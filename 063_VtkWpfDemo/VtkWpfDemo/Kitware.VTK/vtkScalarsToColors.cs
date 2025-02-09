using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkScalarsToColors
/// </summary>
/// <remarks>
///    Superclass for mapping scalar values to colors
///
/// vtkScalarsToColors is a general-purpose base class for objects that
/// convert scalars to colors. This include vtkLookupTable classes and
/// color transfer functions.  By itself, this class will simply rescale
/// the scalars.
///
/// The scalar-to-color mapping can be augmented with an additional
/// uniform alpha blend. This is used, for example, to blend a vtkActor's
/// opacity with the lookup table values.
///
/// Specific scalar values may be annotated with text strings that will
/// be included in color legends using \a SetAnnotations, \a SetAnnotation,
/// \a GetNumberOfAnnotatedValues, \a GetAnnotatedValue, \a GetAnnotation,
/// \a RemoveAnnotation, and \a ResetAnnotations.
///
/// This class also has a method for indicating that the set of
/// annotated values form a categorical color map; by setting \a
/// IndexedLookup to true, you indicate that the annotated values are
/// the only valid values for which entries in the color table should
/// be returned. In this mode, subclasses should then assign colors to
/// annotated values by taking the modulus of an annotated value's
/// index in the list of annotations with the number of colors in the
/// table.
///
/// </remarks>
/// <seealso>
///
/// vtkLookupTable vtkColorTransferFunction
/// </seealso>
public class vtkScalarsToColors : vtkObject
{
	/// <summary>
	/// Change mode that maps vectors by magnitude vs. component.
	/// If the mode is "RGBColors", then the vectors components are
	/// scaled to the range and passed directly as the colors.
	/// </summary>
	public enum VectorModes
	{
		/// <summary>enum member</summary>
		COMPONENT = 1,
		/// <summary>enum member</summary>
		MAGNITUDE = 0,
		/// <summary>enum member</summary>
		RGBCOLORS = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScalarsToColors";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScalarsToColors()
	{
		MRClassNameKey = "class vtkScalarsToColors";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarsToColors"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScalarsToColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScalarsToColors New()
	{
		vtkScalarsToColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkScalarsToColors()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkScalarsToColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_Build_01(HandleRef pThis);

	/// <summary>
	/// Perform any processing required (if any) before processing
	/// scalars. Default implementation does nothing.
	/// </summary>
	public virtual void Build()
	{
		vtkScalarsToColors_Build_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarsToColors_ColorToUChar_02(double t);

	/// <summary>
	/// Specializations of vtkScalarsToColors::ColorToUChar
	/// Converts from a color in a floating point type in range 0.0-1.0 to a uchar
	/// in range 0-255.
	/// </summary>
	public static byte ColorToUChar(double t)
	{
		return vtkScalarsToColors_ColorToUChar_02(t);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarsToColors_ColorToUChar_03(float t);

	/// <summary>
	/// Specializations of vtkScalarsToColors::ColorToUChar
	/// Converts from a color in a floating point type in range 0.0-1.0 to a uchar
	/// in range 0-255.
	/// </summary>
	public static byte ColorToUChar(float t)
	{
		return vtkScalarsToColors_ColorToUChar_03(t);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_DeepCopy_04(HandleRef pThis, HandleRef o);

	/// <summary>
	/// Copy the contents from another object.
	/// </summary>
	public virtual void DeepCopy(vtkScalarsToColors o)
	{
		vtkScalarsToColors_DeepCopy_04(GetCppThis(), o?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarsToColors_GetAlpha_05(HandleRef pThis);

	/// <summary>
	/// Specify an additional opacity (alpha) value to blend with. Values
	/// != 1 modify the resulting color consistent with the requested
	/// form of the output. This is typically used by an actor in order to
	/// blend its opacity. Value is clamped between 0 and 1.
	/// </summary>
	public virtual double GetAlpha()
	{
		return vtkScalarsToColors_GetAlpha_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_GetAnnotatedValue_06(HandleRef pThis, long idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the annotated value at a particular index in the list of annotations.
	/// </summary>
	public vtkVariant GetAnnotatedValue(long idx)
	{
		vtkVariant result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColors_GetAnnotatedValue_06(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColors_GetAnnotatedValueIndex_07(HandleRef pThis, HandleRef val);

	/// <summary>
	/// Return the index of the given value in the list of annotated values (or -1 if not present).
	/// </summary>
	public long GetAnnotatedValueIndex(vtkVariant val)
	{
		return vtkScalarsToColors_GetAnnotatedValueIndex_07(GetCppThis(), val?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColors_GetAnnotatedValueIndexInternal_08(HandleRef pThis, HandleRef val);

	/// <summary>
	/// Look up an index into the array of annotations given a
	/// value. Does no pointer checks. Returns -1 when \p val not
	/// present.
	/// </summary>
	public long GetAnnotatedValueIndexInternal(vtkVariant val)
	{
		return vtkScalarsToColors_GetAnnotatedValueIndexInternal_08(GetCppThis(), val?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_GetAnnotatedValues_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a list of discrete values, either
	/// as a categorical set of values (when IndexedLookup is true) or
	/// as a set of annotations to add to a scalar array (when IndexedLookup is false).
	/// The two arrays must both either be nullptr or of the same length or
	/// the call will be ignored.
	///
	/// Note that these arrays are deep copied rather than being used directly
	/// in order to support the use case where edits are made. If the
	/// \a values and \a annotations arrays were held by this class then each
	/// call to map scalar values to colors would require us to check the MTime
	/// of the arrays.
	/// </summary>
	public virtual vtkAbstractArray GetAnnotatedValues()
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColors_GetAnnotatedValues_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkScalarsToColors_GetAnnotation_10(HandleRef pThis, long idx);

	/// <summary>
	/// Return the annotation at a particular index in the list of annotations.
	/// </summary>
	public string GetAnnotation(long idx)
	{
		return vtkScalarsToColors_GetAnnotation_10(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_GetAnnotationColor_11(HandleRef pThis, HandleRef val, IntPtr rgba);

	/// <summary>
	/// Obtain the color associated with a particular annotated value (or NanColor if unmatched).
	/// </summary>
	public virtual void GetAnnotationColor(vtkVariant val, IntPtr rgba)
	{
		vtkScalarsToColors_GetAnnotationColor_11(GetCppThis(), val?.GetCppThis() ?? default(HandleRef), rgba);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_GetAnnotations_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a list of discrete values, either
	/// as a categorical set of values (when IndexedLookup is true) or
	/// as a set of annotations to add to a scalar array (when IndexedLookup is false).
	/// The two arrays must both either be nullptr or of the same length or
	/// the call will be ignored.
	///
	/// Note that these arrays are deep copied rather than being used directly
	/// in order to support the use case where edits are made. If the
	/// \a values and \a annotations arrays were held by this class then each
	/// call to map scalar values to colors would require us to check the MTime
	/// of the arrays.
	/// </summary>
	public virtual vtkStringArray GetAnnotations()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColors_GetAnnotations_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_GetColor_13(HandleRef pThis, double v, IntPtr rgb);

	/// <summary>
	/// Map one value through the lookup table and store the color as
	/// an RGB array of doubles between 0 and 1 in the \a rgb argument.
	/// </summary>
	public virtual void GetColor(double v, IntPtr rgb)
	{
		vtkScalarsToColors_GetColor_13(GetCppThis(), v, rgb);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_GetColor_14(HandleRef pThis, double v);

	/// <summary>
	/// Map one value through the lookup table and return the color as
	/// an RGB array of doubles between 0 and 1.
	/// </summary>
	public double[] GetColor(double v)
	{
		IntPtr intPtr = vtkScalarsToColors_GetColor_14(GetCppThis(), v);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_GetIndexedColor_15(HandleRef pThis, long i, IntPtr rgba);

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
	public virtual void GetIndexedColor(long i, IntPtr rgba)
	{
		vtkScalarsToColors_GetIndexedColor_15(GetCppThis(), i, rgba);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_GetIndexedLookup_16(HandleRef pThis);

	/// <summary>
	/// Set/get whether the lookup table is for categorical or ordinal data.
	/// The default is ordinal data; values not present in the lookup table
	/// will be assigned an interpolated color.
	///
	/// When categorical data is present, only values in the lookup table will be
	/// considered valid; all other values will be assigned \a NanColor.
	/// </summary>
	public virtual int GetIndexedLookup()
	{
		return vtkScalarsToColors_GetIndexedLookup_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarsToColors_GetLuminance_17(HandleRef pThis, double x);

	/// <summary>
	/// Map one value through the lookup table and return the luminance
	/// 0.3*red + 0.59*green + 0.11*blue as a double between 0 and 1.
	/// Returns the luminance value for the specified scalar value.
	/// </summary>
	public double GetLuminance(double x)
	{
		return vtkScalarsToColors_GetLuminance_17(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColors_GetNumberOfAnnotatedValues_18(HandleRef pThis);

	/// <summary>
	/// Return the annotated value at a particular index in the list of annotations.
	/// </summary>
	public long GetNumberOfAnnotatedValues()
	{
		return vtkScalarsToColors_GetNumberOfAnnotatedValues_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColors_GetNumberOfAvailableColors_19(HandleRef pThis);

	/// <summary>
	/// Get the number of available colors for mapping to.
	/// </summary>
	public virtual long GetNumberOfAvailableColors()
	{
		return vtkScalarsToColors_GetNumberOfAvailableColors_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColors_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScalarsToColors_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColors_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScalarsToColors_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarsToColors_GetOpacity_22(HandleRef pThis, double v);

	/// <summary>
	/// Map one value through the lookup table and return the alpha value
	/// (the opacity) as a double between 0 and 1. This implementation
	/// always returns 1.
	/// </summary>
	public virtual double GetOpacity(double v)
	{
		return vtkScalarsToColors_GetOpacity_22(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_GetRange_23(HandleRef pThis);

	/// <summary>
	/// Sets/Gets the range of scalars that will be mapped.
	/// </summary>
	public virtual double[] GetRange()
	{
		IntPtr intPtr = vtkScalarsToColors_GetRange_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_GetVectorComponent_24(HandleRef pThis);

	/// <summary>
	/// If the mapper does not select which component of a vector
	/// to map to colors, you can specify it here.
	/// </summary>
	public virtual int GetVectorComponent()
	{
		return vtkScalarsToColors_GetVectorComponent_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_GetVectorMode_25(HandleRef pThis);

	/// <summary>
	/// Change mode that maps vectors by magnitude vs. component.
	/// If the mode is "RGBColors", then the vectors components are
	/// scaled to the range and passed directly as the colors.
	/// </summary>
	public virtual int GetVectorMode()
	{
		return vtkScalarsToColors_GetVectorMode_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_GetVectorSize_26(HandleRef pThis);

	/// <summary>
	/// When mapping vectors, consider only the number of components selected
	/// by VectorSize to be part of the vector, and ignore any other
	/// components.  Set to -1 to map all components.  If this is not set
	/// to -1, then you can use SetVectorComponent to set which scalar
	/// component will be the first component in the vector to be mapped.
	/// </summary>
	public virtual int GetVectorSize()
	{
		return vtkScalarsToColors_GetVectorSize_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_IndexedLookupOff_27(HandleRef pThis);

	/// <summary>
	/// Set/get whether the lookup table is for categorical or ordinal data.
	/// The default is ordinal data; values not present in the lookup table
	/// will be assigned an interpolated color.
	///
	/// When categorical data is present, only values in the lookup table will be
	/// considered valid; all other values will be assigned \a NanColor.
	/// </summary>
	public virtual void IndexedLookupOff()
	{
		vtkScalarsToColors_IndexedLookupOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_IndexedLookupOn_28(HandleRef pThis);

	/// <summary>
	/// Set/get whether the lookup table is for categorical or ordinal data.
	/// The default is ordinal data; values not present in the lookup table
	/// will be assigned an interpolated color.
	///
	/// When categorical data is present, only values in the lookup table will be
	/// considered valid; all other values will be assigned \a NanColor.
	/// </summary>
	public virtual void IndexedLookupOn()
	{
		vtkScalarsToColors_IndexedLookupOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScalarsToColors_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_IsOpaque_30(HandleRef pThis);

	/// <summary>
	/// Return true if all of the values defining the mapping have an opacity
	/// equal to 1. Default implementation returns true. The more complex
	/// signature will yield more accurate results.
	/// </summary>
	public virtual int IsOpaque()
	{
		return vtkScalarsToColors_IsOpaque_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_IsOpaque_31(HandleRef pThis, HandleRef scalars, int colorMode, int component);

	/// <summary>
	/// Return true if all of the values defining the mapping have an opacity
	/// equal to 1. Default implementation returns true. The more complex
	/// signature will yield more accurate results.
	/// </summary>
	public virtual int IsOpaque(vtkAbstractArray scalars, int colorMode, int component)
	{
		return vtkScalarsToColors_IsOpaque_31(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), colorMode, component);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_IsOpaque_32(HandleRef pThis, HandleRef scalars, int colorMode, int component, HandleRef ghosts, byte ghostsToSkip);

	/// <summary>
	/// Return true if all of the values defining the mapping have an opacity
	/// equal to 1. Default implementation returns true. The more complex
	/// signature will yield more accurate results.
	/// </summary>
	public virtual int IsOpaque(vtkAbstractArray scalars, int colorMode, int component, vtkUnsignedCharArray ghosts, byte ghostsToSkip)
	{
		return vtkScalarsToColors_IsOpaque_32(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), colorMode, component, ghosts?.GetCppThis() ?? default(HandleRef), ghostsToSkip);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_IsTypeOf_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScalarsToColors_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_MapScalars_34(HandleRef pThis, HandleRef scalars, int colorMode, int component, int outputFormat, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Internal methods that map a data array into an unsigned char array.
	/// The output format can be set to VTK_RGBA (4 components),
	/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
	/// or VTK_LUMINANCE_ALPHA (2 components).
	/// If not supplied, the output format defaults to RGBA.
	/// The color mode determines the behavior of mapping.
	/// If VTK_COLOR_MODE_DEFAULT is set, then unsigned char data arrays are
	/// treated as colors (and converted to RGBA if necessary);
	/// If VTK_COLOR_MODE_DIRECT_SCALARS is set, then all arrays are treated as
	/// colors (integer types are clamped in the range 0-255, floating point
	/// arrays are clamped in the range 0.0-1.0. Note 'char' does not have enough
	/// values to represent a color so mapping this type is considered an error);
	/// otherwise, the data is mapped through this instance of ScalarsToColors.
	/// The component argument is used for data arrays with more than one
	/// component; it indicates which component to use to do the blending.
	/// When the component argument is -1, then the this object uses its own
	/// selected technique to change a vector into a scalar to map.
	/// </summary>
	public virtual vtkUnsignedCharArray MapScalars(vtkDataArray scalars, int colorMode, int component, int outputFormat)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColors_MapScalars_34(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), colorMode, component, outputFormat, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_MapScalars_35(HandleRef pThis, HandleRef scalars, int colorMode, int component, int outputFormat, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Internal methods that map a data array into an unsigned char array.
	/// The output format can be set to VTK_RGBA (4 components),
	/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
	/// or VTK_LUMINANCE_ALPHA (2 components).
	/// If not supplied, the output format defaults to RGBA.
	/// The color mode determines the behavior of mapping.
	/// If VTK_COLOR_MODE_DEFAULT is set, then unsigned char data arrays are
	/// treated as colors (and converted to RGBA if necessary);
	/// If VTK_COLOR_MODE_DIRECT_SCALARS is set, then all arrays are treated as
	/// colors (integer types are clamped in the range 0-255, floating point
	/// arrays are clamped in the range 0.0-1.0. Note 'char' does not have enough
	/// values to represent a color so mapping this type is considered an error);
	/// otherwise, the data is mapped through this instance of ScalarsToColors.
	/// The component argument is used for data arrays with more than one
	/// component; it indicates which component to use to do the blending.
	/// When the component argument is -1, then the this object uses its own
	/// selected technique to change a vector into a scalar to map.
	/// </summary>
	public virtual vtkUnsignedCharArray MapScalars(vtkAbstractArray scalars, int colorMode, int component, int outputFormat)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColors_MapScalars_35(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), colorMode, component, outputFormat, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_MapScalarsThroughTable_36(HandleRef pThis, HandleRef scalars, IntPtr output, int outputFormat);

	/// <summary>
	/// Map a set of scalars through the lookup table in a single operation.
	/// This method ignores the VectorMode and the VectorComponent.
	/// The output format can be set to VTK_RGBA (4 components),
	/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
	/// or VTK_LUMINANCE_ALPHA (2 components)
	/// If not supplied, the output format defaults to RGBA.
	/// </summary>
	public void MapScalarsThroughTable(vtkDataArray scalars, IntPtr output, int outputFormat)
	{
		vtkScalarsToColors_MapScalarsThroughTable_36(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), output, outputFormat);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_MapScalarsThroughTable_37(HandleRef pThis, HandleRef scalars, IntPtr output);

	/// <summary>
	/// Map a set of scalars through the lookup table in a single operation.
	/// This method ignores the VectorMode and the VectorComponent.
	/// The output format can be set to VTK_RGBA (4 components),
	/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
	/// or VTK_LUMINANCE_ALPHA (2 components)
	/// If not supplied, the output format defaults to RGBA.
	/// </summary>
	public void MapScalarsThroughTable(vtkDataArray scalars, IntPtr output)
	{
		vtkScalarsToColors_MapScalarsThroughTable_37(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), output);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_MapScalarsThroughTable_38(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

	/// <summary>
	/// Map a set of scalars through the lookup table in a single operation.
	/// This method ignores the VectorMode and the VectorComponent.
	/// The output format can be set to VTK_RGBA (4 components),
	/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
	/// or VTK_LUMINANCE_ALPHA (2 components)
	/// If not supplied, the output format defaults to RGBA.
	/// </summary>
	public void MapScalarsThroughTable(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
	{
		vtkScalarsToColors_MapScalarsThroughTable_38(GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_MapScalarsThroughTable2_39(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

	/// <summary>
	/// An internal method typically not used in applications.  This should
	/// be a protected function, but it must be kept public for backwards
	/// compatibility.  Never call this method directly.
	/// </summary>
	public virtual void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
	{
		vtkScalarsToColors_MapScalarsThroughTable2_39(GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_MapValue_40(HandleRef pThis, double v);

	/// <summary>
	/// Map one value through the lookup table and return a color defined
	/// as an RGBA unsigned char tuple (4 bytes).
	/// </summary>
	public virtual IntPtr MapValue(double v)
	{
		return vtkScalarsToColors_MapValue_40(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_MapVectorsThroughTable_41(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize);

	/// <summary>
	/// Map vectors through the lookup table.  Unlike MapScalarsThroughTable,
	/// this method will use the VectorMode to decide how to map vectors.
	/// The output format can be set to VTK_RGBA (4 components),
	/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
	/// or VTK_LUMINANCE_ALPHA (2 components)
	/// </summary>
	public void MapVectorsThroughTable(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
	{
		vtkScalarsToColors_MapVectorsThroughTable_41(GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat, vectorComponent, vectorSize);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_MapVectorsThroughTable_42(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

	/// <summary>
	/// Map vectors through the lookup table.  Unlike MapScalarsThroughTable,
	/// this method will use the VectorMode to decide how to map vectors.
	/// The output format can be set to VTK_RGBA (4 components),
	/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
	/// or VTK_LUMINANCE_ALPHA (2 components)
	/// </summary>
	public void MapVectorsThroughTable(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
	{
		vtkScalarsToColors_MapVectorsThroughTable_42(GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkScalarsToColors NewInstance()
	{
		vtkScalarsToColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColors_NewInstance_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarsToColors_RemoveAnnotation_45(HandleRef pThis, HandleRef value);

	/// <summary>
	/// Remove an existing entry from the list of annotated values.
	///
	/// Returns true when the entry was actually removed (i.e., it existed before the call).
	/// Otherwise, returns false.
	/// </summary>
	public virtual bool RemoveAnnotation(vtkVariant value)
	{
		return (vtkScalarsToColors_RemoveAnnotation_45(GetCppThis(), value?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_ResetAnnotations_46(HandleRef pThis);

	/// <summary>
	/// Remove all existing values and their annotations.
	/// </summary>
	public virtual void ResetAnnotations()
	{
		vtkScalarsToColors_ResetAnnotations_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColors_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScalarsToColors SafeDownCast(vtkObjectBase o)
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColors_SafeDownCast_47(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetAlpha_48(HandleRef pThis, double alpha);

	/// <summary>
	/// Specify an additional opacity (alpha) value to blend with. Values
	/// != 1 modify the resulting color consistent with the requested
	/// form of the output. This is typically used by an actor in order to
	/// blend its opacity. Value is clamped between 0 and 1.
	/// </summary>
	public virtual void SetAlpha(double alpha)
	{
		vtkScalarsToColors_SetAlpha_48(GetCppThis(), alpha);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColors_SetAnnotation_49(HandleRef pThis, HandleRef value, string annotation);

	/// <summary>
	/// Add a new entry (or change an existing entry) to the list of annotated values.
	/// Returns the index of \a value in the list of annotations.
	/// </summary>
	public virtual long SetAnnotation(vtkVariant value, string annotation)
	{
		return vtkScalarsToColors_SetAnnotation_49(GetCppThis(), value?.GetCppThis() ?? default(HandleRef), annotation);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColors_SetAnnotation_50(HandleRef pThis, string value, string annotation);

	/// <summary>
	/// This variant of \a SetAnnotation accepts the value as a string so
	/// ParaView can treat annotations as string vector arrays.
	/// </summary>
	public virtual long SetAnnotation(string value, string annotation)
	{
		return vtkScalarsToColors_SetAnnotation_50(GetCppThis(), value, annotation);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetAnnotations_51(HandleRef pThis, HandleRef values, HandleRef annotations);

	/// <summary>
	/// Set a list of discrete values, either
	/// as a categorical set of values (when IndexedLookup is true) or
	/// as a set of annotations to add to a scalar array (when IndexedLookup is false).
	/// The two arrays must both either be nullptr or of the same length or
	/// the call will be ignored.
	///
	/// Note that these arrays are deep copied rather than being used directly
	/// in order to support the use case where edits are made. If the
	/// \a values and \a annotations arrays were held by this class then each
	/// call to map scalar values to colors would require us to check the MTime
	/// of the arrays.
	/// </summary>
	public virtual void SetAnnotations(vtkAbstractArray values, vtkStringArray annotations)
	{
		vtkScalarsToColors_SetAnnotations_51(GetCppThis(), values?.GetCppThis() ?? default(HandleRef), annotations?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetIndexedLookup_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get whether the lookup table is for categorical or ordinal data.
	/// The default is ordinal data; values not present in the lookup table
	/// will be assigned an interpolated color.
	///
	/// When categorical data is present, only values in the lookup table will be
	/// considered valid; all other values will be assigned \a NanColor.
	/// </summary>
	public virtual void SetIndexedLookup(int _arg)
	{
		vtkScalarsToColors_SetIndexedLookup_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetRange_53(HandleRef pThis, double min, double max);

	/// <summary>
	/// Sets/Gets the range of scalars that will be mapped.
	/// </summary>
	public virtual void SetRange(double min, double max)
	{
		vtkScalarsToColors_SetRange_53(GetCppThis(), min, max);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetRange_54(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// Sets/Gets the range of scalars that will be mapped.
	/// </summary>
	public virtual void SetRange(IntPtr rng)
	{
		vtkScalarsToColors_SetRange_54(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetVectorComponent_55(HandleRef pThis, int _arg);

	/// <summary>
	/// If the mapper does not select which component of a vector
	/// to map to colors, you can specify it here.
	/// </summary>
	public virtual void SetVectorComponent(int _arg)
	{
		vtkScalarsToColors_SetVectorComponent_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetVectorMode_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Change mode that maps vectors by magnitude vs. component.
	/// If the mode is "RGBColors", then the vectors components are
	/// scaled to the range and passed directly as the colors.
	/// </summary>
	public virtual void SetVectorMode(int _arg)
	{
		vtkScalarsToColors_SetVectorMode_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetVectorModeToComponent_57(HandleRef pThis);

	/// <summary>
	/// Change mode that maps vectors by magnitude vs. component.
	/// If the mode is "RGBColors", then the vectors components are
	/// scaled to the range and passed directly as the colors.
	/// </summary>
	public void SetVectorModeToComponent()
	{
		vtkScalarsToColors_SetVectorModeToComponent_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetVectorModeToMagnitude_58(HandleRef pThis);

	/// <summary>
	/// Change mode that maps vectors by magnitude vs. component.
	/// If the mode is "RGBColors", then the vectors components are
	/// scaled to the range and passed directly as the colors.
	/// </summary>
	public void SetVectorModeToMagnitude()
	{
		vtkScalarsToColors_SetVectorModeToMagnitude_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetVectorModeToRGBColors_59(HandleRef pThis);

	/// <summary>
	/// Change mode that maps vectors by magnitude vs. component.
	/// If the mode is "RGBColors", then the vectors components are
	/// scaled to the range and passed directly as the colors.
	/// </summary>
	public void SetVectorModeToRGBColors()
	{
		vtkScalarsToColors_SetVectorModeToRGBColors_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColors_SetVectorSize_60(HandleRef pThis, int _arg);

	/// <summary>
	/// When mapping vectors, consider only the number of components selected
	/// by VectorSize to be part of the vector, and ignore any other
	/// components.  Set to -1 to map all components.  If this is not set
	/// to -1, then you can use SetVectorComponent to set which scalar
	/// component will be the first component in the vector to be mapped.
	/// </summary>
	public virtual void SetVectorSize(int _arg)
	{
		vtkScalarsToColors_SetVectorSize_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColors_UsingLogScale_61(HandleRef pThis);

	/// <summary>
	/// This should return 1 is the subclass is using log scale for mapping scalars
	/// to colors. Default implementation always returns 0.
	/// </summary>
	public virtual int UsingLogScale()
	{
		return vtkScalarsToColors_UsingLogScale_61(GetCppThis());
	}
}
