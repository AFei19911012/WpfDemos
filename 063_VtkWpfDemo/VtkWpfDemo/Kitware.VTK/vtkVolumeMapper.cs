using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolumeMapper
/// </summary>
/// <remarks>
///    Abstract class for a volume mapper
///
///
/// vtkVolumeMapper is the abstract definition of a volume mapper for regular
/// rectilinear data (vtkImageData). Several basic types of volume mappers
/// are supported.
/// </remarks>
public abstract class vtkVolumeMapper : vtkAbstractVolumeMapper
{
	/// <summary>
	/// Blend modes.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively,  along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsoSurfaceValues()
	/// </summary>
	public enum BlendModes
	{
		/// <summary>enum member</summary>
		ADDITIVE_BLEND = 4,
		/// <summary>enum member</summary>
		AVERAGE_INTENSITY_BLEND = 3,
		/// <summary>enum member</summary>
		COMPOSITE_BLEND = 0,
		/// <summary>enum member</summary>
		ISOSURFACE_BLEND = 5,
		/// <summary>enum member</summary>
		MAXIMUM_INTENSITY_BLEND = 1,
		/// <summary>enum member</summary>
		MINIMUM_INTENSITY_BLEND = 2,
		/// <summary>enum member</summary>
		SLICE_BLEND = 6
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolumeMapper()
	{
		MRClassNameKey = "class vtkVolumeMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_ComputeNormalFromOpacityOff_01(HandleRef pThis);

	/// <summary>
	/// If enabled, the volume(s) whose shading is enabled will use the gradient
	/// of opacity instead of the scalar gradient to estimate the surface's normal
	/// when applying the shading model. The opacity considered for the gradient
	/// is then the scalars converted to opacity by the transfer function(s).
	/// For now it is only supported in vtkGPUVolumeRayCastMapper.
	/// In vtkSmartVolumeMapper and in vtkMultiBlockVolumeMapper, this parameter
	/// is used when the GPU mapper is effectively used.
	/// Note that enabling it might affect performances, especially when
	/// using a 2D TF or a gradient opacity. It is disabled by default.
	/// </summary>
	public virtual void ComputeNormalFromOpacityOff()
	{
		vtkVolumeMapper_ComputeNormalFromOpacityOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_ComputeNormalFromOpacityOn_02(HandleRef pThis);

	/// <summary>
	/// If enabled, the volume(s) whose shading is enabled will use the gradient
	/// of opacity instead of the scalar gradient to estimate the surface's normal
	/// when applying the shading model. The opacity considered for the gradient
	/// is then the scalars converted to opacity by the transfer function(s).
	/// For now it is only supported in vtkGPUVolumeRayCastMapper.
	/// In vtkSmartVolumeMapper and in vtkMultiBlockVolumeMapper, this parameter
	/// is used when the GPU mapper is effectively used.
	/// Note that enabling it might affect performances, especially when
	/// using a 2D TF or a gradient opacity. It is disabled by default.
	/// </summary>
	public virtual void ComputeNormalFromOpacityOn()
	{
		vtkVolumeMapper_ComputeNormalFromOpacityOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_CroppingOff_03(HandleRef pThis);

	/// <summary>
	/// Turn On/Off orthogonal cropping. (Clipping planes are
	/// perpendicular to the coordinate axes.)
	/// </summary>
	public virtual void CroppingOff()
	{
		vtkVolumeMapper_CroppingOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_CroppingOn_04(HandleRef pThis);

	/// <summary>
	/// Turn On/Off orthogonal cropping. (Clipping planes are
	/// perpendicular to the coordinate axes.)
	/// </summary>
	public virtual void CroppingOn()
	{
		vtkVolumeMapper_CroppingOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeMapper_GetAverageIPScalarRange_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the scalar range to be considered for average intensity projection
	/// blend mode. Only scalar values between this range will be averaged during
	/// ray casting. This can be useful when volume rendering CT datasets where the
	/// areas occupied by air would deviate the final rendering. By default, the
	/// range is set to (VTK_FLOAT_MIN, VTK_FLOAT_MAX).
	/// \sa SetBlendModeToAverageIntensity()
	/// </summary>
	public virtual double[] GetAverageIPScalarRange()
	{
		IntPtr intPtr = vtkVolumeMapper_GetAverageIPScalarRange_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_GetAverageIPScalarRange_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the scalar range to be considered for average intensity projection
	/// blend mode. Only scalar values between this range will be averaged during
	/// ray casting. This can be useful when volume rendering CT datasets where the
	/// areas occupied by air would deviate the final rendering. By default, the
	/// range is set to (VTK_FLOAT_MIN, VTK_FLOAT_MAX).
	/// \sa SetBlendModeToAverageIntensity()
	/// </summary>
	public virtual void GetAverageIPScalarRange(IntPtr data)
	{
		vtkVolumeMapper_GetAverageIPScalarRange_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_GetBlendMode_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public virtual int GetBlendMode()
	{
		return vtkVolumeMapper_GetBlendMode_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVolumeMapper_GetComputeNormalFromOpacity_08(HandleRef pThis);

	/// <summary>
	/// If enabled, the volume(s) whose shading is enabled will use the gradient
	/// of opacity instead of the scalar gradient to estimate the surface's normal
	/// when applying the shading model. The opacity considered for the gradient
	/// is then the scalars converted to opacity by the transfer function(s).
	/// For now it is only supported in vtkGPUVolumeRayCastMapper.
	/// In vtkSmartVolumeMapper and in vtkMultiBlockVolumeMapper, this parameter
	/// is used when the GPU mapper is effectively used.
	/// Note that enabling it might affect performances, especially when
	/// using a 2D TF or a gradient opacity. It is disabled by default.
	/// </summary>
	public virtual bool GetComputeNormalFromOpacity()
	{
		return (vtkVolumeMapper_GetComputeNormalFromOpacity_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_GetCropping_09(HandleRef pThis);

	/// <summary>
	/// Turn On/Off orthogonal cropping. (Clipping planes are
	/// perpendicular to the coordinate axes.)
	/// </summary>
	public virtual int GetCropping()
	{
		return vtkVolumeMapper_GetCropping_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_GetCroppingMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Turn On/Off orthogonal cropping. (Clipping planes are
	/// perpendicular to the coordinate axes.)
	/// </summary>
	public virtual int GetCroppingMaxValue()
	{
		return vtkVolumeMapper_GetCroppingMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_GetCroppingMinValue_11(HandleRef pThis);

	/// <summary>
	/// Turn On/Off orthogonal cropping. (Clipping planes are
	/// perpendicular to the coordinate axes.)
	/// </summary>
	public virtual int GetCroppingMinValue()
	{
		return vtkVolumeMapper_GetCroppingMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_GetCroppingRegionFlags_12(HandleRef pThis);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public virtual int GetCroppingRegionFlags()
	{
		return vtkVolumeMapper_GetCroppingRegionFlags_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_GetCroppingRegionFlagsMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public virtual int GetCroppingRegionFlagsMaxValue()
	{
		return vtkVolumeMapper_GetCroppingRegionFlagsMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_GetCroppingRegionFlagsMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public virtual int GetCroppingRegionFlagsMinValue()
	{
		return vtkVolumeMapper_GetCroppingRegionFlagsMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeMapper_GetCroppingRegionPlanes_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cropping Region Planes ( xmin, xmax, ymin, ymax, zmin, zmax )
	/// These planes are defined in volume coordinates - spacing and origin are
	/// considered.
	/// </summary>
	public virtual double[] GetCroppingRegionPlanes()
	{
		IntPtr intPtr = vtkVolumeMapper_GetCroppingRegionPlanes_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_GetCroppingRegionPlanes_16(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the Cropping Region Planes ( xmin, xmax, ymin, ymax, zmin, zmax )
	/// These planes are defined in volume coordinates - spacing and origin are
	/// considered.
	/// </summary>
	public virtual void GetCroppingRegionPlanes(IntPtr data)
	{
		vtkVolumeMapper_GetCroppingRegionPlanes_16(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeMapper_GetInput_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeMapper_GetInput_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeMapper_GetInput_18(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual vtkDataSet GetInput(int port)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeMapper_GetInput_18(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeMapper_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolumeMapper_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeMapper_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolumeMapper_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeMapper_GetVoxelCroppingRegionPlanes_21(HandleRef pThis);

	/// <summary>
	/// Get the cropping region planes in voxels. Only valid during the
	/// rendering process
	/// </summary>
	public virtual double[] GetVoxelCroppingRegionPlanes()
	{
		IntPtr intPtr = vtkVolumeMapper_GetVoxelCroppingRegionPlanes_21(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_GetVoxelCroppingRegionPlanes_22(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get the cropping region planes in voxels. Only valid during the
	/// rendering process
	/// </summary>
	public virtual void GetVoxelCroppingRegionPlanes(IntPtr data)
	{
		vtkVolumeMapper_GetVoxelCroppingRegionPlanes_22(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolumeMapper_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeMapper_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolumeMapper_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeMapper_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolumeMapper NewInstance()
	{
		vtkVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeMapper_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkVolumeMapper_ReleaseGraphicsResources_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_Render_27(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public override void Render(vtkRenderer ren, vtkVolume vol)
	{
		vtkVolumeMapper_Render_27(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeMapper_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeMapper SafeDownCast(vtkObjectBase o)
	{
		vtkVolumeMapper vtkVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeMapper_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeMapper2 = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeMapper2.Register(null);
			}
		}
		return vtkVolumeMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetAverageIPScalarRange_29(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set/Get the scalar range to be considered for average intensity projection
	/// blend mode. Only scalar values between this range will be averaged during
	/// ray casting. This can be useful when volume rendering CT datasets where the
	/// areas occupied by air would deviate the final rendering. By default, the
	/// range is set to (VTK_FLOAT_MIN, VTK_FLOAT_MAX).
	/// \sa SetBlendModeToAverageIntensity()
	/// </summary>
	public virtual void SetAverageIPScalarRange(double _arg1, double _arg2)
	{
		vtkVolumeMapper_SetAverageIPScalarRange_29(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetAverageIPScalarRange_30(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the scalar range to be considered for average intensity projection
	/// blend mode. Only scalar values between this range will be averaged during
	/// ray casting. This can be useful when volume rendering CT datasets where the
	/// areas occupied by air would deviate the final rendering. By default, the
	/// range is set to (VTK_FLOAT_MIN, VTK_FLOAT_MAX).
	/// \sa SetBlendModeToAverageIntensity()
	/// </summary>
	public void SetAverageIPScalarRange(IntPtr _arg)
	{
		vtkVolumeMapper_SetAverageIPScalarRange_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetBlendMode_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public virtual void SetBlendMode(int _arg)
	{
		vtkVolumeMapper_SetBlendMode_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetBlendModeToAdditive_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public void SetBlendModeToAdditive()
	{
		vtkVolumeMapper_SetBlendModeToAdditive_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetBlendModeToAverageIntensity_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public void SetBlendModeToAverageIntensity()
	{
		vtkVolumeMapper_SetBlendModeToAverageIntensity_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetBlendModeToComposite_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public void SetBlendModeToComposite()
	{
		vtkVolumeMapper_SetBlendModeToComposite_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetBlendModeToIsoSurface_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public void SetBlendModeToIsoSurface()
	{
		vtkVolumeMapper_SetBlendModeToIsoSurface_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetBlendModeToMaximumIntensity_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public void SetBlendModeToMaximumIntensity()
	{
		vtkVolumeMapper_SetBlendModeToMaximumIntensity_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetBlendModeToMinimumIntensity_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public void SetBlendModeToMinimumIntensity()
	{
		vtkVolumeMapper_SetBlendModeToMinimumIntensity_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetBlendModeToSlice_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the blend mode.
	/// The default mode is Composite where the scalar values are sampled through
	/// the volume and composited in a front-to-back scheme through alpha blending.
	/// The final color and opacity is determined using the color and opacity
	/// transfer functions.
	///
	/// Maximum and minimum intensity blend modes use the maximum and minimum
	/// scalar values, respectively, along the sampling ray. The final color and
	/// opacity is determined by passing the resultant value through the color and
	/// opacity transfer functions.
	///
	/// Additive blend mode accumulates scalar values by passing each value through
	/// the opacity transfer function and then adding up the product of the value
	/// and its opacity. In other words, the scalar values are scaled using the
	/// opacity transfer function and summed to derive the final color. Note that
	/// the resulting image is always grayscale i.e. aggregated values are not
	/// passed through the color transfer function. This is because the final
	/// value is a derived value and not a real data value along the sampling ray.
	///
	/// Average intensity blend mode works similar to the additive blend mode where
	/// the scalar values are multiplied by opacity calculated from the opacity
	/// transfer function and then added. The additional step here is to
	/// divide the sum by the number of samples taken through the volume.
	/// One can control the scalar range by setting the AverageIPScalarRange ivar
	/// to disregard scalar values, not in the range of interest, from the average
	/// computation.
	/// As is the case with the additive intensity projection, the final
	/// image will always be grayscale i.e. the aggregated values are not
	/// passed through the color transfer function. This is because the
	/// resultant value is a derived value and not a real data value along
	/// the sampling ray.
	///
	/// IsoSurface blend mode uses contour values defined by the user in order
	/// to display scalar values only when the ray crosses the contour. It supports
	/// opacity the same way composite blend mode does.
	///
	/// \note vtkVolumeMapper::AVERAGE_INTENSITY_BLEND and ISOSURFACE_BLEND are
	/// only supported by the vtkGPUVolumeRayCastMapper with the OpenGL2 backend.
	/// \sa SetAverageIPScalarRange()
	/// \sa GetIsosurfaceValues()
	/// </summary>
	public void SetBlendModeToSlice()
	{
		vtkVolumeMapper_SetBlendModeToSlice_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetComputeNormalFromOpacity_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// If enabled, the volume(s) whose shading is enabled will use the gradient
	/// of opacity instead of the scalar gradient to estimate the surface's normal
	/// when applying the shading model. The opacity considered for the gradient
	/// is then the scalars converted to opacity by the transfer function(s).
	/// For now it is only supported in vtkGPUVolumeRayCastMapper.
	/// In vtkSmartVolumeMapper and in vtkMultiBlockVolumeMapper, this parameter
	/// is used when the GPU mapper is effectively used.
	/// Note that enabling it might affect performances, especially when
	/// using a 2D TF or a gradient opacity. It is disabled by default.
	/// </summary>
	public virtual void SetComputeNormalFromOpacity(bool _arg)
	{
		vtkVolumeMapper_SetComputeNormalFromOpacity_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCropping_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn On/Off orthogonal cropping. (Clipping planes are
	/// perpendicular to the coordinate axes.)
	/// </summary>
	public virtual void SetCropping(int _arg)
	{
		vtkVolumeMapper_SetCropping_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCroppingRegionFlags_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public virtual void SetCroppingRegionFlags(int _arg)
	{
		vtkVolumeMapper_SetCroppingRegionFlags_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToCross_42(HandleRef pThis);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public void SetCroppingRegionFlagsToCross()
	{
		vtkVolumeMapper_SetCroppingRegionFlagsToCross_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToFence_43(HandleRef pThis);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public void SetCroppingRegionFlagsToFence()
	{
		vtkVolumeMapper_SetCroppingRegionFlagsToFence_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToInvertedCross_44(HandleRef pThis);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public void SetCroppingRegionFlagsToInvertedCross()
	{
		vtkVolumeMapper_SetCroppingRegionFlagsToInvertedCross_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToInvertedFence_45(HandleRef pThis);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public void SetCroppingRegionFlagsToInvertedFence()
	{
		vtkVolumeMapper_SetCroppingRegionFlagsToInvertedFence_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToSubVolume_46(HandleRef pThis);

	/// <summary>
	/// Set the flags for the cropping regions. The clipping planes divide the
	/// volume into 27 regions - there is one bit for each region. The regions
	/// start from the one containing voxel (0,0,0), moving along the x axis
	/// fastest, the y axis next, and the z axis slowest. These are represented
	/// from the lowest bit to bit number 27 in the integer containing the
	/// flags. There are several convenience functions to set some common
	/// configurations - subvolume (the default), fence (between any of the
	/// clip plane pairs), inverted fence, cross (between any two of the
	/// clip plane pairs) and inverted cross.
	/// </summary>
	public void SetCroppingRegionFlagsToSubVolume()
	{
		vtkVolumeMapper_SetCroppingRegionFlagsToSubVolume_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCroppingRegionPlanes_47(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set/Get the Cropping Region Planes ( xmin, xmax, ymin, ymax, zmin, zmax )
	/// These planes are defined in volume coordinates - spacing and origin are
	/// considered.
	/// </summary>
	public virtual void SetCroppingRegionPlanes(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkVolumeMapper_SetCroppingRegionPlanes_47(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetCroppingRegionPlanes_48(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the Cropping Region Planes ( xmin, xmax, ymin, ymax, zmin, zmax )
	/// These planes are defined in volume coordinates - spacing and origin are
	/// considered.
	/// </summary>
	public virtual void SetCroppingRegionPlanes(IntPtr _arg)
	{
		vtkVolumeMapper_SetCroppingRegionPlanes_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetInputData_49(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual void SetInputData(vtkImageData arg0)
	{
		vtkVolumeMapper_SetInputData_49(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetInputData_50(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual void SetInputData(vtkDataSet arg0)
	{
		vtkVolumeMapper_SetInputData_50(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeMapper_SetInputData_51(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the input data
	/// </summary>
	public virtual void SetInputData(vtkRectilinearGrid arg0)
	{
		vtkVolumeMapper_SetInputData_51(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
