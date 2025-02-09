using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCameraOrientationWidget
/// </summary>
/// <remarks>
///    A widget to manipulate vtkCameraOrientationWidget.
///
///
/// This 3D widget creates and manages its own vtkCameraOrientationRepresentation.
/// To use this widget, make sure you call SetParentRenderer() and enable the widget.
/// The jump-to-axis-viewpoint feature is animated over 20 frames. See SetAnimatorTotalFrames()
/// Turn off animation with AnimateOff()
///
/// @par Event Bindings:
/// By default, the widget responds to the following VTK events (i.e., it
/// watches the vtkRenderWindowInteractor for these events):
/// &lt;pre&gt;
/// LeftButtonPressEvent - select the appropriate handle
/// LeftButtonReleaseEvent - release the currently selected handle
/// If one of the six handles are selected:
///   MouseMoveEvent - rotate (if left button) , else set hover representation for nearest handle.
/// &lt;/pre&gt;
/// These input events are not forwarded to any other observers. This widget
/// eats up mouse events. (AbortFlagOn).
///
/// @par Event Bindings:
/// Note that the event bindings described above can be changed using this
/// class's vtkWidgetEventTranslator, which translates VTK events
/// into the vtkCameraOrientationWidget's widget events:
/// &lt;pre&gt;
///   vtkWidgetEvent::Select -- some part of the widget has been selected
///   vtkWidgetEvent::EndSelect -- the selection process has completed
///   vtkWidgetEvent::Move -- a request for motion has been invoked
/// &lt;/pre&gt;
///
/// @par Event Bindings:
/// This class, and the affiliated vtkCameraOrientationRepresentation,
/// are second generation VTK widgets.
///
/// </remarks>
/// <seealso>
///
/// vtkCameraOrientationRepresentation
/// </seealso>
public class vtkCameraOrientationWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCameraOrientationWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCameraOrientationWidget()
	{
		MRClassNameKey = "class vtkCameraOrientationWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraOrientationWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCameraOrientationWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraOrientationWidget New()
	{
		vtkCameraOrientationWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraOrientationWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCameraOrientationWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCameraOrientationWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCameraOrientationWidget_AnimateOff_01(HandleRef pThis);

	/// <summary>
	/// Enable jump-to-axis-view animation.
	/// See AnimatorTotalFrames.
	/// </summary>
	public virtual void AnimateOff()
	{
		vtkCameraOrientationWidget_AnimateOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationWidget_AnimateOn_02(HandleRef pThis);

	/// <summary>
	/// Enable jump-to-axis-view animation.
	/// See AnimatorTotalFrames.
	/// </summary>
	public virtual void AnimateOn()
	{
		vtkCameraOrientationWidget_AnimateOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationWidget_CreateDefaultRepresentation_03(HandleRef pThis);

	/// <summary>
	/// Create a vtkCameraOrientationRepresentation.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkCameraOrientationWidget_CreateDefaultRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCameraOrientationWidget_GetAnimate_04(HandleRef pThis);

	/// <summary>
	/// Enable jump-to-axis-view animation.
	/// See AnimatorTotalFrames.
	/// </summary>
	public virtual bool GetAnimate()
	{
		return (vtkCameraOrientationWidget_GetAnimate_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationWidget_GetAnimatorTotalFrames_05(HandleRef pThis);

	/// <summary>
	/// Length of animation. (in frames)
	/// </summary>
	public virtual int GetAnimatorTotalFrames()
	{
		return vtkCameraOrientationWidget_GetAnimatorTotalFrames_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationWidget_GetAnimatorTotalFramesMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Length of animation. (in frames)
	/// </summary>
	public virtual int GetAnimatorTotalFramesMaxValue()
	{
		return vtkCameraOrientationWidget_GetAnimatorTotalFramesMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationWidget_GetAnimatorTotalFramesMinValue_07(HandleRef pThis);

	/// <summary>
	/// Length of animation. (in frames)
	/// </summary>
	public virtual int GetAnimatorTotalFramesMinValue()
	{
		return vtkCameraOrientationWidget_GetAnimatorTotalFramesMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraOrientationWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCameraOrientationWidget_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraOrientationWidget_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCameraOrientationWidget_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationWidget_GetParentRenderer_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This widget shows and manipulates the orientation of
	/// the parent renderer's active camera.
	///
	/// Note: The renderer must be part of a render window for
	/// the widget to appear.
	/// </summary>
	public vtkRenderer GetParentRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationWidget_GetParentRenderer_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationWidget_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCameraOrientationWidget_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraOrientationWidget_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCameraOrientationWidget_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationWidget_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCameraOrientationWidget NewInstance()
	{
		vtkCameraOrientationWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationWidget_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraOrientationWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraOrientationWidget_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraOrientationWidget SafeDownCast(vtkObjectBase o)
	{
		vtkCameraOrientationWidget vtkCameraOrientationWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraOrientationWidget_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCameraOrientationWidget2 = (vtkCameraOrientationWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCameraOrientationWidget2.Register(null);
			}
		}
		return vtkCameraOrientationWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationWidget_SetAnimate_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable jump-to-axis-view animation.
	/// See AnimatorTotalFrames.
	/// </summary>
	public virtual void SetAnimate(bool _arg)
	{
		vtkCameraOrientationWidget_SetAnimate_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationWidget_SetAnimatorTotalFrames_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Length of animation. (in frames)
	/// </summary>
	public virtual void SetAnimatorTotalFrames(int _arg)
	{
		vtkCameraOrientationWidget_SetAnimatorTotalFrames_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationWidget_SetParentRenderer_18(HandleRef pThis, HandleRef renderer);

	/// <summary>
	/// This widget shows and manipulates the orientation of
	/// the parent renderer's active camera.
	///
	/// Note: The renderer must be part of a render window for
	/// the widget to appear.
	/// </summary>
	public void SetParentRenderer(vtkRenderer renderer)
	{
		vtkCameraOrientationWidget_SetParentRenderer_18(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraOrientationWidget_SquareResize_19(HandleRef pThis);

	/// <summary>
	/// Fits the widget's renderer to a square viewport.
	/// </summary>
	public void SquareResize()
	{
		vtkCameraOrientationWidget_SquareResize_19(GetCppThis());
	}
}
