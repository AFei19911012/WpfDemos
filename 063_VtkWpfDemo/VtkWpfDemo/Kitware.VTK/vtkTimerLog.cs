using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTimerLog
/// </summary>
/// <remarks>
///    Timer support and logging
///
/// vtkTimerLog contains walltime and cputime measurements associated
/// with a given event.  These results can be later analyzed when
/// "dumping out" the table.
///
/// In addition, vtkTimerLog allows the user to simply get the current
/// time, and to start/stop a simple timer separate from the timing
/// table logging.
/// </remarks>
public class vtkTimerLog : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTimerLog";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTimerLog()
	{
		MRClassNameKey = "class vtkTimerLog";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimerLog"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTimerLog(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimerLog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTimerLog New()
	{
		vtkTimerLog result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimerLog_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTimerLog()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTimerLog_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_CleanupLog_01();

	/// <summary>
	/// Remove timer log.
	/// </summary>
	public static void CleanupLog()
	{
		vtkTimerLog_CleanupLog_01();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_DumpLog_02(string filename);

	/// <summary>
	/// Write the timing table out to a file.  Calculate some helpful
	/// statistics (deltas and percentages) in the process.
	/// </summary>
	public static void DumpLog(string filename)
	{
		vtkTimerLog_DumpLog_02(filename);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_FormatAndMarkEvent_03(string format);

	/// <summary>
	/// Record a timing event.  The event is represented by a formatted
	/// string.  The internal buffer is 4096 bytes and will truncate anything longer.
	/// </summary>
	public static void FormatAndMarkEvent(string format)
	{
		vtkTimerLog_FormatAndMarkEvent_03(format);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTimerLog_GetCPUTime_04();

	/// <summary>
	/// Returns the CPU time for this process
	/// On Win32 platforms this actually returns wall time.
	/// </summary>
	public static double GetCPUTime()
	{
		return vtkTimerLog_GetCPUTime_04();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTimerLog_GetElapsedTime_05(HandleRef pThis);

	/// <summary>
	/// Returns the difference between StartTime and EndTime as
	/// a doubleing point value indicating the elapsed time in seconds.
	/// </summary>
	public double GetElapsedTime()
	{
		return vtkTimerLog_GetElapsedTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimerLog_GetEventIndent_06(int i);

	/// <summary>
	/// Programmatic access to events.  Indexed from 0 to num-1.
	/// </summary>
	public static int GetEventIndent(int i)
	{
		return vtkTimerLog_GetEventIndent_06(i);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimerLog_GetEventString_07(int i);

	/// <summary>
	/// Programmatic access to events.  Indexed from 0 to num-1.
	/// </summary>
	public static string GetEventString(int i)
	{
		return Marshal.PtrToStringAnsi(vtkTimerLog_GetEventString_07(i));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTimerLog_GetEventWallTime_08(int i);

	/// <summary>
	/// Programmatic access to events.  Indexed from 0 to num-1.
	/// </summary>
	public static double GetEventWallTime(int i)
	{
		return vtkTimerLog_GetEventWallTime_08(i);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimerLog_GetLogging_09();

	/// <summary>
	/// This flag will turn logging of events off or on.
	/// By default, logging is on.
	/// </summary>
	public static int GetLogging()
	{
		return vtkTimerLog_GetLogging_09();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimerLog_GetMaxEntries_10();

	/// <summary>
	/// Set/Get the maximum number of entries allowed in the timer log
	/// </summary>
	public static int GetMaxEntries()
	{
		return vtkTimerLog_GetMaxEntries_10();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimerLog_GetNumberOfEvents_11();

	/// <summary>
	/// Programmatic access to events.  Indexed from 0 to num-1.
	/// </summary>
	public static int GetNumberOfEvents()
	{
		return vtkTimerLog_GetNumberOfEvents_11();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTimerLog_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTimerLog_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTimerLog_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTimerLog_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTimerLog_GetUniversalTime_14();

	/// <summary>
	/// Returns the elapsed number of seconds since 00:00:00 Coordinated Universal
	/// Time (UTC), Thursday, 1 January 1970. This is also called Unix Time.
	/// </summary>
	public static double GetUniversalTime()
	{
		return vtkTimerLog_GetUniversalTime_14();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_InsertTimedEvent_15(string EventString, double time, int cpuTicks);

	/// <summary>
	/// Insert an event with a known wall time value (in seconds)
	/// and cpuTicks.
	/// </summary>
	public static void InsertTimedEvent(string EventString, double time, int cpuTicks)
	{
		vtkTimerLog_InsertTimedEvent_15(EventString, time, cpuTicks);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimerLog_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTimerLog_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimerLog_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTimerLog_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_LoggingOff_18();

	/// <summary>
	/// This flag will turn logging of events off or on.
	/// By default, logging is on.
	/// </summary>
	public static void LoggingOff()
	{
		vtkTimerLog_LoggingOff_18();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_LoggingOn_19();

	/// <summary>
	/// This flag will turn logging of events off or on.
	/// By default, logging is on.
	/// </summary>
	public static void LoggingOn()
	{
		vtkTimerLog_LoggingOn_19();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_MarkEndEvent_20(string EventString);

	/// <summary>
	/// I want to time events, so I am creating this interface to
	/// mark events that have a start and an end.  These events can be,
	/// nested. The standard Dumplog ignores the indents.
	/// </summary>
	public static void MarkEndEvent(string EventString)
	{
		vtkTimerLog_MarkEndEvent_20(EventString);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_MarkEvent_21(string EventString);

	/// <summary>
	/// Record a timing event and capture wall time and cpu ticks.
	/// </summary>
	public static void MarkEvent(string EventString)
	{
		vtkTimerLog_MarkEvent_21(EventString);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_MarkStartEvent_22(string EventString);

	/// <summary>
	/// I want to time events, so I am creating this interface to
	/// mark events that have a start and an end.  These events can be,
	/// nested. The standard Dumplog ignores the indents.
	/// </summary>
	public static void MarkStartEvent(string EventString)
	{
		vtkTimerLog_MarkStartEvent_22(EventString);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimerLog_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTimerLog NewInstance()
	{
		vtkTimerLog result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimerLog_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_ResetLog_25();

	/// <summary>
	/// Clear the timing table.  walltime and cputime will also be set
	/// to zero when the first new event is recorded.
	/// </summary>
	public static void ResetLog()
	{
		vtkTimerLog_ResetLog_25();
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimerLog_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTimerLog SafeDownCast(vtkObjectBase o)
	{
		vtkTimerLog vtkTimerLog2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimerLog_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTimerLog2 = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTimerLog2.Register(null);
			}
		}
		return vtkTimerLog2;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_SetLogging_27(int v);

	/// <summary>
	/// This flag will turn logging of events off or on.
	/// By default, logging is on.
	/// </summary>
	public static void SetLogging(int v)
	{
		vtkTimerLog_SetLogging_27(v);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_SetMaxEntries_28(int a);

	/// <summary>
	/// Set/Get the maximum number of entries allowed in the timer log
	/// </summary>
	public static void SetMaxEntries(int a)
	{
		vtkTimerLog_SetMaxEntries_28(a);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_StartTimer_29(HandleRef pThis);

	/// <summary>
	/// Set the StartTime to the current time. Used with GetElapsedTime().
	/// </summary>
	public void StartTimer()
	{
		vtkTimerLog_StartTimer_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimerLog_StopTimer_30(HandleRef pThis);

	/// <summary>
	/// Sets EndTime to the current time. Used with GetElapsedTime().
	/// </summary>
	public void StopTimer()
	{
		vtkTimerLog_StopTimer_30(GetCppThis());
	}
}
