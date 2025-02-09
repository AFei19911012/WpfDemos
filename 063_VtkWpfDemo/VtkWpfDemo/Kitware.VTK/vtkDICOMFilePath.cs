using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMFilePath : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMFilePath";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMFilePath()
	{
		MRClassNameKey = "class vtkDICOMFilePath";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMFilePath"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMFilePath(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern string vtkDICOMFilePath_AsString_01(HandleRef pThis);

	public string AsString()
	{
		return vtkDICOMFilePath_AsString_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMFilePath_GetBack_02(HandleRef pThis);

	public string GetBack()
	{
		return vtkDICOMFilePath_GetBack_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMFilePath_GetExtension_03(HandleRef pThis);

	public string GetExtension()
	{
		return vtkDICOMFilePath_GetExtension_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMFilePath_GetRealPath_04(HandleRef pThis);

	public string GetRealPath()
	{
		return vtkDICOMFilePath_GetRealPath_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFilePath_IsDirectory_05(HandleRef pThis);

	public bool IsDirectory()
	{
		return (vtkDICOMFilePath_IsDirectory_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFilePath_IsEmpty_06(HandleRef pThis);

	public bool IsEmpty()
	{
		return (vtkDICOMFilePath_IsEmpty_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFilePath_IsRoot_07(HandleRef pThis);

	public bool IsRoot()
	{
		return (vtkDICOMFilePath_IsRoot_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFilePath_IsSpecial_08(HandleRef pThis);

	public bool IsSpecial()
	{
		return (vtkDICOMFilePath_IsSpecial_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMFilePath_IsSymlink_09(HandleRef pThis);

	public bool IsSymlink()
	{
		return (vtkDICOMFilePath_IsSymlink_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMFilePath_Join_10(HandleRef pThis, string second);

	public string Join(string second)
	{
		return vtkDICOMFilePath_Join_10(GetCppThis(), second);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMFilePath_Local_11(HandleRef pThis);

	public string Local()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMFilePath_Local_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMFilePath_PopBack_12(HandleRef pThis);

	public void PopBack()
	{
		vtkDICOMFilePath_PopBack_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMFilePath_PopExtension_13(HandleRef pThis);

	public void PopExtension()
	{
		vtkDICOMFilePath_PopExtension_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMFilePath_PushBack_14(HandleRef pThis, string path);

	public void PushBack(string path)
	{
		vtkDICOMFilePath_PushBack_14(GetCppThis(), path);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMFilePath_PushExtension_15(HandleRef pThis, string path);

	public void PushExtension(string path)
	{
		vtkDICOMFilePath_PushExtension_15(GetCppThis(), path);
	}
}
