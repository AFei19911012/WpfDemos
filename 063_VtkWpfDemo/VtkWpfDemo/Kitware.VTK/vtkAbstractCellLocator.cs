using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractCellLocator
/// </summary>
/// <remarks>
///    an abstract base class for locators which find cells
///
/// vtkAbstractCellLocator is a spatial search object to quickly locate cells in 3D.
/// vtkAbstractCellLocator supplies a basic interface which concrete subclasses
/// should implement.
///
/// @warning
/// When deriving a class from vtkAbstractCellLocator, one should include the
/// 'hidden' member functions by the following construct in the derived class
/// \verbatim
///  using vtkAbstractCellLocator::IntersectWithLine;
///  using vtkAbstractCellLocator::FindClosestPoint;
///  using vtkAbstractCellLocator::FindClosestPointWithinRadius;
///  using vtkAbstractCellLocator::FindCell;
/// \endverbatim
///
/// </remarks>
/// <seealso>
///
/// vtkLocator vtkCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkModifiedBSPTree vtkOBBTree
/// </seealso>
public abstract class vtkAbstractCellLocator : vtkLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractCellLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractCellLocator()
	{
		MRClassNameKey = "class vtkAbstractCellLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractCellLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkAbstractCellLocator_CacheCellBoundsOff_01(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether the bounds of each cell are computed only
	/// once and then saved.  Should be 10 to 20% faster if repeatedly
	/// calling any of the Intersect/Find routines and the extra memory
	/// won't cause disk caching (48 extra bytes per cell are required to
	/// save the bounds).
	/// </summary>
	public virtual void CacheCellBoundsOff()
	{
		vtkAbstractCellLocator_CacheCellBoundsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_CacheCellBoundsOn_02(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether the bounds of each cell are computed only
	/// once and then saved.  Should be 10 to 20% faster if repeatedly
	/// calling any of the Intersect/Find routines and the extra memory
	/// won't cause disk caching (48 extra bytes per cell are required to
	/// save the bounds).
	/// </summary>
	public virtual void CacheCellBoundsOn()
	{
		vtkAbstractCellLocator_CacheCellBoundsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_ComputeCellBounds_03(HandleRef pThis);

	/// <summary>
	/// This function can be used either internally or externally to compute only the cached
	/// cell bounds if CacheCellBounds is on.
	/// </summary>
	public void ComputeCellBounds()
	{
		vtkAbstractCellLocator_ComputeCellBounds_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLocator_FindCell_04(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Returns the Id of the cell containing the point,
	/// returns -1 if no cell found. This interface uses a tolerance of zero
	///
	/// THIS FUNCTION IS NOT THREAD SAFE.
	/// </summary>
	public virtual long FindCell(IntPtr x)
	{
		return vtkAbstractCellLocator_FindCell_04(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLocator_FindCell_05(HandleRef pThis, IntPtr x, double tol2, HandleRef GenCell, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Find the cell containing a given point. returns -1 if no cell found
	/// the cell parameters are copied into the supplied variables, a cell must
	/// be provided to store the information.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual long FindCell(IntPtr x, double tol2, vtkGenericCell GenCell, IntPtr pcoords, IntPtr weights)
	{
		return vtkAbstractCellLocator_FindCell_05(GetCppThis(), x, tol2, GenCell?.GetCppThis() ?? default(HandleRef), pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLocator_FindCell_06(HandleRef pThis, IntPtr x, double tol2, HandleRef GenCell, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Find the cell containing a given point. returns -1 if no cell found
	/// the cell parameters are copied into the supplied variables, a cell must
	/// be provided to store the information.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual long FindCell(IntPtr x, double tol2, vtkGenericCell GenCell, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkAbstractCellLocator_FindCell_06(GetCppThis(), x, tol2, GenCell?.GetCppThis() ?? default(HandleRef), ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_FindCellsAlongLine_07(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cells);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// For each intersection with the bounds of a cell, the cellIds
	/// have the relevant information added sort by t. If cellIds is nullptr
	/// pointer, then no information is generated for that list.
	///
	/// A vtkAbstractCellLocator subclass needs to implement IntersectWithLine that
	/// takes cells ids, which is used internally to implement FindCellsAlongLine.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cells)
	{
		vtkAbstractCellLocator_FindCellsAlongLine_07(GetCppThis(), p1, p2, tolerance, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_FindCellsAlongPlane_08(HandleRef pThis, IntPtr o, IntPtr n, double tolerance, HandleRef cells);

	/// <summary>
	/// Given an unbounded plane defined by an origin o[3] and unit normal n[3],
	/// return the list of unique cell ids in the buckets containing the
	/// plane. It is possible that an empty cell list is returned. The user must
	/// provide the vtkIdList cell list to populate. This method returns data
	/// only after the locator has been built.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual void FindCellsAlongPlane(IntPtr o, IntPtr n, double tolerance, vtkIdList cells)
	{
		vtkAbstractCellLocator_FindCellsAlongPlane_08(GetCppThis(), o, n, tolerance, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_FindCellsWithinBounds_09(HandleRef pThis, IntPtr bbox, HandleRef cells);

	/// <summary>
	/// Return a list of unique cell ids inside of a given bounding box. The
	/// user must provide the vtkIdList to populate.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
	{
		vtkAbstractCellLocator_FindCellsWithinBounds_09(GetCppThis(), bbox, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_FindClosestPoint_10(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

	/// <summary>
	/// Return the closest point and the cell which is closest to the point x.
	/// The closest point is somewhere on a cell, it need not be one of the
	/// vertices of the cell.
	///
	/// A vtkAbstractCellLocator subclass needs to implement FindClosestPointWithinRadius
	/// which is used internally to implement FindClosestPoint.
	///
	/// THIS FUNCTION IS NOT THREAD SAFE.
	/// </summary>
	public virtual void FindClosestPoint(IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
	{
		vtkAbstractCellLocator_FindClosestPoint_10(GetCppThis(), x, closestPoint, ref cellId, ref subId, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_FindClosestPoint_11(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

	/// <summary>
	/// Return the closest point and the cell which is closest to the point x.
	/// The closest point is somewhere on a cell, it need not be one of the
	/// vertices of the cell.
	///
	/// A vtkAbstractCellLocator subclass needs to implement FindClosestPointWithinRadius
	/// which is used internally to implement FindClosestPoint.
	///
	/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
	{
		vtkAbstractCellLocator_FindClosestPoint_11(GetCppThis(), x, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_12(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

	/// <summary>
	/// Return the closest point within a specified radius and the cell which is
	/// closest to the point x. The closest point is somewhere on a cell, it
	/// need not be one of the vertices of the cell. This method returns 1 if
	/// a point is found within the specified radius. If there are no cells within
	/// the specified radius, the method returns 0 and the values of closestPoint,
	/// cellId, subId, and dist2 are undefined.
	///
	/// THIS FUNCTION IS NOT THREAD SAFE.
	/// </summary>
	public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
	{
		return vtkAbstractCellLocator_FindClosestPointWithinRadius_12(GetCppThis(), x, radius, closestPoint, ref cellId, ref subId, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_13(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

	/// <summary>
	/// Return the closest point within a specified radius and the cell which is
	/// closest to the point x. The closest point is somewhere on a cell, it
	/// need not be one of the vertices of the cell. This method returns 1 if
	/// a point is found within the specified radius. If there are no cells within
	/// the specified radius, the method returns 0 and the values of closestPoint,
	/// cellId, subId, and dist2 are undefined.
	///
	/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
	{
		return vtkAbstractCellLocator_FindClosestPointWithinRadius_13(GetCppThis(), x, radius, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_14(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

	/// <summary>
	/// Return the closest point within a specified radius and the cell which is
	/// closest to the point x. The closest point is somewhere on a cell, it
	/// need not be one of the vertices of the cell. This method returns 1 if a
	/// point is found within the specified radius. If there are no cells within
	/// the specified radius, the method returns 0 and the values of
	/// closestPoint, cellId, subId, and dist2 are undefined. If a closest point
	/// is found, inside returns the return value of the EvaluatePosition call to
	/// the closest cell; inside(=1) or outside(=0).
	///
	/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
	{
		return vtkAbstractCellLocator_FindClosestPointWithinRadius_14(GetCppThis(), x, radius, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2, ref inside);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_GetCacheCellBounds_15(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether the bounds of each cell are computed only
	/// once and then saved.  Should be 10 to 20% faster if repeatedly
	/// calling any of the Intersect/Find routines and the extra memory
	/// won't cause disk caching (48 extra bytes per cell are required to
	/// save the bounds).
	/// </summary>
	public virtual int GetCacheCellBounds()
	{
		return vtkAbstractCellLocator_GetCacheCellBounds_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNode_16(HandleRef pThis);

	/// <summary>
	/// Specify the preferred/maximum number of cells in each node/bucket.
	/// Default 32. Locators generally operate by subdividing space into
	/// smaller regions until the number of cells in each region (or node)
	/// reaches the desired level.
	/// </summary>
	public virtual int GetNumberOfCellsPerNode()
	{
		return vtkAbstractCellLocator_GetNumberOfCellsPerNode_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNodeMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the preferred/maximum number of cells in each node/bucket.
	/// Default 32. Locators generally operate by subdividing space into
	/// smaller regions until the number of cells in each region (or node)
	/// reaches the desired level.
	/// </summary>
	public virtual int GetNumberOfCellsPerNodeMaxValue()
	{
		return vtkAbstractCellLocator_GetNumberOfCellsPerNodeMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNodeMinValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the preferred/maximum number of cells in each node/bucket.
	/// Default 32. Locators generally operate by subdividing space into
	/// smaller regions until the number of cells in each region (or node)
	/// reaches the desired level.
	/// </summary>
	public virtual int GetNumberOfCellsPerNodeMinValue()
	{
		return vtkAbstractCellLocator_GetNumberOfCellsPerNodeMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLocator_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractCellLocator_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractCellLocator_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractCellLocator_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_GetRetainCellLists_21(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to maintain list of cells in each node.
	/// not applicable to all implementations, but if the locator is being used
	/// as a geometry simplification technique, there is no need to keep them.
	/// </summary>
	public virtual int GetRetainCellLists()
	{
		return vtkAbstractCellLocator_GetRetainCellLists_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAbstractCellLocator_InsideCellBounds_22(HandleRef pThis, IntPtr x, long cell_ID);

	/// <summary>
	/// Quickly test if a point is inside the bounds of a particular cell.
	/// Some locators cache cell bounds and this function can make use
	/// of fast access to the data. This function should be used ONLY after the locator is built.
	/// </summary>
	public virtual bool InsideCellBounds(IntPtr x, long cell_ID)
	{
		return (vtkAbstractCellLocator_InsideCellBounds_22(GetCppThis(), x, cell_ID) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Return intersection point (if any) of finite line with cells contained
	/// in cell locator. See vtkCell.h parameters documentation.
	///
	/// THIS FUNCTION IS NOT THREAD SAFE.
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkAbstractCellLocator_IntersectWithLine_23(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId);

	/// <summary>
	/// Return intersection point (if any) AND the cell which was intersected by
	/// the finite line.
	///
	/// THIS FUNCTION IS NOT THREAD SAFE.
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId)
	{
		return vtkAbstractCellLocator_IntersectWithLine_24(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_IntersectWithLine_25(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

	/// <summary>
	/// Return intersection point (if any) AND the cell which was intersected by
	/// the finite line. The cell is returned as a cell id and as a generic cell.
	///
	/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
	{
		return vtkAbstractCellLocator_IntersectWithLine_25(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_IntersectWithLine_26(HandleRef pThis, IntPtr p1, IntPtr p2, HandleRef points, HandleRef cellIds);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// The return value of the function is 0 if no intersections were found,
	/// -1 if point 'a0' lies inside the closed surface, or +1 if point 'a0'
	/// lies outside the closed surface. This method assumes that the data set
	/// is a vtkPolyData that describes a closed surface, and the intersection
	/// points that are returned in 'points' alternate between entrance points and exit points.
	///
	/// Either 'points' or 'cellIds' can be set to nullptr if you don't want
	/// to receive that information.
	///
	/// This method is only implemented in vtkOBBTree.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, vtkPoints points, vtkIdList cellIds)
	{
		return vtkAbstractCellLocator_IntersectWithLine_26(GetCppThis(), p1, p2, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_IntersectWithLine_27(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// The return value of the function is 0 if no intersections were found.
	/// For each intersection with a cell, the points and cellIds have the relevant information
	/// added sorted by t. If points or cellIds are nullptr pointers, then no information is
	/// generated for that list.
	///
	/// THIS FUNCTION IS NOT THREAD SAFE.
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds)
	{
		return vtkAbstractCellLocator_IntersectWithLine_27(GetCppThis(), p1, p2, tol, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// The return value of the function is 0 if no intersections were found.
	/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
	/// the points and cellIds have the relevant information added sorted by t.
	/// If points or cellIds are nullptr pointers, then no information is generated for that list.
	///
	/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
	///
	/// THIS FUNCTION IS THREAD SAFE.
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
	{
		return vtkAbstractCellLocator_IntersectWithLine_28(GetCppThis(), p1, p2, tol, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractCellLocator_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractCellLocator_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractCellLocator_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractCellLocator_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractCellLocator NewInstance()
	{
		vtkAbstractCellLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractCellLocator_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_RetainCellListsOff_32(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to maintain list of cells in each node.
	/// not applicable to all implementations, but if the locator is being used
	/// as a geometry simplification technique, there is no need to keep them.
	/// </summary>
	public virtual void RetainCellListsOff()
	{
		vtkAbstractCellLocator_RetainCellListsOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_RetainCellListsOn_33(HandleRef pThis);

	/// <summary>
	/// Boolean controls whether to maintain list of cells in each node.
	/// not applicable to all implementations, but if the locator is being used
	/// as a geometry simplification technique, there is no need to keep them.
	/// </summary>
	public virtual void RetainCellListsOn()
	{
		vtkAbstractCellLocator_RetainCellListsOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractCellLocator_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractCellLocator SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractCellLocator vtkAbstractCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractCellLocator_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLocator2 = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLocator2.Register(null);
			}
		}
		return vtkAbstractCellLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_SetCacheCellBounds_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether the bounds of each cell are computed only
	/// once and then saved.  Should be 10 to 20% faster if repeatedly
	/// calling any of the Intersect/Find routines and the extra memory
	/// won't cause disk caching (48 extra bytes per cell are required to
	/// save the bounds).
	/// </summary>
	public virtual void SetCacheCellBounds(int _arg)
	{
		vtkAbstractCellLocator_SetCacheCellBounds_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_SetNumberOfCellsPerNode_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the preferred/maximum number of cells in each node/bucket.
	/// Default 32. Locators generally operate by subdividing space into
	/// smaller regions until the number of cells in each region (or node)
	/// reaches the desired level.
	/// </summary>
	public virtual void SetNumberOfCellsPerNode(int _arg)
	{
		vtkAbstractCellLocator_SetNumberOfCellsPerNode_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_SetRetainCellLists_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Boolean controls whether to maintain list of cells in each node.
	/// not applicable to all implementations, but if the locator is being used
	/// as a geometry simplification technique, there is no need to keep them.
	/// </summary>
	public virtual void SetRetainCellLists(int _arg)
	{
		vtkAbstractCellLocator_SetRetainCellLists_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractCellLocator_ShallowCopy_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Shallow copy of a vtkAbstractCellLocator.
	/// </summary>
	public virtual void ShallowCopy(vtkAbstractCellLocator arg0)
	{
		vtkAbstractCellLocator_ShallowCopy_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
