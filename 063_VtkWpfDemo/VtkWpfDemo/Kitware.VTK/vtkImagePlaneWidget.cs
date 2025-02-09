using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImagePlaneWidget
/// </summary>
/// <remarks>
///    3D widget for reslicing image data
///
/// This 3D widget defines a plane that can be interactively placed in an
/// image volume. A nice feature of the object is that the
/// vtkImagePlaneWidget, like any 3D widget, will work with the current
/// interactor style. That is, if vtkImagePlaneWidget does not handle an
/// event, then all other registered observers (including the interactor
/// style) have an opportunity to process the event. Otherwise, the
/// vtkImagePlaneWidget will terminate the processing of the event that it
/// handles.
///
/// The core functionality of the widget is provided by a vtkImageReslice
/// object which passes its output onto a texture mapping pipeline for fast
/// slicing through volumetric data. See the key methods: GenerateTexturePlane()
/// and UpdatePlane() for implementation details.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. If the "i" key (for
/// "interactor") is pressed, the vtkImagePlaneWidget will appear. (See
/// superclass documentation for information about changing this behavior.)
///
/// Selecting the widget with the middle mouse button with and without holding
/// the shift or control keys enables complex reslicing capablilites.
/// To facilitate use, a set of 'margins' (left, right, top, bottom) are shown as
/// a set of plane-axes aligned lines, the properties of which can be changed
/// as a group.
/// Without keyboard modifiers: selecting in the middle of the margins
/// enables translation of the plane along its normal. Selecting one of the
/// corners within the margins enables spinning around the plane's normal at its
/// center.  Selecting within a margin allows rotating about the center of the
/// plane around an axis aligned with the margin (i.e., selecting left margin
/// enables rotating around the plane's local y-prime axis).
/// With control key modifier: margin selection enables edge translation (i.e., a
/// constrained form of scaling). Selecting within the margins enables
/// translation of the entire plane.
/// With shift key modifier: uniform plane scaling is enabled.  Moving the mouse
/// up enlarges the plane while downward movement shrinks it.
///
/// Window-level is achieved by using the right mouse button.  Window-level
/// values can be reset by shift + 'r' or control + 'r' while regular reset
/// camera is maintained with 'r' or 'R'.
/// The left mouse button can be used to query the underlying image data
/// with a snap-to cross-hair cursor.  Currently, the nearest point in the input
/// image data to the mouse cursor generates the cross-hairs.  With oblique
/// slicing, this behaviour may appear unsatisfactory. Text display of
/// window-level and image coordinates/data values are provided by a text
/// actor/mapper pair.
///
/// Events that occur outside of the widget (i.e., no part of the widget is
/// picked) are propagated to any other registered obsevers (such as the
/// interaction style). Turn off the widget by pressing the "i" key again
/// (or invoke the Off() method). To support interactive manipulation of
/// objects, this class invokes the events StartInteractionEvent,
/// InteractionEvent, and EndInteractionEvent as well as StartWindowLevelEvent,
/// WindowLevelEvent, EndWindowLevelEvent and ResetWindowLevelEvent.
///
/// The vtkImagePlaneWidget has several methods that can be used in
/// conjunction with other VTK objects. The GetPolyData() method can be used
/// to get the polygonal representation of the plane and can be used as input
/// for other VTK objects. Typical usage of the widget is to make use of the
/// StartInteractionEvent, InteractionEvent, and EndInteractionEvent
/// events. The InteractionEvent is called on mouse motion; the other two
/// events are called on button down and button up (either left or right
/// button).
///
/// Some additional features of this class include the ability to control the
/// properties of the widget. You can set the properties of: the selected and
/// unselected representations of the plane's outline; the text actor via its
/// vtkTextProperty; the cross-hair cursor. In addition there are methods to
/// constrain the plane so that it is aligned along the x-y-z axes.  Finally,
/// one can specify the degree of interpolation (vtkImageReslice): nearest
/// neighbour, linear, and cubic.
///
/// A simpler version of this widget is the combination of
/// vtkImplicitPlaneWidget2 combined with the representation
/// vtkImplicitImageRepresentation.
///
/// @par Thanks:
/// Thanks to Dean Inglis for developing and contributing this class.
/// Based on the Python SlicePlaneFactory from Atamai, Inc.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkBoxWidget vtkLineWidget  vtkPlaneWidget vtkPointWidget
/// vtkPolyDataSourceWidget vtkSphereWidget vtkImplicitPlaneWidget
/// vtkImplicitPlaneWidget2 vtkImplicitImageRepresentation
/// </seealso>
public class vtkImagePlaneWidget : vtkPolyDataSourceWidget
{
	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public enum VTK_CURSOR_ACTION_WrapperEnum
	{
		/// <summary>enum member</summary>
		VTK_CURSOR_ACTION,
		/// <summary>enum member</summary>
		VTK_SLICE_MOTION_ACTION,
		/// <summary>enum member</summary>
		VTK_WINDOW_LEVEL_ACTION
	}

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public enum VTK_CONTROL_MODIFIER_WrapperEnum
	{
		/// <summary>enum member</summary>
		VTK_CONTROL_MODIFIER = 2,
		/// <summary>enum member</summary>
		VTK_NO_MODIFIER = 0,
		/// <summary>enum member</summary>
		VTK_SHIFT_MODIFIER = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImagePlaneWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImagePlaneWidget()
	{
		MRClassNameKey = "class vtkImagePlaneWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePlaneWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImagePlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkImagePlaneWidget New()
	{
		vtkImagePlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkImagePlaneWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImagePlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImagePlaneWidget_DisplayTextOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable text display of window-level, image coordinates and
	/// scalar values in a render window.
	/// </summary>
	public virtual void DisplayTextOff()
	{
		vtkImagePlaneWidget_DisplayTextOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_DisplayTextOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable text display of window-level, image coordinates and
	/// scalar values in a render window.
	/// </summary>
	public virtual void DisplayTextOn()
	{
		vtkImagePlaneWidget_DisplayTextOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetCenter_03(HandleRef pThis);

	/// <summary>
	/// Get the center of the plane.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkImagePlaneWidget_GetCenter_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetCenter_04(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the center of the plane.
	/// </summary>
	public void GetCenter(IntPtr xyz)
	{
		vtkImagePlaneWidget_GetCenter_04(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetColorMap_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get the vtkImageMapToColors filter used by this
	/// widget.  The user can properly render other transparent actors in a
	/// scene by calling the filter's SetOutputFormatToRGB and
	/// PassAlphaToOutputOff.
	/// </summary>
	public virtual vtkImageMapToColors GetColorMap()
	{
		vtkImageMapToColors vtkImageMapToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetColorMap_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapToColors2 = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapToColors2.Register(null);
			}
		}
		return vtkImageMapToColors2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetCurrentCursorPosition_06(HandleRef pThis);

	/// <summary>
	/// Get the current cursor position.  To be used in conjunction with
	/// GetCursorDataStatus.
	/// </summary>
	public virtual double[] GetCurrentCursorPosition()
	{
		IntPtr intPtr = vtkImagePlaneWidget_GetCurrentCursorPosition_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetCurrentCursorPosition_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get the current cursor position.  To be used in conjunction with
	/// GetCursorDataStatus.
	/// </summary>
	public virtual void GetCurrentCursorPosition(IntPtr data)
	{
		vtkImagePlaneWidget_GetCurrentCursorPosition_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetCurrentImageValue_08(HandleRef pThis);

	/// <summary>
	/// Get the current image value at the current cursor position.  To
	/// be used in conjunction with GetCursorDataStatus.  The value is
	/// VTK_DOUBLE_MAX when the data is invalid.
	/// </summary>
	public virtual double GetCurrentImageValue()
	{
		return vtkImagePlaneWidget_GetCurrentImageValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetCursorData_09(HandleRef pThis, IntPtr xyzv);

	/// <summary>
	/// Get the image coordinate position and voxel value.  Currently only
	/// supports single component image data.
	/// </summary>
	public int GetCursorData(IntPtr xyzv)
	{
		return vtkImagePlaneWidget_GetCursorData_09(GetCppThis(), xyzv);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetCursorDataStatus_10(HandleRef pThis);

	/// <summary>
	/// Get the status of the cursor data.  If this returns 1 the
	/// CurrentCursorPosition and CurrentImageValue will have current
	/// data.  If it returns 0, these values are invalid.
	/// </summary>
	public int GetCursorDataStatus()
	{
		return vtkImagePlaneWidget_GetCursorDataStatus_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetCursorProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the properties of the cross-hair cursor.
	/// </summary>
	public virtual vtkProperty GetCursorProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetCursorProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImagePlaneWidget_GetDisplayText_12(HandleRef pThis);

	/// <summary>
	/// Enable/disable text display of window-level, image coordinates and
	/// scalar values in a render window.
	/// </summary>
	public virtual int GetDisplayText()
	{
		return vtkImagePlaneWidget_GetDisplayText_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetInteraction_13(HandleRef pThis);

	/// <summary>
	/// Enable/disable mouse interaction so the widget remains on display.
	/// </summary>
	public virtual int GetInteraction()
	{
		return vtkImagePlaneWidget_GetInteraction_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetLeftButtonAction_14(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetLeftButtonAction()
	{
		return vtkImagePlaneWidget_GetLeftButtonAction_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetLeftButtonActionMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetLeftButtonActionMaxValue()
	{
		return vtkImagePlaneWidget_GetLeftButtonActionMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetLeftButtonActionMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetLeftButtonActionMinValue()
	{
		return vtkImagePlaneWidget_GetLeftButtonActionMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifier_17(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetLeftButtonAutoModifier()
	{
		return vtkImagePlaneWidget_GetLeftButtonAutoModifier_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifierMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetLeftButtonAutoModifierMaxValue()
	{
		return vtkImagePlaneWidget_GetLeftButtonAutoModifierMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifierMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetLeftButtonAutoModifierMinValue()
	{
		return vtkImagePlaneWidget_GetLeftButtonAutoModifierMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetLevel_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public double GetLevel()
	{
		return vtkImagePlaneWidget_GetLevel_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetLookupTable_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
	/// alternatively, to the lut of another vtkImgePlaneWidget.  In this way,
	/// a set of three orthogonal planes can share the same lut so that
	/// window-levelling is performed uniformly among planes.  The default
	/// internal lut can be re- set/allocated by setting to 0 (nullptr).
	/// </summary>
	public virtual vtkLookupTable GetLookupTable()
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetLookupTable_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLookupTable2 = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLookupTable2.Register(null);
			}
		}
		return vtkLookupTable2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetMarginProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the properties of the margins.
	/// </summary>
	public virtual vtkProperty GetMarginProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetMarginProperty_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImagePlaneWidget_GetMarginSizeX_23(HandleRef pThis);

	/// <summary>
	/// Set the size of the margins based on a percentage of the
	/// plane's width and height, limited between 0 and 50%.
	/// </summary>
	public virtual double GetMarginSizeX()
	{
		return vtkImagePlaneWidget_GetMarginSizeX_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetMarginSizeXMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Set the size of the margins based on a percentage of the
	/// plane's width and height, limited between 0 and 50%.
	/// </summary>
	public virtual double GetMarginSizeXMaxValue()
	{
		return vtkImagePlaneWidget_GetMarginSizeXMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetMarginSizeXMinValue_25(HandleRef pThis);

	/// <summary>
	/// Set the size of the margins based on a percentage of the
	/// plane's width and height, limited between 0 and 50%.
	/// </summary>
	public virtual double GetMarginSizeXMinValue()
	{
		return vtkImagePlaneWidget_GetMarginSizeXMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetMarginSizeY_26(HandleRef pThis);

	/// <summary>
	/// Set the size of the margins based on a percentage of the
	/// plane's width and height, limited between 0 and 50%.
	/// </summary>
	public virtual double GetMarginSizeY()
	{
		return vtkImagePlaneWidget_GetMarginSizeY_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetMarginSizeYMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Set the size of the margins based on a percentage of the
	/// plane's width and height, limited between 0 and 50%.
	/// </summary>
	public virtual double GetMarginSizeYMaxValue()
	{
		return vtkImagePlaneWidget_GetMarginSizeYMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetMarginSizeYMinValue_28(HandleRef pThis);

	/// <summary>
	/// Set the size of the margins based on a percentage of the
	/// plane's width and height, limited between 0 and 50%.
	/// </summary>
	public virtual double GetMarginSizeYMinValue()
	{
		return vtkImagePlaneWidget_GetMarginSizeYMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetMiddleButtonAction_29(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetMiddleButtonAction()
	{
		return vtkImagePlaneWidget_GetMiddleButtonAction_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetMiddleButtonActionMaxValue_30(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetMiddleButtonActionMaxValue()
	{
		return vtkImagePlaneWidget_GetMiddleButtonActionMaxValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetMiddleButtonActionMinValue_31(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetMiddleButtonActionMinValue()
	{
		return vtkImagePlaneWidget_GetMiddleButtonActionMinValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifier_32(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetMiddleButtonAutoModifier()
	{
		return vtkImagePlaneWidget_GetMiddleButtonAutoModifier_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifierMaxValue_33(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetMiddleButtonAutoModifierMaxValue()
	{
		return vtkImagePlaneWidget_GetMiddleButtonAutoModifierMaxValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifierMinValue_34(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetMiddleButtonAutoModifierMinValue()
	{
		return vtkImagePlaneWidget_GetMiddleButtonAutoModifierMinValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetNormal_35(HandleRef pThis);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public double[] GetNormal()
	{
		IntPtr intPtr = vtkImagePlaneWidget_GetNormal_35(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetNormal_36(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Get the normal to the plane.
	/// </summary>
	public void GetNormal(IntPtr xyz)
	{
		vtkImagePlaneWidget_GetNormal_36(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImagePlaneWidget_GetNumberOfGenerationsFromBase_37(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImagePlaneWidget_GetNumberOfGenerationsFromBase_37(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImagePlaneWidget_GetNumberOfGenerationsFromBaseType_38(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImagePlaneWidget_GetNumberOfGenerationsFromBaseType_38(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetOrigin_39(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public double[] GetOrigin()
	{
		IntPtr intPtr = vtkImagePlaneWidget_GetOrigin_39(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetOrigin_40(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void GetOrigin(IntPtr xyz)
	{
		vtkImagePlaneWidget_GetOrigin_40(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetPlaneOrientation_41(HandleRef pThis);

	/// <summary>
	/// Convenience method sets the plane orientation normal to the
	/// x, y, or z axes.  Default is XAxes (0).
	/// </summary>
	public virtual int GetPlaneOrientation()
	{
		return vtkImagePlaneWidget_GetPlaneOrientation_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetPlaneProperty_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the plane's outline properties. The properties of the plane's
	/// outline when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetPlaneProperty_42(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImagePlaneWidget_GetPoint1_43(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the point defining the first axis of the plane.
	/// </summary>
	public double[] GetPoint1()
	{
		IntPtr intPtr = vtkImagePlaneWidget_GetPoint1_43(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetPoint1_44(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point defining the first axis of the plane.
	/// </summary>
	public void GetPoint1(IntPtr xyz)
	{
		vtkImagePlaneWidget_GetPoint1_44(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetPoint2_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the point defining the second axis of the plane.
	/// </summary>
	public double[] GetPoint2()
	{
		IntPtr intPtr = vtkImagePlaneWidget_GetPoint2_45(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetPoint2_46(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point defining the second axis of the plane.
	/// </summary>
	public void GetPoint2(IntPtr xyz)
	{
		vtkImagePlaneWidget_GetPoint2_46(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetPolyData_47(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the plane.  The
	/// polydata consists of (res+1)*(res+1) points, and res*res quadrilateral
	/// polygons, where res is the resolution of the plane. These point values
	/// are guaranteed to be up-to-date when either the InteractionEvent or
	/// EndInteraction events are invoked. The user provides the vtkPolyData and
	/// the points and polygons are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkImagePlaneWidget_GetPolyData_47(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetPolyDataAlgorithm_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Satisfies superclass API.  This returns a pointer to the underlying
	/// vtkPolyData.  Make changes to this before calling the initial PlaceWidget()
	/// to have the initial placement follow suit.  Or, make changes after the
	/// widget has been initialised and call UpdatePlacement() to realise.
	/// </summary>
	public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
	{
		vtkPolyDataAlgorithm vtkPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetPolyDataAlgorithm_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataAlgorithm2 = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetReslice_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the current reslice class and reslice axes
	/// </summary>
	public virtual vtkImageReslice GetReslice()
	{
		vtkImageReslice vtkImageReslice2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetReslice_49(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageReslice2 = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageReslice2.Register(null);
			}
		}
		return vtkImageReslice2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetResliceAxes_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the current reslice class and reslice axes
	/// </summary>
	public virtual vtkMatrix4x4 GetResliceAxes()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetResliceAxes_50(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetResliceInterpolate_51(HandleRef pThis);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public virtual int GetResliceInterpolate()
	{
		return vtkImagePlaneWidget_GetResliceInterpolate_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetResliceOutput_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get the vtkImageReslice output.
	/// </summary>
	public vtkImageData GetResliceOutput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetResliceOutput_52(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetRestrictPlaneToVolume_53(HandleRef pThis);

	/// <summary>
	/// Make sure that the plane remains within the volume.
	/// Default is On.
	/// </summary>
	public virtual int GetRestrictPlaneToVolume()
	{
		return vtkImagePlaneWidget_GetRestrictPlaneToVolume_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetRightButtonAction_54(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetRightButtonAction()
	{
		return vtkImagePlaneWidget_GetRightButtonAction_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetRightButtonActionMaxValue_55(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetRightButtonActionMaxValue()
	{
		return vtkImagePlaneWidget_GetRightButtonActionMaxValue_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetRightButtonActionMinValue_56(HandleRef pThis);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual int GetRightButtonActionMinValue()
	{
		return vtkImagePlaneWidget_GetRightButtonActionMinValue_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifier_57(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetRightButtonAutoModifier()
	{
		return vtkImagePlaneWidget_GetRightButtonAutoModifier_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifierMaxValue_58(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetRightButtonAutoModifierMaxValue()
	{
		return vtkImagePlaneWidget_GetRightButtonAutoModifierMaxValue_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifierMinValue_59(HandleRef pThis);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual int GetRightButtonAutoModifierMinValue()
	{
		return vtkImagePlaneWidget_GetRightButtonAutoModifierMinValue_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetSelectedPlaneProperty_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the plane's outline properties. The properties of the plane's
	/// outline when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetSelectedPlaneProperty_60(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImagePlaneWidget_GetSliceIndex_61(HandleRef pThis);

	/// <summary>
	/// Get the slice position in terms of the data extent.
	/// </summary>
	public int GetSliceIndex()
	{
		return vtkImagePlaneWidget_GetSliceIndex_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetSlicePosition_62(HandleRef pThis);

	/// <summary>
	/// Get the position of the slice along its normal.
	/// </summary>
	public double GetSlicePosition()
	{
		return vtkImagePlaneWidget_GetSlicePosition_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetTextProperty_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property for the image data and window-level annotation.
	/// </summary>
	public vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetTextProperty_63(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetTexture_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get the texture used by this widget.  This can be
	/// used in external slice viewers.
	/// </summary>
	public vtkTexture GetTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetTexture_64(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetTextureInterpolate_65(HandleRef pThis);

	/// <summary>
	/// Specify whether to interpolate the texture or not. When off, the
	/// reslice interpolation is nearest neighbour regardless of how the
	/// interpolation is set through the API. Set before setting the
	/// vtkImageData input. Default is On.
	/// </summary>
	public virtual int GetTextureInterpolate()
	{
		return vtkImagePlaneWidget_GetTextureInterpolate_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_GetTexturePlaneProperty_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the property for the resliced image.
	/// </summary>
	public virtual vtkProperty GetTexturePlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_GetTexturePlaneProperty_66(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImagePlaneWidget_GetTextureVisibility_67(HandleRef pThis);

	/// <summary>
	/// Control the visibility of the actual texture mapped reformatted plane.
	/// in some cases you may only want the plane outline for example.
	/// </summary>
	public virtual int GetTextureVisibility()
	{
		return vtkImagePlaneWidget_GetTextureVisibility_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetUseContinuousCursor_68(HandleRef pThis);

	/// <summary>
	/// Choose between voxel centered or continuous cursor probing.  With voxel
	/// centered probing, the cursor snaps to the nearest voxel and the reported
	/// cursor coordinates are extent based.  With continuous probing, voxel data
	/// is interpolated using vtkDataSetAttributes' InterpolatePoint method and
	/// the reported coordinates are 3D spatial continuous.
	/// </summary>
	public virtual int GetUseContinuousCursor()
	{
		return vtkImagePlaneWidget_GetUseContinuousCursor_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_GetUserControlledLookupTable_69(HandleRef pThis);

	/// <summary>
	/// Let the user control the lookup table. NOTE: apply this method BEFORE
	/// applying the SetLookupTable method.
	/// Default is Off.
	/// </summary>
	public virtual int GetUserControlledLookupTable()
	{
		return vtkImagePlaneWidget_GetUserControlledLookupTable_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetVector1_70(HandleRef pThis, IntPtr v1);

	/// <summary>
	/// Get the vector from the plane origin to point1.
	/// </summary>
	public void GetVector1(IntPtr v1)
	{
		vtkImagePlaneWidget_GetVector1_70(GetCppThis(), v1);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetVector2_71(HandleRef pThis, IntPtr v2);

	/// <summary>
	/// Get the vector from the plane origin to point2.
	/// </summary>
	public void GetVector2(IntPtr v2)
	{
		vtkImagePlaneWidget_GetVector2_71(GetCppThis(), v2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImagePlaneWidget_GetWindow_72(HandleRef pThis);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public double GetWindow()
	{
		return vtkImagePlaneWidget_GetWindow_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_GetWindowLevel_73(HandleRef pThis, IntPtr wl);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public void GetWindowLevel(IntPtr wl)
	{
		vtkImagePlaneWidget_GetWindowLevel_73(GetCppThis(), wl);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_InteractionOff_74(HandleRef pThis);

	/// <summary>
	/// Enable/disable mouse interaction so the widget remains on display.
	/// </summary>
	public virtual void InteractionOff()
	{
		vtkImagePlaneWidget_InteractionOff_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_InteractionOn_75(HandleRef pThis);

	/// <summary>
	/// Enable/disable mouse interaction so the widget remains on display.
	/// </summary>
	public virtual void InteractionOn()
	{
		vtkImagePlaneWidget_InteractionOn_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_IsA_76(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImagePlaneWidget_IsA_76(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImagePlaneWidget_IsTypeOf_77(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImagePlaneWidget_IsTypeOf_77(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_NewInstance_79(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkImagePlaneWidget NewInstance()
	{
		vtkImagePlaneWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_NewInstance_79(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_PlaceWidget_80(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkImagePlaneWidget_PlaceWidget_80(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_PlaceWidget_81(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkImagePlaneWidget_PlaceWidget_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_PlaceWidget_82(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkImagePlaneWidget_PlaceWidget_82(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_RestrictPlaneToVolumeOff_83(HandleRef pThis);

	/// <summary>
	/// Make sure that the plane remains within the volume.
	/// Default is On.
	/// </summary>
	public virtual void RestrictPlaneToVolumeOff()
	{
		vtkImagePlaneWidget_RestrictPlaneToVolumeOff_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_RestrictPlaneToVolumeOn_84(HandleRef pThis);

	/// <summary>
	/// Make sure that the plane remains within the volume.
	/// Default is On.
	/// </summary>
	public virtual void RestrictPlaneToVolumeOn()
	{
		vtkImagePlaneWidget_RestrictPlaneToVolumeOn_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImagePlaneWidget_SafeDownCast_85(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkImagePlaneWidget SafeDownCast(vtkObjectBase o)
	{
		vtkImagePlaneWidget vtkImagePlaneWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImagePlaneWidget_SafeDownCast_85(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImagePlaneWidget2 = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImagePlaneWidget2.Register(null);
			}
		}
		return vtkImagePlaneWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetColorMap_86(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Convenience method to get the vtkImageMapToColors filter used by this
	/// widget.  The user can properly render other transparent actors in a
	/// scene by calling the filter's SetOutputFormatToRGB and
	/// PassAlphaToOutputOff.
	/// </summary>
	public virtual void SetColorMap(vtkImageMapToColors arg0)
	{
		vtkImagePlaneWidget_SetColorMap_86(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetCursorProperty_87(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the properties of the cross-hair cursor.
	/// </summary>
	public virtual void SetCursorProperty(vtkProperty arg0)
	{
		vtkImagePlaneWidget_SetCursorProperty_87(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetDisplayText_88(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable text display of window-level, image coordinates and
	/// scalar values in a render window.
	/// </summary>
	public virtual void SetDisplayText(int _arg)
	{
		vtkImagePlaneWidget_SetDisplayText_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetEnabled_89(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkImagePlaneWidget_SetEnabled_89(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetInputConnection_90(HandleRef pThis, HandleRef aout);

	/// <summary>
	/// Set the vtkImageData* input for the vtkImageReslice.
	/// </summary>
	public override void SetInputConnection(vtkAlgorithmOutput aout)
	{
		vtkImagePlaneWidget_SetInputConnection_90(GetCppThis(), aout?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetInteraction_91(HandleRef pThis, int interact);

	/// <summary>
	/// Enable/disable mouse interaction so the widget remains on display.
	/// </summary>
	public void SetInteraction(int interact)
	{
		vtkImagePlaneWidget_SetInteraction_91(GetCppThis(), interact);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetLeftButtonAction_92(HandleRef pThis, int _arg);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual void SetLeftButtonAction(int _arg)
	{
		vtkImagePlaneWidget_SetLeftButtonAction_92(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetLeftButtonAutoModifier_93(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual void SetLeftButtonAutoModifier(int _arg)
	{
		vtkImagePlaneWidget_SetLeftButtonAutoModifier_93(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetLookupTable_94(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
	/// alternatively, to the lut of another vtkImgePlaneWidget.  In this way,
	/// a set of three orthogonal planes can share the same lut so that
	/// window-levelling is performed uniformly among planes.  The default
	/// internal lut can be re- set/allocated by setting to 0 (nullptr).
	/// </summary>
	public virtual void SetLookupTable(vtkLookupTable arg0)
	{
		vtkImagePlaneWidget_SetLookupTable_94(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetMarginProperty_95(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the properties of the margins.
	/// </summary>
	public virtual void SetMarginProperty(vtkProperty arg0)
	{
		vtkImagePlaneWidget_SetMarginProperty_95(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetMarginSizeX_96(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the size of the margins based on a percentage of the
	/// plane's width and height, limited between 0 and 50%.
	/// </summary>
	public virtual void SetMarginSizeX(double _arg)
	{
		vtkImagePlaneWidget_SetMarginSizeX_96(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetMarginSizeY_97(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the size of the margins based on a percentage of the
	/// plane's width and height, limited between 0 and 50%.
	/// </summary>
	public virtual void SetMarginSizeY(double _arg)
	{
		vtkImagePlaneWidget_SetMarginSizeY_97(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetMiddleButtonAction_98(HandleRef pThis, int _arg);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual void SetMiddleButtonAction(int _arg)
	{
		vtkImagePlaneWidget_SetMiddleButtonAction_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetMiddleButtonAutoModifier_99(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual void SetMiddleButtonAutoModifier(int _arg)
	{
		vtkImagePlaneWidget_SetMiddleButtonAutoModifier_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetOrigin_100(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void SetOrigin(double x, double y, double z)
	{
		vtkImagePlaneWidget_SetOrigin_100(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetOrigin_101(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void SetOrigin(IntPtr xyz)
	{
		vtkImagePlaneWidget_SetOrigin_101(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPicker_102(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the internal picker to one defined by the user.  In this way,
	/// a set of three orthogonal planes can share the same picker so that
	/// picking is performed correctly.  The default internal picker can be
	/// re-set/allocated by setting to 0 (nullptr).
	/// </summary>
	public void SetPicker(vtkAbstractPropPicker arg0)
	{
		vtkImagePlaneWidget_SetPicker_102(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPlaneOrientation_103(HandleRef pThis, int arg0);

	/// <summary>
	/// Convenience method sets the plane orientation normal to the
	/// x, y, or z axes.  Default is XAxes (0).
	/// </summary>
	public void SetPlaneOrientation(int arg0)
	{
		vtkImagePlaneWidget_SetPlaneOrientation_103(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToXAxes_104(HandleRef pThis);

	/// <summary>
	/// Convenience method sets the plane orientation normal to the
	/// x, y, or z axes.  Default is XAxes (0).
	/// </summary>
	public void SetPlaneOrientationToXAxes()
	{
		vtkImagePlaneWidget_SetPlaneOrientationToXAxes_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToYAxes_105(HandleRef pThis);

	/// <summary>
	/// Convenience method sets the plane orientation normal to the
	/// x, y, or z axes.  Default is XAxes (0).
	/// </summary>
	public void SetPlaneOrientationToYAxes()
	{
		vtkImagePlaneWidget_SetPlaneOrientationToYAxes_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToZAxes_106(HandleRef pThis);

	/// <summary>
	/// Convenience method sets the plane orientation normal to the
	/// x, y, or z axes.  Default is XAxes (0).
	/// </summary>
	public void SetPlaneOrientationToZAxes()
	{
		vtkImagePlaneWidget_SetPlaneOrientationToZAxes_106(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPlaneProperty_107(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the plane's outline properties. The properties of the plane's
	/// outline when selected and unselected can be manipulated.
	/// </summary>
	public virtual void SetPlaneProperty(vtkProperty arg0)
	{
		vtkImagePlaneWidget_SetPlaneProperty_107(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPoint1_108(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the point defining the first axis of the plane.
	/// </summary>
	public void SetPoint1(double x, double y, double z)
	{
		vtkImagePlaneWidget_SetPoint1_108(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPoint1_109(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point defining the first axis of the plane.
	/// </summary>
	public void SetPoint1(IntPtr xyz)
	{
		vtkImagePlaneWidget_SetPoint1_109(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPoint2_110(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the point defining the second axis of the plane.
	/// </summary>
	public void SetPoint2(double x, double y, double z)
	{
		vtkImagePlaneWidget_SetPoint2_110(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetPoint2_111(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point defining the second axis of the plane.
	/// </summary>
	public void SetPoint2(IntPtr xyz)
	{
		vtkImagePlaneWidget_SetPoint2_111(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetResliceInterpolate_112(HandleRef pThis, int arg0);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public void SetResliceInterpolate(int arg0)
	{
		vtkImagePlaneWidget_SetResliceInterpolate_112(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToCubic_113(HandleRef pThis);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public void SetResliceInterpolateToCubic()
	{
		vtkImagePlaneWidget_SetResliceInterpolateToCubic_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToLinear_114(HandleRef pThis);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public void SetResliceInterpolateToLinear()
	{
		vtkImagePlaneWidget_SetResliceInterpolateToLinear_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToNearestNeighbour_115(HandleRef pThis);

	/// <summary>
	/// Set the interpolation to use when texturing the plane.
	/// </summary>
	public void SetResliceInterpolateToNearestNeighbour()
	{
		vtkImagePlaneWidget_SetResliceInterpolateToNearestNeighbour_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetRestrictPlaneToVolume_116(HandleRef pThis, int _arg);

	/// <summary>
	/// Make sure that the plane remains within the volume.
	/// Default is On.
	/// </summary>
	public virtual void SetRestrictPlaneToVolume(int _arg)
	{
		vtkImagePlaneWidget_SetRestrictPlaneToVolume_116(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetRightButtonAction_117(HandleRef pThis, int _arg);

	/// <summary>
	/// Set action associated to buttons.
	/// </summary>
	public virtual void SetRightButtonAction(int _arg)
	{
		vtkImagePlaneWidget_SetRightButtonAction_117(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetRightButtonAutoModifier_118(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the auto-modifiers associated to buttons.
	/// This allows users to bind some buttons to actions that are usually
	/// triggered by a key modifier. For example, if you do not need cursoring,
	/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
	/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
	/// the left button controlling panning without pressing a key.
	/// </summary>
	public virtual void SetRightButtonAutoModifier(int _arg)
	{
		vtkImagePlaneWidget_SetRightButtonAutoModifier_118(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetSelectedPlaneProperty_119(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the plane's outline properties. The properties of the plane's
	/// outline when selected and unselected can be manipulated.
	/// </summary>
	public virtual void SetSelectedPlaneProperty(vtkProperty arg0)
	{
		vtkImagePlaneWidget_SetSelectedPlaneProperty_119(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetSliceIndex_120(HandleRef pThis, int index);

	/// <summary>
	/// Set the slice position in terms of the data extent.
	/// </summary>
	public void SetSliceIndex(int index)
	{
		vtkImagePlaneWidget_SetSliceIndex_120(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetSlicePosition_121(HandleRef pThis, double position);

	/// <summary>
	/// Set the position of the slice along its normal.
	/// </summary>
	public void SetSlicePosition(double position)
	{
		vtkImagePlaneWidget_SetSlicePosition_121(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetTextProperty_122(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// Set/Get the text property for the image data and window-level annotation.
	/// </summary>
	public void SetTextProperty(vtkTextProperty tprop)
	{
		vtkImagePlaneWidget_SetTextProperty_122(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetTextureInterpolate_123(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to interpolate the texture or not. When off, the
	/// reslice interpolation is nearest neighbour regardless of how the
	/// interpolation is set through the API. Set before setting the
	/// vtkImageData input. Default is On.
	/// </summary>
	public virtual void SetTextureInterpolate(int _arg)
	{
		vtkImagePlaneWidget_SetTextureInterpolate_123(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetTexturePlaneProperty_124(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the property for the resliced image.
	/// </summary>
	public virtual void SetTexturePlaneProperty(vtkProperty arg0)
	{
		vtkImagePlaneWidget_SetTexturePlaneProperty_124(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetTextureVisibility_125(HandleRef pThis, int arg0);

	/// <summary>
	/// Control the visibility of the actual texture mapped reformatted plane.
	/// in some cases you may only want the plane outline for example.
	/// </summary>
	public virtual void SetTextureVisibility(int arg0)
	{
		vtkImagePlaneWidget_SetTextureVisibility_125(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetUseContinuousCursor_126(HandleRef pThis, int _arg);

	/// <summary>
	/// Choose between voxel centered or continuous cursor probing.  With voxel
	/// centered probing, the cursor snaps to the nearest voxel and the reported
	/// cursor coordinates are extent based.  With continuous probing, voxel data
	/// is interpolated using vtkDataSetAttributes' InterpolatePoint method and
	/// the reported coordinates are 3D spatial continuous.
	/// </summary>
	public virtual void SetUseContinuousCursor(int _arg)
	{
		vtkImagePlaneWidget_SetUseContinuousCursor_126(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetUserControlledLookupTable_127(HandleRef pThis, int _arg);

	/// <summary>
	/// Let the user control the lookup table. NOTE: apply this method BEFORE
	/// applying the SetLookupTable method.
	/// Default is Off.
	/// </summary>
	public virtual void SetUserControlledLookupTable(int _arg)
	{
		vtkImagePlaneWidget_SetUserControlledLookupTable_127(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_SetWindowLevel_128(HandleRef pThis, double window, double level, int copy);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public void SetWindowLevel(double window, double level, int copy)
	{
		vtkImagePlaneWidget_SetWindowLevel_128(GetCppThis(), window, level, copy);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_TextureInterpolateOff_129(HandleRef pThis);

	/// <summary>
	/// Specify whether to interpolate the texture or not. When off, the
	/// reslice interpolation is nearest neighbour regardless of how the
	/// interpolation is set through the API. Set before setting the
	/// vtkImageData input. Default is On.
	/// </summary>
	public virtual void TextureInterpolateOff()
	{
		vtkImagePlaneWidget_TextureInterpolateOff_129(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_TextureInterpolateOn_130(HandleRef pThis);

	/// <summary>
	/// Specify whether to interpolate the texture or not. When off, the
	/// reslice interpolation is nearest neighbour regardless of how the
	/// interpolation is set through the API. Set before setting the
	/// vtkImageData input. Default is On.
	/// </summary>
	public virtual void TextureInterpolateOn()
	{
		vtkImagePlaneWidget_TextureInterpolateOn_130(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_TextureVisibilityOff_131(HandleRef pThis);

	/// <summary>
	/// Control the visibility of the actual texture mapped reformatted plane.
	/// in some cases you may only want the plane outline for example.
	/// </summary>
	public virtual void TextureVisibilityOff()
	{
		vtkImagePlaneWidget_TextureVisibilityOff_131(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_TextureVisibilityOn_132(HandleRef pThis);

	/// <summary>
	/// Control the visibility of the actual texture mapped reformatted plane.
	/// in some cases you may only want the plane outline for example.
	/// </summary>
	public virtual void TextureVisibilityOn()
	{
		vtkImagePlaneWidget_TextureVisibilityOn_132(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_UpdatePlacement_133(HandleRef pThis);

	/// <summary>
	/// Satisfies superclass API.  This will change the state of the widget to
	/// match changes that have been made to the underlying vtkPolyDataSource
	/// </summary>
	public override void UpdatePlacement()
	{
		vtkImagePlaneWidget_UpdatePlacement_133(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_UseContinuousCursorOff_134(HandleRef pThis);

	/// <summary>
	/// Choose between voxel centered or continuous cursor probing.  With voxel
	/// centered probing, the cursor snaps to the nearest voxel and the reported
	/// cursor coordinates are extent based.  With continuous probing, voxel data
	/// is interpolated using vtkDataSetAttributes' InterpolatePoint method and
	/// the reported coordinates are 3D spatial continuous.
	/// </summary>
	public virtual void UseContinuousCursorOff()
	{
		vtkImagePlaneWidget_UseContinuousCursorOff_134(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_UseContinuousCursorOn_135(HandleRef pThis);

	/// <summary>
	/// Choose between voxel centered or continuous cursor probing.  With voxel
	/// centered probing, the cursor snaps to the nearest voxel and the reported
	/// cursor coordinates are extent based.  With continuous probing, voxel data
	/// is interpolated using vtkDataSetAttributes' InterpolatePoint method and
	/// the reported coordinates are 3D spatial continuous.
	/// </summary>
	public virtual void UseContinuousCursorOn()
	{
		vtkImagePlaneWidget_UseContinuousCursorOn_135(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_UserControlledLookupTableOff_136(HandleRef pThis);

	/// <summary>
	/// Let the user control the lookup table. NOTE: apply this method BEFORE
	/// applying the SetLookupTable method.
	/// Default is Off.
	/// </summary>
	public virtual void UserControlledLookupTableOff()
	{
		vtkImagePlaneWidget_UserControlledLookupTableOff_136(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImagePlaneWidget_UserControlledLookupTableOn_137(HandleRef pThis);

	/// <summary>
	/// Let the user control the lookup table. NOTE: apply this method BEFORE
	/// applying the SetLookupTable method.
	/// Default is Off.
	/// </summary>
	public virtual void UserControlledLookupTableOn()
	{
		vtkImagePlaneWidget_UserControlledLookupTableOn_137(GetCppThis());
	}
}
