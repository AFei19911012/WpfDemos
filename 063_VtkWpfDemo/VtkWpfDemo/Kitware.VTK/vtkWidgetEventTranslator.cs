using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWidgetEventTranslator
/// </summary>
/// <remarks>
///    map VTK events into widget events
///
/// vtkWidgetEventTranslator maps VTK events (defined on vtkCommand) into
/// widget events (defined in vtkWidgetEvent.h). This class is typically used
/// in combination with vtkWidgetCallbackMapper, which is responsible for
/// translating widget events into method callbacks, and then invoking the
/// callbacks.
///
/// This class can be used to define different mappings of VTK events into
/// the widget events. Thus widgets can be reconfigured to use different
/// event bindings.
///
/// </remarks>
/// <seealso>
///
/// vtkWidgetEvent vtkCommand vtkInteractorObserver
/// </seealso>
public class vtkWidgetEventTranslator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetEventTranslator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWidgetEventTranslator()
	{
		MRClassNameKey = "class vtkWidgetEventTranslator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetEventTranslator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWidgetEventTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetEventTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkWidgetEventTranslator New()
	{
		vtkWidgetEventTranslator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetEventTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkWidgetEventTranslator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWidgetEventTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkWidgetEventTranslator_ClearEvents_01(HandleRef pThis);

	/// <summary>
	/// Clear all events from the translator (i.e., no events will be
	/// translated).
	/// </summary>
	public void ClearEvents()
	{
		vtkWidgetEventTranslator_ClearEvents_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetEventTranslator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWidgetEventTranslator_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetEventTranslator_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWidgetEventTranslator_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkWidgetEventTranslator_GetTranslation_04(HandleRef pThis, uint VTKEvent);

	/// <summary>
	/// Translate a VTK event into a widget event. If no event mapping is found,
	/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
	/// </summary>
	public uint GetTranslation(uint VTKEvent)
	{
		return vtkWidgetEventTranslator_GetTranslation_04(GetCppThis(), VTKEvent);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetEventTranslator_GetTranslation_05(HandleRef pThis, string VTKEvent);

	/// <summary>
	/// Translate a VTK event into a widget event. If no event mapping is found,
	/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
	/// </summary>
	public string GetTranslation(string VTKEvent)
	{
		return Marshal.PtrToStringAnsi(vtkWidgetEventTranslator_GetTranslation_05(GetCppThis(), VTKEvent));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkWidgetEventTranslator_GetTranslation_06(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym);

	/// <summary>
	/// Translate a VTK event into a widget event. If no event mapping is found,
	/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
	/// </summary>
	public uint GetTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym)
	{
		return vtkWidgetEventTranslator_GetTranslation_06(GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkWidgetEventTranslator_GetTranslation_07(HandleRef pThis, uint VTKEvent, HandleRef edata);

	/// <summary>
	/// Translate a VTK event into a widget event. If no event mapping is found,
	/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
	/// </summary>
	public uint GetTranslation(uint VTKEvent, vtkEventData edata)
	{
		return vtkWidgetEventTranslator_GetTranslation_07(GetCppThis(), VTKEvent, edata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkWidgetEventTranslator_GetTranslation_08(HandleRef pThis, HandleRef VTKEvent);

	/// <summary>
	/// Translate a VTK event into a widget event. If no event mapping is found,
	/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
	/// </summary>
	public uint GetTranslation(vtkEvent VTKEvent)
	{
		return vtkWidgetEventTranslator_GetTranslation_08(GetCppThis(), VTKEvent?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEventTranslator_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWidgetEventTranslator_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEventTranslator_IsTypeOf_10(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWidgetEventTranslator_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetEventTranslator_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new vtkWidgetEventTranslator NewInstance()
	{
		vtkWidgetEventTranslator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetEventTranslator_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEventTranslator_RemoveTranslation_13(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym);

	/// <summary>
	/// Remove translations for a binding.
	/// Returns the number of translations removed.
	/// </summary>
	public int RemoveTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym)
	{
		return vtkWidgetEventTranslator_RemoveTranslation_13(GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEventTranslator_RemoveTranslation_14(HandleRef pThis, HandleRef e);

	/// <summary>
	/// Remove translations for a binding.
	/// Returns the number of translations removed.
	/// </summary>
	public int RemoveTranslation(vtkEvent e)
	{
		return vtkWidgetEventTranslator_RemoveTranslation_14(GetCppThis(), e?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEventTranslator_RemoveTranslation_15(HandleRef pThis, HandleRef e);

	/// <summary>
	/// Remove translations for a binding.
	/// Returns the number of translations removed.
	/// </summary>
	public int RemoveTranslation(vtkEventData e)
	{
		return vtkWidgetEventTranslator_RemoveTranslation_15(GetCppThis(), e?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEventTranslator_RemoveTranslation_16(HandleRef pThis, uint VTKEvent);

	/// <summary>
	/// Remove translations for a binding.
	/// Returns the number of translations removed.
	/// </summary>
	public int RemoveTranslation(uint VTKEvent)
	{
		return vtkWidgetEventTranslator_RemoveTranslation_16(GetCppThis(), VTKEvent);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEventTranslator_RemoveTranslation_17(HandleRef pThis, string VTKEvent);

	/// <summary>
	/// Remove translations for a binding.
	/// Returns the number of translations removed.
	/// </summary>
	public int RemoveTranslation(string VTKEvent)
	{
		return vtkWidgetEventTranslator_RemoveTranslation_17(GetCppThis(), VTKEvent);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetEventTranslator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static vtkWidgetEventTranslator SafeDownCast(vtkObjectBase o)
	{
		vtkWidgetEventTranslator vtkWidgetEventTranslator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetEventTranslator_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWidgetEventTranslator2 = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWidgetEventTranslator2.Register(null);
			}
		}
		return vtkWidgetEventTranslator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetEventTranslator_SetTranslation_19(HandleRef pThis, uint VTKEvent, uint widgetEvent);

	/// <summary>
	/// Use these methods to create the translation from a VTK event to a widget
	/// event. Specifying vtkWidgetEvent::NoEvent or an empty
	/// string for the (toEvent) erases the mapping for the event.
	/// </summary>
	public void SetTranslation(uint VTKEvent, uint widgetEvent)
	{
		vtkWidgetEventTranslator_SetTranslation_19(GetCppThis(), VTKEvent, widgetEvent);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetEventTranslator_SetTranslation_20(HandleRef pThis, string VTKEvent, string widgetEvent);

	/// <summary>
	/// Use these methods to create the translation from a VTK event to a widget
	/// event. Specifying vtkWidgetEvent::NoEvent or an empty
	/// string for the (toEvent) erases the mapping for the event.
	/// </summary>
	public void SetTranslation(string VTKEvent, string widgetEvent)
	{
		vtkWidgetEventTranslator_SetTranslation_20(GetCppThis(), VTKEvent, widgetEvent);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetEventTranslator_SetTranslation_21(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent);

	/// <summary>
	/// Use these methods to create the translation from a VTK event to a widget
	/// event. Specifying vtkWidgetEvent::NoEvent or an empty
	/// string for the (toEvent) erases the mapping for the event.
	/// </summary>
	public void SetTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent)
	{
		vtkWidgetEventTranslator_SetTranslation_21(GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym, widgetEvent);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetEventTranslator_SetTranslation_22(HandleRef pThis, HandleRef VTKevent, uint widgetEvent);

	/// <summary>
	/// Use these methods to create the translation from a VTK event to a widget
	/// event. Specifying vtkWidgetEvent::NoEvent or an empty
	/// string for the (toEvent) erases the mapping for the event.
	/// </summary>
	public void SetTranslation(vtkEvent VTKevent, uint widgetEvent)
	{
		vtkWidgetEventTranslator_SetTranslation_22(GetCppThis(), VTKevent?.GetCppThis() ?? default(HandleRef), widgetEvent);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetEventTranslator_SetTranslation_23(HandleRef pThis, uint VTKEvent, HandleRef edata, uint widgetEvent);

	/// <summary>
	/// Use these methods to create the translation from a VTK event to a widget
	/// event. Specifying vtkWidgetEvent::NoEvent or an empty
	/// string for the (toEvent) erases the mapping for the event.
	/// </summary>
	public void SetTranslation(uint VTKEvent, vtkEventData edata, uint widgetEvent)
	{
		vtkWidgetEventTranslator_SetTranslation_23(GetCppThis(), VTKEvent, edata?.GetCppThis() ?? default(HandleRef), widgetEvent);
	}
}
