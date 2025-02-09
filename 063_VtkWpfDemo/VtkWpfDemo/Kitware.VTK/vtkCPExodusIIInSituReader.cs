using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCPExodusIIInSituReader
/// </summary>
/// <remarks>
///    Read an Exodus II file into data structures
/// that map the raw arrays returned by the Exodus II library into a multi-block
/// data set containing vtkUnstructuredGridBase subclasses.
///
///
/// This class can be used to import Exodus II files into VTK without repacking
/// the data into the standard VTK memory layout, avoiding the cost of a deep
/// copy.
/// </remarks>
public class vtkCPExodusIIInSituReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCPExodusIIInSituReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCPExodusIIInSituReader()
	{
		MRClassNameKey = "class vtkCPExodusIIInSituReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCPExodusIIInSituReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCPExodusIIInSituReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCPExodusIIInSituReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCPExodusIIInSituReader New()
	{
		vtkCPExodusIIInSituReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCPExodusIIInSituReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCPExodusIIInSituReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCPExodusIIInSituReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCPExodusIIInSituReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCPExodusIIInSituReader_GetCurrentTimeStep_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the current timestep to read as a zero-based index.
	/// </summary>
	public virtual int GetCurrentTimeStep()
	{
		return vtkCPExodusIIInSituReader_GetCurrentTimeStep_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCPExodusIIInSituReader_GetFileName_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the Exodus file to read.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkCPExodusIIInSituReader_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCPExodusIIInSituReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCPExodusIIInSituReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCPExodusIIInSituReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCPExodusIIInSituReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCPExodusIIInSituReader_GetTimeStepRange_05(HandleRef pThis);

	/// <summary>
	/// Get the range of timesteps, represented as [0, numTimeSteps - 1]. Call
	/// UpdateInformation first to set this without reading any timestep data.
	/// </summary>
	public virtual int[] GetTimeStepRange()
	{
		IntPtr intPtr = vtkCPExodusIIInSituReader_GetTimeStepRange_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCPExodusIIInSituReader_GetTimeStepRange_06(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the range of timesteps, represented as [0, numTimeSteps - 1]. Call
	/// UpdateInformation first to set this without reading any timestep data.
	/// </summary>
	public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
	{
		vtkCPExodusIIInSituReader_GetTimeStepRange_06(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCPExodusIIInSituReader_GetTimeStepRange_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the range of timesteps, represented as [0, numTimeSteps - 1]. Call
	/// UpdateInformation first to set this without reading any timestep data.
	/// </summary>
	public virtual void GetTimeStepRange(IntPtr _arg)
	{
		vtkCPExodusIIInSituReader_GetTimeStepRange_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCPExodusIIInSituReader_GetTimeStepValue_08(HandleRef pThis, int step);

	/// <summary>
	/// Get the floating point tag associated with the timestep at 'step'.
	/// </summary>
	public double GetTimeStepValue(int step)
	{
		return vtkCPExodusIIInSituReader_GetTimeStepValue_08(GetCppThis(), step);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCPExodusIIInSituReader_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCPExodusIIInSituReader_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCPExodusIIInSituReader_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCPExodusIIInSituReader_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCPExodusIIInSituReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCPExodusIIInSituReader NewInstance()
	{
		vtkCPExodusIIInSituReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCPExodusIIInSituReader_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCPExodusIIInSituReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCPExodusIIInSituReader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCPExodusIIInSituReader SafeDownCast(vtkObjectBase o)
	{
		vtkCPExodusIIInSituReader vtkCPExodusIIInSituReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCPExodusIIInSituReader_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCPExodusIIInSituReader2 = (vtkCPExodusIIInSituReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCPExodusIIInSituReader2.Register(null);
			}
		}
		return vtkCPExodusIIInSituReader2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCPExodusIIInSituReader_SetCurrentTimeStep_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the current timestep to read as a zero-based index.
	/// </summary>
	public virtual void SetCurrentTimeStep(int _arg)
	{
		vtkCPExodusIIInSituReader_SetCurrentTimeStep_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCPExodusIIInSituReader_SetFileName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the Exodus file to read.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkCPExodusIIInSituReader_SetFileName_15(GetCppThis(), _arg);
	}
}
