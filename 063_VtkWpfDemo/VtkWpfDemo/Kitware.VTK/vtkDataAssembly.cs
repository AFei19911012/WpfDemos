using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkDataAssembly
/// </summary>
/// <remarks>
///  hierarchical representation to use with
/// vtkPartitionedDataSetCollection
///
/// vtkDataAssembly is a mechanism to represent hierarchical organization of
/// items (or vtkPartitionedDataSet instances) in a vtkPartitionedDataSetCollection.
/// vtkPartitionedDataSetCollection is similar to a vtkMultiBlockDataSet since it
/// provides a means for putting together multiple non-composite datasets.
/// However, vtkPartitionedDataSetCollection itself doesn't provide any mechanism
/// to define relationships between items in the collections. That is done using
/// vtkDataAssembly.
///
/// @section Overview Overview
///
/// At its core, vtkDataAssembly is simply a tree of nodes starting
/// with the root node. Each node has a unique id and a string name (names need not
/// be unique). On initialization with `vtkDataAssembly::Initialize`, an empty tree
/// with a root node is created. The root node's id and name can be obtained
/// using `vtkDataAssembly::GetRootNode` and `vtkDataAssembly::GetRootNodeName`.
/// The root node's id is fixed (vtkDataAssembly::GetRootNode), however the name
/// can be changed using `vtkDataAssembly::SetRootNodeName`.
///
/// Child nodes can be added using `vtkDataAssembly::AddNode` or
/// `vtkDataAssembly::AddNodes`, each of which returns the ids for every child
/// node added. A non-root node can be removed using `vtkDataAssembly::RemoveNode`.
///
/// Each node in the tree (including the root node) can have associated dataset
/// indices. For a vtkDataAssembly associated with a
/// vtkPartitionedDataSetCollection, these indices refer to the item index, or
/// partitioned-dataset-index for items in the collection. Dataset indices can be
/// specified using `vtkDataAssembly::AddDataSetIndex`,
/// `vtkDataAssembly::AddDataSetIndices` and removed using `vtkDataAssembly::RemoveDataSetIndex`,
/// `vtkDataAssembly::RemoveAllDataSetIndices`.
/// `vtkDataAssembly::GetDataSetIndices` provides a mechanism to get the
/// database indices associated with a node, and optionally, the entire subtree
/// rooted at the chosen node.
///
/// @section Searching Searching
///
/// Each node in the vtkDataAssembly is assigned a unique id.
/// `vtkDataAssembly::FindFirstNodeWithName` and
/// `vtkDataAssembly::FindNodesWithName` can be used to get the id(s) for
/// node(s) with given name.
///
/// `vtkDataAssembly::SelectNodes` provides a
/// more flexible mechanism to find nodes using name-based queries. Section
/// @ref DataAssemblyPathQueries covers supported queries.
///
/// @section Traversal Traversal
///
/// `vtkDataAssemblyVisitor` defines a visitor API. An instance of a concretized
/// `vtkDataAssemblyVisitor` subclass can be passed to `vtkDataAssembly::Visit`
/// to traverse the data-assembly hierarchy either in depth-first or
/// breadth-first order.
///
/// @section DataAssemblyPathQueries Supported Path Queries
///
/// `vtkDataAssembly::SelectNodes` can be used find nodes that match the
/// specified query (or queries) using XPath 1.0 syntax.
///
/// For example:
///
/// * '/' is used as the path separator. If a node name has a `/` it must be
/// escaped using `\\` in the query. Note, escaping is not necessary when using
/// `SetNodeName`/`GetNodeName`.
///
/// * '/' selects the root node.
///
/// * '/nodename' selects all child nodes of the root with the name 'nodename'.
///
/// * '//nodename' selects all nodes with 'nodename' that are descendants of the
///   root; thus, this this will traverse the entire tree.
///
/// * '/nodename/' selects all child nodes of all nodes named 'nodename' under
///   the root; thus, ending a query with '/' selects the children of the found
///   nodes rather than the nodes themselves.
///
/// * '/nodename1/nodename2' selects all nodes named 'nodename2' which are
///   children of nodes with name 'nodename1' that are themselves children of
///   the root node.
///
/// * '//nodename1/nodename2' finds all nodes in the tree named 'nodename1' and
///   then selects all children of these found nodes that are named 'nodename2'.
///
/// @section Applications Applications
///
/// The separation of dataset storage (vtkPartitionedDataSetCollection) and
/// organization (vtkDataAssembly) enables development of algorithms that can
/// expose APIs that are not tightly coupled to dataset storage. Together,
/// vtkPartitionedDataSetCollection and vtkDataAssembly can be thought of as a
/// different way of organizing data that was previously organized as a
/// vtkMultiBlockDataSet. The advantage of the this newer approach is that
/// filters can support specifying parameters using paths or path queries
/// rather than composite indices. The composite indices suffered from the fact
/// that they made no sense except for the specific vtkMultiBlockDataSet they
/// were applied too. Thus, if the filters input was changed, the composite ids
/// rarely made any sense and needed to be updated. Paths and path queries,
/// however, do not suffer from this issue.
///
/// </remarks>
public class vtkDataAssembly : vtkObject
{
	/// <summary>
	/// Clears all dataset indices from the node.
	///
	/// If `traverse_subtree` is true (default), recursively removes all
	/// dataset indices from all the child nodes.
	///
	/// @returns true on success, else returns false.
	/// </summary>
	public enum TraversalOrder
	{
		/// <summary>enum member</summary>
		BreadthFirst = 1,
		/// <summary>enum member</summary>
		DepthFirst = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataAssembly";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataAssembly()
	{
		MRClassNameKey = "class vtkDataAssembly";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataAssembly"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataAssembly New()
	{
		vtkDataAssembly result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataAssembly()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkDataAssembly_AddDataSetIndex_01(HandleRef pThis, int id, uint dataset_index);

	/// <summary>
	/// Add a dataset index to a node. The node id can refer to any
	/// valid node in the assembly, including the root.
	///
	/// While the same dataset can be added multiple times in the assembly,
	/// it cannot be added multiple times to the same node. Additional adds
	/// will fail.
	///
	/// @returns true if addition succeeded else false.
	/// </summary>
	public bool AddDataSetIndex(int id, uint dataset_index)
	{
		return (vtkDataAssembly_AddDataSetIndex_01(GetCppThis(), id, dataset_index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_AddDataSetIndexRange_02(HandleRef pThis, int id, uint index_start, int count);

	/// <summary>
	/// Same as `AddDataSetIndices` except this supports adding a contiguous range of dataset
	/// indices in one go.
	///
	/// @ returns true if any dataset index was successfully added.
	/// </summary>
	public bool AddDataSetIndexRange(int id, uint index_start, int count)
	{
		return (vtkDataAssembly_AddDataSetIndexRange_02(GetCppThis(), id, index_start, count) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_AddNode_03(HandleRef pThis, string name, int parent);

	/// <summary>
	/// Adds a node to the assembly with the given name and returns its id. `parent` is the id for
	/// the parent node which defaults to the root node id (i.e. `GetRootNode`).
	///
	/// If `parent` is invalid, the add will fail.
	///
	/// @returns id of the newly added node on success, else -1.
	/// </summary>
	public int AddNode(string name, int parent)
	{
		return vtkDataAssembly_AddNode_03(GetCppThis(), name, parent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_AddSubtree_04(HandleRef pThis, int parent, HandleRef other, int otherParent);

	/// <summary>
	/// Add a subtree by copy the nodes from another tree starting with the
	/// specified parent index.
	/// </summary>
	public int AddSubtree(int parent, vtkDataAssembly other, int otherParent)
	{
		return vtkDataAssembly_AddSubtree_04(GetCppThis(), parent, other?.GetCppThis() ?? default(HandleRef), otherParent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_DeepCopy_05(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Deep copy the `other`.
	/// </summary>
	public void DeepCopy(vtkDataAssembly other)
	{
		vtkDataAssembly_DeepCopy_05(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_FindFirstNodeWithName_06(HandleRef pThis, string name, int traversal_order);

	/// <summary>
	/// Finds first node that is encountered in a breadth first traversal
	/// of the assembly with the given name.
	///
	/// @returns the if of the node if found, else -1.
	/// </summary>
	public int FindFirstNodeWithName(string name, int traversal_order)
	{
		return vtkDataAssembly_FindFirstNodeWithName_06(GetCppThis(), name, traversal_order);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_GetAttribute_07(HandleRef pThis, int id, string name, ref int value);

	/// <summary>
	/// Get an attribute value. Returns true if a value was provided else false.
	/// </summary>
	public bool GetAttribute(int id, string name, ref int value)
	{
		return (vtkDataAssembly_GetAttribute_07(GetCppThis(), id, name, ref value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_GetAttribute_08(HandleRef pThis, int id, string name, ref uint value);

	/// <summary>
	/// Get an attribute value. Returns true if a value was provided else false.
	/// </summary>
	public bool GetAttribute(int id, string name, ref uint value)
	{
		return (vtkDataAssembly_GetAttribute_08(GetCppThis(), id, name, ref value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_GetAttribute_09(HandleRef pThis, int id, string name, ref long value);

	/// <summary>
	/// Get an attribute value. Returns true if a value was provided else false.
	/// </summary>
	public bool GetAttribute(int id, string name, ref long value)
	{
		return (vtkDataAssembly_GetAttribute_09(GetCppThis(), id, name, ref value) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssembly_GetAttributeOrDefault_10(HandleRef pThis, int id, string name, string default_value);

	/// <summary>
	/// Get an attribute value. Returns the value associated with the node or the
	/// provided default value.
	/// </summary>
	public string GetAttributeOrDefault(int id, string name, string default_value)
	{
		return Marshal.PtrToStringAnsi(vtkDataAssembly_GetAttributeOrDefault_10(GetCppThis(), id, name, default_value));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_GetAttributeOrDefault_11(HandleRef pThis, int id, string name, int default_value);

	/// <summary>
	/// Get an attribute value. Returns the value associated with the node or the
	/// provided default value.
	/// </summary>
	public int GetAttributeOrDefault(int id, string name, int default_value)
	{
		return vtkDataAssembly_GetAttributeOrDefault_11(GetCppThis(), id, name, default_value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDataAssembly_GetAttributeOrDefault_12(HandleRef pThis, int id, string name, uint default_value);

	/// <summary>
	/// Get an attribute value. Returns the value associated with the node or the
	/// provided default value.
	/// </summary>
	public uint GetAttributeOrDefault(int id, string name, uint default_value)
	{
		return vtkDataAssembly_GetAttributeOrDefault_12(GetCppThis(), id, name, default_value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataAssembly_GetAttributeOrDefault_13(HandleRef pThis, int id, string name, long default_value);

	/// <summary>
	/// Get an attribute value. Returns the value associated with the node or the
	/// provided default value.
	/// </summary>
	public long GetAttributeOrDefault(int id, string name, long default_value)
	{
		return vtkDataAssembly_GetAttributeOrDefault_13(GetCppThis(), id, name, default_value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_GetChild_14(HandleRef pThis, int parent, int index);

	/// <summary>
	/// Returns the id for a child not at the given index, if valid, otherwise -1.
	/// </summary>
	public int GetChild(int parent, int index)
	{
		return vtkDataAssembly_GetChild_14(GetCppThis(), parent, index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_GetChildIndex_15(HandleRef pThis, int parent, int child);

	/// <summary>
	/// Returns the index for a child under a given. -1 if invalid.
	/// </summary>
	public int GetChildIndex(int parent, int child)
	{
		return vtkDataAssembly_GetChildIndex_15(GetCppThis(), parent, child);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_GetFirstNodeByPath_16(HandleRef pThis, string path);

	/// <summary>
	/// Return a node id given the path. Returns `-1` if path is not valid.
	/// </summary>
	public int GetFirstNodeByPath(string path)
	{
		return vtkDataAssembly_GetFirstNodeByPath_16(GetCppThis(), path);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssembly_GetNodeName_17(HandleRef pThis, int id);

	/// <summary>
	/// Get/Set a node's name. If node id is invalid, `SetNodeName` will raise an
	/// error; `GetNodeName` will also raise an error and return nullptr.
	///
	/// `SetNodeName` will raise an error if the name is not valid. Name cannot be
	/// empty or nullptr.
	/// </summary>
	public string GetNodeName(int id)
	{
		return Marshal.PtrToStringAnsi(vtkDataAssembly_GetNodeName_17(GetCppThis(), id));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDataAssembly_GetNodePath_18(HandleRef pThis, int id);

	/// <summary>
	/// Returns the path for a node.
	/// </summary>
	public string GetNodePath(int id)
	{
		return vtkDataAssembly_GetNodePath_18(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_GetNumberOfChildren_19(HandleRef pThis, int parent);

	/// <summary>
	/// Returns the number of child nodes.
	///
	/// @returns the number of child nodes for the parent node or 0 if the parent
	/// is invalid.
	/// </summary>
	public int GetNumberOfChildren(int parent)
	{
		return vtkDataAssembly_GetNumberOfChildren_19(GetCppThis(), parent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataAssembly_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataAssembly_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataAssembly_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataAssembly_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_GetParent_22(HandleRef pThis, int id);

	/// <summary>
	/// Returns the id for the parent node, if any.
	/// Returns -1 if the node is invalid or has no parent (i.e. is the root node).
	/// </summary>
	public int GetParent(int id)
	{
		return vtkDataAssembly_GetParent_22(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_GetRootNode_23();

	/// <summary>
	/// Returns the ID for the root node.
	/// This always returns 0.
	/// </summary>
	public static int GetRootNode()
	{
		return vtkDataAssembly_GetRootNode_23();
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssembly_GetRootNodeName_24(HandleRef pThis);

	/// <summary>
	/// Get/Set root node name. Defaults to DataAssembly.
	/// </summary>
	public string GetRootNodeName()
	{
		return Marshal.PtrToStringAnsi(vtkDataAssembly_GetRootNodeName_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_HasAttribute_25(HandleRef pThis, int id, string name);

	/// <summary>
	/// Returns true if attribute with the given name is present
	/// on the chosen node.
	/// </summary>
	public bool HasAttribute(int id, string name)
	{
		return (vtkDataAssembly_HasAttribute_25(GetCppThis(), id, name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_Initialize_26(HandleRef pThis);

	/// <summary>
	/// Initializes the data-assembly. When a new vtkDataAssembly instance is
	/// created, it is in initialized form and it is not required to call this
	/// method to initialize it.
	/// </summary>
	public void Initialize()
	{
		vtkDataAssembly_Initialize_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_InitializeFromXML_27(HandleRef pThis, string xmlcontents);

	/// <summary>
	/// Initializes a data-assembly using an XML representation of the assembly.
	/// Returns true if the initialization was successful, otherwise the assembly
	/// is set a clean state and returns false.
	/// </summary>
	public bool InitializeFromXML(string xmlcontents)
	{
		return (vtkDataAssembly_InitializeFromXML_27(GetCppThis(), xmlcontents) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataAssembly_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_IsNodeNameReserved_29(string name);

	/// <summary>
	/// Returns true for node names that are reserved.
	/// </summary>
	public static bool IsNodeNameReserved(string name)
	{
		return (vtkDataAssembly_IsNodeNameReserved_29(name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_IsNodeNameValid_30(string name);

	/// <summary>
	/// Validates a node name.
	/// </summary>
	public static bool IsNodeNameValid(string name)
	{
		return (vtkDataAssembly_IsNodeNameValid_30(name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataAssembly_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataAssembly_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDataAssembly_MakeValidNodeName_32(string name);

	/// <summary>
	/// Converts any string to a string that is a valid node name.
	/// This is done by simply discarding any non-supported character.
	/// Additionally, if the first character is not a "_" or an alphabet, then
	/// the "_" is prepended.
	/// </summary>
	public static string MakeValidNodeName(string name)
	{
		return vtkDataAssembly_MakeValidNodeName_32(name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssembly_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataAssembly NewInstance()
	{
		vtkDataAssembly result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataAssembly_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_RemoveAllDataSetIndices_35(HandleRef pThis, int id, byte traverse_subtree);

	/// <summary>
	/// Clears all dataset indices from the node.
	///
	/// If `traverse_subtree` is true (default), recursively removes all
	/// dataset indices from all the child nodes.
	///
	/// @returns true on success, else returns false.
	/// </summary>
	public bool RemoveAllDataSetIndices(int id, bool traverse_subtree)
	{
		return (vtkDataAssembly_RemoveAllDataSetIndices_35(GetCppThis(), id, (byte)(traverse_subtree ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_RemoveDataSetIndex_36(HandleRef pThis, int id, uint dataset_index);

	/// <summary>
	/// Removes a dataset index from a node.
	///
	/// @returns true if the removal was successful, else returns false.
	/// </summary>
	public bool RemoveDataSetIndex(int id, uint dataset_index)
	{
		return (vtkDataAssembly_RemoveDataSetIndex_36(GetCppThis(), id, dataset_index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataAssembly_RemoveNode_37(HandleRef pThis, int id);

	/// <summary>
	/// Removes a node from the assembly. The node identified by the id and all its
	/// children are removed.
	///
	/// Root node cannot be removed.
	///
	/// @returns true if removal was successful, false if the id is invalid or root
	/// node id.
	/// </summary>
	public bool RemoveNode(int id)
	{
		return (vtkDataAssembly_RemoveNode_37(GetCppThis(), id) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataAssembly_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataAssembly SafeDownCast(vtkObjectBase o)
	{
		vtkDataAssembly vtkDataAssembly2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataAssembly_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataAssembly2 = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataAssembly2.Register(null);
			}
		}
		return vtkDataAssembly2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_SetAttribute_39(HandleRef pThis, int id, string name, string value);

	/// <summary>
	/// Set an attribute. Will replace an existing attribute with the same name if
	/// present.
	/// </summary>
	public void SetAttribute(int id, string name, string value)
	{
		vtkDataAssembly_SetAttribute_39(GetCppThis(), id, name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_SetAttribute_40(HandleRef pThis, int id, string name, int value);

	/// <summary>
	/// Set an attribute. Will replace an existing attribute with the same name if
	/// present.
	/// </summary>
	public void SetAttribute(int id, string name, int value)
	{
		vtkDataAssembly_SetAttribute_40(GetCppThis(), id, name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_SetAttribute_41(HandleRef pThis, int id, string name, uint value);

	/// <summary>
	/// Set an attribute. Will replace an existing attribute with the same name if
	/// present.
	/// </summary>
	public void SetAttribute(int id, string name, uint value)
	{
		vtkDataAssembly_SetAttribute_41(GetCppThis(), id, name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_SetAttribute_42(HandleRef pThis, int id, string name, long value);

	/// <summary>
	/// Set an attribute. Will replace an existing attribute with the same name if
	/// present.
	/// </summary>
	public void SetAttribute(int id, string name, long value)
	{
		vtkDataAssembly_SetAttribute_42(GetCppThis(), id, name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_SetNodeName_43(HandleRef pThis, int id, string name);

	/// <summary>
	/// Get/Set a node's name. If node id is invalid, `SetNodeName` will raise an
	/// error; `GetNodeName` will also raise an error and return nullptr.
	///
	/// `SetNodeName` will raise an error if the name is not valid. Name cannot be
	/// empty or nullptr.
	/// </summary>
	public void SetNodeName(int id, string name)
	{
		vtkDataAssembly_SetNodeName_43(GetCppThis(), id, name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_SetRootNodeName_44(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set root node name. Defaults to DataAssembly.
	/// </summary>
	public void SetRootNodeName(string name)
	{
		vtkDataAssembly_SetRootNodeName_44(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_Visit_45(HandleRef pThis, HandleRef visitor, int traversal_order);

	/// <summary>
	/// Visit each node in the assembly for processing. The traversal order can be
	/// specified using `traversal_order` which defaults to depth-first.
	/// </summary>
	public void Visit(vtkDataAssemblyVisitor visitor, int traversal_order)
	{
		vtkDataAssembly_Visit_45(GetCppThis(), visitor?.GetCppThis() ?? default(HandleRef), traversal_order);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataAssembly_Visit_46(HandleRef pThis, int id, HandleRef visitor, int traversal_order);

	/// <summary>
	/// Visit each node in the assembly for processing. The traversal order can be
	/// specified using `traversal_order` which defaults to depth-first.
	/// </summary>
	public void Visit(int id, vtkDataAssemblyVisitor visitor, int traversal_order)
	{
		vtkDataAssembly_Visit_46(GetCppThis(), id, visitor?.GetCppThis() ?? default(HandleRef), traversal_order);
	}
}
