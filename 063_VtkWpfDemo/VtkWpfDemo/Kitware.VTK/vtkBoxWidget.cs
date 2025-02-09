using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBoxWidget
/// </summary>
/// <remarks>
///    orthogonal hexahedron 3D widget
///
/// This 3D widget defines a region of interest that is represented by an
/// arbitrarily oriented hexahedron with interior face angles of 90 degrees
/// (orthogonal faces). The object creates 7 handles that can be moused on and
/// manipulated. The first six correspond to the six faces, the seventh is in
/// the center of the hexahedron. In addition, a bounding box outline is shown,
/// the "faces" of which can be selected for object rotation or scaling. A
/// nice feature of the object is that the vtkBoxWidget, like any 3D widget,
/// will work with the current interactor style. That is, if vtkBoxWidget does
/// not handle an event, then all other registered observers (including the
/// interactor style) have an opportunity to process the event. Otherwise, the
/// vtkBoxWidget will terminate the processing of the event that it handles.
///
/// To use this object, just invoke SetInteractor() with the argument of the
/// method a vtkRenderWindowInteractor.  You may also wish to invoke
/// "PlaceWidget()" to initially position the widget. The interactor will act
/// normally until the "i" key (for "interactor") is pressed, at which point the
/// vtkBoxWidget will appear. (See superclass documentation for information
/// about changing this behavior.) By grabbing the six face handles (use the
/// left mouse button), faces can be moved. By grabbing the center handle
/// (with the left mouse button), the entire hexahedron can be
/// translated. (Translation can also be employed by using the
/// "shift-left-mouse-button" combination inside of the widget.) Scaling is
/// achieved by using the right mouse button "up" the render window (makes the
/// widget bigger) or "down" the render window (makes the widget smaller). To
/// rotate vtkBoxWidget, pick a face (but not a face handle) and move the left
/// mouse. (Note: the mouse button must be held down during manipulation.)
/// Events that occur outside of the widget (i.e., no part of the widget is
/// picked) are propagated to any other registered obsevers (such as the
/// interaction style).  Turn off the widget by pressing the "i" key again.
/// (See the superclass documentation on key press activiation.)
///
/// The vtkBoxWidget is very flexible. It can be used to select, cut, clip, or
/// perform any other operation that depends on an implicit function (use the
/// GetPlanes() method); or it can be used to transform objects using a linear
/// transformation (use the GetTransform() method). Typical usage of the
/// widget is to make use of the StartInteractionEvent, InteractionEvent, and
/// EndInteractionEvent events. The InteractionEvent is called on mouse
/// motion; the other two events are called on button down and button up
/// (either left or right button).
///
/// Some additional features of this class include the ability to control the
/// rendered properties of the widget. You can set the properties of the
/// selected and unselected representations of the parts of the widget. For
/// example, you can set the property for the handles, faces, and outline in
/// their normal and selected states.
///
/// The box widget can be oriented by specifying a transformation matrix.
/// This transformation is applied to the initial bounding box as defined by
/// the PlaceWidget() method. DO NOT ASSUME that the transformation is applied
/// to a unit box centered at the origin; this is wrong!
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkPointWidget vtkLineWidget vtkPlaneWidget
/// vtkImplicitPlaneWidget vtkImagePlaneWidget
/// </seealso>
public class vtkBoxWidget : vtk3DWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBoxWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBoxWidget()
	{
		MRClassNameKey = "class vtkBoxWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBoxWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkBoxWidget New()
	{
		vtkBoxWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public vtkBoxWidget()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBoxWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBoxWidget_GetFaceProperty_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the face properties (the faces of the box). The
	/// properties of the face when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetFaceProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_GetFaceProperty_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBoxWidget_GetHandleProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_GetHandleProperty_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBoxWidget_GetInsideOut_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, the normals point out of the
	/// box. When on, the normals point into the hexahedron.  InsideOut
	/// is off by default.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkBoxWidget_GetInsideOut_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxWidget_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBoxWidget_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxWidget_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBoxWidget_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget_GetOutlineCursorWires_06(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public virtual int GetOutlineCursorWires()
	{
		return vtkBoxWidget_GetOutlineCursorWires_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget_GetOutlineFaceWires_07(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public virtual int GetOutlineFaceWires()
	{
		return vtkBoxWidget_GetOutlineFaceWires_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxWidget_GetOutlineProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the outline properties (the outline of the box). The
	/// properties of the outline when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_GetOutlineProperty_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBoxWidget_GetPlanes_09(HandleRef pThis, HandleRef planes);

	/// <summary>
	/// Get the planes describing the implicit function defined by the box
	/// widget. The user must provide the instance of the class vtkPlanes. Note
	/// that vtkPlanes is a subclass of vtkImplicitFunction, meaning that it can
	/// be used by a variety of filters to perform clipping, cutting, and
	/// selection of data.  (The direction of the normals of the planes can be
	/// reversed enabling the InsideOut flag.)
	/// </summary>
	public void GetPlanes(vtkPlanes planes)
	{
		vtkBoxWidget_GetPlanes_09(GetCppThis(), planes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_GetPolyData_10(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that define the box widget. The
	/// polydata consists of 6 quadrilateral faces and 15 points. The first
	/// eight points define the eight corner vertices; the next six define the
	/// -x,+x, -y,+y, -z,+z face points; and the final point (the 15th out of 15
	/// points) defines the center of the hexahedron. These point values are
	/// guaranteed to be up-to-date when either the InteractionEvent or
	/// EndInteractionEvent events are invoked. The user provides the
	/// vtkPolyData and the points and cells are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkBoxWidget_GetPolyData_10(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget_GetRotationEnabled_11(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual int GetRotationEnabled()
	{
		return vtkBoxWidget_GetRotationEnabled_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget_GetScalingEnabled_12(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual int GetScalingEnabled()
	{
		return vtkBoxWidget_GetScalingEnabled_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxWidget_GetSelectedFaceProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the face properties (the faces of the box). The
	/// properties of the face when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetSelectedFaceProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_GetSelectedFaceProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBoxWidget_GetSelectedHandleProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_GetSelectedHandleProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBoxWidget_GetSelectedOutlineProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the outline properties (the outline of the box). The
	/// properties of the outline when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetSelectedOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_GetSelectedOutlineProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBoxWidget_GetTransform_16(HandleRef pThis, HandleRef t);

	/// <summary>
	/// Retrieve a linear transform characterizing the transformation of the
	/// box. Note that the transformation is relative to where PlaceWidget
	/// was initially called. This method modifies the transform provided. The
	/// transform can be used to control the position of vtkProp3D's, as well as
	/// other transformation operations (e.g., vtkTransformPolyData).
	/// </summary>
	public virtual void GetTransform(vtkTransform t)
	{
		vtkBoxWidget_GetTransform_16(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget_GetTranslationEnabled_17(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual int GetTranslationEnabled()
	{
		return vtkBoxWidget_GetTranslationEnabled_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_HandlesOff_18(HandleRef pThis);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the actor
	/// visibility.
	/// </summary>
	public void HandlesOff()
	{
		vtkBoxWidget_HandlesOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_HandlesOn_19(HandleRef pThis);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the actor
	/// visibility.
	/// </summary>
	public void HandlesOn()
	{
		vtkBoxWidget_HandlesOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_InsideOutOff_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, the normals point out of the
	/// box. When on, the normals point into the hexahedron.  InsideOut
	/// is off by default.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkBoxWidget_InsideOutOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_InsideOutOn_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, the normals point out of the
	/// box. When on, the normals point into the hexahedron.  InsideOut
	/// is off by default.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkBoxWidget_InsideOutOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBoxWidget_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxWidget_IsTypeOf_23(string type);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBoxWidget_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxWidget_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new vtkBoxWidget NewInstance()
	{
		vtkBoxWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_OutlineCursorWiresOff_26(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void OutlineCursorWiresOff()
	{
		vtkBoxWidget_OutlineCursorWiresOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_OutlineCursorWiresOn_27(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void OutlineCursorWiresOn()
	{
		vtkBoxWidget_OutlineCursorWiresOn_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_OutlineFaceWiresOff_28(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void OutlineFaceWiresOff()
	{
		vtkBoxWidget_OutlineFaceWiresOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_OutlineFaceWiresOn_29(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void OutlineFaceWiresOn()
	{
		vtkBoxWidget_OutlineFaceWiresOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_PlaceWidget_30(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkBoxWidget_PlaceWidget_30(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_PlaceWidget_31(HandleRef pThis);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkBoxWidget_PlaceWidget_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_PlaceWidget_32(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkBoxWidget_PlaceWidget_32(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_RotationEnabledOff_33(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void RotationEnabledOff()
	{
		vtkBoxWidget_RotationEnabledOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_RotationEnabledOn_34(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void RotationEnabledOn()
	{
		vtkBoxWidget_RotationEnabledOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxWidget_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the object.
	/// </summary>
	public new static vtkBoxWidget SafeDownCast(vtkObjectBase o)
	{
		vtkBoxWidget vtkBoxWidget3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxWidget_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBoxWidget3 = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBoxWidget3.Register(null);
			}
		}
		return vtkBoxWidget3;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_ScalingEnabledOff_36(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void ScalingEnabledOff()
	{
		vtkBoxWidget_ScalingEnabledOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_ScalingEnabledOn_37(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void ScalingEnabledOn()
	{
		vtkBoxWidget_ScalingEnabledOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_SetEnabled_38(HandleRef pThis, int arg0);

	/// <summary>
	/// Methods that satisfy the superclass' API.
	/// </summary>
	public override void SetEnabled(int arg0)
	{
		vtkBoxWidget_SetEnabled_38(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_SetInsideOut_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the InsideOut flag. When off, the normals point out of the
	/// box. When on, the normals point into the hexahedron.  InsideOut
	/// is off by default.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkBoxWidget_SetInsideOut_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_SetOutlineCursorWires_40(HandleRef pThis, int arg0);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void SetOutlineCursorWires(int arg0)
	{
		vtkBoxWidget_SetOutlineCursorWires_40(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_SetOutlineFaceWires_41(HandleRef pThis, int arg0);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void SetOutlineFaceWires(int arg0)
	{
		vtkBoxWidget_SetOutlineFaceWires_41(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_SetRotationEnabled_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void SetRotationEnabled(int _arg)
	{
		vtkBoxWidget_SetRotationEnabled_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_SetScalingEnabled_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void SetScalingEnabled(int _arg)
	{
		vtkBoxWidget_SetScalingEnabled_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_SetTransform_44(HandleRef pThis, HandleRef t);

	/// <summary>
	/// Set the position, scale and orientation of the box widget using the
	/// transform specified. Note that the transformation is relative to
	/// where PlaceWidget was initially called (i.e., the original bounding
	/// box).
	/// </summary>
	public virtual void SetTransform(vtkTransform t)
	{
		vtkBoxWidget_SetTransform_44(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_SetTranslationEnabled_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void SetTranslationEnabled(int _arg)
	{
		vtkBoxWidget_SetTranslationEnabled_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_TranslationEnabledOff_46(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void TranslationEnabledOff()
	{
		vtkBoxWidget_TranslationEnabledOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxWidget_TranslationEnabledOn_47(HandleRef pThis);

	/// <summary>
	/// Control the behavior of the widget. Translation, rotation, and
	/// scaling can all be enabled and disabled.
	/// </summary>
	public virtual void TranslationEnabledOn()
	{
		vtkBoxWidget_TranslationEnabledOn_47(GetCppThis());
	}
}
