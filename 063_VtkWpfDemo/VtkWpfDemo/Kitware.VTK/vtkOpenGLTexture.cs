using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLTexture
/// </summary>
/// <remarks>
///    OpenGL texture map
///
/// vtkOpenGLTexture is a concrete implementation of the abstract class
/// vtkTexture. vtkOpenGLTexture interfaces to the OpenGL rendering library.
/// </remarks>
public class vtkOpenGLTexture : vtkTexture
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLTexture()
	{
		MRClassNameKey = "class vtkOpenGLTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLTexture New()
	{
		vtkOpenGLTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOpenGLTexture_CopyTexImage_01(HandleRef pThis, int x, int y, int width, int height);

	/// <summary>
	/// copy the renderers read buffer into this texture
	/// </summary>
	public void CopyTexImage(int x, int y, int width, int height)
	{
		vtkOpenGLTexture_CopyTexImage_01(GetCppThis(), x, y, width, height);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLTexture_GetIsDepthTexture_02(HandleRef pThis);

	/// <summary>
	/// Provide for specifying a format for the texture
	/// </summary>
	public virtual int GetIsDepthTexture()
	{
		return vtkOpenGLTexture_GetIsDepthTexture_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLTexture_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLTexture_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLTexture_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLTexture_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLTexture_GetTextureType_05(HandleRef pThis);

	/// <summary>
	/// What type of texture map GL_TEXTURE_2D versus GL_TEXTURE_RECTANGLE
	/// </summary>
	public virtual int GetTextureType()
	{
		return vtkOpenGLTexture_GetTextureType_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLTexture_GetTextureUnit_06(HandleRef pThis);

	/// <summary>
	/// Return the texture unit used for this texture
	/// </summary>
	public override int GetTextureUnit()
	{
		return vtkOpenGLTexture_GetTextureUnit_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLTexture_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLTexture_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLTexture_IsTranslucent_08(HandleRef pThis);

	/// <summary>
	/// Is this Texture Translucent?
	/// returns false (0) if the texture is either fully opaque or has
	/// only fully transparent pixels and fully opaque pixels and the
	/// Interpolate flag is turn off.
	/// </summary>
	public override int IsTranslucent()
	{
		return vtkOpenGLTexture_IsTranslucent_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLTexture_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLTexture_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLTexture_Load_10(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void Load(vtkRenderer arg0)
	{
		vtkOpenGLTexture_Load_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLTexture_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLTexture NewInstance()
	{
		vtkOpenGLTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLTexture_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLTexture_PostRender_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void PostRender(vtkRenderer arg0)
	{
		vtkOpenGLTexture_PostRender_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLTexture_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this texture.
	/// The parameter window could be used to determine which graphic
	/// resources to release. Using the same texture object in multiple
	/// render windows is NOT currently supported.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkOpenGLTexture_ReleaseGraphicsResources_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLTexture_Render_15(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Renders a texture map. It first checks the object's modified time
	/// to make sure the texture maps Input is valid, then it invokes the
	/// Load() method.
	/// </summary>
	public override void Render(vtkRenderer ren)
	{
		vtkOpenGLTexture_Render_15(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLTexture_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLTexture SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLTexture vtkOpenGLTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLTexture_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOpenGLTexture_SetIsDepthTexture_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Provide for specifying a format for the texture
	/// </summary>
	public virtual void SetIsDepthTexture(int _arg)
	{
		vtkOpenGLTexture_SetIsDepthTexture_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLTexture_SetTextureType_18(HandleRef pThis, int _arg);

	/// <summary>
	/// What type of texture map GL_TEXTURE_2D versus GL_TEXTURE_RECTANGLE
	/// </summary>
	public virtual void SetTextureType(int _arg)
	{
		vtkOpenGLTexture_SetTextureType_18(GetCppThis(), _arg);
	}
}
