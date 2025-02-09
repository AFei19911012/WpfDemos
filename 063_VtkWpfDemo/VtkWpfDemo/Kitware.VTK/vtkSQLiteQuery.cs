using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSQLiteQuery
/// </summary>
/// <remarks>
///    vtkSQLQuery implementation for SQLite databases
///
///
///
/// This is an implementation of vtkSQLQuery for SQLite databases.  See
/// the documentation for vtkSQLQuery for information about what the
/// methods do.
///
///
/// @bug
/// Sometimes Execute() will return false (meaning an error) but
/// GetLastErrorText() winds up null.  I am not certain why this is
/// happening.
///
/// @par Thanks:
/// Thanks to Andrew Wilson from Sandia National Laboratories for implementing
/// this class.
///
/// </remarks>
/// <seealso>
///
/// vtkSQLDatabase vtkSQLQuery vtkSQLiteDatabase
/// </seealso>
public class vtkSQLiteQuery : vtkSQLQuery
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSQLiteQuery";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSQLiteQuery()
	{
		MRClassNameKey = "class vtkSQLiteQuery";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLiteQuery"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSQLiteQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteQuery_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLiteQuery New()
	{
		vtkSQLiteQuery result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteQuery_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSQLiteQuery()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSQLiteQuery_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BeginTransaction_01(HandleRef pThis);

	/// <summary>
	/// Begin, abort (roll back), or commit a transaction.
	/// </summary>
	public override bool BeginTransaction()
	{
		return (vtkSQLiteQuery_BeginTransaction_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_02(HandleRef pThis, int index, byte value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, byte value)
	{
		return (vtkSQLiteQuery_BindParameter_02(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_03(HandleRef pThis, int index, sbyte value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, sbyte value)
	{
		return (vtkSQLiteQuery_BindParameter_03(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_04(HandleRef pThis, int index, ushort value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, ushort value)
	{
		return (vtkSQLiteQuery_BindParameter_04(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_05(HandleRef pThis, int index, short value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, short value)
	{
		return (vtkSQLiteQuery_BindParameter_05(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_06(HandleRef pThis, int index, uint value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, uint value)
	{
		return (vtkSQLiteQuery_BindParameter_06(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_07(HandleRef pThis, int index, int value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, int value)
	{
		return (vtkSQLiteQuery_BindParameter_07(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_08(HandleRef pThis, int index, ulong value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, ulong value)
	{
		return (vtkSQLiteQuery_BindParameter_08(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_09(HandleRef pThis, int index, long value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, long value)
	{
		return (vtkSQLiteQuery_BindParameter_09(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_10(HandleRef pThis, int index, float value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, float value)
	{
		return (vtkSQLiteQuery_BindParameter_10(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_11(HandleRef pThis, int index, double value);

	/// <summary>
	/// The following methods bind a parameter value to a placeholder in
	/// the SQL string.  See the documentation for vtkSQLQuery for
	/// further explanation.  The driver makes internal copies of string
	/// and BLOB parameters so you don't need to worry about keeping them
	/// in scope until the query finishes executing.
	/// </summary>
	public override bool BindParameter(int index, double value)
	{
		return (vtkSQLiteQuery_BindParameter_11(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_12(HandleRef pThis, int index, string stringValue);

	/// <summary>
	/// Bind a string value -- string must be null-terminated
	/// </summary>
	public override bool BindParameter(int index, string stringValue)
	{
		return (vtkSQLiteQuery_BindParameter_12(GetCppThis(), index, stringValue) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_13(HandleRef pThis, int index, string stringValue, ulong length);

	/// <summary>
	/// Bind a string value by specifying an array and a size
	/// </summary>
	public override bool BindParameter(int index, string stringValue, ulong length)
	{
		return (vtkSQLiteQuery_BindParameter_13(GetCppThis(), index, stringValue, length) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_14(HandleRef pThis, int index, HandleRef value);

	/// <summary>
	/// Bind a string value by specifying an array and a size
	/// </summary>
	public override bool BindParameter(int index, vtkVariant value)
	{
		return (vtkSQLiteQuery_BindParameter_14(GetCppThis(), index, value?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_BindParameter_15(HandleRef pThis, int index, IntPtr data, ulong length);

	/// <summary>
	/// Bind a blob value.  Not all databases support blobs as a data
	/// type.  Check vtkSQLDatabase::IsSupported(VTK_SQL_FEATURE_BLOB) to
	/// make sure.
	/// </summary>
	public override bool BindParameter(int index, IntPtr data, ulong length)
	{
		return (vtkSQLiteQuery_BindParameter_15(GetCppThis(), index, data, length) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_ClearParameterBindings_16(HandleRef pThis);

	/// <summary>
	/// Bind a blob value.  Not all databases support blobs as a data
	/// type.  Check vtkSQLDatabase::IsSupported(VTK_SQL_FEATURE_BLOB) to
	/// make sure.
	/// </summary>
	public override bool ClearParameterBindings()
	{
		return (vtkSQLiteQuery_ClearParameterBindings_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_CommitTransaction_17(HandleRef pThis);

	/// <summary>
	/// Begin, abort (roll back), or commit a transaction.
	/// </summary>
	public override bool CommitTransaction()
	{
		return (vtkSQLiteQuery_CommitTransaction_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteQuery_DataValue_18(HandleRef pThis, long c, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return data in current row, field c
	/// </summary>
	public override vtkVariant DataValue(long c)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteQuery_DataValue_18(GetCppThis(), c, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_Execute_19(HandleRef pThis);

	/// <summary>
	/// Execute the query.  This must be performed
	/// before any field name or data access functions
	/// are used.
	/// </summary>
	public override bool Execute()
	{
		return (vtkSQLiteQuery_Execute_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteQuery_GetFieldName_20(HandleRef pThis, int i);

	/// <summary>
	/// Return the name of the specified query field.
	/// </summary>
	public override string GetFieldName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkSQLiteQuery_GetFieldName_20(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLiteQuery_GetFieldType_21(HandleRef pThis, int i);

	/// <summary>
	/// Return the type of the field, using the constants defined in vtkType.h.
	/// </summary>
	public override int GetFieldType(int i)
	{
		return vtkSQLiteQuery_GetFieldType_21(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteQuery_GetLastErrorText_22(HandleRef pThis);

	/// <summary>
	/// Get the last error text from the query
	/// </summary>
	public override string GetLastErrorText()
	{
		return Marshal.PtrToStringAnsi(vtkSQLiteQuery_GetLastErrorText_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLiteQuery_GetNumberOfFields_23(HandleRef pThis);

	/// <summary>
	/// The number of fields in the query result.
	/// </summary>
	public override int GetNumberOfFields()
	{
		return vtkSQLiteQuery_GetNumberOfFields_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLiteQuery_GetNumberOfGenerationsFromBase_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSQLiteQuery_GetNumberOfGenerationsFromBase_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLiteQuery_GetNumberOfGenerationsFromBaseType_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSQLiteQuery_GetNumberOfGenerationsFromBaseType_25(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_HasError_26(HandleRef pThis);

	/// <summary>
	/// Return true if there is an error on the current query.
	/// </summary>
	public override bool HasError()
	{
		return (vtkSQLiteQuery_HasError_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLiteQuery_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSQLiteQuery_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLiteQuery_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSQLiteQuery_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteQuery_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSQLiteQuery NewInstance()
	{
		vtkSQLiteQuery result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteQuery_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_NextRow_31(HandleRef pThis);

	/// <summary>
	/// Advance row, return false if past end.
	/// </summary>
	public override bool NextRow()
	{
		return (vtkSQLiteQuery_NextRow_31(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_RollbackTransaction_32(HandleRef pThis);

	/// <summary>
	/// Begin, abort (roll back), or commit a transaction.
	/// </summary>
	public override bool RollbackTransaction()
	{
		return (vtkSQLiteQuery_RollbackTransaction_32(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteQuery_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLiteQuery SafeDownCast(vtkObjectBase o)
	{
		vtkSQLiteQuery vtkSQLiteQuery2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteQuery_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSQLiteQuery2 = (vtkSQLiteQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSQLiteQuery2.Register(null);
			}
		}
		return vtkSQLiteQuery2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteQuery_SetQuery_34(HandleRef pThis, string query);

	/// <summary>
	/// Set the SQL query string.  This must be performed before
	/// Execute() or BindParameter() can be called.
	/// </summary>
	public override bool SetQuery(string query)
	{
		return (vtkSQLiteQuery_SetQuery_34(GetCppThis(), query) != 0) ? true : false;
	}
}
