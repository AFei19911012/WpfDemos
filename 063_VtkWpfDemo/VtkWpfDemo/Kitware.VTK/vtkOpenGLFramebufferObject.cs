using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLFramebufferObject
/// </summary>
/// <remarks>
///    Internal class which encapsulates OpenGL FramebufferObject
///
/// Before delving into this class it is best to have some background
/// in some OpenGL terms. OpenGL has a notion of a currently
/// bound Framebuffers for drawing and reading. It can be the default
/// framebuffer such as created with a standard window/context or
/// it can be a user created Framebuffer objects. When draw and read
/// commands are invoked, they apply to the current draw and/or read
/// framebuffers.
///
/// A framebuffer consists of color buffers and an optional depth buffer.
/// The FramebufferObject does not hold the memory for these buffers, it
/// just keeps track of what buffers are attached to it. The buffers themselves
/// hold the storage for the pixels/depths.
///
/// In the context of this discussion a buffer can be either a
/// vtkTextureObject (both 2D or a slice of a 3D texture) or
/// a vtkRenderbuffer. In some cases a renderbuffer may be faster
/// or more lightweight but you cannot pass a renderbuffer into
/// a shader for sampling in a later pass like you can a texture.
///
/// You attach these buffers to the Framebuffer using methods
/// such as AddColorAttachment or AddDepthAttachment
/// In normal usage a buffer is Attached to a FramebufferObject
/// and then some or all of the attached buffers are activated for drawing
/// or reading.
///
/// When you have a framebuffer bound along with some buffers attached to it
/// you can then activate specific buffers for drawing or reading. So you
/// have draw and read framebuffer objects (bindings) and then for the currently
/// bound FramebufferObjects you have active draw and read buffers.
///
/// A single FramebufferObject can be bound to both Draw and Read. You
/// cannot assign and activate a TextureObject for drawing on the FO and
/// at the same time pass it in as a Texture to the shader program. That
/// type of operation is very common and must be done in two steps.
///  - Render to the FO with the Texture attached as an active buffer
///  - deactivate the texture obj and then render with the texture obj
///    as a texture passed into the shader
///
/// Typical use cases:
/// The simplest example
///             <code>{.cpp}
/// fbo-&gt;SetContext(renWin);
/// fbo-&gt;SaveCurrentBindingsAndBuffers();
/// fbo-&gt;PopulateFramebuffer(width, height);
///
/// ...
///
/// fbo-&gt;RestorePreviousBindingsAndBuffers();
///             </code>
///
/// If you wish to use a texture you created
///
///             <code>{.cpp}
/// fbo-&gt;SetContext(renWin);
/// fbo-&gt;SaveCurrentBindingsAndBuffers();
/// fbo-&gt;Bind();
/// fbo-&gt;AddColorAttachment(0, vtkTextureObj);
/// fbo-&gt;AddDepthAttachment(); // auto create depth buffer
/// fbo-&gt;ActivateBuffer(0);
///
/// ...
///
/// fbo-&gt;RestorePreviousBindingsAndBuffers();
///             </code>
///
/// If you will be using a FO repeatedly then it is best to create it
/// attach the buffers and then use as needed for example
///
/// Typical use case:
///             <code>{.cpp}
/// // setup the FBO once
/// fbo-&gt;SetContext(renWin);
/// fbo-&gt;SaveCurrentBindingsAndBuffers();
/// fbo-&gt;AddColorAttachment(0, vtkTextureObj);
/// fbo-&gt;AddDepthAttachment(); // auto create depth buffer
/// fbo-&gt;RestorePreviousBindingsAndBuffers();
///
/// // use it many times
/// fbo-&gt;SaveCurrentBindingsAndBuffers();
/// fbo-&gt;Bind();
/// fbo-&gt;ActivateBuffer(0);
/// ... // render here etc
/// fbo-&gt;RestorePreviousBindingsAndBuffers();
///             </code>
///
/// If you with to only bind the framebuffer for drawing or reading there
/// are mode specific versions of some methods that only apply to the
/// mode specified Draw/Read/Both. The mode argument uses OpenGL constants
/// so this class provides convenience methods to return them named
/// GetDrawMode() GetReadMode() and GetBothMode() so that your code
/// does not need to be polluted with OpenGL headers/constants.
///
/// This class replaces both vtkFrameBufferObject and vtkFrameBufferObject2
/// and contins methods from both of them. Most methods from FO2 should
/// work with this class. Just rename FBO2 to FBO and make sure to Save and
/// Restore the bindings and buffers.
/// If you have been using the old FO class, which had comments
/// in the header saying not to use it. Then you are in for a bit more of
/// a conversion but generally it should still be easy. Use the code
/// samples above (or any of the classes in OpenGL2 that currently use FBOs)
/// to guide you. They have all been converted to this class. Where previously
/// a DepthBuffer was automatically created for you, you now need to do it
/// explicitly using AddDepthAttachment().
///
/// Note the capitalization of FramebufferObject
///
/// </remarks>
/// <seealso>
///
/// vtkTextureObject, vtkRenderbufferObject
/// </seealso>
public class vtkOpenGLFramebufferObject : vtkFrameBufferObjectBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLFramebufferObject";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLFramebufferObject()
	{
		MRClassNameKey = "class vtkOpenGLFramebufferObject";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLFramebufferObject"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLFramebufferObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFramebufferObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLFramebufferObject New()
	{
		vtkOpenGLFramebufferObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFramebufferObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLFramebufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLFramebufferObject()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLFramebufferObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_ActivateBuffer_01(HandleRef pThis, uint id);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public void ActivateBuffer(uint id)
	{
		vtkOpenGLFramebufferObject_ActivateBuffer_01(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_ActivateDrawBuffer_02(HandleRef pThis, uint id);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public void ActivateDrawBuffer(uint id)
	{
		vtkOpenGLFramebufferObject_ActivateDrawBuffer_02(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_ActivateDrawBuffers_03(HandleRef pThis, uint n);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public void ActivateDrawBuffers(uint n)
	{
		vtkOpenGLFramebufferObject_ActivateDrawBuffers_03(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_ActivateDrawBuffers_04(HandleRef pThis, IntPtr ids, int n);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public void ActivateDrawBuffers(IntPtr ids, int n)
	{
		vtkOpenGLFramebufferObject_ActivateDrawBuffers_04(GetCppThis(), ids, n);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_ActivateReadBuffer_05(HandleRef pThis, uint id);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public void ActivateReadBuffer(uint id)
	{
		vtkOpenGLFramebufferObject_ActivateReadBuffer_05(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_AddDepthAttachment_06(HandleRef pThis);

	/// <summary>
	/// Directly assign/remove a texture/renderbuffer to depth attachments.
	/// </summary>
	public void AddDepthAttachment()
	{
		vtkOpenGLFramebufferObject_AddDepthAttachment_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_Bind_07(HandleRef pThis);

	/// <summary>
	/// Make the draw frame buffer active.
	/// </summary>
	public void Bind()
	{
		vtkOpenGLFramebufferObject_Bind_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_Bind_08(HandleRef pThis, uint mode);

	/// <summary>
	/// Make the draw frame buffer active.
	/// </summary>
	public void Bind(uint mode)
	{
		vtkOpenGLFramebufferObject_Bind_08(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFramebufferObject_Blit_09(IntPtr srcExt, IntPtr destExt, uint bits, uint mapping);

	/// <summary>
	/// Copy from the currently bound READ FBO to the currently
	/// bound DRAW FBO. The method is static so that one doesn't
	/// need to ccreate an instance when transferring between attachments
	/// in the default FBO.
	/// </summary>
	public static int Blit(IntPtr srcExt, IntPtr destExt, uint bits, uint mapping)
	{
		return vtkOpenGLFramebufferObject_Blit_09(srcExt, destExt, bits, mapping);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFramebufferObject_CheckFrameBufferStatus_10(HandleRef pThis, uint mode);

	/// <summary>
	/// Validate the current FBO configuration (attachments, formats, etc)
	/// prints detected errors to vtkErrorMacro.
	/// </summary>
	public int CheckFrameBufferStatus(uint mode)
	{
		return vtkOpenGLFramebufferObject_CheckFrameBufferStatus_10(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_DeactivateDrawBuffers_11(HandleRef pThis);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public void DeactivateDrawBuffers()
	{
		vtkOpenGLFramebufferObject_DeactivateDrawBuffers_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_DeactivateReadBuffer_12(HandleRef pThis);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public void DeactivateReadBuffer()
	{
		vtkOpenGLFramebufferObject_DeactivateReadBuffer_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFramebufferObject_GetActiveDrawBuffer_13(HandleRef pThis, uint id);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public uint GetActiveDrawBuffer(uint id)
	{
		return vtkOpenGLFramebufferObject_GetActiveDrawBuffer_13(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFramebufferObject_GetActiveReadBuffer_14(HandleRef pThis);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public virtual uint GetActiveReadBuffer()
	{
		return vtkOpenGLFramebufferObject_GetActiveReadBuffer_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFramebufferObject_GetBothMode_15();

	/// <summary>
	/// Download data from the read buffer of the current FBO. These
	/// are low level methods. In the static variant a PBO must be
	/// passed in since we don't have access to a context. The static
	/// method is provided so that one may download from the default
	/// FBO.
	/// </summary>
	public static uint GetBothMode()
	{
		return vtkOpenGLFramebufferObject_GetBothMode_15();
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFramebufferObject_GetContext_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
	/// This does not increase the reference count of the
	/// context to avoid reference loops.
	/// SetContext() may raise an error if the OpenGL context does not support the
	/// required OpenGL extensions.
	/// </summary>
	public vtkOpenGLRenderWindow GetContext()
	{
		vtkOpenGLRenderWindow vtkOpenGLRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFramebufferObject_GetContext_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLRenderWindow2 = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLRenderWindow2.Register(null);
			}
		}
		return vtkOpenGLRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFramebufferObject_GetDrawMode_17();

	/// <summary>
	/// Download data from the read buffer of the current FBO. These
	/// are low level methods. In the static variant a PBO must be
	/// passed in since we don't have access to a context. The static
	/// method is provided so that one may download from the default
	/// FBO.
	/// </summary>
	public static uint GetDrawMode()
	{
		return vtkOpenGLFramebufferObject_GetDrawMode_17();
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFramebufferObject_GetFBOIndex_18(HandleRef pThis);

	/// <summary>
	/// Validate the current FBO configuration (attachments, formats, etc)
	/// return false if the FBO is incomplete. Assigns description a literal
	/// containing a description of the status.
	/// Low level api.
	/// </summary>
	public virtual uint GetFBOIndex()
	{
		return vtkOpenGLFramebufferObject_GetFBOIndex_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFramebufferObject_GetLastSize_19(HandleRef pThis);

	/// <summary>
	/// Dimensions in pixels of the framebuffer.
	/// </summary>
	public override IntPtr GetLastSize()
	{
		return vtkOpenGLFramebufferObject_GetLastSize_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_GetLastSize_20(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Dimensions in pixels of the framebuffer.
	/// </summary>
	public override void GetLastSize(ref int _arg1, ref int _arg2)
	{
		vtkOpenGLFramebufferObject_GetLastSize_20(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_GetLastSize_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Dimensions in pixels of the framebuffer.
	/// </summary>
	public override void GetLastSize(IntPtr _arg)
	{
		vtkOpenGLFramebufferObject_GetLastSize_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFramebufferObject_GetMaximumNumberOfActiveTargets_22(HandleRef pThis);

	/// <summary>
	/// Returns the maximum number of targets that can be rendered to at one time.
	/// This limits the active targets set by SetActiveTargets().
	/// The return value is valid only if GetContext is non-null.
	/// </summary>
	public uint GetMaximumNumberOfActiveTargets()
	{
		return vtkOpenGLFramebufferObject_GetMaximumNumberOfActiveTargets_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFramebufferObject_GetMaximumNumberOfRenderTargets_23(HandleRef pThis);

	/// <summary>
	/// Returns the maximum number of render targets available. This limits the
	/// available attachment points for SetColorAttachment().
	/// The return value is valid only if GetContext is non-null.
	/// </summary>
	public uint GetMaximumNumberOfRenderTargets()
	{
		return vtkOpenGLFramebufferObject_GetMaximumNumberOfRenderTargets_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFramebufferObject_GetMultiSamples_24(HandleRef pThis);

	/// <summary>
	/// Resize all FO attachments
	/// </summary>
	public int GetMultiSamples()
	{
		return vtkOpenGLFramebufferObject_GetMultiSamples_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFramebufferObject_GetNumberOfColorAttachments_25(HandleRef pThis);

	/// <summary>
	/// Return the number of color attachments for the given mode
	/// </summary>
	public int GetNumberOfColorAttachments()
	{
		return vtkOpenGLFramebufferObject_GetNumberOfColorAttachments_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLFramebufferObject_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLFramebufferObject_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLFramebufferObject_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLFramebufferObject_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFramebufferObject_GetReadMode_28();

	/// <summary>
	/// Download data from the read buffer of the current FBO. These
	/// are low level methods. In the static variant a PBO must be
	/// passed in since we don't have access to a context. The static
	/// method is provided so that one may download from the default
	/// FBO.
	/// </summary>
	public static uint GetReadMode()
	{
		return vtkOpenGLFramebufferObject_GetReadMode_28();
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_InitializeViewport_29(HandleRef pThis, int width, int height);

	/// <summary>
	/// Set up ortho viewport with scissor, lighting, blend, and depth
	/// disabled. The method affects the current bound FBO.
	/// </summary>
	public void InitializeViewport(int width, int height)
	{
		vtkOpenGLFramebufferObject_InitializeViewport_29(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFramebufferObject_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLFramebufferObject_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLFramebufferObject_IsSupported_31(HandleRef arg0);

	/// <summary>
	/// Returns if the context supports the required extensions.
	/// Extension will be loaded when the context is set.
	/// </summary>
	public static bool IsSupported(vtkOpenGLRenderWindow arg0)
	{
		return (vtkOpenGLFramebufferObject_IsSupported_31(arg0?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFramebufferObject_IsTypeOf_32(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLFramebufferObject_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFramebufferObject_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLFramebufferObject NewInstance()
	{
		vtkOpenGLFramebufferObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFramebufferObject_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLFramebufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLFramebufferObject_PopulateFramebuffer_35(HandleRef pThis, int width, int height);

	/// <summary>
	/// Convenience method to populate a framebuffer with
	/// attachments created as well. Returns true if a
	/// complete valid Framebuffer was created
	/// </summary>
	public bool PopulateFramebuffer(int width, int height)
	{
		return (vtkOpenGLFramebufferObject_PopulateFramebuffer_35(GetCppThis(), width, height) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLFramebufferObject_PopulateFramebuffer_36(HandleRef pThis, int width, int height, byte useTextures, int numberOfColorAttachments, int colorDataType, byte wantDepthAttachment, int depthBitplanes, int multisamples, byte wantStencilAttachment);

	/// <summary>
	/// Convenience method to populate a framebuffer with
	/// attachments created as well. Returns true if a
	/// complete valid Framebuffer was created
	/// </summary>
	public bool PopulateFramebuffer(int width, int height, bool useTextures, int numberOfColorAttachments, int colorDataType, bool wantDepthAttachment, int depthBitplanes, int multisamples, bool wantStencilAttachment)
	{
		return (vtkOpenGLFramebufferObject_PopulateFramebuffer_36(GetCppThis(), width, height, (byte)(useTextures ? 1u : 0u), numberOfColorAttachments, colorDataType, (byte)(wantDepthAttachment ? 1u : 0u), depthBitplanes, multisamples, (byte)(wantStencilAttachment ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_ReleaseGraphicsResources_37(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Deactivate and UnBind
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkOpenGLFramebufferObject_ReleaseGraphicsResources_37(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_RemoveColorAttachment_38(HandleRef pThis, uint index);

	/// <summary>
	/// Directly assign/remove a texture to color attachments.
	/// </summary>
	public void RemoveColorAttachment(uint index)
	{
		vtkOpenGLFramebufferObject_RemoveColorAttachment_38(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_RemoveColorAttachments_39(HandleRef pThis, uint num);

	/// <summary>
	/// Directly assign/remove a texture to color attachments.
	/// </summary>
	public void RemoveColorAttachments(uint num)
	{
		vtkOpenGLFramebufferObject_RemoveColorAttachments_39(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_RemoveDepthAttachment_40(HandleRef pThis);

	/// <summary>
	/// Directly assign/remove a texture/renderbuffer to depth attachments.
	/// </summary>
	public void RemoveDepthAttachment()
	{
		vtkOpenGLFramebufferObject_RemoveDepthAttachment_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_Resize_41(HandleRef pThis, int width, int height);

	/// <summary>
	/// Resize all FO attachments
	/// </summary>
	public void Resize(int width, int height)
	{
		vtkOpenGLFramebufferObject_Resize_41(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_RestorePreviousBindingsAndBuffers_42(HandleRef pThis);

	/// <summary>
	/// Store/Restore the current framebuffer bindings and buffers.
	/// </summary>
	public void RestorePreviousBindingsAndBuffers()
	{
		vtkOpenGLFramebufferObject_RestorePreviousBindingsAndBuffers_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_RestorePreviousBindingsAndBuffers_43(HandleRef pThis, uint mode);

	/// <summary>
	/// Store/Restore the current framebuffer bindings and buffers.
	/// </summary>
	public void RestorePreviousBindingsAndBuffers(uint mode)
	{
		vtkOpenGLFramebufferObject_RestorePreviousBindingsAndBuffers_43(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFramebufferObject_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLFramebufferObject SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLFramebufferObject vtkOpenGLFramebufferObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFramebufferObject_SafeDownCast_44(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLFramebufferObject2 = (vtkOpenGLFramebufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLFramebufferObject2.Register(null);
			}
		}
		return vtkOpenGLFramebufferObject2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_SaveCurrentBindingsAndBuffers_45(HandleRef pThis);

	/// <summary>
	/// Store/Restore the current framebuffer bindings and buffers.
	/// </summary>
	public void SaveCurrentBindingsAndBuffers()
	{
		vtkOpenGLFramebufferObject_SaveCurrentBindingsAndBuffers_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_SaveCurrentBindingsAndBuffers_46(HandleRef pThis, uint mode);

	/// <summary>
	/// Store/Restore the current framebuffer bindings and buffers.
	/// </summary>
	public void SaveCurrentBindingsAndBuffers(uint mode)
	{
		vtkOpenGLFramebufferObject_SaveCurrentBindingsAndBuffers_46(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_SetContext_47(HandleRef pThis, HandleRef context);

	/// <summary>
	/// Get/Set the context. Context must be a vtkOpenGLRenderWindow.
	/// This does not increase the reference count of the
	/// context to avoid reference loops.
	/// SetContext() may raise an error if the OpenGL context does not support the
	/// required OpenGL extensions.
	/// </summary>
	public void SetContext(vtkRenderWindow context)
	{
		vtkOpenGLFramebufferObject_SetContext_47(GetCppThis(), context?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLFramebufferObject_Start_48(HandleRef pThis, int width, int height);

	/// <summary>
	/// User must take care that width/height match the dimensions of
	/// the user defined texture attachments.
	/// This method makes the "active buffers" the buffers that will get drawn
	/// into by subsequent drawing calls.
	/// Note that this does not clear the render buffers i.e. no glClear() calls
	/// are made by either of these methods. It's up to the caller to clear the
	/// buffers if needed.
	/// </summary>
	public bool Start(int width, int height)
	{
		return (vtkOpenGLFramebufferObject_Start_48(GetCppThis(), width, height) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLFramebufferObject_StartNonOrtho_49(HandleRef pThis, int width, int height);

	/// <summary>
	/// User must take care that width/height match the dimensions of
	/// the user defined texture attachments.
	/// This method makes the "active buffers" the buffers that will get drawn
	/// into by subsequent drawing calls.
	/// Note that this does not clear the render buffers i.e. no glClear() calls
	/// are made by either of these methods. It's up to the caller to clear the
	/// buffers if needed.
	/// </summary>
	public bool StartNonOrtho(int width, int height)
	{
		return (vtkOpenGLFramebufferObject_StartNonOrtho_49(GetCppThis(), width, height) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_UnBind_50(HandleRef pThis);

	/// <summary>
	/// Unbind this buffer
	/// </summary>
	public void UnBind()
	{
		vtkOpenGLFramebufferObject_UnBind_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFramebufferObject_UnBind_51(HandleRef pThis, uint mode);

	/// <summary>
	/// Unbind this buffer
	/// </summary>
	public void UnBind(uint mode)
	{
		vtkOpenGLFramebufferObject_UnBind_51(GetCppThis(), mode);
	}
}
