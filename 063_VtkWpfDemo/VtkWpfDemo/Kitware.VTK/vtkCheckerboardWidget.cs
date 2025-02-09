using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCheckerboardWidget
/// </summary>
/// <remarks>
///    interactively set the number of divisions in 2D image checkerboard
///
/// The vtkCheckerboardWidget is used to interactively control an instance of
/// vtkImageCheckerboard (and an associated vtkImageActor used to display the
/// checkerboard). The user can adjust the number of divisions in each of the
/// i-j directions in a 2D image. A frame appears around the vtkImageActor
/// with sliders along each side of the frame. The user can interactively
/// adjust the sliders to the desired number of checkerboard subdivisions.
///
/// To use this widget, specify an instance of vtkImageCheckerboard and an
/// instance of vtkImageActor. By default, the widget responds to the
/// following events:
/// &lt;pre&gt;
/// If the slider bead is selected:
///   LeftButtonPressEvent - select slider (if on slider)
///   LeftButtonReleaseEvent - release slider
///   MouseMoveEvent - move slider
/// If the end caps or slider tube of a slider are selected:
///   LeftButtonPressEvent - jump (or animate) to cap or point on tube;
/// &lt;/pre&gt;
/// It is possible to change these event bindings. Please refer to the
/// documentation for vtkSliderWidget for more information. Advanced users may
/// directly access and manipulate the sliders by obtaining the instances of
/// vtkSliderWidget composing the vtkCheckerboard widget.
///
/// </remarks>
/// <seealso>
///
/// vtkImageCheckerboard vtkImageActor vtkSliderWidget vtkRectilinearWipeWidget
/// </seealso>
public class vtkCheckerboardWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCheckerboardWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCheckerboardWidget()
	{
		MRClassNameKey = "class vtkCheckerboardWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCheckerboardWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCheckerboardWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkCheckerboardWidget New()
	{
		vtkCheckerboardWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkCheckerboardWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCheckerboardWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCheckerboardWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkCheckerboardWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardWidget_GetCheckerboardRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkCheckerboardRepresentation.
	/// </summary>
	public vtkCheckerboardRepresentation GetCheckerboardRepresentation()
	{
		vtkCheckerboardRepresentation vtkCheckerboardRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardWidget_GetCheckerboardRepresentation_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCheckerboardRepresentation2 = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCheckerboardRepresentation2.Register(null);
			}
		}
		return vtkCheckerboardRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCheckerboardWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCheckerboardWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCheckerboardWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCheckerboardWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardWidget_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCheckerboardWidget_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCheckerboardWidget_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCheckerboardWidget_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new vtkCheckerboardWidget NewInstance()
	{
		vtkCheckerboardWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardWidget_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCheckerboardWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for a VTK class.
	/// </summary>
	public new static vtkCheckerboardWidget SafeDownCast(vtkObjectBase o)
	{
		vtkCheckerboardWidget vtkCheckerboardWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCheckerboardWidget_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCheckerboardWidget2 = (vtkCheckerboardWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCheckerboardWidget2.Register(null);
			}
		}
		return vtkCheckerboardWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardWidget_SetEnabled_10(HandleRef pThis, int arg0);

	/// <summary>
	/// The method for activating and deactivating this widget. This method
	/// must be overridden because it is a composite widget and does more than
	/// its superclasses' vtkAbstractWidget::SetEnabled() method.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkCheckerboardWidget_SetEnabled_10(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCheckerboardWidget_SetRepresentation_11(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkCheckerboardRepresentation r)
	{
		vtkCheckerboardWidget_SetRepresentation_11(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}
}
