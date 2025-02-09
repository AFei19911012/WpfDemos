using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMutableDirectedGraph
/// </summary>
/// <remarks>
///    An editable directed graph.
///
///
/// vtkMutableDirectedGraph is a directed graph which has additional methods
/// for adding edges and vertices. AddChild() is a convenience method for
/// constructing trees. ShallowCopy(), DeepCopy(), CheckedShallowCopy() and
/// CheckedDeepCopy() will succeed for instances of vtkDirectedGraph,
/// vtkMutableDirectedGraph and vtkTree.
///
/// </remarks>
/// <seealso>
///
/// vtkDirectedGraph vtkGraph vtkTree
/// </seealso>
public class vtkMutableDirectedGraph : vtkDirectedGraph
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMutableDirectedGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMutableDirectedGraph()
	{
		MRClassNameKey = "class vtkMutableDirectedGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableDirectedGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMutableDirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableDirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMutableDirectedGraph New()
	{
		vtkMutableDirectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableDirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMutableDirectedGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMutableDirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkMutableDirectedGraph_AddChild_01(HandleRef pThis, long parent, HandleRef propertyArr);

	/// <summary>
	/// Convenience method for creating trees.
	/// Returns the newly created vertex id.
	/// Shortcut for
	/// <code>
	/// vtkIdType v = g-&gt;AddVertex();
	/// g-&gt;AddEdge(parent, v);
	/// </code>
	/// If non-null, \p propertyArr provides edge properties
	/// for the newly-created edge. The values in \p propertyArr must match
	/// up with the arrays in the edge data returned by GetEdgeData().
	/// </summary>
	public long AddChild(long parent, vtkVariantArray propertyArr)
	{
		return vtkMutableDirectedGraph_AddChild_01(GetCppThis(), parent, propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableDirectedGraph_AddChild_02(HandleRef pThis, long parent);

	/// <summary>
	/// Convenience method for creating trees.
	/// Returns the newly created vertex id.
	/// Shortcut for
	/// <code>
	/// vtkIdType v = g-&gt;AddVertex();
	/// g-&gt;AddEdge(parent, v);
	/// </code>
	/// If non-null, \p propertyArr provides edge properties
	/// for the newly-created edge. The values in \p propertyArr must match
	/// up with the arrays in the edge data returned by GetEdgeData().
	/// </summary>
	public long AddChild(long parent)
	{
		return vtkMutableDirectedGraph_AddChild_02(GetCppThis(), parent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableDirectedGraph_AddGraphEdge_03(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Variant of AddEdge() that returns a heavyweight \p vtkGraphEdge object.
	/// The graph owns the reference of the edge and will replace
	/// its contents on the next call to AddGraphEdge().
	///
	/// \note This is a less efficient method for use with wrappers.
	/// In C++ you should use the faster AddEdge().
	/// </summary>
	public vtkGraphEdge AddGraphEdge(long u, long v)
	{
		vtkGraphEdge vtkGraphEdge2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableDirectedGraph_AddGraphEdge_03(GetCppThis(), u, v, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphEdge2 = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphEdge2.Register(null);
			}
		}
		return vtkGraphEdge2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableDirectedGraph_AddVertex_04(HandleRef pThis);

	/// <summary>
	/// Adds a vertex to the graph and returns the index of the new vertex.
	///
	/// \note In a distributed graph (i.e. a graph whose DistributedHelper
	/// is non-null), this routine cannot be used to add a vertex
	/// if the vertices in the graph have pedigree IDs, because this routine
	/// will always add the vertex locally, which may conflict with the
	/// proper location of the vertex based on the distribution of the
	/// pedigree IDs.
	/// </summary>
	public long AddVertex()
	{
		return vtkMutableDirectedGraph_AddVertex_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableDirectedGraph_AddVertex_05(HandleRef pThis, HandleRef propertyArr);

	/// <summary>
	/// Adds a vertex to the graph with associated properties defined in
	/// \p propertyArr and returns the index of the new vertex.
	/// The number and order of values in \p propertyArr must match up with the
	/// arrays in the vertex data retrieved by GetVertexData().
	///
	/// If a vertex with the given pedigree ID already exists, its properties will be
	/// overwritten with the properties in \p propertyArr and the existing
	/// vertex index will be returned.
	///
	/// \note In a distributed graph (i.e. a graph whose DistributedHelper
	/// is non-null) the vertex added or found might not be local. In this case,
	/// AddVertex will wait until the vertex can be added or found
	/// remotely, so that the proper vertex index can be returned. If you
	/// don't actually need to use the vertex index, consider calling
	/// LazyAddVertex, which provides better performance by eliminating
	/// the delays associated with returning the vertex index.
	/// </summary>
	public long AddVertex(vtkVariantArray propertyArr)
	{
		return vtkMutableDirectedGraph_AddVertex_05(GetCppThis(), propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableDirectedGraph_AddVertex_06(HandleRef pThis, HandleRef pedigreeId);

	/// <summary>
	/// Adds a vertex with the given \p pedigreeID to the graph and
	/// returns the index of the new vertex.
	///
	/// If a vertex with the given pedigree ID already exists,
	/// the existing vertex index will be returned.
	///
	/// \note In a distributed graph (i.e. a graph whose DistributedHelper
	/// is non-null) the vertex added or found might not be local. In this case,
	/// AddVertex will wait until the vertex can be added or found
	/// remotely, so that the proper vertex index can be returned. If you
	/// don't actually need to use the vertex index, consider calling
	/// LazyAddVertex, which provides better performance by eliminating
	/// the delays associated with returning the vertex index.
	/// </summary>
	public long AddVertex(vtkVariant pedigreeId)
	{
		return vtkMutableDirectedGraph_AddVertex_06(GetCppThis(), pedigreeId?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableDirectedGraph_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMutableDirectedGraph_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableDirectedGraph_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMutableDirectedGraph_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMutableDirectedGraph_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMutableDirectedGraph_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMutableDirectedGraph_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMutableDirectedGraph_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_LazyAddEdge_11(HandleRef pThis, long u, long v, HandleRef propertyArr);

	/// <summary>
	/// Adds a directed edge from \p u to \p v,
	/// where \p u and \p v are vertex indices.
	///
	/// The number and order of values in the optional parameter
	/// \p propertyArr must match up with the arrays in the edge data
	/// retrieved by GetEdgeData().
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddEdge(long u, long v, vtkVariantArray propertyArr)
	{
		vtkMutableDirectedGraph_LazyAddEdge_11(GetCppThis(), u, v, propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_LazyAddEdge_12(HandleRef pThis, HandleRef u, long v, HandleRef propertyArr);

	/// <summary>
	/// Adds a directed edge from \p u to \p v,
	/// where \p u is a vertex pedigree ID and \p v is a vertex index.
	///
	/// The number and order of values in the optional parameter
	/// \p propertyArr must match up with the arrays in the edge data
	/// retrieved by GetEdgeData().
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddEdge(vtkVariant u, long v, vtkVariantArray propertyArr)
	{
		vtkMutableDirectedGraph_LazyAddEdge_12(GetCppThis(), u?.GetCppThis() ?? default(HandleRef), v, propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_LazyAddEdge_13(HandleRef pThis, long u, HandleRef v, HandleRef propertyArr);

	/// <summary>
	/// Adds a directed edge from \p u to \p v,
	/// where \p u is a vertex index and \p v is a vertex pedigree ID.
	///
	/// The number and order of values in the optional parameter
	/// \p propertyArr must match up with the arrays in the edge data
	/// retrieved by GetEdgeData().
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddEdge(long u, vtkVariant v, vtkVariantArray propertyArr)
	{
		vtkMutableDirectedGraph_LazyAddEdge_13(GetCppThis(), u, v?.GetCppThis() ?? default(HandleRef), propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_LazyAddEdge_14(HandleRef pThis, HandleRef u, HandleRef v, HandleRef propertyArr);

	/// <summary>
	/// Adds a directed edge from \p u to \p v,
	/// where \p u and \p v are vertex pedigree IDs.
	///
	/// The number and order of values in the optional parameter
	/// \p propertyArr must match up with the arrays in the edge data
	/// retrieved by GetEdgeData().
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddEdge(vtkVariant u, vtkVariant v, vtkVariantArray propertyArr)
	{
		vtkMutableDirectedGraph_LazyAddEdge_14(GetCppThis(), u?.GetCppThis() ?? default(HandleRef), v?.GetCppThis() ?? default(HandleRef), propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_LazyAddVertex_15(HandleRef pThis);

	/// <summary>
	/// Adds a vertex to the graph.
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddVertex()
	{
		vtkMutableDirectedGraph_LazyAddVertex_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_LazyAddVertex_16(HandleRef pThis, HandleRef propertyArr);

	/// <summary>
	/// Adds a vertex to the graph with associated properties defined in
	/// \p propertyArr.
	/// The number and order of values in \p propertyArr must match up with the
	/// arrays in the vertex data retrieved by GetVertexData().
	///
	/// If a vertex with the given pedigree ID already exists, its properties will be
	/// overwritten with the properties in \p propertyArr.
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddVertex(vtkVariantArray propertyArr)
	{
		vtkMutableDirectedGraph_LazyAddVertex_16(GetCppThis(), propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_LazyAddVertex_17(HandleRef pThis, HandleRef pedigreeId);

	/// <summary>
	/// Adds a vertex with the given \p pedigreeID to the graph.
	///
	/// If a vertex with the given pedigree ID already exists,
	/// no operation is performed.
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddVertex(vtkVariant pedigreeId)
	{
		vtkMutableDirectedGraph_LazyAddVertex_17(GetCppThis(), pedigreeId?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableDirectedGraph_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMutableDirectedGraph NewInstance()
	{
		vtkMutableDirectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableDirectedGraph_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_RemoveEdge_20(HandleRef pThis, long e);

	/// <summary>
	/// Removes the edge from the graph.
	/// Note: This invalidates the last edge index, which is reassigned to e.
	/// </summary>
	public void RemoveEdge(long e)
	{
		vtkMutableDirectedGraph_RemoveEdge_20(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_RemoveEdges_21(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Removes a collection of edges from the graph.
	/// </summary>
	public void RemoveEdges(vtkIdTypeArray arr)
	{
		vtkMutableDirectedGraph_RemoveEdges_21(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_RemoveVertex_22(HandleRef pThis, long v);

	/// <summary>
	/// Removes the vertex from the graph along with any connected edges.
	/// Note: This invalidates the last vertex index, which is reassigned to v.
	/// </summary>
	public void RemoveVertex(long v)
	{
		vtkMutableDirectedGraph_RemoveVertex_22(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableDirectedGraph_RemoveVertices_23(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Removes a collection of vertices from the graph along with any connected edges.
	/// </summary>
	public void RemoveVertices(vtkIdTypeArray arr)
	{
		vtkMutableDirectedGraph_RemoveVertices_23(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableDirectedGraph_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMutableDirectedGraph SafeDownCast(vtkObjectBase o)
	{
		vtkMutableDirectedGraph vtkMutableDirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableDirectedGraph_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMutableDirectedGraph2 = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMutableDirectedGraph2.Register(null);
			}
		}
		return vtkMutableDirectedGraph2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableDirectedGraph_SetNumberOfVertices_25(HandleRef pThis, long numVerts);

	/// <summary>
	/// Allocates space for the specified number of vertices in the graph's
	/// internal data structures.
	///
	/// This has no effect on the number of vertex coordinate tuples or
	/// vertex attribute tuples allocated; you are responsible for
	/// guaranteeing these match.
	/// Also, this call is not implemented for distributed-memory graphs since
	/// the semantics are unclear; calling this function on a graph with a
	/// non-nullptr DistributedGraphHelper will generate an error message and
	/// no allocation will be performed.
	/// </summary>
	public virtual long SetNumberOfVertices(long numVerts)
	{
		return vtkMutableDirectedGraph_SetNumberOfVertices_25(GetCppThis(), numVerts);
	}
}
