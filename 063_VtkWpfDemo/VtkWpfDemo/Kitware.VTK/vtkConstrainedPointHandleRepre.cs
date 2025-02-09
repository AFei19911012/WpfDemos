using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkConstrainedPointHandleRepresentation
/// </summary>
/// <remarks>
///    point representation constrained to a 2D plane
///
/// This class is used to represent a vtkHandleWidget. It represents a
/// position in 3D world coordinates that is constrained to a specified plane.
/// The default look is to draw a white point when this widget is not selected
/// or active, a thin green circle when it is highlighted, and a thicker cyan
/// circle when it is active (being positioned). Defaults can be adjusted - but
/// take care to define cursor geometry that makes sense for this widget.
/// The geometry will be aligned on the constraining plane, with the plane
/// normal aligned with the X axis of the geometry (similar behavior to
/// vtkGlyph3D).
///
/// TODO: still need to work on
/// 1) translation when mouse is outside bounding planes
/// 2) size of the widget
///
/// </remarks>
/// <seealso>
///
/// vtkHandleRepresentation vtkHandleWidget
/// </seealso>
public class vtkConstrainedPointHandleRepresentation : vtkHandleRepresentation
{
	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public enum Oblique_WrapperEnum
	{
		/// <summary>enum member</summary>
		Oblique = 3,
		/// <summary>enum member</summary>
		XAxis = 0,
		/// <summary>enum member</summary>
		YAxis = 1,
		/// <summary>enum member</summary>
		ZAxis = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkConstrainedPointHandleRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkConstrainedPointHandleRepresentation()
	{
		MRClassNameKey = "class vtkConstrainedPointHandleRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkConstrainedPointHandleRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkConstrainedPointHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkConstrainedPointHandleRepresentation New()
	{
		vtkConstrainedPointHandleRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkConstrainedPointHandleRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkConstrainedPointHandleRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkConstrainedPointHandleRepresentation_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public void AddBoundingPlane(vtkPlane plane)
	{
		vtkConstrainedPointHandleRepresentation_AddBoundingPlane_01(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_BuildRepresentation_02(HandleRef pThis);

	/// <summary>
	/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkConstrainedPointHandleRepresentation_BuildRepresentation_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_CheckConstraint_03(HandleRef pThis, HandleRef renderer, IntPtr pos);

	/// <summary>
	/// Overridden from the base class. It converts the display
	/// co-ordinates to world co-ordinates. It returns 1 if the point lies
	/// within the constrained region, otherwise return 0
	/// </summary>
	public override int CheckConstraint(vtkRenderer renderer, IntPtr pos)
	{
		return vtkConstrainedPointHandleRepresentation_CheckConstraint_03(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkConstrainedPointHandleRepresentation_ComputeInteractionState_04(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetActiveCursorShape_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the shape of the cursor (handle) when it is active.
	/// This is the geometry that will be used when the mouse is
	/// close to the handle or if the user is manipulating the handle.
	/// </summary>
	public vtkPolyData GetActiveCursorShape()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_GetActiveCursorShape_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetActiveProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is the property used when the user is interacting
	/// with the handle.
	/// </summary>
	public virtual vtkProperty GetActiveProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_GetActiveProperty_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkConstrainedPointHandleRepresentation_GetActors_07(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkConstrainedPointHandleRepresentation_GetActors_07(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetBoundingPlanes_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public virtual vtkPlaneCollection GetBoundingPlanes()
	{
		vtkPlaneCollection vtkPlaneCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_GetBoundingPlanes_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlaneCollection2 = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlaneCollection2.Register(null);
			}
		}
		return vtkPlaneCollection2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetCursorShape_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the cursor shape. Keep in mind that the shape will be
	/// aligned with the constraining plane by orienting it such that
	/// the x axis of the geometry lies along the normal of the plane.
	/// </summary>
	public vtkPolyData GetCursorShape()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_GetCursorShape_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkConstrainedPointHandleRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkConstrainedPointHandleRepresentation_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkConstrainedPointHandleRepresentation_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkConstrainedPointHandleRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetObliquePlane_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the ProjectionNormal is set to Oblique, then this is the
	/// oblique plane used to constrain the handle position
	/// </summary>
	public virtual vtkPlane GetObliquePlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_GetObliquePlane_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetPosition_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the position of the point in display coordinates.  These are
	/// convenience methods that extend the superclasses' GetHandlePosition()
	/// method. Note that only the x-y coordinate values are used
	/// </summary>
	public IntPtr GetPosition()
	{
		return vtkConstrainedPointHandleRepresentation_GetPosition_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_GetPosition_14(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point in display coordinates.  These are
	/// convenience methods that extend the superclasses' GetHandlePosition()
	/// method. Note that only the x-y coordinate values are used
	/// </summary>
	public void GetPosition(IntPtr xyz)
	{
		vtkConstrainedPointHandleRepresentation_GetPosition_14(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormal_15(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public virtual int GetProjectionNormal()
	{
		return vtkConstrainedPointHandleRepresentation_GetProjectionNormal_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormalMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public virtual int GetProjectionNormalMaxValue()
	{
		return vtkConstrainedPointHandleRepresentation_GetProjectionNormalMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormalMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public virtual int GetProjectionNormalMinValue()
	{
		return vtkConstrainedPointHandleRepresentation_GetProjectionNormalMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkConstrainedPointHandleRepresentation_GetProjectionPosition_18(HandleRef pThis);

	/// <summary>
	/// The position of the bounding plane from the origin along the
	/// normal. The origin and normal are defined in the oblique plane
	/// when the ProjectionNormal is Oblique. For the X, Y, and Z
	/// axes projection normals, the normal is the axis direction, and
	/// the origin is (0,0,0).
	/// </summary>
	public virtual double GetProjectionPosition()
	{
		return vtkConstrainedPointHandleRepresentation_GetProjectionPosition_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is the property used when the handle is not active
	/// (the mouse is not near the handle)
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_GetProperty_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetSelectedProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is the property used when the mouse is near the
	/// handle (but the user is not yet interacting with it)
	/// </summary>
	public virtual vtkProperty GetSelectedProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_GetSelectedProperty_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkConstrainedPointHandleRepresentation_HasTranslucentPolygonalGeometry_21(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkConstrainedPointHandleRepresentation_HasTranslucentPolygonalGeometry_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_Highlight_22(HandleRef pThis, int highlight);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void Highlight(int highlight)
	{
		vtkConstrainedPointHandleRepresentation_Highlight_22(GetCppThis(), highlight);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_IsA_23(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkConstrainedPointHandleRepresentation_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_IsTypeOf_24(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkConstrainedPointHandleRepresentation_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkConstrainedPointHandleRepresentation NewInstance()
	{
		vtkConstrainedPointHandleRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkConstrainedPointHandleRepresentation_ReleaseGraphicsResources_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_RemoveAllBoundingPlanes_28(HandleRef pThis);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public void RemoveAllBoundingPlanes()
	{
		vtkConstrainedPointHandleRepresentation_RemoveAllBoundingPlanes_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_RemoveBoundingPlane_29(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public void RemoveBoundingPlane(vtkPlane plane)
	{
		vtkConstrainedPointHandleRepresentation_RemoveBoundingPlane_29(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_RenderOpaqueGeometry_30(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkConstrainedPointHandleRepresentation_RenderOpaqueGeometry_30(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_RenderOverlay_31(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkConstrainedPointHandleRepresentation_RenderOverlay_31(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkConstrainedPointHandleRepresentation_RenderTranslucentPolygonalGeometry_32(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkConstrainedPointHandleRepresentation_RenderTranslucentPolygonalGeometry_32(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkConstrainedPointHandleRepresentation_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkConstrainedPointHandleRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkConstrainedPointHandleRepresentation vtkConstrainedPointHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkConstrainedPointHandleRepresentation_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkConstrainedPointHandleRepresentation2 = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkConstrainedPointHandleRepresentation2.Register(null);
			}
		}
		return vtkConstrainedPointHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetActiveCursorShape_34(HandleRef pThis, HandleRef activeShape);

	/// <summary>
	/// Specify the shape of the cursor (handle) when it is active.
	/// This is the geometry that will be used when the mouse is
	/// close to the handle or if the user is manipulating the handle.
	/// </summary>
	public void SetActiveCursorShape(vtkPolyData activeShape)
	{
		vtkConstrainedPointHandleRepresentation_SetActiveCursorShape_34(GetCppThis(), activeShape?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_35(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public virtual void SetBoundingPlanes(vtkPlaneCollection arg0)
	{
		vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_36(HandleRef pThis, HandleRef planes);

	/// <summary>
	/// A collection of plane equations used to bound the position of the point.
	/// This is in addition to confining the point to a plane - these constraints
	/// are meant to, for example, keep a point within the extent of an image.
	/// Using a set of plane equations allows for more complex bounds (such as
	/// bounding a point to an oblique reliced image that has hexagonal shape)
	/// than a simple extent.
	/// </summary>
	public void SetBoundingPlanes(vtkPlanes planes)
	{
		vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_36(GetCppThis(), planes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetCursorShape_37(HandleRef pThis, HandleRef cursorShape);

	/// <summary>
	/// Specify the cursor shape. Keep in mind that the shape will be
	/// aligned with the constraining plane by orienting it such that
	/// the x axis of the geometry lies along the normal of the plane.
	/// </summary>
	public void SetCursorShape(vtkPolyData cursorShape)
	{
		vtkConstrainedPointHandleRepresentation_SetCursorShape_37(GetCppThis(), cursorShape?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetDisplayPosition_38(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Method overridden from Superclass. computes the world
	/// co-ordinates using GetIntersectionPosition()
	/// </summary>
	public override void SetDisplayPosition(IntPtr pos)
	{
		vtkConstrainedPointHandleRepresentation_SetDisplayPosition_38(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetObliquePlane_39(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// If the ProjectionNormal is set to Oblique, then this is the
	/// oblique plane used to constrain the handle position
	/// </summary>
	public void SetObliquePlane(vtkPlane arg0)
	{
		vtkConstrainedPointHandleRepresentation_SetObliquePlane_39(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetPosition_40(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the point in display coordinates.  These are
	/// convenience methods that extend the superclasses' GetHandlePosition()
	/// method. Note that only the x-y coordinate values are used
	/// </summary>
	public void SetPosition(double x, double y, double z)
	{
		vtkConstrainedPointHandleRepresentation_SetPosition_40(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetPosition_41(HandleRef pThis, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the point in display coordinates.  These are
	/// convenience methods that extend the superclasses' GetHandlePosition()
	/// method. Note that only the x-y coordinate values are used
	/// </summary>
	public void SetPosition(IntPtr xyz)
	{
		vtkConstrainedPointHandleRepresentation_SetPosition_41(GetCppThis(), xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormal_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public virtual void SetProjectionNormal(int _arg)
	{
		vtkConstrainedPointHandleRepresentation_SetProjectionNormal_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToOblique_43(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public void SetProjectionNormalToOblique()
	{
		vtkConstrainedPointHandleRepresentation_SetProjectionNormalToOblique_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToXAxis_44(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public void SetProjectionNormalToXAxis()
	{
		vtkConstrainedPointHandleRepresentation_SetProjectionNormalToXAxis_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToYAxis_45(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public void SetProjectionNormalToYAxis()
	{
		vtkConstrainedPointHandleRepresentation_SetProjectionNormalToYAxis_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToZAxis_46(HandleRef pThis);

	/// <summary>
	/// Set the projection normal to lie along the x, y, or z axis,
	/// or to be oblique. If it is oblique, then the plane is
	/// defined in the ObliquePlane ivar.
	/// </summary>
	public void SetProjectionNormalToZAxis()
	{
		vtkConstrainedPointHandleRepresentation_SetProjectionNormalToZAxis_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionPosition_47(HandleRef pThis, double position);

	/// <summary>
	/// The position of the bounding plane from the origin along the
	/// normal. The origin and normal are defined in the oblique plane
	/// when the ProjectionNormal is Oblique. For the X, Y, and Z
	/// axes projection normals, the normal is the axis direction, and
	/// the origin is (0,0,0).
	/// </summary>
	public void SetProjectionPosition(double position)
	{
		vtkConstrainedPointHandleRepresentation_SetProjectionPosition_47(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_SetRenderer_48(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void SetRenderer(vtkRenderer ren)
	{
		vtkConstrainedPointHandleRepresentation_SetRenderer_48(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_ShallowCopy_49(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkConstrainedPointHandleRepresentation_ShallowCopy_49(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_StartWidgetInteraction_50(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkConstrainedPointHandleRepresentation_StartWidgetInteraction_50(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkConstrainedPointHandleRepresentation_WidgetInteraction_51(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkConstrainedPointHandleRepresentation_WidgetInteraction_51(GetCppThis(), eventPos);
	}
}
