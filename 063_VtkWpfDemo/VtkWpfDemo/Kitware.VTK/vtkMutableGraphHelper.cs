using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMutableGraphHelper
/// </summary>
/// <remarks>
///    Helper class for building a directed or
///   directed graph
///
///
/// vtkMutableGraphHelper has helper methods AddVertex and AddEdge which
/// add vertices/edges to the underlying mutable graph. This is helpful in
/// filters which need to (re)construct graphs which may be either directed
/// or undirected.
///
/// </remarks>
/// <seealso>
///
/// vtkGraph vtkMutableDirectedGraph vtkMutableUndirectedGraph
/// </seealso>
public class vtkMutableGraphHelper : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMutableGraphHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMutableGraphHelper()
	{
		MRClassNameKey = "class vtkMutableGraphHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableGraphHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMutableGraphHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableGraphHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMutableGraphHelper New()
	{
		vtkMutableGraphHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableGraphHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMutableGraphHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMutableGraphHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableGraphHelper_AddGraphEdge_01(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add an edge to the underlying mutable graph.
	/// </summary>
	public vtkGraphEdge AddGraphEdge(long u, long v)
	{
		vtkGraphEdge vtkGraphEdge2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableGraphHelper_AddGraphEdge_01(GetCppThis(), u, v, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableGraphHelper_AddVertex_02(HandleRef pThis);

	/// <summary>
	/// Add a vertex to the underlying mutable graph.
	/// </summary>
	public long AddVertex()
	{
		return vtkMutableGraphHelper_AddVertex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableGraphHelper_GetGraph_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the underlying graph that you want to modify with this helper.
	/// The graph must be an instance of vtkMutableDirectedGraph or
	/// vtkMutableUndirectedGraph.
	/// </summary>
	public vtkGraph GetGraph()
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableGraphHelper_GetGraph_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableGraphHelper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMutableGraphHelper_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMutableGraphHelper_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMutableGraphHelper_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMutableGraphHelper_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMutableGraphHelper_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMutableGraphHelper_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMutableGraphHelper_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableGraphHelper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMutableGraphHelper NewInstance()
	{
		vtkMutableGraphHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableGraphHelper_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableGraphHelper_RemoveEdge_10(HandleRef pThis, long e);

	/// <summary>
	/// Remove an edge from the underlying mutable graph.
	/// </summary>
	public void RemoveEdge(long e)
	{
		vtkMutableGraphHelper_RemoveEdge_10(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableGraphHelper_RemoveEdges_11(HandleRef pThis, HandleRef edges);

	/// <summary>
	/// Remove a collection of edges from the underlying mutable graph.
	/// </summary>
	public void RemoveEdges(vtkIdTypeArray edges)
	{
		vtkMutableGraphHelper_RemoveEdges_11(GetCppThis(), edges?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableGraphHelper_RemoveVertex_12(HandleRef pThis, long v);

	/// <summary>
	/// Remove a vertex from the underlying mutable graph.
	/// </summary>
	public void RemoveVertex(long v)
	{
		vtkMutableGraphHelper_RemoveVertex_12(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableGraphHelper_RemoveVertices_13(HandleRef pThis, HandleRef verts);

	/// <summary>
	/// Remove a collection of vertices from the underlying mutable graph.
	/// </summary>
	public void RemoveVertices(vtkIdTypeArray verts)
	{
		vtkMutableGraphHelper_RemoveVertices_13(GetCppThis(), verts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMutableGraphHelper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMutableGraphHelper SafeDownCast(vtkObjectBase o)
	{
		vtkMutableGraphHelper vtkMutableGraphHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMutableGraphHelper_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMutableGraphHelper2 = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMutableGraphHelper2.Register(null);
			}
		}
		return vtkMutableGraphHelper2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMutableGraphHelper_SetGraph_15(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Set the underlying graph that you want to modify with this helper.
	/// The graph must be an instance of vtkMutableDirectedGraph or
	/// vtkMutableUndirectedGraph.
	/// </summary>
	public void SetGraph(vtkGraph g)
	{
		vtkMutableGraphHelper_SetGraph_15(GetCppThis(), g?.GetCppThis() ?? default(HandleRef));
	}
}
