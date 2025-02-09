using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSSAOPass
/// </summary>
/// <remarks>
///    Implement a screen-space ambient occlusion pass.
///
/// SSAO darkens some pixels to improve depth perception simulating ambient occlusion
/// in screen space.
/// For each fragment, random samples inside a hemisphere at the fragment position oriented with
/// the normal are tested against other fragments to compute an average occlusion.
/// The number of samples and the radius of the hemisphere are configurables.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass
/// </seealso>
public class vtkSSAOPass : vtkImageProcessingPass
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSSAOPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSSAOPass()
	{
		MRClassNameKey = "class vtkSSAOPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSSAOPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSSAOPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSSAOPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSSAOPass New()
	{
		vtkSSAOPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSSAOPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSSAOPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSSAOPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSSAOPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSSAOPass_BlurOff_01(HandleRef pThis);

	/// <summary>
	/// Get/Set blurring of the ambient occlusion.
	/// Blurring can help to improve the result if samples number is low.
	/// Default is false
	/// </summary>
	public virtual void BlurOff()
	{
		vtkSSAOPass_BlurOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSSAOPass_BlurOn_02(HandleRef pThis);

	/// <summary>
	/// Get/Set blurring of the ambient occlusion.
	/// Blurring can help to improve the result if samples number is low.
	/// Default is false
	/// </summary>
	public virtual void BlurOn()
	{
		vtkSSAOPass_BlurOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSSAOPass_GetBias_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the bias when comparing samples.
	/// Default is 0.01
	/// </summary>
	public virtual double GetBias()
	{
		return vtkSSAOPass_GetBias_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSSAOPass_GetBlur_04(HandleRef pThis);

	/// <summary>
	/// Get/Set blurring of the ambient occlusion.
	/// Blurring can help to improve the result if samples number is low.
	/// Default is false
	/// </summary>
	public virtual bool GetBlur()
	{
		return (vtkSSAOPass_GetBlur_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkSSAOPass_GetKernelSize_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of samples.
	/// Default is 32
	/// </summary>
	public virtual uint GetKernelSize()
	{
		return vtkSSAOPass_GetKernelSize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkSSAOPass_GetKernelSizeMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of samples.
	/// Default is 32
	/// </summary>
	public virtual uint GetKernelSizeMaxValue()
	{
		return vtkSSAOPass_GetKernelSizeMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkSSAOPass_GetKernelSizeMinValue_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of samples.
	/// Default is 32
	/// </summary>
	public virtual uint GetKernelSizeMinValue()
	{
		return vtkSSAOPass_GetKernelSizeMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSSAOPass_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSSAOPass_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSSAOPass_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSSAOPass_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSSAOPass_GetRadius_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the SSAO hemisphere radius.
	/// Default is 0.5
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkSSAOPass_GetRadius_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSSAOPass_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSSAOPass_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSSAOPass_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSSAOPass_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSSAOPass_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSSAOPass NewInstance()
	{
		vtkSSAOPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSSAOPass_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSSAOPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSSAOPass_PostReplaceShaderValues_15(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Post replace shader values
	/// </summary>
	public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkSSAOPass_PostReplaceShaderValues_15(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSSAOPass_PreReplaceShaderValues_16(HandleRef pThis, string vertexShader, string geometryShader, string fragmentShader, HandleRef mapper, HandleRef prop);

	/// <summary>
	/// Pre replace shader values
	/// </summary>
	public override bool PreReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
	{
		return (vtkSSAOPass_PreReplaceShaderValues_16(GetCppThis(), vertexShader, geometryShader, fragmentShader, mapper?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSSAOPass_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own resources.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkSSAOPass_ReleaseGraphicsResources_17(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSSAOPass_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSSAOPass SafeDownCast(vtkObjectBase o)
	{
		vtkSSAOPass vtkSSAOPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSSAOPass_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSSAOPass2 = (vtkSSAOPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSSAOPass2.Register(null);
			}
		}
		return vtkSSAOPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSSAOPass_SetBias_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the bias when comparing samples.
	/// Default is 0.01
	/// </summary>
	public virtual void SetBias(double _arg)
	{
		vtkSSAOPass_SetBias_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSSAOPass_SetBlur_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set blurring of the ambient occlusion.
	/// Blurring can help to improve the result if samples number is low.
	/// Default is false
	/// </summary>
	public virtual void SetBlur(bool _arg)
	{
		vtkSSAOPass_SetBlur_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSSAOPass_SetKernelSize_21(HandleRef pThis, uint _arg);

	/// <summary>
	/// Get/Set the number of samples.
	/// Default is 32
	/// </summary>
	public virtual void SetKernelSize(uint _arg)
	{
		vtkSSAOPass_SetKernelSize_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSSAOPass_SetRadius_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the SSAO hemisphere radius.
	/// Default is 0.5
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkSSAOPass_SetRadius_22(GetCppThis(), _arg);
	}
}
