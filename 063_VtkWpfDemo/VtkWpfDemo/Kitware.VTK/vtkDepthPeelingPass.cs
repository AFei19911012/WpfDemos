using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDepthPeelingPass
/// </summary>
/// <remarks>
///    Implement Depth Peeling for use within a framebuffer pass
///
/// Note that this implementation is used as a fallback for drivers that
/// don't support floating point textures. Most renderings will use the subclass
/// vtkDualDepthPeelingPass instead.
///
/// Render the translucent polygonal geometry of a scene without sorting
/// polygons in the view direction.
///
/// This pass expects an initialized depth buffer and color buffer.
/// Initialized buffers means they have been cleared with farest z-value and
/// background color/gradient/transparent color.
/// An opaque pass may have been performed right after the initialization.
///
/// The depth peeling algorithm works by rendering the translucent polygonal
/// geometry multiple times (once for each peel). The actually rendering of
/// the translucent polygonal geometry is performed by its delegate
/// TranslucentPass. This delegate is therefore used multiple times.
///
/// Its delegate is usually set to a vtkTranslucentPass.
///
/// This implementation makes use of textures and is suitable for ES3
/// For ES3 it must be embedded within a pass that makes use of framebuffers
/// so that the required OpaqueZTexture and OpaqueRGBATexture can be
/// passed from the outer framebuffer pass. For OpenGL ES3 be aware the
/// occlusion ratio test is not supported. The maximum number of peels
/// is used instead so set it to a reasonable value. For many scenes
/// a value of 4 or 5 will work well.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass, vtkTranslucentPass, vtkFramebufferPass
/// </seealso>
public class vtkDepthPeelingPass : vtkOpenGLRenderPass
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDepthPeelingPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDepthPeelingPass()
	{
		MRClassNameKey = "class vtkDepthPeelingPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthPeelingPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDepthPeelingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthPeelingPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDepthPeelingPass New()
	{
		vtkDepthPeelingPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthPeelingPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDepthPeelingPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDepthPeelingPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDepthPeelingPass_GetMaximumNumberOfPeels_01(HandleRef pThis);

	/// <summary>
	/// In case of depth peeling, define the maximum number of peeling layers.
	/// Initial value is 4. A special value of 0 means no maximum limit.
	/// It has to be a positive value.
	/// </summary>
	public virtual int GetMaximumNumberOfPeels()
	{
		return vtkDepthPeelingPass_GetMaximumNumberOfPeels_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDepthPeelingPass_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDepthPeelingPass_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDepthPeelingPass_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDepthPeelingPass_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDepthPeelingPass_GetOcclusionRatio_04(HandleRef pThis);

	/// <summary>
	/// In case of use of depth peeling technique for rendering translucent
	/// material, define the threshold under which the algorithm stops to
	/// iterate over peel layers. This is the ratio of the number of pixels
	/// that have been touched by the last layer over the total number of pixels
	/// of the viewport area.
	/// Initial value is 0.0, meaning rendering have to be exact. Greater values
	/// may speed-up the rendering with small impact on the quality.
	/// </summary>
	public virtual double GetOcclusionRatio()
	{
		return vtkDepthPeelingPass_GetOcclusionRatio_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDepthPeelingPass_GetOcclusionRatioMaxValue_05(HandleRef pThis);

	/// <summary>
	/// In case of use of depth peeling technique for rendering translucent
	/// material, define the threshold under which the algorithm stops to
	/// iterate over peel layers. This is the ratio of the number of pixels
	/// that have been touched by the last layer over the total number of pixels
	/// of the viewport area.
	/// Initial value is 0.0, meaning rendering have to be exact. Greater values
	/// may speed-up the rendering with small impact on the quality.
	/// </summary>
	public virtual double GetOcclusionRatioMaxValue()
	{
		return vtkDepthPeelingPass_GetOcclusionRatioMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDepthPeelingPass_GetOcclusionRatioMinValue_06(HandleRef pThis);

	/// <summary>
	/// In case of use of depth peeling technique for rendering translucent
	/// material, define the threshold under which the algorithm stops to
	/// iterate over peel layers. This is the ratio of the number of pixels
	/// that have been touched by the last layer over the total number of pixels
	/// of the viewport area.
	/// Initial value is 0.0, meaning rendering have to be exact. Greater values
	/// may speed-up the rendering with small impact on the quality.
	/// </summary>
	public virtual double GetOcclusionRatioMinValue()
	{
		return vtkDepthPeelingPass_GetOcclusionRatioMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthPeelingPass_GetTranslucentPass_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Delegate for rendering the translucent polygonal geometry.
	/// If it is NULL, nothing will be rendered and a warning will be emitted.
	/// It is usually set to a vtkTranslucentPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual vtkRenderPass GetTranslucentPass()
	{
		vtkRenderPass vtkRenderPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthPeelingPass_GetTranslucentPass_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderPass2 = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderPass2.Register(null);
			}
		}
		return vtkRenderPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthPeelingPass_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDepthPeelingPass_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDepthPeelingPass_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDepthPeelingPass_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthPeelingPass_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDepthPeelingPass NewInstance()
	{
		vtkDepthPeelingPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthPeelingPass_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDepthPeelingPass_PostReplaceShaderValues_12(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// In case of depth peeling, define the maximum number of peeling layers.
	/// Initial value is 4. A special value of 0 means no maximum limit.
	/// It has to be a positive value.
	/// </summary>
	public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkDepthPeelingPass_PostReplaceShaderValues_12(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthPeelingPass_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own
	/// resources.
	/// \pre w_exists: w!=0
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkDepthPeelingPass_ReleaseGraphicsResources_13(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDepthPeelingPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDepthPeelingPass SafeDownCast(vtkObjectBase o)
	{
		vtkDepthPeelingPass vtkDepthPeelingPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDepthPeelingPass_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDepthPeelingPass2 = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDepthPeelingPass2.Register(null);
			}
		}
		return vtkDepthPeelingPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthPeelingPass_SetDepthFormat_15(HandleRef pThis, int _arg);

	/// <summary>
	///  Set the format to use for the depth texture
	/// e.g. vtkTextureObject::Float32
	/// </summary>
	public virtual void SetDepthFormat(int _arg)
	{
		vtkDepthPeelingPass_SetDepthFormat_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthPeelingPass_SetMaximumNumberOfPeels_16(HandleRef pThis, int _arg);

	/// <summary>
	/// In case of depth peeling, define the maximum number of peeling layers.
	/// Initial value is 4. A special value of 0 means no maximum limit.
	/// It has to be a positive value.
	/// </summary>
	public virtual void SetMaximumNumberOfPeels(int _arg)
	{
		vtkDepthPeelingPass_SetMaximumNumberOfPeels_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthPeelingPass_SetOcclusionRatio_17(HandleRef pThis, double _arg);

	/// <summary>
	/// In case of use of depth peeling technique for rendering translucent
	/// material, define the threshold under which the algorithm stops to
	/// iterate over peel layers. This is the ratio of the number of pixels
	/// that have been touched by the last layer over the total number of pixels
	/// of the viewport area.
	/// Initial value is 0.0, meaning rendering have to be exact. Greater values
	/// may speed-up the rendering with small impact on the quality.
	/// </summary>
	public virtual void SetOcclusionRatio(double _arg)
	{
		vtkDepthPeelingPass_SetOcclusionRatio_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDepthPeelingPass_SetTranslucentPass_18(HandleRef pThis, HandleRef translucentPass);

	/// <summary>
	/// Delegate for rendering the translucent polygonal geometry.
	/// If it is NULL, nothing will be rendered and a warning will be emitted.
	/// It is usually set to a vtkTranslucentPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual void SetTranslucentPass(vtkRenderPass translucentPass)
	{
		vtkDepthPeelingPass_SetTranslucentPass_18(GetCppThis(), translucentPass?.GetCppThis() ?? default(HandleRef));
	}
}
