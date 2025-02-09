using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIncrementalOctreeNode
/// </summary>
/// <remarks>
///    Octree node constituting incremental
///  octree (in support of both point location and point insertion)
///
///
///  Octree nodes serve as spatial sub-division primitives to build the search
///  structure of an incremental octree in a recursive top-down manner. The
///  hierarchy takes the form of a tree-like representation by which a parent
///  node contains eight mutually non-overlapping child nodes. Each child is
///  assigned with an axis-aligned rectangular volume (Spatial Bounding Box)
///  and the eight children together cover exactly the same region as governed
///  by their parent. The eight child nodes / octants are ordered as
///
///  { (xBBoxMin, xBBoxMid] &amp; (yBBoxMin, yBBoxMid] &amp; (zBBoxMin, zBBoxMid] },
///  { (xBBoxMid, xBBoxMax] &amp; (yBBoxMin, yBBoxMid] &amp; (zBBoxMin, zBBoxMid] },
///  { (xBBoxMin, xBBoxMid] &amp; (yBBoxMid, yBBoxMax] &amp; (zBBoxMin, zBBoxMid] },
///  { (xBBoxMid, xBBoxMax] &amp; (yBBoxMid, yBBoxMax] &amp; (zBBoxMin, zBBoxMid] },
///  { (xBBoxMin, xBBoxMid] &amp; (yBBoxMin, yBBoxMid] &amp; (zBBoxMid, zBBoxMax] },
///  { (xBBoxMid, xBBoxMax] &amp; (yBBoxMin, yBBoxMid] &amp; (zBBoxMid, zBBoxMax] },
///  { (xBBoxMin, xBBoxMid] &amp; (yBBoxMid, yBBoxMax] &amp; (zBBoxMid, zBBoxMax] },
///  { (xBBoxMid, xBBoxMax] &amp; (yBBoxMid, yBBoxMax] &amp; (zBBoxMid, zBBoxMax] },
///
///  where { xrange &amp; yRange &amp; zRange } defines the region of each 3D octant.
///  In addition, the points falling within and registered, by means of point
///  indices, in the parent node are distributed to the child nodes for delegated
///  maintenance. In fact, only leaf nodes, i.e., those without any descendants,
///  actually store point indices while each node, regardless of a leaf or non-
///  leaf node, keeps a dynamically updated Data Bounding Box of the inhabitant
///  points, if any. Given a maximum number of points per leaf node, an octree
///  is initialized with an empty leaf node that is then recursively sub-divided,
///  but only on demand as points are incrementally inserted, to construct a
///  populated tree.
///
///  Please note that this octree node class is able to handle a large number
///  of EXACTLY duplicate points that is greater than the specified maximum
///  number of points per leaf node. In other words, as an exception, a leaf
///  node may maintain an arbitrary number of exactly duplicate points to deal
///  with possible extreme cases.
///
/// </remarks>
/// <seealso>
///
///  vtkIncrementalOctreePointLocator
/// </seealso>
public class vtkIncrementalOctreeNode : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalOctreeNode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIncrementalOctreeNode()
	{
		MRClassNameKey = "class vtkIncrementalOctreeNode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalOctreeNode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIncrementalOctreeNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIncrementalOctreeNode New()
	{
		vtkIncrementalOctreeNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreeNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIncrementalOctreeNode()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIncrementalOctreeNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_ContainsPoint_01(HandleRef pThis, IntPtr pnt);

	/// <summary>
	/// A point is in a node if and only if MinBounds[i] &lt; p[i] &lt;= MaxBounds[i],
	/// which allows a node to be divided into eight non-overlapping children.
	/// </summary>
	public int ContainsPoint(IntPtr pnt)
	{
		return vtkIncrementalOctreeNode_ContainsPoint_01(GetCppThis(), pnt);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_ContainsPointByData_02(HandleRef pThis, IntPtr pnt);

	/// <summary>
	/// A point is in a node, in terms of data, if and only if MinDataBounds[i]
	/// &lt;= p[i] &lt;= MaxDataBounds[i].
	/// </summary>
	public int ContainsPointByData(IntPtr pnt)
	{
		return vtkIncrementalOctreeNode_ContainsPointByData_02(GetCppThis(), pnt);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_DeleteChildNodes_03(HandleRef pThis);

	/// <summary>
	/// Delete the eight child nodes.
	/// </summary>
	public void DeleteChildNodes()
	{
		vtkIncrementalOctreeNode_DeleteChildNodes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_ExportAllPointIdsByDirectSet_04(HandleRef pThis, IntPtr pntIdx, HandleRef idList);

	/// <summary>
	/// Export all the indices of the points (contained in or under this node) by
	/// directly setting them in an allocated vtkIdList object. pntIdx indicates
	/// the starting location (in terms of vtkIdList) from which new point indices
	/// are added to vtkIdList by vtkIdList::SetId().
	/// </summary>
	public void ExportAllPointIdsByDirectSet(IntPtr pntIdx, vtkIdList idList)
	{
		vtkIncrementalOctreeNode_ExportAllPointIdsByDirectSet_04(GetCppThis(), pntIdx, idList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_ExportAllPointIdsByInsertion_05(HandleRef pThis, HandleRef idList);

	/// <summary>
	/// Export all the indices of the points (contained in or under this node) by
	/// inserting them to an allocated vtkIdList via vtkIdList::InsertNextId().
	/// </summary>
	public void ExportAllPointIdsByInsertion(vtkIdList idList)
	{
		vtkIncrementalOctreeNode_ExportAllPointIdsByInsertion_05(GetCppThis(), idList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_GetBounds_06(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the spatial bounding box of the node. The values are returned via
	/// an array in order of: x_min, x_max, y_min, y_max, z_min, z_max.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkIncrementalOctreeNode_GetBounds_06(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_GetChild_07(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get quick access to a child of this node. Note that this node is assumed
	/// to be a non-leaf one and no checking is performed on the node type.
	/// </summary>
	public vtkIncrementalOctreeNode GetChild(int i)
	{
		vtkIncrementalOctreeNode vtkIncrementalOctreeNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreeNode_GetChild_07(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalOctreeNode2 = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalOctreeNode2.Register(null);
			}
		}
		return vtkIncrementalOctreeNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_GetChildIndex_08(HandleRef pThis, IntPtr point);

	/// <summary>
	/// Determine which specific child / octant contains a given point. Note that
	/// the point is assumed to be inside this node and no checking is performed
	/// on the inside issue.
	/// </summary>
	public int GetChildIndex(IntPtr point)
	{
		return vtkIncrementalOctreeNode_GetChildIndex_08(GetCppThis(), point);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIncrementalOctreeNode_GetDistance2ToBoundary_09(HandleRef pThis, IntPtr point, HandleRef rootNode, int checkData);

	/// <summary>
	/// Compute the minimum squared distance from a point to this node, with all
	/// six boundaries considered. The data bounding box is checked if checkData
	/// is non-zero.
	/// </summary>
	public double GetDistance2ToBoundary(IntPtr point, vtkIncrementalOctreeNode rootNode, int checkData)
	{
		return vtkIncrementalOctreeNode_GetDistance2ToBoundary_09(GetCppThis(), point, rootNode?.GetCppThis() ?? default(HandleRef), checkData);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIncrementalOctreeNode_GetDistance2ToBoundary_10(HandleRef pThis, IntPtr point, IntPtr closest, HandleRef rootNode, int checkData);

	/// <summary>
	/// Compute the minimum squared distance from a point to this node, with all
	/// six boundaries considered. The data bounding box is checked if checkData
	/// is non-zero. The closest on-boundary point is returned via closest.
	/// </summary>
	public double GetDistance2ToBoundary(IntPtr point, IntPtr closest, vtkIncrementalOctreeNode rootNode, int checkData)
	{
		return vtkIncrementalOctreeNode_GetDistance2ToBoundary_10(GetCppThis(), point, closest, rootNode?.GetCppThis() ?? default(HandleRef), checkData);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIncrementalOctreeNode_GetDistance2ToInnerBoundary_11(HandleRef pThis, IntPtr point, HandleRef rootNode);

	/// <summary>
	/// Given a point inside this node, get the minimum squared distance to all
	/// inner boundaries. An inner boundary is a node's face that is shared by
	/// another non-root node.
	/// </summary>
	public double GetDistance2ToInnerBoundary(IntPtr point, vtkIncrementalOctreeNode rootNode)
	{
		return vtkIncrementalOctreeNode_GetDistance2ToInnerBoundary_11(GetCppThis(), point, rootNode?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_GetID_12(HandleRef pThis);

	/// <summary>
	/// Returns the ID of this node which is the index of the node in the
	/// octree. The index of the node enables users of this class to
	/// associate additional information with each node.
	/// </summary>
	public int GetID()
	{
		return vtkIncrementalOctreeNode_GetID_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_GetMaxBounds_13(HandleRef pThis);

	/// <summary>
	/// Get access to MaxBounds. Do not free this pointer.
	/// </summary>
	public virtual double[] GetMaxBounds()
	{
		IntPtr intPtr = vtkIncrementalOctreeNode_GetMaxBounds_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_GetMaxBounds_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get access to MaxBounds. Do not free this pointer.
	/// </summary>
	public virtual void GetMaxBounds(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkIncrementalOctreeNode_GetMaxBounds_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_GetMaxBounds_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get access to MaxBounds. Do not free this pointer.
	/// </summary>
	public virtual void GetMaxBounds(IntPtr _arg)
	{
		vtkIncrementalOctreeNode_GetMaxBounds_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_GetMaxDataBounds_16(HandleRef pThis);

	/// <summary>
	/// Get access to MaxDataBounds. Note that MaxDataBounds is not valid until
	/// point insertion.
	/// </summary>
	public IntPtr GetMaxDataBounds()
	{
		return vtkIncrementalOctreeNode_GetMaxDataBounds_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_GetMinBounds_17(HandleRef pThis);

	/// <summary>
	/// Get access to MinBounds. Do not free this pointer.
	/// </summary>
	public virtual double[] GetMinBounds()
	{
		IntPtr intPtr = vtkIncrementalOctreeNode_GetMinBounds_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_GetMinBounds_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get access to MinBounds. Do not free this pointer.
	/// </summary>
	public virtual void GetMinBounds(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkIncrementalOctreeNode_GetMinBounds_18(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_GetMinBounds_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get access to MinBounds. Do not free this pointer.
	/// </summary>
	public virtual void GetMinBounds(IntPtr _arg)
	{
		vtkIncrementalOctreeNode_GetMinBounds_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_GetMinDataBounds_20(HandleRef pThis);

	/// <summary>
	/// Get access to MinDataBounds. Note that MinDataBounds is not valid until
	/// point insertion.
	/// </summary>
	public IntPtr GetMinDataBounds()
	{
		return vtkIncrementalOctreeNode_GetMinDataBounds_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreeNode_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIncrementalOctreeNode_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreeNode_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIncrementalOctreeNode_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_GetNumberOfLevels_23(HandleRef pThis);

	/// <summary>
	/// Computes and returns the maximum level of the tree. If a tree has
	/// one node it returns 1 else it returns the maximum level of its
	/// children plus 1.
	/// </summary>
	public int GetNumberOfLevels()
	{
		return vtkIncrementalOctreeNode_GetNumberOfLevels_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_GetNumberOfPoints_24(HandleRef pThis);

	/// <summary>
	/// Get the number of points inside or under this node.
	/// </summary>
	public virtual int GetNumberOfPoints()
	{
		return vtkIncrementalOctreeNode_GetNumberOfPoints_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_GetPointIdSet_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the list of point indices, nullptr for a non-leaf node.
	/// </summary>
	public virtual vtkIdList GetPointIdSet()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreeNode_GetPointIdSet_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdList2 = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdList2.Register(null);
			}
		}
		return vtkIdList2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_GetPointIds_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ID of this node which is the index of the node in the
	/// octree. The index of the node enables users of this class to
	/// associate additional information with each node.
	/// </summary>
	public vtkIdList GetPointIds()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreeNode_GetPointIds_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdList2 = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdList2.Register(null);
			}
		}
		return vtkIdList2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_InsertPoint_27(HandleRef pThis, HandleRef points, IntPtr newPnt, int maxPts, IntPtr pntId, int ptMode, ref int numberOfNodes);

	/// <summary>
	/// This function is called after a successful point-insertion check and
	/// only applies to a leaf node. Prior to a call to this function, the
	/// octree should have been retrieved top-down to find the specific leaf
	/// node in which this new point (newPt) will be inserted. The actual index
	/// of the new point (to be inserted to points) is stored in pntId. Argument
	/// ptMode specifies whether the point is not inserted at all but instead only
	/// the point index is provided upon 0, the point is inserted via vtkPoints::
	/// InsertPoint() upon 1, or it is inserted via vtkPoints::InsertNextPoint()
	/// upon 2. For case 0, pntId needs to be specified. For cases 1 and 2, the
	/// actual point index is returned via pntId. Note that this function always
	/// returns 1 to indicate the success of point insertion.
	/// numberOfNodes is the number of nodes present in the tree at this time.
	/// it is used to assign an ID to each node which can be used to associate
	/// application specific information with each node. It is updated if new nodes
	/// are added to the tree.
	/// </summary>
	public int InsertPoint(vtkPoints points, IntPtr newPnt, int maxPts, IntPtr pntId, int ptMode, ref int numberOfNodes)
	{
		return vtkIncrementalOctreeNode_InsertPoint_27(GetCppThis(), points?.GetCppThis() ?? default(HandleRef), newPnt, maxPts, pntId, ptMode, ref numberOfNodes);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIncrementalOctreeNode_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_IsLeaf_29(HandleRef pThis);

	/// <summary>
	/// Determine whether or not this node is a leaf.
	/// </summary>
	public int IsLeaf()
	{
		return vtkIncrementalOctreeNode_IsLeaf_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreeNode_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIncrementalOctreeNode_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIncrementalOctreeNode NewInstance()
	{
		vtkIncrementalOctreeNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreeNode_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreeNode_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIncrementalOctreeNode SafeDownCast(vtkObjectBase o)
	{
		vtkIncrementalOctreeNode vtkIncrementalOctreeNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreeNode_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalOctreeNode2 = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalOctreeNode2.Register(null);
			}
		}
		return vtkIncrementalOctreeNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreeNode_SetBounds_34(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

	/// <summary>
	/// Set the spatial bounding box of the node. This function sets a default
	/// data bounding box.
	/// </summary>
	public void SetBounds(double x1, double x2, double y1, double y2, double z1, double z2)
	{
		vtkIncrementalOctreeNode_SetBounds_34(GetCppThis(), x1, x2, y1, y2, z1, z2);
	}
}
