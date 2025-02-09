using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStaticCellLocator
/// </summary>
/// <remarks>
///    perform fast cell location operations
///
/// vtkStaticCellLocator is a type of vtkAbstractCellLocator that accelerates
/// certain operations when performing spatial operations on cells. These
/// operations include finding a point that contains a cell, and intersecting
/// cells with a line.
///
/// vtkStaticCellLocator is an accelerated version of vtkCellLocator. It is
/// threaded (via vtkSMPTools), and supports one-time static construction
/// (i.e., incremental cell insertion is not supported).
///
/// @warning
/// vtkStaticCellLocator utilizes the following parent class parameters:
/// - Automatic                   (default true)
/// - NumberOfCellsPerNode        (default 10)
/// - UseExistingSearchStructure  (default false)
///
/// vtkStaticCellLocator does NOT utilize the following parameters:
/// - CacheCellBounds             (always cached)
/// - Tolerance
/// - Level
/// - MaxLevel
/// - RetainCellLists
///
/// @warning
/// This class is templated. It may run slower than serial execution if the code
/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractCellLocator vtkCellLocator vtkCellTreeLocator vtkModifiedBSPTree vtkOBBTree
/// </seealso>
public class vtkStaticCellLocator : vtkAbstractCellLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStaticCellLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStaticCellLocator()
	{
		MRClassNameKey = "class vtkStaticCellLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticCellLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStaticCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCellLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new static vtkStaticCellLocator New()
	{
		vtkStaticCellLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCellLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public vtkStaticCellLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStaticCellLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStaticCellLocator_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void BuildLocator()
	{
		vtkStaticCellLocator_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCellLocator_FindCell_02(HandleRef pThis, IntPtr x, double arg1, HandleRef GenCell, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Find the cell containing a given point. returns -1 if no cell found
	/// the cell parameters are copied into the supplied variables, a cell must
	/// be provided to store the information.
	///
	/// For other FindCell signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override long FindCell(IntPtr x, double arg1, vtkGenericCell GenCell, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkStaticCellLocator_FindCell_02(GetCppThis(), x, arg1, GenCell?.GetCppThis() ?? default(HandleRef), ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// For each intersection with the bounds of a cell, the cellIds
	/// have the relevant information added. If cellIds is nullptr
	/// pointer, then no information is generated for that list.
	///
	/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
	/// </summary>
	public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
	{
		vtkStaticCellLocator_FindCellsAlongLine_03(GetCppThis(), p1, p2, tolerance, cellsIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_FindCellsAlongPlane_04(HandleRef pThis, IntPtr o, IntPtr n, double tolerance, HandleRef cells);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// For each intersection with the bounds of a cell, the cellIds
	/// have the relevant information added sort by t. If cellIds is nullptr
	/// pointer, then no information is generated for that list.
	/// </summary>
	public override void FindCellsAlongPlane(IntPtr o, IntPtr n, double tolerance, vtkIdList cells)
	{
		vtkStaticCellLocator_FindCellsAlongPlane_04(GetCppThis(), o, n, tolerance, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_FindCellsWithinBounds_05(HandleRef pThis, IntPtr bbox, HandleRef cells);

	/// <summary>
	/// Return a list of unique cell ids inside of a given bounding box. The
	/// user must provide the vtkIdList to populate.
	/// </summary>
	public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
	{
		vtkStaticCellLocator_FindCellsWithinBounds_05(GetCppThis(), bbox, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_FindClosestPoint_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

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
		vtkStaticCellLocator_FindClosestPoint_06(GetCppThis(), x, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCellLocator_FindClosestPointWithinRadius_07(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

	/// <summary>
	/// Return the closest point within a specified radius and the cell which is
	/// closest to the point x. The closest point is somewhere on a cell, it
	/// need not be one of the vertices of the cell. This method returns 1 if a
	/// point is found within the specified radius. If there are no cells within
	/// the specified radius, the method returns 0 and the values of
	/// closestPoint, cellId, subId, and dist2 are undefined. If a closest point
	/// is found, inside returns the return value of the EvaluatePosition call to
	/// the closest cell; inside(=1) or outside(=0).
	/// </summary>
	public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
	{
		return vtkStaticCellLocator_FindClosestPointWithinRadius_07(GetCppThis(), x, radius, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2, ref inside);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_ForceBuildLocator_08(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkStaticCellLocator_ForceBuildLocator_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_FreeSearchStructure_09(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkStaticCellLocator_FreeSearchStructure_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkStaticCellLocator_GenerateRepresentation_10(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCellLocator_GetDivisions_11(HandleRef pThis);

	/// <summary>
	/// Set the number of divisions in x-y-z directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfCellsPerNode and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual int[] GetDivisions()
	{
		IntPtr intPtr = vtkStaticCellLocator_GetDivisions_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_GetDivisions_12(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the number of divisions in x-y-z directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfCellsPerNode and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual void GetDivisions(IntPtr data)
	{
		vtkStaticCellLocator_GetDivisions_12(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCellLocator_GetLargeIds_13(HandleRef pThis);

	/// <summary>
	/// Inform the user as to whether large ids are being used. This flag only
	/// has meaning after the locator has been built. Large ids are used when the
	/// number of binned points, or the number of bins, is &gt;= the maximum number
	/// of buckets (specified by the user). Note that LargeIds are only available
	/// on 64-bit architectures.
	/// </summary>
	public bool GetLargeIds()
	{
		return (vtkStaticCellLocator_GetLargeIds_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCellLocator_GetMaxNumberOfBuckets_14(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of buckets in the locator. By default the value
	/// is set to VTK_INT_MAX. Note that there are significant performance
	/// implications at work here. If the number of buckets is set very large
	/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
	/// 64-bit integers (which is much slower than using a 32-bit int). Of
	/// course, memory requirements may dramatically increase as well.  It is
	/// recommended that the default value be used; but for extremely large data
	/// it may be desired to create a locator with an exceptionally large number
	/// of buckets. Note also that during initialization of the locator if the
	/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
	/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
	/// the size of the bounding box in the x-y-z directions.
	/// </summary>
	public virtual long GetMaxNumberOfBuckets()
	{
		return vtkStaticCellLocator_GetMaxNumberOfBuckets_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCellLocator_GetMaxNumberOfBucketsMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of buckets in the locator. By default the value
	/// is set to VTK_INT_MAX. Note that there are significant performance
	/// implications at work here. If the number of buckets is set very large
	/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
	/// 64-bit integers (which is much slower than using a 32-bit int). Of
	/// course, memory requirements may dramatically increase as well.  It is
	/// recommended that the default value be used; but for extremely large data
	/// it may be desired to create a locator with an exceptionally large number
	/// of buckets. Note also that during initialization of the locator if the
	/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
	/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
	/// the size of the bounding box in the x-y-z directions.
	/// </summary>
	public virtual long GetMaxNumberOfBucketsMaxValue()
	{
		return vtkStaticCellLocator_GetMaxNumberOfBucketsMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCellLocator_GetMaxNumberOfBucketsMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set the maximum number of buckets in the locator. By default the value
	/// is set to VTK_INT_MAX. Note that there are significant performance
	/// implications at work here. If the number of buckets is set very large
	/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
	/// 64-bit integers (which is much slower than using a 32-bit int). Of
	/// course, memory requirements may dramatically increase as well.  It is
	/// recommended that the default value be used; but for extremely large data
	/// it may be desired to create a locator with an exceptionally large number
	/// of buckets. Note also that during initialization of the locator if the
	/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
	/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
	/// the size of the bounding box in the x-y-z directions.
	/// </summary>
	public virtual long GetMaxNumberOfBucketsMinValue()
	{
		return vtkStaticCellLocator_GetMaxNumberOfBucketsMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCellLocator_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStaticCellLocator_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStaticCellLocator_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStaticCellLocator_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStaticCellLocator_InsideCellBounds_19(HandleRef pThis, IntPtr x, long cellId);

	/// <summary>
	/// Quickly test if a point is inside the bounds of a particular cell.
	/// This function should be used ONLY after the locator is built.
	/// </summary>
	public override bool InsideCellBounds(IntPtr x, long cellId)
	{
		return (vtkStaticCellLocator_InsideCellBounds_19(GetCppThis(), x, cellId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCellLocator_IntersectWithLine_20(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

	/// <summary>
	/// Return intersection point (if any) AND the cell which was intersected by
	/// the finite line. The cell is returned as a cell id and as a generic cell.
	///
	/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
	{
		return vtkStaticCellLocator_IntersectWithLine_20(GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCellLocator_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

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
		return vtkStaticCellLocator_IntersectWithLine_21(GetCppThis(), p1, p2, tol, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCellLocator_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStaticCellLocator_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStaticCellLocator_IsTypeOf_23(string type);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStaticCellLocator_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCellLocator_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new vtkStaticCellLocator NewInstance()
	{
		vtkStaticCellLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCellLocator_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStaticCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStaticCellLocator_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new static vtkStaticCellLocator SafeDownCast(vtkObjectBase o)
	{
		vtkStaticCellLocator vtkStaticCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStaticCellLocator_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStaticCellLocator2 = (vtkStaticCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStaticCellLocator2.Register(null);
			}
		}
		return vtkStaticCellLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_SetDivisions_27(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set the number of divisions in x-y-z directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfCellsPerNode and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
	{
		vtkStaticCellLocator_SetDivisions_27(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_SetDivisions_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the number of divisions in x-y-z directions. If the Automatic data
	/// member is enabled, the Divisions are set according to the
	/// NumberOfCellsPerNode and MaxNumberOfBuckets data members. The number
	/// of divisions must be &gt;= 1 in each direction.
	/// </summary>
	public virtual void SetDivisions(IntPtr _arg)
	{
		vtkStaticCellLocator_SetDivisions_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_SetMaxNumberOfBuckets_29(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the maximum number of buckets in the locator. By default the value
	/// is set to VTK_INT_MAX. Note that there are significant performance
	/// implications at work here. If the number of buckets is set very large
	/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
	/// 64-bit integers (which is much slower than using a 32-bit int). Of
	/// course, memory requirements may dramatically increase as well.  It is
	/// recommended that the default value be used; but for extremely large data
	/// it may be desired to create a locator with an exceptionally large number
	/// of buckets. Note also that during initialization of the locator if the
	/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
	/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
	/// the size of the bounding box in the x-y-z directions.
	/// </summary>
	public virtual void SetMaxNumberOfBuckets(long _arg)
	{
		vtkStaticCellLocator_SetMaxNumberOfBuckets_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStaticCellLocator_ShallowCopy_30(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Shallow copy of a vtkStaticCellLocator.
	/// </summary>
	public override void ShallowCopy(vtkAbstractCellLocator locator)
	{
		vtkStaticCellLocator_ShallowCopy_30(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}
}
