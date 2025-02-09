using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellLocator
/// </summary>
/// <remarks>
///    octree-based spatial search object to quickly locate cells
///
/// vtkCellLocator is a spatial search object to quickly locate cells in 3D.
/// vtkCellLocator uses a uniform-level octree subdivision, where each octant
/// (an octant is also referred to as a bucket) carries an indication of
/// whether it is empty or not, and each leaf octant carries a list of the
/// cells inside of it. (An octant is not empty if it has one or more cells
/// inside of it.)  Typical operations are intersection with a line to return
/// candidate cells, or intersection with another vtkCellLocator to return
/// candidate cells.
///
/// @warning
/// vtkCellLocator utilizes the following parent class parameters:
/// - Automatic                   (default true)
/// - Level                       (default 8)
/// - MaxLevel                    (default 8)
/// - NumberOfCellsPerNode        (default 25)
/// - CacheCellBounds             (default true)
/// - UseExistingSearchStructure  (default false)
///
/// vtkCellLocator does NOT utilize the following parameters:
/// - Tolerance
/// - RetainCellLists
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkModifiedBSPTree vtkOBBTree
/// </seealso>
public class vtkCellLocator : vtkAbstractCellLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellLocator()
	{
		MRClassNameKey = "class vtkCellLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 25 cells per bucket.
	/// </summary>
	public new static vtkCellLocator New()
	{
		vtkCellLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 25 cells per bucket.
	/// </summary>
	public vtkCellLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCellLocator_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void BuildLocator()
	{
		vtkCellLocator_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLocator_FindCell_02(HandleRef pThis, IntPtr x, double arg1, HandleRef GenCell, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Find the cell containing a given point. returns -1 if no cell found
	/// the cell parameters are copied into the supplied variables, a cell must
	/// be provided to store the information.
	///
	/// For other FindCell signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override long FindCell(IntPtr x, double arg1, vtkGenericCell GenCell, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkCellLocator_FindCell_02(GetCppThis(), x, arg1, GenCell?.GetCppThis() ?? default(HandleRef), ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLocator_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// For each intersection with the bounds of a cell, the cellIds
	/// have the relevant information added sort by t. If cellIds is nullptr
	/// pointer, then no information is generated for that list.
	///
	/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
	/// </summary>
	public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
	{
		vtkCellLocator_FindCellsAlongLine_03(GetCppThis(), p1, p2, tolerance, cellsIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLocator_FindCellsWithinBounds_04(HandleRef pThis, IntPtr bbox, HandleRef cells);

	/// <summary>
	/// Return a list of unique cell ids inside of a given bounding box. The
	/// user must provide the vtkIdList to populate.
	/// </summary>
	public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
	{
		vtkCellLocator_FindCellsWithinBounds_04(GetCppThis(), bbox, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLocator_FindClosestPoint_05(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

	/// <summary>
	/// Return the closest point and the cell which is closest to the point x.
	/// The closest point is somewhere on a cell, it need not be one of the
	/// vertices of the cell.
	///
	/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
	///
	/// For other FindClosestPoint signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
	{
		vtkCellLocator_FindClosestPoint_05(GetCppThis(), x, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLocator_FindClosestPointWithinRadius_06(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

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
	/// For other FindClosestPointWithinRadius signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
	{
		return vtkCellLocator_FindClosestPointWithinRadius_06(GetCppThis(), x, radius, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2, ref inside);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLocator_ForceBuildLocator_07(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkCellLocator_ForceBuildLocator_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLocator_FreeSearchStructure_08(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkCellLocator_FreeSearchStructure_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLocator_GenerateRepresentation_09(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkCellLocator_GenerateRepresentation_09(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLocator_GetCells_10(HandleRef pThis, int bucket, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cells in a particular bucket.
	/// </summary>
	public virtual vtkIdList GetCells(int bucket)
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLocator_GetCells_10(GetCppThis(), bucket, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCellLocator_GetNumberOfBuckets_11(HandleRef pThis);

	/// <summary>
	/// Return number of buckets available. Ensure that the locator has been
	/// built before attempting to access buckets (octants).
	/// </summary>
	public virtual int GetNumberOfBuckets()
	{
		return vtkCellLocator_GetNumberOfBuckets_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLocator_GetNumberOfCellsPerBucket_12(HandleRef pThis);

	/// <summary>
	/// Specify the average number of cells in each octant.
	/// </summary>
	public int GetNumberOfCellsPerBucket()
	{
		return vtkCellLocator_GetNumberOfCellsPerBucket_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLocator_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellLocator_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLocator_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellLocator_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLocator_IntersectWithLine_15(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

	/// <summary>
	/// Return intersection point (if any) AND the cell which was intersected by
	/// the finite line. The cell is returned as a cell id and as a generic cell.
	///
	/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
	{
		return vtkCellLocator_IntersectWithLine_15(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLocator_IntersectWithLine_16(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// The return value of the function is 0 if no intersections were found.
	/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
	/// the points and cellIds have the relevant information added sorted by t.
	/// If points or cellIds are nullptr pointers, then no information is generated for that list.
	///
	/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
	{
		return vtkCellLocator_IntersectWithLine_16(GetCppThis(), p1, p2, tol, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLocator_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellLocator_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLocator_IsTypeOf_18(string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellLocator_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLocator_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new vtkCellLocator NewInstance()
	{
		vtkCellLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLocator_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLocator_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static vtkCellLocator SafeDownCast(vtkObjectBase o)
	{
		vtkCellLocator vtkCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLocator_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellLocator2 = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellLocator2.Register(null);
			}
		}
		return vtkCellLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLocator_SetNumberOfCellsPerBucket_22(HandleRef pThis, int N);

	/// <summary>
	/// Specify the average number of cells in each octant.
	/// </summary>
	public void SetNumberOfCellsPerBucket(int N)
	{
		vtkCellLocator_SetNumberOfCellsPerBucket_22(GetCppThis(), N);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLocator_ShallowCopy_23(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Shallow copy of a vtkCellLocator.
	/// </summary>
	public override void ShallowCopy(vtkAbstractCellLocator locator)
	{
		vtkCellLocator_ShallowCopy_23(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}
}
