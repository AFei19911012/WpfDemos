using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRControlsHelper
/// </summary>
/// <remarks>
///    Tooltip helper explaining controls
/// Helper class to draw one tooltip per button around the controller.
///
/// </remarks>
/// <seealso>
///
/// vtkVRPanelRepresentation
/// </seealso>
public abstract class vtkVRControlsHelper : vtkProp
{
	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public enum ButtonSides
	{
		/// <summary>enum member</summary>
		Back = -1,
		/// <summary>enum member</summary>
		Front = 1
	}

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public enum DrawSides
	{
		/// <summary>enum member</summary>
		Left = -1,
		/// <summary>enum member</summary>
		Right = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRControlsHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRControlsHelper()
	{
		MRClassNameKey = "class vtkVRControlsHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRControlsHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRControlsHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkVRControlsHelper_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public void BuildRepresentation()
	{
		vtkVRControlsHelper_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRControlsHelper_EnabledOff_02(HandleRef pThis);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public virtual void EnabledOff()
	{
		vtkVRControlsHelper_EnabledOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRControlsHelper_EnabledOn_03(HandleRef pThis);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public virtual void EnabledOn()
	{
		vtkVRControlsHelper_EnabledOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRControlsHelper_GetEnabled_04(HandleRef pThis);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public virtual bool GetEnabled()
	{
		return (vtkVRControlsHelper_GetEnabled_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRControlsHelper_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRControlsHelper_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRControlsHelper_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRControlsHelper_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRControlsHelper_GetRenderer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public virtual vtkRenderer GetRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRControlsHelper_GetRenderer_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRControlsHelper_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkVRControlsHelper_HasTranslucentPolygonalGeometry_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRControlsHelper_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRControlsHelper_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRControlsHelper_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRControlsHelper_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRControlsHelper_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkVRControlsHelper NewInstance()
	{
		vtkVRControlsHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRControlsHelper_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRControlsHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRControlsHelper_ReleaseGraphicsResources_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkVRControlsHelper_ReleaseGraphicsResources_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRControlsHelper_RenderOpaqueGeometry_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkVRControlsHelper_RenderOpaqueGeometry_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRControlsHelper_RenderTranslucentPolygonalGeometry_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkVRControlsHelper_RenderTranslucentPolygonalGeometry_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRControlsHelper_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkVRControlsHelper SafeDownCast(vtkObjectBase o)
	{
		vtkVRControlsHelper vtkVRControlsHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRControlsHelper_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkVRControlsHelper_SetDevice_16(HandleRef pThis, vtkEventDataDevice val);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public void SetDevice(vtkEventDataDevice val)
	{
		vtkVRControlsHelper_SetDevice_16(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRControlsHelper_SetEnabled_17(HandleRef pThis, byte enabled);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public void SetEnabled(bool enabled)
	{
		vtkVRControlsHelper_SetEnabled_17(GetCppThis(), (byte)(enabled ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRControlsHelper_SetRenderer_18(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public virtual void SetRenderer(vtkRenderer ren)
	{
		vtkVRControlsHelper_SetRenderer_18(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRControlsHelper_SetText_19(HandleRef pThis, string str);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public void SetText(string str)
	{
		vtkVRControlsHelper_SetText_19(GetCppThis(), str);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRControlsHelper_SetTooltipInfo_20(HandleRef pThis, string s, int buttonSide, int drawSide, string txt);

	/// <summary>
	/// Set Tooltip text (used by TextActor)
	/// </summary>
	public void SetTooltipInfo(string s, int buttonSide, int drawSide, string txt)
	{
		vtkVRControlsHelper_SetTooltipInfo_20(GetCppThis(), s, buttonSide, drawSide, txt);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRControlsHelper_UpdateRepresentation_21(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkVRPanelWidget.
	/// </summary>
	public void UpdateRepresentation()
	{
		vtkVRControlsHelper_UpdateRepresentation_21(GetCppThis());
	}
}
