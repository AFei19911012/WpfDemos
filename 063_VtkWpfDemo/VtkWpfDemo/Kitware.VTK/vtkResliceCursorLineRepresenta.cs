using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkResliceCursorLineRepresentation
/// </summary>
/// <remarks>
///    represent the vtkResliceCursorWidget
///
/// This class provides a representation for the reslice cursor widget. It
/// consists of two cross sectional hairs, with an optional thickness. The
/// hairs may have a hole in the center. These may be translated or rotated
/// independent of each other in the view. The result is used to reslice
/// the data along these cross sections. This allows the user to perform
/// multi-planar thin or thick reformat of the data on an image view, rather
/// than a 3D view.
/// </remarks>
/// <seealso>
///
/// vtkResliceCursorWidget vtkResliceCursor vtkResliceCursorPolyDataAlgorithm
/// vtkResliceCursorRepresentation vtkResliceCursorThickLineRepresentation
/// vtkResliceCursorActor vtkImagePlaneWidget
/// </seealso>
public class vtkResliceCursorLineRepresentation : vtkResliceCursorRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorLineRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResliceCursorLineRepresentation()
	{
		MRClassNameKey = "class vtkResliceCursorLineRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorLineRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResliceCursorLineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorLineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkResliceCursorLineRepresentation New()
	{
		vtkResliceCursorLineRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorLineRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkResliceCursorLineRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResliceCursorLineRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkResliceCursorLineRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkResliceCursorLineRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorLineRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkResliceCursorLineRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorLineRepresentation_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Get the bounds of this prop. This simply returns the bounds of the
	/// reslice cursor object.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkResliceCursorLineRepresentation_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorLineRepresentation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResliceCursorLineRepresentation_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResliceCursorLineRepresentation_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResliceCursorLineRepresentation_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorLineRepresentation_GetResliceCursor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the reslice cursor.
	/// </summary>
	public override vtkResliceCursor GetResliceCursor()
	{
		vtkResliceCursor vtkResliceCursor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorLineRepresentation_GetResliceCursor_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursor2 = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursor2.Register(null);
			}
		}
		return vtkResliceCursor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorLineRepresentation_GetResliceCursorActor_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the reslice cursor actor. You must set the reslice cursor on this
	/// class
	/// </summary>
	public virtual vtkResliceCursorActor GetResliceCursorActor()
	{
		vtkResliceCursorActor vtkResliceCursorActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorLineRepresentation_GetResliceCursorActor_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorActor2 = (vtkResliceCursorActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorActor2.Register(null);
			}
		}
		return vtkResliceCursorActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorLineRepresentation_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkResliceCursorLineRepresentation_HasTranslucentPolygonalGeometry_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorLineRepresentation_Highlight_09(HandleRef pThis, int highlightOn);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void Highlight(int highlightOn)
	{
		vtkResliceCursorLineRepresentation_Highlight_09(GetCppThis(), highlightOn);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorLineRepresentation_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResliceCursorLineRepresentation_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorLineRepresentation_IsTypeOf_11(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResliceCursorLineRepresentation_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorLineRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkResliceCursorLineRepresentation NewInstance()
	{
		vtkResliceCursorLineRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorLineRepresentation_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResliceCursorLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorLineRepresentation_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkResliceCursorLineRepresentation_ReleaseGraphicsResources_14(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorLineRepresentation_RenderOpaqueGeometry_15(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkResliceCursorLineRepresentation_RenderOpaqueGeometry_15(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorLineRepresentation_RenderOverlay_16(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkResliceCursorLineRepresentation_RenderOverlay_16(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResliceCursorLineRepresentation_RenderTranslucentPolygonalGeometry_17(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkResliceCursorLineRepresentation_RenderTranslucentPolygonalGeometry_17(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResliceCursorLineRepresentation_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkResliceCursorLineRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkResliceCursorLineRepresentation vtkResliceCursorLineRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResliceCursorLineRepresentation_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResliceCursorLineRepresentation2 = (vtkResliceCursorLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResliceCursorLineRepresentation2.Register(null);
			}
		}
		return vtkResliceCursorLineRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorLineRepresentation_SetTolerance_19(HandleRef pThis, int t);

	/// <summary>
	/// Re-implemented to set the tolerance of the picker.
	/// </summary>
	public override void SetTolerance(int t)
	{
		vtkResliceCursorLineRepresentation_SetTolerance_19(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorLineRepresentation_SetUserMatrix_20(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Set the user matrix on all the internal actors.
	/// </summary>
	public virtual void SetUserMatrix(vtkMatrix4x4 matrix)
	{
		vtkResliceCursorLineRepresentation_SetUserMatrix_20(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorLineRepresentation_StartWidgetInteraction_21(HandleRef pThis, IntPtr startEventPos);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr startEventPos)
	{
		vtkResliceCursorLineRepresentation_StartWidgetInteraction_21(GetCppThis(), startEventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResliceCursorLineRepresentation_WidgetInteraction_22(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkResliceCursorLineRepresentation_WidgetInteraction_22(GetCppThis(), e);
	}
}
