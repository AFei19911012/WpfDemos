using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkJoinTables
/// </summary>
/// <remarks>
///    SQL-style Join operation on two tables.
///
///
/// vtkJoinTables is a filter that operates on two vtkTable objects to perform an
/// SQL-style Join operation. It outputs one vtkTable object. The goal is to combine the rows of both
/// tables into one bigger table based on a related column between them (both inputs have their "key
/// column"). The two input tables are referred to as left and right. In each input table, the values
/// in the key column act like unique IDs for their respective  rows. During the merge, the
/// attributes of each item will be given with respect to its ID.
/// </remarks>
public class vtkJoinTables : vtkTableAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum JoinMode
	{
		/// <summary>enum member</summary>
		INTERSECTION = 0,
		/// <summary>enum member</summary>
		LEFT = 2,
		/// <summary>enum member</summary>
		RIGHT = 3,
		/// <summary>enum member</summary>
		UNION = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkJoinTables";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkJoinTables()
	{
		MRClassNameKey = "class vtkJoinTables";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkJoinTables"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkJoinTables(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJoinTables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJoinTables New()
	{
		vtkJoinTables result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJoinTables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJoinTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkJoinTables()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkJoinTables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJoinTables_GetLeftKey_01(HandleRef pThis);

	/// <summary>
	/// Specifies which column of the left table to use for the join operation.
	/// </summary>
	public virtual string GetLeftKey()
	{
		return Marshal.PtrToStringAnsi(vtkJoinTables_GetLeftKey_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJoinTables_GetMode_02(HandleRef pThis);

	/// <summary>
	/// The mode of the Join Tables filter. This is meaningful when the two key columns do not share
	/// exactly the same set of values. The different Join modes that this filter implements are :
	/// - INTERSECTION : Keeps only the keys that are in both columns.
	/// - UNION : Keeps all of the keys from both tables.
	/// - LEFT : Keeps the keys from the left table.
	/// - RIGHT : Keeps the keys from the right table.
	/// </summary>
	public virtual int GetMode()
	{
		return vtkJoinTables_GetMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJoinTables_GetModeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// The mode of the Join Tables filter. This is meaningful when the two key columns do not share
	/// exactly the same set of values. The different Join modes that this filter implements are :
	/// - INTERSECTION : Keeps only the keys that are in both columns.
	/// - UNION : Keeps all of the keys from both tables.
	/// - LEFT : Keeps the keys from the left table.
	/// - RIGHT : Keeps the keys from the right table.
	/// </summary>
	public virtual int GetModeMaxValue()
	{
		return vtkJoinTables_GetModeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJoinTables_GetModeMinValue_04(HandleRef pThis);

	/// <summary>
	/// The mode of the Join Tables filter. This is meaningful when the two key columns do not share
	/// exactly the same set of values. The different Join modes that this filter implements are :
	/// - INTERSECTION : Keeps only the keys that are in both columns.
	/// - UNION : Keeps all of the keys from both tables.
	/// - LEFT : Keeps the keys from the left table.
	/// - RIGHT : Keeps the keys from the right table.
	/// </summary>
	public virtual int GetModeMinValue()
	{
		return vtkJoinTables_GetModeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJoinTables_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkJoinTables_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJoinTables_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkJoinTables_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkJoinTables_GetReplacementValue_07(HandleRef pThis);

	/// <summary>
	/// Value to be imputed in numeric columns of the output when the data for a given key in a given
	/// column is unknown.
	/// </summary>
	public virtual double GetReplacementValue()
	{
		return vtkJoinTables_GetReplacementValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJoinTables_GetRightKey_08(HandleRef pThis);

	/// <summary>
	/// Specifies which column of the right table to use for the join operation.
	/// </summary>
	public virtual string GetRightKey()
	{
		return Marshal.PtrToStringAnsi(vtkJoinTables_GetRightKey_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJoinTables_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkJoinTables_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJoinTables_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkJoinTables_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJoinTables_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkJoinTables NewInstance()
	{
		vtkJoinTables result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJoinTables_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJoinTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJoinTables_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJoinTables SafeDownCast(vtkObjectBase o)
	{
		vtkJoinTables vtkJoinTables2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJoinTables_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkJoinTables2 = (vtkJoinTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkJoinTables2.Register(null);
			}
		}
		return vtkJoinTables2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJoinTables_SetLeftKey_14(HandleRef pThis, string arg);

	/// <summary>
	/// Specifies which column of the left table to use for the join operation.
	/// </summary>
	public virtual void SetLeftKey(string arg)
	{
		vtkJoinTables_SetLeftKey_14(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJoinTables_SetMode_15(HandleRef pThis, int _arg);

	/// <summary>
	/// The mode of the Join Tables filter. This is meaningful when the two key columns do not share
	/// exactly the same set of values. The different Join modes that this filter implements are :
	/// - INTERSECTION : Keeps only the keys that are in both columns.
	/// - UNION : Keeps all of the keys from both tables.
	/// - LEFT : Keeps the keys from the left table.
	/// - RIGHT : Keeps the keys from the right table.
	/// </summary>
	public virtual void SetMode(int _arg)
	{
		vtkJoinTables_SetMode_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJoinTables_SetReplacementValue_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Value to be imputed in numeric columns of the output when the data for a given key in a given
	/// column is unknown.
	/// </summary>
	public virtual void SetReplacementValue(double _arg)
	{
		vtkJoinTables_SetReplacementValue_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJoinTables_SetRightKey_17(HandleRef pThis, string arg);

	/// <summary>
	/// Specifies which column of the right table to use for the join operation.
	/// </summary>
	public virtual void SetRightKey(string arg)
	{
		vtkJoinTables_SetRightKey_17(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJoinTables_SetSourceConnection_18(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Set a pipeline connection on port 1 for the right table. This method is equivalent
	/// to SetInputConnection(1, source).
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput source)
	{
		vtkJoinTables_SetSourceConnection_18(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJoinTables_SetSourceData_19(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify input data on port 1 for the right table. This method is equivalent
	/// to SetInputData(1, source).
	/// </summary>
	public void SetSourceData(vtkTable source)
	{
		vtkJoinTables_SetSourceData_19(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}
}
