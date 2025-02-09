using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCaptionWidget
/// </summary>
/// <remarks>
///    widget for placing a caption (text plus leader)
///
/// This class provides support for interactively placing a caption on the 2D
/// overlay plane. A caption is defined by some text with a leader (e.g.,
/// arrow) that points from the text to a point in the scene. The caption is
/// represented by a vtkCaptionRepresentation. It uses the event bindings of
/// its superclass (vtkBorderWidget) to control the placement of the text, and
/// adds the ability to move the attachment point around. In addition, when
/// the caption text is selected, the widget emits a ActivateEvent that
/// observers can watch for. This is useful for opening GUI dialogoues to
/// adjust font characteristics, etc. (Please see the superclass for a
/// description of event bindings.)
///
/// Note that this widget extends the behavior of its superclass
/// vtkBorderWidget. The end point of the leader can be selected and
/// moved around with an internal vtkHandleWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkBorderWidget vtkTextWidget
/// </seealso>
public class vtkCaptionWidget : vtkBorderWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCaptionWidget()
	{
		MRClassNameKey = "class vtkCaptionWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCaptionWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkCaptionWidget New()
	{
		vtkCaptionWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkCaptionWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCaptionWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCaptionWidget_CreateDefaultRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Create the default widget representation if one is not set.
	/// </summary>
	public override void CreateDefaultRepresentation()
	{
		vtkCaptionWidget_CreateDefaultRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionWidget_GetCaptionActor2D_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a vtkCaptionActor2D to manage. This is convenient, alternative
	/// method to SetRepresentation(). It internally create a vtkCaptionRepresentation
	/// and then invokes vtkCaptionRepresentation::SetCaptionActor2D().
	/// </summary>
	public vtkCaptionActor2D GetCaptionActor2D()
	{
		vtkCaptionActor2D vtkCaptionActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionWidget_GetCaptionActor2D_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCaptionActor2D2 = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCaptionActor2D2.Register(null);
			}
		}
		return vtkCaptionActor2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCaptionWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCaptionWidget_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCaptionWidget_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCaptionWidget_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionWidget_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCaptionWidget_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionWidget_IsTypeOf_06(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCaptionWidget_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new vtkCaptionWidget NewInstance()
	{
		vtkCaptionWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionWidget_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static vtkCaptionWidget SafeDownCast(vtkObjectBase o)
	{
		vtkCaptionWidget vtkCaptionWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionWidget_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCaptionWidget2 = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCaptionWidget2.Register(null);
			}
		}
		return vtkCaptionWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionWidget_SetCaptionActor2D_10(HandleRef pThis, HandleRef capActor);

	/// <summary>
	/// Specify a vtkCaptionActor2D to manage. This is convenient, alternative
	/// method to SetRepresentation(). It internally create a vtkCaptionRepresentation
	/// and then invokes vtkCaptionRepresentation::SetCaptionActor2D().
	/// </summary>
	public void SetCaptionActor2D(vtkCaptionActor2D capActor)
	{
		vtkCaptionWidget_SetCaptionActor2D_10(GetCppThis(), capActor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionWidget_SetEnabled_11(HandleRef pThis, int enabling);

	/// <summary>
	/// Override superclasses' SetEnabled() method because the caption leader
	/// has its own dedicated widget.
	/// </summary>
	public override void SetEnabled(int enabling)
	{
		vtkCaptionWidget_SetEnabled_11(GetCppThis(), enabling);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionWidget_SetRepresentation_12(HandleRef pThis, HandleRef r);

	/// <summary>
	/// Specify an instance of vtkWidgetRepresentation used to represent this
	/// widget in the scene. Note that the representation is a subclass of vtkProp
	/// so it can be added to the renderer independent of the widget.
	/// </summary>
	public void SetRepresentation(vtkCaptionRepresentation r)
	{
		vtkCaptionWidget_SetRepresentation_12(GetCppThis(), r?.GetCppThis() ?? default(HandleRef));
	}
}
