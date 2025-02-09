using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDelaunay3D
/// </summary>
/// <remarks>
///    create 3D Delaunay triangulation of input points
///
/// vtkDelaunay3D is a filter that constructs a 3D Delaunay
/// triangulation from a list of input points. These points may be
/// represented by any dataset of type vtkPointSet and subclasses. The
/// output of the filter is an unstructured grid dataset. Usually the
/// output is a tetrahedral mesh, but if a non-zero alpha distance
/// value is specified (called the "alpha" value), then only tetrahedra,
/// triangles, edges, and vertices laying within the alpha radius are
/// output. In other words, non-zero alpha values may result in arbitrary
/// combinations of tetrahedra, triangles, lines, and vertices. (The notion
/// of alpha value is derived from Edelsbrunner's work on "alpha shapes".)
/// Note that a modification to alpha shapes enables output of combinations
/// of tetrahedra, triangles, lines, and/or verts (see the boolean ivars
/// AlphaTets, AlphaTris, AlphaLines, AlphaVerts).
///
/// The 3D Delaunay triangulation is defined as the triangulation that
/// satisfies the Delaunay criterion for n-dimensional simplexes (in
/// this case n=3 and the simplexes are tetrahedra). This criterion
/// states that a circumsphere of each simplex in a triangulation
/// contains only the n+1 defining points of the simplex. (See text for
/// more information.) While in two dimensions this translates into an
/// "optimal" triangulation, this is not true in 3D, since a measurement
/// for optimality in 3D is not agreed on.
///
/// Delaunay triangulations are used to build topological structures
/// from unorganized (or unstructured) points. The input to this filter
/// is a list of points specified in 3D. (If you wish to create 2D
/// triangulations see vtkDelaunay2D.) The output is an unstructured grid.
///
/// The Delaunay triangulation can be numerically sensitive. To prevent
/// problems, try to avoid injecting points that will result in
/// triangles with bad aspect ratios (1000:1 or greater). In practice
/// this means inserting points that are "widely dispersed", and
/// enables smooth transition of triangle sizes throughout the
/// mesh. (You may even want to add extra points to create a better
/// point distribution.) If numerical problems are present, you will
/// see a warning message to this effect at the end of the
/// triangulation process.
///
/// @warning
/// Points arranged on a regular lattice (termed degenerate cases) can be
/// triangulated in more than one way (at least according to the Delaunay
/// criterion). The choice of triangulation (as implemented by
/// this algorithm) depends on the order of the input points. The first four
/// points will form a tetrahedron; other degenerate points (relative to this
/// initial tetrahedron) will not break it.
///
/// @warning
/// Points that are coincident (or nearly so) may be discarded by the
/// algorithm.  This is because the Delaunay triangulation requires
/// unique input points.  You can control the definition of coincidence
/// with the "Tolerance" instance variable.
///
/// @warning
/// The output of the Delaunay triangulation is supposedly a convex hull. In
/// certain cases this implementation may not generate the convex hull. This
/// behavior can be controlled by the Offset instance variable. Offset is a
/// multiplier used to control the size of the initial triangulation. The
/// larger the offset value, the more likely you will generate a convex hull;
/// and the more likely you are to see numerical problems.
///
/// @warning
/// The implementation of this algorithm varies from the 2D Delaunay
/// algorithm (i.e., vtkDelaunay2D) in an important way. When points are
/// injected into the triangulation, the search for the enclosing tetrahedron
/// is quite different. In the 3D case, the closest previously inserted point
/// point is found, and then the connected tetrahedra are searched to find
/// the containing one. (In 2D, a "walk" towards the enclosing triangle is
/// performed.) If the triangulation is Delaunay, then an enclosing tetrahedron
/// will be found. However, in degenerate cases an enclosing tetrahedron may
/// not be found and the point will be rejected.
///
/// </remarks>
/// <seealso>
///
/// vtkDelaunay2D vtkGaussianSplatter vtkUnstructuredGrid
/// </seealso>
public class vtkDelaunay3D : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDelaunay3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDelaunay3D()
	{
		MRClassNameKey = "class vtkDelaunay3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelaunay3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDelaunay3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with Alpha = 0.0; Tolerance = 0.001; Offset = 2.5;
	/// BoundingTriangulation turned off.
	/// </summary>
	public new static vtkDelaunay3D New()
	{
		vtkDelaunay3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with Alpha = 0.0; Tolerance = 0.001; Offset = 2.5;
	/// BoundingTriangulation turned off.
	/// </summary>
	public vtkDelaunay3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDelaunay3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDelaunay3D_AlphaLinesOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether lines are output for non-zero alpha values.
	/// </summary>
	public virtual void AlphaLinesOff()
	{
		vtkDelaunay3D_AlphaLinesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_AlphaLinesOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether lines are output for non-zero alpha values.
	/// </summary>
	public virtual void AlphaLinesOn()
	{
		vtkDelaunay3D_AlphaLinesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_AlphaTetsOff_03(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether tetrahedra are output for non-zero alpha values.
	/// </summary>
	public virtual void AlphaTetsOff()
	{
		vtkDelaunay3D_AlphaTetsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_AlphaTetsOn_04(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether tetrahedra are output for non-zero alpha values.
	/// </summary>
	public virtual void AlphaTetsOn()
	{
		vtkDelaunay3D_AlphaTetsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_AlphaTrisOff_05(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether triangles are output for non-zero alpha values.
	/// </summary>
	public virtual void AlphaTrisOff()
	{
		vtkDelaunay3D_AlphaTrisOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_AlphaTrisOn_06(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether triangles are output for non-zero alpha values.
	/// </summary>
	public virtual void AlphaTrisOn()
	{
		vtkDelaunay3D_AlphaTrisOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_AlphaVertsOff_07(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether vertices are output for non-zero alpha values.
	/// </summary>
	public virtual void AlphaVertsOff()
	{
		vtkDelaunay3D_AlphaVertsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_AlphaVertsOn_08(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether vertices are output for non-zero alpha values.
	/// </summary>
	public virtual void AlphaVertsOn()
	{
		vtkDelaunay3D_AlphaVertsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_BoundingTriangulationOff_09(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether bounding triangulation points (and associated
	/// triangles) are included in the output. (These are introduced as an
	/// initial triangulation to begin the triangulation process. This feature
	/// is nice for debugging output.)
	/// </summary>
	public virtual void BoundingTriangulationOff()
	{
		vtkDelaunay3D_BoundingTriangulationOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_BoundingTriangulationOn_10(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether bounding triangulation points (and associated
	/// triangles) are included in the output. (These are introduced as an
	/// initial triangulation to begin the triangulation process. This feature
	/// is nice for debugging output.)
	/// </summary>
	public virtual void BoundingTriangulationOn()
	{
		vtkDelaunay3D_BoundingTriangulationOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_CreateDefaultLocator_11(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified. The
	/// locator is used to eliminate "coincident" points.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkDelaunay3D_CreateDefaultLocator_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_EndPointInsertion_12(HandleRef pThis);

	/// <summary>
	/// Invoke this method after all points have been inserted. The purpose of
	/// the method is to clean up internal data structures. Note that the
	/// (vtkUnstructuredGrid *)Mesh returned from InitPointInsertion() is NOT
	/// deleted, you still are responsible for cleaning that up.
	/// </summary>
	public void EndPointInsertion()
	{
		vtkDelaunay3D_EndPointInsertion_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetAlpha_13(HandleRef pThis);

	/// <summary>
	/// Specify alpha (or distance) value to control output of this filter.  For
	/// a non-zero alpha value, only verts, edges, faces, or tetra contained
	/// within the circumsphere (of radius alpha) will be output. Otherwise,
	/// only tetrahedra will be output. Note that the flags AlphaTets, AlphaTris,
	/// AlphaLines, and AlphaVerts control whether these primitives are output
	/// when Alpha is non-zero. (By default all tets, triangles, lines and verts
	/// satisfying the alpha shape criterion are output.)
	/// </summary>
	public virtual double GetAlpha()
	{
		return vtkDelaunay3D_GetAlpha_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay3D_GetAlphaLines_14(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether lines are output for non-zero alpha values.
	/// </summary>
	public virtual int GetAlphaLines()
	{
		return vtkDelaunay3D_GetAlphaLines_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetAlphaMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Specify alpha (or distance) value to control output of this filter.  For
	/// a non-zero alpha value, only verts, edges, faces, or tetra contained
	/// within the circumsphere (of radius alpha) will be output. Otherwise,
	/// only tetrahedra will be output. Note that the flags AlphaTets, AlphaTris,
	/// AlphaLines, and AlphaVerts control whether these primitives are output
	/// when Alpha is non-zero. (By default all tets, triangles, lines and verts
	/// satisfying the alpha shape criterion are output.)
	/// </summary>
	public virtual double GetAlphaMaxValue()
	{
		return vtkDelaunay3D_GetAlphaMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetAlphaMinValue_16(HandleRef pThis);

	/// <summary>
	/// Specify alpha (or distance) value to control output of this filter.  For
	/// a non-zero alpha value, only verts, edges, faces, or tetra contained
	/// within the circumsphere (of radius alpha) will be output. Otherwise,
	/// only tetrahedra will be output. Note that the flags AlphaTets, AlphaTris,
	/// AlphaLines, and AlphaVerts control whether these primitives are output
	/// when Alpha is non-zero. (By default all tets, triangles, lines and verts
	/// satisfying the alpha shape criterion are output.)
	/// </summary>
	public virtual double GetAlphaMinValue()
	{
		return vtkDelaunay3D_GetAlphaMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay3D_GetAlphaTets_17(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether tetrahedra are output for non-zero alpha values.
	/// </summary>
	public virtual int GetAlphaTets()
	{
		return vtkDelaunay3D_GetAlphaTets_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay3D_GetAlphaTris_18(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether triangles are output for non-zero alpha values.
	/// </summary>
	public virtual int GetAlphaTris()
	{
		return vtkDelaunay3D_GetAlphaTris_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay3D_GetAlphaVerts_19(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether vertices are output for non-zero alpha values.
	/// </summary>
	public virtual int GetAlphaVerts()
	{
		return vtkDelaunay3D_GetAlphaVerts_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay3D_GetBoundingTriangulation_20(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether bounding triangulation points (and associated
	/// triangles) are included in the output. (These are introduced as an
	/// initial triangulation to begin the triangulation process. This feature
	/// is nice for debugging output.)
	/// </summary>
	public virtual int GetBoundingTriangulation()
	{
		return vtkDelaunay3D_GetBoundingTriangulation_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay3D_GetLocator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkPointLocator is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay3D_GetLocator_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDelaunay3D_GetMTime_22(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDelaunay3D_GetMTime_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelaunay3D_GetNumberOfGenerationsFromBase_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDelaunay3D_GetNumberOfGenerationsFromBase_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelaunay3D_GetNumberOfGenerationsFromBaseType_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDelaunay3D_GetNumberOfGenerationsFromBaseType_24(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetOffset_25(HandleRef pThis);

	/// <summary>
	/// Specify a multiplier to control the size of the initial, bounding
	/// Delaunay triangulation.
	/// </summary>
	public virtual double GetOffset()
	{
		return vtkDelaunay3D_GetOffset_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetOffsetMaxValue_26(HandleRef pThis);

	/// <summary>
	/// Specify a multiplier to control the size of the initial, bounding
	/// Delaunay triangulation.
	/// </summary>
	public virtual double GetOffsetMaxValue()
	{
		return vtkDelaunay3D_GetOffsetMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetOffsetMinValue_27(HandleRef pThis);

	/// <summary>
	/// Specify a multiplier to control the size of the initial, bounding
	/// Delaunay triangulation.
	/// </summary>
	public virtual double GetOffsetMinValue()
	{
		return vtkDelaunay3D_GetOffsetMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay3D_GetOutputPointsPrecision_28(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkDelaunay3D_GetOutputPointsPrecision_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetTolerance_29(HandleRef pThis);

	/// <summary>
	/// Specify a tolerance to control discarding of closely spaced points.
	/// This tolerance is specified as a fraction of the diagonal length of
	/// the bounding box of the points.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkDelaunay3D_GetTolerance_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetToleranceMaxValue_30(HandleRef pThis);

	/// <summary>
	/// Specify a tolerance to control discarding of closely spaced points.
	/// This tolerance is specified as a fraction of the diagonal length of
	/// the bounding box of the points.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkDelaunay3D_GetToleranceMaxValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelaunay3D_GetToleranceMinValue_31(HandleRef pThis);

	/// <summary>
	/// Specify a tolerance to control discarding of closely spaced points.
	/// This tolerance is specified as a fraction of the diagonal length of
	/// the bounding box of the points.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkDelaunay3D_GetToleranceMinValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay3D_InitPointInsertion_32(HandleRef pThis, IntPtr center, double length, long numPts, HandleRef points, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is a helper method used with InsertPoint() to create
	/// tetrahedronalizations of points. Its purpose is construct an initial
	/// Delaunay triangulation into which to inject other points. You must
	/// specify the center of a cubical bounding box and its length, as well
	/// as the number of points to insert. The method returns a pointer to
	/// an unstructured grid. Use this pointer to manipulate the mesh as
	/// necessary. You must delete (with Delete()) the mesh when done.
	/// Note: This initialization method places points forming bounding octahedron
	/// at the end of the Mesh's point list. That is, InsertPoint() assumes that
	/// you will be inserting points between (0,numPtsToInsert-1).
	/// </summary>
	public vtkUnstructuredGrid InitPointInsertion(IntPtr center, double length, long numPts, vtkPoints points)
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay3D_InitPointInsertion_32(GetCppThis(), center, length, numPts, points?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_InsertPoint_33(HandleRef pThis, HandleRef Mesh, HandleRef points, long id, IntPtr x, HandleRef holeTetras);

	/// <summary>
	/// This is a helper method used with InitPointInsertion() to create
	/// tetrahedronalizations of points. Its purpose is to inject point at
	/// coordinates specified into tetrahedronalization. The point id is an index
	/// into the list of points in the mesh structure.  (See
	/// vtkDelaunay3D::InitPointInsertion() for more information.)  When you have
	/// completed inserting points, traverse the mesh structure to extract desired
	/// tetrahedra (or tetra faces and edges).The holeTetras id list lists all the
	/// tetrahedra that are deleted (invalid) in the mesh structure.
	/// </summary>
	public void InsertPoint(vtkUnstructuredGrid Mesh, vtkPoints points, long id, IntPtr x, vtkIdList holeTetras)
	{
		vtkDelaunay3D_InsertPoint_33(GetCppThis(), Mesh?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef), id, x, holeTetras?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay3D_IsA_34(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDelaunay3D_IsA_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelaunay3D_IsTypeOf_35(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDelaunay3D_IsTypeOf_35(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay3D_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDelaunay3D NewInstance()
	{
		vtkDelaunay3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay3D_NewInstance_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelaunay3D_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDelaunay3D SafeDownCast(vtkObjectBase o)
	{
		vtkDelaunay3D vtkDelaunay3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelaunay3D_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDelaunay3D2 = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDelaunay3D2.Register(null);
			}
		}
		return vtkDelaunay3D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetAlpha_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify alpha (or distance) value to control output of this filter.  For
	/// a non-zero alpha value, only verts, edges, faces, or tetra contained
	/// within the circumsphere (of radius alpha) will be output. Otherwise,
	/// only tetrahedra will be output. Note that the flags AlphaTets, AlphaTris,
	/// AlphaLines, and AlphaVerts control whether these primitives are output
	/// when Alpha is non-zero. (By default all tets, triangles, lines and verts
	/// satisfying the alpha shape criterion are output.)
	/// </summary>
	public virtual void SetAlpha(double _arg)
	{
		vtkDelaunay3D_SetAlpha_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetAlphaLines_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether lines are output for non-zero alpha values.
	/// </summary>
	public virtual void SetAlphaLines(int _arg)
	{
		vtkDelaunay3D_SetAlphaLines_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetAlphaTets_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether tetrahedra are output for non-zero alpha values.
	/// </summary>
	public virtual void SetAlphaTets(int _arg)
	{
		vtkDelaunay3D_SetAlphaTets_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetAlphaTris_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether triangles are output for non-zero alpha values.
	/// </summary>
	public virtual void SetAlphaTris(int _arg)
	{
		vtkDelaunay3D_SetAlphaTris_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetAlphaVerts_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether vertices are output for non-zero alpha values.
	/// </summary>
	public virtual void SetAlphaVerts(int _arg)
	{
		vtkDelaunay3D_SetAlphaVerts_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetBoundingTriangulation_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether bounding triangulation points (and associated
	/// triangles) are included in the output. (These are introduced as an
	/// initial triangulation to begin the triangulation process. This feature
	/// is nice for debugging output.)
	/// </summary>
	public virtual void SetBoundingTriangulation(int _arg)
	{
		vtkDelaunay3D_SetBoundingTriangulation_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetLocator_45(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By default,
	/// an instance of vtkPointLocator is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkDelaunay3D_SetLocator_45(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetOffset_46(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a multiplier to control the size of the initial, bounding
	/// Delaunay triangulation.
	/// </summary>
	public virtual void SetOffset(double _arg)
	{
		vtkDelaunay3D_SetOffset_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetOutputPointsPrecision_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkDelaunay3D_SetOutputPointsPrecision_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelaunay3D_SetTolerance_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a tolerance to control discarding of closely spaced points.
	/// This tolerance is specified as a fraction of the diagonal length of
	/// the bounding box of the points.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkDelaunay3D_SetTolerance_48(GetCppThis(), _arg);
	}
}
