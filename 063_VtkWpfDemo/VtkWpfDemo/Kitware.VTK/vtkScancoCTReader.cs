using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkScancoCTReader
/// \brief Read SCANCO ISQ and AIM medical image files
///
/// This class reads ISQ and AIM files, which are used for high-resolution
/// computed tomography.  The information that it provides uses different
/// units as compared to the original files: all distances are given in
/// millimeters (instead of micrometers), times are given in milliseconds
/// (instead of microseconds), voltage and current given in kV and mA
/// (instead of volts and microamps).  If the scanner was calibrated, then
/// the data values can be converted to calibrated units.  To convert
/// to linear attenuation coefficients [cm^-1], simply divide the data
/// values by the MuScaling.  To convert to density values, multiply
/// the data values by the RescaleSlope and add the RescaleIntercept.
/// To convert to Hounsfield units, multiply by 1000/(MuScaling*MuWater)
/// and subtract 1000.
///
/// Created at the Calgary Image Processing and Analysis Centre (CIPAC).
/// </summary>
public class vtkScancoCTReader : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScancoCTReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScancoCTReader()
	{
		MRClassNameKey = "class vtkScancoCTReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScancoCTReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScancoCTReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScancoCTReader New()
	{
		vtkScancoCTReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScancoCTReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScancoCTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkScancoCTReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkScancoCTReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkScancoCTReader_CanReadFile_01(HandleRef pThis, string filename);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int CanReadFile(string filename)
	{
		return vtkScancoCTReader_CanReadFile_01(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetCalibrationData_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetCalibrationData()
	{
		return Marshal.PtrToStringAnsi(vtkScancoCTReader_GetCalibrationData_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetCreationDate_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetCreationDate()
	{
		return Marshal.PtrToStringAnsi(vtkScancoCTReader_GetCreationDate_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetDataRange_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double[] GetDataRange()
	{
		IntPtr intPtr = vtkScancoCTReader_GetDataRange_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScancoCTReader_GetDataRange_05(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetDataRange(ref double _arg1, ref double _arg2)
	{
		vtkScancoCTReader_GetDataRange_05(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScancoCTReader_GetDataRange_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetDataRange(IntPtr _arg)
	{
		vtkScancoCTReader_GetDataRange_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetDescriptiveName_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkScancoCTReader_GetDescriptiveName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetEndPosition_08(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetEndPosition()
	{
		return vtkScancoCTReader_GetEndPosition_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetEnergy_09(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetEnergy()
	{
		return vtkScancoCTReader_GetEnergy_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetFileExtensions_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkScancoCTReader_GetFileExtensions_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetIntensity_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetIntensity()
	{
		return vtkScancoCTReader_GetIntensity_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetMeasurementIndex_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetMeasurementIndex()
	{
		return vtkScancoCTReader_GetMeasurementIndex_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetModificationDate_13(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetModificationDate()
	{
		return Marshal.PtrToStringAnsi(vtkScancoCTReader_GetModificationDate_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetMuScaling_14(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetMuScaling()
	{
		return vtkScancoCTReader_GetMuScaling_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetMuWater_15(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetMuWater()
	{
		return vtkScancoCTReader_GetMuWater_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScancoCTReader_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScancoCTReader_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScancoCTReader_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScancoCTReader_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetNumberOfProjections_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetNumberOfProjections()
	{
		return vtkScancoCTReader_GetNumberOfProjections_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetNumberOfSamples_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetNumberOfSamples()
	{
		return vtkScancoCTReader_GetNumberOfSamples_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetPatientIndex_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetPatientIndex()
	{
		return vtkScancoCTReader_GetPatientIndex_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetPatientName_21(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetPatientName()
	{
		return Marshal.PtrToStringAnsi(vtkScancoCTReader_GetPatientName_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetRawHeader_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public IntPtr GetRawHeader()
	{
		return vtkScancoCTReader_GetRawHeader_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetReconstructionAlg_23(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetReconstructionAlg()
	{
		return vtkScancoCTReader_GetReconstructionAlg_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetReferenceLine_24(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetReferenceLine()
	{
		return vtkScancoCTReader_GetReferenceLine_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetRescaleIntercept_25(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetRescaleIntercept()
	{
		return vtkScancoCTReader_GetRescaleIntercept_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetRescaleSlope_26(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetRescaleSlope()
	{
		return vtkScancoCTReader_GetRescaleSlope_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetRescaleType_27(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetRescaleType()
	{
		return vtkScancoCTReader_GetRescaleType_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetRescaleUnits_28(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetRescaleUnits()
	{
		return Marshal.PtrToStringAnsi(vtkScancoCTReader_GetRescaleUnits_28(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetSampleTime_29(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetSampleTime()
	{
		return vtkScancoCTReader_GetSampleTime_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetScanDimensionsPhysical_30(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double[] GetScanDimensionsPhysical()
	{
		IntPtr intPtr = vtkScancoCTReader_GetScanDimensionsPhysical_30(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScancoCTReader_GetScanDimensionsPhysical_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetScanDimensionsPhysical(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkScancoCTReader_GetScanDimensionsPhysical_31(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScancoCTReader_GetScanDimensionsPhysical_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetScanDimensionsPhysical(IntPtr _arg)
	{
		vtkScancoCTReader_GetScanDimensionsPhysical_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetScanDimensionsPixels_33(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int[] GetScanDimensionsPixels()
	{
		IntPtr intPtr = vtkScancoCTReader_GetScanDimensionsPixels_33(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScancoCTReader_GetScanDimensionsPixels_34(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetScanDimensionsPixels(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkScancoCTReader_GetScanDimensionsPixels_34(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScancoCTReader_GetScanDimensionsPixels_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetScanDimensionsPixels(IntPtr _arg)
	{
		vtkScancoCTReader_GetScanDimensionsPixels_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetScanDistance_36(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetScanDistance()
	{
		return vtkScancoCTReader_GetScanDistance_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetScannerID_37(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetScannerID()
	{
		return vtkScancoCTReader_GetScannerID_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetScannerType_38(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetScannerType()
	{
		return vtkScancoCTReader_GetScannerType_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_GetSite_39(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetSite()
	{
		return vtkScancoCTReader_GetSite_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetSliceIncrement_40(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetSliceIncrement()
	{
		return vtkScancoCTReader_GetSliceIncrement_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetSliceThickness_41(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetSliceThickness()
	{
		return vtkScancoCTReader_GetSliceThickness_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetStartPosition_42(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetStartPosition()
	{
		return vtkScancoCTReader_GetStartPosition_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_GetVersion_43(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetVersion()
	{
		return Marshal.PtrToStringAnsi(vtkScancoCTReader_GetVersion_43(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScancoCTReader_GetZPosition_44(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetZPosition()
	{
		return vtkScancoCTReader_GetZPosition_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_IsA_45(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScancoCTReader_IsA_45(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScancoCTReader_IsTypeOf_46(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScancoCTReader_IsTypeOf_46(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkScancoCTReader NewInstance()
	{
		vtkScancoCTReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScancoCTReader_NewInstance_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScancoCTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScancoCTReader_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScancoCTReader SafeDownCast(vtkObjectBase o)
	{
		vtkScancoCTReader vtkScancoCTReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScancoCTReader_SafeDownCast_49(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScancoCTReader2 = (vtkScancoCTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScancoCTReader2.Register(null);
			}
		}
		return vtkScancoCTReader2;
	}
}
