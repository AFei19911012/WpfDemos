using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLabelHierarchy
/// </summary>
/// <remarks>
///    contains an octree of labels
///
///
/// This class represents labels in a hierarchy used to denote rendering priority.
/// A binary tree of labels is maintained that subdivides the bounds of the
/// of the label anchors spatially. Which level of the tree a label occupies
/// determines its priority; those at higher levels of the tree will be
/// more likely to render than those at lower levels of the tree.
///
/// Pass vtkLabelHierarchy objects to a vtkLabelPlacementMapper filter for dynamic,
/// non-overlapping, per-frame placement of labels.
///
/// Note that if we have a d-dimensional binary tree and we want a fixed
/// number \f$n\f$ of labels in each node (all nodes, not just leaves),
/// we can compute the depth of tree required assuming a uniform distribution
/// of points. Given a total of \f$N\f$ points we know that
/// \f$\frac{N}{|T|} = n\f$, where \f$|T|\f$ is the cardinality of the tree (i.e.,
/// the number of nodes it contains).
/// Because we have a uniform distribution, the tree will be uniformly subdivided
/// and thus \f$|T| = 1 + 2^d + \left(2^d\right)^2 + \cdots + \left(2^d\right)^k\f$,
/// where \f$d\f$ is the dimensionality of the input points (fixed at 3 for now).
/// As \f$k\f$ becomes large, \f$|T|\approx 2 \left(2^d\right)^k\f$.
/// Using this approximation, we can solve for \f$k\f$:
/// \f[ k = \frac{\log{\frac{N}{2n}}}{\log{2^d}} \f]
/// Given a set of \f$N\f$ input label anchors, we'll compute \f$k\f$ and then
/// bin the anchors into tree nodes at level \f$k\f$ of the tree. After this,
/// all the nodes will be in the leaves of the tree and those leaves will be at
/// the \f$k\f$-th level; no anchors will be in levels \f$1, 2, \ldots, k-1\f$.
/// To fix that, we'll choose to move some anchors upwards.
/// The exact number to move upwards depends on \a TargetLabelCount. We'll
/// move as many up as required to have \a TargetLabelCount at each node.
///
/// You should avoid situations where \a MaximumDepth does not allow for
/// \a TargetLabelCount or fewer entries at each node. The \a MaximumDepth
/// is a hard limit while \a TargetLabelCount is a suggested optimum. You will
/// end up with many more than \a TargetLabelCount entries per node and things
/// will be sloooow.
/// </remarks>
public class vtkLabelHierarchy : vtkPointSet
{
	/// <summary>
	/// Enumeration of iterator types.
	/// </summary>
	public enum IteratorType
	{
		/// <summary>enum member</summary>
		DEPTH_FIRST = 2,
		/// <summary>enum member</summary>
		FRUSTUM = 3,
		/// <summary>enum member</summary>
		FULL_SORT = 0,
		/// <summary>enum member</summary>
		QUEUE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLabelHierarchy()
	{
		MRClassNameKey = "class vtkLabelHierarchy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLabelHierarchy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelHierarchy New()
	{
		vtkLabelHierarchy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLabelHierarchy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLabelHierarchy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_ComputeHierarchy_01(HandleRef pThis);

	/// <summary>
	/// Fill the hierarchy with the input labels.
	/// </summary>
	public virtual void ComputeHierarchy()
	{
		vtkLabelHierarchy_ComputeHierarchy_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchy_FindCell_02(HandleRef pThis, IntPtr arg0, HandleRef arg1, long arg2, double arg3, ref int arg4, IntPtr arg5, IntPtr arg6);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override long FindCell(IntPtr arg0, vtkCell arg1, long arg2, double arg3, ref int arg4, IntPtr arg5, IntPtr arg6)
	{
		return vtkLabelHierarchy_FindCell_02(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3, ref arg4, arg5, arg6);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchy_FindCell_03(HandleRef pThis, IntPtr arg0, HandleRef arg1, HandleRef arg2, long arg3, double arg4, ref int arg5, IntPtr arg6, IntPtr arg7);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override long FindCell(IntPtr arg0, vtkCell arg1, vtkGenericCell arg2, long arg3, double arg4, ref int arg5, IntPtr arg6, IntPtr arg7)
	{
		return vtkLabelHierarchy_FindCell_03(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef), arg2?.GetCppThis() ?? default(HandleRef), arg3, arg4, ref arg5, arg6, arg7);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_GetAnchorFrustumPlanes_04(IntPtr frustumPlanes, HandleRef ren, HandleRef anchorTransform);

	/// <summary>
	/// Compute frustum for quickly excluding labels from rendering
	/// that are outside the visible region.
	/// This is a shared utility function.
	/// </summary>
	public static void GetAnchorFrustumPlanes(IntPtr frustumPlanes, vtkRenderer ren, vtkCoordinate anchorTransform)
	{
		vtkLabelHierarchy_GetAnchorFrustumPlanes_04(frustumPlanes, ren?.GetCppThis() ?? default(HandleRef), anchorTransform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetBoundedSizes_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the array specifying the maximum width and height in world coordinates of each label.
	/// </summary>
	public virtual vtkDataArray GetBoundedSizes()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetBoundedSizes_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetCell_06(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override vtkCell GetCell(long arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetCell_06(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_GetCell_07(HandleRef pThis, long arg0, HandleRef arg1);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override void GetCell(long arg0, vtkGenericCell arg1)
	{
		vtkLabelHierarchy_GetCell_07(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_GetCellPoints_08(HandleRef pThis, long arg0, HandleRef arg1);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override void GetCellPoints(long arg0, vtkIdList arg1)
	{
		vtkLabelHierarchy_GetCellPoints_08(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchy_GetCellType_09(HandleRef pThis, long arg0);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override int GetCellType(long arg0)
	{
		return vtkLabelHierarchy_GetCellType_09(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetCenterPts_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Provide access to original coordinates of sets of coincident points
	/// </summary>
	public virtual vtkPoints GetCenterPts()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetCenterPts_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetCoincidentPoints_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Provide access to the set of coincident points that have been
	/// perturbed by the hierarchy in order to render labels for each
	/// without overlap.
	/// </summary>
	public virtual vtkCoincidentPoints GetCoincidentPoints()
	{
		vtkCoincidentPoints vtkCoincidentPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetCoincidentPoints_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoincidentPoints2 = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoincidentPoints2.Register(null);
			}
		}
		return vtkCoincidentPoints2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_GetDiscreteNodeCoordinatesFromWorldPoint_12(HandleRef pThis, IntPtr ijk, IntPtr pt, int level);

	/// <summary>
	/// Given a depth in the hierarchy (\a level) and a point \a pt in world space, compute \a ijk.
	/// This is used to find other octree nodes at the same \a level that are within the search radius
	/// for candidate labels to be placed. It is called with \a pt set to the camera eye point and
	/// pythagorean quadruples increasingly distant from the origin are added to \a ijk to identify
	/// octree nodes whose labels should be placed.
	/// @param[out] ijk - discrete coordinates of the octree node at \a level containing \a pt.
	/// @param[in]  pt - input world point coordinates
	/// @param[in]  level - input octree level to be considered
	/// </summary>
	public void GetDiscreteNodeCoordinatesFromWorldPoint(IntPtr ijk, IntPtr pt, int level)
	{
		vtkLabelHierarchy_GetDiscreteNodeCoordinatesFromWorldPoint_12(GetCppThis(), ijk, pt, level);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetIconIndices_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the array specifying the icon index of each label.
	/// </summary>
	public virtual vtkIntArray GetIconIndices()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetIconIndices_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetLabels_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the array specifying the text of each label.
	/// </summary>
	public virtual vtkAbstractArray GetLabels()
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetLabels_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchy_GetMaxCellSize_15(HandleRef pThis);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkLabelHierarchy_GetMaxCellSize_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchy_GetMaximumDepth_16(HandleRef pThis);

	/// <summary>
	/// The maximum depth of the octree.
	/// </summary>
	public virtual int GetMaximumDepth()
	{
		return vtkLabelHierarchy_GetMaximumDepth_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchy_GetNumberOfCells_17(HandleRef pThis);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkLabelHierarchy_GetNumberOfCells_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchy_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLabelHierarchy_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLabelHierarchy_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLabelHierarchy_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetOrientations_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the array specifying the orientation of each label.
	/// </summary>
	public virtual vtkDataArray GetOrientations()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetOrientations_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkLabelHierarchy_GetPathForNodalCoordinates_21(IntPtr path, IntPtr ijk, int level);

	/// <summary>
	/// Given a \a level of the tree and \a ijk coordinates in a lattice,
	/// compute a \a path down the tree to reach the corresponding lattice node.
	/// If the lattice coordinates are outside the tree, this returns
	/// false. Otherwise it returns true. This does &lt;b&gt;not&lt;/b&gt; guarantee that
	/// the path exists in the hierarchy.
	/// @param[out] path - a vector of \a level integers specifying which child to descend at each
	/// level to reach \a ijk
	/// @param[in] ijk - discrete coordinates of the octree node at \a level
	/// @param[in] level - input octree level to be considered
	/// </summary>
	public static bool GetPathForNodalCoordinates(IntPtr path, IntPtr ijk, int level)
	{
		return (vtkLabelHierarchy_GetPathForNodalCoordinates_21(path, ijk, level) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_GetPointCells_22(HandleRef pThis, long arg0, HandleRef arg1);

	/// <summary>
	/// Inherited members (from vtkDataSet)
	/// </summary>
	public override void GetPointCells(long arg0, vtkIdList arg1)
	{
		vtkLabelHierarchy_GetPointCells_22(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetPriorities_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the array specifying the importance (priority) of each label.
	/// </summary>
	public virtual vtkDataArray GetPriorities()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetPriorities_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetSizes_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the array specifying the size of each label.
	/// </summary>
	public virtual vtkDataArray GetSizes()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetSizes_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchy_GetTargetLabelCount_25(HandleRef pThis);

	/// <summary>
	/// The number of labels that is ideally present at any octree node.
	/// It is best if this is a multiple of \f$2^d\f$.
	/// </summary>
	public virtual int GetTargetLabelCount()
	{
		return vtkLabelHierarchy_GetTargetLabelCount_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_GetTextProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The default text property assigned to labels in this hierarchy.
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_GetTextProperty_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchy_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLabelHierarchy_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLabelHierarchy_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLabelHierarchy_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLabelHierarchy NewInstance()
	{
		vtkLabelHierarchy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_NewIterator_31(HandleRef pThis, int type, HandleRef ren, HandleRef cam, IntPtr frustumPlanes, byte positionsAsNormals, IntPtr bucketSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns an iterator for this data object.
	/// positionsAsNormals should only be true when labels are on a sphere centered at the origin
	/// (3D world).
	/// @param type - the type should be one of FULL_SORT, QUEUE, DEPTH_FIRST, or FRUSTUM.
	/// @param ren - the current renderer (used for viewport information)
	/// @param cam - the current camera.
	/// @param frustumPlanes - should be the output of the camera's frustum planes.
	/// @param positionsAsNormals - throws out octree nodes on the opposite side of the origin.
	/// @param bucketSize - an array of 2 integers describing the width and height of label placer
	/// buckets.
	/// </summary>
	public vtkLabelHierarchyIterator NewIterator(int type, vtkRenderer ren, vtkCamera cam, IntPtr frustumPlanes, bool positionsAsNormals, IntPtr bucketSize)
	{
		vtkLabelHierarchyIterator vtkLabelHierarchyIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_NewIterator_31(GetCppThis(), type, ren?.GetCppThis() ?? default(HandleRef), cam?.GetCppThis() ?? default(HandleRef), frustumPlanes, (byte)(positionsAsNormals ? 1u : 0u), bucketSize, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelHierarchyIterator2 = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelHierarchyIterator2.Register(null);
			}
		}
		return vtkLabelHierarchyIterator2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLabelHierarchy_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLabelHierarchy SafeDownCast(vtkObjectBase o)
	{
		vtkLabelHierarchy vtkLabelHierarchy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLabelHierarchy_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLabelHierarchy2 = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLabelHierarchy2.Register(null);
			}
		}
		return vtkLabelHierarchy2;
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetBoundedSizes_33(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Set/get the array specifying the maximum width and height in world coordinates of each label.
	/// </summary>
	public virtual void SetBoundedSizes(vtkDataArray arr)
	{
		vtkLabelHierarchy_SetBoundedSizes_33(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetIconIndices_34(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Set/get the array specifying the icon index of each label.
	/// </summary>
	public virtual void SetIconIndices(vtkIntArray arr)
	{
		vtkLabelHierarchy_SetIconIndices_34(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetLabels_35(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Set/get the array specifying the text of each label.
	/// </summary>
	public virtual void SetLabels(vtkAbstractArray arr)
	{
		vtkLabelHierarchy_SetLabels_35(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetMaximumDepth_36(HandleRef pThis, int _arg);

	/// <summary>
	/// The maximum depth of the octree.
	/// </summary>
	public virtual void SetMaximumDepth(int _arg)
	{
		vtkLabelHierarchy_SetMaximumDepth_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetOrientations_37(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Set/get the array specifying the orientation of each label.
	/// </summary>
	public virtual void SetOrientations(vtkDataArray arr)
	{
		vtkLabelHierarchy_SetOrientations_37(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetPoints_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Override SetPoints so we can reset the hierarchy when the points change.
	/// </summary>
	public override void SetPoints(vtkPoints arg0)
	{
		vtkLabelHierarchy_SetPoints_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetPriorities_39(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Set/get the array specifying the importance (priority) of each label.
	/// </summary>
	public virtual void SetPriorities(vtkDataArray arr)
	{
		vtkLabelHierarchy_SetPriorities_39(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetSizes_40(HandleRef pThis, HandleRef arr);

	/// <summary>
	/// Set/get the array specifying the size of each label.
	/// </summary>
	public virtual void SetSizes(vtkDataArray arr)
	{
		vtkLabelHierarchy_SetSizes_40(GetCppThis(), arr?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetTargetLabelCount_41(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of labels that is ideally present at any octree node.
	/// It is best if this is a multiple of \f$2^d\f$.
	/// </summary>
	public virtual void SetTargetLabelCount(int _arg)
	{
		vtkLabelHierarchy_SetTargetLabelCount_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLabelHierarchy_SetTextProperty_42(HandleRef pThis, HandleRef tprop);

	/// <summary>
	/// The default text property assigned to labels in this hierarchy.
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty tprop)
	{
		vtkLabelHierarchy_SetTextProperty_42(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef));
	}
}
