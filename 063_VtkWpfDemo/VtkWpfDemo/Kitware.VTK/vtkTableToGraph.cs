using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTableToGraph
/// </summary>
/// <remarks>
///    convert a vtkTable into a vtkGraph
///
///
/// vtkTableToGraph converts a table to a graph using an auxiliary
/// link graph.  The link graph specifies how each row in the table
/// should be converted to an edge, or a collection of edges.  It also
/// specifies which columns of the table should be considered part of
/// the same domain, and which columns should be hidden.
///
/// A second, optional, table may be provided as the vertex table.
/// This vertex table must have one or more domain columns whose values
/// match values in the edge table.  The linked column name is specified in
/// the domain array in the link graph.  The output graph will only contain
/// vertices corresponding to a row in the vertex table.  For heterogeneous
/// graphs, you may want to use vtkMergeTables to create a single vertex table.
///
/// The link graph contains the following arrays:
///
/// (1) The "column" array has the names of the columns to connect in each table row.
/// This array is required.
///
/// (2) The optional "domain" array provides user-defined domain names for each column.
/// Matching domains in multiple columns will merge vertices with the same
/// value from those columns.  By default, all columns are in the same domain.
/// If a vertex table is supplied, the domain indicates the column in the vertex
/// table that the edge table column associates with.  If the user provides a
/// vertex table but no domain names, the output will be an empty graph.
/// Hidden columns do not need valid domain names.
///
/// (3) The optional "hidden" array is a bit array specifying whether the column should be
/// hidden.  The resulting graph will contain edges representing connections
/// "through" the hidden column, but the vertices for that column will not
/// be present.  By default, no columns are hidden.  Hiding a column
/// in a particular domain hides all columns in that domain.
///
/// The output graph will contain three additional arrays in the vertex data.
/// The "domain" column is a string array containing the domain of each vertex.
/// The "label" column is a string version of the distinct value that, along
/// with the domain, defines that vertex. The "ids" column also contains
/// the distinguishing value, but as a vtkVariant holding the raw value instead
/// of being converted to a string. The "ids" column is set as the vertex pedigree
/// ID attribute.
/// </remarks>
public class vtkTableToGraph : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTableToGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTableToGraph()
	{
		MRClassNameKey = "class vtkTableToGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTableToGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableToGraph New()
	{
		vtkTableToGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTableToGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTableToGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTableToGraph_AddLinkEdge_01(HandleRef pThis, string column1, string column2);

	/// <summary>
	/// Add an edge to the link graph.  Specify the names of the columns to link.
	/// </summary>
	public void AddLinkEdge(string column1, string column2)
	{
		vtkTableToGraph_AddLinkEdge_01(GetCppThis(), column1, column2);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_AddLinkVertex_02(HandleRef pThis, string column, string domain, int hidden);

	/// <summary>
	/// Add a vertex to the link graph.  Specify the column name, the domain name
	/// for the column, and whether the column is hidden.
	/// </summary>
	public void AddLinkVertex(string column, string domain, int hidden)
	{
		vtkTableToGraph_AddLinkVertex_02(GetCppThis(), column, domain, hidden);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_ClearLinkEdges_03(HandleRef pThis);

	/// <summary>
	/// Clear the link graph edges.  The graph vertices will remain.
	/// </summary>
	public void ClearLinkEdges()
	{
		vtkTableToGraph_ClearLinkEdges_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_ClearLinkVertices_04(HandleRef pThis);

	/// <summary>
	/// Clear the link graph vertices.  This also clears all edges.
	/// </summary>
	public void ClearLinkVertices()
	{
		vtkTableToGraph_ClearLinkVertices_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_DirectedOff_05(HandleRef pThis);

	/// <summary>
	/// Specify the directedness of the output graph.
	/// </summary>
	public virtual void DirectedOff()
	{
		vtkTableToGraph_DirectedOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_DirectedOn_06(HandleRef pThis);

	/// <summary>
	/// Specify the directedness of the output graph.
	/// </summary>
	public virtual void DirectedOn()
	{
		vtkTableToGraph_DirectedOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTableToGraph_GetDirected_07(HandleRef pThis);

	/// <summary>
	/// Specify the directedness of the output graph.
	/// </summary>
	public virtual bool GetDirected()
	{
		return (vtkTableToGraph_GetDirected_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToGraph_GetLinkGraph_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The graph describing how to link the columns in the table.
	/// </summary>
	public virtual vtkMutableDirectedGraph GetLinkGraph()
	{
		vtkMutableDirectedGraph vtkMutableDirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToGraph_GetLinkGraph_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkTableToGraph_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// Get the current modified time.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkTableToGraph_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableToGraph_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTableToGraph_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTableToGraph_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTableToGraph_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToGraph_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTableToGraph_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTableToGraph_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTableToGraph_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_LinkColumnPath_14(HandleRef pThis, HandleRef column, HandleRef domain, HandleRef hidden);

	/// <summary>
	/// Links the columns in a specific order.
	/// This creates a simple path as the link graph.
	/// </summary>
	public void LinkColumnPath(vtkStringArray column, vtkStringArray domain, vtkBitArray hidden)
	{
		vtkTableToGraph_LinkColumnPath_14(GetCppThis(), column?.GetCppThis() ?? default(HandleRef), domain?.GetCppThis() ?? default(HandleRef), hidden?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToGraph_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTableToGraph NewInstance()
	{
		vtkTableToGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToGraph_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTableToGraph_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTableToGraph SafeDownCast(vtkObjectBase o)
	{
		vtkTableToGraph vtkTableToGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTableToGraph_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTableToGraph2 = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTableToGraph2.Register(null);
			}
		}
		return vtkTableToGraph2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_SetDirected_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify the directedness of the output graph.
	/// </summary>
	public virtual void SetDirected(bool _arg)
	{
		vtkTableToGraph_SetDirected_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_SetLinkGraph_19(HandleRef pThis, HandleRef g);

	/// <summary>
	/// The graph describing how to link the columns in the table.
	/// </summary>
	public void SetLinkGraph(vtkMutableDirectedGraph g)
	{
		vtkTableToGraph_SetLinkGraph_19(GetCppThis(), g?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTableToGraph_SetVertexTableConnection_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method for setting the vertex table input.  This
	/// is mainly for the benefit of the VTK client/server layer,
	/// vanilla VTK code should use e.g:
	///
	/// table_to_graph-&gt;SetInputConnection(1, vertex_table-&gt;output());
	/// </summary>
	public void SetVertexTableConnection(vtkAlgorithmOutput arg0)
	{
		vtkTableToGraph_SetVertexTableConnection_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
