using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkShadowMapPass
/// </summary>
/// <remarks>
///    Implement a shadow mapping render pass.
///
/// Render the opaque polygonal geometry of a scene with shadow maps (a
/// technique to render hard shadows in hardware).
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
/// with the OCCLUDER property keys.
/// The second pass is to render the opaque objects with the RECEIVER keys.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass, vtkOpaquePass
/// </seealso>
public class vtkShadowMapPass : vtkOpenGLRenderPass
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkShadowMapPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkShadowMapPass()
	{
		MRClassNameKey = "class vtkShadowMapPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkShadowMapPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkShadowMapPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkShadowMapPass New()
	{
		vtkShadowMapPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkShadowMapPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkShadowMapPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern string vtkShadowMapPass_GetFragmentDeclaration_01(HandleRef pThis);

	/// <summary>
	/// Get the shader code to compute light factors based
	/// on a mappers vertexVC variable
	/// </summary>
	public string GetFragmentDeclaration()
	{
		return vtkShadowMapPass_GetFragmentDeclaration_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkShadowMapPass_GetFragmentImplementation_02(HandleRef pThis);

	/// <summary>
	/// Get the shader code to compute light factors based
	/// on a mappers vertexVC variable
	/// </summary>
	public string GetFragmentImplementation()
	{
		return vtkShadowMapPass_GetFragmentImplementation_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShadowMapPass_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkShadowMapPass_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShadowMapPass_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkShadowMapPass_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapPass_GetOpaqueSequence_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Pass that render the lights and opaque geometry
	/// Typically a sequence pass with a light pass and opaque pass.
	/// </summary>
	public virtual vtkRenderPass GetOpaqueSequence()
	{
		vtkRenderPass vtkRenderPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapPass_GetOpaqueSequence_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkShadowMapPass_GetShadowMapBakerPass_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Pass that generates the shadow maps.
	/// the vtkShadowMapPass will use the Resolution ivar of
	/// this pass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual vtkShadowMapBakerPass GetShadowMapBakerPass()
	{
		vtkShadowMapBakerPass vtkShadowMapBakerPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapPass_GetShadowMapBakerPass_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkShadowMapPass_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkShadowMapPass_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShadowMapPass_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkShadowMapPass_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapPass_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkShadowMapPass NewInstance()
	{
		vtkShadowMapPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapPass_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShadowMapPass_PostReplaceShaderValues_11(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Get the shader code to compute light factors based
	/// on a mappers vertexVC variable
	/// </summary>
	public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkShadowMapPass_PostReplaceShaderValues_11(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShadowMapPass_PreReplaceShaderValues_12(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Get the shader code to compute light factors based
	/// on a mappers vertexVC variable
	/// </summary>
	public override bool PreReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkShadowMapPass_PreReplaceShaderValues_12(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShadowMapPass_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own
	/// resources.
	/// \pre w_exists: w!=0
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkShadowMapPass_ReleaseGraphicsResources_13(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkShadowMapPass SafeDownCast(vtkObjectBase o)
	{
		vtkShadowMapPass vtkShadowMapPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapPass_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShadowMapPass2 = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShadowMapPass2.Register(null);
			}
		}
		return vtkShadowMapPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShadowMapPass_SetOpaqueSequence_15(HandleRef pThis, HandleRef opaqueSequence);

	/// <summary>
	/// Pass that render the lights and opaque geometry
	/// Typically a sequence pass with a light pass and opaque pass.
	/// </summary>
	public virtual void SetOpaqueSequence(vtkRenderPass opaqueSequence)
	{
		vtkShadowMapPass_SetOpaqueSequence_15(GetCppThis(), opaqueSequence?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShadowMapPass_SetShadowMapBakerPass_16(HandleRef pThis, HandleRef shadowMapBakerPass);

	/// <summary>
	/// Pass that generates the shadow maps.
	/// the vtkShadowMapPass will use the Resolution ivar of
	/// this pass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual void SetShadowMapBakerPass(vtkShadowMapBakerPass shadowMapBakerPass)
	{
		vtkShadowMapPass_SetShadowMapBakerPass_16(GetCppThis(), shadowMapBakerPass?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShadowMapPass_ShadowMapPass_17(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// this key will contain the shadow map pass
	/// </summary>
	public static vtkInformationObjectBaseKey ShadowMapPass()
	{
		vtkInformationObjectBaseKey vtkInformationObjectBaseKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShadowMapPass_ShadowMapPass_17(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseKey2 = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseKey2;
	}
}
