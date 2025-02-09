using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNIFTIImageHeader
/// </summary>
/// <remarks>
///    Store NIfTI header information.
///
/// This class stores the header of a NIfTI file in a VTK-friendly format.
/// By using this class, it is possible to specify the header information
/// that will be stored in a file written by the vtkNIFTIImageWriter.  Note
/// that the SForm and QForm orientation information in this class will be
/// ignored by the writer if an SForm and QForm have been explicitly set
/// via the writer's SetSForm and SetQForm methods.  Also note that all
/// info like Dim, PixDim, DataType, etc. will be ignored by the writer
/// because this information must instead be taken from the vtkImageData
/// information.  Finally, note that the vtkNIFTIImageWriter will ignore the
/// Descrip field, since it has its own SetDescription method.
/// @par Thanks:
/// This class was contributed to VTK by the Calgary Image Processing and
/// Analysis Centre (CIPAC).
/// </remarks>
/// <seealso>
///
/// vtkNIFTIImageReader, vtkNIFTIImageWriter
/// </seealso>
public class vtkNIFTIImageHeader : vtkObject
{
	/// <summary>
	/// NIFTI data types.
	/// Types RGB24 and RGB32 are represented in VTK as a multi-component
	/// unsigned char image.  Complex values are represented as two-component
	/// images.  The NIFTI types Float128 and Complex256 are not supported.
	/// </summary>
	public enum DataTypeEnum
	{
		/// <summary>enum member</summary>
		TypeComplex128 = 1792,
		/// <summary>enum member</summary>
		TypeComplex256 = 2048,
		/// <summary>enum member</summary>
		TypeComplex64 = 32,
		/// <summary>enum member</summary>
		TypeFloat128 = 1536,
		/// <summary>enum member</summary>
		TypeFloat32 = 16,
		/// <summary>enum member</summary>
		TypeFloat64 = 64,
		/// <summary>enum member</summary>
		TypeInt16 = 4,
		/// <summary>enum member</summary>
		TypeInt32 = 8,
		/// <summary>enum member</summary>
		TypeInt64 = 1024,
		/// <summary>enum member</summary>
		TypeInt8 = 256,
		/// <summary>enum member</summary>
		TypeRGB24 = 128,
		/// <summary>enum member</summary>
		TypeRGBA32 = 2304,
		/// <summary>enum member</summary>
		TypeUInt16 = 512,
		/// <summary>enum member</summary>
		TypeUInt32 = 768,
		/// <summary>enum member</summary>
		TypeUInt64 = 1280,
		/// <summary>enum member</summary>
		TypeUInt8 = 2
	}

	/// <summary>
	/// NIFTI header sizes.
	/// </summary>
	public enum HeaderSizeEnum
	{
		/// <summary>enum member</summary>
		NIFTI1HeaderSize = 348,
		/// <summary>enum member</summary>
		NIFTI2HeaderSize = 540
	}

	/// <summary>
	/// NIFTI intent codes.
	/// </summary>
	public enum IntentCodeEnum
	{
		/// <summary>enum member</summary>
		IntentBeta = 7,
		/// <summary>enum member</summary>
		IntentBinom = 8,
		/// <summary>enum member</summary>
		IntentChi = 19,
		/// <summary>enum member</summary>
		IntentChiSQ = 6,
		/// <summary>enum member</summary>
		IntentChiSQNonc = 13,
		/// <summary>enum member</summary>
		IntentCorrel = 2,
		/// <summary>enum member</summary>
		IntentDimless = 1011,
		/// <summary>enum member</summary>
		IntentDispVect = 1006,
		/// <summary>enum member</summary>
		IntentEstimate = 1001,
		/// <summary>enum member</summary>
		IntentExtVal = 21,
		/// <summary>enum member</summary>
		IntentFTest = 4,
		/// <summary>enum member</summary>
		IntentFTestNonc = 12,
		/// <summary>enum member</summary>
		IntentGamma = 9,
		/// <summary>enum member</summary>
		IntentGenMatrix = 1004,
		/// <summary>enum member</summary>
		IntentInvGauss = 20,
		/// <summary>enum member</summary>
		IntentLabel = 1002,
		/// <summary>enum member</summary>
		IntentLaplace = 15,
		/// <summary>enum member</summary>
		IntentLog10PVal = 24,
		/// <summary>enum member</summary>
		IntentLogPVal = 23,
		/// <summary>enum member</summary>
		IntentLogistic = 14,
		/// <summary>enum member</summary>
		IntentNeuroName = 1003,
		/// <summary>enum member</summary>
		IntentNodeIndex = 2002,
		/// <summary>enum member</summary>
		IntentNone = 0,
		/// <summary>enum member</summary>
		IntentNormal = 11,
		/// <summary>enum member</summary>
		IntentPVal = 22,
		/// <summary>enum member</summary>
		IntentPointSet = 1008,
		/// <summary>enum member</summary>
		IntentPoisson = 10,
		/// <summary>enum member</summary>
		IntentQuaternion = 1010,
		/// <summary>enum member</summary>
		IntentRGBAVector = 2004,
		/// <summary>enum member</summary>
		IntentRGBVector = 2003,
		/// <summary>enum member</summary>
		IntentShape = 2005,
		/// <summary>enum member</summary>
		IntentSymMatrix = 1005,
		/// <summary>enum member</summary>
		IntentTTest = 3,
		/// <summary>enum member</summary>
		IntentTTestNonc = 17,
		/// <summary>enum member</summary>
		IntentTimeSeries = 2001,
		/// <summary>enum member</summary>
		IntentTriangle = 1009,
		/// <summary>enum member</summary>
		IntentUniform = 16,
		/// <summary>enum member</summary>
		IntentVector = 1007,
		/// <summary>enum member</summary>
		IntentWeibull = 18,
		/// <summary>enum member</summary>
		IntentZScore = 5
	}

