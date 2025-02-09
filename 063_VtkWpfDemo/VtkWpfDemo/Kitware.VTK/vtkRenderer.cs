using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderer
/// </summary>
/// <remarks>
///    abstract specification for renderers
///
/// vtkRenderer provides an abstract specification for renderers. A renderer
/// is an object that controls the rendering process for objects. Rendering
/// is the process of converting geometry, a specification for lights, and
/// a camera view into an image. vtkRenderer also performs coordinate
/// transformation between world coordinates, view coordinates (the computer
/// graphics rendering coordinate system), and display coordinates (the
/// actual screen coordinates on the display device). Certain advanced
/// rendering features such as two-sided lighting can also be controlled.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderWindow vtkActor vtkCamera vtkLight vtkVolume
/// </seealso>
public class vtkRenderer : vtkViewport
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderer()
	{
		MRClassNameKey = "class vtkRenderer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a vtkRenderer with a black background, a white ambient light,
	/// two-sided lighting turned on, a viewport of (0,0,1,1), and backface
	/// culling turned off.
	/// </summary>
	public new static vtkRenderer New()
	{
		vtkRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a vtkRenderer with a black background, a white ambient light,
	/// two-sided lighting turned on, a viewport of (0,0,1,1), and backface
	/// culling turned off.
	/// </summary>
	public vtkRenderer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRenderer_AddActor_01(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Add/Remove different types of props to the renderer.
	/// These methods are all synonyms to AddViewProp and RemoveViewProp.
	/// They are here for convenience and backwards compatibility.
	/// </summary>
	public void AddActor(vtkProp p)
	{
		vtkRenderer_AddActor_01(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_AddCuller_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add an culler to the list of cullers.
	/// </summary>
	public void AddCuller(vtkCuller arg0)
	{
		vtkRenderer_AddCuller_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_AddLight_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a light to the list of lights.
	/// </summary>
	public void AddLight(vtkLight arg0)
	{
		vtkRenderer_AddLight_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_AddVolume_04(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Add/Remove different types of props to the renderer.
	/// These methods are all synonyms to AddViewProp and RemoveViewProp.
	/// They are here for convenience and backwards compatibility.
	/// </summary>
	public void AddVolume(vtkProp p)
	{
		vtkRenderer_AddVolume_04(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_AutomaticLightCreationOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which disables the automatic light creation capability.
	/// Normally in VTK if no lights are associated with the renderer, then a light
	/// is automatically created. However, in special circumstances this feature is
	/// undesirable, so the following boolean is provided to disable automatic
	/// light creation. (Turn AutomaticLightCreation off if you do not want lights
	/// to be created.)
	/// </summary>
	public virtual void AutomaticLightCreationOff()
	{
		vtkRenderer_AutomaticLightCreationOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_AutomaticLightCreationOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which disables the automatic light creation capability.
	/// Normally in VTK if no lights are associated with the renderer, then a light
	/// is automatically created. However, in special circumstances this feature is
	/// undesirable, so the following boolean is provided to disable automatic
	/// light creation. (Turn AutomaticLightCreation off if you do not want lights
	/// to be created.)
	/// </summary>
	public virtual void AutomaticLightCreationOn()
	{
		vtkRenderer_AutomaticLightCreationOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_BackingStoreOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off using backing store. This may cause the re-rendering
	/// time to be slightly slower when the view changes. But it is
	/// much faster when the image has not changed, such as during an
	/// expose event.
	/// </summary>
	public virtual void BackingStoreOff()
	{
		vtkRenderer_BackingStoreOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_BackingStoreOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off using backing store. This may cause the re-rendering
	/// time to be slightly slower when the view changes. But it is
	/// much faster when the image has not changed, such as during an
	/// expose event.
	/// </summary>
	public virtual void BackingStoreOn()
	{
		vtkRenderer_BackingStoreOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_CaptureGL2PSSpecialProp_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// This function is called to capture an instance of vtkProp that requires
	/// special handling during vtkRenderWindow::CaptureGL2PSSpecialProps().
	/// </summary>
	public int CaptureGL2PSSpecialProp(vtkProp arg0)
	{
		return vtkRenderer_CaptureGL2PSSpecialProp_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_Clear_10(HandleRef pThis);

	/// <summary>
	/// Clear the image to the background color.
	/// </summary>
	public virtual void Clear()
	{
		vtkRenderer_Clear_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ClearLights_11(HandleRef pThis);

	/// <summary>
	/// Internal method temporarily removes lights before reloading them
	/// into graphics pipeline.
	/// </summary>
	public virtual void ClearLights()
	{
		vtkRenderer_ClearLights_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ComputeVisiblePropBounds_12(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Compute the bounding box of all the visible props
	/// Used in ResetCamera() and ResetCameraClippingRange()
	/// </summary>
	public void ComputeVisiblePropBounds(IntPtr bounds)
	{
		vtkRenderer_ComputeVisiblePropBounds_12(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_ComputeVisiblePropBounds_13(HandleRef pThis);

	/// <summary>
	/// Wrapper-friendly version of ComputeVisiblePropBounds
	/// </summary>
	public double[] ComputeVisiblePropBounds()
	{
		IntPtr intPtr = vtkRenderer_ComputeVisiblePropBounds_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_CreateLight_14(HandleRef pThis);

	/// <summary>
	/// Create and add a light to renderer.
	/// </summary>
	public void CreateLight()
	{
		vtkRenderer_CreateLight_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_DeviceRender_15(HandleRef pThis);

	/// <summary>
	/// Create an image. Subclasses of vtkRenderer must implement this method.
	/// </summary>
	public virtual void DeviceRender()
	{
		vtkRenderer_DeviceRender_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_DeviceRenderOpaqueGeometry_16(HandleRef pThis, HandleRef fbo);

	/// <summary>
	/// Render opaque polygonal geometry. Default implementation just calls
	/// UpdateOpaquePolygonalGeometry().
	/// Subclasses of vtkRenderer that can deal with, e.g. hidden line removal must
	/// override this method.
	/// </summary>
	public virtual void DeviceRenderOpaqueGeometry(vtkFrameBufferObjectBase fbo)
	{
		vtkRenderer_DeviceRenderOpaqueGeometry_16(GetCppThis(), fbo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_DeviceRenderTranslucentPolygonalGeometry_17(HandleRef pThis, HandleRef fbo);

	/// <summary>
	/// Render translucent polygonal geometry. Default implementation just call
	/// UpdateTranslucentPolygonalGeometry().
	/// Subclasses of vtkRenderer that can deal with depth peeling must
	/// override this method.
	/// If UseDepthPeeling and UseDepthPeelingForVolumes are true, volumetric data
	/// will be rendered here as well.
	/// It updates boolean ivar LastRenderingUsedDepthPeeling.
	/// </summary>
	public virtual void DeviceRenderTranslucentPolygonalGeometry(vtkFrameBufferObjectBase fbo)
	{
		vtkRenderer_DeviceRenderTranslucentPolygonalGeometry_17(GetCppThis(), fbo?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_DisplayToWorld_18(HandleRef pThis, HandleRef display, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convert a vtkVector3d from display space to world space.
	/// </summary>
	public vtkVector3d DisplayToWorld(vtkVector3d display)
	{
		vtkVector3d result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_DisplayToWorld_18(GetCppThis(), display?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_DrawOff_19(HandleRef pThis);

	/// <summary>
	/// When this flag is off, render commands are ignored.  It is used to either
	/// multiplex a vtkRenderWindow or render only part of a vtkRenderWindow.
	/// By default, Draw is on.
	/// </summary>
	public virtual void DrawOff()
	{
		vtkRenderer_DrawOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_DrawOn_20(HandleRef pThis);

	/// <summary>
	/// When this flag is off, render commands are ignored.  It is used to either
	/// multiplex a vtkRenderWindow or render only part of a vtkRenderWindow.
	/// By default, Draw is on.
	/// </summary>
	public virtual void DrawOn()
	{
		vtkRenderer_DrawOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_EraseOff_21(HandleRef pThis);

	/// <summary>
	/// When this flag is off, the renderer will not erase the background
	/// or the Zbuffer.  It is used to have overlapping renderers.
	/// Both the RenderWindow Erase and Render Erase must be on
	/// for the camera to clear the renderer.  By default, Erase is on.
	/// </summary>
	public virtual void EraseOff()
	{
		vtkRenderer_EraseOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_EraseOn_22(HandleRef pThis);

	/// <summary>
	/// When this flag is off, the renderer will not erase the background
	/// or the Zbuffer.  It is used to have overlapping renderers.
	/// Both the RenderWindow Erase and Render Erase must be on
	/// for the camera to clear the renderer.  By default, Erase is on.
	/// </summary>
	public virtual void EraseOn()
	{
		vtkRenderer_EraseOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetActiveCamera_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the current camera. If there is not camera assigned to the
	/// renderer already, a new one is created automatically.
	/// This does *not* reset the camera.
	/// </summary>
	public vtkCamera GetActiveCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetActiveCamera_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRenderer_GetActors_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return any actors in this renderer.
	/// </summary>
	public vtkActorCollection GetActors()
	{
		vtkActorCollection vtkActorCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetActors_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActorCollection2 = (vtkActorCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActorCollection2.Register(null);
			}
		}
		return vtkActorCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetAllocatedRenderTime_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the amount of time this renderer is allowed to spend
	/// rendering its scene. This is used by vtkLODActor's.
	/// </summary>
	public virtual double GetAllocatedRenderTime()
	{
		return vtkRenderer_GetAllocatedRenderTime_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetAmbient_26(HandleRef pThis);

	/// <summary>
	/// Set the intensity of ambient lighting.
	/// </summary>
	public virtual double[] GetAmbient()
	{
		IntPtr intPtr = vtkRenderer_GetAmbient_26(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_GetAmbient_27(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the intensity of ambient lighting.
	/// </summary>
	public virtual void GetAmbient(IntPtr data)
	{
		vtkRenderer_GetAmbient_27(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetAutomaticLightCreation_28(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which disables the automatic light creation capability.
	/// Normally in VTK if no lights are associated with the renderer, then a light
	/// is automatically created. However, in special circumstances this feature is
	/// undesirable, so the following boolean is provided to disable automatic
	/// light creation. (Turn AutomaticLightCreation off if you do not want lights
	/// to be created.)
	/// </summary>
	public virtual int GetAutomaticLightCreation()
	{
		return vtkRenderer_GetAutomaticLightCreation_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetBackgroundTexture_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the texture to be used for the monocular or stereo left eye
	/// background. If set and enabled this gets the priority over the gradient
	/// background.
	/// </summary>
	public virtual vtkTexture GetBackgroundTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetBackgroundTexture_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetBackingStore_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off using backing store. This may cause the re-rendering
	/// time to be slightly slower when the view changes. But it is
	/// much faster when the image has not changed, such as during an
	/// expose event.
	/// </summary>
	public virtual int GetBackingStore()
	{
		return vtkRenderer_GetBackingStore_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetClippingRangeExpansion_31(HandleRef pThis);

	/// <summary>
	/// Specify enlargement of bounds when resetting the
	/// camera clipping range.  By default the range is not expanded by
	/// any percent of the (far - near) on the near and far sides
	/// </summary>
	public virtual double GetClippingRangeExpansion()
	{
		return vtkRenderer_GetClippingRangeExpansion_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetClippingRangeExpansionMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Specify enlargement of bounds when resetting the
	/// camera clipping range.  By default the range is not expanded by
	/// any percent of the (far - near) on the near and far sides
	/// </summary>
	public virtual double GetClippingRangeExpansionMaxValue()
	{
		return vtkRenderer_GetClippingRangeExpansionMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetClippingRangeExpansionMinValue_33(HandleRef pThis);

	/// <summary>
	/// Specify enlargement of bounds when resetting the
	/// camera clipping range.  By default the range is not expanded by
	/// any percent of the (far - near) on the near and far sides
	/// </summary>
	public virtual double GetClippingRangeExpansionMinValue()
	{
		return vtkRenderer_GetClippingRangeExpansionMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetCullers_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the collection of cullers.
	/// </summary>
	public vtkCullerCollection GetCullers()
	{
		vtkCullerCollection vtkCullerCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetCullers_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCullerCollection2 = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCullerCollection2.Register(null);
			}
		}
		return vtkCullerCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetDelegate_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a custom Render call. Allows to hook a Render call from an
	/// external project.It will be used in place of vtkRenderer::Render() if it
	/// is not NULL and its Used ivar is set to true.
	/// Initial value is NULL.
	/// </summary>
	public virtual vtkRendererDelegate GetDelegate()
	{
		vtkRendererDelegate vtkRendererDelegate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetDelegate_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRendererDelegate2 = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRendererDelegate2.Register(null);
			}
		}
		return vtkRendererDelegate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetDraw_36(HandleRef pThis);

	/// <summary>
	/// When this flag is off, render commands are ignored.  It is used to either
	/// multiplex a vtkRenderWindow or render only part of a vtkRenderWindow.
	/// By default, Draw is on.
	/// </summary>
	public virtual int GetDraw()
	{
		return vtkRenderer_GetDraw_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetEnvironmentRight_37(HandleRef pThis);

	/// <summary>
	/// Set/Get the environment right vector.
	/// </summary>
	public virtual double[] GetEnvironmentRight()
	{
		IntPtr intPtr = vtkRenderer_GetEnvironmentRight_37(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_GetEnvironmentRight_38(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the environment right vector.
	/// </summary>
	public virtual void GetEnvironmentRight(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkRenderer_GetEnvironmentRight_38(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_GetEnvironmentRight_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the environment right vector.
	/// </summary>
	public virtual void GetEnvironmentRight(IntPtr _arg)
	{
		vtkRenderer_GetEnvironmentRight_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetEnvironmentTexture_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the environment texture used for image based lighting.
	/// This texture is supposed to represent the scene background.
	/// If it is not a cubemap, the texture is supposed to represent an equirectangular projection.
	/// If used with raytracing backends, the texture must be an equirectangular projection and must be
	/// constructed with a valid vtkImageData.
	/// Warning, this texture must be expressed in linear color space.
	/// If the texture is in sRGB color space, set the color flag on the texture or
	/// set the argument isSRGB to true.
	/// @sa vtkTexture::UseSRGBColorSpaceOn
	/// </summary>
	public virtual vtkTexture GetEnvironmentTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetEnvironmentTexture_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetEnvironmentUp_41(HandleRef pThis);

	/// <summary>
	/// Set/Get the environment up vector.
	/// </summary>
	public virtual double[] GetEnvironmentUp()
	{
		IntPtr intPtr = vtkRenderer_GetEnvironmentUp_41(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_GetEnvironmentUp_42(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the environment up vector.
	/// </summary>
	public virtual void GetEnvironmentUp(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkRenderer_GetEnvironmentUp_42(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_GetEnvironmentUp_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the environment up vector.
	/// </summary>
	public virtual void GetEnvironmentUp(IntPtr _arg)
	{
		vtkRenderer_GetEnvironmentUp_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetErase_44(HandleRef pThis);

	/// <summary>
	/// When this flag is off, the renderer will not erase the background
	/// or the Zbuffer.  It is used to have overlapping renderers.
	/// Both the RenderWindow Erase and Render Erase must be on
	/// for the camera to clear the renderer.  By default, Erase is on.
	/// </summary>
	public virtual int GetErase()
	{
		return vtkRenderer_GetErase_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetFXAAOptions_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The configuration object for FXAA antialiasing.
	/// </summary>
	public virtual vtkFXAAOptions GetFXAAOptions()
	{
		vtkFXAAOptions vtkFXAAOptions2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetFXAAOptions_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFXAAOptions2 = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFXAAOptions2.Register(null);
			}
		}
		return vtkFXAAOptions2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetInformation_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the information object associated with this algorithm.
	/// </summary>
	public virtual vtkInformation GetInformation()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetInformation_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkRenderer_GetInteractive_47(HandleRef pThis);

	/// <summary>
	/// Turn on/off interactive status.  An interactive renderer is one that
	/// can receive events from an interactor.  Should only be set if
	/// there are multiple renderers in the same section of the viewport.
	/// </summary>
	public virtual int GetInteractive()
	{
		return vtkRenderer_GetInteractive_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetLastRenderTimeInSeconds_48(HandleRef pThis);

	/// <summary>
	/// Get the time required, in seconds, for the last Render call.
	/// </summary>
	public virtual double GetLastRenderTimeInSeconds()
	{
		return vtkRenderer_GetLastRenderTimeInSeconds_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetLastRenderingUsedDepthPeeling_49(HandleRef pThis);

	/// <summary>
	/// Tells if the last call to DeviceRenderTranslucentPolygonalGeometry()
	/// actually used depth peeling.
	/// Initial value is false.
	/// </summary>
	public virtual int GetLastRenderingUsedDepthPeeling()
	{
		return vtkRenderer_GetLastRenderingUsedDepthPeeling_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetLayer_50(HandleRef pThis);

	/// <summary>
	/// Set/Get the layer that this renderer belongs to.  This is only used if
	/// there are layered renderers.
	///
	/// Note: Changing the layer will update the PreserveColorBuffer setting. If
	/// the layer is 0, PreserveColorBuffer will be set to false, making the
	/// bottom renderer opaque. If the layer is non-zero, PreserveColorBuffer will
	/// be set to true, giving the renderer a transparent background. If other
	/// PreserveColorBuffer configurations are desired, they must be adjusted after
	/// the layer is set.
	/// </summary>
	public virtual int GetLayer()
	{
		return vtkRenderer_GetLayer_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetLeftBackgroundTexture_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the texture to be used for the monocular or stereo left eye
	/// background. If set and enabled this gets the priority over the gradient
	/// background.
	/// </summary>
	public vtkTexture GetLeftBackgroundTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetLeftBackgroundTexture_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetLightFollowCamera_52(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic repositioning of lights as the camera moves.
	/// If LightFollowCamera is on, lights that are designated as Headlights
	/// or CameraLights will be adjusted to move with this renderer's camera.
	/// If LightFollowCamera is off, the lights will not be adjusted.
	///
	/// (Note: In previous versions of vtk, this light-tracking
	/// functionality was part of the interactors, not the renderer. For
	/// backwards compatibility, the older, more limited interactor
	/// behavior is enabled by default. To disable this mode, turn the
	/// interactor's LightFollowCamera flag OFF, and leave the renderer's
	/// LightFollowCamera flag ON.)
	/// </summary>
	public virtual int GetLightFollowCamera()
	{
		return vtkRenderer_GetLightFollowCamera_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetLights_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the collection of lights.
	/// </summary>
	public vtkLightCollection GetLights()
	{
		vtkLightCollection vtkLightCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetLights_53(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLightCollection2 = (vtkLightCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLightCollection2.Register(null);
			}
		}
		return vtkLightCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkRenderer_GetMTime_54(HandleRef pThis);

	/// <summary>
	/// Return the MTime of the renderer also considering its ivars.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkRenderer_GetMTime_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetMaximumNumberOfPeels_55(HandleRef pThis);

	/// <summary>
	/// In case of depth peeling, define the maximum number of peeling layers.
	/// Initial value is 4. A special value of 0 means no maximum limit.
	/// It has to be a positive value.
	/// </summary>
	public virtual int GetMaximumNumberOfPeels()
	{
		return vtkRenderer_GetMaximumNumberOfPeels_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetNearClippingPlaneTolerance_56(HandleRef pThis);

	/// <summary>
	/// Specify tolerance for near clipping plane distance to the camera as a
	/// percentage of the far clipping plane distance. By default this will be
	/// set to 0.01 for 16 bit zbuffers and 0.001 for higher depth z buffers
	/// </summary>
	public virtual double GetNearClippingPlaneTolerance()
	{
		return vtkRenderer_GetNearClippingPlaneTolerance_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetNearClippingPlaneToleranceMaxValue_57(HandleRef pThis);

	/// <summary>
	/// Specify tolerance for near clipping plane distance to the camera as a
	/// percentage of the far clipping plane distance. By default this will be
	/// set to 0.01 for 16 bit zbuffers and 0.001 for higher depth z buffers
	/// </summary>
	public virtual double GetNearClippingPlaneToleranceMaxValue()
	{
		return vtkRenderer_GetNearClippingPlaneToleranceMaxValue_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetNearClippingPlaneToleranceMinValue_58(HandleRef pThis);

	/// <summary>
	/// Specify tolerance for near clipping plane distance to the camera as a
	/// percentage of the far clipping plane distance. By default this will be
	/// set to 0.01 for 16 bit zbuffers and 0.001 for higher depth z buffers
	/// </summary>
	public virtual double GetNearClippingPlaneToleranceMinValue()
	{
		return vtkRenderer_GetNearClippingPlaneToleranceMinValue_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderer_GetNumberOfGenerationsFromBase_59(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderer_GetNumberOfGenerationsFromBase_59(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderer_GetNumberOfGenerationsFromBaseType_60(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderer_GetNumberOfGenerationsFromBaseType_60(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetNumberOfPropsRendered_61(HandleRef pThis);

	/// <summary>
	/// Should be used internally only during a render
	/// Get the number of props that were rendered using a
	/// RenderOpaqueGeometry or RenderTranslucentPolygonalGeometry call.
	/// This is used to know if something is in the frame buffer.
	/// </summary>
	public virtual int GetNumberOfPropsRendered()
	{
		return vtkRenderer_GetNumberOfPropsRendered_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetOcclusionRatio_62(HandleRef pThis);

	/// <summary>
	/// In case of use of depth peeling technique for rendering translucent
	/// material, define the threshold under which the algorithm stops to
	/// iterate over peel layers. This is the ratio of the number of pixels
	/// that have been touched by the last layer over the total number of pixels
	/// of the viewport area.
	/// Initial value is 0.0, meaning rendering have to be exact. Greater values
	/// may speed-up the rendering with small impact on the quality.
	/// </summary>
	public virtual double GetOcclusionRatio()
	{
		return vtkRenderer_GetOcclusionRatio_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetOcclusionRatioMaxValue_63(HandleRef pThis);

	/// <summary>
	/// In case of use of depth peeling technique for rendering translucent
	/// material, define the threshold under which the algorithm stops to
	/// iterate over peel layers. This is the ratio of the number of pixels
	/// that have been touched by the last layer over the total number of pixels
	/// of the viewport area.
	/// Initial value is 0.0, meaning rendering have to be exact. Greater values
	/// may speed-up the rendering with small impact on the quality.
	/// </summary>
	public virtual double GetOcclusionRatioMaxValue()
	{
		return vtkRenderer_GetOcclusionRatioMaxValue_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetOcclusionRatioMinValue_64(HandleRef pThis);

	/// <summary>
	/// In case of use of depth peeling technique for rendering translucent
	/// material, define the threshold under which the algorithm stops to
	/// iterate over peel layers. This is the ratio of the number of pixels
	/// that have been touched by the last layer over the total number of pixels
	/// of the viewport area.
	/// Initial value is 0.0, meaning rendering have to be exact. Greater values
	/// may speed-up the rendering with small impact on the quality.
	/// </summary>
	public virtual double GetOcclusionRatioMinValue()
	{
		return vtkRenderer_GetOcclusionRatioMinValue_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetPass_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, wireframe
	/// geometry will be drawn using hidden line removal.
	/// </summary>
	public virtual vtkRenderPass GetPass()
	{
		vtkRenderPass vtkRenderPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetPass_65(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderPass2 = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderPass2.Register(null);
			}
		}
		return vtkRenderPass2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetPreserveColorBuffer_66(HandleRef pThis);

	/// <summary>
	/// By default, the renderer at layer 0 is opaque, and all non-zero layer
	/// renderers are transparent. This flag allows this behavior to be overridden.
	/// If true, this setting will force the renderer to preserve the existing
	/// color buffer regardless of layer. If false, it will always be cleared at
	/// the start of rendering.
	///
	/// This flag influences the Transparent() method, and is updated by calls to
	/// SetLayer(). For this reason it should only be set after changing the layer.
	/// </summary>
	public virtual int GetPreserveColorBuffer()
	{
		return vtkRenderer_GetPreserveColorBuffer_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetPreserveDepthBuffer_67(HandleRef pThis);

	/// <summary>
	/// By default, the depth buffer is reset for each renderer. If this flag is
	/// true, this renderer will use the existing depth buffer for its rendering.
	/// </summary>
	public virtual int GetPreserveDepthBuffer()
	{
		return vtkRenderer_GetPreserveDepthBuffer_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetRenderWindow_68(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the rendering window in which to draw. This is automatically set
	/// when the renderer is created by MakeRenderer.  The user probably
	/// shouldn't ever need to call this method.
	/// </summary>
	public vtkRenderWindow GetRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetRenderWindow_68(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetRightBackgroundTexture_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the texture to be used for the right eye background. If set
	/// and enabled this gets the priority over the gradient background.
	/// </summary>
	public virtual vtkTexture GetRightBackgroundTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetRightBackgroundTexture_69(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetSSAOBias_70(HandleRef pThis);

	/// <summary>
	/// When using SSAO, define the bias when comparing samples.
	/// Default is 0.01
	/// </summary>
	public virtual double GetSSAOBias()
	{
		return vtkRenderer_GetSSAOBias_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderer_GetSSAOBlur_71(HandleRef pThis);

	/// <summary>
	/// When using SSAO, define blurring of the ambient occlusion.
	/// Blurring can help to improve the result if samples number is low.
	/// Default is false
	/// </summary>
	public virtual bool GetSSAOBlur()
	{
		return (vtkRenderer_GetSSAOBlur_71(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkRenderer_GetSSAOKernelSize_72(HandleRef pThis);

	/// <summary>
	/// When using SSAO, define the number of samples.
	/// Default is 32
	/// </summary>
	public virtual uint GetSSAOKernelSize()
	{
		return vtkRenderer_GetSSAOKernelSize_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetSSAORadius_73(HandleRef pThis);

	/// <summary>
	/// When using SSAO, define the SSAO hemisphere radius.
	/// Default is 0.5
	/// </summary>
	public virtual double GetSSAORadius()
	{
		return vtkRenderer_GetSSAORadius_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetSelector_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the current hardware selector. If the Selector is set, it implies the
	/// current render pass is for selection. Mappers/Properties may choose to
	/// behave differently when rendering for hardware selection.
	/// </summary>
	public virtual vtkHardwareSelector GetSelector()
	{
		vtkHardwareSelector vtkHardwareSelector2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetSelector_74(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHardwareSelector2 = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHardwareSelector2.Register(null);
			}
		}
		return vtkHardwareSelector2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderer_GetTexturedBackground_75(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should have a textured background.
	/// Default is off.
	/// </summary>
	public virtual bool GetTexturedBackground()
	{
		return (vtkRenderer_GetTexturedBackground_75(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetTiledAspectRatio_76(HandleRef pThis);

	/// <summary>
	/// Compute the aspect ratio of this renderer for the current tile. When
	/// tiled displays are used the aspect ratio of the renderer for a given
	/// tile may be different that the aspect ratio of the renderer when rendered
	/// in it entirety
	/// </summary>
	public double GetTiledAspectRatio()
	{
		return vtkRenderer_GetTiledAspectRatio_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetTimeFactor_77(HandleRef pThis);

	/// <summary>
	/// Get the ratio between allocated time and actual render time.
	/// TimeFactor has been taken out of the render process.
	/// It is still computed in case someone finds it useful.
	/// It may be taken away in the future.
	/// </summary>
	public virtual double GetTimeFactor()
	{
		return vtkRenderer_GetTimeFactor_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetTwoSidedLighting_78(HandleRef pThis);

	/// <summary>
	/// Turn on/off two-sided lighting of surfaces. If two-sided lighting is
	/// off, then only the side of the surface facing the light(s) will be lit,
	/// and the other side dark. If two-sided lighting on, both sides of the
	/// surface will be lit.
	/// </summary>
	public virtual int GetTwoSidedLighting()
	{
		return vtkRenderer_GetTwoSidedLighting_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetUseDepthPeeling_79(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering of translucent material with depth peeling
	/// technique. The render window must have alpha bits (ie call
	/// SetAlphaBitPlanes(1)) and no multisample buffer (ie call
	/// SetMultiSamples(0) ) to support depth peeling.
	/// If UseDepthPeeling is on and the GPU supports it, depth peeling is used
	/// for rendering translucent materials.
	/// If UseDepthPeeling is off, alpha blending is used.
	/// Initial value is off.
	/// </summary>
	public virtual int GetUseDepthPeeling()
	{
		return vtkRenderer_GetUseDepthPeeling_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderer_GetUseDepthPeelingForVolumes_80(HandleRef pThis);

	/// <summary>
	/// This flag is on and the GPU supports it, depth-peel volumes along with
	/// the translucent geometry. Only supported on OpenGL2 with dual-depth
	/// peeling. Default is false.
	/// </summary>
	public virtual bool GetUseDepthPeelingForVolumes()
	{
		return (vtkRenderer_GetUseDepthPeelingForVolumes_80(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderer_GetUseFXAA_81(HandleRef pThis);

	/// <summary>
	/// Turn on/off FXAA anti-aliasing, if supported. Initial value is off.
	/// </summary>
	public virtual bool GetUseFXAA()
	{
		return (vtkRenderer_GetUseFXAA_81(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetUseHiddenLineRemoval_82(HandleRef pThis);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, wireframe
	/// geometry will be drawn using hidden line removal.
	/// </summary>
	public virtual int GetUseHiddenLineRemoval()
	{
		return vtkRenderer_GetUseHiddenLineRemoval_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderer_GetUseImageBasedLighting_83(HandleRef pThis);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, image based
	/// lighting is enabled and surface rendering displays environment reflections.
	/// The input cube map have to be set with SetEnvironmentCubeMap.
	/// If not cubemap is specified, this feature is disable.
	/// </summary>
	public virtual bool GetUseImageBasedLighting()
	{
		return (vtkRenderer_GetUseImageBasedLighting_83(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderer_GetUseSSAO_84(HandleRef pThis);

	/// <summary>
	/// Enable or disable Screen Space Ambient Occlusion.
	/// SSAO darkens some pixels to improve depth perception.
	/// </summary>
	public virtual bool GetUseSSAO()
	{
		return (vtkRenderer_GetUseSSAO_84(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_GetUseShadows_85(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering of shadows if supported
	/// Initial value is off.
	/// </summary>
	public virtual int GetUseShadows()
	{
		return vtkRenderer_GetUseShadows_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetVTKWindow_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the rendering window in which to draw. This is automatically set
	/// when the renderer is created by MakeRenderer.  The user probably
	/// shouldn't ever need to call this method.
	/// </summary>
	public override vtkWindow GetVTKWindow()
	{
		vtkWindow vtkWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetVTKWindow_86(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWindow2 = (vtkWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWindow2.Register(null);
			}
		}
		return vtkWindow2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_GetVolumes_87(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the collection of volumes.
	/// </summary>
	public vtkVolumeCollection GetVolumes()
	{
		vtkVolumeCollection vtkVolumeCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_GetVolumes_87(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeCollection2 = (vtkVolumeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeCollection2.Register(null);
			}
		}
		return vtkVolumeCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderer_GetZ_88(HandleRef pThis, int x, int y);

	/// <summary>
	/// Given a pixel location, return the Z value. The z value is
	/// normalized (0,1) between the front and back clipping planes.
	/// </summary>
	public double GetZ(int x, int y)
	{
		return vtkRenderer_GetZ_88(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_InteractiveOff_89(HandleRef pThis);

	/// <summary>
	/// Turn on/off interactive status.  An interactive renderer is one that
	/// can receive events from an interactor.  Should only be set if
	/// there are multiple renderers in the same section of the viewport.
	/// </summary>
	public virtual void InteractiveOff()
	{
		vtkRenderer_InteractiveOff_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_InteractiveOn_90(HandleRef pThis);

	/// <summary>
	/// Turn on/off interactive status.  An interactive renderer is one that
	/// can receive events from an interactor.  Should only be set if
	/// there are multiple renderers in the same section of the viewport.
	/// </summary>
	public virtual void InteractiveOn()
	{
		vtkRenderer_InteractiveOn_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_IsA_91(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderer_IsA_91(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_IsActiveCameraCreated_92(HandleRef pThis);

	/// <summary>
	/// This method returns 1 if the ActiveCamera has already been set or
	/// automatically created by the renderer. It returns 0 if the
	/// ActiveCamera does not yet exist.
	/// </summary>
	public int IsActiveCameraCreated()
	{
		return vtkRenderer_IsActiveCameraCreated_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_IsTypeOf_93(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderer_IsTypeOf_93(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_LightFollowCameraOff_94(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic repositioning of lights as the camera moves.
	/// If LightFollowCamera is on, lights that are designated as Headlights
	/// or CameraLights will be adjusted to move with this renderer's camera.
	/// If LightFollowCamera is off, the lights will not be adjusted.
	///
	/// (Note: In previous versions of vtk, this light-tracking
	/// functionality was part of the interactors, not the renderer. For
	/// backwards compatibility, the older, more limited interactor
	/// behavior is enabled by default. To disable this mode, turn the
	/// interactor's LightFollowCamera flag OFF, and leave the renderer's
	/// LightFollowCamera flag ON.)
	/// </summary>
	public virtual void LightFollowCameraOff()
	{
		vtkRenderer_LightFollowCameraOff_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_LightFollowCameraOn_95(HandleRef pThis);

	/// <summary>
	/// Turn on/off the automatic repositioning of lights as the camera moves.
	/// If LightFollowCamera is on, lights that are designated as Headlights
	/// or CameraLights will be adjusted to move with this renderer's camera.
	/// If LightFollowCamera is off, the lights will not be adjusted.
	///
	/// (Note: In previous versions of vtk, this light-tracking
	/// functionality was part of the interactors, not the renderer. For
	/// backwards compatibility, the older, more limited interactor
	/// behavior is enabled by default. To disable this mode, turn the
	/// interactor's LightFollowCamera flag OFF, and leave the renderer's
	/// LightFollowCamera flag ON.)
	/// </summary>
	public virtual void LightFollowCameraOn()
	{
		vtkRenderer_LightFollowCameraOn_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_MakeCamera_96(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new Camera sutible for use with this type of Renderer.
	/// For example, a vtkMesaRenderer should create a vtkMesaCamera
	/// in this function.   The default is to just call vtkCamera::New.
	/// </summary>
	public virtual vtkCamera MakeCamera()
	{
		vtkCamera vtkCamera2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_MakeCamera_96(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRenderer_MakeLight_97(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new Light sutible for use with this type of Renderer.
	/// For example, a vtkMesaRenderer should create a vtkMesaLight
	/// in this function.   The default is to just call vtkLight::New.
	/// </summary>
	public virtual vtkLight MakeLight()
	{
		vtkLight vtkLight2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_MakeLight_97(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLight2 = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLight2.Register(null);
			}
		}
		return vtkLight2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_NewInstance_99(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRenderer NewInstance()
	{
		vtkRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_NewInstance_99(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_PickProp_100(HandleRef pThis, double selectionX, double selectionY, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the prop (via a vtkAssemblyPath) that has the highest z value
	/// at the given x, y position in the viewport.  Basically, the top most
	/// prop that renders the pixel at selectionX, selectionY will be returned.
	/// If nothing was picked then NULL is returned.  This method selects from
	/// the renderer's Prop list.
	/// </summary>
	public override vtkAssemblyPath PickProp(double selectionX, double selectionY)
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_PickProp_100(GetCppThis(), selectionX, selectionY, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_PickProp_101(HandleRef pThis, double selectionX1, double selectionY1, double selectionX2, double selectionY2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the prop (via a vtkAssemblyPath) that has the highest z value
	/// at the given x, y position in the viewport.  Basically, the top most
	/// prop that renders the pixel at selectionX, selectionY will be returned.
	/// If nothing was picked then NULL is returned.  This method selects from
	/// the renderer's Prop list.
	/// </summary>
	public override vtkAssemblyPath PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_PickProp_101(GetCppThis(), selectionX1, selectionY1, selectionX2, selectionY2, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_PoseToView_102(HandleRef pThis, ref double wx, ref double wy, ref double wz);

	/// <summary>
	/// Convert to from pose coordinates
	/// </summary>
	public override void PoseToView(ref double wx, ref double wy, ref double wz)
	{
		vtkRenderer_PoseToView_102(GetCppThis(), ref wx, ref wy, ref wz);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_PoseToWorld_103(HandleRef pThis, ref double wx, ref double wy, ref double wz);

	/// <summary>
	/// Convert to from pose coordinates
	/// </summary>
	public override void PoseToWorld(ref double wx, ref double wy, ref double wz)
	{
		vtkRenderer_PoseToWorld_103(GetCppThis(), ref wx, ref wy, ref wz);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_PreserveColorBufferOff_104(HandleRef pThis);

	/// <summary>
	/// By default, the renderer at layer 0 is opaque, and all non-zero layer
	/// renderers are transparent. This flag allows this behavior to be overridden.
	/// If true, this setting will force the renderer to preserve the existing
	/// color buffer regardless of layer. If false, it will always be cleared at
	/// the start of rendering.
	///
	/// This flag influences the Transparent() method, and is updated by calls to
	/// SetLayer(). For this reason it should only be set after changing the layer.
	/// </summary>
	public virtual void PreserveColorBufferOff()
	{
		vtkRenderer_PreserveColorBufferOff_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_PreserveColorBufferOn_105(HandleRef pThis);

	/// <summary>
	/// By default, the renderer at layer 0 is opaque, and all non-zero layer
	/// renderers are transparent. This flag allows this behavior to be overridden.
	/// If true, this setting will force the renderer to preserve the existing
	/// color buffer regardless of layer. If false, it will always be cleared at
	/// the start of rendering.
	///
	/// This flag influences the Transparent() method, and is updated by calls to
	/// SetLayer(). For this reason it should only be set after changing the layer.
	/// </summary>
	public virtual void PreserveColorBufferOn()
	{
		vtkRenderer_PreserveColorBufferOn_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_PreserveDepthBufferOff_106(HandleRef pThis);

	/// <summary>
	/// By default, the depth buffer is reset for each renderer. If this flag is
	/// true, this renderer will use the existing depth buffer for its rendering.
	/// </summary>
	public virtual void PreserveDepthBufferOff()
	{
		vtkRenderer_PreserveDepthBufferOff_106(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_PreserveDepthBufferOn_107(HandleRef pThis);

	/// <summary>
	/// By default, the depth buffer is reset for each renderer. If this flag is
	/// true, this renderer will use the existing depth buffer for its rendering.
	/// </summary>
	public virtual void PreserveDepthBufferOn()
	{
		vtkRenderer_PreserveDepthBufferOn_107(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ReleaseGraphicsResources_108(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get whether this viewport should have a textured background.
	/// Default is off.
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkRenderer_ReleaseGraphicsResources_108(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_RemoveActor_109(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Add/Remove different types of props to the renderer.
	/// These methods are all synonyms to AddViewProp and RemoveViewProp.
	/// They are here for convenience and backwards compatibility.
	/// </summary>
	public void RemoveActor(vtkProp p)
	{
		vtkRenderer_RemoveActor_109(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_RemoveAllLights_110(HandleRef pThis);

	/// <summary>
	/// Remove all lights from the list of lights.
	/// </summary>
	public void RemoveAllLights()
	{
		vtkRenderer_RemoveAllLights_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_RemoveCuller_111(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove an actor from the list of cullers.
	/// </summary>
	public void RemoveCuller(vtkCuller arg0)
	{
		vtkRenderer_RemoveCuller_111(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_RemoveLight_112(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a light from the list of lights.
	/// </summary>
	public void RemoveLight(vtkLight arg0)
	{
		vtkRenderer_RemoveLight_112(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_RemoveVolume_113(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Add/Remove different types of props to the renderer.
	/// These methods are all synonyms to AddViewProp and RemoveViewProp.
	/// They are here for convenience and backwards compatibility.
	/// </summary>
	public void RemoveVolume(vtkProp p)
	{
		vtkRenderer_RemoveVolume_113(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_Render_114(HandleRef pThis);

	/// <summary>
	/// CALLED BY vtkRenderWindow ONLY. End-user pass your way and call
	/// vtkRenderWindow::Render().
	/// Create an image. This is a superclass method which will in turn
	/// call the DeviceRender method of Subclasses of vtkRenderer.
	/// </summary>
	public virtual void Render()
	{
		vtkRenderer_Render_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCamera_115(HandleRef pThis);

	/// <summary>
	/// Automatically set up the camera based on the visible actors.
	/// The camera will reposition itself to view the center point of the actors,
	/// and move along its initial view plane normal (i.e., vector defined from
	/// camera position to focal point) so that all of the actors can be seen.
	/// </summary>
	public virtual void ResetCamera()
	{
		vtkRenderer_ResetCamera_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCamera_116(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Automatically set up the camera based on a specified bounding box
	/// (xmin, xmax, ymin, ymax, zmin, zmax). Camera will reposition itself so
	/// that its focal point is the center of the bounding box, and adjust its
	/// distance and position to preserve its initial view plane normal
	/// (i.e., vector defined from camera position to focal point). Note: if
	/// the view plane is parallel to the view up axis, the view up axis will
	/// be reset to one of the three coordinate axes.
	/// </summary>
	public virtual void ResetCamera(IntPtr bounds)
	{
		vtkRenderer_ResetCamera_116(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCamera_117(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Alternative version of ResetCamera(bounds[6]);
	/// </summary>
	public virtual void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkRenderer_ResetCamera_117(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCameraClippingRange_118(HandleRef pThis);

	/// <summary>
	/// Reset the camera clipping range based on the bounds of the
	/// visible actors. This ensures that no props are cut off
	/// </summary>
	public virtual void ResetCameraClippingRange()
	{
		vtkRenderer_ResetCameraClippingRange_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCameraClippingRange_119(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Reset the camera clipping range based on a bounding box.
	/// </summary>
	public virtual void ResetCameraClippingRange(IntPtr bounds)
	{
		vtkRenderer_ResetCameraClippingRange_119(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCameraClippingRange_120(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Reset the camera clipping range based on a bounding box.
	/// </summary>
	public virtual void ResetCameraClippingRange(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkRenderer_ResetCameraClippingRange_120(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCameraScreenSpace_121(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Alternative version of ResetCameraScreenSpace(bounds[6]);
	/// </summary>
	public virtual void ResetCameraScreenSpace(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkRenderer_ResetCameraScreenSpace_121(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCameraScreenSpace_122(HandleRef pThis);

	/// <summary>
	/// Automatically set up the camera based on the visible actors.
	/// Use a screen space bounding box to zoom closer to the data.
	/// </summary>
	public virtual void ResetCameraScreenSpace()
	{
		vtkRenderer_ResetCameraScreenSpace_122(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ResetCameraScreenSpace_123(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Automatically set up the camera based on a specified bounding box
	/// (xmin, xmax, ymin, ymax, zmin, zmax).
	/// Use a screen space bounding box to zoom closer to the data.
	/// </summary>
	public virtual void ResetCameraScreenSpace(IntPtr bounds)
	{
		vtkRenderer_ResetCameraScreenSpace_123(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SSAOBlurOff_124(HandleRef pThis);

	/// <summary>
	/// When using SSAO, define blurring of the ambient occlusion.
	/// Blurring can help to improve the result if samples number is low.
	/// Default is false
	/// </summary>
	public virtual void SSAOBlurOff()
	{
		vtkRenderer_SSAOBlurOff_124(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SSAOBlurOn_125(HandleRef pThis);

	/// <summary>
	/// When using SSAO, define blurring of the ambient occlusion.
	/// Blurring can help to improve the result if samples number is low.
	/// Default is false
	/// </summary>
	public virtual void SSAOBlurOn()
	{
		vtkRenderer_SSAOBlurOn_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderer_SafeDownCast_126(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderer SafeDownCast(vtkObjectBase o)
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderer_SafeDownCast_126(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetActiveCamera_127(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the camera to use for this renderer.
	/// </summary>
	public void SetActiveCamera(vtkCamera arg0)
	{
		vtkRenderer_SetActiveCamera_127(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetAllocatedRenderTime_128(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the amount of time this renderer is allowed to spend
	/// rendering its scene. This is used by vtkLODActor's.
	/// </summary>
	public virtual void SetAllocatedRenderTime(double _arg)
	{
		vtkRenderer_SetAllocatedRenderTime_128(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetAmbient_129(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the intensity of ambient lighting.
	/// </summary>
	public virtual void SetAmbient(double _arg1, double _arg2, double _arg3)
	{
		vtkRenderer_SetAmbient_129(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetAmbient_130(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the intensity of ambient lighting.
	/// </summary>
	public virtual void SetAmbient(IntPtr _arg)
	{
		vtkRenderer_SetAmbient_130(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetAutomaticLightCreation_131(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off a flag which disables the automatic light creation capability.
	/// Normally in VTK if no lights are associated with the renderer, then a light
	/// is automatically created. However, in special circumstances this feature is
	/// undesirable, so the following boolean is provided to disable automatic
	/// light creation. (Turn AutomaticLightCreation off if you do not want lights
	/// to be created.)
	/// </summary>
	public virtual void SetAutomaticLightCreation(int _arg)
	{
		vtkRenderer_SetAutomaticLightCreation_131(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetBackgroundTexture_132(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the texture to be used for the monocular or stereo left eye
	/// background. If set and enabled this gets the priority over the gradient
	/// background.
	/// </summary>
	public virtual void SetBackgroundTexture(vtkTexture arg0)
	{
		vtkRenderer_SetBackgroundTexture_132(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetBackingStore_133(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off using backing store. This may cause the re-rendering
	/// time to be slightly slower when the view changes. But it is
	/// much faster when the image has not changed, such as during an
	/// expose event.
	/// </summary>
	public virtual void SetBackingStore(int _arg)
	{
		vtkRenderer_SetBackingStore_133(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetClippingRangeExpansion_134(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify enlargement of bounds when resetting the
	/// camera clipping range.  By default the range is not expanded by
	/// any percent of the (far - near) on the near and far sides
	/// </summary>
	public virtual void SetClippingRangeExpansion(double _arg)
	{
		vtkRenderer_SetClippingRangeExpansion_134(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetDelegate_135(HandleRef pThis, HandleRef d);

	/// <summary>
	/// Set/Get a custom Render call. Allows to hook a Render call from an
	/// external project.It will be used in place of vtkRenderer::Render() if it
	/// is not NULL and its Used ivar is set to true.
	/// Initial value is NULL.
	/// </summary>
	public void SetDelegate(vtkRendererDelegate d)
	{
		vtkRenderer_SetDelegate_135(GetCppThis(), d?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetDraw_136(HandleRef pThis, int _arg);

	/// <summary>
	/// When this flag is off, render commands are ignored.  It is used to either
	/// multiplex a vtkRenderWindow or render only part of a vtkRenderWindow.
	/// By default, Draw is on.
	/// </summary>
	public virtual void SetDraw(int _arg)
	{
		vtkRenderer_SetDraw_136(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetEnvironmentRight_137(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the environment right vector.
	/// </summary>
	public virtual void SetEnvironmentRight(double _arg1, double _arg2, double _arg3)
	{
		vtkRenderer_SetEnvironmentRight_137(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetEnvironmentRight_138(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the environment right vector.
	/// </summary>
	public virtual void SetEnvironmentRight(IntPtr _arg)
	{
		vtkRenderer_SetEnvironmentRight_138(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetEnvironmentTexture_139(HandleRef pThis, HandleRef texture, byte isSRGB);

	/// <summary>
	/// Set/Get the environment texture used for image based lighting.
	/// This texture is supposed to represent the scene background.
	/// If it is not a cubemap, the texture is supposed to represent an equirectangular projection.
	/// If used with raytracing backends, the texture must be an equirectangular projection and must be
	/// constructed with a valid vtkImageData.
	/// Warning, this texture must be expressed in linear color space.
	/// If the texture is in sRGB color space, set the color flag on the texture or
	/// set the argument isSRGB to true.
	/// @sa vtkTexture::UseSRGBColorSpaceOn
	/// </summary>
	public virtual void SetEnvironmentTexture(vtkTexture texture, bool isSRGB)
	{
		vtkRenderer_SetEnvironmentTexture_139(GetCppThis(), texture?.GetCppThis() ?? default(HandleRef), (byte)(isSRGB ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetEnvironmentUp_140(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the environment up vector.
	/// </summary>
	public virtual void SetEnvironmentUp(double _arg1, double _arg2, double _arg3)
	{
		vtkRenderer_SetEnvironmentUp_140(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetEnvironmentUp_141(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the environment up vector.
	/// </summary>
	public virtual void SetEnvironmentUp(IntPtr _arg)
	{
		vtkRenderer_SetEnvironmentUp_141(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetErase_142(HandleRef pThis, int _arg);

	/// <summary>
	/// When this flag is off, the renderer will not erase the background
	/// or the Zbuffer.  It is used to have overlapping renderers.
	/// Both the RenderWindow Erase and Render Erase must be on
	/// for the camera to clear the renderer.  By default, Erase is on.
	/// </summary>
	public virtual void SetErase(int _arg)
	{
		vtkRenderer_SetErase_142(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetFXAAOptions_143(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// The configuration object for FXAA antialiasing.
	/// </summary>
	public virtual void SetFXAAOptions(vtkFXAAOptions arg0)
	{
		vtkRenderer_SetFXAAOptions_143(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetGL2PSSpecialPropCollection_144(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the prop collection object used during
	/// vtkRenderWindow::CaptureGL2PSSpecialProps(). Do not call manually, this
	/// is handled automatically by the render window.
	/// </summary>
	public void SetGL2PSSpecialPropCollection(vtkPropCollection arg0)
	{
		vtkRenderer_SetGL2PSSpecialPropCollection_144(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetInformation_145(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the information object associated with this algorithm.
	/// </summary>
	public virtual void SetInformation(vtkInformation arg0)
	{
		vtkRenderer_SetInformation_145(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetInteractive_146(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off interactive status.  An interactive renderer is one that
	/// can receive events from an interactor.  Should only be set if
	/// there are multiple renderers in the same section of the viewport.
	/// </summary>
	public virtual void SetInteractive(int _arg)
	{
		vtkRenderer_SetInteractive_146(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetLayer_147(HandleRef pThis, int layer);

	/// <summary>
	/// Set/Get the layer that this renderer belongs to.  This is only used if
	/// there are layered renderers.
	///
	/// Note: Changing the layer will update the PreserveColorBuffer setting. If
	/// the layer is 0, PreserveColorBuffer will be set to false, making the
	/// bottom renderer opaque. If the layer is non-zero, PreserveColorBuffer will
	/// be set to true, giving the renderer a transparent background. If other
	/// PreserveColorBuffer configurations are desired, they must be adjusted after
	/// the layer is set.
	/// </summary>
	public virtual void SetLayer(int layer)
	{
		vtkRenderer_SetLayer_147(GetCppThis(), layer);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetLeftBackgroundTexture_148(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the texture to be used for the monocular or stereo left eye
	/// background. If set and enabled this gets the priority over the gradient
	/// background.
	/// </summary>
	public virtual void SetLeftBackgroundTexture(vtkTexture arg0)
	{
		vtkRenderer_SetLeftBackgroundTexture_148(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetLightCollection_149(HandleRef pThis, HandleRef lights);

	/// <summary>
	/// Set the collection of lights.
	/// We cannot name it SetLights because of TestSetGet
	/// \pre lights_exist: lights!=0
	/// \post lights_set: lights==this-&gt;GetLights()
	/// </summary>
	public void SetLightCollection(vtkLightCollection lights)
	{
		vtkRenderer_SetLightCollection_149(GetCppThis(), lights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetLightFollowCamera_150(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the automatic repositioning of lights as the camera moves.
	/// If LightFollowCamera is on, lights that are designated as Headlights
	/// or CameraLights will be adjusted to move with this renderer's camera.
	/// If LightFollowCamera is off, the lights will not be adjusted.
	///
	/// (Note: In previous versions of vtk, this light-tracking
	/// functionality was part of the interactors, not the renderer. For
	/// backwards compatibility, the older, more limited interactor
	/// behavior is enabled by default. To disable this mode, turn the
	/// interactor's LightFollowCamera flag OFF, and leave the renderer's
	/// LightFollowCamera flag ON.)
	/// </summary>
	public virtual void SetLightFollowCamera(int _arg)
	{
		vtkRenderer_SetLightFollowCamera_150(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetMaximumNumberOfPeels_151(HandleRef pThis, int _arg);

	/// <summary>
	/// In case of depth peeling, define the maximum number of peeling layers.
	/// Initial value is 4. A special value of 0 means no maximum limit.
	/// It has to be a positive value.
	/// </summary>
	public virtual void SetMaximumNumberOfPeels(int _arg)
	{
		vtkRenderer_SetMaximumNumberOfPeels_151(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetNearClippingPlaneTolerance_152(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify tolerance for near clipping plane distance to the camera as a
	/// percentage of the far clipping plane distance. By default this will be
	/// set to 0.01 for 16 bit zbuffers and 0.001 for higher depth z buffers
	/// </summary>
	public virtual void SetNearClippingPlaneTolerance(double _arg)
	{
		vtkRenderer_SetNearClippingPlaneTolerance_152(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetOcclusionRatio_153(HandleRef pThis, double _arg);

	/// <summary>
	/// In case of use of depth peeling technique for rendering translucent
	/// material, define the threshold under which the algorithm stops to
	/// iterate over peel layers. This is the ratio of the number of pixels
	/// that have been touched by the last layer over the total number of pixels
	/// of the viewport area.
	/// Initial value is 0.0, meaning rendering have to be exact. Greater values
	/// may speed-up the rendering with small impact on the quality.
	/// </summary>
	public virtual void SetOcclusionRatio(double _arg)
	{
		vtkRenderer_SetOcclusionRatio_153(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetPass_154(HandleRef pThis, HandleRef p);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, wireframe
	/// geometry will be drawn using hidden line removal.
	/// </summary>
	public void SetPass(vtkRenderPass p)
	{
		vtkRenderer_SetPass_154(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetPreserveColorBuffer_155(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, the renderer at layer 0 is opaque, and all non-zero layer
	/// renderers are transparent. This flag allows this behavior to be overridden.
	/// If true, this setting will force the renderer to preserve the existing
	/// color buffer regardless of layer. If false, it will always be cleared at
	/// the start of rendering.
	///
	/// This flag influences the Transparent() method, and is updated by calls to
	/// SetLayer(). For this reason it should only be set after changing the layer.
	/// </summary>
	public virtual void SetPreserveColorBuffer(int _arg)
	{
		vtkRenderer_SetPreserveColorBuffer_155(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetPreserveDepthBuffer_156(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, the depth buffer is reset for each renderer. If this flag is
	/// true, this renderer will use the existing depth buffer for its rendering.
	/// </summary>
	public virtual void SetPreserveDepthBuffer(int _arg)
	{
		vtkRenderer_SetPreserveDepthBuffer_156(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetRenderWindow_157(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the rendering window in which to draw. This is automatically set
	/// when the renderer is created by MakeRenderer.  The user probably
	/// shouldn't ever need to call this method.
	/// </summary>
	public void SetRenderWindow(vtkRenderWindow arg0)
	{
		vtkRenderer_SetRenderWindow_157(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetRightBackgroundTexture_158(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the texture to be used for the right eye background. If set
	/// and enabled this gets the priority over the gradient background.
	/// </summary>
	public virtual void SetRightBackgroundTexture(vtkTexture arg0)
	{
		vtkRenderer_SetRightBackgroundTexture_158(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetSSAOBias_159(HandleRef pThis, double _arg);

	/// <summary>
	/// When using SSAO, define the bias when comparing samples.
	/// Default is 0.01
	/// </summary>
	public virtual void SetSSAOBias(double _arg)
	{
		vtkRenderer_SetSSAOBias_159(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetSSAOBlur_160(HandleRef pThis, byte _arg);

	/// <summary>
	/// When using SSAO, define blurring of the ambient occlusion.
	/// Blurring can help to improve the result if samples number is low.
	/// Default is false
	/// </summary>
	public virtual void SetSSAOBlur(bool _arg)
	{
		vtkRenderer_SetSSAOBlur_160(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetSSAOKernelSize_161(HandleRef pThis, uint _arg);

	/// <summary>
	/// When using SSAO, define the number of samples.
	/// Default is 32
	/// </summary>
	public virtual void SetSSAOKernelSize(uint _arg)
	{
		vtkRenderer_SetSSAOKernelSize_161(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetSSAORadius_162(HandleRef pThis, double _arg);

	/// <summary>
	/// When using SSAO, define the SSAO hemisphere radius.
	/// Default is 0.5
	/// </summary>
	public virtual void SetSSAORadius(double _arg)
	{
		vtkRenderer_SetSSAORadius_162(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetTexturedBackground_163(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether this viewport should have a textured background.
	/// Default is off.
	/// </summary>
	public virtual void SetTexturedBackground(bool _arg)
	{
		vtkRenderer_SetTexturedBackground_163(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetTwoSidedLighting_164(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off two-sided lighting of surfaces. If two-sided lighting is
	/// off, then only the side of the surface facing the light(s) will be lit,
	/// and the other side dark. If two-sided lighting on, both sides of the
	/// surface will be lit.
	/// </summary>
	public virtual void SetTwoSidedLighting(int _arg)
	{
		vtkRenderer_SetTwoSidedLighting_164(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetUseDepthPeeling_165(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off rendering of translucent material with depth peeling
	/// technique. The render window must have alpha bits (ie call
	/// SetAlphaBitPlanes(1)) and no multisample buffer (ie call
	/// SetMultiSamples(0) ) to support depth peeling.
	/// If UseDepthPeeling is on and the GPU supports it, depth peeling is used
	/// for rendering translucent materials.
	/// If UseDepthPeeling is off, alpha blending is used.
	/// Initial value is off.
	/// </summary>
	public virtual void SetUseDepthPeeling(int _arg)
	{
		vtkRenderer_SetUseDepthPeeling_165(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetUseDepthPeelingForVolumes_166(HandleRef pThis, byte _arg);

	/// <summary>
	/// This flag is on and the GPU supports it, depth-peel volumes along with
	/// the translucent geometry. Only supported on OpenGL2 with dual-depth
	/// peeling. Default is false.
	/// </summary>
	public virtual void SetUseDepthPeelingForVolumes(bool _arg)
	{
		vtkRenderer_SetUseDepthPeelingForVolumes_166(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetUseFXAA_167(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off FXAA anti-aliasing, if supported. Initial value is off.
	/// </summary>
	public virtual void SetUseFXAA(bool _arg)
	{
		vtkRenderer_SetUseFXAA_167(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetUseHiddenLineRemoval_168(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, wireframe
	/// geometry will be drawn using hidden line removal.
	/// </summary>
	public virtual void SetUseHiddenLineRemoval(int _arg)
	{
		vtkRenderer_SetUseHiddenLineRemoval_168(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetUseImageBasedLighting_169(HandleRef pThis, byte _arg);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, image based
	/// lighting is enabled and surface rendering displays environment reflections.
	/// The input cube map have to be set with SetEnvironmentCubeMap.
	/// If not cubemap is specified, this feature is disable.
	/// </summary>
	public virtual void SetUseImageBasedLighting(bool _arg)
	{
		vtkRenderer_SetUseImageBasedLighting_169(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetUseSSAO_170(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable or disable Screen Space Ambient Occlusion.
	/// SSAO darkens some pixels to improve depth perception.
	/// </summary>
	public virtual void SetUseSSAO(bool _arg)
	{
		vtkRenderer_SetUseSSAO_170(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_SetUseShadows_171(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off rendering of shadows if supported
	/// Initial value is off.
	/// </summary>
	public virtual void SetUseShadows(int _arg)
	{
		vtkRenderer_SetUseShadows_171(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_StereoMidpoint_172(HandleRef pThis);

	/// <summary>
	/// Do anything necessary between rendering the left and right viewpoints
	/// in a stereo render. Doesn't do anything except in the derived
	/// vtkIceTRenderer in ParaView.
	/// </summary>
	public virtual void StereoMidpoint()
	{
		vtkRenderer_StereoMidpoint_172(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_TexturedBackgroundOff_173(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should have a textured background.
	/// Default is off.
	/// </summary>
	public virtual void TexturedBackgroundOff()
	{
		vtkRenderer_TexturedBackgroundOff_173(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_TexturedBackgroundOn_174(HandleRef pThis);

	/// <summary>
	/// Set/Get whether this viewport should have a textured background.
	/// Default is off.
	/// </summary>
	public virtual void TexturedBackgroundOn()
	{
		vtkRenderer_TexturedBackgroundOn_174(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_Transparent_175(HandleRef pThis);

	/// <summary>
	/// Returns a boolean indicating if this renderer is transparent.  It is
	/// transparent if it is not in the deepest layer of its render window.
	/// </summary>
	public int Transparent()
	{
		return vtkRenderer_Transparent_175(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_TwoSidedLightingOff_176(HandleRef pThis);

	/// <summary>
	/// Turn on/off two-sided lighting of surfaces. If two-sided lighting is
	/// off, then only the side of the surface facing the light(s) will be lit,
	/// and the other side dark. If two-sided lighting on, both sides of the
	/// surface will be lit.
	/// </summary>
	public virtual void TwoSidedLightingOff()
	{
		vtkRenderer_TwoSidedLightingOff_176(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_TwoSidedLightingOn_177(HandleRef pThis);

	/// <summary>
	/// Turn on/off two-sided lighting of surfaces. If two-sided lighting is
	/// off, then only the side of the surface facing the light(s) will be lit,
	/// and the other side dark. If two-sided lighting on, both sides of the
	/// surface will be lit.
	/// </summary>
	public virtual void TwoSidedLightingOn()
	{
		vtkRenderer_TwoSidedLightingOn_177(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_UpdateLightsGeometryToFollowCamera_178(HandleRef pThis);

	/// <summary>
	/// Ask the lights in the scene that are not in world space
	/// (for instance, Headlights or CameraLights that are attached to the
	/// camera) to update their geometry to match the active camera.
	/// </summary>
	public virtual int UpdateLightsGeometryToFollowCamera()
	{
		return vtkRenderer_UpdateLightsGeometryToFollowCamera_178(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseDepthPeelingForVolumesOff_179(HandleRef pThis);

	/// <summary>
	/// This flag is on and the GPU supports it, depth-peel volumes along with
	/// the translucent geometry. Only supported on OpenGL2 with dual-depth
	/// peeling. Default is false.
	/// </summary>
	public virtual void UseDepthPeelingForVolumesOff()
	{
		vtkRenderer_UseDepthPeelingForVolumesOff_179(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseDepthPeelingForVolumesOn_180(HandleRef pThis);

	/// <summary>
	/// This flag is on and the GPU supports it, depth-peel volumes along with
	/// the translucent geometry. Only supported on OpenGL2 with dual-depth
	/// peeling. Default is false.
	/// </summary>
	public virtual void UseDepthPeelingForVolumesOn()
	{
		vtkRenderer_UseDepthPeelingForVolumesOn_180(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseDepthPeelingOff_181(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering of translucent material with depth peeling
	/// technique. The render window must have alpha bits (ie call
	/// SetAlphaBitPlanes(1)) and no multisample buffer (ie call
	/// SetMultiSamples(0) ) to support depth peeling.
	/// If UseDepthPeeling is on and the GPU supports it, depth peeling is used
	/// for rendering translucent materials.
	/// If UseDepthPeeling is off, alpha blending is used.
	/// Initial value is off.
	/// </summary>
	public virtual void UseDepthPeelingOff()
	{
		vtkRenderer_UseDepthPeelingOff_181(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseDepthPeelingOn_182(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering of translucent material with depth peeling
	/// technique. The render window must have alpha bits (ie call
	/// SetAlphaBitPlanes(1)) and no multisample buffer (ie call
	/// SetMultiSamples(0) ) to support depth peeling.
	/// If UseDepthPeeling is on and the GPU supports it, depth peeling is used
	/// for rendering translucent materials.
	/// If UseDepthPeeling is off, alpha blending is used.
	/// Initial value is off.
	/// </summary>
	public virtual void UseDepthPeelingOn()
	{
		vtkRenderer_UseDepthPeelingOn_182(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseFXAAOff_183(HandleRef pThis);

	/// <summary>
	/// Turn on/off FXAA anti-aliasing, if supported. Initial value is off.
	/// </summary>
	public virtual void UseFXAAOff()
	{
		vtkRenderer_UseFXAAOff_183(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseFXAAOn_184(HandleRef pThis);

	/// <summary>
	/// Turn on/off FXAA anti-aliasing, if supported. Initial value is off.
	/// </summary>
	public virtual void UseFXAAOn()
	{
		vtkRenderer_UseFXAAOn_184(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseHiddenLineRemovalOff_185(HandleRef pThis);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, wireframe
	/// geometry will be drawn using hidden line removal.
	/// </summary>
	public virtual void UseHiddenLineRemovalOff()
	{
		vtkRenderer_UseHiddenLineRemovalOff_185(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseHiddenLineRemovalOn_186(HandleRef pThis);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, wireframe
	/// geometry will be drawn using hidden line removal.
	/// </summary>
	public virtual void UseHiddenLineRemovalOn()
	{
		vtkRenderer_UseHiddenLineRemovalOn_186(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseImageBasedLightingOff_187(HandleRef pThis);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, image based
	/// lighting is enabled and surface rendering displays environment reflections.
	/// The input cube map have to be set with SetEnvironmentCubeMap.
	/// If not cubemap is specified, this feature is disable.
	/// </summary>
	public virtual void UseImageBasedLightingOff()
	{
		vtkRenderer_UseImageBasedLightingOff_187(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseImageBasedLightingOn_188(HandleRef pThis);

	/// <summary>
	/// If this flag is true and the rendering engine supports it, image based
	/// lighting is enabled and surface rendering displays environment reflections.
	/// The input cube map have to be set with SetEnvironmentCubeMap.
	/// If not cubemap is specified, this feature is disable.
	/// </summary>
	public virtual void UseImageBasedLightingOn()
	{
		vtkRenderer_UseImageBasedLightingOn_188(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseSSAOOff_189(HandleRef pThis);

	/// <summary>
	/// Enable or disable Screen Space Ambient Occlusion.
	/// SSAO darkens some pixels to improve depth perception.
	/// </summary>
	public virtual void UseSSAOOff()
	{
		vtkRenderer_UseSSAOOff_189(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseSSAOOn_190(HandleRef pThis);

	/// <summary>
	/// Enable or disable Screen Space Ambient Occlusion.
	/// SSAO darkens some pixels to improve depth perception.
	/// </summary>
	public virtual void UseSSAOOn()
	{
		vtkRenderer_UseSSAOOn_190(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseShadowsOff_191(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering of shadows if supported
	/// Initial value is off.
	/// </summary>
	public virtual void UseShadowsOff()
	{
		vtkRenderer_UseShadowsOff_191(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_UseShadowsOn_192(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering of shadows if supported
	/// Initial value is off.
	/// </summary>
	public virtual void UseShadowsOn()
	{
		vtkRenderer_UseShadowsOn_192(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ViewToPose_193(HandleRef pThis, ref double wx, ref double wy, ref double wz);

	/// <summary>
	/// Convert to from pose coordinates
	/// </summary>
	public override void ViewToPose(ref double wx, ref double wy, ref double wz)
	{
		vtkRenderer_ViewToPose_193(GetCppThis(), ref wx, ref wy, ref wz);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ViewToWorld_194(HandleRef pThis);

	/// <summary>
	/// Convert view point coordinates to world coordinates.
	/// </summary>
	public override void ViewToWorld()
	{
		vtkRenderer_ViewToWorld_194(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ViewToWorld_195(HandleRef pThis, ref double wx, ref double wy, ref double wz);

	/// <summary>
	/// Convert view point coordinates to world coordinates.
	/// </summary>
	public override void ViewToWorld(ref double wx, ref double wy, ref double wz)
	{
		vtkRenderer_ViewToWorld_195(GetCppThis(), ref wx, ref wy, ref wz);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_VisibleActorCount_196(HandleRef pThis);

	/// <summary>
	/// Returns the number of visible actors.
	/// </summary>
	public int VisibleActorCount()
	{
		return vtkRenderer_VisibleActorCount_196(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderer_VisibleVolumeCount_197(HandleRef pThis);

	/// <summary>
	/// Returns the number of visible volumes.
	/// </summary>
	public int VisibleVolumeCount()
	{
		return vtkRenderer_VisibleVolumeCount_197(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_WorldToPose_198(HandleRef pThis, ref double wx, ref double wy, ref double wz);

	/// <summary>
	/// Convert to from pose coordinates
	/// </summary>
	public override void WorldToPose(ref double wx, ref double wy, ref double wz)
	{
		vtkRenderer_WorldToPose_198(GetCppThis(), ref wx, ref wy, ref wz);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_WorldToView_199(HandleRef pThis);

	/// <summary>
	/// Convert world point coordinates to view coordinates.
	/// </summary>
	public override void WorldToView()
	{
		vtkRenderer_WorldToView_199(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_WorldToView_200(HandleRef pThis, ref double wx, ref double wy, ref double wz);

	/// <summary>
	/// Convert world point coordinates to view coordinates.
	/// </summary>
	public override void WorldToView(ref double wx, ref double wy, ref double wz)
	{
		vtkRenderer_WorldToView_200(GetCppThis(), ref wx, ref wy, ref wz);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderer_ZoomToBoxUsingViewAngle_201(HandleRef pThis, HandleRef box, double offsetRatio);

	/// <summary>
	/// Automatically set up the camera focal point and zoom factor to
	/// observe the \p box in display coordinates.
	/// \p OffsetRatio can be used to add a zoom offset.
	/// </summary>
	public void ZoomToBoxUsingViewAngle(vtkRecti box, double offsetRatio)
	{
		vtkRenderer_ZoomToBoxUsingViewAngle_201(GetCppThis(), box?.GetCppThis() ?? default(HandleRef), offsetRatio);
	}
}
