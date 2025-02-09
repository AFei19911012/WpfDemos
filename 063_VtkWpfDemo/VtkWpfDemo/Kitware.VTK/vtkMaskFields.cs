using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMaskFields
/// </summary>
/// <remarks>
///    Allow control of which fields get passed
/// to the output
///
/// vtkMaskFields is used to mark which fields in the input dataset
/// get copied to the output.  The output will contain only those fields
/// marked as on by the filter.
///
/// </remarks>
/// <seealso>
///
/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
/// vtkDataSetAttributes vtkDataArray vtkRearrangeFields
/// vtkSplitField vtkMergeFields vtkAssignAttribute
/// </seealso>
public class vtkMaskFields : vtkDataSetAlgorithm
{
	/// <summary>
	/// Turn off copying of all data.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array
	/// </summary>
	public enum FieldLocation
	{
		/// <summary>enum member</summary>
		CELL_DATA = 2,
		/// <summary>enum member</summary>
		OBJECT_DATA = 0,
		/// <summary>enum member</summary>
		POINT_DATA = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMaskFields";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMaskFields()
	{
		MRClassNameKey = "class vtkMaskFields";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskFields"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMaskFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkMaskFields.
	/// </summary>
	public new static vtkMaskFields New()
	{
		vtkMaskFields result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkMaskFields.
	/// </summary>
	public vtkMaskFields()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMaskFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMaskFields_CopyAllOff_01(HandleRef pThis);

	/// <summary>
	/// Turn off copying of all data.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array
	/// </summary>
	public virtual void CopyAllOff()
	{
		vtkMaskFields_CopyAllOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyAllOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on copying of all data.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array
	/// </summary>
	public virtual void CopyAllOn()
	{
		vtkMaskFields_CopyAllOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyAttributeOff_03(HandleRef pThis, int attributeLocation, int attributeType);

	/// <summary>
	/// Turn on/off the copying of the attribute or specified by vtkDataSetAttributes:AttributeTypes.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array
	/// An attribute type and a location must be specified. For example:
	/// @verbatim
	/// maskFields-&gt;CopyAttributeOff(vtkMaskFields::POINT_DATA, vtkDataSetAttributes::SCALARS);
	/// @endverbatim
	/// causes the scalars on the input point data to not get copied
	/// to the output.
	/// </summary>
	public void CopyAttributeOff(int attributeLocation, int attributeType)
	{
		vtkMaskFields_CopyAttributeOff_03(GetCppThis(), attributeLocation, attributeType);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyAttributeOff_04(HandleRef pThis, string attributeLoc, string attributeType);

	/// <summary>
	/// Helper methods used by other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.
	/// </summary>
	public void CopyAttributeOff(string attributeLoc, string attributeType)
	{
		vtkMaskFields_CopyAttributeOff_04(GetCppThis(), attributeLoc, attributeType);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyAttributeOn_05(HandleRef pThis, int attributeLocation, int attributeType);

	/// <summary>
	/// Turn on/off the copying of the attribute or specified by vtkDataSetAttributes:AttributeTypes.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array
	/// An attribute type and a location must be specified. For example:
	/// @verbatim
	/// maskFields-&gt;CopyAttributeOff(vtkMaskFields::POINT_DATA, vtkDataSetAttributes::SCALARS);
	/// @endverbatim
	/// causes the scalars on the input point data to not get copied
	/// to the output.
	/// </summary>
	public void CopyAttributeOn(int attributeLocation, int attributeType)
	{
		vtkMaskFields_CopyAttributeOn_05(GetCppThis(), attributeLocation, attributeType);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyAttributeOn_06(HandleRef pThis, string attributeLoc, string attributeType);

	/// <summary>
	/// Helper methods used by other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.
	/// </summary>
	public void CopyAttributeOn(string attributeLoc, string attributeType)
	{
		vtkMaskFields_CopyAttributeOn_06(GetCppThis(), attributeLoc, attributeType);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyAttributesOff_07(HandleRef pThis);

	/// <summary>
	/// Convenience methods which operate on all field data or
	/// attribute data.  More specific than CopyAllOn or CopyAllOff
	/// </summary>
	public void CopyAttributesOff()
	{
		vtkMaskFields_CopyAttributesOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyAttributesOn_08(HandleRef pThis);

	/// <summary>
	/// Convenience methods which operate on all field data or
	/// attribute data.  More specific than CopyAllOn or CopyAllOff
	/// </summary>
	public void CopyAttributesOn()
	{
		vtkMaskFields_CopyAttributesOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyFieldOff_09(HandleRef pThis, int fieldLocation, string name);

	/// <summary>
	/// Turn on/off the copying of the field or specified by name.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array
	/// A field name and a location must be specified. For example:
	/// @verbatim
	/// maskFields-&gt;CopyFieldOff(vtkMaskFields::CELL_DATA, "foo");
	/// @endverbatim
	/// causes the field "foo" on the input cell data to not get copied
	/// to the output.
	/// </summary>
	public void CopyFieldOff(int fieldLocation, string name)
	{
		vtkMaskFields_CopyFieldOff_09(GetCppThis(), fieldLocation, name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyFieldOff_10(HandleRef pThis, string fieldLoc, string name);

	/// <summary>
	/// Helper methods used by other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.
	/// </summary>
	public void CopyFieldOff(string fieldLoc, string name)
	{
		vtkMaskFields_CopyFieldOff_10(GetCppThis(), fieldLoc, name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyFieldOn_11(HandleRef pThis, int fieldLocation, string name);

	/// <summary>
	/// Turn on/off the copying of the field or specified by name.
	/// During the copying/passing, the following rules are followed for each
	/// array:
	/// 1. If the copy flag for an array is set (on or off), it is applied
	/// This overrides rule 2.
	/// 2. If CopyAllOn is set, copy the array.
	/// If CopyAllOff is set, do not copy the array
	/// A field name and a location must be specified. For example:
	/// @verbatim
	/// maskFields-&gt;CopyFieldOff(vtkMaskFields::CELL_DATA, "foo");
	/// @endverbatim
	/// causes the field "foo" on the input cell data to not get copied
	/// to the output.
	/// </summary>
	public void CopyFieldOn(int fieldLocation, string name)
	{
		vtkMaskFields_CopyFieldOn_11(GetCppThis(), fieldLocation, name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyFieldOn_12(HandleRef pThis, string fieldLoc, string name);

	/// <summary>
	/// Helper methods used by other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.
	/// </summary>
	public void CopyFieldOn(string fieldLoc, string name)
	{
		vtkMaskFields_CopyFieldOn_12(GetCppThis(), fieldLoc, name);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyFieldsOff_13(HandleRef pThis);

	/// <summary>
	/// Convenience methods which operate on all field data or
	/// attribute data.  More specific than CopyAllOn or CopyAllOff
	/// </summary>
	public void CopyFieldsOff()
	{
		vtkMaskFields_CopyFieldsOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMaskFields_CopyFieldsOn_14(HandleRef pThis);

	/// <summary>
	/// Convenience methods which operate on all field data or
	/// attribute data.  More specific than CopyAllOn or CopyAllOff
	/// </summary>
	public void CopyFieldsOn()
	{
		vtkMaskFields_CopyFieldsOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskFields_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMaskFields_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMaskFields_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMaskFields_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskFields_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMaskFields_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMaskFields_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMaskFields_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskFields_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMaskFields NewInstance()
	{
		vtkMaskFields result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskFields_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMaskFields_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMaskFields SafeDownCast(vtkObjectBase o)
	{
		vtkMaskFields vtkMaskFields2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMaskFields_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMaskFields2 = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMaskFields2.Register(null);
			}
		}
		return vtkMaskFields2;
	}
}
