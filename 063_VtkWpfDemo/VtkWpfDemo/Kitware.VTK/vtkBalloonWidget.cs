using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBalloonWidget
/// </summary>
/// <remarks>
///    popup text balloons above instance of vtkProp when hovering occurs
///
/// The vtkBalloonWidget is used to popup text and/or an image when the mouse
/// hovers over an instance of vtkProp. The widget keeps track of
/// (vtkProp,vtkBalloon) pairs (where the internal vtkBalloon class is defined
/// by a pair of vtkStdString and vtkImageData), and when the mouse stops
/// moving for a user-specified period of time over the vtkProp, then the
/// vtkBalloon is drawn nearby the vtkProp. Note that an instance of
/// vtkBalloonRepresentation is used to draw the balloon.
///
/// To use this widget, specify an instance of vtkBalloonWidget and a
/// representation (e.g., vtkBalloonRepresentation). Then list all instances
/// of vtkProp, a text string, and/or an instance of vtkImageData to be
/// associated with each vtkProp. (Note that you can specify both text and an
/// image, or just one or the other.) You may also wish to specify the hover
/// delay (i.e., set in the superclass vtkHoverWidget).
///
/// @par Event Bindings:
/// By default, the widget observes the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
///   MouseMoveEvent - occurs when mouse is moved in render window.
///   TimerEvent - occurs when the time between events (e.g., mouse move)
///                is greater than TimerDuration.
///   KeyPressEvent - when the "Enter" key is pressed after the balloon appears,
///                   a callback is activated (e.g., WidgetActivateEvent).
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkBalloonWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Move -- start the timer
///   vtkWidgetEvent::TimedOut -- when hovering occurs,
///   vtkWidgetEvent::SelectAction -- activate any callbacks associated
///                                   with the balloon.
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// This widget invokes the following VTK events on itself (which observers
/// can listen for):
/// &lt;pre&gt;
///   vtkCommand::TimerEvent (when hovering is determined to occur)
///   vtkCommand::EndInteractionEvent (after a hover has occurred and the
///                                    mouse begins moving again).
///   vtkCommand::WidgetActivateEvent (when the balloon is selected with a
///                                    keypress).
/// &lt;/pre&gt;
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractWidget
/// </seealso>
public class vtkBalloonWidget : vtkHoverWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBalloonWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBalloonWidget()
	{
		MRClassNameKey = "class vtkBalloonWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBalloonWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBalloonWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkBalloonWidget New()
	{
		vtkBalloonWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkBalloonWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBalloonWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBalloonWidget_AddBalloon_01(HandleRef pThis, HandleRef prop, string str, HandleRef img);

	/// <summary>
	/// Add and remove text and/or an image to be associated with a vtkProp. You
	/// may add one or both of them.
	/// </summary>
	public void AddBalloon(vtkProp prop, string str, vtkImageData img)
	{
		vtkBalloonWidget_AddBalloon_01(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef), str, img?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_AddBalloon_02(HandleRef pThis, HandleRef prop, string str);

	/// <summary>
	/// Add and remove text and/or an image to be associated with a vtkProp. You
	/// may add one or both of them.
	/// </summary>
	public void AddBalloon(vtkProp prop, string str)
	{
		vtkBalloonWidget_AddBalloon_02(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef), str);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_CreateDefaultRepresentation_03(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkBalloonWidget_CreateDefaultRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonWidget_GetBalloonImage_04(HandleRef pThis, HandleRef prop, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Methods to retrieve the information associated with each vtkProp (i.e.,
	/// the information that makes up each balloon). A nullptr will be returned if
	/// the vtkProp does not exist, or if a string or image have not been
	/// associated with the specified vtkProp.
	/// </summary>
	public vtkImageData GetBalloonImage(vtkProp prop)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonWidget_GetBalloonImage_04(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBalloonWidget_GetBalloonRepresentation_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkBalloonRepresentation.
	/// </summary>
	public vtkBalloonRepresentation GetBalloonRepresentation()
	{
		vtkBalloonRepresentation vtkBalloonRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonWidget_GetBalloonRepresentation_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBalloonRepresentation2 = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBalloonRepresentation2.Register(null);
			}
		}
		return vtkBalloonRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonWidget_GetBalloonString_06(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to retrieve the information associated with each vtkProp (i.e.,
	/// the information that makes up each balloon). A nullptr will be returned if
	/// the vtkProp does not exist, or if a string or image have not been
	/// associated with the specified vtkProp.
	/// </summary>
	public string GetBalloonString(vtkProp prop)
	{
		return Marshal.PtrToStringAnsi(vtkBalloonWidget_GetBalloonString_06(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef)));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonWidget_GetCurrentProp_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the current vtkProp that is being hovered over. Note that the
	/// value may be nullptr (if hovering over nothing or the mouse is moving).
	/// </summary>
	public virtual vtkProp GetCurrentProp()
	{
		vtkProp vtkProp2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonWidget_GetCurrentProp_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp2 = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp2.Register(null);
			}
		}
		return vtkProp2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBalloonWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBalloonWidget_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBalloonWidget_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBalloonWidget_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonWidget_GetPicker_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the object used to perform pick operations. Since the
	/// vtkBalloonWidget operates on vtkProps, the picker must be a subclass of
	/// vtkAbstractPropPicker. (Note: if not specified, an instance of
	/// vtkPropPicker is used.)
	/// </summary>
	public virtual vtkAbstractPropPicker GetPicker()
	{
		vtkAbstractPropPicker vtkAbstractPropPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonWidget_GetPicker_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPropPicker2 = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPropPicker2.Register(null);
			}
		}
		return vtkAbstractPropPicker2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonWidget_IsA_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBalloonWidget_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBalloonWidget_IsTypeOf_12(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBalloonWidget_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonWidget_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkBalloonWidget NewInstance()
	{
		vtkBalloonWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonWidget_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_RegisterPickers_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the object used to perform pick operations. Since the
	/// vtkBalloonWidget operates on vtkProps, the picker must be a subclass of
	/// vtkAbstractPropPicker. (Note: if not specified, an instance of
	/// vtkPropPicker is used.)
	/// </summary>
	public virtual void RegisterPickers()
	{
		vtkBalloonWidget_RegisterPickers_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_RemoveBalloon_16(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Add and remove text and/or an image to be associated with a vtkProp. You
	/// may add one or both of them.
	/// </summary>
	public void RemoveBalloon(vtkProp prop)
	{
		vtkBalloonWidget_RemoveBalloon_16(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBalloonWidget_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkBalloonWidget SafeDownCast(vtkObjectBase o)
	{
		vtkBalloonWidget vtkBalloonWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBalloonWidget_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBalloonWidget2 = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBalloonWidget2.Register(null);
			}
		}
		return vtkBalloonWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_SetEnabled_18(HandleRef pThis, int arg0);

	/// <summary>
	/// The method for activating and deactivating this widget. This method
	/// must be overridden because it performs special timer-related operations.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkBalloonWidget_SetEnabled_18(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_SetPicker_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the object used to perform pick operations. Since the
	/// vtkBalloonWidget operates on vtkProps, the picker must be a subclass of
	/// vtkAbstractPropPicker. (Note: if not specified, an instance of
	/// vtkPropPicker is used.)
	/// </summary>
	public void SetPicker(vtkAbstractPropPicker arg0)
	{
		vtkBalloonWidget_SetPicker_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_SetRepresentation_20(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkBalloonRepresentation r)
	{
		vtkBalloonWidget_SetRepresentation_20(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_UpdateBalloonImage_21(HandleRef pThis, HandleRef prop, HandleRef image);

	/// <summary>
	/// Update the balloon string or image. If the specified prop does not exist,
	/// then nothing is added not changed.
	/// </summary>
	public void UpdateBalloonImage(vtkProp prop, vtkImageData image)
	{
		vtkBalloonWidget_UpdateBalloonImage_21(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef), image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBalloonWidget_UpdateBalloonString_22(HandleRef pThis, HandleRef prop, string str);

	/// <summary>
	/// Update the balloon string or image. If the specified prop does not exist,
	/// then nothing is added not changed.
	/// </summary>
	public void UpdateBalloonString(vtkProp prop, string str)
	{
		vtkBalloonWidget_UpdateBalloonString_22(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef), str);
	}
}
