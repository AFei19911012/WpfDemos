using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageToPolyDataFilter
/// </summary>
/// <remarks>
///    generate linear primitives (vtkPolyData) from an image
///
/// vtkImageToPolyDataFilter converts raster data (i.e., an image) into
/// polygonal data (i.e., quads or n-sided polygons), with each polygon
/// assigned a constant color. This is useful for writers that generate vector
/// formats (i.e., CGM or PostScript). To use this filter, you specify how to
/// quantize the color (or whether to use an image with a lookup table), and
/// what style the output should be. The output is always polygons, but the
/// choice is n x m quads (where n and m define the input image dimensions)
/// "Pixelize" option; arbitrary polygons "Polygonalize" option; or variable
/// number of quads of constant color generated along scan lines "RunLength"
/// option.
///
/// The algorithm quantizes color in order to create coherent regions that the
/// polygons can represent with good compression. By default, the input image
/// is quantized to 256 colors using a 3-3-2 bits for red-green-blue. However,
/// you can also supply a single component image and a lookup table, with the
/// single component assumed to be an index into the table.  (Note: a quantized
/// image can be generated with the filter vtkImageQuantizeRGBToIndex.) The
/// number of colors on output is equal to the number of colors in the input
/// lookup table (or 256 if the built in linear ramp is used).
///
/// The output of the filter is polygons with a single color per polygon cell.
/// If the output style is set to "Polygonalize", the polygons may have an
/// large number of points (bounded by something like 2*(n+m)); and the
/// polygon may not be convex which may cause rendering problems on some
/// systems (use vtkTriangleFilter). Otherwise, each polygon will have four
/// vertices. The output also contains scalar data defining RGB color in
/// unsigned char form.
///
/// @warning
/// The input linear lookup table must
/// be of the form of 3-component unsigned char.
///
/// @warning
/// This filter defines constant cell colors. If you have a plotting
/// device that supports Gouraud shading (linear interpolation of color), then
/// superior algorithms are available for generating polygons from images.
///
/// @warning
/// Note that many plotting devices/formats support only a limited number of
/// colors.
///
/// </remarks>
/// <seealso>
///
/// vtkCGMWriter vtkImageQuantizeRGBToIndex vtkTriangleFilter
/// </seealso>
public class vtkImageToPolyDataFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageToPolyDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageToPolyDataFilter()
	{
		MRClassNameKey = "class vtkImageToPolyDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToPolyDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with initial number of colors 256.
	/// </summary>
	public new static vtkImageToPolyDataFilter New()
	{
		vtkImageToPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with initial number of colors 256.
	/// </summary>
	public vtkImageToPolyDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageToPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_DecimationOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the final polygons should be decimated.
	/// whether to smooth boundaries.
	/// </summary>
	public virtual void DecimationOff()
	{
		vtkImageToPolyDataFilter_DecimationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_DecimationOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the final polygons should be decimated.
	/// whether to smooth boundaries.
	/// </summary>
	public virtual void DecimationOn()
	{
		vtkImageToPolyDataFilter_DecimationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetColorMode_03(HandleRef pThis);

	/// <summary>
	/// Specify how to quantize color.
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkImageToPolyDataFilter_GetColorMode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetColorModeMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify how to quantize color.
	/// </summary>
	public virtual int GetColorModeMaxValue()
	{
		return vtkImageToPolyDataFilter_GetColorModeMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetColorModeMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify how to quantize color.
	/// </summary>
	public virtual int GetColorModeMinValue()
	{
		return vtkImageToPolyDataFilter_GetColorModeMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetDecimation_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether the final polygons should be decimated.
	/// whether to smooth boundaries.
	/// </summary>
	public virtual int GetDecimation()
	{
		return vtkImageToPolyDataFilter_GetDecimation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageToPolyDataFilter_GetDecimationError_07(HandleRef pThis);

	/// <summary>
	/// Specify the error to use for decimation (if decimation is on).
	/// The error is an absolute number--the image spacing and
	/// dimensions are used to create points so the error should be
	/// consistent with the image size.
	/// </summary>
	public virtual double GetDecimationError()
	{
		return vtkImageToPolyDataFilter_GetDecimationError_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageToPolyDataFilter_GetDecimationErrorMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the error to use for decimation (if decimation is on).
	/// The error is an absolute number--the image spacing and
	/// dimensions are used to create points so the error should be
	/// consistent with the image size.
	/// </summary>
	public virtual double GetDecimationErrorMaxValue()
	{
		return vtkImageToPolyDataFilter_GetDecimationErrorMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageToPolyDataFilter_GetDecimationErrorMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the error to use for decimation (if decimation is on).
	/// The error is an absolute number--the image spacing and
	/// dimensions are used to create points so the error should be
	/// consistent with the image size.
	/// </summary>
	public virtual double GetDecimationErrorMinValue()
	{
		return vtkImageToPolyDataFilter_GetDecimationErrorMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetError_10(HandleRef pThis);

	/// <summary>
	/// Specify the error value between two colors where the colors are
	/// considered the same. Only use this if the color mode uses the
	/// default 256 table.
	/// </summary>
	public virtual int GetError()
	{
		return vtkImageToPolyDataFilter_GetError_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetErrorMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the error value between two colors where the colors are
	/// considered the same. Only use this if the color mode uses the
	/// default 256 table.
	/// </summary>
	public virtual int GetErrorMaxValue()
	{
		return vtkImageToPolyDataFilter_GetErrorMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetErrorMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the error value between two colors where the colors are
	/// considered the same. Only use this if the color mode uses the
	/// default 256 table.
	/// </summary>
	public virtual int GetErrorMinValue()
	{
		return vtkImageToPolyDataFilter_GetErrorMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToPolyDataFilter_GetLookupTable_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the vtkLookupTable to use. The lookup table is used when the
	/// color mode is set to LUT and a single component scalar is input.
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToPolyDataFilter_GetLookupTable_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageToPolyDataFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageToPolyDataFilter_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageToPolyDataFilter_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageToPolyDataFilter_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterations_16(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing iterations to smooth polygons. (Only
	/// in effect if output style is Polygonalize and smoothing is on.)
	/// </summary>
	public virtual int GetNumberOfSmoothingIterations()
	{
		return vtkImageToPolyDataFilter_GetNumberOfSmoothingIterations_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing iterations to smooth polygons. (Only
	/// in effect if output style is Polygonalize and smoothing is on.)
	/// </summary>
	public virtual int GetNumberOfSmoothingIterationsMaxValue()
	{
		return vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMinValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing iterations to smooth polygons. (Only
	/// in effect if output style is Polygonalize and smoothing is on.)
	/// </summary>
	public virtual int GetNumberOfSmoothingIterationsMinValue()
	{
		return vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetOutputStyle_19(HandleRef pThis);

	/// <summary>
	/// Specify how to create the output. Pixelize means converting the image
	/// to quad polygons with a constant color per quad. Polygonalize means
	/// merging colors together into polygonal regions, and then smoothing
	/// the regions (if smoothing is turned on). RunLength means creating
	/// quad polygons that may encompass several pixels on a scan line. The
	/// default behavior is Polygonalize.
	/// </summary>
	public virtual int GetOutputStyle()
	{
		return vtkImageToPolyDataFilter_GetOutputStyle_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetOutputStyleMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Specify how to create the output. Pixelize means converting the image
	/// to quad polygons with a constant color per quad. Polygonalize means
	/// merging colors together into polygonal regions, and then smoothing
	/// the regions (if smoothing is turned on). RunLength means creating
	/// quad polygons that may encompass several pixels on a scan line. The
	/// default behavior is Polygonalize.
	/// </summary>
	public virtual int GetOutputStyleMaxValue()
	{
		return vtkImageToPolyDataFilter_GetOutputStyleMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetOutputStyleMinValue_21(HandleRef pThis);

	/// <summary>
	/// Specify how to create the output. Pixelize means converting the image
	/// to quad polygons with a constant color per quad. Polygonalize means
	/// merging colors together into polygonal regions, and then smoothing
	/// the regions (if smoothing is turned on). RunLength means creating
	/// quad polygons that may encompass several pixels on a scan line. The
	/// default behavior is Polygonalize.
	/// </summary>
	public virtual int GetOutputStyleMinValue()
	{
		return vtkImageToPolyDataFilter_GetOutputStyleMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetSmoothing_22(HandleRef pThis);

	/// <summary>
	/// If the output style is set to polygonalize, then you can control
	/// whether to smooth boundaries.
	/// </summary>
	public virtual int GetSmoothing()
	{
		return vtkImageToPolyDataFilter_GetSmoothing_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetSubImageSize_23(HandleRef pThis);

	/// <summary>
	/// Specify the size (n by n pixels) of the largest region to
	/// polygonalize. When the OutputStyle is set to VTK_STYLE_POLYGONALIZE,
	/// large amounts of memory are used. In order to process large images,
	/// the image is broken into pieces that are at most Size pixels in
	/// width and height.
	/// </summary>
	public virtual int GetSubImageSize()
	{
		return vtkImageToPolyDataFilter_GetSubImageSize_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetSubImageSizeMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Specify the size (n by n pixels) of the largest region to
	/// polygonalize. When the OutputStyle is set to VTK_STYLE_POLYGONALIZE,
	/// large amounts of memory are used. In order to process large images,
	/// the image is broken into pieces that are at most Size pixels in
	/// width and height.
	/// </summary>
	public virtual int GetSubImageSizeMaxValue()
	{
		return vtkImageToPolyDataFilter_GetSubImageSizeMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_GetSubImageSizeMinValue_25(HandleRef pThis);

	/// <summary>
	/// Specify the size (n by n pixels) of the largest region to
	/// polygonalize. When the OutputStyle is set to VTK_STYLE_POLYGONALIZE,
	/// large amounts of memory are used. In order to process large images,
	/// the image is broken into pieces that are at most Size pixels in
	/// width and height.
	/// </summary>
	public virtual int GetSubImageSizeMinValue()
	{
		return vtkImageToPolyDataFilter_GetSubImageSizeMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_IsA_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageToPolyDataFilter_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageToPolyDataFilter_IsTypeOf_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageToPolyDataFilter_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToPolyDataFilter_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageToPolyDataFilter NewInstance()
	{
		vtkImageToPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToPolyDataFilter_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageToPolyDataFilter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageToPolyDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkImageToPolyDataFilter vtkImageToPolyDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageToPolyDataFilter_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageToPolyDataFilter2 = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageToPolyDataFilter2.Register(null);
			}
		}
		return vtkImageToPolyDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetColorMode_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how to quantize color.
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkImageToPolyDataFilter_SetColorMode_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetColorModeToLUT_32(HandleRef pThis);

	/// <summary>
	/// Specify how to quantize color.
	/// </summary>
	public void SetColorModeToLUT()
	{
		vtkImageToPolyDataFilter_SetColorModeToLUT_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetColorModeToLinear256_33(HandleRef pThis);

	/// <summary>
	/// Specify how to quantize color.
	/// </summary>
	public void SetColorModeToLinear256()
	{
		vtkImageToPolyDataFilter_SetColorModeToLinear256_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetDecimation_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether the final polygons should be decimated.
	/// whether to smooth boundaries.
	/// </summary>
	public virtual void SetDecimation(int _arg)
	{
		vtkImageToPolyDataFilter_SetDecimation_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetDecimationError_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the error to use for decimation (if decimation is on).
	/// The error is an absolute number--the image spacing and
	/// dimensions are used to create points so the error should be
	/// consistent with the image size.
	/// </summary>
	public virtual void SetDecimationError(double _arg)
	{
		vtkImageToPolyDataFilter_SetDecimationError_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetError_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the error value between two colors where the colors are
	/// considered the same. Only use this if the color mode uses the
	/// default 256 table.
	/// </summary>
	public virtual void SetError(int _arg)
	{
		vtkImageToPolyDataFilter_SetError_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetLookupTable_37(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the vtkLookupTable to use. The lookup table is used when the
	/// color mode is set to LUT and a single component scalar is input.
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors arg0)
	{
		vtkImageToPolyDataFilter_SetLookupTable_37(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetNumberOfSmoothingIterations_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of smoothing iterations to smooth polygons. (Only
	/// in effect if output style is Polygonalize and smoothing is on.)
	/// </summary>
	public virtual void SetNumberOfSmoothingIterations(int _arg)
	{
		vtkImageToPolyDataFilter_SetNumberOfSmoothingIterations_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetOutputStyle_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how to create the output. Pixelize means converting the image
	/// to quad polygons with a constant color per quad. Polygonalize means
	/// merging colors together into polygonal regions, and then smoothing
	/// the regions (if smoothing is turned on). RunLength means creating
	/// quad polygons that may encompass several pixels on a scan line. The
	/// default behavior is Polygonalize.
	/// </summary>
	public virtual void SetOutputStyle(int _arg)
	{
		vtkImageToPolyDataFilter_SetOutputStyle_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToPixelize_40(HandleRef pThis);

	/// <summary>
	/// Specify how to create the output. Pixelize means converting the image
	/// to quad polygons with a constant color per quad. Polygonalize means
	/// merging colors together into polygonal regions, and then smoothing
	/// the regions (if smoothing is turned on). RunLength means creating
	/// quad polygons that may encompass several pixels on a scan line. The
	/// default behavior is Polygonalize.
	/// </summary>
	public void SetOutputStyleToPixelize()
	{
		vtkImageToPolyDataFilter_SetOutputStyleToPixelize_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToPolygonalize_41(HandleRef pThis);

	/// <summary>
	/// Specify how to create the output. Pixelize means converting the image
	/// to quad polygons with a constant color per quad. Polygonalize means
	/// merging colors together into polygonal regions, and then smoothing
	/// the regions (if smoothing is turned on). RunLength means creating
	/// quad polygons that may encompass several pixels on a scan line. The
	/// default behavior is Polygonalize.
	/// </summary>
	public void SetOutputStyleToPolygonalize()
	{
		vtkImageToPolyDataFilter_SetOutputStyleToPolygonalize_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToRunLength_42(HandleRef pThis);

	/// <summary>
	/// Specify how to create the output. Pixelize means converting the image
	/// to quad polygons with a constant color per quad. Polygonalize means
	/// merging colors together into polygonal regions, and then smoothing
	/// the regions (if smoothing is turned on). RunLength means creating
	/// quad polygons that may encompass several pixels on a scan line. The
	/// default behavior is Polygonalize.
	/// </summary>
	public void SetOutputStyleToRunLength()
	{
		vtkImageToPolyDataFilter_SetOutputStyleToRunLength_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetSmoothing_43(HandleRef pThis, int _arg);

	/// <summary>
	/// If the output style is set to polygonalize, then you can control
	/// whether to smooth boundaries.
	/// </summary>
	public virtual void SetSmoothing(int _arg)
	{
		vtkImageToPolyDataFilter_SetSmoothing_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SetSubImageSize_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the size (n by n pixels) of the largest region to
	/// polygonalize. When the OutputStyle is set to VTK_STYLE_POLYGONALIZE,
	/// large amounts of memory are used. In order to process large images,
	/// the image is broken into pieces that are at most Size pixels in
	/// width and height.
	/// </summary>
	public virtual void SetSubImageSize(int _arg)
	{
		vtkImageToPolyDataFilter_SetSubImageSize_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SmoothingOff_45(HandleRef pThis);

	/// <summary>
	/// If the output style is set to polygonalize, then you can control
	/// whether to smooth boundaries.
	/// </summary>
	public virtual void SmoothingOff()
	{
		vtkImageToPolyDataFilter_SmoothingOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageToPolyDataFilter_SmoothingOn_46(HandleRef pThis);

	/// <summary>
	/// If the output style is set to polygonalize, then you can control
	/// whether to smooth boundaries.
	/// </summary>
	public virtual void SmoothingOn()
	{
		vtkImageToPolyDataFilter_SmoothingOn_46(GetCppThis());
	}
}
