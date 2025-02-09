using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOctreePointLocatorNode
/// </summary>
/// <remarks>
///    Octree node that has 8 children each of equal size
///
///
/// This class represents a single spatial region in a 3D axis octant
/// partitioning.  It is intended to work efficiently with the
/// vtkOctreePointLocator and is not meant for general use.  It is assumed
/// the region bounds some set of points.  The ordering of the children is
/// (-x,-y,-z),(+x,-y,-z),(-x,+y,-z),(+x,+y,-z),(-x,-y,+z),(+x,-y,+z),
/// (-x,+y,+z),(+x,+y,+z).  The portion of the domain assigned to an
/// octant is Min &lt; x &lt;= Max.
///
/// </remarks>
/// <seealso>
///
/// vtkOctreePointLocator
/// </seealso>
public class vtkOctreePointLocatorNode : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOctreePointLocatorNode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOctreePointLocatorNode()
	{
		MRClassNameKey = "class vtkOctreePointLocatorNode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOctreePointLocatorNode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOctreePointLocatorNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocatorNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOctreePointLocatorNode New()
	{
		vtkOctreePointLocatorNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreePointLocatorNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOctreePointLocatorNode()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOctreePointLocatorNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOctreePointLocatorNode_ComputeOctreeNodeInformation_01(HandleRef pThis, HandleRef Parent, ref int NextLeafId, ref int NextMinId, IntPtr coordinates);

	/// <summary>
	/// Recursive function to compute ID, MinVal, MaxVal, and MinID.
	/// Parent is used for MinVal and MaxVal in the case that no
	/// points are in the leaf node.
	/// </summary>
	public void ComputeOctreeNodeInformation(vtkOctreePointLocatorNode Parent, ref int NextLeafId, ref int NextMinId, IntPtr coordinates)
	{
		vtkOctreePointLocatorNode_ComputeOctreeNodeInformation_01(GetCppThis(), Parent?.GetCppThis() ?? default(HandleRef), ref NextLeafId, ref NextMinId, coordinates);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocatorNode_ContainsPoint_02(HandleRef pThis, double x, double y, double z, int useDataBounds);

	/// <summary>
	/// Return 1 if this spatial region entirely contains the given point.
	/// Use the possibly smaller bounds of the points within the region
	/// if useDataBounds is non-zero.
	/// </summary>
	public int ContainsPoint(double x, double y, double z, int useDataBounds)
	{
		return vtkOctreePointLocatorNode_ContainsPoint_02(GetCppThis(), x, y, z, useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_CreateChildNodes_03(HandleRef pThis);

	/// <summary>
	/// Add the 8 children.
	/// </summary>
	public void CreateChildNodes()
	{
		vtkOctreePointLocatorNode_CreateChildNodes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_DeleteChildNodes_04(HandleRef pThis);

	/// <summary>
	/// Delete the 8 children.
	/// </summary>
	public void DeleteChildNodes()
	{
		vtkOctreePointLocatorNode_DeleteChildNodes_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_GetBounds_05(HandleRef pThis, IntPtr b);

	/// <summary>
	/// Set/Get the bounds of the spatial region represented by this node.
	/// Caller allocates storage for 6-vector in GetBounds.
	/// </summary>
	public void GetBounds(IntPtr b)
	{
		vtkOctreePointLocatorNode_GetBounds_05(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocatorNode_GetChild_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the ith child of this node.
	/// </summary>
	public vtkOctreePointLocatorNode GetChild(int i)
	{
		vtkOctreePointLocatorNode vtkOctreePointLocatorNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreePointLocatorNode_GetChild_06(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOctreePointLocatorNode2 = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOctreePointLocatorNode2.Register(null);
			}
		}
		return vtkOctreePointLocatorNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_GetDataBounds_07(HandleRef pThis, IntPtr b);

	/// <summary>
	/// Set/Get the bounds of the points contained in this spatial region.
	/// This may be smaller than the bounds of the region itself.
	/// Caller allocates storage for 6-vector in GetDataBounds.
	/// </summary>
	public void GetDataBounds(IntPtr b)
	{
		vtkOctreePointLocatorNode_GetDataBounds_07(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkOctreePointLocatorNode_GetDistance2ToBoundary_08(HandleRef pThis, double x, double y, double z, HandleRef top, int useDataBounds);

	/// <summary>
	/// Calculate the distance squared from any point to the boundary of this
	/// region.  Use the boundary of the points within the region if useDataBounds
	/// is non-zero.
	/// </summary>
	public double GetDistance2ToBoundary(double x, double y, double z, vtkOctreePointLocatorNode top, int useDataBounds)
	{
		return vtkOctreePointLocatorNode_GetDistance2ToBoundary_08(GetCppThis(), x, y, z, top?.GetCppThis() ?? default(HandleRef), useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkOctreePointLocatorNode_GetDistance2ToBoundary_09(HandleRef pThis, double x, double y, double z, IntPtr boundaryPt, HandleRef top, int useDataBounds);

	/// <summary>
	/// Calculate the distance squared from any point to the boundary of this
	/// region.  Use the boundary of the points within the region if useDataBounds
	/// is non-zero.  Set boundaryPt to the point on the boundary.
	/// </summary>
	public double GetDistance2ToBoundary(double x, double y, double z, IntPtr boundaryPt, vtkOctreePointLocatorNode top, int useDataBounds)
	{
		return vtkOctreePointLocatorNode_GetDistance2ToBoundary_09(GetCppThis(), x, y, z, boundaryPt, top?.GetCppThis() ?? default(HandleRef), useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkOctreePointLocatorNode_GetDistance2ToInnerBoundary_10(HandleRef pThis, double x, double y, double z, HandleRef top);

	/// <summary>
	/// Calculate the distance from the specified point (which is required to
	/// be inside this spatial region) to an interior boundary.  An interior
	/// boundary is one that is not also an boundary of the entire space
	/// partitioned by the tree of vtkOctreePointLocatorNode's.
	/// </summary>
	public double GetDistance2ToInnerBoundary(double x, double y, double z, vtkOctreePointLocatorNode top)
	{
		return vtkOctreePointLocatorNode_GetDistance2ToInnerBoundary_10(GetCppThis(), x, y, z, top?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocatorNode_GetID_11(HandleRef pThis);

	/// <summary>
	/// Get the ID associated with the region described by this node.  If
	/// this is not a leaf node, this value should be -1.
	/// </summary>
	public virtual int GetID()
	{
		return vtkOctreePointLocatorNode_GetID_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocatorNode_GetMaxBounds_12(HandleRef pThis);

	/// <summary>
	/// Get a pointer to the 3 bound minima (xmin, ymin and zmin) or the
	/// 3 bound maxima (xmax, ymax, zmax).  Don't free this pointer.
	/// </summary>
	public virtual IntPtr GetMaxBounds()
	{
		return vtkOctreePointLocatorNode_GetMaxBounds_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocatorNode_GetMaxDataBounds_13(HandleRef pThis);

	/// <summary>
	/// Get a pointer to the 3 data bound minima (xmin, ymin and zmin) or the
	/// 3 data bound maxima (xmax, ymax, zmax).  Don't free this pointer.
	/// </summary>
	public virtual IntPtr GetMaxDataBounds()
	{
		return vtkOctreePointLocatorNode_GetMaxDataBounds_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocatorNode_GetMinBounds_14(HandleRef pThis);

	/// <summary>
	/// Get a pointer to the 3 bound minima (xmin, ymin and zmin) or the
	/// 3 bound maxima (xmax, ymax, zmax).  Don't free this pointer.
	/// </summary>
	public virtual IntPtr GetMinBounds()
	{
		return vtkOctreePointLocatorNode_GetMinBounds_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocatorNode_GetMinDataBounds_15(HandleRef pThis);

	/// <summary>
	/// Get a pointer to the 3 data bound minima (xmin, ymin and zmin) or the
	/// 3 data bound maxima (xmax, ymax, zmax).  Don't free this pointer.
	/// </summary>
	public virtual IntPtr GetMinDataBounds()
	{
		return vtkOctreePointLocatorNode_GetMinDataBounds_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocatorNode_GetMinID_16(HandleRef pThis);

	/// <summary>
	/// If this node is not a leaf node, there are leaf nodes below it whose
	/// regions represent a partitioning of this region.  The IDs of these
	/// leaf nodes form a contiguous set.  Get the first of the first point's
	/// ID that is contained in this node.
	/// </summary>
	public virtual int GetMinID()
	{
		return vtkOctreePointLocatorNode_GetMinID_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocatorNode_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOctreePointLocatorNode_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOctreePointLocatorNode_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOctreePointLocatorNode_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocatorNode_GetNumberOfPoints_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of points contained in this region.
	/// </summary>
	public virtual int GetNumberOfPoints()
	{
		return vtkOctreePointLocatorNode_GetNumberOfPoints_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocatorNode_GetSubOctantIndex_20(HandleRef pThis, IntPtr point, int CheckContainment);

	/// <summary>
	/// Return the id of the suboctant that a given point is in.
	/// If CheckContainment is non-zero then it checks whether
	/// the point is in the actual bounding box of the suboctant,
	/// otherwise it only checks which octant the point is in
	/// that is created from the axis-aligned partitioning of
	/// the domain at this octant's center.
	/// </summary>
	public int GetSubOctantIndex(IntPtr point, int CheckContainment)
	{
		return vtkOctreePointLocatorNode_GetSubOctantIndex_20(GetCppThis(), point, CheckContainment);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocatorNode_IntersectsRegion_21(HandleRef pThis, HandleRef pi, int useDataBounds);

	/// <summary>
	/// A vtkPlanesIntersection object represents a convex 3D region bounded
	/// by planes, and it is capable of computing intersections of
	/// boxes with itself.  Return 1 if this spatial region intersects
	/// the spatial region described by the vtkPlanesIntersection object.
	/// Use the possibly smaller bounds of the points within the region
	/// if useDataBounds is non-zero.
	/// </summary>
	public int IntersectsRegion(vtkPlanesIntersection pi, int useDataBounds)
	{
		return vtkOctreePointLocatorNode_IntersectsRegion_21(GetCppThis(), pi?.GetCppThis() ?? default(HandleRef), useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocatorNode_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOctreePointLocatorNode_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOctreePointLocatorNode_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOctreePointLocatorNode_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocatorNode_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOctreePointLocatorNode NewInstance()
	{
		vtkOctreePointLocatorNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreePointLocatorNode_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOctreePointLocatorNode_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOctreePointLocatorNode SafeDownCast(vtkObjectBase o)
	{
		vtkOctreePointLocatorNode vtkOctreePointLocatorNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOctreePointLocatorNode_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOctreePointLocatorNode2 = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOctreePointLocatorNode2.Register(null);
			}
		}
		return vtkOctreePointLocatorNode2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_SetBounds_27(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Set/Get the bounds of the spatial region represented by this node.
	/// Caller allocates storage for 6-vector in GetBounds.
	/// </summary>
	public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkOctreePointLocatorNode_SetBounds_27(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_SetBounds_28(HandleRef pThis, IntPtr b);

	/// <summary>
	/// Set/Get the bounds of the spatial region represented by this node.
	/// Caller allocates storage for 6-vector in GetBounds.
	/// </summary>
	public void SetBounds(IntPtr b)
	{
		vtkOctreePointLocatorNode_SetBounds_28(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_SetDataBounds_29(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Set/Get the bounds of the points contained in this spatial region.
	/// This may be smaller than the bounds of the region itself.
	/// Caller allocates storage for 6-vector in GetDataBounds.
	/// </summary>
	public void SetDataBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkOctreePointLocatorNode_SetDataBounds_29(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_SetMaxBounds_30(HandleRef pThis, IntPtr maxBounds);

	/// <summary>
	/// Set the xmax, ymax and zmax value of the bounds of this region
	/// </summary>
	public void SetMaxBounds(IntPtr maxBounds)
	{
		vtkOctreePointLocatorNode_SetMaxBounds_30(GetCppThis(), maxBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_SetMaxDataBounds_31(HandleRef pThis, IntPtr maxDataBounds);

	/// <summary>
	/// Set the xmax, ymax and zmax value of the bounds of this
	/// data within this region.
	/// </summary>
	public void SetMaxDataBounds(IntPtr maxDataBounds)
	{
		vtkOctreePointLocatorNode_SetMaxDataBounds_31(GetCppThis(), maxDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_SetMinBounds_32(HandleRef pThis, IntPtr minBounds);

	/// <summary>
	/// Set the xmin, ymin and zmin value of the bounds of this region
	/// </summary>
	public void SetMinBounds(IntPtr minBounds)
	{
		vtkOctreePointLocatorNode_SetMinBounds_32(GetCppThis(), minBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_SetMinDataBounds_33(HandleRef pThis, IntPtr minDataBounds);

	/// <summary>
	/// Set the xmin, ymin and zmin value of the bounds of this
	/// data within this region.
	/// </summary>
	public void SetMinDataBounds(IntPtr minDataBounds)
	{
		vtkOctreePointLocatorNode_SetMinDataBounds_33(GetCppThis(), minDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOctreePointLocatorNode_SetNumberOfPoints_34(HandleRef pThis, int numberOfPoints);

	/// <summary>
	/// Set/Get the number of points contained in this region.
	/// </summary>
	public void SetNumberOfPoints(int numberOfPoints)
	{
		vtkOctreePointLocatorNode_SetNumberOfPoints_34(GetCppThis(), numberOfPoints);
	}
}
