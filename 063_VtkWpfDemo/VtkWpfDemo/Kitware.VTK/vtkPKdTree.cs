using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPKdTree
/// </summary>
/// <remarks>
///    Build a k-d tree decomposition of a list of points.
///
///
///      Build, in parallel, a k-d tree decomposition of one or more
///      vtkDataSets distributed across processors.  We assume each
///      process has read in one portion of a large distributed data set.
///      When done, each process has access to the k-d tree structure,
///      can obtain information about which process contains
///      data for each spatial region, and can depth sort the spatial
///      regions.
///
///      This class can also assign spatial regions to processors, based
///      on one of several region assignment schemes.  By default
///      a contiguous, convex region is assigned to each process.  Several
///      queries return information about how many and what cells I have
///      that lie in a region assigned to another process.
///
/// </remarks>
/// <seealso>
///
///      vtkKdTree
/// </seealso>
public class vtkPKdTree : vtkKdTree
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPKdTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPKdTree()
	{
		MRClassNameKey = "class vtkPKdTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPKdTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPKdTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPKdTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPKdTree New()
	{
		vtkPKdTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPKdTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPKdTree()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPKdTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPKdTree_AssignRegions_01(HandleRef pThis, IntPtr map, int numRegions);

	/// <summary>
	/// Assign spatial regions to processes via a user defined map.
	/// The user-supplied map is indexed by region ID, and provides a
	/// process ID for each region.
	/// </summary>
	public int AssignRegions(IntPtr map, int numRegions)
	{
		return vtkPKdTree_AssignRegions_01(GetCppThis(), map, numRegions);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_AssignRegionsContiguous_02(HandleRef pThis);

	/// <summary>
	/// Let the PKdTree class assign a process to each region
	/// by assigning contiguous sets of spatial regions to each
	/// process.  The set of regions assigned to each process will
	/// always have a union that is a convex space (a box).
	/// If the k-d tree has not yet been built, the regions
	/// will be assigned after BuildLocator executes.
	/// </summary>
	public int AssignRegionsContiguous()
	{
		return vtkPKdTree_AssignRegionsContiguous_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_AssignRegionsRoundRobin_03(HandleRef pThis);

	/// <summary>
	/// Let the PKdTree class assign a process to each region in a
	/// round robin fashion.  If the k-d tree has not yet been
	/// built, the regions will be assigned after BuildLocator executes.
	/// </summary>
	public int AssignRegionsRoundRobin()
	{
		return vtkPKdTree_AssignRegionsRoundRobin_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPKdTree_BuildLocator_04(HandleRef pThis);

	/// <summary>
	/// Build the spatial decomposition.  Call this explicitly
	/// after changing any parameters affecting the build of the
	/// tree.  It must be called by all processes in the parallel
	/// application, or it will hang.
	/// </summary>
	public override void BuildLocator()
	{
		vtkPKdTree_BuildLocator_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_CreateGlobalDataArrayBounds_05(HandleRef pThis);

	/// <summary>
	/// A convenience function which compiles the global
	/// bounds of the data arrays across processes.
	/// These bounds can be accessed with
	/// "GetCellArrayGlobalRange" and "GetPointArrayGlobalRange".
	/// This method must be called by all processes or it will hang.
	/// Returns 1 on error, 0 when no error.
	/// </summary>
	public int CreateGlobalDataArrayBounds()
	{
		return vtkPKdTree_CreateGlobalDataArrayBounds_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_CreateProcessCellCountData_06(HandleRef pThis);

	/// <summary>
	/// Create tables of counts of cells per process per region.
	/// These tables can be accessed with queries like
	/// "HasData", "GetProcessCellCountForRegion", and so on.
	/// You must have called BuildLocator() beforehand.  This
	/// method must be called by all processes or it will hang.
	/// Returns 1 on error, 0 when no error.
	/// </summary>
	public int CreateProcessCellCountData()
	{
		return vtkPKdTree_CreateProcessCellCountData_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPKdTree_GetAllProcessesBorderingOnPoint_07(HandleRef pThis, float x, float y, float z, HandleRef list);

	/// <summary>
	/// The k-d tree spatial regions have been assigned to processes.
	/// Given a point on the boundary of one of the regions, this
	/// method creates a list of all processes whose region
	/// boundaries include that point.  This may be required when
	/// looking for processes that have cells adjacent to the cells
	/// of a given process.
	/// </summary>
	public void GetAllProcessesBorderingOnPoint(float x, float y, float z, vtkIntArray list)
	{
		vtkPKdTree_GetAllProcessesBorderingOnPoint_07(GetCppThis(), x, y, z, list?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetCellArrayGlobalRange_08(HandleRef pThis, string name, IntPtr range);

	/// <summary>
	/// An added feature of vtkPKdTree is that it will calculate the
	/// the global range of field arrays across all processes.  You
	/// call CreateGlobalDataArrayBounds() to do this calculation.
	/// Then the following methods return the ranges.
	/// Returns 1 on error, 0 otherwise.
	/// </summary>
	public int GetCellArrayGlobalRange(string name, IntPtr range)
	{
		return vtkPKdTree_GetCellArrayGlobalRange_08(GetCppThis(), name, range);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetCellArrayGlobalRange_09(HandleRef pThis, int arrayIndex, IntPtr range);

	/// <summary>
	/// An added feature of vtkPKdTree is that it will calculate the
	/// the global range of field arrays across all processes.  You
	/// call CreateGlobalDataArrayBounds() to do this calculation.
	/// Then the following methods return the ranges.
	/// Returns 1 on error, 0 otherwise.
	/// </summary>
	public int GetCellArrayGlobalRange(int arrayIndex, IntPtr range)
	{
		return vtkPKdTree_GetCellArrayGlobalRange_09(GetCppThis(), arrayIndex, range);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPKdTree_GetCellListsForProcessRegions_10(HandleRef pThis, int ProcessId, int set, HandleRef inRegionCells, HandleRef onBoundaryCells);

	/// <summary>
	/// After regions have been assigned to processes, I may want to know
	/// which cells I have that are in the regions assigned to a particular
	/// process.
	///
	/// This method takes a process ID and two vtkIdLists.  It
	/// writes to the first list the IDs of the cells
	/// contained in the process' regions.  (That is, their cell
	/// centroid is contained in the region.)  To the second list it
	/// write the IDs of the cells which intersect the process' regions
	/// but whose cell centroid lies elsewhere.
	///
	/// The total number of cell IDs written to both lists is returned.
	/// Either list pointer passed in can be nullptr, and it will be ignored.
	/// If there are multiple data sets, you must specify which data set
	/// you wish cell IDs for.
	///
	/// The caller should delete these two lists when done.  This method
	/// uses the cell lists created in vtkKdTree::CreateCellLists().
	/// If the cell lists for the process' regions do not exist, this
	/// method will first build the cell lists for all regions by calling
	/// CreateCellLists().  You must remember to DeleteCellLists() when
	/// done with all calls to this method, as cell lists can require a
	/// great deal of memory.
	/// </summary>
	public long GetCellListsForProcessRegions(int ProcessId, int set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
	{
		return vtkPKdTree_GetCellListsForProcessRegions_10(GetCppThis(), ProcessId, set, inRegionCells?.GetCppThis() ?? default(HandleRef), onBoundaryCells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPKdTree_GetCellListsForProcessRegions_11(HandleRef pThis, int ProcessId, HandleRef set, HandleRef inRegionCells, HandleRef onBoundaryCells);

	/// <summary>
	/// After regions have been assigned to processes, I may want to know
	/// which cells I have that are in the regions assigned to a particular
	/// process.
	///
	/// This method takes a process ID and two vtkIdLists.  It
	/// writes to the first list the IDs of the cells
	/// contained in the process' regions.  (That is, their cell
	/// centroid is contained in the region.)  To the second list it
	/// write the IDs of the cells which intersect the process' regions
	/// but whose cell centroid lies elsewhere.
	///
	/// The total number of cell IDs written to both lists is returned.
	/// Either list pointer passed in can be nullptr, and it will be ignored.
	/// If there are multiple data sets, you must specify which data set
	/// you wish cell IDs for.
	///
	/// The caller should delete these two lists when done.  This method
	/// uses the cell lists created in vtkKdTree::CreateCellLists().
	/// If the cell lists for the process' regions do not exist, this
	/// method will first build the cell lists for all regions by calling
	/// CreateCellLists().  You must remember to DeleteCellLists() when
	/// done with all calls to this method, as cell lists can require a
	/// great deal of memory.
	/// </summary>
	public long GetCellListsForProcessRegions(int ProcessId, vtkDataSet set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
	{
		return vtkPKdTree_GetCellListsForProcessRegions_11(GetCppThis(), ProcessId, set?.GetCppThis() ?? default(HandleRef), inRegionCells?.GetCppThis() ?? default(HandleRef), onBoundaryCells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPKdTree_GetCellListsForProcessRegions_12(HandleRef pThis, int ProcessId, HandleRef inRegionCells, HandleRef onBoundaryCells);

	/// <summary>
	/// After regions have been assigned to processes, I may want to know
	/// which cells I have that are in the regions assigned to a particular
	/// process.
	///
	/// This method takes a process ID and two vtkIdLists.  It
	/// writes to the first list the IDs of the cells
	/// contained in the process' regions.  (That is, their cell
	/// centroid is contained in the region.)  To the second list it
	/// write the IDs of the cells which intersect the process' regions
	/// but whose cell centroid lies elsewhere.
	///
	/// The total number of cell IDs written to both lists is returned.
	/// Either list pointer passed in can be nullptr, and it will be ignored.
	/// If there are multiple data sets, you must specify which data set
	/// you wish cell IDs for.
	///
	/// The caller should delete these two lists when done.  This method
	/// uses the cell lists created in vtkKdTree::CreateCellLists().
	/// If the cell lists for the process' regions do not exist, this
	/// method will first build the cell lists for all regions by calling
	/// CreateCellLists().  You must remember to DeleteCellLists() when
	/// done with all calls to this method, as cell lists can require a
	/// great deal of memory.
	/// </summary>
	public long GetCellListsForProcessRegions(int ProcessId, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
	{
		return vtkPKdTree_GetCellListsForProcessRegions_12(GetCppThis(), ProcessId, inRegionCells?.GetCppThis() ?? default(HandleRef), onBoundaryCells?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPKdTree_GetController_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the communicator object
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPKdTree_GetController_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPKdTree_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPKdTree_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPKdTree_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPKdTree_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetPointArrayGlobalRange_16(HandleRef pThis, string name, IntPtr range);

	/// <summary>
	/// An added feature of vtkPKdTree is that it will calculate the
	/// the global range of field arrays across all processes.  You
	/// call CreateGlobalDataArrayBounds() to do this calculation.
	/// Then the following methods return the ranges.
	/// Returns 1 on error, 0 otherwise.
	/// </summary>
	public int GetPointArrayGlobalRange(string name, IntPtr range)
	{
		return vtkPKdTree_GetPointArrayGlobalRange_16(GetCppThis(), name, range);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetPointArrayGlobalRange_17(HandleRef pThis, int arrayIndex, IntPtr range);

	/// <summary>
	/// An added feature of vtkPKdTree is that it will calculate the
	/// the global range of field arrays across all processes.  You
	/// call CreateGlobalDataArrayBounds() to do this calculation.
	/// Then the following methods return the ranges.
	/// Returns 1 on error, 0 otherwise.
	/// </summary>
	public int GetPointArrayGlobalRange(int arrayIndex, IntPtr range)
	{
		return vtkPKdTree_GetPointArrayGlobalRange_17(GetCppThis(), arrayIndex, range);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetProcessAssignedToRegion_18(HandleRef pThis, int regionId);

	/// <summary>
	/// Returns the ID of the process assigned to the region.
	/// </summary>
	public int GetProcessAssignedToRegion(int regionId)
	{
		return vtkPKdTree_GetProcessAssignedToRegion_18(GetCppThis(), regionId);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetProcessCellCountForRegion_19(HandleRef pThis, int processId, int regionId);

	/// <summary>
	/// Returns the number of cells the specified process has in the
	/// specified region.
	/// </summary>
	public int GetProcessCellCountForRegion(int processId, int regionId)
	{
		return vtkPKdTree_GetProcessCellCountForRegion_19(GetCppThis(), processId, regionId);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetProcessListForRegion_20(HandleRef pThis, int regionId, HandleRef processes);

	/// <summary>
	/// Adds the list of processes having data for the given
	/// region to the supplied list, returns the number of
	/// processes added.
	/// </summary>
	public int GetProcessListForRegion(int regionId, vtkIntArray processes)
	{
		return vtkPKdTree_GetProcessListForRegion_20(GetCppThis(), regionId, processes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetProcessesCellCountForRegion_21(HandleRef pThis, int regionId, IntPtr count, int len);

	/// <summary>
	/// Writes the number of cells each process has for the region
	/// to the supplied list of length len.  Returns the number of
	/// cell counts written.  The order of the cell counts corresponds
	/// to the order of process IDs in the process list returned by
	/// GetProcessListForRegion.
	/// </summary>
	public int GetProcessesCellCountForRegion(int regionId, IntPtr count, int len)
	{
		return vtkPKdTree_GetProcessesCellCountForRegion_21(GetCppThis(), regionId, count, len);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetRegionAssignment_22(HandleRef pThis);

	/// <summary>
	/// The PKdTree class can assign spatial regions to processors after
	/// building the k-d tree, using one of several partitioning criteria.
	/// These functions Set/Get whether this assignment is computed.
	/// The default is "Off", no assignment is computed.   If "On", and
	/// no assignment scheme is specified, contiguous assignment will be
	/// computed.  Specifying an assignment scheme (with AssignRegions*())
	/// automatically turns on RegionAssignment.
	/// </summary>
	public virtual int GetRegionAssignment()
	{
		return vtkPKdTree_GetRegionAssignment_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetRegionAssignmentList_23(HandleRef pThis, int procId, HandleRef list);

	/// <summary>
	/// Writes the list of region IDs assigned to the specified
	/// process.  Regions IDs start at 0 and increase by 1 from there.
	/// Returns the number of regions in the list.
	/// </summary>
	public int GetRegionAssignmentList(int procId, vtkIntArray list)
	{
		return vtkPKdTree_GetRegionAssignmentList_23(GetCppThis(), procId, list?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPKdTree_GetRegionAssignmentMap_24(HandleRef pThis);

	/// <summary>
	/// Returns the region assignment map where index is the region and value is
	/// the processes id for that region.
	/// </summary>
	public IntPtr GetRegionAssignmentMap()
	{
		return vtkPKdTree_GetRegionAssignmentMap_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetRegionAssignmentMapLength_25(HandleRef pThis);

	/// <summary>
	/// / Returns the number of regions in the region assignment map.
	/// </summary>
	public int GetRegionAssignmentMapLength()
	{
		return vtkPKdTree_GetRegionAssignmentMapLength_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetRegionListForProcess_26(HandleRef pThis, int processId, HandleRef regions);

	/// <summary>
	/// Adds the region IDs for which this process has data to
	/// the supplied vtkIntArray.  Returns the number of regions.
	/// </summary>
	public int GetRegionListForProcess(int processId, vtkIntArray regions)
	{
		return vtkPKdTree_GetRegionListForProcess_26(GetCppThis(), processId, regions?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetRegionsCellCountForProcess_27(HandleRef pThis, int ProcessId, IntPtr count, int len);

	/// <summary>
	/// Writes to the supplied integer array the number of cells this
	/// process has for each region.  Returns the number of
	/// cell counts written.  The order of the cell counts corresponds
	/// to the order of region IDs in the region list returned by
	/// GetRegionListForProcess.
	/// </summary>
	public int GetRegionsCellCountForProcess(int ProcessId, IntPtr count, int len)
	{
		return vtkPKdTree_GetRegionsCellCountForProcess_27(GetCppThis(), ProcessId, count, len);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPKdTree_GetTotalNumberOfCells_28(HandleRef pThis);

	/// <summary>
	/// Get the total number of cells distributed across the data
	/// files read by all processes.  You must have called BuildLocator
	/// before calling this method.
	/// </summary>
	public long GetTotalNumberOfCells()
	{
		return vtkPKdTree_GetTotalNumberOfCells_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetTotalProcessesInRegion_29(HandleRef pThis, int regionId);

	/// <summary>
	/// Returns the total number of processes that have data
	/// falling within this spatial region.
	/// </summary>
	public int GetTotalProcessesInRegion(int regionId)
	{
		return vtkPKdTree_GetTotalProcessesInRegion_29(GetCppThis(), regionId);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_GetTotalRegionsForProcess_30(HandleRef pThis, int processId);

	/// <summary>
	/// Returns the total number of spatial regions that a given
	/// process has data for.
	/// </summary>
	public int GetTotalRegionsForProcess(int processId)
	{
		return vtkPKdTree_GetTotalRegionsForProcess_30(GetCppThis(), processId);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_HasData_31(HandleRef pThis, int processId, int regionId);

	/// <summary>
	/// Returns 1 if the process has data for the given region,
	/// 0 otherwise.
	/// </summary>
	public int HasData(int processId, int regionId)
	{
		return vtkPKdTree_HasData_31(GetCppThis(), processId, regionId);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPKdTree_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_IsTypeOf_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPKdTree_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPKdTree_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPKdTree NewInstance()
	{
		vtkPKdTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPKdTree_NewInstance_35(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPKdTree_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPKdTree SafeDownCast(vtkObjectBase o)
	{
		vtkPKdTree vtkPKdTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPKdTree_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPKdTree_SetController_37(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Set/Get the communicator object
	/// </summary>
	public void SetController(vtkMultiProcessController c)
	{
		vtkPKdTree_SetController_37(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_ViewOrderAllProcessesFromPosition_38(HandleRef pThis, IntPtr cameraPosition, HandleRef orderedList);

	/// <summary>
	/// Return a list of all processes in order from front to back given a
	/// camera position.  Use this to do visibility sorts in perspective
	/// projection mode. `orderedList' will be resized to the number
	/// of processes. The return value is the number of processes.
	/// \pre orderedList_exists: orderedList!=0
	/// </summary>
	public int ViewOrderAllProcessesFromPosition(IntPtr cameraPosition, vtkIntArray orderedList)
	{
		return vtkPKdTree_ViewOrderAllProcessesFromPosition_38(GetCppThis(), cameraPosition, orderedList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPKdTree_ViewOrderAllProcessesInDirection_39(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

	/// <summary>
	/// Return a list of all processes in order from front to back given a
	/// vector direction of projection.  Use this to do visibility sorts
	/// in parallel projection mode. `orderedList' will be resized to the number
	/// of processes. The return value is the number of processes.
	/// \pre orderedList_exists: orderedList!=0
	/// </summary>
	public int ViewOrderAllProcessesInDirection(IntPtr directionOfProjection, vtkIntArray orderedList)
	{
		return vtkPKdTree_ViewOrderAllProcessesInDirection_39(GetCppThis(), directionOfProjection, orderedList?.GetCppThis() ?? default(HandleRef));
	}
}
