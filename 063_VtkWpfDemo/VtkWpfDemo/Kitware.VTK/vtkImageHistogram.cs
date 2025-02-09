using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageHistogram
/// </summary>
/// <remarks>
///    Compute the histogram for an image.
///
/// vtkImageHistogram generates a histogram from its input, and optionally
/// produces a 2D black-and-white image of the histogram as its output.
/// Unlike the class vtkImageAccumulate, a multi-component image does not
/// result in a multi-dimensional histogram.  Instead, the resulting
/// histogram will be the sum of the histograms of each of the individual
/// components, unless SetActiveComponent is used to choose a single
/// component.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
public class vtkImageHistogram : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Scale types for the histogram image.
	/// </summary>
	public enum Linear_WrapperEnum
	{
		/// <summary>enum member</summary>
		Linear,
		/// <summary>enum member</summary>
		Log,
		/// <summary>enum member</summary>
		Sqrt
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageHistogram";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageHistogram()
	{
		MRClassNameKey = "class vtkImageHistogram";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHistogram"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageHistogram(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogram_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageHistogram New()
	{
		vtkImageHistogram result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageHistogram_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageHistogram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageHistogram()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageHistogram_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_AutomaticBinningOff_01(HandleRef pThis);

	/// <summary>
	/// If this is On, then the histogram binning will be done automatically.
	/// For char and unsigned char data, there will be 256 bins with unit
	/// spacing.  For data of type short and larger, there will be between
	/// 256 and MaximumNumberOfBins, depending on the range of the data, and
	/// the BinOrigin will be set to zero if no negative values are present,
	/// or to the smallest negative value if negative values are present.
	/// For float data, the MaximumNumberOfBins will always be used.
	/// The BinOrigin and BinSpacing will be set so that they provide a mapping
	/// from bin index to scalar value.
	/// </summary>
	public virtual void AutomaticBinningOff()
	{
		vtkImageHistogram_AutomaticBinningOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_AutomaticBinningOn_02(HandleRef pThis);

	/// <summary>
	/// If this is On, then the histogram binning will be done automatically.
	/// For char and unsigned char data, there will be 256 bins with unit
	/// spacing.  For data of type short and larger, there will be between
	/// 256 and MaximumNumberOfBins, depending on the range of the data, and
	/// the BinOrigin will be set to zero if no negative values are present,
	/// or to the smallest negative value if negative values are present.
	/// For float data, the MaximumNumberOfBins will always be used.
	/// The BinOrigin and BinSpacing will be set so that they provide a mapping
	/// from bin index to scalar value.
	/// </summary>
	public virtual void AutomaticBinningOn()
	{
		vtkImageHistogram_AutomaticBinningOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_GenerateHistogramImageOff_03(HandleRef pThis);

	/// <summary>
	/// If this is On, then a histogram image will be produced as the output.
	/// Regardless of this setting, the histogram is always available as a
	/// vtkIdTypeArray from the GetHistogram method.
	/// </summary>
	public virtual void GenerateHistogramImageOff()
	{
		vtkImageHistogram_GenerateHistogramImageOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_GenerateHistogramImageOn_04(HandleRef pThis);

	/// <summary>
	/// If this is On, then a histogram image will be produced as the output.
	/// Regardless of this setting, the histogram is always available as a
	/// vtkIdTypeArray from the GetHistogram method.
	/// </summary>
	public virtual void GenerateHistogramImageOn()
	{
		vtkImageHistogram_GenerateHistogramImageOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_GetActiveComponent_05(HandleRef pThis);

	/// <summary>
	/// Set the component for which to generate a histogram.  The default
	/// value is -1, which produces a histogram that is the sum of the
	/// histograms of the individual components.
	/// </summary>
	public virtual int GetActiveComponent()
	{
		return vtkImageHistogram_GetActiveComponent_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_GetAutomaticBinning_06(HandleRef pThis);

	/// <summary>
	/// If this is On, then the histogram binning will be done automatically.
	/// For char and unsigned char data, there will be 256 bins with unit
	/// spacing.  For data of type short and larger, there will be between
	/// 256 and MaximumNumberOfBins, depending on the range of the data, and
	/// the BinOrigin will be set to zero if no negative values are present,
	/// or to the smallest negative value if negative values are present.
	/// For float data, the MaximumNumberOfBins will always be used.
	/// The BinOrigin and BinSpacing will be set so that they provide a mapping
	/// from bin index to scalar value.
	/// </summary>
	public virtual int GetAutomaticBinning()
	{
		return vtkImageHistogram_GetAutomaticBinning_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageHistogram_GetBinOrigin_07(HandleRef pThis);

	/// <summary>
	/// The value for the center of the first bin (default 0).  This is
	/// automatically computed unless AutomaticBinning is Off.
	/// </summary>
	public virtual double GetBinOrigin()
	{
		return vtkImageHistogram_GetBinOrigin_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageHistogram_GetBinSpacing_08(HandleRef pThis);

	/// <summary>
	/// The bin spacing (default 1).  This is automatically computed unless
	/// AutomaticBinning is Off.
	/// </summary>
	public virtual double GetBinSpacing()
	{
		return vtkImageHistogram_GetBinSpacing_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_GetGenerateHistogramImage_09(HandleRef pThis);

	/// <summary>
	/// If this is On, then a histogram image will be produced as the output.
	/// Regardless of this setting, the histogram is always available as a
	/// vtkIdTypeArray from the GetHistogram method.
	/// </summary>
	public virtual int GetGenerateHistogramImage()
	{
		return vtkImageHistogram_GetGenerateHistogramImage_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogram_GetHistogram_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the histogram as a vtkIdTypeArray.  You must call Update()
	/// before calling this method.
	/// </summary>
	public vtkIdTypeArray GetHistogram()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageHistogram_GetHistogram_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_GetHistogramImageScale_11(HandleRef pThis);

	/// <summary>
	/// Set the scale to use for the histogram image.  The default is
	/// a linear scale, but sqrt and log provide better visualization.
	/// </summary>
	public virtual int GetHistogramImageScale()
	{
		return vtkImageHistogram_GetHistogramImageScale_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogram_GetHistogramImageScaleAsString_12(HandleRef pThis);

	/// <summary>
	/// Set the scale to use for the histogram image.  The default is
	/// a linear scale, but sqrt and log provide better visualization.
	/// </summary>
	public string GetHistogramImageScaleAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageHistogram_GetHistogramImageScaleAsString_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_GetHistogramImageScaleMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set the scale to use for the histogram image.  The default is
	/// a linear scale, but sqrt and log provide better visualization.
	/// </summary>
	public virtual int GetHistogramImageScaleMaxValue()
	{
		return vtkImageHistogram_GetHistogramImageScaleMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_GetHistogramImageScaleMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set the scale to use for the histogram image.  The default is
	/// a linear scale, but sqrt and log provide better visualization.
	/// </summary>
	public virtual int GetHistogramImageScaleMinValue()
	{
		return vtkImageHistogram_GetHistogramImageScaleMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogram_GetHistogramImageSize_15(HandleRef pThis);

	/// <summary>
	/// Set the size of the histogram image that is produced as output.
	/// The default is 256 by 256.
	/// </summary>
	public virtual int[] GetHistogramImageSize()
	{
		IntPtr intPtr = vtkImageHistogram_GetHistogramImageSize_15(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_GetHistogramImageSize_16(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set the size of the histogram image that is produced as output.
	/// The default is 256 by 256.
	/// </summary>
	public virtual void GetHistogramImageSize(ref int _arg1, ref int _arg2)
	{
		vtkImageHistogram_GetHistogramImageSize_16(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_GetHistogramImageSize_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the size of the histogram image that is produced as output.
	/// The default is 256 by 256.
	/// </summary>
	public virtual void GetHistogramImageSize(IntPtr _arg)
	{
		vtkImageHistogram_GetHistogramImageSize_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_GetMaximumNumberOfBins_18(HandleRef pThis);

	/// <summary>
	/// The maximum number of bins to use when AutomaticBinning is On.
	/// When AutomaticBinning is On, the size of the output histogram
	/// will be set to the full range of the input data values, unless
	/// the full range is greater than this value.  By default, the max
	/// value is 65536, which is large enough to capture the full range
	/// of 16-bit integers.
	/// </summary>
	public virtual int GetMaximumNumberOfBins()
	{
		return vtkImageHistogram_GetMaximumNumberOfBins_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_GetNumberOfBins_19(HandleRef pThis);

	/// <summary>
	/// The number of bins in histogram (default 256).  This is automatically
	/// computed unless AutomaticBinning is Off.
	/// </summary>
	public virtual int GetNumberOfBins()
	{
		return vtkImageHistogram_GetNumberOfBins_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageHistogram_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageHistogram_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageHistogram_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageHistogram_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogram_GetStencil_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Use a stencil to compute the histogram for just a part of the image.
	/// </summary>
	public vtkImageStencilData GetStencil()
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageHistogram_GetStencil_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageHistogram_GetTotal_23(HandleRef pThis);

	/// <summary>
	/// Get the total count of the histogram.  This will be the number of
	/// voxels times the number of components.
	/// </summary>
	public long GetTotal()
	{
		return vtkImageHistogram_GetTotal_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageHistogram_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogram_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageHistogram_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogram_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageHistogram NewInstance()
	{
		vtkImageHistogram result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageHistogram_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageHistogram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogram_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageHistogram SafeDownCast(vtkObjectBase o)
	{
		vtkImageHistogram vtkImageHistogram2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageHistogram_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageHistogram2 = (vtkImageHistogram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageHistogram2.Register(null);
			}
		}
		return vtkImageHistogram2;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetActiveComponent_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the component for which to generate a histogram.  The default
	/// value is -1, which produces a histogram that is the sum of the
	/// histograms of the individual components.
	/// </summary>
	public virtual void SetActiveComponent(int _arg)
	{
		vtkImageHistogram_SetActiveComponent_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetAutomaticBinning_30(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is On, then the histogram binning will be done automatically.
	/// For char and unsigned char data, there will be 256 bins with unit
	/// spacing.  For data of type short and larger, there will be between
	/// 256 and MaximumNumberOfBins, depending on the range of the data, and
	/// the BinOrigin will be set to zero if no negative values are present,
	/// or to the smallest negative value if negative values are present.
	/// For float data, the MaximumNumberOfBins will always be used.
	/// The BinOrigin and BinSpacing will be set so that they provide a mapping
	/// from bin index to scalar value.
	/// </summary>
	public virtual void SetAutomaticBinning(int _arg)
	{
		vtkImageHistogram_SetAutomaticBinning_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetBinOrigin_31(HandleRef pThis, double _arg);

	/// <summary>
	/// The value for the center of the first bin (default 0).  This is
	/// automatically computed unless AutomaticBinning is Off.
	/// </summary>
	public virtual void SetBinOrigin(double _arg)
	{
		vtkImageHistogram_SetBinOrigin_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetBinSpacing_32(HandleRef pThis, double _arg);

	/// <summary>
	/// The bin spacing (default 1).  This is automatically computed unless
	/// AutomaticBinning is Off.
	/// </summary>
	public virtual void SetBinSpacing(double _arg)
	{
		vtkImageHistogram_SetBinSpacing_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetGenerateHistogramImage_33(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is On, then a histogram image will be produced as the output.
	/// Regardless of this setting, the histogram is always available as a
	/// vtkIdTypeArray from the GetHistogram method.
	/// </summary>
	public virtual void SetGenerateHistogramImage(int _arg)
	{
		vtkImageHistogram_SetGenerateHistogramImage_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetHistogramImageScale_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the scale to use for the histogram image.  The default is
	/// a linear scale, but sqrt and log provide better visualization.
	/// </summary>
	public virtual void SetHistogramImageScale(int _arg)
	{
		vtkImageHistogram_SetHistogramImageScale_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetHistogramImageScaleToLinear_35(HandleRef pThis);

	/// <summary>
	/// Set the scale to use for the histogram image.  The default is
	/// a linear scale, but sqrt and log provide better visualization.
	/// </summary>
	public void SetHistogramImageScaleToLinear()
	{
		vtkImageHistogram_SetHistogramImageScaleToLinear_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetHistogramImageScaleToLog_36(HandleRef pThis);

	/// <summary>
	/// Set the scale to use for the histogram image.  The default is
	/// a linear scale, but sqrt and log provide better visualization.
	/// </summary>
	public void SetHistogramImageScaleToLog()
	{
		vtkImageHistogram_SetHistogramImageScaleToLog_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetHistogramImageScaleToSqrt_37(HandleRef pThis);

	/// <summary>
	/// Set the scale to use for the histogram image.  The default is
	/// a linear scale, but sqrt and log provide better visualization.
	/// </summary>
	public void SetHistogramImageScaleToSqrt()
	{
		vtkImageHistogram_SetHistogramImageScaleToSqrt_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetHistogramImageSize_38(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the size of the histogram image that is produced as output.
	/// The default is 256 by 256.
	/// </summary>
	public virtual void SetHistogramImageSize(int _arg1, int _arg2)
	{
		vtkImageHistogram_SetHistogramImageSize_38(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetHistogramImageSize_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the size of the histogram image that is produced as output.
	/// The default is 256 by 256.
	/// </summary>
	public void SetHistogramImageSize(IntPtr _arg)
	{
		vtkImageHistogram_SetHistogramImageSize_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetMaximumNumberOfBins_40(HandleRef pThis, int _arg);

	/// <summary>
	/// The maximum number of bins to use when AutomaticBinning is On.
	/// When AutomaticBinning is On, the size of the output histogram
	/// will be set to the full range of the input data values, unless
	/// the full range is greater than this value.  By default, the max
	/// value is 65536, which is large enough to capture the full range
	/// of 16-bit integers.
	/// </summary>
	public virtual void SetMaximumNumberOfBins(int _arg)
	{
		vtkImageHistogram_SetMaximumNumberOfBins_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetNumberOfBins_41(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of bins in histogram (default 256).  This is automatically
	/// computed unless AutomaticBinning is Off.
	/// </summary>
	public virtual void SetNumberOfBins(int _arg)
	{
		vtkImageHistogram_SetNumberOfBins_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetStencilConnection_42(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Equivalent to SetInputConnection(1, algOutput).
	/// </summary>
	public void SetStencilConnection(vtkAlgorithmOutput algOutput)
	{
		vtkImageHistogram_SetStencilConnection_42(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogram_SetStencilData_43(HandleRef pThis, HandleRef stencil);

	/// <summary>
	/// Use a stencil to compute the histogram for just a part of the image.
	/// </summary>
	public void SetStencilData(vtkImageStencilData stencil)
	{
		vtkImageHistogram_SetStencilData_43(GetCppThis(), stencil?.GetCppThis() ?? default(HandleRef));
	}
}
