using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLegendBoxActor
/// </summary>
/// <remarks>
///    draw symbols with text
///
/// vtkLegendBoxActor is used to associate a symbol with a text string.
/// The user specifies a vtkPolyData to use as the symbol, and a string
/// associated with the symbol. The actor can then be placed in the scene
/// in the same way that any other vtkActor2D can be used.
///
/// To use this class, you must define the position of the legend box by using
/// the superclasses' vtkActor2D::Position coordinate and
/// Position2 coordinate. Then define the set of symbols and text strings that
/// make up the menu box. The font attributes of the entries can be set through
/// the vtkTextProperty associated to this actor. The class will
/// scale the symbols and text to fit in the legend box defined by
/// (Position,Position2). Optional features like turning on a border line and
/// setting the spacing between the border and the symbols/text can also be
/// set.
///
/// </remarks>
/// <seealso>
///
/// vtkXYPlotActor vtkActor2D vtkGlyphSource2D
/// </seealso>
public class vtkLegendBoxActor : vtkActor2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLegendBoxActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLegendBoxActor()
	{
		MRClassNameKey = "class vtkLegendBoxActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLegendBoxActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLegendBoxActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with a rectangle in normaled view coordinates
	/// of (0.2,0.85, 0.8, 0.95).
	/// </summary>
	public new static vtkLegendBoxActor New()
	{
		vtkLegendBoxActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendBoxActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with a rectangle in normaled view coordinates
	/// of (0.2,0.85, 0.8, 0.95).
	/// </summary>
	public vtkLegendBoxActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLegendBoxActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_BorderOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether a border will be drawn
	/// around the legend box.
	/// </summary>
	public virtual void BorderOff()
	{
		vtkLegendBoxActor_BorderOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_BorderOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether a border will be drawn
	/// around the legend box.
	/// </summary>
	public virtual void BorderOn()
	{
		vtkLegendBoxActor_BorderOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_BoxOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether a box will be drawn/filled
	/// corresponding to the legend box.
	/// </summary>
	public virtual void BoxOff()
	{
		vtkLegendBoxActor_BoxOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_BoxOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether a box will be drawn/filled
	/// corresponding to the legend box.
	/// </summary>
	public virtual void BoxOn()
	{
		vtkLegendBoxActor_BoxOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_GetBackgroundColor_05(HandleRef pThis);

	/// <summary>
	/// Set/Get background color.
	/// Default is: (0.3, 0.3, 0.3).
	/// </summary>
	public virtual double[] GetBackgroundColor()
	{
		IntPtr intPtr = vtkLegendBoxActor_GetBackgroundColor_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_GetBackgroundColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get background color.
	/// Default is: (0.3, 0.3, 0.3).
	/// </summary>
	public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkLegendBoxActor_GetBackgroundColor_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_GetBackgroundColor_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get background color.
	/// Default is: (0.3, 0.3, 0.3).
	/// </summary>
	public virtual void GetBackgroundColor(IntPtr _arg)
	{
		vtkLegendBoxActor_GetBackgroundColor_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLegendBoxActor_GetBackgroundOpacity_08(HandleRef pThis);

	/// <summary>
	/// Set/Get background opacity.
	/// Default is: 1.0
	/// </summary>
	public virtual double GetBackgroundOpacity()
	{
		return vtkLegendBoxActor_GetBackgroundOpacity_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLegendBoxActor_GetBackgroundOpacityMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get background opacity.
	/// Default is: 1.0
	/// </summary>
	public virtual double GetBackgroundOpacityMaxValue()
	{
		return vtkLegendBoxActor_GetBackgroundOpacityMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLegendBoxActor_GetBackgroundOpacityMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get background opacity.
	/// Default is: 1.0
	/// </summary>
	public virtual double GetBackgroundOpacityMinValue()
	{
		return vtkLegendBoxActor_GetBackgroundOpacityMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetBorder_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether a border will be drawn
	/// around the legend box.
	/// </summary>
	public virtual int GetBorder()
	{
		return vtkLegendBoxActor_GetBorder_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetBox_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether a box will be drawn/filled
	/// corresponding to the legend box.
	/// </summary>
	public virtual int GetBox()
	{
		return vtkLegendBoxActor_GetBox_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_GetBoxProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the box vtkProperty2D.
	/// </summary>
	public vtkProperty2D GetBoxProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendBoxActor_GetBoxProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_GetEntryColor_14(HandleRef pThis, int i);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public double[] GetEntryColor(int i)
	{
		IntPtr intPtr = vtkLegendBoxActor_GetEntryColor_14(GetCppThis(), i);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_GetEntryIcon_15(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public vtkImageData GetEntryIcon(int i)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendBoxActor_GetEntryIcon_15(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_GetEntryString_16(HandleRef pThis, int i);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public string GetEntryString(int i)
	{
		return Marshal.PtrToStringAnsi(vtkLegendBoxActor_GetEntryString_16(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_GetEntrySymbol_17(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public vtkPolyData GetEntrySymbol(int i)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendBoxActor_GetEntrySymbol_17(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_GetEntryTextProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual vtkTextProperty GetEntryTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendBoxActor_GetEntryTextProperty_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetLockBorder_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the border and legend
	/// placement is locked into the rectangle defined by (Position,Position2).
	/// If off, then the legend box will adjust its size so that the border
	/// fits nicely around the text and symbols. (The ivar is off by default.)
	/// Note: the legend box is guaranteed to lie within the original border
	/// definition.
	/// </summary>
	public virtual int GetLockBorder()
	{
		return vtkLegendBoxActor_GetLockBorder_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetNumberOfEntries_20(HandleRef pThis);

	/// <summary>
	/// Specify the number of entries in the legend box.
	/// </summary>
	public int GetNumberOfEntries()
	{
		return vtkLegendBoxActor_GetNumberOfEntries_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLegendBoxActor_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLegendBoxActor_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLegendBoxActor_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLegendBoxActor_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetPadding_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the legend entries and the border. The value
	/// is specified in pixels.
	/// </summary>
	public virtual int GetPadding()
	{
		return vtkLegendBoxActor_GetPadding_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetPaddingMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the legend entries and the border. The value
	/// is specified in pixels.
	/// </summary>
	public virtual int GetPaddingMaxValue()
	{
		return vtkLegendBoxActor_GetPaddingMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetPaddingMinValue_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the legend entries and the border. The value
	/// is specified in pixels.
	/// </summary>
	public virtual int GetPaddingMinValue()
	{
		return vtkLegendBoxActor_GetPaddingMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetScalarVisibility_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether the symbol's scalar data
	/// is used to color the symbol. If off, the color of the
	/// vtkLegendBoxActor is used.
	/// </summary>
	public virtual int GetScalarVisibility()
	{
		return vtkLegendBoxActor_GetScalarVisibility_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_GetUseBackground_27(HandleRef pThis);

	/// <summary>
	/// Turn on/off background.
	/// </summary>
	public virtual int GetUseBackground()
	{
		return vtkLegendBoxActor_GetUseBackground_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_HasTranslucentPolygonalGeometry_28(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkLegendBoxActor_HasTranslucentPolygonalGeometry_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLegendBoxActor_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLegendBoxActor_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_LockBorderOff_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the border and legend
	/// placement is locked into the rectangle defined by (Position,Position2).
	/// If off, then the legend box will adjust its size so that the border
	/// fits nicely around the text and symbols. (The ivar is off by default.)
	/// Note: the legend box is guaranteed to lie within the original border
	/// definition.
	/// </summary>
	public virtual void LockBorderOff()
	{
		vtkLegendBoxActor_LockBorderOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_LockBorderOn_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the flag that controls whether the border and legend
	/// placement is locked into the rectangle defined by (Position,Position2).
	/// If off, then the legend box will adjust its size so that the border
	/// fits nicely around the text and symbols. (The ivar is off by default.)
	/// Note: the legend box is guaranteed to lie within the original border
	/// definition.
	/// </summary>
	public virtual void LockBorderOn()
	{
		vtkLegendBoxActor_LockBorderOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLegendBoxActor NewInstance()
	{
		vtkLegendBoxActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendBoxActor_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_ReleaseGraphicsResources_35(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLegendBoxActor_ReleaseGraphicsResources_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_RenderOpaqueGeometry_36(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the legend box to the screen.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkLegendBoxActor_RenderOpaqueGeometry_36(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_RenderOverlay_37(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the legend box to the screen.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkLegendBoxActor_RenderOverlay_37(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLegendBoxActor_RenderTranslucentPolygonalGeometry_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the legend box to the screen.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkLegendBoxActor_RenderTranslucentPolygonalGeometry_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLegendBoxActor_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLegendBoxActor SafeDownCast(vtkObjectBase o)
	{
		vtkLegendBoxActor vtkLegendBoxActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLegendBoxActor_SafeDownCast_39(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLegendBoxActor2 = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLegendBoxActor2.Register(null);
			}
		}
		return vtkLegendBoxActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_ScalarVisibilityOff_40(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether the symbol's scalar data
	/// is used to color the symbol. If off, the color of the
	/// vtkLegendBoxActor is used.
	/// </summary>
	public virtual void ScalarVisibilityOff()
	{
		vtkLegendBoxActor_ScalarVisibilityOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_ScalarVisibilityOn_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off flag to control whether the symbol's scalar data
	/// is used to color the symbol. If off, the color of the
	/// vtkLegendBoxActor is used.
	/// </summary>
	public virtual void ScalarVisibilityOn()
	{
		vtkLegendBoxActor_ScalarVisibilityOn_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetBackgroundColor_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get background color.
	/// Default is: (0.3, 0.3, 0.3).
	/// </summary>
	public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
	{
		vtkLegendBoxActor_SetBackgroundColor_42(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetBackgroundColor_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get background color.
	/// Default is: (0.3, 0.3, 0.3).
	/// </summary>
	public virtual void SetBackgroundColor(IntPtr _arg)
	{
		vtkLegendBoxActor_SetBackgroundColor_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetBackgroundOpacity_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get background opacity.
	/// Default is: 1.0
	/// </summary>
	public virtual void SetBackgroundOpacity(double _arg)
	{
		vtkLegendBoxActor_SetBackgroundOpacity_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetBorder_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag that controls whether a border will be drawn
	/// around the legend box.
	/// </summary>
	public virtual void SetBorder(int _arg)
	{
		vtkLegendBoxActor_SetBorder_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetBox_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag that controls whether a box will be drawn/filled
	/// corresponding to the legend box.
	/// </summary>
	public virtual void SetBox(int _arg)
	{
		vtkLegendBoxActor_SetBox_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntry_47(HandleRef pThis, int i, HandleRef symbol, string arg2, IntPtr color);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public void SetEntry(int i, vtkPolyData symbol, string arg2, IntPtr color)
	{
		vtkLegendBoxActor_SetEntry_47(GetCppThis(), i, symbol?.GetCppThis() ?? default(HandleRef), arg2, color);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntry_48(HandleRef pThis, int i, HandleRef symbol, string arg2, IntPtr color);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public void SetEntry(int i, vtkImageData symbol, string arg2, IntPtr color)
	{
		vtkLegendBoxActor_SetEntry_48(GetCppThis(), i, symbol?.GetCppThis() ?? default(HandleRef), arg2, color);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntry_49(HandleRef pThis, int i, HandleRef symbol, HandleRef icon, string arg3, IntPtr color);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public void SetEntry(int i, vtkPolyData symbol, vtkImageData icon, string arg3, IntPtr color)
	{
		vtkLegendBoxActor_SetEntry_49(GetCppThis(), i, symbol?.GetCppThis() ?? default(HandleRef), icon?.GetCppThis() ?? default(HandleRef), arg3, color);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntryColor_50(HandleRef pThis, int i, IntPtr color);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public void SetEntryColor(int i, IntPtr color)
	{
		vtkLegendBoxActor_SetEntryColor_50(GetCppThis(), i, color);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntryColor_51(HandleRef pThis, int i, double r, double g, double b);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public void SetEntryColor(int i, double r, double g, double b)
	{
		vtkLegendBoxActor_SetEntryColor_51(GetCppThis(), i, r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntryIcon_52(HandleRef pThis, int i, HandleRef icon);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public void SetEntryIcon(int i, vtkImageData icon)
	{
		vtkLegendBoxActor_SetEntryIcon_52(GetCppThis(), i, icon?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntryString_53(HandleRef pThis, int i, string arg1);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public void SetEntryString(int i, string arg1)
	{
		vtkLegendBoxActor_SetEntryString_53(GetCppThis(), i, arg1);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntrySymbol_54(HandleRef pThis, int i, HandleRef symbol);

	/// <summary>
	/// Add an entry to the legend box. You must supply a vtkPolyData to be
	/// used as a symbol (it can be NULL) and a text string (which also can
	/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
	/// and the text is assumed to be a single line in height. Note that when
	/// this method is invoked previous entries are deleted. Also supply a text
	/// string and optionally a color. (If a color is not specified, then the
	/// entry color is the same as this actor's color.) (Note: use the set
	/// methods when you use SetNumberOfEntries().)
	/// </summary>
	public void SetEntrySymbol(int i, vtkPolyData symbol)
	{
		vtkLegendBoxActor_SetEntrySymbol_54(GetCppThis(), i, symbol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetEntryTextProperty_55(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual void SetEntryTextProperty(vtkTextProperty p)
	{
		vtkLegendBoxActor_SetEntryTextProperty_55(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetLockBorder_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the flag that controls whether the border and legend
	/// placement is locked into the rectangle defined by (Position,Position2).
	/// If off, then the legend box will adjust its size so that the border
	/// fits nicely around the text and symbols. (The ivar is off by default.)
	/// Note: the legend box is guaranteed to lie within the original border
	/// definition.
	/// </summary>
	public virtual void SetLockBorder(int _arg)
	{
		vtkLegendBoxActor_SetLockBorder_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetNumberOfEntries_57(HandleRef pThis, int num);

	/// <summary>
	/// Specify the number of entries in the legend box.
	/// </summary>
	public void SetNumberOfEntries(int num)
	{
		vtkLegendBoxActor_SetNumberOfEntries_57(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetPadding_58(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the padding between the legend entries and the border. The value
	/// is specified in pixels.
	/// </summary>
	public virtual void SetPadding(int _arg)
	{
		vtkLegendBoxActor_SetPadding_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetScalarVisibility_59(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off flag to control whether the symbol's scalar data
	/// is used to color the symbol. If off, the color of the
	/// vtkLegendBoxActor is used.
	/// </summary>
	public virtual void SetScalarVisibility(int _arg)
	{
		vtkLegendBoxActor_SetScalarVisibility_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_SetUseBackground_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off background.
	/// </summary>
	public virtual void SetUseBackground(int _arg)
	{
		vtkLegendBoxActor_SetUseBackground_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_ShallowCopy_61(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this scaled text actor. Overloads the virtual
	/// vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkLegendBoxActor_ShallowCopy_61(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_UseBackgroundOff_62(HandleRef pThis);

	/// <summary>
	/// Turn on/off background.
	/// </summary>
	public virtual void UseBackgroundOff()
	{
		vtkLegendBoxActor_UseBackgroundOff_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLegendBoxActor_UseBackgroundOn_63(HandleRef pThis);

	/// <summary>
	/// Turn on/off background.
	/// </summary>
	public virtual void UseBackgroundOn()
	{
		vtkLegendBoxActor_UseBackgroundOn_63(GetCppThis());
	}
}
