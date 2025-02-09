using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMergeTables
/// </summary>
/// <remarks>
///    combine two tables
///
///
/// Combines the columns of two tables into one larger table.
/// The number of rows in the resulting table is the sum of the number of
/// rows in each of the input tables.
/// The number of columns in the output is generally the sum of the number
/// of columns in each input table, except in the case where column names
/// are duplicated in both tables.
/// In this case, if MergeColumnsByName is on (the default), the two columns
/// will be merged into a single column of the same name.
/// If MergeColumnsByName is off, both columns will exist in the output.
/// You may set the FirstTablePrefix and SecondTablePrefix to define how
/// the columns named are modified.  One of these prefixes may be the empty
/// string, but they must be different.
/// </remarks>
public class vtkMergeTables : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMergeTables";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMergeTables()
	{
		MRClassNameKey = "class vtkMergeTables";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeTables"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMergeTables(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeTables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeTables New()
	{
		vtkMergeTables result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeTables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMergeTables()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMergeTables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeTables_GetFirstTablePrefix_01(HandleRef pThis);

	/// <summary>
	/// The prefix to give to same-named fields from the first table.
	/// Default is "Table1.".
	/// </summary>
	public virtual string GetFirstTablePrefix()
	{
		return Marshal.PtrToStringAnsi(vtkMergeTables_GetFirstTablePrefix_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMergeTables_GetMergeColumnsByName_02(HandleRef pThis);

	/// <summary>
	/// If on, merges columns with the same name.
	/// If off, keeps both columns, but calls one
	/// FirstTablePrefix + name, and the other SecondTablePrefix + name.
	/// Default is on.
	/// </summary>
	public virtual bool GetMergeColumnsByName()
	{
		return (vtkMergeTables_GetMergeColumnsByName_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeTables_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMergeTables_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeTables_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMergeTables_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMergeTables_GetPrefixAllButMerged_05(HandleRef pThis);

	/// <summary>
	/// If on, all columns will have prefixes except merged columns.
	/// If off, only unmerged columns with the same name will have prefixes.
	/// Default is off.
	/// </summary>
	public virtual bool GetPrefixAllButMerged()
	{
		return (vtkMergeTables_GetPrefixAllButMerged_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeTables_GetSecondTablePrefix_06(HandleRef pThis);

	/// <summary>
	/// The prefix to give to same-named fields from the second table.
	/// Default is "Table2.".
	/// </summary>
	public virtual string GetSecondTablePrefix()
	{
		return Marshal.PtrToStringAnsi(vtkMergeTables_GetSecondTablePrefix_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeTables_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMergeTables_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeTables_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMergeTables_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTables_MergeColumnsByNameOff_09(HandleRef pThis);

	/// <summary>
	/// If on, merges columns with the same name.
	/// If off, keeps both columns, but calls one
	/// FirstTablePrefix + name, and the other SecondTablePrefix + name.
	/// Default is on.
	/// </summary>
	public virtual void MergeColumnsByNameOff()
	{
		vtkMergeTables_MergeColumnsByNameOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTables_MergeColumnsByNameOn_10(HandleRef pThis);

	/// <summary>
	/// If on, merges columns with the same name.
	/// If off, keeps both columns, but calls one
	/// FirstTablePrefix + name, and the other SecondTablePrefix + name.
	/// Default is on.
	/// </summary>
	public virtual void MergeColumnsByNameOn()
	{
		vtkMergeTables_MergeColumnsByNameOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeTables_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMergeTables NewInstance()
	{
		vtkMergeTables result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeTables_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTables_PrefixAllButMergedOff_13(HandleRef pThis);

	/// <summary>
	/// If on, all columns will have prefixes except merged columns.
	/// If off, only unmerged columns with the same name will have prefixes.
	/// Default is off.
	/// </summary>
	public virtual void PrefixAllButMergedOff()
	{
		vtkMergeTables_PrefixAllButMergedOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTables_PrefixAllButMergedOn_14(HandleRef pThis);

	/// <summary>
	/// If on, all columns will have prefixes except merged columns.
	/// If off, only unmerged columns with the same name will have prefixes.
	/// Default is off.
	/// </summary>
	public virtual void PrefixAllButMergedOn()
	{
		vtkMergeTables_PrefixAllButMergedOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeTables_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeTables SafeDownCast(vtkObjectBase o)
	{
		vtkMergeTables vtkMergeTables2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeTables_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMergeTables2 = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMergeTables2.Register(null);
			}
		}
		return vtkMergeTables2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTables_SetFirstTablePrefix_16(HandleRef pThis, string _arg);

	/// <summary>
	/// The prefix to give to same-named fields from the first table.
	/// Default is "Table1.".
	/// </summary>
	public virtual void SetFirstTablePrefix(string _arg)
	{
		vtkMergeTables_SetFirstTablePrefix_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTables_SetMergeColumnsByName_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, merges columns with the same name.
	/// If off, keeps both columns, but calls one
	/// FirstTablePrefix + name, and the other SecondTablePrefix + name.
	/// Default is on.
	/// </summary>
	public virtual void SetMergeColumnsByName(bool _arg)
	{
		vtkMergeTables_SetMergeColumnsByName_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTables_SetPrefixAllButMerged_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, all columns will have prefixes except merged columns.
	/// If off, only unmerged columns with the same name will have prefixes.
	/// Default is off.
	/// </summary>
	public virtual void SetPrefixAllButMerged(bool _arg)
	{
		vtkMergeTables_SetPrefixAllButMerged_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTables_SetSecondTablePrefix_19(HandleRef pThis, string _arg);

	/// <summary>
	/// The prefix to give to same-named fields from the second table.
	/// Default is "Table2.".
	/// </summary>
	public virtual void SetSecondTablePrefix(string _arg)
	{
		vtkMergeTables_SetSecondTablePrefix_19(GetCppThis(), _arg);
	}
}
