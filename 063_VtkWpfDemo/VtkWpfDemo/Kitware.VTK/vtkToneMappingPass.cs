using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkToneMappingPass
/// </summary>
/// <remarks>
///    Implement a post-processing Tone Mapping.
///
/// Tone mapping is the process of mapping HDR colors to [0;1] range.
/// This render pass supports four different modes:
/// - Clamp: clamps the color to [0;1] range
/// - Reinhard: maps the color using formula: x/(x+1)
/// - Exponential: maps the colors using a coefficient and the formula: 1-exp(-a*x)
/// - GenericFilmic: maps the color using five parameters that allow to shape the
///                  tonemapping curve : Contrast adjust the toe (left part) of the curve;
///                  Shoulder adjusts the right part; MidIn and MidOut adjusts the middle gray
///                  level in percent of the curve for input and output (ie. the halfway point
///                  between white and black); and HdrMax is the maximum HDR input that is not
///                  clipped. A boolean UseACES allows to use the Academy Color Encoding System.
///
/// Advanced tone mapping like GenericFilmic, Reinhard or Exponential can be useful when several
/// lights are added to the renderer.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass
/// </seealso>
public class vtkToneMappingPass : vtkImageProcessingPass
{
	/// <summary>
	/// Enumeration of tone mapping algorithms
	/// </summary>
	public enum Clamp_WrapperEnum
	{
		/// <summary>enum member</summary>
		Clamp = 0,
		/// <summary>enum member</summary>
		Exponential = 2,
		/// <summary>enum member</summary>
		GenericFilmic = 3,
		/// <summary>enum member</summary>
		Reinhard = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkToneMappingPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkToneMappingPass()
	{
		MRClassNameKey = "class vtkToneMappingPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkToneMappingPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkToneMappingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkToneMappingPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkToneMappingPass New()
	{
		vtkToneMappingPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkToneMappingPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkToneMappingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkToneMappingPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkToneMappingPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkToneMappingPass_GetContrast_01(HandleRef pThis);

	/// <summary>
	/// Contrast adjust the toe of the curve. Typically in [1-2].
	/// Default is 1.6773
	/// </summary>
	public virtual float GetContrast()
	{
		return vtkToneMappingPass_GetContrast_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetContrastMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Contrast adjust the toe of the curve. Typically in [1-2].
	/// Default is 1.6773
	/// </summary>
	public virtual float GetContrastMaxValue()
	{
		return vtkToneMappingPass_GetContrastMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetContrastMinValue_03(HandleRef pThis);

	/// <summary>
	/// Contrast adjust the toe of the curve. Typically in [1-2].
	/// Default is 1.6773
	/// </summary>
	public virtual float GetContrastMinValue()
	{
		return vtkToneMappingPass_GetContrastMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetExposure_04(HandleRef pThis);

	/// <summary>
	/// Get/Set Exposure coefficient used for exponential and Generic Filmic tone mapping.
	/// Default is 1.0
	/// </summary>
	public virtual float GetExposure()
	{
		return vtkToneMappingPass_GetExposure_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetHdrMax_05(HandleRef pThis);

	/// <summary>
	/// Maximum HDR input that is not clipped.
	/// Default is 11.0785
	/// </summary>
	public virtual float GetHdrMax()
	{
		return vtkToneMappingPass_GetHdrMax_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetHdrMaxMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Maximum HDR input that is not clipped.
	/// Default is 11.0785
	/// </summary>
	public virtual float GetHdrMaxMaxValue()
	{
		return vtkToneMappingPass_GetHdrMaxMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetHdrMaxMinValue_07(HandleRef pThis);

	/// <summary>
	/// Maximum HDR input that is not clipped.
	/// Default is 11.0785
	/// </summary>
	public virtual float GetHdrMaxMinValue()
	{
		return vtkToneMappingPass_GetHdrMaxMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetMidIn_08(HandleRef pThis);

	/// <summary>
	/// Mid level anchor input.
	/// Default is 0.18 (in percent gray)
	/// </summary>
	public virtual float GetMidIn()
	{
		return vtkToneMappingPass_GetMidIn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetMidInMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Mid level anchor input.
	/// Default is 0.18 (in percent gray)
	/// </summary>
	public virtual float GetMidInMaxValue()
	{
		return vtkToneMappingPass_GetMidInMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetMidInMinValue_10(HandleRef pThis);

	/// <summary>
	/// Mid level anchor input.
	/// Default is 0.18 (in percent gray)
	/// </summary>
	public virtual float GetMidInMinValue()
	{
		return vtkToneMappingPass_GetMidInMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetMidOut_11(HandleRef pThis);

	/// <summary>
	/// Mid level anchor output.
	/// Default is 0.18 (in percent gray)
	/// </summary>
	public virtual float GetMidOut()
	{
		return vtkToneMappingPass_GetMidOut_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetMidOutMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Mid level anchor output.
	/// Default is 0.18 (in percent gray)
	/// </summary>
	public virtual float GetMidOutMaxValue()
	{
		return vtkToneMappingPass_GetMidOutMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetMidOutMinValue_13(HandleRef pThis);

	/// <summary>
	/// Mid level anchor output.
	/// Default is 0.18 (in percent gray)
	/// </summary>
	public virtual float GetMidOutMinValue()
	{
		return vtkToneMappingPass_GetMidOutMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkToneMappingPass_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkToneMappingPass_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkToneMappingPass_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkToneMappingPass_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetShoulder_16(HandleRef pThis);

	/// <summary>
	/// Shoulder limit the output in the shoulder region of the curve.
	/// Typically in [0.9-1].
	/// Default is 0.9714
	/// </summary>
	public virtual float GetShoulder()
	{
		return vtkToneMappingPass_GetShoulder_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetShoulderMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Shoulder limit the output in the shoulder region of the curve.
	/// Typically in [0.9-1].
	/// Default is 0.9714
	/// </summary>
	public virtual float GetShoulderMaxValue()
	{
		return vtkToneMappingPass_GetShoulderMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkToneMappingPass_GetShoulderMinValue_18(HandleRef pThis);

	/// <summary>
	/// Shoulder limit the output in the shoulder region of the curve.
	/// Typically in [0.9-1].
	/// Default is 0.9714
	/// </summary>
	public virtual float GetShoulderMinValue()
	{
		return vtkToneMappingPass_GetShoulderMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkToneMappingPass_GetToneMappingType_19(HandleRef pThis);

	/// <summary>
	/// Get/Set the tone mapping type.
	/// Default is GenericFilmic
	/// </summary>
	public virtual int GetToneMappingType()
	{
		return vtkToneMappingPass_GetToneMappingType_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkToneMappingPass_GetToneMappingTypeMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the tone mapping type.
	/// Default is GenericFilmic
	/// </summary>
	public virtual int GetToneMappingTypeMaxValue()
	{
		return vtkToneMappingPass_GetToneMappingTypeMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkToneMappingPass_GetToneMappingTypeMinValue_21(HandleRef pThis);

	/// <summary>
	/// Get/Set the tone mapping type.
	/// Default is GenericFilmic
	/// </summary>
	public virtual int GetToneMappingTypeMinValue()
	{
		return vtkToneMappingPass_GetToneMappingTypeMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkToneMappingPass_GetUseACES_22(HandleRef pThis);

	/// <summary>
	/// Apply or not the Academy Color Encoding System (ACES).
	/// Default is true
	/// </summary>
	public virtual bool GetUseACES()
	{
		return (vtkToneMappingPass_GetUseACES_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkToneMappingPass_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkToneMappingPass_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkToneMappingPass_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkToneMappingPass_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkToneMappingPass_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkToneMappingPass NewInstance()
	{
		vtkToneMappingPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkToneMappingPass_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkToneMappingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own resources.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkToneMappingPass_ReleaseGraphicsResources_27(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkToneMappingPass_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkToneMappingPass SafeDownCast(vtkObjectBase o)
	{
		vtkToneMappingPass vtkToneMappingPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkToneMappingPass_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkToneMappingPass2 = (vtkToneMappingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkToneMappingPass2.Register(null);
			}
		}
		return vtkToneMappingPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetContrast_29(HandleRef pThis, float _arg);

	/// <summary>
	/// Contrast adjust the toe of the curve. Typically in [1-2].
	/// Default is 1.6773
	/// </summary>
	public virtual void SetContrast(float _arg)
	{
		vtkToneMappingPass_SetContrast_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetExposure_30(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set Exposure coefficient used for exponential and Generic Filmic tone mapping.
	/// Default is 1.0
	/// </summary>
	public virtual void SetExposure(float _arg)
	{
		vtkToneMappingPass_SetExposure_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetGenericFilmicDefaultPresets_31(HandleRef pThis);

	/// <summary>
	/// Set function to set uncharted 2 presets, and default presets
	/// </summary>
	public void SetGenericFilmicDefaultPresets()
	{
		vtkToneMappingPass_SetGenericFilmicDefaultPresets_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetGenericFilmicUncharted2Presets_32(HandleRef pThis);

	/// <summary>
	/// Set function to set uncharted 2 presets, and default presets
	/// </summary>
	public void SetGenericFilmicUncharted2Presets()
	{
		vtkToneMappingPass_SetGenericFilmicUncharted2Presets_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetHdrMax_33(HandleRef pThis, float _arg);

	/// <summary>
	/// Maximum HDR input that is not clipped.
	/// Default is 11.0785
	/// </summary>
	public virtual void SetHdrMax(float _arg)
	{
		vtkToneMappingPass_SetHdrMax_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetMidIn_34(HandleRef pThis, float _arg);

	/// <summary>
	/// Mid level anchor input.
	/// Default is 0.18 (in percent gray)
	/// </summary>
	public virtual void SetMidIn(float _arg)
	{
		vtkToneMappingPass_SetMidIn_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetMidOut_35(HandleRef pThis, float _arg);

	/// <summary>
	/// Mid level anchor output.
	/// Default is 0.18 (in percent gray)
	/// </summary>
	public virtual void SetMidOut(float _arg)
	{
		vtkToneMappingPass_SetMidOut_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetShoulder_36(HandleRef pThis, float _arg);

	/// <summary>
	/// Shoulder limit the output in the shoulder region of the curve.
	/// Typically in [0.9-1].
	/// Default is 0.9714
	/// </summary>
	public virtual void SetShoulder(float _arg)
	{
		vtkToneMappingPass_SetShoulder_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetToneMappingType_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the tone mapping type.
	/// Default is GenericFilmic
	/// </summary>
	public virtual void SetToneMappingType(int _arg)
	{
		vtkToneMappingPass_SetToneMappingType_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkToneMappingPass_SetUseACES_38(HandleRef pThis, byte _arg);

	/// <summary>
	/// Apply or not the Academy Color Encoding System (ACES).
	/// Default is true
	/// </summary>
	public virtual void SetUseACES(bool _arg)
	{
		vtkToneMappingPass_SetUseACES_38(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
