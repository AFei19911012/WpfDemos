using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVRMenuWidget
/// </summary>
/// <remarks>
///    3D widget to display a menu in VR
///
/// </remarks>
/// <seealso>
///
/// vtkVRMenuRepresentation
/// </seealso>
public class vtkVRMenuWidget : vtkAbstractWidget
{
	/// <summary>
	/// Get the widget state.
	/// </summary>
	public enum WidgetStateType
	{
		/// <summary>enum member</summary>
		Active = 1,
		/// <summary>enum member</summary>
		Start = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVRMenuWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVRMenuWidget()
	{
		MRClassNameKey = "class vtkVRMenuWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRMenuWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVRMenuWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRMenuWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkVRMenuWidget New()
	{
		vtkVRMenuWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRMenuWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRMenuWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkVRMenuWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVRMenuWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMenuWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkVRMenuWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRMenuWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVRMenuWidget_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVRMenuWidget_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVRMenuWidget_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRMenuWidget_GetWidgetState_04(HandleRef pThis);

	/// <summary>
	/// Get the widget state.
	/// </summary>
	public virtual int GetWidgetState()
	{
		return vtkVRMenuWidget_GetWidgetState_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRMenuWidget_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVRMenuWidget_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVRMenuWidget_IsTypeOf_06(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVRMenuWidget_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRMenuWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new vtkVRMenuWidget NewInstance()
	{
		vtkVRMenuWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRMenuWidget_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVRMenuWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMenuWidget_PushFrontMenuItem_09(HandleRef pThis, string name, string text, HandleRef cmd);

	/// <summary>
	/// Methods to add/remove items to the menu, called by the menu widget
	/// </summary>
	public void PushFrontMenuItem(string name, string text, vtkCommand cmd)
	{
		vtkVRMenuWidget_PushFrontMenuItem_09(GetCppThis(), name, text, cmd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMenuWidget_RemoveAllMenuItems_10(HandleRef pThis);

	/// <summary>
	/// Methods to add/remove items to the menu, called by the menu widget
	/// </summary>
	public void RemoveAllMenuItems()
	{
		vtkVRMenuWidget_RemoveAllMenuItems_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMenuWidget_RemoveMenuItem_11(HandleRef pThis, string name);

	/// <summary>
	/// Methods to add/remove items to the menu, called by the menu widget
	/// </summary>
	public void RemoveMenuItem(string name)
	{
		vtkVRMenuWidget_RemoveMenuItem_11(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMenuWidget_RenameMenuItem_12(HandleRef pThis, string name, string text);

	/// <summary>
	/// Methods to add/remove items to the menu, called by the menu widget
	/// </summary>
	public void RenameMenuItem(string name, string text)
	{
		vtkVRMenuWidget_RenameMenuItem_12(GetCppThis(), name, text);
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVRMenuWidget_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static vtkVRMenuWidget SafeDownCast(vtkObjectBase o)
	{
		vtkVRMenuWidget vtkVRMenuWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVRMenuWidget_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVRMenuWidget2 = (vtkVRMenuWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVRMenuWidget2.Register(null);
			}
		}
		return vtkVRMenuWidget2;
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMenuWidget_SetRepresentation_14(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkVRMenuRepresentation rep)
	{
		vtkVRMenuWidget_SetRepresentation_14(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMenuWidget_Show_15(HandleRef pThis, HandleRef ed);

	/// <summary>
	/// Methods to add/remove items to the menu, called by the menu widget
	/// </summary>
	public void Show(vtkEventData ed)
	{
		vtkVRMenuWidget_Show_15(GetCppThis(), ed?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVRMenuWidget_ShowSubMenu_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to add/remove items to the menu, called by the menu widget
	/// </summary>
	public void ShowSubMenu(vtkVRMenuWidget arg0)
	{
		vtkVRMenuWidget_ShowSubMenu_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
