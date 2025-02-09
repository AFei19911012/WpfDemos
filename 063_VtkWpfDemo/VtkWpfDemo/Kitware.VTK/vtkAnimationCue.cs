using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAnimationCue
/// </summary>
/// <remarks>
///    a seqin an animation.
///
/// vtkAnimationCue and vtkAnimationScene provide the framework to support
/// animations in VTK. vtkAnimationCue represents an entity that changes/
/// animates with time, while vtkAnimationScene represents scene or setup
/// for the animation, which consists on individual cues or other scenes.
///
/// A cue has three states: UNINITIALIZED, ACTIVE and INACTIVE.
/// UNINITIALIZED represents an point in time before the start time of the cue.
/// The cue is in ACTIVE state at a point in time between start time and end time
/// for the cue. While, beyond the end time, it is in INACTIVE state.
/// When the cue enters the ACTIVE state, StartAnimationCueEvent is fired. This
/// event may be handled to initialize the entity to be animated.
/// When the cue leaves the ACTIVE state, EndAnimationCueEvent is fired, which
/// can be handled to cleanup after having run the animation.
/// For every request to render during the ACTIVE state, AnimationCueTickEvent is
/// fired, which must be handled to perform the actual animation.
/// </remarks>
/// <seealso>
///
/// vtkAnimationScene
/// </seealso>
public class vtkAnimationCue : vtkObject
{
	/// <summary>
	/// This is valid only in a AnimationCueTickEvent handler.
	/// Before firing the event the animation cue sets the ClockTime to
	/// the time of the tick. ClockTime is directly the time from the animation
	/// scene neither normalized nor offsetted to the start of the scene.
	/// </summary>
	public enum PlayDirection
	{
		/// <summary>enum member</summary>
		BACKWARD,
		/// <summary>enum member</summary>
		FORWARD
	}

