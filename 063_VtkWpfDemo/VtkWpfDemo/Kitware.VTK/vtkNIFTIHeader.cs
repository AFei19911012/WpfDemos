using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkNIFTIHeader
/// \brief Store NIfTI header information.
///
/// This class stores the header of a NIfTI file in a VTK-friendly format.
/// By using this class, it is possible to specify the header information
/// that will be stored in a file written by the vtkNIFTIWriter.  Note
/// that the SForm and QForm orientation information in this class will be
/// ignored by the writer if an SForm and QForm have been explicitly set
/// via the writer's SetSForm and SetQForm methods.  Also note that all
/// info like Dim, PixDim, DataType, etc. will be ignored by the writer
/// because this information must instead be taken from the vtkImageData
/// information.  Finally, note that the vtkNIFTIWriter will ignore the
/// Descrip field, since it has its own SetDescription method.
///
/// This class was contributed to VTK by the Calgary Image Processing and
/// Analysis Centre (CIPAC).
///
/// \sa vtkNIFTIReader, vtkNIFTIWriter
/// </summary>
public class vtkNIFTIHeader : vtkObject
{
	/// <summary>
	///             Undocumented Block
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
	///             Undocumented Block
	/// </summary>
	public enum HeaderSizeEnum
	{
		/// <summary>enum member</summary>
		Nifti1HeaderSize = 348,
		/// <summary>enum member</summary>
		Nifti2HeaderSize = 540
	}

