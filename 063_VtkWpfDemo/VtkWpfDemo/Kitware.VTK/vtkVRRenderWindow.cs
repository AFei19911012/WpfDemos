using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRRenderWindow
/// </summary>
/// <remarks>
///    VR rendering window
///
///
/// vtkVRRenderWindow is a abstract class to define a RenderWindow in a
/// VR context.
///
/// VR provides HMD and controller positions in the "Physical" coordinate
/// system. For room scale VR this is based on the room setup
/// per the underlying VR API being used. Units are in meters.
///
/// Renderer shows actors in the World coordinate system. Transformation between
/// Physical and World coordinate systems is defined by PhysicalToWorldMatrix.
/// This matrix determines the user's position and orientation in the rendered
/// scene and scaling (magnification) of rendered actors.
///
/// This class introduces the notion of DeviceHandles. A DeviceHandle is
/// a uint32_t handle that represents a device in the underlying VR API
/// such as OpenVR or OpenXR. Implementations of this class are responsible
/// for mapping the actual devices from that API into unique DeviceHandles.
/// Typically these devices are handheld controllers, HMDs, stylus etc.
/// The subclass should call AddDeviceHandle when it first sees a new device.
///
/// This class also uses the term Device from vtkEventDataDevice to represent
/// a generic device type that is used in the event handling system. Multiple
/// DeviceHandles could point to the same Device though most often there is a
/// one to one mapping. For example vtkEventDataDevice::LeftController will
/// typically have one or zero DeviceHandles that map to it.
///
/// Most event processing works with generic devices and this class provides a
/// number of methods to support that. This class also provides a number of methods
/// that work on DeviceHandles which are typically used by VR classes and their
/// subclasses.
/// </remarks>
public abstract class vtkVRRenderWindow : vtkOpenGLRenderWindow
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum PhysicalToWorldMatrixModified_WrapperEnum
	{
		/// <summary>enum member</summary>
		PhysicalToWorldMatrixModified = 1200
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum LeftEye_WrapperEnum
	{
		/// <summary>enum member</summary>
		LeftEye,
		/// <summary>enum member</summary>
		RightEye
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRRenderWindow()
	{
		MRClassNameKey = "class vtkVRRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkVRRenderWindow_AddDeviceHandle_01(HandleRef pThis, uint handle);

	/// <summary>
	/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
	/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
	/// device in physical coordinates.
	/// </summary>
	public void AddDeviceHandle(uint handle)
	{
		vtkVRRenderWindow_AddDeviceHandle_01(GetCppThis(), handle);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_AddDeviceHandle_02(HandleRef pThis, uint handle, vtkEventDataDevice device);

	/// <summary>
	/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
	/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
	/// device in physical coordinates.
	/// </summary>
	public void AddDeviceHandle(uint handle, vtkEventDataDevice device)
	{
		vtkVRRenderWindow_AddDeviceHandle_02(GetCppThis(), handle, device);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_AddRenderer_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a renderer to the list of renderers.
	/// </summary>
	public override void AddRenderer(vtkRenderer arg0)
	{
		vtkVRRenderWindow_AddRenderer_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_BaseStationVisibilityOff_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the visibility of the base stations. Defaults to false
	/// </summary>
	public virtual void BaseStationVisibilityOff()
	{
		vtkVRRenderWindow_BaseStationVisibilityOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_BaseStationVisibilityOn_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the visibility of the base stations. Defaults to false
	/// </summary>
	public virtual void BaseStationVisibilityOn()
	{
		vtkVRRenderWindow_BaseStationVisibilityOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_Finalize_06(HandleRef pThis);

	/// <summary>
	/// Finalize the rendering window.  This will shutdown all system-specific
	/// resources. After having called this, it should be possible to destroy
	/// a window that was used for a SetWindowId() call without any ill effects.
	/// </summary>
	public override void FinalizeWrapper()
	{
		vtkVRRenderWindow_Finalize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRRenderWindow_GetBaseStationVisibility_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the visibility of the base stations. Defaults to false
	/// </summary>
	public virtual bool GetBaseStationVisibility()
	{
		return (vtkVRRenderWindow_GetBaseStationVisibility_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkEventDataDevice vtkVRRenderWindow_GetDeviceForDeviceHandle_08(HandleRef pThis, uint handle);

	/// <summary>
	/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
	/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
	/// device in physical coordinates.
	/// </summary>
	public vtkEventDataDevice GetDeviceForDeviceHandle(uint handle)
	{
		return vtkVRRenderWindow_GetDeviceForDeviceHandle_08(GetCppThis(), handle);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVRRenderWindow_GetDeviceHandleForDevice_09(HandleRef pThis, vtkEventDataDevice dev, uint index);

	/// <summary>
	/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
	/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
	/// device in physical coordinates.
	/// </summary>
	public uint GetDeviceHandleForDevice(vtkEventDataDevice dev, uint index)
	{
		return vtkVRRenderWindow_GetDeviceHandleForDevice_09(GetCppThis(), dev, index);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetDeviceToPhysicalMatrixForDevice_10(HandleRef pThis, vtkEventDataDevice idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
	/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
	/// device in physical coordinates.
	/// </summary>
	public vtkMatrix4x4 GetDeviceToPhysicalMatrixForDevice(vtkEventDataDevice idx)
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindow_GetDeviceToPhysicalMatrixForDevice_10(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetDeviceToPhysicalMatrixForDeviceHandle_11(HandleRef pThis, uint handle, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
	/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
	/// device in physical coordinates.
	/// </summary>
	public vtkMatrix4x4 GetDeviceToPhysicalMatrixForDeviceHandle(uint handle)
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindow_GetDeviceToPhysicalMatrixForDeviceHandle_11(GetCppThis(), handle, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRRenderWindow_GetDeviceToWorldMatrixForDevice_12(HandleRef pThis, vtkEventDataDevice device, HandleRef deviceToWorldMatrix);

	/// <summary>
	/// Store in \p deviceToWorldMatrix the matrix that goes from device coordinates
	/// to world coordinates. e.g. if you push 0,0,0,1 through this matrix you will get
	/// the location of the device in world coordinates.
	/// Return true if the query is valid, else false.
	/// </summary>
	public override bool GetDeviceToWorldMatrixForDevice(vtkEventDataDevice device, vtkMatrix4x4 deviceToWorldMatrix)
	{
		return (vtkVRRenderWindow_GetDeviceToWorldMatrixForDevice_12(GetCppThis(), device, deviceToWorldMatrix?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRRenderWindow_GetDeviceToWorldMatrixForDeviceHandle_13(HandleRef pThis, uint handle, HandleRef deviceToWorldMatrix);

	/// <summary>
	/// Store in \p deviceToWorldMatrix the matrix that goes from device coordinates
	/// to world coordinates. e.g. if you push 0,0,0,1 through this matrix you will get
	/// the location of the device in world coordinates.
	/// Return true if the query is valid, else false.
	/// </summary>
	public virtual bool GetDeviceToWorldMatrixForDeviceHandle(uint handle, vtkMatrix4x4 deviceToWorldMatrix)
	{
		return (vtkVRRenderWindow_GetDeviceToWorldMatrixForDeviceHandle_13(GetCppThis(), handle, deviceToWorldMatrix?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderWindow_GetEventPending_14(HandleRef pThis);

	/// <summary>
	/// Check to see if a mouse button has been pressed or mouse wheel activated.
	/// All other events are ignored by this method.
	/// Maybe should return 1 always?
	/// </summary>
	public override int GetEventPending()
	{
		return vtkVRRenderWindow_GetEventPending_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetGenericContext_15(HandleRef pThis);

	/// <summary>
	/// Implement required virtual functions.
	/// </summary>
	public override IntPtr GetGenericContext()
	{
		return vtkVRRenderWindow_GetGenericContext_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetGenericDisplayId_16(HandleRef pThis);

	/// <summary>
	/// Implement required virtual functions.
	/// </summary>
	public override IntPtr GetGenericDisplayId()
	{
		return vtkVRRenderWindow_GetGenericDisplayId_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetGenericDrawable_17(HandleRef pThis);

	/// <summary>
	/// Implement required virtual functions.
	/// </summary>
	public override IntPtr GetGenericDrawable()
	{
		return vtkVRRenderWindow_GetGenericDrawable_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetGenericParentId_18(HandleRef pThis);

	/// <summary>
	/// Implement required virtual functions.
	/// </summary>
	public override IntPtr GetGenericParentId()
	{
		return vtkVRRenderWindow_GetGenericParentId_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetGenericWindowId_19(HandleRef pThis);

	/// <summary>
	/// Implement required virtual functions.
	/// </summary>
	public override IntPtr GetGenericWindowId()
	{
		return vtkVRRenderWindow_GetGenericWindowId_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetHelperWindow_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the window to use for the openGL context
	/// </summary>
	public virtual vtkOpenGLRenderWindow GetHelperWindow()
	{
		vtkOpenGLRenderWindow vtkOpenGLRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindow_GetHelperWindow_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLRenderWindow2 = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLRenderWindow2.Register(null);
			}
		}
		return vtkOpenGLRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRRenderWindow_GetInitialized_21(HandleRef pThis);

	/// <summary>
	/// Get whether the window has been initialized successfully.
	/// </summary>
	public virtual bool GetInitialized()
	{
		return (vtkVRRenderWindow_GetInitialized_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVRRenderWindow_GetLeftResolveBufferId_22(HandleRef pThis);

	/// <summary>
	/// Get the frame buffers used for rendering
	/// </summary>
	public uint GetLeftResolveBufferId()
	{
		return vtkVRRenderWindow_GetLeftResolveBufferId_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetModelForDevice_23(HandleRef pThis, vtkEventDataDevice idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the VRModel corresponding to the device or device handle.
	/// </summary>
	public vtkVRModel GetModelForDevice(vtkEventDataDevice idx)
	{
		vtkVRModel vtkVRModel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindow_GetModelForDevice_23(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRModel2 = (vtkVRModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRModel2.Register(null);
			}
		}
		return vtkVRModel2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetModelForDeviceHandle_24(HandleRef pThis, uint handle, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the VRModel corresponding to the device or device handle.
	/// </summary>
	public vtkVRModel GetModelForDeviceHandle(uint handle)
	{
		vtkVRModel vtkVRModel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindow_GetModelForDeviceHandle_24(GetCppThis(), handle, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRModel2 = (vtkVRModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRModel2.Register(null);
			}
		}
		return vtkVRModel2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVRRenderWindow_GetNumberOfDeviceHandlesForDevice_25(HandleRef pThis, vtkEventDataDevice dev);

	/// <summary>
	/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
	/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
	/// device in physical coordinates.
	/// </summary>
	public uint GetNumberOfDeviceHandlesForDevice(vtkEventDataDevice dev)
	{
		return vtkVRRenderWindow_GetNumberOfDeviceHandlesForDevice_25(GetCppThis(), dev);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRRenderWindow_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRRenderWindow_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRRenderWindow_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRRenderWindow_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVRRenderWindow_GetPhysicalScale_28(HandleRef pThis);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// Ratio of distance in world coordinate and physical and system
	/// (PhysicalScale = distance_World / distance_Physical).
	/// Example: if world coordinate system is in mm then
	/// PhysicalScale = 1000.0 makes objects appear in real size.
	/// PhysicalScale = 100.0 makes objects appear 10x larger than real size.
	/// </summary>
	public virtual double GetPhysicalScale()
	{
		return vtkVRRenderWindow_GetPhysicalScale_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_GetPhysicalToWorldMatrix_29(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Get physical to world transform matrix. Members used to calculate the matrix:
	/// \sa PhysicalViewDirection, \sa PhysicalViewUp, \sa PhysicalTranslation, \sa PhysicalScale
	/// </summary>
	public override void GetPhysicalToWorldMatrix(vtkMatrix4x4 matrix)
	{
		vtkVRRenderWindow_GetPhysicalToWorldMatrix_29(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetPhysicalTranslation_30(HandleRef pThis);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// Position of the physical coordinate system origin
	/// in world coordinates.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual double[] GetPhysicalTranslation()
	{
		IntPtr intPtr = vtkVRRenderWindow_GetPhysicalTranslation_30(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_GetPhysicalTranslation_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// Position of the physical coordinate system origin
	/// in world coordinates.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void GetPhysicalTranslation(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVRRenderWindow_GetPhysicalTranslation_31(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_GetPhysicalTranslation_32(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// Position of the physical coordinate system origin
	/// in world coordinates.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void GetPhysicalTranslation(IntPtr _arg)
	{
		vtkVRRenderWindow_GetPhysicalTranslation_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetPhysicalViewDirection_33(HandleRef pThis);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View direction is the -Z axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual double[] GetPhysicalViewDirection()
	{
		IntPtr intPtr = vtkVRRenderWindow_GetPhysicalViewDirection_33(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_GetPhysicalViewDirection_34(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View direction is the -Z axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void GetPhysicalViewDirection(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVRRenderWindow_GetPhysicalViewDirection_34(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_GetPhysicalViewDirection_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View direction is the -Z axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void GetPhysicalViewDirection(IntPtr _arg)
	{
		vtkVRRenderWindow_GetPhysicalViewDirection_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetPhysicalViewUp_36(HandleRef pThis);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View up is the +Y axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual double[] GetPhysicalViewUp()
	{
		IntPtr intPtr = vtkVRRenderWindow_GetPhysicalViewUp_36(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_GetPhysicalViewUp_37(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View up is the +Y axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void GetPhysicalViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVRRenderWindow_GetPhysicalViewUp_37(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_GetPhysicalViewUp_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View up is the +Y axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void GetPhysicalViewUp(IntPtr _arg)
	{
		vtkVRRenderWindow_GetPhysicalViewUp_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_GetRenderBufferSize_39(HandleRef pThis, ref int width, ref int height);

	/// <summary>
	/// Get the frame buffers used for rendering
	/// </summary>
	public void GetRenderBufferSize(ref int width, ref int height)
	{
		vtkVRRenderWindow_GetRenderBufferSize_39(GetCppThis(), ref width, ref height);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkVRRenderWindow_GetRightResolveBufferId_40(HandleRef pThis);

	/// <summary>
	/// Get the frame buffers used for rendering
	/// </summary>
	public uint GetRightResolveBufferId()
	{
		return vtkVRRenderWindow_GetRightResolveBufferId_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_GetScreenSize_41(HandleRef pThis);

	/// <summary>
	/// Get the current size of the screen in pixels.
	/// </summary>
	public override int[] GetScreenSize()
	{
		IntPtr intPtr = vtkVRRenderWindow_GetScreenSize_41(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRRenderWindow_GetTrackHMD_42(HandleRef pThis);

	/// <summary>
	/// When on the camera will track the HMD position.
	/// On is the default.
	/// </summary>
	public virtual bool GetTrackHMD()
	{
		return (vtkVRRenderWindow_GetTrackHMD_42(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_Initialize_43(HandleRef pThis);

	/// <summary>
	/// Initialize the rendering window.
	/// </summary>
	public override void Initialize()
	{
		vtkVRRenderWindow_Initialize_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_InitializeViewFromCamera_44(HandleRef pThis, HandleRef cam);

	/// <summary>
	/// Initialize the HMD to World setting and camera settings so that the VR
	/// world view most closely matched the view from the provided camera. This
	/// method is useful for initializing a VR world from an existing on screen
	/// window and camera. The Renderer and its camera must already be created
	/// and set when this is called.
	/// </summary>
	public virtual void InitializeViewFromCamera(vtkCamera cam)
	{
		vtkVRRenderWindow_InitializeViewFromCamera_44(GetCppThis(), cam?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderWindow_IsA_45(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRRenderWindow_IsA_45(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVRRenderWindow_IsCurrent_46(HandleRef pThis);

	/// <summary>
	/// Tells if this window is the current OpenGL context for the calling thread.
	/// </summary>
	public override bool IsCurrent()
	{
		return (vtkVRRenderWindow_IsCurrent_46(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderWindow_IsDirect_47(HandleRef pThis);

	/// <summary>
	/// Is this render window using hardware acceleration? 0-false, 1-true
	/// </summary>
	public override int IsDirect()
	{
		return vtkVRRenderWindow_IsDirect_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderWindow_IsTypeOf_48(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRRenderWindow_IsTypeOf_48(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_MakeCurrent_49(HandleRef pThis);

	/// <summary>
	/// Make this windows OpenGL context the current context.
	/// </summary>
	public override void MakeCurrent()
	{
		vtkVRRenderWindow_MakeCurrent_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_MakeRenderWindowInteractor_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an interactor to control renderers in this window. Must be
	/// overridden to instantiate a specific interactor depending on the API
	/// </summary>
	public override vtkRenderWindowInteractor MakeRenderWindowInteractor()
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindow_MakeRenderWindowInteractor_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_NewInstance_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVRRenderWindow NewInstance()
	{
		vtkVRRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindow_NewInstance_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_ReleaseCurrent_52(HandleRef pThis);

	/// <summary>
	/// Release the current context.
	/// </summary>
	public override void ReleaseCurrent()
	{
		vtkVRRenderWindow_ReleaseCurrent_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_ReleaseGraphicsResources_53(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Free up any graphics resources associated with this window
	/// a value of nullptr means the context may already be destroyed
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkVRRenderWindow_ReleaseGraphicsResources_53(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_Render_54(HandleRef pThis);

	/// <summary>
	/// Overridden to not release resources that would interfere with an external
	/// application's rendering. Avoiding round trip.
	/// </summary>
	public override void Render()
	{
		vtkVRRenderWindow_Render_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_RenderModels_55(HandleRef pThis);

	/// <summary>
	/// Render the controller and base station models
	/// </summary>
	public virtual void RenderModels()
	{
		vtkVRRenderWindow_RenderModels_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_ReportCapabilities_56(HandleRef pThis);

	/// <summary>
	/// Get report of capabilities for the render window
	/// </summary>
	public override string ReportCapabilities()
	{
		return Marshal.PtrToStringAnsi(vtkVRRenderWindow_ReportCapabilities_56(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRRenderWindow_SafeDownCast_57(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVRRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkVRRenderWindow vtkVRRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRRenderWindow_SafeDownCast_57(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRRenderWindow2 = (vtkVRRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRRenderWindow2.Register(null);
			}
		}
		return vtkVRRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetBaseStationVisibility_58(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the visibility of the base stations. Defaults to false
	/// </summary>
	public virtual void SetBaseStationVisibility(bool _arg)
	{
		vtkVRRenderWindow_SetBaseStationVisibility_58(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetHelperWindow_59(HandleRef pThis, HandleRef val);

	/// <summary>
	/// Set/Get the window to use for the openGL context
	/// </summary>
	public void SetHelperWindow(vtkOpenGLRenderWindow val)
	{
		vtkVRRenderWindow_SetHelperWindow_59(GetCppThis(), val?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetModelForDeviceHandle_60(HandleRef pThis, uint handle, HandleRef model);

	/// <summary>
	/// Set the VRModel corresponding to the device handle
	/// </summary>
	public void SetModelForDeviceHandle(uint handle, vtkVRModel model)
	{
		vtkVRRenderWindow_SetModelForDeviceHandle_60(GetCppThis(), handle, model?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetPhysicalScale_61(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// Ratio of distance in world coordinate and physical and system
	/// (PhysicalScale = distance_World / distance_Physical).
	/// Example: if world coordinate system is in mm then
	/// PhysicalScale = 1000.0 makes objects appear in real size.
	/// PhysicalScale = 100.0 makes objects appear 10x larger than real size.
	/// </summary>
	public virtual void SetPhysicalScale(double arg0)
	{
		vtkVRRenderWindow_SetPhysicalScale_61(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetPhysicalToWorldMatrix_62(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Set physical to world transform matrix. Members calculated and set from the matrix:
	/// \sa PhysicalViewDirection, \sa PhysicalViewUp, \sa PhysicalTranslation, \sa PhysicalScale
	/// The x axis scale is used for \sa PhysicalScale
	/// </summary>
	public void SetPhysicalToWorldMatrix(vtkMatrix4x4 matrix)
	{
		vtkVRRenderWindow_SetPhysicalToWorldMatrix_62(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetPhysicalTranslation_63(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// Position of the physical coordinate system origin
	/// in world coordinates.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void SetPhysicalTranslation(double arg0, double arg1, double arg2)
	{
		vtkVRRenderWindow_SetPhysicalTranslation_63(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetPhysicalTranslation_64(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// Position of the physical coordinate system origin
	/// in world coordinates.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void SetPhysicalTranslation(IntPtr arg0)
	{
		vtkVRRenderWindow_SetPhysicalTranslation_64(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetPhysicalViewDirection_65(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View direction is the -Z axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void SetPhysicalViewDirection(double arg0, double arg1, double arg2)
	{
		vtkVRRenderWindow_SetPhysicalViewDirection_65(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetPhysicalViewDirection_66(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View direction is the -Z axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void SetPhysicalViewDirection(IntPtr arg0)
	{
		vtkVRRenderWindow_SetPhysicalViewDirection_66(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetPhysicalViewUp_67(HandleRef pThis, double arg0, double arg1, double arg2);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View up is the +Y axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void SetPhysicalViewUp(double arg0, double arg1, double arg2)
	{
		vtkVRRenderWindow_SetPhysicalViewUp_67(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetPhysicalViewUp_68(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set/get physical coordinate system in world coordinate system.
	///
	/// View up is the +Y axis of the physical coordinate system
	/// in world coordinate system.
	/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
	/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
	/// </summary>
	public virtual void SetPhysicalViewUp(IntPtr arg0)
	{
		vtkVRRenderWindow_SetPhysicalViewUp_68(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetSize_69(HandleRef pThis, int width, int height);

	/// <summary>
	/// Set the size of the window in screen coordinates in pixels.
	/// This resizes the operating system's window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public override void SetSize(int width, int height)
	{
		vtkVRRenderWindow_SetSize_69(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetSize_70(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the size of the window in screen coordinates in pixels.
	/// This resizes the operating system's window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public override void SetSize(IntPtr a)
	{
		vtkVRRenderWindow_SetSize_70(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_SetTrackHMD_71(HandleRef pThis, byte _arg);

	/// <summary>
	/// When on the camera will track the HMD position.
	/// On is the default.
	/// </summary>
	public virtual void SetTrackHMD(bool _arg)
	{
		vtkVRRenderWindow_SetTrackHMD_71(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_Start_72(HandleRef pThis);

	/// <summary>
	/// Begin the rendering process.
	/// </summary>
	public override void Start()
	{
		vtkVRRenderWindow_Start_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRRenderWindow_SupportsOpenGL_73(HandleRef pThis);

	/// <summary>
	/// Does this render window support OpenGL? 0-false, 1-true
	/// </summary>
	public override int SupportsOpenGL()
	{
		return vtkVRRenderWindow_SupportsOpenGL_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRRenderWindow_UpdateHMDMatrixPose_74(HandleRef pThis);

	/// <summary>
	/// Update the HMD pose.
	/// </summary>
	public virtual void UpdateHMDMatrixPose()
	{
		vtkVRRenderWindow_UpdateHMDMatrixPose_74(GetCppThis());
	}
}
