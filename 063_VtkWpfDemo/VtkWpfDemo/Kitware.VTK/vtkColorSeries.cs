using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkColorSeries
/// </summary>
/// <remarks>
///    stores a list of colors.
///
///
/// The vtkColorSeries stores palettes of colors. There are several default
/// palettes (or schemes) available and functions to control several aspects
/// of what colors are returned. In essence a color scheme is set and then
/// the number of colors and individual color values may be requested.
///
/// For a web page showcasing the default palettes, see:
/// &lt;a
/// href="https://htmlpreview.github.io/?https://github.com/Kitware/vtk-examples/blob/gh-pages/VTKColorSeriesPatches.html"&gt;VTKColorSeriesPatches&lt;/a&gt;;
/// &lt;a
/// href="https://kitware.github.io/vtk-examples/site/Python/Visualization/ColorSeriesPatches/"&gt;ColorSeriesPatches&lt;/a&gt;
/// was used to generate this table.
///
/// It is also possible to add schemes beyond the default palettes.
/// Whenever \a SetColorScheme is called with a string for which no palette
/// already exists, a new, empty palette is created.
/// You may then use \a SetNumberOfColors and \a SetColor to populate the
/// palette.
/// You may not extend default palettes by calling functions that alter
/// a scheme; if called while a predefined palette is in use, they
/// will create a new non-default scheme and populate it with the current
/// palette before continuing.
///
/// The "Brewer" palettes are courtesy of
/// Cynthia A. Brewer (Dept. of Geography, Pennsylvania State University)
/// and under the Apache License. See the source code for details.
/// </remarks>
public class vtkColorSeries : vtkObject
{
	/// <summary>
	/// Enum of the available color schemes
	/// </summary>
	public enum ColorSchemes
	{
		/// <summary>enum member</summary>
		BLUES = 3,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_10 = 25,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_11 = 24,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_3 = 32,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_4 = 31,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_5 = 30,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_6 = 29,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_7 = 28,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_8 = 27,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_BROWN_BLUE_GREEN_9 = 26,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_10 = 7,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_11 = 6,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_3 = 14,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_4 = 13,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_5 = 12,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_6 = 11,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_7 = 10,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_8 = 9,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_PURPLE_ORANGE_9 = 8,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_10 = 16,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_11 = 15,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_3 = 23,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_4 = 22,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_5 = 21,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_6 = 20,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_7 = 19,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_8 = 18,
		/// <summary>enum member</summary>
		BREWER_DIVERGING_SPECTRAL_9 = 17,
		/// <summary>enum member</summary>
		BREWER_QUALITATIVE_ACCENT = 54,
		/// <summary>enum member</summary>
		BREWER_QUALITATIVE_DARK2 = 55,
		/// <summary>enum member</summary>
		BREWER_QUALITATIVE_PAIRED = 60,
		/// <summary>enum member</summary>
		BREWER_QUALITATIVE_PASTEL1 = 58,
		/// <summary>enum member</summary>
		BREWER_QUALITATIVE_PASTEL2 = 57,
		/// <summary>enum member</summary>
		BREWER_QUALITATIVE_SET1 = 59,
		/// <summary>enum member</summary>
		BREWER_QUALITATIVE_SET2 = 56,
		/// <summary>enum member</summary>
		BREWER_QUALITATIVE_SET3 = 61,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_GREEN_3 = 39,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_GREEN_4 = 38,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_GREEN_5 = 37,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_GREEN_6 = 36,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_GREEN_7 = 35,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_GREEN_8 = 34,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_GREEN_9 = 33,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_PURPLE_3 = 53,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_PURPLE_4 = 52,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_PURPLE_5 = 51,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_PURPLE_6 = 50,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_PURPLE_7 = 49,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_PURPLE_8 = 48,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_BLUE_PURPLE_9 = 47,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_3 = 46,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_4 = 45,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_5 = 44,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_6 = 43,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_7 = 42,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_8 = 41,
		/// <summary>enum member</summary>
		BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_9 = 40,
		/// <summary>enum member</summary>
		CITRUS = 5,
		/// <summary>enum member</summary>
		COOL = 2,
		/// <summary>enum member</summary>
		CUSTOM = 62,
		/// <summary>enum member</summary>
		SPECTRUM = 0,
		/// <summary>enum member</summary>
		WARM = 1,
		/// <summary>enum member</summary>
		WILD_FLOWER = 4
	}

