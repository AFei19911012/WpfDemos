using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDSPFilterGroup
/// </summary>
/// <remarks>
///    used by the Exodus readers
///
/// vtkDSPFilterGroup is used by vtkExodusReader, vtkExodusIIReader and
/// vtkPExodusReader to do temporal smoothing of data
/// </remarks>
/// <seealso>
///
/// vtkDSPFilterDefinition vtkExodusReader vtkExodusIIReader vtkPExodusReader
/// </seealso>
public class vtkDSPFilterGroup : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDSPFilterGroup";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDSPFilterGroup()
	{
		MRClassNameKey = "class vtkDSPFilterGroup";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDSPFilterGroup"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDSPFilterGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDSPFilterGroup New()
	{
		vtkDSPFilterGroup result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDSPFilterGroup()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDSPFilterGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDSPFilterGroup_AddFilter_01(HandleRef pThis, HandleRef filter);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void AddFilter(vtkDSPFilterDefinition filter)
	{
		vtkDSPFilterGroup_AddFilter_01(GetCppThis(), filter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterGroup_AddInputVariableInstance_02(HandleRef pThis, string a_name, int a_timestep, HandleRef a_data);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void AddInputVariableInstance(string a_name, int a_timestep, vtkFloatArray a_data)
	{
		vtkDSPFilterGroup_AddInputVariableInstance_02(GetCppThis(), a_name, a_timestep, a_data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterGroup_Copy_03(HandleRef pThis, HandleRef other);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Copy(vtkDSPFilterGroup other)
	{
		vtkDSPFilterGroup_Copy_03(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterGroup_GetCachedInput_04(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFloatArray GetCachedInput(int a_whichFilter, int a_whichTimestep)
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterGroup_GetCachedInput_04(GetCppThis(), a_whichFilter, a_whichTimestep, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterGroup_GetCachedOutput_05(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFloatArray GetCachedOutput(int a_whichFilter, int a_whichTimestep)
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterGroup_GetCachedOutput_05(GetCppThis(), a_whichFilter, a_whichTimestep, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterGroup_GetFilter_06(HandleRef pThis, int a_whichFilter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDSPFilterDefinition GetFilter(int a_whichFilter)
	{
		vtkDSPFilterDefinition vtkDSPFilterDefinition2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterGroup_GetFilter_06(GetCppThis(), a_whichFilter, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDSPFilterGroup_GetInputVariableName_07(HandleRef pThis, int a_whichFilter);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetInputVariableName(int a_whichFilter)
	{
		return Marshal.PtrToStringAnsi(vtkDSPFilterGroup_GetInputVariableName_07(GetCppThis(), a_whichFilter));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDSPFilterGroup_GetNumFilters_08(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetNumFilters()
	{
		return vtkDSPFilterGroup_GetNumFilters_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDSPFilterGroup_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDSPFilterGroup_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDSPFilterGroup_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDSPFilterGroup_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterGroup_GetOutput_11(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref int a_instancesCalculated, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFloatArray GetOutput(int a_whichFilter, int a_whichTimestep, ref int a_instancesCalculated)
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterGroup_GetOutput_11(GetCppThis(), a_whichFilter, a_whichTimestep, ref a_instancesCalculated, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDSPFilterGroup_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDSPFilterGroup_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDSPFilterGroup_IsThisInputVariableInstanceCached_13(HandleRef pThis, string a_name, int a_timestep);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool IsThisInputVariableInstanceCached(string a_name, int a_timestep)
	{
		return (vtkDSPFilterGroup_IsThisInputVariableInstanceCached_13(GetCppThis(), a_name, a_timestep) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDSPFilterGroup_IsThisInputVariableInstanceNeeded_14(HandleRef pThis, string a_name, int a_timestep, int a_outputTimestep);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool IsThisInputVariableInstanceNeeded(string a_name, int a_timestep, int a_outputTimestep)
	{
		return (vtkDSPFilterGroup_IsThisInputVariableInstanceNeeded_14(GetCppThis(), a_name, a_timestep, a_outputTimestep) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDSPFilterGroup_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDSPFilterGroup_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterGroup_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDSPFilterGroup NewInstance()
	{
		vtkDSPFilterGroup result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterGroup_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDSPFilterGroup_RemoveFilter_18(HandleRef pThis, string a_outputVariableName);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void RemoveFilter(string a_outputVariableName)
	{
		vtkDSPFilterGroup_RemoveFilter_18(GetCppThis(), a_outputVariableName);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDSPFilterGroup_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDSPFilterGroup SafeDownCast(vtkObjectBase o)
	{
		vtkDSPFilterGroup vtkDSPFilterGroup2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDSPFilterGroup_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDSPFilterGroup2 = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDSPFilterGroup2.Register(null);
			}
		}
		return vtkDSPFilterGroup2;
	}
}
