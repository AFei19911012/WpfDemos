using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMFileDirectory : WrappedObject
{
	public enum Code
	{
		/// <summary>enum member</summary>
		AccessDenied = 2,
		/// <summary>enum member</summary>
		FileNotFound = 5,
		/// <summary>enum member</summary>
		Good = 0,
		/// <summary>enum member</summary>
		ImpossiblePath = 4,
		/// <summary>enum member</summary>
		OutOfSpace = 6,
		/// <summary>enum member</summary>
		Reserved = 3,
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMFileDirectory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMFileDirectory()
	{
		MRClassNameKey = "class vtkDICOMFileDirectory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMFileDirectory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMFileDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkDICOMFileDirectory_Access_01(string dirname, Mode mode);

	public static int Access(string dirname, Mode mode)
	{
		return vtkDICOMFileDirectory_Access_01(dirname, mode);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMFileDirectory_Create_02(string dirname);

	public static int Create(string dirname)
	{
		return vtkDICOMFileDirectory_Create_02(dirname);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMFileDirectory_GetEntry_03(HandleRef pThis, int i);

	public string GetEntry(int i)
	{
		return Marshal.PtrToStringAnsi(vtkDICOMFileDirectory_GetEntry_03(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMFileDirectory_GetError_04(HandleRef pThis);

	public int GetError()
	{
		return vtkDICOMFileDirectory_GetError_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMFileDirectory_GetNumberOfEntries_05(HandleRef pThis);

	public int GetNumberOfEntries()
	{
		return vtkDICOMFileDirectory_GetNumberOfEntries_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFileDirectory_IsBroken_06(HandleRef pThis, int i);

	public bool IsBroken(int i)
	{
		return (vtkDICOMFileDirectory_IsBroken_06(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFileDirectory_IsDirectory_07(HandleRef pThis, int i);

	public bool IsDirectory(int i)
	{
		return (vtkDICOMFileDirectory_IsDirectory_07(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFileDirectory_IsHidden_08(HandleRef pThis, int i);

	public bool IsHidden(int i)
	{
		return (vtkDICOMFileDirectory_IsHidden_08(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFileDirectory_IsSpecial_09(HandleRef pThis, int i);

	public bool IsSpecial(int i)
	{
		return (vtkDICOMFileDirectory_IsSpecial_09(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFileDirectory_IsSymlink_10(HandleRef pThis, int i);

	public bool IsSymlink(int i)
	{
		return (vtkDICOMFileDirectory_IsSymlink_10(GetCppThis(), i) != 0) ? true : false;
	}
}
