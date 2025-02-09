using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDICOMImageReader
/// </summary>
/// <remarks>
///    Reads some DICOM images
///
/// DICOM (stands for Digital Imaging in COmmunications and Medicine)
/// is a medical image file format widely used to exchange data, provided
/// by various modalities.
/// @warning
/// This reader might eventually handle ACR-NEMA file (predecessor of the DICOM
/// format for medical images).
/// This reader does not handle encapsulated format, only plain raw file are
/// handled. This reader also does not handle multi-frames DICOM datasets.
/// @warning
/// Internally DICOMParser assumes the x,y pixel spacing is stored in 0028,0030 and
/// that z spacing is stored in Slice Thickness (correct only when slice were acquired
/// contiguous): 0018,0050. Which means this is only valid for some rare
/// MR Image Storage
///
/// </remarks>
/// <seealso>
///
/// vtkBMPReader vtkPNMReader vtkTIFFReader
/// </seealso>
public class vtkDICOMImageReader : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMImageReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMImageReader()
	{
		MRClassNameKey = "class vtkDICOMImageReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMImageReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static vtkDICOMImageReader New()
	{
		vtkDICOMImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public vtkDICOMImageReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDICOMImageReader_CanReadFile_01(HandleRef pThis, string fname);

	/// <summary>
	/// Get the gantry angle for the last image processed.
	/// </summary>
	public override int CanReadFile(string fname)
	{
		return vtkDICOMImageReader_CanReadFile_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMImageReader_GetBitsAllocated_02(HandleRef pThis);

	/// <summary>
	/// Get the number of bits allocated for each pixel in the file.
	/// </summary>
	public int GetBitsAllocated()
	{
		return vtkDICOMImageReader_GetBitsAllocated_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetDescriptiveName_03(HandleRef pThis);

	/// <summary>
	/// Return a descriptive name for the file format that might be useful in a GUI.
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMImageReader_GetDescriptiveName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetDirectoryName_04(HandleRef pThis);

	/// <summary>
	/// Returns the directory name.
	/// </summary>
	public virtual string GetDirectoryName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMImageReader_GetDirectoryName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetFileExtensions_05(HandleRef pThis);

	/// <summary>
	/// Get the gantry angle for the last image processed.
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMImageReader_GetFileExtensions_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDICOMImageReader_GetGantryAngle_06(HandleRef pThis);

	/// <summary>
	/// Get the gantry angle for the last image processed.
	/// </summary>
	public float GetGantryAngle()
	{
		return vtkDICOMImageReader_GetGantryAngle_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMImageReader_GetHeight_07(HandleRef pThis);

	/// <summary>
	/// Returns the image height.
	/// </summary>
	public int GetHeight()
	{
		return vtkDICOMImageReader_GetHeight_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetImageOrientationPatient_08(HandleRef pThis);

	/// <summary>
	/// Get the (DICOM) directions cosines. It consist of the components
	/// of the first two vectors. The third vector needs to be computed
	/// to form an orthonormal basis.
	/// </summary>
	public float[] GetImageOrientationPatient()
	{
		IntPtr intPtr = vtkDICOMImageReader_GetImageOrientationPatient_08(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetImagePositionPatient_09(HandleRef pThis);

	/// <summary>
	/// Get the (DICOM) x,y,z coordinates of the first pixel in the
	/// image (upper left hand corner) of the last image processed by the
	/// DICOMParser
	/// </summary>
	public float[] GetImagePositionPatient()
	{
		IntPtr intPtr = vtkDICOMImageReader_GetImagePositionPatient_09(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMImageReader_GetNumberOfComponents_10(HandleRef pThis);

	/// <summary>
	/// Get the number of components of the image data for the last
	/// image processed.
	/// </summary>
	public int GetNumberOfComponents()
	{
		return vtkDICOMImageReader_GetNumberOfComponents_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMImageReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMImageReader_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMImageReader_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMImageReader_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetPatientName_13(HandleRef pThis);

	/// <summary>
	/// Get the patient name for the last image processed.
	/// </summary>
	public string GetPatientName()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMImageReader_GetPatientName_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMImageReader_GetPixelRepresentation_14(HandleRef pThis);

	/// <summary>
	/// Get the pixel representation of the last image processed by the
	/// DICOMParser. A zero is a unsigned quantity.  A one indicates a
	/// signed quantity
	/// </summary>
	public int GetPixelRepresentation()
	{
		return vtkDICOMImageReader_GetPixelRepresentation_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetPixelSpacing_15(HandleRef pThis);

	/// <summary>
	/// Returns the pixel spacing (in X, Y, Z).
	/// Note: if there is only one slice, the Z spacing is set to the slice
	/// thickness. If there is more than one slice, it is set to the distance
	/// between the first two slices.
	/// </summary>
	public double[] GetPixelSpacing()
	{
		IntPtr intPtr = vtkDICOMImageReader_GetPixelSpacing_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDICOMImageReader_GetRescaleOffset_16(HandleRef pThis);

	/// <summary>
	/// Get the rescale offset for the pixel data.
	/// </summary>
	public float GetRescaleOffset()
	{
		return vtkDICOMImageReader_GetRescaleOffset_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkDICOMImageReader_GetRescaleSlope_17(HandleRef pThis);

	/// <summary>
	/// Get the rescale slope for the pixel data.
	/// </summary>
	public float GetRescaleSlope()
	{
		return vtkDICOMImageReader_GetRescaleSlope_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetStudyID_18(HandleRef pThis);

	/// <summary>
	/// Get the Study ID for the last image processed.
	/// </summary>
	public string GetStudyID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMImageReader_GetStudyID_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetStudyUID_19(HandleRef pThis);

	/// <summary>
	/// Get the study uid for the last image processed.
	/// </summary>
	public string GetStudyUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMImageReader_GetStudyUID_19(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_GetTransferSyntaxUID_20(HandleRef pThis);

	/// <summary>
	/// Get the transfer syntax UID for the last image processed.
	/// </summary>
	public string GetTransferSyntaxUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMImageReader_GetTransferSyntaxUID_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMImageReader_GetWidth_21(HandleRef pThis);

	/// <summary>
	/// Returns the image width.
	/// </summary>
	public int GetWidth()
	{
		return vtkDICOMImageReader_GetWidth_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMImageReader_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDICOMImageReader_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMImageReader_IsTypeOf_23(string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDICOMImageReader_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new vtkDICOMImageReader NewInstance()
	{
		vtkDICOMImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMImageReader_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMImageReader_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static vtkDICOMImageReader SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMImageReader vtkDICOMImageReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMImageReader_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMImageReader2 = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMImageReader2.Register(null);
			}
		}
		return vtkDICOMImageReader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMImageReader_SetDirectoryName_27(HandleRef pThis, string dn);

	/// <summary>
	/// Set the directory name for the reader to look in for DICOM
	/// files. If this method is used, the reader will try to find
	/// all the DICOM files in a directory. It will select the subset
	/// corresponding to the first series UID it stumbles across and
	/// it will try to build an ordered volume from them based on
	/// the slice number. The volume building will be upgraded to
	/// something more sophisticated in the future.
	/// </summary>
	public void SetDirectoryName(string dn)
	{
		vtkDICOMImageReader_SetDirectoryName_27(GetCppThis(), dn);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMImageReader_SetFileName_28(HandleRef pThis, string fn);

	/// <summary>
	/// Set the filename for the file to read. If this method is used,
	/// the reader will only read a single file.
	/// </summary>
	public override void SetFileName(string fn)
	{
		vtkDICOMImageReader_SetFileName_28(GetCppThis(), fn);
	}
}
