using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelopipedRepresentation
/// </summary>
/// <remarks>
///    Default representation for vtkParallelopipedWidget
///
/// This class provides the default geometrical representation for
/// vtkParallelopipedWidget. As a result of interactions of the widget, this
/// representation can take on of the following shapes:
/// &lt;p&gt;1) A parallelopiped. (8 handles, 6 faces)
/// &lt;p&gt;2) Paralleopiped with a chair depression on any one handle. (A chair
/// is a depression on one of the handles that carves inwards so as to allow
/// the user to visualize cuts in the volume). (14 handles, 9 faces).
///
/// </remarks>
/// <seealso>
///
/// vtkParallelopipedWidget
/// </seealso>
public class vtkParallelopipedRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Given and x-y display coordinate, compute the interaction state of
	/// the widget.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		ChairMode = 10,
		/// <summary>enum member</summary>
		Inside = 1,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		RequestChairMode = 4,
		/// <summary>enum member</summary>
		RequestResizeParallelopiped = 2,
		/// <summary>enum member</summary>
		RequestResizeParallelopipedAlongAnAxis = 3,
		/// <summary>enum member</summary>
		RequestRotateParallelopiped = 7,
		/// <summary>enum member</summary>
		RequestScaleParallelopiped = 6,
		/// <summary>enum member</summary>
		RequestTranslateParallelopiped = 5,
		/// <summary>enum member</summary>
		ResizingParallelopiped = 8,
		/// <summary>enum member</summary>
		ResizingParallelopipedAlongAnAxis = 9,
		/// <summary>enum member</summary>
		RotatingParallelopiped = 13,
		/// <summary>enum member</summary>
		ScalingParallelopiped = 12,
		/// <summary>enum member</summary>
		TranslatingParallelopiped = 11
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelopipedRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelopipedRepresentation()
	{
		MRClassNameKey = "class vtkParallelopipedRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelopipedRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelopipedRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkParallelopipedRepresentation New()
	{
		vtkParallelopipedRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkParallelopipedRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParallelopipedRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParallelopipedRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// This actually constructs the geometry of the widget from the various
	/// data parameters.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkParallelopipedRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelopipedRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// Given and x-y display coordinate, compute the interaction state of
	/// the widget.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkParallelopipedRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_GetActors_03(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Methods to satisfy the superclass.
	/// </summary>
	public override void GetActors(vtkPropCollection pc)
	{
		vtkParallelopipedRepresentation_GetActors_03(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_GetBoundingPlanes_04(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// Get the bounding planes of the object. The first 6 planes will
	/// be bounding planes of the parallelopiped. If in chair mode, three
	/// additional planes will be present. The last three planes will be those
	/// of the chair. The normals of all the planes will point into the object.
	/// </summary>
	public void GetBoundingPlanes(vtkPlaneCollection pc)
	{
		vtkParallelopipedRepresentation_GetBoundingPlanes_04(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedRepresentation_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// The parallelopiped polydata.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkParallelopipedRepresentation_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedRepresentation_GetFaceProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the face properties. When a face is being translated, the face gets
	/// highlighted with the SelectedFaceProperty.
	/// </summary>
	public virtual vtkProperty GetFaceProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_GetFaceProperty_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkParallelopipedRepresentation_GetHandleProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_GetHandleProperty_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkParallelopipedRepresentation_GetHandleRepresentation_08(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties.
	/// </summary>
	public vtkHandleRepresentation GetHandleRepresentation(int index)
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_GetHandleRepresentation_08(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedRepresentation_GetHoveredHandleProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties.
	/// </summary>
	public virtual vtkProperty GetHoveredHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_GetHoveredHandleProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkParallelopipedRepresentation_GetMinimumThickness_10(HandleRef pThis);

	/// <summary>
	/// Minimum thickness for the parallelopiped. User interactions cannot make
	/// any individual axis of the parallopiped thinner than this value.
	/// Default is 0.05 expressed as a fraction of the diagonal of the bounding
	/// box used in the PlaceWidget() invocation.
	/// </summary>
	public virtual double GetMinimumThickness()
	{
		return vtkParallelopipedRepresentation_GetMinimumThickness_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelopipedRepresentation_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelopipedRepresentation_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelopipedRepresentation_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelopipedRepresentation_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedRepresentation_GetOutlineProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the outline properties. These are the properties with which the
	/// parallelopiped wireframe is rendered.
	/// </summary>
	public virtual vtkProperty GetOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_GetOutlineProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParallelopipedRepresentation_GetPolyData_14(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// The parallelopiped polydata.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkParallelopipedRepresentation_GetPolyData_14(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedFaceProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the face properties. When a face is being translated, the face gets
	/// highlighted with the SelectedFaceProperty.
	/// </summary>
	public virtual vtkProperty GetSelectedFaceProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_GetSelectedFaceProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedHandleProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_GetSelectedHandleProperty_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedOutlineProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the outline properties. These are the properties with which the
	/// parallelopiped wireframe is rendered.
	/// </summary>
	public virtual vtkProperty GetSelectedOutlineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_GetSelectedOutlineProperty_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParallelopipedRepresentation_HandlesOff_18(HandleRef pThis);

	/// <summary>
	/// Turns the visibility of the handles on/off. Sometimes they may get in
	/// the way of visualization.
	/// </summary>
	public void HandlesOff()
	{
		vtkParallelopipedRepresentation_HandlesOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_HandlesOn_19(HandleRef pThis);

	/// <summary>
	/// Turns the visibility of the handles on/off. Sometimes they may get in
	/// the way of visualization.
	/// </summary>
	public void HandlesOn()
	{
		vtkParallelopipedRepresentation_HandlesOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelopipedRepresentation_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelopipedRepresentation_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelopipedRepresentation_IsTypeOf_21(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelopipedRepresentation_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedRepresentation_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkParallelopipedRepresentation NewInstance()
	{
		vtkParallelopipedRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_PlaceWidget_24(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Place the widget in the scene. You can use either of the two APIs :
	/// 1) PlaceWidget( double bounds[6] )
	/// Creates a cuboid conforming to the said bounds.
	/// 2) PlaceWidget( double corners[8][3] )
	/// Creates a parallelopiped with corners specified. The order in
	/// which corners are specified must obey the following rule:
	/// Corner 0 - 1 - 2 - 3 - 0  forms a face
	/// Corner 4 - 5 - 6 - 7 - 4  forms a face
	/// Corner 0 - 4 - 5 - 1 - 0  forms a face
	/// Corner 1 - 5 - 6 - 2 - 1  forms a face
	/// Corner 2 - 6 - 7 - 3 - 2  forms a face
	/// Corner 3 - 7 - 4 - 0 - 3  forms a face
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkParallelopipedRepresentation_PlaceWidget_24(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_PositionHandles_25(HandleRef pThis);

	/// <summary>
	/// Synchronize the parallelopiped handle positions with the
	/// Polygonal datastructure.
	/// </summary>
	public virtual void PositionHandles()
	{
		vtkParallelopipedRepresentation_PositionHandles_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkParallelopipedRepresentation_ReleaseGraphicsResources_26(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelopipedRepresentation_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkParallelopipedRepresentation_RenderOpaqueGeometry_27(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelopipedRepresentation_RenderOverlay_28(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkParallelopipedRepresentation_RenderOverlay_28(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelopipedRepresentation_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkParallelopipedRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkParallelopipedRepresentation vtkParallelopipedRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelopipedRepresentation_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelopipedRepresentation2 = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelopipedRepresentation2.Register(null);
			}
		}
		return vtkParallelopipedRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_Scale_30(HandleRef pThis, int X, int Y);

	/// <summary>
	/// Given and x-y display coordinate, compute the interaction state of
	/// the widget.
	/// </summary>
	public virtual void Scale(int X, int Y)
	{
		vtkParallelopipedRepresentation_Scale_30(GetCppThis(), X, Y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_SetHandleProperty_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties.
	/// </summary>
	public virtual void SetHandleProperty(vtkProperty arg0)
	{
		vtkParallelopipedRepresentation_SetHandleProperty_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_SetHandleRepresentation_32(HandleRef pThis, HandleRef handle);

	/// <summary>
	/// Set/Get the handle properties.
	/// </summary>
	public void SetHandleRepresentation(vtkHandleRepresentation handle)
	{
		vtkParallelopipedRepresentation_SetHandleRepresentation_32(GetCppThis(), handle?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_SetHoveredHandleProperty_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties.
	/// </summary>
	public virtual void SetHoveredHandleProperty(vtkProperty arg0)
	{
		vtkParallelopipedRepresentation_SetHoveredHandleProperty_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_SetInteractionState_34(HandleRef pThis, int _arg);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., PointWidget)
	/// or other object. This controls how the interaction with the
	/// widget proceeds.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkParallelopipedRepresentation_SetInteractionState_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_SetMinimumThickness_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Minimum thickness for the parallelopiped. User interactions cannot make
	/// any individual axis of the parallopiped thinner than this value.
	/// Default is 0.05 expressed as a fraction of the diagonal of the bounding
	/// box used in the PlaceWidget() invocation.
	/// </summary>
	public virtual void SetMinimumThickness(double _arg)
	{
		vtkParallelopipedRepresentation_SetMinimumThickness_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_SetSelectedHandleProperty_36(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the handle properties.
	/// </summary>
	public virtual void SetSelectedHandleProperty(vtkProperty arg0)
	{
		vtkParallelopipedRepresentation_SetSelectedHandleProperty_36(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_Translate_37(HandleRef pThis, IntPtr translation);

	/// <summary>
	/// Given and x-y display coordinate, compute the interaction state of
	/// the widget.
	/// </summary>
	public virtual void Translate(IntPtr translation)
	{
		vtkParallelopipedRepresentation_Translate_37(GetCppThis(), translation);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelopipedRepresentation_Translate_38(HandleRef pThis, int X, int Y);

	/// <summary>
	/// Given and x-y display coordinate, compute the interaction state of
	/// the widget.
	/// </summary>
	public virtual void Translate(int X, int Y)
	{
		vtkParallelopipedRepresentation_Translate_38(GetCppThis(), X, Y);
	}
}
