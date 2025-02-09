using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleMultiTouchCamera
/// </summary>
/// <remarks>
///    multitouch manipulation of the camera
///
/// vtkInteractorStyleMultiTouchCamera allows the user to interactively
/// manipulate (rotate, pan, etc.) the camera, the viewpoint of the scene
/// using multitouch gestures in addition to regular gestures
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyleTrackballActor vtkInteractorStyleJoystickCamera
/// vtkInteractorStyleJoystickActor
/// </seealso>
public class vtkInteractorStyleMultiTouchCamera : vtkInteractorStyleTrackballCamera
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleMultiTouchCamera";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleMultiTouchCamera()
	{
		MRClassNameKey = "class vtkInteractorStyleMultiTouchCamera";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleMultiTouchCamera"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleMultiTouchCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleMultiTouchCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleMultiTouchCamera New()
	{
		vtkInteractorStyleMultiTouchCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleMultiTouchCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleMultiTouchCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleMultiTouchCamera()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleMultiTouchCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkInteractorStyleMultiTouchCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleMultiTouchCamera_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleMultiTouchCamera_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleMultiTouchCamera_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleMultiTouchCamera_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleMultiTouchCamera_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleMultiTouchCamera_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleMultiTouchCamera_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleMultiTouchCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleMultiTouchCamera NewInstance()
	{
		vtkInteractorStyleMultiTouchCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleMultiTouchCamera_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleMultiTouchCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnEndPan_07(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnEndPan()
	{
		vtkInteractorStyleMultiTouchCamera_OnEndPan_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnEndPinch_08(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnEndPinch()
	{
		vtkInteractorStyleMultiTouchCamera_OnEndPinch_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnEndRotate_09(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnEndRotate()
	{
		vtkInteractorStyleMultiTouchCamera_OnEndRotate_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnPan_10(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnPan()
	{
		vtkInteractorStyleMultiTouchCamera_OnPan_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnPinch_11(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnPinch()
	{
		vtkInteractorStyleMultiTouchCamera_OnPinch_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnRotate_12(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnRotate()
	{
		vtkInteractorStyleMultiTouchCamera_OnRotate_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnStartPan_13(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnStartPan()
	{
		vtkInteractorStyleMultiTouchCamera_OnStartPan_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnStartPinch_14(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnStartPinch()
	{
		vtkInteractorStyleMultiTouchCamera_OnStartPinch_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleMultiTouchCamera_OnStartRotate_15(HandleRef pThis);

	/// <summary>
	/// Event bindings for gestures
	/// </summary>
	public override void OnStartRotate()
	{
		vtkInteractorStyleMultiTouchCamera_OnStartRotate_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleMultiTouchCamera_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleMultiTouchCamera SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleMultiTouchCamera vtkInteractorStyleMultiTouchCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleMultiTouchCamera_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleMultiTouchCamera2 = (vtkInteractorStyleMultiTouchCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleMultiTouchCamera2.Register(null);
			}
		}
		return vtkInteractorStyleMultiTouchCamera2;
	}
}
