using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLookupTable
/// </summary>
/// <remarks>
///    map scalar values into colors via a lookup table
///
/// vtkLookupTable is an object that is used by mapper objects to map scalar
/// values into RGBA (red-green-blue-alpha) color specification,
/// or RGBA into scalar values. The color table can be created by direct
/// insertion of color values, or by specifying a hue, saturation, value, and
/// alpha range and generating a table.
///
/// A special color for NaN values in the data can be specified via
/// SetNanColor(). In addition, a color for data values below the
/// lookup table range minimum can be specified with
/// SetBelowRangeColor(), and that color will be used for values below
/// the range minimum when UseBelowRangeColor is on.  Likewise, a color
/// for data values above the lookup table range maximum can be
/// specified with SetAboveRangeColor(), and it is used when
/// UseAboveRangeColor is on.
///
/// This class behaves differently depending on how \a IndexedLookup is set.
/// When true, vtkLookupTable enters a mode for representing categorical color maps.
/// By setting \a IndexedLookup to true, you indicate that the annotated
/// values are the only valid values for which entries in the color table
/// should be returned. The colors in the lookup \a Table are assigned
/// to annotated values by taking the modulus of their index in the list
/// of annotations. \a IndexedLookup changes the behavior of \a GetIndex,
/// which in turn changes the way \a MapScalarsThroughTable2 behaves;
/// when \a IndexedLookup is true, \a MapScalarsThroughTable2 will search for
/// scalar values in \a AnnotatedValues and use the resulting index to
/// determine the color. If a scalar value is not present in \a AnnotatedValues,
/// then \a NanColor will be used.
///
/// @warning
/// You need to explicitly call Build() when constructing the LUT by hand.
///
/// </remarks>
/// <seealso>
///
/// vtkLogLookupTable vtkWindowLevelLookupTable
/// </seealso>
public class vtkLookupTable : vtkScalarsToColors
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLookupTable";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLookupTable()
	{
		MRClassNameKey = "class vtkLookupTable";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLookupTable"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
	/// (from red to blue).
	/// </summary>
	public new static vtkLookupTable New()
	{
		vtkLookupTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLookupTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
	/// (from red to blue).
	/// </summary>
	public vtkLookupTable()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLookupTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLookupTable_Allocate_01(HandleRef pThis, int sz, int ext);

	/// <summary>
	/// Allocate a color table of specified size.
	/// Note that ext is no longer used.
	/// </summary>
	public int Allocate(int sz, int ext)
	{
		return vtkLookupTable_Allocate_01(GetCppThis(), sz, ext);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLookupTable_ApplyLogScale_02(double v, IntPtr range, IntPtr log_range);

	/// <summary>
	/// Apply log to value, with appropriate constraints.
	/// </summary>
	public static double ApplyLogScale(double v, IntPtr range, IntPtr log_range)
	{
		return vtkLookupTable_ApplyLogScale_02(v, range, log_range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_Build_03(HandleRef pThis);

	/// <summary>
	/// Generate lookup table from hue, saturation, value, alpha min/max values.
	/// Table is built from linear ramp of each value.
	/// </summary>
	public override void Build()
	{
		vtkLookupTable_Build_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_BuildSpecialColors_04(HandleRef pThis);

	/// <summary>
	/// Copies the "special" colors into the given table.
	/// </summary>
	public void BuildSpecialColors()
	{
		vtkLookupTable_BuildSpecialColors_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_DeepCopy_05(HandleRef pThis, HandleRef obj);

	/// <summary>
	/// Copy the contents from another LookupTable.
	/// </summary>
	public override void DeepCopy(vtkScalarsToColors obj)
	{
		vtkLookupTable_DeepCopy_05(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_ForceBuild_06(HandleRef pThis);

	/// <summary>
	/// Force the lookup table to regenerate from hue, saturation, value,
	/// and alpha min/max values.  Table is built from a linear ramp of
	/// each value.  ForceBuild() is useful if a lookup table has been
	/// defined manually (using SetTableValue) and then an application
	/// decides to rebuild the lookup table using the implicit process.
	/// </summary>
	public virtual void ForceBuild()
	{
		vtkLookupTable_ForceBuild_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetAboveRangeColor_07(HandleRef pThis);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual double[] GetAboveRangeColor()
	{
		IntPtr intPtr = vtkLookupTable_GetAboveRangeColor_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetAboveRangeColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void GetAboveRangeColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkLookupTable_GetAboveRangeColor_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetAboveRangeColor_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void GetAboveRangeColor(IntPtr _arg)
	{
		vtkLookupTable_GetAboveRangeColor_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetAlphaRange_10(HandleRef pThis);

	/// <summary>
	/// Set the range in alpha (using automatic generation). Alpha ranges from
	/// [0,1].
	/// </summary>
	public virtual double[] GetAlphaRange()
	{
		IntPtr intPtr = vtkLookupTable_GetAlphaRange_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetAlphaRange_11(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the range in alpha (using automatic generation). Alpha ranges from
	/// [0,1].
	/// </summary>
	public virtual void GetAlphaRange(ref double _arg1, ref double _arg2)
	{
		vtkLookupTable_GetAlphaRange_11(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetAlphaRange_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in alpha (using automatic generation). Alpha ranges from
	/// [0,1].
	/// </summary>
	public virtual void GetAlphaRange(IntPtr _arg)
	{
		vtkLookupTable_GetAlphaRange_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetBelowRangeColor_13(HandleRef pThis);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual double[] GetBelowRangeColor()
	{
		IntPtr intPtr = vtkLookupTable_GetBelowRangeColor_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetBelowRangeColor_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void GetBelowRangeColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkLookupTable_GetBelowRangeColor_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetBelowRangeColor_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void GetBelowRangeColor(IntPtr _arg)
	{
		vtkLookupTable_GetBelowRangeColor_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetColor_16(HandleRef pThis, double v, IntPtr rgb);

	/// <summary>
	/// Map one value through the lookup table and return the color as
	/// an RGB[3] array of doubles between 0 and 1. Note lack of alpha.
	/// </summary>
	public override void GetColor(double v, IntPtr rgb)
	{
		vtkLookupTable_GetColor_16(GetCppThis(), v, rgb);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetColorAsUnsignedChars_17(IntPtr colorIn, IntPtr colorOut);

	/// <summary>
	/// Given an RGBA[4] color in the [0,1] range, convert it to RGBA[4] in the [0,255] range.
	/// </summary>
	public static void GetColorAsUnsignedChars(IntPtr colorIn, IntPtr colorOut)
	{
		vtkLookupTable_GetColorAsUnsignedChars_17(colorIn, colorOut);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetHueRange_18(HandleRef pThis);

	/// <summary>
	/// Set the range in hue (using automatic generation). Hue ranges
	/// between [0,1].
	/// </summary>
	public virtual double[] GetHueRange()
	{
		IntPtr intPtr = vtkLookupTable_GetHueRange_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetHueRange_19(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the range in hue (using automatic generation). Hue ranges
	/// between [0,1].
	/// </summary>
	public virtual void GetHueRange(ref double _arg1, ref double _arg2)
	{
		vtkLookupTable_GetHueRange_19(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetHueRange_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in hue (using automatic generation). Hue ranges
	/// between [0,1].
	/// </summary>
	public virtual void GetHueRange(IntPtr _arg)
	{
		vtkLookupTable_GetHueRange_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTable_GetIndex_21(HandleRef pThis, double v);

	/// <summary>
	/// Return the table index associated with a particular value.
	/// Returns -1 if \a v is NaN.
	///
	/// Do not use this function when \a IndexedLookup is true:
	/// in that case, the set of values \a v may take on is exactly the integers
	/// from 0 to \a GetNumberOfTableValues() - 1;
	/// and \a v serves directly as an index into \a TableValues.
	/// </summary>
	public virtual long GetIndex(double v)
	{
		return vtkLookupTable_GetIndex_21(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetIndexedColor_22(HandleRef pThis, long idx, IntPtr rgba);

	/// <summary>
	/// Return a color given an integer index.
	///
	/// This is used to assign colors to annotations (given an offset into the
	/// list of annotations).
	/// If the table is empty or \a idx &lt; 0, then NanColor is returned.
	/// </summary>
	public override void GetIndexedColor(long idx, IntPtr rgba)
	{
		vtkLookupTable_GetIndexedColor_22(GetCppThis(), idx, rgba);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetLogRange_23(IntPtr range, IntPtr log_range);

	/// <summary>
	/// Returns the log of \c range in \c log_range.
	/// There is a little more to this than simply taking the log10 of the
	/// two range values: we do conversion of negative ranges to positive
	/// ranges, and conversion of zero to a 'very small number'.
	/// </summary>
	public static void GetLogRange(IntPtr range, IntPtr log_range)
	{
		vtkLookupTable_GetLogRange_23(range, log_range);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetNanColor_24(HandleRef pThis);

	/// <summary>
	/// Set the color to use when a NaN (not a number) is encountered.  This is an
	/// RGBA 4-tuple of doubles in the range [0,1].
	/// </summary>
	public virtual double[] GetNanColor()
	{
		IntPtr intPtr = vtkLookupTable_GetNanColor_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetNanColor_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set the color to use when a NaN (not a number) is encountered.  This is an
	/// RGBA 4-tuple of doubles in the range [0,1].
	/// </summary>
	public virtual void GetNanColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkLookupTable_GetNanColor_25(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetNanColor_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a NaN (not a number) is encountered.  This is an
	/// RGBA 4-tuple of doubles in the range [0,1].
	/// </summary>
	public virtual void GetNanColor(IntPtr _arg)
	{
		vtkLookupTable_GetNanColor_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetNanColorAsUnsignedChars_27(HandleRef pThis);

	/// <summary>
	/// Return the \a NanColor as a pointer to 4 unsigned chars. This
	/// will overwrite any data returned by previous calls to MapValue.
	/// </summary>
	public IntPtr GetNanColorAsUnsignedChars()
	{
		return vtkLookupTable_GetNanColorAsUnsignedChars_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTable_GetNumberOfAvailableColors_28(HandleRef pThis);

	/// <summary>
	/// Get the number of available colors for mapping to.
	/// </summary>
	public override long GetNumberOfAvailableColors()
	{
		return vtkLookupTable_GetNumberOfAvailableColors_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTable_GetNumberOfColors_29(HandleRef pThis);

	/// <summary>
	/// Set the number of colors in the lookup table.  Use
	/// SetNumberOfTableValues() instead, it can be used both before and
	/// after the table has been built whereas SetNumberOfColors() has no
	/// effect after the table has been built.
	/// </summary>
	public virtual long GetNumberOfColors()
	{
		return vtkLookupTable_GetNumberOfColors_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTable_GetNumberOfColorsMaxValue_30(HandleRef pThis);

	/// <summary>
	/// Set the number of colors in the lookup table.  Use
	/// SetNumberOfTableValues() instead, it can be used both before and
	/// after the table has been built whereas SetNumberOfColors() has no
	/// effect after the table has been built.
	/// </summary>
	public virtual long GetNumberOfColorsMaxValue()
	{
		return vtkLookupTable_GetNumberOfColorsMaxValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTable_GetNumberOfColorsMinValue_31(HandleRef pThis);

	/// <summary>
	/// Set the number of colors in the lookup table.  Use
	/// SetNumberOfTableValues() instead, it can be used both before and
	/// after the table has been built whereas SetNumberOfColors() has no
	/// effect after the table has been built.
	/// </summary>
	public virtual long GetNumberOfColorsMinValue()
	{
		return vtkLookupTable_GetNumberOfColorsMinValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTable_GetNumberOfGenerationsFromBase_32(HandleRef pThis, string type);

	/// <summary>
	/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
	/// (from red to blue).
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLookupTable_GetNumberOfGenerationsFromBase_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTable_GetNumberOfGenerationsFromBaseType_33(string type);

	/// <summary>
	/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
	/// (from red to blue).
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLookupTable_GetNumberOfGenerationsFromBaseType_33(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLookupTable_GetNumberOfTableValues_34(HandleRef pThis);

	/// <summary>
	/// Specify the number of values (i.e., colors) in the lookup table.
	/// </summary>
	public long GetNumberOfTableValues()
	{
		return vtkLookupTable_GetNumberOfTableValues_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLookupTable_GetOpacity_35(HandleRef pThis, double v);

	/// <summary>
	/// Map one value through the lookup table and return the alpha value
	/// (the opacity) as a double between 0 and 1.
	/// </summary>
	public override double GetOpacity(double v)
	{
		return vtkLookupTable_GetOpacity_35(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetPointer_36(HandleRef pThis, long id);

	/// <summary>
	/// Get pointer to color table data. Format is array of unsigned char
	/// R-G-B-A...R-G-B-A.
	/// </summary>
	public IntPtr GetPointer(long id)
	{
		return vtkLookupTable_GetPointer_36(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_GetRamp_37(HandleRef pThis);

	/// <summary>
	/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
	/// The default is S-curve, which tails off gradually at either end.
	///
	/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
	/// For an S-curve greyscale ramp, you should set NumberOfTableValues
	/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
	///
	/// The equation for the linear ramp is simply y = x.
	///
	/// The equation for the SQRT is y = sqrt(x).
	/// </summary>
	public virtual int GetRamp()
	{
		return vtkLookupTable_GetRamp_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetRange_38(HandleRef pThis);

	/// <summary>
	/// Sets/Gets the range of scalars which will be mapped.  This is a duplicate
	/// of Get/SetTableRange.
	/// </summary>
	public override double[] GetRange()
	{
		IntPtr intPtr = vtkLookupTable_GetRange_38(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetSaturationRange_39(HandleRef pThis);

	/// <summary>
	/// Set the range in saturation (using automatic generation). Saturation
	/// ranges between [0,1].
	/// </summary>
	public virtual double[] GetSaturationRange()
	{
		IntPtr intPtr = vtkLookupTable_GetSaturationRange_39(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetSaturationRange_40(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the range in saturation (using automatic generation). Saturation
	/// ranges between [0,1].
	/// </summary>
	public virtual void GetSaturationRange(ref double _arg1, ref double _arg2)
	{
		vtkLookupTable_GetSaturationRange_40(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetSaturationRange_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in saturation (using automatic generation). Saturation
	/// ranges between [0,1].
	/// </summary>
	public virtual void GetSaturationRange(IntPtr _arg)
	{
		vtkLookupTable_GetSaturationRange_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_GetScale_42(HandleRef pThis);

	/// <summary>
	/// Set the type of scale to use, linear or logarithmic.  The default
	/// is linear.  If the scale is logarithmic, then the TableRange must not
	/// cross the value zero.
	/// </summary>
	public virtual int GetScale()
	{
		return vtkLookupTable_GetScale_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetTable_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the internal table array that is used to map the scalars
	/// to colors.  The table array is an unsigned char array with 4
	/// components representing RGBA.
	/// </summary>
	public virtual vtkUnsignedCharArray GetTable()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLookupTable_GetTable_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkLookupTable_GetTableRange_44(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum/maximum scalar values for scalar mapping. Scalar
	/// values less than minimum range value are clamped to minimum range value.
	/// Scalar values greater than maximum range value are clamped to maximum
	/// range value.
	///
	/// The \a TableRange values are only used when \a IndexedLookup is false.
	/// </summary>
	public virtual double[] GetTableRange()
	{
		IntPtr intPtr = vtkLookupTable_GetTableRange_44(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetTableRange_45(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the minimum/maximum scalar values for scalar mapping. Scalar
	/// values less than minimum range value are clamped to minimum range value.
	/// Scalar values greater than maximum range value are clamped to maximum
	/// range value.
	///
	/// The \a TableRange values are only used when \a IndexedLookup is false.
	/// </summary>
	public virtual void GetTableRange(IntPtr data)
	{
		vtkLookupTable_GetTableRange_45(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetTableValue_46(HandleRef pThis, long indx);

	/// <summary>
	/// Return an RGBA color value for the given index into the lookup table. Color
	/// components are expressed as [0,1] double values.
	/// </summary>
	public double[] GetTableValue(long indx)
	{
		IntPtr intPtr = vtkLookupTable_GetTableValue_46(GetCppThis(), indx);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetTableValue_47(HandleRef pThis, long indx, IntPtr rgba);

	/// <summary>
	/// Return an RGBA color value for the given index into the lookup table. Color
	/// components are expressed as [0,1] double values.
	/// </summary>
	public void GetTableValue(long indx, IntPtr rgba)
	{
		vtkLookupTable_GetTableValue_47(GetCppThis(), indx, rgba);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_GetUseAboveRangeColor_48(HandleRef pThis);

	/// <summary>
	/// Set whether the above range color should be used.
	/// </summary>
	public virtual int GetUseAboveRangeColor()
	{
		return vtkLookupTable_GetUseAboveRangeColor_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_GetUseBelowRangeColor_49(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual int GetUseBelowRangeColor()
	{
		return vtkLookupTable_GetUseBelowRangeColor_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_GetValueRange_50(HandleRef pThis);

	/// <summary>
	/// Set the range in value (using automatic generation). Value ranges
	/// between [0,1].
	/// </summary>
	public virtual double[] GetValueRange()
	{
		IntPtr intPtr = vtkLookupTable_GetValueRange_50(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetValueRange_51(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the range in value (using automatic generation). Value ranges
	/// between [0,1].
	/// </summary>
	public virtual void GetValueRange(ref double _arg1, ref double _arg2)
	{
		vtkLookupTable_GetValueRange_51(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_GetValueRange_52(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in value (using automatic generation). Value ranges
	/// between [0,1].
	/// </summary>
	public virtual void GetValueRange(IntPtr _arg)
	{
		vtkLookupTable_GetValueRange_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_IsA_53(HandleRef pThis, string type);

	/// <summary>
	/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
	/// (from red to blue).
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLookupTable_IsA_53(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_IsOpaque_54(HandleRef pThis);

	/// <summary>
	/// Return true if all of the values defining the mapping have an opacity
	/// equal to 1.
	/// </summary>
	public override int IsOpaque()
	{
		return vtkLookupTable_IsOpaque_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_IsOpaque_55(HandleRef pThis, HandleRef scalars, int colorMode, int component);

	/// <summary>
	/// Return true if all of the values defining the mapping have an opacity
	/// equal to 1.
	/// </summary>
	public override int IsOpaque(vtkAbstractArray scalars, int colorMode, int component)
	{
		return vtkLookupTable_IsOpaque_55(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), colorMode, component);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_IsOpaque_56(HandleRef pThis, HandleRef scalars, int colorMode, int component, HandleRef ghosts, byte ghostsToSkip);

	/// <summary>
	/// Return true if all of the values defining the mapping have an opacity
	/// equal to 1.
	/// </summary>
	public override int IsOpaque(vtkAbstractArray scalars, int colorMode, int component, vtkUnsignedCharArray ghosts, byte ghostsToSkip)
	{
		return vtkLookupTable_IsOpaque_56(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef), colorMode, component, ghosts?.GetCppThis() ?? default(HandleRef), ghostsToSkip);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_IsTypeOf_57(string type);

	/// <summary>
	/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
	/// (from red to blue).
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLookupTable_IsTypeOf_57(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_MapScalarsThroughTable2_58(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

	/// <summary>
	/// Map a set of scalars through the lookup table.
	///
	/// This member function is thread safe.
	/// </summary>
	public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
	{
		vtkLookupTable_MapScalarsThroughTable2_58(GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_MapValue_59(HandleRef pThis, double v);

	/// <summary>
	/// Map one value through the lookup table, returning an RBGA[4] color.
	/// </summary>
	public override IntPtr MapValue(double v)
	{
		return vtkLookupTable_MapValue_59(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_NewInstance_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
	/// (from red to blue).
	/// </summary>
	public new vtkLookupTable NewInstance()
	{
		vtkLookupTable result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLookupTable_NewInstance_61(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_SafeDownCast_62(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
	/// (from red to blue).
	/// </summary>
	public new static vtkLookupTable SafeDownCast(vtkObjectBase o)
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLookupTable_SafeDownCast_62(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLookupTable2 = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLookupTable2.Register(null);
			}
		}
		return vtkLookupTable2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetAboveRangeColor_63(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void SetAboveRangeColor(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkLookupTable_SetAboveRangeColor_63(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetAboveRangeColor_64(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void SetAboveRangeColor(IntPtr _arg)
	{
		vtkLookupTable_SetAboveRangeColor_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetAlphaRange_65(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the range in alpha (using automatic generation). Alpha ranges from
	/// [0,1].
	/// </summary>
	public virtual void SetAlphaRange(double _arg1, double _arg2)
	{
		vtkLookupTable_SetAlphaRange_65(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetAlphaRange_66(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in alpha (using automatic generation). Alpha ranges from
	/// [0,1].
	/// </summary>
	public void SetAlphaRange(IntPtr _arg)
	{
		vtkLookupTable_SetAlphaRange_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetBelowRangeColor_67(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void SetBelowRangeColor(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkLookupTable_SetBelowRangeColor_67(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetBelowRangeColor_68(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void SetBelowRangeColor(IntPtr _arg)
	{
		vtkLookupTable_SetBelowRangeColor_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetHueRange_69(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the range in hue (using automatic generation). Hue ranges
	/// between [0,1].
	/// </summary>
	public virtual void SetHueRange(double _arg1, double _arg2)
	{
		vtkLookupTable_SetHueRange_69(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetHueRange_70(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in hue (using automatic generation). Hue ranges
	/// between [0,1].
	/// </summary>
	public void SetHueRange(IntPtr _arg)
	{
		vtkLookupTable_SetHueRange_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetNanColor_71(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set the color to use when a NaN (not a number) is encountered.  This is an
	/// RGBA 4-tuple of doubles in the range [0,1].
	/// </summary>
	public virtual void SetNanColor(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkLookupTable_SetNanColor_71(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetNanColor_72(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a NaN (not a number) is encountered.  This is an
	/// RGBA 4-tuple of doubles in the range [0,1].
	/// </summary>
	public virtual void SetNanColor(IntPtr _arg)
	{
		vtkLookupTable_SetNanColor_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetNumberOfColors_73(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the number of colors in the lookup table.  Use
	/// SetNumberOfTableValues() instead, it can be used both before and
	/// after the table has been built whereas SetNumberOfColors() has no
	/// effect after the table has been built.
	/// </summary>
	public virtual void SetNumberOfColors(long _arg)
	{
		vtkLookupTable_SetNumberOfColors_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetNumberOfTableValues_74(HandleRef pThis, long number);

	/// <summary>
	/// Specify the number of values (i.e., colors) in the lookup table.
	/// </summary>
	public void SetNumberOfTableValues(long number)
	{
		vtkLookupTable_SetNumberOfTableValues_74(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetRamp_75(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
	/// The default is S-curve, which tails off gradually at either end.
	///
	/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
	/// For an S-curve greyscale ramp, you should set NumberOfTableValues
	/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
	///
	/// The equation for the linear ramp is simply y = x.
	///
	/// The equation for the SQRT is y = sqrt(x).
	/// </summary>
	public virtual void SetRamp(int _arg)
	{
		vtkLookupTable_SetRamp_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetRampToLinear_76(HandleRef pThis);

	/// <summary>
	/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
	/// The default is S-curve, which tails off gradually at either end.
	///
	/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
	/// For an S-curve greyscale ramp, you should set NumberOfTableValues
	/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
	///
	/// The equation for the linear ramp is simply y = x.
	///
	/// The equation for the SQRT is y = sqrt(x).
	/// </summary>
	public void SetRampToLinear()
	{
		vtkLookupTable_SetRampToLinear_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetRampToSCurve_77(HandleRef pThis);

	/// <summary>
	/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
	/// The default is S-curve, which tails off gradually at either end.
	///
	/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
	/// For an S-curve greyscale ramp, you should set NumberOfTableValues
	/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
	///
	/// The equation for the linear ramp is simply y = x.
	///
	/// The equation for the SQRT is y = sqrt(x).
	/// </summary>
	public void SetRampToSCurve()
	{
		vtkLookupTable_SetRampToSCurve_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetRampToSQRT_78(HandleRef pThis);

	/// <summary>
	/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
	/// The default is S-curve, which tails off gradually at either end.
	///
	/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
	/// For an S-curve greyscale ramp, you should set NumberOfTableValues
	/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
	///
	/// The equation for the linear ramp is simply y = x.
	///
	/// The equation for the SQRT is y = sqrt(x).
	/// </summary>
	public void SetRampToSQRT()
	{
		vtkLookupTable_SetRampToSQRT_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetRange_79(HandleRef pThis, double min, double max);

	/// <summary>
	/// Sets/Gets the range of scalars which will be mapped.  This is a duplicate
	/// of Get/SetTableRange.
	/// </summary>
	public override void SetRange(double min, double max)
	{
		vtkLookupTable_SetRange_79(GetCppThis(), min, max);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetRange_80(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// Sets/Gets the range of scalars which will be mapped.  This is a duplicate
	/// of Get/SetTableRange.
	/// </summary>
	public override void SetRange(IntPtr rng)
	{
		vtkLookupTable_SetRange_80(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetSaturationRange_81(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the range in saturation (using automatic generation). Saturation
	/// ranges between [0,1].
	/// </summary>
	public virtual void SetSaturationRange(double _arg1, double _arg2)
	{
		vtkLookupTable_SetSaturationRange_81(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetSaturationRange_82(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in saturation (using automatic generation). Saturation
	/// ranges between [0,1].
	/// </summary>
	public void SetSaturationRange(IntPtr _arg)
	{
		vtkLookupTable_SetSaturationRange_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetScale_83(HandleRef pThis, int scale);

	/// <summary>
	/// Set the type of scale to use, linear or logarithmic.  The default
	/// is linear.  If the scale is logarithmic, then the TableRange must not
	/// cross the value zero.
	/// </summary>
	public void SetScale(int scale)
	{
		vtkLookupTable_SetScale_83(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetScaleToLinear_84(HandleRef pThis);

	/// <summary>
	/// Set the type of scale to use, linear or logarithmic.  The default
	/// is linear.  If the scale is logarithmic, then the TableRange must not
	/// cross the value zero.
	/// </summary>
	public void SetScaleToLinear()
	{
		vtkLookupTable_SetScaleToLinear_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetScaleToLog10_85(HandleRef pThis);

	/// <summary>
	/// Set the type of scale to use, linear or logarithmic.  The default
	/// is linear.  If the scale is logarithmic, then the TableRange must not
	/// cross the value zero.
	/// </summary>
	public void SetScaleToLog10()
	{
		vtkLookupTable_SetScaleToLog10_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetTable_86(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the internal table array that is used to map the scalars
	/// to colors.  The table array is an unsigned char array with 4
	/// components representing RGBA.
	/// </summary>
	public void SetTable(vtkUnsignedCharArray arg0)
	{
		vtkLookupTable_SetTable_86(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetTableRange_87(HandleRef pThis, IntPtr r);

	/// <summary>
	/// Set/Get the minimum/maximum scalar values for scalar mapping. Scalar
	/// values less than minimum range value are clamped to minimum range value.
	/// Scalar values greater than maximum range value are clamped to maximum
	/// range value.
	///
	/// The \a TableRange values are only used when \a IndexedLookup is false.
	/// </summary>
	public virtual void SetTableRange(IntPtr r)
	{
		vtkLookupTable_SetTableRange_87(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetTableRange_88(HandleRef pThis, double min, double max);

	/// <summary>
	/// Set/Get the minimum/maximum scalar values for scalar mapping. Scalar
	/// values less than minimum range value are clamped to minimum range value.
	/// Scalar values greater than maximum range value are clamped to maximum
	/// range value.
	///
	/// The \a TableRange values are only used when \a IndexedLookup is false.
	/// </summary>
	public virtual void SetTableRange(double min, double max)
	{
		vtkLookupTable_SetTableRange_88(GetCppThis(), min, max);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetTableValue_89(HandleRef pThis, long indx, IntPtr rgba);

	/// <summary>
	/// Directly load color into lookup table. Use [0,1] double values for color
	/// component specification. Make sure that you've either used the
	/// Build() method or used SetNumberOfTableValues() prior to using this
	/// method.
	/// </summary>
	public virtual void SetTableValue(long indx, IntPtr rgba)
	{
		vtkLookupTable_SetTableValue_89(GetCppThis(), indx, rgba);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetTableValue_90(HandleRef pThis, long indx, double r, double g, double b, double a);

	/// <summary>
	/// Directly load color into lookup table. Use [0,1] double values for color
	/// component specification. Alpha defaults to 1 if unspecified.
	/// </summary>
	public virtual void SetTableValue(long indx, double r, double g, double b, double a)
	{
		vtkLookupTable_SetTableValue_90(GetCppThis(), indx, r, g, b, a);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetUseAboveRangeColor_91(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether the above range color should be used.
	/// </summary>
	public virtual void SetUseAboveRangeColor(int _arg)
	{
		vtkLookupTable_SetUseAboveRangeColor_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetUseBelowRangeColor_92(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void SetUseBelowRangeColor(int _arg)
	{
		vtkLookupTable_SetUseBelowRangeColor_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetValueRange_93(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the range in value (using automatic generation). Value ranges
	/// between [0,1].
	/// </summary>
	public virtual void SetValueRange(double _arg1, double _arg2)
	{
		vtkLookupTable_SetValueRange_93(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_SetValueRange_94(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range in value (using automatic generation). Value ranges
	/// between [0,1].
	/// </summary>
	public void SetValueRange(IntPtr _arg)
	{
		vtkLookupTable_SetValueRange_94(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_UseAboveRangeColorOff_95(HandleRef pThis);

	/// <summary>
	/// Set whether the above range color should be used.
	/// </summary>
	public virtual void UseAboveRangeColorOff()
	{
		vtkLookupTable_UseAboveRangeColorOff_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_UseAboveRangeColorOn_96(HandleRef pThis);

	/// <summary>
	/// Set whether the above range color should be used.
	/// </summary>
	public virtual void UseAboveRangeColorOn()
	{
		vtkLookupTable_UseAboveRangeColorOn_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_UseBelowRangeColorOff_97(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void UseBelowRangeColorOff()
	{
		vtkLookupTable_UseBelowRangeColorOff_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLookupTable_UseBelowRangeColorOn_98(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void UseBelowRangeColorOn()
	{
		vtkLookupTable_UseBelowRangeColorOn_98(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLookupTable_UsingLogScale_99(HandleRef pThis);

	/// <summary>
	/// This should return 1 if the subclass is using log scale for mapping scalars
	/// to colors. Returns 1 is scale == VTK_SCALE_LOG10.
	/// </summary>
	public override int UsingLogScale()
	{
		return vtkLookupTable_UsingLogScale_99(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLookupTable_WritePointer_100(HandleRef pThis, long id, int number);

	/// <summary>
	/// Get pointer to data. Useful for direct writes into object. MaxId is bumped
	/// by number (and memory allocated if necessary). Id is the location you
	/// wish to write into; number is the number of rgba values to write.
	///
	/// \warning If you modify the table data via the pointer returned by this
	/// member function, you must call vtkLookupTable::BuildSpecialColors()
	/// afterwards to ensure that the special colors (below/above range and NaN
	/// value) are up-to-date.
	/// </summary>
	public IntPtr WritePointer(long id, int number)
	{
		return vtkLookupTable_WritePointer_100(GetCppThis(), id, number);
	}
}
