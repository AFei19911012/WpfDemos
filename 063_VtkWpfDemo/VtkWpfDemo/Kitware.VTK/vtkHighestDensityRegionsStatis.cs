using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHighestDensityRegionsStatistics
/// </summary>
/// <remarks>
///    Compute a random vector of
/// density f from input observations points. f is computed using a smooth
/// kernel method.
///
///
/// Given a selection of pairs of columns of interest, this class provides the
/// following functionalities, depending on the chosen execution options:
/// * Learn: calculates density estimator f of a random vector using a smooth
///   gaussian kernel. The output metadata on port OUTPUT_MODEL is a multiblock
///   dataset containing at one vtkTable holding three columns which are for the
///   first columns the input columns of interest and for the last columns the
///   density estimators of each input pair of columns of interest.
/// * Derive: calculate normalized (as a percentage) quantiles coming from
///   Learn output. The second block of the multibloc dataset contains a
///   vtkTable holding some pairs of columns which are for the second one the
///   quantiles ordered from the stronger to the lower and for the first one
///   the correspondand quantile index.
/// * Assess: not implemented.
/// * Test: not implemented.
/// </remarks>
public class vtkHighestDensityRegionsStatistics : vtkStatisticsAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHighestDensityRegionsStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHighestDensityRegionsStatistics()
	{
		MRClassNameKey = "class vtkHighestDensityRegionsStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHighestDensityRegionsStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHighestDensityRegionsStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHighestDensityRegionsStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHighestDensityRegionsStatistics New()
	{
		vtkHighestDensityRegionsStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHighestDensityRegionsStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHighestDensityRegionsStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHighestDensityRegionsStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHighestDensityRegionsStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHighestDensityRegionsStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkHighestDensityRegionsStatistics_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHighestDensityRegionsStatistics_ComputeHDR_02(HandleRef pThis, HandleRef inObservations, HandleRef outDensity);

	/// <summary>
	/// Fill outDensity with density vector that is computed from
	/// inObservations values. This method uses a Gaussian kernel.
	/// For n observations and with X an observation point:
	/// f(X) = (1 / n) * Sum(KH(X -Xi)) for (i = 1 to n).
	/// Look ComputeSmoothGaussianKernel for KH kernel definition.
	/// </summary>
	public double ComputeHDR(vtkDataArray inObservations, vtkDataArray outDensity)
	{
		return vtkHighestDensityRegionsStatistics_ComputeHDR_02(GetCppThis(), inObservations?.GetCppThis() ?? default(HandleRef), outDensity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHighestDensityRegionsStatistics_ComputeHDR_03(HandleRef pThis, HandleRef inObs, HandleRef inPOI, HandleRef outDensity);

	/// <summary>
	/// Fill outDensity with density vector defined by inPOI and computed from
	/// the inObs values. This method uses a Gaussian kernel.
	/// For n observations and with X an observation point:
	/// f(X) = (1 / n) * Sum(KH(X -Xi)) for (i = 1 to n).
	/// Look ComputeSmoothGaussianKernel for KH kernel definition.
	/// </summary>
	public double ComputeHDR(vtkDataArray inObs, vtkDataArray inPOI, vtkDataArray outDensity)
	{
		return vtkHighestDensityRegionsStatistics_ComputeHDR_03(GetCppThis(), inObs?.GetCppThis() ?? default(HandleRef), inPOI?.GetCppThis() ?? default(HandleRef), outDensity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHighestDensityRegionsStatistics_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHighestDensityRegionsStatistics_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHighestDensityRegionsStatistics_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHighestDensityRegionsStatistics_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHighestDensityRegionsStatistics_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHighestDensityRegionsStatistics_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHighestDensityRegionsStatistics_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHighestDensityRegionsStatistics_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHighestDensityRegionsStatistics_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHighestDensityRegionsStatistics NewInstance()
	{
		vtkHighestDensityRegionsStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHighestDensityRegionsStatistics_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHighestDensityRegionsStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHighestDensityRegionsStatistics_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHighestDensityRegionsStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkHighestDensityRegionsStatistics vtkHighestDensityRegionsStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHighestDensityRegionsStatistics_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHighestDensityRegionsStatistics2 = (vtkHighestDensityRegionsStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHighestDensityRegionsStatistics2.Register(null);
			}
		}
		return vtkHighestDensityRegionsStatistics2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHighestDensityRegionsStatistics_SetSigma_11(HandleRef pThis, double sigma);

	/// <summary>
	/// Set the width of the gaussian kernel.
	/// </summary>
	public void SetSigma(double sigma)
	{
		vtkHighestDensityRegionsStatistics_SetSigma_11(GetCppThis(), sigma);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHighestDensityRegionsStatistics_SetSigmaMatrix_12(HandleRef pThis, double s11, double s12, double s21, double s22);

	/// <summary>
	/// Set the gaussian kernel matrix.
	/// </summary>
	public void SetSigmaMatrix(double s11, double s12, double s21, double s22)
	{
		vtkHighestDensityRegionsStatistics_SetSigmaMatrix_12(GetCppThis(), s11, s12, s21, s22);
	}
}
