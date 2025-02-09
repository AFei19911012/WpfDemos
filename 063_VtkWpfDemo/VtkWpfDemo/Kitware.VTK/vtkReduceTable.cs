using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkReduceTable
/// </summary>
/// <remarks>
///    combine some of the rows of a table
///
///
/// Collapses the rows of the input table so that one particular
/// column (the IndexColumn) does not contain any duplicate values.
/// Thus the output table will have the same columns as the input
/// table, but potentially fewer rows.  One example use of this
/// class would be to generate a summary table from a table of
/// observations.
/// When two or more rows of the input table share a value in the
/// IndexColumn, the values from these rows will be combined on a
/// column-by-column basis.  By default, such numerical values will be
/// reduced to their mean, and non-numerical values will be reduced to
/// their mode.  This default behavior can be changed by calling
/// SetNumericalReductionMethod() or SetNonNumericalReductionMethod().
/// You can also specify the reduction method to use for a particular
/// column by calling SetReductionMethodForColumn().
/// </remarks>
public class vtkReduceTable : vtkTableAlgorithm
{
	/// <summary>
	/// Enum for methods of reduction
	/// </summary>
	public enum MEAN_WrapperEnum
	{
		/// <summary>enum member</summary>
		MEAN,
		/// <summary>enum member</summary>
		MEDIAN,
		/// <summary>enum member</summary>
		MODE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkReduceTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkReduceTable()
	{
		MRClassNameKey = "class vtkReduceTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkReduceTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkReduceTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReduceTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReduceTable New()
	{
		vtkReduceTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReduceTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReduceTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkReduceTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkReduceTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkReduceTable_GetIndexColumn_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the column that will be used to reduce the input table.
	/// Any rows sharing a value in this column will be collapsed into
	/// a single row in the output table.
	/// </summary>
	public virtual long GetIndexColumn()
	{
		return vtkReduceTable_GetIndexColumn_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReduceTable_GetNonNumericalReductionMethod_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the method that should be used to combine non-numerical
	/// values.
	/// </summary>
	public virtual int GetNonNumericalReductionMethod()
	{
		return vtkReduceTable_GetNonNumericalReductionMethod_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReduceTable_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkReduceTable_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkReduceTable_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkReduceTable_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReduceTable_GetNumericalReductionMethod_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the method that should be used to combine numerical
	/// values.
	/// </summary>
	public virtual int GetNumericalReductionMethod()
	{
		return vtkReduceTable_GetNumericalReductionMethod_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReduceTable_GetReductionMethodForColumn_06(HandleRef pThis, long col);

	/// <summary>
	/// Get the method that should be used to combine the values within
	/// the specified column.  Returns -1 if no method has been set for
	/// this particular column.
	/// </summary>
	public int GetReductionMethodForColumn(long col)
	{
		return vtkReduceTable_GetReductionMethodForColumn_06(GetCppThis(), col);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReduceTable_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkReduceTable_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkReduceTable_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkReduceTable_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReduceTable_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkReduceTable NewInstance()
	{
		vtkReduceTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReduceTable_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkReduceTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkReduceTable_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkReduceTable SafeDownCast(vtkObjectBase o)
	{
		vtkReduceTable vtkReduceTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkReduceTable_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkReduceTable2 = (vtkReduceTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkReduceTable2.Register(null);
			}
		}
		return vtkReduceTable2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReduceTable_SetIndexColumn_12(HandleRef pThis, long _arg);

	/// <summary>
	/// Get/Set the column that will be used to reduce the input table.
	/// Any rows sharing a value in this column will be collapsed into
	/// a single row in the output table.
	/// </summary>
	public virtual void SetIndexColumn(long _arg)
	{
		vtkReduceTable_SetIndexColumn_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReduceTable_SetNonNumericalReductionMethod_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the method that should be used to combine non-numerical
	/// values.
	/// </summary>
	public virtual void SetNonNumericalReductionMethod(int _arg)
	{
		vtkReduceTable_SetNonNumericalReductionMethod_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReduceTable_SetNumericalReductionMethod_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the method that should be used to combine numerical
	/// values.
	/// </summary>
	public virtual void SetNumericalReductionMethod(int _arg)
	{
		vtkReduceTable_SetNumericalReductionMethod_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkReduceTable_SetReductionMethodForColumn_15(HandleRef pThis, long col, int method);

	/// <summary>
	/// Set the method that should be used to combine the values within
	/// the specified column.
	/// </summary>
	public void SetReductionMethodForColumn(long col, int method)
	{
		vtkReduceTable_SetReductionMethodForColumn_15(GetCppThis(), col, method);
	}
}
