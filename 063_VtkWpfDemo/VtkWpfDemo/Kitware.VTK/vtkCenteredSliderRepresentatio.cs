using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCenteredSliderRepresentation
/// </summary>
/// <remarks>
///    provide the representation for a vtkCenteredSliderWidget
///
/// This class is used to represent and render a vtkCenteredSliderWidget. To use this
/// class, you must at a minimum specify the end points of the
/// slider. Optional instance variable can be used to modify the appearance of
/// the widget.
///
///
/// </remarks>
/// <seealso>
///
/// vtkSliderWidget
/// </seealso>
public class vtkCenteredSliderRepresentation : vtkSliderRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCenteredSliderRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCenteredSliderRepresentation()
	{
		MRClassNameKey = "class vtkCenteredSliderRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCenteredSliderRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCenteredSliderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenteredSliderRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkCenteredSliderRepresentation New()
	{
		vtkCenteredSliderRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenteredSliderRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCenteredSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkCenteredSliderRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCenteredSliderRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCenteredSliderRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCenteredSliderRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCenteredSliderRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkCenteredSliderRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenteredSliderRepresentation_GetActors_03(HandleRef pThis, HandleRef propCollections);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors(vtkPropCollection propCollections)
	{
		vtkCenteredSliderRepresentation_GetActors_03(GetCppThis(), propCollections?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenteredSliderRepresentation_GetLabelProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the properties for the label and title text.
	/// </summary>
	public virtual vtkTextProperty GetLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenteredSliderRepresentation_GetLabelProperty_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCenteredSliderRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCenteredSliderRepresentation_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCenteredSliderRepresentation_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCenteredSliderRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenteredSliderRepresentation_GetPoint1Coordinate_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkCenteredSliderRepresentation_GetPoint1Coordinate_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCenteredSliderRepresentation_GetPoint2Coordinate_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkCenteredSliderRepresentation_GetPoint2Coordinate_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCenteredSliderRepresentation_GetSelectedProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkCenteredSliderRepresentation_GetSelectedProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCenteredSliderRepresentation_GetSliderProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties for the tube and slider
	/// </summary>
	public virtual vtkProperty2D GetSliderProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenteredSliderRepresentation_GetSliderProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCenteredSliderRepresentation_GetTitleText_11(HandleRef pThis);

	/// <summary>
	/// Specify the label text for this widget. If the value is not set, or set
	/// to the empty string "", then the label text is not displayed.
	/// </summary>
	public override string GetTitleText()
	{
		return Marshal.PtrToStringAnsi(vtkCenteredSliderRepresentation_GetTitleText_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenteredSliderRepresentation_GetTubeProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties for the tube and slider
	/// </summary>
	public virtual vtkProperty2D GetTubeProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenteredSliderRepresentation_GetTubeProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCenteredSliderRepresentation_Highlight_13(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void Highlight(int arg0)
	{
		vtkCenteredSliderRepresentation_Highlight_13(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCenteredSliderRepresentation_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCenteredSliderRepresentation_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCenteredSliderRepresentation_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCenteredSliderRepresentation_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenteredSliderRepresentation_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkCenteredSliderRepresentation NewInstance()
	{
		vtkCenteredSliderRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenteredSliderRepresentation_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCenteredSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenteredSliderRepresentation_PlaceWidget_18(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkCenteredSliderRepresentation_PlaceWidget_18(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenteredSliderRepresentation_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef window);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkCenteredSliderRepresentation_ReleaseGraphicsResources_19(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCenteredSliderRepresentation_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCenteredSliderRepresentation_RenderOpaqueGeometry_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCenteredSliderRepresentation_RenderOverlay_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkCenteredSliderRepresentation_RenderOverlay_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCenteredSliderRepresentation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkCenteredSliderRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCenteredSliderRepresentation vtkCenteredSliderRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCenteredSliderRepresentation_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCenteredSliderRepresentation2 = (vtkCenteredSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCenteredSliderRepresentation2.Register(null);
			}
		}
		return vtkCenteredSliderRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenteredSliderRepresentation_SetTitleText_23(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify the label text for this widget. If the value is not set, or set
	/// to the empty string "", then the label text is not displayed.
	/// </summary>
	public override void SetTitleText(string arg0)
	{
		vtkCenteredSliderRepresentation_SetTitleText_23(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenteredSliderRepresentation_StartWidgetInteraction_24(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkCenteredSliderRepresentation_StartWidgetInteraction_24(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCenteredSliderRepresentation_WidgetInteraction_25(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display
	/// space where the widget should be placed.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkCenteredSliderRepresentation_WidgetInteraction_25(GetCppThis(), eventPos);
	}
}
