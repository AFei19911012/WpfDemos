using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLFXAAFilter
/// </summary>
/// <remarks>
///    Perform FXAA antialiasing on the current
/// framebuffer.
///
///
/// Call Execute() to run a FXAA antialiasing pass on the current OpenGL
/// framebuffer. See method documentation for tunable parameters.
///
/// Based on the following implementation and description:
///
/// Whitepaper:
/// http://developer.download.nvidia.com/assets/gamedev/files/sdk/11/FXAA_WhitePaper.pdf
///
/// Sample implementation:
/// https://github.com/NVIDIAGameWorks/GraphicsSamples/blob/master/samples/es3-kepler/FXAA/FXAA3_11.h
///
/// TODO there are currently some "banding" artifacts on some edges, particularly
/// single pixel lines. These seem to be caused by using a linear RGB input,
/// rather than a gamma-correct sRGB input. Future work should combine this pass
/// with a gamma correction pass to correct this. Bonus points for precomputing
/// luminosity into the sRGB's alpha channel to save cycles in the FXAA shader!
/// </remarks>
public class vtkOpenGLFXAAFilter : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLFXAAFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLFXAAFilter()
	{
		MRClassNameKey = "class vtkOpenGLFXAAFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLFXAAFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLFXAAFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFXAAFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLFXAAFilter New()
	{
		vtkOpenGLFXAAFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFXAAFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLFXAAFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLFXAAFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLFXAAFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_Execute_01(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Perform FXAA on the current render buffer in @a ren.
	/// </summary>
	public void Execute(vtkOpenGLRenderer ren)
	{
		vtkOpenGLFXAAFilter_Execute_01(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkFXAAOptions.DebugOption vtkOpenGLFXAAFilter_GetDebugOptionValue_02(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual vtkFXAAOptions.DebugOption GetDebugOptionValue()
	{
		return vtkOpenGLFXAAFilter_GetDebugOptionValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFXAAFilter_GetEndpointSearchIterations_03(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual int GetEndpointSearchIterations()
	{
		return vtkOpenGLFXAAFilter_GetEndpointSearchIterations_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFXAAFilter_GetEndpointSearchIterationsMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual int GetEndpointSearchIterationsMaxValue()
	{
		return vtkOpenGLFXAAFilter_GetEndpointSearchIterationsMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFXAAFilter_GetEndpointSearchIterationsMinValue_05(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual int GetEndpointSearchIterationsMinValue()
	{
		return vtkOpenGLFXAAFilter_GetEndpointSearchIterationsMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetHardContrastThreshold_06(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetHardContrastThreshold()
	{
		return vtkOpenGLFXAAFilter_GetHardContrastThreshold_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetHardContrastThresholdMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetHardContrastThresholdMaxValue()
	{
		return vtkOpenGLFXAAFilter_GetHardContrastThresholdMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetHardContrastThresholdMinValue_08(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetHardContrastThresholdMinValue()
	{
		return vtkOpenGLFXAAFilter_GetHardContrastThresholdMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLFXAAFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLFXAAFilter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLFXAAFilter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLFXAAFilter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetRelativeContrastThreshold_11(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetRelativeContrastThreshold()
	{
		return vtkOpenGLFXAAFilter_GetRelativeContrastThreshold_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetRelativeContrastThresholdMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetRelativeContrastThresholdMaxValue()
	{
		return vtkOpenGLFXAAFilter_GetRelativeContrastThresholdMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetRelativeContrastThresholdMinValue_13(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetRelativeContrastThresholdMinValue()
	{
		return vtkOpenGLFXAAFilter_GetRelativeContrastThresholdMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetSubpixelBlendLimit_14(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetSubpixelBlendLimit()
	{
		return vtkOpenGLFXAAFilter_GetSubpixelBlendLimit_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetSubpixelBlendLimitMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetSubpixelBlendLimitMaxValue()
	{
		return vtkOpenGLFXAAFilter_GetSubpixelBlendLimitMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetSubpixelBlendLimitMinValue_16(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetSubpixelBlendLimitMinValue()
	{
		return vtkOpenGLFXAAFilter_GetSubpixelBlendLimitMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetSubpixelContrastThreshold_17(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetSubpixelContrastThreshold()
	{
		return vtkOpenGLFXAAFilter_GetSubpixelContrastThreshold_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetSubpixelContrastThresholdMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetSubpixelContrastThresholdMaxValue()
	{
		return vtkOpenGLFXAAFilter_GetSubpixelContrastThresholdMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFXAAFilter_GetSubpixelContrastThresholdMinValue_19(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual float GetSubpixelContrastThresholdMinValue()
	{
		return vtkOpenGLFXAAFilter_GetSubpixelContrastThresholdMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLFXAAFilter_GetUseHighQualityEndpoints_20(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual bool GetUseHighQualityEndpoints()
	{
		return (vtkOpenGLFXAAFilter_GetUseHighQualityEndpoints_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFXAAFilter_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLFXAAFilter_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFXAAFilter_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLFXAAFilter_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFXAAFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLFXAAFilter NewInstance()
	{
		vtkOpenGLFXAAFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFXAAFilter_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLFXAAFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_ReleaseGraphicsResources_25(HandleRef pThis);

	/// <summary>
	/// Release all OpenGL state.
	/// </summary>
	public void ReleaseGraphicsResources()
	{
		vtkOpenGLFXAAFilter_ReleaseGraphicsResources_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFXAAFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLFXAAFilter SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLFXAAFilter vtkOpenGLFXAAFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFXAAFilter_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLFXAAFilter2 = (vtkOpenGLFXAAFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLFXAAFilter2.Register(null);
			}
		}
		return vtkOpenGLFXAAFilter2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_SetDebugOptionValue_27(HandleRef pThis, vtkFXAAOptions.DebugOption opt);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void SetDebugOptionValue(vtkFXAAOptions.DebugOption opt)
	{
		vtkOpenGLFXAAFilter_SetDebugOptionValue_27(GetCppThis(), opt);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_SetEndpointSearchIterations_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void SetEndpointSearchIterations(int _arg)
	{
		vtkOpenGLFXAAFilter_SetEndpointSearchIterations_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_SetHardContrastThreshold_29(HandleRef pThis, float _arg);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void SetHardContrastThreshold(float _arg)
	{
		vtkOpenGLFXAAFilter_SetHardContrastThreshold_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_SetRelativeContrastThreshold_30(HandleRef pThis, float _arg);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void SetRelativeContrastThreshold(float _arg)
	{
		vtkOpenGLFXAAFilter_SetRelativeContrastThreshold_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_SetSubpixelBlendLimit_31(HandleRef pThis, float _arg);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void SetSubpixelBlendLimit(float _arg)
	{
		vtkOpenGLFXAAFilter_SetSubpixelBlendLimit_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_SetSubpixelContrastThreshold_32(HandleRef pThis, float _arg);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void SetSubpixelContrastThreshold(float _arg)
	{
		vtkOpenGLFXAAFilter_SetSubpixelContrastThreshold_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_SetUseHighQualityEndpoints_33(HandleRef pThis, byte val);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void SetUseHighQualityEndpoints(bool val)
	{
		vtkOpenGLFXAAFilter_SetUseHighQualityEndpoints_33(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_UpdateConfiguration_34(HandleRef pThis, HandleRef opts);

	/// <summary>
	/// Copy the configuration values from @a opts into this filter. Note that
	/// this copies the configuration values from opts -- it does not save the
	/// @a opts pointer.
	/// </summary>
	public void UpdateConfiguration(vtkFXAAOptions opts)
	{
		vtkOpenGLFXAAFilter_UpdateConfiguration_34(GetCppThis(), opts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_UseHighQualityEndpointsOff_35(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void UseHighQualityEndpointsOff()
	{
		vtkOpenGLFXAAFilter_UseHighQualityEndpointsOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFXAAFilter_UseHighQualityEndpointsOn_36(HandleRef pThis);

	/// <summary>
	/// Parameter for tuning the FXAA implementation. See vtkFXAAOptions for
	/// details and suggested values.
	/// </summary>
	public virtual void UseHighQualityEndpointsOn()
	{
		vtkOpenGLFXAAFilter_UseHighQualityEndpointsOn_36(GetCppThis());
	}
}
