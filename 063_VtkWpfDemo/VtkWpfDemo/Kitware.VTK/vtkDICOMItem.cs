using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMItem : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMItem()
	{
		MRClassNameKey = "class vtkDICOMItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkDICOMItem_Begin_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMDataElementIterator Begin()
	{
		vtkDICOMDataElementIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_Begin_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_Clear_02(HandleRef pThis);

	public void Clear()
	{
		vtkDICOMItem_Clear_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_End_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMDataElementIterator End()
	{
		vtkDICOMDataElementIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_End_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_FindDictEntry_04(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMDictEntry FindDictEntry(vtkDICOMTag tag)
	{
		vtkDICOMDictEntry result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_FindDictEntry_04(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDictEntry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMVR vtkDICOMItem_FindDictVR_05(HandleRef pThis, HandleRef tag);

	public vtkDICOMVR FindDictVR(vtkDICOMTag tag)
	{
		return vtkDICOMItem_FindDictVR_05(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_Get_06(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_Get_06(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_Get_07(HandleRef pThis, vtkDICOMTagPath tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(vtkDICOMTagPath tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_Get_07(GetCppThis(), tag, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_GetAttributeValue_08(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_GetAttributeValue_08(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_GetAttributeValue_09(HandleRef pThis, vtkDICOMTagPath tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(vtkDICOMTagPath tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_GetAttributeValue_09(GetCppThis(), tag, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMItem_GetByteOffset_10(HandleRef pThis);

	public uint GetByteOffset()
	{
		return vtkDICOMItem_GetByteOffset_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMItem_GetNumberOfDataElements_11(HandleRef pThis);

	public int GetNumberOfDataElements()
	{
		return vtkDICOMItem_GetNumberOfDataElements_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMItem_IsDelimited_12(HandleRef pThis);

	public bool IsDelimited()
	{
		return (vtkDICOMItem_IsDelimited_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMItem_IsEmpty_13(HandleRef pThis);

	public bool IsEmpty()
	{
		return (vtkDICOMItem_IsEmpty_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_ResolvePrivateTag_14(HandleRef pThis, HandleRef ptag, string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag ResolvePrivateTag(vtkDICOMTag ptag, string creator)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_ResolvePrivateTag_14(GetCppThis(), ptag?.GetCppThis() ?? default(HandleRef), creator, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_ResolvePrivateTagForWriting_15(HandleRef pThis, HandleRef ptag, string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag ResolvePrivateTagForWriting(vtkDICOMTag ptag, string creator)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMItem_ResolvePrivateTagForWriting_15(GetCppThis(), ptag?.GetCppThis() ?? default(HandleRef), creator, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_Set_16(HandleRef pThis, HandleRef tag, HandleRef v);

	public void Set(vtkDICOMTag tag, vtkDICOMValue v)
	{
		vtkDICOMItem_Set_16(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_Set_17(HandleRef pThis, HandleRef tag, double v);

	public void Set(vtkDICOMTag tag, double v)
	{
		vtkDICOMItem_Set_17(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_Set_18(HandleRef pThis, HandleRef tag, string v);

	public void Set(vtkDICOMTag tag, string v)
	{
		vtkDICOMItem_Set_18(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_Set_19(HandleRef pThis, vtkDICOMTagPath tag, HandleRef v);

	public void Set(vtkDICOMTagPath tag, vtkDICOMValue v)
	{
		vtkDICOMItem_Set_19(GetCppThis(), tag, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_Set_20(HandleRef pThis, vtkDICOMTagPath tag, double v);

	public void Set(vtkDICOMTagPath tag, double v)
	{
		vtkDICOMItem_Set_20(GetCppThis(), tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_Set_21(HandleRef pThis, vtkDICOMTagPath tag, string v);

	public void Set(vtkDICOMTagPath tag, string v)
	{
		vtkDICOMItem_Set_21(GetCppThis(), tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_SetAttributeValue_22(HandleRef pThis, HandleRef tag, HandleRef v);

	public void SetAttributeValue(vtkDICOMTag tag, vtkDICOMValue v)
	{
		vtkDICOMItem_SetAttributeValue_22(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_SetAttributeValue_23(HandleRef pThis, HandleRef tag, double v);

	public void SetAttributeValue(vtkDICOMTag tag, double v)
	{
		vtkDICOMItem_SetAttributeValue_23(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_SetAttributeValue_24(HandleRef pThis, HandleRef tag, string v);

	public void SetAttributeValue(vtkDICOMTag tag, string v)
	{
		vtkDICOMItem_SetAttributeValue_24(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_SetAttributeValue_25(HandleRef pThis, vtkDICOMTagPath tag, HandleRef v);

	public void SetAttributeValue(vtkDICOMTagPath tag, vtkDICOMValue v)
	{
		vtkDICOMItem_SetAttributeValue_25(GetCppThis(), tag, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_SetAttributeValue_26(HandleRef pThis, vtkDICOMTagPath tag, double v);

	public void SetAttributeValue(vtkDICOMTagPath tag, double v)
	{
		vtkDICOMItem_SetAttributeValue_26(GetCppThis(), tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMItem_SetAttributeValue_27(HandleRef pThis, vtkDICOMTagPath tag, string v);

	public void SetAttributeValue(vtkDICOMTagPath tag, string v)
	{
		vtkDICOMItem_SetAttributeValue_27(GetCppThis(), tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}
}
