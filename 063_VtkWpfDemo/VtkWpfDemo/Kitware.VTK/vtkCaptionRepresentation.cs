using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCaptionRepresentation
/// </summary>
/// <remarks>
///    represents vtkCaptionWidget in the scene
///
/// This class represents vtkCaptionWidget. A caption is defined by some text
/// with a leader (e.g., arrow) that points from the text to a point in the
/// scene. The caption is defined by an instance of vtkCaptionActor2D. It uses
/// the event bindings of its superclass (vtkBorderWidget) to control the
/// placement of the text, and adds the ability to move the attachment point
/// around. In addition, when the caption text is selected, the widget emits a
/// ActivateEvent that observers can watch for. This is useful for opening GUI
/// dialogoues to adjust font characteristics, etc. (Please see the superclass
/// for a description of event bindings.)
///
/// Note that this widget extends the behavior of its superclass
/// vtkBorderRepresentation.
///
/// </remarks>
/// <seealso>
///
/// vtkCaptionWidget vtkBorderWidget vtkBorderRepresentation vtkCaptionActor
/// </seealso>
public class vtkCaptionRepresentation : vtkBorderRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCaptionRepresentation()
	{
		MRClassNameKey = "class vtkCaptionRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCaptionRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkCaptionRepresentation New()
	{
		vtkCaptionRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkCaptionRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCaptionRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCaptionRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCaptionRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionRepresentation_GetActors2D_02(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkCaptionRepresentation_GetActors2D_02(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionRepresentation_GetAnchorPosition_03(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Specify the position of the anchor (i.e., the point that the caption is anchored to).
	/// Note that the position should be specified in world coordinates.
	/// </summary>
	public void GetAnchorPosition(IntPtr pos)
	{
		vtkCaptionRepresentation_GetAnchorPosition_03(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionRepresentation_GetAnchorRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the instances of vtkPointHandleRepresentation3D used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public virtual vtkPointHandleRepresentation3D GetAnchorRepresentation()
	{
		vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionRepresentation_GetAnchorRepresentation_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointHandleRepresentation3D2 = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointHandleRepresentation3D2.Register(null);
			}
		}
		return vtkPointHandleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionRepresentation_GetCaptionActor2D_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the vtkCaptionActor2D to manage. If not specified, then one
	/// is automatically created.
	/// </summary>
	public virtual vtkCaptionActor2D GetCaptionActor2D()
	{
		vtkCaptionActor2D vtkCaptionActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionRepresentation_GetCaptionActor2D_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkCaptionRepresentation_GetFontFactor_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts
	/// of the caption when the text actor's ScaledText is OFF
	/// </summary>
	public virtual double GetFontFactor()
	{
		return vtkCaptionRepresentation_GetFontFactor_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCaptionRepresentation_GetFontFactorMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts
	/// of the caption when the text actor's ScaledText is OFF
	/// </summary>
	public virtual double GetFontFactorMaxValue()
	{
		return vtkCaptionRepresentation_GetFontFactorMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCaptionRepresentation_GetFontFactorMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts
	/// of the caption when the text actor's ScaledText is OFF
	/// </summary>
	public virtual double GetFontFactorMinValue()
	{
		return vtkCaptionRepresentation_GetFontFactorMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCaptionRepresentation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCaptionRepresentation_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCaptionRepresentation_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCaptionRepresentation_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionRepresentation_GetSize_11(HandleRef pThis, IntPtr size);

	/// <summary>
	/// Satisfy the superclasses API.
	/// </summary>
	public override void GetSize(IntPtr size)
	{
		vtkCaptionRepresentation_GetSize_11(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionRepresentation_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCaptionRepresentation_HasTranslucentPolygonalGeometry_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionRepresentation_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCaptionRepresentation_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionRepresentation_IsTypeOf_14(string type);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCaptionRepresentation_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionRepresentation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new vtkCaptionRepresentation NewInstance()
	{
		vtkCaptionRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionRepresentation_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionRepresentation_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCaptionRepresentation_ReleaseGraphicsResources_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionRepresentation_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCaptionRepresentation_RenderOpaqueGeometry_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionRepresentation_RenderOverlay_19(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkCaptionRepresentation_RenderOverlay_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCaptionRepresentation_RenderTranslucentPolygonalGeometry_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK class methods.
	/// </summary>
	public new static vtkCaptionRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCaptionRepresentation vtkCaptionRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionRepresentation_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCaptionRepresentation2 = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCaptionRepresentation2.Register(null);
			}
		}
		return vtkCaptionRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionRepresentation_SetAnchorPosition_22(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Specify the position of the anchor (i.e., the point that the caption is anchored to).
	/// Note that the position should be specified in world coordinates.
	/// </summary>
	public void SetAnchorPosition(IntPtr pos)
	{
		vtkCaptionRepresentation_SetAnchorPosition_22(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionRepresentation_SetAnchorRepresentation_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the instances of vtkPointHandleRepresentation3D used to implement this
	/// representation. Normally default representations are created, but you can
	/// specify the ones you want to use.
	/// </summary>
	public void SetAnchorRepresentation(vtkPointHandleRepresentation3D arg0)
	{
		vtkCaptionRepresentation_SetAnchorRepresentation_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionRepresentation_SetCaptionActor2D_24(HandleRef pThis, HandleRef captionActor);

	/// <summary>
	/// Specify the vtkCaptionActor2D to manage. If not specified, then one
	/// is automatically created.
	/// </summary>
	public void SetCaptionActor2D(vtkCaptionActor2D captionActor)
	{
		vtkCaptionRepresentation_SetCaptionActor2D_24(GetCppThis(), captionActor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionRepresentation_SetFontFactor_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the factor that controls the overall size of the fonts
	/// of the caption when the text actor's ScaledText is OFF
	/// </summary>
	public virtual void SetFontFactor(double _arg)
	{
		vtkCaptionRepresentation_SetFontFactor_25(GetCppThis(), _arg);
	}
}
