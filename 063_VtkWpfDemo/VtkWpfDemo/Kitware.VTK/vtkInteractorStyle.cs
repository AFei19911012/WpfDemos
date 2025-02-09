using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyle
/// </summary>
/// <remarks>
///    provide event-driven interface to the rendering window (defines trackball mode)
///
/// vtkInteractorStyle is a base class implementing the majority of motion
/// control routines and defines an event driven interface to support
/// vtkRenderWindowInteractor. vtkRenderWindowInteractor implements
/// platform dependent key/mouse routing and timer control, which forwards
/// events in a neutral form to vtkInteractorStyle.
///
/// vtkInteractorStyle implements the "joystick" style of interaction. That
/// is, holding down the mouse keys generates a stream of events that cause
/// continuous actions (e.g., rotate, translate, pan, zoom). (The class
/// vtkInteractorStyleTrackball implements a grab and move style.) The event
/// bindings for this class include the following:
/// - Keypress j / Keypress t: toggle between joystick (position sensitive) and
/// trackball (motion sensitive) styles. In joystick style, motion occurs
/// continuously as long as a mouse button is pressed. In trackball style,
/// motion occurs when the mouse button is pressed and the mouse pointer
/// moves.
/// - Keypress c / Keypress a: toggle between camera and actor modes. In
/// camera mode, mouse events affect the camera position and focal point. In
/// actor mode, mouse events affect the actor that is under the mouse pointer.
/// - Button 1: rotate the camera around its focal point (if camera mode) or
/// rotate the actor around its origin (if actor mode). The rotation is in the
/// direction defined from the center of the renderer's viewport towards
/// the mouse position. In joystick mode, the magnitude of the rotation is
/// determined by the distance the mouse is from the center of the render
/// window.
/// - Button 2: pan the camera (if camera mode) or translate the actor (if
/// actor mode). In joystick mode, the direction of pan or translation is
/// from the center of the viewport towards the mouse position. In trackball
/// mode, the direction of motion is the direction the mouse moves. (Note:
/// with 2-button mice, pan is defined as \&lt;Shift\&gt;-Button 1.)
/// - Button 3: zoom the camera (if camera mode) or scale the actor (if
/// actor mode). Zoom in/increase scale if the mouse position is in the top
/// half of the viewport; zoom out/decrease scale if the mouse position is in
/// the bottom half. In joystick mode, the amount of zoom is controlled by the
/// distance of the mouse pointer from the horizontal centerline of the
/// window.
/// - Keypress 3: toggle the render window into and out of stereo mode. By
/// default, red-blue stereo pairs are created. Some systems support Crystal
/// Eyes LCD stereo glasses; you have to invoke SetStereoTypeToCrystalEyes()
/// on the rendering window.
/// - Keypress e: exit the application.
/// - Keypress f: fly to the picked point
/// - Keypress p: perform a pick operation. The render window interactor has
/// an internal instance of vtkCellPicker that it uses to pick.
/// - Keypress r: reset the camera view along the current view
/// direction. Centers the actors and moves the camera so that all actors are
/// visible.
/// - Keypress s: modify the representation of all actors so that they are
/// surfaces.
/// - Keypress u: invoke the user-defined function. Typically,
/// this keypress will bring up an interactor that you can type commands in.
/// Typing u calls UserCallBack() on the vtkRenderWindowInteractor, which
/// invokes a vtkCommand::UserEvent. In other words, to define a user-defined
/// callback, just add an observer to the vtkCommand::UserEvent on the
/// vtkRenderWindowInteractor object.
/// - Keypress w: modify the representation of all actors so that they are
/// wireframe.
///
/// vtkInteractorStyle can be subclassed to provide new interaction styles and
/// a facility to override any of the default mouse/key operations which
/// currently handle trackball or joystick styles is provided. Note that this
/// class will fire a variety of events that can be watched using an observer,
/// such as LeftButtonPressEvent, LeftButtonReleaseEvent,
/// MiddleButtonPressEvent, MiddleButtonReleaseEvent, RightButtonPressEvent,
/// RightButtonReleaseEvent, EnterEvent, LeaveEvent, KeyPressEvent,
/// KeyReleaseEvent, CharEvent, ExposeEvent, ConfigureEvent, TimerEvent,
/// MouseMoveEvent,
///
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyleTrackball
/// </seealso>
public class vtkInteractorStyle : vtkInteractorObserver
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyle";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyle()
	{
		MRClassNameKey = "class vtkInteractorStyle";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyle"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
	/// parent. This class should not normally be instantiated by application
	/// programmers.
	/// </summary>
	public new static vtkInteractorStyle New()
	{
		vtkInteractorStyle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
	/// parent. This class should not normally be instantiated by application
	/// programmers.
	/// </summary>
	public vtkInteractorStyle()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_AutoAdjustCameraClippingRangeOff_01(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustCameraClippingRange is on, then before each render the
	/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
	/// will still occur if objects in the scene are behind the camera or
	/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
	/// will be made per render, but the camera clipping range will still
	/// be reset when the camera is reset.
	/// </summary>
	public virtual void AutoAdjustCameraClippingRangeOff()
	{
		vtkInteractorStyle_AutoAdjustCameraClippingRangeOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_AutoAdjustCameraClippingRangeOn_02(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustCameraClippingRange is on, then before each render the
	/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
	/// will still occur if objects in the scene are behind the camera or
	/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
	/// will be made per render, but the camera clipping range will still
	/// be reset when the camera is reset.
	/// </summary>
	public virtual void AutoAdjustCameraClippingRangeOn()
	{
		vtkInteractorStyle_AutoAdjustCameraClippingRangeOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_DelegateTDxEvent_03(HandleRef pThis, uint arg0, IntPtr calldata);

	/// <summary>
	/// Called by the callback to process 3DConnexion device events.
	/// </summary>
	public void DelegateTDxEvent(uint arg0, IntPtr calldata)
	{
		vtkInteractorStyle_DelegateTDxEvent_03(GetCppThis(), arg0, calldata);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_Dolly_04(HandleRef pThis);

	/// <summary>
	/// These methods for the different interactions in different modes
	/// are overridden in subclasses to perform the correct motion. Since
	/// they might be called from OnTimer, they do not have mouse coord parameters
	/// (use interactor's GetEventPosition and GetLastEventPosition)
	/// </summary>
	public virtual void Dolly()
	{
		vtkInteractorStyle_Dolly_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndDolly_05(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndDolly()
	{
		vtkInteractorStyle_EndDolly_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndEnvRotate_06(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndEnvRotate()
	{
		vtkInteractorStyle_EndEnvRotate_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndGesture_07(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndGesture()
	{
		vtkInteractorStyle_EndGesture_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndPan_08(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndPan()
	{
		vtkInteractorStyle_EndPan_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndRotate_09(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndRotate()
	{
		vtkInteractorStyle_EndRotate_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndSpin_10(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndSpin()
	{
		vtkInteractorStyle_EndSpin_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndTimer_11(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndTimer()
	{
		vtkInteractorStyle_EndTimer_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndTwoPointer_12(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndTwoPointer()
	{
		vtkInteractorStyle_EndTwoPointer_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndUniformScale_13(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndUniformScale()
	{
		vtkInteractorStyle_EndUniformScale_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EndZoom_14(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void EndZoom()
	{
		vtkInteractorStyle_EndZoom_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_EnvironmentRotate_15(HandleRef pThis);

	/// <summary>
	/// These methods for the different interactions in different modes
	/// are overridden in subclasses to perform the correct motion. Since
	/// they might be called from OnTimer, they do not have mouse coord parameters
	/// (use interactor's GetEventPosition and GetLastEventPosition)
	/// </summary>
	public virtual void EnvironmentRotate()
	{
		vtkInteractorStyle_EnvironmentRotate_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_FindPokedRenderer_16(HandleRef pThis, int arg0, int arg1);

	/// <summary>
	/// When an event occurs, we must determine which Renderer the event
	/// occurred within, since one RenderWindow may contain multiple
	/// renderers.
	/// </summary>
	public void FindPokedRenderer(int arg0, int arg1)
	{
		vtkInteractorStyle_FindPokedRenderer_16(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRange_17(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustCameraClippingRange is on, then before each render the
	/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
	/// will still occur if objects in the scene are behind the camera or
	/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
	/// will be made per render, but the camera clipping range will still
	/// be reset when the camera is reset.
	/// </summary>
	public virtual int GetAutoAdjustCameraClippingRange()
	{
		return vtkInteractorStyle_GetAutoAdjustCameraClippingRange_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMaxValue_18(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustCameraClippingRange is on, then before each render the
	/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
	/// will still occur if objects in the scene are behind the camera or
	/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
	/// will be made per render, but the camera clipping range will still
	/// be reset when the camera is reset.
	/// </summary>
	public virtual int GetAutoAdjustCameraClippingRangeMaxValue()
	{
		return vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMinValue_19(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustCameraClippingRange is on, then before each render the
	/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
	/// will still occur if objects in the scene are behind the camera or
	/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
	/// will be made per render, but the camera clipping range will still
	/// be reset when the camera is reset.
	/// </summary>
	public virtual int GetAutoAdjustCameraClippingRangeMinValue()
	{
		return vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle_GetHandleObservers_20(HandleRef pThis);

	/// <summary>
	/// Does ProcessEvents handle observers on this class or not
	/// </summary>
	public virtual int GetHandleObservers()
	{
		return vtkInteractorStyle_GetHandleObservers_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkInteractorStyle_GetMouseWheelMotionFactor_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the mouse wheel motion factor. Default to 1.0. Set it to a
	/// different value to emphasize or de-emphasize the action triggered by
	/// mouse wheel motion.
	/// </summary>
	public virtual double GetMouseWheelMotionFactor()
	{
		return vtkInteractorStyle_GetMouseWheelMotionFactor_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyle_GetNumberOfGenerationsFromBase_22(HandleRef pThis, string type);

	/// <summary>
	/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
	/// parent. This class should not normally be instantiated by application
	/// programmers.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyle_GetNumberOfGenerationsFromBase_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyle_GetNumberOfGenerationsFromBaseType_23(string type);

	/// <summary>
	/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
	/// parent. This class should not normally be instantiated by application
	/// programmers.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyle_GetNumberOfGenerationsFromBaseType_23(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle_GetPickColor_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the pick color (used by default to color vtkActor2D's).
	/// The color is expressed as red/green/blue values between (0.0,1.0).
	/// </summary>
	public virtual double[] GetPickColor()
	{
		IntPtr intPtr = vtkInteractorStyle_GetPickColor_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_GetPickColor_25(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the pick color (used by default to color vtkActor2D's).
	/// The color is expressed as red/green/blue values between (0.0,1.0).
	/// </summary>
	public virtual void GetPickColor(IntPtr data)
	{
		vtkInteractorStyle_GetPickColor_25(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle_GetState_26(HandleRef pThis);

	/// <summary>
	/// Some useful information for interaction
	/// </summary>
	public virtual int GetState()
	{
		return vtkInteractorStyle_GetState_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle_GetTDxStyle_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// 3Dconnexion device interactor style. Initial value is a pointer to an
	/// object of class vtkTdxInteractorStyleCamera.
	/// </summary>
	public virtual vtkTDxInteractorStyle GetTDxStyle()
	{
		vtkTDxInteractorStyle vtkTDxInteractorStyle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyle_GetTDxStyle_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTDxInteractorStyle2 = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTDxInteractorStyle2.Register(null);
			}
		}
		return vtkTDxInteractorStyle2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkInteractorStyle_GetTimerDuration_28(HandleRef pThis);

	/// <summary>
	/// If using timers, specify the default timer interval (in
	/// milliseconds). Care must be taken when adjusting the timer interval from
	/// the default value of 10 milliseconds--it may adversely affect the
	/// interactors.
	/// </summary>
	public virtual uint GetTimerDuration()
	{
		return vtkInteractorStyle_GetTimerDuration_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkInteractorStyle_GetTimerDurationMaxValue_29(HandleRef pThis);

	/// <summary>
	/// If using timers, specify the default timer interval (in
	/// milliseconds). Care must be taken when adjusting the timer interval from
	/// the default value of 10 milliseconds--it may adversely affect the
	/// interactors.
	/// </summary>
	public virtual uint GetTimerDurationMaxValue()
	{
		return vtkInteractorStyle_GetTimerDurationMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkInteractorStyle_GetTimerDurationMinValue_30(HandleRef pThis);

	/// <summary>
	/// If using timers, specify the default timer interval (in
	/// milliseconds). Care must be taken when adjusting the timer interval from
	/// the default value of 10 milliseconds--it may adversely affect the
	/// interactors.
	/// </summary>
	public virtual uint GetTimerDurationMinValue()
	{
		return vtkInteractorStyle_GetTimerDurationMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle_GetUseTimers_31(HandleRef pThis);

	/// <summary>
	/// Set/Get timer hint
	/// </summary>
	public virtual int GetUseTimers()
	{
		return vtkInteractorStyle_GetUseTimers_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_HandleObserversOff_32(HandleRef pThis);

	/// <summary>
	/// Does ProcessEvents handle observers on this class or not
	/// </summary>
	public virtual void HandleObserversOff()
	{
		vtkInteractorStyle_HandleObserversOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_HandleObserversOn_33(HandleRef pThis);

	/// <summary>
	/// Does ProcessEvents handle observers on this class or not
	/// </summary>
	public virtual void HandleObserversOn()
	{
		vtkInteractorStyle_HandleObserversOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_HighlightActor2D_34(HandleRef pThis, HandleRef actor2D);

	/// <summary>
	/// When picking successfully selects an actor, this method highlights the
	/// picked prop appropriately. Currently this is done by placing a bounding
	/// box around a picked vtkProp3D, and using the PickColor to highlight a
	/// vtkProp2D.
	/// </summary>
	public virtual void HighlightActor2D(vtkActor2D actor2D)
	{
		vtkInteractorStyle_HighlightActor2D_34(GetCppThis(), actor2D?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_HighlightProp_35(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// When picking successfully selects an actor, this method highlights the
	/// picked prop appropriately. Currently this is done by placing a bounding
	/// box around a picked vtkProp3D, and using the PickColor to highlight a
	/// vtkProp2D.
	/// </summary>
	public virtual void HighlightProp(vtkProp prop)
	{
		vtkInteractorStyle_HighlightProp_35(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_HighlightProp3D_36(HandleRef pThis, HandleRef prop3D);

	/// <summary>
	/// When picking successfully selects an actor, this method highlights the
	/// picked prop appropriately. Currently this is done by placing a bounding
	/// box around a picked vtkProp3D, and using the PickColor to highlight a
	/// vtkProp2D.
	/// </summary>
	public virtual void HighlightProp3D(vtkProp3D prop3D)
	{
		vtkInteractorStyle_HighlightProp3D_36(GetCppThis(), prop3D?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle_IsA_37(HandleRef pThis, string type);

	/// <summary>
	/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
	/// parent. This class should not normally be instantiated by application
	/// programmers.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyle_IsA_37(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyle_IsTypeOf_38(string type);

	/// <summary>
	/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
	/// parent. This class should not normally be instantiated by application
	/// programmers.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyle_IsTypeOf_38(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
	/// parent. This class should not normally be instantiated by application
	/// programmers.
	/// </summary>
	public new vtkInteractorStyle NewInstance()
	{
		vtkInteractorStyle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyle_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnButton3D_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnButton3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnButton3D_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnChar_42(HandleRef pThis);

	/// <summary>
	/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
	/// are handled here ('q' for Quit, 'p' for Pick, etc)
	/// </summary>
	public override void OnChar()
	{
		vtkInteractorStyle_OnChar_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnClip3D_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnClip3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnClip3D_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnConfigure_44(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public virtual void OnConfigure()
	{
		vtkInteractorStyle_OnConfigure_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnDropFiles_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// When files are dropped on the render window.
	/// The argument contains the list of file paths dropped.
	/// It is called after OnDropLocation.
	/// </summary>
	public virtual void OnDropFiles(vtkStringArray arg0)
	{
		vtkInteractorStyle_OnDropFiles_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnDropLocation_46(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// When the mouse location is updated while dragging files.
	/// The argument contains the position relative to the window of the mouse
	/// where the files are dropped.
	/// It is called before OnDropFiles.
	/// </summary>
	public virtual void OnDropLocation(IntPtr arg0)
	{
		vtkInteractorStyle_OnDropLocation_46(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnElevation3D_47(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnElevation3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnElevation3D_47(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnEndPan_48(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnEndPan()
	{
		vtkInteractorStyle_OnEndPan_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnEndPinch_49(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnEndPinch()
	{
		vtkInteractorStyle_OnEndPinch_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnEndRotate_50(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnEndRotate()
	{
		vtkInteractorStyle_OnEndRotate_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnEndSwipe_51(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnEndSwipe()
	{
		vtkInteractorStyle_OnEndSwipe_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnEnter_52(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public virtual void OnEnter()
	{
		vtkInteractorStyle_OnEnter_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnExpose_53(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public virtual void OnExpose()
	{
		vtkInteractorStyle_OnExpose_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnFifthButtonDown_54(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnFifthButtonDown()
	{
		vtkInteractorStyle_OnFifthButtonDown_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnFifthButtonUp_55(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnFifthButtonUp()
	{
		vtkInteractorStyle_OnFifthButtonUp_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnFourthButtonDown_56(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnFourthButtonDown()
	{
		vtkInteractorStyle_OnFourthButtonDown_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnFourthButtonUp_57(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnFourthButtonUp()
	{
		vtkInteractorStyle_OnFourthButtonUp_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnKeyDown_58(HandleRef pThis);

	/// <summary>
	/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
	/// are handled here ('q' for Quit, 'p' for Pick, etc)
	/// </summary>
	public virtual void OnKeyDown()
	{
		vtkInteractorStyle_OnKeyDown_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnKeyPress_59(HandleRef pThis);

	/// <summary>
	/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
	/// are handled here ('q' for Quit, 'p' for Pick, etc)
	/// </summary>
	public virtual void OnKeyPress()
	{
		vtkInteractorStyle_OnKeyPress_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnKeyRelease_60(HandleRef pThis);

	/// <summary>
	/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
	/// are handled here ('q' for Quit, 'p' for Pick, etc)
	/// </summary>
	public virtual void OnKeyRelease()
	{
		vtkInteractorStyle_OnKeyRelease_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnKeyUp_61(HandleRef pThis);

	/// <summary>
	/// OnChar is triggered when an ASCII key is pressed. Some basic key presses
	/// are handled here ('q' for Quit, 'p' for Pick, etc)
	/// </summary>
	public virtual void OnKeyUp()
	{
		vtkInteractorStyle_OnKeyUp_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnLeave_62(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public virtual void OnLeave()
	{
		vtkInteractorStyle_OnLeave_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnLeftButtonDoubleClick_63(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnLeftButtonDoubleClick()
	{
		vtkInteractorStyle_OnLeftButtonDoubleClick_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnLeftButtonDown_64(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnLeftButtonDown()
	{
		vtkInteractorStyle_OnLeftButtonDown_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnLeftButtonUp_65(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnLeftButtonUp()
	{
		vtkInteractorStyle_OnLeftButtonUp_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnLongTap_66(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnLongTap()
	{
		vtkInteractorStyle_OnLongTap_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMenu3D_67(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMenu3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnMenu3D_67(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMiddleButtonDoubleClick_68(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMiddleButtonDoubleClick()
	{
		vtkInteractorStyle_OnMiddleButtonDoubleClick_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMiddleButtonDown_69(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMiddleButtonDown()
	{
		vtkInteractorStyle_OnMiddleButtonDown_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMiddleButtonUp_70(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMiddleButtonUp()
	{
		vtkInteractorStyle_OnMiddleButtonUp_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMouseMove_71(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMouseMove()
	{
		vtkInteractorStyle_OnMouseMove_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMouseWheelBackward_72(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMouseWheelBackward()
	{
		vtkInteractorStyle_OnMouseWheelBackward_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMouseWheelForward_73(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMouseWheelForward()
	{
		vtkInteractorStyle_OnMouseWheelForward_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMouseWheelLeft_74(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMouseWheelLeft()
	{
		vtkInteractorStyle_OnMouseWheelLeft_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMouseWheelRight_75(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMouseWheelRight()
	{
		vtkInteractorStyle_OnMouseWheelRight_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnMove3D_76(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnMove3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnMove3D_76(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnNextPose3D_77(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnNextPose3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnNextPose3D_77(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnPan_78(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnPan()
	{
		vtkInteractorStyle_OnPan_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnPick3D_79(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnPick3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnPick3D_79(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnPinch_80(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnPinch()
	{
		vtkInteractorStyle_OnPinch_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnPositionProp3D_81(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnPositionProp3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnPositionProp3D_81(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnRightButtonDoubleClick_82(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnRightButtonDoubleClick()
	{
		vtkInteractorStyle_OnRightButtonDoubleClick_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnRightButtonDown_83(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnRightButtonDown()
	{
		vtkInteractorStyle_OnRightButtonDown_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnRightButtonUp_84(HandleRef pThis);

	/// <summary>
	/// Generic event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnRightButtonUp()
	{
		vtkInteractorStyle_OnRightButtonUp_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnRotate_85(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnRotate()
	{
		vtkInteractorStyle_OnRotate_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnSelect3D_86(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnSelect3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnSelect3D_86(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnStartPan_87(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnStartPan()
	{
		vtkInteractorStyle_OnStartPan_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnStartPinch_88(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnStartPinch()
	{
		vtkInteractorStyle_OnStartPinch_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnStartRotate_89(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnStartRotate()
	{
		vtkInteractorStyle_OnStartRotate_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnStartSwipe_90(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnStartSwipe()
	{
		vtkInteractorStyle_OnStartSwipe_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnSwipe_91(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnSwipe()
	{
		vtkInteractorStyle_OnSwipe_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnTap_92(HandleRef pThis);

	/// <summary>
	/// gesture based events
	/// </summary>
	public virtual void OnTap()
	{
		vtkInteractorStyle_OnTap_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnTimer_93(HandleRef pThis);

	/// <summary>
	/// OnTimer calls Rotate, Rotate etc which should be overridden by
	/// style subclasses.
	/// </summary>
	public virtual void OnTimer()
	{
		vtkInteractorStyle_OnTimer_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_OnViewerMovement3D_94(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Generic 3D event bindings can be overridden in subclasses
	/// </summary>
	public virtual void OnViewerMovement3D(vtkEventData arg0)
	{
		vtkInteractorStyle_OnViewerMovement3D_94(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_Pan_95(HandleRef pThis);

	/// <summary>
	/// These methods for the different interactions in different modes
	/// are overridden in subclasses to perform the correct motion. Since
	/// they might be called from OnTimer, they do not have mouse coord parameters
	/// (use interactor's GetEventPosition and GetLastEventPosition)
	/// </summary>
	public virtual void Pan()
	{
		vtkInteractorStyle_Pan_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_Rotate_96(HandleRef pThis);

	/// <summary>
	/// These methods for the different interactions in different modes
	/// are overridden in subclasses to perform the correct motion. Since
	/// they might be called from OnTimer, they do not have mouse coord parameters
	/// (use interactor's GetEventPosition and GetLastEventPosition)
	/// </summary>
	public virtual void Rotate()
	{
		vtkInteractorStyle_Rotate_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyle_SafeDownCast_97(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This class must be supplied with a vtkRenderWindowInteractor wrapper or
	/// parent. This class should not normally be instantiated by application
	/// programmers.
	/// </summary>
	public new static vtkInteractorStyle SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyle vtkInteractorStyle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyle_SafeDownCast_97(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyle2 = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyle2.Register(null);
			}
		}
		return vtkInteractorStyle2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetAutoAdjustCameraClippingRange_98(HandleRef pThis, int _arg);

	/// <summary>
	/// If AutoAdjustCameraClippingRange is on, then before each render the
	/// camera clipping range will be adjusted to "fit" the whole scene. Clipping
	/// will still occur if objects in the scene are behind the camera or
	/// come very close. If AutoAdjustCameraClippingRange is off, no adjustment
	/// will be made per render, but the camera clipping range will still
	/// be reset when the camera is reset.
	/// </summary>
	public virtual void SetAutoAdjustCameraClippingRange(int _arg)
	{
		vtkInteractorStyle_SetAutoAdjustCameraClippingRange_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetEnabled_99(HandleRef pThis, int arg0);

	/// <summary>
	/// Turn on/off this interactor. Interactor styles operate a little
	/// bit differently than other types of interactor observers. When
	/// the SetInteractor() method is invoked, the automatically enable
	/// themselves. This is a legacy requirement, and convenient for the
	/// user.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkInteractorStyle_SetEnabled_99(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetHandleObservers_100(HandleRef pThis, int _arg);

	/// <summary>
	/// Does ProcessEvents handle observers on this class or not
	/// </summary>
	public virtual void SetHandleObservers(int _arg)
	{
		vtkInteractorStyle_SetHandleObservers_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetInteractor_101(HandleRef pThis, HandleRef interactor);

	/// <summary>
	/// Set/Get the Interactor wrapper being controlled by this object.
	/// (Satisfy superclass API.)
	/// </summary>
	public override void SetInteractor(vtkRenderWindowInteractor interactor)
	{
		vtkInteractorStyle_SetInteractor_101(GetCppThis(), interactor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetMouseWheelMotionFactor_102(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the mouse wheel motion factor. Default to 1.0. Set it to a
	/// different value to emphasize or de-emphasize the action triggered by
	/// mouse wheel motion.
	/// </summary>
	public virtual void SetMouseWheelMotionFactor(double _arg)
	{
		vtkInteractorStyle_SetMouseWheelMotionFactor_102(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetPickColor_103(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the pick color (used by default to color vtkActor2D's).
	/// The color is expressed as red/green/blue values between (0.0,1.0).
	/// </summary>
	public virtual void SetPickColor(double _arg1, double _arg2, double _arg3)
	{
		vtkInteractorStyle_SetPickColor_103(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetPickColor_104(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the pick color (used by default to color vtkActor2D's).
	/// The color is expressed as red/green/blue values between (0.0,1.0).
	/// </summary>
	public virtual void SetPickColor(IntPtr _arg)
	{
		vtkInteractorStyle_SetPickColor_104(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetTDxStyle_105(HandleRef pThis, HandleRef tdxStyle);

	/// <summary>
	/// 3Dconnexion device interactor style. Initial value is a pointer to an
	/// object of class vtkTdxInteractorStyleCamera.
	/// </summary>
	public virtual void SetTDxStyle(vtkTDxInteractorStyle tdxStyle)
	{
		vtkInteractorStyle_SetTDxStyle_105(GetCppThis(), tdxStyle?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetTimerDuration_106(HandleRef pThis, uint _arg);

	/// <summary>
	/// If using timers, specify the default timer interval (in
	/// milliseconds). Care must be taken when adjusting the timer interval from
	/// the default value of 10 milliseconds--it may adversely affect the
	/// interactors.
	/// </summary>
	public virtual void SetTimerDuration(uint _arg)
	{
		vtkInteractorStyle_SetTimerDuration_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_SetUseTimers_107(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get timer hint
	/// </summary>
	public virtual void SetUseTimers(int _arg)
	{
		vtkInteractorStyle_SetUseTimers_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_Spin_108(HandleRef pThis);

	/// <summary>
	/// These methods for the different interactions in different modes
	/// are overridden in subclasses to perform the correct motion. Since
	/// they might be called from OnTimer, they do not have mouse coord parameters
	/// (use interactor's GetEventPosition and GetLastEventPosition)
	/// </summary>
	public virtual void Spin()
	{
		vtkInteractorStyle_Spin_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartAnimate_109(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartAnimate()
	{
		vtkInteractorStyle_StartAnimate_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartDolly_110(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartDolly()
	{
		vtkInteractorStyle_StartDolly_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartEnvRotate_111(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartEnvRotate()
	{
		vtkInteractorStyle_StartEnvRotate_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartGesture_112(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartGesture()
	{
		vtkInteractorStyle_StartGesture_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartPan_113(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartPan()
	{
		vtkInteractorStyle_StartPan_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartRotate_114(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartRotate()
	{
		vtkInteractorStyle_StartRotate_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartSpin_115(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartSpin()
	{
		vtkInteractorStyle_StartSpin_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartState_116(HandleRef pThis, int newstate);

	/// <summary>
	/// utility routines used by state changes
	/// </summary>
	public virtual void StartState(int newstate)
	{
		vtkInteractorStyle_StartState_116(GetCppThis(), newstate);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartTimer_117(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartTimer()
	{
		vtkInteractorStyle_StartTimer_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartTwoPointer_118(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartTwoPointer()
	{
		vtkInteractorStyle_StartTwoPointer_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartUniformScale_119(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartUniformScale()
	{
		vtkInteractorStyle_StartUniformScale_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StartZoom_120(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StartZoom()
	{
		vtkInteractorStyle_StartZoom_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StopAnimate_121(HandleRef pThis);

	/// <summary>
	/// Interaction mode entry points used internally.
	/// </summary>
	public virtual void StopAnimate()
	{
		vtkInteractorStyle_StopAnimate_121(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_StopState_122(HandleRef pThis);

	/// <summary>
	/// utility routines used by state changes
	/// </summary>
	public virtual void StopState()
	{
		vtkInteractorStyle_StopState_122(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_UniformScale_123(HandleRef pThis);

	/// <summary>
	/// These methods for the different interactions in different modes
	/// are overridden in subclasses to perform the correct motion. Since
	/// they might be called from OnTimer, they do not have mouse coord parameters
	/// (use interactor's GetEventPosition and GetLastEventPosition)
	/// </summary>
	public virtual void UniformScale()
	{
		vtkInteractorStyle_UniformScale_123(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_UseTimersOff_124(HandleRef pThis);

	/// <summary>
	/// Set/Get timer hint
	/// </summary>
	public virtual void UseTimersOff()
	{
		vtkInteractorStyle_UseTimersOff_124(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_UseTimersOn_125(HandleRef pThis);

	/// <summary>
	/// Set/Get timer hint
	/// </summary>
	public virtual void UseTimersOn()
	{
		vtkInteractorStyle_UseTimersOn_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyle_Zoom_126(HandleRef pThis);

	/// <summary>
	/// These methods for the different interactions in different modes
	/// are overridden in subclasses to perform the correct motion. Since
	/// they might be called from OnTimer, they do not have mouse coord parameters
	/// (use interactor's GetEventPosition and GetLastEventPosition)
	/// </summary>
	public virtual void Zoom()
	{
		vtkInteractorStyle_Zoom_126(GetCppThis());
	}
}
