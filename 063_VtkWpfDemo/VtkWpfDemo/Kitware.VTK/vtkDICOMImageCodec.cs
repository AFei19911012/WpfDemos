using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMImageCodec : WrappedObject
{
	public enum EnumType
	{
		/// <summary>enum member</summary>
		BigEndian = 1,
		/// <summary>enum member</summary>
		HEVCM10PL51 = 19,
		/// <summary>enum member</summary>
		HEVCMPL51 = 18,
		/// <summary>enum member</summary>
		JPEG2K = 9,
		/// <summary>enum member</summary>
		JPEG2KLossless = 10,
		/// <summary>enum member</summary>
		JPEGBaseline = 3,
		/// <summary>enum member</summary>
		JPEGExtended = 4,
		/// <summary>enum member</summary>
		JPEGLS = 7,
		/// <summary>enum member</summary>
		JPEGLSConstrained = 8,
		/// <summary>enum member</summary>
		JPEGLossless = 5,
		/// <summary>enum member</summary>
		JPEGPrediction = 6,
		/// <summary>enum member</summary>
		LittleEndian = 0,
		/// <summary>enum member</summary>
		MPEG2HL = 12,
		/// <summary>enum member</summary>
		MPEG2ML = 11,
		/// <summary>enum member</summary>
		MPEG4HPL41 = 13,
		/// <summary>enum member</summary>
		MPEG4HPL41BD = 14,
		/// <summary>enum member</summary>
		MPEG4HPL42Stereo = 17,
		/// <summary>enum member</summary>
		MPEG4HPL42V2D = 15,
		/// <summary>enum member</summary>
		MPEG4HPL42V3D = 16,
		/// <summary>enum member</summary>
		NumberOfCodecs = 20,
		/// <summary>enum member</summary>
		RLE = 2
	}

	public enum ErrorCode
	{
		/// <summary>enum member</summary>
		BadPixelFormat = 2,
		/// <summary>enum member</summary>
		MissingCodec = 1,
		/// <summary>enum member</summary>
		MissingData = 3,
		/// <summary>enum member</summary>
		NoError = 0,
		/// <summary>enum member</summary>
		UnknownError = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMImageCodec";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMImageCodec()
	{
		MRClassNameKey = "class vtkDICOMImageCodec";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMImageCodec"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMImageCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern byte vtkDICOMImageCodec_GetKey_01(HandleRef pThis);

	public byte GetKey()
	{
		return vtkDICOMImageCodec_GetKey_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDICOMImageCodec_GetTransferSyntaxUID_02(HandleRef pThis);

	public string GetTransferSyntaxUID()
	{
		return vtkDICOMImageCodec_GetTransferSyntaxUID_02(GetCppThis());
	}
}
