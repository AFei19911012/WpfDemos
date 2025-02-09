using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProperty
/// </summary>
/// <remarks>
///    represent surface properties of a geometric object
///
/// vtkProperty is an object that represents lighting and other surface
/// properties of a geometric object. The primary properties that can be
/// set are colors (overall, ambient, diffuse, specular, and edge color);
/// specular power; opacity of the object; the representation of the
/// object (points, wireframe, or surface); and the shading method to be
/// used (flat, Gouraud, and Phong). Also, some special graphics features
/// like backface properties can be set and manipulated with this object.
///
/// </remarks>
/// <seealso>
///
/// vtkActor vtkPropertyDevice
/// </seealso>
public class vtkProperty : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProperty";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProperty()
	{
		MRClassNameKey = "class vtkProperty";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProperty"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with object color, ambient color, diffuse color,
	/// specular color, and edge color white; ambient coefficient=0; diffuse
	/// coefficient=0; specular coefficient=0; specular power=1; Gouraud shading;
	/// and surface representation. Backface and frontface culling are off.
	/// </summary>
	public new static vtkProperty New()
	{
		vtkProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with object color, ambient color, diffuse color,
	/// specular color, and edge color white; ambient coefficient=0; diffuse
	/// coefficient=0; specular coefficient=0; specular power=1; Gouraud shading;
	/// and surface representation. Backface and frontface culling are off.
	/// </summary>
	public vtkProperty()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkProperty_AddShaderVariable_01(HandleRef pThis, string name, int numVars, IntPtr x);

	/// <summary>
	/// Provide values to initialize shader variables.
	/// Useful to initialize shader variables that change over time
	/// (animation, GUI widgets inputs, etc. )
	/// - \p name - hardware name of the uniform variable
	/// - \p numVars - number of variables being set
	/// - \p x - values
	/// </summary>
	public virtual void AddShaderVariable(string name, int numVars, IntPtr x)
	{
		vtkProperty_AddShaderVariable_01(GetCppThis(), name, numVars, x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_02(HandleRef pThis, string name, int v);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, int v)
	{
		vtkProperty_AddShaderVariable_02(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_03(HandleRef pThis, string name, float v);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, float v)
	{
		vtkProperty_AddShaderVariable_03(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_04(HandleRef pThis, string name, double v);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, double v)
	{
		vtkProperty_AddShaderVariable_04(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_05(HandleRef pThis, string name, int v1, int v2);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, int v1, int v2)
	{
		vtkProperty_AddShaderVariable_05(GetCppThis(), name, v1, v2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_06(HandleRef pThis, string name, float v1, float v2);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, float v1, float v2)
	{
		vtkProperty_AddShaderVariable_06(GetCppThis(), name, v1, v2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_07(HandleRef pThis, string name, double v1, double v2);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, double v1, double v2)
	{
		vtkProperty_AddShaderVariable_07(GetCppThis(), name, v1, v2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_08(HandleRef pThis, string name, int v1, int v2, int v3);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, int v1, int v2, int v3)
	{
		vtkProperty_AddShaderVariable_08(GetCppThis(), name, v1, v2, v3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_09(HandleRef pThis, string name, float v1, float v2, float v3);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, float v1, float v2, float v3)
	{
		vtkProperty_AddShaderVariable_09(GetCppThis(), name, v1, v2, v3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_AddShaderVariable_10(HandleRef pThis, string name, double v1, double v2, double v3);

	/// <summary>
	/// Methods to provide to add shader variables from wrappers.
	/// </summary>
	public void AddShaderVariable(string name, double v1, double v2, double v3)
	{
		vtkProperty_AddShaderVariable_10(GetCppThis(), name, v1, v2, v3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_BackfaceCullingOff_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast culling of polygons based on orientation of normal
	/// with respect to camera. If backface culling is on, polygons facing
	/// away from camera are not drawn.
	/// </summary>
	public virtual void BackfaceCullingOff()
	{
		vtkProperty_BackfaceCullingOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_BackfaceCullingOn_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast culling of polygons based on orientation of normal
	/// with respect to camera. If backface culling is on, polygons facing
	/// away from camera are not drawn.
	/// </summary>
	public virtual void BackfaceCullingOn()
	{
		vtkProperty_BackfaceCullingOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_BackfaceRender_13(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// This method renders the property as a backface property. TwoSidedLighting
	/// must be turned off to see any backface properties. Note that only
	/// colors and opacity are used for backface properties. Other properties
	/// such as Representation, Culling are specified by the Property.
	/// </summary>
	public virtual void BackfaceRender(vtkActor arg0, vtkRenderer arg1)
	{
		vtkProperty_BackfaceRender_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_ComputeIORFromReflectance_14(double reflectance, double ior);

	/// <summary>
	/// For PBR, calculate the refractive index from the reflectance of the interface
	/// and the refractive index of one of both medium.
	/// </summary>
	public static double ComputeIORFromReflectance(double reflectance, double ior)
	{
		return vtkProperty_ComputeIORFromReflectance_14(reflectance, ior);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_ComputeReflectanceFromIOR_15(double IORTo, double IORFrom);

	/// <summary>
	/// For PBR, calculate the reflectance from the refractive index of
	/// ingoing and outgoing interfaces.
	/// </summary>
	public static double ComputeReflectanceFromIOR(double IORTo, double IORFrom)
	{
		return vtkProperty_ComputeReflectanceFromIOR_15(IORTo, IORFrom);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_ComputeReflectanceOfBaseLayer_16(HandleRef pThis);

	/// <summary>
	/// For PBR, calculate the reflectance of the base layer depending on the presence
	/// of a coat layer. If there is no coat layer, the reflectance is the one at the
	/// interface environment - base layer. If a coat layer is present, the reflectance
	/// is the one at the interface between the base and the coat layer.
	/// </summary>
	public double ComputeReflectanceOfBaseLayer()
	{
		return vtkProperty_ComputeReflectanceOfBaseLayer_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_DeepCopy_17(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public void DeepCopy(vtkProperty p)
	{
		vtkProperty_DeepCopy_17(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_EdgeVisibilityOff_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off the visibility of edges. On some renderers it is
	/// possible to render the edges of geometric primitives separately
	/// from the interior.
	/// </summary>
	public virtual void EdgeVisibilityOff()
	{
		vtkProperty_EdgeVisibilityOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_EdgeVisibilityOn_19(HandleRef pThis);

	/// <summary>
	/// Turn on/off the visibility of edges. On some renderers it is
	/// possible to render the edges of geometric primitives separately
	/// from the interior.
	/// </summary>
	public virtual void EdgeVisibilityOn()
	{
		vtkProperty_EdgeVisibilityOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_FrontfaceCullingOff_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast culling of polygons based on orientation of normal
	/// with respect to camera. If frontface culling is on, polygons facing
	/// towards camera are not drawn.
	/// </summary>
	public virtual void FrontfaceCullingOff()
	{
		vtkProperty_FrontfaceCullingOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_FrontfaceCullingOn_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast culling of polygons based on orientation of normal
	/// with respect to camera. If frontface culling is on, polygons facing
	/// towards camera are not drawn.
	/// </summary>
	public virtual void FrontfaceCullingOn()
	{
		vtkProperty_FrontfaceCullingOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAmbient_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the ambient lighting coefficient.
	/// </summary>
	public virtual double GetAmbient()
	{
		return vtkProperty_GetAmbient_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetAmbientColor_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the ambient surface color. Not all renderers support separate
	/// ambient and diffuse colors. From a physical standpoint it really
	/// doesn't make too much sense to have both. For the rendering
	/// libraries that don't support both, the diffuse color is used.
	/// </summary>
	public virtual double[] GetAmbientColor()
	{
		IntPtr intPtr = vtkProperty_GetAmbientColor_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetAmbientColor_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the ambient surface color. Not all renderers support separate
	/// ambient and diffuse colors. From a physical standpoint it really
	/// doesn't make too much sense to have both. For the rendering
	/// libraries that don't support both, the diffuse color is used.
	/// </summary>
	public virtual void GetAmbientColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty_GetAmbientColor_24(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetAmbientColor_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the ambient surface color. Not all renderers support separate
	/// ambient and diffuse colors. From a physical standpoint it really
	/// doesn't make too much sense to have both. For the rendering
	/// libraries that don't support both, the diffuse color is used.
	/// </summary>
	public virtual void GetAmbientColor(IntPtr _arg)
	{
		vtkProperty_GetAmbientColor_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAmbientMaxValue_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the ambient lighting coefficient.
	/// </summary>
	public virtual double GetAmbientMaxValue()
	{
		return vtkProperty_GetAmbientMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAmbientMinValue_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the ambient lighting coefficient.
	/// </summary>
	public virtual double GetAmbientMinValue()
	{
		return vtkProperty_GetAmbientMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAnisotropy_28(HandleRef pThis);

	/// <summary>
	/// Set/Get the anisotropy coefficient.
	/// This value controls the anisotropy of the material (0.0 means isotropic)
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetAnisotropy()
	{
		return vtkProperty_GetAnisotropy_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAnisotropyMaxValue_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the anisotropy coefficient.
	/// This value controls the anisotropy of the material (0.0 means isotropic)
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetAnisotropyMaxValue()
	{
		return vtkProperty_GetAnisotropyMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAnisotropyMinValue_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the anisotropy coefficient.
	/// This value controls the anisotropy of the material (0.0 means isotropic)
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetAnisotropyMinValue()
	{
		return vtkProperty_GetAnisotropyMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAnisotropyRotation_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the anisotropy rotation coefficient.
	/// This value controls the rotation of the direction of the anisotropy.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetAnisotropyRotation()
	{
		return vtkProperty_GetAnisotropyRotation_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAnisotropyRotationMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the anisotropy rotation coefficient.
	/// This value controls the rotation of the direction of the anisotropy.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetAnisotropyRotationMaxValue()
	{
		return vtkProperty_GetAnisotropyRotationMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetAnisotropyRotationMinValue_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the anisotropy rotation coefficient.
	/// This value controls the rotation of the direction of the anisotropy.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetAnisotropyRotationMinValue()
	{
		return vtkProperty_GetAnisotropyRotationMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetBackfaceCulling_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast culling of polygons based on orientation of normal
	/// with respect to camera. If backface culling is on, polygons facing
	/// away from camera are not drawn.
	/// </summary>
	public virtual int GetBackfaceCulling()
	{
		return vtkProperty_GetBackfaceCulling_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetBaseIOR_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the Index Of Refraction of the base layer.
	/// It controls the amount of light reflected at normal incidence (the reflectance F0),
	/// depending on the IOR of the upper layer (eg. coat layer, or environment).
	/// For example, with a base IOR of 1.5 and an IOR of 1.0 outside (IOR of the air),
	/// 4% of the amount of the light is reflected at normal incidence.
	/// Notice that modifying this value is only useful for dielectrics materials, as
	/// the reflectance for metallic is the albedo.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.5
	/// </summary>
	public virtual double GetBaseIOR()
	{
		return vtkProperty_GetBaseIOR_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetBaseIORMaxValue_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the Index Of Refraction of the base layer.
	/// It controls the amount of light reflected at normal incidence (the reflectance F0),
	/// depending on the IOR of the upper layer (eg. coat layer, or environment).
	/// For example, with a base IOR of 1.5 and an IOR of 1.0 outside (IOR of the air),
	/// 4% of the amount of the light is reflected at normal incidence.
	/// Notice that modifying this value is only useful for dielectrics materials, as
	/// the reflectance for metallic is the albedo.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.5
	/// </summary>
	public virtual double GetBaseIORMaxValue()
	{
		return vtkProperty_GetBaseIORMaxValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetBaseIORMinValue_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the Index Of Refraction of the base layer.
	/// It controls the amount of light reflected at normal incidence (the reflectance F0),
	/// depending on the IOR of the upper layer (eg. coat layer, or environment).
	/// For example, with a base IOR of 1.5 and an IOR of 1.0 outside (IOR of the air),
	/// 4% of the amount of the light is reflected at normal incidence.
	/// Notice that modifying this value is only useful for dielectrics materials, as
	/// the reflectance for metallic is the albedo.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.5
	/// </summary>
	public virtual double GetBaseIORMinValue()
	{
		return vtkProperty_GetBaseIORMinValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetCoatColor_38(HandleRef pThis);

	/// <summary>
	/// Set/Get the color of the coat layer.
	/// This value is only used by PBR Interpolation.
	/// Default value is white [1.0, 1.0, 1.0]
	/// </summary>
	public virtual double[] GetCoatColor()
	{
		IntPtr intPtr = vtkProperty_GetCoatColor_38(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetCoatColor_39(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the color of the coat layer.
	/// This value is only used by PBR Interpolation.
	/// Default value is white [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void GetCoatColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty_GetCoatColor_39(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetCoatColor_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of the coat layer.
	/// This value is only used by PBR Interpolation.
	/// Default value is white [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void GetCoatColor(IntPtr _arg)
	{
		vtkProperty_GetCoatColor_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatIOR_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer Index Of Refraction.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 2.0
	/// </summary>
	public virtual double GetCoatIOR()
	{
		return vtkProperty_GetCoatIOR_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatIORMaxValue_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer Index Of Refraction.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 2.0
	/// </summary>
	public virtual double GetCoatIORMaxValue()
	{
		return vtkProperty_GetCoatIORMaxValue_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatIORMinValue_43(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer Index Of Refraction.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 2.0
	/// </summary>
	public virtual double GetCoatIORMinValue()
	{
		return vtkProperty_GetCoatIORMinValue_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatNormalScale_44(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer normal scale coefficient.
	/// This value affects the strength of the normal deviation from the coat normal texture.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.0
	/// </summary>
	public virtual double GetCoatNormalScale()
	{
		return vtkProperty_GetCoatNormalScale_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatNormalScaleMaxValue_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer normal scale coefficient.
	/// This value affects the strength of the normal deviation from the coat normal texture.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.0
	/// </summary>
	public virtual double GetCoatNormalScaleMaxValue()
	{
		return vtkProperty_GetCoatNormalScaleMaxValue_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatNormalScaleMinValue_46(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer normal scale coefficient.
	/// This value affects the strength of the normal deviation from the coat normal texture.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.0
	/// </summary>
	public virtual double GetCoatNormalScaleMinValue()
	{
		return vtkProperty_GetCoatNormalScaleMinValue_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatRoughness_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer roughness coefficient.
	/// This value has to be between 0 (glossy) and 1 (rough).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetCoatRoughness()
	{
		return vtkProperty_GetCoatRoughness_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatRoughnessMaxValue_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer roughness coefficient.
	/// This value has to be between 0 (glossy) and 1 (rough).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetCoatRoughnessMaxValue()
	{
		return vtkProperty_GetCoatRoughnessMaxValue_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatRoughnessMinValue_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer roughness coefficient.
	/// This value has to be between 0 (glossy) and 1 (rough).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetCoatRoughnessMinValue()
	{
		return vtkProperty_GetCoatRoughnessMinValue_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatStrength_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer strength coefficient.
	/// This value affects the strength of the coat layer reflection.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetCoatStrength()
	{
		return vtkProperty_GetCoatStrength_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatStrengthMaxValue_51(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer strength coefficient.
	/// This value affects the strength of the coat layer reflection.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetCoatStrengthMaxValue()
	{
		return vtkProperty_GetCoatStrengthMaxValue_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetCoatStrengthMinValue_52(HandleRef pThis);

	/// <summary>
	/// Set/Get the coat layer strength coefficient.
	/// This value affects the strength of the coat layer reflection.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetCoatStrengthMinValue()
	{
		return vtkProperty_GetCoatStrengthMinValue_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetColor_53(HandleRef pThis);

	/// <summary>
	/// Set the color of the object. Has the side effect of setting the
	/// ambient diffuse and specular colors as well. This is basically
	/// a quick overall color setting method.
	/// </summary>
	public double[] GetColor()
	{
		IntPtr intPtr = vtkProperty_GetColor_53(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetColor_54(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set the color of the object. Has the side effect of setting the
	/// ambient diffuse and specular colors as well. This is basically
	/// a quick overall color setting method.
	/// </summary>
	public void GetColor(IntPtr rgb)
	{
		vtkProperty_GetColor_54(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetColor_55(HandleRef pThis, ref double r, ref double g, ref double b);

	/// <summary>
	/// Set the color of the object. Has the side effect of setting the
	/// ambient diffuse and specular colors as well. This is basically
	/// a quick overall color setting method.
	/// </summary>
	public void GetColor(ref double r, ref double g, ref double b)
	{
		vtkProperty_GetColor_55(GetCppThis(), ref r, ref g, ref b);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetDiffuse_56(HandleRef pThis);

	/// <summary>
	/// Set/Get the diffuse lighting coefficient.
	/// </summary>
	public virtual double GetDiffuse()
	{
		return vtkProperty_GetDiffuse_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetDiffuseColor_57(HandleRef pThis);

	/// <summary>
	/// Set/Get the diffuse surface color.
	/// For PBR Interpolation, DiffuseColor is used as the base color
	/// </summary>
	public virtual double[] GetDiffuseColor()
	{
		IntPtr intPtr = vtkProperty_GetDiffuseColor_57(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetDiffuseColor_58(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the diffuse surface color.
	/// For PBR Interpolation, DiffuseColor is used as the base color
	/// </summary>
	public virtual void GetDiffuseColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty_GetDiffuseColor_58(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetDiffuseColor_59(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the diffuse surface color.
	/// For PBR Interpolation, DiffuseColor is used as the base color
	/// </summary>
	public virtual void GetDiffuseColor(IntPtr _arg)
	{
		vtkProperty_GetDiffuseColor_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetDiffuseMaxValue_60(HandleRef pThis);

	/// <summary>
	/// Set/Get the diffuse lighting coefficient.
	/// </summary>
	public virtual double GetDiffuseMaxValue()
	{
		return vtkProperty_GetDiffuseMaxValue_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetDiffuseMinValue_61(HandleRef pThis);

	/// <summary>
	/// Set/Get the diffuse lighting coefficient.
	/// </summary>
	public virtual double GetDiffuseMinValue()
	{
		return vtkProperty_GetDiffuseMinValue_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetEdgeColor_62(HandleRef pThis);

	/// <summary>
	/// Set/Get the color of primitive edges (if edge visibility is enabled).
	/// </summary>
	public virtual double[] GetEdgeColor()
	{
		IntPtr intPtr = vtkProperty_GetEdgeColor_62(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetEdgeColor_63(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the color of primitive edges (if edge visibility is enabled).
	/// </summary>
	public virtual void GetEdgeColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty_GetEdgeColor_63(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetEdgeColor_64(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of primitive edges (if edge visibility is enabled).
	/// </summary>
	public virtual void GetEdgeColor(IntPtr _arg)
	{
		vtkProperty_GetEdgeColor_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetEdgeTint_65(HandleRef pThis);

	/// <summary>
	/// Set/Get the edge tint (for metals only).
	/// Set the color at grazing angle (fresnel reflectance).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual double[] GetEdgeTint()
	{
		IntPtr intPtr = vtkProperty_GetEdgeTint_65(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetEdgeTint_66(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the edge tint (for metals only).
	/// Set the color at grazing angle (fresnel reflectance).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void GetEdgeTint(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty_GetEdgeTint_66(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetEdgeTint_67(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the edge tint (for metals only).
	/// Set the color at grazing angle (fresnel reflectance).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void GetEdgeTint(IntPtr _arg)
	{
		vtkProperty_GetEdgeTint_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetEdgeVisibility_68(HandleRef pThis);

	/// <summary>
	/// Turn on/off the visibility of edges. On some renderers it is
	/// possible to render the edges of geometric primitives separately
	/// from the interior.
	/// </summary>
	public virtual int GetEdgeVisibility()
	{
		return vtkProperty_GetEdgeVisibility_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetEmissiveFactor_69(HandleRef pThis);

	/// <summary>
	/// Set/Get the emissive factor.
	/// This value is multiplied with the emissive color when an emissive texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual double[] GetEmissiveFactor()
	{
		IntPtr intPtr = vtkProperty_GetEmissiveFactor_69(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetEmissiveFactor_70(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the emissive factor.
	/// This value is multiplied with the emissive color when an emissive texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void GetEmissiveFactor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty_GetEmissiveFactor_70(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetEmissiveFactor_71(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the emissive factor.
	/// This value is multiplied with the emissive color when an emissive texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void GetEmissiveFactor(IntPtr _arg)
	{
		vtkProperty_GetEmissiveFactor_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetFrontfaceCulling_72(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast culling of polygons based on orientation of normal
	/// with respect to camera. If frontface culling is on, polygons facing
	/// towards camera are not drawn.
	/// </summary>
	public virtual int GetFrontfaceCulling()
	{
		return vtkProperty_GetFrontfaceCulling_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetInformation_73(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the information object associated with the Property.
	/// </summary>
	public virtual vtkInformation GetInformation()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProperty_GetInformation_73(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkProperty_GetInterpolation_74(HandleRef pThis);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public virtual int GetInterpolation()
	{
		return vtkProperty_GetInterpolation_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetInterpolationAsString_75(HandleRef pThis);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public string GetInterpolationAsString()
	{
		return Marshal.PtrToStringAnsi(vtkProperty_GetInterpolationAsString_75(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetInterpolationMaxValue_76(HandleRef pThis);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public virtual int GetInterpolationMaxValue()
	{
		return vtkProperty_GetInterpolationMaxValue_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetInterpolationMinValue_77(HandleRef pThis);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public virtual int GetInterpolationMinValue()
	{
		return vtkProperty_GetInterpolationMinValue_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProperty_GetLighting_78(HandleRef pThis);

	/// <summary>
	/// Set/Get lighting flag for an object. Initial value is true.
	/// </summary>
	public virtual bool GetLighting()
	{
		return (vtkProperty_GetLighting_78(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetLineStipplePattern_79(HandleRef pThis);

	/// <summary>
	/// Set/Get the stippling pattern of a Line, as a 16-bit binary pattern
	/// (1 = pixel on, 0 = pixel off).
	/// This is only implemented for OpenGL, not OpenGL2. The default is 0xFFFF.
	/// </summary>
	public virtual int GetLineStipplePattern()
	{
		return vtkProperty_GetLineStipplePattern_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetLineStippleRepeatFactor_80(HandleRef pThis);

	/// <summary>
	/// Set/Get the stippling repeat factor of a Line, which specifies how
	/// many times each bit in the pattern is to be repeated.
	/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
	/// </summary>
	public virtual int GetLineStippleRepeatFactor()
	{
		return vtkProperty_GetLineStippleRepeatFactor_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetLineStippleRepeatFactorMaxValue_81(HandleRef pThis);

	/// <summary>
	/// Set/Get the stippling repeat factor of a Line, which specifies how
	/// many times each bit in the pattern is to be repeated.
	/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
	/// </summary>
	public virtual int GetLineStippleRepeatFactorMaxValue()
	{
		return vtkProperty_GetLineStippleRepeatFactorMaxValue_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetLineStippleRepeatFactorMinValue_82(HandleRef pThis);

	/// <summary>
	/// Set/Get the stippling repeat factor of a Line, which specifies how
	/// many times each bit in the pattern is to be repeated.
	/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
	/// </summary>
	public virtual int GetLineStippleRepeatFactorMinValue()
	{
		return vtkProperty_GetLineStippleRepeatFactorMinValue_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty_GetLineWidth_83(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of a Line. The width is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetLineWidth()
	{
		return vtkProperty_GetLineWidth_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty_GetLineWidthMaxValue_84(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of a Line. The width is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetLineWidthMaxValue()
	{
		return vtkProperty_GetLineWidthMaxValue_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty_GetLineWidthMinValue_85(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of a Line. The width is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetLineWidthMinValue()
	{
		return vtkProperty_GetLineWidthMinValue_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetMaterialName_86(HandleRef pThis);

	/// <summary>
	/// Returns the name of the material currently loaded, if any.
	/// </summary>
	public virtual string GetMaterialName()
	{
		return Marshal.PtrToStringAnsi(vtkProperty_GetMaterialName_86(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetMetallic_87(HandleRef pThis);

	/// <summary>
	/// Set/Get the metallic coefficient.
	/// Usually this value is either 0 or 1 for real material but any value in between is valid.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetMetallic()
	{
		return vtkProperty_GetMetallic_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetMetallicMaxValue_88(HandleRef pThis);

	/// <summary>
	/// Set/Get the metallic coefficient.
	/// Usually this value is either 0 or 1 for real material but any value in between is valid.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetMetallicMaxValue()
	{
		return vtkProperty_GetMetallicMaxValue_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetMetallicMinValue_89(HandleRef pThis);

	/// <summary>
	/// Set/Get the metallic coefficient.
	/// Usually this value is either 0 or 1 for real material but any value in between is valid.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual double GetMetallicMinValue()
	{
		return vtkProperty_GetMetallicMinValue_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetNormalScale_90(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal scale coefficient.
	/// This value affects the strength of the normal deviation from the texture.
	/// Default value is 1.0
	/// </summary>
	public virtual double GetNormalScale()
	{
		return vtkProperty_GetNormalScale_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProperty_GetNumberOfGenerationsFromBase_91(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProperty_GetNumberOfGenerationsFromBase_91(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProperty_GetNumberOfGenerationsFromBaseType_92(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProperty_GetNumberOfGenerationsFromBaseType_92(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetNumberOfTextures_93(HandleRef pThis);

	/// <summary>
	/// Returns the number of textures in this property.
	/// </summary>
	public int GetNumberOfTextures()
	{
		return vtkProperty_GetNumberOfTextures_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetOcclusionStrength_94(HandleRef pThis);

	/// <summary>
	/// Set/Get the occlusion strength coefficient.
	/// This value affects the strength of the occlusion if a material texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.0
	/// </summary>
	public virtual double GetOcclusionStrength()
	{
		return vtkProperty_GetOcclusionStrength_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetOcclusionStrengthMaxValue_95(HandleRef pThis);

	/// <summary>
	/// Set/Get the occlusion strength coefficient.
	/// This value affects the strength of the occlusion if a material texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.0
	/// </summary>
	public virtual double GetOcclusionStrengthMaxValue()
	{
		return vtkProperty_GetOcclusionStrengthMaxValue_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetOcclusionStrengthMinValue_96(HandleRef pThis);

	/// <summary>
	/// Set/Get the occlusion strength coefficient.
	/// This value affects the strength of the occlusion if a material texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.0
	/// </summary>
	public virtual double GetOcclusionStrengthMinValue()
	{
		return vtkProperty_GetOcclusionStrengthMinValue_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetOpacity_97(HandleRef pThis);

	/// <summary>
	/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetOpacity()
	{
		return vtkProperty_GetOpacity_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetOpacityMaxValue_98(HandleRef pThis);

	/// <summary>
	/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetOpacityMaxValue()
	{
		return vtkProperty_GetOpacityMaxValue_98(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetOpacityMinValue_99(HandleRef pThis);

	/// <summary>
	/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetOpacityMinValue()
	{
		return vtkProperty_GetOpacityMinValue_99(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty_GetPointSize_100(HandleRef pThis);

	/// <summary>
	/// Set/Get the diameter of a point. The size is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetPointSize()
	{
		return vtkProperty_GetPointSize_100(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty_GetPointSizeMaxValue_101(HandleRef pThis);

	/// <summary>
	/// Set/Get the diameter of a point. The size is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetPointSizeMaxValue()
	{
		return vtkProperty_GetPointSizeMaxValue_101(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty_GetPointSizeMinValue_102(HandleRef pThis);

	/// <summary>
	/// Set/Get the diameter of a point. The size is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetPointSizeMinValue()
	{
		return vtkProperty_GetPointSizeMinValue_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProperty_GetRenderLinesAsTubes_103(HandleRef pThis);

	/// <summary>
	/// Set/Get rendering of lines as tubes. The width of the
	/// line in pixels is controlled by the LineWidth
	/// attribute. May not be supported on every platform
	/// and the implementation may be half tubes, or something
	/// only tube like in appearance.
	/// </summary>
	public virtual bool GetRenderLinesAsTubes()
	{
		return (vtkProperty_GetRenderLinesAsTubes_103(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProperty_GetRenderPointsAsSpheres_104(HandleRef pThis);

	/// <summary>
	/// Set/Get rendering of points as spheres. The size of the
	/// sphere in pixels is controlled by the PointSize
	/// attribute. Note that half spheres may be rendered
	/// instead of spheres.
	/// </summary>
	public virtual bool GetRenderPointsAsSpheres()
	{
		return (vtkProperty_GetRenderPointsAsSpheres_104(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetRepresentation_105(HandleRef pThis);

	/// <summary>
	/// Control the surface geometry representation for the object.
	/// </summary>
	public virtual int GetRepresentation()
	{
		return vtkProperty_GetRepresentation_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetRepresentationAsString_106(HandleRef pThis);

	/// <summary>
	/// Control the surface geometry representation for the object.
	/// </summary>
	public string GetRepresentationAsString()
	{
		return Marshal.PtrToStringAnsi(vtkProperty_GetRepresentationAsString_106(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetRepresentationMaxValue_107(HandleRef pThis);

	/// <summary>
	/// Control the surface geometry representation for the object.
	/// </summary>
	public virtual int GetRepresentationMaxValue()
	{
		return vtkProperty_GetRepresentationMaxValue_107(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetRepresentationMinValue_108(HandleRef pThis);

	/// <summary>
	/// Control the surface geometry representation for the object.
	/// </summary>
	public virtual int GetRepresentationMinValue()
	{
		return vtkProperty_GetRepresentationMinValue_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetRoughness_109(HandleRef pThis);

	/// <summary>
	/// Set/Get the roughness coefficient.
	/// This value has to be between 0 (glossy) and 1 (rough).
	/// A glossy material has reflections and a high specular part.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.5
	/// </summary>
	public virtual double GetRoughness()
	{
		return vtkProperty_GetRoughness_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetRoughnessMaxValue_110(HandleRef pThis);

	/// <summary>
	/// Set/Get the roughness coefficient.
	/// This value has to be between 0 (glossy) and 1 (rough).
	/// A glossy material has reflections and a high specular part.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.5
	/// </summary>
	public virtual double GetRoughnessMaxValue()
	{
		return vtkProperty_GetRoughnessMaxValue_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetRoughnessMinValue_111(HandleRef pThis);

	/// <summary>
	/// Set/Get the roughness coefficient.
	/// This value has to be between 0 (glossy) and 1 (rough).
	/// A glossy material has reflections and a high specular part.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.5
	/// </summary>
	public virtual double GetRoughnessMinValue()
	{
		return vtkProperty_GetRoughnessMinValue_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetSelectionColor_112(HandleRef pThis);

	/// <summary>
	/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
	/// Default is red and opaque.
	/// </summary>
	public virtual double[] GetSelectionColor()
	{
		IntPtr intPtr = vtkProperty_GetSelectionColor_112(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetSelectionColor_113(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
	/// Default is red and opaque.
	/// </summary>
	public virtual void GetSelectionColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkProperty_GetSelectionColor_113(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetSelectionColor_114(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
	/// Default is red and opaque.
	/// </summary>
	public virtual void GetSelectionColor(IntPtr _arg)
	{
		vtkProperty_GetSelectionColor_114(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty_GetSelectionLineWidth_115(HandleRef pThis);

	/// <summary>
	/// Set/Get the selection line width.
	/// Default is 2.
	/// </summary>
	public virtual float GetSelectionLineWidth()
	{
		return vtkProperty_GetSelectionLineWidth_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty_GetSelectionPointSize_116(HandleRef pThis);

	/// <summary>
	/// Set/Get the selection point size.
	/// Default is 2.
	/// </summary>
	public virtual float GetSelectionPointSize()
	{
		return vtkProperty_GetSelectionPointSize_116(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetShading_117(HandleRef pThis);

	/// <summary>
	/// Enable/Disable shading. When shading is enabled, the
	/// Material must be set.
	/// </summary>
	public virtual int GetShading()
	{
		return vtkProperty_GetShading_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkProperty_GetShowTexturesOnBackface_118(HandleRef pThis);

	/// <summary>
	/// Show texture maps when the geometry is backfacing. Texture maps are
	/// always shown when frontfacing. By default this is true.
	/// </summary>
	public virtual bool GetShowTexturesOnBackface()
	{
		return (vtkProperty_GetShowTexturesOnBackface_118(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetSpecular_119(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular lighting coefficient.
	/// </summary>
	public virtual double GetSpecular()
	{
		return vtkProperty_GetSpecular_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetSpecularColor_120(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular surface color.
	/// </summary>
	public virtual double[] GetSpecularColor()
	{
		IntPtr intPtr = vtkProperty_GetSpecularColor_120(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetSpecularColor_121(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the specular surface color.
	/// </summary>
	public virtual void GetSpecularColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty_GetSpecularColor_121(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetSpecularColor_122(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the specular surface color.
	/// </summary>
	public virtual void GetSpecularColor(IntPtr _arg)
	{
		vtkProperty_GetSpecularColor_122(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetSpecularMaxValue_123(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular lighting coefficient.
	/// </summary>
	public virtual double GetSpecularMaxValue()
	{
		return vtkProperty_GetSpecularMaxValue_123(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetSpecularMinValue_124(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular lighting coefficient.
	/// </summary>
	public virtual double GetSpecularMinValue()
	{
		return vtkProperty_GetSpecularMinValue_124(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetSpecularPower_125(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular power.
	/// </summary>
	public virtual double GetSpecularPower()
	{
		return vtkProperty_GetSpecularPower_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetSpecularPowerMaxValue_126(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular power.
	/// </summary>
	public virtual double GetSpecularPowerMaxValue()
	{
		return vtkProperty_GetSpecularPowerMaxValue_126(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty_GetSpecularPowerMinValue_127(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular power.
	/// </summary>
	public virtual double GetSpecularPowerMinValue()
	{
		return vtkProperty_GetSpecularPowerMinValue_127(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetTexture_128(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the texture object to control rendering texture maps. This will
	/// be a vtkTexture object. A property does not need to have an associated
	/// texture map and multiple properties can share one texture. Textures
	/// must be assigned unique names. Note that for texture blending the
	/// textures will be rendering is alphabetical order and after any texture
	/// defined in the actor.
	/// There exists 6 special textures with reserved names: "albedoTex", "materialTex", "normalTex",
	/// "emissiveTex", "anisotropyTex" and "coatNormalTex". While these textures can be added with the
	/// regular SetTexture method, it is preferred to use the methods SetBaseColorTexture,
	/// SetORMTexture, SetNormalTexture, SetEmissiveTexture, SetAnisotropyTexture and SetCoatNormalTex
	/// respectively.
	/// </summary>
	public vtkTexture GetTexture(string name)
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProperty_GetTexture_128(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_GetVertexColor_129(HandleRef pThis);

	/// <summary>
	/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
	/// </summary>
	public virtual double[] GetVertexColor()
	{
		IntPtr intPtr = vtkProperty_GetVertexColor_129(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetVertexColor_130(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
	/// </summary>
	public virtual void GetVertexColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty_GetVertexColor_130(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_GetVertexColor_131(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
	/// </summary>
	public virtual void GetVertexColor(IntPtr _arg)
	{
		vtkProperty_GetVertexColor_131(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_GetVertexVisibility_132(HandleRef pThis);

	/// <summary>
	/// Turn on/off the visibility of vertices. On some renderers it is
	/// possible to render the vertices of geometric primitives separately
	/// from the interior.
	/// </summary>
	public virtual int GetVertexVisibility()
	{
		return vtkProperty_GetVertexVisibility_132(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_IsA_133(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProperty_IsA_133(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty_IsTypeOf_134(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProperty_IsTypeOf_134(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_LightingOff_135(HandleRef pThis);

	/// <summary>
	/// Set/Get lighting flag for an object. Initial value is true.
	/// </summary>
	public virtual void LightingOff()
	{
		vtkProperty_LightingOff_135(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_LightingOn_136(HandleRef pThis);

	/// <summary>
	/// Set/Get lighting flag for an object. Initial value is true.
	/// </summary>
	public virtual void LightingOn()
	{
		vtkProperty_LightingOn_136(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_NewInstance_138(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProperty NewInstance()
	{
		vtkProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProperty_NewInstance_138(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_PostRender_139(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// This method is called after the actor has been rendered.
	/// Don't call this directly. This method cleans up
	/// any shaders allocated.
	/// </summary>
	public virtual void PostRender(vtkActor arg0, vtkRenderer arg1)
	{
		vtkProperty_PostRender_139(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_ReleaseGraphicsResources_140(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Release any graphics resources that are being consumed by this
	/// property. The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkProperty_ReleaseGraphicsResources_140(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_RemoveAllTextures_141(HandleRef pThis);

	/// <summary>
	/// Remove all the textures.
	/// </summary>
	public void RemoveAllTextures()
	{
		vtkProperty_RemoveAllTextures_141(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_RemoveTexture_142(HandleRef pThis, string name);

	/// <summary>
	/// Remove a texture from the collection.
	/// </summary>
	public void RemoveTexture(string name)
	{
		vtkProperty_RemoveTexture_142(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_Render_143(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// This method causes the property to set up whatever is required for
	/// its instance variables. This is actually handled by a subclass of
	/// vtkProperty, which is created automatically. This
	/// method includes the invoking actor as an argument which can
	/// be used by property devices that require the actor.
	/// </summary>
	public virtual void Render(vtkActor arg0, vtkRenderer arg1)
	{
		vtkProperty_Render_143(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_RenderLinesAsTubesOff_144(HandleRef pThis);

	/// <summary>
	/// Set/Get rendering of lines as tubes. The width of the
	/// line in pixels is controlled by the LineWidth
	/// attribute. May not be supported on every platform
	/// and the implementation may be half tubes, or something
	/// only tube like in appearance.
	/// </summary>
	public virtual void RenderLinesAsTubesOff()
	{
		vtkProperty_RenderLinesAsTubesOff_144(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_RenderLinesAsTubesOn_145(HandleRef pThis);

	/// <summary>
	/// Set/Get rendering of lines as tubes. The width of the
	/// line in pixels is controlled by the LineWidth
	/// attribute. May not be supported on every platform
	/// and the implementation may be half tubes, or something
	/// only tube like in appearance.
	/// </summary>
	public virtual void RenderLinesAsTubesOn()
	{
		vtkProperty_RenderLinesAsTubesOn_145(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_RenderPointsAsSpheresOff_146(HandleRef pThis);

	/// <summary>
	/// Set/Get rendering of points as spheres. The size of the
	/// sphere in pixels is controlled by the PointSize
	/// attribute. Note that half spheres may be rendered
	/// instead of spheres.
	/// </summary>
	public virtual void RenderPointsAsSpheresOff()
	{
		vtkProperty_RenderPointsAsSpheresOff_146(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_RenderPointsAsSpheresOn_147(HandleRef pThis);

	/// <summary>
	/// Set/Get rendering of points as spheres. The size of the
	/// sphere in pixels is controlled by the PointSize
	/// attribute. Note that half spheres may be rendered
	/// instead of spheres.
	/// </summary>
	public virtual void RenderPointsAsSpheresOn()
	{
		vtkProperty_RenderPointsAsSpheresOn_147(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty_SafeDownCast_148(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProperty SafeDownCast(vtkObjectBase o)
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProperty_SafeDownCast_148(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetAmbient_149(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ambient lighting coefficient.
	/// </summary>
	public virtual void SetAmbient(double _arg)
	{
		vtkProperty_SetAmbient_149(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetAmbientColor_150(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the ambient surface color. Not all renderers support separate
	/// ambient and diffuse colors. From a physical standpoint it really
	/// doesn't make too much sense to have both. For the rendering
	/// libraries that don't support both, the diffuse color is used.
	/// </summary>
	public virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty_SetAmbientColor_150(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetAmbientColor_151(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the ambient surface color. Not all renderers support separate
	/// ambient and diffuse colors. From a physical standpoint it really
	/// doesn't make too much sense to have both. For the rendering
	/// libraries that don't support both, the diffuse color is used.
	/// </summary>
	public virtual void SetAmbientColor(IntPtr _arg)
	{
		vtkProperty_SetAmbientColor_151(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetAnisotropy_152(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the anisotropy coefficient.
	/// This value controls the anisotropy of the material (0.0 means isotropic)
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual void SetAnisotropy(double _arg)
	{
		vtkProperty_SetAnisotropy_152(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetAnisotropyRotation_153(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the anisotropy rotation coefficient.
	/// This value controls the rotation of the direction of the anisotropy.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual void SetAnisotropyRotation(double _arg)
	{
		vtkProperty_SetAnisotropyRotation_153(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetAnisotropyTexture_154(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Set the anisotropy texture. This texture contains two independent components corresponding to
	/// the anisotropy value and anisotropy rotation. The last component (blue channel) is discarded.
	/// The anisotropy value is scaled by the anisotropy coefficient of the material. The anisotropy
	/// rotation rotates the direction of the anisotropy (ie. the tangent) around the normal and is not
	/// scaled by the anisotropy rotation coefficient.
	/// This texture must be in linear color space.
	/// This is only used by the PBR shading model.
	/// @sa SetInterpolationToPBR SetAnisotropy
	/// </summary>
	public void SetAnisotropyTexture(vtkTexture texture)
	{
		vtkProperty_SetAnisotropyTexture_154(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetBackfaceCulling_155(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off fast culling of polygons based on orientation of normal
	/// with respect to camera. If backface culling is on, polygons facing
	/// away from camera are not drawn.
	/// </summary>
	public virtual void SetBackfaceCulling(int _arg)
	{
		vtkProperty_SetBackfaceCulling_155(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetBaseColorTexture_156(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Set the base color texture. Also called albedo, this texture is only used while rendering
	/// with PBR interpolation. This is the color of the object.
	/// This texture must be in sRGB color space.
	/// @sa SetInterpolationToPBR vtkTexture::UseSRGBColorSpaceOn
	/// </summary>
	public void SetBaseColorTexture(vtkTexture texture)
	{
		vtkProperty_SetBaseColorTexture_156(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetBaseIOR_157(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Index Of Refraction of the base layer.
	/// It controls the amount of light reflected at normal incidence (the reflectance F0),
	/// depending on the IOR of the upper layer (eg. coat layer, or environment).
	/// For example, with a base IOR of 1.5 and an IOR of 1.0 outside (IOR of the air),
	/// 4% of the amount of the light is reflected at normal incidence.
	/// Notice that modifying this value is only useful for dielectrics materials, as
	/// the reflectance for metallic is the albedo.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.5
	/// </summary>
	public virtual void SetBaseIOR(double _arg)
	{
		vtkProperty_SetBaseIOR_157(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetCoatColor_158(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the color of the coat layer.
	/// This value is only used by PBR Interpolation.
	/// Default value is white [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void SetCoatColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty_SetCoatColor_158(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetCoatColor_159(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of the coat layer.
	/// This value is only used by PBR Interpolation.
	/// Default value is white [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void SetCoatColor(IntPtr _arg)
	{
		vtkProperty_SetCoatColor_159(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetCoatIOR_160(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the coat layer Index Of Refraction.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 2.0
	/// </summary>
	public virtual void SetCoatIOR(double _arg)
	{
		vtkProperty_SetCoatIOR_160(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetCoatNormalScale_161(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the coat layer normal scale coefficient.
	/// This value affects the strength of the normal deviation from the coat normal texture.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.0
	/// </summary>
	public virtual void SetCoatNormalScale(double _arg)
	{
		vtkProperty_SetCoatNormalScale_161(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetCoatNormalTexture_162(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Set the coat normal texture. This texture is required for coat normal mapping.
	/// It is valid only for PBR interpolation.
	/// The coat normal mapping is enabled if this texture is present and both normals and tangents are
	/// presents in the vtkPolyData.
	/// This texture must be in linear color space.
	/// @sa vtkPolyDataTangents SetCoatNormalScale
	/// </summary>
	public void SetCoatNormalTexture(vtkTexture texture)
	{
		vtkProperty_SetCoatNormalTexture_162(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetCoatRoughness_163(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the coat layer roughness coefficient.
	/// This value has to be between 0 (glossy) and 1 (rough).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual void SetCoatRoughness(double _arg)
	{
		vtkProperty_SetCoatRoughness_163(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetCoatStrength_164(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the coat layer strength coefficient.
	/// This value affects the strength of the coat layer reflection.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual void SetCoatStrength(double _arg)
	{
		vtkProperty_SetCoatStrength_164(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetColor_165(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the color of the object. Has the side effect of setting the
	/// ambient diffuse and specular colors as well. This is basically
	/// a quick overall color setting method.
	/// </summary>
	public virtual void SetColor(double r, double g, double b)
	{
		vtkProperty_SetColor_165(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetColor_166(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the color of the object. Has the side effect of setting the
	/// ambient diffuse and specular colors as well. This is basically
	/// a quick overall color setting method.
	/// </summary>
	public virtual void SetColor(IntPtr a)
	{
		vtkProperty_SetColor_166(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetDiffuse_167(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the diffuse lighting coefficient.
	/// </summary>
	public virtual void SetDiffuse(double _arg)
	{
		vtkProperty_SetDiffuse_167(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetDiffuseColor_168(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the diffuse surface color.
	/// For PBR Interpolation, DiffuseColor is used as the base color
	/// </summary>
	public virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty_SetDiffuseColor_168(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetDiffuseColor_169(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the diffuse surface color.
	/// For PBR Interpolation, DiffuseColor is used as the base color
	/// </summary>
	public virtual void SetDiffuseColor(IntPtr _arg)
	{
		vtkProperty_SetDiffuseColor_169(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetEdgeColor_170(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the color of primitive edges (if edge visibility is enabled).
	/// </summary>
	public virtual void SetEdgeColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty_SetEdgeColor_170(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetEdgeColor_171(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of primitive edges (if edge visibility is enabled).
	/// </summary>
	public virtual void SetEdgeColor(IntPtr _arg)
	{
		vtkProperty_SetEdgeColor_171(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetEdgeTint_172(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the edge tint (for metals only).
	/// Set the color at grazing angle (fresnel reflectance).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void SetEdgeTint(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty_SetEdgeTint_172(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetEdgeTint_173(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the edge tint (for metals only).
	/// Set the color at grazing angle (fresnel reflectance).
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void SetEdgeTint(IntPtr _arg)
	{
		vtkProperty_SetEdgeTint_173(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetEdgeVisibility_174(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the visibility of edges. On some renderers it is
	/// possible to render the edges of geometric primitives separately
	/// from the interior.
	/// </summary>
	public virtual void SetEdgeVisibility(int _arg)
	{
		vtkProperty_SetEdgeVisibility_174(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetEmissiveFactor_175(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the emissive factor.
	/// This value is multiplied with the emissive color when an emissive texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void SetEmissiveFactor(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty_SetEmissiveFactor_175(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetEmissiveFactor_176(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the emissive factor.
	/// This value is multiplied with the emissive color when an emissive texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is [1.0, 1.0, 1.0]
	/// </summary>
	public virtual void SetEmissiveFactor(IntPtr _arg)
	{
		vtkProperty_SetEmissiveFactor_176(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetEmissiveTexture_177(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Set the emissive texture. When present, this RGB texture provides location and color to the
	/// shader where the vtkPolyData should emit light. Emitted light is scaled by EmissiveFactor.
	/// This is only supported by PBR interpolation model.
	/// This texture must be in sRGB color space.
	/// @sa SetInterpolationToPBR SetEmissiveFactor vtkTexture::UseSRGBColorSpaceOn
	/// </summary>
	public void SetEmissiveTexture(vtkTexture texture)
	{
		vtkProperty_SetEmissiveTexture_177(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetFrontfaceCulling_178(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off fast culling of polygons based on orientation of normal
	/// with respect to camera. If frontface culling is on, polygons facing
	/// towards camera are not drawn.
	/// </summary>
	public virtual void SetFrontfaceCulling(int _arg)
	{
		vtkProperty_SetFrontfaceCulling_178(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetInformation_179(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the information object associated with the Property.
	/// </summary>
	public virtual void SetInformation(vtkInformation arg0)
	{
		vtkProperty_SetInformation_179(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetInterpolation_180(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public virtual void SetInterpolation(int _arg)
	{
		vtkProperty_SetInterpolation_180(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetInterpolationToFlat_181(HandleRef pThis);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public void SetInterpolationToFlat()
	{
		vtkProperty_SetInterpolationToFlat_181(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetInterpolationToGouraud_182(HandleRef pThis);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public void SetInterpolationToGouraud()
	{
		vtkProperty_SetInterpolationToGouraud_182(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetInterpolationToPBR_183(HandleRef pThis);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public void SetInterpolationToPBR()
	{
		vtkProperty_SetInterpolationToPBR_183(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetInterpolationToPhong_184(HandleRef pThis);

	/// <summary>
	/// Set the shading interpolation method for an object.
	/// </summary>
	public void SetInterpolationToPhong()
	{
		vtkProperty_SetInterpolationToPhong_184(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetLighting_185(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get lighting flag for an object. Initial value is true.
	/// </summary>
	public virtual void SetLighting(bool _arg)
	{
		vtkProperty_SetLighting_185(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetLineStipplePattern_186(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the stippling pattern of a Line, as a 16-bit binary pattern
	/// (1 = pixel on, 0 = pixel off).
	/// This is only implemented for OpenGL, not OpenGL2. The default is 0xFFFF.
	/// </summary>
	public virtual void SetLineStipplePattern(int _arg)
	{
		vtkProperty_SetLineStipplePattern_186(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetLineStippleRepeatFactor_187(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the stippling repeat factor of a Line, which specifies how
	/// many times each bit in the pattern is to be repeated.
	/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
	/// </summary>
	public virtual void SetLineStippleRepeatFactor(int _arg)
	{
		vtkProperty_SetLineStippleRepeatFactor_187(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetLineWidth_188(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the width of a Line. The width is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual void SetLineWidth(float _arg)
	{
		vtkProperty_SetLineWidth_188(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetMaterialName_189(HandleRef pThis, string _arg);

	/// <summary>
	/// Returns the name of the material currently loaded, if any.
	/// </summary>
	public virtual void SetMaterialName(string _arg)
	{
		vtkProperty_SetMaterialName_189(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetMetallic_190(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the metallic coefficient.
	/// Usually this value is either 0 or 1 for real material but any value in between is valid.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.0
	/// </summary>
	public virtual void SetMetallic(double _arg)
	{
		vtkProperty_SetMetallic_190(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetNormalScale_191(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the normal scale coefficient.
	/// This value affects the strength of the normal deviation from the texture.
	/// Default value is 1.0
	/// </summary>
	public virtual void SetNormalScale(double _arg)
	{
		vtkProperty_SetNormalScale_191(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetNormalTexture_192(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Set the normal texture. This texture is required for normal mapping. It is valid for both PBR
	/// and Phong interpolation.
	/// The normal mapping is enabled if this texture is present and both normals and tangents are
	/// presents in the vtkPolyData.
	/// This texture must be in linear color space.
	/// @sa vtkPolyDataTangents SetNormalScale
	/// </summary>
	public void SetNormalTexture(vtkTexture texture)
	{
		vtkProperty_SetNormalTexture_192(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetORMTexture_193(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Set the ORM texture. This texture contains three RGB independent components corresponding to
	/// the Occlusion value, Roughness value and Metallic value respectively.
	/// Each texture value is scaled by the Occlusion strength, roughness coefficient and metallic
	/// coefficient.
	/// This texture must be in linear color space.
	/// This is only used by the PBR shading model.
	/// @sa SetInterpolationToPBR SetOcclusionStrength SetMetallic SetRoughness
	/// </summary>
	public void SetORMTexture(vtkTexture texture)
	{
		vtkProperty_SetORMTexture_193(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetOcclusionStrength_194(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the occlusion strength coefficient.
	/// This value affects the strength of the occlusion if a material texture is present.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 1.0
	/// </summary>
	public virtual void SetOcclusionStrength(double _arg)
	{
		vtkProperty_SetOcclusionStrength_194(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetOpacity_195(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual void SetOpacity(double _arg)
	{
		vtkProperty_SetOpacity_195(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetPointSize_196(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the diameter of a point. The size is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual void SetPointSize(float _arg)
	{
		vtkProperty_SetPointSize_196(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetRenderLinesAsTubes_197(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get rendering of lines as tubes. The width of the
	/// line in pixels is controlled by the LineWidth
	/// attribute. May not be supported on every platform
	/// and the implementation may be half tubes, or something
	/// only tube like in appearance.
	/// </summary>
	public virtual void SetRenderLinesAsTubes(bool _arg)
	{
		vtkProperty_SetRenderLinesAsTubes_197(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetRenderPointsAsSpheres_198(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get rendering of points as spheres. The size of the
	/// sphere in pixels is controlled by the PointSize
	/// attribute. Note that half spheres may be rendered
	/// instead of spheres.
	/// </summary>
	public virtual void SetRenderPointsAsSpheres(bool _arg)
	{
		vtkProperty_SetRenderPointsAsSpheres_198(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetRepresentation_199(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the surface geometry representation for the object.
	/// </summary>
	public virtual void SetRepresentation(int _arg)
	{
		vtkProperty_SetRepresentation_199(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetRepresentationToPoints_200(HandleRef pThis);

	/// <summary>
	/// Control the surface geometry representation for the object.
	/// </summary>
	public void SetRepresentationToPoints()
	{
		vtkProperty_SetRepresentationToPoints_200(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetRepresentationToSurface_201(HandleRef pThis);

	/// <summary>
	/// Control the surface geometry representation for the object.
	/// </summary>
	public void SetRepresentationToSurface()
	{
		vtkProperty_SetRepresentationToSurface_201(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetRepresentationToWireframe_202(HandleRef pThis);

	/// <summary>
	/// Control the surface geometry representation for the object.
	/// </summary>
	public void SetRepresentationToWireframe()
	{
		vtkProperty_SetRepresentationToWireframe_202(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetRoughness_203(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the roughness coefficient.
	/// This value has to be between 0 (glossy) and 1 (rough).
	/// A glossy material has reflections and a high specular part.
	/// This parameter is only used by PBR Interpolation.
	/// Default value is 0.5
	/// </summary>
	public virtual void SetRoughness(double _arg)
	{
		vtkProperty_SetRoughness_203(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetSelectionColor_204(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
	/// Default is red and opaque.
	/// </summary>
	public virtual void SetSelectionColor(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkProperty_SetSelectionColor_204(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetSelectionColor_205(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
	/// Default is red and opaque.
	/// </summary>
	public virtual void SetSelectionColor(IntPtr _arg)
	{
		vtkProperty_SetSelectionColor_205(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetSelectionLineWidth_206(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the selection line width.
	/// Default is 2.
	/// </summary>
	public virtual void SetSelectionLineWidth(float _arg)
	{
		vtkProperty_SetSelectionLineWidth_206(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetSelectionPointSize_207(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the selection point size.
	/// Default is 2.
	/// </summary>
	public virtual void SetSelectionPointSize(float _arg)
	{
		vtkProperty_SetSelectionPointSize_207(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetShading_208(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable shading. When shading is enabled, the
	/// Material must be set.
	/// </summary>
	public virtual void SetShading(int _arg)
	{
		vtkProperty_SetShading_208(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetShowTexturesOnBackface_209(HandleRef pThis, byte _arg);

	/// <summary>
	/// Show texture maps when the geometry is backfacing. Texture maps are
	/// always shown when frontfacing. By default this is true.
	/// </summary>
	public virtual void SetShowTexturesOnBackface(bool _arg)
	{
		vtkProperty_SetShowTexturesOnBackface_209(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetSpecular_210(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the specular lighting coefficient.
	/// </summary>
	public virtual void SetSpecular(double _arg)
	{
		vtkProperty_SetSpecular_210(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetSpecularColor_211(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the specular surface color.
	/// </summary>
	public virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty_SetSpecularColor_211(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetSpecularColor_212(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the specular surface color.
	/// </summary>
	public virtual void SetSpecularColor(IntPtr _arg)
	{
		vtkProperty_SetSpecularColor_212(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetSpecularPower_213(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the specular power.
	/// </summary>
	public virtual void SetSpecularPower(double _arg)
	{
		vtkProperty_SetSpecularPower_213(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetTexture_214(HandleRef pThis, string name, HandleRef texture);

	/// <summary>
	/// Set/Get the texture object to control rendering texture maps. This will
	/// be a vtkTexture object. A property does not need to have an associated
	/// texture map and multiple properties can share one texture. Textures
	/// must be assigned unique names. Note that for texture blending the
	/// textures will be rendering is alphabetical order and after any texture
	/// defined in the actor.
	/// There exists 6 special textures with reserved names: "albedoTex", "materialTex", "normalTex",
	/// "emissiveTex", "anisotropyTex" and "coatNormalTex". While these textures can be added with the
	/// regular SetTexture method, it is preferred to use the methods SetBaseColorTexture,
	/// SetORMTexture, SetNormalTexture, SetEmissiveTexture, SetAnisotropyTexture and SetCoatNormalTex
	/// respectively.
	/// </summary>
	public void SetTexture(string name, vtkTexture texture)
	{
		vtkProperty_SetTexture_214(GetCppThis(), name, texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetVertexColor_215(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
	/// </summary>
	public virtual void SetVertexColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty_SetVertexColor_215(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetVertexColor_216(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
	/// </summary>
	public virtual void SetVertexColor(IntPtr _arg)
	{
		vtkProperty_SetVertexColor_216(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_SetVertexVisibility_217(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the visibility of vertices. On some renderers it is
	/// possible to render the vertices of geometric primitives separately
	/// from the interior.
	/// </summary>
	public virtual void SetVertexVisibility(int _arg)
	{
		vtkProperty_SetVertexVisibility_217(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_ShadingOff_218(HandleRef pThis);

	/// <summary>
	/// Enable/Disable shading. When shading is enabled, the
	/// Material must be set.
	/// </summary>
	public virtual void ShadingOff()
	{
		vtkProperty_ShadingOff_218(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_ShadingOn_219(HandleRef pThis);

	/// <summary>
	/// Enable/Disable shading. When shading is enabled, the
	/// Material must be set.
	/// </summary>
	public virtual void ShadingOn()
	{
		vtkProperty_ShadingOn_219(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_ShowTexturesOnBackfaceOff_220(HandleRef pThis);

	/// <summary>
	/// Show texture maps when the geometry is backfacing. Texture maps are
	/// always shown when frontfacing. By default this is true.
	/// </summary>
	public virtual void ShowTexturesOnBackfaceOff()
	{
		vtkProperty_ShowTexturesOnBackfaceOff_220(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_ShowTexturesOnBackfaceOn_221(HandleRef pThis);

	/// <summary>
	/// Show texture maps when the geometry is backfacing. Texture maps are
	/// always shown when frontfacing. By default this is true.
	/// </summary>
	public virtual void ShowTexturesOnBackfaceOn()
	{
		vtkProperty_ShowTexturesOnBackfaceOn_221(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_VertexVisibilityOff_222(HandleRef pThis);

	/// <summary>
	/// Turn on/off the visibility of vertices. On some renderers it is
	/// possible to render the vertices of geometric primitives separately
	/// from the interior.
	/// </summary>
	public virtual void VertexVisibilityOff()
	{
		vtkProperty_VertexVisibilityOff_222(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty_VertexVisibilityOn_223(HandleRef pThis);

	/// <summary>
	/// Turn on/off the visibility of vertices. On some renderers it is
	/// possible to render the vertices of geometric primitives separately
	/// from the interior.
	/// </summary>
	public virtual void VertexVisibilityOn()
	{
		vtkProperty_VertexVisibilityOn_223(GetCppThis());
	}
}
