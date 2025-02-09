using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkClosestPointStrategy
/// </summary>
/// <remarks>
///    implement a specific vtkPointSet::FindCell() strategy based
///          on closest point
///
/// vtkClosestPointStrategy is implements a FindCell() strategy based on
/// locating the closest point in a dataset, and then searching the attached
/// cells. While relatively fast, it does not always return the correct result
/// (it may not find a cell, since the closest cell may not be connected to the
/// closest point). vtkCellLocatorStrategy or vtkClosestNPointsStrategy will
/// produce better results at the cost of speed.
///
/// </remarks>
/// <seealso>
///
/// vtkFindCellStrategy vtkPointSet vtkCellLocatorStrategy
/// vtkClosestNPointsStrategy
/// </seealso>
public class vtkClosestPointStrategy : vtkFindCellStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkClosestPointStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkClosestPointStrategy()
	{
		MRClassNameKey = "class vtkClosestPointStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkClosestPointStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkClosestPointStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosestPointStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vtkFindCellStrategy subclass.
	/// </summary>
	public new static vtkClosestPointStrategy New()
	{
		vtkClosestPointStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosestPointStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClosestPointStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vtkFindCellStrategy subclass.
	/// </summary>
	public vtkClosestPointStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkClosestPointStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkClosestPointStrategy_CopyParameters_01(HandleRef pThis, HandleRef from);

	/// <summary>
	/// Copy essential parameters between instances of this class. This
	/// generally is used to copy from instance prototype to another, or to copy
	/// strategies between thread instances.  Sub-classes can contribute to
	/// the parameter copying process via chaining.
	/// </summary>
	public override void CopyParameters(vtkFindCellStrategy from)
	{
		vtkClosestPointStrategy_CopyParameters_01(GetCppThis(), from?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClosestPointStrategy_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Implement the specific strategy. This method should only be called
	/// after the Initialize() method has been invoked.
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkClosestPointStrategy_FindCell_02(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), gencell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClosestPointStrategy_FindClosestPointWithinRadius_03(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

	/// <summary>
	/// Implement the specific strategy. This method should only be called
	/// after the Initialize() method has been invoked.
	/// </summary>
	public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
	{
		return vtkClosestPointStrategy_FindClosestPointWithinRadius_03(GetCppThis(), x, radius, closestPoint, cell?.GetCppThis() ?? default(HandleRef), ref cellId, ref subId, ref dist2, ref inside);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClosestPointStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkClosestPointStrategy_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkClosestPointStrategy_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkClosestPointStrategy_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosestPointStrategy_GetPointLocator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get an instance of vtkAbstractPointLocator which is used to
	/// implement the strategy for FindCell(). Note if a locator is not
	/// specified, then the default locator instantiated by the vtkPointSet
	/// provided in the Initialize() method is used.
	/// </summary>
	public virtual vtkAbstractPointLocator GetPointLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosestPointStrategy_GetPointLocator_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosestPointStrategy_Initialize_07(HandleRef pThis, HandleRef ps);

	/// <summary>
	/// Provide the necessary initialization method (see superclass for more
	/// information). This method sets up the point locator, vtkPointSet relationship.
	/// It will use the vtkPointSet's default locator if not defined by
	/// SetPointLocator() below.
	/// </summary>
	public override int Initialize(vtkPointSet ps)
	{
		return vtkClosestPointStrategy_Initialize_07(GetCppThis(), ps?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkClosestPointStrategy_InsideCellBounds_08(HandleRef pThis, IntPtr x, long cellId);

	/// <summary>
	/// Implement the specific strategy.
	/// </summary>
	public override bool InsideCellBounds(IntPtr x, long cellId)
	{
		return (vtkClosestPointStrategy_InsideCellBounds_08(GetCppThis(), x, cellId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosestPointStrategy_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkClosestPointStrategy_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkClosestPointStrategy_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkClosestPointStrategy_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosestPointStrategy_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkClosestPointStrategy NewInstance()
	{
		vtkClosestPointStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosestPointStrategy_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkClosestPointStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosestPointStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkClosestPointStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkClosestPointStrategy vtkClosestPointStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosestPointStrategy_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkClosestPointStrategy2 = (vtkClosestPointStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkClosestPointStrategy2.Register(null);
			}
		}
		return vtkClosestPointStrategy2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkClosestPointStrategy_SelectCell_14(HandleRef pThis, HandleRef self, long cellId, HandleRef cell, HandleRef gencell, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Subclasses use this method to select the current cell.
	/// </summary>
	public vtkCell SelectCell(vtkPointSet self, long cellId, vtkCell cell, vtkGenericCell gencell)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkClosestPointStrategy_SelectCell_14(GetCppThis(), self?.GetCppThis() ?? default(HandleRef), cellId, cell?.GetCppThis() ?? default(HandleRef), gencell?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkClosestPointStrategy_SetPointLocator_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get an instance of vtkAbstractPointLocator which is used to
	/// implement the strategy for FindCell(). Note if a locator is not
	/// specified, then the default locator instantiated by the vtkPointSet
	/// provided in the Initialize() method is used.
	/// </summary>
	public virtual void SetPointLocator(vtkAbstractPointLocator arg0)
	{
		vtkClosestPointStrategy_SetPointLocator_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
