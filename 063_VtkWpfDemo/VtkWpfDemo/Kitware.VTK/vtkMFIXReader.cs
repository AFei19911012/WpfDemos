using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMFIXReader
/// </summary>
/// <remarks>
///    reads a dataset in MFIX file format
///
/// vtkMFIXReader creates an unstructured grid dataset. It reads a restart
/// file and a set of sp files.  The restart file contains the mesh
/// information.  MFIX meshes are either cylindrical or rectilinear, but
/// this reader will convert them to an unstructured grid.  The sp files
/// contain transient data for the cells.  Each sp file has one or more
/// variables stored inside it.
///
/// @par Thanks:
/// Thanks to Phil Nicoletti and Brian Dotson at the National Energy
/// Technology Laboratory who developed this class.
/// Please address all comments to Brian Dotson (brian.dotson@netl.doe.gov)
///
/// </remarks>
/// <seealso>
///
/// vtkGAMBITReader
/// </seealso>
public class vtkMFIXReader : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMFIXReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMFIXReader()
	{
		MRClassNameKey = "class vtkMFIXReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMFIXReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMFIXReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMFIXReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMFIXReader New()
	{
		vtkMFIXReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMFIXReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMFIXReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMFIXReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_DisableAllCellArrays_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off all cell arrays.
	/// </summary>
	public void DisableAllCellArrays()
	{
		vtkMFIXReader_DisableAllCellArrays_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_EnableAllCellArrays_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off all cell arrays.
	/// </summary>
	public void EnableAllCellArrays()
	{
		vtkMFIXReader_EnableAllCellArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMFIXReader_GetCellArrayName_03(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the cell array with the given index in
	/// the input.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkMFIXReader_GetCellArrayName_03(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_GetCellArrayStatus_04(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the cell array with the given name is to
	/// be read.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkMFIXReader_GetCellArrayStatus_04(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_GetCellDataRange_05(HandleRef pThis, int cellComp, IntPtr min, IntPtr max);

	/// <summary>
	/// Get the range of cell data.
	/// </summary>
	public void GetCellDataRange(int cellComp, IntPtr min, IntPtr max)
	{
		vtkMFIXReader_GetCellDataRange_05(GetCppThis(), cellComp, min, max);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMFIXReader_GetFileName_06(HandleRef pThis);

	/// <summary>
	/// Specify the file name of the MFIX Restart data file to read.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMFIXReader_GetFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_GetNumberOfCellArrays_07(HandleRef pThis);

	/// <summary>
	/// Get the number of cell arrays available in the input.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkMFIXReader_GetNumberOfCellArrays_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_GetNumberOfCellFields_08(HandleRef pThis);

	/// <summary>
	/// Get the number of data components at the nodes and cells.
	/// </summary>
	public virtual int GetNumberOfCellFields()
	{
		return vtkMFIXReader_GetNumberOfCellFields_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_GetNumberOfCells_09(HandleRef pThis);

	/// <summary>
	/// Get the total number of cells. The number of cells is only valid after a
	/// successful read of the data file is performed.
	/// </summary>
	public virtual int GetNumberOfCells()
	{
		return vtkMFIXReader_GetNumberOfCells_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMFIXReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMFIXReader_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMFIXReader_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMFIXReader_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_GetNumberOfPoints_12(HandleRef pThis);

	/// <summary>
	/// Get the total number of nodes. The number of nodes is only valid after a
	/// successful read of the data file is performed.
	/// </summary>
	public virtual int GetNumberOfPoints()
	{
		return vtkMFIXReader_GetNumberOfPoints_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_GetNumberOfTimeSteps_13(HandleRef pThis);

	/// <summary>
	/// Returns the number of timesteps.
	/// </summary>
	public virtual int GetNumberOfTimeSteps()
	{
		return vtkMFIXReader_GetNumberOfTimeSteps_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_GetTimeStep_14(HandleRef pThis);

	/// <summary>
	/// Which TimeStep to read.
	/// </summary>
	public virtual int GetTimeStep()
	{
		return vtkMFIXReader_GetTimeStep_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMFIXReader_GetTimeStepRange_15(HandleRef pThis);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public virtual int[] GetTimeStepRange()
	{
		IntPtr intPtr = vtkMFIXReader_GetTimeStepRange_15(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_GetTimeStepRange_16(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
	{
		vtkMFIXReader_GetTimeStepRange_16(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_GetTimeStepRange_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public virtual void GetTimeStepRange(IntPtr _arg)
	{
		vtkMFIXReader_GetTimeStepRange_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMFIXReader_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMFIXReader_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMFIXReader_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMFIXReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMFIXReader NewInstance()
	{
		vtkMFIXReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMFIXReader_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMFIXReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMFIXReader SafeDownCast(vtkObjectBase o)
	{
		vtkMFIXReader vtkMFIXReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMFIXReader_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMFIXReader2 = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMFIXReader2.Register(null);
			}
		}
		return vtkMFIXReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_SetCellArrayStatus_23(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the cell array with the given name is to
	/// be read.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkMFIXReader_SetCellArrayStatus_23(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_SetFileName_24(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the file name of the MFIX Restart data file to read.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkMFIXReader_SetFileName_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_SetTimeStep_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Which TimeStep to read.
	/// </summary>
	public virtual void SetTimeStep(int _arg)
	{
		vtkMFIXReader_SetTimeStep_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_SetTimeStepRange_26(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public virtual void SetTimeStepRange(int _arg1, int _arg2)
	{
		vtkMFIXReader_SetTimeStepRange_26(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMFIXReader_SetTimeStepRange_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Which TimeStepRange to read
	/// </summary>
	public void SetTimeStepRange(IntPtr _arg)
	{
		vtkMFIXReader_SetTimeStepRange_27(GetCppThis(), _arg);
	}
}
