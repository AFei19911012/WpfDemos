using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGPUVolumeRayCastMapper
/// </summary>
/// <remarks>
///    Ray casting performed on the GPU.
///
/// vtkGPUVolumeRayCastMapper is a volume mapper that performs ray casting on
/// the GPU using fragment programs.
///
/// This mapper supports connections in multiple ports of input 0 (port 0 being
/// the only required connection). It is up to the concrete implementation
/// whether additional inputs will be used during rendering. This class maintains
/// a list of the currently active input ports (Ports) as well as a list of the
/// ports that have been disconnected (RemovedPorts). RemovedPorts is used the
/// the concrete implementation to clean up internal structures.
///
/// </remarks>
public abstract class vtkGPUVolumeRayCastMapper : vtkVolumeMapper
{
	/// <summary>
	/// Optionally, set a mask input. This mask may be a binary mask or a label
	/// map. This must be specified via SetMaskType.
	///
	/// If the mask is a binary mask, the volume rendering is confined to regions
	/// within the binary mask. The binary mask is assumed to have a datatype of
	/// UCHAR and values of 255 (inside) and 0 (outside).
	///
	/// The mask may also be a label map. The label map must have a datatype of
	/// UCHAR i.e. it can have upto 256 labels. The label 0 is reserved as a
	/// special label. In voxels with label value of 0, the default transfer
	/// functions supplied by vtkVolumeProperty are used.
	///
	/// For voxels with a label values greater than 0, the color transfer functions
	/// supplied using vtkVolumeProperty's label API are used.
	///
	/// For voxels with a label value greater than 0, the color transfer function
	/// is blended with the default color transfer function, with the blending
	/// weight determined by MaskBlendFactor.
	/// </summary>
	public enum BinaryMaskType_WrapperEnum
	{
		/// <summary>enum member</summary>
		BinaryMaskType,
		/// <summary>enum member</summary>
		LabelMapMaskType
	}

