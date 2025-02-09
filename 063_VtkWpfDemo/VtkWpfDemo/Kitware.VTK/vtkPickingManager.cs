using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPickingManager
/// Class defines API to manage the picking process.
///
/// The Picking Manager (PM) coordinates picking across widgets simultaneously.
/// It maintains a collection of registered pickers;
/// when the manager is picked (e.g. vtkPickingManager::Pick()),
/// a pick is run on each picker but only the best picker
/// (e.g. closest to camera point) is selected.
/// It finally returns the widget/representation or picker that was
/// selected.
/// @warning
/// Every time a vtkWidget and/or a vtkWidgetRepresentation is instantiated,
/// it automatically registers its picker(s) and start being managed by
/// delegating all its pick calls to the picking manager.
/// It is possible to customize with the management in two ways:
/// * at the widget level, the "ManagesPicking" variable can be changed
/// from the widget/representation class to tell
/// whether to use the manager or not.
/// * Directly disable the picking manager itself with the boolean variable
/// \sa Enabled using vtkPickingManager::EnabledOn(), EnabledOff(),
/// SetEnabled(bool).
/// @par Important:
/// The picking manager is not active by default as it slightly reduces the
/// performances when interacting with the scene.
/// @par Important:
/// When registering pickers, a null object is considered valid because we can
/// managed picker without any associated object.
/// It is really important to note that a null object is different from one
/// to an other !!
/// This has been done to allow adding multiple times the same picker to the manager
/// by not passing the referenced object to not force the suppression of all pickers
/// </summary>
public class vtkPickingManager : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPickingManager";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPickingManager()
	{
		MRClassNameKey = "class vtkPickingManager";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPickingManager"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPickingManager(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPickingManager_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPickingManager New()
	{
		vtkPickingManager result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPickingManager_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPickingManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPickingManager()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPickingManager_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPickingManager_AddPicker_01(HandleRef pThis, HandleRef picker, HandleRef arg1);

	/// <summary>
	/// Register a picker into the picking manager.
	/// It can be internally associated (optional) with an \a object.
	/// This allows the removal of all the pickers of the given object.
	/// Note that a picker can be registered multiple times with different objects.
	/// \sa RemovePicker(), RemoveObject().
	/// </summary>
	public void AddPicker(vtkAbstractPicker picker, vtkObject arg1)
	{
		vtkPickingManager_AddPicker_01(GetCppThis(), picker?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPickingManager_EnabledOff_02(HandleRef pThis);

	/// <summary>
	/// Enable/Disable management.
	/// When disabled, it redirects every pick on the picker.
	/// By default the picking manager is disabled when initialized.
	/// </summary>
	public virtual void EnabledOff()
	{
		vtkPickingManager_EnabledOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPickingManager_EnabledOn_03(HandleRef pThis);

	/// <summary>
	/// Enable/Disable management.
	/// When disabled, it redirects every pick on the picker.
	/// By default the picking manager is disabled when initialized.
	/// </summary>
	public virtual void EnabledOn()
	{
		vtkPickingManager_EnabledOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPickingManager_GetAssemblyPath_04(HandleRef pThis, double X, double Y, double Z, HandleRef picker, HandleRef renderer, HandleRef obj, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the picking manager is enabled, it runs the picking selection process
	/// and return the assembly path associated to the picker passed as
	/// argument if it is the one mediated.
	/// Otherwise it simply proceeds to a pick using the given renderer and
	/// returns the corresponding assembly path.
	/// </summary>
	public vtkAssemblyPath GetAssemblyPath(double X, double Y, double Z, vtkAbstractPropPicker picker, vtkRenderer renderer, vtkObject obj)
	{
		vtkAssemblyPath vtkAssemblyPath2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPickingManager_GetAssemblyPath_04(GetCppThis(), X, Y, Z, picker?.GetCppThis() ?? default(HandleRef), renderer?.GetCppThis() ?? default(HandleRef), obj?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAssemblyPath2 = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAssemblyPath2.Register(null);
			}
		}
		return vtkAssemblyPath2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPickingManager_GetEnabled_05(HandleRef pThis);

	/// <summary>
	/// Enable/Disable management.
	/// When disabled, it redirects every pick on the picker.
	/// By default the picking manager is disabled when initialized.
	/// </summary>
	public virtual bool GetEnabled()
	{
		return (vtkPickingManager_GetEnabled_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPickingManager_GetInteractor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the window interactor associated with the manager.
	/// </summary>
	public virtual vtkRenderWindowInteractor GetInteractor()
	{
		vtkRenderWindowInteractor vtkRenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPickingManager_GetInteractor_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindowInteractor2 = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindowInteractor2.Register(null);
			}
		}
		return vtkRenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPickingManager_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPickingManager_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPickingManager_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPickingManager_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPickingManager_GetNumberOfObjectsLinked_09(HandleRef pThis, HandleRef picker);

	/// <summary>
	/// Return the number of objects linked with a given \a picker.
	/// Note: a null object is counted as an associated object.
	/// </summary>
	public int GetNumberOfObjectsLinked(vtkAbstractPicker picker)
	{
		return vtkPickingManager_GetNumberOfObjectsLinked_09(GetCppThis(), picker?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPickingManager_GetNumberOfPickers_10(HandleRef pThis);

	/// <summary>
	/// Return the number of pickers registered.
	/// If the same picker is added multiple times with different objects, it is
	/// counted once.
	/// </summary>
	public int GetNumberOfPickers()
	{
		return vtkPickingManager_GetNumberOfPickers_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPickingManager_GetOptimizeOnInteractorEvents_11(HandleRef pThis);

	/// <summary>
	/// Enable/Disable optimization depending on the renderWindowInteractor events.
	/// The mechanism keeps in cache the last selected picker as well as the last
	/// render time to recompute the selection only if a new render event
	/// occurred after the last selection; otherwise, it simply returns the last
	/// picker selected.
	/// By default pickingManagers does use the optimization.
	/// Warning: Turning off the caching significantly decreases performance.
	/// </summary>
	public virtual bool GetOptimizeOnInteractorEvents()
	{
		return (vtkPickingManager_GetOptimizeOnInteractorEvents_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPickingManager_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPickingManager_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPickingManager_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPickingManager_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPickingManager_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPickingManager NewInstance()
	{
		vtkPickingManager result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPickingManager_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPickingManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPickingManager_Pick_16(HandleRef pThis, HandleRef picker, HandleRef arg1);

	/// <summary>
	/// Run the picking selection process and return true if the \a object
	/// is associated with the given picker if it is the best one, false otherwise.
	/// If OptimizeOnInteractorEvents is true, the pick can reuse cached
	/// information.
	/// </summary>
	public bool Pick(vtkAbstractPicker picker, vtkObject arg1)
	{
		return (vtkPickingManager_Pick_16(GetCppThis(), picker?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPickingManager_Pick_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Run the picking selection process and return true if the \a object
	/// is associated with the best picker.
	/// This is an overloaded function.
	/// </summary>
	public bool Pick(vtkObject arg0)
	{
		return (vtkPickingManager_Pick_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPickingManager_Pick_18(HandleRef pThis, HandleRef picker);

	/// <summary>
	/// Run the picking selection process and return if \a picker is the one
	/// selected.
	/// This is an overloaded function.
	/// </summary>
	public bool Pick(vtkAbstractPicker picker)
	{
		return (vtkPickingManager_Pick_18(GetCppThis(), picker?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPickingManager_RemoveObject_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove all occurrence of the \a object from the registered list.
	/// If a picker associated with the \a object is not also associated with
	/// any other object, it is removed from the list as well.
	/// </summary>
	public void RemoveObject(vtkObject arg0)
	{
		vtkPickingManager_RemoveObject_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPickingManager_RemovePicker_20(HandleRef pThis, HandleRef picker, HandleRef arg1);

	/// <summary>
	/// Unregister the \a picker from the picking manager.
	/// If \a object is non null, only the pair (\a picker, \a object) is removed.
	/// </summary>
	public void RemovePicker(vtkAbstractPicker picker, vtkObject arg1)
	{
		vtkPickingManager_RemovePicker_20(GetCppThis(), picker?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPickingManager_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPickingManager SafeDownCast(vtkObjectBase o)
	{
		vtkPickingManager vtkPickingManager2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPickingManager_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPickingManager2 = (vtkPickingManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPickingManager2.Register(null);
			}
		}
		return vtkPickingManager2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPickingManager_SetEnabled_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/Disable management.
	/// When disabled, it redirects every pick on the picker.
	/// By default the picking manager is disabled when initialized.
	/// </summary>
	public virtual void SetEnabled(bool _arg)
	{
		vtkPickingManager_SetEnabled_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPickingManager_SetInteractor_23(HandleRef pThis, HandleRef iren);

	/// <summary>
	/// Set the window interactor associated with the manager.
	/// </summary>
	public void SetInteractor(vtkRenderWindowInteractor iren)
	{
		vtkPickingManager_SetInteractor_23(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPickingManager_SetOptimizeOnInteractorEvents_24(HandleRef pThis, byte optimize);

	/// <summary>
	/// Enable/Disable optimization depending on the renderWindowInteractor events.
	/// The mechanism keeps in cache the last selected picker as well as the last
	/// render time to recompute the selection only if a new render event
	/// occurred after the last selection; otherwise, it simply returns the last
	/// picker selected.
	/// By default pickingManagers does use the optimization.
	/// Warning: Turning off the caching significantly decreases performance.
	/// </summary>
	public void SetOptimizeOnInteractorEvents(bool optimize)
	{
		vtkPickingManager_SetOptimizeOnInteractorEvents_24(GetCppThis(), (byte)(optimize ? 1u : 0u));
	}
}
