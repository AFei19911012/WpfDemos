using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractWidget
/// </summary>
/// <remarks>
///    define the API for widget / widget representation
///
/// The vtkAbstractWidget defines an API and implements methods common to all
/// widgets using the interaction/representation design. In this design, the
/// term interaction means that part of the widget that performs event
/// handling, while the representation corresponds to a vtkProp (or the
/// subclass vtkWidgetRepresentation) used to represent the
/// widget. vtkAbstractWidget also implements some methods common to all
/// subclasses.
///
/// Note that vtkAbstractWidget provides access to the
/// vtkWidgetEventTranslator.  This class is responsible for translating VTK
/// events (defined in vtkCommand.h) into widget events (defined in
/// vtkWidgetEvent.h). This class can be manipulated so that different VTK
/// events can be mapped into widget events, thereby allowing the modification
/// of event bindings. Each subclass of vtkAbstractWidget defines the events
/// to which it responds.
///
/// @warning
/// Note that the pair ( vtkAbstractWidget / vtkWidgetRepresentation ) is an
/// implementation of the second generation VTK Widgets design. In the first
/// generation design, widgets were implemented in a single monolithic
/// class. This design was problematic because in client-server application
/// it was difficult to manage widgets properly. Also, new "representations"
/// or look-and-feel, for a widget required a whole new class, with a lot of
/// redundant code. The separation of the widget event handling and
/// representation enables users and developers to create new appearances for
/// the widget. It also facilitates parallel processing, where the client
/// application handles events, and remote representations of the widget are
/// slaves to the client (and do not handle events).
///
/// </remarks>
/// <seealso>
///
/// vtkWidgetRepresentation vtkWidgetEventTranslator vtkWidgetCallbackMapper
/// </seealso>
public abstract class vtkAbstractWidget : vtkInteractorObserver
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractWidget()
	{
		MRClassNameKey = "class vtkAbstractWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkAbstractWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set. The
	/// representation defines the geometry of the widget (i.e., how it appears)
	/// as well as providing special methods for manipulting the state and
	/// appearance of the widget.
	/// </summary>
	public virtual void CreateDefaultRepresentation()
	{
		vtkAbstractWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractWidget_GetEventTranslator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the event translator. Careful manipulation of this class enables
	/// the user to override the default event bindings.
	/// </summary>
	public vtkWidgetEventTranslator GetEventTranslator()
	{
		vtkWidgetEventTranslator vtkWidgetEventTranslator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractWidget_GetEventTranslator_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWidgetEventTranslator2 = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWidgetEventTranslator2.Register(null);
			}
		}
		return vtkWidgetEventTranslator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractWidget_GetManagesCursor_03(HandleRef pThis);

	/// <summary>
	/// Turn on or off the management of the cursor. Cursor management is
	/// typically disabled for subclasses when composite widgets are
	/// created. For example, vtkHandleWidgets are often used to create
	/// composite widgets, and the parent widget takes over the cursor
	/// management.
	/// </summary>
	public virtual int GetManagesCursor()
	{
		return vtkAbstractWidget_GetManagesCursor_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractWidget_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros implementing standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractWidget_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractWidget_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard macros implementing standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractWidget_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractWidget_GetParent_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specifying a parent to this widget is used when creating composite
	/// widgets. It is an internal method not meant to be used by the public.
	/// When a widget has a parent, it defers the rendering to the parent. It
	/// may also defer managing the cursor (see ManagesCursor ivar).
	/// </summary>
	public virtual vtkAbstractWidget GetParent()
	{
		vtkAbstractWidget vtkAbstractWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractWidget_GetParent_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractWidget2 = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractWidget2.Register(null);
			}
		}
		return vtkAbstractWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractWidget_GetProcessEvents_07(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual int GetProcessEvents()
	{
		return vtkAbstractWidget_GetProcessEvents_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractWidget_GetProcessEventsMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual int GetProcessEventsMaxValue()
	{
		return vtkAbstractWidget_GetProcessEventsMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractWidget_GetProcessEventsMinValue_09(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual int GetProcessEventsMinValue()
	{
		return vtkAbstractWidget_GetProcessEventsMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractWidget_GetRepresentation_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of
	/// vtkProp (typically a subclass of vtkWidgetRepresentation) so it can be
	/// added to the renderer independent of the widget.
	/// </summary>
	public vtkWidgetRepresentation GetRepresentation()
	{
		vtkWidgetRepresentation vtkWidgetRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractWidget_GetRepresentation_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWidgetRepresentation2 = (vtkWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWidgetRepresentation2.Register(null);
			}
		}
		return vtkWidgetRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractWidget_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros implementing standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractWidget_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractWidget_IsTypeOf_12(string type);

	/// <summary>
	/// Standard macros implementing standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractWidget_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_ManagesCursorOff_13(HandleRef pThis);

	/// <summary>
	/// Turn on or off the management of the cursor. Cursor management is
	/// typically disabled for subclasses when composite widgets are
	/// created. For example, vtkHandleWidgets are often used to create
	/// composite widgets, and the parent widget takes over the cursor
	/// management.
	/// </summary>
	public virtual void ManagesCursorOff()
	{
		vtkAbstractWidget_ManagesCursorOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_ManagesCursorOn_14(HandleRef pThis);

	/// <summary>
	/// Turn on or off the management of the cursor. Cursor management is
	/// typically disabled for subclasses when composite widgets are
	/// created. For example, vtkHandleWidgets are often used to create
	/// composite widgets, and the parent widget takes over the cursor
	/// management.
	/// </summary>
	public virtual void ManagesCursorOn()
	{
		vtkAbstractWidget_ManagesCursorOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractWidget_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros implementing standard VTK methods.
	/// </summary>
	public new vtkAbstractWidget NewInstance()
	{
		vtkAbstractWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractWidget_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_ProcessEventsOff_16(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual void ProcessEventsOff()
	{
		vtkAbstractWidget_ProcessEventsOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_ProcessEventsOn_17(HandleRef pThis);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual void ProcessEventsOn()
	{
		vtkAbstractWidget_ProcessEventsOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_Render_18(HandleRef pThis);

	/// <summary>
	/// This method is called by subclasses when a render method is to be
	/// invoked on the vtkRenderWindowInteractor. This method should be called
	/// (instead of vtkRenderWindow::Render() because it has built into it
	/// optimizations for minimizing renders and/or speeding renders.
	/// </summary>
	public void Render()
	{
		vtkAbstractWidget_Render_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractWidget_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros implementing standard VTK methods.
	/// </summary>
	public new static vtkAbstractWidget SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractWidget vtkAbstractWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractWidget_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractWidget2 = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractWidget2.Register(null);
			}
		}
		return vtkAbstractWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_SetEnabled_20(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods for activating this widget. Note that the widget representation
	/// must be specified or the widget will not appear.
	/// ProcessEvents (On by default) must be On for Enabled widget to respond
	/// to interaction. If ProcessEvents is Off, enabling/disabling a widget
	/// merely affects the visibility of the representation.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkAbstractWidget_SetEnabled_20(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_SetManagesCursor_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on or off the management of the cursor. Cursor management is
	/// typically disabled for subclasses when composite widgets are
	/// created. For example, vtkHandleWidgets are often used to create
	/// composite widgets, and the parent widget takes over the cursor
	/// management.
	/// </summary>
	public virtual void SetManagesCursor(int _arg)
	{
		vtkAbstractWidget_SetManagesCursor_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_SetParent_22(HandleRef pThis, HandleRef parent);

	/// <summary>
	/// Specifying a parent to this widget is used when creating composite
	/// widgets. It is an internal method not meant to be used by the public.
	/// When a widget has a parent, it defers the rendering to the parent. It
	/// may also defer managing the cursor (see ManagesCursor ivar).
	/// </summary>
	public void SetParent(vtkAbstractWidget parent)
	{
		vtkAbstractWidget_SetParent_22(GetCppThis(), parent?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_SetPriority_23(HandleRef pThis, float arg0);

	/// <summary>
	/// Override the superclass method. This will automatically change the
	/// priority of the widget. Unlike the superclass documentation, no
	/// methods such as SetInteractor to null and reset it etc. are necessary
	/// </summary>
	public override void SetPriority(float arg0)
	{
		vtkAbstractWidget_SetPriority_23(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractWidget_SetProcessEvents_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Methods to change whether the widget responds to interaction.
	/// Set this to Off to disable interaction. On by default.
	/// Subclasses must override SetProcessEvents() to make sure
	/// that they pass on the flag to all component widgets.
	/// </summary>
	public virtual void SetProcessEvents(int _arg)
	{
		vtkAbstractWidget_SetProcessEvents_24(GetCppThis(), _arg);
	}
}
