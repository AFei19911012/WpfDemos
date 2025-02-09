using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellArrayIterator
/// </summary>
/// <remarks>
///    Encapsulate traversal logic for vtkCellArray.
///
/// This is iterator for thread-safe traversal of a vtkCellArray. It provides
/// random access and forward iteration. Typical usage for forward iteration
/// looks like:
///
/// ```
/// auto iter = vtk::TakeSmartPointer(cellArray-&gt;NewIterator());
/// for (iter-&gt;GoToFirstCell(); !iter-&gt;IsDoneWithTraversal(); iter-&gt;GoToNextCell())
/// {
///   // do work with iter
///   iter-&gt;GetCurrentCell(numCellPts, cellPts);
/// }
/// ```
///
/// Typical usage for random access looks like:
///
/// ```
/// auto iter = vtk::TakeSmartPointer(cellArray-&gt;NewIterator());
/// iter-&gt;GetCellAtId(cellId, numCellPts, cellPts);
/// ```
///
/// Here @a cellId is the id of the ith cell in the vtkCellArray;
/// @a numCellPts is the number of points defining the cell represented
/// as vtkIdType; and @a cellPts is a pointer to the point ids defined
/// as vtkIdType const*&amp;.
///
/// Internally the iterator may copy data from the vtkCellArray, or reference
/// the internal vtkCellArray storage. This depends on the relationship of
/// vtkIdType to the type and structure of internal storage. If the type of
/// storage is the same as vtkIdType, and the storage is a single-component
/// AOS array (i.e., a 1D array), then shared access to the vtkCellArray
/// storage is provided. Otherwise, the data from storage is copied into an
/// internal iterator buffer. (Of course copying is slower and can result in
/// 3-4x reduction in traversal performance. On the other hand, the
/// vtkCellArray can use the appropriate storage to save memory, perform
/// zero-copy, and/or efficiently represent the cell connectivity
/// information.) Note that referencing internal vtkCellArray storage has
/// implications on the validity of the iterator. If the underlying
/// vtkCellArray storage changes while iterating, and the iterator is
/// referencing this storage, unpredictable and catastrophic results are
/// likely - hence do not modify the vtkCellArray while iterating.
///
/// </remarks>
/// <seealso>
///
/// vtkCellArray
/// </seealso>
public class vtkCellArrayIterator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellArrayIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellArrayIterator()
	{
		MRClassNameKey = "class vtkCellArrayIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellArrayIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellArrayIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArrayIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkCellArrayIterator New()
	{
		vtkCellArrayIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArrayIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkCellArrayIterator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellArrayIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCellArrayIterator_GetCellArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the vtkCellArray object over which iteration is occurring.
	/// </summary>
	public vtkCellArray GetCellArray()
	{
		vtkCellArray vtkCellArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArrayIterator_GetCellArray_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellArray2 = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellArray2.Register(null);
			}
		}
		return vtkCellArray2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArrayIterator_GetCellAtId_02(HandleRef pThis, long cellId, HandleRef cellIds);

	/// <summary>
	/// Initialize the iterator to a specific cell and return the cell. Note
	/// that methods passing vtkIdLists always copy data from the vtkCellArray
	/// storage buffer into the vtkIdList. Otherwise, a fastpath returning
	/// (numCellPts,cellPts) which may return a pointer to internal vtkCellArray
	/// storage is possible, if vtkIdType is the same as the vtkCellArray buffer
	/// (which is typical).
	/// </summary>
	public void GetCellAtId(long cellId, vtkIdList cellIds)
	{
		vtkCellArrayIterator_GetCellAtId_02(GetCppThis(), cellId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArrayIterator_GetCellAtId_03(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Initialize the iterator to a specific cell and return the cell. Note
	/// that methods passing vtkIdLists always copy data from the vtkCellArray
	/// storage buffer into the vtkIdList. Otherwise, a fastpath returning
	/// (numCellPts,cellPts) which may return a pointer to internal vtkCellArray
	/// storage is possible, if vtkIdType is the same as the vtkCellArray buffer
	/// (which is typical).
	/// </summary>
	public vtkIdList GetCellAtId(long cellId)
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArrayIterator_GetCellAtId_03(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArrayIterator_GetCurrentCell_04(HandleRef pThis, HandleRef ids);

	/// <summary>
	/// Returns the definition of the current cell during forward
	/// traversal. Note that methods passing vtkIdLists always copy data from
	/// the vtkCellArray storage buffer into the vtkIdList. Otherwise, a
	/// fastpath returning (numCellPts,cellPts) - which may return a pointer to
	/// internal vtkCellArray storage - is possible, if vtkIdType is the same as
	/// the vtkCellArray storage (which is typical).
	/// </summary>
	public void GetCurrentCell(vtkIdList ids)
	{
		vtkCellArrayIterator_GetCurrentCell_04(GetCppThis(), ids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArrayIterator_GetCurrentCell_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the definition of the current cell during forward
	/// traversal. Note that methods passing vtkIdLists always copy data from
	/// the vtkCellArray storage buffer into the vtkIdList. Otherwise, a
	/// fastpath returning (numCellPts,cellPts) - which may return a pointer to
	/// internal vtkCellArray storage - is possible, if vtkIdType is the same as
	/// the vtkCellArray storage (which is typical).
	/// </summary>
	public vtkIdList GetCurrentCell()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArrayIterator_GetCurrentCell_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArrayIterator_GetCurrentCellId_06(HandleRef pThis);

	/// <summary>
	/// Returns the id of the current cell during forward iteration.
	/// </summary>
	public long GetCurrentCellId()
	{
		return vtkCellArrayIterator_GetCurrentCellId_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArrayIterator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellArrayIterator_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellArrayIterator_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellArrayIterator_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArrayIterator_GoToCell_09(HandleRef pThis, long cellId);

	/// <summary>
	/// Initialize the iterator to a specific cell. This will revalidate the
	/// iterator if the underlying vtkCellArray has been modified. This method
	/// can always be used to set the starting location for forward iteration,
	/// and it is also used to support random access.
	/// </summary>
	public void GoToCell(long cellId)
	{
		vtkCellArrayIterator_GoToCell_09(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArrayIterator_GoToFirstCell_10(HandleRef pThis);

	/// <summary>
	/// Initialize the iterator for forward iteration. This will revalidate the
	/// iterator if the underlying vtkCellArray has been modified.
	/// </summary>
	public void GoToFirstCell()
	{
		vtkCellArrayIterator_GoToFirstCell_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArrayIterator_GoToNextCell_11(HandleRef pThis);

	/// <summary>
	/// Advance the forward iterator to the next cell.
	/// </summary>
	public void GoToNextCell()
	{
		vtkCellArrayIterator_GoToNextCell_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellArrayIterator_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellArrayIterator_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellArrayIterator_IsDoneWithTraversal_13(HandleRef pThis);

	/// <summary>
	/// Returns true if the iterator has completed the traversal.
	/// </summary>
	public bool IsDoneWithTraversal()
	{
		return (vtkCellArrayIterator_IsDoneWithTraversal_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellArrayIterator_IsTypeOf_14(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellArrayIterator_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArrayIterator_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkCellArrayIterator NewInstance()
	{
		vtkCellArrayIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArrayIterator_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArrayIterator_ReplaceCurrentCell_17(HandleRef pThis, HandleRef list);

	/// <summary>
	/// Replace the current cell with the ids in `list`. Note that this method
	/// CANNOT change the number of points in the cell, it can only redefine the
	/// ids (e.g. `list` must contain the same number of entries as the current
	/// cell's points).
	/// </summary>
	public void ReplaceCurrentCell(vtkIdList list)
	{
		vtkCellArrayIterator_ReplaceCurrentCell_17(GetCppThis(), list?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArrayIterator_ReplaceCurrentCell_18(HandleRef pThis, long npts, IntPtr pts);

	/// <summary>
	/// Replace the current cell with the ids in `pts`. Note that this method
	/// CANNOT change the number of points in the cell, it can only redefine the
	/// ids (e.g. `npts` must equal the current cell's number of points).
	/// </summary>
	public void ReplaceCurrentCell(long npts, IntPtr pts)
	{
		vtkCellArrayIterator_ReplaceCurrentCell_18(GetCppThis(), npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellArrayIterator_ReverseCurrentCell_19(HandleRef pThis);

	/// <summary>
	/// Reverses the order of the point ids in the current cell.
	/// </summary>
	public void ReverseCurrentCell()
	{
		vtkCellArrayIterator_ReverseCurrentCell_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellArrayIterator_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkCellArrayIterator SafeDownCast(vtkObjectBase o)
	{
		vtkCellArrayIterator vtkCellArrayIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellArrayIterator_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellArrayIterator2 = (vtkCellArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellArrayIterator2.Register(null);
			}
		}
		return vtkCellArrayIterator2;
	}
}
