using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPCAStatistics
/// </summary>
/// <remarks>
///    A class for multivariate principal component analysis
///
///
/// This class derives from the multi-correlative statistics algorithm and
/// uses the covariance matrix and Cholesky decomposition computed by it.
/// However, when it finalizes the statistics in learn operation, the PCA class
/// computes the SVD of the covariance matrix in order to obtain its eigenvectors.
///
/// In the assess operation, the input data are
/// - projected into the basis defined by the eigenvectors,
/// - the energy associated with each datum is computed,
/// - or some combination thereof.
/// Additionally, the user may specify some threshold energy or
/// eigenvector entry below which the basis is truncated. This allows
/// projection into a lower-dimensional state while minimizing (in a
/// least squares sense) the projection error.
///
/// In the test operation, a Jarque-Bera-Srivastava test of n-d normality is performed.
///
/// The Robust PCA can be computed by using the median instead of the mean,
/// and the MAD matrix (Median Absolute Deviation) instead of the covariance matrix.
/// This can be done by activating the MedianAbsoluteDeviation boolean (declared in
/// the superclass).
///
/// @par Thanks:
/// Thanks to David Thompson, Philippe Pebay and Jackson Mayo from
/// Sandia National Laboratories for implementing this class.
/// Updated by Philippe Pebay, Kitware SAS 2012
/// Updated by Tristan Coulange and Joachim Pouderoux, Kitware SAS 2013
/// </remarks>
public class vtkPCAStatistics : vtkMultiCorrelativeStatistics
{
	/// <summary>
	/// Methods by which the covariance matrix may be normalized.
	/// </summary>
	public enum NormalizationType
	{
		/// <summary>enum member</summary>
		DIAGONAL_SPECIFIED = 2,
		/// <summary>enum member</summary>
		DIAGONAL_VARIANCE = 3,
		/// <summary>enum member</summary>
		NONE = 0,
		/// <summary>enum member</summary>
		NUM_NORMALIZATION_SCHEMES = 4,
		/// <summary>enum member</summary>
		TRIANGLE_SPECIFIED = 1
	}

