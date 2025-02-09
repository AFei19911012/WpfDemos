using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellTreeLocator
/// </summary>
/// <remarks>
///    This class implements the data structures, construction
/// algorithms for fast cell location.
///
/// Cell Tree is a bounding interval hierarchy based data structure, where child boxes
/// do not form an exact split of the parent boxes along a dimension.  Therefore two axis-
/// aligned bounding planes (left max and right min) are stored for each node along a
/// dimension. This class implements the data structure (Cell Tree Node) and its build
/// and traversal algorithms described in the paper.
/// Some methods in building and traversing the cell tree in this class were derived
/// from avtCellLocatorBIH class in the VisIT Visualization Tool.
///
/// vtkCellTreeLocator utilizes the following parent class parameters:
/// - NumberOfCellsPerNode        (default 8)
/// - CacheCellBounds             (default true)
/// - UseExistingSearchStructure  (default false)
///
/// vtkCellTreeLocator does NOT utilize the following parameters:
/// - Automatic
/// - Level
/// - MaxLevel
/// - Tolerance
/// - RetainCellLists
///
/// @warning
/// This class is templated. It may run slower than serial execution if the code
/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
///
/// From the article: "Fast, Memory-Efficient Cell location in Unstructured Grids for Visualization"
/// by Christoph Garth and Kenneth I. Joy in VisWeek, 2011.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractCellLocator vtkCellLocator vtkStaticCellLocator vtkModifiedBSPTree vtkOBBTree
/// </seealso>
public class vtkCellTreeLocator : vtkAbstractCellLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellTreeLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellTreeLocator()
	{
		MRClassNameKey = "class vtkCellTreeLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellTreeLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellTreeLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTreeLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Constructor sets the maximum number of cells in a leaf to 8 and number of buckets to 6.
	/// Buckets are used in building the cell tree as described in the paper.
	/// </summary>
	public new static vtkCellTreeLocator New()
	{
		vtkCellTreeLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTreeLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellTreeLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Constructor sets the maximum number of cells in a leaf to 8 and number of buckets to 6.
	/// Buckets are used in building the cell tree as described in the paper.
	/// </summary>
	public vtkCellTreeLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellTreeLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCellTreeLocator_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void BuildLocator()
	{
		vtkCellTreeLocator_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTreeLocator_FindCell_02(HandleRef pThis, IntPtr pos, double arg1, HandleRef cell, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Find the cell containing a given point. returns -1 if no cell found
	/// the cell parameters are copied into the supplied variables, a cell must
	/// be provided to store the information.
	/// </summary>
	public override long FindCell(IntPtr pos, double arg1, vtkGenericCell cell, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkCellTreeLocator_FindCell_02(GetCppThis(), pos, arg1, cell?.GetCppThis() ?? default(HandleRef), ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTreeLocator_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

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
		vtkCellTreeLocator_FindCellsAlongLine_03(GetCppThis(), p1, p2, tolerance, cellsIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTreeLocator_FindCellsWithinBounds_04(HandleRef pThis, IntPtr bbox, HandleRef cells);

	/// <summary>
	/// Return a list of unique cell ids inside of a given bounding box. The
	/// user must provide the vtkIdList to populate.
	/// </summary>
	public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
	{
		vtkCellTreeLocator_FindCellsWithinBounds_04(GetCppThis(), bbox, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTreeLocator_ForceBuildLocator_05(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkCellTreeLocator_ForceBuildLocator_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTreeLocator_FreeSearchStructure_06(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkCellTreeLocator_FreeSearchStructure_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTreeLocator_GenerateRepresentation_07(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkCellTreeLocator_GenerateRepresentation_07(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellTreeLocator_GetLargeIds_08(HandleRef pThis);

	/// <summary>
	/// Inform the user as to whether large ids are being used. This flag only
	/// has meaning after the locator has been built. Large ids are used when the
	/// number of binned points, or the number of bins, is &gt;= the maximum number
	/// of buckets (specified by the user). Note that LargeIds are only available
	/// on 64-bit architectures.
	/// </summary>
	public bool GetLargeIds()
	{
		return (vtkCellTreeLocator_GetLargeIds_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTreeLocator_GetNumberOfBuckets_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of buckets.
	///
	/// Default is 6.
	/// </summary>
	public virtual int GetNumberOfBuckets()
	{
		return vtkCellTreeLocator_GetNumberOfBuckets_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTreeLocator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellTreeLocator_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTreeLocator_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellTreeLocator_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTreeLocator_IntersectWithLine_12(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

	/// <summary>
	/// Return intersection point (if any) AND the cell which was intersected by
	/// the finite line. The cell is returned as a cell id and as a generic cell.
	/// </summary>
	public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
	{
		return vtkCellTreeLocator_IntersectWithLine_12(GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTreeLocator_IntersectWithLine_13(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

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
		return vtkCellTreeLocator_IntersectWithLine_13(GetCppThis(), p1, p2, tol, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTreeLocator_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellTreeLocator_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTreeLocator_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellTreeLocator_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTreeLocator_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new vtkCellTreeLocator NewInstance()
	{
		vtkCellTreeLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTreeLocator_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellTreeLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTreeLocator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static vtkCellTreeLocator SafeDownCast(vtkObjectBase o)
	{
		vtkCellTreeLocator vtkCellTreeLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTreeLocator_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellTreeLocator2 = (vtkCellTreeLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellTreeLocator2.Register(null);
			}
		}
		return vtkCellTreeLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTreeLocator_SetNumberOfBuckets_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of buckets.
	///
	/// Default is 6.
	/// </summary>
	public virtual void SetNumberOfBuckets(int _arg)
	{
		vtkCellTreeLocator_SetNumberOfBuckets_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTreeLocator_ShallowCopy_20(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Shallow copy of a vtkCellTreeLocator.
	/// </summary>
	public override void ShallowCopy(vtkAbstractCellLocator locator)
	{
		vtkCellTreeLocator_ShallowCopy_20(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}
}
