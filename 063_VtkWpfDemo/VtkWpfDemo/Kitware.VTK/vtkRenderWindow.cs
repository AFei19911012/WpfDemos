using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRenderWindow
/// </summary>
/// <remarks>
///    create a window for renderers to draw into
///
/// vtkRenderWindow is an abstract object to specify the behavior of a
/// rendering window. A rendering window is a window in a graphical user
/// interface where renderers draw their images. Methods are provided to
/// synchronize the rendering process, set window size, and control double
/// buffering.  The window also allows rendering in stereo.  The interlaced
/// render stereo type is for output to a VRex stereo projector.  All of the
/// odd horizontal lines are from the left eye, and the even lines are from
/// the right eye.  The user has to make the render window aligned with the
/// VRex projector, or the eye will be swapped.
///
/// @warning
/// In VTK versions 4 and later, the vtkWindowToImageFilter class is
/// part of the canonical way to output an image of a window to a file
/// (replacing the obsolete SaveImageAsPPM method for vtkRenderWindows
/// that existed in 3.2 and earlier).  Connect one of these filters to
/// the output of the window, and filter's output to a writer such as
/// vtkPNGWriter.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderer vtkRenderWindowInteractor vtkWindowToImageFilter
/// </seealso>
public class vtkRenderWindow : vtkWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRenderWindow()
	{
		MRClassNameKey = "class vtkRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of  vtkRenderWindow with its screen size
	/// set to 300x300, borders turned on, positioned at (0,0), double
	/// buffering turned on.
	/// </summary>
	public new static vtkRenderWindow New()
	{
		vtkRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an instance of  vtkRenderWindow with its screen size
	/// set to 300x300, borders turned on, positioned at (0,0), double
	/// buffering turned on.
	/// </summary>
	public vtkRenderWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_UnRegister_163(HandleRef pThis, HandleRef o);

	/// <summary>
	/// This Method detects loops of RenderWindow&lt;-&gt;Interactor,
	/// so objects are freed properly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (GetCallDisposalMethod())
			{
				vtkRenderWindow_UnRegister_163(GetCppThis(), default(HandleRef));
				ClearCppThis();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_AddRenderer_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a renderer to the list of renderers.
	/// </summary>
	public virtual void AddRenderer(vtkRenderer arg0)
	{
		vtkRenderWindow_AddRenderer_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_AlphaBitPlanesOff_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the use of alpha bitplanes.
	/// </summary>
	public virtual void AlphaBitPlanesOff()
	{
		vtkRenderWindow_AlphaBitPlanesOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_AlphaBitPlanesOn_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the use of alpha bitplanes.
	/// </summary>
	public virtual void AlphaBitPlanesOn()
	{
		vtkRenderWindow_AlphaBitPlanesOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_BordersOff_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off window manager borders. Typically, you shouldn't turn the
	/// borders off, because that bypasses the window manager and can cause
	/// undesirable behavior.
	/// </summary>
	public virtual void BordersOff()
	{
		vtkRenderWindow_BordersOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_BordersOn_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off window manager borders. Typically, you shouldn't turn the
	/// borders off, because that bypasses the window manager and can cause
	/// undesirable behavior.
	/// </summary>
	public virtual void BordersOn()
	{
		vtkRenderWindow_BordersOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_CaptureGL2PSSpecialProps_06(HandleRef pThis, HandleRef specialProps);

	/// <summary>
	/// The GL2PS exporter must handle certain props in a special way (e.g. text).
	/// This method performs a render and captures all "GL2PS-special" props in
	/// the specified collection. The collection will contain a
	/// vtkPropCollection for each vtkRenderer in this-&gt;GetRenderers(), each
	/// containing the special props rendered by the corresponding renderer.
	/// </summary>
	public void CaptureGL2PSSpecialProps(vtkCollection specialProps)
	{
		vtkRenderWindow_CaptureGL2PSSpecialProps_06(GetCppThis(), specialProps?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_CheckAbortStatus_07(HandleRef pThis);

	/// <summary>
	/// This is a flag that can be set to interrupt a rendering that is in
	/// progress.
	/// </summary>
	public virtual int CheckAbortStatus()
	{
		return vtkRenderWindow_CheckAbortStatus_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_CheckInRenderStatus_08(HandleRef pThis);

	/// <summary>
	/// Are we rendering at the moment
	/// </summary>
	public virtual int CheckInRenderStatus()
	{
		return vtkRenderWindow_CheckInRenderStatus_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_ClearInRenderStatus_09(HandleRef pThis);

	/// <summary>
	/// Clear status (after an exception was thrown for example)
	/// </summary>
	public virtual void ClearInRenderStatus()
	{
		vtkRenderWindow_ClearInRenderStatus_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_CopyResultFrame_10(HandleRef pThis);

	/// <summary>
	/// Performed at the end of the rendering process to generate image.
	/// This is typically done right before swapping buffers.
	/// </summary>
	public virtual void CopyResultFrame()
	{
		vtkRenderWindow_CopyResultFrame_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_End_11(HandleRef pThis);

	/// <summary>
	/// Update the system, if needed, at end of render process
	/// </summary>
	public virtual void End()
	{
		vtkRenderWindow_End_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_Finalize_12(HandleRef pThis);

	/// <summary>
	/// Finalize the rendering process.
	/// </summary>
	public virtual void FinalizeWrapper()
	{
		vtkRenderWindow_Finalize_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_Frame_13(HandleRef pThis);

	/// <summary>
	/// A termination method performed at the end of the rendering process
	/// to do things like swapping buffers (if necessary) or similar actions.
	/// </summary>
	public virtual void Frame()
	{
		vtkRenderWindow_Frame_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_FullScreenOff_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering full screen window size.
	/// </summary>
	public virtual void FullScreenOff()
	{
		vtkRenderWindow_FullScreenOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_FullScreenOn_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering full screen window size.
	/// </summary>
	public virtual void FullScreenOn()
	{
		vtkRenderWindow_FullScreenOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetAbortRender_16(HandleRef pThis);

	/// <summary>
	/// This is a flag that can be set to interrupt a rendering that is in
	/// progress.
	/// </summary>
	public virtual int GetAbortRender()
	{
		return vtkRenderWindow_GetAbortRender_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetAlphaBitPlanes_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off the use of alpha bitplanes.
	/// </summary>
	public virtual int GetAlphaBitPlanes()
	{
		return vtkRenderWindow_GetAlphaBitPlanes_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetAnaglyphColorMask_18(HandleRef pThis);

	/// <summary>
	/// Set/get the anaglyph color mask values.  These two numbers are bits
	/// mask that control which color channels of the original stereo
	/// images are used to produce the final anaglyph image.  The first
	/// value is the color mask for the left view, the second the mask
	/// for the right view.  If a bit in the mask is on for a particular
	/// color for a view, that color is passed on to the final view; if
	/// it is not set, that channel for that view is ignored.
	/// The bits are arranged as r, g, and b, so r = 4, g = 2, and b = 1.
	/// By default, the first value (the left view) is set to 4, and the
	/// second value is set to 3.  That means that the red output channel
	/// comes from the left view, and the green and blue values come from
	/// the right view.
	/// </summary>
	public virtual int[] GetAnaglyphColorMask()
	{
		IntPtr intPtr = vtkRenderWindow_GetAnaglyphColorMask_18(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_GetAnaglyphColorMask_19(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/get the anaglyph color mask values.  These two numbers are bits
	/// mask that control which color channels of the original stereo
	/// images are used to produce the final anaglyph image.  The first
	/// value is the color mask for the left view, the second the mask
	/// for the right view.  If a bit in the mask is on for a particular
	/// color for a view, that color is passed on to the final view; if
	/// it is not set, that channel for that view is ignored.
	/// The bits are arranged as r, g, and b, so r = 4, g = 2, and b = 1.
	/// By default, the first value (the left view) is set to 4, and the
	/// second value is set to 3.  That means that the red output channel
	/// comes from the left view, and the green and blue values come from
	/// the right view.
	/// </summary>
	public virtual void GetAnaglyphColorMask(IntPtr data)
	{
		vtkRenderWindow_GetAnaglyphColorMask_19(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkRenderWindow_GetAnaglyphColorSaturation_20(HandleRef pThis);

	/// <summary>
	/// Set/get the anaglyph color saturation factor.  This number ranges from
	/// 0.0 to 1.0:  0.0 means that no color from the original object is
	/// maintained, 1.0 means all of the color is maintained.  The default
	/// value is 0.65.  Too much saturation can produce uncomfortable 3D
	/// viewing because anaglyphs also use color to encode 3D.
	/// </summary>
	public virtual float GetAnaglyphColorSaturation()
	{
		return vtkRenderWindow_GetAnaglyphColorSaturation_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkRenderWindow_GetAnaglyphColorSaturationMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Set/get the anaglyph color saturation factor.  This number ranges from
	/// 0.0 to 1.0:  0.0 means that no color from the original object is
	/// maintained, 1.0 means all of the color is maintained.  The default
	/// value is 0.65.  Too much saturation can produce uncomfortable 3D
	/// viewing because anaglyphs also use color to encode 3D.
	/// </summary>
	public virtual float GetAnaglyphColorSaturationMaxValue()
	{
		return vtkRenderWindow_GetAnaglyphColorSaturationMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkRenderWindow_GetAnaglyphColorSaturationMinValue_22(HandleRef pThis);

	/// <summary>
	/// Set/get the anaglyph color saturation factor.  This number ranges from
	/// 0.0 to 1.0:  0.0 means that no color from the original object is
	/// maintained, 1.0 means all of the color is maintained.  The default
	/// value is 0.65.  Too much saturation can produce uncomfortable 3D
	/// viewing because anaglyphs also use color to encode 3D.
	/// </summary>
	public virtual float GetAnaglyphColorSaturationMinValue()
	{
		return vtkRenderWindow_GetAnaglyphColorSaturationMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetBorders_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off window manager borders. Typically, you shouldn't turn the
	/// borders off, because that bypasses the window manager and can cause
	/// undesirable behavior.
	/// </summary>
	public virtual int GetBorders()
	{
		return vtkRenderWindow_GetBorders_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetCapturingGL2PSSpecialProps_24(HandleRef pThis);

	/// <summary>
	/// Returns true if the render process is capturing text actors.
	/// </summary>
	public virtual int GetCapturingGL2PSSpecialProps()
	{
		return vtkRenderWindow_GetCapturingGL2PSSpecialProps_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetColorBufferSizes_25(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Get the size of the color buffer.
	/// Returns 0 if not able to determine otherwise sets R G B and A into buffer.
	/// </summary>
	public virtual int GetColorBufferSizes(IntPtr arg0)
	{
		return vtkRenderWindow_GetColorBufferSizes_25(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetCurrentCursor_26(HandleRef pThis);

	/// <summary>
	/// Change the shape of the cursor.
	/// </summary>
	public virtual int GetCurrentCursor()
	{
		return vtkRenderWindow_GetCurrentCursor_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetCursorFileName_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the full path to the custom cursor.
	/// This is used when the current cursor is set to VTK_CURSOR_CUSTOM.
	/// </summary>
	public virtual string GetCursorFileName()
	{
		return Marshal.PtrToStringAnsi(vtkRenderWindow_GetCursorFileName_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetDepthBufferSize_28(HandleRef pThis);

	/// <summary>
	/// This method should be defined by the subclass. How many bits of
	/// precision are there in the zbuffer?
	/// </summary>
	public virtual int GetDepthBufferSize()
	{
		return vtkRenderWindow_GetDepthBufferSize_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRenderWindow_GetDesiredUpdateRate_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the desired update rate. This is used with
	/// the vtkLODActor class. When using level of detail actors you
	/// need to specify what update rate you require. The LODActors then
	/// will pick the correct resolution to meet your desired update rate
	/// in frames per second. A value of zero indicates that they can use
	/// all the time they want to.
	/// </summary>
	public virtual double GetDesiredUpdateRate()
	{
		return vtkRenderWindow_GetDesiredUpdateRate_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetDeviceIndex_30(HandleRef pThis);

	/// <summary>
	/// If there are several graphics card installed on a system,
	/// this index can be used to specify which card you want to render to.
	/// the default is 0. This may not work on all derived render window and
	/// it may need to be set before the first render.
	/// </summary>
	public virtual int GetDeviceIndex()
	{
		return vtkRenderWindow_GetDeviceIndex_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindow_GetDeviceToWorldMatrixForDevice_31(HandleRef pThis, vtkEventDataDevice device, HandleRef deviceToWorldMatrix);

	/// <summary>
	/// Store in \p deviceToWorldMatrix the matrix that goes from device coordinates
	/// to world coordinates. e.g. if you push 0,0,0,1 through this matrix you will get
	/// the location of the device in world coordinates.
	/// Return true if the query is valid, else false.
	/// </summary>
	public virtual bool GetDeviceToWorldMatrixForDevice(vtkEventDataDevice device, vtkMatrix4x4 deviceToWorldMatrix)
	{
		return (vtkRenderWindow_GetDeviceToWorldMatrixForDevice_31(GetCppThis(), device, deviceToWorldMatrix?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetEventPending_32(HandleRef pThis);

	/// <summary>
	/// Check to see if a mouse button has been pressed.  All other events
	/// are ignored by this method.  Ideally, you want to abort the render
	/// on any event which causes the DesiredUpdateRate to switch from
	/// a high-quality rate to a more interactive rate.
	/// </summary>
	public virtual int GetEventPending()
	{
		return vtkRenderWindow_GetEventPending_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetFullScreen_33(HandleRef pThis);

	/// <summary>
	/// Turn on/off rendering full screen window size.
	/// </summary>
	public virtual int GetFullScreen()
	{
		return vtkRenderWindow_GetFullScreen_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetGenericContext_34(HandleRef pThis);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override IntPtr GetGenericContext()
	{
		return vtkRenderWindow_GetGenericContext_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetGenericDisplayId_35(HandleRef pThis);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override IntPtr GetGenericDisplayId()
	{
		return vtkRenderWindow_GetGenericDisplayId_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetGenericDrawable_36(HandleRef pThis);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override IntPtr GetGenericDrawable()
	{
		return vtkRenderWindow_GetGenericDrawable_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetGenericParentId_37(HandleRef pThis);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override IntPtr GetGenericParentId()
	{
		return vtkRenderWindow_GetGenericParentId_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetGenericWindowId_38(HandleRef pThis);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override IntPtr GetGenericWindowId()
	{
		return vtkRenderWindow_GetGenericWindowId_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetInAbortCheck_39(HandleRef pThis);

	/// <summary>
	/// This is a flag that can be set to interrupt a rendering that is in
	/// progress.
	/// </summary>
	public virtual int GetInAbortCheck()
	{
		return vtkRenderWindow_GetInAbortCheck_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetInteractor_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the interactor associated with this render window
	/// </summary>
	public virtual vtkRenderWindowInteractor GetInteractor()
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindow_GetInteractor_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetLineSmoothing_41(HandleRef pThis);

	/// <summary>
	/// Turn on/off line smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual int GetLineSmoothing()
	{
		return vtkRenderWindow_GetLineSmoothing_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetMultiSamples_42(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of multisamples to use for hardware antialiasing.
	/// A value of 1 will be set to 0.
	/// </summary>
	public virtual int GetMultiSamples()
	{
		return vtkRenderWindow_GetMultiSamples_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetNeverRendered_43(HandleRef pThis);

	/// <summary>
	/// This flag is set if the window hasn't rendered since it was created
	/// </summary>
	public virtual int GetNeverRendered()
	{
		return vtkRenderWindow_GetNeverRendered_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetNumberOfDevices_44(HandleRef pThis);

	/// <summary>
	/// Returns the number of devices (graphics cards) on a system.
	/// This may not work on all derived render windows.
	/// </summary>
	public virtual int GetNumberOfDevices()
	{
		return vtkRenderWindow_GetNumberOfDevices_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderWindow_GetNumberOfGenerationsFromBase_45(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRenderWindow_GetNumberOfGenerationsFromBase_45(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRenderWindow_GetNumberOfGenerationsFromBaseType_46(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRenderWindow_GetNumberOfGenerationsFromBaseType_46(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetNumberOfLayers_47(HandleRef pThis);

	/// <summary>
	/// Get the number of layers for renderers.  Each renderer should have
	/// its layer set individually.  Some algorithms iterate through all layers,
	/// so it is not wise to set the number of layers to be exorbitantly large
	/// (say bigger than 100).
	/// </summary>
	public virtual int GetNumberOfLayers()
	{
		return vtkRenderWindow_GetNumberOfLayers_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetNumberOfLayersMaxValue_48(HandleRef pThis);

	/// <summary>
	/// Get the number of layers for renderers.  Each renderer should have
	/// its layer set individually.  Some algorithms iterate through all layers,
	/// so it is not wise to set the number of layers to be exorbitantly large
	/// (say bigger than 100).
	/// </summary>
	public virtual int GetNumberOfLayersMaxValue()
	{
		return vtkRenderWindow_GetNumberOfLayersMaxValue_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetNumberOfLayersMinValue_49(HandleRef pThis);

	/// <summary>
	/// Get the number of layers for renderers.  Each renderer should have
	/// its layer set individually.  Some algorithms iterate through all layers,
	/// so it is not wise to set the number of layers to be exorbitantly large
	/// (say bigger than 100).
	/// </summary>
	public virtual int GetNumberOfLayersMinValue()
	{
		return vtkRenderWindow_GetNumberOfLayersMinValue_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_GetPhysicalToWorldMatrix_50(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Get physical to world transform matrix. Some subclasses may define a
	/// Physical coordinate system such as in VR. This method provides access
	/// to the matrix mapping that space to world coordinates.
	/// </summary>
	public virtual void GetPhysicalToWorldMatrix(vtkMatrix4x4 matrix)
	{
		vtkRenderWindow_GetPhysicalToWorldMatrix_50(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindow_GetPlatformSupportsRenderWindowSharing_51(HandleRef pThis);

	/// <summary>
	/// Set/Get an already existing window that this window should
	/// share data with if possible. This must be set
	/// after the shared render window has been created and initialized
	/// but before this window has been initialized. Not all platforms
	/// support data sharing.
	/// </summary>
	public virtual bool GetPlatformSupportsRenderWindowSharing()
	{
		return (vtkRenderWindow_GetPlatformSupportsRenderWindowSharing_51(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetPointSmoothing_52(HandleRef pThis);

	/// <summary>
	/// Turn on/off point smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual int GetPointSmoothing()
	{
		return vtkRenderWindow_GetPointSmoothing_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetPolygonSmoothing_53(HandleRef pThis);

	/// <summary>
	/// Turn on/off polygon smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual int GetPolygonSmoothing()
	{
		return vtkRenderWindow_GetPolygonSmoothing_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetRGBACharPixelData_54(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual IntPtr GetRGBACharPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		return vtkRenderWindow_GetRGBACharPixelData_54(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetRGBACharPixelData_55(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, HandleRef arg5, int arg6);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual int GetRGBACharPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, vtkUnsignedCharArray arg5, int arg6)
	{
		return vtkRenderWindow_GetRGBACharPixelData_55(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5?.GetCppThis() ?? default(HandleRef), arg6);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetRGBAPixelData_56(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual IntPtr GetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		return vtkRenderWindow_GetRGBAPixelData_56(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetRGBAPixelData_57(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, HandleRef arg5, int arg6);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual int GetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, vtkFloatArray arg5, int arg6)
	{
		return vtkRenderWindow_GetRGBAPixelData_57(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5?.GetCppThis() ?? default(HandleRef), arg6);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetRenderLibrary_58();

	/// <summary>
	/// What rendering library has the user requested
	/// </summary>
	public static string GetRenderLibrary()
	{
		return Marshal.PtrToStringAnsi(vtkRenderWindow_GetRenderLibrary_58());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetRenderTimer_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the render timer log for this window.
	/// </summary>
	public virtual vtkRenderTimerLog GetRenderTimer()
	{
		vtkRenderTimerLog vtkRenderTimerLog2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindow_GetRenderTimer_59(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderTimerLog2 = (vtkRenderTimerLog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderTimerLog2.Register(null);
			}
		}
		return vtkRenderTimerLog2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetRenderers_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the collection of renderers in the render window.
	/// </summary>
	public vtkRendererCollection GetRenderers()
	{
		vtkRendererCollection vtkRendererCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindow_GetRenderers_60(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRendererCollection2 = (vtkRendererCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRendererCollection2.Register(null);
			}
		}
		return vtkRendererCollection2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetRenderingBackend_61(HandleRef pThis);

	/// <summary>
	/// What rendering backend has the user requested
	/// </summary>
	public virtual string GetRenderingBackend()
	{
		return Marshal.PtrToStringAnsi(vtkRenderWindow_GetRenderingBackend_61(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetSharedRenderWindow_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get an already existing window that this window should
	/// share data with if possible. This must be set
	/// after the shared render window has been created and initialized
	/// but before this window has been initialized. Not all platforms
	/// support data sharing.
	/// </summary>
	public virtual vtkRenderWindow GetSharedRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindow_GetSharedRenderWindow_62(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkRenderWindow_GetStencilCapable_63(HandleRef pThis);

	/// <summary>
	/// Set / Get the availability of the stencil buffer.
	/// </summary>
	public virtual int GetStencilCapable()
	{
		return vtkRenderWindow_GetStencilCapable_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetStereoCapableWindow_64(HandleRef pThis);

	/// <summary>
	/// Prescribe that the window be created in a stereo-capable mode. This
	/// method must be called before the window is realized. Default is off.
	/// </summary>
	public virtual int GetStereoCapableWindow()
	{
		return vtkRenderWindow_GetStereoCapableWindow_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetStereoRender_65(HandleRef pThis);

	/// <summary>
	/// Turn on/off stereo rendering.
	/// </summary>
	public virtual int GetStereoRender()
	{
		return vtkRenderWindow_GetStereoRender_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetStereoType_66(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public virtual int GetStereoType()
	{
		return vtkRenderWindow_GetStereoType_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetStereoTypeAsString_67(HandleRef pThis);

	/// <summary>
	/// Returns the stereo type as a string.
	/// </summary>
	public string GetStereoTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkRenderWindow_GetStereoTypeAsString_67(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetStereoTypeAsString_68(int type);

	/// <summary>
	/// Returns the stereo type as a string.
	/// </summary>
	public static string GetStereoTypeAsString(int type)
	{
		return Marshal.PtrToStringAnsi(vtkRenderWindow_GetStereoTypeAsString_68(type));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetSwapBuffers_69(HandleRef pThis);

	/// <summary>
	/// Turn on/off buffer swapping between images.
	/// </summary>
	public virtual int GetSwapBuffers()
	{
		return vtkRenderWindow_GetSwapBuffers_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindow_GetUseSRGBColorSpace_70(HandleRef pThis);

	/// <summary>
	/// Set/Get if we want this window to use the sRGB color space.
	/// Some hardware/drivers do not fully support this.
	/// </summary>
	public virtual bool GetUseSRGBColorSpace()
	{
		return (vtkRenderWindow_GetUseSRGBColorSpace_70(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_GetZbufferData_71(HandleRef pThis, int arg0, int arg1, int arg2, int arg3);

	/// <summary>
	/// Set/Get the zbuffer data from the frame buffer.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual IntPtr GetZbufferData(int arg0, int arg1, int arg2, int arg3)
	{
		return vtkRenderWindow_GetZbufferData_71(GetCppThis(), arg0, arg1, arg2, arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetZbufferData_72(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4);

	/// <summary>
	/// Set/Get the zbuffer data from the frame buffer.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual int GetZbufferData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4)
	{
		return vtkRenderWindow_GetZbufferData_72(GetCppThis(), arg0, arg1, arg2, arg3, arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_GetZbufferData_73(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

	/// <summary>
	/// Set/Get the zbuffer data from the frame buffer.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual int GetZbufferData(int arg0, int arg1, int arg2, int arg3, vtkFloatArray arg4)
	{
		return vtkRenderWindow_GetZbufferData_73(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkRenderWindow_GetZbufferDataAtPoint_74(HandleRef pThis, int x, int y);

	/// <summary>
	/// Set/Get the zbuffer data from the frame buffer.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public float GetZbufferDataAtPoint(int x, int y)
	{
		return vtkRenderWindow_GetZbufferDataAtPoint_74(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_HasRenderer_75(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Query if a renderer is in the list of renderers.
	/// </summary>
	public int HasRenderer(vtkRenderer arg0)
	{
		return vtkRenderWindow_HasRenderer_75(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_HideCursor_76(HandleRef pThis);

	/// <summary>
	/// Hide or Show the mouse cursor, it is nice to be able to hide the
	/// default cursor if you want VTK to display a 3D cursor instead.
	/// Set cursor position in window (note that (0,0) is the lower left
	/// corner).
	/// </summary>
	public virtual void HideCursor()
	{
		vtkRenderWindow_HideCursor_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindow_InitializeFromCurrentContext_77(HandleRef pThis);

	/// <summary>
	/// Initialize the render window from the information associated
	/// with the currently activated OpenGL context.
	/// </summary>
	public virtual bool InitializeFromCurrentContext()
	{
		return (vtkRenderWindow_InitializeFromCurrentContext_77(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_IsA_78(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRenderWindow_IsA_78(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRenderWindow_IsCurrent_79(HandleRef pThis);

	/// <summary>
	/// Tells if this window is the current graphics context for the calling
	/// thread.
	/// </summary>
	public virtual bool IsCurrent()
	{
		return (vtkRenderWindow_IsCurrent_79(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_IsDirect_80(HandleRef pThis);

	/// <summary>
	/// Is this render window using hardware acceleration? 0-false, 1-true
	/// </summary>
	public virtual int IsDirect()
	{
		return vtkRenderWindow_IsDirect_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_IsTypeOf_81(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRenderWindow_IsTypeOf_81(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_LineSmoothingOff_82(HandleRef pThis);

	/// <summary>
	/// Turn on/off line smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void LineSmoothingOff()
	{
		vtkRenderWindow_LineSmoothingOff_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_LineSmoothingOn_83(HandleRef pThis);

	/// <summary>
	/// Turn on/off line smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void LineSmoothingOn()
	{
		vtkRenderWindow_LineSmoothingOn_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_MakeRenderWindowInteractor_84(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an interactor to control renderers in this window. We need
	/// to know what type of interactor to create, because we might be in
	/// X Windows or MS Windows.
	/// </summary>
	public virtual vtkRenderWindowInteractor MakeRenderWindowInteractor()
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindow_MakeRenderWindowInteractor_84(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_NewInstance_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRenderWindow NewInstance()
	{
		vtkRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindow_NewInstance_86(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_PointSmoothingOff_87(HandleRef pThis);

	/// <summary>
	/// Turn on/off point smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void PointSmoothingOff()
	{
		vtkRenderWindow_PointSmoothingOff_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_PointSmoothingOn_88(HandleRef pThis);

	/// <summary>
	/// Turn on/off point smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void PointSmoothingOn()
	{
		vtkRenderWindow_PointSmoothingOn_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_PolygonSmoothingOff_89(HandleRef pThis);

	/// <summary>
	/// Turn on/off polygon smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void PolygonSmoothingOff()
	{
		vtkRenderWindow_PolygonSmoothingOff_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_PolygonSmoothingOn_90(HandleRef pThis);

	/// <summary>
	/// Turn on/off polygon smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void PolygonSmoothingOn()
	{
		vtkRenderWindow_PolygonSmoothingOn_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_ReleaseRGBAPixelData_91(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual void ReleaseRGBAPixelData(IntPtr arg0)
	{
		vtkRenderWindow_ReleaseRGBAPixelData_91(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_RemoveRenderer_92(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a renderer from the list of renderers.
	/// </summary>
	public void RemoveRenderer(vtkRenderer arg0)
	{
		vtkRenderWindow_RemoveRenderer_92(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_Render_93(HandleRef pThis);

	/// <summary>
	/// Ask each renderer owned by this RenderWindow to render its image and
	/// synchronize this process.
	/// </summary>
	public override void Render()
	{
		vtkRenderWindow_Render_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_ReportCapabilities_94(HandleRef pThis);

	/// <summary>
	/// Get report of capabilities for the render window
	/// </summary>
	public virtual string ReportCapabilities()
	{
		return Marshal.PtrToStringAnsi(vtkRenderWindow_ReportCapabilities_94(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRenderWindow_SafeDownCast_95(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRenderWindow_SafeDownCast_95(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRenderWindow_SetAbortRender_96(HandleRef pThis, int _arg);

	/// <summary>
	/// This is a flag that can be set to interrupt a rendering that is in
	/// progress.
	/// </summary>
	public virtual void SetAbortRender(int _arg)
	{
		vtkRenderWindow_SetAbortRender_96(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetAlphaBitPlanes_97(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the use of alpha bitplanes.
	/// </summary>
	public virtual void SetAlphaBitPlanes(int _arg)
	{
		vtkRenderWindow_SetAlphaBitPlanes_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetAnaglyphColorMask_98(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/get the anaglyph color mask values.  These two numbers are bits
	/// mask that control which color channels of the original stereo
	/// images are used to produce the final anaglyph image.  The first
	/// value is the color mask for the left view, the second the mask
	/// for the right view.  If a bit in the mask is on for a particular
	/// color for a view, that color is passed on to the final view; if
	/// it is not set, that channel for that view is ignored.
	/// The bits are arranged as r, g, and b, so r = 4, g = 2, and b = 1.
	/// By default, the first value (the left view) is set to 4, and the
	/// second value is set to 3.  That means that the red output channel
	/// comes from the left view, and the green and blue values come from
	/// the right view.
	/// </summary>
	public virtual void SetAnaglyphColorMask(int _arg1, int _arg2)
	{
		vtkRenderWindow_SetAnaglyphColorMask_98(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetAnaglyphColorMask_99(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the anaglyph color mask values.  These two numbers are bits
	/// mask that control which color channels of the original stereo
	/// images are used to produce the final anaglyph image.  The first
	/// value is the color mask for the left view, the second the mask
	/// for the right view.  If a bit in the mask is on for a particular
	/// color for a view, that color is passed on to the final view; if
	/// it is not set, that channel for that view is ignored.
	/// The bits are arranged as r, g, and b, so r = 4, g = 2, and b = 1.
	/// By default, the first value (the left view) is set to 4, and the
	/// second value is set to 3.  That means that the red output channel
	/// comes from the left view, and the green and blue values come from
	/// the right view.
	/// </summary>
	public void SetAnaglyphColorMask(IntPtr _arg)
	{
		vtkRenderWindow_SetAnaglyphColorMask_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetAnaglyphColorSaturation_100(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/get the anaglyph color saturation factor.  This number ranges from
	/// 0.0 to 1.0:  0.0 means that no color from the original object is
	/// maintained, 1.0 means all of the color is maintained.  The default
	/// value is 0.65.  Too much saturation can produce uncomfortable 3D
	/// viewing because anaglyphs also use color to encode 3D.
	/// </summary>
	public virtual void SetAnaglyphColorSaturation(float _arg)
	{
		vtkRenderWindow_SetAnaglyphColorSaturation_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetBorders_101(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off window manager borders. Typically, you shouldn't turn the
	/// borders off, because that bypasses the window manager and can cause
	/// undesirable behavior.
	/// </summary>
	public virtual void SetBorders(int _arg)
	{
		vtkRenderWindow_SetBorders_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetCurrentCursor_102(HandleRef pThis, int _arg);

	/// <summary>
	/// Change the shape of the cursor.
	/// </summary>
	public virtual void SetCurrentCursor(int _arg)
	{
		vtkRenderWindow_SetCurrentCursor_102(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetCursorFileName_103(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the full path to the custom cursor.
	/// This is used when the current cursor is set to VTK_CURSOR_CUSTOM.
	/// </summary>
	public virtual void SetCursorFileName(string _arg)
	{
		vtkRenderWindow_SetCursorFileName_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetCursorPosition_104(HandleRef pThis, int arg0, int arg1);

	/// <summary>
	/// Hide or Show the mouse cursor, it is nice to be able to hide the
	/// default cursor if you want VTK to display a 3D cursor instead.
	/// Set cursor position in window (note that (0,0) is the lower left
	/// corner).
	/// </summary>
	public virtual void SetCursorPosition(int arg0, int arg1)
	{
		vtkRenderWindow_SetCursorPosition_104(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetDesiredUpdateRate_105(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/Get the desired update rate. This is used with
	/// the vtkLODActor class. When using level of detail actors you
	/// need to specify what update rate you require. The LODActors then
	/// will pick the correct resolution to meet your desired update rate
	/// in frames per second. A value of zero indicates that they can use
	/// all the time they want to.
	/// </summary>
	public virtual void SetDesiredUpdateRate(double arg0)
	{
		vtkRenderWindow_SetDesiredUpdateRate_105(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetDeviceIndex_106(HandleRef pThis, int _arg);

	/// <summary>
	/// If there are several graphics card installed on a system,
	/// this index can be used to specify which card you want to render to.
	/// the default is 0. This may not work on all derived render window and
	/// it may need to be set before the first render.
	/// </summary>
	public virtual void SetDeviceIndex(int _arg)
	{
		vtkRenderWindow_SetDeviceIndex_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetDisplayId_107(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override void SetDisplayId(IntPtr arg0)
	{
		vtkRenderWindow_SetDisplayId_107(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetForceMakeCurrent_108(HandleRef pThis);

	/// <summary>
	/// If called, allow MakeCurrent() to skip cache-check when called.
	/// MakeCurrent() reverts to original behavior of cache-checking
	/// on the next render.
	/// </summary>
	public virtual void SetForceMakeCurrent()
	{
		vtkRenderWindow_SetForceMakeCurrent_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetFullScreen_109(HandleRef pThis, int arg0);

	/// <summary>
	/// Turn on/off rendering full screen window size.
	/// </summary>
	public virtual void SetFullScreen(int arg0)
	{
		vtkRenderWindow_SetFullScreen_109(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetInAbortCheck_110(HandleRef pThis, int _arg);

	/// <summary>
	/// This is a flag that can be set to interrupt a rendering that is in
	/// progress.
	/// </summary>
	public virtual void SetInAbortCheck(int _arg)
	{
		vtkRenderWindow_SetInAbortCheck_110(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetInteractor_111(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the interactor to the render window
	/// </summary>
	public virtual void SetInteractor(vtkRenderWindowInteractor arg0)
	{
		vtkRenderWindow_SetInteractor_111(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetLineSmoothing_112(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off line smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void SetLineSmoothing(int _arg)
	{
		vtkRenderWindow_SetLineSmoothing_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetMultiSamples_113(HandleRef pThis, int arg0);

	/// <summary>
	/// Set / Get the number of multisamples to use for hardware antialiasing.
	/// A value of 1 will be set to 0.
	/// </summary>
	public virtual void SetMultiSamples(int arg0)
	{
		vtkRenderWindow_SetMultiSamples_113(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetNextWindowId_114(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public virtual void SetNextWindowId(IntPtr arg0)
	{
		vtkRenderWindow_SetNextWindowId_114(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetNextWindowInfo_115(HandleRef pThis, string arg0);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public virtual void SetNextWindowInfo(string arg0)
	{
		vtkRenderWindow_SetNextWindowInfo_115(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetNumberOfLayers_116(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the number of layers for renderers.  Each renderer should have
	/// its layer set individually.  Some algorithms iterate through all layers,
	/// so it is not wise to set the number of layers to be exorbitantly large
	/// (say bigger than 100).
	/// </summary>
	public virtual void SetNumberOfLayers(int _arg)
	{
		vtkRenderWindow_SetNumberOfLayers_116(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetParentId_117(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override void SetParentId(IntPtr arg0)
	{
		vtkRenderWindow_SetParentId_117(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetParentInfo_118(HandleRef pThis, string arg0);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override void SetParentInfo(string arg0)
	{
		vtkRenderWindow_SetParentInfo_118(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SetPixelData_119(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBRGBRGB. The
	/// front argument indicates if the front buffer should be used or the back
	/// buffer. It is the caller's responsibility to delete the resulting
	/// array. It is very important to realize that the memory in this array
	/// is organized from the bottom of the window to the top. The origin
	/// of the screen is in the lower left corner. The y axis increases as
	/// you go up the screen. So the storage of pixels is from left to right
	/// and from bottom to top.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual int SetPixelData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6)
	{
		return vtkRenderWindow_SetPixelData_119(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SetPixelData_120(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4, int arg5, int arg6);

	/// <summary>
	/// Set/Get the pixel data of an image, transmitted as RGBRGBRGB. The
	/// front argument indicates if the front buffer should be used or the back
	/// buffer. It is the caller's responsibility to delete the resulting
	/// array. It is very important to realize that the memory in this array
	/// is organized from the bottom of the window to the top. The origin
	/// of the screen is in the lower left corner. The y axis increases as
	/// you go up the screen. So the storage of pixels is from left to right
	/// and from bottom to top.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual int SetPixelData(int arg0, int arg1, int arg2, int arg3, vtkUnsignedCharArray arg4, int arg5, int arg6)
	{
		return vtkRenderWindow_SetPixelData_120(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef), arg5, arg6);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetPointSmoothing_121(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off point smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void SetPointSmoothing(int _arg)
	{
		vtkRenderWindow_SetPointSmoothing_121(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetPolygonSmoothing_122(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off polygon smoothing. Default is off.
	/// This must be applied before the first Render.
	/// </summary>
	public virtual void SetPolygonSmoothing(int _arg)
	{
		vtkRenderWindow_SetPolygonSmoothing_122(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SetRGBACharPixelData_123(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6, int arg7);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual int SetRGBACharPixelData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6, int arg7)
	{
		return vtkRenderWindow_SetRGBACharPixelData_123(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SetRGBACharPixelData_124(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4, int arg5, int arg6, int arg7);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual int SetRGBACharPixelData(int arg0, int arg1, int arg2, int arg3, vtkUnsignedCharArray arg4, int arg5, int arg6, int arg7)
	{
		return vtkRenderWindow_SetRGBACharPixelData_124(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef), arg5, arg6, arg7);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SetRGBAPixelData_125(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6, int arg7);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual int SetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4, int arg5, int arg6, int arg7)
	{
		return vtkRenderWindow_SetRGBAPixelData_125(GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SetRGBAPixelData_126(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4, int arg5, int arg6, int arg7);

	/// <summary>
	/// Same as Get/SetPixelData except that the image also contains an alpha
	/// component. The image is transmitted as RGBARGBARGBA... each of which is a
	/// float value. The "blend" parameter controls whether the SetRGBAPixelData
	/// method blends the data with the previous contents of the frame buffer
	/// or completely replaces the frame buffer data.
	/// </summary>
	public virtual int SetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, vtkFloatArray arg4, int arg5, int arg6, int arg7)
	{
		return vtkRenderWindow_SetRGBAPixelData_126(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef), arg5, arg6, arg7);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetSharedRenderWindow_127(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get an already existing window that this window should
	/// share data with if possible. This must be set
	/// after the shared render window has been created and initialized
	/// but before this window has been initialized. Not all platforms
	/// support data sharing.
	/// </summary>
	public virtual void SetSharedRenderWindow(vtkRenderWindow arg0)
	{
		vtkRenderWindow_SetSharedRenderWindow_127(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStencilCapable_128(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / Get the availability of the stencil buffer.
	/// </summary>
	public virtual void SetStencilCapable(int _arg)
	{
		vtkRenderWindow_SetStencilCapable_128(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoCapableWindow_129(HandleRef pThis, int capable);

	/// <summary>
	/// Prescribe that the window be created in a stereo-capable mode. This
	/// method must be called before the window is realized. Default is off.
	/// </summary>
	public virtual void SetStereoCapableWindow(int capable)
	{
		vtkRenderWindow_SetStereoCapableWindow_129(GetCppThis(), capable);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoRender_130(HandleRef pThis, int stereo);

	/// <summary>
	/// Turn on/off stereo rendering.
	/// </summary>
	public void SetStereoRender(int stereo)
	{
		vtkRenderWindow_SetStereoRender_130(GetCppThis(), stereo);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoType_131(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoType(int arg0)
	{
		vtkRenderWindow_SetStereoType_131(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToAnaglyph_132(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToAnaglyph()
	{
		vtkRenderWindow_SetStereoTypeToAnaglyph_132(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToCheckerboard_133(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToCheckerboard()
	{
		vtkRenderWindow_SetStereoTypeToCheckerboard_133(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToCrystalEyes_134(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToCrystalEyes()
	{
		vtkRenderWindow_SetStereoTypeToCrystalEyes_134(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToDresden_135(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToDresden()
	{
		vtkRenderWindow_SetStereoTypeToDresden_135(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToEmulate_136(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToEmulate()
	{
		vtkRenderWindow_SetStereoTypeToEmulate_136(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToFake_137(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToFake()
	{
		vtkRenderWindow_SetStereoTypeToFake_137(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToInterlaced_138(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToInterlaced()
	{
		vtkRenderWindow_SetStereoTypeToInterlaced_138(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToLeft_139(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToLeft()
	{
		vtkRenderWindow_SetStereoTypeToLeft_139(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToRedBlue_140(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToRedBlue()
	{
		vtkRenderWindow_SetStereoTypeToRedBlue_140(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToRight_141(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToRight()
	{
		vtkRenderWindow_SetStereoTypeToRight_141(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetStereoTypeToSplitViewportHorizontal_142(HandleRef pThis);

	/// <summary>
	/// Set/Get what type of stereo rendering to use.  CrystalEyes
	/// mode uses frame-sequential capabilities available in OpenGL
	/// to drive LCD shutter glasses and stereo projectors.  RedBlue
	/// mode is a simple type of stereo for use with red-blue glasses.
	/// Anaglyph mode is a superset of RedBlue mode, but the color
	/// output channels can be configured using the AnaglyphColorMask
	/// and the color of the original image can be (somewhat) maintained
	/// using AnaglyphColorSaturation;  the default colors for Anaglyph
	/// mode is red-cyan.  Interlaced stereo mode produces a composite
	/// image where horizontal lines alternate between left and right
	/// views.  StereoLeft and StereoRight modes choose one or the other
	/// stereo view.  Dresden mode is yet another stereoscopic
	/// interleaving. Fake simply causes the window to render twice without
	/// actually swapping the camera from left eye to right eye. This is useful in
	/// certain applications that want to emulate the rendering passes without
	/// actually rendering in stereo mode. Emulate is similar to Fake, except that
	/// it does render left and right eye. There is no compositing of the resulting
	/// images from the two eyes at the end of each render in this mode, hence the
	/// result onscreen will be the right eye.
	/// </summary>
	public void SetStereoTypeToSplitViewportHorizontal()
	{
		vtkRenderWindow_SetStereoTypeToSplitViewportHorizontal_142(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetSwapBuffers_143(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off buffer swapping between images.
	/// </summary>
	public virtual void SetSwapBuffers(int _arg)
	{
		vtkRenderWindow_SetSwapBuffers_143(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetUseSRGBColorSpace_144(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if we want this window to use the sRGB color space.
	/// Some hardware/drivers do not fully support this.
	/// </summary>
	public virtual void SetUseSRGBColorSpace(bool _arg)
	{
		vtkRenderWindow_SetUseSRGBColorSpace_144(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetWindowId_145(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override void SetWindowId(IntPtr arg0)
	{
		vtkRenderWindow_SetWindowId_145(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SetWindowInfo_146(HandleRef pThis, string arg0);

	/// <summary>
	/// Dummy stubs for vtkWindow API.
	/// </summary>
	public override void SetWindowInfo(string arg0)
	{
		vtkRenderWindow_SetWindowInfo_146(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SetZbufferData_147(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, IntPtr arg4);

	/// <summary>
	/// Set/Get the zbuffer data from the frame buffer.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual int SetZbufferData(int arg0, int arg1, int arg2, int arg3, IntPtr arg4)
	{
		return vtkRenderWindow_SetZbufferData_147(GetCppThis(), arg0, arg1, arg2, arg3, arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SetZbufferData_148(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

	/// <summary>
	/// Set/Get the zbuffer data from the frame buffer.
	/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
	/// the diagonal.
	/// </summary>
	public virtual int SetZbufferData(int arg0, int arg1, int arg2, int arg3, vtkFloatArray arg4)
	{
		return vtkRenderWindow_SetZbufferData_148(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_ShowCursor_149(HandleRef pThis);

	/// <summary>
	/// Hide or Show the mouse cursor, it is nice to be able to hide the
	/// default cursor if you want VTK to display a 3D cursor instead.
	/// Set cursor position in window (note that (0,0) is the lower left
	/// corner).
	/// </summary>
	public virtual void ShowCursor()
	{
		vtkRenderWindow_ShowCursor_149(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_Start_150(HandleRef pThis);

	/// <summary>
	/// Start the rendering process for a frame
	/// </summary>
	public virtual void Start()
	{
		vtkRenderWindow_Start_150(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StencilCapableOff_151(HandleRef pThis);

	/// <summary>
	/// Set / Get the availability of the stencil buffer.
	/// </summary>
	public virtual void StencilCapableOff()
	{
		vtkRenderWindow_StencilCapableOff_151(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StencilCapableOn_152(HandleRef pThis);

	/// <summary>
	/// Set / Get the availability of the stencil buffer.
	/// </summary>
	public virtual void StencilCapableOn()
	{
		vtkRenderWindow_StencilCapableOn_152(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StereoCapableWindowOff_153(HandleRef pThis);

	/// <summary>
	/// Prescribe that the window be created in a stereo-capable mode. This
	/// method must be called before the window is realized. Default is off.
	/// </summary>
	public virtual void StereoCapableWindowOff()
	{
		vtkRenderWindow_StereoCapableWindowOff_153(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StereoCapableWindowOn_154(HandleRef pThis);

	/// <summary>
	/// Prescribe that the window be created in a stereo-capable mode. This
	/// method must be called before the window is realized. Default is off.
	/// </summary>
	public virtual void StereoCapableWindowOn()
	{
		vtkRenderWindow_StereoCapableWindowOn_154(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StereoMidpoint_155(HandleRef pThis);

	/// <summary>
	/// Intermediate method performs operations required between the rendering
	/// of the left and right eye.
	/// </summary>
	public virtual void StereoMidpoint()
	{
		vtkRenderWindow_StereoMidpoint_155(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StereoRenderComplete_156(HandleRef pThis);

	/// <summary>
	/// Handles work required once both views have been rendered when using
	/// stereo rendering.
	/// </summary>
	public virtual void StereoRenderComplete()
	{
		vtkRenderWindow_StereoRenderComplete_156(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StereoRenderOff_157(HandleRef pThis);

	/// <summary>
	/// Turn on/off stereo rendering.
	/// </summary>
	public virtual void StereoRenderOff()
	{
		vtkRenderWindow_StereoRenderOff_157(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StereoRenderOn_158(HandleRef pThis);

	/// <summary>
	/// Turn on/off stereo rendering.
	/// </summary>
	public virtual void StereoRenderOn()
	{
		vtkRenderWindow_StereoRenderOn_158(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_StereoUpdate_159(HandleRef pThis);

	/// <summary>
	/// Update the system, if needed, due to stereo rendering. For some stereo
	/// methods, subclasses might need to switch some hardware settings here.
	/// </summary>
	public virtual void StereoUpdate()
	{
		vtkRenderWindow_StereoUpdate_159(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRenderWindow_SupportsOpenGL_160(HandleRef pThis);

	/// <summary>
	/// Does this render window support OpenGL? 0-false, 1-true
	/// </summary>
	public virtual int SupportsOpenGL()
	{
		return vtkRenderWindow_SupportsOpenGL_160(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SwapBuffersOff_161(HandleRef pThis);

	/// <summary>
	/// Turn on/off buffer swapping between images.
	/// </summary>
	public virtual void SwapBuffersOff()
	{
		vtkRenderWindow_SwapBuffersOff_161(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_SwapBuffersOn_162(HandleRef pThis);

	/// <summary>
	/// Turn on/off buffer swapping between images.
	/// </summary>
	public virtual void SwapBuffersOn()
	{
		vtkRenderWindow_SwapBuffersOn_162(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_UseSRGBColorSpaceOff_164(HandleRef pThis);

	/// <summary>
	/// Set/Get if we want this window to use the sRGB color space.
	/// Some hardware/drivers do not fully support this.
	/// </summary>
	public virtual void UseSRGBColorSpaceOff()
	{
		vtkRenderWindow_UseSRGBColorSpaceOff_164(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_UseSRGBColorSpaceOn_165(HandleRef pThis);

	/// <summary>
	/// Set/Get if we want this window to use the sRGB color space.
	/// Some hardware/drivers do not fully support this.
	/// </summary>
	public virtual void UseSRGBColorSpaceOn()
	{
		vtkRenderWindow_UseSRGBColorSpaceOn_165(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_WaitForCompletion_166(HandleRef pThis);

	/// <summary>
	/// Block the thread until the actual rendering is finished().
	/// Useful for measurement only.
	/// </summary>
	public virtual void WaitForCompletion()
	{
		vtkRenderWindow_WaitForCompletion_166(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRenderWindow_WindowRemap_167(HandleRef pThis);

	/// <summary>
	/// Remap the rendering window. This probably only works on UNIX right now.
	/// It is useful for changing properties that can't normally be changed
	/// once the window is up.
	/// </summary>
	public virtual void WindowRemap()
	{
		vtkRenderWindow_WindowRemap_167(GetCppThis());
	}
}
