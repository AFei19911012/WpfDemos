using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridBase
/// </summary>
/// <remarks>
///    dataset represents arbitrary combinations
/// of all possible cell types. May be mapped onto a non-standard memory layout.
///
///
/// vtkUnstructuredGridBase defines the core vtkUnstructuredGrid API, omitting
/// functions that are implementation dependent.
///
/// </remarks>
/// <seealso>
///
/// vtkMappedDataArray vtkUnstructuredGrid
/// </seealso>
public abstract class vtkUnstructuredGridBase : vtkPointSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridBase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridBase()
	{
		MRClassNameKey = "class vtkUnstructuredGridBase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridBase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkUnstructuredGridBase_Allocate_01(HandleRef pThis, long numCells, int extSize);

	/// <summary>
	/// Allocate memory for the number of cells indicated. extSize is not used.
	/// </summary>
	public virtual void Allocate(long numCells, int extSize)
	{
		vtkUnstructuredGridBase_Allocate_01(GetCppThis(), numCells, extSize);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridBase_DeepCopy_02(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkUnstructuredGridBase_DeepCopy_02(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBase_GetData_03(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkUnstructuredGridBase GetData(vtkInformation info)
	{
		vtkUnstructuredGridBase vtkUnstructuredGridBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBase_GetData_03(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridBase2 = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridBase2.Register(null);
			}
		}
		return vtkUnstructuredGridBase2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBase_GetData_04(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkUnstructuredGridBase GetData(vtkInformationVector v, int i)
	{
		vtkUnstructuredGridBase vtkUnstructuredGridBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBase_GetData_04(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridBase2 = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridBase2.Register(null);
			}
		}
		return vtkUnstructuredGridBase2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridBase_GetDataObjectType_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkUnstructuredGridBase_GetDataObjectType_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridBase_GetIdsOfCellsOfType_06(HandleRef pThis, int type, HandleRef array);

	/// <summary>
	/// Fill vtkIdTypeArray container with list of cell Ids.  This
	/// method traverses all cells and, for a particular cell type,
	/// inserts the cell Id into the container.
	/// </summary>
	public virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray array)
	{
		vtkUnstructuredGridBase_GetIdsOfCellsOfType_06(GetCppThis(), type, array?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridBase_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridBase_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridBase_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridBase_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridBase_InsertNextCell_09(HandleRef pThis, int type, long npts, IntPtr ptIds);

	/// <summary>
	/// Insert/create cell in object by type and list of point ids defining
	/// cell topology. Most cells require just a type which implicitly defines
	/// a set of points and their ordering. For non-polyhedron cell type, npts
	/// is the number of unique points in the cell. pts are the list of global
	/// point Ids. For polyhedron cell, a special input format is required.
	/// npts is the number of faces in the cell. ptIds is the list of face stream:
	/// (numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// Make sure you have called Allocate() before calling this method
	/// </summary>
	public long InsertNextCell(int type, long npts, IntPtr ptIds)
	{
		return vtkUnstructuredGridBase_InsertNextCell_09(GetCppThis(), type, npts, ptIds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridBase_InsertNextCell_10(HandleRef pThis, int type, HandleRef ptIds);

	/// <summary>
	/// Insert/create cell in object by a list of point ids defining
	/// cell topology. Most cells require just a type which implicitly defines
	/// a set of points and their ordering. For non-polyhedron cell type, ptIds
	/// is the list of global Ids of unique cell points. For polyhedron cell,
	/// a special ptIds input format is required:
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// Make sure you have called Allocate() before calling this method
	/// </summary>
	public long InsertNextCell(int type, vtkIdList ptIds)
	{
		return vtkUnstructuredGridBase_InsertNextCell_10(GetCppThis(), type, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridBase_InsertNextCell_11(HandleRef pThis, int type, long npts, IntPtr ptIds, long nfaces, IntPtr faces);

	/// <summary>
	/// Insert/create cell in object by a list of point ids defining
	/// cell topology. Most cells require just a type which implicitly defines
	/// a set of points and their ordering. For non-polyhedron cell type, ptIds
	/// is the list of global Ids of unique cell points. For polyhedron cell,
	/// a special ptIds input format is required:
	/// (numCellFaces, numFace0Pts, id1, id2, id3, numFace1Pts,id1, id2, id3, ...)
	/// Make sure you have called Allocate() before calling this method
	/// </summary>
	public long InsertNextCell(int type, long npts, IntPtr ptIds, long nfaces, IntPtr faces)
	{
		return vtkUnstructuredGridBase_InsertNextCell_11(GetCppThis(), type, npts, ptIds, nfaces, faces);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridBase_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridBase_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridBase_IsHomogeneous_13(HandleRef pThis);

	/// <summary>
	/// Traverse cells and determine if cells are all of the same type.
	/// </summary>
	public virtual int IsHomogeneous()
	{
		return vtkUnstructuredGridBase_IsHomogeneous_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridBase_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridBase_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBase_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridBase NewInstance()
	{
		vtkUnstructuredGridBase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBase_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridBase_ReplaceCell_16(HandleRef pThis, long cellId, int npts, IntPtr pts);

	/// <summary>
	/// Replace the points defining cell "cellId" with a new set of points. This
	/// operator is (typically) used when links from points to cells have not been
	/// built (i.e., BuildLinks() has not been executed). Use the operator
	/// ReplaceLinkedCell() to replace a cell when cell structure has been built.
	/// </summary>
	public void ReplaceCell(long cellId, int npts, IntPtr pts)
	{
		vtkUnstructuredGridBase_ReplaceCell_16(GetCppThis(), cellId, npts, pts);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridBase_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridBase SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridBase vtkUnstructuredGridBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridBase_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridBase2 = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridBase2.Register(null);
			}
		}
		return vtkUnstructuredGridBase2;
	}
}
