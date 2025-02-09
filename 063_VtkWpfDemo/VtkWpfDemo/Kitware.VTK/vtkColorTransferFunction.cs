using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkColorTransferFunction
/// </summary>
/// <remarks>
///    Defines a transfer function for mapping a
/// property to an RGB color value.
///
///
/// vtkColorTransferFunction is a color mapping in RGB or HSV space that
/// uses piecewise hermite functions to allow interpolation that can be
/// piecewise constant, piecewise linear, or somewhere in-between
/// (a modified piecewise hermite function that squishes the function
/// according to a sharpness parameter). The function also allows for
/// the specification of the midpoint (the place where the function
/// reaches the average of the two bounding nodes) as a normalize distance
/// between nodes.
/// See the description of class vtkPiecewiseFunction for an explanation of
/// midpoint and sharpness.
///
/// </remarks>
/// <seealso>
///
/// vtkPiecewiseFunction
/// </seealso>
public class vtkColorTransferFunction : vtkScalarsToColors
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkColorTransferFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkColorTransferFunction()
	{
		MRClassNameKey = "class vtkColorTransferFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorTransferFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkColorTransferFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkColorTransferFunction New()
	{
		vtkColorTransferFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorTransferFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkColorTransferFunction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkColorTransferFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkColorTransferFunction_AddHSVPoint_01(HandleRef pThis, double x, double h, double s, double v);

	/// <summary>
	/// Add/Remove a point to/from the function defined in RGB or HSV
	/// Return the index of the point (0 based), or -1 on error.
	/// See the description of class vtkPiecewiseFunction for an explanation of
	/// midpoint and sharpness.
	/// </summary>
	public int AddHSVPoint(double x, double h, double s, double v)
	{
		return vtkColorTransferFunction_AddHSVPoint_01(GetCppThis(), x, h, s, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_AddHSVPoint_02(HandleRef pThis, double x, double h, double s, double v, double midpoint, double sharpness);

	/// <summary>
	/// Add/Remove a point to/from the function defined in RGB or HSV
	/// Return the index of the point (0 based), or -1 on error.
	/// See the description of class vtkPiecewiseFunction for an explanation of
	/// midpoint and sharpness.
	/// </summary>
	public int AddHSVPoint(double x, double h, double s, double v, double midpoint, double sharpness)
	{
		return vtkColorTransferFunction_AddHSVPoint_02(GetCppThis(), x, h, s, v, midpoint, sharpness);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_AddHSVSegment_03(HandleRef pThis, double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2);

	/// <summary>
	/// Add two points to the function and remove all the points
	/// between them
	/// </summary>
	public void AddHSVSegment(double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2)
	{
		vtkColorTransferFunction_AddHSVSegment_03(GetCppThis(), x1, h1, s1, v1, x2, h2, s2, v2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_AddRGBPoint_04(HandleRef pThis, double x, double r, double g, double b);

	/// <summary>
	/// Add/Remove a point to/from the function defined in RGB or HSV
	/// Return the index of the point (0 based), or -1 on error.
	/// See the description of class vtkPiecewiseFunction for an explanation of
	/// midpoint and sharpness.
	/// </summary>
	public int AddRGBPoint(double x, double r, double g, double b)
	{
		return vtkColorTransferFunction_AddRGBPoint_04(GetCppThis(), x, r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_AddRGBPoint_05(HandleRef pThis, double x, double r, double g, double b, double midpoint, double sharpness);

	/// <summary>
	/// Add/Remove a point to/from the function defined in RGB or HSV
	/// Return the index of the point (0 based), or -1 on error.
	/// See the description of class vtkPiecewiseFunction for an explanation of
	/// midpoint and sharpness.
	/// </summary>
	public int AddRGBPoint(double x, double r, double g, double b, double midpoint, double sharpness)
	{
		return vtkColorTransferFunction_AddRGBPoint_05(GetCppThis(), x, r, g, b, midpoint, sharpness);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_AddRGBPoints_06(HandleRef pThis, HandleRef x, HandleRef rgbColors);

	/// <summary>
	/// Add/Remove a point to/from the function defined in RGB or HSV
	/// Return the index of the point (0 based), or -1 on error.
	/// See the description of class vtkPiecewiseFunction for an explanation of
	/// midpoint and sharpness.
	/// </summary>
	public int AddRGBPoints(vtkDoubleArray x, vtkDoubleArray rgbColors)
	{
		return vtkColorTransferFunction_AddRGBPoints_06(GetCppThis(), x?.GetCppThis() ?? default(HandleRef), rgbColors?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_AddRGBPoints_07(HandleRef pThis, HandleRef x, HandleRef rgbColors, double midpoint, double sharpness);

	/// <summary>
	/// Add/Remove a point to/from the function defined in RGB or HSV
	/// Return the index of the point (0 based), or -1 on error.
	/// See the description of class vtkPiecewiseFunction for an explanation of
	/// midpoint and sharpness.
	/// </summary>
	public int AddRGBPoints(vtkDoubleArray x, vtkDoubleArray rgbColors, double midpoint, double sharpness)
	{
		return vtkColorTransferFunction_AddRGBPoints_07(GetCppThis(), x?.GetCppThis() ?? default(HandleRef), rgbColors?.GetCppThis() ?? default(HandleRef), midpoint, sharpness);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_AddRGBSegment_08(HandleRef pThis, double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2);

	/// <summary>
	/// Add two points to the function and remove all the points
	/// between them
	/// </summary>
	public void AddRGBSegment(double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2)
	{
		vtkColorTransferFunction_AddRGBSegment_08(GetCppThis(), x1, r1, g1, b1, x2, r2, g2, b2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_AdjustRange_09(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Remove all points out of the new range, and make sure there is a point
	/// at each end of that range.
	/// Returns 1 on success, 0 otherwise.
	/// </summary>
	public int AdjustRange(IntPtr range)
	{
		return vtkColorTransferFunction_AdjustRange_09(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_AllowDuplicateScalarsOff_10(HandleRef pThis);

	/// <summary>
	/// Toggle whether to allow duplicate scalar values in the color transfer
	/// function (off by default).
	/// </summary>
	public virtual void AllowDuplicateScalarsOff()
	{
		vtkColorTransferFunction_AllowDuplicateScalarsOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_AllowDuplicateScalarsOn_11(HandleRef pThis);

	/// <summary>
	/// Toggle whether to allow duplicate scalar values in the color transfer
	/// function (off by default).
	/// </summary>
	public virtual void AllowDuplicateScalarsOn()
	{
		vtkColorTransferFunction_AllowDuplicateScalarsOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_BuildFunctionFromTable_12(HandleRef pThis, double x1, double x2, int size, IntPtr table);

	/// <summary>
	/// Construct a color transfer function from a table. Unlike
	/// FillFromDataPointer(), the \p table parameter's layout is assumed
	/// to be [R1, G1, B1, R2, G2, B2, ..., Rn, Gn, Bn], and it is
	/// assumed to be a block of memory of size [3*size]. After calling
	/// this method, the function range will be [x1, x2], the function
	/// will have \p size nodes, and function values will be regularly spaced
	/// between x1 and x2.
	/// </summary>
	public void BuildFunctionFromTable(double x1, double x2, int size, IntPtr table)
	{
		vtkColorTransferFunction_BuildFunctionFromTable_12(GetCppThis(), x1, x2, size, table);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_ClampingOff_13(HandleRef pThis);

	/// <summary>
	/// Sets/gets whether clamping is used. If on, scalar values below
	/// the lower range value set for the transfer function will be
	/// mapped to the first node color, and scalar values above the upper
	/// range value set for the transfer function will be mapped to the
	/// last node color. If off, values outside the range are mapped to
	/// black.
	/// </summary>
	public virtual void ClampingOff()
	{
		vtkColorTransferFunction_ClampingOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_ClampingOn_14(HandleRef pThis);

	/// <summary>
	/// Sets/gets whether clamping is used. If on, scalar values below
	/// the lower range value set for the transfer function will be
	/// mapped to the first node color, and scalar values above the upper
	/// range value set for the transfer function will be mapped to the
	/// last node color. If off, values outside the range are mapped to
	/// black.
	/// </summary>
	public virtual void ClampingOn()
	{
		vtkColorTransferFunction_ClampingOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_DeepCopy_15(HandleRef pThis, HandleRef f);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void DeepCopy(vtkScalarsToColors f)
	{
		vtkColorTransferFunction_DeepCopy_15(GetCppThis(), f?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_EstimateMinNumberOfSamples_16(HandleRef pThis, ref double x1, ref double x2);

	/// <summary>
	/// Estimates the minimum size of a table such that it would correctly sample this function.
	/// The returned value should be passed as parameter 'n' when calling GetTable().
	/// </summary>
	public int EstimateMinNumberOfSamples(ref double x1, ref double x2)
	{
		return vtkColorTransferFunction_EstimateMinNumberOfSamples_16(GetCppThis(), ref x1, ref x2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_FillFromDataPointer_17(HandleRef pThis, int n, IntPtr ptr);

	/// <summary>
	/// Defines the nodes from an array \a ptr with the layout [X1, R1,
	/// G1, B1, X2, R2, G2, B2, ..., Xn, Rn, Gn, Bn] where n is the
	/// number of nodes.
	/// </summary>
	public void FillFromDataPointer(int n, IntPtr ptr)
	{
		vtkColorTransferFunction_FillFromDataPointer_17(GetCppThis(), n, ptr);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_GetAboveRangeColor_18(HandleRef pThis);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual double[] GetAboveRangeColor()
	{
		IntPtr intPtr = vtkColorTransferFunction_GetAboveRangeColor_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetAboveRangeColor_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void GetAboveRangeColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkColorTransferFunction_GetAboveRangeColor_19(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetAboveRangeColor_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void GetAboveRangeColor(IntPtr _arg)
	{
		vtkColorTransferFunction_GetAboveRangeColor_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetAllowDuplicateScalars_21(HandleRef pThis);

	/// <summary>
	/// Toggle whether to allow duplicate scalar values in the color transfer
	/// function (off by default).
	/// </summary>
	public virtual int GetAllowDuplicateScalars()
	{
		return vtkColorTransferFunction_GetAllowDuplicateScalars_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_GetBelowRangeColor_22(HandleRef pThis);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual double[] GetBelowRangeColor()
	{
		IntPtr intPtr = vtkColorTransferFunction_GetBelowRangeColor_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetBelowRangeColor_23(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void GetBelowRangeColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkColorTransferFunction_GetBelowRangeColor_23(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetBelowRangeColor_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void GetBelowRangeColor(IntPtr _arg)
	{
		vtkColorTransferFunction_GetBelowRangeColor_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkColorTransferFunction_GetBlueValue_25(HandleRef pThis, double x);

	/// <summary>
	/// Get the color components individually.
	/// </summary>
	public double GetBlueValue(double x)
	{
		return vtkColorTransferFunction_GetBlueValue_25(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetClamping_26(HandleRef pThis);

	/// <summary>
	/// Sets/gets whether clamping is used. If on, scalar values below
	/// the lower range value set for the transfer function will be
	/// mapped to the first node color, and scalar values above the upper
	/// range value set for the transfer function will be mapped to the
	/// last node color. If off, values outside the range are mapped to
	/// black.
	/// </summary>
	public virtual int GetClamping()
	{
		return vtkColorTransferFunction_GetClamping_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetClampingMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Sets/gets whether clamping is used. If on, scalar values below
	/// the lower range value set for the transfer function will be
	/// mapped to the first node color, and scalar values above the upper
	/// range value set for the transfer function will be mapped to the
	/// last node color. If off, values outside the range are mapped to
	/// black.
	/// </summary>
	public virtual int GetClampingMaxValue()
	{
		return vtkColorTransferFunction_GetClampingMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetClampingMinValue_28(HandleRef pThis);

	/// <summary>
	/// Sets/gets whether clamping is used. If on, scalar values below
	/// the lower range value set for the transfer function will be
	/// mapped to the first node color, and scalar values above the upper
	/// range value set for the transfer function will be mapped to the
	/// last node color. If off, values outside the range are mapped to
	/// black.
	/// </summary>
	public virtual int GetClampingMinValue()
	{
		return vtkColorTransferFunction_GetClampingMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_GetColor_29(HandleRef pThis, double x);

	/// <summary>
	/// Returns an RGB color for the specified scalar value
	/// </summary>
	public new double[] GetColor(double x)
	{
		IntPtr intPtr = vtkColorTransferFunction_GetColor_29(GetCppThis(), x);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetColor_30(HandleRef pThis, double x, IntPtr rgb);

	/// <summary>
	/// Returns an RGB color for the specified scalar value
	/// </summary>
	public override void GetColor(double x, IntPtr rgb)
	{
		vtkColorTransferFunction_GetColor_30(GetCppThis(), x, rgb);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetColorSpace_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public virtual int GetColorSpace()
	{
		return vtkColorTransferFunction_GetColorSpace_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetColorSpaceMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public virtual int GetColorSpaceMaxValue()
	{
		return vtkColorTransferFunction_GetColorSpaceMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetColorSpaceMinValue_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public virtual int GetColorSpaceMinValue()
	{
		return vtkColorTransferFunction_GetColorSpaceMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_GetDataPointer_34(HandleRef pThis);

	/// <summary>
	/// Returns a pointer to an array of all node values in an
	/// interleaved array with the layout [X1, R1, G1, B1, X2, R2, G2,
	/// B2, ..., Xn, Rn, Gn, Bn] where n is the number of nodes defining
	/// the transfer function. The returned pointer points to an array
	/// that is managed by this class, so callers should not free it.
	/// </summary>
	public IntPtr GetDataPointer()
	{
		return vtkColorTransferFunction_GetDataPointer_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkColorTransferFunction_GetGreenValue_35(HandleRef pThis, double x);

	/// <summary>
	/// Get the color components individually.
	/// </summary>
	public double GetGreenValue(double x)
	{
		return vtkColorTransferFunction_GetGreenValue_35(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetHSVWrap_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public virtual int GetHSVWrap()
	{
		return vtkColorTransferFunction_GetHSVWrap_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetIndexedColor_37(HandleRef pThis, long idx, IntPtr rgba);

	/// <summary>
	/// Return a color given an integer index.
	///
	/// This is used to assign colors to annotations (given an offset into the list of annotations).
	/// If there are no control points or \a idx &lt; 0, then NanColor is returned.
	/// </summary>
	public override void GetIndexedColor(long idx, IntPtr rgba)
	{
		vtkColorTransferFunction_GetIndexedColor_37(GetCppThis(), idx, rgba);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_GetNanColor_38(HandleRef pThis);

	/// <summary>
	/// Set the RGB color to use when a NaN (not a number) is
	/// encountered.  This is an RGB 3-tuple color of doubles in the
	/// range [0,1].
	/// </summary>
	public virtual double[] GetNanColor()
	{
		IntPtr intPtr = vtkColorTransferFunction_GetNanColor_38(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetNanColor_39(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the RGB color to use when a NaN (not a number) is
	/// encountered.  This is an RGB 3-tuple color of doubles in the
	/// range [0,1].
	/// </summary>
	public virtual void GetNanColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkColorTransferFunction_GetNanColor_39(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetNanColor_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the RGB color to use when a NaN (not a number) is
	/// encountered.  This is an RGB 3-tuple color of doubles in the
	/// range [0,1].
	/// </summary>
	public virtual void GetNanColor(IntPtr _arg)
	{
		vtkColorTransferFunction_GetNanColor_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkColorTransferFunction_GetNanOpacity_41(HandleRef pThis);

	/// <summary>
	/// Get/Set the opacity to use when a NaN (not a number) is
	/// encountered. This a double in the range [0,1].
	/// </summary>
	public virtual double GetNanOpacity()
	{
		return vtkColorTransferFunction_GetNanOpacity_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetNodeValue_42(HandleRef pThis, int index, IntPtr val);

	/// <summary>
	/// For the node specified by index, set/get the
	/// location (X), R, G, and B values, midpoint, and
	/// sharpness values at the node.
	/// </summary>
	public int GetNodeValue(int index, IntPtr val)
	{
		return vtkColorTransferFunction_GetNodeValue_42(GetCppThis(), index, val);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorTransferFunction_GetNumberOfAvailableColors_43(HandleRef pThis);

	/// <summary>
	/// Get the number of available colors for mapping to.
	/// </summary>
	public override long GetNumberOfAvailableColors()
	{
		return vtkColorTransferFunction_GetNumberOfAvailableColors_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorTransferFunction_GetNumberOfGenerationsFromBase_44(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkColorTransferFunction_GetNumberOfGenerationsFromBase_44(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorTransferFunction_GetNumberOfGenerationsFromBaseType_45(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkColorTransferFunction_GetNumberOfGenerationsFromBaseType_45(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_GetRange_46(HandleRef pThis);

	/// <summary>
	/// Returns min and max position of all function points.
	/// </summary>
	public override double[] GetRange()
	{
		IntPtr intPtr = vtkColorTransferFunction_GetRange_46(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetRange_47(HandleRef pThis, ref double arg1, ref double arg2);

	/// <summary>
	/// Returns min and max position of all function points.
	/// </summary>
	public virtual void GetRange(ref double arg1, ref double arg2)
	{
		vtkColorTransferFunction_GetRange_47(GetCppThis(), ref arg1, ref arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetRange_48(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Returns min and max position of all function points.
	/// </summary>
	public virtual void GetRange(IntPtr _arg)
	{
		vtkColorTransferFunction_GetRange_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkColorTransferFunction_GetRedValue_49(HandleRef pThis, double x);

	/// <summary>
	/// Get the color components individually.
	/// </summary>
	public double GetRedValue(double x)
	{
		return vtkColorTransferFunction_GetRedValue_49(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetScale_50(HandleRef pThis);

	/// <summary>
	/// Set the type of scale to use, linear or logarithmic.  The default
	/// is linear.  If the scale is logarithmic, and the range contains
	/// zero, the color mapping will be linear.
	/// </summary>
	public virtual int GetScale()
	{
		return vtkColorTransferFunction_GetScale_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetSize_51(HandleRef pThis);

	/// <summary>
	/// How many nodes define this function?
	/// </summary>
	public int GetSize()
	{
		return vtkColorTransferFunction_GetSize_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_GetTable_52(HandleRef pThis, double x1, double x2, int n, IntPtr table);

	/// <summary>
	/// Fills in a table of \a n colors mapped from \a values mapped with
	/// even spacing between x1 and x2, inclusive.
	///
	/// Note that \a GetTable ignores \a IndexedLookup
	/// </summary>
	public void GetTable(double x1, double x2, int n, IntPtr table)
	{
		vtkColorTransferFunction_GetTable_52(GetCppThis(), x1, x2, n, table);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_GetTable_53(HandleRef pThis, double x1, double x2, int n);

	/// <summary>
	/// Fills in a table of \a n colors mapped from \a values mapped with
	/// even spacing between x1 and x2, inclusive.
	///
	/// Note that \a GetTable ignores \a IndexedLookup
	/// </summary>
	public IntPtr GetTable(double x1, double x2, int n)
	{
		return vtkColorTransferFunction_GetTable_53(GetCppThis(), x1, x2, n);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetUseAboveRangeColor_54(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual int GetUseAboveRangeColor()
	{
		return vtkColorTransferFunction_GetUseAboveRangeColor_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_GetUseBelowRangeColor_55(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual int GetUseBelowRangeColor()
	{
		return vtkColorTransferFunction_GetUseBelowRangeColor_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_HSVWrapOff_56(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public virtual void HSVWrapOff()
	{
		vtkColorTransferFunction_HSVWrapOff_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_HSVWrapOn_57(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public virtual void HSVWrapOn()
	{
		vtkColorTransferFunction_HSVWrapOn_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_IsA_58(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkColorTransferFunction_IsA_58(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_IsTypeOf_59(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkColorTransferFunction_IsTypeOf_59(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_MapScalarsThroughTable2_60(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement);

	/// <summary>
	/// Map a set of scalars through the lookup table.
	/// </summary>
	public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
	{
		vtkColorTransferFunction_MapScalarsThroughTable2_60(GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_MapValue_61(HandleRef pThis, double v);

	/// <summary>
	/// Map one value through the lookup table.
	/// </summary>
	public override IntPtr MapValue(double v)
	{
		return vtkColorTransferFunction_MapValue_61(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_NewInstance_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkColorTransferFunction NewInstance()
	{
		vtkColorTransferFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorTransferFunction_NewInstance_63(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_RemoveAllPoints_64(HandleRef pThis);

	/// <summary>
	/// Remove all points
	/// </summary>
	public void RemoveAllPoints()
	{
		vtkColorTransferFunction_RemoveAllPoints_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_RemovePoint_65(HandleRef pThis, double x);

	/// <summary>
	/// Add/Remove a point to/from the function defined in RGB or HSV
	/// Return the index of the point (0 based), or -1 on error.
	/// See the description of class vtkPiecewiseFunction for an explanation of
	/// midpoint and sharpness.
	/// </summary>
	public int RemovePoint(double x)
	{
		return vtkColorTransferFunction_RemovePoint_65(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferFunction_SafeDownCast_66(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkColorTransferFunction SafeDownCast(vtkObjectBase o)
	{
		vtkColorTransferFunction vtkColorTransferFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorTransferFunction_SafeDownCast_66(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkColorTransferFunction_SetAboveRangeColor_67(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void SetAboveRangeColor(double _arg1, double _arg2, double _arg3)
	{
		vtkColorTransferFunction_SetAboveRangeColor_67(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetAboveRangeColor_68(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a value above the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void SetAboveRangeColor(IntPtr _arg)
	{
		vtkColorTransferFunction_SetAboveRangeColor_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetAllowDuplicateScalars_69(HandleRef pThis, int _arg);

	/// <summary>
	/// Toggle whether to allow duplicate scalar values in the color transfer
	/// function (off by default).
	/// </summary>
	public virtual void SetAllowDuplicateScalars(int _arg)
	{
		vtkColorTransferFunction_SetAllowDuplicateScalars_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetBelowRangeColor_70(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void SetBelowRangeColor(double _arg1, double _arg2, double _arg3)
	{
		vtkColorTransferFunction_SetBelowRangeColor_70(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetBelowRangeColor_71(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when a value below the range is
	/// encountered. This is an RGB 3-tuple of doubles in the range [0, 1].
	/// </summary>
	public virtual void SetBelowRangeColor(IntPtr _arg)
	{
		vtkColorTransferFunction_SetBelowRangeColor_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetClamping_72(HandleRef pThis, int _arg);

	/// <summary>
	/// Sets/gets whether clamping is used. If on, scalar values below
	/// the lower range value set for the transfer function will be
	/// mapped to the first node color, and scalar values above the upper
	/// range value set for the transfer function will be mapped to the
	/// last node color. If off, values outside the range are mapped to
	/// black.
	/// </summary>
	public virtual void SetClamping(int _arg)
	{
		vtkColorTransferFunction_SetClamping_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetColorSpace_73(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public virtual void SetColorSpace(int _arg)
	{
		vtkColorTransferFunction_SetColorSpace_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetColorSpaceToDiverging_74(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public void SetColorSpaceToDiverging()
	{
		vtkColorTransferFunction_SetColorSpaceToDiverging_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetColorSpaceToHSV_75(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public void SetColorSpaceToHSV()
	{
		vtkColorTransferFunction_SetColorSpaceToHSV_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetColorSpaceToLab_76(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public void SetColorSpaceToLab()
	{
		vtkColorTransferFunction_SetColorSpaceToLab_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetColorSpaceToLabCIEDE2000_77(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public void SetColorSpaceToLabCIEDE2000()
	{
		vtkColorTransferFunction_SetColorSpaceToLabCIEDE2000_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetColorSpaceToRGB_78(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public void SetColorSpaceToRGB()
	{
		vtkColorTransferFunction_SetColorSpaceToRGB_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetColorSpaceToStep_79(HandleRef pThis);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public void SetColorSpaceToStep()
	{
		vtkColorTransferFunction_SetColorSpaceToStep_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetHSVWrap_80(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the color space used for interpolation: RGB, HSV, CIELAB,
	/// Diverging or Step.  In HSV mode, if HSVWrap is on, it will take the shortest path
	/// in Hue (going back through 0 if that is the shortest way around the hue
	/// circle) whereas if HSVWrap is off it will not go through 0 (in order the
	/// match the current functionality of vtkLookupTable).  In Lab/CIEDE2000 mode,
	/// it will take the shortest path in the Lab color space with respect to the
	/// CIE Delta E 2000 color distance measure. Diverging is a special
	/// mode where colors will pass through white when interpolating between two
	/// saturated colors. Step is a mode where the color of an interval is the
	/// color of the second color of the interval.
	/// </summary>
	public virtual void SetHSVWrap(int _arg)
	{
		vtkColorTransferFunction_SetHSVWrap_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetNanColor_81(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the RGB color to use when a NaN (not a number) is
	/// encountered.  This is an RGB 3-tuple color of doubles in the
	/// range [0,1].
	/// </summary>
	public virtual void SetNanColor(double _arg1, double _arg2, double _arg3)
	{
		vtkColorTransferFunction_SetNanColor_81(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetNanColor_82(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the RGB color to use when a NaN (not a number) is
	/// encountered.  This is an RGB 3-tuple color of doubles in the
	/// range [0,1].
	/// </summary>
	public virtual void SetNanColor(IntPtr _arg)
	{
		vtkColorTransferFunction_SetNanColor_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetNanColorRGBA_83(HandleRef pThis, double r, double g, double b, double a);

	/// <summary>
	/// Set the RGBA color to use when a NaN (not a number) is
	/// encountered.  This is an RGBA 4-tuple color of doubles in the
	/// range [0,1].
	/// </summary>
	public virtual void SetNanColorRGBA(double r, double g, double b, double a)
	{
		vtkColorTransferFunction_SetNanColorRGBA_83(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetNanColorRGBA_84(HandleRef pThis, IntPtr rgba);

	/// <summary>
	/// Set the RGBA color to use when a NaN (not a number) is
	/// encountered.  This is an RGBA 4-tuple color of doubles in the
	/// range [0,1].
	/// </summary>
	public void SetNanColorRGBA(IntPtr rgba)
	{
		vtkColorTransferFunction_SetNanColorRGBA_84(GetCppThis(), rgba);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetNanOpacity_85(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/Set the opacity to use when a NaN (not a number) is
	/// encountered. This a double in the range [0,1].
	/// </summary>
	public virtual void SetNanOpacity(double _arg)
	{
		vtkColorTransferFunction_SetNanOpacity_85(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferFunction_SetNodeValue_86(HandleRef pThis, int index, IntPtr val);

	/// <summary>
	/// For the node specified by index, set/get the
	/// location (X), R, G, and B values, midpoint, and
	/// sharpness values at the node.
	/// </summary>
	public int SetNodeValue(int index, IntPtr val)
	{
		return vtkColorTransferFunction_SetNodeValue_86(GetCppThis(), index, val);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetScale_87(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the type of scale to use, linear or logarithmic.  The default
	/// is linear.  If the scale is logarithmic, and the range contains
	/// zero, the color mapping will be linear.
	/// </summary>
	public virtual void SetScale(int _arg)
	{
		vtkColorTransferFunction_SetScale_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetScaleToLinear_88(HandleRef pThis);

	/// <summary>
	/// Set the type of scale to use, linear or logarithmic.  The default
	/// is linear.  If the scale is logarithmic, and the range contains
	/// zero, the color mapping will be linear.
	/// </summary>
	public void SetScaleToLinear()
	{
		vtkColorTransferFunction_SetScaleToLinear_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetScaleToLog10_89(HandleRef pThis);

	/// <summary>
	/// Set the type of scale to use, linear or logarithmic.  The default
	/// is linear.  If the scale is logarithmic, and the range contains
	/// zero, the color mapping will be linear.
	/// </summary>
	public void SetScaleToLog10()
	{
		vtkColorTransferFunction_SetScaleToLog10_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetUseAboveRangeColor_90(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void SetUseAboveRangeColor(int _arg)
	{
		vtkColorTransferFunction_SetUseAboveRangeColor_90(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_SetUseBelowRangeColor_91(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void SetUseBelowRangeColor(int _arg)
	{
		vtkColorTransferFunction_SetUseBelowRangeColor_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_ShallowCopy_92(HandleRef pThis, HandleRef f);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void ShallowCopy(vtkColorTransferFunction f)
	{
		vtkColorTransferFunction_ShallowCopy_92(GetCppThis(), f?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_UseAboveRangeColorOff_93(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void UseAboveRangeColorOff()
	{
		vtkColorTransferFunction_UseAboveRangeColorOff_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_UseAboveRangeColorOn_94(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void UseAboveRangeColorOn()
	{
		vtkColorTransferFunction_UseAboveRangeColorOn_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_UseBelowRangeColorOff_95(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void UseBelowRangeColorOff()
	{
		vtkColorTransferFunction_UseBelowRangeColorOff_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferFunction_UseBelowRangeColorOn_96(HandleRef pThis);

	/// <summary>
	/// Set whether the below range color should be used.
	/// </summary>
	public virtual void UseBelowRangeColorOn()
	{
		vtkColorTransferFunction_UseBelowRangeColorOn_96(GetCppThis());
	}
}
