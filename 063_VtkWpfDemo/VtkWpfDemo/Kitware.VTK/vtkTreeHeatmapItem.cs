using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTreeHeatmapItem
/// </summary>
/// <remarks>
///    A 2D graphics item for rendering a tree and
/// an associated heatmap.
///
///
/// This item draws a tree and a heatmap as a part of a vtkContextScene.
/// The input tree's vertex data must contain at least two arrays.
/// The first required array is a vtkStringArray called "node name".
/// This array corresponds to the first column of the input table.
/// The second required array is a scalar array called "node weight".
/// This array is used by vtkTreeLayoutStrategy to set any particular
/// node's distance from the root of the tree.
///
/// The vtkNewickTreeReader automatically initializes both of these
/// required arrays in its output tree.
///
/// .SEE ALSO
/// vtkDendrogramItem vtkHeatmapItem vtkTree vtkTable vtkNewickTreeReader
/// </remarks>
public class vtkTreeHeatmapItem : vtkContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTreeHeatmapItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTreeHeatmapItem()
	{
		MRClassNameKey = "class vtkTreeHeatmapItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeHeatmapItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTreeHeatmapItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeHeatmapItem New()
	{
		vtkTreeHeatmapItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeHeatmapItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTreeHeatmapItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTreeHeatmapItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_CollapseToNumberOfLeafNodes_01(HandleRef pThis, uint n);

	/// <summary>
	/// Collapse subtrees until there are only n leaf nodes left in the tree.
	/// The leaf nodes that remain are those that are closest to the root.
	/// Any subtrees that were collapsed prior to this function being called
	/// may be re-expanded.  Use this function instead of
	/// this-&gt;GetDendrogram-&gt;CollapseToNumberOfLeafNodes(), as this function
	/// also handles the hiding of heatmap rows that correspond to newly
	/// collapsed subtrees.
	/// </summary>
	public void CollapseToNumberOfLeafNodes(uint n)
	{
		vtkTreeHeatmapItem_CollapseToNumberOfLeafNodes_01(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds of this item (xMin, xMax, yMin, Max) in pixel coordinates.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkTreeHeatmapItem_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_GetCenter_03(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Get the center point of this item in pixel coordinates.
	/// </summary>
	public void GetCenter(IntPtr center)
	{
		vtkTreeHeatmapItem_GetCenter_03(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_GetColumnTree_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the tree that represents the columns of the heatmap (if one has
	/// been set).
	/// </summary>
	public vtkTree GetColumnTree()
	{
		vtkTree vtkTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_GetColumnTree_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTree2 = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTree2.Register(null);
			}
		}
		return vtkTree2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_GetDendrogram_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the dendrogram contained by this item.
	/// </summary>
	public vtkDendrogramItem GetDendrogram()
	{
		vtkDendrogramItem vtkDendrogramItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_GetDendrogram_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDendrogramItem2 = (vtkDendrogramItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDendrogramItem2.Register(null);
			}
		}
		return vtkDendrogramItem2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_GetHeatmap_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the heatmap contained by this item.
	/// </summary>
	public vtkHeatmapItem GetHeatmap()
	{
		vtkHeatmapItem vtkHeatmapItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_GetHeatmap_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHeatmapItem2 = (vtkHeatmapItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHeatmapItem2.Register(null);
			}
		}
		return vtkHeatmapItem2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeHeatmapItem_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTreeHeatmapItem_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTreeHeatmapItem_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTreeHeatmapItem_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeHeatmapItem_GetOrientation_09(HandleRef pThis);

	/// <summary>
	/// Get the current orientation.
	/// </summary>
	public int GetOrientation()
	{
		return vtkTreeHeatmapItem_GetOrientation_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_GetPrunedTree_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Deprecated.  Use this-&gt;GetDendrogram()-&gt;GetPrunedTree() instead.
	/// </summary>
	public vtkTree GetPrunedTree()
	{
		vtkTree vtkTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_GetPrunedTree_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTree2 = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTree2.Register(null);
			}
		}
		return vtkTree2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_GetSize_11(HandleRef pThis, IntPtr size);

	/// <summary>
	/// Get the size of this item in pixel coordinates.
	/// </summary>
	public void GetSize(IntPtr size)
	{
		vtkTreeHeatmapItem_GetSize_11(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_GetTable_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the table that this item draws.
	/// </summary>
	public vtkTable GetTable()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_GetTable_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_GetTree_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the tree that this item draws.
	/// </summary>
	public vtkTree GetTree()
	{
		vtkTree vtkTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_GetTree_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTree2 = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTree2.Register(null);
			}
		}
		return vtkTree2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkTreeHeatmapItem_GetTreeLineWidth_14(HandleRef pThis);

	/// <summary>
	/// Get/Set how wide the edges of the trees should be.  Default is one pixel.
	/// </summary>
	public float GetTreeLineWidth()
	{
		return vtkTreeHeatmapItem_GetTreeLineWidth_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeHeatmapItem_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTreeHeatmapItem_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTreeHeatmapItem_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTreeHeatmapItem_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTreeHeatmapItem NewInstance()
	{
		vtkTreeHeatmapItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTreeHeatmapItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_ReorderTable_19(HandleRef pThis);

	/// <summary>
	/// Reorder the rows in the table so they match the order of the leaf
	/// nodes in our tree.
	/// </summary>
	public void ReorderTable()
	{
		vtkTreeHeatmapItem_ReorderTable_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_ReverseTableColumns_20(HandleRef pThis);

	/// <summary>
	/// Reverse the order of the rows in our input table.  This is used
	/// to simplify the table layout for DOWN_TO_UP and UP_TO_DOWN
	/// orientations.
	/// </summary>
	public void ReverseTableColumns()
	{
		vtkTreeHeatmapItem_ReverseTableColumns_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_ReverseTableRows_21(HandleRef pThis);

	/// <summary>
	/// Reverse the order of the rows in our input table.  This is used
	/// to simplify the table layout for DOWN_TO_UP and RIGHT_TO_LEFT
	/// orientations.
	/// </summary>
	public void ReverseTableRows()
	{
		vtkTreeHeatmapItem_ReverseTableRows_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTreeHeatmapItem_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTreeHeatmapItem SafeDownCast(vtkObjectBase o)
	{
		vtkTreeHeatmapItem vtkTreeHeatmapItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTreeHeatmapItem_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTreeHeatmapItem2 = (vtkTreeHeatmapItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTreeHeatmapItem2.Register(null);
			}
		}
		return vtkTreeHeatmapItem2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_SetColumnTree_23(HandleRef pThis, HandleRef tree);

	/// <summary>
	/// Set a tree to be drawn for the columns of the heatmap.  This tree's
	/// vertex data must contain a vtkStringArray called "node name" that
	/// corresponds to the names of the columns in the heatmap.
	/// </summary>
	public virtual void SetColumnTree(vtkTree tree)
	{
		vtkTreeHeatmapItem_SetColumnTree_23(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_SetDendrogram_24(HandleRef pThis, HandleRef dendrogram);

	/// <summary>
	/// Get/Set the dendrogram contained by this item.
	/// </summary>
	public void SetDendrogram(vtkDendrogramItem dendrogram)
	{
		vtkTreeHeatmapItem_SetDendrogram_24(GetCppThis(), dendrogram?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_SetHeatmap_25(HandleRef pThis, HandleRef heatmap);

	/// <summary>
	/// Get/Set the heatmap contained by this item.
	/// </summary>
	public void SetHeatmap(vtkHeatmapItem heatmap)
	{
		vtkTreeHeatmapItem_SetHeatmap_25(GetCppThis(), heatmap?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_SetOrientation_26(HandleRef pThis, int orientation);

	/// <summary>
	/// Set which way the tree / heatmap should face within the visualization.
	/// The default is for both components to be drawn left to right.
	/// </summary>
	public void SetOrientation(int orientation)
	{
		vtkTreeHeatmapItem_SetOrientation_26(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_SetTable_27(HandleRef pThis, HandleRef table);

	/// <summary>
	/// Set the table that this item draws.  The first column of the table
	/// must contain the names of the rows.  These names, in turn, must correspond
	/// with the nodes names in the input tree.  See SetTree for more information.
	/// </summary>
	public virtual void SetTable(vtkTable table)
	{
		vtkTreeHeatmapItem_SetTable_27(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_SetTree_28(HandleRef pThis, HandleRef tree);

	/// <summary>
	/// Set the tree that this item draws.  Note that this tree's vertex data
	/// must contain a vtkStringArray called "node name".  Additionally, this
	/// array must contain the same values as the first column of the input
	/// table.  See SetTable for more information.  The vtkNewickTreeReader
	/// automatically creates this required array for you.
	/// </summary>
	public virtual void SetTree(vtkTree tree)
	{
		vtkTreeHeatmapItem_SetTree_28(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_SetTreeColorArray_29(HandleRef pThis, string arrayName);

	/// <summary>
	/// Deprecated.  Use this-&gt;GetDendrogram()-&gt;SetColorArray(const char *arrayName)
	/// instead.
	/// </summary>
	public void SetTreeColorArray(string arrayName)
	{
		vtkTreeHeatmapItem_SetTreeColorArray_29(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTreeHeatmapItem_SetTreeLineWidth_30(HandleRef pThis, float width);

	/// <summary>
	/// Get/Set how wide the edges of the trees should be.  Default is one pixel.
	/// </summary>
	public void SetTreeLineWidth(float width)
	{
		vtkTreeHeatmapItem_SetTreeLineWidth_30(GetCppThis(), width);
	}
}
