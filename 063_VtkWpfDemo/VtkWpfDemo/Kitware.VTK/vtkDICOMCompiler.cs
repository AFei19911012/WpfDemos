using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMCompiler : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMCompiler";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMCompiler()
	{
		MRClassNameKey = "class vtkDICOMCompiler";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMCompiler"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMCompiler(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMCompiler New()
	{
		vtkDICOMCompiler result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCompiler_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMCompiler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMCompiler()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMCompiler_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDICOMCompiler_Close_01(HandleRef pThis);

	public virtual void Close()
	{
		vtkDICOMCompiler_Close_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_CloseAndRemove_02(HandleRef pThis);

	public virtual void CloseAndRemove()
	{
		vtkDICOMCompiler_CloseAndRemove_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_GenerateSeriesUIDs_03(HandleRef pThis);

	public void GenerateSeriesUIDs()
	{
		vtkDICOMCompiler_GenerateSeriesUIDs_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMCompiler_GetBufferSize_04(HandleRef pThis);

	public int GetBufferSize()
	{
		return vtkDICOMCompiler_GetBufferSize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMCompiler_GetErrorCode_05(HandleRef pThis);

	public uint GetErrorCode()
	{
		return vtkDICOMCompiler_GetErrorCode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetFileName_06(HandleRef pThis);

	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMCompiler_GetFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetImplementationClassUID_07(HandleRef pThis);

	public virtual string GetImplementationClassUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMCompiler_GetImplementationClassUID_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetImplementationVersionName_08(HandleRef pThis);

	public virtual string GetImplementationVersionName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMCompiler_GetImplementationVersionName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMCompiler_GetIndex_09(HandleRef pThis);

	public int GetIndex()
	{
		return vtkDICOMCompiler_GetIndex_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMCompiler_GetKeepOriginalPixelDataVR_10(HandleRef pThis);

	public virtual bool GetKeepOriginalPixelDataVR()
	{
		return (vtkDICOMCompiler_GetKeepOriginalPixelDataVR_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetMetaData_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMMetaData GetMetaData()
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCompiler_GetMetaData_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDICOMCompiler_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMCompiler_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMCompiler_GetNumberOfGenerationsFromBaseType_13(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMCompiler_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetSOPInstanceUID_14(HandleRef pThis);

	public virtual string GetSOPInstanceUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMCompiler_GetSOPInstanceUID_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetSeriesInstanceUID_15(HandleRef pThis);

	public virtual string GetSeriesInstanceUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMCompiler_GetSeriesInstanceUID_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetSourceApplicationEntityTitle_16(HandleRef pThis);

	public virtual string GetSourceApplicationEntityTitle()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMCompiler_GetSourceApplicationEntityTitle_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetStudyInstanceUID_17(HandleRef pThis);

	public virtual string GetStudyInstanceUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMCompiler_GetStudyInstanceUID_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_GetTransferSyntaxUID_18(HandleRef pThis);

	public virtual string GetTransferSyntaxUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMCompiler_GetTransferSyntaxUID_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMCompiler_IsA_19(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMCompiler_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMCompiler_IsTypeOf_20(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMCompiler_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_KeepOriginalPixelDataVROff_21(HandleRef pThis);

	public virtual void KeepOriginalPixelDataVROff()
	{
		vtkDICOMCompiler_KeepOriginalPixelDataVROff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_KeepOriginalPixelDataVROn_22(HandleRef pThis);

	public virtual void KeepOriginalPixelDataVROn()
	{
		vtkDICOMCompiler_KeepOriginalPixelDataVROn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMCompiler NewInstance()
	{
		vtkDICOMCompiler result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCompiler_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMCompiler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCompiler_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMCompiler SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMCompiler vtkDICOMCompiler2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCompiler_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMCompiler2 = (vtkDICOMCompiler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMCompiler2.Register(null);
			}
		}
		return vtkDICOMCompiler2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetBufferSize_26(HandleRef pThis, int size);

	public void SetBufferSize(int size)
	{
		vtkDICOMCompiler_SetBufferSize_26(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetFileName_27(HandleRef pThis, string _arg);

	public virtual void SetFileName(string _arg)
	{
		vtkDICOMCompiler_SetFileName_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetImplementationClassUID_28(HandleRef pThis, string _arg);

	public virtual void SetImplementationClassUID(string _arg)
	{
		vtkDICOMCompiler_SetImplementationClassUID_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetImplementationVersionName_29(HandleRef pThis, string _arg);

	public virtual void SetImplementationVersionName(string _arg)
	{
		vtkDICOMCompiler_SetImplementationVersionName_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetIndex_30(HandleRef pThis, int _arg);

	public virtual void SetIndex(int _arg)
	{
		vtkDICOMCompiler_SetIndex_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetKeepOriginalPixelDataVR_31(HandleRef pThis, byte _arg);

	public virtual void SetKeepOriginalPixelDataVR(bool _arg)
	{
		vtkDICOMCompiler_SetKeepOriginalPixelDataVR_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetMetaData_32(HandleRef pThis, HandleRef arg0);

	public void SetMetaData(vtkDICOMMetaData arg0)
	{
		vtkDICOMCompiler_SetMetaData_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetSOPInstanceUID_33(HandleRef pThis, string _arg);

	public virtual void SetSOPInstanceUID(string _arg)
	{
		vtkDICOMCompiler_SetSOPInstanceUID_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetSeriesInstanceUID_34(HandleRef pThis, string _arg);

	public virtual void SetSeriesInstanceUID(string _arg)
	{
		vtkDICOMCompiler_SetSeriesInstanceUID_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetSourceApplicationEntityTitle_35(HandleRef pThis, string _arg);

	public virtual void SetSourceApplicationEntityTitle(string _arg)
	{
		vtkDICOMCompiler_SetSourceApplicationEntityTitle_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetStudyInstanceUID_36(HandleRef pThis, string _arg);

	public virtual void SetStudyInstanceUID(string _arg)
	{
		vtkDICOMCompiler_SetStudyInstanceUID_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_SetTransferSyntaxUID_37(HandleRef pThis, string _arg);

	public virtual void SetTransferSyntaxUID(string _arg)
	{
		vtkDICOMCompiler_SetTransferSyntaxUID_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_WriteFrame_38(HandleRef pThis, IntPtr cp, long size);

	public virtual void WriteFrame(IntPtr cp, long size)
	{
		vtkDICOMCompiler_WriteFrame_38(GetCppThis(), cp, size);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_WriteHeader_39(HandleRef pThis);

	public virtual void WriteHeader()
	{
		vtkDICOMCompiler_WriteHeader_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCompiler_WritePixelData_40(HandleRef pThis, IntPtr cp, long size);

	public virtual void WritePixelData(IntPtr cp, long size)
	{
		vtkDICOMCompiler_WritePixelData_40(GetCppThis(), cp, size);
	}
}
