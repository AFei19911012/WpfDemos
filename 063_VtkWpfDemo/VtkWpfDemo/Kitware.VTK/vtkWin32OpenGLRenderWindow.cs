using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWin32OpenGL2RenderWindow
/// </summary>
/// <remarks>
///    OpenGL rendering window
///
/// vtkWin32OpenGL2RenderWindow is a concrete implementation of the abstract
/// class vtkRenderWindow. vtkWin32OpenGL2Renderer interfaces to the standard
/// OpenGL graphics library in the Windows/NT environment..
/// </remarks>
public class vtkWin32OpenGLRenderWindow : vtkOpenGLRenderWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWin32OpenGLRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWin32OpenGLRenderWindow()
	{
		MRClassNameKey = "class vtkWin32OpenGLRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32OpenGLRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWin32OpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWin32OpenGLRenderWindow New()
	{
		vtkWin32OpenGLRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32OpenGLRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkWin32OpenGLRenderWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWin32OpenGLRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_Clean_01(HandleRef pThis);

	/// <summary>
	/// Clean up device contexts, rendering contexts, etc.
	/// </summary>
	public void Clean()
	{
		vtkWin32OpenGLRenderWindow_Clean_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWin32OpenGLRenderWindow_DetectDPI_02(HandleRef pThis);

	/// <summary>
	/// Change the shape of the cursor
	/// </summary>
	public override bool DetectDPI()
	{
		return (vtkWin32OpenGLRenderWindow_DetectDPI_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_Finalize_03(HandleRef pThis);

	/// <summary>
	/// Finalize the rendering window.  This will shutdown all system-specific
	/// resources.  After having called this, it should be possible to destroy
	/// a window that was used for a SetWindowId() call without any ill effects.
	/// </summary>
	public override void FinalizeWrapper()
	{
		vtkWin32OpenGLRenderWindow_Finalize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_Frame_04(HandleRef pThis);

	/// <summary>
	/// End the rendering process and display the image.
	/// </summary>
	public override void Frame()
	{
		vtkWin32OpenGLRenderWindow_Frame_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32OpenGLRenderWindow_GetEventPending_05(HandleRef pThis);

	/// <summary>
	/// Check to see if a mouse button has been pressed or mouse wheel activated.
	/// All other events are ignored by this method.
	/// This is a useful check to abort a long render.
	/// </summary>
	public override int GetEventPending()
	{
		return vtkWin32OpenGLRenderWindow_GetEventPending_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericContext_06(HandleRef pThis);

	/// <summary>
	/// Sets the HWND id of the window that WILL BE created.
	/// </summary>
	public override IntPtr GetGenericContext()
	{
		return vtkWin32OpenGLRenderWindow_GetGenericContext_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericDisplayId_07(HandleRef pThis);

	/// <summary>
	/// Sets the HWND id of the window that WILL BE created.
	/// </summary>
	public override IntPtr GetGenericDisplayId()
	{
		return vtkWin32OpenGLRenderWindow_GetGenericDisplayId_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericDrawable_08(HandleRef pThis);

	/// <summary>
	/// Sets the HWND id of the window that WILL BE created.
	/// </summary>
	public override IntPtr GetGenericDrawable()
	{
		return vtkWin32OpenGLRenderWindow_GetGenericDrawable_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericParentId_09(HandleRef pThis);

	/// <summary>
	/// Sets the HWND id of the window that WILL BE created.
	/// </summary>
	public override IntPtr GetGenericParentId()
	{
		return vtkWin32OpenGLRenderWindow_GetGenericParentId_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetGenericWindowId_10(HandleRef pThis);

	/// <summary>
	/// Sets the HWND id of the window that WILL BE created.
	/// </summary>
	public override IntPtr GetGenericWindowId()
	{
		return vtkWin32OpenGLRenderWindow_GetGenericWindowId_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWin32OpenGLRenderWindow_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWin32OpenGLRenderWindow_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWin32OpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWin32OpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWin32OpenGLRenderWindow_GetPlatformSupportsRenderWindowSharing_13(HandleRef pThis);

	/// <summary>
	/// Does this platform support render window data sharing.
	/// </summary>
	public override bool GetPlatformSupportsRenderWindowSharing()
	{
		return (vtkWin32OpenGLRenderWindow_GetPlatformSupportsRenderWindowSharing_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetPosition_14(HandleRef pThis);

	/// <summary>
	/// Get the position (x and y) of the rendering window in
	/// screen coordinates (in pixels).
	/// </summary>
	public override int[] GetPosition()
	{
		IntPtr intPtr = vtkWin32OpenGLRenderWindow_GetPosition_14(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetScreenSize_15(HandleRef pThis);

	/// <summary>
	/// Get the current size of the screen in pixels.
	/// An HDTV for example would be 1920 x 1080 pixels.
	/// </summary>
	public override int[] GetScreenSize()
	{
		IntPtr intPtr = vtkWin32OpenGLRenderWindow_GetScreenSize_15(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_GetSize_16(HandleRef pThis);

	/// <summary>
	/// Get the size (width and height) of the rendering window in
	/// screen coordinates (in pixels).
	/// </summary>
	public override int[] GetSize()
	{
		IntPtr intPtr = vtkWin32OpenGLRenderWindow_GetSize_16(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_HideCursor_17(HandleRef pThis);

	/// <summary>
	/// Hide or Show the mouse cursor, it is nice to be able to hide the
	/// default cursor if you want VTK to display a 3D cursor instead.
	/// Set cursor position in window (note that (0,0) is the lower left
	/// corner).
	/// </summary>
	public override void HideCursor()
	{
		vtkWin32OpenGLRenderWindow_HideCursor_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_Initialize_18(HandleRef pThis);

	/// <summary>
	/// Initialize the rendering window.  This will setup all system-specific
	/// resources.  This method and Finalize() must be symmetric and it
	/// should be possible to call them multiple times, even changing WindowId
	/// in-between.  This is what WindowRemap does.
	/// </summary>
	public override void Initialize()
	{
		vtkWin32OpenGLRenderWindow_Initialize_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWin32OpenGLRenderWindow_InitializeFromCurrentContext_19(HandleRef pThis);

	/// <summary>
	/// Initialize the render window from the information associated
	/// with the currently activated OpenGL context.
	/// </summary>
	public override bool InitializeFromCurrentContext()
	{
		return (vtkWin32OpenGLRenderWindow_InitializeFromCurrentContext_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32OpenGLRenderWindow_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWin32OpenGLRenderWindow_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWin32OpenGLRenderWindow_IsCurrent_21(HandleRef pThis);

	/// <summary>
	/// Tells if this window is the current OpenGL context for the calling thread.
	/// </summary>
	public override bool IsCurrent()
	{
		return (vtkWin32OpenGLRenderWindow_IsCurrent_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32OpenGLRenderWindow_IsDirect_22(HandleRef pThis);

	/// <summary>
	/// Is this render window using hardware acceleration? 0-false, 1-true
	/// </summary>
	public override int IsDirect()
	{
		return vtkWin32OpenGLRenderWindow_IsDirect_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWin32OpenGLRenderWindow_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWin32OpenGLRenderWindow_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_MakeCurrent_24(HandleRef pThis);

	/// <summary>
	/// Make this windows OpenGL context the current context.
	/// </summary>
	public override void MakeCurrent()
	{
		vtkWin32OpenGLRenderWindow_MakeCurrent_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkWin32OpenGLRenderWindow NewInstance()
	{
		vtkWin32OpenGLRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32OpenGLRenderWindow_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_PopContext_27(HandleRef pThis);

	/// <summary>
	/// Ability to push and pop this window's context
	/// as the current context. The idea being to
	/// if needed make this window's context current
	/// and when done releasing resources restore
	/// the prior context
	/// </summary>
	public override void PopContext()
	{
		vtkWin32OpenGLRenderWindow_PopContext_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_PrefFullScreen_28(HandleRef pThis);

	/// <summary>
	/// Set the preferred window size to full screen.
	/// </summary>
	public virtual void PrefFullScreen()
	{
		vtkWin32OpenGLRenderWindow_PrefFullScreen_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_PushContext_29(HandleRef pThis);

	/// <summary>
	/// Ability to push and pop this window's context
	/// as the current context. The idea being to
	/// if needed make this window's context current
	/// and when done releasing resources restore
	/// the prior context
	/// </summary>
	public override void PushContext()
	{
		vtkWin32OpenGLRenderWindow_PushContext_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_ReleaseCurrent_30(HandleRef pThis);

	/// <summary>
	/// Release the current context.
	/// </summary>
	public override void ReleaseCurrent()
	{
		vtkWin32OpenGLRenderWindow_ReleaseCurrent_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_ReportCapabilities_31(HandleRef pThis);

	/// <summary>
	/// Get report of capabilities for the render window
	/// </summary>
	public override string ReportCapabilities()
	{
		return Marshal.PtrToStringAnsi(vtkWin32OpenGLRenderWindow_ReportCapabilities_31(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWin32OpenGLRenderWindow_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkWin32OpenGLRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkWin32OpenGLRenderWindow vtkWin32OpenGLRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWin32OpenGLRenderWindow_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWin32OpenGLRenderWindow2 = (vtkWin32OpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWin32OpenGLRenderWindow2.Register(null);
			}
		}
		return vtkWin32OpenGLRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetCurrentCursor_33(HandleRef pThis, int arg0);

	/// <summary>
	/// Change the shape of the cursor
	/// </summary>
	public override void SetCurrentCursor(int arg0)
	{
		vtkWin32OpenGLRenderWindow_SetCurrentCursor_33(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetCursorPosition_34(HandleRef pThis, int x, int y);

	/// <summary>
	/// Hide or Show the mouse cursor, it is nice to be able to hide the
	/// default cursor if you want VTK to display a 3D cursor instead.
	/// Set cursor position in window (note that (0,0) is the lower left
	/// corner).
	/// </summary>
	public override void SetCursorPosition(int x, int y)
	{
		vtkWin32OpenGLRenderWindow_SetCursorPosition_34(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetDisplayId_35(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Sets the HWND id of the window that WILL BE created.
	/// </summary>
	public override void SetDisplayId(IntPtr arg0)
	{
		vtkWin32OpenGLRenderWindow_SetDisplayId_35(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetFullScreen_36(HandleRef pThis, int arg0);

	/// <summary>
	/// Change the window to fill the entire screen.
	/// </summary>
	public override void SetFullScreen(int arg0)
	{
		vtkWin32OpenGLRenderWindow_SetFullScreen_36(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetIcon_37(HandleRef pThis, HandleRef img);

	/// <summary>
	/// Set the icon displayed in the title bar and the taskbar.
	/// </summary>
	public override void SetIcon(vtkImageData img)
	{
		vtkWin32OpenGLRenderWindow_SetIcon_37(GetCppThis(), img?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetNextWindowId_38(HandleRef pThis, IntPtr arg);

	/// <summary>
	/// Set the window id of the new window once a WindowRemap is done.
	/// This is the generic prototype as required by the vtkRenderWindow
	/// parent.
	/// </summary>
	public override void SetNextWindowId(IntPtr arg)
	{
		vtkWin32OpenGLRenderWindow_SetNextWindowId_38(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetNextWindowInfo_39(HandleRef pThis, string arg0);

	/// <summary>
	/// Sets the WindowInfo that will be used after a WindowRemap.
	/// </summary>
	public override void SetNextWindowInfo(string arg0)
	{
		vtkWin32OpenGLRenderWindow_SetNextWindowInfo_39(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetParentId_40(HandleRef pThis, IntPtr foo);

	/// <summary>
	/// Set the window's parent id to a pre-existing window.
	/// </summary>
	public override void SetParentId(IntPtr foo)
	{
		vtkWin32OpenGLRenderWindow_SetParentId_40(GetCppThis(), foo);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetParentInfo_41(HandleRef pThis, string arg0);

	/// <summary>
	/// Sets the HWND id of the window that WILL BE created.
	/// </summary>
	public override void SetParentInfo(string arg0)
	{
		vtkWin32OpenGLRenderWindow_SetParentInfo_41(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetPosition_42(HandleRef pThis, int x, int y);

	/// <summary>
	/// Set the position (x and y) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	/// </summary>
	public override void SetPosition(int x, int y)
	{
		vtkWin32OpenGLRenderWindow_SetPosition_42(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetPosition_43(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the position (x and y) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	/// </summary>
	public override void SetPosition(IntPtr a)
	{
		vtkWin32OpenGLRenderWindow_SetPosition_43(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetShowWindow_44(HandleRef pThis, byte val);

	/// <summary>
	/// Show or not Show the window
	/// </summary>
	public override void SetShowWindow(bool val)
	{
		vtkWin32OpenGLRenderWindow_SetShowWindow_44(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetSize_45(HandleRef pThis, int width, int height);

	/// <summary>
	/// Set the size (width and height) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public override void SetSize(int width, int height)
	{
		vtkWin32OpenGLRenderWindow_SetSize_45(GetCppThis(), width, height);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetSize_46(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the size (width and height) of the rendering window in
	/// screen coordinates (in pixels). This resizes the operating
	/// system's view/window and redraws it.
	///
	/// If the size has changed, this method will fire
	/// vtkCommand::WindowResizeEvent.
	/// </summary>
	public override void SetSize(IntPtr a)
	{
		vtkWin32OpenGLRenderWindow_SetSize_46(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetStereoCapableWindow_47(HandleRef pThis, int capable);

	/// <summary>
	/// Prescribe that the window be created in a stereo-capable mode. This
	/// method must be called before the window is realized. This method
	/// overrides the superclass method since this class can actually check
	/// whether the window has been realized yet.
	/// </summary>
	public override void SetStereoCapableWindow(int capable)
	{
		vtkWin32OpenGLRenderWindow_SetStereoCapableWindow_47(GetCppThis(), capable);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkWin32OpenGLRenderWindow_SetSwapControl_48(HandleRef pThis, int i);

	/// <summary>
	/// Set the number of vertical syncs required between frames.
	/// A value of 0 means swap buffers as quickly as possible
	/// regardless of the vertical refresh. A value of 1 means swap
	/// buffers in sync with the vertical refresh to eliminate tearing.
	/// A value of -1 means use a value of 1 unless we missed a frame
	/// in which case swap immediately. Returns true if the call
	/// succeeded.
	/// </summary>
	public override bool SetSwapControl(int i)
	{
		return (vtkWin32OpenGLRenderWindow_SetSwapControl_48(GetCppThis(), i) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetWindowId_49(HandleRef pThis, IntPtr foo);

	/// <summary>
	/// Set the window id to a pre-existing window.
	/// </summary>
	public override void SetWindowId(IntPtr foo)
	{
		vtkWin32OpenGLRenderWindow_SetWindowId_49(GetCppThis(), foo);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetWindowInfo_50(HandleRef pThis, string arg0);

	/// <summary>
	/// Set this RenderWindow's window id to a pre-existing window.
	/// </summary>
	public override void SetWindowInfo(string arg0)
	{
		vtkWin32OpenGLRenderWindow_SetWindowInfo_50(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_SetWindowName_51(HandleRef pThis, string arg0);

	/// <summary>
	/// Set the name of the window. This appears at the top of the window
	/// normally.
	/// </summary>
	public override void SetWindowName(string arg0)
	{
		vtkWin32OpenGLRenderWindow_SetWindowName_51(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_ShowCursor_52(HandleRef pThis);

	/// <summary>
	/// Hide or Show the mouse cursor, it is nice to be able to hide the
	/// default cursor if you want VTK to display a 3D cursor instead.
	/// Set cursor position in window (note that (0,0) is the lower left
	/// corner).
	/// </summary>
	public override void ShowCursor()
	{
		vtkWin32OpenGLRenderWindow_ShowCursor_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_WindowInitialize_53(HandleRef pThis);

	/// <summary>
	/// Create the window
	/// </summary>
	public virtual void WindowInitialize()
	{
		vtkWin32OpenGLRenderWindow_WindowInitialize_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWin32OpenGLRenderWindow_WindowRemap_54(HandleRef pThis);

	/// <summary>
	/// Remap the window.
	/// </summary>
	public override void WindowRemap()
	{
		vtkWin32OpenGLRenderWindow_WindowRemap_54(GetCppThis());
	}
}
