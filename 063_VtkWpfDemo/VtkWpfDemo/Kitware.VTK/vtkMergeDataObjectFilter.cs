using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMergeDataObjectFilter
/// </summary>
/// <remarks>
///    merge dataset and data object field to create dataset with attribute data
///
/// vtkMergeDataObjectFilter is a filter that merges the field from a
/// vtkDataObject with a vtkDataSet. The resulting combined dataset can
/// then be processed by other filters (e.g.,
/// vtkFieldDataToAttributeDataFilter) to create attribute data like
/// scalars, vectors, etc.
///
/// The filter operates as follows. The field data from the
/// vtkDataObject is merged with the input's vtkDataSet and then placed
/// in the output. You can choose to place the field data into the cell
/// data field, the point data field, or the datasets field (i.e., the
/// one inherited from vtkDataSet's superclass vtkDataObject). All this
/// data shuffling occurs via reference counting, therefore memory is
/// not copied.
///
/// One of the uses of this filter is to allow you to read/generate the
/// structure of a dataset independent of the attributes. So, for
/// example, you could store the dataset geometry/topology in one file,
/// and field data in another. Then use this filter in combination with
/// vtkFieldDataToAttributeData to create a dataset ready for
/// processing in the visualization pipeline.
/// </remarks>
public class vtkMergeDataObjectFilter : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMergeDataObjectFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMergeDataObjectFilter()
	{
		MRClassNameKey = "class vtkMergeDataObjectFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeDataObjectFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMergeDataObjectFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeDataObjectFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeDataObjectFilter New()
	{
		vtkMergeDataObjectFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeDataObjectFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMergeDataObjectFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMergeDataObjectFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkMergeDataObjectFilter_GetDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the data object to merge with the input dataset.
	/// </summary>
	public vtkDataObject GetDataObject()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeDataObjectFilter_GetDataObject_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeDataObjectFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMergeDataObjectFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeDataObjectFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMergeDataObjectFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeDataObjectFilter_GetOutputField_04(HandleRef pThis);

	/// <summary>
	/// Specify where to place the field data during the merge process.  There
	/// are three choices: the field data associated with the vtkDataObject
	/// superclass; the point field attribute data; and the cell field attribute
	/// data.
	/// </summary>
	public virtual int GetOutputField()
	{
		return vtkMergeDataObjectFilter_GetOutputField_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeDataObjectFilter_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMergeDataObjectFilter_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeDataObjectFilter_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMergeDataObjectFilter_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeDataObjectFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMergeDataObjectFilter NewInstance()
	{
		vtkMergeDataObjectFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeDataObjectFilter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeDataObjectFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeDataObjectFilter SafeDownCast(vtkObjectBase o)
	{
		vtkMergeDataObjectFilter vtkMergeDataObjectFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeDataObjectFilter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMergeDataObjectFilter2 = (vtkMergeDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMergeDataObjectFilter2.Register(null);
			}
		}
		return vtkMergeDataObjectFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeDataObjectFilter_SetDataObjectInputData_10(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the data object to merge with the input dataset.
	/// </summary>
	public void SetDataObjectInputData(vtkDataObject arg0)
	{
		vtkMergeDataObjectFilter_SetDataObjectInputData_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeDataObjectFilter_SetOutputField_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify where to place the field data during the merge process.  There
	/// are three choices: the field data associated with the vtkDataObject
	/// superclass; the point field attribute data; and the cell field attribute
	/// data.
	/// </summary>
	public virtual void SetOutputField(int _arg)
	{
		vtkMergeDataObjectFilter_SetOutputField_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToCellDataField_12(HandleRef pThis);

	/// <summary>
	/// Specify where to place the field data during the merge process.  There
	/// are three choices: the field data associated with the vtkDataObject
	/// superclass; the point field attribute data; and the cell field attribute
	/// data.
	/// </summary>
	public void SetOutputFieldToCellDataField()
	{
		vtkMergeDataObjectFilter_SetOutputFieldToCellDataField_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToDataObjectField_13(HandleRef pThis);

	/// <summary>
	/// Specify where to place the field data during the merge process.  There
	/// are three choices: the field data associated with the vtkDataObject
	/// superclass; the point field attribute data; and the cell field attribute
	/// data.
	/// </summary>
	public void SetOutputFieldToDataObjectField()
	{
		vtkMergeDataObjectFilter_SetOutputFieldToDataObjectField_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeDataObjectFilter_SetOutputFieldToPointDataField_14(HandleRef pThis);

	/// <summary>
	/// Specify where to place the field data during the merge process.  There
	/// are three choices: the field data associated with the vtkDataObject
	/// superclass; the point field attribute data; and the cell field attribute
	/// data.
	/// </summary>
	public void SetOutputFieldToPointDataField()
	{
		vtkMergeDataObjectFilter_SetOutputFieldToPointDataField_14(GetCppThis());
	}
}
