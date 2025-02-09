using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKCoreDecomposition
/// </summary>
/// <remarks>
///    Compute the k-core decomposition of the input graph.
///
///
/// The k-core decomposition is a graph partitioning strategy that is useful for
/// analyzing the structure of large networks. A k-core of a graph G is a maximal
/// connected subgraph of G in which all vertices have degree at least k.  The k-core
/// membership for each vertex of the input graph is found on the vertex data of the
/// output graph as an array named 'KCoreDecompositionNumbers' by default.  The algorithm
/// used to find the k-cores has O(number of graph edges) running time, and is described
/// in the following reference paper.
///
/// An O(m) Algorithm for Cores Decomposition of Networks
///   V. Batagelj, M. Zaversnik, 2001
///
/// @par Thanks:
/// Thanks to Thomas Otahal from Sandia National Laboratories for providing this
/// implementation.
/// </remarks>
public class vtkKCoreDecomposition : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKCoreDecomposition";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKCoreDecomposition()
	{
		MRClassNameKey = "class vtkKCoreDecomposition";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKCoreDecomposition"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKCoreDecomposition(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreDecomposition_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKCoreDecomposition New()
	{
		vtkKCoreDecomposition result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKCoreDecomposition_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKCoreDecomposition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKCoreDecomposition()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKCoreDecomposition_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkKCoreDecomposition_CheckInputGraphOff_01(HandleRef pThis);

	/// <summary>
	/// Check the input graph for self loops and parallel
	/// edges.  The k-core is not defined for graphs that
	/// contain either of these.  Default is on.
	/// </summary>
	public virtual void CheckInputGraphOff()
	{
		vtkKCoreDecomposition_CheckInputGraphOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_CheckInputGraphOn_02(HandleRef pThis);

	/// <summary>
	/// Check the input graph for self loops and parallel
	/// edges.  The k-core is not defined for graphs that
	/// contain either of these.  Default is on.
	/// </summary>
	public virtual void CheckInputGraphOn()
	{
		vtkKCoreDecomposition_CheckInputGraphOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkKCoreDecomposition_GetCheckInputGraph_03(HandleRef pThis);

	/// <summary>
	/// Check the input graph for self loops and parallel
	/// edges.  The k-core is not defined for graphs that
	/// contain either of these.  Default is on.
	/// </summary>
	public virtual bool GetCheckInputGraph()
	{
		return (vtkKCoreDecomposition_GetCheckInputGraph_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKCoreDecomposition_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKCoreDecomposition_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKCoreDecomposition_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKCoreDecomposition_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkKCoreDecomposition_GetUseInDegreeNeighbors_06(HandleRef pThis);

	/// <summary>
	/// Directed graphs only.  Use only the in edges to
	/// compute the vertex degree of a vertex.  The default
	/// is to use both in and out edges to compute vertex
	/// degree.
	/// </summary>
	public virtual bool GetUseInDegreeNeighbors()
	{
		return (vtkKCoreDecomposition_GetUseInDegreeNeighbors_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkKCoreDecomposition_GetUseOutDegreeNeighbors_07(HandleRef pThis);

	/// <summary>
	/// Directed graphs only.  Use only the out edges to
	/// compute the vertex degree of a vertex.  The default
	/// is to use both in and out edges to compute vertex
	/// degree.
	/// </summary>
	public virtual bool GetUseOutDegreeNeighbors()
	{
		return (vtkKCoreDecomposition_GetUseOutDegreeNeighbors_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKCoreDecomposition_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKCoreDecomposition_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKCoreDecomposition_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKCoreDecomposition_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreDecomposition_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKCoreDecomposition NewInstance()
	{
		vtkKCoreDecomposition result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKCoreDecomposition_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKCoreDecomposition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreDecomposition_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKCoreDecomposition SafeDownCast(vtkObjectBase o)
	{
		vtkKCoreDecomposition vtkKCoreDecomposition2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKCoreDecomposition_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKCoreDecomposition2 = (vtkKCoreDecomposition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKCoreDecomposition2.Register(null);
			}
		}
		return vtkKCoreDecomposition2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_SetCheckInputGraph_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// Check the input graph for self loops and parallel
	/// edges.  The k-core is not defined for graphs that
	/// contain either of these.  Default is on.
	/// </summary>
	public virtual void SetCheckInputGraph(bool _arg)
	{
		vtkKCoreDecomposition_SetCheckInputGraph_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_SetOutputArrayName_14(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the output array name. If no output array name is
	/// set then the name 'KCoreDecompositionNumbers' is used.
	/// </summary>
	public virtual void SetOutputArrayName(string _arg)
	{
		vtkKCoreDecomposition_SetOutputArrayName_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_SetUseInDegreeNeighbors_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Directed graphs only.  Use only the in edges to
	/// compute the vertex degree of a vertex.  The default
	/// is to use both in and out edges to compute vertex
	/// degree.
	/// </summary>
	public virtual void SetUseInDegreeNeighbors(bool _arg)
	{
		vtkKCoreDecomposition_SetUseInDegreeNeighbors_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_SetUseOutDegreeNeighbors_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Directed graphs only.  Use only the out edges to
	/// compute the vertex degree of a vertex.  The default
	/// is to use both in and out edges to compute vertex
	/// degree.
	/// </summary>
	public virtual void SetUseOutDegreeNeighbors(bool _arg)
	{
		vtkKCoreDecomposition_SetUseOutDegreeNeighbors_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_UseInDegreeNeighborsOff_17(HandleRef pThis);

	/// <summary>
	/// Directed graphs only.  Use only the in edges to
	/// compute the vertex degree of a vertex.  The default
	/// is to use both in and out edges to compute vertex
	/// degree.
	/// </summary>
	public virtual void UseInDegreeNeighborsOff()
	{
		vtkKCoreDecomposition_UseInDegreeNeighborsOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_UseInDegreeNeighborsOn_18(HandleRef pThis);

	/// <summary>
	/// Directed graphs only.  Use only the in edges to
	/// compute the vertex degree of a vertex.  The default
	/// is to use both in and out edges to compute vertex
	/// degree.
	/// </summary>
	public virtual void UseInDegreeNeighborsOn()
	{
		vtkKCoreDecomposition_UseInDegreeNeighborsOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_UseOutDegreeNeighborsOff_19(HandleRef pThis);

	/// <summary>
	/// Directed graphs only.  Use only the out edges to
	/// compute the vertex degree of a vertex.  The default
	/// is to use both in and out edges to compute vertex
	/// degree.
	/// </summary>
	public virtual void UseOutDegreeNeighborsOff()
	{
		vtkKCoreDecomposition_UseOutDegreeNeighborsOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreDecomposition_UseOutDegreeNeighborsOn_20(HandleRef pThis);

	/// <summary>
	/// Directed graphs only.  Use only the out edges to
	/// compute the vertex degree of a vertex.  The default
	/// is to use both in and out edges to compute vertex
	/// degree.
	/// </summary>
	public virtual void UseOutDegreeNeighborsOn()
	{
		vtkKCoreDecomposition_UseOutDegreeNeighborsOn_20(GetCppThis());
	}
}
