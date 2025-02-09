using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSQLQuery
/// </summary>
/// <remarks>
///    executes an sql query and retrieves results
///
///
/// The abstract superclass of SQL query classes.  Instances of subclasses
/// of vtkSQLQuery are created using the GetQueryInstance() function in
/// vtkSQLDatabase.  To implement a query connection for a new database
/// type, subclass both vtkSQLDatabase and vtkSQLQuery, and implement the
/// required functions.  For the query class, this involves the following:
///
/// Execute() - Execute the query on the database.  No results need to be
///             retrieved at this point, unless you are performing caching.
///
/// GetNumberOfFields() - After Execute() is performed, returns the number
///                       of fields in the query results.
///
/// GetFieldName() - The name of the field at an index.
///
/// GetFieldType() - The data type of the field at an index.
///
/// NextRow() - Advances the query results by one row, and returns whether
///             there are more rows left in the query.
///
/// DataValue() - Extract a single data value from the current row.
///
/// Begin/Rollback/CommitTransaction() - These methods are optional but
/// recommended if the database supports transactions.
///
/// @par Thanks:
/// Thanks to Andrew Wilson from Sandia National Laboratories for his work
/// on the database classes.
///
/// </remarks>
/// <seealso>
///
/// vtkSQLDatabase
/// </seealso>
public abstract class vtkSQLQuery : vtkRowQuery
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSQLQuery";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSQLQuery()
	{
		MRClassNameKey = "class vtkSQLQuery";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLQuery"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSQLQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BeginTransaction_01(HandleRef pThis);

	/// <summary>
	/// Begin, commit, or roll back a transaction.  If the underlying
	/// database does not support transactions these calls will do
	/// nothing.
	/// </summary>
	public virtual bool BeginTransaction()
	{
		return (vtkSQLQuery_BeginTransaction_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_02(HandleRef pThis, int index, byte value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, byte value)
	{
		return (vtkSQLQuery_BindParameter_02(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_03(HandleRef pThis, int index, ushort value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, ushort value)
	{
		return (vtkSQLQuery_BindParameter_03(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_04(HandleRef pThis, int index, uint value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, uint value)
	{
		return (vtkSQLQuery_BindParameter_04(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_05(HandleRef pThis, int index, sbyte value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, sbyte value)
	{
		return (vtkSQLQuery_BindParameter_05(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_06(HandleRef pThis, int index, short value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, short value)
	{
		return (vtkSQLQuery_BindParameter_06(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_07(HandleRef pThis, int index, int value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, int value)
	{
		return (vtkSQLQuery_BindParameter_07(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_08(HandleRef pThis, int index, ulong value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, ulong value)
	{
		return (vtkSQLQuery_BindParameter_08(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_09(HandleRef pThis, int index, long value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, long value)
	{
		return (vtkSQLQuery_BindParameter_09(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_10(HandleRef pThis, int index, float value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, float value)
	{
		return (vtkSQLQuery_BindParameter_10(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_11(HandleRef pThis, int index, double value);

	/// <summary>
	/// Bind a parameter to a placeholder in a query.  A full discussion
	/// of this feature is beyond the scope of this header file, but in
	/// short, here's how it works:
	///
	/// Instead of saying "SELECT foo FROM mytable WHERE myfield = 12345"
	/// you can say "SELECT foo FROM mytable WHERE myfield = ?".  The ?
	/// character is a placeholder for a parameter that must then be
	/// bound.  Call BindParameter(0, 12345) to bind the integer value
	/// 12345 to that field.  Placeholders are indexed starting at 0.
	///
	/// You are responsible for making sure that the types match when you
	/// call BindParameter.  You don't have to get it precisely correct:
	/// in general, the SQL driver is smart enough to do things like cast
	/// a short to a long or a float to a double.
	///
	/// Bound parameters were introduced in ANSI SQL 92.  Please see that
	/// standard for more information.
	///
	/// Most of these methods are excluded from wrapping because the Java
	/// wrapper treats all integer types from char up through 64-bit long
	/// as 'int'.  This is incorrect behavior but what else am I going to
	/// do?
	///
	/// Finally, the default implementation for BindParameter(int,
	/// vtkVariant) dispatches to one of the more type-specific versions.  It
	/// should be OK to use in database drivers without modification.
	/// </summary>
	public virtual bool BindParameter(int index, double value)
	{
		return (vtkSQLQuery_BindParameter_11(GetCppThis(), index, value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_12(HandleRef pThis, int index, string stringValue);

	/// <summary>
	/// Bind a string value -- string must be null-terminated
	/// </summary>
	public virtual bool BindParameter(int index, string stringValue)
	{
		return (vtkSQLQuery_BindParameter_12(GetCppThis(), index, stringValue) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_13(HandleRef pThis, int index, string stringValue, ulong length);

	/// <summary>
	/// Bind a string value by specifying an array and a size
	/// </summary>
	public virtual bool BindParameter(int index, string stringValue, ulong length)
	{
		return (vtkSQLQuery_BindParameter_13(GetCppThis(), index, stringValue, length) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_14(HandleRef pThis, int index, HandleRef var);

	/// <summary>
	/// Bind a string value by specifying an array and a size
	/// </summary>
	public virtual bool BindParameter(int index, vtkVariant var)
	{
		return (vtkSQLQuery_BindParameter_14(GetCppThis(), index, var?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_BindParameter_15(HandleRef pThis, int index, IntPtr data, ulong length);

	/// <summary>
	/// Bind a blob value.  Not all databases support blobs as a data
	/// type.  Check vtkSQLDatabase::IsSupported(VTK_SQL_FEATURE_BLOB) to
	/// make sure.
	/// </summary>
	public virtual bool BindParameter(int index, IntPtr data, ulong length)
	{
		return (vtkSQLQuery_BindParameter_15(GetCppThis(), index, data, length) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_ClearParameterBindings_16(HandleRef pThis);

	/// <summary>
	/// Reset all parameter bindings to nullptr.
	/// </summary>
	public virtual bool ClearParameterBindings()
	{
		return (vtkSQLQuery_ClearParameterBindings_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_CommitTransaction_17(HandleRef pThis);

	/// <summary>
	/// Begin, commit, or roll back a transaction.  If the underlying
	/// database does not support transactions these calls will do
	/// nothing.
	/// </summary>
	public virtual bool CommitTransaction()
	{
		return (vtkSQLQuery_CommitTransaction_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLQuery_EscapeString_18(HandleRef pThis, string s, byte addSurroundingQuotes);

	/// <summary>
	/// Escape a string for inclusion into an SQL query.
	/// If \a addSurroundingQuotes is true, then quotation marks appropriate to the
	/// backend database will be added to enclose the escaped string. This argument
	/// defaults to true.
	///
	/// A default, simple-minded implementation is provided for
	/// database backends that do not provde a way to escape
	/// strings for use inside queries.
	/// </summary>
	public virtual string EscapeString(string s, bool addSurroundingQuotes)
	{
		return vtkSQLQuery_EscapeString_18(GetCppThis(), s, (byte)(addSurroundingQuotes ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_Execute_19(HandleRef pThis);

	/// <summary>
	/// Execute the query.  This must be performed
	/// before any field name or data access functions
	/// are used.
	/// </summary>
	public override bool Execute()
	{
		return (vtkSQLQuery_Execute_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLQuery_GetDatabase_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the database associated with the query.
	/// </summary>
	public virtual vtkSQLDatabase GetDatabase()
	{
		vtkSQLDatabase vtkSQLDatabase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLQuery_GetDatabase_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSQLDatabase2 = (vtkSQLDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSQLDatabase2.Register(null);
			}
		}
		return vtkSQLDatabase2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLQuery_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSQLQuery_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLQuery_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSQLQuery_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLQuery_GetQuery_23(HandleRef pThis);

	/// <summary>
	/// The query string to be executed.  Since some databases will
	/// process the query string as soon as it's set, this method returns
	/// a boolean to indicate success or failure.
	/// </summary>
	public virtual string GetQuery()
	{
		return Marshal.PtrToStringAnsi(vtkSQLQuery_GetQuery_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLQuery_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSQLQuery_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_IsActive_25(HandleRef pThis);

	/// <summary>
	/// Return true if the query is active (i.e. execution was successful
	/// and results are ready to be fetched).  Returns false on error or
	/// inactive query.
	/// </summary>
	public override bool IsActive()
	{
		return (vtkSQLQuery_IsActive_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLQuery_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSQLQuery_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLQuery_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSQLQuery NewInstance()
	{
		vtkSQLQuery result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLQuery_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_RollbackTransaction_28(HandleRef pThis);

	/// <summary>
	/// Begin, commit, or roll back a transaction.  If the underlying
	/// database does not support transactions these calls will do
	/// nothing.
	/// </summary>
	public virtual bool RollbackTransaction()
	{
		return (vtkSQLQuery_RollbackTransaction_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLQuery_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLQuery SafeDownCast(vtkObjectBase o)
	{
		vtkSQLQuery vtkSQLQuery2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLQuery_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSQLQuery2 = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSQLQuery2.Register(null);
			}
		}
		return vtkSQLQuery2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLQuery_SetQuery_30(HandleRef pThis, string query);

	/// <summary>
	/// The query string to be executed.  Since some databases will
	/// process the query string as soon as it's set, this method returns
	/// a boolean to indicate success or failure.
	/// </summary>
	public virtual bool SetQuery(string query)
	{
		return (vtkSQLQuery_SetQuery_30(GetCppThis(), query) != 0) ? true : false;
	}
}
