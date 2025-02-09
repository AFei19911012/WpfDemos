using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIncrementalOctreePointLocator
/// </summary>
/// <remarks>
///    Incremental octree in support
///  of both point location and point insertion.
///
///
///  As opposed to the uniform bin-based search structure (adopted in class
///  vtkPointLocator) with a fixed spatial resolution, an octree mechanism
///  employs a hierarchy of tree-like sub-division of the 3D data domain. Thus
///  it enables data-aware multi-resolution and accordingly accelerated point
///  location as well as insertion, particularly when handling a radically
///  imbalanced layout of points as not uncommon in datasets defined on
///  adaptive meshes. Compared to a static point locator supporting pure
///  location functionalities through some search structure established from
///  a fixed set of points, an incremental point locator allows for, in addition,
///  point insertion capabilities, with the search structure maintaining a
///  dynamically increasing number of points.
///  Class vtkIncrementalOctreePointLocator is an octree-based accelerated
///  implementation of the functionalities of the uniform bin-based incremental
///  point locator vtkPointLocator. For point location, an octree is built by
///  accessing a vtkDataSet, specifically a vtkPointSet. For point insertion,
///  an empty octree is inited and then incrementally populated as points are
///  inserted. Three increasingly complex point insertion modes, i.e., direct
///  check-free insertion, zero tolerance insertion, and non-zero tolerance
///  insertion, are supported. In fact, the octree used in the point location
///  mode is actually constructed via direct check-free point insertion. This
///  class also provides a polygonal representation of the octree boundary.
///
/// </remarks>
/// <seealso>
///
///  vtkAbstractPointLocator, vtkIncrementalPointLocator, vtkPointLocator,
///  vtkMergePoints
/// </seealso>
public class vtkIncrementalOctreePointLocator : vtkIncrementalPointLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalOctreePointLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIncrementalOctreePointLocator()
	{
		MRClassNameKey = "class vtkIncrementalOctreePointLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalOctreePointLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIncrementalOctreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIncrementalOctreePointLocator New()
	{
		vtkIncrementalOctreePointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIncrementalOctreePointLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIncrementalOctreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkIncrementalOctreePointLocator_BuildCubicOctreeOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the search octree is built as a cubic shape or not.
	/// </summary>
	public virtual void BuildCubicOctreeOff()
	{
		vtkIncrementalOctreePointLocator_BuildCubicOctreeOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_BuildCubicOctreeOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the search octree is built as a cubic shape or not.
	/// </summary>
	public virtual void BuildCubicOctreeOn()
	{
		vtkIncrementalOctreePointLocator_BuildCubicOctreeOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_BuildLocator_03(HandleRef pThis);

	/// <summary>
	/// Load points from a dataset to construct an octree for point location.
	/// This function resorts to InitPointInsertion() to fulfill some of the work.
	/// This will NOT do anything if UseExistingSearchStructure is on.
	/// </summary>
	public override void BuildLocator()
	{
		vtkIncrementalOctreePointLocator_BuildLocator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_FindClosestInsertedPoint_04(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a point x assumed to be covered by the octree, return the index of
	/// the closest in-octree point regardless of the associated minimum squared
	/// distance relative to the squared insertion-tolerance distance. This method
	/// is used when performing incremental point insertion. Note -1 indicates that
	/// no point is found. InitPointInsertion() should have been called in advance.
	/// </summary>
	public override long FindClosestInsertedPoint(IntPtr x)
	{
		return vtkIncrementalOctreePointLocator_FindClosestInsertedPoint_04(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_FindClosestNPoints_05(HandleRef pThis, int N, IntPtr x, HandleRef result);

	/// <summary>
	/// Find the closest N points to a given point. The returned point ids (via
	/// result) are sorted from closest to farthest. BuildLocator() should have
	/// been called prior to this function. This method is thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread first.
	/// </summary>
	public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
	{
		vtkIncrementalOctreePointLocator_FindClosestNPoints_05(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_06(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Given a point x, return the id of the closest point. BuildLocator() should
	/// have been called prior to this function. This method is thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread first.
	/// </summary>
	public override long FindClosestPoint(IntPtr x)
	{
		return vtkIncrementalOctreePointLocator_FindClosestPoint_06(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_07(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Given a point (x, y, z), return the id of the closest point. Note that
	/// BuildLocator() should have been called prior to this function. This method
	/// is thread safe if BuildLocator() is directly or indirectly called from a
	/// single thread first.
	/// </summary>
	public new virtual long FindClosestPoint(double x, double y, double z)
	{
		return vtkIncrementalOctreePointLocator_FindClosestPoint_07(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_08(HandleRef pThis, IntPtr x, IntPtr miniDist2);

	/// <summary>
	/// Given a point x, return the id of the closest point and the associated
	/// minimum squared distance (via miniDist2). Note BuildLocator() should have
	/// been called prior to this function. This method is thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread first.
	/// </summary>
	public virtual long FindClosestPoint(IntPtr x, IntPtr miniDist2)
	{
		return vtkIncrementalOctreePointLocator_FindClosestPoint_08(GetCppThis(), x, miniDist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_09(HandleRef pThis, double x, double y, double z, IntPtr miniDist2);

	/// <summary>
	/// Given a point (x, y, z), return the id of the closest point and the
	/// associated minimum squared distance (via miniDist2). BuildLocator() should
	/// have been called prior to this function. This method is thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread first.
	/// </summary>
	public virtual long FindClosestPoint(double x, double y, double z, IntPtr miniDist2)
	{
		return vtkIncrementalOctreePointLocator_FindClosestPoint_09(GetCppThis(), x, y, z, miniDist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_FindClosestPointWithinRadius_10(HandleRef pThis, double radius, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a point x and a radius, return the id of the closest point within
	/// the radius and the associated minimum squared distance (via dist2, this
	/// returned distance is valid only if the point id is not -1). Note that
	/// BuildLocator() should have been called prior to this function. This method
	/// is thread safe if BuildLocator() is directly or indirectly called from a
	/// single thread first.
	/// </summary>
	public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
	{
		return vtkIncrementalOctreePointLocator_FindClosestPointWithinRadius_10(GetCppThis(), radius, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_FindClosestPointWithinSquaredRadius_11(HandleRef pThis, double radius2, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a point x and a squared radius radius2, return the id of the closest
	/// point within the radius and the associated minimum squared distance (via
	/// dist2, note this returned distance is valid only if the point id is not
	/// -1). BuildLocator() should have been called prior to this function.This
	/// method is thread safe if BuildLocator() is directly or indirectly called
	/// from a single thread first.
	/// </summary>
	public long FindClosestPointWithinSquaredRadius(double radius2, IntPtr x, ref double dist2)
	{
		return vtkIncrementalOctreePointLocator_FindClosestPointWithinSquaredRadius_11(GetCppThis(), radius2, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_FindPointsWithinRadius_12(HandleRef pThis, double R, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a radius R relative to a given point x. The returned
	/// point ids (stored in result) are not sorted in any way. BuildLocator() should
	/// have been called prior to this function. This method is thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread first.
	/// </summary>
	public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
	{
		vtkIncrementalOctreePointLocator_FindPointsWithinRadius_12(GetCppThis(), R, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_FindPointsWithinSquaredRadius_13(HandleRef pThis, double R2, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a squared radius R2 relative to a given point x. The
	/// returned point ids (stored in result) are not sorted in any way. BuildLocator()
	/// should have been called prior to this function. This method is thread safe if
	/// BuildLocator() is directly or indirectly called from a single thread first.
	/// </summary>
	public void FindPointsWithinSquaredRadius(double R2, IntPtr x, vtkIdList result)
	{
		vtkIncrementalOctreePointLocator_FindPointsWithinSquaredRadius_13(GetCppThis(), R2, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_ForceBuildLocator_14(HandleRef pThis);

	/// <summary>
	/// Build the locator from the input dataset (even if UseExistingSearchStructure is on).
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkIncrementalOctreePointLocator_ForceBuildLocator_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_FreeSearchStructure_15(HandleRef pThis);

	/// <summary>
	/// Delete the octree search structure.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkIncrementalOctreePointLocator_FreeSearchStructure_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_GenerateRepresentation_16(HandleRef pThis, int level, HandleRef polysData);

	/// <summary>
	/// Create a polygonal representation of the octree 'level': for each node
	/// on the specified level we generate six faces for the bounding box of the node.
	/// We also include a cell attribute that specifies the Index of the node.
	/// The second version of this function, generates user defined boundaries
	/// provided by 'GetBounds'. This function takes as parameters a user defined
	/// opaque 'data', the current node, and a pointer to where to write the 'bounds'.
	/// The function returns true if we want to generate the representation for this node,
	/// and false otherwise. A user can store data associated with a node using
	/// the node index.
	/// @see vtkIncrementalOctreeNode::GetIndex
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData polysData)
	{
		vtkIncrementalOctreePointLocator_GenerateRepresentation_16(GetCppThis(), level, polysData?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_GetBounds_17(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the spatial bounding box of the octree.
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkIncrementalOctreePointLocator_GetBounds_17(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreePointLocator_GetBounds_18(HandleRef pThis);

	/// <summary>
	/// Get the spatial bounding box of the octree.
	/// </summary>
	public override IntPtr GetBounds()
	{
		return vtkIncrementalOctreePointLocator_GetBounds_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_GetBuildCubicOctree_19(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the search octree is built as a cubic shape or not.
	/// </summary>
	public virtual int GetBuildCubicOctree()
	{
		return vtkIncrementalOctreePointLocator_GetBuildCubicOctree_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreePointLocator_GetLocatorPoints_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get access to the vtkPoints object in which point coordinates are stored
	/// for either point location or point insertion.
	/// </summary>
	public virtual vtkPoints GetLocatorPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreePointLocator_GetLocatorPoints_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_GetMaxPointsPerLeaf_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of points that a leaf node may maintain.
	/// Note that the actual number of points maintained by a leaf node might
	/// exceed this threshold if there is a large number (equal to or greater
	/// than the threshold) of exactly duplicate points (with zero distance)
	/// to be inserted (e.g., to construct an octree for subsequent point
	/// location) in extreme cases. Respecting this threshold in such scenarios
	/// would cause endless node sub-division. Thus this threshold is broken, but
	/// only in case of such situations.
	/// </summary>
	public virtual int GetMaxPointsPerLeaf()
	{
		return vtkIncrementalOctreePointLocator_GetMaxPointsPerLeaf_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_GetNumberOfGenerationsFromBase_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIncrementalOctreePointLocator_GetNumberOfGenerationsFromBase_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_GetNumberOfGenerationsFromBaseType_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIncrementalOctreePointLocator_GetNumberOfGenerationsFromBaseType_23(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_GetNumberOfLevels_24(HandleRef pThis);

	/// <summary>
	/// Returns the maximum level of the tree. If a tree has one node it returns 1
	/// else it returns the maximum level of its children plus 1.
	/// </summary>
	public int GetNumberOfLevels()
	{
		return vtkIncrementalOctreePointLocator_GetNumberOfLevels_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_GetNumberOfNodes_25(HandleRef pThis);

	/// <summary>
	/// Get number of nodes in the tree.
	/// </summary>
	public virtual int GetNumberOfNodes()
	{
		return vtkIncrementalOctreePointLocator_GetNumberOfNodes_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_GetNumberOfPoints_26(HandleRef pThis);

	/// <summary>
	/// Get the number of points maintained by the octree.
	/// </summary>
	public int GetNumberOfPoints()
	{
		return vtkIncrementalOctreePointLocator_GetNumberOfPoints_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreePointLocator_GetRoot_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// "Insert" a point to the octree without any checking. Argument insert means
	/// whether vtkPoints::InsertNextPoint() upon 1 is called or the point itself
	/// is not inserted to the vtkPoints at all but instead only the point index is
	/// inserted to a vtkIdList upon 0. For case 0, the point index needs to be
	/// specified via pntId. For case 1, the actual point index is returned via
	/// pntId. InitPointInsertion() should have been called.
	/// </summary>
	public vtkIncrementalOctreeNode GetRoot()
	{
		vtkIncrementalOctreeNode vtkIncrementalOctreeNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreePointLocator_GetRoot_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkIncrementalOctreePointLocator_InitPointInsertion_28(HandleRef pThis, HandleRef points, IntPtr bounds);

	/// <summary>
	/// Initialize the point insertion process. points is an object, storing 3D
	/// point coordinates, to which incremental point insertion put coordinates.
	/// It is created and provided by an external VTK class. Argument bounds
	/// represents the spatial bounding box, into which the points fall. In fact,
	/// an adjusted version of the bounding box is used to build the octree to
	/// make sure no any point (to be inserted) falls outside the octree. This
	/// function is not thread safe.
	/// </summary>
	public override int InitPointInsertion(vtkPoints points, IntPtr bounds)
	{
		return vtkIncrementalOctreePointLocator_InitPointInsertion_28(GetCppThis(), points?.GetCppThis() ?? default(HandleRef), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_InitPointInsertion_29(HandleRef pThis, HandleRef points, IntPtr bounds, long estSize);

	/// <summary>
	/// Initialize the point insertion process. points is an object, storing 3D
	/// point coordinates, to which incremental point insertion put coordinates.
	/// It is created and provided by an external VTK class. Argument bounds
	/// represents the spatial bounding box, into which the points fall. In fact,
	/// an adjusted version of the bounding box is used to build the octree to
	/// make sure no any point (to be inserted) falls outside the octree. Argument
	/// estSize specifies the initial estimated size of the vtkPoints object. This
	/// function is not thread safe.
	/// </summary>
	public override int InitPointInsertion(vtkPoints points, IntPtr bounds, long estSize)
	{
		return vtkIncrementalOctreePointLocator_InitPointInsertion_29(GetCppThis(), points?.GetCppThis() ?? default(HandleRef), bounds, estSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_Initialize_30(HandleRef pThis);

	/// <summary>
	/// Delete the octree search structure.
	/// </summary>
	public override void Initialize()
	{
		vtkIncrementalOctreePointLocator_Initialize_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_InsertNextPoint_31(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Insert a given point into the octree and return the point index. Note that
	/// InitPointInsertion() should have been called prior to this function. In
	/// addition, IsInsertedPoint() should have been called in advance to ensure
	/// that the given point has not been inserted unless point duplication is
	/// allowed (in this case, this function involves a repeated leaf container
	/// location). vtkPoints::InsertNextPoint() is invoked.
	/// </summary>
	public override long InsertNextPoint(IntPtr x)
	{
		return vtkIncrementalOctreePointLocator_InsertNextPoint_31(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_InsertPoint_32(HandleRef pThis, long ptId, IntPtr x);

	/// <summary>
	/// Insert a given point into the octree with a specified point index ptId.
	/// InitPointInsertion() should have been called prior to this function. In
	/// addition, IsInsertedPoint() should have been called in advance to ensure
	/// that the given point has not been inserted unless point duplication is
	/// allowed (Note that in this case, this function involves a repeated leaf
	/// container location). vtkPoints::InsertPoint() is invoked.
	/// </summary>
	public override void InsertPoint(long ptId, IntPtr x)
	{
		vtkIncrementalOctreePointLocator_InsertPoint_32(GetCppThis(), ptId, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_InsertPointWithoutChecking_33(HandleRef pThis, IntPtr point, ref long pntId, int insert);

	/// <summary>
	/// "Insert" a point to the octree without any checking. Argument insert means
	/// whether vtkPoints::InsertNextPoint() upon 1 is called or the point itself
	/// is not inserted to the vtkPoints at all but instead only the point index is
	/// inserted to a vtkIdList upon 0. For case 0, the point index needs to be
	/// specified via pntId. For case 1, the actual point index is returned via
	/// pntId. InitPointInsertion() should have been called.
	/// </summary>
	public void InsertPointWithoutChecking(IntPtr point, ref long pntId, int insert)
	{
		vtkIncrementalOctreePointLocator_InsertPointWithoutChecking_33(GetCppThis(), point, ref pntId, insert);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_InsertUniquePoint_34(HandleRef pThis, IntPtr point, ref long pntId);

	/// <summary>
	/// Insert a point to the octree unless there has been a duplicate point.
	/// Whether the point is actually inserted (return 1) or not (return 0 upon a
	/// rejection by an existing duplicate), the index of the point (either new
	/// or the duplicate) is returned via pntId. Note that InitPointInsertion()
	/// should have been called prior to this function. vtkPoints::InsertNextPoint()
	/// is invoked. This method is not thread safe.
	/// </summary>
	public override int InsertUniquePoint(IntPtr point, ref long pntId)
	{
		return vtkIncrementalOctreePointLocator_InsertUniquePoint_34(GetCppThis(), point, ref pntId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIncrementalOctreePointLocator_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_IsInsertedPoint_36(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Determine whether or not a given point has been inserted into the octree.
	/// Return the id of the already inserted point if true, otherwise return -1.
	/// InitPointInsertion() should have been called in advance.
	/// </summary>
	public override long IsInsertedPoint(IntPtr x)
	{
		return vtkIncrementalOctreePointLocator_IsInsertedPoint_36(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalOctreePointLocator_IsInsertedPoint_37(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Determine whether or not a given point has been inserted into the octree.
	/// Return the id of the already inserted point if true, otherwise return -1.
	/// InitPointInsertion() should have been called in advance.
	/// </summary>
	public override long IsInsertedPoint(double x, double y, double z)
	{
		return vtkIncrementalOctreePointLocator_IsInsertedPoint_37(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalOctreePointLocator_IsTypeOf_38(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIncrementalOctreePointLocator_IsTypeOf_38(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreePointLocator_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIncrementalOctreePointLocator NewInstance()
	{
		vtkIncrementalOctreePointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreePointLocator_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalOctreePointLocator_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIncrementalOctreePointLocator SafeDownCast(vtkObjectBase o)
	{
		vtkIncrementalOctreePointLocator vtkIncrementalOctreePointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalOctreePointLocator_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalOctreePointLocator2 = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalOctreePointLocator2.Register(null);
			}
		}
		return vtkIncrementalOctreePointLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_SetBuildCubicOctree_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether the search octree is built as a cubic shape or not.
	/// </summary>
	public virtual void SetBuildCubicOctree(int _arg)
	{
		vtkIncrementalOctreePointLocator_SetBuildCubicOctree_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalOctreePointLocator_SetMaxPointsPerLeaf_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of points that a leaf node may maintain.
	/// Note that the actual number of points maintained by a leaf node might
	/// exceed this threshold if there is a large number (equal to or greater
	/// than the threshold) of exactly duplicate points (with zero distance)
	/// to be inserted (e.g., to construct an octree for subsequent point
	/// location) in extreme cases. Respecting this threshold in such scenarios
	/// would cause endless node sub-division. Thus this threshold is broken, but
	/// only in case of such situations.
	/// </summary>
	public virtual void SetMaxPointsPerLeaf(int _arg)
	{
		vtkIncrementalOctreePointLocator_SetMaxPointsPerLeaf_43(GetCppThis(), _arg);
	}
}
