using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMParser : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMParser";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMParser()
	{
		MRClassNameKey = "class vtkDICOMParser";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMParser"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMParser New()
	{
		vtkDICOMParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMParser()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDICOMParser_GetBufferSize_01(HandleRef pThis);

	public int GetBufferSize()
	{
		return vtkDICOMParser_GetBufferSize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMCharacterSet vtkDICOMParser_GetDefaultCharacterSet_02(HandleRef pThis);

	public vtkDICOMCharacterSet GetDefaultCharacterSet()
	{
		return vtkDICOMParser_GetDefaultCharacterSet_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMParser_GetErrorCode_03(HandleRef pThis);

	public uint GetErrorCode()
	{
		return vtkDICOMParser_GetErrorCode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMParser_GetFileName_04(HandleRef pThis);

	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMParser_GetFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMParser_GetFileOffset_05(HandleRef pThis);

	public long GetFileOffset()
	{
		return vtkDICOMParser_GetFileOffset_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMParser_GetFileSize_06(HandleRef pThis);

	public long GetFileSize()
	{
		return vtkDICOMParser_GetFileSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMParser_GetGroups_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkUnsignedShortArray GetGroups()
	{
		vtkUnsignedShortArray vtkUnsignedShortArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMParser_GetGroups_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedShortArray2 = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedShortArray2.Register(null);
			}
		}
		return vtkUnsignedShortArray2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMParser_GetIndex_08(HandleRef pThis);

	public int GetIndex()
	{
		return vtkDICOMParser_GetIndex_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMParser_GetMetaData_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMMetaData GetMetaData()
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMParser_GetMetaData_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMMetaData2 = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMMetaData2.Register(null);
			}
		}
		return vtkDICOMMetaData2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMParser_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMParser_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMParser_GetNumberOfGenerationsFromBaseType_11(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMParser_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMParser_GetOverrideCharacterSet_12(HandleRef pThis);

	public bool GetOverrideCharacterSet()
	{
		return (vtkDICOMParser_GetOverrideCharacterSet_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMParser_GetPixelDataFound_13(HandleRef pThis);

	public bool GetPixelDataFound()
	{
		return (vtkDICOMParser_GetPixelDataFound_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMParser_GetPixelDataVL_14(HandleRef pThis);

	public uint GetPixelDataVL()
	{
		return vtkDICOMParser_GetPixelDataVL_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMParser_GetQuery_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMMetaData GetQuery()
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMParser_GetQuery_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMMetaData2 = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMMetaData2.Register(null);
			}
		}
		return vtkDICOMMetaData2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMParser_GetQueryMatched_16(HandleRef pThis);

	public bool GetQueryMatched()
	{
		return (vtkDICOMParser_GetQueryMatched_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMParser_IsA_17(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMParser_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMParser_IsTypeOf_18(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMParser_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMParser_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMParser NewInstance()
	{
		vtkDICOMParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMParser_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_OverrideCharacterSetOff_21(HandleRef pThis);

	public void OverrideCharacterSetOff()
	{
		vtkDICOMParser_OverrideCharacterSetOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_OverrideCharacterSetOn_22(HandleRef pThis);

	public void OverrideCharacterSetOn()
	{
		vtkDICOMParser_OverrideCharacterSetOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMParser_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMParser SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMParser vtkDICOMParser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMParser_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMParser2 = (vtkDICOMParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMParser2.Register(null);
			}
		}
		return vtkDICOMParser2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetBufferSize_24(HandleRef pThis, int size);

	public void SetBufferSize(int size)
	{
		vtkDICOMParser_SetBufferSize_24(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetDefaultCharacterSet_25(HandleRef pThis, vtkDICOMCharacterSet cs);

	public void SetDefaultCharacterSet(vtkDICOMCharacterSet cs)
	{
		vtkDICOMParser_SetDefaultCharacterSet_25(GetCppThis(), cs);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetFileName_26(HandleRef pThis, string _arg);

	public virtual void SetFileName(string _arg)
	{
		vtkDICOMParser_SetFileName_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetGroups_27(HandleRef pThis, HandleRef groups);

	public void SetGroups(vtkUnsignedShortArray groups)
	{
		vtkDICOMParser_SetGroups_27(GetCppThis(), groups?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetIndex_28(HandleRef pThis, int _arg);

	public virtual void SetIndex(int _arg)
	{
		vtkDICOMParser_SetIndex_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetMetaData_29(HandleRef pThis, HandleRef arg0);

	public void SetMetaData(vtkDICOMMetaData arg0)
	{
		vtkDICOMParser_SetMetaData_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetOverrideCharacterSet_30(HandleRef pThis, byte b);

	public void SetOverrideCharacterSet(bool b)
	{
		vtkDICOMParser_SetOverrideCharacterSet_30(GetCppThis(), (byte)(b ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetQuery_31(HandleRef pThis, HandleRef query);

	public void SetQuery(vtkDICOMMetaData query)
	{
		vtkDICOMParser_SetQuery_31(GetCppThis(), query?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_SetQueryItem_32(HandleRef pThis, HandleRef query);

	public void SetQueryItem(vtkDICOMItem query)
	{
		vtkDICOMParser_SetQueryItem_32(GetCppThis(), query?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMParser_Update_33(HandleRef pThis);

	public virtual void Update()
	{
		vtkDICOMParser_Update_33(GetCppThis());
	}
}
