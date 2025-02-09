using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSliderWidget
/// </summary>
/// <remarks>
///    set a value by manipulating a slider
///
/// The vtkSliderWidget is used to set a scalar value in an application.  This
/// class assumes that a slider is moved along a 1D parameter space (e.g., a
/// spherical bead that can be moved along a tube).  Moving the slider
/// modifies the value of the widget, which can be used to set parameters on
/// other objects. Note that the actual appearance of the widget depends on
/// the specific representation for the widget.
///
/// To use this widget, set the widget representation. The representation is
/// assumed to consist of a tube, two end caps, and a slider (the details may
/// vary depending on the particulars of the representation). Then in the
/// representation you will typically set minimum and maximum value, as well
/// as the current value. The position of the slider must also be set, as well
/// as various properties.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// If the slider bead is selected:
///   LeftButtonPressEvent - select slider (if on slider)
///   LeftButtonReleaseEvent - release slider (if selected)
///   MouseMoveEvent - move slider
/// If the end caps or slider tube are selected:
///   LeftButtonPressEvent - move (or animate) to cap or point on tube;
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkSliderWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, the vtkSliderWidget
/// invokes the following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
/// </remarks>
public class vtkSliderWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSliderWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSliderWidget()
	{
		MRClassNameKey = "class vtkSliderWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSliderWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkSliderWidget New()
	{
		vtkSliderWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkSliderWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSliderWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSliderWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkSliderWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderWidget_GetAnimationMode_02(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the slider when selecting the tube or caps. If
	/// Jump, then selecting the tube, left cap, or right cap causes the slider to
	/// jump to the selection point. If the mode is Animate, the slider moves
	/// towards the selection point in NumberOfAnimationSteps number of steps.
	/// If Off, then the slider does not move.
	/// </summary>
	public virtual int GetAnimationMode()
	{
		return vtkSliderWidget_GetAnimationMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderWidget_GetAnimationModeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the slider when selecting the tube or caps. If
	/// Jump, then selecting the tube, left cap, or right cap causes the slider to
	/// jump to the selection point. If the mode is Animate, the slider moves
	/// towards the selection point in NumberOfAnimationSteps number of steps.
	/// If Off, then the slider does not move.
	/// </summary>
	public virtual int GetAnimationModeMaxValue()
	{
		return vtkSliderWidget_GetAnimationModeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderWidget_GetAnimationModeMinValue_04(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the slider when selecting the tube or caps. If
	/// Jump, then selecting the tube, left cap, or right cap causes the slider to
	/// jump to the selection point. If the mode is Animate, the slider moves
	/// towards the selection point in NumberOfAnimationSteps number of steps.
	/// If Off, then the slider does not move.
	/// </summary>
	public virtual int GetAnimationModeMinValue()
	{
		return vtkSliderWidget_GetAnimationModeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderWidget_GetNumberOfAnimationSteps_05(HandleRef pThis);

	/// <summary>
	/// Specify the number of animation steps to take if the animation mode
	/// is set to animate.
	/// </summary>
	public virtual int GetNumberOfAnimationSteps()
	{
		return vtkSliderWidget_GetNumberOfAnimationSteps_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderWidget_GetNumberOfAnimationStepsMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Specify the number of animation steps to take if the animation mode
	/// is set to animate.
	/// </summary>
	public virtual int GetNumberOfAnimationStepsMaxValue()
	{
		return vtkSliderWidget_GetNumberOfAnimationStepsMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderWidget_GetNumberOfAnimationStepsMinValue_07(HandleRef pThis);

	/// <summary>
	/// Specify the number of animation steps to take if the animation mode
	/// is set to animate.
	/// </summary>
	public virtual int GetNumberOfAnimationStepsMinValue()
	{
		return vtkSliderWidget_GetNumberOfAnimationStepsMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliderWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSliderWidget_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSliderWidget_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSliderWidget_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderWidget_GetSliderRepresentation_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkSliderRepresentation.
	/// </summary>
	public vtkSliderRepresentation GetSliderRepresentation()
	{
		vtkSliderRepresentation vtkSliderRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderWidget_GetSliderRepresentation_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderRepresentation2 = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderRepresentation2.Register(null);
			}
		}
		return vtkSliderRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderWidget_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSliderWidget_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSliderWidget_IsTypeOf_12(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSliderWidget_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderWidget_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new vtkSliderWidget NewInstance()
	{
		vtkSliderWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderWidget_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSliderWidget_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static vtkSliderWidget SafeDownCast(vtkObjectBase o)
	{
		vtkSliderWidget vtkSliderWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSliderWidget_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSliderWidget2 = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSliderWidget2.Register(null);
			}
		}
		return vtkSliderWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderWidget_SetAnimationMode_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the slider when selecting the tube or caps. If
	/// Jump, then selecting the tube, left cap, or right cap causes the slider to
	/// jump to the selection point. If the mode is Animate, the slider moves
	/// towards the selection point in NumberOfAnimationSteps number of steps.
	/// If Off, then the slider does not move.
	/// </summary>
	public virtual void SetAnimationMode(int _arg)
	{
		vtkSliderWidget_SetAnimationMode_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderWidget_SetAnimationModeToAnimate_17(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the slider when selecting the tube or caps. If
	/// Jump, then selecting the tube, left cap, or right cap causes the slider to
	/// jump to the selection point. If the mode is Animate, the slider moves
	/// towards the selection point in NumberOfAnimationSteps number of steps.
	/// If Off, then the slider does not move.
	/// </summary>
	public void SetAnimationModeToAnimate()
	{
		vtkSliderWidget_SetAnimationModeToAnimate_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderWidget_SetAnimationModeToJump_18(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the slider when selecting the tube or caps. If
	/// Jump, then selecting the tube, left cap, or right cap causes the slider to
	/// jump to the selection point. If the mode is Animate, the slider moves
	/// towards the selection point in NumberOfAnimationSteps number of steps.
	/// If Off, then the slider does not move.
	/// </summary>
	public void SetAnimationModeToJump()
	{
		vtkSliderWidget_SetAnimationModeToJump_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderWidget_SetAnimationModeToOff_19(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the slider when selecting the tube or caps. If
	/// Jump, then selecting the tube, left cap, or right cap causes the slider to
	/// jump to the selection point. If the mode is Animate, the slider moves
	/// towards the selection point in NumberOfAnimationSteps number of steps.
	/// If Off, then the slider does not move.
	/// </summary>
	public void SetAnimationModeToOff()
	{
		vtkSliderWidget_SetAnimationModeToOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderWidget_SetNumberOfAnimationSteps_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of animation steps to take if the animation mode
	/// is set to animate.
	/// </summary>
	public virtual void SetNumberOfAnimationSteps(int _arg)
	{
		vtkSliderWidget_SetNumberOfAnimationSteps_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSliderWidget_SetRepresentation_21(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkSliderRepresentation r)
	{
		vtkSliderWidget_SetRepresentation_21(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}
}
