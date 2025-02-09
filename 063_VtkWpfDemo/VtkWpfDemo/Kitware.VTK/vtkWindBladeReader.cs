using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWindBladeReader
/// </summary>
/// <remarks>
///    class for reading WindBlade data files
///
/// vtkWindBladeReader is a source object that reads WindBlade files
/// which are block binary files with tags before and after each block
/// giving the number of bytes within the block.  The number of data
/// variables dumped varies.  There are 3 output ports with the first
/// being a structured grid with irregular spacing in the Z dimension.
/// The second is an unstructured grid only read on process 0 and
/// used to represent the blade.  The third is also a structured grid
/// with irregular spacing on the Z dimension.  Only the first and
/// second output ports have time dependent data.
/// </remarks>
public class vtkWindBladeReader : vtkStructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWindBladeReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWindBladeReader()
	{
		MRClassNameKey = "class vtkWindBladeReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindBladeReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWindBladeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindBladeReader New()
	{
		vtkWindBladeReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindBladeReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWindBladeReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWindBladeReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkWindBladeReader_DisableAllPointArrays_01(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void DisableAllPointArrays()
	{
		vtkWindBladeReader_DisableAllPointArrays_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_EnableAllPointArrays_02(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void EnableAllPointArrays()
	{
		vtkWindBladeReader_EnableAllPointArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_GetBladeOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the reader's output
	/// </summary>
	public vtkUnstructuredGrid GetBladeOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindBladeReader_GetBladeOutput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_GetFieldOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the reader's output
	/// </summary>
	public vtkStructuredGrid GetFieldOutput()
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindBladeReader_GetFieldOutput_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGrid2 = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGrid2.Register(null);
			}
		}
		return vtkStructuredGrid2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_GetFilename_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetFilename()
	{
		return Marshal.PtrToStringAnsi(vtkWindBladeReader_GetFilename_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_GetGroundOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the reader's output
	/// </summary>
	public vtkStructuredGrid GetGroundOutput()
	{
		vtkStructuredGrid vtkStructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindBladeReader_GetGroundOutput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGrid2 = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGrid2.Register(null);
			}
		}
		return vtkStructuredGrid2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindBladeReader_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWindBladeReader_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindBladeReader_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWindBladeReader_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindBladeReader_GetNumberOfPointArrays_09(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkWindBladeReader_GetNumberOfPointArrays_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_GetPointArrayName_10(HandleRef pThis, int index);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkWindBladeReader_GetPointArrayName_10(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindBladeReader_GetPointArrayStatus_11(HandleRef pThis, string name);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkWindBladeReader_GetPointArrayStatus_11(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_GetSubExtent_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int[] GetSubExtent()
	{
		IntPtr intPtr = vtkWindBladeReader_GetSubExtent_12(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_GetSubExtent_13(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetSubExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkWindBladeReader_GetSubExtent_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_GetSubExtent_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetSubExtent(IntPtr _arg)
	{
		vtkWindBladeReader_GetSubExtent_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_GetWholeExtent_15(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkWindBladeReader_GetWholeExtent_15(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_GetWholeExtent_16(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkWindBladeReader_GetWholeExtent_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_GetWholeExtent_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetWholeExtent(IntPtr _arg)
	{
		vtkWindBladeReader_GetWholeExtent_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindBladeReader_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWindBladeReader_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindBladeReader_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWindBladeReader_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWindBladeReader NewInstance()
	{
		vtkWindBladeReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindBladeReader_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindBladeReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWindBladeReader SafeDownCast(vtkObjectBase o)
	{
		vtkWindBladeReader vtkWindBladeReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindBladeReader_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWindBladeReader2 = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWindBladeReader2.Register(null);
			}
		}
		return vtkWindBladeReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_SetFilename_23(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetFilename(string _arg)
	{
		vtkWindBladeReader_SetFilename_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_SetPointArrayStatus_24(HandleRef pThis, string name, int status);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkWindBladeReader_SetPointArrayStatus_24(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_SetSubExtent_25(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSubExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkWindBladeReader_SetSubExtent_25(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_SetSubExtent_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSubExtent(IntPtr _arg)
	{
		vtkWindBladeReader_SetSubExtent_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_SetWholeExtent_27(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkWindBladeReader_SetWholeExtent_27(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindBladeReader_SetWholeExtent_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetWholeExtent(IntPtr _arg)
	{
		vtkWindBladeReader_SetWholeExtent_28(GetCppThis(), _arg);
	}
}
