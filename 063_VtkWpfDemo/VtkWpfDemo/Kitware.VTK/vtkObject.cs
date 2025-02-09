using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkObject
/// </summary>
/// <remarks>
///    abstract base class for most VTK objects
///
/// vtkObject is the base class for most objects in the visualization
/// toolkit. vtkObject provides methods for tracking modification time,
/// debugging, printing, and event callbacks. Most objects created
/// within the VTK framework should be a subclass of vtkObject or one
/// of its children.  The few exceptions tend to be very small helper
/// classes that usually never get instantiated or situations where
/// multiple inheritance gets in the way.  vtkObject also performs
/// reference counting: objects that are reference counted exist as
/// long as another object uses them. Once the last reference to a
/// reference counted object is removed, the object will spontaneously
/// destruct.
///
/// @warning
/// Note: in VTK objects should always be created with the New() method
/// and deleted with the Delete() method. VTK objects cannot be
/// allocated off the stack (i.e., automatic objects) because the
/// constructor is a protected method.
///
/// </remarks>
/// <seealso>
///
/// vtkCommand vtkTimeStamp
/// </seealso>
public class vtkObject : vtkObjectBase
{
	/// <summary>
	/// Generic signature for all vtkObject events.
	/// </summary>
	public delegate void vtkObjectEventHandler(vtkObject sender, vtkObjectEventArgs e);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkObject";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	private vtkObjectEventRelay AbortCheckEvtRelay;

	private vtkObjectEventRelay ActiveCameraEvtRelay;

	private vtkObjectEventRelay AnimationCueTickEvtRelay;

	private vtkObjectEventRelay AnnotationChangedEvtRelay;

	private vtkObjectEventRelay AnyEvtRelay;

	private vtkObjectEventRelay Button3DEvtRelay;

	private vtkObjectEventRelay CharEvtRelay;

	private vtkObjectEventRelay Clip3DEvtRelay;

	private vtkObjectEventRelay ComputeVisiblePropBoundsEvtRelay;

	private vtkObjectEventRelay ConfigureEvtRelay;

	private vtkObjectEventRelay ConnectionClosedEvtRelay;

	private vtkObjectEventRelay ConnectionCreatedEvtRelay;

	private vtkObjectEventRelay CreateCameraEvtRelay;

	private vtkObjectEventRelay CreateTimerEvtRelay;

	private vtkObjectEventRelay CurrentChangedEvtRelay;

	private vtkObjectEventRelay CursorChangedEvtRelay;

	private vtkObjectEventRelay DeleteEvtRelay;

	private vtkObjectEventRelay DeletePointEvtRelay;

	private vtkObjectEventRelay DestroyTimerEvtRelay;

	private vtkObjectEventRelay DisableEvtRelay;

	private vtkObjectEventRelay DomainModifiedEvtRelay;

	private vtkObjectEventRelay DropFilesEvtRelay;

	private vtkObjectEventRelay EnableEvtRelay;

	private vtkObjectEventRelay EndEvtRelay;

	private vtkObjectEventRelay EndAnimationCueEvtRelay;

	private vtkObjectEventRelay EndInteractionEvtRelay;

	private vtkObjectEventRelay EndPanEvtRelay;

	private vtkObjectEventRelay EndPickEvtRelay;

	private vtkObjectEventRelay EndPinchEvtRelay;

	private vtkObjectEventRelay EndRotateEvtRelay;

	private vtkObjectEventRelay EndSwipeEvtRelay;

	private vtkObjectEventRelay EndWindowLevelEvtRelay;

	private vtkObjectEventRelay EnterEvtRelay;

	private vtkObjectEventRelay ErrorEvtRelay;

	private vtkObjectEventRelay ExecuteInformationEvtRelay;

	private vtkObjectEventRelay ExitEvtRelay;

	private vtkObjectEventRelay ExposeEvtRelay;

	private vtkObjectEventRelay FifthButtonPressEvtRelay;

	private vtkObjectEventRelay FifthButtonReleaseEvtRelay;

	private vtkObjectEventRelay FourthButtonPressEvtRelay;

	private vtkObjectEventRelay FourthButtonReleaseEvtRelay;

	private vtkObjectEventRelay HighlightEvtRelay;

	private vtkObjectEventRelay HoverEvtRelay;

	private vtkObjectEventRelay InteractionEvtRelay;

	private vtkObjectEventRelay KeyPressEvtRelay;

	private vtkObjectEventRelay KeyReleaseEvtRelay;

	private vtkObjectEventRelay LeaveEvtRelay;

	private vtkObjectEventRelay LeftButtonDoubleClickEvtRelay;

	private vtkObjectEventRelay LeftButtonPressEvtRelay;

	private vtkObjectEventRelay LeftButtonReleaseEvtRelay;

	private vtkObjectEventRelay LoadStateEvtRelay;

	private vtkObjectEventRelay LongTapEvtRelay;

	private vtkObjectEventRelay Menu3DEvtRelay;

	private vtkObjectEventRelay MessageEvtRelay;

	private vtkObjectEventRelay MiddleButtonDoubleClickEvtRelay;

	private vtkObjectEventRelay MiddleButtonPressEvtRelay;

	private vtkObjectEventRelay MiddleButtonReleaseEvtRelay;

	private vtkObjectEventRelay ModifiedEvtRelay;

	private vtkObjectEventRelay MouseMoveEvtRelay;

	private vtkObjectEventRelay MouseWheelBackwardEvtRelay;

	private vtkObjectEventRelay MouseWheelForwardEvtRelay;

	private vtkObjectEventRelay MouseWheelLeftEvtRelay;

	private vtkObjectEventRelay MouseWheelRightEvtRelay;

	private vtkObjectEventRelay Move3DEvtRelay;

	private vtkObjectEventRelay NextPose3DEvtRelay;

	private vtkObjectEventRelay NoEvtRelay;

	private vtkObjectEventRelay PanEvtRelay;

	private vtkObjectEventRelay PickEvtRelay;

	private vtkObjectEventRelay Pick3DEvtRelay;

	private vtkObjectEventRelay PinchEvtRelay;

	private vtkObjectEventRelay PlacePointEvtRelay;

	private vtkObjectEventRelay PlaceWidgetEvtRelay;

	private vtkObjectEventRelay PositionProp3DEvtRelay;

	private vtkObjectEventRelay ProgressEvtRelay;

	private vtkObjectEventRelay PropertyModifiedEvtRelay;

	private vtkObjectEventRelay RegisterEvtRelay;

	private vtkObjectEventRelay RenderEvtRelay;

	private vtkObjectEventRelay RenderWindowMessageEvtRelay;

	private vtkObjectEventRelay ResetCameraEvtRelay;

	private vtkObjectEventRelay ResetCameraClippingRangeEvtRelay;

	private vtkObjectEventRelay ResetWindowLevelEvtRelay;

	private vtkObjectEventRelay ResliceAxesChangedEvtRelay;

	private vtkObjectEventRelay RightButtonDoubleClickEvtRelay;

	private vtkObjectEventRelay RightButtonPressEvtRelay;

	private vtkObjectEventRelay RightButtonReleaseEvtRelay;

	private vtkObjectEventRelay RotateEvtRelay;

	private vtkObjectEventRelay SaveStateEvtRelay;

	private vtkObjectEventRelay Select3DEvtRelay;

	private vtkObjectEventRelay SelectionChangedEvtRelay;

	private vtkObjectEventRelay SetOutputEvtRelay;

	private vtkObjectEventRelay StartEvtRelay;

	private vtkObjectEventRelay StartAnimationCueEvtRelay;

	private vtkObjectEventRelay StartInteractionEvtRelay;

	private vtkObjectEventRelay StartPanEvtRelay;

	private vtkObjectEventRelay StartPickEvtRelay;

	private vtkObjectEventRelay StartPinchEvtRelay;

	private vtkObjectEventRelay StartRotateEvtRelay;

	private vtkObjectEventRelay StartSwipeEvtRelay;

	private vtkObjectEventRelay StartWindowLevelEvtRelay;

	private vtkObjectEventRelay StateChangedEvtRelay;

	private vtkObjectEventRelay SwipeEvtRelay;

	private vtkObjectEventRelay TapEvtRelay;

	private vtkObjectEventRelay TDxButtonPressEvtRelay;

	private vtkObjectEventRelay TDxButtonReleaseEvtRelay;

	private vtkObjectEventRelay TDxMotionEvtRelay;

	private vtkObjectEventRelay TextEvtRelay;

	private vtkObjectEventRelay TimerEvtRelay;

	private vtkObjectEventRelay UncheckedPropertyModifiedEvtRelay;

	private vtkObjectEventRelay UnRegisterEvtRelay;

	private vtkObjectEventRelay UpdateEvtRelay;

	private vtkObjectEventRelay UpdateDataEvtRelay;

	private vtkObjectEventRelay UpdateDropLocationEvtRelay;

	private vtkObjectEventRelay UpdateInformationEvtRelay;

	private vtkObjectEventRelay UpdatePropertyEvtRelay;

	private vtkObjectEventRelay UpdateShaderEvtRelay;

	private vtkObjectEventRelay UserEvtRelay;

	private vtkObjectEventRelay ViewerMovement3DEvtRelay;

	private vtkObjectEventRelay ViewProgressEvtRelay;

	private vtkObjectEventRelay VolumeMapperComputeGradientsEndEvtRelay;

	private vtkObjectEventRelay VolumeMapperComputeGradientsProgressEvtRelay;

	private vtkObjectEventRelay VolumeMapperComputeGradientsStartEvtRelay;

	private vtkObjectEventRelay VolumeMapperRenderEndEvtRelay;

	private vtkObjectEventRelay VolumeMapperRenderProgressEvtRelay;

	private vtkObjectEventRelay VolumeMapperRenderStartEvtRelay;

	private vtkObjectEventRelay WarningEvtRelay;

	private vtkObjectEventRelay WidgetActivateEvtRelay;

	private vtkObjectEventRelay WidgetModifiedEvtRelay;

	private vtkObjectEventRelay WidgetValueChangedEvtRelay;

	private vtkObjectEventRelay WindowFrameEvtRelay;

	private vtkObjectEventRelay WindowIsCurrentEvtRelay;

	private vtkObjectEventRelay WindowIsDirectEvtRelay;

	private vtkObjectEventRelay WindowLevelEvtRelay;

	private vtkObjectEventRelay WindowMakeCurrentEvtRelay;

	private vtkObjectEventRelay WindowResizeEvtRelay;

	private vtkObjectEventRelay WindowStereoTypeChangedEvtRelay;

	private vtkObjectEventRelay WindowSupportsOpenGLEvtRelay;

	private vtkObjectEventRelay WrongTagEvtRelay;

