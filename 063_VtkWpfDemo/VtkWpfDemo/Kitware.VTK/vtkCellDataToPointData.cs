using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellDataToPointData
/// </summary>
/// <remarks>
///    map cell data to point data
///
/// vtkCellDataToPointData is a filter that transforms cell data (i.e., data
/// specified per cell) into point data (i.e., data specified at cell
/// points). The method of transformation is based on averaging the data
/// values of all cells using each point. For large datasets with
/// several cell data arrays, the filter optionally supports selective
/// processing to speed up processing. Optionally, the input cell data can
/// be passed through to the output as well.
///
/// Options exist to control which cells are used to perform the averaging
/// operation. Since unstructured grids and polydata can contain cells of
/// different dimensions, in some cases it is desirable to perform cell
/// averaging using cells of a specified dimension. The available options to
/// control this functionality are All (default), Patch and DataSetMax. Patch
/// uses only the highest dimension cells attached to a point. DataSetMax uses
/// the highest cell dimension in the entire data set.
///
/// @warning
/// This filter is an abstract filter, that is, the output is an abstract type
/// (i.e., vtkDataSet). Use the convenience methods (e.g.,
/// GetPolyDataOutput(), GetStructuredPointsOutput(), etc.) to get the type
/// of output you want.
///
/// @warning
/// For maximum performance, use the ContributingCellOption=All. Other options
/// significantly, negatively impact performance (on the order of &gt;10x).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential execution type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPointData vtkCellData vtkPointDataToCellData
/// </seealso>
public class vtkCellDataToPointData : vtkDataSetAlgorithm
{
	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public enum ContributingCellEnum
	{
		/// <summary>enum member</summary>
		All = 0,
		/// <summary>enum member</summary>
		DataSetMax = 2,
		/// <summary>enum member</summary>
		Patch = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellDataToPointData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellDataToPointData()
	{
		MRClassNameKey = "class vtkCellDataToPointData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellDataToPointData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellDataToPointData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDataToPointData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkCellDataToPointData New()
	{
		vtkCellDataToPointData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDataToPointData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkCellDataToPointData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellDataToPointData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCellDataToPointData_AddCellDataArray_01(HandleRef pThis, string name);

	/// <summary>
	/// Adds an array to be processed. This only has an effect if the
	/// ProcessAllArrays option is turned off. If a name is already present,
	/// nothing happens.
	/// </summary>
	public virtual void AddCellDataArray(string name)
	{
		vtkCellDataToPointData_AddCellDataArray_01(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_ClearCellDataArrays_02(HandleRef pThis);

	/// <summary>
	/// Removes all arrays to be processed from the list. This only has an effect
	/// if the ProcessAllArrays option is turned off.
	/// </summary>
	public virtual void ClearCellDataArrays()
	{
		vtkCellDataToPointData_ClearCellDataArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDataToPointData_GetContributingCellOption_03(HandleRef pThis);

	/// <summary>
	/// Option to specify what cells to include in the cell-averaging computation.
	/// Options are all cells (All, Patch and DataSetMax). The default is All.
	/// </summary>
	public virtual int GetContributingCellOption()
	{
		return vtkCellDataToPointData_GetContributingCellOption_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDataToPointData_GetContributingCellOptionMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Option to specify what cells to include in the cell-averaging computation.
	/// Options are all cells (All, Patch and DataSetMax). The default is All.
	/// </summary>
	public virtual int GetContributingCellOptionMaxValue()
	{
		return vtkCellDataToPointData_GetContributingCellOptionMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDataToPointData_GetContributingCellOptionMinValue_05(HandleRef pThis);

	/// <summary>
	/// Option to specify what cells to include in the cell-averaging computation.
	/// Options are all cells (All, Patch and DataSetMax). The default is All.
	/// </summary>
	public virtual int GetContributingCellOptionMinValue()
	{
		return vtkCellDataToPointData_GetContributingCellOptionMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellDataToPointData_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellDataToPointData_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellDataToPointData_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellDataToPointData_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellDataToPointData_GetPassCellData_08(HandleRef pThis);

	/// <summary>
	/// Control whether the input cell data is to be passed to the output. If
	/// on, then the input cell data is passed through to the output; otherwise,
	/// only generated point data is placed into the output. The default is false.
	/// </summary>
	public virtual bool GetPassCellData()
	{
		return (vtkCellDataToPointData_GetPassCellData_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellDataToPointData_GetPieceInvariant_09(HandleRef pThis);

	/// <summary>
	/// To get piece invariance, this filter has to request an
	/// extra ghost level.  By default piece invariance is on.
	/// </summary>
	public virtual bool GetPieceInvariant()
	{
		return (vtkCellDataToPointData_GetPieceInvariant_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellDataToPointData_GetProcessAllArrays_10(HandleRef pThis);

	/// <summary>
	/// Activate selective processing of arrays. If false, only arrays selected
	/// by the user will be considered by this filter. The default is true.
	/// </summary>
	public virtual bool GetProcessAllArrays()
	{
		return (vtkCellDataToPointData_GetProcessAllArrays_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDataToPointData_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellDataToPointData_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellDataToPointData_IsTypeOf_12(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellDataToPointData_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDataToPointData_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkCellDataToPointData NewInstance()
	{
		vtkCellDataToPointData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDataToPointData_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_PassCellDataOff_15(HandleRef pThis);

	/// <summary>
	/// Control whether the input cell data is to be passed to the output. If
	/// on, then the input cell data is passed through to the output; otherwise,
	/// only generated point data is placed into the output. The default is false.
	/// </summary>
	public virtual void PassCellDataOff()
	{
		vtkCellDataToPointData_PassCellDataOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_PassCellDataOn_16(HandleRef pThis);

	/// <summary>
	/// Control whether the input cell data is to be passed to the output. If
	/// on, then the input cell data is passed through to the output; otherwise,
	/// only generated point data is placed into the output. The default is false.
	/// </summary>
	public virtual void PassCellDataOn()
	{
		vtkCellDataToPointData_PassCellDataOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_PieceInvariantOff_17(HandleRef pThis);

	/// <summary>
	/// To get piece invariance, this filter has to request an
	/// extra ghost level.  By default piece invariance is on.
	/// </summary>
	public virtual void PieceInvariantOff()
	{
		vtkCellDataToPointData_PieceInvariantOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_PieceInvariantOn_18(HandleRef pThis);

	/// <summary>
	/// To get piece invariance, this filter has to request an
	/// extra ghost level.  By default piece invariance is on.
	/// </summary>
	public virtual void PieceInvariantOn()
	{
		vtkCellDataToPointData_PieceInvariantOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_ProcessAllArraysOff_19(HandleRef pThis);

	/// <summary>
	/// Activate selective processing of arrays. If false, only arrays selected
	/// by the user will be considered by this filter. The default is true.
	/// </summary>
	public virtual void ProcessAllArraysOff()
	{
		vtkCellDataToPointData_ProcessAllArraysOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_ProcessAllArraysOn_20(HandleRef pThis);

	/// <summary>
	/// Activate selective processing of arrays. If false, only arrays selected
	/// by the user will be considered by this filter. The default is true.
	/// </summary>
	public virtual void ProcessAllArraysOn()
	{
		vtkCellDataToPointData_ProcessAllArraysOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_RemoveCellDataArray_21(HandleRef pThis, string name);

	/// <summary>
	/// Removes an array to be processed. This only has an effect if the
	/// ProcessAllArrays option is turned off. If the specified name is not
	/// present, nothing happens.
	/// </summary>
	public virtual void RemoveCellDataArray(string name)
	{
		vtkCellDataToPointData_RemoveCellDataArray_21(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellDataToPointData_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkCellDataToPointData SafeDownCast(vtkObjectBase o)
	{
		vtkCellDataToPointData vtkCellDataToPointData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellDataToPointData_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellDataToPointData2 = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellDataToPointData2.Register(null);
			}
		}
		return vtkCellDataToPointData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_SetContributingCellOption_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Option to specify what cells to include in the cell-averaging computation.
	/// Options are all cells (All, Patch and DataSetMax). The default is All.
	/// </summary>
	public virtual void SetContributingCellOption(int _arg)
	{
		vtkCellDataToPointData_SetContributingCellOption_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_SetPassCellData_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Control whether the input cell data is to be passed to the output. If
	/// on, then the input cell data is passed through to the output; otherwise,
	/// only generated point data is placed into the output. The default is false.
	/// </summary>
	public virtual void SetPassCellData(bool _arg)
	{
		vtkCellDataToPointData_SetPassCellData_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_SetPieceInvariant_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// To get piece invariance, this filter has to request an
	/// extra ghost level.  By default piece invariance is on.
	/// </summary>
	public virtual void SetPieceInvariant(bool _arg)
	{
		vtkCellDataToPointData_SetPieceInvariant_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellDataToPointData_SetProcessAllArrays_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Activate selective processing of arrays. If false, only arrays selected
	/// by the user will be considered by this filter. The default is true.
	/// </summary>
	public virtual void SetProcessAllArrays(bool _arg)
	{
		vtkCellDataToPointData_SetProcessAllArrays_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
