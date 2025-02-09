using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSparseArrayToTable
/// </summary>
/// <remarks>
///    Converts a sparse array to a vtkTable.
///
///
/// Converts any sparse array to a vtkTable containing one row for each value
/// stored in the array.  The table will contain one column of coordinates for each
/// dimension in the source array, plus one column of array values.  A common use-case
/// for vtkSparseArrayToTable would be converting a sparse array into a table
/// suitable for use as an input to vtkTableToGraph.
///
/// The coordinate columns in the output table will be named using the dimension labels
/// from the source array,  The value column name can be explicitly set using
/// SetValueColumn().
///
/// @par Thanks:
/// </remarks>
/// <seealso>
/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
/// </seealso>
public class vtkSparseArrayToTable : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSparseArrayToTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSparseArrayToTable()
	{
		MRClassNameKey = "class vtkSparseArrayToTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSparseArrayToTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSparseArrayToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSparseArrayToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSparseArrayToTable New()
	{
		vtkSparseArrayToTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSparseArrayToTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSparseArrayToTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSparseArrayToTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkSparseArrayToTable_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSparseArrayToTable_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSparseArrayToTable_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSparseArrayToTable_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSparseArrayToTable_GetValueColumn_03(HandleRef pThis);

	/// <summary>
	/// Specify the name of the output table column that contains array values.
	/// Default: "value"
	/// </summary>
	public virtual string GetValueColumn()
	{
		return Marshal.PtrToStringAnsi(vtkSparseArrayToTable_GetValueColumn_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSparseArrayToTable_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSparseArrayToTable_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSparseArrayToTable_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSparseArrayToTable_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSparseArrayToTable_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSparseArrayToTable NewInstance()
	{
		vtkSparseArrayToTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSparseArrayToTable_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSparseArrayToTable_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSparseArrayToTable SafeDownCast(vtkObjectBase o)
	{
		vtkSparseArrayToTable vtkSparseArrayToTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSparseArrayToTable_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSparseArrayToTable2 = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSparseArrayToTable2.Register(null);
			}
		}
		return vtkSparseArrayToTable2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSparseArrayToTable_SetValueColumn_09(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the output table column that contains array values.
	/// Default: "value"
	/// </summary>
	public virtual void SetValueColumn(string _arg)
	{
		vtkSparseArrayToTable_SetValueColumn_09(GetCppThis(), _arg);
	}
}
