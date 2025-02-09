using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkScalarTree
/// </summary>
/// <remarks>
///    organize data according to scalar values (used to accelerate contouring operations)
///
///
/// vtkScalarTree is an abstract class that defines the API to concrete
/// scalar tree subclasses. A scalar tree is a data structure that organizes
/// data according to its scalar value. This allows rapid access to data for
/// those algorithms that access the data based on scalar value. For example,
/// isocontouring operates on cells based on the scalar (isocontour) value.
///
/// To use subclasses of this class, you must specify a dataset to operate on,
/// and then specify a scalar value in the InitTraversal() method. Then
/// calls to GetNextCell() return cells whose scalar data contains the
/// scalar value specified. (This describes serial traversal.)
///
/// Methods supporting parallel traversal (such as threading) are also
/// supported. Basically thread-safe batches of cells (which are a
/// portion of the whole dataset) are available for processing using a
/// parallel For() operation. First request the number of batches, and
/// then for each batch, retrieve the array of cell ids in that batch. These
/// batches contain cell ids that are likely to contain the isosurface.
///
/// </remarks>
/// <seealso>
///
/// vtkSimpleScalarTree vtkSpanSpace
/// </seealso>
public abstract class vtkScalarTree : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkScalarTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkScalarTree()
	{
		MRClassNameKey = "class vtkScalarTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkScalarTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarTree_BuildTree_01(HandleRef pThis);

	/// <summary>
	/// Construct the scalar tree from the dataset provided. Checks build times
	/// and modified time from input and reconstructs the tree if necessary.
	/// </summary>
	public virtual void BuildTree()
	{
		vtkScalarTree_BuildTree_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarTree_GetCellBatch_02(HandleRef pThis, long batchNum, ref long numCells);

	/// <summary>
	/// Return the array of cell ids in the specified batch. The method
	/// also returns the number of cell ids in the array. Make sure to
	/// call GetNumberOfCellBatches() beforehand.
	/// </summary>
	public virtual IntPtr GetCellBatch(long batchNum, ref long numCells)
	{
		return vtkScalarTree_GetCellBatch_02(GetCppThis(), batchNum, ref numCells);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarTree_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Build the tree from the points/cells and scalars defining this
	/// dataset.
	/// </summary>
	public virtual vtkDataSet GetDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarTree_GetDataSet_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarTree_GetNextCell_04(HandleRef pThis, ref long cellId, HandleRef ptIds, HandleRef cellScalars, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the next cell that may contain scalar value specified to
	/// InitTraversal() (serial traversal). The value nullptr is returned if the
	/// list is exhausted. Make sure that InitTraversal() has been invoked first
	/// or you'll get erratic behavior.
	/// </summary>
	public virtual vtkCell GetNextCell(ref long cellId, vtkIdList ptIds, vtkDataArray cellScalars)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarTree_GetNextCell_04(GetCppThis(), ref cellId, ptIds?.GetCppThis() ?? default(HandleRef), cellScalars?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkScalarTree_GetNumberOfCellBatches_05(HandleRef pThis, double scalarValue);

	/// <summary>
	/// Get the number of cell batches available for processing as a function of
	/// the specified scalar value. Each batch contains a list of candidate
	/// cells that may contain the specified isocontour value.
	/// </summary>
	public virtual long GetNumberOfCellBatches(double scalarValue)
	{
		return vtkScalarTree_GetNumberOfCellBatches_05(GetCppThis(), scalarValue);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarTree_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkScalarTree_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkScalarTree_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkScalarTree_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkScalarTree_GetScalarValue_08(HandleRef pThis);

	/// <summary>
	/// Return the current scalar value over which tree traversal is proceeding.
	/// This is the scalar value provided in InitTraversal().
	/// </summary>
	public double GetScalarValue()
	{
		return vtkScalarTree_GetScalarValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarTree_GetScalars_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Build the tree from the points/cells and scalars defining the
	/// dataset and scalars provided. Typically the scalars come from
	/// the vtkDataSet specified, but sometimes a separate vtkDataArray
	/// is provided to specify the scalars. If the scalar array is
	/// explicitly set, then it takes precedence over the scalars held
	/// in the vtkDataSet.
	/// </summary>
	public virtual vtkDataArray GetScalars()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarTree_GetScalars_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarTree_InitTraversal_10(HandleRef pThis, double scalarValue);

	/// <summary>
	/// Begin to traverse the cells based on a scalar value (serial
	/// traversal). Returned cells will have scalar values that span the scalar
	/// value specified. Note that changing the scalarValue does not cause the
	/// scalar tree to be modified, and hence it does not rebuild.
	/// </summary>
	public virtual void InitTraversal(double scalarValue)
	{
		vtkScalarTree_InitTraversal_10(GetCppThis(), scalarValue);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarTree_Initialize_11(HandleRef pThis);

	/// <summary>
	/// Initialize locator. Frees memory and resets object as appropriate.
	/// </summary>
	public virtual void Initialize()
	{
		vtkScalarTree_Initialize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarTree_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkScalarTree_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkScalarTree_IsTypeOf_13(string type);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkScalarTree_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarTree_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new vtkScalarTree NewInstance()
	{
		vtkScalarTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarTree_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkScalarTree_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type related macros and PrintSelf() method.
	/// </summary>
	public new static vtkScalarTree SafeDownCast(vtkObjectBase o)
	{
		vtkScalarTree vtkScalarTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkScalarTree_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarTree2 = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarTree2.Register(null);
			}
		}
		return vtkScalarTree2;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarTree_SetDataSet_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Build the tree from the points/cells and scalars defining this
	/// dataset.
	/// </summary>
	public virtual void SetDataSet(vtkDataSet arg0)
	{
		vtkScalarTree_SetDataSet_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarTree_SetScalars_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Build the tree from the points/cells and scalars defining the
	/// dataset and scalars provided. Typically the scalars come from
	/// the vtkDataSet specified, but sometimes a separate vtkDataArray
	/// is provided to specify the scalars. If the scalar array is
	/// explicitly set, then it takes precedence over the scalars held
	/// in the vtkDataSet.
	/// </summary>
	public virtual void SetScalars(vtkDataArray arg0)
	{
		vtkScalarTree_SetScalars_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkScalarTree_ShallowCopy_18(HandleRef pThis, HandleRef stree);

	/// <summary>
	/// This method is used to copy data members when cloning an instance of the
	/// class. It does not copy heavy data.
	/// </summary>
	public virtual void ShallowCopy(vtkScalarTree stree)
	{
		vtkScalarTree_ShallowCopy_18(GetCppThis(), stree?.GetCppThis() ?? default(HandleRef));
	}
}
