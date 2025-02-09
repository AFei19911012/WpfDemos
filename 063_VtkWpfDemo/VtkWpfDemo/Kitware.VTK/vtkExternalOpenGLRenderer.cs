using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExternalOpenGLRenderer
/// </summary>
/// <remarks>
///    OpenGL renderer
///
/// vtkExternalOpenGLRenderer is a secondary implementation of the class
/// vtkOpenGLRenderer. vtkExternalOpenGLRenderer interfaces to the
/// OpenGL graphics library. This class provides API to preserve the color and
/// depth buffers, thereby allowing external applications to manage the OpenGL
/// buffers. This becomes very useful when there are multiple OpenGL applications
/// sharing the same OpenGL context.
///
/// vtkExternalOpenGLRenderer makes sure that the camera used in the scene if of
/// type vtkExternalOpenGLCamera. It manages light and camera transformations for
/// VTK objects in the OpenGL context.
///
/// \sa vtkExternalOpenGLCamera
/// </remarks>
public class vtkExternalOpenGLRenderer : vtkOpenGLRenderer
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExternalOpenGLRenderer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExternalOpenGLRenderer()
	{
		MRClassNameKey = "class vtkExternalOpenGLRenderer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExternalOpenGLRenderer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExternalOpenGLRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExternalOpenGLRenderer New()
	{
		vtkExternalOpenGLRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExternalOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExternalOpenGLRenderer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExternalOpenGLRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExternalOpenGLRenderer_AddExternalLight_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add an external light to the list of external lights.
	/// </summary>
	public virtual void AddExternalLight(vtkExternalLight arg0)
	{
		vtkExternalOpenGLRenderer_AddExternalLight_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExternalOpenGLRenderer_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExternalOpenGLRenderer_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExternalOpenGLRenderer_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExternalOpenGLRenderer_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLRenderer_GetPreserveGLCameraMatrices_04(HandleRef pThis);

	/// <summary>
	/// If PreserveGLCameraMatrices is set to true, VTK camera matrices
	/// are copied from the current context GL_MODELVIEW_MATRIX and
	/// GL_PROJECTION_MATRIX parameters before each render call.
	/// This flag is on by default.
	/// </summary>
	public virtual int GetPreserveGLCameraMatrices()
	{
		return vtkExternalOpenGLRenderer_GetPreserveGLCameraMatrices_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLRenderer_GetPreserveGLLights_05(HandleRef pThis);

	/// <summary>
	/// If PreserveGLLights is set to true, existing GL lights are modified before
	/// each render call to match the collection of lights added with
	/// AddExternalLight(). This flag is on by default.
	/// </summary>
	public virtual int GetPreserveGLLights()
	{
		return vtkExternalOpenGLRenderer_GetPreserveGLLights_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLRenderer_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExternalOpenGLRenderer_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLRenderer_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExternalOpenGLRenderer_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLRenderer_MakeCamera_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new Camera sutible for use with this type of Renderer.
	/// This function creates the vtkExternalOpenGLCamera.
	/// </summary>
	public override vtkCamera MakeCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLRenderer_MakeCamera_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLRenderer_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExternalOpenGLRenderer NewInstance()
	{
		vtkExternalOpenGLRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLRenderer_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExternalOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_PreserveGLCameraMatricesOff_11(HandleRef pThis);

	/// <summary>
	/// If PreserveGLCameraMatrices is set to true, VTK camera matrices
	/// are copied from the current context GL_MODELVIEW_MATRIX and
	/// GL_PROJECTION_MATRIX parameters before each render call.
	/// This flag is on by default.
	/// </summary>
	public virtual void PreserveGLCameraMatricesOff()
	{
		vtkExternalOpenGLRenderer_PreserveGLCameraMatricesOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_PreserveGLCameraMatricesOn_12(HandleRef pThis);

	/// <summary>
	/// If PreserveGLCameraMatrices is set to true, VTK camera matrices
	/// are copied from the current context GL_MODELVIEW_MATRIX and
	/// GL_PROJECTION_MATRIX parameters before each render call.
	/// This flag is on by default.
	/// </summary>
	public virtual void PreserveGLCameraMatricesOn()
	{
		vtkExternalOpenGLRenderer_PreserveGLCameraMatricesOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_PreserveGLLightsOff_13(HandleRef pThis);

	/// <summary>
	/// If PreserveGLLights is set to true, existing GL lights are modified before
	/// each render call to match the collection of lights added with
	/// AddExternalLight(). This flag is on by default.
	/// </summary>
	public virtual void PreserveGLLightsOff()
	{
		vtkExternalOpenGLRenderer_PreserveGLLightsOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_PreserveGLLightsOn_14(HandleRef pThis);

	/// <summary>
	/// If PreserveGLLights is set to true, existing GL lights are modified before
	/// each render call to match the collection of lights added with
	/// AddExternalLight(). This flag is on by default.
	/// </summary>
	public virtual void PreserveGLLightsOn()
	{
		vtkExternalOpenGLRenderer_PreserveGLLightsOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_RemoveAllExternalLights_15(HandleRef pThis);

	/// <summary>
	/// Remove all external lights
	/// </summary>
	public virtual void RemoveAllExternalLights()
	{
		vtkExternalOpenGLRenderer_RemoveAllExternalLights_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_RemoveExternalLight_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove an external light from the list of external lights.
	/// </summary>
	public virtual void RemoveExternalLight(vtkExternalLight arg0)
	{
		vtkExternalOpenGLRenderer_RemoveExternalLight_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_Render_17(HandleRef pThis);

	/// <summary>
	/// Synchronize camera and light parameters
	/// </summary>
	public override void Render()
	{
		vtkExternalOpenGLRenderer_Render_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLRenderer_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExternalOpenGLRenderer SafeDownCast(vtkObjectBase o)
	{
		vtkExternalOpenGLRenderer vtkExternalOpenGLRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLRenderer_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExternalOpenGLRenderer2 = (vtkExternalOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExternalOpenGLRenderer2.Register(null);
			}
		}
		return vtkExternalOpenGLRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_SetPreserveGLCameraMatrices_19(HandleRef pThis, int _arg);

	/// <summary>
	/// If PreserveGLCameraMatrices is set to true, VTK camera matrices
	/// are copied from the current context GL_MODELVIEW_MATRIX and
	/// GL_PROJECTION_MATRIX parameters before each render call.
	/// This flag is on by default.
	/// </summary>
	public virtual void SetPreserveGLCameraMatrices(int _arg)
	{
		vtkExternalOpenGLRenderer_SetPreserveGLCameraMatrices_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderer_SetPreserveGLLights_20(HandleRef pThis, int _arg);

	/// <summary>
	/// If PreserveGLLights is set to true, existing GL lights are modified before
	/// each render call to match the collection of lights added with
	/// AddExternalLight(). This flag is on by default.
	/// </summary>
	public virtual void SetPreserveGLLights(int _arg)
	{
		vtkExternalOpenGLRenderer_SetPreserveGLLights_20(GetCppThis(), _arg);
	}
}
