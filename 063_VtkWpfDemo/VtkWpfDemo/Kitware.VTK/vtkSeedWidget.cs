using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSeedWidget
/// </summary>
/// <remarks>
///    place multiple seed points
///
/// The vtkSeedWidget is used to placed multiple seed points in the scene.
/// The seed points can be used for operations like connectivity, segmentation,
/// and region growing.
///
/// To use this widget, specify an instance of vtkSeedWidget and a
/// representation (a subclass of vtkSeedRepresentation). The widget is
/// implemented using multiple instances of vtkHandleWidget which can be used
/// to position the seed points (after they are initially placed). The
/// representations for these handle widgets are provided by the
/// vtkSeedRepresentation.
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
///   LeftButtonPressEvent - add a point or select a handle (i.e., seed)
///   RightButtonPressEvent - finish adding the seeds
///   MouseMoveEvent - move a handle (i.e., seed)
///   LeftButtonReleaseEvent - release the selected handle (seed)
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator. This class translates VTK events
/// into the vtkSeedWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::AddPoint -- add one point; depending on the state
///                               it may the first or second point added. Or,
///                               if near handle, select handle.
///   vtkWidgetEvent::Completed -- finished adding seeds.
///   vtkWidgetEvent::Move -- move the second point or handle depending on the state.
///   vtkWidgetEvent::EndSelect -- the handle manipulation process has completed.
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// This widget invokes the following VTK events on itself (which observers
/// can listen for):
/// &lt;pre&gt;
///   vtkCommand::StartInteractionEvent (beginning to interact)
///   vtkCommand::EndInteractionEvent (completing interaction)
///   vtkCommand::InteractionEvent (moving after selecting something)
///   vtkCommand::PlacePointEvent (after point is positioned;
///                                call data includes handle id (0,1))
///   vtkCommand::DeletePointEvent (before point is deleted;
///                                call data includes handle id (0,1))
/// &lt;/pre&gt;
///
/// </remarks>
/// <seealso>
///
/// vtkHandleWidget vtkSeedRepresentation
/// </seealso>
public class vtkSeedWidget : vtkAbstractWidget
{
	/// <summary>
	/// Get the widget state.
	/// </summary>
	public enum MovingSeed_WrapperEnum
	{
		/// <summary>enum member</summary>
		MovingSeed = 8,
		/// <summary>enum member</summary>
		PlacedSeeds = 4,
		/// <summary>enum member</summary>
		PlacingSeeds = 2,
		/// <summary>enum member</summary>
		Start = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSeedWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSeedWidget()
	{
		MRClassNameKey = "class vtkSeedWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSeedWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSeedWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkSeedWidget New()
	{
		vtkSeedWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkSeedWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSeedWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSeedWidget_CompleteInteraction_01(HandleRef pThis);

	/// <summary>
	/// Method to be called when the seed widget should stop responding to
	/// the place point interaction. The seed widget, when defined allows you
	/// place seeds by clicking on the render window. Use this method to
	/// indicate that you would like to stop placing seeds interactively. If
	/// you'd like the widget to stop responding to *any* user interaction
	/// simply disable event processing by the widget by calling
	/// widget-&gt;ProcessEventsOff()
	/// </summary>
	public virtual void CompleteInteraction()
	{
		vtkSeedWidget_CompleteInteraction_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedWidget_CreateDefaultRepresentation_02(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkSeedWidget_CreateDefaultRepresentation_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedWidget_CreateNewHandle_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Use this method to programmatically create a new handle. In interactive
	/// mode, (when the widget is in the PlacingSeeds state) this method is
	/// automatically invoked. The method returns the handle created.
	/// A valid seed representation must exist for the widget to create a new
	/// handle.
	/// </summary>
	public virtual vtkHandleWidget CreateNewHandle()
	{
		vtkHandleWidget vtkHandleWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedWidget_CreateNewHandle_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleWidget2 = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleWidget2.Register(null);
			}
		}
		return vtkHandleWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedWidget_DeleteSeed_04(HandleRef pThis, int n);

	/// <summary>
	/// Delete the nth seed.
	/// </summary>
	public void DeleteSeed(int n)
	{
		vtkSeedWidget_DeleteSeed_04(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSeedWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSeedWidget_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSeedWidget_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSeedWidget_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedWidget_GetSeed_07(HandleRef pThis, int n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the nth seed
	/// </summary>
	public vtkHandleWidget GetSeed(int n)
	{
		vtkHandleWidget vtkHandleWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedWidget_GetSeed_07(GetCppThis(), n, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleWidget2 = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleWidget2.Register(null);
			}
		}
		return vtkHandleWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedWidget_GetSeedRepresentation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkSeedRepresentation.
	/// </summary>
	public vtkSeedRepresentation GetSeedRepresentation()
	{
		vtkSeedRepresentation vtkSeedRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedWidget_GetSeedRepresentation_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSeedRepresentation2 = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSeedRepresentation2.Register(null);
			}
		}
		return vtkSeedRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedWidget_GetWidgetState_09(HandleRef pThis);

	/// <summary>
	/// Get the widget state.
	/// </summary>
	public virtual int GetWidgetState()
	{
		return vtkSeedWidget_GetWidgetState_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedWidget_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSeedWidget_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSeedWidget_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSeedWidget_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkSeedWidget NewInstance()
	{
		vtkSeedWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedWidget_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedWidget_RestartInteraction_14(HandleRef pThis);

	/// <summary>
	/// Method to be called when the seed widget should start responding
	/// to the interaction.
	/// </summary>
	public virtual void RestartInteraction()
	{
		vtkSeedWidget_RestartInteraction_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSeedWidget_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkSeedWidget SafeDownCast(vtkObjectBase o)
	{
		vtkSeedWidget vtkSeedWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSeedWidget_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSeedWidget2 = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSeedWidget2.Register(null);
			}
		}
		return vtkSeedWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedWidget_SetCurrentRenderer_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the current renderer. This method also propagates to all the child
	/// handle widgets, if any exist
	/// </summary>
	public override void SetCurrentRenderer(vtkRenderer arg0)
	{
		vtkSeedWidget_SetCurrentRenderer_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedWidget_SetEnabled_17(HandleRef pThis, int arg0);

	/// <summary>
	/// The method for activating and deactivating this widget. This method
	/// must be overridden because it is a composite widget and does more than
	/// its superclasses' vtkAbstractWidget::SetEnabled() method.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkSeedWidget_SetEnabled_17(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedWidget_SetInteractor_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the interactor. This method also propagates to all the child
	/// handle widgets, if any exist
	/// </summary>
	public override void SetInteractor(vtkRenderWindowInteractor arg0)
	{
		vtkSeedWidget_SetInteractor_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedWidget_SetProcessEvents_19(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods to change the whether the widget responds to interaction.
	/// Overridden to pass the state to component widgets.
	/// </summary>
	public override void SetProcessEvents(int arg0)
	{
		vtkSeedWidget_SetProcessEvents_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSeedWidget_SetRepresentation_20(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkSeedRepresentation rep)
	{
		vtkSeedWidget_SetRepresentation_20(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}
}
