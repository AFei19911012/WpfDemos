using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCommand
/// </summary>
/// <remarks>
///    superclass for callback/observer methods
///
/// vtkCommand is an implementation of the observer/command design
/// pattern.  In this design pattern, any instance of vtkObject can be
/// "observed" for any events it might invoke. For example,
/// vtkRenderer invokes a StartEvent as it begins to render and a
/// EndEvent when it finishes rendering. Filters (subclasses of
/// vtkProcessObject) invoke StartEvent, ProgressEvent, and EndEvent as
/// the filter processes data. Observers of events are added with the
/// AddObserver() method found in vtkObject.  AddObserver(), besides
/// requiring an event id or name, also takes an instance of vtkCommand
/// (or a subclasses). Note that vtkCommand is meant to be subclassed,
/// so that you can package the information necessary to support your
/// callback.
///
/// Event processing can be organized in priority lists, so it is
/// possible to truncate the processing of a particular event by
/// setting the AbortFlag variable. The priority is set using the
/// AddObserver() method.  By default the priority is 0, events of the
/// same priority are processed in last-in-first-processed order. The
/// ordering/aborting of events is important for things like 3D
/// widgets, which handle an event if the widget is selected (and then
/// aborting further processing of that event).  Otherwise. the event
/// is passed along for further processing.
///
/// When an instance of vtkObject invokes an event, it also passes an optional
/// void pointer to a callData. This callData is nullptr most of the time.
/// The callData is not specific to a type of event but specific to a type
/// of vtkObject invoking a specific event. For instance, vtkCommand::PickEvent
/// is invoked by vtkProp with a nullptr callData but is invoked by
/// vtkInteractorStyleImage with a pointer to the vtkInteractorStyleImage object
/// itself.
///
/// Here is the list of events that may be invoked with a non-nullptr callData.
/// - vtkCommand::ProgressEvent
///  - most of the objects return a pointer to a double value ranged between
/// 0.0 and 1.0
///  - Infovis/vtkFixedWidthTextReader returns a pointer to a float value equal
/// to the number of lines read so far.
/// - vtkCommand::ErrorEvent
///  - an error message as a const char * string
/// - vtkCommand::WarningEvent
///  - a warning message as a const char * string
/// - vtkCommand::StartAnimationCueEvent
///  - a pointer to a vtkAnimationCue::AnimationCueInfo object
/// - vtkCommand::EndAnimationCueEvent
///  - a pointer to a vtkAnimationCue::AnimationCueInfo object
/// - vtkCommand::AnimationCueTickEvent
///  - a pointer to a vtkAnimationCue::AnimationCueInfo object
/// - vtkCommand::PickEvent
///  - Common/vtkProp returns nullptr
///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
/// - vtkCommand::StartPickEvent
///  - Rendering/vtkPropPicker returns nullptr
///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
/// - vtkCommand::EndPickEvent
///  - Rendering/vtkPropPicker returns nullptr
///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
/// - vtkCommand::WrongTagEvent
///  - Parallel/vtkSocketCommunicator returns a received tag as a char *
/// - vtkCommand::SelectionChangedEvent
///  - Views/vtkView returns nullptr
///  - Views/vtkDataRepresentation returns a pointer to a vtkSelection
///  - Rendering/vtkInteractorStyleRubberBand2D returns an array of 5 unsigned
/// integers (p1x, p1y, p2x, p2y, mode), where mode is
/// vtkInteractorStyleRubberBand2D::SELECT_UNION or
/// vtkInteractorStyleRubberBand2D::SELECT_NORMAL
/// - vtkCommand::AnnotationChangedEvent
///  - GUISupport/Qt/vtkQtAnnotationView returns a pointer to a
/// vtkAnnotationLayers
/// - vtkCommand::PlacePointEvent
///  - Widgets/vtkSeedWidget returns a pointer to an int, being the current
/// handle number
/// - vtkCommand::DeletePointEvent
///  - Widgets/vtkSeedWidget returns a pointer to an int, being the
/// handle number of the deleted point
/// - vtkCommand::ResetWindowLevelEvent
///  - Widgets/vtkImagePlaneWidget returns an array of 2 double values (window
/// and level)
///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
/// - vtkCommand::StartWindowLevelEvent
///  - Widgets/vtkImagePlaneWidget returns an array of 2 double values (window
/// and level)
///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
/// - vtkCommand::EndWindowLevelEvent
///  - Widgets/vtkImagePlaneWidget returns an array of 2 double values (window
/// and level)
///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
/// - vtkCommand::WindowLevelEvent
///  - Widgets/vtkImagePlaneWidget returns an array of 2 double values (window
/// and level)
///  - Rendering/vtkInteractorStyleImage returns a pointer to itself
/// - vtkCommand::CharEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QKeyEvent *
/// - vtkCommand::TimerEvent
///  - most of the objects return a to an int representing a timer id
///  - Widgets/vtkHoverWidget returns nullptr
/// - vtkCommand::CreateTimerEvent
///  - Rendering/vtkGenericRenderWindowInteractor returns a to an int
/// representing a timer id
/// - vtkCommand::DestroyTimerEvent
///  - Rendering/vtkGenericRenderWindowInteractor returns a to an int
/// representing a timer id
/// - vtkCommand::UserEvent
///  - most of the objects return nullptr
///  - Infovis/vtkInteractorStyleTreeMapHover returns a pointer to a vtkIdType
/// representing a pedigree id
/// - vtkCommand::KeyPressEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QKeyEvent*
/// - vtkCommand::KeyReleaseEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QKeyEvent*
/// - vtkCommand::LeftButtonPressEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
/// - vtkCommand::LeftButtonReleaseEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
/// - vtkCommand::MouseMoveEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
/// - vtkCommand::MouseWheelForwardEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QWheelEvent*
/// - vtkCommand::MouseWheelBackwardEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QWheelEvent*
/// - vtkCommand::RightButtonPressEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
/// - vtkCommand::RightButtonReleaseEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
/// - vtkCommand::MiddleButtonPressEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
/// - vtkCommand::MiddleButtonReleaseEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QMouseEvent*
/// - vtkCommand::CursorChangedEvent
///  - most of the objects return a pointer to an int representing a shape
///  - Rendering/vtkInteractorObserver returns nullptr
/// - vtkCommand::ResetCameraEvent
///  - Rendering/vtkRenderer returns a pointer to itself
/// - vtkCommand::ResetCameraClippingRangeEvent
///  - Rendering/vtkRenderer returns a pointer to itself
/// - vtkCommand::ActiveCameraEvent
///  - Rendering/vtkRenderer returns a pointer to the active camera
/// - vtkCommand::CreateCameraEvent
///  - Rendering/vtkRenderer returns a pointer to the created camera
/// - vtkCommand::EnterEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QEvent*
/// - vtkCommand::LeaveEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QEvent*
/// - vtkCommand::RenderWindowMessageEvent
///  - Rendering/vtkWin32OpenGLRenderWindow return a pointer to a UINT message
/// - vtkCommand::ComputeVisiblePropBoundsEvent
///  - Rendering/vtkRenderer returns a pointer to itself
/// - QVTKOpenGLStereoWidget::ContextMenuEvent
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QContextMenuEvent*
/// - QVTKOpenGLStereoWidget::DragEnterEvent
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QDragEnterEvent*
/// - QVTKOpenGLStereoWidget::DragMoveEvent
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QDragMoveEvent*
/// - QVTKOpenGLStereoWidget::DragLeaveEvent
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QDragLeaveEvent*
/// - QVTKOpenGLStereoWidget::DropEvent
///  - GUISupport/Qt/QVTKOpenGLStereoWidget returns a QDropEvent*
/// - vtkCommand::ViewProgressEvent
///  - View/vtkView returns a ViewProgressEventCallData*
/// - vtkCommand::VolumeMapperRenderProgressEvent
///  - A pointer to a double value between 0.0 and 1.0
/// - vtkCommand::VolumeMapperComputeGradientsProgressEvent
///  - A pointer to a double value between 0.0 and 1.0
/// - vtkCommand::TDxMotionEvent (TDx=3DConnexion)
///  - A vtkTDxMotionEventInfo*
/// - vtkCommand::TDxButtonPressEvent
///  - A int* being the number of the button
/// - vtkCommand::TDxButtonReleaseEvent
///  - A int* being the number of the button
/// - vtkCommand::UpdateShaderEvent
///  - A vtkOpenGLHelper* currently being used
/// - vtkCommand::FourthButtonPressEvent
///  - most of the objects return nullptr
/// - vtkCommand::FourthButtonReleaseEvent
///  - most of the objects return nullptr
/// - vtkCommand::FifthButtonPressEvent
///  - most of the objects return nullptr
/// - vtkCommand::FifthButtonReleaseEvent
///  - most of the objects return nullptr
/// - vtkCommand::MouseWheelLeftEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLWidget returns a QWheelEvent*
/// - vtkCommand::MouseWheelRightEvent
///  - most of the objects return nullptr
///  - GUISupport/Qt/QVTKOpenGLWidget returns a QWheelEvent*
/// - vtkCommand::ErrorEvent
///  - vtkOutputWindow fires this with `char char*` for the error message
/// - vtkCommand::WarningEvent
///  - vtkOutputWindow fires this with `char char*` for the warning message
/// - vtkCommand::MessageEvent
///  - vtkOutputWindow fires this with `char char*` for the message text
/// - vtkCommand::TextEvent
///  - vtkOutputWindow fires this with `char char*` for the text
///
/// </remarks>
/// <seealso>
///
/// vtkObject vtkCallbackCommand vtkOldStyleCallbackCommand
/// vtkInteractorObserver vtk3DWidget
/// </seealso>
public abstract class vtkCommand : vtkObjectBase
{
	/// <summary>
	/// All the currently defined events are listed here.  Developers can
	/// use -- vtkCommand::UserEvent + int to specify their own event
	/// ids.
	/// Add new events by updating vtkAllEventsMacro.
	/// </summary>
	public enum EventIds
	{
		/// <summary>enum member</summary>
		AbortCheckEvent = 10,
		/// <summary>enum member</summary>
		ActiveCameraEvent = 29,
		/// <summary>enum member</summary>
		AnimationCueTickEvent = 59,
		/// <summary>enum member</summary>
		AnnotationChangedEvent = 78,
		/// <summary>enum member</summary>
		AnyEvent = 1,
		/// <summary>enum member</summary>
		Button3DEvent = 122,
		/// <summary>enum member</summary>
		CharEvent = 22,
		/// <summary>enum member</summary>
		Clip3DEvent = 132,
		/// <summary>enum member</summary>
		ComputeVisiblePropBoundsEvent = 84,
		/// <summary>enum member</summary>
		ConfigureEvent = 24,
		/// <summary>enum member</summary>
		ConnectionClosedEvent = 71,
		/// <summary>enum member</summary>
		ConnectionCreatedEvent = 70,
		/// <summary>enum member</summary>
		CreateCameraEvent = 30,
		/// <summary>enum member</summary>
		CreateTimerEvent = 48,
		/// <summary>enum member</summary>
		CurrentChangedEvent = 83,
		/// <summary>enum member</summary>
		CursorChangedEvent = 53,
		/// <summary>enum member</summary>
		DeleteEvent = 2,
		/// <summary>enum member</summary>
		DeletePointEvent = 51,
		/// <summary>enum member</summary>
		DestroyTimerEvent = 49,
		/// <summary>enum member</summary>
		DisableEvent = 47,
		/// <summary>enum member</summary>
		DomainModifiedEvent = 72,
		/// <summary>enum member</summary>
		DropFilesEvent = 42,
		/// <summary>enum member</summary>
		Elevation3DEvent = 136,
		/// <summary>enum member</summary>
		EnableEvent = 46,
		/// <summary>enum member</summary>
		EndAnimationCueEvent = 60,
		/// <summary>enum member</summary>
		EndEvent = 4,
		/// <summary>enum member</summary>
		EndInteractionEvent = 45,
		/// <summary>enum member</summary>
		EndPanEvent = 114,
		/// <summary>enum member</summary>
		EndPickEvent = 9,
		/// <summary>enum member</summary>
		EndPinchEvent = 108,
		/// <summary>enum member</summary>
		EndRotateEvent = 111,
		/// <summary>enum member</summary>
		EndSwipeEvent = 105,
		/// <summary>enum member</summary>
		EndWindowLevelEvent = 36,
		/// <summary>enum member</summary>
		EnterEvent = 18,
		/// <summary>enum member</summary>
		ErrorEvent = 39,
		/// <summary>enum member</summary>
		ExecuteInformationEvent = 54,
		/// <summary>enum member</summary>
		ExitEvent = 11,
		/// <summary>enum member</summary>
		ExposeEvent = 23,
		/// <summary>enum member</summary>
		FifthButtonPressEvent = 119,
		/// <summary>enum member</summary>
		FifthButtonReleaseEvent = 120,
		/// <summary>enum member</summary>
		FourthButtonPressEvent = 117,
		/// <summary>enum member</summary>
		FourthButtonReleaseEvent = 118,
		/// <summary>enum member</summary>
		HighlightEvent = 95,
		/// <summary>enum member</summary>
		HoverEvent = 88,
		/// <summary>enum member</summary>
		InteractionEvent = 44,
		/// <summary>enum member</summary>
		KeyPressEvent = 20,
		/// <summary>enum member</summary>
		KeyReleaseEvent = 21,
		/// <summary>enum member</summary>
		LeaveEvent = 19,
		/// <summary>enum member</summary>
		LeftButtonDoubleClickEvent = 124,
		/// <summary>enum member</summary>
		LeftButtonPressEvent = 12,
		/// <summary>enum member</summary>
		LeftButtonReleaseEvent = 13,
		/// <summary>enum member</summary>
		LoadStateEvent = 89,
		/// <summary>enum member</summary>
		LongTapEvent = 116,
		/// <summary>enum member</summary>
		Menu3DEvent = 130,
		/// <summary>enum member</summary>
		MessageEvent = 102,
		/// <summary>enum member</summary>
		MiddleButtonDoubleClickEvent = 125,
		/// <summary>enum member</summary>
		MiddleButtonPressEvent = 14,
		/// <summary>enum member</summary>
		MiddleButtonReleaseEvent = 15,
		/// <summary>enum member</summary>
		ModifiedEvent = 33,
		/// <summary>enum member</summary>
		MouseMoveEvent = 26,
		/// <summary>enum member</summary>
		MouseWheelBackwardEvent = 28,
		/// <summary>enum member</summary>
		MouseWheelForwardEvent = 27,
		/// <summary>enum member</summary>
		MouseWheelLeftEvent = 127,
		/// <summary>enum member</summary>
		MouseWheelRightEvent = 128,
		/// <summary>enum member</summary>
		Move3DEvent = 121,
		/// <summary>enum member</summary>
		NextPose3DEvent = 131,
		/// <summary>enum member</summary>
		NoEvent = 0,
		/// <summary>enum member</summary>
		PanEvent = 113,
		/// <summary>enum member</summary>
		Pick3DEvent = 134,
		/// <summary>enum member</summary>
		PickEvent = 7,
		/// <summary>enum member</summary>
		PinchEvent = 107,
		/// <summary>enum member</summary>
		PlacePointEvent = 50,
		/// <summary>enum member</summary>
		PlaceWidgetEvent = 52,
		/// <summary>enum member</summary>
		PositionProp3DEvent = 133,
		/// <summary>enum member</summary>
		ProgressEvent = 6,
		/// <summary>enum member</summary>
		PropertyModifiedEvent = 73,
		/// <summary>enum member</summary>
		RegisterEvent = 75,
		/// <summary>enum member</summary>
		RenderEvent = 5,
		/// <summary>enum member</summary>
		RenderWindowMessageEvent = 55,
		/// <summary>enum member</summary>
		ResetCameraClippingRangeEvent = 32,
		/// <summary>enum member</summary>
		ResetCameraEvent = 31,
		/// <summary>enum member</summary>
		ResetWindowLevelEvent = 37,
		/// <summary>enum member</summary>
		ResliceAxesChangedEvent = 58,
		/// <summary>enum member</summary>
		RightButtonDoubleClickEvent = 126,
		/// <summary>enum member</summary>
		RightButtonPressEvent = 16,
		/// <summary>enum member</summary>
		RightButtonReleaseEvent = 17,
		/// <summary>enum member</summary>
		RotateEvent = 110,
		/// <summary>enum member</summary>
		SaveStateEvent = 90,
		/// <summary>enum member</summary>
		Select3DEvent = 135,
		/// <summary>enum member</summary>
		SelectionChangedEvent = 79,
		/// <summary>enum member</summary>
		SetOutputEvent = 38,
		/// <summary>enum member</summary>
		StartAnimationCueEvent = 57,
		/// <summary>enum member</summary>
		StartEvent = 3,
		/// <summary>enum member</summary>
		StartInteractionEvent = 41,
		/// <summary>enum member</summary>
		StartPanEvent = 112,
		/// <summary>enum member</summary>
		StartPickEvent = 8,
		/// <summary>enum member</summary>
		StartPinchEvent = 106,
		/// <summary>enum member</summary>
		StartRotateEvent = 109,
		/// <summary>enum member</summary>
		StartSwipeEvent = 103,
		/// <summary>enum member</summary>
		StartWindowLevelEvent = 35,
		/// <summary>enum member</summary>
		StateChangedEvent = 91,
		/// <summary>enum member</summary>
		SwipeEvent = 104,
		/// <summary>enum member</summary>
		TDxButtonPressEvent = 86,
		/// <summary>enum member</summary>
		TDxButtonReleaseEvent = 87,
		/// <summary>enum member</summary>
		TDxMotionEvent = 85,
		/// <summary>enum member</summary>
		TapEvent = 115,
		/// <summary>enum member</summary>
		TextEvent = 123,
		/// <summary>enum member</summary>
		TimerEvent = 25,
		/// <summary>enum member</summary>
		UnRegisterEvent = 76,
		/// <summary>enum member</summary>
		UncheckedPropertyModifiedEvent = 100,
		/// <summary>enum member</summary>
		UpdateDataEvent = 82,
		/// <summary>enum member</summary>
		UpdateDropLocationEvent = 43,
		/// <summary>enum member</summary>
		UpdateEvent = 74,
		/// <summary>enum member</summary>
		UpdateInformationEvent = 77,
		/// <summary>enum member</summary>
		UpdatePropertyEvent = 80,
		/// <summary>enum member</summary>
		UpdateShaderEvent = 101,
		/// <summary>enum member</summary>
		UserEvent = 1000,
		/// <summary>enum member</summary>
		ViewProgressEvent = 81,
		/// <summary>enum member</summary>
		ViewerMovement3DEvent = 129,
		/// <summary>enum member</summary>
		VolumeMapperComputeGradientsEndEvent = 64,
		/// <summary>enum member</summary>
		VolumeMapperComputeGradientsProgressEvent = 65,
		/// <summary>enum member</summary>
		VolumeMapperComputeGradientsStartEvent = 66,
		/// <summary>enum member</summary>
		VolumeMapperRenderEndEvent = 61,
		/// <summary>enum member</summary>
		VolumeMapperRenderProgressEvent = 62,
		/// <summary>enum member</summary>
		VolumeMapperRenderStartEvent = 63,
		/// <summary>enum member</summary>
		WarningEvent = 40,
		/// <summary>enum member</summary>
		WidgetActivateEvent = 69,
		/// <summary>enum member</summary>
		WidgetModifiedEvent = 67,
		/// <summary>enum member</summary>
		WidgetValueChangedEvent = 68,
		/// <summary>enum member</summary>
		WindowFrameEvent = 94,
		/// <summary>enum member</summary>
		WindowIsCurrentEvent = 93,
		/// <summary>enum member</summary>
		WindowIsDirectEvent = 97,
		/// <summary>enum member</summary>
		WindowLevelEvent = 34,
		/// <summary>enum member</summary>
		WindowMakeCurrentEvent = 92,
		/// <summary>enum member</summary>
		WindowResizeEvent = 99,
		/// <summary>enum member</summary>
		WindowStereoTypeChangedEvent = 98,
		/// <summary>enum member</summary>
		WindowSupportsOpenGLEvent = 96,
		/// <summary>enum member</summary>
		WrongTagEvent = 56
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCommand";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCommand()
	{
		MRClassNameKey = "class vtkCommand";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommand"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCommand(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommand_UnRegister_19(HandleRef pThis);

	/// <summary>
	/// Decrease the reference count (release by another object). This has
	/// the same effect as invoking Delete() (i.e., it reduces the reference
	/// count by 1).
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (GetCallDisposalMethod())
			{
				vtkCommand_UnRegister_19(GetCppThis());
				ClearCppThis();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommand_AbortFlagOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the abort flag. If this is set to true no further
	/// commands are executed.
	/// </summary>
	public void AbortFlagOff()
	{
		vtkCommand_AbortFlagOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommand_AbortFlagOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the abort flag. If this is set to true no further
	/// commands are executed.
	/// </summary>
	public void AbortFlagOn()
	{
		vtkCommand_AbortFlagOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCommand_EventHasData_03(uint arg0);

	/// <summary>
	/// Does this event type contain vtkEventData
	/// </summary>
	public static bool EventHasData(uint arg0)
	{
		return (vtkCommand_EventHasData_03(arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommand_Execute_04(HandleRef pThis, HandleRef caller, uint eventId, IntPtr callData);

	/// <summary>
	/// All derived classes of vtkCommand must implement this
	/// method. This is the method that actually does the work of the
	/// callback. The caller argument is the object invoking the event,
	/// the eventId parameter is the id of the event, and callData
	/// parameter is data that can be passed into the execute
	/// method. (Note: vtkObject::InvokeEvent() takes two parameters: the
	/// event id (or name) and call data. Typically call data is nullptr,
	/// but the user can package data and pass it this
	/// way. Alternatively, a derived class of vtkCommand can be used to
	/// pass data.)
	/// </summary>
	public virtual void Execute(vtkObject caller, uint eventId, IntPtr callData)
	{
		vtkCommand_Execute_04(GetCppThis(), caller?.GetCppThis() ?? default(HandleRef), eventId, callData);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommand_GetAbortFlag_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the abort flag. If this is set to true no further
	/// commands are executed.
	/// </summary>
	public int GetAbortFlag()
	{
		return vtkCommand_GetAbortFlag_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkCommand_GetEventIdFromString_06(string arg0);

	/// <summary>
	/// Convenience methods for translating between event names and event
	/// ids.
	/// </summary>
	public static uint GetEventIdFromString(string arg0)
	{
		return vtkCommand_GetEventIdFromString_06(arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCommand_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCommand_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCommand_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCommand_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommand_GetPassiveObserver_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the passive observer flag. If this is set to true, this
	/// indicates that this command does not change the state of the
	/// system in any way. Passive observers are processed first, and
	/// are not called even when another command has focus.
	/// </summary>
	public int GetPassiveObserver()
	{
		return vtkCommand_GetPassiveObserver_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommand_GetStringFromEventId_10(uint arg0);

	/// <summary>
	/// Convenience methods for translating between event names and event
	/// ids.
	/// </summary>
	public static string GetStringFromEventId(uint arg0)
	{
		return Marshal.PtrToStringAnsi(vtkCommand_GetStringFromEventId_10(arg0));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommand_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCommand_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommand_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCommand_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommand_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCommand NewInstance()
	{
		vtkCommand result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCommand_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommand_PassiveObserverOff_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the passive observer flag. If this is set to true, this
	/// indicates that this command does not change the state of the
	/// system in any way. Passive observers are processed first, and
	/// are not called even when another command has focus.
	/// </summary>
	public void PassiveObserverOff()
	{
		vtkCommand_PassiveObserverOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommand_PassiveObserverOn_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the passive observer flag. If this is set to true, this
	/// indicates that this command does not change the state of the
	/// system in any way. Passive observers are processed first, and
	/// are not called even when another command has focus.
	/// </summary>
	public void PassiveObserverOn()
	{
		vtkCommand_PassiveObserverOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommand_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkCommand SafeDownCast(vtkObjectBase o)
	{
		vtkCommand vtkCommand2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCommand_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCommand2 = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCommand2.Register(null);
			}
		}
		return vtkCommand2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommand_SetAbortFlag_17(HandleRef pThis, int f);

	/// <summary>
	/// Set/Get the abort flag. If this is set to true no further
	/// commands are executed.
	/// </summary>
	public void SetAbortFlag(int f)
	{
		vtkCommand_SetAbortFlag_17(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommand_SetPassiveObserver_18(HandleRef pThis, int f);

	/// <summary>
	/// Set/Get the passive observer flag. If this is set to true, this
	/// indicates that this command does not change the state of the
	/// system in any way. Passive observers are processed first, and
	/// are not called even when another command has focus.
	/// </summary>
	public void SetPassiveObserver(int f)
	{
		vtkCommand_SetPassiveObserver_18(GetCppThis(), f);
	}
}
