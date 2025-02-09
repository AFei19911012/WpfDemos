using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalArrayOperatorFilter
/// </summary>
/// <remarks>
///    perform simple mathematical operation on a data array at different time
///
/// This filter computes a simple operation between two time steps of one
/// data array.
///
/// </remarks>
/// <seealso>
///
/// vtkArrayCalulator
/// </seealso>
public class vtkTemporalArrayOperatorFilter : vtkMultiTimeStepAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum OperatorType
	{
		/// <summary>enum member</summary>
		ADD = 0,
		/// <summary>enum member</summary>
		DIV = 3,
		/// <summary>enum member</summary>
		MUL = 2,
		/// <summary>enum member</summary>
		SUB = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalArrayOperatorFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalArrayOperatorFilter()
	{
		MRClassNameKey = "class vtkTemporalArrayOperatorFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalArrayOperatorFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalArrayOperatorFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalArrayOperatorFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalArrayOperatorFilter New()
	{
		vtkTemporalArrayOperatorFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalArrayOperatorFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalArrayOperatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTemporalArrayOperatorFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalArrayOperatorFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalArrayOperatorFilter_GetFirstTimeStepIndex_01(HandleRef pThis);

	/// <summary>
	/// @brief Set/Get the first time step.
	/// </summary>
	public virtual int GetFirstTimeStepIndex()
	{
		return vtkTemporalArrayOperatorFilter_GetFirstTimeStepIndex_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalArrayOperatorFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalArrayOperatorFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalArrayOperatorFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalArrayOperatorFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalArrayOperatorFilter_GetOperator_04(HandleRef pThis);

	/// <summary>
	/// @brief Set/Get the operator to apply. Default is ADD (0).
	/// </summary>
	public virtual int GetOperator()
	{
		return vtkTemporalArrayOperatorFilter_GetOperator_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalArrayOperatorFilter_GetOutputArrayNameSuffix_05(HandleRef pThis);

	/// <summary>
	/// @brief Set/Get the suffix to be append to the output array name.
	/// If not specified, output will be suffixed with '_' and the operation
	/// type (eg. myarrayname_add).
	/// </summary>
	public virtual string GetOutputArrayNameSuffix()
	{
		return Marshal.PtrToStringAnsi(vtkTemporalArrayOperatorFilter_GetOutputArrayNameSuffix_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalArrayOperatorFilter_GetSecondTimeStepIndex_06(HandleRef pThis);

	/// <summary>
	/// @brief Set/Get the second time step.
	/// </summary>
	public virtual int GetSecondTimeStepIndex()
	{
		return vtkTemporalArrayOperatorFilter_GetSecondTimeStepIndex_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalArrayOperatorFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalArrayOperatorFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalArrayOperatorFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalArrayOperatorFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalArrayOperatorFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTemporalArrayOperatorFilter NewInstance()
	{
		vtkTemporalArrayOperatorFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalArrayOperatorFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalArrayOperatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalArrayOperatorFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalArrayOperatorFilter SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalArrayOperatorFilter vtkTemporalArrayOperatorFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalArrayOperatorFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalArrayOperatorFilter2 = (vtkTemporalArrayOperatorFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalArrayOperatorFilter2.Register(null);
			}
		}
		return vtkTemporalArrayOperatorFilter2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalArrayOperatorFilter_SetFirstTimeStepIndex_12(HandleRef pThis, int _arg);

	/// <summary>
	/// @brief Set/Get the first time step.
	/// </summary>
	public virtual void SetFirstTimeStepIndex(int _arg)
	{
		vtkTemporalArrayOperatorFilter_SetFirstTimeStepIndex_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalArrayOperatorFilter_SetOperator_13(HandleRef pThis, int _arg);

	/// <summary>
	/// @brief Set/Get the operator to apply. Default is ADD (0).
	/// </summary>
	public virtual void SetOperator(int _arg)
	{
		vtkTemporalArrayOperatorFilter_SetOperator_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalArrayOperatorFilter_SetOutputArrayNameSuffix_14(HandleRef pThis, string _arg);

	/// <summary>
	/// @brief Set/Get the suffix to be append to the output array name.
	/// If not specified, output will be suffixed with '_' and the operation
	/// type (eg. myarrayname_add).
	/// </summary>
	public virtual void SetOutputArrayNameSuffix(string _arg)
	{
		vtkTemporalArrayOperatorFilter_SetOutputArrayNameSuffix_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalArrayOperatorFilter_SetSecondTimeStepIndex_15(HandleRef pThis, int _arg);

	/// <summary>
	/// @brief Set/Get the second time step.
	/// </summary>
	public virtual void SetSecondTimeStepIndex(int _arg)
	{
		vtkTemporalArrayOperatorFilter_SetSecondTimeStepIndex_15(GetCppThis(), _arg);
	}
}
