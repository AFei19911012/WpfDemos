using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkDataSetAttributesFieldList
/// </summary>
/// <remarks>
///  helps manage arrays from multiple vtkDataSetAttributes.
///
/// vtkDataSetAttributesFieldList, also called vtkDataSetAttributes::FieldList,
/// is used to help with filters when dealing with arrays from multiple
/// vtkDataSetAttributes instances, potentially from multiple inputs.
///
/// Consider a filter that appends multiple inputs, e.g. vtkAppendPolyData.
/// Besides appending mesh elements, such a filter also needs to combine field
/// arrays (point, and cell data) from inputs to pass on to the output.
/// Now if all the inputs had exactly the same set of arrays, we're all set.
/// However, more often than not, the inputs will have different sets of arrays.
/// The filter will need to match up from various inputs to combine together,
/// potentially dropping arrays not in all inputs. Furthermore, it needs to
/// ensure arrays in the output are flagged as attributes consistently. All of
/// this can be done using vtkDataSetAttributesFieldList.
///
/// @section Usage Usage
///
/// Typical usage is as follows:
/// 1. call `IntersectFieldList` or `UnionFieldList` for all input vtkDataSetAttributes
///   instances,
/// 2. allocate arrays for the output vtkDataSetAttributes by using `CopyAllocate`,
/// 3. call `CopyData` per input (preserving the input order used in step 1) to
///    copy tuple(s) from input to the output.
///
/// `vtkDataSetAttributes::InitializeFieldList` is provided for API compatibility
/// with previous implementation of this class and it not required to be called.
/// Simply calling `UnionFieldList` or `IntersectFieldList` for the first
/// vtkDataSetAttributes instance is sufficient.
///
/// `CopyAllocate, `CopyData`, and `InterpolatePoint` methods on this class
/// are called by similarly named variants on vtkDataSetAttributes that take in a
/// FieldList instance as an argument. Hence, either forms may be used.
///
/// Calls to `UnionFieldList` and `IntersectFieldList` cannot be mixed. Use
/// `Reset` or `InitializeFieldList` to change mode and start reinitialization.
/// </remarks>
public class vtkDataSetAttributesFieldList : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetAttributesFieldList";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataSetAttributesFieldList()
	{
		MRClassNameKey = "class vtkDataSetAttributesFieldList";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetAttributesFieldList"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataSetAttributesFieldList(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkDataSetAttributesFieldList_BuildPrototype_01(HandleRef pThis, HandleRef protoDSA, HandleRef ordering);

	/// <summary>
	/// A convenience function that builds a prototype / template dataset
	/// attributes for initializing the process of attribute interpolation and
	/// copying. The supplied protoPD should be initialized (empty), and the
	/// arrays present in this field list are instantiated and added to the
	/// prototype attributes. The typical usage is to use field list
	/// intersection (or union) operations to build up the field list, then
	/// create the prototype. Note, to retain an order of the data arrays,
	/// an optional ordering dataset attributes may be provided. (This is
	/// necessary because the vtkDataSetAttributesFieldList does not necessarily
	/// retain the original order of data arrays.)
	/// </summary>
	public void BuildPrototype(vtkDataSetAttributes protoDSA, vtkDataSetAttributes ordering)
	{
		vtkDataSetAttributesFieldList_BuildPrototype_01(GetCppThis(), protoDSA?.GetCppThis() ?? default(HandleRef), ordering?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributesFieldList_CopyAllocate_02(HandleRef pThis, HandleRef output, int ctype, long sz, long ext);

	/// <summary>
	/// These methods can called to generate and update the output
	/// vtkDataSetAttributes. These match corresponding API on vtkDataSetAttributes
	/// and can be called via the output vtkDataSetAttributes instance
	/// instead as well.
	/// </summary>
	public void CopyAllocate(vtkDataSetAttributes output, int ctype, long sz, long ext)
	{
		vtkDataSetAttributesFieldList_CopyAllocate_02(GetCppThis(), output?.GetCppThis() ?? default(HandleRef), ctype, sz, ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributesFieldList_CopyData_03(HandleRef pThis, int inputIndex, HandleRef input, long fromId, HandleRef output, long toId);

	/// <summary>
	/// These methods can called to generate and update the output
	/// vtkDataSetAttributes. These match corresponding API on vtkDataSetAttributes
	/// and can be called via the output vtkDataSetAttributes instance
	/// instead as well.
	/// </summary>
	public void CopyData(int inputIndex, vtkDataSetAttributes input, long fromId, vtkDataSetAttributes output, long toId)
	{
		vtkDataSetAttributesFieldList_CopyData_03(GetCppThis(), inputIndex, input?.GetCppThis() ?? default(HandleRef), fromId, output?.GetCppThis() ?? default(HandleRef), toId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributesFieldList_CopyData_04(HandleRef pThis, int inputIndex, HandleRef input, long inputStart, long numValues, HandleRef output, long outStart);

	/// <summary>
	/// These methods can called to generate and update the output
	/// vtkDataSetAttributes. These match corresponding API on vtkDataSetAttributes
	/// and can be called via the output vtkDataSetAttributes instance
	/// instead as well.
	/// </summary>
	public void CopyData(int inputIndex, vtkDataSetAttributes input, long inputStart, long numValues, vtkDataSetAttributes output, long outStart)
	{
		vtkDataSetAttributesFieldList_CopyData_04(GetCppThis(), inputIndex, input?.GetCppThis() ?? default(HandleRef), inputStart, numValues, output?.GetCppThis() ?? default(HandleRef), outStart);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetAttributesFieldList_GetNumberOfArrays_05(HandleRef pThis);

	/// <summary>
	/// This method can be used to determine the number of arrays remaining
	/// after intersection or union operations. See also
	/// vtkFieldData::GetNumberOfArrays().
	/// </summary>
	public int GetNumberOfArrays()
	{
		return vtkDataSetAttributesFieldList_GetNumberOfArrays_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributesFieldList_InitializeFieldList_06(HandleRef pThis, HandleRef dsa);

	/// <summary>
	/// Initialize the field list. This also adds the first input.
	/// Calling this method is optional. The first call to `IntersectFieldList` or
	/// `UnionFieldList` on a new instance or after calling `Reset()` will have the
	/// same effect.
	/// </summary>
	public void InitializeFieldList(vtkDataSetAttributes dsa)
	{
		vtkDataSetAttributesFieldList_InitializeFieldList_06(GetCppThis(), dsa?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributesFieldList_InterpolatePoint_07(HandleRef pThis, int inputIndex, HandleRef input, HandleRef inputIds, IntPtr weights, HandleRef output, long toId);

	/// <summary>
	/// These methods can called to generate and update the output
	/// vtkDataSetAttributes. These match corresponding API on vtkDataSetAttributes
	/// and can be called via the output vtkDataSetAttributes instance
	/// instead as well.
	/// </summary>
	public void InterpolatePoint(int inputIndex, vtkDataSetAttributes input, vtkIdList inputIds, IntPtr weights, vtkDataSetAttributes output, long toId)
	{
		vtkDataSetAttributesFieldList_InterpolatePoint_07(GetCppThis(), inputIndex, input?.GetCppThis() ?? default(HandleRef), inputIds?.GetCppThis() ?? default(HandleRef), weights, output?.GetCppThis() ?? default(HandleRef), toId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributesFieldList_IntersectFieldList_08(HandleRef pThis, HandleRef dsa);

	/// <summary>
	/// Update the field list for an intersection of arrays registered so far and
	/// those in `dsa`.
	/// </summary>
	public void IntersectFieldList(vtkDataSetAttributes dsa)
	{
		vtkDataSetAttributesFieldList_IntersectFieldList_08(GetCppThis(), dsa?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributesFieldList_Reset_09(HandleRef pThis);

	/// <summary>
	/// Initializes the field list to empty.
	/// </summary>
	public void Reset()
	{
		vtkDataSetAttributesFieldList_Reset_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetAttributesFieldList_UnionFieldList_10(HandleRef pThis, HandleRef dsa);

	/// <summary>
	/// Update the field list for an union of arrays registered so far and
	/// those in `dsa`.
	/// </summary>
	public void UnionFieldList(vtkDataSetAttributes dsa)
	{
		vtkDataSetAttributesFieldList_UnionFieldList_10(GetCppThis(), dsa?.GetCppThis() ?? default(HandleRef));
	}
}
