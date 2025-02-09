using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkViewTheme
/// </summary>
/// <remarks>
///    Sets theme colors for a graphical view.
///
///
/// This may be set on any subclass of vtkView.  The view class will attempt
/// to use the values set in the theme to customize the view.  Views will not
/// generally use every aspect of the theme.
/// NOTICE: This class will be deprecated in favor of a more robust
/// solution based on style sheets.  Do not become overly-dependent on the
/// functionality of themes.
/// </remarks>
public class vtkViewTheme : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkViewTheme";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkViewTheme()
	{
		MRClassNameKey = "class vtkViewTheme";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewTheme"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkViewTheme(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkViewTheme New()
	{
		vtkViewTheme result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkViewTheme()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkViewTheme_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_CreateMellowTheme_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience methods for creating some default view themes.
	/// The return reference is reference-counted, so you will have to call
	/// Delete() on the reference when you are finished with it.
	/// </summary>
	public static vtkViewTheme CreateMellowTheme()
	{
		vtkViewTheme vtkViewTheme2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_CreateMellowTheme_01(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewTheme2 = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewTheme2.Register(null);
			}
		}
		return vtkViewTheme2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_CreateNeonTheme_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience methods for creating some default view themes.
	/// The return reference is reference-counted, so you will have to call
	/// Delete() on the reference when you are finished with it.
	/// </summary>
	public static vtkViewTheme CreateNeonTheme()
	{
		vtkViewTheme vtkViewTheme2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_CreateNeonTheme_02(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewTheme2 = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewTheme2.Register(null);
			}
		}
		return vtkViewTheme2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_CreateOceanTheme_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience methods for creating some default view themes.
	/// The return reference is reference-counted, so you will have to call
	/// Delete() on the reference when you are finished with it.
	/// </summary>
	public static vtkViewTheme CreateOceanTheme()
	{
		vtkViewTheme vtkViewTheme2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_CreateOceanTheme_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewTheme2 = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewTheme2.Register(null);
			}
		}
		return vtkViewTheme2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetBackgroundColor_04(HandleRef pThis);

	/// <summary>
	/// The view background color.
	/// </summary>
	public virtual double[] GetBackgroundColor()
	{
		IntPtr intPtr = vtkViewTheme_GetBackgroundColor_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetBackgroundColor_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The view background color.
	/// </summary>
	public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewTheme_GetBackgroundColor_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetBackgroundColor_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The view background color.
	/// </summary>
	public virtual void GetBackgroundColor(IntPtr _arg)
	{
		vtkViewTheme_GetBackgroundColor_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetBackgroundColor2_07(HandleRef pThis);

	/// <summary>
	/// The second background color (for gradients).
	/// </summary>
	public virtual double[] GetBackgroundColor2()
	{
		IntPtr intPtr = vtkViewTheme_GetBackgroundColor2_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetBackgroundColor2_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The second background color (for gradients).
	/// </summary>
	public virtual void GetBackgroundColor2(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewTheme_GetBackgroundColor2_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetBackgroundColor2_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The second background color (for gradients).
	/// </summary>
	public virtual void GetBackgroundColor2(IntPtr _arg)
	{
		vtkViewTheme_GetBackgroundColor2_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetCellAlphaRange_10(HandleRef pThis);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual IntPtr GetCellAlphaRange()
	{
		return vtkViewTheme_GetCellAlphaRange_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellAlphaRange_11(HandleRef pThis, ref double mn, ref double mx);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetCellAlphaRange(ref double mn, ref double mx)
	{
		vtkViewTheme_GetCellAlphaRange_11(GetCppThis(), ref mn, ref mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellAlphaRange_12(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetCellAlphaRange(IntPtr rng)
	{
		vtkViewTheme_GetCellAlphaRange_12(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetCellColor_13(HandleRef pThis);

	/// <summary>
	/// The color and opacity of cells or edges when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual double[] GetCellColor()
	{
		IntPtr intPtr = vtkViewTheme_GetCellColor_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellColor_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The color and opacity of cells or edges when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void GetCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewTheme_GetCellColor_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellColor_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color and opacity of cells or edges when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void GetCellColor(IntPtr _arg)
	{
		vtkViewTheme_GetCellColor_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetCellHueRange_16(HandleRef pThis);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual IntPtr GetCellHueRange()
	{
		return vtkViewTheme_GetCellHueRange_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellHueRange_17(HandleRef pThis, ref double mn, ref double mx);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetCellHueRange(ref double mn, ref double mx)
	{
		vtkViewTheme_GetCellHueRange_17(GetCppThis(), ref mn, ref mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellHueRange_18(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetCellHueRange(IntPtr rng)
	{
		vtkViewTheme_GetCellHueRange_18(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetCellLookupTable_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the cell lookup table.
	/// </summary>
	public virtual vtkScalarsToColors GetCellLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_GetCellLookupTable_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewTheme_GetCellOpacity_20(HandleRef pThis);

	/// <summary>
	/// The color and opacity of cells or edges when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual double GetCellOpacity()
	{
		return vtkViewTheme_GetCellOpacity_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetCellSaturationRange_21(HandleRef pThis);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual IntPtr GetCellSaturationRange()
	{
		return vtkViewTheme_GetCellSaturationRange_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellSaturationRange_22(HandleRef pThis, ref double mn, ref double mx);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetCellSaturationRange(ref double mn, ref double mx)
	{
		vtkViewTheme_GetCellSaturationRange_22(GetCppThis(), ref mn, ref mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellSaturationRange_23(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetCellSaturationRange(IntPtr rng)
	{
		vtkViewTheme_GetCellSaturationRange_23(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetCellTextProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The text property to use for labeling edges/cells.
	/// </summary>
	public virtual vtkTextProperty GetCellTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_GetCellTextProperty_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetCellValueRange_25(HandleRef pThis);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual IntPtr GetCellValueRange()
	{
		return vtkViewTheme_GetCellValueRange_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellValueRange_26(HandleRef pThis, ref double mn, ref double mx);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetCellValueRange(ref double mn, ref double mx)
	{
		vtkViewTheme_GetCellValueRange_26(GetCppThis(), ref mn, ref mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetCellValueRange_27(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetCellValueRange(IntPtr rng)
	{
		vtkViewTheme_GetCellValueRange_27(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetEdgeLabelColor_28(HandleRef pThis);

	/// <summary>
	/// The color to use for labeling graph edges.
	/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual IntPtr GetEdgeLabelColor()
	{
		return vtkViewTheme_GetEdgeLabelColor_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetEdgeLabelColor_29(HandleRef pThis, ref double r, ref double g, ref double b);

	/// <summary>
	/// The color to use for labeling graph edges.
	/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual void GetEdgeLabelColor(ref double r, ref double g, ref double b)
	{
		vtkViewTheme_GetEdgeLabelColor_29(GetCppThis(), ref r, ref g, ref b);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetEdgeLabelColor_30(HandleRef pThis, IntPtr c);

	/// <summary>
	/// The color to use for labeling graph edges.
	/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual void GetEdgeLabelColor(IntPtr c)
	{
		vtkViewTheme_GetEdgeLabelColor_30(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewTheme_GetLineWidth_31(HandleRef pThis);

	/// <summary>
	/// The width of lines or edges
	/// </summary>
	public virtual double GetLineWidth()
	{
		return vtkViewTheme_GetLineWidth_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkViewTheme_GetNumberOfGenerationsFromBase_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkViewTheme_GetNumberOfGenerationsFromBase_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkViewTheme_GetNumberOfGenerationsFromBaseType_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkViewTheme_GetNumberOfGenerationsFromBaseType_33(type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetOutlineColor_34(HandleRef pThis);

	/// <summary>
	/// The color of any outlines in the view.
	/// </summary>
	public virtual double[] GetOutlineColor()
	{
		IntPtr intPtr = vtkViewTheme_GetOutlineColor_34(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetOutlineColor_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The color of any outlines in the view.
	/// </summary>
	public virtual void GetOutlineColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewTheme_GetOutlineColor_35(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetOutlineColor_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color of any outlines in the view.
	/// </summary>
	public virtual void GetOutlineColor(IntPtr _arg)
	{
		vtkViewTheme_GetOutlineColor_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetPointAlphaRange_37(HandleRef pThis);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual IntPtr GetPointAlphaRange()
	{
		return vtkViewTheme_GetPointAlphaRange_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointAlphaRange_38(HandleRef pThis, ref double mn, ref double mx);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetPointAlphaRange(ref double mn, ref double mx)
	{
		vtkViewTheme_GetPointAlphaRange_38(GetCppThis(), ref mn, ref mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointAlphaRange_39(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetPointAlphaRange(IntPtr rng)
	{
		vtkViewTheme_GetPointAlphaRange_39(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetPointColor_40(HandleRef pThis);

	/// <summary>
	/// The color and opacity of points or vertices when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual double[] GetPointColor()
	{
		IntPtr intPtr = vtkViewTheme_GetPointColor_40(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointColor_41(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The color and opacity of points or vertices when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void GetPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewTheme_GetPointColor_41(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointColor_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color and opacity of points or vertices when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void GetPointColor(IntPtr _arg)
	{
		vtkViewTheme_GetPointColor_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetPointHueRange_43(HandleRef pThis);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual IntPtr GetPointHueRange()
	{
		return vtkViewTheme_GetPointHueRange_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointHueRange_44(HandleRef pThis, ref double mn, ref double mx);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetPointHueRange(ref double mn, ref double mx)
	{
		vtkViewTheme_GetPointHueRange_44(GetCppThis(), ref mn, ref mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointHueRange_45(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetPointHueRange(IntPtr rng)
	{
		vtkViewTheme_GetPointHueRange_45(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetPointLookupTable_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the point lookup table.
	/// </summary>
	public virtual vtkScalarsToColors GetPointLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_GetPointLookupTable_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewTheme_GetPointOpacity_47(HandleRef pThis);

	/// <summary>
	/// The color and opacity of points or vertices when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual double GetPointOpacity()
	{
		return vtkViewTheme_GetPointOpacity_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetPointSaturationRange_48(HandleRef pThis);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual IntPtr GetPointSaturationRange()
	{
		return vtkViewTheme_GetPointSaturationRange_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointSaturationRange_49(HandleRef pThis, ref double mn, ref double mx);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetPointSaturationRange(ref double mn, ref double mx)
	{
		vtkViewTheme_GetPointSaturationRange_49(GetCppThis(), ref mn, ref mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointSaturationRange_50(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetPointSaturationRange(IntPtr rng)
	{
		vtkViewTheme_GetPointSaturationRange_50(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewTheme_GetPointSize_51(HandleRef pThis);

	/// <summary>
	/// The size of points or vertices
	/// </summary>
	public virtual double GetPointSize()
	{
		return vtkViewTheme_GetPointSize_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetPointTextProperty_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The text property to use for labeling points/vertices.
	/// </summary>
	public virtual vtkTextProperty GetPointTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_GetPointTextProperty_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetPointValueRange_53(HandleRef pThis);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual IntPtr GetPointValueRange()
	{
		return vtkViewTheme_GetPointValueRange_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointValueRange_54(HandleRef pThis, ref double mn, ref double mx);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetPointValueRange(ref double mn, ref double mx)
	{
		vtkViewTheme_GetPointValueRange_54(GetCppThis(), ref mn, ref mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetPointValueRange_55(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void GetPointValueRange(IntPtr rng)
	{
		vtkViewTheme_GetPointValueRange_55(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkViewTheme_GetScaleCellLookupTable_56(HandleRef pThis);

	/// <summary>
	/// Whether to scale the lookup table to fit the range of the data.
	/// </summary>
	public virtual bool GetScaleCellLookupTable()
	{
		return (vtkViewTheme_GetScaleCellLookupTable_56(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkViewTheme_GetScalePointLookupTable_57(HandleRef pThis);

	/// <summary>
	/// Whether to scale the lookup table to fit the range of the data.
	/// </summary>
	public virtual bool GetScalePointLookupTable()
	{
		return (vtkViewTheme_GetScalePointLookupTable_57(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetSelectedCellColor_58(HandleRef pThis);

	/// <summary>
	/// The color of selected cells or edges.
	/// </summary>
	public virtual double[] GetSelectedCellColor()
	{
		IntPtr intPtr = vtkViewTheme_GetSelectedCellColor_58(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetSelectedCellColor_59(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The color of selected cells or edges.
	/// </summary>
	public virtual void GetSelectedCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewTheme_GetSelectedCellColor_59(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetSelectedCellColor_60(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color of selected cells or edges.
	/// </summary>
	public virtual void GetSelectedCellColor(IntPtr _arg)
	{
		vtkViewTheme_GetSelectedCellColor_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewTheme_GetSelectedCellOpacity_61(HandleRef pThis);

	/// <summary>
	/// The color of selected cells or edges.
	/// </summary>
	public virtual double GetSelectedCellOpacity()
	{
		return vtkViewTheme_GetSelectedCellOpacity_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetSelectedPointColor_62(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The color of selected points or vertices.
	/// </summary>
	public virtual void GetSelectedPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkViewTheme_GetSelectedPointColor_62(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetSelectedPointColor_63(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color of selected points or vertices.
	/// </summary>
	public virtual void GetSelectedPointColor(IntPtr _arg)
	{
		vtkViewTheme_GetSelectedPointColor_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetSelectedPointColor_64(HandleRef pThis);

	/// <summary>
	/// The color of selected points or vertices.
	/// </summary>
	public virtual double[] GetSelectedPointColor()
	{
		IntPtr intPtr = vtkViewTheme_GetSelectedPointColor_64(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkViewTheme_GetSelectedPointOpacity_65(HandleRef pThis);

	/// <summary>
	/// The color of selected points or vertices.
	/// </summary>
	public virtual double GetSelectedPointOpacity()
	{
		return vtkViewTheme_GetSelectedPointOpacity_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_GetVertexLabelColor_66(HandleRef pThis);

	/// <summary>
	/// The color to use for labeling graph vertices.
	/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual IntPtr GetVertexLabelColor()
	{
		return vtkViewTheme_GetVertexLabelColor_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetVertexLabelColor_67(HandleRef pThis, ref double r, ref double g, ref double b);

	/// <summary>
	/// The color to use for labeling graph vertices.
	/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual void GetVertexLabelColor(ref double r, ref double g, ref double b)
	{
		vtkViewTheme_GetVertexLabelColor_67(GetCppThis(), ref r, ref g, ref b);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_GetVertexLabelColor_68(HandleRef pThis, IntPtr c);

	/// <summary>
	/// The color to use for labeling graph vertices.
	/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual void GetVertexLabelColor(IntPtr c)
	{
		vtkViewTheme_GetVertexLabelColor_68(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewTheme_IsA_69(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkViewTheme_IsA_69(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkViewTheme_IsTypeOf_70(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkViewTheme_IsTypeOf_70(type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkViewTheme_LookupMatchesCellTheme_71(HandleRef pThis, HandleRef s2c);

	/// <summary>
	/// Whether a given lookup table matches the point or cell theme of this
	/// theme.
	/// </summary>
	public bool LookupMatchesCellTheme(vtkScalarsToColors s2c)
	{
		return (vtkViewTheme_LookupMatchesCellTheme_71(GetCppThis(), s2c?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkViewTheme_LookupMatchesPointTheme_72(HandleRef pThis, HandleRef s2c);

	/// <summary>
	/// Whether a given lookup table matches the point or cell theme of this
	/// theme.
	/// </summary>
	public bool LookupMatchesPointTheme(vtkScalarsToColors s2c)
	{
		return (vtkViewTheme_LookupMatchesPointTheme_72(GetCppThis(), s2c?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_NewInstance_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkViewTheme NewInstance()
	{
		vtkViewTheme result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_NewInstance_74(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkViewTheme_SafeDownCast_75(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkViewTheme SafeDownCast(vtkObjectBase o)
	{
		vtkViewTheme vtkViewTheme2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkViewTheme_SafeDownCast_75(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkViewTheme2 = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkViewTheme2.Register(null);
			}
		}
		return vtkViewTheme2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_ScaleCellLookupTableOff_76(HandleRef pThis);

	/// <summary>
	/// Whether to scale the lookup table to fit the range of the data.
	/// </summary>
	public virtual void ScaleCellLookupTableOff()
	{
		vtkViewTheme_ScaleCellLookupTableOff_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_ScaleCellLookupTableOn_77(HandleRef pThis);

	/// <summary>
	/// Whether to scale the lookup table to fit the range of the data.
	/// </summary>
	public virtual void ScaleCellLookupTableOn()
	{
		vtkViewTheme_ScaleCellLookupTableOn_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_ScalePointLookupTableOff_78(HandleRef pThis);

	/// <summary>
	/// Whether to scale the lookup table to fit the range of the data.
	/// </summary>
	public virtual void ScalePointLookupTableOff()
	{
		vtkViewTheme_ScalePointLookupTableOff_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_ScalePointLookupTableOn_79(HandleRef pThis);

	/// <summary>
	/// Whether to scale the lookup table to fit the range of the data.
	/// </summary>
	public virtual void ScalePointLookupTableOn()
	{
		vtkViewTheme_ScalePointLookupTableOn_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetBackgroundColor_80(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The view background color.
	/// </summary>
	public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
	{
		vtkViewTheme_SetBackgroundColor_80(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetBackgroundColor_81(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The view background color.
	/// </summary>
	public virtual void SetBackgroundColor(IntPtr _arg)
	{
		vtkViewTheme_SetBackgroundColor_81(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetBackgroundColor2_82(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The second background color (for gradients).
	/// </summary>
	public virtual void SetBackgroundColor2(double _arg1, double _arg2, double _arg3)
	{
		vtkViewTheme_SetBackgroundColor2_82(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetBackgroundColor2_83(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The second background color (for gradients).
	/// </summary>
	public virtual void SetBackgroundColor2(IntPtr _arg)
	{
		vtkViewTheme_SetBackgroundColor2_83(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellAlphaRange_84(HandleRef pThis, double mn, double mx);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetCellAlphaRange(double mn, double mx)
	{
		vtkViewTheme_SetCellAlphaRange_84(GetCppThis(), mn, mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellAlphaRange_85(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetCellAlphaRange(IntPtr rng)
	{
		vtkViewTheme_SetCellAlphaRange_85(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellColor_86(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The color and opacity of cells or edges when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void SetCellColor(double _arg1, double _arg2, double _arg3)
	{
		vtkViewTheme_SetCellColor_86(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellColor_87(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color and opacity of cells or edges when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void SetCellColor(IntPtr _arg)
	{
		vtkViewTheme_SetCellColor_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellHueRange_88(HandleRef pThis, double mn, double mx);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetCellHueRange(double mn, double mx)
	{
		vtkViewTheme_SetCellHueRange_88(GetCppThis(), mn, mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellHueRange_89(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetCellHueRange(IntPtr rng)
	{
		vtkViewTheme_SetCellHueRange_89(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellLookupTable_90(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Set/Get the cell lookup table.
	/// </summary>
	public virtual void SetCellLookupTable(vtkScalarsToColors lut)
	{
		vtkViewTheme_SetCellLookupTable_90(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellOpacity_91(HandleRef pThis, double _arg);

	/// <summary>
	/// The color and opacity of cells or edges when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void SetCellOpacity(double _arg)
	{
		vtkViewTheme_SetCellOpacity_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellSaturationRange_92(HandleRef pThis, double mn, double mx);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetCellSaturationRange(double mn, double mx)
	{
		vtkViewTheme_SetCellSaturationRange_92(GetCppThis(), mn, mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellSaturationRange_93(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetCellSaturationRange(IntPtr rng)
	{
		vtkViewTheme_SetCellSaturationRange_93(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellTextProperty_94(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// The text property to use for labeling edges/cells.
	/// </summary>
	public virtual void SetCellTextProperty(vtkTextProperty tprop)
	{
		vtkViewTheme_SetCellTextProperty_94(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellValueRange_95(HandleRef pThis, double mn, double mx);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetCellValueRange(double mn, double mx)
	{
		vtkViewTheme_SetCellValueRange_95(GetCppThis(), mn, mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetCellValueRange_96(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the cell lookup table.
	/// You may also do this by accessing the cell lookup table directly
	/// with GetCellLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetCellValueRange(IntPtr rng)
	{
		vtkViewTheme_SetCellValueRange_96(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetEdgeLabelColor_97(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// The color to use for labeling graph edges.
	/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual void SetEdgeLabelColor(double r, double g, double b)
	{
		vtkViewTheme_SetEdgeLabelColor_97(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetEdgeLabelColor_98(HandleRef pThis, IntPtr c);

	/// <summary>
	/// The color to use for labeling graph edges.
	/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual void SetEdgeLabelColor(IntPtr c)
	{
		vtkViewTheme_SetEdgeLabelColor_98(GetCppThis(), c);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetLineWidth_99(HandleRef pThis, double _arg);

	/// <summary>
	/// The width of lines or edges
	/// </summary>
	public virtual void SetLineWidth(double _arg)
	{
		vtkViewTheme_SetLineWidth_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetOutlineColor_100(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The color of any outlines in the view.
	/// </summary>
	public virtual void SetOutlineColor(double _arg1, double _arg2, double _arg3)
	{
		vtkViewTheme_SetOutlineColor_100(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetOutlineColor_101(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color of any outlines in the view.
	/// </summary>
	public virtual void SetOutlineColor(IntPtr _arg)
	{
		vtkViewTheme_SetOutlineColor_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointAlphaRange_102(HandleRef pThis, double mn, double mx);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetPointAlphaRange(double mn, double mx)
	{
		vtkViewTheme_SetPointAlphaRange_102(GetCppThis(), mn, mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointAlphaRange_103(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetPointAlphaRange(IntPtr rng)
	{
		vtkViewTheme_SetPointAlphaRange_103(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointColor_104(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The color and opacity of points or vertices when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void SetPointColor(double _arg1, double _arg2, double _arg3)
	{
		vtkViewTheme_SetPointColor_104(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointColor_105(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color and opacity of points or vertices when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void SetPointColor(IntPtr _arg)
	{
		vtkViewTheme_SetPointColor_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointHueRange_106(HandleRef pThis, double mn, double mx);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetPointHueRange(double mn, double mx)
	{
		vtkViewTheme_SetPointHueRange_106(GetCppThis(), mn, mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointHueRange_107(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetPointHueRange(IntPtr rng)
	{
		vtkViewTheme_SetPointHueRange_107(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointLookupTable_108(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Set/Get the point lookup table.
	/// </summary>
	public virtual void SetPointLookupTable(vtkScalarsToColors lut)
	{
		vtkViewTheme_SetPointLookupTable_108(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointOpacity_109(HandleRef pThis, double _arg);

	/// <summary>
	/// The color and opacity of points or vertices when not mapped through
	/// a lookup table.
	/// </summary>
	public virtual void SetPointOpacity(double _arg)
	{
		vtkViewTheme_SetPointOpacity_109(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointSaturationRange_110(HandleRef pThis, double mn, double mx);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetPointSaturationRange(double mn, double mx)
	{
		vtkViewTheme_SetPointSaturationRange_110(GetCppThis(), mn, mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointSaturationRange_111(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetPointSaturationRange(IntPtr rng)
	{
		vtkViewTheme_SetPointSaturationRange_111(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointSize_112(HandleRef pThis, double _arg);

	/// <summary>
	/// The size of points or vertices
	/// </summary>
	public virtual void SetPointSize(double _arg)
	{
		vtkViewTheme_SetPointSize_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointTextProperty_113(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// The text property to use for labeling points/vertices.
	/// </summary>
	public virtual void SetPointTextProperty(vtkTextProperty tprop)
	{
		vtkViewTheme_SetPointTextProperty_113(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointValueRange_114(HandleRef pThis, double mn, double mx);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetPointValueRange(double mn, double mx)
	{
		vtkViewTheme_SetPointValueRange_114(GetCppThis(), mn, mx);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetPointValueRange_115(HandleRef pThis, IntPtr rng);

	/// <summary>
	/// The ranges to use in the point lookup table.
	/// You may also do this by accessing the point lookup table directly
	/// with GetPointLookupTable() and calling these methods.
	/// </summary>
	public virtual void SetPointValueRange(IntPtr rng)
	{
		vtkViewTheme_SetPointValueRange_115(GetCppThis(), rng);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetScaleCellLookupTable_116(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to scale the lookup table to fit the range of the data.
	/// </summary>
	public virtual void SetScaleCellLookupTable(bool _arg)
	{
		vtkViewTheme_SetScaleCellLookupTable_116(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetScalePointLookupTable_117(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to scale the lookup table to fit the range of the data.
	/// </summary>
	public virtual void SetScalePointLookupTable(bool _arg)
	{
		vtkViewTheme_SetScalePointLookupTable_117(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetSelectedCellColor_118(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The color of selected cells or edges.
	/// </summary>
	public virtual void SetSelectedCellColor(double _arg1, double _arg2, double _arg3)
	{
		vtkViewTheme_SetSelectedCellColor_118(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetSelectedCellColor_119(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color of selected cells or edges.
	/// </summary>
	public virtual void SetSelectedCellColor(IntPtr _arg)
	{
		vtkViewTheme_SetSelectedCellColor_119(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetSelectedCellOpacity_120(HandleRef pThis, double _arg);

	/// <summary>
	/// The color of selected cells or edges.
	/// </summary>
	public virtual void SetSelectedCellOpacity(double _arg)
	{
		vtkViewTheme_SetSelectedCellOpacity_120(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetSelectedPointColor_121(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The color of selected points or vertices.
	/// </summary>
	public virtual void SetSelectedPointColor(double _arg1, double _arg2, double _arg3)
	{
		vtkViewTheme_SetSelectedPointColor_121(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetSelectedPointColor_122(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The color of selected points or vertices.
	/// </summary>
	public virtual void SetSelectedPointColor(IntPtr _arg)
	{
		vtkViewTheme_SetSelectedPointColor_122(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetSelectedPointOpacity_123(HandleRef pThis, double _arg);

	/// <summary>
	/// The color of selected points or vertices.
	/// </summary>
	public virtual void SetSelectedPointOpacity(double _arg)
	{
		vtkViewTheme_SetSelectedPointOpacity_123(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetVertexLabelColor_124(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// The color to use for labeling graph vertices.
	/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual void SetVertexLabelColor(double r, double g, double b)
	{
		vtkViewTheme_SetVertexLabelColor_124(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkViewTheme_SetVertexLabelColor_125(HandleRef pThis, IntPtr c);

	/// <summary>
	/// The color to use for labeling graph vertices.
	/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
	/// </summary>
	public virtual void SetVertexLabelColor(IntPtr c)
	{
		vtkViewTheme_SetVertexLabelColor_125(GetCppThis(), c);
	}
}
