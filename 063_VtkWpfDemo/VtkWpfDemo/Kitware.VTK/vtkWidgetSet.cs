using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWidgetSet
/// </summary>
/// <remarks>
///    Synchronize a collection on vtkWidgets drawn on different renderwindows using the
/// Callback - Dispatch Action mechanism.
///
///
/// The class synchronizes a set of vtkAbstractWidget(s). Widgets typically
/// invoke "Actions" that drive the geometry/behaviour of their representations
/// in response to interactor events. Interactor interactions on a render window
/// are mapped into "Callbacks" by the widget, from which "Actions" are
/// dispatched to the entire set. This architecture allows us to tie widgets
/// existing in different render windows together. For instance a HandleWidget
/// might exist on the sagittal view. Moving it around should update the
/// representations of the corresponding handle widget that lies on the axial
/// and coronal and volume views as well.
///
/// @par User API:
/// A user would use this class as follows.
/// <code>
/// vtkWidgetSet *set = vtkWidgetSet::New();
/// vtkParallelopipedWidget *w1 = vtkParallelopipedWidget::New();
/// set-&gt;AddWidget(w1);
/// w1-&gt;SetInteractor(axialRenderWindow-&gt;GetInteractor());
/// vtkParallelopipedWidget *w2 = vtkParallelopipedWidget::New();
/// set-&gt;AddWidget(w2);
/// w2-&gt;SetInteractor(coronalRenderWindow-&gt;GetInteractor());
/// vtkParallelopipedWidget *w3 = vtkParallelopipedWidget::New();
/// set-&gt;AddWidget(w3);
/// w3-&gt;SetInteractor(sagittalRenderWindow-&gt;GetInteractor());
/// set-&gt;SetEnabled(1);
/// </code>
///
/// @par Motivation:
/// The motivation for this class is really to provide a usable API to tie
/// together multiple widgets of the same kind. To enable this, subclasses
/// of vtkAbstractWidget, must be written as follows:
///   They will generally have callback methods mapped to some user
/// interaction such as:
/// <code>
/// this-&gt;CallbackMapper-&gt;SetCallbackMethod(vtkCommand::LeftButtonPressEvent,
///                         vtkEvent::NoModifier, 0, 0, nullptr,
///                         vtkPaintbrushWidget::BeginDrawStrokeEvent,
///                         this, vtkPaintbrushWidget::BeginDrawCallback);
/// </code>
///   The callback invoked when the left button is pressed looks like:
/// <code>
/// void vtkPaintbrushWidget::BeginDrawCallback(vtkAbstractWidget *w)
/// {
///   vtkPaintbrushWidget *self = vtkPaintbrushWidget::SafeDownCast(w);
///   self-&gt;WidgetSet-&gt;DispatchAction(self, &amp;vtkPaintbrushWidget::BeginDrawAction);
/// }
/// </code>
///   The actual code for handling the drawing is written in the BeginDrawAction
/// method.
/// <code>
/// void vtkPaintbrushWidget::BeginDrawAction( vtkPaintbrushWidget *dispatcher)
/// {
/// // Do stuff to draw...
/// // Here dispatcher is the widget that was interacted with, the one that
/// // dispatched an action to all the other widgets in its group. You may, if
/// // necessary find it helpful to get parameters from it.
/// //   For instance for a ResizeAction:
/// //     if (this != dispatcher)
/// //       {
/// //       double *newsize = dispatcher-&gt;GetRepresentation()-&gt;GetSize();
/// //       this-&gt;WidgetRep-&gt;SetSize(newsize);
/// //       }
/// //     else
/// //       {
/// //       this-&gt;WidgetRep-&gt;IncrementSizeByDelta();
/// //       }
/// }
/// </code>
///
/// @warning
/// Actions are always dispatched first to the activeWidget, the one calling
/// the set, and then to the other widgets in the set.
///
/// </remarks>
public class vtkWidgetSet : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWidgetSet()
	{
		MRClassNameKey = "class vtkWidgetSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWidgetSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkWidgetSet New()
	{
		vtkWidgetSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkWidgetSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWidgetSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkWidgetSet_AddWidget_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Add a widget to the set.
	/// </summary>
	public void AddWidget(vtkAbstractWidget arg0)
	{
		vtkWidgetSet_AddWidget_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetSet_EnabledOff_02(HandleRef pThis);

	/// <summary>
	/// Method for activating and deactivating all widgets in the group.
	/// </summary>
	public virtual void EnabledOff()
	{
		vtkWidgetSet_EnabledOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetSet_EnabledOn_03(HandleRef pThis);

	/// <summary>
	/// Method for activating and deactivating all widgets in the group.
	/// </summary>
	public virtual void EnabledOn()
	{
		vtkWidgetSet_EnabledOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetSet_GetNthWidget_04(HandleRef pThis, uint arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the Nth widget in the set.
	/// </summary>
	public vtkAbstractWidget GetNthWidget(uint arg0)
	{
		vtkAbstractWidget vtkAbstractWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetSet_GetNthWidget_04(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractWidget2 = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractWidget2.Register(null);
			}
		}
		return vtkAbstractWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetSet_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWidgetSet_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWidgetSet_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWidgetSet_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkWidgetSet_GetNumberOfWidgets_07(HandleRef pThis);

	/// <summary>
	/// Get number of widgets in the set.
	/// </summary>
	public uint GetNumberOfWidgets()
	{
		return vtkWidgetSet_GetNumberOfWidgets_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetSet_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWidgetSet_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWidgetSet_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWidgetSet_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetSet_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkWidgetSet NewInstance()
	{
		vtkWidgetSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetSet_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetSet_RemoveWidget_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove a widget from the set
	/// </summary>
	public void RemoveWidget(vtkAbstractWidget arg0)
	{
		vtkWidgetSet_RemoveWidget_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWidgetSet_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkWidgetSet SafeDownCast(vtkObjectBase o)
	{
		vtkWidgetSet vtkWidgetSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWidgetSet_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWidgetSet2 = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWidgetSet2.Register(null);
			}
		}
		return vtkWidgetSet2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWidgetSet_SetEnabled_14(HandleRef pThis, int arg0);

	/// <summary>
	/// Method for activating and deactivating all widgets in the group.
	/// </summary>
	public virtual void SetEnabled(int arg0)
	{
		vtkWidgetSet_SetEnabled_14(GetCppThis(), arg0);
	}
}
