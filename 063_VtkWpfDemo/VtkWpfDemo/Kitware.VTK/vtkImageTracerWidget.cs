using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageTracerWidget
/// </summary>
/// <remarks>
///    3D widget for tracing on planar props.
///
/// vtkImageTracerWidget is different from other widgets in three distinct ways:
/// 1) any sub-class of vtkProp can be input rather than just vtkProp3D, so that
/// vtkImageActor can be set as the prop and then traced over, 2) the widget fires
/// pick events at the input prop to decide where to move its handles, 3) the
/// widget has 2D glyphs for handles instead of 3D spheres as is done in other
/// sub-classes of vtk3DWidget. This widget is primarily designed for manually
/// tracing over image data.
/// The button actions and key modifiers are as follows for controlling the
/// widget:
/// 1) left button click over the image, hold and drag draws a free hand line.
/// 2) left button click and release erases the widget line,
/// if it exists, and repositions the first handle.
/// 3) middle button click starts a snap drawn line.  The line is terminated by
/// clicking the middle button while depressing the ctrl key.
/// 4) when tracing a continuous or snap drawn line, if the last cursor position
/// is within a specified tolerance to the first handle, the widget line will form
/// a closed loop.
/// 5) right button clicking and holding on any handle that is part of a snap
/// drawn line allows handle dragging: existing line segments are updated
/// accordingly.  If the path is open and AutoClose is set to On, the path can
/// be closed by repositioning the first and last points over one another.
/// 6) ctrl key + right button down on any handle will erase it: existing
/// snap drawn line segments are updated accordingly.  If the line was formed by
/// continuous tracing, the line is deleted leaving one handle.
/// 7) shift key + right button down on any snap drawn line segment will insert
/// a handle at the cursor position.  The line segment is split accordingly.
///
/// @warning
/// the input vtkDataSet should be vtkImageData.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkLineWidget vtkPointWidget vtkSphereWidget
/// vtkImagePlaneWidget vtkImplicitPlaneWidget vtkPlaneWidget
/// </seealso>
public class vtkImageTracerWidget : vtk3DWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageTracerWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageTracerWidget()
	{
		MRClassNameKey = "class vtkImageTracerWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageTracerWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageTracerWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkImageTracerWidget New()
	{
		vtkImageTracerWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTracerWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkImageTracerWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageTracerWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_AutoCloseOff_01(HandleRef pThis);

	/// <summary>
	/// In concert with a CaptureRadius value, automatically
	/// form a closed path by connecting first to last path points.
	/// Default is Off.
	/// </summary>
	public virtual void AutoCloseOff()
	{
		vtkImageTracerWidget_AutoCloseOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_AutoCloseOn_02(HandleRef pThis);

	/// <summary>
	/// In concert with a CaptureRadius value, automatically
	/// form a closed path by connecting first to last path points.
	/// Default is Off.
	/// </summary>
	public virtual void AutoCloseOn()
	{
		vtkImageTracerWidget_AutoCloseOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetAutoClose_03(HandleRef pThis);

	/// <summary>
	/// In concert with a CaptureRadius value, automatically
	/// form a closed path by connecting first to last path points.
	/// Default is Off.
	/// </summary>
	public virtual int GetAutoClose()
	{
		return vtkImageTracerWidget_GetAutoClose_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageTracerWidget_GetCaptureRadius_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the capture radius for automatic path closing.  For image
	/// data, capture radius should be half the distance between voxel/pixel
	/// centers.
	/// Default is 1.0
	/// </summary>
	public virtual double GetCaptureRadius()
	{
		return vtkImageTracerWidget_GetCaptureRadius_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_GetGlyphSource_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handles' geometric representation via vtkGlyphSource2D.
	/// </summary>
	public vtkGlyphSource2D GetGlyphSource()
	{
		vtkGlyphSource2D vtkGlyphSource2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTracerWidget_GetGlyphSource_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGlyphSource2D2 = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGlyphSource2D2.Register(null);
			}
		}
		return vtkGlyphSource2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetHandleLeftMouseButton_06(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual int GetHandleLeftMouseButton()
	{
		return vtkImageTracerWidget_GetHandleLeftMouseButton_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetHandleMiddleMouseButton_07(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual int GetHandleMiddleMouseButton()
	{
		return vtkImageTracerWidget_GetHandleMiddleMouseButton_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_GetHandlePosition_08(HandleRef pThis, int handle, IntPtr xyz);

	/// <summary>
	/// Set/Get the handle position in terms of a zero-based array of handles.
	/// </summary>
	public void GetHandlePosition(int handle, IntPtr xyz)
	{
		vtkImageTracerWidget_GetHandlePosition_08(GetCppThis(), handle, xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_GetHandlePosition_09(HandleRef pThis, int handle);

	/// <summary>
	/// Set/Get the handle position in terms of a zero-based array of handles.
	/// </summary>
	public double[] GetHandlePosition(int handle)
	{
		IntPtr intPtr = vtkImageTracerWidget_GetHandlePosition_09(GetCppThis(), handle);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_GetHandleProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties (the 2D glyphs are the handles). The
	/// properties of the handles when selected and normal can be manipulated.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTracerWidget_GetHandleProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetHandleRightMouseButton_11(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual int GetHandleRightMouseButton()
	{
		return vtkImageTracerWidget_GetHandleRightMouseButton_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetImageSnapType_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of snapping to image data: center of a pixel/voxel or
	/// nearest point defining a pixel/voxel.
	/// </summary>
	public virtual int GetImageSnapType()
	{
		return vtkImageTracerWidget_GetImageSnapType_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetImageSnapTypeMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of snapping to image data: center of a pixel/voxel or
	/// nearest point defining a pixel/voxel.
	/// </summary>
	public virtual int GetImageSnapTypeMaxValue()
	{
		return vtkImageTracerWidget_GetImageSnapTypeMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetImageSnapTypeMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of snapping to image data: center of a pixel/voxel or
	/// nearest point defining a pixel/voxel.
	/// </summary>
	public virtual int GetImageSnapTypeMinValue()
	{
		return vtkImageTracerWidget_GetImageSnapTypeMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetInteraction_15(HandleRef pThis);

	/// <summary>
	/// Enable/disable mouse interaction when the widget is visible.
	/// </summary>
	public virtual int GetInteraction()
	{
		return vtkImageTracerWidget_GetInteraction_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_GetLineProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTracerWidget_GetLineProperty_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageTracerWidget_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageTracerWidget_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageTracerWidget_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageTracerWidget_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetNumberOfHandles_19(HandleRef pThis);

	/// <summary>
	/// Get the number of handles.
	/// </summary>
	public virtual int GetNumberOfHandles()
	{
		return vtkImageTracerWidget_GetNumberOfHandles_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_GetPath_20(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the points and lines that define the traced path. These point values
	/// are guaranteed to be up-to-date when either the InteractionEvent or
	/// EndInteraction events are invoked. The user provides the vtkPolyData and
	/// the points and cells representing the line are added to it.
	/// </summary>
	public void GetPath(vtkPolyData pd)
	{
		vtkImageTracerWidget_GetPath_20(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetProjectToPlane_21(HandleRef pThis);

	/// <summary>
	/// Force handles to be on a specific ortho plane. Default is Off.
	/// </summary>
	public virtual int GetProjectToPlane()
	{
		return vtkImageTracerWidget_GetProjectToPlane_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetProjectionNormal_22(HandleRef pThis);

	/// <summary>
	/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
	/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
	/// necessary to specify a plane on which to generate them, even though
	/// ProjectToPlane may be turned off.
	/// </summary>
	public virtual int GetProjectionNormal()
	{
		return vtkImageTracerWidget_GetProjectionNormal_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetProjectionNormalMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
	/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
	/// necessary to specify a plane on which to generate them, even though
	/// ProjectToPlane may be turned off.
	/// </summary>
	public virtual int GetProjectionNormalMaxValue()
	{
		return vtkImageTracerWidget_GetProjectionNormalMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetProjectionNormalMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
	/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
	/// necessary to specify a plane on which to generate them, even though
	/// ProjectToPlane may be turned off.
	/// </summary>
	public virtual int GetProjectionNormalMinValue()
	{
		return vtkImageTracerWidget_GetProjectionNormalMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageTracerWidget_GetProjectionPosition_25(HandleRef pThis);

	/// <summary>
	/// Set the position of the widgets' handles in terms of a plane's position.
	/// e.g., if ProjectionNormal is 0, all of the x-coordinate values of the
	/// handles are set to ProjectionPosition.  No attempt is made to ensure that
	/// the position is within the bounds of either the underlying image data or
	/// the prop on which tracing is performed.
	/// </summary>
	public virtual double GetProjectionPosition()
	{
		return vtkImageTracerWidget_GetProjectionPosition_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_GetSelectedHandleProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties (the 2D glyphs are the handles). The
	/// properties of the handles when selected and normal can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTracerWidget_GetSelectedHandleProperty_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_GetSelectedLineProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTracerWidget_GetSelectedLineProperty_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_GetSnapToImage_28(HandleRef pThis);

	/// <summary>
	/// Force snapping to image data while tracing. Default is Off.
	/// </summary>
	public virtual int GetSnapToImage()
	{
		return vtkImageTracerWidget_GetSnapToImage_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_HandleLeftMouseButtonOff_29(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void HandleLeftMouseButtonOff()
	{
		vtkImageTracerWidget_HandleLeftMouseButtonOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_HandleLeftMouseButtonOn_30(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void HandleLeftMouseButtonOn()
	{
		vtkImageTracerWidget_HandleLeftMouseButtonOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_HandleMiddleMouseButtonOff_31(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void HandleMiddleMouseButtonOff()
	{
		vtkImageTracerWidget_HandleMiddleMouseButtonOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_HandleMiddleMouseButtonOn_32(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void HandleMiddleMouseButtonOn()
	{
		vtkImageTracerWidget_HandleMiddleMouseButtonOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_HandleRightMouseButtonOff_33(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void HandleRightMouseButtonOff()
	{
		vtkImageTracerWidget_HandleRightMouseButtonOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_HandleRightMouseButtonOn_34(HandleRef pThis);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void HandleRightMouseButtonOn()
	{
		vtkImageTracerWidget_HandleRightMouseButtonOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_InitializeHandles_35(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Initialize the widget with a set of points and generate
	/// lines between them.  If AutoClose is on it will handle the
	/// case wherein the first and last points are congruent.
	/// </summary>
	public void InitializeHandles(vtkPoints arg0)
	{
		vtkImageTracerWidget_InitializeHandles_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_InteractionOff_36(HandleRef pThis);

	/// <summary>
	/// Enable/disable mouse interaction when the widget is visible.
	/// </summary>
	public virtual void InteractionOff()
	{
		vtkImageTracerWidget_InteractionOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_InteractionOn_37(HandleRef pThis);

	/// <summary>
	/// Enable/disable mouse interaction when the widget is visible.
	/// </summary>
	public virtual void InteractionOn()
	{
		vtkImageTracerWidget_InteractionOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_IsA_38(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageTracerWidget_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_IsClosed_39(HandleRef pThis);

	/// <summary>
	/// Is the path closed or open?
	/// </summary>
	public int IsClosed()
	{
		return vtkImageTracerWidget_IsClosed_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageTracerWidget_IsTypeOf_40(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageTracerWidget_IsTypeOf_40(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkImageTracerWidget NewInstance()
	{
		vtkImageTracerWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTracerWidget_NewInstance_42(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_PlaceWidget_43(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkImageTracerWidget_PlaceWidget_43(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_PlaceWidget_44(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkImageTracerWidget_PlaceWidget_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_PlaceWidget_45(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkImageTracerWidget_PlaceWidget_45(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_ProjectToPlaneOff_46(HandleRef pThis);

	/// <summary>
	/// Force handles to be on a specific ortho plane. Default is Off.
	/// </summary>
	public virtual void ProjectToPlaneOff()
	{
		vtkImageTracerWidget_ProjectToPlaneOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_ProjectToPlaneOn_47(HandleRef pThis);

	/// <summary>
	/// Force handles to be on a specific ortho plane. Default is Off.
	/// </summary>
	public virtual void ProjectToPlaneOn()
	{
		vtkImageTracerWidget_ProjectToPlaneOn_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageTracerWidget_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkImageTracerWidget SafeDownCast(vtkObjectBase o)
	{
		vtkImageTracerWidget vtkImageTracerWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageTracerWidget_SafeDownCast_48(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageTracerWidget2 = (vtkImageTracerWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageTracerWidget2.Register(null);
			}
		}
		return vtkImageTracerWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetAutoClose_49(HandleRef pThis, int _arg);

	/// <summary>
	/// In concert with a CaptureRadius value, automatically
	/// form a closed path by connecting first to last path points.
	/// Default is Off.
	/// </summary>
	public virtual void SetAutoClose(int _arg)
	{
		vtkImageTracerWidget_SetAutoClose_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetCaptureRadius_50(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the capture radius for automatic path closing.  For image
	/// data, capture radius should be half the distance between voxel/pixel
	/// centers.
	/// Default is 1.0
	/// </summary>
	public virtual void SetCaptureRadius(double _arg)
	{
		vtkImageTracerWidget_SetCaptureRadius_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetEnabled_51(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkImageTracerWidget_SetEnabled_51(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetHandleLeftMouseButton_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void SetHandleLeftMouseButton(int _arg)
	{
		vtkImageTracerWidget_SetHandleLeftMouseButton_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetHandleMiddleMouseButton_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void SetHandleMiddleMouseButton(int _arg)
	{
		vtkImageTracerWidget_SetHandleMiddleMouseButton_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetHandlePosition_54(HandleRef pThis, int handle, IntPtr xyz);

	/// <summary>
	/// Set/Get the handle position in terms of a zero-based array of handles.
	/// </summary>
	public void SetHandlePosition(int handle, IntPtr xyz)
	{
		vtkImageTracerWidget_SetHandlePosition_54(GetCppThis(), handle, xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetHandlePosition_55(HandleRef pThis, int handle, double x, double y, double z);

	/// <summary>
	/// Set/Get the handle position in terms of a zero-based array of handles.
	/// </summary>
	public void SetHandlePosition(int handle, double x, double y, double z)
	{
		vtkImageTracerWidget_SetHandlePosition_55(GetCppThis(), handle, x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetHandleProperty_56(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties (the 2D glyphs are the handles). The
	/// properties of the handles when selected and normal can be manipulated.
	/// </summary>
	public virtual void SetHandleProperty(vtkProperty arg0)
	{
		vtkImageTracerWidget_SetHandleProperty_56(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetHandleRightMouseButton_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/Disable mouse button events
	/// </summary>
	public virtual void SetHandleRightMouseButton(int _arg)
	{
		vtkImageTracerWidget_SetHandleRightMouseButton_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetImageSnapType_58(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the type of snapping to image data: center of a pixel/voxel or
	/// nearest point defining a pixel/voxel.
	/// </summary>
	public virtual void SetImageSnapType(int _arg)
	{
		vtkImageTracerWidget_SetImageSnapType_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetInteraction_59(HandleRef pThis, int interact);

	/// <summary>
	/// Enable/disable mouse interaction when the widget is visible.
	/// </summary>
	public void SetInteraction(int interact)
	{
		vtkImageTracerWidget_SetInteraction_59(GetCppThis(), interact);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetLineProperty_60(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual void SetLineProperty(vtkProperty arg0)
	{
		vtkImageTracerWidget_SetLineProperty_60(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetProjectToPlane_61(HandleRef pThis, int _arg);

	/// <summary>
	/// Force handles to be on a specific ortho plane. Default is Off.
	/// </summary>
	public virtual void SetProjectToPlane(int _arg)
	{
		vtkImageTracerWidget_SetProjectToPlane_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetProjectionNormal_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
	/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
	/// necessary to specify a plane on which to generate them, even though
	/// ProjectToPlane may be turned off.
	/// </summary>
	public virtual void SetProjectionNormal(int _arg)
	{
		vtkImageTracerWidget_SetProjectionNormal_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetProjectionNormalToXAxes_63(HandleRef pThis);

	/// <summary>
	/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
	/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
	/// necessary to specify a plane on which to generate them, even though
	/// ProjectToPlane may be turned off.
	/// </summary>
	public void SetProjectionNormalToXAxes()
	{
		vtkImageTracerWidget_SetProjectionNormalToXAxes_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetProjectionNormalToYAxes_64(HandleRef pThis);

	/// <summary>
	/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
	/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
	/// necessary to specify a plane on which to generate them, even though
	/// ProjectToPlane may be turned off.
	/// </summary>
	public void SetProjectionNormalToYAxes()
	{
		vtkImageTracerWidget_SetProjectionNormalToYAxes_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetProjectionNormalToZAxes_65(HandleRef pThis);

	/// <summary>
	/// Set the projection normal.  The normal in SetProjectionNormal is 0,1,2
	/// for YZ,XZ,XY planes respectively.  Since the handles are 2D glyphs, it is
	/// necessary to specify a plane on which to generate them, even though
	/// ProjectToPlane may be turned off.
	/// </summary>
	public void SetProjectionNormalToZAxes()
	{
		vtkImageTracerWidget_SetProjectionNormalToZAxes_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetProjectionPosition_66(HandleRef pThis, double position);

	/// <summary>
	/// Set the position of the widgets' handles in terms of a plane's position.
	/// e.g., if ProjectionNormal is 0, all of the x-coordinate values of the
	/// handles are set to ProjectionPosition.  No attempt is made to ensure that
	/// the position is within the bounds of either the underlying image data or
	/// the prop on which tracing is performed.
	/// </summary>
	public void SetProjectionPosition(double position)
	{
		vtkImageTracerWidget_SetProjectionPosition_66(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetSelectedHandleProperty_67(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties (the 2D glyphs are the handles). The
	/// properties of the handles when selected and normal can be manipulated.
	/// </summary>
	public virtual void SetSelectedHandleProperty(vtkProperty arg0)
	{
		vtkImageTracerWidget_SetSelectedHandleProperty_67(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetSelectedLineProperty_68(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual void SetSelectedLineProperty(vtkProperty arg0)
	{
		vtkImageTracerWidget_SetSelectedLineProperty_68(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetSnapToImage_69(HandleRef pThis, int snap);

	/// <summary>
	/// Force snapping to image data while tracing. Default is Off.
	/// </summary>
	public void SetSnapToImage(int snap)
	{
		vtkImageTracerWidget_SetSnapToImage_69(GetCppThis(), snap);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SetViewProp_70(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Set the prop, usually a vtkImageActor, to trace over.
	/// </summary>
	public void SetViewProp(vtkProp prop)
	{
		vtkImageTracerWidget_SetViewProp_70(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SnapToImageOff_71(HandleRef pThis);

	/// <summary>
	/// Force snapping to image data while tracing. Default is Off.
	/// </summary>
	public virtual void SnapToImageOff()
	{
		vtkImageTracerWidget_SnapToImageOff_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageTracerWidget_SnapToImageOn_72(HandleRef pThis);

	/// <summary>
	/// Force snapping to image data while tracing. Default is Off.
	/// </summary>
	public virtual void SnapToImageOn()
	{
		vtkImageTracerWidget_SnapToImageOn_72(GetCppThis());
	}
}
