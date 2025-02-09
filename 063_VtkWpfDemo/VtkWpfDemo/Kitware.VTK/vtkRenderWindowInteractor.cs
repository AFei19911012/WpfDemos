using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderWindowInteractor
/// </summary>
/// <remarks>
///    platform-independent render window
/// interaction including picking and frame rate control.
///
///
/// vtkRenderWindowInteractor provides a platform-independent interaction
/// mechanism for mouse/key/time events. It serves as a base class for
/// platform-dependent implementations that handle routing of mouse/key/timer
/// messages to vtkInteractorObserver and its subclasses. vtkRenderWindowInteractor
/// also provides controls for picking, rendering frame rate, and headlights.
///
/// vtkRenderWindowInteractor has changed from previous implementations and
/// now serves only as a shell to hold user preferences and route messages to
/// vtkInteractorStyle. Callbacks are available for many events.  Platform
/// specific subclasses should provide methods for manipulating timers,
/// TerminateApp, and an event loop if required via
/// Initialize/Start/Enable/Disable.
///
/// @warning
/// vtkRenderWindowInteractor routes events through VTK's command/observer
/// design pattern. That is, when vtkRenderWindowInteractor (actually, one of
/// its subclasses) sees a platform-dependent event, it translates this into
/// a VTK event using the InvokeEvent() method. Then any vtkInteractorObservers
/// registered for that event are expected to respond as appropriate.
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorObserver
/// </seealso>
public class vtkRenderWindowInteractor : vtkObject
{
	/// <summary>
	/// Get the VTK timer ID that corresponds to the supplied platform ID.
	/// </summary>
	public enum OneShotTimer_WrapperEnum
	{
		/// <summary>enum member</summary>
		OneShotTimer = 1,
		/// <summary>enum member</summary>
		RepeatingTimer
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindowInteractor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderWindowInteractor()
	{
		MRClassNameKey = "class vtkRenderWindowInteractor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindowInteractor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderWindowInteractor New()
	{
		vtkRenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRenderWindowInteractor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_UnRegister_191(HandleRef pThis, HandleRef o);

	/// <summary>
	/// This Method detects loops of RenderWindow-Interactor,
	/// so objects are freed properly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (GetCallDisposalMethod())
			{
				vtkRenderWindowInteractor_UnRegister_191(GetCppThis(), default(HandleRef));
				ClearCppThis();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_CharEvent_01(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void CharEvent()
	{
		vtkRenderWindowInteractor_CharEvent_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ClearContact_02(HandleRef pThis, ulong contactID);

	/// <summary>
	/// Most multitouch systems use persistent contact/pointer ids to
	/// track events/motion during multitouch events. We keep an array
	/// that maps these system dependent contact ids to our pointer index
	/// These functions return -1 if the ID is not found or if there
	/// is no more room for contacts
	/// </summary>
	public void ClearContact(ulong contactID)
	{
		vtkRenderWindowInteractor_ClearContact_02(GetCppThis(), contactID);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ClearPointerIndex_03(HandleRef pThis, int i);

	/// <summary>
	/// Most multitouch systems use persistent contact/pointer ids to
	/// track events/motion during multitouch events. We keep an array
	/// that maps these system dependent contact ids to our pointer index
	/// These functions return -1 if the ID is not found or if there
	/// is no more room for contacts
	/// </summary>
	public void ClearPointerIndex(int i)
	{
		vtkRenderWindowInteractor_ClearPointerIndex_03(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ConfigureEvent_04(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void ConfigureEvent()
	{
		vtkRenderWindowInteractor_ConfigureEvent_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_CreateDefaultPicker_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create default picker. Used to create one when none is specified.
	/// Default is an instance of vtkPropPicker.
	/// </summary>
	public virtual vtkAbstractPropPicker CreateDefaultPicker()
	{
		vtkAbstractPropPicker vtkAbstractPropPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_CreateDefaultPicker_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPropPicker2 = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPropPicker2.Register(null);
			}
		}
		return vtkAbstractPropPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_CreateOneShotTimer_06(HandleRef pThis, uint duration);

	/// <summary>
	/// Create a one shot timer, with the specified duration (in milliseconds).
	/// \return the timer id.
	/// </summary>
	public int CreateOneShotTimer(uint duration)
	{
		return vtkRenderWindowInteractor_CreateOneShotTimer_06(GetCppThis(), duration);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_CreateRepeatingTimer_07(HandleRef pThis, uint duration);

	/// <summary>
	/// Create a repeating timer, with the specified duration (in milliseconds).
	/// \return the timer id.
	/// </summary>
	public int CreateRepeatingTimer(uint duration)
	{
		return vtkRenderWindowInteractor_CreateRepeatingTimer_07(GetCppThis(), duration);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_CreateTimer_08(HandleRef pThis, int timerType);

	/// <summary>
	/// This class provides two groups of methods for manipulating timers.  The
	/// first group (CreateTimer(timerType) and DestroyTimer()) implicitly use
	/// an internal timer id (and are present for backward compatibility). The
	/// second group (CreateRepeatingTimer(long),CreateOneShotTimer(long),
	/// ResetTimer(int),DestroyTimer(int)) use timer ids so multiple timers can
	/// be independently managed. In the first group, the CreateTimer() method
	/// takes an argument indicating whether the timer is created the first time
	/// (timerType==VTKI_TIMER_FIRST) or whether it is being reset
	/// (timerType==VTKI_TIMER_UPDATE). (In initial implementations of VTK this
	/// was how one shot and repeating timers were managed.) In the second
	/// group, the create methods take a timer duration argument (in
	/// milliseconds) and return a timer id. Thus the ResetTimer(timerId) and
	/// DestroyTimer(timerId) methods take this timer id and operate on the
	/// timer as appropriate. Methods are also available for determining
	/// </summary>
	public virtual int CreateTimer(int timerType)
	{
		return vtkRenderWindowInteractor_CreateTimer_08(GetCppThis(), timerType);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_DestroyTimer_09(HandleRef pThis);

	/// <summary>
	/// This class provides two groups of methods for manipulating timers.  The
	/// first group (CreateTimer(timerType) and DestroyTimer()) implicitly use
	/// an internal timer id (and are present for backward compatibility). The
	/// second group (CreateRepeatingTimer(long),CreateOneShotTimer(long),
	/// ResetTimer(int),DestroyTimer(int)) use timer ids so multiple timers can
	/// be independently managed. In the first group, the CreateTimer() method
	/// takes an argument indicating whether the timer is created the first time
	/// (timerType==VTKI_TIMER_FIRST) or whether it is being reset
	/// (timerType==VTKI_TIMER_UPDATE). (In initial implementations of VTK this
	/// was how one shot and repeating timers were managed.) In the second
	/// group, the create methods take a timer duration argument (in
	/// milliseconds) and return a timer id. Thus the ResetTimer(timerId) and
	/// DestroyTimer(timerId) methods take this timer id and operate on the
	/// timer as appropriate. Methods are also available for determining
	/// </summary>
	public virtual int DestroyTimer()
	{
		return vtkRenderWindowInteractor_DestroyTimer_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_DestroyTimer_10(HandleRef pThis, int timerId);

	/// <summary>
	/// Destroy the timer specified by timerId.
	/// \return 1 if the timer was destroyed.
	/// </summary>
	public int DestroyTimer(int timerId)
	{
		return vtkRenderWindowInteractor_DestroyTimer_10(GetCppThis(), timerId);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_Disable_11(HandleRef pThis);

	/// <summary>
	/// Enable/Disable interactions.  By default interactors are enabled when
	/// initialized.  Initialize() must be called prior to enabling/disabling
	/// interaction. These methods are used when a window/widget is being
	/// shared by multiple renderers and interactors.  This allows a "modal"
	/// display where one interactor is active when its data is to be displayed
	/// and all other interactors associated with the widget are disabled
	/// when their data is not displayed.
	/// </summary>
	public virtual void Disable()
	{
		vtkRenderWindowInteractor_Disable_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_Enable_12(HandleRef pThis);

	/// <summary>
	/// Enable/Disable interactions.  By default interactors are enabled when
	/// initialized.  Initialize() must be called prior to enabling/disabling
	/// interaction. These methods are used when a window/widget is being
	/// shared by multiple renderers and interactors.  This allows a "modal"
	/// display where one interactor is active when its data is to be displayed
	/// and all other interactors associated with the widget are disabled
	/// when their data is not displayed.
	/// </summary>
	public virtual void Enable()
	{
		vtkRenderWindowInteractor_Enable_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_EnableRenderOff_13(HandleRef pThis);

	/// <summary>
	/// Enable/Disable whether vtkRenderWindowInteractor::Render() calls
	/// this-&gt;RenderWindow-&gt;Render().
	/// </summary>
	public virtual void EnableRenderOff()
	{
		vtkRenderWindowInteractor_EnableRenderOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_EnableRenderOn_14(HandleRef pThis);

	/// <summary>
	/// Enable/Disable whether vtkRenderWindowInteractor::Render() calls
	/// this-&gt;RenderWindow-&gt;Render().
	/// </summary>
	public virtual void EnableRenderOn()
	{
		vtkRenderWindowInteractor_EnableRenderOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_EndPanEvent_15(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void EndPanEvent()
	{
		vtkRenderWindowInteractor_EndPanEvent_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_EndPickCallback_16(HandleRef pThis);

	/// <summary>
	/// These methods correspond to the Exit, User and Pick
	/// callbacks. They allow for the Style to invoke them.
	/// </summary>
	public virtual void EndPickCallback()
	{
		vtkRenderWindowInteractor_EndPickCallback_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_EndPinchEvent_17(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void EndPinchEvent()
	{
		vtkRenderWindowInteractor_EndPinchEvent_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_EndRotateEvent_18(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void EndRotateEvent()
	{
		vtkRenderWindowInteractor_EndRotateEvent_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_EnterEvent_19(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void EnterEvent()
	{
		vtkRenderWindowInteractor_EnterEvent_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ExitCallback_20(HandleRef pThis);

	/// <summary>
	/// These methods correspond to the Exit, User and Pick
	/// callbacks. They allow for the Style to invoke them.
	/// </summary>
	public virtual void ExitCallback()
	{
		vtkRenderWindowInteractor_ExitCallback_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ExitEvent_21(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void ExitEvent()
	{
		vtkRenderWindowInteractor_ExitEvent_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ExposeEvent_22(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void ExposeEvent()
	{
		vtkRenderWindowInteractor_ExposeEvent_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_FifthButtonPressEvent_23(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void FifthButtonPressEvent()
	{
		vtkRenderWindowInteractor_FifthButtonPressEvent_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_FifthButtonReleaseEvent_24(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void FifthButtonReleaseEvent()
	{
		vtkRenderWindowInteractor_FifthButtonReleaseEvent_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_FindPokedRenderer_25(HandleRef pThis, int arg0, int arg1, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When an event occurs, we must determine which Renderer the event
	/// occurred within, since one RenderWindow may contain multiple
	/// renderers.
	/// </summary>
	public virtual vtkRenderer FindPokedRenderer(int arg0, int arg1)
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_FindPokedRenderer_25(GetCppThis(), arg0, arg1, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_FlyTo_26(HandleRef pThis, HandleRef ren, double x, double y, double z);

	/// <summary>
	/// Given a position x, move the current camera's focal point to x.
	/// The movement is animated over the number of frames specified in
	/// NumberOfFlyFrames. The LOD desired frame rate is used.
	/// </summary>
	public void FlyTo(vtkRenderer ren, double x, double y, double z)
	{
		vtkRenderWindowInteractor_FlyTo_26(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_FlyTo_27(HandleRef pThis, HandleRef ren, IntPtr x);

	/// <summary>
	/// Given a position x, move the current camera's focal point to x.
	/// The movement is animated over the number of frames specified in
	/// NumberOfFlyFrames. The LOD desired frame rate is used.
	/// </summary>
	public void FlyTo(vtkRenderer ren, IntPtr x)
	{
		vtkRenderWindowInteractor_FlyTo_27(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_FlyToImage_28(HandleRef pThis, HandleRef ren, double x, double y);

	/// <summary>
	/// Given a position x, move the current camera's focal point to x.
	/// The movement is animated over the number of frames specified in
	/// NumberOfFlyFrames. The LOD desired frame rate is used.
	/// </summary>
	public void FlyToImage(vtkRenderer ren, double x, double y)
	{
		vtkRenderWindowInteractor_FlyToImage_28(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_FlyToImage_29(HandleRef pThis, HandleRef ren, IntPtr x);

	/// <summary>
	/// Given a position x, move the current camera's focal point to x.
	/// The movement is animated over the number of frames specified in
	/// NumberOfFlyFrames. The LOD desired frame rate is used.
	/// </summary>
	public void FlyToImage(vtkRenderer ren, IntPtr x)
	{
		vtkRenderWindowInteractor_FlyToImage_29(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_FourthButtonPressEvent_30(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void FourthButtonPressEvent()
	{
		vtkRenderWindowInteractor_FourthButtonPressEvent_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_FourthButtonReleaseEvent_31(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void FourthButtonReleaseEvent()
	{
		vtkRenderWindowInteractor_FourthButtonReleaseEvent_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetAltKey_32(HandleRef pThis);

	/// <summary>
	/// Set/get whether alt modifier key was pressed.
	/// </summary>
	public virtual int GetAltKey()
	{
		return vtkRenderWindowInteractor_GetAltKey_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetControlKey_33(HandleRef pThis);

	/// <summary>
	/// Set/get whether control modifier key was pressed.
	/// </summary>
	public virtual int GetControlKey()
	{
		return vtkRenderWindowInteractor_GetControlKey_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRate_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired update rate. This is used by vtkLODActor's to tell
	/// them how quickly they need to render.  This update is in effect only
	/// when the camera is being rotated, or zoomed.  When the interactor is
	/// still, the StillUpdateRate is used instead.
	/// The default is 15.
	/// </summary>
	public virtual double GetDesiredUpdateRate()
	{
		return vtkRenderWindowInteractor_GetDesiredUpdateRate_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRateMaxValue_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired update rate. This is used by vtkLODActor's to tell
	/// them how quickly they need to render.  This update is in effect only
	/// when the camera is being rotated, or zoomed.  When the interactor is
	/// still, the StillUpdateRate is used instead.
	/// The default is 15.
	/// </summary>
	public virtual double GetDesiredUpdateRateMaxValue()
	{
		return vtkRenderWindowInteractor_GetDesiredUpdateRateMaxValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRateMinValue_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired update rate. This is used by vtkLODActor's to tell
	/// them how quickly they need to render.  This update is in effect only
	/// when the camera is being rotated, or zoomed.  When the interactor is
	/// still, the StillUpdateRate is used instead.
	/// The default is 15.
	/// </summary>
	public virtual double GetDesiredUpdateRateMinValue()
	{
		return vtkRenderWindowInteractor_GetDesiredUpdateRateMinValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetDolly_37(HandleRef pThis);

	/// <summary>
	/// Set the total Dolly value to use when flying to (FlyTo()) a
	/// specified point. Negative values fly away from the point.
	/// </summary>
	public virtual double GetDolly()
	{
		return vtkRenderWindowInteractor_GetDolly_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindowInteractor_GetDone_38(HandleRef pThis);

	/// <summary>
	/// Is the interactor loop done
	/// </summary>
	public virtual bool GetDone()
	{
		return (vtkRenderWindowInteractor_GetDone_38(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindowInteractor_GetEnableRender_39(HandleRef pThis);

	/// <summary>
	/// Enable/Disable whether vtkRenderWindowInteractor::Render() calls
	/// this-&gt;RenderWindow-&gt;Render().
	/// </summary>
	public virtual bool GetEnableRender()
	{
		return (vtkRenderWindowInteractor_GetEnableRender_39(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetEnabled_40(HandleRef pThis);

	/// <summary>
	/// Enable/Disable interactions.  By default interactors are enabled when
	/// initialized.  Initialize() must be called prior to enabling/disabling
	/// interaction. These methods are used when a window/widget is being
	/// shared by multiple renderers and interactors.  This allows a "modal"
	/// display where one interactor is active when its data is to be displayed
	/// and all other interactors associated with the widget are disabled
	/// when their data is not displayed.
	/// </summary>
	public virtual int GetEnabled()
	{
		return vtkRenderWindowInteractor_GetEnabled_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetEventPosition_41(HandleRef pThis);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual int[] GetEventPosition()
	{
		IntPtr intPtr = vtkRenderWindowInteractor_GetEventPosition_41(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetEventPosition_42(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void GetEventPosition(ref int _arg1, ref int _arg2)
	{
		vtkRenderWindowInteractor_GetEventPosition_42(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetEventPosition_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void GetEventPosition(IntPtr _arg)
	{
		vtkRenderWindowInteractor_GetEventPosition_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetEventPositions_44(HandleRef pThis, int pointerIndex);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual IntPtr GetEventPositions(int pointerIndex)
	{
		return vtkRenderWindowInteractor_GetEventPositions_44(GetCppThis(), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetEventSize_45(HandleRef pThis);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public virtual int[] GetEventSize()
	{
		IntPtr intPtr = vtkRenderWindowInteractor_GetEventSize_45(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetEventSize_46(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public virtual void GetEventSize(ref int _arg1, ref int _arg2)
	{
		vtkRenderWindowInteractor_GetEventSize_46(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetEventSize_47(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public virtual void GetEventSize(IntPtr _arg)
	{
		vtkRenderWindowInteractor_GetEventSize_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetHardwareWindow_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the hardware window being controlled by this object.
	/// For opengl the hardware window is not used as the opengl
	/// subclasses of RenderWindow provide the functionality.
	/// </summary>
	public virtual vtkHardwareWindow GetHardwareWindow()
	{
		vtkHardwareWindow vtkHardwareWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_GetHardwareWindow_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHardwareWindow2 = (vtkHardwareWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHardwareWindow2.Register(null);
			}
		}
		return vtkHardwareWindow2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetInitialized_49(HandleRef pThis);

	/// <summary>
	/// See whether interactor has been initialized yet.
	/// Default is 0.
	/// </summary>
	public virtual int GetInitialized()
	{
		return vtkRenderWindowInteractor_GetInitialized_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetInteractorStyle_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// External switching between joystick/trackball/new? modes. Initial value
	/// is a vtkInteractorStyleSwitch object.
	/// </summary>
	public virtual vtkInteractorObserver GetInteractorStyle()
	{
		vtkInteractorObserver vtkInteractorObserver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_GetInteractorStyle_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorObserver2 = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorObserver2.Register(null);
			}
		}
		return vtkInteractorObserver2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkRenderWindowInteractor_GetKeyCode_51(HandleRef pThis);

	/// <summary>
	/// Set/get the key code for the key that was pressed.
	/// </summary>
	public virtual sbyte GetKeyCode()
	{
		return vtkRenderWindowInteractor_GetKeyCode_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetKeySym_52(HandleRef pThis);

	/// <summary>
	/// Set/get the key symbol for the key that was pressed. This is the key
	/// symbol as defined by the relevant X headers. On X based platforms this
	/// corresponds to the installed X server, whereas on other platforms the
	/// native key codes are translated into a string representation.
	/// </summary>
	public virtual string GetKeySym()
	{
		return Marshal.PtrToStringAnsi(vtkRenderWindowInteractor_GetKeySym_52(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetLastEventPosition_53(HandleRef pThis);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual int[] GetLastEventPosition()
	{
		IntPtr intPtr = vtkRenderWindowInteractor_GetLastEventPosition_53(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetLastEventPosition_54(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void GetLastEventPosition(ref int _arg1, ref int _arg2)
	{
		vtkRenderWindowInteractor_GetLastEventPosition_54(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetLastEventPosition_55(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void GetLastEventPosition(IntPtr _arg)
	{
		vtkRenderWindowInteractor_GetLastEventPosition_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetLastEventPositions_56(HandleRef pThis, int pointerIndex);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual IntPtr GetLastEventPositions(int pointerIndex)
	{
		return vtkRenderWindowInteractor_GetLastEventPositions_56(GetCppThis(), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetLastRotation_57(HandleRef pThis);

	/// <summary>
	/// Set/get the rotation for the gesture in degrees, update LastRotation
	/// </summary>
	public virtual double GetLastRotation()
	{
		return vtkRenderWindowInteractor_GetLastRotation_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetLastScale_58(HandleRef pThis);

	/// <summary>
	/// Set/get the scale for the gesture, updates LastScale
	/// </summary>
	public virtual double GetLastScale()
	{
		return vtkRenderWindowInteractor_GetLastScale_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetLastTranslation_59(HandleRef pThis);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual double[] GetLastTranslation()
	{
		IntPtr intPtr = vtkRenderWindowInteractor_GetLastTranslation_59(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetLastTranslation_60(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual void GetLastTranslation(ref double _arg1, ref double _arg2)
	{
		vtkRenderWindowInteractor_GetLastTranslation_60(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetLastTranslation_61(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual void GetLastTranslation(IntPtr _arg)
	{
		vtkRenderWindowInteractor_GetLastTranslation_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetLightFollowCamera_62(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic repositioning of lights as the camera moves.
	/// Default is On.
	/// </summary>
	public virtual int GetLightFollowCamera()
	{
		return vtkRenderWindowInteractor_GetLightFollowCamera_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetMousePosition_63(HandleRef pThis, IntPtr x, IntPtr y);

	/// <summary>
	/// Get the current position of the mouse.
	/// </summary>
	public virtual void GetMousePosition(IntPtr x, IntPtr y)
	{
		vtkRenderWindowInteractor_GetMousePosition_63(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFrames_64(HandleRef pThis);

	/// <summary>
	/// Set the number of frames to fly to when FlyTo is invoked.
	/// </summary>
	public virtual int GetNumberOfFlyFrames()
	{
		return vtkRenderWindowInteractor_GetNumberOfFlyFrames_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFramesMaxValue_65(HandleRef pThis);

	/// <summary>
	/// Set the number of frames to fly to when FlyTo is invoked.
	/// </summary>
	public virtual int GetNumberOfFlyFramesMaxValue()
	{
		return vtkRenderWindowInteractor_GetNumberOfFlyFramesMaxValue_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFramesMinValue_66(HandleRef pThis);

	/// <summary>
	/// Set the number of frames to fly to when FlyTo is invoked.
	/// </summary>
	public virtual int GetNumberOfFlyFramesMinValue()
	{
		return vtkRenderWindowInteractor_GetNumberOfFlyFramesMinValue_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderWindowInteractor_GetNumberOfGenerationsFromBase_67(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderWindowInteractor_GetNumberOfGenerationsFromBase_67(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_68(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_68(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetObserverMediator_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the object used to mediate between vtkInteractorObservers
	/// contending for resources. Multiple interactor observers will often
	/// request different resources (e.g., cursor shape); the mediator uses a
	/// strategy to provide the resource based on priority of the observer plus
	/// the particular request (default versus non-default cursor shape).
	/// </summary>
	public vtkObserverMediator GetObserverMediator()
	{
		vtkObserverMediator vtkObserverMediator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_GetObserverMediator_69(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkObserverMediator2 = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkObserverMediator2.Register(null);
			}
		}
		return vtkObserverMediator2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetPicker_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the object used to perform pick operations. In order to
	/// pick instances of vtkProp, the picker must be a subclass of
	/// vtkAbstractPropPicker, meaning that it can identify a particular
	/// instance of vtkProp.
	/// </summary>
	public virtual vtkAbstractPicker GetPicker()
	{
		vtkAbstractPicker vtkAbstractPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_GetPicker_70(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPicker2 = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPicker2.Register(null);
			}
		}
		return vtkAbstractPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetPickingManager_71(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the picking manager.
	/// Set/Get the object used to perform operations through the interactor
	/// By default, a valid but disabled picking manager is instantiated.
	/// </summary>
	public virtual vtkPickingManager GetPickingManager()
	{
		vtkPickingManager vtkPickingManager2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_GetPickingManager_71(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPickingManager2 = (vtkPickingManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPickingManager2.Register(null);
			}
		}
		return vtkPickingManager2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetPointerIndex_72(HandleRef pThis);

	/// <summary>
	/// Set/get the index of the most recent pointer to have an event
	/// </summary>
	public virtual int GetPointerIndex()
	{
		return vtkRenderWindowInteractor_GetPointerIndex_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetPointerIndexForContact_73(HandleRef pThis, ulong contactID);

	/// <summary>
	/// Most multitouch systems use persistent contact/pointer ids to
	/// track events/motion during multitouch events. We keep an array
	/// that maps these system dependent contact ids to our pointer index
	/// These functions return -1 if the ID is not found or if there
	/// is no more room for contacts
	/// </summary>
	public int GetPointerIndexForContact(ulong contactID)
	{
		return vtkRenderWindowInteractor_GetPointerIndexForContact_73(GetCppThis(), contactID);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetPointerIndexForExistingContact_74(HandleRef pThis, ulong contactID);

	/// <summary>
	/// Most multitouch systems use persistent contact/pointer ids to
	/// track events/motion during multitouch events. We keep an array
	/// that maps these system dependent contact ids to our pointer index
	/// These functions return -1 if the ID is not found or if there
	/// is no more room for contacts
	/// </summary>
	public int GetPointerIndexForExistingContact(ulong contactID)
	{
		return vtkRenderWindowInteractor_GetPointerIndexForExistingContact_74(GetCppThis(), contactID);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetPointersDownCount_75(HandleRef pThis);

	/// <summary>
	/// When handling gestures you can query this value to
	/// determine how many pointers are down for the gesture
	/// this is useful for pan gestures for example
	/// </summary>
	public virtual int GetPointersDownCount()
	{
		return vtkRenderWindowInteractor_GetPointersDownCount_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindowInteractor_GetRecognizeGestures_76(HandleRef pThis);

	/// <summary>
	/// Convert multitouch events into gestures. When this is on
	/// (its default) multitouch events received by this interactor
	/// will be converted into gestures by VTK. If turned off the
	/// raw multitouch events will be passed down.
	/// </summary>
	public virtual bool GetRecognizeGestures()
	{
		return (vtkRenderWindowInteractor_GetRecognizeGestures_76(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetRenderWindow_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the rendering window being controlled by this object.
	/// </summary>
	public virtual vtkRenderWindow GetRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_GetRenderWindow_77(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetRepeatCount_78(HandleRef pThis);

	/// <summary>
	/// Set/get the repear count for the key or mouse event. This specifies how
	/// many times a key has been pressed.
	/// </summary>
	public virtual int GetRepeatCount()
	{
		return vtkRenderWindowInteractor_GetRepeatCount_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetRotation_79(HandleRef pThis);

	/// <summary>
	/// Set/get the rotation for the gesture in degrees, update LastRotation
	/// </summary>
	public virtual double GetRotation()
	{
		return vtkRenderWindowInteractor_GetRotation_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetScale_80(HandleRef pThis);

	/// <summary>
	/// Set/get the scale for the gesture, updates LastScale
	/// </summary>
	public virtual double GetScale()
	{
		return vtkRenderWindowInteractor_GetScale_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetShiftKey_81(HandleRef pThis);

	/// <summary>
	/// Set/get whether shift modifier key was pressed.
	/// </summary>
	public virtual int GetShiftKey()
	{
		return vtkRenderWindowInteractor_GetShiftKey_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetSize_82(HandleRef pThis);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public virtual int[] GetSize()
	{
		IntPtr intPtr = vtkRenderWindowInteractor_GetSize_82(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetSize_83(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public virtual void GetSize(ref int _arg1, ref int _arg2)
	{
		vtkRenderWindowInteractor_GetSize_83(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetSize_84(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public virtual void GetSize(IntPtr _arg)
	{
		vtkRenderWindowInteractor_GetSize_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetStillUpdateRate_85(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired update rate when movement has stopped.
	/// For the non-still update rate, see the SetDesiredUpdateRate method.
	/// The default is 0.0001
	/// </summary>
	public virtual double GetStillUpdateRate()
	{
		return vtkRenderWindowInteractor_GetStillUpdateRate_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetStillUpdateRateMaxValue_86(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired update rate when movement has stopped.
	/// For the non-still update rate, see the SetDesiredUpdateRate method.
	/// The default is 0.0001
	/// </summary>
	public virtual double GetStillUpdateRateMaxValue()
	{
		return vtkRenderWindowInteractor_GetStillUpdateRateMaxValue_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor_GetStillUpdateRateMinValue_87(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired update rate when movement has stopped.
	/// For the non-still update rate, see the SetDesiredUpdateRate method.
	/// The default is 0.0001
	/// </summary>
	public virtual double GetStillUpdateRateMinValue()
	{
		return vtkRenderWindowInteractor_GetStillUpdateRateMinValue_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkRenderWindowInteractor_GetTimerDuration_88(HandleRef pThis, int timerId);

	/// <summary>
	/// Get the duration (in milliseconds) for the specified timerId.
	/// </summary>
	public uint GetTimerDuration(int timerId)
	{
		return vtkRenderWindowInteractor_GetTimerDuration_88(GetCppThis(), timerId);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkRenderWindowInteractor_GetTimerDuration_89(HandleRef pThis);

	/// <summary>
	/// Specify the default timer interval (in milliseconds). (This is used in
	/// conjunction with the timer methods described previously, e.g.,
	/// CreateTimer() uses this value; and CreateRepeatingTimer(duration) and
	/// CreateOneShotTimer(duration) use the default value if the parameter
	/// "duration" is less than or equal to zero.) Care must be taken when
	/// adjusting the timer interval from the default value of 10
	/// milliseconds--it may adversely affect the interactors.
	/// </summary>
	public virtual uint GetTimerDuration()
	{
		return vtkRenderWindowInteractor_GetTimerDuration_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkRenderWindowInteractor_GetTimerDurationMaxValue_90(HandleRef pThis);

	/// <summary>
	/// Specify the default timer interval (in milliseconds). (This is used in
	/// conjunction with the timer methods described previously, e.g.,
	/// CreateTimer() uses this value; and CreateRepeatingTimer(duration) and
	/// CreateOneShotTimer(duration) use the default value if the parameter
	/// "duration" is less than or equal to zero.) Care must be taken when
	/// adjusting the timer interval from the default value of 10
	/// milliseconds--it may adversely affect the interactors.
	/// </summary>
	public virtual uint GetTimerDurationMaxValue()
	{
		return vtkRenderWindowInteractor_GetTimerDurationMaxValue_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkRenderWindowInteractor_GetTimerDurationMinValue_91(HandleRef pThis);

	/// <summary>
	/// Specify the default timer interval (in milliseconds). (This is used in
	/// conjunction with the timer methods described previously, e.g.,
	/// CreateTimer() uses this value; and CreateRepeatingTimer(duration) and
	/// CreateOneShotTimer(duration) use the default value if the parameter
	/// "duration" is less than or equal to zero.) Care must be taken when
	/// adjusting the timer interval from the default value of 10
	/// milliseconds--it may adversely affect the interactors.
	/// </summary>
	public virtual uint GetTimerDurationMinValue()
	{
		return vtkRenderWindowInteractor_GetTimerDurationMinValue_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetTimerEventDuration_92(HandleRef pThis);

	/// <summary>
	/// These methods are used to communicate information about the currently
	/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
	/// CreateTimerEvent sets up TimerEventId, TimerEventType and
	/// TimerEventDuration. The observer of CreateTimerEvent should set up an
	/// appropriate platform specific timer based on those values and set the
	/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
	/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
	/// simply destroy the platform specific timer created by CreateTimerEvent.
	/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
	/// InternalDestroyTimer for an example.
	/// </summary>
	public virtual int GetTimerEventDuration()
	{
		return vtkRenderWindowInteractor_GetTimerEventDuration_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetTimerEventId_93(HandleRef pThis);

	/// <summary>
	/// These methods are used to communicate information about the currently
	/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
	/// CreateTimerEvent sets up TimerEventId, TimerEventType and
	/// TimerEventDuration. The observer of CreateTimerEvent should set up an
	/// appropriate platform specific timer based on those values and set the
	/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
	/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
	/// simply destroy the platform specific timer created by CreateTimerEvent.
	/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
	/// InternalDestroyTimer for an example.
	/// </summary>
	public virtual int GetTimerEventId()
	{
		return vtkRenderWindowInteractor_GetTimerEventId_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetTimerEventPlatformId_94(HandleRef pThis);

	/// <summary>
	/// These methods are used to communicate information about the currently
	/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
	/// CreateTimerEvent sets up TimerEventId, TimerEventType and
	/// TimerEventDuration. The observer of CreateTimerEvent should set up an
	/// appropriate platform specific timer based on those values and set the
	/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
	/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
	/// simply destroy the platform specific timer created by CreateTimerEvent.
	/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
	/// InternalDestroyTimer for an example.
	/// </summary>
	public virtual int GetTimerEventPlatformId()
	{
		return vtkRenderWindowInteractor_GetTimerEventPlatformId_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetTimerEventType_95(HandleRef pThis);

	/// <summary>
	/// These methods are used to communicate information about the currently
	/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
	/// CreateTimerEvent sets up TimerEventId, TimerEventType and
	/// TimerEventDuration. The observer of CreateTimerEvent should set up an
	/// appropriate platform specific timer based on those values and set the
	/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
	/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
	/// simply destroy the platform specific timer created by CreateTimerEvent.
	/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
	/// InternalDestroyTimer for an example.
	/// </summary>
	public virtual int GetTimerEventType()
	{
		return vtkRenderWindowInteractor_GetTimerEventType_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_GetTranslation_96(HandleRef pThis);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual double[] GetTranslation()
	{
		IntPtr intPtr = vtkRenderWindowInteractor_GetTranslation_96(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetTranslation_97(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual void GetTranslation(ref double _arg1, ref double _arg2)
	{
		vtkRenderWindowInteractor_GetTranslation_97(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_GetTranslation_98(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual void GetTranslation(IntPtr _arg)
	{
		vtkRenderWindowInteractor_GetTranslation_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindowInteractor_GetUseTDx_99(HandleRef pThis);

	/// <summary>
	/// Use a 3DConnexion device. Initial value is false.
	/// If VTK is not build with the TDx option, this is no-op.
	/// If VTK is build with the TDx option, and a device is not connected,
	/// a warning is emitted.
	/// It is must be called before the first Render to be effective, otherwise
	/// it is ignored.
	/// </summary>
	public virtual bool GetUseTDx()
	{
		return (vtkRenderWindowInteractor_GetUseTDx_99(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_GetVTKTimerId_100(HandleRef pThis, int platformTimerId);

	/// <summary>
	/// Get the VTK timer ID that corresponds to the supplied platform ID.
	/// </summary>
	public virtual int GetVTKTimerId(int platformTimerId)
	{
		return vtkRenderWindowInteractor_GetVTKTimerId_100(GetCppThis(), platformTimerId);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_HideCursor_101(HandleRef pThis);

	/// <summary>
	/// Hide or show the mouse cursor, it is nice to be able to hide the
	/// default cursor if you want VTK to display a 3D cursor instead.
	/// </summary>
	public void HideCursor()
	{
		vtkRenderWindowInteractor_HideCursor_101(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_Initialize_102(HandleRef pThis);

	/// <summary>
	/// Prepare for handling events and set the Enabled flag to true.
	/// This will be called automatically by Start() if the interactor
	/// is not initialized, but it can be called manually if you need
	/// to perform any operations between initialization and the start
	/// of the event loop.
	/// </summary>
	public virtual void Initialize()
	{
		vtkRenderWindowInteractor_Initialize_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_IsA_103(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderWindowInteractor_IsA_103(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_IsOneShotTimer_104(HandleRef pThis, int timerId);

	/// <summary>
	/// Query whether the specified timerId is a one shot timer.
	/// \return 1 if the timer is a one shot timer.
	/// </summary>
	public int IsOneShotTimer(int timerId)
	{
		return vtkRenderWindowInteractor_IsOneShotTimer_104(GetCppThis(), timerId);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindowInteractor_IsPointerIndexSet_105(HandleRef pThis, int i);

	/// <summary>
	/// Most multitouch systems use persistent contact/pointer ids to
	/// track events/motion during multitouch events. We keep an array
	/// that maps these system dependent contact ids to our pointer index
	/// These functions return -1 if the ID is not found or if there
	/// is no more room for contacts
	/// </summary>
	public bool IsPointerIndexSet(int i)
	{
		return (vtkRenderWindowInteractor_IsPointerIndexSet_105(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_IsTypeOf_106(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderWindowInteractor_IsTypeOf_106(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_KeyPressEvent_107(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void KeyPressEvent()
	{
		vtkRenderWindowInteractor_KeyPressEvent_107(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_KeyReleaseEvent_108(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void KeyReleaseEvent()
	{
		vtkRenderWindowInteractor_KeyReleaseEvent_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_LeaveEvent_109(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void LeaveEvent()
	{
		vtkRenderWindowInteractor_LeaveEvent_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_LeftButtonPressEvent_110(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void LeftButtonPressEvent()
	{
		vtkRenderWindowInteractor_LeftButtonPressEvent_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_LeftButtonReleaseEvent_111(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void LeftButtonReleaseEvent()
	{
		vtkRenderWindowInteractor_LeftButtonReleaseEvent_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_LightFollowCameraOff_112(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic repositioning of lights as the camera moves.
	/// Default is On.
	/// </summary>
	public virtual void LightFollowCameraOff()
	{
		vtkRenderWindowInteractor_LightFollowCameraOff_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_LightFollowCameraOn_113(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic repositioning of lights as the camera moves.
	/// Default is On.
	/// </summary>
	public virtual void LightFollowCameraOn()
	{
		vtkRenderWindowInteractor_LightFollowCameraOn_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_LongTapEvent_114(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void LongTapEvent()
	{
		vtkRenderWindowInteractor_LongTapEvent_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_MiddleButtonPressEvent_115(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void MiddleButtonPressEvent()
	{
		vtkRenderWindowInteractor_MiddleButtonPressEvent_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_MiddleButtonReleaseEvent_116(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void MiddleButtonReleaseEvent()
	{
		vtkRenderWindowInteractor_MiddleButtonReleaseEvent_116(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_MouseMoveEvent_117(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void MouseMoveEvent()
	{
		vtkRenderWindowInteractor_MouseMoveEvent_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_MouseWheelBackwardEvent_118(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void MouseWheelBackwardEvent()
	{
		vtkRenderWindowInteractor_MouseWheelBackwardEvent_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_MouseWheelForwardEvent_119(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void MouseWheelForwardEvent()
	{
		vtkRenderWindowInteractor_MouseWheelForwardEvent_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_MouseWheelLeftEvent_120(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void MouseWheelLeftEvent()
	{
		vtkRenderWindowInteractor_MouseWheelLeftEvent_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_MouseWheelRightEvent_121(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void MouseWheelRightEvent()
	{
		vtkRenderWindowInteractor_MouseWheelRightEvent_121(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_NewInstance_123(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRenderWindowInteractor NewInstance()
	{
		vtkRenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_NewInstance_123(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_PanEvent_124(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void PanEvent()
	{
		vtkRenderWindowInteractor_PanEvent_124(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_PinchEvent_125(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void PinchEvent()
	{
		vtkRenderWindowInteractor_PinchEvent_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ProcessEvents_126(HandleRef pThis);

	/// <summary>
	/// Run the event loop and return. This is provided so that you can
	/// implement your own event loop but yet use the vtk event handling as
	/// well.
	/// </summary>
	public virtual void ProcessEvents()
	{
		vtkRenderWindowInteractor_ProcessEvents_126(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ReInitialize_127(HandleRef pThis);

	/// <summary>
	/// Prepare for handling events and set the Enabled flag to true.
	/// This will be called automatically by Start() if the interactor
	/// is not initialized, but it can be called manually if you need
	/// to perform any operations between initialization and the start
	/// of the event loop.
	/// </summary>
	public void ReInitialize()
	{
		vtkRenderWindowInteractor_ReInitialize_127(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_Render_128(HandleRef pThis);

	/// <summary>
	/// Render the scene. Just pass the render call on to the
	/// associated vtkRenderWindow.
	/// </summary>
	public virtual void Render()
	{
		vtkRenderWindowInteractor_Render_128(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor_ResetTimer_129(HandleRef pThis, int timerId);

	/// <summary>
	/// Reset the specified timer.
	/// </summary>
	public int ResetTimer(int timerId)
	{
		return vtkRenderWindowInteractor_ResetTimer_129(GetCppThis(), timerId);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_RightButtonPressEvent_130(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void RightButtonPressEvent()
	{
		vtkRenderWindowInteractor_RightButtonPressEvent_130(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_RightButtonReleaseEvent_131(HandleRef pThis);

	/// <summary>
	/// Fire various events. SetEventInformation should be called just prior
	/// to calling any of these methods. These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void RightButtonReleaseEvent()
	{
		vtkRenderWindowInteractor_RightButtonReleaseEvent_131(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_RotateEvent_132(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void RotateEvent()
	{
		vtkRenderWindowInteractor_RotateEvent_132(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor_SafeDownCast_133(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderWindowInteractor SafeDownCast(vtkObjectBase o)
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor_SafeDownCast_133(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindowInteractor2 = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindowInteractor2.Register(null);
			}
		}
		return vtkRenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetAltKey_134(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether alt modifier key was pressed.
	/// </summary>
	public virtual void SetAltKey(int _arg)
	{
		vtkRenderWindowInteractor_SetAltKey_134(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetControlKey_135(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether control modifier key was pressed.
	/// </summary>
	public virtual void SetControlKey(int _arg)
	{
		vtkRenderWindowInteractor_SetControlKey_135(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetDesiredUpdateRate_136(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the desired update rate. This is used by vtkLODActor's to tell
	/// them how quickly they need to render.  This update is in effect only
	/// when the camera is being rotated, or zoomed.  When the interactor is
	/// still, the StillUpdateRate is used instead.
	/// The default is 15.
	/// </summary>
	public virtual void SetDesiredUpdateRate(double _arg)
	{
		vtkRenderWindowInteractor_SetDesiredUpdateRate_136(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetDolly_137(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the total Dolly value to use when flying to (FlyTo()) a
	/// specified point. Negative values fly away from the point.
	/// </summary>
	public virtual void SetDolly(double _arg)
	{
		vtkRenderWindowInteractor_SetDolly_137(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetDone_138(HandleRef pThis, byte _arg);

	/// <summary>
	/// Is the interactor loop done
	/// </summary>
	public virtual void SetDone(bool _arg)
	{
		vtkRenderWindowInteractor_SetDone_138(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEnableRender_139(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/Disable whether vtkRenderWindowInteractor::Render() calls
	/// this-&gt;RenderWindow-&gt;Render().
	/// </summary>
	public virtual void SetEnableRender(bool _arg)
	{
		vtkRenderWindowInteractor_SetEnableRender_139(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventInformation_140(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym, int pointerIndex);

	/// <summary>
	/// Set all the event information in one call.
	/// </summary>
	public void SetEventInformation(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym, int pointerIndex)
	{
		vtkRenderWindowInteractor_SetEventInformation_140(GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym, pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventInformation_141(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym);

	/// <summary>
	/// Set all the event information in one call.
	/// </summary>
	public void SetEventInformation(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
	{
		vtkRenderWindowInteractor_SetEventInformation_141(GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventInformationFlipY_142(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym, int pointerIndex);

	/// <summary>
	/// Calls SetEventInformation, but flips the Y based on the current Size[1]
	/// value (i.e. y = this-&gt;Size[1] - y - 1).
	/// </summary>
	public void SetEventInformationFlipY(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym, int pointerIndex)
	{
		vtkRenderWindowInteractor_SetEventInformationFlipY_142(GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym, pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventInformationFlipY_143(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym);

	/// <summary>
	/// Calls SetEventInformation, but flips the Y based on the current Size[1]
	/// value (i.e. y = this-&gt;Size[1] - y - 1).
	/// </summary>
	public void SetEventInformationFlipY(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
	{
		vtkRenderWindowInteractor_SetEventInformationFlipY_143(GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventPosition_144(HandleRef pThis, int x, int y);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetEventPosition(int x, int y)
	{
		vtkRenderWindowInteractor_SetEventPosition_144(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventPosition_145(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetEventPosition(IntPtr pos)
	{
		vtkRenderWindowInteractor_SetEventPosition_145(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventPosition_146(HandleRef pThis, int x, int y, int pointerIndex);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetEventPosition(int x, int y, int pointerIndex)
	{
		vtkRenderWindowInteractor_SetEventPosition_146(GetCppThis(), x, y, pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventPosition_147(HandleRef pThis, IntPtr pos, int pointerIndex);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetEventPosition(IntPtr pos, int pointerIndex)
	{
		vtkRenderWindowInteractor_SetEventPosition_147(GetCppThis(), pos, pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_148(HandleRef pThis, int x, int y);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetEventPositionFlipY(int x, int y)
	{
		vtkRenderWindowInteractor_SetEventPositionFlipY_148(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_149(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetEventPositionFlipY(IntPtr pos)
	{
		vtkRenderWindowInteractor_SetEventPositionFlipY_149(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_150(HandleRef pThis, int x, int y, int pointerIndex);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetEventPositionFlipY(int x, int y, int pointerIndex)
	{
		vtkRenderWindowInteractor_SetEventPositionFlipY_150(GetCppThis(), x, y, pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_151(HandleRef pThis, IntPtr pos, int pointerIndex);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetEventPositionFlipY(IntPtr pos, int pointerIndex)
	{
		vtkRenderWindowInteractor_SetEventPositionFlipY_151(GetCppThis(), pos, pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventSize_152(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public virtual void SetEventSize(int _arg1, int _arg2)
	{
		vtkRenderWindowInteractor_SetEventSize_152(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetEventSize_153(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public void SetEventSize(IntPtr _arg)
	{
		vtkRenderWindowInteractor_SetEventSize_153(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetHardwareWindow_154(HandleRef pThis, HandleRef aren);

	/// <summary>
	/// Set/Get the hardware window being controlled by this object.
	/// For opengl the hardware window is not used as the opengl
	/// subclasses of RenderWindow provide the functionality.
	/// </summary>
	public void SetHardwareWindow(vtkHardwareWindow aren)
	{
		vtkRenderWindowInteractor_SetHardwareWindow_154(GetCppThis(), aren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetInteractorStyle_155(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// External switching between joystick/trackball/new? modes. Initial value
	/// is a vtkInteractorStyleSwitch object.
	/// </summary>
	public virtual void SetInteractorStyle(vtkInteractorObserver arg0)
	{
		vtkRenderWindowInteractor_SetInteractorStyle_155(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetKeyCode_156(HandleRef pThis, sbyte _arg);

	/// <summary>
	/// Set/get the key code for the key that was pressed.
	/// </summary>
	public virtual void SetKeyCode(sbyte _arg)
	{
		vtkRenderWindowInteractor_SetKeyCode_156(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetKeyEventInformation_157(HandleRef pThis, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym);

	/// <summary>
	/// Set all the keyboard-related event information in one call.
	/// </summary>
	public void SetKeyEventInformation(int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
	{
		vtkRenderWindowInteractor_SetKeyEventInformation_157(GetCppThis(), ctrl, shift, keycode, repeatcount, keysym);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetKeySym_158(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the key symbol for the key that was pressed. This is the key
	/// symbol as defined by the relevant X headers. On X based platforms this
	/// corresponds to the installed X server, whereas on other platforms the
	/// native key codes are translated into a string representation.
	/// </summary>
	public virtual void SetKeySym(string _arg)
	{
		vtkRenderWindowInteractor_SetKeySym_158(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetLastEventPosition_159(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public virtual void SetLastEventPosition(int _arg1, int _arg2)
	{
		vtkRenderWindowInteractor_SetLastEventPosition_159(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetLastEventPosition_160(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get information about the current event.
	/// The current x,y position is in the EventPosition, and the previous
	/// event position is in LastEventPosition, updated automatically each
	/// time EventPosition is set using its Set() method. Mouse positions
	/// are measured in pixels.
	/// The other information is about key board input.
	/// </summary>
	public void SetLastEventPosition(IntPtr _arg)
	{
		vtkRenderWindowInteractor_SetLastEventPosition_160(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetLightFollowCamera_161(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the automatic repositioning of lights as the camera moves.
	/// Default is On.
	/// </summary>
	public virtual void SetLightFollowCamera(int _arg)
	{
		vtkRenderWindowInteractor_SetLightFollowCamera_161(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetNumberOfFlyFrames_162(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of frames to fly to when FlyTo is invoked.
	/// </summary>
	public virtual void SetNumberOfFlyFrames(int _arg)
	{
		vtkRenderWindowInteractor_SetNumberOfFlyFrames_162(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetPicker_163(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the object used to perform pick operations. In order to
	/// pick instances of vtkProp, the picker must be a subclass of
	/// vtkAbstractPropPicker, meaning that it can identify a particular
	/// instance of vtkProp.
	/// </summary>
	public virtual void SetPicker(vtkAbstractPicker arg0)
	{
		vtkRenderWindowInteractor_SetPicker_163(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetPickingManager_164(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the picking manager.
	/// Set/Get the object used to perform operations through the interactor
	/// By default, a valid but disabled picking manager is instantiated.
	/// </summary>
	public virtual void SetPickingManager(vtkPickingManager arg0)
	{
		vtkRenderWindowInteractor_SetPickingManager_164(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetPointerIndex_165(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the index of the most recent pointer to have an event
	/// </summary>
	public virtual void SetPointerIndex(int _arg)
	{
		vtkRenderWindowInteractor_SetPointerIndex_165(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetRecognizeGestures_166(HandleRef pThis, byte _arg);

	/// <summary>
	/// Convert multitouch events into gestures. When this is on
	/// (its default) multitouch events received by this interactor
	/// will be converted into gestures by VTK. If turned off the
	/// raw multitouch events will be passed down.
	/// </summary>
	public virtual void SetRecognizeGestures(bool _arg)
	{
		vtkRenderWindowInteractor_SetRecognizeGestures_166(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetRenderWindow_167(HandleRef pThis, HandleRef aren);

	/// <summary>
	/// Set/Get the rendering window being controlled by this object.
	/// </summary>
	public void SetRenderWindow(vtkRenderWindow aren)
	{
		vtkRenderWindowInteractor_SetRenderWindow_167(GetCppThis(), aren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetRepeatCount_168(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the repear count for the key or mouse event. This specifies how
	/// many times a key has been pressed.
	/// </summary>
	public virtual void SetRepeatCount(int _arg)
	{
		vtkRenderWindowInteractor_SetRepeatCount_168(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetRotation_169(HandleRef pThis, double rotation);

	/// <summary>
	/// Set/get the rotation for the gesture in degrees, update LastRotation
	/// </summary>
	public void SetRotation(double rotation)
	{
		vtkRenderWindowInteractor_SetRotation_169(GetCppThis(), rotation);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetScale_170(HandleRef pThis, double scale);

	/// <summary>
	/// Set/get the scale for the gesture, updates LastScale
	/// </summary>
	public void SetScale(double scale)
	{
		vtkRenderWindowInteractor_SetScale_170(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetShiftKey_171(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether shift modifier key was pressed.
	/// </summary>
	public virtual void SetShiftKey(int _arg)
	{
		vtkRenderWindowInteractor_SetShiftKey_171(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetSize_172(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public virtual void SetSize(int _arg1, int _arg2)
	{
		vtkRenderWindowInteractor_SetSize_172(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetSize_173(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This methods sets the Size ivar of the interactor without
	/// actually changing the size of the window. Normally
	/// application programmers would use UpdateSize if anything.
	/// This is useful for letting someone else change the size of
	/// the rendering window and just letting the interactor
	/// know about the change.
	/// The current event width/height (if any) is in EventSize
	/// (Expose event, for example).
	/// Window size is measured in pixels.
	/// </summary>
	public void SetSize(IntPtr _arg)
	{
		vtkRenderWindowInteractor_SetSize_173(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetStillUpdateRate_174(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the desired update rate when movement has stopped.
	/// For the non-still update rate, see the SetDesiredUpdateRate method.
	/// The default is 0.0001
	/// </summary>
	public virtual void SetStillUpdateRate(double _arg)
	{
		vtkRenderWindowInteractor_SetStillUpdateRate_174(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetTimerDuration_175(HandleRef pThis, uint _arg);

	/// <summary>
	/// Specify the default timer interval (in milliseconds). (This is used in
	/// conjunction with the timer methods described previously, e.g.,
	/// CreateTimer() uses this value; and CreateRepeatingTimer(duration) and
	/// CreateOneShotTimer(duration) use the default value if the parameter
	/// "duration" is less than or equal to zero.) Care must be taken when
	/// adjusting the timer interval from the default value of 10
	/// milliseconds--it may adversely affect the interactors.
	/// </summary>
	public virtual void SetTimerDuration(uint _arg)
	{
		vtkRenderWindowInteractor_SetTimerDuration_175(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetTimerEventDuration_176(HandleRef pThis, int _arg);

	/// <summary>
	/// These methods are used to communicate information about the currently
	/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
	/// CreateTimerEvent sets up TimerEventId, TimerEventType and
	/// TimerEventDuration. The observer of CreateTimerEvent should set up an
	/// appropriate platform specific timer based on those values and set the
	/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
	/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
	/// simply destroy the platform specific timer created by CreateTimerEvent.
	/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
	/// InternalDestroyTimer for an example.
	/// </summary>
	public virtual void SetTimerEventDuration(int _arg)
	{
		vtkRenderWindowInteractor_SetTimerEventDuration_176(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetTimerEventId_177(HandleRef pThis, int _arg);

	/// <summary>
	/// These methods are used to communicate information about the currently
	/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
	/// CreateTimerEvent sets up TimerEventId, TimerEventType and
	/// TimerEventDuration. The observer of CreateTimerEvent should set up an
	/// appropriate platform specific timer based on those values and set the
	/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
	/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
	/// simply destroy the platform specific timer created by CreateTimerEvent.
	/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
	/// InternalDestroyTimer for an example.
	/// </summary>
	public virtual void SetTimerEventId(int _arg)
	{
		vtkRenderWindowInteractor_SetTimerEventId_177(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetTimerEventPlatformId_178(HandleRef pThis, int _arg);

	/// <summary>
	/// These methods are used to communicate information about the currently
	/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
	/// CreateTimerEvent sets up TimerEventId, TimerEventType and
	/// TimerEventDuration. The observer of CreateTimerEvent should set up an
	/// appropriate platform specific timer based on those values and set the
	/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
	/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
	/// simply destroy the platform specific timer created by CreateTimerEvent.
	/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
	/// InternalDestroyTimer for an example.
	/// </summary>
	public virtual void SetTimerEventPlatformId(int _arg)
	{
		vtkRenderWindowInteractor_SetTimerEventPlatformId_178(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetTimerEventType_179(HandleRef pThis, int _arg);

	/// <summary>
	/// These methods are used to communicate information about the currently
	/// firing CreateTimerEvent or DestroyTimerEvent. The caller of
	/// CreateTimerEvent sets up TimerEventId, TimerEventType and
	/// TimerEventDuration. The observer of CreateTimerEvent should set up an
	/// appropriate platform specific timer based on those values and set the
	/// TimerEventPlatformId before returning. The caller of DestroyTimerEvent
	/// sets up TimerEventPlatformId. The observer of DestroyTimerEvent should
	/// simply destroy the platform specific timer created by CreateTimerEvent.
	/// See vtkGenericRenderWindowInteractor's InternalCreateTimer and
	/// InternalDestroyTimer for an example.
	/// </summary>
	public virtual void SetTimerEventType(int _arg)
	{
		vtkRenderWindowInteractor_SetTimerEventType_179(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetTranslation_180(HandleRef pThis, IntPtr val);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public void SetTranslation(IntPtr val)
	{
		vtkRenderWindowInteractor_SetTranslation_180(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SetUseTDx_181(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use a 3DConnexion device. Initial value is false.
	/// If VTK is not build with the TDx option, this is no-op.
	/// If VTK is build with the TDx option, and a device is not connected,
	/// a warning is emitted.
	/// It is must be called before the first Render to be effective, otherwise
	/// it is ignored.
	/// </summary>
	public virtual void SetUseTDx(bool _arg)
	{
		vtkRenderWindowInteractor_SetUseTDx_181(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_ShowCursor_182(HandleRef pThis);

	/// <summary>
	/// Hide or show the mouse cursor, it is nice to be able to hide the
	/// default cursor if you want VTK to display a 3D cursor instead.
	/// </summary>
	public void ShowCursor()
	{
		vtkRenderWindowInteractor_ShowCursor_182(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_Start_183(HandleRef pThis);

	/// <summary>
	/// Start the event loop. This is provided so that you do not have to
	/// implement your own event loop. You still can use your own
	/// event loop if you want.
	/// </summary>
	public virtual void Start()
	{
		vtkRenderWindowInteractor_Start_183(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_StartPanEvent_184(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void StartPanEvent()
	{
		vtkRenderWindowInteractor_StartPanEvent_184(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_StartPickCallback_185(HandleRef pThis);

	/// <summary>
	/// These methods correspond to the Exit, User and Pick
	/// callbacks. They allow for the Style to invoke them.
	/// </summary>
	public virtual void StartPickCallback()
	{
		vtkRenderWindowInteractor_StartPickCallback_185(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_StartPinchEvent_186(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void StartPinchEvent()
	{
		vtkRenderWindowInteractor_StartPinchEvent_186(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_StartRotateEvent_187(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void StartRotateEvent()
	{
		vtkRenderWindowInteractor_StartRotateEvent_187(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_SwipeEvent_188(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void SwipeEvent()
	{
		vtkRenderWindowInteractor_SwipeEvent_188(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_TapEvent_189(HandleRef pThis);

	/// <summary>
	/// Fire various gesture based events.  These methods will Invoke the
	/// corresponding vtk event.
	/// </summary>
	public virtual void TapEvent()
	{
		vtkRenderWindowInteractor_TapEvent_189(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_TerminateApp_190(HandleRef pThis);

	/// <summary>
	/// This function is called on 'q','e' keypress if exitmethod is not
	/// specified and should be overridden by platform dependent subclasses
	/// to provide a termination procedure if one is required.
	/// </summary>
	public virtual void TerminateApp()
	{
		vtkRenderWindowInteractor_TerminateApp_190(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_UpdateSize_192(HandleRef pThis, int x, int y);

	/// <summary>
	/// Event loop notification member for window size change.
	/// Window size is measured in pixels.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public virtual void UpdateSize(int x, int y)
	{
		vtkRenderWindowInteractor_UpdateSize_192(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor_UserCallback_193(HandleRef pThis);

	/// <summary>
	/// These methods correspond to the Exit, User and Pick
	/// callbacks. They allow for the Style to invoke them.
	/// </summary>
	public virtual void UserCallback()
	{
		vtkRenderWindowInteractor_UserCallback_193(GetCppThis());
	}
}
