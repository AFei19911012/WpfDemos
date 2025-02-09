using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDSPFilterDefinition
/// </summary>
/// <remarks>
///    used by the Exodus readers
///
/// vtkDSPFilterDefinition is used by vtkExodusReader, vtkExodusIIReader and
/// vtkPExodusReader to do temporal smoothing of data
/// </remarks>
/// <seealso>
///
/// vtkDSPFilterGroup vtkExodusReader vtkExodusIIReader vtkPExodusReader
/// </seealso>
public class vtkDSPFilterDefinition : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDSPFilterDefinition";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDSPFilterDefinition()
	{
		MRClassNameKey = "class vtkDSPFilterDefinition";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDSPFilterDefinition"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDSPFilterDefinition(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterDefinition_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDSPFilterDefinition New()
	{
		vtkDSPFilterDefinition result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterDefinition_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDSPFilterDefinition()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDSPFilterDefinition_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDSPFilterDefinition_Clear_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Clear()
	{
		vtkDSPFilterDefinition_Clear_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterDefinition_Copy_02(HandleRef pThis, HandleRef other);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Copy(vtkDSPFilterDefinition other)
	{
		vtkDSPFilterDefinition_Copy_02(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDSPFilterDefinition_GetDenominatorWeight_03(HandleRef pThis, int a_which);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetDenominatorWeight(int a_which)
	{
		return vtkDSPFilterDefinition_GetDenominatorWeight_03(GetCppThis(), a_which);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDSPFilterDefinition_GetForwardNumeratorWeight_04(HandleRef pThis, int a_which);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetForwardNumeratorWeight(int a_which)
	{
		return vtkDSPFilterDefinition_GetForwardNumeratorWeight_04(GetCppThis(), a_which);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterDefinition_GetInputVariableName_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetInputVariableName()
	{
		return Marshal.PtrToStringAnsi(vtkDSPFilterDefinition_GetInputVariableName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDSPFilterDefinition_GetNumDenominatorWeights_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetNumDenominatorWeights()
	{
		return vtkDSPFilterDefinition_GetNumDenominatorWeights_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDSPFilterDefinition_GetNumForwardNumeratorWeights_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetNumForwardNumeratorWeights()
	{
		return vtkDSPFilterDefinition_GetNumForwardNumeratorWeights_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDSPFilterDefinition_GetNumNumeratorWeights_08(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetNumNumeratorWeights()
	{
		return vtkDSPFilterDefinition_GetNumNumeratorWeights_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDSPFilterDefinition_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDSPFilterDefinition_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDSPFilterDefinition_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDSPFilterDefinition_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDSPFilterDefinition_GetNumeratorWeight_11(HandleRef pThis, int a_which);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetNumeratorWeight(int a_which)
	{
		return vtkDSPFilterDefinition_GetNumeratorWeight_11(GetCppThis(), a_which);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterDefinition_GetOutputVariableName_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetOutputVariableName()
	{
		return Marshal.PtrToStringAnsi(vtkDSPFilterDefinition_GetOutputVariableName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDSPFilterDefinition_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDSPFilterDefinition_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDSPFilterDefinition_IsThisInputVariableInstanceNeeded_14(HandleRef pThis, int a_timestep, int a_outputTimestep);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool IsThisInputVariableInstanceNeeded(int a_timestep, int a_outputTimestep)
	{
		return (vtkDSPFilterDefinition_IsThisInputVariableInstanceNeeded_14(GetCppThis(), a_timestep, a_outputTimestep) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDSPFilterDefinition_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDSPFilterDefinition_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterDefinition_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDSPFilterDefinition NewInstance()
	{
		vtkDSPFilterDefinition result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterDefinition_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterDefinition_PushBackDenominatorWeight_18(HandleRef pThis, double a_value);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void PushBackDenominatorWeight(double a_value)
	{
		vtkDSPFilterDefinition_PushBackDenominatorWeight_18(GetCppThis(), a_value);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterDefinition_PushBackForwardNumeratorWeight_19(HandleRef pThis, double a_value);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void PushBackForwardNumeratorWeight(double a_value)
	{
		vtkDSPFilterDefinition_PushBackForwardNumeratorWeight_19(GetCppThis(), a_value);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterDefinition_PushBackNumeratorWeight_20(HandleRef pThis, double a_value);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void PushBackNumeratorWeight(double a_value)
	{
		vtkDSPFilterDefinition_PushBackNumeratorWeight_20(GetCppThis(), a_value);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterDefinition_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDSPFilterDefinition SafeDownCast(vtkObjectBase o)
	{
		vtkDSPFilterDefinition vtkDSPFilterDefinition2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterDefinition_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDSPFilterDefinition2 = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDSPFilterDefinition2.Register(null);
			}
		}
		return vtkDSPFilterDefinition2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterDefinition_SetInputVariableName_22(HandleRef pThis, string a_value);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInputVariableName(string a_value)
	{
		vtkDSPFilterDefinition_SetInputVariableName_22(GetCppThis(), a_value);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterDefinition_SetOutputVariableName_23(HandleRef pThis, string a_value);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetOutputVariableName(string a_value)
	{
		vtkDSPFilterDefinition_SetOutputVariableName_23(GetCppThis(), a_value);
	}
}
