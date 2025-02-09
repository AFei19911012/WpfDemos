using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBSPIntersections
/// </summary>
/// <remarks>
///    Perform calculations (mostly intersection
///   calculations) on regions of a 3D binary spatial partitioning.
///
///
///    Given an axis aligned binary spatial partitioning described by a
///    vtkBSPCuts object, perform intersection queries on various
///    geometric entities with regions of the spatial partitioning.
///
/// </remarks>
/// <seealso>
///
///    vtkBSPCuts  vtkKdTree
/// </seealso>
public class vtkBSPIntersections : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBSPIntersections";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBSPIntersections()
	{
		MRClassNameKey = "class vtkBSPIntersections";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBSPIntersections"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBSPIntersections(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPIntersections_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBSPIntersections New()
	{
		vtkBSPIntersections result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPIntersections_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBSPIntersections()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBSPIntersections_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOff_01(HandleRef pThis);

	/// <summary>
	/// When computing the intersection of k-d tree regions with other
	/// objects, we use the spatial bounds of the region.  To use the
	/// tighter bound of the bounding box of the data within the region,
	/// set this variable ON.  (Specifying data bounds in the vtkBSPCuts
	/// object is optional.  If data bounds were not specified, this
	/// option has no meaning.)
	/// </summary>
	public void ComputeIntersectionsUsingDataBoundsOff()
	{
		vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOn_02(HandleRef pThis);

	/// <summary>
	/// When computing the intersection of k-d tree regions with other
	/// objects, we use the spatial bounds of the region.  To use the
	/// tighter bound of the bounding box of the data within the region,
	/// set this variable ON.  (Specifying data bounds in the vtkBSPCuts
	/// object is optional.  If data bounds were not specified, this
	/// option has no meaning.)
	/// </summary>
	public void ComputeIntersectionsUsingDataBoundsOn()
	{
		vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_GetBounds_03(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds of the whole space (xmin, xmax, ymin, ymax, zmin, zmax)
	/// Return 0 if OK, 1 on error.
	/// </summary>
	public int GetBounds(IntPtr bounds)
	{
		return vtkBSPIntersections_GetBounds_03(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_GetComputeIntersectionsUsingDataBounds_04(HandleRef pThis);

	/// <summary>
	/// When computing the intersection of k-d tree regions with other
	/// objects, we use the spatial bounds of the region.  To use the
	/// tighter bound of the bounding box of the data within the region,
	/// set this variable ON.  (Specifying data bounds in the vtkBSPCuts
	/// object is optional.  If data bounds were not specified, this
	/// option has no meaning.)
	/// </summary>
	public virtual int GetComputeIntersectionsUsingDataBounds()
	{
		return vtkBSPIntersections_GetComputeIntersectionsUsingDataBounds_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPIntersections_GetCuts_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Define the binary spatial partitioning.
	/// </summary>
	public virtual vtkBSPCuts GetCuts()
	{
		vtkBSPCuts vtkBSPCuts2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPIntersections_GetCuts_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkBSPIntersections_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBSPIntersections_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBSPIntersections_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBSPIntersections_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_GetNumberOfRegions_08(HandleRef pThis);

	/// <summary>
	/// The number of regions in the binary spatial partitioning
	/// </summary>
	public int GetNumberOfRegions()
	{
		return vtkBSPIntersections_GetNumberOfRegions_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_GetRegionBounds_09(HandleRef pThis, int regionID, IntPtr bounds);

	/// <summary>
	/// Get the spatial bounds of a particular region
	/// Return 0 if OK, 1 on error.
	/// </summary>
	public int GetRegionBounds(int regionID, IntPtr bounds)
	{
		return vtkBSPIntersections_GetRegionBounds_09(GetCppThis(), regionID, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_GetRegionDataBounds_10(HandleRef pThis, int regionID, IntPtr bounds);

	/// <summary>
	/// Get the bounds of the data within the k-d tree region, possibly
	/// smaller than the bounds of the region.
	/// Return 0 if OK, 1 on error.
	/// </summary>
	public int GetRegionDataBounds(int regionID, IntPtr bounds)
	{
		return vtkBSPIntersections_GetRegionDataBounds_10(GetCppThis(), regionID, bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IntersectsBox_11(HandleRef pThis, int regionId, IntPtr x);

	/// <summary>
	/// Determine whether a region of the spatial decomposition
	/// intersects an axis aligned box.
	/// </summary>
	public int IntersectsBox(int regionId, IntPtr x)
	{
		return vtkBSPIntersections_IntersectsBox_11(GetCppThis(), regionId, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IntersectsBox_12(HandleRef pThis, int regionId, double x0, double x1, double y0, double y1, double z0, double z1);

	/// <summary>
	/// Determine whether a region of the spatial decomposition
	/// intersects an axis aligned box.
	/// </summary>
	public int IntersectsBox(int regionId, double x0, double x1, double y0, double y1, double z0, double z1)
	{
		return vtkBSPIntersections_IntersectsBox_12(GetCppThis(), regionId, x0, x1, y0, y1, z0, z1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IntersectsBox_13(HandleRef pThis, IntPtr ids, int len, IntPtr x);

	/// <summary>
	/// Compute a list of the Ids of all regions that
	/// intersect the specified axis aligned box.
	/// Returns: the number of ids in the list.
	/// </summary>
	public int IntersectsBox(IntPtr ids, int len, IntPtr x)
	{
		return vtkBSPIntersections_IntersectsBox_13(GetCppThis(), ids, len, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IntersectsBox_14(HandleRef pThis, IntPtr ids, int len, double x0, double x1, double y0, double y1, double z0, double z1);

	/// <summary>
	/// Compute a list of the Ids of all regions that
	/// intersect the specified axis aligned box.
	/// Returns: the number of ids in the list.
	/// </summary>
	public int IntersectsBox(IntPtr ids, int len, double x0, double x1, double y0, double y1, double z0, double z1)
	{
		return vtkBSPIntersections_IntersectsBox_14(GetCppThis(), ids, len, x0, x1, y0, y1, z0, z1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IntersectsCell_15(HandleRef pThis, int regionId, HandleRef cell, int cellRegion);

	/// <summary>
	/// Determine whether a region of the spatial decomposition
	/// intersects the given cell.  If you already
	/// know the region that the cell centroid lies in, provide
	/// that as the last argument to make the computation quicker.
	/// </summary>
	public int IntersectsCell(int regionId, vtkCell cell, int cellRegion)
	{
		return vtkBSPIntersections_IntersectsCell_15(GetCppThis(), regionId, cell?.GetCppThis() ?? default(HandleRef), cellRegion);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IntersectsCell_16(HandleRef pThis, IntPtr ids, int len, HandleRef cell, int cellRegion);

	/// <summary>
	/// Compute a list of the Ids of all regions that
	/// intersect the given cell.  If you already
	/// know the region that the cell centroid lies in, provide
	/// that as the last argument to make the computation quicker.
	/// Returns the number of regions the cell intersects.
	/// </summary>
	public int IntersectsCell(IntPtr ids, int len, vtkCell cell, int cellRegion)
	{
		return vtkBSPIntersections_IntersectsCell_16(GetCppThis(), ids, len, cell?.GetCppThis() ?? default(HandleRef), cellRegion);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IntersectsSphere2_17(HandleRef pThis, int regionId, double x, double y, double z, double rSquared);

	/// <summary>
	/// Determine whether a region of the spatial decomposition
	/// intersects a sphere, given the center of the sphere
	/// and the square of it's radius.
	/// </summary>
	public int IntersectsSphere2(int regionId, double x, double y, double z, double rSquared)
	{
		return vtkBSPIntersections_IntersectsSphere2_17(GetCppThis(), regionId, x, y, z, rSquared);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IntersectsSphere2_18(HandleRef pThis, IntPtr ids, int len, double x, double y, double z, double rSquared);

	/// <summary>
	/// Compute a list of the Ids of all regions that
	/// intersect the specified sphere.  The sphere is given
	/// by it's center and the square of it's radius.
	/// Returns: the number of ids in the list.
	/// </summary>
	public int IntersectsSphere2(IntPtr ids, int len, double x, double y, double z, double rSquared)
	{
		return vtkBSPIntersections_IntersectsSphere2_18(GetCppThis(), ids, len, x, y, z, rSquared);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBSPIntersections_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSPIntersections_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBSPIntersections_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPIntersections_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBSPIntersections NewInstance()
	{
		vtkBSPIntersections result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPIntersections_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSPIntersections_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBSPIntersections SafeDownCast(vtkObjectBase o)
	{
		vtkBSPIntersections vtkBSPIntersections2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSPIntersections_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBSPIntersections2 = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBSPIntersections2.Register(null);
			}
		}
		return vtkBSPIntersections2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPIntersections_SetComputeIntersectionsUsingDataBounds_24(HandleRef pThis, int c);

	/// <summary>
	/// When computing the intersection of k-d tree regions with other
	/// objects, we use the spatial bounds of the region.  To use the
	/// tighter bound of the bounding box of the data within the region,
	/// set this variable ON.  (Specifying data bounds in the vtkBSPCuts
	/// object is optional.  If data bounds were not specified, this
	/// option has no meaning.)
	/// </summary>
	public void SetComputeIntersectionsUsingDataBounds(int c)
	{
		vtkBSPIntersections_SetComputeIntersectionsUsingDataBounds_24(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSPIntersections_SetCuts_25(HandleRef pThis, HandleRef cuts);

	/// <summary>
	/// Define the binary spatial partitioning.
	/// </summary>
	public void SetCuts(vtkBSPCuts cuts)
	{
		vtkBSPIntersections_SetCuts_25(GetCppThis(), cuts?.GetCppThis() ?? default(HandleRef));
	}
}
