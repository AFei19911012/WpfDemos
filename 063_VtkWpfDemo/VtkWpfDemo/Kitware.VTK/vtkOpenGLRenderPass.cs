using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLRenderPass
/// </summary>
/// <remarks>
///    Abstract render pass with shader modifications.
///
///
/// Allows a render pass to update shader code using a new virtual API.
/// </remarks>
public abstract class vtkOpenGLRenderPass : vtkRenderPass
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLRenderPass()
	{
		MRClassNameKey = "class vtkOpenGLRenderPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLRenderPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern uint vtkOpenGLRenderPass_GetActiveDrawBuffers_01(HandleRef pThis);

	/// <summary>
	/// Number of active draw buffers.
	/// </summary>
	public virtual uint GetActiveDrawBuffers()
	{
		return vtkOpenGLRenderPass_GetActiveDrawBuffers_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderPass_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLRenderPass_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderPass_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLRenderPass_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkOpenGLRenderPass_GetShaderStageMTime_04(HandleRef pThis);

	/// <summary>
	/// For multi-stage render passes that need to change shader code during a
	/// single pass, use this method to notify a mapper that the shader needs to be
	/// rebuilt (rather than reuse the last cached shader. This method should
	/// return the last time that the shader stage changed, or 0 if the shader
	/// is single-stage.
	/// </summary>
	public virtual ulong GetShaderStageMTime()
	{
		return vtkOpenGLRenderPass_GetShaderStageMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderPass_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLRenderPass_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderPass_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLRenderPass_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLRenderPass NewInstance()
	{
		vtkOpenGLRenderPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderPass_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderPass_PostReplaceShaderValues_08(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Use vtkShaderProgram::Substitute to replace @code //VTK::XXX:YYY @endcode declarations in
	/// the shader sources. Gets called before other mapper shader replacements
	/// Return false on error.
	/// </summary>
	public virtual bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkOpenGLRenderPass_PostReplaceShaderValues_08(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLRenderPass_PreReplaceShaderValues_09(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Use vtkShaderProgram::Substitute to replace @code //VTK::XXX:YYY @endcode declarations in
	/// the shader sources. Gets called before other mapper shader replacements
	/// Return false on error.
	/// </summary>
	public virtual bool PreReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkOpenGLRenderPass_PreReplaceShaderValues_09(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderPass_RenderPasses_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key containing information about the current pass.
	/// </summary>
	public static vtkInformationObjectBaseVectorKey RenderPasses()
	{
		vtkInformationObjectBaseVectorKey vtkInformationObjectBaseVectorKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderPass_RenderPasses_10(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationObjectBaseVectorKey2 = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationObjectBaseVectorKey2.Register(null);
			}
		}
		return vtkInformationObjectBaseVectorKey2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderPass_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRenderPass SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLRenderPass vtkOpenGLRenderPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderPass_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLRenderPass2 = (vtkOpenGLRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLRenderPass2.Register(null);
			}
		}
		return vtkOpenGLRenderPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderPass_SetActiveDrawBuffers_12(HandleRef pThis, uint _arg);

	/// <summary>
	/// Number of active draw buffers.
	/// </summary>
	public virtual void SetActiveDrawBuffers(uint _arg)
	{
		vtkOpenGLRenderPass_SetActiveDrawBuffers_12(GetCppThis(), _arg);
	}
}
