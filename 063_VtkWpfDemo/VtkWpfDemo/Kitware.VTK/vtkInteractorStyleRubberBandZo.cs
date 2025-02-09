using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleRubberBandZoom
/// </summary>
/// <remarks>
///    zoom in by amount indicated by rubber band box
///
/// This interactor style allows the user to draw a rectangle in the render
/// window using the left mouse button.  When the mouse button is released,
/// the current camera zooms by an amount determined from the shorter side of
/// the drawn rectangle.
/// </remarks>
public class vtkInteractorStyleRubberBandZoom : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBandZoom";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleRubberBandZoom()
	{
		MRClassNameKey = "class vtkInteractorStyleRubberBandZoom";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBandZoom"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleRubberBandZoom(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBandZoom_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleRubberBandZoom New()
	{
		vtkInteractorStyleRubberBandZoom result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBandZoom_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleRubberBandZoom()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleRubberBandZoom_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_CenterAtStartPositionOff_01(HandleRef pThis);

	/// <summary>
	/// When set to true (default, false), the position where the user starts the
	/// interaction is treated as the center of the box rather that one of the
	/// corners of the box.
	///
	/// During interaction, modifier keys `Shift` or `Control` can be used to toggle
	/// this flag temporarily. In other words, if `Shift` or `Control` key is pressed,
	/// this class will act as if CenterAtStartPosition was opposite of what it is
	/// set to.
	/// </summary>
	public virtual void CenterAtStartPositionOff()
	{
		vtkInteractorStyleRubberBandZoom_CenterAtStartPositionOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_CenterAtStartPositionOn_02(HandleRef pThis);

	/// <summary>
	/// When set to true (default, false), the position where the user starts the
	/// interaction is treated as the center of the box rather that one of the
	/// corners of the box.
	///
	/// During interaction, modifier keys `Shift` or `Control` can be used to toggle
	/// this flag temporarily. In other words, if `Shift` or `Control` key is pressed,
	/// this class will act as if CenterAtStartPosition was opposite of what it is
	/// set to.
	/// </summary>
	public virtual void CenterAtStartPositionOn()
	{
		vtkInteractorStyleRubberBandZoom_CenterAtStartPositionOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInteractorStyleRubberBandZoom_GetCenterAtStartPosition_03(HandleRef pThis);

	/// <summary>
	/// When set to true (default, false), the position where the user starts the
	/// interaction is treated as the center of the box rather that one of the
	/// corners of the box.
	///
	/// During interaction, modifier keys `Shift` or `Control` can be used to toggle
	/// this flag temporarily. In other words, if `Shift` or `Control` key is pressed,
	/// this class will act as if CenterAtStartPosition was opposite of what it is
	/// set to.
	/// </summary>
	public virtual bool GetCenterAtStartPosition()
	{
		return (vtkInteractorStyleRubberBandZoom_GetCenterAtStartPosition_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInteractorStyleRubberBandZoom_GetLockAspectToViewport_04(HandleRef pThis);

	/// <summary>
	/// When set to true (default, false), the interactor will lock the rendered box to the
	/// viewport's aspect ratio.
	/// </summary>
	public virtual bool GetLockAspectToViewport()
	{
		return (vtkInteractorStyleRubberBandZoom_GetLockAspectToViewport_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleRubberBandZoom_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleRubberBandZoom_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleRubberBandZoom_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleRubberBandZoom_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkInteractorStyleRubberBandZoom_GetUseDollyForPerspectiveProjection_07(HandleRef pThis);

	/// <summary>
	/// If camera is in perspective projection mode, this interactor style uses
	/// vtkCamera::Dolly to dolly the camera ahead for zooming. However, that can
	/// have unintended consequences such as the camera entering into the data.
	/// Another option is to use vtkCamera::Zoom instead. In that case, the camera
	/// position is left unchanged, instead the focal point is changed to the
	/// center of the target box and then the view angle is changed to zoom in.
	/// To use this approach, set this parameter to false (default, true).
	/// </summary>
	public virtual bool GetUseDollyForPerspectiveProjection()
	{
		return (vtkInteractorStyleRubberBandZoom_GetUseDollyForPerspectiveProjection_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBandZoom_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleRubberBandZoom_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleRubberBandZoom_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleRubberBandZoom_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_LockAspectToViewportOff_10(HandleRef pThis);

	/// <summary>
	/// When set to true (default, false), the interactor will lock the rendered box to the
	/// viewport's aspect ratio.
	/// </summary>
	public virtual void LockAspectToViewportOff()
	{
		vtkInteractorStyleRubberBandZoom_LockAspectToViewportOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_LockAspectToViewportOn_11(HandleRef pThis);

	/// <summary>
	/// When set to true (default, false), the interactor will lock the rendered box to the
	/// viewport's aspect ratio.
	/// </summary>
	public virtual void LockAspectToViewportOn()
	{
		vtkInteractorStyleRubberBandZoom_LockAspectToViewportOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBandZoom_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleRubberBandZoom NewInstance()
	{
		vtkInteractorStyleRubberBandZoom result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBandZoom_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_OnLeftButtonDown_14(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleRubberBandZoom_OnLeftButtonDown_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_OnLeftButtonUp_15(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleRubberBandZoom_OnLeftButtonUp_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_OnMouseMove_16(HandleRef pThis);

	/// <summary>
	/// Event bindings
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleRubberBandZoom_OnMouseMove_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleRubberBandZoom_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleRubberBandZoom SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleRubberBandZoom vtkInteractorStyleRubberBandZoom2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleRubberBandZoom_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleRubberBandZoom2 = (vtkInteractorStyleRubberBandZoom)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleRubberBandZoom2.Register(null);
			}
		}
		return vtkInteractorStyleRubberBandZoom2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_SetCenterAtStartPosition_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default, false), the position where the user starts the
	/// interaction is treated as the center of the box rather that one of the
	/// corners of the box.
	///
	/// During interaction, modifier keys `Shift` or `Control` can be used to toggle
	/// this flag temporarily. In other words, if `Shift` or `Control` key is pressed,
	/// this class will act as if CenterAtStartPosition was opposite of what it is
	/// set to.
	/// </summary>
	public virtual void SetCenterAtStartPosition(bool _arg)
	{
		vtkInteractorStyleRubberBandZoom_SetCenterAtStartPosition_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_SetLockAspectToViewport_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default, false), the interactor will lock the rendered box to the
	/// viewport's aspect ratio.
	/// </summary>
	public virtual void SetLockAspectToViewport(bool _arg)
	{
		vtkInteractorStyleRubberBandZoom_SetLockAspectToViewport_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_SetUseDollyForPerspectiveProjection_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// If camera is in perspective projection mode, this interactor style uses
	/// vtkCamera::Dolly to dolly the camera ahead for zooming. However, that can
	/// have unintended consequences such as the camera entering into the data.
	/// Another option is to use vtkCamera::Zoom instead. In that case, the camera
	/// position is left unchanged, instead the focal point is changed to the
	/// center of the target box and then the view angle is changed to zoom in.
	/// To use this approach, set this parameter to false (default, true).
	/// </summary>
	public virtual void SetUseDollyForPerspectiveProjection(bool _arg)
	{
		vtkInteractorStyleRubberBandZoom_SetUseDollyForPerspectiveProjection_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_UseDollyForPerspectiveProjectionOff_21(HandleRef pThis);

	/// <summary>
	/// If camera is in perspective projection mode, this interactor style uses
	/// vtkCamera::Dolly to dolly the camera ahead for zooming. However, that can
	/// have unintended consequences such as the camera entering into the data.
	/// Another option is to use vtkCamera::Zoom instead. In that case, the camera
	/// position is left unchanged, instead the focal point is changed to the
	/// center of the target box and then the view angle is changed to zoom in.
	/// To use this approach, set this parameter to false (default, true).
	/// </summary>
	public virtual void UseDollyForPerspectiveProjectionOff()
	{
		vtkInteractorStyleRubberBandZoom_UseDollyForPerspectiveProjectionOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleRubberBandZoom_UseDollyForPerspectiveProjectionOn_22(HandleRef pThis);

	/// <summary>
	/// If camera is in perspective projection mode, this interactor style uses
	/// vtkCamera::Dolly to dolly the camera ahead for zooming. However, that can
	/// have unintended consequences such as the camera entering into the data.
	/// Another option is to use vtkCamera::Zoom instead. In that case, the camera
	/// position is left unchanged, instead the focal point is changed to the
	/// center of the target box and then the view angle is changed to zoom in.
	/// To use this approach, set this parameter to false (default, true).
	/// </summary>
	public virtual void UseDollyForPerspectiveProjectionOn()
	{
		vtkInteractorStyleRubberBandZoom_UseDollyForPerspectiveProjectionOn_22(GetCppThis());
	}
}
