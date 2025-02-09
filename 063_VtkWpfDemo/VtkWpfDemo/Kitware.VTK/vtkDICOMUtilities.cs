using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMUtilities : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMUtilities";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMUtilities()
	{
		MRClassNameKey = "class vtkDICOMUtilities";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMUtilities"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMUtilities New()
	{
		vtkDICOMUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMUtilities()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMUtilities_CompareUIDs_01(string u1, string u2);

	public static int CompareUIDs(string u1, string u2)
	{
		return vtkDICOMUtilities_CompareUIDs_01(u1, u2);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMUtilities_ConvertDateTime_02(string datetime);

	public static long ConvertDateTime(string datetime)
	{
		return vtkDICOMUtilities_ConvertDateTime_02(datetime);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMUtilities_GenerateDateTime_03(string zone);

	public static string GenerateDateTime(string zone)
	{
		return vtkDICOMUtilities_GenerateDateTime_03(zone);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMUtilities_GenerateDateTime_04(long microsecs, string zone);

	public static string GenerateDateTime(long microsecs, string zone)
	{
		return vtkDICOMUtilities_GenerateDateTime_04(microsecs, zone);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMUtilities_GenerateUID_05(HandleRef tag);

	public static string GenerateUID(vtkDICOMTag tag)
	{
		return vtkDICOMUtilities_GenerateUID_05(tag?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMUtilities_GenerateUIDs_06(HandleRef tag, HandleRef uids);

	public static void GenerateUIDs(vtkDICOMTag tag, vtkStringArray uids)
	{
		vtkDICOMUtilities_GenerateUIDs_06(tag?.GetCppThis() ?? default(HandleRef), uids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkDICOMUtilities_GetCIDFromUID_07(HandleRef pThis, string uid);

	public ushort GetCIDFromUID(string uid)
	{
		return vtkDICOMUtilities_GetCIDFromUID_07(GetCppThis(), uid);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUtilities_GetImplementationClassUID_08();

	public static string GetImplementationClassUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMUtilities_GetImplementationClassUID_08());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUtilities_GetImplementationVersionName_09();

	public static string GetImplementationVersionName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMUtilities_GetImplementationVersionName_09());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMUtilities_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMUtilities_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMUtilities_GetNumberOfGenerationsFromBaseType_11(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMUtilities_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUtilities_GetUIDName_12(string uid);

	public static string GetUIDName(string uid)
	{
		return Marshal.PtrToStringAnsi(vtkDICOMUtilities_GetUIDName_12(uid));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUtilities_GetUIDPrefix_13();

	public static string GetUIDPrefix()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMUtilities_GetUIDPrefix_13());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMUtilities_GetUTC_14(IntPtr offset);

	public static long GetUTC(IntPtr offset)
	{
		return vtkDICOMUtilities_GetUTC_14(offset);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMUtilities_GetUniversalTime_15();

	public static long GetUniversalTime()
	{
		return vtkDICOMUtilities_GetUniversalTime_15();
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMUtilities_IsA_16(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMUtilities_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMUtilities_IsDICOMFile_17(string filename);

	public static bool IsDICOMFile(string filename)
	{
		return (vtkDICOMUtilities_IsDICOMFile_17(filename) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMUtilities_IsTypeOf_18(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMUtilities_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMUtilities_IsValidUTF8_19(string text, ulong l);

	public static bool IsValidUTF8(string text, ulong l)
	{
		return (vtkDICOMUtilities_IsValidUTF8_19(text, l) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUtilities_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMUtilities NewInstance()
	{
		vtkDICOMUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMUtilities_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMUtilities_PackUnsignedInt_22(uint i, IntPtr cp);

	public static void PackUnsignedInt(uint i, IntPtr cp)
	{
		vtkDICOMUtilities_PackUnsignedInt_22(i, cp);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMUtilities_PatternMatches_23(string pattern, string val);

	public static bool PatternMatches(string pattern, string val)
	{
		return (vtkDICOMUtilities_PatternMatches_23(pattern, val) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMUtilities_PatternMatches_24(string pattern, ulong pl, string val, ulong vl);

	public static bool PatternMatches(string pattern, ulong pl, string val, ulong vl)
	{
		return (vtkDICOMUtilities_PatternMatches_24(pattern, pl, val, vl) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUtilities_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMUtilities SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMUtilities vtkDICOMUtilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMUtilities_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMUtilities2 = (vtkDICOMUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMUtilities2.Register(null);
			}
		}
		return vtkDICOMUtilities2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMUtilities_SetImplementationClassUID_26(string uid);

	public static void SetImplementationClassUID(string uid)
	{
		vtkDICOMUtilities_SetImplementationClassUID_26(uid);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMUtilities_SetImplementationVersionName_27(string name);

	public static void SetImplementationVersionName(string name)
	{
		vtkDICOMUtilities_SetImplementationVersionName_27(name);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMUtilities_SetUIDPrefix_28(string prefix);

	public static void SetUIDPrefix(string prefix)
	{
		vtkDICOMUtilities_SetUIDPrefix_28(prefix);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMUtilities_UnpackUnsignedInt_29(IntPtr cp);

	public static uint UnpackUnsignedInt(IntPtr cp)
	{
		return vtkDICOMUtilities_UnpackUnsignedInt_29(cp);
	}
}
