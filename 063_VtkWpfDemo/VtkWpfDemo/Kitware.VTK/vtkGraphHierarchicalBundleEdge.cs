using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphHierarchicalBundleEdges
/// </summary>
/// <remarks>
///    layout graph arcs in bundles
///
///
/// This algorithm creates a vtkPolyData from a vtkGraph.  As opposed to
/// vtkGraphToPolyData, which converts each arc into a straight line, each arc
/// is converted to a polyline, following a tree structure.  The filter requires
/// both a vtkGraph and vtkTree as input.  The tree vertices must be a
/// superset of the graph vertices.  A common example is when the graph vertices
/// correspond to the leaves of the tree, but the internal vertices of the tree
/// represent groupings of graph vertices.  The algorithm matches the vertices
/// using the array "PedigreeId".  The user may alternately set the
/// DirectMapping flag to indicate that the two structures must have directly
/// corresponding offsets (i.e. node i in the graph must correspond to node i in
/// the tree).
///
/// The vtkGraph defines the topology of the output vtkPolyData (i.e.
/// the connections between nodes) while the vtkTree defines the geometry (i.e.
/// the location of nodes and arc routes).  Thus, the tree must have been
/// assigned vertex locations, but the graph does not need locations, in fact
/// they will be ignored.  The edges approximately follow the path from the
/// source to target nodes in the tree.  A bundling parameter controls how
/// closely the edges are bundled together along the tree structure.
///
/// You may follow this algorithm with vtkSplineFilter in order to make nicely
/// curved edges.
///
/// @par Thanks:
/// This algorithm was developed in the paper
/// Danny Holten. Hierarchical Edge Bundles: Visualization of Adjacency Relations
/// Relations in Hierarchical Data. IEEE Transactions on Visualization and
/// Computer Graphics, Vol. 12, No. 5, 2006. pp. 741-748.
/// </remarks>
public class vtkGraphHierarchicalBundleEdges : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphHierarchicalBundleEdges";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphHierarchicalBundleEdges()
	{
		MRClassNameKey = "class vtkGraphHierarchicalBundleEdges";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphHierarchicalBundleEdges"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphHierarchicalBundleEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphHierarchicalBundleEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphHierarchicalBundleEdges New()
	{
		vtkGraphHierarchicalBundleEdges result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphHierarchicalBundleEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGraphHierarchicalBundleEdges()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGraphHierarchicalBundleEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGraphHierarchicalBundleEdges_DirectMappingOff_01(HandleRef pThis);

	/// <summary>
	/// If on, uses direct mapping from tree to graph vertices.
	/// If off, both the graph and tree must contain PedigreeId arrays
	/// which are used to match graph and tree vertices.
	/// Default is off.
	/// </summary>
	public virtual void DirectMappingOff()
	{
		vtkGraphHierarchicalBundleEdges_DirectMappingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphHierarchicalBundleEdges_DirectMappingOn_02(HandleRef pThis);

	/// <summary>
	/// If on, uses direct mapping from tree to graph vertices.
	/// If off, both the graph and tree must contain PedigreeId arrays
	/// which are used to match graph and tree vertices.
	/// Default is off.
	/// </summary>
	public virtual void DirectMappingOn()
	{
		vtkGraphHierarchicalBundleEdges_DirectMappingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphHierarchicalBundleEdges_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Set the input type of the algorithm to vtkGraph.
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkGraphHierarchicalBundleEdges_FillInputPortInformation_03(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrength_04(HandleRef pThis);

	/// <summary>
	/// The level of arc bundling in the graph.
	/// A strength of 0 creates straight lines, while a strength of 1
	/// forces arcs to pass directly through hierarchy node points.
	/// The default value is 0.8.
	/// </summary>
	public virtual double GetBundlingStrength()
	{
		return vtkGraphHierarchicalBundleEdges_GetBundlingStrength_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMaxValue_05(HandleRef pThis);

	/// <summary>
	/// The level of arc bundling in the graph.
	/// A strength of 0 creates straight lines, while a strength of 1
	/// forces arcs to pass directly through hierarchy node points.
	/// The default value is 0.8.
	/// </summary>
	public virtual double GetBundlingStrengthMaxValue()
	{
		return vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMinValue_06(HandleRef pThis);

	/// <summary>
	/// The level of arc bundling in the graph.
	/// A strength of 0 creates straight lines, while a strength of 1
	/// forces arcs to pass directly through hierarchy node points.
	/// The default value is 0.8.
	/// </summary>
	public virtual double GetBundlingStrengthMinValue()
	{
		return vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphHierarchicalBundleEdges_GetDirectMapping_07(HandleRef pThis);

	/// <summary>
	/// If on, uses direct mapping from tree to graph vertices.
	/// If off, both the graph and tree must contain PedigreeId arrays
	/// which are used to match graph and tree vertices.
	/// Default is off.
	/// </summary>
	public virtual bool GetDirectMapping()
	{
		return (vtkGraphHierarchicalBundleEdges_GetDirectMapping_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphHierarchicalBundleEdges_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphHierarchicalBundleEdges_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphHierarchicalBundleEdges_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphHierarchicalBundleEdges_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphHierarchicalBundleEdges_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphHierarchicalBundleEdges_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphHierarchicalBundleEdges_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphHierarchicalBundleEdges_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphHierarchicalBundleEdges_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphHierarchicalBundleEdges NewInstance()
	{
		vtkGraphHierarchicalBundleEdges result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphHierarchicalBundleEdges_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphHierarchicalBundleEdges_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphHierarchicalBundleEdges SafeDownCast(vtkObjectBase o)
	{
		vtkGraphHierarchicalBundleEdges vtkGraphHierarchicalBundleEdges2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphHierarchicalBundleEdges_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphHierarchicalBundleEdges2 = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphHierarchicalBundleEdges2.Register(null);
			}
		}
		return vtkGraphHierarchicalBundleEdges2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphHierarchicalBundleEdges_SetBundlingStrength_15(HandleRef pThis, double _arg);

	/// <summary>
	/// The level of arc bundling in the graph.
	/// A strength of 0 creates straight lines, while a strength of 1
	/// forces arcs to pass directly through hierarchy node points.
	/// The default value is 0.8.
	/// </summary>
	public virtual void SetBundlingStrength(double _arg)
	{
		vtkGraphHierarchicalBundleEdges_SetBundlingStrength_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphHierarchicalBundleEdges_SetDirectMapping_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, uses direct mapping from tree to graph vertices.
	/// If off, both the graph and tree must contain PedigreeId arrays
	/// which are used to match graph and tree vertices.
	/// Default is off.
	/// </summary>
	public virtual void SetDirectMapping(bool _arg)
	{
		vtkGraphHierarchicalBundleEdges_SetDirectMapping_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
