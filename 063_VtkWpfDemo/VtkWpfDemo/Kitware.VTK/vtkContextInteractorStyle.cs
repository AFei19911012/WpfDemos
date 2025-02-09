using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContextInteractorStyle
/// </summary>
/// <remarks>
///    An interactor for chart views.
///
///
/// It observes the user events (mouse events) and propagates them
/// to the scene. If the scene doesn't eat the event, it is propagated
/// to the interactor style superclass.
/// </remarks>
public class vtkContextInteractorStyle : vtkInteractorStyle
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContextInteractorStyle";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContextInteractorStyle()
	{
		MRClassNameKey = "class vtkContextInteractorStyle";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextInteractorStyle"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContextInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContextInteractorStyle New()
	{
		vtkContextInteractorStyle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkContextInteractorStyle()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContextInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextInteractorStyle_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContextInteractorStyle_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextInteractorStyle_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContextInteractorStyle_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextInteractorStyle_GetScene_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the observed scene.
	/// </summary>
	public vtkContextScene GetScene()
	{
		vtkContextScene vtkContextScene2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextInteractorStyle_GetScene_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContextScene2 = (vtkContextScene)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContextScene2.Register(null);
			}
		}
		return vtkContextScene2;
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextInteractorStyle_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContextInteractorStyle_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextInteractorStyle_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContextInteractorStyle_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextInteractorStyle_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContextInteractorStyle NewInstance()
	{
		vtkContextInteractorStyle result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextInteractorStyle_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnChar_08(HandleRef pThis);

	/// <summary>
	/// Handle key presses.
	/// </summary>
	public override void OnChar()
	{
		vtkContextInteractorStyle_OnChar_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnKeyPress_09(HandleRef pThis);

	/// <summary>
	/// Called when the user presses a key.
	/// </summary>
	public override void OnKeyPress()
	{
		vtkContextInteractorStyle_OnKeyPress_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnKeyRelease_10(HandleRef pThis);

	/// <summary>
	/// Called when the user releases a key.
	/// </summary>
	public override void OnKeyRelease()
	{
		vtkContextInteractorStyle_OnKeyRelease_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnLeftButtonDoubleClick_11(HandleRef pThis);

	/// <summary>
	/// Called when the user double-clicks the mouse left button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnLeftButtonDoubleClick()
	{
		vtkContextInteractorStyle_OnLeftButtonDoubleClick_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnLeftButtonDown_12(HandleRef pThis);

	/// <summary>
	/// Called when the user clicks the mouse left button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnLeftButtonDown()
	{
		vtkContextInteractorStyle_OnLeftButtonDown_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnLeftButtonUp_13(HandleRef pThis);

	/// <summary>
	/// Called when the user releases the mouse left button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnLeftButtonUp()
	{
		vtkContextInteractorStyle_OnLeftButtonUp_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnMiddleButtonDoubleClick_14(HandleRef pThis);

	/// <summary>
	/// Called when the user double-clicks the mouse middle button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnMiddleButtonDoubleClick()
	{
		vtkContextInteractorStyle_OnMiddleButtonDoubleClick_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnMiddleButtonDown_15(HandleRef pThis);

	/// <summary>
	/// Called when the user clicks the mouse middle button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnMiddleButtonDown()
	{
		vtkContextInteractorStyle_OnMiddleButtonDown_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnMiddleButtonUp_16(HandleRef pThis);

	/// <summary>
	/// Called when the user releases the mouse middle button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnMiddleButtonUp()
	{
		vtkContextInteractorStyle_OnMiddleButtonUp_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnMouseMove_17(HandleRef pThis);

	/// <summary>
	/// Called when the user moves the mouse
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnMouseMove()
	{
		vtkContextInteractorStyle_OnMouseMove_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnMouseWheelBackward_18(HandleRef pThis);

	/// <summary>
	/// Called when the user moves the mouse wheel backward.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnMouseWheelBackward()
	{
		vtkContextInteractorStyle_OnMouseWheelBackward_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnMouseWheelForward_19(HandleRef pThis);

	/// <summary>
	/// Called when the user moves the mouse wheel forward.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnMouseWheelForward()
	{
		vtkContextInteractorStyle_OnMouseWheelForward_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnRightButtonDoubleClick_20(HandleRef pThis);

	/// <summary>
	/// Called when the user double-clicks the mouse right button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnRightButtonDoubleClick()
	{
		vtkContextInteractorStyle_OnRightButtonDoubleClick_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnRightButtonDown_21(HandleRef pThis);

	/// <summary>
	/// Called when the user clicks the mouse right button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnRightButtonDown()
	{
		vtkContextInteractorStyle_OnRightButtonDown_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnRightButtonUp_22(HandleRef pThis);

	/// <summary>
	/// Called when the user releases the mouse right button.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public override void OnRightButtonUp()
	{
		vtkContextInteractorStyle_OnRightButtonUp_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnSceneModified_23(HandleRef pThis);

	/// <summary>
	/// Called when the scene is modified. Refresh the scene if needed.
	/// </summary>
	public virtual void OnSceneModified()
	{
		vtkContextInteractorStyle_OnSceneModified_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_OnSelection_24(HandleRef pThis, IntPtr rect);

	/// <summary>
	/// Place holder for future implementation.
	/// Default behavior forwards the event to the observed scene.
	/// </summary>
	public virtual void OnSelection(IntPtr rect)
	{
		vtkContextInteractorStyle_OnSelection_24(GetCppThis(), rect);
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextInteractorStyle_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContextInteractorStyle SafeDownCast(vtkObjectBase o)
	{
		vtkContextInteractorStyle vtkContextInteractorStyle2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextInteractorStyle_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContextInteractorStyle2 = (vtkContextInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContextInteractorStyle2.Register(null);
			}
		}
		return vtkContextInteractorStyle2;
	}

	[DllImport("Kitware.VTK.ViewsContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextInteractorStyle_SetScene_26(HandleRef pThis, HandleRef scene);

	/// <summary>
	/// Set the scene to forward user events to.
	/// Refresh the view when the scene is dirty and no event is being processed.
	/// The scene is observed (vtkCommand::ModifiedEvent) and a refresh on the
	/// view is called appropriately: scene is dirty and no event is being
	/// processed.
	/// </summary>
	public void SetScene(vtkContextScene scene)
	{
		vtkContextInteractorStyle_SetScene_26(GetCppThis(), scene?.GetCppThis() ?? default(HandleRef));
	}
}
