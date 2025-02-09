using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageHistogramStatistics
/// </summary>
/// <remarks>
///    Compute statistics for an image
///
/// vtkImageHistogramStatistics computes statistics such as mean, median, and
/// standard deviation.  These statistics are computed from the histogram
/// of the image, rather than from the image itself, because this is more
/// efficient than computing the statistics while traversing the pixels.
/// If the input image is of type float or double, then the precision of
/// the Mean, Median, and StandardDeviation will depend on the number of
/// histogram bins.  By default, 65536 bins are used for float data, giving
/// at least 16 bits of precision.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
public class vtkImageHistogramStatistics : vtkImageHistogram
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageHistogramStatistics";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageHistogramStatistics()
	{
		MRClassNameKey = "class vtkImageHistogramStatistics";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHistogramStatistics"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageHistogramStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogramStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageHistogramStatistics New()
	{
		vtkImageHistogramStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageHistogramStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageHistogramStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageHistogramStatistics()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageHistogramStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImageHistogramStatistics_GetAutoRange_01(HandleRef pThis);

	/// <summary>
	/// Get an automatically computed view range for the image, for use
	/// with the lookup table or image property that is used when viewing
	/// the image.  The use of this range will avoid situations where an
	/// image looks too dark because a few pixels happen to be much brighter
	/// than the rest.
	/// </summary>
	public virtual double[] GetAutoRange()
	{
		IntPtr intPtr = vtkImageHistogramStatistics_GetAutoRange_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_GetAutoRange_02(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Get an automatically computed view range for the image, for use
	/// with the lookup table or image property that is used when viewing
	/// the image.  The use of this range will avoid situations where an
	/// image looks too dark because a few pixels happen to be much brighter
	/// than the rest.
	/// </summary>
	public virtual void GetAutoRange(ref double _arg1, ref double _arg2)
	{
		vtkImageHistogramStatistics_GetAutoRange_02(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_GetAutoRange_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get an automatically computed view range for the image, for use
	/// with the lookup table or image property that is used when viewing
	/// the image.  The use of this range will avoid situations where an
	/// image looks too dark because a few pixels happen to be much brighter
	/// than the rest.
	/// </summary>
	public virtual void GetAutoRange(IntPtr _arg)
	{
		vtkImageHistogramStatistics_GetAutoRange_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_04(HandleRef pThis);

	/// <summary>
	/// Set lower and upper expansion factors to apply to the auto range
	/// that was computed from the AutoRangePercentiles.  Any outliers that
	/// are within this expanded range will be included, even if they are
	/// beyond the percentile.  This allows inclusion of values that are
	/// just slightly outside of the percentile, while rejecting values
	/// that are far beyond the percentile.  The default is to expand the
	/// range by a factor of 0.1 at each end.  The range will never be
	/// expanded beyond the Minimum or Maximum pixel values.
	/// </summary>
	public virtual double[] GetAutoRangeExpansionFactors()
	{
		IntPtr intPtr = vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_05(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set lower and upper expansion factors to apply to the auto range
	/// that was computed from the AutoRangePercentiles.  Any outliers that
	/// are within this expanded range will be included, even if they are
	/// beyond the percentile.  This allows inclusion of values that are
	/// just slightly outside of the percentile, while rejecting values
	/// that are far beyond the percentile.  The default is to expand the
	/// range by a factor of 0.1 at each end.  The range will never be
	/// expanded beyond the Minimum or Maximum pixel values.
	/// </summary>
	public virtual void GetAutoRangeExpansionFactors(ref double _arg1, ref double _arg2)
	{
		vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_05(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set lower and upper expansion factors to apply to the auto range
	/// that was computed from the AutoRangePercentiles.  Any outliers that
	/// are within this expanded range will be included, even if they are
	/// beyond the percentile.  This allows inclusion of values that are
	/// just slightly outside of the percentile, while rejecting values
	/// that are far beyond the percentile.  The default is to expand the
	/// range by a factor of 0.1 at each end.  The range will never be
	/// expanded beyond the Minimum or Maximum pixel values.
	/// </summary>
	public virtual void GetAutoRangeExpansionFactors(IntPtr _arg)
	{
		vtkImageHistogramStatistics_GetAutoRangeExpansionFactors_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogramStatistics_GetAutoRangePercentiles_07(HandleRef pThis);

	/// <summary>
	/// Set the percentiles to use for automatic view range computation.
	/// This allows one to compute a range that does not include outliers
	/// that are significantly darker or significantly brighter than the
	/// rest of the pixels in the image.  The default is to use the first
	/// percentile and the 99th percentile.
	/// </summary>
	public virtual double[] GetAutoRangePercentiles()
	{
		IntPtr intPtr = vtkImageHistogramStatistics_GetAutoRangePercentiles_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_GetAutoRangePercentiles_08(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the percentiles to use for automatic view range computation.
	/// This allows one to compute a range that does not include outliers
	/// that are significantly darker or significantly brighter than the
	/// rest of the pixels in the image.  The default is to use the first
	/// percentile and the 99th percentile.
	/// </summary>
	public virtual void GetAutoRangePercentiles(ref double _arg1, ref double _arg2)
	{
		vtkImageHistogramStatistics_GetAutoRangePercentiles_08(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_GetAutoRangePercentiles_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the percentiles to use for automatic view range computation.
	/// This allows one to compute a range that does not include outliers
	/// that are significantly darker or significantly brighter than the
	/// rest of the pixels in the image.  The default is to use the first
	/// percentile and the 99th percentile.
	/// </summary>
	public virtual void GetAutoRangePercentiles(IntPtr _arg)
	{
		vtkImageHistogramStatistics_GetAutoRangePercentiles_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageHistogramStatistics_GetMaximum_10(HandleRef pThis);

	/// <summary>
	/// Get the maximum value present in the image.  This value is computed
	/// when Update() is called.
	/// </summary>
	public double GetMaximum()
	{
		return vtkImageHistogramStatistics_GetMaximum_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageHistogramStatistics_GetMean_11(HandleRef pThis);

	/// <summary>
	/// Get the mean value of the image.  This value is computed when Update()
	/// is called.
	/// </summary>
	public double GetMean()
	{
		return vtkImageHistogramStatistics_GetMean_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageHistogramStatistics_GetMedian_12(HandleRef pThis);

	/// <summary>
	/// Get the median value.  This is computed when Update() is called.
	/// </summary>
	public double GetMedian()
	{
		return vtkImageHistogramStatistics_GetMedian_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageHistogramStatistics_GetMinimum_13(HandleRef pThis);

	/// <summary>
	/// Get the minimum value present in the image.  This value is computed
	/// when Update() is called.
	/// </summary>
	public double GetMinimum()
	{
		return vtkImageHistogramStatistics_GetMinimum_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageHistogramStatistics_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageHistogramStatistics_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageHistogramStatistics_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageHistogramStatistics_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageHistogramStatistics_GetStandardDeviation_16(HandleRef pThis);

	/// <summary>
	/// Get the standard deviation of the values in the image.  This is
	/// computed when Update() is called.
	/// </summary>
	public double GetStandardDeviation()
	{
		return vtkImageHistogramStatistics_GetStandardDeviation_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogramStatistics_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageHistogramStatistics_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageHistogramStatistics_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageHistogramStatistics_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogramStatistics_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageHistogramStatistics NewInstance()
	{
		vtkImageHistogramStatistics result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageHistogramStatistics_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageHistogramStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageHistogramStatistics_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageHistogramStatistics SafeDownCast(vtkObjectBase o)
	{
		vtkImageHistogramStatistics vtkImageHistogramStatistics2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageHistogramStatistics_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageHistogramStatistics2 = (vtkImageHistogramStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageHistogramStatistics2.Register(null);
			}
		}
		return vtkImageHistogramStatistics2;
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_SetAutoRangeExpansionFactors_22(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set lower and upper expansion factors to apply to the auto range
	/// that was computed from the AutoRangePercentiles.  Any outliers that
	/// are within this expanded range will be included, even if they are
	/// beyond the percentile.  This allows inclusion of values that are
	/// just slightly outside of the percentile, while rejecting values
	/// that are far beyond the percentile.  The default is to expand the
	/// range by a factor of 0.1 at each end.  The range will never be
	/// expanded beyond the Minimum or Maximum pixel values.
	/// </summary>
	public virtual void SetAutoRangeExpansionFactors(double _arg1, double _arg2)
	{
		vtkImageHistogramStatistics_SetAutoRangeExpansionFactors_22(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_SetAutoRangeExpansionFactors_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set lower and upper expansion factors to apply to the auto range
	/// that was computed from the AutoRangePercentiles.  Any outliers that
	/// are within this expanded range will be included, even if they are
	/// beyond the percentile.  This allows inclusion of values that are
	/// just slightly outside of the percentile, while rejecting values
	/// that are far beyond the percentile.  The default is to expand the
	/// range by a factor of 0.1 at each end.  The range will never be
	/// expanded beyond the Minimum or Maximum pixel values.
	/// </summary>
	public void SetAutoRangeExpansionFactors(IntPtr _arg)
	{
		vtkImageHistogramStatistics_SetAutoRangeExpansionFactors_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_SetAutoRangePercentiles_24(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the percentiles to use for automatic view range computation.
	/// This allows one to compute a range that does not include outliers
	/// that are significantly darker or significantly brighter than the
	/// rest of the pixels in the image.  The default is to use the first
	/// percentile and the 99th percentile.
	/// </summary>
	public virtual void SetAutoRangePercentiles(double _arg1, double _arg2)
	{
		vtkImageHistogramStatistics_SetAutoRangePercentiles_24(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageHistogramStatistics_SetAutoRangePercentiles_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the percentiles to use for automatic view range computation.
	/// This allows one to compute a range that does not include outliers
	/// that are significantly darker or significantly brighter than the
	/// rest of the pixels in the image.  The default is to use the first
	/// percentile and the 99th percentile.
	/// </summary>
	public void SetAutoRangePercentiles(IntPtr _arg)
	{
		vtkImageHistogramStatistics_SetAutoRangePercentiles_25(GetCppThis(), _arg);
	}
}
