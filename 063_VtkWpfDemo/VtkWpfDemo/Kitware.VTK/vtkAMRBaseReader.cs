using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRBaseReader
/// </summary>
/// <remarks>
///    An abstract class that encapsulates common functionality for all AMR readers.
/// </remarks>
public abstract class vtkAMRBaseReader : vtkOverlappingAMRAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRBaseReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRBaseReader()
	{
		MRClassNameKey = "class vtkAMRBaseReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRBaseReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRBaseReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_EnableCachingOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get Reader caching property
	/// </summary>
	public virtual void EnableCachingOff()
	{
		vtkAMRBaseReader_EnableCachingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_EnableCachingOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get Reader caching property
	/// </summary>
	public virtual void EnableCachingOn()
	{
		vtkAMRBaseReader_EnableCachingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseReader_GetCellArrayName_03(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point or cell array with the given index in
	/// the input.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkAMRBaseReader_GetCellArrayName_03(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_GetCellArrayStatus_04(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkAMRBaseReader_GetCellArrayStatus_04(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseReader_GetCellDataArraySelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetCellDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseReader_GetCellDataArraySelection_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseReader_GetController_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a multiprocess-controller for reading in parallel.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseReader_GetController_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_GetEnableCaching_07(HandleRef pThis);

	/// <summary>
	/// Set/Get Reader caching property
	/// </summary>
	public virtual int GetEnableCaching()
	{
		return vtkAMRBaseReader_GetEnableCaching_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseReader_GetFileName_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the filename. Concrete instances of this class must implement
	/// the SetFileName method accordingly.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkAMRBaseReader_GetFileName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_GetNumberOfBlocks_09(HandleRef pThis);

	/// <summary>
	/// Returns the total number of blocks. Implemented by concrete instances.
	/// </summary>
	public virtual int GetNumberOfBlocks()
	{
		return vtkAMRBaseReader_GetNumberOfBlocks_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_GetNumberOfCellArrays_10(HandleRef pThis);

	/// <summary>
	/// Get the number of point or cell arrays available in the input.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkAMRBaseReader_GetNumberOfCellArrays_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRBaseReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRBaseReader_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRBaseReader_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRBaseReader_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_GetNumberOfLevels_13(HandleRef pThis);

	/// <summary>
	/// Returns the total number of levels. Implemented by concrete instances.
	/// </summary>
	public virtual int GetNumberOfLevels()
	{
		return vtkAMRBaseReader_GetNumberOfLevels_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_GetNumberOfPointArrays_14(HandleRef pThis);

	/// <summary>
	/// Get the number of point or cell arrays available in the input.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkAMRBaseReader_GetNumberOfPointArrays_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseReader_GetPointArrayName_15(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point or cell array with the given index in
	/// the input.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkAMRBaseReader_GetPointArrayName_15(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_GetPointArrayStatus_16(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkAMRBaseReader_GetPointArrayStatus_16(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseReader_GetPointDataArraySelection_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetPointDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseReader_GetPointDataArraySelection_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_Initialize_18(HandleRef pThis);

	/// <summary>
	/// Initializes the AMR reader.
	/// All concrete instances must call this method in their constructor.
	/// </summary>
	public void Initialize()
	{
		vtkAMRBaseReader_Initialize_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRBaseReader_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRBaseReader_IsCachingEnabled_20(HandleRef pThis);

	/// <summary>
	/// Set/Get Reader caching property
	/// </summary>
	public bool IsCachingEnabled()
	{
		return (vtkAMRBaseReader_IsCachingEnabled_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRBaseReader_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRBaseReader_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseReader_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRBaseReader NewInstance()
	{
		vtkAMRBaseReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseReader_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRBaseReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRBaseReader_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRBaseReader SafeDownCast(vtkObjectBase o)
	{
		vtkAMRBaseReader vtkAMRBaseReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRBaseReader_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRBaseReader2 = (vtkAMRBaseReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRBaseReader2.Register(null);
			}
		}
		return vtkAMRBaseReader2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_SetCellArrayStatus_24(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkAMRBaseReader_SetCellArrayStatus_24(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_SetController_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get a multiprocess-controller for reading in parallel.
	/// By default this parameter is set to nullptr by the constructor.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkAMRBaseReader_SetController_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_SetEnableCaching_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get Reader caching property
	/// </summary>
	public virtual void SetEnableCaching(int _arg)
	{
		vtkAMRBaseReader_SetEnableCaching_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_SetFileName_27(HandleRef pThis, string fileName);

	/// <summary>
	/// Set/Get the filename. Concrete instances of this class must implement
	/// the SetFileName method accordingly.
	/// </summary>
	public virtual void SetFileName(string fileName)
	{
		vtkAMRBaseReader_SetFileName_27(GetCppThis(), fileName);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_SetMaxLevel_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the level, up to which the blocks are loaded.
	/// </summary>
	public virtual void SetMaxLevel(int _arg)
	{
		vtkAMRBaseReader_SetMaxLevel_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRBaseReader_SetPointArrayStatus_29(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the point or cell array with the given name is to
	/// be read.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkAMRBaseReader_SetPointArrayStatus_29(GetCppThis(), name, status);
	}
}
