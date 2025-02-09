using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMultiCorrelativeStatistics
/// </summary>
/// <remarks>
///    A class for multivariate linear correlation
///
///
/// Given a selection of sets of columns of interest, this class provides the
/// following functionalities, depending on the operation in which it is executed:
/// * Learn: calculates means, unbiased variance and covariance estimators of
///   column pairs coefficient.
///   More precisely, Learn calculates the averages and centered
///   variance/covariance sums; if \p finalize is set to true (default),
///   the final statistics are calculated.
///   The output metadata on port OUTPUT_MODEL is a multiblock dataset containing at a minimum
///   one vtkTable holding the raw sums in a sparse matrix style. If \a finalize is
///   true, then one additional vtkTable will be present for each requested set of
///   column correlations. These additional tables contain column averages, the
///   upper triangular portion of the covariance matrix (in the upper right hand
///   portion of the table) and the Cholesky decomposition of the covariance matrix
///   (in the lower portion of the table beneath the covariance triangle).
///   The leftmost column will be a vector of column averages.
///   The last entry in the column averages vector is the number of samples.
///   As an example, consider a request for a 3-column correlation with columns
///   named ColA, ColB, and ColC.
///   The resulting table will look like this:
///   &lt;pre&gt;
///      Column  |Mean     |ColA     |ColB     |ColC
///      --------+---------+---------+---------+---------
///      ColA    |avg(A)   |cov(A,A) |cov(A,B) |cov(A,C)
///      ColB    |avg(B)   |chol(1,1)|cov(B,B) |cov(B,C)
///      ColC    |avg(C)   |chol(2,1)|chol(2,2)|cov(C,C)
///      Cholesky|length(A)|chol(3,1)|chol(3,2)|chol(3,3)
///   &lt;/pre&gt;
///   The mean point and the covariance matrix can be replaced by the median point and the
///   MAD matrix (Median Absolute Deviation) thanks to the MedianAbsoluteDeviation boolean.
///   In this mode, the resulting table will look like this:
///   &lt;pre&gt;
///      Column  |Mean     |ColA     |ColB     |ColC
///      --------+---------+---------+---------+---------
///      ColA    |med(A)   |MAD(A,A) |MAD(A,B) |MAD(A,C)
///      ColB    |med(B)   |chol(1,1)|MAD(B,B) |MAD(B,C)
///      ColC    |med(C)   |chol(2,1)|chol(2,2)|MAD(C,C)
///      Cholesky|length(A)|chol(3,1)|chol(3,2)|chol(3,3)
///   &lt;/pre&gt;
///   The Median Absolute Deviation is known to be more robust than the covariance. It is
///   used in the robust PCA computation for instance.
/// * Assess: given a set of results matrices as specified above in input port INPUT_MODEL and
///   tabular data on input port INPUT_DATA that contains column names matching those
///   of the tables on input port INPUT_MODEL, the assess mode computes the relative
///   deviation of each observation in port INPUT_DATA's table according to the linear
///   correlations implied by each table in port INPUT_MODEL.
///
/// @par Thanks:
/// Thanks to Philippe Pebay, Jackson Mayo, and David Thompson of
/// Sandia National Laboratories for implementing this class.
/// Updated by Philippe Pebay, Kitware SAS 2012
/// Updated by Tristan Coulange and Joachim Pouderoux, Kitware SAS 2013
/// </remarks>
public class vtkMultiCorrelativeStatistics : vtkStatisticsAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiCorrelativeStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiCorrelativeStatistics()
	{
		MRClassNameKey = "class vtkMultiCorrelativeStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiCorrelativeStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiCorrelativeStatistics New()
	{
		vtkMultiCorrelativeStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMultiCorrelativeStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMultiCorrelativeStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkMultiCorrelativeStatistics_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMultiCorrelativeStatistics_GetGhostsToSkip_02(HandleRef pThis);

	/// <summary>
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
		return vtkMultiCorrelativeStatistics_GetGhostsToSkip_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMultiCorrelativeStatistics_GetMedianAbsoluteDeviation_03(HandleRef pThis);

	/// <summary>
	/// If set to true, the covariance matrix is replaced by
	/// the Median Absolute Deviation matrix.
	/// Default is false.
	/// </summary>
	public virtual bool GetMedianAbsoluteDeviation()
	{
		return (vtkMultiCorrelativeStatistics_GetMedianAbsoluteDeviation_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiCorrelativeStatistics_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiCorrelativeStatistics_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiCorrelativeStatistics_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiCorrelativeStatistics_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiCorrelativeStatistics_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiCorrelativeStatistics_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiCorrelativeStatistics_MedianAbsoluteDeviationOff_08(HandleRef pThis);

	/// <summary>
	/// If set to true, the covariance matrix is replaced by
	/// the Median Absolute Deviation matrix.
	/// Default is false.
	/// </summary>
	public virtual void MedianAbsoluteDeviationOff()
	{
		vtkMultiCorrelativeStatistics_MedianAbsoluteDeviationOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiCorrelativeStatistics_MedianAbsoluteDeviationOn_09(HandleRef pThis);

	/// <summary>
	/// If set to true, the covariance matrix is replaced by
	/// the Median Absolute Deviation matrix.
	/// Default is false.
	/// </summary>
	public virtual void MedianAbsoluteDeviationOn()
	{
		vtkMultiCorrelativeStatistics_MedianAbsoluteDeviationOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiCorrelativeStatistics_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiCorrelativeStatistics NewInstance()
	{
		vtkMultiCorrelativeStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiCorrelativeStatistics_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiCorrelativeStatistics_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiCorrelativeStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkMultiCorrelativeStatistics vtkMultiCorrelativeStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiCorrelativeStatistics_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiCorrelativeStatistics2 = (vtkMultiCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiCorrelativeStatistics2.Register(null);
			}
		}
		return vtkMultiCorrelativeStatistics2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiCorrelativeStatistics_SetGhostsToSkip_13(HandleRef pThis, byte _arg);

	/// <summary>
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
		vtkMultiCorrelativeStatistics_SetGhostsToSkip_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiCorrelativeStatistics_SetMedianAbsoluteDeviation_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set to true, the covariance matrix is replaced by
	/// the Median Absolute Deviation matrix.
	/// Default is false.
	/// </summary>
	public virtual void SetMedianAbsoluteDeviation(bool _arg)
	{
		vtkMultiCorrelativeStatistics_SetMedianAbsoluteDeviation_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
