using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkModifiedBSPTree
/// </summary>
/// <remarks>
///    Generate axis aligned BBox tree for ray-casting and other Locator based searches
///
///
/// vtkModifiedBSPTree creates an evenly balanced BSP tree using a top down
/// implementation. Axis aligned split planes are found which evenly divide
/// cells into two buckets. Generally a split plane will intersect some cells
/// and these are usually stored in both child nodes of the current parent.
/// (Or split into separate cells which we cannot consider in this case).
/// Storing cells in multiple buckets creates problems associated with multiple
/// tests against rays and increases the required storage as complex meshes
/// will have many cells straddling a split plane (and further splits may
/// cause multiple copies of these).
///
/// During a discussion with Arno Formella in 1998 he suggested using
/// a third child node to store objects which straddle split planes. I've not
/// seen this published (Yes! - see below), but thought it worth trying. This
/// implementation of the BSP tree creates a third child node for storing cells
/// laying across split planes, the third cell may overlap the other two, but the
/// two 'proper' nodes otherwise conform to usual BSP rules.
///
/// The advantage of this implementation is cells only ever lie in one node
/// and mailbox testing is avoided. All BBoxes are axis aligned and a ray cast
/// uses an efficient search strategy based on near/far nodes and rejects
/// all BBoxes using simple tests.
///
/// For fast raytracing, 6 copies of cell lists are stored in each leaf node
/// each list is in axis sorted order +/- x,y,z and cells are always tested
/// in the direction of the ray dominant axis. Once an intersection is found
/// any cell or BBox with a closest point further than the I-point can be
/// instantly rejected and raytracing stops as soon as no nodes can be closer
/// than the current best intersection point.
///
/// The addition of the 'middle' node upsets the optimal balance of the tree,
/// but is a minor overhead during the raytrace. Each child node is contracted
/// such that it tightly fits all cells inside it, enabling further ray/box
/// rejections.
///
/// This class is intended for persons requiring many ray tests and is optimized
/// for this purpose. As no cell ever lies in more than one leaf node, and parent
/// nodes do not maintain cell lists, the memory overhead of the sorted cell
/// lists is 6*num_cells*4 for 6 lists of ints, each num_cells in length.
/// The memory requirement of the nodes themselves is usually of minor
/// significance.
///
/// Subdivision is controlled by MaxCellsPerNode - any node with more than
/// this number will be subdivided providing a good split plane can be found and
/// the max depth is not exceeded.
///
/// The average cells per leaf will usually be around half the MaxCellsPerNode,
/// though the middle node is usually sparsely populated and lowers the average
/// slightly. The middle node will not be created when not needed.
/// Subdividing down to very small cells per node is not generally suggested
/// as then the 6 stored cell lists are effectively redundant.
///
/// Values of MaxCellsPerNode of around 16-&gt;128 depending on dataset size will
/// usually give good results.
///
/// Cells are only sorted into 6 lists once - before tree creation, each node
/// segments the lists and passes them down to the new child nodes whilst
/// maintaining sorted order. This makes for an efficient subdivision strategy.
///
/// @warning
/// vtkModifiedBSPTree utilizes the following parent class parameters:
/// - Level                       (default 8)
/// - MaxLevel                    (default 8)
/// - NumberOfCellsPerNode        (default 32)
/// - UseExistingSearchStructure  (default false)
/// - CacheCellBounds             (default true)
///
/// vtkModifiedBSPTree does NOT utilize the following parameters:
/// - Automatic
/// - Tolerance
/// - RetainCellLists
///
/// NB. The following reference has been sent to me
/// <code>
///   @Article{formella-1995-ray,
///     author =     "Arno Formella and Christian Gill",
///     title =      "{Ray Tracing: A Quantitative Analysis and a New
///                   Practical Algorithm}",
///     journal =    "{The Visual Computer}",
///     year =       "{1995}",
///     month =       dec,
///     pages =      "{465--476}",
///     volume =     "{11}",
///     number =     "{9}",
///     publisher =  "{Springer}",
///     keywords =   "{ray tracing, space subdivision, plane traversal,
///                    octree, clustering, benchmark scenes}",
///     annote =     "{We present a new method to accelerate the process of
///                    finding nearest ray--object intersections in ray
///                    tracing. The algorithm consumes an amount of memory
///                    more or less linear in the number of objects. The basic
///                    ideas can be characterized with a modified BSP--tree
///                    and plane traversal. Plane traversal is a fast linear
///                    time algorithm to find the closest intersection point
///                    in a list of bounding volumes hit by a ray. We use
///                    plane traversal at every node of the high outdegree
///                    BSP--tree. Our implementation is competitive to fast
///                    ray tracing programs. We present a benchmark suite
///                    which allows for an extensive comparison of ray tracing
///                    algorithms.}",
///   }
/// </code>
///
/// @par Thanks:
///  John Biddiscombe for developing and contributing this class
///
/// @todo
/// -------------
/// Implement intersection heap for testing rays against transparent objects
///
/// @par Style:
/// --------------
/// This class is currently maintained by J. Biddiscombe who has specially
/// requested that the code style not be modified to the Kitware standard.
/// Please respect the contribution of this class by keeping the style
/// as close as possible to the author's original.
///
/// </remarks>
/// <seealso>
///
/// vtkAbstractCellLocator vtkCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkOBBTree
/// </seealso>
public class vtkModifiedBSPTree : vtkAbstractCellLocator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkModifiedBSPTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkModifiedBSPTree()
	{
		MRClassNameKey = "class vtkModifiedBSPTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkModifiedBSPTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkModifiedBSPTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModifiedBSPTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with maximum 32 cells per node. (average 16-&gt;31)
	/// </summary>
	public new static vtkModifiedBSPTree New()
	{
		vtkModifiedBSPTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModifiedBSPTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with maximum 32 cells per node. (average 16-&gt;31)
	/// </summary>
	public vtkModifiedBSPTree()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkModifiedBSPTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModifiedBSPTree_BuildLocator_01(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void BuildLocator()
	{
		vtkModifiedBSPTree_BuildLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkModifiedBSPTree_FindCell_02(HandleRef pThis, IntPtr x, double arg1, HandleRef GenCell, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Find the cell containing a given point. returns -1 if no cell found
	/// the cell parameters are copied into the supplied variables, a cell must
	/// be provided to store the information.
	///
	/// For other FindCell signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override long FindCell(IntPtr x, double arg1, vtkGenericCell GenCell, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkModifiedBSPTree_FindCell_02(GetCppThis(), x, arg1, GenCell?.GetCppThis() ?? default(HandleRef), ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModifiedBSPTree_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// For each intersection with the bounds of a cell, the cellIds
	/// have the relevant information added sort by t. If cellIds is nullptr
	/// pointer, then no information is generated for that list.
	///
	/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
	/// </summary>
	public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
	{
		vtkModifiedBSPTree_FindCellsAlongLine_03(GetCppThis(), p1, p2, tolerance, cellsIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModifiedBSPTree_ForceBuildLocator_04(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void ForceBuildLocator()
	{
		vtkModifiedBSPTree_ForceBuildLocator_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModifiedBSPTree_FreeSearchStructure_05(HandleRef pThis);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void FreeSearchStructure()
	{
		vtkModifiedBSPTree_FreeSearchStructure_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModifiedBSPTree_GenerateRepresentation_06(HandleRef pThis, int level, HandleRef pd);

	/// <summary>
	/// Satisfy vtkLocator abstract interface.
	/// </summary>
	public override void GenerateRepresentation(int level, vtkPolyData pd)
	{
		vtkModifiedBSPTree_GenerateRepresentation_06(GetCppThis(), level, pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModifiedBSPTree_GenerateRepresentationLeafs_07(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Generate BBox representation of all leaf nodes
	/// </summary>
	public virtual void GenerateRepresentationLeafs(vtkPolyData pd)
	{
		vtkModifiedBSPTree_GenerateRepresentationLeafs_07(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModifiedBSPTree_GetLeafNodeCellInformation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// After subdivision has completed, one may wish to query the tree to find
	/// which cells are in which leaf nodes. This function returns a list
	/// which holds a cell Id list for each leaf node.
	/// </summary>
	public vtkIdListCollection GetLeafNodeCellInformation()
	{
		vtkIdListCollection vtkIdListCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModifiedBSPTree_GetLeafNodeCellInformation_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdListCollection2 = (vtkIdListCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdListCollection2.Register(null);
			}
		}
		return vtkIdListCollection2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkModifiedBSPTree_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkModifiedBSPTree_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkModifiedBSPTree_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkModifiedBSPTree_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModifiedBSPTree_IntersectWithLine_11(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

	/// <summary>
	/// Return intersection point (if any) AND the cell which was intersected by
	/// the finite line. The cell is returned as a cell id and as a generic cell.
	///
	/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
	{
		return vtkModifiedBSPTree_IntersectWithLine_11(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModifiedBSPTree_IntersectWithLine_12(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

	/// <summary>
	/// Take the passed line segment and intersect it with the data set.
	/// The return value of the function is 0 if no intersections were found.
	/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
	/// the points and cellIds have the relevant information added sorted by t.
	/// If points or cellIds are nullptr pointers, then no information is generated for that list.
	///
	/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
	/// </summary>
	public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
	{
		return vtkModifiedBSPTree_IntersectWithLine_12(GetCppThis(), p1, p2, tol, points?.GetCppThis() ?? default(HandleRef), cellIds?.GetCppThis() ?? default(HandleRef), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModifiedBSPTree_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkModifiedBSPTree_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModifiedBSPTree_IsTypeOf_14(string type);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkModifiedBSPTree_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModifiedBSPTree_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new vtkModifiedBSPTree NewInstance()
	{
		vtkModifiedBSPTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModifiedBSPTree_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModifiedBSPTree_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to print and obtain type-related information.
	/// </summary>
	public new static vtkModifiedBSPTree SafeDownCast(vtkObjectBase o)
	{
		vtkModifiedBSPTree vtkModifiedBSPTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModifiedBSPTree_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkModifiedBSPTree2 = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkModifiedBSPTree2.Register(null);
			}
		}
		return vtkModifiedBSPTree2;
	}

	[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModifiedBSPTree_ShallowCopy_18(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Shallow copy of a vtkModifiedBSPTree.
	/// </summary>
	public override void ShallowCopy(vtkAbstractCellLocator locator)
	{
		vtkModifiedBSPTree_ShallowCopy_18(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}
}
