using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMDirectory : vtkAlgorithm
{
	public enum FRAME_WrapperEnum
	{
		/// <summary>enum member</summary>
		FRAME = 4,
		/// <summary>enum member</summary>
		IMAGE = 3,
		/// <summary>enum member</summary>
		PATIENT = 0,
		/// <summary>enum member</summary>
		SERIES = 2,
		/// <summary>enum member</summary>
		STUDY = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMDirectory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMDirectory()
	{
		MRClassNameKey = "class vtkDICOMDirectory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMDirectory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMDirectory New()
	{
		vtkDICOMDirectory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMDirectory()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMDirectory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDICOMDirectory_AddInputFileNames_01(HandleRef pThis, HandleRef sa);

	public void AddInputFileNames(vtkStringArray sa)
	{
		vtkDICOMDirectory_AddInputFileNames_01(GetCppThis(), sa?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_FollowSymlinksOff_02(HandleRef pThis);

	public virtual void FollowSymlinksOff()
	{
		vtkDICOMDirectory_FollowSymlinksOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_FollowSymlinksOn_03(HandleRef pThis);

	public virtual void FollowSymlinksOn()
	{
		vtkDICOMDirectory_FollowSymlinksOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMCharacterSet vtkDICOMDirectory_GetDefaultCharacterSet_04(HandleRef pThis);

	public vtkDICOMCharacterSet GetDefaultCharacterSet()
	{
		return vtkDICOMDirectory_GetDefaultCharacterSet_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetDirectoryName_05(HandleRef pThis);

	public string GetDirectoryName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMDirectory_GetDirectoryName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetFileNamesForSeries_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkStringArray GetFileNamesForSeries(int i)
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_GetFileNamesForSeries_06(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetFilePattern_07(HandleRef pThis);

	public string GetFilePattern()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMDirectory_GetFilePattern_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetFileSetID_08(HandleRef pThis);

	public string GetFileSetID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMDirectory_GetFileSetID_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetFindLevel_09(HandleRef pThis);

	public int GetFindLevel()
	{
		return vtkDICOMDirectory_GetFindLevel_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetFirstSeriesForStudy_10(HandleRef pThis, int study);

	public int GetFirstSeriesForStudy(int study)
	{
		return vtkDICOMDirectory_GetFirstSeriesForStudy_10(GetCppThis(), study);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetFollowSymlinks_11(HandleRef pThis);

	public int GetFollowSymlinks()
	{
		return vtkDICOMDirectory_GetFollowSymlinks_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetIgnoreDicomdir_12(HandleRef pThis);

	public int GetIgnoreDicomdir()
	{
		return vtkDICOMDirectory_GetIgnoreDicomdir_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetInputFileNames_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkStringArray GetInputFileNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_GetInputFileNames_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetInternalFileName_14(HandleRef pThis);

	public string GetInternalFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMDirectory_GetInternalFileName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetLastSeriesForStudy_15(HandleRef pThis, int study);

	public int GetLastSeriesForStudy(int study)
	{
		return vtkDICOMDirectory_GetLastSeriesForStudy_15(GetCppThis(), study);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetMetaDataForSeries_16(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMMetaData GetMetaDataForSeries(int i)
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_GetMetaDataForSeries_16(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDICOMDirectory_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMDirectory_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMDirectory_GetNumberOfGenerationsFromBaseType_18(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMDirectory_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetNumberOfPatients_19(HandleRef pThis);

	public int GetNumberOfPatients()
	{
		return vtkDICOMDirectory_GetNumberOfPatients_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetNumberOfSeries_20(HandleRef pThis);

	public int GetNumberOfSeries()
	{
		return vtkDICOMDirectory_GetNumberOfSeries_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetNumberOfStudies_21(HandleRef pThis);

	public int GetNumberOfStudies()
	{
		return vtkDICOMDirectory_GetNumberOfStudies_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMDirectory_GetOverrideCharacterSet_22(HandleRef pThis);

	public bool GetOverrideCharacterSet()
	{
		return (vtkDICOMDirectory_GetOverrideCharacterSet_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetPatientRecord_23(HandleRef pThis, int patient, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem GetPatientRecord(int patient)
	{
		vtkDICOMItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_GetPatientRecord_23(GetCppThis(), patient, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetPatientRecordForStudy_24(HandleRef pThis, int study, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem GetPatientRecordForStudy(int study)
	{
		vtkDICOMItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_GetPatientRecordForStudy_24(GetCppThis(), study, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetQueryFiles_25(HandleRef pThis);

	public int GetQueryFiles()
	{
		return vtkDICOMDirectory_GetQueryFiles_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetRequirePixelData_26(HandleRef pThis);

	public int GetRequirePixelData()
	{
		return vtkDICOMDirectory_GetRequirePixelData_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetScanDepth_27(HandleRef pThis);

	public int GetScanDepth()
	{
		return vtkDICOMDirectory_GetScanDepth_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetSeriesRecord_28(HandleRef pThis, int series, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem GetSeriesRecord(int series)
	{
		vtkDICOMItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_GetSeriesRecord_28(GetCppThis(), series, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_GetShowHidden_29(HandleRef pThis);

	public int GetShowHidden()
	{
		return vtkDICOMDirectory_GetShowHidden_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetStudiesForPatient_30(HandleRef pThis, int patient, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkIntArray GetStudiesForPatient(int patient)
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_GetStudiesForPatient_30(GetCppThis(), patient, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_GetStudyRecord_31(HandleRef pThis, int study, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMItem GetStudyRecord(int study)
	{
		vtkDICOMItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_GetStudyRecord_31(GetCppThis(), study, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_IgnoreDicomdirOff_32(HandleRef pThis);

	public virtual void IgnoreDicomdirOff()
	{
		vtkDICOMDirectory_IgnoreDicomdirOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_IgnoreDicomdirOn_33(HandleRef pThis);

	public virtual void IgnoreDicomdirOn()
	{
		vtkDICOMDirectory_IgnoreDicomdirOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_IsA_34(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMDirectory_IsA_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_IsTypeOf_35(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMDirectory_IsTypeOf_35(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMDirectory NewInstance()
	{
		vtkDICOMDirectory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_NewInstance_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_OverrideCharacterSetOff_38(HandleRef pThis);

	public virtual void OverrideCharacterSetOff()
	{
		vtkDICOMDirectory_OverrideCharacterSetOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_OverrideCharacterSetOn_39(HandleRef pThis);

	public virtual void OverrideCharacterSetOn()
	{
		vtkDICOMDirectory_OverrideCharacterSetOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_RequirePixelDataOff_40(HandleRef pThis);

	public virtual void RequirePixelDataOff()
	{
		vtkDICOMDirectory_RequirePixelDataOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_RequirePixelDataOn_41(HandleRef pThis);

	public virtual void RequirePixelDataOn()
	{
		vtkDICOMDirectory_RequirePixelDataOn_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMDirectory_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMDirectory SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMDirectory vtkDICOMDirectory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMDirectory_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMDirectory2 = (vtkDICOMDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMDirectory2.Register(null);
			}
		}
		return vtkDICOMDirectory2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetDefaultCharacterSet_43(HandleRef pThis, vtkDICOMCharacterSet cs);

	public void SetDefaultCharacterSet(vtkDICOMCharacterSet cs)
	{
		vtkDICOMDirectory_SetDefaultCharacterSet_43(GetCppThis(), cs);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetDirectoryName_44(HandleRef pThis, string name);

	public void SetDirectoryName(string name)
	{
		vtkDICOMDirectory_SetDirectoryName_44(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetFilePattern_45(HandleRef pThis, string pattern);

	public void SetFilePattern(string pattern)
	{
		vtkDICOMDirectory_SetFilePattern_45(GetCppThis(), pattern);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetFindLevel_46(HandleRef pThis, int level);

	public void SetFindLevel(int level)
	{
		vtkDICOMDirectory_SetFindLevel_46(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetFindLevelToImage_47(HandleRef pThis);

	public void SetFindLevelToImage()
	{
		vtkDICOMDirectory_SetFindLevelToImage_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetFindLevelToSeries_48(HandleRef pThis);

	public void SetFindLevelToSeries()
	{
		vtkDICOMDirectory_SetFindLevelToSeries_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetFindQuery_49(HandleRef pThis, HandleRef query);

	public void SetFindQuery(vtkDICOMItem query)
	{
		vtkDICOMDirectory_SetFindQuery_49(GetCppThis(), query?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetFollowSymlinks_50(HandleRef pThis, int _arg);

	public virtual void SetFollowSymlinks(int _arg)
	{
		vtkDICOMDirectory_SetFollowSymlinks_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetIgnoreDicomdir_51(HandleRef pThis, int _arg);

	public virtual void SetIgnoreDicomdir(int _arg)
	{
		vtkDICOMDirectory_SetIgnoreDicomdir_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetInputFileNames_52(HandleRef pThis, HandleRef sa);

	public void SetInputFileNames(vtkStringArray sa)
	{
		vtkDICOMDirectory_SetInputFileNames_52(GetCppThis(), sa?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetOverrideCharacterSet_53(HandleRef pThis, byte _arg);

	public virtual void SetOverrideCharacterSet(bool _arg)
	{
		vtkDICOMDirectory_SetOverrideCharacterSet_53(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetQueryFiles_54(HandleRef pThis, int _arg);

	public virtual void SetQueryFiles(int _arg)
	{
		vtkDICOMDirectory_SetQueryFiles_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetQueryFilesToAlways_55(HandleRef pThis);

	public void SetQueryFilesToAlways()
	{
		vtkDICOMDirectory_SetQueryFilesToAlways_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetQueryFilesToDefault_56(HandleRef pThis);

	public void SetQueryFilesToDefault()
	{
		vtkDICOMDirectory_SetQueryFilesToDefault_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetQueryFilesToNever_57(HandleRef pThis);

	public void SetQueryFilesToNever()
	{
		vtkDICOMDirectory_SetQueryFilesToNever_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetRequirePixelData_58(HandleRef pThis, int _arg);

	public virtual void SetRequirePixelData(int _arg)
	{
		vtkDICOMDirectory_SetRequirePixelData_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetScanDepth_59(HandleRef pThis, int _arg);

	public virtual void SetScanDepth(int _arg)
	{
		vtkDICOMDirectory_SetScanDepth_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_SetShowHidden_60(HandleRef pThis, int _arg);

	public virtual void SetShowHidden(int _arg)
	{
		vtkDICOMDirectory_SetShowHidden_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_ShowHiddenOff_61(HandleRef pThis);

	public virtual void ShowHiddenOff()
	{
		vtkDICOMDirectory_ShowHiddenOff_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_ShowHiddenOn_62(HandleRef pThis);

	public virtual void ShowHiddenOn()
	{
		vtkDICOMDirectory_ShowHiddenOn_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_Update_63(HandleRef pThis);

	public override void Update()
	{
		vtkDICOMDirectory_Update_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMDirectory_Update_64(HandleRef pThis, int arg0);

	public override void Update(int arg0)
	{
		vtkDICOMDirectory_Update_64(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_Update_65(HandleRef pThis, HandleRef arg0);

	public override int Update(vtkInformation arg0)
	{
		return vtkDICOMDirectory_Update_65(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMDirectory_Update_66(HandleRef pThis, int i, HandleRef arg1);

	public override int Update(int i, vtkInformationVector arg1)
	{
		return vtkDICOMDirectory_Update_66(GetCppThis(), i, arg1?.GetCppThis() ?? default(HandleRef));
	}
}
