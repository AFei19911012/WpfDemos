using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleRubberBand3D
/// </summary>
/// <remarks>
///    A rubber band interactor for a 3D view
///
///
/// vtkInteractorStyleRubberBand3D manages interaction in a 3D view.
/// The style also allows draws a rubber band using the left button.
/// All camera changes invoke StartInteractionEvent when the button
/// is pressed, InteractionEvent when the mouse (or wheel) is moved,
/// and EndInteractionEvent when the button is released.  The bindings
/// are as follows:
/// Left mouse - Select (invokes a SelectionChangedEvent).
/// Right mouse - Rotate.
/// Shift + right mouse - Zoom.
/// Middle mouse - Pan.
/// Scroll wheel - Zoom.
/// </remarks>
public class vtkInteractorStyleRubberBand3D : vtkInteractorStyleTrackballCamera
{
	/// <summary>
	/// Selection types
	/// </summary>
	public enum SELECT_NORMAL_WrapperEnum
	{
		/// <summary>enum member</summary>
		SELECT_NORMAL,
		/// <summary>enum member</summary>
		SELECT_UNION
	}

	/// <summary>
	/// Current interaction state
	/// </summary>
	public enum NONE_WrapperEnum
	{
		/// <summary>enum member</summary>
		NONE = 0,
		/// <summary>enum member</summary>
		PANNING = 1,
		/// <summary>enum member</summary>
		ROTATING = 3,
		/// <summary>enum member</summary>
		SELECTING = 4,
		/// <summary>enum member</summary>
		ZOOMING = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBand3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleRubberBand3D()
	{
		MRClassNameKey = "class vtkInteractorStyleRubberBand3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBand3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleRubberBand3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBand3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleRubberBand3D New()
	{
		vtkInteractorStyleRubberBand3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBand3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleRubberBand3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleRubberBand3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkInteractorStyleRubberBand3D_GetEndPosition_01(HandleRef pThis);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual int[] GetEndPosition()
	{
		IntPtr intPtr = vtkInteractorStyleRubberBand3D_GetEndPosition_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_GetEndPosition_02(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual void GetEndPosition(ref int _arg1, ref int _arg2)
	{
		vtkInteractorStyleRubberBand3D_GetEndPosition_02(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_GetEndPosition_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual void GetEndPosition(IntPtr _arg)
	{
		vtkInteractorStyleRubberBand3D_GetEndPosition_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBand3D_GetInteraction_04(HandleRef pThis);

	/// <summary>
	/// Current interaction state
	/// </summary>
	public virtual int GetInteraction()
	{
		return vtkInteractorStyleRubberBand3D_GetInteraction_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleRubberBand3D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleRubberBand3D_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleRubberBand3D_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleRubberBand3D_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInteractorStyleRubberBand3D_GetRenderOnMouseMove_07(HandleRef pThis);

	/// <summary>
	/// Whether to invoke a render when the mouse moves.
	/// </summary>
	public virtual bool GetRenderOnMouseMove()
	{
		return (vtkInteractorStyleRubberBand3D_GetRenderOnMouseMove_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBand3D_GetStartPosition_08(HandleRef pThis);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual int[] GetStartPosition()
	{
		IntPtr intPtr = vtkInteractorStyleRubberBand3D_GetStartPosition_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_GetStartPosition_09(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual void GetStartPosition(ref int _arg1, ref int _arg2)
	{
		vtkInteractorStyleRubberBand3D_GetStartPosition_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_GetStartPosition_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual void GetStartPosition(IntPtr _arg)
	{
		vtkInteractorStyleRubberBand3D_GetStartPosition_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBand3D_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleRubberBand3D_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBand3D_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleRubberBand3D_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBand3D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleRubberBand3D NewInstance()
	{
		vtkInteractorStyleRubberBand3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBand3D_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnLeftButtonDown_15(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleRubberBand3D_OnLeftButtonDown_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnLeftButtonUp_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleRubberBand3D_OnLeftButtonUp_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnMiddleButtonDown_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleRubberBand3D_OnMiddleButtonDown_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnMiddleButtonUp_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleRubberBand3D_OnMiddleButtonUp_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnMouseMove_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleRubberBand3D_OnMouseMove_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnMouseWheelBackward_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMouseWheelBackward()
	{
		vtkInteractorStyleRubberBand3D_OnMouseWheelBackward_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnMouseWheelForward_21(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMouseWheelForward()
	{
		vtkInteractorStyleRubberBand3D_OnMouseWheelForward_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnRightButtonDown_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleRubberBand3D_OnRightButtonDown_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_OnRightButtonUp_23(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleRubberBand3D_OnRightButtonUp_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOff_24(HandleRef pThis);

	/// <summary>
	/// Whether to invoke a render when the mouse moves.
	/// </summary>
	public virtual void RenderOnMouseMoveOff()
	{
		vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOn_25(HandleRef pThis);

	/// <summary>
	/// Whether to invoke a render when the mouse moves.
	/// </summary>
	public virtual void RenderOnMouseMoveOn()
	{
		vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBand3D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleRubberBand3D SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleRubberBand3D vtkInteractorStyleRubberBand3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBand3D_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleRubberBand3D2 = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleRubberBand3D2.Register(null);
			}
		}
		return vtkInteractorStyleRubberBand3D2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand3D_SetRenderOnMouseMove_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to invoke a render when the mouse moves.
	/// </summary>
	public virtual void SetRenderOnMouseMove(bool _arg)
	{
		vtkInteractorStyleRubberBand3D_SetRenderOnMouseMove_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
