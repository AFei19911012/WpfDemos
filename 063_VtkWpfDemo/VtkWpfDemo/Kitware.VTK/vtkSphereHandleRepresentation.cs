using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphereHandleRepresentation
/// </summary>
/// <remarks>
///    A spherical rendition of point in 3D space
///
///
/// This class is a concrete implementation of vtkHandleRepresentation. It
/// renders handles as spherical blobs in 3D space.
///
/// </remarks>
/// <seealso>
///
/// vtkHandleRepresentation vtkHandleWidget vtkSphereSource
/// </seealso>
public class vtkSphereHandleRepresentation : vtkHandleRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphereHandleRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphereHandleRepresentation()
	{
		MRClassNameKey = "class vtkSphereHandleRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereHandleRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphereHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereHandleRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkSphereHandleRepresentation New()
	{
		vtkSphereHandleRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereHandleRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkSphereHandleRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphereHandleRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSphereHandleRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkSphereHandleRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereHandleRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkSphereHandleRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_DeepCopy_03(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void DeepCopy(vtkProp prop)
	{
		vtkSphereHandleRepresentation_DeepCopy_03(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_GetActors_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkSphereHandleRepresentation_GetActors_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereHandleRepresentation_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkSphereHandleRepresentation_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereHandleRepresentation_GetHotSpotSize_06(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSize()
	{
		return vtkSphereHandleRepresentation_GetHotSpotSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereHandleRepresentation_GetHotSpotSizeMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSizeMaxValue()
	{
		return vtkSphereHandleRepresentation_GetHotSpotSizeMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereHandleRepresentation_GetHotSpotSizeMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSizeMinValue()
	{
		return vtkSphereHandleRepresentation_GetHotSpotSizeMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereHandleRepresentation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphereHandleRepresentation_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphereHandleRepresentation_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphereHandleRepresentation_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereHandleRepresentation_GetProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereHandleRepresentation_GetProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereHandleRepresentation_GetSelectedProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public virtual vtkProperty GetSelectedProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereHandleRepresentation_GetSelectedProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphereHandleRepresentation_GetSphereRadius_13(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point moves
	/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
	/// the cursor focal point moves, which is constrained by the bounds of the
	/// point representation. (Note that the bounds can be scaled up using the
	/// right mouse button.)
	/// </summary>
	public double GetSphereRadius()
	{
		return vtkSphereHandleRepresentation_GetSphereRadius_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereHandleRepresentation_GetTranslationMode_14(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point moves
	/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
	/// the cursor focal point moves, which is constrained by the bounds of the
	/// point representation. (Note that the bounds can be scaled up using the
	/// right mouse button.)
	/// </summary>
	public virtual int GetTranslationMode()
	{
		return vtkSphereHandleRepresentation_GetTranslationMode_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereHandleRepresentation_HasTranslucentPolygonalGeometry_15(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkSphereHandleRepresentation_HasTranslucentPolygonalGeometry_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_Highlight_16(HandleRef pThis, int highlight);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void Highlight(int highlight)
	{
		vtkSphereHandleRepresentation_Highlight_16(GetCppThis(), highlight);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereHandleRepresentation_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphereHandleRepresentation_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereHandleRepresentation_IsTypeOf_18(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphereHandleRepresentation_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereHandleRepresentation_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkSphereHandleRepresentation NewInstance()
	{
		vtkSphereHandleRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereHandleRepresentation_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_PlaceWidget_21(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkSphereHandleRepresentation_PlaceWidget_21(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_RegisterPickers_22(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkSphereHandleRepresentation_RegisterPickers_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkSphereHandleRepresentation_ReleaseGraphicsResources_23(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereHandleRepresentation_RenderOpaqueGeometry_24(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkSphereHandleRepresentation_RenderOpaqueGeometry_24(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphereHandleRepresentation_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkSphereHandleRepresentation_RenderTranslucentPolygonalGeometry_25(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphereHandleRepresentation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkSphereHandleRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkSphereHandleRepresentation vtkSphereHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphereHandleRepresentation_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphereHandleRepresentation2 = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphereHandleRepresentation2.Register(null);
			}
		}
		return vtkSphereHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetDisplayPosition_27(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates. Note
	/// that if the position is set outside of the bounding box, it will be
	/// clamped to the boundary of the bounding box. This method overloads
	/// the superclasses' SetWorldPosition() and SetDisplayPosition() in
	/// order to set the focal point of the cursor properly.
	/// </summary>
	public override void SetDisplayPosition(IntPtr p)
	{
		vtkSphereHandleRepresentation_SetDisplayPosition_27(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetHandleSize_28(HandleRef pThis, double size);

	/// <summary>
	/// Overload the superclasses SetHandleSize() method to update internal
	/// variables.
	/// </summary>
	public override void SetHandleSize(double size)
	{
		vtkSphereHandleRepresentation_SetHandleSize_28(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetHotSpotSize_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual void SetHotSpotSize(double _arg)
	{
		vtkSphereHandleRepresentation_SetHotSpotSize_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetProperty_30(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public void SetProperty(vtkProperty arg0)
	{
		vtkSphereHandleRepresentation_SetProperty_30(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetSelectedProperty_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public void SetSelectedProperty(vtkProperty arg0)
	{
		vtkSphereHandleRepresentation_SetSelectedProperty_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetSphereRadius_32(HandleRef pThis, double arg0);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point moves
	/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
	/// the cursor focal point moves, which is constrained by the bounds of the
	/// point representation. (Note that the bounds can be scaled up using the
	/// right mouse button.)
	/// </summary>
	public void SetSphereRadius(double arg0)
	{
		vtkSphereHandleRepresentation_SetSphereRadius_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetTranslationMode_33(HandleRef pThis, int _arg);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point moves
	/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
	/// the cursor focal point moves, which is constrained by the bounds of the
	/// point representation. (Note that the bounds can be scaled up using the
	/// right mouse button.)
	/// </summary>
	public virtual void SetTranslationMode(int _arg)
	{
		vtkSphereHandleRepresentation_SetTranslationMode_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetVisibility_34(HandleRef pThis, int visible);

	/// <summary>
	/// Override to ensure that the internal actor's visibility is consistent with
	/// this representation's visibility. Inconsistency between the two would cause
	/// issues in picking logic which relies on individual view prop visibility to
	/// determine whether the prop is pickable.
	/// </summary>
	public override void SetVisibility(int visible)
	{
		vtkSphereHandleRepresentation_SetVisibility_34(GetCppThis(), visible);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_SetWorldPosition_35(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates. Note
	/// that if the position is set outside of the bounding box, it will be
	/// clamped to the boundary of the bounding box. This method overloads
	/// the superclasses' SetWorldPosition() and SetDisplayPosition() in
	/// order to set the focal point of the cursor properly.
	/// </summary>
	public override void SetWorldPosition(IntPtr p)
	{
		vtkSphereHandleRepresentation_SetWorldPosition_35(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_ShallowCopy_36(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkSphereHandleRepresentation_ShallowCopy_36(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_StartWidgetInteraction_37(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkSphereHandleRepresentation_StartWidgetInteraction_37(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_TranslationModeOff_38(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point moves
	/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
	/// the cursor focal point moves, which is constrained by the bounds of the
	/// point representation. (Note that the bounds can be scaled up using the
	/// right mouse button.)
	/// </summary>
	public virtual void TranslationModeOff()
	{
		vtkSphereHandleRepresentation_TranslationModeOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_TranslationModeOn_39(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated simultaneously as the point moves
	/// (i.e., the left and middle mouse buttons act the same).  Otherwise, only
	/// the cursor focal point moves, which is constrained by the bounds of the
	/// point representation. (Note that the bounds can be scaled up using the
	/// right mouse button.)
	/// </summary>
	public virtual void TranslationModeOn()
	{
		vtkSphereHandleRepresentation_TranslationModeOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphereHandleRepresentation_WidgetInteraction_40(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkSphereHandleRepresentation_WidgetInteraction_40(GetCppThis(), eventPos);
	}
}
