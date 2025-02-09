using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStatisticsAlgorithm
/// </summary>
/// <remarks>
///    Base class for statistics algorithms
///
///
/// All statistics algorithms can conceptually be operated with several operations:
/// * Learn: given an input data set, calculate a minimal statistical model (e.g.,
///   sums, raw moments, joint probabilities).
/// * Derive: given an input minimal statistical model, derive the full model
///   (e.g., descriptive statistics, quantiles, correlations, conditional
///    probabilities).
///   NB: It may be, or not be, a problem that a full model was not derived. For
///   instance, when doing parallel calculations, one only wants to derive the full
///   model after all partial calculations have completed. On the other hand, one
///   can also directly provide a full model, that was previously calculated or
///   guessed, and not derive a new one.
/// * Assess: given an input data set, input statistics, and some form of
///   threshold, assess a subset of the data set.
/// * Test: perform at least one statistical test.
/// Therefore, a vtkStatisticsAlgorithm has the following ports
/// * 3 optional input ports:
///   * Data (vtkTable)
///   * Parameters to the learn operation (vtkTable)
///   * Input model (vtkMultiBlockDataSet)
/// * 3 output ports:
///   * Data (input annotated with assessments when the Assess operation is ON).
///   * Output model (identical to the input model when Learn operation is OFF).
///   * Output of statistical tests. Some engines do not offer such tests yet, in
///     which case this output will always be empty even when the Test operation is ON.
///
/// @par Thanks:
/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
/// for implementing this class.
/// Updated by Philippe Pebay, Kitware SAS 2012
/// </remarks>
public abstract class vtkStatisticsAlgorithm : vtkTableAlgorithm
{
	/// <summary>
	/// enumeration values to specify input port types
	/// </summary>
	public enum InputPorts
	{
		/// <summary>enum member</summary>
		INPUT_DATA = 0,
		/// <summary>enum member</summary>
		INPUT_MODEL = 2,
		/// <summary>enum member</summary>
		LEARN_PARAMETERS = 1
	}

