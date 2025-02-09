using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSmartVolumeMapper
/// </summary>
/// <remarks>
///    Adaptive volume mapper
///
/// vtkSmartVolumeMapper is a volume mapper that will delegate to a specific
/// volume mapper based on rendering parameters and available hardware. Use the
/// SetRequestedRenderMode() method to control the behavior of the selection.
/// The following options are available:
///
/// @par vtkSmartVolumeMapper::DefaultRenderMode:
///          Allow the vtkSmartVolumeMapper to select the best mapper based on
///          rendering parameters and hardware support. If GPU ray casting is
///          supported, the vtkGPUVolumeRayCastMapper mapper will be used for
///          all rendering. If not, then the vtkFixedPointVolumeRayCastMapper
///          will be used exclusively. This is the default requested render
///          mode, and is generally the best option. When you use this option,
///          your volume will always be rendered, but the method used to render
///          it may vary based on parameters and platform.
///
/// @par vtkSmartVolumeMapper::RayCastRenderMode:
///          Use the vtkFixedPointVolumeRayCastMapper for both interactive and
///          still rendering. When you use this option your volume will always
///          be rendered with the vtkFixedPointVolumeRayCastMapper.
///
/// @par vtkSmartVolumeMapper::GPURenderMode:
///          Use the vtkGPUVolumeRayCastMapper, if supported, for both
///          interactive and still rendering. If the GPU ray caster is not
///          supported (due to hardware limitations or rendering parameters)
///          then no image will be rendered. Use this option only if you have
///          already checked for supported based on the current hardware,
///          number of scalar components, and rendering parameters in the
///          vtkVolumeProperty.
///
/// @par vtkSmartVolumeMapper::GPURenderMode:
///  You can adjust the contrast and brightness in the rendered image using the
///  FinalColorWindow and FinalColorLevel ivars. By default the
///  FinalColorWindow is set to 1.0, and the FinalColorLevel is set to 0.5,
///  which applies no correction to the computed image. To apply the window /
///  level operation to the computer image color, first a Scale and Bias
///  value are computed:
///  &lt;pre&gt;
///  scale = 1.0 / this-&gt;FinalColorWindow
///  bias  = 0.5 - this-&gt;FinalColorLevel / this-&gt;FinalColorWindow
///  &lt;/pre&gt;
///  To compute a new color (R', G', B', A') from an existing color (R,G,B,A)
///  for a pixel, the following equation is used:
///  &lt;pre&gt;
///  R' = R*scale + bias*A
///  G' = G*scale + bias*A
///  B' = B*scale + bias*A
///  A' = A
///  &lt;/pre&gt;
/// Note that bias is multiplied by the alpha component before adding because
/// the red, green, and blue component of the color are already pre-multiplied
/// by alpha. Also note that the window / level operation leaves the alpha
/// component unchanged - it only adjusts the RGB values.
/// </remarks>
public class vtkSmartVolumeMapper : vtkVolumeMapper
{
	/// <summary>
	/// Get the final color level.
	/// </summary>
	public enum DefaultRenderMode_WrapperEnum
	{
		/// <summary>enum member</summary>
		DefaultRenderMode = 0,
		/// <summary>enum member</summary>
		GPURenderMode = 2,
		/// <summary>enum member</summary>
		InvalidRenderMode = 5,
		/// <summary>enum member</summary>
		OSPRayRenderMode = 3,
		/// <summary>enum member</summary>
		RayCastRenderMode = 1,
		/// <summary>enum member</summary>
		UndefinedRenderMode = 4
	}

	/// <summary>
	/// LowResDisable disables low res mode (default)
	/// LowResResample enable low res mode by automatically resampling the volume,
	/// this enable large volume to be displayed at higher frame rate at the cost of
	/// rendering quality
	/// Actual resample factor will be determined using MaxMemoryInBytes and MaxMemoryFraction
	/// </summary>
	public enum LowResModeType
	{
		/// <summary>enum member</summary>
		LowResModeDisabled,
		/// <summary>enum member</summary>
		LowResModeResample
	}

