using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContextArea
/// </summary>
/// <remarks>
///    Clipped, transformed area with axes for context items.
///
///
/// vtkContextArea provides an clipped drawing area surrounded by four axes.
/// The drawing area is transformed to map the 2D area described by
/// DrawAreaBounds into pixel coordinates. DrawAreaBounds is also used to
/// configure the axes. Item to be rendered in the draw area should be added
/// to the context item returned by GetDrawAreaItem().
///
/// The size and shape of the draw area is configured by the following member
/// variables:
/// - Geometry: The rect (pixel coordinates) defining the location of the context
///   area in the scene. This includes the draw area and axis ticks/labels.
/// - FillViewport: If true (default), Geometry is set to span the size returned
///   by vtkContextDevice2D::GetViewportSize().
/// - DrawAreaResizeBehavior: Controls how the draw area should be shaped.
///   Available options: Expand (default), FixedAspect, FixedRect, FixedMargins.
/// - FixedAspect: Aspect ratio to enforce for FixedAspect resize behavior.
/// - FixedRect: Rect used to enforce for FixedRect resize behavior.
/// - FixedMargins: Margins to enforce for FixedMargins resize behavior.
/// </remarks>
public class vtkContextArea : vtkAbstractContextItem
{
	/// <summary>
	/// The data bounds of the clipped and transformed area inside of the axes.
	/// This is used to configure the axes labels and setup the transform.
	/// </summary>
	public enum DrawAreaResizeBehaviorType
	{
		/// <summary>enum member</summary>
		DARB_Expand = 0,
		/// <summary>enum member</summary>
		DARB_FixedAspect = 1,
		/// <summary>enum member</summary>
		DARB_FixedMargins = 3,
		/// <summary>enum member</summary>
		DARB_FixedRect = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContextArea";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContextArea()
	{
		MRClassNameKey = "class vtkContextArea";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextArea"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContextArea(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContextArea New()
	{
		vtkContextArea result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextArea_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextArea)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkContextArea()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContextArea_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkContextArea_FillViewportOff_01(HandleRef pThis);

	/// <summary>
	/// If true, Geometry is set to (0, 0, vpSize[0], vpSize[1]) at the start
	/// of each Paint call. vpSize is vtkContextDevice2D::GetViewportSize. Default
	/// is true.
	/// </summary>
	public virtual void FillViewportOff()
	{
		vtkContextArea_FillViewportOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_FillViewportOn_02(HandleRef pThis);

	/// <summary>
	/// If true, Geometry is set to (0, 0, vpSize[0], vpSize[1]) at the start
	/// of each Paint call. vpSize is vtkContextDevice2D::GetViewportSize. Default
	/// is true.
	/// </summary>
	public virtual void FillViewportOn()
	{
		vtkContextArea_FillViewportOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_GetAxis_03(HandleRef pThis, vtkAxis.Location location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkAxis associated with the specified location.
	/// </summary>
	public vtkAxis GetAxis(vtkAxis.Location location)
	{
		vtkAxis vtkAxis2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextArea_GetAxis_03(GetCppThis(), location, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAxis2 = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAxis2.Register(null);
			}
		}
		return vtkAxis2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_GetDrawAreaBounds_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The data bounds of the clipped and transformed area inside of the axes.
	/// This is used to configure the axes labels and setup the transform.
	/// </summary>
	public virtual vtkRectd GetDrawAreaBounds()
	{
		vtkRectd result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextArea_GetDrawAreaBounds_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectd)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_GetDrawAreaItem_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the vtkAbstractContextItem that will draw in the clipped,
	/// transformed space. This is the item to add children for.
	/// </summary>
	public vtkAbstractContextItem GetDrawAreaItem()
	{
		vtkAbstractContextItem vtkAbstractContextItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextArea_GetDrawAreaItem_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractContextItem2 = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractContextItem2.Register(null);
			}
		}
		return vtkAbstractContextItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern DrawAreaResizeBehaviorType vtkContextArea_GetDrawAreaResizeBehavior_06(HandleRef pThis);

	/// <summary>
	/// Set the resize behavior for the draw area:
	/// - @a Expand: The default behavior. The draw area will automatically resize
	/// to take up as much of @a Geometry as possible. Margin sizes are
	/// minimized based on the space required for axis labels/tick marks.
	/// - FixedAspect: Same as Expand, but a fixed aspect ratio is enforced.
	/// See SetFixedAspect.
	/// - FixedRect: Draw area is always constrained to a fixed rectangle.
	/// See SetFixedRect.
	/// - FixMargins: The draw area expands to fill @a Geometry, but margins
	/// (axis labels, etc) are fixed, rather than dynamically sized.
	/// See SetFixedMargins.
	/// </summary>
	public virtual DrawAreaResizeBehaviorType GetDrawAreaResizeBehavior()
	{
		return vtkContextArea_GetDrawAreaResizeBehavior_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextArea_GetFillViewport_07(HandleRef pThis);

	/// <summary>
	/// If true, Geometry is set to (0, 0, vpSize[0], vpSize[1]) at the start
	/// of each Paint call. vpSize is vtkContextDevice2D::GetViewportSize. Default
	/// is true.
	/// </summary>
	public virtual bool GetFillViewport()
	{
		return (vtkContextArea_GetFillViewport_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkContextArea_GetFixedAspect_08(HandleRef pThis);

	/// <summary>
	/// The fixed aspect ratio, if DrawAreaResizeBehavior is FixedAspect.
	/// Defined as width/height. Default is 1.
	/// Setting the aspect ratio will also set DrawAreaResizeBehavior to
	/// FixedAspect.
	/// </summary>
	public virtual float GetFixedAspect()
	{
		return vtkContextArea_GetFixedAspect_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_GetFixedMarginsArray_09(HandleRef pThis, IntPtr margins);

	/// <summary>
	/// The left, right, bottom, and top margins for the draw area, if
	/// DrawAreaResizeBehavior is FixedMargins. Units are in pixels, default is
	/// { 0, 0, 0, 0 }.
	/// Setting the fixed margins will also set DrawAreaResizeBehavior to
	/// FixedMargins.
	/// </summary>
	public virtual void GetFixedMarginsArray(IntPtr margins)
	{
		vtkContextArea_GetFixedMarginsArray_09(GetCppThis(), margins);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_GetFixedMarginsArray_10(HandleRef pThis);

	/// <summary>
	/// The left, right, bottom, and top margins for the draw area, if
	/// DrawAreaResizeBehavior is FixedMargins. Units are in pixels, default is
	/// { 0, 0, 0, 0 }.
	/// Setting the fixed margins will also set DrawAreaResizeBehavior to
	/// FixedMargins.
	/// </summary>
	public virtual IntPtr GetFixedMarginsArray()
	{
		return vtkContextArea_GetFixedMarginsArray_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_GetFixedRect_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The fixed rect to use for the draw area, if DrawAreaResizeBehavior is
	/// FixedRect. Units are in pixels, default is 300x300+0+0.
	/// Setting the fixed rect will also set DrawAreaResizeBehavior to
	/// FixedRect.
	/// </summary>
	public virtual vtkRecti GetFixedRect()
	{
		vtkRecti result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextArea_GetFixedRect_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRecti)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_GetGeometry_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The rect defining the pixel location and size of the entire vtkContextArea,
	/// including axis labels, title, etc. Note that this will be updated to the
	/// window geometry if FillWindow is true.
	/// </summary>
	public virtual vtkRecti GetGeometry()
	{
		vtkRecti result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextArea_GetGeometry_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRecti)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextArea_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContextArea_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextArea_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContextArea_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextArea_GetShowGrid_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off grid visibility.
	/// </summary>
	public virtual bool GetShowGrid()
	{
		return (vtkContextArea_GetShowGrid_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextArea_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContextArea_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextArea_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContextArea_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContextArea NewInstance()
	{
		vtkContextArea result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextArea_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextArea)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextArea_Paint_20(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item, called whenever the item needs to be drawn.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkContextArea_Paint_20(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextArea_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContextArea SafeDownCast(vtkObjectBase o)
	{
		vtkContextArea vtkContextArea2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextArea_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContextArea2 = (vtkContextArea)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContextArea2.Register(null);
			}
		}
		return vtkContextArea2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetDrawAreaBounds_22(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// The data bounds of the clipped and transformed area inside of the axes.
	/// This is used to configure the axes labels and setup the transform.
	/// </summary>
	public virtual void SetDrawAreaBounds(vtkRectd _arg)
	{
		vtkContextArea_SetDrawAreaBounds_22(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetDrawAreaResizeBehavior_23(HandleRef pThis, DrawAreaResizeBehaviorType _arg);

	/// <summary>
	/// Set the resize behavior for the draw area:
	/// - @a Expand: The default behavior. The draw area will automatically resize
	/// to take up as much of @a Geometry as possible. Margin sizes are
	/// minimized based on the space required for axis labels/tick marks.
	/// - FixedAspect: Same as Expand, but a fixed aspect ratio is enforced.
	/// See SetFixedAspect.
	/// - FixedRect: Draw area is always constrained to a fixed rectangle.
	/// See SetFixedRect.
	/// - FixMargins: The draw area expands to fill @a Geometry, but margins
	/// (axis labels, etc) are fixed, rather than dynamically sized.
	/// See SetFixedMargins.
	/// </summary>
	public virtual void SetDrawAreaResizeBehavior(DrawAreaResizeBehaviorType _arg)
	{
		vtkContextArea_SetDrawAreaResizeBehavior_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetFillViewport_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, Geometry is set to (0, 0, vpSize[0], vpSize[1]) at the start
	/// of each Paint call. vpSize is vtkContextDevice2D::GetViewportSize. Default
	/// is true.
	/// </summary>
	public virtual void SetFillViewport(bool _arg)
	{
		vtkContextArea_SetFillViewport_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetFixedAspect_25(HandleRef pThis, float aspect);

	/// <summary>
	/// The fixed aspect ratio, if DrawAreaResizeBehavior is FixedAspect.
	/// Defined as width/height. Default is 1.
	/// Setting the aspect ratio will also set DrawAreaResizeBehavior to
	/// FixedAspect.
	/// </summary>
	public virtual void SetFixedAspect(float aspect)
	{
		vtkContextArea_SetFixedAspect_25(GetCppThis(), aspect);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetFixedMargins_26(HandleRef pThis, IntPtr margins);

	/// <summary>
	/// The left, right, bottom, and top margins for the draw area, if
	/// DrawAreaResizeBehavior is FixedMargins. Units are in pixels, default is
	/// { 0, 0, 0, 0 }.
	/// Setting the fixed margins will also set DrawAreaResizeBehavior to
	/// FixedMargins.
	/// </summary>
	public virtual void SetFixedMargins(IntPtr margins)
	{
		vtkContextArea_SetFixedMargins_26(GetCppThis(), margins);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetFixedMargins_27(HandleRef pThis, int left, int right, int bottom, int top);

	/// <summary>
	/// The left, right, bottom, and top margins for the draw area, if
	/// DrawAreaResizeBehavior is FixedMargins. Units are in pixels, default is
	/// { 0, 0, 0, 0 }.
	/// Setting the fixed margins will also set DrawAreaResizeBehavior to
	/// FixedMargins.
	/// </summary>
	public virtual void SetFixedMargins(int left, int right, int bottom, int top)
	{
		vtkContextArea_SetFixedMargins_27(GetCppThis(), left, right, bottom, top);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetFixedRect_28(HandleRef pThis, HandleRef rect);

	/// <summary>
	/// The fixed rect to use for the draw area, if DrawAreaResizeBehavior is
	/// FixedRect. Units are in pixels, default is 300x300+0+0.
	/// Setting the fixed rect will also set DrawAreaResizeBehavior to
	/// FixedRect.
	/// </summary>
	public virtual void SetFixedRect(vtkRecti rect)
	{
		vtkContextArea_SetFixedRect_28(GetCppThis(), rect?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetFixedRect_29(HandleRef pThis, int x, int y, int width, int height);

	/// <summary>
	/// The fixed rect to use for the draw area, if DrawAreaResizeBehavior is
	/// FixedRect. Units are in pixels, default is 300x300+0+0.
	/// Setting the fixed rect will also set DrawAreaResizeBehavior to
	/// FixedRect.
	/// </summary>
	public virtual void SetFixedRect(int x, int y, int width, int height)
	{
		vtkContextArea_SetFixedRect_29(GetCppThis(), x, y, width, height);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetGeometry_30(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// The rect defining the pixel location and size of the entire vtkContextArea,
	/// including axis labels, title, etc. Note that this will be updated to the
	/// window geometry if FillWindow is true.
	/// </summary>
	public virtual void SetGeometry(vtkRecti _arg)
	{
		vtkContextArea_SetGeometry_30(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_SetShowGrid_31(HandleRef pThis, byte show);

	/// <summary>
	/// Turn on/off grid visibility.
	/// </summary>
	public virtual void SetShowGrid(bool show)
	{
		vtkContextArea_SetShowGrid_31(GetCppThis(), (byte)(show ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_ShowGridOff_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off grid visibility.
	/// </summary>
	public virtual void ShowGridOff()
	{
		vtkContextArea_ShowGridOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextArea_ShowGridOn_33(HandleRef pThis);

	/// <summary>
	/// Turn on/off grid visibility.
	/// </summary>
	public virtual void ShowGridOn()
	{
		vtkContextArea_ShowGridOn_33(GetCppThis());
	}
}
