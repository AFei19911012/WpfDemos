using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContinuousValueWidget
/// </summary>
/// <remarks>
///    set a value by manipulating something
///
/// The vtkContinuousValueWidget is used to adjust a scalar value in an
/// application. Note that the actual appearance of the widget depends on
/// the specific representation for the widget.
///
/// To use this widget, set the widget representation. (the details may
/// vary depending on the particulars of the representation).
///
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
/// into the vtkContinuousValueWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkContinuousValueWidget
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
/// </remarks>
public abstract class vtkContinuousValueWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContinuousValueWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContinuousValueWidget()
	{
		MRClassNameKey = "class vtkContinuousValueWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContinuousValueWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContinuousValueWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkContinuousValueWidget_GetContinuousValueWidgetRepresentation_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkContinuousValueWidgetRepresentation.
	/// </summary>
	public vtkContinuousValueWidgetRepresentation GetContinuousValueWidgetRepresentation()
	{
		vtkContinuousValueWidgetRepresentation vtkContinuousValueWidgetRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContinuousValueWidget_GetContinuousValueWidgetRepresentation_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContinuousValueWidgetRepresentation2 = (vtkContinuousValueWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContinuousValueWidgetRepresentation2.Register(null);
			}
		}
		return vtkContinuousValueWidgetRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContinuousValueWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContinuousValueWidget_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContinuousValueWidget_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContinuousValueWidget_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContinuousValueWidget_GetValue_04(HandleRef pThis);

	/// <summary>
	/// Get the value for this widget.
	/// </summary>
	public double GetValue()
	{
		return vtkContinuousValueWidget_GetValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContinuousValueWidget_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContinuousValueWidget_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContinuousValueWidget_IsTypeOf_06(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContinuousValueWidget_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContinuousValueWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new vtkContinuousValueWidget NewInstance()
	{
		vtkContinuousValueWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContinuousValueWidget_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContinuousValueWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContinuousValueWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static vtkContinuousValueWidget SafeDownCast(vtkObjectBase o)
	{
		vtkContinuousValueWidget vtkContinuousValueWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContinuousValueWidget_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContinuousValueWidget2 = (vtkContinuousValueWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContinuousValueWidget2.Register(null);
			}
		}
		return vtkContinuousValueWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContinuousValueWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkContinuousValueWidgetRepresentation r)
	{
		vtkContinuousValueWidget_SetRepresentation_09(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContinuousValueWidget_SetValue_10(HandleRef pThis, double v);

	/// <summary>
	/// Get the value for this widget.
	/// </summary>
	public void SetValue(double v)
	{
		vtkContinuousValueWidget_SetValue_10(GetCppThis(), v);
	}
}
