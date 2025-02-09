using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMergeCells
/// </summary>
/// <remarks>
///    merges any number of vtkDataSets back into a single
///   vtkUnstructuredGrid
///
///
///    Designed to work with distributed vtkDataSets, this class will take
///    vtkDataSets and merge them back into a single vtkUnstructuredGrid.
///
///    The vtkPoints object of the unstructured grid will have data type
///    VTK_FLOAT if input is not of type vtkPointSet, otherwise it will have same
///    data type than the input point set.
///
///    It is assumed the different DataSets have the same field arrays.  If
///    the name of a global point ID array is provided, this class will
///    refrain from including duplicate points in the merged Ugrid.  This
///    class differs from vtkAppendFilter in these ways: (1) it uses less
///    memory than that class (which uses memory equal to twice the size
///    of the final Ugrid) but requires that you know the size of the
///    final Ugrid in advance (2) this class assumes the individual DataSets have
///    the same field arrays, while vtkAppendFilter intersects the field
///    arrays (3) this class knows duplicate points may be appearing in
///    the DataSets and can filter those out, (4) this class is not a filter.
/// </remarks>
public class vtkMergeCells : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMergeCells";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMergeCells()
	{
		MRClassNameKey = "class vtkMergeCells";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeCells"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMergeCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeCells New()
	{
		vtkMergeCells result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeCells_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMergeCells()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMergeCells_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_Finish_01(HandleRef pThis);

	/// <summary>
	/// Call Finish() after merging last DataSet to free unneeded memory and to
	/// make sure the ugrid's GetNumberOfPoints() reflects the actual
	/// number of points set, not the number allocated.
	/// </summary>
	public void Finish()
	{
		vtkMergeCells_Finish_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMergeCells_GetMergeDuplicatePoints_02(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  If for some reason you don't want it to do this,
	/// than MergeDuplicatePointsOff().
	/// </summary>
	public virtual bool GetMergeDuplicatePoints()
	{
		return (vtkMergeCells_GetMergeDuplicatePoints_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeCells_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMergeCells_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeCells_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMergeCells_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeCells_GetOutputPointsPrecision_05(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkMergeCells_GetOutputPointsPrecision_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMergeCells_GetPointMergeTolerance_06(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  If no global point ID field array name is provided,
	/// it will use a point locator to find duplicate points.  You can
	/// set a tolerance for that locator here.  The default tolerance
	/// is 10e-4.
	/// </summary>
	public virtual double GetPointMergeTolerance()
	{
		return vtkMergeCells_GetPointMergeTolerance_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMergeCells_GetPointMergeToleranceMaxValue_07(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  If no global point ID field array name is provided,
	/// it will use a point locator to find duplicate points.  You can
	/// set a tolerance for that locator here.  The default tolerance
	/// is 10e-4.
	/// </summary>
	public virtual double GetPointMergeToleranceMaxValue()
	{
		return vtkMergeCells_GetPointMergeToleranceMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMergeCells_GetPointMergeToleranceMinValue_08(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  If no global point ID field array name is provided,
	/// it will use a point locator to find duplicate points.  You can
	/// set a tolerance for that locator here.  The default tolerance
	/// is 10e-4.
	/// </summary>
	public virtual double GetPointMergeToleranceMinValue()
	{
		return vtkMergeCells_GetPointMergeToleranceMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeCells_GetTotalNumberOfCells_09(HandleRef pThis);

	/// <summary>
	/// Specify the total number of cells in the final vtkUnstructuredGrid.
	/// Make this call before any call to MergeDataSet().
	/// </summary>
	public virtual long GetTotalNumberOfCells()
	{
		return vtkMergeCells_GetTotalNumberOfCells_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeCells_GetTotalNumberOfDataSets_10(HandleRef pThis);

	/// <summary>
	/// We need to know the number of different data sets that will
	/// be merged into one so we can pre-allocate some arrays.
	/// This can be an upper bound, not necessarily exact.
	/// </summary>
	public virtual int GetTotalNumberOfDataSets()
	{
		return vtkMergeCells_GetTotalNumberOfDataSets_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeCells_GetTotalNumberOfPoints_11(HandleRef pThis);

	/// <summary>
	/// Specify the total number of points in the final vtkUnstructuredGrid
	/// Make this call before any call to MergeDataSet().  This is an
	/// upper bound, since some points may be duplicates.
	/// </summary>
	public virtual long GetTotalNumberOfPoints()
	{
		return vtkMergeCells_GetTotalNumberOfPoints_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeCells_GetUnstructuredGrid_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the vtkUnstructuredGrid object that will become the
	/// union of the DataSets specified in MergeDataSet calls.
	/// vtkMergeCells assumes this grid is empty at first.
	/// </summary>
	public virtual vtkUnstructuredGrid GetUnstructuredGrid()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeCells_GetUnstructuredGrid_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeCells_GetUseGlobalCellIds_13(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells will detect and filter out duplicate cells if you
	/// provide it the name of a global cell ID array.
	/// </summary>
	public virtual int GetUseGlobalCellIds()
	{
		return vtkMergeCells_GetUseGlobalCellIds_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeCells_GetUseGlobalIds_14(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  This is done most efficiently if a global point ID
	/// field array is available.  Set the name of the point array if you
	/// have one.
	/// </summary>
	public virtual int GetUseGlobalIds()
	{
		return vtkMergeCells_GetUseGlobalIds_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_InvalidateCachedLocator_15(HandleRef pThis);

	/// <summary>
	/// Clear the Locator and set it to nullptr.
	/// </summary>
	public void InvalidateCachedLocator()
	{
		vtkMergeCells_InvalidateCachedLocator_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeCells_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMergeCells_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeCells_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMergeCells_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeCells_MergeDataSet_18(HandleRef pThis, HandleRef set);

	/// <summary>
	/// Provide a DataSet to be merged in to the final UnstructuredGrid.
	/// This call returns after the merge has completed.  Be sure to call
	/// SetTotalNumberOfCells, SetTotalNumberOfPoints, and SetTotalNumberOfDataSets
	/// before making this call.  Return 0 if OK, -1 if error.
	/// </summary>
	public int MergeDataSet(vtkDataSet set)
	{
		return vtkMergeCells_MergeDataSet_18(GetCppThis(), set?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_MergeDuplicatePointsOff_19(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  If for some reason you don't want it to do this,
	/// than MergeDuplicatePointsOff().
	/// </summary>
	public virtual void MergeDuplicatePointsOff()
	{
		vtkMergeCells_MergeDuplicatePointsOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_MergeDuplicatePointsOn_20(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  If for some reason you don't want it to do this,
	/// than MergeDuplicatePointsOff().
	/// </summary>
	public virtual void MergeDuplicatePointsOn()
	{
		vtkMergeCells_MergeDuplicatePointsOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeCells_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMergeCells NewInstance()
	{
		vtkMergeCells result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeCells_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeCells_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeCells SafeDownCast(vtkObjectBase o)
	{
		vtkMergeCells vtkMergeCells2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeCells_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMergeCells2 = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMergeCells2.Register(null);
			}
		}
		return vtkMergeCells2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetMergeDuplicatePoints_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  If for some reason you don't want it to do this,
	/// than MergeDuplicatePointsOff().
	/// </summary>
	public virtual void SetMergeDuplicatePoints(bool _arg)
	{
		vtkMergeCells_SetMergeDuplicatePoints_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetOutputPointsPrecision_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkMergeCells_SetOutputPointsPrecision_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetPointMergeTolerance_26(HandleRef pThis, double _arg);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  If no global point ID field array name is provided,
	/// it will use a point locator to find duplicate points.  You can
	/// set a tolerance for that locator here.  The default tolerance
	/// is 10e-4.
	/// </summary>
	public virtual void SetPointMergeTolerance(double _arg)
	{
		vtkMergeCells_SetPointMergeTolerance_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetTotalNumberOfCells_27(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the total number of cells in the final vtkUnstructuredGrid.
	/// Make this call before any call to MergeDataSet().
	/// </summary>
	public virtual void SetTotalNumberOfCells(long _arg)
	{
		vtkMergeCells_SetTotalNumberOfCells_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetTotalNumberOfDataSets_28(HandleRef pThis, int _arg);

	/// <summary>
	/// We need to know the number of different data sets that will
	/// be merged into one so we can pre-allocate some arrays.
	/// This can be an upper bound, not necessarily exact.
	/// </summary>
	public virtual void SetTotalNumberOfDataSets(int _arg)
	{
		vtkMergeCells_SetTotalNumberOfDataSets_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetTotalNumberOfPoints_29(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the total number of points in the final vtkUnstructuredGrid
	/// Make this call before any call to MergeDataSet().  This is an
	/// upper bound, since some points may be duplicates.
	/// </summary>
	public virtual void SetTotalNumberOfPoints(long _arg)
	{
		vtkMergeCells_SetTotalNumberOfPoints_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetUnstructuredGrid_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the vtkUnstructuredGrid object that will become the
	/// union of the DataSets specified in MergeDataSet calls.
	/// vtkMergeCells assumes this grid is empty at first.
	/// </summary>
	public virtual void SetUnstructuredGrid(vtkUnstructuredGrid arg0)
	{
		vtkMergeCells_SetUnstructuredGrid_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetUseGlobalCellIds_31(HandleRef pThis, int _arg);

	/// <summary>
	/// vtkMergeCells will detect and filter out duplicate cells if you
	/// provide it the name of a global cell ID array.
	/// </summary>
	public virtual void SetUseGlobalCellIds(int _arg)
	{
		vtkMergeCells_SetUseGlobalCellIds_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_SetUseGlobalIds_32(HandleRef pThis, int _arg);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  This is done most efficiently if a global point ID
	/// field array is available.  Set the name of the point array if you
	/// have one.
	/// </summary>
	public virtual void SetUseGlobalIds(int _arg)
	{
		vtkMergeCells_SetUseGlobalIds_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_UseGlobalCellIdsOff_33(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells will detect and filter out duplicate cells if you
	/// provide it the name of a global cell ID array.
	/// </summary>
	public virtual void UseGlobalCellIdsOff()
	{
		vtkMergeCells_UseGlobalCellIdsOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_UseGlobalCellIdsOn_34(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells will detect and filter out duplicate cells if you
	/// provide it the name of a global cell ID array.
	/// </summary>
	public virtual void UseGlobalCellIdsOn()
	{
		vtkMergeCells_UseGlobalCellIdsOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_UseGlobalIdsOff_35(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  This is done most efficiently if a global point ID
	/// field array is available.  Set the name of the point array if you
	/// have one.
	/// </summary>
	public virtual void UseGlobalIdsOff()
	{
		vtkMergeCells_UseGlobalIdsOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeCells_UseGlobalIdsOn_36(HandleRef pThis);

	/// <summary>
	/// vtkMergeCells attempts eliminate duplicate points when merging
	/// data sets.  This is done most efficiently if a global point ID
	/// field array is available.  Set the name of the point array if you
	/// have one.
	/// </summary>
	public virtual void UseGlobalIdsOn()
	{
		vtkMergeCells_UseGlobalIdsOn_36(GetCppThis());
	}
}
