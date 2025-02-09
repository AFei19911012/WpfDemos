using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTanglegramItem
/// </summary>
/// <remarks>
///    Display two related trees
///
///
/// This item draws two trees with connections between their leaf nodes.
/// Use SetTable() to specify what leaf nodes correspond to one another
/// between the two trees.  See the documentation for this function for
/// more details on how this table should be formatted.
///
/// .SEE ALSO
/// vtkTree vtkTable vtkDendrogramItem vtkNewickTreeReader
/// </remarks>
public class vtkTanglegramItem : vtkContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTanglegramItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTanglegramItem()
	{
		MRClassNameKey = "class vtkTanglegramItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTanglegramItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTanglegramItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTanglegramItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTanglegramItem New()
	{
		vtkTanglegramItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTanglegramItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTanglegramItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTanglegramItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTanglegramItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkTanglegramItem_GetCorrespondenceLineWidth_01(HandleRef pThis);

	/// <summary>
	/// Get/Set how wide the correspondence lines should be.  Default is two pixels.
	/// </summary>
	public virtual float GetCorrespondenceLineWidth()
	{
		return vtkTanglegramItem_GetCorrespondenceLineWidth_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTanglegramItem_GetLabelSizeDifference_02(HandleRef pThis);

	/// <summary>
	/// Get/Set how much larger the dendrogram labels should be compared to the
	/// vertex labels.  Because the vertex labels automatically resize based
	/// on zoom levels, this is a relative (not absolute) size.  Default value
	/// is 4 pts larger than the vertex labels.
	/// </summary>
	public virtual int GetLabelSizeDifference()
	{
		return vtkTanglegramItem_GetLabelSizeDifference_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTanglegramItem_GetMinimumVisibleFontSize_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the smallest font size that is still considered legible.
	/// If the current zoom level requires our vertex labels to be smaller
	/// than this size the labels will not be drawn at all.  Default value
	/// is 8 pt.
	/// </summary>
	public virtual int GetMinimumVisibleFontSize()
	{
		return vtkTanglegramItem_GetMinimumVisibleFontSize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTanglegramItem_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTanglegramItem_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTanglegramItem_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTanglegramItem_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTanglegramItem_GetOrientation_06(HandleRef pThis);

	/// <summary>
	/// Get the current orientation.
	/// </summary>
	public int GetOrientation()
	{
		return vtkTanglegramItem_GetOrientation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTanglegramItem_GetTable_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the table that describes the correspondences between the
	/// two trees.  The first column should contain the names of the leaf
	/// nodes from tree #1.  The columns of this table should be named
	/// after the leaf nodes of tree #2.  A non-zero cell should be used
	/// to create a connection between the two trees.  Different numbers
	/// in the table will result in connections being drawn in different
	/// colors.
	/// </summary>
	public vtkTable GetTable()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTanglegramItem_GetTable_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTanglegramItem_GetTree1Label_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the label for tree #1.
	/// </summary>
	public virtual string GetTree1Label()
	{
		return Marshal.PtrToStringAnsi(vtkTanglegramItem_GetTree1Label_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTanglegramItem_GetTree2Label_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the label for tree #2.
	/// </summary>
	public virtual string GetTree2Label()
	{
		return Marshal.PtrToStringAnsi(vtkTanglegramItem_GetTree2Label_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkTanglegramItem_GetTreeLineWidth_10(HandleRef pThis);

	/// <summary>
	/// Get/Set how wide the edges of the trees should be.  Default is one pixel.
	/// </summary>
	public float GetTreeLineWidth()
	{
		return vtkTanglegramItem_GetTreeLineWidth_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTanglegramItem_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTanglegramItem_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTanglegramItem_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTanglegramItem_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTanglegramItem_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTanglegramItem NewInstance()
	{
		vtkTanglegramItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTanglegramItem_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTanglegramItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTanglegramItem_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTanglegramItem SafeDownCast(vtkObjectBase o)
	{
		vtkTanglegramItem vtkTanglegramItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTanglegramItem_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTanglegramItem2 = (vtkTanglegramItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTanglegramItem2.Register(null);
			}
		}
		return vtkTanglegramItem2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetCorrespondenceLineWidth_16(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set how wide the correspondence lines should be.  Default is two pixels.
	/// </summary>
	public virtual void SetCorrespondenceLineWidth(float _arg)
	{
		vtkTanglegramItem_SetCorrespondenceLineWidth_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetLabelSizeDifference_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set how much larger the dendrogram labels should be compared to the
	/// vertex labels.  Because the vertex labels automatically resize based
	/// on zoom levels, this is a relative (not absolute) size.  Default value
	/// is 4 pts larger than the vertex labels.
	/// </summary>
	public virtual void SetLabelSizeDifference(int _arg)
	{
		vtkTanglegramItem_SetLabelSizeDifference_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetMinimumVisibleFontSize_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the smallest font size that is still considered legible.
	/// If the current zoom level requires our vertex labels to be smaller
	/// than this size the labels will not be drawn at all.  Default value
	/// is 8 pt.
	/// </summary>
	public virtual void SetMinimumVisibleFontSize(int _arg)
	{
		vtkTanglegramItem_SetMinimumVisibleFontSize_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetOrientation_19(HandleRef pThis, int orientation);

	/// <summary>
	/// Set which way the tanglegram should face within the visualization.
	/// The default is for tree #1 to be drawn left to right.
	/// </summary>
	public void SetOrientation(int orientation)
	{
		vtkTanglegramItem_SetOrientation_19(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetTable_20(HandleRef pThis, HandleRef table);

	/// <summary>
	/// Get/Set the table that describes the correspondences between the
	/// two trees.  The first column should contain the names of the leaf
	/// nodes from tree #1.  The columns of this table should be named
	/// after the leaf nodes of tree #2.  A non-zero cell should be used
	/// to create a connection between the two trees.  Different numbers
	/// in the table will result in connections being drawn in different
	/// colors.
	/// </summary>
	public void SetTable(vtkTable table)
	{
		vtkTanglegramItem_SetTable_20(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetTree1_21(HandleRef pThis, HandleRef tree);

	/// <summary>
	/// Set the first tree
	/// </summary>
	public virtual void SetTree1(vtkTree tree)
	{
		vtkTanglegramItem_SetTree1_21(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetTree1Label_22(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the label for tree #1.
	/// </summary>
	public virtual void SetTree1Label(string _arg)
	{
		vtkTanglegramItem_SetTree1Label_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetTree2_23(HandleRef pThis, HandleRef tree);

	/// <summary>
	/// Set the second tree
	/// </summary>
	public virtual void SetTree2(vtkTree tree)
	{
		vtkTanglegramItem_SetTree2_23(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetTree2Label_24(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the label for tree #2.
	/// </summary>
	public virtual void SetTree2Label(string _arg)
	{
		vtkTanglegramItem_SetTree2Label_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTanglegramItem_SetTreeLineWidth_25(HandleRef pThis, float width);

	/// <summary>
	/// Get/Set how wide the edges of the trees should be.  Default is one pixel.
	/// </summary>
	public void SetTreeLineWidth(float width)
	{
		vtkTanglegramItem_SetTreeLineWidth_25(GetCppThis(), width);
	}
}
