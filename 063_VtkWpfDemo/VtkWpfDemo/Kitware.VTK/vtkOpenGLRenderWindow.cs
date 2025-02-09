using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLRenderWindow
/// </summary>
/// <remarks>
///    OpenGL rendering window
///
/// vtkOpenGLRenderWindow is a concrete implementation of the abstract class
/// vtkRenderWindow. vtkOpenGLRenderer interfaces to the OpenGL graphics
/// library. Application programmers should normally use vtkRenderWindow
/// instead of the OpenGL specific version.
/// </remarks>
public abstract class vtkOpenGLRenderWindow : vtkRenderWindow
{
	/// <summary>
	/// Define how the resulting image should be blitted when at the end of the Frame() call if
	/// SwapBuffers is true
	/// </summary>
	public enum FrameBlitModes
	{
		/// <summary>enum member</summary>
		BlitToCurrent = 1,
		/// <summary>enum member</summary>
		BlitToHardware = 0,
		/// <summary>enum member</summary>
		NoBlit = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLRenderWindow()
	{
		MRClassNameKey = "class vtkOpenGLRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkOpenGLRenderWindow_BlitDisplayFramebuffer_01(HandleRef pThis);

	/// <summary>
	/// Blit a display framebuffer into a currently bound draw destination
	/// </summary>
	public void BlitDisplayFramebuffer()
	{
		vtkOpenGLRenderWindow_BlitDisplayFramebuffer_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_BlitDisplayFramebuffer_02(HandleRef pThis, int right, int srcX, int srcY, int srcWidth, int srcHeight, int destX, int destY, int destWidth, int destHeight, int bufferMode, int interpolation);

	/// <summary>
	/// Blit a display buffer into a currently bound draw destination
	/// </summary>
	public void BlitDisplayFramebuffer(int right, int srcX, int srcY, int srcWidth, int srcHeight, int destX, int destY, int destWidth, int destHeight, int bufferMode, int interpolation)
	{
		vtkOpenGLRenderWindow_BlitDisplayFramebuffer_02(GetCppThis(), right, srcX, srcY, srcWidth, srcHeight, destX, destY, destWidth, destHeight, bufferMode, interpolation);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_BlitToRenderFramebuffer_03(HandleRef pThis, byte includeDepth);

	/// <summary>
	/// Blit the currently bound read buffer to the renderbuffer. This is useful for
	/// taking rendering from an external system and then having VTK draw on top of it.
	/// </summary>
	public void BlitToRenderFramebuffer(bool includeDepth)
	{
		vtkOpenGLRenderWindow_BlitToRenderFramebuffer_03(GetCppThis(), (byte)(includeDepth ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_BlitToRenderFramebuffer_04(HandleRef pThis, int srcX, int srcY, int srcWidth, int srcHeight, int destX, int destY, int destWidth, int destHeight, int bufferMode, int interpolation);

	/// <summary>
	/// Blit the currently bound read buffer to the renderbuffer. This is useful for
	/// taking rendering from an external system and then having VTK draw on top of it.
	/// </summary>
	public void BlitToRenderFramebuffer(int srcX, int srcY, int srcWidth, int srcHeight, int destX, int destY, int destWidth, int destHeight, int bufferMode, int interpolation)
	{
		vtkOpenGLRenderWindow_BlitToRenderFramebuffer_04(GetCppThis(), srcX, srcY, srcWidth, srcHeight, destX, destY, destWidth, destHeight, bufferMode, interpolation);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_DrawPixels_05(HandleRef pThis, int x1, int y1, int x2, int y2, int numComponents, int dataType, IntPtr data);

	/// <summary>
	/// Replacement for the old glDrawPixels function
	/// </summary>
	public virtual void DrawPixels(int x1, int y1, int x2, int y2, int numComponents, int dataType, IntPtr data)
	{
		vtkOpenGLRenderWindow_DrawPixels_05(GetCppThis(), x1, y1, x2, y2, numComponents, dataType, data);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_DrawPixels_06(HandleRef pThis, int dstXmin, int dstYmin, int dstXmax, int dstYmax, int srcXmin, int srcYmin, int srcXmax, int srcYmax, int srcWidth, int srcHeight, int numComponents, int dataType, IntPtr data);

	/// <summary>
	/// Replacement for the old glDrawPixels function, but it allows
	/// for scaling the data and using only part of the texture
	/// </summary>
	public virtual void DrawPixels(int dstXmin, int dstYmin, int dstXmax, int dstYmax, int srcXmin, int srcYmin, int srcXmax, int srcYmax, int srcWidth, int srcHeight, int numComponents, int dataType, IntPtr data)
	{
		vtkOpenGLRenderWindow_DrawPixels_06(GetCppThis(), dstXmin, dstYmin, dstXmax, dstYmax, srcXmin, srcYmin, srcXmax, srcYmax, srcWidth, srcHeight, numComponents, dataType, data);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_DrawPixels_07(HandleRef pThis, int srcWidth, int srcHeight, int numComponents, int dataType, IntPtr data);

	/// <summary>
	/// Replacement for the old glDrawPixels function.  This simple version draws all
	/// the data to the entire current viewport scaling as needed.
	/// </summary>
	public virtual void DrawPixels(int srcWidth, int srcHeight, int numComponents, int dataType, IntPtr data)
	{
		vtkOpenGLRenderWindow_DrawPixels_07(GetCppThis(), srcWidth, srcHeight, numComponents, dataType, data);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_End_08(HandleRef pThis);

	/// <summary>
	/// Update the system, if needed, at end of render process
	/// </summary>
	public override void End()
	{
		vtkOpenGLRenderWindow_End_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_Frame_09(HandleRef pThis);

	/// <summary>
	/// A termination method performed at the end of the rendering process
	/// to do things like swapping buffers (if necessary) or similar actions.
	/// </summary>
	public override void Frame()
	{
		vtkOpenGLRenderWindow_Frame_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_FramebufferFlipYOff_10(HandleRef pThis);

	/// <summary>
	/// Enable/Disable flipping the Y axis of the rendered texture.
	/// </summary>
	public virtual void FramebufferFlipYOff()
	{
		vtkOpenGLRenderWindow_FramebufferFlipYOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_FramebufferFlipYOn_11(HandleRef pThis);

	/// <summary>
	/// Enable/Disable flipping the Y axis of the rendered texture.
	/// </summary>
	public virtual void FramebufferFlipYOn()
	{
		vtkOpenGLRenderWindow_FramebufferFlipYOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderWindow_GetBufferNeedsResolving_12(HandleRef pThis);

	/// <summary>
	/// Intermediate method performs operations required between the rendering
	/// of the left and right eye.
	/// </summary>
	public bool GetBufferNeedsResolving()
	{
		return (vtkOpenGLRenderWindow_GetBufferNeedsResolving_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetColorBufferInternalFormat_13(HandleRef pThis, int attachmentPoint);

	/// <summary>
	/// Get the internal format of current attached texture or render buffer.
	/// attachmentPoint is the index of attachment.
	/// Returns 0 if not able to determine.
	/// </summary>
	public int GetColorBufferInternalFormat(int attachmentPoint)
	{
		return vtkOpenGLRenderWindow_GetColorBufferInternalFormat_13(GetCppThis(), attachmentPoint);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetColorBufferSizes_14(HandleRef pThis, IntPtr rgba);

	/// <summary>
	/// Get the size of the color buffer.
	/// Returns 0 if not able to determine otherwise sets R G B and A into buffer.
	/// </summary>
	public override int GetColorBufferSizes(IntPtr rgba)
	{
		return vtkOpenGLRenderWindow_GetColorBufferSizes_14(GetCppThis(), rgba);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkOpenGLRenderWindow_GetContextCreationTime_15(HandleRef pThis);

	/// <summary>
	/// Get the time when the OpenGL context was created.
	/// </summary>
	public virtual ulong GetContextCreationTime()
	{
		return vtkOpenGLRenderWindow_GetContextCreationTime_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetDefaultTextureInternalFormat_16(HandleRef pThis, int vtktype, int numComponents, byte needInteger, byte needFloat, byte needSRGB);

	/// <summary>
	/// Get a mapping of vtk data types to native texture formats for this window
	/// we put this on the RenderWindow so that every texture does not have to
	/// build these structures themselves
	/// </summary>
	public int GetDefaultTextureInternalFormat(int vtktype, int numComponents, bool needInteger, bool needFloat, bool needSRGB)
	{
		return vtkOpenGLRenderWindow_GetDefaultTextureInternalFormat_16(GetCppThis(), vtktype, numComponents, (byte)(needInteger ? 1u : 0u), (byte)(needFloat ? 1u : 0u), (byte)(needSRGB ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetDepthBufferSize_17(HandleRef pThis);

	/// <summary>
	/// Get the size of the depth buffer.
	/// </summary>
	public override int GetDepthBufferSize()
	{
		return vtkOpenGLRenderWindow_GetDepthBufferSize_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_GetDisplayFramebuffer_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the display framebuffer object.
	/// </summary>
	public virtual vtkOpenGLFramebufferObject GetDisplayFramebuffer()
	{
		vtkOpenGLFramebufferObject vtkOpenGLFramebufferObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderWindow_GetDisplayFramebuffer_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern FrameBlitModes vtkOpenGLRenderWindow_GetFrameBlitMode_19(HandleRef pThis);

	/// <summary>
	/// SetGet how to handle blits at the end of a Frame() call.
	/// Only happens when SwapBuffers is true.
	/// </summary>
	public virtual FrameBlitModes GetFrameBlitMode()
	{
		return vtkOpenGLRenderWindow_GetFrameBlitMode_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern FrameBlitModes vtkOpenGLRenderWindow_GetFrameBlitModeMaxValue_20(HandleRef pThis);

	/// <summary>
	/// SetGet how to handle blits at the end of a Frame() call.
	/// Only happens when SwapBuffers is true.
	/// </summary>
	public virtual FrameBlitModes GetFrameBlitModeMaxValue()
	{
		return vtkOpenGLRenderWindow_GetFrameBlitModeMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern FrameBlitModes vtkOpenGLRenderWindow_GetFrameBlitModeMinValue_21(HandleRef pThis);

	/// <summary>
	/// SetGet how to handle blits at the end of a Frame() call.
	/// Only happens when SwapBuffers is true.
	/// </summary>
	public virtual FrameBlitModes GetFrameBlitModeMinValue()
	{
		return vtkOpenGLRenderWindow_GetFrameBlitModeMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderWindow_GetFramebufferFlipY_22(HandleRef pThis);

	/// <summary>
	/// Enable/Disable flipping the Y axis of the rendered texture.
	/// </summary>
	public virtual bool GetFramebufferFlipY()
	{
		return (vtkOpenGLRenderWindow_GetFramebufferFlipY_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetGlobalMaximumNumberOfMultiSamples_23();

	/// <summary>
	/// Set/Get the maximum number of multisamples
	/// </summary>
	public static int GetGlobalMaximumNumberOfMultiSamples()
	{
		return vtkOpenGLRenderWindow_GetGlobalMaximumNumberOfMultiSamples_23();
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLRenderWindow_GetMaximumHardwareLineWidth_24(HandleRef pThis);

	/// <summary>
	/// Return the largest line width supported by the hardware
	/// </summary>
	public virtual float GetMaximumHardwareLineWidth()
	{
		return vtkOpenGLRenderWindow_GetMaximumHardwareLineWidth_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetNoiseTextureUnit_25(HandleRef pThis);

	/// <summary>
	/// Set the number of vertical syncs required between frames.
	/// A value of 0 means swap buffers as quickly as possible
	/// regardless of the vertical refresh. A value of 1 means swap
	/// buffers in sync with the vertical refresh to eliminate tearing.
	/// A value of -1 means use a value of 1 unless we missed a frame
	/// in which case swap immediately. Returns true if the call
	/// succeeded.
	/// </summary>
	public int GetNoiseTextureUnit()
	{
		return vtkOpenGLRenderWindow_GetNoiseTextureUnit_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderWindow_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLRenderWindow_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkOpenGLRenderWindow_GetOpenGLSupportMessage_28(HandleRef pThis);

	/// <summary>
	/// Return a message profiding additional details about the
	/// results of calling SupportsOpenGL()  This can be used
	/// to retrieve more specifics about what failed
	/// </summary>
	public string GetOpenGLSupportMessage()
	{
		return vtkOpenGLRenderWindow_GetOpenGLSupportMessage_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_GetOpenGLVersion_29(HandleRef pThis, ref int major, ref int minor);

	/// <summary>
	/// Get the major and minor version numbers of the OpenGL context we are using
	/// ala 3.2, 3.3, 4.0, etc... returns 0,0 if opengl has not been initialized
	/// yet
	/// </summary>
	public void GetOpenGLVersion(ref int major, ref int minor)
	{
		vtkOpenGLRenderWindow_GetOpenGLVersion_29(GetCppThis(), ref major, ref minor);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_GetPixelData_30(HandleRef pThis, int x, int y, int x2, int y2, int front, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBRGB...
	/// front in this context indicates that the read should come from the
	/// display buffer versus the render buffer
	/// </summary>
	public override IntPtr GetPixelData(int x, int y, int x2, int y2, int front, int right)
	{
		return vtkOpenGLRenderWindow_GetPixelData_30(GetCppThis(), x, y, x2, y2, front, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetPixelData_31(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBRGB...
	/// front in this context indicates that the read should come from the
	/// display buffer versus the render buffer
	/// </summary>
	public override int GetPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray data, int right)
	{
		return vtkOpenGLRenderWindow_GetPixelData_31(GetCppThis(), x, y, x2, y2, front, data?.GetCppThis() ?? default(HandleRef), right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_GetRGBACharPixelData_32(HandleRef pThis, int x, int y, int x2, int y2, int front, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override IntPtr GetRGBACharPixelData(int x, int y, int x2, int y2, int front, int right)
	{
		return vtkOpenGLRenderWindow_GetRGBACharPixelData_32(GetCppThis(), x, y, x2, y2, front, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetRGBACharPixelData_33(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray data, int right)
	{
		return vtkOpenGLRenderWindow_GetRGBACharPixelData_33(GetCppThis(), x, y, x2, y2, front, data?.GetCppThis() ?? default(HandleRef), right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_GetRGBAPixelData_34(HandleRef pThis, int x, int y, int x2, int y2, int front, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override IntPtr GetRGBAPixelData(int x, int y, int x2, int y2, int front, int right)
	{
		return vtkOpenGLRenderWindow_GetRGBAPixelData_34(GetCppThis(), x, y, x2, y2, front, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetRGBAPixelData_35(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray data, int right)
	{
		return vtkOpenGLRenderWindow_GetRGBAPixelData_35(GetCppThis(), x, y, x2, y2, front, data?.GetCppThis() ?? default(HandleRef), right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_GetRenderFramebuffer_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the render framebuffer object.
	/// </summary>
	public virtual vtkOpenGLFramebufferObject GetRenderFramebuffer()
	{
		vtkOpenGLFramebufferObject vtkOpenGLFramebufferObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderWindow_GetRenderFramebuffer_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkOpenGLRenderWindow_GetRenderingBackend_37(HandleRef pThis);

	/// <summary>
	/// What rendering backend has the user requested
	/// </summary>
	public override string GetRenderingBackend()
	{
		return Marshal.PtrToStringAnsi(vtkOpenGLRenderWindow_GetRenderingBackend_37(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_GetTQuad2DVBO_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the number of vertical syncs required between frames.
	/// A value of 0 means swap buffers as quickly as possible
	/// regardless of the vertical refresh. A value of 1 means swap
	/// buffers in sync with the vertical refresh to eliminate tearing.
	/// A value of -1 means use a value of 1 unless we missed a frame
	/// in which case swap immediately. Returns true if the call
	/// succeeded.
	/// </summary>
	public vtkOpenGLBufferObject GetTQuad2DVBO()
	{
		vtkOpenGLBufferObject vtkOpenGLBufferObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderWindow_GetTQuad2DVBO_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLBufferObject2 = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLBufferObject2.Register(null);
			}
		}
		return vtkOpenGLBufferObject2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderWindow_GetUsingSRGBColorSpace_39(HandleRef pThis);

	/// <summary>
	/// Is this window/fo in sRGB colorspace
	/// </summary>
	public bool GetUsingSRGBColorSpace()
	{
		return (vtkOpenGLRenderWindow_GetUsingSRGBColorSpace_39(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_GetZbufferData_40(HandleRef pThis, int x1, int y1, int x2, int y2);

	/// <summary>
	/// Set/Get the zbuffer data from an image
	/// </summary>
	public override IntPtr GetZbufferData(int x1, int y1, int x2, int y2)
	{
		return vtkOpenGLRenderWindow_GetZbufferData_40(GetCppThis(), x1, y1, x2, y2);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetZbufferData_41(HandleRef pThis, int x1, int y1, int x2, int y2, IntPtr z);

	/// <summary>
	/// Set/Get the zbuffer data from an image
	/// </summary>
	public override int GetZbufferData(int x1, int y1, int x2, int y2, IntPtr z)
	{
		return vtkOpenGLRenderWindow_GetZbufferData_41(GetCppThis(), x1, y1, x2, y2, z);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_GetZbufferData_42(HandleRef pThis, int x1, int y1, int x2, int y2, HandleRef buffer);

	/// <summary>
	/// Set/Get the zbuffer data from an image
	/// </summary>
	public override int GetZbufferData(int x1, int y1, int x2, int y2, vtkFloatArray buffer)
	{
		return vtkOpenGLRenderWindow_GetZbufferData_42(GetCppThis(), x1, y1, x2, y2, buffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_Initialize_43(HandleRef pThis);

	/// <summary>
	/// Initialize the rendering window.  This will setup all system-specific
	/// resources.  This method and Finalize() must be symmetric and it
	/// should be possible to call them multiple times, even changing WindowId
	/// in-between.  This is what WindowRemap does.
	/// </summary>
	public virtual void Initialize()
	{
		vtkOpenGLRenderWindow_Initialize_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderWindow_InitializeFromCurrentContext_44(HandleRef pThis);

	/// <summary>
	/// Initialize the render window from the information associated
	/// with the currently activated OpenGL context.
	/// </summary>
	public override bool InitializeFromCurrentContext()
	{
		return (vtkOpenGLRenderWindow_InitializeFromCurrentContext_44(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_IsA_45(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLRenderWindow_IsA_45(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderWindow_IsPointSpriteBugPresent_46(HandleRef pThis);

	/// <summary>
	/// Returns true if driver has an
	/// EGL/OpenGL bug that makes vtkChartsCoreCxx-TestChartDoubleColors and other tests to fail
	/// because point sprites don't work correctly (gl_PointCoord is undefined) unless
	/// glEnable(GL_POINT_SPRITE)
	/// </summary>
	public virtual bool IsPointSpriteBugPresent()
	{
		return (vtkOpenGLRenderWindow_IsPointSpriteBugPresent_46(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_IsTypeOf_47(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLRenderWindow_IsTypeOf_47(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLRenderWindow NewInstance()
	{
		vtkOpenGLRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderWindow_NewInstance_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_OpenGLInit_49(HandleRef pThis);

	/// <summary>
	/// Initialize OpenGL for this window.
	/// </summary>
	public virtual void OpenGLInit()
	{
		vtkOpenGLRenderWindow_OpenGLInit_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_OpenGLInitContext_50(HandleRef pThis);

	/// <summary>
	/// Initialize OpenGL for this window.
	/// </summary>
	public virtual void OpenGLInitContext()
	{
		vtkOpenGLRenderWindow_OpenGLInitContext_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_OpenGLInitState_51(HandleRef pThis);

	/// <summary>
	/// Initialize OpenGL for this window.
	/// </summary>
	public virtual void OpenGLInitState()
	{
		vtkOpenGLRenderWindow_OpenGLInitState_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_PopContext_52(HandleRef pThis);

	/// <summary>
	/// Ability to push and pop this window's context
	/// as the current context. The idea being to
	/// if needed make this window's context current
	/// and when done releasing resources restore
	/// the prior context.  The default implementation
	/// here is only meant as a backup for subclasses
	/// that lack a proper implementation.
	/// </summary>
	public virtual void PopContext()
	{
		vtkOpenGLRenderWindow_PopContext_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_PushContext_53(HandleRef pThis);

	/// <summary>
	/// Ability to push and pop this window's context
	/// as the current context. The idea being to
	/// if needed make this window's context current
	/// and when done releasing resources restore
	/// the prior context.  The default implementation
	/// here is only meant as a backup for subclasses
	/// that lack a proper implementation.
	/// </summary>
	public virtual void PushContext()
	{
		vtkOpenGLRenderWindow_PushContext_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_ReleaseGraphicsResources_54(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Free up any graphics resources associated with this window
	/// a value of NULL means the context may already be destroyed
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkOpenGLRenderWindow_ReleaseGraphicsResources_54(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_ReleaseRGBAPixelData_55(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override void ReleaseRGBAPixelData(IntPtr data)
	{
		vtkOpenGLRenderWindow_ReleaseRGBAPixelData_55(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_Render_56(HandleRef pThis);

	/// <summary>
	/// Handle opengl specific code and calls superclass
	/// </summary>
	public override void Render()
	{
		vtkOpenGLRenderWindow_Render_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_ReportCapabilities_57(HandleRef pThis);

	/// <summary>
	/// Get report of capabilities for the render window
	/// </summary>
	public override string ReportCapabilities()
	{
		return Marshal.PtrToStringAnsi(vtkOpenGLRenderWindow_ReportCapabilities_57(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderWindow_SafeDownCast_58(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLRenderWindow vtkOpenGLRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderWindow_SafeDownCast_58(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOpenGLRenderWindow_SetFrameBlitMode_59(HandleRef pThis, FrameBlitModes _arg);

	/// <summary>
	/// SetGet how to handle blits at the end of a Frame() call.
	/// Only happens when SwapBuffers is true.
	/// </summary>
	public virtual void SetFrameBlitMode(FrameBlitModes _arg)
	{
		vtkOpenGLRenderWindow_SetFrameBlitMode_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_SetFrameBlitModeToBlitToCurrent_60(HandleRef pThis);

	/// <summary>
	/// SetGet how to handle blits at the end of a Frame() call.
	/// Only happens when SwapBuffers is true.
	/// </summary>
	public void SetFrameBlitModeToBlitToCurrent()
	{
		vtkOpenGLRenderWindow_SetFrameBlitModeToBlitToCurrent_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_SetFrameBlitModeToBlitToHardware_61(HandleRef pThis);

	/// <summary>
	/// SetGet how to handle blits at the end of a Frame() call.
	/// Only happens when SwapBuffers is true.
	/// </summary>
	public void SetFrameBlitModeToBlitToHardware()
	{
		vtkOpenGLRenderWindow_SetFrameBlitModeToBlitToHardware_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_SetFrameBlitModeToNoBlit_62(HandleRef pThis);

	/// <summary>
	/// SetGet how to handle blits at the end of a Frame() call.
	/// Only happens when SwapBuffers is true.
	/// </summary>
	public void SetFrameBlitModeToNoBlit()
	{
		vtkOpenGLRenderWindow_SetFrameBlitModeToNoBlit_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_SetFramebufferFlipY_63(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/Disable flipping the Y axis of the rendered texture.
	/// </summary>
	public virtual void SetFramebufferFlipY(bool _arg)
	{
		vtkOpenGLRenderWindow_SetFramebufferFlipY_63(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_SetGlobalMaximumNumberOfMultiSamples_64(int val);

	/// <summary>
	/// Set/Get the maximum number of multisamples
	/// </summary>
	public static void SetGlobalMaximumNumberOfMultiSamples(int val)
	{
		vtkOpenGLRenderWindow_SetGlobalMaximumNumberOfMultiSamples_64(val);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SetPixelData_65(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBRGB...
	/// front in this context indicates that the read should come from the
	/// display buffer versus the render buffer
	/// </summary>
	public override int SetPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int right)
	{
		return vtkOpenGLRenderWindow_SetPixelData_65(GetCppThis(), x, y, x2, y2, data, front, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SetPixelData_66(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBRGB...
	/// front in this context indicates that the read should come from the
	/// display buffer versus the render buffer
	/// </summary>
	public override int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray data, int front, int right)
	{
		return vtkOpenGLRenderWindow_SetPixelData_66(GetCppThis(), x, y, x2, y2, data?.GetCppThis() ?? default(HandleRef), front, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SetRGBACharPixelData_67(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int blend, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override int SetRGBACharPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int blend, int right)
	{
		return vtkOpenGLRenderWindow_SetRGBACharPixelData_67(GetCppThis(), x, y, x2, y2, data, front, blend, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SetRGBACharPixelData_68(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int blend, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray data, int front, int blend, int right)
	{
		return vtkOpenGLRenderWindow_SetRGBACharPixelData_68(GetCppThis(), x, y, x2, y2, data?.GetCppThis() ?? default(HandleRef), front, blend, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SetRGBAPixelData_69(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int blend, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override int SetRGBAPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int blend, int right)
	{
		return vtkOpenGLRenderWindow_SetRGBAPixelData_69(GetCppThis(), x, y, x2, y2, data, front, blend, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SetRGBAPixelData_70(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int blend, int right);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBARGBA...
	/// </summary>
	public override int SetRGBAPixelData(int x, int y, int x2, int y2, vtkFloatArray data, int front, int blend, int right)
	{
		return vtkOpenGLRenderWindow_SetRGBAPixelData_70(GetCppThis(), x, y, x2, y2, data?.GetCppThis() ?? default(HandleRef), front, blend, right);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderWindow_SetSwapControl_71(HandleRef pThis, int arg0);

	/// <summary>
	/// Set the number of vertical syncs required between frames.
	/// A value of 0 means swap buffers as quickly as possible
	/// regardless of the vertical refresh. A value of 1 means swap
	/// buffers in sync with the vertical refresh to eliminate tearing.
	/// A value of -1 means use a value of 1 unless we missed a frame
	/// in which case swap immediately. Returns true if the call
	/// succeeded.
	/// </summary>
	public virtual bool SetSwapControl(int arg0)
	{
		return (vtkOpenGLRenderWindow_SetSwapControl_71(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SetZbufferData_72(HandleRef pThis, int x1, int y1, int x2, int y2, IntPtr buffer);

	/// <summary>
	/// Set/Get the zbuffer data from an image
	/// </summary>
	public override int SetZbufferData(int x1, int y1, int x2, int y2, IntPtr buffer)
	{
		return vtkOpenGLRenderWindow_SetZbufferData_72(GetCppThis(), x1, y1, x2, y2, buffer);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SetZbufferData_73(HandleRef pThis, int x1, int y1, int x2, int y2, HandleRef buffer);

	/// <summary>
	/// Set/Get the zbuffer data from an image
	/// </summary>
	public override int SetZbufferData(int x1, int y1, int x2, int y2, vtkFloatArray buffer)
	{
		return vtkOpenGLRenderWindow_SetZbufferData_73(GetCppThis(), x1, y1, x2, y2, buffer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_Start_74(HandleRef pThis);

	/// <summary>
	/// Begin the rendering process.
	/// </summary>
	public override void Start()
	{
		vtkOpenGLRenderWindow_Start_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_StereoMidpoint_75(HandleRef pThis);

	/// <summary>
	/// Intermediate method performs operations required between the rendering
	/// of the left and right eye.
	/// </summary>
	public override void StereoMidpoint()
	{
		vtkOpenGLRenderWindow_StereoMidpoint_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderWindow_SupportsOpenGL_76(HandleRef pThis);

	/// <summary>
	/// Does this render window support OpenGL? 0-false, 1-true
	/// </summary>
	public override int SupportsOpenGL()
	{
		return vtkOpenGLRenderWindow_SupportsOpenGL_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderWindow_WaitForCompletion_77(HandleRef pThis);

	/// <summary>
	/// Block the thread until the actual rendering is finished().
	/// Useful for measurement only.
	/// </summary>
	public override void WaitForCompletion()
	{
		vtkOpenGLRenderWindow_WaitForCompletion_77(GetCppThis());
	}
}
