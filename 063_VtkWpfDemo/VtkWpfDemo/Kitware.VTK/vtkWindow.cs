using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWindow
/// </summary>
/// <remarks>
///    window superclass for vtkRenderWindow
///
/// vtkWindow is an abstract object to specify the behavior of a
/// rendering window.  It contains vtkViewports.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderWindow vtkViewport
/// </seealso>
public class vtkWindow : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWindow()
	{
		MRClassNameKey = "class vtkWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWindow_DetectDPI_01(HandleRef pThis);

	/// <summary>
	/// Attempt to detect and set the DPI of the display device by querying the
	/// system. Note that this is not supported on most backends, and this method
	/// will return false if the DPI could not be detected. Use GetDPI() to
	/// inspect the detected value.
	/// </summary>
	public virtual bool DetectDPI()
	{
		return (vtkWindow_DetectDPI_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_DoubleBufferOff_02(HandleRef pThis);

	/// <summary>
	/// Keep track of whether double buffering is on or off
	/// </summary>
	public virtual void DoubleBufferOff()
	{
		vtkWindow_DoubleBufferOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_DoubleBufferOn_03(HandleRef pThis);

	/// <summary>
	/// Keep track of whether double buffering is on or off
	/// </summary>
	public virtual void DoubleBufferOn()
	{
		vtkWindow_DoubleBufferOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_EraseOff_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off erasing the screen between images. This allows multiple
	/// exposure sequences if turned on. You will need to turn double
	/// buffering off or make use of the SwapBuffers methods to prevent
	/// you from swapping buffers between exposures.
	/// </summary>
	public virtual void EraseOff()
	{
		vtkWindow_EraseOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_EraseOn_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off erasing the screen between images. This allows multiple
	/// exposure sequences if turned on. You will need to turn double
	/// buffering off or make use of the SwapBuffers methods to prevent
	/// you from swapping buffers between exposures.
	/// </summary>
	public virtual void EraseOn()
	{
		vtkWindow_EraseOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetActualSize_06(HandleRef pThis);

	/// <summary>
	/// GetSize() returns the size * this-&gt;TileScale, whereas this method returns
	/// the size without multiplying with the tile scale. Measured in pixels.
	/// </summary>
	public IntPtr GetActualSize()
	{
		return vtkWindow_GetActualSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_GetDPI_07(HandleRef pThis);

	/// <summary>
	/// Return a best estimate to the dots per inch of the display
	/// device being rendered (or printed).
	/// </summary>
	public virtual int GetDPI()
	{
		return vtkWindow_GetDPI_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_GetDPIMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Return a best estimate to the dots per inch of the display
	/// device being rendered (or printed).
	/// </summary>
	public virtual int GetDPIMaxValue()
	{
		return vtkWindow_GetDPIMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_GetDPIMinValue_09(HandleRef pThis);

	/// <summary>
	/// Return a best estimate to the dots per inch of the display
	/// device being rendered (or printed).
	/// </summary>
	public virtual int GetDPIMinValue()
	{
		return vtkWindow_GetDPIMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_GetDoubleBuffer_10(HandleRef pThis);

	/// <summary>
	/// Keep track of whether double buffering is on or off
	/// </summary>
	public virtual int GetDoubleBuffer()
	{
		return vtkWindow_GetDoubleBuffer_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_GetErase_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off erasing the screen between images. This allows multiple
	/// exposure sequences if turned on. You will need to turn double
	/// buffering off or make use of the SwapBuffers methods to prevent
	/// you from swapping buffers between exposures.
	/// </summary>
	public virtual int GetErase()
	{
		return vtkWindow_GetErase_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetGenericContext_12(HandleRef pThis);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual IntPtr GetGenericContext()
	{
		return vtkWindow_GetGenericContext_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetGenericDisplayId_13(HandleRef pThis);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual IntPtr GetGenericDisplayId()
	{
		return vtkWindow_GetGenericDisplayId_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetGenericDrawable_14(HandleRef pThis);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual IntPtr GetGenericDrawable()
	{
		return vtkWindow_GetGenericDrawable_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetGenericParentId_15(HandleRef pThis);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual IntPtr GetGenericParentId()
	{
		return vtkWindow_GetGenericParentId_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetGenericWindowId_16(HandleRef pThis);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual IntPtr GetGenericWindowId()
	{
		return vtkWindow_GetGenericWindowId_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_GetMapped_17(HandleRef pThis);

	/// <summary>
	/// Keep track of whether the rendering window has been mapped to screen.
	/// </summary>
	public virtual int GetMapped()
	{
		return vtkWindow_GetMapped_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindow_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWindow_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindow_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWindow_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_GetOffScreenRendering_20(HandleRef pThis);

	/// <summary>
	/// Deprecated, directly use GetShowWindow and GetOffScreenBuffers
	/// instead.
	/// </summary>
	public int GetOffScreenRendering()
	{
		return vtkWindow_GetOffScreenRendering_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetPixelData_21(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

	/// <summary>
	/// Get the pixel data of an image, transmitted as RGBRGBRGB. The
	/// front argument indicates if the front buffer should be used or the back
	/// buffer. It is the caller's responsibility to delete the resulting
	/// array. It is very important to realize that the memory in this array
	/// is organized from the bottom of the window to the top. The origin
	/// of the screen is in the lower left corner. The y axis increases as
	/// you go up the screen. So the storage of pixels is from left to right
	/// and from bottom to top.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual IntPtr GetPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		return vtkWindow_GetPixelData_21(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_GetPixelData_22(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, HandleRef arg5, int arg6);

	/// <summary>
	/// Get the pixel data of an image, transmitted as RGBRGBRGB. The
	/// front argument indicates if the front buffer should be used or the back
	/// buffer. It is the caller's responsibility to delete the resulting
	/// array. It is very important to realize that the memory in this array
	/// is organized from the bottom of the window to the top. The origin
	/// of the screen is in the lower left corner. The y axis increases as
	/// you go up the screen. So the storage of pixels is from left to right
	/// and from bottom to top.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual int GetPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, vtkUnsignedCharArray arg5, int arg6)
	{
		return vtkWindow_GetPixelData_22(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5?.GetCppThis() ?? default(HandleRef), arg6);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetPosition_23(HandleRef pThis);

	/// <summary>
	/// Get the position (x and y) of the rendering window in
	/// screen coordinates (in pixels).
	/// </summary>
	public virtual int[] GetPosition()
	{
		IntPtr intPtr = vtkWindow_GetPosition_23(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetScreenSize_24(HandleRef pThis);

	/// <summary>
	/// Get the current size of the screen in pixels.
	/// </summary>
	public virtual int[] GetScreenSize()
	{
		IntPtr intPtr = vtkWindow_GetScreenSize_24(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWindow_GetShowWindow_25(HandleRef pThis);

	/// <summary>
	/// Show or not Show the window
	/// </summary>
	public virtual bool GetShowWindow()
	{
		return (vtkWindow_GetShowWindow_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetSize_26(HandleRef pThis);

	/// <summary>
	/// Get the size (width and height) of the rendering window in
	/// screen coordinates (in pixels).
	/// </summary>
	public virtual int[] GetSize()
	{
		IntPtr intPtr = vtkWindow_GetSize_26(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetTileScale_27(HandleRef pThis);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual int[] GetTileScale()
	{
		IntPtr intPtr = vtkWindow_GetTileScale_27(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_GetTileScale_28(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual void GetTileScale(ref int _arg1, ref int _arg2)
	{
		vtkWindow_GetTileScale_28(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_GetTileScale_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual void GetTileScale(IntPtr _arg)
	{
		vtkWindow_GetTileScale_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetTileViewport_30(HandleRef pThis);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual double[] GetTileViewport()
	{
		IntPtr intPtr = vtkWindow_GetTileViewport_30(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_GetTileViewport_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual void GetTileViewport(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkWindow_GetTileViewport_31(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_GetTileViewport_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual void GetTileViewport(IntPtr _arg)
	{
		vtkWindow_GetTileViewport_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWindow_GetUseOffScreenBuffers_33(HandleRef pThis);

	/// <summary>
	/// Render to an offscreen destination such as a framebuffer.
	/// All four combinations of ShowWindow and UseOffScreenBuffers
	/// should work for most rendering backends.
	/// </summary>
	public virtual bool GetUseOffScreenBuffers()
	{
		return (vtkWindow_GetUseOffScreenBuffers_33(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_GetWindowName_34(HandleRef pThis);

	/// <summary>
	/// Get name of rendering window
	/// </summary>
	public virtual string GetWindowName()
	{
		return Marshal.PtrToStringAnsi(vtkWindow_GetWindowName_34(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWindow_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindow_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWindow_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_MakeCurrent_37(HandleRef pThis);

	/// <summary>
	/// Make the window current. May be overridden in subclasses to do
	/// for example a glXMakeCurrent or a wglMakeCurrent.
	/// </summary>
	public virtual void MakeCurrent()
	{
		vtkWindow_MakeCurrent_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWindow NewInstance()
	{
		vtkWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindow_NewInstance_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_OffScreenRenderingOff_39(HandleRef pThis);

	/// <summary>
	/// Convenience to set SHowWindow and UseOffScreenBuffers in one call
	/// </summary>
	public virtual void OffScreenRenderingOff()
	{
		vtkWindow_OffScreenRenderingOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_OffScreenRenderingOn_40(HandleRef pThis);

	/// <summary>
	/// Convenience to set SHowWindow and UseOffScreenBuffers in one call
	/// </summary>
	public virtual void OffScreenRenderingOn()
	{
		vtkWindow_OffScreenRenderingOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_ReleaseCurrent_41(HandleRef pThis);

	/// <summary>
	/// Release the current context. May be overridden in subclasses to do
	/// for example a glXMakeCurrent or a wglMakeCurrent.
	/// </summary>
	public virtual void ReleaseCurrent()
	{
		vtkWindow_ReleaseCurrent_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_ReleaseGraphicsResources_42(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this texture.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkWindow_ReleaseGraphicsResources_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_Render_43(HandleRef pThis);

	/// <summary>
	/// Ask each viewport owned by this Window to render its image and
	/// synchronize this process.
	/// </summary>
	public virtual void Render()
	{
		vtkWindow_Render_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindow_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindow SafeDownCast(vtkObjectBase o)
	{
		vtkWindow vtkWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindow_SafeDownCast_44(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetDPI_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Return a best estimate to the dots per inch of the display
	/// device being rendered (or printed).
	/// </summary>
	public virtual void SetDPI(int _arg)
	{
		vtkWindow_SetDPI_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetDisplayId_46(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual void SetDisplayId(IntPtr arg0)
	{
		vtkWindow_SetDisplayId_46(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetDoubleBuffer_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Keep track of whether double buffering is on or off
	/// </summary>
	public virtual void SetDoubleBuffer(int _arg)
	{
		vtkWindow_SetDoubleBuffer_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetErase_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off erasing the screen between images. This allows multiple
	/// exposure sequences if turned on. You will need to turn double
	/// buffering off or make use of the SwapBuffers methods to prevent
	/// you from swapping buffers between exposures.
	/// </summary>
	public virtual void SetErase(int _arg)
	{
		vtkWindow_SetErase_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetIcon_49(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the icon used in title bar and task bar.
	/// Currently implemented for OpenGL windows on Windows and Linux.
	/// </summary>
	public virtual void SetIcon(vtkImageData arg0)
	{
		vtkWindow_SetIcon_49(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetOffScreenRendering_50(HandleRef pThis, int val);

	/// <summary>
	/// Convenience to set SHowWindow and UseOffScreenBuffers in one call
	/// </summary>
	public void SetOffScreenRendering(int val)
	{
		vtkWindow_SetOffScreenRendering_50(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetParentId_51(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual void SetParentId(IntPtr arg0)
	{
		vtkWindow_SetParentId_51(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetParentInfo_52(HandleRef pThis, string arg0);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual void SetParentInfo(string arg0)
	{
		vtkWindow_SetParentInfo_52(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetPosition_53(HandleRef pThis, int x, int y);

	/// <summary>
	/// Set the position (x and y) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	/// </summary>
	public virtual void SetPosition(int x, int y)
	{
		vtkWindow_SetPosition_53(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetPosition_54(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the position (x and y) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	/// </summary>
	public virtual void SetPosition(IntPtr a)
	{
		vtkWindow_SetPosition_54(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetShowWindow_55(HandleRef pThis, byte _arg);

	/// <summary>
	/// Show or not Show the window
	/// </summary>
	public virtual void SetShowWindow(bool _arg)
	{
		vtkWindow_SetShowWindow_55(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetSize_56(HandleRef pThis, int width, int height);

	/// <summary>
	/// Set the size (width and height) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public virtual void SetSize(int width, int height)
	{
		vtkWindow_SetSize_56(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetSize_57(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the size (width and height) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public virtual void SetSize(IntPtr a)
	{
		vtkWindow_SetSize_57(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetTileScale_58(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual void SetTileScale(int _arg1, int _arg2)
	{
		vtkWindow_SetTileScale_58(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetTileScale_59(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public void SetTileScale(IntPtr _arg)
	{
		vtkWindow_SetTileScale_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetTileScale_60(HandleRef pThis, int s);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public void SetTileScale(int s)
	{
		vtkWindow_SetTileScale_60(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetTileViewport_61(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual void SetTileViewport(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkWindow_SetTileViewport_61(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetTileViewport_62(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// These methods are used by vtkWindowToImageFilter to tell a VTK window
	/// to simulate a larger window by tiling. For 3D geometry these methods
	/// have no impact. It is just in handling annotation that this information
	/// must be available to the mappers and the coordinate calculations.
	/// </summary>
	public virtual void SetTileViewport(IntPtr _arg)
	{
		vtkWindow_SetTileViewport_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetUseOffScreenBuffers_63(HandleRef pThis, byte _arg);

	/// <summary>
	/// Render to an offscreen destination such as a framebuffer.
	/// All four combinations of ShowWindow and UseOffScreenBuffers
	/// should work for most rendering backends.
	/// </summary>
	public virtual void SetUseOffScreenBuffers(bool _arg)
	{
		vtkWindow_SetUseOffScreenBuffers_63(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetWindowId_64(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual void SetWindowId(IntPtr arg0)
	{
		vtkWindow_SetWindowId_64(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetWindowInfo_65(HandleRef pThis, string arg0);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public virtual void SetWindowInfo(string arg0)
	{
		vtkWindow_SetWindowInfo_65(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_SetWindowName_66(HandleRef pThis, string _arg);

	/// <summary>
	/// Get name of rendering window
	/// </summary>
	public virtual void SetWindowName(string _arg)
	{
		vtkWindow_SetWindowName_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_ShowWindowOff_67(HandleRef pThis);

	/// <summary>
	/// Show or not Show the window
	/// </summary>
	public virtual void ShowWindowOff()
	{
		vtkWindow_ShowWindowOff_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_ShowWindowOn_68(HandleRef pThis);

	/// <summary>
	/// Show or not Show the window
	/// </summary>
	public virtual void ShowWindowOn()
	{
		vtkWindow_ShowWindowOn_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_UseOffScreenBuffersOff_69(HandleRef pThis);

	/// <summary>
	/// Render to an offscreen destination such as a framebuffer.
	/// All four combinations of ShowWindow and UseOffScreenBuffers
	/// should work for most rendering backends.
	/// </summary>
	public virtual void UseOffScreenBuffersOff()
	{
		vtkWindow_UseOffScreenBuffersOff_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindow_UseOffScreenBuffersOn_70(HandleRef pThis);

	/// <summary>
	/// Render to an offscreen destination such as a framebuffer.
	/// All four combinations of ShowWindow and UseOffScreenBuffers
	/// should work for most rendering backends.
	/// </summary>
	public virtual void UseOffScreenBuffersOn()
	{
		vtkWindow_UseOffScreenBuffersOn_70(GetCppThis());
	}
}
