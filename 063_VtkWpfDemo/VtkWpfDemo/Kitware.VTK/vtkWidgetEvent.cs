using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWidgetEvent
/// </summary>
/// <remarks>
///    define widget events
///
/// vtkWidgetEvent defines widget events. These events are processed by
/// subclasses of vtkInteractorObserver.
/// </remarks>
public class vtkWidgetEvent : vtkObject
{
	/// <summary>
	/// All the widget events are defined here.
	/// </summary>
	public enum WidgetEventIds
	{
		/// <summary>enum member</summary>
		AddFinalPoint = 15,
		/// <summary>enum member</summary>
		AddFinalPoint3D = 31,
		/// <summary>enum member</summary>
		AddPoint = 14,
		/// <summary>enum member</summary>
		AddPoint3D = 30,
		/// <summary>enum member</summary>
		Completed = 16,
		/// <summary>enum member</summary>
		Delete = 3,
		/// <summary>enum member</summary>
		Down = 24,
		/// <summary>enum member</summary>
		EndResize = 9,
		/// <summary>enum member</summary>
		EndRotate = 11,
		/// <summary>enum member</summary>
		EndScale = 7,
		/// <summary>enum member</summary>
		EndSelect = 2,
		/// <summary>enum member</summary>
		EndSelect3D = 28,
		/// <summary>enum member</summary>
		EndTranslate = 5,
		/// <summary>enum member</summary>
		HoverLeave = 32,
		/// <summary>enum member</summary>
		Left = 25,
		/// <summary>enum member</summary>
		ModifyEvent = 21,
		/// <summary>enum member</summary>
		Move = 12,
		/// <summary>enum member</summary>
		Move3D = 29,
		/// <summary>enum member</summary>
		NoEvent = 0,
		/// <summary>enum member</summary>
		PickDirectionPoint = 19,
		/// <summary>enum member</summary>
		PickNormal = 18,
		/// <summary>enum member</summary>
		PickPoint = 17,
		/// <summary>enum member</summary>
		Reset = 22,
		/// <summary>enum member</summary>
		Resize = 8,
		/// <summary>enum member</summary>
		Right = 26,
		/// <summary>enum member</summary>
		Rotate = 10,
		/// <summary>enum member</summary>
		Scale = 6,
		/// <summary>enum member</summary>
		Select = 1,
		/// <summary>enum member</summary>
		Select3D = 27,
		/// <summary>enum member</summary>
		SizeHandles = 13,
		/// <summary>enum member</summary>
		TimedOut = 20,
		/// <summary>enum member</summary>
		Translate = 4,
		/// <summary>enum member</summary>
		Up = 23
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetEvent";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWidgetEvent()
	{
		MRClassNameKey = "class vtkWidgetEvent";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetEvent"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWidgetEvent(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetEvent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The object factory constructor.
	/// </summary>
	public new static vtkWidgetEvent New()
	{
		vtkWidgetEvent result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetEvent_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// The object factory constructor.
	/// </summary>
	public vtkWidgetEvent()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWidgetEvent_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkWidgetEvent_GetEventIdFromString_01(string arg0);

	/// <summary>
	/// Convenience methods for translating between event names and event ids.
	/// </summary>
	public static uint GetEventIdFromString(string arg0)
	{
		return vtkWidgetEvent_GetEventIdFromString_01(arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetEvent_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWidgetEvent_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetEvent_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWidgetEvent_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetEvent_GetStringFromEventId_04(uint arg0);

	/// <summary>
	/// Convenience methods for translating between event names and event ids.
	/// </summary>
	public static string GetStringFromEventId(uint arg0)
	{
		return Marshal.PtrToStringAnsi(vtkWidgetEvent_GetStringFromEventId_04(arg0));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEvent_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWidgetEvent_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetEvent_IsTypeOf_06(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWidgetEvent_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetEvent_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new vtkWidgetEvent NewInstance()
	{
		vtkWidgetEvent result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetEvent_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetEvent_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static vtkWidgetEvent SafeDownCast(vtkObjectBase o)
	{
		vtkWidgetEvent vtkWidgetEvent2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetEvent_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWidgetEvent2 = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWidgetEvent2.Register(null);
			}
		}
		return vtkWidgetEvent2;
	}
}
