using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOBBTree
/// </summary>
/// <remarks>
///    generate oriented bounding box (OBB) tree
///
/// vtkOBBTree is an object to generate oriented bounding box (OBB) trees.
/// An oriented bounding box is a bounding box that does not necessarily line
/// up along coordinate axes. The OBB tree is a hierarchical tree structure
/// of such boxes, where deeper levels of OBB confine smaller regions of space.
///
/// To build the OBB, a recursive, top-down process is used. First, the root OBB
/// is constructed by finding the mean and covariance matrix of the cells (and
/// their points) that define the dataset. The eigenvectors of the covariance
/// matrix are extracted, giving a set of three orthogonal vectors that define
/// the tightest-fitting OBB. To create the two children OBB's, a split plane
/// is found that (approximately) divides the number cells in half. These are
/// then assigned to the children OBB's. This process then continues until
/// the MaxLevel ivar limits the recursion, or no split plane can be found.
///
/// A good reference for OBB-trees is Gottschalk &amp; Manocha in Proceedings of
/// Siggraph `96.
///
/// @warning
/// vtkOBBTree utilizes the following parent class parameters:
/// - Tolerance                   (default 0.01)
/// - Level                       (default 4)
/// - MaxLevel                    (default 12)
/// - NumberOfCellsPerNode        (default 32)
/// - RetainCellLists             (default true)
/// - UseExistingSearchStructure  (default false)
///
/// vtkOBBTree does NOT utilize the following parameters:
/// - Automatic
/// - CacheCellBounds
///
/// @warning
/// Since this algorithms works from a list of cells, the OBB tree will only
/// bound the "geometry" attached to the cells if the convex hull of the
/// cells bounds the geometry.
///
/// @warning
/// Long, skinny cells (i.e., cells with poor aspect ratio) may cause
/// unsatisfactory results. This is due to the fact that this is a top-down
/// implementation of the OBB tree, requiring that one or more complete cells
/// are contained in each OBB. This requirement makes it hard to find good
/// split planes during the recursion process. A bottom-up implementation would
/// go a long way to correcting this problem.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractCellLocator vtkCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkModifiedBSPTree
/// </seealso>
public class vtkOBBTree : vtkAbstractCellLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOBBTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOBBTree()
	{
		MRClassNameKey = "class vtkOBBTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBBTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOBBTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBBTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 25 cells per octant.
	/// </summary>
	public new static vtkOBBTree New()
	{
		vtkOBBTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOBBTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with automatic computation of divisions, averaging
	/// 25 cells per octant.
	/// </summary>
	public vtkOBBTree()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOBBTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBBTree_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// Satisfy locator's abstract interface, see vtkLocator.
	/// </summary>
	public override void BuildLocator()
	{
		vtkOBBTree_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBBTree_ComputeOBB_02(HandleRef pts, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size);

	/// <summary>
	/// Compute an OBB from the list of points given. Return the corner point
	/// and the three axes defining the orientation of the OBB. Also return
	/// a sorted list of relative "sizes" of axes for comparison purposes.
	/// </summary>
	public static void ComputeOBB(vtkPoints pts, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size)
	{
		vtkOBBTree_ComputeOBB_02(pts?.GetCppThis() ?? default(HandleRef), corner, max, mid, min, size);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBBTree_ComputeOBB_03(HandleRef pThis, HandleRef input, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size);

	/// <summary>
	/// Compute an OBB for the input dataset using the cells in the data.
	/// Return the corner point and the three axes defining the orientation
	/// of the OBB. Also return a sorted list of relative "sizes" of axes for
	/// comparison purposes.
	/// </summary>
	public void ComputeOBB(vtkDataSet input, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size)
	{
		vtkOBBTree_ComputeOBB_03(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), corner, max, mid, min, size);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBBTree_ForceBuildLocator_04(HandleRef pThis);

	/// <summary>
	/// Satisfy locator's abstract interface, see vtkLocator.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkOBBTree_ForceBuildLocator_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBBTree_FreeSearchStructure_05(HandleRef pThis);

	/// <summary>
	/// Satisfy locator's abstract interface, see vtkLocator.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkOBBTree_FreeSearchStructure_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBBTree_GenerateRepresentation_06(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Create polygonal representation for OBB tree at specified level. If
	/// level &lt; 0, then the leaf OBB nodes will be gathered. The aspect ratio (ar)
	/// and line diameter (d) are used to control the building of the
	/// representation. If a OBB node edge ratio's are greater than ar, then the
	/// dimension of the OBB is collapsed (OBB-&gt;plane-&gt;line). A "line" OBB will be
	/// represented either as two crossed polygons, or as a line, depending on
	/// the relative diameter of the OBB compared to the diameter (d).
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkOBBTree_GenerateRepresentation_06(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOBBTree_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOBBTree_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOBBTree_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOBBTree_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOBBTree_InsideOrOutside_09(HandleRef pThis, IntPtr point);

	/// <summary>
	/// Determine whether a point is inside or outside the data used to build
	/// this OBB tree.  The data must be a closed surface vtkPolyData data set.
	/// The return value is +1 if outside, -1 if inside, and 0 if undecided.
	/// </summary>
	public int InsideOrOutside(IntPtr point)
	{
		return vtkOBBTree_InsideOrOutside_09(GetCppThis(), point);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOBBTree_IntersectWithLine_10(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

	/// <summary>
	/// Return the first intersection of the specified line segment with
	/// the OBB tree, as well as information about the cell which the
	/// line segment intersected. A return value of 1 indicates an intersection
	/// and 0 indicates no intersection.
	/// </summary>
	public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
	{
		return vtkOBBTree_IntersectWithLine_10(GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOBBTree_IntersectWithLine_11(HandleRef pThis, IntPtr a0, IntPtr a1, HandleRef points, HandleRef cellIds);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// This method assumes that the data set is a vtkPolyData that describes
	/// a closed surface, and the intersection points that are returned in
	/// 'points' alternate between entrance points and exit points.
	/// The return value of the function is 0 if no intersections were found,
	/// -1 if point 'a0' lies inside the closed surface, or +1 if point 'a0'
	/// lies outside the closed surface.
	/// Either 'points' or 'cellIds' can be set to nullptr if you don't want
	/// to receive that information.
	/// </summary>
	public override int IntersectWithLine(IntPtr a0, IntPtr a1, vtkPoints points, vtkIdList cellIds)
	{
		return vtkOBBTree_IntersectWithLine_11(GetCppThis(), a0, a1, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOBBTree_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOBBTree_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOBBTree_IsTypeOf_13(string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOBBTree_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBBTree_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new vtkOBBTree NewInstance()
	{
		vtkOBBTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOBBTree_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBBTree_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static vtkOBBTree SafeDownCast(vtkObjectBase o)
	{
		vtkOBBTree vtkOBBTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOBBTree_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOBBTree2 = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOBBTree2.Register(null);
			}
		}
		return vtkOBBTree2;
	}
}
