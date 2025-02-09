using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRearrangeFields
/// </summary>
/// <remarks>
///    Move/copy fields between field data, point data and cell data
///
/// vtkRearrangeFields is used to copy/move fields (vtkDataArrays) between
/// data object's field data, point data and cell data. To specify which
/// fields are copied/moved, the user adds operations. There are two types
/// of operations: 1. the type which copies/moves an attribute's data
/// (i.e. the field will be copied but will not be an attribute in the
/// target), 2. the type which copies/moves fields by name. For example:
/// @verbatim
/// rf-&gt;AddOperation(vtkRearrangeFields::COPY, "foo",
///                  vtkRearrangeFields::DATA_OBJECT,
///                  vtkRearrangeFields::POINT_DATA);
/// @endverbatim
/// adds an operation which copies a field (data array) called foo from
/// the data object's field data to point data.
/// The same can be done using Python and Java bindings by passing
/// strings as arguments.
/// @verbatim
/// Operation types: COPY, MOVE
/// AttributeTypes: SCALARS, VECTORS, NORMALS, TCOORDS, TENSORS
/// Field data locations: DATA_OBJECT, POINT_DATA, CELL_DATA
/// @endverbatim
///
/// @warning
/// When using Java, Python or Visual Basic bindings, the array name
/// can not be one of the  AttributeTypes when calling AddOperation() which
/// takes strings as arguments. The wrapped command will
/// always assume the string corresponds to an attribute type when
/// the argument is one of the AttributeTypes. In this situation,
/// use the AddOperation() which takes enums.
///
/// </remarks>
/// <seealso>
///
/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
/// vtkDataSetAttributes vtkDataArray vtkAssignAttribute
/// vtkSplitField vtkMergeFields
/// </seealso>
public class vtkRearrangeFields : vtkDataSetAlgorithm
{
	/// <summary>
	/// Create a new vtkRearrangeFields with an empty operation list.
	/// </summary>
	public enum FieldLocation
	{
		/// <summary>enum member</summary>
		CELL_DATA = 2,
		/// <summary>enum member</summary>
		DATA_OBJECT = 0,
		/// <summary>enum member</summary>
		POINT_DATA = 1
	}

	/// <summary>
	/// Remove all operations.
	/// </summary>
	public enum FieldType
	{
		/// <summary>enum member</summary>
		ATTRIBUTE = 1,
		/// <summary>enum member</summary>
		NAME = 0
	}

	/// <summary>
	/// Create a new vtkRearrangeFields with an empty operation list.
	/// </summary>
	public enum OperationType
	{
		/// <summary>enum member</summary>
		COPY,
		/// <summary>enum member</summary>
		MOVE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRearrangeFields";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRearrangeFields()
	{
		MRClassNameKey = "class vtkRearrangeFields";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRearrangeFields"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRearrangeFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRearrangeFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkRearrangeFields with an empty operation list.
	/// </summary>
	public new static vtkRearrangeFields New()
	{
		vtkRearrangeFields result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRearrangeFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkRearrangeFields with an empty operation list.
	/// </summary>
	public vtkRearrangeFields()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRearrangeFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkRearrangeFields_AddOperation_01(HandleRef pThis, int operationType, int attributeType, int fromFieldLoc, int toFieldLoc);

	/// <summary>
	/// Add an operation which copies an attribute's field (data array) from
	/// one field data to another. Returns an operation id which can later
	/// be used to remove the operation.
	/// </summary>
	public int AddOperation(int operationType, int attributeType, int fromFieldLoc, int toFieldLoc)
	{
		return vtkRearrangeFields_AddOperation_01(GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRearrangeFields_AddOperation_02(HandleRef pThis, int operationType, string name, int fromFieldLoc, int toFieldLoc);

	/// <summary>
	/// Add an operation which copies a field (data array) from one field
	/// data to another. Returns an operation id which can later
	/// be used to remove the operation.
	/// </summary>
	public int AddOperation(int operationType, string name, int fromFieldLoc, int toFieldLoc)
	{
		return vtkRearrangeFields_AddOperation_02(GetCppThis(), operationType, name, fromFieldLoc, toFieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRearrangeFields_AddOperation_03(HandleRef pThis, string operationType, string attributeType, string fromFieldLoc, string toFieldLoc);

	/// <summary>
	/// Helper method used by other language bindings. Allows the caller to
	/// specify arguments as strings instead of enums.Returns an operation id
	/// which can later be used to remove the operation.
	/// </summary>
	public int AddOperation(string operationType, string attributeType, string fromFieldLoc, string toFieldLoc)
	{
		return vtkRearrangeFields_AddOperation_03(GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRearrangeFields_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRearrangeFields_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRearrangeFields_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRearrangeFields_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRearrangeFields_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRearrangeFields_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRearrangeFields_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRearrangeFields_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRearrangeFields_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRearrangeFields NewInstance()
	{
		vtkRearrangeFields result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRearrangeFields_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRearrangeFields_RemoveAllOperations_10(HandleRef pThis);

	/// <summary>
	/// Remove all operations.
	/// </summary>
	public void RemoveAllOperations()
	{
		vtkRearrangeFields_RemoveAllOperations_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRearrangeFields_RemoveOperation_11(HandleRef pThis, int operationId);

	/// <summary>
	/// Remove an operation with the given id.
	/// </summary>
	public int RemoveOperation(int operationId)
	{
		return vtkRearrangeFields_RemoveOperation_11(GetCppThis(), operationId);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRearrangeFields_RemoveOperation_12(HandleRef pThis, int operationType, int attributeType, int fromFieldLoc, int toFieldLoc);

	/// <summary>
	/// Remove an operation with the given signature. See AddOperation
	/// for details.
	/// </summary>
	public int RemoveOperation(int operationType, int attributeType, int fromFieldLoc, int toFieldLoc)
	{
		return vtkRearrangeFields_RemoveOperation_12(GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRearrangeFields_RemoveOperation_13(HandleRef pThis, int operationType, string name, int fromFieldLoc, int toFieldLoc);

	/// <summary>
	/// Remove an operation with the given signature. See AddOperation
	/// for details.
	/// </summary>
	public int RemoveOperation(int operationType, string name, int fromFieldLoc, int toFieldLoc)
	{
		return vtkRearrangeFields_RemoveOperation_13(GetCppThis(), operationType, name, fromFieldLoc, toFieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRearrangeFields_RemoveOperation_14(HandleRef pThis, string operationType, string attributeType, string fromFieldLoc, string toFieldLoc);

	/// <summary>
	/// Remove an operation with the given signature. See AddOperation
	/// for details.
	/// </summary>
	public int RemoveOperation(string operationType, string attributeType, string fromFieldLoc, string toFieldLoc)
	{
		return vtkRearrangeFields_RemoveOperation_14(GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRearrangeFields_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRearrangeFields SafeDownCast(vtkObjectBase o)
	{
		vtkRearrangeFields vtkRearrangeFields2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRearrangeFields_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRearrangeFields2 = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRearrangeFields2.Register(null);
			}
		}
		return vtkRearrangeFields2;
	}
}
