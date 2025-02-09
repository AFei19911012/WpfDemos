using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkExtractBlock
/// </summary>
/// <remarks>
///  extracts blocks from a vtkDataObjectTree subclass.
///
/// vtkExtractBlock is a filter that extracts blocks from a vtkDataObjectTree
/// subclass such as vtkPartitionedDataSet, vtkPartitionedDataSetCollection, etc.
/// using their composite-ids (also called flat-index).
///
/// The composite-id can be obtained by performing a pre-order traversal of the
/// tree (including empty nodes). For example, consider a tree with nodes named
/// `A(B (D, E), C(F, G))`.  Pre-order traversal yields: `A, B, D, E, C, F, G`;
/// hence, composite-id of `A` is `0`, while index of `C` is `4`.
///
/// `0` identifies the root-node. Thus, choosing `0` will result in the entire
/// input dataset being passed to the output.
/// </remarks>
public class vtkExtractBlock : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractBlock";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractBlock()
	{
		MRClassNameKey = "class vtkExtractBlock";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractBlock"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractBlock(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractBlock_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkExtractBlock New()
	{
		vtkExtractBlock result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractBlock_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkExtractBlock()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractBlock_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_AddIndex_01(HandleRef pThis, uint index);

	/// <summary>
	/// Select the block indices to extract.  Each node in the multi-block tree
	/// is identified by an \c index. The index can be obtained by performing a
	/// preorder traversal of the tree (including empty nodes). eg. A(B (D, E),
	/// C(F, G)).  Inorder traversal yields: A, B, D, E, C, F, G Index of A is
	/// 0, while index of C is 4. (Note: specifying node 0 means the input is
	/// copied to the output.)
	/// </summary>
	public void AddIndex(uint index)
	{
		vtkExtractBlock_AddIndex_01(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractBlock_GetMaintainStructure_02(HandleRef pThis);

	/// <summary>
	/// This is used only when PruneOutput is ON. By default, when pruning the
	/// output i.e. remove empty blocks, if node has only 1 non-null child block,
	/// then that node is removed. To preserve these parent nodes, set this flag to
	/// true. Off by default.
	///
	/// This has no effect for vtkPartitionedDataSetCollection.
	/// </summary>
	public virtual int GetMaintainStructure()
	{
		return vtkExtractBlock_GetMaintainStructure_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractBlock_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractBlock_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractBlock_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractBlock_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractBlock_GetPruneOutput_05(HandleRef pThis);

	/// <summary>
	/// When set, the output multiblock dataset will be pruned to remove empty
	/// nodes. On by default.
	///
	/// This has no effect for vtkPartitionedDataSetCollection.
	/// </summary>
	public virtual int GetPruneOutput()
	{
		return vtkExtractBlock_GetPruneOutput_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractBlock_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractBlock_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractBlock_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractBlock_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_MaintainStructureOff_08(HandleRef pThis);

	/// <summary>
	/// This is used only when PruneOutput is ON. By default, when pruning the
	/// output i.e. remove empty blocks, if node has only 1 non-null child block,
	/// then that node is removed. To preserve these parent nodes, set this flag to
	/// true. Off by default.
	///
	/// This has no effect for vtkPartitionedDataSetCollection.
	/// </summary>
	public virtual void MaintainStructureOff()
	{
		vtkExtractBlock_MaintainStructureOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_MaintainStructureOn_09(HandleRef pThis);

	/// <summary>
	/// This is used only when PruneOutput is ON. By default, when pruning the
	/// output i.e. remove empty blocks, if node has only 1 non-null child block,
	/// then that node is removed. To preserve these parent nodes, set this flag to
	/// true. Off by default.
	///
	/// This has no effect for vtkPartitionedDataSetCollection.
	/// </summary>
	public virtual void MaintainStructureOn()
	{
		vtkExtractBlock_MaintainStructureOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractBlock_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkExtractBlock NewInstance()
	{
		vtkExtractBlock result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractBlock_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_PruneOutputOff_12(HandleRef pThis);

	/// <summary>
	/// When set, the output multiblock dataset will be pruned to remove empty
	/// nodes. On by default.
	///
	/// This has no effect for vtkPartitionedDataSetCollection.
	/// </summary>
	public virtual void PruneOutputOff()
	{
		vtkExtractBlock_PruneOutputOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_PruneOutputOn_13(HandleRef pThis);

	/// <summary>
	/// When set, the output multiblock dataset will be pruned to remove empty
	/// nodes. On by default.
	///
	/// This has no effect for vtkPartitionedDataSetCollection.
	/// </summary>
	public virtual void PruneOutputOn()
	{
		vtkExtractBlock_PruneOutputOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_RemoveAllIndices_14(HandleRef pThis);

	/// <summary>
	/// Select the block indices to extract.  Each node in the multi-block tree
	/// is identified by an \c index. The index can be obtained by performing a
	/// preorder traversal of the tree (including empty nodes). eg. A(B (D, E),
	/// C(F, G)).  Inorder traversal yields: A, B, D, E, C, F, G Index of A is
	/// 0, while index of C is 4. (Note: specifying node 0 means the input is
	/// copied to the output.)
	/// </summary>
	public void RemoveAllIndices()
	{
		vtkExtractBlock_RemoveAllIndices_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_RemoveIndex_15(HandleRef pThis, uint index);

	/// <summary>
	/// Select the block indices to extract.  Each node in the multi-block tree
	/// is identified by an \c index. The index can be obtained by performing a
	/// preorder traversal of the tree (including empty nodes). eg. A(B (D, E),
	/// C(F, G)).  Inorder traversal yields: A, B, D, E, C, F, G Index of A is
	/// 0, while index of C is 4. (Note: specifying node 0 means the input is
	/// copied to the output.)
	/// </summary>
	public void RemoveIndex(uint index)
	{
		vtkExtractBlock_RemoveIndex_15(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractBlock_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkExtractBlock SafeDownCast(vtkObjectBase o)
	{
		vtkExtractBlock vtkExtractBlock2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractBlock_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractBlock2 = (vtkExtractBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractBlock2.Register(null);
			}
		}
		return vtkExtractBlock2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_SetMaintainStructure_17(HandleRef pThis, int _arg);

	/// <summary>
	/// This is used only when PruneOutput is ON. By default, when pruning the
	/// output i.e. remove empty blocks, if node has only 1 non-null child block,
	/// then that node is removed. To preserve these parent nodes, set this flag to
	/// true. Off by default.
	///
	/// This has no effect for vtkPartitionedDataSetCollection.
	/// </summary>
	public virtual void SetMaintainStructure(int _arg)
	{
		vtkExtractBlock_SetMaintainStructure_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractBlock_SetPruneOutput_18(HandleRef pThis, int _arg);

	/// <summary>
	/// When set, the output multiblock dataset will be pruned to remove empty
	/// nodes. On by default.
	///
	/// This has no effect for vtkPartitionedDataSetCollection.
	/// </summary>
	public virtual void SetPruneOutput(int _arg)
	{
		vtkExtractBlock_SetPruneOutput_18(GetCppThis(), _arg);
	}
}
