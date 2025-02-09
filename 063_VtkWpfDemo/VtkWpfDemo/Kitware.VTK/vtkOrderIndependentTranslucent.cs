using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOrderIndependentTranslucentPass
/// </summary>
/// <remarks>
///    Implement OIT rendering using average color
///
/// Simple version that uses average alpha weighted color
/// and correct final computed alpha. Single pass approach.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass, vtkTranslucentPass, vtkFramebufferPass
/// </seealso>
public class vtkOrderIndependentTranslucentPass : vtkOpenGLRenderPass
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOrderIndependentTranslucentPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOrderIndependentTranslucentPass()
	{
		MRClassNameKey = "class vtkOrderIndependentTranslucentPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrderIndependentTranslucentPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOrderIndependentTranslucentPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderIndependentTranslucentPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOrderIndependentTranslucentPass New()
	{
		vtkOrderIndependentTranslucentPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderIndependentTranslucentPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrderIndependentTranslucentPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOrderIndependentTranslucentPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOrderIndependentTranslucentPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkOrderIndependentTranslucentPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOrderIndependentTranslucentPass_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrderIndependentTranslucentPass_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOrderIndependentTranslucentPass_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderIndependentTranslucentPass_GetTranslucentPass_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Delegate for rendering the translucent polygonal geometry.
	/// If it is NULL, nothing will be rendered and a warning will be emitted.
	/// It is usually set to a vtkTranslucentPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual vtkRenderPass GetTranslucentPass()
	{
		vtkRenderPass vtkRenderPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderIndependentTranslucentPass_GetTranslucentPass_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkOrderIndependentTranslucentPass_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOrderIndependentTranslucentPass_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrderIndependentTranslucentPass_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOrderIndependentTranslucentPass_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderIndependentTranslucentPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOrderIndependentTranslucentPass NewInstance()
	{
		vtkOrderIndependentTranslucentPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderIndependentTranslucentPass_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrderIndependentTranslucentPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOrderIndependentTranslucentPass_PostReplaceShaderValues_08(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Delegate for rendering the translucent polygonal geometry.
	/// If it is NULL, nothing will be rendered and a warning will be emitted.
	/// It is usually set to a vtkTranslucentPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkOrderIndependentTranslucentPass_PostReplaceShaderValues_08(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderIndependentTranslucentPass_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own
	/// resources.
	/// \pre w_exists: w!=0
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkOrderIndependentTranslucentPass_ReleaseGraphicsResources_09(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrderIndependentTranslucentPass_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOrderIndependentTranslucentPass SafeDownCast(vtkObjectBase o)
	{
		vtkOrderIndependentTranslucentPass vtkOrderIndependentTranslucentPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrderIndependentTranslucentPass_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOrderIndependentTranslucentPass2 = (vtkOrderIndependentTranslucentPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOrderIndependentTranslucentPass2.Register(null);
			}
		}
		return vtkOrderIndependentTranslucentPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrderIndependentTranslucentPass_SetTranslucentPass_11(HandleRef pThis, HandleRef translucentPass);

	/// <summary>
	/// Delegate for rendering the translucent polygonal geometry.
	/// If it is NULL, nothing will be rendered and a warning will be emitted.
	/// It is usually set to a vtkTranslucentPass.
	/// Initial value is a NULL pointer.
	/// </summary>
	public virtual void SetTranslucentPass(vtkRenderPass translucentPass)
	{
		vtkOrderIndependentTranslucentPass_SetTranslucentPass_11(GetCppThis(), translucentPass?.GetCppThis() ?? default(HandleRef));
	}
}
