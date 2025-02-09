using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKdNode
/// </summary>
/// <remarks>
///    This class represents a single spatial region
///     in an 3D axis aligned binary spatial partitioning.  It is assumed
///     the region bounds some set of points.  Regions are represented
///     as nodes in a binary tree.
///
///
///
/// </remarks>
/// <seealso>
///
///      vtkKdTree vtkOBSPCuts
/// </seealso>
public class vtkKdNode : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKdNode";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKdNode()
	{
		MRClassNameKey = "class vtkKdNode";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdNode"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKdNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKdNode New()
	{
		vtkKdNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKdNode()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKdNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkKdNode_AddChildNodes_01(HandleRef pThis, HandleRef left, HandleRef right);

	/// <summary>
	/// Add the left and right children.
	/// </summary>
	public void AddChildNodes(vtkKdNode left, vtkKdNode right)
	{
		vtkKdNode_AddChildNodes_01(GetCppThis(), left?.GetCppThis() ?? default(HandleRef), right?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_ContainsBox_02(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds);

	/// <summary>
	/// Return 1 if this spatial region entirely contains a box specified
	/// by it's bounds. Use the possibly smaller
	/// bounds of the points within the region if useDataBounds is non-zero.
	/// </summary>
	public int ContainsBox(double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds)
	{
		return vtkKdNode_ContainsBox_02(GetCppThis(), x1, x2, y1, y2, z1, z2, useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_ContainsPoint_03(HandleRef pThis, double x, double y, double z, int useDataBounds);

	/// <summary>
	/// Return 1 if this spatial region entirely contains the given point.
	/// Use the possibly smaller bounds of the points within the region
	/// if useDataBounds is non-zero.
	/// </summary>
	public int ContainsPoint(double x, double y, double z, int useDataBounds)
	{
		return vtkKdNode_ContainsPoint_03(GetCppThis(), x, y, z, useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_DeleteChildNodes_04(HandleRef pThis);

	/// <summary>
	/// Delete the left and right children.
	/// </summary>
	public void DeleteChildNodes()
	{
		vtkKdNode_DeleteChildNodes_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_GetBounds_05(HandleRef pThis, IntPtr b);

	/// <summary>
	/// Set/Get the bounds of the spatial region represented by this node.
	/// Caller allocates storage for 6-vector in GetBounds.
	/// </summary>
	public void GetBounds(IntPtr b)
	{
		vtkKdNode_GetBounds_05(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_GetDataBounds_06(HandleRef pThis, IntPtr b);

	/// <summary>
	/// Set/Get the bounds of the points contained in this spatial region.
	/// This may be smaller than the bounds of the region itself.
	/// Caller allocates storage for 6-vector in GetDataBounds.
	/// </summary>
	public void GetDataBounds(IntPtr b)
	{
		vtkKdNode_GetDataBounds_06(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_GetDim_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the dimension along which this region is divided.
	/// (0 - x, 1 - y, 2 - z, 3 - leaf node (default)).
	/// </summary>
	public virtual int GetDim()
	{
		return vtkKdNode_GetDim_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKdNode_GetDistance2ToBoundary_08(HandleRef pThis, double x, double y, double z, int useDataBounds);

	/// <summary>
	/// Calculate the distance squared from any point to the boundary of this
	/// region.  Use the boundary of the points within the region if useDataBounds
	/// is non-zero.
	/// </summary>
	public double GetDistance2ToBoundary(double x, double y, double z, int useDataBounds)
	{
		return vtkKdNode_GetDistance2ToBoundary_08(GetCppThis(), x, y, z, useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKdNode_GetDistance2ToBoundary_09(HandleRef pThis, double x, double y, double z, IntPtr boundaryPt, int useDataBounds);

	/// <summary>
	/// Calculate the distance squared from any point to the boundary of this
	/// region.  Use the boundary of the points within the region if useDataBounds
	/// is non-zero.  Set boundaryPt to the point on the boundary.
	/// </summary>
	public double GetDistance2ToBoundary(double x, double y, double z, IntPtr boundaryPt, int useDataBounds)
	{
		return vtkKdNode_GetDistance2ToBoundary_09(GetCppThis(), x, y, z, boundaryPt, useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKdNode_GetDistance2ToInnerBoundary_10(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Calculate the distance from the specified point (which is required to
	/// be inside this spatial region) to an interior boundary.  An interior
	/// boundary is one that is not also an boundary of the entire space
	/// partitioned by the tree of vtkKdNode's.
	/// </summary>
	public double GetDistance2ToInnerBoundary(double x, double y, double z)
	{
		return vtkKdNode_GetDistance2ToInnerBoundary_10(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKdNode_GetDivisionPosition_11(HandleRef pThis);

	/// <summary>
	/// Get the location of the division plane along the axis the region
	/// is divided.  See also GetDim().  The result is undertermined if
	/// this node is not divided (a leaf node).
	/// </summary>
	public virtual double GetDivisionPosition()
	{
		return vtkKdNode_GetDivisionPosition_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_GetID_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the ID associated with the region described by this node.  If
	/// this is not a leaf node, this value should be -1.
	/// </summary>
	public virtual int GetID()
	{
		return vtkKdNode_GetID_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdNode_GetLeft_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a pointer to the left child of this node.
	/// </summary>
	public virtual vtkKdNode GetLeft()
	{
		vtkKdNode vtkKdNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdNode_GetLeft_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkKdNode_GetMaxBounds_14(HandleRef pThis);

	/// <summary>
	/// Get a pointer to the 3 bound minima (xmin, ymin and zmin) or the
	/// 3 bound maxima (xmax, ymax, zmax).  Don't free this pointer.
	/// </summary>
	public double[] GetMaxBounds()
	{
		IntPtr intPtr = vtkKdNode_GetMaxBounds_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdNode_GetMaxDataBounds_15(HandleRef pThis);

	/// <summary>
	/// Get a pointer to the 3 data bound minima (xmin, ymin and zmin) or the
	/// 3 data bound maxima (xmax, ymax, zmax).  Don't free this pointer.
	/// </summary>
	public double[] GetMaxDataBounds()
	{
		IntPtr intPtr = vtkKdNode_GetMaxDataBounds_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_GetMaxID_16(HandleRef pThis);

	/// <summary>
	/// If this node is not a leaf node, there are leaf nodes below it whose
	/// regions represent a partitioning of this region.  The IDs of these
	/// leaf nodes form a contiguous set.  Set/Get the range of the IDs of
	/// the leaf nodes below this node.  If this is already a leaf node, these
	/// values should be the same as the ID.
	/// </summary>
	public virtual int GetMaxID()
	{
		return vtkKdNode_GetMaxID_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdNode_GetMinBounds_17(HandleRef pThis);

	/// <summary>
	/// Get a pointer to the 3 bound minima (xmin, ymin and zmin) or the
	/// 3 bound maxima (xmax, ymax, zmax).  Don't free this pointer.
	/// </summary>
	public double[] GetMinBounds()
	{
		IntPtr intPtr = vtkKdNode_GetMinBounds_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdNode_GetMinDataBounds_18(HandleRef pThis);

	/// <summary>
	/// Get a pointer to the 3 data bound minima (xmin, ymin and zmin) or the
	/// 3 data bound maxima (xmax, ymax, zmax).  Don't free this pointer.
	/// </summary>
	public double[] GetMinDataBounds()
	{
		IntPtr intPtr = vtkKdNode_GetMinDataBounds_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_GetMinID_19(HandleRef pThis);

	/// <summary>
	/// If this node is not a leaf node, there are leaf nodes below it whose
	/// regions represent a partitioning of this region.  The IDs of these
	/// leaf nodes form a contiguous set.  Set/Get the range of the IDs of
	/// the leaf nodes below this node.  If this is already a leaf node, these
	/// values should be the same as the ID.
	/// </summary>
	public virtual int GetMinID()
	{
		return vtkKdNode_GetMinID_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdNode_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKdNode_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKdNode_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKdNode_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_GetNumberOfPoints_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of points contained in this region.
	/// </summary>
	public virtual int GetNumberOfPoints()
	{
		return vtkKdNode_GetNumberOfPoints_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdNode_GetRight_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a pointer to the right child of this node.
	/// </summary>
	public virtual vtkKdNode GetRight()
	{
		vtkKdNode vtkKdNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdNode_GetRight_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkKdNode_GetUp_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a pointer to the parent of this node.
	/// </summary>
	public virtual vtkKdNode GetUp()
	{
		vtkKdNode vtkKdNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdNode_GetUp_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkKdNode_IntersectsBox_25(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds);

	/// <summary>
	/// Return 1 if this spatial region intersects the axis-aligned box given
	/// by the bounds passed in.  Use the possibly smaller bounds of the points
	/// within the region if useDataBounds is non-zero.
	/// </summary>
	public int IntersectsBox(double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds)
	{
		return vtkKdNode_IntersectsBox_25(GetCppThis(), x1, x2, y1, y2, z1, z2, useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_IntersectsCell_26(HandleRef pThis, HandleRef cell, int useDataBounds, int cellRegion, IntPtr cellBounds);

	/// <summary>
	/// Return 1 if the cell specified intersects this region.  If you
	/// already know the ID of the region containing the cell's centroid,
	/// provide that as an argument.  If you already know the bounds of the
	/// cell, provide that as well, in the form of xmin,xmax,ymin,ymax,zmin,
	/// zmax.  Either of these may speed the calculation.
	/// Use the possibly smaller bounds of the points within the region
	/// if useDataBounds is non-zero.
	/// </summary>
	public int IntersectsCell(vtkCell cell, int useDataBounds, int cellRegion, IntPtr cellBounds)
	{
		return vtkKdNode_IntersectsCell_26(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), useDataBounds, cellRegion, cellBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_IntersectsRegion_27(HandleRef pThis, HandleRef pi, int useDataBounds);

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
		return vtkKdNode_IntersectsRegion_27(GetCppThis(), pi?.GetCppThis() ?? default(HandleRef), useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_IntersectsSphere2_28(HandleRef pThis, double x, double y, double z, double rSquared, int useDataBounds);

	/// <summary>
	/// Return 1 if this spatial region intersects a sphere described by
	/// it's center and the square of it's radius. Use the possibly smaller
	/// bounds of the points within the region if useDataBounds is non-zero.
	/// </summary>
	public int IntersectsSphere2(double x, double y, double z, double rSquared, int useDataBounds)
	{
		return vtkKdNode_IntersectsSphere2_28(GetCppThis(), x, y, z, rSquared, useDataBounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKdNode_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKdNode_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKdNode_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdNode_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKdNode NewInstance()
	{
		vtkKdNode result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdNode_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_PrintNode_33(HandleRef pThis, int depth);

	/// <summary>
	/// For debugging purposes, print out this node.
	/// </summary>
	public void PrintNode(int depth)
	{
		vtkKdNode_PrintNode_33(GetCppThis(), depth);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_PrintVerboseNode_34(HandleRef pThis, int depth);

	/// <summary>
	/// For debugging purposes, print out this node.
	/// </summary>
	public void PrintVerboseNode(int depth)
	{
		vtkKdNode_PrintVerboseNode_34(GetCppThis(), depth);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKdNode_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKdNode SafeDownCast(vtkObjectBase o)
	{
		vtkKdNode vtkKdNode2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKdNode_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkKdNode_SetBounds_36(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

	/// <summary>
	/// Set/Get the bounds of the spatial region represented by this node.
	/// Caller allocates storage for 6-vector in GetBounds.
	/// </summary>
	public void SetBounds(double x1, double x2, double y1, double y2, double z1, double z2)
	{
		vtkKdNode_SetBounds_36(GetCppThis(), x1, x2, y1, y2, z1, z2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetBounds_37(HandleRef pThis, IntPtr b);

	/// <summary>
	/// Set/Get the bounds of the spatial region represented by this node.
	/// Caller allocates storage for 6-vector in GetBounds.
	/// </summary>
	public void SetBounds(IntPtr b)
	{
		vtkKdNode_SetBounds_37(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetDataBounds_38(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

	/// <summary>
	/// Set/Get the bounds of the points contained in this spatial region.
	/// This may be smaller than the bounds of the region itself.
	/// Caller allocates storage for 6-vector in GetDataBounds.
	/// </summary>
	public void SetDataBounds(double x1, double x2, double y1, double y2, double z1, double z2)
	{
		vtkKdNode_SetDataBounds_38(GetCppThis(), x1, x2, y1, y2, z1, z2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetDataBounds_39(HandleRef pThis, IntPtr v);

	/// <summary>
	/// Given a pointer to NumberOfPoints points, set the DataBounds of this
	/// node to the bounds of these points.
	/// </summary>
	public void SetDataBounds(IntPtr v)
	{
		vtkKdNode_SetDataBounds_39(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetDim_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the dimension along which this region is divided.
	/// (0 - x, 1 - y, 2 - z, 3 - leaf node (default)).
	/// </summary>
	public virtual void SetDim(int _arg)
	{
		vtkKdNode_SetDim_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetID_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the ID associated with the region described by this node.  If
	/// this is not a leaf node, this value should be -1.
	/// </summary>
	public virtual void SetID(int _arg)
	{
		vtkKdNode_SetID_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetLeft_42(HandleRef pThis, HandleRef left);

	/// <summary>
	/// Set/Get a pointer to the left child of this node.
	/// </summary>
	public void SetLeft(vtkKdNode left)
	{
		vtkKdNode_SetLeft_42(GetCppThis(), left?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetMaxBounds_43(HandleRef pThis, IntPtr mb);

	/// <summary>
	/// Set the xmax, ymax and zmax value of the bounds of this region
	/// </summary>
	public void SetMaxBounds(IntPtr mb)
	{
		vtkKdNode_SetMaxBounds_43(GetCppThis(), mb);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetMaxDataBounds_44(HandleRef pThis, IntPtr mb);

	/// <summary>
	/// Set the xmax, ymax and zmax value of the bounds of this
	/// data within this region
	/// </summary>
	public void SetMaxDataBounds(IntPtr mb)
	{
		vtkKdNode_SetMaxDataBounds_44(GetCppThis(), mb);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetMaxID_45(HandleRef pThis, int _arg);

	/// <summary>
	/// If this node is not a leaf node, there are leaf nodes below it whose
	/// regions represent a partitioning of this region.  The IDs of these
	/// leaf nodes form a contiguous set.  Set/Get the range of the IDs of
	/// the leaf nodes below this node.  If this is already a leaf node, these
	/// values should be the same as the ID.
	/// </summary>
	public virtual void SetMaxID(int _arg)
	{
		vtkKdNode_SetMaxID_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetMinBounds_46(HandleRef pThis, IntPtr mb);

	/// <summary>
	/// Set the xmin, ymin and zmin value of the bounds of this region
	/// </summary>
	public void SetMinBounds(IntPtr mb)
	{
		vtkKdNode_SetMinBounds_46(GetCppThis(), mb);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetMinDataBounds_47(HandleRef pThis, IntPtr mb);

	/// <summary>
	/// Set the xmin, ymin and zmin value of the bounds of this
	/// data within this region
	/// </summary>
	public void SetMinDataBounds(IntPtr mb)
	{
		vtkKdNode_SetMinDataBounds_47(GetCppThis(), mb);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetMinID_48(HandleRef pThis, int _arg);

	/// <summary>
	/// If this node is not a leaf node, there are leaf nodes below it whose
	/// regions represent a partitioning of this region.  The IDs of these
	/// leaf nodes form a contiguous set.  Set/Get the range of the IDs of
	/// the leaf nodes below this node.  If this is already a leaf node, these
	/// values should be the same as the ID.
	/// </summary>
	public virtual void SetMinID(int _arg)
	{
		vtkKdNode_SetMinID_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetNumberOfPoints_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of points contained in this region.
	/// </summary>
	public virtual void SetNumberOfPoints(int _arg)
	{
		vtkKdNode_SetNumberOfPoints_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetRight_50(HandleRef pThis, HandleRef right);

	/// <summary>
	/// Set/Get a pointer to the right child of this node.
	/// </summary>
	public void SetRight(vtkKdNode right)
	{
		vtkKdNode_SetRight_50(GetCppThis(), right?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKdNode_SetUp_51(HandleRef pThis, HandleRef up);

	/// <summary>
	/// Set/Get a pointer to the parent of this node.
	/// </summary>
	public void SetUp(vtkKdNode up)
	{
		vtkKdNode_SetUp_51(GetCppThis(), up?.GetCppThis() ?? default(HandleRef));
	}
}
