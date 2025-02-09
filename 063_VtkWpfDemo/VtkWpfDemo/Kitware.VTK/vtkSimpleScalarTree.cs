using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSimpleScalarTree
/// </summary>
/// <remarks>
///    organize data according to scalar values (used to accelerate contouring operations)
///
/// vtkSimpleScalarTree creates a pointerless binary tree that helps search
/// for cells that lie within a particular scalar range. This object is used
/// to accelerate some contouring (and other scalar-based techniques).
///
/// The tree consists of an array of (min,max) scalar range pairs per
/// node in the tree. The (min,max) range is determined from looking at
/// the range of the children of the tree node. If the node is a leaf,
/// then the range is determined by scanning the range of scalar data
/// in n cells in the dataset. The n cells are determined by arbitrary
/// selecting cell ids from id(i) to id(i+n), and where n is specified
/// using the BranchingFactor ivar. Note that leaf node i=0 contains
/// the scalar range computed from cell ids (0,n-1); leaf node i=1
/// contains the range from cell ids (n,2n-1); and so on. The
/// implication is that there are no direct lists of cell ids per leaf
/// node, instead the cell ids are implicitly known. Despite the
/// arbitrary grouping of cells, in practice this scalar tree actually
/// performs quite well due to spatial/data coherence.
///
/// This class has an API that supports both serial and parallel
/// operation.  The parallel API enables the using class to grab arrays
/// (or batches) of cells that potentially intersect the
/// isocontour. These batches can then be processed in separate
/// threads.
///
/// </remarks>
/// <seealso>
///
/// vtkScalarTree vtkSpanSpace
/// </seealso>
public class vtkSimpleScalarTree : vtkScalarTree
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleScalarTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSimpleScalarTree()
	{
		MRClassNameKey = "class vtkSimpleScalarTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleScalarTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSimpleScalarTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleScalarTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate scalar tree with maximum level of 20 and branching
	/// factor of three.
	/// </summary>
	public new static vtkSimpleScalarTree New()
	{
		vtkSimpleScalarTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleScalarTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate scalar tree with maximum level of 20 and branching
	/// factor of three.
	/// </summary>
	public vtkSimpleScalarTree()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSimpleScalarTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleScalarTree_BuildTree_01(HandleRef pThis);

	/// <summary>
	/// Construct the scalar tree from the dataset provided. Checks build times
	/// and modified time from input and reconstructs the tree if necessary.
	/// </summary>
	public override void BuildTree()
	{
		vtkSimpleScalarTree_BuildTree_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_GetBranchingFactor_02(HandleRef pThis);

	/// <summary>
	/// Set the branching factor for the tree. This is the number of
	/// children per tree node. Smaller values (minimum is 2) mean deeper
	/// trees and more memory overhead. Larger values mean shallower
	/// trees, less memory usage, but worse performance.
	/// </summary>
	public virtual int GetBranchingFactor()
	{
		return vtkSimpleScalarTree_GetBranchingFactor_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_GetBranchingFactorMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set the branching factor for the tree. This is the number of
	/// children per tree node. Smaller values (minimum is 2) mean deeper
	/// trees and more memory overhead. Larger values mean shallower
	/// trees, less memory usage, but worse performance.
	/// </summary>
	public virtual int GetBranchingFactorMaxValue()
	{
		return vtkSimpleScalarTree_GetBranchingFactorMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_GetBranchingFactorMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set the branching factor for the tree. This is the number of
	/// children per tree node. Smaller values (minimum is 2) mean deeper
	/// trees and more memory overhead. Larger values mean shallower
	/// trees, less memory usage, but worse performance.
	/// </summary>
	public virtual int GetBranchingFactorMinValue()
	{
		return vtkSimpleScalarTree_GetBranchingFactorMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleScalarTree_GetCellBatch_05(HandleRef pThis, long batchNum, ref long numCells);

	/// <summary>
	/// Return the array of cell ids in the specified batch. The method
	/// also returns the number of cell ids in the array. Make sure to
	/// call GetNumberOfCellBatches() beforehand.
	/// </summary>
	public override IntPtr GetCellBatch(long batchNum, ref long numCells)
	{
		return vtkSimpleScalarTree_GetCellBatch_05(GetCppThis(), batchNum, ref numCells);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_GetLevel_06(HandleRef pThis);

	/// <summary>
	/// Get the level of the scalar tree. This value may change each time the
	/// scalar tree is built and the branching factor changes.
	/// </summary>
	public virtual int GetLevel()
	{
		return vtkSimpleScalarTree_GetLevel_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_GetMaxLevel_07(HandleRef pThis);

	/// <summary>
	/// Set the maximum allowable level for the tree.
	/// </summary>
	public virtual int GetMaxLevel()
	{
		return vtkSimpleScalarTree_GetMaxLevel_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_GetMaxLevelMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set the maximum allowable level for the tree.
	/// </summary>
	public virtual int GetMaxLevelMaxValue()
	{
		return vtkSimpleScalarTree_GetMaxLevelMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_GetMaxLevelMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set the maximum allowable level for the tree.
	/// </summary>
	public virtual int GetMaxLevelMinValue()
	{
		return vtkSimpleScalarTree_GetMaxLevelMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleScalarTree_GetNextCell_10(HandleRef pThis, ref long cellId, HandleRef ptIds, HandleRef cellScalars, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the next cell that may contain scalar value specified to
	/// initialize traversal. The value nullptr is returned if the list is
	/// exhausted. Make sure that InitTraversal() has been invoked first or
	/// you'll get erratic behavior.
	/// </summary>
	public override vtkCell GetNextCell(ref long cellId, vtkIdList ptIds, vtkDataArray cellScalars)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleScalarTree_GetNextCell_10(GetCppThis(), ref cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellScalars?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleScalarTree_GetNumberOfCellBatches_11(HandleRef pThis, double scalarValue);

	/// <summary>
	/// Get the number of cell batches available for processing as a function of
	/// the specified scalar value. Each batch contains a list of candidate
	/// cells that may contain the specified isocontour value.
	/// </summary>
	public override long GetNumberOfCellBatches(double scalarValue)
	{
		return vtkSimpleScalarTree_GetNumberOfCellBatches_11(GetCppThis(), scalarValue);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleScalarTree_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSimpleScalarTree_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleScalarTree_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSimpleScalarTree_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleScalarTree_InitTraversal_14(HandleRef pThis, double scalarValue);

	/// <summary>
	/// Begin to traverse the cells based on a scalar value. Returned cells
	/// will likely have scalar values that span the scalar value specified.
	/// </summary>
	public override void InitTraversal(double scalarValue)
	{
		vtkSimpleScalarTree_InitTraversal_14(GetCppThis(), scalarValue);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleScalarTree_Initialize_15(HandleRef pThis);

	/// <summary>
	/// Initialize locator. Frees memory and resets object as appropriate.
	/// </summary>
	public override void Initialize()
	{
		vtkSimpleScalarTree_Initialize_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSimpleScalarTree_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleScalarTree_IsTypeOf_17(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSimpleScalarTree_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleScalarTree_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new vtkSimpleScalarTree NewInstance()
	{
		vtkSimpleScalarTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleScalarTree_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleScalarTree_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static vtkSimpleScalarTree SafeDownCast(vtkObjectBase o)
	{
		vtkSimpleScalarTree vtkSimpleScalarTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleScalarTree_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSimpleScalarTree2 = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSimpleScalarTree2.Register(null);
			}
		}
		return vtkSimpleScalarTree2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleScalarTree_SetBranchingFactor_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the branching factor for the tree. This is the number of
	/// children per tree node. Smaller values (minimum is 2) mean deeper
	/// trees and more memory overhead. Larger values mean shallower
	/// trees, less memory usage, but worse performance.
	/// </summary>
	public virtual void SetBranchingFactor(int _arg)
	{
		vtkSimpleScalarTree_SetBranchingFactor_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleScalarTree_SetMaxLevel_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the maximum allowable level for the tree.
	/// </summary>
	public virtual void SetMaxLevel(int _arg)
	{
		vtkSimpleScalarTree_SetMaxLevel_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleScalarTree_ShallowCopy_23(HandleRef pThis, HandleRef stree);

	/// <summary>
	/// This method is used to copy data members when cloning an instance of the
	/// class. It does not copy heavy data.
	/// </summary>
	public override void ShallowCopy(vtkScalarTree stree)
	{
		vtkSimpleScalarTree_ShallowCopy_23(GetCppThis(), stree?.GetCppThis() ?? default(HandleRef));
	}
}
