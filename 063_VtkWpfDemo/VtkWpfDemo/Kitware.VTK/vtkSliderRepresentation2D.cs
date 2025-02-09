using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSliderRepresentation2D
/// </summary>
/// <remarks>
///    provide the representation for a vtkSliderWidget with a 3D skin
///
/// This class is used to represent and render a vtkSliderWidget. To use this
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
public class vtkSliderRepresentation2D : vtkSliderRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSliderRepresentation2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSliderRepresentation2D()
	{
		MRClassNameKey = "class vtkSliderRepresentation2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderRepresentation2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSliderRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkSliderRepresentation2D New()
	{
		vtkSliderRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliderRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkSliderRepresentation2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSliderRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSliderRepresentation2D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display space
	/// where the widget should be placed.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkSliderRepresentation2D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation2D_GetActors2D_02(HandleRef pThis, HandleRef propCollection);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors2D(vtkPropCollection propCollection)
	{
		vtkSliderRepresentation2D_GetActors2D_02(GetCppThis(), propCollection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation2D_GetCapProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties for the tube and end caps.
	/// </summary>
	public virtual vtkProperty2D GetCapProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_GetCapProperty_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSliderRepresentation2D_GetLabelProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the properties for the label and title text.
	/// </summary>
	public virtual vtkTextProperty GetLabelProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_GetLabelProperty_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkSliderRepresentation2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSliderRepresentation2D_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliderRepresentation2D_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSliderRepresentation2D_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation2D_GetPoint1Coordinate_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkSliderRepresentation2D_GetPoint1Coordinate_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSliderRepresentation2D_GetPoint2Coordinate_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkSliderRepresentation2D_GetPoint2Coordinate_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSliderRepresentation2D_GetSelectedProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the selection property. This property is used to modify the appearance of
	/// selected objects (e.g., the slider).
	/// </summary>
	public virtual vtkProperty2D GetSelectedProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_GetSelectedProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSliderRepresentation2D_GetSliderProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the slider properties. The properties of the slider when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty2D GetSliderProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_GetSliderProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSliderRepresentation2D_GetTitleProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the properties for the label and title text.
	/// </summary>
	public virtual vtkTextProperty GetTitleProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_GetTitleProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSliderRepresentation2D_GetTitleText_12(HandleRef pThis);

	/// <summary>
	/// Specify the label text for this widget. If the value is not set, or set
	/// to the empty string "", then the label text is not displayed.
	/// </summary>
	public override string GetTitleText()
	{
		return Marshal.PtrToStringAnsi(vtkSliderRepresentation2D_GetTitleText_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation2D_GetTubeProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties for the tube and end caps.
	/// </summary>
	public virtual vtkProperty2D GetTubeProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_GetTubeProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSliderRepresentation2D_Highlight_14(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display space
	/// where the widget should be placed.
	/// </summary>
	public override void Highlight(int arg0)
	{
		vtkSliderRepresentation2D_Highlight_14(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation2D_IsA_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSliderRepresentation2D_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation2D_IsTypeOf_16(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSliderRepresentation2D_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation2D_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkSliderRepresentation2D NewInstance()
	{
		vtkSliderRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliderRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation2D_PlaceWidget_19(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display space
	/// where the widget should be placed.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkSliderRepresentation2D_PlaceWidget_19(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation2D_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef window);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkSliderRepresentation2D_ReleaseGraphicsResources_20(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation2D_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkSliderRepresentation2D_RenderOpaqueGeometry_21(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation2D_RenderOverlay_22(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkSliderRepresentation2D_RenderOverlay_22(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation2D_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkSliderRepresentation2D SafeDownCast(vtkObjectBase o)
	{
		vtkSliderRepresentation2D vtkSliderRepresentation2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation2D_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderRepresentation2D2 = (vtkSliderRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderRepresentation2D2.Register(null);
			}
		}
		return vtkSliderRepresentation2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation2D_SetTitleText_24(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify the label text for this widget. If the value is not set, or set
	/// to the empty string "", then the label text is not displayed.
	/// </summary>
	public override void SetTitleText(string arg0)
	{
		vtkSliderRepresentation2D_SetTitleText_24(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation2D_StartWidgetInteraction_25(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display space
	/// where the widget should be placed.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkSliderRepresentation2D_StartWidgetInteraction_25(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation2D_WidgetInteraction_26(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
	/// assumes that the parameter bounds[6] specifies the location in display space
	/// where the widget should be placed.
	/// </summary>
	public override void WidgetInteraction(IntPtr newEventPos)
	{
		vtkSliderRepresentation2D_WidgetInteraction_26(GetCppThis(), newEventPos);
	}
}
