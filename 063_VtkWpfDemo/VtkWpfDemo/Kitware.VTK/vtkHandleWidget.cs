using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHandleWidget
/// </summary>
/// <remarks>
///    a general widget for moving handles
///
/// The vtkHandleWidget is used to position a handle.  A handle is a widget
/// with a position (in display and world space). Various appearances are
/// available depending on its associated representation. The widget provides
/// methods for translation, including constrained translation along
/// coordinate axes. To use this widget, create and associate a representation
/// with the widget.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
///   LeftButtonPressEvent - select focal point of widget
///   LeftButtonReleaseEvent - end selection
///   MiddleButtonPressEvent - translate widget
///   MiddleButtonReleaseEvent - end translation
///   RightButtonPressEvent - scale widget
///   RightButtonReleaseEvent - end scaling
///   MouseMoveEvent - interactive movement across widget
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkHandleWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- focal point is being selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Translate -- translate the widget
///   vtkWidgetEvent::EndTranslate -- end widget translation
///   vtkWidgetEvent::Scale -- scale the widget
///   vtkWidgetEvent::EndScale -- end scaling the widget
///   vtkWidgetEvent::Move -- a request for widget motion
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkHandleWidget
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
/// </remarks>
public class vtkHandleWidget : vtkAbstractWidget
{
	/// <summary>
	/// Allow the widget to be visible as an inactive representation when disabled.
	/// By default, this is false i.e. the representation is not visible when the
	/// widget is disabled.
	/// </summary>
	public enum WidgetStateType
	{
		/// <summary>enum member</summary>
		Active = 1,
		/// <summary>enum member</summary>
		Inactive = 2,
		/// <summary>enum member</summary>
		Start = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHandleWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHandleWidget()
	{
		MRClassNameKey = "class vtkHandleWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHandleWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHandleWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkHandleWidget New()
	{
		vtkHandleWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkHandleWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHandleWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_AllowHandleResizeOff_01(HandleRef pThis);

	/// <summary>
	/// Allow resizing of handles ? By default the right mouse button scales
	/// the handle size.
	/// </summary>
	public virtual void AllowHandleResizeOff()
	{
		vtkHandleWidget_AllowHandleResizeOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_AllowHandleResizeOn_02(HandleRef pThis);

	/// <summary>
	/// Allow resizing of handles ? By default the right mouse button scales
	/// the handle size.
	/// </summary>
	public virtual void AllowHandleResizeOn()
	{
		vtkHandleWidget_AllowHandleResizeOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_CreateDefaultRepresentation_03(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set. By default
	/// an instance of vtkPointHandleRepresentation3D is created.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkHandleWidget_CreateDefaultRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_EnableAxisConstraintOff_04(HandleRef pThis);

	/// <summary>
	/// Enable / disable axis constrained motion of the handles. By default the
	/// widget responds to the shift modifier to constrain the handle along the
	/// axis closest aligned with the motion vector.
	/// </summary>
	public virtual void EnableAxisConstraintOff()
	{
		vtkHandleWidget_EnableAxisConstraintOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_EnableAxisConstraintOn_05(HandleRef pThis);

	/// <summary>
	/// Enable / disable axis constrained motion of the handles. By default the
	/// widget responds to the shift modifier to constrain the handle along the
	/// axis closest aligned with the motion vector.
	/// </summary>
	public virtual void EnableAxisConstraintOn()
	{
		vtkHandleWidget_EnableAxisConstraintOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_EnableTranslationOff_06(HandleRef pThis);

	/// <summary>
	/// Enable moving of handles. By default, the handle can be moved.
	/// </summary>
	public virtual void EnableTranslationOff()
	{
		vtkHandleWidget_EnableTranslationOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_EnableTranslationOn_07(HandleRef pThis);

	/// <summary>
	/// Enable moving of handles. By default, the handle can be moved.
	/// </summary>
	public virtual void EnableTranslationOn()
	{
		vtkHandleWidget_EnableTranslationOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleWidget_GetAllowHandleResize_08(HandleRef pThis);

	/// <summary>
	/// Allow resizing of handles ? By default the right mouse button scales
	/// the handle size.
	/// </summary>
	public virtual int GetAllowHandleResize()
	{
		return vtkHandleWidget_GetAllowHandleResize_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleWidget_GetEnableAxisConstraint_09(HandleRef pThis);

	/// <summary>
	/// Enable / disable axis constrained motion of the handles. By default the
	/// widget responds to the shift modifier to constrain the handle along the
	/// axis closest aligned with the motion vector.
	/// </summary>
	public virtual int GetEnableAxisConstraint()
	{
		return vtkHandleWidget_GetEnableAxisConstraint_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleWidget_GetEnableTranslation_10(HandleRef pThis);

	/// <summary>
	/// Enable moving of handles. By default, the handle can be moved.
	/// </summary>
	public virtual int GetEnableTranslation()
	{
		return vtkHandleWidget_GetEnableTranslation_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleWidget_GetHandleRepresentation_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkHandleRepresentation.
	/// </summary>
	public vtkHandleRepresentation GetHandleRepresentation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleWidget_GetHandleRepresentation_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHandleWidget_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHandleWidget_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHandleWidget_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHandleWidget_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleWidget_GetShowInactive_14(HandleRef pThis);

	/// <summary>
	/// Allow the widget to be visible as an inactive representation when disabled.
	/// By default, this is false i.e. the representation is not visible when the
	/// widget is disabled.
	/// </summary>
	public virtual int GetShowInactive()
	{
		return vtkHandleWidget_GetShowInactive_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleWidget_GetWidgetState_15(HandleRef pThis);

	/// <summary>
	/// Get the widget state.
	/// </summary>
	public virtual int GetWidgetState()
	{
		return vtkHandleWidget_GetWidgetState_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleWidget_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHandleWidget_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHandleWidget_IsTypeOf_17(string type);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHandleWidget_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleWidget_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public new vtkHandleWidget NewInstance()
	{
		vtkHandleWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleWidget_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHandleWidget_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class macros.
	/// </summary>
	public new static vtkHandleWidget SafeDownCast(vtkObjectBase o)
	{
		vtkHandleWidget vtkHandleWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHandleWidget_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleWidget2 = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleWidget2.Register(null);
			}
		}
		return vtkHandleWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_SetAllowHandleResize_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Allow resizing of handles ? By default the right mouse button scales
	/// the handle size.
	/// </summary>
	public virtual void SetAllowHandleResize(int _arg)
	{
		vtkHandleWidget_SetAllowHandleResize_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_SetEnableAxisConstraint_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable / disable axis constrained motion of the handles. By default the
	/// widget responds to the shift modifier to constrain the handle along the
	/// axis closest aligned with the motion vector.
	/// </summary>
	public virtual void SetEnableAxisConstraint(int _arg)
	{
		vtkHandleWidget_SetEnableAxisConstraint_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_SetEnableTranslation_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable moving of handles. By default, the handle can be moved.
	/// </summary>
	public virtual void SetEnableTranslation(int _arg)
	{
		vtkHandleWidget_SetEnableTranslation_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_SetEnabled_24(HandleRef pThis, int enabling);

	/// <summary>
	/// Enable/disable widget.
	/// Custom override for the SetEnabled method to allow for the inactive state.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkHandleWidget_SetEnabled_24(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_SetRepresentation_25(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkHandleRepresentation r)
	{
		vtkHandleWidget_SetRepresentation_25(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_SetShowInactive_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Allow the widget to be visible as an inactive representation when disabled.
	/// By default, this is false i.e. the representation is not visible when the
	/// widget is disabled.
	/// </summary>
	public virtual void SetShowInactive(int _arg)
	{
		vtkHandleWidget_SetShowInactive_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_ShowInactiveOff_27(HandleRef pThis);

	/// <summary>
	/// Allow the widget to be visible as an inactive representation when disabled.
	/// By default, this is false i.e. the representation is not visible when the
	/// widget is disabled.
	/// </summary>
	public virtual void ShowInactiveOff()
	{
		vtkHandleWidget_ShowInactiveOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHandleWidget_ShowInactiveOn_28(HandleRef pThis);

	/// <summary>
	/// Allow the widget to be visible as an inactive representation when disabled.
	/// By default, this is false i.e. the representation is not visible when the
	/// widget is disabled.
	/// </summary>
	public virtual void ShowInactiveOn()
	{
		vtkHandleWidget_ShowInactiveOn_28(GetCppThis());
	}
}
