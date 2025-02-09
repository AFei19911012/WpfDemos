using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointDataToCellData
/// </summary>
/// <remarks>
///    map point data to cell data
///
/// vtkPointDataToCellData is a filter that transforms point data (i.e., data
/// specified per point) into cell data (i.e., data specified per cell).  By
/// default, the method of transformation is based on averaging the data
/// values of all the points defining a particular cell. Optionally (by enabling
/// CategoricalData), histograming can be used to assign the cell data. For
/// large datasets with several cell data arrays, the filter optionally
/// supports selective processing to speed up processing. Optionally, the
/// input point data can be passed through to the output as well.
///
/// @warning
/// This filter is an abstract filter, that is, the output is an abstract type
/// (i.e., vtkDataSet). Use the convenience methods (e.g.,
/// GetPolyDataOutput(), GetStructuredPointsOutput(), etc.) to get the type
/// of output you want.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPointData vtkCellData vtkCellDataToPointData
/// </seealso>
public class vtkPointDataToCellData : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointDataToCellData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointDataToCellData()
	{
		MRClassNameKey = "class vtkPointDataToCellData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointDataToCellData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointDataToCellData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDataToCellData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkPointDataToCellData New()
	{
		vtkPointDataToCellData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointDataToCellData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkPointDataToCellData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointDataToCellData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointDataToCellData_AddPointDataArray_01(HandleRef pThis, string name);

	/// <summary>
	/// Adds an array to be processed. This only has an effect if the
	/// ProcessAllArrays option is turned off. If a name is already present,
	/// nothing happens.
	/// </summary>
	public virtual void AddPointDataArray(string name)
	{
		vtkPointDataToCellData_AddPointDataArray_01(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_CategoricalDataOff_02(HandleRef pThis);

	/// <summary>
	/// Control whether the input point data is to be treated as categorical. If
	/// the data is categorical, then the resultant cell data will be determined
	/// by a "majority rules" vote (using a histogram of the point data scalar
	/// values), with ties going to the smaller point data value.
	/// </summary>
	public virtual void CategoricalDataOff()
	{
		vtkPointDataToCellData_CategoricalDataOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_CategoricalDataOn_03(HandleRef pThis);

	/// <summary>
	/// Control whether the input point data is to be treated as categorical. If
	/// the data is categorical, then the resultant cell data will be determined
	/// by a "majority rules" vote (using a histogram of the point data scalar
	/// values), with ties going to the smaller point data value.
	/// </summary>
	public virtual void CategoricalDataOn()
	{
		vtkPointDataToCellData_CategoricalDataOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_ClearPointDataArrays_04(HandleRef pThis);

	/// <summary>
	/// Removes all arrays to be processed from the list. This only has an effect
	/// if the ProcessAllArrays option is turned off.
	/// </summary>
	public virtual void ClearPointDataArrays()
	{
		vtkPointDataToCellData_ClearPointDataArrays_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointDataToCellData_GetCategoricalData_05(HandleRef pThis);

	/// <summary>
	/// Control whether the input point data is to be treated as categorical. If
	/// the data is categorical, then the resultant cell data will be determined
	/// by a "majority rules" vote (using a histogram of the point data scalar
	/// values), with ties going to the smaller point data value.
	/// </summary>
	public virtual bool GetCategoricalData()
	{
		return (vtkPointDataToCellData_GetCategoricalData_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointDataToCellData_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointDataToCellData_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointDataToCellData_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointDataToCellData_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointDataToCellData_GetPassPointData_08(HandleRef pThis);

	/// <summary>
	/// Control whether the input point data is to be passed to the output. If
	/// on, then the input point data is passed through to the output; otherwise,
	/// only generated cell data is placed into the output.
	/// </summary>
	public virtual bool GetPassPointData()
	{
		return (vtkPointDataToCellData_GetPassPointData_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointDataToCellData_GetProcessAllArrays_09(HandleRef pThis);

	/// <summary>
	/// Activate selective processing of arrays. If inactive, only arrays selected
	/// by the user will be considered by this filter. The default is true.
	/// </summary>
	public virtual bool GetProcessAllArrays()
	{
		return (vtkPointDataToCellData_GetProcessAllArrays_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDataToCellData_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointDataToCellData_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDataToCellData_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointDataToCellData_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDataToCellData_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkPointDataToCellData NewInstance()
	{
		vtkPointDataToCellData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointDataToCellData_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_PassPointDataOff_14(HandleRef pThis);

	/// <summary>
	/// Control whether the input point data is to be passed to the output. If
	/// on, then the input point data is passed through to the output; otherwise,
	/// only generated cell data is placed into the output.
	/// </summary>
	public virtual void PassPointDataOff()
	{
		vtkPointDataToCellData_PassPointDataOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_PassPointDataOn_15(HandleRef pThis);

	/// <summary>
	/// Control whether the input point data is to be passed to the output. If
	/// on, then the input point data is passed through to the output; otherwise,
	/// only generated cell data is placed into the output.
	/// </summary>
	public virtual void PassPointDataOn()
	{
		vtkPointDataToCellData_PassPointDataOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_ProcessAllArraysOff_16(HandleRef pThis);

	/// <summary>
	/// Activate selective processing of arrays. If inactive, only arrays selected
	/// by the user will be considered by this filter. The default is true.
	/// </summary>
	public virtual void ProcessAllArraysOff()
	{
		vtkPointDataToCellData_ProcessAllArraysOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_ProcessAllArraysOn_17(HandleRef pThis);

	/// <summary>
	/// Activate selective processing of arrays. If inactive, only arrays selected
	/// by the user will be considered by this filter. The default is true.
	/// </summary>
	public virtual void ProcessAllArraysOn()
	{
		vtkPointDataToCellData_ProcessAllArraysOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_RemovePointDataArray_18(HandleRef pThis, string name);

	/// <summary>
	/// Removes an array to be processed. This only has an effect if the
	/// ProcessAllArrays option is turned off. If the specified name is not
	/// present, nothing happens.
	/// </summary>
	public virtual void RemovePointDataArray(string name)
	{
		vtkPointDataToCellData_RemovePointDataArray_18(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDataToCellData_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkPointDataToCellData SafeDownCast(vtkObjectBase o)
	{
		vtkPointDataToCellData vtkPointDataToCellData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointDataToCellData_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointDataToCellData2 = (vtkPointDataToCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointDataToCellData2.Register(null);
			}
		}
		return vtkPointDataToCellData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_SetCategoricalData_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Control whether the input point data is to be treated as categorical. If
	/// the data is categorical, then the resultant cell data will be determined
	/// by a "majority rules" vote (using a histogram of the point data scalar
	/// values), with ties going to the smaller point data value.
	/// </summary>
	public virtual void SetCategoricalData(bool _arg)
	{
		vtkPointDataToCellData_SetCategoricalData_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_SetPassPointData_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Control whether the input point data is to be passed to the output. If
	/// on, then the input point data is passed through to the output; otherwise,
	/// only generated cell data is placed into the output.
	/// </summary>
	public virtual void SetPassPointData(bool _arg)
	{
		vtkPointDataToCellData_SetPassPointData_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDataToCellData_SetProcessAllArrays_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Activate selective processing of arrays. If inactive, only arrays selected
	/// by the user will be considered by this filter. The default is true.
	/// </summary>
	public virtual void SetProcessAllArrays(bool _arg)
	{
		vtkPointDataToCellData_SetProcessAllArrays_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
