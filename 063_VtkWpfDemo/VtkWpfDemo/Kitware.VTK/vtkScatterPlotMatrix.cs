using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkScatterPlotMatrix
/// </summary>
/// <remarks>
///    container for a matrix of charts.
///
///
/// This class contains a matrix of charts. These charts will be of type
/// vtkChartXY by default, but this can be overridden. The class will manage
/// their layout and object lifetime.
/// </remarks>
public class vtkScatterPlotMatrix : vtkChartMatrix
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum ACTIVEPLOT_WrapperEnum
	{
		/// <summary>enum member</summary>
		ACTIVEPLOT = 2,
		/// <summary>enum member</summary>
		HISTOGRAM = 1,
		/// <summary>enum member</summary>
		NOPLOT = 3,
		/// <summary>enum member</summary>
		SCATTERPLOT = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScatterPlotMatrix";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScatterPlotMatrix()
	{
		MRClassNameKey = "class vtkScatterPlotMatrix";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScatterPlotMatrix"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScatterPlotMatrix(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new object.
	/// </summary>
	public new static vtkScatterPlotMatrix New()
	{
		vtkScatterPlotMatrix result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScatterPlotMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a new object.
	/// </summary>
	public vtkScatterPlotMatrix()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkScatterPlotMatrix_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScatterPlotMatrix_AddAnimationPath_01(HandleRef pThis, HandleRef move);

	/// <summary>
	/// Add a move to the animation path. Note that a move can only change i or j,
	/// not both. If the proposed move does not satisfy those criteria it will
	/// be rejected and the animation path will not be extended.
	/// </summary>
	public bool AddAnimationPath(vtkVector2i move)
	{
		return (vtkScatterPlotMatrix_AddAnimationPath_01(GetCppThis(), move?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_AdvanceAnimation_02(HandleRef pThis);

	/// <summary>
	/// Advance the animation in response to the timer events. This is public to
	/// allow the animation to be manually advanced when timers are not a
	/// </summary>
	public virtual void AdvanceAnimation()
	{
		vtkScatterPlotMatrix_AdvanceAnimation_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScatterPlotMatrix_BeginAnimationPath_03(HandleRef pThis, HandleRef interactor);

	/// <summary>
	/// Trigger the animation of the scatter plot matrix to begin.
	/// </summary>
	public bool BeginAnimationPath(vtkRenderWindowInteractor interactor)
	{
		return (vtkScatterPlotMatrix_BeginAnimationPath_03(GetCppThis(), interactor?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_ClearAnimationPath_04(HandleRef pThis);

	/// <summary>
	/// Clear the animation path.
	/// </summary>
	public void ClearAnimationPath()
	{
		vtkScatterPlotMatrix_ClearAnimationPath_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetActivePlot_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the position of the active plot.
	/// </summary>
	public virtual vtkVector2i GetActivePlot()
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetActivePlot_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetAnimationPathElement_06(HandleRef pThis, long i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the element specified from the animation path.
	/// </summary>
	public vtkVector2i GetAnimationPathElement(long i)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetAnimationPathElement_06(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetAnnotationLink_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the AnnotationLink for the scatter plot matrix, this gives you access
	/// to the currently selected points in the scatter plot matrix.
	/// </summary>
	public vtkAnnotationLink GetAnnotationLink()
	{
		vtkAnnotationLink vtkAnnotationLink2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetAnnotationLink_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLink2 = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLink2.Register(null);
			}
		}
		return vtkAnnotationLink2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetAxisColor_08(HandleRef pThis, int plotType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Sets the color for the axes given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public vtkColor4ub GetAxisColor(int plotType)
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetAxisColor_08(GetCppThis(), plotType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetAxisLabelNotation_09(HandleRef pThis, int plotType);

	/// <summary>
	/// Sets the axis label notation for the axes given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public int GetAxisLabelNotation(int plotType)
	{
		return vtkScatterPlotMatrix_GetAxisLabelNotation_09(GetCppThis(), plotType);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetAxisLabelPrecision_10(HandleRef pThis, int plotType);

	/// <summary>
	/// Sets the axis label precision for the axes given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public int GetAxisLabelPrecision(int plotType)
	{
		return vtkScatterPlotMatrix_GetAxisLabelPrecision_10(GetCppThis(), plotType);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetAxisLabelProperties_11(HandleRef pThis, int plotType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the text property for the axis labels of the given plot type,
	/// possible types are vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public vtkTextProperty GetAxisLabelProperties(int plotType)
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetAxisLabelProperties_11(GetCppThis(), plotType, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScatterPlotMatrix_GetAxisLabelVisibility_12(HandleRef pThis, int plotType);

	/// <summary>
	/// Sets whether or not the labels for the axes are visible, given a plot type,
	/// which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public bool GetAxisLabelVisibility(int plotType)
	{
		return (vtkScatterPlotMatrix_GetAxisLabelVisibility_12(GetCppThis(), plotType) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetBackgroundColor_13(HandleRef pThis, int plotType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Sets the background color for the chart given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public vtkColor4ub GetBackgroundColor(int plotType)
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetBackgroundColor_13(GetCppThis(), plotType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkScatterPlotMatrix_GetColumnName_14(HandleRef pThis, int column);

	/// <summary>
	/// Get the column name for the supplied index.
	/// </summary>
	public string GetColumnName(int column)
	{
		return vtkScatterPlotMatrix_GetColumnName_14(GetCppThis(), column);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScatterPlotMatrix_GetColumnVisibility_15(HandleRef pThis, string name);

	/// <summary>
	/// Get the visibility of the specified column.
	/// </summary>
	public bool GetColumnVisibility(string name)
	{
		return (vtkScatterPlotMatrix_GetColumnVisibility_15(GetCppThis(), name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetGridColor_16(HandleRef pThis, int plotType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Sets the color for the axes given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public vtkColor4ub GetGridColor(int plotType)
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetGridColor_16(GetCppThis(), plotType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScatterPlotMatrix_GetGridVisibility_17(HandleRef pThis, int plotType);

	/// <summary>
	/// Sets whether or not the grid for the given axis is visible given a plot
	/// type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public bool GetGridVisibility(int plotType)
	{
		return (vtkScatterPlotMatrix_GetGridVisibility_17(GetCppThis(), plotType) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetIndexedLabels_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the indexed labels array.
	/// </summary>
	public vtkStringArray GetIndexedLabels()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetIndexedLabels_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetMainChart_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the main plot (the one in the top-right of the matrix.
	/// </summary>
	public virtual vtkChart GetMainChart()
	{
		vtkChart vtkChart2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetMainChart_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChart2 = (vtkChart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChart2.Register(null);
			}
		}
		return vtkChart2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScatterPlotMatrix_GetNumberOfAnimationPathElements_20(HandleRef pThis);

	/// <summary>
	/// Get the number of elements (transitions) in the animation path.
	/// </summary>
	public long GetNumberOfAnimationPathElements()
	{
		return vtkScatterPlotMatrix_GetNumberOfAnimationPathElements_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetNumberOfBins_21(HandleRef pThis);

	/// <summary>
	/// Get the number of bins the histograms along the central diagonal scatter
	/// plot matrix. The default value is 10.
	/// </summary>
	public virtual int GetNumberOfBins()
	{
		return vtkScatterPlotMatrix_GetNumberOfBins_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetNumberOfFrames_22(HandleRef pThis);

	/// <summary>
	/// Get the number of animation frames in each transition. Default is 25,
	/// and 0 means to animations between axes.
	/// </summary>
	public int GetNumberOfFrames()
	{
		return vtkScatterPlotMatrix_GetNumberOfFrames_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScatterPlotMatrix_GetNumberOfGenerationsFromBase_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScatterPlotMatrix_GetNumberOfGenerationsFromBase_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScatterPlotMatrix_GetNumberOfGenerationsFromBaseType_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScatterPlotMatrix_GetNumberOfGenerationsFromBaseType_24(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetPlotType_25(HandleRef pThis, HandleRef pos);

	/// <summary>
	/// Returns the type of the plot at the given position. The return
	/// value is one of: SCATTERPLOT, HISTOGRAM, ACTIVEPLOT, or NOPLOT.
	/// </summary>
	public int GetPlotType(vtkVector2i pos)
	{
		return vtkScatterPlotMatrix_GetPlotType_25(GetCppThis(), pos?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetPlotType_26(HandleRef pThis, int row, int column);

	/// <summary>
	/// Returns the type of the plot at the given position. The return
	/// value is one of: SCATTERPLOT, HISTOGRAM, ACTIVEPLOT, or NOPLOT.
	/// </summary>
	public int GetPlotType(int row, int column)
	{
		return vtkScatterPlotMatrix_GetPlotType_26(GetCppThis(), row, column);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkScatterPlotMatrix_GetRowName_27(HandleRef pThis, int row);

	/// <summary>
	/// Get the column name for the supplied index.
	/// </summary>
	public string GetRowName(int row)
	{
		return vtkScatterPlotMatrix_GetRowName_27(GetCppThis(), row);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetScatterPlotSelectedActiveColor_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the scatter plot selected active chart background color.
	/// </summary>
	public vtkColor4ub GetScatterPlotSelectedActiveColor()
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetScatterPlotSelectedActiveColor_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetScatterPlotSelectedRowColumnColor_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the scatter plot selected row/column charts' background color.
	/// </summary>
	public vtkColor4ub GetScatterPlotSelectedRowColumnColor()
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetScatterPlotSelectedRowColumnColor_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetSelectionMode_30(HandleRef pThis);

	/// <summary>
	/// Set/get the Selection Mode that will be used by the chart while doing
	/// selection. The only valid enums are vtkContextScene::SELECTION_NONE,
	/// SELECTION_DEFAULT, SELECTION_ADDITION, SELECTION_SUBTRACTION, SELECTION_TOGGLE
	/// </summary>
	public virtual int GetSelectionMode()
	{
		return vtkScatterPlotMatrix_GetSelectionMode_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkScatterPlotMatrix_GetTitle_31(HandleRef pThis);

	/// <summary>
	/// Set/get the scatter plot title.
	/// </summary>
	public string GetTitle()
	{
		return vtkScatterPlotMatrix_GetTitle_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetTitleProperties_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the text properties for the chart title, i.e. color, font, size.
	/// </summary>
	public vtkTextProperty GetTitleProperties()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetTitleProperties_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetTooltip_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkTooltipItem object that will be displayed by the active chart.
	/// </summary>
	public vtkTooltipItem GetTooltip()
	{
		vtkTooltipItem vtkTooltipItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetTooltip_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTooltipItem2 = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTooltipItem2.Register(null);
			}
		}
		return vtkTooltipItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetTooltipNotation_34(HandleRef pThis, int plotType);

	/// <summary>
	/// Set chart's tooltip notation and precision, given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public int GetTooltipNotation(int plotType)
	{
		return vtkScatterPlotMatrix_GetTooltipNotation_34(GetCppThis(), plotType);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_GetTooltipPrecision_35(HandleRef pThis, int plotType);

	/// <summary>
	/// Set chart's tooltip notation and precision, given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public int GetTooltipPrecision(int plotType)
	{
		return vtkScatterPlotMatrix_GetTooltipPrecision_35(GetCppThis(), plotType);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_GetVisibleColumns_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a list of the columns, and the order in which they are displayed.
	/// </summary>
	public virtual vtkStringArray GetVisibleColumns()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_GetVisibleColumns_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_InsertVisibleColumn_37(HandleRef pThis, string name, int index);

	/// <summary>
	/// Insert the specified column at the index position of
	/// the visible columns.
	/// </summary>
	public void InsertVisibleColumn(string name, int index)
	{
		vtkScatterPlotMatrix_InsertVisibleColumn_37(GetCppThis(), name, index);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_IsA_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScatterPlotMatrix_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScatterPlotMatrix_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScatterPlotMatrix_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkScatterPlotMatrix NewInstance()
	{
		vtkScatterPlotMatrix result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScatterPlotMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScatterPlotMatrix_Paint_42(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the chart matrix.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkScatterPlotMatrix_Paint_42(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScatterPlotMatrix_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScatterPlotMatrix SafeDownCast(vtkObjectBase o)
	{
		vtkScatterPlotMatrix vtkScatterPlotMatrix2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScatterPlotMatrix_SafeDownCast_43(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScatterPlotMatrix2 = (vtkScatterPlotMatrix)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScatterPlotMatrix2.Register(null);
			}
		}
		return vtkScatterPlotMatrix2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScatterPlotMatrix_SetActivePlot_44(HandleRef pThis, HandleRef position);

	/// <summary>
	/// Set the active plot, the one that will be displayed in the top-right.
	/// This defaults to (0, n-2), the plot below the first histogram on the left.
	/// \return false is the position specified is not valid.
	/// </summary>
	public virtual bool SetActivePlot(vtkVector2i position)
	{
		return (vtkScatterPlotMatrix_SetActivePlot_44(GetCppThis(), position?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetAxisColor_45(HandleRef pThis, int plotType, HandleRef color);

	/// <summary>
	/// Sets the color for the axes given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetAxisColor(int plotType, vtkColor4ub color)
	{
		vtkScatterPlotMatrix_SetAxisColor_45(GetCppThis(), plotType, color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetAxisLabelNotation_46(HandleRef pThis, int plotType, int notation);

	/// <summary>
	/// Sets the axis label notation for the axes given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetAxisLabelNotation(int plotType, int notation)
	{
		vtkScatterPlotMatrix_SetAxisLabelNotation_46(GetCppThis(), plotType, notation);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetAxisLabelPrecision_47(HandleRef pThis, int plotType, int precision);

	/// <summary>
	/// Sets the axis label precision for the axes given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetAxisLabelPrecision(int plotType, int precision)
	{
		vtkScatterPlotMatrix_SetAxisLabelPrecision_47(GetCppThis(), plotType, precision);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetAxisLabelProperties_48(HandleRef pThis, int plotType, HandleRef prop);

	/// <summary>
	/// Set/get the text property for the axis labels of the given plot type,
	/// possible types are vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetAxisLabelProperties(int plotType, vtkTextProperty prop)
	{
		vtkScatterPlotMatrix_SetAxisLabelProperties_48(GetCppThis(), plotType, prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetAxisLabelVisibility_49(HandleRef pThis, int plotType, byte visible);

	/// <summary>
	/// Sets whether or not the labels for the axes are visible, given a plot type,
	/// which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetAxisLabelVisibility(int plotType, bool visible)
	{
		vtkScatterPlotMatrix_SetAxisLabelVisibility_49(GetCppThis(), plotType, (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetBackgroundColor_50(HandleRef pThis, int plotType, HandleRef color);

	/// <summary>
	/// Sets the background color for the chart given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetBackgroundColor(int plotType, vtkColor4ub color)
	{
		vtkScatterPlotMatrix_SetBackgroundColor_50(GetCppThis(), plotType, color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetColumnVisibility_51(HandleRef pThis, string name, byte visible);

	/// <summary>
	/// Set the visibility of the specified column.
	/// </summary>
	public void SetColumnVisibility(string name, bool visible)
	{
		vtkScatterPlotMatrix_SetColumnVisibility_51(GetCppThis(), name, (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetColumnVisibilityAll_52(HandleRef pThis, byte visible);

	/// <summary>
	/// Set the visibility of all columns (true will make them all visible, false
	/// will remove all visible columns).
	/// </summary>
	public void SetColumnVisibilityAll(bool visible)
	{
		vtkScatterPlotMatrix_SetColumnVisibilityAll_52(GetCppThis(), (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetGridColor_53(HandleRef pThis, int plotType, HandleRef color);

	/// <summary>
	/// Sets the color for the axes given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetGridColor(int plotType, vtkColor4ub color)
	{
		vtkScatterPlotMatrix_SetGridColor_53(GetCppThis(), plotType, color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetGridVisibility_54(HandleRef pThis, int plotType, byte visible);

	/// <summary>
	/// Sets whether or not the grid for the given axis is visible given a plot
	/// type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetGridVisibility(int plotType, bool visible)
	{
		vtkScatterPlotMatrix_SetGridVisibility_54(GetCppThis(), plotType, (byte)(visible ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetIndexedLabels_55(HandleRef pThis, HandleRef labels);

	/// <summary>
	/// Set indexed labels array.
	/// </summary>
	public void SetIndexedLabels(vtkStringArray labels)
	{
		vtkScatterPlotMatrix_SetIndexedLabels_55(GetCppThis(), labels?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetInput_56(HandleRef pThis, HandleRef table);

	/// <summary>
	/// Set the input table for the scatter plot matrix. This will cause all
	/// columns to be plotted against each other - a square scatter plot matrix.
	/// </summary>
	public virtual void SetInput(vtkTable table)
	{
		vtkScatterPlotMatrix_SetInput_56(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetNumberOfBins_57(HandleRef pThis, int numberOfBins);

	/// <summary>
	/// Set the number of bins in the histograms along the central diagonal of the
	/// scatter plot matrix.
	/// </summary>
	public virtual void SetNumberOfBins(int numberOfBins)
	{
		vtkScatterPlotMatrix_SetNumberOfBins_57(GetCppThis(), numberOfBins);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetNumberOfFrames_58(HandleRef pThis, int frames);

	/// <summary>
	/// Set the number of animation frames in each transition. Default is 25,
	/// and 0 means to animations between axes.
	/// </summary>
	public void SetNumberOfFrames(int frames)
	{
		vtkScatterPlotMatrix_SetNumberOfFrames_58(GetCppThis(), frames);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetPlotColor_59(HandleRef pThis, int plotType, HandleRef color);

	/// <summary>
	/// Set the color for the specified plotType.
	/// </summary>
	public void SetPlotColor(int plotType, vtkColor4ub color)
	{
		vtkScatterPlotMatrix_SetPlotColor_59(GetCppThis(), plotType, color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetPlotMarkerSize_60(HandleRef pThis, int plotType, float size);

	/// <summary>
	/// Sets the marker size for the specified plotType.
	/// </summary>
	public void SetPlotMarkerSize(int plotType, float size)
	{
		vtkScatterPlotMatrix_SetPlotMarkerSize_60(GetCppThis(), plotType, size);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetPlotMarkerStyle_61(HandleRef pThis, int plotType, int style);

	/// <summary>
	/// Sets the marker style for the specified plotType.
	/// </summary>
	public void SetPlotMarkerStyle(int plotType, int style)
	{
		vtkScatterPlotMatrix_SetPlotMarkerStyle_61(GetCppThis(), plotType, style);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetScatterPlotSelectedActiveColor_62(HandleRef pThis, HandleRef color);

	/// <summary>
	/// Set the scatter plot selected active chart background color.
	/// </summary>
	public void SetScatterPlotSelectedActiveColor(vtkColor4ub color)
	{
		vtkScatterPlotMatrix_SetScatterPlotSelectedActiveColor_62(GetCppThis(), color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetScatterPlotSelectedRowColumnColor_63(HandleRef pThis, HandleRef color);

	/// <summary>
	/// Set the scatter plot selected row/column charts' background color.
	/// </summary>
	public void SetScatterPlotSelectedRowColumnColor(vtkColor4ub color)
	{
		vtkScatterPlotMatrix_SetScatterPlotSelectedRowColumnColor_63(GetCppThis(), color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetScene_64(HandleRef pThis, HandleRef scene);

	/// <summary>
	/// Paint event for the chart matrix.
	/// </summary>
	public override void SetScene(vtkContextScene scene)
	{
		vtkScatterPlotMatrix_SetScene_64(GetCppThis(), scene?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetSelectionMode_65(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/get the Selection Mode that will be used by the chart while doing
	/// selection. The only valid enums are vtkContextScene::SELECTION_NONE,
	/// SELECTION_DEFAULT, SELECTION_ADDITION, SELECTION_SUBTRACTION, SELECTION_TOGGLE
	/// </summary>
	public virtual void SetSelectionMode(int arg0)
	{
		vtkScatterPlotMatrix_SetSelectionMode_65(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetSize_66(HandleRef pThis, HandleRef size);

	/// <summary>
	/// Reset ActivePlotSet flag and call superclass method
	/// </summary>
	public override void SetSize(vtkVector2i size)
	{
		vtkScatterPlotMatrix_SetSize_66(GetCppThis(), size?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetTitle_67(HandleRef pThis, string title);

	/// <summary>
	/// Set/get the scatter plot title.
	/// </summary>
	public void SetTitle(string title)
	{
		vtkScatterPlotMatrix_SetTitle_67(GetCppThis(), title);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetTitleProperties_68(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Set/get the text properties for the chart title, i.e. color, font, size.
	/// </summary>
	public void SetTitleProperties(vtkTextProperty prop)
	{
		vtkScatterPlotMatrix_SetTitleProperties_68(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetTooltip_69(HandleRef pThis, HandleRef tooltip);

	/// <summary>
	/// Set the vtkTooltipItem object that will be displayed by the active chart.
	/// </summary>
	public void SetTooltip(vtkTooltipItem tooltip)
	{
		vtkScatterPlotMatrix_SetTooltip_69(GetCppThis(), tooltip?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetTooltipNotation_70(HandleRef pThis, int plotType, int notation);

	/// <summary>
	/// Set chart's tooltip notation and precision, given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetTooltipNotation(int plotType, int notation)
	{
		vtkScatterPlotMatrix_SetTooltipNotation_70(GetCppThis(), plotType, notation);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetTooltipPrecision_71(HandleRef pThis, int plotType, int precision);

	/// <summary>
	/// Set chart's tooltip notation and precision, given a plot type, which refers to
	/// vtkScatterPlotMatrix::{SCATTERPLOT, HISTOGRAM, ACTIVEPLOT}.
	/// </summary>
	public void SetTooltipPrecision(int plotType, int precision)
	{
		vtkScatterPlotMatrix_SetTooltipPrecision_71(GetCppThis(), plotType, precision);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_SetVisibleColumns_72(HandleRef pThis, HandleRef visColumns);

	/// <summary>
	/// Set the list of visible columns, and the order in which they will be displayed.
	/// </summary>
	public virtual void SetVisibleColumns(vtkStringArray visColumns)
	{
		vtkScatterPlotMatrix_SetVisibleColumns_72(GetCppThis(), visColumns?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_Update_73(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// </summary>
	public override void Update()
	{
		vtkScatterPlotMatrix_Update_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_UpdateChartSettings_74(HandleRef pThis, int plotType);

	/// <summary>
	/// Update charts based on settings given the plot type
	/// </summary>
	public void UpdateChartSettings(int plotType)
	{
		vtkScatterPlotMatrix_UpdateChartSettings_74(GetCppThis(), plotType);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScatterPlotMatrix_UpdateSettings_75(HandleRef pThis);

	/// <summary>
	/// Convenient method to update all the chart settings
	/// </summary>
	public void UpdateSettings()
	{
		vtkScatterPlotMatrix_UpdateSettings_75(GetCppThis());
	}
}
