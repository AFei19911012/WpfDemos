using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphericalPointIterator
/// </summary>
/// <remarks>
///    Traverse a collection of points in spherical ordering.
///
///
/// vtkSphericalPointIterator is a state-based iterator for traversing a set
/// of points (i.e., a neighborhood of points) in a dataset, providing a point
/// traversal order across user-defined "axes" which span a 2D or 3D space
/// (typically a circle or sphere). The points along each axes may be sorted
/// in increasing radial order. To define the points, specify a dataset (i.e.,
/// its associated points, whether the points are represented implicitly or
/// explicitly) and an associated neighborhood over which to iterate. Methods
/// for iterating over the points are provided.
///
/// For example, consider the axes of iteration to be the four rays emanating
/// from the center of a square and passing through the center of each of the
/// four edges of the square. Points to be iterated over are associated (using
/// a dot product) with each of the four axes, and then can be sorted along
/// each axis. Then the order of iteration is then: (axis0,pt0), (axis1,pt0),
/// (axis2,pt0), (axis3,pt0), (axis0,pt1), (axis1,pt1), (axis2,pt1),
/// (axis3,pt1), (axis0,pt2), (axis1,pt2), (axis2,pt2), (axis3,pt2), and so on
/// in a "spiraling" fashion until all points are visited. Thus the order of
/// visitation is: iteration i visits all N axes in order, returning the jth
/// point sorted along each of the N axes (i.e., i increases the fastest).
/// Alternatively, methods exist to randomly access points, or points
/// associated with an axes, so that custom iteration methods can be defined.
///
/// The iterator can be defined with any number of axes (defined by 3D
/// vectors). The axes must not be coincident, and typically are equally
/// spaced from one another. The order which the axes are defined determines
/// the order in which the axes (and hence the points) are traversed. So for
/// example, in a 2D sphere, four axes in the (-x,+x,-y,+y) directions would
/// provide a "ping pong" iteration, while four axes ordered in the
/// (+x,+y,-x,-y) directions would provide a counterclockwise rotation
/// iteration.
///
/// The iterator provides thread-safe iteration of dataset points. It supports
/// both random and forward iteration.
///
/// @warning
/// The behavior of the iterator depends on the ordering of the iteration
/// axes. It is possible to obtain a wide variety of iteration patterns
/// depending on these axes. For example, if only one axis is defined, then a
/// "linear" pattern is possible (i.e., visiting points in the half space
/// defined by the vector); if two axes, then a "diagonal" iteration pattern;
/// and so on. Note that points are sorted along the iteration axes depending
/// on the their projection onto them (e.g., using the dot product). Because
/// only points with positive projection are associated with an axis, it is
/// possible that some points in the neighborhood will not be processed (i.e.,
/// if a point in the neighborhood does not positively project onto any of the
/// axes, then it will not be iterated over). Thus if all points are to be
/// iterated over, then the axes must form a basis which covers all points
/// using positive projections.
///
/// </remarks>
/// <seealso>
///
/// vtkVoronoi2D vtkVoronoi3D vtkStaticPointLocator vtkPointLocator
/// </seealso>
public class vtkSphericalPointIterator : vtkObject
{
	/// <summary>
	/// While the axes can be arbitrarily specified, it is possible to select
	/// axes from a menu of predefined axes sets. For example, XY_CW_AXES refer
	/// to axes that rotate in clockwise direction starting with the first axis
	/// parallel to the x-axis; with the total number of axes given by the
	/// resolution.  Some 3D regular polyhedral solids are also referred to: the
	/// axes pass through the center of the faces of the solid. So DODECAHEDRON
	/// axes refer to the 12 axes that pass through the center of the 12 faces
	/// of the dodecahedron. In some cases the resolution parameter need not be
	/// specified.
	/// </summary>
	public enum AxesType
	{
		/// <summary>enum member</summary>
		CUBE_AXES = 3,
		/// <summary>enum member</summary>
		CUBE_OCTAHEDRON_AXES = 5,
		/// <summary>enum member</summary>
		DODECAHEDRON_AXES = 6,
		/// <summary>enum member</summary>
		ICOSAHEDRON_AXES = 7,
		/// <summary>enum member</summary>
		OCTAHEDRON_AXES = 4,
		/// <summary>enum member</summary>
		XY_CCW_AXES = 1,
		/// <summary>enum member</summary>
		XY_CW_AXES = 0,
		/// <summary>enum member</summary>
		XY_SQUARE_AXES = 2
	}

