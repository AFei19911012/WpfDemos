using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRInformation
/// </summary>
/// <remarks>
///    Meta data that describes the structure of an AMR data set
///
///
/// vtkAMRInformation encapsulates the following meta information for an AMR data set
/// - a list of vtkAMRBox objects
/// - Refinement ratio between AMR levels
/// - Grid spacing for each level
/// - The file block index for each block
/// - parent child information, if requested
///
/// </remarks>
/// <seealso>
///
/// vtkOverlappingAMR, vtkAMRBox
/// </seealso>
public class vtkAMRInformation : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRInformation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRInformation()
	{
		MRClassNameKey = "class vtkAMRInformation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRInformation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRInformation New()
	{
		vtkAMRInformation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAMRInformation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAMRInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkAMRInformation_Audit_01(HandleRef pThis);

	/// <summary>
	/// Checks whether the meta data is internally consistent.
	/// </summary>
	public bool Audit()
	{
		return (vtkAMRInformation_Audit_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_ComputeIndexPair_02(HandleRef pThis, uint index, ref uint level, ref uint id);

	/// <summary>
	/// Returns the an index pair given a single index
	/// </summary>
	public void ComputeIndexPair(uint index, ref uint level, ref uint id)
	{
		vtkAMRInformation_ComputeIndexPair_02(GetCppThis(), index, ref level, ref id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_DeepCopy_03(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Returns internal arrays.
	/// </summary>
	public void DeepCopy(vtkAMRInformation other)
	{
		vtkAMRInformation_DeepCopy_03(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInformation_FindCell_04(HandleRef pThis, IntPtr q, uint level, uint index, ref int cellIdx);

	/// <summary>
	/// Given a point q, find whether q is bounded by the data set at
	/// (level,index).  If it is, set cellIdx to the cell index and return
	/// true; otherwise return false
	/// </summary>
	public bool FindCell(IntPtr q, uint level, uint index, ref int cellIdx)
	{
		return (vtkAMRInformation_FindCell_04(GetCppThis(), q, level, index, ref cellIdx) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInformation_FindGrid_05(HandleRef pThis, IntPtr q, int level, ref uint gridId);

	/// <summary>
	/// find the grid that contains the point q at the specified level
	/// </summary>
	public bool FindGrid(IntPtr q, int level, ref uint gridId)
	{
		return (vtkAMRInformation_FindGrid_05(GetCppThis(), q, level, ref gridId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInformation_FindGrid_06(HandleRef pThis, IntPtr q, ref uint level, ref uint gridId);

	/// <summary>
	/// Given a point q, find the highest level grid that contains it.
	/// </summary>
	public bool FindGrid(IntPtr q, ref uint level, ref uint gridId)
	{
		return (vtkAMRInformation_FindGrid_06(GetCppThis(), q, ref level, ref gridId) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_GenerateParentChildInformation_07(HandleRef pThis);

	/// <summary>
	/// Generate the parent/child relationships - needed to be called
	/// before GetParents or GetChildren can be used!
	/// </summary>
	public void GenerateParentChildInformation()
	{
		vtkAMRInformation_GenerateParentChildInformation_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_GenerateRefinementRatio_08(HandleRef pThis);

	/// <summary>
	/// This method computes the refinement ratio at each level.
	/// At each level, l, the refinement ratio r_l is computed by
	/// r_l = D_{l} / D_{l+1}, where D_{l+1} and D_{l} are the grid
	/// spacings at the next and current level respectively.
	///
	/// .SECTION Assumptions
	/// 1) Within each level, the refinement ratios are the same for all blocks.
	/// 2) The refinement ratio is uniform along each dimension of the block.
	/// </summary>
	public void GenerateRefinementRatio()
	{
		vtkAMRInformation_GenerateRefinementRatio_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInformation_GetAMRBlockSourceIndex_09(HandleRef pThis, int index);

	/// <summary>
	/// Get/Set the SourceIndex of a block. Typically, this is a file-type specific index
	/// that can be used by a reader to load a particular file block
	/// </summary>
	public int GetAMRBlockSourceIndex(int index)
	{
		return vtkAMRInformation_GetAMRBlockSourceIndex_09(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInformation_GetBounds_10(HandleRef pThis);

	/// <summary>
	/// Returns the bounds of the entire domain
	/// </summary>
	public IntPtr GetBounds()
	{
		return vtkAMRInformation_GetBounds_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_GetBounds_11(HandleRef pThis, uint level, uint id, IntPtr bb);

	/// <summary>
	/// Returns the bounding box of a given box
	/// </summary>
	public void GetBounds(uint level, uint id, IntPtr bb)
	{
		vtkAMRInformation_GetBounds_11(GetCppThis(), level, id, bb);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInformation_GetChildren_12(HandleRef pThis, uint level, uint index, ref uint numChildren);

	/// <summary>
	/// Return a pointer to Children of a block.  The first entry is the number
	/// of children the block has followed by its children ids in level+1.
	/// If none exits it returns nullptr.
	/// </summary>
	public IntPtr GetChildren(uint level, uint index, ref uint numChildren)
	{
		return vtkAMRInformation_GetChildren_12(GetCppThis(), level, index, ref numChildren);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInformation_GetGridDescription_13(HandleRef pThis);

	/// <summary>
	/// returns the value of vtkUniformGrid::GridDescription() of any block
	/// </summary>
	public virtual int GetGridDescription()
	{
		return vtkAMRInformation_GetGridDescription_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInformation_GetIndex_14(HandleRef pThis, uint level, uint id);

	/// <summary>
	/// Returns the single index from a pair of indices
	/// </summary>
	public int GetIndex(uint level, uint id)
	{
		return vtkAMRInformation_GetIndex_14(GetCppThis(), level, id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAMRInformation_GetNumberOfDataSets_15(HandleRef pThis, uint level);

	/// <summary>
	/// Returns the number of datasets at the given levelx
	/// </summary>
	public uint GetNumberOfDataSets(uint level)
	{
		return vtkAMRInformation_GetNumberOfDataSets_15(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRInformation_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRInformation_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRInformation_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRInformation_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAMRInformation_GetNumberOfLevels_18(HandleRef pThis);

	/// <summary>
	/// Return the number of levels
	/// </summary>
	public uint GetNumberOfLevels()
	{
		return vtkAMRInformation_GetNumberOfLevels_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_GetOrigin_19(HandleRef pThis, IntPtr origin);

	/// <summary>
	/// Get the AMR dataset origin
	/// The origin is essentially the minimum of all the grids.
	/// </summary>
	public void GetOrigin(IntPtr origin)
	{
		vtkAMRInformation_GetOrigin_19(GetCppThis(), origin);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInformation_GetOrigin_20(HandleRef pThis);

	/// <summary>
	/// Get the AMR dataset origin
	/// The origin is essentially the minimum of all the grids.
	/// </summary>
	public IntPtr GetOrigin()
	{
		return vtkAMRInformation_GetOrigin_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInformation_GetOrigin_21(HandleRef pThis, uint level, uint id, IntPtr origin);

	/// <summary>
	/// Returns the origin of the grid at (level,id)
	/// </summary>
	public bool GetOrigin(uint level, uint id, IntPtr origin)
	{
		return (vtkAMRInformation_GetOrigin_21(GetCppThis(), level, id, origin) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInformation_GetParents_22(HandleRef pThis, uint level, uint index, ref uint numParents);

	/// <summary>
	/// Return a pointer to Parents of a block.  The first entry is the number
	/// of parents the block has followed by its parent ids in level-1.
	/// If none exits it returns nullptr.
	/// </summary>
	public IntPtr GetParents(uint level, uint index, ref uint numParents)
	{
		return vtkAMRInformation_GetParents_22(GetCppThis(), level, index, ref numParents);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInformation_GetRefinementRatio_23(HandleRef pThis, uint level);

	/// <summary>
	/// Returns the refinement of a given level.
	/// </summary>
	public int GetRefinementRatio(uint level)
	{
		return vtkAMRInformation_GetRefinementRatio_23(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_GetSpacing_24(HandleRef pThis, uint level, IntPtr spacing);

	/// <summary>
	/// Return the spacing at the given fiven
	/// </summary>
	public void GetSpacing(uint level, IntPtr spacing)
	{
		vtkAMRInformation_GetSpacing_24(GetCppThis(), level, spacing);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkAMRInformation_GetTotalNumberOfBlocks_25(HandleRef pThis);

	/// <summary>
	/// Returns total number of datasets
	/// </summary>
	public uint GetTotalNumberOfBlocks()
	{
		return vtkAMRInformation_GetTotalNumberOfBlocks_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInformation_HasChildrenInformation_26(HandleRef pThis);

	/// <summary>
	/// Return whether parent child information has been generated
	/// </summary>
	public bool HasChildrenInformation()
	{
		return (vtkAMRInformation_HasChildrenInformation_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInformation_HasRefinementRatio_27(HandleRef pThis);

	/// <summary>
	/// Returns whether refinement ratio has been set (either by calling
	/// GenerateRefinementRatio() or by calling SetRefinementRatio()
	/// </summary>
	public bool HasRefinementRatio()
	{
		return (vtkAMRInformation_HasRefinementRatio_27(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRInformation_HasSpacing_28(HandleRef pThis, uint level);

	/// <summary>
	/// Return the spacing at the given fiven
	/// </summary>
	public bool HasSpacing(uint level)
	{
		return (vtkAMRInformation_HasSpacing_28(GetCppThis(), level) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_Initialize_29(HandleRef pThis, int numLevels, IntPtr blocksPerLevel);

	/// <summary>
	/// Initialize the meta information
	/// numLevels is the number of levels
	/// blocksPerLevel[i] is the number of blocks at level i
	/// </summary>
	public void Initialize(int numLevels, IntPtr blocksPerLevel)
	{
		vtkAMRInformation_Initialize_29(GetCppThis(), numLevels, blocksPerLevel);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInformation_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRInformation_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRInformation_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRInformation_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInformation_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRInformation NewInstance()
	{
		vtkAMRInformation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRInformation_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_PrintParentChildInfo_34(HandleRef pThis, uint level, uint index);

	/// <summary>
	/// Prints the parents and children of a requested block (Debug Routine)
	/// </summary>
	public void PrintParentChildInfo(uint level, uint index)
	{
		vtkAMRInformation_PrintParentChildInfo_34(GetCppThis(), level, index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRInformation_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRInformation SafeDownCast(vtkObjectBase o)
	{
		vtkAMRInformation vtkAMRInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRInformation_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRInformation2 = (vtkAMRInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRInformation2.Register(null);
			}
		}
		return vtkAMRInformation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_SetAMRBlockSourceIndex_36(HandleRef pThis, int index, int sourceId);

	/// <summary>
	/// Get/Set the SourceIndex of a block. Typically, this is a file-type specific index
	/// that can be used by a reader to load a particular file block
	/// </summary>
	public void SetAMRBlockSourceIndex(int index, int sourceId)
	{
		vtkAMRInformation_SetAMRBlockSourceIndex_36(GetCppThis(), index, sourceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_SetGridDescription_37(HandleRef pThis, int description);

	/// <summary>
	/// returns the value of vtkUniformGrid::GridDescription() of any block
	/// </summary>
	public void SetGridDescription(int description)
	{
		vtkAMRInformation_SetGridDescription_37(GetCppThis(), description);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_SetOrigin_38(HandleRef pThis, IntPtr origin);

	/// <summary>
	/// Get the AMR dataset origin
	/// The origin is essentially the minimum of all the grids.
	/// </summary>
	public void SetOrigin(IntPtr origin)
	{
		vtkAMRInformation_SetOrigin_38(GetCppThis(), origin);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_SetRefinementRatio_39(HandleRef pThis, uint level, int ratio);

	/// <summary>
	/// Set the refinement ratio at a level. This method should be
	/// called for all levels, if called at all.
	/// </summary>
	public void SetRefinementRatio(uint level, int ratio)
	{
		vtkAMRInformation_SetRefinementRatio_39(GetCppThis(), level, ratio);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRInformation_SetSpacing_40(HandleRef pThis, uint level, IntPtr h);

	/// <summary>
	/// Set the spacing at a given level
	/// </summary>
	public void SetSpacing(uint level, IntPtr h)
	{
		vtkAMRInformation_SetSpacing_40(GetCppThis(), level, h);
	}
}
