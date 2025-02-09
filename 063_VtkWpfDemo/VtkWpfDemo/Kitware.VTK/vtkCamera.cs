using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCamera
/// </summary>
/// <remarks>
///    a virtual camera for 3D rendering
///
/// vtkCamera is a virtual camera for 3D rendering. It provides methods
/// to position and orient the view point and focal point. Convenience
/// methods for moving about the focal point also are provided. More
/// complex methods allow the manipulation of the computer graphics
/// model including view up vector, clipping planes, and
/// camera perspective.
/// </remarks>
/// <seealso>
///
/// vtkPerspectiveTransform
/// </seealso>
public class vtkCamera : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCamera";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCamera()
	{
		MRClassNameKey = "class vtkCamera";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCamera"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct camera instance with its focal point at the origin,
	/// and position=(0,0,1). The view up is along the y-axis,
	/// view angle is 30 degrees, and the clipping range is (.1,1000).
	/// </summary>
	public new static vtkCamera New()
	{
		vtkCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct camera instance with its focal point at the origin,
	/// and position=(0,0,1). The view up is along the y-axis,
	/// view angle is 30 degrees, and the clipping range is (.1,1000).
	/// </summary>
	public vtkCamera()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCamera_ApplyTransform_01(HandleRef pThis, HandleRef t);

	/// <summary>
	/// Apply a transform to the camera.  The camera position, focal-point,
	/// and view-up are re-calculated using the transform's matrix to
	/// multiply the old points by the new transform.
	/// </summary>
	public void ApplyTransform(vtkTransform t)
	{
		vtkCamera_ApplyTransform_01(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_Azimuth_02(HandleRef pThis, double angle);

	/// <summary>
	/// Rotate the camera about the view up vector centered at the focal point.
	/// Note that the view up vector is whatever was set via SetViewUp, and is
	/// not necessarily perpendicular to the direction of projection.  The
	/// result is a horizontal rotation of the camera.
	/// </summary>
	public void Azimuth(double angle)
	{
		vtkCamera_Azimuth_02(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_ComputeViewPlaneNormal_03(HandleRef pThis);

	/// <summary>
	/// This method is called automatically whenever necessary, it
	/// should never be used outside of vtkCamera.cxx.
	/// </summary>
	public void ComputeViewPlaneNormal()
	{
		vtkCamera_ComputeViewPlaneNormal_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_DeepCopy_04(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Copy the properties of `source' into `this'.
	/// Copy the contents of the matrices.
	/// \pre source_exists!=0
	/// \pre not_this: source!=this
	/// </summary>
	public void DeepCopy(vtkCamera source)
	{
		vtkCamera_DeepCopy_04(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_Dolly_05(HandleRef pThis, double value);

	/// <summary>
	/// Divide the camera's distance from the focal point by the given
	/// dolly value.  Use a value greater than one to dolly-in toward
	/// the focal point, and use a value less than one to dolly-out away
	/// from the focal point.
	/// </summary>
	public void Dolly(double value)
	{
		vtkCamera_Dolly_05(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_Elevation_06(HandleRef pThis, double angle);

	/// <summary>
	/// Rotate the camera about the cross product of the negative of the
	/// direction of projection and the view up vector, using the focal point
	/// as the center of rotation.  The result is a vertical rotation of the
	/// scene.
	/// </summary>
	public void Elevation(double angle)
	{
		vtkCamera_Elevation_06(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetCameraLightTransformMatrix_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns a transformation matrix for a coordinate frame attached to
	/// the camera, where the camera is located at (0, 0, 1) looking at the
	/// focal point at (0, 0, 0), with up being (0, 1, 0).
	/// </summary>
	public vtkMatrix4x4 GetCameraLightTransformMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetCameraLightTransformMatrix_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetClippingRange_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the near and far clipping planes along the
	/// direction of projection.  Both of these values must be positive.
	/// How the clipping planes are set can have a large impact on how
	/// well z-buffering works.  In particular the front clipping
	/// plane can make a very big difference. Setting it to 0.01 when it
	/// really could be 1.0 can have a big impact on your z-buffer resolution
	/// farther away.  The default clipping range is (0.1,1000).
	/// Clipping distance is measured in world coordinate unless a scale factor
	/// exists in camera's ModelTransformMatrix.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual double[] GetClippingRange()
	{
		IntPtr intPtr = vtkCamera_GetClippingRange_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetClippingRange_09(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the location of the near and far clipping planes along the
	/// direction of projection.  Both of these values must be positive.
	/// How the clipping planes are set can have a large impact on how
	/// well z-buffering works.  In particular the front clipping
	/// plane can make a very big difference. Setting it to 0.01 when it
	/// really could be 1.0 can have a big impact on your z-buffer resolution
	/// farther away.  The default clipping range is (0.1,1000).
	/// Clipping distance is measured in world coordinate unless a scale factor
	/// exists in camera's ModelTransformMatrix.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void GetClippingRange(ref double _arg1, ref double _arg2)
	{
		vtkCamera_GetClippingRange_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetClippingRange_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the location of the near and far clipping planes along the
	/// direction of projection.  Both of these values must be positive.
	/// How the clipping planes are set can have a large impact on how
	/// well z-buffering works.  In particular the front clipping
	/// plane can make a very big difference. Setting it to 0.01 when it
	/// really could be 1.0 can have a big impact on your z-buffer resolution
	/// farther away.  The default clipping range is (0.1,1000).
	/// Clipping distance is measured in world coordinate unless a scale factor
	/// exists in camera's ModelTransformMatrix.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void GetClippingRange(IntPtr _arg)
	{
		vtkCamera_GetClippingRange_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetCompositeProjectionTransformMatrix_11(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the concatenation of the ViewTransform and the
	/// ProjectionTransform. This transform will convert world
	/// coordinates to viewport coordinates. The 'aspect' is the
	/// width/height for the viewport, and the nearz and farz are the
	/// Z-buffer values that map to the near and far clipping planes.
	/// The viewport coordinates of a point located inside the frustum are in the
	/// range ([-1,+1],[-1,+1],[nearz,farz]).
	/// aspect is ignored if UseExplicitAspectRatio is true.
	/// @sa ExplicitProjectionTransformMatrix
	/// </summary>
	public virtual vtkMatrix4x4 GetCompositeProjectionTransformMatrix(double aspect, double nearz, double farz)
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetCompositeProjectionTransformMatrix_11(GetCppThis(), aspect, nearz, farz, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetDirectionOfProjection_12(HandleRef pThis);

	/// <summary>
	/// Get the vector in the direction from the camera position to the
	/// focal point.  This is usually the opposite of the ViewPlaneNormal,
	/// the vector perpendicular to the screen, unless the view is oblique.
	/// </summary>
	public virtual double[] GetDirectionOfProjection()
	{
		IntPtr intPtr = vtkCamera_GetDirectionOfProjection_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetDirectionOfProjection_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the vector in the direction from the camera position to the
	/// focal point.  This is usually the opposite of the ViewPlaneNormal,
	/// the vector perpendicular to the screen, unless the view is oblique.
	/// </summary>
	public virtual void GetDirectionOfProjection(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetDirectionOfProjection_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetDirectionOfProjection_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the vector in the direction from the camera position to the
	/// focal point.  This is usually the opposite of the ViewPlaneNormal,
	/// the vector perpendicular to the screen, unless the view is oblique.
	/// </summary>
	public virtual void GetDirectionOfProjection(IntPtr _arg)
	{
		vtkCamera_GetDirectionOfProjection_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetDistance_15(HandleRef pThis);

	/// <summary>
	/// Return the distance from the camera position to the focal point.
	/// This distance is positive.
	/// </summary>
	public virtual double GetDistance()
	{
		return vtkCamera_GetDistance_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetExplicitAspectRatio_16(HandleRef pThis);

	/// <summary>
	/// Set/get an explicit aspect to use, rather than computing it from the renderer.
	/// Only used when UseExplicitAspect is true.
	/// @{
	/// </summary>
	public virtual double GetExplicitAspectRatio()
	{
		return vtkCamera_GetExplicitAspectRatio_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetExplicitProjectionTransformMatrix_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get an explicit 4x4 projection matrix to use, rather than computing
	/// one from other state variables. Only used when
	/// UseExplicitProjectionTransformMatrix is true.
	/// @{
	/// </summary>
	public virtual vtkMatrix4x4 GetExplicitProjectionTransformMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetExplicitProjectionTransformMatrix_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetEyeAngle_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the separation between eyes (in degrees). This is used
	/// when generating stereo images.
	/// </summary>
	public virtual double GetEyeAngle()
	{
		return vtkCamera_GetEyeAngle_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetEyePlaneNormal_19(HandleRef pThis, IntPtr normal);

	/// <summary>
	/// Get normal vector from eye to screen rotated by EyeTransformMatrix.
	/// This will be used only for offaxis frustum calculation.
	/// </summary>
	public void GetEyePlaneNormal(IntPtr normal)
	{
		vtkCamera_GetEyePlaneNormal_19(GetCppThis(), normal);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetEyePosition_20(HandleRef pThis, IntPtr eyePosition);

	/// <summary>
	/// Set/Get the eye position (center point between two eyes).
	/// This is a convenience function that sets the translation
	/// component of EyeTransformMatrix.
	/// This will be used only for offaxis frustum calculation.
	/// </summary>
	public void GetEyePosition(IntPtr eyePosition)
	{
		vtkCamera_GetEyePosition_20(GetCppThis(), eyePosition);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetEyeSeparation_21(HandleRef pThis);

	/// <summary>
	/// Set/Get distance between the eyes.
	/// This will be used only for offaxis frustum calculation.
	/// Default is 0.06.
	/// </summary>
	public virtual double GetEyeSeparation()
	{
		return vtkCamera_GetEyeSeparation_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetEyeTransformMatrix_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get eye transformation matrix.
	/// This is the transformation matrix for the point between eyes.
	/// This will be used only for offaxis frustum calculation.
	/// Default is identity.
	/// </summary>
	public virtual vtkMatrix4x4 GetEyeTransformMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetEyeTransformMatrix_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetFocalDisk_23(HandleRef pThis);

	/// <summary>
	/// Set the size of the cameras lens in world coordinates. This is only
	/// used when the renderer is doing focal depth rendering. When that is
	/// being done the size of the focal disk will effect how significant the
	/// depth effects will be.
	/// </summary>
	public virtual double GetFocalDisk()
	{
		return vtkCamera_GetFocalDisk_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetFocalDistance_24(HandleRef pThis);

	/// <summary>
	/// Sets the distance at which rendering is in focus. This is currently
	/// only used by the ray tracing renderers. 0 (default) disables
	/// ray traced depth of field.
	/// Not to be confused with FocalPoint that is the camera target and
	/// is centered on screen. Using a separate focal distance property
	/// enables out-of-focus areas anywhere on screen.
	/// </summary>
	public virtual double GetFocalDistance()
	{
		return vtkCamera_GetFocalDistance_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetFocalPoint_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the focal of the camera in world coordinates.
	/// The default focal point is the origin.
	/// </summary>
	public virtual double[] GetFocalPoint()
	{
		IntPtr intPtr = vtkCamera_GetFocalPoint_25(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetFocalPoint_26(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the focal of the camera in world coordinates.
	/// The default focal point is the origin.
	/// </summary>
	public virtual void GetFocalPoint(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetFocalPoint_26(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetFocalPoint_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the focal of the camera in world coordinates.
	/// The default focal point is the origin.
	/// </summary>
	public virtual void GetFocalPoint(IntPtr _arg)
	{
		vtkCamera_GetFocalPoint_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetFocalPointScale_28(HandleRef pThis);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual double GetFocalPointScale()
	{
		return vtkCamera_GetFocalPointScale_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetFocalPointShift_29(HandleRef pThis);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual double[] GetFocalPointShift()
	{
		IntPtr intPtr = vtkCamera_GetFocalPointShift_29(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetFocalPointShift_30(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual void GetFocalPointShift(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetFocalPointShift_30(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetFocalPointShift_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual void GetFocalPointShift(IntPtr _arg)
	{
		vtkCamera_GetFocalPointShift_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCamera_GetFreezeFocalPoint_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the FreezeDolly instance variable. This
	/// determines if the camera should move the focal point with the camera position.
	/// HACK!!!
	/// </summary>
	public virtual bool GetFreezeFocalPoint()
	{
		return (vtkCamera_GetFreezeFocalPoint_32(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetFrustumPlanes_33(HandleRef pThis, double aspect, IntPtr planes);

	/// <summary>
	/// Get the plane equations that bound the view frustum.
	/// The plane normals point inward. The planes array contains six
	/// plane equations of the form (Ax+By+Cz+D=0), the first four
	/// values are (A,B,C,D) which repeats for each of the planes.
	/// The planes are given in the following order: -x,+x,-y,+y,-z,+z.
	/// Warning: it means left,right,bottom,top,far,near (NOT near,far)
	/// The aspect of the viewport is needed to correctly compute the planes.
	/// aspect is ignored if UseExplicitAspectRatio is true.
	/// </summary>
	public virtual void GetFrustumPlanes(double aspect, IntPtr planes)
	{
		vtkCamera_GetFrustumPlanes_33(GetCppThis(), aspect, planes);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetInformation_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the information object associated with this camera.
	/// </summary>
	public virtual vtkInformation GetInformation()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetInformation_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCamera_GetLeftEye_35(HandleRef pThis);

	/// <summary>
	/// Set the Left Eye setting
	/// </summary>
	public virtual int GetLeftEye()
	{
		return vtkCamera_GetLeftEye_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetModelTransformMatrix_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get model transformation matrix.
	/// This matrix could be used for model related transformations
	/// such as scale, shear, rotations and translations.
	/// </summary>
	public virtual vtkMatrix4x4 GetModelTransformMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetModelTransformMatrix_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetModelViewTransformMatrix_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the model view matrix of model view transform.
	/// </summary>
	public virtual vtkMatrix4x4 GetModelViewTransformMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetModelViewTransformMatrix_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetModelViewTransformObject_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the model view transform.
	/// </summary>
	public virtual vtkTransform GetModelViewTransformObject()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetModelViewTransformObject_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetNearPlaneScale_39(HandleRef pThis);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual double GetNearPlaneScale()
	{
		return vtkCamera_GetNearPlaneScale_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetNearPlaneShift_40(HandleRef pThis);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual double[] GetNearPlaneShift()
	{
		IntPtr intPtr = vtkCamera_GetNearPlaneShift_40(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetNearPlaneShift_41(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual void GetNearPlaneShift(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetNearPlaneShift_41(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetNearPlaneShift_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual void GetNearPlaneShift(IntPtr _arg)
	{
		vtkCamera_GetNearPlaneShift_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCamera_GetNumberOfGenerationsFromBase_43(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCamera_GetNumberOfGenerationsFromBase_43(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCamera_GetNumberOfGenerationsFromBaseType_44(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCamera_GetNumberOfGenerationsFromBaseType_44(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetOrientation_45(HandleRef pThis);

	/// <summary>
	/// Get the orientation of the camera.
	/// </summary>
	public double[] GetOrientation()
	{
		IntPtr intPtr = vtkCamera_GetOrientation_45(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetOrientationWXYZ_46(HandleRef pThis);

	/// <summary>
	/// Get the orientation of the camera.
	/// </summary>
	public double[] GetOrientationWXYZ()
	{
		IntPtr intPtr = vtkCamera_GetOrientationWXYZ_46(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCamera_GetParallelProjection_47(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the ParallelProjection instance variable. This
	/// determines if the camera should do a perspective or parallel projection.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual int GetParallelProjection()
	{
		return vtkCamera_GetParallelProjection_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetParallelScale_48(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling used for a parallel projection, i.e. the half of the height
	/// of the viewport in world-coordinate distances. The default is 1.
	/// Note that the "scale" parameter works as an "inverse scale" ---
	/// larger numbers produce smaller images.
	/// This method has no effect in perspective projection mode.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual double GetParallelScale()
	{
		return vtkCamera_GetParallelScale_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetPosition_49(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the camera in world coordinates.
	/// The default position is (0,0,1).
	/// </summary>
	public virtual double[] GetPosition()
	{
		IntPtr intPtr = vtkCamera_GetPosition_49(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetPosition_50(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the position of the camera in world coordinates.
	/// The default position is (0,0,1).
	/// </summary>
	public virtual void GetPosition(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetPosition_50(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetPosition_51(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the position of the camera in world coordinates.
	/// The default position is (0,0,1).
	/// </summary>
	public virtual void GetPosition(IntPtr _arg)
	{
		vtkCamera_GetPosition_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetProjectionTransformMatrix_52(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the projection transform matrix, which converts from camera
	/// coordinates to viewport coordinates.  The 'aspect' is the
	/// width/height for the viewport, and the nearz and farz are the
	/// Z-buffer values that map to the near and far clipping planes.
	/// The viewport coordinates of a point located inside the frustum are in the
	/// range ([-1,+1],[-1,+1],[nearz,farz]).
	/// aspect is ignored if UseExplicitAspectRatio is true.
	/// @sa ExplicitProjectionTransformMatrix
	/// </summary>
	public virtual vtkMatrix4x4 GetProjectionTransformMatrix(double aspect, double nearz, double farz)
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetProjectionTransformMatrix_52(GetCppThis(), aspect, nearz, farz, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetProjectionTransformMatrix_53(HandleRef pThis, HandleRef ren, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the projection transform matrix, which converts from camera
	/// coordinates to viewport coordinates. This method computes
	/// the aspect, nearz and farz, then calls the more specific
	/// signature of GetCompositeProjectionTransformMatrix
	/// @sa ExplicitProjectionTransformMatrix
	/// </summary>
	public virtual vtkMatrix4x4 GetProjectionTransformMatrix(vtkRenderer ren)
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetProjectionTransformMatrix_53(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetProjectionTransformObject_54(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the projection transform matrix, which converts from camera
	/// coordinates to viewport coordinates. The 'aspect' is the
	/// width/height for the viewport, and the nearz and farz are the
	/// Z-buffer values that map to the near and far clipping planes.
	/// The viewport coordinates of a point located inside the frustum are in the
	/// range ([-1,+1],[-1,+1],[nearz,farz]).
	/// aspect is ignored if UseExplicitAspectRatio is true.
	/// @sa ExplicitProjectionTransformMatrix
	/// </summary>
	public virtual vtkPerspectiveTransform GetProjectionTransformObject(double aspect, double nearz, double farz)
	{
		vtkPerspectiveTransform vtkPerspectiveTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetProjectionTransformObject_54(GetCppThis(), aspect, nearz, farz, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPerspectiveTransform2 = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPerspectiveTransform2.Register(null);
			}
		}
		return vtkPerspectiveTransform2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetRoll_55(HandleRef pThis);

	/// <summary>
	/// Set the roll angle of the camera about the direction of projection.
	/// </summary>
	public double GetRoll()
	{
		return vtkCamera_GetRoll_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetScissorRect_56(HandleRef pThis, HandleRef scissorRect);

	/// <summary>
	/// Set/Get the vtkRect value of the scissor
	/// </summary>
	public void GetScissorRect(vtkRecti scissorRect)
	{
		vtkCamera_GetScissorRect_56(GetCppThis(), scissorRect?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetScreenBottomLeft_57(HandleRef pThis);

	/// <summary>
	/// Set/Get top left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (-1.0, -1.0, -1.0).
	/// </summary>
	public virtual double[] GetScreenBottomLeft()
	{
		IntPtr intPtr = vtkCamera_GetScreenBottomLeft_57(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetScreenBottomLeft_58(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get top left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (-1.0, -1.0, -1.0).
	/// </summary>
	public virtual void GetScreenBottomLeft(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetScreenBottomLeft_58(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetScreenBottomLeft_59(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get top left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (-1.0, -1.0, -1.0).
	/// </summary>
	public virtual void GetScreenBottomLeft(IntPtr _arg)
	{
		vtkCamera_GetScreenBottomLeft_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetScreenBottomRight_60(HandleRef pThis);

	/// <summary>
	/// Set/Get bottom left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, -1.0, -1.0).
	/// </summary>
	public virtual double[] GetScreenBottomRight()
	{
		IntPtr intPtr = vtkCamera_GetScreenBottomRight_60(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetScreenBottomRight_61(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get bottom left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, -1.0, -1.0).
	/// </summary>
	public virtual void GetScreenBottomRight(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetScreenBottomRight_61(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetScreenBottomRight_62(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get bottom left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, -1.0, -1.0).
	/// </summary>
	public virtual void GetScreenBottomRight(IntPtr _arg)
	{
		vtkCamera_GetScreenBottomRight_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetScreenTopRight_63(HandleRef pThis);

	/// <summary>
	/// Set/Get top right corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, 1.0, -1.0).
	/// </summary>
	public virtual double[] GetScreenTopRight()
	{
		IntPtr intPtr = vtkCamera_GetScreenTopRight_63(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetScreenTopRight_64(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get top right corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, 1.0, -1.0).
	/// </summary>
	public virtual void GetScreenTopRight(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetScreenTopRight_64(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetScreenTopRight_65(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get top right corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, 1.0, -1.0).
	/// </summary>
	public virtual void GetScreenTopRight(IntPtr _arg)
	{
		vtkCamera_GetScreenTopRight_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetShiftScaleThreshold_66(HandleRef pThis);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual double GetShiftScaleThreshold()
	{
		return vtkCamera_GetShiftScaleThreshold_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCamera_GetStereo_67(HandleRef pThis);

	/// <summary>
	/// Get the stereo setting
	/// </summary>
	public virtual int GetStereo()
	{
		return vtkCamera_GetStereo_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetThickness_68(HandleRef pThis);

	/// <summary>
	/// Set the distance between clipping planes.  This method adjusts the
	/// far clipping plane to be set a distance 'thickness' beyond the
	/// near clipping plane.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual double GetThickness()
	{
		return vtkCamera_GetThickness_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCamera_GetUseExplicitAspectRatio_69(HandleRef pThis);

	/// <summary>
	/// If true, the ExplicitAspect is used for the projection
	/// transformation, rather than computing it from the renderer.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual bool GetUseExplicitAspectRatio()
	{
		return (vtkCamera_GetUseExplicitAspectRatio_69(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCamera_GetUseExplicitProjectionTransformMatrix_70(HandleRef pThis);

	/// <summary>
	/// If true, the ExplicitProjectionTransformMatrix is used for the projection
	/// transformation, rather than computing a transform from internal state.
	/// @{
	/// </summary>
	public virtual bool GetUseExplicitProjectionTransformMatrix()
	{
		return (vtkCamera_GetUseExplicitProjectionTransformMatrix_70(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCamera_GetUseHorizontalViewAngle_71(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the UseHorizontalViewAngle instance variable. If
	/// set, the camera's view angle represents a horizontal view angle, rather
	/// than the default vertical view angle. This is useful if the application
	/// uses a display device which whose specs indicate a particular horizontal
	/// view angle, or if the application varies the window height but wants to
	/// keep the perspective transform unchanges.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual int GetUseHorizontalViewAngle()
	{
		return vtkCamera_GetUseHorizontalViewAngle_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCamera_GetUseOffAxisProjection_72(HandleRef pThis);

	/// <summary>
	/// Set/Get use offaxis frustum.
	/// OffAxis frustum is used for off-axis frustum calculations specifically
	/// for stereo rendering.
	/// For reference see "High Resolution Virtual Reality", in Proc.
	/// SIGGRAPH '92, Computer Graphics, pages 195-202, 1992.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual int GetUseOffAxisProjection()
	{
		return vtkCamera_GetUseOffAxisProjection_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCamera_GetUseScissor_73(HandleRef pThis);

	/// <summary>
	/// Enable/Disable the scissor
	/// </summary>
	public virtual bool GetUseScissor()
	{
		return (vtkCamera_GetUseScissor_73(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetUserTransform_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// In addition to the instance variables such as position and orientation,
	/// you can add an additional transformation for your own use. This
	/// transformation is concatenated to the camera's ProjectionTransform
	/// </summary>
	public virtual vtkHomogeneousTransform GetUserTransform()
	{
		vtkHomogeneousTransform vtkHomogeneousTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetUserTransform_74(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHomogeneousTransform2 = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHomogeneousTransform2.Register(null);
			}
		}
		return vtkHomogeneousTransform2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetUserViewTransform_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// In addition to the instance variables such as position and orientation,
	/// you can add an additional transformation for your own use.  This
	/// transformation is concatenated to the camera's ViewTransform
	/// </summary>
	public virtual vtkHomogeneousTransform GetUserViewTransform()
	{
		vtkHomogeneousTransform vtkHomogeneousTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetUserViewTransform_75(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHomogeneousTransform2 = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHomogeneousTransform2.Register(null);
			}
		}
		return vtkHomogeneousTransform2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCamera_GetViewAngle_76(HandleRef pThis);

	/// <summary>
	/// Set/Get the camera view angle, which is the angular height of the
	/// camera view measured in degrees.  The default angle is 30 degrees.
	/// This method has no effect in parallel projection mode.
	/// The formula for setting the angle up for perfect perspective viewing
	/// is: angle = 2*atan((h/2)/d) where h is the height of the RenderWindow
	/// (measured by holding a ruler up to your screen) and d is the
	/// distance from your eyes to the screen.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual double GetViewAngle()
	{
		return vtkCamera_GetViewAngle_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetViewPlaneNormal_77(HandleRef pThis);

	/// <summary>
	/// Get the ViewPlaneNormal.  This vector will point opposite to
	/// the direction of projection, unless you have created a sheared output
	/// view using SetViewShear/SetObliqueAngles.
	/// </summary>
	public virtual double[] GetViewPlaneNormal()
	{
		IntPtr intPtr = vtkCamera_GetViewPlaneNormal_77(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetViewPlaneNormal_78(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the ViewPlaneNormal.  This vector will point opposite to
	/// the direction of projection, unless you have created a sheared output
	/// view using SetViewShear/SetObliqueAngles.
	/// </summary>
	public virtual void GetViewPlaneNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetViewPlaneNormal_78(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetViewPlaneNormal_79(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the ViewPlaneNormal.  This vector will point opposite to
	/// the direction of projection, unless you have created a sheared output
	/// view using SetViewShear/SetObliqueAngles.
	/// </summary>
	public virtual void GetViewPlaneNormal(IntPtr _arg)
	{
		vtkCamera_GetViewPlaneNormal_79(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetViewShear_80(HandleRef pThis);

	/// <summary>
	/// Set/get the shear transform of the viewing frustum.  Parameters are
	/// dx/dz, dy/dz, and center.  center is a factor that describes where
	/// to shear around. The distance dshear from the camera where
	/// no shear occurs is given by (dshear = center * FocalDistance).
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual double[] GetViewShear()
	{
		IntPtr intPtr = vtkCamera_GetViewShear_80(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetViewShear_81(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get the shear transform of the viewing frustum.  Parameters are
	/// dx/dz, dy/dz, and center.  center is a factor that describes where
	/// to shear around. The distance dshear from the camera where
	/// no shear occurs is given by (dshear = center * FocalDistance).
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void GetViewShear(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetViewShear_81(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetViewShear_82(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the shear transform of the viewing frustum.  Parameters are
	/// dx/dz, dy/dz, and center.  center is a factor that describes where
	/// to shear around. The distance dshear from the camera where
	/// no shear occurs is given by (dshear = center * FocalDistance).
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void GetViewShear(IntPtr _arg)
	{
		vtkCamera_GetViewShear_82(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetViewTransformMatrix_83(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// For backward compatibility. Use GetModelViewTransformMatrix() now.
	/// Return the matrix of the view transform.
	/// The ViewTransform depends on only three ivars:  the Position, the
	/// FocalPoint, and the ViewUp vector.  All the other methods are there
	/// simply for the sake of the users' convenience.
	/// </summary>
	public virtual vtkMatrix4x4 GetViewTransformMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetViewTransformMatrix_83(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetViewTransformObject_84(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// For backward compatibility. Use GetModelViewTransformObject() now.
	/// Return the view transform.
	/// If the camera's ModelTransformMatrix is identity then
	/// the ViewTransform depends on only three ivars:
	/// the Position, the FocalPoint, and the ViewUp vector.
	/// All the other methods are there simply for the sake of the users'
	/// convenience.
	/// </summary>
	public virtual vtkTransform GetViewTransformObject()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_GetViewTransformObject_84(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetViewUp_85(HandleRef pThis);

	/// <summary>
	/// Set/Get the view up direction for the camera.  The default
	/// is (0,1,0).
	/// </summary>
	public virtual double[] GetViewUp()
	{
		IntPtr intPtr = vtkCamera_GetViewUp_85(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetViewUp_86(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the view up direction for the camera.  The default
	/// is (0,1,0).
	/// </summary>
	public virtual void GetViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCamera_GetViewUp_86(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetViewUp_87(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the view up direction for the camera.  The default
	/// is (0,1,0).
	/// </summary>
	public virtual void GetViewUp(IntPtr _arg)
	{
		vtkCamera_GetViewUp_87(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkCamera_GetViewingRaysMTime_88(HandleRef pThis);

	/// <summary>
	/// Return the MTime that concerns recomputing the view rays of the camera.
	/// </summary>
	public ulong GetViewingRaysMTime()
	{
		return vtkCamera_GetViewingRaysMTime_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_GetWindowCenter_89(HandleRef pThis);

	/// <summary>
	/// Set/Get the center of the window in viewport coordinates.
	/// The viewport coordinate range is ([-1,+1],[-1,+1]).  This method
	/// is for if you have one window which consists of several viewports,
	/// or if you have several screens which you want to act together as
	/// one large screen.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual double[] GetWindowCenter()
	{
		IntPtr intPtr = vtkCamera_GetWindowCenter_89(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetWindowCenter_90(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the center of the window in viewport coordinates.
	/// The viewport coordinate range is ([-1,+1],[-1,+1]).  This method
	/// is for if you have one window which consists of several viewports,
	/// or if you have several screens which you want to act together as
	/// one large screen.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void GetWindowCenter(ref double _arg1, ref double _arg2)
	{
		vtkCamera_GetWindowCenter_90(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_GetWindowCenter_91(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the center of the window in viewport coordinates.
	/// The viewport coordinate range is ([-1,+1],[-1,+1]).  This method
	/// is for if you have one window which consists of several viewports,
	/// or if you have several screens which you want to act together as
	/// one large screen.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void GetWindowCenter(IntPtr _arg)
	{
		vtkCamera_GetWindowCenter_91(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCamera_IsA_92(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCamera_IsA_92(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCamera_IsTypeOf_93(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCamera_IsTypeOf_93(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_NewInstance_95(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCamera NewInstance()
	{
		vtkCamera result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_NewInstance_95(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_OrthogonalizeViewUp_96(HandleRef pThis);

	/// <summary>
	/// Recompute the ViewUp vector to force it to be perpendicular to
	/// camera-&gt;focalpoint vector.  Unless you are going to use
	/// Yaw or Azimuth on the camera, there is no need to do this.
	/// </summary>
	public void OrthogonalizeViewUp()
	{
		vtkCamera_OrthogonalizeViewUp_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_ParallelProjectionOff_97(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the ParallelProjection instance variable. This
	/// determines if the camera should do a perspective or parallel projection.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void ParallelProjectionOff()
	{
		vtkCamera_ParallelProjectionOff_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_ParallelProjectionOn_98(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the ParallelProjection instance variable. This
	/// determines if the camera should do a perspective or parallel projection.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void ParallelProjectionOn()
	{
		vtkCamera_ParallelProjectionOn_98(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_Pitch_99(HandleRef pThis, double angle);

	/// <summary>
	/// Rotate the focal point about the cross product of the view up vector
	/// and the direction of projection, using the camera's position as the
	/// center of rotation.  The result is a vertical rotation of the camera.
	/// </summary>
	public void Pitch(double angle)
	{
		vtkCamera_Pitch_99(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_Render_100(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// This method causes the camera to set up whatever is required for
	/// viewing the scene. This is actually handled by an subclass of
	/// vtkCamera, which is created through New()
	/// </summary>
	public virtual void Render(vtkRenderer arg0)
	{
		vtkCamera_Render_100(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_Roll_101(HandleRef pThis, double angle);

	/// <summary>
	/// Rotate the camera about the direction of projection.  This will
	/// spin the camera about its axis.
	/// </summary>
	public void Roll(double angle)
	{
		vtkCamera_Roll_101(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCamera_SafeDownCast_102(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCamera SafeDownCast(vtkObjectBase o)
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCamera_SafeDownCast_102(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCamera2 = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCamera2.Register(null);
			}
		}
		return vtkCamera2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetClippingRange_103(HandleRef pThis, double dNear, double dFar);

	/// <summary>
	/// Set/Get the location of the near and far clipping planes along the
	/// direction of projection.  Both of these values must be positive.
	/// How the clipping planes are set can have a large impact on how
	/// well z-buffering works.  In particular the front clipping
	/// plane can make a very big difference. Setting it to 0.01 when it
	/// really could be 1.0 can have a big impact on your z-buffer resolution
	/// farther away.  The default clipping range is (0.1,1000).
	/// Clipping distance is measured in world coordinate unless a scale factor
	/// exists in camera's ModelTransformMatrix.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetClippingRange(double dNear, double dFar)
	{
		vtkCamera_SetClippingRange_103(GetCppThis(), dNear, dFar);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetClippingRange_104(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set/Get the location of the near and far clipping planes along the
	/// direction of projection.  Both of these values must be positive.
	/// How the clipping planes are set can have a large impact on how
	/// well z-buffering works.  In particular the front clipping
	/// plane can make a very big difference. Setting it to 0.01 when it
	/// really could be 1.0 can have a big impact on your z-buffer resolution
	/// farther away.  The default clipping range is (0.1,1000).
	/// Clipping distance is measured in world coordinate unless a scale factor
	/// exists in camera's ModelTransformMatrix.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetClippingRange(IntPtr a)
	{
		vtkCamera_SetClippingRange_104(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetDistance_105(HandleRef pThis, double arg0);

	/// <summary>
	/// Move the focal point so that it is the specified distance from
	/// the camera position.  This distance must be positive.
	/// </summary>
	public void SetDistance(double arg0)
	{
		vtkCamera_SetDistance_105(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetExplicitAspectRatio_106(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get an explicit aspect to use, rather than computing it from the renderer.
	/// Only used when UseExplicitAspect is true.
	/// @{
	/// </summary>
	public virtual void SetExplicitAspectRatio(double _arg)
	{
		vtkCamera_SetExplicitAspectRatio_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetExplicitProjectionTransformMatrix_107(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get an explicit 4x4 projection matrix to use, rather than computing
	/// one from other state variables. Only used when
	/// UseExplicitProjectionTransformMatrix is true.
	/// @{
	/// </summary>
	public virtual void SetExplicitProjectionTransformMatrix(vtkMatrix4x4 arg0)
	{
		vtkCamera_SetExplicitProjectionTransformMatrix_107(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetEyeAngle_108(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the separation between eyes (in degrees). This is used
	/// when generating stereo images.
	/// </summary>
	public virtual void SetEyeAngle(double _arg)
	{
		vtkCamera_SetEyeAngle_108(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetEyePosition_109(HandleRef pThis, IntPtr eyePosition);

	/// <summary>
	/// Set/Get the eye position (center point between two eyes).
	/// This is a convenience function that sets the translation
	/// component of EyeTransformMatrix.
	/// This will be used only for offaxis frustum calculation.
	/// </summary>
	public void SetEyePosition(IntPtr eyePosition)
	{
		vtkCamera_SetEyePosition_109(GetCppThis(), eyePosition);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetEyeSeparation_110(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get distance between the eyes.
	/// This will be used only for offaxis frustum calculation.
	/// Default is 0.06.
	/// </summary>
	public virtual void SetEyeSeparation(double _arg)
	{
		vtkCamera_SetEyeSeparation_110(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetEyeTransformMatrix_111(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Set/Get eye transformation matrix.
	/// This is the transformation matrix for the point between eyes.
	/// This will be used only for offaxis frustum calculation.
	/// Default is identity.
	/// </summary>
	public void SetEyeTransformMatrix(vtkMatrix4x4 matrix)
	{
		vtkCamera_SetEyeTransformMatrix_111(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetEyeTransformMatrix_112(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set the eye transform matrix.
	/// This is the transformation matrix for the point between eyes.
	/// This will be used only for offaxis frustum calculation.
	/// Default is identity.
	/// </summary>
	public void SetEyeTransformMatrix(IntPtr elements)
	{
		vtkCamera_SetEyeTransformMatrix_112(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetFocalDisk_113(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the size of the cameras lens in world coordinates. This is only
	/// used when the renderer is doing focal depth rendering. When that is
	/// being done the size of the focal disk will effect how significant the
	/// depth effects will be.
	/// </summary>
	public virtual void SetFocalDisk(double _arg)
	{
		vtkCamera_SetFocalDisk_113(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetFocalDistance_114(HandleRef pThis, double _arg);

	/// <summary>
	/// Sets the distance at which rendering is in focus. This is currently
	/// only used by the ray tracing renderers. 0 (default) disables
	/// ray traced depth of field.
	/// Not to be confused with FocalPoint that is the camera target and
	/// is centered on screen. Using a separate focal distance property
	/// enables out-of-focus areas anywhere on screen.
	/// </summary>
	public virtual void SetFocalDistance(double _arg)
	{
		vtkCamera_SetFocalDistance_114(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetFocalPoint_115(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the focal of the camera in world coordinates.
	/// The default focal point is the origin.
	/// </summary>
	public void SetFocalPoint(double x, double y, double z)
	{
		vtkCamera_SetFocalPoint_115(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetFocalPoint_116(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set/Get the focal of the camera in world coordinates.
	/// The default focal point is the origin.
	/// </summary>
	public void SetFocalPoint(IntPtr a)
	{
		vtkCamera_SetFocalPoint_116(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetFreezeFocalPoint_117(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get the value of the FreezeDolly instance variable. This
	/// determines if the camera should move the focal point with the camera position.
	/// HACK!!!
	/// </summary>
	public virtual void SetFreezeFocalPoint(bool _arg)
	{
		vtkCamera_SetFreezeFocalPoint_117(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetInformation_118(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the information object associated with this camera.
	/// </summary>
	public virtual void SetInformation(vtkInformation arg0)
	{
		vtkCamera_SetInformation_118(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetLeftEye_119(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the Left Eye setting
	/// </summary>
	public virtual void SetLeftEye(int _arg)
	{
		vtkCamera_SetLeftEye_119(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetModelTransformMatrix_120(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Set/Get model transformation matrix.
	/// This matrix could be used for model related transformations
	/// such as scale, shear, rotations and translations.
	/// </summary>
	public void SetModelTransformMatrix(vtkMatrix4x4 matrix)
	{
		vtkCamera_SetModelTransformMatrix_120(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetModelTransformMatrix_121(HandleRef pThis, IntPtr elements);

	/// <summary>
	/// Set model transformation matrix.
	/// This matrix could be used for model related transformations
	/// such as scale, shear, rotations and translations.
	/// </summary>
	public void SetModelTransformMatrix(IntPtr elements)
	{
		vtkCamera_SetModelTransformMatrix_121(GetCppThis(), elements);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetObliqueAngles_122(HandleRef pThis, double alpha, double beta);

	/// <summary>
	/// Get/Set the oblique viewing angles.  The first angle, alpha, is the
	/// angle (measured from the horizontal) that rays along the direction
	/// of projection will follow once projected onto the 2D screen.
	/// The second angle, beta, is the angle between the view plane and
	/// the direction of projection.  This creates a shear transform
	/// x' = x + dz*cos(alpha)/tan(beta), y' = dz*sin(alpha)/tan(beta)
	/// where dz is the distance of the point from the focal plane.
	/// The angles are (45,90) by default.  Oblique projections
	/// commonly use (30,63.435).
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetObliqueAngles(double alpha, double beta)
	{
		vtkCamera_SetObliqueAngles_122(GetCppThis(), alpha, beta);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetParallelProjection_123(HandleRef pThis, int flag);

	/// <summary>
	/// Set/Get the value of the ParallelProjection instance variable. This
	/// determines if the camera should do a perspective or parallel projection.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetParallelProjection(int flag)
	{
		vtkCamera_SetParallelProjection_123(GetCppThis(), flag);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetParallelScale_124(HandleRef pThis, double scale);

	/// <summary>
	/// Set/Get the scaling used for a parallel projection, i.e. the half of the height
	/// of the viewport in world-coordinate distances. The default is 1.
	/// Note that the "scale" parameter works as an "inverse scale" ---
	/// larger numbers produce smaller images.
	/// This method has no effect in perspective projection mode.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetParallelScale(double scale)
	{
		vtkCamera_SetParallelScale_124(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetPosition_125(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the camera in world coordinates.
	/// The default position is (0,0,1).
	/// </summary>
	public void SetPosition(double x, double y, double z)
	{
		vtkCamera_SetPosition_125(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetPosition_126(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set/Get the position of the camera in world coordinates.
	/// The default position is (0,0,1).
	/// </summary>
	public void SetPosition(IntPtr a)
	{
		vtkCamera_SetPosition_126(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetRoll_127(HandleRef pThis, double angle);

	/// <summary>
	/// Set the roll angle of the camera about the direction of projection.
	/// </summary>
	public void SetRoll(double angle)
	{
		vtkCamera_SetRoll_127(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetScissorRect_128(HandleRef pThis, HandleRef scissorRect);

	/// <summary>
	/// Set/Get the vtkRect value of the scissor
	/// </summary>
	public void SetScissorRect(vtkRecti scissorRect)
	{
		vtkCamera_SetScissorRect_128(GetCppThis(), scissorRect?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetScreenBottomLeft_129(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get top left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (-1.0, -1.0, -1.0).
	/// </summary>
	public virtual void SetScreenBottomLeft(double _arg1, double _arg2, double _arg3)
	{
		vtkCamera_SetScreenBottomLeft_129(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetScreenBottomLeft_130(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get top left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (-1.0, -1.0, -1.0).
	/// </summary>
	public virtual void SetScreenBottomLeft(IntPtr _arg)
	{
		vtkCamera_SetScreenBottomLeft_130(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetScreenBottomRight_131(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get bottom left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, -1.0, -1.0).
	/// </summary>
	public virtual void SetScreenBottomRight(double _arg1, double _arg2, double _arg3)
	{
		vtkCamera_SetScreenBottomRight_131(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetScreenBottomRight_132(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get bottom left corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, -1.0, -1.0).
	/// </summary>
	public virtual void SetScreenBottomRight(IntPtr _arg)
	{
		vtkCamera_SetScreenBottomRight_132(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetScreenTopRight_133(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get top right corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, 1.0, -1.0).
	/// </summary>
	public virtual void SetScreenTopRight(double _arg1, double _arg2, double _arg3)
	{
		vtkCamera_SetScreenTopRight_133(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetScreenTopRight_134(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get top right corner point of the screen.
	/// This will be used only for offaxis frustum calculation.
	/// Default is (1.0, 1.0, -1.0).
	/// </summary>
	public virtual void SetScreenTopRight(IntPtr _arg)
	{
		vtkCamera_SetScreenTopRight_134(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetShiftScaleThreshold_135(HandleRef pThis, double _arg);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual void SetShiftScaleThreshold(double _arg)
	{
		vtkCamera_SetShiftScaleThreshold_135(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetThickness_136(HandleRef pThis, double arg0);

	/// <summary>
	/// Set the distance between clipping planes.  This method adjusts the
	/// far clipping plane to be set a distance 'thickness' beyond the
	/// near clipping plane.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetThickness(double arg0)
	{
		vtkCamera_SetThickness_136(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetUseExplicitAspectRatio_137(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, the ExplicitAspect is used for the projection
	/// transformation, rather than computing it from the renderer.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void SetUseExplicitAspectRatio(bool _arg)
	{
		vtkCamera_SetUseExplicitAspectRatio_137(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetUseExplicitProjectionTransformMatrix_138(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, the ExplicitProjectionTransformMatrix is used for the projection
	/// transformation, rather than computing a transform from internal state.
	/// @{
	/// </summary>
	public virtual void SetUseExplicitProjectionTransformMatrix(bool _arg)
	{
		vtkCamera_SetUseExplicitProjectionTransformMatrix_138(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetUseHorizontalViewAngle_139(HandleRef pThis, int flag);

	/// <summary>
	/// Set/Get the value of the UseHorizontalViewAngle instance variable. If
	/// set, the camera's view angle represents a horizontal view angle, rather
	/// than the default vertical view angle. This is useful if the application
	/// uses a display device which whose specs indicate a particular horizontal
	/// view angle, or if the application varies the window height but wants to
	/// keep the perspective transform unchanges.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetUseHorizontalViewAngle(int flag)
	{
		vtkCamera_SetUseHorizontalViewAngle_139(GetCppThis(), flag);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetUseOffAxisProjection_140(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get use offaxis frustum.
	/// OffAxis frustum is used for off-axis frustum calculations specifically
	/// for stereo rendering.
	/// For reference see "High Resolution Virtual Reality", in Proc.
	/// SIGGRAPH '92, Computer Graphics, pages 195-202, 1992.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void SetUseOffAxisProjection(int _arg)
	{
		vtkCamera_SetUseOffAxisProjection_140(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetUseScissor_141(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/Disable the scissor
	/// </summary>
	public virtual void SetUseScissor(bool _arg)
	{
		vtkCamera_SetUseScissor_141(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetUserTransform_142(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// In addition to the instance variables such as position and orientation,
	/// you can add an additional transformation for your own use. This
	/// transformation is concatenated to the camera's ProjectionTransform
	/// </summary>
	public void SetUserTransform(vtkHomogeneousTransform transform)
	{
		vtkCamera_SetUserTransform_142(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetUserViewTransform_143(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// In addition to the instance variables such as position and orientation,
	/// you can add an additional transformation for your own use.  This
	/// transformation is concatenated to the camera's ViewTransform
	/// </summary>
	public void SetUserViewTransform(vtkHomogeneousTransform transform)
	{
		vtkCamera_SetUserViewTransform_143(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetViewAngle_144(HandleRef pThis, double angle);

	/// <summary>
	/// Set/Get the camera view angle, which is the angular height of the
	/// camera view measured in degrees.  The default angle is 30 degrees.
	/// This method has no effect in parallel projection mode.
	/// The formula for setting the angle up for perfect perspective viewing
	/// is: angle = 2*atan((h/2)/d) where h is the height of the RenderWindow
	/// (measured by holding a ruler up to your screen) and d is the
	/// distance from your eyes to the screen.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetViewAngle(double angle)
	{
		vtkCamera_SetViewAngle_144(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetViewShear_145(HandleRef pThis, double dxdz, double dydz, double center);

	/// <summary>
	/// Set/get the shear transform of the viewing frustum.  Parameters are
	/// dx/dz, dy/dz, and center.  center is a factor that describes where
	/// to shear around. The distance dshear from the camera where
	/// no shear occurs is given by (dshear = center * FocalDistance).
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetViewShear(double dxdz, double dydz, double center)
	{
		vtkCamera_SetViewShear_145(GetCppThis(), dxdz, dydz, center);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetViewShear_146(HandleRef pThis, IntPtr d);

	/// <summary>
	/// Set/get the shear transform of the viewing frustum.  Parameters are
	/// dx/dz, dy/dz, and center.  center is a factor that describes where
	/// to shear around. The distance dshear from the camera where
	/// no shear occurs is given by (dshear = center * FocalDistance).
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetViewShear(IntPtr d)
	{
		vtkCamera_SetViewShear_146(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetViewUp_147(HandleRef pThis, double vx, double vy, double vz);

	/// <summary>
	/// Set/Get the view up direction for the camera.  The default
	/// is (0,1,0).
	/// </summary>
	public void SetViewUp(double vx, double vy, double vz)
	{
		vtkCamera_SetViewUp_147(GetCppThis(), vx, vy, vz);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetViewUp_148(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set/Get the view up direction for the camera.  The default
	/// is (0,1,0).
	/// </summary>
	public void SetViewUp(IntPtr a)
	{
		vtkCamera_SetViewUp_148(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_SetWindowCenter_149(HandleRef pThis, double x, double y);

	/// <summary>
	/// Set/Get the center of the window in viewport coordinates.
	/// The viewport coordinate range is ([-1,+1],[-1,+1]).  This method
	/// is for if you have one window which consists of several viewports,
	/// or if you have several screens which you want to act together as
	/// one large screen.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void SetWindowCenter(double x, double y)
	{
		vtkCamera_SetWindowCenter_149(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_ShallowCopy_150(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Copy the properties of `source' into `this'.
	/// Copy pointers of matrices.
	/// \pre source_exists!=0
	/// \pre not_this: source!=this
	/// </summary>
	public void ShallowCopy(vtkCamera source)
	{
		vtkCamera_ShallowCopy_150(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UpdateIdealShiftScale_151(HandleRef pThis, double aspect);

	/// <summary>
	/// The following methods are used to support view dependent methods
	/// for normalizing data (typically point coordinates). When dealing with
	/// data that can exceed floating point resolution sometimes is it best
	/// to normalize that data based on the current camera view such that
	/// what is seen will be in the sweet spot for floating point resolution.
	/// Input datasets may be double precision but the rendering engine
	/// is currently single precision which also can lead to these issues.
	/// See vtkOpenGLVertexBufferObject for related information.
	/// </summary>
	public virtual void UpdateIdealShiftScale(double aspect)
	{
		vtkCamera_UpdateIdealShiftScale_151(GetCppThis(), aspect);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UpdateViewport_152(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Update the viewport
	/// </summary>
	public virtual void UpdateViewport(vtkRenderer arg0)
	{
		vtkCamera_UpdateViewport_152(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UseExplicitAspectRatioOff_153(HandleRef pThis);

	/// <summary>
	/// If true, the ExplicitAspect is used for the projection
	/// transformation, rather than computing it from the renderer.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void UseExplicitAspectRatioOff()
	{
		vtkCamera_UseExplicitAspectRatioOff_153(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UseExplicitAspectRatioOn_154(HandleRef pThis);

	/// <summary>
	/// If true, the ExplicitAspect is used for the projection
	/// transformation, rather than computing it from the renderer.
	/// Default is false.
	/// @{
	/// </summary>
	public virtual void UseExplicitAspectRatioOn()
	{
		vtkCamera_UseExplicitAspectRatioOn_154(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UseExplicitProjectionTransformMatrixOff_155(HandleRef pThis);

	/// <summary>
	/// If true, the ExplicitProjectionTransformMatrix is used for the projection
	/// transformation, rather than computing a transform from internal state.
	/// @{
	/// </summary>
	public virtual void UseExplicitProjectionTransformMatrixOff()
	{
		vtkCamera_UseExplicitProjectionTransformMatrixOff_155(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UseExplicitProjectionTransformMatrixOn_156(HandleRef pThis);

	/// <summary>
	/// If true, the ExplicitProjectionTransformMatrix is used for the projection
	/// transformation, rather than computing a transform from internal state.
	/// @{
	/// </summary>
	public virtual void UseExplicitProjectionTransformMatrixOn()
	{
		vtkCamera_UseExplicitProjectionTransformMatrixOn_156(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UseHorizontalViewAngleOff_157(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the UseHorizontalViewAngle instance variable. If
	/// set, the camera's view angle represents a horizontal view angle, rather
	/// than the default vertical view angle. This is useful if the application
	/// uses a display device which whose specs indicate a particular horizontal
	/// view angle, or if the application varies the window height but wants to
	/// keep the perspective transform unchanges.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void UseHorizontalViewAngleOff()
	{
		vtkCamera_UseHorizontalViewAngleOff_157(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UseHorizontalViewAngleOn_158(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the UseHorizontalViewAngle instance variable. If
	/// set, the camera's view angle represents a horizontal view angle, rather
	/// than the default vertical view angle. This is useful if the application
	/// uses a display device which whose specs indicate a particular horizontal
	/// view angle, or if the application varies the window height but wants to
	/// keep the perspective transform unchanges.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void UseHorizontalViewAngleOn()
	{
		vtkCamera_UseHorizontalViewAngleOn_158(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UseOffAxisProjectionOff_159(HandleRef pThis);

	/// <summary>
	/// Set/Get use offaxis frustum.
	/// OffAxis frustum is used for off-axis frustum calculations specifically
	/// for stereo rendering.
	/// For reference see "High Resolution Virtual Reality", in Proc.
	/// SIGGRAPH '92, Computer Graphics, pages 195-202, 1992.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void UseOffAxisProjectionOff()
	{
		vtkCamera_UseOffAxisProjectionOff_159(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_UseOffAxisProjectionOn_160(HandleRef pThis);

	/// <summary>
	/// Set/Get use offaxis frustum.
	/// OffAxis frustum is used for off-axis frustum calculations specifically
	/// for stereo rendering.
	/// For reference see "High Resolution Virtual Reality", in Proc.
	/// SIGGRAPH '92, Computer Graphics, pages 195-202, 1992.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public virtual void UseOffAxisProjectionOn()
	{
		vtkCamera_UseOffAxisProjectionOn_160(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_ViewingRaysModified_161(HandleRef pThis);

	/// <summary>
	/// Mark that something has changed which requires the view rays
	/// to be recomputed.
	/// </summary>
	public void ViewingRaysModified()
	{
		vtkCamera_ViewingRaysModified_161(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_Yaw_162(HandleRef pThis, double angle);

	/// <summary>
	/// Rotate the focal point about the view up vector, using the camera's
	/// position as the center of rotation. Note that the view up vector is
	/// whatever was set via SetViewUp, and is not necessarily perpendicular
	/// to the direction of projection.  The result is a horizontal rotation
	/// of the scene.
	/// </summary>
	public void Yaw(double angle)
	{
		vtkCamera_Yaw_162(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCamera_Zoom_163(HandleRef pThis, double factor);

	/// <summary>
	/// In perspective mode, decrease the view angle by the specified factor.
	/// In parallel mode, decrease the parallel scale by the specified factor.
	/// A value greater than 1 is a zoom-in, a value less than 1 is a zoom-out.
	/// @note This setting is ignored when UseExplicitProjectionTransformMatrix
	/// is true.
	/// </summary>
	public void Zoom(double factor)
	{
		vtkCamera_Zoom_163(GetCppThis(), factor);
	}
}
