using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTable
/// </summary>
/// <remarks>
///    A table, which contains similar-typed columns of data
///
///
/// vtkTable is a basic data structure for storing columns of data.
/// Internally, columns are stored in a vtkDataSetAttributes structure called
/// RowData. However, using the vtkTable API additionally ensures that every column
/// has the same number of entries, and provides row access (using vtkVariantArray)
/// and single entry access (using vtkVariant).
///
/// Inserting or removing rows via the class API preserves existing table data where possible.
///
/// The "RemoveRow*" and SetNumberOfRows() operations will not release memory. Call on SqueezeRows()
/// to achieve this after performing the operations.
///
/// The field data inherited from vtkDataObject may be used to store metadata
/// related to the table.
///
/// @warning
/// You should use the vtkTable API to change the table data. Performing
/// operations on the object returned by GetRowData() may
/// yield unexpected results. vtkTable does allow the user to set the field
/// data using SetRowData(); the number of rows in the table is determined
/// by the number of tuples in the first array (it is assumed that all arrays
/// are the same length).
///
/// @warning
/// Each column added with AddColumn &lt;b&gt;must&lt;/b&gt; have its name set to a unique,
/// non-empty string in order for GetValue() to function properly.
///
/// @par Thanks:
/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
/// Sandia National Laboratories for their help in developing this class API.
/// </remarks>
public class vtkTable : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTable()
	{
		MRClassNameKey = "class vtkTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTable New()
	{
		vtkTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_AddColumn_01(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Add a column to the table.
	/// </summary>
	public void AddColumn(vtkAbstractArray arr)
	{
		vtkTable_AddColumn_01(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_DeepCopy_02(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow/deep copy the data from src into this object.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkTable_DeepCopy_02(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_Dump_03(HandleRef pThis, uint colWidth, int rowLimit);

	/// <summary>
	/// Dump table contents.  If rowLimit is -1 then the full table
	/// is printed out (Default).  If rowLimit is 0 then only the
	/// header row will be displayed.  Otherwise, if rowLimit &gt; 0
	/// then Dump will print the first rowLimit rows of data.
	/// </summary>
	public void Dump(uint colWidth, int rowLimit)
	{
		vtkTable_Dump_03(GetCppThis(), colWidth, rowLimit);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_ExtendedNew_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static vtkTable ExtendedNew()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_ExtendedNew_04(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkTable_GetActualMemorySize_05(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated. The memory size
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to represent the data (e.g., extra space in
	/// arrays, etc. are not included in the return value).
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkTable_GetActualMemorySize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetAttributesAsFieldData_06(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the attributes of the data object as a vtkFieldData.
	/// This returns non-null values in all the same cases as GetAttributes,
	/// in addition to the case of FIELD, which will return the field data
	/// for any vtkDataObject subclass.
	/// </summary>
	public override vtkFieldData GetAttributesAsFieldData(int type)
	{
		vtkFieldData vtkFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetAttributesAsFieldData_06(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldData2 = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldData2.Register(null);
			}
		}
		return vtkFieldData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetColumn_07(HandleRef pThis, long col, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a column of the table by its column index.
	/// </summary>
	public vtkAbstractArray GetColumn(long col)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetColumn_07(GetCppThis(), col, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetColumnByName_08(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a column of the table by its name.
	/// </summary>
	public vtkAbstractArray GetColumnByName(string name)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetColumnByName_08(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTable_GetColumnIndex_09(HandleRef pThis, string name);

	/// <summary>
	/// Get the column index for a name.
	/// If name is not found returns -1.
	/// </summary>
	public long GetColumnIndex(string name)
	{
		return vtkTable_GetColumnIndex_09(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetColumnName_10(HandleRef pThis, long col);

	/// <summary>
	/// Get the number of columns in the table.
	/// </summary>
	public string GetColumnName(long col)
	{
		return Marshal.PtrToStringAnsi(vtkTable_GetColumnName_10(GetCppThis(), col));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetData_11(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the table from vtkInformation.
	/// </summary>
	public new static vtkTable GetData(vtkInformation info)
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetData_11(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetData_12(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the table from vtkInformation.
	/// </summary>
	public new static vtkTable GetData(vtkInformationVector v, int i)
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetData_12(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTable_GetDataObjectType_13(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkTable_GetDataObjectType_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTable_GetNumberOfColumns_14(HandleRef pThis);

	/// <summary>
	/// Get the number of columns in the table.
	/// </summary>
	public long GetNumberOfColumns()
	{
		return vtkTable_GetNumberOfColumns_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTable_GetNumberOfElements_15(HandleRef pThis, int type);

	/// <summary>
	/// Get the number of elements for a specific attribute type (ROW, etc.).
	/// </summary>
	public override long GetNumberOfElements(int type)
	{
		return vtkTable_GetNumberOfElements_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTable_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTable_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTable_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTable_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTable_GetNumberOfRows_18(HandleRef pThis);

	/// <summary>
	/// Get the number of rows in the table.
	/// </summary>
	public long GetNumberOfRows()
	{
		return vtkTable_GetNumberOfRows_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetRow_19(HandleRef pThis, long row, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a row of the table as a vtkVariantArray which has one entry for each column.
	/// NOTE: This version of the method is NOT thread safe.
	/// </summary>
	public vtkVariantArray GetRow(long row)
	{
		vtkVariantArray vtkVariantArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetRow_19(GetCppThis(), row, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVariantArray2 = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVariantArray2.Register(null);
			}
		}
		return vtkVariantArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_GetRow_20(HandleRef pThis, long row, HandleRef values);

	/// <summary>
	/// Get a row of the table as a vtkVariantArray which has one entry for each column.
	/// </summary>
	public void GetRow(long row, vtkVariantArray values)
	{
		vtkTable_GetRow_20(GetCppThis(), row, values?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetRowData_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the main data (columns) of the table.
	/// </summary>
	public virtual vtkDataSetAttributes GetRowData()
	{
		vtkDataSetAttributes vtkDataSetAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetRowData_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetAttributes2 = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetAttributes2.Register(null);
			}
		}
		return vtkDataSetAttributes2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetValue_22(HandleRef pThis, long row, long col, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a value in the table by row and column index as a variant.
	/// Note that this calls GetValueByName internally so that each column
	/// array must have its name set (and that name should be unique within
	/// the table).
	/// </summary>
	public vtkVariant GetValue(long row, long col)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetValue_22(GetCppThis(), row, col, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_GetValueByName_23(HandleRef pThis, long row, string col, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve a value in the table by row index and column name as a variant.
	/// </summary>
	public vtkVariant GetValueByName(long row, string col)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_GetValueByName_23(GetCppThis(), row, col, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_Initialize_24(HandleRef pThis);

	/// <summary>
	/// Initialize to an empty table.
	/// </summary>
	public override void Initialize()
	{
		vtkTable_Initialize_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_InsertColumn_25(HandleRef pThis, HandleRef arr, long index);

	/// <summary>
	/// Insert a column into the table at given column index.
	/// </summary>
	public void InsertColumn(vtkAbstractArray arr, long index)
	{
		vtkTable_InsertColumn_25(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTable_InsertNextBlankRow_26(HandleRef pThis, double default_num_val);

	/// <summary>
	/// Insert a blank row at the end of the table.
	/// </summary>
	public long InsertNextBlankRow(double default_num_val)
	{
		return vtkTable_InsertNextBlankRow_26(GetCppThis(), default_num_val);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTable_InsertNextRow_27(HandleRef pThis, HandleRef values);

	/// <summary>
	/// Insert a row at the end of the tablespecified by a vtkVariantArray. The number of entries in
	/// the array should match the number of columns in the table.
	/// </summary>
	public long InsertNextRow(vtkVariantArray values)
	{
		return vtkTable_InsertNextRow_27(GetCppThis(), values?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_InsertRow_28(HandleRef pThis, long row);

	/// <summary>
	/// Insert a single row at the index.
	/// </summary>
	public void InsertRow(long row)
	{
		vtkTable_InsertRow_28(GetCppThis(), row);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_InsertRows_29(HandleRef pThis, long row, long n);

	/// <summary>
	/// Insert n rows before row. If row &lt; 0 then the rows will be prepended to the table.
	/// </summary>
	public void InsertRows(long row, long n)
	{
		vtkTable_InsertRows_29(GetCppThis(), row, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTable_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTable_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTable_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTable_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTable NewInstance()
	{
		vtkTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_RemoveAllColumns_34(HandleRef pThis);

	/// <summary>
	/// Remove all columns from the table.
	/// </summary>
	public void RemoveAllColumns()
	{
		vtkTable_RemoveAllColumns_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_RemoveAllRows_35(HandleRef pThis);

	/// <summary>
	/// Delete all rows from the table. The column arrays are not delete, they are just empty
	/// after this operation.
	/// </summary>
	public void RemoveAllRows()
	{
		vtkTable_RemoveAllRows_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_RemoveColumn_36(HandleRef pThis, long col);

	/// <summary>
	/// Remove a column from the table by its column index.
	/// </summary>
	public void RemoveColumn(long col)
	{
		vtkTable_RemoveColumn_36(GetCppThis(), col);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_RemoveColumnByName_37(HandleRef pThis, string name);

	/// <summary>
	/// Remove a column from the table by its name.
	/// </summary>
	public void RemoveColumnByName(string name)
	{
		vtkTable_RemoveColumnByName_37(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_RemoveRow_38(HandleRef pThis, long row);

	/// <summary>
	/// Delete a single row from the table. Rows below the deleted row are shifted up.
	/// </summary>
	public void RemoveRow(long row)
	{
		vtkTable_RemoveRow_38(GetCppThis(), row);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_RemoveRows_39(HandleRef pThis, long row, long n);

	/// <summary>
	/// Delete n rows from the table, starting at row. Rows below the deleted rows are shifted up.
	/// </summary>
	public void RemoveRows(long row, long n)
	{
		vtkTable_RemoveRows_39(GetCppThis(), row, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTable_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTable SafeDownCast(vtkObjectBase o)
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTable_SafeDownCast_40(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_SetNumberOfRows_41(HandleRef pThis, long arg0);

	/// <summary>
	/// Set the number of rows in the table. Note that memory allocation might be performed
	/// as a result of this, but no memory will be released. Existing data is preserved if the table is
	/// expanding.
	/// </summary>
	public void SetNumberOfRows(long arg0)
	{
		vtkTable_SetNumberOfRows_41(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_SetRow_42(HandleRef pThis, long row, HandleRef values);

	/// <summary>
	/// Set a row of the table with a vtkVariantArray which has one entry for each column.
	/// </summary>
	public void SetRow(long row, vtkVariantArray values)
	{
		vtkTable_SetRow_42(GetCppThis(), row, values?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_SetRowData_43(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Get/Set the main data (columns) of the table.
	/// </summary>
	public virtual void SetRowData(vtkDataSetAttributes data)
	{
		vtkTable_SetRowData_43(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_SetValue_44(HandleRef pThis, long row, long col, HandleRef value);

	/// <summary>
	/// Set a value in the table by row and column index as a variant.
	/// </summary>
	public void SetValue(long row, long col, vtkVariant value)
	{
		vtkTable_SetValue_44(GetCppThis(), row, col, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_SetValueByName_45(HandleRef pThis, long row, string col, HandleRef value);

	/// <summary>
	/// Set a value in the table by row index and column name as a variant.
	/// </summary>
	public void SetValueByName(long row, string col, vtkVariant value)
	{
		vtkTable_SetValueByName_45(GetCppThis(), row, col, value?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_ShallowCopy_46(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow/deep copy the data from src into this object.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkTable_ShallowCopy_46(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTable_SqueezeRows_47(HandleRef pThis);

	/// <summary>
	/// Release previously allocated and now unused memory after performing resizing operations.
	/// </summary>
	public void SqueezeRows()
	{
		vtkTable_SqueezeRows_47(GetCppThis());
	}
}
