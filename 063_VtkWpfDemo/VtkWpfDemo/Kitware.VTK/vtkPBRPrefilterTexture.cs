using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPBRPrefilterTexture
/// </summary>
/// <remarks>
///    precompute prefilter texture used in physically based rendering
///
/// Prefilter texture is a cubemap result of integration of the input cubemap contribution in
/// BRDF equation. The result depends on roughness coefficient so several levels of mipmap are
/// used to store results of different roughness coefficients.
/// It is used in Image Base Lighting to compute the specular part.
/// </remarks>
public class vtkPBRPrefilterTexture : vtkOpenGLTexture
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPBRPrefilterTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPBRPrefilterTexture()
	{
		MRClassNameKey = "class vtkPBRPrefilterTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPBRPrefilterTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPBRPrefilterTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPBRPrefilterTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPBRPrefilterTexture New()
	{
		vtkPBRPrefilterTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPBRPrefilterTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPBRPrefilterTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPBRPrefilterTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPBRPrefilterTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPBRPrefilterTexture_ConvertToLinearOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the conversion to linear color space.
	/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
	/// directly with the texture format, the conversion can be done in the shader with this flag.
	/// </summary>
	public virtual void ConvertToLinearOff()
	{
		vtkPBRPrefilterTexture_ConvertToLinearOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRPrefilterTexture_ConvertToLinearOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the conversion to linear color space.
	/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
	/// directly with the texture format, the conversion can be done in the shader with this flag.
	/// </summary>
	public virtual void ConvertToLinearOn()
	{
		vtkPBRPrefilterTexture_ConvertToLinearOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPBRPrefilterTexture_GetConvertToLinear_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the conversion to linear color space.
	/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
	/// directly with the texture format, the conversion can be done in the shader with this flag.
	/// </summary>
	public virtual bool GetConvertToLinear()
	{
		return (vtkPBRPrefilterTexture_GetConvertToLinear_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPBRPrefilterTexture_GetInputTexture_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the input texture.
	/// </summary>
	public virtual vtkOpenGLTexture GetInputTexture()
	{
		vtkOpenGLTexture vtkOpenGLTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPBRPrefilterTexture_GetInputTexture_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPBRPrefilterTexture_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPBRPrefilterTexture_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPBRPrefilterTexture_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPBRPrefilterTexture_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPBRPrefilterTexture_GetPrefilterLevels_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of mip-map levels.
	/// Default is 5.
	/// </summary>
	public virtual uint GetPrefilterLevels()
	{
		return vtkPBRPrefilterTexture_GetPrefilterLevels_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPBRPrefilterTexture_GetPrefilterMaxSamples_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of samples.
	/// The number of samples for each roughness is between 1
	/// at roughness = 0 and PrefilterMaxSamples at roughness = 1
	/// Default is 512.
	/// </summary>
	public virtual uint GetPrefilterMaxSamples()
	{
		return vtkPBRPrefilterTexture_GetPrefilterMaxSamples_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPBRPrefilterTexture_GetPrefilterSize_09(HandleRef pThis);

	/// <summary>
	/// Get size of texture (input texture height).
	/// </summary>
	public virtual uint GetPrefilterSize()
	{
		return vtkPBRPrefilterTexture_GetPrefilterSize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPBRPrefilterTexture_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPBRPrefilterTexture_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPBRPrefilterTexture_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPBRPrefilterTexture_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRPrefilterTexture_Load_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void Load(vtkRenderer arg0)
	{
		vtkPBRPrefilterTexture_Load_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPBRPrefilterTexture_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPBRPrefilterTexture NewInstance()
	{
		vtkPBRPrefilterTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPBRPrefilterTexture_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPBRPrefilterTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRPrefilterTexture_ReleaseGraphicsResources_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this texture.
	/// The parameter window could be used to determine which graphic
	/// resources to release. Using the same texture object in multiple
	/// render windows is NOT currently supported.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkPBRPrefilterTexture_ReleaseGraphicsResources_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRPrefilterTexture_Render_16(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void Render(vtkRenderer ren)
	{
		vtkPBRPrefilterTexture_Render_16(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPBRPrefilterTexture_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPBRPrefilterTexture SafeDownCast(vtkObjectBase o)
	{
		vtkPBRPrefilterTexture vtkPBRPrefilterTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPBRPrefilterTexture_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPBRPrefilterTexture_SetConvertToLinear_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the conversion to linear color space.
	/// If the input texture is in sRGB color space and the conversion is not done by OpenGL
	/// directly with the texture format, the conversion can be done in the shader with this flag.
	/// </summary>
	public virtual void SetConvertToLinear(bool _arg)
	{
		vtkPBRPrefilterTexture_SetConvertToLinear_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRPrefilterTexture_SetInputTexture_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the input texture.
	/// </summary>
	public void SetInputTexture(vtkOpenGLTexture arg0)
	{
		vtkPBRPrefilterTexture_SetInputTexture_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRPrefilterTexture_SetPrefilterLevels_20(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the number of mip-map levels.
	/// Default is 5.
	/// </summary>
	public virtual void SetPrefilterLevels(uint _arg)
	{
		vtkPBRPrefilterTexture_SetPrefilterLevels_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPBRPrefilterTexture_SetPrefilterMaxSamples_21(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the maximum number of samples.
	/// The number of samples for each roughness is between 1
	/// at roughness = 0 and PrefilterMaxSamples at roughness = 1
	/// Default is 512.
	/// </summary>
	public virtual void SetPrefilterMaxSamples(uint _arg)
	{
		vtkPBRPrefilterTexture_SetPrefilterMaxSamples_21(GetCppThis(), _arg);
	}
}
