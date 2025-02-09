using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellIterator
/// </summary>
/// <remarks>
///    Efficient cell iterator for vtkDataSet topologies.
///
///
/// vtkCellIterator provides a method for traversing cells in a data set. Call
/// the vtkDataSet::NewCellIterator() method to use this class.
///
/// The cell is represented as a set of three pieces of information: The cell
/// type, the ids of the points constituting the cell, and the points themselves.
/// This iterator fetches these as needed. If only the cell type is used,
/// the type is not looked up until GetCellType is called, and the point
/// information is left uninitialized. This allows efficient screening of cells,
/// since expensive point lookups may be skipped depending on the cell type/etc.
///
/// An example usage of this class:
/// ~~~
/// void myWorkerFunction(vtkDataSet *ds)
/// {
///   vtkCellIterator *it = ds-&gt;NewCellIterator();
///   for (it-&gt;InitTraversal(); !it-&gt;IsDoneWithTraversal(); it-&gt;GoToNextCell())
///     {
///     if (it-&gt;GetCellType() != VTK_TETRA)
///       {
///       continue; // Skip non-tetrahedral cells
///       }
///
///     vtkIdList *pointIds = it-&gt;GetPointIds();
///     // Do screening on the point ids, maybe figure out scalar range and skip
///        cells that do not lie in a certain range?
///
///     vtkPoints *points = it-&gt;GetPoints();
///     // Do work using the cell points, or ...
///
///     vtkGenericCell *cell = ...;
///     it-&gt;GetCell(cell);
///     // ... do work with a vtkCell.
///     }
///   it-&gt;Delete();
/// }
/// ~~~
///
/// The example above pulls in bits of information as needed to filter out cells
/// that aren't relevant. The least expensive lookups are performed first
/// (cell type, then point ids, then points/full cell) to prevent wasted cycles
/// fetching unnecessary data. Also note that at the end of the loop, the
/// iterator must be deleted as these iterators are vtkObject subclasses.
/// </remarks>
public abstract class vtkCellIterator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellIterator()
	{
		MRClassNameKey = "class vtkCellIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkCellIterator_GetCell_01(HandleRef pThis, HandleRef cell);

	/// <summary>
	/// Write the current full cell information into the argument.
	/// This is usually a very expensive call, and should be avoided when possible.
	/// This should only be called when IsDoneWithTraversal() returns false.
	/// </summary>
	public void GetCell(vtkGenericCell cell)
	{
		vtkCellIterator_GetCell_01(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellIterator_GetCellDimension_02(HandleRef pThis);

	/// <summary>
	/// Get the current cell dimension (0, 1, 2, or 3). This should only be called
	/// when IsDoneWithTraversal() returns false.
	/// </summary>
	public int GetCellDimension()
	{
		return vtkCellIterator_GetCellDimension_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellIterator_GetCellId_03(HandleRef pThis);

	/// <summary>
	/// Get the id of the current cell.
	/// </summary>
	public virtual long GetCellId()
	{
		return vtkCellIterator_GetCellId_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellIterator_GetCellType_04(HandleRef pThis);

	/// <summary>
	/// Get the current cell type (e.g. VTK_LINE, VTK_VERTEX, VTK_TETRA, etc).
	/// This should only be called when IsDoneWithTraversal() returns false.
	/// </summary>
	public int GetCellType()
	{
		return vtkCellIterator_GetCellType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellIterator_GetFaces_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the faces for a polyhedral cell. This is only valid when CellType
	/// is VTK_POLYHEDRON.
	/// </summary>
	public vtkIdList GetFaces()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellIterator_GetFaces_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCellIterator_GetNumberOfFaces_06(HandleRef pThis);

	/// <summary>
	/// Return the number of faces in the current cell.
	/// This should only be called when IsDoneWithTraversal() returns false.
	/// </summary>
	public long GetNumberOfFaces()
	{
		return vtkCellIterator_GetNumberOfFaces_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellIterator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellIterator_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellIterator_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellIterator_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellIterator_GetNumberOfPoints_09(HandleRef pThis);

	/// <summary>
	/// Return the number of points in the current cell.
	/// This should only be called when IsDoneWithTraversal() returns false.
	/// </summary>
	public long GetNumberOfPoints()
	{
		return vtkCellIterator_GetNumberOfPoints_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellIterator_GetPointIds_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the ids of the points in the current cell.
	/// This should only be called when IsDoneWithTraversal() returns false.
	/// </summary>
	public vtkIdList GetPointIds()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellIterator_GetPointIds_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCellIterator_GetPoints_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the points in the current cell.
	/// This is usually a very expensive call, and should be avoided when possible.
	/// This should only be called when IsDoneWithTraversal() returns false.
	/// </summary>
	public vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellIterator_GetPoints_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellIterator_GoToNextCell_12(HandleRef pThis);

	/// <summary>
	/// Increment to next cell. Always safe to call.
	/// </summary>
	public void GoToNextCell()
	{
		vtkCellIterator_GoToNextCell_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellIterator_InitTraversal_13(HandleRef pThis);

	/// <summary>
	/// Reset to the first cell.
	/// </summary>
	public void InitTraversal()
	{
		vtkCellIterator_InitTraversal_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellIterator_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellIterator_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellIterator_IsDoneWithTraversal_15(HandleRef pThis);

	/// <summary>
	/// Returns false while the iterator is valid. Always safe to call.
	/// </summary>
	public virtual bool IsDoneWithTraversal()
	{
		return (vtkCellIterator_IsDoneWithTraversal_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellIterator_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellIterator_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellIterator_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCellIterator NewInstance()
	{
		vtkCellIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellIterator_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellIterator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellIterator SafeDownCast(vtkObjectBase o)
	{
		vtkCellIterator vtkCellIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellIterator_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellIterator2 = (vtkCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellIterator2.Register(null);
			}
		}
		return vtkCellIterator2;
	}
}
