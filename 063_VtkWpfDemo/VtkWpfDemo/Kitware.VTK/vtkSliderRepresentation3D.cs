using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSliderRepresentation3D
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
public class vtkSliderRepresentation3D : vtkSliderRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSliderRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSliderRepresentation3D()
	{
		MRClassNameKey = "class vtkSliderRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSliderRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkSliderRepresentation3D New()
	{
		vtkSliderRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkSliderRepresentation3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSliderRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSliderRepresentation3D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkSliderRepresentation3D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_GetActors_02(HandleRef pThis, HandleRef propCollection);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void GetActors(vtkPropCollection propCollection)
	{
		vtkSliderRepresentation3D_GetActors_02(GetCppThis(), propCollection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkSliderRepresentation3D_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_GetCapProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties for the tube and end caps.
	/// </summary>
	public virtual vtkProperty GetCapProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation3D_GetCapProperty_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkSliderRepresentation3D_GetMTime_05(HandleRef pThis);

	/// <summary>
	/// Override GetMTime to include point coordinates
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSliderRepresentation3D_GetMTime_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliderRepresentation3D_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSliderRepresentation3D_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliderRepresentation3D_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSliderRepresentation3D_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_GetPoint1Coordinate_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkSliderRepresentation3D_GetPoint1Coordinate_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSliderRepresentation3D_GetPoint2Coordinate_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkSliderRepresentation3D_GetPoint2Coordinate_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkSliderRepresentation3D_GetRotation_10(HandleRef pThis);

	/// <summary>
	/// Set the rotation of the slider widget around the axis of the widget. This is
	/// used to control which way the widget is initially oriented. (This is especially
	/// important for the label and title.)
	/// </summary>
	public virtual double GetRotation()
	{
		return vtkSliderRepresentation3D_GetRotation_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_GetSelectedProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the selection property. This property is used to modify the appearance of
	/// selected objects (e.g., the slider).
	/// </summary>
	public virtual vtkProperty GetSelectedProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation3D_GetSelectedProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSliderRepresentation3D_GetSliderProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the slider properties. The properties of the slider when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSliderProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation3D_GetSliderProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSliderRepresentation3D_GetSliderShape_13(HandleRef pThis);

	/// <summary>
	/// Specify whether to use a sphere or cylinder slider shape. By default, a
	/// sphere shape is used.
	/// </summary>
	public virtual int GetSliderShape()
	{
		return vtkSliderRepresentation3D_GetSliderShape_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation3D_GetSliderShapeMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify whether to use a sphere or cylinder slider shape. By default, a
	/// sphere shape is used.
	/// </summary>
	public virtual int GetSliderShapeMaxValue()
	{
		return vtkSliderRepresentation3D_GetSliderShapeMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation3D_GetSliderShapeMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify whether to use a sphere or cylinder slider shape. By default, a
	/// sphere shape is used.
	/// </summary>
	public virtual int GetSliderShapeMinValue()
	{
		return vtkSliderRepresentation3D_GetSliderShapeMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_GetTitleText_16(HandleRef pThis);

	/// <summary>
	/// Specify the title text for this widget. If the value is not set, or set
	/// to the empty string "", then the title text is not displayed.
	/// </summary>
	public override string GetTitleText()
	{
		return Marshal.PtrToStringAnsi(vtkSliderRepresentation3D_GetTitleText_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_GetTubeProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties for the tube and end caps.
	/// </summary>
	public virtual vtkProperty GetTubeProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation3D_GetTubeProperty_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkSliderRepresentation3D_HasTranslucentPolygonalGeometry_18(HandleRef pThis);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkSliderRepresentation3D_HasTranslucentPolygonalGeometry_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_Highlight_19(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget.
	/// </summary>
	public override void Highlight(int arg0)
	{
		vtkSliderRepresentation3D_Highlight_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation3D_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSliderRepresentation3D_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation3D_IsTypeOf_21(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSliderRepresentation3D_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkSliderRepresentation3D NewInstance()
	{
		vtkSliderRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation3D_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_PlaceWidget_24(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkSliderRepresentation3D_PlaceWidget_24(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_RegisterPickers_25(HandleRef pThis);

	/// <summary>
	/// Override GetMTime to include point coordinates
	/// </summary>
	public override void RegisterPickers()
	{
		vtkSliderRepresentation3D_RegisterPickers_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef window);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkSliderRepresentation3D_ReleaseGraphicsResources_26(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation3D_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkSliderRepresentation3D_RenderOpaqueGeometry_27(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderRepresentation3D_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods supporting the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkSliderRepresentation3D_RenderTranslucentPolygonalGeometry_28(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderRepresentation3D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkSliderRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkSliderRepresentation3D vtkSliderRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderRepresentation3D_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderRepresentation3D2 = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderRepresentation3D2.Register(null);
			}
		}
		return vtkSliderRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_SetPoint1InWorldCoordinates_30(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Position the first end point of the slider. Note that this point is an
	/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
	/// variety of coordinate systems, and can even be relative to another
	/// point. To set the point, you'll want to get the Point1Coordinate and
	/// then invoke the necessary methods to put it into the correct coordinate
	/// system and set the correct initial value.
	/// </summary>
	public void SetPoint1InWorldCoordinates(double x, double y, double z)
	{
		vtkSliderRepresentation3D_SetPoint1InWorldCoordinates_30(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_SetPoint2InWorldCoordinates_31(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Position the second end point of the slider. Note that this point is an
	/// instance of vtkCoordinate, meaning that Point 1 can be specified in a
	/// variety of coordinate systems, and can even be relative to another
	/// point. To set the point, you'll want to get the Point2Coordinate and
	/// then invoke the necessary methods to put it into the correct coordinate
	/// system and set the correct initial value.
	/// </summary>
	public void SetPoint2InWorldCoordinates(double x, double y, double z)
	{
		vtkSliderRepresentation3D_SetPoint2InWorldCoordinates_31(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_SetRotation_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the rotation of the slider widget around the axis of the widget. This is
	/// used to control which way the widget is initially oriented. (This is especially
	/// important for the label and title.)
	/// </summary>
	public virtual void SetRotation(double _arg)
	{
		vtkSliderRepresentation3D_SetRotation_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_SetSliderShape_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to use a sphere or cylinder slider shape. By default, a
	/// sphere shape is used.
	/// </summary>
	public virtual void SetSliderShape(int _arg)
	{
		vtkSliderRepresentation3D_SetSliderShape_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_SetSliderShapeToCylinder_34(HandleRef pThis);

	/// <summary>
	/// Specify whether to use a sphere or cylinder slider shape. By default, a
	/// sphere shape is used.
	/// </summary>
	public void SetSliderShapeToCylinder()
	{
		vtkSliderRepresentation3D_SetSliderShapeToCylinder_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_SetSliderShapeToSphere_35(HandleRef pThis);

	/// <summary>
	/// Specify whether to use a sphere or cylinder slider shape. By default, a
	/// sphere shape is used.
	/// </summary>
	public void SetSliderShapeToSphere()
	{
		vtkSliderRepresentation3D_SetSliderShapeToSphere_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_SetTitleText_36(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify the title text for this widget. If the value is not set, or set
	/// to the empty string "", then the title text is not displayed.
	/// </summary>
	public override void SetTitleText(string arg0)
	{
		vtkSliderRepresentation3D_SetTitleText_36(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_StartWidgetInteraction_37(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkSliderRepresentation3D_StartWidgetInteraction_37(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderRepresentation3D_WidgetInteraction_38(HandleRef pThis, IntPtr newEventPos);

	/// <summary>
	/// Methods to interface with the vtkSliderWidget.
	/// </summary>
	public override void WidgetInteraction(IntPtr newEventPos)
	{
		vtkSliderRepresentation3D_WidgetInteraction_38(GetCppThis(), newEventPos);
	}
}
