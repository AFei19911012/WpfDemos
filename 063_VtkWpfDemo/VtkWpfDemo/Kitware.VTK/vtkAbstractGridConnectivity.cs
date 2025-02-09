using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractGridConnectivity
///
///
///  A superclass that defines the interface to be implemented by all
///  concrete grid connectivity classes. Grid connectivity classes provide the
///  mechanism to achieve the following:
///  &lt;ul&gt;
///    &lt;li&gt;
///      &lt;b&gt; Handling of partitioned/distributed data &lt;/b&gt;
///      &lt;p&gt;
///       Construct the neighboring topology information for each partition,e.g.,
///       used for creating communication lists and in computing statistics,i.e.,
///       average, mean, etc.
///      &lt;/p&gt;
///      &lt;b&gt; Creation of ghost layers &lt;/b&gt;
///      &lt;p&gt;
///       Provides the mechanism for automatically generating ghost information
///       given a partitioned/distributed grid configuration.
///      &lt;/p&gt;
///    &lt;/li&gt;
///  &lt;/ul&gt;
///
/// </summary>
/// <seealso>
///
///  vtkStructuredGridConnectivity vtkStructuredAMRGridConnectivity
/// </seealso>
public abstract class vtkAbstractGridConnectivity : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractGridConnectivity";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractGridConnectivity()
	{
		MRClassNameKey = "class vtkAbstractGridConnectivity";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractGridConnectivity"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractGridConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractGridConnectivity_ComputeNeighbors_01(HandleRef pThis);

	/// <summary>
	/// Computes the grid neighboring topology for the domain
	/// </summary>
	public virtual void ComputeNeighbors()
	{
		vtkAbstractGridConnectivity_ComputeNeighbors_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractGridConnectivity_CreateGhostLayers_02(HandleRef pThis, int N);

	/// <summary>
	/// Creates N layers of ghost layers where N is the number of cells that will
	/// be added to each grid. If no parameter is supplied, N has a nominal value
	/// of 1, in which case 1 layer of cells would be added.
	/// NOTE: This method is implemented by concrete implementations
	/// </summary>
	public virtual void CreateGhostLayers(int N)
	{
		vtkAbstractGridConnectivity_CreateGhostLayers_02(GetCppThis(), N);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedCellGhostArray_03(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ghosted cells ghost array for the grid associated with the
	/// given grid ID. The return pointer is a shallow-copy of the internal
	/// data-structure. The pointer may be nullptr iff there is no ghosted cells
	/// ghost array for the requested grid.
	/// </summary>
	public vtkUnsignedCharArray GetGhostedCellGhostArray(int gridID)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractGridConnectivity_GetGhostedCellGhostArray_03(GetCppThis(), gridID, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedGridCellData_04(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ghosted grid cell data for the grid associated with the
	/// given grid ID. The return pointer is a shallow-copy of the internal
	/// data-structure. The pointer may be nullptr iff there is no ghosted cell
	/// data for the requested grid.
	/// </summary>
	public vtkCellData GetGhostedGridCellData(int gridID)
	{
		vtkCellData vtkCellData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractGridConnectivity_GetGhostedGridCellData_04(GetCppThis(), gridID, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellData2 = (vtkCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellData2.Register(null);
			}
		}
		return vtkCellData2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedGridPointData_05(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ghosted grid point data for the grid associated with the
	/// given grid ID. The return pointer is a shallow-copy of the internal
	/// data-structure. The pointer may be nullptr iff there is no ghosted point
	/// data for the requested grid.
	/// </summary>
	public vtkPointData GetGhostedGridPointData(int gridID)
	{
		vtkPointData vtkPointData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractGridConnectivity_GetGhostedGridPointData_05(GetCppThis(), gridID, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointData2 = (vtkPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointData2.Register(null);
			}
		}
		return vtkPointData2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedPointGhostArray_06(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ghosted points ghost array for the grid associated with the
	/// given grid ID. The return pointer is a shallow-copy of the internal
	/// data-structure. The pointer may be nullptr iff there is no ghosted points
	/// ghost array for the requested grid.
	/// </summary>
	public vtkUnsignedCharArray GetGhostedPointGhostArray(int gridID)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractGridConnectivity_GetGhostedPointGhostArray_06(GetCppThis(), gridID, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedPoints_07(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the ghosted grid points for the grid associated with the given
	/// grid ID. The return pointer is a shallow-copy of the internal data
	/// structure. The pointer may be nullptr iff there are no ghosted points
	/// created for the requested grid.
	/// </summary>
	public vtkPoints GetGhostedPoints(int gridID)
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractGridConnectivity_GetGhostedPoints_07(GetCppThis(), gridID, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractGridConnectivity_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractGridConnectivity_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractGridConnectivity_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractGridConnectivity_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAbstractGridConnectivity_GetNumberOfGhostLayers_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of ghost layers
	/// </summary>
	public virtual uint GetNumberOfGhostLayers()
	{
		return vtkAbstractGridConnectivity_GetNumberOfGhostLayers_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAbstractGridConnectivity_GetNumberOfGrids_11(HandleRef pThis);

	/// <summary>
	/// Returns the total number of grids.
	/// </summary>
	public uint GetNumberOfGrids()
	{
		return vtkAbstractGridConnectivity_GetNumberOfGrids_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractGridConnectivity_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractGridConnectivity_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractGridConnectivity_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractGridConnectivity_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractGridConnectivity_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractGridConnectivity NewInstance()
	{
		vtkAbstractGridConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractGridConnectivity_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractGridConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractGridConnectivity_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractGridConnectivity SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractGridConnectivity vtkAbstractGridConnectivity2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractGridConnectivity_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractGridConnectivity2 = (vtkAbstractGridConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractGridConnectivity2.Register(null);
			}
		}
		return vtkAbstractGridConnectivity2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractGridConnectivity_SetNumberOfGhostLayers_16(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the number of ghost layers
	/// </summary>
	public virtual void SetNumberOfGhostLayers(uint _arg)
	{
		vtkAbstractGridConnectivity_SetNumberOfGhostLayers_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractGridConnectivity_SetNumberOfGrids_17(HandleRef pThis, uint N);

	/// <summary>
	/// Sets the total number of grids in the domain.
	/// Note: This method is implemented by concrete classes.
	/// NOTE: Concrete classes implementing this pure virtual method must
	/// set the number of grids and call AllocateUserRegisterDataStructures
	/// in addition to defining any other additional functionality.
	/// </summary>
	public virtual void SetNumberOfGrids(uint N)
	{
		vtkAbstractGridConnectivity_SetNumberOfGrids_17(GetCppThis(), N);
	}
}
