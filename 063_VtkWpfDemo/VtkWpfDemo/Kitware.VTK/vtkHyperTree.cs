using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHyperTree
/// </summary>
/// <remarks>
///    A data object structured as a tree.
///
/// An hypertree grid is a dataobject containing a rectilinear grid of
/// elements that can be either null or a hypertree.
/// An hypertree is a dataobject describing a decomposition tree.
/// A VERTICE is an element of this tree.
/// A NODE, also called COARSE cell, is a specific vertice which is
/// refined and than has either exactly f^d children, where f in {2,3}
/// is the branching factor, the same value for all trees in this
/// hypertree grid, and d in {1,2,3} is the spatial dimension. It is
/// called coarse because there are smaller child cells.
/// A LEAF, also called FINE cell, is a vertice without children, not
/// refined. It is called fine because in the same space there are no
/// finer cells.
/// In a tree, we can find coarse cells smaller than fine cell but not
/// in the same space.
///
/// Such trees have particular names for f=2:
/// - bintree (d=1),
/// - quadtree (d=2),
/// - octree (d=3).
///
/// The original octree class name came from the following paper:
/// \verbatim
/// @ARTICLE{yau-srihari-1983,
///  author={Mann-May Yau and Sargur N. Srihari},
///  title={A Hierarchical Data Structure for Multidimensional Digital Images},
///  journal={Communications of the ACM},
///  month={July},
///  year={1983},
///  volume={26},
///  number={7},
///  pages={504--515}
///  }
/// \endverbatim
///
/// Attributes are associated with (all) cells, not with points. The
/// attributes that are associated with coarses, it's used for LoD
/// (Level-of-Detail). The attributes on coarse cells can be given by the
/// code or/and computed by the use of a specific filter exploiting the
/// values from its children (which can be leaves or not).
///
/// The geometry is implicitly given by the size of the root node on each
/// axis and position of the origin. In fact, in 3D, the geometry is then
/// not limited to a cube but can have a rectangular shape.
///
/// By construction, an hypertree is efficient in memory usage. The LoD
/// feature allows for quick culling of part of the dataobject.
///
/// This is an abstract class used as a superclass by a custom templated
/// compact class. Other versions of this code could be made available
/// to meet other needs without questioning cursors and filters.
/// All methods are pure virtual. This is done to hide templates.
///
/// @par Case octree with f=2, d=3:
/// For each node (coarse cell), 8 children are encoded in a child index
/// (from 0 to 7) in the following orientation described in hypertree grid.
/// It is easy to access each child as a cell of a grid.
/// Note also that the binary representation is relevant, each bit codes
/// a side:
/// bit 0 encodes -x side (0) or +x side (1)
/// bit 1 encodes -y side (0) or +y side (1)
/// bit 2 encodes -z side (0) or +z side (1)
/// -z side is first, in counter-clockwise order:
///  0: -y -x sides
///  1: -y +x sides
///  2: +y -x sides
///  3: +y +x sides
/// +z side is last, in counter-clockwise order:
///  4: -y -x sides
///  5: -y +x sides
///  6: +y -x sides
///  7: +y +x sides
/// \verbatim
///              +y
/// +-+-+        ^
/// |2|3|        |
/// +-+-+  O +z  +-&gt; +x
/// |0|1|
/// +-+-+
///              +y
/// +-+-+        ^
/// |6|7|        |
/// +-+-+  1 +z  +-&gt; +x
/// |4|5|
/// +-+-+
/// \endverbatim
///
/// @par Case quadtree with f=2, d=2:
/// Just use 2 bits.
/// \verbatim
///              +y
/// +-+-+        ^
/// |2|3|        |
/// +-+-+        +-&gt; +x
/// |0|1|
/// +-+-+
/// \endverbatim
///
/// @par Case bintree with f=2, d=1:
/// Just use 1 bits.
/// \verbatim
///             O+-&gt; +x
/// \endverbatim
///
/// It's more difficult with f=3.
///
/// @par Thanks:
/// This class was written by Philippe Pebay, Joachim Pouderoux, and
/// Charles Law, Kitware 2013
/// This class was modified by Guenole Harel and Jacques-Bernard Lekien 2014
/// This class was modified by Philippe Pebay, 2016
/// Among others, this class was simplified, optimized (memory), documented and
/// completed for to improve IO XML by Jacques-Bernard Lekien 2018-19
/// This work was supported by Commissariat a l'Energie Atomique
/// CEA, DAM, DIF, F-91297 Arpajon, France.
/// </remarks>
public abstract class vtkHyperTree : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperTree()
	{
		MRClassNameKey = "class vtkHyperTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_BuildFromBreadthFirstOrderDescriptor_01(HandleRef pThis, HandleRef descriptor, long numberOfBits, long startIndex);

	/// <summary>
	/// This method builds the indexing of this tree given a breadth first order
	/// descriptor. This descriptor is the same bit array that would be created by
	/// `ComputeBreadthFirstOrderDescriptor`. The current tree is ready to use
	/// after calling this method.
	///
	/// @param descriptor is a binary descriptor, in breadth first order, that describes
	/// the tree topology. If vertex of index `id` in breadth first order has
	/// children, then the corresponding value in `descriptor` is one. Otherwise, it
	/// is set to zero. Remember that arrays are appended, meaning that the index
	/// in `descriptor` corresponding to `id` in the current tree
	/// would be the size of `descriptor`
	/// before calling this method, plus `id`.
	///
	/// @param numberOfBits: Number of bits to be read in the descriptor to build
	/// the tree. Remember that the last depth of the tree is not encoded in the
	/// descriptor, as we know that they are full of zeros (because leaves have no children).
	///
	/// @param startIndex: Input descriptor is being read starting at this index.
	/// </summary>
	public virtual void BuildFromBreadthFirstOrderDescriptor(vtkBitArray descriptor, long numberOfBits, long startIndex)
	{
		vtkHyperTree_BuildFromBreadthFirstOrderDescriptor_01(GetCppThis(), descriptor?.GetCppThis() ?? default(HandleRef), numberOfBits, startIndex);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_ComputeBreadthFirstOrderDescriptor_02(HandleRef pThis, HandleRef inputMask, HandleRef numberOfVerticesPerDepth, HandleRef descriptor, HandleRef breadthFirstIdMap);

	/// <summary>
	/// This method computes the breadth first order descriptor of the current
	/// tree. It takes as input the input mask `inputMask` which should be provided
	/// by the `vtkHyperTreeGrid` in which this `vtkHyperTree` lies. In addition to
	/// computing the descriptor, it computes the mapping between the current
	/// memory layout of this tree with the breadth first order version of it.
	///
	/// Outputs are `numberOfVerticesPerDepth`, `descriptor` and
	/// `breadthFirstIdMap`. Each of those arrays are appended with new data, so
	/// one can create one unique big array for an entire `vtkHyperTreeGrid`
	/// concatenating breadth first order description and mapping of concatenated
	/// trees.
	///
	/// @param inputMask the mask provided by `vtkHyperTreeGrid`.
	///
	/// @param numberOfVerticesPerDepth is self explanatory: from depth 0 to the maximum
	/// depth of the tree, it stores the number of vertices at each depth. If the
	/// input tree has masked subtrees such that getting rid of those subtrees
	/// reduces the depth, then `numberOfVerticesPerDepth` will take this smaller
	/// depth into account rather than adding zeros. In other words,
	/// `numberOfVerticesPerDepth` cannot have zero values.
	///
	/// @param descriptor is a binary descriptor, in breadth first order, that describes
	/// the tree topology. If vertex of index `id` in breadth first order has
	/// children, then the corresponding value in `descriptor` is one. Otherwise, it
	/// is set to zero. Remember that arrays are appended, meaning that the index
	/// in `descriptor` corresponding to `id` in the current tree
	/// would be the size of `descriptor`
	/// before calling this method, plus `id`.
	///
	/// @param breadthFirstIdMap maps breadth first ordering to current indexing of the
	/// current tree. In other word, the value at appended position `id` in this
	/// array gives the corresponding index in the current tree.
	///
	/// @warning Masked subtrees of the input are ignored, so the topology of the
	/// output tree can differ from the input depending on that.
	/// </summary>
	public virtual void ComputeBreadthFirstOrderDescriptor(vtkBitArray inputMask, vtkTypeInt64Array numberOfVerticesPerDepth, vtkBitArray descriptor, vtkIdList breadthFirstIdMap)
	{
		vtkHyperTree_ComputeBreadthFirstOrderDescriptor_02(GetCppThis(), inputMask?.GetCppThis() ?? default(HandleRef), numberOfVerticesPerDepth?.GetCppThis() ?? default(HandleRef), descriptor?.GetCppThis() ?? default(HandleRef), breadthFirstIdMap?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_CopyStructure_03(HandleRef pThis, HandleRef ht);

	/// <summary>
	/// Copy the structure by sharing the decomposition description
	/// of the tree.
	/// \pre ht_exist: ht!=nullptr
	/// </summary>
	public void CopyStructure(vtkHyperTree ht)
	{
		vtkHyperTree_CopyStructure_03(GetCppThis(), ht?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTree_CreateInstance_04(byte branchFactor, byte dimension, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an instance of an implementation of a hypertree for
	/// given branch factor and dimension.
	/// Other versions of this code could be made available to meet
	/// other needs without questioning cursors and filters.
	/// Since an instance, an other instance can be creating by call
	/// the method Freeze (by default, nothing more, instance currently
	/// is returning).
	/// </summary>
	public static vtkHyperTree CreateInstance(byte branchFactor, byte dimension)
	{
		vtkHyperTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTree_CreateInstance_04(branchFactor, dimension, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTree_Freeze_05(HandleRef pThis, string mode, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a freeze instance (a priori compact but potentially
	/// unmodifiable).
	/// This method is calling by the Squeeze method of hypertree grid.
	/// The mode parameter will allow to propose different instances.
	/// Today, there is none, the freeze call does not do anything.
	/// </summary>
	public virtual vtkHyperTree Freeze(string mode)
	{
		vtkHyperTree vtkHyperTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTree_Freeze_05(GetCppThis(), mode, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTree2 = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTree2.Register(null);
			}
		}
		return vtkHyperTree2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTree_GetActualMemorySize_06(HandleRef pThis);

	/// <summary>
	/// Return memory used in kibibytes (1024 bytes).
	/// NB: Ignore the attribute array because its size is added by the data set.
	/// </summary>
	public uint GetActualMemorySize()
	{
		return vtkHyperTree_GetActualMemorySize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTree_GetActualMemorySizeBytes_07(HandleRef pThis);

	/// <summary>
	/// Return memory used in bytes.
	/// NB: Ignore the attribute array because its size is added by the data set.
	/// </summary>
	public virtual uint GetActualMemorySizeBytes()
	{
		return vtkHyperTree_GetActualMemorySizeBytes_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTree_GetBranchFactor_08(HandleRef pThis);

	/// <summary>
	/// Return the branch factor of the tree.
	/// </summary>
	public int GetBranchFactor()
	{
		return vtkHyperTree_GetBranchFactor_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTree_GetDimension_09(HandleRef pThis);

	/// <summary>
	/// Return the spatial dimension of the tree.
	/// </summary>
	public int GetDimension()
	{
		return vtkHyperTree_GetDimension_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetElderChildIndex_10(HandleRef pThis, uint index_parent);

	/// <summary>
	/// Return the elder child index, local index node of first child, of
	/// node, coarse cell, identified by index_parent.
	/// \pre not_valid_index_parent
	/// Public only for entry: vtkHyperTreeGridEntry,
	/// vtkHyperTreeGridGeometryEntry, vtkHyperTreeGridGeometryLevelEntry
	/// </summary>
	public virtual long GetElderChildIndex(uint index_parent)
	{
		return vtkHyperTree_GetElderChildIndex_10(GetCppThis(), index_parent);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTree_GetElderChildIndexArray_11(HandleRef pThis, ref ulong nbElements);

	/// <summary>
	/// Return the elder child index array, internals of the tree structure
	/// Should be used with great care, for consulting and not modifying.
	/// </summary>
	public virtual IntPtr GetElderChildIndexArray(ref ulong nbElements)
	{
		return vtkHyperTree_GetElderChildIndexArray_11(GetCppThis(), ref nbElements);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetGlobalIndexFromLocal_12(HandleRef pThis, long index);

	/// <summary>
	/// Get the global id of a local node identified by index.
	/// Use the explicit mapping function if available or the implicit
	/// mapping build with start global index.
	/// \pre not_valid_index
	/// \pre not_positive_start_index (case implicit global index mapping)
	/// \pre not_positive_global_index (case explicit global index mapping)
	/// </summary>
	public virtual long GetGlobalIndexFromLocal(long index)
	{
		return vtkHyperTree_GetGlobalIndexFromLocal_12(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetGlobalIndexStart_13(HandleRef pThis);

	/// <summary>
	/// Get the start global index for the current tree for implicit global
	/// index mapping.
	/// </summary>
	public long GetGlobalIndexStart()
	{
		return vtkHyperTree_GetGlobalIndexStart_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetGlobalNodeIndexMax_14(HandleRef pThis);

	/// <summary>
	/// Return the maximum value reached by global index mapping
	/// (implicit or explicit).
	/// </summary>
	public virtual long GetGlobalNodeIndexMax()
	{
		return vtkHyperTree_GetGlobalNodeIndexMax_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetNumberOfChildren_15(HandleRef pThis);

	/// <summary>
	/// Return the number of children per node of the tree.
	/// This value is branchfactoring scale spatial dimension (f^d).
	/// </summary>
	public long GetNumberOfChildren()
	{
		return vtkHyperTree_GetNumberOfChildren_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperTree_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperTree_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetNumberOfLeaves_18(HandleRef pThis);

	/// <summary>
	/// Return the number of leaf (fine) in the tree.
	/// </summary>
	public long GetNumberOfLeaves()
	{
		return vtkHyperTree_GetNumberOfLeaves_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHyperTree_GetNumberOfLevels_19(HandleRef pThis);

	/// <summary>
	/// Return the number of levels.
	/// </summary>
	public uint GetNumberOfLevels()
	{
		return vtkHyperTree_GetNumberOfLevels_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetNumberOfNodes_20(HandleRef pThis);

	/// <summary>
	/// Return the number of nodes (coarse) in the tree.
	/// </summary>
	public long GetNumberOfNodes()
	{
		return vtkHyperTree_GetNumberOfNodes_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetNumberOfVertices_21(HandleRef pThis);

	/// <summary>
	/// Return the number of all vertices (coarse and fine) in the tree.
	/// </summary>
	public long GetNumberOfVertices()
	{
		return vtkHyperTree_GetNumberOfVertices_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_GetScale_22(HandleRef pThis, IntPtr s);

	/// <summary>
	/// Set/Get scale of the tree in each direction for the ground
	/// level (0).
	/// </summary>
	public void GetScale(IntPtr s)
	{
		vtkHyperTree_GetScale_22(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperTree_GetScale_23(HandleRef pThis, uint d);

	/// <summary>
	/// Set/Get scale of the tree in each direction for the ground
	/// level (0).
	/// </summary>
	public double GetScale(uint d)
	{
		return vtkHyperTree_GetScale_23(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperTree_GetTreeIndex_24(HandleRef pThis);

	/// <summary>
	/// Set/Get tree index in hypertree grid.
	/// Services for internal use between hypertree grid and hypertree.
	/// </summary>
	public long GetTreeIndex()
	{
		return vtkHyperTree_GetTreeIndex_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTree_HasScales_25(HandleRef pThis);

	/// <summary>
	/// Return the existence scales.
	/// </summary>
	public bool HasScales()
	{
		return (vtkHyperTree_HasScales_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_Initialize_26(HandleRef pThis, byte branchFactor, byte dimension, byte numberOfChildren);

	/// <summary>
	/// Restore the initial state: only one vertice is then a leaf:
	/// the root cell for the hypertree.
	/// @param branchFactor
	/// @param dimension
	/// @param numberOfChildren
	/// </summary>
	public void Initialize(byte branchFactor, byte dimension, byte numberOfChildren)
	{
		vtkHyperTree_Initialize_26(GetCppThis(), branchFactor, dimension, numberOfChildren);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_InitializeForReader_27(HandleRef pThis, long numberOfLevels, long nbVertices, long nbVerticesOfLastLevel, HandleRef isParent, HandleRef isMasked, HandleRef outIsMasked);

	/// <summary>
	/// Restore a state from read data, without using a cursor
	/// Call after create hypertree with initialize.
	///
	/// @param numberOfLevels: the maximum number of levels.
	/// @param nbVertices: the number of vertices of the future tree
	/// (coarse and leaves), fixed either the information loading
	/// (for load reduction) or defined by the fixed level of reader.
	/// @param nbVerticesOfLastLevel: the number of vertices of last
	/// valid level.
	/// @param isParent: a binary decomposition tree by level with
	/// constraint all describe children. It is useless to declare
	/// all the latest values to False, especially the last level
	/// may not be defined.
	/// @param isMasked: a binary mask corresponding. It is useless
	/// to declare all the latest values to False.
	/// @param outIsMasked: the mask of hypertree grid including
	/// this hypertree which is a vtkBitArray.
	/// </summary>
	public virtual void InitializeForReader(long numberOfLevels, long nbVertices, long nbVerticesOfLastLevel, vtkBitArray isParent, vtkBitArray isMasked, vtkBitArray outIsMasked)
	{
		vtkHyperTree_InitializeForReader_27(GetCppThis(), numberOfLevels, nbVertices, nbVerticesOfLastLevel, isParent?.GetCppThis() ?? default(HandleRef), isMasked?.GetCppThis() ?? default(HandleRef), outIsMasked?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTree_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperTree_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTree_IsGlobalIndexImplicit_29(HandleRef pThis);

	/// <summary>
	/// Return if implicit global index mapping has been used.
	/// If true, the initialize has been done by SetGlobalIndexStart (one call
	/// by hypertree).
	/// If false, the initialize has been done by SetGlobalIndexFromLocal (one
	/// call by cell of hypertree).
	/// GetGlobalIndexFromLocel get the good value of global index mapping for
	/// one cell what ever the initialize metho used.
	/// </summary>
	public virtual bool IsGlobalIndexImplicit()
	{
		return (vtkHyperTree_IsGlobalIndexImplicit_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTree_IsLeaf_30(HandleRef pThis, long index);

	/// <summary>
	/// Return if a vertice identified by index in tree as being leaf.
	/// \pre not_valid_index
	/// </summary>
	public virtual bool IsLeaf(long index)
	{
		return (vtkHyperTree_IsLeaf_30(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHyperTree_IsTerminalNode_31(HandleRef pThis, long index);

	/// <summary>
	/// Return if a vertice identified by index in tree as a terminal node.
	/// For this, all childrens mus be all leaves.
	/// \pre not_valid_index
	/// \pre not_valid_child_index
	/// </summary>
	public virtual bool IsTerminalNode(long index)
	{
		return (vtkHyperTree_IsTerminalNode_31(GetCppThis(), index) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperTree_IsTypeOf_32(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperTree_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTree_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperTree NewInstance()
	{
		vtkHyperTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTree_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperTree_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperTree SafeDownCast(vtkObjectBase o)
	{
		vtkHyperTree vtkHyperTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperTree_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperTree2 = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperTree2.Register(null);
			}
		}
		return vtkHyperTree2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_SetGlobalIndexFromLocal_35(HandleRef pThis, long index, long global);

	/// <summary>
	/// Set the mapping between a node index in tree and a explicit global
	/// index mapping.
	/// This global index mapping permits to access a value of
	/// field for a cell, in explicit, the index depend of order values.
	/// For this tree, in debug, assert is calling if tried call
	/// SetGlobalIndexStart.
	/// \pre not_global_index_from_local_if_use_global_index_start
	/// </summary>
	public virtual void SetGlobalIndexFromLocal(long index, long global)
	{
		vtkHyperTree_SetGlobalIndexFromLocal_35(GetCppThis(), index, global);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_SetGlobalIndexStart_36(HandleRef pThis, long start);

	/// <summary>
	/// Set the start implicit global index mapping for the first cell in the
	/// current tree.
	/// The implicit global index mapping of a node will be computed by
	/// this start index + the node index (local offset in tree).
	/// The node index begin by 0, the origin cell in tree. The follow values
	/// are organizing by fatrie as i to i+NumberOfChildren, for all children
	/// of one coarse cell, i is 1+8*s with s in integer. The order of fatrie
	/// depend of order to call SubdivideLeaf.
	/// This global index mapping permits to access a value of
	/// field for a cell, in implicit, the order values depends of implicit
	/// order linking with the order build of this tree.
	/// WARNING: See of hypertree grid, for to use a implicit global index
	/// mapping, you have to build hypertree by hypertree without to recome
	/// in hypertree also build.
	/// For this tree, in debug, assert is calling if tried call
	/// SetGlobalIndexFromLocal.
	/// \pre not_global_index_start_if_use_global_index_from_local
	/// </summary>
	public virtual void SetGlobalIndexStart(long start)
	{
		vtkHyperTree_SetGlobalIndexStart_36(GetCppThis(), start);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_SetTreeIndex_37(HandleRef pThis, long treeIndex);

	/// <summary>
	/// Set/Get tree index in hypertree grid.
	/// Services for internal use between hypertree grid and hypertree.
	/// </summary>
	public void SetTreeIndex(long treeIndex)
	{
		vtkHyperTree_SetTreeIndex_37(GetCppThis(), treeIndex);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperTree_SubdivideLeaf_38(HandleRef pThis, long index, uint level);

	/// <summary>
	/// Subdivide a vertice, only if its a leaf.
	/// \pre not_valide_index
	/// \pre not_leaf
	/// </summary>
	public virtual void SubdivideLeaf(long index, uint level)
	{
		vtkHyperTree_SubdivideLeaf_38(GetCppThis(), index, level);
	}
}
