using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleImage
/// </summary>
/// <remarks>
///    interactive manipulation of the camera specialized for images
///
/// vtkInteractorStyleImage allows the user to interactively manipulate
/// (rotate, pan, zoom etc.) the camera. vtkInteractorStyleImage is specially
/// designed to work with images that are being rendered with
/// vtkImageActor. Several events are overloaded from its superclass
/// vtkInteractorStyle, hence the mouse bindings are different. (The bindings
/// keep the camera's view plane normal perpendicular to the x-y plane.) In
/// summary the mouse events for 2D image interaction are as follows:
/// - Left Mouse button triggers window level events
/// - CTRL Left Mouse spins the camera around its view plane normal
/// - SHIFT Left Mouse pans the camera
/// - CTRL SHIFT Left Mouse dollys (a positional zoom) the camera
/// - Middle mouse button pans the camera
/// - Right mouse button dollys the camera.
/// - SHIFT Right Mouse triggers pick events
///
/// If SetInteractionModeToImageSlicing() is called, then some of the mouse
/// events are changed as follows:
/// - CTRL Left Mouse slices through the image
/// - SHIFT Middle Mouse slices through the image
/// - CTRL Right Mouse spins the camera
///
/// If SetInteractionModeToImage3D() is called, then some of the mouse
/// events are changed as follows:
/// - SHIFT Left Mouse rotates the camera for oblique slicing
/// - SHIFT Middle Mouse slices through the image
/// - CTRL Right Mouse also slices through the image
///
/// In all modes, the following key bindings are in effect:
/// - R Reset the Window/Level
/// - X Reset to a sagittal view
/// - Y Reset to a coronal view
/// - Z Reset to an axial view
///
/// Note that the renderer's actors are not moved; instead the camera is moved.
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorStyle vtkInteractorStyleTrackballActor
/// vtkInteractorStyleJoystickCamera vtkInteractorStyleJoystickActor
/// </seealso>
public class vtkInteractorStyleImage : vtkInteractorStyleTrackballCamera
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleImage";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleImage()
	{
		MRClassNameKey = "class vtkInteractorStyleImage";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleImage"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleImage New()
	{
		vtkInteractorStyleImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleImage()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkInteractorStyleImage_EndPick_01(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void EndPick()
	{
		vtkInteractorStyleImage_EndPick_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_EndSlice_02(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void EndSlice()
	{
		vtkInteractorStyleImage_EndSlice_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_EndWindowLevel_03(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void EndWindowLevel()
	{
		vtkInteractorStyleImage_EndWindowLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleImage_GetCurrentImageNumber_04(HandleRef pThis);

	/// <summary>
	/// Set the image to use for WindowLevel interaction.
	/// Any images for which the Pickable flag is off are ignored.
	/// Images are counted back-to-front, so 0 is the rearmost image.
	/// Negative values can be used to count front-to-back, so -1 is
	/// the frontmost image, -2 is the image behind that one, etc.
	/// The default is to use the frontmost image for interaction.
	/// If the specified image does not exist, then no WindowLevel
	/// interaction will take place.
	/// </summary>
	public int GetCurrentImageNumber()
	{
		return vtkInteractorStyleImage_GetCurrentImageNumber_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetCurrentImageProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the current image property, which is set when StartWindowLevel
	/// is called immediately before StartWindowLevelEvent is generated.
	/// This is the image property of the topmost vtkImageSlice in the
	/// renderer or nullptr if no image actors are present.
	/// </summary>
	public vtkImageProperty GetCurrentImageProperty()
	{
		vtkImageProperty vtkImageProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleImage_GetCurrentImageProperty_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageProperty2 = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageProperty2.Register(null);
			}
		}
		return vtkImageProperty2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleImage_GetInteractionMode_06(HandleRef pThis);

	/// <summary>
	/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
	/// it is possible to rotate the camera to view oblique slices.  In Slicing
	/// mode, it is possible to slice through the data, but not to generate oblique
	/// views by rotating the camera.
	/// </summary>
	public virtual int GetInteractionMode()
	{
		return vtkInteractorStyleImage_GetInteractionMode_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleImage_GetInteractionModeMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
	/// it is possible to rotate the camera to view oblique slices.  In Slicing
	/// mode, it is possible to slice through the data, but not to generate oblique
	/// views by rotating the camera.
	/// </summary>
	public virtual int GetInteractionModeMaxValue()
	{
		return vtkInteractorStyleImage_GetInteractionModeMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleImage_GetInteractionModeMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
	/// it is possible to rotate the camera to view oblique slices.  In Slicing
	/// mode, it is possible to slice through the data, but not to generate oblique
	/// views by rotating the camera.
	/// </summary>
	public virtual int GetInteractionModeMinValue()
	{
		return vtkInteractorStyleImage_GetInteractionModeMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleImage_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleImage_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleImage_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleImage_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetWindowLevelCurrentPosition_11(HandleRef pThis);

	/// <summary>
	/// Some useful information for handling window level
	/// </summary>
	public virtual int[] GetWindowLevelCurrentPosition()
	{
		IntPtr intPtr = vtkInteractorStyleImage_GetWindowLevelCurrentPosition_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetWindowLevelCurrentPosition_12(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Some useful information for handling window level
	/// </summary>
	public virtual void GetWindowLevelCurrentPosition(ref int _arg1, ref int _arg2)
	{
		vtkInteractorStyleImage_GetWindowLevelCurrentPosition_12(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetWindowLevelCurrentPosition_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Some useful information for handling window level
	/// </summary>
	public virtual void GetWindowLevelCurrentPosition(IntPtr _arg)
	{
		vtkInteractorStyleImage_GetWindowLevelCurrentPosition_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetWindowLevelStartPosition_14(HandleRef pThis);

	/// <summary>
	/// Some useful information for handling window level
	/// </summary>
	public virtual int[] GetWindowLevelStartPosition()
	{
		IntPtr intPtr = vtkInteractorStyleImage_GetWindowLevelStartPosition_14(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetWindowLevelStartPosition_15(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Some useful information for handling window level
	/// </summary>
	public virtual void GetWindowLevelStartPosition(ref int _arg1, ref int _arg2)
	{
		vtkInteractorStyleImage_GetWindowLevelStartPosition_15(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetWindowLevelStartPosition_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Some useful information for handling window level
	/// </summary>
	public virtual void GetWindowLevelStartPosition(IntPtr _arg)
	{
		vtkInteractorStyleImage_GetWindowLevelStartPosition_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetXViewRightVector_17(HandleRef pThis);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual double[] GetXViewRightVector()
	{
		IntPtr intPtr = vtkInteractorStyleImage_GetXViewRightVector_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetXViewRightVector_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetXViewRightVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkInteractorStyleImage_GetXViewRightVector_18(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetXViewRightVector_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetXViewRightVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_GetXViewRightVector_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetXViewUpVector_20(HandleRef pThis);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual double[] GetXViewUpVector()
	{
		IntPtr intPtr = vtkInteractorStyleImage_GetXViewUpVector_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetXViewUpVector_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetXViewUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkInteractorStyleImage_GetXViewUpVector_21(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetXViewUpVector_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetXViewUpVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_GetXViewUpVector_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetYViewRightVector_23(HandleRef pThis);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual double[] GetYViewRightVector()
	{
		IntPtr intPtr = vtkInteractorStyleImage_GetYViewRightVector_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetYViewRightVector_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetYViewRightVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkInteractorStyleImage_GetYViewRightVector_24(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetYViewRightVector_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetYViewRightVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_GetYViewRightVector_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetYViewUpVector_26(HandleRef pThis);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual double[] GetYViewUpVector()
	{
		IntPtr intPtr = vtkInteractorStyleImage_GetYViewUpVector_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetYViewUpVector_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetYViewUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkInteractorStyleImage_GetYViewUpVector_27(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetYViewUpVector_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetYViewUpVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_GetYViewUpVector_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetZViewRightVector_29(HandleRef pThis);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual double[] GetZViewRightVector()
	{
		IntPtr intPtr = vtkInteractorStyleImage_GetZViewRightVector_29(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetZViewRightVector_30(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetZViewRightVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkInteractorStyleImage_GetZViewRightVector_30(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetZViewRightVector_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetZViewRightVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_GetZViewRightVector_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_GetZViewUpVector_32(HandleRef pThis);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual double[] GetZViewUpVector()
	{
		IntPtr intPtr = vtkInteractorStyleImage_GetZViewUpVector_32(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetZViewUpVector_33(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetZViewUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkInteractorStyleImage_GetZViewUpVector_33(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_GetZViewUpVector_34(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void GetZViewUpVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_GetZViewUpVector_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleImage_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleImage_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleImage_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleImage_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleImage NewInstance()
	{
		vtkInteractorStyleImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleImage_NewInstance_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_OnChar_39(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public override void OnChar()
	{
		vtkInteractorStyleImage_OnChar_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_OnLeftButtonDown_40(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleImage_OnLeftButtonDown_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_OnLeftButtonUp_41(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleImage_OnLeftButtonUp_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_OnMiddleButtonDown_42(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleImage_OnMiddleButtonDown_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_OnMiddleButtonUp_43(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleImage_OnMiddleButtonUp_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_OnMouseMove_44(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleImage_OnMouseMove_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_OnRightButtonDown_45(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleImage_OnRightButtonDown_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_OnRightButtonUp_46(HandleRef pThis);

	/// <summary>
	/// Event bindings controlling the effects of pressing mouse buttons
	/// or moving the mouse.
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleImage_OnRightButtonUp_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_Pick_47(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void Pick()
	{
		vtkInteractorStyleImage_Pick_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleImage_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleImage SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleImage vtkInteractorStyleImage2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleImage_SafeDownCast_48(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleImage2 = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleImage2.Register(null);
			}
		}
		return vtkInteractorStyleImage2;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetCurrentImageNumber_49(HandleRef pThis, int i);

	/// <summary>
	/// Set the image to use for WindowLevel interaction.
	/// Any images for which the Pickable flag is off are ignored.
	/// Images are counted back-to-front, so 0 is the rearmost image.
	/// Negative values can be used to count front-to-back, so -1 is
	/// the frontmost image, -2 is the image behind that one, etc.
	/// The default is to use the frontmost image for interaction.
	/// If the specified image does not exist, then no WindowLevel
	/// interaction will take place.
	/// </summary>
	public virtual void SetCurrentImageNumber(int i)
	{
		vtkInteractorStyleImage_SetCurrentImageNumber_49(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetImageOrientation_50(HandleRef pThis, IntPtr leftToRight, IntPtr bottomToTop);

	/// <summary>
	/// Set the view orientation, in terms of the horizontal and
	/// vertical directions of the computer screen.  The first
	/// vector gives the direction that will correspond to moving
	/// horizontally left-to-right across the screen, and the
	/// second vector gives the direction that will correspond to
	/// moving bottom-to-top up the screen.  This method changes
	/// the position of the camera to provide the desired view.
	/// </summary>
	public void SetImageOrientation(IntPtr leftToRight, IntPtr bottomToTop)
	{
		vtkInteractorStyleImage_SetImageOrientation_50(GetCppThis(), leftToRight, bottomToTop);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetInteractionMode_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
	/// it is possible to rotate the camera to view oblique slices.  In Slicing
	/// mode, it is possible to slice through the data, but not to generate oblique
	/// views by rotating the camera.
	/// </summary>
	public virtual void SetInteractionMode(int _arg)
	{
		vtkInteractorStyleImage_SetInteractionMode_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetInteractionModeToImage2D_52(HandleRef pThis);

	/// <summary>
	/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
	/// it is possible to rotate the camera to view oblique slices.  In Slicing
	/// mode, it is possible to slice through the data, but not to generate oblique
	/// views by rotating the camera.
	/// </summary>
	public void SetInteractionModeToImage2D()
	{
		vtkInteractorStyleImage_SetInteractionModeToImage2D_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetInteractionModeToImage3D_53(HandleRef pThis);

	/// <summary>
	/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
	/// it is possible to rotate the camera to view oblique slices.  In Slicing
	/// mode, it is possible to slice through the data, but not to generate oblique
	/// views by rotating the camera.
	/// </summary>
	public void SetInteractionModeToImage3D()
	{
		vtkInteractorStyleImage_SetInteractionModeToImage3D_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetInteractionModeToImageSlicing_54(HandleRef pThis);

	/// <summary>
	/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
	/// it is possible to rotate the camera to view oblique slices.  In Slicing
	/// mode, it is possible to slice through the data, but not to generate oblique
	/// views by rotating the camera.
	/// </summary>
	public void SetInteractionModeToImageSlicing()
	{
		vtkInteractorStyleImage_SetInteractionModeToImageSlicing_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetXViewRightVector_55(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetXViewRightVector(double _arg1, double _arg2, double _arg3)
	{
		vtkInteractorStyleImage_SetXViewRightVector_55(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetXViewRightVector_56(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetXViewRightVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_SetXViewRightVector_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetXViewUpVector_57(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetXViewUpVector(double _arg1, double _arg2, double _arg3)
	{
		vtkInteractorStyleImage_SetXViewUpVector_57(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetXViewUpVector_58(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetXViewUpVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_SetXViewUpVector_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetYViewRightVector_59(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetYViewRightVector(double _arg1, double _arg2, double _arg3)
	{
		vtkInteractorStyleImage_SetYViewRightVector_59(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetYViewRightVector_60(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetYViewRightVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_SetYViewRightVector_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetYViewUpVector_61(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetYViewUpVector(double _arg1, double _arg2, double _arg3)
	{
		vtkInteractorStyleImage_SetYViewUpVector_61(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetYViewUpVector_62(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetYViewUpVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_SetYViewUpVector_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetZViewRightVector_63(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetZViewRightVector(double _arg1, double _arg2, double _arg3)
	{
		vtkInteractorStyleImage_SetZViewRightVector_63(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetZViewRightVector_64(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetZViewRightVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_SetZViewRightVector_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetZViewUpVector_65(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetZViewUpVector(double _arg1, double _arg2, double _arg3)
	{
		vtkInteractorStyleImage_SetZViewUpVector_65(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_SetZViewUpVector_66(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the orientations that will be used when the X, Y, or Z
	/// keys are pressed.  See SetImageOrientation for more information.
	/// </summary>
	public virtual void SetZViewUpVector(IntPtr _arg)
	{
		vtkInteractorStyleImage_SetZViewUpVector_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_Slice_67(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void Slice()
	{
		vtkInteractorStyleImage_Slice_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_StartPick_68(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void StartPick()
	{
		vtkInteractorStyleImage_StartPick_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_StartSlice_69(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void StartSlice()
	{
		vtkInteractorStyleImage_StartSlice_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_StartWindowLevel_70(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void StartWindowLevel()
	{
		vtkInteractorStyleImage_StartWindowLevel_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleImage_WindowLevel_71(HandleRef pThis);

	/// <summary>
	/// Override the "fly-to" (f keypress) for images.
	/// </summary>
	public virtual void WindowLevel()
	{
		vtkInteractorStyleImage_WindowLevel_71(GetCppThis());
	}
}
