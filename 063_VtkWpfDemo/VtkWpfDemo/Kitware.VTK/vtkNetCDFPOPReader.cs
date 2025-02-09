using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNetCDFPOPReader
/// </summary>
/// <remarks>
///    read NetCDF files
/// .Author Joshua Wu 09.15.2009
///
/// vtkNetCDFPOPReader is a source object that reads NetCDF files.
/// It should be able to read most any NetCDF file that wants to output a
/// rectilinear grid.  The ordering of the variables is changed such that
/// the NetCDF x, y, z directions correspond to the vtkRectilinearGrid
/// z, y, x directions, respectively.  The striding is done with
/// respect to the vtkRectilinearGrid ordering.  Additionally, the
/// z coordinates of the vtkRectilinearGrid are negated so that the
/// first slice/plane has the highest z-value and the last slice/plane
/// has the lowest z-value.
/// </remarks>
public class vtkNetCDFPOPReader : vtkRectilinearGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFPOPReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNetCDFPOPReader()
	{
		MRClassNameKey = "class vtkNetCDFPOPReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFPOPReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNetCDFPOPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFPOPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFPOPReader New()
	{
		vtkNetCDFPOPReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFPOPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNetCDFPOPReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNetCDFPOPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFPOPReader_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// The file to open
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFPOPReader_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFPOPReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNetCDFPOPReader_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFPOPReader_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNetCDFPOPReader_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFPOPReader_GetNumberOfVariableArrays_04(HandleRef pThis);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual int GetNumberOfVariableArrays()
	{
		return vtkNetCDFPOPReader_GetNumberOfVariableArrays_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFPOPReader_GetStride_05(HandleRef pThis);

	/// <summary>
	/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
	/// </summary>
	public virtual int[] GetStride()
	{
		IntPtr intPtr = vtkNetCDFPOPReader_GetStride_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFPOPReader_GetStride_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
	/// </summary>
	public virtual void GetStride(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkNetCDFPOPReader_GetStride_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFPOPReader_GetStride_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
	/// </summary>
	public virtual void GetStride(IntPtr _arg)
	{
		vtkNetCDFPOPReader_GetStride_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFPOPReader_GetVariableArrayName_08(HandleRef pThis, int index);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual string GetVariableArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFPOPReader_GetVariableArrayName_08(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFPOPReader_GetVariableArrayStatus_09(HandleRef pThis, string name);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual int GetVariableArrayStatus(string name)
	{
		return vtkNetCDFPOPReader_GetVariableArrayStatus_09(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFPOPReader_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNetCDFPOPReader_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFPOPReader_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNetCDFPOPReader_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFPOPReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNetCDFPOPReader NewInstance()
	{
		vtkNetCDFPOPReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFPOPReader_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFPOPReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFPOPReader SafeDownCast(vtkObjectBase o)
	{
		vtkNetCDFPOPReader vtkNetCDFPOPReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFPOPReader_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNetCDFPOPReader2 = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNetCDFPOPReader2.Register(null);
			}
		}
		return vtkNetCDFPOPReader2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFPOPReader_SetFileName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// The file to open
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkNetCDFPOPReader_SetFileName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFPOPReader_SetStride_16(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
	/// </summary>
	public virtual void SetStride(int _arg1, int _arg2, int _arg3)
	{
		vtkNetCDFPOPReader_SetStride_16(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFPOPReader_SetStride_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
	/// </summary>
	public virtual void SetStride(IntPtr _arg)
	{
		vtkNetCDFPOPReader_SetStride_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFPOPReader_SetVariableArrayStatus_18(HandleRef pThis, string name, int status);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual void SetVariableArrayStatus(string name, int status)
	{
		vtkNetCDFPOPReader_SetVariableArrayStatus_18(GetCppThis(), name, status);
	}
}
