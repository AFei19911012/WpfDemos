using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkShadowMapBakerPass
/// </summary>
/// <remarks>
///    Implement a builder of shadow map pass.
///
/// Bake a list of shadow maps, once per spot light.
/// It work in conjunction with the vtkShadowMapPass, which uses the
/// shadow maps for rendering the opaque geometry (a technique to render hard
/// shadows in hardware).
///
/// This pass expects an initialized depth buffer and color buffer.
/// Initialized buffers means they have been cleared with farest z-value and
/// background color/gradient/transparent color.
/// An opaque pass may have been performed right after the initialization.
///
///
///
/// Its delegate is usually set to a vtkOpaquePass.
///
/// @par Implementation:
/// The first pass of the algorithm is to generate a shadow map per light
/// (depth map from the light point of view) by rendering the opaque objects
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass, vtkOpaquePass, vtkShadowMapPass
/// </seealso>
public class vtkShadowMapBakerPass : vtkOpenGLRenderPass
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkShadowMapBakerPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkShadowMapBakerPass()
	{
		MRClassNameKey = "class vtkShadowMapBakerPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkShadowMapBakerPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkShadowMapBakerPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapBakerPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkShadowMapBakerPass New()
	{
		vtkShadowMapBakerPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapBakerPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkShadowMapBakerPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkShadowMapBakerPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkShadowMapBakerPass_GetCompositeZPass_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Delegate for compositing of the shadow maps across processors.
	/// If it is NULL, there is no z compositing.
	/// It is usually set to a vtkCompositeZPass (Parallel package).
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual vtkRenderPass GetCompositeZPass()
	{
		vtkRenderPass vtkRenderPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapBakerPass_GetCompositeZPass_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderPass2 = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderPass2.Register(null);
			}
		}
		return vtkRenderPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShadowMapBakerPass_GetHasShadows_02(HandleRef pThis);

	/// <summary>
	/// INTERNAL USE ONLY.
	/// Internally used by vtkShadowMapBakerPass and vtkShadowMapPass.
	///
	/// Tell if there is at least one shadow.
	/// Initial value is false.
	/// </summary>
	public bool GetHasShadows()
	{
		return (vtkShadowMapBakerPass_GetHasShadows_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShadowMapBakerPass_GetNeedUpdate_03(HandleRef pThis);

	/// <summary>
	/// INTERNAL USE ONLY.
	/// Internally used by vtkShadowMapBakerPass and vtkShadowMapPass.
	///
	/// Do the shadows need to be updated?
	/// Value changed by vtkShadowMapBakerPass and used by vtkShadowMapPass.
	/// Initial value is true.
	/// </summary>
	public bool GetNeedUpdate()
	{
		return (vtkShadowMapBakerPass_GetNeedUpdate_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShadowMapBakerPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkShadowMapBakerPass_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShadowMapBakerPass_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkShadowMapBakerPass_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapBakerPass_GetOpaqueSequence_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Delegate for rendering the camera, lights, and opaque geometry.
	/// If it is NULL, nothing will be rendered and a warning will be emitted.
	/// It defaults to a vtkCameraPass with a sequence of
	/// vtkLightPass/vtkOpaquePass.
	/// </summary>
	public virtual vtkRenderPass GetOpaqueSequence()
	{
		vtkRenderPass vtkRenderPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapBakerPass_GetOpaqueSequence_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderPass2 = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderPass2.Register(null);
			}
		}
		return vtkRenderPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkShadowMapBakerPass_GetResolution_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of pixels in each dimension of the shadow maps
	/// (shadow maps are square). Initial value is 256. The greater the better.
	/// Resolution does not have to be a power-of-two value.
	/// </summary>
	public virtual uint GetResolution()
	{
		return vtkShadowMapBakerPass_GetResolution_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShadowMapBakerPass_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkShadowMapBakerPass_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShadowMapBakerPass_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkShadowMapBakerPass_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShadowMapBakerPass_LightCreatesShadow_10(HandleRef pThis, HandleRef l);

	/// <summary>
	/// INTERNAL USE ONLY.
	/// Internally used by vtkShadowMapBakerPass and vtkShadowMapPass.
	///
	/// Tell if the light `l' can create shadows.
	/// The light has to not be a head light and to be directional or
	/// positional with an angle less than 180 degrees.
	/// \pre l_exists: l!=0
	/// </summary>
	public bool LightCreatesShadow(vtkLight l)
	{
		return (vtkShadowMapBakerPass_LightCreatesShadow_10(GetCppThis(), l?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapBakerPass_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkShadowMapBakerPass NewInstance()
	{
		vtkShadowMapBakerPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapBakerPass_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShadowMapBakerPass_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own
	/// resources.
	/// \pre w_exists: w!=0
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkShadowMapBakerPass_ReleaseGraphicsResources_13(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapBakerPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkShadowMapBakerPass SafeDownCast(vtkObjectBase o)
	{
		vtkShadowMapBakerPass vtkShadowMapBakerPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapBakerPass_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShadowMapBakerPass2 = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShadowMapBakerPass2.Register(null);
			}
		}
		return vtkShadowMapBakerPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShadowMapBakerPass_SetCompositeZPass_15(HandleRef pThis, HandleRef compositeZPass);

	/// <summary>
	/// Delegate for compositing of the shadow maps across processors.
	/// If it is NULL, there is no z compositing.
	/// It is usually set to a vtkCompositeZPass (Parallel package).
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual void SetCompositeZPass(vtkRenderPass compositeZPass)
	{
		vtkShadowMapBakerPass_SetCompositeZPass_15(GetCppThis(), compositeZPass?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShadowMapBakerPass_SetOpaqueSequence_16(HandleRef pThis, HandleRef opaqueSequence);

	/// <summary>
	/// Delegate for rendering the camera, lights, and opaque geometry.
	/// If it is NULL, nothing will be rendered and a warning will be emitted.
	/// It defaults to a vtkCameraPass with a sequence of
	/// vtkLightPass/vtkOpaquePass.
	/// </summary>
	public virtual void SetOpaqueSequence(vtkRenderPass opaqueSequence)
	{
		vtkShadowMapBakerPass_SetOpaqueSequence_16(GetCppThis(), opaqueSequence?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShadowMapBakerPass_SetResolution_17(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the number of pixels in each dimension of the shadow maps
	/// (shadow maps are square). Initial value is 256. The greater the better.
	/// Resolution does not have to be a power-of-two value.
	/// </summary>
	public virtual void SetResolution(uint _arg)
	{
		vtkShadowMapBakerPass_SetResolution_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShadowMapBakerPass_SetUpToDate_18(HandleRef pThis);

	/// <summary>
	/// INTERNAL USE ONLY.
	/// Internally used by vtkShadowMapBakerPass and vtkShadowMapPass.
	///
	/// Do the shadows need to be updated?
	/// Value changed by vtkShadowMapBakerPass and used by vtkShadowMapPass.
	/// Initial value is true.
	/// </summary>
	public void SetUpToDate()
	{
		vtkShadowMapBakerPass_SetUpToDate_18(GetCppThis());
	}
}
