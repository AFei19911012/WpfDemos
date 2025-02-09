using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMedicalImageProperties
/// </summary>
/// <remarks>
///    some medical image properties.
///
/// vtkMedicalImageProperties is a helper class that can be used by medical
/// image readers and applications to encapsulate medical image/acquisition
/// properties. Later on, this should probably be extended to add
/// any user-defined property.
/// </remarks>
/// <seealso>
///
/// vtkMedicalImageReader2
/// </seealso>
public class vtkMedicalImageProperties : vtkObject
{
	/// <summary>
	/// Provides the inverse mapping. Returns -1 if a slice for this uid is
	/// not found.
	/// </summary>
	public enum OrientationType
	{
		/// <summary>enum member</summary>
		AXIAL,
		/// <summary>enum member</summary>
		CORONAL,
		/// <summary>enum member</summary>
		SAGITTAL
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMedicalImageProperties";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMedicalImageProperties()
	{
		MRClassNameKey = "class vtkMedicalImageProperties";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMedicalImageProperties"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMedicalImageProperties(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMedicalImageProperties New()
	{
		vtkMedicalImageProperties result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMedicalImageProperties_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMedicalImageProperties()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMedicalImageProperties_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_AddUserDefinedValue_01(HandleRef pThis, string name, string value);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual void AddUserDefinedValue(string name, string value)
	{
		vtkMedicalImageProperties_AddUserDefinedValue_01(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_AddWindowLevelPreset_02(HandleRef pThis, double w, double l);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual int AddWindowLevelPreset(double w, double l)
	{
		return vtkMedicalImageProperties_AddWindowLevelPreset_02(GetCppThis(), w, l);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_Clear_03(HandleRef pThis);

	/// <summary>
	/// Convenience method to reset all fields to an empty string/value
	/// </summary>
	public virtual void Clear()
	{
		vtkMedicalImageProperties_Clear_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_DeepCopy_04(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Copy the contents of p to this instance.
	/// </summary>
	public virtual void DeepCopy(vtkMedicalImageProperties p)
	{
		vtkMedicalImageProperties_DeepCopy_04(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetAcquisitionDate_05(HandleRef pThis);

	/// <summary>
	/// Acquisition Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0022) = 20030617
	/// </summary>
	public virtual string GetAcquisitionDate()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetAcquisitionDate_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetAcquisitionDateDay_06(HandleRef pThis);

	/// <summary>
	/// Acquisition Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0022) = 20030617
	/// </summary>
	public int GetAcquisitionDateDay()
	{
		return vtkMedicalImageProperties_GetAcquisitionDateDay_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetAcquisitionDateMonth_07(HandleRef pThis);

	/// <summary>
	/// Acquisition Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0022) = 20030617
	/// </summary>
	public int GetAcquisitionDateMonth()
	{
		return vtkMedicalImageProperties_GetAcquisitionDateMonth_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetAcquisitionDateYear_08(HandleRef pThis);

	/// <summary>
	/// Acquisition Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0022) = 20030617
	/// </summary>
	public int GetAcquisitionDateYear()
	{
		return vtkMedicalImageProperties_GetAcquisitionDateYear_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetAcquisitionTime_09(HandleRef pThis);

	/// <summary>
	/// Acquisition time
	/// Format: hhmmss.frac (any trailing component(s) can be omitted)
	/// For ex: DICOM (0008,0032) = 162552.0705 or 230012, or 0012
	/// </summary>
	public virtual string GetAcquisitionTime()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetAcquisitionTime_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetAgeAsFields_10(string age, ref int year, ref int month, ref int week, ref int day);

	/// <summary>
	/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
	/// different fields namely: year month week day
	/// Return 0 on error, 1 on success
	/// One can test fields if they are different from -1 upon success
	/// </summary>
	public static int GetAgeAsFields(string age, ref int year, ref int month, ref int week, ref int day)
	{
		return vtkMedicalImageProperties_GetAgeAsFields_10(age, ref year, ref month, ref week, ref day);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetConvolutionKernel_11(HandleRef pThis);

	/// <summary>
	/// Convolution Kernel (or algorithm used to reconstruct the data)
	/// For ex: DICOM (0018,1210) = Bone
	/// </summary>
	public virtual string GetConvolutionKernel()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetConvolutionKernel_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetDateAsFields_12(string date, ref int year, ref int month, ref int day);

	/// <summary>
	/// Take as input a string in ISO 8601 date (YYYY/MM/DD) and extract the
	/// different fields namely: year month day
	/// Return 0 on error, 1 on success
	/// </summary>
	public static int GetDateAsFields(string date, ref int year, ref int month, ref int day)
	{
		return vtkMedicalImageProperties_GetDateAsFields_12(date, ref year, ref month, ref day);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetDateAsLocale_13(string date, string locale);

	/// <summary>
	/// Take as input a string in ISO 8601 date (YYYY/MM/DD) and construct a
	/// locale date based on the different fields (see GetDateAsFields to extract
	/// different fields)
	/// Return 0 on error, 1 on success
	/// </summary>
	public static int GetDateAsLocale(string date, string locale)
	{
		return vtkMedicalImageProperties_GetDateAsLocale_13(date, locale);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetDirectionCosine_14(HandleRef pThis);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual double[] GetDirectionCosine()
	{
		IntPtr intPtr = vtkMedicalImageProperties_GetDirectionCosine_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_GetDirectionCosine_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual void GetDirectionCosine(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkMedicalImageProperties_GetDirectionCosine_15(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_GetDirectionCosine_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual void GetDirectionCosine(IntPtr _arg)
	{
		vtkMedicalImageProperties_GetDirectionCosine_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetEchoTime_17(HandleRef pThis);

	/// <summary>
	/// Echo Time
	/// (Time in ms between the middle of the excitation pulse and the peak of
	/// the echo produced)
	/// For ex: DICOM (0018,0081) = 105
	/// </summary>
	public virtual string GetEchoTime()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetEchoTime_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetEchoTrainLength_18(HandleRef pThis);

	/// <summary>
	/// Echo Train Length
	/// (Number of lines in k-space acquired per excitation per image)
	/// For ex: DICOM (0018,0091) = 35
	/// </summary>
	public virtual string GetEchoTrainLength()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetEchoTrainLength_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetExposure_19(HandleRef pThis);

	/// <summary>
	/// Exposure (The exposure expressed in mAs, for example calculated
	/// from Exposure Time and X-ray Tube Current)
	/// For ex: DICOM (0018,1152) = 114
	/// </summary>
	public virtual string GetExposure()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetExposure_19(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetExposureTime_20(HandleRef pThis);

	/// <summary>
	/// Exposure time (time of x-ray exposure in msec)
	/// For ex: DICOM (0018,1150) = 5
	/// </summary>
	public virtual string GetExposureTime()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetExposureTime_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetGantryTilt_21(HandleRef pThis);

	/// <summary>
	/// Gantry/Detector tilt (Nominal angle of tilt in degrees of the scanning
	/// gantry.)
	/// For ex: DICOM (0018,1120) = 15
	/// </summary>
	public virtual string GetGantryTilt()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetGantryTilt_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMedicalImageProperties_GetGantryTiltAsDouble_22(HandleRef pThis);

	/// <summary>
	/// Gantry/Detector tilt (Nominal angle of tilt in degrees of the scanning
	/// gantry.)
	/// For ex: DICOM (0018,1120) = 15
	/// </summary>
	public virtual double GetGantryTiltAsDouble()
	{
		return vtkMedicalImageProperties_GetGantryTiltAsDouble_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetImageDate_23(HandleRef pThis);

	/// <summary>
	/// Image Date aka Content Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0023) = 20030617
	/// </summary>
	public virtual string GetImageDate()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetImageDate_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetImageDateDay_24(HandleRef pThis);

	/// <summary>
	/// Image Date aka Content Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0023) = 20030617
	/// </summary>
	public int GetImageDateDay()
	{
		return vtkMedicalImageProperties_GetImageDateDay_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetImageDateMonth_25(HandleRef pThis);

	/// <summary>
	/// Image Date aka Content Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0023) = 20030617
	/// </summary>
	public int GetImageDateMonth()
	{
		return vtkMedicalImageProperties_GetImageDateMonth_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetImageDateYear_26(HandleRef pThis);

	/// <summary>
	/// Image Date aka Content Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0023) = 20030617
	/// </summary>
	public int GetImageDateYear()
	{
		return vtkMedicalImageProperties_GetImageDateYear_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetImageNumber_27(HandleRef pThis);

	/// <summary>
	/// Image number
	/// For ex: DICOM (0020,0013) = 1
	/// </summary>
	public virtual string GetImageNumber()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetImageNumber_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetImageTime_28(HandleRef pThis);

	/// <summary>
	/// Image Time
	/// Format: hhmmss.frac (any trailing component(s) can be omitted)
	/// For ex: DICOM (0008,0033) = 162552.0705 or 230012, or 0012
	/// </summary>
	public virtual string GetImageTime()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetImageTime_28(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetInstanceUIDFromSliceID_29(HandleRef pThis, int volumeidx, int sliceid);

	/// <summary>
	/// Mapping from a sliceidx within a volumeidx into a DICOM Instance UID
	/// Some DICOM reader can populate this structure so that later on from
	/// a slice index in a vtkImageData volume we can backtrack and find out
	/// which 2d slice it was coming from
	/// </summary>
	public string GetInstanceUIDFromSliceID(int volumeidx, int sliceid)
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetInstanceUIDFromSliceID_29(GetCppThis(), volumeidx, sliceid));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetInstitutionName_30(HandleRef pThis);

	/// <summary>
	/// Institution Name
	/// For ex: DICOM (0008,0080) = FooCity Medical Center
	/// </summary>
	public virtual string GetInstitutionName()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetInstitutionName_30(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetKVP_31(HandleRef pThis);

	/// <summary>
	/// Peak kilo voltage output of the (x-ray) generator used
	/// For ex: DICOM (0018,0060) = 120
	/// </summary>
	public virtual string GetKVP()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetKVP_31(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetManufacturer_32(HandleRef pThis);

	/// <summary>
	/// Manufacturer
	/// For ex: DICOM (0008,0070) = Siemens
	/// </summary>
	public virtual string GetManufacturer()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetManufacturer_32(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetManufacturerModelName_33(HandleRef pThis);

	/// <summary>
	/// Manufacturer's Model Name
	/// For ex: DICOM (0008,1090) = LightSpeed QX/i
	/// </summary>
	public virtual string GetManufacturerModelName()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetManufacturerModelName_33(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetModality_34(HandleRef pThis);

	/// <summary>
	/// Modality
	/// For ex: DICOM (0008,0060)= CT
	/// </summary>
	public virtual string GetModality()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetModality_34(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetNthWindowLevelPreset_35(HandleRef pThis, int idx, IntPtr w, IntPtr l);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual int GetNthWindowLevelPreset(int idx, IntPtr w, IntPtr l)
	{
		return vtkMedicalImageProperties_GetNthWindowLevelPreset_35(GetCppThis(), idx, w, l);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetNthWindowLevelPreset_36(HandleRef pThis, int idx);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual double[] GetNthWindowLevelPreset(int idx)
	{
		IntPtr intPtr = vtkMedicalImageProperties_GetNthWindowLevelPreset_36(GetCppThis(), idx);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetNthWindowLevelPresetComment_37(HandleRef pThis, int idx);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual string GetNthWindowLevelPresetComment(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetNthWindowLevelPresetComment_37(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMedicalImageProperties_GetNumberOfGenerationsFromBase_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMedicalImageProperties_GetNumberOfGenerationsFromBase_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMedicalImageProperties_GetNumberOfGenerationsFromBaseType_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMedicalImageProperties_GetNumberOfGenerationsFromBaseType_39(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkMedicalImageProperties_GetNumberOfUserDefinedValues_40(HandleRef pThis);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual uint GetNumberOfUserDefinedValues()
	{
		return vtkMedicalImageProperties_GetNumberOfUserDefinedValues_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetNumberOfWindowLevelPresets_41(HandleRef pThis);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual int GetNumberOfWindowLevelPresets()
	{
		return vtkMedicalImageProperties_GetNumberOfWindowLevelPresets_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetOrientationType_42(HandleRef pThis, int volumeidx);

	/// <summary>
	/// Provides the inverse mapping. Returns -1 if a slice for this uid is
	/// not found.
	/// </summary>
	public int GetOrientationType(int volumeidx)
	{
		return vtkMedicalImageProperties_GetOrientationType_42(GetCppThis(), volumeidx);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetPatientAge_43(HandleRef pThis);

	/// <summary>
	/// Patient age
	/// Format: nnnD, nnW, nnnM or nnnY (eventually nnD, nnW, nnY)
	/// with D (day), M (month), W (week), Y (year)
	/// For ex: DICOM (0010,1010) = 031Y
	/// </summary>
	public virtual string GetPatientAge()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetPatientAge_43(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetPatientAgeDay_44(HandleRef pThis);

	/// <summary>
	/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
	/// different fields namely: year month week day
	/// Return 0 on error, 1 on success
	/// One can test fields if they are different from -1 upon success
	/// </summary>
	public int GetPatientAgeDay()
	{
		return vtkMedicalImageProperties_GetPatientAgeDay_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetPatientAgeMonth_45(HandleRef pThis);

	/// <summary>
	/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
	/// different fields namely: year month week day
	/// Return 0 on error, 1 on success
	/// One can test fields if they are different from -1 upon success
	/// </summary>
	public int GetPatientAgeMonth()
	{
		return vtkMedicalImageProperties_GetPatientAgeMonth_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetPatientAgeWeek_46(HandleRef pThis);

	/// <summary>
	/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
	/// different fields namely: year month week day
	/// Return 0 on error, 1 on success
	/// One can test fields if they are different from -1 upon success
	/// </summary>
	public int GetPatientAgeWeek()
	{
		return vtkMedicalImageProperties_GetPatientAgeWeek_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetPatientAgeYear_47(HandleRef pThis);

	/// <summary>
	/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
	/// different fields namely: year month week day
	/// Return 0 on error, 1 on success
	/// One can test fields if they are different from -1 upon success
	/// </summary>
	public int GetPatientAgeYear()
	{
		return vtkMedicalImageProperties_GetPatientAgeYear_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetPatientBirthDate_48(HandleRef pThis);

	/// <summary>
	/// Patient birth date
	/// Format: yyyymmdd
	/// For ex: DICOM (0010,0030) = 19680427
	/// </summary>
	public virtual string GetPatientBirthDate()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetPatientBirthDate_48(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetPatientBirthDateDay_49(HandleRef pThis);

	/// <summary>
	/// Patient birth date
	/// Format: yyyymmdd
	/// For ex: DICOM (0010,0030) = 19680427
	/// </summary>
	public int GetPatientBirthDateDay()
	{
		return vtkMedicalImageProperties_GetPatientBirthDateDay_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetPatientBirthDateMonth_50(HandleRef pThis);

	/// <summary>
	/// Patient birth date
	/// Format: yyyymmdd
	/// For ex: DICOM (0010,0030) = 19680427
	/// </summary>
	public int GetPatientBirthDateMonth()
	{
		return vtkMedicalImageProperties_GetPatientBirthDateMonth_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetPatientBirthDateYear_51(HandleRef pThis);

	/// <summary>
	/// Patient birth date
	/// Format: yyyymmdd
	/// For ex: DICOM (0010,0030) = 19680427
	/// </summary>
	public int GetPatientBirthDateYear()
	{
		return vtkMedicalImageProperties_GetPatientBirthDateYear_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetPatientID_52(HandleRef pThis);

	/// <summary>
	/// Patient ID
	/// For ex: DICOM (0010,0020) = 1933197
	/// </summary>
	public virtual string GetPatientID()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetPatientID_52(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetPatientName_53(HandleRef pThis);

	/// <summary>
	/// Patient name
	/// For ex: DICOM (0010,0010) = DOE,JOHN
	/// </summary>
	public virtual string GetPatientName()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetPatientName_53(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetPatientSex_54(HandleRef pThis);

	/// <summary>
	/// Patient sex
	/// For ex: DICOM (0010,0040) = M
	/// </summary>
	public virtual string GetPatientSex()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetPatientSex_54(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetRepetitionTime_55(HandleRef pThis);

	/// <summary>
	/// Repetition Time
	/// The period of time in msec between the beginning of a pulse sequence and
	/// the beginning of the succeeding (essentially identical) pulse sequence.
	/// For ex: DICOM (0018,0080) = 2040
	/// </summary>
	public virtual string GetRepetitionTime()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetRepetitionTime_55(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetSeriesDescription_56(HandleRef pThis);

	/// <summary>
	/// Series Description
	/// User provided description of the Series
	/// For ex: DICOM (0008,103e) = SCOUT
	/// </summary>
	public virtual string GetSeriesDescription()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetSeriesDescription_56(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetSeriesNumber_57(HandleRef pThis);

	/// <summary>
	/// Series number
	/// For ex: DICOM (0020,0011) = 902
	/// </summary>
	public virtual string GetSeriesNumber()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetSeriesNumber_57(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetSliceIDFromInstanceUID_58(HandleRef pThis, ref int volumeidx, string uid);

	/// <summary>
	/// Provides the inverse mapping. Returns -1 if a slice for this uid is
	/// not found.
	/// </summary>
	public int GetSliceIDFromInstanceUID(ref int volumeidx, string uid)
	{
		return vtkMedicalImageProperties_GetSliceIDFromInstanceUID_58(GetCppThis(), ref volumeidx, uid);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetSliceThickness_59(HandleRef pThis);

	/// <summary>
	/// Slice Thickness (Nominal reconstructed slice thickness, in mm)
	/// For ex: DICOM (0018,0050) = 0.273438
	/// </summary>
	public virtual string GetSliceThickness()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetSliceThickness_59(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMedicalImageProperties_GetSliceThicknessAsDouble_60(HandleRef pThis);

	/// <summary>
	/// Slice Thickness (Nominal reconstructed slice thickness, in mm)
	/// For ex: DICOM (0018,0050) = 0.273438
	/// </summary>
	public virtual double GetSliceThicknessAsDouble()
	{
		return vtkMedicalImageProperties_GetSliceThicknessAsDouble_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetStationName_61(HandleRef pThis);

	/// <summary>
	/// Station Name
	/// For ex: DICOM (0008,1010) = LSPD_OC8
	/// </summary>
	public virtual string GetStationName()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetStationName_61(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetStringFromOrientationType_62(uint type);

	/// <summary>
	/// Provides the inverse mapping. Returns -1 if a slice for this uid is
	/// not found.
	/// </summary>
	public static string GetStringFromOrientationType(uint type)
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetStringFromOrientationType_62(type));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetStudyDate_63(HandleRef pThis);

	/// <summary>
	/// Study Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0020) = 20030617
	/// </summary>
	public virtual string GetStudyDate()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetStudyDate_63(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetStudyDescription_64(HandleRef pThis);

	/// <summary>
	/// Study description
	/// For ex: DICOM (0008,1030) = BRAIN/C-SP/FACIAL
	/// </summary>
	public virtual string GetStudyDescription()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetStudyDescription_64(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetStudyID_65(HandleRef pThis);

	/// <summary>
	/// Study ID
	/// For ex: DICOM (0020,0010) = 37481
	/// </summary>
	public virtual string GetStudyID()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetStudyID_65(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetStudyTime_66(HandleRef pThis);

	/// <summary>
	/// Study Time
	/// Format: hhmmss.frac (any trailing component(s) can be omitted)
	/// For ex: DICOM (0008,0030) = 162552.0705 or 230012, or 0012
	/// </summary>
	public virtual string GetStudyTime()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetStudyTime_66(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetTimeAsFields_67(string time, ref int hour, ref int minute, ref int second);

	/// <summary>
	/// Take as input a string in VR:TM format (HHMMSS) and extract the
	/// different fields namely: hour, minute and second
	/// Return 0 on error, 1 on success
	/// </summary>
	public static int GetTimeAsFields(string time, ref int hour, ref int minute, ref int second)
	{
		return vtkMedicalImageProperties_GetTimeAsFields_67(time, ref hour, ref minute, ref second);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedNameByIndex_68(HandleRef pThis, uint idx);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual string GetUserDefinedNameByIndex(uint idx)
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetUserDefinedNameByIndex_68(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedValue_69(HandleRef pThis, string name);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual string GetUserDefinedValue(string name)
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetUserDefinedValue_69(GetCppThis(), name));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedValueByIndex_70(HandleRef pThis, uint idx);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual string GetUserDefinedValueByIndex(uint idx)
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetUserDefinedValueByIndex_70(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_GetWindowLevelPresetIndex_71(HandleRef pThis, double w, double l);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual int GetWindowLevelPresetIndex(double w, double l)
	{
		return vtkMedicalImageProperties_GetWindowLevelPresetIndex_71(GetCppThis(), w, l);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_GetXRayTubeCurrent_72(HandleRef pThis);

	/// <summary>
	/// X-ray tube current (in mA)
	/// For ex: DICOM (0018,1151) = 400
	/// </summary>
	public virtual string GetXRayTubeCurrent()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageProperties_GetXRayTubeCurrent_72(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_HasWindowLevelPreset_73(HandleRef pThis, double w, double l);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual int HasWindowLevelPreset(double w, double l)
	{
		return vtkMedicalImageProperties_HasWindowLevelPreset_73(GetCppThis(), w, l);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_IsA_74(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMedicalImageProperties_IsA_74(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageProperties_IsTypeOf_75(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMedicalImageProperties_IsTypeOf_75(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_NewInstance_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMedicalImageProperties NewInstance()
	{
		vtkMedicalImageProperties result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMedicalImageProperties_NewInstance_77(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_RemoveAllUserDefinedValues_78(HandleRef pThis);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual void RemoveAllUserDefinedValues()
	{
		vtkMedicalImageProperties_RemoveAllUserDefinedValues_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_RemoveAllWindowLevelPresets_79(HandleRef pThis);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual void RemoveAllWindowLevelPresets()
	{
		vtkMedicalImageProperties_RemoveAllWindowLevelPresets_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_RemoveWindowLevelPreset_80(HandleRef pThis, double w, double l);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual void RemoveWindowLevelPreset(double w, double l)
	{
		vtkMedicalImageProperties_RemoveWindowLevelPreset_80(GetCppThis(), w, l);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageProperties_SafeDownCast_81(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMedicalImageProperties SafeDownCast(vtkObjectBase o)
	{
		vtkMedicalImageProperties vtkMedicalImageProperties2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMedicalImageProperties_SafeDownCast_81(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetAcquisitionDate_82(HandleRef pThis, string _arg);

	/// <summary>
	/// Acquisition Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0022) = 20030617
	/// </summary>
	public virtual void SetAcquisitionDate(string _arg)
	{
		vtkMedicalImageProperties_SetAcquisitionDate_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetAcquisitionTime_83(HandleRef pThis, string _arg);

	/// <summary>
	/// Acquisition time
	/// Format: hhmmss.frac (any trailing component(s) can be omitted)
	/// For ex: DICOM (0008,0032) = 162552.0705 or 230012, or 0012
	/// </summary>
	public virtual void SetAcquisitionTime(string _arg)
	{
		vtkMedicalImageProperties_SetAcquisitionTime_83(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetConvolutionKernel_84(HandleRef pThis, string _arg);

	/// <summary>
	/// Convolution Kernel (or algorithm used to reconstruct the data)
	/// For ex: DICOM (0018,1210) = Bone
	/// </summary>
	public virtual void SetConvolutionKernel(string _arg)
	{
		vtkMedicalImageProperties_SetConvolutionKernel_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetDirectionCosine_85(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual void SetDirectionCosine(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkMedicalImageProperties_SetDirectionCosine_85(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetDirectionCosine_86(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the direction cosine (default to 1,0,0,0,1,0)
	/// </summary>
	public virtual void SetDirectionCosine(IntPtr _arg)
	{
		vtkMedicalImageProperties_SetDirectionCosine_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetEchoTime_87(HandleRef pThis, string _arg);

	/// <summary>
	/// Echo Time
	/// (Time in ms between the middle of the excitation pulse and the peak of
	/// the echo produced)
	/// For ex: DICOM (0018,0081) = 105
	/// </summary>
	public virtual void SetEchoTime(string _arg)
	{
		vtkMedicalImageProperties_SetEchoTime_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetEchoTrainLength_88(HandleRef pThis, string _arg);

	/// <summary>
	/// Echo Train Length
	/// (Number of lines in k-space acquired per excitation per image)
	/// For ex: DICOM (0018,0091) = 35
	/// </summary>
	public virtual void SetEchoTrainLength(string _arg)
	{
		vtkMedicalImageProperties_SetEchoTrainLength_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetExposure_89(HandleRef pThis, string _arg);

	/// <summary>
	/// Exposure (The exposure expressed in mAs, for example calculated
	/// from Exposure Time and X-ray Tube Current)
	/// For ex: DICOM (0018,1152) = 114
	/// </summary>
	public virtual void SetExposure(string _arg)
	{
		vtkMedicalImageProperties_SetExposure_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetExposureTime_90(HandleRef pThis, string _arg);

	/// <summary>
	/// Exposure time (time of x-ray exposure in msec)
	/// For ex: DICOM (0018,1150) = 5
	/// </summary>
	public virtual void SetExposureTime(string _arg)
	{
		vtkMedicalImageProperties_SetExposureTime_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetGantryTilt_91(HandleRef pThis, string _arg);

	/// <summary>
	/// Gantry/Detector tilt (Nominal angle of tilt in degrees of the scanning
	/// gantry.)
	/// For ex: DICOM (0018,1120) = 15
	/// </summary>
	public virtual void SetGantryTilt(string _arg)
	{
		vtkMedicalImageProperties_SetGantryTilt_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetImageDate_92(HandleRef pThis, string _arg);

	/// <summary>
	/// Image Date aka Content Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0023) = 20030617
	/// </summary>
	public virtual void SetImageDate(string _arg)
	{
		vtkMedicalImageProperties_SetImageDate_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetImageNumber_93(HandleRef pThis, string _arg);

	/// <summary>
	/// Image number
	/// For ex: DICOM (0020,0013) = 1
	/// </summary>
	public virtual void SetImageNumber(string _arg)
	{
		vtkMedicalImageProperties_SetImageNumber_93(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetImageTime_94(HandleRef pThis, string _arg);

	/// <summary>
	/// Image Time
	/// Format: hhmmss.frac (any trailing component(s) can be omitted)
	/// For ex: DICOM (0008,0033) = 162552.0705 or 230012, or 0012
	/// </summary>
	public virtual void SetImageTime(string _arg)
	{
		vtkMedicalImageProperties_SetImageTime_94(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetInstanceUIDFromSliceID_95(HandleRef pThis, int volumeidx, int sliceid, string uid);

	/// <summary>
	/// Mapping from a sliceidx within a volumeidx into a DICOM Instance UID
	/// Some DICOM reader can populate this structure so that later on from
	/// a slice index in a vtkImageData volume we can backtrack and find out
	/// which 2d slice it was coming from
	/// </summary>
	public void SetInstanceUIDFromSliceID(int volumeidx, int sliceid, string uid)
	{
		vtkMedicalImageProperties_SetInstanceUIDFromSliceID_95(GetCppThis(), volumeidx, sliceid, uid);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetInstitutionName_96(HandleRef pThis, string _arg);

	/// <summary>
	/// Institution Name
	/// For ex: DICOM (0008,0080) = FooCity Medical Center
	/// </summary>
	public virtual void SetInstitutionName(string _arg)
	{
		vtkMedicalImageProperties_SetInstitutionName_96(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetKVP_97(HandleRef pThis, string _arg);

	/// <summary>
	/// Peak kilo voltage output of the (x-ray) generator used
	/// For ex: DICOM (0018,0060) = 120
	/// </summary>
	public virtual void SetKVP(string _arg)
	{
		vtkMedicalImageProperties_SetKVP_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetManufacturer_98(HandleRef pThis, string _arg);

	/// <summary>
	/// Manufacturer
	/// For ex: DICOM (0008,0070) = Siemens
	/// </summary>
	public virtual void SetManufacturer(string _arg)
	{
		vtkMedicalImageProperties_SetManufacturer_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetManufacturerModelName_99(HandleRef pThis, string _arg);

	/// <summary>
	/// Manufacturer's Model Name
	/// For ex: DICOM (0008,1090) = LightSpeed QX/i
	/// </summary>
	public virtual void SetManufacturerModelName(string _arg)
	{
		vtkMedicalImageProperties_SetManufacturerModelName_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetModality_100(HandleRef pThis, string _arg);

	/// <summary>
	/// Modality
	/// For ex: DICOM (0008,0060)= CT
	/// </summary>
	public virtual void SetModality(string _arg)
	{
		vtkMedicalImageProperties_SetModality_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetNthWindowLevelPresetComment_101(HandleRef pThis, int idx, string comment);

	/// <summary>
	/// Add/Remove/Query the window/level presets that may have been associated
	/// to a medical image. Window is also known as 'width', level is also known
	/// as 'center'. The same window/level pair can not be added twice.
	/// As a convenience, a comment (aka Explanation) can be associated to
	/// a preset.
	/// For ex:
	/// \verbatim
	/// DICOM Window Center (0028,1050) = 00045\000470
	/// DICOM Window Width  (0028,1051) = 0106\03412
	/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
	/// \endverbatim
	/// </summary>
	public virtual void SetNthWindowLevelPresetComment(int idx, string comment)
	{
		vtkMedicalImageProperties_SetNthWindowLevelPresetComment_101(GetCppThis(), idx, comment);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetOrientationType_102(HandleRef pThis, int volumeidx, int orientation);

	/// <summary>
	/// Provides the inverse mapping. Returns -1 if a slice for this uid is
	/// not found.
	/// </summary>
	public void SetOrientationType(int volumeidx, int orientation)
	{
		vtkMedicalImageProperties_SetOrientationType_102(GetCppThis(), volumeidx, orientation);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetPatientAge_103(HandleRef pThis, string _arg);

	/// <summary>
	/// Patient age
	/// Format: nnnD, nnW, nnnM or nnnY (eventually nnD, nnW, nnY)
	/// with D (day), M (month), W (week), Y (year)
	/// For ex: DICOM (0010,1010) = 031Y
	/// </summary>
	public virtual void SetPatientAge(string _arg)
	{
		vtkMedicalImageProperties_SetPatientAge_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetPatientBirthDate_104(HandleRef pThis, string _arg);

	/// <summary>
	/// Patient birth date
	/// Format: yyyymmdd
	/// For ex: DICOM (0010,0030) = 19680427
	/// </summary>
	public virtual void SetPatientBirthDate(string _arg)
	{
		vtkMedicalImageProperties_SetPatientBirthDate_104(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetPatientID_105(HandleRef pThis, string _arg);

	/// <summary>
	/// Patient ID
	/// For ex: DICOM (0010,0020) = 1933197
	/// </summary>
	public virtual void SetPatientID(string _arg)
	{
		vtkMedicalImageProperties_SetPatientID_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetPatientName_106(HandleRef pThis, string _arg);

	/// <summary>
	/// Patient name
	/// For ex: DICOM (0010,0010) = DOE,JOHN
	/// </summary>
	public virtual void SetPatientName(string _arg)
	{
		vtkMedicalImageProperties_SetPatientName_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetPatientSex_107(HandleRef pThis, string _arg);

	/// <summary>
	/// Patient sex
	/// For ex: DICOM (0010,0040) = M
	/// </summary>
	public virtual void SetPatientSex(string _arg)
	{
		vtkMedicalImageProperties_SetPatientSex_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetRepetitionTime_108(HandleRef pThis, string _arg);

	/// <summary>
	/// Repetition Time
	/// The period of time in msec between the beginning of a pulse sequence and
	/// the beginning of the succeeding (essentially identical) pulse sequence.
	/// For ex: DICOM (0018,0080) = 2040
	/// </summary>
	public virtual void SetRepetitionTime(string _arg)
	{
		vtkMedicalImageProperties_SetRepetitionTime_108(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetSeriesDescription_109(HandleRef pThis, string _arg);

	/// <summary>
	/// Series Description
	/// User provided description of the Series
	/// For ex: DICOM (0008,103e) = SCOUT
	/// </summary>
	public virtual void SetSeriesDescription(string _arg)
	{
		vtkMedicalImageProperties_SetSeriesDescription_109(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetSeriesNumber_110(HandleRef pThis, string _arg);

	/// <summary>
	/// Series number
	/// For ex: DICOM (0020,0011) = 902
	/// </summary>
	public virtual void SetSeriesNumber(string _arg)
	{
		vtkMedicalImageProperties_SetSeriesNumber_110(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetSliceThickness_111(HandleRef pThis, string _arg);

	/// <summary>
	/// Slice Thickness (Nominal reconstructed slice thickness, in mm)
	/// For ex: DICOM (0018,0050) = 0.273438
	/// </summary>
	public virtual void SetSliceThickness(string _arg)
	{
		vtkMedicalImageProperties_SetSliceThickness_111(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetStationName_112(HandleRef pThis, string _arg);

	/// <summary>
	/// Station Name
	/// For ex: DICOM (0008,1010) = LSPD_OC8
	/// </summary>
	public virtual void SetStationName(string _arg)
	{
		vtkMedicalImageProperties_SetStationName_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetStudyDate_113(HandleRef pThis, string _arg);

	/// <summary>
	/// Study Date
	/// Format: yyyymmdd
	/// For ex: DICOM (0008,0020) = 20030617
	/// </summary>
	public virtual void SetStudyDate(string _arg)
	{
		vtkMedicalImageProperties_SetStudyDate_113(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetStudyDescription_114(HandleRef pThis, string _arg);

	/// <summary>
	/// Study description
	/// For ex: DICOM (0008,1030) = BRAIN/C-SP/FACIAL
	/// </summary>
	public virtual void SetStudyDescription(string _arg)
	{
		vtkMedicalImageProperties_SetStudyDescription_114(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetStudyID_115(HandleRef pThis, string _arg);

	/// <summary>
	/// Study ID
	/// For ex: DICOM (0020,0010) = 37481
	/// </summary>
	public virtual void SetStudyID(string _arg)
	{
		vtkMedicalImageProperties_SetStudyID_115(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetStudyTime_116(HandleRef pThis, string _arg);

	/// <summary>
	/// Study Time
	/// Format: hhmmss.frac (any trailing component(s) can be omitted)
	/// For ex: DICOM (0008,0030) = 162552.0705 or 230012, or 0012
	/// </summary>
	public virtual void SetStudyTime(string _arg)
	{
		vtkMedicalImageProperties_SetStudyTime_116(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageProperties_SetXRayTubeCurrent_117(HandleRef pThis, string _arg);

	/// <summary>
	/// X-ray tube current (in mA)
	/// For ex: DICOM (0018,1151) = 400
	/// </summary>
	public virtual void SetXRayTubeCurrent(string _arg)
	{
		vtkMedicalImageProperties_SetXRayTubeCurrent_117(GetCppThis(), _arg);
	}
}
