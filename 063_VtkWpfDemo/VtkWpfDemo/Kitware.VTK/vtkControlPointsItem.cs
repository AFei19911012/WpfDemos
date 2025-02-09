using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkControlPointsItem
/// </summary>
/// <remarks>
///    Abstract class for control points items.
///
/// vtkControlPointsItem provides control point painting and management for
/// subclasses that provide points (typically control points of a transfer
/// function)
/// </remarks>
/// <seealso>
///
/// vtkScalarsToColorsItem
/// vtkPiecewiseControlPointsItem
/// </seealso>
public abstract class vtkControlPointsItem : vtkPlot
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum CurrentPointChangedEvent_WrapperEnum
	{
		/// <summary>enum member</summary>
		CurrentPointChangedEvent = 1000,
		/// <summary>enum member</summary>
		CurrentPointEditEvent
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkControlPointsItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkControlPointsItem()
	{
		MRClassNameKey = "class vtkControlPointsItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkControlPointsItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

	/// <summary>
	/// Add a point to the function. Returns the index of the point (0 based),
	/// or -1 on error.
	/// Subclasses should reimplement this function to do the actual work.
	/// </summary>
	public virtual long AddPoint(IntPtr newPos)
	{
		return vtkControlPointsItem_AddPoint_01(GetCppThis(), newPos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_DeselectAllPoints_02(HandleRef pThis);

	/// <summary>
	/// Unselect all the previously selected points
	/// </summary>
	public void DeselectAllPoints()
	{
		vtkControlPointsItem_DeselectAllPoints_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_DeselectPoint_03(HandleRef pThis, long pointId);

	/// <summary>
	/// Unselect a point by its ID
	/// </summary>
	public void DeselectPoint(long pointId)
	{
		vtkControlPointsItem_DeselectPoint_03(GetCppThis(), pointId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_DeselectPoint_04(HandleRef pThis, IntPtr currentPoint);

	/// <summary>
	/// Utility function that unselects a point providing its coordinates.
	/// To be found, the position of the point must be no further away than its
	/// painted point size
	/// </summary>
	public void DeselectPoint(IntPtr currentPoint)
	{
		vtkControlPointsItem_DeselectPoint_04(GetCppThis(), currentPoint);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_DrawPointsOff_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to draw points.
	/// Default is true.
	/// </summary>
	public virtual void DrawPointsOff()
	{
		vtkControlPointsItem_DrawPointsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_DrawPointsOn_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to draw points.
	/// Default is true.
	/// </summary>
	public virtual void DrawPointsOn()
	{
		vtkControlPointsItem_DrawPointsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_FindPoint_07(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Returns the vtkIdType of the point given its coordinates and a tolerance
	/// based on the screen point size.
	/// </summary>
	public long FindPoint(IntPtr pos)
	{
		return vtkControlPointsItem_FindPoint_07(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkControlPointsItem_GetAddPointItem_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Item dedicated to add point, to be added below all other items.
	/// Used only if UseAddPointItem is set to true.
	/// </summary>
	public vtkPlot GetAddPointItem()
	{
		vtkPlot vtkPlot2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkControlPointsItem_GetAddPointItem_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlot2 = (vtkPlot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlot2.Register(null);
			}
		}
		return vtkPlot2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_GetBounds_09(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Bounds of the item, typically the bound of all the control points
	/// except if custom bounds have been set \sa SetUserBounds.
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkControlPointsItem_GetBounds_09(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_GetControlPoint_10(HandleRef pThis, long index, IntPtr point);

	/// <summary>
	/// Returns the x and y coordinates as well as the midpoint and sharpness
	/// of the control point corresponding to the index.
	/// point must be a double array of size 4.
	/// </summary>
	public virtual void GetControlPoint(long index, IntPtr point)
	{
		vtkControlPointsItem_GetControlPoint_10(GetCppThis(), index, point);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_GetControlPointId_11(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Returns the id of the control point exactly matching pos, -1 if not found.
	/// </summary>
	public long GetControlPointId(IntPtr pos)
	{
		return vtkControlPointsItem_GetControlPointId_11(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_GetControlPointsIds_12(HandleRef pThis, HandleRef ids, byte excludeFirstAndLast);

	/// <summary>
	/// Utility function that returns an array of all the control points IDs
	/// Typically: [0, 1, 2, ... n -1] where n is the point count
	/// Can exclude the first and last point ids from the array.
	/// </summary>
	public void GetControlPointsIds(vtkIdTypeArray ids, bool excludeFirstAndLast)
	{
		vtkControlPointsItem_GetControlPointsIds_12(GetCppThis(), ids?.GetCppThis() ?? default(HandleRef), (byte)(excludeFirstAndLast ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_GetCurrentPoint_13(HandleRef pThis);

	/// <summary>
	/// Returns the current point ID selected or -1 if there is no point current.
	/// No current point by default.
	/// </summary>
	public long GetCurrentPoint()
	{
		return vtkControlPointsItem_GetCurrentPoint_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_GetDrawPoints_14(HandleRef pThis);

	/// <summary>
	/// Get/Set the flag to draw points.
	/// Default is true.
	/// </summary>
	public virtual bool GetDrawPoints()
	{
		return (vtkControlPointsItem_GetDrawPoints_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_GetEndPointsMovable_15(HandleRef pThis);

	/// <summary>
	/// If EndPointsMovable is false, the two end points will not
	/// be moved. True by default.
	/// </summary>
	public virtual bool GetEndPointsMovable()
	{
		return (vtkControlPointsItem_GetEndPointsMovable_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_GetEndPointsRemovable_16(HandleRef pThis);

	/// <summary>
	/// If EndPointsRemovable is false, the two end points will not
	/// be removed. True by default.
	/// </summary>
	public virtual bool GetEndPointsRemovable()
	{
		return (vtkControlPointsItem_GetEndPointsRemovable_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_GetEndPointsXMovable_17(HandleRef pThis);

	/// <summary>
	/// If EndPointsMovable is false, the two end points will not
	/// be moved. True by default.
	/// </summary>
	public virtual bool GetEndPointsXMovable()
	{
		return (vtkControlPointsItem_GetEndPointsXMovable_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_GetEndPointsYMovable_18(HandleRef pThis);

	/// <summary>
	/// If EndPointsMovable is false, the two end points will not
	/// be moved. True by default.
	/// </summary>
	public virtual bool GetEndPointsYMovable()
	{
		return (vtkControlPointsItem_GetEndPointsYMovable_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkControlPointsItem_GetLabelFormat_19(HandleRef pThis);

	/// <summary>
	/// Get/Set the label format. Default is "%.4f, %.4f".
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkControlPointsItem_GetLabelFormat_19(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkControlPointsItem_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkControlPointsItem_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_GetNumberOfPoints_22(HandleRef pThis);

	/// <summary>
	/// Returns the total number of points
	/// </summary>
	public virtual long GetNumberOfPoints()
	{
		return vtkControlPointsItem_GetNumberOfPoints_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_GetNumberOfSelectedPoints_23(HandleRef pThis);

	/// <summary>
	/// Return the number of selected points.
	/// </summary>
	public long GetNumberOfSelectedPoints()
	{
		return vtkControlPointsItem_GetNumberOfSelectedPoints_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkControlPointsItem_GetScreenPointRadius_24(HandleRef pThis);

	/// <summary>
	/// Get/set the radius for screen points.
	/// Default is 6.f
	/// </summary>
	public virtual float GetScreenPointRadius()
	{
		return vtkControlPointsItem_GetScreenPointRadius_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkControlPointsItem_GetSelectedPointBrush_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Depending on the control points item, the brush might not be taken into
	/// account.
	/// </summary>
	public virtual vtkBrush GetSelectedPointBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkControlPointsItem_GetSelectedPointBrush_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkControlPointsItem_GetSelectedPointPen_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Gets the selected point pen and brush.
	/// </summary>
	public virtual vtkPen GetSelectedPointPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkControlPointsItem_GetSelectedPointPen_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkControlPointsItem_GetShowLabels_27(HandleRef pThis);

	/// <summary>
	/// When set to true, labels are shown on the current control point and the end
	/// points. Default is false.
	/// </summary>
	public virtual bool GetShowLabels()
	{
		return (vtkControlPointsItem_GetShowLabels_27(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_GetStrokeMode_28(HandleRef pThis);

	/// <summary>
	/// Controls whether or not control points are drawn (true) or clicked and
	/// moved (false).
	/// False by default.
	/// </summary>
	public virtual bool GetStrokeMode()
	{
		return (vtkControlPointsItem_GetStrokeMode_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_GetSwitchPointsMode_29(HandleRef pThis);

	/// <summary>
	/// If DrawPoints is false, SwitchPoints controls the behavior when a control
	/// point is dragged past another point. The crossed point becomes current
	/// (true) or the current point is blocked/stopped (false).
	/// False by default.
	/// </summary>
	public virtual bool GetSwitchPointsMode()
	{
		return (vtkControlPointsItem_GetSwitchPointsMode_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_GetUseAddPointItem_30(HandleRef pThis);

	/// <summary>
	/// When enabled, a dedicated item is used to determine if a point should
	/// be added when clicking anywhere.
	/// This item can be recovered with GetAddPointItem and can this be placed
	/// below all other items. False by default.
	/// </summary>
	public virtual bool GetUseAddPointItem()
	{
		return (vtkControlPointsItem_GetUseAddPointItem_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkControlPointsItem_GetUserBounds_31(HandleRef pThis);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual double[] GetUserBounds()
	{
		IntPtr intPtr = vtkControlPointsItem_GetUserBounds_31(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_GetUserBounds_32(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual void GetUserBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkControlPointsItem_GetUserBounds_32(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_GetUserBounds_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual void GetUserBounds(IntPtr _arg)
	{
		vtkControlPointsItem_GetUserBounds_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkControlPointsItem_GetValidBounds_34(HandleRef pThis);

	/// <summary>
	/// Controls the valid range for the values.
	/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
	/// range is the current bounds. It is the default behavior.
	/// </summary>
	public virtual double[] GetValidBounds()
	{
		IntPtr intPtr = vtkControlPointsItem_GetValidBounds_34(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_GetValidBounds_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Controls the valid range for the values.
	/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
	/// range is the current bounds. It is the default behavior.
	/// </summary>
	public virtual void GetValidBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkControlPointsItem_GetValidBounds_35(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_GetValidBounds_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Controls the valid range for the values.
	/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
	/// range is the current bounds. It is the default behavior.
	/// </summary>
	public virtual void GetValidBounds(IntPtr _arg)
	{
		vtkControlPointsItem_GetValidBounds_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkControlPointsItem_IsA_37(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkControlPointsItem_IsA_37(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_IsOverPoint_38(HandleRef pThis, IntPtr pos, long pointId);

	/// <summary>
	/// Returns true if pos is above the pointId point, false otherwise.
	/// It uses the size of the drawn point. To search what point is under the pos,
	/// use the more efficient \sa FindPoint() instead.
	/// </summary>
	public bool IsOverPoint(IntPtr pos, long pointId)
	{
		return (vtkControlPointsItem_IsOverPoint_38(GetCppThis(), pos, pointId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkControlPointsItem_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkControlPointsItem_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_MovePoints_40(HandleRef pThis, HandleRef translation, HandleRef pointIds);

	/// <summary>
	/// Move the points referred by pointIds by a given translation.
	/// The new positions won't be outside the bounds.
	/// MovePoints is typically called with GetControlPointsIds() or GetSelection().
	/// Warning: if you pass this-&gt;GetSelection(), the array is deleted after
	/// each individual point move. Increase the reference count of the array.
	/// See also MoveAllPoints()
	/// </summary>
	public void MovePoints(vtkVector2f translation, vtkIdTypeArray pointIds)
	{
		vtkControlPointsItem_MovePoints_40(GetCppThis(), translation?.GetCppThis() ?? default(HandleRef), pointIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_MovePoints_41(HandleRef pThis, HandleRef translation, byte dontMoveFirstAndLast);

	/// <summary>
	/// Utility function to move all the control points of the given translation
	/// If dontMoveFirstAndLast is true, then the first and last points won't be
	/// moved.
	/// </summary>
	public void MovePoints(vtkVector2f translation, bool dontMoveFirstAndLast)
	{
		vtkControlPointsItem_MovePoints_41(GetCppThis(), translation?.GetCppThis() ?? default(HandleRef), (byte)(dontMoveFirstAndLast ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkControlPointsItem_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkControlPointsItem NewInstance()
	{
		vtkControlPointsItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkControlPointsItem_NewInstance_42(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_Paint_43(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint the points with a fixed size (cosmetic) which doesn't depend
	/// on the scene zoom factor. Selected and unselected points are drawn
	/// with a different color.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkControlPointsItem_Paint_43(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_RemoveCurrentPoint_44(HandleRef pThis);

	/// <summary>
	/// Remove the current point.
	/// </summary>
	public void RemoveCurrentPoint()
	{
		vtkControlPointsItem_RemoveCurrentPoint_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_RemovePoint_45(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Remove a point of the function. Returns the index of the point (0 based),
	/// or -1 on error.
	/// Subclasses should reimplement this function to do the actual work.
	/// </summary>
	public virtual long RemovePoint(IntPtr pos)
	{
		return vtkControlPointsItem_RemovePoint_45(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkControlPointsItem_RemovePoint_46(HandleRef pThis, long pointId);

	/// <summary>
	/// Remove a point give its id. It is a utility function that internally call
	/// the virtual method RemovePoint(double*) and return its result.
	/// </summary>
	public long RemovePoint(long pointId)
	{
		return vtkControlPointsItem_RemovePoint_46(GetCppThis(), pointId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_ResetBounds_47(HandleRef pThis);

	/// <summary>
	/// Recompute the bounds next time they are requested.
	/// You shouldn't have to call it but it is provided for rare cases.
	/// </summary>
	public void ResetBounds()
	{
		vtkControlPointsItem_ResetBounds_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkControlPointsItem_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkControlPointsItem SafeDownCast(vtkObjectBase o)
	{
		vtkControlPointsItem vtkControlPointsItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkControlPointsItem_SafeDownCast_48(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkControlPointsItem2 = (vtkControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkControlPointsItem2.Register(null);
			}
		}
		return vtkControlPointsItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SelectAllPoints_49(HandleRef pThis);

	/// <summary>
	/// Select all the points
	/// </summary>
	public void SelectAllPoints()
	{
		vtkControlPointsItem_SelectAllPoints_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SelectPoint_50(HandleRef pThis, long pointId);

	/// <summary>
	/// Select a point by its ID
	/// </summary>
	public void SelectPoint(long pointId)
	{
		vtkControlPointsItem_SelectPoint_50(GetCppThis(), pointId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SelectPoint_51(HandleRef pThis, IntPtr currentPoint);

	/// <summary>
	/// Utility function that selects a point providing its coordinates.
	/// To be found, the position of the point must be no further away than its
	/// painted point size
	/// </summary>
	public void SelectPoint(IntPtr currentPoint)
	{
		vtkControlPointsItem_SelectPoint_51(GetCppThis(), currentPoint);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkControlPointsItem_SelectPoints_52(HandleRef pThis, HandleRef min, HandleRef max);

	/// <summary>
	/// Select all points in the specified rectangle.
	/// </summary>
	public override bool SelectPoints(vtkVector2f min, vtkVector2f max)
	{
		return (vtkControlPointsItem_SelectPoints_52(GetCppThis(), min?.GetCppThis() ?? default(HandleRef), max?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetControlPoint_53(HandleRef pThis, long index, IntPtr point);

	/// <summary>
	/// Sets the x and y coordinates as well as the midpoint and sharpness
	/// of the control point corresponding to the index.
	/// </summary>
	public virtual void SetControlPoint(long index, IntPtr point)
	{
		vtkControlPointsItem_SetControlPoint_53(GetCppThis(), index, point);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetCurrentPoint_54(HandleRef pThis, long index);

	/// <summary>
	/// Sets the current point selected.
	/// </summary>
	public void SetCurrentPoint(long index)
	{
		vtkControlPointsItem_SetCurrentPoint_54(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetDrawPoints_55(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set the flag to draw points.
	/// Default is true.
	/// </summary>
	public virtual void SetDrawPoints(bool _arg)
	{
		vtkControlPointsItem_SetDrawPoints_55(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetEndPointsRemovable_56(HandleRef pThis, byte _arg);

	/// <summary>
	/// If EndPointsRemovable is false, the two end points will not
	/// be removed. True by default.
	/// </summary>
	public virtual void SetEndPointsRemovable(bool _arg)
	{
		vtkControlPointsItem_SetEndPointsRemovable_56(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetEndPointsXMovable_57(HandleRef pThis, byte _arg);

	/// <summary>
	/// If EndPointsMovable is false, the two end points will not
	/// be moved. True by default.
	/// </summary>
	public virtual void SetEndPointsXMovable(bool _arg)
	{
		vtkControlPointsItem_SetEndPointsXMovable_57(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetEndPointsYMovable_58(HandleRef pThis, byte _arg);

	/// <summary>
	/// If EndPointsMovable is false, the two end points will not
	/// be moved. True by default.
	/// </summary>
	public virtual void SetEndPointsYMovable(bool _arg)
	{
		vtkControlPointsItem_SetEndPointsYMovable_58(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetLabelFormat_59(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the label format. Default is "%.4f, %.4f".
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkControlPointsItem_SetLabelFormat_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetScreenPointRadius_60(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/set the radius for screen points.
	/// Default is 6.f
	/// </summary>
	public virtual void SetScreenPointRadius(float _arg)
	{
		vtkControlPointsItem_SetScreenPointRadius_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetShowLabels_61(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true, labels are shown on the current control point and the end
	/// points. Default is false.
	/// </summary>
	public virtual void SetShowLabels(bool _arg)
	{
		vtkControlPointsItem_SetShowLabels_61(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetStrokeMode_62(HandleRef pThis, byte _arg);

	/// <summary>
	/// Controls whether or not control points are drawn (true) or clicked and
	/// moved (false).
	/// False by default.
	/// </summary>
	public virtual void SetStrokeMode(bool _arg)
	{
		vtkControlPointsItem_SetStrokeMode_62(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetSwitchPointsMode_63(HandleRef pThis, byte _arg);

	/// <summary>
	/// If DrawPoints is false, SwitchPoints controls the behavior when a control
	/// point is dragged past another point. The crossed point becomes current
	/// (true) or the current point is blocked/stopped (false).
	/// False by default.
	/// </summary>
	public virtual void SetSwitchPointsMode(bool _arg)
	{
		vtkControlPointsItem_SetSwitchPointsMode_63(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetUseAddPointItem_64(HandleRef pThis, byte _arg);

	/// <summary>
	/// When enabled, a dedicated item is used to determine if a point should
	/// be added when clicking anywhere.
	/// This item can be recovered with GetAddPointItem and can this be placed
	/// below all other items. False by default.
	/// </summary>
	public virtual void SetUseAddPointItem(bool _arg)
	{
		vtkControlPointsItem_SetUseAddPointItem_64(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetUserBounds_65(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual void SetUserBounds(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkControlPointsItem_SetUserBounds_65(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetUserBounds_66(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set custom bounds, except if bounds are invalid, bounds will be
	/// automatically computed based on the range of the control points
	/// Invalid bounds by default.
	/// </summary>
	public virtual void SetUserBounds(IntPtr _arg)
	{
		vtkControlPointsItem_SetUserBounds_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetValidBounds_67(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Controls the valid range for the values.
	/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
	/// range is the current bounds. It is the default behavior.
	/// </summary>
	public virtual void SetValidBounds(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkControlPointsItem_SetValidBounds_67(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SetValidBounds_68(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Controls the valid range for the values.
	/// An invalid value (0, -1, 0., -1, 0, -1.) indicates that the valid
	/// range is the current bounds. It is the default behavior.
	/// </summary>
	public virtual void SetValidBounds(IntPtr _arg)
	{
		vtkControlPointsItem_SetValidBounds_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SpreadPoints_69(HandleRef pThis, float factor, HandleRef pointIds);

	/// <summary>
	/// Spread the points referred by pointIds
	/// If factor &gt; 0, points are moved away from each other.
	/// If factor &lt; 0, points are moved closer to each other
	/// SpreadPoints is typically called with GetControlPointsIds() or GetSelection().
	/// Warning: if you pass this-&gt;GetSelection(), the array is deleted after
	/// each individual point move. Increase the reference count of the array.
	/// </summary>
	public void SpreadPoints(float factor, vtkIdTypeArray pointIds)
	{
		vtkControlPointsItem_SpreadPoints_69(GetCppThis(), factor, pointIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_SpreadPoints_70(HandleRef pThis, float factor, byte dontSpreadFirstAndLast);

	/// <summary>
	/// Utility function to spread all the control points of a given factor
	/// If dontSpreadFirstAndLast is true, then the first and last points won't be
	/// spread.
	/// </summary>
	public void SpreadPoints(float factor, bool dontSpreadFirstAndLast)
	{
		vtkControlPointsItem_SpreadPoints_70(GetCppThis(), factor, (byte)(dontSpreadFirstAndLast ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_ToggleSelectPoint_71(HandleRef pThis, long pointId);

	/// <summary>
	/// Toggle the selection of a point by its ID. If the point was selected then
	/// unselect it, otherwise select it.
	/// </summary>
	public void ToggleSelectPoint(long pointId)
	{
		vtkControlPointsItem_ToggleSelectPoint_71(GetCppThis(), pointId);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_ToggleSelectPoint_72(HandleRef pThis, IntPtr currentPoint);

	/// <summary>
	/// Utility function that toggles the selection a point providing its
	/// coordinates. To be found, the position of the point must be no further
	/// away than its painted point size
	/// </summary>
	public void ToggleSelectPoint(IntPtr currentPoint)
	{
		vtkControlPointsItem_ToggleSelectPoint_72(GetCppThis(), currentPoint);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_UseAddPointItemOff_73(HandleRef pThis);

	/// <summary>
	/// When enabled, a dedicated item is used to determine if a point should
	/// be added when clicking anywhere.
	/// This item can be recovered with GetAddPointItem and can this be placed
	/// below all other items. False by default.
	/// </summary>
	public virtual void UseAddPointItemOff()
	{
		vtkControlPointsItem_UseAddPointItemOff_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkControlPointsItem_UseAddPointItemOn_74(HandleRef pThis);

	/// <summary>
	/// When enabled, a dedicated item is used to determine if a point should
	/// be added when clicking anywhere.
	/// This item can be recovered with GetAddPointItem and can this be placed
	/// below all other items. False by default.
	/// </summary>
	public virtual void UseAddPointItemOn()
	{
		vtkControlPointsItem_UseAddPointItemOn_74(GetCppThis());
	}
}
