using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOrientedGlyphFocalPlaneContourRepresentation
/// </summary>
/// <remarks>
///    Contours constrained
/// to a focal plane.
///
///
/// This class is used to represent a contour drawn on the focal plane (usually
/// overlaid on top of an image or volume widget).
/// The class was written in order to be able to draw contours on a volume widget
/// and have the contours overlaid on the focal plane in order to do contour
/// segmentation.
///
/// </remarks>
/// <seealso>
///
/// vtkOrientedGlyphContourRepresentation
/// </seealso>
public class vtkOrientedGlyphFocalPlaneContourRepresentation : vtkFocalPlaneContourRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedGlyphFocalPlaneContourRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOrientedGlyphFocalPlaneContourRepresentation()
	{
		MRClassNameKey = "class vtkOrientedGlyphFocalPlaneContourRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedGlyphFocalPlaneContourRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOrientedGlyphFocalPlaneContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkOrientedGlyphFocalPlaneContourRepresentation New()
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkOrientedGlyphFocalPlaneContourRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
	/// These are the methods that the widget and its representation use to communicate with each
	/// other.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modified);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
	/// These are the methods that the widget and its representation use to communicate with each
	/// other.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modified)
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modified);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveCursorShape_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveCursorShape_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is the property used when the user is interacting
	/// with the handle.
	/// </summary>
	public virtual vtkProperty2D GetActiveProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveProperty_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_GetActors2D_05(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation_GetActors2D_05(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourPlaneDirectionCosines_06(HandleRef pThis, IntPtr origin, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Direction cosines of the plane on which the contour lies
	/// on in world co-ordinates. This would be the same matrix that would be
	/// set in vtkImageReslice or vtkImagePlaneWidget if there were a plane
	/// passing through the contour points. The origin must be the origin of the
	/// data under the contour.
	/// </summary>
	public vtkMatrix4x4 GetContourPlaneDirectionCosines(IntPtr origin)
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourPlaneDirectionCosines_06(GetCppThis(), origin, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourRepresentationAsPolyData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the points in this contour as a vtkPolyData.
	/// </summary>
	public override vtkPolyData GetContourRepresentationAsPolyData()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourRepresentationAsPolyData_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetCursorShape_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_GetCursorShape_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetLinesProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is the property used by the lines.
	/// </summary>
	public virtual vtkProperty2D GetLinesProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_GetLinesProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrientedGlyphFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrientedGlyphFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is the property used when the handle is not active
	/// (the mouse is not near the handle)
	/// </summary>
	public virtual vtkProperty2D GetProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_GetProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_HasTranslucentPolygonalGeometry_13(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_HasTranslucentPolygonalGeometry_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkOrientedGlyphFocalPlaneContourRepresentation NewInstance()
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation_ReleaseGraphicsResources_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOpaqueGeometry_19(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOpaqueGeometry_19(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOverlay_20(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOverlay_20(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderTranslucentPolygonalGeometry_21(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkOrientedGlyphFocalPlaneContourRepresentation_RenderTranslucentPolygonalGeometry_21(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkOrientedGlyphFocalPlaneContourRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation vtkOrientedGlyphFocalPlaneContourRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation2 = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOrientedGlyphFocalPlaneContourRepresentation2.Register(null);
			}
		}
		return vtkOrientedGlyphFocalPlaneContourRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetActiveCursorShape_23(HandleRef pThis, HandleRef activeShape);

	/// <summary>
	/// Specify the shape of the cursor (handle) when it is active.
	/// This is the geometry that will be used when the mouse is
	/// close to the handle or if the user is manipulating the handle.
	/// </summary>
	public void SetActiveCursorShape(vtkPolyData activeShape)
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation_SetActiveCursorShape_23(GetCppThis(), activeShape?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetCursorShape_24(HandleRef pThis, HandleRef cursorShape);

	/// <summary>
	/// Specify the cursor shape. Keep in mind that the shape will be
	/// aligned with the constraining plane by orienting it such that
	/// the x axis of the geometry lies along the normal of the plane.
	/// </summary>
	public void SetCursorShape(vtkPolyData cursorShape)
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation_SetCursorShape_24(GetCppThis(), cursorShape?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetRenderer_25(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
	/// These are the methods that the widget and its representation use to communicate with each
	/// other.
	/// </summary>
	public override void SetRenderer(vtkRenderer ren)
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation_SetRenderer_25(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_StartWidgetInteraction_26(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
	/// These are the methods that the widget and its representation use to communicate with each
	/// other.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation_StartWidgetInteraction_26(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_WidgetInteraction_27(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
	/// These are the methods that the widget and its representation use to communicate with each
	/// other.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkOrientedGlyphFocalPlaneContourRepresentation_WidgetInteraction_27(GetCppThis(), eventPos);
	}
}
