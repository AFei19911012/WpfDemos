using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHoverWidget
/// </summary>
/// <remarks>
///    invoke a vtkTimerEvent when hovering
///
/// The vtkHoverWidget is used to invoke an event when hovering in a render window.
/// Hovering occurs when mouse motion (in the render window) does not occur
/// for a specified amount of time (i.e., TimerDuration). This class can be used
/// as is (by observing TimerEvents) or for class derivation for those classes
/// wishing to do more with the hover event.
///
/// To use this widget, specify an instance of vtkHoverWidget and specify the
/// time (in milliseconds) defining the hover period. Unlike most widgets,
/// this widget does not require a representation (although subclasses like
/// vtkBalloonWidget do require a representation).
///
/// @par Event Bindings:
/// By default, the widget observes the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
///   MouseMoveEvent - manages a timer used to determine whether the mouse
///                    is hovering.
///   TimerEvent - when the time between events (e.g., mouse move), then a
///                timer event is invoked.
///   KeyPressEvent - when the "Enter" key is pressed after the balloon appears,
///                   a callback is activated (e.g., WidgetActivateEvent).
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkHoverWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Move -- start (or reset) the timer
///   vtkWidgetEvent::TimedOut -- when enough time is elapsed between defined
///                               VTK events the hover event is invoked.
///   vtkWidgetEvent::SelectAction -- activate any callbacks associated
///                                   with the balloon.
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// This widget invokes the following VTK events on itself when the widget
/// determines that it is hovering. Note that observers of this widget can
/// listen for these events and take appropriate action.
/// &lt;pre&gt;
///   vtkCommand::TimerEvent (when hovering is determined to occur)
///   vtkCommand::EndInteractionEvent (after a hover has occurred and the
///                                    mouse begins moving again).
///   vtkCommand::WidgetActivateEvent (when the balloon is selected with a
///                                    keypress).
/// &lt;/pre&gt;
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractWidget
/// </seealso>
public class vtkHoverWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHoverWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHoverWidget()
	{
		MRClassNameKey = "class vtkHoverWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHoverWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHoverWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHoverWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkHoverWidget New()
	{
		vtkHoverWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHoverWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkHoverWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHoverWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHoverWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// A default representation, of which there is none, is created. Note
	/// that the superclasses vtkAbstractWidget::GetRepresentation()
	/// method returns nullptr.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkHoverWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHoverWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHoverWidget_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHoverWidget_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHoverWidget_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHoverWidget_GetTimerDuration_04(HandleRef pThis);

	/// <summary>
	/// Specify the hovering interval (in milliseconds). If after moving the
	/// mouse the pointer stays over a vtkProp for this duration, then a
	/// vtkTimerEvent::TimerEvent is invoked.
	/// </summary>
	public virtual int GetTimerDuration()
	{
		return vtkHoverWidget_GetTimerDuration_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHoverWidget_GetTimerDurationMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the hovering interval (in milliseconds). If after moving the
	/// mouse the pointer stays over a vtkProp for this duration, then a
	/// vtkTimerEvent::TimerEvent is invoked.
	/// </summary>
	public virtual int GetTimerDurationMaxValue()
	{
		return vtkHoverWidget_GetTimerDurationMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHoverWidget_GetTimerDurationMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the hovering interval (in milliseconds). If after moving the
	/// mouse the pointer stays over a vtkProp for this duration, then a
	/// vtkTimerEvent::TimerEvent is invoked.
	/// </summary>
	public virtual int GetTimerDurationMinValue()
	{
		return vtkHoverWidget_GetTimerDurationMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHoverWidget_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHoverWidget_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHoverWidget_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHoverWidget_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHoverWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkHoverWidget NewInstance()
	{
		vtkHoverWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHoverWidget_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHoverWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkHoverWidget SafeDownCast(vtkObjectBase o)
	{
		vtkHoverWidget vtkHoverWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHoverWidget_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHoverWidget2 = (vtkHoverWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHoverWidget2.Register(null);
			}
		}
		return vtkHoverWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHoverWidget_SetEnabled_12(HandleRef pThis, int arg0);

	/// <summary>
	/// The method for activating and deactivating this widget. This method
	/// must be overridden because it performs special timer-related operations.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkHoverWidget_SetEnabled_12(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHoverWidget_SetTimerDuration_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the hovering interval (in milliseconds). If after moving the
	/// mouse the pointer stays over a vtkProp for this duration, then a
	/// vtkTimerEvent::TimerEvent is invoked.
	/// </summary>
	public virtual void SetTimerDuration(int _arg)
	{
		vtkHoverWidget_SetTimerDuration_13(GetCppThis(), _arg);
	}
}
