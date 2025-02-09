using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMValue : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMValue";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMValue()
	{
		MRClassNameKey = "class vtkDICOMValue";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMValue"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMValue(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkDICOMValue_AllocateCharData_01(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public string AllocateCharData(vtkDICOMVR vr, ulong vn)
	{
		return Marshal.PtrToStringAnsi(vtkDICOMValue_AllocateCharData_01(GetCppThis(), vr, vn));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateCharData_02(HandleRef pThis, vtkDICOMVR vr, vtkDICOMCharacterSet cs, ulong vn);

	public string AllocateCharData(vtkDICOMVR vr, vtkDICOMCharacterSet cs, ulong vn)
	{
		return Marshal.PtrToStringAnsi(vtkDICOMValue_AllocateCharData_02(GetCppThis(), vr, cs, vn));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateDoubleData_03(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateDoubleData(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateDoubleData_03(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateFloatData_04(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateFloatData(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateFloatData_04(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateInt64Data_05(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateInt64Data(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateInt64Data_05(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateIntData_06(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateIntData(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateIntData_06(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateMultiplexData_07(HandleRef pThis, vtkDICOMVR vr, ulong vn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue AllocateMultiplexData(vtkDICOMVR vr, ulong vn)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_AllocateMultiplexData_07(GetCppThis(), vr, vn, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateSequenceData_08(HandleRef pThis, vtkDICOMVR vr, ulong vn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem AllocateSequenceData(vtkDICOMVR vr, ulong vn)
	{
		vtkDICOMItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_AllocateSequenceData_08(GetCppThis(), vr, vn, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateShortData_09(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateShortData(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateShortData_09(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateTagData_10(HandleRef pThis, vtkDICOMVR vr, ulong vn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag AllocateTagData(vtkDICOMVR vr, ulong vn)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_AllocateTagData_10(GetCppThis(), vr, vn, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateUnsignedCharData_11(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateUnsignedCharData(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateUnsignedCharData_11(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateUnsignedInt64Data_12(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateUnsignedInt64Data(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateUnsignedInt64Data_12(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateUnsignedIntData_13(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateUnsignedIntData(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateUnsignedIntData_13(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AllocateUnsignedShortData_14(HandleRef pThis, vtkDICOMVR vr, ulong vn);

	public IntPtr AllocateUnsignedShortData(vtkDICOMVR vr, ulong vn)
	{
		return vtkDICOMValue_AllocateUnsignedShortData_14(GetCppThis(), vr, vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMValue_AppendValueToSafeUTF8String_15(HandleRef pThis, string str, ulong i);

	public void AppendValueToSafeUTF8String(string str, ulong i)
	{
		vtkDICOMValue_AppendValueToSafeUTF8String_15(GetCppThis(), str, i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMValue_AppendValueToString_16(HandleRef pThis, string str, ulong i);

	public void AppendValueToString(string str, ulong i)
	{
		vtkDICOMValue_AppendValueToString_16(GetCppThis(), str, i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMValue_AppendValueToUTF8String_17(HandleRef pThis, string str, ulong i);

	public void AppendValueToUTF8String(string str, ulong i)
	{
		vtkDICOMValue_AppendValueToUTF8String_17(GetCppThis(), str, i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMValue_AsDouble_18(HandleRef pThis);

	public double AsDouble()
	{
		return vtkDICOMValue_AsDouble_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDICOMValue_AsFloat_19(HandleRef pThis);

	public float AsFloat()
	{
		return vtkDICOMValue_AsFloat_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMValue_AsInt_20(HandleRef pThis);

	public int AsInt()
	{
		return vtkDICOMValue_AsInt_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMValue_AsInt64_21(HandleRef pThis);

	public long AsInt64()
	{
		return vtkDICOMValue_AsInt64_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AsItem_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem AsItem()
	{
		vtkDICOMItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_AsItem_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern short vtkDICOMValue_AsShort_23(HandleRef pThis);

	public short AsShort()
	{
		return vtkDICOMValue_AsShort_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMValue_AsString_24(HandleRef pThis);

	public string AsString()
	{
		return vtkDICOMValue_AsString_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_AsTag_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag AsTag()
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_AsTag_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMValue_AsUTF8String_26(HandleRef pThis);

	public string AsUTF8String()
	{
		return vtkDICOMValue_AsUTF8String_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMValue_AsUnsignedChar_27(HandleRef pThis);

	public byte AsUnsignedChar()
	{
		return vtkDICOMValue_AsUnsignedChar_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMValue_AsUnsignedInt_28(HandleRef pThis);

	public uint AsUnsignedInt()
	{
		return vtkDICOMValue_AsUnsignedInt_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDICOMValue_AsUnsignedInt64_29(HandleRef pThis);

	public ulong AsUnsignedInt64()
	{
		return vtkDICOMValue_AsUnsignedInt64_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkDICOMValue_AsUnsignedShort_30(HandleRef pThis);

	public ushort AsUnsignedShort()
	{
		return vtkDICOMValue_AsUnsignedShort_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMValue_Clear_31(HandleRef pThis);

	public void Clear()
	{
		vtkDICOMValue_Clear_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMValue_ComputeNumberOfValuesForCharData_32(HandleRef pThis);

	public void ComputeNumberOfValuesForCharData()
	{
		vtkDICOMValue_ComputeNumberOfValuesForCharData_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_FromUTF8String_33(vtkDICOMVR vr, vtkDICOMCharacterSet cs, string v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public static vtkDICOMValue FromUTF8String(vtkDICOMVR vr, vtkDICOMCharacterSet cs, string v)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_FromUTF8String_33(vr, cs, v, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetCharData_34(HandleRef pThis);

	public string GetCharData()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMValue_GetCharData_34(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMCharacterSet vtkDICOMValue_GetCharacterSet_35(HandleRef pThis);

	public vtkDICOMCharacterSet GetCharacterSet()
	{
		return vtkDICOMValue_GetCharacterSet_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMValue_GetDouble_36(HandleRef pThis, ulong i);

	public double GetDouble(ulong i)
	{
		return vtkDICOMValue_GetDouble_36(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetDoubleData_37(HandleRef pThis);

	public IntPtr GetDoubleData()
	{
		return vtkDICOMValue_GetDoubleData_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDICOMValue_GetFloat_38(HandleRef pThis, ulong i);

	public float GetFloat(ulong i)
	{
		return vtkDICOMValue_GetFloat_38(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetFloatData_39(HandleRef pThis);

	public IntPtr GetFloatData()
	{
		return vtkDICOMValue_GetFloatData_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMValue_GetInt_40(HandleRef pThis, ulong i);

	public int GetInt(ulong i)
	{
		return vtkDICOMValue_GetInt_40(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMValue_GetInt64_41(HandleRef pThis, ulong i);

	public long GetInt64(ulong i)
	{
		return vtkDICOMValue_GetInt64_41(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetInt64Data_42(HandleRef pThis);

	public IntPtr GetInt64Data()
	{
		return vtkDICOMValue_GetInt64Data_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetIntData_43(HandleRef pThis);

	public IntPtr GetIntData()
	{
		return vtkDICOMValue_GetIntData_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetItem_44(HandleRef pThis, ulong i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem GetItem(ulong i)
	{
		vtkDICOMItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_GetItem_44(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetMultiplexData_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetMultiplexData()
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_GetMultiplexData_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDICOMValue_GetNumberOfValues_46(HandleRef pThis);

	public ulong GetNumberOfValues()
	{
		return vtkDICOMValue_GetNumberOfValues_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetSequenceData_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem GetSequenceData()
	{
		vtkDICOMItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_GetSequenceData_47(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern short vtkDICOMValue_GetShort_48(HandleRef pThis, ulong i);

	public short GetShort(ulong i)
	{
		return vtkDICOMValue_GetShort_48(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetShortData_49(HandleRef pThis);

	public IntPtr GetShortData()
	{
		return vtkDICOMValue_GetShortData_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMValue_GetString_50(HandleRef pThis, ulong i);

	public string GetString(ulong i)
	{
		return vtkDICOMValue_GetString_50(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetTag_51(HandleRef pThis, ulong i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag GetTag(ulong i)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_GetTag_51(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetTagData_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag GetTagData()
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMValue_GetTagData_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: false, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMValue_GetUTF8String_53(HandleRef pThis, ulong i);

	public string GetUTF8String(ulong i)
	{
		return vtkDICOMValue_GetUTF8String_53(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMValue_GetUnsignedChar_54(HandleRef pThis, ulong i);

	public byte GetUnsignedChar(ulong i)
	{
		return vtkDICOMValue_GetUnsignedChar_54(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetUnsignedCharData_55(HandleRef pThis);

	public IntPtr GetUnsignedCharData()
	{
		return vtkDICOMValue_GetUnsignedCharData_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMValue_GetUnsignedInt_56(HandleRef pThis, ulong i);

	public uint GetUnsignedInt(ulong i)
	{
		return vtkDICOMValue_GetUnsignedInt_56(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDICOMValue_GetUnsignedInt64_57(HandleRef pThis, ulong i);

	public ulong GetUnsignedInt64(ulong i)
	{
		return vtkDICOMValue_GetUnsignedInt64_57(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetUnsignedInt64Data_58(HandleRef pThis);

	public IntPtr GetUnsignedInt64Data()
	{
		return vtkDICOMValue_GetUnsignedInt64Data_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetUnsignedIntData_59(HandleRef pThis);

	public IntPtr GetUnsignedIntData()
	{
		return vtkDICOMValue_GetUnsignedIntData_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkDICOMValue_GetUnsignedShort_60(HandleRef pThis, ulong i);

	public ushort GetUnsignedShort(ulong i)
	{
		return vtkDICOMValue_GetUnsignedShort_60(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_GetUnsignedShortData_61(HandleRef pThis);

	public IntPtr GetUnsignedShortData()
	{
		return vtkDICOMValue_GetUnsignedShortData_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMValue_GetVL_62(HandleRef pThis);

	public uint GetVL()
	{
		return vtkDICOMValue_GetVL_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMVR vtkDICOMValue_GetVR_63(HandleRef pThis);

	public vtkDICOMVR GetVR()
	{
		return vtkDICOMValue_GetVR_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMValue_GetValues_64(HandleRef pThis, string vb, ulong n, ulong i);

	public void GetValues(string vb, ulong n, ulong i)
	{
		vtkDICOMValue_GetValues_64(GetCppThis(), vb, n, i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMValue_GetValues_65(HandleRef pThis, IntPtr vb, ulong n, ulong i);

	public void GetValues(IntPtr vb, ulong n, ulong i)
	{
		vtkDICOMValue_GetValues_65(GetCppThis(), vb, n, i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMValue_GetValues_66(HandleRef pThis, HandleRef vb, ulong n, ulong i);

	public void GetValues(vtkDICOMTag vb, ulong n, ulong i)
	{
		vtkDICOMValue_GetValues_66(GetCppThis(), vb?.GetCppThis() ?? default(HandleRef), n, i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMValue_IsValid_67(HandleRef pThis);

	public bool IsValid()
	{
		return (vtkDICOMValue_IsValid_67(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMValue_Matches_68(HandleRef pThis, HandleRef value);

	public bool Matches(vtkDICOMValue value)
	{
		return (vtkDICOMValue_Matches_68(GetCppThis(), value?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMValue_Matches_69(HandleRef pThis, string v);

	public bool Matches(string v)
	{
		return (vtkDICOMValue_Matches_69(GetCppThis(), v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMValue_Matches_70(HandleRef pThis, double v);

	public bool Matches(double v)
	{
		return (vtkDICOMValue_Matches_70(GetCppThis(), v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_ReallocateUnsignedCharData_71(HandleRef pThis, ulong vn);

	public IntPtr ReallocateUnsignedCharData(ulong vn)
	{
		return vtkDICOMValue_ReallocateUnsignedCharData_71(GetCppThis(), vn);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMValue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, vtkDICOMTag tag);

	public vtkDICOMValue(vtkDICOMTag tag)
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMValue_New(ref mteStatus, ref mteIndex, ref rawRefCount, tag);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}
}
