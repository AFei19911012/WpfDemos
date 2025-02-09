using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNamedColors
/// </summary>
/// <remarks>
///    A class holding colors and their names.
///
/// For a web page showcasing VTK Named Colors and their RGB values, see:
/// &lt;a
/// href="https://htmlpreview.github.io/?https://github.com/Kitware/vtk-examples/blob/gh-pages/VTKNamedColorPatches.html"&gt;VTKNamedColorPatches&lt;/a&gt;;
/// &lt;a
/// href="https://kitware.github.io/vtk-examples/site/Python/Visualization/NamedColorPatches/"&gt;NamedColorPatches&lt;/a&gt;
/// was used to generate this table.
///
/// Color names are case insensitive and are stored as lower-case names
/// along with a 4-element array whose elements are red, green, blue and alpha,
/// in that order, corresponding to the RGBA value of the color.
///
/// It is assumed that if the RGBA values are unsigned char then each element
/// lies in the range 0...255 and if the RGBA values are double then each
/// element lies in the range 0...1.
///
/// The colors and names are those in &lt;a href="https://en.wikipedia.org/wiki/Web_colors"&gt;Web
/// colors&lt;/a&gt; that are derived from the CSS3 specification: &lt;a
/// href="https://www.w3.org/TR/css-color-3/"&gt;CSS Color Module Level 3&lt;/a&gt; In this table
/// common synonyms such as cyan/aqua and magenta/fuchsia are also included.
///
/// Also included in this class are names and colors taken from
/// &lt;em&gt;Wrapping/Python/vtkmodules/util/colors.py&lt;/em&gt; that were originally taken from
/// &lt;em&gt;Wrapping/Tcl/vtktesting/colors.tcl&lt;/em&gt; (no longer in the VTK source files - deleted
/// 06-Dec-2017).
///
/// Web colors and names in &lt;a href="https://en.wikipedia.org/wiki/Web_colors"&gt;Web colors&lt;/a&gt; take
/// precedence over those in &lt;em&gt;colors.py&lt;/em&gt;. One consequence of this
/// is that while &lt;em&gt;colors.py&lt;/em&gt; specifies green as equivalent to
/// (0,255,0), the web color standard defines it as (0,128,0).
///
/// The \a SetColor methods will overwrite existing colors if the name of the
/// color being set matches an existing color. Note that ColorExists() can be
/// used to test for existence of the color being set.
///
/// In the case of the \a GetColor methods returning doubles, alternative versions,
/// identified by the letters RGB in the names, are provided.
/// These get functions return just the red, green and blue components of
/// a color.
///
/// The class also provides methods for defining a color through an HTML color
/// string. The following formats are supported:
///
/// - \#RGB                 (3-digit hexadecimal number, where #4F2 is a shortcut for #44FF22)
/// - \#RRGGBB              (6-digit hexadecimal number)
/// - rgb(r, g, b)          (where r, g, b are in 0..255 or percentage values)
/// - rgba(r, g, b, a)      (where r, g, b, are in 0..255 or percentage values, a is in 0.0..1.0)
/// - a CSS3 color name     (e.g. "steelblue")
/// </remarks>
public class vtkNamedColors : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNamedColors";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNamedColors()
	{
		MRClassNameKey = "class vtkNamedColors";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNamedColors"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNamedColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkNamedColors object.
	/// </summary>
	public new static vtkNamedColors New()
	{
		vtkNamedColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNamedColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkNamedColors object.
	/// </summary>
	public vtkNamedColors()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNamedColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkNamedColors_ColorExists_01(HandleRef pThis, string name);

	/// <summary>
	/// Return true if the color exists.
	/// </summary>
	public bool ColorExists(string name)
	{
		return (vtkNamedColors_ColorExists_01(GetCppThis(), name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColor_02(HandleRef pThis, string name, ref byte r, ref byte g, ref byte b, ref byte a);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as four unsigned char variables:
	/// red, green, blue, alpha. The range of each element is 0...255.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColor(string name, ref byte r, ref byte g, ref byte b, ref byte a)
	{
		vtkNamedColors_GetColor_02(GetCppThis(), name, ref r, ref g, ref b, ref a);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColor_03(HandleRef pThis, string name, IntPtr rgba);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as an unsigned char array:
	/// [red, green, blue, alpha]. The range of each element is 0...255.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColor(string name, IntPtr rgba)
	{
		vtkNamedColors_GetColor_03(GetCppThis(), name, rgba);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColor_04(HandleRef pThis, string name, HandleRef rgba);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a vtkColor4ub class.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColor(string name, vtkColor4ub rgba)
	{
		vtkNamedColors_GetColor_04(GetCppThis(), name, rgba?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColor_05(HandleRef pThis, string name, ref double r, ref double g, ref double b, ref double a);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as four double variables:
	/// red, green, blue, alpha. The range of each element is 0...1.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColor(string name, ref double r, ref double g, ref double b, ref double a)
	{
		vtkNamedColors_GetColor_05(GetCppThis(), name, ref r, ref g, ref b, ref a);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColor_06(HandleRef pThis, string name, HandleRef rgba);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a vtkColor4d class.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColor(string name, vtkColor4d rgba)
	{
		vtkNamedColors_GetColor_06(GetCppThis(), name, rgba?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColor_07(HandleRef pThis, string name, ref double r, ref double g, ref double b);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as three double variables:
	/// red, green, blue. The range of each element is 0...1.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColor(string name, ref double r, ref double g, ref double b)
	{
		vtkNamedColors_GetColor_07(GetCppThis(), name, ref r, ref g, ref b);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColor_08(HandleRef pThis, string name, HandleRef rgb);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a vtkColor3ub class.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColor(string name, vtkColor3ub rgb)
	{
		vtkNamedColors_GetColor_08(GetCppThis(), name, rgb?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColor_09(HandleRef pThis, string name, HandleRef rgb);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a vtkColor3d class.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColor(string name, vtkColor3d rgb)
	{
		vtkNamedColors_GetColor_09(GetCppThis(), name, rgb?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_GetColor3d_10(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a vtkColor3d class.
	/// The color black is returned if the color is not found.
	/// </summary>
	public vtkColor3d GetColor3d(string name)
	{
		vtkColor3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_GetColor3d_10(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_GetColor3ub_11(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a vtkColor3ub class.
	/// The color black is returned if the color is not found.
	/// </summary>
	public vtkColor3ub GetColor3ub(string name)
	{
		vtkColor3ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_GetColor3ub_11(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor3ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_GetColor4d_12(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a vtkColor4d class.
	/// The color black is returned if the color is not found.
	/// </summary>
	public vtkColor4d GetColor4d(string name)
	{
		vtkColor4d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_GetColor4d_12(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_GetColor4ub_13(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a vtkColor4ub class.
	/// The color black is returned if the color is not found.
	/// </summary>
	public vtkColor4ub GetColor4ub(string name)
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_GetColor4ub_13(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkNamedColors_GetColorNames_14(HandleRef pThis);

	/// <summary>
	/// Return a string of color names with each name
	/// delimited by a line feed.
	/// This is easily parsed by the user into whatever
	/// data structure they require.
	/// Examples for parsing are provided in:
	/// TestNamedColors.cxx and TestNamedColorsIntegration.py
	/// </summary>
	public string GetColorNames()
	{
		return vtkNamedColors_GetColorNames_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColorNames_15(HandleRef pThis, HandleRef colorNames);

	/// <summary>
	/// Return a string array of color names.
	/// </summary>
	public void GetColorNames(vtkStringArray colorNames)
	{
		vtkNamedColors_GetColorNames_15(GetCppThis(), colorNames?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_GetColorRGB_16(HandleRef pThis, string name, IntPtr rgb);

	/// <summary>
	/// Get the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is returned as a double array:
	/// [red, green, blue]. The range of each element is 0...1.
	/// The color black is returned if the color is not found.
	/// </summary>
	public void GetColorRGB(string name, IntPtr rgb)
	{
		vtkNamedColors_GetColorRGB_16(GetCppThis(), name, rgb);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNamedColors_GetNumberOfColors_17(HandleRef pThis);

	/// <summary>
	/// Get the number of colors.
	/// </summary>
	public int GetNumberOfColors()
	{
		return vtkNamedColors_GetNumberOfColors_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNamedColors_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNamedColors_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNamedColors_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNamedColors_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkNamedColors_GetSynonyms_20(HandleRef pThis);

	/// <summary>
	/// Return a string of synonyms such as
	/// cyan/aqua and magenta/fuchsia.
	/// The string is formatted such that a single line feed delimits
	/// each color in the synonym and a double line feed delimits each
	/// synonym.
	/// Warning this could take a long time for very large color maps.
	/// This is easily parsed by the user into whatever
	/// data structure they require.
	/// </summary>
	public string GetSynonyms()
	{
		return vtkNamedColors_GetSynonyms_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_HTMLColorToRGB_21(HandleRef pThis, string colorString, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a vtkColor3ub instance from an HTML color string in any of
	/// the following formats:
	/// - \#RGB
	/// - \#RRGGBB
	/// - rgb(r, g, b)
	/// - rgba(r, g, b, a)
	/// - a CSS3 color name, e.g. "steelblue"
	/// If the string argument defines a color using one of the above formats
	/// the method returns the successfully parsed color else returns the color
	/// black.
	/// </summary>
	public vtkColor3ub HTMLColorToRGB(string colorString)
	{
		vtkColor3ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_HTMLColorToRGB_21(GetCppThis(), colorString, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor3ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_HTMLColorToRGBA_22(HandleRef pThis, string colorString, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a vtkColor4ub instance from an HTML color string in any of
	/// the following formats:
	/// - \#RGB
	/// - \#RRGGBB
	/// - rgb(r, g, b)
	/// - rgba(r, g, b, a)
	/// - a CSS3 color name, e.g. "steelblue"
	/// If the string argument defines a color using one of the above formats
	/// the method returns the successfully parsed color else returns a color
	/// equal to `rgba(0, 0, 0, 0)`.
	/// </summary>
	public vtkColor4ub HTMLColorToRGBA(string colorString)
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_HTMLColorToRGBA_22(GetCppThis(), colorString, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNamedColors_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNamedColors_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNamedColors_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNamedColors_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNamedColors NewInstance()
	{
		vtkNamedColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNamedColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkNamedColors_RGBAToHTMLColor_27(HandleRef pThis, HandleRef rgba);

	/// <summary>
	/// Given a vtkColor4ub instance as input color return a valid HTML color
	/// string in the `rgba(r, g, b, a)` format.
	/// </summary>
	public string RGBAToHTMLColor(vtkColor4ub rgba)
	{
		return vtkNamedColors_RGBAToHTMLColor_27(GetCppThis(), rgba?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkNamedColors_RGBToHTMLColor_28(HandleRef pThis, HandleRef rgb);

	/// <summary>
	/// Given a vtkColor3ub instance as input color return a valid HTML color
	/// string in the `#RRGGBB` format.
	/// </summary>
	public string RGBToHTMLColor(vtkColor3ub rgb)
	{
		return vtkNamedColors_RGBToHTMLColor_28(GetCppThis(), rgb?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_RemoveColor_29(HandleRef pThis, string name);

	/// <summary>
	/// Remove the color by name.
	/// The name is treated as being case-insensitive.
	/// Examples for parsing are provided in:
	/// TestNamedColors.cxx and TestNamedColorsIntegration.py
	/// </summary>
	public void RemoveColor(string name)
	{
		vtkNamedColors_RemoveColor_29(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_ResetColors_30(HandleRef pThis);

	/// <summary>
	/// Reset the colors in the color map to the original colors.
	/// Any colors inserted by the user will be lost.
	/// </summary>
	public void ResetColors()
	{
		vtkNamedColors_ResetColors_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNamedColors_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNamedColors SafeDownCast(vtkObjectBase o)
	{
		vtkNamedColors vtkNamedColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNamedColors_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNamedColors2 = (vtkNamedColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNamedColors2.Register(null);
			}
		}
		return vtkNamedColors2;
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_SetColor_32(HandleRef pThis, string name, ref byte r, ref byte g, ref byte b, ref byte a);

	/// <summary>
	/// Set the color by name.
	/// The name is treated as being case-insensitive.
	/// The range of each color is 0...255.
	/// No color is set if the name is empty.
	/// </summary>
	public virtual void SetColor(string name, ref byte r, ref byte g, ref byte b, ref byte a)
	{
		vtkNamedColors_SetColor_32(GetCppThis(), name, ref r, ref g, ref b, ref a);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_SetColor_33(HandleRef pThis, string name, ref double r, ref double g, ref double b, ref double a);

	/// <summary>
	/// Set the color by name.
	/// The name is treated as being case-insensitive.
	/// The range of each color is 0...1.
	/// No color is set if the name is empty.
	/// </summary>
	public virtual void SetColor(string name, ref double r, ref double g, ref double b, ref double a)
	{
		vtkNamedColors_SetColor_33(GetCppThis(), name, ref r, ref g, ref b, ref a);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_SetColor_34(HandleRef pThis, string name, IntPtr rgba);

	/// <summary>
	/// Set the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is an unsigned char array:
	/// [red, green, blue, alpha]. The range of each element is 0...255.
	/// The user must ensure that the color array size is 4.
	/// No color is set if the name is empty.
	/// </summary>
	public virtual void SetColor(string name, IntPtr rgba)
	{
		vtkNamedColors_SetColor_34(GetCppThis(), name, rgba);
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_SetColor_35(HandleRef pThis, string name, HandleRef rgba);

	/// <summary>
	/// Set the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is a vtkColor4ub class.
	/// No color is set if the name is empty.
	/// </summary>
	public virtual void SetColor(string name, vtkColor4ub rgba)
	{
		vtkNamedColors_SetColor_35(GetCppThis(), name, rgba?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_SetColor_36(HandleRef pThis, string name, HandleRef rgb);

	/// <summary>
	/// Set the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is a vtkColor3ub class.
	/// No color is set if the name is empty.
	/// </summary>
	public virtual void SetColor(string name, vtkColor3ub rgb)
	{
		vtkNamedColors_SetColor_36(GetCppThis(), name, rgb?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_SetColor_37(HandleRef pThis, string name, HandleRef rgba);

	/// <summary>
	/// Set the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is a vtkColor4d class.
	/// No color is set if the name is empty.
	/// </summary>
	public virtual void SetColor(string name, vtkColor4d rgba)
	{
		vtkNamedColors_SetColor_37(GetCppThis(), name, rgba?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_SetColor_38(HandleRef pThis, string name, HandleRef rgb);

	/// <summary>
	/// Set the color by name.
	/// The name is treated as being case-insensitive.
	/// The color is a vtkColor3d class.
	/// No color is set if the name is empty.
	/// </summary>
	public virtual void SetColor(string name, vtkColor3d rgb)
	{
		vtkNamedColors_SetColor_38(GetCppThis(), name, rgb?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNamedColors_SetColor_39(HandleRef pThis, string name, string htmlString);

	/// <summary>
	/// Set the color by name.
	/// The name is treated as being case-insensitive.
	/// The color must be a valid HTML color string.
	/// No color is set if the name is empty or if `htmlString` is not a valid
	/// HTML color string.
	/// </summary>
	public void SetColor(string name, string htmlString)
	{
		vtkNamedColors_SetColor_39(GetCppThis(), name, htmlString);
	}
}