	/// <summary>
	/// This is valid only in a AnimationCueTickEvent handler.
	/// Before firing the event the animation cue sets the ClockTime to
	/// the time of the tick. ClockTime is directly the time from the animation
	/// scene neither normalized nor offsetted to the start of the scene.
	/// </summary>
	public enum TimeCodes
	{
		/// <summary>enum member</summary>
		TIMEMODE_NORMALIZED,
		/// <summary>enum member</summary>
		TIMEMODE_RELATIVE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAnimationCue";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAnimationCue()
	{
		MRClassNameKey = "class vtkAnimationCue";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnimationCue"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAnimationCue(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimationCue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnimationCue New()
	{
		vtkAnimationCue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimationCue_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAnimationCue()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAnimationCue_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAnimationCue_Finalize_01(HandleRef pThis);

	/// <summary>
	/// Called when the scene reaches the end.
	/// If the cue state is ACTIVE when this method is called, this will
	/// trigger a EndAnimationCueEvent.
	/// </summary>
	public virtual void FinalizeWrapper()
	{
		vtkAnimationCue_Finalize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAnimationCue_GetAnimationTime_02(HandleRef pThis);

	/// <summary>
	/// This is valid only in a AnimationCueTickEvent handler.
	/// Before firing the event the animation cue sets the AnimationTime to
	/// the time of the tick.
	/// </summary>
	public virtual double GetAnimationTime()
	{
		return vtkAnimationCue_GetAnimationTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAnimationCue_GetClockTime_03(HandleRef pThis);

	/// <summary>
	/// This is valid only in a AnimationCueTickEvent handler.
	/// Before firing the event the animation cue sets the ClockTime to
	/// the time of the tick. ClockTime is directly the time from the animation
	/// scene neither normalized nor offsetted to the start of the scene.
	/// </summary>
	public virtual double GetClockTime()
	{
		return vtkAnimationCue_GetClockTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAnimationCue_GetDeltaTime_04(HandleRef pThis);

	/// <summary>
	/// This is valid only in a AnimationCueTickEvent handler.
	/// Before firing the event the animation cue sets the DeltaTime
	/// to the difference in time between the current tick and the last tick.
	/// </summary>
	public virtual double GetDeltaTime()
	{
		return vtkAnimationCue_GetDeltaTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern PlayDirection vtkAnimationCue_GetDirection_05(HandleRef pThis);

	/// <summary>
	/// Set/get the direction of playback.
	/// </summary>
	public virtual PlayDirection GetDirection()
	{
		return vtkAnimationCue_GetDirection_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAnimationCue_GetEndTime_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the End time for this cue.
	/// When the current time is &gt; EndTime, the Cue is in
	/// INACTIVE state. Whenever the cue leaves an ACTIVE state to enter
	/// INACTIVE state, the EndEvent is triggered.
	/// The End time is in seconds relative to the start of the
	/// container Scene (when in Relative time mode) or is normalized
	/// over the span of the container Scene (when in Normalized time mode).
	/// </summary>
	public virtual double GetEndTime()
	{
		return vtkAnimationCue_GetEndTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnimationCue_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAnimationCue_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnimationCue_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAnimationCue_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAnimationCue_GetStartTime_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the Start time for this cue.
	/// When the current time is &gt;= StartTime, the Cue is in
	/// ACTIVE state. if Current time i &lt; StartTime, the Cue is in
	/// UNINITIALIZED state. Whenever the cue enters the ACTIVE state from
	/// an INACTIVE state, it triggers the StartEvent.
	/// The Start time is in seconds relative to the start of the
	/// container Scene (when in Relative time mode) or is normalized
	/// over the span of the container Scene (when in Normalized time mode).
	/// </summary>
	public virtual double GetStartTime()
	{
		return vtkAnimationCue_GetStartTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationCue_GetTimeMode_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the time mode. In Normalized mode, the start and end
	/// times of the cue are normalized [0,1] with respect to the start and
	/// end times of the container scene. In Relative mode the start and end
	/// time of the cue are specified in offset seconds relative to the
	/// start time of the container scene.
	/// </summary>
	public virtual int GetTimeMode()
	{
		return vtkAnimationCue_GetTimeMode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationCue_Initialize_11(HandleRef pThis);

	/// <summary>
	/// Called when the playing of the scene begins.
	/// This will set the Cue to UNINITIALIZED state.
	/// </summary>
	public virtual void Initialize()
	{
		vtkAnimationCue_Initialize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationCue_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAnimationCue_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationCue_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAnimationCue_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimationCue_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAnimationCue NewInstance()
	{
		vtkAnimationCue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimationCue_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimationCue_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnimationCue SafeDownCast(vtkObjectBase o)
	{
		vtkAnimationCue vtkAnimationCue2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimationCue_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnimationCue2 = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnimationCue2.Register(null);
			}
		}
		return vtkAnimationCue2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationCue_SetDirection_17(HandleRef pThis, PlayDirection _arg);

	/// <summary>
	/// Set/get the direction of playback.
	/// </summary>
	public virtual void SetDirection(PlayDirection _arg)
	{
		vtkAnimationCue_SetDirection_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationCue_SetEndTime_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the End time for this cue.
	/// When the current time is &gt; EndTime, the Cue is in
	/// INACTIVE state. Whenever the cue leaves an ACTIVE state to enter
	/// INACTIVE state, the EndEvent is triggered.
	/// The End time is in seconds relative to the start of the
	/// container Scene (when in Relative time mode) or is normalized
	/// over the span of the container Scene (when in Normalized time mode).
	/// </summary>
	public virtual void SetEndTime(double _arg)
	{
		vtkAnimationCue_SetEndTime_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationCue_SetStartTime_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the Start time for this cue.
	/// When the current time is &gt;= StartTime, the Cue is in
	/// ACTIVE state. if Current time i &lt; StartTime, the Cue is in
	/// UNINITIALIZED state. Whenever the cue enters the ACTIVE state from
	/// an INACTIVE state, it triggers the StartEvent.
	/// The Start time is in seconds relative to the start of the
	/// container Scene (when in Relative time mode) or is normalized
	/// over the span of the container Scene (when in Normalized time mode).
	/// </summary>
	public virtual void SetStartTime(double _arg)
	{
		vtkAnimationCue_SetStartTime_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationCue_SetTimeMode_20(HandleRef pThis, int mode);

	/// <summary>
	/// Get/Set the time mode. In Normalized mode, the start and end
	/// times of the cue are normalized [0,1] with respect to the start and
	/// end times of the container scene. In Relative mode the start and end
	/// time of the cue are specified in offset seconds relative to the
	/// start time of the container scene.
	/// </summary>
	public virtual void SetTimeMode(int mode)
	{
		vtkAnimationCue_SetTimeMode_20(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationCue_SetTimeModeToNormalized_21(HandleRef pThis);

	/// <summary>
	/// Get/Set the time mode. In Normalized mode, the start and end
	/// times of the cue are normalized [0,1] with respect to the start and
	/// end times of the container scene. In Relative mode the start and end
	/// time of the cue are specified in offset seconds relative to the
	/// start time of the container scene.
	/// </summary>
	public void SetTimeModeToNormalized()
	{
		vtkAnimationCue_SetTimeModeToNormalized_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationCue_SetTimeModeToRelative_22(HandleRef pThis);

	/// <summary>
	/// Get/Set the time mode. In Normalized mode, the start and end
	/// times of the cue are normalized [0,1] with respect to the start and
	/// end times of the container scene. In Relative mode the start and end
	/// time of the cue are specified in offset seconds relative to the
	/// start time of the container scene.
	/// </summary>
	public void SetTimeModeToRelative()
	{
		vtkAnimationCue_SetTimeModeToRelative_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationCue_Tick_23(HandleRef pThis, double currenttime, double deltatime, double clocktime);

	/// <summary>
	/// Indicates a tick or point in time in the animation.
	/// Triggers a Tick event if currenttime &gt;= StartTime and
	/// currenttime &lt;= EndTime.
	/// Whenever the state of the cue changes,
	/// either StartEvent or EndEvent is triggered depending upon
	/// whether the cue entered Active state or quit active state respectively.
	/// The current time is relative to the start of the container Scene
	/// (when in Relative time mode) or is normalized
	/// over the span of the container Scene (when in Normalized time mode).
	/// deltatime is the time since last call to Tick. deltatime also can be in seconds
	/// relative to the start of the container Scene or normalized depending upon the
	/// cue's Time mode.
	/// clocktime is the time from the scene i.e. it does not depend on the time
	/// mode for the cue.
	/// For the first call to Tick
	/// after a call to Initialize(), the deltatime is 0;
	/// </summary>
	public virtual void Tick(double currenttime, double deltatime, double clocktime)
	{
		vtkAnimationCue_Tick_23(GetCppThis(), currenttime, deltatime, clocktime);
	}
}
