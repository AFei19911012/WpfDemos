using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLinearTransformCellLocator
/// </summary>
/// <remarks>
///    Cell locator adaptor to perform cell Location on datasets that are a linear
/// transformation of the original dataset.
///
/// vtkLinearTransformCellLocator is a cell locator adaptor that can accept any cell locator, e.g.
/// vtkStaticCellLocator, vtkCellLocator, calculate the transformation matrix from the cell
/// locator adaptor's dataset to the given dataset inside BuildLocator, and then use the cell locator
/// and transformation to perform cell locator operations. The transformation matrix is computed
/// using the https://en.wikipedia.org/wiki/Kabsch_algorithm. UseAllPoints allows you to compute the
/// transformation using all the points of the dataset (use that when you are not sure if it's a
/// linear transformation) or 100 sample points (or less if the dataset is smaller) that are chosen
/// every-nth. IsLinearTransformation validates if the dataset is a linear transformation of the cell
/// locator's dataset based on the used points.
///
/// @warning The cell locator adaptor MUST be built before using it.
///
/// vtkLinearTransformCellLocator does NOT utilize ANY vtkLocator/vtkAbstractCellLocator parameter:
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractCellLocator vtkCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkModifiedBSPTree
/// vtkOBBTree
/// </seealso>
public class vtkLinearTransformCellLocator : vtkAbstractCellLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLinearTransformCellLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLinearTransformCellLocator()
	{
		MRClassNameKey = "class vtkLinearTransformCellLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearTransformCellLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLinearTransformCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransformCellLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new static vtkLinearTransformCellLocator New()
	{
		vtkLinearTransformCellLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearTransformCellLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearTransformCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public vtkLinearTransformCellLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLinearTransformCellLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void BuildLocator()
	{
		vtkLinearTransformCellLocator_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearTransformCellLocator_FindCell_02(HandleRef pThis, IntPtr x, double arg1, HandleRef cell, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Find the cell containing a given point. returns -1 if no cell found
	/// the cell parameters are copied into the supplied variables, a cell must
	/// be provided to store the information.
	///
	/// For other FindCell signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override long FindCell(IntPtr x, double arg1, vtkGenericCell cell, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkLinearTransformCellLocator_FindCell_02(GetCppThis(), x, arg1, cell?.GetCppThis() ?? default(HandleRef), ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// For each intersection with the bounds of a cell, the cellIds
	/// have the relevant information added. If cellIds is nullptr
	/// pointer, then no information is generated for that list.
	/// </summary>
	public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
	{
		vtkLinearTransformCellLocator_FindCellsAlongLine_03(GetCppThis(), p1, p2, tolerance, cellsIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_FindCellsAlongPlane_04(HandleRef pThis, IntPtr o, IntPtr n, double tolerance, HandleRef cells);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// For each intersection with the bounds of a cell, the cellIds
	/// have the relevant information added sort by t. If cellIds is nullptr
	/// pointer, then no information is generated for that list.
	/// </summary>
	public override void FindCellsAlongPlane(IntPtr o, IntPtr n, double tolerance, vtkIdList cells)
	{
		vtkLinearTransformCellLocator_FindCellsAlongPlane_04(GetCppThis(), o, n, tolerance, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_FindCellsWithinBounds_05(HandleRef pThis, IntPtr bbox, HandleRef cells);

	/// <summary>
	/// Return a list of unique cell ids inside of a given bounding box. The
	/// user must provide the vtkIdList to populate.
	///
	/// This function does NOT work when SupportLinearTransformation is on.
	/// </summary>
	public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
	{
		vtkLinearTransformCellLocator_FindCellsWithinBounds_05(GetCppThis(), bbox, cells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_FindClosestPoint_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

	/// <summary>
	/// Return the closest point and the cell which is closest to the point x.
	/// The closest point is somewhere on a cell, it need not be one of the
	/// vertices of the cell.
	///
	/// For other FindClosestPoint signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
	{
		vtkLinearTransformCellLocator_FindClosestPoint_06(GetCppThis(), x, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearTransformCellLocator_FindClosestPointWithinRadius_07(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

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
		return vtkLinearTransformCellLocator_FindClosestPointWithinRadius_07(GetCppThis(), x, radius, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2, ref inside);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_ForceBuildLocator_08(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkLinearTransformCellLocator_ForceBuildLocator_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_FreeSearchStructure_09(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkLinearTransformCellLocator_FreeSearchStructure_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkLinearTransformCellLocator_GenerateRepresentation_10(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransformCellLocator_GetCellLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the cell locator to be used internally.
	///
	/// The cell locator MUST be built before using it.
	/// </summary>
	public virtual vtkAbstractCellLocator GetCellLocator()
	{
		vtkAbstractCellLocator vtkAbstractCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearTransformCellLocator_GetCellLocator_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLinearTransformCellLocator_GetIsLinearTransformation_12(HandleRef pThis);

	/// <summary>
	/// Get if the set dataset is a linear transformation of cell locator's dataset. The value is
	/// inside BuildLocator().
	/// </summary>
	public virtual bool GetIsLinearTransformation()
	{
		return (vtkLinearTransformCellLocator_GetIsLinearTransformation_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearTransformCellLocator_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLinearTransformCellLocator_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearTransformCellLocator_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLinearTransformCellLocator_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLinearTransformCellLocator_GetUseAllPoints_15(HandleRef pThis);

	/// <summary>
	/// UseAllPoints allows to compute the transformation using all the points of the dataset
	/// (use that when you are not if it's a linear transformation) or 100 sample points
	/// (or less if the dataset is smaller) that are chosen every-nth.
	///
	/// Default is off.
	/// </summary>
	public virtual bool GetUseAllPoints()
	{
		return (vtkLinearTransformCellLocator_GetUseAllPoints_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLinearTransformCellLocator_InsideCellBounds_16(HandleRef pThis, IntPtr x, long cellId);

	/// <summary>
	/// Quickly test if a point is inside the bounds of a particular cell.
	/// This function should be used ONLY after the locator is built.
	/// </summary>
	public override bool InsideCellBounds(IntPtr x, long cellId)
	{
		return (vtkLinearTransformCellLocator_InsideCellBounds_16(GetCppThis(), x, cellId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearTransformCellLocator_IntersectWithLine_17(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

	/// <summary>
	/// Return intersection point (if any) AND the cell which was intersected by
	/// the finite line. The cell is returned as a cell id and as a generic cell.
	///
	/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
	{
		return vtkLinearTransformCellLocator_IntersectWithLine_17(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearTransformCellLocator_IntersectWithLine_18(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

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
		return vtkLinearTransformCellLocator_IntersectWithLine_18(GetCppThis(), p1, p2, tol, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearTransformCellLocator_IsA_19(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLinearTransformCellLocator_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearTransformCellLocator_IsTypeOf_20(string type);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLinearTransformCellLocator_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransformCellLocator_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new vtkLinearTransformCellLocator NewInstance()
	{
		vtkLinearTransformCellLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearTransformCellLocator_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearTransformCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearTransformCellLocator_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print and obtain type-related information.
	/// </summary>
	public new static vtkLinearTransformCellLocator SafeDownCast(vtkObjectBase o)
	{
		vtkLinearTransformCellLocator vtkLinearTransformCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearTransformCellLocator_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearTransformCellLocator2 = (vtkLinearTransformCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearTransformCellLocator2.Register(null);
			}
		}
		return vtkLinearTransformCellLocator2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_SetCellLocator_24(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set/Get the cell locator to be used internally.
	///
	/// The cell locator MUST be built before using it.
	/// </summary>
	public virtual void SetCellLocator(vtkAbstractCellLocator locator)
	{
		vtkLinearTransformCellLocator_SetCellLocator_24(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_SetUseAllPoints_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// UseAllPoints allows to compute the transformation using all the points of the dataset
	/// (use that when you are not if it's a linear transformation) or 100 sample points
	/// (or less if the dataset is smaller) that are chosen every-nth.
	///
	/// Default is off.
	/// </summary>
	public virtual void SetUseAllPoints(bool _arg)
	{
		vtkLinearTransformCellLocator_SetUseAllPoints_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_ShallowCopy_26(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Shallow copy of a vtkLinearTransformCellLocator.
	/// </summary>
	public override void ShallowCopy(vtkAbstractCellLocator locator)
	{
		vtkLinearTransformCellLocator_ShallowCopy_26(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_UseAllPointsOff_27(HandleRef pThis);

	/// <summary>
	/// UseAllPoints allows to compute the transformation using all the points of the dataset
	/// (use that when you are not if it's a linear transformation) or 100 sample points
	/// (or less if the dataset is smaller) that are chosen every-nth.
	///
	/// Default is off.
	/// </summary>
	public virtual void UseAllPointsOff()
	{
		vtkLinearTransformCellLocator_UseAllPointsOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLinearTransformCellLocator_UseAllPointsOn_28(HandleRef pThis);

	/// <summary>
	/// UseAllPoints allows to compute the transformation using all the points of the dataset
	/// (use that when you are not if it's a linear transformation) or 100 sample points
	/// (or less if the dataset is smaller) that are chosen every-nth.
	///
	/// Default is off.
	/// </summary>
	public virtual void UseAllPointsOn()
	{
		vtkLinearTransformCellLocator_UseAllPointsOn_28(GetCppThis());
	}
}
