using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCorrelativeStatistics
/// </summary>
/// <remarks>
///    A class for bivariate linear correlation
///
///
/// Given a selection of pairs of columns of interest, this class provides the
/// following functionalities, depending on the chosen execution options:
/// * Learn: calculate sample mean and M2 aggregates for each pair of variables
///   (cf. P. Pebay, Formulas for robust, one-pass parallel computation of covariances
///   and Arbitrary-Order Statistical Moments, Sandia Report SAND2008-6212, Sep 2008,
///   http://infoserve.sandia.gov/sand_doc/2008/086212.pdf for details)
/// * Derive: calculate unbiased covariance matrix estimators and its determinant,
///   linear regressions, and Pearson correlation coefficient.
/// * Assess: given an input data set, two means and a 2x2 covariance matrix,
///   mark each datum with corresponding relative deviation (2-dimensional Mahlanobis
///   distance).
/// * Test: Perform Jarque-Bera-Srivastava test of 2-d normality
///
/// @par Thanks:
/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
/// for implementing this class.
/// Updated by Philippe Pebay, Kitware SAS 2012
/// </remarks>
public class vtkCorrelativeStatistics : vtkStatisticsAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCorrelativeStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCorrelativeStatistics()
	{
		MRClassNameKey = "class vtkCorrelativeStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCorrelativeStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCorrelativeStatistics New()
	{
		vtkCorrelativeStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCorrelativeStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCorrelativeStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCorrelativeStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkCorrelativeStatistics_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCorrelativeStatistics_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCorrelativeStatistics_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCorrelativeStatistics_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCorrelativeStatistics_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCorrelativeStatistics_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCorrelativeStatistics_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCorrelativeStatistics_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCorrelativeStatistics NewInstance()
	{
		vtkCorrelativeStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCorrelativeStatistics_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCorrelativeStatistics_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCorrelativeStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkCorrelativeStatistics vtkCorrelativeStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCorrelativeStatistics_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCorrelativeStatistics2 = (vtkCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCorrelativeStatistics2.Register(null);
			}
		}
		return vtkCorrelativeStatistics2;
	}
}
