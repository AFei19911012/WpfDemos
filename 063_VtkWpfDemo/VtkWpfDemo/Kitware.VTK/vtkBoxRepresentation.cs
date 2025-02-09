using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBoxRepresentation
/// </summary>
/// <remarks>
///    a class defining the representation for the vtkBoxWidget2
///
/// This class is a concrete representation for the vtkBoxWidget2. It
/// represents a box with seven handles: one on each of the six faces, plus a
/// center handle. Through interaction with the widget, the box
/// representation can be arbitrarily positioned in the 3D space.
///
/// To use this representation, you normally use the PlaceWidget() method
/// to position the widget at a specified region in space.
///
/// @warning
/// This class, and vtkBoxWidget2, are second generation VTK
/// widgets. An earlier version of this functionality was defined in the
/// class vtkBoxWidget.
///
/// </remarks>
/// <seealso>
///
/// vtkBoxWidget2 vtkBoxWidget
/// </seealso>
public class vtkBoxRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public enum MoveF0_WrapperEnum
	{
		/// <summary>enum member</summary>
		MoveF0 = 1,
		/// <summary>enum member</summary>
		MoveF1 = 2,
		/// <summary>enum member</summary>
		MoveF2 = 3,
		/// <summary>enum member</summary>
		MoveF3 = 4,
		/// <summary>enum member</summary>
		MoveF4 = 5,
		/// <summary>enum member</summary>
		MoveF5 = 6,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Rotating = 8,
		/// <summary>enum member</summary>
		Scaling = 9,
		/// <summary>enum member</summary>
		Translating = 7
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBoxRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBoxRepresentation()
	{
		MRClassNameKey = "class vtkBoxRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBoxRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkBoxRepresentation New()
	{
		vtkBoxRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkBoxRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBoxRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBoxRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkBoxRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkBoxRepresentation_ComplexInteraction_02(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_ComputeComplexInteractionState_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
	{
		return vtkBoxRepresentation_ComputeComplexInteractionState_03(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkBoxRepresentation_ComputeInteractionState_04(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_EndComplexInteraction_05(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkBoxRepresentation_EndComplexInteraction_05(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_GetActors_06(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// These methods are necessary to make this representation behave as
	/// a vtkProp (i.e., support rendering).
	/// GetActors adds all the internal props used by this representation to the supplied collection.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkBoxRepresentation_GetActors_06(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxRepresentation_GetBounds_07(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkBoxRepresentation_GetBounds_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxRepresentation_GetFaceProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBoxRepresentation_GetFaceProperty_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBoxRepresentation_GetHandleProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles, when selected or normal, can be
	/// specified.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxRepresentation_GetHandleProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBoxRepresentation_GetInsideOut_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. This data member is used in conjunction
	/// with the GetPlanes() method. When off, the normals point out of the
	/// box. When on, the normals point into the hexahedron.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual int GetInsideOut()
	{
		return vtkBoxRepresentation_GetInsideOut_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxRepresentation_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBoxRepresentation_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBoxRepresentation_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBoxRepresentation_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_GetOutlineCursorWires_13(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public virtual int GetOutlineCursorWires()
	{
		return vtkBoxRepresentation_GetOutlineCursorWires_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_GetOutlineFaceWires_14(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public virtual int GetOutlineFaceWires()
	{
		return vtkBoxRepresentation_GetOutlineFaceWires_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxRepresentation_GetOutlineProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBoxRepresentation_GetOutlineProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBoxRepresentation_GetPlanes_16(HandleRef pThis, HandleRef planes);

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
		vtkBoxRepresentation_GetPlanes_16(GetCppThis(), planes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_GetPolyData_17(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that define the box widget. The
	/// polydata consists of 6 quadrilateral faces and 15 points. The first
	/// eight points define the eight corner vertices; the next six define the
	/// -x,+x, -y,+y, -z,+z face points; and the final point (the 15th out of 15
	/// points) defines the center of the box. These point values are guaranteed
	/// to be up-to-date when either the widget's corresponding InteractionEvent
	/// or EndInteractionEvent events are invoked. The user provides the
	/// vtkPolyData and the points and cells are added to it.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkBoxRepresentation_GetPolyData_17(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxRepresentation_GetSelectedFaceProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBoxRepresentation_GetSelectedFaceProperty_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBoxRepresentation_GetSelectedHandleProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles, when selected or normal, can be
	/// specified.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxRepresentation_GetSelectedHandleProperty_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkBoxRepresentation_GetSelectedOutlineProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkBoxRepresentation_GetSelectedOutlineProperty_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkBoxRepresentation_GetSnapToAxes_21(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public virtual bool GetSnapToAxes()
	{
		return (vtkBoxRepresentation_GetSnapToAxes_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_GetTransform_22(HandleRef pThis, HandleRef t);

	/// <summary>
	/// Retrieve a linear transform characterizing the transformation of the
	/// box. Note that the transformation is relative to where PlaceWidget()
	/// was initially called. This method modifies the transform provided. The
	/// transform can be used to control the position of vtkProp3D's, as well as
	/// other transformation operations (e.g., vtkTransformPolyData).
	/// </summary>
	public virtual void GetTransform(vtkTransform t)
	{
		vtkBoxRepresentation_GetTransform_22(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_GetTranslationAxis_23(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxis()
	{
		return vtkBoxRepresentation_GetTranslationAxis_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_GetTranslationAxisMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMaxValue()
	{
		return vtkBoxRepresentation_GetTranslationAxisMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_GetTranslationAxisMinValue_25(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMinValue()
	{
		return vtkBoxRepresentation_GetTranslationAxisMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBoxRepresentation_GetTwoPlaneMode_26(HandleRef pThis);

	/// <summary>
	/// In two plane mode only the X planes are shown
	/// this is useful for defining thick slabs
	/// </summary>
	public virtual bool GetTwoPlaneMode()
	{
		return (vtkBoxRepresentation_GetTwoPlaneMode_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxRepresentation_GetUnderlyingPlane_27(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the planes describing the implicit function defined by the box
	/// widget. The user must provide the instance of the class vtkPlanes. Note
	/// that vtkPlanes is a subclass of vtkImplicitFunction, meaning that it can
	/// be used by a variety of filters to perform clipping, cutting, and
	/// selection of data.  (The direction of the normals of the planes can be
	/// reversed enabling the InsideOut flag.)
	/// </summary>
	public vtkPlane GetUnderlyingPlane(int i)
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxRepresentation_GetUnderlyingPlane_27(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBoxRepresentation_HandlesOff_28(HandleRef pThis);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the underlying
	/// actor visibility.
	/// </summary>
	public virtual void HandlesOff()
	{
		vtkBoxRepresentation_HandlesOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_HandlesOn_29(HandleRef pThis);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the underlying
	/// actor visibility.
	/// </summary>
	public virtual void HandlesOn()
	{
		vtkBoxRepresentation_HandlesOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_HasTranslucentPolygonalGeometry_30(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkBoxRepresentation_HasTranslucentPolygonalGeometry_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_InsideOutOff_31(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. This data member is used in conjunction
	/// with the GetPlanes() method. When off, the normals point out of the
	/// box. When on, the normals point into the hexahedron.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void InsideOutOff()
	{
		vtkBoxRepresentation_InsideOutOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_InsideOutOn_32(HandleRef pThis);

	/// <summary>
	/// Set/Get the InsideOut flag. This data member is used in conjunction
	/// with the GetPlanes() method. When off, the normals point out of the
	/// box. When on, the normals point into the hexahedron.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void InsideOutOn()
	{
		vtkBoxRepresentation_InsideOutOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_IsA_33(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBoxRepresentation_IsA_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBoxRepresentation_IsTranslationConstrained_34(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkBoxRepresentation_IsTranslationConstrained_34(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_IsTypeOf_35(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBoxRepresentation_IsTypeOf_35(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxRepresentation_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkBoxRepresentation NewInstance()
	{
		vtkBoxRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxRepresentation_NewInstance_37(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_OutlineCursorWiresOff_38(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void OutlineCursorWiresOff()
	{
		vtkBoxRepresentation_OutlineCursorWiresOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_OutlineCursorWiresOn_39(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void OutlineCursorWiresOn()
	{
		vtkBoxRepresentation_OutlineCursorWiresOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_OutlineFaceWiresOff_40(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void OutlineFaceWiresOff()
	{
		vtkBoxRepresentation_OutlineFaceWiresOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_OutlineFaceWiresOn_41(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void OutlineFaceWiresOn()
	{
		vtkBoxRepresentation_OutlineFaceWiresOn_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_PlaceWidget_42(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkBoxRepresentation_PlaceWidget_42(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_RegisterPickers_43(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public override void RegisterPickers()
	{
		vtkBoxRepresentation_RegisterPickers_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkBoxRepresentation_ReleaseGraphicsResources_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_RenderOpaqueGeometry_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkBoxRepresentation_RenderOpaqueGeometry_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBoxRepresentation_RenderTranslucentPolygonalGeometry_46(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkBoxRepresentation_RenderTranslucentPolygonalGeometry_46(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBoxRepresentation_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkBoxRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkBoxRepresentation vtkBoxRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBoxRepresentation_SafeDownCast_47(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBoxRepresentation2 = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBoxRepresentation2.Register(null);
			}
		}
		return vtkBoxRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetInsideOut_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the InsideOut flag. This data member is used in conjunction
	/// with the GetPlanes() method. When off, the normals point out of the
	/// box. When on, the normals point into the hexahedron.  InsideOut is off
	/// by default.
	/// </summary>
	public virtual void SetInsideOut(int _arg)
	{
		vtkBoxRepresentation_SetInsideOut_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetInteractionState_49(HandleRef pThis, int state);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkBoxWidget2) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public void SetInteractionState(int state)
	{
		vtkBoxRepresentation_SetInteractionState_49(GetCppThis(), state);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetOutlineCursorWires_50(HandleRef pThis, int arg0);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void SetOutlineCursorWires(int arg0)
	{
		vtkBoxRepresentation_SetOutlineCursorWires_50(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetOutlineFaceWires_51(HandleRef pThis, int arg0);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void SetOutlineFaceWires(int arg0)
	{
		vtkBoxRepresentation_SetOutlineFaceWires_51(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetSnapToAxes_52(HandleRef pThis, byte _arg);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public virtual void SetSnapToAxes(bool _arg)
	{
		vtkBoxRepresentation_SetSnapToAxes_52(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetTransform_53(HandleRef pThis, HandleRef t);

	/// <summary>
	/// Set the position, scale and orientation of the box widget using the
	/// transform specified. Note that the transformation is relative to
	/// where PlaceWidget() was initially called (i.e., the original bounding
	/// box).
	/// </summary>
	public virtual void SetTransform(vtkTransform t)
	{
		vtkBoxRepresentation_SetTransform_53(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetTranslationAxis_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual void SetTranslationAxis(int _arg)
	{
		vtkBoxRepresentation_SetTranslationAxis_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetTranslationAxisOff_55(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkBoxRepresentation_SetTranslationAxisOff_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetTwoPlaneMode_56(HandleRef pThis, byte arg0);

	/// <summary>
	/// In two plane mode only the X planes are shown
	/// this is useful for defining thick slabs
	/// </summary>
	public void SetTwoPlaneMode(bool arg0)
	{
		vtkBoxRepresentation_SetTwoPlaneMode_56(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetXTranslationAxisOn_57(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkBoxRepresentation_SetXTranslationAxisOn_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetYTranslationAxisOn_58(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkBoxRepresentation_SetYTranslationAxisOn_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_SetZTranslationAxisOn_59(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkBoxRepresentation_SetZTranslationAxisOn_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_StartComplexInteraction_60(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkBoxRepresentation_StartComplexInteraction_60(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_StartWidgetInteraction_61(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkBoxRepresentation_StartWidgetInteraction_61(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_StepBackward_62(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public void StepBackward()
	{
		vtkBoxRepresentation_StepBackward_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_StepForward_63(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public void StepForward()
	{
		vtkBoxRepresentation_StepForward_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBoxRepresentation_WidgetInteraction_64(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkBoxRepresentation_WidgetInteraction_64(GetCppThis(), e);
	}
}
