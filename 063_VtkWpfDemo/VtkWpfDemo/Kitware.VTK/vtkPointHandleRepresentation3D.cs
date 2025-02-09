using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointHandleRepresentation3D
/// </summary>
/// <remarks>
///    represent the position of a point in 3D space
///
/// This class is used to represent a vtkHandleWidget. It represents a position
/// in 3D world coordinates using a x-y-z cursor. The cursor can be configured to
/// show a bounding box and/or shadows.
///
/// </remarks>
/// <seealso>
///
/// vtkHandleRepresentation vtkHandleWidget vtkCursor3D
/// </seealso>
public class vtkPointHandleRepresentation3D : vtkHandleRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointHandleRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointHandleRepresentation3D()
	{
		MRClassNameKey = "class vtkPointHandleRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointHandleRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPointHandleRepresentation3D New()
	{
		vtkPointHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPointHandleRepresentation3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointHandleRepresentation3D_AllOff_01(HandleRef pThis);

	/// <summary>
	/// Convenience methods to turn outline and shadows on and off.
	/// </summary>
	public void AllOff()
	{
		vtkPointHandleRepresentation3D_AllOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_AllOn_02(HandleRef pThis);

	/// <summary>
	/// Convenience methods to turn outline and shadows on and off.
	/// </summary>
	public void AllOn()
	{
		vtkPointHandleRepresentation3D_AllOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_BuildRepresentation_03(HandleRef pThis);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkPointHandleRepresentation3D_BuildRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_ComplexInteraction_04(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkPointHandleRepresentation3D_ComplexInteraction_04(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_ComputeComplexInteractionState_05(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
	{
		return vtkPointHandleRepresentation3D_ComputeComplexInteractionState_05(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_ComputeInteractionState_06(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkPointHandleRepresentation3D_ComputeInteractionState_06(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_DeepCopy_07(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void DeepCopy(vtkProp prop)
	{
		vtkPointHandleRepresentation3D_DeepCopy_07(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_GetActors_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkPointHandleRepresentation3D_GetActors_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleRepresentation3D_GetBounds_09(HandleRef pThis);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkPointHandleRepresentation3D_GetBounds_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSize_10(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSize()
	{
		return vtkPointHandleRepresentation3D_GetHotSpotSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSizeMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSizeMaxValue()
	{
		return vtkPointHandleRepresentation3D_GetHotSpotSizeMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSizeMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual double GetHotSpotSizeMinValue()
	{
		return vtkPointHandleRepresentation3D_GetHotSpotSizeMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointHandleRepresentation3D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointHandleRepresentation3D_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_GetOutline_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public int GetOutline()
	{
		return vtkPointHandleRepresentation3D_GetOutline_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleRepresentation3D_GetProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointHandleRepresentation3D_GetProperty_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPointHandleRepresentation3D_GetSelectedProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public virtual vtkProperty GetSelectedProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointHandleRepresentation3D_GetSelectedProperty_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPointHandleRepresentation3D_GetSmoothMotion_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
	/// which constrains the widget to the surface of a mesh. In such cases,
	/// inherent restrictions on handle placement might conflict with a request
	/// for smooth motion of the handles.
	/// </summary>
	public virtual int GetSmoothMotion()
	{
		return vtkPointHandleRepresentation3D_GetSmoothMotion_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_GetTranslationMode_19(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated and sized simultaneously as the
	/// point moves (i.e., the left and middle mouse buttons act the same). If
	/// translation mode is off, the cursor does not scale itself (based on the
	/// specified handle size), and the bounding box and shadows do not move or
	/// size themselves as the cursor focal point moves, which is constrained by
	/// the bounds of the point representation. (Note that the bounds can be
	/// scaled up using the right mouse button, and the bounds can be manually
	/// set with the SetBounds() method.)
	/// </summary>
	public virtual int GetTranslationMode()
	{
		return vtkPointHandleRepresentation3D_GetTranslationMode_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_GetXShadows_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public int GetXShadows()
	{
		return vtkPointHandleRepresentation3D_GetXShadows_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_GetYShadows_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public int GetYShadows()
	{
		return vtkPointHandleRepresentation3D_GetYShadows_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_GetZShadows_22(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public int GetZShadows()
	{
		return vtkPointHandleRepresentation3D_GetZShadows_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_HasTranslucentPolygonalGeometry_23(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkPointHandleRepresentation3D_HasTranslucentPolygonalGeometry_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_Highlight_24(HandleRef pThis, int highlight);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void Highlight(int highlight)
	{
		vtkPointHandleRepresentation3D_Highlight_24(GetCppThis(), highlight);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_IsA_25(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointHandleRepresentation3D_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_IsTypeOf_26(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointHandleRepresentation3D_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleRepresentation3D_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkPointHandleRepresentation3D NewInstance()
	{
		vtkPointHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointHandleRepresentation3D_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_OutlineOff_29(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public void OutlineOff()
	{
		vtkPointHandleRepresentation3D_OutlineOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_OutlineOn_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public void OutlineOn()
	{
		vtkPointHandleRepresentation3D_OutlineOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_PlaceWidget_31(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkPointHandleRepresentation3D_PlaceWidget_31(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_RegisterPickers_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
	/// which constrains the widget to the surface of a mesh. In such cases,
	/// inherent restrictions on handle placement might conflict with a request
	/// for smooth motion of the handles.
	/// </summary>
	public override void RegisterPickers()
	{
		vtkPointHandleRepresentation3D_RegisterPickers_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_ReleaseGraphicsResources_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkPointHandleRepresentation3D_ReleaseGraphicsResources_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_RenderOpaqueGeometry_34(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkPointHandleRepresentation3D_RenderOpaqueGeometry_34(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointHandleRepresentation3D_RenderTranslucentPolygonalGeometry_35(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkPointHandleRepresentation3D_RenderTranslucentPolygonalGeometry_35(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointHandleRepresentation3D_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkPointHandleRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointHandleRepresentation3D_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointHandleRepresentation3D_SetDisplayPosition_37(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates. Note
	/// that if the position is set outside of the bounding box, it will be
	/// clamped to the boundary of the bounding box. This method overloads
	/// the superclasses' SetWorldPosition() and SetDisplayPosition() in
	/// order to set the focal point of the cursor properly.
	/// </summary>
	public override void SetDisplayPosition(IntPtr p)
	{
		vtkPointHandleRepresentation3D_SetDisplayPosition_37(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetHandleSize_38(HandleRef pThis, double size);

	/// <summary>
	/// Overload the superclasses SetHandleSize() method to update internal variables.
	/// </summary>
	public override void SetHandleSize(double size)
	{
		vtkPointHandleRepresentation3D_SetHandleSize_38(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetHotSpotSize_39(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the "hot spot" size; i.e., the region around the focus, in which the
	/// motion vector is used to control the constrained sliding action. Note the
	/// size is specified as a fraction of the length of the diagonal of the
	/// point widget's bounding box.
	/// </summary>
	public virtual void SetHotSpotSize(double _arg)
	{
		vtkPointHandleRepresentation3D_SetHotSpotSize_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetOutline_40(HandleRef pThis, int o);

	/// <summary>
	/// Turn on/off the wireframe bounding box.
	/// </summary>
	public void SetOutline(int o)
	{
		vtkPointHandleRepresentation3D_SetOutline_40(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetProperty_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public void SetProperty(vtkProperty arg0)
	{
		vtkPointHandleRepresentation3D_SetProperty_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetSelectedProperty_42(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public void SetSelectedProperty(vtkProperty arg0)
	{
		vtkPointHandleRepresentation3D_SetSelectedProperty_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetSmoothMotion_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
	/// which constrains the widget to the surface of a mesh. In such cases,
	/// inherent restrictions on handle placement might conflict with a request
	/// for smooth motion of the handles.
	/// </summary>
	public virtual void SetSmoothMotion(int _arg)
	{
		vtkPointHandleRepresentation3D_SetSmoothMotion_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetTranslationMode_44(HandleRef pThis, int mode);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated and sized simultaneously as the
	/// point moves (i.e., the left and middle mouse buttons act the same). If
	/// translation mode is off, the cursor does not scale itself (based on the
	/// specified handle size), and the bounding box and shadows do not move or
	/// size themselves as the cursor focal point moves, which is constrained by
	/// the bounds of the point representation. (Note that the bounds can be
	/// scaled up using the right mouse button, and the bounds can be manually
	/// set with the SetBounds() method.)
	/// </summary>
	public void SetTranslationMode(int mode)
	{
		vtkPointHandleRepresentation3D_SetTranslationMode_44(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetVisibility_45(HandleRef pThis, int visible);

	/// <summary>
	/// Override to ensure that the internal actor's visibility is consistent with
	/// this representation's visibility. Inconsistency between the two would cause
	/// issues in picking logic which relies on individual view prop visibility to
	/// determine whether the prop is pickable.
	/// </summary>
	public override void SetVisibility(int visible)
	{
		vtkPointHandleRepresentation3D_SetVisibility_45(GetCppThis(), visible);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetWorldPosition_46(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates. Note
	/// that if the position is set outside of the bounding box, it will be
	/// clamped to the boundary of the bounding box. This method overloads
	/// the superclasses' SetWorldPosition() and SetDisplayPosition() in
	/// order to set the focal point of the cursor properly.
	/// </summary>
	public override void SetWorldPosition(IntPtr p)
	{
		vtkPointHandleRepresentation3D_SetWorldPosition_46(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetXShadows_47(HandleRef pThis, int o);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public void SetXShadows(int o)
	{
		vtkPointHandleRepresentation3D_SetXShadows_47(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetYShadows_48(HandleRef pThis, int o);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public void SetYShadows(int o)
	{
		vtkPointHandleRepresentation3D_SetYShadows_48(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SetZShadows_49(HandleRef pThis, int o);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public void SetZShadows(int o)
	{
		vtkPointHandleRepresentation3D_SetZShadows_49(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_ShallowCopy_50(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkPointHandleRepresentation3D_ShallowCopy_50(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SmoothMotionOff_51(HandleRef pThis);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
	/// which constrains the widget to the surface of a mesh. In such cases,
	/// inherent restrictions on handle placement might conflict with a request
	/// for smooth motion of the handles.
	/// </summary>
	public virtual void SmoothMotionOff()
	{
		vtkPointHandleRepresentation3D_SmoothMotionOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_SmoothMotionOn_52(HandleRef pThis);

	/// <summary>
	/// Turn on/off smooth motion of the handle. See the documentation of
	/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
	/// in certain applications the user may want to turn it off. For instance
	/// when using certain specific PointPlacer's with the representation such
	/// as the vtkCellCentersPointPlacer, which causes the representation to
	/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
	/// which constrains the widget to the surface of a mesh. In such cases,
	/// inherent restrictions on handle placement might conflict with a request
	/// for smooth motion of the handles.
	/// </summary>
	public virtual void SmoothMotionOn()
	{
		vtkPointHandleRepresentation3D_SmoothMotionOn_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_StartComplexInteraction_53(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkPointHandleRepresentation3D_StartComplexInteraction_53(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_StartWidgetInteraction_54(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkPointHandleRepresentation3D_StartWidgetInteraction_54(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_TranslationModeOff_55(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated and sized simultaneously as the
	/// point moves (i.e., the left and middle mouse buttons act the same). If
	/// translation mode is off, the cursor does not scale itself (based on the
	/// specified handle size), and the bounding box and shadows do not move or
	/// size themselves as the cursor focal point moves, which is constrained by
	/// the bounds of the point representation. (Note that the bounds can be
	/// scaled up using the right mouse button, and the bounds can be manually
	/// set with the SetBounds() method.)
	/// </summary>
	public virtual void TranslationModeOff()
	{
		vtkPointHandleRepresentation3D_TranslationModeOff_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_TranslationModeOn_56(HandleRef pThis);

	/// <summary>
	/// If translation mode is on, as the widget is moved the bounding box,
	/// shadows, and cursor are all translated and sized simultaneously as the
	/// point moves (i.e., the left and middle mouse buttons act the same). If
	/// translation mode is off, the cursor does not scale itself (based on the
	/// specified handle size), and the bounding box and shadows do not move or
	/// size themselves as the cursor focal point moves, which is constrained by
	/// the bounds of the point representation. (Note that the bounds can be
	/// scaled up using the right mouse button, and the bounds can be manually
	/// set with the SetBounds() method.)
	/// </summary>
	public virtual void TranslationModeOn()
	{
		vtkPointHandleRepresentation3D_TranslationModeOn_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_WidgetInteraction_57(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkPointHandleRepresentation3D_WidgetInteraction_57(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_XShadowsOff_58(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public void XShadowsOff()
	{
		vtkPointHandleRepresentation3D_XShadowsOff_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_XShadowsOn_59(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe x-shadows.
	/// </summary>
	public void XShadowsOn()
	{
		vtkPointHandleRepresentation3D_XShadowsOn_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_YShadowsOff_60(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public void YShadowsOff()
	{
		vtkPointHandleRepresentation3D_YShadowsOff_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_YShadowsOn_61(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe y-shadows.
	/// </summary>
	public void YShadowsOn()
	{
		vtkPointHandleRepresentation3D_YShadowsOn_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_ZShadowsOff_62(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public void ZShadowsOff()
	{
		vtkPointHandleRepresentation3D_ZShadowsOff_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointHandleRepresentation3D_ZShadowsOn_63(HandleRef pThis);

	/// <summary>
	/// Turn on/off the wireframe z-shadows.
	/// </summary>
	public void ZShadowsOn()
	{
		vtkPointHandleRepresentation3D_ZShadowsOn_63(GetCppThis());
	}
}
