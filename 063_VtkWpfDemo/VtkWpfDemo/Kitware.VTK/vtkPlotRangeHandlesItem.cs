using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotRangeHandlesItem
/// </summary>
/// <remarks>
///    item to show and control a range on vtkAxis
///
/// vtkPlotRangeHandlesItem provides range handles painting and management
/// for a provided extent.
/// Handles can be moved by clicking on them.
/// The range is shown when hovering or moving the handles.
/// It emits a StartInteractionEvent when starting to interact with a handle,
/// an InteractionEvent when interacting with a handle and an EndInteractionEvent
/// when releasing a handle.
/// It emits a LeftMouseButtonDoubleClickEvent when double clicked.
/// Options can be used to change the appearance or behavior of handles:
/// - SynchronizeHandlesRange: When enabled, moving the minimum handle triggers
/// the modification of the whole range, resulting in the maximum handle being
/// moved too. Disabled by default.
/// - Orientation: Choose between horizontal (Y axis) or vertical (X axis)
/// handles. Default is vertical.
/// - ExtentToAxis: When enabled, the height of handles span the range of the
/// opposite axis. If disabled, the height of handles is defined by the provided
/// extent. Enabled by default.
/// </remarks>
public class vtkPlotRangeHandlesItem : vtkPlot
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum Handle
	{
		/// <summary>enum member</summary>
		LEFT_HANDLE = 0,
		/// <summary>enum member</summary>
		NO_HANDLE = -1,
		/// <summary>enum member</summary>
		RIGHT_HANDLE = 1
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum Orientation
	{
		/// <summary>enum member</summary>
		HORIZONTAL = 1,
		/// <summary>enum member</summary>
		VERTICAL = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotRangeHandlesItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotRangeHandlesItem()
	{
		MRClassNameKey = "class vtkPlotRangeHandlesItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotRangeHandlesItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotRangeHandlesItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotRangeHandlesItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotRangeHandlesItem New()
	{
		vtkPlotRangeHandlesItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotRangeHandlesItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPlotRangeHandlesItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotRangeHandlesItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlotRangeHandlesItem_ComputeHandlesDrawRange_01(HandleRef pThis);

	/// <summary>
	/// Compute the handles draw range by using the handle width and the transfer function
	/// </summary>
	public virtual void ComputeHandlesDrawRange()
	{
		vtkPlotRangeHandlesItem_ComputeHandlesDrawRange_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_ExtentToAxisRangeOff_02(HandleRef pThis);

	/// <summary>
	/// Set/Get whether handles span the range of the axis. Default is On.
	/// </summary>
	public virtual void ExtentToAxisRangeOff()
	{
		vtkPlotRangeHandlesItem_ExtentToAxisRangeOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_ExtentToAxisRangeOn_03(HandleRef pThis);

	/// <summary>
	/// Set/Get whether handles span the range of the axis. Default is On.
	/// </summary>
	public virtual void ExtentToAxisRangeOn()
	{
		vtkPlotRangeHandlesItem_ExtentToAxisRangeOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_GetBounds_04(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Recover the bounds of the item
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkPlotRangeHandlesItem_GetBounds_04(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotRangeHandlesItem_GetExtent_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the extent of the handles in data space (axis unscaled range).
	/// The first two parameters define the left and right handles positions on
	/// the axis. The last two parameters define the length of handles along the
	/// opposite axis. Default values are set to (0, 1, 0, 1).
	/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
	/// effect and handles span the axis range.
	/// </summary>
	public virtual double[] GetExtent()
	{
		IntPtr intPtr = vtkPlotRangeHandlesItem_GetExtent_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_GetExtent_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set/Get the extent of the handles in data space (axis unscaled range).
	/// The first two parameters define the left and right handles positions on
	/// the axis. The last two parameters define the length of handles along the
	/// opposite axis. Default values are set to (0, 1, 0, 1).
	/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
	/// effect and handles span the axis range.
	/// </summary>
	public virtual void GetExtent(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkPlotRangeHandlesItem_GetExtent_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_GetExtent_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the extent of the handles in data space (axis unscaled range).
	/// The first two parameters define the left and right handles positions on
	/// the axis. The last two parameters define the length of handles along the
	/// opposite axis. Default values are set to (0, 1, 0, 1).
	/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
	/// effect and handles span the axis range.
	/// </summary>
	public virtual void GetExtent(IntPtr _arg)
	{
		vtkPlotRangeHandlesItem_GetExtent_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotRangeHandlesItem_GetExtentToAxisRange_08(HandleRef pThis);

	/// <summary>
	/// Set/Get whether handles span the range of the axis. Default is On.
	/// </summary>
	public virtual int GetExtentToAxisRange()
	{
		return vtkPlotRangeHandlesItem_GetExtentToAxisRange_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotRangeHandlesItem_GetHandleOrientation_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the handles orientation in the plot.
	/// </summary>
	public virtual int GetHandleOrientation()
	{
		return vtkPlotRangeHandlesItem_GetHandleOrientation_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotRangeHandlesItem_GetHandleOrientationMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the handles orientation in the plot.
	/// </summary>
	public virtual int GetHandleOrientationMaxValue()
	{
		return vtkPlotRangeHandlesItem_GetHandleOrientationMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotRangeHandlesItem_GetHandleOrientationMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the handles orientation in the plot.
	/// </summary>
	public virtual int GetHandleOrientationMinValue()
	{
		return vtkPlotRangeHandlesItem_GetHandleOrientationMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPlotRangeHandlesItem_GetHandleWidth_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the handles width in pixels.
	/// Default is 2.
	/// </summary>
	public virtual float GetHandleWidth()
	{
		return vtkPlotRangeHandlesItem_GetHandleWidth_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_GetHandlesRange_13(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Recover the range currently set by the handles
	/// Use this method by observing EndInteractionEvent
	/// </summary>
	public virtual void GetHandlesRange(IntPtr range)
	{
		vtkPlotRangeHandlesItem_GetHandlesRange_13(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotRangeHandlesItem_GetHighlightBrush_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the brush used to paint handles being hovered
	/// </summary>
	public virtual vtkBrush GetHighlightBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotRangeHandlesItem_GetHighlightBrush_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPlotRangeHandlesItem_GetLockTooltipToMouse_15(HandleRef pThis);

	/// <summary>
	/// If On, the range tooltip is always rendered using mouse position,
	/// otherwise it is placed at the center of the x axis Default is On.
	/// </summary>
	public virtual int GetLockTooltipToMouse()
	{
		return vtkPlotRangeHandlesItem_GetLockTooltipToMouse_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotRangeHandlesItem_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotRangeHandlesItem_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotRangeHandlesItem_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotRangeHandlesItem_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotRangeHandlesItem_GetSynchronizeRangeHandles_18(HandleRef pThis);

	/// <summary>
	/// Set/Get whether handles move together when one of them is update. Default is Off.
	/// </summary>
	public virtual int GetSynchronizeRangeHandles()
	{
		return vtkPlotRangeHandlesItem_GetSynchronizeRangeHandles_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotRangeHandlesItem_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotRangeHandlesItem_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotRangeHandlesItem_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotRangeHandlesItem_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_LockTooltipToMouseOff_21(HandleRef pThis);

	/// <summary>
	/// If On, the range tooltip is always rendered using mouse position,
	/// otherwise it is placed at the center of the x axis Default is On.
	/// </summary>
	public virtual void LockTooltipToMouseOff()
	{
		vtkPlotRangeHandlesItem_LockTooltipToMouseOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_LockTooltipToMouseOn_22(HandleRef pThis);

	/// <summary>
	/// If On, the range tooltip is always rendered using mouse position,
	/// otherwise it is placed at the center of the x axis Default is On.
	/// </summary>
	public virtual void LockTooltipToMouseOn()
	{
		vtkPlotRangeHandlesItem_LockTooltipToMouseOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotRangeHandlesItem_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotRangeHandlesItem NewInstance()
	{
		vtkPlotRangeHandlesItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotRangeHandlesItem_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPlotRangeHandlesItem_Paint_25(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint both handles and the range if
	/// a handle is active or hovered
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPlotRangeHandlesItem_Paint_25(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotRangeHandlesItem_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotRangeHandlesItem SafeDownCast(vtkObjectBase o)
	{
		vtkPlotRangeHandlesItem vtkPlotRangeHandlesItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotRangeHandlesItem_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotRangeHandlesItem2 = (vtkPlotRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotRangeHandlesItem2.Register(null);
			}
		}
		return vtkPlotRangeHandlesItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetExtent_27(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set/Get the extent of the handles in data space (axis unscaled range).
	/// The first two parameters define the left and right handles positions on
	/// the axis. The last two parameters define the length of handles along the
	/// opposite axis. Default values are set to (0, 1, 0, 1).
	/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
	/// effect and handles span the axis range.
	/// </summary>
	public virtual void SetExtent(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkPlotRangeHandlesItem_SetExtent_27(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetExtent_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the extent of the handles in data space (axis unscaled range).
	/// The first two parameters define the left and right handles positions on
	/// the axis. The last two parameters define the length of handles along the
	/// opposite axis. Default values are set to (0, 1, 0, 1).
	/// When using ExtentToAxisRangeOn(), the last two parameters don't have any
	/// effect and handles span the axis range.
	/// </summary>
	public virtual void SetExtent(IntPtr _arg)
	{
		vtkPlotRangeHandlesItem_SetExtent_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetExtentToAxisRange_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether handles span the range of the axis. Default is On.
	/// </summary>
	public virtual void SetExtentToAxisRange(int _arg)
	{
		vtkPlotRangeHandlesItem_SetExtentToAxisRange_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetHandleOrientation_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the handles orientation in the plot.
	/// </summary>
	public virtual void SetHandleOrientation(int _arg)
	{
		vtkPlotRangeHandlesItem_SetHandleOrientation_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetHandleOrientationToHorizontal_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the handles orientation in the plot.
	/// </summary>
	public void SetHandleOrientationToHorizontal()
	{
		vtkPlotRangeHandlesItem_SetHandleOrientationToHorizontal_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetHandleOrientationToVertical_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the handles orientation in the plot.
	/// </summary>
	public void SetHandleOrientationToVertical()
	{
		vtkPlotRangeHandlesItem_SetHandleOrientationToVertical_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetHandleWidth_33(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the handles width in pixels.
	/// Default is 2.
	/// </summary>
	public virtual void SetHandleWidth(float _arg)
	{
		vtkPlotRangeHandlesItem_SetHandleWidth_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetLockTooltipToMouse_34(HandleRef pThis, int _arg);

	/// <summary>
	/// If On, the range tooltip is always rendered using mouse position,
	/// otherwise it is placed at the center of the x axis Default is On.
	/// </summary>
	public virtual void SetLockTooltipToMouse(int _arg)
	{
		vtkPlotRangeHandlesItem_SetLockTooltipToMouse_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SetSynchronizeRangeHandles_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether handles move together when one of them is update. Default is Off.
	/// </summary>
	public virtual void SetSynchronizeRangeHandles(int _arg)
	{
		vtkPlotRangeHandlesItem_SetSynchronizeRangeHandles_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SynchronizeRangeHandlesOff_36(HandleRef pThis);

	/// <summary>
	/// Set/Get whether handles move together when one of them is update. Default is Off.
	/// </summary>
	public virtual void SynchronizeRangeHandlesOff()
	{
		vtkPlotRangeHandlesItem_SynchronizeRangeHandlesOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotRangeHandlesItem_SynchronizeRangeHandlesOn_37(HandleRef pThis);

	/// <summary>
	/// Set/Get whether handles move together when one of them is update. Default is Off.
	/// </summary>
	public virtual void SynchronizeRangeHandlesOn()
	{
		vtkPlotRangeHandlesItem_SynchronizeRangeHandlesOn_37(GetCppThis());
	}
}
