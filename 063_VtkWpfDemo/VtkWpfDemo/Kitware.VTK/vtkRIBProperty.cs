using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRIBProperty
/// </summary>
/// <remarks>
///    RIP Property
///
/// vtkRIBProperty is a subclass of vtkProperty that allows the user to
/// specify named shaders for use with RenderMan. Both surface
/// and displacement shaders can be specified. Parameters
/// for the shaders can be declared and set.
///
/// </remarks>
/// <seealso>
///
/// vtkRIBExporter vtkRIBLight
/// </seealso>
public class vtkRIBProperty : vtkProperty
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRIBProperty";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRIBProperty()
	{
		MRClassNameKey = "class vtkRIBProperty";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRIBProperty"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRIBProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRIBProperty New()
	{
		vtkRIBProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRIBProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRIBProperty()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRIBProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_AddDisplacementShaderParameter_01(HandleRef pThis, string parameter, string value);

	/// <summary>
	/// Specify parameter values for displacement shader parameters
	/// </summary>
	public void AddDisplacementShaderParameter(string parameter, string value)
	{
		vtkRIBProperty_AddDisplacementShaderParameter_01(GetCppThis(), parameter, value);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_AddParameter_02(HandleRef pThis, string parameter, string value);

	/// <summary>
	/// Specify parameter values for variables.
	/// DEPRECATED: use (Set/Add)SurfaceShaderParameter instead.
	/// </summary>
	public void AddParameter(string parameter, string value)
	{
		vtkRIBProperty_AddParameter_02(GetCppThis(), parameter, value);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_AddSurfaceShaderParameter_03(HandleRef pThis, string parameter, string value);

	/// <summary>
	/// Specify parameter values for surface shader parameters
	/// </summary>
	public void AddSurfaceShaderParameter(string parameter, string value)
	{
		vtkRIBProperty_AddSurfaceShaderParameter_03(GetCppThis(), parameter, value);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_AddVariable_04(HandleRef pThis, string variable, string declaration);

	/// <summary>
	/// Specify declarations for variables.
	/// </summary>
	public void AddVariable(string variable, string declaration)
	{
		vtkRIBProperty_AddVariable_04(GetCppThis(), variable, declaration);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_GetDeclarations_05(HandleRef pThis);

	/// <summary>
	/// Get variable declarations
	/// </summary>
	public string GetDeclarations()
	{
		return Marshal.PtrToStringAnsi(vtkRIBProperty_GetDeclarations_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_GetDisplacementShader_06(HandleRef pThis);

	/// <summary>
	/// Specify the name of a displacement shader.
	/// </summary>
	public virtual string GetDisplacementShader()
	{
		return Marshal.PtrToStringAnsi(vtkRIBProperty_GetDisplacementShader_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_GetDisplacementShaderParameters_07(HandleRef pThis);

	/// <summary>
	/// Get parameters.
	/// </summary>
	public string GetDisplacementShaderParameters()
	{
		return Marshal.PtrToStringAnsi(vtkRIBProperty_GetDisplacementShaderParameters_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRIBProperty_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRIBProperty_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRIBProperty_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRIBProperty_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_GetParameters_10(HandleRef pThis);

	/// <summary>
	/// Get parameters.
	/// </summary>
	public string GetParameters()
	{
		return Marshal.PtrToStringAnsi(vtkRIBProperty_GetParameters_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_GetSurfaceShader_11(HandleRef pThis);

	/// <summary>
	/// Specify the name of a surface shader.
	/// </summary>
	public virtual string GetSurfaceShader()
	{
		return Marshal.PtrToStringAnsi(vtkRIBProperty_GetSurfaceShader_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_GetSurfaceShaderParameters_12(HandleRef pThis);

	/// <summary>
	/// Get parameters.
	/// </summary>
	public string GetSurfaceShaderParameters()
	{
		return Marshal.PtrToStringAnsi(vtkRIBProperty_GetSurfaceShaderParameters_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRIBProperty_GetSurfaceShaderUsesDefaultParameters_13(HandleRef pThis);

	/// <summary>
	/// If true (default) the surface shader uses the usual shader parameters:
	/// Ka - Ambient amount
	/// Kd - Diffuse amount
	/// Ks - Specular amount
	/// Roughness
	/// SpecularColor
	/// Additional surface shader parameters can be added with the
	/// Set/AddSurfaceShaderParameter methods.
	/// If false, all surface shader parameters must be specified
	/// </summary>
	public virtual bool GetSurfaceShaderUsesDefaultParameters()
	{
		return (vtkRIBProperty_GetSurfaceShaderUsesDefaultParameters_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRIBProperty_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRIBProperty_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRIBProperty_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRIBProperty_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRIBProperty NewInstance()
	{
		vtkRIBProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRIBProperty_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRIBProperty_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRIBProperty SafeDownCast(vtkObjectBase o)
	{
		vtkRIBProperty vtkRIBProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRIBProperty_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRIBProperty2 = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRIBProperty2.Register(null);
			}
		}
		return vtkRIBProperty2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SetDisplacementShader_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of a displacement shader.
	/// </summary>
	public virtual void SetDisplacementShader(string _arg)
	{
		vtkRIBProperty_SetDisplacementShader_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SetDisplacementShaderParameter_20(HandleRef pThis, string parameter, string value);

	/// <summary>
	/// Specify parameter values for displacement shader parameters
	/// </summary>
	public void SetDisplacementShaderParameter(string parameter, string value)
	{
		vtkRIBProperty_SetDisplacementShaderParameter_20(GetCppThis(), parameter, value);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SetParameter_21(HandleRef pThis, string parameter, string value);

	/// <summary>
	/// Specify parameter values for variables.
	/// DEPRECATED: use (Set/Add)SurfaceShaderParameter instead.
	/// </summary>
	public void SetParameter(string parameter, string value)
	{
		vtkRIBProperty_SetParameter_21(GetCppThis(), parameter, value);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SetSurfaceShader_22(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of a surface shader.
	/// </summary>
	public virtual void SetSurfaceShader(string _arg)
	{
		vtkRIBProperty_SetSurfaceShader_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SetSurfaceShaderParameter_23(HandleRef pThis, string parameter, string value);

	/// <summary>
	/// Specify parameter values for surface shader parameters
	/// </summary>
	public void SetSurfaceShaderParameter(string parameter, string value)
	{
		vtkRIBProperty_SetSurfaceShaderParameter_23(GetCppThis(), parameter, value);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SetSurfaceShaderUsesDefaultParameters_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true (default) the surface shader uses the usual shader parameters:
	/// Ka - Ambient amount
	/// Kd - Diffuse amount
	/// Ks - Specular amount
	/// Roughness
	/// SpecularColor
	/// Additional surface shader parameters can be added with the
	/// Set/AddSurfaceShaderParameter methods.
	/// If false, all surface shader parameters must be specified
	/// </summary>
	public virtual void SetSurfaceShaderUsesDefaultParameters(bool _arg)
	{
		vtkRIBProperty_SetSurfaceShaderUsesDefaultParameters_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SetVariable_25(HandleRef pThis, string variable, string declaration);

	/// <summary>
	/// Specify declarations for variables.
	/// </summary>
	public void SetVariable(string variable, string declaration)
	{
		vtkRIBProperty_SetVariable_25(GetCppThis(), variable, declaration);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SurfaceShaderUsesDefaultParametersOff_26(HandleRef pThis);

	/// <summary>
	/// If true (default) the surface shader uses the usual shader parameters:
	/// Ka - Ambient amount
	/// Kd - Diffuse amount
	/// Ks - Specular amount
	/// Roughness
	/// SpecularColor
	/// Additional surface shader parameters can be added with the
	/// Set/AddSurfaceShaderParameter methods.
	/// If false, all surface shader parameters must be specified
	/// </summary>
	public virtual void SurfaceShaderUsesDefaultParametersOff()
	{
		vtkRIBProperty_SurfaceShaderUsesDefaultParametersOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRIBProperty_SurfaceShaderUsesDefaultParametersOn_27(HandleRef pThis);

	/// <summary>
	/// If true (default) the surface shader uses the usual shader parameters:
	/// Ka - Ambient amount
	/// Kd - Diffuse amount
	/// Ks - Specular amount
	/// Roughness
	/// SpecularColor
	/// Additional surface shader parameters can be added with the
	/// Set/AddSurfaceShaderParameter methods.
	/// If false, all surface shader parameters must be specified
	/// </summary>
	public virtual void SurfaceShaderUsesDefaultParametersOn()
	{
		vtkRIBProperty_SurfaceShaderUsesDefaultParametersOn_27(GetCppThis());
	}
}
