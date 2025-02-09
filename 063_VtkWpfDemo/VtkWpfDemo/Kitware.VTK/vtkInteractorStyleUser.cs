using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkInteractorStyleUser
/// </summary>
/// <remarks>
///    provides customizable interaction routines
///
///
/// The most common way to customize user interaction is to write a subclass
/// of vtkInteractorStyle: vtkInteractorStyleUser allows you to customize
/// the interaction to without subclassing vtkInteractorStyle.  This is
/// particularly useful for setting up custom interaction modes in
/// scripting languages such as Python.  This class allows you
/// to hook into the MouseMove, ButtonPress/Release, KeyPress/Release,
/// etc. events.  If you want to hook into just a single mouse button,
/// but leave the interaction modes for the others unchanged, you
/// must use e.g. SetMiddleButtonPressMethod() instead of the more
/// general SetButtonPressMethod().
/// </remarks>
public class vtkInteractorStyleUser : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleUser";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkInteractorStyleUser()
	{
		MRClassNameKey = "class vtkInteractorStyleUser";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleUser"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkInteractorStyleUser(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleUser New()
	{
		vtkInteractorStyleUser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleUser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkInteractorStyleUser()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkInteractorStyleUser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleUser_GetButton_01(HandleRef pThis);

	/// <summary>
	/// Get the mouse button that was last pressed inside the window
	/// (returns zero when the button is released).
	/// </summary>
	public virtual int GetButton()
	{
		return vtkInteractorStyleUser_GetButton_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleUser_GetChar_02(HandleRef pThis);

	/// <summary>
	/// Get the character for a Char event.
	/// </summary>
	public virtual int GetChar()
	{
		return vtkInteractorStyleUser_GetChar_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleUser_GetCtrlKey_03(HandleRef pThis);

	/// <summary>
	/// Test whether modifiers were held down when mouse button or key
	/// was pressed.
	/// </summary>
	public virtual int GetCtrlKey()
	{
		return vtkInteractorStyleUser_GetCtrlKey_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUser_GetKeySym_04(HandleRef pThis);

	/// <summary>
	/// Get the KeySym (in the same format as vtkRenderWindowInteractor KeySyms)
	/// for a KeyPress or KeyRelease method.
	/// </summary>
	public virtual string GetKeySym()
	{
		return Marshal.PtrToStringAnsi(vtkInteractorStyleUser_GetKeySym_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUser_GetLastPos_05(HandleRef pThis);

	/// <summary>
	/// Get the most recent mouse position during mouse motion.
	/// In your user interaction method, you must use this to track
	/// the mouse movement.  Do not use GetEventPosition(), which records
	/// the last position where a mouse button was pressed.
	/// </summary>
	public virtual int[] GetLastPos()
	{
		IntPtr intPtr = vtkInteractorStyleUser_GetLastPos_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_GetLastPos_06(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the most recent mouse position during mouse motion.
	/// In your user interaction method, you must use this to track
	/// the mouse movement.  Do not use GetEventPosition(), which records
	/// the last position where a mouse button was pressed.
	/// </summary>
	public virtual void GetLastPos(ref int _arg1, ref int _arg2)
	{
		vtkInteractorStyleUser_GetLastPos_06(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_GetLastPos_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the most recent mouse position during mouse motion.
	/// In your user interaction method, you must use this to track
	/// the mouse movement.  Do not use GetEventPosition(), which records
	/// the last position where a mouse button was pressed.
	/// </summary>
	public virtual void GetLastPos(IntPtr _arg)
	{
		vtkInteractorStyleUser_GetLastPos_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleUser_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkInteractorStyleUser_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkInteractorStyleUser_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkInteractorStyleUser_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUser_GetOldPos_10(HandleRef pThis);

	/// <summary>
	/// Get the previous mouse position during mouse motion, or after
	/// a key press.  This can be used to calculate the relative
	/// displacement of the mouse.
	/// </summary>
	public virtual int[] GetOldPos()
	{
		IntPtr intPtr = vtkInteractorStyleUser_GetOldPos_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_GetOldPos_11(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get the previous mouse position during mouse motion, or after
	/// a key press.  This can be used to calculate the relative
	/// displacement of the mouse.
	/// </summary>
	public virtual void GetOldPos(ref int _arg1, ref int _arg2)
	{
		vtkInteractorStyleUser_GetOldPos_11(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_GetOldPos_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the previous mouse position during mouse motion, or after
	/// a key press.  This can be used to calculate the relative
	/// displacement of the mouse.
	/// </summary>
	public virtual void GetOldPos(IntPtr _arg)
	{
		vtkInteractorStyleUser_GetOldPos_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleUser_GetShiftKey_13(HandleRef pThis);

	/// <summary>
	/// Test whether modifiers were held down when mouse button or key
	/// was pressed.
	/// </summary>
	public virtual int GetShiftKey()
	{
		return vtkInteractorStyleUser_GetShiftKey_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleUser_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkInteractorStyleUser_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkInteractorStyleUser_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkInteractorStyleUser_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUser_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkInteractorStyleUser NewInstance()
	{
		vtkInteractorStyleUser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleUser_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnChar_18(HandleRef pThis);

	/// <summary>
	/// Keyboard functions
	/// </summary>
	public override void OnChar()
	{
		vtkInteractorStyleUser_OnChar_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnConfigure_19(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public override void OnConfigure()
	{
		vtkInteractorStyleUser_OnConfigure_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnEnter_20(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public override void OnEnter()
	{
		vtkInteractorStyleUser_OnEnter_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnExpose_21(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public override void OnExpose()
	{
		vtkInteractorStyleUser_OnExpose_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnKeyPress_22(HandleRef pThis);

	/// <summary>
	/// Keyboard functions
	/// </summary>
	public override void OnKeyPress()
	{
		vtkInteractorStyleUser_OnKeyPress_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnKeyRelease_23(HandleRef pThis);

	/// <summary>
	/// Keyboard functions
	/// </summary>
	public override void OnKeyRelease()
	{
		vtkInteractorStyleUser_OnKeyRelease_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnLeave_24(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public override void OnLeave()
	{
		vtkInteractorStyleUser_OnLeave_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnLeftButtonDown_25(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkInteractorStyleUser_OnLeftButtonDown_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnLeftButtonUp_26(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkInteractorStyleUser_OnLeftButtonUp_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnMiddleButtonDown_27(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkInteractorStyleUser_OnMiddleButtonDown_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnMiddleButtonUp_28(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkInteractorStyleUser_OnMiddleButtonUp_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnMouseMove_29(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnMouseMove()
	{
		vtkInteractorStyleUser_OnMouseMove_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnMouseWheelBackward_30(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnMouseWheelBackward()
	{
		vtkInteractorStyleUser_OnMouseWheelBackward_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnMouseWheelForward_31(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnMouseWheelForward()
	{
		vtkInteractorStyleUser_OnMouseWheelForward_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnRightButtonDown_32(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkInteractorStyleUser_OnRightButtonDown_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnRightButtonUp_33(HandleRef pThis);

	/// <summary>
	/// Generic event bindings
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkInteractorStyleUser_OnRightButtonUp_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkInteractorStyleUser_OnTimer_34(HandleRef pThis);

	/// <summary>
	/// These are more esoteric events, but are useful in some cases.
	/// </summary>
	public override void OnTimer()
	{
		vtkInteractorStyleUser_OnTimer_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkInteractorStyleUser_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkInteractorStyleUser SafeDownCast(vtkObjectBase o)
	{
		vtkInteractorStyleUser vtkInteractorStyleUser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkInteractorStyleUser_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInteractorStyleUser2 = (vtkInteractorStyleUser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInteractorStyleUser2.Register(null);
			}
		}
		return vtkInteractorStyleUser2;
	}
}