	/// <summary>
	/// NIFTI slice codes.
	/// </summary>
	public enum SliceCodeEnum
	{
		/// <summary>enum member</summary>
		SliceAltDec = 4,
		/// <summary>enum member</summary>
		SliceAltDec2 = 6,
		/// <summary>enum member</summary>
		SliceAltInc = 3,
		/// <summary>enum member</summary>
		SliceAltInc2 = 5,
		/// <summary>enum member</summary>
		SliceSeqDec = 2,
		/// <summary>enum member</summary>
		SliceSeqInc = 1,
		/// <summary>enum member</summary>
		SliceUnknown = 0
	}

	/// <summary>
	/// NIFTI unit codes.
	/// </summary>
	public enum UnitsXYZTEnum
	{
		/// <summary>enum member</summary>
		UnitsHz = 32,
		/// <summary>enum member</summary>
		UnitsMM = 2,
		/// <summary>enum member</summary>
		UnitsMSec = 16,
		/// <summary>enum member</summary>
		UnitsMeter = 1,
		/// <summary>enum member</summary>
		UnitsMicron = 3,
		/// <summary>enum member</summary>
		UnitsPPM = 40,
		/// <summary>enum member</summary>
		UnitsRads = 48,
		/// <summary>enum member</summary>
		UnitsSec = 8,
		/// <summary>enum member</summary>
		UnitsSpace = 7,
		/// <summary>enum member</summary>
		UnitsTime = 56,
		/// <summary>enum member</summary>
		UnitsUSec = 24,
		/// <summary>enum member</summary>
		UnitsUnknown = 0
	}

