using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTensorRepresentation
/// </summary>
/// <remarks>
///    class defining a representation for the vtkTensorWidget
///
/// This class is a concrete representation for the vtkTensorWidget. In
/// summary, it allows the editing of a tensor glyph (by modifying the
/// underlying tensor value). This includes controlling the position, scaling,
/// and rotation of the glyph. The representation is simply an oriented,
/// scaled box which can be manipulated to transform the tensor. Optionally,
/// an ellipsoid defined by the tensor eigenvectors can be shown for
/// informational purposes.
///
/// To use this representation, specify a 3x3 real, symmetric matrix defining
/// the tensor. (This implicitly defines an orthogonal basis from the three
/// tensor eigenvectors.) Then use PlaceWidget() to define a bounding box: the
/// bounding box defines a position for the tensor from its center point, and
/// the representation is scaled to fit in the bounding box.
///
/// Note: typical usage is to place a tensor glyph inside of the
/// representation (i.e., the box) which is updated as the representation is
/// manipulated by the user. The built-in ellipsoid can be used for this;
/// alternatively through callbacks and such, it is possible to place
/// other glyph types such as superquadrics.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorWidget vtkBoxRepresentation
/// </seealso>
public class vtkTensorRepresentation : vtkWidgetRepresentation
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
	public new const string MRFullTypeName = "Kitware.VTK.vtkTensorRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTensorRepresentation()
	{
		MRClassNameKey = "class vtkTensorRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTensorRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkTensorRepresentation New()
	{
		vtkTensorRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTensorRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkTensorRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTensorRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTensorRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkTensorRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkTensorRepresentation_ComplexInteraction_02(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_ComputeComplexInteractionState_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
	{
		return vtkTensorRepresentation_ComputeComplexInteractionState_03(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkTensorRepresentation_ComputeInteractionState_04(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_EndComplexInteraction_05(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkTensorRepresentation_EndComplexInteraction_05(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorRepresentation_GetBounds_06(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkTensorRepresentation_GetBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_GetEigenvalues_07(HandleRef pThis, IntPtr evals);

	/// <summary>
	/// These are methods used to retrieve derived information about the tensor.
	/// Specify (0&lt;=i&lt;3) to retrieve the ith eigenvector. The eigenvalues and
	/// associated eigenvectors are sorted in decreasing order.
	/// </summary>
	public void GetEigenvalues(IntPtr evals)
	{
		vtkTensorRepresentation_GetEigenvalues_07(GetCppThis(), evals);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_GetEigenvector_08(HandleRef pThis, int n, IntPtr ev);

	/// <summary>
	/// These are methods used to retrieve derived information about the tensor.
	/// Specify (0&lt;=i&lt;3) to retrieve the ith eigenvector. The eigenvalues and
	/// associated eigenvectors are sorted in decreasing order.
	/// </summary>
	public void GetEigenvector(int n, IntPtr ev)
	{
		vtkTensorRepresentation_GetEigenvector_08(GetCppThis(), n, ev);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorRepresentation_GetEllipsoidProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the tensor ellipsoid properties. If visibility is enabled,
	/// the ellipsoid will be rendered with this property.
	/// </summary>
	public virtual vtkProperty GetEllipsoidProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorRepresentation_GetEllipsoidProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTensorRepresentation_GetFaceProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkTensorRepresentation_GetFaceProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTensorRepresentation_GetHandleProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkTensorRepresentation_GetHandleProperty_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTensorRepresentation_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTensorRepresentation_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTensorRepresentation_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTensorRepresentation_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTensorRepresentation_GetOutlineCursorWires_14(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public virtual bool GetOutlineCursorWires()
	{
		return (vtkTensorRepresentation_GetOutlineCursorWires_14(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTensorRepresentation_GetOutlineFaceWires_15(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public virtual bool GetOutlineFaceWires()
	{
		return (vtkTensorRepresentation_GetOutlineFaceWires_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorRepresentation_GetOutlineProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkTensorRepresentation_GetOutlineProperty_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTensorRepresentation_GetPolyData_17(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that define the representation. The
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
		vtkTensorRepresentation_GetPolyData_17(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_GetPosition_18(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get a position for the location of the tensor. Of course a tensor
	/// inherently has no position, but this is for the purpose of placing
	/// this widget representation.
	/// </summary>
	public void GetPosition(IntPtr pos)
	{
		vtkTensorRepresentation_GetPosition_18(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorRepresentation_GetSelectedFaceProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkTensorRepresentation_GetSelectedFaceProperty_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTensorRepresentation_GetSelectedHandleProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkTensorRepresentation_GetSelectedHandleProperty_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkTensorRepresentation_GetSelectedOutlineProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkTensorRepresentation_GetSelectedOutlineProperty_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkTensorRepresentation_GetSnapToAxes_22(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public virtual bool GetSnapToAxes()
	{
		return (vtkTensorRepresentation_GetSnapToAxes_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_GetSymmetricTensor_23(HandleRef pThis, IntPtr symTensor);

	/// <summary>
	/// These are the basic methods used to define the tensor (these methods
	/// coordinate with the overloaded PlaceWidget() method). The methods enable
	/// specification of a 3x3 symmetric tensor. This information is used to
	/// construct an oriented, appropriately ellipsoid that is (initially)
	/// centered and fits inside the bounding box defined by PlaceWidget(). As
	/// this widget is modified during user interaction, the tensor data member
	/// is continuously updated and can be queried. Note that a symmetric tensor
	/// can be defined with only six components. If a full 3x3 tensor is
	/// specified, only the symmetrical part of the tensor is used since the
	/// extracted eigenvalues/eigenvecters are required to be real valued. When
	/// a tensor is specified, the derived information (e.g.,
	/// eigenvalues/vectors and position) are immediately updated.
	/// </summary>
	public void GetSymmetricTensor(IntPtr symTensor)
	{
		vtkTensorRepresentation_GetSymmetricTensor_23(GetCppThis(), symTensor);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_GetTensor_24(HandleRef pThis, IntPtr tensor);

	/// <summary>
	/// These are the basic methods used to define the tensor (these methods
	/// coordinate with the overloaded PlaceWidget() method). The methods enable
	/// specification of a 3x3 symmetric tensor. This information is used to
	/// construct an oriented, appropriately ellipsoid that is (initially)
	/// centered and fits inside the bounding box defined by PlaceWidget(). As
	/// this widget is modified during user interaction, the tensor data member
	/// is continuously updated and can be queried. Note that a symmetric tensor
	/// can be defined with only six components. If a full 3x3 tensor is
	/// specified, only the symmetrical part of the tensor is used since the
	/// extracted eigenvalues/eigenvecters are required to be real valued. When
	/// a tensor is specified, the derived information (e.g.,
	/// eigenvalues/vectors and position) are immediately updated.
	/// </summary>
	public void GetTensor(IntPtr tensor)
	{
		vtkTensorRepresentation_GetTensor_24(GetCppThis(), tensor);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTensorRepresentation_GetTensorEllipsoid_25(HandleRef pThis);

	/// <summary>
	/// Indicate whether to show the tensor ellipsoid. By default it is on.
	/// </summary>
	public virtual bool GetTensorEllipsoid()
	{
		return (vtkTensorRepresentation_GetTensorEllipsoid_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_GetTranslationAxis_26(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxis()
	{
		return vtkTensorRepresentation_GetTranslationAxis_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_GetTranslationAxisMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMaxValue()
	{
		return vtkTensorRepresentation_GetTranslationAxisMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_GetTranslationAxisMinValue_28(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMinValue()
	{
		return vtkTensorRepresentation_GetTranslationAxisMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_HandlesOff_29(HandleRef pThis);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the underlying
	/// actor visibility.
	/// </summary>
	public virtual void HandlesOff()
	{
		vtkTensorRepresentation_HandlesOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_HandlesOn_30(HandleRef pThis);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the underlying
	/// actor visibility.
	/// </summary>
	public virtual void HandlesOn()
	{
		vtkTensorRepresentation_HandlesOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_HasTranslucentPolygonalGeometry_31(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkTensorRepresentation_HasTranslucentPolygonalGeometry_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_IsA_32(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTensorRepresentation_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTensorRepresentation_IsTranslationConstrained_33(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkTensorRepresentation_IsTranslationConstrained_33(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_IsTypeOf_34(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTensorRepresentation_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorRepresentation_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkTensorRepresentation NewInstance()
	{
		vtkTensorRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorRepresentation_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTensorRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_OutlineCursorWiresOff_37(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void OutlineCursorWiresOff()
	{
		vtkTensorRepresentation_OutlineCursorWiresOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_OutlineCursorWiresOn_38(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void OutlineCursorWiresOn()
	{
		vtkTensorRepresentation_OutlineCursorWiresOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_OutlineFaceWiresOff_39(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void OutlineFaceWiresOff()
	{
		vtkTensorRepresentation_OutlineFaceWiresOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_OutlineFaceWiresOn_40(HandleRef pThis);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void OutlineFaceWiresOn()
	{
		vtkTensorRepresentation_OutlineFaceWiresOn_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_PlaceTensor_41(HandleRef pThis, IntPtr tensor, IntPtr position);

	/// <summary>
	/// This is a specialized place widget method for a tensor. Specify the
	/// tensor (an array of 9 components) and the position to place the tensor.
	/// Note that the PlaceFactor (defined in superclass) can be used to
	/// scale the representation when placed.
	/// </summary>
	public void PlaceTensor(IntPtr tensor, IntPtr position)
	{
		vtkTensorRepresentation_PlaceTensor_41(GetCppThis(), tensor, position);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_PlaceWidget_42(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkTensorRepresentation_PlaceWidget_42(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_RegisterPickers_43(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public override void RegisterPickers()
	{
		vtkTensorRepresentation_RegisterPickers_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTensorRepresentation_ReleaseGraphicsResources_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_RenderOpaqueGeometry_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkTensorRepresentation_RenderOpaqueGeometry_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTensorRepresentation_RenderTranslucentPolygonalGeometry_46(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkTensorRepresentation_RenderTranslucentPolygonalGeometry_46(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTensorRepresentation_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkTensorRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkTensorRepresentation vtkTensorRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTensorRepresentation_SafeDownCast_47(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTensorRepresentation2 = (vtkTensorRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTensorRepresentation2.Register(null);
			}
		}
		return vtkTensorRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetInteractionState_48(HandleRef pThis, int state);

	/// <summary>
	/// The interaction state may be set from a widget (e.g., vtkTensorWidget) or
	/// other object. This controls how the interaction with the widget
	/// proceeds. Normally this method is used as part of a handshaking
	/// process with the widget: First ComputeInteractionState() is invoked that
	/// returns a state based on geometric considerations (i.e., cursor near a
	/// widget feature), then based on events, the widget may modify this
	/// further.
	/// </summary>
	public void SetInteractionState(int state)
	{
		vtkTensorRepresentation_SetInteractionState_48(GetCppThis(), state);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetOutlineCursorWires_49(HandleRef pThis, byte arg0);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// the cursor lines running between the handles. By default cursor
	/// wires are on.
	/// </summary>
	public void SetOutlineCursorWires(bool arg0)
	{
		vtkTensorRepresentation_SetOutlineCursorWires_49(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetOutlineFaceWires_50(HandleRef pThis, byte arg0);

	/// <summary>
	/// Control the representation of the outline. This flag enables
	/// face wires. By default face wires are off.
	/// </summary>
	public void SetOutlineFaceWires(bool arg0)
	{
		vtkTensorRepresentation_SetOutlineFaceWires_50(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetPosition_51(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get a position for the location of the tensor. Of course a tensor
	/// inherently has no position, but this is for the purpose of placing
	/// this widget representation.
	/// </summary>
	public void SetPosition(IntPtr pos)
	{
		vtkTensorRepresentation_SetPosition_51(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetSnapToAxes_52(HandleRef pThis, byte _arg);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public virtual void SetSnapToAxes(bool _arg)
	{
		vtkTensorRepresentation_SetSnapToAxes_52(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetSymmetricTensor_53(HandleRef pThis, IntPtr symTensor);

	/// <summary>
	/// These are the basic methods used to define the tensor (these methods
	/// coordinate with the overloaded PlaceWidget() method). The methods enable
	/// specification of a 3x3 symmetric tensor. This information is used to
	/// construct an oriented, appropriately ellipsoid that is (initially)
	/// centered and fits inside the bounding box defined by PlaceWidget(). As
	/// this widget is modified during user interaction, the tensor data member
	/// is continuously updated and can be queried. Note that a symmetric tensor
	/// can be defined with only six components. If a full 3x3 tensor is
	/// specified, only the symmetrical part of the tensor is used since the
	/// extracted eigenvalues/eigenvecters are required to be real valued. When
	/// a tensor is specified, the derived information (e.g.,
	/// eigenvalues/vectors and position) are immediately updated.
	/// </summary>
	public void SetSymmetricTensor(IntPtr symTensor)
	{
		vtkTensorRepresentation_SetSymmetricTensor_53(GetCppThis(), symTensor);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetTensor_54(HandleRef pThis, IntPtr tensor);

	/// <summary>
	/// These are the basic methods used to define the tensor (these methods
	/// coordinate with the overloaded PlaceWidget() method). The methods enable
	/// specification of a 3x3 symmetric tensor. This information is used to
	/// construct an oriented, appropriately ellipsoid that is (initially)
	/// centered and fits inside the bounding box defined by PlaceWidget(). As
	/// this widget is modified during user interaction, the tensor data member
	/// is continuously updated and can be queried. Note that a symmetric tensor
	/// can be defined with only six components. If a full 3x3 tensor is
	/// specified, only the symmetrical part of the tensor is used since the
	/// extracted eigenvalues/eigenvecters are required to be real valued. When
	/// a tensor is specified, the derived information (e.g.,
	/// eigenvalues/vectors and position) are immediately updated.
	/// </summary>
	public void SetTensor(IntPtr tensor)
	{
		vtkTensorRepresentation_SetTensor_54(GetCppThis(), tensor);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetTensorEllipsoid_55(HandleRef pThis, byte arg0);

	/// <summary>
	/// Indicate whether to show the tensor ellipsoid. By default it is on.
	/// </summary>
	public void SetTensorEllipsoid(bool arg0)
	{
		vtkTensorRepresentation_SetTensorEllipsoid_55(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetTranslationAxis_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual void SetTranslationAxis(int _arg)
	{
		vtkTensorRepresentation_SetTranslationAxis_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetTranslationAxisOff_57(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkTensorRepresentation_SetTranslationAxisOff_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetXTranslationAxisOn_58(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkTensorRepresentation_SetXTranslationAxisOn_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetYTranslationAxisOn_59(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkTensorRepresentation_SetYTranslationAxisOn_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_SetZTranslationAxisOn_60(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkTensorRepresentation_SetZTranslationAxisOn_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_StartComplexInteraction_61(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
	{
		vtkTensorRepresentation_StartComplexInteraction_61(GetCppThis(), iren?.GetCppThis() ?? default(HandleRef), widget?.GetCppThis() ?? default(HandleRef), arg2, calldata);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_StartWidgetInteraction_62(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkTensorRepresentation_StartWidgetInteraction_62(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_StepBackward_63(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public void StepBackward()
	{
		vtkTensorRepresentation_StepBackward_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_StepForward_64(HandleRef pThis);

	/// <summary>
	/// For complex events should we snap orientations to
	/// be aligned with the x y z axes
	/// </summary>
	public void StepForward()
	{
		vtkTensorRepresentation_StepForward_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_TensorEllipsoidOff_65(HandleRef pThis);

	/// <summary>
	/// Indicate whether to show the tensor ellipsoid. By default it is on.
	/// </summary>
	public void TensorEllipsoidOff()
	{
		vtkTensorRepresentation_TensorEllipsoidOff_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_TensorEllipsoidOn_66(HandleRef pThis);

	/// <summary>
	/// Indicate whether to show the tensor ellipsoid. By default it is on.
	/// </summary>
	public void TensorEllipsoidOn()
	{
		vtkTensorRepresentation_TensorEllipsoidOn_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTensorRepresentation_WidgetInteraction_67(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkTensorRepresentation_WidgetInteraction_67(GetCppThis(), e);
	}
}
