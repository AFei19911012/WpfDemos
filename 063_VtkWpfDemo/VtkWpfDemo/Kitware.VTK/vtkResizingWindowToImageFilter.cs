using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResizingWindowToImageFilter
/// </summary>
/// <remarks>
///    Use a vtkWindow as input to image pipeline
///
/// vtkResizingWindowToImageFilter provides methods needed to read the data in
/// a vtkWindow and use it as input to the imaging pipeline. This is
/// useful for saving an image to a file for example. The window can
/// be read as either RGB or RGBA pixels;  in addition, the depth buffer
/// can also be read.   RGB and RGBA pixels are of type unsigned char,
/// while Z-Buffer data is returned as floats.  Use this filter
/// to convert RenderWindows or ImageWindows to an image format.
///
/// @note
/// In contrast to the vtkWindowToImageFilter, this allows also for non-integral
/// values to be used as scaling factors for the generated image. Also, it
/// provides a SizeLimit parameter which enables to control when the algorithm
/// will switch to using tiling for generating a large image instead of
/// rendering the entire result at once.
///
/// @warning
/// A vtkWindow doesn't behave like other parts of the VTK pipeline: its
/// modification time doesn't get updated when an image is rendered.  As a
/// result, naive use of vtkResizingWindowToImageFilter will produce an image of
/// the first image that the window rendered, but which is never updated
/// on subsequent window updates.  This behavior is unexpected and in
/// general undesirable.
///
/// @warning
/// To force an update of the output image, call vtkResizingWindowToImageFilter's
/// Modified method after rendering to the window.
///
/// </remarks>
/// <seealso>
///
/// vtkRendererSource vtkRendererPointCloudSource vtkWindow
/// vtkRenderLargeImage vtkWindowToImageFilter
/// </seealso>
public class vtkResizingWindowToImageFilter : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResizingWindowToImageFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResizingWindowToImageFilter()
	{
		MRClassNameKey = "class vtkResizingWindowToImageFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResizingWindowToImageFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResizingWindowToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResizingWindowToImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResizingWindowToImageFilter New()
	{
		vtkResizingWindowToImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResizingWindowToImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResizingWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkResizingWindowToImageFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResizingWindowToImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkResizingWindowToImageFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkResizingWindowToImageFilter_GetInput_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkResizingWindowToImageFilter_GetInputBufferType_02(HandleRef pThis);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public virtual int GetInputBufferType()
	{
		return vtkResizingWindowToImageFilter_GetInputBufferType_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResizingWindowToImageFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResizingWindowToImageFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResizingWindowToImageFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResizingWindowToImageFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResizingWindowToImageFilter_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkImageData GetOutput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResizingWindowToImageFilter_GetOutput_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkResizingWindowToImageFilter_GetSize_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the size of the target image in pixels.
	/// </summary>
	public virtual int[] GetSize()
	{
		IntPtr intPtr = vtkResizingWindowToImageFilter_GetSize_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_GetSize_07(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get/Set the size of the target image in pixels.
	/// </summary>
	public virtual void GetSize(ref int _arg1, ref int _arg2)
	{
		vtkResizingWindowToImageFilter_GetSize_07(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_GetSize_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the size of the target image in pixels.
	/// </summary>
	public virtual void GetSize(IntPtr _arg)
	{
		vtkResizingWindowToImageFilter_GetSize_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResizingWindowToImageFilter_GetSizeLimit_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the size limit of the image (in pixels per axis) for switching
	/// from rendering the entire image in memory to using tiling which uses less
	/// memory but may fail to produce the exact size in pixels as requested.
	/// </summary>
	public virtual int GetSizeLimit()
	{
		return vtkResizingWindowToImageFilter_GetSizeLimit_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResizingWindowToImageFilter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResizingWindowToImageFilter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResizingWindowToImageFilter_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResizingWindowToImageFilter_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResizingWindowToImageFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkResizingWindowToImageFilter NewInstance()
	{
		vtkResizingWindowToImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResizingWindowToImageFilter_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResizingWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResizingWindowToImageFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResizingWindowToImageFilter SafeDownCast(vtkObjectBase o)
	{
		vtkResizingWindowToImageFilter vtkResizingWindowToImageFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResizingWindowToImageFilter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResizingWindowToImageFilter2 = (vtkResizingWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResizingWindowToImageFilter2.Register(null);
			}
		}
		return vtkResizingWindowToImageFilter2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_SetInput_15(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Indicates what renderer to get the pixel data from. Initial value is 0.
	/// </summary>
	public void SetInput(vtkWindow input)
	{
		vtkResizingWindowToImageFilter_SetInput_15(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_SetInputBufferType_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public virtual void SetInputBufferType(int _arg)
	{
		vtkResizingWindowToImageFilter_SetInputBufferType_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_SetInputBufferTypeToRGB_17(HandleRef pThis);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public void SetInputBufferTypeToRGB()
	{
		vtkResizingWindowToImageFilter_SetInputBufferTypeToRGB_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_SetInputBufferTypeToRGBA_18(HandleRef pThis);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public void SetInputBufferTypeToRGBA()
	{
		vtkResizingWindowToImageFilter_SetInputBufferTypeToRGBA_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_SetInputBufferTypeToZBuffer_19(HandleRef pThis);

	/// <summary>
	/// Set/get the window buffer from which data will be read.  Choices
	/// include VTK_RGB (read the color image from the window), VTK_RGBA
	/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
	/// buffer, returned as a float array). Initial value is VTK_RGB.
	/// </summary>
	public void SetInputBufferTypeToZBuffer()
	{
		vtkResizingWindowToImageFilter_SetInputBufferTypeToZBuffer_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_SetSize_20(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Get/Set the size of the target image in pixels.
	/// </summary>
	public virtual void SetSize(int _arg1, int _arg2)
	{
		vtkResizingWindowToImageFilter_SetSize_20(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_SetSize_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the size of the target image in pixels.
	/// </summary>
	public void SetSize(IntPtr _arg)
	{
		vtkResizingWindowToImageFilter_SetSize_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResizingWindowToImageFilter_SetSizeLimit_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the size limit of the image (in pixels per axis) for switching
	/// from rendering the entire image in memory to using tiling which uses less
	/// memory but may fail to produce the exact size in pixels as requested.
	/// </summary>
	public virtual void SetSizeLimit(int _arg)
	{
		vtkResizingWindowToImageFilter_SetSizeLimit_22(GetCppThis(), _arg);
	}
}
