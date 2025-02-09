using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResampleWithDataSet
/// </summary>
/// <remarks>
///    sample point and cell data of a dataset on
/// points from another dataset.
///
/// Similar to vtkCompositeDataProbeFilter, vtkResampleWithDataSet takes two
/// inputs - Input and Source, and samples the point and cell values of Source
/// on to the point locations of Input. The output has the same structure as
/// Input but its point data have the resampled values from Source. Unlike
/// vtkCompositeDataProbeFilter, this filter support composite datasets for both
/// Input and Source.
/// </remarks>
/// <seealso>
///
/// vtkCompositeDataProbeFilter vtkResampleToImage
/// </seealso>
public class vtkResampleWithDataSet : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResampleWithDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResampleWithDataSet()
	{
		MRClassNameKey = "class vtkResampleWithDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResampleWithDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResampleWithDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleWithDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResampleWithDataSet New()
	{
		vtkResampleWithDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResampleWithDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResampleWithDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkResampleWithDataSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResampleWithDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_ComputeToleranceOff_01(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field
	/// value is ignored. Off by default.
	/// </summary>
	public virtual void ComputeToleranceOff()
	{
		vtkResampleWithDataSet_ComputeToleranceOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_ComputeToleranceOn_02(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field
	/// value is ignored. Off by default.
	/// </summary>
	public virtual void ComputeToleranceOn()
	{
		vtkResampleWithDataSet_ComputeToleranceOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleWithDataSet_GetCategoricalData_03(HandleRef pThis);

	/// <summary>
	/// Control whether the source point data is to be treated as categorical. If
	/// the data is categorical, then the resultant data will be determined by
	/// a nearest neighbor interpolation scheme.
	/// </summary>
	public bool GetCategoricalData()
	{
		return (vtkResampleWithDataSet_GetCategoricalData_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleWithDataSet_GetCellLocatorPrototype_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public virtual vtkAbstractCellLocator GetCellLocatorPrototype()
	{
		vtkAbstractCellLocator vtkAbstractCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResampleWithDataSet_GetCellLocatorPrototype_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleWithDataSet_GetComputeTolerance_05(HandleRef pThis);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field
	/// value is ignored. Off by default.
	/// </summary>
	public bool GetComputeTolerance()
	{
		return (vtkResampleWithDataSet_GetComputeTolerance_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkResampleWithDataSet_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkResampleWithDataSet_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleWithDataSet_GetMarkBlankPointsAndCells_07(HandleRef pThis);

	/// <summary>
	/// Set whether points without resampled values, and their corresponding cells,
	/// should be marked as Blank. Default is On.
	/// </summary>
	public virtual bool GetMarkBlankPointsAndCells()
	{
		return (vtkResampleWithDataSet_GetMarkBlankPointsAndCells_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResampleWithDataSet_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResampleWithDataSet_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResampleWithDataSet_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResampleWithDataSet_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleWithDataSet_GetPassCellArrays_10(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public bool GetPassCellArrays()
	{
		return (vtkResampleWithDataSet_GetPassCellArrays_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleWithDataSet_GetPassFieldArrays_11(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public bool GetPassFieldArrays()
	{
		return (vtkResampleWithDataSet_GetPassFieldArrays_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleWithDataSet_GetPassPartialArrays_12(HandleRef pThis);

	/// <summary>
	/// When sampling from composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in
	/// all the blocks i.e. partial arrays are removed.  When PassPartialArrays is
	/// turned on, this behavior is changed to take a union of all arrays present
	/// thus partial arrays are passed as well. However, for composite dataset
	/// input, this filter still produces a non-composite output. For all those
	/// locations in a block of where a particular data array is missing, this
	/// filter uses vtkMath::Nan() for double and float arrays, and 0 for all
	/// other types of arrays e.g. int, char, etc. Off by default.
	/// </summary>
	public bool GetPassPartialArrays()
	{
		return (vtkResampleWithDataSet_GetPassPartialArrays_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleWithDataSet_GetPassPointArrays_13(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public bool GetPassPointArrays()
	{
		return (vtkResampleWithDataSet_GetPassPointArrays_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkResampleWithDataSet_GetSnapToCellWithClosestPoint_14(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public bool GetSnapToCellWithClosestPoint()
	{
		return (vtkResampleWithDataSet_GetSnapToCellWithClosestPoint_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkResampleWithDataSet_GetTolerance_15(HandleRef pThis);

	/// <summary>
	/// Set the tolerance used to compute whether a point in the
	/// source is in a cell of the input.  This value is only used
	/// if ComputeTolerance is off.
	/// </summary>
	public double GetTolerance()
	{
		return vtkResampleWithDataSet_GetTolerance_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResampleWithDataSet_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResampleWithDataSet_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResampleWithDataSet_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResampleWithDataSet_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_MarkBlankPointsAndCellsOff_18(HandleRef pThis);

	/// <summary>
	/// Set whether points without resampled values, and their corresponding cells,
	/// should be marked as Blank. Default is On.
	/// </summary>
	public virtual void MarkBlankPointsAndCellsOff()
	{
		vtkResampleWithDataSet_MarkBlankPointsAndCellsOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_MarkBlankPointsAndCellsOn_19(HandleRef pThis);

	/// <summary>
	/// Set whether points without resampled values, and their corresponding cells,
	/// should be marked as Blank. Default is On.
	/// </summary>
	public virtual void MarkBlankPointsAndCellsOn()
	{
		vtkResampleWithDataSet_MarkBlankPointsAndCellsOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleWithDataSet_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkResampleWithDataSet NewInstance()
	{
		vtkResampleWithDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResampleWithDataSet_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResampleWithDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_PassCellArraysOff_22(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual void PassCellArraysOff()
	{
		vtkResampleWithDataSet_PassCellArraysOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_PassCellArraysOn_23(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public virtual void PassCellArraysOn()
	{
		vtkResampleWithDataSet_PassCellArraysOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_PassFieldArraysOff_24(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOff()
	{
		vtkResampleWithDataSet_PassFieldArraysOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_PassFieldArraysOn_25(HandleRef pThis);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public virtual void PassFieldArraysOn()
	{
		vtkResampleWithDataSet_PassFieldArraysOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_PassPartialArraysOff_26(HandleRef pThis);

	/// <summary>
	/// When sampling from composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in
	/// all the blocks i.e. partial arrays are removed.  When PassPartialArrays is
	/// turned on, this behavior is changed to take a union of all arrays present
	/// thus partial arrays are passed as well. However, for composite dataset
	/// input, this filter still produces a non-composite output. For all those
	/// locations in a block of where a particular data array is missing, this
	/// filter uses vtkMath::Nan() for double and float arrays, and 0 for all
	/// other types of arrays e.g. int, char, etc. Off by default.
	/// </summary>
	public virtual void PassPartialArraysOff()
	{
		vtkResampleWithDataSet_PassPartialArraysOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_PassPartialArraysOn_27(HandleRef pThis);

	/// <summary>
	/// When sampling from composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in
	/// all the blocks i.e. partial arrays are removed.  When PassPartialArrays is
	/// turned on, this behavior is changed to take a union of all arrays present
	/// thus partial arrays are passed as well. However, for composite dataset
	/// input, this filter still produces a non-composite output. For all those
	/// locations in a block of where a particular data array is missing, this
	/// filter uses vtkMath::Nan() for double and float arrays, and 0 for all
	/// other types of arrays e.g. int, char, etc. Off by default.
	/// </summary>
	public virtual void PassPartialArraysOn()
	{
		vtkResampleWithDataSet_PassPartialArraysOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_PassPointArraysOff_28(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual void PassPointArraysOff()
	{
		vtkResampleWithDataSet_PassPointArraysOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_PassPointArraysOn_29(HandleRef pThis);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public virtual void PassPointArraysOn()
	{
		vtkResampleWithDataSet_PassPointArraysOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResampleWithDataSet_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResampleWithDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkResampleWithDataSet vtkResampleWithDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResampleWithDataSet_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResampleWithDataSet2 = (vtkResampleWithDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResampleWithDataSet2.Register(null);
			}
		}
		return vtkResampleWithDataSet2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetCategoricalData_31(HandleRef pThis, byte arg);

	/// <summary>
	/// Control whether the source point data is to be treated as categorical. If
	/// the data is categorical, then the resultant data will be determined by
	/// a nearest neighbor interpolation scheme.
	/// </summary>
	public void SetCategoricalData(bool arg)
	{
		vtkResampleWithDataSet_SetCategoricalData_31(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetCellLocatorPrototype_32(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public virtual void SetCellLocatorPrototype(vtkAbstractCellLocator arg0)
	{
		vtkResampleWithDataSet_SetCellLocatorPrototype_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetComputeTolerance_33(HandleRef pThis, byte arg);

	/// <summary>
	/// Set whether to use the Tolerance field or precompute the tolerance.
	/// When on, the tolerance will be computed and the field
	/// value is ignored. Off by default.
	/// </summary>
	public void SetComputeTolerance(bool arg)
	{
		vtkResampleWithDataSet_SetComputeTolerance_33(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetMarkBlankPointsAndCells_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether points without resampled values, and their corresponding cells,
	/// should be marked as Blank. Default is On.
	/// </summary>
	public virtual void SetMarkBlankPointsAndCells(bool _arg)
	{
		vtkResampleWithDataSet_SetMarkBlankPointsAndCells_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetPassCellArrays_35(HandleRef pThis, byte arg);

	/// <summary>
	/// Shallow copy the input cell data arrays to the output.
	/// Off by default.
	/// </summary>
	public void SetPassCellArrays(bool arg)
	{
		vtkResampleWithDataSet_SetPassCellArrays_35(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetPassFieldArrays_36(HandleRef pThis, byte arg);

	/// <summary>
	/// Set whether to pass the field-data arrays from the Input i.e. the input
	/// providing the geometry to the output. On by default.
	/// </summary>
	public void SetPassFieldArrays(bool arg)
	{
		vtkResampleWithDataSet_SetPassFieldArrays_36(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetPassPartialArrays_37(HandleRef pThis, byte arg);

	/// <summary>
	/// When sampling from composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in
	/// all the blocks i.e. partial arrays are removed.  When PassPartialArrays is
	/// turned on, this behavior is changed to take a union of all arrays present
	/// thus partial arrays are passed as well. However, for composite dataset
	/// input, this filter still produces a non-composite output. For all those
	/// locations in a block of where a particular data array is missing, this
	/// filter uses vtkMath::Nan() for double and float arrays, and 0 for all
	/// other types of arrays e.g. int, char, etc. Off by default.
	/// </summary>
	public void SetPassPartialArrays(bool arg)
	{
		vtkResampleWithDataSet_SetPassPartialArrays_37(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetPassPointArrays_38(HandleRef pThis, byte arg);

	/// <summary>
	/// Shallow copy the input point data arrays to the output
	/// Off by default.
	/// </summary>
	public void SetPassPointArrays(bool arg)
	{
		vtkResampleWithDataSet_SetPassPointArrays_38(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetSnapToCellWithClosestPoint_39(HandleRef pThis, byte arg);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public void SetSnapToCellWithClosestPoint(bool arg)
	{
		vtkResampleWithDataSet_SetSnapToCellWithClosestPoint_39(GetCppThis(), (byte)(arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetSourceConnection_40(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the data set that will be probed at the input points.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is probed (interpolated) to generate the scalars,
	/// vectors, etc. for the output points based on the point locations.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkResampleWithDataSet_SetSourceConnection_40(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetSourceData_41(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the data set that will be probed at the input points.
	/// The Input gives the geometry (the points and cells) for the output,
	/// while the Source is probed (interpolated) to generate the scalars,
	/// vectors, etc. for the output points based on the point locations.
	/// </summary>
	public void SetSourceData(vtkDataObject source)
	{
		vtkResampleWithDataSet_SetSourceData_41(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SetTolerance_42(HandleRef pThis, double arg);

	/// <summary>
	/// Set the tolerance used to compute whether a point in the
	/// source is in a cell of the input.  This value is only used
	/// if ComputeTolerance is off.
	/// </summary>
	public void SetTolerance(double arg)
	{
		vtkResampleWithDataSet_SetTolerance_42(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SnapToCellWithClosestPointOff_43(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public virtual void SnapToCellWithClosestPointOff()
	{
		vtkResampleWithDataSet_SnapToCellWithClosestPointOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResampleWithDataSet_SnapToCellWithClosestPointOn_44(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
	/// FindCell is executed.
	///
	/// Default is off.
	///
	/// Note: This is useful only when the source is a vtkPointSet.
	/// </summary>
	public virtual void SnapToCellWithClosestPointOn()
	{
		vtkResampleWithDataSet_SnapToCellWithClosestPointOn_44(GetCppThis());
	}
}
