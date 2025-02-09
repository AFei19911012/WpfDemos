using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOutputWindow
/// </summary>
/// <remarks>
///    base class for writing debug output to a console
///
/// This class is used to encapsulate all text output, so that it will work
/// with operating systems that have a stdout and stderr, and ones that
/// do not.  (i.e windows does not).  Sub-classes can be provided which can
/// redirect the output to a window.
/// </remarks>
public class vtkOutputWindow : vtkObject
{
	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public enum DisplayModes
	{
		/// <summary>enum member</summary>
		ALWAYS = 1,
		/// <summary>enum member</summary>
		ALWAYS_STDERR = 2,
		/// <summary>enum member</summary>
		DEFAULT = -1,
		/// <summary>enum member</summary>
		NEVER = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOutputWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOutputWindow()
	{
		MRClassNameKey = "class vtkOutputWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutputWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOutputWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutputWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a new instance of vtkOutputWindow. Note this *will* create a new
	/// instance using the vtkObjectFactory. If you want to access the global
	/// instance, use `GetInstance` instead.
	/// </summary>
	public new static vtkOutputWindow New()
	{
		vtkOutputWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a new instance of vtkOutputWindow. Note this *will* create a new
	/// instance using the vtkObjectFactory. If you want to access the global
	/// instance, use `GetInstance` instead.
	/// </summary>
	public vtkOutputWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOutputWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_DisplayDebugText_01(HandleRef pThis, string arg0);

	/// <summary>
	/// Display the text. Four virtual methods exist, depending on the type of
	/// message to display. This allows redirection or reformatting of the
	/// messages. The default implementation uses DisplayText for all.
	/// Consequently, subclasses can simply override DisplayText and use
	/// `GetCurrentMessageType` to determine the type of message that's being reported.
	/// </summary>
	public virtual void DisplayDebugText(string arg0)
	{
		vtkOutputWindow_DisplayDebugText_01(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_DisplayErrorText_02(HandleRef pThis, string arg0);

	/// <summary>
	/// Display the text. Four virtual methods exist, depending on the type of
	/// message to display. This allows redirection or reformatting of the
	/// messages. The default implementation uses DisplayText for all.
	/// Consequently, subclasses can simply override DisplayText and use
	/// `GetCurrentMessageType` to determine the type of message that's being reported.
	/// </summary>
	public virtual void DisplayErrorText(string arg0)
	{
		vtkOutputWindow_DisplayErrorText_02(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_DisplayGenericWarningText_03(HandleRef pThis, string arg0);

	/// <summary>
	/// Display the text. Four virtual methods exist, depending on the type of
	/// message to display. This allows redirection or reformatting of the
	/// messages. The default implementation uses DisplayText for all.
	/// Consequently, subclasses can simply override DisplayText and use
	/// `GetCurrentMessageType` to determine the type of message that's being reported.
	/// </summary>
	public virtual void DisplayGenericWarningText(string arg0)
	{
		vtkOutputWindow_DisplayGenericWarningText_03(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_DisplayText_04(HandleRef pThis, string arg0);

	/// <summary>
	/// Display the text. Four virtual methods exist, depending on the type of
	/// message to display. This allows redirection or reformatting of the
	/// messages. The default implementation uses DisplayText for all.
	/// Consequently, subclasses can simply override DisplayText and use
	/// `GetCurrentMessageType` to determine the type of message that's being reported.
	/// </summary>
	public virtual void DisplayText(string arg0)
	{
		vtkOutputWindow_DisplayText_04(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_DisplayWarningText_05(HandleRef pThis, string arg0);

	/// <summary>
	/// Display the text. Four virtual methods exist, depending on the type of
	/// message to display. This allows redirection or reformatting of the
	/// messages. The default implementation uses DisplayText for all.
	/// Consequently, subclasses can simply override DisplayText and use
	/// `GetCurrentMessageType` to determine the type of message that's being reported.
	/// </summary>
	public virtual void DisplayWarningText(string arg0)
	{
		vtkOutputWindow_DisplayWarningText_05(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutputWindow_GetDisplayMode_06(HandleRef pThis);

	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public virtual int GetDisplayMode()
	{
		return vtkOutputWindow_GetDisplayMode_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutputWindow_GetDisplayModeMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public virtual int GetDisplayModeMaxValue()
	{
		return vtkOutputWindow_GetDisplayModeMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutputWindow_GetDisplayModeMinValue_08(HandleRef pThis);

	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public virtual int GetDisplayModeMinValue()
	{
		return vtkOutputWindow_GetDisplayModeMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutputWindow_GetInstance_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the singleton instance with no reference counting.
	/// </summary>
	public static vtkOutputWindow GetInstance()
	{
		vtkOutputWindow vtkOutputWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutputWindow_GetInstance_09(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOutputWindow2 = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOutputWindow2.Register(null);
			}
		}
		return vtkOutputWindow2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOutputWindow_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOutputWindow_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOutputWindow_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOutputWindow_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutputWindow_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOutputWindow_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutputWindow_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOutputWindow_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutputWindow_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOutputWindow NewInstance()
	{
		vtkOutputWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutputWindow_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_PromptUserOff_16(HandleRef pThis);

	/// <summary>
	/// If PromptUser is set to true then each time a line of text
	/// is displayed, the user is asked if they want to keep getting
	/// messages.
	///
	/// Note that PromptUser has not effect of messages displayed by directly
	/// calling `DisplayText`. The prompt is never shown for such messages.
	///
	/// </summary>
	public virtual void PromptUserOff()
	{
		vtkOutputWindow_PromptUserOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_PromptUserOn_17(HandleRef pThis);

	/// <summary>
	/// If PromptUser is set to true then each time a line of text
	/// is displayed, the user is asked if they want to keep getting
	/// messages.
	///
	/// Note that PromptUser has not effect of messages displayed by directly
	/// calling `DisplayText`. The prompt is never shown for such messages.
	///
	/// </summary>
	public virtual void PromptUserOn()
	{
		vtkOutputWindow_PromptUserOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutputWindow_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOutputWindow SafeDownCast(vtkObjectBase o)
	{
		vtkOutputWindow vtkOutputWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutputWindow_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOutputWindow2 = (vtkOutputWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOutputWindow2.Register(null);
			}
		}
		return vtkOutputWindow2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_SetDisplayMode_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public virtual void SetDisplayMode(int _arg)
	{
		vtkOutputWindow_SetDisplayMode_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_SetDisplayModeToAlways_20(HandleRef pThis);

	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public void SetDisplayModeToAlways()
	{
		vtkOutputWindow_SetDisplayModeToAlways_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_SetDisplayModeToAlwaysStdErr_21(HandleRef pThis);

	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public void SetDisplayModeToAlwaysStdErr()
	{
		vtkOutputWindow_SetDisplayModeToAlwaysStdErr_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_SetDisplayModeToDefault_22(HandleRef pThis);

	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public void SetDisplayModeToDefault()
	{
		vtkOutputWindow_SetDisplayModeToDefault_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_SetDisplayModeToNever_23(HandleRef pThis);

	/// <summary>
	/// Flag indicates how the vtkOutputWindow handles displaying of text to
	/// `stderr` / `stdout`. Default is `DEFAULT` except in
	/// `vtkWin32OutputWindow` where on non dashboard runs, the default is
	/// `NEVER`.
	///
	/// `NEVER` indicates that the messages should never be forwarded to the
	/// standard output/error streams.
	///
	/// `ALWAYS` will result in error/warning/debug messages being posted to the
	/// standard error stream, while text messages to standard output stream.
	///
	/// `ALWAYS_STDERR` will result in all messages being posted to the standard
	/// error stream (this was default behavior in VTK 8.1 and earlier).
	///
	/// `DEFAULT` is similar to `ALWAYS` except when logging is enabled. If
	/// logging is enabled, messages posted to the output window using VTK error/warning macros such as
	/// `vtkErrorMacro`, `vtkWarningMacro` etc. will not posted on any of the output streams. This is
	/// done to avoid duplicate messages on these streams since these macros also result in add items
	/// to the log.
	///
	/// @note vtkStringOutputWindow does not result this flag as is never forwards
	/// any text to the output streams.
	/// </summary>
	public void SetDisplayModeToNever()
	{
		vtkOutputWindow_SetDisplayModeToNever_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_SetInstance_24(HandleRef instance);

	/// <summary>
	/// Supply a user defined output window. Call -&gt;Delete() on the supplied
	/// instance after setting it.
	/// </summary>
	public static void SetInstance(vtkOutputWindow instance)
	{
		vtkOutputWindow_SetInstance_24(instance?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutputWindow_SetPromptUser_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// If PromptUser is set to true then each time a line of text
	/// is displayed, the user is asked if they want to keep getting
	/// messages.
	///
	/// Note that PromptUser has not effect of messages displayed by directly
	/// calling `DisplayText`. The prompt is never shown for such messages.
	///
	/// </summary>
	public virtual void SetPromptUser(bool _arg)
	{
		vtkOutputWindow_SetPromptUser_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
