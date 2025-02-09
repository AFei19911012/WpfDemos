using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMergeFields
/// </summary>
/// <remarks>
///    Merge multiple fields into one.
///
/// vtkMergeFields is used to merge multiple field into one.
/// The new field is put in the same field data as the original field.
/// For example
/// @verbatim
/// mf-&gt;SetOutputField("foo", vtkMergeFields::POINT_DATA);
/// mf-&gt;SetNumberOfComponents(2);
/// mf-&gt;Merge(0, "array1", 1);
/// mf-&gt;Merge(1, "array2", 0);
/// @endverbatim
/// will tell vtkMergeFields to use the 2nd component of array1 and
/// the 1st component of array2 to create a 2 component field called foo.
///
/// </remarks>
/// <seealso>
///
/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
/// vtkDataSetAttributes vtkDataArray vtkRearrangeFields
/// vtkSplitField vtkAssignAttribute
/// </seealso>
public class vtkMergeFields : vtkDataSetAlgorithm
{
	/// <summary>
	/// Set the number of the components in the output field.
	/// This has to be set before execution. Default value is 0.
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkMergeFields";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMergeFields()
	{
		MRClassNameKey = "class vtkMergeFields";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeFields"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMergeFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkMergeFields.
	/// </summary>
	public new static vtkMergeFields New()
	{
		vtkMergeFields result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkMergeFields.
	/// </summary>
	public vtkMergeFields()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMergeFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkMergeFields_GetNumberOfComponents_01(HandleRef pThis);

	/// <summary>
	/// Set the number of the components in the output field.
	/// This has to be set before execution. Default value is 0.
	/// </summary>
	public virtual int GetNumberOfComponents()
	{
		return vtkMergeFields_GetNumberOfComponents_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeFields_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMergeFields_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeFields_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMergeFields_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeFields_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMergeFields_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeFields_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMergeFields_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeFields_Merge_06(HandleRef pThis, int component, string arrayName, int sourceComp);

	/// <summary>
	/// Add a component (arrayName,sourceComp) to the output field.
	/// </summary>
	public void Merge(int component, string arrayName, int sourceComp)
	{
		vtkMergeFields_Merge_06(GetCppThis(), component, arrayName, sourceComp);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeFields_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMergeFields NewInstance()
	{
		vtkMergeFields result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeFields_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeFields_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeFields SafeDownCast(vtkObjectBase o)
	{
		vtkMergeFields vtkMergeFields2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeFields_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMergeFields2 = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMergeFields2.Register(null);
			}
		}
		return vtkMergeFields2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeFields_SetNumberOfComponents_10(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of the components in the output field.
	/// This has to be set before execution. Default value is 0.
	/// </summary>
	public virtual void SetNumberOfComponents(int _arg)
	{
		vtkMergeFields_SetNumberOfComponents_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeFields_SetOutputField_11(HandleRef pThis, string name, int fieldLoc);

	/// <summary>
	/// The output field will have the given name and it will be in
	/// fieldLoc (the input fields also have to be in fieldLoc).
	/// </summary>
	public void SetOutputField(string name, int fieldLoc)
	{
		vtkMergeFields_SetOutputField_11(GetCppThis(), name, fieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeFields_SetOutputField_12(HandleRef pThis, string name, string fieldLoc);

	/// <summary>
	/// Helper method used by the other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.Returns an operation id
	/// which can later be used to remove the operation.
	/// </summary>
	public void SetOutputField(string name, string fieldLoc)
	{
		vtkMergeFields_SetOutputField_12(GetCppThis(), name, fieldLoc);
	}
}
