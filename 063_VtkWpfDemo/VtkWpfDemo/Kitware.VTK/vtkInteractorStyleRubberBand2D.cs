using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleRubberBand2D
/// </summary>
/// <remarks>
///    A rubber band interactor for a 2D view
///
///
/// vtkInteractorStyleRubberBand2D manages interaction in a 2D view.
/// Camera rotation is not allowed with this interactor style.
/// Zooming affects the camera's parallel scale only, and assumes
/// that the camera is in parallel projection mode.
/// The style also allows draws a rubber band using the left button.
/// All camera changes invoke StartInteractionEvent when the button
/// is pressed, InteractionEvent when the mouse (or wheel) is moved,
/// and EndInteractionEvent when the button is released.  The bindings
/// are as follows:
/// Left mouse - Select (invokes a SelectionChangedEvent).
/// Right mouse - Zoom.
/// Middle mouse - Pan.
/// Scroll wheel - Zoom.
/// </remarks>
public class vtkInteractorStyleRubberBand2D : vtkInteractorStyle
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
		SELECTING = 3,
		/// <summary>enum member</summary>
		ZOOMING = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBand2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleRubberBand2D()
	{
		MRClassNameKey = "class vtkInteractorStyleRubberBand2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBand2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleRubberBand2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBand2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleRubberBand2D New()
	{
		vtkInteractorStyleRubberBand2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBand2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleRubberBand2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleRubberBand2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkInteractorStyleRubberBand2D_GetEndPosition_01(HandleRef pThis);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual int[] GetEndPosition()
	{
		IntPtr intPtr = vtkInteractorStyleRubberBand2D_GetEndPosition_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_GetEndPosition_02(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual void GetEndPosition(ref int _arg1, ref int _arg2)
	{
		vtkInteractorStyleRubberBand2D_GetEndPosition_02(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_GetEndPosition_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual void GetEndPosition(IntPtr _arg)
	{
		vtkInteractorStyleRubberBand2D_GetEndPosition_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBand2D_GetInteraction_04(HandleRef pThis);

	/// <summary>
	/// Current interaction state
	/// </summary>
	public virtual int GetInteraction()
	{
		return vtkInteractorStyleRubberBand2D_GetInteraction_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleRubberBand2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleRubberBand2D_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleRubberBand2D_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleRubberBand2D_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInteractorStyleRubberBand2D_GetRenderOnMouseMove_07(HandleRef pThis);

	/// <summary>
	/// Whether to invoke a render when the mouse moves.
	/// </summary>
	public virtual bool GetRenderOnMouseMove()
	{
		return (vtkInteractorStyleRubberBand2D_GetRenderOnMouseMove_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBand2D_GetStartPosition_08(HandleRef pThis);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual int[] GetStartPosition()
	{
		IntPtr intPtr = vtkInteractorStyleRubberBand2D_GetStartPosition_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_GetStartPosition_09(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual void GetStartPosition(ref int _arg1, ref int _arg2)
	{
		vtkInteractorStyleRubberBand2D_GetStartPosition_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_GetStartPosition_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Access to the start and end positions (display coordinates) of the rubber
	/// band pick area. This is a convenience method for the wrapped languages
	/// since the event callData is lost when using those wrappings.
	/// </summary>
	public virtual void GetStartPosition(IntPtr _arg)
	{
		vtkInteractorStyleRubberBand2D_GetStartPosition_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBand2D_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleRubberBand2D_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBand2D_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleRubberBand2D_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBand2D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleRubberBand2D NewInstance()
	{
		vtkInteractorStyleRubberBand2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBand2D_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnLeftButtonDown_15(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleRubberBand2D_OnLeftButtonDown_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnLeftButtonUp_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleRubberBand2D_OnLeftButtonUp_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnMiddleButtonDown_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleRubberBand2D_OnMiddleButtonDown_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnMiddleButtonUp_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleRubberBand2D_OnMiddleButtonUp_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnMouseMove_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleRubberBand2D_OnMouseMove_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnMouseWheelBackward_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMouseWheelBackward()
	{
		vtkInteractorStyleRubberBand2D_OnMouseWheelBackward_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnMouseWheelForward_21(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnMouseWheelForward()
	{
		vtkInteractorStyleRubberBand2D_OnMouseWheelForward_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnRightButtonDown_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleRubberBand2D_OnRightButtonDown_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_OnRightButtonUp_23(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleRubberBand2D_OnRightButtonUp_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOff_24(HandleRef pThis);

	/// <summary>
	/// Whether to invoke a render when the mouse moves.
	/// </summary>
	public virtual void RenderOnMouseMoveOff()
	{
		vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOn_25(HandleRef pThis);

	/// <summary>
	/// Whether to invoke a render when the mouse moves.
	/// </summary>
	public virtual void RenderOnMouseMoveOn()
	{
		vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBand2D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleRubberBand2D SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleRubberBand2D vtkInteractorStyleRubberBand2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBand2D_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleRubberBand2D2 = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleRubberBand2D2.Register(null);
			}
		}
		return vtkInteractorStyleRubberBand2D2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBand2D_SetRenderOnMouseMove_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to invoke a render when the mouse moves.
	/// </summary>
	public virtual void SetRenderOnMouseMove(bool _arg)
	{
		vtkInteractorStyleRubberBand2D_SetRenderOnMouseMove_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
