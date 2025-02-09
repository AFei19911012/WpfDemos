using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractCells
/// </summary>
/// <remarks>
///    subset a vtkDataSet to create a vtkUnstructuredGrid
///
///
///    Given a vtkDataSet and a list of cell ids, create a vtkUnstructuredGrid
///    composed of these cells.  If the cell list is empty when vtkExtractCells
///    executes, it will set up the ugrid, point and cell arrays, with no points,
///    cells or data.
/// </remarks>
public class vtkExtractCells : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCells";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractCells()
	{
		MRClassNameKey = "class vtkExtractCells";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCells"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtkExtractCells New()
	{
		vtkExtractCells result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCells_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public vtkExtractCells()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractCells_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_AddCellIds_01(HandleRef pThis, IntPtr ptr, long numValues);

	/// <summary>
	/// Another way to provide ids using a pointer to vtkIdType array.
	/// </summary>
	public void AddCellIds(IntPtr ptr, long numValues)
	{
		vtkExtractCells_AddCellIds_01(GetCppThis(), ptr, numValues);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_AddCellList_02(HandleRef pThis, HandleRef l);

	/// <summary>
	/// Add the supplied list of cell IDs to those that will be included in the
	/// output vtkUnstructuredGrid. The cell ids should be &gt;=0.
	/// </summary>
	public void AddCellList(vtkIdList l)
	{
		vtkExtractCells_AddCellList_02(GetCppThis(), l?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_AddCellRange_03(HandleRef pThis, long from, long to);

	/// <summary>
	/// Add this range of cell IDs to those that will be included in the output
	/// vtkUnstructuredGrid. Note that (from &lt; to), and (from &gt;= 0).
	/// </summary>
	public void AddCellRange(long from, long to)
	{
		vtkExtractCells_AddCellRange_03(GetCppThis(), from, to);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_AssumeSortedAndUniqueIdsOff_04(HandleRef pThis);

	/// <summary>
	/// If the cell ids specified are already sorted and unique, then set this to
	/// true to avoid the filter from doing time-consuming sorts and uniquification
	/// operations. Defaults to false.
	/// </summary>
	public virtual void AssumeSortedAndUniqueIdsOff()
	{
		vtkExtractCells_AssumeSortedAndUniqueIdsOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_AssumeSortedAndUniqueIdsOn_05(HandleRef pThis);

	/// <summary>
	/// If the cell ids specified are already sorted and unique, then set this to
	/// true to avoid the filter from doing time-consuming sorts and uniquification
	/// operations. Defaults to false.
	/// </summary>
	public virtual void AssumeSortedAndUniqueIdsOn()
	{
		vtkExtractCells_AssumeSortedAndUniqueIdsOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_ExtractAllCellsOff_06(HandleRef pThis);

	/// <summary>
	/// If all cells are being extracted, this filter can use fast path to speed up
	/// the extraction. In that case, one can set this flag to true. When set to
	/// true, cell ids added via the various methods are simply ignored.
	/// Defaults to false.
	/// </summary>
	public virtual void ExtractAllCellsOff()
	{
		vtkExtractCells_ExtractAllCellsOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_ExtractAllCellsOn_07(HandleRef pThis);

	/// <summary>
	/// If all cells are being extracted, this filter can use fast path to speed up
	/// the extraction. In that case, one can set this flag to true. When set to
	/// true, cell ids added via the various methods are simply ignored.
	/// Defaults to false.
	/// </summary>
	public virtual void ExtractAllCellsOn()
	{
		vtkExtractCells_ExtractAllCellsOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractCells_GetAssumeSortedAndUniqueIds_08(HandleRef pThis);

	/// <summary>
	/// If the cell ids specified are already sorted and unique, then set this to
	/// true to avoid the filter from doing time-consuming sorts and uniquification
	/// operations. Defaults to false.
	/// </summary>
	public virtual bool GetAssumeSortedAndUniqueIds()
	{
		return (vtkExtractCells_GetAssumeSortedAndUniqueIds_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractCells_GetExtractAllCells_09(HandleRef pThis);

	/// <summary>
	/// If all cells are being extracted, this filter can use fast path to speed up
	/// the extraction. In that case, one can set this flag to true. When set to
	/// true, cell ids added via the various methods are simply ignored.
	/// Defaults to false.
	/// </summary>
	public virtual bool GetExtractAllCells()
	{
		return (vtkExtractCells_GetExtractAllCells_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractCells_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractCells_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractCells_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractCells_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCells_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractCells_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCells_IsTypeOf_13(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractCells_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCells_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new vtkExtractCells NewInstance()
	{
		vtkExtractCells result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCells_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCells_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtkExtractCells SafeDownCast(vtkObjectBase o)
	{
		vtkExtractCells vtkExtractCells2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCells_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractCells2 = (vtkExtractCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractCells2.Register(null);
			}
		}
		return vtkExtractCells2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_SetAssumeSortedAndUniqueIds_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// If the cell ids specified are already sorted and unique, then set this to
	/// true to avoid the filter from doing time-consuming sorts and uniquification
	/// operations. Defaults to false.
	/// </summary>
	public virtual void SetAssumeSortedAndUniqueIds(bool _arg)
	{
		vtkExtractCells_SetAssumeSortedAndUniqueIds_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_SetCellIds_18(HandleRef pThis, IntPtr ptr, long numValues);

	/// <summary>
	/// Another way to provide ids using a pointer to vtkIdType array.
	/// </summary>
	public void SetCellIds(IntPtr ptr, long numValues)
	{
		vtkExtractCells_SetCellIds_18(GetCppThis(), ptr, numValues);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_SetCellList_19(HandleRef pThis, HandleRef l);

	/// <summary>
	/// Set the list of cell IDs that the output vtkUnstructuredGrid will be
	/// composed of.  Replaces any other cell ID list supplied so far.  (Set to
	/// nullptr to free memory used by cell list.)  The cell ids should be &gt;=0.
	/// </summary>
	public void SetCellList(vtkIdList l)
	{
		vtkExtractCells_SetCellList_19(GetCppThis(), l?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCells_SetExtractAllCells_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// If all cells are being extracted, this filter can use fast path to speed up
	/// the extraction. In that case, one can set this flag to true. When set to
	/// true, cell ids added via the various methods are simply ignored.
	/// Defaults to false.
	/// </summary>
	public virtual void SetExtractAllCells(bool _arg)
	{
		vtkExtractCells_SetExtractAllCells_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
