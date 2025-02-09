using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFXAAOptions
/// </summary>
/// <remarks>
///    Configuration for FXAA implementations.
///
///
/// This class encapsulates the settings for vtkOpenGLFXAAFilter.
/// </remarks>
public class vtkFXAAOptions : vtkObject
{
	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public enum DebugOption
	{
		/// <summary>enum member</summary>
		FXAA_DEBUG_EDGE_DIRECTION = 2,
		/// <summary>enum member</summary>
		FXAA_DEBUG_EDGE_DISTANCE = 4,
		/// <summary>enum member</summary>
		FXAA_DEBUG_EDGE_NUM_STEPS = 3,
		/// <summary>enum member</summary>
		FXAA_DEBUG_EDGE_SAMPLE_OFFSET = 5,
		/// <summary>enum member</summary>
		FXAA_DEBUG_ONLY_EDGE_AA = 7,
		/// <summary>enum member</summary>
		FXAA_DEBUG_ONLY_SUBPIX_AA = 6,
		/// <summary>enum member</summary>
		FXAA_DEBUG_SUBPIXEL_ALIASING = 1,
		/// <summary>enum member</summary>
		FXAA_NO_DEBUG = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFXAAOptions";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFXAAOptions()
	{
		MRClassNameKey = "class vtkFXAAOptions";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFXAAOptions"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFXAAOptions(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFXAAOptions_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public new static vtkFXAAOptions New()
	{
		vtkFXAAOptions result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFXAAOptions_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public vtkFXAAOptions()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFXAAOptions_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DebugOption vtkFXAAOptions_GetDebugOptionValue_01(HandleRef pThis);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details. Only one may be active at a time.
	/// </summary>
	public virtual DebugOption GetDebugOptionValue()
	{
		return vtkFXAAOptions_GetDebugOptionValue_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFXAAOptions_GetEndpointSearchIterations_02(HandleRef pThis);

	/// <summary>
	/// Set the number of iterations for the endpoint search algorithm. Increasing
	/// this value will increase runtime, but also properly detect longer edges.
	/// The current implementation steps one pixel in both the positive and
	/// negative directions per iteration. The default value is 12, which will
	/// resolve endpoints of edges &lt; 25 pixels long (2 * 12 + 1).
	/// </summary>
	public virtual int GetEndpointSearchIterations()
	{
		return vtkFXAAOptions_GetEndpointSearchIterations_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFXAAOptions_GetEndpointSearchIterationsMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set the number of iterations for the endpoint search algorithm. Increasing
	/// this value will increase runtime, but also properly detect longer edges.
	/// The current implementation steps one pixel in both the positive and
	/// negative directions per iteration. The default value is 12, which will
	/// resolve endpoints of edges &lt; 25 pixels long (2 * 12 + 1).
	/// </summary>
	public virtual int GetEndpointSearchIterationsMaxValue()
	{
		return vtkFXAAOptions_GetEndpointSearchIterationsMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFXAAOptions_GetEndpointSearchIterationsMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set the number of iterations for the endpoint search algorithm. Increasing
	/// this value will increase runtime, but also properly detect longer edges.
	/// The current implementation steps one pixel in both the positive and
	/// negative directions per iteration. The default value is 12, which will
	/// resolve endpoints of edges &lt; 25 pixels long (2 * 12 + 1).
	/// </summary>
	public virtual int GetEndpointSearchIterationsMinValue()
	{
		return vtkFXAAOptions_GetEndpointSearchIterationsMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetHardContrastThreshold_05(HandleRef pThis);

	/// <summary>
	/// Similar to RelativeContrastThreshold, but not scaled by the maximum
	/// luminosity.
	///
	/// If the contrast of the current pixel and it's 4 immediate NSWE neighbors is
	/// less than HardContrastThreshold, the pixel is not considered aliased and
	/// will not be affected by FXAA.
	///
	/// Suggested settings:
	/// - 1/32: Visible limit
	/// - 1/16: High quality (default)
	/// - 1/12: Upper limit (start of visible unfiltered edges)
	/// </summary>
	public virtual float GetHardContrastThreshold()
	{
		return vtkFXAAOptions_GetHardContrastThreshold_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetHardContrastThresholdMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Similar to RelativeContrastThreshold, but not scaled by the maximum
	/// luminosity.
	///
	/// If the contrast of the current pixel and it's 4 immediate NSWE neighbors is
	/// less than HardContrastThreshold, the pixel is not considered aliased and
	/// will not be affected by FXAA.
	///
	/// Suggested settings:
	/// - 1/32: Visible limit
	/// - 1/16: High quality (default)
	/// - 1/12: Upper limit (start of visible unfiltered edges)
	/// </summary>
	public virtual float GetHardContrastThresholdMaxValue()
	{
		return vtkFXAAOptions_GetHardContrastThresholdMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetHardContrastThresholdMinValue_07(HandleRef pThis);

	/// <summary>
	/// Similar to RelativeContrastThreshold, but not scaled by the maximum
	/// luminosity.
	///
	/// If the contrast of the current pixel and it's 4 immediate NSWE neighbors is
	/// less than HardContrastThreshold, the pixel is not considered aliased and
	/// will not be affected by FXAA.
	///
	/// Suggested settings:
	/// - 1/32: Visible limit
	/// - 1/16: High quality (default)
	/// - 1/12: Upper limit (start of visible unfiltered edges)
	/// </summary>
	public virtual float GetHardContrastThresholdMinValue()
	{
		return vtkFXAAOptions_GetHardContrastThresholdMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFXAAOptions_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFXAAOptions_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFXAAOptions_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFXAAOptions_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetRelativeContrastThreshold_10(HandleRef pThis);

	/// <summary>
	/// Threshold for applying FXAA to a pixel, relative to the maximum luminosity
	/// of its 4 immediate neighbors.
	///
	/// The luminosity of the current pixel and it's NSWE neighbors is computed.
	/// The maximum luminosity and luminosity range (contrast) of all 5 pixels is
	/// found. If the contrast is less than RelativeContrastThreshold * maxLum,
	/// the pixel is not considered aliased and will not be affected by FXAA.
	///
	/// Suggested settings:
	/// - 1/3: Too little
	/// - 1/4: Low quality
	/// - 1/8: High quality (default)
	/// - 1/16: Overkill
	/// </summary>
	public virtual float GetRelativeContrastThreshold()
	{
		return vtkFXAAOptions_GetRelativeContrastThreshold_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetRelativeContrastThresholdMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Threshold for applying FXAA to a pixel, relative to the maximum luminosity
	/// of its 4 immediate neighbors.
	///
	/// The luminosity of the current pixel and it's NSWE neighbors is computed.
	/// The maximum luminosity and luminosity range (contrast) of all 5 pixels is
	/// found. If the contrast is less than RelativeContrastThreshold * maxLum,
	/// the pixel is not considered aliased and will not be affected by FXAA.
	///
	/// Suggested settings:
	/// - 1/3: Too little
	/// - 1/4: Low quality
	/// - 1/8: High quality (default)
	/// - 1/16: Overkill
	/// </summary>
	public virtual float GetRelativeContrastThresholdMaxValue()
	{
		return vtkFXAAOptions_GetRelativeContrastThresholdMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetRelativeContrastThresholdMinValue_12(HandleRef pThis);

	/// <summary>
	/// Threshold for applying FXAA to a pixel, relative to the maximum luminosity
	/// of its 4 immediate neighbors.
	///
	/// The luminosity of the current pixel and it's NSWE neighbors is computed.
	/// The maximum luminosity and luminosity range (contrast) of all 5 pixels is
	/// found. If the contrast is less than RelativeContrastThreshold * maxLum,
	/// the pixel is not considered aliased and will not be affected by FXAA.
	///
	/// Suggested settings:
	/// - 1/3: Too little
	/// - 1/4: Low quality
	/// - 1/8: High quality (default)
	/// - 1/16: Overkill
	/// </summary>
	public virtual float GetRelativeContrastThresholdMinValue()
	{
		return vtkFXAAOptions_GetRelativeContrastThresholdMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetSubpixelBlendLimit_13(HandleRef pThis);

	/// <summary>
	/// Subpixel aliasing is corrected by applying a lowpass filter to the current
	/// pixel. This is implemented by blending an average of the 3x3 neighborhood
	/// around the pixel into the final result. The amount of blending is
	/// determined by comparing the detected amount of subpixel aliasing to the
	/// total contrasting of the CNSWE pixels:
	///
	/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
	///
	/// This parameter sets an upper limit to the amount of subpixel blending to
	/// prevent the image from simply getting blurred.
	///
	/// Suggested settings:
	/// - 1/2: Low amount of blending.
	/// - 3/4: Medium amount of blending (default)
	/// - 7/8: High amount of blending.
	/// - 1: Maximum amount of blending.
	/// </summary>
	public virtual float GetSubpixelBlendLimit()
	{
		return vtkFXAAOptions_GetSubpixelBlendLimit_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetSubpixelBlendLimitMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Subpixel aliasing is corrected by applying a lowpass filter to the current
	/// pixel. This is implemented by blending an average of the 3x3 neighborhood
	/// around the pixel into the final result. The amount of blending is
	/// determined by comparing the detected amount of subpixel aliasing to the
	/// total contrasting of the CNSWE pixels:
	///
	/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
	///
	/// This parameter sets an upper limit to the amount of subpixel blending to
	/// prevent the image from simply getting blurred.
	///
	/// Suggested settings:
	/// - 1/2: Low amount of blending.
	/// - 3/4: Medium amount of blending (default)
	/// - 7/8: High amount of blending.
	/// - 1: Maximum amount of blending.
	/// </summary>
	public virtual float GetSubpixelBlendLimitMaxValue()
	{
		return vtkFXAAOptions_GetSubpixelBlendLimitMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetSubpixelBlendLimitMinValue_15(HandleRef pThis);

	/// <summary>
	/// Subpixel aliasing is corrected by applying a lowpass filter to the current
	/// pixel. This is implemented by blending an average of the 3x3 neighborhood
	/// around the pixel into the final result. The amount of blending is
	/// determined by comparing the detected amount of subpixel aliasing to the
	/// total contrasting of the CNSWE pixels:
	///
	/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
	///
	/// This parameter sets an upper limit to the amount of subpixel blending to
	/// prevent the image from simply getting blurred.
	///
	/// Suggested settings:
	/// - 1/2: Low amount of blending.
	/// - 3/4: Medium amount of blending (default)
	/// - 7/8: High amount of blending.
	/// - 1: Maximum amount of blending.
	/// </summary>
	public virtual float GetSubpixelBlendLimitMinValue()
	{
		return vtkFXAAOptions_GetSubpixelBlendLimitMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetSubpixelContrastThreshold_16(HandleRef pThis);

	/// <summary>
	/// Minimum amount of subpixel aliasing required for subpixel antialiasing to
	/// be applied.
	///
	/// Subpixel aliasing is corrected by applying a lowpass filter to the current
	/// pixel. This is implemented by blending an average of the 3x3 neighborhood
	/// around the pixel into the final result. The amount of blending is
	/// determined by comparing the detected amount of subpixel aliasing to the
	/// total contrasting of the CNSWE pixels:
	///
	/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
	///
	/// If SubpixelBlending is less than this threshold, no lowpass blending will
	/// occur.
	///
	/// Suggested settings:
	/// - 1/2: Low subpixel aliasing removal
	/// - 1/3: Medium subpixel aliasing removal
	/// - 1/4: Default subpixel aliasing removal
	/// - 1/8: High subpixel aliasing removal
	/// - 0: Complete subpixel aliasing removal
	/// </summary>
	public virtual float GetSubpixelContrastThreshold()
	{
		return vtkFXAAOptions_GetSubpixelContrastThreshold_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetSubpixelContrastThresholdMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Minimum amount of subpixel aliasing required for subpixel antialiasing to
	/// be applied.
	///
	/// Subpixel aliasing is corrected by applying a lowpass filter to the current
	/// pixel. This is implemented by blending an average of the 3x3 neighborhood
	/// around the pixel into the final result. The amount of blending is
	/// determined by comparing the detected amount of subpixel aliasing to the
	/// total contrasting of the CNSWE pixels:
	///
	/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
	///
	/// If SubpixelBlending is less than this threshold, no lowpass blending will
	/// occur.
	///
	/// Suggested settings:
	/// - 1/2: Low subpixel aliasing removal
	/// - 1/3: Medium subpixel aliasing removal
	/// - 1/4: Default subpixel aliasing removal
	/// - 1/8: High subpixel aliasing removal
	/// - 0: Complete subpixel aliasing removal
	/// </summary>
	public virtual float GetSubpixelContrastThresholdMaxValue()
	{
		return vtkFXAAOptions_GetSubpixelContrastThresholdMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFXAAOptions_GetSubpixelContrastThresholdMinValue_18(HandleRef pThis);

	/// <summary>
	/// Minimum amount of subpixel aliasing required for subpixel antialiasing to
	/// be applied.
	///
	/// Subpixel aliasing is corrected by applying a lowpass filter to the current
	/// pixel. This is implemented by blending an average of the 3x3 neighborhood
	/// around the pixel into the final result. The amount of blending is
	/// determined by comparing the detected amount of subpixel aliasing to the
	/// total contrasting of the CNSWE pixels:
	///
	/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
	///
	/// If SubpixelBlending is less than this threshold, no lowpass blending will
	/// occur.
	///
	/// Suggested settings:
	/// - 1/2: Low subpixel aliasing removal
	/// - 1/3: Medium subpixel aliasing removal
	/// - 1/4: Default subpixel aliasing removal
	/// - 1/8: High subpixel aliasing removal
	/// - 0: Complete subpixel aliasing removal
	/// </summary>
	public virtual float GetSubpixelContrastThresholdMinValue()
	{
		return vtkFXAAOptions_GetSubpixelContrastThresholdMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFXAAOptions_GetUseHighQualityEndpoints_19(HandleRef pThis);

	/// <summary>
	/// Use an improved edge endpoint detection algorithm.
	///
	/// If true, a modified edge endpoint detection algorithm is used that requires
	/// more texture lookups, but will properly detect aliased single-pixel lines.
	///
	/// If false, the edge endpoint algorithm proposed by NVIDIA will by used. This
	/// algorithm is faster (fewer lookups), but will fail to detect endpoints of
	/// single pixel edge steps.
	///
	/// Default setting is true.
	/// </summary>
	public virtual bool GetUseHighQualityEndpoints()
	{
		return (vtkFXAAOptions_GetUseHighQualityEndpoints_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFXAAOptions_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFXAAOptions_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFXAAOptions_IsTypeOf_21(string type);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFXAAOptions_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFXAAOptions_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public new vtkFXAAOptions NewInstance()
	{
		vtkFXAAOptions result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFXAAOptions_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFXAAOptions_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details.
	/// </summary>
	public new static vtkFXAAOptions SafeDownCast(vtkObjectBase o)
	{
		vtkFXAAOptions vtkFXAAOptions2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFXAAOptions_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFXAAOptions2 = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFXAAOptions2.Register(null);
			}
		}
		return vtkFXAAOptions2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_SetDebugOptionValue_25(HandleRef pThis, DebugOption _arg);

	/// <summary>
	/// Debugging options that affect the output color buffer. See
	/// vtkFXAAFilterFS.glsl for details. Only one may be active at a time.
	/// </summary>
	public virtual void SetDebugOptionValue(DebugOption _arg)
	{
		vtkFXAAOptions_SetDebugOptionValue_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_SetEndpointSearchIterations_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of iterations for the endpoint search algorithm. Increasing
	/// this value will increase runtime, but also properly detect longer edges.
	/// The current implementation steps one pixel in both the positive and
	/// negative directions per iteration. The default value is 12, which will
	/// resolve endpoints of edges &lt; 25 pixels long (2 * 12 + 1).
	/// </summary>
	public virtual void SetEndpointSearchIterations(int _arg)
	{
		vtkFXAAOptions_SetEndpointSearchIterations_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_SetHardContrastThreshold_27(HandleRef pThis, float _arg);

	/// <summary>
	/// Similar to RelativeContrastThreshold, but not scaled by the maximum
	/// luminosity.
	///
	/// If the contrast of the current pixel and it's 4 immediate NSWE neighbors is
	/// less than HardContrastThreshold, the pixel is not considered aliased and
	/// will not be affected by FXAA.
	///
	/// Suggested settings:
	/// - 1/32: Visible limit
	/// - 1/16: High quality (default)
	/// - 1/12: Upper limit (start of visible unfiltered edges)
	/// </summary>
	public virtual void SetHardContrastThreshold(float _arg)
	{
		vtkFXAAOptions_SetHardContrastThreshold_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_SetRelativeContrastThreshold_28(HandleRef pThis, float _arg);

	/// <summary>
	/// Threshold for applying FXAA to a pixel, relative to the maximum luminosity
	/// of its 4 immediate neighbors.
	///
	/// The luminosity of the current pixel and it's NSWE neighbors is computed.
	/// The maximum luminosity and luminosity range (contrast) of all 5 pixels is
	/// found. If the contrast is less than RelativeContrastThreshold * maxLum,
	/// the pixel is not considered aliased and will not be affected by FXAA.
	///
	/// Suggested settings:
	/// - 1/3: Too little
	/// - 1/4: Low quality
	/// - 1/8: High quality (default)
	/// - 1/16: Overkill
	/// </summary>
	public virtual void SetRelativeContrastThreshold(float _arg)
	{
		vtkFXAAOptions_SetRelativeContrastThreshold_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_SetSubpixelBlendLimit_29(HandleRef pThis, float _arg);

	/// <summary>
	/// Subpixel aliasing is corrected by applying a lowpass filter to the current
	/// pixel. This is implemented by blending an average of the 3x3 neighborhood
	/// around the pixel into the final result. The amount of blending is
	/// determined by comparing the detected amount of subpixel aliasing to the
	/// total contrasting of the CNSWE pixels:
	///
	/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
	///
	/// This parameter sets an upper limit to the amount of subpixel blending to
	/// prevent the image from simply getting blurred.
	///
	/// Suggested settings:
	/// - 1/2: Low amount of blending.
	/// - 3/4: Medium amount of blending (default)
	/// - 7/8: High amount of blending.
	/// - 1: Maximum amount of blending.
	/// </summary>
	public virtual void SetSubpixelBlendLimit(float _arg)
	{
		vtkFXAAOptions_SetSubpixelBlendLimit_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_SetSubpixelContrastThreshold_30(HandleRef pThis, float _arg);

	/// <summary>
	/// Minimum amount of subpixel aliasing required for subpixel antialiasing to
	/// be applied.
	///
	/// Subpixel aliasing is corrected by applying a lowpass filter to the current
	/// pixel. This is implemented by blending an average of the 3x3 neighborhood
	/// around the pixel into the final result. The amount of blending is
	/// determined by comparing the detected amount of subpixel aliasing to the
	/// total contrasting of the CNSWE pixels:
	///
	/// SubpixelBlending = abs(lumC - lumAveNSWE) / (lumMaxCNSWE - lumMinCNSWE)
	///
	/// If SubpixelBlending is less than this threshold, no lowpass blending will
	/// occur.
	///
	/// Suggested settings:
	/// - 1/2: Low subpixel aliasing removal
	/// - 1/3: Medium subpixel aliasing removal
	/// - 1/4: Default subpixel aliasing removal
	/// - 1/8: High subpixel aliasing removal
	/// - 0: Complete subpixel aliasing removal
	/// </summary>
	public virtual void SetSubpixelContrastThreshold(float _arg)
	{
		vtkFXAAOptions_SetSubpixelContrastThreshold_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_SetUseHighQualityEndpoints_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use an improved edge endpoint detection algorithm.
	///
	/// If true, a modified edge endpoint detection algorithm is used that requires
	/// more texture lookups, but will properly detect aliased single-pixel lines.
	///
	/// If false, the edge endpoint algorithm proposed by NVIDIA will by used. This
	/// algorithm is faster (fewer lookups), but will fail to detect endpoints of
	/// single pixel edge steps.
	///
	/// Default setting is true.
	/// </summary>
	public virtual void SetUseHighQualityEndpoints(bool _arg)
	{
		vtkFXAAOptions_SetUseHighQualityEndpoints_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_UseHighQualityEndpointsOff_32(HandleRef pThis);

	/// <summary>
	/// Use an improved edge endpoint detection algorithm.
	///
	/// If true, a modified edge endpoint detection algorithm is used that requires
	/// more texture lookups, but will properly detect aliased single-pixel lines.
	///
	/// If false, the edge endpoint algorithm proposed by NVIDIA will by used. This
	/// algorithm is faster (fewer lookups), but will fail to detect endpoints of
	/// single pixel edge steps.
	///
	/// Default setting is true.
	/// </summary>
	public virtual void UseHighQualityEndpointsOff()
	{
		vtkFXAAOptions_UseHighQualityEndpointsOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFXAAOptions_UseHighQualityEndpointsOn_33(HandleRef pThis);

	/// <summary>
	/// Use an improved edge endpoint detection algorithm.
	///
	/// If true, a modified edge endpoint detection algorithm is used that requires
	/// more texture lookups, but will properly detect aliased single-pixel lines.
	///
	/// If false, the edge endpoint algorithm proposed by NVIDIA will by used. This
	/// algorithm is faster (fewer lookups), but will fail to detect endpoints of
	/// single pixel edge steps.
	///
	/// Default setting is true.
	/// </summary>
	public virtual void UseHighQualityEndpointsOn()
	{
		vtkFXAAOptions_UseHighQualityEndpointsOn_33(GetCppThis());
	}
}
