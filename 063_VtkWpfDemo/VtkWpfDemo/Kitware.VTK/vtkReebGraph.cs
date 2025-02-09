using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkReebGraph
/// </summary>
/// <remarks>
///    Reeb graph computation for PL scalar fields.
///
///
/// vtkReebGraph is a class that computes a Reeb graph given a PL scalar
/// field (vtkDataArray) defined on a simplicial mesh.
/// A Reeb graph is a concise representation of the connectivity evolution of
/// the level sets of a scalar function.
///
/// It is particularly useful in visualization (optimal seed set computation,
/// fast flexible isosurface extraction, automated transfer function design,
/// feature-driven visualization, etc.) and computer graphics (shape
/// deformation, shape matching, shape compression, etc.).
///
/// Reference:
/// "Sur les points singuliers d'une forme de Pfaff completement integrable ou
/// d'une fonction numerique",
/// G. Reeb,
/// Comptes-rendus de l'Academie des Sciences, 222:847-849, 1946.
///
/// vtkReebGraph implements one of the latest and most robust Reeb graph
/// computation algorithms.
///
/// Reference:
/// "Robust on-line computation of Reeb graphs: simplicity and speed",
/// V. Pascucci, G. Scorzelli, P.-T. Bremer, and A. Mascarenhas,
/// ACM Transactions on Graphics, Proc. of SIGGRAPH 2007.
///
/// vtkReebGraph provides methods for computing multi-resolution topological
/// hierarchies through topological simplification.
/// Topoligical simplification can be either driven by persistence homology
/// concepts (default behavior) or by application specific metrics (see
/// vtkReebGraphSimplificationMetric).
/// In the latter case, designing customized simplification metric evaluation
/// algorithms enables the user to control the definition of what should be
/// considered as noise or signal in the topological filtering process.
///
/// References:
/// "Topological persistence and simplification",
/// H. Edelsbrunner, D. Letscher, and A. Zomorodian,
/// Discrete Computational Geometry, 28:511-533, 2002.
///
/// "Extreme elevation on a 2-manifold",
/// P.K. Agarwal, H. Edelsbrunner, J. Harer, and Y. Wang,
/// ACM Symposium on Computational Geometry, pp. 357-365, 2004.
///
/// "Simplifying flexible isosurfaces using local geometric measures",
/// H. Carr, J. Snoeyink, M van de Panne,
/// IEEE Visualization, 497-504, 2004
///
/// "Loop surgery for volumetric meshes: Reeb graphs reduced to contour trees",
/// J. Tierny, A. Gyulassy, E. Simon, V. Pascucci,
/// IEEE Trans. on Vis. and Comp. Graph. (Proc of IEEE VIS), 15:1177-1184, 2009.
///
///
///
/// Reeb graphs can be computed from 2D data (vtkPolyData, with triangles only)
/// or 3D data (vtkUnstructuredGrid, with tetrahedra only), sequentially (see
/// the "Build" calls) or in streaming (see the "StreamTriangle" and
/// "StreamTetrahedron" calls).
///
/// vtkReebGraph inherits from vtkMutableDirectedGraph.
///
/// Each vertex of a vtkReebGraph object represents a critical point of the
/// scalar field where the connectivity of the related level set changes
/// (creation, deletion, split or merge of connected components).
/// A vtkIdTypeArray (called "Vertex Ids") is associated with the VertexData of
/// a vtkReebGraph object, in order to retrieve if necessary the exact Ids of
/// the corresponding vertices in the input mesh.
///
/// The edges of a vtkReebGraph object represent the regions of the input mesh
/// separated by the critical contours of the field, and where the connectivity
/// of the input field does not change.
/// A vtkVariantArray is associated with the EdgeDta of a vtkReebGraph object and
/// each entry of this array is a vtkAbstractArray containing the Ids of the
/// vertices of those regions, sorted by function value (useful for flexible
/// isosurface extraction or level set signature computation, for instance).
///
/// See Graphics/Testing/Cxx/TestReebGraph.cxx for examples of traversals and
/// typical usages (customized simplification, skeletonization, contour spectra,
///  etc.) of a vtkReebGraph object.
///
///
/// </remarks>
/// <seealso>
///
///      vtkReebGraphSimplificationMetric
///      vtkPolyDataToReebGraphFilter
///      vtkUnstructuredGridToReebGraphFilter
///      vtkReebGraphSimplificationFilter
///      vtkReebGraphSurfaceSkeletonFilter
///      vtkReebGraphVolumeSkeletonFilter
///      vtkAreaContourSpectrumFilter
///      vtkVolumeContourSpectrumFilter
///
/// @par Tests:
///      Graphics/Testing/Cxx/TestReebGraph.cxx
/// </seealso>
public class vtkReebGraph : vtkMutableDirectedGraph
{
	/// <summary>
	/// Return class name of data type. This is one of VTK_STRUCTURED_GRID,
	/// VTK_STRUCTURED_POINTS, VTK_UNSTRUCTURED_GRID, VTK_POLY_DATA, or
	/// VTK_RECTILINEAR_GRID (see vtkSetGet.h for definitions).
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public enum ERR_INCORRECT_FIELD_WrapperEnum
	{
		/// <summary>enum member</summary>
		ERR_INCORRECT_FIELD = -1,
		/// <summary>enum member</summary>
		ERR_NOT_A_SIMPLICIAL_MESH = -3,
		/// <summary>enum member</summary>
		ERR_NO_SUCH_FIELD = -2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkReebGraph()
	{
		MRClassNameKey = "class vtkReebGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkReebGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReebGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReebGraph New()
	{
		vtkReebGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReebGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkReebGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkReebGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkReebGraph_Build_01(HandleRef pThis, HandleRef mesh, HandleRef scalarField);

	/// <summary>
	/// Build the Reeb graph of the field 'scalarField' defined on the surface
	/// mesh 'mesh'.
	///
	/// Returned values:
	///
	/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
	/// tuples as 'mesh' has vertices.
	///
	/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
	/// simplicial mesh (for example, the surface mesh contains quads instead of
	/// triangles).
	/// </summary>
	public int Build(vtkPolyData mesh, vtkDataArray scalarField)
	{
		return vtkReebGraph_Build_01(GetCppThis(), mesh?.GetCppThis() ?? default(HandleRef), scalarField?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_Build_02(HandleRef pThis, HandleRef mesh, HandleRef scalarField);

	/// <summary>
	/// Build the Reeb graph of the field 'scalarField' defined on the volume
	/// mesh 'mesh'.
	///
	/// Returned values:
	///
	/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
	/// tuples as 'mesh' has vertices.
	///
	/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
	/// simplicial mesh.
	/// </summary>
	public int Build(vtkUnstructuredGrid mesh, vtkDataArray scalarField)
	{
		return vtkReebGraph_Build_02(GetCppThis(), mesh?.GetCppThis() ?? default(HandleRef), scalarField?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_Build_03(HandleRef pThis, HandleRef mesh, long scalarFieldId);

	/// <summary>
	/// Build the Reeb graph of the field given by the Id 'scalarFieldId',
	/// defined on the surface mesh 'mesh'.
	///
	/// Returned values:
	///
	/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
	/// tuples as 'mesh' as vertices.
	///
	/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
	/// simplicial mesh (for example, the surface mesh contains quads instead of
	/// triangles).
	///
	/// vtkReebGraph::ERR_NO_SUCH_FIELD: the scalar field given by the Id
	/// 'scalarFieldId' does not exist.
	/// </summary>
	public int Build(vtkPolyData mesh, long scalarFieldId)
	{
		return vtkReebGraph_Build_03(GetCppThis(), mesh?.GetCppThis() ?? default(HandleRef), scalarFieldId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_Build_04(HandleRef pThis, HandleRef mesh, long scalarFieldId);

	/// <summary>
	/// Build the Reeb graph of the field given by the Id 'scalarFieldId',
	/// defined on the volume mesh 'mesh'.
	///
	/// Returned values:
	///
	/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
	/// tuples as 'mesh' as vertices.
	///
	/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
	/// simplicial mesh.
	///
	/// vtkReebGraph::ERR_NO_SUCH_FIELD: the scalar field given by the Id
	/// 'scalarFieldId' does not exist.
	/// </summary>
	public int Build(vtkUnstructuredGrid mesh, long scalarFieldId)
	{
		return vtkReebGraph_Build_04(GetCppThis(), mesh?.GetCppThis() ?? default(HandleRef), scalarFieldId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_Build_05(HandleRef pThis, HandleRef mesh, string scalarFieldName);

	/// <summary>
	/// Build the Reeb graph of the field given by the name 'scalarFieldName',
	/// defined on the surface mesh 'mesh'.
	///
	/// Returned values:
	///
	/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
	/// tuples as 'mesh' as vertices.
	///
	/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
	/// simplicial mesh (for example, the surface mesh contains quads instead of
	/// triangles).
	///
	/// vtkReebGraph::ERR_NO_SUCH_FIELD: the scalar field given by the name
	/// 'scalarFieldName' does not exist.
	/// </summary>
	public int Build(vtkPolyData mesh, string scalarFieldName)
	{
		return vtkReebGraph_Build_05(GetCppThis(), mesh?.GetCppThis() ?? default(HandleRef), scalarFieldName);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_Build_06(HandleRef pThis, HandleRef mesh, string scalarFieldName);

	/// <summary>
	/// Build the Reeb graph of the field given by the name 'scalarFieldName',
	/// defined on the volume mesh 'mesh'.
	///
	/// Returned values:
	///
	/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
	/// tuples as 'mesh' as vertices.
	///
	/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
	/// simplicial mesh.
	///
	/// vtkReebGraph::ERR_NO_SUCH_FIELD: the scalar field given by the name
	/// 'scalarFieldName' does not exist.
	/// </summary>
	public int Build(vtkUnstructuredGrid mesh, string scalarFieldName)
	{
		return vtkReebGraph_Build_06(GetCppThis(), mesh?.GetCppThis() ?? default(HandleRef), scalarFieldName);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReebGraph_CloseStream_07(HandleRef pThis);

	/// <summary>
	/// Finalize internal data structures, in the case of streaming computations
	/// (with StreamTriangle or StreamTetrahedron).
	/// After this call, no more triangle or tetrahedron can be inserted via
	/// StreamTriangle or StreamTetrahedron.
	/// IMPORTANT: This method _must_ be called when the input stream is finished.
	/// If you need to get a snapshot of the Reeb graph during the streaming
	/// process (to parse or simplify it), do a DeepCopy followed by a
	/// CloseStream on the copy.
	/// </summary>
	public void CloseStream()
	{
		vtkReebGraph_CloseStream_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReebGraph_DeepCopy_08(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Finalize internal data structures, in the case of streaming computations
	/// (with StreamTriangle or StreamTetrahedron).
	/// After this call, no more triangle or tetrahedron can be inserted via
	/// StreamTriangle or StreamTetrahedron.
	/// IMPORTANT: This method _must_ be called when the input stream is finished.
	/// If you need to get a snapshot of the Reeb graph during the streaming
	/// process (to parse or simplify it), do a DeepCopy followed by a
	/// CloseStream on the copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkReebGraph_DeepCopy_08(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_GetDataObjectType_09(HandleRef pThis);

	/// <summary>
	/// Return class name of data type. This is one of VTK_STRUCTURED_GRID,
	/// VTK_STRUCTURED_POINTS, VTK_UNSTRUCTURED_GRID, VTK_POLY_DATA, or
	/// VTK_RECTILINEAR_GRID (see vtkSetGet.h for definitions).
	/// THIS METHOD IS THREAD SAFE
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkReebGraph_GetDataObjectType_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReebGraph_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkReebGraph_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReebGraph_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkReebGraph_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkReebGraph_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkReebGraph_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReebGraph_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkReebGraph NewInstance()
	{
		vtkReebGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReebGraph_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReebGraph_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReebGraph SafeDownCast(vtkObjectBase o)
	{
		vtkReebGraph vtkReebGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReebGraph_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkReebGraph2 = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkReebGraph2.Register(null);
			}
		}
		return vtkReebGraph2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReebGraph_Set_17(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Use a pre-defined Reeb graph (post-processing).
	/// Use with caution!
	/// </summary>
	public void Set(vtkMutableDirectedGraph g)
	{
		vtkReebGraph_Set_17(GetCppThis(), g?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_Simplify_18(HandleRef pThis, double simplificationThreshold, HandleRef simplificationMetric);

	/// <summary>
	/// Simplify the Reeb graph given a threshold 'simplificationThreshold'
	/// (between 0 and 1).
	///
	/// This method is the core feature for Reeb graph multi-resolution hierarchy
	/// construction.
	///
	/// Return the number of arcs that have been removed through the simplification
	/// process.
	///
	/// 'simplificationThreshold' represents a "scale", under which each Reeb graph
	/// feature is considered as noise. 'simplificationThreshold' is expressed as a
	/// fraction of the scalar field overall span. It can vary from 0
	/// (no simplification) to 1 (maximal simplification).
	///
	/// 'simplificationMetric' is an object in charge of evaluating the importance
	/// of a Reeb graph arc at each step of the simplification process.
	/// if 'simplificationMetric' is nullptr, the default strategy (persitence of the
	/// scalar field) is used.
	/// Customized simplification metric evaluation algorithm can be designed (see
	/// vtkReebGraphSimplificationMetric), enabling the user to control the
	/// definition of what should be considered as noise or signal.
	///
	/// References:
	///
	/// "Topological persistence and simplification",
	/// H. Edelsbrunner, D. Letscher, and A. Zomorodian,
	/// Discrete Computational Geometry, 28:511-533, 2002.
	///
	/// "Extreme elevation on a 2-manifold",
	/// P.K. Agarwal, H. Edelsbrunner, J. Harer, and Y. Wang,
	/// ACM Symposium on Computational Geometry, pp. 357-365, 2004.
	///
	/// "Simplifying flexible isosurfaces using local geometric measures",
	/// H. Carr, J. Snoeyink, M van de Panne,
	/// IEEE Visualization, 497-504, 2004
	///
	/// "Loop surgery for volumetric meshes: Reeb graphs reduced to contour trees",
	/// J. Tierny, A. Gyulassy, E. Simon, V. Pascucci,
	/// IEEE Trans. on Vis. and Comp. Graph. (Proc of IEEE VIS), 15:1177-1184,2009.
	/// </summary>
	public int Simplify(double simplificationThreshold, vtkReebGraphSimplificationMetric simplificationMetric)
	{
		return vtkReebGraph_Simplify_18(GetCppThis(), simplificationThreshold, simplificationMetric?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_StreamTetrahedron_19(HandleRef pThis, long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2, long vertex3Id, double scalar3);

	/// <summary>
	/// Streaming Reeb graph computation.
	/// Add to the streaming computation the tetrahedra of the vtkUnstructuredGrid
	/// volume mesh described by
	/// vertex0Id, scalar0
	/// vertex1Id, scalar1
	/// vertex2Id, scalar2
	/// vertex3Id, scalar3
	///
	/// where vertexNId is the Id of the vertex in the vtkUnstructuredGrid
	/// structure and scalarN is the corresponding scalar field value.
	///
	/// IMPORTANT: The stream _must_ be finalized with the "CloseStream" call.
	/// </summary>
	public int StreamTetrahedron(long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2, long vertex3Id, double scalar3)
	{
		return vtkReebGraph_StreamTetrahedron_19(GetCppThis(), vertex0Id, scalar0, vertex1Id, scalar1, vertex2Id, scalar2, vertex3Id, scalar3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReebGraph_StreamTriangle_20(HandleRef pThis, long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2);

	/// <summary>
	/// Streaming Reeb graph computation.
	/// Add to the streaming computation the triangle of the vtkPolyData surface
	/// mesh described by
	/// vertex0Id, scalar0
	/// vertex1Id, scalar1
	/// vertex2Id, scalar2
	///
	/// where vertexNId is the Id of the vertex in the vtkPolyData structure
	/// and scalarN is the corresponding scalar field value.
	///
	/// IMPORTANT: The stream _must_ be finalized with the "CloseStream" call.
	/// </summary>
	public int StreamTriangle(long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2)
	{
		return vtkReebGraph_StreamTriangle_20(GetCppThis(), vertex0Id, scalar0, vertex1Id, scalar1, vertex2Id, scalar2);
	}
}
