using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExternalOpenGLRenderWindow
/// </summary>
/// <remarks>
///    OpenGL render window that allows using
/// an external window to render vtk objects
///
/// vtkExternalOpenGLRenderWindow is a concrete implementation of the abstract
/// class vtkRenderWindow. vtkExternalOpenGLRenderer interfaces to the OpenGL
/// graphics library.
///
/// This class extends vtkGenericOpenGLRenderWindow to allow sharing the
/// same OpenGL context by various visualization applications. Basically, this
/// class prevents VTK from creating a new OpenGL context. Thus, it requires that
/// an OpenGL context be initialized before Render is called.
/// \sa Render()
///
/// It is a generic implementation; this window is platform agnostic. However,
/// the application user must explicitly make sure the window size is
/// synchronized when the external application window/viewport resizes.
/// \sa SetSize()
///
/// It has the same requirements as the vtkGenericOpenGLRenderWindow, whereby,
/// one must register an observer for WindowMakeCurrentEvent,
/// WindowIsCurrentEvent and WindowFrameEvent.
/// \sa vtkGenericOpenGLRenderWindow
/// </remarks>
public class vtkExternalOpenGLRenderWindow : vtkGenericOpenGLRenderWindow
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExternalOpenGLRenderWindow";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExternalOpenGLRenderWindow()
	{
		MRClassNameKey = "class vtkExternalOpenGLRenderWindow";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExternalOpenGLRenderWindow"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExternalOpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExternalOpenGLRenderWindow New()
	{
		vtkExternalOpenGLRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExternalOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExternalOpenGLRenderWindow()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExternalOpenGLRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderWindow_AutomaticWindowPositionAndResizeOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which enables/disables automatic positioning and
	/// resizing of the render window. By default, vtkExternalOpenGLRenderWindow
	/// queries the viewport position and size (glViewport) from the OpenGL state
	/// and uses it to resize itself. However, in special circumstances this
	/// feature is undesirable. One such circumstance may be to avoid performance
	/// penalty of querying OpenGL state variables. So the following boolean is
	/// provided to disable automatic window resize.
	/// (Turn AutomaticWindowPositionAndResize off if you do not want the viewport
	/// to be queried from the OpenGL state.)
	/// </summary>
	public virtual void AutomaticWindowPositionAndResizeOff()
	{
		vtkExternalOpenGLRenderWindow_AutomaticWindowPositionAndResizeOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderWindow_AutomaticWindowPositionAndResizeOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which enables/disables automatic positioning and
	/// resizing of the render window. By default, vtkExternalOpenGLRenderWindow
	/// queries the viewport position and size (glViewport) from the OpenGL state
	/// and uses it to resize itself. However, in special circumstances this
	/// feature is undesirable. One such circumstance may be to avoid performance
	/// penalty of querying OpenGL state variables. So the following boolean is
	/// provided to disable automatic window resize.
	/// (Turn AutomaticWindowPositionAndResize off if you do not want the viewport
	/// to be queried from the OpenGL state.)
	/// </summary>
	public virtual void AutomaticWindowPositionAndResizeOn()
	{
		vtkExternalOpenGLRenderWindow_AutomaticWindowPositionAndResizeOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLRenderWindow_GetAutomaticWindowPositionAndResize_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which enables/disables automatic positioning and
	/// resizing of the render window. By default, vtkExternalOpenGLRenderWindow
	/// queries the viewport position and size (glViewport) from the OpenGL state
	/// and uses it to resize itself. However, in special circumstances this
	/// feature is undesirable. One such circumstance may be to avoid performance
	/// penalty of querying OpenGL state variables. So the following boolean is
	/// provided to disable automatic window resize.
	/// (Turn AutomaticWindowPositionAndResize off if you do not want the viewport
	/// to be queried from the OpenGL state.)
	/// </summary>
	public virtual int GetAutomaticWindowPositionAndResize()
	{
		return vtkExternalOpenGLRenderWindow_GetAutomaticWindowPositionAndResize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExternalOpenGLRenderWindow_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExternalOpenGLRenderWindow_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExternalOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExternalOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalOpenGLRenderWindow_GetUseExternalContent_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which enables/disables using the content from an
	/// outside application.  When on the active read buffer is first blitted
	/// into VTK and becomes the starting poiint for VTK's rendering.
	/// </summary>
	public virtual bool GetUseExternalContent()
	{
		return (vtkExternalOpenGLRenderWindow_GetUseExternalContent_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLRenderWindow_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExternalOpenGLRenderWindow_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExternalOpenGLRenderWindow_IsCurrent_08(HandleRef pThis);

	/// <summary>
	/// Tells if this window is the current graphics context for the calling
	/// thread.
	/// </summary>
	public override bool IsCurrent()
	{
		return (vtkExternalOpenGLRenderWindow_IsCurrent_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExternalOpenGLRenderWindow_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExternalOpenGLRenderWindow_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLRenderWindow_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExternalOpenGLRenderWindow NewInstance()
	{
		vtkExternalOpenGLRenderWindow result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLRenderWindow_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExternalOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExternalOpenGLRenderWindow_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExternalOpenGLRenderWindow SafeDownCast(vtkObjectBase o)
	{
		vtkExternalOpenGLRenderWindow vtkExternalOpenGLRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExternalOpenGLRenderWindow_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExternalOpenGLRenderWindow2 = (vtkExternalOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExternalOpenGLRenderWindow2.Register(null);
			}
		}
		return vtkExternalOpenGLRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderWindow_SetAutomaticWindowPositionAndResize_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off a flag which enables/disables automatic positioning and
	/// resizing of the render window. By default, vtkExternalOpenGLRenderWindow
	/// queries the viewport position and size (glViewport) from the OpenGL state
	/// and uses it to resize itself. However, in special circumstances this
	/// feature is undesirable. One such circumstance may be to avoid performance
	/// penalty of querying OpenGL state variables. So the following boolean is
	/// provided to disable automatic window resize.
	/// (Turn AutomaticWindowPositionAndResize off if you do not want the viewport
	/// to be queried from the OpenGL state.)
	/// </summary>
	public virtual void SetAutomaticWindowPositionAndResize(int _arg)
	{
		vtkExternalOpenGLRenderWindow_SetAutomaticWindowPositionAndResize_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderWindow_SetUseExternalContent_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off a flag which enables/disables using the content from an
	/// outside application.  When on the active read buffer is first blitted
	/// into VTK and becomes the starting poiint for VTK's rendering.
	/// </summary>
	public virtual void SetUseExternalContent(bool _arg)
	{
		vtkExternalOpenGLRenderWindow_SetUseExternalContent_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderWindow_Start_15(HandleRef pThis);

	/// <summary>
	/// Begin the rendering process using the existing context.
	/// </summary>
	public override void Start()
	{
		vtkExternalOpenGLRenderWindow_Start_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderWindow_UseExternalContentOff_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which enables/disables using the content from an
	/// outside application.  When on the active read buffer is first blitted
	/// into VTK and becomes the starting poiint for VTK's rendering.
	/// </summary>
	public virtual void UseExternalContentOff()
	{
		vtkExternalOpenGLRenderWindow_UseExternalContentOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExternalOpenGLRenderWindow_UseExternalContentOn_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off a flag which enables/disables using the content from an
	/// outside application.  When on the active read buffer is first blitted
	/// into VTK and becomes the starting poiint for VTK's rendering.
	/// </summary>
	public virtual void UseExternalContentOn()
	{
		vtkExternalOpenGLRenderWindow_UseExternalContentOn_17(GetCppThis());
	}
}
