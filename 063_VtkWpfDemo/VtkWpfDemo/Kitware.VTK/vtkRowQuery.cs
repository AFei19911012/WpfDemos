using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRowQuery
/// </summary>
/// <remarks>
///    abstract interface for queries that return
/// row-oriented results.
///
///
/// The abstract superclass of query classes that return row-oriented (table)
/// results.  A subclass will provide database-specific query parameters and
/// implement the vtkRowQuery API to return query results:
///
/// Execute() - Execute the query.  No results need to be retrieved at this
///             point, unless you are performing caching.
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
/// @par Thanks:
/// Thanks to Andrew Wilson from Sandia National Laboratories for his work
/// on the database classes.
///
/// </remarks>
/// <seealso>
///
/// vtkRowQueryToTable
/// </seealso>
public abstract class vtkRowQuery : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRowQuery";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRowQuery()
	{
		MRClassNameKey = "class vtkRowQuery";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRowQuery"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRowQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkRowQuery_CaseSensitiveFieldNamesOff_01(HandleRef pThis);

	/// <summary>
	/// Many databases do not preserve case in field names.  This can
	/// cause GetFieldIndex to fail if you search for a field named
	/// someFieldName when the database actually stores it as
	/// SOMEFIELDNAME.  This ivar controls whether GetFieldIndex()
	/// expects field names to be case-sensitive.  The default is OFF,
	/// i.e. case is not preserved.
	/// </summary>
	public virtual void CaseSensitiveFieldNamesOff()
	{
		vtkRowQuery_CaseSensitiveFieldNamesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRowQuery_CaseSensitiveFieldNamesOn_02(HandleRef pThis);

	/// <summary>
	/// Many databases do not preserve case in field names.  This can
	/// cause GetFieldIndex to fail if you search for a field named
	/// someFieldName when the database actually stores it as
	/// SOMEFIELDNAME.  This ivar controls whether GetFieldIndex()
	/// expects field names to be case-sensitive.  The default is OFF,
	/// i.e. case is not preserved.
	/// </summary>
	public virtual void CaseSensitiveFieldNamesOn()
	{
		vtkRowQuery_CaseSensitiveFieldNamesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRowQuery_DataValue_03(HandleRef pThis, long c, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return data in current row, field c
	/// </summary>
	public virtual vtkVariant DataValue(long c)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRowQuery_DataValue_03(GetCppThis(), c, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRowQuery_Execute_04(HandleRef pThis);

	/// <summary>
	/// Execute the query.  This must be performed
	/// before any field name or data access functions
	/// are used.
	/// </summary>
	public virtual bool Execute()
	{
		return (vtkRowQuery_Execute_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRowQuery_GetCaseSensitiveFieldNames_05(HandleRef pThis);

	/// <summary>
	/// Many databases do not preserve case in field names.  This can
	/// cause GetFieldIndex to fail if you search for a field named
	/// someFieldName when the database actually stores it as
	/// SOMEFIELDNAME.  This ivar controls whether GetFieldIndex()
	/// expects field names to be case-sensitive.  The default is OFF,
	/// i.e. case is not preserved.
	/// </summary>
	public virtual bool GetCaseSensitiveFieldNames()
	{
		return (vtkRowQuery_GetCaseSensitiveFieldNames_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRowQuery_GetFieldIndex_06(HandleRef pThis, string name);

	/// <summary>
	/// Return the index of the specified query field.
	/// Uses GetNumberOfFields() and GetFieldName()
	/// to match field name.
	/// </summary>
	public int GetFieldIndex(string name)
	{
		return vtkRowQuery_GetFieldIndex_06(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRowQuery_GetFieldName_07(HandleRef pThis, int i);

	/// <summary>
	/// Return the name of the specified query field.
	/// </summary>
	public virtual string GetFieldName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkRowQuery_GetFieldName_07(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRowQuery_GetFieldType_08(HandleRef pThis, int i);

	/// <summary>
	/// Return the type of the field, using the constants defined in vtkType.h.
	/// </summary>
	public virtual int GetFieldType(int i)
	{
		return vtkRowQuery_GetFieldType_08(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRowQuery_GetLastErrorText_09(HandleRef pThis);

	/// <summary>
	/// Get the last error text from the query
	/// </summary>
	public virtual string GetLastErrorText()
	{
		return Marshal.PtrToStringAnsi(vtkRowQuery_GetLastErrorText_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRowQuery_GetNumberOfFields_10(HandleRef pThis);

	/// <summary>
	/// The number of fields in the query result.
	/// </summary>
	public virtual int GetNumberOfFields()
	{
		return vtkRowQuery_GetNumberOfFields_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRowQuery_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRowQuery_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRowQuery_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRowQuery_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRowQuery_HasError_13(HandleRef pThis);

	/// <summary>
	/// Returns true if an error is set, otherwise false.
	/// </summary>
	public virtual bool HasError()
	{
		return (vtkRowQuery_HasError_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRowQuery_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRowQuery_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRowQuery_IsActive_15(HandleRef pThis);

	/// <summary>
	/// Return true if the query is active (i.e. execution was successful
	/// and results are ready to be fetched).  Returns false on error or
	/// inactive query.
	/// </summary>
	public virtual bool IsActive()
	{
		return (vtkRowQuery_IsActive_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRowQuery_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRowQuery_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRowQuery_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRowQuery NewInstance()
	{
		vtkRowQuery result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRowQuery_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRowQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRowQuery_NextRow_18(HandleRef pThis);

	/// <summary>
	/// Advance row, return false if past end.
	/// </summary>
	public virtual bool NextRow()
	{
		return (vtkRowQuery_NextRow_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRowQuery_NextRow_19(HandleRef pThis, HandleRef rowArray);

	/// <summary>
	/// Advance row, return false if past end.
	/// Also, fill array with row values.
	/// </summary>
	public bool NextRow(vtkVariantArray rowArray)
	{
		return (vtkRowQuery_NextRow_19(GetCppThis(), rowArray?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRowQuery_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRowQuery SafeDownCast(vtkObjectBase o)
	{
		vtkRowQuery vtkRowQuery2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRowQuery_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRowQuery2 = (vtkRowQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRowQuery2.Register(null);
			}
		}
		return vtkRowQuery2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRowQuery_SetCaseSensitiveFieldNames_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Many databases do not preserve case in field names.  This can
	/// cause GetFieldIndex to fail if you search for a field named
	/// someFieldName when the database actually stores it as
	/// SOMEFIELDNAME.  This ivar controls whether GetFieldIndex()
	/// expects field names to be case-sensitive.  The default is OFF,
	/// i.e. case is not preserved.
	/// </summary>
	public virtual void SetCaseSensitiveFieldNames(bool _arg)
	{
		vtkRowQuery_SetCaseSensitiveFieldNames_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
