using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGaussianSplatter
/// </summary>
/// <remarks>
///    splat points into a volume with an elliptical, Gaussian distribution
///
/// vtkGaussianSplatter is a filter that injects input points into a
/// structured points (volume) dataset. As each point is injected, it "splats"
/// or distributes values to nearby voxels. Data is distributed using an
/// elliptical, Gaussian distribution function. The distribution function is
/// modified using scalar values (expands distribution) or normals
/// (creates ellipsoidal distribution rather than spherical).
///
/// In general, the Gaussian distribution function f(x) around a given
/// splat point p is given by
///
///     f(x) = ScaleFactor * exp( ExponentFactor*((r/Radius)**2) )
///
/// where x is the current voxel sample point; r is the distance |x-p|
/// ExponentFactor &lt;= 0.0, and ScaleFactor can be multiplied by the scalar
/// value of the point p that is currently being splatted.
///
/// If points normals are present (and NormalWarping is on), then the splat
/// function becomes elliptical (as compared to the spherical one described
/// by the previous equation). The Gaussian distribution function then
/// becomes:
///
///     f(x) = ScaleFactor *
///               exp( ExponentFactor*( ((rxy/E)**2 + z**2)/R**2) )
///
/// where E is a user-defined eccentricity factor that controls the elliptical
/// shape of the splat; z is the distance of the current voxel sample point
/// along normal N; and rxy is the distance of x in the direction
/// prependicular to N.
///
/// This class is typically used to convert point-valued distributions into
/// a volume representation. The volume is then usually iso-surfaced or
/// volume rendered to generate a visualization. It can be used to create
/// surfaces from point distributions, or to create structure (i.e.,
/// topology) when none exists.
///
/// @warning
/// The input to this filter is any dataset type. This filter can be used
/// to resample any form of data, i.e., the input data need not be
/// unstructured.
///
/// @warning
/// Some voxels may never receive a contribution during the splatting process.
/// The final value of these points can be specified with the "NullValue"
/// instance variable.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkShepardMethod vtkCheckerboardSplatter
/// </seealso>
public class vtkGaussianSplatter : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianSplatter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGaussianSplatter()
	{
		MRClassNameKey = "class vtkGaussianSplatter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianSplatter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGaussianSplatter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianSplatter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with dimensions=(50,50,50); automatic computation of
	/// bounds; a splat radius of 0.1; an exponent factor of -5; and normal and
	/// scalar warping turned on.
	/// </summary>
	public new static vtkGaussianSplatter New()
	{
		vtkGaussianSplatter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGaussianSplatter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with dimensions=(50,50,50); automatic computation of
	/// bounds; a splat radius of 0.1; an exponent factor of -5; and normal and
	/// scalar warping turned on.
	/// </summary>
	public vtkGaussianSplatter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGaussianSplatter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_CappingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the capping of the outer boundary of the volume
	/// to a specified cap value. This can be used to close surfaces
	/// (after iso-surfacing) and create other effects.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkGaussianSplatter_CappingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_CappingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the capping of the outer boundary of the volume
	/// to a specified cap value. This can be used to close surfaces
	/// (after iso-surfacing) and create other effects.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkGaussianSplatter_CappingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_ComputeModelBounds_03(HandleRef pThis, HandleRef input, HandleRef output, HandleRef outInfo);

	/// <summary>
	/// Compute the size of the sample bounding box automatically from the
	/// input data. This is an internal helper function.
	/// </summary>
	public void ComputeModelBounds(vtkDataSet input, vtkImageData output, vtkInformation outInfo)
	{
		vtkGaussianSplatter_ComputeModelBounds_03(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), outInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_ComputeModelBounds_04(HandleRef pThis, HandleRef input, HandleRef output, HandleRef outInfo);

	/// <summary>
	/// Compute the size of the sample bounding box automatically from the
	/// input data. This is an internal helper function.
	/// </summary>
	public void ComputeModelBounds(vtkCompositeDataSet input, vtkImageData output, vtkInformation outInfo)
	{
		vtkGaussianSplatter_ComputeModelBounds_04(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), outInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianSplatter_GetAccumulationMode_05(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats are overlapped. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min
	/// mode acts like a set intersection, and the sum is just weird.
	/// </summary>
	public virtual int GetAccumulationMode()
	{
		return vtkGaussianSplatter_GetAccumulationMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianSplatter_GetAccumulationModeAsString_06(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats are overlapped. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min
	/// mode acts like a set intersection, and the sum is just weird.
	/// </summary>
	public string GetAccumulationModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkGaussianSplatter_GetAccumulationModeAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianSplatter_GetAccumulationModeMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats are overlapped. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min
	/// mode acts like a set intersection, and the sum is just weird.
	/// </summary>
	public virtual int GetAccumulationModeMaxValue()
	{
		return vtkGaussianSplatter_GetAccumulationModeMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianSplatter_GetAccumulationModeMinValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats are overlapped. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min
	/// mode acts like a set intersection, and the sum is just weird.
	/// </summary>
	public virtual int GetAccumulationModeMinValue()
	{
		return vtkGaussianSplatter_GetAccumulationModeMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetCapValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the cap value to use. (This instance variable only has effect
	/// if the ivar Capping is on.)
	/// </summary>
	public virtual double GetCapValue()
	{
		return vtkGaussianSplatter_GetCapValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianSplatter_GetCapping_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off the capping of the outer boundary of the volume
	/// to a specified cap value. This can be used to close surfaces
	/// (after iso-surfacing) and create other effects.
	/// </summary>
	public virtual int GetCapping()
	{
		return vtkGaussianSplatter_GetCapping_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetEccentricity_11(HandleRef pThis);

	/// <summary>
	/// Control the shape of elliptical splatting. Eccentricity is the ratio
	/// of the major axis (aligned along normal) to the minor (axes) aligned
	/// along other two axes. So Eccentricity &gt; 1 creates needles with the
	/// long axis in the direction of the normal; Eccentricity&lt;1 creates
	/// pancakes perpendicular to the normal vector.
	/// </summary>
	public virtual double GetEccentricity()
	{
		return vtkGaussianSplatter_GetEccentricity_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetEccentricityMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Control the shape of elliptical splatting. Eccentricity is the ratio
	/// of the major axis (aligned along normal) to the minor (axes) aligned
	/// along other two axes. So Eccentricity &gt; 1 creates needles with the
	/// long axis in the direction of the normal; Eccentricity&lt;1 creates
	/// pancakes perpendicular to the normal vector.
	/// </summary>
	public virtual double GetEccentricityMaxValue()
	{
		return vtkGaussianSplatter_GetEccentricityMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetEccentricityMinValue_13(HandleRef pThis);

	/// <summary>
	/// Control the shape of elliptical splatting. Eccentricity is the ratio
	/// of the major axis (aligned along normal) to the minor (axes) aligned
	/// along other two axes. So Eccentricity &gt; 1 creates needles with the
	/// long axis in the direction of the normal; Eccentricity&lt;1 creates
	/// pancakes perpendicular to the normal vector.
	/// </summary>
	public virtual double GetEccentricityMinValue()
	{
		return vtkGaussianSplatter_GetEccentricityMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetExponentFactor_14(HandleRef pThis);

	/// <summary>
	/// Set / get the sharpness of decay of the splats. This is the
	/// exponent constant in the Gaussian equation. Normally this is
	/// a negative value.
	/// </summary>
	public virtual double GetExponentFactor()
	{
		return vtkGaussianSplatter_GetExponentFactor_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianSplatter_GetModelBounds_15(HandleRef pThis);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkGaussianSplatter_GetModelBounds_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_GetModelBounds_16(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkGaussianSplatter_GetModelBounds_16(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianSplatter_GetNormalWarping_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of elliptical splats. If normal warping is
	/// on, then the input normals affect the distribution of the splat. This
	/// boolean is used in combination with the Eccentricity ivar.
	/// </summary>
	public virtual int GetNormalWarping()
	{
		return vtkGaussianSplatter_GetNormalWarping_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetNullValue_18(HandleRef pThis);

	/// <summary>
	/// Set the Null value for output points not receiving a contribution from the
	/// input points. (This is the initial value of the voxel samples.)
	/// </summary>
	public virtual double GetNullValue()
	{
		return vtkGaussianSplatter_GetNullValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGaussianSplatter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGaussianSplatter_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGaussianSplatter_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGaussianSplatter_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetRadius_21(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of propagation of the splat. This value is expressed
	/// as a percentage of the length of the longest side of the sampling
	/// volume. Smaller numbers greatly reduce execution time.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkGaussianSplatter_GetRadius_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetRadiusMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of propagation of the splat. This value is expressed
	/// as a percentage of the length of the longest side of the sampling
	/// volume. Smaller numbers greatly reduce execution time.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkGaussianSplatter_GetRadiusMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetRadiusMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of propagation of the splat. This value is expressed
	/// as a percentage of the length of the longest side of the sampling
	/// volume. Smaller numbers greatly reduce execution time.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkGaussianSplatter_GetRadiusMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianSplatter_GetSampleDimensions_24(HandleRef pThis);

	/// <summary>
	/// Set / get the dimensions of the sampling structured point set. Higher
	/// values produce better results but are much slower.
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkGaussianSplatter_GetSampleDimensions_24(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_GetSampleDimensions_25(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the dimensions of the sampling structured point set. Higher
	/// values produce better results but are much slower.
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkGaussianSplatter_GetSampleDimensions_25(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianSplatter_GetScalarWarping_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off the scaling of splats by scalar value.
	/// </summary>
	public virtual int GetScalarWarping()
	{
		return vtkGaussianSplatter_GetScalarWarping_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetScaleFactor_27(HandleRef pThis);

	/// <summary>
	/// Multiply Gaussian splat distribution by this value. If ScalarWarping
	/// is on, then the Scalar value will be multiplied by the ScaleFactor
	/// times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkGaussianSplatter_GetScaleFactor_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetScaleFactorMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Multiply Gaussian splat distribution by this value. If ScalarWarping
	/// is on, then the Scalar value will be multiplied by the ScaleFactor
	/// times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactorMaxValue()
	{
		return vtkGaussianSplatter_GetScaleFactorMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_GetScaleFactorMinValue_29(HandleRef pThis);

	/// <summary>
	/// Multiply Gaussian splat distribution by this value. If ScalarWarping
	/// is on, then the Scalar value will be multiplied by the ScaleFactor
	/// times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactorMinValue()
	{
		return vtkGaussianSplatter_GetScaleFactorMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianSplatter_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGaussianSplatter_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianSplatter_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGaussianSplatter_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianSplatter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGaussianSplatter NewInstance()
	{
		vtkGaussianSplatter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGaussianSplatter_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_NormalWarpingOff_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of elliptical splats. If normal warping is
	/// on, then the input normals affect the distribution of the splat. This
	/// boolean is used in combination with the Eccentricity ivar.
	/// </summary>
	public virtual void NormalWarpingOff()
	{
		vtkGaussianSplatter_NormalWarpingOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_NormalWarpingOn_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of elliptical splats. If normal warping is
	/// on, then the input normals affect the distribution of the splat. This
	/// boolean is used in combination with the Eccentricity ivar.
	/// </summary>
	public virtual void NormalWarpingOn()
	{
		vtkGaussianSplatter_NormalWarpingOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianSplatter_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGaussianSplatter SafeDownCast(vtkObjectBase o)
	{
		vtkGaussianSplatter vtkGaussianSplatter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGaussianSplatter_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGaussianSplatter2 = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGaussianSplatter2.Register(null);
			}
		}
		return vtkGaussianSplatter2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianSplatter_SamplePoint_37(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Provide access to templated helper class. Note that SamplePoint() method
	/// is public here because some compilers don't handle friend functions
	/// properly.
	/// </summary>
	public double SamplePoint(IntPtr x)
	{
		return vtkGaussianSplatter_SamplePoint_37(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_ScalarWarpingOff_38(HandleRef pThis);

	/// <summary>
	/// Turn on/off the scaling of splats by scalar value.
	/// </summary>
	public virtual void ScalarWarpingOff()
	{
		vtkGaussianSplatter_ScalarWarpingOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_ScalarWarpingOn_39(HandleRef pThis);

	/// <summary>
	/// Turn on/off the scaling of splats by scalar value.
	/// </summary>
	public virtual void ScalarWarpingOn()
	{
		vtkGaussianSplatter_ScalarWarpingOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetAccumulationMode_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats are overlapped. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min
	/// mode acts like a set intersection, and the sum is just weird.
	/// </summary>
	public virtual void SetAccumulationMode(int _arg)
	{
		vtkGaussianSplatter_SetAccumulationMode_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetAccumulationModeToMax_41(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats are overlapped. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min
	/// mode acts like a set intersection, and the sum is just weird.
	/// </summary>
	public void SetAccumulationModeToMax()
	{
		vtkGaussianSplatter_SetAccumulationModeToMax_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetAccumulationModeToMin_42(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats are overlapped. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min
	/// mode acts like a set intersection, and the sum is just weird.
	/// </summary>
	public void SetAccumulationModeToMin()
	{
		vtkGaussianSplatter_SetAccumulationModeToMin_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetAccumulationModeToSum_43(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats are overlapped. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min
	/// mode acts like a set intersection, and the sum is just weird.
	/// </summary>
	public void SetAccumulationModeToSum()
	{
		vtkGaussianSplatter_SetAccumulationModeToSum_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetCapValue_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the cap value to use. (This instance variable only has effect
	/// if the ivar Capping is on.)
	/// </summary>
	public virtual void SetCapValue(double _arg)
	{
		vtkGaussianSplatter_SetCapValue_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetCapping_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the capping of the outer boundary of the volume
	/// to a specified cap value. This can be used to close surfaces
	/// (after iso-surfacing) and create other effects.
	/// </summary>
	public virtual void SetCapping(int _arg)
	{
		vtkGaussianSplatter_SetCapping_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetEccentricity_46(HandleRef pThis, double _arg);

	/// <summary>
	/// Control the shape of elliptical splatting. Eccentricity is the ratio
	/// of the major axis (aligned along normal) to the minor (axes) aligned
	/// along other two axes. So Eccentricity &gt; 1 creates needles with the
	/// long axis in the direction of the normal; Eccentricity&lt;1 creates
	/// pancakes perpendicular to the normal vector.
	/// </summary>
	public virtual void SetEccentricity(double _arg)
	{
		vtkGaussianSplatter_SetEccentricity_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetExponentFactor_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the sharpness of decay of the splats. This is the
	/// exponent constant in the Gaussian equation. Normally this is
	/// a negative value.
	/// </summary>
	public virtual void SetExponentFactor(double _arg)
	{
		vtkGaussianSplatter_SetExponentFactor_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetModelBounds_48(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkGaussianSplatter_SetModelBounds_48(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetModelBounds_49(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(IntPtr _arg)
	{
		vtkGaussianSplatter_SetModelBounds_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetNormalWarping_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the generation of elliptical splats. If normal warping is
	/// on, then the input normals affect the distribution of the splat. This
	/// boolean is used in combination with the Eccentricity ivar.
	/// </summary>
	public virtual void SetNormalWarping(int _arg)
	{
		vtkGaussianSplatter_SetNormalWarping_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetNullValue_51(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the Null value for output points not receiving a contribution from the
	/// input points. (This is the initial value of the voxel samples.)
	/// </summary>
	public virtual void SetNullValue(double _arg)
	{
		vtkGaussianSplatter_SetNullValue_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetRadius_52(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the radius of propagation of the splat. This value is expressed
	/// as a percentage of the length of the longest side of the sampling
	/// volume. Smaller numbers greatly reduce execution time.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkGaussianSplatter_SetRadius_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetSampleDimensions_53(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set / get the dimensions of the sampling structured point set. Higher
	/// values produce better results but are much slower.
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkGaussianSplatter_SetSampleDimensions_53(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetSampleDimensions_54(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set / get the dimensions of the sampling structured point set. Higher
	/// values produce better results but are much slower.
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkGaussianSplatter_SetSampleDimensions_54(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetScalar_55(HandleRef pThis, long idx, double dist2, IntPtr sPtr);

	/// <summary>
	/// Provide access to templated helper class. Note that SamplePoint() method
	/// is public here because some compilers don't handle friend functions
	/// properly.
	/// </summary>
	public void SetScalar(long idx, double dist2, IntPtr sPtr)
	{
		vtkGaussianSplatter_SetScalar_55(GetCppThis(), idx, dist2, sPtr);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetScalarWarping_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the scaling of splats by scalar value.
	/// </summary>
	public virtual void SetScalarWarping(int _arg)
	{
		vtkGaussianSplatter_SetScalarWarping_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianSplatter_SetScaleFactor_57(HandleRef pThis, double _arg);

	/// <summary>
	/// Multiply Gaussian splat distribution by this value. If ScalarWarping
	/// is on, then the Scalar value will be multiplied by the ScaleFactor
	/// times the Gaussian function.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkGaussianSplatter_SetScaleFactor_57(GetCppThis(), _arg);
	}
}