	/// <summary>
	///             Undocumented Block
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
	///             Undocumented Block
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
	///             Undocumented Block
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
	///             Undocumented Block
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIHeader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNIFTIHeader()
	{
		MRClassNameKey = "class vtkNIFTIHeader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIHeader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNIFTIHeader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNIFTIHeader New()
	{
		vtkNIFTIHeader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIHeader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIHeader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNIFTIHeader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNIFTIHeader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkNIFTIHeader_DeepCopy_01(HandleRef pThis, HandleRef o);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void DeepCopy(vtkNIFTIHeader o)
	{
		vtkNIFTIHeader_DeepCopy_01(GetCppThis(), o?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_GetAuxFile_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetAuxFile()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIHeader_GetAuxFile_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_GetBitPix_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetBitPix()
	{
		return vtkNIFTIHeader_GetBitPix_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetCalMax_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetCalMax()
	{
		return vtkNIFTIHeader_GetCalMax_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetCalMin_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetCalMin()
	{
		return vtkNIFTIHeader_GetCalMin_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_GetDataType_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetDataType()
	{
		return vtkNIFTIHeader_GetDataType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_GetDescrip_07(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetDescrip()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIHeader_GetDescrip_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIHeader_GetDim_08(HandleRef pThis, int i);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetDim(int i)
	{
		return vtkNIFTIHeader_GetDim_08(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_GetDimInfo_09(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetDimInfo()
	{
		return vtkNIFTIHeader_GetDimInfo_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_GetIntentCode_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetIntentCode()
	{
		return vtkNIFTIHeader_GetIntentCode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_GetIntentName_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetIntentName()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIHeader_GetIntentName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetIntentP1_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetIntentP1()
	{
		return vtkNIFTIHeader_GetIntentP1_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetIntentP2_13(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetIntentP2()
	{
		return vtkNIFTIHeader_GetIntentP2_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetIntentP3_14(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetIntentP3()
	{
		return vtkNIFTIHeader_GetIntentP3_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_GetMagic_15(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetMagic()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIHeader_GetMagic_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIHeader_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNIFTIHeader_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIHeader_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNIFTIHeader_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetPixDim_18(HandleRef pThis, int i);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetPixDim(int i)
	{
		return vtkNIFTIHeader_GetPixDim_18(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_GetQFormCode_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetQFormCode()
	{
		return vtkNIFTIHeader_GetQFormCode_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetQOffsetX_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetQOffsetX()
	{
		return vtkNIFTIHeader_GetQOffsetX_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetQOffsetY_21(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetQOffsetY()
	{
		return vtkNIFTIHeader_GetQOffsetY_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetQOffsetZ_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetQOffsetZ()
	{
		return vtkNIFTIHeader_GetQOffsetZ_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetQuaternB_23(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetQuaternB()
	{
		return vtkNIFTIHeader_GetQuaternB_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetQuaternC_24(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetQuaternC()
	{
		return vtkNIFTIHeader_GetQuaternC_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetQuaternD_25(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetQuaternD()
	{
		return vtkNIFTIHeader_GetQuaternD_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_GetSFormCode_26(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetSFormCode()
	{
		return vtkNIFTIHeader_GetSFormCode_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_GetSRowX_27(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double[] GetSRowX()
	{
		IntPtr intPtr = vtkNIFTIHeader_GetSRowX_27(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_GetSRowX_28(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetSRowX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkNIFTIHeader_GetSRowX_28(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_GetSRowX_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetSRowX(IntPtr _arg)
	{
		vtkNIFTIHeader_GetSRowX_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_GetSRowY_30(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double[] GetSRowY()
	{
		IntPtr intPtr = vtkNIFTIHeader_GetSRowY_30(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_GetSRowY_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetSRowY(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkNIFTIHeader_GetSRowY_31(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_GetSRowY_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetSRowY(IntPtr _arg)
	{
		vtkNIFTIHeader_GetSRowY_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_GetSRowZ_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetSRowZ(IntPtr _arg)
	{
		vtkNIFTIHeader_GetSRowZ_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_GetSRowZ_34(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double[] GetSRowZ()
	{
		IntPtr intPtr = vtkNIFTIHeader_GetSRowZ_34(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_GetSRowZ_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void GetSRowZ(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkNIFTIHeader_GetSRowZ_35(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetSclInter_36(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetSclInter()
	{
		return vtkNIFTIHeader_GetSclInter_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetSclSlope_37(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetSclSlope()
	{
		return vtkNIFTIHeader_GetSclSlope_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_GetSliceCode_38(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetSliceCode()
	{
		return vtkNIFTIHeader_GetSliceCode_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetSliceDuration_39(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetSliceDuration()
	{
		return vtkNIFTIHeader_GetSliceDuration_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIHeader_GetSliceEnd_40(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetSliceEnd()
	{
		return vtkNIFTIHeader_GetSliceEnd_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIHeader_GetSliceStart_41(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetSliceStart()
	{
		return vtkNIFTIHeader_GetSliceStart_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIHeader_GetTOffset_42(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public double GetTOffset()
	{
		return vtkNIFTIHeader_GetTOffset_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIHeader_GetVoxOffset_43(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public long GetVoxOffset()
	{
		return vtkNIFTIHeader_GetVoxOffset_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_GetXYZTUnits_44(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetXYZTUnits()
	{
		return vtkNIFTIHeader_GetXYZTUnits_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_Initialize_45(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Initialize()
	{
		vtkNIFTIHeader_Initialize_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_IsA_46(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNIFTIHeader_IsA_46(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIHeader_IsTypeOf_47(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNIFTIHeader_IsTypeOf_47(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNIFTIHeader NewInstance()
	{
		vtkNIFTIHeader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIHeader_NewInstance_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIHeader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIHeader_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNIFTIHeader SafeDownCast(vtkObjectBase o)
	{
		vtkNIFTIHeader vtkNIFTIHeader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIHeader_SafeDownCast_50(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNIFTIHeader2 = (vtkNIFTIHeader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNIFTIHeader2.Register(null);
			}
		}
		return vtkNIFTIHeader2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetAuxFile_51(HandleRef pThis, string auxfile);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetAuxFile(string auxfile)
	{
		vtkNIFTIHeader_SetAuxFile_51(GetCppThis(), auxfile);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetCalMax_52(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetCalMax(double _arg)
	{
		vtkNIFTIHeader_SetCalMax_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetCalMin_53(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetCalMin(double _arg)
	{
		vtkNIFTIHeader_SetCalMin_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetDescrip_54(HandleRef pThis, string descrip);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetDescrip(string descrip)
	{
		vtkNIFTIHeader_SetDescrip_54(GetCppThis(), descrip);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetDimInfo_55(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetDimInfo(int _arg)
	{
		vtkNIFTIHeader_SetDimInfo_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetIntentCode_56(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetIntentCode(int _arg)
	{
		vtkNIFTIHeader_SetIntentCode_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetIntentName_57(HandleRef pThis, string name);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetIntentName(string name)
	{
		vtkNIFTIHeader_SetIntentName_57(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetIntentP1_58(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetIntentP1(double _arg)
	{
		vtkNIFTIHeader_SetIntentP1_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetIntentP2_59(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetIntentP2(double _arg)
	{
		vtkNIFTIHeader_SetIntentP2_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetIntentP3_60(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetIntentP3(double _arg)
	{
		vtkNIFTIHeader_SetIntentP3_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetQFormCode_61(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetQFormCode(int _arg)
	{
		vtkNIFTIHeader_SetQFormCode_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetQOffsetX_62(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetQOffsetX(double _arg)
	{
		vtkNIFTIHeader_SetQOffsetX_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetQOffsetY_63(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetQOffsetY(double _arg)
	{
		vtkNIFTIHeader_SetQOffsetY_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetQOffsetZ_64(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetQOffsetZ(double _arg)
	{
		vtkNIFTIHeader_SetQOffsetZ_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetQuaternB_65(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetQuaternB(double _arg)
	{
		vtkNIFTIHeader_SetQuaternB_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetQuaternC_66(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetQuaternC(double _arg)
	{
		vtkNIFTIHeader_SetQuaternC_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetQuaternD_67(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetQuaternD(double _arg)
	{
		vtkNIFTIHeader_SetQuaternD_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSFormCode_68(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSFormCode(int _arg)
	{
		vtkNIFTIHeader_SetSFormCode_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSRowX_69(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSRowX(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkNIFTIHeader_SetSRowX_69(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSRowX_70(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSRowX(IntPtr _arg)
	{
		vtkNIFTIHeader_SetSRowX_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSRowY_71(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSRowY(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkNIFTIHeader_SetSRowY_71(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSRowY_72(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSRowY(IntPtr _arg)
	{
		vtkNIFTIHeader_SetSRowY_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSRowZ_73(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSRowZ(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkNIFTIHeader_SetSRowZ_73(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSRowZ_74(HandleRef pThis, IntPtr _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSRowZ(IntPtr _arg)
	{
		vtkNIFTIHeader_SetSRowZ_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSclInter_75(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSclInter(double _arg)
	{
		vtkNIFTIHeader_SetSclInter_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSclSlope_76(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSclSlope(double _arg)
	{
		vtkNIFTIHeader_SetSclSlope_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSliceCode_77(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSliceCode(int _arg)
	{
		vtkNIFTIHeader_SetSliceCode_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSliceDuration_78(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSliceDuration(double _arg)
	{
		vtkNIFTIHeader_SetSliceDuration_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSliceEnd_79(HandleRef pThis, long _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSliceEnd(long _arg)
	{
		vtkNIFTIHeader_SetSliceEnd_79(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetSliceStart_80(HandleRef pThis, long _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSliceStart(long _arg)
	{
		vtkNIFTIHeader_SetSliceStart_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetTOffset_81(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTOffset(double _arg)
	{
		vtkNIFTIHeader_SetTOffset_81(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIHeader_SetXYZTUnits_82(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetXYZTUnits(int _arg)
	{
		vtkNIFTIHeader_SetXYZTUnits_82(GetCppThis(), _arg);
	}
}
