using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOrientedGlyphContourRepresentation
/// </summary>
/// <remarks>
///    Default representation for the contour widget
///
/// This class provides the default concrete representation for the
/// vtkContourWidget. It works in conjunction with the
/// vtkContourLineInterpolator and vtkPointPlacer. See vtkContourWidget
/// for details.
/// </remarks>
/// <seealso>
///
/// vtkContourRepresentation vtkContourWidget vtkPointPlacer
/// vtkContourLineInterpolator
/// </seealso>
public class vtkOrientedGlyphContourRepresentation : vtkContourRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedGlyphContourRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOrientedGlyphContourRepresentation()
	{
		MRClassNameKey = "class vtkOrientedGlyphContourRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedGlyphContourRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOrientedGlyphContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkOrientedGlyphContourRepresentation New()
	{
		vtkOrientedGlyphContourRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkOrientedGlyphContourRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOrientedGlyphContourRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOrientedGlyphContourRepresentation_AlwaysOnTopOff_01(HandleRef pThis);

	/// <summary>
	/// Controls whether the contour widget should always appear on top
	/// of other actors in the scene. (In effect, this will disable OpenGL
	/// Depth buffer tests while rendering the contour).
	/// Default is to set it to false.
	/// </summary>
	public virtual void AlwaysOnTopOff()
	{
		vtkOrientedGlyphContourRepresentation_AlwaysOnTopOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_AlwaysOnTopOn_02(HandleRef pThis);

	/// <summary>
	/// Controls whether the contour widget should always appear on top
	/// of other actors in the scene. (In effect, this will disable OpenGL
	/// Depth buffer tests while rendering the contour).
	/// Default is to set it to false.
	/// </summary>
	public virtual void AlwaysOnTopOn()
	{
		vtkOrientedGlyphContourRepresentation_AlwaysOnTopOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_BuildRepresentation_03(HandleRef pThis);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkOrientedGlyphContourRepresentation_BuildRepresentation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphContourRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modified);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modified)
	{
		return vtkOrientedGlyphContourRepresentation_ComputeInteractionState_04(GetCppThis(), X, Y, modified);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetActiveCursorShape_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_GetActiveCursorShape_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetActiveProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_GetActiveProperty_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOrientedGlyphContourRepresentation_GetActors_07(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkOrientedGlyphContourRepresentation_GetActors_07(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphContourRepresentation_GetAlwaysOnTop_08(HandleRef pThis);

	/// <summary>
	/// Controls whether the contour widget should always appear on top
	/// of other actors in the scene. (In effect, this will disable OpenGL
	/// Depth buffer tests while rendering the contour).
	/// Default is to set it to false.
	/// </summary>
	public virtual int GetAlwaysOnTop()
	{
		return vtkOrientedGlyphContourRepresentation_GetAlwaysOnTop_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetBounds_09(HandleRef pThis);

	/// <summary>
	/// Return the bounds of the representation
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_GetBounds_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetContourRepresentationAsPolyData_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the points in this contour as a vtkPolyData.
	/// </summary>
	public override vtkPolyData GetContourRepresentationAsPolyData()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_GetContourRepresentationAsPolyData_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetCursorShape_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_GetCursorShape_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetLinesProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is the property used by the lines.
	/// </summary>
	public virtual vtkProperty GetLinesProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_GetLinesProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkOrientedGlyphContourRepresentation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOrientedGlyphContourRepresentation_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOrientedGlyphContourRepresentation_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOrientedGlyphContourRepresentation_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_GetProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkOrientedGlyphContourRepresentation_HasTranslucentPolygonalGeometry_16(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkOrientedGlyphContourRepresentation_HasTranslucentPolygonalGeometry_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphContourRepresentation_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOrientedGlyphContourRepresentation_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphContourRepresentation_IsTypeOf_18(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOrientedGlyphContourRepresentation_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkOrientedGlyphContourRepresentation NewInstance()
	{
		vtkOrientedGlyphContourRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkOrientedGlyphContourRepresentation_ReleaseGraphicsResources_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphContourRepresentation_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkOrientedGlyphContourRepresentation_RenderOpaqueGeometry_22(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphContourRepresentation_RenderOverlay_23(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkOrientedGlyphContourRepresentation_RenderOverlay_23(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOrientedGlyphContourRepresentation_RenderTranslucentPolygonalGeometry_24(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkOrientedGlyphContourRepresentation_RenderTranslucentPolygonalGeometry_24(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOrientedGlyphContourRepresentation_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkOrientedGlyphContourRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkOrientedGlyphContourRepresentation vtkOrientedGlyphContourRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOrientedGlyphContourRepresentation_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOrientedGlyphContourRepresentation2 = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOrientedGlyphContourRepresentation2.Register(null);
			}
		}
		return vtkOrientedGlyphContourRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_SetActiveCursorShape_26(HandleRef pThis, HandleRef activeShape);

	/// <summary>
	/// Specify the shape of the cursor (handle) when it is active.
	/// This is the geometry that will be used when the mouse is
	/// close to the handle or if the user is manipulating the handle.
	/// </summary>
	public void SetActiveCursorShape(vtkPolyData activeShape)
	{
		vtkOrientedGlyphContourRepresentation_SetActiveCursorShape_26(GetCppThis(), activeShape?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_SetAlwaysOnTop_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Controls whether the contour widget should always appear on top
	/// of other actors in the scene. (In effect, this will disable OpenGL
	/// Depth buffer tests while rendering the contour).
	/// Default is to set it to false.
	/// </summary>
	public virtual void SetAlwaysOnTop(int _arg)
	{
		vtkOrientedGlyphContourRepresentation_SetAlwaysOnTop_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_SetCursorShape_28(HandleRef pThis, HandleRef cursorShape);

	/// <summary>
	/// Specify the cursor shape. Keep in mind that the shape will be
	/// aligned with the constraining plane by orienting it such that
	/// the x axis of the geometry lies along the normal of the plane.
	/// </summary>
	public void SetCursorShape(vtkPolyData cursorShape)
	{
		vtkOrientedGlyphContourRepresentation_SetCursorShape_28(GetCppThis(), cursorShape?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_SetLineColor_29(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Convenience method to set the line color.
	/// Ideally one should use GetLinesProperty()-&gt;SetColor().
	/// </summary>
	public void SetLineColor(double r, double g, double b)
	{
		vtkOrientedGlyphContourRepresentation_SetLineColor_29(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_SetRenderer_30(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void SetRenderer(vtkRenderer ren)
	{
		vtkOrientedGlyphContourRepresentation_SetRenderer_30(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_SetShowSelectedNodes_31(HandleRef pThis, int arg0);

	/// <summary>
	/// A flag to indicate whether to show the Selected nodes
	/// Default is to set it to false.
	/// </summary>
	public override void SetShowSelectedNodes(int arg0)
	{
		vtkOrientedGlyphContourRepresentation_SetShowSelectedNodes_31(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_StartWidgetInteraction_32(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkOrientedGlyphContourRepresentation_StartWidgetInteraction_32(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOrientedGlyphContourRepresentation_WidgetInteraction_33(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses of vtkOrientedGlyphContourRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkOrientedGlyphContourRepresentation_WidgetInteraction_33(GetCppThis(), eventPos);
	}
}
