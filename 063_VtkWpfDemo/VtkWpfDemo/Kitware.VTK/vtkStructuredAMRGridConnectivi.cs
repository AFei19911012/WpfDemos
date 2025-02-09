using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStructuredAMRGridConnectivity
///  grid connectivity.
///
///
///  A concrete instance of vtkAbstractGridConnectivity that implements
///  functionality for computing the neighboring topology within a structured
///  AMR grid, as well as, generating ghost-layers. Support is provided for
///  1-D, 2-D (XY,XZ,YZ) and 3-D cell-centered datasets. This implementation
///  does not have any support for distributed data. For the parallel
///  implementation see vtkPStructuredAMRGridConnectivity.
///
/// </summary>
/// <seealso>
///
///  vtkPStructuredAMRGridConnectivity vtkAbstractGridConnectivity
/// </seealso>
public class vtkStructuredAMRGridConnectivity : vtkAbstractGridConnectivity
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredAMRGridConnectivity";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStructuredAMRGridConnectivity()
	{
		MRClassNameKey = "class vtkStructuredAMRGridConnectivity";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredAMRGridConnectivity"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStructuredAMRGridConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredAMRGridConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredAMRGridConnectivity New()
	{
		vtkStructuredAMRGridConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredAMRGridConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredAMRGridConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStructuredAMRGridConnectivity()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStructuredAMRGridConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkStructuredAMRGridConnectivity_ComputeNeighbors_01(HandleRef pThis);

	/// <summary>
	/// Computes neighboring information.
	/// </summary>
	public override void ComputeNeighbors()
	{
		vtkStructuredAMRGridConnectivity_ComputeNeighbors_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredAMRGridConnectivity_CreateGhostLayers_02(HandleRef pThis, int N);

	/// <summary>
	/// Creates ghost layers.
	/// </summary>
	public override void CreateGhostLayers(int N)
	{
		vtkStructuredAMRGridConnectivity_CreateGhostLayers_02(GetCppThis(), N);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredAMRGridConnectivity_GetBalancedRefinement_03(HandleRef pThis);

	/// <summary>
	/// Get/Set macro for BalancedRefinement property, default is true. If the
	/// refinement is balanced, then, adjacent grids in the AMR hierarchy can
	/// only differ by one level. By default, a balanced refinement is assumed.
	/// </summary>
	public virtual bool GetBalancedRefinement()
	{
		return (vtkStructuredAMRGridConnectivity_GetBalancedRefinement_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredAMRGridConnectivity_GetCellCentered_04(HandleRef pThis);

	/// <summary>
	/// Get/Set CellCentered property which indicates if the data is cell-centered
	/// By default, cell-centered is set to true.
	/// </summary>
	public virtual bool GetCellCentered()
	{
		return (vtkStructuredAMRGridConnectivity_GetCellCentered_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredAMRGridConnectivity_GetGhostedExtent_05(HandleRef pThis, int gridID, IntPtr ext);

	/// <summary>
	/// Returns the ghost extend for the grid corresponding to the given grid ID.
	/// </summary>
	public void GetGhostedExtent(int gridID, IntPtr ext)
	{
		vtkStructuredAMRGridConnectivity_GetGhostedExtent_05(GetCppThis(), gridID, ext);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStructuredAMRGridConnectivity_GetNodeCentered_06(HandleRef pThis);

	/// <summary>
	/// Get/Set macro NodeCentered property which indicates if the data is
	/// node-centered or cell-centered. By default, node-centered is set to false
	/// since AMR datasets are primarily cell-centered.
	/// </summary>
	public virtual bool GetNodeCentered()
	{
		return (vtkStructuredAMRGridConnectivity_GetNodeCentered_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredAMRGridConnectivity_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStructuredAMRGridConnectivity_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredAMRGridConnectivity_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStructuredAMRGridConnectivity_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredAMRGridConnectivity_GetNumberOfNeighbors_09(HandleRef pThis, int gridID);

	/// <summary>
	/// Returns the number of neighbors for the grid corresponding to the given
	/// grid ID.
	/// </summary>
	public int GetNumberOfNeighbors(int gridID)
	{
		return vtkStructuredAMRGridConnectivity_GetNumberOfNeighbors_09(GetCppThis(), gridID);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredAMRGridConnectivity_Initialize_10(HandleRef pThis, uint NumberOfLevels, uint N, int RefinementRatio);

	/// <summary>
	/// Initializes this instance of vtkStructuredAMRGridConnectivity where N
	/// is the total number of grids in the AMR hierarchy. Optionally, if the
	/// AMR dataset has a constant refinement, it should be specified during
	/// initialization as the code optimizes for it. If a -1 or no refinement
	/// ratio is specified a varying refinement ratio is assumed.
	/// </summary>
	public void Initialize(uint NumberOfLevels, uint N, int RefinementRatio)
	{
		vtkStructuredAMRGridConnectivity_Initialize_10(GetCppThis(), NumberOfLevels, N, RefinementRatio);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredAMRGridConnectivity_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStructuredAMRGridConnectivity_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredAMRGridConnectivity_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStructuredAMRGridConnectivity_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredAMRGridConnectivity_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStructuredAMRGridConnectivity NewInstance()
	{
		vtkStructuredAMRGridConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredAMRGridConnectivity_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredAMRGridConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredAMRGridConnectivity_RegisterGrid_15(HandleRef pThis, int gridIdx, int level, int refinementRatio, IntPtr extents, HandleRef nodesGhostArray, HandleRef cellGhostArray, HandleRef pointData, HandleRef cellData, HandleRef gridNodes);

	/// <summary>
	/// Registers the AMR grid with the given global linear grid ID (starting
	/// numbering from 0) and level and refinement ratio. This method is to be
	/// used when the refinement ratio is not constant.
	/// </summary>
	public virtual void RegisterGrid(int gridIdx, int level, int refinementRatio, IntPtr extents, vtkUnsignedCharArray nodesGhostArray, vtkUnsignedCharArray cellGhostArray, vtkPointData pointData, vtkCellData cellData, vtkPoints gridNodes)
	{
		vtkStructuredAMRGridConnectivity_RegisterGrid_15(GetCppThis(), gridIdx, level, refinementRatio, extents, nodesGhostArray?.GetCppThis() ?? default(HandleRef), cellGhostArray?.GetCppThis() ?? default(HandleRef), pointData?.GetCppThis() ?? default(HandleRef), cellData?.GetCppThis() ?? default(HandleRef), gridNodes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredAMRGridConnectivity_RegisterGrid_16(HandleRef pThis, int gridIdx, int level, IntPtr extents, HandleRef nodesGhostArray, HandleRef cellGhostArray, HandleRef pointData, HandleRef cellData, HandleRef gridNodes);

	/// <summary>
	/// Registers the AMR grid with the given global linear grid ID (starting
	/// numbering from 0) and level. The extents of the grid are expected to be
	/// global node extents.
	/// </summary>
	public virtual void RegisterGrid(int gridIdx, int level, IntPtr extents, vtkUnsignedCharArray nodesGhostArray, vtkUnsignedCharArray cellGhostArray, vtkPointData pointData, vtkCellData cellData, vtkPoints gridNodes)
	{
		vtkStructuredAMRGridConnectivity_RegisterGrid_16(GetCppThis(), gridIdx, level, extents, nodesGhostArray?.GetCppThis() ?? default(HandleRef), cellGhostArray?.GetCppThis() ?? default(HandleRef), pointData?.GetCppThis() ?? default(HandleRef), cellData?.GetCppThis() ?? default(HandleRef), gridNodes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredAMRGridConnectivity_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredAMRGridConnectivity SafeDownCast(vtkObjectBase o)
	{
		vtkStructuredAMRGridConnectivity vtkStructuredAMRGridConnectivity2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredAMRGridConnectivity_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredAMRGridConnectivity2 = (vtkStructuredAMRGridConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredAMRGridConnectivity2.Register(null);
			}
		}
		return vtkStructuredAMRGridConnectivity2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredAMRGridConnectivity_SetBalancedRefinement_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set macro for BalancedRefinement property, default is true. If the
	/// refinement is balanced, then, adjacent grids in the AMR hierarchy can
	/// only differ by one level. By default, a balanced refinement is assumed.
	/// </summary>
	public virtual void SetBalancedRefinement(bool _arg)
	{
		vtkStructuredAMRGridConnectivity_SetBalancedRefinement_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredAMRGridConnectivity_SetCellCentered_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set CellCentered property which indicates if the data is cell-centered
	/// By default, cell-centered is set to true.
	/// </summary>
	public virtual void SetCellCentered(bool _arg)
	{
		vtkStructuredAMRGridConnectivity_SetCellCentered_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredAMRGridConnectivity_SetNodeCentered_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set macro NodeCentered property which indicates if the data is
	/// node-centered or cell-centered. By default, node-centered is set to false
	/// since AMR datasets are primarily cell-centered.
	/// </summary>
	public virtual void SetNodeCentered(bool _arg)
	{
		vtkStructuredAMRGridConnectivity_SetNodeCentered_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
