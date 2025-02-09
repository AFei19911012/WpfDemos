using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageResize
/// </summary>
/// <remarks>
///    High-quality image resizing filter
///
/// vtkImageResize will magnify or shrink an image with interpolation and
/// antialiasing.  The resizing is done with a 5-lobe Lanczos-windowed sinc
/// filter that is bandlimited to the output sampling frequency in order to
/// avoid aliasing when the image size is reduced.  This filter utilizes a
/// O(n) algorithm to provide good efficiency even though the filtering kernel
/// is large.  The sinc interpolator can be turned off if nearest-neighbor
/// interpolation is required, or it can be replaced with a different
/// vtkImageInterpolator object.
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </remarks>
public class vtkImageResize : vtkThreadedImageAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum MAGNIFICATION_FACTORS_WrapperEnum
	{
		/// <summary>enum member</summary>
		MAGNIFICATION_FACTORS = 2,
		/// <summary>enum member</summary>
		OUTPUT_DIMENSIONS = 0,
		/// <summary>enum member</summary>
		OUTPUT_SPACING = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageResize";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageResize()
	{
		MRClassNameKey = "class vtkImageResize";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResize"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageResize(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageResize New()
	{
		vtkImageResize result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResize_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageResize)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageResize()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageResize_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_BorderOff_01(HandleRef pThis);

	/// <summary>
	/// If Border is Off (the default), then the centers of each of the corner
	/// voxels will be considered to form the rectangular bounds of the image.
	/// This is the way that VTK normally computes image bounds.  If Border is On,
	/// then the image bounds will be defined by the outer corners of the voxels.
	/// This setting impacts how the resizing is done.  For example, if a
	/// MagnificationFactor of two is applied to a 256x256 image, the output
	/// image will be 512x512 if Border is On, or 511x511 if Border is Off.
	/// </summary>
	public virtual void BorderOff()
	{
		vtkImageResize_BorderOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_BorderOn_02(HandleRef pThis);

	/// <summary>
	/// If Border is Off (the default), then the centers of each of the corner
	/// voxels will be considered to form the rectangular bounds of the image.
	/// This is the way that VTK normally computes image bounds.  If Border is On,
	/// then the image bounds will be defined by the outer corners of the voxels.
	/// This setting impacts how the resizing is done.  For example, if a
	/// MagnificationFactor of two is applied to a 256x256 image, the output
	/// image will be 512x512 if Border is On, or 511x511 if Border is Off.
	/// </summary>
	public virtual void BorderOn()
	{
		vtkImageResize_BorderOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_CroppingOff_03(HandleRef pThis);

	/// <summary>
	/// Whether to crop the input image before resizing (Off by default).  If this
	/// is On, then the CroppingRegion must be set.
	/// </summary>
	public virtual void CroppingOff()
	{
		vtkImageResize_CroppingOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_CroppingOn_04(HandleRef pThis);

	/// <summary>
	/// Whether to crop the input image before resizing (Off by default).  If this
	/// is On, then the CroppingRegion must be set.
	/// </summary>
	public virtual void CroppingOn()
	{
		vtkImageResize_CroppingOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResize_GetBorder_05(HandleRef pThis);

	/// <summary>
	/// If Border is Off (the default), then the centers of each of the corner
	/// voxels will be considered to form the rectangular bounds of the image.
	/// This is the way that VTK normally computes image bounds.  If Border is On,
	/// then the image bounds will be defined by the outer corners of the voxels.
	/// This setting impacts how the resizing is done.  For example, if a
	/// MagnificationFactor of two is applied to a 256x256 image, the output
	/// image will be 512x512 if Border is On, or 511x511 if Border is Off.
	/// </summary>
	public virtual int GetBorder()
	{
		return vtkImageResize_GetBorder_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResize_GetCropping_06(HandleRef pThis);

	/// <summary>
	/// Whether to crop the input image before resizing (Off by default).  If this
	/// is On, then the CroppingRegion must be set.
	/// </summary>
	public virtual int GetCropping()
	{
		return vtkImageResize_GetCropping_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_GetCroppingRegion_07(HandleRef pThis);

	/// <summary>
	/// If Cropping is On, then the CroppingRegion will be used to crop the image
	/// before it is resized.  The region must be specified in data coordinates,
	/// rather than voxel indices.
	/// </summary>
	public virtual double[] GetCroppingRegion()
	{
		IntPtr intPtr = vtkImageResize_GetCroppingRegion_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_GetCroppingRegion_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

	/// <summary>
	/// If Cropping is On, then the CroppingRegion will be used to crop the image
	/// before it is resized.  The region must be specified in data coordinates,
	/// rather than voxel indices.
	/// </summary>
	public virtual void GetCroppingRegion(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
	{
		vtkImageResize_GetCroppingRegion_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_GetCroppingRegion_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// If Cropping is On, then the CroppingRegion will be used to crop the image
	/// before it is resized.  The region must be specified in data coordinates,
	/// rather than voxel indices.
	/// </summary>
	public virtual void GetCroppingRegion(IntPtr _arg)
	{
		vtkImageResize_GetCroppingRegion_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResize_GetInterpolate_10(HandleRef pThis);

	/// <summary>
	/// Turn interpolation on or off (by default, interpolation is on).
	/// </summary>
	public virtual int GetInterpolate()
	{
		return vtkImageResize_GetInterpolate_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_GetInterpolator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the interpolator for resampling the data.
	/// </summary>
	public virtual vtkAbstractImageInterpolator GetInterpolator()
	{
		vtkAbstractImageInterpolator vtkAbstractImageInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResize_GetInterpolator_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractImageInterpolator2 = (vtkAbstractImageInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractImageInterpolator2.Register(null);
			}
		}
		return vtkAbstractImageInterpolator2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageResize_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// Get the modified time of the filter.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageResize_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_GetMagnificationFactors_13(HandleRef pThis);

	/// <summary>
	/// The desired magnification factor, meaning that the sample spacing will
	/// be reduced by this factor.  This setting is only used if the ResizeMethod
	/// is set to MagnificationFactors.
	/// </summary>
	public virtual double[] GetMagnificationFactors()
	{
		IntPtr intPtr = vtkImageResize_GetMagnificationFactors_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_GetMagnificationFactors_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The desired magnification factor, meaning that the sample spacing will
	/// be reduced by this factor.  This setting is only used if the ResizeMethod
	/// is set to MagnificationFactors.
	/// </summary>
	public virtual void GetMagnificationFactors(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageResize_GetMagnificationFactors_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_GetMagnificationFactors_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The desired magnification factor, meaning that the sample spacing will
	/// be reduced by this factor.  This setting is only used if the ResizeMethod
	/// is set to MagnificationFactors.
	/// </summary>
	public virtual void GetMagnificationFactors(IntPtr _arg)
	{
		vtkImageResize_GetMagnificationFactors_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageResize_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageResize_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageResize_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageResize_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_GetOutputDimensions_18(HandleRef pThis);

	/// <summary>
	/// The desired output dimensions.  This is only used if the ResizeMethod is
	/// set to OutputDimensions.  If you want to keep one of the image dimensions
	/// the same as the input, then set that dimension to -1.
	/// </summary>
	public virtual int[] GetOutputDimensions()
	{
		IntPtr intPtr = vtkImageResize_GetOutputDimensions_18(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_GetOutputDimensions_19(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// The desired output dimensions.  This is only used if the ResizeMethod is
	/// set to OutputDimensions.  If you want to keep one of the image dimensions
	/// the same as the input, then set that dimension to -1.
	/// </summary>
	public virtual void GetOutputDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageResize_GetOutputDimensions_19(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_GetOutputDimensions_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The desired output dimensions.  This is only used if the ResizeMethod is
	/// set to OutputDimensions.  If you want to keep one of the image dimensions
	/// the same as the input, then set that dimension to -1.
	/// </summary>
	public virtual void GetOutputDimensions(IntPtr _arg)
	{
		vtkImageResize_GetOutputDimensions_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_GetOutputSpacing_21(HandleRef pThis);

	/// <summary>
	/// The desired output spacing.  This is only used if the ResizeMethod is
	/// set to OutputSpacing.  If you want to keep one of the original spacing
	/// values, then set that spacing value to zero.
	/// </summary>
	public virtual double[] GetOutputSpacing()
	{
		IntPtr intPtr = vtkImageResize_GetOutputSpacing_21(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_GetOutputSpacing_22(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The desired output spacing.  This is only used if the ResizeMethod is
	/// set to OutputSpacing.  If you want to keep one of the original spacing
	/// values, then set that spacing value to zero.
	/// </summary>
	public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageResize_GetOutputSpacing_22(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_GetOutputSpacing_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The desired output spacing.  This is only used if the ResizeMethod is
	/// set to OutputSpacing.  If you want to keep one of the original spacing
	/// values, then set that spacing value to zero.
	/// </summary>
	public virtual void GetOutputSpacing(IntPtr _arg)
	{
		vtkImageResize_GetOutputSpacing_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResize_GetResizeMethod_24(HandleRef pThis);

	/// <summary>
	/// The resizing method to use.  The default is to set the output image
	/// dimensions, and allow the filter to resize the image to these new
	/// dimensions.  It is also possible to resize the image by setting the
	/// output image spacing or by setting a magnification factor.
	/// </summary>
	public virtual int GetResizeMethod()
	{
		return vtkImageResize_GetResizeMethod_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_GetResizeMethodAsString_25(HandleRef pThis);

	/// <summary>
	/// The resizing method to use.  The default is to set the output image
	/// dimensions, and allow the filter to resize the image to these new
	/// dimensions.  It is also possible to resize the image by setting the
	/// output image spacing or by setting a magnification factor.
	/// </summary>
	public virtual string GetResizeMethodAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageResize_GetResizeMethodAsString_25(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResize_GetResizeMethodMaxValue_26(HandleRef pThis);

	/// <summary>
	/// The resizing method to use.  The default is to set the output image
	/// dimensions, and allow the filter to resize the image to these new
	/// dimensions.  It is also possible to resize the image by setting the
	/// output image spacing or by setting a magnification factor.
	/// </summary>
	public virtual int GetResizeMethodMaxValue()
	{
		return vtkImageResize_GetResizeMethodMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResize_GetResizeMethodMinValue_27(HandleRef pThis);

	/// <summary>
	/// The resizing method to use.  The default is to set the output image
	/// dimensions, and allow the filter to resize the image to these new
	/// dimensions.  It is also possible to resize the image by setting the
	/// output image spacing or by setting a magnification factor.
	/// </summary>
	public virtual int GetResizeMethodMinValue()
	{
		return vtkImageResize_GetResizeMethodMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_InterpolateOff_28(HandleRef pThis);

	/// <summary>
	/// Turn interpolation on or off (by default, interpolation is on).
	/// </summary>
	public virtual void InterpolateOff()
	{
		vtkImageResize_InterpolateOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_InterpolateOn_29(HandleRef pThis);

	/// <summary>
	/// Turn interpolation on or off (by default, interpolation is on).
	/// </summary>
	public virtual void InterpolateOn()
	{
		vtkImageResize_InterpolateOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResize_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageResize_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResize_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageResize_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageResize NewInstance()
	{
		vtkImageResize result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResize_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageResize)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResize_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageResize SafeDownCast(vtkObjectBase o)
	{
		vtkImageResize vtkImageResize2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResize_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageResize2 = (vtkImageResize)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageResize2.Register(null);
			}
		}
		return vtkImageResize2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetBorder_35(HandleRef pThis, int _arg);

	/// <summary>
	/// If Border is Off (the default), then the centers of each of the corner
	/// voxels will be considered to form the rectangular bounds of the image.
	/// This is the way that VTK normally computes image bounds.  If Border is On,
	/// then the image bounds will be defined by the outer corners of the voxels.
	/// This setting impacts how the resizing is done.  For example, if a
	/// MagnificationFactor of two is applied to a 256x256 image, the output
	/// image will be 512x512 if Border is On, or 511x511 if Border is Off.
	/// </summary>
	public virtual void SetBorder(int _arg)
	{
		vtkImageResize_SetBorder_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetCropping_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Whether to crop the input image before resizing (Off by default).  If this
	/// is On, then the CroppingRegion must be set.
	/// </summary>
	public virtual void SetCropping(int _arg)
	{
		vtkImageResize_SetCropping_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetCroppingRegion_37(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// If Cropping is On, then the CroppingRegion will be used to crop the image
	/// before it is resized.  The region must be specified in data coordinates,
	/// rather than voxel indices.
	/// </summary>
	public virtual void SetCroppingRegion(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkImageResize_SetCroppingRegion_37(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetCroppingRegion_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// If Cropping is On, then the CroppingRegion will be used to crop the image
	/// before it is resized.  The region must be specified in data coordinates,
	/// rather than voxel indices.
	/// </summary>
	public virtual void SetCroppingRegion(IntPtr _arg)
	{
		vtkImageResize_SetCroppingRegion_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetInterpolate_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn interpolation on or off (by default, interpolation is on).
	/// </summary>
	public virtual void SetInterpolate(int _arg)
	{
		vtkImageResize_SetInterpolate_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetInterpolator_40(HandleRef pThis, HandleRef sampler);

	/// <summary>
	/// Set the interpolator for resampling the data.
	/// </summary>
	public virtual void SetInterpolator(vtkAbstractImageInterpolator sampler)
	{
		vtkImageResize_SetInterpolator_40(GetCppThis(), sampler?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetMagnificationFactors_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The desired magnification factor, meaning that the sample spacing will
	/// be reduced by this factor.  This setting is only used if the ResizeMethod
	/// is set to MagnificationFactors.
	/// </summary>
	public virtual void SetMagnificationFactors(double _arg1, double _arg2, double _arg3)
	{
		vtkImageResize_SetMagnificationFactors_41(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetMagnificationFactors_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The desired magnification factor, meaning that the sample spacing will
	/// be reduced by this factor.  This setting is only used if the ResizeMethod
	/// is set to MagnificationFactors.
	/// </summary>
	public virtual void SetMagnificationFactors(IntPtr _arg)
	{
		vtkImageResize_SetMagnificationFactors_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetOutputDimensions_43(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// The desired output dimensions.  This is only used if the ResizeMethod is
	/// set to OutputDimensions.  If you want to keep one of the image dimensions
	/// the same as the input, then set that dimension to -1.
	/// </summary>
	public virtual void SetOutputDimensions(int _arg1, int _arg2, int _arg3)
	{
		vtkImageResize_SetOutputDimensions_43(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetOutputDimensions_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The desired output dimensions.  This is only used if the ResizeMethod is
	/// set to OutputDimensions.  If you want to keep one of the image dimensions
	/// the same as the input, then set that dimension to -1.
	/// </summary>
	public virtual void SetOutputDimensions(IntPtr _arg)
	{
		vtkImageResize_SetOutputDimensions_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetOutputSpacing_45(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The desired output spacing.  This is only used if the ResizeMethod is
	/// set to OutputSpacing.  If you want to keep one of the original spacing
	/// values, then set that spacing value to zero.
	/// </summary>
	public virtual void SetOutputSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkImageResize_SetOutputSpacing_45(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetOutputSpacing_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The desired output spacing.  This is only used if the ResizeMethod is
	/// set to OutputSpacing.  If you want to keep one of the original spacing
	/// values, then set that spacing value to zero.
	/// </summary>
	public virtual void SetOutputSpacing(IntPtr _arg)
	{
		vtkImageResize_SetOutputSpacing_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetResizeMethod_47(HandleRef pThis, int _arg);

	/// <summary>
	/// The resizing method to use.  The default is to set the output image
	/// dimensions, and allow the filter to resize the image to these new
	/// dimensions.  It is also possible to resize the image by setting the
	/// output image spacing or by setting a magnification factor.
	/// </summary>
	public virtual void SetResizeMethod(int _arg)
	{
		vtkImageResize_SetResizeMethod_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetResizeMethodToMagnificationFactors_48(HandleRef pThis);

	/// <summary>
	/// The resizing method to use.  The default is to set the output image
	/// dimensions, and allow the filter to resize the image to these new
	/// dimensions.  It is also possible to resize the image by setting the
	/// output image spacing or by setting a magnification factor.
	/// </summary>
	public void SetResizeMethodToMagnificationFactors()
	{
		vtkImageResize_SetResizeMethodToMagnificationFactors_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetResizeMethodToOutputDimensions_49(HandleRef pThis);

	/// <summary>
	/// The resizing method to use.  The default is to set the output image
	/// dimensions, and allow the filter to resize the image to these new
	/// dimensions.  It is also possible to resize the image by setting the
	/// output image spacing or by setting a magnification factor.
	/// </summary>
	public void SetResizeMethodToOutputDimensions()
	{
		vtkImageResize_SetResizeMethodToOutputDimensions_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResize_SetResizeMethodToOutputSpacing_50(HandleRef pThis);

	/// <summary>
	/// The resizing method to use.  The default is to set the output image
	/// dimensions, and allow the filter to resize the image to these new
	/// dimensions.  It is also possible to resize the image by setting the
	/// output image spacing or by setting a magnification factor.
	/// </summary>
	public void SetResizeMethodToOutputSpacing()
	{
		vtkImageResize_SetResizeMethodToOutputSpacing_50(GetCppThis());
	}
}
