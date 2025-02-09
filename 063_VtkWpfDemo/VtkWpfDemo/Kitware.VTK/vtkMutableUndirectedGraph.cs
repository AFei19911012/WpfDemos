using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMutableUndirectedGraph
/// </summary>
/// <remarks>
///    An editable undirected graph.
///
///
/// vtkMutableUndirectedGraph is an undirected graph with additional functions
/// for adding vertices and edges. ShallowCopy(), DeepCopy(), CheckedShallowCopy(),
/// and CheckedDeepCopy() will succeed when the argument is a vtkUndirectedGraph
/// or vtkMutableUndirectedGraph.
///
/// </remarks>
/// <seealso>
///
/// vtkUndirectedGraph vtkGraph
/// </seealso>
public class vtkMutableUndirectedGraph : vtkUndirectedGraph
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMutableUndirectedGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMutableUndirectedGraph()
	{
		MRClassNameKey = "class vtkMutableUndirectedGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableUndirectedGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMutableUndirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableUndirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMutableUndirectedGraph New()
	{
		vtkMutableUndirectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableUndirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMutableUndirectedGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMutableUndirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkMutableUndirectedGraph_AddGraphEdge_01(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkMutableUndirectedGraph_AddGraphEdge_01(GetCppThis(), u, v, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkMutableUndirectedGraph_AddVertex_02(HandleRef pThis);

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
		return vtkMutableUndirectedGraph_AddVertex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableUndirectedGraph_AddVertex_03(HandleRef pThis, HandleRef propertyArr);

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
		return vtkMutableUndirectedGraph_AddVertex_03(GetCppThis(), propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableUndirectedGraph_AddVertex_04(HandleRef pThis, HandleRef pedigreeId);

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
		return vtkMutableUndirectedGraph_AddVertex_04(GetCppThis(), pedigreeId?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableUndirectedGraph_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMutableUndirectedGraph_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableUndirectedGraph_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMutableUndirectedGraph_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMutableUndirectedGraph_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMutableUndirectedGraph_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMutableUndirectedGraph_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMutableUndirectedGraph_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_09(HandleRef pThis, long u, long v);

	/// <summary>
	/// Adds an undirected edge from \p u to \p v,
	/// where \p u and \p v are vertex indices.
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddEdge(long u, long v)
	{
		vtkMutableUndirectedGraph_LazyAddEdge_09(GetCppThis(), u, v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_10(HandleRef pThis, long u, long v, HandleRef propertyArr);

	/// <summary>
	/// Adds an undirected edge from \p u to \p v,
	/// where \p u and \p v are vertex indices.
	///
	/// The number and order of values in
	/// \p propertyArr must match up with the arrays in the edge data
	/// retrieved by GetEdgeData().
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddEdge(long u, long v, vtkVariantArray propertyArr)
	{
		vtkMutableUndirectedGraph_LazyAddEdge_10(GetCppThis(), u, v, propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_11(HandleRef pThis, HandleRef u, long v, HandleRef propertyArr);

	/// <summary>
	/// Adds an undirected edge from \p u to \p v,
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
		vtkMutableUndirectedGraph_LazyAddEdge_11(GetCppThis(), u?.GetCppThis() ?? default(HandleRef), v, propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_12(HandleRef pThis, long u, HandleRef v, HandleRef propertyArr);

	/// <summary>
	/// Adds an undirected edge from \p u to \p v,
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
		vtkMutableUndirectedGraph_LazyAddEdge_12(GetCppThis(), u, v?.GetCppThis() ?? default(HandleRef), propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_13(HandleRef pThis, HandleRef u, HandleRef v, HandleRef propertyArr);

	/// <summary>
	/// Adds an undirected edge from \p u to \p v,
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
		vtkMutableUndirectedGraph_LazyAddEdge_13(GetCppThis(), u?.GetCppThis() ?? default(HandleRef), v?.GetCppThis() ?? default(HandleRef), propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_LazyAddVertex_14(HandleRef pThis);

	/// <summary>
	/// Adds a vertex to the graph.
	///
	/// This method is lazily evaluated for distributed graphs (i.e. graphs
	/// whose DistributedHelper is non-null) the next time Synchronize is
	/// called on the helper.
	/// </summary>
	public void LazyAddVertex()
	{
		vtkMutableUndirectedGraph_LazyAddVertex_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_LazyAddVertex_15(HandleRef pThis, HandleRef propertyArr);

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
		vtkMutableUndirectedGraph_LazyAddVertex_15(GetCppThis(), propertyArr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_LazyAddVertex_16(HandleRef pThis, HandleRef pedigreeId);

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
		vtkMutableUndirectedGraph_LazyAddVertex_16(GetCppThis(), pedigreeId?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableUndirectedGraph_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMutableUndirectedGraph NewInstance()
	{
		vtkMutableUndirectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableUndirectedGraph_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_RemoveEdge_19(HandleRef pThis, long e);

	/// <summary>
	/// Removes the edge from the graph.
	/// Note: This invalidates the last edge index, which is reassigned to e.
	/// </summary>
	public void RemoveEdge(long e)
	{
		vtkMutableUndirectedGraph_RemoveEdge_19(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_RemoveEdges_20(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Removes a collection of edges from the graph.
	/// </summary>
	public void RemoveEdges(vtkIdTypeArray arr)
	{
		vtkMutableUndirectedGraph_RemoveEdges_20(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_RemoveVertex_21(HandleRef pThis, long v);

	/// <summary>
	/// Removes the vertex from the graph along with any connected edges.
	/// Note: This invalidates the last vertex index, which is reassigned to v.
	/// </summary>
	public void RemoveVertex(long v)
	{
		vtkMutableUndirectedGraph_RemoveVertex_21(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableUndirectedGraph_RemoveVertices_22(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Removes a collection of vertices from the graph along with any connected edges.
	/// </summary>
	public void RemoveVertices(vtkIdTypeArray arr)
	{
		vtkMutableUndirectedGraph_RemoveVertices_22(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableUndirectedGraph_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMutableUndirectedGraph SafeDownCast(vtkObjectBase o)
	{
		vtkMutableUndirectedGraph vtkMutableUndirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableUndirectedGraph_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMutableUndirectedGraph2 = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMutableUndirectedGraph2.Register(null);
			}
		}
		return vtkMutableUndirectedGraph2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableUndirectedGraph_SetNumberOfVertices_24(HandleRef pThis, long numVerts);

	/// <summary>
	/// Allocates space for the specified number of vertices in the graph's
	/// internal data structures.
	/// The previous number of vertices is returned on success and -1
	/// is returned on failure.
	///
	/// This has no effect on the number of vertex coordinate tuples or
	/// vertex attribute tuples allocated; you are responsible for
	/// guaranteeing these match.
	/// Also, this call is not implemented for distributed-memory graphs since
	/// the semantics are unclear; calling this function on a graph with a
	/// non-nullptr DistributedGraphHelper will generate an error message,
	/// no allocation will be performed, and a value of -1 will be returned.
	/// </summary>
	public virtual long SetNumberOfVertices(long numVerts)
	{
		return vtkMutableUndirectedGraph_SetNumberOfVertices_24(GetCppThis(), numVerts);
	}
}
