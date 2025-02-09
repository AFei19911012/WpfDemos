using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelCoordinatesInteractorStyle
/// </summary>
/// <remarks>
///    interactive manipulation of the camera specialized for parallel coordinates
///
/// vtkParallelCoordinatesInteractorStyle allows the user to interactively manipulate
/// (rotate, pan, zoom etc.) the camera.
/// Several events are overloaded from its superclass
/// vtkInteractorStyleTrackballCamera, hence the mouse bindings are different.
/// (The bindings keep the camera's view plane normal perpendicular to the x-y plane.)
/// In summary, the mouse events are as follows:
/// + Left Mouse button triggers window level events
/// + CTRL Left Mouse spins the camera around its view plane normal
/// + SHIFT Left Mouse pans the camera
/// + CTRL SHIFT Left Mouse dollys (a positional zoom) the camera
/// + Middle mouse button pans the camera
/// + Right mouse button dollys the camera.
/// + SHIFT Right Mouse triggers pick events
///
/// Note that the renderer's actors are not moved; instead the camera is moved.
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyle vtkInteractorStyleTrackballActor
/// vtkInteractorStyleJoystickCamera vtkInteractorStyleJoystickActor
/// </seealso>
public class vtkParallelCoordinatesInteractorStyle : vtkInteractorStyleTrackballCamera
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum INTERACT_HOVER_WrapperEnum
	{
		/// <summary>enum member</summary>
		INTERACT_HOVER = 0,
		/// <summary>enum member</summary>
		INTERACT_INSPECT = 1,
		/// <summary>enum member</summary>
		INTERACT_PAN = 3,
		/// <summary>enum member</summary>
		INTERACT_ZOOM = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesInteractorStyle";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelCoordinatesInteractorStyle()
	{
		MRClassNameKey = "class vtkParallelCoordinatesInteractorStyle";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesInteractorStyle"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelCoordinatesInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesInteractorStyle New()
	{
		vtkParallelCoordinatesInteractorStyle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkParallelCoordinatesInteractorStyle()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParallelCoordinatesInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParallelCoordinatesInteractorStyle_EndInspect_01(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public virtual void EndInspect()
	{
		vtkParallelCoordinatesInteractorStyle_EndInspect_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_EndPan_02(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void EndPan()
	{
		vtkParallelCoordinatesInteractorStyle_EndPan_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_EndZoom_03(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void EndZoom()
	{
		vtkParallelCoordinatesInteractorStyle_EndZoom_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_04(HandleRef pThis);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual int[] GetCursorCurrentPosition()
	{
		IntPtr intPtr = vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_05(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual void GetCursorCurrentPosition(ref int _arg1, ref int _arg2)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_05(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual void GetCursorCurrentPosition(IntPtr _arg)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_07(HandleRef pThis, HandleRef viewport, IntPtr pos);

	/// <summary>
	/// Get the cursor positions in a given coordinate system
	/// </summary>
	public void GetCursorCurrentPosition(vtkViewport viewport, IntPtr pos)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorCurrentPosition_07(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), pos);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_08(HandleRef pThis);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual int[] GetCursorLastPosition()
	{
		IntPtr intPtr = vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_09(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual void GetCursorLastPosition(ref int _arg1, ref int _arg2)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual void GetCursorLastPosition(IntPtr _arg)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_11(HandleRef pThis, HandleRef viewport, IntPtr pos);

	/// <summary>
	/// Get the cursor positions in a given coordinate system
	/// </summary>
	public void GetCursorLastPosition(vtkViewport viewport, IntPtr pos)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorLastPosition_11(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), pos);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_12(HandleRef pThis);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual int[] GetCursorStartPosition()
	{
		IntPtr intPtr = vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_12(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_13(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual void GetCursorStartPosition(ref int _arg1, ref int _arg2)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_13(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the cursor positions in pixel coords
	/// </summary>
	public virtual void GetCursorStartPosition(IntPtr _arg)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_15(HandleRef pThis, HandleRef viewport, IntPtr pos);

	/// <summary>
	/// Get the cursor positions in a given coordinate system
	/// </summary>
	public void GetCursorStartPosition(vtkViewport viewport, IntPtr pos)
	{
		vtkParallelCoordinatesInteractorStyle_GetCursorStartPosition_15(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef), pos);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesInteractorStyle_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelCoordinatesInteractorStyle_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesInteractorStyle_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelCoordinatesInteractorStyle_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_Inspect_18(HandleRef pThis, int x, int y);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public virtual void Inspect(int x, int y)
	{
		vtkParallelCoordinatesInteractorStyle_Inspect_18(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesInteractorStyle_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelCoordinatesInteractorStyle_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesInteractorStyle_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelCoordinatesInteractorStyle_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParallelCoordinatesInteractorStyle NewInstance()
	{
		vtkParallelCoordinatesInteractorStyle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesInteractorStyle_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnChar_23(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public override void OnChar()
	{
		vtkParallelCoordinatesInteractorStyle_OnChar_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeave_24(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeave()
	{
		vtkParallelCoordinatesInteractorStyle_OnLeave_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeftButtonDown_25(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkParallelCoordinatesInteractorStyle_OnLeftButtonDown_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnLeftButtonUp_26(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkParallelCoordinatesInteractorStyle_OnLeftButtonUp_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnMiddleButtonDown_27(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkParallelCoordinatesInteractorStyle_OnMiddleButtonDown_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnMiddleButtonUp_28(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkParallelCoordinatesInteractorStyle_OnMiddleButtonUp_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnMouseMove_29(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkParallelCoordinatesInteractorStyle_OnMouseMove_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnRightButtonDown_30(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkParallelCoordinatesInteractorStyle_OnRightButtonDown_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_OnRightButtonUp_31(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkParallelCoordinatesInteractorStyle_OnRightButtonUp_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_Pan_32(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Pan()
	{
		vtkParallelCoordinatesInteractorStyle_Pan_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesInteractorStyle_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesInteractorStyle SafeDownCast(vtkObjectBase o)
	{
		vtkParallelCoordinatesInteractorStyle vtkParallelCoordinatesInteractorStyle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesInteractorStyle_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelCoordinatesInteractorStyle2 = (vtkParallelCoordinatesInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelCoordinatesInteractorStyle2.Register(null);
			}
		}
		return vtkParallelCoordinatesInteractorStyle2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_StartInspect_34(HandleRef pThis, int x, int y);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public virtual void StartInspect(int x, int y)
	{
		vtkParallelCoordinatesInteractorStyle_StartInspect_34(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_StartPan_35(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void StartPan()
	{
		vtkParallelCoordinatesInteractorStyle_StartPan_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_StartZoom_36(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void StartZoom()
	{
		vtkParallelCoordinatesInteractorStyle_StartZoom_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesInteractorStyle_Zoom_37(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void Zoom()
	{
		vtkParallelCoordinatesInteractorStyle_Zoom_37(GetCppThis());
	}
}