	/// <summary>
	/// The AbortCheckEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.AbortCheckEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler AbortCheckEvt
	{
		add
		{
			if (null == AbortCheckEvtRelay)
			{
				AbortCheckEvtRelay = new vtkObjectEventRelay(this, 10u);
			}
			if (null != AbortCheckEvtRelay)
			{
				AbortCheckEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != AbortCheckEvtRelay)
			{
				AbortCheckEvtRelay.RemoveHandler(value);
				if (!AbortCheckEvtRelay.HasHandlers())
				{
					AbortCheckEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ActiveCameraEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ActiveCameraEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ActiveCameraEvt
	{
		add
		{
			if (null == ActiveCameraEvtRelay)
			{
				ActiveCameraEvtRelay = new vtkObjectEventRelay(this, 29u);
			}
			if (null != ActiveCameraEvtRelay)
			{
				ActiveCameraEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ActiveCameraEvtRelay)
			{
				ActiveCameraEvtRelay.RemoveHandler(value);
				if (!ActiveCameraEvtRelay.HasHandlers())
				{
					ActiveCameraEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The AnimationCueTickEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.AnimationCueTickEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler AnimationCueTickEvt
	{
		add
		{
			if (null == AnimationCueTickEvtRelay)
			{
				AnimationCueTickEvtRelay = new vtkObjectEventRelay(this, 59u);
			}
			if (null != AnimationCueTickEvtRelay)
			{
				AnimationCueTickEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != AnimationCueTickEvtRelay)
			{
				AnimationCueTickEvtRelay.RemoveHandler(value);
				if (!AnimationCueTickEvtRelay.HasHandlers())
				{
					AnimationCueTickEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The AnnotationChangedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.AnnotationChangedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler AnnotationChangedEvt
	{
		add
		{
			if (null == AnnotationChangedEvtRelay)
			{
				AnnotationChangedEvtRelay = new vtkObjectEventRelay(this, 78u);
			}
			if (null != AnnotationChangedEvtRelay)
			{
				AnnotationChangedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != AnnotationChangedEvtRelay)
			{
				AnnotationChangedEvtRelay.RemoveHandler(value);
				if (!AnnotationChangedEvtRelay.HasHandlers())
				{
					AnnotationChangedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The AnyEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.AnyEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler AnyEvt
	{
		add
		{
			if (null == AnyEvtRelay)
			{
				AnyEvtRelay = new vtkObjectEventRelay(this, 1u);
			}
			if (null != AnyEvtRelay)
			{
				AnyEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != AnyEvtRelay)
			{
				AnyEvtRelay.RemoveHandler(value);
				if (!AnyEvtRelay.HasHandlers())
				{
					AnyEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The Button3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.Button3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler Button3DEvt
	{
		add
		{
			if (null == Button3DEvtRelay)
			{
				Button3DEvtRelay = new vtkObjectEventRelay(this, 122u);
			}
			if (null != Button3DEvtRelay)
			{
				Button3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != Button3DEvtRelay)
			{
				Button3DEvtRelay.RemoveHandler(value);
				if (!Button3DEvtRelay.HasHandlers())
				{
					Button3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The CharEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.CharEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler CharEvt
	{
		add
		{
			if (null == CharEvtRelay)
			{
				CharEvtRelay = new vtkObjectEventRelay(this, 22u);
			}
			if (null != CharEvtRelay)
			{
				CharEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != CharEvtRelay)
			{
				CharEvtRelay.RemoveHandler(value);
				if (!CharEvtRelay.HasHandlers())
				{
					CharEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The Clip3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.Clip3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler Clip3DEvt
	{
		add
		{
			if (null == Clip3DEvtRelay)
			{
				Clip3DEvtRelay = new vtkObjectEventRelay(this, 132u);
			}
			if (null != Clip3DEvtRelay)
			{
				Clip3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != Clip3DEvtRelay)
			{
				Clip3DEvtRelay.RemoveHandler(value);
				if (!Clip3DEvtRelay.HasHandlers())
				{
					Clip3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ComputeVisiblePropBoundsEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ComputeVisiblePropBoundsEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ComputeVisiblePropBoundsEvt
	{
		add
		{
			if (null == ComputeVisiblePropBoundsEvtRelay)
			{
				ComputeVisiblePropBoundsEvtRelay = new vtkObjectEventRelay(this, 84u);
			}
			if (null != ComputeVisiblePropBoundsEvtRelay)
			{
				ComputeVisiblePropBoundsEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ComputeVisiblePropBoundsEvtRelay)
			{
				ComputeVisiblePropBoundsEvtRelay.RemoveHandler(value);
				if (!ComputeVisiblePropBoundsEvtRelay.HasHandlers())
				{
					ComputeVisiblePropBoundsEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ConfigureEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ConfigureEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ConfigureEvt
	{
		add
		{
			if (null == ConfigureEvtRelay)
			{
				ConfigureEvtRelay = new vtkObjectEventRelay(this, 24u);
			}
			if (null != ConfigureEvtRelay)
			{
				ConfigureEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ConfigureEvtRelay)
			{
				ConfigureEvtRelay.RemoveHandler(value);
				if (!ConfigureEvtRelay.HasHandlers())
				{
					ConfigureEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ConnectionClosedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ConnectionClosedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ConnectionClosedEvt
	{
		add
		{
			if (null == ConnectionClosedEvtRelay)
			{
				ConnectionClosedEvtRelay = new vtkObjectEventRelay(this, 71u);
			}
			if (null != ConnectionClosedEvtRelay)
			{
				ConnectionClosedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ConnectionClosedEvtRelay)
			{
				ConnectionClosedEvtRelay.RemoveHandler(value);
				if (!ConnectionClosedEvtRelay.HasHandlers())
				{
					ConnectionClosedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ConnectionCreatedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ConnectionCreatedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ConnectionCreatedEvt
	{
		add
		{
			if (null == ConnectionCreatedEvtRelay)
			{
				ConnectionCreatedEvtRelay = new vtkObjectEventRelay(this, 70u);
			}
			if (null != ConnectionCreatedEvtRelay)
			{
				ConnectionCreatedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ConnectionCreatedEvtRelay)
			{
				ConnectionCreatedEvtRelay.RemoveHandler(value);
				if (!ConnectionCreatedEvtRelay.HasHandlers())
				{
					ConnectionCreatedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The CreateCameraEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.CreateCameraEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler CreateCameraEvt
	{
		add
		{
			if (null == CreateCameraEvtRelay)
			{
				CreateCameraEvtRelay = new vtkObjectEventRelay(this, 30u);
			}
			if (null != CreateCameraEvtRelay)
			{
				CreateCameraEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != CreateCameraEvtRelay)
			{
				CreateCameraEvtRelay.RemoveHandler(value);
				if (!CreateCameraEvtRelay.HasHandlers())
				{
					CreateCameraEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The CreateTimerEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.CreateTimerEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler CreateTimerEvt
	{
		add
		{
			if (null == CreateTimerEvtRelay)
			{
				CreateTimerEvtRelay = new vtkObjectEventRelay(this, 48u);
			}
			if (null != CreateTimerEvtRelay)
			{
				CreateTimerEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != CreateTimerEvtRelay)
			{
				CreateTimerEvtRelay.RemoveHandler(value);
				if (!CreateTimerEvtRelay.HasHandlers())
				{
					CreateTimerEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The CurrentChangedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.CurrentChangedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler CurrentChangedEvt
	{
		add
		{
			if (null == CurrentChangedEvtRelay)
			{
				CurrentChangedEvtRelay = new vtkObjectEventRelay(this, 83u);
			}
			if (null != CurrentChangedEvtRelay)
			{
				CurrentChangedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != CurrentChangedEvtRelay)
			{
				CurrentChangedEvtRelay.RemoveHandler(value);
				if (!CurrentChangedEvtRelay.HasHandlers())
				{
					CurrentChangedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The CursorChangedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.CursorChangedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler CursorChangedEvt
	{
		add
		{
			if (null == CursorChangedEvtRelay)
			{
				CursorChangedEvtRelay = new vtkObjectEventRelay(this, 53u);
			}
			if (null != CursorChangedEvtRelay)
			{
				CursorChangedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != CursorChangedEvtRelay)
			{
				CursorChangedEvtRelay.RemoveHandler(value);
				if (!CursorChangedEvtRelay.HasHandlers())
				{
					CursorChangedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The DeleteEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.DeleteEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler DeleteEvt
	{
		add
		{
			if (null == DeleteEvtRelay)
			{
				DeleteEvtRelay = new vtkObjectEventRelay(this, 2u);
			}
			if (null != DeleteEvtRelay)
			{
				DeleteEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != DeleteEvtRelay)
			{
				DeleteEvtRelay.RemoveHandler(value);
				if (!DeleteEvtRelay.HasHandlers())
				{
					DeleteEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The DeletePointEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.DeletePointEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler DeletePointEvt
	{
		add
		{
			if (null == DeletePointEvtRelay)
			{
				DeletePointEvtRelay = new vtkObjectEventRelay(this, 51u);
			}
			if (null != DeletePointEvtRelay)
			{
				DeletePointEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != DeletePointEvtRelay)
			{
				DeletePointEvtRelay.RemoveHandler(value);
				if (!DeletePointEvtRelay.HasHandlers())
				{
					DeletePointEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The DestroyTimerEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.DestroyTimerEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler DestroyTimerEvt
	{
		add
		{
			if (null == DestroyTimerEvtRelay)
			{
				DestroyTimerEvtRelay = new vtkObjectEventRelay(this, 49u);
			}
			if (null != DestroyTimerEvtRelay)
			{
				DestroyTimerEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != DestroyTimerEvtRelay)
			{
				DestroyTimerEvtRelay.RemoveHandler(value);
				if (!DestroyTimerEvtRelay.HasHandlers())
				{
					DestroyTimerEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The DisableEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.DisableEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler DisableEvt
	{
		add
		{
			if (null == DisableEvtRelay)
			{
				DisableEvtRelay = new vtkObjectEventRelay(this, 47u);
			}
			if (null != DisableEvtRelay)
			{
				DisableEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != DisableEvtRelay)
			{
				DisableEvtRelay.RemoveHandler(value);
				if (!DisableEvtRelay.HasHandlers())
				{
					DisableEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The DomainModifiedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.DomainModifiedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler DomainModifiedEvt
	{
		add
		{
			if (null == DomainModifiedEvtRelay)
			{
				DomainModifiedEvtRelay = new vtkObjectEventRelay(this, 72u);
			}
			if (null != DomainModifiedEvtRelay)
			{
				DomainModifiedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != DomainModifiedEvtRelay)
			{
				DomainModifiedEvtRelay.RemoveHandler(value);
				if (!DomainModifiedEvtRelay.HasHandlers())
				{
					DomainModifiedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The DropFilesEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.DropFilesEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler DropFilesEvt
	{
		add
		{
			if (null == DropFilesEvtRelay)
			{
				DropFilesEvtRelay = new vtkObjectEventRelay(this, 42u);
			}
			if (null != DropFilesEvtRelay)
			{
				DropFilesEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != DropFilesEvtRelay)
			{
				DropFilesEvtRelay.RemoveHandler(value);
				if (!DropFilesEvtRelay.HasHandlers())
				{
					DropFilesEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EnableEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EnableEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EnableEvt
	{
		add
		{
			if (null == EnableEvtRelay)
			{
				EnableEvtRelay = new vtkObjectEventRelay(this, 46u);
			}
			if (null != EnableEvtRelay)
			{
				EnableEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EnableEvtRelay)
			{
				EnableEvtRelay.RemoveHandler(value);
				if (!EnableEvtRelay.HasHandlers())
				{
					EnableEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndEvt
	{
		add
		{
			if (null == EndEvtRelay)
			{
				EndEvtRelay = new vtkObjectEventRelay(this, 4u);
			}
			if (null != EndEvtRelay)
			{
				EndEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndEvtRelay)
			{
				EndEvtRelay.RemoveHandler(value);
				if (!EndEvtRelay.HasHandlers())
				{
					EndEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndAnimationCueEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndAnimationCueEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndAnimationCueEvt
	{
		add
		{
			if (null == EndAnimationCueEvtRelay)
			{
				EndAnimationCueEvtRelay = new vtkObjectEventRelay(this, 60u);
			}
			if (null != EndAnimationCueEvtRelay)
			{
				EndAnimationCueEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndAnimationCueEvtRelay)
			{
				EndAnimationCueEvtRelay.RemoveHandler(value);
				if (!EndAnimationCueEvtRelay.HasHandlers())
				{
					EndAnimationCueEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndInteractionEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndInteractionEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndInteractionEvt
	{
		add
		{
			if (null == EndInteractionEvtRelay)
			{
				EndInteractionEvtRelay = new vtkObjectEventRelay(this, 45u);
			}
			if (null != EndInteractionEvtRelay)
			{
				EndInteractionEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndInteractionEvtRelay)
			{
				EndInteractionEvtRelay.RemoveHandler(value);
				if (!EndInteractionEvtRelay.HasHandlers())
				{
					EndInteractionEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndPanEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndPanEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndPanEvt
	{
		add
		{
			if (null == EndPanEvtRelay)
			{
				EndPanEvtRelay = new vtkObjectEventRelay(this, 114u);
			}
			if (null != EndPanEvtRelay)
			{
				EndPanEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndPanEvtRelay)
			{
				EndPanEvtRelay.RemoveHandler(value);
				if (!EndPanEvtRelay.HasHandlers())
				{
					EndPanEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndPickEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndPickEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndPickEvt
	{
		add
		{
			if (null == EndPickEvtRelay)
			{
				EndPickEvtRelay = new vtkObjectEventRelay(this, 9u);
			}
			if (null != EndPickEvtRelay)
			{
				EndPickEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndPickEvtRelay)
			{
				EndPickEvtRelay.RemoveHandler(value);
				if (!EndPickEvtRelay.HasHandlers())
				{
					EndPickEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndPinchEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndPinchEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndPinchEvt
	{
		add
		{
			if (null == EndPinchEvtRelay)
			{
				EndPinchEvtRelay = new vtkObjectEventRelay(this, 108u);
			}
			if (null != EndPinchEvtRelay)
			{
				EndPinchEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndPinchEvtRelay)
			{
				EndPinchEvtRelay.RemoveHandler(value);
				if (!EndPinchEvtRelay.HasHandlers())
				{
					EndPinchEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndRotateEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndRotateEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndRotateEvt
	{
		add
		{
			if (null == EndRotateEvtRelay)
			{
				EndRotateEvtRelay = new vtkObjectEventRelay(this, 111u);
			}
			if (null != EndRotateEvtRelay)
			{
				EndRotateEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndRotateEvtRelay)
			{
				EndRotateEvtRelay.RemoveHandler(value);
				if (!EndRotateEvtRelay.HasHandlers())
				{
					EndRotateEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndSwipeEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndSwipeEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndSwipeEvt
	{
		add
		{
			if (null == EndSwipeEvtRelay)
			{
				EndSwipeEvtRelay = new vtkObjectEventRelay(this, 105u);
			}
			if (null != EndSwipeEvtRelay)
			{
				EndSwipeEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndSwipeEvtRelay)
			{
				EndSwipeEvtRelay.RemoveHandler(value);
				if (!EndSwipeEvtRelay.HasHandlers())
				{
					EndSwipeEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EndWindowLevelEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EndWindowLevelEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EndWindowLevelEvt
	{
		add
		{
			if (null == EndWindowLevelEvtRelay)
			{
				EndWindowLevelEvtRelay = new vtkObjectEventRelay(this, 36u);
			}
			if (null != EndWindowLevelEvtRelay)
			{
				EndWindowLevelEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EndWindowLevelEvtRelay)
			{
				EndWindowLevelEvtRelay.RemoveHandler(value);
				if (!EndWindowLevelEvtRelay.HasHandlers())
				{
					EndWindowLevelEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The EnterEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.EnterEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler EnterEvt
	{
		add
		{
			if (null == EnterEvtRelay)
			{
				EnterEvtRelay = new vtkObjectEventRelay(this, 18u);
			}
			if (null != EnterEvtRelay)
			{
				EnterEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != EnterEvtRelay)
			{
				EnterEvtRelay.RemoveHandler(value);
				if (!EnterEvtRelay.HasHandlers())
				{
					EnterEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ErrorEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ErrorEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ErrorEvt
	{
		add
		{
			if (null == ErrorEvtRelay)
			{
				ErrorEvtRelay = new vtkObjectEventRelay(this, 39u);
			}
			if (null != ErrorEvtRelay)
			{
				ErrorEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ErrorEvtRelay)
			{
				ErrorEvtRelay.RemoveHandler(value);
				if (!ErrorEvtRelay.HasHandlers())
				{
					ErrorEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ExecuteInformationEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ExecuteInformationEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ExecuteInformationEvt
	{
		add
		{
			if (null == ExecuteInformationEvtRelay)
			{
				ExecuteInformationEvtRelay = new vtkObjectEventRelay(this, 54u);
			}
			if (null != ExecuteInformationEvtRelay)
			{
				ExecuteInformationEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ExecuteInformationEvtRelay)
			{
				ExecuteInformationEvtRelay.RemoveHandler(value);
				if (!ExecuteInformationEvtRelay.HasHandlers())
				{
					ExecuteInformationEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ExitEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ExitEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ExitEvt
	{
		add
		{
			if (null == ExitEvtRelay)
			{
				ExitEvtRelay = new vtkObjectEventRelay(this, 11u);
			}
			if (null != ExitEvtRelay)
			{
				ExitEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ExitEvtRelay)
			{
				ExitEvtRelay.RemoveHandler(value);
				if (!ExitEvtRelay.HasHandlers())
				{
					ExitEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ExposeEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ExposeEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ExposeEvt
	{
		add
		{
			if (null == ExposeEvtRelay)
			{
				ExposeEvtRelay = new vtkObjectEventRelay(this, 23u);
			}
			if (null != ExposeEvtRelay)
			{
				ExposeEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ExposeEvtRelay)
			{
				ExposeEvtRelay.RemoveHandler(value);
				if (!ExposeEvtRelay.HasHandlers())
				{
					ExposeEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The FifthButtonPressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.FifthButtonPressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler FifthButtonPressEvt
	{
		add
		{
			if (null == FifthButtonPressEvtRelay)
			{
				FifthButtonPressEvtRelay = new vtkObjectEventRelay(this, 119u);
			}
			if (null != FifthButtonPressEvtRelay)
			{
				FifthButtonPressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != FifthButtonPressEvtRelay)
			{
				FifthButtonPressEvtRelay.RemoveHandler(value);
				if (!FifthButtonPressEvtRelay.HasHandlers())
				{
					FifthButtonPressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The FifthButtonReleaseEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.FifthButtonReleaseEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler FifthButtonReleaseEvt
	{
		add
		{
			if (null == FifthButtonReleaseEvtRelay)
			{
				FifthButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 120u);
			}
			if (null != FifthButtonReleaseEvtRelay)
			{
				FifthButtonReleaseEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != FifthButtonReleaseEvtRelay)
			{
				FifthButtonReleaseEvtRelay.RemoveHandler(value);
				if (!FifthButtonReleaseEvtRelay.HasHandlers())
				{
					FifthButtonReleaseEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The FourthButtonPressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.FourthButtonPressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler FourthButtonPressEvt
	{
		add
		{
			if (null == FourthButtonPressEvtRelay)
			{
				FourthButtonPressEvtRelay = new vtkObjectEventRelay(this, 117u);
			}
			if (null != FourthButtonPressEvtRelay)
			{
				FourthButtonPressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != FourthButtonPressEvtRelay)
			{
				FourthButtonPressEvtRelay.RemoveHandler(value);
				if (!FourthButtonPressEvtRelay.HasHandlers())
				{
					FourthButtonPressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The FourthButtonReleaseEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.FourthButtonReleaseEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler FourthButtonReleaseEvt
	{
		add
		{
			if (null == FourthButtonReleaseEvtRelay)
			{
				FourthButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 118u);
			}
			if (null != FourthButtonReleaseEvtRelay)
			{
				FourthButtonReleaseEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != FourthButtonReleaseEvtRelay)
			{
				FourthButtonReleaseEvtRelay.RemoveHandler(value);
				if (!FourthButtonReleaseEvtRelay.HasHandlers())
				{
					FourthButtonReleaseEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The HighlightEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.HighlightEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler HighlightEvt
	{
		add
		{
			if (null == HighlightEvtRelay)
			{
				HighlightEvtRelay = new vtkObjectEventRelay(this, 95u);
			}
			if (null != HighlightEvtRelay)
			{
				HighlightEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != HighlightEvtRelay)
			{
				HighlightEvtRelay.RemoveHandler(value);
				if (!HighlightEvtRelay.HasHandlers())
				{
					HighlightEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The HoverEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.HoverEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler HoverEvt
	{
		add
		{
			if (null == HoverEvtRelay)
			{
				HoverEvtRelay = new vtkObjectEventRelay(this, 88u);
			}
			if (null != HoverEvtRelay)
			{
				HoverEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != HoverEvtRelay)
			{
				HoverEvtRelay.RemoveHandler(value);
				if (!HoverEvtRelay.HasHandlers())
				{
					HoverEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The InteractionEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.InteractionEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler InteractionEvt
	{
		add
		{
			if (null == InteractionEvtRelay)
			{
				InteractionEvtRelay = new vtkObjectEventRelay(this, 44u);
			}
			if (null != InteractionEvtRelay)
			{
				InteractionEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != InteractionEvtRelay)
			{
				InteractionEvtRelay.RemoveHandler(value);
				if (!InteractionEvtRelay.HasHandlers())
				{
					InteractionEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The KeyPressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.KeyPressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler KeyPressEvt
	{
		add
		{
			if (null == KeyPressEvtRelay)
			{
				KeyPressEvtRelay = new vtkObjectEventRelay(this, 20u);
			}
			if (null != KeyPressEvtRelay)
			{
				KeyPressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != KeyPressEvtRelay)
			{
				KeyPressEvtRelay.RemoveHandler(value);
				if (!KeyPressEvtRelay.HasHandlers())
				{
					KeyPressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The KeyReleaseEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.KeyReleaseEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler KeyReleaseEvt
	{
		add
		{
			if (null == KeyReleaseEvtRelay)
			{
				KeyReleaseEvtRelay = new vtkObjectEventRelay(this, 21u);
			}
			if (null != KeyReleaseEvtRelay)
			{
				KeyReleaseEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != KeyReleaseEvtRelay)
			{
				KeyReleaseEvtRelay.RemoveHandler(value);
				if (!KeyReleaseEvtRelay.HasHandlers())
				{
					KeyReleaseEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The LeaveEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.LeaveEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler LeaveEvt
	{
		add
		{
			if (null == LeaveEvtRelay)
			{
				LeaveEvtRelay = new vtkObjectEventRelay(this, 19u);
			}
			if (null != LeaveEvtRelay)
			{
				LeaveEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != LeaveEvtRelay)
			{
				LeaveEvtRelay.RemoveHandler(value);
				if (!LeaveEvtRelay.HasHandlers())
				{
					LeaveEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The LeftButtonDoubleClickEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.LeftButtonDoubleClickEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler LeftButtonDoubleClickEvt
	{
		add
		{
			if (null == LeftButtonDoubleClickEvtRelay)
			{
				LeftButtonDoubleClickEvtRelay = new vtkObjectEventRelay(this, 124u);
			}
			if (null != LeftButtonDoubleClickEvtRelay)
			{
				LeftButtonDoubleClickEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != LeftButtonDoubleClickEvtRelay)
			{
				LeftButtonDoubleClickEvtRelay.RemoveHandler(value);
				if (!LeftButtonDoubleClickEvtRelay.HasHandlers())
				{
					LeftButtonDoubleClickEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The LeftButtonPressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.LeftButtonPressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler LeftButtonPressEvt
	{
		add
		{
			if (null == LeftButtonPressEvtRelay)
			{
				LeftButtonPressEvtRelay = new vtkObjectEventRelay(this, 12u);
			}
			if (null != LeftButtonPressEvtRelay)
			{
				LeftButtonPressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != LeftButtonPressEvtRelay)
			{
				LeftButtonPressEvtRelay.RemoveHandler(value);
				if (!LeftButtonPressEvtRelay.HasHandlers())
				{
					LeftButtonPressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The LeftButtonReleaseEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.LeftButtonReleaseEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler LeftButtonReleaseEvt
	{
		add
		{
			if (null == LeftButtonReleaseEvtRelay)
			{
				LeftButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 13u);
			}
			if (null != LeftButtonReleaseEvtRelay)
			{
				LeftButtonReleaseEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != LeftButtonReleaseEvtRelay)
			{
				LeftButtonReleaseEvtRelay.RemoveHandler(value);
				if (!LeftButtonReleaseEvtRelay.HasHandlers())
				{
					LeftButtonReleaseEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The LoadStateEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.LoadStateEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler LoadStateEvt
	{
		add
		{
			if (null == LoadStateEvtRelay)
			{
				LoadStateEvtRelay = new vtkObjectEventRelay(this, 89u);
			}
			if (null != LoadStateEvtRelay)
			{
				LoadStateEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != LoadStateEvtRelay)
			{
				LoadStateEvtRelay.RemoveHandler(value);
				if (!LoadStateEvtRelay.HasHandlers())
				{
					LoadStateEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The LongTapEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.LongTapEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler LongTapEvt
	{
		add
		{
			if (null == LongTapEvtRelay)
			{
				LongTapEvtRelay = new vtkObjectEventRelay(this, 116u);
			}
			if (null != LongTapEvtRelay)
			{
				LongTapEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != LongTapEvtRelay)
			{
				LongTapEvtRelay.RemoveHandler(value);
				if (!LongTapEvtRelay.HasHandlers())
				{
					LongTapEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The Menu3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.Menu3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler Menu3DEvt
	{
		add
		{
			if (null == Menu3DEvtRelay)
			{
				Menu3DEvtRelay = new vtkObjectEventRelay(this, 130u);
			}
			if (null != Menu3DEvtRelay)
			{
				Menu3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != Menu3DEvtRelay)
			{
				Menu3DEvtRelay.RemoveHandler(value);
				if (!Menu3DEvtRelay.HasHandlers())
				{
					Menu3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MessageEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MessageEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MessageEvt
	{
		add
		{
			if (null == MessageEvtRelay)
			{
				MessageEvtRelay = new vtkObjectEventRelay(this, 102u);
			}
			if (null != MessageEvtRelay)
			{
				MessageEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MessageEvtRelay)
			{
				MessageEvtRelay.RemoveHandler(value);
				if (!MessageEvtRelay.HasHandlers())
				{
					MessageEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MiddleButtonDoubleClickEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MiddleButtonDoubleClickEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MiddleButtonDoubleClickEvt
	{
		add
		{
			if (null == MiddleButtonDoubleClickEvtRelay)
			{
				MiddleButtonDoubleClickEvtRelay = new vtkObjectEventRelay(this, 125u);
			}
			if (null != MiddleButtonDoubleClickEvtRelay)
			{
				MiddleButtonDoubleClickEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MiddleButtonDoubleClickEvtRelay)
			{
				MiddleButtonDoubleClickEvtRelay.RemoveHandler(value);
				if (!MiddleButtonDoubleClickEvtRelay.HasHandlers())
				{
					MiddleButtonDoubleClickEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MiddleButtonPressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MiddleButtonPressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MiddleButtonPressEvt
	{
		add
		{
			if (null == MiddleButtonPressEvtRelay)
			{
				MiddleButtonPressEvtRelay = new vtkObjectEventRelay(this, 14u);
			}
			if (null != MiddleButtonPressEvtRelay)
			{
				MiddleButtonPressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MiddleButtonPressEvtRelay)
			{
				MiddleButtonPressEvtRelay.RemoveHandler(value);
				if (!MiddleButtonPressEvtRelay.HasHandlers())
				{
					MiddleButtonPressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MiddleButtonReleaseEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MiddleButtonReleaseEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MiddleButtonReleaseEvt
	{
		add
		{
			if (null == MiddleButtonReleaseEvtRelay)
			{
				MiddleButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 15u);
			}
			if (null != MiddleButtonReleaseEvtRelay)
			{
				MiddleButtonReleaseEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MiddleButtonReleaseEvtRelay)
			{
				MiddleButtonReleaseEvtRelay.RemoveHandler(value);
				if (!MiddleButtonReleaseEvtRelay.HasHandlers())
				{
					MiddleButtonReleaseEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ModifiedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ModifiedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ModifiedEvt
	{
		add
		{
			if (null == ModifiedEvtRelay)
			{
				ModifiedEvtRelay = new vtkObjectEventRelay(this, 33u);
			}
			if (null != ModifiedEvtRelay)
			{
				ModifiedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ModifiedEvtRelay)
			{
				ModifiedEvtRelay.RemoveHandler(value);
				if (!ModifiedEvtRelay.HasHandlers())
				{
					ModifiedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MouseMoveEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MouseMoveEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MouseMoveEvt
	{
		add
		{
			if (null == MouseMoveEvtRelay)
			{
				MouseMoveEvtRelay = new vtkObjectEventRelay(this, 26u);
			}
			if (null != MouseMoveEvtRelay)
			{
				MouseMoveEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MouseMoveEvtRelay)
			{
				MouseMoveEvtRelay.RemoveHandler(value);
				if (!MouseMoveEvtRelay.HasHandlers())
				{
					MouseMoveEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MouseWheelBackwardEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MouseWheelBackwardEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MouseWheelBackwardEvt
	{
		add
		{
			if (null == MouseWheelBackwardEvtRelay)
			{
				MouseWheelBackwardEvtRelay = new vtkObjectEventRelay(this, 28u);
			}
			if (null != MouseWheelBackwardEvtRelay)
			{
				MouseWheelBackwardEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MouseWheelBackwardEvtRelay)
			{
				MouseWheelBackwardEvtRelay.RemoveHandler(value);
				if (!MouseWheelBackwardEvtRelay.HasHandlers())
				{
					MouseWheelBackwardEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MouseWheelForwardEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MouseWheelForwardEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MouseWheelForwardEvt
	{
		add
		{
			if (null == MouseWheelForwardEvtRelay)
			{
				MouseWheelForwardEvtRelay = new vtkObjectEventRelay(this, 27u);
			}
			if (null != MouseWheelForwardEvtRelay)
			{
				MouseWheelForwardEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MouseWheelForwardEvtRelay)
			{
				MouseWheelForwardEvtRelay.RemoveHandler(value);
				if (!MouseWheelForwardEvtRelay.HasHandlers())
				{
					MouseWheelForwardEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MouseWheelLeftEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MouseWheelLeftEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MouseWheelLeftEvt
	{
		add
		{
			if (null == MouseWheelLeftEvtRelay)
			{
				MouseWheelLeftEvtRelay = new vtkObjectEventRelay(this, 127u);
			}
			if (null != MouseWheelLeftEvtRelay)
			{
				MouseWheelLeftEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MouseWheelLeftEvtRelay)
			{
				MouseWheelLeftEvtRelay.RemoveHandler(value);
				if (!MouseWheelLeftEvtRelay.HasHandlers())
				{
					MouseWheelLeftEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The MouseWheelRightEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.MouseWheelRightEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler MouseWheelRightEvt
	{
		add
		{
			if (null == MouseWheelRightEvtRelay)
			{
				MouseWheelRightEvtRelay = new vtkObjectEventRelay(this, 128u);
			}
			if (null != MouseWheelRightEvtRelay)
			{
				MouseWheelRightEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != MouseWheelRightEvtRelay)
			{
				MouseWheelRightEvtRelay.RemoveHandler(value);
				if (!MouseWheelRightEvtRelay.HasHandlers())
				{
					MouseWheelRightEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The Move3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.Move3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler Move3DEvt
	{
		add
		{
			if (null == Move3DEvtRelay)
			{
				Move3DEvtRelay = new vtkObjectEventRelay(this, 121u);
			}
			if (null != Move3DEvtRelay)
			{
				Move3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != Move3DEvtRelay)
			{
				Move3DEvtRelay.RemoveHandler(value);
				if (!Move3DEvtRelay.HasHandlers())
				{
					Move3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The NextPose3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.NextPose3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler NextPose3DEvt
	{
		add
		{
			if (null == NextPose3DEvtRelay)
			{
				NextPose3DEvtRelay = new vtkObjectEventRelay(this, 131u);
			}
			if (null != NextPose3DEvtRelay)
			{
				NextPose3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != NextPose3DEvtRelay)
			{
				NextPose3DEvtRelay.RemoveHandler(value);
				if (!NextPose3DEvtRelay.HasHandlers())
				{
					NextPose3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The NoEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.NoEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler NoEvt
	{
		add
		{
			if (null == NoEvtRelay)
			{
				NoEvtRelay = new vtkObjectEventRelay(this, 0u);
			}
			if (null != NoEvtRelay)
			{
				NoEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != NoEvtRelay)
			{
				NoEvtRelay.RemoveHandler(value);
				if (!NoEvtRelay.HasHandlers())
				{
					NoEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The PanEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.PanEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler PanEvt
	{
		add
		{
			if (null == PanEvtRelay)
			{
				PanEvtRelay = new vtkObjectEventRelay(this, 113u);
			}
			if (null != PanEvtRelay)
			{
				PanEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != PanEvtRelay)
			{
				PanEvtRelay.RemoveHandler(value);
				if (!PanEvtRelay.HasHandlers())
				{
					PanEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The PickEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.PickEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler PickEvt
	{
		add
		{
			if (null == PickEvtRelay)
			{
				PickEvtRelay = new vtkObjectEventRelay(this, 7u);
			}
			if (null != PickEvtRelay)
			{
				PickEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != PickEvtRelay)
			{
				PickEvtRelay.RemoveHandler(value);
				if (!PickEvtRelay.HasHandlers())
				{
					PickEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The Pick3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.Pick3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler Pick3DEvt
	{
		add
		{
			if (null == Pick3DEvtRelay)
			{
				Pick3DEvtRelay = new vtkObjectEventRelay(this, 134u);
			}
			if (null != Pick3DEvtRelay)
			{
				Pick3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != Pick3DEvtRelay)
			{
				Pick3DEvtRelay.RemoveHandler(value);
				if (!Pick3DEvtRelay.HasHandlers())
				{
					Pick3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The PinchEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.PinchEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler PinchEvt
	{
		add
		{
			if (null == PinchEvtRelay)
			{
				PinchEvtRelay = new vtkObjectEventRelay(this, 107u);
			}
			if (null != PinchEvtRelay)
			{
				PinchEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != PinchEvtRelay)
			{
				PinchEvtRelay.RemoveHandler(value);
				if (!PinchEvtRelay.HasHandlers())
				{
					PinchEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The PlacePointEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.PlacePointEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler PlacePointEvt
	{
		add
		{
			if (null == PlacePointEvtRelay)
			{
				PlacePointEvtRelay = new vtkObjectEventRelay(this, 50u);
			}
			if (null != PlacePointEvtRelay)
			{
				PlacePointEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != PlacePointEvtRelay)
			{
				PlacePointEvtRelay.RemoveHandler(value);
				if (!PlacePointEvtRelay.HasHandlers())
				{
					PlacePointEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The PlaceWidgetEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.PlaceWidgetEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler PlaceWidgetEvt
	{
		add
		{
			if (null == PlaceWidgetEvtRelay)
			{
				PlaceWidgetEvtRelay = new vtkObjectEventRelay(this, 52u);
			}
			if (null != PlaceWidgetEvtRelay)
			{
				PlaceWidgetEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != PlaceWidgetEvtRelay)
			{
				PlaceWidgetEvtRelay.RemoveHandler(value);
				if (!PlaceWidgetEvtRelay.HasHandlers())
				{
					PlaceWidgetEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The PositionProp3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.PositionProp3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler PositionProp3DEvt
	{
		add
		{
			if (null == PositionProp3DEvtRelay)
			{
				PositionProp3DEvtRelay = new vtkObjectEventRelay(this, 133u);
			}
			if (null != PositionProp3DEvtRelay)
			{
				PositionProp3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != PositionProp3DEvtRelay)
			{
				PositionProp3DEvtRelay.RemoveHandler(value);
				if (!PositionProp3DEvtRelay.HasHandlers())
				{
					PositionProp3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ProgressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ProgressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ProgressEvt
	{
		add
		{
			if (null == ProgressEvtRelay)
			{
				ProgressEvtRelay = new vtkObjectEventRelay(this, 6u);
			}
			if (null != ProgressEvtRelay)
			{
				ProgressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ProgressEvtRelay)
			{
				ProgressEvtRelay.RemoveHandler(value);
				if (!ProgressEvtRelay.HasHandlers())
				{
					ProgressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The PropertyModifiedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.PropertyModifiedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler PropertyModifiedEvt
	{
		add
		{
			if (null == PropertyModifiedEvtRelay)
			{
				PropertyModifiedEvtRelay = new vtkObjectEventRelay(this, 73u);
			}
			if (null != PropertyModifiedEvtRelay)
			{
				PropertyModifiedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != PropertyModifiedEvtRelay)
			{
				PropertyModifiedEvtRelay.RemoveHandler(value);
				if (!PropertyModifiedEvtRelay.HasHandlers())
				{
					PropertyModifiedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The RegisterEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.RegisterEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler RegisterEvt
	{
		add
		{
			if (null == RegisterEvtRelay)
			{
				RegisterEvtRelay = new vtkObjectEventRelay(this, 75u);
			}
			if (null != RegisterEvtRelay)
			{
				RegisterEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != RegisterEvtRelay)
			{
				RegisterEvtRelay.RemoveHandler(value);
				if (!RegisterEvtRelay.HasHandlers())
				{
					RegisterEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The RenderEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.RenderEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler RenderEvt
	{
		add
		{
			if (null == RenderEvtRelay)
			{
				RenderEvtRelay = new vtkObjectEventRelay(this, 5u);
			}
			if (null != RenderEvtRelay)
			{
				RenderEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != RenderEvtRelay)
			{
				RenderEvtRelay.RemoveHandler(value);
				if (!RenderEvtRelay.HasHandlers())
				{
					RenderEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The RenderWindowMessageEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.RenderWindowMessageEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler RenderWindowMessageEvt
	{
		add
		{
			if (null == RenderWindowMessageEvtRelay)
			{
				RenderWindowMessageEvtRelay = new vtkObjectEventRelay(this, 55u);
			}
			if (null != RenderWindowMessageEvtRelay)
			{
				RenderWindowMessageEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != RenderWindowMessageEvtRelay)
			{
				RenderWindowMessageEvtRelay.RemoveHandler(value);
				if (!RenderWindowMessageEvtRelay.HasHandlers())
				{
					RenderWindowMessageEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ResetCameraEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ResetCameraEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ResetCameraEvt
	{
		add
		{
			if (null == ResetCameraEvtRelay)
			{
				ResetCameraEvtRelay = new vtkObjectEventRelay(this, 31u);
			}
			if (null != ResetCameraEvtRelay)
			{
				ResetCameraEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ResetCameraEvtRelay)
			{
				ResetCameraEvtRelay.RemoveHandler(value);
				if (!ResetCameraEvtRelay.HasHandlers())
				{
					ResetCameraEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ResetCameraClippingRangeEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ResetCameraClippingRangeEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ResetCameraClippingRangeEvt
	{
		add
		{
			if (null == ResetCameraClippingRangeEvtRelay)
			{
				ResetCameraClippingRangeEvtRelay = new vtkObjectEventRelay(this, 32u);
			}
			if (null != ResetCameraClippingRangeEvtRelay)
			{
				ResetCameraClippingRangeEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ResetCameraClippingRangeEvtRelay)
			{
				ResetCameraClippingRangeEvtRelay.RemoveHandler(value);
				if (!ResetCameraClippingRangeEvtRelay.HasHandlers())
				{
					ResetCameraClippingRangeEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ResetWindowLevelEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ResetWindowLevelEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ResetWindowLevelEvt
	{
		add
		{
			if (null == ResetWindowLevelEvtRelay)
			{
				ResetWindowLevelEvtRelay = new vtkObjectEventRelay(this, 37u);
			}
			if (null != ResetWindowLevelEvtRelay)
			{
				ResetWindowLevelEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ResetWindowLevelEvtRelay)
			{
				ResetWindowLevelEvtRelay.RemoveHandler(value);
				if (!ResetWindowLevelEvtRelay.HasHandlers())
				{
					ResetWindowLevelEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ResliceAxesChangedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ResliceAxesChangedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ResliceAxesChangedEvt
	{
		add
		{
			if (null == ResliceAxesChangedEvtRelay)
			{
				ResliceAxesChangedEvtRelay = new vtkObjectEventRelay(this, 58u);
			}
			if (null != ResliceAxesChangedEvtRelay)
			{
				ResliceAxesChangedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ResliceAxesChangedEvtRelay)
			{
				ResliceAxesChangedEvtRelay.RemoveHandler(value);
				if (!ResliceAxesChangedEvtRelay.HasHandlers())
				{
					ResliceAxesChangedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The RightButtonDoubleClickEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.RightButtonDoubleClickEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler RightButtonDoubleClickEvt
	{
		add
		{
			if (null == RightButtonDoubleClickEvtRelay)
			{
				RightButtonDoubleClickEvtRelay = new vtkObjectEventRelay(this, 126u);
			}
			if (null != RightButtonDoubleClickEvtRelay)
			{
				RightButtonDoubleClickEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != RightButtonDoubleClickEvtRelay)
			{
				RightButtonDoubleClickEvtRelay.RemoveHandler(value);
				if (!RightButtonDoubleClickEvtRelay.HasHandlers())
				{
					RightButtonDoubleClickEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The RightButtonPressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.RightButtonPressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler RightButtonPressEvt
	{
		add
		{
			if (null == RightButtonPressEvtRelay)
			{
				RightButtonPressEvtRelay = new vtkObjectEventRelay(this, 16u);
			}
			if (null != RightButtonPressEvtRelay)
			{
				RightButtonPressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != RightButtonPressEvtRelay)
			{
				RightButtonPressEvtRelay.RemoveHandler(value);
				if (!RightButtonPressEvtRelay.HasHandlers())
				{
					RightButtonPressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The RightButtonReleaseEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.RightButtonReleaseEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler RightButtonReleaseEvt
	{
		add
		{
			if (null == RightButtonReleaseEvtRelay)
			{
				RightButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 17u);
			}
			if (null != RightButtonReleaseEvtRelay)
			{
				RightButtonReleaseEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != RightButtonReleaseEvtRelay)
			{
				RightButtonReleaseEvtRelay.RemoveHandler(value);
				if (!RightButtonReleaseEvtRelay.HasHandlers())
				{
					RightButtonReleaseEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The RotateEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.RotateEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler RotateEvt
	{
		add
		{
			if (null == RotateEvtRelay)
			{
				RotateEvtRelay = new vtkObjectEventRelay(this, 110u);
			}
			if (null != RotateEvtRelay)
			{
				RotateEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != RotateEvtRelay)
			{
				RotateEvtRelay.RemoveHandler(value);
				if (!RotateEvtRelay.HasHandlers())
				{
					RotateEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The SaveStateEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.SaveStateEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler SaveStateEvt
	{
		add
		{
			if (null == SaveStateEvtRelay)
			{
				SaveStateEvtRelay = new vtkObjectEventRelay(this, 90u);
			}
			if (null != SaveStateEvtRelay)
			{
				SaveStateEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != SaveStateEvtRelay)
			{
				SaveStateEvtRelay.RemoveHandler(value);
				if (!SaveStateEvtRelay.HasHandlers())
				{
					SaveStateEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The Select3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.Select3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler Select3DEvt
	{
		add
		{
			if (null == Select3DEvtRelay)
			{
				Select3DEvtRelay = new vtkObjectEventRelay(this, 135u);
			}
			if (null != Select3DEvtRelay)
			{
				Select3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != Select3DEvtRelay)
			{
				Select3DEvtRelay.RemoveHandler(value);
				if (!Select3DEvtRelay.HasHandlers())
				{
					Select3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The SelectionChangedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.SelectionChangedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler SelectionChangedEvt
	{
		add
		{
			if (null == SelectionChangedEvtRelay)
			{
				SelectionChangedEvtRelay = new vtkObjectEventRelay(this, 79u);
			}
			if (null != SelectionChangedEvtRelay)
			{
				SelectionChangedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != SelectionChangedEvtRelay)
			{
				SelectionChangedEvtRelay.RemoveHandler(value);
				if (!SelectionChangedEvtRelay.HasHandlers())
				{
					SelectionChangedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The SetOutputEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.SetOutputEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler SetOutputEvt
	{
		add
		{
			if (null == SetOutputEvtRelay)
			{
				SetOutputEvtRelay = new vtkObjectEventRelay(this, 38u);
			}
			if (null != SetOutputEvtRelay)
			{
				SetOutputEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != SetOutputEvtRelay)
			{
				SetOutputEvtRelay.RemoveHandler(value);
				if (!SetOutputEvtRelay.HasHandlers())
				{
					SetOutputEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartEvt
	{
		add
		{
			if (null == StartEvtRelay)
			{
				StartEvtRelay = new vtkObjectEventRelay(this, 3u);
			}
			if (null != StartEvtRelay)
			{
				StartEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartEvtRelay)
			{
				StartEvtRelay.RemoveHandler(value);
				if (!StartEvtRelay.HasHandlers())
				{
					StartEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartAnimationCueEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartAnimationCueEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartAnimationCueEvt
	{
		add
		{
			if (null == StartAnimationCueEvtRelay)
			{
				StartAnimationCueEvtRelay = new vtkObjectEventRelay(this, 57u);
			}
			if (null != StartAnimationCueEvtRelay)
			{
				StartAnimationCueEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartAnimationCueEvtRelay)
			{
				StartAnimationCueEvtRelay.RemoveHandler(value);
				if (!StartAnimationCueEvtRelay.HasHandlers())
				{
					StartAnimationCueEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartInteractionEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartInteractionEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartInteractionEvt
	{
		add
		{
			if (null == StartInteractionEvtRelay)
			{
				StartInteractionEvtRelay = new vtkObjectEventRelay(this, 41u);
			}
			if (null != StartInteractionEvtRelay)
			{
				StartInteractionEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartInteractionEvtRelay)
			{
				StartInteractionEvtRelay.RemoveHandler(value);
				if (!StartInteractionEvtRelay.HasHandlers())
				{
					StartInteractionEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartPanEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartPanEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartPanEvt
	{
		add
		{
			if (null == StartPanEvtRelay)
			{
				StartPanEvtRelay = new vtkObjectEventRelay(this, 112u);
			}
			if (null != StartPanEvtRelay)
			{
				StartPanEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartPanEvtRelay)
			{
				StartPanEvtRelay.RemoveHandler(value);
				if (!StartPanEvtRelay.HasHandlers())
				{
					StartPanEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartPickEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartPickEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartPickEvt
	{
		add
		{
			if (null == StartPickEvtRelay)
			{
				StartPickEvtRelay = new vtkObjectEventRelay(this, 8u);
			}
			if (null != StartPickEvtRelay)
			{
				StartPickEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartPickEvtRelay)
			{
				StartPickEvtRelay.RemoveHandler(value);
				if (!StartPickEvtRelay.HasHandlers())
				{
					StartPickEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartPinchEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartPinchEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartPinchEvt
	{
		add
		{
			if (null == StartPinchEvtRelay)
			{
				StartPinchEvtRelay = new vtkObjectEventRelay(this, 106u);
			}
			if (null != StartPinchEvtRelay)
			{
				StartPinchEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartPinchEvtRelay)
			{
				StartPinchEvtRelay.RemoveHandler(value);
				if (!StartPinchEvtRelay.HasHandlers())
				{
					StartPinchEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartRotateEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartRotateEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartRotateEvt
	{
		add
		{
			if (null == StartRotateEvtRelay)
			{
				StartRotateEvtRelay = new vtkObjectEventRelay(this, 109u);
			}
			if (null != StartRotateEvtRelay)
			{
				StartRotateEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartRotateEvtRelay)
			{
				StartRotateEvtRelay.RemoveHandler(value);
				if (!StartRotateEvtRelay.HasHandlers())
				{
					StartRotateEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartSwipeEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartSwipeEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartSwipeEvt
	{
		add
		{
			if (null == StartSwipeEvtRelay)
			{
				StartSwipeEvtRelay = new vtkObjectEventRelay(this, 103u);
			}
			if (null != StartSwipeEvtRelay)
			{
				StartSwipeEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartSwipeEvtRelay)
			{
				StartSwipeEvtRelay.RemoveHandler(value);
				if (!StartSwipeEvtRelay.HasHandlers())
				{
					StartSwipeEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StartWindowLevelEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StartWindowLevelEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StartWindowLevelEvt
	{
		add
		{
			if (null == StartWindowLevelEvtRelay)
			{
				StartWindowLevelEvtRelay = new vtkObjectEventRelay(this, 35u);
			}
			if (null != StartWindowLevelEvtRelay)
			{
				StartWindowLevelEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StartWindowLevelEvtRelay)
			{
				StartWindowLevelEvtRelay.RemoveHandler(value);
				if (!StartWindowLevelEvtRelay.HasHandlers())
				{
					StartWindowLevelEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The StateChangedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.StateChangedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler StateChangedEvt
	{
		add
		{
			if (null == StateChangedEvtRelay)
			{
				StateChangedEvtRelay = new vtkObjectEventRelay(this, 91u);
			}
			if (null != StateChangedEvtRelay)
			{
				StateChangedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != StateChangedEvtRelay)
			{
				StateChangedEvtRelay.RemoveHandler(value);
				if (!StateChangedEvtRelay.HasHandlers())
				{
					StateChangedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The SwipeEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.SwipeEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler SwipeEvt
	{
		add
		{
			if (null == SwipeEvtRelay)
			{
				SwipeEvtRelay = new vtkObjectEventRelay(this, 104u);
			}
			if (null != SwipeEvtRelay)
			{
				SwipeEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != SwipeEvtRelay)
			{
				SwipeEvtRelay.RemoveHandler(value);
				if (!SwipeEvtRelay.HasHandlers())
				{
					SwipeEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The TapEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.TapEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler TapEvt
	{
		add
		{
			if (null == TapEvtRelay)
			{
				TapEvtRelay = new vtkObjectEventRelay(this, 115u);
			}
			if (null != TapEvtRelay)
			{
				TapEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != TapEvtRelay)
			{
				TapEvtRelay.RemoveHandler(value);
				if (!TapEvtRelay.HasHandlers())
				{
					TapEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The TDxButtonPressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.TDxButtonPressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler TDxButtonPressEvt
	{
		add
		{
			if (null == TDxButtonPressEvtRelay)
			{
				TDxButtonPressEvtRelay = new vtkObjectEventRelay(this, 86u);
			}
			if (null != TDxButtonPressEvtRelay)
			{
				TDxButtonPressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != TDxButtonPressEvtRelay)
			{
				TDxButtonPressEvtRelay.RemoveHandler(value);
				if (!TDxButtonPressEvtRelay.HasHandlers())
				{
					TDxButtonPressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The TDxButtonReleaseEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.TDxButtonReleaseEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler TDxButtonReleaseEvt
	{
		add
		{
			if (null == TDxButtonReleaseEvtRelay)
			{
				TDxButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 87u);
			}
			if (null != TDxButtonReleaseEvtRelay)
			{
				TDxButtonReleaseEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != TDxButtonReleaseEvtRelay)
			{
				TDxButtonReleaseEvtRelay.RemoveHandler(value);
				if (!TDxButtonReleaseEvtRelay.HasHandlers())
				{
					TDxButtonReleaseEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The TDxMotionEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.TDxMotionEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler TDxMotionEvt
	{
		add
		{
			if (null == TDxMotionEvtRelay)
			{
				TDxMotionEvtRelay = new vtkObjectEventRelay(this, 85u);
			}
			if (null != TDxMotionEvtRelay)
			{
				TDxMotionEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != TDxMotionEvtRelay)
			{
				TDxMotionEvtRelay.RemoveHandler(value);
				if (!TDxMotionEvtRelay.HasHandlers())
				{
					TDxMotionEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The TextEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.TextEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler TextEvt
	{
		add
		{
			if (null == TextEvtRelay)
			{
				TextEvtRelay = new vtkObjectEventRelay(this, 123u);
			}
			if (null != TextEvtRelay)
			{
				TextEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != TextEvtRelay)
			{
				TextEvtRelay.RemoveHandler(value);
				if (!TextEvtRelay.HasHandlers())
				{
					TextEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The TimerEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.TimerEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler TimerEvt
	{
		add
		{
			if (null == TimerEvtRelay)
			{
				TimerEvtRelay = new vtkObjectEventRelay(this, 25u);
			}
			if (null != TimerEvtRelay)
			{
				TimerEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != TimerEvtRelay)
			{
				TimerEvtRelay.RemoveHandler(value);
				if (!TimerEvtRelay.HasHandlers())
				{
					TimerEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UncheckedPropertyModifiedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UncheckedPropertyModifiedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UncheckedPropertyModifiedEvt
	{
		add
		{
			if (null == UncheckedPropertyModifiedEvtRelay)
			{
				UncheckedPropertyModifiedEvtRelay = new vtkObjectEventRelay(this, 100u);
			}
			if (null != UncheckedPropertyModifiedEvtRelay)
			{
				UncheckedPropertyModifiedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UncheckedPropertyModifiedEvtRelay)
			{
				UncheckedPropertyModifiedEvtRelay.RemoveHandler(value);
				if (!UncheckedPropertyModifiedEvtRelay.HasHandlers())
				{
					UncheckedPropertyModifiedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UnRegisterEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UnRegisterEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UnRegisterEvt
	{
		add
		{
			if (null == UnRegisterEvtRelay)
			{
				UnRegisterEvtRelay = new vtkObjectEventRelay(this, 76u);
			}
			if (null != UnRegisterEvtRelay)
			{
				UnRegisterEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UnRegisterEvtRelay)
			{
				UnRegisterEvtRelay.RemoveHandler(value);
				if (!UnRegisterEvtRelay.HasHandlers())
				{
					UnRegisterEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UpdateEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UpdateEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UpdateEvt
	{
		add
		{
			if (null == UpdateEvtRelay)
			{
				UpdateEvtRelay = new vtkObjectEventRelay(this, 74u);
			}
			if (null != UpdateEvtRelay)
			{
				UpdateEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UpdateEvtRelay)
			{
				UpdateEvtRelay.RemoveHandler(value);
				if (!UpdateEvtRelay.HasHandlers())
				{
					UpdateEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UpdateDataEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UpdateDataEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UpdateDataEvt
	{
		add
		{
			if (null == UpdateDataEvtRelay)
			{
				UpdateDataEvtRelay = new vtkObjectEventRelay(this, 82u);
			}
			if (null != UpdateDataEvtRelay)
			{
				UpdateDataEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UpdateDataEvtRelay)
			{
				UpdateDataEvtRelay.RemoveHandler(value);
				if (!UpdateDataEvtRelay.HasHandlers())
				{
					UpdateDataEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UpdateDropLocationEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UpdateDropLocationEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UpdateDropLocationEvt
	{
		add
		{
			if (null == UpdateDropLocationEvtRelay)
			{
				UpdateDropLocationEvtRelay = new vtkObjectEventRelay(this, 43u);
			}
			if (null != UpdateDropLocationEvtRelay)
			{
				UpdateDropLocationEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UpdateDropLocationEvtRelay)
			{
				UpdateDropLocationEvtRelay.RemoveHandler(value);
				if (!UpdateDropLocationEvtRelay.HasHandlers())
				{
					UpdateDropLocationEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UpdateInformationEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UpdateInformationEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UpdateInformationEvt
	{
		add
		{
			if (null == UpdateInformationEvtRelay)
			{
				UpdateInformationEvtRelay = new vtkObjectEventRelay(this, 77u);
			}
			if (null != UpdateInformationEvtRelay)
			{
				UpdateInformationEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UpdateInformationEvtRelay)
			{
				UpdateInformationEvtRelay.RemoveHandler(value);
				if (!UpdateInformationEvtRelay.HasHandlers())
				{
					UpdateInformationEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UpdatePropertyEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UpdatePropertyEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UpdatePropertyEvt
	{
		add
		{
			if (null == UpdatePropertyEvtRelay)
			{
				UpdatePropertyEvtRelay = new vtkObjectEventRelay(this, 80u);
			}
			if (null != UpdatePropertyEvtRelay)
			{
				UpdatePropertyEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UpdatePropertyEvtRelay)
			{
				UpdatePropertyEvtRelay.RemoveHandler(value);
				if (!UpdatePropertyEvtRelay.HasHandlers())
				{
					UpdatePropertyEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UpdateShaderEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UpdateShaderEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UpdateShaderEvt
	{
		add
		{
			if (null == UpdateShaderEvtRelay)
			{
				UpdateShaderEvtRelay = new vtkObjectEventRelay(this, 101u);
			}
			if (null != UpdateShaderEvtRelay)
			{
				UpdateShaderEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UpdateShaderEvtRelay)
			{
				UpdateShaderEvtRelay.RemoveHandler(value);
				if (!UpdateShaderEvtRelay.HasHandlers())
				{
					UpdateShaderEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The UserEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.UserEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler UserEvt
	{
		add
		{
			if (null == UserEvtRelay)
			{
				UserEvtRelay = new vtkObjectEventRelay(this, 1000u);
			}
			if (null != UserEvtRelay)
			{
				UserEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != UserEvtRelay)
			{
				UserEvtRelay.RemoveHandler(value);
				if (!UserEvtRelay.HasHandlers())
				{
					UserEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ViewerMovement3DEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ViewerMovement3DEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ViewerMovement3DEvt
	{
		add
		{
			if (null == ViewerMovement3DEvtRelay)
			{
				ViewerMovement3DEvtRelay = new vtkObjectEventRelay(this, 129u);
			}
			if (null != ViewerMovement3DEvtRelay)
			{
				ViewerMovement3DEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ViewerMovement3DEvtRelay)
			{
				ViewerMovement3DEvtRelay.RemoveHandler(value);
				if (!ViewerMovement3DEvtRelay.HasHandlers())
				{
					ViewerMovement3DEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The ViewProgressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.ViewProgressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler ViewProgressEvt
	{
		add
		{
			if (null == ViewProgressEvtRelay)
			{
				ViewProgressEvtRelay = new vtkObjectEventRelay(this, 81u);
			}
			if (null != ViewProgressEvtRelay)
			{
				ViewProgressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != ViewProgressEvtRelay)
			{
				ViewProgressEvtRelay.RemoveHandler(value);
				if (!ViewProgressEvtRelay.HasHandlers())
				{
					ViewProgressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The VolumeMapperComputeGradientsEndEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.VolumeMapperComputeGradientsEndEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler VolumeMapperComputeGradientsEndEvt
	{
		add
		{
			if (null == VolumeMapperComputeGradientsEndEvtRelay)
			{
				VolumeMapperComputeGradientsEndEvtRelay = new vtkObjectEventRelay(this, 64u);
			}
			if (null != VolumeMapperComputeGradientsEndEvtRelay)
			{
				VolumeMapperComputeGradientsEndEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != VolumeMapperComputeGradientsEndEvtRelay)
			{
				VolumeMapperComputeGradientsEndEvtRelay.RemoveHandler(value);
				if (!VolumeMapperComputeGradientsEndEvtRelay.HasHandlers())
				{
					VolumeMapperComputeGradientsEndEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The VolumeMapperComputeGradientsProgressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.VolumeMapperComputeGradientsProgressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler VolumeMapperComputeGradientsProgressEvt
	{
		add
		{
			if (null == VolumeMapperComputeGradientsProgressEvtRelay)
			{
				VolumeMapperComputeGradientsProgressEvtRelay = new vtkObjectEventRelay(this, 65u);
			}
			if (null != VolumeMapperComputeGradientsProgressEvtRelay)
			{
				VolumeMapperComputeGradientsProgressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != VolumeMapperComputeGradientsProgressEvtRelay)
			{
				VolumeMapperComputeGradientsProgressEvtRelay.RemoveHandler(value);
				if (!VolumeMapperComputeGradientsProgressEvtRelay.HasHandlers())
				{
					VolumeMapperComputeGradientsProgressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The VolumeMapperComputeGradientsStartEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.VolumeMapperComputeGradientsStartEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler VolumeMapperComputeGradientsStartEvt
	{
		add
		{
			if (null == VolumeMapperComputeGradientsStartEvtRelay)
			{
				VolumeMapperComputeGradientsStartEvtRelay = new vtkObjectEventRelay(this, 66u);
			}
			if (null != VolumeMapperComputeGradientsStartEvtRelay)
			{
				VolumeMapperComputeGradientsStartEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != VolumeMapperComputeGradientsStartEvtRelay)
			{
				VolumeMapperComputeGradientsStartEvtRelay.RemoveHandler(value);
				if (!VolumeMapperComputeGradientsStartEvtRelay.HasHandlers())
				{
					VolumeMapperComputeGradientsStartEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The VolumeMapperRenderEndEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.VolumeMapperRenderEndEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler VolumeMapperRenderEndEvt
	{
		add
		{
			if (null == VolumeMapperRenderEndEvtRelay)
			{
				VolumeMapperRenderEndEvtRelay = new vtkObjectEventRelay(this, 61u);
			}
			if (null != VolumeMapperRenderEndEvtRelay)
			{
				VolumeMapperRenderEndEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != VolumeMapperRenderEndEvtRelay)
			{
				VolumeMapperRenderEndEvtRelay.RemoveHandler(value);
				if (!VolumeMapperRenderEndEvtRelay.HasHandlers())
				{
					VolumeMapperRenderEndEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The VolumeMapperRenderProgressEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.VolumeMapperRenderProgressEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler VolumeMapperRenderProgressEvt
	{
		add
		{
			if (null == VolumeMapperRenderProgressEvtRelay)
			{
				VolumeMapperRenderProgressEvtRelay = new vtkObjectEventRelay(this, 62u);
			}
			if (null != VolumeMapperRenderProgressEvtRelay)
			{
				VolumeMapperRenderProgressEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != VolumeMapperRenderProgressEvtRelay)
			{
				VolumeMapperRenderProgressEvtRelay.RemoveHandler(value);
				if (!VolumeMapperRenderProgressEvtRelay.HasHandlers())
				{
					VolumeMapperRenderProgressEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The VolumeMapperRenderStartEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.VolumeMapperRenderStartEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler VolumeMapperRenderStartEvt
	{
		add
		{
			if (null == VolumeMapperRenderStartEvtRelay)
			{
				VolumeMapperRenderStartEvtRelay = new vtkObjectEventRelay(this, 63u);
			}
			if (null != VolumeMapperRenderStartEvtRelay)
			{
				VolumeMapperRenderStartEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != VolumeMapperRenderStartEvtRelay)
			{
				VolumeMapperRenderStartEvtRelay.RemoveHandler(value);
				if (!VolumeMapperRenderStartEvtRelay.HasHandlers())
				{
					VolumeMapperRenderStartEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WarningEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WarningEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WarningEvt
	{
		add
		{
			if (null == WarningEvtRelay)
			{
				WarningEvtRelay = new vtkObjectEventRelay(this, 40u);
			}
			if (null != WarningEvtRelay)
			{
				WarningEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WarningEvtRelay)
			{
				WarningEvtRelay.RemoveHandler(value);
				if (!WarningEvtRelay.HasHandlers())
				{
					WarningEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WidgetActivateEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WidgetActivateEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WidgetActivateEvt
	{
		add
		{
			if (null == WidgetActivateEvtRelay)
			{
				WidgetActivateEvtRelay = new vtkObjectEventRelay(this, 69u);
			}
			if (null != WidgetActivateEvtRelay)
			{
				WidgetActivateEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WidgetActivateEvtRelay)
			{
				WidgetActivateEvtRelay.RemoveHandler(value);
				if (!WidgetActivateEvtRelay.HasHandlers())
				{
					WidgetActivateEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WidgetModifiedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WidgetModifiedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WidgetModifiedEvt
	{
		add
		{
			if (null == WidgetModifiedEvtRelay)
			{
				WidgetModifiedEvtRelay = new vtkObjectEventRelay(this, 67u);
			}
			if (null != WidgetModifiedEvtRelay)
			{
				WidgetModifiedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WidgetModifiedEvtRelay)
			{
				WidgetModifiedEvtRelay.RemoveHandler(value);
				if (!WidgetModifiedEvtRelay.HasHandlers())
				{
					WidgetModifiedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WidgetValueChangedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WidgetValueChangedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WidgetValueChangedEvt
	{
		add
		{
			if (null == WidgetValueChangedEvtRelay)
			{
				WidgetValueChangedEvtRelay = new vtkObjectEventRelay(this, 68u);
			}
			if (null != WidgetValueChangedEvtRelay)
			{
				WidgetValueChangedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WidgetValueChangedEvtRelay)
			{
				WidgetValueChangedEvtRelay.RemoveHandler(value);
				if (!WidgetValueChangedEvtRelay.HasHandlers())
				{
					WidgetValueChangedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WindowFrameEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WindowFrameEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WindowFrameEvt
	{
		add
		{
			if (null == WindowFrameEvtRelay)
			{
				WindowFrameEvtRelay = new vtkObjectEventRelay(this, 94u);
			}
			if (null != WindowFrameEvtRelay)
			{
				WindowFrameEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WindowFrameEvtRelay)
			{
				WindowFrameEvtRelay.RemoveHandler(value);
				if (!WindowFrameEvtRelay.HasHandlers())
				{
					WindowFrameEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WindowIsCurrentEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WindowIsCurrentEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WindowIsCurrentEvt
	{
		add
		{
			if (null == WindowIsCurrentEvtRelay)
			{
				WindowIsCurrentEvtRelay = new vtkObjectEventRelay(this, 93u);
			}
			if (null != WindowIsCurrentEvtRelay)
			{
				WindowIsCurrentEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WindowIsCurrentEvtRelay)
			{
				WindowIsCurrentEvtRelay.RemoveHandler(value);
				if (!WindowIsCurrentEvtRelay.HasHandlers())
				{
					WindowIsCurrentEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WindowIsDirectEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WindowIsDirectEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WindowIsDirectEvt
	{
		add
		{
			if (null == WindowIsDirectEvtRelay)
			{
				WindowIsDirectEvtRelay = new vtkObjectEventRelay(this, 97u);
			}
			if (null != WindowIsDirectEvtRelay)
			{
				WindowIsDirectEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WindowIsDirectEvtRelay)
			{
				WindowIsDirectEvtRelay.RemoveHandler(value);
				if (!WindowIsDirectEvtRelay.HasHandlers())
				{
					WindowIsDirectEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WindowLevelEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WindowLevelEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WindowLevelEvt
	{
		add
		{
			if (null == WindowLevelEvtRelay)
			{
				WindowLevelEvtRelay = new vtkObjectEventRelay(this, 34u);
			}
			if (null != WindowLevelEvtRelay)
			{
				WindowLevelEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WindowLevelEvtRelay)
			{
				WindowLevelEvtRelay.RemoveHandler(value);
				if (!WindowLevelEvtRelay.HasHandlers())
				{
					WindowLevelEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WindowMakeCurrentEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WindowMakeCurrentEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WindowMakeCurrentEvt
	{
		add
		{
			if (null == WindowMakeCurrentEvtRelay)
			{
				WindowMakeCurrentEvtRelay = new vtkObjectEventRelay(this, 92u);
			}
			if (null != WindowMakeCurrentEvtRelay)
			{
				WindowMakeCurrentEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WindowMakeCurrentEvtRelay)
			{
				WindowMakeCurrentEvtRelay.RemoveHandler(value);
				if (!WindowMakeCurrentEvtRelay.HasHandlers())
				{
					WindowMakeCurrentEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WindowResizeEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WindowResizeEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WindowResizeEvt
	{
		add
		{
			if (null == WindowResizeEvtRelay)
			{
				WindowResizeEvtRelay = new vtkObjectEventRelay(this, 99u);
			}
			if (null != WindowResizeEvtRelay)
			{
				WindowResizeEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WindowResizeEvtRelay)
			{
				WindowResizeEvtRelay.RemoveHandler(value);
				if (!WindowResizeEvtRelay.HasHandlers())
				{
					WindowResizeEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WindowStereoTypeChangedEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WindowStereoTypeChangedEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WindowStereoTypeChangedEvt
	{
		add
		{
			if (null == WindowStereoTypeChangedEvtRelay)
			{
				WindowStereoTypeChangedEvtRelay = new vtkObjectEventRelay(this, 98u);
			}
			if (null != WindowStereoTypeChangedEvtRelay)
			{
				WindowStereoTypeChangedEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WindowStereoTypeChangedEvtRelay)
			{
				WindowStereoTypeChangedEvtRelay.RemoveHandler(value);
				if (!WindowStereoTypeChangedEvtRelay.HasHandlers())
				{
					WindowStereoTypeChangedEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WindowSupportsOpenGLEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WindowSupportsOpenGLEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WindowSupportsOpenGLEvt
	{
		add
		{
			if (null == WindowSupportsOpenGLEvtRelay)
			{
				WindowSupportsOpenGLEvtRelay = new vtkObjectEventRelay(this, 96u);
			}
			if (null != WindowSupportsOpenGLEvtRelay)
			{
				WindowSupportsOpenGLEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WindowSupportsOpenGLEvtRelay)
			{
				WindowSupportsOpenGLEvtRelay.RemoveHandler(value);
				if (!WindowSupportsOpenGLEvtRelay.HasHandlers())
				{
					WindowSupportsOpenGLEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// The WrongTagEvt event is invoked when the sender's InvokeEvent method
	/// is called with vtkCommand.EventIds.WrongTagEvent
	/// as the eventId parameter.
	/// </summary>
	public event vtkObjectEventHandler WrongTagEvt
	{
		add
		{
			if (null == WrongTagEvtRelay)
			{
				WrongTagEvtRelay = new vtkObjectEventRelay(this, 56u);
			}
			if (null != WrongTagEvtRelay)
			{
				WrongTagEvtRelay.AddHandler(value);
			}
		}
		remove
		{
			if (null != WrongTagEvtRelay)
			{
				WrongTagEvtRelay.RemoveHandler(value);
				if (!WrongTagEvtRelay.HasHandlers())
				{
					WrongTagEvtRelay = null;
				}
			}
		}
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkObject()
	{
		MRClassNameKey = "class vtkObject";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkObject"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an object with Debug turned off, modified time initialized
	/// to zero, and reference counting on.
	/// </summary>
	public new static vtkObject New()
	{
		vtkObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create an object with Debug turned off, modified time initialized
	/// to zero, and reference counting on.
	/// </summary>
	public vtkObject()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkObject_AddObserver_01(HandleRef pThis, uint arg0, HandleRef arg1, float priority);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public uint AddObserver(uint arg0, vtkCommand arg1, float priority)
	{
		return vtkObject_AddObserver_01(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef), priority);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkObject_AddObserver_02(HandleRef pThis, string arg0, HandleRef arg1, float priority);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public uint AddObserver(string arg0, vtkCommand arg1, float priority)
	{
		return vtkObject_AddObserver_02(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef), priority);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_BreakOnError_03();

	/// <summary>
	/// This method is called when vtkErrorMacro executes. It allows
	/// the debugger to break on error.
	/// </summary>
	public static void BreakOnError()
	{
		vtkObject_BreakOnError_03();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_DebugOff_04(HandleRef pThis);

	/// <summary>
	/// Turn debugging output off.
	/// </summary>
	public virtual void DebugOff()
	{
		vtkObject_DebugOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_DebugOn_05(HandleRef pThis);

	/// <summary>
	/// Turn debugging output on.
	/// </summary>
	public virtual void DebugOn()
	{
		vtkObject_DebugOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObject_GetCommand_06(HandleRef pThis, uint tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public vtkCommand GetCommand(uint tag)
	{
		vtkCommand vtkCommand2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObject_GetCommand_06(GetCppThis(), tag, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkObject_GetDebug_07(HandleRef pThis);

	/// <summary>
	/// Get the value of the debug flag.
	/// </summary>
	public bool GetDebug()
	{
		return (vtkObject_GetDebug_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_GetGlobalWarningDisplay_08();

	/// <summary>
	/// This is a global flag that controls whether any debug, warning
	/// or error messages are displayed.
	/// </summary>
	public static int GetGlobalWarningDisplay()
	{
		return vtkObject_GetGlobalWarningDisplay_08();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkObject_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// Return this object's modified time.
	/// </summary>
	public virtual ulong GetMTime()
	{
		return vtkObject_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkObject_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkObject_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkObject_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkObject_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkObject_GetObjectDescription_12(HandleRef pThis);

	/// <summary>
	/// The object description printed in messages and PrintSelf
	/// output. To be used only for reporting purposes.
	/// </summary>
	public override string GetObjectDescription()
	{
		return vtkObject_GetObjectDescription_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkObject_GetObjectName_13(HandleRef pThis);

	/// <summary>
	/// Set/get the name of this object for reporting purposes. The name appears in
	/// warning and debug messages and in the Print output. Setting the object name
	/// does not change the MTime and does not invoke a ModifiedEvent. Derived
	/// classes implementing copying methods are expected not to copy the ObjectName.
	/// </summary>
	public virtual string GetObjectName()
	{
		return vtkObject_GetObjectName_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_GlobalWarningDisplayOff_14();

	/// <summary>
	/// This is a global flag that controls whether any debug, warning
	/// or error messages are displayed.
	/// </summary>
	public static void GlobalWarningDisplayOff()
	{
		vtkObject_GlobalWarningDisplayOff_14();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_GlobalWarningDisplayOn_15();

	/// <summary>
	/// This is a global flag that controls whether any debug, warning
	/// or error messages are displayed.
	/// </summary>
	public static void GlobalWarningDisplayOn()
	{
		vtkObject_GlobalWarningDisplayOn_15();
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_HasObserver_16(HandleRef pThis, uint arg0, HandleRef arg1);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public int HasObserver(uint arg0, vtkCommand arg1)
	{
		return vtkObject_HasObserver_16(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_HasObserver_17(HandleRef pThis, string arg0, HandleRef arg1);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public int HasObserver(string arg0, vtkCommand arg1)
	{
		return vtkObject_HasObserver_17(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_HasObserver_18(HandleRef pThis, uint arg0);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public int HasObserver(uint arg0)
	{
		return vtkObject_HasObserver_18(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_HasObserver_19(HandleRef pThis, string arg0);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public int HasObserver(string arg0)
	{
		return vtkObject_HasObserver_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_InvokeEvent_20(HandleRef pThis, uint arg0, IntPtr callData);

	/// <summary>
	/// This method invokes an event and return whether the event was
	/// aborted or not. If the event was aborted, the return value is 1,
	/// otherwise it is 0.
	/// </summary>
	public int InvokeEvent(uint arg0, IntPtr callData)
	{
		return vtkObject_InvokeEvent_20(GetCppThis(), arg0, callData);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_InvokeEvent_21(HandleRef pThis, string arg0, IntPtr callData);

	/// <summary>
	/// This method invokes an event and return whether the event was
	/// aborted or not. If the event was aborted, the return value is 1,
	/// otherwise it is 0.
	/// </summary>
	public int InvokeEvent(string arg0, IntPtr callData)
	{
		return vtkObject_InvokeEvent_21(GetCppThis(), arg0, callData);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_InvokeEvent_22(HandleRef pThis, uint arg0);

	/// <summary>
	/// This method invokes an event and return whether the event was
	/// aborted or not. If the event was aborted, the return value is 1,
	/// otherwise it is 0.
	/// </summary>
	public int InvokeEvent(uint arg0)
	{
		return vtkObject_InvokeEvent_22(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_InvokeEvent_23(HandleRef pThis, string arg0);

	/// <summary>
	/// This method invokes an event and return whether the event was
	/// aborted or not. If the event was aborted, the return value is 1,
	/// otherwise it is 0.
	/// </summary>
	public int InvokeEvent(string arg0)
	{
		return vtkObject_InvokeEvent_23(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkObject_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkObject_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkObject_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_Modified_26(HandleRef pThis);

	/// <summary>
	/// Update the modification time for this object. Many filters rely on
	/// the modification time to determine if they need to recompute their
	/// data. The modification time is a unique monotonically increasing
	/// unsigned long integer.
	/// </summary>
	public virtual void Modified()
	{
		vtkObject_Modified_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObject_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkObject NewInstance()
	{
		vtkObject result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObject_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_RemoveAllObservers_29(HandleRef pThis);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public void RemoveAllObservers()
	{
		vtkObject_RemoveAllObservers_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_RemoveObserver_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public void RemoveObserver(vtkCommand arg0)
	{
		vtkObject_RemoveObserver_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_RemoveObserver_31(HandleRef pThis, uint tag);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public void RemoveObserver(uint tag)
	{
		vtkObject_RemoveObserver_31(GetCppThis(), tag);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_RemoveObservers_32(HandleRef pThis, uint arg0, HandleRef arg1);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public void RemoveObservers(uint arg0, vtkCommand arg1)
	{
		vtkObject_RemoveObservers_32(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_RemoveObservers_33(HandleRef pThis, string arg0, HandleRef arg1);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public void RemoveObservers(string arg0, vtkCommand arg1)
	{
		vtkObject_RemoveObservers_33(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_RemoveObservers_34(HandleRef pThis, uint arg0);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public void RemoveObservers(uint arg0)
	{
		vtkObject_RemoveObservers_34(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_RemoveObservers_35(HandleRef pThis, string arg0);

	/// <summary>
	/// Allow people to add/remove/invoke observers (callbacks) to any VTK
	/// object.  This is an implementation of the subject/observer design
	/// pattern. An observer is added by specifying an event to respond to
	/// and a vtkCommand to execute. It returns an unsigned long tag which
	/// can be used later to remove the event or retrieve the command.
	/// When events are invoked, the observers are called in the order they
	/// were added. If a priority value is specified, then the higher
	/// priority commands are called first. A command may set an abort
	/// flag to stop processing of the event. (See vtkCommand.h for more
	/// information.)
	/// </summary>
	public void RemoveObservers(string arg0)
	{
		vtkObject_RemoveObservers_35(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkObject_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkObject SafeDownCast(vtkObjectBase o)
	{
		vtkObject vtkObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkObject_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObject2 = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObject2.Register(null);
			}
		}
		return vtkObject2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_SetDebug_37(HandleRef pThis, byte debugFlag);

	/// <summary>
	/// Set the value of the debug flag. A true value turns debugging on.
	/// </summary>
	public void SetDebug(bool debugFlag)
	{
		vtkObject_SetDebug_37(GetCppThis(), (byte)(debugFlag ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_SetGlobalWarningDisplay_38(int val);

	/// <summary>
	/// This is a global flag that controls whether any debug, warning
	/// or error messages are displayed.
	/// </summary>
	public static void SetGlobalWarningDisplay(int val)
	{
		vtkObject_SetGlobalWarningDisplay_38(val);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkObject_SetObjectName_39(HandleRef pThis, string objectName);

	/// <summary>
	/// Set/get the name of this object for reporting purposes. The name appears in
	/// warning and debug messages and in the Print output. Setting the object name
	/// does not change the MTime and does not invoke a ModifiedEvent. Derived
	/// classes implementing copying methods are expected not to copy the ObjectName.
	/// </summary>
	public virtual void SetObjectName(string objectName)
	{
		vtkObject_SetObjectName_39(GetCppThis(), objectName);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern string vtkObject_Print(HandleRef pThis);

	/// <summary>
	/// Returns the result of calling vtkObject::Print as a C# string.
	/// </summary>
	public override string ToString()
	{
		return vtkObject_Print(GetCppThis());
	}

	/// <summary>
	/// Call RemoveAllHandlers on each non-null vtkObjectEventRelay.
	/// TODO: This method needs to get called by the generated Dispose.
	/// Make that happen...
	/// </summary>
	public void RemoveAllHandlersForAllEvents()
	{
		if (null != AbortCheckEvtRelay)
		{
			AbortCheckEvtRelay.RemoveAllHandlers();
			AbortCheckEvtRelay = null;
		}
		if (null != ActiveCameraEvtRelay)
		{
			ActiveCameraEvtRelay.RemoveAllHandlers();
			ActiveCameraEvtRelay = null;
		}
		if (null != AnimationCueTickEvtRelay)
		{
			AnimationCueTickEvtRelay.RemoveAllHandlers();
			AnimationCueTickEvtRelay = null;
		}
		if (null != AnnotationChangedEvtRelay)
		{
			AnnotationChangedEvtRelay.RemoveAllHandlers();
			AnnotationChangedEvtRelay = null;
		}
		if (null != AnyEvtRelay)
		{
			AnyEvtRelay.RemoveAllHandlers();
			AnyEvtRelay = null;
		}
		if (null != Button3DEvtRelay)
		{
			Button3DEvtRelay.RemoveAllHandlers();
			Button3DEvtRelay = null;
		}
		if (null != CharEvtRelay)
		{
			CharEvtRelay.RemoveAllHandlers();
			CharEvtRelay = null;
		}
		if (null != Clip3DEvtRelay)
		{
			Clip3DEvtRelay.RemoveAllHandlers();
			Clip3DEvtRelay = null;
		}
		if (null != ComputeVisiblePropBoundsEvtRelay)
		{
			ComputeVisiblePropBoundsEvtRelay.RemoveAllHandlers();
			ComputeVisiblePropBoundsEvtRelay = null;
		}
		if (null != ConfigureEvtRelay)
		{
			ConfigureEvtRelay.RemoveAllHandlers();
			ConfigureEvtRelay = null;
		}
		if (null != ConnectionClosedEvtRelay)
		{
			ConnectionClosedEvtRelay.RemoveAllHandlers();
			ConnectionClosedEvtRelay = null;
		}
		if (null != ConnectionCreatedEvtRelay)
		{
			ConnectionCreatedEvtRelay.RemoveAllHandlers();
			ConnectionCreatedEvtRelay = null;
		}
		if (null != CreateCameraEvtRelay)
		{
			CreateCameraEvtRelay.RemoveAllHandlers();
			CreateCameraEvtRelay = null;
		}
		if (null != CreateTimerEvtRelay)
		{
			CreateTimerEvtRelay.RemoveAllHandlers();
			CreateTimerEvtRelay = null;
		}
		if (null != CurrentChangedEvtRelay)
		{
			CurrentChangedEvtRelay.RemoveAllHandlers();
			CurrentChangedEvtRelay = null;
		}
		if (null != CursorChangedEvtRelay)
		{
			CursorChangedEvtRelay.RemoveAllHandlers();
			CursorChangedEvtRelay = null;
		}
		if (null != DeleteEvtRelay)
		{
			DeleteEvtRelay.RemoveAllHandlers();
			DeleteEvtRelay = null;
		}
		if (null != DeletePointEvtRelay)
		{
			DeletePointEvtRelay.RemoveAllHandlers();
			DeletePointEvtRelay = null;
		}
		if (null != DestroyTimerEvtRelay)
		{
			DestroyTimerEvtRelay.RemoveAllHandlers();
			DestroyTimerEvtRelay = null;
		}
		if (null != DisableEvtRelay)
		{
			DisableEvtRelay.RemoveAllHandlers();
			DisableEvtRelay = null;
		}
		if (null != DomainModifiedEvtRelay)
		{
			DomainModifiedEvtRelay.RemoveAllHandlers();
			DomainModifiedEvtRelay = null;
		}
		if (null != DropFilesEvtRelay)
		{
			DropFilesEvtRelay.RemoveAllHandlers();
			DropFilesEvtRelay = null;
		}
		if (null != EnableEvtRelay)
		{
			EnableEvtRelay.RemoveAllHandlers();
			EnableEvtRelay = null;
		}
		if (null != EndEvtRelay)
		{
			EndEvtRelay.RemoveAllHandlers();
			EndEvtRelay = null;
		}
		if (null != EndAnimationCueEvtRelay)
		{
			EndAnimationCueEvtRelay.RemoveAllHandlers();
			EndAnimationCueEvtRelay = null;
		}
		if (null != EndInteractionEvtRelay)
		{
			EndInteractionEvtRelay.RemoveAllHandlers();
			EndInteractionEvtRelay = null;
		}
		if (null != EndPanEvtRelay)
		{
			EndPanEvtRelay.RemoveAllHandlers();
			EndPanEvtRelay = null;
		}
		if (null != EndPickEvtRelay)
		{
			EndPickEvtRelay.RemoveAllHandlers();
			EndPickEvtRelay = null;
		}
		if (null != EndPinchEvtRelay)
		{
			EndPinchEvtRelay.RemoveAllHandlers();
			EndPinchEvtRelay = null;
		}
		if (null != EndRotateEvtRelay)
		{
			EndRotateEvtRelay.RemoveAllHandlers();
			EndRotateEvtRelay = null;
		}
		if (null != EndSwipeEvtRelay)
		{
			EndSwipeEvtRelay.RemoveAllHandlers();
			EndSwipeEvtRelay = null;
		}
		if (null != EndWindowLevelEvtRelay)
		{
			EndWindowLevelEvtRelay.RemoveAllHandlers();
			EndWindowLevelEvtRelay = null;
		}
		if (null != EnterEvtRelay)
		{
			EnterEvtRelay.RemoveAllHandlers();
			EnterEvtRelay = null;
		}
		if (null != ErrorEvtRelay)
		{
			ErrorEvtRelay.RemoveAllHandlers();
			ErrorEvtRelay = null;
		}
		if (null != ExecuteInformationEvtRelay)
		{
			ExecuteInformationEvtRelay.RemoveAllHandlers();
			ExecuteInformationEvtRelay = null;
		}
		if (null != ExitEvtRelay)
		{
			ExitEvtRelay.RemoveAllHandlers();
			ExitEvtRelay = null;
		}
		if (null != ExposeEvtRelay)
		{
			ExposeEvtRelay.RemoveAllHandlers();
			ExposeEvtRelay = null;
		}
		if (null != FifthButtonPressEvtRelay)
		{
			FifthButtonPressEvtRelay.RemoveAllHandlers();
			FifthButtonPressEvtRelay = null;
		}
		if (null != FifthButtonReleaseEvtRelay)
		{
			FifthButtonReleaseEvtRelay.RemoveAllHandlers();
			FifthButtonReleaseEvtRelay = null;
		}
		if (null != FourthButtonPressEvtRelay)
		{
			FourthButtonPressEvtRelay.RemoveAllHandlers();
			FourthButtonPressEvtRelay = null;
		}
		if (null != FourthButtonReleaseEvtRelay)
		{
			FourthButtonReleaseEvtRelay.RemoveAllHandlers();
			FourthButtonReleaseEvtRelay = null;
		}
		if (null != HighlightEvtRelay)
		{
			HighlightEvtRelay.RemoveAllHandlers();
			HighlightEvtRelay = null;
		}
		if (null != HoverEvtRelay)
		{
			HoverEvtRelay.RemoveAllHandlers();
			HoverEvtRelay = null;
		}
		if (null != InteractionEvtRelay)
		{
			InteractionEvtRelay.RemoveAllHandlers();
			InteractionEvtRelay = null;
		}
		if (null != KeyPressEvtRelay)
		{
			KeyPressEvtRelay.RemoveAllHandlers();
			KeyPressEvtRelay = null;
		}
		if (null != KeyReleaseEvtRelay)
		{
			KeyReleaseEvtRelay.RemoveAllHandlers();
			KeyReleaseEvtRelay = null;
		}
		if (null != LeaveEvtRelay)
		{
			LeaveEvtRelay.RemoveAllHandlers();
			LeaveEvtRelay = null;
		}
		if (null != LeftButtonDoubleClickEvtRelay)
		{
			LeftButtonDoubleClickEvtRelay.RemoveAllHandlers();
			LeftButtonDoubleClickEvtRelay = null;
		}
		if (null != LeftButtonPressEvtRelay)
		{
			LeftButtonPressEvtRelay.RemoveAllHandlers();
			LeftButtonPressEvtRelay = null;
		}
		if (null != LeftButtonReleaseEvtRelay)
		{
			LeftButtonReleaseEvtRelay.RemoveAllHandlers();
			LeftButtonReleaseEvtRelay = null;
		}
		if (null != LoadStateEvtRelay)
		{
			LoadStateEvtRelay.RemoveAllHandlers();
			LoadStateEvtRelay = null;
		}
		if (null != LongTapEvtRelay)
		{
			LongTapEvtRelay.RemoveAllHandlers();
			LongTapEvtRelay = null;
		}
		if (null != Menu3DEvtRelay)
		{
			Menu3DEvtRelay.RemoveAllHandlers();
			Menu3DEvtRelay = null;
		}
		if (null != MessageEvtRelay)
		{
			MessageEvtRelay.RemoveAllHandlers();
			MessageEvtRelay = null;
		}
		if (null != MiddleButtonDoubleClickEvtRelay)
		{
			MiddleButtonDoubleClickEvtRelay.RemoveAllHandlers();
			MiddleButtonDoubleClickEvtRelay = null;
		}
		if (null != MiddleButtonPressEvtRelay)
		{
			MiddleButtonPressEvtRelay.RemoveAllHandlers();
			MiddleButtonPressEvtRelay = null;
		}
		if (null != MiddleButtonReleaseEvtRelay)
		{
			MiddleButtonReleaseEvtRelay.RemoveAllHandlers();
			MiddleButtonReleaseEvtRelay = null;
		}
		if (null != ModifiedEvtRelay)
		{
			ModifiedEvtRelay.RemoveAllHandlers();
			ModifiedEvtRelay = null;
		}
		if (null != MouseMoveEvtRelay)
		{
			MouseMoveEvtRelay.RemoveAllHandlers();
			MouseMoveEvtRelay = null;
		}
		if (null != MouseWheelBackwardEvtRelay)
		{
			MouseWheelBackwardEvtRelay.RemoveAllHandlers();
			MouseWheelBackwardEvtRelay = null;
		}
		if (null != MouseWheelForwardEvtRelay)
		{
			MouseWheelForwardEvtRelay.RemoveAllHandlers();
			MouseWheelForwardEvtRelay = null;
		}
		if (null != MouseWheelLeftEvtRelay)
		{
			MouseWheelLeftEvtRelay.RemoveAllHandlers();
			MouseWheelLeftEvtRelay = null;
		}
		if (null != MouseWheelRightEvtRelay)
		{
			MouseWheelRightEvtRelay.RemoveAllHandlers();
			MouseWheelRightEvtRelay = null;
		}
		if (null != Move3DEvtRelay)
		{
			Move3DEvtRelay.RemoveAllHandlers();
			Move3DEvtRelay = null;
		}
		if (null != NextPose3DEvtRelay)
		{
			NextPose3DEvtRelay.RemoveAllHandlers();
			NextPose3DEvtRelay = null;
		}
		if (null != NoEvtRelay)
		{
			NoEvtRelay.RemoveAllHandlers();
			NoEvtRelay = null;
		}
		if (null != PanEvtRelay)
		{
			PanEvtRelay.RemoveAllHandlers();
			PanEvtRelay = null;
		}
		if (null != PickEvtRelay)
		{
			PickEvtRelay.RemoveAllHandlers();
			PickEvtRelay = null;
		}
		if (null != Pick3DEvtRelay)
		{
			Pick3DEvtRelay.RemoveAllHandlers();
			Pick3DEvtRelay = null;
		}
		if (null != PinchEvtRelay)
		{
			PinchEvtRelay.RemoveAllHandlers();
			PinchEvtRelay = null;
		}
		if (null != PlacePointEvtRelay)
		{
			PlacePointEvtRelay.RemoveAllHandlers();
			PlacePointEvtRelay = null;
		}
		if (null != PlaceWidgetEvtRelay)
		{
			PlaceWidgetEvtRelay.RemoveAllHandlers();
			PlaceWidgetEvtRelay = null;
		}
		if (null != PositionProp3DEvtRelay)
		{
			PositionProp3DEvtRelay.RemoveAllHandlers();
			PositionProp3DEvtRelay = null;
		}
		if (null != ProgressEvtRelay)
		{
			ProgressEvtRelay.RemoveAllHandlers();
			ProgressEvtRelay = null;
		}
		if (null != PropertyModifiedEvtRelay)
		{
			PropertyModifiedEvtRelay.RemoveAllHandlers();
			PropertyModifiedEvtRelay = null;
		}
		if (null != RegisterEvtRelay)
		{
			RegisterEvtRelay.RemoveAllHandlers();
			RegisterEvtRelay = null;
		}
		if (null != RenderEvtRelay)
		{
			RenderEvtRelay.RemoveAllHandlers();
			RenderEvtRelay = null;
		}
		if (null != RenderWindowMessageEvtRelay)
		{
			RenderWindowMessageEvtRelay.RemoveAllHandlers();
			RenderWindowMessageEvtRelay = null;
		}
		if (null != ResetCameraEvtRelay)
		{
			ResetCameraEvtRelay.RemoveAllHandlers();
			ResetCameraEvtRelay = null;
		}
		if (null != ResetCameraClippingRangeEvtRelay)
		{
			ResetCameraClippingRangeEvtRelay.RemoveAllHandlers();
			ResetCameraClippingRangeEvtRelay = null;
		}
		if (null != ResetWindowLevelEvtRelay)
		{
			ResetWindowLevelEvtRelay.RemoveAllHandlers();
			ResetWindowLevelEvtRelay = null;
		}
		if (null != ResliceAxesChangedEvtRelay)
		{
			ResliceAxesChangedEvtRelay.RemoveAllHandlers();
			ResliceAxesChangedEvtRelay = null;
		}
		if (null != RightButtonDoubleClickEvtRelay)
		{
			RightButtonDoubleClickEvtRelay.RemoveAllHandlers();
			RightButtonDoubleClickEvtRelay = null;
		}
		if (null != RightButtonPressEvtRelay)
		{
			RightButtonPressEvtRelay.RemoveAllHandlers();
			RightButtonPressEvtRelay = null;
		}
		if (null != RightButtonReleaseEvtRelay)
		{
			RightButtonReleaseEvtRelay.RemoveAllHandlers();
			RightButtonReleaseEvtRelay = null;
		}
		if (null != RotateEvtRelay)
		{
			RotateEvtRelay.RemoveAllHandlers();
			RotateEvtRelay = null;
		}
		if (null != SaveStateEvtRelay)
		{
			SaveStateEvtRelay.RemoveAllHandlers();
			SaveStateEvtRelay = null;
		}
		if (null != Select3DEvtRelay)
		{
			Select3DEvtRelay.RemoveAllHandlers();
			Select3DEvtRelay = null;
		}
		if (null != SelectionChangedEvtRelay)
		{
			SelectionChangedEvtRelay.RemoveAllHandlers();
			SelectionChangedEvtRelay = null;
		}
		if (null != SetOutputEvtRelay)
		{
			SetOutputEvtRelay.RemoveAllHandlers();
			SetOutputEvtRelay = null;
		}
		if (null != StartEvtRelay)
		{
			StartEvtRelay.RemoveAllHandlers();
			StartEvtRelay = null;
		}
		if (null != StartAnimationCueEvtRelay)
		{
			StartAnimationCueEvtRelay.RemoveAllHandlers();
			StartAnimationCueEvtRelay = null;
		}
		if (null != StartInteractionEvtRelay)
		{
			StartInteractionEvtRelay.RemoveAllHandlers();
			StartInteractionEvtRelay = null;
		}
		if (null != StartPanEvtRelay)
		{
			StartPanEvtRelay.RemoveAllHandlers();
			StartPanEvtRelay = null;
		}
		if (null != StartPickEvtRelay)
		{
			StartPickEvtRelay.RemoveAllHandlers();
			StartPickEvtRelay = null;
		}
		if (null != StartPinchEvtRelay)
		{
			StartPinchEvtRelay.RemoveAllHandlers();
			StartPinchEvtRelay = null;
		}
		if (null != StartRotateEvtRelay)
		{
			StartRotateEvtRelay.RemoveAllHandlers();
			StartRotateEvtRelay = null;
		}
		if (null != StartSwipeEvtRelay)
		{
			StartSwipeEvtRelay.RemoveAllHandlers();
			StartSwipeEvtRelay = null;
		}
		if (null != StartWindowLevelEvtRelay)
		{
			StartWindowLevelEvtRelay.RemoveAllHandlers();
			StartWindowLevelEvtRelay = null;
		}
		if (null != StateChangedEvtRelay)
		{
			StateChangedEvtRelay.RemoveAllHandlers();
			StateChangedEvtRelay = null;
		}
		if (null != SwipeEvtRelay)
		{
			SwipeEvtRelay.RemoveAllHandlers();
			SwipeEvtRelay = null;
		}
		if (null != TapEvtRelay)
		{
			TapEvtRelay.RemoveAllHandlers();
			TapEvtRelay = null;
		}
		if (null != TDxButtonPressEvtRelay)
		{
			TDxButtonPressEvtRelay.RemoveAllHandlers();
			TDxButtonPressEvtRelay = null;
		}
		if (null != TDxButtonReleaseEvtRelay)
		{
			TDxButtonReleaseEvtRelay.RemoveAllHandlers();
			TDxButtonReleaseEvtRelay = null;
		}
		if (null != TDxMotionEvtRelay)
		{
			TDxMotionEvtRelay.RemoveAllHandlers();
			TDxMotionEvtRelay = null;
		}
		if (null != TextEvtRelay)
		{
			TextEvtRelay.RemoveAllHandlers();
			TextEvtRelay = null;
		}
		if (null != TimerEvtRelay)
		{
			TimerEvtRelay.RemoveAllHandlers();
			TimerEvtRelay = null;
		}
		if (null != UncheckedPropertyModifiedEvtRelay)
		{
			UncheckedPropertyModifiedEvtRelay.RemoveAllHandlers();
			UncheckedPropertyModifiedEvtRelay = null;
		}
		if (null != UnRegisterEvtRelay)
		{
			UnRegisterEvtRelay.RemoveAllHandlers();
			UnRegisterEvtRelay = null;
		}
		if (null != UpdateEvtRelay)
		{
			UpdateEvtRelay.RemoveAllHandlers();
			UpdateEvtRelay = null;
		}
		if (null != UpdateDataEvtRelay)
		{
			UpdateDataEvtRelay.RemoveAllHandlers();
			UpdateDataEvtRelay = null;
		}
		if (null != UpdateDropLocationEvtRelay)
		{
			UpdateDropLocationEvtRelay.RemoveAllHandlers();
			UpdateDropLocationEvtRelay = null;
		}
		if (null != UpdateInformationEvtRelay)
		{
			UpdateInformationEvtRelay.RemoveAllHandlers();
			UpdateInformationEvtRelay = null;
		}
		if (null != UpdatePropertyEvtRelay)
		{
			UpdatePropertyEvtRelay.RemoveAllHandlers();
			UpdatePropertyEvtRelay = null;
		}
		if (null != UpdateShaderEvtRelay)
		{
			UpdateShaderEvtRelay.RemoveAllHandlers();
			UpdateShaderEvtRelay = null;
		}
		if (null != UserEvtRelay)
		{
			UserEvtRelay.RemoveAllHandlers();
			UserEvtRelay = null;
		}
		if (null != ViewerMovement3DEvtRelay)
		{
			ViewerMovement3DEvtRelay.RemoveAllHandlers();
			ViewerMovement3DEvtRelay = null;
		}
		if (null != ViewProgressEvtRelay)
		{
			ViewProgressEvtRelay.RemoveAllHandlers();
			ViewProgressEvtRelay = null;
		}
		if (null != VolumeMapperComputeGradientsEndEvtRelay)
		{
			VolumeMapperComputeGradientsEndEvtRelay.RemoveAllHandlers();
			VolumeMapperComputeGradientsEndEvtRelay = null;
		}
		if (null != VolumeMapperComputeGradientsProgressEvtRelay)
		{
			VolumeMapperComputeGradientsProgressEvtRelay.RemoveAllHandlers();
			VolumeMapperComputeGradientsProgressEvtRelay = null;
		}
		if (null != VolumeMapperComputeGradientsStartEvtRelay)
		{
			VolumeMapperComputeGradientsStartEvtRelay.RemoveAllHandlers();
			VolumeMapperComputeGradientsStartEvtRelay = null;
		}
		if (null != VolumeMapperRenderEndEvtRelay)
		{
			VolumeMapperRenderEndEvtRelay.RemoveAllHandlers();
			VolumeMapperRenderEndEvtRelay = null;
		}
		if (null != VolumeMapperRenderProgressEvtRelay)
		{
			VolumeMapperRenderProgressEvtRelay.RemoveAllHandlers();
			VolumeMapperRenderProgressEvtRelay = null;
		}
		if (null != VolumeMapperRenderStartEvtRelay)
		{
			VolumeMapperRenderStartEvtRelay.RemoveAllHandlers();
			VolumeMapperRenderStartEvtRelay = null;
		}
		if (null != WarningEvtRelay)
		{
			WarningEvtRelay.RemoveAllHandlers();
			WarningEvtRelay = null;
		}
		if (null != WidgetActivateEvtRelay)
		{
			WidgetActivateEvtRelay.RemoveAllHandlers();
			WidgetActivateEvtRelay = null;
		}
		if (null != WidgetModifiedEvtRelay)
		{
			WidgetModifiedEvtRelay.RemoveAllHandlers();
			WidgetModifiedEvtRelay = null;
		}
		if (null != WidgetValueChangedEvtRelay)
		{
			WidgetValueChangedEvtRelay.RemoveAllHandlers();
			WidgetValueChangedEvtRelay = null;
		}
		if (null != WindowFrameEvtRelay)
		{
			WindowFrameEvtRelay.RemoveAllHandlers();
			WindowFrameEvtRelay = null;
		}
		if (null != WindowIsCurrentEvtRelay)
		{
			WindowIsCurrentEvtRelay.RemoveAllHandlers();
			WindowIsCurrentEvtRelay = null;
		}
		if (null != WindowIsDirectEvtRelay)
		{
			WindowIsDirectEvtRelay.RemoveAllHandlers();
			WindowIsDirectEvtRelay = null;
		}
		if (null != WindowLevelEvtRelay)
		{
			WindowLevelEvtRelay.RemoveAllHandlers();
			WindowLevelEvtRelay = null;
		}
		if (null != WindowMakeCurrentEvtRelay)
		{
			WindowMakeCurrentEvtRelay.RemoveAllHandlers();
			WindowMakeCurrentEvtRelay = null;
		}
		if (null != WindowResizeEvtRelay)
		{
			WindowResizeEvtRelay.RemoveAllHandlers();
			WindowResizeEvtRelay = null;
		}
		if (null != WindowStereoTypeChangedEvtRelay)
		{
			WindowStereoTypeChangedEvtRelay.RemoveAllHandlers();
			WindowStereoTypeChangedEvtRelay = null;
		}
		if (null != WindowSupportsOpenGLEvtRelay)
		{
			WindowSupportsOpenGLEvtRelay.RemoveAllHandlers();
			WindowSupportsOpenGLEvtRelay = null;
		}
		if (null != WrongTagEvtRelay)
		{
			WrongTagEvtRelay.RemoveAllHandlers();
			WrongTagEvtRelay = null;
		}
	}
}
