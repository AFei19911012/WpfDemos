using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMVR : WrappedObject
{
	public enum EnumType
	{
		/// <summary>enum member</summary>
		AE = 1,
		/// <summary>enum member</summary>
		AS = 2,
		/// <summary>enum member</summary>
		AT = 3,
		/// <summary>enum member</summary>
		CS = 4,
		/// <summary>enum member</summary>
		DA = 5,
		/// <summary>enum member</summary>
		DS = 6,
		/// <summary>enum member</summary>
		DT = 7,
		/// <summary>enum member</summary>
		FD = 8,
		/// <summary>enum member</summary>
		FL = 9,
		/// <summary>enum member</summary>
		IS = 10,
		/// <summary>enum member</summary>
		LO = 11,
		/// <summary>enum member</summary>
		LT = 12,
		/// <summary>enum member</summary>
		OB = 13,
		/// <summary>enum member</summary>
		OD = 14,
		/// <summary>enum member</summary>
		OF = 15,
		/// <summary>enum member</summary>
		OL = 16,
		/// <summary>enum member</summary>
		OV = 34,
		/// <summary>enum member</summary>
		OW = 17,
		/// <summary>enum member</summary>
		OX = 32,
		/// <summary>enum member</summary>
		PN = 18,
		/// <summary>enum member</summary>
		SH = 19,
		/// <summary>enum member</summary>
		SL = 20,
		/// <summary>enum member</summary>
		SQ = 21,
		/// <summary>enum member</summary>
		SS = 22,
		/// <summary>enum member</summary>
		ST = 23,
		/// <summary>enum member</summary>
		SV = 35,
		/// <summary>enum member</summary>
		TM = 24,
		/// <summary>enum member</summary>
		UC = 25,
		/// <summary>enum member</summary>
		UI = 26,
		/// <summary>enum member</summary>
		UL = 27,
		/// <summary>enum member</summary>
		UN = 28,
		/// <summary>enum member</summary>
		UR = 29,
		/// <summary>enum member</summary>
		US = 30,
		/// <summary>enum member</summary>
		UT = 31,
		/// <summary>enum member</summary>
		UV = 36,
		/// <summary>enum member</summary>
		XS = 33,
		/// <summary>enum member</summary>
		XX = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMVR";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMVR()
	{
		MRClassNameKey = "class vtkDICOMVR";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMVR"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMVR(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkDICOMVR_GetText_01(HandleRef pThis);

	public string GetText()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMVR_GetText_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMVR_GetType_02(HandleRef pThis);

	public int GetTypeWrapper()
	{
		return vtkDICOMVR_GetType_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMVR_HasLongVL_03(HandleRef pThis);

	public bool HasLongVL()
	{
		return (vtkDICOMVR_HasLongVL_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMVR_HasNumericValue_04(HandleRef pThis);

	public bool HasNumericValue()
	{
		return (vtkDICOMVR_HasNumericValue_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMVR_HasSingleValue_05(HandleRef pThis);

	public bool HasSingleValue()
	{
		return (vtkDICOMVR_HasSingleValue_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMVR_HasSpecificCharacterSet_06(HandleRef pThis);

	public bool HasSpecificCharacterSet()
	{
		return (vtkDICOMVR_HasSpecificCharacterSet_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMVR_HasTextValue_07(HandleRef pThis);

	public bool HasTextValue()
	{
		return (vtkDICOMVR_HasTextValue_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMVR_IsValid_08(HandleRef pThis);

	public bool IsValid()
	{
		return (vtkDICOMVR_IsValid_08(GetCppThis()) != 0) ? true : false;
	}
}
