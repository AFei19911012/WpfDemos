using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalShiftScale
/// </summary>
/// <remarks>
///    modify the time range/steps of temporal data
///
/// vtkTemporalShiftScale  modify the time range or time steps of
/// the data without changing the data itself. The data is not resampled
/// by this filter, only the information accompanying the data is modified.
///
/// @par Thanks:
/// Ken Martin (Kitware) and John Bidiscombe of
/// CSCS - Swiss National Supercomputing Centre
/// for creating and contributing this class.
/// For related material, please refer to :
/// John Biddiscombe, Berk Geveci, Ken Martin, Kenneth Moreland, David Thompson,
/// "Time Dependent Processing in a Parallel Pipeline Architecture",
/// IEEE Visualization 2007.
/// </remarks>
public class vtkTemporalShiftScale : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalShiftScale";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalShiftScale()
	{
		MRClassNameKey = "class vtkTemporalShiftScale";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalShiftScale"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalShiftScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalShiftScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalShiftScale New()
	{
		vtkTemporalShiftScale result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalShiftScale_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTemporalShiftScale()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalShiftScale_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTemporalShiftScale_GetMaximumNumberOfPeriods_01(HandleRef pThis);

	/// <summary>
	/// if Periodic time is enabled, this controls how many time periods time is reported
	/// for. A filter cannot output an infinite number of time steps and therefore a finite
	/// number of periods is generated when reporting time.
	/// </summary>
	public virtual double GetMaximumNumberOfPeriods()
	{
		return vtkTemporalShiftScale_GetMaximumNumberOfPeriods_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalShiftScale_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalShiftScale_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalShiftScale_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalShiftScale_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalShiftScale_GetPeriodic_04(HandleRef pThis);

	/// <summary>
	/// If Periodic is true, requests for time will be wrapped around so that
	/// the source appears to be a periodic time source. If data exists for times
	/// {0,N-1}, setting periodic to true will cause time 0 to be produced when time
	/// N, 2N, 2N etc is requested. This effectively gives the source the ability to
	/// generate time data indefinitely in a loop.
	/// When combined with Shift/Scale, the time becomes periodic in the
	/// shifted and scaled time frame of reference.
	/// Note: Since the input time may not start at zero, the wrapping of time
	/// from the end of one period to the start of the next, will subtract the
	/// initial time - a source with T{5..6} repeated periodically will have output
	/// time {5..6..7..8} etc.
	/// </summary>
	public virtual int GetPeriodic()
	{
		return vtkTemporalShiftScale_GetPeriodic_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalShiftScale_GetPeriodicEndCorrection_05(HandleRef pThis);

	/// <summary>
	/// if Periodic time is enabled, this flag determines if the last time step is the same
	/// as the first. If PeriodicEndCorrection is true, then it is assumed that the input
	/// data goes from 0-1 (or whatever scaled/shifted actual time) and time 1 is the
	/// same as time 0 so that steps will be 0,1,2,3...N,1,2,3...N,1,2,3 where step N
	/// is the same as 0 and step 0 is not repeated. When this flag is false
	/// the data is assumed to be literal and output is of the form 0,1,2,3...N,0,1,2,3...
	/// By default this flag is ON
	/// </summary>
	public virtual int GetPeriodicEndCorrection()
	{
		return vtkTemporalShiftScale_GetPeriodicEndCorrection_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTemporalShiftScale_GetPostShift_06(HandleRef pThis);

	/// <summary>
	/// Apply a translation to the time
	/// </summary>
	public virtual double GetPostShift()
	{
		return vtkTemporalShiftScale_GetPostShift_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTemporalShiftScale_GetPreShift_07(HandleRef pThis);

	/// <summary>
	/// Apply a translation to the data before scaling.
	/// To convert T{5,100} to T{0,1} use Preshift=-5, Scale=1/95, PostShift=0
	/// To convert T{5,105} to T{5,10} use Preshift=-5, Scale=5/100, PostShift=5
	/// </summary>
	public virtual double GetPreShift()
	{
		return vtkTemporalShiftScale_GetPreShift_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTemporalShiftScale_GetScale_08(HandleRef pThis);

	/// <summary>
	/// Apply a scale to the time.
	/// </summary>
	public virtual double GetScale()
	{
		return vtkTemporalShiftScale_GetScale_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalShiftScale_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalShiftScale_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalShiftScale_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalShiftScale_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalShiftScale_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTemporalShiftScale NewInstance()
	{
		vtkTemporalShiftScale result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalShiftScale_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_PeriodicEndCorrectionOff_13(HandleRef pThis);

	/// <summary>
	/// if Periodic time is enabled, this flag determines if the last time step is the same
	/// as the first. If PeriodicEndCorrection is true, then it is assumed that the input
	/// data goes from 0-1 (or whatever scaled/shifted actual time) and time 1 is the
	/// same as time 0 so that steps will be 0,1,2,3...N,1,2,3...N,1,2,3 where step N
	/// is the same as 0 and step 0 is not repeated. When this flag is false
	/// the data is assumed to be literal and output is of the form 0,1,2,3...N,0,1,2,3...
	/// By default this flag is ON
	/// </summary>
	public virtual void PeriodicEndCorrectionOff()
	{
		vtkTemporalShiftScale_PeriodicEndCorrectionOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_PeriodicEndCorrectionOn_14(HandleRef pThis);

	/// <summary>
	/// if Periodic time is enabled, this flag determines if the last time step is the same
	/// as the first. If PeriodicEndCorrection is true, then it is assumed that the input
	/// data goes from 0-1 (or whatever scaled/shifted actual time) and time 1 is the
	/// same as time 0 so that steps will be 0,1,2,3...N,1,2,3...N,1,2,3 where step N
	/// is the same as 0 and step 0 is not repeated. When this flag is false
	/// the data is assumed to be literal and output is of the form 0,1,2,3...N,0,1,2,3...
	/// By default this flag is ON
	/// </summary>
	public virtual void PeriodicEndCorrectionOn()
	{
		vtkTemporalShiftScale_PeriodicEndCorrectionOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_PeriodicOff_15(HandleRef pThis);

	/// <summary>
	/// If Periodic is true, requests for time will be wrapped around so that
	/// the source appears to be a periodic time source. If data exists for times
	/// {0,N-1}, setting periodic to true will cause time 0 to be produced when time
	/// N, 2N, 2N etc is requested. This effectively gives the source the ability to
	/// generate time data indefinitely in a loop.
	/// When combined with Shift/Scale, the time becomes periodic in the
	/// shifted and scaled time frame of reference.
	/// Note: Since the input time may not start at zero, the wrapping of time
	/// from the end of one period to the start of the next, will subtract the
	/// initial time - a source with T{5..6} repeated periodically will have output
	/// time {5..6..7..8} etc.
	/// </summary>
	public virtual void PeriodicOff()
	{
		vtkTemporalShiftScale_PeriodicOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_PeriodicOn_16(HandleRef pThis);

	/// <summary>
	/// If Periodic is true, requests for time will be wrapped around so that
	/// the source appears to be a periodic time source. If data exists for times
	/// {0,N-1}, setting periodic to true will cause time 0 to be produced when time
	/// N, 2N, 2N etc is requested. This effectively gives the source the ability to
	/// generate time data indefinitely in a loop.
	/// When combined with Shift/Scale, the time becomes periodic in the
	/// shifted and scaled time frame of reference.
	/// Note: Since the input time may not start at zero, the wrapping of time
	/// from the end of one period to the start of the next, will subtract the
	/// initial time - a source with T{5..6} repeated periodically will have output
	/// time {5..6..7..8} etc.
	/// </summary>
	public virtual void PeriodicOn()
	{
		vtkTemporalShiftScale_PeriodicOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalShiftScale_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalShiftScale SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalShiftScale vtkTemporalShiftScale2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalShiftScale_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalShiftScale2 = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalShiftScale2.Register(null);
			}
		}
		return vtkTemporalShiftScale2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_SetMaximumNumberOfPeriods_18(HandleRef pThis, double _arg);

	/// <summary>
	/// if Periodic time is enabled, this controls how many time periods time is reported
	/// for. A filter cannot output an infinite number of time steps and therefore a finite
	/// number of periods is generated when reporting time.
	/// </summary>
	public virtual void SetMaximumNumberOfPeriods(double _arg)
	{
		vtkTemporalShiftScale_SetMaximumNumberOfPeriods_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_SetPeriodic_19(HandleRef pThis, int _arg);

	/// <summary>
	/// If Periodic is true, requests for time will be wrapped around so that
	/// the source appears to be a periodic time source. If data exists for times
	/// {0,N-1}, setting periodic to true will cause time 0 to be produced when time
	/// N, 2N, 2N etc is requested. This effectively gives the source the ability to
	/// generate time data indefinitely in a loop.
	/// When combined with Shift/Scale, the time becomes periodic in the
	/// shifted and scaled time frame of reference.
	/// Note: Since the input time may not start at zero, the wrapping of time
	/// from the end of one period to the start of the next, will subtract the
	/// initial time - a source with T{5..6} repeated periodically will have output
	/// time {5..6..7..8} etc.
	/// </summary>
	public virtual void SetPeriodic(int _arg)
	{
		vtkTemporalShiftScale_SetPeriodic_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_SetPeriodicEndCorrection_20(HandleRef pThis, int _arg);

	/// <summary>
	/// if Periodic time is enabled, this flag determines if the last time step is the same
	/// as the first. If PeriodicEndCorrection is true, then it is assumed that the input
	/// data goes from 0-1 (or whatever scaled/shifted actual time) and time 1 is the
	/// same as time 0 so that steps will be 0,1,2,3...N,1,2,3...N,1,2,3 where step N
	/// is the same as 0 and step 0 is not repeated. When this flag is false
	/// the data is assumed to be literal and output is of the form 0,1,2,3...N,0,1,2,3...
	/// By default this flag is ON
	/// </summary>
	public virtual void SetPeriodicEndCorrection(int _arg)
	{
		vtkTemporalShiftScale_SetPeriodicEndCorrection_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_SetPostShift_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Apply a translation to the time
	/// </summary>
	public virtual void SetPostShift(double _arg)
	{
		vtkTemporalShiftScale_SetPostShift_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_SetPreShift_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Apply a translation to the data before scaling.
	/// To convert T{5,100} to T{0,1} use Preshift=-5, Scale=1/95, PostShift=0
	/// To convert T{5,105} to T{5,10} use Preshift=-5, Scale=5/100, PostShift=5
	/// </summary>
	public virtual void SetPreShift(double _arg)
	{
		vtkTemporalShiftScale_SetPreShift_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalShiftScale_SetScale_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Apply a scale to the time.
	/// </summary>
	public virtual void SetScale(double _arg)
	{
		vtkTemporalShiftScale_SetScale_23(GetCppThis(), _arg);
	}
}
