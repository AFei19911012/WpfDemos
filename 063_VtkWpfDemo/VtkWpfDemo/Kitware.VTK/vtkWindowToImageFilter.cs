using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWindowToImageFilter
/// </summary>
/// <remarks>
///    Use a vtkWindow as input to image pipeline
///
/// vtkWindowToImageFilter provides methods needed to read the data in
/// a vtkWindow and use it as input to the imaging pipeline. This is
/// useful for saving an image to a file for example. The window can
/// be read as either RGB or RGBA pixels;  in addition, the depth buffer
/// can also be read.   RGB and RGBA pixels are of type unsigned char,
/// while Z-Buffer data is returned as floats.  Use this filter
/// to convert RenderWindows or ImageWindows to an image format.
///
/// @warning
/// A vtkWindow doesn't behave like other parts of the VTK pipeline: its
/// modification time doesn't get updated when an image is rendered.  As a
/// result, naive use of vtkWindowToImageFilter will produce an image of
/// the first image that the window rendered, but which is never updated
/// on subsequent window updates.  This behavior is unexpected and in
/// general undesirable.
///
/// @warning
/// To force an update of the output image, call vtkWindowToImageFilter's
/// Modified method after rendering to the window.
///
/// @warning
/// In VTK versions 4 and later, this filter is part of the canonical
/// way to output an image of a window to a file (replacing the
/// obsolete SaveImageAsPPM method for vtkRenderWindows that existed in
/// 3.2 and earlier).  Connect this filter to the output of the window,
/// and filter's output to a writer such as vtkPNGWriter.
///
/// @warning
/// Reading back alpha planes is dependent on the correct operation of
/// the render window's GetRGBACharPixelData method, which in turn is
/// dependent on the configuration of the window's alpha planes.  As of
/// VTK 4.4+, machine-independent behavior is not automatically
/// assured because of these dependencies.
///
/// </remarks>
/// <seealso>
///
/// vtkRendererSource vtkRendererPointCloudSource vtkWindow
/// vtkRenderLargeImage
/// </seealso>
public class vtkWindowToImageFilter : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWindowToImageFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWindowToImageFilter()
	{
		MRClassNameKey = "class vtkWindowToImageFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowToImageFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWindowToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowToImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindowToImageFilter New()
	{
		vtkWindowToImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowToImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWindowToImageFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWindowToImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_FixBoundaryOff_01(HandleRef pThis);

	/// <summary>
	/// When scale factor &gt; 1, this class render the full image in tiles.
	/// Sometimes that results in artificial artifacts at internal tile seams.
	/// To overcome this issue, set this flag to true.
	/// </summary>
	public virtual void FixBoundaryOff()
	{
		vtkWindowToImageFilter_FixBoundaryOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_FixBoundaryOn_02(HandleRef pThis);

	/// <summary>
	/// When scale factor &gt; 1, this class render the full image in tiles.
	/// Sometimes that results in artificial artifacts at internal tile seams.
	/// To overcome this issue, set this flag to true.
	/// </summary>
	public virtual void FixBoundaryOn()
	{
		vtkWindowToImageFilter_FixBoundaryOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWindowToImageFilter_GetFixBoundary_03(HandleRef pThis);

	/// <summary>
	/// When scale factor &gt; 1, this class render the full image in tiles.
	/// Sometimes that results in artificial artifacts at internal tile seams.
	/// To overcome this issue, set this flag to true.
	/// </summary>
	public virtual bool GetFixBoundary()
	{
		return (vtkWindowToImageFilter_GetFixBoundary_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowToImageFilter_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns which renderer is being used as the source for the pixel data.
	/// Initial value is 0.
	/// </summary>
	public virtual vtkWindow GetInput()
	{
		vtkWindow vtkWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowToImageFilter_GetInput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWindow2 = (vtkWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWindow2.Register(null);
			}
		}
		return vtkWindow2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowToImageFilter_GetInputBufferType_05(HandleRef pThis);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public virtual int GetInputBufferType()
	{
		return vtkWindowToImageFilter_GetInputBufferType_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindowToImageFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWindowToImageFilter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindowToImageFilter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWindowToImageFilter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowToImageFilter_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkImageData GetOutput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowToImageFilter_GetOutput_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowToImageFilter_GetReadFrontBuffer_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that determines which buffer to read from.
	/// The default is to read from the front buffer.
	/// </summary>
	public virtual int GetReadFrontBuffer()
	{
		return vtkWindowToImageFilter_GetReadFrontBuffer_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowToImageFilter_GetScale_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the scale (or magnification) factors in X and Y.
	/// </summary>
	public virtual int[] GetScale()
	{
		IntPtr intPtr = vtkWindowToImageFilter_GetScale_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_GetScale_11(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get/Set the scale (or magnification) factors in X and Y.
	/// </summary>
	public virtual void GetScale(ref int _arg1, ref int _arg2)
	{
		vtkWindowToImageFilter_GetScale_11(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_GetScale_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the scale (or magnification) factors in X and Y.
	/// </summary>
	public virtual void GetScale(IntPtr _arg)
	{
		vtkWindowToImageFilter_GetScale_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowToImageFilter_GetShouldRerender_13(HandleRef pThis);

	/// <summary>
	/// Set/get whether to re-render the input window. Initial value is true.
	/// (This option makes no difference if scale factor &gt; 1.)
	/// </summary>
	public virtual int GetShouldRerender()
	{
		return vtkWindowToImageFilter_GetShouldRerender_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowToImageFilter_GetViewport_14(HandleRef pThis);

	/// <summary>
	/// Set/get the extents to be used to generate the image. Initial value is
	/// {0,0,1,1} (This option does not work if scale factor &gt; 1.)
	/// </summary>
	public virtual double[] GetViewport()
	{
		IntPtr intPtr = vtkWindowToImageFilter_GetViewport_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_GetViewport_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get the extents to be used to generate the image. Initial value is
	/// {0,0,1,1} (This option does not work if scale factor &gt; 1.)
	/// </summary>
	public virtual void GetViewport(IntPtr data)
	{
		vtkWindowToImageFilter_GetViewport_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowToImageFilter_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWindowToImageFilter_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowToImageFilter_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWindowToImageFilter_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowToImageFilter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWindowToImageFilter NewInstance()
	{
		vtkWindowToImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowToImageFilter_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_ReadFrontBufferOff_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that determines which buffer to read from.
	/// The default is to read from the front buffer.
	/// </summary>
	public virtual void ReadFrontBufferOff()
	{
		vtkWindowToImageFilter_ReadFrontBufferOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_ReadFrontBufferOn_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that determines which buffer to read from.
	/// The default is to read from the front buffer.
	/// </summary>
	public virtual void ReadFrontBufferOn()
	{
		vtkWindowToImageFilter_ReadFrontBufferOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowToImageFilter_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindowToImageFilter SafeDownCast(vtkObjectBase o)
	{
		vtkWindowToImageFilter vtkWindowToImageFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowToImageFilter_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWindowToImageFilter2 = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWindowToImageFilter2.Register(null);
			}
		}
		return vtkWindowToImageFilter2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetFixBoundary_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// When scale factor &gt; 1, this class render the full image in tiles.
	/// Sometimes that results in artificial artifacts at internal tile seams.
	/// To overcome this issue, set this flag to true.
	/// </summary>
	public virtual void SetFixBoundary(bool _arg)
	{
		vtkWindowToImageFilter_SetFixBoundary_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetInput_24(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Indicates what renderer to get the pixel data from. Initial value is 0.
	/// </summary>
	public void SetInput(vtkWindow input)
	{
		vtkWindowToImageFilter_SetInput_24(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetInputBufferType_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public virtual void SetInputBufferType(int _arg)
	{
		vtkWindowToImageFilter_SetInputBufferType_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToRGB_26(HandleRef pThis);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public void SetInputBufferTypeToRGB()
	{
		vtkWindowToImageFilter_SetInputBufferTypeToRGB_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToRGBA_27(HandleRef pThis);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public void SetInputBufferTypeToRGBA()
	{
		vtkWindowToImageFilter_SetInputBufferTypeToRGBA_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToZBuffer_28(HandleRef pThis);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public void SetInputBufferTypeToZBuffer()
	{
		vtkWindowToImageFilter_SetInputBufferTypeToZBuffer_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetReadFrontBuffer_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag that determines which buffer to read from.
	/// The default is to read from the front buffer.
	/// </summary>
	public virtual void SetReadFrontBuffer(int _arg)
	{
		vtkWindowToImageFilter_SetReadFrontBuffer_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetScale_30(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Get/Set the scale (or magnification) factors in X and Y.
	/// </summary>
	public virtual void SetScale(int _arg1, int _arg2)
	{
		vtkWindowToImageFilter_SetScale_30(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetScale_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the scale (or magnification) factors in X and Y.
	/// </summary>
	public void SetScale(IntPtr _arg)
	{
		vtkWindowToImageFilter_SetScale_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetScale_32(HandleRef pThis, int scale);

	/// <summary>
	/// Convenience method to set same scale factors for x and y.
	/// i.e. same as calling this-&gt;SetScale(scale, scale).
	/// </summary>
	public void SetScale(int scale)
	{
		vtkWindowToImageFilter_SetScale_32(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetShouldRerender_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether to re-render the input window. Initial value is true.
	/// (This option makes no difference if scale factor &gt; 1.)
	/// </summary>
	public virtual void SetShouldRerender(int _arg)
	{
		vtkWindowToImageFilter_SetShouldRerender_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetViewport_34(HandleRef pThis, double arg0, double arg1, double arg2, double arg3);

	/// <summary>
	/// Set/get the extents to be used to generate the image. Initial value is
	/// {0,0,1,1} (This option does not work if scale factor &gt; 1.)
	/// </summary>
	public void SetViewport(double arg0, double arg1, double arg2, double arg3)
	{
		vtkWindowToImageFilter_SetViewport_34(GetCppThis(), arg0, arg1, arg2, arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_SetViewport_35(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set/get the extents to be used to generate the image. Initial value is
	/// {0,0,1,1} (This option does not work if scale factor &gt; 1.)
	/// </summary>
	public void SetViewport(IntPtr arg0)
	{
		vtkWindowToImageFilter_SetViewport_35(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_ShouldRerenderOff_36(HandleRef pThis);

	/// <summary>
	/// Set/get whether to re-render the input window. Initial value is true.
	/// (This option makes no difference if scale factor &gt; 1.)
	/// </summary>
	public virtual void ShouldRerenderOff()
	{
		vtkWindowToImageFilter_ShouldRerenderOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowToImageFilter_ShouldRerenderOn_37(HandleRef pThis);

	/// <summary>
	/// Set/get whether to re-render the input window. Initial value is true.
	/// (This option makes no difference if scale factor &gt; 1.)
	/// </summary>
	public virtual void ShouldRerenderOn()
	{
		vtkWindowToImageFilter_ShouldRerenderOn_37(GetCppThis());
	}
}
