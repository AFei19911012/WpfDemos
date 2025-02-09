using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkChartLegend
/// </summary>
/// <remarks>
///    draw the chart legend
///
///
/// The vtkChartLegend is drawn in screen coordinates. It is usually one of the
/// last elements of a chart to be drawn. It renders the mark/line for each
/// plot, and the plot labels.
/// </remarks>
public class vtkChartLegend : vtkContextItem
{
	/// <summary>
	/// Get point the legend box is anchored to.
	/// </summary>
	public enum BOTTOM_WrapperEnum
	{
		/// <summary>enum member</summary>
		BOTTOM = 4,
		/// <summary>enum member</summary>
		CENTER = 1,
		/// <summary>enum member</summary>
		CUSTOM = 5,
		/// <summary>enum member</summary>
		LEFT = 0,
		/// <summary>enum member</summary>
		RIGHT = 2,
		/// <summary>enum member</summary>
		TOP = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkChartLegend";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkChartLegend()
	{
		MRClassNameKey = "class vtkChartLegend";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartLegend"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkChartLegend(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public new static vtkChartLegend New()
	{
		vtkChartLegend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Chart object.
	/// </summary>
	public vtkChartLegend()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkChartLegend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkChartLegend_CacheBoundsOff_01(HandleRef pThis);

	/// <summary>
	/// Toggle whether or not this legend should attempt to cache its position
	/// and size.  The default value is true.  If this value is set to false,
	/// the legend will recalculate its position and bounds every time it is
	/// drawn.  If users will be able to zoom in or out on your legend, you
	/// may want to set this to false.  Otherwise, the border around the legend
	/// may not resize appropriately.
	/// </summary>
	public virtual void CacheBoundsOff()
	{
		vtkChartLegend_CacheBoundsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_CacheBoundsOn_02(HandleRef pThis);

	/// <summary>
	/// Toggle whether or not this legend should attempt to cache its position
	/// and size.  The default value is true.  If this value is set to false,
	/// the legend will recalculate its position and bounds every time it is
	/// drawn.  If users will be able to zoom in or out on your legend, you
	/// may want to set this to false.  Otherwise, the border around the legend
	/// may not resize appropriately.
	/// </summary>
	public virtual void CacheBoundsOn()
	{
		vtkChartLegend_CacheBoundsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_GetBoundingRect_03(HandleRef pThis, HandleRef painter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Request the space the legend requires to be drawn. This is returned as a
	/// vtkRect4f, with the corner being the offset from Point, and the width/
	/// height being the total width/height required by the axis. In order to
	/// ensure the numbers are correct, Update() should be called first.
	/// </summary>
	public virtual vtkRectf GetBoundingRect(vtkContext2D painter)
	{
		vtkRectf result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_GetBoundingRect_03(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_GetBrush_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the brush used to draw the legend background.
	/// </summary>
	public vtkBrush GetBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_GetBrush_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBrush2 = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBrush2.Register(null);
			}
		}
		return vtkBrush2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartLegend_GetCacheBounds_05(HandleRef pThis);

	/// <summary>
	/// Toggle whether or not this legend should attempt to cache its position
	/// and size.  The default value is true.  If this value is set to false,
	/// the legend will recalculate its position and bounds every time it is
	/// drawn.  If users will be able to zoom in or out on your legend, you
	/// may want to set this to false.  Otherwise, the border around the legend
	/// may not resize appropriately.
	/// </summary>
	public virtual bool GetCacheBounds()
	{
		return (vtkChartLegend_GetCacheBounds_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_GetChart_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the chart that the legend belongs to and will draw the legend for.
	/// </summary>
	public vtkChart GetChart()
	{
		vtkChart vtkChart2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_GetChart_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkChartLegend_GetDragEnabled_07(HandleRef pThis);

	/// <summary>
	/// Get/set if the legend can be dragged with the mouse button, or not.
	/// True results in left click and drag causing the legend to move around the
	/// scene. False disables response to mouse events.
	/// The default is true.
	/// </summary>
	public virtual bool GetDragEnabled()
	{
		return (vtkChartLegend_GetDragEnabled_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartLegend_GetHorizontalAlignment_08(HandleRef pThis);

	/// <summary>
	/// Get the horizontal alignment of the legend to the point specified.
	/// </summary>
	public virtual int GetHorizontalAlignment()
	{
		return vtkChartLegend_GetHorizontalAlignment_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartLegend_GetInline_09(HandleRef pThis);

	/// <summary>
	/// Get/set if the legend should be drawn inline (inside the chart), or not.
	/// True would generally request that the chart draws it inside the chart,
	/// false would adjust the chart axes and make space to draw the axes outside.
	/// </summary>
	public virtual bool GetInline()
	{
		return (vtkChartLegend_GetInline_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_GetLabelProperties_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkTextProperty for the legend's labels.
	/// </summary>
	public vtkTextProperty GetLabelProperties()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_GetLabelProperties_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkChartLegend_GetLabelSize_11(HandleRef pThis);

	/// <summary>
	/// Get the point size of the label text.
	/// </summary>
	public virtual int GetLabelSize()
	{
		return vtkChartLegend_GetLabelSize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartLegend_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkChartLegend_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkChartLegend_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkChartLegend_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartLegend_GetPadding_14(HandleRef pThis);

	/// <summary>
	/// Get the padding between legend marks.
	/// </summary>
	public virtual int GetPadding()
	{
		return vtkChartLegend_GetPadding_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_GetPen_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the pen used to draw the legend outline.
	/// </summary>
	public vtkPen GetPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_GetPen_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkChartLegend_GetPoint_16(HandleRef pThis);

	/// <summary>
	/// Get point the legend box is anchored to.
	/// </summary>
	public virtual float[] GetPoint()
	{
		IntPtr intPtr = vtkChartLegend_GetPoint_16(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_GetPoint_17(HandleRef pThis, ref float _arg1, ref float _arg2);

	/// <summary>
	/// Get point the legend box is anchored to.
	/// </summary>
	public virtual void GetPoint(ref float _arg1, ref float _arg2)
	{
		vtkChartLegend_GetPoint_17(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_GetPoint_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get point the legend box is anchored to.
	/// </summary>
	public virtual void GetPoint(IntPtr _arg)
	{
		vtkChartLegend_GetPoint_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_GetPointVector_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get point the legend box is anchored to.
	/// </summary>
	public vtkVector2f GetPointVector()
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_GetPointVector_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartLegend_GetSymbolWidth_20(HandleRef pThis);

	/// <summary>
	/// Get the legend symbol width.
	/// </summary>
	public virtual int GetSymbolWidth()
	{
		return vtkChartLegend_GetSymbolWidth_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartLegend_GetVerticalAlignment_21(HandleRef pThis);

	/// <summary>
	/// Get the vertical alignment of the legend to the point specified.
	/// </summary>
	public virtual int GetVerticalAlignment()
	{
		return vtkChartLegend_GetVerticalAlignment_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartLegend_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkChartLegend_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkChartLegend_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkChartLegend_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkChartLegend NewInstance()
	{
		vtkChartLegend result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkChartLegend_Paint_26(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the axis, called whenever the axis needs to be drawn.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkChartLegend_Paint_26(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkChartLegend_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkChartLegend SafeDownCast(vtkObjectBase o)
	{
		vtkChartLegend vtkChartLegend2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkChartLegend_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkChartLegend2 = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkChartLegend2.Register(null);
			}
		}
		return vtkChartLegend2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetCacheBounds_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// Toggle whether or not this legend should attempt to cache its position
	/// and size.  The default value is true.  If this value is set to false,
	/// the legend will recalculate its position and bounds every time it is
	/// drawn.  If users will be able to zoom in or out on your legend, you
	/// may want to set this to false.  Otherwise, the border around the legend
	/// may not resize appropriately.
	/// </summary>
	public virtual void SetCacheBounds(bool _arg)
	{
		vtkChartLegend_SetCacheBounds_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetChart_29(HandleRef pThis, HandleRef chart);

	/// <summary>
	/// Set the chart that the legend belongs to and will draw the legend for.
	/// </summary>
	public void SetChart(vtkChart chart)
	{
		vtkChartLegend_SetChart_29(GetCppThis(), chart?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetDragEnabled_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set if the legend can be dragged with the mouse button, or not.
	/// True results in left click and drag causing the legend to move around the
	/// scene. False disables response to mouse events.
	/// The default is true.
	/// </summary>
	public virtual void SetDragEnabled(bool _arg)
	{
		vtkChartLegend_SetDragEnabled_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetHorizontalAlignment_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the horizontal alignment of the legend to the point specified.
	/// Valid values are LEFT, CENTER and RIGHT.
	/// </summary>
	public virtual void SetHorizontalAlignment(int _arg)
	{
		vtkChartLegend_SetHorizontalAlignment_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetInline_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/set if the legend should be drawn inline (inside the chart), or not.
	/// True would generally request that the chart draws it inside the chart,
	/// false would adjust the chart axes and make space to draw the axes outside.
	/// </summary>
	public virtual void SetInline(bool _arg)
	{
		vtkChartLegend_SetInline_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetLabelSize_33(HandleRef pThis, int size);

	/// <summary>
	/// Set the point size of the label text.
	/// </summary>
	public virtual void SetLabelSize(int size)
	{
		vtkChartLegend_SetLabelSize_33(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetPadding_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the padding between legend marks, default is 5.
	/// </summary>
	public virtual void SetPadding(int _arg)
	{
		vtkChartLegend_SetPadding_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetPoint_35(HandleRef pThis, float _arg1, float _arg2);

	/// <summary>
	/// Set point the legend box is anchored to.
	/// </summary>
	public virtual void SetPoint(float _arg1, float _arg2)
	{
		vtkChartLegend_SetPoint_35(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetPoint_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set point the legend box is anchored to.
	/// </summary>
	public void SetPoint(IntPtr _arg)
	{
		vtkChartLegend_SetPoint_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetPoint_37(HandleRef pThis, HandleRef point);

	/// <summary>
	/// Set point the legend box is anchored to.
	/// </summary>
	public void SetPoint(vtkVector2f point)
	{
		vtkChartLegend_SetPoint_37(GetCppThis(), point?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetSymbolWidth_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the symbol width, default is 15.
	/// </summary>
	public virtual void SetSymbolWidth(int _arg)
	{
		vtkChartLegend_SetSymbolWidth_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_SetVerticalAlignment_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the vertical alignment of the legend to the point specified.
	/// Valid values are TOP, CENTER and BOTTOM.
	/// </summary>
	public virtual void SetVerticalAlignment(int _arg)
	{
		vtkChartLegend_SetVerticalAlignment_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkChartLegend_Update_40(HandleRef pThis);

	/// <summary>
	/// Update the geometry of the axis. Takes care of setting up the tick mark
	/// locations etc. Should be called by the scene before rendering.
	/// </summary>
	public override void Update()
	{
		vtkChartLegend_Update_40(GetCppThis());
	}
}
