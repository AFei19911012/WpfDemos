using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellLinks
/// </summary>
/// <remarks>
///    object represents upward pointers from points to list of cells using each point
///
/// vtkCellLinks is a supplemental object to vtkCellArray and vtkCellTypes,
/// enabling access from points to the cells using the points. vtkCellLinks is
/// a list of cell ids, each such link representing a dynamic list of cell ids
/// using the point. The information provided by this object can be used to
/// determine neighbors and construct other local topological information.
///
/// @warning
/// vtkCellLinks supports incremental (i.e., "editable") operations such as
/// inserting a new cell, or deleting a point. Because of this, it is less
/// memory efficient, and slower to construct and delete than static classes
/// such as vtkStaticCellLinks or vtkStaticCellLinksTemplate. However these
/// other classes are typically meant for one-time (static) construction.
///
/// </remarks>
/// <seealso>
///
/// vtkCellArray vtkCellTypes vtkStaticCellLinks vtkStaticCellLinksTemplate
/// </seealso>
public class vtkCellLinks : vtkAbstractCellLinks
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellLinks";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellLinks()
	{
		MRClassNameKey = "class vtkCellLinks";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLinks"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellLinks(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLinks_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print, and obtain type information.
	/// </summary>
	public new static vtkCellLinks New()
	{
		vtkCellLinks result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLinks_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods to instantiate, print, and obtain type information.
	/// </summary>
	public vtkCellLinks()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellLinks_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCellLinks_AddCellReference_01(HandleRef pThis, long cellId, long ptId);

	/// <summary>
	/// Add the reference to the cell (cellId) from the point (ptId). This
	/// adds a reference to the cellId from the cell list, but does not resize
	/// the list (extend memory with ResizeCellList(), if necessary).
	/// </summary>
	public void AddCellReference(long cellId, long ptId)
	{
		vtkCellLinks_AddCellReference_01(GetCppThis(), cellId, ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_Allocate_02(HandleRef pThis, long numLinks, long ext);

	/// <summary>
	/// Allocate the specified number of links (i.e., number of points) that
	/// will be built.
	/// </summary>
	public void Allocate(long numLinks, long ext)
	{
		vtkCellLinks_Allocate_02(GetCppThis(), numLinks, ext);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_BuildLinks_03(HandleRef pThis, HandleRef data);

	/// <summary>
	/// Build the link list array. All subclasses of vtkAbstractCellLinks
	/// must support this method.
	/// </summary>
	public override void BuildLinks(vtkDataSet data)
	{
		vtkCellLinks_BuildLinks_03(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_DeepCopy_04(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Standard DeepCopy method.  Since this object contains no reference
	/// to other objects, there is no ShallowCopy.
	/// </summary>
	public override void DeepCopy(vtkAbstractCellLinks src)
	{
		vtkCellLinks_DeepCopy_04(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_DeletePoint_05(HandleRef pThis, long ptId);

	/// <summary>
	/// Delete point (and storage) by destroying links to using cells.
	/// </summary>
	public void DeletePoint(long ptId)
	{
		vtkCellLinks_DeletePoint_05(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkCellLinks_GetActualMemorySize_06(HandleRef pThis);

	/// <summary>
	/// Return the memory in kibibytes (1024 bytes) consumed by this cell links array.
	/// Used to support streaming and reading/writing data. The value
	/// returned is guaranteed to be greater than or equal to the memory
	/// required to actually represent the data represented by this object.
	/// The information returned is valid only after the pipeline has
	/// been updated.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkCellLinks_GetActualMemorySize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLinks_GetCells_07(HandleRef pThis, long ptId);

	/// <summary>
	/// Return a list of cell ids using the point.
	/// </summary>
	public IntPtr GetCells(long ptId)
	{
		return vtkCellLinks_GetCells_07(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLinks_GetNcells_08(HandleRef pThis, long ptId);

	/// <summary>
	/// Get the number of cells using the point specified by ptId.
	/// </summary>
	public long GetNcells(long ptId)
	{
		return vtkCellLinks_GetNcells_08(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLinks_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print, and obtain type information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellLinks_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLinks_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard methods to instantiate, print, and obtain type information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellLinks_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_Initialize_11(HandleRef pThis);

	/// <summary>
	/// Clear out any previously allocated data structures
	/// </summary>
	public override void Initialize()
	{
		vtkCellLinks_Initialize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_InsertNextCellReference_12(HandleRef pThis, long ptId, long cellId);

	/// <summary>
	/// Insert a cell id into the list of cells (at the end) using the cell id
	/// provided. (Make sure to extend the link list (if necessary) using the
	/// method ResizeCellList().)
	/// </summary>
	public void InsertNextCellReference(long ptId, long cellId)
	{
		vtkCellLinks_InsertNextCellReference_12(GetCppThis(), ptId, cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellLinks_InsertNextPoint_13(HandleRef pThis, int numLinks);

	/// <summary>
	/// Insert a new point into the cell-links data structure. The size parameter
	/// is the initial size of the list.
	/// </summary>
	public long InsertNextPoint(int numLinks)
	{
		return vtkCellLinks_InsertNextPoint_13(GetCppThis(), numLinks);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLinks_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to instantiate, print, and obtain type information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellLinks_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellLinks_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods to instantiate, print, and obtain type information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellLinks_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLinks_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print, and obtain type information.
	/// </summary>
	public new vtkCellLinks NewInstance()
	{
		vtkCellLinks result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLinks_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_RemoveCellReference_18(HandleRef pThis, long cellId, long ptId);

	/// <summary>
	/// Delete the reference to the cell (cellId) from the point (ptId). This
	/// removes the reference to the cellId from the cell list, but does not
	/// resize the list (recover memory with ResizeCellList(), if necessary).
	/// </summary>
	public void RemoveCellReference(long cellId, long ptId)
	{
		vtkCellLinks_RemoveCellReference_18(GetCppThis(), cellId, ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_Reset_19(HandleRef pThis);

	/// <summary>
	/// Reset to a state of no entries without freeing the memory.
	/// </summary>
	public override void Reset()
	{
		vtkCellLinks_Reset_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_ResizeCellList_20(HandleRef pThis, long ptId, int size);

	/// <summary>
	/// Change the length of a point's link list (i.e., list of cells using a
	/// point) by the size specified.
	/// </summary>
	public void ResizeCellList(long ptId, int size)
	{
		vtkCellLinks_ResizeCellList_20(GetCppThis(), ptId, size);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellLinks_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to instantiate, print, and obtain type information.
	/// </summary>
	public new static vtkCellLinks SafeDownCast(vtkObjectBase o)
	{
		vtkCellLinks vtkCellLinks2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellLinks_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellLinks2 = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellLinks2.Register(null);
			}
		}
		return vtkCellLinks2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_SelectCells_22(HandleRef pThis, IntPtr minMaxDegree, IntPtr cellSelection);

	/// <summary>
	/// Select all cells with a point degree in the range [minDegree,maxDegree).
	/// The degree is the number of cells using a point. The selection is
	/// indicated through the provided unsigned char array, with a non-zero
	/// value indicates selection. The memory allocated for cellSelection must
	/// be the maximum cell id referenced in the links.
	/// </summary>
	public override void SelectCells(IntPtr minMaxDegree, IntPtr cellSelection)
	{
		vtkCellLinks_SelectCells_22(GetCppThis(), minMaxDegree, cellSelection);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellLinks_Squeeze_23(HandleRef pThis);

	/// <summary>
	/// Reclaim any unused memory.
	/// </summary>
	public override void Squeeze()
	{
		vtkCellLinks_Squeeze_23(GetCppThis());
	}
}
