using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderWindowInteractor3D
/// </summary>
/// <remarks>
///    adds support for 3D events to vtkRenderWindowInteractor.
///
///
/// vtkRenderWindowInteractor3D provides a platform-independent interaction
/// support for 3D events including 3D clicks and 3D controller
/// orientations. It follows the same basic model as
/// vtkRenderWindowInteractor but adds methods to set and get 3D event
/// locations and orientations. VR systems will subclass this class to
/// provide the code to set these values based on events from their VR
/// controllers.
/// </remarks>
public class vtkRenderWindowInteractor3D : vtkRenderWindowInteractor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindowInteractor3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderWindowInteractor3D()
	{
		MRClassNameKey = "class vtkRenderWindowInteractor3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindowInteractor3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderWindowInteractor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new static vtkRenderWindowInteractor3D New()
	{
		vtkRenderWindowInteractor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderWindowInteractor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public vtkRenderWindowInteractor3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderWindowInteractor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_Disable_01(HandleRef pThis);

	/// <summary>
	/// Enable/Disable interactions.  By default interactors are enabled when
	/// initialized.  Initialize() must be called prior to enabling/disabling
	/// interaction. These methods are used when a window/widget is being
	/// shared by multiple renderers and interactors.  This allows a "modal"
	/// display where one interactor is active when its data is to be displayed
	/// and all other interactors associated with the widget are disabled
	/// when their data is not displayed.
	/// </summary>
	public override void Disable()
	{
		vtkRenderWindowInteractor3D_Disable_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_Enable_02(HandleRef pThis);

	/// <summary>
	/// Enable/Disable interactions.  By default interactors are enabled when
	/// initialized.  Initialize() must be called prior to enabling/disabling
	/// interaction. These methods are used when a window/widget is being
	/// shared by multiple renderers and interactors.  This allows a "modal"
	/// display where one interactor is active when its data is to be displayed
	/// and all other interactors associated with the widget are disabled
	/// when their data is not displayed.
	/// </summary>
	public override void Enable()
	{
		vtkRenderWindowInteractor3D_Enable_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetLastPhysicalEventPose_03(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

	/// <summary>
	/// With VR we know the physical/room coordinate positions
	/// and orientations of events.
	/// These methods support getting them.
	/// </summary>
	public virtual void GetLastPhysicalEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_GetLastPhysicalEventPose_03(GetCppThis(), poseMatrix?.GetCppThis() ?? default(HandleRef), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetLastTranslation3D_04(HandleRef pThis);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual double[] GetLastTranslation3D()
	{
		IntPtr intPtr = vtkRenderWindowInteractor3D_GetLastTranslation3D_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetLastTranslation3D_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual void GetLastTranslation3D(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkRenderWindowInteractor3D_GetLastTranslation3D_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetLastTranslation3D_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual void GetLastTranslation3D(IntPtr _arg)
	{
		vtkRenderWindowInteractor3D_GetLastTranslation3D_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetLastWorldEventOrientation_07(HandleRef pThis, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions and orientations of events.
	/// These methods support querying them instead of going through a display X,Y
	/// coordinate approach as is standard for mouse/touch events
	/// </summary>
	public virtual IntPtr GetLastWorldEventOrientation(int pointerIndex)
	{
		return vtkRenderWindowInteractor3D_GetLastWorldEventOrientation_07(GetCppThis(), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetLastWorldEventPose_08(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions and orientations of events.
	/// These methods support querying them instead of going through a display X,Y
	/// coordinate approach as is standard for mouse/touch events
	/// </summary>
	public virtual void GetLastWorldEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_GetLastWorldEventPose_08(GetCppThis(), poseMatrix?.GetCppThis() ?? default(HandleRef), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetLastWorldEventPosition_09(HandleRef pThis, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions and orientations of events.
	/// These methods support querying them instead of going through a display X,Y
	/// coordinate approach as is standard for mouse/touch events
	/// </summary>
	public virtual IntPtr GetLastWorldEventPosition(int pointerIndex)
	{
		return vtkRenderWindowInteractor3D_GetLastWorldEventPosition_09(GetCppThis(), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderWindowInteractor3D_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderWindowInteractor3D_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderWindowInteractor3D_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderWindowInteractor3D_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetPhysicalEventPose_12(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

	/// <summary>
	/// With VR we know the physical/room coordinate positions
	/// and orientations of events.
	/// These methods support getting them.
	/// </summary>
	public virtual void GetPhysicalEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_GetPhysicalEventPose_12(GetCppThis(), poseMatrix?.GetCppThis() ?? default(HandleRef), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindowInteractor3D_GetPhysicalScale_13(HandleRef pThis);

	/// <summary>
	/// Set/get the physical scale (world / physical distance ratio)
	/// </summary>
	public virtual double GetPhysicalScale()
	{
		return vtkRenderWindowInteractor3D_GetPhysicalScale_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetPhysicalTranslation_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get position of the physical coordinate system origin in world coordinates.
	/// </summary>
	public virtual IntPtr GetPhysicalTranslation(vtkCamera arg0)
	{
		return vtkRenderWindowInteractor3D_GetPhysicalTranslation_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetPhysicalViewDirection_15(HandleRef pThis);

	/// <summary>
	/// Set/get the direction of the physical coordinate system -Z axis in world coordinates.
	/// </summary>
	public virtual IntPtr GetPhysicalViewDirection()
	{
		return vtkRenderWindowInteractor3D_GetPhysicalViewDirection_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetPhysicalViewUp_16(HandleRef pThis);

	/// <summary>
	/// Set/get the direction of the physical coordinate system +Y axis in world coordinates.
	/// </summary>
	public virtual IntPtr GetPhysicalViewUp()
	{
		return vtkRenderWindowInteractor3D_GetPhysicalViewUp_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetStartingPhysicalEventPose_17(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

	/// <summary>
	/// With VR we know the physical/room coordinate positions
	/// and orientations of events.
	/// These methods support getting them.
	/// </summary>
	public virtual void GetStartingPhysicalEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_GetStartingPhysicalEventPose_17(GetCppThis(), poseMatrix?.GetCppThis() ?? default(HandleRef), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetTouchPadPosition_18(HandleRef pThis, vtkEventDataDevice arg0, vtkEventDataDeviceInput arg1, IntPtr arg2);

	/// <summary>
	/// Get the latest touchpad or joystick position for a device
	/// </summary>
	public virtual void GetTouchPadPosition(vtkEventDataDevice arg0, vtkEventDataDeviceInput arg1, IntPtr arg2)
	{
		vtkRenderWindowInteractor3D_GetTouchPadPosition_18(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetTranslation3D_19(HandleRef pThis);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual double[] GetTranslation3D()
	{
		IntPtr intPtr = vtkRenderWindowInteractor3D_GetTranslation3D_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetTranslation3D_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual void GetTranslation3D(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkRenderWindowInteractor3D_GetTranslation3D_20(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetTranslation3D_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public virtual void GetTranslation3D(IntPtr _arg)
	{
		vtkRenderWindowInteractor3D_GetTranslation3D_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetWorldEventOrientation_22(HandleRef pThis, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions and orientations of events.
	/// These methods support querying them instead of going through a display X,Y
	/// coordinate approach as is standard for mouse/touch events
	/// </summary>
	public virtual IntPtr GetWorldEventOrientation(int pointerIndex)
	{
		return vtkRenderWindowInteractor3D_GetWorldEventOrientation_22(GetCppThis(), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_GetWorldEventPose_23(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions and orientations of events.
	/// These methods support querying them instead of going through a display X,Y
	/// coordinate approach as is standard for mouse/touch events
	/// </summary>
	public virtual void GetWorldEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_GetWorldEventPose_23(GetCppThis(), poseMatrix?.GetCppThis() ?? default(HandleRef), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_GetWorldEventPosition_24(HandleRef pThis, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions and orientations of events.
	/// These methods support querying them instead of going through a display X,Y
	/// coordinate approach as is standard for mouse/touch events
	/// </summary>
	public virtual IntPtr GetWorldEventPosition(int pointerIndex)
	{
		return vtkRenderWindowInteractor3D_GetWorldEventPosition_24(GetCppThis(), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor3D_IsA_25(HandleRef pThis, string type);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderWindowInteractor3D_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindowInteractor3D_IsTypeOf_26(string type);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderWindowInteractor3D_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_MiddleButtonPressEvent_27(HandleRef pThis);

	/// <summary>
	/// Override to set pointers down
	/// </summary>
	public override void MiddleButtonPressEvent()
	{
		vtkRenderWindowInteractor3D_MiddleButtonPressEvent_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_MiddleButtonReleaseEvent_28(HandleRef pThis);

	/// <summary>
	/// Override to set pointers down
	/// </summary>
	public override void MiddleButtonReleaseEvent()
	{
		vtkRenderWindowInteractor3D_MiddleButtonReleaseEvent_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new vtkRenderWindowInteractor3D NewInstance()
	{
		vtkRenderWindowInteractor3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor3D_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderWindowInteractor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_RightButtonPressEvent_31(HandleRef pThis);

	/// <summary>
	/// Override to set pointers down
	/// </summary>
	public override void RightButtonPressEvent()
	{
		vtkRenderWindowInteractor3D_RightButtonPressEvent_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_RightButtonReleaseEvent_32(HandleRef pThis);

	/// <summary>
	/// Override to set pointers down
	/// </summary>
	public override void RightButtonReleaseEvent()
	{
		vtkRenderWindowInteractor3D_RightButtonReleaseEvent_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindowInteractor3D_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new static vtkRenderWindowInteractor3D SafeDownCast(vtkObjectBase o)
	{
		vtkRenderWindowInteractor3D vtkRenderWindowInteractor3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindowInteractor3D_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindowInteractor3D2 = (vtkRenderWindowInteractor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindowInteractor3D2.Register(null);
			}
		}
		return vtkRenderWindowInteractor3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetPhysicalEventPose_34(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

	/// <summary>
	/// With VR we know the physical/room coordinate positions
	/// and orientations of events.
	/// These methods support setting them.
	/// </summary>
	public virtual void SetPhysicalEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_SetPhysicalEventPose_34(GetCppThis(), poseMatrix?.GetCppThis() ?? default(HandleRef), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetPhysicalEventPosition_35(HandleRef pThis, double x, double y, double z, int pointerIndex);

	/// <summary>
	/// With VR we know the physical/room coordinate positions
	/// and orientations of events.
	/// These methods support setting them.
	/// </summary>
	public virtual void SetPhysicalEventPosition(double x, double y, double z, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_SetPhysicalEventPosition_35(GetCppThis(), x, y, z, pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetPhysicalScale_36(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/get the physical scale (world / physical distance ratio)
	/// </summary>
	public virtual void SetPhysicalScale(double arg0)
	{
		vtkRenderWindowInteractor3D_SetPhysicalScale_36(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetPhysicalTranslation_37(HandleRef pThis, HandleRef arg0, double arg1, double arg2, double arg3);

	/// <summary>
	/// Set/get position of the physical coordinate system origin in world coordinates.
	/// </summary>
	public virtual void SetPhysicalTranslation(vtkCamera arg0, double arg1, double arg2, double arg3)
	{
		vtkRenderWindowInteractor3D_SetPhysicalTranslation_37(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1, arg2, arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetPhysicalViewDirection_38(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/get the direction of the physical coordinate system -Z axis in world coordinates.
	/// </summary>
	public virtual void SetPhysicalViewDirection(double arg0, double arg1, double arg2)
	{
		vtkRenderWindowInteractor3D_SetPhysicalViewDirection_38(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetPhysicalViewUp_39(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/get the direction of the physical coordinate system +Y axis in world coordinates.
	/// </summary>
	public virtual void SetPhysicalViewUp(double arg0, double arg1, double arg2)
	{
		vtkRenderWindowInteractor3D_SetPhysicalViewUp_39(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetTranslation3D_40(HandleRef pThis, IntPtr val);

	/// <summary>
	/// Set/get the translation for pan/swipe gestures, update LastTranslation
	/// </summary>
	public void SetTranslation3D(IntPtr val)
	{
		vtkRenderWindowInteractor3D_SetTranslation3D_40(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetWorldEventOrientation_41(HandleRef pThis, double w, double x, double y, double z, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions
	/// and orientations of events. These methods
	/// support setting them.
	/// </summary>
	public virtual void SetWorldEventOrientation(double w, double x, double y, double z, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_SetWorldEventOrientation_41(GetCppThis(), w, x, y, z, pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetWorldEventPose_42(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions
	/// and orientations of events. These methods
	/// support setting them.
	/// </summary>
	public virtual void SetWorldEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_SetWorldEventPose_42(GetCppThis(), poseMatrix?.GetCppThis() ?? default(HandleRef), pointerIndex);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindowInteractor3D_SetWorldEventPosition_43(HandleRef pThis, double x, double y, double z, int pointerIndex);

	/// <summary>
	/// With VR we know the world coordinate positions
	/// and orientations of events. These methods
	/// support setting them.
	/// </summary>
	public virtual void SetWorldEventPosition(double x, double y, double z, int pointerIndex)
	{
		vtkRenderWindowInteractor3D_SetWorldEventPosition_43(GetCppThis(), x, y, z, pointerIndex);
	}
}
