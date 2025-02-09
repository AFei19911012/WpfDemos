using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStructuredGridConnectivity
///
///
///  vtkStructuredGridConnectivity is a concrete instance of vtkObject that
///  implements functionality for computing the neighboring topology within a
///  single partitioned structured grid dataset. This class implementation does
///  not have any support for distributed data. For the parallel implementation
///  see vtkPStructuredGridConnectivity.
///
/// </summary>
/// <seealso>
///
///  vtkPStructuredGridConnectivity
/// </seealso>
public class vtkStructuredGridConnectivity : vtkAbstractGridConnectivity
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridConnectivity";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStructuredGridConnectivity()
	{
		MRClassNameKey = "class vtkStructuredGridConnectivity";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridConnectivity"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStructuredGridConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGridConnectivity New()
	{
		vtkStructuredGridConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredGridConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStructuredGridConnectivity()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStructuredGridConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_ComputeNeighbors_01(HandleRef pThis);

	/// <summary>
	/// Computes neighboring information
	/// </summary>
	public override void ComputeNeighbors()
	{
		vtkStructuredGridConnectivity_ComputeNeighbors_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_CreateGhostLayers_02(HandleRef pThis, int N);

	/// <summary>
	/// Creates ghost layers.
	/// </summary>
	public override void CreateGhostLayers(int N)
	{
		vtkStructuredGridConnectivity_CreateGhostLayers_02(GetCppThis(), N);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_FillGhostArrays_03(HandleRef pThis, int gridID, HandleRef nodesArray, HandleRef cellsArray);

	/// <summary>
	/// Fills the mesh property arrays, nodes and cells, for the grid
	/// corresponding to the given grid ID.
	/// NOTE: this method assumes that ComputeNeighbors() has been called.
	/// </summary>
	public virtual void FillGhostArrays(int gridID, vtkUnsignedCharArray nodesArray, vtkUnsignedCharArray cellsArray)
	{
		vtkStructuredGridConnectivity_FillGhostArrays_03(GetCppThis(), gridID, nodesArray?.GetCppThis() ?? default(HandleRef), cellsArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridConnectivity_GetDataDimension_04(HandleRef pThis);

	/// <summary>
	/// Returns the data dimension based on the whole extent
	/// </summary>
	public virtual int GetDataDimension()
	{
		return vtkStructuredGridConnectivity_GetDataDimension_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_GetGhostedGridExtent_05(HandleRef pThis, int gridID, IntPtr ext);

	/// <summary>
	/// Returns the ghosted grid extent for the block corresponding the
	/// </summary>
	public void GetGhostedGridExtent(int gridID, IntPtr ext)
	{
		vtkStructuredGridConnectivity_GetGhostedGridExtent_05(GetCppThis(), gridID, ext);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_GetGridExtent_06(HandleRef pThis, int gridID, IntPtr extent);

	/// <summary>
	/// Returns the grid extent of the grid corresponding to the given grid ID.
	/// </summary>
	public void GetGridExtent(int gridID, IntPtr extent)
	{
		vtkStructuredGridConnectivity_GetGridExtent_06(GetCppThis(), gridID, extent);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridConnectivity_GetNeighbors_07(HandleRef pThis, int gridID, IntPtr extents, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the list of neighboring blocks for the given grid and the
	/// corresponding overlapping extents are filled in the 1-D flat array
	/// strided by 6.
	///
	/// NOTE: the flat array extents must be pre-allocated.
	/// </summary>
	public vtkIdList GetNeighbors(int gridID, IntPtr extents)
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridConnectivity_GetNeighbors_07(GetCppThis(), gridID, extents, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdList2 = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdList2.Register(null);
			}
		}
		return vtkIdList2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGridConnectivity_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStructuredGridConnectivity_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGridConnectivity_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStructuredGridConnectivity_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridConnectivity_GetNumberOfNeighbors_10(HandleRef pThis, int gridID);

	/// <summary>
	/// Returns the number of neighbors for the grid corresponding to the given
	/// grid ID.
	/// </summary>
	public int GetNumberOfNeighbors(int gridID)
	{
		return vtkStructuredGridConnectivity_GetNumberOfNeighbors_10(GetCppThis(), gridID);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridConnectivity_GetWholeExtent_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the whole extent of the grid
	/// </summary>
	public virtual int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkStructuredGridConnectivity_GetWholeExtent_11(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_GetWholeExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set/Get the whole extent of the grid
	/// </summary>
	public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkStructuredGridConnectivity_GetWholeExtent_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_GetWholeExtent_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the whole extent of the grid
	/// </summary>
	public virtual void GetWholeExtent(IntPtr _arg)
	{
		vtkStructuredGridConnectivity_GetWholeExtent_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridConnectivity_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStructuredGridConnectivity_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridConnectivity_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStructuredGridConnectivity_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridConnectivity_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStructuredGridConnectivity NewInstance()
	{
		vtkStructuredGridConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridConnectivity_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredGridConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_RegisterGrid_18(HandleRef pThis, int gridID, IntPtr extents, HandleRef nodesGhostArray, HandleRef cellGhostArray, HandleRef pointData, HandleRef cellData, HandleRef gridNodes);

	/// <summary>
	/// Registers the current grid corresponding to the grid ID by its global
	/// extent w.r.t. the whole extent.
	/// </summary>
	public virtual void RegisterGrid(int gridID, IntPtr extents, vtkUnsignedCharArray nodesGhostArray, vtkUnsignedCharArray cellGhostArray, vtkPointData pointData, vtkCellData cellData, vtkPoints gridNodes)
	{
		vtkStructuredGridConnectivity_RegisterGrid_18(GetCppThis(), gridID, extents, nodesGhostArray?.GetCppThis() ?? default(HandleRef), cellGhostArray?.GetCppThis() ?? default(HandleRef), pointData?.GetCppThis() ?? default(HandleRef), cellData?.GetCppThis() ?? default(HandleRef), gridNodes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridConnectivity_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGridConnectivity SafeDownCast(vtkObjectBase o)
	{
		vtkStructuredGridConnectivity vtkStructuredGridConnectivity2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridConnectivity_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGridConnectivity2 = (vtkStructuredGridConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGridConnectivity2.Register(null);
			}
		}
		return vtkStructuredGridConnectivity2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_SetGhostedGridExtent_20(HandleRef pThis, int gridID, IntPtr ext);

	/// <summary>
	/// Sets the ghosted grid extent for the grid corresponding to the given
	/// grid ID to the given extent.
	/// </summary>
	public void SetGhostedGridExtent(int gridID, IntPtr ext)
	{
		vtkStructuredGridConnectivity_SetGhostedGridExtent_20(GetCppThis(), gridID, ext);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_SetNumberOfGrids_21(HandleRef pThis, uint N);

	/// <summary>
	/// Set/Get the total number of domains distributed among processors
	/// </summary>
	public override void SetNumberOfGrids(uint N)
	{
		vtkStructuredGridConnectivity_SetNumberOfGrids_21(GetCppThis(), N);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_SetWholeExtent_22(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set/Get the whole extent of the grid
	/// </summary>
	public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkStructuredGridConnectivity_SetWholeExtent_22(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridConnectivity_SetWholeExtent_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the whole extent of the grid
	/// </summary>
	public virtual void SetWholeExtent(IntPtr _arg)
	{
		vtkStructuredGridConnectivity_SetWholeExtent_23(GetCppThis(), _arg);
	}
}
