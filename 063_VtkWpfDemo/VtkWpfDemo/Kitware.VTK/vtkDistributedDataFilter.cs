using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDistributedDataFilter
/// </summary>
/// <remarks>
///    Serial stand-in for parallel filter that distributes data among processors
///
/// This filter is a serial implementation of the vtkPDistributedDataFilter
/// filter with the intent that it can be used in non-MPI builds. This filter
/// acts almost as a "pass-through" filter when run in serial, though when the
/// input is a non-composite dataset, the output will be an vtkUnstructuredGrid
/// to be consistent with the parallel filter. The combination of this filter and
/// its parallel counterpart serves to unify the API for serial and parallel
/// builds.
///
/// </remarks>
/// <seealso>
///  vtkPDistributedDataFilter
/// </seealso>
public class vtkDistributedDataFilter : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Set this variable if you want the cells of the output
	/// vtkUnstructuredGrid to be clipped to the spatial region
	/// boundaries.  By default this is off.
	/// </summary>
	public enum BoundaryModes
	{
		/// <summary>enum member</summary>
		ASSIGN_TO_ALL_INTERSECTING_REGIONS = 1,
		/// <summary>enum member</summary>
		ASSIGN_TO_ONE_REGION = 0,
		/// <summary>enum member</summary>
		SPLIT_BOUNDARY_CELLS = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDistributedDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDistributedDataFilter()
	{
		MRClassNameKey = "class vtkDistributedDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistributedDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDistributedDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDistributedDataFilter New()
	{
		vtkDistributedDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDistributedDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDistributedDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_ClipCellsOff_01(HandleRef pThis);

	/// <summary>
	/// Set this variable if you want the cells of the output
	/// vtkUnstructuredGrid to be clipped to the spatial region
	/// boundaries.  By default this is off.
	/// </summary>
	public virtual void ClipCellsOff()
	{
		vtkDistributedDataFilter_ClipCellsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_ClipCellsOn_02(HandleRef pThis);

	/// <summary>
	/// Set this variable if you want the cells of the output
	/// vtkUnstructuredGrid to be clipped to the spatial region
	/// boundaries.  By default this is off.
	/// </summary>
	public virtual void ClipCellsOn()
	{
		vtkDistributedDataFilter_ClipCellsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_GetBoundaryMode_03(HandleRef pThis);

	/// <summary>
	/// Handling of ClipCells and IncludeAllIntersectingCells.
	/// </summary>
	public int GetBoundaryMode()
	{
		return vtkDistributedDataFilter_GetBoundaryMode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_GetClipCells_04(HandleRef pThis);

	/// <summary>
	/// Set this variable if you want the cells of the output
	/// vtkUnstructuredGrid to be clipped to the spatial region
	/// boundaries.  By default this is off.
	/// </summary>
	public virtual int GetClipCells()
	{
		return vtkDistributedDataFilter_GetClipCells_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedDataFilter_GetController_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the communicator object
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedDataFilter_GetController_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedDataFilter_GetCuts_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// You can set the k-d tree decomposition, rather than
	/// have D3 compute it.  This allows you to divide a dataset using
	/// the decomposition computed for another dataset.  Obtain a description
	/// of the k-d tree cuts this way:
	///
	/// vtkBSPCuts *cuts = D3Object1-&gt;GetCuts()
	///
	/// And set it this way:
	///
	/// D3Object2-&gt;SetCuts(cuts)
	/// </summary>
	public vtkBSPCuts GetCuts()
	{
		vtkBSPCuts vtkBSPCuts2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedDataFilter_GetCuts_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBSPCuts2 = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBSPCuts2.Register(null);
			}
		}
		return vtkBSPCuts2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_GetIncludeAllIntersectingCells_07(HandleRef pThis);

	/// <summary>
	/// Each cell in the data set is associated with one of the
	/// spatial regions of the k-d tree decomposition.  In particular,
	/// the cell belongs to the region that it's centroid lies in.
	/// When the new vtkUnstructuredGrid is created, by default it
	/// is composed of the cells associated with the region(s)
	/// assigned to this process.  If you also want it to contain
	/// cells that intersect these regions, but have their centroid
	/// elsewhere, then set this variable on.  By default it is off.
	/// </summary>
	public virtual int GetIncludeAllIntersectingCells()
	{
		return vtkDistributedDataFilter_GetIncludeAllIntersectingCells_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedDataFilter_GetKdtree_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to the parallel k-d tree object.  Required for changing
	/// default behavior for region assignment, changing default depth of tree,
	/// or other tree building default parameters.  See vtkPKdTree and
	/// vtkKdTree for more information about these options.
	/// NOTE: Changing the tree returned by this method does NOT change
	/// the d3 filter. Make sure to call Modified() on the d3 object if
	/// you want it to re-execute.
	/// </summary>
	public vtkPKdTree GetKdtree()
	{
		vtkPKdTree vtkPKdTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedDataFilter_GetKdtree_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPKdTree2 = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPKdTree2.Register(null);
			}
		}
		return vtkPKdTree2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_GetMinimumGhostLevel_09(HandleRef pThis);

	/// <summary>
	/// The minimum number of ghost levels to add to each processor's output. If
	/// the pipeline also requests ghost levels, the larger value will be used.
	/// </summary>
	public virtual int GetMinimumGhostLevel()
	{
		return vtkDistributedDataFilter_GetMinimumGhostLevel_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedDataFilter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDistributedDataFilter_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistributedDataFilter_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDistributedDataFilter_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_GetRetainKdtree_12(HandleRef pThis);

	/// <summary>
	/// When this filter executes, it creates a vtkPKdTree (K-d tree)
	/// data structure in parallel which divides the total distributed
	/// data set into spatial regions.  The K-d tree object also creates
	/// tables describing which processes have data for which
	/// regions.  Only then does this filter redistribute
	/// the data according to the region assignment scheme.  By default,
	/// the K-d tree structure and it's associated tables are deleted
	/// after the filter executes.  If you anticipate changing only the
	/// region assignment scheme (input is unchanged) and explicitly
	/// re-executing, then RetainKdTreeOn, and the K-d tree structure and
	/// tables will be saved.  Then, when you re-execute, this filter will
	/// skip the k-d tree build phase and go straight to redistributing
	/// the data according to region assignment.  See vtkPKdTree for
	/// more information about region assignment.
	/// </summary>
	public virtual int GetRetainKdtree()
	{
		return vtkDistributedDataFilter_GetRetainKdtree_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_GetTiming_13(HandleRef pThis);

	/// <summary>
	/// Turn on collection of timing data
	/// </summary>
	public virtual int GetTiming()
	{
		return vtkDistributedDataFilter_GetTiming_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_GetUseMinimalMemory_14(HandleRef pThis);

	/// <summary>
	/// This class does a great deal of all-to-all communication
	/// when exchanging portions of data sets and building new sub
	/// grids.
	/// By default it will do fast communication.  It can instead
	/// use communication routines that use the least possible
	/// amount of memory, but these are slower.  Set this option
	/// ON to choose these latter routines.
	/// </summary>
	public virtual int GetUseMinimalMemory()
	{
		return vtkDistributedDataFilter_GetUseMinimalMemory_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_IncludeAllIntersectingCellsOff_15(HandleRef pThis);

	/// <summary>
	/// Each cell in the data set is associated with one of the
	/// spatial regions of the k-d tree decomposition.  In particular,
	/// the cell belongs to the region that it's centroid lies in.
	/// When the new vtkUnstructuredGrid is created, by default it
	/// is composed of the cells associated with the region(s)
	/// assigned to this process.  If you also want it to contain
	/// cells that intersect these regions, but have their centroid
	/// elsewhere, then set this variable on.  By default it is off.
	/// </summary>
	public virtual void IncludeAllIntersectingCellsOff()
	{
		vtkDistributedDataFilter_IncludeAllIntersectingCellsOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_IncludeAllIntersectingCellsOn_16(HandleRef pThis);

	/// <summary>
	/// Each cell in the data set is associated with one of the
	/// spatial regions of the k-d tree decomposition.  In particular,
	/// the cell belongs to the region that it's centroid lies in.
	/// When the new vtkUnstructuredGrid is created, by default it
	/// is composed of the cells associated with the region(s)
	/// assigned to this process.  If you also want it to contain
	/// cells that intersect these regions, but have their centroid
	/// elsewhere, then set this variable on.  By default it is off.
	/// </summary>
	public virtual void IncludeAllIntersectingCellsOn()
	{
		vtkDistributedDataFilter_IncludeAllIntersectingCellsOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDistributedDataFilter_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistributedDataFilter_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDistributedDataFilter_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedDataFilter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDistributedDataFilter NewInstance()
	{
		vtkDistributedDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedDataFilter_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_RetainKdtreeOff_21(HandleRef pThis);

	/// <summary>
	/// When this filter executes, it creates a vtkPKdTree (K-d tree)
	/// data structure in parallel which divides the total distributed
	/// data set into spatial regions.  The K-d tree object also creates
	/// tables describing which processes have data for which
	/// regions.  Only then does this filter redistribute
	/// the data according to the region assignment scheme.  By default,
	/// the K-d tree structure and it's associated tables are deleted
	/// after the filter executes.  If you anticipate changing only the
	/// region assignment scheme (input is unchanged) and explicitly
	/// re-executing, then RetainKdTreeOn, and the K-d tree structure and
	/// tables will be saved.  Then, when you re-execute, this filter will
	/// skip the k-d tree build phase and go straight to redistributing
	/// the data according to region assignment.  See vtkPKdTree for
	/// more information about region assignment.
	/// </summary>
	public virtual void RetainKdtreeOff()
	{
		vtkDistributedDataFilter_RetainKdtreeOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_RetainKdtreeOn_22(HandleRef pThis);

	/// <summary>
	/// When this filter executes, it creates a vtkPKdTree (K-d tree)
	/// data structure in parallel which divides the total distributed
	/// data set into spatial regions.  The K-d tree object also creates
	/// tables describing which processes have data for which
	/// regions.  Only then does this filter redistribute
	/// the data according to the region assignment scheme.  By default,
	/// the K-d tree structure and it's associated tables are deleted
	/// after the filter executes.  If you anticipate changing only the
	/// region assignment scheme (input is unchanged) and explicitly
	/// re-executing, then RetainKdTreeOn, and the K-d tree structure and
	/// tables will be saved.  Then, when you re-execute, this filter will
	/// skip the k-d tree build phase and go straight to redistributing
	/// the data according to region assignment.  See vtkPKdTree for
	/// more information about region assignment.
	/// </summary>
	public virtual void RetainKdtreeOn()
	{
		vtkDistributedDataFilter_RetainKdtreeOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistributedDataFilter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDistributedDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkDistributedDataFilter vtkDistributedDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistributedDataFilter_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistributedDataFilter2 = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistributedDataFilter2.Register(null);
			}
		}
		return vtkDistributedDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetBoundaryMode_24(HandleRef pThis, int mode);

	/// <summary>
	/// Handling of ClipCells and IncludeAllIntersectingCells.
	/// </summary>
	public void SetBoundaryMode(int mode)
	{
		vtkDistributedDataFilter_SetBoundaryMode_24(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetBoundaryModeToAssignToAllIntersectingRegions_25(HandleRef pThis);

	/// <summary>
	/// Handling of ClipCells and IncludeAllIntersectingCells.
	/// </summary>
	public void SetBoundaryModeToAssignToAllIntersectingRegions()
	{
		vtkDistributedDataFilter_SetBoundaryModeToAssignToAllIntersectingRegions_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetBoundaryModeToAssignToOneRegion_26(HandleRef pThis);

	/// <summary>
	/// Handling of ClipCells and IncludeAllIntersectingCells.
	/// </summary>
	public void SetBoundaryModeToAssignToOneRegion()
	{
		vtkDistributedDataFilter_SetBoundaryModeToAssignToOneRegion_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetBoundaryModeToSplitBoundaryCells_27(HandleRef pThis);

	/// <summary>
	/// Handling of ClipCells and IncludeAllIntersectingCells.
	/// </summary>
	public void SetBoundaryModeToSplitBoundaryCells()
	{
		vtkDistributedDataFilter_SetBoundaryModeToSplitBoundaryCells_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetClipCells_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set this variable if you want the cells of the output
	/// vtkUnstructuredGrid to be clipped to the spatial region
	/// boundaries.  By default this is off.
	/// </summary>
	public virtual void SetClipCells(int _arg)
	{
		vtkDistributedDataFilter_SetClipCells_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetController_29(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Set/Get the communicator object
	/// </summary>
	public void SetController(vtkMultiProcessController c)
	{
		vtkDistributedDataFilter_SetController_29(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetCuts_30(HandleRef pThis, HandleRef cuts);

	/// <summary>
	/// You can set the k-d tree decomposition, rather than
	/// have D3 compute it.  This allows you to divide a dataset using
	/// the decomposition computed for another dataset.  Obtain a description
	/// of the k-d tree cuts this way:
	///
	/// vtkBSPCuts *cuts = D3Object1-&gt;GetCuts()
	///
	/// And set it this way:
	///
	/// D3Object2-&gt;SetCuts(cuts)
	/// </summary>
	public void SetCuts(vtkBSPCuts cuts)
	{
		vtkDistributedDataFilter_SetCuts_30(GetCppThis(), cuts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetIncludeAllIntersectingCells_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Each cell in the data set is associated with one of the
	/// spatial regions of the k-d tree decomposition.  In particular,
	/// the cell belongs to the region that it's centroid lies in.
	/// When the new vtkUnstructuredGrid is created, by default it
	/// is composed of the cells associated with the region(s)
	/// assigned to this process.  If you also want it to contain
	/// cells that intersect these regions, but have their centroid
	/// elsewhere, then set this variable on.  By default it is off.
	/// </summary>
	public virtual void SetIncludeAllIntersectingCells(int _arg)
	{
		vtkDistributedDataFilter_SetIncludeAllIntersectingCells_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetMinimumGhostLevel_32(HandleRef pThis, int _arg);

	/// <summary>
	/// The minimum number of ghost levels to add to each processor's output. If
	/// the pipeline also requests ghost levels, the larger value will be used.
	/// </summary>
	public virtual void SetMinimumGhostLevel(int _arg)
	{
		vtkDistributedDataFilter_SetMinimumGhostLevel_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetRetainKdtree_33(HandleRef pThis, int _arg);

	/// <summary>
	/// When this filter executes, it creates a vtkPKdTree (K-d tree)
	/// data structure in parallel which divides the total distributed
	/// data set into spatial regions.  The K-d tree object also creates
	/// tables describing which processes have data for which
	/// regions.  Only then does this filter redistribute
	/// the data according to the region assignment scheme.  By default,
	/// the K-d tree structure and it's associated tables are deleted
	/// after the filter executes.  If you anticipate changing only the
	/// region assignment scheme (input is unchanged) and explicitly
	/// re-executing, then RetainKdTreeOn, and the K-d tree structure and
	/// tables will be saved.  Then, when you re-execute, this filter will
	/// skip the k-d tree build phase and go straight to redistributing
	/// the data according to region assignment.  See vtkPKdTree for
	/// more information about region assignment.
	/// </summary>
	public virtual void SetRetainKdtree(int _arg)
	{
		vtkDistributedDataFilter_SetRetainKdtree_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetTiming_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on collection of timing data
	/// </summary>
	public virtual void SetTiming(int _arg)
	{
		vtkDistributedDataFilter_SetTiming_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetUseMinimalMemory_35(HandleRef pThis, int _arg);

	/// <summary>
	/// This class does a great deal of all-to-all communication
	/// when exchanging portions of data sets and building new sub
	/// grids.
	/// By default it will do fast communication.  It can instead
	/// use communication routines that use the least possible
	/// amount of memory, but these are slower.  Set this option
	/// ON to choose these latter routines.
	/// </summary>
	public virtual void SetUseMinimalMemory(int _arg)
	{
		vtkDistributedDataFilter_SetUseMinimalMemory_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_SetUserRegionAssignments_36(HandleRef pThis, IntPtr map, int numRegions);

	/// <summary>
	/// vtkBSPCuts doesn't have information about process assignments for the cuts.
	/// Typically D3 filter simply reassigns the processes for each cut. However,
	/// that may not always work, sometimes the processes have be pre-assigned and
	/// we want to preserve that partitioning. In that case, one sets the region
	/// assignments explicitly. Look at vtkPKdTree::AssignRegions for details about
	/// the arguments. Calling SetUserRegionAssignments(nullptr, 0) will revert to
	/// default behavior i.e. letting the KdTree come up with the assignments.
	/// </summary>
	public void SetUserRegionAssignments(IntPtr map, int numRegions)
	{
		vtkDistributedDataFilter_SetUserRegionAssignments_36(GetCppThis(), map, numRegions);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_TimingOff_37(HandleRef pThis);

	/// <summary>
	/// Turn on collection of timing data
	/// </summary>
	public virtual void TimingOff()
	{
		vtkDistributedDataFilter_TimingOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_TimingOn_38(HandleRef pThis);

	/// <summary>
	/// Turn on collection of timing data
	/// </summary>
	public virtual void TimingOn()
	{
		vtkDistributedDataFilter_TimingOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_UseMinimalMemoryOff_39(HandleRef pThis);

	/// <summary>
	/// This class does a great deal of all-to-all communication
	/// when exchanging portions of data sets and building new sub
	/// grids.
	/// By default it will do fast communication.  It can instead
	/// use communication routines that use the least possible
	/// amount of memory, but these are slower.  Set this option
	/// ON to choose these latter routines.
	/// </summary>
	public virtual void UseMinimalMemoryOff()
	{
		vtkDistributedDataFilter_UseMinimalMemoryOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistributedDataFilter_UseMinimalMemoryOn_40(HandleRef pThis);

	/// <summary>
	/// This class does a great deal of all-to-all communication
	/// when exchanging portions of data sets and building new sub
	/// grids.
	/// By default it will do fast communication.  It can instead
	/// use communication routines that use the least possible
	/// amount of memory, but these are slower.  Set this option
	/// ON to choose these latter routines.
	/// </summary>
	public virtual void UseMinimalMemoryOn()
	{
		vtkDistributedDataFilter_UseMinimalMemoryOn_40(GetCppThis());
	}
}
