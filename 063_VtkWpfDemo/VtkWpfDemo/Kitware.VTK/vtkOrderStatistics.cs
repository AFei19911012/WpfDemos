using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOrderStatistics
/// </summary>
/// <remarks>
///    A class for univariate order statistics
///
///
/// Given a selection of columns of interest in an input data table, this
/// class provides the following functionalities, depending on the
/// execution mode it is executed in:
/// * Learn: calculate histogram.
/// * Derive: calculate PDFs and arbitrary quantiles. Provide specific names when 5-point
///   statistics (minimum, 1st quartile, median, third quartile, maximum) requested.
/// * Assess: given an input data set and a set of q-quantiles, label each datum
///   either with the quantile interval to which it belongs, or 0 if it is smaller
///   than smaller quantile, or q if it is larger than largest quantile.
/// * Test: calculate Kolmogorov-Smirnov goodness-of-fit statistic between CDF based on
///   model quantiles, and empirical CDF
///
/// @par Thanks:
/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
/// for implementing this class.
/// Updated by Philippe Pebay, Kitware SAS 2012
/// </remarks>
public class vtkOrderStatistics : vtkStatisticsAlgorithm
{
	/// <summary>
	/// The type of quantile definition.
	/// </summary>
	public enum QuantileDefinitionType
	{
		/// <summary>enum member</summary>
		InverseCDF,
		/// <summary>enum member</summary>
		InverseCDFAveragedSteps,
		/// <summary>enum member</summary>
		NearestObservation
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOrderStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOrderStatistics()
	{
		MRClassNameKey = "class vtkOrderStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrderStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOrderStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOrderStatistics New()
	{
		vtkOrderStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOrderStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOrderStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// NB: not implemented
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkOrderStatistics_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOrderStatistics_GetGhostsToSkip_02(HandleRef pThis);

	/// <summary>
	/// If there is a ghost array in the input, then ghosts matching `GhostsToSkip` mask
	/// will be skipped. It is set to 0xff by default (every ghosts types are skipped).
	///
	/// @sa
	/// vtkDataSetAttributes
	/// vtkFieldData
	/// vtkPointData
	/// vtkCellData
	/// </summary>
	public virtual byte GetGhostsToSkip()
	{
		return vtkOrderStatistics_GetGhostsToSkip_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderStatistics_GetMaximumHistogramSize_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum histogram size.
	/// This maximum size is enforced only when Quantize is TRUE.
	/// </summary>
	public virtual long GetMaximumHistogramSize()
	{
		return vtkOrderStatistics_GetMaximumHistogramSize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderStatistics_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOrderStatistics_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderStatistics_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOrderStatistics_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderStatistics_GetNumberOfIntervals_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of quantiles (with uniform spacing).
	/// </summary>
	public virtual long GetNumberOfIntervals()
	{
		return vtkOrderStatistics_GetNumberOfIntervals_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderStatistics_GetQuantileDefinition_07(HandleRef pThis);

	/// <summary>
	/// Get the quantile definition.
	/// </summary>
	public long GetQuantileDefinition()
	{
		return vtkOrderStatistics_GetQuantileDefinition_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOrderStatistics_GetQuantize_08(HandleRef pThis);

	/// <summary>
	/// Set/Get whether quantization will be allowed to enforce maximum histogram size.
	/// </summary>
	public virtual bool GetQuantize()
	{
		return (vtkOrderStatistics_GetQuantize_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderStatistics_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOrderStatistics_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderStatistics_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOrderStatistics_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderStatistics_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOrderStatistics NewInstance()
	{
		vtkOrderStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderStatistics_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderStatistics_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOrderStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkOrderStatistics vtkOrderStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderStatistics_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOrderStatistics2 = (vtkOrderStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOrderStatistics2.Register(null);
			}
		}
		return vtkOrderStatistics2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderStatistics_SetGhostsToSkip_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// If there is a ghost array in the input, then ghosts matching `GhostsToSkip` mask
	/// will be skipped. It is set to 0xff by default (every ghosts types are skipped).
	///
	/// @sa
	/// vtkDataSetAttributes
	/// vtkFieldData
	/// vtkPointData
	/// vtkCellData
	/// </summary>
	public virtual void SetGhostsToSkip(byte _arg)
	{
		vtkOrderStatistics_SetGhostsToSkip_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderStatistics_SetMaximumHistogramSize_15(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/Get the maximum histogram size.
	/// This maximum size is enforced only when Quantize is TRUE.
	/// </summary>
	public virtual void SetMaximumHistogramSize(long _arg)
	{
		vtkOrderStatistics_SetMaximumHistogramSize_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderStatistics_SetNumberOfIntervals_16(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/Get the number of quantiles (with uniform spacing).
	/// </summary>
	public virtual void SetNumberOfIntervals(long _arg)
	{
		vtkOrderStatistics_SetNumberOfIntervals_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOrderStatistics_SetParameter_17(HandleRef pThis, string parameter, int index, HandleRef value);

	/// <summary>
	/// A convenience method (in particular for access from other applications) to
	/// set parameter values.
	/// Return true if setting of requested parameter name was executed, false otherwise.
	/// </summary>
	public override bool SetParameter(string parameter, int index, vtkVariant value)
	{
		return (vtkOrderStatistics_SetParameter_17(GetCppThis(), parameter, index, value?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderStatistics_SetQuantileDefinition_18(HandleRef pThis, QuantileDefinitionType _arg);

	/// <summary>
	/// Set the quantile definition.
	/// </summary>
	public virtual void SetQuantileDefinition(QuantileDefinitionType _arg)
	{
		vtkOrderStatistics_SetQuantileDefinition_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderStatistics_SetQuantileDefinition_19(HandleRef pThis, int arg0);

	/// <summary>
	/// Set the quantile definition.
	/// </summary>
	public void SetQuantileDefinition(int arg0)
	{
		vtkOrderStatistics_SetQuantileDefinition_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderStatistics_SetQuantize_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether quantization will be allowed to enforce maximum histogram size.
	/// </summary>
	public virtual void SetQuantize(bool _arg)
	{
		vtkOrderStatistics_SetQuantize_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
