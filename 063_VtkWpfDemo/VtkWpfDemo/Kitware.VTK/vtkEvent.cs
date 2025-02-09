using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEvent
/// </summary>
/// <remarks>
///    a complete specification of a VTK event including all modifiers
///
/// vtkEvent is a class that fully describes a VTK event. It is used by the
/// widgets to help specify the mapping between VTK events and widget events.
/// </remarks>
public class vtkEvent : vtkObject
{
	/// <summary>
	/// Ways to specify modifiers to VTK events. These can be logical OR'd to
	/// produce combinations of modifiers.
	/// </summary>
	public enum EventModifiers
	{
		/// <summary>enum member</summary>
		AltModifier = 4,
		/// <summary>enum member</summary>
		AnyModifier = -1,
		/// <summary>enum member</summary>
		ControlModifier = 2,
		/// <summary>enum member</summary>
		NoModifier = 0,
		/// <summary>enum member</summary>
		ShiftModifier = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEvent";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEvent()
	{
		MRClassNameKey = "class vtkEvent";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEvent"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEvent(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The object factory constructor.
	/// </summary>
	public new static vtkEvent New()
	{
		vtkEvent result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEvent_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// The object factory constructor.
	/// </summary>
	public vtkEvent()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEvent_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkEvent_GetEventId_01(HandleRef pThis);

	/// <summary>
	/// Set the modifier for the event.
	/// </summary>
	public virtual uint GetEventId()
	{
		return vtkEvent_GetEventId_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkEvent_GetKeyCode_02(HandleRef pThis);

	/// <summary>
	/// Set the KeyCode for the event.
	/// </summary>
	public virtual sbyte GetKeyCode()
	{
		return vtkEvent_GetKeyCode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvent_GetKeySym_03(HandleRef pThis);

	/// <summary>
	/// Set the complex key symbol (compound key strokes) for the event.
	/// </summary>
	public virtual string GetKeySym()
	{
		return Marshal.PtrToStringAnsi(vtkEvent_GetKeySym_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEvent_GetModifier_04(HandleRef pThis);

	/// <summary>
	/// Set the modifier for the event.
	/// </summary>
	public virtual int GetModifier()
	{
		return vtkEvent_GetModifier_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEvent_GetModifier_05(HandleRef arg0);

	/// <summary>
	/// Convenience method computes the event modifier from an interactor.
	/// </summary>
	public static int GetModifier(vtkRenderWindowInteractor arg0)
	{
		return vtkEvent_GetModifier_05(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEvent_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEvent_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEvent_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEvent_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEvent_GetRepeatCount_08(HandleRef pThis);

	/// <summary>
	/// Set the repease count for the event.
	/// </summary>
	public virtual int GetRepeatCount()
	{
		return vtkEvent_GetRepeatCount_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEvent_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEvent_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEvent_IsTypeOf_10(string type);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEvent_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvent_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new vtkEvent NewInstance()
	{
		vtkEvent result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEvent_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEvent_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard macros.
	/// </summary>
	public new static vtkEvent SafeDownCast(vtkObjectBase o)
	{
		vtkEvent vtkEvent2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEvent_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEvent2 = (vtkEvent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEvent2.Register(null);
			}
		}
		return vtkEvent2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvent_SetEventId_14(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set the modifier for the event.
	/// </summary>
	public virtual void SetEventId(uint _arg)
	{
		vtkEvent_SetEventId_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvent_SetKeyCode_15(HandleRef pThis, sbyte _arg);

	/// <summary>
	/// Set the KeyCode for the event.
	/// </summary>
	public virtual void SetKeyCode(sbyte _arg)
	{
		vtkEvent_SetKeyCode_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvent_SetKeySym_16(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the complex key symbol (compound key strokes) for the event.
	/// </summary>
	public virtual void SetKeySym(string _arg)
	{
		vtkEvent_SetKeySym_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvent_SetModifier_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the modifier for the event.
	/// </summary>
	public virtual void SetModifier(int _arg)
	{
		vtkEvent_SetModifier_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEvent_SetRepeatCount_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the repease count for the event.
	/// </summary>
	public virtual void SetRepeatCount(int _arg)
	{
		vtkEvent_SetRepeatCount_18(GetCppThis(), _arg);
	}
}
