using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMCharacterSet : WrappedObject
{
	public enum EnumType
	{
		/// <summary>enum member</summary>
		GB18030 = 65,
		/// <summary>enum member</summary>
		GBK = 66,
		/// <summary>enum member</summary>
		ISO_2022_IR_100 = 40,
		/// <summary>enum member</summary>
		ISO_2022_IR_101 = 41,
		/// <summary>enum member</summary>
		ISO_2022_IR_109 = 42,
		/// <summary>enum member</summary>
		ISO_2022_IR_110 = 43,
		/// <summary>enum member</summary>
		ISO_2022_IR_126 = 46,
		/// <summary>enum member</summary>
		ISO_2022_IR_127 = 45,
		/// <summary>enum member</summary>
		ISO_2022_IR_13 = 33,
		/// <summary>enum member</summary>
		ISO_2022_IR_138 = 47,
		/// <summary>enum member</summary>
		ISO_2022_IR_144 = 44,
		/// <summary>enum member</summary>
		ISO_2022_IR_148 = 48,
		/// <summary>enum member</summary>
		ISO_2022_IR_149 = 56,
		/// <summary>enum member</summary>
		ISO_2022_IR_159 = 36,
		/// <summary>enum member</summary>
		ISO_2022_IR_166 = 50,
		/// <summary>enum member</summary>
		ISO_2022_IR_58 = 57,
		/// <summary>enum member</summary>
		ISO_2022_IR_6 = 32,
		/// <summary>enum member</summary>
		ISO_2022_IR_87 = 34,
		/// <summary>enum member</summary>
		ISO_IR_100 = 8,
		/// <summary>enum member</summary>
		ISO_IR_101 = 9,
		/// <summary>enum member</summary>
		ISO_IR_109 = 10,
		/// <summary>enum member</summary>
		ISO_IR_110 = 11,
		/// <summary>enum member</summary>
		ISO_IR_126 = 14,
		/// <summary>enum member</summary>
		ISO_IR_127 = 13,
		/// <summary>enum member</summary>
		ISO_IR_13 = 1,
		/// <summary>enum member</summary>
		ISO_IR_138 = 15,
		/// <summary>enum member</summary>
		ISO_IR_144 = 12,
		/// <summary>enum member</summary>
		ISO_IR_148 = 16,
		/// <summary>enum member</summary>
		ISO_IR_166 = 18,
		/// <summary>enum member</summary>
		ISO_IR_192 = 64,
		/// <summary>enum member</summary>
		ISO_IR_6 = 0,
		/// <summary>enum member</summary>
		Unknown = 255,
		/// <summary>enum member</summary>
		X_BIG5 = 67,
		/// <summary>enum member</summary>
		X_CP1250 = 80,
		/// <summary>enum member</summary>
		X_CP1251 = 81,
		/// <summary>enum member</summary>
		X_CP1252 = 82,
		/// <summary>enum member</summary>
		X_CP1253 = 83,
		/// <summary>enum member</summary>
		X_CP1254 = 84,
		/// <summary>enum member</summary>
		X_CP1255 = 85,
		/// <summary>enum member</summary>
		X_CP1256 = 86,
		/// <summary>enum member</summary>
		X_CP1257 = 87,
		/// <summary>enum member</summary>
		X_CP874 = 76,
		/// <summary>enum member</summary>
		X_EUCJP = 69,
		/// <summary>enum member</summary>
		X_EUCKR = 24,
		/// <summary>enum member</summary>
		X_GB2312 = 25,
		/// <summary>enum member</summary>
		X_KOI8 = 90,
		/// <summary>enum member</summary>
		X_LATIN10 = 22,
		/// <summary>enum member</summary>
		X_LATIN6 = 17,
		/// <summary>enum member</summary>
		X_LATIN7 = 19,
		/// <summary>enum member</summary>
		X_LATIN8 = 20,
		/// <summary>enum member</summary>
		X_LATIN9 = 21,
		/// <summary>enum member</summary>
		X_SJIS = 70
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMCharacterSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMCharacterSet()
	{
		MRClassNameKey = "class vtkDICOMCharacterSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMCharacterSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMCharacterSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern string vtkDICOMCharacterSet_CaseFoldedUTF8_01(HandleRef pThis, string text, ulong l);

	public string CaseFoldedUTF8(string text, ulong l)
	{
		return vtkDICOMCharacterSet_CaseFoldedUTF8_01(GetCppThis(), text, l);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_CaseFoldedUTF8_02(HandleRef pThis, string text);

	public string CaseFoldedUTF8(string text)
	{
		return vtkDICOMCharacterSet_CaseFoldedUTF8_02(GetCppThis(), text);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_ConvertToUTF8_03(HandleRef pThis, string text, ulong l);

	public string ConvertToUTF8(string text, ulong l)
	{
		return vtkDICOMCharacterSet_ConvertToUTF8_03(GetCppThis(), text, l);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMCharacterSet_CountBackslashes_04(HandleRef pThis, string text, ulong l);

	public uint CountBackslashes(string text, ulong l)
	{
		return vtkDICOMCharacterSet_CountBackslashes_04(GetCppThis(), text, l);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_FromUTF8_05(HandleRef pThis, string text, ulong l, IntPtr lp);

	public string FromUTF8(string text, ulong l, IntPtr lp)
	{
		return vtkDICOMCharacterSet_FromUTF8_05(GetCppThis(), text, l, lp);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_FromUTF8_06(HandleRef pThis, string text);

	public string FromUTF8(string text)
	{
		return vtkDICOMCharacterSet_FromUTF8_06(GetCppThis(), text);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_GetCharacterSetString_07(HandleRef pThis);

	public string GetCharacterSetString()
	{
		return vtkDICOMCharacterSet_GetCharacterSetString_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMCharacterSet vtkDICOMCharacterSet_GetGlobalDefault_08();

	public static vtkDICOMCharacterSet GetGlobalDefault()
	{
		return vtkDICOMCharacterSet_GetGlobalDefault_08();
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMCharacterSet_GetGlobalOverride_09();

	public static bool GetGlobalOverride()
	{
		return (vtkDICOMCharacterSet_GetGlobalOverride_09() != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMCharacterSet_GetKey_10(HandleRef pThis);

	public byte GetKey()
	{
		return vtkDICOMCharacterSet_GetKey_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCharacterSet_GlobalOverrideOff_11();

	public static void GlobalOverrideOff()
	{
		vtkDICOMCharacterSet_GlobalOverrideOff_11();
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCharacterSet_GlobalOverrideOn_12();

	public static void GlobalOverrideOn()
	{
		vtkDICOMCharacterSet_GlobalOverrideOn_12();
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMCharacterSet_IsBiDirectional_13(HandleRef pThis);

	public bool IsBiDirectional()
	{
		return (vtkDICOMCharacterSet_IsBiDirectional_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMCharacterSet_IsISO2022_14(HandleRef pThis);

	public bool IsISO2022()
	{
		return (vtkDICOMCharacterSet_IsISO2022_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMCharacterSet_IsISO8859_15(HandleRef pThis);

	public bool IsISO8859()
	{
		return (vtkDICOMCharacterSet_IsISO8859_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDICOMCharacterSet_NextBackslash_16(HandleRef pThis, string text, string end);

	public ulong NextBackslash(string text, string end)
	{
		return vtkDICOMCharacterSet_NextBackslash_16(GetCppThis(), text, end);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCharacterSet_SetGlobalDefault_17(vtkDICOMCharacterSet cs);

	public static void SetGlobalDefault(vtkDICOMCharacterSet cs)
	{
		vtkDICOMCharacterSet_SetGlobalDefault_17(cs);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCharacterSet_SetGlobalOverride_18(byte b);

	public static void SetGlobalOverride(bool b)
	{
		vtkDICOMCharacterSet_SetGlobalOverride_18((byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_ToSafeUTF8_19(HandleRef pThis, string text, ulong l);

	public string ToSafeUTF8(string text, ulong l)
	{
		return vtkDICOMCharacterSet_ToSafeUTF8_19(GetCppThis(), text, l);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_ToSafeUTF8_20(HandleRef pThis, string text);

	public string ToSafeUTF8(string text)
	{
		return vtkDICOMCharacterSet_ToSafeUTF8_20(GetCppThis(), text);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_ToUTF8_21(HandleRef pThis, string text, ulong l, IntPtr lp);

	public string ToUTF8(string text, ulong l, IntPtr lp)
	{
		return vtkDICOMCharacterSet_ToUTF8_21(GetCppThis(), text, l, lp);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMCharacterSet_ToUTF8_22(HandleRef pThis, string text);

	public string ToUTF8(string text)
	{
		return vtkDICOMCharacterSet_ToUTF8_22(GetCppThis(), text);
	}
}
