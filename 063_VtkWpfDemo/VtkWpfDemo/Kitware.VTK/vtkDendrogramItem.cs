using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDendrogramItem
/// </summary>
/// <remarks>
///    A 2D graphics item for rendering a tree as
/// a dendrogram
///
///
/// Draw a tree as a dendrogram
/// The input tree's vertex data must contain at least two arrays.
/// The first required array is a vtkStringArray called "node name".
/// This array is used to label the leaf nodes of the tree.
/// The second required array is a scalar array called "node weight".
/// This array is used by vtkTreeLayoutStrategy to set any particular
/// node's distance from the root of the tree.
///
/// The vtkNewickTreeReader automatically initializes both of these
/// required arrays in its output tree.
///
/// .SEE ALSO
/// vtkTree vtkNewickTreeReader
/// </remarks>
public class vtkDendrogramItem : vtkContextItem
{
	/// <summary>
	/// Enum for Orientation.
	/// </summary>
	public enum DOWN_TO_UP_WrapperEnum
	{
		/// <summary>enum member</summary>
		DOWN_TO_UP = 3,
		/// <summary>enum member</summary>
		LEFT_TO_RIGHT = 0,
		/// <summary>enum member</summary>
		RIGHT_TO_LEFT = 2,
		/// <summary>enum member</summary>
		UP_TO_DOWN = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDendrogramItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDendrogramItem()
	{
		MRClassNameKey = "class vtkDendrogramItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDendrogramItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDendrogramItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDendrogramItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDendrogramItem New()
	{
		vtkDendrogramItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDendrogramItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDendrogramItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDendrogramItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDendrogramItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDendrogramItem_CollapseToNumberOfLeafNodes_01(HandleRef pThis, uint n);

	/// <summary>
	/// Collapse subtrees until there are only n leaf nodes left in the tree.
	/// The leaf nodes that remain are those that are closest to the root.
	/// Any subtrees that were collapsed prior to this function being called
	/// may be re-expanded.
	/// </summary>
	public void CollapseToNumberOfLeafNodes(uint n)
	{
		vtkDendrogramItem_CollapseToNumberOfLeafNodes_01(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_ComputeLabelWidth_02(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Compute the width of the longest leaf node label.
	/// </summary>
	public void ComputeLabelWidth(vtkContext2D painter)
	{
		vtkDendrogramItem_ComputeLabelWidth_02(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_DisplayNumberOfCollapsedLeafNodesOff_03(HandleRef pThis);

	/// <summary>
	/// Get/set whether or not the number of collapsed leaf nodes should be written
	/// inside the triangle representing a collapsed subtree.  Default is true.
	/// </summary>
	public virtual void DisplayNumberOfCollapsedLeafNodesOff()
	{
		vtkDendrogramItem_DisplayNumberOfCollapsedLeafNodesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_DisplayNumberOfCollapsedLeafNodesOn_04(HandleRef pThis);

	/// <summary>
	/// Get/set whether or not the number of collapsed leaf nodes should be written
	/// inside the triangle representing a collapsed subtree.  Default is true.
	/// </summary>
	public virtual void DisplayNumberOfCollapsedLeafNodesOn()
	{
		vtkDendrogramItem_DisplayNumberOfCollapsedLeafNodesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_DrawLabelsOff_05(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not leaf nodes should be labeled by this class.
	/// Default is true.
	/// </summary>
	public virtual void DrawLabelsOff()
	{
		vtkDendrogramItem_DrawLabelsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_DrawLabelsOn_06(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not leaf nodes should be labeled by this class.
	/// Default is true.
	/// </summary>
	public virtual void DrawLabelsOn()
	{
		vtkDendrogramItem_DrawLabelsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_ExtendLeafNodesOff_07(HandleRef pThis);

	/// <summary>
	/// Get/set whether or not leaf nodes should be extended so that they all line
	/// up vertically.  The default is to NOT extend leaf nodes.  When extending
	/// leaf nodes, the extra length is drawn in grey so as to distinguish it from
	/// the actual length of the leaf node.
	/// </summary>
	public virtual void ExtendLeafNodesOff()
	{
		vtkDendrogramItem_ExtendLeafNodesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_ExtendLeafNodesOn_08(HandleRef pThis);

	/// <summary>
	/// Get/set whether or not leaf nodes should be extended so that they all line
	/// up vertically.  The default is to NOT extend leaf nodes.  When extending
	/// leaf nodes, the extra length is drawn in grey so as to distinguish it from
	/// the actual length of the leaf node.
	/// </summary>
	public virtual void ExtendLeafNodesOn()
	{
		vtkDendrogramItem_ExtendLeafNodesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDendrogramItem_GetAngleForOrientation_09(HandleRef pThis, int orientation);

	/// <summary>
	/// Get the rotation angle (in degrees) that corresponds to the given
	/// tree orientation.  For the default orientation (LEFT_TO_RIGHT), this
	/// is 90 degrees.
	/// </summary>
	public double GetAngleForOrientation(int orientation)
	{
		return vtkDendrogramItem_GetAngleForOrientation_09(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_GetBounds_10(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this item as (Xmin,Xmax,Ymin,Ymax).
	/// These bounds are only guaranteed to be accurate after Paint() or
	/// PrepareToPaint() has been called.
	/// </summary>
	public virtual void GetBounds(IntPtr bounds)
	{
		vtkDendrogramItem_GetBounds_10(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDendrogramItem_GetDisplayNumberOfCollapsedLeafNodes_11(HandleRef pThis);

	/// <summary>
	/// Get/set whether or not the number of collapsed leaf nodes should be written
	/// inside the triangle representing a collapsed subtree.  Default is true.
	/// </summary>
	public virtual bool GetDisplayNumberOfCollapsedLeafNodes()
	{
		return (vtkDendrogramItem_GetDisplayNumberOfCollapsedLeafNodes_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDendrogramItem_GetDistanceArrayName_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the array that specifies the distance of each vertex
	/// from the root (NOT the vertex's parent).  This array should be a part of
	/// the input tree's VertexData.  By default, this value is "node weight",
	/// which is the name of the array created by vtkNewickTreeReader.
	/// </summary>
	public virtual string GetDistanceArrayName()
	{
		return vtkDendrogramItem_GetDistanceArrayName_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDendrogramItem_GetDrawLabels_13(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not leaf nodes should be labeled by this class.
	/// Default is true.
	/// </summary>
	public virtual bool GetDrawLabels()
	{
		return (vtkDendrogramItem_GetDrawLabels_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDendrogramItem_GetExtendLeafNodes_14(HandleRef pThis);

	/// <summary>
	/// Get/set whether or not leaf nodes should be extended so that they all line
	/// up vertically.  The default is to NOT extend leaf nodes.  When extending
	/// leaf nodes, the extra length is drawn in grey so as to distinguish it from
	/// the actual length of the leaf node.
	/// </summary>
	public virtual bool GetExtendLeafNodes()
	{
		return (vtkDendrogramItem_GetExtendLeafNodes_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDendrogramItem_GetLabelWidth_15(HandleRef pThis);

	/// <summary>
	/// Get the width of the longest leaf node label.
	/// </summary>
	public float GetLabelWidth()
	{
		return vtkDendrogramItem_GetLabelWidth_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDendrogramItem_GetLeafSpacing_16(HandleRef pThis);

	/// <summary>
	/// Get/Set the spacing between the leaf nodes in our dendrogram.
	/// Default is 18 pixels.
	/// </summary>
	public virtual double GetLeafSpacing()
	{
		return vtkDendrogramItem_GetLeafSpacing_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDendrogramItem_GetLineWidth_17(HandleRef pThis);

	/// <summary>
	/// Get/Set how wide the edges of this dendrogram should be.  Default is one pixel.
	/// </summary>
	public virtual float GetLineWidth()
	{
		return vtkDendrogramItem_GetLineWidth_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDendrogramItem_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDendrogramItem_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDendrogramItem_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDendrogramItem_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDendrogramItem_GetOrientation_20(HandleRef pThis);

	/// <summary>
	/// Get the current tree orientation.
	/// </summary>
	public int GetOrientation()
	{
		return vtkDendrogramItem_GetOrientation_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDendrogramItem_GetPosition_21(HandleRef pThis);

	/// <summary>
	/// Get position of the dendrogram.
	/// </summary>
	public virtual float[] GetPosition()
	{
		IntPtr intPtr = vtkDendrogramItem_GetPosition_21(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_GetPosition_22(HandleRef pThis, ref float _arg1, ref float _arg2);

	/// <summary>
	/// Get position of the dendrogram.
	/// </summary>
	public virtual void GetPosition(ref float _arg1, ref float _arg2)
	{
		vtkDendrogramItem_GetPosition_22(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_GetPosition_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get position of the dendrogram.
	/// </summary>
	public virtual void GetPosition(IntPtr _arg)
	{
		vtkDendrogramItem_GetPosition_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDendrogramItem_GetPositionOfVertex_24(HandleRef pThis, string vertexName, IntPtr position);

	/// <summary>
	/// Find the position of the vertex with the specified name.  Store
	/// this information in the passed array.  Returns true if the vertex
	/// was found, false otherwise.
	/// </summary>
	public bool GetPositionOfVertex(string vertexName, IntPtr position)
	{
		return (vtkDendrogramItem_GetPositionOfVertex_24(GetCppThis(), vertexName, position) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDendrogramItem_GetPositionVector_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get position of the dendrogram.
	/// </summary>
	public vtkVector2f GetPositionVector()
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDendrogramItem_GetPositionVector_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDendrogramItem_GetPrunedTree_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the collapsed tree
	/// </summary>
	public vtkTree GetPrunedTree()
	{
		vtkTree vtkTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDendrogramItem_GetPrunedTree_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkDendrogramItem_GetTextAngleForOrientation_27(HandleRef pThis, int orientation);

	/// <summary>
	/// Get the angle that vertex labels should be rotated for the corresponding
	/// tree orientation.  For the default orientation (LEFT_TO_RIGHT), this
	/// is 0 degrees.
	/// </summary>
	public double GetTextAngleForOrientation(int orientation)
	{
		return vtkDendrogramItem_GetTextAngleForOrientation_27(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDendrogramItem_GetTree_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the tree that this item draws.
	/// </summary>
	public vtkTree GetTree()
	{
		vtkTree vtkTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDendrogramItem_GetTree_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern string vtkDendrogramItem_GetVertexNameArrayName_29(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of a vtkStringArray that specifies the names of the
	/// vertices of the input tree.  This array should be a part of the input
	/// tree's VertexData.  By default, this value is "node name", which is the
	/// name of the array created by vtkNewickTreeReader.
	/// </summary>
	public virtual string GetVertexNameArrayName()
	{
		return vtkDendrogramItem_GetVertexNameArrayName_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDendrogramItem_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDendrogramItem_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDendrogramItem_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDendrogramItem_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDendrogramItem_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDendrogramItem NewInstance()
	{
		vtkDendrogramItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDendrogramItem_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDendrogramItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDendrogramItem_Paint_34(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paints the input tree as a dendrogram.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkDendrogramItem_Paint_34(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_PrepareToPaint_35(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// This function calls RebuildBuffers() if necessary.
	/// Once PrepareToPaint() has been called, GetBounds() is guaranteed
	/// to provide useful information.
	/// </summary>
	public void PrepareToPaint(vtkContext2D painter)
	{
		vtkDendrogramItem_PrepareToPaint_35(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDendrogramItem_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDendrogramItem SafeDownCast(vtkObjectBase o)
	{
		vtkDendrogramItem vtkDendrogramItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDendrogramItem_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDendrogramItem_SetColorArray_37(HandleRef pThis, string arrayName);

	/// <summary>
	/// Indicate which array within the Tree's VertexData should be used to
	/// color the tree.  The specified array must be a vtkDoubleArray.
	/// By default, the tree will be drawn in black.
	/// </summary>
	public void SetColorArray(string arrayName)
	{
		vtkDendrogramItem_SetColorArray_37(GetCppThis(), arrayName);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetDisplayNumberOfCollapsedLeafNodes_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether or not the number of collapsed leaf nodes should be written
	/// inside the triangle representing a collapsed subtree.  Default is true.
	/// </summary>
	public virtual void SetDisplayNumberOfCollapsedLeafNodes(bool _arg)
	{
		vtkDendrogramItem_SetDisplayNumberOfCollapsedLeafNodes_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetDistanceArrayName_39(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the array that specifies the distance of each vertex
	/// from the root (NOT the vertex's parent).  This array should be a part of
	/// the input tree's VertexData.  By default, this value is "node weight",
	/// which is the name of the array created by vtkNewickTreeReader.
	/// </summary>
	public virtual void SetDistanceArrayName(string _arg)
	{
		vtkDendrogramItem_SetDistanceArrayName_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetDrawLabels_40(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether or not leaf nodes should be labeled by this class.
	/// Default is true.
	/// </summary>
	public virtual void SetDrawLabels(bool _arg)
	{
		vtkDendrogramItem_SetDrawLabels_40(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetExtendLeafNodes_41(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set whether or not leaf nodes should be extended so that they all line
	/// up vertically.  The default is to NOT extend leaf nodes.  When extending
	/// leaf nodes, the extra length is drawn in grey so as to distinguish it from
	/// the actual length of the leaf node.
	/// </summary>
	public virtual void SetExtendLeafNodes(bool _arg)
	{
		vtkDendrogramItem_SetExtendLeafNodes_41(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetLeafSpacing_42(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the spacing between the leaf nodes in our dendrogram.
	/// Default is 18 pixels.
	/// </summary>
	public virtual void SetLeafSpacing(double _arg)
	{
		vtkDendrogramItem_SetLeafSpacing_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetLineWidth_43(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set how wide the edges of this dendrogram should be.  Default is one pixel.
	/// </summary>
	public virtual void SetLineWidth(float _arg)
	{
		vtkDendrogramItem_SetLineWidth_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetOrientation_44(HandleRef pThis, int orientation);

	/// <summary>
	/// Set which way the tree should face within the visualization.  The default
	/// is for the tree to be drawn left to right.
	/// </summary>
	public void SetOrientation(int orientation)
	{
		vtkDendrogramItem_SetOrientation_44(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetPosition_45(HandleRef pThis, float _arg1, float _arg2);

	/// <summary>
	/// Set the position of the dendrogram.
	/// </summary>
	public virtual void SetPosition(float _arg1, float _arg2)
	{
		vtkDendrogramItem_SetPosition_45(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetPosition_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the position of the dendrogram.
	/// </summary>
	public void SetPosition(IntPtr _arg)
	{
		vtkDendrogramItem_SetPosition_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetPosition_47(HandleRef pThis, HandleRef pos);

	/// <summary>
	/// Set the position of the dendrogram.
	/// </summary>
	public void SetPosition(vtkVector2f pos)
	{
		vtkDendrogramItem_SetPosition_47(GetCppThis(), pos?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetTree_48(HandleRef pThis, HandleRef tree);

	/// <summary>
	/// Set the tree that this item draws.  Note that this tree's vertex data
	/// must contain a vtkStringArray called "node name".  The vtkNewickTreeReader
	/// automatically creates this required array for you.
	/// </summary>
	public virtual void SetTree(vtkTree tree)
	{
		vtkDendrogramItem_SetTree_48(GetCppThis(), tree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDendrogramItem_SetVertexNameArrayName_49(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of a vtkStringArray that specifies the names of the
	/// vertices of the input tree.  This array should be a part of the input
	/// tree's VertexData.  By default, this value is "node name", which is the
	/// name of the array created by vtkNewickTreeReader.
	/// </summary>
	public virtual void SetVertexNameArrayName(string _arg)
	{
		vtkDendrogramItem_SetVertexNameArrayName_49(GetCppThis(), _arg);
	}
}
