using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOrderedTriangulator
/// </summary>
/// <remarks>
///    helper class to generate triangulations
///
/// This class is used to generate unique triangulations of points. The
/// uniqueness of the triangulation is controlled by the id of the inserted
/// points in combination with a Delaunay criterion. The class is designed to
/// be as fast as possible (since the algorithm can be slow) and uses block
/// memory allocations to support rapid triangulation generation. Also, the
/// assumption behind the class is that a maximum of hundreds of points are to
/// be triangulated. If you desire more robust triangulation methods use
/// vtkPolygon::Triangulate(), vtkDelaunay2D, or vtkDelaunay3D.
///
/// @par Background:
/// This work is documented in the technical paper: W.J. Schroeder, B. Geveci,
/// M. Malaterre. Compatible Triangulations of Spatial Decompositions. In
/// Proceedings of Visualization 2004, IEEE Press October 2004.
///
/// @par Background:
/// Delaunay triangulations are unique assuming a random distribution of input
/// points. The 3D Delaunay criterion is as follows: the circumsphere of each
/// tetrahedron contains no other points of the triangulation except for the
/// four points defining the tetrahedron.  In application this property is
/// hard to satisfy because objects like cubes are defined by eight points all
/// sharing the same circumsphere (center and radius); hence the Delaunay
/// triangulation is not unique.  These so-called degenerate situations are
/// typically resolved by arbitrary selecting a triangulation. This code does
/// something different: it resolves degenerate triangulations by modifying
/// the "InCircumsphere" method to use a slightly smaller radius. Hence,
/// degenerate points are always considered "out" of the circumsphere. This,
/// in combination with an ordering (based on id) of the input points,
/// guarantees a unique triangulation.
///
/// @par Background:
/// There is another related characteristic of Delaunay triangulations. Given
/// a N-dimensional Delaunay triangulation, points laying on a (N-1) dimensional
/// plane also form a (N-1) Delaunay triangulation. This means for example,
/// that if a 3D cell is defined by a set of (2D) planar faces, then the
/// face triangulations are Delaunay. Combining this with the method to
/// generate unique triangulations described previously, the triangulations
/// on the face are guaranteed unique. This fact can be used to triangulate
/// 3D objects in such a way to guarantee compatible face triangulations.
/// This is a very useful fact for parallel processing, or performing
/// operations like clipping that require compatible triangulations across
/// 3D cell faces. (See vtkClipVolume for an example.)
///
/// @par Background:
/// A special feature of this class is that it can generate triangulation
/// templates on the fly. If template triangulation is enabled, then the
/// ordered triangulator will first triangulate the cell using the slower
/// ordered Delaunay approach, and then store the result as a template.
/// Later, if the same cell type and cell configuration is encountered,
/// then the template is reused which greatly speeds the triangulation.
///
/// @warning
/// Duplicate vertices will be ignored, i.e., if two points have the same
/// coordinates the second one is discarded. The implications are that the
/// user of this class must prevent duplicate points. Because the precision
/// of this algorithm is double, it's also a good idea to merge points
/// that are within some epsilon of one another.
///
/// @warning
/// The triangulation is performed using the parametric coordinates of the
/// inserted points. Therefore the bounds (see InitTriangulation()) should
/// represent the range of the parametric coordinates of the inserted points.
///
/// </remarks>
/// <seealso>
///
/// vtkDelaunay2D vtkDelaunay3D vtkPolygon
/// </seealso>
public class vtkOrderedTriangulator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOrderedTriangulator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOrderedTriangulator()
	{
		MRClassNameKey = "class vtkOrderedTriangulator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrderedTriangulator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOrderedTriangulator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderedTriangulator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object.
	/// </summary>
	public new static vtkOrderedTriangulator New()
	{
		vtkOrderedTriangulator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderedTriangulator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object.
	/// </summary>
	public vtkOrderedTriangulator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOrderedTriangulator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_AddTetras_01(HandleRef pThis, int classification, HandleRef ugrid);

	/// <summary>
	/// Add the tetras to the unstructured grid provided. The unstructured
	/// grid is assumed to have been initialized (with Allocate()) and
	/// points set (with SetPoints()). The tetrahdera added are of the type
	/// specified (0=inside,1=outside,2=all). Inside tetrahedron are
	/// those whose points are classified "inside" or on the "boundary."
	/// Outside tetrahedron have at least one point classified "outside."
	/// The method returns the number of tetrahedrahedron of the type
	/// requested.
	/// </summary>
	public long AddTetras(int classification, vtkUnstructuredGrid ugrid)
	{
		return vtkOrderedTriangulator_AddTetras_01(GetCppThis(), classification, ugrid?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_AddTetras_02(HandleRef pThis, int classification, HandleRef connectivity);

	/// <summary>
	/// Add the tetrahedra classified (0=inside,1=outside) to the connectivity
	/// list provided. Inside tetrahedron are those whose points are all
	/// classified "inside." Outside tetrahedron have at least one point
	/// classified "outside." The method returns the number of tetrahedron
	/// of the type requested.
	/// </summary>
	public long AddTetras(int classification, vtkCellArray connectivity)
	{
		return vtkOrderedTriangulator_AddTetras_02(GetCppThis(), classification, connectivity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_AddTetras_03(HandleRef pThis, int classification, HandleRef locator, HandleRef outConnectivity, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

	/// <summary>
	/// Assuming that all the inserted points come from a cell `cellId' to
	/// triangulate, get the tetrahedra in outConnectivity, the points in locator
	/// and copy point data and cell data. Return the number of added tetras.
	/// \pre locator_exists: locator!=0
	/// \pre outConnectivity: outConnectivity!=0
	/// \pre inPD_exists: inPD!=0
	/// \pre outPD_exists:  outPD!=0
	/// \pre inCD_exists: inCD!=0
	/// \pre outCD_exists: outCD!=0
	/// </summary>
	public long AddTetras(int classification, vtkIncrementalPointLocator locator, vtkCellArray outConnectivity, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
	{
		return vtkOrderedTriangulator_AddTetras_03(GetCppThis(), classification, locator?.GetCppThis() ?? default(HandleRef), outConnectivity?.GetCppThis() ?? default(HandleRef), inPD?.GetCppThis() ?? default(HandleRef), outPD?.GetCppThis() ?? default(HandleRef), inCD?.GetCppThis() ?? default(HandleRef), cellId, outCD?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_AddTetras_04(HandleRef pThis, int classification, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// Add the tetrahedra classified (0=inside,1=outside) to the list
	/// of ids and coordinates provided. These assume that the first four points
	/// form a tetrahedron, the next four the next, and so on.
	/// </summary>
	public long AddTetras(int classification, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkOrderedTriangulator_AddTetras_04(GetCppThis(), classification, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_AddTriangles_05(HandleRef pThis, HandleRef connectivity);

	/// <summary>
	/// Add the triangle faces classified (2=boundary) to the connectivity
	/// list provided. The method returns the number of triangles.
	/// </summary>
	public long AddTriangles(vtkCellArray connectivity)
	{
		return vtkOrderedTriangulator_AddTriangles_05(GetCppThis(), connectivity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_AddTriangles_06(HandleRef pThis, long id, HandleRef connectivity);

	/// <summary>
	/// Add the triangle faces classified (2=boundary) and attached to the
	/// specified point id to the connectivity list provided. (The id is the
	/// same as that specified in InsertPoint().)
	/// </summary>
	public long AddTriangles(long id, vtkCellArray connectivity)
	{
		return vtkOrderedTriangulator_AddTriangles_06(GetCppThis(), id, connectivity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderedTriangulator_GetNextTetra_07(HandleRef pThis, int classification, HandleRef tet, HandleRef cellScalars, HandleRef tetScalars);

	/// <summary>
	/// Methods to get one tetra at a time. Start with InitTetraTraversal()
	/// and then invoke GetNextTetra() until the method returns 0.
	/// cellScalars are point-centered scalars on the original cell.
	/// tetScalars are point-centered scalars on the tetra: the values will be
	/// copied from cellScalars.
	/// \pre tet_exists: tet!=0
	/// \pre cellScalars_exists: cellScalars!=0
	/// \pre tetScalars_exists: tetScalars!=0
	/// \pre tetScalars_valid_size: tetScalars-&gt;GetNumberOfTuples()==4
	/// </summary>
	public int GetNextTetra(int classification, vtkTetra tet, vtkDataArray cellScalars, vtkDoubleArray tetScalars)
	{
		return vtkOrderedTriangulator_GetNextTetra_07(GetCppThis(), classification, tet?.GetCppThis() ?? default(HandleRef), cellScalars?.GetCppThis() ?? default(HandleRef), tetScalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOrderedTriangulator_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOrderedTriangulator_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderedTriangulator_GetNumberOfPoints_10(HandleRef pThis);

	/// <summary>
	/// Return the number of inserted points.
	/// </summary>
	public virtual int GetNumberOfPoints()
	{
		return vtkOrderedTriangulator_GetNumberOfPoints_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_GetPointId_11(HandleRef pThis, long internalId);

	/// <summary>
	/// Return the Id of point `internalId'. This id is the one passed in
	/// argument of InsertPoint.
	/// It assumes that the point has already been inserted.
	/// The method should be invoked prior to the Triangulate method.
	/// \pre valid_range: internalId&gt;=0 &amp;&amp; internalId&lt;this-&gt;GetNumberOfPoints()
	/// </summary>
	public long GetPointId(long internalId)
	{
		return vtkOrderedTriangulator_GetPointId_11(GetCppThis(), internalId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderedTriangulator_GetPointLocation_12(HandleRef pThis, long internalId);

	/// <summary>
	/// Return the global coordinates of point `internalId'.
	/// It assumes that the point has already been inserted.
	/// The method should be invoked prior to the Triangulate method.
	/// \pre valid_range: internalId&gt;=0 &amp;&amp; internalId&lt;this-&gt;GetNumberOfPoints()
	/// </summary>
	public IntPtr GetPointLocation(long internalId)
	{
		return vtkOrderedTriangulator_GetPointLocation_12(GetCppThis(), internalId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderedTriangulator_GetPointPosition_13(HandleRef pThis, long internalId);

	/// <summary>
	/// Return the parametric coordinates of point `internalId'.
	/// It assumes that the point has already been inserted.
	/// The method should be invoked prior to the Triangulate method.
	/// \pre valid_range: internalId&gt;=0 &amp;&amp; internalId&lt;this-&gt;GetNumberOfPoints()
	/// </summary>
	public IntPtr GetPointPosition(long internalId)
	{
		return vtkOrderedTriangulator_GetPointPosition_13(GetCppThis(), internalId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderedTriangulator_GetPreSorted_14(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the points have been pre-sorted. If
	/// pre-sorted is enabled, the points are not sorted on point id.
	/// By default, presorted is off. (The point id is defined in
	/// InsertPoint().)
	/// </summary>
	public virtual int GetPreSorted()
	{
		return vtkOrderedTriangulator_GetPreSorted_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_GetTetras_15(HandleRef pThis, int classification, HandleRef ugrid);

	/// <summary>
	/// Initialize and add the tetras and points from the triangulation to the
	/// unstructured grid provided.  New points are created and the mesh is
	/// allocated. (This method differs from AddTetras() in that it inserts
	/// points and cells; AddTetras only adds the tetra cells.) The tetrahdera
	/// added are of the type specified (0=inside,1=outside,2=all). Inside
	/// tetrahedron are those whose points are classified "inside" or on the
	/// "boundary."  Outside tetrahedron have at least one point classified
	/// "outside."  The method returns the number of tetrahedrahedron of the
	/// type requested.
	/// </summary>
	public long GetTetras(int classification, vtkUnstructuredGrid ugrid)
	{
		return vtkOrderedTriangulator_GetTetras_15(GetCppThis(), classification, ugrid?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderedTriangulator_GetUseTemplates_16(HandleRef pThis);

	/// <summary>
	/// If this flag is set, then the ordered triangulator will create
	/// and use templates for the triangulation. To use templates, the
	/// TemplateTriangulate() method should be called when appropriate.
	/// (Note: the TemplateTriangulate() method works for complete
	/// (interior) cells without extra points due to intersection, etc.)
	/// </summary>
	public virtual int GetUseTemplates()
	{
		return vtkOrderedTriangulator_GetUseTemplates_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderedTriangulator_GetUseTwoSortIds_17(HandleRef pThis);

	/// <summary>
	/// Tells the triangulator that a second sort id is provided
	/// for each point and should also be considered when sorting.
	/// </summary>
	public virtual int GetUseTwoSortIds()
	{
		return vtkOrderedTriangulator_GetUseTwoSortIds_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_InitTetraTraversal_18(HandleRef pThis);

	/// <summary>
	/// Methods to get one tetra at a time. Start with InitTetraTraversal()
	/// and then invoke GetNextTetra() until the method returns 0.
	/// </summary>
	public void InitTetraTraversal()
	{
		vtkOrderedTriangulator_InitTetraTraversal_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_InitTriangulation_19(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int numPts);

	/// <summary>
	/// Initialize the triangulation process. Provide a bounding box and
	/// the maximum number of points to be inserted. Note that since the
	/// triangulation is performed using parametric coordinates (see
	/// InsertPoint()) the bounds should be represent the range of the
	/// parametric coordinates inserted.
	/// \post no_point_inserted: GetNumberOfPoints()==0
	/// </summary>
	public void InitTriangulation(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int numPts)
	{
		vtkOrderedTriangulator_InitTriangulation_19(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax, numPts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_InitTriangulation_20(HandleRef pThis, IntPtr bounds, int numPts);

	/// <summary>
	/// Initialize the triangulation process. Provide a bounding box and
	/// the maximum number of points to be inserted. Note that since the
	/// triangulation is performed using parametric coordinates (see
	/// InsertPoint()) the bounds should be represent the range of the
	/// parametric coordinates inserted.
	/// \post no_point_inserted: GetNumberOfPoints()==0
	/// </summary>
	public void InitTriangulation(IntPtr bounds, int numPts)
	{
		vtkOrderedTriangulator_InitTriangulation_20(GetCppThis(), bounds, numPts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_InsertPoint_21(HandleRef pThis, long id, IntPtr x, IntPtr p, int type);

	/// <summary>
	/// For each point to be inserted, provide an id, a position x, parametric
	/// coordinate p, and whether the point is inside (type=0), outside
	/// (type=1), or on the boundary (type=2). You must call InitTriangulation()
	/// prior to invoking this method. Make sure that the number of points
	/// inserted does not exceed the numPts specified in
	/// InitTriangulation(). Also note that the "id" can be any integer and can
	/// be greater than numPts. It is used to create tetras (in AddTetras()) with
	/// the appropriate connectivity ids. The method returns an internal id that
	/// can be used prior to the Triangulate() method to update the type of the
	/// point with UpdatePointType(). (Note: the algorithm triangulated with the
	/// parametric coordinate p[3] and creates tetras with the global coordinate
	/// x[3]. The parametric coordinates and global coordinates may be the same.)
	/// </summary>
	public long InsertPoint(long id, IntPtr x, IntPtr p, int type)
	{
		return vtkOrderedTriangulator_InsertPoint_21(GetCppThis(), id, x, p, type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_InsertPoint_22(HandleRef pThis, long id, long sortid, IntPtr x, IntPtr p, int type);

	/// <summary>
	/// For each point to be inserted, provide an id, a position x, parametric
	/// coordinate p, and whether the point is inside (type=0), outside
	/// (type=1), or on the boundary (type=2). You must call InitTriangulation()
	/// prior to invoking this method. Make sure that the number of points
	/// inserted does not exceed the numPts specified in
	/// InitTriangulation(). Also note that the "id" can be any integer and can
	/// be greater than numPts. It is used to create tetras (in AddTetras()) with
	/// the appropriate connectivity ids. The method returns an internal id that
	/// can be used prior to the Triangulate() method to update the type of the
	/// point with UpdatePointType(). (Note: the algorithm triangulated with the
	/// parametric coordinate p[3] and creates tetras with the global coordinate
	/// x[3]. The parametric coordinates and global coordinates may be the same.)
	/// </summary>
	public long InsertPoint(long id, long sortid, IntPtr x, IntPtr p, int type)
	{
		return vtkOrderedTriangulator_InsertPoint_22(GetCppThis(), id, sortid, x, p, type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderedTriangulator_InsertPoint_23(HandleRef pThis, long id, long sortid, long sortid2, IntPtr x, IntPtr p, int type);

	/// <summary>
	/// For each point to be inserted, provide an id, a position x, parametric
	/// coordinate p, and whether the point is inside (type=0), outside
	/// (type=1), or on the boundary (type=2). You must call InitTriangulation()
	/// prior to invoking this method. Make sure that the number of points
	/// inserted does not exceed the numPts specified in
	/// InitTriangulation(). Also note that the "id" can be any integer and can
	/// be greater than numPts. It is used to create tetras (in AddTetras()) with
	/// the appropriate connectivity ids. The method returns an internal id that
	/// can be used prior to the Triangulate() method to update the type of the
	/// point with UpdatePointType(). (Note: the algorithm triangulated with the
	/// parametric coordinate p[3] and creates tetras with the global coordinate
	/// x[3]. The parametric coordinates and global coordinates may be the same.)
	/// </summary>
	public long InsertPoint(long id, long sortid, long sortid2, IntPtr x, IntPtr p, int type)
	{
		return vtkOrderedTriangulator_InsertPoint_23(GetCppThis(), id, sortid, sortid2, x, p, type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderedTriangulator_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOrderedTriangulator_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderedTriangulator_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOrderedTriangulator_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderedTriangulator_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOrderedTriangulator NewInstance()
	{
		vtkOrderedTriangulator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderedTriangulator_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_PreSortedOff_28(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the points have been pre-sorted. If
	/// pre-sorted is enabled, the points are not sorted on point id.
	/// By default, presorted is off. (The point id is defined in
	/// InsertPoint().)
	/// </summary>
	public virtual void PreSortedOff()
	{
		vtkOrderedTriangulator_PreSortedOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_PreSortedOn_29(HandleRef pThis);

	/// <summary>
	/// Boolean indicates whether the points have been pre-sorted. If
	/// pre-sorted is enabled, the points are not sorted on point id.
	/// By default, presorted is off. (The point id is defined in
	/// InsertPoint().)
	/// </summary>
	public virtual void PreSortedOn()
	{
		vtkOrderedTriangulator_PreSortedOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderedTriangulator_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOrderedTriangulator SafeDownCast(vtkObjectBase o)
	{
		vtkOrderedTriangulator vtkOrderedTriangulator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderedTriangulator_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOrderedTriangulator2 = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOrderedTriangulator2.Register(null);
			}
		}
		return vtkOrderedTriangulator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_SetPreSorted_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean indicates whether the points have been pre-sorted. If
	/// pre-sorted is enabled, the points are not sorted on point id.
	/// By default, presorted is off. (The point id is defined in
	/// InsertPoint().)
	/// </summary>
	public virtual void SetPreSorted(int _arg)
	{
		vtkOrderedTriangulator_SetPreSorted_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_SetUseTemplates_32(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is set, then the ordered triangulator will create
	/// and use templates for the triangulation. To use templates, the
	/// TemplateTriangulate() method should be called when appropriate.
	/// (Note: the TemplateTriangulate() method works for complete
	/// (interior) cells without extra points due to intersection, etc.)
	/// </summary>
	public virtual void SetUseTemplates(int _arg)
	{
		vtkOrderedTriangulator_SetUseTemplates_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_SetUseTwoSortIds_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Tells the triangulator that a second sort id is provided
	/// for each point and should also be considered when sorting.
	/// </summary>
	public virtual void SetUseTwoSortIds(int _arg)
	{
		vtkOrderedTriangulator_SetUseTwoSortIds_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_TemplateTriangulate_34(HandleRef pThis, int cellType, int numPts, int numEdges);

	/// <summary>
	/// Perform the triangulation. (Complete all calls to InsertPoint() prior
	/// to invoking this method.) A special version is available when templates
	/// should be used.
	/// </summary>
	public void TemplateTriangulate(int cellType, int numPts, int numEdges)
	{
		vtkOrderedTriangulator_TemplateTriangulate_34(GetCppThis(), cellType, numPts, numEdges);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_Triangulate_35(HandleRef pThis);

	/// <summary>
	/// Perform the triangulation. (Complete all calls to InsertPoint() prior
	/// to invoking this method.) A special version is available when templates
	/// should be used.
	/// </summary>
	public void Triangulate()
	{
		vtkOrderedTriangulator_Triangulate_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_UpdatePointType_36(HandleRef pThis, long internalId, int type);

	/// <summary>
	/// Update the point type. This is useful when the merging of nearly
	/// coincident points is performed. The id is the internal id returned
	/// from InsertPoint(). The method should be invoked prior to the
	/// Triangulate method. The type is specified as inside (type=0),
	/// outside (type=1), or on the boundary (type=2).
	/// \pre valid_range: internalId&gt;=0 &amp;&amp; internalId&lt;this-&gt;GetNumberOfPoints()
	/// </summary>
	public void UpdatePointType(long internalId, int type)
	{
		vtkOrderedTriangulator_UpdatePointType_36(GetCppThis(), internalId, type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_UseTemplatesOff_37(HandleRef pThis);

	/// <summary>
	/// If this flag is set, then the ordered triangulator will create
	/// and use templates for the triangulation. To use templates, the
	/// TemplateTriangulate() method should be called when appropriate.
	/// (Note: the TemplateTriangulate() method works for complete
	/// (interior) cells without extra points due to intersection, etc.)
	/// </summary>
	public virtual void UseTemplatesOff()
	{
		vtkOrderedTriangulator_UseTemplatesOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_UseTemplatesOn_38(HandleRef pThis);

	/// <summary>
	/// If this flag is set, then the ordered triangulator will create
	/// and use templates for the triangulation. To use templates, the
	/// TemplateTriangulate() method should be called when appropriate.
	/// (Note: the TemplateTriangulate() method works for complete
	/// (interior) cells without extra points due to intersection, etc.)
	/// </summary>
	public virtual void UseTemplatesOn()
	{
		vtkOrderedTriangulator_UseTemplatesOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_UseTwoSortIdsOff_39(HandleRef pThis);

	/// <summary>
	/// Tells the triangulator that a second sort id is provided
	/// for each point and should also be considered when sorting.
	/// </summary>
	public virtual void UseTwoSortIdsOff()
	{
		vtkOrderedTriangulator_UseTwoSortIdsOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderedTriangulator_UseTwoSortIdsOn_40(HandleRef pThis);

	/// <summary>
	/// Tells the triangulator that a second sort id is provided
	/// for each point and should also be considered when sorting.
	/// </summary>
	public virtual void UseTwoSortIdsOn()
	{
		vtkOrderedTriangulator_UseTwoSortIdsOn_40(GetCppThis());
	}
}
