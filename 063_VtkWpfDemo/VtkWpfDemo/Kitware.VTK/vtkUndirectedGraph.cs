using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUndirectedGraph
/// </summary>
/// <remarks>
///    An undirected graph.
///
///
/// vtkUndirectedGraph is a collection of vertices along with a collection of
/// undirected edges (they connect two vertices in no particular order).
/// ShallowCopy(), DeepCopy(), CheckedShallowCopy(), CheckedDeepCopy()
/// accept instances of vtkUndirectedGraph and vtkMutableUndirectedGraph.
/// GetOutEdges(v, it) and GetInEdges(v, it) return the same list of edges,
/// which is the list of all edges which have a v as an endpoint.
/// GetInDegree(v), GetOutDegree(v) and GetDegree(v) all return the full
/// degree of vertex v.
///
/// vtkUndirectedGraph is read-only. To create an undirected graph,
/// use an instance of vtkMutableUndirectedGraph, then you may set the
/// structure to a vtkUndirectedGraph using ShallowCopy().
///
/// </remarks>
/// <seealso>
///
/// vtkGraph vtkMutableUndirectedGraph
/// </seealso>
public class vtkUndirectedGraph : vtkGraph
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUndirectedGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUndirectedGraph()
	{
		MRClassNameKey = "class vtkUndirectedGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUndirectedGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUndirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUndirectedGraph New()
	{
		vtkUndirectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUndirectedGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUndirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkUndirectedGraph_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a graph from an information vector.
	/// </summary>
	public new static vtkUndirectedGraph GetData(vtkInformation info)
	{
		vtkUndirectedGraph vtkUndirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraph_GetData_01(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUndirectedGraph2 = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUndirectedGraph2.Register(null);
			}
		}
		return vtkUndirectedGraph2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraph_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a graph from an information vector.
	/// </summary>
	public new static vtkUndirectedGraph GetData(vtkInformationVector v, int i)
	{
		vtkUndirectedGraph vtkUndirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraph_GetData_02(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUndirectedGraph2 = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUndirectedGraph2.Register(null);
			}
		}
		return vtkUndirectedGraph2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUndirectedGraph_GetDataObjectType_03(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkUndirectedGraph_GetDataObjectType_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUndirectedGraph_GetInDegree_04(HandleRef pThis, long v);

	/// <summary>
	/// Returns the full degree of the vertex.
	/// </summary>
	public override long GetInDegree(long v)
	{
		return vtkUndirectedGraph_GetInDegree_04(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUndirectedGraph_GetInEdge_05(HandleRef pThis, long v, long i, HandleRef e);

	/// <summary>
	/// Random-access method for retrieving incoming edges to vertex v.
	/// The method fills the vtkGraphEdge instance with the id, source, and
	/// target of the edge. This method is provided for wrappers,
	/// GetInEdge(vtkIdType, vtkIdType) is preferred.
	/// </summary>
	public override void GetInEdge(long v, long i, vtkGraphEdge e)
	{
		vtkUndirectedGraph_GetInEdge_05(GetCppThis(), v, i, e?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUndirectedGraph_GetInEdges_06(HandleRef pThis, long v, HandleRef it);

	/// <summary>
	/// Initialize the iterator to get the incoming edges to a vertex.
	/// For an undirected graph, this is all incident edges.
	/// </summary>
	public override void GetInEdges(long v, vtkInEdgeIterator it)
	{
		vtkUndirectedGraph_GetInEdges_06(GetCppThis(), v, it?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUndirectedGraph_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUndirectedGraph_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUndirectedGraph_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUndirectedGraph_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUndirectedGraph_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUndirectedGraph_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUndirectedGraph_IsStructureValid_10(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Check the structure, and accept it if it is a valid
	/// undirected graph. This is public to allow
	/// the ToDirected/UndirectedGraph to work.
	/// </summary>
	public virtual bool IsStructureValid(vtkGraph g)
	{
		return (vtkUndirectedGraph_IsStructureValid_10(GetCppThis(), g?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUndirectedGraph_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUndirectedGraph_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraph_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUndirectedGraph NewInstance()
	{
		vtkUndirectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraph_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUndirectedGraph_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUndirectedGraph SafeDownCast(vtkObjectBase o)
	{
		vtkUndirectedGraph vtkUndirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUndirectedGraph_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUndirectedGraph2 = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUndirectedGraph2.Register(null);
			}
		}
		return vtkUndirectedGraph2;
	}
}
