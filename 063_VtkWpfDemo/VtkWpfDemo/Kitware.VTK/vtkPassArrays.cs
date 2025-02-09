using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPassArrays
/// </summary>
/// <remarks>
///    Passes a subset of arrays to the output
///
///
/// This filter preserves all the topology of the input, but only a subset of
/// arrays are passed to the output. Add an array to be passed to the output
/// data object with AddArray(). If RemoveArrays is on, the specified arrays will
/// be the ones that are removed instead of the ones that are kept.
///
/// Arrays with special attributes (scalars, pedigree ids, etc.) will retain those
/// attributes in the output.
///
/// By default, only those field types with at least one array specified through
/// AddArray will be processed. If instead UseFieldTypes
/// is turned on, you explicitly set which field types to process with AddFieldType.
///
/// By default, ghost arrays will be passed unless RemoveArrays is selected
/// and those arrays are specifically chosen to be removed.
///
/// Example 1:
///
/// &lt;pre&gt;
/// passArray-&gt;AddArray(vtkDataObject::POINT, "velocity");
/// &lt;/pre&gt;
///
/// The output will have only that one array "velocity" in the
/// point data, but cell and field data will be untouched.
///
/// Example 2:
///
/// &lt;pre&gt;
/// passArray-&gt;AddArray(vtkDataObject::POINT, "velocity");
/// passArray-&gt;UseFieldTypesOn();
/// passArray-&gt;AddFieldType(vtkDataObject::POINT);
/// passArray-&gt;AddFieldType(vtkDataObject::CELL);
/// &lt;/pre&gt;
///
/// The point data would still contain the single array, but the cell data
/// would be cleared since you did not specify any arrays to pass. Field data would
/// still be untouched.
///
/// @section Note
///
/// vtkPassArrays has been replaced by `vtkPassSelectedArrays`. It is recommended
/// that newer code uses `vtkPassSelectedArrays` instead of this filter.
/// `vtkPassSelectedArrays` uses `vtkDataArraySelection` to select arrays and
/// hence provides a more typical API. `vtkPassArrays` may be deprecated in
/// future releases.
/// </remarks>
public class vtkPassArrays : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPassArrays";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPassArrays()
	{
		MRClassNameKey = "class vtkPassArrays";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassArrays"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPassArrays(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPassArrays_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPassArrays New()
	{
		vtkPassArrays result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPassArrays_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPassArrays()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPassArrays_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPassArrays_AddArray_01(HandleRef pThis, int fieldType, string name);

	/// <summary>
	/// Adds an array to pass through.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// </summary>
	public virtual void AddArray(int fieldType, string name)
	{
		vtkPassArrays_AddArray_01(GetCppThis(), fieldType, name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_AddCellDataArray_02(HandleRef pThis, string name);

	/// <summary>
	/// Adds an array to pass through.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// </summary>
	public virtual void AddCellDataArray(string name)
	{
		vtkPassArrays_AddCellDataArray_02(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_AddFieldDataArray_03(HandleRef pThis, string name);

	/// <summary>
	/// Adds an array to pass through.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// </summary>
	public virtual void AddFieldDataArray(string name)
	{
		vtkPassArrays_AddFieldDataArray_03(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_AddFieldType_04(HandleRef pThis, int fieldType);

	/// <summary>
	/// Add a field type to process.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// NOTE: These are only used if UseFieldType is turned on.
	/// </summary>
	public virtual void AddFieldType(int fieldType)
	{
		vtkPassArrays_AddFieldType_04(GetCppThis(), fieldType);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_AddPointDataArray_05(HandleRef pThis, string name);

	/// <summary>
	/// Adds an array to pass through.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// </summary>
	public virtual void AddPointDataArray(string name)
	{
		vtkPassArrays_AddPointDataArray_05(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_ClearArrays_06(HandleRef pThis);

	/// <summary>
	/// Clear all arrays to pass through.
	/// </summary>
	public virtual void ClearArrays()
	{
		vtkPassArrays_ClearArrays_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_ClearCellDataArrays_07(HandleRef pThis);

	/// <summary>
	/// Clear all arrays to pass through.
	/// </summary>
	public virtual void ClearCellDataArrays()
	{
		vtkPassArrays_ClearCellDataArrays_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_ClearFieldDataArrays_08(HandleRef pThis);

	/// <summary>
	/// Clear all arrays to pass through.
	/// </summary>
	public virtual void ClearFieldDataArrays()
	{
		vtkPassArrays_ClearFieldDataArrays_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_ClearFieldTypes_09(HandleRef pThis);

	/// <summary>
	/// Clear all field types to process.
	/// </summary>
	public virtual void ClearFieldTypes()
	{
		vtkPassArrays_ClearFieldTypes_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_ClearPointDataArrays_10(HandleRef pThis);

	/// <summary>
	/// Clear all arrays to pass through.
	/// </summary>
	public virtual void ClearPointDataArrays()
	{
		vtkPassArrays_ClearPointDataArrays_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPassArrays_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPassArrays_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPassArrays_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPassArrays_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPassArrays_GetRemoveArrays_13(HandleRef pThis);

	/// <summary>
	/// Instead of passing only the specified arrays, remove the specified arrays
	/// and keep all other arrays. Default is off.
	/// </summary>
	public virtual bool GetRemoveArrays()
	{
		return (vtkPassArrays_GetRemoveArrays_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPassArrays_GetUseFieldTypes_14(HandleRef pThis);

	/// <summary>
	/// Process only those field types explicitly specified with AddFieldType.
	/// Otherwise, processes field types associated with at least one specified
	/// array. Default is off.
	/// </summary>
	public virtual bool GetUseFieldTypes()
	{
		return (vtkPassArrays_GetUseFieldTypes_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPassArrays_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPassArrays_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPassArrays_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPassArrays_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPassArrays_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPassArrays NewInstance()
	{
		vtkPassArrays result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPassArrays_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_RemoveArray_19(HandleRef pThis, int fieldType, string name);

	/// <summary>
	/// Adds an array to pass through.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// </summary>
	public virtual void RemoveArray(int fieldType, string name)
	{
		vtkPassArrays_RemoveArray_19(GetCppThis(), fieldType, name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_RemoveArraysOff_20(HandleRef pThis);

	/// <summary>
	/// Instead of passing only the specified arrays, remove the specified arrays
	/// and keep all other arrays. Default is off.
	/// </summary>
	public virtual void RemoveArraysOff()
	{
		vtkPassArrays_RemoveArraysOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_RemoveArraysOn_21(HandleRef pThis);

	/// <summary>
	/// Instead of passing only the specified arrays, remove the specified arrays
	/// and keep all other arrays. Default is off.
	/// </summary>
	public virtual void RemoveArraysOn()
	{
		vtkPassArrays_RemoveArraysOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_RemoveCellDataArray_22(HandleRef pThis, string name);

	/// <summary>
	/// Adds an array to pass through.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// </summary>
	public virtual void RemoveCellDataArray(string name)
	{
		vtkPassArrays_RemoveCellDataArray_22(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_RemoveFieldDataArray_23(HandleRef pThis, string name);

	/// <summary>
	/// Adds an array to pass through.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// </summary>
	public virtual void RemoveFieldDataArray(string name)
	{
		vtkPassArrays_RemoveFieldDataArray_23(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_RemovePointDataArray_24(HandleRef pThis, string name);

	/// <summary>
	/// Adds an array to pass through.
	/// fieldType where the array that should be passed (point data, cell data, etc.).
	/// It should be one of the constants defined in the vtkDataObject::AttributeTypes
	/// enumeration.
	/// </summary>
	public virtual void RemovePointDataArray(string name)
	{
		vtkPassArrays_RemovePointDataArray_24(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPassArrays_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPassArrays SafeDownCast(vtkObjectBase o)
	{
		vtkPassArrays vtkPassArrays2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPassArrays_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPassArrays2 = (vtkPassArrays)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPassArrays2.Register(null);
			}
		}
		return vtkPassArrays2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_SetRemoveArrays_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Instead of passing only the specified arrays, remove the specified arrays
	/// and keep all other arrays. Default is off.
	/// </summary>
	public virtual void SetRemoveArrays(bool _arg)
	{
		vtkPassArrays_SetRemoveArrays_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_SetUseFieldTypes_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Process only those field types explicitly specified with AddFieldType.
	/// Otherwise, processes field types associated with at least one specified
	/// array. Default is off.
	/// </summary>
	public virtual void SetUseFieldTypes(bool _arg)
	{
		vtkPassArrays_SetUseFieldTypes_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_UseFieldTypesOff_28(HandleRef pThis);

	/// <summary>
	/// Process only those field types explicitly specified with AddFieldType.
	/// Otherwise, processes field types associated with at least one specified
	/// array. Default is off.
	/// </summary>
	public virtual void UseFieldTypesOff()
	{
		vtkPassArrays_UseFieldTypesOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPassArrays_UseFieldTypesOn_29(HandleRef pThis);

	/// <summary>
	/// Process only those field types explicitly specified with AddFieldType.
	/// Otherwise, processes field types associated with at least one specified
	/// array. Default is off.
	/// </summary>
	public virtual void UseFieldTypesOn()
	{
		vtkPassArrays_UseFieldTypesOn_29(GetCppThis());
	}
}
