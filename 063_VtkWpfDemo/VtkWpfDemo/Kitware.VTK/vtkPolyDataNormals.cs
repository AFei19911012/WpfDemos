using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataNormals
/// </summary>
/// <remarks>
///    compute normals for polygonal mesh
///
/// vtkPolyDataNormals is a filter that computes point and/or cell normals
/// for a polygonal mesh. The user specifies if they would like the point
/// and/or cell normals to be computed by setting the ComputeCellNormals
/// and ComputePointNormals flags.
///
/// The computed normals (a vtkFloatArray) are set to be the active normals
/// (using SetNormals()) of the PointData and/or the CellData (respectively)
/// of the output PolyData. The name of these arrays is "Normals", so they
/// can be retrieved either with
/// vtkArrayDownCast&lt;vtkFloatArray&gt;(output-&gt;GetPointData()-&gt;GetNormals())
/// or with
/// vtkArrayDownCast&lt;vtkFloatArray&gt;(output-&gt;GetPointData()-&gt;GetArray("Normals"))
///
/// The filter can reorder polygons to ensure consistent
/// orientation across polygon neighbors. Sharp edges can be split and points
/// duplicated with separate normals to give crisp (rendered) surface definition.
/// It is also possible to globally flip the normal orientation.
///
/// The algorithm works by determining normals for each polygon and then
/// averaging them at shared points. When sharp edges are present, the edges
/// are split and new points generated to prevent blurry edges (due to
/// Gouraud shading).
///
/// @warning
/// Normals are computed only for polygons and triangle strips. Normals are
/// not computed for lines or vertices.
///
/// @warning
/// Triangle strips are broken up into triangle polygons. You may want to
/// restrip the triangles.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// For high-performance rendering, you could use vtkTriangleMeshPointNormals
/// if you know that you have a triangle mesh which does not require splitting
/// nor consistency check on the cell orientations.
///
/// </seealso>
public class vtkPolyDataNormals : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataNormals";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataNormals()
	{
		MRClassNameKey = "class vtkPolyDataNormals";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataNormals"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with feature angle=30, splitting and consistency turned on,
	/// flipNormals turned off, and non-manifold traversal turned on.
	/// ComputePointNormals is on and ComputeCellNormals is off.
	/// </summary>
	public new static vtkPolyDataNormals New()
	{
		vtkPolyDataNormals result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataNormals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with feature angle=30, splitting and consistency turned on,
	/// flipNormals turned off, and non-manifold traversal turned on.
	/// ComputePointNormals is on and ComputeCellNormals is off.
	/// </summary>
	public vtkPolyDataNormals()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataNormals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_AutoOrientNormalsOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic determination of correct normal
	/// orientation. NOTE: This assumes a completely closed surface
	/// (i.e. no boundary edges) and no non-manifold edges. If these
	/// constraints do not hold, all bets are off. This option adds some
	/// computational complexity, and is useful if you don't want to have
	/// to inspect the rendered image to determine whether to turn on the
	/// FlipNormals flag. However, this flag can work with the FlipNormals
	/// flag, and if both are set, all the normals in the output will
	/// point "inward".
	/// </summary>
	public virtual void AutoOrientNormalsOff()
	{
		vtkPolyDataNormals_AutoOrientNormalsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_AutoOrientNormalsOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic determination of correct normal
	/// orientation. NOTE: This assumes a completely closed surface
	/// (i.e. no boundary edges) and no non-manifold edges. If these
	/// constraints do not hold, all bets are off. This option adds some
	/// computational complexity, and is useful if you don't want to have
	/// to inspect the rendered image to determine whether to turn on the
	/// FlipNormals flag. However, this flag can work with the FlipNormals
	/// flag, and if both are set, all the normals in the output will
	/// point "inward".
	/// </summary>
	public virtual void AutoOrientNormalsOn()
	{
		vtkPolyDataNormals_AutoOrientNormalsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_ComputeCellNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of cell normals.
	/// </summary>
	public virtual void ComputeCellNormalsOff()
	{
		vtkPolyDataNormals_ComputeCellNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_ComputeCellNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of cell normals.
	/// </summary>
	public virtual void ComputeCellNormalsOn()
	{
		vtkPolyDataNormals_ComputeCellNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_ComputePointNormalsOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of point normals.
	/// </summary>
	public virtual void ComputePointNormalsOff()
	{
		vtkPolyDataNormals_ComputePointNormalsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_ComputePointNormalsOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of point normals.
	/// </summary>
	public virtual void ComputePointNormalsOn()
	{
		vtkPolyDataNormals_ComputePointNormalsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_ConsistencyOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the enforcement of consistent polygon ordering.
	/// </summary>
	public virtual void ConsistencyOff()
	{
		vtkPolyDataNormals_ConsistencyOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_ConsistencyOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the enforcement of consistent polygon ordering.
	/// </summary>
	public virtual void ConsistencyOn()
	{
		vtkPolyDataNormals_ConsistencyOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_FlipNormalsOff_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the global flipping of normal orientation. Flipping
	/// reverves the meaning of front and back for Frontface and Backface
	/// culling in vtkProperty.  Flipping modifies both the normal
	/// direction and the order of a cell's points.
	/// </summary>
	public virtual void FlipNormalsOff()
	{
		vtkPolyDataNormals_FlipNormalsOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_FlipNormalsOn_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off the global flipping of normal orientation. Flipping
	/// reverves the meaning of front and back for Frontface and Backface
	/// culling in vtkProperty.  Flipping modifies both the normal
	/// direction and the order of a cell's points.
	/// </summary>
	public virtual void FlipNormalsOn()
	{
		vtkPolyDataNormals_FlipNormalsOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetAutoOrientNormals_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic determination of correct normal
	/// orientation. NOTE: This assumes a completely closed surface
	/// (i.e. no boundary edges) and no non-manifold edges. If these
	/// constraints do not hold, all bets are off. This option adds some
	/// computational complexity, and is useful if you don't want to have
	/// to inspect the rendered image to determine whether to turn on the
	/// FlipNormals flag. However, this flag can work with the FlipNormals
	/// flag, and if both are set, all the normals in the output will
	/// point "inward".
	/// </summary>
	public virtual int GetAutoOrientNormals()
	{
		return vtkPolyDataNormals_GetAutoOrientNormals_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetComputeCellNormals_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of cell normals.
	/// </summary>
	public virtual int GetComputeCellNormals()
	{
		return vtkPolyDataNormals_GetComputeCellNormals_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetComputePointNormals_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of point normals.
	/// </summary>
	public virtual int GetComputePointNormals()
	{
		return vtkPolyDataNormals_GetComputePointNormals_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetConsistency_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off the enforcement of consistent polygon ordering.
	/// </summary>
	public virtual int GetConsistency()
	{
		return vtkPolyDataNormals_GetConsistency_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataNormals_GetFeatureAngle_15(HandleRef pThis);

	/// <summary>
	/// Specify the angle that defines a sharp edge. If the difference in
	/// angle across neighboring polygons is greater than this value, the
	/// shared edge is considered "sharp".
	/// </summary>
	public virtual double GetFeatureAngle()
	{
		return vtkPolyDataNormals_GetFeatureAngle_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataNormals_GetFeatureAngleMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Specify the angle that defines a sharp edge. If the difference in
	/// angle across neighboring polygons is greater than this value, the
	/// shared edge is considered "sharp".
	/// </summary>
	public virtual double GetFeatureAngleMaxValue()
	{
		return vtkPolyDataNormals_GetFeatureAngleMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataNormals_GetFeatureAngleMinValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the angle that defines a sharp edge. If the difference in
	/// angle across neighboring polygons is greater than this value, the
	/// shared edge is considered "sharp".
	/// </summary>
	public virtual double GetFeatureAngleMinValue()
	{
		return vtkPolyDataNormals_GetFeatureAngleMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetFlipNormals_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off the global flipping of normal orientation. Flipping
	/// reverves the meaning of front and back for Frontface and Backface
	/// culling in vtkProperty.  Flipping modifies both the normal
	/// direction and the order of a cell's points.
	/// </summary>
	public virtual int GetFlipNormals()
	{
		return vtkPolyDataNormals_GetFlipNormals_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetNonManifoldTraversal_19(HandleRef pThis);

	/// <summary>
	/// Turn on/off traversal across non-manifold edges. This will prevent
	/// problems where the consistency of polygonal ordering is corrupted due
	/// to topological loops.
	/// </summary>
	public virtual int GetNonManifoldTraversal()
	{
		return vtkPolyDataNormals_GetNonManifoldTraversal_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataNormals_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataNormals_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataNormals_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataNormals_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetOutputPointsPrecision_22(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPolyDataNormals_GetOutputPointsPrecision_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetOutputPointsPrecisionMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMaxValue()
	{
		return vtkPolyDataNormals_GetOutputPointsPrecisionMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetOutputPointsPrecisionMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecisionMinValue()
	{
		return vtkPolyDataNormals_GetOutputPointsPrecisionMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_GetSplitting_25(HandleRef pThis);

	/// <summary>
	/// Turn on/off the splitting of sharp edges.
	/// </summary>
	public virtual int GetSplitting()
	{
		return vtkPolyDataNormals_GetSplitting_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_IsA_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataNormals_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataNormals_IsTypeOf_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataNormals_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataNormals_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolyDataNormals NewInstance()
	{
		vtkPolyDataNormals result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataNormals_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_NonManifoldTraversalOff_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off traversal across non-manifold edges. This will prevent
	/// problems where the consistency of polygonal ordering is corrupted due
	/// to topological loops.
	/// </summary>
	public virtual void NonManifoldTraversalOff()
	{
		vtkPolyDataNormals_NonManifoldTraversalOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_NonManifoldTraversalOn_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off traversal across non-manifold edges. This will prevent
	/// problems where the consistency of polygonal ordering is corrupted due
	/// to topological loops.
	/// </summary>
	public virtual void NonManifoldTraversalOn()
	{
		vtkPolyDataNormals_NonManifoldTraversalOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataNormals_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataNormals SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataNormals vtkPolyDataNormals2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataNormals_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataNormals2 = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataNormals2.Register(null);
			}
		}
		return vtkPolyDataNormals2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetAutoOrientNormals_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the automatic determination of correct normal
	/// orientation. NOTE: This assumes a completely closed surface
	/// (i.e. no boundary edges) and no non-manifold edges. If these
	/// constraints do not hold, all bets are off. This option adds some
	/// computational complexity, and is useful if you don't want to have
	/// to inspect the rendered image to determine whether to turn on the
	/// FlipNormals flag. However, this flag can work with the FlipNormals
	/// flag, and if both are set, all the normals in the output will
	/// point "inward".
	/// </summary>
	public virtual void SetAutoOrientNormals(int _arg)
	{
		vtkPolyDataNormals_SetAutoOrientNormals_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetComputeCellNormals_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the computation of cell normals.
	/// </summary>
	public virtual void SetComputeCellNormals(int _arg)
	{
		vtkPolyDataNormals_SetComputeCellNormals_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetComputePointNormals_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the computation of point normals.
	/// </summary>
	public virtual void SetComputePointNormals(int _arg)
	{
		vtkPolyDataNormals_SetComputePointNormals_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetConsistency_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the enforcement of consistent polygon ordering.
	/// </summary>
	public virtual void SetConsistency(int _arg)
	{
		vtkPolyDataNormals_SetConsistency_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetFeatureAngle_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the angle that defines a sharp edge. If the difference in
	/// angle across neighboring polygons is greater than this value, the
	/// shared edge is considered "sharp".
	/// </summary>
	public virtual void SetFeatureAngle(double _arg)
	{
		vtkPolyDataNormals_SetFeatureAngle_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetFlipNormals_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the global flipping of normal orientation. Flipping
	/// reverves the meaning of front and back for Frontface and Backface
	/// culling in vtkProperty.  Flipping modifies both the normal
	/// direction and the order of a cell's points.
	/// </summary>
	public virtual void SetFlipNormals(int _arg)
	{
		vtkPolyDataNormals_SetFlipNormals_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetNonManifoldTraversal_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off traversal across non-manifold edges. This will prevent
	/// problems where the consistency of polygonal ordering is corrupted due
	/// to topological loops.
	/// </summary>
	public virtual void SetNonManifoldTraversal(int _arg)
	{
		vtkPolyDataNormals_SetNonManifoldTraversal_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetOutputPointsPrecision_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPolyDataNormals_SetOutputPointsPrecision_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SetSplitting_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the splitting of sharp edges.
	/// </summary>
	public virtual void SetSplitting(int _arg)
	{
		vtkPolyDataNormals_SetSplitting_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SplittingOff_42(HandleRef pThis);

	/// <summary>
	/// Turn on/off the splitting of sharp edges.
	/// </summary>
	public virtual void SplittingOff()
	{
		vtkPolyDataNormals_SplittingOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataNormals_SplittingOn_43(HandleRef pThis);

	/// <summary>
	/// Turn on/off the splitting of sharp edges.
	/// </summary>
	public virtual void SplittingOn()
	{
		vtkPolyDataNormals_SplittingOn_43(GetCppThis());
	}
}
