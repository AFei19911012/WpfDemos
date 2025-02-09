using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDescriptiveStatistics
/// </summary>
/// <remarks>
///    A class for univariate descriptive statistics
///
///
/// Given a selection of columns of interest in an input data table, this
/// class provides the following functionalities, depending on the chosen
/// execution options:
/// * Learn: calculate extremal values, sample mean, and M2, M3, and M4 aggregates
///   (cf. P. Pebay, Formulas for robust, one-pass parallel computation of covariances
///   and Arbitrary-Order Statistical Moments, Sandia Report SAND2008-6212, Sep 2008,
///   http://infoserve.sandia.gov/sand_doc/2008/086212.pdf for details)
/// * Derive: calculate unbiased variance estimator, standard deviation estimator,
///   two skewness estimators, and two kurtosis excess estimators.
/// * Assess: given an input data set, a reference value and a non-negative deviation,
///   mark each datum with corresponding relative deviation (1-dimensional Mahlanobis
///   distance). If the deviation is zero, then mark each datum which are equal to the
///   reference value with 0, and all others with 1. By default, the reference value
///   and the deviation are, respectively, the mean and the standard deviation of the
///   input model.
/// * Test: calculate Jarque-Bera statistic and, if VTK to R interface is available,
///   retrieve corresponding p-value for normality testing.
///
/// Among the derived statistics, the variance, the standard deviation, the skewness
/// and the kurtosis can be estimated in two ways: using the sample version of those
/// statistics, or the population version. Specify whether a sample estimate or population
/// estimate is done by setting `SampleEstimate`. By default, `SampleEstimate == true`, hence
/// the sample version of the statistics is estimated,
/// which produces unbiased estimators (except for the sample standard deviation).
/// The sample estimate should be used for input that represent a subset of the whole
/// population of study. On the other hand, when `SampleEstimate == false`, the population
/// version of the statistics is estimated. If the input doesn't contain all the samples
/// from the population of study, then a bias is induced (the variance is slightly bigger than it
/// should be). One can read about Bessel's correction to understand better where this comes from.
/// That being said, on very large data, the difference between the 2 estimation formulas
/// becomes very low, so in those instances,
/// either state of `SampleEstimate` should yield very similar results
/// (see explicit formulas below).
///
/// \verbatim
///
/// The formulas used are as follows, writing \f( \bar{X} \f) the mean of \f( X \f) and \f( N \f)
/// the number of samples:
/// - Sample estimate:
///   \f[
///    Var{X} = s^2 = \frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^2 }{N - 1}
///   \f]
///   \f[
///    Skew{X} = \frac{n}{(n - 1)(n - 2)}
///    \frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^3 }{s^3}
///   \f]
///   \f[
///    Kurt{X} = \frac{n(n + 1)}{(n - 1)(n - 2)(n - 3)}
///    \frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^3 }{s^4}
///    - 3 \frac{(n - 1)^2}{(n - 2)(n - 3)}
///   \f]
/// - Population estimate:
///   \f[
///    Var{X} = \sigma^2 = \frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^2 }{N}
///   \f]
///   \f[
///    Skew{X} = \frac{1}{N}\frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^3 }{\sigma^3}
///   \f]
///   \f[
///    Kurt{X} = \frac{1}{N}\frac{\sum_{k=1}^N \left(x_k - \bar{x}\right)^3 }{\sigma^4} - 3
///   \f]
///
/// \f(\sigma\f) is the population standard deviation, and \f(s\f) is the sample standard deviation.
/// Note that the kurtosis is corrected so the kurtosis of a gaussian distribution should yield 0.
///
/// In the instance where \f(\sigma = 0\f) or \f(s = 0\f), the skewness and kurtosis are undefined.
/// Thus they output a `NaN`. Similarly, if there are no samples, then all derived statistics
/// yield a `NaN`.
///
/// \endverbatim
///
/// @par Thanks:
/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
/// for implementing this class.
/// Updated by Philippe Pebay, Kitware SAS 2012
/// </remarks>
public class vtkDescriptiveStatistics : vtkStatisticsAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDescriptiveStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDescriptiveStatistics()
	{
		MRClassNameKey = "class vtkDescriptiveStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDescriptiveStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDescriptiveStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDescriptiveStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDescriptiveStatistics New()
	{
		vtkDescriptiveStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDescriptiveStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDescriptiveStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDescriptiveStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDescriptiveStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkDescriptiveStatistics_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDescriptiveStatistics_GetGhostsToSkip_02(HandleRef pThis);

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
		return vtkDescriptiveStatistics_GetGhostsToSkip_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDescriptiveStatistics_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDescriptiveStatistics_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDescriptiveStatistics_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDescriptiveStatistics_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDescriptiveStatistics_GetSampleEstimate_05(HandleRef pThis);

	/// <summary>
	/// Getter / Setter on `SampleEstimate`. When turned on, descriptive statistics
	/// computed by this filter assume that the input data only holds a sample of the whole
	/// population of study. In effect, the sample variance, the sample standard deviation,
	/// the sample skewness and the sample kurtosis are estimated. When turned off, the population
	/// variance, the population standard deviation, the population skewness and the population
	/// kurtosis are estimated instead.
	///
	/// In short, if the input data is a full description of the population being studied,
	/// `SampleEstimate` should be turned off. If the input data is a sample of the population being
	/// studied, then `SampleEstimate` should be turned on. By default, `SampleEstimate` is turned
	/// on, as it is the most likely case.
	///
	/// Please see class description for a full description of the formulas.
	///
	/// @note For large data, the difference between the population estimate and the sample
	/// estimate becomes thin, so this parameter becomes of less worry.
	/// </summary>
	public virtual bool GetSampleEstimate()
	{
		return (vtkDescriptiveStatistics_GetSampleEstimate_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDescriptiveStatistics_GetSignedDeviations_06(HandleRef pThis);

	/// <summary>
	/// Set/get whether the deviations returned should be signed, or should
	/// only have their magnitude reported.
	/// The default is that signed deviations will be computed.
	/// </summary>
	public virtual int GetSignedDeviations()
	{
		return vtkDescriptiveStatistics_GetSignedDeviations_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDescriptiveStatistics_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDescriptiveStatistics_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDescriptiveStatistics_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDescriptiveStatistics_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDescriptiveStatistics_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDescriptiveStatistics NewInstance()
	{
		vtkDescriptiveStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDescriptiveStatistics_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDescriptiveStatistics_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDescriptiveStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkDescriptiveStatistics vtkDescriptiveStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDescriptiveStatistics_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDescriptiveStatistics2 = (vtkDescriptiveStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDescriptiveStatistics2.Register(null);
			}
		}
		return vtkDescriptiveStatistics2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDescriptiveStatistics_SampleEstimateOff_12(HandleRef pThis);

	/// <summary>
	/// Getter / Setter on `SampleEstimate`. When turned on, descriptive statistics
	/// computed by this filter assume that the input data only holds a sample of the whole
	/// population of study. In effect, the sample variance, the sample standard deviation,
	/// the sample skewness and the sample kurtosis are estimated. When turned off, the population
	/// variance, the population standard deviation, the population skewness and the population
	/// kurtosis are estimated instead.
	///
	/// In short, if the input data is a full description of the population being studied,
	/// `SampleEstimate` should be turned off. If the input data is a sample of the population being
	/// studied, then `SampleEstimate` should be turned on. By default, `SampleEstimate` is turned
	/// on, as it is the most likely case.
	///
	/// Please see class description for a full description of the formulas.
	///
	/// @note For large data, the difference between the population estimate and the sample
	/// estimate becomes thin, so this parameter becomes of less worry.
	/// </summary>
	public virtual void SampleEstimateOff()
	{
		vtkDescriptiveStatistics_SampleEstimateOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDescriptiveStatistics_SampleEstimateOn_13(HandleRef pThis);

	/// <summary>
	/// Getter / Setter on `SampleEstimate`. When turned on, descriptive statistics
	/// computed by this filter assume that the input data only holds a sample of the whole
	/// population of study. In effect, the sample variance, the sample standard deviation,
	/// the sample skewness and the sample kurtosis are estimated. When turned off, the population
	/// variance, the population standard deviation, the population skewness and the population
	/// kurtosis are estimated instead.
	///
	/// In short, if the input data is a full description of the population being studied,
	/// `SampleEstimate` should be turned off. If the input data is a sample of the population being
	/// studied, then `SampleEstimate` should be turned on. By default, `SampleEstimate` is turned
	/// on, as it is the most likely case.
	///
	/// Please see class description for a full description of the formulas.
	///
	/// @note For large data, the difference between the population estimate and the sample
	/// estimate becomes thin, so this parameter becomes of less worry.
	/// </summary>
	public virtual void SampleEstimateOn()
	{
		vtkDescriptiveStatistics_SampleEstimateOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDescriptiveStatistics_SetGhostsToSkip_14(HandleRef pThis, byte _arg);

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
		vtkDescriptiveStatistics_SetGhostsToSkip_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDescriptiveStatistics_SetSampleEstimate_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Getter / Setter on `SampleEstimate`. When turned on, descriptive statistics
	/// computed by this filter assume that the input data only holds a sample of the whole
	/// population of study. In effect, the sample variance, the sample standard deviation,
	/// the sample skewness and the sample kurtosis are estimated. When turned off, the population
	/// variance, the population standard deviation, the population skewness and the population
	/// kurtosis are estimated instead.
	///
	/// In short, if the input data is a full description of the population being studied,
	/// `SampleEstimate` should be turned off. If the input data is a sample of the population being
	/// studied, then `SampleEstimate` should be turned on. By default, `SampleEstimate` is turned
	/// on, as it is the most likely case.
	///
	/// Please see class description for a full description of the formulas.
	///
	/// @note For large data, the difference between the population estimate and the sample
	/// estimate becomes thin, so this parameter becomes of less worry.
	/// </summary>
	public virtual void SetSampleEstimate(bool _arg)
	{
		vtkDescriptiveStatistics_SetSampleEstimate_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDescriptiveStatistics_SetSignedDeviations_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether the deviations returned should be signed, or should
	/// only have their magnitude reported.
	/// The default is that signed deviations will be computed.
	/// </summary>
	public virtual void SetSignedDeviations(int _arg)
	{
		vtkDescriptiveStatistics_SetSignedDeviations_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDescriptiveStatistics_SignedDeviationsOff_17(HandleRef pThis);

	/// <summary>
	/// Set/get whether the deviations returned should be signed, or should
	/// only have their magnitude reported.
	/// The default is that signed deviations will be computed.
	/// </summary>
	public virtual void SignedDeviationsOff()
	{
		vtkDescriptiveStatistics_SignedDeviationsOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDescriptiveStatistics_SignedDeviationsOn_18(HandleRef pThis);

	/// <summary>
	/// Set/get whether the deviations returned should be signed, or should
	/// only have their magnitude reported.
	/// The default is that signed deviations will be computed.
	/// </summary>
	public virtual void SignedDeviationsOn()
	{
		vtkDescriptiveStatistics_SignedDeviationsOn_18(GetCppThis());
	}
}
