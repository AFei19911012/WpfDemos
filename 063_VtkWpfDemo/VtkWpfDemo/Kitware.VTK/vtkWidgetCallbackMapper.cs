using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWidgetCallbackMapper
/// </summary>
/// <remarks>
///    map widget events into callbacks
///
/// vtkWidgetCallbackMapper maps widget events (defined in vtkWidgetEvent.h)
/// into static class methods, and provides facilities to invoke the methods.
/// This class is templated and meant to be used as an internal helper class
/// by the widget classes. The class works in combination with the class
/// vtkWidgetEventTranslator, which translates VTK events into widget events.
///
/// </remarks>
/// <seealso>
///
/// vtkWidgetEvent vtkWidgetEventTranslator
/// </seealso>
public class vtkWidgetCallbackMapper : vtkObject
{
	/// <summary>
	/// Convenient typedef for working with callbacks.
	/// </summary>
	public delegate void CallbackType(IntPtr arg0);

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetCallbackMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWidgetCallbackMapper()
	{
		MRClassNameKey = "class vtkWidgetCallbackMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetCallbackMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWidgetCallbackMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetCallbackMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkWidgetCallbackMapper New()
	{
		vtkWidgetCallbackMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetCallbackMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkWidgetCallbackMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWidgetCallbackMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkWidgetCallbackMapper_GetEventTranslator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the vtkWidgetEventTranslator to coordinate with.
	/// </summary>
	public virtual vtkWidgetEventTranslator GetEventTranslator()
	{
		vtkWidgetEventTranslator vtkWidgetEventTranslator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetCallbackMapper_GetEventTranslator_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkWidgetCallbackMapper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWidgetCallbackMapper_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetCallbackMapper_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWidgetCallbackMapper_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetCallbackMapper_InvokeCallback_04(HandleRef pThis, uint widgetEvent);

	/// <summary>
	/// This method invokes the callback given a widget event. A non-zero value
	/// is returned if the listed event is registered.
	/// </summary>
	public void InvokeCallback(uint widgetEvent)
	{
		vtkWidgetCallbackMapper_InvokeCallback_04(GetCppThis(), widgetEvent);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetCallbackMapper_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWidgetCallbackMapper_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetCallbackMapper_IsTypeOf_06(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWidgetCallbackMapper_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetCallbackMapper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new vtkWidgetCallbackMapper NewInstance()
	{
		vtkWidgetCallbackMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetCallbackMapper_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetCallbackMapper_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static vtkWidgetCallbackMapper SafeDownCast(vtkObjectBase o)
	{
		vtkWidgetCallbackMapper vtkWidgetCallbackMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetCallbackMapper_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWidgetCallbackMapper2 = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWidgetCallbackMapper2.Register(null);
			}
		}
		return vtkWidgetCallbackMapper2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetCallbackMapper_SetCallbackMethod_10(HandleRef pThis, uint VTKEvent, uint widgetEvent, HandleRef w, CallbackType f);

	/// <summary>
	/// This class works with the class vtkWidgetEventTranslator to set up the
	/// initial coorespondence between VTK events, widget events, and callbacks.
	/// Different flavors of the SetCallbackMethod() are available depending on
	/// what sort of modifiers are to be associated with a particular event.
	/// Typically the widgets should use this method to set up their event
	/// callbacks. If modifiers are not provided (i.e., the VTKEvent is a
	/// unsigned long eventId) then modifiers are ignored. Otherwise, a vtkEvent
	/// instance is used to fully quality the events.
	/// </summary>
	public void SetCallbackMethod(uint VTKEvent, uint widgetEvent, vtkAbstractWidget w, CallbackType f)
	{
		vtkWidgetCallbackMapper_SetCallbackMethod_10(GetCppThis(), VTKEvent, widgetEvent, w?.GetCppThis() ?? default(HandleRef), f);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetCallbackMapper_SetCallbackMethod_11(HandleRef pThis, uint VTKEvent, int modifiers, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent, HandleRef w, CallbackType f);

	/// <summary>
	/// This class works with the class vtkWidgetEventTranslator to set up the
	/// initial coorespondence between VTK events, widget events, and callbacks.
	/// Different flavors of the SetCallbackMethod() are available depending on
	/// what sort of modifiers are to be associated with a particular event.
	/// Typically the widgets should use this method to set up their event
	/// callbacks. If modifiers are not provided (i.e., the VTKEvent is a
	/// unsigned long eventId) then modifiers are ignored. Otherwise, a vtkEvent
	/// instance is used to fully quality the events.
	/// </summary>
	public void SetCallbackMethod(uint VTKEvent, int modifiers, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent, vtkAbstractWidget w, CallbackType f)
	{
		vtkWidgetCallbackMapper_SetCallbackMethod_11(GetCppThis(), VTKEvent, modifiers, keyCode, repeatCount, keySym, widgetEvent, w?.GetCppThis() ?? default(HandleRef), f);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetCallbackMapper_SetCallbackMethod_12(HandleRef pThis, uint VTKEvent, HandleRef ed, uint widgetEvent, HandleRef w, CallbackType f);

	/// <summary>
	/// This class works with the class vtkWidgetEventTranslator to set up the
	/// initial coorespondence between VTK events, widget events, and callbacks.
	/// Different flavors of the SetCallbackMethod() are available depending on
	/// what sort of modifiers are to be associated with a particular event.
	/// Typically the widgets should use this method to set up their event
	/// callbacks. If modifiers are not provided (i.e., the VTKEvent is a
	/// unsigned long eventId) then modifiers are ignored. Otherwise, a vtkEvent
	/// instance is used to fully quality the events.
	/// </summary>
	public void SetCallbackMethod(uint VTKEvent, vtkEventData ed, uint widgetEvent, vtkAbstractWidget w, CallbackType f)
	{
		vtkWidgetCallbackMapper_SetCallbackMethod_12(GetCppThis(), VTKEvent, ed?.GetCppThis() ?? default(HandleRef), widgetEvent, w?.GetCppThis() ?? default(HandleRef), f);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetCallbackMapper_SetEventTranslator_13(HandleRef pThis, HandleRef t);

	/// <summary>
	/// Specify the vtkWidgetEventTranslator to coordinate with.
	/// </summary>
	public void SetEventTranslator(vtkWidgetEventTranslator t)
	{
		vtkWidgetCallbackMapper_SetEventTranslator_13(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}
}
