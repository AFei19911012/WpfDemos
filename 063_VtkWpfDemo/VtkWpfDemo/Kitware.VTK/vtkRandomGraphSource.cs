using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRandomGraphSource
/// </summary>
/// <remarks>
///    a graph with random edges
///
///
/// Generates a graph with a specified number of vertices, with the density of
/// edges specified by either an exact number of edges or the probability of
/// an edge.  You may additionally specify whether to begin with a random
/// tree (which enforces graph connectivity).
///
/// </remarks>
public class vtkRandomGraphSource : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRandomGraphSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRandomGraphSource()
	{
		MRClassNameKey = "class vtkRandomGraphSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomGraphSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRandomGraphSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomGraphSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRandomGraphSource New()
	{
		vtkRandomGraphSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomGraphSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRandomGraphSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRandomGraphSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRandomGraphSource_AllowParallelEdgesOff_01(HandleRef pThis);

	/// <summary>
	/// When set, multiple edges from a source to a target vertex are
	/// allowed. The default is to forbid such loops.
	/// </summary>
	public virtual void AllowParallelEdgesOff()
	{
		vtkRandomGraphSource_AllowParallelEdgesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_AllowParallelEdgesOn_02(HandleRef pThis);

	/// <summary>
	/// When set, multiple edges from a source to a target vertex are
	/// allowed. The default is to forbid such loops.
	/// </summary>
	public virtual void AllowParallelEdgesOn()
	{
		vtkRandomGraphSource_AllowParallelEdgesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_AllowSelfLoopsOff_03(HandleRef pThis);

	/// <summary>
	/// If this flag is set to true, edges where the source and target
	/// vertex are the same can be generated.  The default is to forbid
	/// such loops.
	/// </summary>
	public virtual void AllowSelfLoopsOff()
	{
		vtkRandomGraphSource_AllowSelfLoopsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_AllowSelfLoopsOn_04(HandleRef pThis);

	/// <summary>
	/// If this flag is set to true, edges where the source and target
	/// vertex are the same can be generated.  The default is to forbid
	/// such loops.
	/// </summary>
	public virtual void AllowSelfLoopsOn()
	{
		vtkRandomGraphSource_AllowSelfLoopsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_DirectedOff_05(HandleRef pThis);

	/// <summary>
	/// When set, creates a directed graph, as opposed to an undirected graph.
	/// </summary>
	public virtual void DirectedOff()
	{
		vtkRandomGraphSource_DirectedOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_DirectedOn_06(HandleRef pThis);

	/// <summary>
	/// When set, creates a directed graph, as opposed to an undirected graph.
	/// </summary>
	public virtual void DirectedOn()
	{
		vtkRandomGraphSource_DirectedOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_GeneratePedigreeIdsOff_07(HandleRef pThis);

	/// <summary>
	/// Add pedigree ids to vertex and edge data.
	/// </summary>
	public virtual void GeneratePedigreeIdsOff()
	{
		vtkRandomGraphSource_GeneratePedigreeIdsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_GeneratePedigreeIdsOn_08(HandleRef pThis);

	/// <summary>
	/// Add pedigree ids to vertex and edge data.
	/// </summary>
	public virtual void GeneratePedigreeIdsOn()
	{
		vtkRandomGraphSource_GeneratePedigreeIdsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRandomGraphSource_GetAllowParallelEdges_09(HandleRef pThis);

	/// <summary>
	/// When set, multiple edges from a source to a target vertex are
	/// allowed. The default is to forbid such loops.
	/// </summary>
	public virtual bool GetAllowParallelEdges()
	{
		return (vtkRandomGraphSource_GetAllowParallelEdges_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRandomGraphSource_GetAllowSelfLoops_10(HandleRef pThis);

	/// <summary>
	/// If this flag is set to true, edges where the source and target
	/// vertex are the same can be generated.  The default is to forbid
	/// such loops.
	/// </summary>
	public virtual bool GetAllowSelfLoops()
	{
		return (vtkRandomGraphSource_GetAllowSelfLoops_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRandomGraphSource_GetDirected_11(HandleRef pThis);

	/// <summary>
	/// When set, creates a directed graph, as opposed to an undirected graph.
	/// </summary>
	public virtual bool GetDirected()
	{
		return (vtkRandomGraphSource_GetDirected_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomGraphSource_GetEdgePedigreeIdArrayName_12(HandleRef pThis);

	/// <summary>
	/// The name of the edge pedigree id array. Default "edge id".
	/// </summary>
	public virtual string GetEdgePedigreeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRandomGraphSource_GetEdgePedigreeIdArrayName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRandomGraphSource_GetEdgeProbability_13(HandleRef pThis);

	/// <summary>
	/// If UseEdgeProbability is on, adds an edge with this probability between 0 and 1
	/// for each pair of vertices in the graph.
	/// </summary>
	public virtual double GetEdgeProbability()
	{
		return vtkRandomGraphSource_GetEdgeProbability_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRandomGraphSource_GetEdgeProbabilityMaxValue_14(HandleRef pThis);

	/// <summary>
	/// If UseEdgeProbability is on, adds an edge with this probability between 0 and 1
	/// for each pair of vertices in the graph.
	/// </summary>
	public virtual double GetEdgeProbabilityMaxValue()
	{
		return vtkRandomGraphSource_GetEdgeProbabilityMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRandomGraphSource_GetEdgeProbabilityMinValue_15(HandleRef pThis);

	/// <summary>
	/// If UseEdgeProbability is on, adds an edge with this probability between 0 and 1
	/// for each pair of vertices in the graph.
	/// </summary>
	public virtual double GetEdgeProbabilityMinValue()
	{
		return vtkRandomGraphSource_GetEdgeProbabilityMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomGraphSource_GetEdgeWeightArrayName_16(HandleRef pThis);

	/// <summary>
	/// The name of the edge weight array. Default "edge weight".
	/// </summary>
	public virtual string GetEdgeWeightArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRandomGraphSource_GetEdgeWeightArrayName_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRandomGraphSource_GetGeneratePedigreeIds_17(HandleRef pThis);

	/// <summary>
	/// Add pedigree ids to vertex and edge data.
	/// </summary>
	public virtual bool GetGeneratePedigreeIds()
	{
		return (vtkRandomGraphSource_GetGeneratePedigreeIds_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRandomGraphSource_GetIncludeEdgeWeights_18(HandleRef pThis);

	/// <summary>
	/// When set, includes edge weights in an array named "edge_weights".
	/// Defaults to off.  Weights are random between 0 and 1.
	/// </summary>
	public virtual bool GetIncludeEdgeWeights()
	{
		return (vtkRandomGraphSource_GetIncludeEdgeWeights_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_GetNumberOfEdges_19(HandleRef pThis);

	/// <summary>
	/// If UseEdgeProbability is off, creates a graph with the specified number
	/// of edges.  Duplicate (parallel) edges are allowed.
	/// </summary>
	public virtual int GetNumberOfEdges()
	{
		return vtkRandomGraphSource_GetNumberOfEdges_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_GetNumberOfEdgesMaxValue_20(HandleRef pThis);

	/// <summary>
	/// If UseEdgeProbability is off, creates a graph with the specified number
	/// of edges.  Duplicate (parallel) edges are allowed.
	/// </summary>
	public virtual int GetNumberOfEdgesMaxValue()
	{
		return vtkRandomGraphSource_GetNumberOfEdgesMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_GetNumberOfEdgesMinValue_21(HandleRef pThis);

	/// <summary>
	/// If UseEdgeProbability is off, creates a graph with the specified number
	/// of edges.  Duplicate (parallel) edges are allowed.
	/// </summary>
	public virtual int GetNumberOfEdgesMinValue()
	{
		return vtkRandomGraphSource_GetNumberOfEdgesMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomGraphSource_GetNumberOfGenerationsFromBase_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRandomGraphSource_GetNumberOfGenerationsFromBase_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomGraphSource_GetNumberOfGenerationsFromBaseType_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRandomGraphSource_GetNumberOfGenerationsFromBaseType_23(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_GetNumberOfVertices_24(HandleRef pThis);

	/// <summary>
	/// The number of vertices in the graph.
	/// </summary>
	public virtual int GetNumberOfVertices()
	{
		return vtkRandomGraphSource_GetNumberOfVertices_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_GetNumberOfVerticesMaxValue_25(HandleRef pThis);

	/// <summary>
	/// The number of vertices in the graph.
	/// </summary>
	public virtual int GetNumberOfVerticesMaxValue()
	{
		return vtkRandomGraphSource_GetNumberOfVerticesMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_GetNumberOfVerticesMinValue_26(HandleRef pThis);

	/// <summary>
	/// The number of vertices in the graph.
	/// </summary>
	public virtual int GetNumberOfVerticesMinValue()
	{
		return vtkRandomGraphSource_GetNumberOfVerticesMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_GetSeed_27(HandleRef pThis);

	/// <summary>
	/// Control the seed used for pseudo-random-number generation.
	/// This ensures that vtkRandomGraphSource can produce repeatable
	/// results.
	/// </summary>
	public virtual int GetSeed()
	{
		return vtkRandomGraphSource_GetSeed_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRandomGraphSource_GetStartWithTree_28(HandleRef pThis);

	/// <summary>
	/// When set, builds a random tree structure first, then adds additional
	/// random edges.
	/// </summary>
	public virtual bool GetStartWithTree()
	{
		return (vtkRandomGraphSource_GetStartWithTree_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRandomGraphSource_GetUseEdgeProbability_29(HandleRef pThis);

	/// <summary>
	/// When set, uses the EdgeProbability parameter to determine the density
	/// of edges.  Otherwise, NumberOfEdges is used.
	/// </summary>
	public virtual bool GetUseEdgeProbability()
	{
		return (vtkRandomGraphSource_GetUseEdgeProbability_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomGraphSource_GetVertexPedigreeIdArrayName_30(HandleRef pThis);

	/// <summary>
	/// The name of the vertex pedigree id array. Default "vertex id".
	/// </summary>
	public virtual string GetVertexPedigreeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkRandomGraphSource_GetVertexPedigreeIdArrayName_30(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_IncludeEdgeWeightsOff_31(HandleRef pThis);

	/// <summary>
	/// When set, includes edge weights in an array named "edge_weights".
	/// Defaults to off.  Weights are random between 0 and 1.
	/// </summary>
	public virtual void IncludeEdgeWeightsOff()
	{
		vtkRandomGraphSource_IncludeEdgeWeightsOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_IncludeEdgeWeightsOn_32(HandleRef pThis);

	/// <summary>
	/// When set, includes edge weights in an array named "edge_weights".
	/// Defaults to off.  Weights are random between 0 and 1.
	/// </summary>
	public virtual void IncludeEdgeWeightsOn()
	{
		vtkRandomGraphSource_IncludeEdgeWeightsOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_IsA_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRandomGraphSource_IsA_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomGraphSource_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRandomGraphSource_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomGraphSource_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRandomGraphSource NewInstance()
	{
		vtkRandomGraphSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomGraphSource_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomGraphSource_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRandomGraphSource SafeDownCast(vtkObjectBase o)
	{
		vtkRandomGraphSource vtkRandomGraphSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomGraphSource_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRandomGraphSource2 = (vtkRandomGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRandomGraphSource2.Register(null);
			}
		}
		return vtkRandomGraphSource2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetAllowParallelEdges_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set, multiple edges from a source to a target vertex are
	/// allowed. The default is to forbid such loops.
	/// </summary>
	public virtual void SetAllowParallelEdges(bool _arg)
	{
		vtkRandomGraphSource_SetAllowParallelEdges_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetAllowSelfLoops_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// If this flag is set to true, edges where the source and target
	/// vertex are the same can be generated.  The default is to forbid
	/// such loops.
	/// </summary>
	public virtual void SetAllowSelfLoops(bool _arg)
	{
		vtkRandomGraphSource_SetAllowSelfLoops_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetDirected_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set, creates a directed graph, as opposed to an undirected graph.
	/// </summary>
	public virtual void SetDirected(bool _arg)
	{
		vtkRandomGraphSource_SetDirected_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetEdgePedigreeIdArrayName_41(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the edge pedigree id array. Default "edge id".
	/// </summary>
	public virtual void SetEdgePedigreeIdArrayName(string _arg)
	{
		vtkRandomGraphSource_SetEdgePedigreeIdArrayName_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetEdgeProbability_42(HandleRef pThis, double _arg);

	/// <summary>
	/// If UseEdgeProbability is on, adds an edge with this probability between 0 and 1
	/// for each pair of vertices in the graph.
	/// </summary>
	public virtual void SetEdgeProbability(double _arg)
	{
		vtkRandomGraphSource_SetEdgeProbability_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetEdgeWeightArrayName_43(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the edge weight array. Default "edge weight".
	/// </summary>
	public virtual void SetEdgeWeightArrayName(string _arg)
	{
		vtkRandomGraphSource_SetEdgeWeightArrayName_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetGeneratePedigreeIds_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Add pedigree ids to vertex and edge data.
	/// </summary>
	public virtual void SetGeneratePedigreeIds(bool _arg)
	{
		vtkRandomGraphSource_SetGeneratePedigreeIds_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetIncludeEdgeWeights_45(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set, includes edge weights in an array named "edge_weights".
	/// Defaults to off.  Weights are random between 0 and 1.
	/// </summary>
	public virtual void SetIncludeEdgeWeights(bool _arg)
	{
		vtkRandomGraphSource_SetIncludeEdgeWeights_45(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetNumberOfEdges_46(HandleRef pThis, int _arg);

	/// <summary>
	/// If UseEdgeProbability is off, creates a graph with the specified number
	/// of edges.  Duplicate (parallel) edges are allowed.
	/// </summary>
	public virtual void SetNumberOfEdges(int _arg)
	{
		vtkRandomGraphSource_SetNumberOfEdges_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetNumberOfVertices_47(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of vertices in the graph.
	/// </summary>
	public virtual void SetNumberOfVertices(int _arg)
	{
		vtkRandomGraphSource_SetNumberOfVertices_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetSeed_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the seed used for pseudo-random-number generation.
	/// This ensures that vtkRandomGraphSource can produce repeatable
	/// results.
	/// </summary>
	public virtual void SetSeed(int _arg)
	{
		vtkRandomGraphSource_SetSeed_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetStartWithTree_49(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set, builds a random tree structure first, then adds additional
	/// random edges.
	/// </summary>
	public virtual void SetStartWithTree(bool _arg)
	{
		vtkRandomGraphSource_SetStartWithTree_49(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetUseEdgeProbability_50(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set, uses the EdgeProbability parameter to determine the density
	/// of edges.  Otherwise, NumberOfEdges is used.
	/// </summary>
	public virtual void SetUseEdgeProbability(bool _arg)
	{
		vtkRandomGraphSource_SetUseEdgeProbability_50(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_SetVertexPedigreeIdArrayName_51(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the vertex pedigree id array. Default "vertex id".
	/// </summary>
	public virtual void SetVertexPedigreeIdArrayName(string _arg)
	{
		vtkRandomGraphSource_SetVertexPedigreeIdArrayName_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_StartWithTreeOff_52(HandleRef pThis);

	/// <summary>
	/// When set, builds a random tree structure first, then adds additional
	/// random edges.
	/// </summary>
	public virtual void StartWithTreeOff()
	{
		vtkRandomGraphSource_StartWithTreeOff_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_StartWithTreeOn_53(HandleRef pThis);

	/// <summary>
	/// When set, builds a random tree structure first, then adds additional
	/// random edges.
	/// </summary>
	public virtual void StartWithTreeOn()
	{
		vtkRandomGraphSource_StartWithTreeOn_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_UseEdgeProbabilityOff_54(HandleRef pThis);

	/// <summary>
	/// When set, uses the EdgeProbability parameter to determine the density
	/// of edges.  Otherwise, NumberOfEdges is used.
	/// </summary>
	public virtual void UseEdgeProbabilityOff()
	{
		vtkRandomGraphSource_UseEdgeProbabilityOff_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomGraphSource_UseEdgeProbabilityOn_55(HandleRef pThis);

	/// <summary>
	/// When set, uses the EdgeProbability parameter to determine the density
	/// of edges.  Otherwise, NumberOfEdges is used.
	/// </summary>
	public virtual void UseEdgeProbabilityOn()
	{
		vtkRandomGraphSource_UseEdgeProbabilityOn_55(GetCppThis());
	}
}
