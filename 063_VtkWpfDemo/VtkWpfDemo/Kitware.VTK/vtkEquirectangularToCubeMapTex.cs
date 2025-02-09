using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEquirectangularToCubeMapTexture
/// </summary>
/// <remarks>
///    compute a cubemap texture based on a standard equirectangular projection
///
/// This special texture converts a 2D projected texture in equirectangular format to a 3D cubemap
/// using the GPU.
/// The generated texture can be used as input for a skybox or an environment map for PBR shading.
///
/// </remarks>
/// <seealso>
///  vtkSkybox vtkRenderer::SetEnvironmentCubeMap
/// </seealso>
public class vtkEquirectangularToCubeMapTexture : vtkOpenGLTexture
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEquirectangularToCubeMapTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEquirectangularToCubeMapTexture()
	{
		MRClassNameKey = "class vtkEquirectangularToCubeMapTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEquirectangularToCubeMapTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEquirectangularToCubeMapTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEquirectangularToCubeMapTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEquirectangularToCubeMapTexture New()
	{
		vtkEquirectangularToCubeMapTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEquirectangularToCubeMapTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEquirectangularToCubeMapTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkEquirectangularToCubeMapTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEquirectangularToCubeMapTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkEquirectangularToCubeMapTexture_GetCubeMapSize_01(HandleRef pThis);

	/// <summary>
	/// Set/Get size of each face of the output cubemap texture.
	/// Default is 512.
	/// </summary>
	public virtual uint GetCubeMapSize()
	{
		return vtkEquirectangularToCubeMapTexture_GetCubeMapSize_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEquirectangularToCubeMapTexture_GetInputTexture_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the input equirectangular 2D texture.
	/// </summary>
	public virtual vtkOpenGLTexture GetInputTexture()
	{
		vtkOpenGLTexture vtkOpenGLTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEquirectangularToCubeMapTexture_GetInputTexture_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkEquirectangularToCubeMapTexture_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEquirectangularToCubeMapTexture_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEquirectangularToCubeMapTexture_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEquirectangularToCubeMapTexture_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEquirectangularToCubeMapTexture_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEquirectangularToCubeMapTexture_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEquirectangularToCubeMapTexture_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEquirectangularToCubeMapTexture_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEquirectangularToCubeMapTexture_Load_07(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void Load(vtkRenderer arg0)
	{
		vtkEquirectangularToCubeMapTexture_Load_07(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEquirectangularToCubeMapTexture_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEquirectangularToCubeMapTexture NewInstance()
	{
		vtkEquirectangularToCubeMapTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEquirectangularToCubeMapTexture_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEquirectangularToCubeMapTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEquirectangularToCubeMapTexture_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this texture.
	/// The parameter window could be used to determine which graphic
	/// resources to release. Using the same texture object in multiple
	/// render windows is NOT currently supported.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkEquirectangularToCubeMapTexture_ReleaseGraphicsResources_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEquirectangularToCubeMapTexture_Render_11(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Implement base class method.
	/// </summary>
	public override void Render(vtkRenderer ren)
	{
		vtkEquirectangularToCubeMapTexture_Render_11(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEquirectangularToCubeMapTexture_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEquirectangularToCubeMapTexture SafeDownCast(vtkObjectBase o)
	{
		vtkEquirectangularToCubeMapTexture vtkEquirectangularToCubeMapTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEquirectangularToCubeMapTexture_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEquirectangularToCubeMapTexture2 = (vtkEquirectangularToCubeMapTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEquirectangularToCubeMapTexture2.Register(null);
			}
		}
		return vtkEquirectangularToCubeMapTexture2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEquirectangularToCubeMapTexture_SetCubeMapSize_13(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get size of each face of the output cubemap texture.
	/// Default is 512.
	/// </summary>
	public virtual void SetCubeMapSize(uint _arg)
	{
		vtkEquirectangularToCubeMapTexture_SetCubeMapSize_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEquirectangularToCubeMapTexture_SetInputTexture_14(HandleRef pThis, HandleRef texture);

	/// <summary>
	/// Get/Set the input equirectangular 2D texture.
	/// </summary>
	public void SetInputTexture(vtkOpenGLTexture texture)
	{
		vtkEquirectangularToCubeMapTexture_SetInputTexture_14(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef));
	}
}
