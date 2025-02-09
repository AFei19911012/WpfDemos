using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderTimerLog
/// </summary>
/// <remarks>
///    Asynchronously measures GPU execution times for a series of events.
///
/// This class measures the time it takes for events to occur on the GPU by
/// posting timing events into the rendering command stream. This can be used
/// to compute the time spent doing work on the GPU without stalling the
/// CPU.
///
/// To aid asynchronous usage, this class uses the concepts "Event" and "Frame",
/// where a Frame is a logical collection of Events. The timer log can manage
/// multiple Frames at a time:
/// - The current Frame, where new Events are created.
/// - Pending Frames, for which all Events have been marked, but the results are
///   not available (the timer requests are still waiting to be processed by the
///   graphics device).
/// - Ready Frames, which have been completed by the graphics device and may be
///   retrieved.
///
/// Call MarkFrame() to begin a new Frame. This pushes the current Frame to the
/// collection of pending Frames, and creates a new one to store future Events.
///
/// Call MarkStartEvent() and MarkEndEvent() to mark the beginning and end of
/// an Event. These Events may be nested, but all child Events must have their
/// end marked before the parent Event ends.
///
/// Use FrameReady() and PopFirstReadyFrame() to check for completed Frames and
/// retrieve results.
///
/// This is currently only implemented for the OpenGL2 backend. The IsSupported()
/// method can be used to detect if there is a valid implementation available.
/// </remarks>
public class vtkRenderTimerLog : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderTimerLog";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderTimerLog()
	{
		MRClassNameKey = "class vtkRenderTimerLog";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderTimerLog"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderTimerLog(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderTimerLog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// RAII struct for logging events. Such events start when
	/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
	/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
	/// </summary>
	public new static vtkRenderTimerLog New()
	{
		vtkRenderTimerLog result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderTimerLog_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// RAII struct for logging events. Such events start when
	/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
	/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
	/// </summary>
	public vtkRenderTimerLog()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderTimerLog_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkRenderTimerLog_FrameReady_01(HandleRef pThis);

	/// <summary>
	/// Returns true if there are any frames ready with complete timing info.
	/// </summary>
	public virtual bool FrameReady()
	{
		return (vtkRenderTimerLog_FrameReady_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkRenderTimerLog_GetFrameLimit_02(HandleRef pThis);

	/// <summary>
	/// If there are more than FrameLimit frames pending/ready, drop the old ones
	/// until we are under this limit. Prevents things from backing up.
	/// Default is 32. Set to 0 to disable. @{
	/// </summary>
	public virtual uint GetFrameLimit()
	{
		return vtkRenderTimerLog_GetFrameLimit_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderTimerLog_GetLoggingEnabled_03(HandleRef pThis);

	/// <summary>
	/// If false, no events are recorded. Default is false. @{ 
	/// </summary>
	public virtual bool GetLoggingEnabled()
	{
		return (vtkRenderTimerLog_GetLoggingEnabled_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderTimerLog_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// RAII struct for logging events. Such events start when
	/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
	/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderTimerLog_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderTimerLog_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// RAII struct for logging events. Such events start when
	/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
	/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderTimerLog_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderTimerLog_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// RAII struct for logging events. Such events start when
	/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
	/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderTimerLog_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderTimerLog_IsSupported_07(HandleRef pThis);

	/// <summary>
	/// Returns true if stream timings are implemented for the current graphics
	/// backend.
	/// </summary>
	public virtual bool IsSupported()
	{
		return (vtkRenderTimerLog_IsSupported_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderTimerLog_IsTypeOf_08(string type);

	/// <summary>
	/// RAII struct for logging events. Such events start when
	/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
	/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderTimerLog_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderTimerLog_LoggingEnabledOff_09(HandleRef pThis);

	/// <summary>
	/// If false, no events are recorded. Default is false. @{ 
	/// </summary>
	public virtual void LoggingEnabledOff()
	{
		vtkRenderTimerLog_LoggingEnabledOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderTimerLog_LoggingEnabledOn_10(HandleRef pThis);

	/// <summary>
	/// If false, no events are recorded. Default is false. @{ 
	/// </summary>
	public virtual void LoggingEnabledOn()
	{
		vtkRenderTimerLog_LoggingEnabledOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderTimerLog_MarkEndEvent_11(HandleRef pThis);

	/// <summary>
	/// Mark the beginning or end of an event. @{
	/// </summary>
	public virtual void MarkEndEvent()
	{
		vtkRenderTimerLog_MarkEndEvent_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderTimerLog_MarkFrame_12(HandleRef pThis);

	/// <summary>
	/// Call to mark the start of a new frame, or the end of an old one. Does
	/// nothing if no events have been recorded in the current frame.
	/// </summary>
	public virtual void MarkFrame()
	{
		vtkRenderTimerLog_MarkFrame_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderTimerLog_MarkStartEvent_13(HandleRef pThis, string name);

	/// <summary>
	/// Mark the beginning or end of an event. @{
	/// </summary>
	public virtual void MarkStartEvent(string name)
	{
		vtkRenderTimerLog_MarkStartEvent_13(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderTimerLog_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// RAII struct for logging events. Such events start when
	/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
	/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
	/// </summary>
	public new vtkRenderTimerLog NewInstance()
	{
		vtkRenderTimerLog result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderTimerLog_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderTimerLog_ReleaseGraphicsResources_16(HandleRef pThis);

	/// <summary>
	/// Releases any resources allocated on the graphics device.
	/// </summary>
	public virtual void ReleaseGraphicsResources()
	{
		vtkRenderTimerLog_ReleaseGraphicsResources_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderTimerLog_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// RAII struct for logging events. Such events start when
	/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
	/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
	/// </summary>
	public new static vtkRenderTimerLog SafeDownCast(vtkObjectBase o)
	{
		vtkRenderTimerLog vtkRenderTimerLog2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderTimerLog_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderTimerLog2 = (vtkRenderTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderTimerLog2.Register(null);
			}
		}
		return vtkRenderTimerLog2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderTimerLog_SetFrameLimit_18(HandleRef pThis, uint _arg);

	/// <summary>
	/// If there are more than FrameLimit frames pending/ready, drop the old ones
	/// until we are under this limit. Prevents things from backing up.
	/// Default is 32. Set to 0 to disable. @{
	/// </summary>
	public virtual void SetFrameLimit(uint _arg)
	{
		vtkRenderTimerLog_SetFrameLimit_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderTimerLog_SetLoggingEnabled_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// If false, no events are recorded. Default is false. @{ 
	/// </summary>
	public virtual void SetLoggingEnabled(bool _arg)
	{
		vtkRenderTimerLog_SetLoggingEnabled_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
