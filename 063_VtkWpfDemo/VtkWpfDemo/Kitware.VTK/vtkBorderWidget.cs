using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBorderWidget
/// </summary>
/// <remarks>
///    place a border around a 2D rectangular region
///
/// This class is a superclass for 2D widgets that may require a rectangular
/// border. Besides drawing a border, the widget provides methods for resizing
/// and moving the rectangular region (and associated border). The widget
/// provides methods and internal data members so that subclasses can take
/// advantage of this widgets capabilities, requiring only that the subclass
/// defines a "representation", i.e., some combination of props or actors
/// that can be managed in the 2D rectangular region.
///
/// The class defines basic positioning functionality, including the ability
/// to size the widget with locked x/y proportions. The area within the border
/// may be made "selectable" as well, meaning that a selection event interior
/// to the widget invokes a virtual SelectRegion() method, which can be used
/// to pick objects or otherwise manipulate data interior to the widget.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// On the boundary of the widget:
///   LeftButtonPressEvent - select boundary
///   LeftButtonReleaseEvent - deselect boundary
///   MouseMoveEvent - move/resize widget depending on which portion of the
///                    boundary was selected.
/// On the interior of the widget:
///   LeftButtonPressEvent - invoke SelectButton() callback (if the ivar
///                          Selectable is on)
/// Anywhere on the widget:
///   MiddleButtonPressEvent - move the widget
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkBorderWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Translate -- the widget is to be translated
///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// In turn, when these widget events are processed, this widget invokes the
/// following VTK events on itself (which observers can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
/// &lt;/pre&gt;
///
/// </remarks>
/// <seealso>
///
/// vtkInteractorObserver vtkCameraInterpolator
/// </seealso>
public class vtkBorderWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBorderWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBorderWidget()
	{
		MRClassNameKey = "class vtkBorderWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBorderWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBorderWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Method to instantiate class.
	/// </summary>
	public new static vtkBorderWidget New()
	{
		vtkBorderWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Method to instantiate class.
	/// </summary>
	public vtkBorderWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBorderWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBorderWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkBorderWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderWidget_GetBorderRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkBorderRepresentation.
	/// </summary>
	public vtkBorderRepresentation GetBorderRepresentation()
	{
		vtkBorderRepresentation vtkBorderRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderWidget_GetBorderRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBorderRepresentation2 = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBorderRepresentation2.Register(null);
			}
		}
		return vtkBorderRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBorderWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBorderWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBorderWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBorderWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderWidget_GetProcessEvents_05(HandleRef pThis);

	/// <summary>
	/// Reimplement ProcessEvents to disable it when using relative location with
	/// windowLocation. When using exact location this override has no effect.
	/// </summary>
	public override int GetProcessEvents()
	{
		return vtkBorderWidget_GetProcessEvents_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderWidget_GetResizable_06(HandleRef pThis);

	/// <summary>
	/// Indicate whether the boundary of the widget can be resized.
	/// If not, the cursor will not change to "resize" type when mouse
	/// over the boundary.
	/// </summary>
	public virtual int GetResizable()
	{
		return vtkBorderWidget_GetResizable_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderWidget_GetSelectable_07(HandleRef pThis);

	/// <summary>
	/// Indicate whether the interior region of the widget can be selected or
	/// not. If not, then events (such as left mouse down) allow the user to
	/// "move" the widget, and no selection is possible. Otherwise the
	/// SelectRegion() method is invoked.
	/// </summary>
	public virtual int GetSelectable()
	{
		return vtkBorderWidget_GetSelectable_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderWidget_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBorderWidget_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBorderWidget_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBorderWidget_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public new vtkBorderWidget NewInstance()
	{
		vtkBorderWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderWidget_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderWidget_ResizableOff_12(HandleRef pThis);

	/// <summary>
	/// Indicate whether the boundary of the widget can be resized.
	/// If not, the cursor will not change to "resize" type when mouse
	/// over the boundary.
	/// </summary>
	public virtual void ResizableOff()
	{
		vtkBorderWidget_ResizableOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderWidget_ResizableOn_13(HandleRef pThis);

	/// <summary>
	/// Indicate whether the boundary of the widget can be resized.
	/// If not, the cursor will not change to "resize" type when mouse
	/// over the boundary.
	/// </summary>
	public virtual void ResizableOn()
	{
		vtkBorderWidget_ResizableOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBorderWidget_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public new static vtkBorderWidget SafeDownCast(vtkObjectBase o)
	{
		vtkBorderWidget vtkBorderWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBorderWidget_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBorderWidget2 = (vtkBorderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBorderWidget2.Register(null);
			}
		}
		return vtkBorderWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderWidget_SelectableOff_15(HandleRef pThis);

	/// <summary>
	/// Indicate whether the interior region of the widget can be selected or
	/// not. If not, then events (such as left mouse down) allow the user to
	/// "move" the widget, and no selection is possible. Otherwise the
	/// SelectRegion() method is invoked.
	/// </summary>
	public virtual void SelectableOff()
	{
		vtkBorderWidget_SelectableOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderWidget_SelectableOn_16(HandleRef pThis);

	/// <summary>
	/// Indicate whether the interior region of the widget can be selected or
	/// not. If not, then events (such as left mouse down) allow the user to
	/// "move" the widget, and no selection is possible. Otherwise the
	/// SelectRegion() method is invoked.
	/// </summary>
	public virtual void SelectableOn()
	{
		vtkBorderWidget_SelectableOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderWidget_SetRepresentation_17(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkBorderRepresentation r)
	{
		vtkBorderWidget_SetRepresentation_17(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderWidget_SetResizable_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether the boundary of the widget can be resized.
	/// If not, the cursor will not change to "resize" type when mouse
	/// over the boundary.
	/// </summary>
	public virtual void SetResizable(int _arg)
	{
		vtkBorderWidget_SetResizable_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBorderWidget_SetSelectable_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether the interior region of the widget can be selected or
	/// not. If not, then events (such as left mouse down) allow the user to
	/// "move" the widget, and no selection is possible. Otherwise the
	/// SelectRegion() method is invoked.
	/// </summary>
	public virtual void SetSelectable(int _arg)
	{
		vtkBorderWidget_SetSelectable_19(GetCppThis(), _arg);
	}
}
