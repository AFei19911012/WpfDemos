using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceCursorRepresentation
/// </summary>
/// <remarks>
///    represent the vtkResliceCursorWidget
///
/// This class is the base class for the reslice cursor representation
/// subclasses. It represents a cursor that may be interactively translated,
/// rotated through an image and perform thick / thick reformats.
/// </remarks>
/// <seealso>
///
/// vtkResliceCursorLineRepresentation vtkResliceCursorThickLineRepresentation
/// vtkResliceCursorWidget vtkResliceCursor
/// </seealso>
public abstract class vtkResliceCursorRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the thickness value.
	/// </summary>
	public enum NearAxis1_WrapperEnum
	{
		/// <summary>enum member</summary>
		NearAxis1 = 2,
		/// <summary>enum member</summary>
		NearAxis2 = 3,
		/// <summary>enum member</summary>
		NearCenter = 1,
		/// <summary>enum member</summary>
		OnAxis1 = 5,
		/// <summary>enum member</summary>
		OnAxis2 = 6,
		/// <summary>enum member</summary>
		OnCenter = 4,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the thickness value.
	/// </summary>
	public enum None_WrapperEnum
	{
		/// <summary>enum member</summary>
		None = 0,
		/// <summary>enum member</summary>
		PanAndRotate = 1,
		/// <summary>enum member</summary>
		ResizeThickness = 3,
		/// <summary>enum member</summary>
		RotateBothAxes = 2,
		/// <summary>enum member</summary>
		TranslateSingleAxis = 5,
		/// <summary>enum member</summary>
		WindowLevelling = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceCursorRepresentation()
	{
		MRClassNameKey = "class vtkResliceCursorRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceCursorRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_ActivateText_01(HandleRef pThis, int arg0);

	/// <summary>
	/// INTERNAL - Do not use.
	/// Internal methods used by the widget to manage text displays
	/// for annotations.
	/// </summary>
	public void ActivateText(int arg0)
	{
		vtkResliceCursorRepresentation_ActivateText_01(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_BoundPlane_02(IntPtr bounds, IntPtr origin, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Fit the plane defined by origin, p1, p2 onto the bounds.
	/// Plane is untouched if does not intersect bounds.
	/// return 1 if the bounds is intersected, else 0
	/// </summary>
	public static int BoundPlane(IntPtr bounds, IntPtr origin, IntPtr p1, IntPtr p2)
	{
		return vtkResliceCursorRepresentation_BoundPlane_02(bounds, origin, p1, p2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_BuildRepresentation_03(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkResliceCursorRepresentation_BuildRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_DisplayTextOff_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable text display of window-level, image coordinates and
	/// scalar values in a render window.
	/// </summary>
	public virtual void DisplayTextOff()
	{
		vtkResliceCursorRepresentation_DisplayTextOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_DisplayTextOn_05(HandleRef pThis);

	/// <summary>
	/// Enable/disable text display of window-level, image coordinates and
	/// scalar values in a render window.
	/// </summary>
	public virtual void DisplayTextOn()
	{
		vtkResliceCursorRepresentation_DisplayTextOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetColorMap_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkResliceCursorRepresentation_GetColorMap_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkResliceCursorRepresentation_GetCursorAlgorithm_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the underlying cursor source.
	/// </summary>
	public virtual vtkResliceCursorPolyDataAlgorithm GetCursorAlgorithm()
	{
		vtkResliceCursorPolyDataAlgorithm vtkResliceCursorPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_GetCursorAlgorithm_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorPolyDataAlgorithm2 = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkResliceCursorPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_GetDisplayText_08(HandleRef pThis);

	/// <summary>
	/// Enable/disable text display of window-level, image coordinates and
	/// scalar values in a render window.
	/// </summary>
	public virtual int GetDisplayText()
	{
		return vtkResliceCursorRepresentation_GetDisplayText_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetImageActor_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the displayed image actor
	/// </summary>
	public virtual vtkImageActor GetImageActor()
	{
		vtkImageActor vtkImageActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_GetImageActor_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageActor2 = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageActor2.Register(null);
			}
		}
		return vtkImageActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkResliceCursorRepresentation_GetLevel_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public double GetLevel()
	{
		return vtkResliceCursorRepresentation_GetLevel_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetLookupTable_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
	/// alternatively, to the lut of another Reslice cusror widget.  In this way,
	/// a set of three orthogonal planes can share the same lut so that
	/// window-levelling is performed uniformly among planes.  The default
	/// internal lut can be re- set/allocated by setting to 0 (nullptr).
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_GetLookupTable_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_GetManipulationMode_12(HandleRef pThis);

	/// <summary>
	/// INTERNAL - Do not use
	/// Set the manipulation mode. This is done by the widget
	/// </summary>
	public virtual int GetManipulationMode()
	{
		return vtkResliceCursorRepresentation_GetManipulationMode_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorRepresentation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceCursorRepresentation_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorRepresentation_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceCursorRepresentation_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetPlaneSource_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane source on which the texture (the thin/thick resliced
	/// image is displayed)
	/// </summary>
	public virtual vtkPlaneSource GetPlaneSource()
	{
		vtkPlaneSource vtkPlaneSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_GetPlaneSource_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlaneSource2 = (vtkPlaneSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlaneSource2.Register(null);
			}
		}
		return vtkPlaneSource2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetReslice_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the current reslice class and reslice axes
	/// </summary>
	public virtual vtkImageAlgorithm GetReslice()
	{
		vtkImageAlgorithm vtkImageAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_GetReslice_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageAlgorithm2 = (vtkImageAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageAlgorithm2.Register(null);
			}
		}
		return vtkImageAlgorithm2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetResliceAxes_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the current reslice class and reslice axes
	/// </summary>
	public virtual vtkMatrix4x4 GetResliceAxes()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_GetResliceAxes_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkResliceCursorRepresentation_GetResliceCursor_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public virtual vtkResliceCursor GetResliceCursor()
	{
		vtkResliceCursor vtkResliceCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_GetResliceCursor_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursor2 = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursor2.Register(null);
			}
		}
		return vtkResliceCursor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_GetRestrictPlaneToVolume_19(HandleRef pThis);

	/// <summary>
	/// Make sure that the resliced image remains within the volume.
	/// Default is On.
	/// </summary>
	public virtual int GetRestrictPlaneToVolume()
	{
		return vtkResliceCursorRepresentation_GetRestrictPlaneToVolume_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_GetShowReslicedImage_20(HandleRef pThis);

	/// <summary>
	/// Show the resliced image ?
	/// </summary>
	public virtual int GetShowReslicedImage()
	{
		return vtkResliceCursorRepresentation_GetShowReslicedImage_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetTextProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property for the image data and window-level annotation.
	/// </summary>
	public vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_GetTextProperty_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkResliceCursorRepresentation_GetThicknessLabelFormat_22(HandleRef pThis);

	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the thickness value.
	/// </summary>
	public virtual string GetThicknessLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkResliceCursorRepresentation_GetThicknessLabelFormat_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetThicknessLabelPosition_23(HandleRef pThis);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public virtual IntPtr GetThicknessLabelPosition()
	{
		return vtkResliceCursorRepresentation_GetThicknessLabelPosition_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_GetThicknessLabelPosition_24(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public virtual void GetThicknessLabelPosition(IntPtr pos)
	{
		vtkResliceCursorRepresentation_GetThicknessLabelPosition_24(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_GetThicknessLabelText_25(HandleRef pThis);

	/// <summary>
	/// Get the text shown in the widget's label.
	/// </summary>
	public virtual string GetThicknessLabelText()
	{
		return Marshal.PtrToStringAnsi(vtkResliceCursorRepresentation_GetThicknessLabelText_25(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_GetTolerance_26(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the
	/// representation to be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkResliceCursorRepresentation_GetTolerance_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_GetToleranceMaxValue_27(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the
	/// representation to be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkResliceCursorRepresentation_GetToleranceMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_GetToleranceMinValue_28(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the
	/// representation to be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkResliceCursorRepresentation_GetToleranceMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_GetUseImageActor_29(HandleRef pThis);

	/// <summary>
	/// Render as a 2D image, or render as a plane with a texture in physical
	/// space.
	/// </summary>
	public virtual int GetUseImageActor()
	{
		return vtkResliceCursorRepresentation_GetUseImageActor_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkResliceCursorRepresentation_GetWindow_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public double GetWindow()
	{
		return vtkResliceCursorRepresentation_GetWindow_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_GetWindowLevel_31(HandleRef pThis, IntPtr wl);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public void GetWindowLevel(IntPtr wl)
	{
		vtkResliceCursorRepresentation_GetWindowLevel_31(GetCppThis(), wl);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_GetWorldThicknessLabelPosition_32(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public virtual void GetWorldThicknessLabelPosition(IntPtr pos)
	{
		vtkResliceCursorRepresentation_GetWorldThicknessLabelPosition_32(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_InitializeReslicePlane_33(HandleRef pThis);

	/// <summary>
	/// Initialize the reslice planes and the camera center. This is done
	/// automatically, the first time we render.
	/// </summary>
	public virtual void InitializeReslicePlane()
	{
		vtkResliceCursorRepresentation_InitializeReslicePlane_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_IsA_34(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceCursorRepresentation_IsA_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorRepresentation_IsTypeOf_35(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceCursorRepresentation_IsTypeOf_35(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_ManageTextDisplay_36(HandleRef pThis);

	/// <summary>
	/// INTERNAL - Do not use.
	/// Internal methods used by the widget to manage text displays
	/// for annotations.
	/// </summary>
	public void ManageTextDisplay()
	{
		vtkResliceCursorRepresentation_ManageTextDisplay_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkResliceCursorRepresentation NewInstance()
	{
		vtkResliceCursorRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_NewInstance_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_ResetCamera_38(HandleRef pThis);

	/// <summary>
	/// Initialize the reslice planes and the camera center. This is done
	/// automatically, the first time we render.
	/// </summary>
	public virtual void ResetCamera()
	{
		vtkResliceCursorRepresentation_ResetCamera_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_RestrictPlaneToVolumeOff_39(HandleRef pThis);

	/// <summary>
	/// Make sure that the resliced image remains within the volume.
	/// Default is On.
	/// </summary>
	public virtual void RestrictPlaneToVolumeOff()
	{
		vtkResliceCursorRepresentation_RestrictPlaneToVolumeOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_RestrictPlaneToVolumeOn_40(HandleRef pThis);

	/// <summary>
	/// Make sure that the resliced image remains within the volume.
	/// Default is On.
	/// </summary>
	public virtual void RestrictPlaneToVolumeOn()
	{
		vtkResliceCursorRepresentation_RestrictPlaneToVolumeOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorRepresentation_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkResliceCursorRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkResliceCursorRepresentation vtkResliceCursorRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorRepresentation_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorRepresentation2 = (vtkResliceCursorRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorRepresentation2.Register(null);
			}
		}
		return vtkResliceCursorRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetColorMap_42(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Convenience method to get the vtkImageMapToColors filter used by this
	/// widget.  The user can properly render other transparent actors in a
	/// scene by calling the filter's SetOutputFormatToRGB and
	/// PassAlphaToOutputOff.
	/// </summary>
	public virtual void SetColorMap(vtkImageMapToColors arg0)
	{
		vtkResliceCursorRepresentation_SetColorMap_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetDisplayText_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable text display of window-level, image coordinates and
	/// scalar values in a render window.
	/// </summary>
	public virtual void SetDisplayText(int _arg)
	{
		vtkResliceCursorRepresentation_SetDisplayText_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetLookupTable_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
	/// alternatively, to the lut of another Reslice cusror widget.  In this way,
	/// a set of three orthogonal planes can share the same lut so that
	/// window-levelling is performed uniformly among planes.  The default
	/// internal lut can be re- set/allocated by setting to 0 (nullptr).
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors arg0)
	{
		vtkResliceCursorRepresentation_SetLookupTable_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetManipulationMode_45(HandleRef pThis, int m);

	/// <summary>
	/// INTERNAL - Do not use
	/// Set the manipulation mode. This is done by the widget
	/// </summary>
	public void SetManipulationMode(int m)
	{
		vtkResliceCursorRepresentation_SetManipulationMode_45(GetCppThis(), m);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetRestrictPlaneToVolume_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Make sure that the resliced image remains within the volume.
	/// Default is On.
	/// </summary>
	public virtual void SetRestrictPlaneToVolume(int _arg)
	{
		vtkResliceCursorRepresentation_SetRestrictPlaneToVolume_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetShowReslicedImage_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Show the resliced image ?
	/// </summary>
	public virtual void SetShowReslicedImage(int _arg)
	{
		vtkResliceCursorRepresentation_SetShowReslicedImage_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetTextProperty_48(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// Set/Get the text property for the image data and window-level annotation.
	/// </summary>
	public void SetTextProperty(vtkTextProperty tprop)
	{
		vtkResliceCursorRepresentation_SetTextProperty_48(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetThicknessLabelFormat_49(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the thickness value.
	/// </summary>
	public virtual void SetThicknessLabelFormat(string _arg)
	{
		vtkResliceCursorRepresentation_SetThicknessLabelFormat_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetTolerance_50(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the
	/// representation to be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkResliceCursorRepresentation_SetTolerance_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetUseImageActor_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Render as a 2D image, or render as a plane with a texture in physical
	/// space.
	/// </summary>
	public virtual void SetUseImageActor(int _arg)
	{
		vtkResliceCursorRepresentation_SetUseImageActor_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_SetWindowLevel_52(HandleRef pThis, double window, double level, int copy);

	/// <summary>
	/// Set/Get the current window and level values.  SetWindowLevel should
	/// only be called after SetInput.  If a shared lookup table is being used,
	/// a callback is required to update the window level values without having
	/// to update the lookup table again.
	/// </summary>
	public void SetWindowLevel(double window, double level, int copy)
	{
		vtkResliceCursorRepresentation_SetWindowLevel_52(GetCppThis(), window, level, copy);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_ShowReslicedImageOff_53(HandleRef pThis);

	/// <summary>
	/// Show the resliced image ?
	/// </summary>
	public virtual void ShowReslicedImageOff()
	{
		vtkResliceCursorRepresentation_ShowReslicedImageOff_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_ShowReslicedImageOn_54(HandleRef pThis);

	/// <summary>
	/// Show the resliced image ?
	/// </summary>
	public virtual void ShowReslicedImageOn()
	{
		vtkResliceCursorRepresentation_ShowReslicedImageOn_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_TransformPlane_55(HandleRef planeToTransform, IntPtr targetCenter, IntPtr targetNormal, IntPtr targetViewUp);

	/// <summary>
	/// First rotate planeToTransform to match targetPlane normal.
	/// Then rotate around targetNormal to enforce targetViewUp "up" vector (i.e. Origin-&gt;p2 ).
	/// There is an infinite number of options to rotate a plane normal to another. Here we attempt to
	/// preserve Origin, P1 and P2 when rotating around targetPlane.
	/// </summary>
	public static void TransformPlane(vtkPlaneSource planeToTransform, IntPtr targetCenter, IntPtr targetNormal, IntPtr targetViewUp)
	{
		vtkResliceCursorRepresentation_TransformPlane_55(planeToTransform?.GetCppThis() ?? default(HandleRef), targetCenter, targetNormal, targetViewUp);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_UseImageActorOff_56(HandleRef pThis);

	/// <summary>
	/// Render as a 2D image, or render as a plane with a texture in physical
	/// space.
	/// </summary>
	public virtual void UseImageActorOff()
	{
		vtkResliceCursorRepresentation_UseImageActorOff_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorRepresentation_UseImageActorOn_57(HandleRef pThis);

	/// <summary>
	/// Render as a 2D image, or render as a plane with a texture in physical
	/// space.
	/// </summary>
	public virtual void UseImageActorOn()
	{
		vtkResliceCursorRepresentation_UseImageActorOn_57(GetCppThis());
	}
}
