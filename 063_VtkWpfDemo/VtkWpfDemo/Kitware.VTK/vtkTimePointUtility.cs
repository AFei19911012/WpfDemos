using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTimePointUtility
/// </summary>
/// <remarks>
///    performs common time operations
///
///
/// vtkTimePointUtility is provides methods to perform common time operations.
/// </remarks>
public class vtkTimePointUtility : vtkObject
{
	/// <summary>
	/// Retrieve the milliseconds from the start of the last second.
	/// </summary>
	public enum ISO8601_DATE_WrapperEnum
	{
		/// <summary>enum member</summary>
		ISO8601_DATE = 2,
		/// <summary>enum member</summary>
		ISO8601_DATETIME = 1,
		/// <summary>enum member</summary>
		ISO8601_DATETIME_MILLIS = 0,
		/// <summary>enum member</summary>
		ISO8601_TIME = 4,
		/// <summary>enum member</summary>
		ISO8601_TIME_MILLIS = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTimePointUtility";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTimePointUtility()
	{
		MRClassNameKey = "class vtkTimePointUtility";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimePointUtility"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTimePointUtility(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimePointUtility_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTimePointUtility New()
	{
		vtkTimePointUtility result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimePointUtility_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTimePointUtility()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTimePointUtility_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkTimePointUtility_DateTimeToTimePoint_01(int year, int month, int day, int hour, int minute, int sec, int millis);

	/// <summary>
	/// Return the time point for a date and time.
	/// </summary>
	public static ulong DateTimeToTimePoint(int year, int month, int day, int hour, int minute, int sec, int millis)
	{
		return vtkTimePointUtility_DateTimeToTimePoint_01(year, month, day, hour, minute, sec, millis);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTimePointUtility_DateToTimePoint_02(int year, int month, int day);

	/// <summary>
	/// Return the time point for 12:00am on a specified day.
	/// </summary>
	public static ulong DateToTimePoint(int year, int month, int day)
	{
		return vtkTimePointUtility_DateToTimePoint_02(year, month, day);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimePointUtility_GetDate_03(ulong time, ref int year, ref int month, ref int day);

	/// <summary>
	/// Retrieve the year, month, and day of a time point.
	/// Everything but the first argument are output parameters.
	/// </summary>
	public static void GetDate(ulong time, ref int year, ref int month, ref int day)
	{
		vtkTimePointUtility_GetDate_03(time, ref year, ref month, ref day);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimePointUtility_GetDateTime_04(ulong time, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second, ref int millis);

	/// <summary>
	/// Retrieve the date and time of a time point.
	/// Everything but the first argument are output parameters.
	/// </summary>
	public static void GetDateTime(ulong time, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second, ref int millis)
	{
		vtkTimePointUtility_GetDateTime_04(time, ref year, ref month, ref day, ref hour, ref minute, ref second, ref millis);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_GetDay_05(ulong time);

	/// <summary>
	/// Retrieve the day of the month from a time point.
	/// </summary>
	public static int GetDay(ulong time)
	{
		return vtkTimePointUtility_GetDay_05(time);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_GetHour_06(ulong time);

	/// <summary>
	/// Retrieve the hour of the day from the time point.
	/// </summary>
	public static int GetHour(ulong time)
	{
		return vtkTimePointUtility_GetHour_06(time);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_GetMillisecond_07(ulong time);

	/// <summary>
	/// Retrieve the milliseconds from the start of the last second.
	/// </summary>
	public static int GetMillisecond(ulong time)
	{
		return vtkTimePointUtility_GetMillisecond_07(time);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_GetMinute_08(ulong time);

	/// <summary>
	/// Retrieve the number of minutes from the start of the last hour.
	/// </summary>
	public static int GetMinute(ulong time)
	{
		return vtkTimePointUtility_GetMinute_08(time);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_GetMonth_09(ulong time);

	/// <summary>
	/// Retrieve the month from a time point.
	/// </summary>
	public static int GetMonth(ulong time)
	{
		return vtkTimePointUtility_GetMonth_09(time);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTimePointUtility_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTimePointUtility_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTimePointUtility_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTimePointUtility_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_GetSecond_12(ulong time);

	/// <summary>
	/// Retrieve the number of seconds from the start of the last minute.
	/// </summary>
	public static int GetSecond(ulong time)
	{
		return vtkTimePointUtility_GetSecond_12(time);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTimePointUtility_GetTime_13(ulong time, ref int hour, ref int minute, ref int second, ref int millis);

	/// <summary>
	/// Retrieve the hour, minute, second, and milliseconds of a time point.
	/// Everything but the first argument are output parameters.
	/// </summary>
	public static void GetTime(ulong time, ref int hour, ref int minute, ref int second, ref int millis)
	{
		vtkTimePointUtility_GetTime_13(time, ref hour, ref minute, ref second, ref millis);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_GetYear_14(ulong time);

	/// <summary>
	/// Retrieve the year from a time point.
	/// </summary>
	public static int GetYear(ulong time)
	{
		return vtkTimePointUtility_GetYear_14(time);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTimePointUtility_ISO8601ToTimePoint_15(string str, IntPtr ok);

	/// <summary>
	/// Converts a ISO8601 string into a VTK timepoint.
	/// The string must follow one of the ISO8601 formats described
	/// in ToISO8601.  To check for a valid format, pass a bool* as
	/// the second argument.  The value will be set to true if the
	/// string was parsed successfully, false otherwise.
	/// </summary>
	public static ulong ISO8601ToTimePoint(string str, IntPtr ok)
	{
		return vtkTimePointUtility_ISO8601ToTimePoint_15(str, ok);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTimePointUtility_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTimePointUtility_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTimePointUtility_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimePointUtility_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTimePointUtility NewInstance()
	{
		vtkTimePointUtility result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimePointUtility_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimePointUtility_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTimePointUtility SafeDownCast(vtkObjectBase o)
	{
		vtkTimePointUtility vtkTimePointUtility2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTimePointUtility_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTimePointUtility2 = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTimePointUtility2.Register(null);
			}
		}
		return vtkTimePointUtility2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTimePointUtility_TimePointToISO8601_21(ulong arg0, int format);

	/// <summary>
	/// Converts a VTK timepoint into one of the following ISO8601
	/// formats.  The default format is ISO8601_DATETIME_MILLIS.
	///
	/// &lt;PRE&gt;
	/// Type                      Format / Example
	/// 0 ISO8601_DATETIME_MILLIS [YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[SSS]
	/// 2006-01-02T03:04:05.678
	/// 1 ISO8601_DATETIME        [YYYY]-[MM]-[DD]T[hh]:[mm]:[ss]
	/// 2006-01-02T03:04:05
	/// 2 ISO8601_DATE            [YYYY]-[MM]-[DD]
	/// 2006-01-02
	/// 3 ISO8601_TIME_MILLIS     [hh]:[mm]:[ss].[SSS]
	/// 03:04:05.678
	/// 4 ISO8601_TIME            [hh]:[mm]:[ss]
	/// 03:04:05
	/// &lt;/PRE&gt;
	/// </summary>
	public static string TimePointToISO8601(ulong arg0, int format)
	{
		return Marshal.PtrToStringAnsi(vtkTimePointUtility_TimePointToISO8601_21(arg0, format));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTimePointUtility_TimeToTimePoint_22(int hour, int minute, int second, int millis);

	/// <summary>
	/// Return the time point for a time of day (the number of milliseconds from 12:00am.
	/// The hour should be from 0-23.
	/// </summary>
	public static ulong TimeToTimePoint(int hour, int minute, int second, int millis)
	{
		return vtkTimePointUtility_TimeToTimePoint_22(hour, minute, second, millis);
	}
}
