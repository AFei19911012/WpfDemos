using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkDICOMReader
/// \brief Read DICOM image files.
///
/// This class reads a series of DICOM files into a vtkImageData object,
/// and also provides access to the DICOM meta data for each file.
/// </summary>
public class vtkDICOMReader : vtkImageReader2
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum RowOrder
	{
		/// <summary>enum member</summary>
		BottomUp = 2,
		/// <summary>enum member</summary>
		FileNative = 0,
		/// <summary>enum member</summary>
		TopDown = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMReader()
	{
		MRClassNameKey = "class vtkDICOMReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDICOMReader New()
	{
		vtkDICOMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDICOMReader_AutoRescaleOff_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void AutoRescaleOff()
	{
		vtkDICOMReader_AutoRescaleOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_AutoRescaleOn_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void AutoRescaleOn()
	{
		vtkDICOMReader_AutoRescaleOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_AutoYBRToRGBOff_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void AutoYBRToRGBOff()
	{
		vtkDICOMReader_AutoYBRToRGBOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_AutoYBRToRGBOn_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void AutoYBRToRGBOn()
	{
		vtkDICOMReader_AutoYBRToRGBOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_CanReadFile_05(HandleRef pThis, string filename);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int CanReadFile(string filename)
	{
		return vtkDICOMReader_CanReadFile_05(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_GetAutoRescale_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetAutoRescale()
	{
		return vtkDICOMReader_GetAutoRescale_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_GetAutoYBRToRGB_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetAutoYBRToRGB()
	{
		return vtkDICOMReader_GetAutoYBRToRGB_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMCharacterSet vtkDICOMReader_GetDefaultCharacterSet_08(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMCharacterSet GetDefaultCharacterSet()
	{
		return vtkDICOMReader_GetDefaultCharacterSet_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetDescriptiveName_09(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMReader_GetDescriptiveName_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetDesiredStackID_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetDesiredStackID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMReader_GetDesiredStackID_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_GetDesiredTimeIndex_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetDesiredTimeIndex()
	{
		return vtkDICOMReader_GetDesiredTimeIndex_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetFileExtensions_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMReader_GetFileExtensions_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetFileIndexArray_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIntArray GetFileIndexArray()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetFileIndexArray_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDICOMReader_GetFrameIndexArray_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIntArray GetFrameIndexArray()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetFrameIndexArray_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDICOMReader_GetMedicalImageProperties_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMedicalImageProperties GetMedicalImageProperties()
	{
		vtkMedicalImageProperties vtkMedicalImageProperties2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetMedicalImageProperties_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMedicalImageProperties2 = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMedicalImageProperties2.Register(null);
			}
		}
		return vtkMedicalImageProperties2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_GetMemoryRowOrder_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetMemoryRowOrder()
	{
		return vtkDICOMReader_GetMemoryRowOrder_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetMemoryRowOrderAsString_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetMemoryRowOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMReader_GetMemoryRowOrderAsString_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetMetaData_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMMetaData GetMetaData()
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetMetaData_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDICOMReader_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMReader_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMReader_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMReader_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_GetOutputScalarType_21(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkDICOMReader_GetOutputScalarType_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkDICOMReader_GetOverlayBitfield_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public ushort GetOverlayBitfield()
	{
		return vtkDICOMReader_GetOverlayBitfield_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetOverlayOutput_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageData GetOverlayOutput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetOverlayOutput_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetOverlayOutputPort_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAlgorithmOutput GetOverlayOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetOverlayOutputPort_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMReader_GetOverrideCharacterSet_25(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool GetOverrideCharacterSet()
	{
		return (vtkDICOMReader_GetOverrideCharacterSet_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetPatientMatrix_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrix4x4 GetPatientMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetPatientMatrix_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMReader_GetRescaleIntercept_27(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetRescaleIntercept()
	{
		return vtkDICOMReader_GetRescaleIntercept_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMReader_GetRescaleSlope_28(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetRescaleSlope()
	{
		return vtkDICOMReader_GetRescaleSlope_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetSorter_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMSliceSorter GetSorter()
	{
		vtkDICOMSliceSorter vtkDICOMSliceSorter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetSorter_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMSliceSorter2 = (vtkDICOMSliceSorter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMSliceSorter2.Register(null);
			}
		}
		return vtkDICOMSliceSorter2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_GetSorting_30(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetSorting()
	{
		return vtkDICOMReader_GetSorting_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_GetStackIDs_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStringArray GetStackIDs()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_GetStackIDs_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDICOMReader_GetTimeAsVector_32(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetTimeAsVector()
	{
		return vtkDICOMReader_GetTimeAsVector_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_GetTimeDimension_33(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetTimeDimension()
	{
		return vtkDICOMReader_GetTimeDimension_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMReader_GetTimeSpacing_34(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetTimeSpacing()
	{
		return vtkDICOMReader_GetTimeSpacing_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMReader_HasOverlay_35(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public bool HasOverlay()
	{
		return (vtkDICOMReader_HasOverlay_35(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_IsA_36(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDICOMReader_IsA_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMReader_IsTypeOf_37(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDICOMReader_IsTypeOf_37(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDICOMReader NewInstance()
	{
		vtkDICOMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_OverrideCharacterSetOff_40(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void OverrideCharacterSetOff()
	{
		vtkDICOMReader_OverrideCharacterSetOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_OverrideCharacterSetOn_41(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void OverrideCharacterSetOn()
	{
		vtkDICOMReader_OverrideCharacterSetOn_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMReader_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDICOMReader SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMReader vtkDICOMReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMReader_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMReader2 = (vtkDICOMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMReader2.Register(null);
			}
		}
		return vtkDICOMReader2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetAutoRescale_43(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetAutoRescale(int _arg)
	{
		vtkDICOMReader_SetAutoRescale_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetAutoYBRToRGB_44(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetAutoYBRToRGB(int _arg)
	{
		vtkDICOMReader_SetAutoYBRToRGB_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetDefaultCharacterSet_45(HandleRef pThis, vtkDICOMCharacterSet cs);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetDefaultCharacterSet(vtkDICOMCharacterSet cs)
	{
		vtkDICOMReader_SetDefaultCharacterSet_45(GetCppThis(), cs);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetDesiredStackID_46(HandleRef pThis, string stackId);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetDesiredStackID(string stackId)
	{
		vtkDICOMReader_SetDesiredStackID_46(GetCppThis(), stackId);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetDesiredTimeIndex_47(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetDesiredTimeIndex(int _arg)
	{
		vtkDICOMReader_SetDesiredTimeIndex_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetMemoryRowOrder_48(HandleRef pThis, int order);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMemoryRowOrder(int order)
	{
		vtkDICOMReader_SetMemoryRowOrder_48(GetCppThis(), order);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetMemoryRowOrderToBottomUp_49(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMemoryRowOrderToBottomUp()
	{
		vtkDICOMReader_SetMemoryRowOrderToBottomUp_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetMemoryRowOrderToFileNative_50(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMemoryRowOrderToFileNative()
	{
		vtkDICOMReader_SetMemoryRowOrderToFileNative_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetMemoryRowOrderToTopDown_51(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMemoryRowOrderToTopDown()
	{
		vtkDICOMReader_SetMemoryRowOrderToTopDown_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetOutputScalarType_52(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkDICOMReader_SetOutputScalarType_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetOverlayOutput_53(HandleRef pThis, HandleRef data);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetOverlayOutput(vtkImageData data)
	{
		vtkDICOMReader_SetOverlayOutput_53(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetOverrideCharacterSet_54(HandleRef pThis, byte _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetOverrideCharacterSet(bool _arg)
	{
		vtkDICOMReader_SetOverrideCharacterSet_54(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetSorter_55(HandleRef pThis, HandleRef sorter);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetSorter(vtkDICOMSliceSorter sorter)
	{
		vtkDICOMReader_SetSorter_55(GetCppThis(), sorter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetSorting_56(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSorting(int _arg)
	{
		vtkDICOMReader_SetSorting_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SetTimeAsVector_57(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTimeAsVector(int _arg)
	{
		vtkDICOMReader_SetTimeAsVector_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SortingOff_58(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SortingOff()
	{
		vtkDICOMReader_SortingOff_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_SortingOn_59(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SortingOn()
	{
		vtkDICOMReader_SortingOn_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_TimeAsVectorOff_60(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void TimeAsVectorOff()
	{
		vtkDICOMReader_TimeAsVectorOff_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_TimeAsVectorOn_61(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void TimeAsVectorOn()
	{
		vtkDICOMReader_TimeAsVectorOn_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMReader_Update_62(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Update()
	{
		vtkDICOMReader_Update_62(GetCppThis());
	}
}
