using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompassWidget
/// </summary>
/// <remarks>
///    widget to set distance, tilt and heading
///
/// The vtkCompassWidget is used to adjust distance, tilt and heading parameters in an
/// application. It uses vtkCompassRepresentation as its representation.
///
/// To customize the widget override the CreateDefaultRepresentation method and set the
/// representation to your own subclass of vtkCompassRepresentation. Ranges for distance and tilt can
/// be set in vtkCompassRepresentation.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// If the slider bead is selected:
///   LeftButtonPressEvent - select slider
///   LeftButtonReleaseEvent - release slider
///   MouseMoveEvent - move slider
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkCompassWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkCompassWidget
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
///   vtkCommand::WidgetValueChangedEvent (when widget values have changed)
/// &lt;/pre&gt;
///
/// </remarks>
public class vtkCompassWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompassWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompassWidget()
	{
		MRClassNameKey = "class vtkCompassWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompassWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompassWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkCompassWidget New()
	{
		vtkCompassWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkCompassWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompassWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCompassWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkCompassWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassWidget_GetDistance_02(HandleRef pThis);

	/// <summary>
	/// Get/set the value for this widget.
	/// </summary>
	public double GetDistance()
	{
		return vtkCompassWidget_GetDistance_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassWidget_GetDistanceSpeed_03(HandleRef pThis);

	/// <summary>
	/// Get/set the distance speed in distance per second. This is the speed with which the distance
	/// changes when the top/bottom distance slider button is clicked. Default is 1.0/s.
	/// </summary>
	public virtual double GetDistanceSpeed()
	{
		return vtkCompassWidget_GetDistanceSpeed_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassWidget_GetHeading_04(HandleRef pThis);

	/// <summary>
	/// Get/set the value for this widget.
	/// </summary>
	public double GetHeading()
	{
		return vtkCompassWidget_GetHeading_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompassWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompassWidget_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompassWidget_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompassWidget_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassWidget_GetTilt_07(HandleRef pThis);

	/// <summary>
	/// Get/set the value for this widget.
	/// </summary>
	public double GetTilt()
	{
		return vtkCompassWidget_GetTilt_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCompassWidget_GetTiltSpeed_08(HandleRef pThis);

	/// <summary>
	/// Get/set the tilt speed in degrees per second. This is the speed with which the tilt
	/// changes when the top/bottom tilt slider button is clicked. Default is 30.0 degrees/s.
	/// </summary>
	public virtual double GetTiltSpeed()
	{
		return vtkCompassWidget_GetTiltSpeed_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompassWidget_GetTimerDuration_09(HandleRef pThis);

	/// <summary>
	/// Get/set the timer interval in milliseconds. The timer interval determines the update frequency
	/// for slider mouse interactions. Default is 50 ms.
	/// </summary>
	public virtual int GetTimerDuration()
	{
		return vtkCompassWidget_GetTimerDuration_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompassWidget_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompassWidget_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompassWidget_IsTypeOf_11(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompassWidget_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new vtkCompassWidget NewInstance()
	{
		vtkCompassWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassWidget_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompassWidget_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static vtkCompassWidget SafeDownCast(vtkObjectBase o)
	{
		vtkCompassWidget vtkCompassWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompassWidget_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompassWidget2 = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompassWidget2.Register(null);
			}
		}
		return vtkCompassWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassWidget_SetDistance_15(HandleRef pThis, double distance);

	/// <summary>
	/// Get/set the value for this widget.
	/// </summary>
	public void SetDistance(double distance)
	{
		vtkCompassWidget_SetDistance_15(GetCppThis(), distance);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassWidget_SetDistanceSpeed_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/set the distance speed in distance per second. This is the speed with which the distance
	/// changes when the top/bottom distance slider button is clicked. Default is 1.0/s.
	/// </summary>
	public virtual void SetDistanceSpeed(double _arg)
	{
		vtkCompassWidget_SetDistanceSpeed_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassWidget_SetHeading_17(HandleRef pThis, double v);

	/// <summary>
	/// Get/set the value for this widget.
	/// </summary>
	public void SetHeading(double v)
	{
		vtkCompassWidget_SetHeading_17(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassWidget_SetRepresentation_18(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkCompassRepresentation r)
	{
		vtkCompassWidget_SetRepresentation_18(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassWidget_SetTilt_19(HandleRef pThis, double tilt);

	/// <summary>
	/// Get/set the value for this widget.
	/// </summary>
	public void SetTilt(double tilt)
	{
		vtkCompassWidget_SetTilt_19(GetCppThis(), tilt);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassWidget_SetTiltSpeed_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Get/set the tilt speed in degrees per second. This is the speed with which the tilt
	/// changes when the top/bottom tilt slider button is clicked. Default is 30.0 degrees/s.
	/// </summary>
	public virtual void SetTiltSpeed(double _arg)
	{
		vtkCompassWidget_SetTiltSpeed_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompassWidget_SetTimerDuration_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/set the timer interval in milliseconds. The timer interval determines the update frequency
	/// for slider mouse interactions. Default is 50 ms.
	/// </summary>
	public virtual void SetTimerDuration(int _arg)
	{
		vtkCompassWidget_SetTimerDuration_21(GetCppThis(), _arg);
	}
}
