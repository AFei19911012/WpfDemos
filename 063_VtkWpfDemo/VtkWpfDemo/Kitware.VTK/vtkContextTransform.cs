using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContextTransform
/// </summary>
/// <remarks>
///    all children of this item are transformed
/// by the vtkTransform2D of this item.
///
///
/// This class can be used to transform all child items of this class. The
/// default transform is the identity.
/// </remarks>
public class vtkContextTransform : vtkAbstractContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContextTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContextTransform()
	{
		MRClassNameKey = "class vtkContextTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContextTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a vtkContextTransform object.
	/// </summary>
	public new static vtkContextTransform New()
	{
		vtkContextTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a vtkContextTransform object.
	/// </summary>
	public vtkContextTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContextTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextTransform_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContextTransform_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContextTransform_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContextTransform_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_GetPanModifier_03(HandleRef pThis);

	/// <summary>
	/// The modifier from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::NO_MODIFIER.
	/// </summary>
	public virtual int GetPanModifier()
	{
		return vtkContextTransform_GetPanModifier_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_GetPanMouseButton_04(HandleRef pThis);

	/// <summary>
	/// The mouse button from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::LEFT_BUTTON.
	/// </summary>
	public virtual int GetPanMouseButton()
	{
		return vtkContextTransform_GetPanMouseButton_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextTransform_GetPanYOnMouseWheel_05(HandleRef pThis);

	/// <summary>
	/// Whether to pan in the Y direction on mouse wheels. Default is false.
	/// </summary>
	public virtual bool GetPanYOnMouseWheel()
	{
		return (vtkContextTransform_GetPanYOnMouseWheel_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_GetSecondaryPanModifier_06(HandleRef pThis);

	/// <summary>
	/// A secondary modifier from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::NO_MODIFIER.
	/// </summary>
	public virtual int GetSecondaryPanModifier()
	{
		return vtkContextTransform_GetSecondaryPanModifier_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_GetSecondaryPanMouseButton_07(HandleRef pThis);

	/// <summary>
	/// A secondary mouse button from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::NO_BUTTON (disabled).
	/// </summary>
	public virtual int GetSecondaryPanMouseButton()
	{
		return vtkContextTransform_GetSecondaryPanMouseButton_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_GetSecondaryZoomModifier_08(HandleRef pThis);

	/// <summary>
	/// A secondary modifier from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::SHIFT_MODIFIER.
	/// </summary>
	public virtual int GetSecondaryZoomModifier()
	{
		return vtkContextTransform_GetSecondaryZoomModifier_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_GetSecondaryZoomMouseButton_09(HandleRef pThis);

	/// <summary>
	/// A secondary mouse button from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::LEFT_BUTTON.
	/// </summary>
	public virtual int GetSecondaryZoomMouseButton()
	{
		return vtkContextTransform_GetSecondaryZoomMouseButton_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextTransform_GetTransform_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the vtkTransform2D that controls object transformation.
	/// </summary>
	public virtual vtkTransform2D GetTransform()
	{
		vtkTransform2D vtkTransform2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextTransform_GetTransform_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2D2 = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2D2.Register(null);
			}
		}
		return vtkTransform2D2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_GetZoomModifier_11(HandleRef pThis);

	/// <summary>
	/// The modifier from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::NO_MODIFIER.
	/// </summary>
	public virtual int GetZoomModifier()
	{
		return vtkContextTransform_GetZoomModifier_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_GetZoomMouseButton_12(HandleRef pThis);

	/// <summary>
	/// The mouse button from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::RIGHT_BUTTON.
	/// </summary>
	public virtual int GetZoomMouseButton()
	{
		return vtkContextTransform_GetZoomMouseButton_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextTransform_GetZoomOnMouseWheel_13(HandleRef pThis);

	/// <summary>
	/// Whether to zoom on mouse wheels. Default is true.
	/// </summary>
	public virtual bool GetZoomOnMouseWheel()
	{
		return (vtkContextTransform_GetZoomOnMouseWheel_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_Identity_14(HandleRef pThis);

	/// <summary>
	/// Reset the transform to the identity transformation.
	/// </summary>
	public virtual void Identity()
	{
		vtkContextTransform_Identity_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContextTransform_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContextTransform_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContextTransform_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextTransform_MapFromParent_17(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Transforms a point from the parent coordinate system.
	/// </summary>
	public override vtkVector2f MapFromParent(vtkVector2f point)
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextTransform_MapFromParent_17(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextTransform_MapToParent_18(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Transforms a point to the parent coordinate system.
	/// </summary>
	public override vtkVector2f MapToParent(vtkVector2f point)
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextTransform_MapToParent_18(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextTransform_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContextTransform NewInstance()
	{
		vtkContextTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextTransform_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContextTransform_Paint_21(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item, called whenever the item needs to be drawn.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkContextTransform_Paint_21(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_PanYOnMouseWheelOff_22(HandleRef pThis);

	/// <summary>
	/// Whether to pan in the Y direction on mouse wheels. Default is false.
	/// </summary>
	public virtual void PanYOnMouseWheelOff()
	{
		vtkContextTransform_PanYOnMouseWheelOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_PanYOnMouseWheelOn_23(HandleRef pThis);

	/// <summary>
	/// Whether to pan in the Y direction on mouse wheels. Default is false.
	/// </summary>
	public virtual void PanYOnMouseWheelOn()
	{
		vtkContextTransform_PanYOnMouseWheelOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_Rotate_24(HandleRef pThis, float angle);

	/// <summary>
	/// Rotate the item by the specified angle.
	/// </summary>
	public virtual void Rotate(float angle)
	{
		vtkContextTransform_Rotate_24(GetCppThis(), angle);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContextTransform_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContextTransform SafeDownCast(vtkObjectBase o)
	{
		vtkContextTransform vtkContextTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContextTransform_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContextTransform2 = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContextTransform2.Register(null);
			}
		}
		return vtkContextTransform2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_Scale_26(HandleRef pThis, float dx, float dy);

	/// <summary>
	/// Scale the item by the specified amounts dx and dy in the x and y
	/// directions.
	/// </summary>
	public virtual void Scale(float dx, float dy)
	{
		vtkContextTransform_Scale_26(GetCppThis(), dx, dy);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetPanModifier_27(HandleRef pThis, int _arg);

	/// <summary>
	/// The modifier from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::NO_MODIFIER.
	/// </summary>
	public virtual void SetPanModifier(int _arg)
	{
		vtkContextTransform_SetPanModifier_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetPanMouseButton_28(HandleRef pThis, int _arg);

	/// <summary>
	/// The mouse button from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::LEFT_BUTTON.
	/// </summary>
	public virtual void SetPanMouseButton(int _arg)
	{
		vtkContextTransform_SetPanMouseButton_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetPanYOnMouseWheel_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to pan in the Y direction on mouse wheels. Default is false.
	/// </summary>
	public virtual void SetPanYOnMouseWheel(bool _arg)
	{
		vtkContextTransform_SetPanYOnMouseWheel_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetSecondaryPanModifier_30(HandleRef pThis, int _arg);

	/// <summary>
	/// A secondary modifier from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::NO_MODIFIER.
	/// </summary>
	public virtual void SetSecondaryPanModifier(int _arg)
	{
		vtkContextTransform_SetSecondaryPanModifier_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetSecondaryPanMouseButton_31(HandleRef pThis, int _arg);

	/// <summary>
	/// A secondary mouse button from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::NO_BUTTON (disabled).
	/// </summary>
	public virtual void SetSecondaryPanMouseButton(int _arg)
	{
		vtkContextTransform_SetSecondaryPanMouseButton_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetSecondaryZoomModifier_32(HandleRef pThis, int _arg);

	/// <summary>
	/// A secondary modifier from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::SHIFT_MODIFIER.
	/// </summary>
	public virtual void SetSecondaryZoomModifier(int _arg)
	{
		vtkContextTransform_SetSecondaryZoomModifier_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetSecondaryZoomMouseButton_33(HandleRef pThis, int _arg);

	/// <summary>
	/// A secondary mouse button from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::LEFT_BUTTON.
	/// </summary>
	public virtual void SetSecondaryZoomMouseButton(int _arg)
	{
		vtkContextTransform_SetSecondaryZoomMouseButton_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetZoomModifier_34(HandleRef pThis, int _arg);

	/// <summary>
	/// The modifier from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::NO_MODIFIER.
	/// </summary>
	public virtual void SetZoomModifier(int _arg)
	{
		vtkContextTransform_SetZoomModifier_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetZoomMouseButton_35(HandleRef pThis, int _arg);

	/// <summary>
	/// The mouse button from vtkContextMouseEvent to use for panning.
	/// Default is vtkContextMouseEvent::RIGHT_BUTTON.
	/// </summary>
	public virtual void SetZoomMouseButton(int _arg)
	{
		vtkContextTransform_SetZoomMouseButton_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_SetZoomOnMouseWheel_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to zoom on mouse wheels. Default is true.
	/// </summary>
	public virtual void SetZoomOnMouseWheel(bool _arg)
	{
		vtkContextTransform_SetZoomOnMouseWheel_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_Translate_37(HandleRef pThis, float dx, float dy);

	/// <summary>
	/// Translate the item by the specified amounts dx and dy in the x and y
	/// directions.
	/// </summary>
	public virtual void Translate(float dx, float dy)
	{
		vtkContextTransform_Translate_37(GetCppThis(), dx, dy);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_Update_38(HandleRef pThis);

	/// <summary>
	/// Perform any updates to the item that may be necessary before rendering.
	/// The scene should take care of calling this on all items before their
	/// Paint function is invoked.
	/// </summary>
	public override void Update()
	{
		vtkContextTransform_Update_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_ZoomOnMouseWheelOff_39(HandleRef pThis);

	/// <summary>
	/// Whether to zoom on mouse wheels. Default is true.
	/// </summary>
	public virtual void ZoomOnMouseWheelOff()
	{
		vtkContextTransform_ZoomOnMouseWheelOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContextTransform_ZoomOnMouseWheelOn_40(HandleRef pThis);

	/// <summary>
	/// Whether to zoom on mouse wheels. Default is true.
	/// </summary>
	public virtual void ZoomOnMouseWheelOn()
	{
		vtkContextTransform_ZoomOnMouseWheelOn_40(GetCppThis());
	}
}
