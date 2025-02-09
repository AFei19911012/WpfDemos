using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDelaunay2D
/// </summary>
/// <remarks>
///    create 2D Delaunay triangulation of input points
///
/// vtkDelaunay2D is a filter that constructs a 2D Delaunay triangulation from
/// a list of input points. These points may be represented by any dataset of
/// type vtkPointSet and subclasses. The output of the filter is a polygonal
/// dataset. Usually the output is a triangle mesh, but if a non-zero alpha
/// distance value is specified (called the "alpha" value), then only
/// triangles, edges, and vertices laying within the alpha radius are
/// output. In other words, non-zero alpha values may result in arbitrary
/// combinations of triangles, lines, and vertices. (The notion of alpha value
/// is derived from Edelsbrunner's work on "alpha shapes".) Also, it is
/// possible to generate "constrained triangulations" using this filter.
/// A constrained triangulation is one where edges and loops (i.e., polygons)
/// can be defined and the triangulation will preserve them (read on for
/// more information).
///
/// The 2D Delaunay triangulation is defined as the triangulation that
/// satisfies the Delaunay criterion for n-dimensional simplexes (in this case
/// n=2 and the simplexes are triangles). This criterion states that a
/// circumsphere of each simplex in a triangulation contains only the n+1
/// defining points of the simplex. (See "The Visualization Toolkit" text
/// for more information.) In two dimensions, this translates into an optimal
/// triangulation. That is, the maximum interior angle of any triangle is less
/// than or equal to that of any possible triangulation.
///
/// Delaunay triangulations are used to build topological structures
/// from unorganized (or unstructured) points. The input to this filter
/// is a list of points specified in 3D, even though the triangulation
/// is 2D. Thus the triangulation is constructed in the x-y plane, and
/// the z coordinate is ignored (although carried through to the
/// output). If you desire to triangulate in a different plane, you
/// can use the vtkTransformFilter to transform the points into and
/// out of the x-y plane or you can specify a transform to the Delaunay2D
/// directly.  In the latter case, the input points are transformed, the
/// transformed points are triangulated, and the output will use the
/// triangulated topology for the original (non-transformed) points.  This
/// avoids transforming the data back as would be required when using the
/// vtkTransformFilter method.  Specifying a transform directly also allows
/// any transform to be used: rigid, non-rigid, non-invertible, etc.
///
/// If an input transform is used, then alpha values are applied (for the
/// most part) in the original data space.  The exception is when
/// BoundingTriangulation is on.  In this case, alpha values are applied in
/// the original data space unless a cell uses a bounding vertex.
///
/// The Delaunay triangulation can be numerically sensitive in some cases. To
/// prevent problems, try to avoid injecting points that will result in
/// triangles with bad aspect ratios (1000:1 or greater). In practice this
/// means inserting points that are "widely dispersed", and enables smooth
/// transition of triangle sizes throughout the mesh. (You may even want to
/// add extra points to create a better point distribution.) If numerical
/// problems are present, you will see a warning message to this effect at
/// the end of the triangulation process. Note also that the
/// RandomPointInsertion mode can be set which will insert the points in
/// pseudo-random order.
///
/// To create constrained meshes, you must define an additional
/// input. This input is an instance of vtkPolyData which contains
/// lines, polylines, and/or polygons that define constrained edges and
/// loops. Only the topology of (lines and polygons) from this second
/// input are used.  The topology is assumed to reference points in the
/// input point set (the one to be triangulated). In other words, the
/// lines and polygons use point ids from the first input point
/// set. Lines and polylines found in the input will be mesh edges in
/// the output. Polygons define a loop with inside and outside
/// regions. The inside of the polygon is determined by using the
/// right-hand-rule, i.e., looking down the z-axis a polygon should be
/// ordered counter-clockwise. Holes in a polygon should be ordered
/// clockwise. If you choose to create a constrained triangulation, the
/// final mesh may not satisfy the Delaunay criterion. (Noted: the
/// lines/polygon edges must not intersect when projected onto the 2D
/// plane.  It may not be possible to recover all edges due to not
/// enough points in the triangulation, or poorly defined edges
/// (coincident or excessively long).  The form of the lines or
/// polygons is a list of point ids that correspond to the input point
/// ids used to generate the triangulation.)
///
/// If an input transform is used, constraints are defined in the
/// "transformed" space.  So when the right hand rule is used for a
/// polygon constraint, that operation is applied using the transformed
/// points.  Since the input transform can be any transformation (rigid
/// or non-rigid), care must be taken in constructing constraints when
/// an input transform is used.
///
/// @warning
/// Points arranged on a regular lattice (termed degenerate cases) can be
/// triangulated in more than one way (at least according to the Delaunay
/// criterion). The choice of triangulation (as implemented by
/// this algorithm) depends on the order of the input points. The first three
/// points will form a triangle; other degenerate points will not break
/// this triangle.
///
/// @warning
/// Points that are coincident (or nearly so) may be discarded by the algorithm.
/// This is because the Delaunay triangulation requires unique input points.
/// You can control the definition of coincidence with the "Tolerance" instance
/// variable.
///
/// @warning
/// The output of the Delaunay triangulation is supposedly a convex hull. In
/// certain cases this implementation may not generate the convex hull. This
/// behavior can be controlled by the Offset instance variable. Offset is a
/// multiplier used to control the size of the initial triangulation. The
/// larger the offset value, the more likely you will generate a convex hull;
/// but the more likely you are to see numerical problems.
///
/// </remarks>
/// <seealso>
///
/// vtkDelaunay3D vtkTransformFilter vtkGaussianSplatter
/// </seealso>
public class vtkDelaunay2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDelaunay2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDelaunay2D()
	{
		MRClassNameKey = "class vtkDelaunay2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelaunay2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDelaunay2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with Alpha = 0.0; Tolerance = 0.001; Offset = 1.25;
	/// BoundingTriangulation turned off.
	/// </summary>
	public new static vtkDelaunay2D New()
	{
		vtkDelaunay2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with Alpha = 0.0; Tolerance = 0.001; Offset = 1.25;
	/// BoundingTriangulation turned off.
	/// </summary>
	public vtkDelaunay2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDelaunay2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDelaunay2D_BoundingTriangulationOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether bounding triangulation points (and associated
	/// triangles) are included in the output. (These are introduced as an
	/// initial triangulation to begin the triangulation process. This feature
	/// is nice for debugging output.)
	/// </summary>
	public virtual void BoundingTriangulationOff()
	{
		vtkDelaunay2D_BoundingTriangulationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_BoundingTriangulationOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether bounding triangulation points (and associated
	/// triangles) are included in the output. (These are introduced as an
	/// initial triangulation to begin the triangulation process. This feature
	/// is nice for debugging output.)
	/// </summary>
	public virtual void BoundingTriangulationOn()
	{
		vtkDelaunay2D_BoundingTriangulationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay2D_ComputeBestFittingPlane_03(HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method computes the best fit plane to a set of points represented
	/// by a vtkPointSet. The method constructs a transform and returns it on
	/// successful completion (null otherwise). The user is responsible for
	/// deleting the transform instance.
	/// </summary>
	public static vtkAbstractTransform ComputeBestFittingPlane(vtkPointSet input)
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay2D_ComputeBestFittingPlane_03(input?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetAlpha_04(HandleRef pThis);

	/// <summary>
	/// Specify alpha (or distance) value to control output of this filter.
	/// For a non-zero alpha value, only edges or triangles contained within
	/// a sphere centered at mesh vertices will be output. Otherwise, only
	/// triangles will be output.
	/// </summary>
	public virtual double GetAlpha()
	{
		return vtkDelaunay2D_GetAlpha_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetAlphaMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify alpha (or distance) value to control output of this filter.
	/// For a non-zero alpha value, only edges or triangles contained within
	/// a sphere centered at mesh vertices will be output. Otherwise, only
	/// triangles will be output.
	/// </summary>
	public virtual double GetAlphaMaxValue()
	{
		return vtkDelaunay2D_GetAlphaMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetAlphaMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify alpha (or distance) value to control output of this filter.
	/// For a non-zero alpha value, only edges or triangles contained within
	/// a sphere centered at mesh vertices will be output. Otherwise, only
	/// triangles will be output.
	/// </summary>
	public virtual double GetAlphaMinValue()
	{
		return vtkDelaunay2D_GetAlphaMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay2D_GetBoundingTriangulation_07(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether bounding triangulation points (and associated
	/// triangles) are included in the output. (These are introduced as an
	/// initial triangulation to begin the triangulation process. This feature
	/// is nice for debugging output.)
	/// </summary>
	public virtual int GetBoundingTriangulation()
	{
		return vtkDelaunay2D_GetBoundingTriangulation_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelaunay2D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDelaunay2D_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelaunay2D_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDelaunay2D_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetOffset_10(HandleRef pThis);

	/// <summary>
	/// Specify a multiplier to control the size of the initial, bounding
	/// Delaunay triangulation.
	/// </summary>
	public virtual double GetOffset()
	{
		return vtkDelaunay2D_GetOffset_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetOffsetMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify a multiplier to control the size of the initial, bounding
	/// Delaunay triangulation.
	/// </summary>
	public virtual double GetOffsetMaxValue()
	{
		return vtkDelaunay2D_GetOffsetMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetOffsetMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify a multiplier to control the size of the initial, bounding
	/// Delaunay triangulation.
	/// </summary>
	public virtual double GetOffsetMinValue()
	{
		return vtkDelaunay2D_GetOffsetMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay2D_GetProjectionPlaneMode_13(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// triangulation. When the VTK_DELAUNAY_XY_PLANE is set, the z-coordinate
	/// is simply ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform
	/// must be supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public virtual int GetProjectionPlaneMode()
	{
		return vtkDelaunay2D_GetProjectionPlaneMode_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay2D_GetProjectionPlaneModeMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// triangulation. When the VTK_DELAUNAY_XY_PLANE is set, the z-coordinate
	/// is simply ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform
	/// must be supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public virtual int GetProjectionPlaneModeMaxValue()
	{
		return vtkDelaunay2D_GetProjectionPlaneModeMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay2D_GetProjectionPlaneModeMinValue_15(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// triangulation. When the VTK_DELAUNAY_XY_PLANE is set, the z-coordinate
	/// is simply ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform
	/// must be supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public virtual int GetProjectionPlaneModeMinValue()
	{
		return vtkDelaunay2D_GetProjectionPlaneModeMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay2D_GetRandomPointInsertion_16(HandleRef pThis);

	/// <summary>
	/// Indicate whether to insert the points in given order, or pseudo-random
	/// order. Inserting in random order can improve performance and numerics
	/// in many circumstances.
	/// </summary>
	public virtual int GetRandomPointInsertion()
	{
		return vtkDelaunay2D_GetRandomPointInsertion_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay2D_GetSource_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the source object.
	/// </summary>
	public vtkPolyData GetSource()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay2D_GetSource_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetTolerance_18(HandleRef pThis);

	/// <summary>
	/// Specify a tolerance to control discarding of closely spaced points.
	/// This tolerance is specified as a fraction of the diagonal length of
	/// the bounding box of the points.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkDelaunay2D_GetTolerance_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetToleranceMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Specify a tolerance to control discarding of closely spaced points.
	/// This tolerance is specified as a fraction of the diagonal length of
	/// the bounding box of the points.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkDelaunay2D_GetToleranceMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay2D_GetToleranceMinValue_20(HandleRef pThis);

	/// <summary>
	/// Specify a tolerance to control discarding of closely spaced points.
	/// This tolerance is specified as a fraction of the diagonal length of
	/// the bounding box of the points.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkDelaunay2D_GetToleranceMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay2D_GetTransform_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the transform which is applied to points to generate a
	/// 2D problem.  This maps a 3D dataset into a 2D dataset where
	/// triangulation can be done on the XY plane.  The points are
	/// transformed and triangulated.  The topology of triangulated
	/// points is used as the output topology.  The output points are the
	/// original (untransformed) points.  The transform can be any
	/// subclass of vtkAbstractTransform (thus it does not need to be a
	/// linear or invertible transform).
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay2D_GetTransform_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay2D_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDelaunay2D_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay2D_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDelaunay2D_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay2D_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDelaunay2D NewInstance()
	{
		vtkDelaunay2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay2D_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_RandomPointInsertionOff_26(HandleRef pThis);

	/// <summary>
	/// Indicate whether to insert the points in given order, or pseudo-random
	/// order. Inserting in random order can improve performance and numerics
	/// in many circumstances.
	/// </summary>
	public virtual void RandomPointInsertionOff()
	{
		vtkDelaunay2D_RandomPointInsertionOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_RandomPointInsertionOn_27(HandleRef pThis);

	/// <summary>
	/// Indicate whether to insert the points in given order, or pseudo-random
	/// order. Inserting in random order can improve performance and numerics
	/// in many circumstances.
	/// </summary>
	public virtual void RandomPointInsertionOn()
	{
		vtkDelaunay2D_RandomPointInsertionOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay2D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDelaunay2D SafeDownCast(vtkObjectBase o)
	{
		vtkDelaunay2D vtkDelaunay2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay2D_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDelaunay2D2 = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDelaunay2D2.Register(null);
			}
		}
		return vtkDelaunay2D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetAlpha_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify alpha (or distance) value to control output of this filter.
	/// For a non-zero alpha value, only edges or triangles contained within
	/// a sphere centered at mesh vertices will be output. Otherwise, only
	/// triangles will be output.
	/// </summary>
	public virtual void SetAlpha(double _arg)
	{
		vtkDelaunay2D_SetAlpha_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetBoundingTriangulation_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether bounding triangulation points (and associated
	/// triangles) are included in the output. (These are introduced as an
	/// initial triangulation to begin the triangulation process. This feature
	/// is nice for debugging output.)
	/// </summary>
	public virtual void SetBoundingTriangulation(int _arg)
	{
		vtkDelaunay2D_SetBoundingTriangulation_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetOffset_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a multiplier to control the size of the initial, bounding
	/// Delaunay triangulation.
	/// </summary>
	public virtual void SetOffset(double _arg)
	{
		vtkDelaunay2D_SetOffset_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetProjectionPlaneMode_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// triangulation. When the VTK_DELAUNAY_XY_PLANE is set, the z-coordinate
	/// is simply ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform
	/// must be supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public virtual void SetProjectionPlaneMode(int _arg)
	{
		vtkDelaunay2D_SetProjectionPlaneMode_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetRandomPointInsertion_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to insert the points in given order, or pseudo-random
	/// order. Inserting in random order can improve performance and numerics
	/// in many circumstances.
	/// </summary>
	public virtual void SetRandomPointInsertion(int _arg)
	{
		vtkDelaunay2D_SetRandomPointInsertion_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetSourceConnection_34(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the source object used to specify constrained edges and loops.
	/// (This is optional.) If set, and lines/polygons are defined, a constrained
	/// triangulation is created. The lines/polygons are assumed to reference
	/// points in the input point set (i.e. point ids are identical in the
	/// input and source).
	/// New style. This method is equivalent to SetInputConnection(1, algOutput).
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkDelaunay2D_SetSourceConnection_34(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetSourceData_35(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the source object used to specify constrained edges and loops.
	/// (This is optional.) If set, and lines/polygons are defined, a constrained
	/// triangulation is created. The lines/polygons are assumed to reference
	/// points in the input point set (i.e. point ids are identical in the
	/// input and source).
	/// Note that this method does not connect the pipeline. See SetSourceConnection
	/// for connecting the pipeline.
	/// </summary>
	public void SetSourceData(vtkPolyData arg0)
	{
		vtkDelaunay2D_SetSourceData_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetTolerance_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a tolerance to control discarding of closely spaced points.
	/// This tolerance is specified as a fraction of the diagonal length of
	/// the bounding box of the points.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkDelaunay2D_SetTolerance_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay2D_SetTransform_37(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Set / get the transform which is applied to points to generate a
	/// 2D problem.  This maps a 3D dataset into a 2D dataset where
	/// triangulation can be done on the XY plane.  The points are
	/// transformed and triangulated.  The topology of triangulated
	/// points is used as the output topology.  The output points are the
	/// original (untransformed) points.  The transform can be any
	/// subclass of vtkAbstractTransform (thus it does not need to be a
	/// linear or invertible transform).
	/// </summary>
	public virtual void SetTransform(vtkAbstractTransform _arg)
	{
		vtkDelaunay2D_SetTransform_37(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}
}