	/// <summary>
	/// An enum defining how lookup tables should be used: either as a
	/// list of discrete colors to choose from (categorical), or as an
	/// ordered list of color set - points to interpolate among (ordinal).
	/// </summary>
	public enum LUTMode
	{
		/// <summary>enum member</summary>
		CATEGORICAL = 1,
		/// <summary>enum member</summary>
		ORDINAL = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkColorSeries";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkColorSeries()
	{
		MRClassNameKey = "class vtkColorSeries";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorSeries"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkColorSeries(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorSeries_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkColorSeries with the SPECTRUM color scheme.
	/// </summary>
	public new static vtkColorSeries New()
	{
		vtkColorSeries result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorSeries_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkColorSeries with the SPECTRUM color scheme.
	/// </summary>
	public vtkColorSeries()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkColorSeries_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_AddColor_01(HandleRef pThis, HandleRef color);

	/// <summary>
	/// Adds the color to the end of the list.
	/// </summary>
	public virtual void AddColor(vtkColor3ub color)
	{
		vtkColorSeries_AddColor_01(GetCppThis(), color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_BuildLookupTable_02(HandleRef pThis, HandleRef lkup, int lutIndexing);

	/// <summary>
	/// Populate a lookup table with all the colors in the current scheme.
	///
	/// The default behavior is to return categorical data. Set lutIndexing
	/// to ORDINAL to return ordinal data. Any other value for lutIndexing
	/// is treated as CATEGORICAL.
	/// </summary>
	public void BuildLookupTable(vtkLookupTable lkup, int lutIndexing)
	{
		vtkColorSeries_BuildLookupTable_02(GetCppThis(), lkup?.GetCppThis() ?? default(HandleRef), lutIndexing);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_ClearColors_03(HandleRef pThis);

	/// <summary>
	/// Clears the list of colors.
	/// </summary>
	public virtual void ClearColors()
	{
		vtkColorSeries_ClearColors_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorSeries_CreateLookupTable_04(HandleRef pThis, int lutIndexing, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new lookup table with all the colors in the current scheme.
	///
	/// The caller is responsible for deleting the table after use.
	///
	/// The default behavior is to return categorical data. Set lutIndexing
	/// to ORDINAL to return ordinal data. Any other value for lutIndexing
	/// is treated as CATEGORICAL.
	/// </summary>
	public vtkLookupTable CreateLookupTable(int lutIndexing)
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorSeries_CreateLookupTable_04(GetCppThis(), lutIndexing, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_DeepCopy_05(HandleRef pThis, HandleRef chartColors);

	/// <summary>
	/// Make a deep copy of the supplied object.
	/// </summary>
	public virtual void DeepCopy(vtkColorSeries chartColors)
	{
		vtkColorSeries_DeepCopy_05(GetCppThis(), chartColors?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorSeries_GetColor_06(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color at the specified index. If the index is out of range then
	/// black will be returned.
	/// </summary>
	public vtkColor3ub GetColor(int index)
	{
		vtkColor3ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorSeries_GetColor_06(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor3ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorSeries_GetColorRepeating_07(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color at the specified index. If the index is out of range then
	/// the call wraps around, i.e. uses the mod operator.
	/// </summary>
	public vtkColor3ub GetColorRepeating(int index)
	{
		vtkColor3ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorSeries_GetColorRepeating_07(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor3ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorSeries_GetColorScheme_08(HandleRef pThis);

	/// <summary>
	/// Return the ID of the color scheme currently in use.
	/// </summary>
	public virtual int GetColorScheme()
	{
		return vtkColorSeries_GetColorScheme_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkColorSeries_GetColorSchemeName_09(HandleRef pThis);

	/// <summary>
	/// Get the color scheme that is currently being used.
	/// </summary>
	public virtual string GetColorSchemeName()
	{
		return vtkColorSeries_GetColorSchemeName_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorSeries_GetNumberOfColorSchemes_10(HandleRef pThis);

	/// <summary>
	/// Return the number of schemes currently defined.
	/// </summary>
	public int GetNumberOfColorSchemes()
	{
		return vtkColorSeries_GetNumberOfColorSchemes_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorSeries_GetNumberOfColors_11(HandleRef pThis);

	/// <summary>
	/// Get the number of colors available in the current color scheme.
	/// </summary>
	public virtual int GetNumberOfColors()
	{
		return vtkColorSeries_GetNumberOfColors_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorSeries_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkColorSeries_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorSeries_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkColorSeries_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_InsertColor_14(HandleRef pThis, int index, HandleRef color);

	/// <summary>
	/// Inserts the color at the specified index in the list.
	/// </summary>
	public virtual void InsertColor(int index, vtkColor3ub color)
	{
		vtkColorSeries_InsertColor_14(GetCppThis(), index, color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorSeries_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkColorSeries_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorSeries_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkColorSeries_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorSeries_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkColorSeries NewInstance()
	{
		vtkColorSeries result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorSeries_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_RemoveColor_19(HandleRef pThis, int index);

	/// <summary>
	/// Removes the color at the specified index in the list.
	/// </summary>
	public virtual void RemoveColor(int index)
	{
		vtkColorSeries_RemoveColor_19(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorSeries_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkColorSeries SafeDownCast(vtkObjectBase o)
	{
		vtkColorSeries vtkColorSeries2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorSeries_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorSeries2 = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorSeries2.Register(null);
			}
		}
		return vtkColorSeries2;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_SetColor_21(HandleRef pThis, int index, HandleRef color);

	/// <summary>
	/// Set the color at the specified index. Does nothing if the index is out of
	/// range.
	/// </summary>
	public virtual void SetColor(int index, vtkColor3ub color)
	{
		vtkColorSeries_SetColor_21(GetCppThis(), index, color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_SetColorScheme_22(HandleRef pThis, int scheme);

	/// <summary>
	/// Set the color scheme that should be used.
	/// The variant of this function that takes an integer should pass a
	/// number from those in the enum, or a value returned by the string variant.
	/// The variant that accepts a string returns the integer index
	/// of the resulting palette (whether it already existed or is newly-created).
	/// </summary>
	public virtual void SetColorScheme(int scheme)
	{
		vtkColorSeries_SetColorScheme_22(GetCppThis(), scheme);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorSeries_SetColorSchemeByName_23(HandleRef pThis, string schemeName);

	/// <summary>
	/// Set the color scheme that should be used.
	/// The variant of this function that takes an integer should pass a
	/// number from those in the enum, or a value returned by the string variant.
	/// The variant that accepts a string returns the integer index
	/// of the resulting palette (whether it already existed or is newly-created).
	/// </summary>
	public virtual int SetColorSchemeByName(string schemeName)
	{
		return vtkColorSeries_SetColorSchemeByName_23(GetCppThis(), schemeName);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_SetColorSchemeName_24(HandleRef pThis, string name);

	/// <summary>
	/// Set the name of the current color scheme
	/// </summary>
	public virtual void SetColorSchemeName(string name)
	{
		vtkColorSeries_SetColorSchemeName_24(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorSeries_SetNumberOfColors_25(HandleRef pThis, int numColors);

	/// <summary>
	/// Set the number of colors to be stored in a non-default color scheme.
	/// Calling this function on a predefined color scheme will cause the scheme
	/// to be duplicated to a new custom scheme.
	/// </summary>
	public virtual void SetNumberOfColors(int numColors)
	{
		vtkColorSeries_SetNumberOfColors_25(GetCppThis(), numColors);
	}
}
