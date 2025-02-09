using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRInteractorStyle
/// </summary>
/// <remarks>
///    Extended from vtkInteractorStyle3D to override command methods.
///
/// This abstract class defines an interactor style in a virtual reality context.
/// </remarks>
public abstract class vtkVRInteractorStyle : vtkInteractorStyle3D
{
	/// <summary>
	/// Specify if the grab mode uses the ray to grab distant objects.
	/// Default is set to on.
	/// </summary>
	public enum MovementStyle
	{
		/// <summary>enum member</summary>
		FLY_STYLE,
		/// <summary>enum member</summary>
		GROUNDED_STYLE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRInteractorStyle";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRInteractorStyle()
	{
		MRClassNameKey = "class vtkVRInteractorStyle";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRInteractorStyle"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_AddTooltipForInput_01(HandleRef pThis, vtkEventDataDevice device, vtkEventDataDeviceInput input, string text);

	/// <summary>
	/// Define the helper text that goes with an input.
	/// </summary>
	public void AddTooltipForInput(vtkEventDataDevice device, vtkEventDataDeviceInput input, string text)
	{
		vtkVRInteractorStyle_AddTooltipForInput_01(GetCppThis(), device, input, text);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_Clip_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods for interaction.
	/// </summary>
	public void Clip(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_Clip_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_Elevation3D_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Move the camera following the "Z" axis (elevation) using the thumbstick/trackpad
	/// position (up/down).
	/// </summary>
	public void Elevation3D(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_Elevation3D_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_EndClip_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void EndClip(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_EndClip_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_EndLoadCamPose_05(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void EndLoadCamPose(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_EndLoadCamPose_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_EndMovement3D_06(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void EndMovement3D(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_EndMovement3D_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_EndPick_07(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void EndPick(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_EndPick_07(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_EndPositionProp_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void EndPositionProp(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_EndPositionProp_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRInteractorStyle_GetGrabWithRay_09(HandleRef pThis);

	/// <summary>
	/// Specify if the grab mode uses the ray to grab distant objects.
	/// Default is set to on.
	/// </summary>
	public virtual bool GetGrabWithRay()
	{
		return (vtkVRInteractorStyle_GetGrabWithRay_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRInteractorStyle_GetHoverPick_10(HandleRef pThis);

	/// <summary>
	/// Indicates if picking should be updated every frame. If so, the interaction
	/// picker will try to pick a prop and rays will be updated accordingly.
	/// Default is set to off.
	/// </summary>
	public virtual bool GetHoverPick()
	{
		return (vtkVRInteractorStyle_GetHoverPick_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRInteractorStyle_GetInteractionState_11(HandleRef pThis, vtkEventDataDevice device);

	/// <summary>
	/// Return interaction state for the specified device (dolly, pick, none, etc...).
	/// </summary>
	public int GetInteractionState(vtkEventDataDevice device)
	{
		return vtkVRInteractorStyle_GetInteractionState_11(GetCppThis(), device);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRInteractorStyle_GetMenu_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the menu to allow the user to add options to it.
	/// </summary>
	public vtkVRMenuWidget GetMenu()
	{
		vtkVRMenuWidget vtkVRMenuWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRInteractorStyle_GetMenu_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRMenuWidget2 = (vtkVRMenuWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRMenuWidget2.Register(null);
			}
		}
		return vtkVRMenuWidget2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRInteractorStyle_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRInteractorStyle_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRInteractorStyle_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRInteractorStyle_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern MovementStyle vtkVRInteractorStyle_GetStyle_15(HandleRef pThis);

	/// <summary>
	/// Specify the movement style between 'Flying" and "Grounded".
	/// Default is Flying.
	/// </summary>
	public virtual MovementStyle GetStyle()
	{
		return vtkVRInteractorStyle_GetStyle_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_GrabWithRayOff_16(HandleRef pThis);

	/// <summary>
	/// Specify if the grab mode uses the ray to grab distant objects.
	/// Default is set to on.
	/// </summary>
	public virtual void GrabWithRayOff()
	{
		vtkVRInteractorStyle_GrabWithRayOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_GrabWithRayOn_17(HandleRef pThis);

	/// <summary>
	/// Specify if the grab mode uses the ray to grab distant objects.
	/// Default is set to on.
	/// </summary>
	public virtual void GrabWithRayOn()
	{
		vtkVRInteractorStyle_GrabWithRayOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_GroundMovement3D_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Move the camera on the "XY" plan (ground) using the thumbstick/trackpad position
	/// (up/down and left/right), according to the headset view direction.
	/// </summary>
	public void GroundMovement3D(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_GroundMovement3D_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_HideBillboard_19(HandleRef pThis);

	/// <summary>
	/// Show/hide billboard with given text string.
	/// </summary>
	public void HideBillboard()
	{
		vtkVRInteractorStyle_HideBillboard_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_HidePickActor_20(HandleRef pThis);

	/// <summary>
	/// Hide the pick actor (sphere or polydata).
	/// </summary>
	public void HidePickActor()
	{
		vtkVRInteractorStyle_HidePickActor_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_HideRay_21(HandleRef pThis, vtkEventDataDevice controller);

	/// <summary>
	/// Show/hide the ray for the specified controller.
	/// </summary>
	public void HideRay(vtkEventDataDevice controller)
	{
		vtkVRInteractorStyle_HideRay_21(GetCppThis(), controller);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_HoverPickOff_22(HandleRef pThis);

	/// <summary>
	/// Indicates if picking should be updated every frame. If so, the interaction
	/// picker will try to pick a prop and rays will be updated accordingly.
	/// Default is set to off.
	/// </summary>
	public virtual void HoverPickOff()
	{
		vtkVRInteractorStyle_HoverPickOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_HoverPickOn_23(HandleRef pThis);

	/// <summary>
	/// Indicates if picking should be updated every frame. If so, the interaction
	/// picker will try to pick a prop and rays will be updated accordingly.
	/// Default is set to off.
	/// </summary>
	public virtual void HoverPickOn()
	{
		vtkVRInteractorStyle_HoverPickOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRInteractorStyle_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRInteractorStyle_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRInteractorStyle_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRInteractorStyle_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_LoadNextCameraPose_26(HandleRef pThis);

	/// <summary>
	/// Methods for interaction.
	/// </summary>
	public virtual void LoadNextCameraPose()
	{
		vtkVRInteractorStyle_LoadNextCameraPose_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRInteractorStyle_MakeControlsHelper_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new ControlsHelper suitable for use with the child class.
	/// </summary>
	public virtual vtkVRControlsHelper MakeControlsHelper()
	{
		vtkVRControlsHelper vtkVRControlsHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRInteractorStyle_MakeControlsHelper_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRControlsHelper2 = (vtkVRControlsHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRControlsHelper2.Register(null);
			}
		}
		return vtkVRControlsHelper2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_MapInputToAction_28(HandleRef pThis, vtkCommand.EventIds eid, int state);

	/// <summary>
	/// Map controller inputs to actions.
	/// Actions are defined by a VTKIS_*STATE*, interaction entry points,
	/// and the corresponding method for interaction.
	/// </summary>
	public void MapInputToAction(vtkCommand.EventIds eid, int state)
	{
		vtkVRInteractorStyle_MapInputToAction_28(GetCppThis(), eid, state);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_MapInputToAction_29(HandleRef pThis, vtkCommand.EventIds eid, vtkEventDataAction action, int state);

	/// <summary>
	/// Map controller inputs to actions.
	/// Actions are defined by a VTKIS_*STATE*, interaction entry points,
	/// and the corresponding method for interaction.
	/// </summary>
	public void MapInputToAction(vtkCommand.EventIds eid, vtkEventDataAction action, int state)
	{
		vtkVRInteractorStyle_MapInputToAction_29(GetCppThis(), eid, action, state);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRInteractorStyle_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVRInteractorStyle NewInstance()
	{
		vtkVRInteractorStyle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRInteractorStyle_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnElevation3D_31(HandleRef pThis, HandleRef edata);

	/// <summary>
	/// Override generic event bindings to call the corresponding action.
	/// </summary>
	public override void OnElevation3D(vtkEventData edata)
	{
		vtkVRInteractorStyle_OnElevation3D_31(GetCppThis(), edata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnMenu3D_32(HandleRef pThis, HandleRef edata);

	/// <summary>
	/// Override generic event bindings to call the corresponding action.
	/// </summary>
	public override void OnMenu3D(vtkEventData edata)
	{
		vtkVRInteractorStyle_OnMenu3D_32(GetCppThis(), edata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnMove3D_33(HandleRef pThis, HandleRef edata);

	/// <summary>
	/// Override generic event bindings to call the corresponding action.
	/// </summary>
	public override void OnMove3D(vtkEventData edata)
	{
		vtkVRInteractorStyle_OnMove3D_33(GetCppThis(), edata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnNextPose3D_34(HandleRef pThis, HandleRef edata);

	/// <summary>
	/// Override generic event bindings to call the corresponding action.
	/// </summary>
	public override void OnNextPose3D(vtkEventData edata)
	{
		vtkVRInteractorStyle_OnNextPose3D_34(GetCppThis(), edata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnPan_35(HandleRef pThis);

	/// <summary>
	/// Multitouch events binding.
	/// </summary>
	public override void OnPan()
	{
		vtkVRInteractorStyle_OnPan_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnPinch_36(HandleRef pThis);

	/// <summary>
	/// Multitouch events binding.
	/// </summary>
	public override void OnPinch()
	{
		vtkVRInteractorStyle_OnPinch_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnRotate_37(HandleRef pThis);

	/// <summary>
	/// Multitouch events binding.
	/// </summary>
	public override void OnRotate()
	{
		vtkVRInteractorStyle_OnRotate_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnSelect3D_38(HandleRef pThis, HandleRef edata);

	/// <summary>
	/// Override generic event bindings to call the corresponding action.
	/// </summary>
	public override void OnSelect3D(vtkEventData edata)
	{
		vtkVRInteractorStyle_OnSelect3D_38(GetCppThis(), edata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_OnViewerMovement3D_39(HandleRef pThis, HandleRef edata);

	/// <summary>
	/// Override generic event bindings to call the corresponding action.
	/// </summary>
	public override void OnViewerMovement3D(vtkEventData edata)
	{
		vtkVRInteractorStyle_OnViewerMovement3D_39(GetCppThis(), edata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_PositionProp_40(HandleRef pThis, HandleRef arg0, IntPtr lwpos, IntPtr lwori);

	/// <summary>
	/// Methods for interaction.
	/// </summary>
	public override void PositionProp(vtkEventData arg0, IntPtr lwpos, IntPtr lwori)
	{
		vtkVRInteractorStyle_PositionProp_40(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), lwpos, lwori);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_ProbeData_41(HandleRef pThis, vtkEventDataDevice controller);

	/// <summary>
	/// Methods for interaction.
	/// </summary>
	public void ProbeData(vtkEventDataDevice controller)
	{
		vtkVRInteractorStyle_ProbeData_41(GetCppThis(), controller);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRInteractorStyle_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRInteractorStyle SafeDownCast(vtkObjectBase o)
	{
		vtkVRInteractorStyle vtkVRInteractorStyle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRInteractorStyle_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRInteractorStyle2 = (vtkVRInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRInteractorStyle2.Register(null);
			}
		}
		return vtkVRInteractorStyle2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_SetDrawControls_43(HandleRef pThis, byte arg0);

	/// <summary>
	/// Control visibility of descriptive tooltips for controller/HMD models.
	/// </summary>
	public void SetDrawControls(bool arg0)
	{
		vtkVRInteractorStyle_SetDrawControls_43(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_SetGrabWithRay_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify if the grab mode uses the ray to grab distant objects.
	/// Default is set to on.
	/// </summary>
	public virtual void SetGrabWithRay(bool _arg)
	{
		vtkVRInteractorStyle_SetGrabWithRay_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_SetHoverPick_45(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicates if picking should be updated every frame. If so, the interaction
	/// picker will try to pick a prop and rays will be updated accordingly.
	/// Default is set to off.
	/// </summary>
	public virtual void SetHoverPick(bool _arg)
	{
		vtkVRInteractorStyle_SetHoverPick_45(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_SetInteractor_46(HandleRef pThis, HandleRef iren);

	/// <summary>
	/// Set the Interactor wrapper being controlled by this object.
	/// </summary>
	public override void SetInteractor(vtkRenderWindowInteractor iren)
	{
		vtkVRInteractorStyle_SetInteractor_46(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_SetStyle_47(HandleRef pThis, MovementStyle _arg);

	/// <summary>
	/// Specify the movement style between 'Flying" and "Grounded".
	/// Default is Flying.
	/// </summary>
	public virtual void SetStyle(MovementStyle _arg)
	{
		vtkVRInteractorStyle_SetStyle_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_SetupActions_48(HandleRef pThis, HandleRef iren);

	/// <summary>
	/// Setup default actions defined with an action path and a corresponding command.
	/// </summary>
	public virtual void SetupActions(vtkRenderWindowInteractor iren)
	{
		vtkVRInteractorStyle_SetupActions_48(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_ShowBillboard_49(HandleRef pThis, string text);

	/// <summary>
	/// Show/hide billboard with given text string.
	/// </summary>
	public void ShowBillboard(string text)
	{
		vtkVRInteractorStyle_ShowBillboard_49(GetCppThis(), text);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_ShowPickCell_50(HandleRef pThis, HandleRef cell, HandleRef arg1);

	/// <summary>
	/// Make the pick actor a polydata built from the points and edges of the
	/// given cell, and show it.
	/// </summary>
	public void ShowPickCell(vtkCell cell, vtkProp3D arg1)
	{
		vtkVRInteractorStyle_ShowPickCell_50(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_ShowPickSphere_51(HandleRef pThis, IntPtr pos, double radius, HandleRef arg2);

	/// <summary>
	/// Make the pick actor a sphere of given radius centered at given position,
	/// and show it.
	/// </summary>
	public void ShowPickSphere(IntPtr pos, double radius, vtkProp3D arg2)
	{
		vtkVRInteractorStyle_ShowPickSphere_51(GetCppThis(), pos, radius, arg2?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_ShowRay_52(HandleRef pThis, vtkEventDataDevice controller);

	/// <summary>
	/// Show/hide the ray for the specified controller.
	/// </summary>
	public void ShowRay(vtkEventDataDevice controller)
	{
		vtkVRInteractorStyle_ShowRay_52(GetCppThis(), controller);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_StartClip_53(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void StartClip(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_StartClip_53(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_StartLoadCamPose_54(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void StartLoadCamPose(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_StartLoadCamPose_54(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_StartMovement3D_55(HandleRef pThis, int interactionState, HandleRef arg1);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void StartMovement3D(int interactionState, vtkEventDataDevice3D arg1)
	{
		vtkVRInteractorStyle_StartMovement3D_55(GetCppThis(), interactionState, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_StartPick_56(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void StartPick(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_StartPick_56(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_StartPositionProp_57(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Interaction mode entry points.
	/// </summary>
	public void StartPositionProp(vtkEventDataDevice3D arg0)
	{
		vtkVRInteractorStyle_StartPositionProp_57(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRInteractorStyle_ToggleDrawControls_58(HandleRef pThis);

	/// <summary>
	/// Control visibility of descriptive tooltips for controller/HMD models.
	/// </summary>
	public void ToggleDrawControls()
	{
		vtkVRInteractorStyle_ToggleDrawControls_58(GetCppThis());
	}
}
