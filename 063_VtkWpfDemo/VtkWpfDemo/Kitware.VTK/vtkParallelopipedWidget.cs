using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelopipedWidget
/// </summary>
/// <remarks>
///    a widget to manipulate 3D parallelopipeds
///
///
/// This widget was designed with the aim of visualizing / probing cuts on
/// a skewed image data / structured grid.
///
/// @par Interaction:
/// The widget allows you to create a parallelopiped (defined by 8 handles).
/// The widget is initially placed by using the "PlaceWidget" method in the
/// representation class. After the widget has been created, the following
/// interactions may be used to manipulate it :
/// 1) Click on a handle and drag it around moves the handle in space, while
///    keeping the same axis alignment of the parallelopiped
/// 2) Dragging a handle with the shift button pressed resizes the piped
///    along an axis.
/// 3) Control-click on a handle creates a chair at that position. (A chair
///    is a depression in the piped that allows you to visualize cuts in the
///    volume).
/// 4) Clicking on a chair and dragging it around moves the chair within the
///    piped.
/// 5) Shift-click on the piped enables you to translate it.
///
/// </remarks>
public class vtkParallelopipedWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelopipedWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelopipedWidget()
	{
		MRClassNameKey = "class vtkParallelopipedWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelopipedWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelopipedWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkParallelopipedWidget New()
	{
		vtkParallelopipedWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkParallelopipedWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParallelopipedWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParallelopipedWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkParallelopipedWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedWidget_EnableChairCreationOff_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable the creation of a chair on this widget. If off,
	/// chairs cannot be created.
	/// </summary>
	public virtual void EnableChairCreationOff()
	{
		vtkParallelopipedWidget_EnableChairCreationOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedWidget_EnableChairCreationOn_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable the creation of a chair on this widget. If off,
	/// chairs cannot be created.
	/// </summary>
	public virtual void EnableChairCreationOn()
	{
		vtkParallelopipedWidget_EnableChairCreationOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelopipedWidget_GetEnableChairCreation_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable the creation of a chair on this widget. If off,
	/// chairs cannot be created.
	/// </summary>
	public virtual int GetEnableChairCreation()
	{
		return vtkParallelopipedWidget_GetEnableChairCreation_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelopipedWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelopipedWidget_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelopipedWidget_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelopipedWidget_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedWidget_GetParallelopipedRepresentation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkParallelopipedRepresentation.
	/// </summary>
	public vtkParallelopipedRepresentation GetParallelopipedRepresentation()
	{
		vtkParallelopipedRepresentation vtkParallelopipedRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedWidget_GetParallelopipedRepresentation_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelopipedRepresentation2 = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelopipedRepresentation2.Register(null);
			}
		}
		return vtkParallelopipedRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelopipedWidget_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelopipedWidget_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelopipedWidget_IsTypeOf_09(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelopipedWidget_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkParallelopipedWidget NewInstance()
	{
		vtkParallelopipedWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedWidget_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedWidget_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkParallelopipedWidget SafeDownCast(vtkObjectBase o)
	{
		vtkParallelopipedWidget vtkParallelopipedWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedWidget_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelopipedWidget2 = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelopipedWidget2.Register(null);
			}
		}
		return vtkParallelopipedWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedWidget_SetEnableChairCreation_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the creation of a chair on this widget. If off,
	/// chairs cannot be created.
	/// </summary>
	public virtual void SetEnableChairCreation(int _arg)
	{
		vtkParallelopipedWidget_SetEnableChairCreation_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedWidget_SetEnabled_14(HandleRef pThis, int arg0);

	/// <summary>
	/// Override the superclass method. This is a composite widget, (it internally
	/// consists of handle widgets). We will override the superclass method, so
	/// that we can pass the enabled state to the internal widgets as well.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkParallelopipedWidget_SetEnabled_14(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedWidget_SetProcessEvents_15(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to change the whether the widget responds to interaction.
	/// Overridden to pass the state to component widgets.
	/// </summary>
	public override void SetProcessEvents(int arg0)
	{
		vtkParallelopipedWidget_SetProcessEvents_15(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedWidget_SetRepresentation_16(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkParallelopipedRepresentation r)
	{
		vtkParallelopipedWidget_SetRepresentation_16(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}
}
