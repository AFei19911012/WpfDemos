using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSQLDatabaseTableSource
/// </summary>
/// <remarks>
///    Generates a vtkTable based on an SQL query.
///
///
/// This class combines vtkSQLDatabase, vtkSQLQuery, and vtkQueryToTable to
/// provide a convenience class for generating tables from databases.
/// Also this class can be easily wrapped and used within ParaView / OverView.
/// </remarks>
public class vtkSQLDatabaseTableSource : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabaseTableSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSQLDatabaseTableSource()
	{
		MRClassNameKey = "class vtkSQLDatabaseTableSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabaseTableSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSQLDatabaseTableSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseTableSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLDatabaseTableSource New()
	{
		vtkSQLDatabaseTableSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabaseTableSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSQLDatabaseTableSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSQLDatabaseTableSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSQLDatabaseTableSource_GeneratePedigreeIdsOff_01(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void GeneratePedigreeIdsOff()
	{
		vtkSQLDatabaseTableSource_GeneratePedigreeIdsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabaseTableSource_GeneratePedigreeIdsOn_02(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void GeneratePedigreeIdsOn()
	{
		vtkSQLDatabaseTableSource_GeneratePedigreeIdsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSQLDatabaseTableSource_GetGeneratePedigreeIds_03(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual bool GetGeneratePedigreeIds()
	{
		return (vtkSQLDatabaseTableSource_GetGeneratePedigreeIds_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLDatabaseTableSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSQLDatabaseTableSource_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSQLDatabaseTableSource_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSQLDatabaseTableSource_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseTableSource_GetPedigreeIdArrayName_06(HandleRef pThis);

	/// <summary>
	/// The name of the array for generating or assigning pedigree ids
	/// (default "id").
	/// </summary>
	public virtual string GetPedigreeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkSQLDatabaseTableSource_GetPedigreeIdArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLDatabaseTableSource_GetQuery_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetQuery()
	{
		return vtkSQLDatabaseTableSource_GetQuery_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkSQLDatabaseTableSource_GetURL_08(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetURL()
	{
		return vtkSQLDatabaseTableSource_GetURL_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseTableSource_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSQLDatabaseTableSource_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSQLDatabaseTableSource_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSQLDatabaseTableSource_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseTableSource_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSQLDatabaseTableSource NewInstance()
	{
		vtkSQLDatabaseTableSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabaseTableSource_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSQLDatabaseTableSource_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSQLDatabaseTableSource SafeDownCast(vtkObjectBase o)
	{
		vtkSQLDatabaseTableSource vtkSQLDatabaseTableSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSQLDatabaseTableSource_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSQLDatabaseTableSource2 = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSQLDatabaseTableSource2.Register(null);
			}
		}
		return vtkSQLDatabaseTableSource2;
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabaseTableSource_SetGeneratePedigreeIds_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void SetGeneratePedigreeIds(bool _arg)
	{
		vtkSQLDatabaseTableSource_SetGeneratePedigreeIds_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabaseTableSource_SetPassword_15(HandleRef pThis, string password);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetPassword(string password)
	{
		vtkSQLDatabaseTableSource_SetPassword_15(GetCppThis(), password);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabaseTableSource_SetPedigreeIdArrayName_16(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the array for generating or assigning pedigree ids
	/// (default "id").
	/// </summary>
	public virtual void SetPedigreeIdArrayName(string _arg)
	{
		vtkSQLDatabaseTableSource_SetPedigreeIdArrayName_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabaseTableSource_SetQuery_17(HandleRef pThis, string query);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetQuery(string query)
	{
		vtkSQLDatabaseTableSource_SetQuery_17(GetCppThis(), query);
	}

	[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSQLDatabaseTableSource_SetURL_18(HandleRef pThis, string url);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetURL(string url)
	{
		vtkSQLDatabaseTableSource_SetURL_18(GetCppThis(), url);
	}
}
