using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDatabaseToTableReader
/// </summary>
/// <remarks>
///    Read an SQL table as a vtkTable
///
/// vtkDatabaseToTableReader reads a table from an SQL database, outputting
/// it as a vtkTable.
/// </remarks>
public abstract class vtkDatabaseToTableReader : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDatabaseToTableReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDatabaseToTableReader()
	{
		MRClassNameKey = "class vtkDatabaseToTableReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDatabaseToTableReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDatabaseToTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern byte vtkDatabaseToTableReader_CheckIfTableExists_01(HandleRef pThis);

	/// <summary>
	/// Check if the currently specified table name exists in the database.
	/// </summary>
	public bool CheckIfTableExists()
	{
		return (vtkDatabaseToTableReader_CheckIfTableExists_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDatabaseToTableReader_GetDatabase_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Check if the currently specified table name exists in the database.
	/// </summary>
	public vtkSQLDatabase GetDatabase()
	{
		vtkSQLDatabase vtkSQLDatabase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDatabaseToTableReader_GetDatabase_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDatabaseToTableReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDatabaseToTableReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDatabaseToTableReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDatabaseToTableReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDatabaseToTableReader_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDatabaseToTableReader_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDatabaseToTableReader_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDatabaseToTableReader_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDatabaseToTableReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDatabaseToTableReader NewInstance()
	{
		vtkDatabaseToTableReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDatabaseToTableReader_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDatabaseToTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDatabaseToTableReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDatabaseToTableReader SafeDownCast(vtkObjectBase o)
	{
		vtkDatabaseToTableReader vtkDatabaseToTableReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDatabaseToTableReader_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDatabaseToTableReader2 = (vtkDatabaseToTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDatabaseToTableReader2.Register(null);
			}
		}
		return vtkDatabaseToTableReader2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDatabaseToTableReader_SetDatabase_09(HandleRef pThis, HandleRef db);

	/// <summary>
	/// Set the database associated with this reader
	/// </summary>
	public bool SetDatabase(vtkSQLDatabase db)
	{
		return (vtkDatabaseToTableReader_SetDatabase_09(GetCppThis(), db?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDatabaseToTableReader_SetTableName_10(HandleRef pThis, string name);

	/// <summary>
	/// Set the name of the table that you'd like to convert to a vtkTable
	/// Returns false if the specified table does not exist in the database.
	/// </summary>
	public bool SetTableName(string name)
	{
		return (vtkDatabaseToTableReader_SetTableName_10(GetCppThis(), name) != 0) ? true : false;
	}
}
