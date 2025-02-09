using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelCoordinatesHistogramRepresentation
/// </summary>
/// <remarks>
///    Data representation
///  that takes generic multivariate data and produces a parallel coordinates plot.
///  This plot optionally can draw a histogram-based plot summary.
///
///
///  A parallel coordinates plot represents each variable in a multivariate
///  data set as a separate axis.  Individual samples of that data set are
///  represented as a polyline that pass through each variable axis at
///  positions that correspond to data values.  This class can generate
///  parallel coordinates plots identical to its superclass
///  (vtkParallelCoordinatesRepresentation) and has the same interaction
///  styles.
///
///  In addition to the standard parallel coordinates plot, this class also
///  can draw a histogram summary of the parallel coordinates plot.
///  Rather than draw every row in an input data set, first it computes
///  a 2D histogram for all neighboring variable axes, then it draws
///  bar (thickness corresponds to bin size) for each bin the histogram
///  with opacity weighted by the number of rows contained in the bin.
///  The result is essentially a density map.
///
///  Because this emphasizes dense regions over sparse outliers, this class
///  also uses a vtkComputeHistogram2DOutliers instance to identify outlier
///  table rows and draws those as standard parallel coordinates lines.
///
/// </remarks>
/// <seealso>
///
///  vtkParallelCoordinatesView vtkParallelCoordinatesRepresentation
///  vtkExtractHistogram2D vtkComputeHistogram2DOutliers
///
/// @par Thanks:
///  Developed by David Feng at Sandia National Laboratories
/// </seealso>
public class vtkParallelCoordinatesHistogramRepresentation : vtkParallelCoordinatesRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesHistogramRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelCoordinatesHistogramRepresentation()
	{
		MRClassNameKey = "class vtkParallelCoordinatesHistogramRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesHistogramRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelCoordinatesHistogramRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesHistogramRepresentation New()
	{
		vtkParallelCoordinatesHistogramRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkParallelCoordinatesHistogramRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParallelCoordinatesHistogramRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

	/// <summary>
	/// Apply the theme to this view.
	/// </summary>
	public override void ApplyViewTheme(vtkViewTheme theme)
	{
		vtkParallelCoordinatesHistogramRepresentation_ApplyViewTheme_01(GetCppThis(), theme?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_02(HandleRef pThis);

	/// <summary>
	/// Control over the range of the lookup table used to draw the histogram quads.
	/// </summary>
	public virtual double[] GetHistogramLookupTableRange()
	{
		IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_03(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Control over the range of the lookup table used to draw the histogram quads.
	/// </summary>
	public virtual void GetHistogramLookupTableRange(ref double _arg1, ref double _arg2)
	{
		vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_03(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Control over the range of the lookup table used to draw the histogram quads.
	/// </summary>
	public virtual void GetHistogramLookupTableRange(IntPtr _arg)
	{
		vtkParallelCoordinatesHistogramRepresentation_GetHistogramLookupTableRange_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesHistogramRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelCoordinatesHistogramRepresentation_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelCoordinatesHistogramRepresentation_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelCoordinatesHistogramRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_07(HandleRef pThis);

	/// <summary>
	/// The number of histogram bins on either side of each pair of axes.
	/// </summary>
	public virtual int[] GetNumberOfHistogramBins()
	{
		IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_08(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// The number of histogram bins on either side of each pair of axes.
	/// </summary>
	public virtual void GetNumberOfHistogramBins(ref int _arg1, ref int _arg2)
	{
		vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_08(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The number of histogram bins on either side of each pair of axes.
	/// </summary>
	public virtual void GetNumberOfHistogramBins(IntPtr _arg)
	{
		vtkParallelCoordinatesHistogramRepresentation_GetNumberOfHistogramBins_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetPreferredNumberOfOutliers_10(HandleRef pThis);

	/// <summary>
	/// Target maximum number of outliers to be drawn, although not guaranteed.
	/// </summary>
	public virtual int GetPreferredNumberOfOutliers()
	{
		return vtkParallelCoordinatesHistogramRepresentation_GetPreferredNumberOfOutliers_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetShowOutliers_11(HandleRef pThis);

	/// <summary>
	/// Whether to compute and show outlier lines
	/// </summary>
	public virtual int GetShowOutliers()
	{
		return vtkParallelCoordinatesHistogramRepresentation_GetShowOutliers_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesHistogramRepresentation_GetUseHistograms_12(HandleRef pThis);

	/// <summary>
	/// Whether to use the histogram rendering mode or the superclass's line rendering mode
	/// </summary>
	public virtual int GetUseHistograms()
	{
		return vtkParallelCoordinatesHistogramRepresentation_GetUseHistograms_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesHistogramRepresentation_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelCoordinatesHistogramRepresentation_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesHistogramRepresentation_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelCoordinatesHistogramRepresentation_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParallelCoordinatesHistogramRepresentation NewInstance()
	{
		vtkParallelCoordinatesHistogramRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelCoordinatesHistogramRepresentation_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelCoordinatesHistogramRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkParallelCoordinatesHistogramRepresentation vtkParallelCoordinatesHistogramRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelCoordinatesHistogramRepresentation_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelCoordinatesHistogramRepresentation2 = (vtkParallelCoordinatesHistogramRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelCoordinatesHistogramRepresentation2.Register(null);
			}
		}
		return vtkParallelCoordinatesHistogramRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_18(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Control over the range of the lookup table used to draw the histogram quads.
	/// </summary>
	public virtual void SetHistogramLookupTableRange(double _arg1, double _arg2)
	{
		vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_18(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Control over the range of the lookup table used to draw the histogram quads.
	/// </summary>
	public void SetHistogramLookupTableRange(IntPtr _arg)
	{
		vtkParallelCoordinatesHistogramRepresentation_SetHistogramLookupTableRange_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_20(HandleRef pThis, int arg0, int arg1);

	/// <summary>
	/// The number of histogram bins on either side of each pair of axes.
	/// </summary>
	public void SetNumberOfHistogramBins(int arg0, int arg1)
	{
		vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_20(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_21(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// The number of histogram bins on either side of each pair of axes.
	/// </summary>
	public void SetNumberOfHistogramBins(IntPtr arg0)
	{
		vtkParallelCoordinatesHistogramRepresentation_SetNumberOfHistogramBins_21(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetPreferredNumberOfOutliers_22(HandleRef pThis, int arg0);

	/// <summary>
	/// Target maximum number of outliers to be drawn, although not guaranteed.
	/// </summary>
	public void SetPreferredNumberOfOutliers(int arg0)
	{
		vtkParallelCoordinatesHistogramRepresentation_SetPreferredNumberOfOutliers_22(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesHistogramRepresentation_SetRangeAtPosition_23(HandleRef pThis, int position, IntPtr range);

	/// <summary>
	/// Calls the superclass method, and assures that only the two histograms
	/// affect by this call get recomputed.
	/// </summary>
	public override int SetRangeAtPosition(int position, IntPtr range)
	{
		return vtkParallelCoordinatesHistogramRepresentation_SetRangeAtPosition_23(GetCppThis(), position, range);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetShowOutliers_24(HandleRef pThis, int arg0);

	/// <summary>
	/// Whether to compute and show outlier lines
	/// </summary>
	public virtual void SetShowOutliers(int arg0)
	{
		vtkParallelCoordinatesHistogramRepresentation_SetShowOutliers_24(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_SetUseHistograms_25(HandleRef pThis, int arg0);

	/// <summary>
	/// Whether to use the histogram rendering mode or the superclass's line rendering mode
	/// </summary>
	public virtual void SetUseHistograms(int arg0)
	{
		vtkParallelCoordinatesHistogramRepresentation_SetUseHistograms_25(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOff_26(HandleRef pThis);

	/// <summary>
	/// Whether to compute and show outlier lines
	/// </summary>
	public virtual void ShowOutliersOff()
	{
		vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOn_27(HandleRef pThis);

	/// <summary>
	/// Whether to compute and show outlier lines
	/// </summary>
	public virtual void ShowOutliersOn()
	{
		vtkParallelCoordinatesHistogramRepresentation_ShowOutliersOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelCoordinatesHistogramRepresentation_SwapAxisPositions_28(HandleRef pThis, int position1, int position2);

	/// <summary>
	/// Calls superclass swap, and assures that only histograms affected by the
	/// swap get recomputed.
	/// </summary>
	public override int SwapAxisPositions(int position1, int position2)
	{
		return vtkParallelCoordinatesHistogramRepresentation_SwapAxisPositions_28(GetCppThis(), position1, position2);
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOff_29(HandleRef pThis);

	/// <summary>
	/// Whether to use the histogram rendering mode or the superclass's line rendering mode
	/// </summary>
	public virtual void UseHistogramsOff()
	{
		vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOn_30(HandleRef pThis);

	/// <summary>
	/// Whether to use the histogram rendering mode or the superclass's line rendering mode
	/// </summary>
	public virtual void UseHistogramsOn()
	{
		vtkParallelCoordinatesHistogramRepresentation_UseHistogramsOn_30(GetCppThis());
	}
}