	/// <summary>
	/// enumeration values to specify output port types
	/// </summary>
	public enum OutputIndices
	{
		/// <summary>enum member</summary>
		OUTPUT_DATA,
		/// <summary>enum member</summary>
		OUTPUT_MODEL,
		/// <summary>enum member</summary>
		OUTPUT_TEST
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStatisticsAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStatisticsAlgorithm()
	{
		MRClassNameKey = "class vtkStatisticsAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStatisticsAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStatisticsAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkStatisticsAlgorithm_AddColumn_01(HandleRef pThis, string namCol);

	/// <summary>
	/// Convenience method to create a request with a single column name \p namCol in a single
	/// call; this is the preferred method to select columns, ensuring selection consistency
	/// (a single column per request).
	/// Warning: no name checking is performed on \p namCol; it is the user's
	/// responsibility to use valid column names.
	/// </summary>
	public void AddColumn(string namCol)
	{
		vtkStatisticsAlgorithm_AddColumn_01(GetCppThis(), namCol);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_AddColumnPair_02(HandleRef pThis, string namColX, string namColY);

	/// <summary>
	/// Convenience method to create a request with a single column name pair
	/// (\p namColX, \p namColY) in a single call; this is the preferred method to select
	/// columns pairs, ensuring selection consistency (a pair of columns per request).
	///
	/// Unlike SetColumnStatus(), you need not call RequestSelectedColumns() after AddColumnPair().
	///
	/// Warning: \p namColX and \p namColY are only checked for their validity as strings;
	/// no check is made that either are valid column names.
	/// </summary>
	public void AddColumnPair(string namColX, string namColY)
	{
		vtkStatisticsAlgorithm_AddColumnPair_02(GetCppThis(), namColX, namColY);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_Aggregate_03(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// </summary>
	public virtual void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkStatisticsAlgorithm_Aggregate_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStatisticsAlgorithm_GetAssessNames_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get assessment names.
	/// </summary>
	public virtual vtkStringArray GetAssessNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStatisticsAlgorithm_GetAssessNames_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStatisticsAlgorithm_GetAssessOption_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the Assess operation.
	/// </summary>
	public virtual bool GetAssessOption()
	{
		return (vtkStatisticsAlgorithm_GetAssessOption_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStatisticsAlgorithm_GetColumnForRequest_06(HandleRef pThis, long r, long c);

	/// <summary>
	/// Provide the name of the \a c-th column for the \a r-th request.
	///
	/// For the version of this routine that returns an integer,
	/// if the request or column does not exist because \a r or \a c is out of bounds,
	/// this routine returns 0 and the value of \a columnName is unspecified.
	/// Otherwise, it returns 1 and the value of \a columnName is set.
	///
	/// For the version of this routine that returns const char*,
	/// if the request or column does not exist because \a r or \a c is out of bounds,
	/// the routine returns nullptr. Otherwise it returns the column name.
	/// This version is not thread-safe.
	/// </summary>
	public virtual string GetColumnForRequest(long r, long c)
	{
		return Marshal.PtrToStringAnsi(vtkStatisticsAlgorithm_GetColumnForRequest_06(GetCppThis(), r, c));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticsAlgorithm_GetColumnForRequest_07(HandleRef pThis, long r, long c, string columnName);

	/// <summary>
	/// Provide the name of the \a c-th column for the \a r-th request.
	///
	/// For the version of this routine that returns an integer,
	/// if the request or column does not exist because \a r or \a c is out of bounds,
	/// this routine returns 0 and the value of \a columnName is unspecified.
	/// Otherwise, it returns 1 and the value of \a columnName is set.
	///
	/// For the version of this routine that returns const char*,
	/// if the request or column does not exist because \a r or \a c is out of bounds,
	/// the routine returns nullptr. Otherwise it returns the column name.
	/// This version is not thread-safe.
	/// </summary>
	public virtual int GetColumnForRequest(long r, long c, string columnName)
	{
		return vtkStatisticsAlgorithm_GetColumnForRequest_07(GetCppThis(), r, c, columnName);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStatisticsAlgorithm_GetDeriveOption_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the Derive operation.
	/// </summary>
	public virtual bool GetDeriveOption()
	{
		return (vtkStatisticsAlgorithm_GetDeriveOption_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStatisticsAlgorithm_GetLearnOption_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the Learn operation.
	/// </summary>
	public virtual bool GetLearnOption()
	{
		return (vtkStatisticsAlgorithm_GetLearnOption_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStatisticsAlgorithm_GetNumberOfColumnsForRequest_10(HandleRef pThis, long request);

	/// <summary>
	/// Return the number of columns for a given request.
	/// </summary>
	public virtual long GetNumberOfColumnsForRequest(long request)
	{
		return vtkStatisticsAlgorithm_GetNumberOfColumnsForRequest_10(GetCppThis(), request);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStatisticsAlgorithm_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStatisticsAlgorithm_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStatisticsAlgorithm_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStatisticsAlgorithm_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStatisticsAlgorithm_GetNumberOfPrimaryTables_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of tables in the primary model.
	/// </summary>
	public virtual long GetNumberOfPrimaryTables()
	{
		return vtkStatisticsAlgorithm_GetNumberOfPrimaryTables_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStatisticsAlgorithm_GetNumberOfRequests_14(HandleRef pThis);

	/// <summary>
	/// Return the number of requests.
	/// This does not include any request that is in the column-status buffer
	/// but for which RequestSelectedColumns() has not yet been called (even though
	/// it is possible this request will be honored when the filter is run -- see SetColumnStatus()
	/// for more information).
	/// </summary>
	public virtual long GetNumberOfRequests()
	{
		return vtkStatisticsAlgorithm_GetNumberOfRequests_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStatisticsAlgorithm_GetTestOption_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the Test operation.
	/// </summary>
	public virtual bool GetTestOption()
	{
		return (vtkStatisticsAlgorithm_GetTestOption_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticsAlgorithm_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStatisticsAlgorithm_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticsAlgorithm_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStatisticsAlgorithm_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStatisticsAlgorithm_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStatisticsAlgorithm NewInstance()
	{
		vtkStatisticsAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStatisticsAlgorithm_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticsAlgorithm_RequestSelectedColumns_19(HandleRef pThis);

	/// <summary>
	/// Use the current column status values to produce a new request for statistics
	/// to be produced when RequestData() is called. See SetColumnStatus() for more information.
	/// </summary>
	public virtual int RequestSelectedColumns()
	{
		return vtkStatisticsAlgorithm_RequestSelectedColumns_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_ResetAllColumnStates_20(HandleRef pThis);

	/// <summary>
	/// Set the status of each and every column in the current request to OFF (0).
	/// </summary>
	public virtual void ResetAllColumnStates()
	{
		vtkStatisticsAlgorithm_ResetAllColumnStates_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_ResetRequests_21(HandleRef pThis);

	/// <summary>
	/// Empty the list of current requests.
	/// </summary>
	public virtual void ResetRequests()
	{
		vtkStatisticsAlgorithm_ResetRequests_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStatisticsAlgorithm_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStatisticsAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkStatisticsAlgorithm vtkStatisticsAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStatisticsAlgorithm_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStatisticsAlgorithm2 = (vtkStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStatisticsAlgorithm2.Register(null);
			}
		}
		return vtkStatisticsAlgorithm2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetAssessNames_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get assessment names.
	/// </summary>
	public virtual void SetAssessNames(vtkStringArray arg0)
	{
		vtkStatisticsAlgorithm_SetAssessNames_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetAssessOption_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the Assess operation.
	/// </summary>
	public virtual void SetAssessOption(bool _arg)
	{
		vtkStatisticsAlgorithm_SetAssessOption_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetColumnStatus_25(HandleRef pThis, string namCol, int status);

	/// <summary>
	/// Add or remove a column from the current analysis request.
	/// Once all the column status values are set, call RequestSelectedColumns()
	/// before selecting another set of columns for a different analysis request.
	/// The way that columns selections are used varies from algorithm to algorithm.
	///
	/// Note: the set of selected columns is maintained in vtkStatisticsAlgorithmPrivate::Buffer
	/// until RequestSelectedColumns() is called, at which point the set is appended
	/// to vtkStatisticsAlgorithmPrivate::Requests.
	/// If there are any columns in vtkStatisticsAlgorithmPrivate::Buffer at the time
	/// RequestData() is called, RequestSelectedColumns() will be called and the
	/// selection added to the list of requests.
	/// </summary>
	public virtual void SetColumnStatus(string namCol, int status)
	{
		vtkStatisticsAlgorithm_SetColumnStatus_25(GetCppThis(), namCol, status);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetDeriveOption_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the Derive operation.
	/// </summary>
	public virtual void SetDeriveOption(bool _arg)
	{
		vtkStatisticsAlgorithm_SetDeriveOption_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetInputModel_27(HandleRef pThis, HandleRef model);

	/// <summary>
	/// A convenience method for setting the input model (if one is expected or allowed).
	/// It is equivalent to calling SetInputData( 2, model );
	/// </summary>
	public virtual void SetInputModel(vtkDataObject model)
	{
		vtkStatisticsAlgorithm_SetInputModel_27(GetCppThis(), model?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetInputModelConnection_28(HandleRef pThis, HandleRef model);

	/// <summary>
	/// A convenience method for setting the input model connection (if one is expected or allowed).
	/// It is equivalent to calling SetInputConnection( 2, model );
	/// </summary>
	public virtual void SetInputModelConnection(vtkAlgorithmOutput model)
	{
		vtkStatisticsAlgorithm_SetInputModelConnection_28(GetCppThis(), model?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetLearnOption_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the Learn operation.
	/// </summary>
	public virtual void SetLearnOption(bool _arg)
	{
		vtkStatisticsAlgorithm_SetLearnOption_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetLearnOptionParameterConnection_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method for setting learn input parameters (if one is expected or allowed).
	/// It is equivalent to calling SetInputConnection( 1, params );
	/// </summary>
	public virtual void SetLearnOptionParameterConnection(vtkAlgorithmOutput arg0)
	{
		vtkStatisticsAlgorithm_SetLearnOptionParameterConnection_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetLearnOptionParameters_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method for setting learn input parameters (if one is expected or allowed).
	/// It is equivalent to calling SetInputData( 1, params );
	/// </summary>
	public virtual void SetLearnOptionParameters(vtkDataObject arg0)
	{
		vtkStatisticsAlgorithm_SetLearnOptionParameters_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetNumberOfPrimaryTables_32(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/Get the number of tables in the primary model.
	/// </summary>
	public virtual void SetNumberOfPrimaryTables(long _arg)
	{
		vtkStatisticsAlgorithm_SetNumberOfPrimaryTables_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStatisticsAlgorithm_SetParameter_33(HandleRef pThis, string parameter, int index, HandleRef value);

	/// <summary>
	/// A convenience method (in particular for access from other applications) to
	/// set parameter values of Learn mode.
	/// Return true if setting of requested parameter name was executed, false otherwise.
	/// NB: default method (which is sufficient for most statistics algorithms) does not
	/// have any Learn parameters to set and always returns false.
	/// </summary>
	public virtual bool SetParameter(string parameter, int index, vtkVariant value)
	{
		return (vtkStatisticsAlgorithm_SetParameter_33(GetCppThis(), parameter, index, value?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticsAlgorithm_SetTestOption_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the Test operation.
	/// </summary>
	public virtual void SetTestOption(bool _arg)
	{
		vtkStatisticsAlgorithm_SetTestOption_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
