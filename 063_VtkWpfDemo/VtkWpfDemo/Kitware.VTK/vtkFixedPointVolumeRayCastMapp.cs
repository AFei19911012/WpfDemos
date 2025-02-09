using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFixedPointVolumeRayCastMapper
/// </summary>
/// <remarks>
///    A fixed point mapper for volumes
///
/// This is a software ray caster for rendering volumes in vtkImageData.
/// It works with all input data types and up to four components. It performs
/// composite or MIP rendering, and can be intermixed with geometric data.
/// Space leaping is used to speed up the rendering process. In addition,
/// calculation are performed in 15 bit fixed point precision. This mapper
/// is threaded, and will interleave scan lines across processors.
///
/// WARNING: This ray caster may not produce consistent results when
/// the number of threads exceeds 1. The class warns if the number of
/// threads &gt; 1. The differences may be subtle. Applications should decide
/// if the trade-off in performance is worth the lack of consistency.
///
/// Other limitations of this ray caster include that:
///   - it does not do isosurface ray casting
///   - it does only interpolate before classify compositing
///   - it does only maximum scalar value MIP
///
/// This mapper handles all data type from unsigned char through double.
/// However, some of the internal calcultions are performed in float and
/// therefore even the full float range may cause problems for this mapper
/// (both in scalar data values and in spacing between samples).
///
/// Space leaping is performed by creating a sub-sampled volume. 4x4x4
/// cells in the original volume are represented by a min, max, and
/// combined gradient and flag value. The min max volume has three
/// unsigned shorts per 4x4x4 group of cells from the original volume -
/// one representing the minimum scalar index (the scalar value adjusted
/// to fit in the 15 bit range), the maximum scalar index, and a
/// third unsigned short which is both the maximum gradient opacity in
/// the neighborhood (an unsigned char) and the flag that is filled
/// in for the current lookup tables to indicate whether this region
/// can be skipped.
///
/// </remarks>
/// <seealso>
///
/// vtkVolumeMapper
/// </seealso>
public class vtkFixedPointVolumeRayCastMapper : vtkVolumeMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFixedPointVolumeRayCastMapper()
	{
		MRClassNameKey = "class vtkFixedPointVolumeRayCastMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFixedPointVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastMapper New()
	{
		vtkFixedPointVolumeRayCastMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFixedPointVolumeRayCastMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFixedPointVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFixedPointVolumeRayCastMapper_AbortRender_01(HandleRef pThis);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public void AbortRender()
	{
		vtkFixedPointVolumeRayCastMapper_AbortRender_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOff_02(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// and the SampleDistance will be varied to achieve the allocated
	/// render time of this prop (controlled by the desired update rate
	/// and any culling in use). If this is an interactive render (more
	/// than 1 frame per second) the SampleDistance will be increased,
	/// otherwise it will not be altered (a binary decision, as opposed
	/// to the ImageSampleDistance which will vary continuously).
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOff()
	{
		vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOn_03(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// and the SampleDistance will be varied to achieve the allocated
	/// render time of this prop (controlled by the desired update rate
	/// and any culling in use). If this is an interactive render (more
	/// than 1 frame per second) the SampleDistance will be increased,
	/// otherwise it will not be altered (a binary decision, as opposed
	/// to the ImageSampleDistance which will vary continuously).
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOn()
	{
		vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_CheckIfCropped_04(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public int CheckIfCropped(IntPtr pos)
	{
		return vtkFixedPointVolumeRayCastMapper_CheckIfCropped_04(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_CheckMIPMinMaxVolumeFlag_05(HandleRef pThis, IntPtr pos, int c, ushort maxIdx, int flip);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public int CheckMIPMinMaxVolumeFlag(IntPtr pos, int c, ushort maxIdx, int flip)
	{
		return vtkFixedPointVolumeRayCastMapper_CheckMIPMinMaxVolumeFlag_05(GetCppThis(), pos, c, maxIdx, flip);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_CheckMinMaxVolumeFlag_06(HandleRef pThis, IntPtr pos, int c);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public int CheckMinMaxVolumeFlag(IntPtr pos, int c)
	{
		return vtkFixedPointVolumeRayCastMapper_CheckMinMaxVolumeFlag_06(GetCppThis(), pos, c);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_ComputeRayInfo_07(HandleRef pThis, int x, int y, IntPtr pos, IntPtr dir, IntPtr numSteps);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void ComputeRayInfo(int x, int y, IntPtr pos, IntPtr dir, IntPtr numSteps)
	{
		vtkFixedPointVolumeRayCastMapper_ComputeRayInfo_07(GetCppThis(), x, y, pos, dir, numSteps);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_08(HandleRef pThis, float desiredTime, HandleRef ren);

	/// <summary>
	/// What is the image sample distance required to achieve the desired time?
	/// A version of this method is provided that does not require the volume
	/// argument since if you are using an LODProp3D you may not know this information.
	/// If you use this version you must be certain that the ray cast mapper is
	/// only used for one volume (and not shared among multiple volumes)
	/// </summary>
	public float ComputeRequiredImageSampleDistance(float desiredTime, vtkRenderer ren)
	{
		return vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_08(GetCppThis(), desiredTime, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_09(HandleRef pThis, float desiredTime, HandleRef ren, HandleRef vol);

	/// <summary>
	/// What is the image sample distance required to achieve the desired time?
	/// A version of this method is provided that does not require the volume
	/// argument since if you are using an LODProp3D you may not know this information.
	/// If you use this version you must be certain that the ray cast mapper is
	/// only used for one volume (and not shared among multiple volumes)
	/// </summary>
	public float ComputeRequiredImageSampleDistance(float desiredTime, vtkRenderer ren, vtkVolume vol)
	{
		return vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_09(GetCppThis(), desiredTime, ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_CreateCanonicalView_10(HandleRef pThis, HandleRef volume, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public void CreateCanonicalView(vtkVolume volume, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
	{
		vtkFixedPointVolumeRayCastMapper_CreateCanonicalView_10(GetCppThis(), volume?.GetCppThis() ?? default(HandleRef), image?.GetCppThis() ?? default(HandleRef), blend_mode, viewDirection, viewUp);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_DisplayRenderedImage_11(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public void DisplayRenderedImage(vtkRenderer arg0, vtkVolume arg1)
	{
		vtkFixedPointVolumeRayCastMapper_DisplayRenderedImage_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_FixedPointIncrement_12(HandleRef pThis, IntPtr position, IntPtr increment);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void FixedPointIncrement(IntPtr position, IntPtr increment)
	{
		vtkFixedPointVolumeRayCastMapper_FixedPointIncrement_12(GetCppThis(), position, increment);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistances_13(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// and the SampleDistance will be varied to achieve the allocated
	/// render time of this prop (controlled by the desired update rate
	/// and any culling in use). If this is an interactive render (more
	/// than 1 frame per second) the SampleDistance will be increased,
	/// otherwise it will not be altered (a binary decision, as opposed
	/// to the ImageSampleDistance which will vary continuously).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistances()
	{
		return vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistances_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_14(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// and the SampleDistance will be varied to achieve the allocated
	/// render time of this prop (controlled by the desired update rate
	/// and any culling in use). If this is an interactive render (more
	/// than 1 frame per second) the SampleDistance will be increased,
	/// otherwise it will not be altered (a binary decision, as opposed
	/// to the ImageSampleDistance which will vary continuously).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMaxValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_15(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// and the SampleDistance will be varied to achieve the allocated
	/// render time of this prop (controlled by the desired update rate
	/// and any culling in use). If this is an interactive render (more
	/// than 1 frame per second) the SampleDistance will be increased,
	/// otherwise it will not be altered (a binary decision, as opposed
	/// to the ImageSampleDistance which will vary continuously).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMinValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetColorTable_16(HandleRef pThis, int c);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public IntPtr GetColorTable(int c)
	{
		return vtkFixedPointVolumeRayCastMapper_GetColorTable_16(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeGOHelper_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual vtkFixedPointVolumeRayCastCompositeGOHelper GetCompositeGOHelper()
	{
		vtkFixedPointVolumeRayCastCompositeGOHelper vtkFixedPointVolumeRayCastCompositeGOHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetCompositeGOHelper_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper2 = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastCompositeGOHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastCompositeGOHelper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeGOShadeHelper_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual vtkFixedPointVolumeRayCastCompositeGOShadeHelper GetCompositeGOShadeHelper()
	{
		vtkFixedPointVolumeRayCastCompositeGOShadeHelper vtkFixedPointVolumeRayCastCompositeGOShadeHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetCompositeGOShadeHelper_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastCompositeGOShadeHelper2 = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastCompositeGOShadeHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastCompositeGOShadeHelper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeHelper_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual vtkFixedPointVolumeRayCastCompositeHelper GetCompositeHelper()
	{
		vtkFixedPointVolumeRayCastCompositeHelper vtkFixedPointVolumeRayCastCompositeHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetCompositeHelper_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastCompositeHelper2 = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastCompositeHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastCompositeHelper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeShadeHelper_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual vtkFixedPointVolumeRayCastCompositeShadeHelper GetCompositeShadeHelper()
	{
		vtkFixedPointVolumeRayCastCompositeShadeHelper vtkFixedPointVolumeRayCastCompositeShadeHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetCompositeShadeHelper_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastCompositeShadeHelper2 = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastCompositeShadeHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastCompositeShadeHelper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCurrentScalars_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual vtkDataArray GetCurrentScalars()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetCurrentScalars_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetDiffuseShadingTable_22(HandleRef pThis, int c);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public IntPtr GetDiffuseShadingTable(int c)
	{
		return vtkFixedPointVolumeRayCastMapper_GetDiffuseShadingTable_22(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_23(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// Get an estimate of the rendering time for a given volume / renderer.
	/// Only valid if this mapper has been used to render that volume for
	/// that renderer previously. Estimate is good when the viewing parameters
	/// have not changed much since that last render.
	/// </summary>
	public float GetEstimatedRenderTime(vtkRenderer ren, vtkVolume vol)
	{
		return vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_23(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_24(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Get an estimate of the rendering time for a given volume / renderer.
	/// Only valid if this mapper has been used to render that volume for
	/// that renderer previously. Estimate is good when the viewing parameters
	/// have not changed much since that last render.
	/// </summary>
	public float GetEstimatedRenderTime(vtkRenderer ren)
	{
		return vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_24(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetFinalColorLevel_25(HandleRef pThis);

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
		return vtkFixedPointVolumeRayCastMapper_GetFinalColorLevel_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetFinalColorWindow_26(HandleRef pThis);

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
		return vtkFixedPointVolumeRayCastMapper_GetFinalColorWindow_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetFlipMIPComparison_27(HandleRef pThis);

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
	public virtual int GetFlipMIPComparison()
	{
		return vtkFixedPointVolumeRayCastMapper_GetFlipMIPComparison_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_GetFloatTripleFromPointer_28(HandleRef pThis, IntPtr v, IntPtr ptr);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void GetFloatTripleFromPointer(IntPtr v, IntPtr ptr)
	{
		vtkFixedPointVolumeRayCastMapper_GetFloatTripleFromPointer_28(GetCppThis(), v, ptr);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetGradientOpacityRequired_29(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual int GetGradientOpacityRequired()
	{
		return vtkFixedPointVolumeRayCastMapper_GetGradientOpacityRequired_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetGradientOpacityTable_30(HandleRef pThis, int c);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public IntPtr GetGradientOpacityTable(int c)
	{
		return vtkFixedPointVolumeRayCastMapper_GetGradientOpacityTable_30(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistance_31(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
	/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
	/// is on.
	/// </summary>
	public virtual float GetImageSampleDistance()
	{
		return vtkFixedPointVolumeRayCastMapper_GetImageSampleDistance_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
	/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
	/// is on.
	/// </summary>
	public virtual float GetImageSampleDistanceMaxValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMinValue_33(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
	/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
	/// is on.
	/// </summary>
	public virtual float GetImageSampleDistanceMinValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetInteractiveSampleDistance_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the distance between samples when interactive rendering is happening.
	/// In this case, interactive is defined as this volume mapper having less than 1
	/// second allocated for rendering. When AutoAdjustSampleDistance is On, and the
	/// allocated render time is less than 1 second, then this InteractiveSampleDistance
	/// will be used instead of the SampleDistance above.
	/// </summary>
	public virtual float GetInteractiveSampleDistance()
	{
		return vtkFixedPointVolumeRayCastMapper_GetInteractiveSampleDistance_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometry_35(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometry()
	{
		return vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometry_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_36(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometryMaxValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_37(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometryMinValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_38(HandleRef pThis);

	/// <summary>
	/// Automatically compute the sample distance from the data spacing.  When
	/// the number of voxels is 8, the sample distance will be roughly 1/200
	/// the average voxel size. The distance will grow proportionally to
	/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
	/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
	/// account and if different than 1, will effect the sample distance.
	/// </summary>
	public virtual int GetLockSampleDistanceToInputSpacing()
	{
		return vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_39(HandleRef pThis);

	/// <summary>
	/// Automatically compute the sample distance from the data spacing.  When
	/// the number of voxels is 8, the sample distance will be roughly 1/200
	/// the average voxel size. The distance will grow proportionally to
	/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
	/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
	/// account and if different than 1, will effect the sample distance.
	/// </summary>
	public virtual int GetLockSampleDistanceToInputSpacingMaxValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_40(HandleRef pThis);

	/// <summary>
	/// Automatically compute the sample distance from the data spacing.  When
	/// the number of voxels is 8, the sample distance will be roughly 1/200
	/// the average voxel size. The distance will grow proportionally to
	/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
	/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
	/// account and if different than 1, will effect the sample distance.
	/// </summary>
	public virtual int GetLockSampleDistanceToInputSpacingMinValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetMIPHelper_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual vtkFixedPointVolumeRayCastMIPHelper GetMIPHelper()
	{
		vtkFixedPointVolumeRayCastMIPHelper vtkFixedPointVolumeRayCastMIPHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetMIPHelper_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastMIPHelper2 = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastMIPHelper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastMIPHelper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistance_42(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMaximumImageSampleDistance()
	{
		return vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistance_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_43(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMaximumImageSampleDistanceMaxValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_44(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMaximumImageSampleDistanceMinValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistance_45(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMinimumImageSampleDistance()
	{
		return vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistance_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_46(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMinimumImageSampleDistanceMaxValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_47(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual float GetMinimumImageSampleDistanceMinValue()
	{
		return vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastMapper_GetNumberOfGenerationsFromBase_48(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFixedPointVolumeRayCastMapper_GetNumberOfGenerationsFromBase_48(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_49(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFixedPointVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_49(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetNumberOfThreads_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of threads to use. This by default is equal to
	/// the number of available processors detected.
	/// WARNING: If number of threads &gt; 1, results may not be consistent.
	/// </summary>
	public int GetNumberOfThreads()
	{
		return vtkFixedPointVolumeRayCastMapper_GetNumberOfThreads_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetPreviousScalars_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual vtkDataArray GetPreviousScalars()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetPreviousScalars_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRayCastImage_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public virtual vtkFixedPointRayCastImage GetRayCastImage()
	{
		vtkFixedPointRayCastImage vtkFixedPointRayCastImage2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetRayCastImage_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointRayCastImage2 = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointRayCastImage2.Register(null);
			}
		}
		return vtkFixedPointRayCastImage2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRenderWindow_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual vtkRenderWindow GetRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetRenderWindow_53(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRowBounds_54(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public IntPtr GetRowBounds()
	{
		return vtkFixedPointVolumeRayCastMapper_GetRowBounds_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointVolumeRayCastMapper_GetSampleDistance_55(HandleRef pThis);

	/// <summary>
	/// Set/Get the distance between samples used for rendering
	/// when AutoAdjustSampleDistances is off, or when this mapper
	/// has more than 1 second allocated to it for rendering.
	/// </summary>
	public virtual float GetSampleDistance()
	{
		return vtkFixedPointVolumeRayCastMapper_GetSampleDistance_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetScalarOpacityTable_56(HandleRef pThis, int c);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public IntPtr GetScalarOpacityTable(int c)
	{
		return vtkFixedPointVolumeRayCastMapper_GetScalarOpacityTable_56(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_GetShadingRequired_57(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual int GetShadingRequired()
	{
		return vtkFixedPointVolumeRayCastMapper_GetShadingRequired_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetSpecularShadingTable_58(HandleRef pThis, int c);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public IntPtr GetSpecularShadingTable(int c)
	{
		return vtkFixedPointVolumeRayCastMapper_GetSpecularShadingTable_58(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetTableScale_59(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual float[] GetTableScale()
	{
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetTableScale_59(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_GetTableScale_60(HandleRef pThis, IntPtr data);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual void GetTableScale(IntPtr data)
	{
		vtkFixedPointVolumeRayCastMapper_GetTableScale_60(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetTableShift_61(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual float[] GetTableShift()
	{
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetTableShift_61(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_GetTableShift_62(HandleRef pThis, IntPtr data);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public virtual void GetTableShift(IntPtr data)
	{
		vtkFixedPointVolumeRayCastMapper_GetTableShift_62(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_GetUIntTripleFromPointer_63(HandleRef pThis, IntPtr v, IntPtr ptr);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void GetUIntTripleFromPointer(IntPtr v, IntPtr ptr)
	{
		vtkFixedPointVolumeRayCastMapper_GetUIntTripleFromPointer_63(GetCppThis(), v, ptr);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetVolume_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public vtkVolume GetVolume()
	{
		vtkVolume vtkVolume2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_GetVolume_64(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolume2 = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolume2.Register(null);
			}
		}
		return vtkVolume2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_InitializeRayInfo_65(HandleRef pThis, HandleRef vol);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void InitializeRayInfo(vtkVolume vol)
	{
		vtkFixedPointVolumeRayCastMapper_InitializeRayInfo_65(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOff_66(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void IntermixIntersectingGeometryOff()
	{
		vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOff_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOn_67(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void IntermixIntersectingGeometryOn()
	{
		vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOn_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_IsA_68(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFixedPointVolumeRayCastMapper_IsA_68(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_IsTypeOf_69(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFixedPointVolumeRayCastMapper_IsTypeOf_69(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_70(HandleRef pThis);

	/// <summary>
	/// Automatically compute the sample distance from the data spacing.  When
	/// the number of voxels is 8, the sample distance will be roughly 1/200
	/// the average voxel size. The distance will grow proportionally to
	/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
	/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
	/// account and if different than 1, will effect the sample distance.
	/// </summary>
	public virtual void LockSampleDistanceToInputSpacingOff()
	{
		vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_71(HandleRef pThis);

	/// <summary>
	/// Automatically compute the sample distance from the data spacing.  When
	/// the number of voxels is 8, the sample distance will be roughly 1/200
	/// the average voxel size. The distance will grow proportionally to
	/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
	/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
	/// account and if different than 1, will effect the sample distance.
	/// </summary>
	public virtual void LockSampleDistanceToInputSpacingOn()
	{
		vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_LookupColorUC_72(HandleRef pThis, IntPtr colorTable, IntPtr scalarOpacityTable, ushort index, IntPtr color);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void LookupColorUC(IntPtr colorTable, IntPtr scalarOpacityTable, ushort index, IntPtr color)
	{
		vtkFixedPointVolumeRayCastMapper_LookupColorUC_72(GetCppThis(), colorTable, scalarOpacityTable, index, color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_LookupDependentColorUC_73(HandleRef pThis, IntPtr colorTable, IntPtr scalarOpacityTable, IntPtr index, int components, IntPtr color);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void LookupDependentColorUC(IntPtr colorTable, IntPtr scalarOpacityTable, IntPtr index, int components, IntPtr color)
	{
		vtkFixedPointVolumeRayCastMapper_LookupDependentColorUC_73(GetCppThis(), colorTable, scalarOpacityTable, index, components, color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_NewInstance_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFixedPointVolumeRayCastMapper NewInstance()
	{
		vtkFixedPointVolumeRayCastMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_NewInstance_75(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_PerImageInitialization_76(HandleRef pThis, HandleRef arg0, HandleRef arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public int PerImageInitialization(vtkRenderer arg0, vtkVolume arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5)
	{
		return vtkFixedPointVolumeRayCastMapper_PerImageInitialization_76(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3, arg4, arg5);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_PerSubVolumeInitialization_77(HandleRef pThis, HandleRef arg0, HandleRef arg1, int arg2);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public void PerSubVolumeInitialization(vtkRenderer arg0, vtkVolume arg1, int arg2)
	{
		vtkFixedPointVolumeRayCastMapper_PerSubVolumeInitialization_77(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_PerVolumeInitialization_78(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public void PerVolumeInitialization(vtkRenderer arg0, vtkVolume arg1)
	{
		vtkFixedPointVolumeRayCastMapper_PerVolumeInitialization_78(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_ReleaseGraphicsResources_79(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Release any graphics resources that are being consumed by this mapper.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkFixedPointVolumeRayCastMapper_ReleaseGraphicsResources_79(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_Render_80(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public override void Render(vtkRenderer arg0, vtkVolume arg1)
	{
		vtkFixedPointVolumeRayCastMapper_Render_80(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_RenderSubVolume_81(HandleRef pThis);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public void RenderSubVolume()
	{
		vtkFixedPointVolumeRayCastMapper_RenderSubVolume_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_SafeDownCast_82(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
	{
		vtkFixedPointVolumeRayCastMapper vtkFixedPointVolumeRayCastMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointVolumeRayCastMapper_SafeDownCast_82(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointVolumeRayCastMapper2 = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointVolumeRayCastMapper2.Register(null);
			}
		}
		return vtkFixedPointVolumeRayCastMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetAutoAdjustSampleDistances_83(HandleRef pThis, int _arg);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// and the SampleDistance will be varied to achieve the allocated
	/// render time of this prop (controlled by the desired update rate
	/// and any culling in use). If this is an interactive render (more
	/// than 1 frame per second) the SampleDistance will be increased,
	/// otherwise it will not be altered (a binary decision, as opposed
	/// to the ImageSampleDistance which will vary continuously).
	/// </summary>
	public virtual void SetAutoAdjustSampleDistances(int _arg)
	{
		vtkFixedPointVolumeRayCastMapper_SetAutoAdjustSampleDistances_83(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetFinalColorLevel_84(HandleRef pThis, float _arg);

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
		vtkFixedPointVolumeRayCastMapper_SetFinalColorLevel_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetFinalColorWindow_85(HandleRef pThis, float _arg);

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
		vtkFixedPointVolumeRayCastMapper_SetFinalColorWindow_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetImageSampleDistance_86(HandleRef pThis, float _arg);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels. This value
	/// will be adjusted to meet a desired frame rate when AutoAdjustSampleDistances
	/// is on.
	/// </summary>
	public virtual void SetImageSampleDistance(float _arg)
	{
		vtkFixedPointVolumeRayCastMapper_SetImageSampleDistance_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetInteractiveSampleDistance_87(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the distance between samples when interactive rendering is happening.
	/// In this case, interactive is defined as this volume mapper having less than 1
	/// second allocated for rendering. When AutoAdjustSampleDistance is On, and the
	/// allocated render time is less than 1 second, then this InteractiveSampleDistance
	/// will be used instead of the SampleDistance above.
	/// </summary>
	public virtual void SetInteractiveSampleDistance(float _arg)
	{
		vtkFixedPointVolumeRayCastMapper_SetInteractiveSampleDistance_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetIntermixIntersectingGeometry_88(HandleRef pThis, int _arg);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void SetIntermixIntersectingGeometry(int _arg)
	{
		vtkFixedPointVolumeRayCastMapper_SetIntermixIntersectingGeometry_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_89(HandleRef pThis, int _arg);

	/// <summary>
	/// Automatically compute the sample distance from the data spacing.  When
	/// the number of voxels is 8, the sample distance will be roughly 1/200
	/// the average voxel size. The distance will grow proportionally to
	/// numVoxels^(1/3) until it reaches 1/2 average voxel size when number of
	/// voxels is 1E6. Note that ScalarOpacityUnitDistance is still taken into
	/// account and if different than 1, will effect the sample distance.
	/// </summary>
	public virtual void SetLockSampleDistanceToInputSpacing(int _arg)
	{
		vtkFixedPointVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetMaximumImageSampleDistance_90(HandleRef pThis, float _arg);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual void SetMaximumImageSampleDistance(float _arg)
	{
		vtkFixedPointVolumeRayCastMapper_SetMaximumImageSampleDistance_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetMinimumImageSampleDistance_91(HandleRef pThis, float _arg);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted.
	/// </summary>
	public virtual void SetMinimumImageSampleDistance(float _arg)
	{
		vtkFixedPointVolumeRayCastMapper_SetMinimumImageSampleDistance_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetNumberOfThreads_92(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the number of threads to use. This by default is equal to
	/// the number of available processors detected.
	/// WARNING: If number of threads &gt; 1, results may not be consistent.
	/// </summary>
	public void SetNumberOfThreads(int num)
	{
		vtkFixedPointVolumeRayCastMapper_SetNumberOfThreads_92(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetRayCastImage_93(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / Get the underlying image object. One will be automatically
	/// created - only need to set it when using from an AMR mapper which
	/// renders multiple times into the same image.
	/// </summary>
	public void SetRayCastImage(vtkFixedPointRayCastImage arg0)
	{
		vtkFixedPointVolumeRayCastMapper_SetRayCastImage_93(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_SetSampleDistance_94(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the distance between samples used for rendering
	/// when AutoAdjustSampleDistances is off, or when this mapper
	/// has more than 1 second allocated to it for rendering.
	/// </summary>
	public virtual void SetSampleDistance(float _arg)
	{
		vtkFixedPointVolumeRayCastMapper_SetSampleDistance_94(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_ShiftVectorDown_95(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void ShiftVectorDown(IntPtr arg0, IntPtr arg1)
	{
		vtkFixedPointVolumeRayCastMapper_ShiftVectorDown_95(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointVolumeRayCastMapper_ShouldUseNearestNeighborInterpolation_96(HandleRef pThis, HandleRef vol);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public int ShouldUseNearestNeighborInterpolation(vtkVolume vol)
	{
		return vtkFixedPointVolumeRayCastMapper_ShouldUseNearestNeighborInterpolation_96(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_97(HandleRef pThis, float dir);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public uint ToFixedPointDirection(float dir)
	{
		return vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_97(GetCppThis(), dir);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_98(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void ToFixedPointDirection(IntPtr arg0, IntPtr arg1)
	{
		vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_98(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_99(HandleRef pThis, float val);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public uint ToFixedPointPosition(float val)
	{
		return vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_99(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_100(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// Initialize rendering for this volume.
	/// </summary>
	public void ToFixedPointPosition(IntPtr arg0, IntPtr arg1)
	{
		vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_100(GetCppThis(), arg0, arg1);
	}
}
