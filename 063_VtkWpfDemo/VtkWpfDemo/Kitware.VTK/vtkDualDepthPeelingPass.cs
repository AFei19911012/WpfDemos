using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDualDepthPeelingPass
/// </summary>
/// <remarks>
///    Implements the dual depth peeling algorithm.
///
///
/// Dual depth peeling is an augmentatation of the standard depth peeling
/// algorithm that peels two layers (front and back) for each render pass. The
/// technique is described in "Order independent transparency with dual depth
/// peeling" (February 2008) by L. Bavoil, K. Myers.
///
/// This algorithm has been extended to also peel volumetric data along with
/// translucent geometry. To use this feature, set VolumetricPass to an
/// appropriate RenderPass (usually vtkVolumetricPass).
///
/// The pass occurs in several stages:
///
/// 1. Copy the current (opaque geometry) depth buffer into a texture.
/// 2. Initialize the min-max depth buffer from the opaque depth texture and the
///    translucent geometry.
/// 3. Peel the nearest and farthest fragments:
/// 3a. Blend fragments that match the nearest depth of the min-max depth buffer
///     into the front buffer.
/// 3b. Write the far depth fragments into a temporary buffer.
/// 3c. Extract the next set of min/max depth values for the next peel.
/// 3d. Blend the temporary far fragment texture (3b) into an accumulation
///     texture.
/// 3e. Go back to 3a and repeat until the maximum number of peels is met, or
///     the desired occlusion ratio is satisfied.
/// 4. If the occlusion ratio != 0 (i.e. we hit the maximum number of peels
///    before finishing), alpha blend the remaining fragments in-between the
///    near and far accumulation textures.
/// 5. Blend all accumulation buffers over the opaque color buffer to produce the
///    final image.
/// </remarks>
public class vtkDualDepthPeelingPass : vtkDepthPeelingPass
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDualDepthPeelingPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDualDepthPeelingPass()
	{
		MRClassNameKey = "class vtkDualDepthPeelingPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDualDepthPeelingPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDualDepthPeelingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDualDepthPeelingPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDualDepthPeelingPass New()
	{
		vtkDualDepthPeelingPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDualDepthPeelingPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDualDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDualDepthPeelingPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDualDepthPeelingPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDualDepthPeelingPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDualDepthPeelingPass_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDualDepthPeelingPass_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDualDepthPeelingPass_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDualDepthPeelingPass_GetShaderStageMTime_03(HandleRef pThis);

	/// <summary>
	/// Delegate for rendering the volumetric geometry, if needed.
	/// It is usually set to a vtkVolumetricPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public override ulong GetShaderStageMTime()
	{
		return vtkDualDepthPeelingPass_GetShaderStageMTime_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDualDepthPeelingPass_GetVolumetricPass_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Delegate for rendering the volumetric geometry, if needed.
	/// It is usually set to a vtkVolumetricPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual vtkRenderPass GetVolumetricPass()
	{
		vtkRenderPass vtkRenderPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDualDepthPeelingPass_GetVolumetricPass_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDualDepthPeelingPass_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDualDepthPeelingPass_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDualDepthPeelingPass_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDualDepthPeelingPass_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDualDepthPeelingPass_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDualDepthPeelingPass NewInstance()
	{
		vtkDualDepthPeelingPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDualDepthPeelingPass_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDualDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDualDepthPeelingPass_PostReplaceShaderValues_09(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Delegate for rendering the volumetric geometry, if needed.
	/// It is usually set to a vtkVolumetricPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkDualDepthPeelingPass_PostReplaceShaderValues_09(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDualDepthPeelingPass_PreReplaceShaderValues_10(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Delegate for rendering the volumetric geometry, if needed.
	/// It is usually set to a vtkVolumetricPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public override bool PreReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkDualDepthPeelingPass_PreReplaceShaderValues_10(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDualDepthPeelingPass_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef w);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkDualDepthPeelingPass_ReleaseGraphicsResources_11(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDualDepthPeelingPass_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDualDepthPeelingPass SafeDownCast(vtkObjectBase o)
	{
		vtkDualDepthPeelingPass vtkDualDepthPeelingPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDualDepthPeelingPass_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDualDepthPeelingPass2 = (vtkDualDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDualDepthPeelingPass2.Register(null);
			}
		}
		return vtkDualDepthPeelingPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDualDepthPeelingPass_SetVolumetricPass_13(HandleRef pThis, HandleRef volumetricPass);

	/// <summary>
	/// Delegate for rendering the volumetric geometry, if needed.
	/// It is usually set to a vtkVolumetricPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual void SetVolumetricPass(vtkRenderPass volumetricPass)
	{
		vtkDualDepthPeelingPass_SetVolumetricPass_13(GetCppThis(), volumetricPass?.GetCppThis() ?? default(HandleRef));
	}
}
