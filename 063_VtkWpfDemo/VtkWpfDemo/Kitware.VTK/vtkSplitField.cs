using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSplitField
/// </summary>
/// <remarks>
///    Split a field into single component fields
///
/// vtkSplitField is used to split a multi-component field (vtkDataArray)
/// into multiple single component fields. The new fields are put in
/// the same field data as the original field. The output arrays
/// are of the same type as the input array. Example:
/// @verbatim
/// sf-&gt;SetInputField("gradient", vtkSplitField::POINT_DATA);
/// sf-&gt;Split(0, "firstcomponent");
/// @endverbatim
/// tells vtkSplitField to extract the first component of the field
/// called gradient and create an array called firstcomponent (the
/// new field will be in the output's point data).
/// Note that, by default, the original array is also passed through.
///
/// @warning
/// When using Java, Python or Visual Basic bindings, the array name
/// can not be one of the  AttributeTypes when calling Split() which takes
/// strings as arguments. The wrapped command will
/// always assume the string corresponds to an attribute type when
/// the argument is one of the AttributeTypes. In this situation,
/// use the Split() which takes enums.
///
/// </remarks>
/// <seealso>
///
/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
/// vtkDataSetAttributes vtkDataArray vtkRearrangeFields
/// vtkAssignAttribute vtkMergeFields
/// </seealso>
public class vtkSplitField : vtkDataSetAlgorithm
{
	/// <summary>
	/// Create a new array with the given component.
	/// </summary>
	public enum FieldLocations
	{
		/// <summary>enum member</summary>
		CELL_DATA = 2,
		/// <summary>enum member</summary>
		DATA_OBJECT = 0,
		/// <summary>enum member</summary>
		POINT_DATA = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSplitField";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSplitField()
	{
		MRClassNameKey = "class vtkSplitField";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplitField"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSplitField(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkSplitField.
	/// </summary>
	public new static vtkSplitField New()
	{
		vtkSplitField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkSplitField.
	/// </summary>
	public vtkSplitField()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSplitField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkSplitField_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSplitField_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSplitField_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSplitField_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitField_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSplitField_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSplitField_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSplitField_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitField_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSplitField NewInstance()
	{
		vtkSplitField result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitField_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSplitField_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSplitField SafeDownCast(vtkObjectBase o)
	{
		vtkSplitField vtkSplitField2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSplitField_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSplitField2 = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSplitField2.Register(null);
			}
		}
		return vtkSplitField2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitField_SetInputField_08(HandleRef pThis, int attributeType, int fieldLoc);

	/// <summary>
	/// Use the given attribute in the field data given
	/// by fieldLoc as input.
	/// </summary>
	public void SetInputField(int attributeType, int fieldLoc)
	{
		vtkSplitField_SetInputField_08(GetCppThis(), attributeType, fieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitField_SetInputField_09(HandleRef pThis, string name, int fieldLoc);

	/// <summary>
	/// Use the array with given name in the field data given
	/// by fieldLoc as input.
	/// </summary>
	public void SetInputField(string name, int fieldLoc)
	{
		vtkSplitField_SetInputField_09(GetCppThis(), name, fieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitField_SetInputField_10(HandleRef pThis, string name, string fieldLoc);

	/// <summary>
	/// Helper method used by other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.
	/// </summary>
	public void SetInputField(string name, string fieldLoc)
	{
		vtkSplitField_SetInputField_10(GetCppThis(), name, fieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSplitField_Split_11(HandleRef pThis, int component, string arrayName);

	/// <summary>
	/// Create a new array with the given component.
	/// </summary>
	public void Split(int component, string arrayName)
	{
		vtkSplitField_Split_11(GetCppThis(), component, arrayName);
	}
}
