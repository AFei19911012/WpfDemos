using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractPolygonalHandleRepresentation3D
/// </summary>
/// <remarks>
///    represent a user defined handle geometry in 3D while maintaining a fixed orientation
/// w.r.t the camera.
///
/// This class serves as the geometrical representation of a vtkHandleWidget.
/// The handle can be represented by an arbitrary polygonal data (vtkPolyData),
/// set via SetHandle(vtkPolyData *). The actual position of the handle
/// will be initially assumed to be (0,0,0). You can specify an offset from
/// this position if desired. This class differs from
/// vtkPolygonalHandleRepresentation3D in that the handle will always remain
/// front facing, ie it maintains a fixed orientation with respect to the
/// camera. This is done by using vtkFollowers internally to render the actors.
/// </remarks>
/// <seealso>
///
/// vtkPolygonalHandleRepresentation3D vtkHandleRepresentation vtkHandleWidget
/// </seealso>
public class vtkAbstractPolygonalHandleRepresentation3D : vtkHandleRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPolygonalHandleRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractPolygonalHandleRepresentation3D()
	{
		MRClassNameKey = "class vtkAbstractPolygonalHandleRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPolygonalHandleRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkAbstractPolygonalHandleRepresentation3D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkAbstractPolygonalHandleRepresentation3D_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_DeepCopy_03(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void DeepCopy(vtkProp prop)
	{
		vtkAbstractPolygonalHandleRepresentation3D_DeepCopy_03(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_GetActors_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkAbstractPolygonalHandleRepresentation3D_GetActors_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetHandle_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the handle polydata.
	/// </summary>
	public vtkPolyData GetHandle()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D_GetHandle_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_GetHandleVisibility_07(HandleRef pThis);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public virtual int GetHandleVisibility()
	{
		return vtkAbstractPolygonalHandleRepresentation3D_GetHandleVisibility_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelText_08(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the seed. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual string GetLabelText()
	{
		return Marshal.PtrToStringAnsi(vtkAbstractPolygonalHandleRepresentation3D_GetLabelText_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextActor_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the label text actor
	/// </summary>
	public virtual vtkFollower GetLabelTextActor()
	{
		vtkFollower vtkFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextActor_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFollower2 = (vtkFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFollower2.Register(null);
			}
		}
		return vtkFollower2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextScale_10(HandleRef pThis);

	/// <summary>
	/// Scale text (font size along each dimension).
	/// </summary>
	public virtual IntPtr GetLabelTextScale()
	{
		return vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextScale_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_GetLabelVisibility_11(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the seed. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual int GetLabelVisibility()
	{
		return vtkAbstractPolygonalHandleRepresentation3D_GetLabelVisibility_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D_GetProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetSelectedProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public virtual vtkProperty GetSelectedProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D_GetSelectedProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_GetSmoothMotion_16(HandleRef pThis);

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
		return vtkAbstractPolygonalHandleRepresentation3D_GetSmoothMotion_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetTransform_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the transform used to transform the generic handle polydata before
	/// placing it in the render window
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D_GetTransform_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOff_18(HandleRef pThis);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public virtual void HandleVisibilityOff()
	{
		vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOn_19(HandleRef pThis);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public virtual void HandleVisibilityOn()
	{
		vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_HasTranslucentPolygonalGeometry_20(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkAbstractPolygonalHandleRepresentation3D_HasTranslucentPolygonalGeometry_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_Highlight_21(HandleRef pThis, int highlight);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public override void Highlight(int highlight)
	{
		vtkAbstractPolygonalHandleRepresentation3D_Highlight_21(GetCppThis(), highlight);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractPolygonalHandleRepresentation3D_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_IsTypeOf_23(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractPolygonalHandleRepresentation3D_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOff_24(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the seed. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void LabelVisibilityOff()
	{
		vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOn_25(HandleRef pThis);

	/// <summary>
	/// A label may be associated with the seed. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void LabelVisibilityOn()
	{
		vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkAbstractPolygonalHandleRepresentation3D NewInstance()
	{
		vtkAbstractPolygonalHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_RegisterPickers_27(HandleRef pThis);

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
		vtkAbstractPolygonalHandleRepresentation3D_RegisterPickers_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_ReleaseGraphicsResources_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkAbstractPolygonalHandleRepresentation3D_ReleaseGraphicsResources_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_RenderOpaqueGeometry_29(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkAbstractPolygonalHandleRepresentation3D_RenderOpaqueGeometry_29(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractPolygonalHandleRepresentation3D_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkAbstractPolygonalHandleRepresentation3D_RenderTranslucentPolygonalGeometry_30(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkAbstractPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractPolygonalHandleRepresentation3D vtkAbstractPolygonalHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPolygonalHandleRepresentation3D2 = (vtkAbstractPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPolygonalHandleRepresentation3D2.Register(null);
			}
		}
		return vtkAbstractPolygonalHandleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetDisplayPosition_32(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates.
	/// </summary>
	public override void SetDisplayPosition(IntPtr p)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetDisplayPosition_32(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetHandle_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the handle polydata.
	/// </summary>
	public void SetHandle(vtkPolyData arg0)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetHandle_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetHandleVisibility_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Toggle the visibility of the handle on and off
	/// </summary>
	public virtual void SetHandleVisibility(int _arg)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetHandleVisibility_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelText_35(HandleRef pThis, string label);

	/// <summary>
	/// A label may be associated with the seed. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void SetLabelText(string label)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetLabelText_35(GetCppThis(), label);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_36(HandleRef pThis, IntPtr scale);

	/// <summary>
	/// Scale text (font size along each dimension).
	/// </summary>
	public virtual void SetLabelTextScale(IntPtr scale)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_36(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_37(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Scale text (font size along each dimension).
	/// </summary>
	public void SetLabelTextScale(double x, double y, double z)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_37(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelVisibility_38(HandleRef pThis, int _arg);

	/// <summary>
	/// A label may be associated with the seed. The string can be set via
	/// SetLabelText. The visibility of the label can be turned on / off.
	/// </summary>
	public virtual void SetLabelVisibility(int _arg)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetLabelVisibility_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetProperty_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public void SetProperty(vtkProperty arg0)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetProperty_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetSelectedProperty_40(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties when unselected and selected.
	/// </summary>
	public void SetSelectedProperty(vtkProperty arg0)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetSelectedProperty_40(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetSmoothMotion_41(HandleRef pThis, int _arg);

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
		vtkAbstractPolygonalHandleRepresentation3D_SetSmoothMotion_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetUniformScale_42(HandleRef pThis, double scale);

	/// <summary>
	/// The handle may be scaled uniformly in all three dimensions using this
	/// API. The handle can also be scaled interactively using the right
	/// mouse button.
	/// </summary>
	public virtual void SetUniformScale(double scale)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetUniformScale_42(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetWorldPosition_43(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates.
	/// </summary>
	public override void SetWorldPosition(IntPtr p)
	{
		vtkAbstractPolygonalHandleRepresentation3D_SetWorldPosition_43(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_ShallowCopy_44(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkAbstractPolygonalHandleRepresentation3D_ShallowCopy_44(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SmoothMotionOff_45(HandleRef pThis);

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
		vtkAbstractPolygonalHandleRepresentation3D_SmoothMotionOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SmoothMotionOn_46(HandleRef pThis);

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
		vtkAbstractPolygonalHandleRepresentation3D_SmoothMotionOn_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_StartWidgetInteraction_47(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkAbstractPolygonalHandleRepresentation3D_StartWidgetInteraction_47(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractPolygonalHandleRepresentation3D_WidgetInteraction_48(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkAbstractPolygonalHandleRepresentation3D_WidgetInteraction_48(GetCppThis(), eventPos);
	}
}
