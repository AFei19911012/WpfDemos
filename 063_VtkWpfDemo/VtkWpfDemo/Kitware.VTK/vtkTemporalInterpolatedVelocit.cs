using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalInterpolatedVelocityField
/// </summary>
/// <remarks>
///    A helper class for interpolating between times during particle tracing
///
/// vtkTemporalInterpolatedVelocityField is a general purpose
/// helper for the temporal particle tracing code (vtkParticleTracerBase)
///
/// It maintains two copies of vtkCompositeInterpolatedVelocityField internally
/// and uses them to obtain velocity values at time T0 and T1.
///
/// In fact the class does quite a bit more than this because when the geometry
/// of the datasets is the same at T0 and T1, we can re-use cached cell Ids and
/// weights used in the cell interpolation routines.
/// Additionally, the same weights can be used when interpolating (point) scalar
/// values and computing vorticity etc.
///
/// @warning
/// vtkTemporalInterpolatedVelocityField is not thread safe.
/// A new instance should be created by each thread.
///
/// @warning
/// Datasets are added in lists. The list for T1 must be identical to that for T0
/// in structure/topology and dataset order, and any datasets marked as static,
/// must remain so for all T - changing a dataset from static to dynamic
/// between time steps will result in undefined behaviour (=crash probably)
///
///
/// </remarks>
/// <seealso>
///
/// vtkCompositeInterpolatedVelocityField vtkParticleTracerBase
/// vtkParticleTracer vtkParticlePathFilter vtkStreaklineFilter
/// </seealso>
public class vtkTemporalInterpolatedVelocityField : vtkFunctionSet
{
	/// <summary>
	/// States that define where the cell id are
	/// </summary>
	public enum IDStates
	{
		/// <summary>enum member</summary>
		INSIDE_ALL,
		/// <summary>enum member</summary>
		OUTSIDE_ALL,
		/// <summary>enum member</summary>
		OUTSIDE_T0,
		/// <summary>enum member</summary>
		OUTSIDE_T1
	}

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public enum MeshOverTimeTypes
	{
		/// <summary>enum member</summary>
		DIFFERENT = 0,
		/// <summary>enum member</summary>
		LINEAR_TRANSFORMATION = 2,
		/// <summary>enum member</summary>
		SAME_TOPOLOGY = 3,
		/// <summary>enum member</summary>
		STATIC = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalInterpolatedVelocityField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalInterpolatedVelocityField()
	{
		MRClassNameKey = "class vtkTemporalInterpolatedVelocityField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalInterpolatedVelocityField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkTemporalInterpolatedVelocityField with no initial data set.
	/// Caching is on. LastCellId is set to -1.
	/// </summary>
	public new static vtkTemporalInterpolatedVelocityField New()
	{
		vtkTemporalInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkTemporalInterpolatedVelocityField with no initial data set.
	/// Caching is on. LastCellId is set to -1.
	/// </summary>
	public vtkTemporalInterpolatedVelocityField()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalInterpolatedVelocityField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_AddDataSetAtTime_01(HandleRef pThis, int N, double T, HandleRef dataset);

	/// <summary>
	/// In order to use this class, two sets of data must be supplied,
	/// corresponding to times T1 and T2. Data is added via
	/// this function.
	/// </summary>
	public void AddDataSetAtTime(int N, double T, vtkDataSet dataset)
	{
		vtkTemporalInterpolatedVelocityField_AddDataSetAtTime_01(GetCppThis(), N, T, dataset?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_AdvanceOneTimeStep_02(HandleRef pThis);

	/// <summary>
	/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
	/// </summary>
	public void AdvanceOneTimeStep()
	{
		vtkTemporalInterpolatedVelocityField_AdvanceOneTimeStep_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_ClearCache_03(HandleRef pThis);

	/// <summary>
	/// Set the last cell id to -1 so that the next search does not
	/// start from the previous cell
	/// </summary>
	public void ClearCache()
	{
		vtkTemporalInterpolatedVelocityField_ClearCache_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_CopyParameters_04(HandleRef pThis, HandleRef from);

	/// <summary>
	/// Copy essential parameters between instances of this class. This
	/// generally is used to copy from instance prototype to another, or to copy
	/// interpolators between thread instances.  Sub-classes can contribute to
	/// the parameter copying process via chaining.
	/// </summary>
	public virtual void CopyParameters(vtkTemporalInterpolatedVelocityField from)
	{
		vtkTemporalInterpolatedVelocityField_CopyParameters_04(GetCppThis(), from?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_FunctionValues_05(HandleRef pThis, IntPtr x, IntPtr u);

	/// <summary>
	/// Evaluate the velocity field, f, at (x, y, z, t).
	/// For now, t is ignored.
	/// </summary>
	public override int FunctionValues(IntPtr x, IntPtr u)
	{
		return vtkTemporalInterpolatedVelocityField_FunctionValues_05(GetCppThis(), x, u);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_FunctionValuesAtT_06(HandleRef pThis, int T, IntPtr x, IntPtr u);

	/// <summary>
	/// Evaluate the velocity field, f, at (x, y, z, t).
	/// For now, t is ignored.
	/// </summary>
	public int FunctionValuesAtT(int T, IntPtr x, IntPtr u)
	{
		return vtkTemporalInterpolatedVelocityField_FunctionValuesAtT_06(GetCppThis(), T, x, u);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalInterpolatedVelocityField_GetCachedCellIds_07(HandleRef pThis, IntPtr id, IntPtr ds);

	/// <summary>
	/// Between iterations of the Particle Tracer, Id's of the Cell
	/// are stored and then at the start of the next particle the
	/// Ids are set to 'pre-fill' the cache.
	/// </summary>
	public bool GetCachedCellIds(IntPtr id, IntPtr ds)
	{
		return (vtkTemporalInterpolatedVelocityField_GetCachedCellIds_07(GetCppThis(), id, ds) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTemporalInterpolatedVelocityField_GetCurrentWeight_08(HandleRef pThis);

	/// <summary>
	/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
	/// </summary>
	public virtual double GetCurrentWeight()
	{
		return vtkTemporalInterpolatedVelocityField_GetCurrentWeight_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalInterpolatedVelocityField_GetFindCellStrategy_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkTemporalInterpolatedVelocityField_GetFindCellStrategy_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_10(HandleRef pThis);

	/// <summary>
	/// If an interpolation was successful, we can retrieve the last computed
	/// value from here. Initial value is (0.0,0.0,0.0)
	/// </summary>
	public virtual double[] GetLastGoodVelocity()
	{
		IntPtr intPtr = vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// If an interpolation was successful, we can retrieve the last computed
	/// value from here. Initial value is (0.0,0.0,0.0)
	/// </summary>
	public virtual void GetLastGoodVelocity(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// If an interpolation was successful, we can retrieve the last computed
	/// value from here. Initial value is (0.0,0.0,0.0)
	/// </summary>
	public virtual void GetLastGoodVelocity(IntPtr _arg)
	{
		vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_GetMeshOverTime_13(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public virtual int GetMeshOverTime()
	{
		return vtkTemporalInterpolatedVelocityField_GetMeshOverTime_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_GetMeshOverTimeMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public virtual int GetMeshOverTimeMaxValue()
	{
		return vtkTemporalInterpolatedVelocityField_GetMeshOverTimeMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_GetMeshOverTimeMinValue_15(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public virtual int GetMeshOverTimeMinValue()
	{
		return vtkTemporalInterpolatedVelocityField_GetMeshOverTimeMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalInterpolatedVelocityField_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalInterpolatedVelocityField_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalInterpolatedVelocityField_GetVorticityData_18(HandleRef pThis, int T, IntPtr pcoords, IntPtr weights, HandleRef cell, HandleRef cellVectors);

	/// <summary>
	/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
	/// </summary>
	public bool GetVorticityData(int T, IntPtr pcoords, IntPtr weights, vtkGenericCell cell, vtkDoubleArray cellVectors)
	{
		return (vtkTemporalInterpolatedVelocityField_GetVorticityData_18(GetCppThis(), T, pcoords, weights, cell?.GetCppThis() ?? default(HandleRef), cellVectors?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_Initialize_19(HandleRef pThis, HandleRef t0, HandleRef t1);

	/// <summary>
	/// The Initialize() method is used to build and cache supporting structures
	/// (such as locators) which are used when operating on the interpolated
	/// velocity field. This method is needed mainly to deal with thread safety
	/// issues; i.e., these supporting structures must be built at the right
	/// time to avoid race conditions.
	/// </summary>
	public void Initialize(vtkCompositeDataSet t0, vtkCompositeDataSet t1)
	{
		vtkTemporalInterpolatedVelocityField_Initialize_19(GetCppThis(), t0?.GetCppThis() ?? default(HandleRef), t1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalInterpolatedVelocityField_InterpolatePoint_20(HandleRef pThis, HandleRef outPD1, HandleRef outPD2, long outIndex);

	/// <summary>
	/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
	/// </summary>
	public bool InterpolatePoint(vtkPointData outPD1, vtkPointData outPD2, long outIndex)
	{
		return (vtkTemporalInterpolatedVelocityField_InterpolatePoint_20(GetCppThis(), outPD1?.GetCppThis() ?? default(HandleRef), outPD2?.GetCppThis() ?? default(HandleRef), outIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalInterpolatedVelocityField_InterpolatePoint_21(HandleRef pThis, int T, HandleRef outPD1, long outIndex);

	/// <summary>
	/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
	/// </summary>
	public bool InterpolatePoint(int T, vtkPointData outPD1, long outIndex)
	{
		return (vtkTemporalInterpolatedVelocityField_InterpolatePoint_21(GetCppThis(), T, outPD1?.GetCppThis() ?? default(HandleRef), outIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalInterpolatedVelocityField_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalInterpolatedVelocityField_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalInterpolatedVelocityField_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTemporalInterpolatedVelocityField NewInstance()
	{
		vtkTemporalInterpolatedVelocityField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalInterpolatedVelocityField_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_QuickTestPoint_26(HandleRef pThis, IntPtr x);

	/// <summary>
	/// A utility function which evaluates the point at T1, T2 to see
	/// if it is inside the data at both times or only one.
	/// </summary>
	public int QuickTestPoint(IntPtr x)
	{
		return vtkTemporalInterpolatedVelocityField_QuickTestPoint_26(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalInterpolatedVelocityField_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalInterpolatedVelocityField vtkTemporalInterpolatedVelocityField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalInterpolatedVelocityField_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalInterpolatedVelocityField2 = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalInterpolatedVelocityField2.Register(null);
			}
		}
		return vtkTemporalInterpolatedVelocityField2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_SelectVectors_28(HandleRef pThis, string fieldName);

	/// <summary>
	/// If you want to work with an arbitrary vector array, then set its name
	/// here. By default this is nullptr and the filter will use the active vector
	/// array.
	/// </summary>
	public void SelectVectors(string fieldName)
	{
		vtkTemporalInterpolatedVelocityField_SelectVectors_28(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_SetCachedCellIds_29(HandleRef pThis, IntPtr id, IntPtr ds);

	/// <summary>
	/// Between iterations of the Particle Tracer, Id's of the Cell
	/// are stored and then at the start of the next particle the
	/// Ids are set to 'pre-fill' the cache.
	/// </summary>
	public void SetCachedCellIds(IntPtr id, IntPtr ds)
	{
		vtkTemporalInterpolatedVelocityField_SetCachedCellIds_29(GetCppThis(), id, ds);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_SetFindCellStrategy_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get the strategy used to perform the FindCell() operation. This
	/// strategy is used when operating on vtkPointSet subclasses. Note if the
	/// input is a composite dataset then the strategy will be used to clone
	/// one strategy per leaf dataset.
	/// </summary>
	public virtual void SetFindCellStrategy(vtkFindCellStrategy arg0)
	{
		vtkTemporalInterpolatedVelocityField_SetFindCellStrategy_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTime_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public virtual void SetMeshOverTime(int _arg)
	{
		vtkTemporalInterpolatedVelocityField_SetMeshOverTime_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToDifferent_32(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public void SetMeshOverTimeToDifferent()
	{
		vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToDifferent_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToLinearTransformation_33(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public void SetMeshOverTimeToLinearTransformation()
	{
		vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToLinearTransformation_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToSameTopology_34(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public void SetMeshOverTimeToSameTopology()
	{
		vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToSameTopology_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToStatic_35(HandleRef pThis);

	/// <summary>
	/// Types of Variance of Mesh over time
	/// </summary>
	public void SetMeshOverTimeToStatic()
	{
		vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToStatic_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolatedVelocityField_ShowCacheResults_36(HandleRef pThis);

	/// <summary>
	/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
	/// </summary>
	public void ShowCacheResults()
	{
		vtkTemporalInterpolatedVelocityField_ShowCacheResults_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolatedVelocityField_TestPoint_37(HandleRef pThis, IntPtr x);

	/// <summary>
	/// A utility function which evaluates the point at T1, T2 to see
	/// if it is inside the data at both times or only one.
	/// </summary>
	public int TestPoint(IntPtr x)
	{
		return vtkTemporalInterpolatedVelocityField_TestPoint_37(GetCppThis(), x);
	}
}
