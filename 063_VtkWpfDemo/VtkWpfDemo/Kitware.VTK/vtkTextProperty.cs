using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextProperty
/// </summary>
/// <remarks>
///    represent text properties.
///
/// vtkTextProperty is an object that represents text properties.
/// The primary properties that can be set are color, opacity, font size,
/// font family horizontal and vertical justification, bold/italic/shadow
/// styles.
/// </remarks>
/// <seealso>
///
/// vtkTextMapper vtkTextActor vtkLegendBoxActor vtkCaptionActor2D
/// </seealso>
public class vtkTextProperty : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextProperty";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextProperty()
	{
		MRClassNameKey = "class vtkTextProperty";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextProperty"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new text property with font size 12, bold off, italic off,
	/// and Arial font.
	/// </summary>
	public new static vtkTextProperty New()
	{
		vtkTextProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a new text property with font size 12, bold off, italic off,
	/// and Arial font.
	/// </summary>
	public vtkTextProperty()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTextProperty_BoldOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable text bolding.
	/// </summary>
	public virtual void BoldOff()
	{
		vtkTextProperty_BoldOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_BoldOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable text bolding.
	/// </summary>
	public virtual void BoldOn()
	{
		vtkTextProperty_BoldOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_FrameOff_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable text frame.
	/// </summary>
	public virtual void FrameOff()
	{
		vtkTextProperty_FrameOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_FrameOn_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable text frame.
	/// </summary>
	public virtual void FrameOn()
	{
		vtkTextProperty_FrameOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetBackgroundColor_05(HandleRef pThis);

	/// <summary>
	/// The background color.
	/// </summary>
	public virtual double[] GetBackgroundColor()
	{
		IntPtr intPtr = vtkTextProperty_GetBackgroundColor_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetBackgroundColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The background color.
	/// </summary>
	public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTextProperty_GetBackgroundColor_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetBackgroundColor_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The background color.
	/// </summary>
	public virtual void GetBackgroundColor(IntPtr _arg)
	{
		vtkTextProperty_GetBackgroundColor_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetBackgroundOpacity_08(HandleRef pThis);

	/// <summary>
	/// The background opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetBackgroundOpacity()
	{
		return vtkTextProperty_GetBackgroundOpacity_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetBackgroundOpacityMaxValue_09(HandleRef pThis);

	/// <summary>
	/// The background opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetBackgroundOpacityMaxValue()
	{
		return vtkTextProperty_GetBackgroundOpacityMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetBackgroundOpacityMinValue_10(HandleRef pThis);

	/// <summary>
	/// The background opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetBackgroundOpacityMinValue()
	{
		return vtkTextProperty_GetBackgroundOpacityMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetBackgroundRGBA_11(HandleRef pThis, IntPtr rgba);

	/// <summary>
	/// Convenience method to get the background color and the opacity at once
	/// </summary>
	public void GetBackgroundRGBA(IntPtr rgba)
	{
		vtkTextProperty_GetBackgroundRGBA_11(GetCppThis(), rgba);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetBackgroundRGBA_12(HandleRef pThis, ref double r, ref double g, ref double b, ref double a);

	/// <summary>
	/// Convenience method to get the background color and the opacity at once
	/// </summary>
	public void GetBackgroundRGBA(ref double r, ref double g, ref double b, ref double a)
	{
		vtkTextProperty_GetBackgroundRGBA_12(GetCppThis(), ref r, ref g, ref b, ref a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetBold_13(HandleRef pThis);

	/// <summary>
	/// Enable/disable text bolding.
	/// </summary>
	public virtual int GetBold()
	{
		return vtkTextProperty_GetBold_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetCellOffset_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal offset between cells.
	/// Only used by MatplotlibMathTextUtilities
	/// </summary>
	public virtual double GetCellOffset()
	{
		return vtkTextProperty_GetCellOffset_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetColor_15(HandleRef pThis);

	/// <summary>
	/// Set the color of the text.
	/// </summary>
	public virtual double[] GetColor()
	{
		IntPtr intPtr = vtkTextProperty_GetColor_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetColor_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color of the text.
	/// </summary>
	public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTextProperty_GetColor_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetColor_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the text.
	/// </summary>
	public virtual void GetColor(IntPtr _arg)
	{
		vtkTextProperty_GetColor_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFontFamily_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public int GetFontFamily()
	{
		return vtkTextProperty_GetFontFamily_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetFontFamilyAsString_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public virtual string GetFontFamilyAsString()
	{
		return Marshal.PtrToStringAnsi(vtkTextProperty_GetFontFamilyAsString_19(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetFontFamilyAsString_20(int f);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public static string GetFontFamilyAsString(int f)
	{
		return Marshal.PtrToStringAnsi(vtkTextProperty_GetFontFamilyAsString_20(f));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFontFamilyFromString_21(string f);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public static int GetFontFamilyFromString(string f)
	{
		return vtkTextProperty_GetFontFamilyFromString_21(f);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFontFamilyMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public int GetFontFamilyMinValue()
	{
		return vtkTextProperty_GetFontFamilyMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetFontFile_23(HandleRef pThis);

	/// <summary>
	/// The absolute filepath to a local file containing a freetype-readable font
	/// if GetFontFamily() return VTK_FONT_FILE. The result is undefined for other
	/// values of GetFontFamily().
	/// </summary>
	public virtual string GetFontFile()
	{
		return Marshal.PtrToStringAnsi(vtkTextProperty_GetFontFile_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFontSize_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the font size (in points).
	/// </summary>
	public virtual int GetFontSize()
	{
		return vtkTextProperty_GetFontSize_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFontSizeMaxValue_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the font size (in points).
	/// </summary>
	public virtual int GetFontSizeMaxValue()
	{
		return vtkTextProperty_GetFontSizeMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFontSizeMinValue_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the font size (in points).
	/// </summary>
	public virtual int GetFontSizeMinValue()
	{
		return vtkTextProperty_GetFontSizeMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFrame_27(HandleRef pThis);

	/// <summary>
	/// Enable/disable text frame.
	/// </summary>
	public virtual int GetFrame()
	{
		return vtkTextProperty_GetFrame_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetFrameColor_28(HandleRef pThis);

	/// <summary>
	/// The frame color.
	/// </summary>
	public virtual double[] GetFrameColor()
	{
		IntPtr intPtr = vtkTextProperty_GetFrameColor_28(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetFrameColor_29(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The frame color.
	/// </summary>
	public virtual void GetFrameColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTextProperty_GetFrameColor_29(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetFrameColor_30(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The frame color.
	/// </summary>
	public virtual void GetFrameColor(IntPtr _arg)
	{
		vtkTextProperty_GetFrameColor_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFrameWidth_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the frame. The width is expressed in pixels.
	/// The default is 1 pixel.
	/// </summary>
	public virtual int GetFrameWidth()
	{
		return vtkTextProperty_GetFrameWidth_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFrameWidthMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the frame. The width is expressed in pixels.
	/// The default is 1 pixel.
	/// </summary>
	public virtual int GetFrameWidthMaxValue()
	{
		return vtkTextProperty_GetFrameWidthMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetFrameWidthMinValue_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the frame. The width is expressed in pixels.
	/// The default is 1 pixel.
	/// </summary>
	public virtual int GetFrameWidthMinValue()
	{
		return vtkTextProperty_GetFrameWidthMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetInteriorLinesColor_34(HandleRef pThis);

	/// <summary>
	/// Set the color of the interior lines between cells.
	/// Default is black (0.0, 0.0, 0.0).
	/// </summary>
	public virtual double[] GetInteriorLinesColor()
	{
		IntPtr intPtr = vtkTextProperty_GetInteriorLinesColor_34(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetInteriorLinesColor_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color of the interior lines between cells.
	/// Default is black (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void GetInteriorLinesColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTextProperty_GetInteriorLinesColor_35(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetInteriorLinesColor_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the interior lines between cells.
	/// Default is black (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void GetInteriorLinesColor(IntPtr _arg)
	{
		vtkTextProperty_GetInteriorLinesColor_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTextProperty_GetInteriorLinesVisibility_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the visibility of the interior lines between cells.
	/// Default is false.
	/// </summary>
	public virtual bool GetInteriorLinesVisibility()
	{
		return (vtkTextProperty_GetInteriorLinesVisibility_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetInteriorLinesWidth_38(HandleRef pThis);

	/// <summary>
	/// Set the width (in pixels) of the interior lines between cells.
	/// Default is 1.
	/// </summary>
	public virtual int GetInteriorLinesWidth()
	{
		return vtkTextProperty_GetInteriorLinesWidth_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetItalic_39(HandleRef pThis);

	/// <summary>
	/// Enable/disable text italic.
	/// </summary>
	public virtual int GetItalic()
	{
		return vtkTextProperty_GetItalic_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetJustification_40(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal justification to left (default), centered,
	/// or right.
	/// </summary>
	public virtual int GetJustification()
	{
		return vtkTextProperty_GetJustification_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetJustificationAsString_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal justification to left (default), centered,
	/// or right.
	/// </summary>
	public string GetJustificationAsString()
	{
		return Marshal.PtrToStringAnsi(vtkTextProperty_GetJustificationAsString_41(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetJustificationMaxValue_42(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal justification to left (default), centered,
	/// or right.
	/// </summary>
	public virtual int GetJustificationMaxValue()
	{
		return vtkTextProperty_GetJustificationMaxValue_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetJustificationMinValue_43(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal justification to left (default), centered,
	/// or right.
	/// </summary>
	public virtual int GetJustificationMinValue()
	{
		return vtkTextProperty_GetJustificationMinValue_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetLineOffset_44(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical offset (measured in pixels).
	/// </summary>
	public virtual double GetLineOffset()
	{
		return vtkTextProperty_GetLineOffset_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetLineSpacing_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the (extra) spacing between lines,
	/// expressed as a text height multiplication factor.
	/// </summary>
	public virtual double GetLineSpacing()
	{
		return vtkTextProperty_GetLineSpacing_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextProperty_GetNumberOfGenerationsFromBase_46(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextProperty_GetNumberOfGenerationsFromBase_46(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextProperty_GetNumberOfGenerationsFromBaseType_47(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextProperty_GetNumberOfGenerationsFromBaseType_47(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetOpacity_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the text's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetOpacity()
	{
		return vtkTextProperty_GetOpacity_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetOpacityMaxValue_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the text's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetOpacityMaxValue()
	{
		return vtkTextProperty_GetOpacityMaxValue_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetOpacityMinValue_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the text's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual double GetOpacityMinValue()
	{
		return vtkTextProperty_GetOpacityMinValue_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTextProperty_GetOrientation_51(HandleRef pThis);

	/// <summary>
	/// Set/Get the text's orientation (in degrees).
	/// </summary>
	public virtual double GetOrientation()
	{
		return vtkTextProperty_GetOrientation_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetShadow_52(HandleRef pThis);

	/// <summary>
	/// Enable/disable text shadow.
	/// </summary>
	public virtual int GetShadow()
	{
		return vtkTextProperty_GetShadow_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetShadowColor_53(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Get the shadow color. It is computed from the Color ivar
	/// </summary>
	public void GetShadowColor(IntPtr color)
	{
		vtkTextProperty_GetShadowColor_53(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetShadowOffset_54(HandleRef pThis);

	/// <summary>
	/// Set/Get the shadow offset, i.e. the distance from the text to
	/// its shadow, in the same unit as FontSize.
	/// </summary>
	public virtual int[] GetShadowOffset()
	{
		IntPtr intPtr = vtkTextProperty_GetShadowOffset_54(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_GetShadowOffset_55(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the shadow offset, i.e. the distance from the text to
	/// its shadow, in the same unit as FontSize.
	/// </summary>
	public virtual void GetShadowOffset(IntPtr data)
	{
		vtkTextProperty_GetShadowOffset_55(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetUseTightBoundingBox_56(HandleRef pThis);

	/// <summary>
	/// If this property is on, text is aligned to drawn pixels not to font metrix.
	/// If the text does not include descents, the bounding box will not extend below
	/// the baseline. This option can be used to get centered labels. It does not
	/// work well if the string changes as the string position will move around.
	/// </summary>
	public virtual int GetUseTightBoundingBox()
	{
		return vtkTextProperty_GetUseTightBoundingBox_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetVerticalJustification_57(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical justification to bottom (default), middle,
	/// or top.
	/// </summary>
	public virtual int GetVerticalJustification()
	{
		return vtkTextProperty_GetVerticalJustification_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_GetVerticalJustificationAsString_58(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical justification to bottom (default), middle,
	/// or top.
	/// </summary>
	public string GetVerticalJustificationAsString()
	{
		return Marshal.PtrToStringAnsi(vtkTextProperty_GetVerticalJustificationAsString_58(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetVerticalJustificationMaxValue_59(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical justification to bottom (default), middle,
	/// or top.
	/// </summary>
	public virtual int GetVerticalJustificationMaxValue()
	{
		return vtkTextProperty_GetVerticalJustificationMaxValue_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_GetVerticalJustificationMinValue_60(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical justification to bottom (default), middle,
	/// or top.
	/// </summary>
	public virtual int GetVerticalJustificationMinValue()
	{
		return vtkTextProperty_GetVerticalJustificationMinValue_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_IsA_61(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextProperty_IsA_61(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextProperty_IsTypeOf_62(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextProperty_IsTypeOf_62(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_ItalicOff_63(HandleRef pThis);

	/// <summary>
	/// Enable/disable text italic.
	/// </summary>
	public virtual void ItalicOff()
	{
		vtkTextProperty_ItalicOff_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_ItalicOn_64(HandleRef pThis);

	/// <summary>
	/// Enable/disable text italic.
	/// </summary>
	public virtual void ItalicOn()
	{
		vtkTextProperty_ItalicOn_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextProperty NewInstance()
	{
		vtkTextProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextProperty_NewInstance_66(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextProperty_SafeDownCast_67(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextProperty SafeDownCast(vtkObjectBase o)
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextProperty_SafeDownCast_67(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetBackgroundColor_68(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The background color.
	/// </summary>
	public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
	{
		vtkTextProperty_SetBackgroundColor_68(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetBackgroundColor_69(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The background color.
	/// </summary>
	public virtual void SetBackgroundColor(IntPtr _arg)
	{
		vtkTextProperty_SetBackgroundColor_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetBackgroundOpacity_70(HandleRef pThis, double _arg);

	/// <summary>
	/// The background opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual void SetBackgroundOpacity(double _arg)
	{
		vtkTextProperty_SetBackgroundOpacity_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetBackgroundRGBA_71(HandleRef pThis, IntPtr rgba);

	/// <summary>
	/// Convenience method to set the background color and the opacity at once
	/// </summary>
	public void SetBackgroundRGBA(IntPtr rgba)
	{
		vtkTextProperty_SetBackgroundRGBA_71(GetCppThis(), rgba);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetBackgroundRGBA_72(HandleRef pThis, double r, double g, double b, double a);

	/// <summary>
	/// Convenience method to set the background color and the opacity at once
	/// </summary>
	public void SetBackgroundRGBA(double r, double g, double b, double a)
	{
		vtkTextProperty_SetBackgroundRGBA_72(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetBold_73(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable text bolding.
	/// </summary>
	public virtual void SetBold(int _arg)
	{
		vtkTextProperty_SetBold_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetCellOffset_74(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the horizontal offset between cells.
	/// Only used by MatplotlibMathTextUtilities
	/// </summary>
	public virtual void SetCellOffset(double _arg)
	{
		vtkTextProperty_SetCellOffset_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetColor_75(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color of the text.
	/// </summary>
	public virtual void SetColor(double _arg1, double _arg2, double _arg3)
	{
		vtkTextProperty_SetColor_75(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetColor_76(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the text.
	/// </summary>
	public virtual void SetColor(IntPtr _arg)
	{
		vtkTextProperty_SetColor_76(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFontFamily_77(HandleRef pThis, int t);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public void SetFontFamily(int t)
	{
		vtkTextProperty_SetFontFamily_77(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFontFamilyAsString_78(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public virtual void SetFontFamilyAsString(string _arg)
	{
		vtkTextProperty_SetFontFamilyAsString_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFontFamilyToArial_79(HandleRef pThis);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public void SetFontFamilyToArial()
	{
		vtkTextProperty_SetFontFamilyToArial_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFontFamilyToCourier_80(HandleRef pThis);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public void SetFontFamilyToCourier()
	{
		vtkTextProperty_SetFontFamilyToCourier_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFontFamilyToTimes_81(HandleRef pThis);

	/// <summary>
	/// Set/Get the font family. Supports legacy three font family system.
	/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
	/// string returned by GetFontFile() must be an absolute filepath
	/// to a local FreeType compatible font.
	/// </summary>
	public void SetFontFamilyToTimes()
	{
		vtkTextProperty_SetFontFamilyToTimes_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFontFile_82(HandleRef pThis, string _arg);

	/// <summary>
	/// The absolute filepath to a local file containing a freetype-readable font
	/// if GetFontFamily() return VTK_FONT_FILE. The result is undefined for other
	/// values of GetFontFamily().
	/// </summary>
	public virtual void SetFontFile(string _arg)
	{
		vtkTextProperty_SetFontFile_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFontSize_83(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the font size (in points).
	/// </summary>
	public virtual void SetFontSize(int _arg)
	{
		vtkTextProperty_SetFontSize_83(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFrame_84(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable text frame.
	/// </summary>
	public virtual void SetFrame(int _arg)
	{
		vtkTextProperty_SetFrame_84(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFrameColor_85(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The frame color.
	/// </summary>
	public virtual void SetFrameColor(double _arg1, double _arg2, double _arg3)
	{
		vtkTextProperty_SetFrameColor_85(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFrameColor_86(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The frame color.
	/// </summary>
	public virtual void SetFrameColor(IntPtr _arg)
	{
		vtkTextProperty_SetFrameColor_86(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetFrameWidth_87(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the width of the frame. The width is expressed in pixels.
	/// The default is 1 pixel.
	/// </summary>
	public virtual void SetFrameWidth(int _arg)
	{
		vtkTextProperty_SetFrameWidth_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetInteriorLinesColor_88(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color of the interior lines between cells.
	/// Default is black (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void SetInteriorLinesColor(double _arg1, double _arg2, double _arg3)
	{
		vtkTextProperty_SetInteriorLinesColor_88(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetInteriorLinesColor_89(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the interior lines between cells.
	/// Default is black (0.0, 0.0, 0.0).
	/// </summary>
	public virtual void SetInteriorLinesColor(IntPtr _arg)
	{
		vtkTextProperty_SetInteriorLinesColor_89(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetInteriorLinesVisibility_90(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the visibility of the interior lines between cells.
	/// Default is false.
	/// </summary>
	public virtual void SetInteriorLinesVisibility(bool _arg)
	{
		vtkTextProperty_SetInteriorLinesVisibility_90(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetInteriorLinesWidth_91(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the width (in pixels) of the interior lines between cells.
	/// Default is 1.
	/// </summary>
	public virtual void SetInteriorLinesWidth(int _arg)
	{
		vtkTextProperty_SetInteriorLinesWidth_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetItalic_92(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable text italic.
	/// </summary>
	public virtual void SetItalic(int _arg)
	{
		vtkTextProperty_SetItalic_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetJustification_93(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the horizontal justification to left (default), centered,
	/// or right.
	/// </summary>
	public virtual void SetJustification(int _arg)
	{
		vtkTextProperty_SetJustification_93(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetJustificationToCentered_94(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal justification to left (default), centered,
	/// or right.
	/// </summary>
	public void SetJustificationToCentered()
	{
		vtkTextProperty_SetJustificationToCentered_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetJustificationToLeft_95(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal justification to left (default), centered,
	/// or right.
	/// </summary>
	public void SetJustificationToLeft()
	{
		vtkTextProperty_SetJustificationToLeft_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetJustificationToRight_96(HandleRef pThis);

	/// <summary>
	/// Set/Get the horizontal justification to left (default), centered,
	/// or right.
	/// </summary>
	public void SetJustificationToRight()
	{
		vtkTextProperty_SetJustificationToRight_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetLineOffset_97(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the vertical offset (measured in pixels).
	/// </summary>
	public virtual void SetLineOffset(double _arg)
	{
		vtkTextProperty_SetLineOffset_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetLineSpacing_98(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the (extra) spacing between lines,
	/// expressed as a text height multiplication factor.
	/// </summary>
	public virtual void SetLineSpacing(double _arg)
	{
		vtkTextProperty_SetLineSpacing_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetOpacity_99(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the text's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent.
	/// </summary>
	public virtual void SetOpacity(double _arg)
	{
		vtkTextProperty_SetOpacity_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetOrientation_100(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the text's orientation (in degrees).
	/// </summary>
	public virtual void SetOrientation(double _arg)
	{
		vtkTextProperty_SetOrientation_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetShadow_101(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable text shadow.
	/// </summary>
	public virtual void SetShadow(int _arg)
	{
		vtkTextProperty_SetShadow_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetShadowOffset_102(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/Get the shadow offset, i.e. the distance from the text to
	/// its shadow, in the same unit as FontSize.
	/// </summary>
	public virtual void SetShadowOffset(int _arg1, int _arg2)
	{
		vtkTextProperty_SetShadowOffset_102(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetShadowOffset_103(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the shadow offset, i.e. the distance from the text to
	/// its shadow, in the same unit as FontSize.
	/// </summary>
	public void SetShadowOffset(IntPtr _arg)
	{
		vtkTextProperty_SetShadowOffset_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetUseTightBoundingBox_104(HandleRef pThis, int _arg);

	/// <summary>
	/// If this property is on, text is aligned to drawn pixels not to font metrix.
	/// If the text does not include descents, the bounding box will not extend below
	/// the baseline. This option can be used to get centered labels. It does not
	/// work well if the string changes as the string position will move around.
	/// </summary>
	public virtual void SetUseTightBoundingBox(int _arg)
	{
		vtkTextProperty_SetUseTightBoundingBox_104(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetVerticalJustification_105(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the vertical justification to bottom (default), middle,
	/// or top.
	/// </summary>
	public virtual void SetVerticalJustification(int _arg)
	{
		vtkTextProperty_SetVerticalJustification_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetVerticalJustificationToBottom_106(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical justification to bottom (default), middle,
	/// or top.
	/// </summary>
	public void SetVerticalJustificationToBottom()
	{
		vtkTextProperty_SetVerticalJustificationToBottom_106(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetVerticalJustificationToCentered_107(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical justification to bottom (default), middle,
	/// or top.
	/// </summary>
	public void SetVerticalJustificationToCentered()
	{
		vtkTextProperty_SetVerticalJustificationToCentered_107(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_SetVerticalJustificationToTop_108(HandleRef pThis);

	/// <summary>
	/// Set/Get the vertical justification to bottom (default), middle,
	/// or top.
	/// </summary>
	public void SetVerticalJustificationToTop()
	{
		vtkTextProperty_SetVerticalJustificationToTop_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_ShadowOff_109(HandleRef pThis);

	/// <summary>
	/// Enable/disable text shadow.
	/// </summary>
	public virtual void ShadowOff()
	{
		vtkTextProperty_ShadowOff_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_ShadowOn_110(HandleRef pThis);

	/// <summary>
	/// Enable/disable text shadow.
	/// </summary>
	public virtual void ShadowOn()
	{
		vtkTextProperty_ShadowOn_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_ShallowCopy_111(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// Shallow copy of a text property.
	/// </summary>
	public void ShallowCopy(vtkTextProperty tprop)
	{
		vtkTextProperty_ShallowCopy_111(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_UseTightBoundingBoxOff_112(HandleRef pThis);

	/// <summary>
	/// If this property is on, text is aligned to drawn pixels not to font metrix.
	/// If the text does not include descents, the bounding box will not extend below
	/// the baseline. This option can be used to get centered labels. It does not
	/// work well if the string changes as the string position will move around.
	/// </summary>
	public virtual void UseTightBoundingBoxOff()
	{
		vtkTextProperty_UseTightBoundingBoxOff_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextProperty_UseTightBoundingBoxOn_113(HandleRef pThis);

	/// <summary>
	/// If this property is on, text is aligned to drawn pixels not to font metrix.
	/// If the text does not include descents, the bounding box will not extend below
	/// the baseline. This option can be used to get centered labels. It does not
	/// work well if the string changes as the string position will move around.
	/// </summary>
	public virtual void UseTightBoundingBoxOn()
	{
		vtkTextProperty_UseTightBoundingBoxOn_113(GetCppThis());
	}
}
