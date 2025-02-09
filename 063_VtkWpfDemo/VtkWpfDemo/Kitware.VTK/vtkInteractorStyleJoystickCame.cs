using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleJoystickCamera
/// </summary>
/// <remarks>
///    interactive manipulation of the camera
///
///
/// vtkInteractorStyleJoystickCamera allows the user to move (rotate, pan,
/// etc.) the camera, the point of view for the scene.  The position of the
/// mouse relative to the center of the scene determines the speed at which
/// the camera moves, and the speed of the mouse movement determines the
/// acceleration of the camera, so the camera continues to move even if the
/// mouse if not moving.
/// For a 3-button mouse, the left button is for rotation, the right button
/// for zooming, the middle button for panning, and ctrl + left button for
/// spinning.  (With fewer mouse buttons, ctrl + shift + left button is
/// for zooming, and shift + left button is for panning.)
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyleJoystickActor vtkInteractorStyleTrackballCamera
/// vtkInteractorStyleTrackballActor
/// </seealso>
public class vtkInteractorStyleJoystickCamera : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleJoystickCamera";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleJoystickCamera()
	{
		MRClassNameKey = "class vtkInteractorStyleJoystickCamera";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleJoystickCamera"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleJoystickCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleJoystickCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleJoystickCamera New()
	{
		vtkInteractorStyleJoystickCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleJoystickCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleJoystickCamera()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleJoystickCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkInteractorStyleJoystickCamera_Dolly_01(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Dolly()
	{
		vtkInteractorStyleJoystickCamera_Dolly_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleJoystickCamera_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleJoystickCamera_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleJoystickCamera_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleJoystickCamera_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleJoystickCamera_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleJoystickCamera_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleJoystickCamera_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleJoystickCamera_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleJoystickCamera_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleJoystickCamera NewInstance()
	{
		vtkInteractorStyleJoystickCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleJoystickCamera_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnLeftButtonDown_08(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleJoystickCamera_OnLeftButtonDown_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnLeftButtonUp_09(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleJoystickCamera_OnLeftButtonUp_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnMiddleButtonDown_10(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleJoystickCamera_OnMiddleButtonDown_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnMiddleButtonUp_11(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleJoystickCamera_OnMiddleButtonUp_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnMouseMove_12(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleJoystickCamera_OnMouseMove_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnMouseWheelBackward_13(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseWheelBackward()
	{
		vtkInteractorStyleJoystickCamera_OnMouseWheelBackward_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnMouseWheelForward_14(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseWheelForward()
	{
		vtkInteractorStyleJoystickCamera_OnMouseWheelForward_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnRightButtonDown_15(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleJoystickCamera_OnRightButtonDown_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_OnRightButtonUp_16(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleJoystickCamera_OnRightButtonUp_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_Pan_17(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Pan()
	{
		vtkInteractorStyleJoystickCamera_Pan_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_Rotate_18(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Rotate()
	{
		vtkInteractorStyleJoystickCamera_Rotate_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleJoystickCamera_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleJoystickCamera SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleJoystickCamera vtkInteractorStyleJoystickCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleJoystickCamera_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleJoystickCamera2 = (vtkInteractorStyleJoystickCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleJoystickCamera2.Register(null);
			}
		}
		return vtkInteractorStyleJoystickCamera2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleJoystickCamera_Spin_20(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Spin()
	{
		vtkInteractorStyleJoystickCamera_Spin_20(GetCppThis());
	}
}
