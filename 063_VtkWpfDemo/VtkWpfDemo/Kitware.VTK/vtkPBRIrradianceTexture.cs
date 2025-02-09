using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPBRIrradianceTexture
/// </summary>
/// <remarks>
///    precompute irradiance texture used in physically based rendering
///
/// Irradiance texture is a cubemap which average light of a hemisphere of the input texture.
/// The input texture can be a cubemap or an equirectangular projection.
/// It is used in Image Base Lighting to compute the diffuse part.
/// </remarks>
public class vtkPBRIrradianceTexture : vtkOpenGLTexture
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPBRIrradianceTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPBRIrradianceTexture()
	{
		MRClassNameKey = "class vtkPBRIrradianceTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPBRIrradianceTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPBRIrradianceTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPBRIrradianceTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPBRIrradianceTexture New()
	{
		vtkPBRIrradianceTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPBRIrradianceTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPBRIrradianceTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPBRIrradianceTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPBRIrradianceTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPBRIrradianceTexture_ConvertToLinearOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the conversion to linear color space.
	/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
	/// directly with the texture format, the conversion can be done in the shader with this flag.
	/// </summary>
	public virtual void ConvertToLinearOff()
	{
		vtkPBRIrradianceTexture_ConvertToLinearOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRIrradianceTexture_ConvertToLinearOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the conversion to linear color space.
	/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
	/// directly with the texture format, the conversion can be done in the shader with this flag.
	/// </summary>
	public virtual void ConvertToLinearOn()
	{
		vtkPBRIrradianceTexture_ConvertToLinearOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPBRIrradianceTexture_GetConvertToLinear_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the conversion to linear color space.
	/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
	/// directly with the texture format, the conversion can be done in the shader with this flag.
	/// </summary>
	public virtual bool GetConvertToLinear()
	{
		return (vtkPBRIrradianceTexture_GetConvertToLinear_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPBRIrradianceTexture_GetInputTexture_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the input texture.
	/// </summary>
	public virtual vtkOpenGLTexture GetInputTexture()
	{
		vtkOpenGLTexture vtkOpenGLTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPBRIrradianceTexture_GetInputTexture_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLTexture2 = (vtkOpenGLTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLTexture2.Register(null);
			}
		}
		return vtkOpenGLTexture2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPBRIrradianceTexture_GetIrradianceSize_05(HandleRef pThis);

	/// <summary>
	/// Set/Get size of texture.
	/// Default is 256.
	/// </summary>
	public virtual uint GetIrradianceSize()
	{
		return vtkPBRIrradianceTexture_GetIrradianceSize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPBRIrradianceTexture_GetIrradianceStep_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the size of steps in radians used to sample hemisphere.
	/// Default is (pi/64).
	/// In some OpenGL drivers (OSMesa, old OSX), the default value might be too low leading to
	/// artifacts.
	/// </summary>
	public virtual float GetIrradianceStep()
	{
		return vtkPBRIrradianceTexture_GetIrradianceStep_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPBRIrradianceTexture_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPBRIrradianceTexture_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPBRIrradianceTexture_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPBRIrradianceTexture_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPBRIrradianceTexture_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPBRIrradianceTexture_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPBRIrradianceTexture_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPBRIrradianceTexture_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRIrradianceTexture_Load_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void Load(vtkRenderer arg0)
	{
		vtkPBRIrradianceTexture_Load_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPBRIrradianceTexture_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPBRIrradianceTexture NewInstance()
	{
		vtkPBRIrradianceTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPBRIrradianceTexture_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPBRIrradianceTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRIrradianceTexture_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this texture.
	/// The parameter window could be used to determine which graphic
	/// resources to release. Using the same texture object in multiple
	/// render windows is NOT currently supported.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkPBRIrradianceTexture_ReleaseGraphicsResources_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRIrradianceTexture_Render_15(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void Render(vtkRenderer ren)
	{
		vtkPBRIrradianceTexture_Render_15(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPBRIrradianceTexture_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPBRIrradianceTexture SafeDownCast(vtkObjectBase o)
	{
		vtkPBRIrradianceTexture vtkPBRIrradianceTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPBRIrradianceTexture_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPBRIrradianceTexture_SetConvertToLinear_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the conversion to linear color space.
	/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
	/// directly with the texture format, the conversion can be done in the shader with this flag.
	/// </summary>
	public virtual void SetConvertToLinear(bool _arg)
	{
		vtkPBRIrradianceTexture_SetConvertToLinear_17(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRIrradianceTexture_SetInputTexture_18(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Get/Set the input texture.
	/// </summary>
	public void SetInputTexture(vtkOpenGLTexture texture)
	{
		vtkPBRIrradianceTexture_SetInputTexture_18(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRIrradianceTexture_SetIrradianceSize_19(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get size of texture.
	/// Default is 256.
	/// </summary>
	public virtual void SetIrradianceSize(uint _arg)
	{
		vtkPBRIrradianceTexture_SetIrradianceSize_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRIrradianceTexture_SetIrradianceStep_20(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the size of steps in radians used to sample hemisphere.
	/// Default is (pi/64).
	/// In some OpenGL drivers (OSMesa, old OSX), the default value might be too low leading to
	/// artifacts.
	/// </summary>
	public virtual void SetIrradianceStep(float _arg)
	{
		vtkPBRIrradianceTexture_SetIrradianceStep_20(GetCppThis(), _arg);
	}
}
