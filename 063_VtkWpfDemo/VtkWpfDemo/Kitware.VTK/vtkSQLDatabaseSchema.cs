using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSQLDatabaseSchema
/// </summary>
/// <remarks>
///    represent an SQL database schema
///
///
/// This class stores the information required to create
/// an SQL database from scratch.
/// Information on each table's columns, indices, and triggers is stored.
/// You may also store an arbitrary number of preamble statements, intended
/// to be executed before any tables are created;
/// this provides a way to create procedures or functions that may be
/// invoked as part of a trigger action.
/// Triggers and table options may be specified differently for each backend
/// database type you wish to support.
///
/// @par Thanks:
/// Thanks to Philippe Pebay and David Thompson from Sandia National
/// Laboratories for implementing this class.
///
/// </remarks>
/// <seealso>
///
/// vtkSQLDatabase
/// </seealso>
public class vtkSQLDatabaseSchema : vtkObject
{
	/// <summary>
	/// Basic data types for database columns
	/// </summary>
	public enum DatabaseColumnType
	{
		/// <summary>enum member</summary>
		BIGINT = 3,
		/// <summary>enum member</summary>
		BLOB = 8,
		/// <summary>enum member</summary>
		DATE = 10,
		/// <summary>enum member</summary>
		DOUBLE = 7,
		/// <summary>enum member</summary>
		INTEGER = 2,
		/// <summary>enum member</summary>
		REAL = 6,
		/// <summary>enum member</summary>
		SERIAL = 0,
		/// <summary>enum member</summary>
		SMALLINT = 1,
		/// <summary>enum member</summary>
		TEXT = 5,
		/// <summary>enum member</summary>
		TIME = 9,
		/// <summary>enum member</summary>
		TIMESTAMP = 11,
		/// <summary>enum member</summary>
		VARCHAR = 4
	}

	/// <summary>
	/// Types of indices that can be generated for database tables
	/// </summary>
	public enum DatabaseIndexType
	{
		/// <summary>enum member</summary>
		INDEX = 0,
		/// <summary>enum member</summary>
		PRIMARY_KEY = 2,
		/// <summary>enum member</summary>
		UNIQUE = 1
	}

	/// <summary>
	/// Events where database triggers can be registered.
	/// </summary>
	public enum DatabaseTriggerType
	{
		/// <summary>enum member</summary>
		AFTER_DELETE = 5,
		/// <summary>enum member</summary>
		AFTER_INSERT = 1,
		/// <summary>enum member</summary>
		AFTER_UPDATE = 3,
		/// <summary>enum member</summary>
		BEFORE_DELETE = 4,
		/// <summary>enum member</summary>
		BEFORE_INSERT = 0,
		/// <summary>enum member</summary>
		BEFORE_UPDATE = 2
	}