	/// <summary>
	/// Return how much the dataset has to be reduced in each dimension to
	/// fit on the GPU. If the value is 1.0, there is no need to reduce the
	/// dataset.
	/// \pre the calling thread has a current OpenGL context.
	/// \pre mapper_supported: IsRenderSupported(renderer-&gt;GetRenderWindow(),0)
	/// The computation is based on hardware limits (3D texture indexable size)
	/// and MaxMemoryInBytes.
	/// \post valid_i_ratio: ratio[0]&gt;0 &amp;&amp; ratio[0]&lt;=1.0
	/// \post valid_j_ratio: ratio[1]&gt;0 &amp;&amp; ratio[1]&lt;=1.0
	/// \post valid_k_ratio: ratio[2]&gt;0 &amp;&amp; ratio[2]&lt;=1.0
	/// </summary>
	public enum TFRangeType
	{
		/// <summary>enum member</summary>
		NATIVE = 1,
		/// <summary>enum member</summary>
		SCALAR = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGPUVolumeRayCastMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGPUVolumeRayCastMapper()
	{
		MRClassNameKey = "class vtkGPUVolumeRayCastMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUVolumeRayCastMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGPUVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGPUVolumeRayCastMapper New()
	{
		vtkGPUVolumeRayCastMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGPUVolumeRayCastMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGPUVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOff()
	{
		vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOn()
	{
		vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_ClampDepthToBackfaceOff_03(HandleRef pThis);

	/// <summary>
	/// Enable or disable clamping the depth value of the fully
	/// transparent voxel to the depth of the back-face of the
	/// volume. This parameter is used when RenderToImage mode is
	/// enabled. When ClampDepthToBackFace is false, the fully transparent
	/// voxels will have a value of 1.0 in the depth image. When
	/// this is true, the fully transparent voxels will have the
	/// depth value of the face at which the ray exits the volume.
	/// By default, this is set to 0 (off).
	/// \sa SetRenderToImage(), GetDepthImage()
	/// </summary>
	public virtual void ClampDepthToBackfaceOff()
	{
		vtkGPUVolumeRayCastMapper_ClampDepthToBackfaceOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_ClampDepthToBackfaceOn_04(HandleRef pThis);

	/// <summary>
	/// Enable or disable clamping the depth value of the fully
	/// transparent voxel to the depth of the back-face of the
	/// volume. This parameter is used when RenderToImage mode is
	/// enabled. When ClampDepthToBackFace is false, the fully transparent
	/// voxels will have a value of 1.0 in the depth image. When
	/// this is true, the fully transparent voxels will have the
	/// depth value of the face at which the ray exits the volume.
	/// By default, this is set to 0 (off).
	/// \sa SetRenderToImage(), GetDepthImage()
	/// </summary>
	public virtual void ClampDepthToBackfaceOn()
	{
		vtkGPUVolumeRayCastMapper_ClampDepthToBackfaceOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_CreateCanonicalView_05(HandleRef pThis, HandleRef ren, HandleRef volume, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

	/// <summary>
	/// Based on hardware and properties, we may or may not be able to
	/// render using 3D texture mapping. This indicates if 3D texture
	/// mapping is supported by the hardware, and if the other extensions
	/// necessary to support the specific properties are available.
	/// </summary>
	public void CreateCanonicalView(vtkRenderer ren, vtkVolume volume, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
	{
		vtkGPUVolumeRayCastMapper_CreateCanonicalView_05(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), volume?.GetCppThis() ?? default(HandleRef), image?.GetCppThis() ?? default(HandleRef), blend_mode, viewDirection, viewUp);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_GPURender_06(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Handled in the subclass - the actual render method
	/// \pre input is up-to-date.
	/// </summary>
	public virtual void GPURender(vtkRenderer arg0, vtkVolume arg1)
	{
		vtkGPUVolumeRayCastMapper_GPURender_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistances_07(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistances()
	{
		return vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistances_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_08(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_09(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetBoundsFromPort_10(HandleRef pThis, int port);

	/// <summary>
	/// Number of currently active ports.
	/// </summary>
	public IntPtr GetBoundsFromPort(int port)
	{
		return vtkGPUVolumeRayCastMapper_GetBoundsFromPort_10(GetCppThis(), port);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetClampDepthToBackface_11(HandleRef pThis);

	/// <summary>
	/// Enable or disable clamping the depth value of the fully
	/// transparent voxel to the depth of the back-face of the
	/// volume. This parameter is used when RenderToImage mode is
	/// enabled. When ClampDepthToBackFace is false, the fully transparent
	/// voxels will have a value of 1.0 in the depth image. When
	/// this is true, the fully transparent voxels will have the
	/// depth value of the face at which the ray exits the volume.
	/// By default, this is set to 0 (off).
	/// \sa SetRenderToImage(), GetDepthImage()
	/// </summary>
	public virtual int GetClampDepthToBackface()
	{
		return vtkGPUVolumeRayCastMapper_GetClampDepthToBackface_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_GetColorImage_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Low level API to export the color texture as vtkImageData in
	/// RenderToImage mode.
	/// Should be implemented by the graphics API specific mapper (GL or other).
	/// \sa SetRenderToImage()
	/// </summary>
	public virtual void GetColorImage(vtkImageData arg0)
	{
		vtkGPUVolumeRayCastMapper_GetColorImage_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetColorRangeType_13(HandleRef pThis);

	/// <summary>
	/// Set whether to use the scalar range or the native transfer function range
	/// when looking up transfer functions for color and opacity values. When the
	/// range is set to TransferFunctionRange::SCALAR, the function is distributed
	/// over the entire scalar range. If it is set to
	/// TransferFunctionRange::NATIVE, the scalar values outside the native
	/// transfer function range will be truncated to native range. By
	/// default, the volume scalar range is used.
	///
	/// \note The native range of the transfer function is the range returned by
	/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
	///
	/// \note There is no special API provided for 2D transfer functions
	/// considering that they are set as a pre-generated vtkImageData on this
	/// class i.e. the range is already encoded.
	/// </summary>
	public virtual int GetColorRangeType()
	{
		return vtkGPUVolumeRayCastMapper_GetColorRangeType_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_GetDepthImage_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Low level API to export the depth texture as vtkImageData in
	/// RenderToImage mode.
	/// Should be implemented by the graphics API specific mapper (GL or other).
	/// \sa SetRenderToImage()
	/// </summary>
	public virtual void GetDepthImage(vtkImageData arg0)
	{
		vtkGPUVolumeRayCastMapper_GetDepthImage_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetDepthImageScalarType_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the scalar type of the depth texture in RenderToImage mode.
	/// By default, the type if VTK_FLOAT.
	/// \sa SetRenderToImage()
	/// </summary>
	public virtual int GetDepthImageScalarType()
	{
		return vtkGPUVolumeRayCastMapper_GetDepthImageScalarType_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetDepthPassContourValues_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return handle to contour values container so
	/// that values can be set by the application. Contour values
	/// will be used only when UseDepthPass is on.
	/// </summary>
	public vtkContourValues GetDepthPassContourValues()
	{
		vtkContourValues vtkContourValues2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUVolumeRayCastMapper_GetDepthPassContourValues_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourValues2 = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourValues2.Register(null);
			}
		}
		return vtkContourValues2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetFinalColorLevel_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the window / level applied to the final color.
	/// This allows brightness / contrast adjustments on the
	/// final image.
	/// window is the width of the window.
	/// level is the center of the window.
	/// Initial window value is 1.0
	/// Initial level value is 0.5
	/// window cannot be null but can be negative, this way
	/// values will be reversed.
	/// |window| can be larger than 1.0
	/// level can be any real value.
	/// </summary>
	public virtual float GetFinalColorLevel()
	{
		return vtkGPUVolumeRayCastMapper_GetFinalColorLevel_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetFinalColorWindow_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the window / level applied to the final color.
	/// This allows brightness / contrast adjustments on the
	/// final image.
	/// window is the width of the window.
	/// level is the center of the window.
	/// Initial window value is 1.0
	/// Initial level value is 0.5
	/// window cannot be null but can be negative, this way
	/// values will be reversed.
	/// |window| can be larger than 1.0
	/// level can be any real value.
	/// </summary>
	public virtual float GetFinalColorWindow()
	{
		return vtkGPUVolumeRayCastMapper_GetFinalColorWindow_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReach_19(HandleRef pThis);

	/// <summary>
	/// This parameter acts as a balance between localness
	/// and globalness of shadows.
	/// A value of 0.0 will be faster, but we'll only capture local shadows.
	/// A value of 1.0 will be slower, but we'll capture all shadows.
	/// The default value is 0.0.
	/// </summary>
	public virtual float GetGlobalIlluminationReach()
	{
		return vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReach_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReachMaxValue_20(HandleRef pThis);

	/// <summary>
	/// This parameter acts as a balance between localness
	/// and globalness of shadows.
	/// A value of 0.0 will be faster, but we'll only capture local shadows.
	/// A value of 1.0 will be slower, but we'll capture all shadows.
	/// The default value is 0.0.
	/// </summary>
	public virtual float GetGlobalIlluminationReachMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReachMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReachMinValue_21(HandleRef pThis);

	/// <summary>
	/// This parameter acts as a balance between localness
	/// and globalness of shadows.
	/// A value of 0.0 will be faster, but we'll only capture local shadows.
	/// A value of 1.0 will be slower, but we'll capture all shadows.
	/// The default value is 0.0.
	/// </summary>
	public virtual float GetGlobalIlluminationReachMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetGlobalIlluminationReachMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetGradientOpacityRangeType_22(HandleRef pThis);

	/// <summary>
	/// Set whether to use the scalar range or the native transfer function range
	/// when looking up transfer functions for color and opacity values. When the
	/// range is set to TransferFunctionRange::SCALAR, the function is distributed
	/// over the entire scalar range. If it is set to
	/// TransferFunctionRange::NATIVE, the scalar values outside the native
	/// transfer function range will be truncated to native range. By
	/// default, the volume scalar range is used.
	///
	/// \note The native range of the transfer function is the range returned by
	/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
	///
	/// \note There is no special API provided for 2D transfer functions
	/// considering that they are set as a pre-generated vtkImageData on this
	/// class i.e. the range is already encoded.
	/// </summary>
	public virtual int GetGradientOpacityRangeType()
	{
		return vtkGPUVolumeRayCastMapper_GetGradientOpacityRangeType_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistance_23(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
	/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
	/// is on.
	/// </summary>
	public virtual float GetImageSampleDistance()
	{
		return vtkGPUVolumeRayCastMapper_GetImageSampleDistance_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
	/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
	/// is on.
	/// </summary>
	public virtual float GetImageSampleDistanceMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMinValue_25(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
	/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
	/// is on.
	/// </summary>
	public virtual float GetImageSampleDistanceMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetInput_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set whether to use the scalar range or the native transfer function range
	/// when looking up transfer functions for color and opacity values. When the
	/// range is set to TransferFunctionRange::SCALAR, the function is distributed
	/// over the entire scalar range. If it is set to
	/// TransferFunctionRange::NATIVE, the scalar values outside the native
	/// transfer function range will be truncated to native range. By
	/// default, the volume scalar range is used.
	///
	/// \note The native range of the transfer function is the range returned by
	/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
	///
	/// \note There is no special API provided for 2D transfer functions
	/// considering that they are set as a pre-generated vtkImageData on this
	/// class i.e. the range is already encoded.
	/// </summary>
	public override vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUVolumeRayCastMapper_GetInput_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkGPUVolumeRayCastMapper_GetInputCount_27(HandleRef pThis);

	/// <summary>
	/// Number of currently active ports.
	/// </summary>
	public int GetInputCount()
	{
		return vtkGPUVolumeRayCastMapper_GetInputCount_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_28(HandleRef pThis);

	/// <summary>
	/// Compute the sample distance from the data spacing.  When the number of
	/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
	/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
	/// </summary>
	public virtual int GetLockSampleDistanceToInputSpacing()
	{
		return vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_29(HandleRef pThis);

	/// <summary>
	/// Compute the sample distance from the data spacing.  When the number of
	/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
	/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
	/// </summary>
	public virtual int GetLockSampleDistanceToInputSpacingMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_30(HandleRef pThis);

	/// <summary>
	/// Compute the sample distance from the data spacing.  When the number of
	/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
	/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
	/// </summary>
	public virtual int GetLockSampleDistanceToInputSpacingMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactor_31(HandleRef pThis);

	/// <summary>
	/// Tells how much mask color transfer function is used compared to the
	/// standard color transfer function when the mask is true. This is relevant
	/// only for the label map mask.
	/// 0.0 means only standard color transfer function.
	/// 1.0 means only mask color transfer function.
	/// The default value is 1.0.
	/// </summary>
	public virtual float GetMaskBlendFactor()
	{
		return vtkGPUVolumeRayCastMapper_GetMaskBlendFactor_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Tells how much mask color transfer function is used compared to the
	/// standard color transfer function when the mask is true. This is relevant
	/// only for the label map mask.
	/// 0.0 means only standard color transfer function.
	/// 1.0 means only mask color transfer function.
	/// The default value is 1.0.
	/// </summary>
	public virtual float GetMaskBlendFactorMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMinValue_33(HandleRef pThis);

	/// <summary>
	/// Tells how much mask color transfer function is used compared to the
	/// standard color transfer function when the mask is true. This is relevant
	/// only for the label map mask.
	/// 0.0 means only standard color transfer function.
	/// 1.0 means only mask color transfer function.
	/// The default value is 1.0.
	/// </summary>
	public virtual float GetMaskBlendFactorMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetMaskInput_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Optionally, set a mask input. This mask may be a binary mask or a label
	/// map. This must be specified via SetMaskType.
	///
	/// If the mask is a binary mask, the volume rendering is confined to regions
	/// within the binary mask. The binary mask is assumed to have a datatype of
	/// UCHAR and values of 255 (inside) and 0 (outside).
	///
	/// The mask may also be a label map. The label map must have a datatype of
	/// UCHAR i.e. it can have upto 256 labels. The label 0 is reserved as a
	/// special label. In voxels with label value of 0, the default transfer
	/// functions supplied by vtkVolumeProperty are used.
	///
	/// For voxels with a label values greater than 0, the color transfer functions
	/// supplied using vtkVolumeProperty's label API are used.
	///
	/// For voxels with a label value greater than 0, the color transfer function
	/// is blended with the default color transfer function, with the blending
	/// weight determined by MaskBlendFactor.
	/// </summary>
	public virtual vtkImageData GetMaskInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUVolumeRayCastMapper_GetMaskInput_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetMaskType_35(HandleRef pThis);

	/// <summary>
	/// Set the mask type, if mask is to be used. See documentation for
	/// SetMaskInput(). The default is a LabelMapMaskType.
	/// </summary>
	public virtual int GetMaskType()
	{
		return vtkGPUVolumeRayCastMapper_GetMaskType_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFraction_36(HandleRef pThis);

	/// <summary>
	/// Maximum fraction of the MaxMemoryInBytes that should
	/// be used to hold the texture. Valid values are 0.1 to
	/// 1.0.
	/// </summary>
	public virtual float GetMaxMemoryFraction()
	{
		return vtkGPUVolumeRayCastMapper_GetMaxMemoryFraction_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMaxValue_37(HandleRef pThis);

	/// <summary>
	/// Maximum fraction of the MaxMemoryInBytes that should
	/// be used to hold the texture. Valid values are 0.1 to
	/// 1.0.
	/// </summary>
	public virtual float GetMaxMemoryFractionMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMaxValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMinValue_38(HandleRef pThis);

	/// <summary>
	/// Maximum fraction of the MaxMemoryInBytes that should
	/// be used to hold the texture. Valid values are 0.1 to
	/// 1.0.
	/// </summary>
	public virtual float GetMaxMemoryFractionMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMinValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGPUVolumeRayCastMapper_GetMaxMemoryInBytes_39(HandleRef pThis);

	/// <summary>
	/// Maximum size of the 3D texture in GPU memory.
	/// Will default to the size computed from the graphics
	/// card. Can be adjusted by the user.
	/// </summary>
	public virtual long GetMaxMemoryInBytes()
	{
		return vtkGPUVolumeRayCastMapper_GetMaxMemoryInBytes_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistance_40(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMaximumImageSampleDistance()
	{
		return vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistance_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_41(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMaximumImageSampleDistanceMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_42(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMaximumImageSampleDistanceMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistance_43(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMinimumImageSampleDistance()
	{
		return vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistance_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_44(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMinimumImageSampleDistanceMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_45(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMinimumImageSampleDistanceMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBase_46(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBase_46(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_47(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_47(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_GetReductionRatio_48(HandleRef pThis, IntPtr ratio);

	/// <summary>
	/// Return how much the dataset has to be reduced in each dimension to
	/// fit on the GPU. If the value is 1.0, there is no need to reduce the
	/// dataset.
	/// \pre the calling thread has a current OpenGL context.
	/// \pre mapper_supported: IsRenderSupported(renderer-&gt;GetRenderWindow(),0)
	/// The computation is based on hardware limits (3D texture indexable size)
	/// and MaxMemoryInBytes.
	/// \post valid_i_ratio: ratio[0]&gt;0 &amp;&amp; ratio[0]&lt;=1.0
	/// \post valid_j_ratio: ratio[1]&gt;0 &amp;&amp; ratio[1]&lt;=1.0
	/// \post valid_k_ratio: ratio[2]&gt;0 &amp;&amp; ratio[2]&lt;=1.0
	/// </summary>
	public virtual void GetReductionRatio(IntPtr ratio)
	{
		vtkGPUVolumeRayCastMapper_GetReductionRatio_48(GetCppThis(), ratio);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetRenderToImage_49(HandleRef pThis);

	/// <summary>
	/// Enable or disable setting output of volume rendering to be
	/// color and depth textures. By default this is set to 0 (off).
	/// It should be noted that it is possible that underlying API specific
	/// mapper may not supoport RenderToImage mode.
	/// \warning
	/// \li This method ignores any other volumes / props in the scene.
	/// \li This method does not respect the general attributes of the
	/// scene i.e. background color, etc. It always produces a color
	/// image that has a transparent white background outside the
	/// bounds of the volume.
	///
	/// \sa GetDepthImage(), GetColorImage()
	/// </summary>
	public virtual int GetRenderToImage()
	{
		return vtkGPUVolumeRayCastMapper_GetRenderToImage_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGPUVolumeRayCastMapper_GetReportProgress_50(HandleRef pThis);

	/// <summary>
	/// Tells if the mapper will report intermediate progress.
	/// Initial value is true. As the progress works with a GL blocking
	/// call (glFinish()), this can be useful for huge dataset but can
	/// slow down rendering of small dataset. It should be set to true
	/// for big dataset or complex shading and streaming but to false for
	/// small datasets.
	/// </summary>
	public virtual bool GetReportProgress()
	{
		return (vtkGPUVolumeRayCastMapper_GetReportProgress_50(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetSampleDistance_51(HandleRef pThis);

	/// <summary>
	/// Set/Get the distance between samples used for rendering
	/// when AutoAdjustSampleDistances is off, or when this mapper
	/// has more than 1 second allocated to it for rendering.
	/// Initial value is 1.0.
	/// </summary>
	public virtual float GetSampleDistance()
	{
		return vtkGPUVolumeRayCastMapper_GetSampleDistance_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetScalarOpacityRangeType_52(HandleRef pThis);

	/// <summary>
	/// Set whether to use the scalar range or the native transfer function range
	/// when looking up transfer functions for color and opacity values. When the
	/// range is set to TransferFunctionRange::SCALAR, the function is distributed
	/// over the entire scalar range. If it is set to
	/// TransferFunctionRange::NATIVE, the scalar values outside the native
	/// transfer function range will be truncated to native range. By
	/// default, the volume scalar range is used.
	///
	/// \note The native range of the transfer function is the range returned by
	/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
	///
	/// \note There is no special API provided for 2D transfer functions
	/// considering that they are set as a pre-generated vtkImageData on this
	/// class i.e. the range is already encoded.
	/// </summary>
	public virtual int GetScalarOpacityRangeType()
	{
		return vtkGPUVolumeRayCastMapper_GetScalarOpacityRangeType_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetTransfer2DYAxisArray_53(HandleRef pThis);

	/// <summary>
	/// Set/Get the transfer 2D Y axis array
	/// </summary>
	public virtual string GetTransfer2DYAxisArray()
	{
		return Marshal.PtrToStringAnsi(vtkGPUVolumeRayCastMapper_GetTransfer2DYAxisArray_53(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetTransformedInput_54(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Number of currently active ports.
	/// </summary>
	public vtkDataSet GetTransformedInput(int port)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUVolumeRayCastMapper_GetTransformedInput_54(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkGPUVolumeRayCastMapper_GetUseDepthPass_55(HandleRef pThis);

	/// <summary>
	/// If UseDepthPass is on, the mapper will use two passes. In the first
	/// pass, an isocontour depth buffer will be utilized as starting point
	/// for ray-casting hence eliminating traversal on voxels that are
	/// not going to participate in final rendering. UseDepthPass requires
	/// reasonable contour values to be set which can be set by calling
	/// GetDepthPassContourValues() method and using vtkControurValues API.
	/// </summary>
	public virtual int GetUseDepthPass()
	{
		return vtkGPUVolumeRayCastMapper_GetUseDepthPass_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetUseDepthPassMaxValue_56(HandleRef pThis);

	/// <summary>
	/// If UseDepthPass is on, the mapper will use two passes. In the first
	/// pass, an isocontour depth buffer will be utilized as starting point
	/// for ray-casting hence eliminating traversal on voxels that are
	/// not going to participate in final rendering. UseDepthPass requires
	/// reasonable contour values to be set which can be set by calling
	/// GetDepthPassContourValues() method and using vtkControurValues API.
	/// </summary>
	public virtual int GetUseDepthPassMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetUseDepthPassMaxValue_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetUseDepthPassMinValue_57(HandleRef pThis);

	/// <summary>
	/// If UseDepthPass is on, the mapper will use two passes. In the first
	/// pass, an isocontour depth buffer will be utilized as starting point
	/// for ray-casting hence eliminating traversal on voxels that are
	/// not going to participate in final rendering. UseDepthPass requires
	/// reasonable contour values to be set which can be set by calling
	/// GetDepthPassContourValues() method and using vtkControurValues API.
	/// </summary>
	public virtual int GetUseDepthPassMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetUseDepthPassMinValue_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetUseJittering_58(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect.
	/// </summary>
	public virtual int GetUseJittering()
	{
		return vtkGPUVolumeRayCastMapper_GetUseJittering_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetUseJitteringMaxValue_59(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect.
	/// </summary>
	public virtual int GetUseJitteringMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetUseJitteringMaxValue_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_GetUseJitteringMinValue_60(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect.
	/// </summary>
	public virtual int GetUseJitteringMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetUseJitteringMinValue_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlending_61(HandleRef pThis);

	/// <summary>
	/// This parameter controls the blending between surfacic approximation
	/// and volumetric multi-scattering. It is only considered when
	/// Shade is enabled.
	/// A value of 0.0 means that no scattered rays will be cast, no volumetric shadows
	/// A value of 1.0 means that the shader will smartly blend between the two models
	/// A value of 2.0 means that the shader only uses the volumetric scattering model.
	/// The blending is not uniform, and is done in the following way:
	/// a value in [0, 1] biases the shader to choose between the two models, and a value
	/// in [1, 2] forces the shader to use more the volumetric model.
	/// </summary>
	public virtual float GetVolumetricScatteringBlending()
	{
		return vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlending_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlendingMaxValue_62(HandleRef pThis);

	/// <summary>
	/// This parameter controls the blending between surfacic approximation
	/// and volumetric multi-scattering. It is only considered when
	/// Shade is enabled.
	/// A value of 0.0 means that no scattered rays will be cast, no volumetric shadows
	/// A value of 1.0 means that the shader will smartly blend between the two models
	/// A value of 2.0 means that the shader only uses the volumetric scattering model.
	/// The blending is not uniform, and is done in the following way:
	/// a value in [0, 1] biases the shader to choose between the two models, and a value
	/// in [1, 2] forces the shader to use more the volumetric model.
	/// </summary>
	public virtual float GetVolumetricScatteringBlendingMaxValue()
	{
		return vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlendingMaxValue_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlendingMinValue_63(HandleRef pThis);

	/// <summary>
	/// This parameter controls the blending between surfacic approximation
	/// and volumetric multi-scattering. It is only considered when
	/// Shade is enabled.
	/// A value of 0.0 means that no scattered rays will be cast, no volumetric shadows
	/// A value of 1.0 means that the shader will smartly blend between the two models
	/// A value of 2.0 means that the shader only uses the volumetric scattering model.
	/// The blending is not uniform, and is done in the following way:
	/// a value in [0, 1] biases the shader to choose between the two models, and a value
	/// in [1, 2] forces the shader to use more the volumetric model.
	/// </summary>
	public virtual float GetVolumetricScatteringBlendingMinValue()
	{
		return vtkGPUVolumeRayCastMapper_GetVolumetricScatteringBlendingMinValue_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_IsA_64(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGPUVolumeRayCastMapper_IsA_64(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_IsRenderSupported_65(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Based on hardware and properties, we may or may not be able to
	/// render using 3D texture mapping. This indicates if 3D texture
	/// mapping is supported by the hardware, and if the other extensions
	/// necessary to support the specific properties are available.
	/// </summary>
	public virtual int IsRenderSupported(vtkRenderWindow arg0, vtkVolumeProperty arg1)
	{
		return vtkGPUVolumeRayCastMapper_IsRenderSupported_65(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGPUVolumeRayCastMapper_IsTypeOf_66(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGPUVolumeRayCastMapper_IsTypeOf_66(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_67(HandleRef pThis);

	/// <summary>
	/// Compute the sample distance from the data spacing.  When the number of
	/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
	/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
	/// </summary>
	public virtual void LockSampleDistanceToInputSpacingOff()
	{
		vtkGPUVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_68(HandleRef pThis);

	/// <summary>
	/// Compute the sample distance from the data spacing.  When the number of
	/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
	/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
	/// </summary>
	public virtual void LockSampleDistanceToInputSpacingOn()
	{
		vtkGPUVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_NewInstance_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGPUVolumeRayCastMapper NewInstance()
	{
		vtkGPUVolumeRayCastMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUVolumeRayCastMapper_NewInstance_70(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_ReleaseGraphicsResources_71(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// \warning INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkGPUVolumeRayCastMapper_ReleaseGraphicsResources_71(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_RemoveInputConnection_72(HandleRef pThis, int port, HandleRef input);

	/// <summary>
	/// Add/Remove input connections. Active and removed ports are cached in
	/// Ports and RemovedPorts respectively.
	/// </summary>
	public override void RemoveInputConnection(int port, vtkAlgorithmOutput input)
	{
		vtkGPUVolumeRayCastMapper_RemoveInputConnection_72(GetCppThis(), port, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_RemoveInputConnection_73(HandleRef pThis, int port, int idx);

	/// <summary>
	/// Add/Remove input connections. Active and removed ports are cached in
	/// Ports and RemovedPorts respectively.
	/// </summary>
	public override void RemoveInputConnection(int port, int idx)
	{
		vtkGPUVolumeRayCastMapper_RemoveInputConnection_73(GetCppThis(), port, idx);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_Render_74(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Initialize rendering for this volume.
	/// \warning INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// </summary>
	public override void Render(vtkRenderer arg0, vtkVolume arg1)
	{
		vtkGPUVolumeRayCastMapper_Render_74(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_RenderToImageOff_75(HandleRef pThis);

	/// <summary>
	/// Enable or disable setting output of volume rendering to be
	/// color and depth textures. By default this is set to 0 (off).
	/// It should be noted that it is possible that underlying API specific
	/// mapper may not supoport RenderToImage mode.
	/// \warning
	/// \li This method ignores any other volumes / props in the scene.
	/// \li This method does not respect the general attributes of the
	/// scene i.e. background color, etc. It always produces a color
	/// image that has a transparent white background outside the
	/// bounds of the volume.
	///
	/// \sa GetDepthImage(), GetColorImage()
	/// </summary>
	public virtual void RenderToImageOff()
	{
		vtkGPUVolumeRayCastMapper_RenderToImageOff_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_RenderToImageOn_76(HandleRef pThis);

	/// <summary>
	/// Enable or disable setting output of volume rendering to be
	/// color and depth textures. By default this is set to 0 (off).
	/// It should be noted that it is possible that underlying API specific
	/// mapper may not supoport RenderToImage mode.
	/// \warning
	/// \li This method ignores any other volumes / props in the scene.
	/// \li This method does not respect the general attributes of the
	/// scene i.e. background color, etc. It always produces a color
	/// image that has a transparent white background outside the
	/// bounds of the volume.
	///
	/// \sa GetDepthImage(), GetColorImage()
	/// </summary>
	public virtual void RenderToImageOn()
	{
		vtkGPUVolumeRayCastMapper_RenderToImageOn_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGPUVolumeRayCastMapper_SafeDownCast_77(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGPUVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
	{
		vtkGPUVolumeRayCastMapper vtkGPUVolumeRayCastMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGPUVolumeRayCastMapper_SafeDownCast_77(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGPUVolumeRayCastMapper2 = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGPUVolumeRayCastMapper2.Register(null);
			}
		}
		return vtkGPUVolumeRayCastMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetAutoAdjustSampleDistances_78(HandleRef pThis, int _arg);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void SetAutoAdjustSampleDistances(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetAutoAdjustSampleDistances_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetClampDepthToBackface_79(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable or disable clamping the depth value of the fully
	/// transparent voxel to the depth of the back-face of the
	/// volume. This parameter is used when RenderToImage mode is
	/// enabled. When ClampDepthToBackFace is false, the fully transparent
	/// voxels will have a value of 1.0 in the depth image. When
	/// this is true, the fully transparent voxels will have the
	/// depth value of the face at which the ray exits the volume.
	/// By default, this is set to 0 (off).
	/// \sa SetRenderToImage(), GetDepthImage()
	/// </summary>
	public virtual void SetClampDepthToBackface(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetClampDepthToBackface_79(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetColorRangeType_80(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to use the scalar range or the native transfer function range
	/// when looking up transfer functions for color and opacity values. When the
	/// range is set to TransferFunctionRange::SCALAR, the function is distributed
	/// over the entire scalar range. If it is set to
	/// TransferFunctionRange::NATIVE, the scalar values outside the native
	/// transfer function range will be truncated to native range. By
	/// default, the volume scalar range is used.
	///
	/// \note The native range of the transfer function is the range returned by
	/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
	///
	/// \note There is no special API provided for 2D transfer functions
	/// considering that they are set as a pre-generated vtkImageData on this
	/// class i.e. the range is already encoded.
	/// </summary>
	public virtual void SetColorRangeType(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetColorRangeType_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetDepthImageScalarType_81(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the scalar type of the depth texture in RenderToImage mode.
	/// By default, the type if VTK_FLOAT.
	/// \sa SetRenderToImage()
	/// </summary>
	public virtual void SetDepthImageScalarType(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetDepthImageScalarType_81(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToFloat_82(HandleRef pThis);

	/// <summary>
	/// Set/Get the scalar type of the depth texture in RenderToImage mode.
	/// By default, the type if VTK_FLOAT.
	/// \sa SetRenderToImage()
	/// </summary>
	public void SetDepthImageScalarTypeToFloat()
	{
		vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToFloat_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToUnsignedChar_83(HandleRef pThis);

	/// <summary>
	/// Set/Get the scalar type of the depth texture in RenderToImage mode.
	/// By default, the type if VTK_FLOAT.
	/// \sa SetRenderToImage()
	/// </summary>
	public void SetDepthImageScalarTypeToUnsignedChar()
	{
		vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToUnsignedChar_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToUnsignedShort_84(HandleRef pThis);

	/// <summary>
	/// Set/Get the scalar type of the depth texture in RenderToImage mode.
	/// By default, the type if VTK_FLOAT.
	/// \sa SetRenderToImage()
	/// </summary>
	public void SetDepthImageScalarTypeToUnsignedShort()
	{
		vtkGPUVolumeRayCastMapper_SetDepthImageScalarTypeToUnsignedShort_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetFinalColorLevel_85(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the window / level applied to the final color.
	/// This allows brightness / contrast adjustments on the
	/// final image.
	/// window is the width of the window.
	/// level is the center of the window.
	/// Initial window value is 1.0
	/// Initial level value is 0.5
	/// window cannot be null but can be negative, this way
	/// values will be reversed.
	/// |window| can be larger than 1.0
	/// level can be any real value.
	/// </summary>
	public virtual void SetFinalColorLevel(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetFinalColorLevel_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetFinalColorWindow_86(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the window / level applied to the final color.
	/// This allows brightness / contrast adjustments on the
	/// final image.
	/// window is the width of the window.
	/// level is the center of the window.
	/// Initial window value is 1.0
	/// Initial level value is 0.5
	/// window cannot be null but can be negative, this way
	/// values will be reversed.
	/// |window| can be larger than 1.0
	/// level can be any real value.
	/// </summary>
	public virtual void SetFinalColorWindow(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetFinalColorWindow_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetGlobalIlluminationReach_87(HandleRef pThis, float _arg);

	/// <summary>
	/// This parameter acts as a balance between localness
	/// and globalness of shadows.
	/// A value of 0.0 will be faster, but we'll only capture local shadows.
	/// A value of 1.0 will be slower, but we'll capture all shadows.
	/// The default value is 0.0.
	/// </summary>
	public virtual void SetGlobalIlluminationReach(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetGlobalIlluminationReach_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetGradientOpacityRangeType_88(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to use the scalar range or the native transfer function range
	/// when looking up transfer functions for color and opacity values. When the
	/// range is set to TransferFunctionRange::SCALAR, the function is distributed
	/// over the entire scalar range. If it is set to
	/// TransferFunctionRange::NATIVE, the scalar values outside the native
	/// transfer function range will be truncated to native range. By
	/// default, the volume scalar range is used.
	///
	/// \note The native range of the transfer function is the range returned by
	/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
	///
	/// \note There is no special API provided for 2D transfer functions
	/// considering that they are set as a pre-generated vtkImageData on this
	/// class i.e. the range is already encoded.
	/// </summary>
	public virtual void SetGradientOpacityRangeType(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetGradientOpacityRangeType_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetImageSampleDistance_89(HandleRef pThis, float _arg);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
	/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
	/// is on.
	/// </summary>
	public virtual void SetImageSampleDistance(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetImageSampleDistance_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetInputConnection_90(HandleRef pThis, int port, HandleRef input);

	/// <summary>
	/// Add/Remove input connections. Active and removed ports are cached in
	/// Ports and RemovedPorts respectively.
	/// </summary>
	public override void SetInputConnection(int port, vtkAlgorithmOutput input)
	{
		vtkGPUVolumeRayCastMapper_SetInputConnection_90(GetCppThis(), port, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetInputConnection_91(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Add/Remove input connections. Active and removed ports are cached in
	/// Ports and RemovedPorts respectively.
	/// </summary>
	public override void SetInputConnection(vtkAlgorithmOutput input)
	{
		vtkGPUVolumeRayCastMapper_SetInputConnection_91(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_92(HandleRef pThis, int _arg);

	/// <summary>
	/// Compute the sample distance from the data spacing.  When the number of
	/// voxels is 8, the sample distance will be roughly 1/200 the average voxel
	/// size. The distance will grow proportionally to numVoxels^(1/3). Off by default.
	/// </summary>
	public virtual void SetLockSampleDistanceToInputSpacing(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMaskBlendFactor_93(HandleRef pThis, float _arg);

	/// <summary>
	/// Tells how much mask color transfer function is used compared to the
	/// standard color transfer function when the mask is true. This is relevant
	/// only for the label map mask.
	/// 0.0 means only standard color transfer function.
	/// 1.0 means only mask color transfer function.
	/// The default value is 1.0.
	/// </summary>
	public virtual void SetMaskBlendFactor(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetMaskBlendFactor_93(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMaskInput_94(HandleRef pThis, HandleRef mask);

	/// <summary>
	/// Optionally, set a mask input. This mask may be a binary mask or a label
	/// map. This must be specified via SetMaskType.
	///
	/// If the mask is a binary mask, the volume rendering is confined to regions
	/// within the binary mask. The binary mask is assumed to have a datatype of
	/// UCHAR and values of 255 (inside) and 0 (outside).
	///
	/// The mask may also be a label map. The label map must have a datatype of
	/// UCHAR i.e. it can have upto 256 labels. The label 0 is reserved as a
	/// special label. In voxels with label value of 0, the default transfer
	/// functions supplied by vtkVolumeProperty are used.
	///
	/// For voxels with a label values greater than 0, the color transfer functions
	/// supplied using vtkVolumeProperty's label API are used.
	///
	/// For voxels with a label value greater than 0, the color transfer function
	/// is blended with the default color transfer function, with the blending
	/// weight determined by MaskBlendFactor.
	/// </summary>
	public void SetMaskInput(vtkImageData mask)
	{
		vtkGPUVolumeRayCastMapper_SetMaskInput_94(GetCppThis(), mask?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMaskType_95(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the mask type, if mask is to be used. See documentation for
	/// SetMaskInput(). The default is a LabelMapMaskType.
	/// </summary>
	public virtual void SetMaskType(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetMaskType_95(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMaskTypeToBinary_96(HandleRef pThis);

	/// <summary>
	/// Set the mask type, if mask is to be used. See documentation for
	/// SetMaskInput(). The default is a LabelMapMaskType.
	/// </summary>
	public void SetMaskTypeToBinary()
	{
		vtkGPUVolumeRayCastMapper_SetMaskTypeToBinary_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMaskTypeToLabelMap_97(HandleRef pThis);

	/// <summary>
	/// Set the mask type, if mask is to be used. See documentation for
	/// SetMaskInput(). The default is a LabelMapMaskType.
	/// </summary>
	public void SetMaskTypeToLabelMap()
	{
		vtkGPUVolumeRayCastMapper_SetMaskTypeToLabelMap_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMaxMemoryFraction_98(HandleRef pThis, float _arg);

	/// <summary>
	/// Maximum fraction of the MaxMemoryInBytes that should
	/// be used to hold the texture. Valid values are 0.1 to
	/// 1.0.
	/// </summary>
	public virtual void SetMaxMemoryFraction(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetMaxMemoryFraction_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMaxMemoryInBytes_99(HandleRef pThis, long _arg);

	/// <summary>
	/// Maximum size of the 3D texture in GPU memory.
	/// Will default to the size computed from the graphics
	/// card. Can be adjusted by the user.
	/// </summary>
	public virtual void SetMaxMemoryInBytes(long _arg)
	{
		vtkGPUVolumeRayCastMapper_SetMaxMemoryInBytes_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMaximumImageSampleDistance_100(HandleRef pThis, float _arg);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual void SetMaximumImageSampleDistance(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetMaximumImageSampleDistance_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetMinimumImageSampleDistance_101(HandleRef pThis, float _arg);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual void SetMinimumImageSampleDistance(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetMinimumImageSampleDistance_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetRenderToImage_102(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable or disable setting output of volume rendering to be
	/// color and depth textures. By default this is set to 0 (off).
	/// It should be noted that it is possible that underlying API specific
	/// mapper may not supoport RenderToImage mode.
	/// \warning
	/// \li This method ignores any other volumes / props in the scene.
	/// \li This method does not respect the general attributes of the
	/// scene i.e. background color, etc. It always produces a color
	/// image that has a transparent white background outside the
	/// bounds of the volume.
	///
	/// \sa GetDepthImage(), GetColorImage()
	/// </summary>
	public virtual void SetRenderToImage(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetRenderToImage_102(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetReportProgress_103(HandleRef pThis, byte _arg);

	/// <summary>
	/// Tells if the mapper will report intermediate progress.
	/// Initial value is true. As the progress works with a GL blocking
	/// call (glFinish()), this can be useful for huge dataset but can
	/// slow down rendering of small dataset. It should be set to true
	/// for big dataset or complex shading and streaming but to false for
	/// small datasets.
	/// </summary>
	public virtual void SetReportProgress(bool _arg)
	{
		vtkGPUVolumeRayCastMapper_SetReportProgress_103(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetSampleDistance_104(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the distance between samples used for rendering
	/// when AutoAdjustSampleDistances is off, or when this mapper
	/// has more than 1 second allocated to it for rendering.
	/// Initial value is 1.0.
	/// </summary>
	public virtual void SetSampleDistance(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetSampleDistance_104(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetScalarOpacityRangeType_105(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to use the scalar range or the native transfer function range
	/// when looking up transfer functions for color and opacity values. When the
	/// range is set to TransferFunctionRange::SCALAR, the function is distributed
	/// over the entire scalar range. If it is set to
	/// TransferFunctionRange::NATIVE, the scalar values outside the native
	/// transfer function range will be truncated to native range. By
	/// default, the volume scalar range is used.
	///
	/// \note The native range of the transfer function is the range returned by
	/// vtkColorTransferFunction::GetRange() or vtkPiecewiseFunction::GetRange().
	///
	/// \note There is no special API provided for 2D transfer functions
	/// considering that they are set as a pre-generated vtkImageData on this
	/// class i.e. the range is already encoded.
	/// </summary>
	public virtual void SetScalarOpacityRangeType(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetScalarOpacityRangeType_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetTransfer2DYAxisArray_106(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the transfer 2D Y axis array
	/// </summary>
	public virtual void SetTransfer2DYAxisArray(string _arg)
	{
		vtkGPUVolumeRayCastMapper_SetTransfer2DYAxisArray_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetUseDepthPass_107(HandleRef pThis, int _arg);

	/// <summary>
	/// If UseDepthPass is on, the mapper will use two passes. In the first
	/// pass, an isocontour depth buffer will be utilized as starting point
	/// for ray-casting hence eliminating traversal on voxels that are
	/// not going to participate in final rendering. UseDepthPass requires
	/// reasonable contour values to be set which can be set by calling
	/// GetDepthPassContourValues() method and using vtkControurValues API.
	/// </summary>
	public virtual void SetUseDepthPass(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetUseDepthPass_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetUseJittering_108(HandleRef pThis, int _arg);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect.
	/// </summary>
	public virtual void SetUseJittering(int _arg)
	{
		vtkGPUVolumeRayCastMapper_SetUseJittering_108(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_SetVolumetricScatteringBlending_109(HandleRef pThis, float _arg);

	/// <summary>
	/// This parameter controls the blending between surfacic approximation
	/// and volumetric multi-scattering. It is only considered when
	/// Shade is enabled.
	/// A value of 0.0 means that no scattered rays will be cast, no volumetric shadows
	/// A value of 1.0 means that the shader will smartly blend between the two models
	/// A value of 2.0 means that the shader only uses the volumetric scattering model.
	/// The blending is not uniform, and is done in the following way:
	/// a value in [0, 1] biases the shader to choose between the two models, and a value
	/// in [1, 2] forces the shader to use more the volumetric model.
	/// </summary>
	public virtual void SetVolumetricScatteringBlending(float _arg)
	{
		vtkGPUVolumeRayCastMapper_SetVolumetricScatteringBlending_109(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_UseDepthPassOff_110(HandleRef pThis);

	/// <summary>
	/// If UseDepthPass is on, the mapper will use two passes. In the first
	/// pass, an isocontour depth buffer will be utilized as starting point
	/// for ray-casting hence eliminating traversal on voxels that are
	/// not going to participate in final rendering. UseDepthPass requires
	/// reasonable contour values to be set which can be set by calling
	/// GetDepthPassContourValues() method and using vtkControurValues API.
	/// </summary>
	public virtual void UseDepthPassOff()
	{
		vtkGPUVolumeRayCastMapper_UseDepthPassOff_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_UseDepthPassOn_111(HandleRef pThis);

	/// <summary>
	/// If UseDepthPass is on, the mapper will use two passes. In the first
	/// pass, an isocontour depth buffer will be utilized as starting point
	/// for ray-casting hence eliminating traversal on voxels that are
	/// not going to participate in final rendering. UseDepthPass requires
	/// reasonable contour values to be set which can be set by calling
	/// GetDepthPassContourValues() method and using vtkControurValues API.
	/// </summary>
	public virtual void UseDepthPassOn()
	{
		vtkGPUVolumeRayCastMapper_UseDepthPassOn_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_UseJitteringOff_112(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect.
	/// </summary>
	public virtual void UseJitteringOff()
	{
		vtkGPUVolumeRayCastMapper_UseJitteringOff_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGPUVolumeRayCastMapper_UseJitteringOn_113(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect.
	/// </summary>
	public virtual void UseJitteringOn()
	{
		vtkGPUVolumeRayCastMapper_UseJitteringOn_113(GetCppThis());
	}
}
