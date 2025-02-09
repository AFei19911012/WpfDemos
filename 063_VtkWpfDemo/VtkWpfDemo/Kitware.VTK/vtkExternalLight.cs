using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExternalLight
/// </summary>
/// <remarks>
///    a virtual light object for tweaking existing lights
/// in an external 3D rendering context
///
///
/// vtkExternalLight is a virtual light object for tweaking existing lights in
/// an external 3D rendering context. It provides a mechanism to adjust and
/// control parameters of existing lights in an external OpenGL context.
///
/// It provides methods to locate and point the light,
/// and set its brightness and color. In addition to the
/// basic infinite distance point light source attributes, you can also specify
/// the light attenuation values and cone angle. These attributes are only used
/// if the light is a positional light.
///
/// By default, vtkExternalLight overrides specific light parameters as set by
/// the user. Setting the #ReplaceMode to ALL_PARAMS, will set all
/// the light parameter values to the ones set in vtkExternalLight.
///
/// @warning
/// Use the vtkExternalLight object to tweak parameters of lights created in the
/// external context. This class does NOT create new lights in the scene.
///
/// @par Example:
/// Usage example for vtkExternalLight in conjunction with
/// vtkExternalOpenGLRenderer and \ref ExternalVTKWidget
/// <code>{.cpp}
///    vtkNew&lt;vtkExternalLight&gt; exLight;
///    exLight-&gt;SetLightIndex(GL_LIGHT0); // GL_LIGHT0 identifies the external light
///    exLight-&gt;SetDiffuseColor(1.0, 0.0, 0.0); // Changing diffuse color
///    vtkNew&lt;ExternalVTKWidget&gt; exWidget;
///    vtkExternalOpenGLRenderer* ren =
/// vtkExternalOpenGLRenderer::SafeDownCast(exWidget-&gt;AddRenderer());
///    ren-&gt;AddExternalLight(exLight.GetPointer());
/// </code>
///
/// </remarks>
/// <seealso>
///
/// vtkExternalOpenGLRenderer \ref ExternalVTKWidget
/// </seealso>
public class vtkExternalLight : vtkLight
{
	/// <summary>
	/// Create an external light object with the focal point at the origin and its
	/// position set to (0,0,1). The light is a Headlight, its color is white
	/// (black ambient, white diffuse, white specular),
	/// intensity=1, the light is turned on, positional lighting is off,
	/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
	/// TransformMatrix is NULL. The light index is GL_LIGHT0, which means the
	/// existing light with index GL_LIGHT0 will be affected by this light.
	/// </summary>
	public enum ReplaceModes
	{
		/// <summary>enum member</summary>
		ALL_PARAMS = 1,
		/// <summary>enum member</summary>
		INDIVIDUAL_PARAMS = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExternalLight";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExternalLight()
	{
		MRClassNameKey = "class vtkExternalLight";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExternalLight"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExternalLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an external light object with the focal point at the origin and its
	/// position set to (0,0,1). The light is a Headlight, its color is white
	/// (black ambient, white diffuse, white specular),
	/// intensity=1, the light is turned on, positional lighting is off,
	/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
	/// TransformMatrix is NULL. The light index is GL_LIGHT0, which means the
	/// existing light with index GL_LIGHT0 will be affected by this light.
	/// </summary>
	public new static vtkExternalLight New()
	{
		vtkExternalLight result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalLight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExternalLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create an external light object with the focal point at the origin and its
	/// position set to (0,0,1). The light is a Headlight, its color is white
	/// (black ambient, white diffuse, white specular),
	/// intensity=1, the light is turned on, positional lighting is off,
	/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
	/// TransformMatrix is NULL. The light index is GL_LIGHT0, which means the
	/// existing light with index GL_LIGHT0 will be affected by this light.
	/// </summary>
	public vtkExternalLight()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExternalLight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetAmbientColorSet_01(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetAmbientColorSet()
	{
		return (vtkExternalLight_GetAmbientColorSet_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetAttenuationValuesSet_02(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetAttenuationValuesSet()
	{
		return (vtkExternalLight_GetAttenuationValuesSet_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetConeAngleSet_03(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetConeAngleSet()
	{
		return (vtkExternalLight_GetConeAngleSet_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetDiffuseColorSet_04(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetDiffuseColorSet()
	{
		return (vtkExternalLight_GetDiffuseColorSet_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetExponentSet_05(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetExponentSet()
	{
		return (vtkExternalLight_GetExponentSet_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetFocalPointSet_06(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetFocalPointSet()
	{
		return (vtkExternalLight_GetFocalPointSet_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetIntensitySet_07(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetIntensitySet()
	{
		return (vtkExternalLight_GetIntensitySet_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalLight_GetLightIndex_08(HandleRef pThis);

	/// <summary>
	/// Set/Get light index
	/// This should be the OpenGL light identifier. (e.g.: GL_LIGHT0)
	/// (Default: GL_LIGHT0)
	/// </summary>
	public virtual int GetLightIndex()
	{
		return vtkExternalLight_GetLightIndex_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExternalLight_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExternalLight_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExternalLight_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExternalLight_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetPositionSet_11(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetPositionSet()
	{
		return (vtkExternalLight_GetPositionSet_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetPositionalSet_12(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetPositionalSet()
	{
		return (vtkExternalLight_GetPositionalSet_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalLight_GetReplaceMode_13(HandleRef pThis);

	/// <summary>
	/// Set/Get replace mode
	/// This determines how this ExternalLight will be used to tweak parameters on
	/// an existing light in the rendering context.
	/// (Default: INDIVIDUAL_PARAMS)
	///
	/// \li \c vtkExternalLight::INDIVIDUAL_PARAMS : Replace parameters
	/// specifically set by the user by calling the parameter
	/// Set method. (e.g. SetDiffuseColor())
	///
	/// \li \c vtkExternalLight::ALL_PARAMS : Replace all
	/// parameters of the light with the parameters in vtkExternalLight object.
	/// </summary>
	public virtual int GetReplaceMode()
	{
		return vtkExternalLight_GetReplaceMode_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalLight_GetSpecularColorSet_14(HandleRef pThis);

	/// <summary>
	/// Check whether value set by user
	/// </summary>
	public virtual bool GetSpecularColorSet()
	{
		return (vtkExternalLight_GetSpecularColorSet_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalLight_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExternalLight_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalLight_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExternalLight_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalLight_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExternalLight NewInstance()
	{
		vtkExternalLight result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalLight_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExternalLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalLight_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExternalLight SafeDownCast(vtkObjectBase o)
	{
		vtkExternalLight vtkExternalLight2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalLight_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExternalLight2 = (vtkExternalLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExternalLight2.Register(null);
			}
		}
		return vtkExternalLight2;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetAmbientColor_20(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetAmbientColor(double arg0, double arg1, double arg2)
	{
		vtkExternalLight_SetAmbientColor_20(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetAttenuationValues_21(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetAttenuationValues(double arg0, double arg1, double arg2)
	{
		vtkExternalLight_SetAttenuationValues_21(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetConeAngle_22(HandleRef pThis, double arg0);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetConeAngle(double arg0)
	{
		vtkExternalLight_SetConeAngle_22(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetDiffuseColor_23(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetDiffuseColor(double arg0, double arg1, double arg2)
	{
		vtkExternalLight_SetDiffuseColor_23(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetExponent_24(HandleRef pThis, double arg0);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetExponent(double arg0)
	{
		vtkExternalLight_SetExponent_24(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetFocalPoint_25(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetFocalPoint(double arg0, double arg1, double arg2)
	{
		vtkExternalLight_SetFocalPoint_25(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetIntensity_26(HandleRef pThis, double arg0);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetIntensity(double arg0)
	{
		vtkExternalLight_SetIntensity_26(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetLightIndex_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get light index
	/// This should be the OpenGL light identifier. (e.g.: GL_LIGHT0)
	/// (Default: GL_LIGHT0)
	/// </summary>
	public virtual void SetLightIndex(int _arg)
	{
		vtkExternalLight_SetLightIndex_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetPosition_28(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetPosition(double arg0, double arg1, double arg2)
	{
		vtkExternalLight_SetPosition_28(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetPositional_29(HandleRef pThis, int arg0);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetPositional(int arg0)
	{
		vtkExternalLight_SetPositional_29(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetReplaceMode_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get replace mode
	/// This determines how this ExternalLight will be used to tweak parameters on
	/// an existing light in the rendering context.
	/// (Default: INDIVIDUAL_PARAMS)
	///
	/// \li \c vtkExternalLight::INDIVIDUAL_PARAMS : Replace parameters
	/// specifically set by the user by calling the parameter
	/// Set method. (e.g. SetDiffuseColor())
	///
	/// \li \c vtkExternalLight::ALL_PARAMS : Replace all
	/// parameters of the light with the parameters in vtkExternalLight object.
	/// </summary>
	public virtual void SetReplaceMode(int _arg)
	{
		vtkExternalLight_SetReplaceMode_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalLight_SetSpecularColor_31(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Override Set method to keep a record of changed value
	/// </summary>
	public override void SetSpecularColor(double arg0, double arg1, double arg2)
	{
		vtkExternalLight_SetSpecularColor_31(GetCppThis(), arg0, arg1, arg2);
	}
}
