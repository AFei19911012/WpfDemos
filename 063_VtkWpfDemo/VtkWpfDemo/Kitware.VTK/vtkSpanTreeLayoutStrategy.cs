using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSpanTreeLayoutStrategy
///
/// vtkSpanTreeLayout is a strategy for drawing directed graphs that
/// works by first extracting a spanning tree (more accurately, a
/// spanning forest), and using this both to position graph vertices
/// and to plan the placement of non-tree edges.  The latter are drawn
/// with the aid of edge points to produce a tidy drawing.
///
/// The approach is best suited to "quasi-trees", graphs where the number
/// of edges is of the same order as the number of nodes; it is less well
/// suited to denser graphs.  The boolean flag DepthFirstSpanningTree
/// determines whether a depth-first or breadth-first strategy is used to
/// construct the underlying forest, and the choice of strategy affects
/// the output layout significantly.  Informal experiments suggest that
/// the breadth-first strategy is better for denser graphs.
///
/// Different layouts could also be produced by plugging in alternative
/// tree layout strategies.  To work with the method of routing non-tree
/// edges, any strategy should draw a tree so that levels are equally
/// spaced along the z-axis, precluding for example the use of a radial
/// or balloon layout.
///
/// vtkSpanTreeLayout is based on an approach to 3D graph layout first
/// developed as part of the "tulip" tool by Dr. David Auber at LaBRI,
/// U.Bordeaux: see www.tulip-software.org
///
/// This implementation departs from the original version in that:
/// (a) it is reconstructed to use Titan/VTK data structures;
/// (b) it uses a faster method for dealing with non-tree edges,
///     requiring at most two edge points per edge
/// (c) allows for plugging in different tree layout methods
/// (d) allows selection of two different strategies for building
///     the underlying layout tree, which can yield significantly
///     different results depending on the data.
///
/// @par Thanks:
/// Thanks to David Duke from the University of Leeds for providing this
/// implementation.
/// </summary>
public class vtkSpanTreeLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSpanTreeLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSpanTreeLayoutStrategy()
	{
		MRClassNameKey = "class vtkSpanTreeLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpanTreeLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSpanTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpanTreeLayoutStrategy New()
	{
		vtkSpanTreeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpanTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSpanTreeLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSpanTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOff_01(HandleRef pThis);

	/// <summary>
	/// If set, base the layout on a depth-first spanning tree,
	/// rather than the default breadth-first spanning tree.
	/// Switching between DFT and BFT may significantly change
	/// the layout, and choice must be made on a per-graph basis.
	/// Default value is off.
	/// </summary>
	public virtual void DepthFirstSpanningTreeOff()
	{
		vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOn_02(HandleRef pThis);

	/// <summary>
	/// If set, base the layout on a depth-first spanning tree,
	/// rather than the default breadth-first spanning tree.
	/// Switching between DFT and BFT may significantly change
	/// the layout, and choice must be made on a per-graph basis.
	/// Default value is off.
	/// </summary>
	public virtual void DepthFirstSpanningTreeOn()
	{
		vtkSpanTreeLayoutStrategy_DepthFirstSpanningTreeOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSpanTreeLayoutStrategy_GetDepthFirstSpanningTree_03(HandleRef pThis);

	/// <summary>
	/// If set, base the layout on a depth-first spanning tree,
	/// rather than the default breadth-first spanning tree.
	/// Switching between DFT and BFT may significantly change
	/// the layout, and choice must be made on a per-graph basis.
	/// Default value is off.
	/// </summary>
	public virtual bool GetDepthFirstSpanningTree()
	{
		return (vtkSpanTreeLayoutStrategy_GetDepthFirstSpanningTree_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSpanTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSpanTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSpanTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanTreeLayoutStrategy_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSpanTreeLayoutStrategy_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSpanTreeLayoutStrategy_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSpanTreeLayoutStrategy_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanTreeLayoutStrategy_Layout_08(HandleRef pThis);

	/// <summary>
	/// Perform the layout.
	/// </summary>
	public override void Layout()
	{
		vtkSpanTreeLayoutStrategy_Layout_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanTreeLayoutStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSpanTreeLayoutStrategy NewInstance()
	{
		vtkSpanTreeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpanTreeLayoutStrategy_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSpanTreeLayoutStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSpanTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkSpanTreeLayoutStrategy vtkSpanTreeLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSpanTreeLayoutStrategy_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpanTreeLayoutStrategy2 = (vtkSpanTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpanTreeLayoutStrategy2.Register(null);
			}
		}
		return vtkSpanTreeLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSpanTreeLayoutStrategy_SetDepthFirstSpanningTree_12(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set, base the layout on a depth-first spanning tree,
	/// rather than the default breadth-first spanning tree.
	/// Switching between DFT and BFT may significantly change
	/// the layout, and choice must be made on a per-graph basis.
	/// Default value is off.
	/// </summary>
	public virtual void SetDepthFirstSpanningTree(bool _arg)
	{
		vtkSpanTreeLayoutStrategy_SetDepthFirstSpanningTree_12(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
