using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMFile : WrappedObject
{
	public enum Code
	{
		/// <summary>enum member</summary>
		AccessDenied = 2,
		/// <summary>enum member</summary>
		FileIsDirectory = 3,
		/// <summary>enum member</summary>
		FileNotFound = 5,
		/// <summary>enum member</summary>
		Good = 0,
		/// <summary>enum member</summary>
		ImpossiblePath = 4,
		/// <summary>enum member</summary>
		OutOfSpace = 6,
		/// <summary>enum member</summary>
		UnknownError = 1
	}

	public enum Mode
	{
		/// <summary>enum member</summary>
		In,
		/// <summary>enum member</summary>
		Out
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMFile";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMFile()
	{
		MRClassNameKey = "class vtkDICOMFile";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMFile"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMFile(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMFile_Access_01(string filename, Mode mode);

	public static int Access(string filename, Mode mode)
	{
		return vtkDICOMFile_Access_01(filename, mode);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMFile_Close_02(HandleRef pThis);

	public void Close()
	{
		vtkDICOMFile_Close_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFile_EndOfFile_03(HandleRef pThis);

	public bool EndOfFile()
	{
		return (vtkDICOMFile_EndOfFile_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMFile_GetError_04(HandleRef pThis);

	public int GetError()
	{
		return vtkDICOMFile_GetError_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDICOMFile_GetSize_05(HandleRef pThis);

	public ulong GetSize()
	{
		return vtkDICOMFile_GetSize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDICOMFile_Read_06(HandleRef pThis, IntPtr data, ulong size);

	public ulong Read(IntPtr data, ulong size)
	{
		return vtkDICOMFile_Read_06(GetCppThis(), data, size);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMFile_Remove_07(string filename);

	public static int Remove(string filename)
	{
		return vtkDICOMFile_Remove_07(filename);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFile_SameFile_08(string file1, string file2);

	public static bool SameFile(string file1, string file2)
	{
		return (vtkDICOMFile_SameFile_08(file1, file2) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFile_SetPosition_09(HandleRef pThis, ulong offset);

	public bool SetPosition(ulong offset)
	{
		return (vtkDICOMFile_SetPosition_09(GetCppThis(), offset) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDICOMFile_Write_10(HandleRef pThis, IntPtr data, ulong size);

	public ulong Write(IntPtr data, ulong size)
	{
		return vtkDICOMFile_Write_10(GetCppThis(), data, size);
	}
}
