using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOctreePointLocator
/// </summary>
/// <remarks>
///    an octree spatial decomposition of a set of points
///
///
/// Given a vtkDataSet, create an octree that is locally refined
/// such that all leaf octants contain less than a certain
/// amount of points.  Note that there is no size constraint that
/// a leaf octant in relation to any of its neighbors.
///
/// This class can also generate a PolyData representation of
/// the boundaries of the spatial regions in the decomposition.
///
/// </remarks>
/// <seealso>
///
/// vtkLocator vtkPointLocator vtkOctreePointLocatorNode
/// </seealso>
public class vtkOctreePointLocator : vtkAbstractPointLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOctreePointLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOctreePointLocator()
	{
		MRClassNameKey = "class vtkOctreePointLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOctreePointLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOctreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOctreePointLocator New()
	{
		vtkOctreePointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOctreePointLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOctreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOctreePointLocator_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// Create the octree decomposition of the cells of the data set
	/// or data sets.  Cells are assigned to octree spatial regions
	/// based on the location of their centroids.
	///
	/// This will NOT do anything if UseExistingSearchStructure is on.
	/// </summary>
	public override void BuildLocator()
	{
		vtkOctreePointLocator_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_FindClosestNPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

	/// <summary>
	/// Find the closest N points to a position. This returns the closest
	/// N points to a position. A faster method could be created that returned
	/// N close points to a position, but not necessarily the exact N closest.
	/// The returned points are sorted from closest to farthest.
	/// These methods are thread safe if BuildLocator() is directly or
	/// indirectly called from a single thread first.
	/// </summary>
	public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
	{
		vtkOctreePointLocator_FindClosestNPoints_02(GetCppThis(), N, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocator_FindClosestPoint_03(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Return the Id of the point that is closest to the given point.
	/// Set the square of the distance between the two points.
	/// </summary>
	public override long FindClosestPoint(IntPtr x)
	{
		return vtkOctreePointLocator_FindClosestPoint_03(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocator_FindClosestPoint_04(HandleRef pThis, double x, double y, double z, ref double dist2);

	/// <summary>
	/// Return the Id of the point that is closest to the given point.
	/// Set the square of the distance between the two points.
	/// </summary>
	public long FindClosestPoint(double x, double y, double z, ref double dist2)
	{
		return vtkOctreePointLocator_FindClosestPoint_04(GetCppThis(), x, y, z, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocator_FindClosestPointInRegion_05(HandleRef pThis, int regionId, IntPtr x, ref double dist2);

	/// <summary>
	/// Find the Id of the point in the given leaf region which is
	/// closest to the given point.  Return the ID of the point,
	/// and set the square of the distance of between the points.
	/// </summary>
	public long FindClosestPointInRegion(int regionId, IntPtr x, ref double dist2)
	{
		return vtkOctreePointLocator_FindClosestPointInRegion_05(GetCppThis(), regionId, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocator_FindClosestPointInRegion_06(HandleRef pThis, int regionId, double x, double y, double z, ref double dist2);

	/// <summary>
	/// Find the Id of the point in the given leaf region which is
	/// closest to the given point.  Return the ID of the point,
	/// and set the square of the distance of between the points.
	/// </summary>
	public long FindClosestPointInRegion(int regionId, double x, double y, double z, ref double dist2)
	{
		return vtkOctreePointLocator_FindClosestPointInRegion_06(GetCppThis(), regionId, x, y, z, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocator_FindClosestPointWithinRadius_07(HandleRef pThis, double radius, IntPtr x, ref double dist2);

	/// <summary>
	/// Given a position x and a radius r, return the id of the point
	/// closest to the point in that radius.
	/// dist2 returns the squared distance to the point.
	/// </summary>
	public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
	{
		return vtkOctreePointLocator_FindClosestPointWithinRadius_07(GetCppThis(), radius, x, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_FindPointsInArea_08(HandleRef pThis, IntPtr area, HandleRef ids, byte clearArray);

	/// <summary>
	/// Fill ids with points found in area.  The area is a 6-tuple containing
	/// (xmin, xmax, ymin, ymax, zmin, zmax).
	/// This method will clear the array by default.  To append ids to an array,
	/// set clearArray to false.
	/// </summary>
	public void FindPointsInArea(IntPtr area, vtkIdTypeArray ids, bool clearArray)
	{
		vtkOctreePointLocator_FindPointsInArea_08(GetCppThis(), area, ids?.GetCppThis() ?? default(HandleRef), (byte)(clearArray ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_FindPointsWithinRadius_09(HandleRef pThis, double radius, IntPtr x, HandleRef result);

	/// <summary>
	/// Find all points within a specified radius of position x.
	/// The result is not sorted in any specific manner.
	/// </summary>
	public override void FindPointsWithinRadius(double radius, IntPtr x, vtkIdList result)
	{
		vtkOctreePointLocator_FindPointsWithinRadius_09(GetCppThis(), radius, x, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_ForceBuildLocator_10(HandleRef pThis);

	/// <summary>
	/// Build the locator from the input dataset (even if UseExistingSearchStructure is on).
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkOctreePointLocator_ForceBuildLocator_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_FreeSearchStructure_11(HandleRef pThis);

	/// <summary>
	/// Delete the octree data structure.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkOctreePointLocator_FreeSearchStructure_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_GenerateRepresentation_12(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Create a polydata representation of the boundaries of
	/// the octree regions.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkOctreePointLocator_GenerateRepresentation_12(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocator_GetBounds_13(HandleRef pThis);

	/// <summary>
	/// Get the spatial bounds of the entire octree space. Sets
	/// bounds array to xmin, xmax, ymin, ymax, zmin, zmax.
	/// </summary>
	public override IntPtr GetBounds()
	{
		return vtkOctreePointLocator_GetBounds_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_GetBounds_14(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the spatial bounds of the entire octree space. Sets
	/// bounds array to xmin, xmax, ymin, ymax, zmin, zmax.
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkOctreePointLocator_GetBounds_14(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocator_GetCreateCubicOctants_15(HandleRef pThis);

	/// <summary>
	/// Get/Set macro for CreateCubicOctants.
	/// </summary>
	public virtual int GetCreateCubicOctants()
	{
		return vtkOctreePointLocator_GetCreateCubicOctants_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkOctreePointLocator_GetFudgeFactor_16(HandleRef pThis);

	/// <summary>
	/// Some algorithms on octrees require a value that is a very
	/// small distance relative to the diameter of the entire space
	/// divided by the octree.  This factor is the maximum axis-aligned
	/// width of the space multiplied by 10e-6.
	/// </summary>
	public virtual double GetFudgeFactor()
	{
		return vtkOctreePointLocator_GetFudgeFactor_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocator_GetMaximumPointsPerRegion_17(HandleRef pThis);

	/// <summary>
	/// Maximum number of points per spatial region.  Default is 100.
	/// </summary>
	public virtual int GetMaximumPointsPerRegion()
	{
		return vtkOctreePointLocator_GetMaximumPointsPerRegion_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocator_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOctreePointLocator_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocator_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOctreePointLocator_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocator_GetNumberOfLeafNodes_20(HandleRef pThis);

	/// <summary>
	/// The number of leaf nodes of the tree, the spatial regions
	/// </summary>
	public virtual int GetNumberOfLeafNodes()
	{
		return vtkOctreePointLocator_GetNumberOfLeafNodes_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocator_GetPointsInRegion_21(HandleRef pThis, int leafNodeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a list of the original IDs of all points in a leaf node.
	/// </summary>
	public vtkIdTypeArray GetPointsInRegion(int leafNodeId)
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreePointLocator_GetPointsInRegion_21(GetCppThis(), leafNodeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOctreePointLocator_GetRegionBounds_22(HandleRef pThis, int regionID, IntPtr bounds);

	/// <summary>
	/// Get the spatial bounds of octree region
	/// </summary>
	public void GetRegionBounds(int regionID, IntPtr bounds)
	{
		vtkOctreePointLocator_GetRegionBounds_22(GetCppThis(), regionID, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocator_GetRegionContainingPoint_23(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Get the id of the leaf region containing the specified location.
	/// </summary>
	public int GetRegionContainingPoint(double x, double y, double z)
	{
		return vtkOctreePointLocator_GetRegionContainingPoint_23(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_GetRegionDataBounds_24(HandleRef pThis, int leafNodeID, IntPtr bounds);

	/// <summary>
	/// Get the bounds of the data within the leaf node
	/// </summary>
	public void GetRegionDataBounds(int leafNodeID, IntPtr bounds)
	{
		vtkOctreePointLocator_GetRegionDataBounds_24(GetCppThis(), leafNodeID, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocator_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOctreePointLocator_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocator_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOctreePointLocator_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocator_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOctreePointLocator NewInstance()
	{
		vtkOctreePointLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreePointLocator_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocator_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOctreePointLocator SafeDownCast(vtkObjectBase o)
	{
		vtkOctreePointLocator vtkOctreePointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreePointLocator_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOctreePointLocator2 = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOctreePointLocator2.Register(null);
			}
		}
		return vtkOctreePointLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_SetCreateCubicOctants_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set macro for CreateCubicOctants.
	/// </summary>
	public virtual void SetCreateCubicOctants(int _arg)
	{
		vtkOctreePointLocator_SetCreateCubicOctants_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_SetFudgeFactor_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Some algorithms on octrees require a value that is a very
	/// small distance relative to the diameter of the entire space
	/// divided by the octree.  This factor is the maximum axis-aligned
	/// width of the space multiplied by 10e-6.
	/// </summary>
	public virtual void SetFudgeFactor(double _arg)
	{
		vtkOctreePointLocator_SetFudgeFactor_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocator_SetMaximumPointsPerRegion_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Maximum number of points per spatial region.  Default is 100.
	/// </summary>
	public virtual void SetMaximumPointsPerRegion(int _arg)
	{
		vtkOctreePointLocator_SetMaximumPointsPerRegion_32(GetCppThis(), _arg);
	}
}
