using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSQLiteDatabase
/// </summary>
/// <remarks>
///    maintain a connection to an SQLite database
///
///
///
/// SQLite (http://www.sqlite.org) is a public-domain SQL database
/// written in C++.  It's small, fast, and can be easily embedded
/// inside other applications.  Its databases are stored in files.
///
/// This class provides a VTK interface to SQLite.  You do not need to
/// download any external libraries: we include a copy of SQLite 3.3.16
/// in VTK/Utilities/vtksqlite.
///
/// If you want to open a database that stays in memory and never gets
/// written to disk, pass in the URL &lt;tt&gt;sqlite://:memory:&lt;/tt&gt;; otherwise,
/// specify the file path by passing the URL &lt;tt&gt;sqlite://\&lt;file_path\&gt;&lt;/tt&gt;.
///
/// @par Thanks:
/// Thanks to Andrew Wilson and Philippe Pebay from Sandia National
/// Laboratories for implementing this class.
///
/// </remarks>
/// <seealso>
///
/// vtkSQLiteQuery
/// </seealso>
public class vtkSQLiteDatabase : vtkSQLDatabase
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum CREATE_WrapperEnum
	{
		/// <summary>enum member</summary>
		CREATE = 3,
		/// <summary>enum member</summary>
		CREATE_OR_CLEAR = 2,
		/// <summary>enum member</summary>
		USE_EXISTING = 0,
		/// <summary>enum member</summary>
		USE_EXISTING_OR_CREATE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSQLiteDatabase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSQLiteDatabase()
	{
		MRClassNameKey = "class vtkSQLiteDatabase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLiteDatabase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSQLiteDatabase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteDatabase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLiteDatabase New()
	{
		vtkSQLiteDatabase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteDatabase_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSQLiteDatabase()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSQLiteDatabase_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSQLiteDatabase_Close_01(HandleRef pThis);

	/// <summary>
	/// Close the connection to the database.
	/// </summary>
	public override void Close()
	{
		vtkSQLiteDatabase_Close_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLiteDatabase_GetColumnSpecification_02(HandleRef pThis, HandleRef schema, int tblHandle, int colHandle);

	/// <summary>
	/// Return the SQL string with the syntax to create a column inside a
	/// "CREATE TABLE" SQL statement.
	/// NB: this method implements the SQLite-specific syntax:
	/// <code>
	/// &lt;column name&gt; &lt;column type&gt; &lt;column attributes&gt;
	/// </code>
	/// </summary>
	public override string GetColumnSpecification(vtkSQLDatabaseSchema schema, int tblHandle, int colHandle)
	{
		return vtkSQLiteDatabase_GetColumnSpecification_02(GetCppThis(), schema?.GetCppThis() ?? default(HandleRef), tblHandle, colHandle);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteDatabase_GetDatabaseFileName_03(HandleRef pThis);

	/// <summary>
	/// String representing the database filename.
	/// </summary>
	public virtual string GetDatabaseFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSQLiteDatabase_GetDatabaseFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteDatabase_GetDatabaseType_04(HandleRef pThis);

	/// <summary>
	/// String representing database type (e.g. "sqlite").
	/// </summary>
	public override string GetDatabaseType()
	{
		return Marshal.PtrToStringAnsi(vtkSQLiteDatabase_GetDatabaseType_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteDatabase_GetLastErrorText_05(HandleRef pThis);

	/// <summary>
	/// Get the last error text from the database
	/// </summary>
	public override string GetLastErrorText()
	{
		return Marshal.PtrToStringAnsi(vtkSQLiteDatabase_GetLastErrorText_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLiteDatabase_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSQLiteDatabase_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLiteDatabase_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSQLiteDatabase_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteDatabase_GetQueryInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an empty query on this database.
	/// </summary>
	public override vtkSQLQuery GetQueryInstance()
	{
		vtkSQLQuery vtkSQLQuery2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteDatabase_GetQueryInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSQLiteDatabase_GetRecord_09(HandleRef pThis, string table, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the list of fields for a particular table
	/// </summary>
	public override vtkStringArray GetRecord(string table)
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteDatabase_GetRecord_09(GetCppThis(), table, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSQLiteDatabase_GetTables_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the list of tables from the database
	/// </summary>
	public override vtkStringArray GetTables()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteDatabase_GetTables_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern string vtkSQLiteDatabase_GetURL_11(HandleRef pThis);

	/// <summary>
	/// Get the URL of the database.
	/// </summary>
	public override string GetURL()
	{
		return vtkSQLiteDatabase_GetURL_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteDatabase_HasError_12(HandleRef pThis);

	/// <summary>
	/// Did the last operation generate an error
	/// </summary>
	public override bool HasError()
	{
		return (vtkSQLiteDatabase_HasError_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLiteDatabase_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSQLiteDatabase_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteDatabase_IsOpen_14(HandleRef pThis);

	/// <summary>
	/// Return whether the database has an open connection
	/// </summary>
	public override bool IsOpen()
	{
		return (vtkSQLiteDatabase_IsOpen_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteDatabase_IsSupported_15(HandleRef pThis, int feature);

	/// <summary>
	/// Return whether a feature is supported by the database.
	/// </summary>
	public override bool IsSupported(int feature)
	{
		return (vtkSQLiteDatabase_IsSupported_15(GetCppThis(), feature) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLiteDatabase_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSQLiteDatabase_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteDatabase_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSQLiteDatabase NewInstance()
	{
		vtkSQLiteDatabase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteDatabase_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteDatabase_Open_19(HandleRef pThis, string password);

	/// <summary>
	/// Open a new connection to the database.  You need to set the
	/// filename before calling this function.  Returns true if the
	/// database was opened successfully; false otherwise.
	/// - USE_EXISTING (default) - Fail if the file does not exist.
	/// - USE_EXISTING_OR_CREATE - Create a new file if necessary.
	/// - CREATE_OR_CLEAR - Create new or clear existing file.
	/// - CREATE - Create new, fail if file exists.
	/// </summary>
	public override bool Open(string password)
	{
		return (vtkSQLiteDatabase_Open_19(GetCppThis(), password) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLiteDatabase_Open_20(HandleRef pThis, string password, int mode);

	/// <summary>
	/// Open a new connection to the database.  You need to set the
	/// filename before calling this function.  Returns true if the
	/// database was opened successfully; false otherwise.
	/// - USE_EXISTING (default) - Fail if the file does not exist.
	/// - USE_EXISTING_OR_CREATE - Create a new file if necessary.
	/// - CREATE_OR_CLEAR - Create new or clear existing file.
	/// - CREATE - Create new, fail if file exists.
	/// </summary>
	public bool Open(string password, int mode)
	{
		return (vtkSQLiteDatabase_Open_20(GetCppThis(), password, mode) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLiteDatabase_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLiteDatabase SafeDownCast(vtkObjectBase o)
	{
		vtkSQLiteDatabase vtkSQLiteDatabase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLiteDatabase_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSQLiteDatabase2 = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSQLiteDatabase2.Register(null);
			}
		}
		return vtkSQLiteDatabase2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLiteDatabase_SetDatabaseFileName_22(HandleRef pThis, string _arg);

	/// <summary>
	/// String representing the database filename.
	/// </summary>
	public virtual void SetDatabaseFileName(string _arg)
	{
		vtkSQLiteDatabase_SetDatabaseFileName_22(GetCppThis(), _arg);
	}
}
