using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNIFTIImageReader
/// </summary>
/// <remarks>
///    Read NIfTI-1 and NIfTI-2 medical image files
///
/// This class reads NIFTI files, either in .nii format or as separate
/// .img and .hdr files.  If two files are used, then they can be passed
/// by using SetFileNames() instead of SetFileName().  Files ending in .gz
/// are decompressed on-the-fly while they are being read.  Files with
/// complex numbers or vector dimensions will be read as multi-component
/// images.  If a NIFTI file has a time dimension, then by default only the
/// first image in the time series will be read, but the TimeAsVector
/// flag can be set to read the time steps as vector components.  Files in
/// Analyze 7.5 format are also supported by this reader.
/// @par Thanks:
/// This class was contributed to VTK by the Calgary Image Processing and
/// Analysis Centre (CIPAC).
/// </remarks>
/// <seealso>
///
/// vtkNIFTIImageWriter, vtkNIFTIImageHeader
/// </seealso>
public class vtkNIFTIImageReader : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIImageReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNIFTIImageReader()
	{
		MRClassNameKey = "class vtkNIFTIImageReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIImageReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNIFTIImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static vtkNIFTIImageReader New()
	{
		vtkNIFTIImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public vtkNIFTIImageReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNIFTIImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkNIFTIImageReader_CanReadFile_01(HandleRef pThis, string filename);

	/// <summary>
	/// Return true if this reader can read the given file.
	/// </summary>
	public override int CanReadFile(string filename)
	{
		return vtkNIFTIImageReader_CanReadFile_01(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageReader_GetDescriptiveName_02(HandleRef pThis);

	/// <summary>
	/// Return a descriptive name that might be useful in a GUI.
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIImageReader_GetDescriptiveName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageReader_GetFileExtensions_03(HandleRef pThis);

	/// <summary>
	/// Valid extensions for this file type.
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIImageReader_GetFileExtensions_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageReader_GetNIFTIHeader_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the raw header information from the NIfTI file.
	/// </summary>
	public vtkNIFTIImageHeader GetNIFTIHeader()
	{
		vtkNIFTIImageHeader vtkNIFTIImageHeader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageReader_GetNIFTIHeader_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkNIFTIImageReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNIFTIImageReader_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageReader_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNIFTIImageReader_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkNIFTIImageReader_GetPlanarRGB_07(HandleRef pThis);

	/// <summary>
	/// Read planar RGB (separate R, G, and B planes), rather than packed RGB.
	/// The NIFTI format should always use packed RGB.  The Analyze format,
	/// however, was used to store both planar RGB and packed RGB depending
	/// on the software, without any indication in the header about which
	/// convention was being used.  Use this if you have a planar RGB file.
	/// </summary>
	public virtual bool GetPlanarRGB()
	{
		return (vtkNIFTIImageReader_GetPlanarRGB_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageReader_GetQFac_08(HandleRef pThis);

	/// <summary>
	/// QFac gives the slice order in the NIFTI file versus the VTK image.
	/// If QFac is -1, then the VTK slice index K is related to the NIFTI
	/// slice index k by the equation K = (num_slices - k - 1).  VTK requires
	/// the slices to be ordered so that the voxel indices (I,J,K) provide a
	/// right-handed coordinate system, whereas NIFTI does not.  Instead,
	/// NIFTI stores a factor called "qfac" in the header to signal when the
	/// (i,j,k) indices form a left-handed coordinate system.  QFac will only
	/// ever have values of +1 or -1.
	/// </summary>
	public double GetQFac()
	{
		return vtkNIFTIImageReader_GetQFac_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageReader_GetQFormMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a matrix that gives the "qform" orientation and offset for the data.
	/// If no qform matrix was stored in the file, the return value is nullptr.
	/// This matrix will transform VTK data coordinates into the NIFTI oriented
	/// data coordinates, where +X points right, +Y points anterior (toward the
	/// front), and +Z points superior (toward the head). The qform matrix will
	/// always have a positive determinant. The offset that is stored in the
	/// matrix gives the position of the first pixel in the first slice of the
	/// VTK image data.  Note that if QFac is -1, then the first slice in the
	/// VTK image data is the last slice in the NIFTI file, and the Z offset
	/// will automatically be adjusted to compensate for this.
	/// </summary>
	public vtkMatrix4x4 GetQFormMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageReader_GetQFormMatrix_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageReader_GetRescaleIntercept_10(HandleRef pThis);

	/// <summary>
	/// Get the slope and intercept for rescaling the scalar values.
	/// These values allow calibration of the data to real values.
	/// Use the equation v = u*RescaleSlope + RescaleIntercept.
	/// This directly returns the values stored in the scl_slope and
	/// scl_inter fields in the NIFTI header.
	/// </summary>
	public double GetRescaleIntercept()
	{
		return vtkNIFTIImageReader_GetRescaleIntercept_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageReader_GetRescaleSlope_11(HandleRef pThis);

	/// <summary>
	/// Get the slope and intercept for rescaling the scalar values.
	/// These values allow calibration of the data to real values.
	/// Use the equation v = u*RescaleSlope + RescaleIntercept.
	/// This directly returns the values stored in the scl_slope and
	/// scl_inter fields in the NIFTI header.
	/// </summary>
	public double GetRescaleSlope()
	{
		return vtkNIFTIImageReader_GetRescaleSlope_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageReader_GetSFormMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a matrix that gives the "sform" orientation and offset for the data.
	/// If no sform matrix was stored in the file, the return value is nullptr.
	/// Like the qform matrix, this matrix will transform VTK data coordinates
	/// into a NIFTI coordinate system.  Unlike the qform matrix, the sform
	/// matrix can contain scaling information and can even (rarely) have
	/// a negative determinant, i.e. a flip.  This matrix is modified slightly
	/// as compared to the sform matrix stored in the NIFTI header: the pixdim
	/// pixel spacing is factored out.  Also, if QFac is -1, then the VTK slices
	/// are in reverse order as compared to the NIFTI slices, hence as compared
	/// to the sform matrix stored in the header, the third column of this matrix
	/// is multiplied by -1 and the Z offset is shifted to compensate for the
	/// fact that the last slice has become the first.
	/// </summary>
	public vtkMatrix4x4 GetSFormMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageReader_GetSFormMatrix_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkNIFTIImageReader_GetTimeAsVector_13(HandleRef pThis);

	/// <summary>
	/// Read the time dimension as scalar components (default: Off).
	/// If this is on, then each time point will be stored as a component in
	/// the image data.  If the file has both a time dimension and a vector
	/// dimension, then the number of components will be the product of these
	/// two dimensions, i.e. the components will store a sequence of vectors.
	/// </summary>
	public virtual bool GetTimeAsVector()
	{
		return (vtkNIFTIImageReader_GetTimeAsVector_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageReader_GetTimeDimension_14(HandleRef pThis);

	/// <summary>
	/// Get the time dimension that was stored in the NIFTI header.
	/// </summary>
	public int GetTimeDimension()
	{
		return vtkNIFTIImageReader_GetTimeDimension_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageReader_GetTimeSpacing_15(HandleRef pThis);

	/// <summary>
	/// Get the time dimension that was stored in the NIFTI header.
	/// </summary>
	public double GetTimeSpacing()
	{
		return vtkNIFTIImageReader_GetTimeSpacing_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageReader_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNIFTIImageReader_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageReader_IsTypeOf_17(string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNIFTIImageReader_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new vtkNIFTIImageReader NewInstance()
	{
		vtkNIFTIImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageReader_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageReader_PlanarRGBOff_20(HandleRef pThis);

	/// <summary>
	/// Read planar RGB (separate R, G, and B planes), rather than packed RGB.
	/// The NIFTI format should always use packed RGB.  The Analyze format,
	/// however, was used to store both planar RGB and packed RGB depending
	/// on the software, without any indication in the header about which
	/// convention was being used.  Use this if you have a planar RGB file.
	/// </summary>
	public virtual void PlanarRGBOff()
	{
		vtkNIFTIImageReader_PlanarRGBOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageReader_PlanarRGBOn_21(HandleRef pThis);

	/// <summary>
	/// Read planar RGB (separate R, G, and B planes), rather than packed RGB.
	/// The NIFTI format should always use packed RGB.  The Analyze format,
	/// however, was used to store both planar RGB and packed RGB depending
	/// on the software, without any indication in the header about which
	/// convention was being used.  Use this if you have a planar RGB file.
	/// </summary>
	public virtual void PlanarRGBOn()
	{
		vtkNIFTIImageReader_PlanarRGBOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static vtkNIFTIImageReader SafeDownCast(vtkObjectBase o)
	{
		vtkNIFTIImageReader vtkNIFTIImageReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageReader_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNIFTIImageReader2 = (vtkNIFTIImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNIFTIImageReader2.Register(null);
			}
		}
		return vtkNIFTIImageReader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageReader_SetPlanarRGB_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Read planar RGB (separate R, G, and B planes), rather than packed RGB.
	/// The NIFTI format should always use packed RGB.  The Analyze format,
	/// however, was used to store both planar RGB and packed RGB depending
	/// on the software, without any indication in the header about which
	/// convention was being used.  Use this if you have a planar RGB file.
	/// </summary>
	public virtual void SetPlanarRGB(bool _arg)
	{
		vtkNIFTIImageReader_SetPlanarRGB_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageReader_SetTimeAsVector_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Read the time dimension as scalar components (default: Off).
	/// If this is on, then each time point will be stored as a component in
	/// the image data.  If the file has both a time dimension and a vector
	/// dimension, then the number of components will be the product of these
	/// two dimensions, i.e. the components will store a sequence of vectors.
	/// </summary>
	public virtual void SetTimeAsVector(bool _arg)
	{
		vtkNIFTIImageReader_SetTimeAsVector_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageReader_TimeAsVectorOff_25(HandleRef pThis);

	/// <summary>
	/// Read the time dimension as scalar components (default: Off).
	/// If this is on, then each time point will be stored as a component in
	/// the image data.  If the file has both a time dimension and a vector
	/// dimension, then the number of components will be the product of these
	/// two dimensions, i.e. the components will store a sequence of vectors.
	/// </summary>
	public virtual void TimeAsVectorOff()
	{
		vtkNIFTIImageReader_TimeAsVectorOff_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageReader_TimeAsVectorOn_26(HandleRef pThis);

	/// <summary>
	/// Read the time dimension as scalar components (default: Off).
	/// If this is on, then each time point will be stored as a component in
	/// the image data.  If the file has both a time dimension and a vector
	/// dimension, then the number of components will be the product of these
	/// two dimensions, i.e. the components will store a sequence of vectors.
	/// </summary>
	public virtual void TimeAsVectorOn()
	{
		vtkNIFTIImageReader_TimeAsVectorOn_26(GetCppThis());
	}
}
