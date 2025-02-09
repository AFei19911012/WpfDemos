using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNIFTIImageWriter
/// </summary>
/// <remarks>
///    Write NIfTI-1 and NIfTI-2 medical image files
///
/// This class writes NIFTI files, either in .nii format or as separate
/// .img and .hdr files.  If told to write a file that ends in ".gz",
/// then the writer will automatically compress the file with zlib.
/// Images of type unsigned char that have 3 or 4 scalar components
/// will automatically be written as RGB or RGBA respectively.  Images
/// of type float or double that have 2 components will automatically be
/// written as complex values.
/// @par Thanks:
/// This class was contributed to VTK by the Calgary Image Processing and
/// Analysis Centre (CIPAC).
/// </remarks>
/// <seealso>
///
/// vtkNIFTIImageReader
/// </seealso>
public class vtkNIFTIImageWriter : vtkImageWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIImageWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNIFTIImageWriter()
	{
		MRClassNameKey = "class vtkNIFTIImageWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIImageWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNIFTIImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static vtkNIFTIImageWriter New()
	{
		vtkNIFTIImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public vtkNIFTIImageWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNIFTIImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkNIFTIImageWriter_GetDescription_01(HandleRef pThis);

	/// <summary>
	/// Set a short description (max 80 chars) of how the file was produced.
	/// The default description is "VTKX.Y" where X.Y is the VTK version.
	/// </summary>
	public virtual string GetDescription()
	{
		return Marshal.PtrToStringAnsi(vtkNIFTIImageWriter_GetDescription_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageWriter_GetNIFTIHeader_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the NIFTI header information to use when writing the file.
	/// The data dimensions and pixdim from the supplied header will be
	/// ignored.  Likewise, the QForm and SForm information in the supplied
	/// header will be ignored if you have called SetQFormMatrix() or
	/// SetSFormMatrix() to provide the orientation information for the file.
	/// </summary>
	public vtkNIFTIImageHeader GetNIFTIHeader()
	{
		vtkNIFTIImageHeader vtkNIFTIImageHeader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageWriter_GetNIFTIHeader_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkNIFTIImageWriter_GetNIFTIVersion_03(HandleRef pThis);

	/// <summary>
	/// Set the version number for the NIfTI file format to use.
	/// This can be 1, 2, or 0 (the default).  If set to zero, then it
	/// will save as NIfTI version 1 unless SetNIFTIHeader() provided
	/// header information from a NIfTI version 2 file.
	/// </summary>
	public virtual int GetNIFTIVersion()
	{
		return vtkNIFTIImageWriter_GetNIFTIVersion_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNIFTIImageWriter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNIFTIImageWriter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNIFTIImageWriter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkNIFTIImageWriter_GetPlanarRGB_06(HandleRef pThis);

	/// <summary>
	/// Write planar RGB (separate R, G, and B planes), rather than packed RGB.
	/// Use this option with extreme caution: the NIFTI standard requires RGB
	/// pixels to be packed.  The Analyze format, however, was used to store
	/// both planar RGB and packed RGB depending on the software, without any
	/// indication in the header about which convention was being used.
	/// </summary>
	public virtual bool GetPlanarRGB()
	{
		return (vtkNIFTIImageWriter_GetPlanarRGB_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageWriter_GetQFac_07(HandleRef pThis);

	/// <summary>
	/// The QFac sets the ordering of the slices in the NIFTI file.
	/// If QFac is -1, then the slice ordering in the file will be reversed
	/// as compared to VTK. Use with caution.
	/// </summary>
	public virtual double GetQFac()
	{
		return vtkNIFTIImageWriter_GetQFac_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageWriter_GetQFormMatrix_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the "qform" orientation and offset for the image data.
	/// The 3x3 portion of the matrix must be orthonormal and have a
	/// positive determinant, it will be used to compute the quaternion.
	/// The last column of the matrix will be used for the offset.
	/// In the NIFTI header, the qform_code will be set to 1.
	/// </summary>
	public vtkMatrix4x4 GetQFormMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageWriter_GetQFormMatrix_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkNIFTIImageWriter_GetRescaleIntercept_09(HandleRef pThis);

	/// <summary>
	/// Set the slope and intercept for calibrating the scalar values.
	/// Other programs that read the NIFTI file can use the equation
	/// v = u*RescaleSlope + RescaleIntercept to rescale the data to
	/// real values.  If both the slope and the intercept are zero,
	/// then the SclSlope and SclIntercept in the header info provided
	/// via SetNIFTIHeader() are used instead.
	/// </summary>
	public virtual double GetRescaleIntercept()
	{
		return vtkNIFTIImageWriter_GetRescaleIntercept_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageWriter_GetRescaleSlope_10(HandleRef pThis);

	/// <summary>
	/// Set the slope and intercept for calibrating the scalar values.
	/// Other programs that read the NIFTI file can use the equation
	/// v = u*RescaleSlope + RescaleIntercept to rescale the data to
	/// real values.  If both the slope and the intercept are zero,
	/// then the SclSlope and SclIntercept in the header info provided
	/// via SetNIFTIHeader() are used instead.
	/// </summary>
	public virtual double GetRescaleSlope()
	{
		return vtkNIFTIImageWriter_GetRescaleSlope_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageWriter_GetSFormMatrix_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a matrix for the "sform" transformation stored in the file.
	/// Unlike the qform matrix, the sform matrix can contain scaling
	/// information.  Before being stored in the NIFTI header, the
	/// first three columns of the matrix will be multiplied by the voxel
	/// spacing. In the NIFTI header, the sform_code will be set to 2.
	/// </summary>
	public vtkMatrix4x4 GetSFormMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageWriter_GetSFormMatrix_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkNIFTIImageWriter_GetTimeDimension_12(HandleRef pThis);

	/// <summary>
	/// Set the time dimension to use in the NIFTI file (or zero if none).
	/// The number of components of the input data must be divisible by the time
	/// dimension if the time dimension is not set to zero.  The vector dimension
	/// will be set to the number of components divided by the time dimension.
	/// </summary>
	public virtual int GetTimeDimension()
	{
		return vtkNIFTIImageWriter_GetTimeDimension_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkNIFTIImageWriter_GetTimeSpacing_13(HandleRef pThis);

	/// <summary>
	/// Set the time dimension to use in the NIFTI file (or zero if none).
	/// The number of components of the input data must be divisible by the time
	/// dimension if the time dimension is not set to zero.  The vector dimension
	/// will be set to the number of components divided by the time dimension.
	/// </summary>
	public virtual double GetTimeSpacing()
	{
		return vtkNIFTIImageWriter_GetTimeSpacing_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageWriter_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNIFTIImageWriter_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNIFTIImageWriter_IsTypeOf_15(string type);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNIFTIImageWriter_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageWriter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new vtkNIFTIImageWriter NewInstance()
	{
		vtkNIFTIImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageWriter_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNIFTIImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_PlanarRGBOff_18(HandleRef pThis);

	/// <summary>
	/// Write planar RGB (separate R, G, and B planes), rather than packed RGB.
	/// Use this option with extreme caution: the NIFTI standard requires RGB
	/// pixels to be packed.  The Analyze format, however, was used to store
	/// both planar RGB and packed RGB depending on the software, without any
	/// indication in the header about which convention was being used.
	/// </summary>
	public virtual void PlanarRGBOff()
	{
		vtkNIFTIImageWriter_PlanarRGBOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_PlanarRGBOn_19(HandleRef pThis);

	/// <summary>
	/// Write planar RGB (separate R, G, and B planes), rather than packed RGB.
	/// Use this option with extreme caution: the NIFTI standard requires RGB
	/// pixels to be packed.  The Analyze format, however, was used to store
	/// both planar RGB and packed RGB depending on the software, without any
	/// indication in the header about which convention was being used.
	/// </summary>
	public virtual void PlanarRGBOn()
	{
		vtkNIFTIImageWriter_PlanarRGBOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNIFTIImageWriter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Static method for construction.
	/// </summary>
	public new static vtkNIFTIImageWriter SafeDownCast(vtkObjectBase o)
	{
		vtkNIFTIImageWriter vtkNIFTIImageWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNIFTIImageWriter_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNIFTIImageWriter2 = (vtkNIFTIImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNIFTIImageWriter2.Register(null);
			}
		}
		return vtkNIFTIImageWriter2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetDescription_21(HandleRef pThis, string _arg);

	/// <summary>
	/// Set a short description (max 80 chars) of how the file was produced.
	/// The default description is "VTKX.Y" where X.Y is the VTK version.
	/// </summary>
	public virtual void SetDescription(string _arg)
	{
		vtkNIFTIImageWriter_SetDescription_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetNIFTIHeader_22(HandleRef pThis, HandleRef hdr);

	/// <summary>
	/// Set the NIFTI header information to use when writing the file.
	/// The data dimensions and pixdim from the supplied header will be
	/// ignored.  Likewise, the QForm and SForm information in the supplied
	/// header will be ignored if you have called SetQFormMatrix() or
	/// SetSFormMatrix() to provide the orientation information for the file.
	/// </summary>
	public void SetNIFTIHeader(vtkNIFTIImageHeader hdr)
	{
		vtkNIFTIImageWriter_SetNIFTIHeader_22(GetCppThis(), hdr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetNIFTIVersion_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the version number for the NIfTI file format to use.
	/// This can be 1, 2, or 0 (the default).  If set to zero, then it
	/// will save as NIfTI version 1 unless SetNIFTIHeader() provided
	/// header information from a NIfTI version 2 file.
	/// </summary>
	public virtual void SetNIFTIVersion(int _arg)
	{
		vtkNIFTIImageWriter_SetNIFTIVersion_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetPlanarRGB_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Write planar RGB (separate R, G, and B planes), rather than packed RGB.
	/// Use this option with extreme caution: the NIFTI standard requires RGB
	/// pixels to be packed.  The Analyze format, however, was used to store
	/// both planar RGB and packed RGB depending on the software, without any
	/// indication in the header about which convention was being used.
	/// </summary>
	public virtual void SetPlanarRGB(bool _arg)
	{
		vtkNIFTIImageWriter_SetPlanarRGB_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetQFac_25(HandleRef pThis, double _arg);

	/// <summary>
	/// The QFac sets the ordering of the slices in the NIFTI file.
	/// If QFac is -1, then the slice ordering in the file will be reversed
	/// as compared to VTK. Use with caution.
	/// </summary>
	public virtual void SetQFac(double _arg)
	{
		vtkNIFTIImageWriter_SetQFac_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetQFormMatrix_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the "qform" orientation and offset for the image data.
	/// The 3x3 portion of the matrix must be orthonormal and have a
	/// positive determinant, it will be used to compute the quaternion.
	/// The last column of the matrix will be used for the offset.
	/// In the NIFTI header, the qform_code will be set to 1.
	/// </summary>
	public void SetQFormMatrix(vtkMatrix4x4 arg0)
	{
		vtkNIFTIImageWriter_SetQFormMatrix_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetRescaleIntercept_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the slope and intercept for calibrating the scalar values.
	/// Other programs that read the NIFTI file can use the equation
	/// v = u*RescaleSlope + RescaleIntercept to rescale the data to
	/// real values.  If both the slope and the intercept are zero,
	/// then the SclSlope and SclIntercept in the header info provided
	/// via SetNIFTIHeader() are used instead.
	/// </summary>
	public virtual void SetRescaleIntercept(double _arg)
	{
		vtkNIFTIImageWriter_SetRescaleIntercept_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetRescaleSlope_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the slope and intercept for calibrating the scalar values.
	/// Other programs that read the NIFTI file can use the equation
	/// v = u*RescaleSlope + RescaleIntercept to rescale the data to
	/// real values.  If both the slope and the intercept are zero,
	/// then the SclSlope and SclIntercept in the header info provided
	/// via SetNIFTIHeader() are used instead.
	/// </summary>
	public virtual void SetRescaleSlope(double _arg)
	{
		vtkNIFTIImageWriter_SetRescaleSlope_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetSFormMatrix_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set a matrix for the "sform" transformation stored in the file.
	/// Unlike the qform matrix, the sform matrix can contain scaling
	/// information.  Before being stored in the NIFTI header, the
	/// first three columns of the matrix will be multiplied by the voxel
	/// spacing. In the NIFTI header, the sform_code will be set to 2.
	/// </summary>
	public void SetSFormMatrix(vtkMatrix4x4 arg0)
	{
		vtkNIFTIImageWriter_SetSFormMatrix_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetTimeDimension_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the time dimension to use in the NIFTI file (or zero if none).
	/// The number of components of the input data must be divisible by the time
	/// dimension if the time dimension is not set to zero.  The vector dimension
	/// will be set to the number of components divided by the time dimension.
	/// </summary>
	public virtual void SetTimeDimension(int _arg)
	{
		vtkNIFTIImageWriter_SetTimeDimension_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNIFTIImageWriter_SetTimeSpacing_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the time dimension to use in the NIFTI file (or zero if none).
	/// The number of components of the input data must be divisible by the time
	/// dimension if the time dimension is not set to zero.  The vector dimension
	/// will be set to the number of components divided by the time dimension.
	/// </summary>
	public virtual void SetTimeSpacing(double _arg)
	{
		vtkNIFTIImageWriter_SetTimeSpacing_31(GetCppThis(), _arg);
	}
}
