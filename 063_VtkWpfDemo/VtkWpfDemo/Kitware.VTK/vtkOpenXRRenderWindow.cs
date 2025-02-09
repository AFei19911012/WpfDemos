using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenXRRenderWindow
/// </summary>
/// <remarks>
///    OpenXR rendering window
///
///
/// vtkOpenXRRenderWindow is a concrete implementation of the abstract
/// class vtkRenderWindow.
///
/// This class and its similar classes are designed to be drop in
/// replacements for VTK. If you link to this module and turn on
/// the CMake option VTK_OPENXR_OBJECT_FACTORY, the object
/// factory mechanism should replace the core rendering classes such as
/// RenderWindow with OpenXR specialized versions. The goal is for VTK
/// programs to be able to use the OpenXR library with little to no
/// changes.
///
/// This class handles the bulk of interfacing to OpenXR. It supports one
/// renderer currently. The renderer is assumed to cover the entire window
/// which is what makes sense to VR. Overlay renderers can probably be
/// made to work with this but consider how overlays will appear in a
/// HMD if they do not track the viewpoint etc.
///
/// OpenXR provides HMD and controller positions in "Physical" coordinate
/// system.
/// Origin: user's eye position at the time of calibration.
/// Axis directions: x = user's right; y = user's up; z = user's back.
/// Unit: meter.
///
/// Renderer shows actors in World coordinate system. Transformation between
/// Physical and World coordinate systems is defined by PhysicalToWorldMatrix.
/// This matrix determines the user's position and orientation in the rendered
/// scene and scaling (magnification) of rendered actors.
///
/// </remarks>
public class vtkOpenXRRenderWindow : vtkVRRenderWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenXRRenderWindow()
	{
		MRClassNameKey = "class vtkOpenXRRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenXRRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenXRRenderWindow New()
	{
		vtkOpenXRRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenXRRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenXRRenderWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenXRRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_AddRenderer_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a renderer to the list of renderers.
	/// </summary>
	public override void AddRenderer(vtkRenderer arg0)
	{
		vtkOpenXRRenderWindow_AddRenderer_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_Finalize_02(HandleRef pThis);

	/// <summary>
	/// Finalize the rendering window.  This will shutdown all system-specific
	/// resources.  After having called this, it should be possible to destroy
	/// a window that was used for a SetWindowId() call without any ill effects.
	/// </summary>
	public override void FinalizeWrapper()
	{
		vtkOpenXRRenderWindow_Finalize_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkEventDataDevice vtkOpenXRRenderWindow_GetDeviceForOpenXRHandle_03(HandleRef pThis, uint ohandle);

	/// <summary>
	/// Set the active state (active: true / inactive: false) of the specified hand.
	/// </summary>
	public vtkEventDataDevice GetDeviceForOpenXRHandle(uint ohandle)
	{
		return vtkOpenXRRenderWindow_GetDeviceForOpenXRHandle_03(GetCppThis(), ohandle);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkOpenXRRenderWindow_GetDeviceHandleForOpenXRHandle_04(HandleRef pThis, uint index);

	/// <summary>
	/// Set the active state (active: true / inactive: false) of the specified hand.
	/// </summary>
	public uint GetDeviceHandleForOpenXRHandle(uint index)
	{
		return vtkOpenXRRenderWindow_GetDeviceHandleForOpenXRHandle_04(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenXRRenderWindow_GetEventPending_05(HandleRef pThis);

	/// <summary>
	/// Check to see if a mouse button has been pressed or mouse wheel activated.
	/// All other events are ignored by this method.
	/// Maybe should return 1 always?
	/// </summary>
	public override int GetEventPending()
	{
		return vtkOpenXRRenderWindow_GetEventPending_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenXRRenderWindow_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenXRRenderWindow_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenXRRenderWindow_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenXRRenderWindow_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenXRRenderWindow_GetSizeFromAPI_08(HandleRef pThis);

	/// <summary>
	/// Get size of render window from OpenXR.
	/// </summary>
	public virtual bool GetSizeFromAPI()
	{
		return (vtkOpenXRRenderWindow_GetSizeFromAPI_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_Initialize_09(HandleRef pThis);

	/// <summary>
	/// Initialize the rendering window.  This will setup all system-specific
	/// resources.  This method and Finalize() must be symmetric and it
	/// should be possible to call them multiple times, even changing WindowId
	/// in-between.  This is what WindowRemap does.
	/// </summary>
	public override void Initialize()
	{
		vtkOpenXRRenderWindow_Initialize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenXRRenderWindow_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenXRRenderWindow_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenXRRenderWindow_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenXRRenderWindow_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRenderWindow_MakeRenderWindowInteractor_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an interactor to control renderers in this window.
	/// </summary>
	public override vtkRenderWindowInteractor MakeRenderWindowInteractor()
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRenderWindow_MakeRenderWindowInteractor_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindowInteractor2 = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindowInteractor2.Register(null);
			}
		}
		return vtkRenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRenderWindow_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenXRRenderWindow NewInstance()
	{
		vtkOpenXRRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRenderWindow_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenXRRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_Render_15(HandleRef pThis);

	/// <summary>
	/// Overridden to not release resources that would interfere with an external
	/// application's rendering. Avoiding round trip.
	/// </summary>
	public override void Render()
	{
		vtkOpenXRRenderWindow_Render_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRenderWindow_ReportCapabilities_16(HandleRef pThis);

	/// <summary>
	/// Get report of capabilities for the render window
	/// </summary>
	public override string ReportCapabilities()
	{
		return Marshal.PtrToStringAnsi(vtkOpenXRRenderWindow_ReportCapabilities_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenXRRenderWindow_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenXRRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkOpenXRRenderWindow vtkOpenXRRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenXRRenderWindow_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenXRRenderWindow2 = (vtkOpenXRRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenXRRenderWindow2.Register(null);
			}
		}
		return vtkOpenXRRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_SetModelActiveState_18(HandleRef pThis, int hand, byte state);

	/// <summary>
	/// Set the active state (active: true / inactive: false) of the specified hand.
	/// </summary>
	public void SetModelActiveState(int hand, bool state)
	{
		vtkOpenXRRenderWindow_SetModelActiveState_18(GetCppThis(), hand, (byte)(state ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_StereoMidpoint_19(HandleRef pThis);

	/// <summary>
	/// Intermediate method performs operations required between the rendering
	/// of the left and right eye.
	/// </summary>
	public override void StereoMidpoint()
	{
		vtkOpenXRRenderWindow_StereoMidpoint_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_StereoRenderComplete_20(HandleRef pThis);

	/// <summary>
	/// Handles work required once both views have been rendered when using
	/// stereo rendering.
	/// </summary>
	public override void StereoRenderComplete()
	{
		vtkOpenXRRenderWindow_StereoRenderComplete_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_StereoUpdate_21(HandleRef pThis);

	/// <summary>
	/// Update the system, if needed, due to stereo rendering. For some stereo
	/// methods, subclasses might need to switch some hardware settings here.
	/// </summary>
	public override void StereoUpdate()
	{
		vtkOpenXRRenderWindow_StereoUpdate_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenXRRenderWindow_UpdateHMDMatrixPose_22(HandleRef pThis);

	/// <summary>
	/// Update the HMD pose based on hardware pose and physical to world transform.
	/// VR camera properties are directly modified based on physical to world to
	/// simulate \sa PhysicalTranslation, \sa PhysicalScale, etc.
	/// </summary>
	public override void UpdateHMDMatrixPose()
	{
		vtkOpenXRRenderWindow_UpdateHMDMatrixPose_22(GetCppThis());
	}
}
