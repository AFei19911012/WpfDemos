using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericOpenGLRenderWindow
/// </summary>
/// <remarks>
///    platform independent render window
///
///
/// vtkGenericOpenGLRenderWindow provides a skeleton for implementing a render window
/// using one's own OpenGL context and drawable.
/// To be effective, one must register an observer for WindowMakeCurrentEvent,
/// WindowIsCurrentEvent and WindowFrameEvent.  When this class sends a WindowIsCurrentEvent,
/// the call data is an bool* which one can use to return whether the context is current.
/// </remarks>
public class vtkGenericOpenGLRenderWindow : vtkOpenGLRenderWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericOpenGLRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericOpenGLRenderWindow()
	{
		MRClassNameKey = "class vtkGenericOpenGLRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericOpenGLRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericOpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericOpenGLRenderWindow New()
	{
		vtkGenericOpenGLRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericOpenGLRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGenericOpenGLRenderWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericOpenGLRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGenericOpenGLRenderWindow_CreateAWindow_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void CreateAWindow()
	{
		vtkGenericOpenGLRenderWindow_CreateAWindow_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_DestroyWindow_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void DestroyWindow()
	{
		vtkGenericOpenGLRenderWindow_DestroyWindow_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_Finalize_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void FinalizeWrapper()
	{
		vtkGenericOpenGLRenderWindow_Finalize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_Frame_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Frame()
	{
		vtkGenericOpenGLRenderWindow_Frame_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericOpenGLRenderWindow_GetEventPending_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetEventPending()
	{
		return vtkGenericOpenGLRenderWindow_GetEventPending_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidth_06(HandleRef pThis);

	/// <summary>
	/// Specify a non-zero line width to force the hardware line width determined
	/// by the window.
	/// </summary>
	public virtual float GetForceMaximumHardwareLineWidth()
	{
		return vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidth_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidthMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Specify a non-zero line width to force the hardware line width determined
	/// by the window.
	/// </summary>
	public virtual float GetForceMaximumHardwareLineWidthMaxValue()
	{
		return vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidthMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidthMinValue_08(HandleRef pThis);

	/// <summary>
	/// Specify a non-zero line width to force the hardware line width determined
	/// by the window.
	/// </summary>
	public virtual float GetForceMaximumHardwareLineWidthMinValue()
	{
		return vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidthMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericContext_09(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override IntPtr GetGenericContext()
	{
		return vtkGenericOpenGLRenderWindow_GetGenericContext_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericDisplayId_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override IntPtr GetGenericDisplayId()
	{
		return vtkGenericOpenGLRenderWindow_GetGenericDisplayId_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericDrawable_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override IntPtr GetGenericDrawable()
	{
		return vtkGenericOpenGLRenderWindow_GetGenericDrawable_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericParentId_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override IntPtr GetGenericParentId()
	{
		return vtkGenericOpenGLRenderWindow_GetGenericParentId_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericWindowId_13(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override IntPtr GetGenericWindowId()
	{
		return vtkGenericOpenGLRenderWindow_GetGenericWindowId_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGenericOpenGLRenderWindow_GetMaximumHardwareLineWidth_14(HandleRef pThis);

	/// <summary>
	/// Overridden to pass explicitly specified MaximumHardwareLineWidth, if any.
	/// </summary>
	public override float GetMaximumHardwareLineWidth()
	{
		return vtkGenericOpenGLRenderWindow_GetMaximumHardwareLineWidth_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericOpenGLRenderWindow_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericOpenGLRenderWindow_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGenericOpenGLRenderWindow_GetReadyForRendering_17(HandleRef pThis);

	/// <summary>
	/// Set this to true to indicate that the context is now ready. For backwards
	/// compatibility reasons, it's set to true by default. If set to false, the
	/// `Render` call will be skipped entirely.
	/// </summary>
	public virtual bool GetReadyForRendering()
	{
		return (vtkGenericOpenGLRenderWindow_GetReadyForRendering_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetScreenSize_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int[] GetScreenSize()
	{
		IntPtr intPtr = vtkGenericOpenGLRenderWindow_GetScreenSize_18(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_HideCursor_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void HideCursor()
	{
		vtkGenericOpenGLRenderWindow_HideCursor_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericOpenGLRenderWindow_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericOpenGLRenderWindow_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGenericOpenGLRenderWindow_IsCurrent_21(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override bool IsCurrent()
	{
		return (vtkGenericOpenGLRenderWindow_IsCurrent_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericOpenGLRenderWindow_IsDirect_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsDirect()
	{
		return vtkGenericOpenGLRenderWindow_IsDirect_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericOpenGLRenderWindow_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericOpenGLRenderWindow_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_MakeCurrent_24(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void MakeCurrent()
	{
		vtkGenericOpenGLRenderWindow_MakeCurrent_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericOpenGLRenderWindow NewInstance()
	{
		vtkGenericOpenGLRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericOpenGLRenderWindow_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_OpenGLInit_27(HandleRef pThis);

	/// <summary>
	/// Initialize OpenGL for this window.
	/// </summary>
	public override void OpenGLInit()
	{
		vtkGenericOpenGLRenderWindow_OpenGLInit_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_PopState_28(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void PopState()
	{
		vtkGenericOpenGLRenderWindow_PopState_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_PushState_29(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void PushState()
	{
		vtkGenericOpenGLRenderWindow_PushState_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_Render_30(HandleRef pThis);

	/// <summary>
	/// Override the Render method to do some state management.
	/// This method saves the OpenGL state before asking its child renderers to
	/// render their image. Once this is done, the OpenGL state is restored.
	/// \sa vtkOpenGLRenderWindow::SaveGLState()
	/// \sa vtkOpenGLRenderWindow::RestoreGLState()
	/// </summary>
	public override void Render()
	{
		vtkGenericOpenGLRenderWindow_Render_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericOpenGLRenderWindow_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericOpenGLRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkGenericOpenGLRenderWindow vtkGenericOpenGLRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericOpenGLRenderWindow_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericOpenGLRenderWindow2 = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericOpenGLRenderWindow2.Register(null);
			}
		}
		return vtkGenericOpenGLRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetBackLeftBuffer_32(HandleRef pThis, uint arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBackLeftBuffer(uint arg0)
	{
		vtkGenericOpenGLRenderWindow_SetBackLeftBuffer_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetBackRightBuffer_33(HandleRef pThis, uint arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetBackRightBuffer(uint arg0)
	{
		vtkGenericOpenGLRenderWindow_SetBackRightBuffer_33(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetCurrentCursor_34(HandleRef pThis, int cShape);

	/// <summary>
	/// Overridden to invoke vtkCommand::CursorChangedEvent
	/// </summary>
	public override void SetCurrentCursor(int cShape)
	{
		vtkGenericOpenGLRenderWindow_SetCurrentCursor_34(GetCppThis(), cShape);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetDisplayId_35(HandleRef pThis, IntPtr arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetDisplayId(IntPtr arg0)
	{
		vtkGenericOpenGLRenderWindow_SetDisplayId_35(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetForceMaximumHardwareLineWidth_36(HandleRef pThis, float _arg);

	/// <summary>
	/// Specify a non-zero line width to force the hardware line width determined
	/// by the window.
	/// </summary>
	public virtual void SetForceMaximumHardwareLineWidth(float _arg)
	{
		vtkGenericOpenGLRenderWindow_SetForceMaximumHardwareLineWidth_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetFrontLeftBuffer_37(HandleRef pThis, uint arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetFrontLeftBuffer(uint arg0)
	{
		vtkGenericOpenGLRenderWindow_SetFrontLeftBuffer_37(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetFrontRightBuffer_38(HandleRef pThis, uint arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetFrontRightBuffer(uint arg0)
	{
		vtkGenericOpenGLRenderWindow_SetFrontRightBuffer_38(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetFullScreen_39(HandleRef pThis, int arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetFullScreen(int arg0)
	{
		vtkGenericOpenGLRenderWindow_SetFullScreen_39(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetIsCurrent_40(HandleRef pThis, byte newValue);

	/// <summary>
	/// Allow to update state within observer callback without changing
	/// data argument and MTime.
	/// </summary>
	public void SetIsCurrent(bool newValue)
	{
		vtkGenericOpenGLRenderWindow_SetIsCurrent_40(GetCppThis(), (byte)(newValue ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetIsDirect_41(HandleRef pThis, int newValue);

	/// <summary>
	/// Allow to update state within observer callback without changing
	/// data argument and MTime.
	/// </summary>
	public void SetIsDirect(int newValue)
	{
		vtkGenericOpenGLRenderWindow_SetIsDirect_41(GetCppThis(), newValue);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetMapped_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Overridden to invoke vtkCommand::CursorChangedEvent
	/// </summary>
	public virtual void SetMapped(int _arg)
	{
		vtkGenericOpenGLRenderWindow_SetMapped_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetNextWindowId_43(HandleRef pThis, IntPtr arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetNextWindowId(IntPtr arg0)
	{
		vtkGenericOpenGLRenderWindow_SetNextWindowId_43(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetNextWindowInfo_44(HandleRef pThis, string arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetNextWindowInfo(string arg0)
	{
		vtkGenericOpenGLRenderWindow_SetNextWindowInfo_44(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetOwnContext_45(HandleRef pThis, int arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetOwnContext(int arg0)
	{
		vtkGenericOpenGLRenderWindow_SetOwnContext_45(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetParentId_46(HandleRef pThis, IntPtr arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetParentId(IntPtr arg0)
	{
		vtkGenericOpenGLRenderWindow_SetParentId_46(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetParentInfo_47(HandleRef pThis, string arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetParentInfo(string arg0)
	{
		vtkGenericOpenGLRenderWindow_SetParentInfo_47(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetReadyForRendering_48(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set this to true to indicate that the context is now ready. For backwards
	/// compatibility reasons, it's set to true by default. If set to false, the
	/// `Render` call will be skipped entirely.
	/// </summary>
	public virtual void SetReadyForRendering(bool _arg)
	{
		vtkGenericOpenGLRenderWindow_SetReadyForRendering_48(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetScreenSize_49(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the size of the screen in pixels.
	/// An HDTV for example would be 1920 x 1080 pixels.
	/// </summary>
	public virtual void SetScreenSize(int _arg1, int _arg2)
	{
		vtkGenericOpenGLRenderWindow_SetScreenSize_49(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetScreenSize_50(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the size of the screen in pixels.
	/// An HDTV for example would be 1920 x 1080 pixels.
	/// </summary>
	public void SetScreenSize(IntPtr _arg)
	{
		vtkGenericOpenGLRenderWindow_SetScreenSize_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetSupportsOpenGL_51(HandleRef pThis, int newValue);

	/// <summary>
	/// Allow to update state within observer callback without changing
	/// data argument and MTime.
	/// </summary>
	public void SetSupportsOpenGL(int newValue)
	{
		vtkGenericOpenGLRenderWindow_SetSupportsOpenGL_51(GetCppThis(), newValue);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetWindowId_52(HandleRef pThis, IntPtr arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetWindowId(IntPtr arg0)
	{
		vtkGenericOpenGLRenderWindow_SetWindowId_52(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_SetWindowInfo_53(HandleRef pThis, string arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void SetWindowInfo(string arg0)
	{
		vtkGenericOpenGLRenderWindow_SetWindowInfo_53(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_ShowCursor_54(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void ShowCursor()
	{
		vtkGenericOpenGLRenderWindow_ShowCursor_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericOpenGLRenderWindow_SupportsOpenGL_55(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int SupportsOpenGL()
	{
		return vtkGenericOpenGLRenderWindow_SupportsOpenGL_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericOpenGLRenderWindow_WindowRemap_56(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void WindowRemap()
	{
		vtkGenericOpenGLRenderWindow_WindowRemap_56(GetCppThis());
	}
}
