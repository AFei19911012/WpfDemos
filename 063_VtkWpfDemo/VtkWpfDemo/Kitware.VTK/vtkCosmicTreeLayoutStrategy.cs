using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCosmicTreeLayoutStrategy
/// </summary>
/// <remarks>
///    tree layout strategy reminiscent of astronomical systems
///
///
/// This layout strategy takes an input tree and places all the children of a
/// node into a containing circle. The placement is such that each child
/// placed can be represented with a circle tangent to the containing circle
/// and (usually) 2 other children. The interior of the circle is left empty
/// so that graph edges drawn on top of the tree will not obfuscate the tree.
/// However, when one child is much larger than all the others, it may
/// encroach on the center of the containing circle; that's OK, because it's
/// large enough not to be obscured by edges drawn atop it.
///
/// @par Thanks:
/// Thanks to the galaxy and David Thompson hierarchically nested inside it
/// for inspiring this layout strategy.
/// </remarks>
public class vtkCosmicTreeLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCosmicTreeLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCosmicTreeLayoutStrategy()
	{
		MRClassNameKey = "class vtkCosmicTreeLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCosmicTreeLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCosmicTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCosmicTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCosmicTreeLayoutStrategy New()
	{
		vtkCosmicTreeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCosmicTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCosmicTreeLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCosmicTreeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCosmicTreeLayoutStrategy_GetLayoutDepth_01(HandleRef pThis);

	/// <summary>
	/// How many levels of the tree should be laid out?
	/// For large trees, you may wish to set the root and maximum depth
	/// in order to retrieve the layout for the visible portion of the tree.
	/// When this value is zero or negative, all nodes below and including
	/// the LayoutRoot will be presented.
	/// This defaults to 0.
	/// </summary>
	public virtual int GetLayoutDepth()
	{
		return vtkCosmicTreeLayoutStrategy_GetLayoutDepth_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCosmicTreeLayoutStrategy_GetLayoutRoot_02(HandleRef pThis);

	/// <summary>
	/// What is the top-most tree node to lay out?
	/// This node will become the largest containing circle in the layout.
	/// Use this in combination with SetLayoutDepth to retrieve the
	/// layout of a subtree of interest for rendering.
	/// Setting LayoutRoot to a negative number signals that the root node
	/// of the tree should be used as the root node of the layout.
	/// This defaults to -1.
	/// </summary>
	public virtual long GetLayoutRoot()
	{
		return vtkCosmicTreeLayoutStrategy_GetLayoutRoot_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCosmicTreeLayoutStrategy_GetNodeSizeArrayName_03(HandleRef pThis);

	/// <summary>
	/// Set the array to be used for sizing nodes.
	/// If this is set to an empty string or nullptr (the default),
	/// then all leaf nodes (or all nodes, when SizeLeafNodesOnly is false)
	/// will be assigned a unit size.
	/// </summary>
	public virtual string GetNodeSizeArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkCosmicTreeLayoutStrategy_GetNodeSizeArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCosmicTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCosmicTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCosmicTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCosmicTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCosmicTreeLayoutStrategy_GetSizeLeafNodesOnly_06(HandleRef pThis);

	/// <summary>
	/// Should node size specifications be obeyed at leaf nodes only or
	/// (with scaling as required to meet constraints) at every node in
	/// the tree?
	/// This defaults to true, so that leaf nodes are scaled according to
	/// the size specification provided, and the parent node sizes are
	/// calculated by the algorithm.
	/// </summary>
	public virtual int GetSizeLeafNodesOnly()
	{
		return vtkCosmicTreeLayoutStrategy_GetSizeLeafNodesOnly_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCosmicTreeLayoutStrategy_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCosmicTreeLayoutStrategy_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCosmicTreeLayoutStrategy_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCosmicTreeLayoutStrategy_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCosmicTreeLayoutStrategy_Layout_09(HandleRef pThis);

	/// <summary>
	/// Perform the layout.
	/// </summary>
	public override void Layout()
	{
		vtkCosmicTreeLayoutStrategy_Layout_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCosmicTreeLayoutStrategy_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCosmicTreeLayoutStrategy NewInstance()
	{
		vtkCosmicTreeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCosmicTreeLayoutStrategy_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCosmicTreeLayoutStrategy_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCosmicTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkCosmicTreeLayoutStrategy vtkCosmicTreeLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCosmicTreeLayoutStrategy_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCosmicTreeLayoutStrategy2 = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCosmicTreeLayoutStrategy2.Register(null);
			}
		}
		return vtkCosmicTreeLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCosmicTreeLayoutStrategy_SetLayoutDepth_13(HandleRef pThis, int _arg);

	/// <summary>
	/// How many levels of the tree should be laid out?
	/// For large trees, you may wish to set the root and maximum depth
	/// in order to retrieve the layout for the visible portion of the tree.
	/// When this value is zero or negative, all nodes below and including
	/// the LayoutRoot will be presented.
	/// This defaults to 0.
	/// </summary>
	public virtual void SetLayoutDepth(int _arg)
	{
		vtkCosmicTreeLayoutStrategy_SetLayoutDepth_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCosmicTreeLayoutStrategy_SetLayoutRoot_14(HandleRef pThis, long _arg);

	/// <summary>
	/// What is the top-most tree node to lay out?
	/// This node will become the largest containing circle in the layout.
	/// Use this in combination with SetLayoutDepth to retrieve the
	/// layout of a subtree of interest for rendering.
	/// Setting LayoutRoot to a negative number signals that the root node
	/// of the tree should be used as the root node of the layout.
	/// This defaults to -1.
	/// </summary>
	public virtual void SetLayoutRoot(long _arg)
	{
		vtkCosmicTreeLayoutStrategy_SetLayoutRoot_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCosmicTreeLayoutStrategy_SetNodeSizeArrayName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the array to be used for sizing nodes.
	/// If this is set to an empty string or nullptr (the default),
	/// then all leaf nodes (or all nodes, when SizeLeafNodesOnly is false)
	/// will be assigned a unit size.
	/// </summary>
	public virtual void SetNodeSizeArrayName(string _arg)
	{
		vtkCosmicTreeLayoutStrategy_SetNodeSizeArrayName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCosmicTreeLayoutStrategy_SetSizeLeafNodesOnly_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Should node size specifications be obeyed at leaf nodes only or
	/// (with scaling as required to meet constraints) at every node in
	/// the tree?
	/// This defaults to true, so that leaf nodes are scaled according to
	/// the size specification provided, and the parent node sizes are
	/// calculated by the algorithm.
	/// </summary>
	public virtual void SetSizeLeafNodesOnly(int _arg)
	{
		vtkCosmicTreeLayoutStrategy_SetSizeLeafNodesOnly_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOff_17(HandleRef pThis);

	/// <summary>
	/// Should node size specifications be obeyed at leaf nodes only or
	/// (with scaling as required to meet constraints) at every node in
	/// the tree?
	/// This defaults to true, so that leaf nodes are scaled according to
	/// the size specification provided, and the parent node sizes are
	/// calculated by the algorithm.
	/// </summary>
	public virtual void SizeLeafNodesOnlyOff()
	{
		vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOn_18(HandleRef pThis);

	/// <summary>
	/// Should node size specifications be obeyed at leaf nodes only or
	/// (with scaling as required to meet constraints) at every node in
	/// the tree?
	/// This defaults to true, so that leaf nodes are scaled according to
	/// the size specification provided, and the parent node sizes are
	/// calculated by the algorithm.
	/// </summary>
	public virtual void SizeLeafNodesOnlyOn()
	{
		vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOn_18(GetCppThis());
	}
}
