using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkGroupDataSetsFilter
/// </summary>
/// <remarks>
///  groups inputs into a chosen composite dataset.
///
/// vtkGroupDataSetsFilter is a filter that can combine multiple input datasets
/// into a vtkMultBlockDataSet, vtkPartitionedDataSet, or a
/// vtkPartitionedDataSetCollection.
///
/// The inputs are added a individual blocks in the output and can be named
/// assigned block-names using `SetInputName`.
///
/// This is a more generic version of `vtkMultiBlockDataGroupFilter` and should
/// be preferred.
/// </remarks>
public class vtkGroupDataSetsFilter : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGroupDataSetsFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGroupDataSetsFilter()
	{
		MRClassNameKey = "class vtkGroupDataSetsFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGroupDataSetsFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGroupDataSetsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGroupDataSetsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGroupDataSetsFilter New()
	{
		vtkGroupDataSetsFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGroupDataSetsFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGroupDataSetsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGroupDataSetsFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGroupDataSetsFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGroupDataSetsFilter_ClearInputNames_01(HandleRef pThis);

	/// <summary>
	/// Clears all assigned input names.
	/// </summary>
	public void ClearInputNames()
	{
		vtkGroupDataSetsFilter_ClearInputNames_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGroupDataSetsFilter_GetInputName_02(HandleRef pThis, int index);

	/// <summary>
	/// API to assign names for inputs. If not specified, the filter automatically
	/// creates sensible names based on the chosen output type.
	///
	/// Names are not useful or relevant if output type is
	/// `VTK_PARTITIONED_DATA_SET` and hence are ignored for that type.
	/// </summary>
	public string GetInputName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkGroupDataSetsFilter_GetInputName_02(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGroupDataSetsFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGroupDataSetsFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGroupDataSetsFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGroupDataSetsFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGroupDataSetsFilter_GetOutputType_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the output type. Supported values are
	/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
	/// `VTK_MULTIBLOCK_DATA_SET`.
	///
	/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
	/// </summary>
	public virtual int GetOutputType()
	{
		return vtkGroupDataSetsFilter_GetOutputType_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGroupDataSetsFilter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGroupDataSetsFilter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGroupDataSetsFilter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGroupDataSetsFilter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGroupDataSetsFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGroupDataSetsFilter NewInstance()
	{
		vtkGroupDataSetsFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGroupDataSetsFilter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGroupDataSetsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGroupDataSetsFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGroupDataSetsFilter SafeDownCast(vtkObjectBase o)
	{
		vtkGroupDataSetsFilter vtkGroupDataSetsFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGroupDataSetsFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGroupDataSetsFilter2 = (vtkGroupDataSetsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGroupDataSetsFilter2.Register(null);
			}
		}
		return vtkGroupDataSetsFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGroupDataSetsFilter_SetInputName_11(HandleRef pThis, int index, string name);

	/// <summary>
	/// API to assign names for inputs. If not specified, the filter automatically
	/// creates sensible names based on the chosen output type.
	///
	/// Names are not useful or relevant if output type is
	/// `VTK_PARTITIONED_DATA_SET` and hence are ignored for that type.
	/// </summary>
	public void SetInputName(int index, string name)
	{
		vtkGroupDataSetsFilter_SetInputName_11(GetCppThis(), index, name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGroupDataSetsFilter_SetOutputType_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the output type. Supported values are
	/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
	/// `VTK_MULTIBLOCK_DATA_SET`.
	///
	/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
	/// </summary>
	public virtual void SetOutputType(int _arg)
	{
		vtkGroupDataSetsFilter_SetOutputType_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGroupDataSetsFilter_SetOutputTypeToMultiBlockDataSet_13(HandleRef pThis);

	/// <summary>
	/// Get/Set the output type. Supported values are
	/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
	/// `VTK_MULTIBLOCK_DATA_SET`.
	///
	/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
	/// </summary>
	public void SetOutputTypeToMultiBlockDataSet()
	{
		vtkGroupDataSetsFilter_SetOutputTypeToMultiBlockDataSet_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGroupDataSetsFilter_SetOutputTypeToPartitionedDataSet_14(HandleRef pThis);

	/// <summary>
	/// Get/Set the output type. Supported values are
	/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
	/// `VTK_MULTIBLOCK_DATA_SET`.
	///
	/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
	/// </summary>
	public void SetOutputTypeToPartitionedDataSet()
	{
		vtkGroupDataSetsFilter_SetOutputTypeToPartitionedDataSet_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGroupDataSetsFilter_SetOutputTypeToPartitionedDataSetCollection_15(HandleRef pThis);

	/// <summary>
	/// Get/Set the output type. Supported values are
	/// `VTK_PARTITIONED_DATA_SET_COLLECTION`, `VTK_PARTITIONED_DATA_SET`, and
	/// `VTK_MULTIBLOCK_DATA_SET`.
	///
	/// Default it VTK_PARTITIONED_DATA_SET_COLLECTION.
	/// </summary>
	public void SetOutputTypeToPartitionedDataSetCollection()
	{
		vtkGroupDataSetsFilter_SetOutputTypeToPartitionedDataSetCollection_15(GetCppThis());
	}
}
