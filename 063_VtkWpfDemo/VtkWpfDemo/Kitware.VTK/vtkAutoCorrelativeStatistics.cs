using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAutoCorrelativeStatistics
/// </summary>
/// <remarks>
///    A class for univariate auto-correlative statistics
///
///
/// Given a selection of columns of interest in an input data table, this
/// class provides the following functionalities, depending on the chosen
/// execution options:
/// * Learn: calculate sample mean and M2 aggregates for each variable w.r.t. itself
///   (cf. P. Pebay, Formulas for robust, one-pass parallel computation of covariances
///   and Arbitrary-Order Statistical Moments, Sandia Report SAND2008-6212, Sep 2008,
///   http://infoserve.sandia.gov/sand_doc/2008/086212.pdf for details)
///   for each specified time lag.
/// * Derive: calculate unbiased autocovariance matrix estimators and its determinant,
///   linear regressions, and Pearson correlation coefficient, for each specified
///   time lag.
/// * Assess: given an input data set, two means and a 2x2 covariance matrix,
///   mark each datum with corresponding relative deviation (2-dimensional Mahlanobis
///   distance).
///
///
/// @par Thanks:
/// This class was written by Philippe Pebay, Kitware SAS 2012
/// </remarks>
public class vtkAutoCorrelativeStatistics : vtkStatisticsAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAutoCorrelativeStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAutoCorrelativeStatistics()
	{
		MRClassNameKey = "class vtkAutoCorrelativeStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAutoCorrelativeStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAutoCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAutoCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAutoCorrelativeStatistics New()
	{
		vtkAutoCorrelativeStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAutoCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAutoCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAutoCorrelativeStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAutoCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAutoCorrelativeStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkAutoCorrelativeStatistics_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAutoCorrelativeStatistics_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAutoCorrelativeStatistics_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAutoCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAutoCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAutoCorrelativeStatistics_GetSliceCardinality_04(HandleRef pThis);

	/// <summary>
	/// Set/get the cardinality of the data set at given time, i.e., of
	/// any given time slice. It cannot be negative.
	/// The input data set is assumed to have a cardinality which
	/// is a multiple of this value.
	/// The default is 0, meaning that the user must specify a value
	/// that is consistent with the input data set.
	/// </summary>
	public virtual long GetSliceCardinality()
	{
		return vtkAutoCorrelativeStatistics_GetSliceCardinality_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAutoCorrelativeStatistics_GetSliceCardinalityMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/get the cardinality of the data set at given time, i.e., of
	/// any given time slice. It cannot be negative.
	/// The input data set is assumed to have a cardinality which
	/// is a multiple of this value.
	/// The default is 0, meaning that the user must specify a value
	/// that is consistent with the input data set.
	/// </summary>
	public virtual long GetSliceCardinalityMaxValue()
	{
		return vtkAutoCorrelativeStatistics_GetSliceCardinalityMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAutoCorrelativeStatistics_GetSliceCardinalityMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/get the cardinality of the data set at given time, i.e., of
	/// any given time slice. It cannot be negative.
	/// The input data set is assumed to have a cardinality which
	/// is a multiple of this value.
	/// The default is 0, meaning that the user must specify a value
	/// that is consistent with the input data set.
	/// </summary>
	public virtual long GetSliceCardinalityMinValue()
	{
		return vtkAutoCorrelativeStatistics_GetSliceCardinalityMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAutoCorrelativeStatistics_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAutoCorrelativeStatistics_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAutoCorrelativeStatistics_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAutoCorrelativeStatistics_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAutoCorrelativeStatistics_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAutoCorrelativeStatistics NewInstance()
	{
		vtkAutoCorrelativeStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAutoCorrelativeStatistics_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAutoCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAutoCorrelativeStatistics_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAutoCorrelativeStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkAutoCorrelativeStatistics vtkAutoCorrelativeStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAutoCorrelativeStatistics_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAutoCorrelativeStatistics2 = (vtkAutoCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAutoCorrelativeStatistics2.Register(null);
			}
		}
		return vtkAutoCorrelativeStatistics2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAutoCorrelativeStatistics_SetSliceCardinality_12(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/get the cardinality of the data set at given time, i.e., of
	/// any given time slice. It cannot be negative.
	/// The input data set is assumed to have a cardinality which
	/// is a multiple of this value.
	/// The default is 0, meaning that the user must specify a value
	/// that is consistent with the input data set.
	/// </summary>
	public virtual void SetSliceCardinality(long _arg)
	{
		vtkAutoCorrelativeStatistics_SetSliceCardinality_12(GetCppThis(), _arg);
	}
}
