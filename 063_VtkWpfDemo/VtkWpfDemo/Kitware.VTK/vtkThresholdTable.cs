using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkThresholdTable
/// </summary>
/// <remarks>
///    Thresholds table rows.
///
///
/// vtkThresholdTable uses minimum and/or maximum values to threshold
/// table rows based on the values in a particular column.
/// The column to threshold is specified using SetInputArrayToProcess(0, ...).
/// </remarks>
public class vtkThresholdTable : vtkTableAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum ACCEPT_BETWEEN_WrapperEnum
	{
		/// <summary>enum member</summary>
		ACCEPT_BETWEEN = 2,
		/// <summary>enum member</summary>
		ACCEPT_GREATER_THAN = 1,
		/// <summary>enum member</summary>
		ACCEPT_LESS_THAN = 0,
		/// <summary>enum member</summary>
		ACCEPT_OUTSIDE = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkThresholdTable()
	{
		MRClassNameKey = "class vtkThresholdTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkThresholdTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThresholdTable New()
	{
		vtkThresholdTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkThresholdTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkThresholdTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkThresholdTable_GetMaxValue_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The maximum value for the threshold.
	/// This may be any data type stored in a vtkVariant.
	/// </summary>
	public virtual vtkVariant GetMaxValue()
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdTable_GetMaxValue_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTable_GetMinValue_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The minimum value for the threshold.
	/// This may be any data type stored in a vtkVariant.
	/// </summary>
	public virtual vtkVariant GetMinValue()
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdTable_GetMinValue_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTable_GetMode_03(HandleRef pThis);

	/// <summary>
	/// The mode of the threshold filter.  Options are:
	/// ACCEPT_LESS_THAN (0) accepts rows with values &lt; MaxValue;
	/// ACCEPT_GREATER_THAN (1) accepts rows with values &gt; MinValue;
	/// ACCEPT_BETWEEN (2) accepts rows with values &gt; MinValue and &lt; MaxValue;
	/// ACCEPT_OUTSIDE (3) accepts rows with values &lt; MinValue or &gt; MaxValue.
	/// </summary>
	public virtual int GetMode()
	{
		return vtkThresholdTable_GetMode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTable_GetModeMaxValue_04(HandleRef pThis);

	/// <summary>
	/// The mode of the threshold filter.  Options are:
	/// ACCEPT_LESS_THAN (0) accepts rows with values &lt; MaxValue;
	/// ACCEPT_GREATER_THAN (1) accepts rows with values &gt; MinValue;
	/// ACCEPT_BETWEEN (2) accepts rows with values &gt; MinValue and &lt; MaxValue;
	/// ACCEPT_OUTSIDE (3) accepts rows with values &lt; MinValue or &gt; MaxValue.
	/// </summary>
	public virtual int GetModeMaxValue()
	{
		return vtkThresholdTable_GetModeMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTable_GetModeMinValue_05(HandleRef pThis);

	/// <summary>
	/// The mode of the threshold filter.  Options are:
	/// ACCEPT_LESS_THAN (0) accepts rows with values &lt; MaxValue;
	/// ACCEPT_GREATER_THAN (1) accepts rows with values &gt; MinValue;
	/// ACCEPT_BETWEEN (2) accepts rows with values &gt; MinValue and &lt; MaxValue;
	/// ACCEPT_OUTSIDE (3) accepts rows with values &lt; MinValue or &gt; MaxValue.
	/// </summary>
	public virtual int GetModeMinValue()
	{
		return vtkThresholdTable_GetModeMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThresholdTable_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkThresholdTable_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThresholdTable_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkThresholdTable_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTable_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkThresholdTable_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTable_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkThresholdTable_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTable_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkThresholdTable NewInstance()
	{
		vtkThresholdTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdTable_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTable_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThresholdTable SafeDownCast(vtkObjectBase o)
	{
		vtkThresholdTable vtkThresholdTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdTable_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkThresholdTable2 = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkThresholdTable2.Register(null);
			}
		}
		return vtkThresholdTable2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTable_SetMaxValue_13(HandleRef pThis, HandleRef v);

	/// <summary>
	/// The maximum value for the threshold.
	/// This may be any data type stored in a vtkVariant.
	/// </summary>
	public virtual void SetMaxValue(vtkVariant v)
	{
		vtkThresholdTable_SetMaxValue_13(GetCppThis(), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTable_SetMaxValue_14(HandleRef pThis, double v);

	/// <summary>
	/// The maximum value for the threshold as a double.
	/// </summary>
	public void SetMaxValue(double v)
	{
		vtkThresholdTable_SetMaxValue_14(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTable_SetMinValue_15(HandleRef pThis, HandleRef v);

	/// <summary>
	/// The minimum value for the threshold.
	/// This may be any data type stored in a vtkVariant.
	/// </summary>
	public virtual void SetMinValue(vtkVariant v)
	{
		vtkThresholdTable_SetMinValue_15(GetCppThis(), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTable_SetMinValue_16(HandleRef pThis, double v);

	/// <summary>
	/// The minimum value for the threshold as a double.
	/// </summary>
	public void SetMinValue(double v)
	{
		vtkThresholdTable_SetMinValue_16(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTable_SetMode_17(HandleRef pThis, int _arg);

	/// <summary>
	/// The mode of the threshold filter.  Options are:
	/// ACCEPT_LESS_THAN (0) accepts rows with values &lt; MaxValue;
	/// ACCEPT_GREATER_THAN (1) accepts rows with values &gt; MinValue;
	/// ACCEPT_BETWEEN (2) accepts rows with values &gt; MinValue and &lt; MaxValue;
	/// ACCEPT_OUTSIDE (3) accepts rows with values &lt; MinValue or &gt; MaxValue.
	/// </summary>
	public virtual void SetMode(int _arg)
	{
		vtkThresholdTable_SetMode_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTable_ThresholdBetween_18(HandleRef pThis, HandleRef lower, HandleRef upper);

	/// <summary>
	/// Criterion is rows whose scalars are between lower and upper thresholds
	/// (inclusive of the end values).
	/// </summary>
	public void ThresholdBetween(vtkVariant lower, vtkVariant upper)
	{
		vtkThresholdTable_ThresholdBetween_18(GetCppThis(), lower?.GetCppThis() ?? default(HandleRef), upper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTable_ThresholdBetween_19(HandleRef pThis, double lower, double upper);

	/// <summary>
	/// Criterion is rows whose scalars are between lower and upper thresholds
	/// (inclusive of the end values).
	/// </summary>
	public void ThresholdBetween(double lower, double upper)
	{
		vtkThresholdTable_ThresholdBetween_19(GetCppThis(), lower, upper);
	}
}
