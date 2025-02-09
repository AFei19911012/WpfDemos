using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMagnifierWidget
/// </summary>
/// <remarks>
///    create a moving, magnifying renderer that can inspect the contents
///          of an encapsulating renderer.
///
/// This class provides a small, interactive, overlayed viewport (i.e.,
/// renderer) that follows the mouse while inside another, larger
/// renderer. Inside this viewport effects like magnification (via zoom or
/// adjustment of the view angle), or other rendering effects are possible.
///
/// To use this widget, pair it with a representation (which provides options
/// like a border and so on). In the representation, indicate what renderer
/// with which the magnifier is associated. Optionally, a list of actors can
/// be provided to the magnifier so that it only renders the actors specified
/// (this is useful for removing objects like widgets from the scene, or
/// creating separate pipelines for creating special effects).
///
/// By default, the magnifier responds to the keypress "m" to toggle between
/// showing/hiding the magnifier. Internally, it also follows mouse move events
/// to track the magnifier with the mouse motion. Finally, using the "-" or "+"
/// keys can be used to decrease/increase the magnification factor by observing
/// the "vtkCommand::WidgetValueChangedEvent".
///
/// </remarks>
/// <seealso>
///
/// vtkMagnifierRepresentation
/// </seealso>
public class vtkMagnifierWidget : vtkAbstractWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMagnifierWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMagnifierWidget()
	{
		MRClassNameKey = "class vtkMagnifierWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMagnifierWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMagnifierWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Method to instantiate class.
	/// </summary>
	public new static vtkMagnifierWidget New()
	{
		vtkMagnifierWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMagnifierWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Method to instantiate class.
	/// </summary>
	public vtkMagnifierWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMagnifierWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMagnifierWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkMagnifierWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkMagnifierWidget_GetKeyPressDecreaseValue_02(HandleRef pThis);

	/// <summary>
	/// By default, the keypress "+" increases magnification, and the keypress
	/// "-" decreases magnification. These can be changed to other key press
	/// values. Note that in either case, these keypresses cause the widget to
	/// emit the "vtkCommand::WidgetValueChangedEvent".
	/// </summary>
	public virtual sbyte GetKeyPressDecreaseValue()
	{
		return vtkMagnifierWidget_GetKeyPressDecreaseValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkMagnifierWidget_GetKeyPressIncreaseValue_03(HandleRef pThis);

	/// <summary>
	/// By default, the keypress "+" increases magnification, and the keypress
	/// "-" decreases magnification. These can be changed to other key press
	/// values. Note that in either case, these keypresses cause the widget to
	/// emit the "vtkCommand::WidgetValueChangedEvent".
	/// </summary>
	public virtual sbyte GetKeyPressIncreaseValue()
	{
		return vtkMagnifierWidget_GetKeyPressIncreaseValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierWidget_GetMagnifierRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the representation as a vtkBorderRepresentation.
	/// </summary>
	public vtkMagnifierRepresentation GetMagnifierRepresentation()
	{
		vtkMagnifierRepresentation vtkMagnifierRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierWidget_GetMagnifierRepresentation_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMagnifierRepresentation2 = (vtkMagnifierRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMagnifierRepresentation2.Register(null);
			}
		}
		return vtkMagnifierRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMagnifierWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMagnifierWidget_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMagnifierWidget_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMagnifierWidget_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierWidget_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMagnifierWidget_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMagnifierWidget_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMagnifierWidget_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public new vtkMagnifierWidget NewInstance()
	{
		vtkMagnifierWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierWidget_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMagnifierWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMagnifierWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for class.
	/// </summary>
	public new static vtkMagnifierWidget SafeDownCast(vtkObjectBase o)
	{
		vtkMagnifierWidget vtkMagnifierWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMagnifierWidget_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMagnifierWidget2 = (vtkMagnifierWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMagnifierWidget2.Register(null);
			}
		}
		return vtkMagnifierWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierWidget_SetEnabled_12(HandleRef pThis, int enabling);

	/// <summary>
	/// Override superclasses' SetEnabled() method because the this widget
	/// must activate the representation.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkMagnifierWidget_SetEnabled_12(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierWidget_SetKeyPressDecreaseValue_13(HandleRef pThis, sbyte _arg);

	/// <summary>
	/// By default, the keypress "+" increases magnification, and the keypress
	/// "-" decreases magnification. These can be changed to other key press
	/// values. Note that in either case, these keypresses cause the widget to
	/// emit the "vtkCommand::WidgetValueChangedEvent".
	/// </summary>
	public virtual void SetKeyPressDecreaseValue(sbyte _arg)
	{
		vtkMagnifierWidget_SetKeyPressDecreaseValue_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierWidget_SetKeyPressIncreaseValue_14(HandleRef pThis, sbyte _arg);

	/// <summary>
	/// By default, the keypress "+" increases magnification, and the keypress
	/// "-" decreases magnification. These can be changed to other key press
	/// values. Note that in either case, these keypresses cause the widget to
	/// emit the "vtkCommand::WidgetValueChangedEvent".
	/// </summary>
	public virtual void SetKeyPressIncreaseValue(sbyte _arg)
	{
		vtkMagnifierWidget_SetKeyPressIncreaseValue_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMagnifierWidget_SetRepresentation_15(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkMagnifierRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkMagnifierRepresentation r)
	{
		vtkMagnifierWidget_SetRepresentation_15(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}
}