	/// <summary>
	/// These are the enumeration values that SetBasisScheme() accepts and GetBasisScheme returns.
	/// </summary>
	public enum ProjectionType
	{
		/// <summary>enum member</summary>
		FIXED_BASIS_ENERGY = 2,
		/// <summary>enum member</summary>
		FIXED_BASIS_SIZE = 1,
		/// <summary>enum member</summary>
		FULL_BASIS = 0,
		/// <summary>enum member</summary>
		NUM_BASIS_SCHEMES = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPCAStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPCAStatistics()
	{
		MRClassNameKey = "class vtkPCAStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCAStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPCAStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPCAStatistics New()
	{
		vtkPCAStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCAStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPCAStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPCAStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPCAStatistics_GetBasisScheme_01(HandleRef pThis);

	/// <summary>
	/// This variable controls the dimensionality of output tuples in Assess operation.
	/// Consider the case where you have requested a PCA on D columns.
	///
	/// When set to vtkPCAStatistics::FULL_BASIS, the entire set of basis vectors
	/// is used to derive new coordinates for each tuple being assessed.
	/// In this mode, you are guaranteed to have output tuples of the same dimension
	/// as the input tuples. (That dimension is D, so there will be D additional
	/// columns added to the table for the request.)
	///
	/// When set to vtkPCAStatistics::FIXED_BASIS_SIZE, only the first N basis vectors
	/// are used to derive new coordinates for each tuple being assessed.
	/// In this mode, you are guaranteed to have output tuples of dimension min(N,D).
	/// You must set N prior to assessing data using the SetFixedBasisSize() method.
	/// When N &lt; D, this turns the PCA into a projection (instead of change of basis).
	///
	/// When set to vtkPCAStatistics::FIXED_BASIS_ENERGY, the number of basis vectors
	/// used to derive new coordinates for each tuple will be the minimum number
	/// of columns N that satisfy
	/// \f[
	/// \frac{\sum_{i=1}^{N} \lambda_i}{\sum_{i=1}^{D} \lambda_i} &lt; T
	/// \f]
	/// You must set T prior to assessing data using the SetFixedBasisEnergy() method.
	/// When T &lt; 1, this turns the PCA into a projection (instead of change of basis).
	///
	/// By default BasisScheme is set to vtkPCAStatistics::FULL_BASIS.
	/// </summary>
	public virtual int GetBasisScheme()
	{
		return vtkPCAStatistics_GetBasisScheme_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAStatistics_GetBasisSchemeName_02(HandleRef pThis, int schemeIndex);

	/// <summary>
	/// This variable controls the dimensionality of output tuples in Assess operation.
	/// Consider the case where you have requested a PCA on D columns.
	///
	/// When set to vtkPCAStatistics::FULL_BASIS, the entire set of basis vectors
	/// is used to derive new coordinates for each tuple being assessed.
	/// In this mode, you are guaranteed to have output tuples of the same dimension
	/// as the input tuples. (That dimension is D, so there will be D additional
	/// columns added to the table for the request.)
	///
	/// When set to vtkPCAStatistics::FIXED_BASIS_SIZE, only the first N basis vectors
	/// are used to derive new coordinates for each tuple being assessed.
	/// In this mode, you are guaranteed to have output tuples of dimension min(N,D).
	/// You must set N prior to assessing data using the SetFixedBasisSize() method.
	/// When N &lt; D, this turns the PCA into a projection (instead of change of basis).
	///
	/// When set to vtkPCAStatistics::FIXED_BASIS_ENERGY, the number of basis vectors
	/// used to derive new coordinates for each tuple will be the minimum number
	/// of columns N that satisfy
	/// \f[
	/// \frac{\sum_{i=1}^{N} \lambda_i}{\sum_{i=1}^{D} \lambda_i} &lt; T
	/// \f]
	/// You must set T prior to assessing data using the SetFixedBasisEnergy() method.
	/// When T &lt; 1, this turns the PCA into a projection (instead of change of basis).
	///
	/// By default BasisScheme is set to vtkPCAStatistics::FULL_BASIS.
	/// </summary>
	public virtual string GetBasisSchemeName(int schemeIndex)
	{
		return Marshal.PtrToStringAnsi(vtkPCAStatistics_GetBasisSchemeName_02(GetCppThis(), schemeIndex));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPCAStatistics_GetEigenvalue_03(HandleRef pThis, int request, int i);

	/// <summary>
	/// Get the eigenvalues. The eigenvalues are ordered according from largest to smallest.
	/// This function:
	/// void GetEigenvalues(int request, int i, vtkDoubleArray*);
	/// does all of the work. The other functions simply call this function with the appropriate
	/// parameters. These functions are not valid unless Update() has been called and the Derive
	/// option is turned on.
	/// </summary>
	public double GetEigenvalue(int request, int i)
	{
		return vtkPCAStatistics_GetEigenvalue_03(GetCppThis(), request, i);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPCAStatistics_GetEigenvalue_04(HandleRef pThis, int i);

	/// <summary>
	/// Get the eigenvalues. The eigenvalues are ordered according from largest to smallest.
	/// This function:
	/// void GetEigenvalues(int request, int i, vtkDoubleArray*);
	/// does all of the work. The other functions simply call this function with the appropriate
	/// parameters. These functions are not valid unless Update() has been called and the Derive
	/// option is turned on.
	/// </summary>
	public double GetEigenvalue(int i)
	{
		return vtkPCAStatistics_GetEigenvalue_04(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_GetEigenvalues_05(HandleRef pThis, int request, HandleRef arg1);

	/// <summary>
	/// Get the eigenvalues. The eigenvalues are ordered according from largest to smallest.
	/// This function:
	/// void GetEigenvalues(int request, int i, vtkDoubleArray*);
	/// does all of the work. The other functions simply call this function with the appropriate
	/// parameters. These functions are not valid unless Update() has been called and the Derive
	/// option is turned on.
	/// </summary>
	public void GetEigenvalues(int request, vtkDoubleArray arg1)
	{
		vtkPCAStatistics_GetEigenvalues_05(GetCppThis(), request, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_GetEigenvalues_06(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get the eigenvalues. The eigenvalues are ordered according from largest to smallest.
	/// This function:
	/// void GetEigenvalues(int request, int i, vtkDoubleArray*);
	/// does all of the work. The other functions simply call this function with the appropriate
	/// parameters. These functions are not valid unless Update() has been called and the Derive
	/// option is turned on.
	/// </summary>
	public void GetEigenvalues(vtkDoubleArray arg0)
	{
		vtkPCAStatistics_GetEigenvalues_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_GetEigenvector_07(HandleRef pThis, int i, HandleRef eigenvector);

	/// <summary>
	/// Get the eigenvectors. The eigenvectors are ordered according to the magnitude of their
	/// associated eigenvalues, sorted from largest to smallest. That is, eigenvector 0 corresponds
	/// to the largest eigenvalue.
	/// This function:
	/// void GetEigenvectors(int request, vtkDoubleArray* eigenvectors)
	/// does all of the work. The other functions are convenience functions that call this function
	/// with default arguments. These functions are not valid unless Update() has been called and the
	/// Derive option is turned on.
	/// </summary>
	public void GetEigenvector(int i, vtkDoubleArray eigenvector)
	{
		vtkPCAStatistics_GetEigenvector_07(GetCppThis(), i, eigenvector?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_GetEigenvector_08(HandleRef pThis, int request, int i, HandleRef eigenvector);

	/// <summary>
	/// Get the eigenvectors. The eigenvectors are ordered according to the magnitude of their
	/// associated eigenvalues, sorted from largest to smallest. That is, eigenvector 0 corresponds
	/// to the largest eigenvalue.
	/// This function:
	/// void GetEigenvectors(int request, vtkDoubleArray* eigenvectors)
	/// does all of the work. The other functions are convenience functions that call this function
	/// with default arguments. These functions are not valid unless Update() has been called and the
	/// Derive option is turned on.
	/// </summary>
	public void GetEigenvector(int request, int i, vtkDoubleArray eigenvector)
	{
		vtkPCAStatistics_GetEigenvector_08(GetCppThis(), request, i, eigenvector?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_GetEigenvectors_09(HandleRef pThis, int request, HandleRef eigenvectors);

	/// <summary>
	/// Get the eigenvectors. The eigenvectors are ordered according to the magnitude of their
	/// associated eigenvalues, sorted from largest to smallest. That is, eigenvector 0 corresponds
	/// to the largest eigenvalue.
	/// This function:
	/// void GetEigenvectors(int request, vtkDoubleArray* eigenvectors)
	/// does all of the work. The other functions are convenience functions that call this function
	/// with default arguments. These functions are not valid unless Update() has been called and the
	/// Derive option is turned on.
	/// </summary>
	public void GetEigenvectors(int request, vtkDoubleArray eigenvectors)
	{
		vtkPCAStatistics_GetEigenvectors_09(GetCppThis(), request, eigenvectors?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_GetEigenvectors_10(HandleRef pThis, HandleRef eigenvectors);

	/// <summary>
	/// Get the eigenvectors. The eigenvectors are ordered according to the magnitude of their
	/// associated eigenvalues, sorted from largest to smallest. That is, eigenvector 0 corresponds
	/// to the largest eigenvalue.
	/// This function:
	/// void GetEigenvectors(int request, vtkDoubleArray* eigenvectors)
	/// does all of the work. The other functions are convenience functions that call this function
	/// with default arguments. These functions are not valid unless Update() has been called and the
	/// Derive option is turned on.
	/// </summary>
	public void GetEigenvectors(vtkDoubleArray eigenvectors)
	{
		vtkPCAStatistics_GetEigenvectors_10(GetCppThis(), eigenvectors?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPCAStatistics_GetFixedBasisEnergy_11(HandleRef pThis);

	/// <summary>
	/// The minimum energy the new basis should use, as a fraction. See SetBasisScheme() for more
	/// information. When FixedBasisEnergy &gt;= 1 (the default), the fixed basis energy scheme is
	/// equivalent to the full basis scheme.
	/// </summary>
	public virtual double GetFixedBasisEnergy()
	{
		return vtkPCAStatistics_GetFixedBasisEnergy_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPCAStatistics_GetFixedBasisEnergyMaxValue_12(HandleRef pThis);

	/// <summary>
	/// The minimum energy the new basis should use, as a fraction. See SetBasisScheme() for more
	/// information. When FixedBasisEnergy &gt;= 1 (the default), the fixed basis energy scheme is
	/// equivalent to the full basis scheme.
	/// </summary>
	public virtual double GetFixedBasisEnergyMaxValue()
	{
		return vtkPCAStatistics_GetFixedBasisEnergyMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPCAStatistics_GetFixedBasisEnergyMinValue_13(HandleRef pThis);

	/// <summary>
	/// The minimum energy the new basis should use, as a fraction. See SetBasisScheme() for more
	/// information. When FixedBasisEnergy &gt;= 1 (the default), the fixed basis energy scheme is
	/// equivalent to the full basis scheme.
	/// </summary>
	public virtual double GetFixedBasisEnergyMinValue()
	{
		return vtkPCAStatistics_GetFixedBasisEnergyMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCAStatistics_GetFixedBasisSize_14(HandleRef pThis);

	/// <summary>
	/// The number of basis vectors to use. See SetBasisScheme() for more information.
	/// When FixedBasisSize &lt;= 0 (the default), the fixed basis size scheme is equivalent to the full
	/// basis scheme.
	/// </summary>
	public virtual int GetFixedBasisSize()
	{
		return vtkPCAStatistics_GetFixedBasisSize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCAStatistics_GetNormalizationScheme_15(HandleRef pThis);

	/// <summary>
	/// This determines how (or if) the covariance matrix \a cov is normalized before PCA.
	///
	/// When set to NONE, no normalization is performed. This is the default.
	///
	/// When set to TRIANGLE_SPECIFIED, each entry cov(i,j) is divided by V(i,j).
	/// The list V of normalization factors must be set using the SetNormalization method
	/// before the filter is executed.
	///
	/// When set to DIAGONAL_SPECIFIED, each entry cov(i,j) is divided by sqrt(V(i)*V(j)).
	/// The list V of normalization factors must be set using the SetNormalization method
	/// before the filter is executed.
	///
	/// When set to DIAGONAL_VARIANCE, each entry cov(i,j) is divided by sqrt(cov(i,i)*cov(j,j)).
	/// &lt;b&gt;Warning&lt;/b&gt;: Although this is accepted practice in some fields,
	/// some people think you should not turn this option on unless there
	/// is a good physically-based reason for doing so. Much better instead
	/// to determine how component magnitudes should be compared using
	/// physical reasoning and use DIAGONAL_SPECIFIED, TRIANGLE_SPECIFIED, or
	/// perform some pre-processing to shift and scale input data columns
	/// appropriately than to expect magical results from a shady normalization hack.
	/// </summary>
	public virtual int GetNormalizationScheme()
	{
		return vtkPCAStatistics_GetNormalizationScheme_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAStatistics_GetNormalizationSchemeName_16(HandleRef pThis, int scheme);

	/// <summary>
	/// This determines how (or if) the covariance matrix \a cov is normalized before PCA.
	///
	/// When set to NONE, no normalization is performed. This is the default.
	///
	/// When set to TRIANGLE_SPECIFIED, each entry cov(i,j) is divided by V(i,j).
	/// The list V of normalization factors must be set using the SetNormalization method
	/// before the filter is executed.
	///
	/// When set to DIAGONAL_SPECIFIED, each entry cov(i,j) is divided by sqrt(V(i)*V(j)).
	/// The list V of normalization factors must be set using the SetNormalization method
	/// before the filter is executed.
	///
	/// When set to DIAGONAL_VARIANCE, each entry cov(i,j) is divided by sqrt(cov(i,i)*cov(j,j)).
	/// &lt;b&gt;Warning&lt;/b&gt;: Although this is accepted practice in some fields,
	/// some people think you should not turn this option on unless there
	/// is a good physically-based reason for doing so. Much better instead
	/// to determine how component magnitudes should be compared using
	/// physical reasoning and use DIAGONAL_SPECIFIED, TRIANGLE_SPECIFIED, or
	/// perform some pre-processing to shift and scale input data columns
	/// appropriately than to expect magical results from a shady normalization hack.
	/// </summary>
	public virtual string GetNormalizationSchemeName(int scheme)
	{
		return Marshal.PtrToStringAnsi(vtkPCAStatistics_GetNormalizationSchemeName_16(GetCppThis(), scheme));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPCAStatistics_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPCAStatistics_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPCAStatistics_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPCAStatistics_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAStatistics_GetSpecifiedNormalization_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// These methods allow you to set/get values used to normalize the covariance matrix before PCA.
	/// The normalization values apply to all requests, so you do not specify a single
	/// vector but a 3-column table.
	///
	/// The first two columns contain the names of columns from input 0 and the third column contains
	/// the value to normalize the corresponding entry in the covariance matrix.
	/// The table must always have 3 columns even when the NormalizationScheme is DIAGONAL_SPECIFIED.
	/// When only diagonal entries are to be used, only table rows where the first two columns are
	/// identical to one another will be employed.
	/// If there are multiple rows specifying different values for the same pair of columns,
	/// the entry nearest the bottom of the table takes precedence.
	///
	/// These functions are actually convenience methods that set/get the third input of the filter.
	/// Because the table is the third input, you may use other filters to produce a table of
	/// normalizations and have the pipeline take care of updates.
	///
	/// Any missing entries will be set to 1.0 and a warning issued.
	/// An error will occur if the third input to the filter is not set and the
	/// NormalizationScheme is DIAGONAL_SPECIFIED or TRIANGLE_SPECIFIED.
	///
	/// NOTE: SetSpecifiedNormalization( table ) is equivalent to SetInputData(3, table)
	/// and therefore does not make a pipeline connection.
	/// </summary>
	public virtual vtkTable GetSpecifiedNormalization()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCAStatistics_GetSpecifiedNormalization_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCAStatistics_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPCAStatistics_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPCAStatistics_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPCAStatistics_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAStatistics_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPCAStatistics NewInstance()
	{
		vtkPCAStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCAStatistics_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPCAStatistics_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPCAStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkPCAStatistics vtkPCAStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPCAStatistics_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPCAStatistics2 = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPCAStatistics2.Register(null);
			}
		}
		return vtkPCAStatistics2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_SetBasisScheme_25(HandleRef pThis, int _arg);

	/// <summary>
	/// This variable controls the dimensionality of output tuples in Assess operation.
	/// Consider the case where you have requested a PCA on D columns.
	///
	/// When set to vtkPCAStatistics::FULL_BASIS, the entire set of basis vectors
	/// is used to derive new coordinates for each tuple being assessed.
	/// In this mode, you are guaranteed to have output tuples of the same dimension
	/// as the input tuples. (That dimension is D, so there will be D additional
	/// columns added to the table for the request.)
	///
	/// When set to vtkPCAStatistics::FIXED_BASIS_SIZE, only the first N basis vectors
	/// are used to derive new coordinates for each tuple being assessed.
	/// In this mode, you are guaranteed to have output tuples of dimension min(N,D).
	/// You must set N prior to assessing data using the SetFixedBasisSize() method.
	/// When N &lt; D, this turns the PCA into a projection (instead of change of basis).
	///
	/// When set to vtkPCAStatistics::FIXED_BASIS_ENERGY, the number of basis vectors
	/// used to derive new coordinates for each tuple will be the minimum number
	/// of columns N that satisfy
	/// \f[
	/// \frac{\sum_{i=1}^{N} \lambda_i}{\sum_{i=1}^{D} \lambda_i} &lt; T
	/// \f]
	/// You must set T prior to assessing data using the SetFixedBasisEnergy() method.
	/// When T &lt; 1, this turns the PCA into a projection (instead of change of basis).
	///
	/// By default BasisScheme is set to vtkPCAStatistics::FULL_BASIS.
	/// </summary>
	public virtual void SetBasisScheme(int _arg)
	{
		vtkPCAStatistics_SetBasisScheme_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_SetBasisSchemeByName_26(HandleRef pThis, string schemeName);

	/// <summary>
	/// This variable controls the dimensionality of output tuples in Assess operation.
	/// Consider the case where you have requested a PCA on D columns.
	///
	/// When set to vtkPCAStatistics::FULL_BASIS, the entire set of basis vectors
	/// is used to derive new coordinates for each tuple being assessed.
	/// In this mode, you are guaranteed to have output tuples of the same dimension
	/// as the input tuples. (That dimension is D, so there will be D additional
	/// columns added to the table for the request.)
	///
	/// When set to vtkPCAStatistics::FIXED_BASIS_SIZE, only the first N basis vectors
	/// are used to derive new coordinates for each tuple being assessed.
	/// In this mode, you are guaranteed to have output tuples of dimension min(N,D).
	/// You must set N prior to assessing data using the SetFixedBasisSize() method.
	/// When N &lt; D, this turns the PCA into a projection (instead of change of basis).
	///
	/// When set to vtkPCAStatistics::FIXED_BASIS_ENERGY, the number of basis vectors
	/// used to derive new coordinates for each tuple will be the minimum number
	/// of columns N that satisfy
	/// \f[
	/// \frac{\sum_{i=1}^{N} \lambda_i}{\sum_{i=1}^{D} \lambda_i} &lt; T
	/// \f]
	/// You must set T prior to assessing data using the SetFixedBasisEnergy() method.
	/// When T &lt; 1, this turns the PCA into a projection (instead of change of basis).
	///
	/// By default BasisScheme is set to vtkPCAStatistics::FULL_BASIS.
	/// </summary>
	public virtual void SetBasisSchemeByName(string schemeName)
	{
		vtkPCAStatistics_SetBasisSchemeByName_26(GetCppThis(), schemeName);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_SetFixedBasisEnergy_27(HandleRef pThis, double _arg);

	/// <summary>
	/// The minimum energy the new basis should use, as a fraction. See SetBasisScheme() for more
	/// information. When FixedBasisEnergy &gt;= 1 (the default), the fixed basis energy scheme is
	/// equivalent to the full basis scheme.
	/// </summary>
	public virtual void SetFixedBasisEnergy(double _arg)
	{
		vtkPCAStatistics_SetFixedBasisEnergy_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_SetFixedBasisSize_28(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of basis vectors to use. See SetBasisScheme() for more information.
	/// When FixedBasisSize &lt;= 0 (the default), the fixed basis size scheme is equivalent to the full
	/// basis scheme.
	/// </summary>
	public virtual void SetFixedBasisSize(int _arg)
	{
		vtkPCAStatistics_SetFixedBasisSize_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_SetNormalizationScheme_29(HandleRef pThis, int _arg);

	/// <summary>
	/// This determines how (or if) the covariance matrix \a cov is normalized before PCA.
	///
	/// When set to NONE, no normalization is performed. This is the default.
	///
	/// When set to TRIANGLE_SPECIFIED, each entry cov(i,j) is divided by V(i,j).
	/// The list V of normalization factors must be set using the SetNormalization method
	/// before the filter is executed.
	///
	/// When set to DIAGONAL_SPECIFIED, each entry cov(i,j) is divided by sqrt(V(i)*V(j)).
	/// The list V of normalization factors must be set using the SetNormalization method
	/// before the filter is executed.
	///
	/// When set to DIAGONAL_VARIANCE, each entry cov(i,j) is divided by sqrt(cov(i,i)*cov(j,j)).
	/// &lt;b&gt;Warning&lt;/b&gt;: Although this is accepted practice in some fields,
	/// some people think you should not turn this option on unless there
	/// is a good physically-based reason for doing so. Much better instead
	/// to determine how component magnitudes should be compared using
	/// physical reasoning and use DIAGONAL_SPECIFIED, TRIANGLE_SPECIFIED, or
	/// perform some pre-processing to shift and scale input data columns
	/// appropriately than to expect magical results from a shady normalization hack.
	/// </summary>
	public virtual void SetNormalizationScheme(int _arg)
	{
		vtkPCAStatistics_SetNormalizationScheme_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_SetNormalizationSchemeByName_30(HandleRef pThis, string schemeName);

	/// <summary>
	/// This determines how (or if) the covariance matrix \a cov is normalized before PCA.
	///
	/// When set to NONE, no normalization is performed. This is the default.
	///
	/// When set to TRIANGLE_SPECIFIED, each entry cov(i,j) is divided by V(i,j).
	/// The list V of normalization factors must be set using the SetNormalization method
	/// before the filter is executed.
	///
	/// When set to DIAGONAL_SPECIFIED, each entry cov(i,j) is divided by sqrt(V(i)*V(j)).
	/// The list V of normalization factors must be set using the SetNormalization method
	/// before the filter is executed.
	///
	/// When set to DIAGONAL_VARIANCE, each entry cov(i,j) is divided by sqrt(cov(i,i)*cov(j,j)).
	/// &lt;b&gt;Warning&lt;/b&gt;: Although this is accepted practice in some fields,
	/// some people think you should not turn this option on unless there
	/// is a good physically-based reason for doing so. Much better instead
	/// to determine how component magnitudes should be compared using
	/// physical reasoning and use DIAGONAL_SPECIFIED, TRIANGLE_SPECIFIED, or
	/// perform some pre-processing to shift and scale input data columns
	/// appropriately than to expect magical results from a shady normalization hack.
	/// </summary>
	public virtual void SetNormalizationSchemeByName(string schemeName)
	{
		vtkPCAStatistics_SetNormalizationSchemeByName_30(GetCppThis(), schemeName);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPCAStatistics_SetParameter_31(HandleRef pThis, string parameter, int index, HandleRef value);

	/// <summary>
	/// A convenience method (in particular for access from other applications) to
	/// set parameter values.
	/// Return true if setting of requested parameter name was executed, false otherwise.
	/// </summary>
	public override bool SetParameter(string parameter, int index, vtkVariant value)
	{
		return (vtkPCAStatistics_SetParameter_31(GetCppThis(), parameter, index, value?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPCAStatistics_SetSpecifiedNormalization_32(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods allow you to set/get values used to normalize the covariance matrix before PCA.
	/// The normalization values apply to all requests, so you do not specify a single
	/// vector but a 3-column table.
	///
	/// The first two columns contain the names of columns from input 0 and the third column contains
	/// the value to normalize the corresponding entry in the covariance matrix.
	/// The table must always have 3 columns even when the NormalizationScheme is DIAGONAL_SPECIFIED.
	/// When only diagonal entries are to be used, only table rows where the first two columns are
	/// identical to one another will be employed.
	/// If there are multiple rows specifying different values for the same pair of columns,
	/// the entry nearest the bottom of the table takes precedence.
	///
	/// These functions are actually convenience methods that set/get the third input of the filter.
	/// Because the table is the third input, you may use other filters to produce a table of
	/// normalizations and have the pipeline take care of updates.
	///
	/// Any missing entries will be set to 1.0 and a warning issued.
	/// An error will occur if the third input to the filter is not set and the
	/// NormalizationScheme is DIAGONAL_SPECIFIED or TRIANGLE_SPECIFIED.
	///
	/// NOTE: SetSpecifiedNormalization( table ) is equivalent to SetInputData(3, table)
	/// and therefore does not make a pipeline connection.
	/// </summary>
	public virtual void SetSpecifiedNormalization(vtkTable arg0)
	{
		vtkPCAStatistics_SetSpecifiedNormalization_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
