using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompassRepresentation
/// </summary>
/// <remarks>
///    provide a compass and distance, tilt sliders
///
/// This class is used to represent and render a compass to represent a heading, and two vertical
/// sliders to manipulate distance and tilt.
///
/// If distance or tilt sliders are not required then their Visibility can be set to off when
/// subclassing it.
///
/// Override the GetStatusText() method if you require a customized status text.
/// </remarks>
public class vtkCompassRepresentation : vtkContinuousValueWidgetRepresentation
{
	/// <summary>
	/// Update the distance by the given delta.
	/// </summary>
	public new enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Adjusting = 2,
		/// <summary>enum member</summary>
		DistanceAdjusting = 8,
		/// <summary>enum member</summary>
		DistanceIn = 7,
		/// <summary>enum member</summary>
		DistanceOut = 6,
		/// <summary>enum member</summary>
		Inside = 1,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		TiltAdjusting = 5,
		/// <summary>enum member</summary>
		TiltDown = 3,
		/// <summary>enum member</summary>
		TiltUp = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompassRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompassRepresentation()
	{
		MRClassNameKey = "class vtkCompassRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompassRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompassRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkCompassRepresentation New()
	{
		vtkCompassRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkCompassRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompassRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCompassRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCompassRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompassRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkCompassRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_DistanceWidgetInteraction_03(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public virtual void DistanceWidgetInteraction(IntPtr eventPos)
	{
		vtkCompassRepresentation_DistanceWidgetInteraction_03(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_EndDistance_04(HandleRef pThis);

	/// <summary>
	/// Update the distance by the given delta.
	/// </summary>
	public virtual void EndDistance()
	{
		vtkCompassRepresentation_EndDistance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_EndTilt_05(HandleRef pThis);

	/// <summary>
	/// Update the tilt by the given delta in degrees.
	/// </summary>
	public virtual void EndTilt()
	{
		vtkCompassRepresentation_EndTilt_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_GetActors_06(HandleRef pThis, HandleRef propCollection);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors(vtkPropCollection propCollection)
	{
		vtkCompassRepresentation_GetActors_06(GetCppThis(), propCollection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassRepresentation_GetDistance_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the distance. These methods ensure that the distance is in the range set by
	/// SetMaximumDistance() and SetMinimumDistance().
	/// </summary>
	public virtual double GetDistance()
	{
		return vtkCompassRepresentation_GetDistance_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassRepresentation_GetHeading_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the heading in degrees. The methods ensure that the heading is in the range [0, 360)
	/// degrees.
	/// </summary>
	public virtual double GetHeading()
	{
		return vtkCompassRepresentation_GetHeading_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassRepresentation_GetLabelProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the properties for the label and title text.
	/// </summary>
	public virtual vtkTextProperty GetLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassRepresentation_GetLabelProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkCompassRepresentation_GetMaximumDistance_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the distance range. The default is [0.0, 2.0].
	/// </summary>
	public double GetMaximumDistance()
	{
		return vtkCompassRepresentation_GetMaximumDistance_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassRepresentation_GetMaximumTiltAngle_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the tilt range. These default range is [-90, 90] degrees.
	/// </summary>
	public double GetMaximumTiltAngle()
	{
		return vtkCompassRepresentation_GetMaximumTiltAngle_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassRepresentation_GetMinimumDistance_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the distance range. The default is [0.0, 2.0].
	/// </summary>
	public double GetMinimumDistance()
	{
		return vtkCompassRepresentation_GetMinimumDistance_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassRepresentation_GetMinimumTiltAngle_13(HandleRef pThis);

	/// <summary>
	/// Get/Set the tilt range. These default range is [-90, 90] degrees.
	/// </summary>
	public double GetMinimumTiltAngle()
	{
		return vtkCompassRepresentation_GetMinimumTiltAngle_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompassRepresentation_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompassRepresentation_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompassRepresentation_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompassRepresentation_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassRepresentation_GetPoint1Coordinate_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Position the first end point of the slider. Note that this point is an
	/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
	/// variety of coordinate systems, and can even be relative to another
	/// point. To set the point, you'll want to get the Point1Coordinate and
	/// then invoke the necessary methods to put it into the correct coordinate
	/// system and set the correct initial value.
	/// </summary>
	public vtkCoordinate GetPoint1Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassRepresentation_GetPoint1Coordinate_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassRepresentation_GetPoint2Coordinate_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Position the second end point of the slider. Note that this point is an
	/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
	/// variety of coordinate systems, and can even be relative to another
	/// point. To set the point, you'll want to get the Point2Coordinate and
	/// then invoke the necessary methods to put it into the correct coordinate
	/// system and set the correct initial value.
	/// </summary>
	public vtkCoordinate GetPoint2Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassRepresentation_GetPoint2Coordinate_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassRepresentation_GetRingProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the slider properties. The properties of the slider when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty2D GetRingProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassRepresentation_GetRingProperty_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassRepresentation_GetSelectedProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the selection property. This property is used to modify the
	/// appearance of selected objects (e.g., the slider).
	/// </summary>
	public virtual vtkProperty2D GetSelectedProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassRepresentation_GetSelectedProperty_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassRepresentation_GetTilt_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the tilt in degrees. The methods ensure that the tilt is in the range set by
	/// SetMaximumTiltAngle() and SetMinimumTiltAngle().
	/// </summary>
	public virtual double GetTilt()
	{
		return vtkCompassRepresentation_GetTilt_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_Highlight_21(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void Highlight(int arg0)
	{
		vtkCompassRepresentation_Highlight_21(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompassRepresentation_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompassRepresentation_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompassRepresentation_IsTypeOf_23(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompassRepresentation_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassRepresentation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkCompassRepresentation NewInstance()
	{
		vtkCompassRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassRepresentation_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_PlaceWidget_26(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkCompassRepresentation_PlaceWidget_26(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef window);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkCompassRepresentation_ReleaseGraphicsResources_27(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompassRepresentation_RenderOpaqueGeometry_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCompassRepresentation_RenderOpaqueGeometry_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompassRepresentation_RenderOverlay_29(HandleRef pThis, HandleRef viewPort);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewPort)
	{
		return vtkCompassRepresentation_RenderOverlay_29(GetCppThis(), viewPort?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassRepresentation_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkCompassRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCompassRepresentation vtkCompassRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassRepresentation_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompassRepresentation2 = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompassRepresentation2.Register(null);
			}
		}
		return vtkCompassRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_SetDistance_31(HandleRef pThis, double distance);

	/// <summary>
	/// Get/Set the distance. These methods ensure that the distance is in the range set by
	/// SetMaximumDistance() and SetMinimumDistance().
	/// </summary>
	public virtual void SetDistance(double distance)
	{
		vtkCompassRepresentation_SetDistance_31(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_SetHeading_32(HandleRef pThis, double heading);

	/// <summary>
	/// Get/Set the heading in degrees. The methods ensure that the heading is in the range [0, 360)
	/// degrees.
	/// </summary>
	public virtual void SetHeading(double heading)
	{
		vtkCompassRepresentation_SetHeading_32(GetCppThis(), heading);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_SetMaximumDistance_33(HandleRef pThis, double distance);

	/// <summary>
	/// Get/Set the distance range. The default is [0.0, 2.0].
	/// </summary>
	public void SetMaximumDistance(double distance)
	{
		vtkCompassRepresentation_SetMaximumDistance_33(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_SetMaximumTiltAngle_34(HandleRef pThis, double angle);

	/// <summary>
	/// Get/Set the tilt range. These default range is [-90, 90] degrees.
	/// </summary>
	public void SetMaximumTiltAngle(double angle)
	{
		vtkCompassRepresentation_SetMaximumTiltAngle_34(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_SetMinimumDistance_35(HandleRef pThis, double distance);

	/// <summary>
	/// Get/Set the distance range. The default is [0.0, 2.0].
	/// </summary>
	public void SetMinimumDistance(double distance)
	{
		vtkCompassRepresentation_SetMinimumDistance_35(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_SetMinimumTiltAngle_36(HandleRef pThis, double angle);

	/// <summary>
	/// Get/Set the tilt range. These default range is [-90, 90] degrees.
	/// </summary>
	public void SetMinimumTiltAngle(double angle)
	{
		vtkCompassRepresentation_SetMinimumTiltAngle_36(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_SetRenderer_37(HandleRef pThis, HandleRef renderer);

	/// <summary>
	/// Update the distance by the given delta.
	/// </summary>
	public override void SetRenderer(vtkRenderer renderer)
	{
		vtkCompassRepresentation_SetRenderer_37(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_SetTilt_38(HandleRef pThis, double tilt);

	/// <summary>
	/// Get/Set the tilt in degrees. The methods ensure that the tilt is in the range set by
	/// SetMaximumTiltAngle() and SetMinimumTiltAngle().
	/// </summary>
	public virtual void SetTilt(double tilt)
	{
		vtkCompassRepresentation_SetTilt_38(GetCppThis(), tilt);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_StartWidgetInteraction_39(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkCompassRepresentation_StartWidgetInteraction_39(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_TiltWidgetInteraction_40(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public virtual void TiltWidgetInteraction(IntPtr eventPos)
	{
		vtkCompassRepresentation_TiltWidgetInteraction_40(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_UpdateDistance_41(HandleRef pThis, double deltaDistance);

	/// <summary>
	/// Update the distance by the given delta.
	/// </summary>
	public virtual void UpdateDistance(double deltaDistance)
	{
		vtkCompassRepresentation_UpdateDistance_41(GetCppThis(), deltaDistance);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_UpdateTilt_42(HandleRef pThis, double deltaTilt);

	/// <summary>
	/// Update the tilt by the given delta in degrees.
	/// </summary>
	public virtual void UpdateTilt(double deltaTilt)
	{
		vtkCompassRepresentation_UpdateTilt_42(GetCppThis(), deltaTilt);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassRepresentation_WidgetInteraction_43(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkCompassRepresentation_WidgetInteraction_43(GetCppThis(), eventPos);
	}
}
