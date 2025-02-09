using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolumeProperty
/// </summary>
/// <remarks>
///    represents the common properties for rendering a volume.
///
/// vtkVolumeProperty is used to represent common properties associated
/// with volume rendering. This includes properties for determining the type
/// of interpolation to use when sampling a volume, the color of a volume,
/// the scalar opacity of a volume, the gradient opacity of a volume, and the
/// shading parameters of a volume.
///
/// Color, scalar opacity and gradient magnitude opacity transfer functions
/// can be set as either 3 separate 1D functions or as a single 2D transfer
/// function.
///
/// - 1D Transfer functions (vtkVolumeProperty::TF_1D)
/// Color, scalar opacity and gradient magnitude opacity are defined by 1
/// vtkColorTransferFunction and 2 vtkPiecewiseFunctions respectively.
/// When the scalar opacity or the gradient opacity of a volume is not set,
/// then the function is defined to be a constant value of 1.0. When a
/// scalar and gradient opacity are both set simultaneously, then the opacity
/// is defined to be the product of the scalar opacity and gradient opacity
/// transfer functions. 1D transfer functions is the legacy and default behavior.
///
/// - 2D Transfer functions (vtkVolumeProperty::TF_2D)
/// Color and scalar/gradient magnitude opacity are defined by a 4-component
/// vtkImageData instance mapping scalar value vs. gradient magnitude on its
/// x and y axis respectively. This mode is only available if a 2D TF has been
/// explicitly set (see SetTransferFunction2D).
///
/// Most properties can be set per "component" for volume mappers that
/// support multiple independent components. If you are using 2 component
/// data as LV or 4 component data as RGBV (as specified in the mapper)
/// only the first scalar opacity and gradient opacity transfer functions
/// will be used (and all color functions will be ignored). Omitting the
/// index parameter on the Set/Get methods will access index = 0.
///
/// </remarks>
/// <seealso>
///  vtkPiecewiseFunction vtkColorTransferFunction
/// </seealso>
public class vtkVolumeProperty : vtkObject
{
	/// <summary>
	/// Color-opacity transfer function mode. TF_1D is its default value.
	///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
	///  and gradient mag. opacity.
	///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
	///  opacity.
	/// </summary>
	public enum TransferMode
	{
		/// <summary>enum member</summary>
		TF_1D,
		/// <summary>enum member</summary>
		TF_2D
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeProperty";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolumeProperty()
	{
		MRClassNameKey = "class vtkVolumeProperty";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeProperty"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolumeProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeProperty New()
	{
		vtkVolumeProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVolumeProperty()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVolumeProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_DeepCopy_01(HandleRef pThis, HandleRef p);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void DeepCopy(vtkVolumeProperty p)
	{
		vtkVolumeProperty_DeepCopy_01(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_DisableGradientOpacityOff_02(HandleRef pThis, int index);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public virtual void DisableGradientOpacityOff(int index)
	{
		vtkVolumeProperty_DisableGradientOpacityOff_02(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_DisableGradientOpacityOff_03(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public virtual void DisableGradientOpacityOff()
	{
		vtkVolumeProperty_DisableGradientOpacityOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_DisableGradientOpacityOn_04(HandleRef pThis, int index);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public virtual void DisableGradientOpacityOn(int index)
	{
		vtkVolumeProperty_DisableGradientOpacityOn_04(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_DisableGradientOpacityOn_05(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public virtual void DisableGradientOpacityOn()
	{
		vtkVolumeProperty_DisableGradientOpacityOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetAmbient_06(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the ambient lighting coefficient.
	/// </summary>
	public double GetAmbient(int index)
	{
		return vtkVolumeProperty_GetAmbient_06(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetAmbient_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the ambient lighting coefficient.
	/// </summary>
	public double GetAmbient()
	{
		return vtkVolumeProperty_GetAmbient_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetClippedVoxelIntensity_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the intensity value for voxels in the clipped space for gradient
	/// computations (for shading and gradient based opacity modulation).
	/// By default, this is set to VTK_DOUBLE_MIN.
	///
	/// \note This value is only used when UseClippedVoxelIntensity is true.
	/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
	/// \sa SetUseClippedVoxelIntensity
	/// </summary>
	public virtual double GetClippedVoxelIntensity()
	{
		return vtkVolumeProperty_GetClippedVoxelIntensity_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetColorChannels_09(HandleRef pThis, int index);

	/// <summary>
	/// Get the number of color channels in the transfer function
	/// for the given component.
	/// </summary>
	public int GetColorChannels(int index)
	{
		return vtkVolumeProperty_GetColorChannels_09(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetColorChannels_10(HandleRef pThis);

	/// <summary>
	/// Get the number of color channels in the transfer function
	/// for the given component.
	/// </summary>
	public int GetColorChannels()
	{
		return vtkVolumeProperty_GetColorChannels_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetComponentWeight_11(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the scalar component weights.
	/// Clamped between the range of (0.0, 1.0)
	/// </summary>
	public virtual double GetComponentWeight(int index)
	{
		return vtkVolumeProperty_GetComponentWeight_11(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetDiffuse_12(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the diffuse lighting coefficient.
	/// </summary>
	public double GetDiffuse(int index)
	{
		return vtkVolumeProperty_GetDiffuse_12(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetDiffuse_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the diffuse lighting coefficient.
	/// </summary>
	public double GetDiffuse()
	{
		return vtkVolumeProperty_GetDiffuse_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetDisableGradientOpacity_14(HandleRef pThis, int index);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public virtual int GetDisableGradientOpacity(int index)
	{
		return vtkVolumeProperty_GetDisableGradientOpacity_14(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetDisableGradientOpacity_15(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public virtual int GetDisableGradientOpacity()
	{
		return vtkVolumeProperty_GetDisableGradientOpacity_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetGradientOpacity_16(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the gradient magnitude opacity transfer function for
	/// the given component.
	/// If no transfer function has been set for this component, a default one
	/// is created and returned.
	/// This default function is always returned if DisableGradientOpacity is On
	/// for that component.
	/// </summary>
	public vtkPiecewiseFunction GetGradientOpacity(int index)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetGradientOpacity_16(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetGradientOpacity_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the gradient magnitude opacity transfer function for
	/// the given component.
	/// If no transfer function has been set for this component, a default one
	/// is created and returned.
	/// This default function is always returned if DisableGradientOpacity is On
	/// for that component.
	/// </summary>
	public vtkPiecewiseFunction GetGradientOpacity()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetGradientOpacity_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetGrayTransferFunction_18(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the gray transfer function.
	/// If no transfer function has been set for this component, a default one
	/// is created and returned.
	/// </summary>
	public vtkPiecewiseFunction GetGrayTransferFunction(int index)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetGrayTransferFunction_18(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetGrayTransferFunction_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the gray transfer function.
	/// If no transfer function has been set for this component, a default one
	/// is created and returned.
	/// </summary>
	public vtkPiecewiseFunction GetGrayTransferFunction()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetGrayTransferFunction_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetIndependentComponents_20(HandleRef pThis);

	/// <summary>
	/// Does the data have independent components, or do some define color
	/// only? If IndependentComponents is On (the default) then each component
	/// will be independently passed through a lookup table to determine RGBA,
	/// shaded. Some volume Mappers can handle 1 to 4 component
	/// unsigned char or unsigned short data (see each mapper header file to
	/// determine functionality). If IndependentComponents is Off, then you
	/// must have either 2 or 4 component data. For 2 component data, the
	/// first is passed through the first color transfer function and the
	/// second component is passed through the first scalar opacity (and
	/// gradient opacity) transfer function.
	/// Normals will be generated off of the second component. When using gradient
	/// based opacity modulation, the gradients are computed off of the
	/// second component. For 4 component
	/// data, the first three will directly represent RGB (no lookup table).
	/// The fourth component will be passed through the first scalar opacity
	/// transfer function for opacity and first gradient opacity transfer function
	/// for gradient based opacity modulation. Normals will be generated from the
	/// fourth component. When using gradient based opacity modulation, the
	/// gradients are computed off of the fourth component.
	/// </summary>
	public virtual int GetIndependentComponents()
	{
		return vtkVolumeProperty_GetIndependentComponents_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetIndependentComponentsMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Does the data have independent components, or do some define color
	/// only? If IndependentComponents is On (the default) then each component
	/// will be independently passed through a lookup table to determine RGBA,
	/// shaded. Some volume Mappers can handle 1 to 4 component
	/// unsigned char or unsigned short data (see each mapper header file to
	/// determine functionality). If IndependentComponents is Off, then you
	/// must have either 2 or 4 component data. For 2 component data, the
	/// first is passed through the first color transfer function and the
	/// second component is passed through the first scalar opacity (and
	/// gradient opacity) transfer function.
	/// Normals will be generated off of the second component. When using gradient
	/// based opacity modulation, the gradients are computed off of the
	/// second component. For 4 component
	/// data, the first three will directly represent RGB (no lookup table).
	/// The fourth component will be passed through the first scalar opacity
	/// transfer function for opacity and first gradient opacity transfer function
	/// for gradient based opacity modulation. Normals will be generated from the
	/// fourth component. When using gradient based opacity modulation, the
	/// gradients are computed off of the fourth component.
	/// </summary>
	public virtual int GetIndependentComponentsMaxValue()
	{
		return vtkVolumeProperty_GetIndependentComponentsMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetIndependentComponentsMinValue_22(HandleRef pThis);

	/// <summary>
	/// Does the data have independent components, or do some define color
	/// only? If IndependentComponents is On (the default) then each component
	/// will be independently passed through a lookup table to determine RGBA,
	/// shaded. Some volume Mappers can handle 1 to 4 component
	/// unsigned char or unsigned short data (see each mapper header file to
	/// determine functionality). If IndependentComponents is Off, then you
	/// must have either 2 or 4 component data. For 2 component data, the
	/// first is passed through the first color transfer function and the
	/// second component is passed through the first scalar opacity (and
	/// gradient opacity) transfer function.
	/// Normals will be generated off of the second component. When using gradient
	/// based opacity modulation, the gradients are computed off of the
	/// second component. For 4 component
	/// data, the first three will directly represent RGB (no lookup table).
	/// The fourth component will be passed through the first scalar opacity
	/// transfer function for opacity and first gradient opacity transfer function
	/// for gradient based opacity modulation. Normals will be generated from the
	/// fourth component. When using gradient based opacity modulation, the
	/// gradients are computed off of the fourth component.
	/// </summary>
	public virtual int GetIndependentComponentsMinValue()
	{
		return vtkVolumeProperty_GetIndependentComponentsMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetInterpolationType_23(HandleRef pThis);

	/// <summary>
	/// Set the interpolation type for sampling a volume. Initial value is
	/// VTK_NEAREST_INTERPOLATION.
	/// </summary>
	public virtual int GetInterpolationType()
	{
		return vtkVolumeProperty_GetInterpolationType_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetInterpolationTypeAsString_24(HandleRef pThis);

	/// <summary>
	/// Set the interpolation type for sampling a volume. Initial value is
	/// VTK_NEAREST_INTERPOLATION.
	/// </summary>
	public string GetInterpolationTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkVolumeProperty_GetInterpolationTypeAsString_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetInterpolationTypeMaxValue_25(HandleRef pThis);

	/// <summary>
	/// Set the interpolation type for sampling a volume. Initial value is
	/// VTK_NEAREST_INTERPOLATION.
	/// </summary>
	public virtual int GetInterpolationTypeMaxValue()
	{
		return vtkVolumeProperty_GetInterpolationTypeMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetInterpolationTypeMinValue_26(HandleRef pThis);

	/// <summary>
	/// Set the interpolation type for sampling a volume. Initial value is
	/// VTK_NEAREST_INTERPOLATION.
	/// </summary>
	public virtual int GetInterpolationTypeMinValue()
	{
		return vtkVolumeProperty_GetInterpolationTypeMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetIsoSurfaceValues_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get contour values for isosurface blending mode.
	/// Do not affect other blending modes.
	/// </summary>
	public vtkContourValues GetIsoSurfaceValues()
	{
		vtkContourValues vtkContourValues2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetIsoSurfaceValues_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourValues2 = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourValues2.Register(null);
			}
		}
		return vtkContourValues2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetLabelColor_28(HandleRef pThis, int label, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the color transfer function for a label in the label map.
	/// </summary>
	public vtkColorTransferFunction GetLabelColor(int label)
	{
		vtkColorTransferFunction vtkColorTransferFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetLabelColor_28(GetCppThis(), label, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorTransferFunction2 = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorTransferFunction2.Register(null);
			}
		}
		return vtkColorTransferFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetLabelGradientOpacity_29(HandleRef pThis, int label, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the gradient opacity function for a label in the label map.
	/// </summary>
	public vtkPiecewiseFunction GetLabelGradientOpacity(int label)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetLabelGradientOpacity_29(GetCppThis(), label, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetLabelScalarOpacity_30(HandleRef pThis, int label, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the opacity transfer function for a label in the label map.
	/// </summary>
	public vtkPiecewiseFunction GetLabelScalarOpacity(int label)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetLabelScalarOpacity_30(GetCppThis(), label, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVolumeProperty_GetMTime_31(HandleRef pThis);

	/// <summary>
	/// Get the modified time for this object (or the properties registered
	/// with this object).
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkVolumeProperty_GetMTime_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeProperty_GetNumberOfGenerationsFromBase_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolumeProperty_GetNumberOfGenerationsFromBase_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeProperty_GetNumberOfGenerationsFromBaseType_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolumeProperty_GetNumberOfGenerationsFromBaseType_33(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVolumeProperty_GetNumberOfLabels_34(HandleRef pThis);

	/// <summary>
	/// Get the number of labels that are provided with transfer functions using
	/// either SetLabelColor, SetLabelScalarOpacity or SetLabelGradientOpacity.
	/// </summary>
	public ulong GetNumberOfLabels()
	{
		return vtkVolumeProperty_GetNumberOfLabels_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetRGBTransferFunction_35(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the RGB transfer function for the given component.
	/// If no transfer function has been set for this component, a default one
	/// is created and returned.
	/// </summary>
	public vtkColorTransferFunction GetRGBTransferFunction(int index)
	{
		vtkColorTransferFunction vtkColorTransferFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetRGBTransferFunction_35(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorTransferFunction2 = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorTransferFunction2.Register(null);
			}
		}
		return vtkColorTransferFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetRGBTransferFunction_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the RGB transfer function for the given component.
	/// If no transfer function has been set for this component, a default one
	/// is created and returned.
	/// </summary>
	public vtkColorTransferFunction GetRGBTransferFunction()
	{
		vtkColorTransferFunction vtkColorTransferFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetRGBTransferFunction_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorTransferFunction2 = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorTransferFunction2.Register(null);
			}
		}
		return vtkColorTransferFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetScalarOpacity_37(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the scalar opacity transfer function for the given component.
	/// If no transfer function has been set for this component, a default one
	/// is created and returned.
	/// </summary>
	public vtkPiecewiseFunction GetScalarOpacity(int index)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetScalarOpacity_37(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetScalarOpacity_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the scalar opacity transfer function for the given component.
	/// If no transfer function has been set for this component, a default one
	/// is created and returned.
	/// </summary>
	public vtkPiecewiseFunction GetScalarOpacity()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetScalarOpacity_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetScalarOpacityUnitDistance_39(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the unit distance on which the scalar opacity transfer function
	/// is defined. By default this is 1.0, meaning that over a distance of
	/// 1.0 units, a given opacity (from the transfer function) is accumulated.
	/// This is adjusted for the actual sampling distance during rendering.
	/// </summary>
	public double GetScalarOpacityUnitDistance(int index)
	{
		return vtkVolumeProperty_GetScalarOpacityUnitDistance_39(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetScalarOpacityUnitDistance_40(HandleRef pThis);

	/// <summary>
	/// Set/Get the unit distance on which the scalar opacity transfer function
	/// is defined. By default this is 1.0, meaning that over a distance of
	/// 1.0 units, a given opacity (from the transfer function) is accumulated.
	/// This is adjusted for the actual sampling distance during rendering.
	/// </summary>
	public double GetScalarOpacityUnitDistance()
	{
		return vtkVolumeProperty_GetScalarOpacityUnitDistance_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVolumeProperty_GetScatteringAnisotropy_41(HandleRef pThis);

	/// <summary>
	/// Get/Set the volume's scattering anisotropy.
	/// The model used is Henyey-Greenstein. The value should
	/// be between -1.0 (back-scattering) and 1.0 (forward-scattering),
	/// so the default value of 0.0 corresponds to an isotropic
	/// volume. For now, it is only used in vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetScatteringAnisotropy()
	{
		return vtkVolumeProperty_GetScatteringAnisotropy_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVolumeProperty_GetScatteringAnisotropyMaxValue_42(HandleRef pThis);

	/// <summary>
	/// Get/Set the volume's scattering anisotropy.
	/// The model used is Henyey-Greenstein. The value should
	/// be between -1.0 (back-scattering) and 1.0 (forward-scattering),
	/// so the default value of 0.0 corresponds to an isotropic
	/// volume. For now, it is only used in vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetScatteringAnisotropyMaxValue()
	{
		return vtkVolumeProperty_GetScatteringAnisotropyMaxValue_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkVolumeProperty_GetScatteringAnisotropyMinValue_43(HandleRef pThis);

	/// <summary>
	/// Get/Set the volume's scattering anisotropy.
	/// The model used is Henyey-Greenstein. The value should
	/// be between -1.0 (back-scattering) and 1.0 (forward-scattering),
	/// so the default value of 0.0 corresponds to an isotropic
	/// volume. For now, it is only used in vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual float GetScatteringAnisotropyMinValue()
	{
		return vtkVolumeProperty_GetScatteringAnisotropyMinValue_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetShade_44(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the shading of a volume. If shading is turned off, then
	/// the mapper for the volume will not perform shading calculations.
	/// If shading is turned on, the mapper may perform shading
	/// calculations - in some cases shading does not apply (for example,
	/// in a maximum intensity projection) and therefore shading will
	/// not be performed even if this flag is on. For a compositing type
	/// of mapper, turning shading off is generally the same as setting
	/// ambient=1, diffuse=0, specular=0. Shading can be independently
	/// turned on/off per component.
	///
	/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
	/// For minimum and maximum intensity blend modes, there is not necessarily one
	/// unique location along the ray through the volume where that minimum or
	/// maximum occurs. For average and additive blend modes, the value being
	/// visualized does not represent a location in the volume but rather a
	/// statistical measurement along the ray traversing through the volume, and
	/// hence shading is not applicable.
	/// \sa vtkVolumeMapper::BlendModes
	/// </summary>
	public int GetShade(int index)
	{
		return vtkVolumeProperty_GetShade_44(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetShade_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the shading of a volume. If shading is turned off, then
	/// the mapper for the volume will not perform shading calculations.
	/// If shading is turned on, the mapper may perform shading
	/// calculations - in some cases shading does not apply (for example,
	/// in a maximum intensity projection) and therefore shading will
	/// not be performed even if this flag is on. For a compositing type
	/// of mapper, turning shading off is generally the same as setting
	/// ambient=1, diffuse=0, specular=0. Shading can be independently
	/// turned on/off per component.
	///
	/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
	/// For minimum and maximum intensity blend modes, there is not necessarily one
	/// unique location along the ray through the volume where that minimum or
	/// maximum occurs. For average and additive blend modes, the value being
	/// visualized does not represent a location in the volume but rather a
	/// statistical measurement along the ray traversing through the volume, and
	/// hence shading is not applicable.
	/// \sa vtkVolumeMapper::BlendModes
	/// </summary>
	public int GetShade()
	{
		return vtkVolumeProperty_GetShade_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetSliceFunction_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the function used for slicing.
	/// Currently, only vtkPlane is supported.
	/// </summary>
	public virtual vtkImplicitFunction GetSliceFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetSliceFunction_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitFunction2 = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitFunction2.Register(null);
			}
		}
		return vtkImplicitFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetSpecular_47(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the specular lighting coefficient.
	/// </summary>
	public double GetSpecular(int index)
	{
		return vtkVolumeProperty_GetSpecular_47(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetSpecular_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular lighting coefficient.
	/// </summary>
	public double GetSpecular()
	{
		return vtkVolumeProperty_GetSpecular_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetSpecularPower_49(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the specular power.
	/// </summary>
	public double GetSpecularPower(int index)
	{
		return vtkVolumeProperty_GetSpecularPower_49(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVolumeProperty_GetSpecularPower_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the specular power.
	/// </summary>
	public double GetSpecularPower()
	{
		return vtkVolumeProperty_GetSpecularPower_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetStoredGradientOpacity_51(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public vtkPiecewiseFunction GetStoredGradientOpacity(int index)
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetStoredGradientOpacity_51(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetStoredGradientOpacity_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public vtkPiecewiseFunction GetStoredGradientOpacity()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetStoredGradientOpacity_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetTransferFunction2D_53(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a 2D transfer function. Volume mappers interpret the x-axis of
	/// of this transfer function as scalar value and the y-axis as gradient
	/// magnitude. The value at (X, Y) corresponds to the color and opacity
	/// for a salar value of X and a gradient magnitude of Y.
	/// </summary>
	public vtkImageData GetTransferFunction2D(int index)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetTransferFunction2D_53(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_GetTransferFunction2D_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a 2D transfer function. Volume mappers interpret the x-axis of
	/// of this transfer function as scalar value and the y-axis as gradient
	/// magnitude. The value at (X, Y) corresponds to the color and opacity
	/// for a salar value of X and a gradient magnitude of Y.
	/// </summary>
	public vtkImageData GetTransferFunction2D()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_GetTransferFunction2D_54(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetTransferFunctionMode_55(HandleRef pThis);

	/// <summary>
	/// Color-opacity transfer function mode. TF_1D is its default value.
	///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
	///  and gradient mag. opacity.
	///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
	///  opacity.
	/// </summary>
	public virtual int GetTransferFunctionMode()
	{
		return vtkVolumeProperty_GetTransferFunctionMode_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetTransferFunctionModeMaxValue_56(HandleRef pThis);

	/// <summary>
	/// Color-opacity transfer function mode. TF_1D is its default value.
	///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
	///  and gradient mag. opacity.
	///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
	///  opacity.
	/// </summary>
	public virtual int GetTransferFunctionModeMaxValue()
	{
		return vtkVolumeProperty_GetTransferFunctionModeMaxValue_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetTransferFunctionModeMinValue_57(HandleRef pThis);

	/// <summary>
	/// Color-opacity transfer function mode. TF_1D is its default value.
	///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
	///  and gradient mag. opacity.
	///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
	///  opacity.
	/// </summary>
	public virtual int GetTransferFunctionModeMinValue()
	{
		return vtkVolumeProperty_GetTransferFunctionModeMinValue_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_GetUseClippedVoxelIntensity_58(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to use a fixed intensity value for voxels in the clipped
	/// space for gradient calculations. When UseClippedVoxelIntensity is
	/// enabled, the ClippedVoxelIntensity value will be used as intensity of
	/// clipped voxels. By default, this is false.
	///
	/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
	/// \sa SetClippedVoxelIntensity
	/// </summary>
	public virtual int GetUseClippedVoxelIntensity()
	{
		return vtkVolumeProperty_GetUseClippedVoxelIntensity_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVolumeProperty_HasGradientOpacity_59(HandleRef pThis, int index);

	/// <summary>
	/// Check whether or not we have the gradient opacity. Checking
	/// gradient opacity via GetDisableGradientOpacity or GetGradientOpacity
	/// will not work as in the former case,  GetDisableGradientOpacity returns
	/// false by default and in the later case, a default gradient opacity will be created.
	/// </summary>
	public bool HasGradientOpacity(int index)
	{
		return (vtkVolumeProperty_HasGradientOpacity_59(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVolumeProperty_HasLabelGradientOpacity_60(HandleRef pThis);

	/// <summary>
	/// Check whether or not we have the gradient opacity. Checking
	/// gradient opacity via GetDisableGradientOpacity or GetGradientOpacity
	/// will not work as in the former case,  GetDisableGradientOpacity returns
	/// false by default and in the later case, a default gradient opacity will be created.
	/// </summary>
	public bool HasLabelGradientOpacity()
	{
		return (vtkVolumeProperty_HasLabelGradientOpacity_60(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_IndependentComponentsOff_61(HandleRef pThis);

	/// <summary>
	/// Does the data have independent components, or do some define color
	/// only? If IndependentComponents is On (the default) then each component
	/// will be independently passed through a lookup table to determine RGBA,
	/// shaded. Some volume Mappers can handle 1 to 4 component
	/// unsigned char or unsigned short data (see each mapper header file to
	/// determine functionality). If IndependentComponents is Off, then you
	/// must have either 2 or 4 component data. For 2 component data, the
	/// first is passed through the first color transfer function and the
	/// second component is passed through the first scalar opacity (and
	/// gradient opacity) transfer function.
	/// Normals will be generated off of the second component. When using gradient
	/// based opacity modulation, the gradients are computed off of the
	/// second component. For 4 component
	/// data, the first three will directly represent RGB (no lookup table).
	/// The fourth component will be passed through the first scalar opacity
	/// transfer function for opacity and first gradient opacity transfer function
	/// for gradient based opacity modulation. Normals will be generated from the
	/// fourth component. When using gradient based opacity modulation, the
	/// gradients are computed off of the fourth component.
	/// </summary>
	public virtual void IndependentComponentsOff()
	{
		vtkVolumeProperty_IndependentComponentsOff_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_IndependentComponentsOn_62(HandleRef pThis);

	/// <summary>
	/// Does the data have independent components, or do some define color
	/// only? If IndependentComponents is On (the default) then each component
	/// will be independently passed through a lookup table to determine RGBA,
	/// shaded. Some volume Mappers can handle 1 to 4 component
	/// unsigned char or unsigned short data (see each mapper header file to
	/// determine functionality). If IndependentComponents is Off, then you
	/// must have either 2 or 4 component data. For 2 component data, the
	/// first is passed through the first color transfer function and the
	/// second component is passed through the first scalar opacity (and
	/// gradient opacity) transfer function.
	/// Normals will be generated off of the second component. When using gradient
	/// based opacity modulation, the gradients are computed off of the
	/// second component. For 4 component
	/// data, the first three will directly represent RGB (no lookup table).
	/// The fourth component will be passed through the first scalar opacity
	/// transfer function for opacity and first gradient opacity transfer function
	/// for gradient based opacity modulation. Normals will be generated from the
	/// fourth component. When using gradient based opacity modulation, the
	/// gradients are computed off of the fourth component.
	/// </summary>
	public virtual void IndependentComponentsOn()
	{
		vtkVolumeProperty_IndependentComponentsOn_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_IsA_63(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolumeProperty_IsA_63(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeProperty_IsTypeOf_64(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolumeProperty_IsTypeOf_64(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolumeProperty NewInstance()
	{
		vtkVolumeProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_NewInstance_66(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeProperty_SafeDownCast_67(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeProperty SafeDownCast(vtkObjectBase o)
	{
		vtkVolumeProperty vtkVolumeProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeProperty_SafeDownCast_67(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeProperty2 = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeProperty2.Register(null);
			}
		}
		return vtkVolumeProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetAmbient_68(HandleRef pThis, int index, double value);

	/// <summary>
	/// Set/Get the ambient lighting coefficient.
	/// </summary>
	public void SetAmbient(int index, double value)
	{
		vtkVolumeProperty_SetAmbient_68(GetCppThis(), index, value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetAmbient_69(HandleRef pThis, double value);

	/// <summary>
	/// Set/Get the ambient lighting coefficient.
	/// </summary>
	public void SetAmbient(double value)
	{
		vtkVolumeProperty_SetAmbient_69(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetClippedVoxelIntensity_70(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the intensity value for voxels in the clipped space for gradient
	/// computations (for shading and gradient based opacity modulation).
	/// By default, this is set to VTK_DOUBLE_MIN.
	///
	/// \note This value is only used when UseClippedVoxelIntensity is true.
	/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
	/// \sa SetUseClippedVoxelIntensity
	/// </summary>
	public virtual void SetClippedVoxelIntensity(double _arg)
	{
		vtkVolumeProperty_SetClippedVoxelIntensity_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetColor_71(HandleRef pThis, int index, HandleRef function);

	/// <summary>
	/// Set the color of a volume to a gray level transfer function
	/// for the component indicated by index. This will set the
	/// color channels for this component to 1.
	/// </summary>
	public void SetColor(int index, vtkPiecewiseFunction function)
	{
		vtkVolumeProperty_SetColor_71(GetCppThis(), index, function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetColor_72(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set the color of a volume to a gray level transfer function
	/// for the component indicated by index. This will set the
	/// color channels for this component to 1.
	/// </summary>
	public void SetColor(vtkPiecewiseFunction function)
	{
		vtkVolumeProperty_SetColor_72(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetColor_73(HandleRef pThis, int index, HandleRef function);

	/// <summary>
	/// Set the color of a volume to an RGB transfer function
	/// for the component indicated by index. This will set the
	/// color channels for this component to 3.
	/// This will also recompute the color channels
	/// </summary>
	public void SetColor(int index, vtkColorTransferFunction function)
	{
		vtkVolumeProperty_SetColor_73(GetCppThis(), index, function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetColor_74(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set the color of a volume to an RGB transfer function
	/// for the component indicated by index. This will set the
	/// color channels for this component to 3.
	/// This will also recompute the color channels
	/// </summary>
	public void SetColor(vtkColorTransferFunction function)
	{
		vtkVolumeProperty_SetColor_74(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetComponentWeight_75(HandleRef pThis, int index, double value);

	/// <summary>
	/// Set/Get the scalar component weights.
	/// Clamped between the range of (0.0, 1.0)
	/// </summary>
	public virtual void SetComponentWeight(int index, double value)
	{
		vtkVolumeProperty_SetComponentWeight_75(GetCppThis(), index, value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetDiffuse_76(HandleRef pThis, int index, double value);

	/// <summary>
	/// Set/Get the diffuse lighting coefficient.
	/// </summary>
	public void SetDiffuse(int index, double value)
	{
		vtkVolumeProperty_SetDiffuse_76(GetCppThis(), index, value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetDiffuse_77(HandleRef pThis, double value);

	/// <summary>
	/// Set/Get the diffuse lighting coefficient.
	/// </summary>
	public void SetDiffuse(double value)
	{
		vtkVolumeProperty_SetDiffuse_77(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetDisableGradientOpacity_78(HandleRef pThis, int index, int value);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public virtual void SetDisableGradientOpacity(int index, int value)
	{
		vtkVolumeProperty_SetDisableGradientOpacity_78(GetCppThis(), index, value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetDisableGradientOpacity_79(HandleRef pThis, int value);

	/// <summary>
	/// Enable/Disable the gradient opacity function for the given component.
	/// If set to true, any call to GetGradientOpacity() will return a default
	/// function for this component. Note that the gradient opacity function is
	/// still stored, it is not set or reset and can be retrieved using
	/// GetStoredGradientOpacity().
	/// </summary>
	public virtual void SetDisableGradientOpacity(int value)
	{
		vtkVolumeProperty_SetDisableGradientOpacity_79(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetGradientOpacity_80(HandleRef pThis, int index, HandleRef function);

	/// <summary>
	/// Set the opacity of a volume to an opacity transfer function based
	/// on gradient magnitude for the given component.
	/// </summary>
	public void SetGradientOpacity(int index, vtkPiecewiseFunction function)
	{
		vtkVolumeProperty_SetGradientOpacity_80(GetCppThis(), index, function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetGradientOpacity_81(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set the opacity of a volume to an opacity transfer function based
	/// on gradient magnitude for the given component.
	/// </summary>
	public void SetGradientOpacity(vtkPiecewiseFunction function)
	{
		vtkVolumeProperty_SetGradientOpacity_81(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetIndependentComponents_82(HandleRef pThis, int _arg);

	/// <summary>
	/// Does the data have independent components, or do some define color
	/// only? If IndependentComponents is On (the default) then each component
	/// will be independently passed through a lookup table to determine RGBA,
	/// shaded. Some volume Mappers can handle 1 to 4 component
	/// unsigned char or unsigned short data (see each mapper header file to
	/// determine functionality). If IndependentComponents is Off, then you
	/// must have either 2 or 4 component data. For 2 component data, the
	/// first is passed through the first color transfer function and the
	/// second component is passed through the first scalar opacity (and
	/// gradient opacity) transfer function.
	/// Normals will be generated off of the second component. When using gradient
	/// based opacity modulation, the gradients are computed off of the
	/// second component. For 4 component
	/// data, the first three will directly represent RGB (no lookup table).
	/// The fourth component will be passed through the first scalar opacity
	/// transfer function for opacity and first gradient opacity transfer function
	/// for gradient based opacity modulation. Normals will be generated from the
	/// fourth component. When using gradient based opacity modulation, the
	/// gradients are computed off of the fourth component.
	/// </summary>
	public virtual void SetIndependentComponents(int _arg)
	{
		vtkVolumeProperty_SetIndependentComponents_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetInterpolationType_83(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the interpolation type for sampling a volume. Initial value is
	/// VTK_NEAREST_INTERPOLATION.
	/// </summary>
	public virtual void SetInterpolationType(int _arg)
	{
		vtkVolumeProperty_SetInterpolationType_83(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetInterpolationTypeToLinear_84(HandleRef pThis);

	/// <summary>
	/// Set the interpolation type for sampling a volume. Initial value is
	/// VTK_NEAREST_INTERPOLATION.
	/// </summary>
	public void SetInterpolationTypeToLinear()
	{
		vtkVolumeProperty_SetInterpolationTypeToLinear_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetInterpolationTypeToNearest_85(HandleRef pThis);

	/// <summary>
	/// Set the interpolation type for sampling a volume. Initial value is
	/// VTK_NEAREST_INTERPOLATION.
	/// </summary>
	public void SetInterpolationTypeToNearest()
	{
		vtkVolumeProperty_SetInterpolationTypeToNearest_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetLabelColor_86(HandleRef pThis, int label, HandleRef function);

	/// <summary>
	/// Set/Get the color transfer function for a label in the label map.
	/// </summary>
	public void SetLabelColor(int label, vtkColorTransferFunction function)
	{
		vtkVolumeProperty_SetLabelColor_86(GetCppThis(), label, function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetLabelGradientOpacity_87(HandleRef pThis, int label, HandleRef function);

	/// <summary>
	/// Set/Get the gradient opacity function for a label in the label map.
	/// </summary>
	public void SetLabelGradientOpacity(int label, vtkPiecewiseFunction function)
	{
		vtkVolumeProperty_SetLabelGradientOpacity_87(GetCppThis(), label, function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetLabelScalarOpacity_88(HandleRef pThis, int label, HandleRef function);

	/// <summary>
	/// Set/Get the opacity transfer function for a label in the label map.
	/// </summary>
	public void SetLabelScalarOpacity(int label, vtkPiecewiseFunction function)
	{
		vtkVolumeProperty_SetLabelScalarOpacity_88(GetCppThis(), label, function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetScalarOpacity_89(HandleRef pThis, int index, HandleRef function);

	/// <summary>
	/// Set the opacity of a volume to an opacity transfer function based
	/// on scalar value for the component indicated by index.
	/// </summary>
	public void SetScalarOpacity(int index, vtkPiecewiseFunction function)
	{
		vtkVolumeProperty_SetScalarOpacity_89(GetCppThis(), index, function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetScalarOpacity_90(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set the opacity of a volume to an opacity transfer function based
	/// on scalar value for the component indicated by index.
	/// </summary>
	public void SetScalarOpacity(vtkPiecewiseFunction function)
	{
		vtkVolumeProperty_SetScalarOpacity_90(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetScalarOpacityUnitDistance_91(HandleRef pThis, int index, double distance);

	/// <summary>
	/// Set/Get the unit distance on which the scalar opacity transfer function
	/// is defined. By default this is 1.0, meaning that over a distance of
	/// 1.0 units, a given opacity (from the transfer function) is accumulated.
	/// This is adjusted for the actual sampling distance during rendering.
	/// </summary>
	public void SetScalarOpacityUnitDistance(int index, double distance)
	{
		vtkVolumeProperty_SetScalarOpacityUnitDistance_91(GetCppThis(), index, distance);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetScalarOpacityUnitDistance_92(HandleRef pThis, double distance);

	/// <summary>
	/// Set/Get the unit distance on which the scalar opacity transfer function
	/// is defined. By default this is 1.0, meaning that over a distance of
	/// 1.0 units, a given opacity (from the transfer function) is accumulated.
	/// This is adjusted for the actual sampling distance during rendering.
	/// </summary>
	public void SetScalarOpacityUnitDistance(double distance)
	{
		vtkVolumeProperty_SetScalarOpacityUnitDistance_92(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetScatteringAnisotropy_93(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the volume's scattering anisotropy.
	/// The model used is Henyey-Greenstein. The value should
	/// be between -1.0 (back-scattering) and 1.0 (forward-scattering),
	/// so the default value of 0.0 corresponds to an isotropic
	/// volume. For now, it is only used in vtkGPUVolumeRayCastMapper.
	/// </summary>
	public virtual void SetScatteringAnisotropy(float _arg)
	{
		vtkVolumeProperty_SetScatteringAnisotropy_93(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetShade_94(HandleRef pThis, int index, int value);

	/// <summary>
	/// Set/Get the shading of a volume. If shading is turned off, then
	/// the mapper for the volume will not perform shading calculations.
	/// If shading is turned on, the mapper may perform shading
	/// calculations - in some cases shading does not apply (for example,
	/// in a maximum intensity projection) and therefore shading will
	/// not be performed even if this flag is on. For a compositing type
	/// of mapper, turning shading off is generally the same as setting
	/// ambient=1, diffuse=0, specular=0. Shading can be independently
	/// turned on/off per component.
	///
	/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
	/// For minimum and maximum intensity blend modes, there is not necessarily one
	/// unique location along the ray through the volume where that minimum or
	/// maximum occurs. For average and additive blend modes, the value being
	/// visualized does not represent a location in the volume but rather a
	/// statistical measurement along the ray traversing through the volume, and
	/// hence shading is not applicable.
	/// \sa vtkVolumeMapper::BlendModes
	/// </summary>
	public void SetShade(int index, int value)
	{
		vtkVolumeProperty_SetShade_94(GetCppThis(), index, value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetShade_95(HandleRef pThis, int value);

	/// <summary>
	/// Set/Get the shading of a volume. If shading is turned off, then
	/// the mapper for the volume will not perform shading calculations.
	/// If shading is turned on, the mapper may perform shading
	/// calculations - in some cases shading does not apply (for example,
	/// in a maximum intensity projection) and therefore shading will
	/// not be performed even if this flag is on. For a compositing type
	/// of mapper, turning shading off is generally the same as setting
	/// ambient=1, diffuse=0, specular=0. Shading can be independently
	/// turned on/off per component.
	///
	/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
	/// For minimum and maximum intensity blend modes, there is not necessarily one
	/// unique location along the ray through the volume where that minimum or
	/// maximum occurs. For average and additive blend modes, the value being
	/// visualized does not represent a location in the volume but rather a
	/// statistical measurement along the ray traversing through the volume, and
	/// hence shading is not applicable.
	/// \sa vtkVolumeMapper::BlendModes
	/// </summary>
	public void SetShade(int value)
	{
		vtkVolumeProperty_SetShade_95(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetSliceFunction_96(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Get/Set the function used for slicing.
	/// Currently, only vtkPlane is supported.
	/// </summary>
	public virtual void SetSliceFunction(vtkImplicitFunction _arg)
	{
		vtkVolumeProperty_SetSliceFunction_96(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetSpecular_97(HandleRef pThis, int index, double value);

	/// <summary>
	/// Set/Get the specular lighting coefficient.
	/// </summary>
	public void SetSpecular(int index, double value)
	{
		vtkVolumeProperty_SetSpecular_97(GetCppThis(), index, value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetSpecular_98(HandleRef pThis, double value);

	/// <summary>
	/// Set/Get the specular lighting coefficient.
	/// </summary>
	public void SetSpecular(double value)
	{
		vtkVolumeProperty_SetSpecular_98(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetSpecularPower_99(HandleRef pThis, int index, double value);

	/// <summary>
	/// Set/Get the specular power.
	/// </summary>
	public void SetSpecularPower(int index, double value)
	{
		vtkVolumeProperty_SetSpecularPower_99(GetCppThis(), index, value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetSpecularPower_100(HandleRef pThis, double value);

	/// <summary>
	/// Set/Get the specular power.
	/// </summary>
	public void SetSpecularPower(double value)
	{
		vtkVolumeProperty_SetSpecularPower_100(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetTransferFunction2D_101(HandleRef pThis, int index, HandleRef function);

	/// <summary>
	/// Set/Get a 2D transfer function. Volume mappers interpret the x-axis of
	/// of this transfer function as scalar value and the y-axis as gradient
	/// magnitude. The value at (X, Y) corresponds to the color and opacity
	/// for a salar value of X and a gradient magnitude of Y.
	/// </summary>
	public void SetTransferFunction2D(int index, vtkImageData function)
	{
		vtkVolumeProperty_SetTransferFunction2D_101(GetCppThis(), index, function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetTransferFunction2D_102(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set/Get a 2D transfer function. Volume mappers interpret the x-axis of
	/// of this transfer function as scalar value and the y-axis as gradient
	/// magnitude. The value at (X, Y) corresponds to the color and opacity
	/// for a salar value of X and a gradient magnitude of Y.
	/// </summary>
	public void SetTransferFunction2D(vtkImageData function)
	{
		vtkVolumeProperty_SetTransferFunction2D_102(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetTransferFunctionMode_103(HandleRef pThis, int _arg);

	/// <summary>
	/// Color-opacity transfer function mode. TF_1D is its default value.
	///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
	///  and gradient mag. opacity.
	///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
	///  opacity.
	/// </summary>
	public virtual void SetTransferFunctionMode(int _arg)
	{
		vtkVolumeProperty_SetTransferFunctionMode_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetTransferFunctionModeTo1D_104(HandleRef pThis);

	/// <summary>
	/// Color-opacity transfer function mode. TF_1D is its default value.
	///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
	///  and gradient mag. opacity.
	///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
	///  opacity.
	/// </summary>
	public void SetTransferFunctionModeTo1D()
	{
		vtkVolumeProperty_SetTransferFunctionModeTo1D_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetTransferFunctionModeTo2D_105(HandleRef pThis);

	/// <summary>
	/// Color-opacity transfer function mode. TF_1D is its default value.
	///  - TF_1D Mappers will use 3 separate 1D functions for color, scalar opacity
	///  and gradient mag. opacity.
	///  - TF_2D Mappers will use a single 2D function for color and scalar/gradient mag.
	///  opacity.
	/// </summary>
	public void SetTransferFunctionModeTo2D()
	{
		vtkVolumeProperty_SetTransferFunctionModeTo2D_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_SetUseClippedVoxelIntensity_106(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether to use a fixed intensity value for voxels in the clipped
	/// space for gradient calculations. When UseClippedVoxelIntensity is
	/// enabled, the ClippedVoxelIntensity value will be used as intensity of
	/// clipped voxels. By default, this is false.
	///
	/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
	/// \sa SetClippedVoxelIntensity
	/// </summary>
	public virtual void SetUseClippedVoxelIntensity(int _arg)
	{
		vtkVolumeProperty_SetUseClippedVoxelIntensity_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_ShadeOff_107(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the shading of a volume. If shading is turned off, then
	/// the mapper for the volume will not perform shading calculations.
	/// If shading is turned on, the mapper may perform shading
	/// calculations - in some cases shading does not apply (for example,
	/// in a maximum intensity projection) and therefore shading will
	/// not be performed even if this flag is on. For a compositing type
	/// of mapper, turning shading off is generally the same as setting
	/// ambient=1, diffuse=0, specular=0. Shading can be independently
	/// turned on/off per component.
	///
	/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
	/// For minimum and maximum intensity blend modes, there is not necessarily one
	/// unique location along the ray through the volume where that minimum or
	/// maximum occurs. For average and additive blend modes, the value being
	/// visualized does not represent a location in the volume but rather a
	/// statistical measurement along the ray traversing through the volume, and
	/// hence shading is not applicable.
	/// \sa vtkVolumeMapper::BlendModes
	/// </summary>
	public void ShadeOff(int index)
	{
		vtkVolumeProperty_ShadeOff_107(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_ShadeOff_108(HandleRef pThis);

	/// <summary>
	/// Set/Get the shading of a volume. If shading is turned off, then
	/// the mapper for the volume will not perform shading calculations.
	/// If shading is turned on, the mapper may perform shading
	/// calculations - in some cases shading does not apply (for example,
	/// in a maximum intensity projection) and therefore shading will
	/// not be performed even if this flag is on. For a compositing type
	/// of mapper, turning shading off is generally the same as setting
	/// ambient=1, diffuse=0, specular=0. Shading can be independently
	/// turned on/off per component.
	///
	/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
	/// For minimum and maximum intensity blend modes, there is not necessarily one
	/// unique location along the ray through the volume where that minimum or
	/// maximum occurs. For average and additive blend modes, the value being
	/// visualized does not represent a location in the volume but rather a
	/// statistical measurement along the ray traversing through the volume, and
	/// hence shading is not applicable.
	/// \sa vtkVolumeMapper::BlendModes
	/// </summary>
	public void ShadeOff()
	{
		vtkVolumeProperty_ShadeOff_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_ShadeOn_109(HandleRef pThis, int index);

	/// <summary>
	/// Set/Get the shading of a volume. If shading is turned off, then
	/// the mapper for the volume will not perform shading calculations.
	/// If shading is turned on, the mapper may perform shading
	/// calculations - in some cases shading does not apply (for example,
	/// in a maximum intensity projection) and therefore shading will
	/// not be performed even if this flag is on. For a compositing type
	/// of mapper, turning shading off is generally the same as setting
	/// ambient=1, diffuse=0, specular=0. Shading can be independently
	/// turned on/off per component.
	///
	/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
	/// For minimum and maximum intensity blend modes, there is not necessarily one
	/// unique location along the ray through the volume where that minimum or
	/// maximum occurs. For average and additive blend modes, the value being
	/// visualized does not represent a location in the volume but rather a
	/// statistical measurement along the ray traversing through the volume, and
	/// hence shading is not applicable.
	/// \sa vtkVolumeMapper::BlendModes
	/// </summary>
	public void ShadeOn(int index)
	{
		vtkVolumeProperty_ShadeOn_109(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_ShadeOn_110(HandleRef pThis);

	/// <summary>
	/// Set/Get the shading of a volume. If shading is turned off, then
	/// the mapper for the volume will not perform shading calculations.
	/// If shading is turned on, the mapper may perform shading
	/// calculations - in some cases shading does not apply (for example,
	/// in a maximum intensity projection) and therefore shading will
	/// not be performed even if this flag is on. For a compositing type
	/// of mapper, turning shading off is generally the same as setting
	/// ambient=1, diffuse=0, specular=0. Shading can be independently
	/// turned on/off per component.
	///
	/// \note Shading is \b only supported for vtkVolumeMapper::COMPOSITE_BLEND.
	/// For minimum and maximum intensity blend modes, there is not necessarily one
	/// unique location along the ray through the volume where that minimum or
	/// maximum occurs. For average and additive blend modes, the value being
	/// visualized does not represent a location in the volume but rather a
	/// statistical measurement along the ray traversing through the volume, and
	/// hence shading is not applicable.
	/// \sa vtkVolumeMapper::BlendModes
	/// </summary>
	public void ShadeOn()
	{
		vtkVolumeProperty_ShadeOn_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_UpdateMTimes_111(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// UpdateMTimes performs a Modified() on all TimeStamps.
	/// This is used by vtkVolume when the property is set, so
	/// that any other object that might have been caching
	/// information for the property will rebuild.
	/// </summary>
	public void UpdateMTimes()
	{
		vtkVolumeProperty_UpdateMTimes_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_UseClippedVoxelIntensityOff_112(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to use a fixed intensity value for voxels in the clipped
	/// space for gradient calculations. When UseClippedVoxelIntensity is
	/// enabled, the ClippedVoxelIntensity value will be used as intensity of
	/// clipped voxels. By default, this is false.
	///
	/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
	/// \sa SetClippedVoxelIntensity
	/// </summary>
	public virtual void UseClippedVoxelIntensityOff()
	{
		vtkVolumeProperty_UseClippedVoxelIntensityOff_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeProperty_UseClippedVoxelIntensityOn_113(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to use a fixed intensity value for voxels in the clipped
	/// space for gradient calculations. When UseClippedVoxelIntensity is
	/// enabled, the ClippedVoxelIntensity value will be used as intensity of
	/// clipped voxels. By default, this is false.
	///
	/// \note This property is only used by the vtkGPUVolumeRayCastMapper for now.
	/// \sa SetClippedVoxelIntensity
	/// </summary>
	public virtual void UseClippedVoxelIntensityOn()
	{
		vtkVolumeProperty_UseClippedVoxelIntensityOn_113(GetCppThis());
	}
}
