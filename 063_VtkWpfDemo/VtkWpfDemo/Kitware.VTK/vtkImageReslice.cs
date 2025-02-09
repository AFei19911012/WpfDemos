using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageReslice
/// </summary>
/// <remarks>
///    Reslices a volume along a new set of axes.
///
/// vtkImageReslice is the swiss-army-knife of image geometry filters:
/// It can permute, rotate, flip, scale, resample, deform, and pad image
/// data in any combination with reasonably high efficiency.  Simple
/// operations such as permutation, resampling and padding are done
/// with similar efficiently to the specialized vtkImagePermute,
/// vtkImageResample, and vtkImagePad filters.  There are a number of
/// tasks that vtkImageReslice is well suited for:
/// &lt;p&gt;1) Application of simple rotations, scales, and translations to
/// an image. It is often a good idea to use vtkImageChangeInformation
/// to center the image first, so that scales and rotations occur around
/// the center rather than around the lower-left corner of the image.
/// &lt;p&gt;2) Resampling of one data set to match the voxel sampling of
/// a second data set via the SetInformationInput() method, e.g. for
/// the purpose of comparing two images or combining two images.
/// A transformation, either linear or nonlinear, can be applied
/// at the same time via the SetResliceTransform method if the two
/// images are not in the same coordinate space.
/// &lt;p&gt;3) Extraction of slices from an image volume.  The most convenient
/// way to do this is to use SetResliceAxesDirectionCosines() to
/// specify the orientation of the slice.  The direction cosines give
/// the x, y, and z axes for the output volume.  The method
/// SetOutputDimensionality(2) is used to specify that want to output a
/// slice rather than a volume.  The SetResliceAxesOrigin() command is
/// used to provide an (x,y,z) point that the slice will pass through.
/// You can use both the ResliceAxes and the ResliceTransform at the
/// same time, in order to extract slices from a volume that you have
/// applied a transformation to.
/// @warning
/// This filter is very inefficient if the output X dimension is 1.
/// </remarks>
/// <seealso>
///
/// vtkAbstractTransform vtkMatrix4x4
/// </seealso>
public class vtkImageReslice : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageReslice";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageReslice()
	{
		MRClassNameKey = "class vtkImageReslice";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReslice"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageReslice(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageReslice New()
	{
		vtkImageReslice result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageReslice()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageReslice_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageReslice_AutoCropOutputOff_01(HandleRef pThis);

	/// <summary>
	/// Turn this on if you want to guarantee that the extent of the
	/// output will be large enough to ensure that none of the
	/// data will be cropped (default: Off).
	/// </summary>
	public virtual void AutoCropOutputOff()
	{
		vtkImageReslice_AutoCropOutputOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_AutoCropOutputOn_02(HandleRef pThis);

	/// <summary>
	/// Turn this on if you want to guarantee that the extent of the
	/// output will be large enough to ensure that none of the
	/// data will be cropped (default: Off).
	/// </summary>
	public virtual void AutoCropOutputOn()
	{
		vtkImageReslice_AutoCropOutputOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_BorderOff_03(HandleRef pThis);

	/// <summary>
	/// Extend the apparent input border by a half voxel (default: On).
	/// This changes how interpolation is handled at the borders of the
	/// input image: if the center of an output voxel is beyond the edge
	/// of the input image, but is within a half voxel width of the edge
	/// (using the input voxel width), then the value of the output voxel
	/// is calculated as if the input's edge voxels were duplicated past
	/// the edges of the input.
	/// This has no effect if Mirror or Wrap are on.
	/// </summary>
	public virtual void BorderOff()
	{
		vtkImageReslice_BorderOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_BorderOn_04(HandleRef pThis);

	/// <summary>
	/// Extend the apparent input border by a half voxel (default: On).
	/// This changes how interpolation is handled at the borders of the
	/// input image: if the center of an output voxel is beyond the edge
	/// of the input image, but is within a half voxel width of the edge
	/// (using the input voxel width), then the value of the output voxel
	/// is calculated as if the input's edge voxels were duplicated past
	/// the edges of the input.
	/// This has no effect if Mirror or Wrap are on.
	/// </summary>
	public virtual void BorderOn()
	{
		vtkImageReslice_BorderOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GenerateStencilOutputOff_05(HandleRef pThis);

	/// <summary>
	/// Generate an output stencil that defines which pixels were
	/// interpolated and which pixels were out-of-bounds of the input.
	/// </summary>
	public virtual void GenerateStencilOutputOff()
	{
		vtkImageReslice_GenerateStencilOutputOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GenerateStencilOutputOn_06(HandleRef pThis);

	/// <summary>
	/// Generate an output stencil that defines which pixels were
	/// interpolated and which pixels were out-of-bounds of the input.
	/// </summary>
	public virtual void GenerateStencilOutputOn()
	{
		vtkImageReslice_GenerateStencilOutputOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetAutoCropOutput_07(HandleRef pThis);

	/// <summary>
	/// Turn this on if you want to guarantee that the extent of the
	/// output will be large enough to ensure that none of the
	/// data will be cropped (default: Off).
	/// </summary>
	public virtual int GetAutoCropOutput()
	{
		return vtkImageReslice_GetAutoCropOutput_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetBackgroundColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set the background color (for multi-component images).
	/// </summary>
	public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkImageReslice_GetBackgroundColor_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetBackgroundColor_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the background color (for multi-component images).
	/// </summary>
	public virtual void GetBackgroundColor(IntPtr _arg)
	{
		vtkImageReslice_GetBackgroundColor_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetBackgroundColor_10(HandleRef pThis);

	/// <summary>
	/// Set the background color (for multi-component images).
	/// </summary>
	public virtual double[] GetBackgroundColor()
	{
		IntPtr intPtr = vtkImageReslice_GetBackgroundColor_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageReslice_GetBackgroundLevel_11(HandleRef pThis);

	/// <summary>
	/// Set background grey level (for single-component images).
	/// </summary>
	public double GetBackgroundLevel()
	{
		return vtkImageReslice_GetBackgroundLevel_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetBorder_12(HandleRef pThis);

	/// <summary>
	/// Extend the apparent input border by a half voxel (default: On).
	/// This changes how interpolation is handled at the borders of the
	/// input image: if the center of an output voxel is beyond the edge
	/// of the input image, but is within a half voxel width of the edge
	/// (using the input voxel width), then the value of the output voxel
	/// is calculated as if the input's edge voxels were duplicated past
	/// the edges of the input.
	/// This has no effect if Mirror or Wrap are on.
	/// </summary>
	public virtual int GetBorder()
	{
		return vtkImageReslice_GetBorder_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageReslice_GetBorderThickness_13(HandleRef pThis);

	/// <summary>
	/// Set the border thickness for BorderOn() (default: 0.5).
	/// See SetBorder() for more information.
	/// </summary>
	public virtual double GetBorderThickness()
	{
		return vtkImageReslice_GetBorderThickness_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetGenerateStencilOutput_14(HandleRef pThis);

	/// <summary>
	/// Generate an output stencil that defines which pixels were
	/// interpolated and which pixels were out-of-bounds of the input.
	/// </summary>
	public virtual int GetGenerateStencilOutput()
	{
		return vtkImageReslice_GetGenerateStencilOutput_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetInformationInput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a vtkImageData from which the default Spacing, Origin,
	/// and WholeExtent of the output will be copied.  The spacing,
	/// origin, and extent will be permuted according to the
	/// ResliceAxes.  Any values set via SetOutputSpacing,
	/// SetOutputOrigin, and SetOutputExtent will override these
	/// values.  By default, the Spacing, Origin, and WholeExtent
	/// of the Input are used.
	/// </summary>
	public virtual vtkImageData GetInformationInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_GetInformationInput_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetInterpolate_16(HandleRef pThis);

	/// <summary>
	/// Convenient methods for switching between nearest-neighbor and linear
	/// interpolation.
	/// InterpolateOn() is equivalent to SetInterpolationModeToLinear() and
	/// InterpolateOff() is equivalent to SetInterpolationModeToNearestNeighbor()
	/// You should not use these methods if you use the SetInterpolationMode
	/// methods.
	/// </summary>
	public int GetInterpolate()
	{
		return vtkImageReslice_GetInterpolate_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetInterpolationMode_17(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode (default: nearest neighbor).
	/// </summary>
	public virtual int GetInterpolationMode()
	{
		return vtkImageReslice_GetInterpolationMode_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetInterpolationModeAsString_18(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode (default: nearest neighbor).
	/// </summary>
	public virtual string GetInterpolationModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageReslice_GetInterpolationModeAsString_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetInterpolationModeMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode (default: nearest neighbor).
	/// </summary>
	public virtual int GetInterpolationModeMaxValue()
	{
		return vtkImageReslice_GetInterpolationModeMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetInterpolationModeMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode (default: nearest neighbor).
	/// </summary>
	public virtual int GetInterpolationModeMinValue()
	{
		return vtkImageReslice_GetInterpolationModeMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetInterpolator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the interpolator to use.  The default interpolator
	/// supports the Nearest, Linear, and Cubic interpolation modes.
	/// </summary>
	public virtual vtkAbstractImageInterpolator GetInterpolator()
	{
		vtkAbstractImageInterpolator vtkAbstractImageInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_GetInterpolator_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkImageReslice_GetMTime_22(HandleRef pThis);

	/// <summary>
	/// When determining the modified time of the filter,
	/// this check the modified time of the transform and matrix.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageReslice_GetMTime_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetMirror_23(HandleRef pThis);

	/// <summary>
	/// Turn on mirror-pad feature (default: Off).
	/// This will override the wrap-pad.
	/// </summary>
	public virtual int GetMirror()
	{
		return vtkImageReslice_GetMirror_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReslice_GetNumberOfGenerationsFromBase_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageReslice_GetNumberOfGenerationsFromBase_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReslice_GetNumberOfGenerationsFromBaseType_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageReslice_GetNumberOfGenerationsFromBaseType_25(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetOptimization_26(HandleRef pThis);

	/// <summary>
	/// Turn on and off optimizations (default on, they should only be
	/// turned off for testing purposes).
	/// </summary>
	public virtual int GetOptimization()
	{
		return vtkImageReslice_GetOptimization_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetOutputDimensionality_27(HandleRef pThis);

	/// <summary>
	/// Force the dimensionality of the output to either 1, 2,
	/// 3 or 0 (default: 3).  If the dimensionality is 2D, then
	/// the Z extent of the output is forced to (0,0) and the Z
	/// origin of the output is forced to 0.0 (i.e. the output
	/// extent is confined to the xy plane).  If the dimensionality
	/// is 1D, the output extent is confined to the x axis.
	/// For 0D, the output extent consists of a single voxel at
	/// (0,0,0).
	/// </summary>
	public virtual int GetOutputDimensionality()
	{
		return vtkImageReslice_GetOutputDimensionality_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetOutputExtent_28(HandleRef pThis);

	/// <summary>
	/// Set the extent for the output data.  The default output extent
	/// is the input extent permuted through the ResliceAxes.
	/// </summary>
	public virtual int[] GetOutputExtent()
	{
		IntPtr intPtr = vtkImageReslice_GetOutputExtent_28(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetOutputExtent_29(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the extent for the output data.  The default output extent
	/// is the input extent permuted through the ResliceAxes.
	/// </summary>
	public virtual void GetOutputExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageReslice_GetOutputExtent_29(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetOutputExtent_30(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the extent for the output data.  The default output extent
	/// is the input extent permuted through the ResliceAxes.
	/// </summary>
	public virtual void GetOutputExtent(IntPtr _arg)
	{
		vtkImageReslice_GetOutputExtent_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetOutputOrigin_31(HandleRef pThis);

	/// <summary>
	/// Set the origin for the output data.  The default output origin
	/// is the input origin permuted through the ResliceAxes.
	/// </summary>
	public virtual double[] GetOutputOrigin()
	{
		IntPtr intPtr = vtkImageReslice_GetOutputOrigin_31(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetOutputOrigin_32(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the origin for the output data.  The default output origin
	/// is the input origin permuted through the ResliceAxes.
	/// </summary>
	public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageReslice_GetOutputOrigin_32(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetOutputOrigin_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the origin for the output data.  The default output origin
	/// is the input origin permuted through the ResliceAxes.
	/// </summary>
	public virtual void GetOutputOrigin(IntPtr _arg)
	{
		vtkImageReslice_GetOutputOrigin_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetOutputScalarType_34(HandleRef pThis);

	/// <summary>
	/// Set the scalar type of the output to be different from the input.
	/// The default value is -1, which means that the input scalar type will be
	/// used to set the output scalar type.  Otherwise, this must be set to one
	/// of the following types: VTK_CHAR, VTK_SIGNED_CHAR, VTK_UNSIGNED_CHAR,
	/// VTK_SHORT, VTK_UNSIGNED_SHORT, VTK_INT, VTK_UNSIGNED_INT, VTK_FLOAT,
	/// or VTK_DOUBLE.  Other types are not permitted.  If the output type
	/// is an integer type, the output will be rounded and clamped to the
	/// limits of the type.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImageReslice_GetOutputScalarType_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetOutputSpacing_35(HandleRef pThis);

	/// <summary>
	/// Set the voxel spacing for the output data.  The default output
	/// spacing is the input spacing permuted through the ResliceAxes.
	/// </summary>
	public virtual double[] GetOutputSpacing()
	{
		IntPtr intPtr = vtkImageReslice_GetOutputSpacing_35(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetOutputSpacing_36(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the voxel spacing for the output data.  The default output
	/// spacing is the input spacing permuted through the ResliceAxes.
	/// </summary>
	public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageReslice_GetOutputSpacing_36(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetOutputSpacing_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the voxel spacing for the output data.  The default output
	/// spacing is the input spacing permuted through the ResliceAxes.
	/// </summary>
	public virtual void GetOutputSpacing(IntPtr _arg)
	{
		vtkImageReslice_GetOutputSpacing_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetResliceAxes_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method is used to set up the axes for the output voxels.
	/// The output Spacing, Origin, and Extent specify the locations
	/// of the voxels within the coordinate system defined by the axes.
	/// The ResliceAxes are used most often to permute the data, e.g.
	/// to extract ZY or XZ slices of a volume as 2D XY images.
	/// &lt;p&gt;The first column of the matrix specifies the x-axis
	/// vector (the fourth element must be set to zero), the second
	/// column specifies the y-axis, and the third column the
	/// z-axis.  The fourth column is the origin of the
	/// axes (the fourth element must be set to one).
	/// &lt;p&gt;An alternative to SetResliceAxes() is to use
	/// SetResliceAxesDirectionCosines() to set the directions of the
	/// axes and SetResliceAxesOrigin() to set the origin of the axes.
	/// </summary>
	public virtual vtkMatrix4x4 GetResliceAxes()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_GetResliceAxes_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetResliceAxesDirectionCosines_39(HandleRef pThis, IntPtr x, IntPtr y, IntPtr z);

	/// <summary>
	/// Specify the direction cosines for the ResliceAxes (i.e. the
	/// first three elements of each of the first three columns of
	/// the ResliceAxes matrix).  This will modify the current
	/// ResliceAxes matrix, or create a new matrix if none exists.
	/// </summary>
	public void GetResliceAxesDirectionCosines(IntPtr x, IntPtr y, IntPtr z)
	{
		vtkImageReslice_GetResliceAxesDirectionCosines_39(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetResliceAxesDirectionCosines_40(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Specify the direction cosines for the ResliceAxes (i.e. the
	/// first three elements of each of the first three columns of
	/// the ResliceAxes matrix).  This will modify the current
	/// ResliceAxes matrix, or create a new matrix if none exists.
	/// </summary>
	public void GetResliceAxesDirectionCosines(IntPtr xyz)
	{
		vtkImageReslice_GetResliceAxesDirectionCosines_40(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetResliceAxesDirectionCosines_41(HandleRef pThis);

	/// <summary>
	/// Specify the direction cosines for the ResliceAxes (i.e. the
	/// first three elements of each of the first three columns of
	/// the ResliceAxes matrix).  This will modify the current
	/// ResliceAxes matrix, or create a new matrix if none exists.
	/// </summary>
	public double[] GetResliceAxesDirectionCosines()
	{
		IntPtr intPtr = vtkImageReslice_GetResliceAxesDirectionCosines_41(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[9];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_GetResliceAxesOrigin_42(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Specify the origin for the ResliceAxes (i.e. the first three
	/// elements of the final column of the ResliceAxes matrix).
	/// This will modify the current ResliceAxes matrix, or create
	/// new matrix if none exists.
	/// </summary>
	public void GetResliceAxesOrigin(IntPtr xyz)
	{
		vtkImageReslice_GetResliceAxesOrigin_42(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetResliceAxesOrigin_43(HandleRef pThis);

	/// <summary>
	/// Specify the origin for the ResliceAxes (i.e. the first three
	/// elements of the final column of the ResliceAxes matrix).
	/// This will modify the current ResliceAxes matrix, or create
	/// new matrix if none exists.
	/// </summary>
	public double[] GetResliceAxesOrigin()
	{
		IntPtr intPtr = vtkImageReslice_GetResliceAxesOrigin_43(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetResliceTransform_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a transform to be applied to the resampling grid that has
	/// been defined via the ResliceAxes and the output Origin, Spacing
	/// and Extent.  Note that applying a transform to the resampling
	/// grid (which lies in the output coordinate system) is
	/// equivalent to applying the inverse of that transform to
	/// the input volume.  Nonlinear transforms such as vtkGridTransform
	/// and vtkThinPlateSplineTransform can be used here.
	/// </summary>
	public virtual vtkAbstractTransform GetResliceTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_GetResliceTransform_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageReslice_GetScalarScale_45(HandleRef pThis);

	/// <summary>
	/// Set multiplication factor to apply to all the output voxels.
	/// After a sample value has been interpolated from the input image, the
	/// equation u = (v + ScalarShift)*ScalarScale will be applied to it before
	/// it is written to the output image.  The result will always be clamped to
	/// the limits of the output data type.
	/// </summary>
	public virtual double GetScalarScale()
	{
		return vtkImageReslice_GetScalarScale_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageReslice_GetScalarShift_46(HandleRef pThis);

	/// <summary>
	/// Set a value to add to all the output voxels.
	/// After a sample value has been interpolated from the input image, the
	/// equation u = (v + ScalarShift)*ScalarScale will be applied to it before
	/// it is written to the output image.  The result will always be clamped to
	/// the limits of the output data type.
	/// </summary>
	public virtual double GetScalarShift()
	{
		return vtkImageReslice_GetScalarShift_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetSlabMode_47(HandleRef pThis);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public virtual int GetSlabMode()
	{
		return vtkImageReslice_GetSlabMode_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetSlabModeAsString_48(HandleRef pThis);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public virtual string GetSlabModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageReslice_GetSlabModeAsString_48(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetSlabModeMaxValue_49(HandleRef pThis);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public virtual int GetSlabModeMaxValue()
	{
		return vtkImageReslice_GetSlabModeMaxValue_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetSlabModeMinValue_50(HandleRef pThis);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public virtual int GetSlabModeMinValue()
	{
		return vtkImageReslice_GetSlabModeMinValue_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetSlabNumberOfSlices_51(HandleRef pThis);

	/// <summary>
	/// Set the number of slices that will be combined to create the slab.
	/// </summary>
	public virtual int GetSlabNumberOfSlices()
	{
		return vtkImageReslice_GetSlabNumberOfSlices_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageReslice_GetSlabSliceSpacingFraction_52(HandleRef pThis);

	/// <summary>
	/// The slab spacing as a fraction of the output slice spacing.
	/// When one of the various slab modes is chosen, each output slice is
	/// produced by generating several "temporary" output slices and then
	/// combining them according to the slab mode.  By default, the spacing
	/// between these temporary slices is the Z component of the OutputSpacing.
	/// This method sets the spacing between these temporary slices to be a
	/// fraction of the output spacing.
	/// </summary>
	public virtual double GetSlabSliceSpacingFraction()
	{
		return vtkImageReslice_GetSlabSliceSpacingFraction_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetSlabTrapezoidIntegration_53(HandleRef pThis);

	/// <summary>
	/// Use trapezoid integration for slab computation.  All this does is
	/// weigh the first and last slices by half when doing sum and mean.
	/// It is off by default.
	/// </summary>
	public virtual int GetSlabTrapezoidIntegration()
	{
		return vtkImageReslice_GetSlabTrapezoidIntegration_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetStencil_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Use a stencil to limit the calculations to a specific region of
	/// the output.  Portions of the output that are 'outside' the stencil
	/// will be cleared to the background color.
	/// </summary>
	public vtkImageStencilData GetStencil()
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_GetStencil_54(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetStencilOutput_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output stencil.
	/// </summary>
	public vtkImageStencilData GetStencilOutput()
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_GetStencilOutput_55(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_GetStencilOutputPort_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output stencil.
	/// </summary>
	public vtkAlgorithmOutput GetStencilOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_GetStencilOutputPort_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetTransformInputSampling_57(HandleRef pThis);

	/// <summary>
	/// Specify whether to transform the spacing, origin and extent
	/// of the Input (or the InformationInput) according to the
	/// direction cosines and origin of the ResliceAxes before applying
	/// them as the default output spacing, origin and extent
	/// (default: On).
	/// </summary>
	public virtual int GetTransformInputSampling()
	{
		return vtkImageReslice_GetTransformInputSampling_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_GetWrap_58(HandleRef pThis);

	/// <summary>
	/// Turn on wrap-pad feature (default: Off).
	/// </summary>
	public virtual int GetWrap()
	{
		return vtkImageReslice_GetWrap_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_InterpolateOff_59(HandleRef pThis);

	/// <summary>
	/// Convenient methods for switching between nearest-neighbor and linear
	/// interpolation.
	/// InterpolateOn() is equivalent to SetInterpolationModeToLinear() and
	/// InterpolateOff() is equivalent to SetInterpolationModeToNearestNeighbor()
	/// You should not use these methods if you use the SetInterpolationMode
	/// methods.
	/// </summary>
	public void InterpolateOff()
	{
		vtkImageReslice_InterpolateOff_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_InterpolateOn_60(HandleRef pThis);

	/// <summary>
	/// Convenient methods for switching between nearest-neighbor and linear
	/// interpolation.
	/// InterpolateOn() is equivalent to SetInterpolationModeToLinear() and
	/// InterpolateOff() is equivalent to SetInterpolationModeToNearestNeighbor()
	/// You should not use these methods if you use the SetInterpolationMode
	/// methods.
	/// </summary>
	public void InterpolateOn()
	{
		vtkImageReslice_InterpolateOn_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_IsA_61(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageReslice_IsA_61(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReslice_IsTypeOf_62(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageReslice_IsTypeOf_62(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_MirrorOff_63(HandleRef pThis);

	/// <summary>
	/// Turn on mirror-pad feature (default: Off).
	/// This will override the wrap-pad.
	/// </summary>
	public virtual void MirrorOff()
	{
		vtkImageReslice_MirrorOff_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_MirrorOn_64(HandleRef pThis);

	/// <summary>
	/// Turn on mirror-pad feature (default: Off).
	/// This will override the wrap-pad.
	/// </summary>
	public virtual void MirrorOn()
	{
		vtkImageReslice_MirrorOn_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageReslice NewInstance()
	{
		vtkImageReslice result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_NewInstance_66(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_OptimizationOff_67(HandleRef pThis);

	/// <summary>
	/// Turn on and off optimizations (default on, they should only be
	/// turned off for testing purposes).
	/// </summary>
	public virtual void OptimizationOff()
	{
		vtkImageReslice_OptimizationOff_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_OptimizationOn_68(HandleRef pThis);

	/// <summary>
	/// Turn on and off optimizations (default on, they should only be
	/// turned off for testing purposes).
	/// </summary>
	public virtual void OptimizationOn()
	{
		vtkImageReslice_OptimizationOn_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_ReportReferences_69(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Report object referenced by instances of this class.
	/// </summary>
	public virtual void ReportReferences(vtkGarbageCollector arg0)
	{
		vtkImageReslice_ReportReferences_69(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReslice_SafeDownCast_70(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageReslice SafeDownCast(vtkObjectBase o)
	{
		vtkImageReslice vtkImageReslice2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReslice_SafeDownCast_70(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageReslice2 = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageReslice2.Register(null);
			}
		}
		return vtkImageReslice2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetAutoCropOutput_71(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn this on if you want to guarantee that the extent of the
	/// output will be large enough to ensure that none of the
	/// data will be cropped (default: Off).
	/// </summary>
	public virtual void SetAutoCropOutput(int _arg)
	{
		vtkImageReslice_SetAutoCropOutput_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetBackgroundColor_72(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set the background color (for multi-component images).
	/// </summary>
	public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkImageReslice_SetBackgroundColor_72(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetBackgroundColor_73(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the background color (for multi-component images).
	/// </summary>
	public virtual void SetBackgroundColor(IntPtr _arg)
	{
		vtkImageReslice_SetBackgroundColor_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetBackgroundLevel_74(HandleRef pThis, double v);

	/// <summary>
	/// Set background grey level (for single-component images).
	/// </summary>
	public void SetBackgroundLevel(double v)
	{
		vtkImageReslice_SetBackgroundLevel_74(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetBorder_75(HandleRef pThis, int _arg);

	/// <summary>
	/// Extend the apparent input border by a half voxel (default: On).
	/// This changes how interpolation is handled at the borders of the
	/// input image: if the center of an output voxel is beyond the edge
	/// of the input image, but is within a half voxel width of the edge
	/// (using the input voxel width), then the value of the output voxel
	/// is calculated as if the input's edge voxels were duplicated past
	/// the edges of the input.
	/// This has no effect if Mirror or Wrap are on.
	/// </summary>
	public virtual void SetBorder(int _arg)
	{
		vtkImageReslice_SetBorder_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetBorderThickness_76(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the border thickness for BorderOn() (default: 0.5).
	/// See SetBorder() for more information.
	/// </summary>
	public virtual void SetBorderThickness(double _arg)
	{
		vtkImageReslice_SetBorderThickness_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetGenerateStencilOutput_77(HandleRef pThis, int _arg);

	/// <summary>
	/// Generate an output stencil that defines which pixels were
	/// interpolated and which pixels were out-of-bounds of the input.
	/// </summary>
	public virtual void SetGenerateStencilOutput(int _arg)
	{
		vtkImageReslice_SetGenerateStencilOutput_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetInformationInput_78(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set a vtkImageData from which the default Spacing, Origin,
	/// and WholeExtent of the output will be copied.  The spacing,
	/// origin, and extent will be permuted according to the
	/// ResliceAxes.  Any values set via SetOutputSpacing,
	/// SetOutputOrigin, and SetOutputExtent will override these
	/// values.  By default, the Spacing, Origin, and WholeExtent
	/// of the Input are used.
	/// </summary>
	public virtual void SetInformationInput(vtkImageData arg0)
	{
		vtkImageReslice_SetInformationInput_78(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetInterpolate_79(HandleRef pThis, int t);

	/// <summary>
	/// Convenient methods for switching between nearest-neighbor and linear
	/// interpolation.
	/// InterpolateOn() is equivalent to SetInterpolationModeToLinear() and
	/// InterpolateOff() is equivalent to SetInterpolationModeToNearestNeighbor()
	/// You should not use these methods if you use the SetInterpolationMode
	/// methods.
	/// </summary>
	public void SetInterpolate(int t)
	{
		vtkImageReslice_SetInterpolate_79(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetInterpolationMode_80(HandleRef pThis, int _arg);

	/// <summary>
	/// Set interpolation mode (default: nearest neighbor).
	/// </summary>
	public virtual void SetInterpolationMode(int _arg)
	{
		vtkImageReslice_SetInterpolationMode_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetInterpolationModeToCubic_81(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode (default: nearest neighbor).
	/// </summary>
	public void SetInterpolationModeToCubic()
	{
		vtkImageReslice_SetInterpolationModeToCubic_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetInterpolationModeToLinear_82(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode (default: nearest neighbor).
	/// </summary>
	public void SetInterpolationModeToLinear()
	{
		vtkImageReslice_SetInterpolationModeToLinear_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetInterpolationModeToNearestNeighbor_83(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode (default: nearest neighbor).
	/// </summary>
	public void SetInterpolationModeToNearestNeighbor()
	{
		vtkImageReslice_SetInterpolationModeToNearestNeighbor_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetInterpolator_84(HandleRef pThis, HandleRef sampler);

	/// <summary>
	/// Set the interpolator to use.  The default interpolator
	/// supports the Nearest, Linear, and Cubic interpolation modes.
	/// </summary>
	public virtual void SetInterpolator(vtkAbstractImageInterpolator sampler)
	{
		vtkImageReslice_SetInterpolator_84(GetCppThis(), sampler?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetMirror_85(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on mirror-pad feature (default: Off).
	/// This will override the wrap-pad.
	/// </summary>
	public virtual void SetMirror(int _arg)
	{
		vtkImageReslice_SetMirror_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOptimization_86(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on and off optimizations (default on, they should only be
	/// turned off for testing purposes).
	/// </summary>
	public virtual void SetOptimization(int _arg)
	{
		vtkImageReslice_SetOptimization_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputDimensionality_87(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the dimensionality of the output to either 1, 2,
	/// 3 or 0 (default: 3).  If the dimensionality is 2D, then
	/// the Z extent of the output is forced to (0,0) and the Z
	/// origin of the output is forced to 0.0 (i.e. the output
	/// extent is confined to the xy plane).  If the dimensionality
	/// is 1D, the output extent is confined to the x axis.
	/// For 0D, the output extent consists of a single voxel at
	/// (0,0,0).
	/// </summary>
	public virtual void SetOutputDimensionality(int _arg)
	{
		vtkImageReslice_SetOutputDimensionality_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputExtent_88(HandleRef pThis, int a, int b, int c, int d, int e, int f);

	/// <summary>
	/// Set the extent for the output data.  The default output extent
	/// is the input extent permuted through the ResliceAxes.
	/// </summary>
	public virtual void SetOutputExtent(int a, int b, int c, int d, int e, int f)
	{
		vtkImageReslice_SetOutputExtent_88(GetCppThis(), a, b, c, d, e, f);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputExtent_89(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the extent for the output data.  The default output extent
	/// is the input extent permuted through the ResliceAxes.
	/// </summary>
	public virtual void SetOutputExtent(IntPtr a)
	{
		vtkImageReslice_SetOutputExtent_89(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputExtentToDefault_90(HandleRef pThis);

	/// <summary>
	/// Set the extent for the output data.  The default output extent
	/// is the input extent permuted through the ResliceAxes.
	/// </summary>
	public void SetOutputExtentToDefault()
	{
		vtkImageReslice_SetOutputExtentToDefault_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputOrigin_91(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set the origin for the output data.  The default output origin
	/// is the input origin permuted through the ResliceAxes.
	/// </summary>
	public virtual void SetOutputOrigin(double x, double y, double z)
	{
		vtkImageReslice_SetOutputOrigin_91(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputOrigin_92(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the origin for the output data.  The default output origin
	/// is the input origin permuted through the ResliceAxes.
	/// </summary>
	public virtual void SetOutputOrigin(IntPtr a)
	{
		vtkImageReslice_SetOutputOrigin_92(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputOriginToDefault_93(HandleRef pThis);

	/// <summary>
	/// Set the origin for the output data.  The default output origin
	/// is the input origin permuted through the ResliceAxes.
	/// </summary>
	public void SetOutputOriginToDefault()
	{
		vtkImageReslice_SetOutputOriginToDefault_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputScalarType_94(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the scalar type of the output to be different from the input.
	/// The default value is -1, which means that the input scalar type will be
	/// used to set the output scalar type.  Otherwise, this must be set to one
	/// of the following types: VTK_CHAR, VTK_SIGNED_CHAR, VTK_UNSIGNED_CHAR,
	/// VTK_SHORT, VTK_UNSIGNED_SHORT, VTK_INT, VTK_UNSIGNED_INT, VTK_FLOAT,
	/// or VTK_DOUBLE.  Other types are not permitted.  If the output type
	/// is an integer type, the output will be rounded and clamped to the
	/// limits of the type.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkImageReslice_SetOutputScalarType_94(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputSpacing_95(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set the voxel spacing for the output data.  The default output
	/// spacing is the input spacing permuted through the ResliceAxes.
	/// </summary>
	public virtual void SetOutputSpacing(double x, double y, double z)
	{
		vtkImageReslice_SetOutputSpacing_95(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputSpacing_96(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the voxel spacing for the output data.  The default output
	/// spacing is the input spacing permuted through the ResliceAxes.
	/// </summary>
	public virtual void SetOutputSpacing(IntPtr a)
	{
		vtkImageReslice_SetOutputSpacing_96(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetOutputSpacingToDefault_97(HandleRef pThis);

	/// <summary>
	/// Set the voxel spacing for the output data.  The default output
	/// spacing is the input spacing permuted through the ResliceAxes.
	/// </summary>
	public void SetOutputSpacingToDefault()
	{
		vtkImageReslice_SetOutputSpacingToDefault_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetResliceAxes_98(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// This method is used to set up the axes for the output voxels.
	/// The output Spacing, Origin, and Extent specify the locations
	/// of the voxels within the coordinate system defined by the axes.
	/// The ResliceAxes are used most often to permute the data, e.g.
	/// to extract ZY or XZ slices of a volume as 2D XY images.
	/// &lt;p&gt;The first column of the matrix specifies the x-axis
	/// vector (the fourth element must be set to zero), the second
	/// column specifies the y-axis, and the third column the
	/// z-axis.  The fourth column is the origin of the
	/// axes (the fourth element must be set to one).
	/// &lt;p&gt;An alternative to SetResliceAxes() is to use
	/// SetResliceAxesDirectionCosines() to set the directions of the
	/// axes and SetResliceAxesOrigin() to set the origin of the axes.
	/// </summary>
	public virtual void SetResliceAxes(vtkMatrix4x4 arg0)
	{
		vtkImageReslice_SetResliceAxes_98(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_99(HandleRef pThis, double x0, double x1, double x2, double y0, double y1, double y2, double z0, double z1, double z2);

	/// <summary>
	/// Specify the direction cosines for the ResliceAxes (i.e. the
	/// first three elements of each of the first three columns of
	/// the ResliceAxes matrix).  This will modify the current
	/// ResliceAxes matrix, or create a new matrix if none exists.
	/// </summary>
	public void SetResliceAxesDirectionCosines(double x0, double x1, double x2, double y0, double y1, double y2, double z0, double z1, double z2)
	{
		vtkImageReslice_SetResliceAxesDirectionCosines_99(GetCppThis(), x0, x1, x2, y0, y1, y2, z0, z1, z2);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_100(HandleRef pThis, IntPtr x, IntPtr y, IntPtr z);

	/// <summary>
	/// Specify the direction cosines for the ResliceAxes (i.e. the
	/// first three elements of each of the first three columns of
	/// the ResliceAxes matrix).  This will modify the current
	/// ResliceAxes matrix, or create a new matrix if none exists.
	/// </summary>
	public void SetResliceAxesDirectionCosines(IntPtr x, IntPtr y, IntPtr z)
	{
		vtkImageReslice_SetResliceAxesDirectionCosines_100(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_101(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Specify the direction cosines for the ResliceAxes (i.e. the
	/// first three elements of each of the first three columns of
	/// the ResliceAxes matrix).  This will modify the current
	/// ResliceAxes matrix, or create a new matrix if none exists.
	/// </summary>
	public void SetResliceAxesDirectionCosines(IntPtr xyz)
	{
		vtkImageReslice_SetResliceAxesDirectionCosines_101(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetResliceAxesOrigin_102(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Specify the origin for the ResliceAxes (i.e. the first three
	/// elements of the final column of the ResliceAxes matrix).
	/// This will modify the current ResliceAxes matrix, or create
	/// new matrix if none exists.
	/// </summary>
	public void SetResliceAxesOrigin(double x, double y, double z)
	{
		vtkImageReslice_SetResliceAxesOrigin_102(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetResliceAxesOrigin_103(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Specify the origin for the ResliceAxes (i.e. the first three
	/// elements of the final column of the ResliceAxes matrix).
	/// This will modify the current ResliceAxes matrix, or create
	/// new matrix if none exists.
	/// </summary>
	public void SetResliceAxesOrigin(IntPtr xyz)
	{
		vtkImageReslice_SetResliceAxesOrigin_103(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetResliceTransform_104(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set a transform to be applied to the resampling grid that has
	/// been defined via the ResliceAxes and the output Origin, Spacing
	/// and Extent.  Note that applying a transform to the resampling
	/// grid (which lies in the output coordinate system) is
	/// equivalent to applying the inverse of that transform to
	/// the input volume.  Nonlinear transforms such as vtkGridTransform
	/// and vtkThinPlateSplineTransform can be used here.
	/// </summary>
	public virtual void SetResliceTransform(vtkAbstractTransform arg0)
	{
		vtkImageReslice_SetResliceTransform_104(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetScalarScale_105(HandleRef pThis, double _arg);

	/// <summary>
	/// Set multiplication factor to apply to all the output voxels.
	/// After a sample value has been interpolated from the input image, the
	/// equation u = (v + ScalarShift)*ScalarScale will be applied to it before
	/// it is written to the output image.  The result will always be clamped to
	/// the limits of the output data type.
	/// </summary>
	public virtual void SetScalarScale(double _arg)
	{
		vtkImageReslice_SetScalarScale_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetScalarShift_106(HandleRef pThis, double _arg);

	/// <summary>
	/// Set a value to add to all the output voxels.
	/// After a sample value has been interpolated from the input image, the
	/// equation u = (v + ScalarShift)*ScalarScale will be applied to it before
	/// it is written to the output image.  The result will always be clamped to
	/// the limits of the output data type.
	/// </summary>
	public virtual void SetScalarShift(double _arg)
	{
		vtkImageReslice_SetScalarShift_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetSlabMode_107(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public virtual void SetSlabMode(int _arg)
	{
		vtkImageReslice_SetSlabMode_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetSlabModeToMax_108(HandleRef pThis);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public void SetSlabModeToMax()
	{
		vtkImageReslice_SetSlabModeToMax_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetSlabModeToMean_109(HandleRef pThis);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public void SetSlabModeToMean()
	{
		vtkImageReslice_SetSlabModeToMean_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetSlabModeToMin_110(HandleRef pThis);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public void SetSlabModeToMin()
	{
		vtkImageReslice_SetSlabModeToMin_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetSlabModeToSum_111(HandleRef pThis);

	/// <summary>
	/// Set the slab mode, for generating thick slices. The default is Mean.
	/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
	/// each output slice will actually be a composite of N slices.  This method
	/// specifies the compositing mode to be used.
	/// </summary>
	public void SetSlabModeToSum()
	{
		vtkImageReslice_SetSlabModeToSum_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetSlabNumberOfSlices_112(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of slices that will be combined to create the slab.
	/// </summary>
	public virtual void SetSlabNumberOfSlices(int _arg)
	{
		vtkImageReslice_SetSlabNumberOfSlices_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetSlabSliceSpacingFraction_113(HandleRef pThis, double _arg);

	/// <summary>
	/// The slab spacing as a fraction of the output slice spacing.
	/// When one of the various slab modes is chosen, each output slice is
	/// produced by generating several "temporary" output slices and then
	/// combining them according to the slab mode.  By default, the spacing
	/// between these temporary slices is the Z component of the OutputSpacing.
	/// This method sets the spacing between these temporary slices to be a
	/// fraction of the output spacing.
	/// </summary>
	public virtual void SetSlabSliceSpacingFraction(double _arg)
	{
		vtkImageReslice_SetSlabSliceSpacingFraction_113(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetSlabTrapezoidIntegration_114(HandleRef pThis, int _arg);

	/// <summary>
	/// Use trapezoid integration for slab computation.  All this does is
	/// weigh the first and last slices by half when doing sum and mean.
	/// It is off by default.
	/// </summary>
	public virtual void SetSlabTrapezoidIntegration(int _arg)
	{
		vtkImageReslice_SetSlabTrapezoidIntegration_114(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetStencilData_115(HandleRef pThis, HandleRef stencil);

	/// <summary>
	/// Use a stencil to limit the calculations to a specific region of
	/// the output.  Portions of the output that are 'outside' the stencil
	/// will be cleared to the background color.
	/// </summary>
	public void SetStencilData(vtkImageStencilData stencil)
	{
		vtkImageReslice_SetStencilData_115(GetCppThis(), stencil?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetStencilOutput_116(HandleRef pThis, HandleRef stencil);

	/// <summary>
	/// Get the output stencil.
	/// </summary>
	public void SetStencilOutput(vtkImageStencilData stencil)
	{
		vtkImageReslice_SetStencilOutput_116(GetCppThis(), stencil?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetTransformInputSampling_117(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to transform the spacing, origin and extent
	/// of the Input (or the InformationInput) according to the
	/// direction cosines and origin of the ResliceAxes before applying
	/// them as the default output spacing, origin and extent
	/// (default: On).
	/// </summary>
	public virtual void SetTransformInputSampling(int _arg)
	{
		vtkImageReslice_SetTransformInputSampling_117(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SetWrap_118(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on wrap-pad feature (default: Off).
	/// </summary>
	public virtual void SetWrap(int _arg)
	{
		vtkImageReslice_SetWrap_118(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SlabTrapezoidIntegrationOff_119(HandleRef pThis);

	/// <summary>
	/// Use trapezoid integration for slab computation.  All this does is
	/// weigh the first and last slices by half when doing sum and mean.
	/// It is off by default.
	/// </summary>
	public virtual void SlabTrapezoidIntegrationOff()
	{
		vtkImageReslice_SlabTrapezoidIntegrationOff_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_SlabTrapezoidIntegrationOn_120(HandleRef pThis);

	/// <summary>
	/// Use trapezoid integration for slab computation.  All this does is
	/// weigh the first and last slices by half when doing sum and mean.
	/// It is off by default.
	/// </summary>
	public virtual void SlabTrapezoidIntegrationOn()
	{
		vtkImageReslice_SlabTrapezoidIntegrationOn_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_TransformInputSamplingOff_121(HandleRef pThis);

	/// <summary>
	/// Specify whether to transform the spacing, origin and extent
	/// of the Input (or the InformationInput) according to the
	/// direction cosines and origin of the ResliceAxes before applying
	/// them as the default output spacing, origin and extent
	/// (default: On).
	/// </summary>
	public virtual void TransformInputSamplingOff()
	{
		vtkImageReslice_TransformInputSamplingOff_121(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_TransformInputSamplingOn_122(HandleRef pThis);

	/// <summary>
	/// Specify whether to transform the spacing, origin and extent
	/// of the Input (or the InformationInput) according to the
	/// direction cosines and origin of the ResliceAxes before applying
	/// them as the default output spacing, origin and extent
	/// (default: On).
	/// </summary>
	public virtual void TransformInputSamplingOn()
	{
		vtkImageReslice_TransformInputSamplingOn_122(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_WrapOff_123(HandleRef pThis);

	/// <summary>
	/// Turn on wrap-pad feature (default: Off).
	/// </summary>
	public virtual void WrapOff()
	{
		vtkImageReslice_WrapOff_123(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReslice_WrapOn_124(HandleRef pThis);

	/// <summary>
	/// Turn on wrap-pad feature (default: Off).
	/// </summary>
	public virtual void WrapOn()
	{
		vtkImageReslice_WrapOn_124(GetCppThis());
	}
}
