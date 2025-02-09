using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKdTree
/// </summary>
/// <remarks>
///    a Kd-tree spatial decomposition of a set of points
///
///
///     Given one or more vtkDataSets, create a load balancing
///     k-d tree decomposition of the points at the center of the cells.
///     Or, create a k-d tree point locator from a list of points.
///
///     This class can also generate a PolyData representation of
///     the boundaries of the spatial regions in the decomposition.
///
///     It can sort the regions with respect to a viewing direction,
///     and it can decompose a list of regions into subsets, each
///     of which represent a convex spatial region (since many algorithms
///     require a convex region).
///
///     If the points were derived from cells, vtkKdTree
///     can create a list of cell Ids for each region for each data set.
///     Two lists are available - all cells with centroid in the region,
///     and all cells that intersect the region but whose centroid lies
///     in another region.
///
///     For the purpose of removing duplicate points quickly from large
///     data sets, or for finding nearby points, we added another mode for
///     building the locator.  BuildLocatorFromPoints will build a k-d tree
///     from one or more vtkPoints objects.  This can be followed by
///     BuildMapForDuplicatePoints which returns a mapping from the original
///     ids to a subset of the ids that is unique within a supplied
///     tolerance, or you can use FindPoint and FindClosestPoint to
///     locate points in the original set that the tree was built from.
///
/// </remarks>
/// <seealso>
///
///      vtkLocator vtkCellLocator vtkPKdTree
/// </seealso>
public class vtkKdTree : vtkLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKdTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKdTree()
	{
		MRClassNameKey = "class vtkKdTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKdTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKdTree New()
	{
		vtkKdTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKdTree()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKdTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkKdTree_AddDataSet_01(HandleRef pThis, HandleRef set);

	/// <summary>
	/// This class can compute a spatial decomposition based on the cells in a list
	/// of one or more input data sets.  Add them one at a time with this method.
	/// </summary>
	public virtual void AddDataSet(vtkDataSet set)
	{
		vtkKdTree_AddDataSet_01(GetCppThis(), set?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_AllGetRegionContainingCell_02(HandleRef pThis);

	/// <summary>
	/// Get a list (in order by data set by cell id) of the
	/// region IDs of the region containing the centroid for
	/// each cell.
	/// This is faster than calling GetRegionContainingCell
	/// for each cell in the DataSet.
	/// vtkKdTree uses this list, so don't delete it.
	/// </summary>
	public IntPtr AllGetRegionContainingCell()
	{
		return vtkKdTree_AllGetRegionContainingCell_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_BuildLocator_03(HandleRef pThis);

	/// <summary>
	/// Create the k-d tree decomposition of the cells of the data set
	/// or data sets.  Cells are assigned to k-d tree spatial regions
	/// based on the location of their centroids.
	/// </summary>
	public override void BuildLocator()
	{
		vtkKdTree_BuildLocator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_BuildLocatorFromPoints_04(HandleRef pThis, HandleRef pointset);

	/// <summary>
	/// This is a special purpose locator that builds a k-d tree to
	/// find duplicate and near-by points.  It builds the tree from
	/// one or more vtkPoints objects instead of from the cells of
	/// a vtkDataSet.  This build would normally be followed by
	/// BuildMapForDuplicatePoints, FindPoint, or FindClosestPoint.
	/// Since this will build a normal k-d tree, all the region intersection
	/// queries will still work, as will most other calls except those that
	/// have "Cell" in the name.
	///
	/// This method works most efficiently when the point arrays are
	/// float arrays.
	/// </summary>
	public void BuildLocatorFromPoints(vtkPointSet pointset)
	{
		vtkKdTree_BuildLocatorFromPoints_04(GetCppThis(), pointset?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_BuildLocatorFromPoints_05(HandleRef pThis, HandleRef ptArray);

	/// <summary>
	/// This is a special purpose locator that builds a k-d tree to
	/// find duplicate and near-by points.  It builds the tree from
	/// one or more vtkPoints objects instead of from the cells of
	/// a vtkDataSet.  This build would normally be followed by
	/// BuildMapForDuplicatePoints, FindPoint, or FindClosestPoint.
	/// Since this will build a normal k-d tree, all the region intersection
	/// queries will still work, as will most other calls except those that
	/// have "Cell" in the name.
	///
	/// This method works most efficiently when the point arrays are
	/// float arrays.
	/// </summary>
	public void BuildLocatorFromPoints(vtkPoints ptArray)
	{
		vtkKdTree_BuildLocatorFromPoints_05(GetCppThis(), ptArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_BuildMapForDuplicatePoints_06(HandleRef pThis, float tolerance, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This call returns a mapping from the original point IDs supplied
	/// to BuildLocatorFromPoints to a subset of those IDs that is unique
	/// within the specified tolerance.
	/// If points 2, 5, and 12 are the same, then
	/// IdMap[2] = IdMap[5] = IdMap[12] = 2 (or 5 or 12).
	///
	/// "original point IDs" - For point IDs we start at 0 for the first
	/// point in the first vtkPoints object, and increase by 1 for subsequent
	/// points and subsequent vtkPoints objects.
	///
	/// You must have called BuildLocatorFromPoints() before calling this.
	/// You are responsible for deleting the returned array.
	/// </summary>
	public vtkIdTypeArray BuildMapForDuplicatePoints(float tolerance)
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_BuildMapForDuplicatePoints_06(GetCppThis(), tolerance, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_CopyTree_07(HandleRef kd, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a copy of the binary tree representation of the
	/// k-d tree spatial partitioning provided.
	/// </summary>
	public static vtkKdNode CopyTree(vtkKdNode kd)
	{
		vtkKdNode vtkKdNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_CopyTree_07(kd?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKdNode2 = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKdNode2.Register(null);
			}
		}
		return vtkKdNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_CreateCellLists_08(HandleRef pThis, int dataSetIndex, IntPtr regionReqList, int reqListSize);

	/// <summary>
	/// Create a list for each of the requested regions, listing
	/// the IDs of all cells whose centroid falls in the region.
	/// These lists are obtained with GetCellList().
	/// If no DataSet is specified, the cell list is created
	/// for DataSet 0.  If no list of requested regions is provided,
	/// the cell lists for all regions are created.
	///
	/// When CreateCellLists is called again, the lists created
	/// on the previous call are deleted.
	/// </summary>
	public void CreateCellLists(int dataSetIndex, IntPtr regionReqList, int reqListSize)
	{
		vtkKdTree_CreateCellLists_08(GetCppThis(), dataSetIndex, regionReqList, reqListSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_CreateCellLists_09(HandleRef pThis, HandleRef set, IntPtr regionReqList, int reqListSize);

	/// <summary>
	/// Create a list for each of the requested regions, listing
	/// the IDs of all cells whose centroid falls in the region.
	/// These lists are obtained with GetCellList().
	/// If no DataSet is specified, the cell list is created
	/// for DataSet 0.  If no list of requested regions is provided,
	/// the cell lists for all regions are created.
	///
	/// When CreateCellLists is called again, the lists created
	/// on the previous call are deleted.
	/// </summary>
	public void CreateCellLists(vtkDataSet set, IntPtr regionReqList, int reqListSize)
	{
		vtkKdTree_CreateCellLists_09(GetCppThis(), set?.GetCppThis() ?? default(HandleRef), regionReqList, reqListSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_CreateCellLists_10(HandleRef pThis, IntPtr regionReqList, int listSize);

	/// <summary>
	/// Create a list for each of the requested regions, listing
	/// the IDs of all cells whose centroid falls in the region.
	/// These lists are obtained with GetCellList().
	/// If no DataSet is specified, the cell list is created
	/// for DataSet 0.  If no list of requested regions is provided,
	/// the cell lists for all regions are created.
	///
	/// When CreateCellLists is called again, the lists created
	/// on the previous call are deleted.
	/// </summary>
	public void CreateCellLists(IntPtr regionReqList, int listSize)
	{
		vtkKdTree_CreateCellLists_10(GetCppThis(), regionReqList, listSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_CreateCellLists_11(HandleRef pThis);

	/// <summary>
	/// Create a list for each of the requested regions, listing
	/// the IDs of all cells whose centroid falls in the region.
	/// These lists are obtained with GetCellList().
	/// If no DataSet is specified, the cell list is created
	/// for DataSet 0.  If no list of requested regions is provided,
	/// the cell lists for all regions are created.
	///
	/// When CreateCellLists is called again, the lists created
	/// on the previous call are deleted.
	/// </summary>
	public void CreateCellLists()
	{
		vtkKdTree_CreateCellLists_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_DeleteCellLists_12(HandleRef pThis);

	/// <summary>
	/// Free the memory used by the cell lists.
	/// </summary>
	public void DeleteCellLists()
	{
		vtkKdTree_DeleteCellLists_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_FindClosestNPoints_13(HandleRef pThis, int N, IntPtr x, HandleRef result);

	/// <summary>
	/// Find the closest N points to a position. This returns the closest
	/// N points to a position. A faster method could be created that returned
	/// N close points to a position, but necessarily the exact N closest.
	/// The returned points are sorted from closest to farthest.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
	{
		vtkKdTree_FindClosestNPoints_13(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_FindClosestPoint_14(HandleRef pThis, IntPtr x, ref double dist2);

	/// <summary>
	/// Find the Id of the point that was previously supplied
	/// to BuildLocatorFromPoints() which is closest to the given point.
	/// Set the square of the distance between the two points.
	/// </summary>
	public long FindClosestPoint(IntPtr x, ref double dist2)
	{
		return vtkKdTree_FindClosestPoint_14(GetCppThis(), x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_FindClosestPoint_15(HandleRef pThis, double x, double y, double z, ref double dist2);

	/// <summary>
	/// Find the Id of the point that was previously supplied
	/// to BuildLocatorFromPoints() which is closest to the given point.
	/// Set the square of the distance between the two points.
	/// </summary>
	public long FindClosestPoint(double x, double y, double z, ref double dist2)
	{
		return vtkKdTree_FindClosestPoint_15(GetCppThis(), x, y, z, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_FindClosestPointInRegion_16(HandleRef pThis, int regionId, IntPtr x, ref double dist2);

	/// <summary>
	/// Find the Id of the point in the given region which is
	/// closest to the given point.  Return the ID of the point,
	/// and set the square of the distance of between the points.
	/// </summary>
	public long FindClosestPointInRegion(int regionId, IntPtr x, ref double dist2)
	{
		return vtkKdTree_FindClosestPointInRegion_16(GetCppThis(), regionId, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_FindClosestPointInRegion_17(HandleRef pThis, int regionId, double x, double y, double z, ref double dist2);

	/// <summary>
	/// Find the Id of the point in the given region which is
	/// closest to the given point.  Return the ID of the point,
	/// and set the square of the distance of between the points.
	/// </summary>
	public long FindClosestPointInRegion(int regionId, double x, double y, double z, ref double dist2)
	{
		return vtkKdTree_FindClosestPointInRegion_17(GetCppThis(), regionId, x, y, z, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_FindClosestPointWithinRadius_18(HandleRef pThis, double radius, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point
	/// closest to the point in that radius.
	/// dist2 returns the squared distance to the point.
	/// </summary>
	public long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
	{
		return vtkKdTree_FindClosestPointWithinRadius_18(GetCppThis(), radius, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_FindPoint_19(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Find the Id of the point that was previously supplied
	/// to BuildLocatorFromPoints().  Returns -1 if the point
	/// was not in the original array.
	/// </summary>
	public long FindPoint(IntPtr x)
	{
		return vtkKdTree_FindPoint_19(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_FindPoint_20(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Find the Id of the point that was previously supplied
	/// to BuildLocatorFromPoints().  Returns -1 if the point
	/// was not in the original array.
	/// </summary>
	public long FindPoint(double x, double y, double z)
	{
		return vtkKdTree_FindPoint_20(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_FindPointsInArea_21(HandleRef pThis, IntPtr area, HandleRef ids, byte clearArray);

	/// <summary>
	/// Fill ids with points found in area.  The area is a 6-tuple containing
	/// (xmin, xmax, ymin, ymax, zmin, zmax).
	/// This method will clear the array by default.  To append ids to an array,
	/// set clearArray to false.
	/// </summary>
	public void FindPointsInArea(IntPtr area, vtkIdTypeArray ids, bool clearArray)
	{
		vtkKdTree_FindPointsInArea_21(GetCppThis(), area, ids?.GetCppThis() ?? default(HandleRef), (byte)(clearArray ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_FindPointsWithinRadius_22(HandleRef pThis, double R, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a specified radius R of position x.
	/// The result is not sorted in any specific manner.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
	{
		vtkKdTree_FindPointsWithinRadius_22(GetCppThis(), R, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_ForceBuildLocator_23(HandleRef pThis);

	/// <summary>
	/// Build the locator from the input dataset (even if UseExistingSearchStructure is on).
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkKdTree_ForceBuildLocator_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_FreeSearchStructure_24(HandleRef pThis);

	/// <summary>
	/// Delete the k-d tree data structure. Also delete any
	/// cell lists that were computed with CreateCellLists().
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkKdTree_FreeSearchStructure_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_GenerateRepresentation_25(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Create a polydata representation of the boundaries of
	/// the k-d tree regions.  If level equals GetLevel(), the
	/// leaf nodes are represented.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkKdTree_GenerateRepresentation_25(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_GenerateRepresentation_26(HandleRef pThis, IntPtr regionList, int len, HandleRef pd);

	/// <summary>
	/// Generate a polygonal representation of a list of regions.
	/// Only leaf nodes have region IDs, so these will be leaf nodes.
	/// </summary>
	public void GenerateRepresentation(IntPtr regionList, int len, vtkPolyData pd)
	{
		vtkKdTree_GenerateRepresentation_26(GetCppThis(), regionList, len, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_GenerateRepresentationUsingDataBoundsOff_27(HandleRef pThis);

	/// <summary>
	/// The polydata representation of the k-d tree shows the boundaries
	/// of the k-d tree decomposition spatial regions.  The data inside
	/// the regions may not occupy the entire space.  To draw just the
	/// bounds of the data in the regions, set this variable ON.
	/// </summary>
	public virtual void GenerateRepresentationUsingDataBoundsOff()
	{
		vtkKdTree_GenerateRepresentationUsingDataBoundsOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_GenerateRepresentationUsingDataBoundsOn_28(HandleRef pThis);

	/// <summary>
	/// The polydata representation of the k-d tree shows the boundaries
	/// of the k-d tree decomposition spatial regions.  The data inside
	/// the regions may not occupy the entire space.  To draw just the
	/// bounds of the data in the regions, set this variable ON.
	/// </summary>
	public virtual void GenerateRepresentationUsingDataBoundsOn()
	{
		vtkKdTree_GenerateRepresentationUsingDataBoundsOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_GetBoundaryCellList_29(HandleRef pThis, int regionID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The cell list obtained with GetCellList is the list
	/// of all cells such that their centroid is contained in
	/// the spatial region.  It may also be desirable to get
	/// a list of all cells intersecting a spatial region,
	/// but with centroid in some other region.  This is that
	/// list.  This list is computed in CreateCellLists() if
	/// and only if IncludeRegionBoundaryCells is ON.  This
	/// returns a pointer to KdTree's memory, so don't free it.
	/// </summary>
	public vtkIdList GetBoundaryCellList(int regionID)
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_GetBoundaryCellList_29(GetCppThis(), regionID, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkKdTree_GetBounds_30(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the spatial bounds of the entire k-d tree space. Sets
	/// bounds array to xmin, xmax, ymin, ymax, zmin, zmax.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkKdTree_GetBounds_30(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_GetCellList_31(HandleRef pThis, int regionID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cell list for a region.  This returns a pointer
	/// to vtkKdTree's memory, so don't free it.
	/// </summary>
	public vtkIdList GetCellList(int regionID)
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_GetCellList_31(GetCppThis(), regionID, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkKdTree_GetCellLists_32(HandleRef pThis, HandleRef regions, int set, HandleRef inRegionCells, HandleRef onBoundaryCells);

	/// <summary>
	///
	/// For a list of regions, get two cell lists.  The first lists
	/// the IDs all cells whose centroids lie in one of the regions.
	/// The second lists the IDs of all cells that intersect the regions,
	/// but whose centroid lies in a region not on the list.
	///
	/// The total number of cell IDs written to both lists is returned.
	/// Either list pointer passed in can be nullptr, and it will be ignored.
	/// If there are multiple data sets, you must specify which data set
	/// you wish cell IDs for.
	///
	/// The caller should delete these two lists when done.  This method
	/// uses the cell lists created in CreateCellLists().
	/// If the cell list for any of the requested regions does not
	/// exist, then this method will call CreateCellLists() to create
	/// cell lists for *every* region of the k-d tree.  You must remember
	/// to DeleteCellLists() when done with all calls to this method, as
	/// cell lists can require a great deal of memory.
	/// </summary>
	public long GetCellLists(vtkIntArray regions, int set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
	{
		return vtkKdTree_GetCellLists_32(GetCppThis(), regions?.GetCppThis() ?? default(HandleRef), set, inRegionCells?.GetCppThis() ?? default(HandleRef), onBoundaryCells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_GetCellLists_33(HandleRef pThis, HandleRef regions, HandleRef set, HandleRef inRegionCells, HandleRef onBoundaryCells);

	/// <summary>
	///
	/// For a list of regions, get two cell lists.  The first lists
	/// the IDs all cells whose centroids lie in one of the regions.
	/// The second lists the IDs of all cells that intersect the regions,
	/// but whose centroid lies in a region not on the list.
	///
	/// The total number of cell IDs written to both lists is returned.
	/// Either list pointer passed in can be nullptr, and it will be ignored.
	/// If there are multiple data sets, you must specify which data set
	/// you wish cell IDs for.
	///
	/// The caller should delete these two lists when done.  This method
	/// uses the cell lists created in CreateCellLists().
	/// If the cell list for any of the requested regions does not
	/// exist, then this method will call CreateCellLists() to create
	/// cell lists for *every* region of the k-d tree.  You must remember
	/// to DeleteCellLists() when done with all calls to this method, as
	/// cell lists can require a great deal of memory.
	/// </summary>
	public long GetCellLists(vtkIntArray regions, vtkDataSet set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
	{
		return vtkKdTree_GetCellLists_33(GetCppThis(), regions?.GetCppThis() ?? default(HandleRef), set?.GetCppThis() ?? default(HandleRef), inRegionCells?.GetCppThis() ?? default(HandleRef), onBoundaryCells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_GetCellLists_34(HandleRef pThis, HandleRef regions, HandleRef inRegionCells, HandleRef onBoundaryCells);

	/// <summary>
	///
	/// For a list of regions, get two cell lists.  The first lists
	/// the IDs all cells whose centroids lie in one of the regions.
	/// The second lists the IDs of all cells that intersect the regions,
	/// but whose centroid lies in a region not on the list.
	///
	/// The total number of cell IDs written to both lists is returned.
	/// Either list pointer passed in can be nullptr, and it will be ignored.
	/// If there are multiple data sets, you must specify which data set
	/// you wish cell IDs for.
	///
	/// The caller should delete these two lists when done.  This method
	/// uses the cell lists created in CreateCellLists().
	/// If the cell list for any of the requested regions does not
	/// exist, then this method will call CreateCellLists() to create
	/// cell lists for *every* region of the k-d tree.  You must remember
	/// to DeleteCellLists() when done with all calls to this method, as
	/// cell lists can require a great deal of memory.
	/// </summary>
	public long GetCellLists(vtkIntArray regions, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
	{
		return vtkKdTree_GetCellLists_34(GetCppThis(), regions?.GetCppThis() ?? default(HandleRef), inRegionCells?.GetCppThis() ?? default(HandleRef), onBoundaryCells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_GetCuts_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a vtkBSPCuts object, a general object representing an axis-
	/// aligned spatial partitioning.  Used by vtkBSPIntersections.
	/// </summary>
	public virtual vtkBSPCuts GetCuts()
	{
		vtkBSPCuts vtkBSPCuts2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_GetCuts_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBSPCuts2 = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBSPCuts2.Register(null);
			}
		}
		return vtkBSPCuts2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_GetDataSet_36(HandleRef pThis, int n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the n'th data set.
	/// </summary>
	public vtkDataSet GetDataSet(int n)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_GetDataSet_36(GetCppThis(), n, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_GetDataSet_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the 0'th data set.  For compatibility with the superclass'
	/// interface.
	/// </summary>
	public override vtkDataSet GetDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_GetDataSet_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetDataSetIndex_38(HandleRef pThis, HandleRef set);

	/// <summary>
	/// Return the index of the given data set.  Returns -1 if that data
	/// set does not exist.
	/// </summary>
	public int GetDataSetIndex(vtkDataSet set)
	{
		return vtkKdTree_GetDataSetIndex_38(GetCppThis(), set?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_GetDataSets_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a collection of all the data sets.
	/// </summary>
	public virtual vtkDataSetCollection GetDataSets()
	{
		vtkDataSetCollection vtkDataSetCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_GetDataSets_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetCollection2 = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetCollection2.Register(null);
			}
		}
		return vtkDataSetCollection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKdTree_GetFudgeFactor_40(HandleRef pThis);

	/// <summary>
	/// Some algorithms on k-d trees require a value that is a very
	/// small distance relative to the diameter of the entire space
	/// divided by the k-d tree.  This factor is the maximum axis-aligned
	/// width of the space multiplied by 10e-6.
	/// </summary>
	public virtual double GetFudgeFactor()
	{
		return vtkKdTree_GetFudgeFactor_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetGenerateRepresentationUsingDataBounds_41(HandleRef pThis);

	/// <summary>
	/// The polydata representation of the k-d tree shows the boundaries
	/// of the k-d tree decomposition spatial regions.  The data inside
	/// the regions may not occupy the entire space.  To draw just the
	/// bounds of the data in the regions, set this variable ON.
	/// </summary>
	public virtual int GetGenerateRepresentationUsingDataBounds()
	{
		return vtkKdTree_GetGenerateRepresentationUsingDataBounds_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetIncludeRegionBoundaryCells_42(HandleRef pThis);

	/// <summary>
	/// If IncludeRegionBoundaryCells is ON,
	/// CreateCellLists() will also create a list of cells which
	/// intersect a given region, but are not assigned
	/// to the region.  These lists are obtained with
	/// GetBoundaryCellList().  Default is OFF.
	/// </summary>
	public virtual int GetIncludeRegionBoundaryCells()
	{
		return vtkKdTree_GetIncludeRegionBoundaryCells_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetMinCells_43(HandleRef pThis);

	/// <summary>
	/// Minimum number of cells per spatial region.  Default is 100.
	/// </summary>
	public virtual int GetMinCells()
	{
		return vtkKdTree_GetMinCells_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetNumberOfDataSets_44(HandleRef pThis);

	/// <summary>
	/// Get the number of data sets included in spatial partitioning
	/// </summary>
	public int GetNumberOfDataSets()
	{
		return vtkKdTree_GetNumberOfDataSets_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_GetNumberOfGenerationsFromBase_45(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKdTree_GetNumberOfGenerationsFromBase_45(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdTree_GetNumberOfGenerationsFromBaseType_46(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKdTree_GetNumberOfGenerationsFromBaseType_46(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetNumberOfRegions_47(HandleRef pThis);

	/// <summary>
	/// The number of leaf nodes of the tree, the spatial regions
	/// </summary>
	public virtual int GetNumberOfRegions()
	{
		return vtkKdTree_GetNumberOfRegions_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetNumberOfRegionsOrLess_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of spatial regions you want to get close
	/// to without going over.  (The number of spatial regions is normally
	/// a power of two.)  Call this before BuildLocator().  Default
	/// is unset (0).
	/// </summary>
	public virtual int GetNumberOfRegionsOrLess()
	{
		return vtkKdTree_GetNumberOfRegionsOrLess_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetNumberOfRegionsOrMore_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of spatial regions you want to get close
	/// to while having at least this many regions.  (The number of
	/// spatial regions is normally a power of two.)   Default
	/// is unset (0).
	/// </summary>
	public virtual int GetNumberOfRegionsOrMore()
	{
		return vtkKdTree_GetNumberOfRegionsOrMore_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_GetPointsInRegion_50(HandleRef pThis, int regionId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a list of the original IDs of all points in a region.  You
	/// must have called BuildLocatorFromPoints before calling this.
	/// </summary>
	public vtkIdTypeArray GetPointsInRegion(int regionId)
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_GetPointsInRegion_50(GetCppThis(), regionId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_GetRegionBounds_51(HandleRef pThis, int regionID, IntPtr bounds);

	/// <summary>
	/// Get the spatial bounds of k-d tree region
	/// </summary>
	public void GetRegionBounds(int regionID, IntPtr bounds)
	{
		vtkKdTree_GetRegionBounds_51(GetCppThis(), regionID, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetRegionContainingCell_52(HandleRef pThis, HandleRef set, long cellID);

	/// <summary>
	/// Get the id of the region containing the cell centroid.  If
	/// no DataSet is specified, assume DataSet 0.  If you need the
	/// region ID for every cell, use AllGetRegionContainingCell
	/// instead.  It is more efficient.
	/// </summary>
	public int GetRegionContainingCell(vtkDataSet set, long cellID)
	{
		return vtkKdTree_GetRegionContainingCell_52(GetCppThis(), set?.GetCppThis() ?? default(HandleRef), cellID);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetRegionContainingCell_53(HandleRef pThis, int set, long cellID);

	/// <summary>
	/// Get the id of the region containing the cell centroid.  If
	/// no DataSet is specified, assume DataSet 0.  If you need the
	/// region ID for every cell, use AllGetRegionContainingCell
	/// instead.  It is more efficient.
	/// </summary>
	public int GetRegionContainingCell(int set, long cellID)
	{
		return vtkKdTree_GetRegionContainingCell_53(GetCppThis(), set, cellID);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetRegionContainingCell_54(HandleRef pThis, long cellID);

	/// <summary>
	/// Get the id of the region containing the cell centroid.  If
	/// no DataSet is specified, assume DataSet 0.  If you need the
	/// region ID for every cell, use AllGetRegionContainingCell
	/// instead.  It is more efficient.
	/// </summary>
	public int GetRegionContainingCell(long cellID)
	{
		return vtkKdTree_GetRegionContainingCell_54(GetCppThis(), cellID);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetRegionContainingPoint_55(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the id of the region containing the specified location.
	/// </summary>
	public int GetRegionContainingPoint(double x, double y, double z)
	{
		return vtkKdTree_GetRegionContainingPoint_55(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_GetRegionDataBounds_56(HandleRef pThis, int regionID, IntPtr bounds);

	/// <summary>
	/// Get the bounds of the data within the k-d tree region
	/// </summary>
	public void GetRegionDataBounds(int regionID, IntPtr bounds)
	{
		vtkKdTree_GetRegionDataBounds_56(GetCppThis(), regionID, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_GetTiming_57(HandleRef pThis);

	/// <summary>
	/// Turn on timing of the k-d tree build
	/// </summary>
	public virtual int GetTiming()
	{
		return vtkKdTree_GetTiming_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_IncludeRegionBoundaryCellsOff_58(HandleRef pThis);

	/// <summary>
	/// If IncludeRegionBoundaryCells is ON,
	/// CreateCellLists() will also create a list of cells which
	/// intersect a given region, but are not assigned
	/// to the region.  These lists are obtained with
	/// GetBoundaryCellList().  Default is OFF.
	/// </summary>
	public virtual void IncludeRegionBoundaryCellsOff()
	{
		vtkKdTree_IncludeRegionBoundaryCellsOff_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_IncludeRegionBoundaryCellsOn_59(HandleRef pThis);

	/// <summary>
	/// If IncludeRegionBoundaryCells is ON,
	/// CreateCellLists() will also create a list of cells which
	/// intersect a given region, but are not assigned
	/// to the region.  These lists are obtained with
	/// GetBoundaryCellList().  Default is OFF.
	/// </summary>
	public virtual void IncludeRegionBoundaryCellsOn()
	{
		vtkKdTree_IncludeRegionBoundaryCellsOn_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_InvalidateGeometry_60(HandleRef pThis);

	/// <summary>
	/// Forget about the last geometry used.  The next call to NewGeometry will
	/// return 1.  A new k-d tree will be built the next time BuildLocator is
	/// called.
	/// </summary>
	public virtual void InvalidateGeometry()
	{
		vtkKdTree_InvalidateGeometry_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_IsA_61(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKdTree_IsA_61(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_IsTypeOf_62(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKdTree_IsTypeOf_62(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_NewGeometry_64(HandleRef pThis);

	/// <summary>
	/// Return 1 if the geometry of the input data sets
	/// has changed since the last time the k-d tree was built.
	/// </summary>
	public virtual int NewGeometry()
	{
		return vtkKdTree_NewGeometry_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_NewInstance_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKdTree NewInstance()
	{
		vtkKdTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_NewInstance_65(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_OmitNoPartitioning_66(HandleRef pThis);

	/// <summary>
	/// Partition along all three axes - this is the default
	/// </summary>
	public void OmitNoPartitioning()
	{
		vtkKdTree_OmitNoPartitioning_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_OmitXPartitioning_67(HandleRef pThis);

	/// <summary>
	/// Omit partitions along the X axis, yielding shafts in the X direction
	/// </summary>
	public void OmitXPartitioning()
	{
		vtkKdTree_OmitXPartitioning_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_OmitXYPartitioning_68(HandleRef pThis);

	/// <summary>
	/// Omit partitions along the X and Y axes, yielding slabs along Z
	/// </summary>
	public void OmitXYPartitioning()
	{
		vtkKdTree_OmitXYPartitioning_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_OmitYPartitioning_69(HandleRef pThis);

	/// <summary>
	/// Omit partitions along the Y axis, yielding shafts in the Y direction
	/// </summary>
	public void OmitYPartitioning()
	{
		vtkKdTree_OmitYPartitioning_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_OmitYZPartitioning_70(HandleRef pThis);

	/// <summary>
	/// Omit partitions along the Y and Z axes, yielding slabs along X
	/// </summary>
	public void OmitYZPartitioning()
	{
		vtkKdTree_OmitYZPartitioning_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_OmitZPartitioning_71(HandleRef pThis);

	/// <summary>
	/// Omit partitions along the Z axis, yielding shafts in the Z direction
	/// </summary>
	public void OmitZPartitioning()
	{
		vtkKdTree_OmitZPartitioning_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_OmitZXPartitioning_72(HandleRef pThis);

	/// <summary>
	/// Omit partitions along the Z and X axes, yielding slabs along Y
	/// </summary>
	public void OmitZXPartitioning()
	{
		vtkKdTree_OmitZXPartitioning_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_PrintRegion_73(HandleRef pThis, int id);

	/// <summary>
	/// Print out leaf node data for given id
	/// </summary>
	public void PrintRegion(int id)
	{
		vtkKdTree_PrintRegion_73(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_PrintTree_74(HandleRef pThis);

	/// <summary>
	/// Print out nodes of kd tree
	/// </summary>
	public void PrintTree()
	{
		vtkKdTree_PrintTree_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_PrintVerboseTree_75(HandleRef pThis);

	/// <summary>
	/// Print out nodes of kd tree
	/// </summary>
	public void PrintVerboseTree()
	{
		vtkKdTree_PrintVerboseTree_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_RemoveAllDataSets_76(HandleRef pThis);

	/// <summary>
	/// Remove the given data set.
	/// </summary>
	public virtual void RemoveAllDataSets()
	{
		vtkKdTree_RemoveAllDataSets_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_RemoveDataSet_77(HandleRef pThis, int index);

	/// <summary>
	/// Remove the given data set.
	/// </summary>
	public virtual void RemoveDataSet(int index)
	{
		vtkKdTree_RemoveDataSet_77(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_RemoveDataSet_78(HandleRef pThis, HandleRef set);

	/// <summary>
	/// Remove the given data set.
	/// </summary>
	public virtual void RemoveDataSet(vtkDataSet set)
	{
		vtkKdTree_RemoveDataSet_78(GetCppThis(), set?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdTree_SafeDownCast_79(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKdTree SafeDownCast(vtkObjectBase o)
	{
		vtkKdTree vtkKdTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdTree_SafeDownCast_79(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKdTree2 = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKdTree2.Register(null);
			}
		}
		return vtkKdTree2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetCuts_80(HandleRef pThis, HandleRef cuts);

	/// <summary>
	/// Normally the k-d tree is computed from the dataset(s) provided
	/// in SetDataSet.  Alternatively, you can provide the cuts that will
	/// be applied by calling SetCuts.
	/// </summary>
	public void SetCuts(vtkBSPCuts cuts)
	{
		vtkKdTree_SetCuts_80(GetCppThis(), cuts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetDataSet_81(HandleRef pThis, HandleRef set);

	/// <summary>
	/// Clear out all data sets and replace with single data set.  For backward
	/// compatibility with superclass.
	/// </summary>
	public override void SetDataSet(vtkDataSet set)
	{
		vtkKdTree_SetDataSet_81(GetCppThis(), set?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetFudgeFactor_82(HandleRef pThis, double _arg);

	/// <summary>
	/// Some algorithms on k-d trees require a value that is a very
	/// small distance relative to the diameter of the entire space
	/// divided by the k-d tree.  This factor is the maximum axis-aligned
	/// width of the space multiplied by 10e-6.
	/// </summary>
	public virtual void SetFudgeFactor(double _arg)
	{
		vtkKdTree_SetFudgeFactor_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetGenerateRepresentationUsingDataBounds_83(HandleRef pThis, int _arg);

	/// <summary>
	/// The polydata representation of the k-d tree shows the boundaries
	/// of the k-d tree decomposition spatial regions.  The data inside
	/// the regions may not occupy the entire space.  To draw just the
	/// bounds of the data in the regions, set this variable ON.
	/// </summary>
	public virtual void SetGenerateRepresentationUsingDataBounds(int _arg)
	{
		vtkKdTree_SetGenerateRepresentationUsingDataBounds_83(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetIncludeRegionBoundaryCells_84(HandleRef pThis, int _arg);

	/// <summary>
	/// If IncludeRegionBoundaryCells is ON,
	/// CreateCellLists() will also create a list of cells which
	/// intersect a given region, but are not assigned
	/// to the region.  These lists are obtained with
	/// GetBoundaryCellList().  Default is OFF.
	/// </summary>
	public virtual void SetIncludeRegionBoundaryCells(int _arg)
	{
		vtkKdTree_SetIncludeRegionBoundaryCells_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetMinCells_85(HandleRef pThis, int _arg);

	/// <summary>
	/// Minimum number of cells per spatial region.  Default is 100.
	/// </summary>
	public virtual void SetMinCells(int _arg)
	{
		vtkKdTree_SetMinCells_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetNewBounds_86(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// There are certain applications where you want the bounds of
	/// the k-d tree space to be at least as large as a specified
	/// box.  If the k-d tree has been built, you can expand it's
	/// bounds with this method.  If the bounds supplied are smaller
	/// than those computed, they will be ignored.
	/// </summary>
	public void SetNewBounds(IntPtr bounds)
	{
		vtkKdTree_SetNewBounds_86(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetNumberOfRegionsOrLess_87(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of spatial regions you want to get close
	/// to without going over.  (The number of spatial regions is normally
	/// a power of two.)  Call this before BuildLocator().  Default
	/// is unset (0).
	/// </summary>
	public virtual void SetNumberOfRegionsOrLess(int _arg)
	{
		vtkKdTree_SetNumberOfRegionsOrLess_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetNumberOfRegionsOrMore_88(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of spatial regions you want to get close
	/// to while having at least this many regions.  (The number of
	/// spatial regions is normally a power of two.)   Default
	/// is unset (0).
	/// </summary>
	public virtual void SetNumberOfRegionsOrMore(int _arg)
	{
		vtkKdTree_SetNumberOfRegionsOrMore_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_SetTiming_89(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on timing of the k-d tree build
	/// </summary>
	public virtual void SetTiming(int _arg)
	{
		vtkKdTree_SetTiming_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_TimingOff_90(HandleRef pThis);

	/// <summary>
	/// Turn on timing of the k-d tree build
	/// </summary>
	public virtual void TimingOff()
	{
		vtkKdTree_TimingOff_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdTree_TimingOn_91(HandleRef pThis);

	/// <summary>
	/// Turn on timing of the k-d tree build
	/// </summary>
	public virtual void TimingOn()
	{
		vtkKdTree_TimingOn_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_ViewOrderAllRegionsFromPosition_92(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

	/// <summary>
	/// Given a camera position (typically obtained with vtkCamera::GetPosition()),
	/// this method, creates a list of the k-d tree region IDs in order from front
	/// to back with respect to that direction.  The number of ordered regions is
	/// returned.  Use this method to view order regions for cameras that use
	/// perspective projection.
	/// </summary>
	public int ViewOrderAllRegionsFromPosition(IntPtr directionOfProjection, vtkIntArray orderedList)
	{
		return vtkKdTree_ViewOrderAllRegionsFromPosition_92(GetCppThis(), directionOfProjection, orderedList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_ViewOrderAllRegionsInDirection_93(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

	/// <summary>
	/// Given a direction of projection (typically obtained with
	/// vtkCamera::GetDirectionOfProjection()), this method, creates a list of the
	/// k-d tree region IDs in order from front to back with respect to that
	/// direction.  The number of ordered regions is returned.  Use this method to
	/// view order regions for cameras that use parallel projection.
	/// </summary>
	public int ViewOrderAllRegionsInDirection(IntPtr directionOfProjection, vtkIntArray orderedList)
	{
		return vtkKdTree_ViewOrderAllRegionsInDirection_93(GetCppThis(), directionOfProjection, orderedList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_ViewOrderRegionsFromPosition_94(HandleRef pThis, HandleRef regionIds, IntPtr directionOfProjection, HandleRef orderedList);

	/// <summary>
	/// Given a camera position and a list of k-d tree region IDs, this method,
	/// creates a list of the k-d tree region IDs in order from front to back with
	/// respect to that direction.  The number of ordered regions is returned.  Use
	/// this method to view order regions for cameras that use perspective
	/// projection.
	/// </summary>
	public int ViewOrderRegionsFromPosition(vtkIntArray regionIds, IntPtr directionOfProjection, vtkIntArray orderedList)
	{
		return vtkKdTree_ViewOrderRegionsFromPosition_94(GetCppThis(), regionIds?.GetCppThis() ?? default(HandleRef), directionOfProjection, orderedList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdTree_ViewOrderRegionsInDirection_95(HandleRef pThis, HandleRef regionIds, IntPtr directionOfProjection, HandleRef orderedList);

	/// <summary>
	/// Given a direction of projection and a list of k-d tree region IDs, this
	/// method, creates a list of the k-d tree region IDs in order from front to
	/// back with respect to that direction.  The number of ordered regions is
	/// returned.  Use this method to view order regions for cameras that use
	/// parallel projection.
	/// </summary>
	public int ViewOrderRegionsInDirection(vtkIntArray regionIds, IntPtr directionOfProjection, vtkIntArray orderedList)
	{
		return vtkKdTree_ViewOrderRegionsInDirection_95(GetCppThis(), regionIds?.GetCppThis() ?? default(HandleRef), directionOfProjection, orderedList?.GetCppThis() ?? default(HandleRef));
	}
}
