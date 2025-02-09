using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSQLDatabase
/// </summary>
/// <remarks>
///    maintain a connection to an sql database
///
///
/// Abstract base class for all SQL database connection classes.
/// Manages a connection to the database, and is responsible for creating
/// instances of the associated vtkSQLQuery objects associated with this
/// class in order to perform execute queries on the database.
/// To allow connections to a new type of database, create both a subclass
/// of this class and vtkSQLQuery, and implement the required functions:
///
/// Open() - open the database connection, if possible.
/// Close() - close the connection.
/// GetQueryInstance() - create and return an instance of the vtkSQLQuery
///                      subclass associated with the database type.
///
/// The subclass should also provide API to set connection parameters.
///
/// This class also provides the function EffectSchema to transform a
/// database schema into a SQL database.
///
/// @par Thanks:
/// Thanks to Andrew Wilson from Sandia National Laboratories for his work
/// on the database classes and for the SQLite example. Thanks to David Thompson
/// and Philippe Pebay from Sandia National Laboratories for implementing
/// this class.
///
/// </remarks>
/// <seealso>
///
/// vtkSQLQuery
/// vtkSQLDatabaseSchema
/// </seealso>
public abstract class vtkSQLDatabase : vtkObject
{
	/// <summary>
	/// Type for CreateFromURL callback.
	/// </summary>
	public delegate IntPtr CreateFunction(string arg0);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSQLDatabase()
	{
		MRClassNameKey = "class vtkSQLDatabase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSQLDatabase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkSQLDatabase_Close_01(HandleRef pThis);

	/// <summary>
	/// Close the connection to the database.
	/// </summary>
	public virtual void Close()
	{
		vtkSQLDatabase_Close_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabase_CreateFromURL_02(string URL, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a the proper subclass given a URL.
	/// The URL format for SQL databases is a true URL of the form:
	/// 'protocol://'[[username[':'password]'@']hostname[':'port]]'/'[dbname] .
	/// </summary>
	public static vtkSQLDatabase CreateFromURL(string URL)
	{
		vtkSQLDatabase vtkSQLDatabase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabase_CreateFromURL_02(URL, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSQLDatabase_DATABASE_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Stores the database class pointer as an information key. This is currently
	/// used to store database pointers as part of 'data on demand' data objects.
	/// For example: The application may have a table/tree/whatever of documents,
	/// the data structure is storing the meta-data but not the full text. Further
	/// down the pipeline algorithms or views may want to retrieve additional
	/// information (full text)for specific documents.
	/// </summary>
	public static vtkInformationObjectBaseKey DATABASE()
	{
		vtkInformationObjectBaseKey vtkInformationObjectBaseKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabase_DATABASE_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseKey2 = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseKey2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLDatabase_EffectSchema_04(HandleRef pThis, HandleRef arg0, byte dropIfExists);

	/// <summary>
	/// Effect a database schema.
	/// </summary>
	public virtual bool EffectSchema(vtkSQLDatabaseSchema arg0, bool dropIfExists)
	{
		return (vtkSQLDatabase_EffectSchema_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), (byte)(dropIfExists ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLDatabase_GetColumnSpecification_05(HandleRef pThis, HandleRef schema, int tblHandle, int colHandle);

	/// <summary>
	/// Return the SQL string with the syntax to create a column inside a
	/// "CREATE TABLE" SQL statement.
	/// NB: this method implements the following minimally-portable syntax:
	/// <code>
	/// &lt;column name&gt; &lt;column type&gt; &lt;column attributes&gt;
	/// </code>
	/// It must be overwritten for those SQL backends which have a different
	/// syntax such as, e.g., MySQL.
	/// </summary>
	public virtual string GetColumnSpecification(vtkSQLDatabaseSchema schema, int tblHandle, int colHandle)
	{
		return vtkSQLDatabase_GetColumnSpecification_05(GetCppThis(), schema?.GetCppThis() ?? default(HandleRef), tblHandle, colHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabase_GetDatabaseType_06(HandleRef pThis);

	/// <summary>
	/// Get the type of the database (e.g. mysql, psql,..).
	/// </summary>
	public virtual string GetDatabaseType()
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabase_GetDatabaseType_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLDatabase_GetIndexSpecification_07(HandleRef pThis, HandleRef schema, int tblHandle, int idxHandle, ref byte skipped);

	/// <summary>
	/// Return the SQL string with the syntax to create an index inside a
	/// "CREATE TABLE" SQL statement.
	/// NB1: this method implements the following minimally-portable syntax:
	/// <code>
	/// &lt;index type&gt; [&lt;index name&gt;] (&lt;column name 1&gt;,... )
	/// </code>
	/// It must be overwritten for those SQL backends which have a different
	/// syntax such as, e.g., MySQL.
	/// NB2: this method does not assume that INDEX creation is supported
	/// within a CREATE TABLE statement. Therefore, should such an INDEX arise
	/// in the schema, a CREATE INDEX statement is returned and skipped is
	/// set to true. Otherwise, skipped will always be returned false.
	/// </summary>
	public virtual string GetIndexSpecification(vtkSQLDatabaseSchema schema, int tblHandle, int idxHandle, ref byte skipped)
	{
		return vtkSQLDatabase_GetIndexSpecification_07(GetCppThis(), schema?.GetCppThis() ?? default(HandleRef), tblHandle, idxHandle, ref skipped);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabase_GetLastErrorText_08(HandleRef pThis);

	/// <summary>
	/// Get the last error text from the database
	/// I'm using const so that people do NOT
	/// use the standard vtkGetStringMacro in their
	/// implementation, because 99% of the time that
	/// will not be the correct thing to do...
	/// </summary>
	public virtual string GetLastErrorText()
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabase_GetLastErrorText_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLDatabase_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSQLDatabase_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLDatabase_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSQLDatabase_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabase_GetQueryInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an empty query on this database.
	/// </summary>
	public virtual vtkSQLQuery GetQueryInstance()
	{
		vtkSQLQuery vtkSQLQuery2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabase_GetQueryInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSQLDatabase_GetRecord_12(HandleRef pThis, string table, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the list of fields for a particular table.
	/// </summary>
	public virtual vtkStringArray GetRecord(string table)
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabase_GetRecord_12(GetCppThis(), table, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLDatabase_GetTablePreamble_13(HandleRef pThis, byte arg0);

	/// <summary>
	/// Return the SQL string with the syntax of the preamble following a
	/// "CREATE TABLE" SQL statement.
	/// NB: by default, this method returns an empty string.
	/// It must be overwritten for those SQL backends which allow such
	/// preambles such as, e.g., MySQL.
	/// </summary>
	public virtual string GetTablePreamble(bool arg0)
	{
		return vtkSQLDatabase_GetTablePreamble_13(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabase_GetTables_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the list of tables from the database.
	/// </summary>
	public virtual vtkStringArray GetTables()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabase_GetTables_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLDatabase_GetTriggerSpecification_15(HandleRef pThis, HandleRef schema, int tblHandle, int trgHandle);

	/// <summary>
	/// Return the SQL string with the syntax to create a trigger using a
	/// "CREATE TRIGGER" SQL statement.
	/// NB1: support is contingent on VTK_FEATURE_TRIGGERS being recognized as
	/// a supported feature. Not all backends (e.g., SQLite) support it.
	/// NB2: this method implements the following minimally-portable syntax:
	/// <code>
	/// &lt;trigger name&gt; {BEFORE | AFTER} &lt;event&gt; ON &lt;table name&gt; FOR EACH ROW &lt;trigger action&gt;
	/// </code>
	/// It must be overwritten for those SQL backends which have a different
	/// syntax such as, e.g., PostgreSQL.
	/// </summary>
	public virtual string GetTriggerSpecification(vtkSQLDatabaseSchema schema, int tblHandle, int trgHandle)
	{
		return vtkSQLDatabase_GetTriggerSpecification_15(GetCppThis(), schema?.GetCppThis() ?? default(HandleRef), tblHandle, trgHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLDatabase_GetURL_16(HandleRef pThis);

	/// <summary>
	/// Get the URL of the database.
	/// </summary>
	public virtual string GetURL()
	{
		return vtkSQLDatabase_GetURL_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLDatabase_HasError_17(HandleRef pThis);

	/// <summary>
	/// Did the last operation generate an error
	/// </summary>
	public virtual bool HasError()
	{
		return (vtkSQLDatabase_HasError_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabase_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSQLDatabase_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLDatabase_IsOpen_19(HandleRef pThis);

	/// <summary>
	/// Return whether the database has an open connection.
	/// </summary>
	public virtual bool IsOpen()
	{
		return (vtkSQLDatabase_IsOpen_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLDatabase_IsSupported_20(HandleRef pThis, int arg0);

	/// <summary>
	/// Return whether a feature is supported by the database.
	/// </summary>
	public virtual bool IsSupported(int arg0)
	{
		return (vtkSQLDatabase_IsSupported_20(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabase_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSQLDatabase_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabase_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSQLDatabase NewInstance()
	{
		vtkSQLDatabase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabase_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLDatabase_Open_23(HandleRef pThis, string password);

	/// <summary>
	/// Open a new connection to the database.
	/// You need to set up any database parameters before calling this function.
	/// For database connections that do not require a password, pass an empty string.
	/// Returns true is the database was opened successfully, and false otherwise.
	/// </summary>
	public virtual bool Open(string password)
	{
		return (vtkSQLDatabase_Open_23(GetCppThis(), password) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabase_RegisterCreateFromURLCallback_24(CreateFunction callback);

	/// <summary>
	/// Provides mechanism to register/unregister additional callbacks to create
	/// concrete subclasses of vtkSQLDatabase to handle different protocols.
	/// The registered callbacks are tried in the order they are registered.
	/// </summary>
	public static void RegisterCreateFromURLCallback(CreateFunction callback)
	{
		vtkSQLDatabase_RegisterCreateFromURLCallback_24(callback);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabase_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLDatabase SafeDownCast(vtkObjectBase o)
	{
		vtkSQLDatabase vtkSQLDatabase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabase_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSQLDatabase_UnRegisterAllCreateFromURLCallbacks_26();

	/// <summary>
	/// Provides mechanism to register/unregister additional callbacks to create
	/// concrete subclasses of vtkSQLDatabase to handle different protocols.
	/// The registered callbacks are tried in the order they are registered.
	/// </summary>
	public static void UnRegisterAllCreateFromURLCallbacks()
	{
		vtkSQLDatabase_UnRegisterAllCreateFromURLCallbacks_26();
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabase_UnRegisterCreateFromURLCallback_27(CreateFunction callback);

	/// <summary>
	/// Provides mechanism to register/unregister additional callbacks to create
	/// concrete subclasses of vtkSQLDatabase to handle different protocols.
	/// The registered callbacks are tried in the order they are registered.
	/// </summary>
	public static void UnRegisterCreateFromURLCallback(CreateFunction callback)
	{
		vtkSQLDatabase_UnRegisterCreateFromURLCallback_27(callback);
	}
}
