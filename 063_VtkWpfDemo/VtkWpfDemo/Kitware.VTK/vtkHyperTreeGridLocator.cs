using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkHyperTreeGridLocator
/// </summary>
/// <remarks>
///  abstract base class for objects that implement accelerated searches through HyperTree
/// Grids (HTGs)
///
/// The goal of this abstract class is to define an interface to helper objects that implement
/// optimized search methods through vtkHyperTreeGrids. This class is heavily inspired from the
/// vtkLocator interface but constructed to be compatible with vtkHyperTreeGrids (which are not
/// vtkDataSets at the time of this implementation). Ideally, implementations of this interface
/// leverage the specific structure of HyperTrees and HyperTreeGrids to deliver accelerated search
/// algorithms through their data.
///
/// As a side comment: ideally we would inherit from vtkLocator which only supports vtkDataSets right
/// now. Hopefully in the future vtkHyperTreeGrid will become a vtkDataSet or vtkCompositeDataSet and
/// we could accomplish just that with minimal refactoring.
///
/// </remarks>
/// <seealso>
///
/// vtkHyperTreeGrid, vtkHyperTree, vtkHyperTreeGridOrientedCursor, vtkHyperTreeGridNonOrientedCursor
/// </seealso>
public abstract class vtkHyperTreeGridLocator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperTreeGridLocator()
	{
		MRClassNameKey = "class vtkHyperTreeGridLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperTreeGridLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkHyperTreeGridLocator_FindCell_01(HandleRef pThis, IntPtr point, double tol, HandleRef cell, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Pure virtual. Find the cell where a given point lies
	/// @param[in] point an array holding the coordinates of the point to search for
	/// @param[in] tol tolerance level
	/// @param[out] cell pointer to a cell configured with information from return value cell index
	/// @param[out] subId index of the sub cell if composite cell
	/// @param[out] pcoords parametric coordinates of the point in the cell
	/// @param[out] weights interpolation weights of the sought point in the cell
	/// @return the global index of the cell holding the point (-1 if no cell is found or masked)
	/// </summary>
	public virtual long FindCell(IntPtr point, double tol, vtkGenericCell cell, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkHyperTreeGridLocator_FindCell_01(GetCppThis(), point, tol, cell?.GetCppThis() ?? default(HandleRef), ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridLocator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperTreeGridLocator_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridLocator_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperTreeGridLocator_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperTreeGridLocator_GetTolerance_04(HandleRef pThis);

	/// <summary>
	/// Get/Set tolerance used when searching for cells in the HTG.
	/// Default is 0.0
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkHyperTreeGridLocator_GetTolerance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridLocator_Initialize_05(HandleRef pThis);

	/// <summary>
	/// Initialize or reinitialize the locator (setting or re-setting clean objects in memory)
	/// (Does nothing)
	/// </summary>
	public virtual void Initialize()
	{
		vtkHyperTreeGridLocator_Initialize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridLocator_IntersectWithLine_06(HandleRef pThis, IntPtr p0, IntPtr p1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

	/// <summary>
	/// Pure virtual. Find first intersection of the line defined by (p0, p1) with the HTG
	/// @param[in] p0 first point of the line
	/// @param[in] p1 second point of the line
	/// @param[in] tol tolerance level
	/// @param[out] t pseudo-time along line path at intersection
	/// @param[out] x intersection point
	/// @param[out] pcoords parametric coordinatesof intersection
	/// @param[out] subId index of the sub cell if composite cell
	/// @param[out] cellId the global index of the intersected cell
	/// @param[out] cell pointer to a vtkCell object corresponding to cellId
	/// @return an integer with 0 if no intersection could be found
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p0, IntPtr p1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
	{
		return vtkHyperTreeGridLocator_IntersectWithLine_06(GetCppThis(), p0, p1, tol, ref t, x, pcoords, ref subId, ref cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridLocator_IntersectWithLine_07(HandleRef pThis, IntPtr p0, IntPtr p1, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

	/// <summary>
	/// Pure virtual. Find all intersections of the line defined by (p0, p1) with the HTG
	/// @param[in] p0 first point of the line
	/// @param[in] p1 second point of the line
	/// @param[in] tol tolerance level
	/// @param[out] points array of points on the line intersecting the HTG
	/// @param[out] cellIds array of cellIds holding the different points of the points array
	/// @param[out] cell pointer to a vtkCell object corresponding to the last cellId found
	/// @return an integer with 0 if no intersection could be found
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p0, IntPtr p1, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
	{
		return vtkHyperTreeGridLocator_IntersectWithLine_07(GetCppThis(), p0, p1, tol, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridLocator_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperTreeGridLocator_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTreeGridLocator_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperTreeGridLocator_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridLocator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperTreeGridLocator NewInstance()
	{
		vtkHyperTreeGridLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridLocator_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTreeGridLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTreeGridLocator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTreeGridLocator SafeDownCast(vtkObjectBase o)
	{
		vtkHyperTreeGridLocator vtkHyperTreeGridLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTreeGridLocator_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTreeGridLocator2 = (vtkHyperTreeGridLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTreeGridLocator2.Register(null);
			}
		}
		return vtkHyperTreeGridLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTreeGridLocator_Search_12(HandleRef pThis, IntPtr point);

	/// <summary>
	/// Basic search for cell holding a given point
	/// @param point coordinated of sought point
	/// @return the global index of the cell holding the point (-1 if cell not found or masked)
	/// </summary>
	public virtual long Search(IntPtr point)
	{
		return vtkHyperTreeGridLocator_Search_12(GetCppThis(), point);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridLocator_SetTolerance_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set tolerance used when searching for cells in the HTG.
	/// Default is 0.0
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkHyperTreeGridLocator_SetTolerance_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTreeGridLocator_Update_14(HandleRef pThis);

	/// <summary>
	/// Update the locator's internal variables with respect to changes that could have happened
	/// outside.
	/// </summary>
	public virtual void Update()
	{
		vtkHyperTreeGridLocator_Update_14(GetCppThis());
	}
}
