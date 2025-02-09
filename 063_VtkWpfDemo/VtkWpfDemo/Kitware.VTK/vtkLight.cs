using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLight
/// </summary>
/// <remarks>
///    a virtual light for 3D rendering
///
/// vtkLight is a virtual light for 3D rendering. It provides methods to locate
/// and point the light, turn it on and off, and set its brightness and color.
/// In addition to the basic infinite distance point light source attributes,
/// you also can specify the light attenuation values and cone angle.
/// These attributes are only used if the light is a positional light.
/// The default is a directional light (e.g. infinite point light source).
///
/// Lights have a type that describes how the light should move with respect
/// to the camera.  A Headlight is always located at the current camera position
/// and shines on the camera's focal point.  A CameraLight also moves with
/// the camera, but may not be coincident to it.  CameraLights are defined
/// in a normalized coordinate space where the camera is located at (0, 0, 1),
/// the camera is looking at (0, 0, 0), and up is (0, 1, 0).  Finally, a
/// SceneLight is part of the scene itself and does not move with the camera.
/// (Renderers are responsible for moving the light based on its type.)
///
/// Lights have a transformation matrix that describes the space in which
/// they are positioned.  A light's world space position and focal point
/// are defined by their local position and focal point, transformed by
/// their transformation matrix (if it exists).
/// </remarks>
public class vtkLight : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLight";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLight()
	{
		MRClassNameKey = "class vtkLight";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLight"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a light with the focal point at the origin and its position
	/// set to (0,0,1). The light is a SceneLight, its color is white
	/// (black ambient, white diffuse, white specular),
	/// intensity=1, the light is turned on, positional lighting is off,
	/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
	/// TransformMatrix is NULL.
	/// </summary>
	public new static vtkLight New()
	{
		vtkLight result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a light with the focal point at the origin and its position
	/// set to (0,0,1). The light is a SceneLight, its color is white
	/// (black ambient, white diffuse, white specular),
	/// intensity=1, the light is turned on, positional lighting is off,
	/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
	/// TransformMatrix is NULL.
	/// </summary>
	public vtkLight()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLight_DeepCopy_01(HandleRef pThis, HandleRef light);

	/// <summary>
	/// Perform deep copy of this light.
	/// </summary>
	public void DeepCopy(vtkLight light)
	{
		vtkLight_DeepCopy_01(GetCppThis(), light?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetAmbientColor_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual double[] GetAmbientColor()
	{
		IntPtr intPtr = vtkLight_GetAmbientColor_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetAmbientColor_03(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void GetAmbientColor(IntPtr data)
	{
		vtkLight_GetAmbientColor_03(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetAttenuationValues_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the quadratic attenuation constants. They are specified as
	/// constant, linear, and quadratic, in that order.
	/// </summary>
	public virtual double[] GetAttenuationValues()
	{
		IntPtr intPtr = vtkLight_GetAttenuationValues_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetAttenuationValues_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the quadratic attenuation constants. They are specified as
	/// constant, linear, and quadratic, in that order.
	/// </summary>
	public virtual void GetAttenuationValues(IntPtr data)
	{
		vtkLight_GetAttenuationValues_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLight_GetConeAngle_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the lighting cone angle of a positional light in degrees.
	/// This is the angle between the axis of the cone and a ray along the edge of
	/// the cone.
	/// A value of 90 (or more) indicates that you want no spot lighting effects
	/// just a positional light.
	/// </summary>
	public virtual double GetConeAngle()
	{
		return vtkLight_GetConeAngle_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetDiffuseColor_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual double[] GetDiffuseColor()
	{
		IntPtr intPtr = vtkLight_GetDiffuseColor_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetDiffuseColor_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void GetDiffuseColor(IntPtr data)
	{
		vtkLight_GetDiffuseColor_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLight_GetExponent_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the exponent of the cosine used in positional lighting.
	/// </summary>
	public virtual double GetExponent()
	{
		return vtkLight_GetExponent_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLight_GetExponentMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the exponent of the cosine used in positional lighting.
	/// </summary>
	public virtual double GetExponentMaxValue()
	{
		return vtkLight_GetExponentMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLight_GetExponentMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the exponent of the cosine used in positional lighting.
	/// </summary>
	public virtual double GetExponentMinValue()
	{
		return vtkLight_GetExponentMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetFocalPoint_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the point at which the light is shining.
	/// Note: The focal point of the light is defined in the coordinate
	/// space indicated by its transformation matrix (if it exists).
	/// Thus, to get the light's world space focal point, use
	/// vtkGetTransformedFocalPoint() instead of vtkGetFocalPoint().
	/// </summary>
	public virtual double[] GetFocalPoint()
	{
		IntPtr intPtr = vtkLight_GetFocalPoint_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetFocalPoint_13(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the point at which the light is shining.
	/// Note: The focal point of the light is defined in the coordinate
	/// space indicated by its transformation matrix (if it exists).
	/// Thus, to get the light's world space focal point, use
	/// vtkGetTransformedFocalPoint() instead of vtkGetFocalPoint().
	/// </summary>
	public virtual void GetFocalPoint(IntPtr data)
	{
		vtkLight_GetFocalPoint_13(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetInformation_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the information object associated with the light.
	/// </summary>
	public virtual vtkInformation GetInformation()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLight_GetInformation_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLight_GetIntensity_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the brightness of the light (from one to zero).
	/// </summary>
	public virtual double GetIntensity()
	{
		return vtkLight_GetIntensity_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLight_GetLightType_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of the light.
	/// A SceneLight is a light located in the world coordinate space.  A light
	/// is initially created as a scene light.
	///
	/// A Headlight is always located at the camera and is pointed at the
	/// camera's focal point.  The renderer is free to modify the position and
	/// focal point of the camera at any time.
	///
	/// A CameraLight is also attached to the camera, but is not necessarily
	/// located at the camera's position.  CameraLights are defined in a
	/// coordinate space where the camera is located at (0, 0, 1), looking
	/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
	/// CameraLight uses the transform matrix to establish this space.
	///
	/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
	/// light's transform matrix.
	/// </summary>
	public virtual int GetLightType()
	{
		return vtkLight_GetLightType_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLight_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLight_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLight_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLight_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetPosition_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the light.
	/// Note: The position of the light is defined in the coordinate
	/// space indicated by its transformation matrix (if it exists).
	/// Thus, to get the light's world space position, use
	/// vtkGetTransformedPosition() instead of vtkGetPosition().
	/// </summary>
	public virtual double[] GetPosition()
	{
		IntPtr intPtr = vtkLight_GetPosition_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetPosition_20(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the position of the light.
	/// Note: The position of the light is defined in the coordinate
	/// space indicated by its transformation matrix (if it exists).
	/// Thus, to get the light's world space position, use
	/// vtkGetTransformedPosition() instead of vtkGetPosition().
	/// </summary>
	public virtual void GetPosition(IntPtr data)
	{
		vtkLight_GetPosition_20(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLight_GetPositional_21(HandleRef pThis);

	/// <summary>
	/// Turn positional lighting on or off.
	/// </summary>
	public virtual int GetPositional()
	{
		return vtkLight_GetPositional_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkLight_GetShadowAttenuation_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the shadow intensity
	/// By default a light will be completely blocked when in shadow
	/// by setting this value to less than 1.0 you can control how much
	/// light is attenuated when in shadow
	/// </summary>
	public virtual float GetShadowAttenuation()
	{
		return vtkLight_GetShadowAttenuation_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetSpecularColor_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual double[] GetSpecularColor()
	{
		IntPtr intPtr = vtkLight_GetSpecularColor_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetSpecularColor_24(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void GetSpecularColor(IntPtr data)
	{
		vtkLight_GetSpecularColor_24(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLight_GetSwitch_25(HandleRef pThis);

	/// <summary>
	/// Turn the light on or off.
	/// </summary>
	public virtual int GetSwitch()
	{
		return vtkLight_GetSwitch_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetTransformMatrix_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the light's transformation matrix.  If a matrix is set for
	/// a light, the light's parameters (position and focal point) are
	/// transformed by the matrix before being rendered.
	/// </summary>
	public virtual vtkMatrix4x4 GetTransformMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLight_GetTransformMatrix_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetTransformedFocalPoint_27(HandleRef pThis, ref double x, ref double y, ref double z);

	/// <summary>
	/// Get the focal point of the light, modified by the transformation matrix
	/// (if it exists).
	/// </summary>
	public void GetTransformedFocalPoint(ref double x, ref double y, ref double z)
	{
		vtkLight_GetTransformedFocalPoint_27(GetCppThis(), ref x, ref y, ref z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetTransformedFocalPoint_28(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Get the focal point of the light, modified by the transformation matrix
	/// (if it exists).
	/// </summary>
	public void GetTransformedFocalPoint(IntPtr a)
	{
		vtkLight_GetTransformedFocalPoint_28(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetTransformedFocalPoint_29(HandleRef pThis);

	/// <summary>
	/// Get the focal point of the light, modified by the transformation matrix
	/// (if it exists).
	/// </summary>
	public double[] GetTransformedFocalPoint()
	{
		IntPtr intPtr = vtkLight_GetTransformedFocalPoint_29(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetTransformedPosition_30(HandleRef pThis, ref double x, ref double y, ref double z);

	/// <summary>
	/// Get the position of the light, modified by the transformation matrix
	/// (if it exists).
	/// </summary>
	public void GetTransformedPosition(ref double x, ref double y, ref double z)
	{
		vtkLight_GetTransformedPosition_30(GetCppThis(), ref x, ref y, ref z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_GetTransformedPosition_31(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Get the position of the light, modified by the transformation matrix
	/// (if it exists).
	/// </summary>
	public void GetTransformedPosition(IntPtr a)
	{
		vtkLight_GetTransformedPosition_31(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_GetTransformedPosition_32(HandleRef pThis);

	/// <summary>
	/// Get the position of the light, modified by the transformation matrix
	/// (if it exists).
	/// </summary>
	public double[] GetTransformedPosition()
	{
		IntPtr intPtr = vtkLight_GetTransformedPosition_32(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLight_IsA_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLight_IsA_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLight_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLight_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLight_LightTypeIsCameraLight_35(HandleRef pThis);

	/// <summary>
	/// Query the type of the light.
	/// </summary>
	public int LightTypeIsCameraLight()
	{
		return vtkLight_LightTypeIsCameraLight_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLight_LightTypeIsHeadlight_36(HandleRef pThis);

	/// <summary>
	/// Query the type of the light.
	/// </summary>
	public int LightTypeIsHeadlight()
	{
		return vtkLight_LightTypeIsHeadlight_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLight_LightTypeIsSceneLight_37(HandleRef pThis);

	/// <summary>
	/// Query the type of the light.
	/// </summary>
	public int LightTypeIsSceneLight()
	{
		return vtkLight_LightTypeIsSceneLight_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLight NewInstance()
	{
		vtkLight result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLight_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_PositionalOff_40(HandleRef pThis);

	/// <summary>
	/// Turn positional lighting on or off.
	/// </summary>
	public virtual void PositionalOff()
	{
		vtkLight_PositionalOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_PositionalOn_41(HandleRef pThis);

	/// <summary>
	/// Turn positional lighting on or off.
	/// </summary>
	public virtual void PositionalOn()
	{
		vtkLight_PositionalOn_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_Render_42(HandleRef pThis, HandleRef arg0, int arg1);

	/// <summary>
	/// Abstract interface to renderer. Each concrete subclass of vtkLight
	/// will load its data into the graphics system in response to this method
	/// invocation. The actual loading is performed by a vtkLightDevice
	/// subclass, which will get created automatically.
	/// </summary>
	public virtual void Render(vtkRenderer arg0, int arg1)
	{
		vtkLight_Render_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLight SafeDownCast(vtkObjectBase o)
	{
		vtkLight vtkLight2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLight_SafeDownCast_43(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLight2 = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLight2.Register(null);
			}
		}
		return vtkLight2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetAmbientColor_44(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
	{
		vtkLight_SetAmbientColor_44(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetAmbientColor_45(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void SetAmbientColor(IntPtr _arg)
	{
		vtkLight_SetAmbientColor_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetAttenuationValues_46(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the quadratic attenuation constants. They are specified as
	/// constant, linear, and quadratic, in that order.
	/// </summary>
	public virtual void SetAttenuationValues(double _arg1, double _arg2, double _arg3)
	{
		vtkLight_SetAttenuationValues_46(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetAttenuationValues_47(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the quadratic attenuation constants. They are specified as
	/// constant, linear, and quadratic, in that order.
	/// </summary>
	public virtual void SetAttenuationValues(IntPtr _arg)
	{
		vtkLight_SetAttenuationValues_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetColor_48(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public void SetColor(double arg0, double arg1, double arg2)
	{
		vtkLight_SetColor_48(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetColor_49(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public void SetColor(IntPtr a)
	{
		vtkLight_SetColor_49(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetConeAngle_50(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the lighting cone angle of a positional light in degrees.
	/// This is the angle between the axis of the cone and a ray along the edge of
	/// the cone.
	/// A value of 90 (or more) indicates that you want no spot lighting effects
	/// just a positional light.
	/// </summary>
	public virtual void SetConeAngle(double _arg)
	{
		vtkLight_SetConeAngle_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetDiffuseColor_51(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
	{
		vtkLight_SetDiffuseColor_51(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetDiffuseColor_52(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void SetDiffuseColor(IntPtr _arg)
	{
		vtkLight_SetDiffuseColor_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetDirectionAngle_53(HandleRef pThis, double elevation, double azimuth);

	/// <summary>
	/// Set the position and focal point of a light based on elevation and
	/// azimuth.  The light is moved so it is shining from the given angle.
	/// Angles are given in degrees.  If the light is a
	/// positional light, it is made directional instead.
	/// </summary>
	public void SetDirectionAngle(double elevation, double azimuth)
	{
		vtkLight_SetDirectionAngle_53(GetCppThis(), elevation, azimuth);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetDirectionAngle_54(HandleRef pThis, IntPtr ang);

	/// <summary>
	/// Set the position and focal point of a light based on elevation and
	/// azimuth.  The light is moved so it is shining from the given angle.
	/// Angles are given in degrees.  If the light is a
	/// positional light, it is made directional instead.
	/// </summary>
	public void SetDirectionAngle(IntPtr ang)
	{
		vtkLight_SetDirectionAngle_54(GetCppThis(), ang);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetExponent_55(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the exponent of the cosine used in positional lighting.
	/// </summary>
	public virtual void SetExponent(double _arg)
	{
		vtkLight_SetExponent_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetFocalPoint_56(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the point at which the light is shining.
	/// Note: The focal point of the light is defined in the coordinate
	/// space indicated by its transformation matrix (if it exists).
	/// Thus, to get the light's world space focal point, use
	/// vtkGetTransformedFocalPoint() instead of vtkGetFocalPoint().
	/// </summary>
	public virtual void SetFocalPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkLight_SetFocalPoint_56(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetFocalPoint_57(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the point at which the light is shining.
	/// Note: The focal point of the light is defined in the coordinate
	/// space indicated by its transformation matrix (if it exists).
	/// Thus, to get the light's world space focal point, use
	/// vtkGetTransformedFocalPoint() instead of vtkGetFocalPoint().
	/// </summary>
	public virtual void SetFocalPoint(IntPtr _arg)
	{
		vtkLight_SetFocalPoint_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetInformation_58(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the information object associated with the light.
	/// </summary>
	public virtual void SetInformation(vtkInformation arg0)
	{
		vtkLight_SetInformation_58(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetIntensity_59(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the brightness of the light (from one to zero).
	/// </summary>
	public virtual void SetIntensity(double _arg)
	{
		vtkLight_SetIntensity_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetLightType_60(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/Get the type of the light.
	/// A SceneLight is a light located in the world coordinate space.  A light
	/// is initially created as a scene light.
	///
	/// A Headlight is always located at the camera and is pointed at the
	/// camera's focal point.  The renderer is free to modify the position and
	/// focal point of the camera at any time.
	///
	/// A CameraLight is also attached to the camera, but is not necessarily
	/// located at the camera's position.  CameraLights are defined in a
	/// coordinate space where the camera is located at (0, 0, 1), looking
	/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
	/// CameraLight uses the transform matrix to establish this space.
	///
	/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
	/// light's transform matrix.
	/// </summary>
	public virtual void SetLightType(int arg0)
	{
		vtkLight_SetLightType_60(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetLightTypeToCameraLight_61(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of the light.
	/// A SceneLight is a light located in the world coordinate space.  A light
	/// is initially created as a scene light.
	///
	/// A Headlight is always located at the camera and is pointed at the
	/// camera's focal point.  The renderer is free to modify the position and
	/// focal point of the camera at any time.
	///
	/// A CameraLight is also attached to the camera, but is not necessarily
	/// located at the camera's position.  CameraLights are defined in a
	/// coordinate space where the camera is located at (0, 0, 1), looking
	/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
	/// CameraLight uses the transform matrix to establish this space.
	///
	/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
	/// light's transform matrix.
	/// </summary>
	public void SetLightTypeToCameraLight()
	{
		vtkLight_SetLightTypeToCameraLight_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetLightTypeToHeadlight_62(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of the light.
	/// A SceneLight is a light located in the world coordinate space.  A light
	/// is initially created as a scene light.
	///
	/// A Headlight is always located at the camera and is pointed at the
	/// camera's focal point.  The renderer is free to modify the position and
	/// focal point of the camera at any time.
	///
	/// A CameraLight is also attached to the camera, but is not necessarily
	/// located at the camera's position.  CameraLights are defined in a
	/// coordinate space where the camera is located at (0, 0, 1), looking
	/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
	/// CameraLight uses the transform matrix to establish this space.
	///
	/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
	/// light's transform matrix.
	/// </summary>
	public void SetLightTypeToHeadlight()
	{
		vtkLight_SetLightTypeToHeadlight_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetLightTypeToSceneLight_63(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of the light.
	/// A SceneLight is a light located in the world coordinate space.  A light
	/// is initially created as a scene light.
	///
	/// A Headlight is always located at the camera and is pointed at the
	/// camera's focal point.  The renderer is free to modify the position and
	/// focal point of the camera at any time.
	///
	/// A CameraLight is also attached to the camera, but is not necessarily
	/// located at the camera's position.  CameraLights are defined in a
	/// coordinate space where the camera is located at (0, 0, 1), looking
	/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
	/// CameraLight uses the transform matrix to establish this space.
	///
	/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
	/// light's transform matrix.
	/// </summary>
	public void SetLightTypeToSceneLight()
	{
		vtkLight_SetLightTypeToSceneLight_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetPosition_64(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the position of the light.
	/// Note: The position of the light is defined in the coordinate
	/// space indicated by its transformation matrix (if it exists).
	/// Thus, to get the light's world space position, use
	/// vtkGetTransformedPosition() instead of vtkGetPosition().
	/// </summary>
	public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
	{
		vtkLight_SetPosition_64(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetPosition_65(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the position of the light.
	/// Note: The position of the light is defined in the coordinate
	/// space indicated by its transformation matrix (if it exists).
	/// Thus, to get the light's world space position, use
	/// vtkGetTransformedPosition() instead of vtkGetPosition().
	/// </summary>
	public virtual void SetPosition(IntPtr _arg)
	{
		vtkLight_SetPosition_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetPositional_66(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn positional lighting on or off.
	/// </summary>
	public virtual void SetPositional(int _arg)
	{
		vtkLight_SetPositional_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetShadowAttenuation_67(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the shadow intensity
	/// By default a light will be completely blocked when in shadow
	/// by setting this value to less than 1.0 you can control how much
	/// light is attenuated when in shadow
	/// </summary>
	public virtual void SetShadowAttenuation(float _arg)
	{
		vtkLight_SetShadowAttenuation_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetSpecularColor_68(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
	{
		vtkLight_SetSpecularColor_68(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetSpecularColor_69(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of the light. It is possible to set the ambient,
	/// diffuse and specular colors separately. The SetColor() method sets
	/// the diffuse and specular colors to the same color (this is a feature
	/// to preserve backward compatibility.)
	/// </summary>
	public virtual void SetSpecularColor(IntPtr _arg)
	{
		vtkLight_SetSpecularColor_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetSwitch_70(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn the light on or off.
	/// </summary>
	public virtual void SetSwitch(int _arg)
	{
		vtkLight_SetSwitch_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SetTransformMatrix_71(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the light's transformation matrix.  If a matrix is set for
	/// a light, the light's parameters (position and focal point) are
	/// transformed by the matrix before being rendered.
	/// </summary>
	public virtual void SetTransformMatrix(vtkMatrix4x4 arg0)
	{
		vtkLight_SetTransformMatrix_71(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLight_ShallowClone_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new light object with the same light parameters than the current
	/// object (any ivar from the superclasses (vtkObject and vtkObjectBase),
	/// like reference counting, timestamp and observers are not copied).
	/// This is a shallow clone (TransformMatrix is referenced)
	/// </summary>
	public virtual vtkLight ShallowClone()
	{
		vtkLight vtkLight2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLight_ShallowClone_72(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLight2 = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLight2.Register(null);
			}
		}
		return vtkLight2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SwitchOff_73(HandleRef pThis);

	/// <summary>
	/// Turn the light on or off.
	/// </summary>
	public virtual void SwitchOff()
	{
		vtkLight_SwitchOff_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_SwitchOn_74(HandleRef pThis);

	/// <summary>
	/// Turn the light on or off.
	/// </summary>
	public virtual void SwitchOn()
	{
		vtkLight_SwitchOn_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_TransformPoint_75(HandleRef pThis, IntPtr a, IntPtr b);

	/// <summary>
	/// Use transform matrix to transform point (if it exists).
	/// </summary>
	public void TransformPoint(IntPtr a, IntPtr b)
	{
		vtkLight_TransformPoint_75(GetCppThis(), a, b);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLight_TransformVector_76(HandleRef pThis, IntPtr a, IntPtr b);

	/// <summary>
	/// Use transform matrix to transform vector (if it exists).
	/// </summary>
	public void TransformVector(IntPtr a, IntPtr b)
	{
		vtkLight_TransformVector_76(GetCppThis(), a, b);
	}
}
