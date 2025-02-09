using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectilinearWipeRepresentation
/// </summary>
/// <remarks>
///    represent a vtkRectilinearWipeWidget
///
/// This class is used to represent and render a vtkRectilinearWipeWidget. To
/// use this class, you need to specify an instance of a
/// vtkImageRectilinearWipe and vtkImageActor. This provides the information
/// for this representation to construct and place itself.
///
/// The class may be subclassed so that alternative representations can
/// be created.  The class defines an API and a default implementation that
/// the vtkRectilinearWipeWidget interacts with to render itself in the scene.
///
/// @warning
/// The separation of the widget event handling and representation enables
/// users and developers to create new appearances for the widget. It also
/// facilitates parallel processing, where the client application handles
/// events, and remote representations of the widget are slaves to the
/// client (and do not handle events).
///
/// </remarks>
/// <seealso>
///
/// vtkRectilinearWipeWidget vtkWidgetRepresentation vtkAbstractWidget
/// </seealso>
public class vtkRectilinearWipeRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		MovingCenter = 3,
		/// <summary>enum member</summary>
		MovingHPane = 1,
		/// <summary>enum member</summary>
		MovingVPane = 2,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearWipeRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectilinearWipeRepresentation()
	{
		MRClassNameKey = "class vtkRectilinearWipeRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearWipeRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectilinearWipeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearWipeRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkRectilinearWipeRepresentation New()
	{
		vtkRectilinearWipeRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearWipeRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkRectilinearWipeRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectilinearWipeRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRectilinearWipeRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkRectilinearWipeRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkRectilinearWipeRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearWipeRepresentation_GetActors2D_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void GetActors2D(vtkPropCollection arg0)
	{
		vtkRectilinearWipeRepresentation_GetActors2D_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearWipeRepresentation_GetImageActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an instance of vtkImageActor to decorate.
	/// </summary>
	public virtual vtkImageActor GetImageActor()
	{
		vtkImageActor vtkImageActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearWipeRepresentation_GetImageActor_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageActor2 = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageActor2.Register(null);
			}
		}
		return vtkImageActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearWipeRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectilinearWipeRepresentation_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearWipeRepresentation_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectilinearWipeRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearWipeRepresentation_GetProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties for the widget. This can be manipulated to set
	/// different colors, line widths, etc.
	/// </summary>
	public virtual vtkProperty2D GetProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearWipeRepresentation_GetProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkRectilinearWipeRepresentation_GetRectilinearWipe_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an instance of vtkImageRectilinearWipe to manipulate.
	/// </summary>
	public virtual vtkImageRectilinearWipe GetRectilinearWipe()
	{
		vtkImageRectilinearWipe vtkImageRectilinearWipe2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearWipeRepresentation_GetRectilinearWipe_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageRectilinearWipe2 = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageRectilinearWipe2.Register(null);
			}
		}
		return vtkImageRectilinearWipe2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_GetTolerance_09(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered to be on the widget, or on a
	/// widget feature (e.g., a corner point or edge).
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkRectilinearWipeRepresentation_GetTolerance_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_GetToleranceMaxValue_10(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered to be on the widget, or on a
	/// widget feature (e.g., a corner point or edge).
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkRectilinearWipeRepresentation_GetToleranceMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_GetToleranceMinValue_11(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered to be on the widget, or on a
	/// widget feature (e.g., a corner point or edge).
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkRectilinearWipeRepresentation_GetToleranceMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkRectilinearWipeRepresentation_HasTranslucentPolygonalGeometry_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectilinearWipeRepresentation_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_IsTypeOf_14(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectilinearWipeRepresentation_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearWipeRepresentation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkRectilinearWipeRepresentation NewInstance()
	{
		vtkRectilinearWipeRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearWipeRepresentation_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearWipeRepresentation_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkRectilinearWipeRepresentation_ReleaseGraphicsResources_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkRectilinearWipeRepresentation_RenderOpaqueGeometry_18(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_RenderOverlay_19(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkRectilinearWipeRepresentation_RenderOverlay_19(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearWipeRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods to make this class behave as a vtkProp.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkRectilinearWipeRepresentation_RenderTranslucentPolygonalGeometry_20(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearWipeRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkRectilinearWipeRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkRectilinearWipeRepresentation vtkRectilinearWipeRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearWipeRepresentation_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearWipeRepresentation2 = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearWipeRepresentation2.Register(null);
			}
		}
		return vtkRectilinearWipeRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearWipeRepresentation_SetImageActor_22(HandleRef pThis, HandleRef imageActor);

	/// <summary>
	/// Specify an instance of vtkImageActor to decorate.
	/// </summary>
	public void SetImageActor(vtkImageActor imageActor)
	{
		vtkRectilinearWipeRepresentation_SetImageActor_22(GetCppThis(), imageActor?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearWipeRepresentation_SetRectilinearWipe_23(HandleRef pThis, HandleRef wipe);

	/// <summary>
	/// Specify an instance of vtkImageRectilinearWipe to manipulate.
	/// </summary>
	public void SetRectilinearWipe(vtkImageRectilinearWipe wipe)
	{
		vtkRectilinearWipeRepresentation_SetRectilinearWipe_23(GetCppThis(), wipe?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearWipeRepresentation_SetTolerance_24(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered to be on the widget, or on a
	/// widget feature (e.g., a corner point or edge).
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkRectilinearWipeRepresentation_SetTolerance_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearWipeRepresentation_StartWidgetInteraction_25(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr eventPos)
	{
		vtkRectilinearWipeRepresentation_StartWidgetInteraction_25(GetCppThis(), eventPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearWipeRepresentation_WidgetInteraction_26(HandleRef pThis, IntPtr eventPos);

	/// <summary>
	/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
	/// are the methods that the widget and its representation use to
	/// communicate with each other.
	/// </summary>
	public override void WidgetInteraction(IntPtr eventPos)
	{
		vtkRectilinearWipeRepresentation_WidgetInteraction_26(GetCppThis(), eventPos);
	}
}
