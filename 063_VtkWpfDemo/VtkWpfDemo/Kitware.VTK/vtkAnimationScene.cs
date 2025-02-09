using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAnimationScene
/// </summary>
/// <remarks>
///    the animation scene manager.
///
/// vtkAnimationCue and vtkAnimationScene provide the framework to support
/// animations in VTK. vtkAnimationCue represents an entity that changes/
/// animates with time, while vtkAnimationScene represents scene or setup
/// for the animation, which consists of individual cues or other scenes.
///
/// A scene can be played in real time mode, or as a sequence of frames
/// 1/frame rate apart in time.
/// </remarks>
/// <seealso>
///
/// vtkAnimationCue
/// </seealso>
public class vtkAnimationScene : vtkAnimationCue
{
	/// <summary>
	/// Returns if the animation is being played.
	/// </summary>
	public enum PlayModes
	{
		/// <summary>enum member</summary>
		PLAYMODE_REALTIME = 1,
		/// <summary>enum member</summary>
		PLAYMODE_SEQUENCE = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAnimationScene";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAnimationScene()
	{
		MRClassNameKey = "class vtkAnimationScene";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnimationScene"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAnimationScene(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimationScene_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnimationScene New()
	{
		vtkAnimationScene result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimationScene_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAnimationScene()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAnimationScene_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_AddCue_01(HandleRef pThis, HandleRef cue);

	/// <summary>
	/// Add/Remove an AnimationCue to/from the Scene.
	/// It's an error to add a cue twice to the Scene.
	/// </summary>
	public void AddCue(vtkAnimationCue cue)
	{
		vtkAnimationScene_AddCue_01(GetCppThis(), cue?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAnimationScene_GetFrameRate_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the frame rate (in frames per second).
	/// This parameter affects only in the Sequence mode. The time interval
	/// indicated to each cue on every tick is progressed by 1/frame-rate seconds.
	/// </summary>
	public virtual double GetFrameRate()
	{
		return vtkAnimationScene_GetFrameRate_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationScene_GetLoop_03(HandleRef pThis);

	/// <summary>
	/// Enable/Disable animation loop.
	/// </summary>
	public virtual int GetLoop()
	{
		return vtkAnimationScene_GetLoop_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationScene_GetNumberOfCues_04(HandleRef pThis);

	/// <summary>
	/// Add/Remove an AnimationCue to/from the Scene.
	/// It's an error to add a cue twice to the Scene.
	/// </summary>
	public int GetNumberOfCues()
	{
		return vtkAnimationScene_GetNumberOfCues_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnimationScene_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAnimationScene_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAnimationScene_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAnimationScene_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationScene_GetPlayMode_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the PlayMode for running/playing the animation scene.
	/// In the Sequence mode, all the frames are generated one after the other.
	/// The time reported to each Tick of the constituent cues (during Play) is
	/// incremented by 1/frame rate, irrespective of the current time.
	/// In the RealTime mode, time indicates the instance in time.
	/// </summary>
	public virtual int GetPlayMode()
	{
		return vtkAnimationScene_GetPlayMode_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationScene_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAnimationScene_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationScene_IsInPlay_09(HandleRef pThis);

	/// <summary>
	/// Returns if the animation is being played.
	/// </summary>
	public int IsInPlay()
	{
		return vtkAnimationScene_IsInPlay_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAnimationScene_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAnimationScene_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimationScene_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAnimationScene NewInstance()
	{
		vtkAnimationScene result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimationScene_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_Play_13(HandleRef pThis);

	/// <summary>
	/// Starts playing the animation scene. Fires a vtkCommand::StartEvent
	/// before play beings and vtkCommand::EndEvent after play ends.
	/// </summary>
	public virtual void Play()
	{
		vtkAnimationScene_Play_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_RemoveAllCues_14(HandleRef pThis);

	/// <summary>
	/// Add/Remove an AnimationCue to/from the Scene.
	/// It's an error to add a cue twice to the Scene.
	/// </summary>
	public void RemoveAllCues()
	{
		vtkAnimationScene_RemoveAllCues_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_RemoveCue_15(HandleRef pThis, HandleRef cue);

	/// <summary>
	/// Add/Remove an AnimationCue to/from the Scene.
	/// It's an error to add a cue twice to the Scene.
	/// </summary>
	public void RemoveCue(vtkAnimationCue cue)
	{
		vtkAnimationScene_RemoveCue_15(GetCppThis(), cue?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAnimationScene_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAnimationScene SafeDownCast(vtkObjectBase o)
	{
		vtkAnimationScene vtkAnimationScene2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAnimationScene_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnimationScene2 = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnimationScene2.Register(null);
			}
		}
		return vtkAnimationScene2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_SetAnimationTime_17(HandleRef pThis, double time);

	/// <summary>
	/// Makes the state of the scene same as the given time.
	/// </summary>
	public void SetAnimationTime(double time)
	{
		vtkAnimationScene_SetAnimationTime_17(GetCppThis(), time);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_SetFrameRate_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the frame rate (in frames per second).
	/// This parameter affects only in the Sequence mode. The time interval
	/// indicated to each cue on every tick is progressed by 1/frame-rate seconds.
	/// </summary>
	public virtual void SetFrameRate(double _arg)
	{
		vtkAnimationScene_SetFrameRate_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_SetLoop_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable animation loop.
	/// </summary>
	public virtual void SetLoop(int _arg)
	{
		vtkAnimationScene_SetLoop_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_SetModeToRealTime_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the PlayMode for running/playing the animation scene.
	/// In the Sequence mode, all the frames are generated one after the other.
	/// The time reported to each Tick of the constituent cues (during Play) is
	/// incremented by 1/frame rate, irrespective of the current time.
	/// In the RealTime mode, time indicates the instance in time.
	/// </summary>
	public void SetModeToRealTime()
	{
		vtkAnimationScene_SetModeToRealTime_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_SetModeToSequence_21(HandleRef pThis);

	/// <summary>
	/// Get/Set the PlayMode for running/playing the animation scene.
	/// In the Sequence mode, all the frames are generated one after the other.
	/// The time reported to each Tick of the constituent cues (during Play) is
	/// incremented by 1/frame rate, irrespective of the current time.
	/// In the RealTime mode, time indicates the instance in time.
	/// </summary>
	public void SetModeToSequence()
	{
		vtkAnimationScene_SetModeToSequence_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_SetPlayMode_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the PlayMode for running/playing the animation scene.
	/// In the Sequence mode, all the frames are generated one after the other.
	/// The time reported to each Tick of the constituent cues (during Play) is
	/// incremented by 1/frame rate, irrespective of the current time.
	/// In the RealTime mode, time indicates the instance in time.
	/// </summary>
	public virtual void SetPlayMode(int _arg)
	{
		vtkAnimationScene_SetPlayMode_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_SetTimeMode_23(HandleRef pThis, int mode);

	/// <summary>
	/// Overridden to allow change to Normalized mode only
	/// if none of the constituent cues is in Relative time mode.
	/// </summary>
	public override void SetTimeMode(int mode)
	{
		vtkAnimationScene_SetTimeMode_23(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAnimationScene_Stop_24(HandleRef pThis);

	/// <summary>
	/// Stops the animation scene that is running.
	/// </summary>
	public void Stop()
	{
		vtkAnimationScene_Stop_24(GetCppThis());
	}
}
