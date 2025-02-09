using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractInterpolatedVelocityField
/// </summary>
/// <remarks>
///    An abstract class for
///  obtaining the interpolated velocity values at a point
///
///
///  vtkAbstractInterpolatedVelocityField acts as a continuous velocity field
///  by performing cell interpolation on the underlying vtkDataSet (or in the
///  case of vtkCompositeInterpolatedVelocityField,
///  vtkCompositeDataSets). This is an abstract sub-class of vtkFunctionSet,
///  NumberOfIndependentVariables = 4 (x,y,z,t) and NumberOfFunctions = 3
///  (u,v,w). With a brute-force scheme, every time an evaluation is
///  performed, the target cell containing point (x,y,z) needs to be found by
///  calling FindCell(); however vtkAbstractInterpolatedVelocityField uses
///  locators to accelerate this operation via an instance of
///  vtkFindCellStrategy. Even with the use of locators, the cost of the find
///  cell operation can be large, hence this class performs local caching to
///  reduce the number of invocations of FindCell(). As a result, this class
///  is not thread safe as it contains local state (such as the cache
///  information). Writing a threaded operations requires separate instances of
///  vtkAbstractInterpolatedVelocityField for each thread.
///
///  For vtkCompositeInterpolatedVelocityField with CLOSEST_POINT strategy,
///  level #0 begins with intra-cell caching.
///  Specifically if the previous cell is valid and the next point is still in
///  it ( i.e., vtkCell::EvaluatePosition() returns 1, coupled with newly created
///  parametric coordinates &amp; weights ), the function values can be interpolated
///  and only vtkCell::EvaluatePosition() is invoked. If this fails, then level #1
///  follows by inter-cell search for the target cell that contains the next point.
///  By an inter-cell search, the previous cell provides an important clue or serves
///  as an immediate neighbor to aid in locating the target cell via vtkPointSet::
///  FindCell(). If this still fails, a global cell location / search is invoked via
///  vtkFindCellStrategy. Finally, if this operation fails, the streamline is
///  considered terminated.
///
///  Note the particular find cell strategy employed can affect the behavior
///  of this class. If the strategy involved using a point locator (e.g.,
///  vtkStaticPointLocator or vtkPointLocator via vtkClosestPointStrategy or
///  vtkClosestNPointsStrategy) the performance of the class improves to the
///  detriment of robustness. Using a cell locator (e.g., vtkStaticCellLocator
///  or vtkCellLocator via vtkCellLocatorStrategy) improves robustness at some
///  cost to performance. Originally, these different behaviors (i.e., using
///  different locators) was codified into different subclasses of
///  vtkAbstractInterpolatedVelocityField.
///
///  Note that topologically structured classes such as vtkImageData and
///  vtkRectilinearGrid are able to provide fast robust cell location. Hence
///  the specified find cell strategy is only applicable to subclasses of
///  vtkPointSet (such as vtkUnstructuredGrid).
///
///
/// @warning
///  vtkAbstractInterpolatedVelocityField is not thread safe. A new instance
///  should be created by each thread.
///
/// </remarks>
/// <seealso>
///
///  vtkCompositeInterpolatedVelocityField vtkAMRInterpolatedVelocityField
///  vtkGenericInterpolatedVelocityField vtkCachingInterpolatedVelocityField
///  vtkTemporalInterpolatedVelocityField vtkFunctionSet vtkStreamTracer
///  vtkFindCellStrategy
/// </seealso>
public abstract class vtkAbstractInterpolatedVelocityField : vtkFunctionSet
{
	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public enum VelocityFieldInitializationState
	{
		/// <summary>enum member</summary>
		INITIALIZE_ALL_DATASETS = 1,
		/// <summary>enum member</summary>
		NOT_INITIALIZED = 0,
		/// <summary>enum member</summary>
		SELF_INITIALIZE = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractInterpolatedVelocityField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractInterpolatedVelocityField()
	{
		MRClassNameKey = "class vtkAbstractInterpolatedVelocityField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractInterpolatedVelocityField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_ClearLastCellId_01(HandleRef pThis);

	/// <summary>
	/// Set the last cell id to -1 to incur a global cell search for the next point.
	/// </summary>
	public void ClearLastCellId()
	{
		vtkAbstractInterpolatedVelocityField_ClearLastCellId_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_CopyParameters_02(HandleRef pThis, HandleRef from);

	/// <summary>
	/// Copy essential parameters between instances of this class. This
	/// generally is used to copy from instance prototype to another, or to copy
	/// interpolators between thread instances.  Sub-classes can contribute to
	/// the parameter copying process via chaining.
	/// </summary>
	public virtual void CopyParameters(vtkAbstractInterpolatedVelocityField from)
	{
		vtkAbstractInterpolatedVelocityField_CopyParameters_02(GetCppThis(), from?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_FunctionValues_03(HandleRef pThis, IntPtr x, IntPtr f);

	/// <summary>
	/// Evaluate the velocity field f at point (x, y, z).
	/// </summary>
	public override int FunctionValues(IntPtr x, IntPtr f)
	{
		return vtkAbstractInterpolatedVelocityField_FunctionValues_03(GetCppThis(), x, f);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_GetCacheHit_04(HandleRef pThis);

	/// <summary>
	/// Get the caching statistics. CacheHit refers to the number of level #0 cache
	/// hits while CacheMiss is the number of level #0 cache misses.
	/// </summary>
	public virtual int GetCacheHit()
	{
		return vtkAbstractInterpolatedVelocityField_GetCacheHit_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_GetCacheMiss_05(HandleRef pThis);

	/// <summary>
	/// Get the caching statistics. CacheHit refers to the number of level #0 cache
	/// hits while CacheMiss is the number of level #0 cache misses.
	/// </summary>
	public virtual int GetCacheMiss()
	{
		return vtkAbstractInterpolatedVelocityField_GetCacheMiss_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractInterpolatedVelocityField_GetCaching_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the caching flag. If this flag is turned ON, there are two levels
	/// of caching for when the strategy is CLOSEST_POINT and one level of caching
	/// when the strategy is CELL_LOCATOR. Otherwise a global cell location is always
	/// invoked for evaluating the function values at any point.
	/// </summary>
	public virtual bool GetCaching()
	{
		return (vtkAbstractInterpolatedVelocityField_GetCaching_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractInterpolatedVelocityField_GetFindCellStrategy_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the strategy used to perform the FindCell() operation. This
	/// strategy is used when operating on vtkPointSet subclasses. Note if the
	/// input is a composite dataset then the strategy will be used to clone
	/// one strategy per leaf dataset.
	/// </summary>
	public virtual vtkFindCellStrategy GetFindCellStrategy()
	{
		vtkFindCellStrategy vtkFindCellStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractInterpolatedVelocityField_GetFindCellStrategy_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFindCellStrategy2 = (vtkFindCellStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFindCellStrategy2.Register(null);
			}
		}
		return vtkFindCellStrategy2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractInterpolatedVelocityField_GetForceSurfaceTangentVector_08(HandleRef pThis);

	/// <summary>
	/// If set to true, the first three point of the cell will be used to compute a normal to the cell,
	/// this normal will then be removed from the vorticity so the resulting vector in tangent to the
	/// cell.
	/// </summary>
	public virtual bool GetForceSurfaceTangentVector()
	{
		return (vtkAbstractInterpolatedVelocityField_GetForceSurfaceTangentVector_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_GetInitializationState_09(HandleRef pThis);

	/// <summary>
	/// The Initialize() method is used to build and cache supporting structures
	/// (such as locators) which are used when operating on the interpolated
	/// velocity field. This method is needed mainly to deal with thread safety
	/// issues; i.e., these supporting structures must be built at the right
	/// time to avoid race conditions. Currently this method is used by
	/// vtkStreamTracer (and related classes) which process composite datasets
	/// (in the future other dataset types may be supported). Also, a
	/// initialization strategy can be specified which controls how the
	/// initialization process functions (this is a API placeholder for the
	/// future). Note that some subclasses may override the initialize
	/// method (via SelfInitialize()) because they have special methods of
	/// setting up the interpolated velocity field.
	/// </summary>
	public virtual int GetInitializationState()
	{
		return vtkAbstractInterpolatedVelocityField_GetInitializationState_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractInterpolatedVelocityField_GetLastCellId_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the id of the cell cached from last evaluation.
	/// </summary>
	public virtual long GetLastCellId()
	{
		return vtkAbstractInterpolatedVelocityField_GetLastCellId_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractInterpolatedVelocityField_GetLastDataSet_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the caching statistics. CacheHit refers to the number of level #0 cache
	/// hits while CacheMiss is the number of level #0 cache misses.
	/// </summary>
	public virtual vtkDataSet GetLastDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractInterpolatedVelocityField_GetLastDataSet_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_GetLastLocalCoordinates_12(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Get the interpolation weights cached from last evaluation. Return 1 if the
	/// cached cell is valid and 0 otherwise.
	/// </summary>
	public int GetLastLocalCoordinates(IntPtr pcoords)
	{
		return vtkAbstractInterpolatedVelocityField_GetLastLocalCoordinates_12(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_GetLastWeights_13(HandleRef pThis, IntPtr w);

	/// <summary>
	/// Get the interpolation weights cached from last evaluation. Return 1 if the
	/// cached cell is valid and 0 otherwise.
	/// </summary>
	public int GetLastWeights(IntPtr w)
	{
		return vtkAbstractInterpolatedVelocityField_GetLastWeights_13(GetCppThis(), w);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractInterpolatedVelocityField_GetNormalizeVector_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag indicating vector post-normalization (following vector
	/// interpolation). Vector post-normalization is required to avoid the
	/// 'curve-overshooting' problem (caused by high velocity magnitude) that
	/// occurs when Cell-Length is used as the step size unit (particularly the
	/// Minimum step size unit). Furthermore, it is required by RK45 to achieve,
	/// as expected, high numerical accuracy (or high smoothness of flow lines)
	/// through adaptive step sizing. Note this operation is performed (when
	/// NormalizeVector TRUE) right after vector interpolation such that the
	/// differing amount of contribution of each node (of a cell) to the
	/// resulting direction of the interpolated vector, due to the possibly
	/// significantly-differing velocity magnitude values at the nodes (which is
	/// the case with large cells), can be reflected as is. Also note that this
	/// flag needs to be turned to FALSE after vtkInitialValueProblemSolver::
	/// ComputeNextStep() as subsequent operations, e.g., vorticity computation,
	/// may need non-normalized vectors.
	/// </summary>
	public virtual bool GetNormalizeVector()
	{
		return (vtkAbstractInterpolatedVelocityField_GetNormalizeVector_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractInterpolatedVelocityField_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractInterpolatedVelocityField_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractInterpolatedVelocityField_GetSurfaceDataset_17(HandleRef pThis);

	/// <summary>
	/// If set to true, cell within tolerance factor will always be found, except for edges.
	/// </summary>
	public virtual bool GetSurfaceDataset()
	{
		return (vtkAbstractInterpolatedVelocityField_GetSurfaceDataset_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractInterpolatedVelocityField_GetVectorsSelection_18(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of a specified vector array. By default it is nullptr, with
	/// the active vector array for use.
	/// </summary>
	public virtual string GetVectorsSelection()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractInterpolatedVelocityField_GetVectorsSelection_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_GetVectorsType_19(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of a specified vector array. By default it is nullptr, with
	/// the active vector array for use.
	/// </summary>
	public virtual int GetVectorsType()
	{
		return vtkAbstractInterpolatedVelocityField_GetVectorsType_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_Initialize_20(HandleRef pThis, HandleRef compDS, int initStrategy);

	/// <summary>
	/// The Initialize() method is used to build and cache supporting structures
	/// (such as locators) which are used when operating on the interpolated
	/// velocity field. This method is needed mainly to deal with thread safety
	/// issues; i.e., these supporting structures must be built at the right
	/// time to avoid race conditions. Currently this method is used by
	/// vtkStreamTracer (and related classes) which process composite datasets
	/// (in the future other dataset types may be supported). Also, a
	/// initialization strategy can be specified which controls how the
	/// initialization process functions (this is a API placeholder for the
	/// future). Note that some subclasses may override the initialize
	/// method (via SelfInitialize()) because they have special methods of
	/// setting up the interpolated velocity field.
	/// </summary>
	public virtual void Initialize(vtkCompositeDataSet compDS, int initStrategy)
	{
		vtkAbstractInterpolatedVelocityField_Initialize_20(GetCppThis(), compDS?.GetCppThis() ?? default(HandleRef), initStrategy);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_IsA_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractInterpolatedVelocityField_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractInterpolatedVelocityField_IsTypeOf_22(string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractInterpolatedVelocityField_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractInterpolatedVelocityField_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new vtkAbstractInterpolatedVelocityField NewInstance()
	{
		vtkAbstractInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractInterpolatedVelocityField_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractInterpolatedVelocityField_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing the object state.
	/// </summary>
	public new static vtkAbstractInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractInterpolatedVelocityField vtkAbstractInterpolatedVelocityField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractInterpolatedVelocityField_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractInterpolatedVelocityField2 = (vtkAbstractInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractInterpolatedVelocityField2.Register(null);
			}
		}
		return vtkAbstractInterpolatedVelocityField2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_SelectVectors_25(HandleRef pThis, int fieldAssociation, string fieldName);

	/// <summary>
	/// the association type (see vtkDataObject::FieldAssociations)
	/// and the name of the velocity data field
	/// </summary>
	public void SelectVectors(int fieldAssociation, string fieldName)
	{
		vtkAbstractInterpolatedVelocityField_SelectVectors_25(GetCppThis(), fieldAssociation, fieldName);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_SetCaching_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the caching flag. If this flag is turned ON, there are two levels
	/// of caching for when the strategy is CLOSEST_POINT and one level of caching
	/// when the strategy is CELL_LOCATOR. Otherwise a global cell location is always
	/// invoked for evaluating the function values at any point.
	/// </summary>
	public virtual void SetCaching(bool _arg)
	{
		vtkAbstractInterpolatedVelocityField_SetCaching_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_SetFindCellStrategy_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get the strategy used to perform the FindCell() operation. This
	/// strategy is used when operating on vtkPointSet subclasses. Note if the
	/// input is a composite dataset then the strategy will be used to clone
	/// one strategy per leaf dataset.
	/// </summary>
	public virtual void SetFindCellStrategy(vtkFindCellStrategy arg0)
	{
		vtkAbstractInterpolatedVelocityField_SetFindCellStrategy_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_SetForceSurfaceTangentVector_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set to true, the first three point of the cell will be used to compute a normal to the cell,
	/// this normal will then be removed from the vorticity so the resulting vector in tangent to the
	/// cell.
	/// </summary>
	public virtual void SetForceSurfaceTangentVector(bool _arg)
	{
		vtkAbstractInterpolatedVelocityField_SetForceSurfaceTangentVector_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_SetLastCellId_29(HandleRef pThis, long c);

	/// <summary>
	/// Get/Set the id of the cell cached from last evaluation.
	/// </summary>
	public virtual void SetLastCellId(long c)
	{
		vtkAbstractInterpolatedVelocityField_SetLastCellId_29(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_SetLastCellId_30(HandleRef pThis, long c, int dataindex);

	/// <summary>
	/// Set the id of the most recently visited cell of a dataset.
	/// </summary>
	public virtual void SetLastCellId(long c, int dataindex)
	{
		vtkAbstractInterpolatedVelocityField_SetLastCellId_30(GetCppThis(), c, dataindex);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_SetNormalizeVector_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the flag indicating vector post-normalization (following vector
	/// interpolation). Vector post-normalization is required to avoid the
	/// 'curve-overshooting' problem (caused by high velocity magnitude) that
	/// occurs when Cell-Length is used as the step size unit (particularly the
	/// Minimum step size unit). Furthermore, it is required by RK45 to achieve,
	/// as expected, high numerical accuracy (or high smoothness of flow lines)
	/// through adaptive step sizing. Note this operation is performed (when
	/// NormalizeVector TRUE) right after vector interpolation such that the
	/// differing amount of contribution of each node (of a cell) to the
	/// resulting direction of the interpolated vector, due to the possibly
	/// significantly-differing velocity magnitude values at the nodes (which is
	/// the case with large cells), can be reflected as is. Also note that this
	/// flag needs to be turned to FALSE after vtkInitialValueProblemSolver::
	/// ComputeNextStep() as subsequent operations, e.g., vorticity computation,
	/// may need non-normalized vectors.
	/// </summary>
	public virtual void SetNormalizeVector(bool _arg)
	{
		vtkAbstractInterpolatedVelocityField_SetNormalizeVector_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractInterpolatedVelocityField_SetSurfaceDataset_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set to true, cell within tolerance factor will always be found, except for edges.
	/// </summary>
	public virtual void SetSurfaceDataset(bool _arg)
	{
		vtkAbstractInterpolatedVelocityField_SetSurfaceDataset_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
