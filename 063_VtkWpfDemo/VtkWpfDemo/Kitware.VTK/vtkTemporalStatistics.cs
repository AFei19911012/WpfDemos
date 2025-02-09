using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalStatistics
/// </summary>
/// <remarks>
///    Compute statistics of point or cell data as it changes over time
///
///
///
/// Given an input that changes over time, vtkTemporalStatistics looks at the
/// data for each time step and computes some statistical information of how a
/// point or cell variable changes over time.  For example, vtkTemporalStatistics
/// can compute the average value of "pressure" over time of each point.
///
/// Note that this filter will require the upstream filter to be run on every
/// time step that it reports that it can compute.  This may be a time consuming
/// operation.
///
/// vtkTemporalStatistics ignores the temporal spacing.  Each timestep will be
/// weighted the same regardless of how long of an interval it is to the next
/// timestep.  Thus, the average statistic may be quite different from an
/// integration of the variable if the time spacing varies.
///
/// @par Thanks:
/// </remarks>
/// <seealso>
/// This class was originally written by Kenneth Moreland (kmorelndia.gov)
/// from Sandia National Laboratories.
///
/// </seealso>
public class vtkTemporalStatistics : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalStatistics()
	{
		MRClassNameKey = "class vtkTemporalStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkTemporalStatistics New()
	{
		vtkTemporalStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkTemporalStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_ComputeAverageOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the average values over time.  On by
	/// default.  The resulting array names have "_average" appended to them.
	/// </summary>
	public virtual void ComputeAverageOff()
	{
		vtkTemporalStatistics_ComputeAverageOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_ComputeAverageOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the average values over time.  On by
	/// default.  The resulting array names have "_average" appended to them.
	/// </summary>
	public virtual void ComputeAverageOn()
	{
		vtkTemporalStatistics_ComputeAverageOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_ComputeMaximumOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the maximum values over time.  On by
	/// default.  The resulting array names have "_maximum" appended to them.
	/// </summary>
	public virtual void ComputeMaximumOff()
	{
		vtkTemporalStatistics_ComputeMaximumOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_ComputeMaximumOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the maximum values over time.  On by
	/// default.  The resulting array names have "_maximum" appended to them.
	/// </summary>
	public virtual void ComputeMaximumOn()
	{
		vtkTemporalStatistics_ComputeMaximumOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_ComputeMinimumOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the minimum values over time.  On by
	/// default.  The resulting array names have "_minimum" appended to them.
	/// </summary>
	public virtual void ComputeMinimumOff()
	{
		vtkTemporalStatistics_ComputeMinimumOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_ComputeMinimumOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the minimum values over time.  On by
	/// default.  The resulting array names have "_minimum" appended to them.
	/// </summary>
	public virtual void ComputeMinimumOn()
	{
		vtkTemporalStatistics_ComputeMinimumOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_ComputeStandardDeviationOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the maximum values over time.  On by
	/// default.  The resulting array names have "_maximum" appended to them.
	/// </summary>
	public virtual void ComputeStandardDeviationOff()
	{
		vtkTemporalStatistics_ComputeStandardDeviationOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_ComputeStandardDeviationOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the maximum values over time.  On by
	/// default.  The resulting array names have "_maximum" appended to them.
	/// </summary>
	public virtual void ComputeStandardDeviationOn()
	{
		vtkTemporalStatistics_ComputeStandardDeviationOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalStatistics_GetComputeAverage_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the average values over time.  On by
	/// default.  The resulting array names have "_average" appended to them.
	/// </summary>
	public virtual int GetComputeAverage()
	{
		return vtkTemporalStatistics_GetComputeAverage_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalStatistics_GetComputeMaximum_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the maximum values over time.  On by
	/// default.  The resulting array names have "_maximum" appended to them.
	/// </summary>
	public virtual int GetComputeMaximum()
	{
		return vtkTemporalStatistics_GetComputeMaximum_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalStatistics_GetComputeMinimum_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the minimum values over time.  On by
	/// default.  The resulting array names have "_minimum" appended to them.
	/// </summary>
	public virtual int GetComputeMinimum()
	{
		return vtkTemporalStatistics_GetComputeMinimum_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalStatistics_GetComputeStandardDeviation_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of the maximum values over time.  On by
	/// default.  The resulting array names have "_maximum" appended to them.
	/// </summary>
	public virtual int GetComputeStandardDeviation()
	{
		return vtkTemporalStatistics_GetComputeStandardDeviation_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalStatistics_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalStatistics_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalStatistics_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalStatistics_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalStatistics_IsA_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalStatistics_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalStatistics_IsTypeOf_16(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalStatistics_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalStatistics_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkTemporalStatistics NewInstance()
	{
		vtkTemporalStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalStatistics_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalStatistics_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkTemporalStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalStatistics vtkTemporalStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalStatistics_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalStatistics2 = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalStatistics2.Register(null);
			}
		}
		return vtkTemporalStatistics2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_SetComputeAverage_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the computation of the average values over time.  On by
	/// default.  The resulting array names have "_average" appended to them.
	/// </summary>
	public virtual void SetComputeAverage(int _arg)
	{
		vtkTemporalStatistics_SetComputeAverage_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_SetComputeMaximum_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the computation of the maximum values over time.  On by
	/// default.  The resulting array names have "_maximum" appended to them.
	/// </summary>
	public virtual void SetComputeMaximum(int _arg)
	{
		vtkTemporalStatistics_SetComputeMaximum_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_SetComputeMinimum_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the computation of the minimum values over time.  On by
	/// default.  The resulting array names have "_minimum" appended to them.
	/// </summary>
	public virtual void SetComputeMinimum(int _arg)
	{
		vtkTemporalStatistics_SetComputeMinimum_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalStatistics_SetComputeStandardDeviation_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the computation of the maximum values over time.  On by
	/// default.  The resulting array names have "_maximum" appended to them.
	/// </summary>
	public virtual void SetComputeStandardDeviation(int _arg)
	{
		vtkTemporalStatistics_SetComputeStandardDeviation_23(GetCppThis(), _arg);
	}
}
