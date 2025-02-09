using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWin32HardwareWindow
/// </summary>
/// <remarks>
///    represents a window in a windows GUI
/// </remarks>
public class vtkWin32HardwareWindow : vtkHardwareWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWin32HardwareWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWin32HardwareWindow()
	{
		MRClassNameKey = "class vtkWin32HardwareWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32HardwareWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWin32HardwareWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32HardwareWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWin32HardwareWindow New()
	{
		vtkWin32HardwareWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32HardwareWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWin32HardwareWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWin32HardwareWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWin32HardwareWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32HardwareWindow_Create_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Create()
	{
		vtkWin32HardwareWindow_Create_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32HardwareWindow_Destroy_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Destroy()
	{
		vtkWin32HardwareWindow_Destroy_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32HardwareWindow_GetGenericDisplayId_03(HandleRef pThis);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public override IntPtr GetGenericDisplayId()
	{
		return vtkWin32HardwareWindow_GetGenericDisplayId_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32HardwareWindow_GetGenericParentId_04(HandleRef pThis);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public override IntPtr GetGenericParentId()
	{
		return vtkWin32HardwareWindow_GetGenericParentId_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32HardwareWindow_GetGenericWindowId_05(HandleRef pThis);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public override IntPtr GetGenericWindowId()
	{
		return vtkWin32HardwareWindow_GetGenericWindowId_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWin32HardwareWindow_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWin32HardwareWindow_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWin32HardwareWindow_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWin32HardwareWindow_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32HardwareWindow_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWin32HardwareWindow_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32HardwareWindow_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWin32HardwareWindow_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32HardwareWindow_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWin32HardwareWindow NewInstance()
	{
		vtkWin32HardwareWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32HardwareWindow_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWin32HardwareWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32HardwareWindow_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWin32HardwareWindow SafeDownCast(vtkObjectBase o)
	{
		vtkWin32HardwareWindow vtkWin32HardwareWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32HardwareWindow_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWin32HardwareWindow2 = (vtkWin32HardwareWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWin32HardwareWindow2.Register(null);
			}
		}
		return vtkWin32HardwareWindow2;
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32HardwareWindow_SetDisplayId_13(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public override void SetDisplayId(IntPtr arg0)
	{
		vtkWin32HardwareWindow_SetDisplayId_13(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32HardwareWindow_SetParentId_14(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public override void SetParentId(IntPtr arg0)
	{
		vtkWin32HardwareWindow_SetParentId_14(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32HardwareWindow_SetPosition_15(HandleRef pThis, int arg0, int arg1);

	/// <summary>
	/// Set the position of the window.
	/// </summary>
	public override void SetPosition(int arg0, int arg1)
	{
		vtkWin32HardwareWindow_SetPosition_15(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32HardwareWindow_SetSize_16(HandleRef pThis, int arg0, int arg1);

	/// <summary>
	/// Set the size of the window in pixels.
	/// </summary>
	public override void SetSize(int arg0, int arg1)
	{
		vtkWin32HardwareWindow_SetSize_16(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32HardwareWindow_SetWindowId_17(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// These are window system independent methods that are used
	/// to help interface vtkWindow to native windowing systems.
	/// </summary>
	public override void SetWindowId(IntPtr arg0)
	{
		vtkWin32HardwareWindow_SetWindowId_17(GetCppThis(), arg0);
	}
}
