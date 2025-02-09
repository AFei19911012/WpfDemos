using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKMeansStatistics
/// </summary>
/// <remarks>
///    A class for KMeans clustering
///
///
/// This class takes as input an optional vtkTable on port LEARN_PARAMETERS
/// specifying initial  set(s) of cluster values of the following form:
/// &lt;pre&gt;
///           K     | Col1            |  ...    | ColN
///      -----------+-----------------+---------+---------------
///           M     |clustCoord(1, 1) |  ...    | clustCoord(1, N)
///           M     |clustCoord(2, 1) |  ...    | clustCoord(2, N)
///           .     |       .         |   .     |        .
///           .     |       .         |   .     |        .
///           .     |       .         |   .     |        .
///           M     |clustCoord(M, 1) |  ...    | clustCoord(M, N)
///           L     |clustCoord(1, 1) |  ...    | clustCoord(1, N)
///           L     |clustCoord(2, 1) |  ...    | clustCoord(2, N)
///           .     |       .         |   .     |        .
///           .     |       .         |   .     |        .
///           .     |       .         |   .     |        .
///           L     |clustCoord(L, 1) |  ...    | clustCoord(L, N)
/// &lt;/pre&gt;
///
/// Because the desired value of K is often not known in advance and the
/// results of the algorithm are dependent on the initial cluster centers,
/// we provide a mechanism for the user to test multiple runs or sets of cluster centers
/// within a single call to the Learn phase.  The first column of the table identifies
/// the number of clusters K in the particular run (the entries in this column should be
/// of type vtkIdType), while the remaining columns are a
/// subset of the columns contained in the table on port INPUT_DATA.  We require that
/// all user specified clusters be of the same dimension N and consequently, that the
/// LEARN_PARAMETERS table have N+1 columns. Due to this restriction, only one request
/// can be processed for each call to the Learn phase and subsequent requests are
/// silently ignored. Note that, if the first column of the LEARN_PARAMETERS table is not
/// of type vtkIdType, then the table will be ignored and a single run will be performed using
/// the first DefaultNumberOfClusters input data observations as initial cluster centers.
///
/// When the user does not supply an initial set of clusters, then the first
/// DefaultNumberOfClusters input data observations are used as initial cluster
/// centers and a single run is performed.
///
///
/// This class provides the following functionalities, depending on the operation
/// in which it is executed:
/// * Learn: calculates new cluster centers for each run.  The output metadata on
///   port OUTPUT_MODEL is a multiblock dataset containing at a minimum
///   one vtkTable with columns specifying the following for each run:
///   the run ID, number of clusters, number of iterations required for convergence,
///   total error associated with the cluster (sum of squared Euclidean distance from each
/// observation to its nearest cluster center), the cardinality of the cluster, and the new cluster
/// coordinates.
///
/// * Derive:  An additional vtkTable is stored in the multiblock dataset output on port
/// OUTPUT_MODEL. This table contains columns that store for each run: the runID, number of clusters,
///   total error for all clusters in the run, local rank, and global rank.
///   The local rank is computed by comparing squared Euclidean errors of all runs with
///   the same number of clusters.  The global rank is computed analagously across all runs.
///
/// * Assess: This requires a multiblock dataset (as computed from Learn and Derive) on input port
/// INPUT_MODEL and tabular data on input port INPUT_DATA that contains column names matching those
///   of the tables on input port INPUT_MODEL. The assess mode reports the closest cluster center
///   and associated squared Euclidean distance of each observation in port INPUT_DATA's table to the
/// cluster centers for each run in the multiblock dataset provided on port INPUT_MODEL.
///
/// The code can handle a wide variety of data types as it operates on vtkAbstractArrays
/// and is not limited to vtkDataArrays.  A default distance functor that
/// computes the sum of the squares of the Euclidean distance between two objects is provided
/// (vtkKMeansDistanceFunctor). The default distance functor can be overridden to use alternative
/// distance metrics.
///
/// @par Thanks:
/// Thanks to Janine Bennett, David Thompson, and Philippe Pebay of
/// Sandia National Laboratories for implementing this class.
/// Updated by Philippe Pebay, Kitware SAS 2012
/// </remarks>
public class vtkKMeansStatistics : vtkStatisticsAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKMeansStatistics()
	{
		MRClassNameKey = "class vtkKMeansStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKMeansStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKMeansStatistics New()
	{
		vtkKMeansStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKMeansStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKMeansStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkKMeansStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Given a collection of models, calculate aggregate model
	/// NB: not implemented
	/// </summary>
	public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
	{
		vtkKMeansStatistics_Aggregate_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansStatistics_GetDefaultNumberOfClusters_02(HandleRef pThis);

	/// <summary>
	/// Set/get the \a DefaultNumberOfClusters, used when no initial cluster coordinates are specified.
	/// </summary>
	public virtual int GetDefaultNumberOfClusters()
	{
		return vtkKMeansStatistics_GetDefaultNumberOfClusters_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansStatistics_GetDistanceFunctor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the DistanceFunctor.
	/// </summary>
	public virtual vtkKMeansDistanceFunctor GetDistanceFunctor()
	{
		vtkKMeansDistanceFunctor vtkKMeansDistanceFunctor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansStatistics_GetDistanceFunctor_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKMeansDistanceFunctor2 = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKMeansDistanceFunctor2.Register(null);
			}
		}
		return vtkKMeansDistanceFunctor2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkKMeansStatistics_GetGhostsToSkip_04(HandleRef pThis);

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
		return vtkKMeansStatistics_GetGhostsToSkip_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansStatistics_GetKValuesArrayName_05(HandleRef pThis);

	/// <summary>
	/// Set/get the KValuesArrayName.
	/// </summary>
	public virtual string GetKValuesArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkKMeansStatistics_GetKValuesArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansStatistics_GetMaxNumIterations_06(HandleRef pThis);

	/// <summary>
	/// Set/get the MaxNumIterations used to terminate iterations on
	/// cluster center coordinates when the relative tolerance can not be met.
	/// </summary>
	public virtual int GetMaxNumIterations()
	{
		return vtkKMeansStatistics_GetMaxNumIterations_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKMeansStatistics_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKMeansStatistics_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKMeansStatistics_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKMeansStatistics_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKMeansStatistics_GetTolerance_09(HandleRef pThis);

	/// <summary>
	/// Set/get the relative \a Tolerance used to terminate iterations on
	/// cluster center coordinates.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkKMeansStatistics_GetTolerance_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansStatistics_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKMeansStatistics_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansStatistics_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKMeansStatistics_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansStatistics_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKMeansStatistics NewInstance()
	{
		vtkKMeansStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansStatistics_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansStatistics_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKMeansStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkKMeansStatistics vtkKMeansStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansStatistics_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKMeansStatistics2 = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKMeansStatistics2.Register(null);
			}
		}
		return vtkKMeansStatistics2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansStatistics_SetDefaultNumberOfClusters_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the \a DefaultNumberOfClusters, used when no initial cluster coordinates are specified.
	/// </summary>
	public virtual void SetDefaultNumberOfClusters(int _arg)
	{
		vtkKMeansStatistics_SetDefaultNumberOfClusters_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansStatistics_SetDistanceFunctor_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the DistanceFunctor.
	/// </summary>
	public virtual void SetDistanceFunctor(vtkKMeansDistanceFunctor arg0)
	{
		vtkKMeansStatistics_SetDistanceFunctor_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansStatistics_SetGhostsToSkip_17(HandleRef pThis, byte _arg);

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
		vtkKMeansStatistics_SetGhostsToSkip_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansStatistics_SetKValuesArrayName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the KValuesArrayName.
	/// </summary>
	public virtual void SetKValuesArrayName(string _arg)
	{
		vtkKMeansStatistics_SetKValuesArrayName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansStatistics_SetMaxNumIterations_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the MaxNumIterations used to terminate iterations on
	/// cluster center coordinates when the relative tolerance can not be met.
	/// </summary>
	public virtual void SetMaxNumIterations(int _arg)
	{
		vtkKMeansStatistics_SetMaxNumIterations_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkKMeansStatistics_SetParameter_20(HandleRef pThis, string parameter, int index, HandleRef value);

	/// <summary>
	/// A convenience method for setting properties by name.
	/// </summary>
	public override bool SetParameter(string parameter, int index, vtkVariant value)
	{
		return (vtkKMeansStatistics_SetParameter_20(GetCppThis(), parameter, index, value?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansStatistics_SetTolerance_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the relative \a Tolerance used to terminate iterations on
	/// cluster center coordinates.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkKMeansStatistics_SetTolerance_21(GetCppThis(), _arg);
	}
}
