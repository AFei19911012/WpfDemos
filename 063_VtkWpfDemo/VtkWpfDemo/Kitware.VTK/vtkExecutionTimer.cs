using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExecutionTimer
/// </summary>
/// <remarks>
///    Time filter execution
///
///
///
/// This object monitors a single filter for StartEvent and EndEvent.
/// Each time it hears StartEvent it records the time.  Each time it
/// hears EndEvent it measures the elapsed time (both CPU and
/// wall-clock) since the most recent StartEvent.  Internally we use
/// vtkTimerLog for measurements.
///
/// By default we simply store the elapsed time.  You are welcome to
/// subclass and override TimerFinished() to do anything you want.
/// </remarks>
public class vtkExecutionTimer : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExecutionTimer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExecutionTimer()
	{
		MRClassNameKey = "class vtkExecutionTimer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutionTimer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExecutionTimer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutionTimer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a new timer with no attached filter.  Use SetFilter()
	/// to specify the vtkAlgorithm whose execution you want to time.
	/// </summary>
	public new static vtkExecutionTimer New()
	{
		vtkExecutionTimer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutionTimer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExecutionTimer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a new timer with no attached filter.  Use SetFilter()
	/// to specify the vtkAlgorithm whose execution you want to time.
	/// </summary>
	public vtkExecutionTimer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExecutionTimer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExecutionTimer_GetElapsedCPUTime_01(HandleRef pThis);

	/// <summary>
	/// Get the total CPU time (in seconds) that elapsed between
	/// StartEvent and EndEvent.  This is undefined before the filter has
	/// finished executing.
	/// </summary>
	public virtual double GetElapsedCPUTime()
	{
		return vtkExecutionTimer_GetElapsedCPUTime_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExecutionTimer_GetElapsedWallClockTime_02(HandleRef pThis);

	/// <summary>
	/// Get the total wall clock time (in seconds) that elapsed between
	/// StartEvent and EndEvent.  This is undefined before the filter has
	/// finished executing.
	/// </summary>
	public virtual double GetElapsedWallClockTime()
	{
		return vtkExecutionTimer_GetElapsedWallClockTime_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutionTimer_GetFilter_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the filter to be monitored.  The only real constraint
	/// here is that the vtkExecutive associated with the filter must
	/// fire StartEvent and EndEvent before and after the filter is
	/// executed.  All VTK executives should do this.
	/// </summary>
	public virtual vtkAlgorithm GetFilter()
	{
		vtkAlgorithm vtkAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutionTimer_GetFilter_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithm2 = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithm2.Register(null);
			}
		}
		return vtkAlgorithm2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExecutionTimer_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExecutionTimer_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExecutionTimer_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExecutionTimer_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutionTimer_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExecutionTimer_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExecutionTimer_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExecutionTimer_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutionTimer_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExecutionTimer NewInstance()
	{
		vtkExecutionTimer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutionTimer_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExecutionTimer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExecutionTimer_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExecutionTimer SafeDownCast(vtkObjectBase o)
	{
		vtkExecutionTimer vtkExecutionTimer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExecutionTimer_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExecutionTimer2 = (vtkExecutionTimer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExecutionTimer2.Register(null);
			}
		}
		return vtkExecutionTimer2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExecutionTimer_SetFilter_11(HandleRef pThis, HandleRef filter);

	/// <summary>
	/// Set/get the filter to be monitored.  The only real constraint
	/// here is that the vtkExecutive associated with the filter must
	/// fire StartEvent and EndEvent before and after the filter is
	/// executed.  All VTK executives should do this.
	/// </summary>
	public void SetFilter(vtkAlgorithm filter)
	{
		vtkExecutionTimer_SetFilter_11(GetCppThis(), filter?.GetCppThis() ?? default(HandleRef));
	}
}
