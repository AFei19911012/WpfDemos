using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLRenderer
/// </summary>
/// <remarks>
///    OpenGL renderer
///
/// vtkOpenGLRenderer is a concrete implementation of the abstract class
/// vtkRenderer. vtkOpenGLRenderer interfaces to the OpenGL graphics library.
/// </remarks>
public class vtkOpenGLRenderer : vtkRenderer
{
	/// <summary>
	/// Dual depth peeling may be disabled for certain runtime configurations.
	/// This method returns true if vtkDualDepthPeelingPass will be used in place
	/// of vtkDepthPeelingPass.
	/// </summary>
	public enum LightingComplexityEnum
	{
		/// <summary>enum member</summary>
		Directional = 2,
		/// <summary>enum member</summary>
		Headlight = 1,
		/// <summary>enum member</summary>
		NoLighting = 0,
		/// <summary>enum member</summary>
		Positional = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLRenderer()
	{
		MRClassNameKey = "class vtkOpenGLRenderer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRenderer New()
	{
		vtkOpenGLRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLRenderer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOpenGLRenderer_Clear_01(HandleRef pThis);

	/// <summary>
	/// Render translucent polygonal geometry. Default implementation just call
	/// UpdateTranslucentPolygonalGeometry().
	/// Subclasses of vtkRenderer that can deal with depth peeling must
	/// override this method.
	/// </summary>
	public override void Clear()
	{
		vtkOpenGLRenderer_Clear_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_DeviceRender_02(HandleRef pThis);

	/// <summary>
	/// Concrete open gl render method.
	/// </summary>
	public override void DeviceRender()
	{
		vtkOpenGLRenderer_DeviceRender_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_DeviceRenderOpaqueGeometry_03(HandleRef pThis, HandleRef fbo);

	/// <summary>
	/// Overridden to support hidden line removal.
	/// </summary>
	public override void DeviceRenderOpaqueGeometry(vtkFrameBufferObjectBase fbo)
	{
		vtkOpenGLRenderer_DeviceRenderOpaqueGeometry_03(GetCppThis(), fbo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_DeviceRenderTranslucentPolygonalGeometry_04(HandleRef pThis, HandleRef fbo);

	/// <summary>
	/// Render translucent polygonal geometry. Default implementation just call
	/// UpdateTranslucentPolygonalGeometry().
	/// Subclasses of vtkRenderer that can deal with depth peeling must
	/// override this method.
	/// </summary>
	public override void DeviceRenderTranslucentPolygonalGeometry(vtkFrameBufferObjectBase fbo)
	{
		vtkOpenGLRenderer_DeviceRenderTranslucentPolygonalGeometry_04(GetCppThis(), fbo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderer_GetDepthPeelingHigherLayer_05(HandleRef pThis);

	/// <summary>
	/// Is rendering at translucent geometry stage using depth peeling and
	/// rendering a layer other than the first one? (Boolean value)
	/// If so, the uniform variables UseTexture and Texture can be set.
	/// (Used by vtkOpenGLProperty or vtkOpenGLTexture)
	/// </summary>
	public int GetDepthPeelingHigherLayer()
	{
		return vtkOpenGLRenderer_GetDepthPeelingHigherLayer_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_GetEnvMapIrradiance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get environment textures used for image based lighting.
	/// </summary>
	public vtkPBRIrradianceTexture GetEnvMapIrradiance()
	{
		vtkPBRIrradianceTexture vtkPBRIrradianceTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderer_GetEnvMapIrradiance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPBRIrradianceTexture2 = (vtkPBRIrradianceTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPBRIrradianceTexture2.Register(null);
			}
		}
		return vtkPBRIrradianceTexture2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_GetEnvMapLookupTable_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get environment textures used for image based lighting.
	/// </summary>
	public vtkPBRLUTTexture GetEnvMapLookupTable()
	{
		vtkPBRLUTTexture vtkPBRLUTTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderer_GetEnvMapLookupTable_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPBRLUTTexture2 = (vtkPBRLUTTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPBRLUTTexture2.Register(null);
			}
		}
		return vtkPBRLUTTexture2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_GetEnvMapPrefiltered_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get environment textures used for image based lighting.
	/// </summary>
	public vtkPBRPrefilterTexture GetEnvMapPrefiltered()
	{
		vtkPBRPrefilterTexture vtkPBRPrefilterTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderer_GetEnvMapPrefiltered_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPBRPrefilterTexture2 = (vtkPBRPrefilterTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPBRPrefilterTexture2.Register(null);
			}
		}
		return vtkPBRPrefilterTexture2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderer_GetLightingComplexity_09(HandleRef pThis);

	/// <summary>
	/// Dual depth peeling may be disabled for certain runtime configurations.
	/// This method returns true if vtkDualDepthPeelingPass will be used in place
	/// of vtkDepthPeelingPass.
	/// </summary>
	public virtual int GetLightingComplexity()
	{
		return vtkOpenGLRenderer_GetLightingComplexity_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderer_GetLightingCount_10(HandleRef pThis);

	/// <summary>
	/// Dual depth peeling may be disabled for certain runtime configurations.
	/// This method returns true if vtkDualDepthPeelingPass will be used in place
	/// of vtkDepthPeelingPass.
	/// </summary>
	public virtual int GetLightingCount()
	{
		return vtkOpenGLRenderer_GetLightingCount_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_GetLightingUniforms_11(HandleRef pThis);

	/// <summary>
	/// Dual depth peeling may be disabled for certain runtime configurations.
	/// This method returns true if vtkDualDepthPeelingPass will be used in place
	/// of vtkDepthPeelingPass.
	/// </summary>
	public string GetLightingUniforms()
	{
		return Marshal.PtrToStringAnsi(vtkOpenGLRenderer_GetLightingUniforms_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderer_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLRenderer_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderer_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLRenderer_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_GetSphericalHarmonics_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get spherical harmonics coefficients used for irradiance
	/// </summary>
	public vtkFloatArray GetSphericalHarmonics()
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderer_GetSphericalHarmonics_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderer_GetUseSphericalHarmonics_15(HandleRef pThis);

	/// <summary>
	/// Use spherical harmonics instead of irradiance texture
	/// </summary>
	public virtual bool GetUseSphericalHarmonics()
	{
		return (vtkOpenGLRenderer_GetUseSphericalHarmonics_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_GetUserLightTransform_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the user light transform applied after the camera transform.
	/// Can be null to disable it.
	/// </summary>
	public vtkTransform GetUserLightTransform()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderer_GetUserLightTransform_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderer_HaveAppleQueryAllocationBug_17();

	/// <summary>
	/// Indicate if this system is subject to the apple/NVIDIA bug that causes
	/// crashes in the driver when too many query objects are allocated.
	/// </summary>
	public static bool HaveAppleQueryAllocationBug()
	{
		return (vtkOpenGLRenderer_HaveAppleQueryAllocationBug_17() != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderer_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLRenderer_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderer_IsDualDepthPeelingSupported_19(HandleRef pThis);

	/// <summary>
	/// Dual depth peeling may be disabled for certain runtime configurations.
	/// This method returns true if vtkDualDepthPeelingPass will be used in place
	/// of vtkDepthPeelingPass.
	/// </summary>
	public bool IsDualDepthPeelingSupported()
	{
		return (vtkOpenGLRenderer_IsDualDepthPeelingSupported_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderer_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLRenderer_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLRenderer NewInstance()
	{
		vtkOpenGLRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderer_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Overridden in order to connect the texture to the environment map textures.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkOpenGLRenderer_ReleaseGraphicsResources_23(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderer_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRenderer SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLRenderer vtkOpenGLRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderer_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLRenderer2 = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLRenderer2.Register(null);
			}
		}
		return vtkOpenGLRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_SetEnvironmentTexture_25(HandleRef pThis, HandleRef texture, byte isSRGB);

	/// <summary>
	/// Overridden in order to connect the texture to the environment map textures.
	/// </summary>
	public override void SetEnvironmentTexture(vtkTexture texture, bool isSRGB)
	{
		vtkOpenGLRenderer_SetEnvironmentTexture_25(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef), (byte)(isSRGB ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_SetUseSphericalHarmonics_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Use spherical harmonics instead of irradiance texture
	/// </summary>
	public virtual void SetUseSphericalHarmonics(bool _arg)
	{
		vtkOpenGLRenderer_SetUseSphericalHarmonics_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_SetUserLightTransform_27(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Set the user light transform applied after the camera transform.
	/// Can be null to disable it.
	/// </summary>
	public void SetUserLightTransform(vtkTransform transform)
	{
		vtkOpenGLRenderer_SetUserLightTransform_27(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_UpdateLightingUniforms_28(HandleRef pThis, HandleRef prog);

	/// <summary>
	/// Dual depth peeling may be disabled for certain runtime configurations.
	/// This method returns true if vtkDualDepthPeelingPass will be used in place
	/// of vtkDepthPeelingPass.
	/// </summary>
	public void UpdateLightingUniforms(vtkShaderProgram prog)
	{
		vtkOpenGLRenderer_UpdateLightingUniforms_28(GetCppThis(), prog?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderer_UpdateLights_29(HandleRef pThis);

	/// <summary>
	/// Ask lights to load themselves into graphics pipeline.
	/// </summary>
	public virtual int UpdateLights()
	{
		return vtkOpenGLRenderer_UpdateLights_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_UseSphericalHarmonicsOff_30(HandleRef pThis);

	/// <summary>
	/// Use spherical harmonics instead of irradiance texture
	/// </summary>
	public virtual void UseSphericalHarmonicsOff()
	{
		vtkOpenGLRenderer_UseSphericalHarmonicsOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderer_UseSphericalHarmonicsOn_31(HandleRef pThis);

	/// <summary>
	/// Use spherical harmonics instead of irradiance texture
	/// </summary>
	public virtual void UseSphericalHarmonicsOn()
	{
		vtkOpenGLRenderer_UseSphericalHarmonicsOn_31(GetCppThis());
	}
}
