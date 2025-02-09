using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageViewer
/// </summary>
/// <remarks>
///    Display a 2d image.
///
/// vtkImageViewer is a convenience class for displaying a 2d image.  It
/// packages up the functionality found in vtkRenderWindow, vtkRenderer,
/// vtkActor2D and vtkImageMapper into a single easy to use class.  Behind the
/// scenes these four classes are actually used to to provide the required
/// functionality. vtkImageViewer is simply a wrapper around them.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderWindow vtkRenderer vtkImageMapper vtkActor2D
/// </seealso>
public class vtkImageViewer : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageViewer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageViewer()
	{
		MRClassNameKey = "class vtkImageViewer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageViewer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageViewer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageViewer New()
	{
		vtkImageViewer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageViewer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageViewer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_GetActor2D_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal objects
	/// </summary>
	public virtual vtkActor2D GetActor2D()
	{
		vtkActor2D vtkActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer_GetActor2D_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2D2 = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2D2.Register(null);
			}
		}
		return vtkActor2D2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageViewer_GetColorLevel_02(HandleRef pThis);

	/// <summary>
	/// Sets window/level for mapping pixels to colors.
	/// </summary>
	public double GetColorLevel()
	{
		return vtkImageViewer_GetColorLevel_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageViewer_GetColorWindow_03(HandleRef pThis);

	/// <summary>
	/// Sets window/level for mapping pixels to colors.
	/// </summary>
	public double GetColorWindow()
	{
		return vtkImageViewer_GetColorWindow_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_GetImageMapper_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal objects
	/// </summary>
	public virtual vtkImageMapper GetImageMapper()
	{
		vtkImageMapper vtkImageMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer_GetImageMapper_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapper2 = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapper2.Register(null);
			}
		}
		return vtkImageMapper2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input to the viewer.
	/// </summary>
	public vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer_GetInput_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageViewer_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageViewer_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageViewer_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageViewer_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer_GetOffScreenRendering_08(HandleRef pThis);

	/// <summary>
	/// Create a window in memory instead of on the screen. This may not
	/// be supported for every type of window and on some windows you may
	/// need to invoke this prior to the first render.
	/// </summary>
	public int GetOffScreenRendering()
	{
		return vtkImageViewer_GetOffScreenRendering_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_GetPosition_09(HandleRef pThis);

	/// <summary>
	/// Get the position (x and y) of the rendering window in
	/// screen coordinates (in pixels).
	/// </summary>
	public int[] GetPosition()
	{
		IntPtr intPtr = vtkImageViewer_GetPosition_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_GetRenderWindow_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal objects
	/// </summary>
	public virtual vtkRenderWindow GetRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer_GetRenderWindow_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_GetRenderer_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the internal objects
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer_GetRenderer_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_GetSize_12(HandleRef pThis);

	/// <summary>
	/// Get the size (width and height) of the rendering window in
	/// screen coordinates (in pixels).
	/// </summary>
	public int[] GetSize()
	{
		IntPtr intPtr = vtkImageViewer_GetSize_12(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer_GetWholeZMax_13(HandleRef pThis);

	/// <summary>
	/// What is the possible Min/ Max z slices available.
	/// </summary>
	public int GetWholeZMax()
	{
		return vtkImageViewer_GetWholeZMax_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer_GetWholeZMin_14(HandleRef pThis);

	/// <summary>
	/// What is the possible Min/ Max z slices available.
	/// </summary>
	public int GetWholeZMin()
	{
		return vtkImageViewer_GetWholeZMin_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_GetWindowName_15(HandleRef pThis);

	/// <summary>
	/// Get name of rendering window
	/// </summary>
	public string GetWindowName()
	{
		return Marshal.PtrToStringAnsi(vtkImageViewer_GetWindowName_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer_GetZSlice_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the current Z Slice to display
	/// </summary>
	public int GetZSlice()
	{
		return vtkImageViewer_GetZSlice_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageViewer_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageViewer_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageViewer_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageViewer NewInstance()
	{
		vtkImageViewer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_OffScreenRenderingOff_21(HandleRef pThis);

	/// <summary>
	/// Create a window in memory instead of on the screen. This may not
	/// be supported for every type of window and on some windows you may
	/// need to invoke this prior to the first render.
	/// </summary>
	public void OffScreenRenderingOff()
	{
		vtkImageViewer_OffScreenRenderingOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_OffScreenRenderingOn_22(HandleRef pThis);

	/// <summary>
	/// Create a window in memory instead of on the screen. This may not
	/// be supported for every type of window and on some windows you may
	/// need to invoke this prior to the first render.
	/// </summary>
	public void OffScreenRenderingOn()
	{
		vtkImageViewer_OffScreenRenderingOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_Render_23(HandleRef pThis);

	/// <summary>
	/// Render the resulting image.
	/// </summary>
	public virtual void Render()
	{
		vtkImageViewer_Render_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageViewer_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageViewer SafeDownCast(vtkObjectBase o)
	{
		vtkImageViewer vtkImageViewer3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageViewer_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageViewer3 = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageViewer3.Register(null);
			}
		}
		return vtkImageViewer3;
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetColorLevel_25(HandleRef pThis, double s);

	/// <summary>
	/// Sets window/level for mapping pixels to colors.
	/// </summary>
	public void SetColorLevel(double s)
	{
		vtkImageViewer_SetColorLevel_25(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetColorWindow_26(HandleRef pThis, double s);

	/// <summary>
	/// Sets window/level for mapping pixels to colors.
	/// </summary>
	public void SetColorWindow(double s)
	{
		vtkImageViewer_SetColorWindow_26(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetDisplayId_27(HandleRef pThis, IntPtr a);

	/// <summary>
	/// These are here for using a tk window.
	/// </summary>
	public void SetDisplayId(IntPtr a)
	{
		vtkImageViewer_SetDisplayId_27(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetInputConnection_28(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set/Get the input to the viewer.
	/// </summary>
	public virtual void SetInputConnection(vtkAlgorithmOutput input)
	{
		vtkImageViewer_SetInputConnection_28(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetInputData_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the input to the viewer.
	/// </summary>
	public void SetInputData(vtkImageData arg0)
	{
		vtkImageViewer_SetInputData_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetOffScreenRendering_30(HandleRef pThis, int arg0);

	/// <summary>
	/// Create a window in memory instead of on the screen. This may not
	/// be supported for every type of window and on some windows you may
	/// need to invoke this prior to the first render.
	/// </summary>
	public void SetOffScreenRendering(int arg0)
	{
		vtkImageViewer_SetOffScreenRendering_30(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetParentId_31(HandleRef pThis, IntPtr a);

	/// <summary>
	/// These are here for using a tk window.
	/// </summary>
	public void SetParentId(IntPtr a)
	{
		vtkImageViewer_SetParentId_31(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetPosition_32(HandleRef pThis, int x, int y);

	/// <summary>
	/// Set the position (x and y) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	/// </summary>
	public void SetPosition(int x, int y)
	{
		vtkImageViewer_SetPosition_32(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetPosition_33(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the position (x and y) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	/// </summary>
	public virtual void SetPosition(IntPtr a)
	{
		vtkImageViewer_SetPosition_33(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetRenderWindow_34(HandleRef pThis, HandleRef renWin);

	/// <summary>
	/// Get the internal objects
	/// </summary>
	public void SetRenderWindow(vtkRenderWindow renWin)
	{
		vtkImageViewer_SetRenderWindow_34(GetCppThis(), renWin?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetSize_35(HandleRef pThis, int width, int height);

	/// <summary>
	/// Set the size (width and height) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public void SetSize(int width, int height)
	{
		vtkImageViewer_SetSize_35(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetSize_36(HandleRef pThis, IntPtr a);

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
		vtkImageViewer_SetSize_36(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetWindowId_37(HandleRef pThis, IntPtr a);

	/// <summary>
	/// These are here for using a tk window.
	/// </summary>
	public void SetWindowId(IntPtr a)
	{
		vtkImageViewer_SetWindowId_37(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetZSlice_38(HandleRef pThis, int s);

	/// <summary>
	/// Set/Get the current Z Slice to display
	/// </summary>
	public void SetZSlice(int s)
	{
		vtkImageViewer_SetZSlice_38(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageViewer_SetupInteractor_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Create and attach an interactor for this window
	/// </summary>
	public void SetupInteractor(vtkRenderWindowInteractor arg0)
	{
		vtkImageViewer_SetupInteractor_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
