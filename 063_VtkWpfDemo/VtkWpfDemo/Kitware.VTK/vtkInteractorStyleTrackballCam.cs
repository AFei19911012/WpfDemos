using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleTrackballCamera
/// </summary>
/// <remarks>
///    interactive manipulation of the camera
///
/// vtkInteractorStyleTrackballCamera allows the user to interactively
/// manipulate (rotate, pan, etc.) the camera, the viewpoint of the scene.  In
/// trackball interaction, the magnitude of the mouse motion is proportional
/// to the camera motion associated with a particular mouse binding. For
/// example, small left-button motions cause small changes in the rotation of
/// the camera around its focal point. For a 3-button mouse, the left button
/// is for rotation, the right button for zooming, the middle button for
/// panning, ctrl + left button for spinning, and shift + right button for
/// environment rotation. (With fewer mouse buttons, ctrl + shift + left button
/// is for zooming, and shift + left button is for panning.)
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyleTrackballActor vtkInteractorStyleJoystickCamera
/// vtkInteractorStyleJoystickActor
/// </seealso>
public class vtkInteractorStyleTrackballCamera : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTrackballCamera";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleTrackballCamera()
	{
		MRClassNameKey = "class vtkInteractorStyleTrackballCamera";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTrackballCamera"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleTrackballCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTrackballCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleTrackballCamera New()
	{
		vtkInteractorStyleTrackballCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTrackballCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleTrackballCamera()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleTrackballCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkInteractorStyleTrackballCamera_Dolly_01(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Dolly()
	{
		vtkInteractorStyleTrackballCamera_Dolly_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_EnvironmentRotate_02(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void EnvironmentRotate()
	{
		vtkInteractorStyleTrackballCamera_EnvironmentRotate_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInteractorStyleTrackballCamera_GetMotionFactor_03(HandleRef pThis);

	/// <summary>
	/// Set the apparent sensitivity of the interactor style to mouse motion.
	/// </summary>
	public virtual double GetMotionFactor()
	{
		return vtkInteractorStyleTrackballCamera_GetMotionFactor_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleTrackballCamera_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleTrackballCamera_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleTrackballCamera_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleTrackballCamera_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTrackballCamera_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleTrackballCamera_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTrackballCamera_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleTrackballCamera_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTrackballCamera_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleTrackballCamera NewInstance()
	{
		vtkInteractorStyleTrackballCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTrackballCamera_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnLeftButtonDown_10(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleTrackballCamera_OnLeftButtonDown_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnLeftButtonUp_11(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleTrackballCamera_OnLeftButtonUp_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnMiddleButtonDown_12(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleTrackballCamera_OnMiddleButtonDown_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnMiddleButtonUp_13(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleTrackballCamera_OnMiddleButtonUp_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnMouseMove_14(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleTrackballCamera_OnMouseMove_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnMouseWheelBackward_15(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseWheelBackward()
	{
		vtkInteractorStyleTrackballCamera_OnMouseWheelBackward_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnMouseWheelForward_16(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseWheelForward()
	{
		vtkInteractorStyleTrackballCamera_OnMouseWheelForward_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnRightButtonDown_17(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleTrackballCamera_OnRightButtonDown_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_OnRightButtonUp_18(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleTrackballCamera_OnRightButtonUp_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_Pan_19(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Pan()
	{
		vtkInteractorStyleTrackballCamera_Pan_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_Rotate_20(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Rotate()
	{
		vtkInteractorStyleTrackballCamera_Rotate_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTrackballCamera_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleTrackballCamera SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleTrackballCamera vtkInteractorStyleTrackballCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTrackballCamera_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleTrackballCamera2 = (vtkInteractorStyleTrackballCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleTrackballCamera2.Register(null);
			}
		}
		return vtkInteractorStyleTrackballCamera2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_SetMotionFactor_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the apparent sensitivity of the interactor style to mouse motion.
	/// </summary>
	public virtual void SetMotionFactor(double _arg)
	{
		vtkInteractorStyleTrackballCamera_SetMotionFactor_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballCamera_Spin_23(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Spin()
	{
		vtkInteractorStyleTrackballCamera_Spin_23(GetCppThis());
	}
}
