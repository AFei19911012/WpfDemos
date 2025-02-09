using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleTrackballActor
/// </summary>
/// <remarks>
///    manipulate objects in the scene independent of each other
///
/// vtkInteractorStyleTrackballActor allows the user to interact with (rotate,
/// pan, etc.) objects in the scene independent of each other.  In trackball
/// interaction, the magnitude of the mouse motion is proportional to the
/// actor motion associated with a particular mouse binding. For example,
/// small left-button motions cause small changes in the rotation of the
/// actor around its center point.
///
/// The mouse bindings are as follows. For a 3-button mouse, the left button
/// is for rotation, the right button for zooming, the middle button for
/// panning, and ctrl + left button for spinning.  (With fewer mouse buttons,
/// ctrl + shift + left button is for zooming, and shift + left button is for
/// panning.)
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyleTrackballCamera vtkInteractorStyleJoystickActor
/// vtkInteractorStyleJoystickCamera
/// </seealso>
public class vtkInteractorStyleTrackballActor : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTrackballActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleTrackballActor()
	{
		MRClassNameKey = "class vtkInteractorStyleTrackballActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTrackballActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleTrackballActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTrackballActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleTrackballActor New()
	{
		vtkInteractorStyleTrackballActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTrackballActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleTrackballActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleTrackballActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkInteractorStyleTrackballActor_Dolly_01(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Dolly()
	{
		vtkInteractorStyleTrackballActor_Dolly_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleTrackballActor_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleTrackballActor_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleTrackballActor_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleTrackballActor_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTrackballActor_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleTrackballActor_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleTrackballActor_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleTrackballActor_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTrackballActor_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleTrackballActor NewInstance()
	{
		vtkInteractorStyleTrackballActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTrackballActor_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_OnLeftButtonDown_08(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleTrackballActor_OnLeftButtonDown_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_OnLeftButtonUp_09(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleTrackballActor_OnLeftButtonUp_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_OnMiddleButtonDown_10(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleTrackballActor_OnMiddleButtonDown_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_OnMiddleButtonUp_11(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleTrackballActor_OnMiddleButtonUp_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_OnMouseMove_12(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleTrackballActor_OnMouseMove_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_OnRightButtonDown_13(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleTrackballActor_OnRightButtonDown_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_OnRightButtonUp_14(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleTrackballActor_OnRightButtonUp_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_Pan_15(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Pan()
	{
		vtkInteractorStyleTrackballActor_Pan_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_Rotate_16(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Rotate()
	{
		vtkInteractorStyleTrackballActor_Rotate_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleTrackballActor_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleTrackballActor SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleTrackballActor vtkInteractorStyleTrackballActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleTrackballActor_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleTrackballActor2 = (vtkInteractorStyleTrackballActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleTrackballActor2.Register(null);
			}
		}
		return vtkInteractorStyleTrackballActor2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_Spin_18(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Spin()
	{
		vtkInteractorStyleTrackballActor_Spin_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleTrackballActor_UniformScale_19(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void UniformScale()
	{
		vtkInteractorStyleTrackballActor_UniformScale_19(GetCppThis());
	}
}
