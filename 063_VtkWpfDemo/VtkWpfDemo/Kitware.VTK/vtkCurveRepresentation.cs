using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCurveRepresentation
/// </summary>
/// <remarks>
///    vtkWidgetRepresentation
/// base class for a widget that represents an curve that connects control
/// points.
///
/// Base class for widgets used to define curves from points, such as
/// vtkPolyLineRepresentation and vtkSplineRepresentation.  This class
/// uses handles, the number of which can be changed, to represent the
/// points that define the curve. The handles can be picked can be
/// picked on the curve itself to translate or rotate it in the scene.
/// </remarks>
public abstract class vtkCurveRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Erasing = 7,
		/// <summary>enum member</summary>
		Inserting = 6,
		/// <summary>enum member</summary>
		Moving = 3,
		/// <summary>enum member</summary>
		OnHandle = 1,
		/// <summary>enum member</summary>
		OnLine = 2,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Pushing = 8,
		/// <summary>enum member</summary>
		Scaling = 4,
		/// <summary>enum member</summary>
		Spinning = 5
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCurveRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCurveRepresentation()
	{
		MRClassNameKey = "class vtkCurveRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCurveRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCurveRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkCurveRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation
	/// API. Note that a version of place widget is available where the
	/// center and handle position are specified.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCurveRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_ClosedOff_02(HandleRef pThis);

	/// <summary>
	/// Control whether the curve is open or closed. A closed forms a
	/// continuous loop: the first and last points are the same.  A
	/// minimum of 3 handles are required to form a closed loop.
	/// </summary>
	public virtual void ClosedOff()
	{
		vtkCurveRepresentation_ClosedOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_ClosedOn_03(HandleRef pThis);

	/// <summary>
	/// Control whether the curve is open or closed. A closed forms a
	/// continuous loop: the first and last points are the same.  A
	/// minimum of 3 handles are required to form a closed loop.
	/// </summary>
	public virtual void ClosedOn()
	{
		vtkCurveRepresentation_ClosedOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation
	/// API. Note that a version of place widget is available where the
	/// center and handle position are specified.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkCurveRepresentation_ComputeInteractionState_04(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_DirectionalOff_05(HandleRef pThis);

	/// <summary>
	/// Set the representation to be directional or not.
	/// The meaning of being directional depends on the representation and
	/// its handles implementations in the subclasses.
	/// </summary>
	public virtual void DirectionalOff()
	{
		vtkCurveRepresentation_DirectionalOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_DirectionalOn_06(HandleRef pThis);

	/// <summary>
	/// Set the representation to be directional or not.
	/// The meaning of being directional depends on the representation and
	/// its handles implementations in the subclasses.
	/// </summary>
	public virtual void DirectionalOn()
	{
		vtkCurveRepresentation_DirectionalOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_EndWidgetInteraction_07(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation
	/// API. Note that a version of place widget is available where the
	/// center and handle position are specified.
	/// </summary>
	public override void EndWidgetInteraction(IntPtr e)
	{
		vtkCurveRepresentation_EndWidgetInteraction_07(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_GetActors_08(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods to make this class behave as a vtkProp. They are repeated here (from the
	/// vtkProp superclass) as a reminder to the widget implementor. Failure to implement
	/// these methods properly may result in the representation not appearing in the scene
	/// (i.e., not implementing the Render() methods properly) or leaking graphics resources
	/// (i.e., not implementing ReleaseGraphicsResources() properly).
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkCurveRepresentation_GetActors_08(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurveRepresentation_GetBounds_09(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation
	/// API. Note that a version of place widget is available where the
	/// center and handle position are specified.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkCurveRepresentation_GetBounds_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetClosed_10(HandleRef pThis);

	/// <summary>
	/// Control whether the curve is open or closed. A closed forms a
	/// continuous loop: the first and last points are the same.  A
	/// minimum of 3 handles are required to form a closed loop.
	/// </summary>
	public virtual int GetClosed()
	{
		return vtkCurveRepresentation_GetClosed_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetCurrentHandleIndex_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the current handle index. Setting the current handle index will
	/// also result in the handle being highlighted. Set to `-1` to remove the
	/// highlight.
	/// </summary>
	public virtual int GetCurrentHandleIndex()
	{
		return vtkCurveRepresentation_GetCurrentHandleIndex_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCurveRepresentation_GetDirectional_12(HandleRef pThis);

	/// <summary>
	/// Set the representation to be directional or not.
	/// The meaning of being directional depends on the representation and
	/// its handles implementations in the subclasses.
	/// </summary>
	public virtual bool GetDirectional()
	{
		return (vtkCurveRepresentation_GetDirectional_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_GetHandlePosition_13(HandleRef pThis, int handle, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public virtual void GetHandlePosition(int handle, IntPtr xyz)
	{
		vtkCurveRepresentation_GetHandlePosition_13(GetCppThis(), handle, xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurveRepresentation_GetHandlePosition_14(HandleRef pThis, int handle);

	/// <summary>
	/// Set/Get the position of the handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public virtual IntPtr GetHandlePosition(int handle)
	{
		return vtkCurveRepresentation_GetHandlePosition_14(GetCppThis(), handle);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurveRepresentation_GetHandlePositions_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the position of the handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public virtual vtkDoubleArray GetHandlePositions()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurveRepresentation_GetHandlePositions_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurveRepresentation_GetHandleProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties (the spheres are the handles). The
	/// properties of the handles when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurveRepresentation_GetHandleProperty_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCurveRepresentation_GetLineProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurveRepresentation_GetLineProperty_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCurveRepresentation_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCurveRepresentation_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCurveRepresentation_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCurveRepresentation_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetNumberOfHandles_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of handles for this widget.
	/// </summary>
	public virtual int GetNumberOfHandles()
	{
		return vtkCurveRepresentation_GetNumberOfHandles_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_GetPolyData_21(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the
	/// interpolating curve. Points are guaranteed to be up-to-date when
	/// either the InteractionEvent or EndInteraction events are
	/// invoked. The user provides the vtkPolyData and the points and
	/// polyline are added to it.
	/// </summary>
	public virtual void GetPolyData(vtkPolyData pd)
	{
		vtkCurveRepresentation_GetPolyData_21(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetProjectToPlane_22(HandleRef pThis);

	/// <summary>
	/// Force the widget to be projected onto one of the orthogonal
	/// planes.  Remember that when the InteractionState changes, a
	/// ModifiedEvent is invoked.  This can be used to snap the curve to
	/// the plane if it is originally not aligned.  The normal in
	/// SetProjectionNormal is 0,1,2 for YZ,XZ,XY planes respectively and
	/// 3 for arbitrary oblique planes when the widget is tied to a
	/// vtkPlaneSource.
	/// </summary>
	public virtual int GetProjectToPlane()
	{
		return vtkCurveRepresentation_GetProjectToPlane_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetProjectionNormal_23(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormal()
	{
		return vtkCurveRepresentation_GetProjectionNormal_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetProjectionNormalMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormalMaxValue()
	{
		return vtkCurveRepresentation_GetProjectionNormalMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetProjectionNormalMinValue_25(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual int GetProjectionNormalMinValue()
	{
		return vtkCurveRepresentation_GetProjectionNormalMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCurveRepresentation_GetProjectionPosition_26(HandleRef pThis);

	/// <summary>
	/// Set the position of poly line handles and points in terms of a plane's
	/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
	/// values of the points are set to position. Any value can be passed (and is
	/// ignored) to update the poly line points when Projection normal is set to 3
	/// for arbitrary plane orientations.
	/// </summary>
	public virtual double GetProjectionPosition()
	{
		return vtkCurveRepresentation_GetProjectionPosition_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurveRepresentation_GetSelectedHandleProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle properties (the spheres are the handles). The
	/// properties of the handles when selected and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurveRepresentation_GetSelectedHandleProperty_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCurveRepresentation_GetSelectedLineProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the line properties. The properties of the line when selected
	/// and unselected can be manipulated.
	/// </summary>
	public virtual vtkProperty GetSelectedLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurveRepresentation_GetSelectedLineProperty_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkCurveRepresentation_GetSummedLength_29(HandleRef pThis);

	/// <summary>
	/// Get the approximate vs. the true arc length of the curve. Calculated as
	/// the summed lengths of the individual straight line segments. Use
	/// SetResolution to control the accuracy.
	/// </summary>
	public virtual double GetSummedLength()
	{
		return vtkCurveRepresentation_GetSummedLength_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetTranslationAxis_30(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxis()
	{
		return vtkCurveRepresentation_GetTranslationAxis_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetTranslationAxisMaxValue_31(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMaxValue()
	{
		return vtkCurveRepresentation_GetTranslationAxisMaxValue_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_GetTranslationAxisMinValue_32(HandleRef pThis);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual int GetTranslationAxisMinValue()
	{
		return vtkCurveRepresentation_GetTranslationAxisMinValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_HasTranslucentPolygonalGeometry_33(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCurveRepresentation_HasTranslucentPolygonalGeometry_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_InitializeHandles_34(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Convenience method to allocate and set the handles from a
	/// vtkPoints instance.  If the first and last points are the same,
	/// the curve sets Closed to the on InteractionState and disregards
	/// the last point, otherwise Closed remains unchanged.
	/// </summary>
	public virtual void InitializeHandles(vtkPoints points)
	{
		vtkCurveRepresentation_InitializeHandles_34(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_IsA_35(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCurveRepresentation_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_IsClosed_36(HandleRef pThis);

	/// <summary>
	/// Convenience method to determine whether the curve is
	/// closed in a geometric sense.  The widget may be set "closed" but still
	/// be geometrically open (e.g., a straight line).
	/// </summary>
	public int IsClosed()
	{
		return vtkCurveRepresentation_IsClosed_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCurveRepresentation_IsTranslationConstrained_37(HandleRef pThis);

	/// <summary>
	/// Returns true if ConstrainedAxis
	/// </summary>
	public bool IsTranslationConstrained()
	{
		return (vtkCurveRepresentation_IsTranslationConstrained_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_IsTypeOf_38(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCurveRepresentation_IsTypeOf_38(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurveRepresentation_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCurveRepresentation NewInstance()
	{
		vtkCurveRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurveRepresentation_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCurveRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_ProjectToPlaneOff_40(HandleRef pThis);

	/// <summary>
	/// Force the widget to be projected onto one of the orthogonal
	/// planes.  Remember that when the InteractionState changes, a
	/// ModifiedEvent is invoked.  This can be used to snap the curve to
	/// the plane if it is originally not aligned.  The normal in
	/// SetProjectionNormal is 0,1,2 for YZ,XZ,XY planes respectively and
	/// 3 for arbitrary oblique planes when the widget is tied to a
	/// vtkPlaneSource.
	/// </summary>
	public virtual void ProjectToPlaneOff()
	{
		vtkCurveRepresentation_ProjectToPlaneOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_ProjectToPlaneOn_41(HandleRef pThis);

	/// <summary>
	/// Force the widget to be projected onto one of the orthogonal
	/// planes.  Remember that when the InteractionState changes, a
	/// ModifiedEvent is invoked.  This can be used to snap the curve to
	/// the plane if it is originally not aligned.  The normal in
	/// SetProjectionNormal is 0,1,2 for YZ,XZ,XY planes respectively and
	/// 3 for arbitrary oblique planes when the widget is tied to a
	/// vtkPlaneSource.
	/// </summary>
	public virtual void ProjectToPlaneOn()
	{
		vtkCurveRepresentation_ProjectToPlaneOn_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_RegisterPickers_42(HandleRef pThis);

	/// <summary>
	/// Convenience method to set the line color.
	/// Ideally one should use GetLineProperty()-&gt;SetColor().
	/// </summary>
	public override void RegisterPickers()
	{
		vtkCurveRepresentation_RegisterPickers_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_ReleaseGraphicsResources_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCurveRepresentation_ReleaseGraphicsResources_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_RenderOpaqueGeometry_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkCurveRepresentation_RenderOpaqueGeometry_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_RenderOverlay_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderOverlay(vtkViewport arg0)
	{
		return vtkCurveRepresentation_RenderOverlay_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCurveRepresentation_RenderTranslucentPolygonalGeometry_46(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCurveRepresentation_RenderTranslucentPolygonalGeometry_46(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCurveRepresentation_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCurveRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCurveRepresentation vtkCurveRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCurveRepresentation_SafeDownCast_47(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCurveRepresentation2 = (vtkCurveRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCurveRepresentation2.Register(null);
			}
		}
		return vtkCurveRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetClosed_48(HandleRef pThis, int closed);

	/// <summary>
	/// Control whether the curve is open or closed. A closed forms a
	/// continuous loop: the first and last points are the same.  A
	/// minimum of 3 handles are required to form a closed loop.
	/// </summary>
	public void SetClosed(int closed)
	{
		vtkCurveRepresentation_SetClosed_48(GetCppThis(), closed);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetCurrentHandleIndex_49(HandleRef pThis, int index);

	/// <summary>
	/// Get/Set the current handle index. Setting the current handle index will
	/// also result in the handle being highlighted. Set to `-1` to remove the
	/// highlight.
	/// </summary>
	public void SetCurrentHandleIndex(int index)
	{
		vtkCurveRepresentation_SetCurrentHandleIndex_49(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetDirectional_50(HandleRef pThis, byte val);

	/// <summary>
	/// Set the representation to be directional or not.
	/// The meaning of being directional depends on the representation and
	/// its handles implementations in the subclasses.
	/// </summary>
	public virtual void SetDirectional(bool val)
	{
		vtkCurveRepresentation_SetDirectional_50(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetHandlePosition_51(HandleRef pThis, int handle, double x, double y, double z);

	/// <summary>
	/// Set/Get the position of the handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public virtual void SetHandlePosition(int handle, double x, double y, double z)
	{
		vtkCurveRepresentation_SetHandlePosition_51(GetCppThis(), handle, x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetHandlePosition_52(HandleRef pThis, int handle, IntPtr xyz);

	/// <summary>
	/// Set/Get the position of the handles. Call GetNumberOfHandles
	/// to determine the valid range of handle indices.
	/// </summary>
	public virtual void SetHandlePosition(int handle, IntPtr xyz)
	{
		vtkCurveRepresentation_SetHandlePosition_52(GetCppThis(), handle, xyz);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetInteractionState_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the interaction state
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkCurveRepresentation_SetInteractionState_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetLineColor_54(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Convenience method to set the line color.
	/// Ideally one should use GetLineProperty()-&gt;SetColor().
	/// </summary>
	public void SetLineColor(double r, double g, double b)
	{
		vtkCurveRepresentation_SetLineColor_54(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetNumberOfHandles_55(HandleRef pThis, int npts);

	/// <summary>
	/// Set/Get the number of handles for this widget.
	/// </summary>
	public virtual void SetNumberOfHandles(int npts)
	{
		vtkCurveRepresentation_SetNumberOfHandles_55(GetCppThis(), npts);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetPlaneSource_56(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetPlaneSource(vtkPlaneSource plane)
	{
		vtkCurveRepresentation_SetPlaneSource_56(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetProjectToPlane_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Force the widget to be projected onto one of the orthogonal
	/// planes.  Remember that when the InteractionState changes, a
	/// ModifiedEvent is invoked.  This can be used to snap the curve to
	/// the plane if it is originally not aligned.  The normal in
	/// SetProjectionNormal is 0,1,2 for YZ,XZ,XY planes respectively and
	/// 3 for arbitrary oblique planes when the widget is tied to a
	/// vtkPlaneSource.
	/// </summary>
	public virtual void SetProjectToPlane(int _arg)
	{
		vtkCurveRepresentation_SetProjectToPlane_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetProjectionNormal_58(HandleRef pThis, int _arg);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public virtual void SetProjectionNormal(int _arg)
	{
		vtkCurveRepresentation_SetProjectionNormal_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetProjectionNormalToOblique_59(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToOblique()
	{
		vtkCurveRepresentation_SetProjectionNormalToOblique_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetProjectionNormalToXAxes_60(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToXAxes()
	{
		vtkCurveRepresentation_SetProjectionNormalToXAxes_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetProjectionNormalToYAxes_61(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToYAxes()
	{
		vtkCurveRepresentation_SetProjectionNormalToYAxes_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetProjectionNormalToZAxes_62(HandleRef pThis);

	/// <summary>
	/// Set up a reference to a vtkPlaneSource that could be from another widget
	/// object, e.g. a vtkPolyDataSourceWidget.
	/// </summary>
	public void SetProjectionNormalToZAxes()
	{
		vtkCurveRepresentation_SetProjectionNormalToZAxes_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetProjectionPosition_63(HandleRef pThis, double position);

	/// <summary>
	/// Set the position of poly line handles and points in terms of a plane's
	/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
	/// values of the points are set to position. Any value can be passed (and is
	/// ignored) to update the poly line points when Projection normal is set to 3
	/// for arbitrary plane orientations.
	/// </summary>
	public void SetProjectionPosition(double position)
	{
		vtkCurveRepresentation_SetProjectionPosition_63(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetTranslationAxis_64(HandleRef pThis, int _arg);

	/// <summary>
	/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
	/// if none.
	/// </summary>
	public virtual void SetTranslationAxis(int _arg)
	{
		vtkCurveRepresentation_SetTranslationAxis_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetTranslationAxisOff_65(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetTranslationAxisOff()
	{
		vtkCurveRepresentation_SetTranslationAxisOff_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetXTranslationAxisOn_66(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetXTranslationAxisOn()
	{
		vtkCurveRepresentation_SetXTranslationAxisOn_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetYTranslationAxisOn_67(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetYTranslationAxisOn()
	{
		vtkCurveRepresentation_SetYTranslationAxisOn_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_SetZTranslationAxisOn_68(HandleRef pThis);

	/// <summary>
	/// Toggles constraint translation axis on/off.
	/// </summary>
	public void SetZTranslationAxisOn()
	{
		vtkCurveRepresentation_SetZTranslationAxisOn_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_StartWidgetInteraction_69(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation
	/// API. Note that a version of place widget is available where the
	/// center and handle position are specified.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkCurveRepresentation_StartWidgetInteraction_69(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCurveRepresentation_WidgetInteraction_70(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation
	/// API. Note that a version of place widget is available where the
	/// center and handle position are specified.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkCurveRepresentation_WidgetInteraction_70(GetCppThis(), e);
	}
}