	/// <summary>
	/// VectorMode is a special rendering mode for 3-component vectors which makes
	/// use of GPURayCastMapper's independent-component capabilities. In this mode,
	/// a single component in the vector can be selected for rendering. In addition,
	/// the mapper can compute a scalar field representing the magnitude of this vector
	/// using a vtkImageMagnitude object (MAGNITUDE mode).
	/// </summary>
	public enum VectorModeType
	{
		/// <summary>enum member</summary>
		COMPONENT = 1,
		/// <summary>enum member</summary>
		DISABLED = -1,
		/// <summary>enum member</summary>
		MAGNITUDE = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSmartVolumeMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSmartVolumeMapper()
	{
		MRClassNameKey = "class vtkSmartVolumeMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmartVolumeMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSmartVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmartVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSmartVolumeMapper New()
	{
		vtkSmartVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmartVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSmartVolumeMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSmartVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
	/// enabled. To explicitly set and use this flag, one must disable
	/// InteractiveAdjustSampleDistances.
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOff()
	{
		vtkSmartVolumeMapper_AutoAdjustSampleDistancesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
	/// enabled. To explicitly set and use this flag, one must disable
	/// InteractiveAdjustSampleDistances.
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOn()
	{
		vtkSmartVolumeMapper_AutoAdjustSampleDistancesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_CreateCanonicalView_03(HandleRef pThis, HandleRef ren, HandleRef volume, HandleRef volume2, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

	/// <summary>
	/// This method can be used to render a representative view of the input data
	/// into the supplied image given the supplied blending mode, view direction,
	/// and view up vector.
	/// </summary>
	public void CreateCanonicalView(vtkRenderer ren, vtkVolume volume, vtkVolume volume2, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
	{
		vtkSmartVolumeMapper_CreateCanonicalView_03(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), volume?.GetCppThis() ?? default(HandleRef), volume2?.GetCppThis() ?? default(HandleRef), image?.GetCppThis() ?? default(HandleRef), blend_mode, viewDirection, viewUp);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetAutoAdjustSampleDistances_04(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
	/// enabled. To explicitly set and use this flag, one must disable
	/// InteractiveAdjustSampleDistances.
	/// </summary>
	public virtual int GetAutoAdjustSampleDistances()
	{
		return vtkSmartVolumeMapper_GetAutoAdjustSampleDistances_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetAutoAdjustSampleDistancesMaxValue_05(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
	/// enabled. To explicitly set and use this flag, one must disable
	/// InteractiveAdjustSampleDistances.
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMaxValue()
	{
		return vtkSmartVolumeMapper_GetAutoAdjustSampleDistancesMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetAutoAdjustSampleDistancesMinValue_06(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
	/// enabled. To explicitly set and use this flag, one must disable
	/// InteractiveAdjustSampleDistances.
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMinValue()
	{
		return vtkSmartVolumeMapper_GetAutoAdjustSampleDistancesMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetFinalColorLevel_07(HandleRef pThis);

	/// <summary>
	/// Get the final color level.
	/// </summary>
	public virtual float GetFinalColorLevel()
	{
		return vtkSmartVolumeMapper_GetFinalColorLevel_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetFinalColorWindow_08(HandleRef pThis);

	/// <summary>
	/// Get the final color window. Initial value is 1.0.
	/// </summary>
	public virtual float GetFinalColorWindow()
	{
		return vtkSmartVolumeMapper_GetFinalColorWindow_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetGlobalIlluminationReach_09(HandleRef pThis);

	/// <summary>
	/// @copydoc vtkGPUVolumeRayCastMapper::SetGlobalIlluminationReach(float)
	///
	/// This parameter is only used when the underlying mapper
	/// is a vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetGlobalIlluminationReach()
	{
		return vtkSmartVolumeMapper_GetGlobalIlluminationReach_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetGlobalIlluminationReachMaxValue_10(HandleRef pThis);

	/// <summary>
	/// @copydoc vtkGPUVolumeRayCastMapper::SetGlobalIlluminationReach(float)
	///
	/// This parameter is only used when the underlying mapper
	/// is a vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetGlobalIlluminationReachMaxValue()
	{
		return vtkSmartVolumeMapper_GetGlobalIlluminationReachMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetGlobalIlluminationReachMinValue_11(HandleRef pThis);

	/// <summary>
	/// @copydoc vtkGPUVolumeRayCastMapper::SetGlobalIlluminationReach(float)
	///
	/// This parameter is only used when the underlying mapper
	/// is a vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetGlobalIlluminationReachMinValue()
	{
		return vtkSmartVolumeMapper_GetGlobalIlluminationReachMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistances_12(HandleRef pThis);

	/// <summary>
	/// If the InteractiveAdjustSampleDistances flag is enabled,
	/// vtkSmartVolumeMapper interactively sets and resets the
	/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
	/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
	/// distance based on whether the render is interactive or still.
	/// By default, InteractiveAdjustSampleDistances is enabled.
	/// </summary>
	public virtual int GetInteractiveAdjustSampleDistances()
	{
		return vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistances_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistancesMaxValue_13(HandleRef pThis);

	/// <summary>
	/// If the InteractiveAdjustSampleDistances flag is enabled,
	/// vtkSmartVolumeMapper interactively sets and resets the
	/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
	/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
	/// distance based on whether the render is interactive or still.
	/// By default, InteractiveAdjustSampleDistances is enabled.
	/// </summary>
	public virtual int GetInteractiveAdjustSampleDistancesMaxValue()
	{
		return vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistancesMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistancesMinValue_14(HandleRef pThis);

	/// <summary>
	/// If the InteractiveAdjustSampleDistances flag is enabled,
	/// vtkSmartVolumeMapper interactively sets and resets the
	/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
	/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
	/// distance based on whether the render is interactive or still.
	/// By default, InteractiveAdjustSampleDistances is enabled.
	/// </summary>
	public virtual int GetInteractiveAdjustSampleDistancesMinValue()
	{
		return vtkSmartVolumeMapper_GetInteractiveAdjustSampleDistancesMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRate_15(HandleRef pThis);

	/// <summary>
	/// Get the update rate at or above which this is considered an
	/// interactive render.
	/// Initial value is 1.0.
	/// </summary>
	public virtual double GetInteractiveUpdateRate()
	{
		return vtkSmartVolumeMapper_GetInteractiveUpdateRate_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRateMaxValue_16(HandleRef pThis);

	/// <summary>
	/// If the DesiredUpdateRate of the vtkRenderWindow that caused the Render
	/// falls at or above this rate, the render is considered interactive and
	/// the mapper may be adjusted (depending on the render mode).
	/// Initial value is 1.0.
	/// </summary>
	public virtual double GetInteractiveUpdateRateMaxValue()
	{
		return vtkSmartVolumeMapper_GetInteractiveUpdateRateMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRateMinValue_17(HandleRef pThis);

	/// <summary>
	/// If the DesiredUpdateRate of the vtkRenderWindow that caused the Render
	/// falls at or above this rate, the render is considered interactive and
	/// the mapper may be adjusted (depending on the render mode).
	/// Initial value is 1.0.
	/// </summary>
	public virtual double GetInteractiveUpdateRateMinValue()
	{
		return vtkSmartVolumeMapper_GetInteractiveUpdateRateMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetInterpolationMode_18(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for downsampling (lowres GPU)
	/// (initial value: cubic).
	/// </summary>
	public virtual int GetInterpolationMode()
	{
		return vtkSmartVolumeMapper_GetInterpolationMode_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetInterpolationModeMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for downsampling (lowres GPU)
	/// (initial value: cubic).
	/// </summary>
	public virtual int GetInterpolationModeMaxValue()
	{
		return vtkSmartVolumeMapper_GetInterpolationModeMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetInterpolationModeMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for downsampling (lowres GPU)
	/// (initial value: cubic).
	/// </summary>
	public virtual int GetInterpolationModeMinValue()
	{
		return vtkSmartVolumeMapper_GetInterpolationModeMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetLastUsedRenderMode_21(HandleRef pThis);

	/// <summary>
	/// This will return the render mode used during the previous call to
	/// Render().
	/// </summary>
	public int GetLastUsedRenderMode()
	{
		return vtkSmartVolumeMapper_GetLastUsedRenderMode_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetLowResMode_22(HandleRef pThis);

	/// <summary>
	/// LowResDisable disables low res mode (default)
	/// LowResResample enable low res mode by automatically resampling the volume,
	/// this enable large volume to be displayed at higher frame rate at the cost of
	/// rendering quality
	/// Actual resample factor will be determined using MaxMemoryInBytes and MaxMemoryFraction
	/// </summary>
	public virtual int GetLowResMode()
	{
		return vtkSmartVolumeMapper_GetLowResMode_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFraction_23(HandleRef pThis);

	/// <summary>
	/// Value passed to the GPU mapper. Ignored by other mappers.
	/// Maximum fraction of the MaxMemoryInBytes that should
	/// be used to hold the texture. Valid values are 0.1 to
	/// 1.0.
	/// </summary>
	public virtual float GetMaxMemoryFraction()
	{
		return vtkSmartVolumeMapper_GetMaxMemoryFraction_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFractionMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Value passed to the GPU mapper. Ignored by other mappers.
	/// Maximum fraction of the MaxMemoryInBytes that should
	/// be used to hold the texture. Valid values are 0.1 to
	/// 1.0.
	/// </summary>
	public virtual float GetMaxMemoryFractionMaxValue()
	{
		return vtkSmartVolumeMapper_GetMaxMemoryFractionMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFractionMinValue_25(HandleRef pThis);

	/// <summary>
	/// Value passed to the GPU mapper. Ignored by other mappers.
	/// Maximum fraction of the MaxMemoryInBytes that should
	/// be used to hold the texture. Valid values are 0.1 to
	/// 1.0.
	/// </summary>
	public virtual float GetMaxMemoryFractionMinValue()
	{
		return vtkSmartVolumeMapper_GetMaxMemoryFractionMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSmartVolumeMapper_GetMaxMemoryInBytes_26(HandleRef pThis);

	/// <summary>
	/// Value passed to the GPU mapper. Ignored by other mappers.
	/// Maximum size of the 3D texture in GPU memory.
	/// Will default to the size computed from the graphics
	/// card. Can be adjusted by the user.
	/// Useful if the automatic detection is defective or missing.
	/// </summary>
	public virtual long GetMaxMemoryInBytes()
	{
		return vtkSmartVolumeMapper_GetMaxMemoryInBytes_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSmartVolumeMapper_GetNumberOfGenerationsFromBase_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSmartVolumeMapper_GetNumberOfGenerationsFromBase_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSmartVolumeMapper_GetNumberOfGenerationsFromBaseType_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSmartVolumeMapper_GetNumberOfGenerationsFromBaseType_28(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetRequestedRenderMode_29(HandleRef pThis);

	/// <summary>
	/// Get the requested render mode.
	/// </summary>
	public virtual int GetRequestedRenderMode()
	{
		return vtkSmartVolumeMapper_GetRequestedRenderMode_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetSampleDistance_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the distance between samples used for rendering
	/// when AutoAdjustSampleDistances is off, or when this mapper
	/// has more than 1 second allocated to it for rendering.
	/// If SampleDistance is negative, it will be computed based on the dataset
	/// spacing. Initial value is -1.0.
	/// </summary>
	public virtual float GetSampleDistance()
	{
		return vtkSmartVolumeMapper_GetSampleDistance_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmartVolumeMapper_GetTransfer2DYAxisArray_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the transfer 2D Y axis array
	/// </summary>
	public virtual string GetTransfer2DYAxisArray()
	{
		return Marshal.PtrToStringAnsi(vtkSmartVolumeMapper_GetTransfer2DYAxisArray_31(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetUseJittering_32(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect. This is only used by the GPU mapper.
	/// </summary>
	public virtual int GetUseJittering()
	{
		return vtkSmartVolumeMapper_GetUseJittering_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetUseJitteringMaxValue_33(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect. This is only used by the GPU mapper.
	/// </summary>
	public virtual int GetUseJitteringMaxValue()
	{
		return vtkSmartVolumeMapper_GetUseJitteringMaxValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetUseJitteringMinValue_34(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect. This is only used by the GPU mapper.
	/// </summary>
	public virtual int GetUseJitteringMinValue()
	{
		return vtkSmartVolumeMapper_GetUseJitteringMinValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetVectorComponent_35(HandleRef pThis);

	/// <summary>
	/// VectorMode is a special rendering mode for 3-component vectors which makes
	/// use of GPURayCastMapper's independent-component capabilities. In this mode,
	/// a single component in the vector can be selected for rendering. In addition,
	/// the mapper can compute a scalar field representing the magnitude of this vector
	/// using a vtkImageMagnitude object (MAGNITUDE mode).
	/// </summary>
	public virtual int GetVectorComponent()
	{
		return vtkSmartVolumeMapper_GetVectorComponent_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetVectorComponentMaxValue_36(HandleRef pThis);

	/// <summary>
	/// VectorMode is a special rendering mode for 3-component vectors which makes
	/// use of GPURayCastMapper's independent-component capabilities. In this mode,
	/// a single component in the vector can be selected for rendering. In addition,
	/// the mapper can compute a scalar field representing the magnitude of this vector
	/// using a vtkImageMagnitude object (MAGNITUDE mode).
	/// </summary>
	public virtual int GetVectorComponentMaxValue()
	{
		return vtkSmartVolumeMapper_GetVectorComponentMaxValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetVectorComponentMinValue_37(HandleRef pThis);

	/// <summary>
	/// VectorMode is a special rendering mode for 3-component vectors which makes
	/// use of GPURayCastMapper's independent-component capabilities. In this mode,
	/// a single component in the vector can be selected for rendering. In addition,
	/// the mapper can compute a scalar field representing the magnitude of this vector
	/// using a vtkImageMagnitude object (MAGNITUDE mode).
	/// </summary>
	public virtual int GetVectorComponentMinValue()
	{
		return vtkSmartVolumeMapper_GetVectorComponentMinValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_GetVectorMode_38(HandleRef pThis);

	/// <summary>
	/// VectorMode is a special rendering mode for 3-component vectors which makes
	/// use of GPURayCastMapper's independent-component capabilities. In this mode,
	/// a single component in the vector can be selected for rendering. In addition,
	/// the mapper can compute a scalar field representing the magnitude of this vector
	/// using a vtkImageMagnitude object (MAGNITUDE mode).
	/// </summary>
	public virtual int GetVectorMode()
	{
		return vtkSmartVolumeMapper_GetVectorMode_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetVolumetricScatteringBlending_39(HandleRef pThis);

	/// <summary>
	/// @copydoc vtkGPUVolumeRayCastMapper::SetVolumetricScatteringBlending(float)
	///
	/// This parameter is only used when the underlying mapper
	/// is a vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetVolumetricScatteringBlending()
	{
		return vtkSmartVolumeMapper_GetVolumetricScatteringBlending_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetVolumetricScatteringBlendingMaxValue_40(HandleRef pThis);

	/// <summary>
	/// @copydoc vtkGPUVolumeRayCastMapper::SetVolumetricScatteringBlending(float)
	///
	/// This parameter is only used when the underlying mapper
	/// is a vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetVolumetricScatteringBlendingMaxValue()
	{
		return vtkSmartVolumeMapper_GetVolumetricScatteringBlendingMaxValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSmartVolumeMapper_GetVolumetricScatteringBlendingMinValue_41(HandleRef pThis);

	/// <summary>
	/// @copydoc vtkGPUVolumeRayCastMapper::SetVolumetricScatteringBlending(float)
	///
	/// This parameter is only used when the underlying mapper
	/// is a vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetVolumetricScatteringBlendingMinValue()
	{
		return vtkSmartVolumeMapper_GetVolumetricScatteringBlendingMinValue_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_InteractiveAdjustSampleDistancesOff_42(HandleRef pThis);

	/// <summary>
	/// If the InteractiveAdjustSampleDistances flag is enabled,
	/// vtkSmartVolumeMapper interactively sets and resets the
	/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
	/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
	/// distance based on whether the render is interactive or still.
	/// By default, InteractiveAdjustSampleDistances is enabled.
	/// </summary>
	public virtual void InteractiveAdjustSampleDistancesOff()
	{
		vtkSmartVolumeMapper_InteractiveAdjustSampleDistancesOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_InteractiveAdjustSampleDistancesOn_43(HandleRef pThis);

	/// <summary>
	/// If the InteractiveAdjustSampleDistances flag is enabled,
	/// vtkSmartVolumeMapper interactively sets and resets the
	/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
	/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
	/// distance based on whether the render is interactive or still.
	/// By default, InteractiveAdjustSampleDistances is enabled.
	/// </summary>
	public virtual void InteractiveAdjustSampleDistancesOn()
	{
		vtkSmartVolumeMapper_InteractiveAdjustSampleDistancesOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_IsA_44(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSmartVolumeMapper_IsA_44(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmartVolumeMapper_IsTypeOf_45(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSmartVolumeMapper_IsTypeOf_45(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmartVolumeMapper_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSmartVolumeMapper NewInstance()
	{
		vtkSmartVolumeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmartVolumeMapper_NewInstance_47(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_ReleaseGraphicsResources_48(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkSmartVolumeMapper_ReleaseGraphicsResources_48(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_Render_49(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public override void Render(vtkRenderer arg0, vtkVolume arg1)
	{
		vtkSmartVolumeMapper_Render_49(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmartVolumeMapper_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSmartVolumeMapper SafeDownCast(vtkObjectBase o)
	{
		vtkSmartVolumeMapper vtkSmartVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmartVolumeMapper_SafeDownCast_50(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSmartVolumeMapper2 = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSmartVolumeMapper2.Register(null);
			}
		}
		return vtkSmartVolumeMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetAutoAdjustSampleDistances_51(HandleRef pThis, int _arg);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// Note that, this flag is ignored when InteractiveAdjustSampleDistances is
	/// enabled. To explicitly set and use this flag, one must disable
	/// InteractiveAdjustSampleDistances.
	/// </summary>
	public virtual void SetAutoAdjustSampleDistances(int _arg)
	{
		vtkSmartVolumeMapper_SetAutoAdjustSampleDistances_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetFinalColorLevel_52(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the final color level. The level controls the
	/// brightness of the image. The final color window will
	/// be centered at the final color level, and together
	/// represent a linear remapping of color values. The
	/// default value for the level is 0.5.
	/// </summary>
	public virtual void SetFinalColorLevel(float _arg)
	{
		vtkSmartVolumeMapper_SetFinalColorLevel_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetFinalColorWindow_53(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the final color window. This controls the contrast of
	/// the image. The default value is 1.0. The Window can be
	/// negative (this causes a "negative" effect on the image)
	/// Although Window can be set to 0.0, any value less than
	/// 0.00001 and greater than or equal to 0.0 will be set to
	/// 0.00001, and any value greater than -0.00001 but less
	/// than or equal to 0.0 will be set to -0.00001.
	/// Initial value is 1.0.
	/// </summary>
	public virtual void SetFinalColorWindow(float _arg)
	{
		vtkSmartVolumeMapper_SetFinalColorWindow_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetGlobalIlluminationReach_54(HandleRef pThis, float _arg);

	/// <summary>
	/// @copydoc vtkGPUVolumeRayCastMapper::SetGlobalIlluminationReach(float)
	///
	/// This parameter is only used when the underlying mapper
	/// is a vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual void SetGlobalIlluminationReach(float _arg)
	{
		vtkSmartVolumeMapper_SetGlobalIlluminationReach_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetInteractiveAdjustSampleDistances_55(HandleRef pThis, int _arg);

	/// <summary>
	/// If the InteractiveAdjustSampleDistances flag is enabled,
	/// vtkSmartVolumeMapper interactively sets and resets the
	/// AutoAdjustSampleDistances flag on the internal volume mapper. This flag
	/// along with InteractiveUpdateRate is useful to adjust volume mapper sample
	/// distance based on whether the render is interactive or still.
	/// By default, InteractiveAdjustSampleDistances is enabled.
	/// </summary>
	public virtual void SetInteractiveAdjustSampleDistances(int _arg)
	{
		vtkSmartVolumeMapper_SetInteractiveAdjustSampleDistances_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetInteractiveUpdateRate_56(HandleRef pThis, double _arg);

	/// <summary>
	/// If the DesiredUpdateRate of the vtkRenderWindow that caused the Render
	/// falls at or above this rate, the render is considered interactive and
	/// the mapper may be adjusted (depending on the render mode).
	/// Initial value is 1.0.
	/// </summary>
	public virtual void SetInteractiveUpdateRate(double _arg)
	{
		vtkSmartVolumeMapper_SetInteractiveUpdateRate_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetInterpolationMode_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Set interpolation mode for downsampling (lowres GPU)
	/// (initial value: cubic).
	/// </summary>
	public virtual void SetInterpolationMode(int _arg)
	{
		vtkSmartVolumeMapper_SetInterpolationMode_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToCubic_58(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for downsampling (lowres GPU)
	/// (initial value: cubic).
	/// </summary>
	public void SetInterpolationModeToCubic()
	{
		vtkSmartVolumeMapper_SetInterpolationModeToCubic_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToLinear_59(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for downsampling (lowres GPU)
	/// (initial value: cubic).
	/// </summary>
	public void SetInterpolationModeToLinear()
	{
		vtkSmartVolumeMapper_SetInterpolationModeToLinear_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToNearestNeighbor_60(HandleRef pThis);

	/// <summary>
	/// Set interpolation mode for downsampling (lowres GPU)
	/// (initial value: cubic).
	/// </summary>
	public void SetInterpolationModeToNearestNeighbor()
	{
		vtkSmartVolumeMapper_SetInterpolationModeToNearestNeighbor_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetLowResMode_61(HandleRef pThis, int _arg);

	/// <summary>
	/// LowResDisable disables low res mode (default)
	/// LowResResample enable low res mode by automatically resampling the volume,
	/// this enable large volume to be displayed at higher frame rate at the cost of
	/// rendering quality
	/// Actual resample factor will be determined using MaxMemoryInBytes and MaxMemoryFraction
	/// </summary>
	public virtual void SetLowResMode(int _arg)
	{
		vtkSmartVolumeMapper_SetLowResMode_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetMaxMemoryFraction_62(HandleRef pThis, float _arg);

	/// <summary>
	/// Value passed to the GPU mapper. Ignored by other mappers.
	/// Maximum fraction of the MaxMemoryInBytes that should
	/// be used to hold the texture. Valid values are 0.1 to
	/// 1.0.
	/// </summary>
	public virtual void SetMaxMemoryFraction(float _arg)
	{
		vtkSmartVolumeMapper_SetMaxMemoryFraction_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetMaxMemoryInBytes_63(HandleRef pThis, long _arg);

	/// <summary>
	/// Value passed to the GPU mapper. Ignored by other mappers.
	/// Maximum size of the 3D texture in GPU memory.
	/// Will default to the size computed from the graphics
	/// card. Can be adjusted by the user.
	/// Useful if the automatic detection is defective or missing.
	/// </summary>
	public virtual void SetMaxMemoryInBytes(long _arg)
	{
		vtkSmartVolumeMapper_SetMaxMemoryInBytes_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetRequestedRenderMode_64(HandleRef pThis, int mode);

	/// <summary>
	/// Set the requested render mode. The default is
	/// vtkSmartVolumeMapper::DefaultRenderMode.
	/// </summary>
	public void SetRequestedRenderMode(int mode)
	{
		vtkSmartVolumeMapper_SetRequestedRenderMode_64(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToDefault_65(HandleRef pThis);

	/// <summary>
	/// Set the requested render mode to vtkSmartVolumeMapper::DefaultRenderMode.
	/// This is the best option for an application that must adapt to different
	/// data types, hardware, and rendering parameters.
	/// </summary>
	public void SetRequestedRenderModeToDefault()
	{
		vtkSmartVolumeMapper_SetRequestedRenderModeToDefault_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToGPU_66(HandleRef pThis);

	/// <summary>
	/// Set the requested render mode to vtkSmartVolumeMapper::GPURenderMode.
	/// This option will use hardware accelerated rendering exclusively. This is a
	/// good option if you know there is hardware acceleration.
	/// </summary>
	public void SetRequestedRenderModeToGPU()
	{
		vtkSmartVolumeMapper_SetRequestedRenderModeToGPU_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToOSPRay_67(HandleRef pThis);

	/// <summary>
	/// Set the requested render mode to vtkSmartVolumeMapper::OSPRayRenderMode.
	/// This option will use intel OSPRay to do software rendering exclusively.
	/// </summary>
	public void SetRequestedRenderModeToOSPRay()
	{
		vtkSmartVolumeMapper_SetRequestedRenderModeToOSPRay_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToRayCast_68(HandleRef pThis);

	/// <summary>
	/// Set the requested render mode to vtkSmartVolumeMapper::RayCastRenderMode.
	/// This option will use software rendering exclusively. This is a good option
	/// if you know there is no hardware acceleration.
	/// </summary>
	public void SetRequestedRenderModeToRayCast()
	{
		vtkSmartVolumeMapper_SetRequestedRenderModeToRayCast_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetSampleDistance_69(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the distance between samples used for rendering
	/// when AutoAdjustSampleDistances is off, or when this mapper
	/// has more than 1 second allocated to it for rendering.
	/// If SampleDistance is negative, it will be computed based on the dataset
	/// spacing. Initial value is -1.0.
	/// </summary>
	public virtual void SetSampleDistance(float _arg)
	{
		vtkSmartVolumeMapper_SetSampleDistance_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetTransfer2DYAxisArray_70(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the transfer 2D Y axis array
	/// </summary>
	public virtual void SetTransfer2DYAxisArray(string _arg)
	{
		vtkSmartVolumeMapper_SetTransfer2DYAxisArray_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetUseJittering_71(HandleRef pThis, int _arg);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect. This is only used by the GPU mapper.
	/// </summary>
	public virtual void SetUseJittering(int _arg)
	{
		vtkSmartVolumeMapper_SetUseJittering_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetVectorComponent_72(HandleRef pThis, int _arg);

	/// <summary>
	/// VectorMode is a special rendering mode for 3-component vectors which makes
	/// use of GPURayCastMapper's independent-component capabilities. In this mode,
	/// a single component in the vector can be selected for rendering. In addition,
	/// the mapper can compute a scalar field representing the magnitude of this vector
	/// using a vtkImageMagnitude object (MAGNITUDE mode).
	/// </summary>
	public virtual void SetVectorComponent(int _arg)
	{
		vtkSmartVolumeMapper_SetVectorComponent_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetVectorMode_73(HandleRef pThis, int mode);

	/// <summary>
	/// VectorMode is a special rendering mode for 3-component vectors which makes
	/// use of GPURayCastMapper's independent-component capabilities. In this mode,
	/// a single component in the vector can be selected for rendering. In addition,
	/// the mapper can compute a scalar field representing the magnitude of this vector
	/// using a vtkImageMagnitude object (MAGNITUDE mode).
	/// </summary>
	public void SetVectorMode(int mode)
	{
		vtkSmartVolumeMapper_SetVectorMode_73(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_SetVolumetricScatteringBlending_74(HandleRef pThis, float _arg);

	/// <summary>
	/// @copydoc vtkGPUVolumeRayCastMapper::SetVolumetricScatteringBlending(float)
	///
	/// This parameter is only used when the underlying mapper
	/// is a vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual void SetVolumetricScatteringBlending(float _arg)
	{
		vtkSmartVolumeMapper_SetVolumetricScatteringBlending_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_UseJitteringOff_75(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect. This is only used by the GPU mapper.
	/// </summary>
	public virtual void UseJitteringOff()
	{
		vtkSmartVolumeMapper_UseJitteringOff_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmartVolumeMapper_UseJitteringOn_76(HandleRef pThis);

	/// <summary>
	/// If UseJittering is on, each ray traversal direction will be
	/// perturbed slightly using a noise-texture to get rid of wood-grain
	/// effect. This is only used by the GPU mapper.
	/// </summary>
	public virtual void UseJitteringOn()
	{
		vtkSmartVolumeMapper_UseJitteringOn_76(GetCppThis());
	}
}
