using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMetaImageReader
/// </summary>
/// <remarks>
///    read binary UNC meta image data
///
/// One of the formats for which a reader is already available in the toolkit is
/// the MetaImage file format. This is a fairly simple yet powerful format
/// consisting of a text header and a binary data section. The following
/// instructions describe how you can write a MetaImage header for the data that
/// you download from the BrainWeb page.
///
/// The minimal structure of the MetaImage header is the following:
///
///    NDims = 3
///    DimSize = 181 217 181
///    ElementType = MET_UCHAR
///    ElementSpacing = 1.0 1.0 1.0
///    ElementByteOrderMSB = False
///    ElementDataFile = brainweb1.raw
///
///    * NDims indicate that this is a 3D image. ITK can handle images of
///      arbitrary dimension.
///    * DimSize indicates the size of the volume in pixels along each
///      direction.
///    * ElementType indicate the primitive type used for pixels. In this case
///      is "unsigned char", implying that the data is digitized in 8 bits /
///      pixel.
///    * ElementSpacing indicates the physical separation between the center of
///      one pixel and the center of the next pixel along each direction in space.
///      The units used are millimeters.
///    * ElementByteOrderMSB indicates is the data is encoded in little or big
///      endian order. You might want to play with this value when moving data
///      between different computer platforms.
///    * ElementDataFile is the name of the file containing the raw binary data
///      of the image. This file must be in the same directory as the header.
///
/// MetaImage headers are expected to have extension: ".mha" or ".mhd"
///
/// Once you write this header text file, it should be possible to read the
/// image into your ITK based application using the itk::FileIOToImageFilter
/// class.
///
///
///
/// </remarks>
public class vtkMetaImageReader : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMetaImageReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMetaImageReader()
	{
		MRClassNameKey = "class vtkMetaImageReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMetaImageReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMetaImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public new static vtkMetaImageReader New()
	{
		vtkMetaImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMetaImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public vtkMetaImageReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMetaImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkMetaImageReader_CanReadFile_01(HandleRef pThis, string name);

	/// <summary>
	/// Test whether the file with the given name can be read by this
	/// reader.
	/// </summary>
	public override int CanReadFile(string name)
	{
		return vtkMetaImageReader_CanReadFile_01(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetAnatomicalOrientation_02(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetAnatomicalOrientation()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetAnatomicalOrientation_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageReader_GetBitsAllocated_03(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual int GetBitsAllocated()
	{
		return vtkMetaImageReader_GetBitsAllocated_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageReader_GetDataByteOrder_04(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public override int GetDataByteOrder()
	{
		return vtkMetaImageReader_GetDataByteOrder_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetDate_05(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetDate()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetDate_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetDescriptiveName_06(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetDescriptiveName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetDistanceUnits_07(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetDistanceUnits()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetDistanceUnits_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetFileExtensions_08(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetFileExtensions_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMetaImageReader_GetGantryAngle_09(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual double GetGantryAngle()
	{
		return vtkMetaImageReader_GetGantryAngle_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageReader_GetHeight_10(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public int GetHeight()
	{
		return vtkMetaImageReader_GetHeight_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetImageNumber_11(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetImageNumber()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetImageNumber_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetImagePositionPatient_12(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public IntPtr GetImagePositionPatient()
	{
		return vtkMetaImageReader_GetImagePositionPatient_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetModality_13(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetModality()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetModality_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageReader_GetNumberOfComponents_14(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public int GetNumberOfComponents()
	{
		return vtkMetaImageReader_GetNumberOfComponents_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMetaImageReader_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMetaImageReader_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMetaImageReader_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMetaImageReader_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetPatientID_17(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetPatientID()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetPatientID_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetPatientName_18(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetPatientName()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetPatientName_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageReader_GetPixelRepresentation_19(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public int GetPixelRepresentation()
	{
		return vtkMetaImageReader_GetPixelRepresentation_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetPixelSpacing_20(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public IntPtr GetPixelSpacing()
	{
		return vtkMetaImageReader_GetPixelSpacing_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMetaImageReader_GetRescaleOffset_21(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual double GetRescaleOffset()
	{
		return vtkMetaImageReader_GetRescaleOffset_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMetaImageReader_GetRescaleSlope_22(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual double GetRescaleSlope()
	{
		return vtkMetaImageReader_GetRescaleSlope_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetSeries_23(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetSeries()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetSeries_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetStudyID_24(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetStudyID()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetStudyID_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetStudyUID_25(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetStudyUID()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetStudyUID_25(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_GetTransferSyntaxUID_26(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public virtual string GetTransferSyntaxUID()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageReader_GetTransferSyntaxUID_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageReader_GetWidth_27(HandleRef pThis);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public int GetWidth()
	{
		return vtkMetaImageReader_GetWidth_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageReader_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMetaImageReader_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageReader_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMetaImageReader_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMetaImageReader NewInstance()
	{
		vtkMetaImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMetaImageReader_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageReader_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMetaImageReader SafeDownCast(vtkObjectBase o)
	{
		vtkMetaImageReader vtkMetaImageReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMetaImageReader_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMetaImageReader2 = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMetaImageReader2.Register(null);
			}
		}
		return vtkMetaImageReader2;
	}
}
