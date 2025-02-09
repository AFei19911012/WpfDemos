using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWin32RenderWindowInteractor
/// </summary>
/// <remarks>
///    implements Win32 specific functions
/// required by vtkRenderWindowInteractor.
///
///
/// By default the interactor installs a MessageProc callback which
/// intercepts windows' messages to the window and controls interactions by
/// routing them to the InteractoStyle classes.
/// MFC or BCB programs can prevent this and instead directly route any mouse/key
/// messages into the event bindings by setting InstallMessageProc to false.
/// This provides a minimal "Mapped" mode of interaction
///
/// </remarks>
public class vtkWin32RenderWindowInteractor : vtkRenderWindowInteractor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWin32RenderWindowInteractor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWin32RenderWindowInteractor()
	{
		MRClassNameKey = "class vtkWin32RenderWindowInteractor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32RenderWindowInteractor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWin32RenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32RenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new static vtkWin32RenderWindowInteractor New()
	{
		vtkWin32RenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32RenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public vtkWin32RenderWindowInteractor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWin32RenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_Disable_01(HandleRef pThis);

	/// <summary>
	/// Enable/Disable interactions.  By default interactors are enabled when
	/// initialized.  Initialize() must be called prior to enabling/disabling
	/// interaction. These methods are used when a window/widget is being
	/// shared by multiple renderers and interactors.  This allows a "modal"
	/// display where one interactor is active when its data is to be displayed
	/// and all other interactors associated with the widget are disabled
	/// when their data is not displayed.
	/// </summary>
	public override void Disable()
	{
		vtkWin32RenderWindowInteractor_Disable_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_Enable_02(HandleRef pThis);

	/// <summary>
	/// Enable/Disable interactions.  By default interactors are enabled when
	/// initialized.  Initialize() must be called prior to enabling/disabling
	/// interaction. These methods are used when a window/widget is being
	/// shared by multiple renderers and interactors.  This allows a "modal"
	/// display where one interactor is active when its data is to be displayed
	/// and all other interactors associated with the widget are disabled
	/// when their data is not displayed.
	/// </summary>
	public override void Enable()
	{
		vtkWin32RenderWindowInteractor_Enable_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_ExitCallback_03(HandleRef pThis);

	/// <summary>
	/// These methods correspond to the Exit, User and Pick
	/// callbacks. They allow for the Style to invoke them.
	/// </summary>
	public override void ExitCallback()
	{
		vtkWin32RenderWindowInteractor_ExitCallback_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32RenderWindowInteractor_GetInstallMessageProc_04(HandleRef pThis);

	/// <summary>
	/// By default the interactor installs a MessageProc callback which
	/// intercepts windows messages to the window and controls interactions.
	/// MFC or BCB programs can prevent this and instead directly route any mouse/key
	/// messages into the event bindings by setting InstallMessgeProc to false.
	/// </summary>
	public virtual int GetInstallMessageProc()
	{
		return vtkWin32RenderWindowInteractor_GetInstallMessageProc_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWin32RenderWindowInteractor_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWin32RenderWindowInteractor_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWin32RenderWindowInteractor_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWin32RenderWindowInteractor_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_Initialize_07(HandleRef pThis);

	/// <summary>
	/// Initialize the event handler
	/// </summary>
	public override void Initialize()
	{
		vtkWin32RenderWindowInteractor_Initialize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_InstallMessageProcOff_08(HandleRef pThis);

	/// <summary>
	/// By default the interactor installs a MessageProc callback which
	/// intercepts windows messages to the window and controls interactions.
	/// MFC or BCB programs can prevent this and instead directly route any mouse/key
	/// messages into the event bindings by setting InstallMessgeProc to false.
	/// </summary>
	public virtual void InstallMessageProcOff()
	{
		vtkWin32RenderWindowInteractor_InstallMessageProcOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_InstallMessageProcOn_09(HandleRef pThis);

	/// <summary>
	/// By default the interactor installs a MessageProc callback which
	/// intercepts windows messages to the window and controls interactions.
	/// MFC or BCB programs can prevent this and instead directly route any mouse/key
	/// messages into the event bindings by setting InstallMessgeProc to false.
	/// </summary>
	public virtual void InstallMessageProcOn()
	{
		vtkWin32RenderWindowInteractor_InstallMessageProcOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32RenderWindowInteractor_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWin32RenderWindowInteractor_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32RenderWindowInteractor_IsTypeOf_11(string type);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWin32RenderWindowInteractor_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32RenderWindowInteractor_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new vtkWin32RenderWindowInteractor NewInstance()
	{
		vtkWin32RenderWindowInteractor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32RenderWindowInteractor_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_ProcessEvents_14(HandleRef pThis);

	/// <summary>
	/// Run the event loop and return. This is provided so that you can
	/// implement your own event loop but yet use the vtk event handling as
	/// well.
	/// </summary>
	public override void ProcessEvents()
	{
		vtkWin32RenderWindowInteractor_ProcessEvents_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32RenderWindowInteractor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object so that light follows camera motion.
	/// </summary>
	public new static vtkWin32RenderWindowInteractor SafeDownCast(vtkObjectBase o)
	{
		vtkWin32RenderWindowInteractor vtkWin32RenderWindowInteractor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32RenderWindowInteractor_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWin32RenderWindowInteractor2 = (vtkWin32RenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWin32RenderWindowInteractor2.Register(null);
			}
		}
		return vtkWin32RenderWindowInteractor2;
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_SetInstallMessageProc_16(HandleRef pThis, int _arg);

	/// <summary>
	/// By default the interactor installs a MessageProc callback which
	/// intercepts windows messages to the window and controls interactions.
	/// MFC or BCB programs can prevent this and instead directly route any mouse/key
	/// messages into the event bindings by setting InstallMessgeProc to false.
	/// </summary>
	public virtual void SetInstallMessageProc(int _arg)
	{
		vtkWin32RenderWindowInteractor_SetInstallMessageProc_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32RenderWindowInteractor_TerminateApp_17(HandleRef pThis);

	/// <summary>
	/// Win32 specific application terminate, calls ClassExitMethod then
	/// calls PostQuitMessage(0) to terminate the application. An application can Specify
	/// ExitMethod for alternative behavior (i.e. suppression of keyboard exit)
	/// </summary>
	public override void TerminateApp()
	{
		vtkWin32RenderWindowInteractor_TerminateApp_17(GetCppThis());
	}
}