	/// <summary>
	/// Set/Get the name of the schema.
	/// </summary>
	public enum VarargTokens
	{
		/// <summary>enum member</summary>
		COLUMN_TOKEN = 58,
		/// <summary>enum member</summary>
		END_INDEX_TOKEN = 75,
		/// <summary>enum member</summary>
		END_TABLE_TOKEN = 99,
		/// <summary>enum member</summary>
		INDEX_COLUMN_TOKEN = 65,
		/// <summary>enum member</summary>
		INDEX_TOKEN = 63,
		/// <summary>enum member</summary>
		OPTION_TOKEN = 86,
		/// <summary>enum member</summary>
		TRIGGER_TOKEN = 81
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabaseSchema";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSQLDatabaseSchema()
	{
		MRClassNameKey = "class vtkSQLDatabaseSchema";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabaseSchema"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSQLDatabaseSchema(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLDatabaseSchema New()
	{
		vtkSQLDatabaseSchema result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabaseSchema_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSQLDatabaseSchema()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSQLDatabaseSchema_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSQLDatabaseSchema_AddColumnToIndex_01(HandleRef pThis, int tblHandle, int idxHandle, int colHandle);

	/// <summary>
	/// Add a column to a table index.
	///
	/// The returned value is an index-column handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddColumnToIndex(int tblHandle, int idxHandle, int colHandle)
	{
		return vtkSQLDatabaseSchema_AddColumnToIndex_01(GetCppThis(), tblHandle, idxHandle, colHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddColumnToIndex_02(HandleRef pThis, string tblName, string idxName, string colName);

	/// <summary>
	/// Add a column to a table index.
	///
	/// The returned value is an index-column handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddColumnToIndex(string tblName, string idxName, string colName)
	{
		return vtkSQLDatabaseSchema_AddColumnToIndex_02(GetCppThis(), tblName, idxName, colName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddColumnToTable_03(HandleRef pThis, int tblHandle, int colType, string colName, int colSize, string colOpts);

	/// <summary>
	/// Add a column to table.
	///
	/// The returned value is a column handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddColumnToTable(int tblHandle, int colType, string colName, int colSize, string colOpts)
	{
		return vtkSQLDatabaseSchema_AddColumnToTable_03(GetCppThis(), tblHandle, colType, colName, colSize, colOpts);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddColumnToTable_04(HandleRef pThis, string tblName, int colType, string colName, int colSize, string colAttribs);

	/// <summary>
	/// Add a column to table.
	///
	/// The returned value is a column handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddColumnToTable(string tblName, int colType, string colName, int colSize, string colAttribs)
	{
		return vtkSQLDatabaseSchema_AddColumnToTable_04(GetCppThis(), tblName, colType, colName, colSize, colAttribs);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddIndexToTable_05(HandleRef pThis, int tblHandle, int idxType, string idxName);

	/// <summary>
	/// Add an index to table.
	///
	/// The returned value is an index handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddIndexToTable(int tblHandle, int idxType, string idxName)
	{
		return vtkSQLDatabaseSchema_AddIndexToTable_05(GetCppThis(), tblHandle, idxType, idxName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddIndexToTable_06(HandleRef pThis, string tblName, int idxType, string idxName);

	/// <summary>
	/// Add an index to table.
	///
	/// The returned value is an index handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddIndexToTable(string tblName, int idxType, string idxName)
	{
		return vtkSQLDatabaseSchema_AddIndexToTable_06(GetCppThis(), tblName, idxType, idxName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddOptionToTable_07(HandleRef pThis, int tblHandle, string optText, string optBackend);

	/// <summary>
	/// Add (possibly backend-specific) text to the end of a
	/// CREATE TABLE (...) statement.
	///
	/// This is most useful for specifying storage semantics of tables
	/// that are specific to the backend. For example, table options
	/// can be used to specify the TABLESPACE of a PostgreSQL table or
	/// the ENGINE of a MySQL table.
	///
	/// The returned value is an option handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddOptionToTable(int tblHandle, string optText, string optBackend)
	{
		return vtkSQLDatabaseSchema_AddOptionToTable_07(GetCppThis(), tblHandle, optText, optBackend);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddOptionToTable_08(HandleRef pThis, string tblName, string optStr, string optBackend);

	/// <summary>
	/// Add (possibly backend-specific) text to the end of a
	/// CREATE TABLE (...) statement.
	///
	/// This is most useful for specifying storage semantics of tables
	/// that are specific to the backend. For example, table options
	/// can be used to specify the TABLESPACE of a PostgreSQL table or
	/// the ENGINE of a MySQL table.
	///
	/// The returned value is an option handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddOptionToTable(string tblName, string optStr, string optBackend)
	{
		return vtkSQLDatabaseSchema_AddOptionToTable_08(GetCppThis(), tblName, optStr, optBackend);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddPreamble_09(HandleRef pThis, string preName, string preAction, string preBackend);

	/// <summary>
	/// Add a preamble to the schema
	/// This can be used, in particular, to create functions and/or
	/// load languages in a backend-specific manner.
	/// Example usage:
	/// vtkSQLDatabaseSchema* schema = vtkSQLDatabaseSchema::New();
	/// schema-&gt;SetName( "Example" );
	/// schema-&gt;AddPreamble( "dropPLPGSQL", "DROP LANGUAGE IF EXISTS PLPGSQL CASCADE",
	/// VTK_SQL_POSTGRESQL ); schema-&gt;AddPreamble( "loadPLPGSQL", "CREATE LANGUAGE PLPGSQL",
	/// VTK_SQL_POSTGRESQL ); schema-&gt;AddPreamble( "createsomefunction", "CREATE OR REPLACE FUNCTION
	/// somefunction() RETURNS TRIGGER AS $btable$ " "BEGIN " "INSERT INTO btable (somevalue) VALUES
	/// (NEW.somenmbr); " "RETURN NEW; " "END; $btable$ LANGUAGE PLPGSQL", VTK_SQL_POSTGRESQL );
	/// </summary>
	public virtual int AddPreamble(string preName, string preAction, string preBackend)
	{
		return vtkSQLDatabaseSchema_AddPreamble_09(GetCppThis(), preName, preAction, preBackend);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddTable_10(HandleRef pThis, string tblName);

	/// <summary>
	/// Add a table to the schema
	/// </summary>
	public virtual int AddTable(string tblName)
	{
		return vtkSQLDatabaseSchema_AddTable_10(GetCppThis(), tblName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddTableMultipleArguments_11(HandleRef pThis, string tblName);

	/// <summary>
	/// An unwrappable but useful routine to construct built-in schema.
	/// Example usage:
	/// int main()
	/// {
	/// vtkSQLDatabaseSchema* schema = vtkSQLDatabaseSchema::New();
	/// schema-&gt;SetName( "Example" );
	/// schema-&gt;AddTableMultipleArguments( "atable",
	/// vtkSQLDatabaseSchema::COLUMN_TOKEN, vtkSQLDatabaseSchema::INTEGER, "tablekey",  0, "",
	/// vtkSQLDatabaseSchema::COLUMN_TOKEN, vtkSQLDatabaseSchema::VARCHAR, "somename", 11, "NOT
	/// nullptr", vtkSQLDatabaseSchema::COLUMN_TOKEN, vtkSQLDatabaseSchema::BIGINT,  "somenmbr", 17,
	/// "DEFAULT 0", vtkSQLDatabaseSchema::INDEX_TOKEN, vtkSQLDatabaseSchema::PRIMARY_KEY, "bigkey",
	/// vtkSQLDatabaseSchema::INDEX_COLUMN_TOKEN, "tablekey",
	/// vtkSQLDatabaseSchema::END_INDEX_TOKEN,
	/// vtkSQLDatabaseSchema::INDEX_TOKEN,  vtkSQLDatabaseSchema::UNIQUE, "reverselookup",
	/// vtkSQLDatabaseSchema::INDEX_COLUMN_TOKEN, "somename",
	/// vtkSQLDatabaseSchema::INDEX_COLUMN_TOKEN, "somenmbr",
	/// vtkSQLDatabaseSchema::END_INDEX_TOKEN,
	/// vtkSQLDatabaseSchema::TRIGGER_TOKEN,  vtkSQLDatabaseSchema::AFTER_INSERT,
	/// "InsertTrigger", "DO NOTHING", VTK_SQL_SQLITE,
	/// vtkSQLDatabaseSchema::TRIGGER_TOKEN,  vtkSQLDatabaseSchema::AFTER_INSERT,
	/// "InsertTrigger", "FOR EACH ROW EXECUTE PROCEDURE somefunction ()", VTK_SQL_POSTGRESQL,
	/// vtkSQLDatabaseSchema::TRIGGER_TOKEN,  vtkSQLDatabaseSchema::AFTER_INSERT,
	/// "InsertTrigger", "FOR EACH ROW INSERT INTO btable SET SomeValue = NEW.SomeNmbr", VTK_SQL_MYSQL,
	/// vtkSQLDatabaseSchema::END_TABLE_TOKEN
	/// );
	/// return 0;
	/// }
	/// </summary>
	public int AddTableMultipleArguments(string tblName)
	{
		return vtkSQLDatabaseSchema_AddTableMultipleArguments_11(GetCppThis(), tblName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddTriggerToTable_12(HandleRef pThis, int tblHandle, int trgType, string trgName, string trgAction, string trgBackend);

	/// <summary>
	/// Add a (possibly backend-specific) trigger action to a table.
	///
	/// Triggers must be given unique, non-nullptr names as some database backends require them.
	/// The returned value is a trigger handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddTriggerToTable(int tblHandle, int trgType, string trgName, string trgAction, string trgBackend)
	{
		return vtkSQLDatabaseSchema_AddTriggerToTable_12(GetCppThis(), tblHandle, trgType, trgName, trgAction, trgBackend);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_AddTriggerToTable_13(HandleRef pThis, string tblName, int trgType, string trgName, string trgAction, string trgBackend);

	/// <summary>
	/// Add a (possibly backend-specific) trigger action to a table.
	///
	/// Triggers must be given unique, non-nullptr names as some database backends require them.
	/// The returned value is a trigger handle or -1 if an error occurred.
	/// </summary>
	public virtual int AddTriggerToTable(string tblName, int trgType, string trgName, string trgAction, string trgBackend)
	{
		return vtkSQLDatabaseSchema_AddTriggerToTable_13(GetCppThis(), tblName, trgType, trgName, trgAction, trgBackend);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetColumnAttributesFromHandle_14(HandleRef pThis, int tblHandle, int colHandle);

	/// <summary>
	/// Given the handles of a table and a column, get the attributes of the column.
	/// </summary>
	public string GetColumnAttributesFromHandle(int tblHandle, int colHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetColumnAttributesFromHandle_14(GetCppThis(), tblHandle, colHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetColumnHandleFromName_15(HandleRef pThis, string tblName, string colName);

	/// <summary>
	/// Given the names of a table and a column, get the handle of the column in this table.
	/// </summary>
	public int GetColumnHandleFromName(string tblName, string colName)
	{
		return vtkSQLDatabaseSchema_GetColumnHandleFromName_15(GetCppThis(), tblName, colName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetColumnNameFromHandle_16(HandleRef pThis, int tblHandle, int colHandle);

	/// <summary>
	/// Given the handles of a table and a column, get the name of the column.
	/// </summary>
	public string GetColumnNameFromHandle(int tblHandle, int colHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetColumnNameFromHandle_16(GetCppThis(), tblHandle, colHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetColumnSizeFromHandle_17(HandleRef pThis, int tblHandle, int colHandle);

	/// <summary>
	/// Given the handles of a table and a column, get the size of the column.
	/// </summary>
	public int GetColumnSizeFromHandle(int tblHandle, int colHandle)
	{
		return vtkSQLDatabaseSchema_GetColumnSizeFromHandle_17(GetCppThis(), tblHandle, colHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetColumnTypeFromHandle_18(HandleRef pThis, int tblHandle, int colHandle);

	/// <summary>
	/// Given the handles of a table and a column, get the type of the column.
	/// </summary>
	public int GetColumnTypeFromHandle(int tblHandle, int colHandle)
	{
		return vtkSQLDatabaseSchema_GetColumnTypeFromHandle_18(GetCppThis(), tblHandle, colHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetIndexColumnNameFromHandle_19(HandleRef pThis, int tblHandle, int idxHandle, int cnmHandle);

	/// <summary>
	/// Given the handles of a table, an index, and a column name, get the column name.
	/// </summary>
	public string GetIndexColumnNameFromHandle(int tblHandle, int idxHandle, int cnmHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetIndexColumnNameFromHandle_19(GetCppThis(), tblHandle, idxHandle, cnmHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetIndexHandleFromName_20(HandleRef pThis, string tblName, string idxName);

	/// <summary>
	/// Given the names of a table and an index, get the handle of the index in this table.
	/// </summary>
	public int GetIndexHandleFromName(string tblName, string idxName)
	{
		return vtkSQLDatabaseSchema_GetIndexHandleFromName_20(GetCppThis(), tblName, idxName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetIndexNameFromHandle_21(HandleRef pThis, int tblHandle, int idxHandle);

	/// <summary>
	/// Given the handles of a table and an index, get the name of the index.
	/// </summary>
	public string GetIndexNameFromHandle(int tblHandle, int idxHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetIndexNameFromHandle_21(GetCppThis(), tblHandle, idxHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetIndexTypeFromHandle_22(HandleRef pThis, int tblHandle, int idxHandle);

	/// <summary>
	/// Given the handles of a table and an index, get the type of the index.
	/// </summary>
	public int GetIndexTypeFromHandle(int tblHandle, int idxHandle)
	{
		return vtkSQLDatabaseSchema_GetIndexTypeFromHandle_22(GetCppThis(), tblHandle, idxHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetName_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the schema.
	/// </summary>
	public virtual string GetName()
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetName_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetNumberOfColumnNamesInIndex_24(HandleRef pThis, int tblHandle, int idxHandle);

	/// <summary>
	/// Get the number of column names associated to a particular index in a particular table .
	/// </summary>
	public int GetNumberOfColumnNamesInIndex(int tblHandle, int idxHandle)
	{
		return vtkSQLDatabaseSchema_GetNumberOfColumnNamesInIndex_24(GetCppThis(), tblHandle, idxHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetNumberOfColumnsInTable_25(HandleRef pThis, int tblHandle);

	/// <summary>
	/// Get the number of columns in a particular table .
	/// </summary>
	public int GetNumberOfColumnsInTable(int tblHandle)
	{
		return vtkSQLDatabaseSchema_GetNumberOfColumnsInTable_25(GetCppThis(), tblHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLDatabaseSchema_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSQLDatabaseSchema_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLDatabaseSchema_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSQLDatabaseSchema_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetNumberOfIndicesInTable_28(HandleRef pThis, int tblHandle);

	/// <summary>
	/// Get the number of indices in a particular table .
	/// </summary>
	public int GetNumberOfIndicesInTable(int tblHandle)
	{
		return vtkSQLDatabaseSchema_GetNumberOfIndicesInTable_28(GetCppThis(), tblHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetNumberOfOptionsInTable_29(HandleRef pThis, int tblHandle);

	/// <summary>
	/// Get the number of options associated with a particular table.
	/// </summary>
	public int GetNumberOfOptionsInTable(int tblHandle)
	{
		return vtkSQLDatabaseSchema_GetNumberOfOptionsInTable_29(GetCppThis(), tblHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetNumberOfPreambles_30(HandleRef pThis);

	/// <summary>
	/// Get the number of preambles.
	/// </summary>
	public int GetNumberOfPreambles()
	{
		return vtkSQLDatabaseSchema_GetNumberOfPreambles_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetNumberOfTables_31(HandleRef pThis);

	/// <summary>
	/// Get the number of tables.
	/// </summary>
	public int GetNumberOfTables()
	{
		return vtkSQLDatabaseSchema_GetNumberOfTables_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetNumberOfTriggersInTable_32(HandleRef pThis, int tblHandle);

	/// <summary>
	/// Get the number of triggers defined for a particular table.
	/// </summary>
	public int GetNumberOfTriggersInTable(int tblHandle)
	{
		return vtkSQLDatabaseSchema_GetNumberOfTriggersInTable_32(GetCppThis(), tblHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetOptionBackendFromHandle_33(HandleRef pThis, int tblHandle, int optHandle);

	/// <summary>
	/// Given the handles of a table and one of its options, get the backend of the option.
	/// </summary>
	public string GetOptionBackendFromHandle(int tblHandle, int optHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetOptionBackendFromHandle_33(GetCppThis(), tblHandle, optHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetOptionTextFromHandle_34(HandleRef pThis, int tblHandle, int optHandle);

	/// <summary>
	/// Given the handles of a table and one of its options, return the text of the option.
	/// </summary>
	public string GetOptionTextFromHandle(int tblHandle, int optHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetOptionTextFromHandle_34(GetCppThis(), tblHandle, optHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleActionFromHandle_35(HandleRef pThis, int preHandle);

	/// <summary>
	/// Given a preamble handle, get its action.
	/// </summary>
	public string GetPreambleActionFromHandle(int preHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetPreambleActionFromHandle_35(GetCppThis(), preHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleBackendFromHandle_36(HandleRef pThis, int preHandle);

	/// <summary>
	/// Given a preamble handle, get its backend.
	/// </summary>
	public string GetPreambleBackendFromHandle(int preHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetPreambleBackendFromHandle_36(GetCppThis(), preHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetPreambleHandleFromName_37(HandleRef pThis, string preName);

	/// <summary>
	/// Given a preamble name, get its handle.
	/// </summary>
	public int GetPreambleHandleFromName(string preName)
	{
		return vtkSQLDatabaseSchema_GetPreambleHandleFromName_37(GetCppThis(), preName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleNameFromHandle_38(HandleRef pThis, int preHandle);

	/// <summary>
	/// Given a preamble handle, get its name.
	/// </summary>
	public string GetPreambleNameFromHandle(int preHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetPreambleNameFromHandle_38(GetCppThis(), preHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetTableHandleFromName_39(HandleRef pThis, string tblName);

	/// <summary>
	/// Given a table name, get its handle.
	/// </summary>
	public int GetTableHandleFromName(string tblName)
	{
		return vtkSQLDatabaseSchema_GetTableHandleFromName_39(GetCppThis(), tblName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetTableNameFromHandle_40(HandleRef pThis, int tblHandle);

	/// <summary>
	/// Given a table handle, get its name.
	/// </summary>
	public string GetTableNameFromHandle(int tblHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetTableNameFromHandle_40(GetCppThis(), tblHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerActionFromHandle_41(HandleRef pThis, int tblHandle, int trgHandle);

	/// <summary>
	/// Given the handles of a table and a trigger, get the action of the trigger.
	/// </summary>
	public string GetTriggerActionFromHandle(int tblHandle, int trgHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetTriggerActionFromHandle_41(GetCppThis(), tblHandle, trgHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerBackendFromHandle_42(HandleRef pThis, int tblHandle, int trgHandle);

	/// <summary>
	/// Given the handles of a table and a trigger, get the backend of the trigger.
	/// </summary>
	public string GetTriggerBackendFromHandle(int tblHandle, int trgHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetTriggerBackendFromHandle_42(GetCppThis(), tblHandle, trgHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetTriggerHandleFromName_43(HandleRef pThis, string tblName, string trgName);

	/// <summary>
	/// Given the names of a trigger and a table, get the handle of the trigger in this table.
	/// </summary>
	public int GetTriggerHandleFromName(string tblName, string trgName)
	{
		return vtkSQLDatabaseSchema_GetTriggerHandleFromName_43(GetCppThis(), tblName, trgName);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerNameFromHandle_44(HandleRef pThis, int tblHandle, int trgHandle);

	/// <summary>
	/// Given the handles of a table and a trigger, get the name of the trigger.
	/// </summary>
	public string GetTriggerNameFromHandle(int tblHandle, int trgHandle)
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema_GetTriggerNameFromHandle_44(GetCppThis(), tblHandle, trgHandle));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_GetTriggerTypeFromHandle_45(HandleRef pThis, int tblHandle, int trgHandle);

	/// <summary>
	/// Given the handles of a table and a trigger, get the type of the trigger.
	/// </summary>
	public int GetTriggerTypeFromHandle(int tblHandle, int trgHandle)
	{
		return vtkSQLDatabaseSchema_GetTriggerTypeFromHandle_45(GetCppThis(), tblHandle, trgHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_IsA_46(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSQLDatabaseSchema_IsA_46(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseSchema_IsTypeOf_47(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSQLDatabaseSchema_IsTypeOf_47(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSQLDatabaseSchema NewInstance()
	{
		vtkSQLDatabaseSchema result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabaseSchema_NewInstance_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabaseSchema_Reset_50(HandleRef pThis);

	/// <summary>
	/// Reset the schema to its initial, empty state.
	/// </summary>
	public void Reset()
	{
		vtkSQLDatabaseSchema_Reset_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseSchema_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLDatabaseSchema SafeDownCast(vtkObjectBase o)
	{
		vtkSQLDatabaseSchema vtkSQLDatabaseSchema2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabaseSchema_SafeDownCast_51(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSQLDatabaseSchema2 = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSQLDatabaseSchema2.Register(null);
			}
		}
		return vtkSQLDatabaseSchema2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabaseSchema_SetName_52(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the schema.
	/// </summary>
	public virtual void SetName(string _arg)
	{
		vtkSQLDatabaseSchema_SetName_52(GetCppThis(), _arg);
	}
}
