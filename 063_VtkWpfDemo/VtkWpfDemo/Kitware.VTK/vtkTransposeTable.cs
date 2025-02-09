using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTransposeTable
/// </summary>
/// <remarks>
///    Transpose an input table.
///
///
/// This algorithm allows to transpose a vtkTable as a matrix.
/// Columns become rows and vice versa. A new column can be added to
/// the result table at index 0 to collect the name of the initial
/// columns (when AddIdColumn is true). Such a column can be used
/// to name the columns of the result.
/// Note that columns of the output table will have a variant type
/// is the columns of the initial table are not consistent.
/// </remarks>
public class vtkTransposeTable : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTransposeTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTransposeTable()
	{
		MRClassNameKey = "class vtkTransposeTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransposeTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTransposeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransposeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransposeTable New()
	{
		vtkTransposeTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransposeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransposeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTransposeTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTransposeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransposeTable_AddIdColumnOff_01(HandleRef pThis);

	/// <summary>
	/// This flag indicates if a column must be inserted at index 0
	/// with the names (ids) of the input columns.
	/// Default: true
	/// </summary>
	public virtual void AddIdColumnOff()
	{
		vtkTransposeTable_AddIdColumnOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransposeTable_AddIdColumnOn_02(HandleRef pThis);

	/// <summary>
	/// This flag indicates if a column must be inserted at index 0
	/// with the names (ids) of the input columns.
	/// Default: true
	/// </summary>
	public virtual void AddIdColumnOn()
	{
		vtkTransposeTable_AddIdColumnOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTransposeTable_GetAddIdColumn_03(HandleRef pThis);

	/// <summary>
	/// This flag indicates if a column must be inserted at index 0
	/// with the names (ids) of the input columns.
	/// Default: true
	/// </summary>
	public virtual bool GetAddIdColumn()
	{
		return (vtkTransposeTable_GetAddIdColumn_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransposeTable_GetIdColumnName_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the id column added by option AddIdColumn.
	/// Default: ColName
	/// </summary>
	public virtual string GetIdColumnName()
	{
		return Marshal.PtrToStringAnsi(vtkTransposeTable_GetIdColumnName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransposeTable_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTransposeTable_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTransposeTable_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTransposeTable_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTransposeTable_GetUseIdColumn_07(HandleRef pThis);

	/// <summary>
	/// This flag indicates if the output column must be named using the
	/// names listed in the index 0 column.
	/// Default: false
	/// </summary>
	public virtual bool GetUseIdColumn()
	{
		return (vtkTransposeTable_GetUseIdColumn_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransposeTable_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTransposeTable_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTransposeTable_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTransposeTable_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransposeTable_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTransposeTable NewInstance()
	{
		vtkTransposeTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransposeTable_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTransposeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTransposeTable_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTransposeTable SafeDownCast(vtkObjectBase o)
	{
		vtkTransposeTable vtkTransposeTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTransposeTable_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransposeTable2 = (vtkTransposeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransposeTable2.Register(null);
			}
		}
		return vtkTransposeTable2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransposeTable_SetAddIdColumn_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// This flag indicates if a column must be inserted at index 0
	/// with the names (ids) of the input columns.
	/// Default: true
	/// </summary>
	public virtual void SetAddIdColumn(bool _arg)
	{
		vtkTransposeTable_SetAddIdColumn_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransposeTable_SetIdColumnName_14(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the id column added by option AddIdColumn.
	/// Default: ColName
	/// </summary>
	public virtual void SetIdColumnName(string _arg)
	{
		vtkTransposeTable_SetIdColumnName_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransposeTable_SetUseIdColumn_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// This flag indicates if the output column must be named using the
	/// names listed in the index 0 column.
	/// Default: false
	/// </summary>
	public virtual void SetUseIdColumn(bool _arg)
	{
		vtkTransposeTable_SetUseIdColumn_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransposeTable_UseIdColumnOff_16(HandleRef pThis);

	/// <summary>
	/// This flag indicates if the output column must be named using the
	/// names listed in the index 0 column.
	/// Default: false
	/// </summary>
	public virtual void UseIdColumnOff()
	{
		vtkTransposeTable_UseIdColumnOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTransposeTable_UseIdColumnOn_17(HandleRef pThis);

	/// <summary>
	/// This flag indicates if the output column must be named using the
	/// names listed in the index 0 column.
	/// Default: false
	/// </summary>
	public virtual void UseIdColumnOn()
	{
		vtkTransposeTable_UseIdColumnOn_17(GetCppThis());
	}
}
