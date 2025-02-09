using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkScalarsToColorsItem
/// </summary>
/// <remarks>
///    Abstract class for ScalarsToColors items.
///
/// vtkScalarsToColorsItem implements item bounds and painting for inherited
/// classes that provide a texture (ComputeTexture()) and optionally a shape
/// </remarks>
/// <seealso>
///
/// vtkControlPointsItem
/// vtkLookupTableItem
/// vtkColorTransferFunctionItem
/// vtkCompositeTransferFunctionItem
/// vtkPiecewiseItemFunctionItem
/// </seealso>
public abstract class vtkScalarsToColorsItem : vtkPlot
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScalarsToColorsItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScalarsToColorsItem()
	{
		MRClassNameKey = "class vtkScalarsToColorsItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarsToColorsItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScalarsToColorsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkScalarsToColorsItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Bounds of the item, use the UserBounds if valid otherwise compute
	/// the bounds of the item (based on the transfer function range).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkScalarsToColorsItem_GetBounds_01(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColorsItem_GetHistogramTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the vtkTable displayed as an histogram using a vtkPlotBar
	/// </summary>
	public virtual vtkTable GetHistogramTable()
	{
		vtkTable vtkTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColorsItem_GetHistogramTable_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTable2 = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTable2.Register(null);
			}
		}
		return vtkTable2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarsToColorsItem_GetMaskAboveCurve_03(HandleRef pThis);

	/// <summary>
	/// Don't fill in the part above the transfer function.
	/// If true texture is not visible above the shape provided by subclasses,
	/// otherwise the whole rectangle defined by the bounds is filled with the
	/// transfer function.
	/// Note: only 2D transfer functions (RGB tf + alpha tf ) support the feature.
	/// </summary>
	public virtual bool GetMaskAboveCurve()
	{
		return (vtkScalarsToColorsItem_GetMaskAboveCurve_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColorsItem_GetNearestPoint_04(HandleRef pThis, HandleRef point, HandleRef arg1, HandleRef location, IntPtr segmentIndex);

	/// <summary>
	/// Function to query a plot for the nearest point to the specified coordinate.
	/// Returns the index of the data series with which the point is associated or
	/// -1.
	/// If a vtkIdType* is passed, its referent will be set to index of the bar
	/// segment with which a point is associated, or -1.
	/// </summary>
	public override long GetNearestPoint(vtkVector2f point, vtkVector2f arg1, vtkVector2f location, IntPtr segmentIndex)
	{
		return vtkScalarsToColorsItem_GetNearestPoint_04(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), location?.GetCppThis() ?? default(HandleRef), segmentIndex);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColorsItem_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScalarsToColorsItem_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarsToColorsItem_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScalarsToColorsItem_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColorsItem_GetPolyLinePen_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the vtkPen object that controls the drawing of the edge
	/// of the shape if any.
	/// PolyLinePen type is vtkPen::NO_PEN by default.
	/// </summary>
	public virtual vtkPen GetPolyLinePen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColorsItem_GetPolyLinePen_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPen2 = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPen2.Register(null);
			}
		}
		return vtkPen2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkScalarsToColorsItem_GetTooltipLabel_08(HandleRef pThis, HandleRef plotPos, long seriesIndex, long segmentIndex);

	/// <summary>
	/// Generate and return the tooltip label string for this plot
	/// The segmentIndex is implemented here.
	/// </summary>
	public override string GetTooltipLabel(vtkVector2d plotPos, long seriesIndex, long segmentIndex)
	{
		return vtkScalarsToColorsItem_GetTooltipLabel_08(GetCppThis(), plotPos?.GetCppThis() ?? default(HandleRef), seriesIndex, segmentIndex);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColorsItem_GetUserBounds_09(HandleRef pThis);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual double[] GetUserBounds()
	{
		IntPtr intPtr = vtkScalarsToColorsItem_GetUserBounds_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColorsItem_GetUserBounds_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual void GetUserBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkScalarsToColorsItem_GetUserBounds_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColorsItem_GetUserBounds_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual void GetUserBounds(IntPtr _arg)
	{
		vtkScalarsToColorsItem_GetUserBounds_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColorsItem_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScalarsToColorsItem_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarsToColorsItem_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScalarsToColorsItem_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColorsItem_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkScalarsToColorsItem NewInstance()
	{
		vtkScalarsToColorsItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColorsItem_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarsToColorsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkScalarsToColorsItem_Paint_15(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint the texture into a rectangle defined by the bounds. If
	/// MaskAboveCurve is true and a shape has been provided by a subclass, it
	/// draws the texture into the shape
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkScalarsToColorsItem_Paint_15(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarsToColorsItem_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkScalarsToColorsItem SafeDownCast(vtkObjectBase o)
	{
		vtkScalarsToColorsItem vtkScalarsToColorsItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarsToColorsItem_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColorsItem2 = (vtkScalarsToColorsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColorsItem2.Register(null);
			}
		}
		return vtkScalarsToColorsItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColorsItem_SetHistogramTable_17(HandleRef pThis, HandleRef histogramTable);

	/// <summary>
	/// Set/Get the vtkTable displayed as an histogram using a vtkPlotBar
	/// </summary>
	public void SetHistogramTable(vtkTable histogramTable)
	{
		vtkScalarsToColorsItem_SetHistogramTable_17(GetCppThis(), histogramTable?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColorsItem_SetMaskAboveCurve_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Don't fill in the part above the transfer function.
	/// If true texture is not visible above the shape provided by subclasses,
	/// otherwise the whole rectangle defined by the bounds is filled with the
	/// transfer function.
	/// Note: only 2D transfer functions (RGB tf + alpha tf ) support the feature.
	/// </summary>
	public virtual void SetMaskAboveCurve(bool _arg)
	{
		vtkScalarsToColorsItem_SetMaskAboveCurve_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColorsItem_SetUserBounds_19(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual void SetUserBounds(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkScalarsToColorsItem_SetUserBounds_19(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarsToColorsItem_SetUserBounds_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual void SetUserBounds(IntPtr _arg)
	{
		vtkScalarsToColorsItem_SetUserBounds_20(GetCppThis(), _arg);
	}
}
