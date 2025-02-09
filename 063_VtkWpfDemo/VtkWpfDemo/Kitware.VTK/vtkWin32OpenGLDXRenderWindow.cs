using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWin32OpenGLDXRenderWindow
/// </summary>
/// <remarks>
///    VTK render window providing OpenGL-DirectX interop
///
/// This vtkWin32OpenGLRenderWindow subclass allows for rendering in a texture
/// that is shared between an OpenGL and a D3D context, using the NVidia
/// NV_DX_interop extension.
/// </remarks>
public class vtkWin32OpenGLDXRenderWindow : vtkWin32OpenGLRenderWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWin32OpenGLDXRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWin32OpenGLDXRenderWindow()
	{
		MRClassNameKey = "class vtkWin32OpenGLDXRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32OpenGLDXRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWin32OpenGLDXRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLDXRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWin32OpenGLDXRenderWindow New()
	{
		vtkWin32OpenGLDXRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32OpenGLDXRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWin32OpenGLDXRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWin32OpenGLDXRenderWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWin32OpenGLDXRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkWin32OpenGLDXRenderWindow_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWin32OpenGLDXRenderWindow_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWin32OpenGLDXRenderWindow_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWin32OpenGLDXRenderWindow_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLDXRenderWindow_Initialize_03(HandleRef pThis);

	/// <summary>
	/// Overriden to create the D3D device, context and texture.
	/// </summary>
	public override void Initialize()
	{
		vtkWin32OpenGLDXRenderWindow_Initialize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32OpenGLDXRenderWindow_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWin32OpenGLDXRenderWindow_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32OpenGLDXRenderWindow_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWin32OpenGLDXRenderWindow_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLDXRenderWindow_Lock_06(HandleRef pThis);

	/// <summary>
	/// Lock/Unlock the shared texture.
	/// The texture must be locked before rendering into it.
	/// </summary>
	public void Lock()
	{
		vtkWin32OpenGLDXRenderWindow_Lock_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLDXRenderWindow_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWin32OpenGLDXRenderWindow NewInstance()
	{
		vtkWin32OpenGLDXRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32OpenGLDXRenderWindow_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWin32OpenGLDXRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLDXRenderWindow_RegisterSharedTexture_09(HandleRef pThis, uint textureHandle);

	/// <summary>
	/// Register/Unregister the OpenGL texture designated by \p textureHandle with
	/// this render window internal D3D shared texture.
	/// </summary>
	public void RegisterSharedTexture(uint textureHandle)
	{
		vtkWin32OpenGLDXRenderWindow_RegisterSharedTexture_09(GetCppThis(), textureHandle);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLDXRenderWindow_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWin32OpenGLDXRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkWin32OpenGLDXRenderWindow vtkWin32OpenGLDXRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32OpenGLDXRenderWindow_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWin32OpenGLDXRenderWindow2 = (vtkWin32OpenGLDXRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWin32OpenGLDXRenderWindow2.Register(null);
			}
		}
		return vtkWin32OpenGLDXRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLDXRenderWindow_SetMultiSamples_11(HandleRef pThis, int samples);

	/// <summary>
	/// Overriden to update the internal D3D shared texture
	/// </summary>
	public override void SetMultiSamples(int samples)
	{
		vtkWin32OpenGLDXRenderWindow_SetMultiSamples_11(GetCppThis(), samples);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLDXRenderWindow_SetSize_12(HandleRef pThis, int width, int height);

	/// <summary>
	/// Overriden to resize the internal D3D shared texture
	/// </summary>
	public override void SetSize(int width, int height)
	{
		vtkWin32OpenGLDXRenderWindow_SetSize_12(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLDXRenderWindow_Unlock_13(HandleRef pThis);

	/// <summary>
	/// Lock/Unlock the shared texture.
	/// The texture must be locked before rendering into it.
	/// </summary>
	public void Unlock()
	{
		vtkWin32OpenGLDXRenderWindow_Unlock_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLDXRenderWindow_UnregisterSharedTexture_14(HandleRef pThis);

	/// <summary>
	/// Register/Unregister the OpenGL texture designated by \p textureHandle with
	/// this render window internal D3D shared texture.
	/// </summary>
	public void UnregisterSharedTexture()
	{
		vtkWin32OpenGLDXRenderWindow_UnregisterSharedTexture_14(GetCppThis());
	}
}
