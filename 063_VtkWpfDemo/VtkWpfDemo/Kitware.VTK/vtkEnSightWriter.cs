using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEnSightWriter
/// </summary>
/// <remarks>
///    write vtk unstructured grid data as an EnSight file
///
/// vtkEnSightWriter is a source object that writes binary
/// unstructured grid data files in EnSight format. See EnSight Manual for
/// format details
///
/// @warning
/// Binary files written on one system may not be readable on other systems.
/// Be sure to specify the endian-ness of the file when reading it into EnSight
/// </remarks>
public class vtkEnSightWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEnSightWriter()
	{
		MRClassNameKey = "class vtkEnSightWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEnSightWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///
	/// </summary>
	public new static vtkEnSightWriter New()
	{
		vtkEnSightWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///
	/// </summary>
	public vtkEnSightWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEnSightWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightWriter_GetBaseName_01(HandleRef pThis);

	/// <summary>
	/// Specify base name of EnSight data files to write.
	/// </summary>
	public virtual string GetBaseName()
	{
		return Marshal.PtrToStringAnsi(vtkEnSightWriter_GetBaseName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightWriter_GetBlockIDs_02(HandleRef pThis);

	/// <summary>
	/// set the array of Block ID's
	/// this class keeps a reference to the array and will not delete it
	/// </summary>
	public virtual IntPtr GetBlockIDs()
	{
		return vtkEnSightWriter_GetBlockIDs_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightWriter_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Specify the path and base name of the output files.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkEnSightWriter_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightWriter_GetGhostLevel_04(HandleRef pThis);

	/// <summary>
	/// Specify the number of ghost levels to include in output files
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkEnSightWriter_GetGhostLevel_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightWriter_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the input data or filter.
	/// </summary>
	public new virtual vtkUnstructuredGrid GetInput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightWriter_GetInput_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightWriter_GetNumberOfBlocks_06(HandleRef pThis);

	/// <summary>
	/// set the number of block ID's
	/// </summary>
	public virtual int GetNumberOfBlocks()
	{
		return vtkEnSightWriter_GetNumberOfBlocks_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnSightWriter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEnSightWriter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEnSightWriter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEnSightWriter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightWriter_GetPath_09(HandleRef pThis);

	/// <summary>
	/// Specify path of EnSight data files to write.
	/// </summary>
	public virtual string GetPath()
	{
		return Marshal.PtrToStringAnsi(vtkEnSightWriter_GetPath_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightWriter_GetProcessNumber_10(HandleRef pThis);

	/// <summary>
	/// Specify which process this writer is
	/// </summary>
	public virtual int GetProcessNumber()
	{
		return vtkEnSightWriter_GetProcessNumber_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightWriter_GetTimeStep_11(HandleRef pThis);

	/// <summary>
	/// Specify the Timestep that this data is for
	/// </summary>
	public virtual int GetTimeStep()
	{
		return vtkEnSightWriter_GetTimeStep_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEnSightWriter_GetTransientGeometry_12(HandleRef pThis);

	/// <summary>
	/// Specify whether the geometry changes each timestep
	/// if false, geometry is only written at timestep 0
	/// </summary>
	public virtual bool GetTransientGeometry()
	{
		return (vtkEnSightWriter_GetTransientGeometry_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightWriter_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEnSightWriter_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEnSightWriter_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEnSightWriter_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightWriter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEnSightWriter NewInstance()
	{
		vtkEnSightWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightWriter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEnSightWriter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEnSightWriter SafeDownCast(vtkObjectBase o)
	{
		vtkEnSightWriter vtkEnSightWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEnSightWriter_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEnSightWriter2 = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEnSightWriter2.Register(null);
			}
		}
		return vtkEnSightWriter2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetBaseName_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify base name of EnSight data files to write.
	/// </summary>
	public virtual void SetBaseName(string _arg)
	{
		vtkEnSightWriter_SetBaseName_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetBlockIDs_19(HandleRef pThis, IntPtr val);

	/// <summary>
	/// set the array of Block ID's
	/// this class keeps a reference to the array and will not delete it
	/// </summary>
	public virtual void SetBlockIDs(IntPtr val)
	{
		vtkEnSightWriter_SetBlockIDs_19(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetFileName_20(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the path and base name of the output files.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkEnSightWriter_SetFileName_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetGhostLevel_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of ghost levels to include in output files
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkEnSightWriter_SetGhostLevel_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetInputData_22(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Specify the input data or filter.
	/// </summary>
	public virtual void SetInputData(vtkUnstructuredGrid input)
	{
		vtkEnSightWriter_SetInputData_22(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetNumberOfBlocks_23(HandleRef pThis, int _arg);

	/// <summary>
	/// set the number of block ID's
	/// </summary>
	public virtual void SetNumberOfBlocks(int _arg)
	{
		vtkEnSightWriter_SetNumberOfBlocks_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetPath_24(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify path of EnSight data files to write.
	/// </summary>
	public virtual void SetPath(string _arg)
	{
		vtkEnSightWriter_SetPath_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetProcessNumber_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify which process this writer is
	/// </summary>
	public virtual void SetProcessNumber(int _arg)
	{
		vtkEnSightWriter_SetProcessNumber_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetTimeStep_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the Timestep that this data is for
	/// </summary>
	public virtual void SetTimeStep(int _arg)
	{
		vtkEnSightWriter_SetTimeStep_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_SetTransientGeometry_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether the geometry changes each timestep
	/// if false, geometry is only written at timestep 0
	/// </summary>
	public virtual void SetTransientGeometry(bool _arg)
	{
		vtkEnSightWriter_SetTransientGeometry_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_WriteCaseFile_28(HandleRef pThis, int TotalTimeSteps);

	/// <summary>
	/// Writes the case file that EnSight is capable of reading
	/// The other data files must be written before the case file
	/// and the input must be one of the time steps
	/// variables must be the same for all time steps or the case file will be
	/// missing variables
	/// </summary>
	public virtual void WriteCaseFile(int TotalTimeSteps)
	{
		vtkEnSightWriter_WriteCaseFile_28(GetCppThis(), TotalTimeSteps);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEnSightWriter_WriteSOSCaseFile_29(HandleRef pThis, int NumProcs);

	/// <summary>
	/// Writes the case file that EnSight is capable of reading
	/// The other data files must be written before the case file
	/// and the input must be one of the time steps
	/// variables must be the same for all time steps or the case file will be
	/// missing variables
	/// </summary>
	public virtual void WriteSOSCaseFile(int NumProcs)
	{
		vtkEnSightWriter_WriteSOSCaseFile_29(GetCppThis(), NumProcs);
	}
}
