using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleSwitch
/// </summary>
/// <remarks>
///    class to swap between interactory styles
///
/// The class vtkInteractorStyleSwitch allows handles interactively switching
/// between four interactor styles -- joystick actor, joystick camera,
/// trackball actor, and trackball camera.  Type 'j' or 't' to select
/// joystick or trackball, and type 'c' or 'a' to select camera or actor.
/// The default interactor style is joystick camera.
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyleJoystickActor vtkInteractorStyleJoystickCamera
/// vtkInteractorStyleTrackballActor vtkInteractorStyleTrackballCamera
/// </seealso>
public class vtkInteractorStyleSwitch : vtkInteractorStyleSwitchBase
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleSwitch";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleSwitch()
	{
		MRClassNameKey = "class vtkInteractorStyleSwitch";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleSwitch"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleSwitch(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleSwitch_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleSwitch New()
	{
		vtkInteractorStyleSwitch result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleSwitch_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleSwitch()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleSwitch_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleSwitch_GetCurrentStyle_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get current style
	/// </summary>
	public virtual vtkInteractorStyle GetCurrentStyle()
	{
		vtkInteractorStyle vtkInteractorStyle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleSwitch_GetCurrentStyle_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyle2 = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyle2.Register(null);
			}
		}
		return vtkInteractorStyle2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleSwitch_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleSwitch_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleSwitch_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleSwitch_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleSwitch_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleSwitch_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleSwitch_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleSwitch_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleSwitch_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleSwitch NewInstance()
	{
		vtkInteractorStyleSwitch result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleSwitch_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_OnChar_08(HandleRef pThis);

	/// <summary>
	/// Only care about the char event, which is used to switch between
	/// different styles.
	/// </summary>
	public override void OnChar()
	{
		vtkInteractorStyleSwitch_OnChar_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleSwitch_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleSwitch SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleSwitch vtkInteractorStyleSwitch2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleSwitch_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleSwitch2 = (vtkInteractorStyleSwitch)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleSwitch2.Register(null);
			}
		}
		return vtkInteractorStyleSwitch2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetAutoAdjustCameraClippingRange_10(HandleRef pThis, int value);

	/// <summary>
	/// We must override this method in order to pass the setting down to
	/// the underlying styles
	/// </summary>
	public override void SetAutoAdjustCameraClippingRange(int value)
	{
		vtkInteractorStyleSwitch_SetAutoAdjustCameraClippingRange_10(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetCurrentRenderer_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Overridden from vtkInteractorObserver because the interactor styles
	/// used by this class must also be updated.
	/// </summary>
	public override void SetCurrentRenderer(vtkRenderer arg0)
	{
		vtkInteractorStyleSwitch_SetCurrentRenderer_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToJoystickActor_12(HandleRef pThis);

	/// <summary>
	/// Set/Get current style
	/// </summary>
	public void SetCurrentStyleToJoystickActor()
	{
		vtkInteractorStyleSwitch_SetCurrentStyleToJoystickActor_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToJoystickCamera_13(HandleRef pThis);

	/// <summary>
	/// Set/Get current style
	/// </summary>
	public void SetCurrentStyleToJoystickCamera()
	{
		vtkInteractorStyleSwitch_SetCurrentStyleToJoystickCamera_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToMultiTouchCamera_14(HandleRef pThis);

	/// <summary>
	/// Set/Get current style
	/// </summary>
	public void SetCurrentStyleToMultiTouchCamera()
	{
		vtkInteractorStyleSwitch_SetCurrentStyleToMultiTouchCamera_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToTrackballActor_15(HandleRef pThis);

	/// <summary>
	/// Set/Get current style
	/// </summary>
	public void SetCurrentStyleToTrackballActor()
	{
		vtkInteractorStyleSwitch_SetCurrentStyleToTrackballActor_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetCurrentStyleToTrackballCamera_16(HandleRef pThis);

	/// <summary>
	/// Set/Get current style
	/// </summary>
	public void SetCurrentStyleToTrackballCamera()
	{
		vtkInteractorStyleSwitch_SetCurrentStyleToTrackballCamera_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetDefaultRenderer_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Overridden from vtkInteractorObserver because the interactor styles
	/// used by this class must also be updated.
	/// </summary>
	public override void SetDefaultRenderer(vtkRenderer arg0)
	{
		vtkInteractorStyleSwitch_SetDefaultRenderer_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleSwitch_SetInteractor_18(HandleRef pThis, HandleRef iren);

	/// <summary>
	/// The sub styles need the interactor too.
	/// </summary>
	public override void SetInteractor(vtkRenderWindowInteractor iren)
	{
		vtkInteractorStyleSwitch_SetInteractor_18(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef));
	}
}