	/// <summary>
	/// NIFTI transform codes.
	/// </summary>
	public enum XFormCodeEnum
	{
		/// <summary>enum member</summary>
		XFormAlignedAnat = 2,
		/// <summary>enum member</summary>
		XFormMNI152 = 4,
		/// <summary>enum member</summary>
		XFormScannerAnat = 1,
		/// <summary>enum member</summary>
		XFormTalairach = 3,
		/// <summary>enum member</summary>
		XFormUnkown = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIImageHeader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNIFTIImageHeader()
	{
		MRClassNameKey = "class vtkNIFTIImageHeader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIImageHeader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNIFTIImageHeader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static vtkNIFTIImageHeader New()
	{
		vtkNIFTIImageHeader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageHeader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIImageHeader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public vtkNIFTIImageHeader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNIFTIImageHeader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkNIFTIImageHeader_DeepCopy_01(HandleRef pThis, HandleRef o);

	/// <summary>
	/// Make a copy of the header.
	/// </summary>
	public void DeepCopy(vtkNIFTIImageHeader o)
	{
		vtkNIFTIImageHeader_DeepCopy_01(GetCppThis(), o?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_GetAuxFile_02(HandleRef pThis);

	/// <summary>
	/// Get an auxiliary file, e.g. a color table, that is associated
	/// with this data.  The length of the filename must be a maximum of
	/// 24 characters, and it will be assumed to be in the same directory
	/// as the NIFTI file.
	/// </summary>
	public string GetAuxFile()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIImageHeader_GetAuxFile_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_GetBitPix_03(HandleRef pThis);

	/// <summary>
	/// Get the number of bits per pixel.
	/// </summary>
	public int GetBitPix()
	{
		return vtkNIFTIImageHeader_GetBitPix_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetCalMax_04(HandleRef pThis);

	/// <summary>
	/// Get the calibrated range of the data, i.e. the values stored in the
	/// cal_min and cal_max fields in the header.
	/// </summary>
	public double GetCalMax()
	{
		return vtkNIFTIImageHeader_GetCalMax_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetCalMin_05(HandleRef pThis);

	/// <summary>
	/// Get the calibrated range of the data, i.e. the values stored in the
	/// cal_min and cal_max fields in the header.
	/// </summary>
	public double GetCalMin()
	{
		return vtkNIFTIImageHeader_GetCalMin_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_GetDataType_06(HandleRef pThis);

	/// <summary>
	/// Get the data type.
	/// </summary>
	public int GetDataType()
	{
		return vtkNIFTIImageHeader_GetDataType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_GetDescrip_07(HandleRef pThis);

	/// <summary>
	/// Get a null-terminated file descriptor, this usually gives the
	/// name of the software that wrote the file. It will have a maximum
	/// length of 80 characters.  Use ASCII to ensure compatibility with
	/// all NIFTI software, the NIFTI standard itself does not specify what
	/// encodings are permitted.
	/// </summary>
	public string GetDescrip()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIImageHeader_GetDescrip_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageHeader_GetDim_08(HandleRef pThis, int i);

	/// <summary>
	/// Get the nth dimension of the data, where GetDim(0) returns the
	/// number of dimensions that are defined for the file.
	/// </summary>
	public long GetDim(int i)
	{
		return vtkNIFTIImageHeader_GetDim_08(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_GetDimInfo_09(HandleRef pThis);

	/// <summary>
	/// Get a bitfield with extra information about the dimensions, it
	/// states which dimensions are the phase encode, frequency encode,
	/// and slice encode dimensions for MRI acquisitions.
	/// </summary>
	public int GetDimInfo()
	{
		return vtkNIFTIImageHeader_GetDimInfo_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_GetIntentCode_10(HandleRef pThis);

	/// <summary>
	/// Get the NIFTI intent code.  This is an enumerated value in the NIFTI
	/// header that states what the data is intended to be used for.
	/// </summary>
	public int GetIntentCode()
	{
		return vtkNIFTIImageHeader_GetIntentCode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_GetIntentName_11(HandleRef pThis);

	/// <summary>
	/// Get the intent name.  This should match the intent code.
	/// </summary>
	public string GetIntentName()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIImageHeader_GetIntentName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetIntentP1_12(HandleRef pThis);

	/// <summary>
	/// Get one of the NIFTI intent parameters.  The definition of these
	/// parameters varies according to the IntentCode.
	/// </summary>
	public double GetIntentP1()
	{
		return vtkNIFTIImageHeader_GetIntentP1_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetIntentP2_13(HandleRef pThis);

	/// <summary>
	/// Get one of the NIFTI intent parameters.  The definition of these
	/// parameters varies according to the IntentCode.
	/// </summary>
	public double GetIntentP2()
	{
		return vtkNIFTIImageHeader_GetIntentP2_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetIntentP3_14(HandleRef pThis);

	/// <summary>
	/// Get one of the NIFTI intent parameters.  The definition of these
	/// parameters varies according to the IntentCode.
	/// </summary>
	public double GetIntentP3()
	{
		return vtkNIFTIImageHeader_GetIntentP3_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_GetMagic_15(HandleRef pThis);

	/// <summary>
	/// Get the magic number for the NIFTI file as a null-terminated string.
	/// </summary>
	public string GetMagic()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIImageHeader_GetMagic_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageHeader_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNIFTIImageHeader_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageHeader_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNIFTIImageHeader_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetPixDim_18(HandleRef pThis, int i);

	/// <summary>
	/// Get the sample spacing in the nth dimension. If GetPixDim(0) is
	/// negative, then the quaternion for the qform describes the correct
	/// orientation only after the slice ordering has been reversed.
	/// </summary>
	public double GetPixDim(int i)
	{
		return vtkNIFTIImageHeader_GetPixDim_18(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_GetQFormCode_19(HandleRef pThis);

	/// <summary>
	/// Get the QForm or SForm code.
	/// </summary>
	public int GetQFormCode()
	{
		return vtkNIFTIImageHeader_GetQFormCode_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetQOffsetX_20(HandleRef pThis);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public double GetQOffsetX()
	{
		return vtkNIFTIImageHeader_GetQOffsetX_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetQOffsetY_21(HandleRef pThis);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public double GetQOffsetY()
	{
		return vtkNIFTIImageHeader_GetQOffsetY_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetQOffsetZ_22(HandleRef pThis);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public double GetQOffsetZ()
	{
		return vtkNIFTIImageHeader_GetQOffsetZ_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetQuaternB_23(HandleRef pThis);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public double GetQuaternB()
	{
		return vtkNIFTIImageHeader_GetQuaternB_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetQuaternC_24(HandleRef pThis);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public double GetQuaternC()
	{
		return vtkNIFTIImageHeader_GetQuaternC_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetQuaternD_25(HandleRef pThis);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public double GetQuaternD()
	{
		return vtkNIFTIImageHeader_GetQuaternD_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_GetSFormCode_26(HandleRef pThis);

	/// <summary>
	/// Get the QForm or SForm code.
	/// </summary>
	public int GetSFormCode()
	{
		return vtkNIFTIImageHeader_GetSFormCode_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_GetSRowX_27(HandleRef pThis);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual double[] GetSRowX()
	{
		IntPtr intPtr = vtkNIFTIImageHeader_GetSRowX_27(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_GetSRowX_28(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void GetSRowX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkNIFTIImageHeader_GetSRowX_28(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_GetSRowX_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void GetSRowX(IntPtr _arg)
	{
		vtkNIFTIImageHeader_GetSRowX_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_GetSRowY_30(HandleRef pThis);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual double[] GetSRowY()
	{
		IntPtr intPtr = vtkNIFTIImageHeader_GetSRowY_30(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_GetSRowY_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void GetSRowY(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkNIFTIImageHeader_GetSRowY_31(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_GetSRowY_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void GetSRowY(IntPtr _arg)
	{
		vtkNIFTIImageHeader_GetSRowY_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_GetSRowZ_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void GetSRowZ(IntPtr _arg)
	{
		vtkNIFTIImageHeader_GetSRowZ_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_GetSRowZ_34(HandleRef pThis);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual double[] GetSRowZ()
	{
		IntPtr intPtr = vtkNIFTIImageHeader_GetSRowZ_34(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_GetSRowZ_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void GetSRowZ(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkNIFTIImageHeader_GetSRowZ_35(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetSclInter_36(HandleRef pThis);

	/// <summary>
	/// Get the scale and slope to apply to the data in order to get
	/// the real-valued data values.
	/// </summary>
	public double GetSclInter()
	{
		return vtkNIFTIImageHeader_GetSclInter_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetSclSlope_37(HandleRef pThis);

	/// <summary>
	/// Get the scale and slope to apply to the data in order to get
	/// the real-valued data values.
	/// </summary>
	public double GetSclSlope()
	{
		return vtkNIFTIImageHeader_GetSclSlope_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_GetSliceCode_38(HandleRef pThis);

	/// <summary>
	/// Get the slice code for the data.
	/// </summary>
	public int GetSliceCode()
	{
		return vtkNIFTIImageHeader_GetSliceCode_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetSliceDuration_39(HandleRef pThis);

	/// <summary>
	/// Get the slice_duration and toffset from the header.
	/// </summary>
	public double GetSliceDuration()
	{
		return vtkNIFTIImageHeader_GetSliceDuration_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageHeader_GetSliceEnd_40(HandleRef pThis);

	/// <summary>
	/// Get the slice range for the data.
	/// </summary>
	public long GetSliceEnd()
	{
		return vtkNIFTIImageHeader_GetSliceEnd_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageHeader_GetSliceStart_41(HandleRef pThis);

	/// <summary>
	/// Get the slice range for the data.
	/// </summary>
	public long GetSliceStart()
	{
		return vtkNIFTIImageHeader_GetSliceStart_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageHeader_GetTOffset_42(HandleRef pThis);

	/// <summary>
	/// Get the slice_duration and toffset from the header.
	/// </summary>
	public double GetTOffset()
	{
		return vtkNIFTIImageHeader_GetTOffset_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageHeader_GetVoxOffset_43(HandleRef pThis);

	/// <summary>
	/// Get the offset to the pixel data within the file.
	/// </summary>
	public long GetVoxOffset()
	{
		return vtkNIFTIImageHeader_GetVoxOffset_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_GetXYZTUnits_44(HandleRef pThis);

	/// <summary>
	/// Get a bitfield that describes the units for the first 4 dims.
	/// </summary>
	public int GetXYZTUnits()
	{
		return vtkNIFTIImageHeader_GetXYZTUnits_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_Initialize_45(HandleRef pThis);

	/// <summary>
	/// Initialize the header to default values.
	/// </summary>
	public void Initialize()
	{
		vtkNIFTIImageHeader_Initialize_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_IsA_46(HandleRef pThis, string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNIFTIImageHeader_IsA_46(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageHeader_IsTypeOf_47(string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNIFTIImageHeader_IsTypeOf_47(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new vtkNIFTIImageHeader NewInstance()
	{
		vtkNIFTIImageHeader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageHeader_NewInstance_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIImageHeader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageHeader_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static vtkNIFTIImageHeader SafeDownCast(vtkObjectBase o)
	{
		vtkNIFTIImageHeader vtkNIFTIImageHeader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageHeader_SafeDownCast_50(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNIFTIImageHeader2 = (vtkNIFTIImageHeader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNIFTIImageHeader2.Register(null);
			}
		}
		return vtkNIFTIImageHeader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetAuxFile_51(HandleRef pThis, string auxfile);

	/// <summary>
	/// Get an auxiliary file, e.g. a color table, that is associated
	/// with this data.  The length of the filename must be a maximum of
	/// 24 characters, and it will be assumed to be in the same directory
	/// as the NIFTI file.
	/// </summary>
	public void SetAuxFile(string auxfile)
	{
		vtkNIFTIImageHeader_SetAuxFile_51(GetCppThis(), auxfile);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetCalMax_52(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the calibrated range of the data, i.e. the values stored in the
	/// cal_min and cal_max fields in the header.
	/// </summary>
	public virtual void SetCalMax(double _arg)
	{
		vtkNIFTIImageHeader_SetCalMax_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetCalMin_53(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the calibrated range of the data, i.e. the values stored in the
	/// cal_min and cal_max fields in the header.
	/// </summary>
	public virtual void SetCalMin(double _arg)
	{
		vtkNIFTIImageHeader_SetCalMin_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetDescrip_54(HandleRef pThis, string descrip);

	/// <summary>
	/// Get a null-terminated file descriptor, this usually gives the
	/// name of the software that wrote the file. It will have a maximum
	/// length of 80 characters.  Use ASCII to ensure compatibility with
	/// all NIFTI software, the NIFTI standard itself does not specify what
	/// encodings are permitted.
	/// </summary>
	public void SetDescrip(string descrip)
	{
		vtkNIFTIImageHeader_SetDescrip_54(GetCppThis(), descrip);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetDimInfo_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Get a bitfield with extra information about the dimensions, it
	/// states which dimensions are the phase encode, frequency encode,
	/// and slice encode dimensions for MRI acquisitions.
	/// </summary>
	public virtual void SetDimInfo(int _arg)
	{
		vtkNIFTIImageHeader_SetDimInfo_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetIntentCode_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the NIFTI intent code.  This is an enumerated value in the NIFTI
	/// header that states what the data is intended to be used for.
	/// </summary>
	public virtual void SetIntentCode(int _arg)
	{
		vtkNIFTIImageHeader_SetIntentCode_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetIntentName_57(HandleRef pThis, string name);

	/// <summary>
	/// Get the intent name.  This should match the intent code.
	/// </summary>
	public void SetIntentName(string name)
	{
		vtkNIFTIImageHeader_SetIntentName_57(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetIntentP1_58(HandleRef pThis, double _arg);

	/// <summary>
	/// Get one of the NIFTI intent parameters.  The definition of these
	/// parameters varies according to the IntentCode.
	/// </summary>
	public virtual void SetIntentP1(double _arg)
	{
		vtkNIFTIImageHeader_SetIntentP1_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetIntentP2_59(HandleRef pThis, double _arg);

	/// <summary>
	/// Get one of the NIFTI intent parameters.  The definition of these
	/// parameters varies according to the IntentCode.
	/// </summary>
	public virtual void SetIntentP2(double _arg)
	{
		vtkNIFTIImageHeader_SetIntentP2_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetIntentP3_60(HandleRef pThis, double _arg);

	/// <summary>
	/// Get one of the NIFTI intent parameters.  The definition of these
	/// parameters varies according to the IntentCode.
	/// </summary>
	public virtual void SetIntentP3(double _arg)
	{
		vtkNIFTIImageHeader_SetIntentP3_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetQFormCode_61(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the QForm or SForm code.
	/// </summary>
	public virtual void SetQFormCode(int _arg)
	{
		vtkNIFTIImageHeader_SetQFormCode_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetQOffsetX_62(HandleRef pThis, double _arg);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public virtual void SetQOffsetX(double _arg)
	{
		vtkNIFTIImageHeader_SetQOffsetX_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetQOffsetY_63(HandleRef pThis, double _arg);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public virtual void SetQOffsetY(double _arg)
	{
		vtkNIFTIImageHeader_SetQOffsetY_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetQOffsetZ_64(HandleRef pThis, double _arg);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public virtual void SetQOffsetZ(double _arg)
	{
		vtkNIFTIImageHeader_SetQOffsetZ_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetQuaternB_65(HandleRef pThis, double _arg);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public virtual void SetQuaternB(double _arg)
	{
		vtkNIFTIImageHeader_SetQuaternB_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetQuaternC_66(HandleRef pThis, double _arg);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public virtual void SetQuaternC(double _arg)
	{
		vtkNIFTIImageHeader_SetQuaternC_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetQuaternD_67(HandleRef pThis, double _arg);

	/// <summary>
	/// Get information about the quaternion transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
	/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
	/// </summary>
	public virtual void SetQuaternD(double _arg)
	{
		vtkNIFTIImageHeader_SetQuaternD_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSFormCode_68(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the QForm or SForm code.
	/// </summary>
	public virtual void SetSFormCode(int _arg)
	{
		vtkNIFTIImageHeader_SetSFormCode_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSRowX_69(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void SetSRowX(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkNIFTIImageHeader_SetSRowX_69(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSRowX_70(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void SetSRowX(IntPtr _arg)
	{
		vtkNIFTIImageHeader_SetSRowX_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSRowY_71(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void SetSRowY(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkNIFTIImageHeader_SetSRowY_71(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSRowY_72(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void SetSRowY(IntPtr _arg)
	{
		vtkNIFTIImageHeader_SetSRowY_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSRowZ_73(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void SetSRowZ(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkNIFTIImageHeader_SetSRowZ_73(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSRowZ_74(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get information about the matrix transformation.  Note that
	/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
	/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
	/// </summary>
	public virtual void SetSRowZ(IntPtr _arg)
	{
		vtkNIFTIImageHeader_SetSRowZ_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSclInter_75(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the scale and slope to apply to the data in order to get
	/// the real-valued data values.
	/// </summary>
	public virtual void SetSclInter(double _arg)
	{
		vtkNIFTIImageHeader_SetSclInter_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSclSlope_76(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the scale and slope to apply to the data in order to get
	/// the real-valued data values.
	/// </summary>
	public virtual void SetSclSlope(double _arg)
	{
		vtkNIFTIImageHeader_SetSclSlope_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSliceCode_77(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the slice code for the data.
	/// </summary>
	public virtual void SetSliceCode(int _arg)
	{
		vtkNIFTIImageHeader_SetSliceCode_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSliceDuration_78(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the slice_duration and toffset from the header.
	/// </summary>
	public virtual void SetSliceDuration(double _arg)
	{
		vtkNIFTIImageHeader_SetSliceDuration_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSliceEnd_79(HandleRef pThis, long _arg);

	/// <summary>
	/// Get the slice range for the data.
	/// </summary>
	public virtual void SetSliceEnd(long _arg)
	{
		vtkNIFTIImageHeader_SetSliceEnd_79(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetSliceStart_80(HandleRef pThis, long _arg);

	/// <summary>
	/// Get the slice range for the data.
	/// </summary>
	public virtual void SetSliceStart(long _arg)
	{
		vtkNIFTIImageHeader_SetSliceStart_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetTOffset_81(HandleRef pThis, double _arg);

	/// <summary>
	/// Get the slice_duration and toffset from the header.
	/// </summary>
	public virtual void SetTOffset(double _arg)
	{
		vtkNIFTIImageHeader_SetTOffset_81(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageHeader_SetXYZTUnits_82(HandleRef pThis, int _arg);

	/// <summary>
	/// Get a bitfield that describes the units for the first 4 dims.
	/// </summary>
	public virtual void SetXYZTUnits(int _arg)
	{
		vtkNIFTIImageHeader_SetXYZTUnits_82(GetCppThis(), _arg);
	}
}
