using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDiscretizableColorTransferFunction
/// </summary>
/// <remarks>
///    a combination of
/// vtkColorTransferFunction and vtkLookupTable.
///
/// This is a cross between a vtkColorTransferFunction and a vtkLookupTable
/// selectively combining the functionality of both. This class is a
/// vtkColorTransferFunction allowing users to specify the RGB control points
/// that control the color transfer function. At the same time, by setting
/// \a Discretize to 1 (true), one can force the transfer function to only have
/// \a NumberOfValues discrete colors.
///
/// When \a IndexedLookup is true, this class behaves differently. The annotated
/// values are considered to the be only valid values for which entries in the
/// color table should be returned. The colors for annotated values are those
/// specified using \a AddIndexedColors. Typically, there must be at least as many
/// indexed colors specified as the annotations. For backwards compatibility, if
/// no indexed-colors are specified, the colors in the lookup \a Table are assigned
/// to annotated values by taking the modulus of their index in the list
/// of annotations. If a scalar value is not present in \a AnnotatedValues,
/// then \a NanColor will be used.
///
/// One can set a scalar opacity function to map scalars to color types handling
/// transparency (VTK_RGBA, VTK_LUMINANCE_ALPHA). Opacity mapping is off by
/// default. Call EnableOpacityMappingOn() to handle mapping of alpha values.
///
/// NOTE: One must call Build() after making any changes to the points
/// in the ColorTransferFunction to ensure that the discrete and non-discrete
/// versions match up.
/// </remarks>
public class vtkDiscretizableColorTransferFunction : vtkColorTransferFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDiscretizableColorTransferFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDiscretizableColorTransferFunction()
	{
		MRClassNameKey = "class vtkDiscretizableColorTransferFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscretizableColorTransferFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDiscretizableColorTransferFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscretizableColorTransferFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDiscretizableColorTransferFunction New()
	{
		vtkDiscretizableColorTransferFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscretizableColorTransferFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDiscretizableColorTransferFunction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDiscretizableColorTransferFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDiscretizableColorTransferFunction_Build_01(HandleRef pThis);

	/// <summary>
	/// Generate discretized lookup table, if applicable.
	/// This method must be called after changes to the ColorTransferFunction
	/// otherwise the discretized version will be inconsistent with the
	/// non-discretized one.
	/// </summary>
	public override void Build()
	{
		vtkDiscretizableColorTransferFunction_Build_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_DiscretizeOff_02(HandleRef pThis);

	/// <summary>
	/// Set if the values are to be mapped after discretization. The
	/// number of discrete values is set by using SetNumberOfValues().
	/// Not set by default, i.e. color value is determined by
	/// interpolating at the scalar value.
	/// </summary>
	public virtual void DiscretizeOff()
	{
		vtkDiscretizableColorTransferFunction_DiscretizeOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_DiscretizeOn_03(HandleRef pThis);

	/// <summary>
	/// Set if the values are to be mapped after discretization. The
	/// number of discrete values is set by using SetNumberOfValues().
	/// Not set by default, i.e. color value is determined by
	/// interpolating at the scalar value.
	/// </summary>
	public virtual void DiscretizeOn()
	{
		vtkDiscretizableColorTransferFunction_DiscretizeOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_EnableOpacityMappingOff_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable the usage of the scalar opacity function.
	/// </summary>
	public virtual void EnableOpacityMappingOff()
	{
		vtkDiscretizableColorTransferFunction_EnableOpacityMappingOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_EnableOpacityMappingOn_05(HandleRef pThis);

	/// <summary>
	/// Enable/disable the usage of the scalar opacity function.
	/// </summary>
	public virtual void EnableOpacityMappingOn()
	{
		vtkDiscretizableColorTransferFunction_EnableOpacityMappingOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_GetColor_06(HandleRef pThis, double v, IntPtr rgb);

	/// <summary>
	/// Map one value through the lookup table and return the color as
	/// an RGB array of doubles between 0 and 1.
	/// </summary>
	public override void GetColor(double v, IntPtr rgb)
	{
		vtkDiscretizableColorTransferFunction_GetColor_06(GetCppThis(), v, rgb);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscretizableColorTransferFunction_GetDiscretize_07(HandleRef pThis);

	/// <summary>
	/// Set if the values are to be mapped after discretization. The
	/// number of discrete values is set by using SetNumberOfValues().
	/// Not set by default, i.e. color value is determined by
	/// interpolating at the scalar value.
	/// </summary>
	public virtual int GetDiscretize()
	{
		return vtkDiscretizableColorTransferFunction_GetDiscretize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDiscretizableColorTransferFunction_GetEnableOpacityMapping_08(HandleRef pThis);

	/// <summary>
	/// Enable/disable the usage of the scalar opacity function.
	/// </summary>
	public virtual bool GetEnableOpacityMapping()
	{
		return (vtkDiscretizableColorTransferFunction_GetEnableOpacityMapping_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_GetIndexedColor_09(HandleRef pThis, long i, IntPtr rgba);

	/// <summary>
	/// Get the "indexed color" assigned to an index.
	///
	/// The index is used in \a IndexedLookup mode to assign colors to annotations (in the order
	/// the annotations were set).
	/// Subclasses must implement this and interpret how to treat the index.
	/// vtkLookupTable simply returns GetTableValue(\a index % \a this-&gt;GetNumberOfTableValues()).
	/// vtkColorTransferFunction returns the color associated with node \a index % \a this-&gt;GetSize().
	///
	/// Note that implementations *must* set the opacity (alpha) component of the color, even if they
	/// do not provide opacity values in their colormaps. In that case, alpha = 1 should be used.
	/// </summary>
	public override void GetIndexedColor(long i, IntPtr rgba)
	{
		vtkDiscretizableColorTransferFunction_GetIndexedColor_09(GetCppThis(), i, rgba);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDiscretizableColorTransferFunction_GetMTime_10(HandleRef pThis);

	/// <summary>
	/// Overridden to include the ScalarOpacityFunction's MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkDiscretizableColorTransferFunction_GetMTime_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfAvailableColors_11(HandleRef pThis);

	/// <summary>
	/// Get the number of available colors for mapping to.
	/// </summary>
	public override long GetNumberOfAvailableColors()
	{
		return vtkDiscretizableColorTransferFunction_GetNumberOfAvailableColors_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDiscretizableColorTransferFunction_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDiscretizableColorTransferFunction_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDiscretizableColorTransferFunction_GetNumberOfIndexedColors_14(HandleRef pThis);

	/// <summary>
	/// Set the number of indexed colors. These are used when IndexedLookup is
	/// true. If no indexed colors are specified, for backwards compatibility,
	/// this class reverts to using the RGBPoints for colors.
	/// </summary>
	public uint GetNumberOfIndexedColors()
	{
		return vtkDiscretizableColorTransferFunction_GetNumberOfIndexedColors_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfValues_15(HandleRef pThis);

	/// <summary>
	/// Set the number of values i.e. colors to be generated in the
	/// discrete lookup table. This has no effect if Discretize is off.
	/// The default is 256.
	/// </summary>
	public virtual long GetNumberOfValues()
	{
		return vtkDiscretizableColorTransferFunction_GetNumberOfValues_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDiscretizableColorTransferFunction_GetOpacity_16(HandleRef pThis, double v);

	/// <summary>
	/// Return the opacity of a given scalar.
	/// </summary>
	public override double GetOpacity(double v)
	{
		return vtkDiscretizableColorTransferFunction_GetOpacity_16(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscretizableColorTransferFunction_GetScalarOpacityFunction_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the opacity function to use.
	/// </summary>
	public virtual vtkPiecewiseFunction GetScalarOpacityFunction()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscretizableColorTransferFunction_GetScalarOpacityFunction_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDiscretizableColorTransferFunction_GetUseLogScale_18(HandleRef pThis);

	/// <summary>
	/// Get/Set if log scale must be used while mapping scalars
	/// to colors. The default is 0.
	/// </summary>
	public virtual int GetUseLogScale()
	{
		return vtkDiscretizableColorTransferFunction_GetUseLogScale_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscretizableColorTransferFunction_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDiscretizableColorTransferFunction_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscretizableColorTransferFunction_IsOpaque_20(HandleRef pThis);

	/// <summary>
	/// Returns the negation of \a EnableOpacityMapping.
	/// </summary>
	public override int IsOpaque()
	{
		return vtkDiscretizableColorTransferFunction_IsOpaque_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscretizableColorTransferFunction_IsOpaque_21(HandleRef pThis, HandleRef scalars, int colorMode, int component);

	/// <summary>
	/// Returns the negation of \a EnableOpacityMapping.
	/// </summary>
	public override int IsOpaque(vtkAbstractArray scalars, int colorMode, int component)
	{
		return vtkDiscretizableColorTransferFunction_IsOpaque_21(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), colorMode, component);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscretizableColorTransferFunction_IsOpaque_22(HandleRef pThis, HandleRef scalars, int colorMode, int component, HandleRef ghosts, byte ghostsToSkip);

	/// <summary>
	/// Returns the negation of \a EnableOpacityMapping.
	/// </summary>
	public override int IsOpaque(vtkAbstractArray scalars, int colorMode, int component, vtkUnsignedCharArray ghosts, byte ghostsToSkip)
	{
		return vtkDiscretizableColorTransferFunction_IsOpaque_22(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), colorMode, component, ghosts?.GetCppThis() ?? default(HandleRef), ghostsToSkip);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscretizableColorTransferFunction_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDiscretizableColorTransferFunction_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_MapScalarsThroughTable2_24(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

	/// <summary>
	/// Map a set of scalars through the lookup table.
	/// Overridden to map the opacity value. This internal method is inherited
	/// from vtkScalarsToColors and should never be called directly.
	/// </summary>
	public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
	{
		vtkDiscretizableColorTransferFunction_MapScalarsThroughTable2_24(GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscretizableColorTransferFunction_MapValue_25(HandleRef pThis, double v);

	/// <summary>
	/// Map one value through the lookup table and return a color defined
	/// as a RGBA unsigned char tuple (4 bytes).
	/// </summary>
	public override IntPtr MapValue(double v)
	{
		return vtkDiscretizableColorTransferFunction_MapValue_25(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscretizableColorTransferFunction_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDiscretizableColorTransferFunction NewInstance()
	{
		vtkDiscretizableColorTransferFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscretizableColorTransferFunction_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDiscretizableColorTransferFunction_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDiscretizableColorTransferFunction SafeDownCast(vtkObjectBase o)
	{
		vtkDiscretizableColorTransferFunction vtkDiscretizableColorTransferFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDiscretizableColorTransferFunction_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDiscretizableColorTransferFunction2 = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDiscretizableColorTransferFunction2.Register(null);
			}
		}
		return vtkDiscretizableColorTransferFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetAlpha_29(HandleRef pThis, double alpha);

	/// <summary>
	/// Specify an additional opacity (alpha) value to blend with. Values
	/// != 1 modify the resulting color consistent with the requested
	/// form of the output. This is typically used by an actor in order to
	/// blend its opacity.
	/// Overridden to pass the alpha to the internal vtkLookupTable.
	/// </summary>
	public override void SetAlpha(double alpha)
	{
		vtkDiscretizableColorTransferFunction_SetAlpha_29(GetCppThis(), alpha);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetDiscretize_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set if the values are to be mapped after discretization. The
	/// number of discrete values is set by using SetNumberOfValues().
	/// Not set by default, i.e. color value is determined by
	/// interpolating at the scalar value.
	/// </summary>
	public virtual void SetDiscretize(int _arg)
	{
		vtkDiscretizableColorTransferFunction_SetDiscretize_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetEnableOpacityMapping_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable the usage of the scalar opacity function.
	/// </summary>
	public virtual void SetEnableOpacityMapping(bool _arg)
	{
		vtkDiscretizableColorTransferFunction_SetEnableOpacityMapping_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetIndexedColor_32(HandleRef pThis, uint index, double r, double g, double b, double a);

	/// <summary>
	/// Add colors to use when \a IndexedLookup is true.
	/// \a SetIndexedColor() will automatically call
	/// SetNumberOfIndexedColors(index+1) if the current number of indexed colors
	/// is not sufficient for the specified index and all will be initialized to
	/// the RGBA/RGB values passed to this call.
	/// </summary>
	public void SetIndexedColor(uint index, double r, double g, double b, double a)
	{
		vtkDiscretizableColorTransferFunction_SetIndexedColor_32(GetCppThis(), index, r, g, b, a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetIndexedColorRGB_33(HandleRef pThis, uint index, IntPtr rgb);

	/// <summary>
	/// Add colors to use when \a IndexedLookup is true.
	/// \a SetIndexedColor() will automatically call
	/// SetNumberOfIndexedColors(index+1) if the current number of indexed colors
	/// is not sufficient for the specified index and all will be initialized to
	/// the RGBA/RGB values passed to this call.
	/// </summary>
	public void SetIndexedColorRGB(uint index, IntPtr rgb)
	{
		vtkDiscretizableColorTransferFunction_SetIndexedColorRGB_33(GetCppThis(), index, rgb);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetIndexedColorRGBA_34(HandleRef pThis, uint index, IntPtr rgba);

	/// <summary>
	/// Add colors to use when \a IndexedLookup is true.
	/// \a SetIndexedColor() will automatically call
	/// SetNumberOfIndexedColors(index+1) if the current number of indexed colors
	/// is not sufficient for the specified index and all will be initialized to
	/// the RGBA/RGB values passed to this call.
	/// </summary>
	public void SetIndexedColorRGBA(uint index, IntPtr rgba)
	{
		vtkDiscretizableColorTransferFunction_SetIndexedColorRGBA_34(GetCppThis(), index, rgba);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetNanColor_35(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the color to use when a NaN (not a number) is encountered.  This is an
	/// RGB 3-tuple color of doubles in the range [0, 1].
	/// Overridden to pass the NanColor to the internal vtkLookupTable.
	/// </summary>
	public override void SetNanColor(double r, double g, double b)
	{
		vtkDiscretizableColorTransferFunction_SetNanColor_35(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetNanColor_36(HandleRef pThis, IntPtr rgb);

	/// <summary>
	/// Set the color to use when a NaN (not a number) is encountered.  This is an
	/// RGB 3-tuple color of doubles in the range [0, 1].
	/// Overridden to pass the NanColor to the internal vtkLookupTable.
	/// </summary>
	public override void SetNanColor(IntPtr rgb)
	{
		vtkDiscretizableColorTransferFunction_SetNanColor_36(GetCppThis(), rgb);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetNanOpacity_37(HandleRef pThis, double a);

	/// <summary>
	/// Set the opacity to use when a NaN (not a number) is encountered.  This is an
	/// double in the range [0, 1].
	/// Overridden to pass the NanOpacity to the internal vtkLookupTable.
	/// </summary>
	public override void SetNanOpacity(double a)
	{
		vtkDiscretizableColorTransferFunction_SetNanOpacity_37(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetNumberOfIndexedColors_38(HandleRef pThis, uint count);

	/// <summary>
	/// Set the number of indexed colors. These are used when IndexedLookup is
	/// true. If no indexed colors are specified, for backwards compatibility,
	/// this class reverts to using the RGBPoints for colors.
	/// </summary>
	public void SetNumberOfIndexedColors(uint count)
	{
		vtkDiscretizableColorTransferFunction_SetNumberOfIndexedColors_38(GetCppThis(), count);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetNumberOfValues_39(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the number of values i.e. colors to be generated in the
	/// discrete lookup table. This has no effect if Discretize is off.
	/// The default is 256.
	/// </summary>
	public virtual void SetNumberOfValues(long _arg)
	{
		vtkDiscretizableColorTransferFunction_SetNumberOfValues_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetScalarOpacityFunction_40(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set/get the opacity function to use.
	/// </summary>
	public virtual void SetScalarOpacityFunction(vtkPiecewiseFunction function)
	{
		vtkDiscretizableColorTransferFunction_SetScalarOpacityFunction_40(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDiscretizableColorTransferFunction_SetUseLogScale_41(HandleRef pThis, int useLogScale);

	/// <summary>
	/// Get/Set if log scale must be used while mapping scalars
	/// to colors. The default is 0.
	/// </summary>
	public virtual void SetUseLogScale(int useLogScale)
	{
		vtkDiscretizableColorTransferFunction_SetUseLogScale_41(GetCppThis(), useLogScale);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDiscretizableColorTransferFunction_UsingLogScale_42(HandleRef pThis);

	/// <summary>
	/// This should return 1 if the subclass is using log scale for
	/// mapping scalars to colors.
	/// </summary>
	public override int UsingLogScale()
	{
		return vtkDiscretizableColorTransferFunction_UsingLogScale_42(GetCppThis());
	}
}
