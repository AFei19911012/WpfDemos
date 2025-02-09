using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextRepresentation
/// </summary>
/// <remarks>
///    represent text for vtkTextWidget
///
/// This class represents text for a vtkTextWidget.  This class provides
/// support for interactively placing text on the 2D overlay plane. The text
/// is defined by an instance of vtkTextActor.
///
/// </remarks>
/// <seealso>
///
/// vtkTextRepresentation vtkBorderWidget vtkAbstractWidget vtkWidgetRepresentation
/// </seealso>
public class vtkTextRepresentation : vtkBorderRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextRepresentation()
	{
		MRClassNameKey = "class vtkTextRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public new static vtkTextRepresentation New()
	{
		vtkTextRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public vtkTextRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTextRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkTextRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_ExecuteTextActorModifiedEvent_02(HandleRef pThis, HandleRef obj, uint enumEvent, IntPtr p);

	/// <summary>
	/// Internal. Execute events observed by internal observer
	/// </summary>
	public void ExecuteTextActorModifiedEvent(vtkObject obj, uint enumEvent, IntPtr p)
	{
		vtkTextRepresentation_ExecuteTextActorModifiedEvent_02(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef), enumEvent, p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_ExecuteTextPropertyModifiedEvent_03(HandleRef pThis, HandleRef obj, uint enumEvent, IntPtr p);

	/// <summary>
	/// Internal. Execute events observed by internal observer
	/// </summary>
	public void ExecuteTextPropertyModifiedEvent(vtkObject obj, uint enumEvent, IntPtr p)
	{
		vtkTextRepresentation_ExecuteTextPropertyModifiedEvent_03(GetCppThis(), obj?.GetCppThis() ?? default(HandleRef), enumEvent, p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkTextRepresentation_GetActors2D_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextRepresentation_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextRepresentation_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingBottom_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the bottom border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingBottom()
	{
		return vtkTextRepresentation_GetPaddingBottom_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingBottomMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the bottom border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingBottomMaxValue()
	{
		return vtkTextRepresentation_GetPaddingBottomMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingBottomMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the bottom border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingBottomMinValue()
	{
		return vtkTextRepresentation_GetPaddingBottomMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingLeft_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the left border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingLeft()
	{
		return vtkTextRepresentation_GetPaddingLeft_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingLeftMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the left border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingLeftMaxValue()
	{
		return vtkTextRepresentation_GetPaddingLeftMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingLeftMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the left border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingLeftMinValue()
	{
		return vtkTextRepresentation_GetPaddingLeftMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingRight_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the right border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingRight()
	{
		return vtkTextRepresentation_GetPaddingRight_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingRightMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the right border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingRightMaxValue()
	{
		return vtkTextRepresentation_GetPaddingRightMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingRightMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the right border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingRightMinValue()
	{
		return vtkTextRepresentation_GetPaddingRightMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingTop_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the top border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingTop()
	{
		return vtkTextRepresentation_GetPaddingTop_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingTopMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the top border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingTopMaxValue()
	{
		return vtkTextRepresentation_GetPaddingTopMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_GetPaddingTopMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the text and the top border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual int GetPaddingTopMinValue()
	{
		return vtkTextRepresentation_GetPaddingTopMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_GetSize_19(HandleRef pThis, IntPtr size);

	/// <summary>
	/// Satisfy the superclasses API.
	/// </summary>
	public override void GetSize(IntPtr size)
	{
		vtkTextRepresentation_GetSize_19(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRepresentation_GetText_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the text string display by this representation.
	/// </summary>
	public string GetText()
	{
		return Marshal.PtrToStringAnsi(vtkTextRepresentation_GetText_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRepresentation_GetTextActor_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the vtkTextActor to manage. If not specified, then one
	/// is automatically created.
	/// </summary>
	public virtual vtkTextActor GetTextActor()
	{
		vtkTextActor vtkTextActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRepresentation_GetTextActor_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextActor2 = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextActor2.Register(null);
			}
		}
		return vtkTextActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_HasTranslucentPolygonalGeometry_22(HandleRef pThis);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkTextRepresentation_HasTranslucentPolygonalGeometry_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_IsA_23(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextRepresentation_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_IsTypeOf_24(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextRepresentation_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRepresentation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkTextRepresentation NewInstance()
	{
		vtkTextRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRepresentation_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTextRepresentation_ReleaseGraphicsResources_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_RenderOpaqueGeometry_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkTextRepresentation_RenderOpaqueGeometry_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_RenderOverlay_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkTextRepresentation_RenderOverlay_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRepresentation_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkTextRepresentation_RenderTranslucentPolygonalGeometry_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRepresentation_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkTextRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkTextRepresentation vtkTextRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRepresentation_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextRepresentation2 = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextRepresentation2.Register(null);
			}
		}
		return vtkTextRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetPadding_32(HandleRef pThis, int padding);

	/// <summary>
	/// Set the padding between the text and the left/right/top/bottom
	/// border, in pixels unit.
	/// Default is 0.
	/// </summary>
	public void SetPadding(int padding)
	{
		vtkTextRepresentation_SetPadding_32(GetCppThis(), padding);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetPaddingBottom_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the padding between the text and the bottom border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual void SetPaddingBottom(int _arg)
	{
		vtkTextRepresentation_SetPaddingBottom_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetPaddingLeft_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the padding between the text and the left border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual void SetPaddingLeft(int _arg)
	{
		vtkTextRepresentation_SetPaddingLeft_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetPaddingRight_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the padding between the text and the right border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual void SetPaddingRight(int _arg)
	{
		vtkTextRepresentation_SetPaddingRight_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetPaddingTop_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the padding between the text and the top border,
	/// in pixels unit.
	/// Default is 0.
	/// </summary>
	public virtual void SetPaddingTop(int _arg)
	{
		vtkTextRepresentation_SetPaddingTop_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetPosition_37(HandleRef pThis, double x, double y);

	/// <summary>
	/// Set the text position, by overriding the same function of
	/// vtkBorderRepresentation so that the Modified() will be called.
	/// </summary>
	public override void SetPosition(double x, double y)
	{
		vtkTextRepresentation_SetPosition_37(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetPosition_38(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set the text position, by overriding the same function of
	/// vtkBorderRepresentation so that the Modified() will be called.
	/// </summary>
	public override void SetPosition(IntPtr pos)
	{
		vtkTextRepresentation_SetPosition_38(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetText_39(HandleRef pThis, string text);

	/// <summary>
	/// Get/Set the text string display by this representation.
	/// </summary>
	public void SetText(string text)
	{
		vtkTextRepresentation_SetText_39(GetCppThis(), text);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetTextActor_40(HandleRef pThis, HandleRef textActor);

	/// <summary>
	/// Specify the vtkTextActor to manage. If not specified, then one
	/// is automatically created.
	/// </summary>
	public void SetTextActor(vtkTextActor textActor)
	{
		vtkTextRepresentation_SetTextActor_40(GetCppThis(), textActor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRepresentation_SetWindowLocation_41(HandleRef pThis, int enumLocation);

	/// <summary>
	/// Set the text position, by enumeration (
	/// vtkBorderRepresentation::AnyLocation = 0,
	/// vtkBorderRepresentation::LowerLeftCorner,
	/// vtkBorderRepresentation::LowerRightCorner,
	/// vtkBorderRepresentation::LowerCenter,
	/// vtkBorderRepresentation::UpperLeftCorner,
	/// vtkBorderRepresentation::UpperRightCorner,
	/// vtkBorderRepresentation::UpperCenter)
	/// related to the render window
	/// </summary>
	public override void SetWindowLocation(int enumLocation)
	{
		vtkTextRepresentation_SetWindowLocation_41(GetCppThis(), enumLocation);
	}
}
