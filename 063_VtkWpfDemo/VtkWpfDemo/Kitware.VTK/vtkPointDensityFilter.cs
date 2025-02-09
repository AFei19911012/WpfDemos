using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointDensityFilter
/// </summary>
/// <remarks>
///    produce density field from input point cloud
///
/// vtkPointDensityFilter is a filter that generates a density field on a
/// volume from a point cloud. Basically the density is computed as number of
/// points in a local neighborhood per unit volume; or optionally, the number
/// of points in a local neighborhood surrounding each voxel. The local
/// neighborhood is specified as a radius around each sample position (i.e.,
/// each voxel) which can be of fixed value; or the radius can be relative to
/// the voxel size. The density computation may be further weighted by a
/// scalar value which is simply multiplied by each point's presumed density
/// of 1.0.
///
/// To use this filter, specify an input of type vtkPointSet (i.e., has an
/// explicit representation of points). Optionally a scalar weighting function
/// can be provided (part of the input to the filter). Then specify how the
/// local spherical neighborhood is to be defined, either by a fixed radius or
/// a radius relative to the voxel size. Finally, specify how the density is
/// specified, either as a points/volume, or as number of points. (The
/// weighting scalar array will affect both of these results if provided and
/// enabled.)
///
/// An optional capability of the filter is to compute the gradients of the
/// resulting density function (a 3-component vector), which also includes the
/// gradient magnitude (single component scalar) and classification (regions
/// of zero function, a scalar with single unsigned char value per voxel).
///
/// @warning
/// A point locator is used to speed up searches. By default a fast
/// vtkStaticPointLocator is used; however the user may specify an alternative
/// locator. In some situations adaptive locators may run faster depending on
/// the relative variation in point cloud density.
///
/// @warning
/// Note that the volume calculation can be affected by the boundary. The
/// local spherical neighborhood around a "near volume boundary" voxel may
/// extend beyond the volume extent, meaning that density computation may be
/// reduced. To counter this effect, the volume may be increased in size
/// and/or resolution so that the point cloud fits well within the volume.
///
/// @warning
/// While this class is very similar to many other of VTK's the point
/// splatting and interpolation classes, the algorithm density computation is
/// specialized to generate the density computation over a volume, does not
/// require (scalar weighting) data attributes to run, and does not require
/// multiple inputs. As an interesting side note: using the
/// vtkPointInterpolation class with a vtkLinearKernel, a (scalar) weighting
/// point attribute, a point cloud source, and an input volume produces the
/// same result as this filter does (assuming that the input volume is the
/// same).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkCheckerboardSplatter vtkShepardMethod vtkGaussianSplatter
/// vtkPointInterpolator vtkSPHInterpolator
/// </seealso>
public class vtkPointDensityFilter : vtkImageAlgorithm
{
	/// <summary>
	/// This enum is used to classify the behavior of the function gradient. Regions
	/// where all density values used in the calculation of the gradient are zero
	/// are referred to as ZERO regions. Otherwise NON_ZERO. This can be used to
	/// differentiate between regions where data is available and where it is not.
	/// </summary>
	public enum FunctionClass
	{
		/// <summary>enum member</summary>
		NON_ZERO = 1,
		/// <summary>enum member</summary>
		ZERO = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointDensityFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointDensityFilter()
	{
		MRClassNameKey = "class vtkPointDensityFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointDensityFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointDensityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDensityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPointDensityFilter New()
	{
		vtkPointDensityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointDensityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointDensityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkPointDensityFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointDensityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_ComputeGradientOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of the gradient vector, gradient magnitude
	/// scalar, and function classification scalar. By default this is off. Note
	/// that this will increase execution time and the size of the output. (The
	/// names of these point data arrays are: "Gradient", "Gradient Magnitude",
	/// and "Classification".)
	/// </summary>
	public virtual void ComputeGradientOff()
	{
		vtkPointDensityFilter_ComputeGradientOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_ComputeGradientOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of the gradient vector, gradient magnitude
	/// scalar, and function classification scalar. By default this is off. Note
	/// that this will increase execution time and the size of the output. (The
	/// names of these point data arrays are: "Gradient", "Gradient Magnitude",
	/// and "Classification".)
	/// </summary>
	public virtual void ComputeGradientOn()
	{
		vtkPointDensityFilter_ComputeGradientOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetAdjustDistance_03(HandleRef pThis);

	/// <summary>
	/// Set / get the relative amount to pad the model bounds if automatic
	/// computation is performed. The padding is the fraction to scale
	/// the model bounds in each of the x-y-z directions. By default the
	/// padding is 0.10 (i.e., 10% larger in each direction).
	/// </summary>
	public virtual double GetAdjustDistance()
	{
		return vtkPointDensityFilter_GetAdjustDistance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetAdjustDistanceMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set / get the relative amount to pad the model bounds if automatic
	/// computation is performed. The padding is the fraction to scale
	/// the model bounds in each of the x-y-z directions. By default the
	/// padding is 0.10 (i.e., 10% larger in each direction).
	/// </summary>
	public virtual double GetAdjustDistanceMaxValue()
	{
		return vtkPointDensityFilter_GetAdjustDistanceMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetAdjustDistanceMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set / get the relative amount to pad the model bounds if automatic
	/// computation is performed. The padding is the fraction to scale
	/// the model bounds in each of the x-y-z directions. By default the
	/// padding is 0.10 (i.e., 10% larger in each direction).
	/// </summary>
	public virtual double GetAdjustDistanceMinValue()
	{
		return vtkPointDensityFilter_GetAdjustDistanceMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointDensityFilter_GetComputeGradient_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of the gradient vector, gradient magnitude
	/// scalar, and function classification scalar. By default this is off. Note
	/// that this will increase execution time and the size of the output. (The
	/// names of these point data arrays are: "Gradient", "Gradient Magnitude",
	/// and "Classification".)
	/// </summary>
	public virtual bool GetComputeGradient()
	{
		return (vtkPointDensityFilter_GetComputeGradient_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDensityFilter_GetDensityEstimate_07(HandleRef pThis);

	/// <summary>
	/// Specify the method to estimate point density. The density can be
	/// calculated using a fixed sphere radius; or a sphere radius that is
	/// relative to voxel size.
	/// </summary>
	public virtual int GetDensityEstimate()
	{
		return vtkPointDensityFilter_GetDensityEstimate_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDensityFilter_GetDensityEstimateAsString_08(HandleRef pThis);

	/// <summary>
	/// Specify the method to estimate point density. The density can be
	/// calculated using a fixed sphere radius; or a sphere radius that is
	/// relative to voxel size.
	/// </summary>
	public string GetDensityEstimateAsString()
	{
		return Marshal.PtrToStringAnsi(vtkPointDensityFilter_GetDensityEstimateAsString_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDensityFilter_GetDensityEstimateMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the method to estimate point density. The density can be
	/// calculated using a fixed sphere radius; or a sphere radius that is
	/// relative to voxel size.
	/// </summary>
	public virtual int GetDensityEstimateMaxValue()
	{
		return vtkPointDensityFilter_GetDensityEstimateMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDensityFilter_GetDensityEstimateMinValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the method to estimate point density. The density can be
	/// calculated using a fixed sphere radius; or a sphere radius that is
	/// relative to voxel size.
	/// </summary>
	public virtual int GetDensityEstimateMinValue()
	{
		return vtkPointDensityFilter_GetDensityEstimateMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDensityFilter_GetDensityForm_11(HandleRef pThis);

	/// <summary>
	/// Specify the form by which the density is expressed. Either the density is
	/// expressed as (number of points/local sphere volume), or as simply the
	/// (number of points) within the local sphere.
	/// </summary>
	public virtual int GetDensityForm()
	{
		return vtkPointDensityFilter_GetDensityForm_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDensityFilter_GetDensityFormAsString_12(HandleRef pThis);

	/// <summary>
	/// Specify the form by which the density is expressed. Either the density is
	/// expressed as (number of points/local sphere volume), or as simply the
	/// (number of points) within the local sphere.
	/// </summary>
	public string GetDensityFormAsString()
	{
		return Marshal.PtrToStringAnsi(vtkPointDensityFilter_GetDensityFormAsString_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDensityFilter_GetDensityFormMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the form by which the density is expressed. Either the density is
	/// expressed as (number of points/local sphere volume), or as simply the
	/// (number of points) within the local sphere.
	/// </summary>
	public virtual int GetDensityFormMaxValue()
	{
		return vtkPointDensityFilter_GetDensityFormMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDensityFilter_GetDensityFormMinValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the form by which the density is expressed. Either the density is
	/// expressed as (number of points/local sphere volume), or as simply the
	/// (number of points) within the local sphere.
	/// </summary>
	public virtual int GetDensityFormMinValue()
	{
		return vtkPointDensityFilter_GetDensityFormMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDensityFilter_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate near a
	/// specified interpolation position.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointDensityFilter_GetLocator_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDensityFilter_GetModelBounds_16(HandleRef pThis);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkPointDensityFilter_GetModelBounds_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_GetModelBounds_17(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkPointDensityFilter_GetModelBounds_17(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointDensityFilter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointDensityFilter_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointDensityFilter_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointDensityFilter_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetRadius_20(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable defining the local sphere used to estimate
	/// the density function. The Radius is used when the density estimate is
	///             ^ set to a fixed radius (i.e., the radius doesn't change).
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkPointDensityFilter_GetRadius_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetRadiusMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable defining the local sphere used to estimate
	/// the density function. The Radius is used when the density estimate is
	///             ^ set to a fixed radius (i.e., the radius doesn't change).
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkPointDensityFilter_GetRadiusMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetRadiusMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable defining the local sphere used to estimate
	/// the density function. The Radius is used when the density estimate is
	///             ^ set to a fixed radius (i.e., the radius doesn't change).
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkPointDensityFilter_GetRadiusMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetRelativeRadius_23(HandleRef pThis);

	/// <summary>
	/// Set / get the relative radius factor defining the local sphere used to
	/// estimate the density function. The relative sphere radius is equal to
	/// the diagonal length of a voxel times the radius factor. The RelativeRadius
	/// is used when the density estimate is set to relative radius (i.e.,
	/// relative to voxel size).
	/// </summary>
	public virtual double GetRelativeRadius()
	{
		return vtkPointDensityFilter_GetRelativeRadius_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetRelativeRadiusMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Set / get the relative radius factor defining the local sphere used to
	/// estimate the density function. The relative sphere radius is equal to
	/// the diagonal length of a voxel times the radius factor. The RelativeRadius
	/// is used when the density estimate is set to relative radius (i.e.,
	/// relative to voxel size).
	/// </summary>
	public virtual double GetRelativeRadiusMaxValue()
	{
		return vtkPointDensityFilter_GetRelativeRadiusMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointDensityFilter_GetRelativeRadiusMinValue_25(HandleRef pThis);

	/// <summary>
	/// Set / get the relative radius factor defining the local sphere used to
	/// estimate the density function. The relative sphere radius is equal to
	/// the diagonal length of a voxel times the radius factor. The RelativeRadius
	/// is used when the density estimate is set to relative radius (i.e.,
	/// relative to voxel size).
	/// </summary>
	public virtual double GetRelativeRadiusMinValue()
	{
		return vtkPointDensityFilter_GetRelativeRadiusMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDensityFilter_GetSampleDimensions_26(HandleRef pThis);

	/// <summary>
	/// Set / get the dimensions of the sampling volume. Higher values generally
	/// produce better results but may be much slower. Note however that too
	/// high a resolution can generate excessive noise; too low and data can be
	/// excessively smoothed.
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkPointDensityFilter_GetSampleDimensions_26(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_GetSampleDimensions_27(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the dimensions of the sampling volume. Higher values generally
	/// produce better results but may be much slower. Note however that too
	/// high a resolution can generate excessive noise; too low and data can be
	/// excessively smoothed.
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkPointDensityFilter_GetSampleDimensions_27(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointDensityFilter_GetScalarWeighting_28(HandleRef pThis);

	/// <summary>
	/// Turn on/off the weighting of point density by a scalar array. By default
	/// scalar weighting is off.
	/// </summary>
	public virtual bool GetScalarWeighting()
	{
		return (vtkPointDensityFilter_GetScalarWeighting_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDensityFilter_IsA_29(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointDensityFilter_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointDensityFilter_IsTypeOf_30(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointDensityFilter_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDensityFilter_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkPointDensityFilter NewInstance()
	{
		vtkPointDensityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointDensityFilter_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointDensityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointDensityFilter_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPointDensityFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPointDensityFilter vtkPointDensityFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointDensityFilter_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointDensityFilter2 = (vtkPointDensityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointDensityFilter2.Register(null);
			}
		}
		return vtkPointDensityFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_ScalarWeightingOff_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off the weighting of point density by a scalar array. By default
	/// scalar weighting is off.
	/// </summary>
	public virtual void ScalarWeightingOff()
	{
		vtkPointDensityFilter_ScalarWeightingOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_ScalarWeightingOn_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off the weighting of point density by a scalar array. By default
	/// scalar weighting is off.
	/// </summary>
	public virtual void ScalarWeightingOn()
	{
		vtkPointDensityFilter_ScalarWeightingOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetAdjustDistance_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the relative amount to pad the model bounds if automatic
	/// computation is performed. The padding is the fraction to scale
	/// the model bounds in each of the x-y-z directions. By default the
	/// padding is 0.10 (i.e., 10% larger in each direction).
	/// </summary>
	public virtual void SetAdjustDistance(double _arg)
	{
		vtkPointDensityFilter_SetAdjustDistance_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetComputeGradient_37(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the generation of the gradient vector, gradient magnitude
	/// scalar, and function classification scalar. By default this is off. Note
	/// that this will increase execution time and the size of the output. (The
	/// names of these point data arrays are: "Gradient", "Gradient Magnitude",
	/// and "Classification".)
	/// </summary>
	public virtual void SetComputeGradient(bool _arg)
	{
		vtkPointDensityFilter_SetComputeGradient_37(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetDensityEstimate_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the method to estimate point density. The density can be
	/// calculated using a fixed sphere radius; or a sphere radius that is
	/// relative to voxel size.
	/// </summary>
	public virtual void SetDensityEstimate(int _arg)
	{
		vtkPointDensityFilter_SetDensityEstimate_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetDensityEstimateToFixedRadius_39(HandleRef pThis);

	/// <summary>
	/// Specify the method to estimate point density. The density can be
	/// calculated using a fixed sphere radius; or a sphere radius that is
	/// relative to voxel size.
	/// </summary>
	public void SetDensityEstimateToFixedRadius()
	{
		vtkPointDensityFilter_SetDensityEstimateToFixedRadius_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetDensityEstimateToRelativeRadius_40(HandleRef pThis);

	/// <summary>
	/// Specify the method to estimate point density. The density can be
	/// calculated using a fixed sphere radius; or a sphere radius that is
	/// relative to voxel size.
	/// </summary>
	public void SetDensityEstimateToRelativeRadius()
	{
		vtkPointDensityFilter_SetDensityEstimateToRelativeRadius_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetDensityForm_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the form by which the density is expressed. Either the density is
	/// expressed as (number of points/local sphere volume), or as simply the
	/// (number of points) within the local sphere.
	/// </summary>
	public virtual void SetDensityForm(int _arg)
	{
		vtkPointDensityFilter_SetDensityForm_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetDensityFormToNumberOfPoints_42(HandleRef pThis);

	/// <summary>
	/// Specify the form by which the density is expressed. Either the density is
	/// expressed as (number of points/local sphere volume), or as simply the
	/// (number of points) within the local sphere.
	/// </summary>
	public void SetDensityFormToNumberOfPoints()
	{
		vtkPointDensityFilter_SetDensityFormToNumberOfPoints_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetDensityFormToVolumeNormalized_43(HandleRef pThis);

	/// <summary>
	/// Specify the form by which the density is expressed. Either the density is
	/// expressed as (number of points/local sphere volume), or as simply the
	/// (number of points) within the local sphere.
	/// </summary>
	public void SetDensityFormToVolumeNormalized()
	{
		vtkPointDensityFilter_SetDensityFormToVolumeNormalized_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetLocator_44(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate near a
	/// specified interpolation position.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkPointDensityFilter_SetLocator_44(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetModelBounds_45(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkPointDensityFilter_SetModelBounds_45(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetModelBounds_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(IntPtr _arg)
	{
		vtkPointDensityFilter_SetModelBounds_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetRadius_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the radius variable defining the local sphere used to estimate
	/// the density function. The Radius is used when the density estimate is
	///             ^ set to a fixed radius (i.e., the radius doesn't change).
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkPointDensityFilter_SetRadius_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetRelativeRadius_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the relative radius factor defining the local sphere used to
	/// estimate the density function. The relative sphere radius is equal to
	/// the diagonal length of a voxel times the radius factor. The RelativeRadius
	/// is used when the density estimate is set to relative radius (i.e.,
	/// relative to voxel size).
	/// </summary>
	public virtual void SetRelativeRadius(double _arg)
	{
		vtkPointDensityFilter_SetRelativeRadius_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetSampleDimensions_49(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set / get the dimensions of the sampling volume. Higher values generally
	/// produce better results but may be much slower. Note however that too
	/// high a resolution can generate excessive noise; too low and data can be
	/// excessively smoothed.
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkPointDensityFilter_SetSampleDimensions_49(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetSampleDimensions_50(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set / get the dimensions of the sampling volume. Higher values generally
	/// produce better results but may be much slower. Note however that too
	/// high a resolution can generate excessive noise; too low and data can be
	/// excessively smoothed.
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkPointDensityFilter_SetSampleDimensions_50(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointDensityFilter_SetScalarWeighting_51(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off the weighting of point density by a scalar array. By default
	/// scalar weighting is off.
	/// </summary>
	public virtual void SetScalarWeighting(bool _arg)
	{
		vtkPointDensityFilter_SetScalarWeighting_51(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