	/// <summary>
	/// Points can be sorted along each axis. By default, no sorting is
	/// performed.  Other options are ascending and descending radial
	/// order. Ascended sorting results in point traversal starting near the
	/// center of the iterator, and proceeding radially outward. Descended
	/// sorting results in point traversal starting away from the center of the
	/// iterator, and proceeding radially inward.
	/// </summary>
	public enum SortType
	{
		/// <summary>enum member</summary>
		SORT_ASCENDING = 1,
		/// <summary>enum member</summary>
		SORT_DESCENDING = 2,
		/// <summary>enum member</summary>
		SORT_NONE = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphericalPointIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphericalPointIterator()
	{
		MRClassNameKey = "class vtkSphericalPointIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphericalPointIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphericalPointIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalPointIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, obtain type information, and
	/// print information about an instance of the class.
	/// </summary>
	public new static vtkSphericalPointIterator New()
	{
		vtkSphericalPointIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphericalPointIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphericalPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to instantiate, obtain type information, and
	/// print information about an instance of the class.
	/// </summary>
	public vtkSphericalPointIterator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphericalPointIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_BuildRepresentation_01(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// A convenience method that produces a geometric representation of the
	/// iterator (e.g., axes + center). The representation simply draws lines
	/// for each of the axes emanating from the center point. Each line (or line
	/// cell) is assigned cell data which is the axis number. This is typically
	/// used for debugging or educational purposes. Note that the method
	/// is valid only after Initialize() has been invoked.
	/// </summary>
	public void BuildRepresentation(vtkPolyData pd)
	{
		vtkSphericalPointIterator_BuildRepresentation_01(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalPointIterator_GetAxes_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Define the axes for the point iterator. This only needs to be defined
	/// once (typically immediately after instantiation). The axes data array
	/// must be a 3-component array, where each 3-tuple defines a vector
	/// defining a axis. The number of axes is limited to 100,000 or less
	/// (typically the numbers of axes are &lt;=20). The order in which the axes
	/// are defined determines the order in which the axes are
	/// traversed. Depending on the order, it's possible to create a variety of
	/// traversal patterns, ranging from clockwise/counterclockwise to spiral to
	/// ping pong (e.g., -x,+x, -y,+y, -z,+z). Note: the defining axes need not
	/// be normalized, they are normalized and copied into internal iterator
	/// storage in the Initialize() method.
	/// </summary>
	public virtual vtkDoubleArray GetAxes()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphericalPointIterator_GetAxes_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_GetCurrentPoint_03(HandleRef pThis, ref long ptId, IntPtr x);

	/// <summary>
	/// Get the current point (point id and coordinates) during
	/// forward iteration.
	/// </summary>
	public void GetCurrentPoint(ref long ptId, IntPtr x)
	{
		vtkSphericalPointIterator_GetCurrentPoint_03(GetCppThis(), ref ptId, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphericalPointIterator_GetCurrentPoint_04(HandleRef pThis);

	/// <summary>
	/// Return the current point id during forward iteration.
	/// </summary>
	public long GetCurrentPoint()
	{
		return vtkSphericalPointIterator_GetCurrentPoint_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalPointIterator_GetDataSet_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Define the dataset and its associated points over which to iterate.
	/// </summary>
	public virtual vtkDataSet GetDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphericalPointIterator_GetDataSet_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphericalPointIterator_GetNumberOfAxes_06(HandleRef pThis);

	/// <summary>
	/// Return the number of axes defined. The value returned is valid only
	/// after Initialize() is invoked.
	/// </summary>
	public long GetNumberOfAxes()
	{
		return vtkSphericalPointIterator_GetNumberOfAxes_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphericalPointIterator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, obtain type information, and
	/// print information about an instance of the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphericalPointIterator_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphericalPointIterator_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods to instantiate, obtain type information, and
	/// print information about an instance of the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphericalPointIterator_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphericalPointIterator_GetPoint_09(HandleRef pThis, int axis, int ptIdx);

	/// <summary>
	/// Provide random access to the jth point of the ith axis. Returns the point id
	/// located at (axis,ptIdx); or a value &lt;0 if the requested point does not exist.
	/// </summary>
	public long GetPoint(int axis, int ptIdx)
	{
		return vtkSphericalPointIterator_GetPoint_09(GetCppThis(), axis, ptIdx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalPointIterator_GetSorting_10(HandleRef pThis);

	/// <summary>
	/// Specify whether points along each axis are radially sorted, and if so,
	/// whether in an ascending or descending direction. (Note that some
	/// operators such as the locator query FindClosestNPoints() return radially
	/// sorted neighborhoods in ascending direction and often do not need
	/// sorting - this can save significant time.)
	/// </summary>
	public virtual int GetSorting()
	{
		return vtkSphericalPointIterator_GetSorting_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalPointIterator_GetSortingMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify whether points along each axis are radially sorted, and if so,
	/// whether in an ascending or descending direction. (Note that some
	/// operators such as the locator query FindClosestNPoints() return radially
	/// sorted neighborhoods in ascending direction and often do not need
	/// sorting - this can save significant time.)
	/// </summary>
	public virtual int GetSortingMaxValue()
	{
		return vtkSphericalPointIterator_GetSortingMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalPointIterator_GetSortingMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify whether points along each axis are radially sorted, and if so,
	/// whether in an ascending or descending direction. (Note that some
	/// operators such as the locator query FindClosestNPoints() return radially
	/// sorted neighborhoods in ascending direction and often do not need
	/// sorting - this can save significant time.)
	/// </summary>
	public virtual int GetSortingMinValue()
	{
		return vtkSphericalPointIterator_GetSortingMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_GoToFirstPoint_13(HandleRef pThis);

	/// <summary>
	/// Begin iterating over the neighborhood of points. It is possible that
	/// not all points are iterated over - those points not projecting onto
	/// any axis with a positive dot product are not visited.
	/// </summary>
	public void GoToFirstPoint()
	{
		vtkSphericalPointIterator_GoToFirstPoint_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_GoToNextPoint_14(HandleRef pThis);

	/// <summary>
	/// Go to the next point in the neighborhood. This is only valid when
	/// IsDoneWithTraversal() returns false;
	/// </summary>
	public void GoToNextPoint()
	{
		vtkSphericalPointIterator_GoToNextPoint_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSphericalPointIterator_Initialize_15(HandleRef pThis, IntPtr center, HandleRef neighborhood);

	/// <summary>
	/// Initialize the iteration process around a position [x], over a set of
	/// points (the neighborhood) defined by a list of numNei point ids. (The
	/// point ids refer to the points contained in the dataset.) If
	/// initialization fails (because the Axes or the DataSet have not been
	/// defined) then false is returned; true otherwise. One of the Initialize()
	/// variants enables iteration over all points in the dataset.
	/// </summary>
	public bool Initialize(IntPtr center, vtkIdList neighborhood)
	{
		return (vtkSphericalPointIterator_Initialize_15(GetCppThis(), center, neighborhood?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSphericalPointIterator_Initialize_16(HandleRef pThis, IntPtr center, long numNei, IntPtr neighborhood);

	/// <summary>
	/// Initialize the iteration process around a position [x], over a set of
	/// points (the neighborhood) defined by a list of numNei point ids. (The
	/// point ids refer to the points contained in the dataset.) If
	/// initialization fails (because the Axes or the DataSet have not been
	/// defined) then false is returned; true otherwise. One of the Initialize()
	/// variants enables iteration over all points in the dataset.
	/// </summary>
	public bool Initialize(IntPtr center, long numNei, IntPtr neighborhood)
	{
		return (vtkSphericalPointIterator_Initialize_16(GetCppThis(), center, numNei, neighborhood) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSphericalPointIterator_Initialize_17(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Initialize the iteration process around a position [x], over a set of
	/// points (the neighborhood) defined by a list of numNei point ids. (The
	/// point ids refer to the points contained in the dataset.) If
	/// initialization fails (because the Axes or the DataSet have not been
	/// defined) then false is returned; true otherwise. One of the Initialize()
	/// variants enables iteration over all points in the dataset.
	/// </summary>
	public bool Initialize(IntPtr center)
	{
		return (vtkSphericalPointIterator_Initialize_17(GetCppThis(), center) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalPointIterator_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, obtain type information, and
	/// print information about an instance of the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphericalPointIterator_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSphericalPointIterator_IsDoneWithTraversal_19(HandleRef pThis);

	/// <summary>
	/// Return true if set traversal is completed. Otherwise false.
	/// </summary>
	public bool IsDoneWithTraversal()
	{
		return (vtkSphericalPointIterator_IsDoneWithTraversal_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphericalPointIterator_IsTypeOf_20(string type);

	/// <summary>
	/// Standard methods to instantiate, obtain type information, and
	/// print information about an instance of the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphericalPointIterator_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalPointIterator_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, obtain type information, and
	/// print information about an instance of the class.
	/// </summary>
	public new vtkSphericalPointIterator NewInstance()
	{
		vtkSphericalPointIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphericalPointIterator_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphericalPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphericalPointIterator_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, obtain type information, and
	/// print information about an instance of the class.
	/// </summary>
	public new static vtkSphericalPointIterator SafeDownCast(vtkObjectBase o)
	{
		vtkSphericalPointIterator vtkSphericalPointIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphericalPointIterator_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphericalPointIterator2 = (vtkSphericalPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphericalPointIterator2.Register(null);
			}
		}
		return vtkSphericalPointIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_SetAxes_24(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Define the axes for the point iterator. This only needs to be defined
	/// once (typically immediately after instantiation). The axes data array
	/// must be a 3-component array, where each 3-tuple defines a vector
	/// defining a axis. The number of axes is limited to 100,000 or less
	/// (typically the numbers of axes are &lt;=20). The order in which the axes
	/// are defined determines the order in which the axes are
	/// traversed. Depending on the order, it's possible to create a variety of
	/// traversal patterns, ranging from clockwise/counterclockwise to spiral to
	/// ping pong (e.g., -x,+x, -y,+y, -z,+z). Note: the defining axes need not
	/// be normalized, they are normalized and copied into internal iterator
	/// storage in the Initialize() method.
	/// </summary>
	public virtual void SetAxes(vtkDoubleArray _arg)
	{
		vtkSphericalPointIterator_SetAxes_24(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_SetAxes_25(HandleRef pThis, int axesType, int resolution);

	/// <summary>
	/// A convenience method to set the iterator axes from the predefined set
	/// enumerated above.  The resolution parameter is optional in some cases -
	/// it is used by axes types that are non-fixed such as rotation of a vector
	/// around a center point in the plane (e.g., x-y plane).
	/// </summary>
	public void SetAxes(int axesType, int resolution)
	{
		vtkSphericalPointIterator_SetAxes_25(GetCppThis(), axesType, resolution);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_SetDataSet_26(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Define the dataset and its associated points over which to iterate.
	/// </summary>
	public virtual void SetDataSet(vtkDataSet _arg)
	{
		vtkSphericalPointIterator_SetDataSet_26(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_SetSortTypeToAscending_27(HandleRef pThis);

	/// <summary>
	/// Specify whether points along each axis are radially sorted, and if so,
	/// whether in an ascending or descending direction. (Note that some
	/// operators such as the locator query FindClosestNPoints() return radially
	/// sorted neighborhoods in ascending direction and often do not need
	/// sorting - this can save significant time.)
	/// </summary>
	public void SetSortTypeToAscending()
	{
		vtkSphericalPointIterator_SetSortTypeToAscending_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_SetSortTypeToDescending_28(HandleRef pThis);

	/// <summary>
	/// Specify whether points along each axis are radially sorted, and if so,
	/// whether in an ascending or descending direction. (Note that some
	/// operators such as the locator query FindClosestNPoints() return radially
	/// sorted neighborhoods in ascending direction and often do not need
	/// sorting - this can save significant time.)
	/// </summary>
	public void SetSortTypeToDescending()
	{
		vtkSphericalPointIterator_SetSortTypeToDescending_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_SetSortTypeToNone_29(HandleRef pThis);

	/// <summary>
	/// Specify whether points along each axis are radially sorted, and if so,
	/// whether in an ascending or descending direction. (Note that some
	/// operators such as the locator query FindClosestNPoints() return radially
	/// sorted neighborhoods in ascending direction and often do not need
	/// sorting - this can save significant time.)
	/// </summary>
	public void SetSortTypeToNone()
	{
		vtkSphericalPointIterator_SetSortTypeToNone_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphericalPointIterator_SetSorting_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether points along each axis are radially sorted, and if so,
	/// whether in an ascending or descending direction. (Note that some
	/// operators such as the locator query FindClosestNPoints() return radially
	/// sorted neighborhoods in ascending direction and often do not need
	/// sorting - this can save significant time.)
	/// </summary>
	public virtual void SetSorting(int _arg)
	{
		vtkSphericalPointIterator_SetSorting_30(GetCppThis(), _arg);
	}
}
