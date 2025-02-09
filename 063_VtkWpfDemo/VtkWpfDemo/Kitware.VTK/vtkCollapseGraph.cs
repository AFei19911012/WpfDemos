using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCollapseGraph
/// </summary>
/// <remarks>
///    "Collapses" vertices onto their neighbors.
///
///
/// vtkCollapseGraph "collapses" vertices onto their neighbors, while maintaining
/// connectivity.  Two inputs are required - a graph (directed or undirected),
/// and a vertex selection that can be converted to indices.
///
/// Conceptually, each of the vertices specified in the input selection
/// expands, "swallowing" adacent vertices.  Edges to-or-from the "swallowed"
/// vertices become edges to-or-from the expanding vertices, maintaining the
/// overall graph connectivity.
///
/// In the case of directed graphs, expanding vertices only swallow vertices that
/// are connected via out edges.  This rule provides intuitive behavior when
/// working with trees, so that "child" vertices collapse into their parents
/// when the parents are part of the input selection.
///
/// Input port 0: graph
/// Input port 1: selection
/// </remarks>
public class vtkCollapseGraph : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCollapseGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCollapseGraph()
	{
		MRClassNameKey = "class vtkCollapseGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollapseGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCollapseGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollapseGraph New()
	{
		vtkCollapseGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollapseGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCollapseGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCollapseGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCollapseGraph_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCollapseGraph_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollapseGraph_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCollapseGraph_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollapseGraph_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCollapseGraph_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollapseGraph_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCollapseGraph_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseGraph_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCollapseGraph NewInstance()
	{
		vtkCollapseGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollapseGraph_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseGraph_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollapseGraph SafeDownCast(vtkObjectBase o)
	{
		vtkCollapseGraph vtkCollapseGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollapseGraph_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCollapseGraph2 = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCollapseGraph2.Register(null);
			}
		}
		return vtkCollapseGraph2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseGraph_SetGraphConnection_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetGraphConnection(vtkAlgorithmOutput arg0)
	{
		vtkCollapseGraph_SetGraphConnection_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseGraph_SetSelectionConnection_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetSelectionConnection(vtkAlgorithmOutput arg0)
	{
		vtkCollapseGraph_SetSelectionConnection_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
