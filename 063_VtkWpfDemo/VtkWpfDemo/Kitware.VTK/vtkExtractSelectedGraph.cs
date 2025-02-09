using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractSelectedGraph
/// </summary>
/// <remarks>
///    return a subgraph of a vtkGraph
///
///
/// The first input is a vtkGraph to take a subgraph from.
/// The second input (optional) is a vtkSelection containing selected
/// indices. The third input (optional) is a vtkAnnotationsLayers whose
/// annotations contain selected specifying selected indices.
/// The vtkSelection may have FIELD_TYPE set to POINTS (a vertex selection)
/// or CELLS (an edge selection).  A vertex selection preserves all edges
/// that connect selected vertices.  An edge selection preserves all vertices
/// that are adjacent to at least one selected edge.  Alternately, you may
/// indicate that an edge selection should maintain the full set of vertices,
/// by turning RemoveIsolatedVertices off.
/// </remarks>
public class vtkExtractSelectedGraph : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractSelectedGraph()
	{
		MRClassNameKey = "class vtkExtractSelectedGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractSelectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedGraph New()
	{
		vtkExtractSelectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractSelectedGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractSelectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkExtractSelectedGraph_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Specify the first vtkGraph input and the second vtkSelection input.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkExtractSelectedGraph_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectedGraph_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractSelectedGraph_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractSelectedGraph_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractSelectedGraph_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractSelectedGraph_GetRemoveIsolatedVertices_04(HandleRef pThis);

	/// <summary>
	/// If set, removes vertices with no adjacent edges in an edge selection.
	/// A vertex selection ignores this flag and always returns the full set
	/// of selected vertices.  Default is on.
	/// </summary>
	public virtual bool GetRemoveIsolatedVertices()
	{
		return (vtkExtractSelectedGraph_GetRemoveIsolatedVertices_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedGraph_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractSelectedGraph_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractSelectedGraph_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractSelectedGraph_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedGraph_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractSelectedGraph NewInstance()
	{
		vtkExtractSelectedGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedGraph_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedGraph_RemoveIsolatedVerticesOff_09(HandleRef pThis);

	/// <summary>
	/// If set, removes vertices with no adjacent edges in an edge selection.
	/// A vertex selection ignores this flag and always returns the full set
	/// of selected vertices.  Default is on.
	/// </summary>
	public virtual void RemoveIsolatedVerticesOff()
	{
		vtkExtractSelectedGraph_RemoveIsolatedVerticesOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedGraph_RemoveIsolatedVerticesOn_10(HandleRef pThis);

	/// <summary>
	/// If set, removes vertices with no adjacent edges in an edge selection.
	/// A vertex selection ignores this flag and always returns the full set
	/// of selected vertices.  Default is on.
	/// </summary>
	public virtual void RemoveIsolatedVerticesOn()
	{
		vtkExtractSelectedGraph_RemoveIsolatedVerticesOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractSelectedGraph_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractSelectedGraph SafeDownCast(vtkObjectBase o)
	{
		vtkExtractSelectedGraph vtkExtractSelectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractSelectedGraph_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractSelectedGraph2 = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractSelectedGraph2.Register(null);
			}
		}
		return vtkExtractSelectedGraph2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedGraph_SetAnnotationLayersConnection_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method for setting the third input (i.e. the annotation layers).
	/// </summary>
	public void SetAnnotationLayersConnection(vtkAlgorithmOutput arg0)
	{
		vtkExtractSelectedGraph_SetAnnotationLayersConnection_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedGraph_SetRemoveIsolatedVertices_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set, removes vertices with no adjacent edges in an edge selection.
	/// A vertex selection ignores this flag and always returns the full set
	/// of selected vertices.  Default is on.
	/// </summary>
	public virtual void SetRemoveIsolatedVertices(bool _arg)
	{
		vtkExtractSelectedGraph_SetRemoveIsolatedVertices_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractSelectedGraph_SetSelectionConnection_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A convenience method for setting the second input (i.e. the selection).
	/// </summary>
	public void SetSelectionConnection(vtkAlgorithmOutput arg0)
	{
		vtkExtractSelectedGraph_SetSelectionConnection_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
