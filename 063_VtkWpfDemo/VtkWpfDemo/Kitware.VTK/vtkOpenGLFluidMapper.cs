using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLFluidMapper
/// </summary>
/// <remarks>
///    Render fluid from position data (and color, if available)
///
/// An OpenGL mapper that display fluid volume using a screen space
/// fluid rendering technique. Thanks to Nghia Truong for the algorithm
/// and initial implementation.
/// </remarks>
public class vtkOpenGLFluidMapper : vtkAbstractVolumeMapper
{
	/// <summary>
	/// Display mode for the fluid, default value is TransparentFluidVolume
	/// </summary>
	public enum FluidDisplayMode
	{
		/// <summary>enum member</summary>
		FilteredOpaqueSurface = 1,
		/// <summary>enum member</summary>
		FilteredSurfaceNormal = 3,
		/// <summary>enum member</summary>
		NumDisplayModes = 5,
		/// <summary>enum member</summary>
		TransparentFluidVolume = 4,
		/// <summary>enum member</summary>
		UnfilteredOpaqueSurface = 0,
		/// <summary>enum member</summary>
		UnfilteredSurfaceNormal = 2
	}

	/// <summary>
	/// Filter method to filter the depth buffer
	/// </summary>
	public enum FluidSurfaceFilterMethod
	{
		/// <summary>enum member</summary>
		BilateralGaussian,
		/// <summary>enum member</summary>
		NarrowRange,
		/// <summary>enum member</summary>
		NumFilterMethods
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLFluidMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLFluidMapper()
	{
		MRClassNameKey = "class vtkOpenGLFluidMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLFluidMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLFluidMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFluidMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLFluidMapper New()
	{
		vtkOpenGLFluidMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFluidMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLFluidMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLFluidMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLFluidMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkOpenGLFluidMapper_GetAdditionalReflection_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the fluid surface additional reflection scale This value is in
	/// [0, 1], which 0 means using the reflection color computed from fresnel
	/// equation, and 1 means using reflection color as [1, 1, 1] Default value
	/// is 0
	/// </summary>
	public virtual float GetAdditionalReflection()
	{
		return vtkOpenGLFluidMapper_GetAdditionalReflection_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFluidMapper_GetAttenuationColor_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the fluid attenuation color
	/// (color that will be absorpted exponentially when going through the fluid
	/// volume)
	/// </summary>
	public virtual float[] GetAttenuationColor()
	{
		IntPtr intPtr = vtkOpenGLFluidMapper_GetAttenuationColor_02(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_GetAttenuationColor_03(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3);

	/// <summary>
	/// Get/Set the fluid attenuation color
	/// (color that will be absorpted exponentially when going through the fluid
	/// volume)
	/// </summary>
	public virtual void GetAttenuationColor(ref float _arg1, ref float _arg2, ref float _arg3)
	{
		vtkOpenGLFluidMapper_GetAttenuationColor_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_GetAttenuationColor_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the fluid attenuation color
	/// (color that will be absorpted exponentially when going through the fluid
	/// volume)
	/// </summary>
	public virtual void GetAttenuationColor(IntPtr _arg)
	{
		vtkOpenGLFluidMapper_GetAttenuationColor_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFluidMapper_GetAttenuationScale_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the fluid volume attenuation scale, which will be multiplied
	/// with attenuation color Default value is 1.0, and can be set to any
	/// non-negative number The larger attenuation scale, the darker fluid
	/// color
	/// </summary>
	public virtual float GetAttenuationScale()
	{
		return vtkOpenGLFluidMapper_GetAttenuationScale_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern FluidDisplayMode vtkOpenGLFluidMapper_GetDisplayMode_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the display mode
	/// </summary>
	public virtual FluidDisplayMode GetDisplayMode()
	{
		return vtkOpenGLFluidMapper_GetDisplayMode_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFluidMapper_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the input data to map.
	/// </summary>
	public vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFluidMapper_GetInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLFluidMapper_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLFluidMapper_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLFluidMapper_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLFluidMapper_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFluidMapper_GetOpaqueColor_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the fluid surface color if rendered in opaque surface mode
	/// without particle color
	/// </summary>
	public virtual float[] GetOpaqueColor()
	{
		IntPtr intPtr = vtkOpenGLFluidMapper_GetOpaqueColor_10(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_GetOpaqueColor_11(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3);

	/// <summary>
	/// Get/Set the fluid surface color if rendered in opaque surface mode
	/// without particle color
	/// </summary>
	public virtual void GetOpaqueColor(ref float _arg1, ref float _arg2, ref float _arg3)
	{
		vtkOpenGLFluidMapper_GetOpaqueColor_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_GetOpaqueColor_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the fluid surface color if rendered in opaque surface mode
	/// without particle color
	/// </summary>
	public virtual void GetOpaqueColor(IntPtr _arg)
	{
		vtkOpenGLFluidMapper_GetOpaqueColor_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFluidMapper_GetParticleColorPower_13(HandleRef pThis);

	/// <summary>
	/// Get/Set the power value for particle color if input data has particle
	/// color Default value is 0.1, and can be set to any non-negative number The
	/// particle color is then recomputed as newColor = pow(oldColor, power) *
	/// scale
	/// </summary>
	public virtual float GetParticleColorPower()
	{
		return vtkOpenGLFluidMapper_GetParticleColorPower_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFluidMapper_GetParticleColorScale_14(HandleRef pThis);

	/// <summary>
	/// Get/Set the scale value for particle color if input data has particle
	/// color Default value is 1.0, and can be set to any non-negative number The
	/// particle color is then recomputed as newColor = pow(oldColor, power) *
	/// scale
	/// </summary>
	public virtual float GetParticleColorScale()
	{
		return vtkOpenGLFluidMapper_GetParticleColorScale_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFluidMapper_GetParticleRadius_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the particle radius, must be explicitly set by user
	/// To fuse the gaps between particles and obtain a smooth surface,
	/// this parameter need to be slightly larger than the actual particle radius,
	/// (particle radius is the half distance between two consecutive particles in
	/// regular pattern sampling)
	/// </summary>
	public virtual float GetParticleRadius()
	{
		return vtkOpenGLFluidMapper_GetParticleRadius_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFluidMapper_GetRefractionScale_16(HandleRef pThis);

	/// <summary>
	/// Get/Set the scale value for refraction This is needed for tweak
	/// refraction of volumes with different size scales For example, fluid
	/// volume having diameter of 100.0 will refract light much more than
	/// volume with diameter 1.0 This value is in [0, 1], default value is 1.0
	/// </summary>
	public virtual float GetRefractionScale()
	{
		return vtkOpenGLFluidMapper_GetRefractionScale_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFluidMapper_GetRefractiveIndex_17(HandleRef pThis);

	/// <summary>
	/// Get/Set the fluid refraction index. The default value is 1.33 (water)
	/// </summary>
	public virtual float GetRefractiveIndex()
	{
		return vtkOpenGLFluidMapper_GetRefractiveIndex_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLFluidMapper_GetScalarVisibility_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual bool GetScalarVisibility()
	{
		return (vtkOpenGLFluidMapper_GetScalarVisibility_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFluidMapper_GetSurfaceFilterIterations_19(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of filter iterations to filter the depth surface
	/// This is an optional parameter, default value is 3
	/// Usually set this to around 3-5
	/// Too many filter iterations will over-smooth the surface
	/// </summary>
	public virtual uint GetSurfaceFilterIterations()
	{
		return vtkOpenGLFluidMapper_GetSurfaceFilterIterations_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern FluidSurfaceFilterMethod vtkOpenGLFluidMapper_GetSurfaceFilterMethod_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the filter method for filtering fluid surface
	/// </summary>
	public virtual FluidSurfaceFilterMethod GetSurfaceFilterMethod()
	{
		return vtkOpenGLFluidMapper_GetSurfaceFilterMethod_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFluidMapper_GetSurfaceFilterRadius_21(HandleRef pThis);

	/// <summary>
	/// Get/Set the filter radius for smoothing the depth surface
	/// This is an optional parameter, default value is 5
	/// This is not exactly the radius in pixels,
	/// instead it is just a parameter used for computing the actual filter
	/// radius in the screen space filtering
	/// </summary>
	public virtual uint GetSurfaceFilterRadius()
	{
		return vtkOpenGLFluidMapper_GetSurfaceFilterRadius_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenGLFluidMapper_GetThicknessAndVolumeColorFilterIterations_22(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of filter iterations to filter the volume thickness
	/// and particle color This is an optional parameter, default value is 3
	/// </summary>
	public virtual uint GetThicknessAndVolumeColorFilterIterations()
	{
		return vtkOpenGLFluidMapper_GetThicknessAndVolumeColorFilterIterations_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLFluidMapper_GetThicknessAndVolumeColorFilterRadius_23(HandleRef pThis);

	/// <summary>
	/// Get/Set the filter radius to filter the volume thickness and particle
	/// color This is an optional parameter, default value is 10 (pixels)
	/// </summary>
	public virtual float GetThicknessAndVolumeColorFilterRadius()
	{
		return vtkOpenGLFluidMapper_GetThicknessAndVolumeColorFilterRadius_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFluidMapper_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLFluidMapper_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLFluidMapper_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLFluidMapper_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFluidMapper_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLFluidMapper NewInstance()
	{
		vtkOpenGLFluidMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFluidMapper_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLFluidMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_ReleaseGraphicsResources_28(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own
	/// resources.
	/// \pre w_exists: w!=0
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkOpenGLFluidMapper_ReleaseGraphicsResources_28(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_Render_29(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// This calls RenderPiece
	/// </summary>
	public override void Render(vtkRenderer ren, vtkVolume vol)
	{
		vtkOpenGLFluidMapper_Render_29(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLFluidMapper_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLFluidMapper SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLFluidMapper vtkOpenGLFluidMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLFluidMapper_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLFluidMapper2 = (vtkOpenGLFluidMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLFluidMapper2.Register(null);
			}
		}
		return vtkOpenGLFluidMapper2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_ScalarVisibilityOff_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOff()
	{
		vtkOpenGLFluidMapper_ScalarVisibilityOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_ScalarVisibilityOn_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void ScalarVisibilityOn()
	{
		vtkOpenGLFluidMapper_ScalarVisibilityOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetAdditionalReflection_33(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the fluid surface additional reflection scale This value is in
	/// [0, 1], which 0 means using the reflection color computed from fresnel
	/// equation, and 1 means using reflection color as [1, 1, 1] Default value
	/// is 0
	/// </summary>
	public virtual void SetAdditionalReflection(float _arg)
	{
		vtkOpenGLFluidMapper_SetAdditionalReflection_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetAttenuationColor_34(HandleRef pThis, float _arg1, float _arg2, float _arg3);

	/// <summary>
	/// Get/Set the fluid attenuation color
	/// (color that will be absorpted exponentially when going through the fluid
	/// volume)
	/// </summary>
	public virtual void SetAttenuationColor(float _arg1, float _arg2, float _arg3)
	{
		vtkOpenGLFluidMapper_SetAttenuationColor_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetAttenuationColor_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the fluid attenuation color
	/// (color that will be absorpted exponentially when going through the fluid
	/// volume)
	/// </summary>
	public virtual void SetAttenuationColor(IntPtr _arg)
	{
		vtkOpenGLFluidMapper_SetAttenuationColor_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetAttenuationScale_36(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the fluid volume attenuation scale, which will be multiplied
	/// with attenuation color Default value is 1.0, and can be set to any
	/// non-negative number The larger attenuation scale, the darker fluid
	/// color
	/// </summary>
	public virtual void SetAttenuationScale(float _arg)
	{
		vtkOpenGLFluidMapper_SetAttenuationScale_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetBilateralGaussianFilterParameter_37(HandleRef pThis, float sigmaDepth);

	/// <summary>
	/// Optional parameters, exclusively for bilateral gaussian filter
	/// The parameter is for controlling smoothing between surface depth values
	/// </summary>
	public void SetBilateralGaussianFilterParameter(float sigmaDepth)
	{
		vtkOpenGLFluidMapper_SetBilateralGaussianFilterParameter_37(GetCppThis(), sigmaDepth);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetDisplayMode_38(HandleRef pThis, FluidDisplayMode _arg);

	/// <summary>
	/// Get/Set the display mode
	/// </summary>
	public virtual void SetDisplayMode(FluidDisplayMode _arg)
	{
		vtkOpenGLFluidMapper_SetDisplayMode_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetInputData_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the input data to map.
	/// </summary>
	public void SetInputData(vtkPolyData arg0)
	{
		vtkOpenGLFluidMapper_SetInputData_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetNarrowRangeFilterParameters_40(HandleRef pThis, float lambda, float mu);

	/// <summary>
	/// Optional parameters, exclusively for narrow range filter
	/// The first parameter is to control smoothing between surface depth values
	/// The second parameter is to control curvature of the surface edges
	/// </summary>
	public void SetNarrowRangeFilterParameters(float lambda, float mu)
	{
		vtkOpenGLFluidMapper_SetNarrowRangeFilterParameters_40(GetCppThis(), lambda, mu);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetOpaqueColor_41(HandleRef pThis, float _arg1, float _arg2, float _arg3);

	/// <summary>
	/// Get/Set the fluid surface color if rendered in opaque surface mode
	/// without particle color
	/// </summary>
	public virtual void SetOpaqueColor(float _arg1, float _arg2, float _arg3)
	{
		vtkOpenGLFluidMapper_SetOpaqueColor_41(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetOpaqueColor_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the fluid surface color if rendered in opaque surface mode
	/// without particle color
	/// </summary>
	public virtual void SetOpaqueColor(IntPtr _arg)
	{
		vtkOpenGLFluidMapper_SetOpaqueColor_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetParticleColorPower_43(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the power value for particle color if input data has particle
	/// color Default value is 0.1, and can be set to any non-negative number The
	/// particle color is then recomputed as newColor = pow(oldColor, power) *
	/// scale
	/// </summary>
	public virtual void SetParticleColorPower(float _arg)
	{
		vtkOpenGLFluidMapper_SetParticleColorPower_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetParticleColorScale_44(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the scale value for particle color if input data has particle
	/// color Default value is 1.0, and can be set to any non-negative number The
	/// particle color is then recomputed as newColor = pow(oldColor, power) *
	/// scale
	/// </summary>
	public virtual void SetParticleColorScale(float _arg)
	{
		vtkOpenGLFluidMapper_SetParticleColorScale_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetParticleRadius_45(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the particle radius, must be explicitly set by user
	/// To fuse the gaps between particles and obtain a smooth surface,
	/// this parameter need to be slightly larger than the actual particle radius,
	/// (particle radius is the half distance between two consecutive particles in
	/// regular pattern sampling)
	/// </summary>
	public virtual void SetParticleRadius(float _arg)
	{
		vtkOpenGLFluidMapper_SetParticleRadius_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetRefractionScale_46(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the scale value for refraction This is needed for tweak
	/// refraction of volumes with different size scales For example, fluid
	/// volume having diameter of 100.0 will refract light much more than
	/// volume with diameter 1.0 This value is in [0, 1], default value is 1.0
	/// </summary>
	public virtual void SetRefractionScale(float _arg)
	{
		vtkOpenGLFluidMapper_SetRefractionScale_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetRefractiveIndex_47(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the fluid refraction index. The default value is 1.33 (water)
	/// </summary>
	public virtual void SetRefractiveIndex(float _arg)
	{
		vtkOpenGLFluidMapper_SetRefractiveIndex_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetScalarVisibility_48(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off flag to control whether scalar data is used to color objects.
	/// </summary>
	public virtual void SetScalarVisibility(bool _arg)
	{
		vtkOpenGLFluidMapper_SetScalarVisibility_48(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetSurfaceFilterIterations_49(HandleRef pThis, uint _arg);

	/// <summary>
	/// Get/Set the number of filter iterations to filter the depth surface
	/// This is an optional parameter, default value is 3
	/// Usually set this to around 3-5
	/// Too many filter iterations will over-smooth the surface
	/// </summary>
	public virtual void SetSurfaceFilterIterations(uint _arg)
	{
		vtkOpenGLFluidMapper_SetSurfaceFilterIterations_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetSurfaceFilterMethod_50(HandleRef pThis, FluidSurfaceFilterMethod _arg);

	/// <summary>
	/// Get/Set the filter method for filtering fluid surface
	/// </summary>
	public virtual void SetSurfaceFilterMethod(FluidSurfaceFilterMethod _arg)
	{
		vtkOpenGLFluidMapper_SetSurfaceFilterMethod_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetSurfaceFilterRadius_51(HandleRef pThis, uint _arg);

	/// <summary>
	/// Get/Set the filter radius for smoothing the depth surface
	/// This is an optional parameter, default value is 5
	/// This is not exactly the radius in pixels,
	/// instead it is just a parameter used for computing the actual filter
	/// radius in the screen space filtering
	/// </summary>
	public virtual void SetSurfaceFilterRadius(uint _arg)
	{
		vtkOpenGLFluidMapper_SetSurfaceFilterRadius_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetThicknessAndVolumeColorFilterIterations_52(HandleRef pThis, uint _arg);

	/// <summary>
	/// Get/Set the number of filter iterations to filter the volume thickness
	/// and particle color This is an optional parameter, default value is 3
	/// </summary>
	public virtual void SetThicknessAndVolumeColorFilterIterations(uint _arg)
	{
		vtkOpenGLFluidMapper_SetThicknessAndVolumeColorFilterIterations_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLFluidMapper_SetThicknessAndVolumeColorFilterRadius_53(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the filter radius to filter the volume thickness and particle
	/// color This is an optional parameter, default value is 10 (pixels)
	/// </summary>
	public virtual void SetThicknessAndVolumeColorFilterRadius(float _arg)
	{
		vtkOpenGLFluidMapper_SetThicknessAndVolumeColorFilterRadius_53(GetCppThis(), _arg);
	}
}
