using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCheckerboardSplatter
/// </summary>
/// <remarks>
///    splat points into a volume with an elliptical, Gaussian distribution
///
/// vtkCheckerboardSplatter is a filter that injects input points into a
/// structured points (volume) dataset using a multithreaded 8-way
/// checkerboard approach. It produces a scalar field of a specified type. As
/// each point is injected, it "splats" or distributes values to nearby
/// voxels. Data is distributed using an elliptical, Gaussian distribution
/// function. The distribution function is modified using scalar values
/// (expands distribution) or normals (creates ellipsoidal distribution rather
/// than spherical). This algorithm is designed for scalability through
/// multithreading.
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
/// If point normals are present (and NormalWarping is on), then the splat
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
/// This class makes use of vtkSMPTools to implement a parallel, shared-memory
/// implementation. Hence performance will be significantly improved if VTK is
/// built with VTK_SMP_IMPLEMENTATION_TYPE set to something other than
/// "Sequential" (typically TBB). For example, on a standard laptop with four
/// threads it is common to see a &gt;10x speedup as compared to the serial
/// version of vtkGaussianSplatter.
///
/// In summary, the algorithm operates by dividing the volume into a 3D
/// checkerboard, where the squares of the checkerboard overlay voxels in the
/// volume. The checkerboard overlay is designed as a function of the splat
/// footprint, so that when splatting occurs in a group (or color) of
/// checkerboard squares, the splat operation will not cause write contention
/// as the splatting proceeds in parallel. There are eight colors in this
/// checkerboard (like an octree) and parallel splatting occurs simultaneously
/// in one of the eight colors (e.g., octants). A single splat operation
/// (across the given 3D footprint) may also be parallelized if the splat is
/// large enough.
///
/// @warning
/// The input to this filter is of type vtkPointSet. Currently only real types
/// (e.g., float, double) are supported as input, but this could easily be
/// extended to other types. The output type is limited to real types as well.
///
/// @warning
/// Some voxels may never receive a contribution during the splatting process.
/// The final value of these points can be specified with the "NullValue"
/// instance variable. Note that NullValue is also the initial value of the
/// output voxel values and will affect the accumulation process.
///
/// @warning
/// While this class is very similar to vtkGaussianSplatter, it does produce
/// slightly different output in most cases (due to the way the footprint is
/// computed).
///
/// </remarks>
/// <seealso>
///
/// vtkShepardMethod vtkGaussianSplatter
/// </seealso>
public class vtkCheckerboardSplatter : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCheckerboardSplatter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCheckerboardSplatter()
	{
		MRClassNameKey = "class vtkCheckerboardSplatter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCheckerboardSplatter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCheckerboardSplatter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardSplatter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with dimensions=(50,50,50); automatic computation of
	/// bounds; a Footprint of 2; a Radius of 0; an exponent factor of -5; and normal and
	/// scalar warping enabled; and Capping enabled.
	/// </summary>
	public new static vtkCheckerboardSplatter New()
	{
		vtkCheckerboardSplatter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardSplatter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCheckerboardSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with dimensions=(50,50,50); automatic computation of
	/// bounds; a Footprint of 2; a Radius of 0; an exponent factor of -5; and normal and
	/// scalar warping enabled; and Capping enabled.
	/// </summary>
	public vtkCheckerboardSplatter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCheckerboardSplatter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCheckerboardSplatter_CappingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the capping of the outer boundary of the volume
	/// to a specified cap value. This can be used to close surfaces
	/// (after iso-surfacing) and create other effects.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkCheckerboardSplatter_CappingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_CappingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the capping of the outer boundary of the volume
	/// to a specified cap value. This can be used to close surfaces
	/// (after iso-surfacing) and create other effects.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkCheckerboardSplatter_CappingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_ComputeModelBounds_03(HandleRef pThis, HandleRef input, HandleRef output, HandleRef outInfo);

	/// <summary>
	/// Compute the size of the sample bounding box automatically from the
	/// input data. This is an internal helper function.
	/// </summary>
	public void ComputeModelBounds(vtkDataSet input, vtkImageData output, vtkInformation outInfo)
	{
		vtkCheckerboardSplatter_ComputeModelBounds_03(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), outInfo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetAccumulationMode_04(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats overlap one another. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min mode
	/// acts like a set intersection, and the sum is just weird (and can
	/// potentially cause accumulation overflow in extreme cases). Note that the
	/// NullValue must be set consistent with the accumulation operation.
	/// </summary>
	public virtual int GetAccumulationMode()
	{
		return vtkCheckerboardSplatter_GetAccumulationMode_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardSplatter_GetAccumulationModeAsString_05(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats overlap one another. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min mode
	/// acts like a set intersection, and the sum is just weird (and can
	/// potentially cause accumulation overflow in extreme cases). Note that the
	/// NullValue must be set consistent with the accumulation operation.
	/// </summary>
	public string GetAccumulationModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkCheckerboardSplatter_GetAccumulationModeAsString_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetAccumulationModeMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats overlap one another. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min mode
	/// acts like a set intersection, and the sum is just weird (and can
	/// potentially cause accumulation overflow in extreme cases). Note that the
	/// NullValue must be set consistent with the accumulation operation.
	/// </summary>
	public virtual int GetAccumulationModeMaxValue()
	{
		return vtkCheckerboardSplatter_GetAccumulationModeMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetAccumulationModeMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats overlap one another. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min mode
	/// acts like a set intersection, and the sum is just weird (and can
	/// potentially cause accumulation overflow in extreme cases). Note that the
	/// NullValue must be set consistent with the accumulation operation.
	/// </summary>
	public virtual int GetAccumulationModeMinValue()
	{
		return vtkCheckerboardSplatter_GetAccumulationModeMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetCapValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the cap value to use. (This instance variable only has effect
	/// if the ivar Capping is on.)
	/// </summary>
	public virtual double GetCapValue()
	{
		return vtkCheckerboardSplatter_GetCapValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetCapping_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the capping of the outer boundary of the volume
	/// to a specified cap value. This can be used to close surfaces
	/// (after iso-surfacing) and create other effects.
	/// </summary>
	public virtual int GetCapping()
	{
		return vtkCheckerboardSplatter_GetCapping_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetEccentricity_10(HandleRef pThis);

	/// <summary>
	/// Control the shape of elliptical splatting. Eccentricity is the ratio
	/// of the major axis (aligned along normal) to the minor (axes) aligned
	/// along other two axes. So Eccentricity &gt; 1 creates needles with the
	/// long axis in the direction of the normal; Eccentricity&lt;1 creates
	/// pancakes perpendicular to the normal vector.
	/// </summary>
	public virtual double GetEccentricity()
	{
		return vtkCheckerboardSplatter_GetEccentricity_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetEccentricityMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Control the shape of elliptical splatting. Eccentricity is the ratio
	/// of the major axis (aligned along normal) to the minor (axes) aligned
	/// along other two axes. So Eccentricity &gt; 1 creates needles with the
	/// long axis in the direction of the normal; Eccentricity&lt;1 creates
	/// pancakes perpendicular to the normal vector.
	/// </summary>
	public virtual double GetEccentricityMaxValue()
	{
		return vtkCheckerboardSplatter_GetEccentricityMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetEccentricityMinValue_12(HandleRef pThis);

	/// <summary>
	/// Control the shape of elliptical splatting. Eccentricity is the ratio
	/// of the major axis (aligned along normal) to the minor (axes) aligned
	/// along other two axes. So Eccentricity &gt; 1 creates needles with the
	/// long axis in the direction of the normal; Eccentricity&lt;1 creates
	/// pancakes perpendicular to the normal vector.
	/// </summary>
	public virtual double GetEccentricityMinValue()
	{
		return vtkCheckerboardSplatter_GetEccentricityMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetExponentFactor_13(HandleRef pThis);

	/// <summary>
	/// Set / get the sharpness of decay of the splats. This is the exponent
	/// constant in the Gaussian equation described above. Normally this is a
	/// negative value.
	/// </summary>
	public virtual double GetExponentFactor()
	{
		return vtkCheckerboardSplatter_GetExponentFactor_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetFootprint_14(HandleRef pThis);

	/// <summary>
	/// Control the footprint size of the splat in terms of propagation across a
	/// voxel neighborhood. The Footprint value simply indicates the number of
	/// neighboring voxels in the i-j-k directions to extend the splat. A value
	/// of zero means that only the voxel containing the splat point is
	/// affected. A value of one means the immediate neighbors touching the
	/// affected voxel are affected as well. Larger numbers increase the splat
	/// footprint and significantly increase processing time. Note that the
	/// footprint is always 3D rectangular.
	/// </summary>
	public virtual int GetFootprint()
	{
		return vtkCheckerboardSplatter_GetFootprint_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetFootprintMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Control the footprint size of the splat in terms of propagation across a
	/// voxel neighborhood. The Footprint value simply indicates the number of
	/// neighboring voxels in the i-j-k directions to extend the splat. A value
	/// of zero means that only the voxel containing the splat point is
	/// affected. A value of one means the immediate neighbors touching the
	/// affected voxel are affected as well. Larger numbers increase the splat
	/// footprint and significantly increase processing time. Note that the
	/// footprint is always 3D rectangular.
	/// </summary>
	public virtual int GetFootprintMaxValue()
	{
		return vtkCheckerboardSplatter_GetFootprintMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetFootprintMinValue_16(HandleRef pThis);

	/// <summary>
	/// Control the footprint size of the splat in terms of propagation across a
	/// voxel neighborhood. The Footprint value simply indicates the number of
	/// neighboring voxels in the i-j-k directions to extend the splat. A value
	/// of zero means that only the voxel containing the splat point is
	/// affected. A value of one means the immediate neighbors touching the
	/// affected voxel are affected as well. Larger numbers increase the splat
	/// footprint and significantly increase processing time. Note that the
	/// footprint is always 3D rectangular.
	/// </summary>
	public virtual int GetFootprintMinValue()
	{
		return vtkCheckerboardSplatter_GetFootprintMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetMaximumDimension_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum dimension of the checkerboard (i.e., the number of
	/// squares in any of the i, j, or k directions). This number also impacts
	/// the granularity of the parallel threading (since each checker square is
	/// processed separaely). Because of the internal addressing, the maximum
	/// dimension is limited to 255 (maximum value of an unsigned char).
	/// </summary>
	public virtual int GetMaximumDimension()
	{
		return vtkCheckerboardSplatter_GetMaximumDimension_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetMaximumDimensionMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum dimension of the checkerboard (i.e., the number of
	/// squares in any of the i, j, or k directions). This number also impacts
	/// the granularity of the parallel threading (since each checker square is
	/// processed separaely). Because of the internal addressing, the maximum
	/// dimension is limited to 255 (maximum value of an unsigned char).
	/// </summary>
	public virtual int GetMaximumDimensionMaxValue()
	{
		return vtkCheckerboardSplatter_GetMaximumDimensionMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetMaximumDimensionMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum dimension of the checkerboard (i.e., the number of
	/// squares in any of the i, j, or k directions). This number also impacts
	/// the granularity of the parallel threading (since each checker square is
	/// processed separaely). Because of the internal addressing, the maximum
	/// dimension is limited to 255 (maximum value of an unsigned char).
	/// </summary>
	public virtual int GetMaximumDimensionMinValue()
	{
		return vtkCheckerboardSplatter_GetMaximumDimensionMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardSplatter_GetModelBounds_20(HandleRef pThis);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkCheckerboardSplatter_GetModelBounds_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_GetModelBounds_21(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkCheckerboardSplatter_GetModelBounds_21(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetNormalWarping_22(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of elliptical splats. If normal warping is
	/// on, then the input normals affect the distribution of the splat. This
	/// boolean is used in combination with the Eccentricity ivar.
	/// </summary>
	public virtual int GetNormalWarping()
	{
		return vtkCheckerboardSplatter_GetNormalWarping_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetNullValue_23(HandleRef pThis);

	/// <summary>
	/// Set the Null value for output points not receiving a contribution from
	/// the input points. (This is the initial value of the voxel samples, by
	/// default it is set to zero.) Note that the value should be consistent
	/// with the output dataset type. The NullValue also provides the initial
	/// value on which the accumulations process operates.
	/// </summary>
	public virtual double GetNullValue()
	{
		return vtkCheckerboardSplatter_GetNullValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCheckerboardSplatter_GetNumberOfGenerationsFromBase_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCheckerboardSplatter_GetNumberOfGenerationsFromBase_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCheckerboardSplatter_GetNumberOfGenerationsFromBaseType_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCheckerboardSplatter_GetNumberOfGenerationsFromBaseType_25(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetOutputScalarType_26(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate. Only double
	/// and float types are supported currently due to precision requirements
	/// during accumulation. By default, float scalars are produced.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkCheckerboardSplatter_GetOutputScalarType_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetParallelSplatCrossover_27(HandleRef pThis);

	/// <summary>
	/// Set/get the crossover point expressed in footprint size where the
	/// splatting operation is parallelized (through vtkSMPTools). By default
	/// the parallel crossover point is for splat footprints of size two or
	/// greater (i.e., at footprint=2 then splat is 5x5x5 and parallel splatting
	/// occurs). This is really meant for experimental purposes.
	/// </summary>
	public virtual int GetParallelSplatCrossover()
	{
		return vtkCheckerboardSplatter_GetParallelSplatCrossover_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetParallelSplatCrossoverMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Set/get the crossover point expressed in footprint size where the
	/// splatting operation is parallelized (through vtkSMPTools). By default
	/// the parallel crossover point is for splat footprints of size two or
	/// greater (i.e., at footprint=2 then splat is 5x5x5 and parallel splatting
	/// occurs). This is really meant for experimental purposes.
	/// </summary>
	public virtual int GetParallelSplatCrossoverMaxValue()
	{
		return vtkCheckerboardSplatter_GetParallelSplatCrossoverMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetParallelSplatCrossoverMinValue_29(HandleRef pThis);

	/// <summary>
	/// Set/get the crossover point expressed in footprint size where the
	/// splatting operation is parallelized (through vtkSMPTools). By default
	/// the parallel crossover point is for splat footprints of size two or
	/// greater (i.e., at footprint=2 then splat is 5x5x5 and parallel splatting
	/// occurs). This is really meant for experimental purposes.
	/// </summary>
	public virtual int GetParallelSplatCrossoverMinValue()
	{
		return vtkCheckerboardSplatter_GetParallelSplatCrossoverMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetRadius_30(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable that controls the Gaussian exponential
	/// function (see equation above). If set to zero, it is automatically set
	/// to the radius of the circumsphere bounding a single voxel. (By default,
	/// the Radius is set to zero and is automatically computed.)
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkCheckerboardSplatter_GetRadius_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetRadiusMaxValue_31(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable that controls the Gaussian exponential
	/// function (see equation above). If set to zero, it is automatically set
	/// to the radius of the circumsphere bounding a single voxel. (By default,
	/// the Radius is set to zero and is automatically computed.)
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkCheckerboardSplatter_GetRadiusMaxValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetRadiusMinValue_32(HandleRef pThis);

	/// <summary>
	/// Set / get the radius variable that controls the Gaussian exponential
	/// function (see equation above). If set to zero, it is automatically set
	/// to the radius of the circumsphere bounding a single voxel. (By default,
	/// the Radius is set to zero and is automatically computed.)
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkCheckerboardSplatter_GetRadiusMinValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardSplatter_GetSampleDimensions_33(HandleRef pThis);

	/// <summary>
	/// Set / get the dimensions of the sampling structured point set. Higher
	/// values produce better results but may be much slower.
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkCheckerboardSplatter_GetSampleDimensions_33(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_GetSampleDimensions_34(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the dimensions of the sampling structured point set. Higher
	/// values produce better results but may be much slower.
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkCheckerboardSplatter_GetSampleDimensions_34(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_GetScalarWarping_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off the scaling of splats by scalar value.
	/// </summary>
	public virtual int GetScalarWarping()
	{
		return vtkCheckerboardSplatter_GetScalarWarping_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetScaleFactor_36(HandleRef pThis);

	/// <summary>
	/// Multiply Gaussian splat distribution by this value. If ScalarWarping
	/// is on, then the Scalar value will be multiplied by the ScaleFactor
	/// times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkCheckerboardSplatter_GetScaleFactor_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetScaleFactorMaxValue_37(HandleRef pThis);

	/// <summary>
	/// Multiply Gaussian splat distribution by this value. If ScalarWarping
	/// is on, then the Scalar value will be multiplied by the ScaleFactor
	/// times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactorMaxValue()
	{
		return vtkCheckerboardSplatter_GetScaleFactorMaxValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCheckerboardSplatter_GetScaleFactorMinValue_38(HandleRef pThis);

	/// <summary>
	/// Multiply Gaussian splat distribution by this value. If ScalarWarping
	/// is on, then the Scalar value will be multiplied by the ScaleFactor
	/// times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactorMinValue()
	{
		return vtkCheckerboardSplatter_GetScaleFactorMinValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_IsA_39(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCheckerboardSplatter_IsA_39(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardSplatter_IsTypeOf_40(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCheckerboardSplatter_IsTypeOf_40(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardSplatter_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCheckerboardSplatter NewInstance()
	{
		vtkCheckerboardSplatter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardSplatter_NewInstance_42(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCheckerboardSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_NormalWarpingOff_43(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of elliptical splats. If normal warping is
	/// on, then the input normals affect the distribution of the splat. This
	/// boolean is used in combination with the Eccentricity ivar.
	/// </summary>
	public virtual void NormalWarpingOff()
	{
		vtkCheckerboardSplatter_NormalWarpingOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_NormalWarpingOn_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of elliptical splats. If normal warping is
	/// on, then the input normals affect the distribution of the splat. This
	/// boolean is used in combination with the Eccentricity ivar.
	/// </summary>
	public virtual void NormalWarpingOn()
	{
		vtkCheckerboardSplatter_NormalWarpingOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardSplatter_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCheckerboardSplatter SafeDownCast(vtkObjectBase o)
	{
		vtkCheckerboardSplatter vtkCheckerboardSplatter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardSplatter_SafeDownCast_45(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCheckerboardSplatter2 = (vtkCheckerboardSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCheckerboardSplatter2.Register(null);
			}
		}
		return vtkCheckerboardSplatter2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_ScalarWarpingOff_46(HandleRef pThis);

	/// <summary>
	/// Turn on/off the scaling of splats by scalar value.
	/// </summary>
	public virtual void ScalarWarpingOff()
	{
		vtkCheckerboardSplatter_ScalarWarpingOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_ScalarWarpingOn_47(HandleRef pThis);

	/// <summary>
	/// Turn on/off the scaling of splats by scalar value.
	/// </summary>
	public virtual void ScalarWarpingOn()
	{
		vtkCheckerboardSplatter_ScalarWarpingOn_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetAccumulationMode_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats overlap one another. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min mode
	/// acts like a set intersection, and the sum is just weird (and can
	/// potentially cause accumulation overflow in extreme cases). Note that the
	/// NullValue must be set consistent with the accumulation operation.
	/// </summary>
	public virtual void SetAccumulationMode(int _arg)
	{
		vtkCheckerboardSplatter_SetAccumulationMode_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetAccumulationModeToMax_49(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats overlap one another. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min mode
	/// acts like a set intersection, and the sum is just weird (and can
	/// potentially cause accumulation overflow in extreme cases). Note that the
	/// NullValue must be set consistent with the accumulation operation.
	/// </summary>
	public void SetAccumulationModeToMax()
	{
		vtkCheckerboardSplatter_SetAccumulationModeToMax_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetAccumulationModeToMin_50(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats overlap one another. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min mode
	/// acts like a set intersection, and the sum is just weird (and can
	/// potentially cause accumulation overflow in extreme cases). Note that the
	/// NullValue must be set consistent with the accumulation operation.
	/// </summary>
	public void SetAccumulationModeToMin()
	{
		vtkCheckerboardSplatter_SetAccumulationModeToMin_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetAccumulationModeToSum_51(HandleRef pThis);

	/// <summary>
	/// Specify the scalar accumulation mode. This mode expresses how scalar
	/// values are combined when splats overlap one another. The Max mode acts
	/// like a set union operation and is the most commonly used; the Min mode
	/// acts like a set intersection, and the sum is just weird (and can
	/// potentially cause accumulation overflow in extreme cases). Note that the
	/// NullValue must be set consistent with the accumulation operation.
	/// </summary>
	public void SetAccumulationModeToSum()
	{
		vtkCheckerboardSplatter_SetAccumulationModeToSum_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetCapValue_52(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the cap value to use. (This instance variable only has effect
	/// if the ivar Capping is on.)
	/// </summary>
	public virtual void SetCapValue(double _arg)
	{
		vtkCheckerboardSplatter_SetCapValue_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetCapping_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the capping of the outer boundary of the volume
	/// to a specified cap value. This can be used to close surfaces
	/// (after iso-surfacing) and create other effects.
	/// </summary>
	public virtual void SetCapping(int _arg)
	{
		vtkCheckerboardSplatter_SetCapping_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetEccentricity_54(HandleRef pThis, double _arg);

	/// <summary>
	/// Control the shape of elliptical splatting. Eccentricity is the ratio
	/// of the major axis (aligned along normal) to the minor (axes) aligned
	/// along other two axes. So Eccentricity &gt; 1 creates needles with the
	/// long axis in the direction of the normal; Eccentricity&lt;1 creates
	/// pancakes perpendicular to the normal vector.
	/// </summary>
	public virtual void SetEccentricity(double _arg)
	{
		vtkCheckerboardSplatter_SetEccentricity_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetExponentFactor_55(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the sharpness of decay of the splats. This is the exponent
	/// constant in the Gaussian equation described above. Normally this is a
	/// negative value.
	/// </summary>
	public virtual void SetExponentFactor(double _arg)
	{
		vtkCheckerboardSplatter_SetExponentFactor_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetFootprint_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the footprint size of the splat in terms of propagation across a
	/// voxel neighborhood. The Footprint value simply indicates the number of
	/// neighboring voxels in the i-j-k directions to extend the splat. A value
	/// of zero means that only the voxel containing the splat point is
	/// affected. A value of one means the immediate neighbors touching the
	/// affected voxel are affected as well. Larger numbers increase the splat
	/// footprint and significantly increase processing time. Note that the
	/// footprint is always 3D rectangular.
	/// </summary>
	public virtual void SetFootprint(int _arg)
	{
		vtkCheckerboardSplatter_SetFootprint_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetMaximumDimension_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum dimension of the checkerboard (i.e., the number of
	/// squares in any of the i, j, or k directions). This number also impacts
	/// the granularity of the parallel threading (since each checker square is
	/// processed separaely). Because of the internal addressing, the maximum
	/// dimension is limited to 255 (maximum value of an unsigned char).
	/// </summary>
	public virtual void SetMaximumDimension(int _arg)
	{
		vtkCheckerboardSplatter_SetMaximumDimension_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetModelBounds_58(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkCheckerboardSplatter_SetModelBounds_58(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetModelBounds_59(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(IntPtr _arg)
	{
		vtkCheckerboardSplatter_SetModelBounds_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetNormalWarping_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the generation of elliptical splats. If normal warping is
	/// on, then the input normals affect the distribution of the splat. This
	/// boolean is used in combination with the Eccentricity ivar.
	/// </summary>
	public virtual void SetNormalWarping(int _arg)
	{
		vtkCheckerboardSplatter_SetNormalWarping_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetNullValue_61(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the Null value for output points not receiving a contribution from
	/// the input points. (This is the initial value of the voxel samples, by
	/// default it is set to zero.) Note that the value should be consistent
	/// with the output dataset type. The NullValue also provides the initial
	/// value on which the accumulations process operates.
	/// </summary>
	public virtual void SetNullValue(double _arg)
	{
		vtkCheckerboardSplatter_SetNullValue_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetOutputScalarType_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Set what type of scalar data this source should generate. Only double
	/// and float types are supported currently due to precision requirements
	/// during accumulation. By default, float scalars are produced.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkCheckerboardSplatter_SetOutputScalarType_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetOutputScalarTypeToDouble_63(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate. Only double
	/// and float types are supported currently due to precision requirements
	/// during accumulation. By default, float scalars are produced.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkCheckerboardSplatter_SetOutputScalarTypeToDouble_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetOutputScalarTypeToFloat_64(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate. Only double
	/// and float types are supported currently due to precision requirements
	/// during accumulation. By default, float scalars are produced.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkCheckerboardSplatter_SetOutputScalarTypeToFloat_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetParallelSplatCrossover_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the crossover point expressed in footprint size where the
	/// splatting operation is parallelized (through vtkSMPTools). By default
	/// the parallel crossover point is for splat footprints of size two or
	/// greater (i.e., at footprint=2 then splat is 5x5x5 and parallel splatting
	/// occurs). This is really meant for experimental purposes.
	/// </summary>
	public virtual void SetParallelSplatCrossover(int _arg)
	{
		vtkCheckerboardSplatter_SetParallelSplatCrossover_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetRadius_66(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the radius variable that controls the Gaussian exponential
	/// function (see equation above). If set to zero, it is automatically set
	/// to the radius of the circumsphere bounding a single voxel. (By default,
	/// the Radius is set to zero and is automatically computed.)
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkCheckerboardSplatter_SetRadius_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetSampleDimensions_67(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set / get the dimensions of the sampling structured point set. Higher
	/// values produce better results but may be much slower.
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkCheckerboardSplatter_SetSampleDimensions_67(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetSampleDimensions_68(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set / get the dimensions of the sampling structured point set. Higher
	/// values produce better results but may be much slower.
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkCheckerboardSplatter_SetSampleDimensions_68(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetScalarWarping_69(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the scaling of splats by scalar value.
	/// </summary>
	public virtual void SetScalarWarping(int _arg)
	{
		vtkCheckerboardSplatter_SetScalarWarping_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardSplatter_SetScaleFactor_70(HandleRef pThis, double _arg);

	/// <summary>
	/// Multiply Gaussian splat distribution by this value. If ScalarWarping
	/// is on, then the Scalar value will be multiplied by the ScaleFactor
	/// times the Gaussian function.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkCheckerboardSplatter_SetScaleFactor_70(GetCppThis(), _arg);
	}
}
