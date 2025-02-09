using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageBlend
/// </summary>
/// <remarks>
///    blend images together using alpha or opacity
///
/// vtkImageBlend takes L, LA, RGB, or RGBA images as input and blends them
/// according to the alpha values and/or the opacity setting for each input.
///
/// The spacing, origin, extent, and number of components of the output are
/// the same as those for the first input.  If the input has an alpha
/// component, then this component is copied unchanged into the output.
/// In addition, if the first input has either one component or two
/// components i.e. if it is either L (greyscale) or LA (greyscale + alpha)
/// then all other inputs must also be L or LA.
///
/// Different blending modes are available:
///
/// \em Normal (default) :
/// This is the standard blending mode used by OpenGL and other graphics
/// packages.  The output always has the same number of components
/// and the same extent as the first input.  The alpha value of the first
/// input is not used in the blending computation, instead it is copied
/// directly to the output.
///
/// <code>
/// output &lt;- input[0]
/// foreach input i {
///   foreach pixel px {
///     r &lt;- input[i](px)(alpha) * opacity[i]
///     f &lt;- (255 - r)
///     output(px) &lt;- output(px) * f + input(px) * r
///   }
/// }
/// </code>
///
/// \em Compound :
/// Images are compounded together and each component is scaled by the sum of
/// the alpha/opacity values. Use the CompoundThreshold method to set
/// specify a threshold in compound mode. Pixels with opacity*alpha less
/// or equal than this threshold are ignored.
/// The alpha value of the first input, if present, is NOT copied to the alpha
/// value of the output.  The output always has the same number of components
/// and the same extent as the first input.
/// If CompoundAlpha is set, the alpha value of the output is also computed using
/// the alpha weighted blend calculation.
///
/// <code>
/// output &lt;- 0
/// foreach pixel px {
///   sum &lt;- 0
///   foreach input i {
///     r &lt;- input[i](px)(alpha) * opacity(i)
///     sum &lt;- sum + r
///     if r &gt; threshold {
///       output(px) &lt;- output(px) + input(px) * r
///     }
///   }
///   output(px) &lt;- output(px) / sum
/// }
/// </code>
/// </remarks>
public class vtkImageBlend : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageBlend";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageBlend()
	{
		MRClassNameKey = "class vtkImageBlend";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageBlend"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageBlend(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBlend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageBlend New()
	{
		vtkImageBlend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBlend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageBlend()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageBlend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_CompoundAlphaOff_01(HandleRef pThis);

	/// <summary>
	/// Set whether to use the alpha weighted blending calculation on the alpha
	/// component. If false, the alpha component is set to the sum of the product
	/// of opacity and alpha from all inputs.
	/// </summary>
	public virtual void CompoundAlphaOff()
	{
		vtkImageBlend_CompoundAlphaOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_CompoundAlphaOn_02(HandleRef pThis);

	/// <summary>
	/// Set whether to use the alpha weighted blending calculation on the alpha
	/// component. If false, the alpha component is set to the sum of the product
	/// of opacity and alpha from all inputs.
	/// </summary>
	public virtual void CompoundAlphaOn()
	{
		vtkImageBlend_CompoundAlphaOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBlend_GetBlendMode_03(HandleRef pThis);

	/// <summary>
	/// Set the blend mode
	/// </summary>
	public virtual int GetBlendMode()
	{
		return vtkImageBlend_GetBlendMode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBlend_GetBlendModeAsString_04(HandleRef pThis);

	/// <summary>
	/// Set the blend mode
	/// </summary>
	public string GetBlendModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageBlend_GetBlendModeAsString_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBlend_GetBlendModeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the blend mode
	/// </summary>
	public virtual int GetBlendModeMaxValue()
	{
		return vtkImageBlend_GetBlendModeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBlend_GetBlendModeMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the blend mode
	/// </summary>
	public virtual int GetBlendModeMinValue()
	{
		return vtkImageBlend_GetBlendModeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBlend_GetCompoundAlpha_07(HandleRef pThis);

	/// <summary>
	/// Set whether to use the alpha weighted blending calculation on the alpha
	/// component. If false, the alpha component is set to the sum of the product
	/// of opacity and alpha from all inputs.
	/// </summary>
	public virtual int GetCompoundAlpha()
	{
		return vtkImageBlend_GetCompoundAlpha_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageBlend_GetCompoundThreshold_08(HandleRef pThis);

	/// <summary>
	/// Specify a threshold in compound mode. Pixels with opacity*alpha less
	/// or equal the threshold are ignored.
	/// </summary>
	public virtual double GetCompoundThreshold()
	{
		return vtkImageBlend_GetCompoundThreshold_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBlend_GetInput_09(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get one input to this filter. This method is only for support of
	/// old-style pipeline connections.  When writing new code you should
	/// use vtkAlgorithm::GetInputConnection(0, num).
	/// </summary>
	public new vtkDataObject GetInput(int num)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBlend_GetInput_09(GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBlend_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get one input to this filter. This method is only for support of
	/// old-style pipeline connections.  When writing new code you should
	/// use vtkAlgorithm::GetInputConnection(0, num).
	/// </summary>
	public new vtkDataObject GetInput()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBlend_GetInput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageBlend_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageBlend_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageBlend_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageBlend_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBlend_GetNumberOfInputs_13(HandleRef pThis);

	/// <summary>
	/// Get the number of inputs to this filter. This method is only for
	/// support of old-style pipeline connections.  When writing new code
	/// you should use vtkAlgorithm::GetNumberOfInputConnections(0).
	/// </summary>
	public int GetNumberOfInputs()
	{
		return vtkImageBlend_GetNumberOfInputs_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageBlend_GetOpacity_14(HandleRef pThis, int idx);

	/// <summary>
	/// Set the opacity of an input image: the alpha values of the image are
	/// multiplied by the opacity.  The opacity of image idx=0 is ignored.
	/// </summary>
	public double GetOpacity(int idx)
	{
		return vtkImageBlend_GetOpacity_14(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBlend_GetStencil_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a stencil to apply when blending the data.
	/// </summary>
	public vtkImageStencilData GetStencil()
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBlend_GetStencil_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBlend_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageBlend_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageBlend_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageBlend_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBlend_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageBlend NewInstance()
	{
		vtkImageBlend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBlend_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_ReplaceNthInputConnection_20(HandleRef pThis, int idx, HandleRef input);

	/// <summary>
	/// Replace one of the input connections with a new input.  You can
	/// only replace input connections that you previously created with
	/// AddInputConnection() or, in the case of the first input,
	/// with SetInputConnection().
	/// </summary>
	public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
	{
		vtkImageBlend_ReplaceNthInputConnection_20(GetCppThis(), idx, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageBlend_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageBlend SafeDownCast(vtkObjectBase o)
	{
		vtkImageBlend vtkImageBlend2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageBlend_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageBlend2 = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageBlend2.Register(null);
			}
		}
		return vtkImageBlend2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetBlendMode_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the blend mode
	/// </summary>
	public virtual void SetBlendMode(int _arg)
	{
		vtkImageBlend_SetBlendMode_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetBlendModeToCompound_23(HandleRef pThis);

	/// <summary>
	/// Set the blend mode
	/// </summary>
	public void SetBlendModeToCompound()
	{
		vtkImageBlend_SetBlendModeToCompound_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetBlendModeToNormal_24(HandleRef pThis);

	/// <summary>
	/// Set the blend mode
	/// </summary>
	public void SetBlendModeToNormal()
	{
		vtkImageBlend_SetBlendModeToNormal_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetCompoundAlpha_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to use the alpha weighted blending calculation on the alpha
	/// component. If false, the alpha component is set to the sum of the product
	/// of opacity and alpha from all inputs.
	/// </summary>
	public virtual void SetCompoundAlpha(int _arg)
	{
		vtkImageBlend_SetCompoundAlpha_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetCompoundThreshold_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a threshold in compound mode. Pixels with opacity*alpha less
	/// or equal the threshold are ignored.
	/// </summary>
	public virtual void SetCompoundThreshold(double _arg)
	{
		vtkImageBlend_SetCompoundThreshold_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetInputData_27(HandleRef pThis, int num, HandleRef input);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public new void SetInputData(int num, vtkDataObject input)
	{
		vtkImageBlend_SetInputData_27(GetCppThis(), num, input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetInputData_28(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Assign a data object as input. Note that this method does not
	/// establish a pipeline connection. Use SetInputConnection() to
	/// setup a pipeline connection.
	/// </summary>
	public new void SetInputData(vtkDataObject input)
	{
		vtkImageBlend_SetInputData_28(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetOpacity_29(HandleRef pThis, int idx, double opacity);

	/// <summary>
	/// Set the opacity of an input image: the alpha values of the image are
	/// multiplied by the opacity.  The opacity of image idx=0 is ignored.
	/// </summary>
	public void SetOpacity(int idx, double opacity)
	{
		vtkImageBlend_SetOpacity_29(GetCppThis(), idx, opacity);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetStencilConnection_30(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Set a stencil to apply when blending the data.
	/// Create a pipeline connection.
	/// </summary>
	public void SetStencilConnection(vtkAlgorithmOutput algOutput)
	{
		vtkImageBlend_SetStencilConnection_30(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageBlend_SetStencilData_31(HandleRef pThis, HandleRef stencil);

	/// <summary>
	/// Set a stencil to apply when blending the data.
	/// </summary>
	public void SetStencilData(vtkImageStencilData stencil)
	{
		vtkImageBlend_SetStencilData_31(GetCppThis(), stencil?.GetCppThis() ?? default(HandleRef));
	}
}
