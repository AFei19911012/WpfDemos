using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraph
/// </summary>
/// <remarks>
///    Base class for graph data types.
///
///
/// vtkGraph is the abstract base class that provides all read-only API for graph
/// data types. A graph consists of a collection of vertices and a
/// collection of edges connecting pairs of vertices. The vtkDirectedGraph
/// subclass represents a graph whose edges have inherent order from source
/// vertex to target vertex, while vtkUndirectedGraph is a graph whose edges
/// have no inherent ordering.
///
/// Graph vertices may be traversed in two ways. In the current implementation,
/// all vertices are assigned consecutive ids starting at zero, so they may
/// be traversed in a simple for loop from 0 to graph-&gt;GetNumberOfVertices() - 1.
/// You may alternately create a vtkVertexListIterator and call graph-&gt;GetVertices(it).
/// it-&gt;Next() will return the id of the next vertex, while it-&gt;HasNext() indicates
/// whether there are more vertices in the graph.
/// This is the preferred method, since in the future graphs may support filtering
/// or subsetting where the vertex ids may not be contiguous.
///
/// Graph edges must be traversed through iterators. To traverse all edges
/// in a graph, create an instance of vtkEdgeListIterator and call graph-&gt;GetEdges(it).
/// it-&gt;Next() returns lightweight vtkEdgeType structures, which contain the public
/// fields Id, Source and Target. Id is the identifier for the edge, which may
/// be used to look up values in associated edge data arrays. Source and Target
/// store the ids of the source and target vertices of the edge. Note that the
/// edge list iterator DOES NOT necessarily iterate over edges in order of ascending
/// id. To traverse edges from wrapper code (Python, Java), use
/// it-&gt;NextGraphEdge() instead of it-&gt;Next().  This will return a heavyweight,
/// wrappable vtkGraphEdge object, which has the same fields as vtkEdgeType
/// accessible through getter methods.
///
/// To traverse all edges outgoing from a vertex, create a vtkOutEdgeIterator and
/// call graph-&gt;GetOutEdges(v, it). it-&gt;Next() returns a lightweight vtkOutEdgeType
/// containing the fields Id and Target. The source of the edge is always the
/// vertex that was passed as an argument to GetOutEdges().
/// Incoming edges may be similarly traversed with vtkInEdgeIterator, which returns
/// vtkInEdgeType structures with Id and Source fields.
/// Both vtkOutEdgeIterator and vtkInEdgeIterator also provide the wrapper functions
/// NextGraphEdge() which return vtkGraphEdge objects.
///
/// An additional iterator, vtkAdjacentVertexIterator can traverse outgoing vertices
/// directly, instead needing to parse through edges. Initialize the iterator by
/// calling graph-&gt;GetAdjacentVertices(v, it).
///
/// vtkGraph has two instances of vtkDataSetAttributes for associated
/// vertex and edge data. It also has a vtkPoints instance which may store
/// x,y,z locations for each vertex. This is populated by filters such as
/// vtkGraphLayout and vtkAssignCoordinates.
///
/// All graph types share the same implementation, so the structure of one
/// may be shared among multiple graphs, even graphs of different types.
/// Structures from vtkUndirectedGraph and vtkMutableUndirectedGraph may be
/// shared directly.  Structures from vtkDirectedGraph, vtkMutableDirectedGraph,
/// and vtkTree may be shared directly with the exception that setting a
/// structure to a tree requires that a "is a tree" test passes.
///
/// For graph types that are known to be compatible, calling ShallowCopy()
/// or DeepCopy() will work as expected.  When the outcome of a conversion
/// is unknown (i.e. setting a graph to a tree), CheckedShallowCopy() and
/// CheckedDeepCopy() exist which are identical to ShallowCopy() and DeepCopy(),
/// except that instead of emitting an error for an incompatible structure,
/// the function returns false.  This allows you to programmatically check
/// structure compatibility without causing error messages.
///
/// To construct a graph, use vtkMutableDirectedGraph or
/// vtkMutableUndirectedGraph. You may then use CheckedShallowCopy
/// to set the contents of a mutable graph type into one of the non-mutable
/// types vtkDirectedGraph, vtkUndirectedGraph.
/// To construct a tree, use vtkMutableDirectedGraph, with directed edges
/// which point from the parent to the child, then use CheckedShallowCopy
/// to set the structure to a vtkTree.
///
/// @warning
/// All copy operations implement copy-on-write. The structures are initially
/// shared, but if one of the graphs is modified, the structure is copied
/// so that to the user they function as if they were deep copied. This means
/// that care must be taken if different threads are accessing different graph
/// instances that share the same structure. Race conditions may develop if
/// one thread is modifying the graph at the same time that another graph is
/// copying the structure.
///
/// @par Vertex pedigree IDs:
/// The vertices in a vtkGraph can be associated with pedigree IDs
/// through GetVertexData()-&gt;SetPedigreeIds. In this case, there is a
/// 1-1 mapping between pedigree Ids and vertices. One can query the
/// vertex ID based on the pedigree ID using FindVertex, add new
/// vertices by pedigree ID with AddVertex, and add edges based on the
/// pedigree IDs of the source and target vertices. For example,
/// AddEdge("Here", "There") will find (or add) vertices with pedigree
/// ID "Here" and "There" and then introduce an edge from "Here" to
/// "There".
///
/// @par Vertex pedigree IDs:
/// To configure the vtkGraph with a pedigree ID mapping, create a
/// vtkDataArray that will store the pedigree IDs and set that array as
/// the pedigree ID array for the vertices via
/// GetVertexData()-&gt;SetPedigreeIds().
///
///
/// @par Distributed graphs:
/// vtkGraph instances can be distributed across multiple machines, to
/// allow the construction and manipulation of graphs larger than a
/// single machine could handle. A distributed graph will typically be
/// distributed across many different nodes within a cluster, using the
/// Message Passing Interface (MPI) to allow those cluster nodes to
/// communicate.
///
/// @par Distributed graphs:
/// An empty vtkGraph can be made into a distributed graph by attaching
/// an instance of a vtkDistributedGraphHelper via the
/// SetDistributedGraphHelper() method. To determine whether a graph is
/// distributed or not, call GetDistributedGraphHelper() and check
/// whether the result is non-nullptr. For a distributed graph, the number
/// of processors across which the graph is distributed can be
/// retrieved by extracting the value for the DATA_NUMBER_OF_PIECES key
/// in the vtkInformation object (retrieved by GetInformation())
/// associated with the graph. Similarly, the value corresponding to
/// the DATA_PIECE_NUMBER key of the vtkInformation object describes
/// which piece of the data this graph instance provides.
///
/// @par Distributed graphs:
/// Distributed graphs behave somewhat differently from non-distributed
/// graphs, and will require special care. In a distributed graph, each
/// of the processors will contain a subset of the vertices in the
/// graph. That subset of vertices can be accessed via the
/// vtkVertexListIterator produced by GetVertices().
/// GetNumberOfVertices(), therefore, returns the number of vertices
/// stored locally: it does not account for vertices stored on other
/// processors. A vertex (or edge) is identified by both the rank of
/// its owning processor and by its index within that processor, both
/// of which are encoded within the vtkIdType value that describes that
/// vertex (or edge). The owning processor is a value between 0 and
/// P-1, where P is the number of processors across which the vtkGraph
/// has been distributed. The local index will be a value between 0 and
/// GetNumberOfVertices(), for vertices, or GetNumberOfEdges(), for
/// edges, and can be used to access the local parts of distributed
/// data arrays. When given a vtkIdType identifying a vertex, one can
/// determine the owner of the vertex with
/// vtkDistributedGraphHelper::GetVertexOwner() and the local index
/// with vtkDistributedGraphHelper::GetVertexIndex(). With edges, the
/// appropriate methods are vtkDistributedGraphHelper::GetEdgeOwner()
/// and vtkDistributedGraphHelper::GetEdgeIndex(), respectively. To
/// construct a vtkIdType representing either a vertex or edge given
/// only its owner and local index, use
/// vtkDistributedGraphHelper::MakeDistributedId().
///
/// @par Distributed graphs:
/// The edges in a distributed graph are always stored on the
/// processors that own the vertices named by the edge. For example,
/// given a directed edge (u, v), the edge will be stored in the
/// out-edges list for vertex u on the processor that owns u, and in
/// the in-edges list for vertex v on the processor that owns v. This
/// "row-wise" decomposition of the graph means that, for any vertex
/// that is local to a processor, that processor can look at all of the
/// incoming and outgoing edges of the graph. Processors cannot,
/// however, access the incoming or outgoing edge lists of vertex owned
/// by other processors. Vertices owned by other processors will not be
/// encountered when traversing the vertex list via GetVertices(), but
/// may be encountered by traversing the in- and out-edge lists of
/// local vertices or the edge list.
///
/// @par Distributed graphs:
/// Distributed graphs can have pedigree IDs for the vertices in the
/// same way that non-distributed graphs can. In this case, the
/// distribution of the vertices in the graph is based on pedigree
/// ID. For example, a vertex with the pedigree ID "Here" might land on
/// processor 0 while a vertex pedigree ID "There" would end up on
/// processor 3. By default, the pedigree IDs themselves are hashed to
/// give a random (and, hopefully, even) distribution of the
/// vertices. However, one can provide a different vertex distribution
/// function by calling
/// vtkDistributedGraphHelper::SetVertexPedigreeIdDistribution.  Once a
/// distributed graph has pedigree IDs, the no-argument AddVertex()
/// method can no longer be used. Additionally, once a vertex has a
/// pedigree ID, that pedigree ID should not be changed unless the user
/// can guarantee that the vertex distribution will still map that
/// vertex to the same processor where it already resides.
///
/// </remarks>
/// <seealso>
///
/// vtkDirectedGraph vtkUndirectedGraph vtkMutableDirectedGraph
/// vtkMutableUndirectedGraph vtkTree vtkDistributedGraphHelper
///
/// @par Thanks:
/// Thanks to Brian Wylie, Timothy Shead, Ken Moreland of Sandia National
/// Laboratories and Douglas Gregor of Indiana University for designing these
/// classes.
/// </seealso>
public abstract class vtkGraph : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraph()
	{
		MRClassNameKey = "class vtkGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_AddEdgePoint_01(HandleRef pThis, long e, IntPtr x);

	/// <summary>
	/// Adds a point to the end of the list of edge points for a certain edge.
	/// </summary>
	public void AddEdgePoint(long e, IntPtr x)
	{
		vtkGraph_AddEdgePoint_01(GetCppThis(), e, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_AddEdgePoint_02(HandleRef pThis, long e, double x, double y, double z);

	/// <summary>
	/// Adds a point to the end of the list of edge points for a certain edge.
	/// </summary>
	public void AddEdgePoint(long e, double x, double y, double z)
	{
		vtkGraph_AddEdgePoint_02(GetCppThis(), e, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraph_CheckedDeepCopy_03(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Performs the same operation as DeepCopy(),
	/// but instead of reporting an error for an incompatible graph,
	/// returns false.
	/// </summary>
	public virtual bool CheckedDeepCopy(vtkGraph g)
	{
		return (vtkGraph_CheckedDeepCopy_03(GetCppThis(), g?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraph_CheckedShallowCopy_04(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Performs the same operation as ShallowCopy(),
	/// but instead of reporting an error for an incompatible graph,
	/// returns false.
	/// </summary>
	public virtual bool CheckedShallowCopy(vtkGraph g)
	{
		return (vtkGraph_CheckedShallowCopy_04(GetCppThis(), g?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_ClearEdgePoints_05(HandleRef pThis, long e);

	/// <summary>
	/// Clear all points associated with an edge.
	/// </summary>
	public void ClearEdgePoints(long e)
	{
		vtkGraph_ClearEdgePoints_05(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_ComputeBounds_06(HandleRef pThis);

	/// <summary>
	/// Compute the bounds of the graph. In a distributed graph, this
	/// computes the bounds around the local part of the graph.
	/// </summary>
	public void ComputeBounds()
	{
		vtkGraph_ComputeBounds_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_CopyStructure_07(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Does a shallow copy of the topological information,
	/// but not the associated attributes.
	/// </summary>
	public virtual void CopyStructure(vtkGraph g)
	{
		vtkGraph_CopyStructure_07(GetCppThis(), g?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_DeepCopy_08(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Deep copies the data object into this graph.
	/// If it is an incompatible graph, reports an error.
	/// </summary>
	public override void DeepCopy(vtkDataObject obj)
	{
		vtkGraph_DeepCopy_08(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_DeepCopyEdgePoints_09(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Copy the internal edge point data from another graph into this graph.
	/// Both graphs must have the same number of edges.
	/// </summary>
	public void DeepCopyEdgePoints(vtkGraph g)
	{
		vtkGraph_DeepCopyEdgePoints_09(GetCppThis(), g?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_Dump_10(HandleRef pThis);

	/// <summary>
	/// Dump the contents of the graph to standard output.
	/// </summary>
	public void Dump()
	{
		vtkGraph_Dump_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_FindVertex_11(HandleRef pThis, HandleRef pedigreeID);

	/// <summary>
	/// Retrieve the vertex with the given pedigree ID. If successful,
	/// returns the ID of the vertex. Otherwise, either the vertex data
	/// does not have a pedigree ID array or there is no vertex with the
	/// given pedigree ID, so this function returns -1.
	/// If the graph is a distributed graph, this method will return the
	/// Distributed-ID of the vertex.
	/// </summary>
	public long FindVertex(vtkVariant pedigreeID)
	{
		return vtkGraph_FindVertex_11(GetCppThis(), pedigreeID?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkGraph_GetActualMemorySize_12(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated. The memory size
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to represent the data (e.g., extra space in
	/// arrays, etc. are not included in the return value).
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkGraph_GetActualMemorySize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetAdjacentVertices_13(HandleRef pThis, long v, HandleRef it);

	/// <summary>
	/// Initializes the adjacent vertex iterator to iterate over
	/// all outgoing vertices from vertex v.  For an undirected graph,
	/// returns all adjacent vertices. In a distributed graph, the vertex
	/// v must be local to this processor.
	/// </summary>
	public virtual void GetAdjacentVertices(long v, vtkAdjacentVertexIterator it)
	{
		vtkGraph_GetAdjacentVertices_13(GetCppThis(), v, it?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetAttributesAsFieldData_14(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the attributes of the data object as a vtkFieldData.
	/// This returns non-null values in all the same cases as GetAttributes,
	/// in addition to the case of FIELD, which will return the field data
	/// for any vtkDataObject subclass.
	/// </summary>
	public override vtkFieldData GetAttributesAsFieldData(int type)
	{
		vtkFieldData vtkFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_GetAttributesAsFieldData_14(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldData2 = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldData2.Register(null);
			}
		}
		return vtkFieldData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetBounds_15(HandleRef pThis);

	/// <summary>
	/// Return a pointer to the geometry bounding box in the form
	/// (xmin,xmax, ymin,ymax, zmin,zmax). In a distributed graph, this
	/// computes the bounds around the local part of the graph.
	/// </summary>
	public IntPtr GetBounds()
	{
		return vtkGraph_GetBounds_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetBounds_16(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return a pointer to the geometry bounding box in the form
	/// (xmin,xmax, ymin,ymax, zmin,zmax). In a distributed graph, this
	/// computes the bounds around the local part of the graph.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkGraph_GetBounds_16(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetData_17(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a graph from an information vector.
	/// </summary>
	public new static vtkGraph GetData(vtkInformation info)
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_GetData_17(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraph2 = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraph2.Register(null);
			}
		}
		return vtkGraph2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetData_18(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a graph from an information vector.
	/// </summary>
	public new static vtkGraph GetData(vtkInformationVector v, int i)
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_GetData_18(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraph2 = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraph2.Register(null);
			}
		}
		return vtkGraph2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraph_GetDataObjectType_19(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkGraph_GetDataObjectType_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetDegree_20(HandleRef pThis, long v);

	/// <summary>
	/// The total of all incoming and outgoing vertices for vertex v.
	/// For undirected graphs, this is simply the number of edges incident
	/// to v. In a distributed graph, the vertex v must be local to this
	/// processor.
	/// </summary>
	public virtual long GetDegree(long v)
	{
		return vtkGraph_GetDegree_20(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetDistributedGraphHelper_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieves the distributed graph helper for this graph
	/// </summary>
	public vtkDistributedGraphHelper GetDistributedGraphHelper()
	{
		vtkDistributedGraphHelper vtkDistributedGraphHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_GetDistributedGraphHelper_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistributedGraphHelper2 = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistributedGraphHelper2.Register(null);
			}
		}
		return vtkDistributedGraphHelper2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetEdgeData_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vertex or edge data.
	/// </summary>
	public virtual vtkDataSetAttributes GetEdgeData()
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_GetEdgeData_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetAttributes2 = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetAttributes2.Register(null);
			}
		}
		return vtkDataSetAttributes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetEdgeId_23(HandleRef pThis, long a, long b);

	/// <summary>
	/// Returns the Id of the edge between vertex a and vertex b.
	/// This is independent of directionality of the edge, that is,
	/// if edge A-&gt;B exists or if edge B-&gt;A exists, this function will
	/// return its Id. If multiple edges exist between a and b, here is no guarantee
	/// about which one will be returned.
	/// Returns -1 if no edge exists between a and b.
	/// </summary>
	public long GetEdgeId(long a, long b)
	{
		return vtkGraph_GetEdgeId_23(GetCppThis(), a, b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetEdgePoint_24(HandleRef pThis, long e, long i);

	/// <summary>
	/// Get the x,y,z location of a point along edge e.
	/// </summary>
	public double[] GetEdgePoint(long e, long i)
	{
		IntPtr intPtr = vtkGraph_GetEdgePoint_24(GetCppThis(), e, i);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetEdges_25(HandleRef pThis, HandleRef it);

	/// <summary>
	/// Initializes the edge list iterator to iterate over all
	/// edges in the graph. Edges may not be traversed in order of
	/// increasing edge id. In a distributed graph, this returns edges
	/// that are stored locally.
	/// </summary>
	public virtual void GetEdges(vtkEdgeListIterator it)
	{
		vtkGraph_GetEdges_25(GetCppThis(), it?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetGraphInternals_26(HandleRef pThis, byte modifying, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the internal representation of the graph. If modifying is
	/// true, then the returned vtkGraphInternals object will be unique to
	/// this vtkGraph object.
	/// </summary>
	public vtkGraphInternals GetGraphInternals(bool modifying)
	{
		vtkGraphInternals vtkGraphInternals2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_GetGraphInternals_26(GetCppThis(), (byte)(modifying ? 1u : 0u), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphInternals2 = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphInternals2.Register(null);
			}
		}
		return vtkGraphInternals2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetInDegree_27(HandleRef pThis, long v);

	/// <summary>
	/// The number of incoming edges to vertex v.
	/// For undirected graphs, returns the same as GetDegree(). In a
	/// distributed graph, the vertex v must be local to this processor.
	/// </summary>
	public virtual long GetInDegree(long v)
	{
		return vtkGraph_GetInDegree_27(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetInEdge_28(HandleRef pThis, long v, long index, HandleRef e);

	/// <summary>
	/// Random-access method for retrieving incoming edges to vertex v.
	/// The method fills the vtkGraphEdge instance with the id, source, and
	/// target of the edge. This method is provided for wrappers,
	/// GetInEdge(vtkIdType, vtkIdType) is preferred.
	/// </summary>
	public virtual void GetInEdge(long v, long index, vtkGraphEdge e)
	{
		vtkGraph_GetInEdge_28(GetCppThis(), v, index, e?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetInEdges_29(HandleRef pThis, long v, HandleRef it);

	/// <summary>
	/// Initializes the in edge iterator to iterate over
	/// all incoming edges to vertex v.  For an undirected graph,
	/// returns all incident edges. In a distributed graph, the vertex
	/// v must be local to this processor.
	/// </summary>
	public virtual void GetInEdges(long v, vtkInEdgeIterator it)
	{
		vtkGraph_GetInEdges_29(GetCppThis(), v, it?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetInducedEdges_30(HandleRef pThis, HandleRef verts, HandleRef edges);

	/// <summary>
	/// Fills a list of edge indices with the edges contained in the induced
	/// subgraph formed by the vertices in the vertex list.
	/// </summary>
	public void GetInducedEdges(vtkIdTypeArray verts, vtkIdTypeArray edges)
	{
		vtkGraph_GetInducedEdges_30(GetCppThis(), verts?.GetCppThis() ?? default(HandleRef), edges?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGraph_GetMTime_31(HandleRef pThis);

	/// <summary>
	/// The modified time of the graph.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGraph_GetMTime_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetNumberOfEdgePoints_32(HandleRef pThis, long e);

	/// <summary>
	/// Get the number of edge points associated with an edge.
	/// </summary>
	public long GetNumberOfEdgePoints(long e)
	{
		return vtkGraph_GetNumberOfEdgePoints_32(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetNumberOfEdges_33(HandleRef pThis);

	/// <summary>
	/// The number of edges in the graph. In a distributed graph,
	/// this returns the number of edges stored locally.
	/// </summary>
	public virtual long GetNumberOfEdges()
	{
		return vtkGraph_GetNumberOfEdges_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetNumberOfElements_34(HandleRef pThis, int type);

	/// <summary>
	/// Get the number of elements for a specific attribute type (VERTEX, EDGE, etc.).
	/// </summary>
	public override long GetNumberOfElements(int type)
	{
		return vtkGraph_GetNumberOfElements_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetNumberOfGenerationsFromBase_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraph_GetNumberOfGenerationsFromBase_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetNumberOfGenerationsFromBaseType_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraph_GetNumberOfGenerationsFromBaseType_36(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetNumberOfVertices_37(HandleRef pThis);

	/// <summary>
	/// The number of vertices in the graph. In a distributed graph,
	/// returns the number of local vertices in the graph.
	/// </summary>
	public virtual long GetNumberOfVertices()
	{
		return vtkGraph_GetNumberOfVertices_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetOutDegree_38(HandleRef pThis, long v);

	/// <summary>
	/// The number of outgoing edges from vertex v.
	/// For undirected graphs, returns the same as GetDegree(). In a
	/// distributed graph, the vertex v must be local to this processor.
	/// </summary>
	public virtual long GetOutDegree(long v)
	{
		return vtkGraph_GetOutDegree_38(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetOutEdge_39(HandleRef pThis, long v, long index, HandleRef e);

	/// <summary>
	/// Random-access method for retrieving outgoing edges from vertex v.
	/// The method fills the vtkGraphEdge instance with the id, source, and
	/// target of the edge. This method is provided for wrappers,
	/// GetOutEdge(vtkIdType, vtkIdType) is preferred.
	/// </summary>
	public virtual void GetOutEdge(long v, long index, vtkGraphEdge e)
	{
		vtkGraph_GetOutEdge_39(GetCppThis(), v, index, e?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetOutEdges_40(HandleRef pThis, long v, HandleRef it);

	/// <summary>
	/// Initializes the out edge iterator to iterate over
	/// all outgoing edges of vertex v.  For an undirected graph,
	/// returns all incident edges. In a distributed graph, the vertex
	/// v must be local to this processor.
	/// </summary>
	public virtual void GetOutEdges(long v, vtkOutEdgeIterator it)
	{
		vtkGraph_GetOutEdges_40(GetCppThis(), v, it?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetPoint_41(HandleRef pThis, long ptId);

	/// <summary>
	/// These methods return the point (0,0,0) until the points structure
	/// is created, when it returns the actual point position. In a
	/// distributed graph, only the points for local vertices can be
	/// retrieved.
	/// </summary>
	public IntPtr GetPoint(long ptId)
	{
		return vtkGraph_GetPoint_41(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetPoint_42(HandleRef pThis, long ptId, IntPtr x);

	/// <summary>
	/// These methods return the point (0,0,0) until the points structure
	/// is created, when it returns the actual point position. In a
	/// distributed graph, only the points for local vertices can be
	/// retrieved.
	/// </summary>
	public void GetPoint(long ptId, IntPtr x)
	{
		vtkGraph_GetPoint_42(GetCppThis(), ptId, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetPoints_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the points array for this graph.
	/// If points is not yet constructed, generates and returns
	/// a new points array filled with (0,0,0) coordinates. In a
	/// distributed graph, only the points for local vertices can be
	/// retrieved or modified.
	/// </summary>
	public vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_GetPoints_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetSourceVertex_44(HandleRef pThis, long e);

	/// <summary>
	/// Retrieve the source and target vertices for an edge id.
	/// NOTE: The first time this is called, the graph will build
	/// a mapping array from edge id to source/target that is the
	/// same size as the number of edges in the graph. If you have
	/// access to a vtkOutEdgeType, vtkInEdgeType, vtkEdgeType, or
	/// vtkGraphEdge, you should directly use these structures
	/// to look up the source or target instead of this method.
	/// </summary>
	public long GetSourceVertex(long e)
	{
		return vtkGraph_GetSourceVertex_44(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraph_GetTargetVertex_45(HandleRef pThis, long e);

	/// <summary>
	/// Retrieve the source and target vertices for an edge id.
	/// NOTE: The first time this is called, the graph will build
	/// a mapping array from edge id to source/target that is the
	/// same size as the number of edges in the graph. If you have
	/// access to a vtkOutEdgeType, vtkInEdgeType, vtkEdgeType, or
	/// vtkGraphEdge, you should directly use these structures
	/// to look up the source or target instead of this method.
	/// </summary>
	public long GetTargetVertex(long e)
	{
		return vtkGraph_GetTargetVertex_45(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_GetVertexData_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vertex or edge data.
	/// </summary>
	public virtual vtkDataSetAttributes GetVertexData()
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_GetVertexData_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetAttributes2 = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetAttributes2.Register(null);
			}
		}
		return vtkDataSetAttributes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_GetVertices_47(HandleRef pThis, HandleRef it);

	/// <summary>
	/// Initializes the vertex list iterator to iterate over all
	/// vertices in the graph. In a distributed graph, the iterator
	/// traverses all local vertices.
	/// </summary>
	public virtual void GetVertices(vtkVertexListIterator it)
	{
		vtkGraph_GetVertices_47(GetCppThis(), it?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_Initialize_48(HandleRef pThis);

	/// <summary>
	/// Initialize to an empty graph.
	/// </summary>
	public override void Initialize()
	{
		vtkGraph_Initialize_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraph_IsA_49(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraph_IsA_49(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraph_IsSameStructure_50(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Returns true if both graphs point to the same adjacency structure.
	/// Can be used to test the copy-on-write feature of the graph.
	/// </summary>
	public bool IsSameStructure(vtkGraph other)
	{
		return (vtkGraph_IsSameStructure_50(GetCppThis(), other?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraph_IsTypeOf_51(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraph_IsTypeOf_51(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_NewInstance_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraph NewInstance()
	{
		vtkGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_NewInstance_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_ReorderOutVertices_53(HandleRef pThis, long v, HandleRef vertices);

	/// <summary>
	/// Reorder the outgoing vertices of a vertex.
	/// The vertex list must have the same elements as the current out edge
	/// list, just in a different order.
	/// This method does not change the topology of the graph.
	/// In a distributed graph, the vertex v must be local.
	/// </summary>
	public void ReorderOutVertices(long v, vtkIdTypeArray vertices)
	{
		vtkGraph_ReorderOutVertices_53(GetCppThis(), v, vertices?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraph_SafeDownCast_54(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraph SafeDownCast(vtkObjectBase o)
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraph_SafeDownCast_54(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraph2 = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraph2.Register(null);
			}
		}
		return vtkGraph2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_SetDistributedGraphHelper_55(HandleRef pThis, HandleRef helper);

	/// <summary>
	/// Sets the distributed graph helper of this graph, turning it into a
	/// distributed graph. This operation can only be executed on an empty
	/// graph.
	/// </summary>
	public void SetDistributedGraphHelper(vtkDistributedGraphHelper helper)
	{
		vtkGraph_SetDistributedGraphHelper_55(GetCppThis(), helper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_SetEdgePoint_56(HandleRef pThis, long e, long i, IntPtr x);

	/// <summary>
	/// Set an x,y,z location of a point along an edge.
	/// This assumes there is already a point at location i, and simply
	/// overwrites it.
	/// </summary>
	public void SetEdgePoint(long e, long i, IntPtr x)
	{
		vtkGraph_SetEdgePoint_56(GetCppThis(), e, i, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_SetEdgePoint_57(HandleRef pThis, long e, long i, double x, double y, double z);

	/// <summary>
	/// Set an x,y,z location of a point along an edge.
	/// This assumes there is already a point at location i, and simply
	/// overwrites it.
	/// </summary>
	public void SetEdgePoint(long e, long i, double x, double y, double z)
	{
		vtkGraph_SetEdgePoint_57(GetCppThis(), e, i, x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_SetEdgePoints_58(HandleRef pThis, long e, long npts, IntPtr pts);

	/// <summary>
	/// Get/Set the internal edge control points associated with each edge.
	/// The size of the pts array is 3*npts, and holds the x,y,z
	/// location of each edge control point.
	/// </summary>
	public void SetEdgePoints(long e, long npts, IntPtr pts)
	{
		vtkGraph_SetEdgePoints_58(GetCppThis(), e, npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_SetPoints_59(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Returns the points array for this graph.
	/// If points is not yet constructed, generates and returns
	/// a new points array filled with (0,0,0) coordinates. In a
	/// distributed graph, only the points for local vertices can be
	/// retrieved or modified.
	/// </summary>
	public virtual void SetPoints(vtkPoints points)
	{
		vtkGraph_SetPoints_59(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_ShallowCopy_60(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Shallow copies the data object into this graph.
	/// If it is an incompatible graph, reports an error.
	/// </summary>
	public override void ShallowCopy(vtkDataObject obj)
	{
		vtkGraph_ShallowCopy_60(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_ShallowCopyEdgePoints_61(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Copy the internal edge point data from another graph into this graph.
	/// Both graphs must have the same number of edges.
	/// </summary>
	public void ShallowCopyEdgePoints(vtkGraph g)
	{
		vtkGraph_ShallowCopyEdgePoints_61(GetCppThis(), g?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraph_Squeeze_62(HandleRef pThis);

	/// <summary>
	/// Reclaim unused memory.
	/// </summary>
	public virtual void Squeeze()
	{
		vtkGraph_Squeeze_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraph_ToDirectedGraph_63(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Convert the graph to a directed graph.
	/// </summary>
	public bool ToDirectedGraph(vtkDirectedGraph g)
	{
		return (vtkGraph_ToDirectedGraph_63(GetCppThis(), g?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraph_ToUndirectedGraph_64(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Convert the graph to an undirected graph.
	/// </summary>
	public bool ToUndirectedGraph(vtkUndirectedGraph g)
	{
		return (vtkGraph_ToUndirectedGraph_64(GetCppThis(), g?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}
}
