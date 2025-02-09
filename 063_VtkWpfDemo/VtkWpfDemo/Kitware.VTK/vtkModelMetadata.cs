using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkModelMetadata
/// </summary>
/// <remarks>
///    This class encapsulates the metadata
///   that appear in mesh-based file formats but do not appear in
///   vtkUnstructuredGrid.
///
///
///   This class is inspired by the Exodus II file format, but
///   because this class does not depend on the Exodus library, it
///   should be possible to use it to represent metadata for other
///   dataset file formats.  Sandia Labs uses it in their Exodus II
///   reader, their Exodus II writer and their EnSight writer.
///   vtkDistributedDataFilter looks for metadata attached to
///   it's input and redistributes the metadata with the grid.
///
///   The fields in this class are those described in the document
///   "EXODUS II: A Finite Element Data Model", SAND92-2137, November 1995.
///
///   Element and node IDs stored in this object must be global IDs,
///   in the event that the original dataset was partitioned across
///   many files.
///
///   One way to initialize this object is by using vtkExodusModel
///   (a Sandia class used by the Sandia Exodus reader).
///   That class will take an open Exodus II file and a
///   vtkUnstructuredGrid drawn from it and will set the required fields.
///
///   Alternatively, you can use all the Set*
///   methods to set the individual fields. This class does not
///   copy the data, it simply uses your pointer. This
///   class will free the storage associated with your pointer
///   when the class is deleted.  Most fields have sensible defaults.
///   The only requirement is that if you are using this ModelMetadata
///   to write out an Exodus or EnSight file in parallel, you must
///   SetBlockIds and SetBlockIdArrayName.  Your vtkUnstructuredGrid must
///   have a cell array giving the block ID for each cell.
///
/// @warning
///   The Exodus II library supports an optimized element order map
///   (section 3.7 in the SAND document).  It contains all the element
///   IDs, listed in the order in which a solver should process them.
///   We don't include this, and won't unless there is a request.
///
/// @warning
///   There is an assumption in some classes that the name of the cell
///   array containing global element ids is "GlobalElementId" and the
///   name of the point array containing global node ids is "GlobalNodeId".
///   (element == cell) and (node == point).
///
/// </remarks>
/// <seealso>
///
///   vtkDistributedDataFilter vtkExtractCells
/// </seealso>
public class vtkModelMetadata : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkModelMetadata";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkModelMetadata()
	{
		MRClassNameKey = "class vtkModelMetadata";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkModelMetadata"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkModelMetadata(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkModelMetadata New()
	{
		vtkModelMetadata result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModelMetadata_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkModelMetadata()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkModelMetadata_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_AllVariablesDefinedInAllBlocksOff_01(HandleRef pThis);

	/// <summary>
	/// Instead of a truth table of all "1"s, you can set this
	/// instance variable to indicate that all variables are
	/// defined in all blocks.
	/// </summary>
	public virtual void AllVariablesDefinedInAllBlocksOff()
	{
		vtkModelMetadata_AllVariablesDefinedInAllBlocksOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_AllVariablesDefinedInAllBlocksOn_02(HandleRef pThis);

	/// <summary>
	/// Instead of a truth table of all "1"s, you can set this
	/// instance variable to indicate that all variables are
	/// defined in all blocks.
	/// </summary>
	public virtual void AllVariablesDefinedInAllBlocksOn()
	{
		vtkModelMetadata_AllVariablesDefinedInAllBlocksOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeAllGlobalData_03(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeAllGlobalData()
	{
		vtkModelMetadata_FreeAllGlobalData_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeAllLocalData_04(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeAllLocalData()
	{
		vtkModelMetadata_FreeAllLocalData_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeBlockDependentData_05(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeBlockDependentData()
	{
		vtkModelMetadata_FreeBlockDependentData_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeOriginalElementVariableNames_06(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeOriginalElementVariableNames()
	{
		vtkModelMetadata_FreeOriginalElementVariableNames_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeOriginalNodeVariableNames_07(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeOriginalNodeVariableNames()
	{
		vtkModelMetadata_FreeOriginalNodeVariableNames_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeUsedElementVariableNames_08(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeUsedElementVariableNames()
	{
		vtkModelMetadata_FreeUsedElementVariableNames_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeUsedElementVariables_09(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeUsedElementVariables()
	{
		vtkModelMetadata_FreeUsedElementVariables_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeUsedNodeVariableNames_10(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeUsedNodeVariableNames()
	{
		vtkModelMetadata_FreeUsedNodeVariableNames_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_FreeUsedNodeVariables_11(HandleRef pThis);

	/// <summary>
	/// Free selected portions of the metadata when updating values
	/// in the vtkModelMetadata object.  Resetting a particular field,
	/// (i.e. SetNodeSetIds) frees the previous setting, but if you
	/// are not setting every field, you may want to do a wholesale
	/// "Free" first.
	///
	/// FreeAllGlobalData frees all the fields which don't depend on
	/// which time step, which blocks, or which variables are in the input.
	/// FreeAllLocalData frees all the fields which do depend on which
	/// time step, blocks or variables are in the input.
	/// FreeBlockDependentData frees all metadata fields which depend on
	/// which blocks were read in.
	/// </summary>
	public void FreeUsedNodeVariables()
	{
		vtkModelMetadata_FreeUsedNodeVariables_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetAllVariablesDefinedInAllBlocks_12(HandleRef pThis);

	/// <summary>
	/// Instead of a truth table of all "1"s, you can set this
	/// instance variable to indicate that all variables are
	/// defined in all blocks.
	/// </summary>
	public int GetAllVariablesDefinedInAllBlocks()
	{
		return vtkModelMetadata_GetAllVariablesDefinedInAllBlocks_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockAttributes_13(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the attributes for all
	/// blocks.  The order of the list should be by block, by element
	/// within the block, by attribute.  Omit blocks that don't
	/// have element attributes.
	/// </summary>
	public IntPtr GetBlockAttributes()
	{
		return vtkModelMetadata_GetBlockAttributes_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockAttributesIndex_14(HandleRef pThis);

	/// <summary>
	/// Get a list of the index into the BlockAttributes of the
	/// start of each block's element attribute list.
	/// </summary>
	public IntPtr GetBlockAttributesIndex()
	{
		return vtkModelMetadata_GetBlockAttributesIndex_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockElementIdList_15(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list global element IDs for the
	/// elements in each block.
	/// We use your pointers, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetBlockElementIdList()
	{
		return vtkModelMetadata_GetBlockElementIdList_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockElementIdListIndex_16(HandleRef pThis);

	/// <summary>
	/// Get a list of the index into the BlockElementIdList of the
	/// start of each block's elements.
	/// </summary>
	public IntPtr GetBlockElementIdListIndex()
	{
		return vtkModelMetadata_GetBlockElementIdListIndex_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockIds_17(HandleRef pThis);

	/// <summary>
	/// An arbitrary integer ID for each block.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetBlockIds()
	{
		return vtkModelMetadata_GetBlockIds_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockNodesPerElement_18(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the number of nodes in the
	/// elements of each block.
	/// We use your pointers, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetBlockNodesPerElement()
	{
		return vtkModelMetadata_GetBlockNodesPerElement_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockNumberOfAttributesPerElement_19(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the number of attributes
	/// stored for the elements in each block.
	/// We use your pointers, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetBlockNumberOfAttributesPerElement()
	{
		return vtkModelMetadata_GetBlockNumberOfAttributesPerElement_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockNumberOfElements_20(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the number of elements in
	/// each block.
	/// We use your pointers, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetBlockNumberOfElements()
	{
		return vtkModelMetadata_GetBlockNumberOfElements_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetBlockPropertyValue_21(HandleRef pThis);

	/// <summary>
	/// Set or get value for each variable for each block.  List
	/// the integer values in order by variable and within variable
	/// by block.
	/// </summary>
	public IntPtr GetBlockPropertyValue()
	{
		return vtkModelMetadata_GetBlockPropertyValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetDimension_22(HandleRef pThis);

	/// <summary>
	/// Get the dimension of the model.  This is also the number
	/// of coordinate names.
	/// </summary>
	public int GetDimension()
	{
		return vtkModelMetadata_GetDimension_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetElementVariableNumberOfComponents_23(HandleRef pThis);

	/// <summary>
	/// The ModelMetadata object may contain these lists:
	/// o  the variables in the original data file
	/// o  the variables created in the u grid from those original variables
	/// o  a mapping from the grid variable names to the original names
	/// o  a list of the number of components each grid variable has
	///
	/// (Example: Variables in Exodus II files are all scalars.  Some are
	/// combined by the ExodusReader into vector variables in the grid.)
	///
	/// These methods return names of the original variables, the names
	/// of the grid variables, a list of the number of components in
	/// each grid variable, and a list of the index into the list of
	/// original variable names where the original name of the first
	/// component of a grid variable may be found.  The names of subsequent
	/// components would immediately follow the name of the first
	/// component.
	/// </summary>
	public IntPtr GetElementVariableNumberOfComponents()
	{
		return vtkModelMetadata_GetElementVariableNumberOfComponents_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetElementVariableTruthTable_24(HandleRef pThis);

	/// <summary>
	/// A truth table indicating which element variables are
	/// defined for which blocks. The variables are all the original
	/// element variables that were in the file.
	/// The table is by block ID and within block ID by variable.
	/// </summary>
	public IntPtr GetElementVariableTruthTable()
	{
		return vtkModelMetadata_GetElementVariableTruthTable_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetGlobalVariableValue_25(HandleRef pThis);

	/// <summary>
	/// Set or get the values of the global variables at the current
	/// time step.
	/// </summary>
	public IntPtr GetGlobalVariableValue()
	{
		return vtkModelMetadata_GetGlobalVariableValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetMapToOriginalElementVariableNames_26(HandleRef pThis);

	/// <summary>
	/// The ModelMetadata object may contain these lists:
	/// o  the variables in the original data file
	/// o  the variables created in the u grid from those original variables
	/// o  a mapping from the grid variable names to the original names
	/// o  a list of the number of components each grid variable has
	///
	/// (Example: Variables in Exodus II files are all scalars.  Some are
	/// combined by the ExodusReader into vector variables in the grid.)
	///
	/// These methods return names of the original variables, the names
	/// of the grid variables, a list of the number of components in
	/// each grid variable, and a list of the index into the list of
	/// original variable names where the original name of the first
	/// component of a grid variable may be found.  The names of subsequent
	/// components would immediately follow the name of the first
	/// component.
	/// </summary>
	public IntPtr GetMapToOriginalElementVariableNames()
	{
		return vtkModelMetadata_GetMapToOriginalElementVariableNames_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetMapToOriginalNodeVariableNames_27(HandleRef pThis);

	/// <summary>
	/// The ModelMetadata object may contain these lists:
	/// o  the variables in the original data file
	/// o  the variables created in the u grid from those original variables
	/// o  a mapping from the grid variable names to the original names
	/// o  a list of the number of components each grid variable has
	///
	/// (Example: Variables in Exodus II files are all scalars.  Some are
	/// combined by the ExodusReader into vector variables in the grid.)
	///
	/// These methods return names of the original variables, the names
	/// of the grid variables, a list of the number of components in
	/// each grid variable, and a list of the index into the list of
	/// original variable names where the original name of the first
	/// component of a grid variable may be found.  The names of subsequent
	/// components would immediately follow the name of the first
	/// component.
	/// </summary>
	public IntPtr GetMapToOriginalNodeVariableNames()
	{
		return vtkModelMetadata_GetMapToOriginalNodeVariableNames_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetDistributionFactorIndex_28(HandleRef pThis);

	/// <summary>
	/// Get a list of the index of the starting entry for each node set
	/// in the list of node set distribution factors.
	/// </summary>
	public IntPtr GetNodeSetDistributionFactorIndex()
	{
		return vtkModelMetadata_GetNodeSetDistributionFactorIndex_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetDistributionFactors_29(HandleRef pThis);

	/// <summary>
	/// Set or get a list of the distribution factors for the node sets.
	/// The list is organized by node set, and within node set by node.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetNodeSetDistributionFactors()
	{
		return vtkModelMetadata_GetNodeSetDistributionFactors_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetIds_30(HandleRef pThis);

	/// <summary>
	/// Set or get the list the IDs for each node set.
	/// Length of list is the number of node sets.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetNodeSetIds()
	{
		return vtkModelMetadata_GetNodeSetIds_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetNames_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The number of node sets in the file.  Set this value before
	/// setting the various node set arrays.
	/// </summary>
	public vtkStringArray GetNodeSetNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModelMetadata_GetNodeSetNames_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetNodeIdList_32(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a concatenated list of the
	/// IDs of all nodes in each node set.  First list all IDs in
	/// node set 0, then all IDs in node set 1, and so on.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetNodeSetNodeIdList()
	{
		return vtkModelMetadata_GetNodeSetNodeIdList_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetNodeIdListIndex_33(HandleRef pThis);

	/// <summary>
	/// Get a list of the index of the starting entry for each node set
	/// in the list of node set node IDs.
	/// </summary>
	public IntPtr GetNodeSetNodeIdListIndex()
	{
		return vtkModelMetadata_GetNodeSetNodeIdListIndex_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetNumberOfDistributionFactors_34(HandleRef pThis);

	/// <summary>
	/// Set or get a list of the number of distribution factors stored
	/// by each node set.  This is either 0 or equal to the number of
	/// nodes in the node set.
	/// Length of list is number of node sets.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetNodeSetNumberOfDistributionFactors()
	{
		return vtkModelMetadata_GetNodeSetNumberOfDistributionFactors_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetPropertyValue_35(HandleRef pThis);

	/// <summary>
	/// Set or get value for each variable for each node set.  List
	/// the integer values in order by variable and within variable
	/// by node set.
	/// </summary>
	public IntPtr GetNodeSetPropertyValue()
	{
		return vtkModelMetadata_GetNodeSetPropertyValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeSetSize_36(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the number of nodes in each node set.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetNodeSetSize()
	{
		return vtkModelMetadata_GetNodeSetSize_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetNodeVariableNumberOfComponents_37(HandleRef pThis);

	/// <summary>
	/// The ModelMetadata object may contain these lists:
	/// o  the variables in the original data file
	/// o  the variables created in the u grid from those original variables
	/// o  a mapping from the grid variable names to the original names
	/// o  a list of the number of components each grid variable has
	///
	/// (Example: Variables in Exodus II files are all scalars.  Some are
	/// combined by the ExodusReader into vector variables in the grid.)
	///
	/// These methods return names of the original variables, the names
	/// of the grid variables, a list of the number of components in
	/// each grid variable, and a list of the index into the list of
	/// original variable names where the original name of the first
	/// component of a grid variable may be found.  The names of subsequent
	/// components would immediately follow the name of the first
	/// component.
	/// </summary>
	public IntPtr GetNodeVariableNumberOfComponents()
	{
		return vtkModelMetadata_GetNodeVariableNumberOfComponents_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfBlockProperties_38(HandleRef pThis);

	/// <summary>
	/// The number of block properties (global variables)
	/// </summary>
	public int GetNumberOfBlockProperties()
	{
		return vtkModelMetadata_GetNumberOfBlockProperties_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfBlocks_39(HandleRef pThis);

	/// <summary>
	/// The number of blocks in the file.  Set this before setting
	/// any of the block arrays.
	/// </summary>
	public int GetNumberOfBlocks()
	{
		return vtkModelMetadata_GetNumberOfBlocks_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfElementVariables_40(HandleRef pThis);

	/// <summary>
	/// The ModelMetadata object may contain these lists:
	/// o  the variables in the original data file
	/// o  the variables created in the u grid from those original variables
	/// o  a mapping from the grid variable names to the original names
	/// o  a list of the number of components each grid variable has
	///
	/// (Example: Variables in Exodus II files are all scalars.  Some are
	/// combined by the ExodusReader into vector variables in the grid.)
	///
	/// These methods return names of the original variables, the names
	/// of the grid variables, a list of the number of components in
	/// each grid variable, and a list of the index into the list of
	/// original variable names where the original name of the first
	/// component of a grid variable may be found.  The names of subsequent
	/// components would immediately follow the name of the first
	/// component.
	/// </summary>
	public int GetNumberOfElementVariables()
	{
		return vtkModelMetadata_GetNumberOfElementVariables_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkModelMetadata_GetNumberOfGenerationsFromBase_41(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkModelMetadata_GetNumberOfGenerationsFromBase_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkModelMetadata_GetNumberOfGenerationsFromBaseType_42(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkModelMetadata_GetNumberOfGenerationsFromBaseType_42(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfGlobalVariables_43(HandleRef pThis);

	/// <summary>
	/// Get the number of global variables per time step
	/// </summary>
	public int GetNumberOfGlobalVariables()
	{
		return vtkModelMetadata_GetNumberOfGlobalVariables_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfInformationLines_44(HandleRef pThis);

	/// <summary>
	/// Get the number of information lines.
	/// </summary>
	public int GetNumberOfInformationLines()
	{
		return vtkModelMetadata_GetNumberOfInformationLines_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfNodeSetProperties_45(HandleRef pThis);

	/// <summary>
	/// The number of node set properties (global variables)
	/// </summary>
	public int GetNumberOfNodeSetProperties()
	{
		return vtkModelMetadata_GetNumberOfNodeSetProperties_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfNodeSets_46(HandleRef pThis);

	/// <summary>
	/// The number of node sets in the file.  Set this value before
	/// setting the various node set arrays.
	/// </summary>
	public int GetNumberOfNodeSets()
	{
		return vtkModelMetadata_GetNumberOfNodeSets_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfNodeVariables_47(HandleRef pThis);

	/// <summary>
	/// The ModelMetadata object may contain these lists:
	/// o  the variables in the original data file
	/// o  the variables created in the u grid from those original variables
	/// o  a mapping from the grid variable names to the original names
	/// o  a list of the number of components each grid variable has
	///
	/// (Example: Variables in Exodus II files are all scalars.  Some are
	/// combined by the ExodusReader into vector variables in the grid.)
	///
	/// These methods return names of the original variables, the names
	/// of the grid variables, a list of the number of components in
	/// each grid variable, and a list of the index into the list of
	/// original variable names where the original name of the first
	/// component of a grid variable may be found.  The names of subsequent
	/// components would immediately follow the name of the first
	/// component.
	/// </summary>
	public int GetNumberOfNodeVariables()
	{
		return vtkModelMetadata_GetNumberOfNodeVariables_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfSideSetProperties_48(HandleRef pThis);

	/// <summary>
	/// The number of side set properties (global variables)
	/// </summary>
	public int GetNumberOfSideSetProperties()
	{
		return vtkModelMetadata_GetNumberOfSideSetProperties_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfSideSets_49(HandleRef pThis);

	/// <summary>
	/// Set or get the number of side sets.  Set this value before
	/// setting any of the other side set arrays.
	/// </summary>
	public int GetNumberOfSideSets()
	{
		return vtkModelMetadata_GetNumberOfSideSets_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetNumberOfTimeSteps_50(HandleRef pThis);

	/// <summary>
	/// Set the total number of time steps in the file,
	/// and the value at each time step.  We use your time
	/// step value array and delete it when we're done.
	/// </summary>
	public int GetNumberOfTimeSteps()
	{
		return vtkModelMetadata_GetNumberOfTimeSteps_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetOriginalNumberOfElementVariables_51(HandleRef pThis);

	/// <summary>
	/// The ModelMetadata object may contain these lists:
	/// o  the variables in the original data file
	/// o  the variables created in the u grid from those original variables
	/// o  a mapping from the grid variable names to the original names
	/// o  a list of the number of components each grid variable has
	///
	/// (Example: Variables in Exodus II files are all scalars.  Some are
	/// combined by the ExodusReader into vector variables in the grid.)
	///
	/// These methods return names of the original variables, the names
	/// of the grid variables, a list of the number of components in
	/// each grid variable, and a list of the index into the list of
	/// original variable names where the original name of the first
	/// component of a grid variable may be found.  The names of subsequent
	/// components would immediately follow the name of the first
	/// component.
	/// </summary>
	public int GetOriginalNumberOfElementVariables()
	{
		return vtkModelMetadata_GetOriginalNumberOfElementVariables_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetOriginalNumberOfNodeVariables_52(HandleRef pThis);

	/// <summary>
	/// The ModelMetadata object may contain these lists:
	/// o  the variables in the original data file
	/// o  the variables created in the u grid from those original variables
	/// o  a mapping from the grid variable names to the original names
	/// o  a list of the number of components each grid variable has
	///
	/// (Example: Variables in Exodus II files are all scalars.  Some are
	/// combined by the ExodusReader into vector variables in the grid.)
	///
	/// These methods return names of the original variables, the names
	/// of the grid variables, a list of the number of components in
	/// each grid variable, and a list of the index into the list of
	/// original variable names where the original name of the first
	/// component of a grid variable may be found.  The names of subsequent
	/// components would immediately follow the name of the first
	/// component.
	/// </summary>
	public int GetOriginalNumberOfNodeVariables()
	{
		return vtkModelMetadata_GetOriginalNumberOfNodeVariables_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetDistributionFactorIndex_53(HandleRef pThis);

	/// <summary>
	/// Get a list of the index of the starting entry for each side set
	/// in the list of side set distribution factors.
	/// </summary>
	public IntPtr GetSideSetDistributionFactorIndex()
	{
		return vtkModelMetadata_GetSideSetDistributionFactorIndex_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetDistributionFactors_54(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of all the distribution factors.
	/// For every side set that has distribution factors, the number of
	/// factors per node was given in the SideSetNumberOfDistributionFactors
	/// array.  If this number for a given side set is N, then for that
	/// side set we have N floating point values for each node for each
	/// side in the side set.  If nodes are repeated in more than one
	/// side, we repeat the distribution factors.  So this list is in order
	/// by side set, by node.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetSideSetDistributionFactors()
	{
		return vtkModelMetadata_GetSideSetDistributionFactors_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetElementList_55(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the elements containing each
	/// side in each side set.  The list is organized by side set, and
	/// within side set by element.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetSideSetElementList()
	{
		return vtkModelMetadata_GetSideSetElementList_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetIds_56(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list giving the ID of each side set.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetSideSetIds()
	{
		return vtkModelMetadata_GetSideSetIds_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetListIndex_57(HandleRef pThis);

	/// <summary>
	/// Get a list of the index of the starting entry for each side set
	/// in the list of side set side IDs.
	/// </summary>
	public IntPtr GetSideSetListIndex()
	{
		return vtkModelMetadata_GetSideSetListIndex_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetNames_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set or get the number of side sets.  Set this value before
	/// setting any of the other side set arrays.
	/// </summary>
	public vtkStringArray GetSideSetNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModelMetadata_GetSideSetNames_58(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetNumDFPerSide_59(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the number of nodes in each
	/// side of each side set.  This list is organized by side set, and
	/// within side set by side.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetSideSetNumDFPerSide()
	{
		return vtkModelMetadata_GetSideSetNumDFPerSide_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetNumberOfDistributionFactors_60(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the number of distribution
	/// factors stored by each side set.   Each side set has either
	/// no distribution factors, or 1 per node in the side set.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetSideSetNumberOfDistributionFactors()
	{
		return vtkModelMetadata_GetSideSetNumberOfDistributionFactors_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetPropertyValue_61(HandleRef pThis);

	/// <summary>
	/// Set or get value for each variable for each side set.  List
	/// the integer values in order by variable and within variable
	/// by side set.
	/// </summary>
	public IntPtr GetSideSetPropertyValue()
	{
		return vtkModelMetadata_GetSideSetPropertyValue_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetSideList_62(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to the element side for each side in the side set.
	/// (See the manual for the convention for numbering sides in different
	/// types of cells.)  Side Ids are arranged by side set and within
	/// side set by side, and correspond to the SideSetElementList.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetSideSetSideList()
	{
		return vtkModelMetadata_GetSideSetSideList_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetSideSetSize_63(HandleRef pThis);

	/// <summary>
	/// Set or get a pointer to a list of the number of sides in each side set.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public IntPtr GetSideSetSize()
	{
		return vtkModelMetadata_GetSideSetSize_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetSizeBlockAttributeArray_64(HandleRef pThis);

	/// <summary>
	/// Get the length of the list of floating point block attributes.
	/// </summary>
	public int GetSizeBlockAttributeArray()
	{
		return vtkModelMetadata_GetSizeBlockAttributeArray_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetSumDistFactPerNodeSet_65(HandleRef pThis);

	/// <summary>
	/// Get the total number of distribution factors stored for all node sets
	/// </summary>
	public int GetSumDistFactPerNodeSet()
	{
		return vtkModelMetadata_GetSumDistFactPerNodeSet_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetSumDistFactPerSideSet_66(HandleRef pThis);

	/// <summary>
	/// Get the total number of distribution factors stored for all side sets
	/// </summary>
	public int GetSumDistFactPerSideSet()
	{
		return vtkModelMetadata_GetSumDistFactPerSideSet_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetSumElementsPerBlock_67(HandleRef pThis);

	/// <summary>
	/// Get the length of the list of elements in every block.
	/// </summary>
	public int GetSumElementsPerBlock()
	{
		return vtkModelMetadata_GetSumElementsPerBlock_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetSumNodesPerNodeSet_68(HandleRef pThis);

	/// <summary>
	/// Get the total number of nodes in all node sets
	/// </summary>
	public int GetSumNodesPerNodeSet()
	{
		return vtkModelMetadata_GetSumNodesPerNodeSet_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetSumSidesPerSideSet_69(HandleRef pThis);

	/// <summary>
	/// Get the total number of sides in all side sets
	/// </summary>
	public int GetSumSidesPerSideSet()
	{
		return vtkModelMetadata_GetSumSidesPerSideSet_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_GetTimeStepIndex_70(HandleRef pThis);

	/// <summary>
	/// Set the index of the time step represented by the results
	/// data in the file attached to this ModelMetadata object.  Time
	/// step indices start at 0 in this file, they start at 1 in
	/// an Exodus file.
	/// </summary>
	public int GetTimeStepIndex()
	{
		return vtkModelMetadata_GetTimeStepIndex_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetTimeStepValues_71(HandleRef pThis);

	/// <summary>
	/// Get the time step values
	/// </summary>
	public IntPtr GetTimeStepValues()
	{
		return vtkModelMetadata_GetTimeStepValues_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_GetTitle_72(HandleRef pThis);

	/// <summary>
	/// The title of the dataset.
	/// </summary>
	public string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkModelMetadata_GetTitle_72(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_IsA_73(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkModelMetadata_IsA_73(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_IsTypeOf_74(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkModelMetadata_IsTypeOf_74(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_NewInstance_76(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkModelMetadata NewInstance()
	{
		vtkModelMetadata result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModelMetadata_NewInstance_76(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_PrintGlobalInformation_77(HandleRef pThis);

	/// <summary>
	/// The global fields are those which pertain to the whole
	/// file.  Examples are the title, information lines,
	/// and list of block IDs.  This method prints out all the
	/// global information.
	/// </summary>
	public virtual void PrintGlobalInformation()
	{
		vtkModelMetadata_PrintGlobalInformation_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_PrintLocalInformation_78(HandleRef pThis);

	/// <summary>
	/// The local fields are those which depend on exactly which
	/// blocks, which time step, and which variables you read in
	/// from the file.  Examples are the number of cells in
	/// each block, and the list of nodes in a node set, or the
	/// value of the global variables at a time step.  If
	/// VERBOSE_TESTING is defined in your execution environment,
	/// this method will print more than mere counts, and actually
	/// print a few of the IDs, distribution factors and so on.  If
	/// VERY_VERBOSE_TESTING is defined, it will print out
	/// all ID lists, distribution factor lists, and so on.
	/// </summary>
	public virtual void PrintLocalInformation()
	{
		vtkModelMetadata_PrintLocalInformation_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_Reset_79(HandleRef pThis);

	/// <summary>
	/// Set the object back to it's initial state
	/// </summary>
	public void Reset()
	{
		vtkModelMetadata_Reset_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkModelMetadata_SafeDownCast_80(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkModelMetadata SafeDownCast(vtkObjectBase o)
	{
		vtkModelMetadata vtkModelMetadata2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkModelMetadata_SafeDownCast_80(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkModelMetadata2 = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkModelMetadata2.Register(null);
			}
		}
		return vtkModelMetadata2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetAllVariablesDefinedInAllBlocks_81(HandleRef pThis, int _arg);

	/// <summary>
	/// Instead of a truth table of all "1"s, you can set this
	/// instance variable to indicate that all variables are
	/// defined in all blocks.
	/// </summary>
	public virtual void SetAllVariablesDefinedInAllBlocks(int _arg)
	{
		vtkModelMetadata_SetAllVariablesDefinedInAllBlocks_81(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetBlockAttributes_82(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to a list of the attributes for all
	/// blocks.  The order of the list should be by block, by element
	/// within the block, by attribute.  Omit blocks that don't
	/// have element attributes.
	/// </summary>
	public void SetBlockAttributes(IntPtr arg0)
	{
		vtkModelMetadata_SetBlockAttributes_82(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetBlockElementIdList_83(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to a list global element IDs for the
	/// elements in each block.
	/// We use your pointers, and free the memory when the object is freed.
	/// </summary>
	public void SetBlockElementIdList(IntPtr arg0)
	{
		vtkModelMetadata_SetBlockElementIdList_83(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetBlockIds_84(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// An arbitrary integer ID for each block.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetBlockIds(IntPtr arg0)
	{
		vtkModelMetadata_SetBlockIds_84(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetBlockNodesPerElement_85(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to a list of the number of nodes in the
	/// elements of each block.
	/// We use your pointers, and free the memory when the object is freed.
	/// </summary>
	public void SetBlockNodesPerElement(IntPtr arg0)
	{
		vtkModelMetadata_SetBlockNodesPerElement_85(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_SetBlockNumberOfAttributesPerElement_86(HandleRef pThis, IntPtr natts);

	/// <summary>
	/// Set or get a pointer to a list of the number of attributes
	/// stored for the elements in each block.
	/// We use your pointers, and free the memory when the object is freed.
	/// </summary>
	public int SetBlockNumberOfAttributesPerElement(IntPtr natts)
	{
		return vtkModelMetadata_SetBlockNumberOfAttributesPerElement_86(GetCppThis(), natts);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_SetBlockNumberOfElements_87(HandleRef pThis, IntPtr nelts);

	/// <summary>
	/// Set or get a pointer to a list of the number of elements in
	/// each block.
	/// We use your pointers, and free the memory when the object is freed.
	/// </summary>
	public int SetBlockNumberOfElements(IntPtr nelts)
	{
		return vtkModelMetadata_SetBlockNumberOfElements_87(GetCppThis(), nelts);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetBlockPropertyValue_88(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get value for each variable for each block.  List
	/// the integer values in order by variable and within variable
	/// by block.
	/// </summary>
	public void SetBlockPropertyValue(IntPtr arg0)
	{
		vtkModelMetadata_SetBlockPropertyValue_88(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetElementVariableTruthTable_89(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// A truth table indicating which element variables are
	/// defined for which blocks. The variables are all the original
	/// element variables that were in the file.
	/// The table is by block ID and within block ID by variable.
	/// </summary>
	public void SetElementVariableTruthTable(IntPtr arg0)
	{
		vtkModelMetadata_SetElementVariableTruthTable_89(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetGlobalVariableValue_90(HandleRef pThis, IntPtr f);

	/// <summary>
	/// Set or get the values of the global variables at the current
	/// time step.
	/// </summary>
	public void SetGlobalVariableValue(IntPtr f)
	{
		vtkModelMetadata_SetGlobalVariableValue_90(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNodeSetDistributionFactors_91(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a list of the distribution factors for the node sets.
	/// The list is organized by node set, and within node set by node.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetNodeSetDistributionFactors(IntPtr arg0)
	{
		vtkModelMetadata_SetNodeSetDistributionFactors_91(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNodeSetIds_92(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get the list the IDs for each node set.
	/// Length of list is the number of node sets.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetNodeSetIds(IntPtr arg0)
	{
		vtkModelMetadata_SetNodeSetIds_92(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNodeSetNames_93(HandleRef pThis, HandleRef names);

	/// <summary>
	/// The number of node sets in the file.  Set this value before
	/// setting the various node set arrays.
	/// </summary>
	public void SetNodeSetNames(vtkStringArray names)
	{
		vtkModelMetadata_SetNodeSetNames_93(GetCppThis(), names?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNodeSetNodeIdList_94(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to a concatenated list of the
	/// IDs of all nodes in each node set.  First list all IDs in
	/// node set 0, then all IDs in node set 1, and so on.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetNodeSetNodeIdList(IntPtr arg0)
	{
		vtkModelMetadata_SetNodeSetNodeIdList_94(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNodeSetNumberOfDistributionFactors_95(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a list of the number of distribution factors stored
	/// by each node set.  This is either 0 or equal to the number of
	/// nodes in the node set.
	/// Length of list is number of node sets.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetNodeSetNumberOfDistributionFactors(IntPtr arg0)
	{
		vtkModelMetadata_SetNodeSetNumberOfDistributionFactors_95(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNodeSetPropertyValue_96(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get value for each variable for each node set.  List
	/// the integer values in order by variable and within variable
	/// by node set.
	/// </summary>
	public void SetNodeSetPropertyValue(IntPtr arg0)
	{
		vtkModelMetadata_SetNodeSetPropertyValue_96(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNodeSetSize_97(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to a list of the number of nodes in each node set.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetNodeSetSize(IntPtr arg0)
	{
		vtkModelMetadata_SetNodeSetSize_97(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNumberOfBlocks_98(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of blocks in the file.  Set this before setting
	/// any of the block arrays.
	/// </summary>
	public virtual void SetNumberOfBlocks(int _arg)
	{
		vtkModelMetadata_SetNumberOfBlocks_98(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNumberOfNodeSets_99(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of node sets in the file.  Set this value before
	/// setting the various node set arrays.
	/// </summary>
	public virtual void SetNumberOfNodeSets(int _arg)
	{
		vtkModelMetadata_SetNumberOfNodeSets_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetNumberOfSideSets_100(HandleRef pThis, int _arg);

	/// <summary>
	/// Set or get the number of side sets.  Set this value before
	/// setting any of the other side set arrays.
	/// </summary>
	public virtual void SetNumberOfSideSets(int _arg)
	{
		vtkModelMetadata_SetNumberOfSideSets_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSideSetDistributionFactors_101(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to a list of all the distribution factors.
	/// For every side set that has distribution factors, the number of
	/// factors per node was given in the SideSetNumberOfDistributionFactors
	/// array.  If this number for a given side set is N, then for that
	/// side set we have N floating point values for each node for each
	/// side in the side set.  If nodes are repeated in more than one
	/// side, we repeat the distribution factors.  So this list is in order
	/// by side set, by node.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetSideSetDistributionFactors(IntPtr arg0)
	{
		vtkModelMetadata_SetSideSetDistributionFactors_101(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSideSetElementList_102(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to a list of the elements containing each
	/// side in each side set.  The list is organized by side set, and
	/// within side set by element.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetSideSetElementList(IntPtr arg0)
	{
		vtkModelMetadata_SetSideSetElementList_102(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSideSetIds_103(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to a list giving the ID of each side set.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetSideSetIds(IntPtr arg0)
	{
		vtkModelMetadata_SetSideSetIds_103(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSideSetNames_104(HandleRef pThis, HandleRef names);

	/// <summary>
	/// Set or get the number of side sets.  Set this value before
	/// setting any of the other side set arrays.
	/// </summary>
	public void SetSideSetNames(vtkStringArray names)
	{
		vtkModelMetadata_SetSideSetNames_104(GetCppThis(), names?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSideSetNumDFPerSide_105(HandleRef pThis, IntPtr numNodes);

	/// <summary>
	/// Set or get a pointer to a list of the number of nodes in each
	/// side of each side set.  This list is organized by side set, and
	/// within side set by side.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetSideSetNumDFPerSide(IntPtr numNodes)
	{
		vtkModelMetadata_SetSideSetNumDFPerSide_105(GetCppThis(), numNodes);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_SetSideSetNumberOfDistributionFactors_106(HandleRef pThis, IntPtr df);

	/// <summary>
	/// Set or get a pointer to a list of the number of distribution
	/// factors stored by each side set.   Each side set has either
	/// no distribution factors, or 1 per node in the side set.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public int SetSideSetNumberOfDistributionFactors(IntPtr df)
	{
		return vtkModelMetadata_SetSideSetNumberOfDistributionFactors_106(GetCppThis(), df);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSideSetPropertyValue_107(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get value for each variable for each side set.  List
	/// the integer values in order by variable and within variable
	/// by side set.
	/// </summary>
	public void SetSideSetPropertyValue(IntPtr arg0)
	{
		vtkModelMetadata_SetSideSetPropertyValue_107(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSideSetSideList_108(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set or get a pointer to the element side for each side in the side set.
	/// (See the manual for the convention for numbering sides in different
	/// types of cells.)  Side Ids are arranged by side set and within
	/// side set by side, and correspond to the SideSetElementList.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public void SetSideSetSideList(IntPtr arg0)
	{
		vtkModelMetadata_SetSideSetSideList_108(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkModelMetadata_SetSideSetSize_109(HandleRef pThis, IntPtr sizes);

	/// <summary>
	/// Set or get a pointer to a list of the number of sides in each side set.
	/// We use your pointer, and free the memory when the object is freed.
	/// </summary>
	public int SetSideSetSize(IntPtr sizes)
	{
		return vtkModelMetadata_SetSideSetSize_109(GetCppThis(), sizes);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSumNodesPerNodeSet_110(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the total number of nodes in all node sets
	/// </summary>
	public virtual void SetSumNodesPerNodeSet(int _arg)
	{
		vtkModelMetadata_SetSumNodesPerNodeSet_110(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetSumSidesPerSideSet_111(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the total number of sides in all side sets
	/// </summary>
	public virtual void SetSumSidesPerSideSet(int _arg)
	{
		vtkModelMetadata_SetSumSidesPerSideSet_111(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetTimeStepIndex_112(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the index of the time step represented by the results
	/// data in the file attached to this ModelMetadata object.  Time
	/// step indices start at 0 in this file, they start at 1 in
	/// an Exodus file.
	/// </summary>
	public virtual void SetTimeStepIndex(int _arg)
	{
		vtkModelMetadata_SetTimeStepIndex_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetTimeSteps_113(HandleRef pThis, int numberOfTimeSteps, IntPtr timeStepValues);

	/// <summary>
	/// Set the total number of time steps in the file,
	/// and the value at each time step.  We use your time
	/// step value array and delete it when we're done.
	/// </summary>
	public void SetTimeSteps(int numberOfTimeSteps, IntPtr timeStepValues)
	{
		vtkModelMetadata_SetTimeSteps_113(GetCppThis(), numberOfTimeSteps, timeStepValues);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkModelMetadata_SetTitle_114(HandleRef pThis, string _arg);

	/// <summary>
	/// The title of the dataset.
	/// </summary>
	public virtual void SetTitle(string _arg)
	{
		vtkModelMetadata_SetTitle_114(GetCppThis(), _arg);
	}
}
