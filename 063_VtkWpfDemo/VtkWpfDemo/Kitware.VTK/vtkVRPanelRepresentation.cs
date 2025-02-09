using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRPanelRepresentation
/// </summary>
/// <remarks>
///    Widget representation for vtkVRPanelWidget
/// Implementation of the popup panel representation for the
/// vtkVRPanelWidget.
/// This representation is rebuilt every time the hovered prop changes.
/// Its position is set according to the camera orientation and is placed at a
/// distance defined in meters in the BuildRepresentation() method.
///
/// WARNING: The panel might be occluded by other props.
/// </remarks>
public class vtkVRPanelRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Moving = 1,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRPanelRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRPanelRepresentation()
	{
		MRClassNameKey = "class vtkVRPanelRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRPanelRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRPanelRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRPanelRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkVRPanelRepresentation New()
	{
		vtkVRPanelRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRPanelRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRPanelRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkVRPanelRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVRPanelRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_AllowAdjustmentOff_01(HandleRef pThis);

	/// <summary>
	/// Can the panel be relocated by the user
	/// </summary>
	public virtual void AllowAdjustmentOff()
	{
		vtkVRPanelRepresentation_AllowAdjustmentOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_AllowAdjustmentOn_02(HandleRef pThis);

	/// <summary>
	/// Can the panel be relocated by the user
	/// </summary>
	public virtual void AllowAdjustmentOn()
	{
		vtkVRPanelRepresentation_AllowAdjustmentOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_BuildRepresentation_03(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkVRPanelRepresentation_BuildRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_ComplexInteraction_04(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkVRPanelRepresentation_ComplexInteraction_04(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRPanelRepresentation_ComputeComplexInteractionState_05(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
	{
		return vtkVRPanelRepresentation_ComputeComplexInteractionState_05(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata, modify);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_EndComplexInteraction_06(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkVRPanelRepresentation_EndComplexInteraction_06(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRPanelRepresentation_GetAllowAdjustment_07(HandleRef pThis);

	/// <summary>
	/// Can the panel be relocated by the user
	/// </summary>
	public virtual bool GetAllowAdjustment()
	{
		return (vtkVRPanelRepresentation_GetAllowAdjustment_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRPanelRepresentation_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRPanelRepresentation_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRPanelRepresentation_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRPanelRepresentation_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRPanelRepresentation_GetTextActor_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set panel text
	/// </summary>
	public virtual vtkTextActor3D GetTextActor()
	{
		vtkTextActor3D vtkTextActor3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRPanelRepresentation_GetTextActor_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextActor3D2 = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextActor3D2.Register(null);
			}
		}
		return vtkTextActor3D2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRPanelRepresentation_HasTranslucentPolygonalGeometry_11(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkVRPanelRepresentation_HasTranslucentPolygonalGeometry_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRPanelRepresentation_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRPanelRepresentation_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRPanelRepresentation_IsTypeOf_13(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRPanelRepresentation_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRPanelRepresentation_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkVRPanelRepresentation NewInstance()
	{
		vtkVRPanelRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRPanelRepresentation_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRPanelRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_PlaceWidget_16(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkVRPanelRepresentation_PlaceWidget_16(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_PlaceWidgetExtended_17(HandleRef pThis, IntPtr bounds, IntPtr normal, IntPtr upvec, double scale);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public void PlaceWidgetExtended(IntPtr bounds, IntPtr normal, IntPtr upvec, double scale)
	{
		vtkVRPanelRepresentation_PlaceWidgetExtended_17(GetCppThis(), bounds, normal, upvec, scale);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkVRPanelRepresentation_ReleaseGraphicsResources_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRPanelRepresentation_RenderOpaqueGeometry_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkVRPanelRepresentation_RenderOpaqueGeometry_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRPanelRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkVRPanelRepresentation_RenderTranslucentPolygonalGeometry_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRPanelRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkVRPanelRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkVRPanelRepresentation vtkVRPanelRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRPanelRepresentation_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRPanelRepresentation2 = (vtkVRPanelRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRPanelRepresentation2.Register(null);
			}
		}
		return vtkVRPanelRepresentation2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_SetAllowAdjustment_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Can the panel be relocated by the user
	/// </summary>
	public virtual void SetAllowAdjustment(bool _arg)
	{
		vtkVRPanelRepresentation_SetAllowAdjustment_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_SetCoordinateSystemToHMD_23(HandleRef pThis);

	/// <summary>
	/// Set panel text
	/// </summary>
	public void SetCoordinateSystemToHMD()
	{
		vtkVRPanelRepresentation_SetCoordinateSystemToHMD_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_SetCoordinateSystemToLeftController_24(HandleRef pThis);

	/// <summary>
	/// Set panel text
	/// </summary>
	public void SetCoordinateSystemToLeftController()
	{
		vtkVRPanelRepresentation_SetCoordinateSystemToLeftController_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_SetCoordinateSystemToRightController_25(HandleRef pThis);

	/// <summary>
	/// Set panel text
	/// </summary>
	public void SetCoordinateSystemToRightController()
	{
		vtkVRPanelRepresentation_SetCoordinateSystemToRightController_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_SetCoordinateSystemToWorld_26(HandleRef pThis);

	/// <summary>
	/// Set panel text
	/// </summary>
	public void SetCoordinateSystemToWorld()
	{
		vtkVRPanelRepresentation_SetCoordinateSystemToWorld_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_SetText_27(HandleRef pThis, string str);

	/// <summary>
	/// Set panel text
	/// </summary>
	public void SetText(string str)
	{
		vtkVRPanelRepresentation_SetText_27(GetCppThis(), str);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRPanelRepresentation_StartComplexInteraction_28(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkVRPanelRepresentation_StartComplexInteraction_28(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}
}
