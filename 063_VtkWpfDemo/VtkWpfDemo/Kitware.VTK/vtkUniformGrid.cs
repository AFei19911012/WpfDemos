using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUniformGrid
/// </summary>
/// <remarks>
///    image data with blanking
///
/// vtkUniformGrid is a subclass of vtkImageData. In addition to all
/// the image data functionality, it supports blanking.
/// </remarks>
/// 
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
public class vtkUniformGrid : vtkImageData
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUniformGrid()
	{
		MRClassNameKey = "class vtkUniformGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUniformGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an empty uniform grid.
	/// </summary>
	public new static vtkUniformGrid New()
	{
		vtkUniformGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an empty uniform grid.
	/// </summary>
	public vtkUniformGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUniformGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUniformGrid_BlankCell_01(HandleRef pThis, long ptId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// cells in the structured grid.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual void BlankCell(long ptId)
	{
		vtkUniformGrid_BlankCell_01(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_BlankCell_02(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// cells in the structured grid.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual void BlankCell(int i, int j, int k)
	{
		vtkUniformGrid_BlankCell_02(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_BlankPoint_03(HandleRef pThis, long ptId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// points in the structured grid, and hence the cells connected to them.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual void BlankPoint(long ptId)
	{
		vtkUniformGrid_BlankPoint_03(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_BlankPoint_04(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// points in the structured grid, and hence the cells connected to them.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual void BlankPoint(int i, int j, int k)
	{
		vtkUniformGrid_BlankPoint_04(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_CopyStructure_05(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Copy the geometric and topological structure of an input image data
	/// object.
	/// </summary>
	public override void CopyStructure(vtkDataSet ds)
	{
		vtkUniformGrid_CopyStructure_05(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_FindAndGetCell_06(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_FindAndGetCell_06(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGrid_FindCell_07(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkUniformGrid_FindCell_07(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGrid_FindCell_08(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkUniformGrid_FindCell_08(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), gencell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_GetCell_09(HandleRef pThis, int i, int j, int k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell GetCell(int i, int j, int k)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_GetCell_09(GetCppThis(), i, j, k, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_GetCell_10(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override vtkCell GetCell(long cellId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_GetCell_10(GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_GetCell_11(HandleRef pThis, long cellId, HandleRef cell);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCell(long cellId, vtkGenericCell cell)
	{
		vtkUniformGrid_GetCell_11(GetCppThis(), cellId, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_GetCellPoints_12(HandleRef pThis, long cellId, HandleRef ptIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetCellPoints(long cellId, vtkIdList ptIds)
	{
		vtkUniformGrid_GetCellPoints_12(GetCppThis(), cellId, ptIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGrid_GetCellType_13(HandleRef pThis, long cellId);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetCellType(long cellId)
	{
		return vtkUniformGrid_GetCellType_13(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_GetData_14(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkUniformGrid GetData(vtkInformation info)
	{
		vtkUniformGrid vtkUniformGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_GetData_14(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGrid2 = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGrid2.Register(null);
			}
		}
		return vtkUniformGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_GetData_15(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkUniformGrid GetData(vtkInformationVector v, int i)
	{
		vtkUniformGrid vtkUniformGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_GetData_15(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGrid2 = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGrid2.Register(null);
			}
		}
		return vtkUniformGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGrid_GetDataObjectType_16(HandleRef pThis);

	/// <summary>
	/// Return what type of dataset this is.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkUniformGrid_GetDataObjectType_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGrid_GetGridDescription_17(HandleRef pThis);

	/// <summary>
	/// Returns the data description of this uniform grid instance.
	/// </summary>
	public int GetGridDescription()
	{
		return vtkUniformGrid_GetGridDescription_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGrid_GetMaxCellSize_18(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkUniformGrid_GetMaxCellSize_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGrid_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	/// Construct an empty uniform grid.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUniformGrid_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGrid_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	/// Construct an empty uniform grid.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUniformGrid_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_GetPointCells_21(HandleRef pThis, long ptId, HandleRef cellIds);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void GetPointCells(long ptId, vtkIdList cellIds)
	{
		vtkUniformGrid_GetPointCells_21(GetCppThis(), ptId, cellIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniformGrid_HasAnyBlankCells_22(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there is any visibility constraint on the cells,
	/// 0 otherwise.
	/// </summary>
	public override bool HasAnyBlankCells()
	{
		return (vtkUniformGrid_HasAnyBlankCells_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniformGrid_HasAnyBlankPoints_23(HandleRef pThis);

	/// <summary>
	/// Returns 1 if there is any visibility constraint on the points,
	/// 0 otherwise.
	/// </summary>
	public override bool HasAnyBlankPoints()
	{
		return (vtkUniformGrid_HasAnyBlankPoints_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_Initialize_24(HandleRef pThis);

	/// <summary>
	/// Standard vtkDataSet API methods. See vtkDataSet for more information.
	/// </summary>
	public override void Initialize()
	{
		vtkUniformGrid_Initialize_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGrid_IsA_25(HandleRef pThis, string type);

	/// <summary>
	/// Construct an empty uniform grid.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUniformGrid_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniformGrid_IsCellVisible_26(HandleRef pThis, long cellId);

	/// <summary>
	/// Return non-zero value if specified cell is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public new virtual byte IsCellVisible(long cellId)
	{
		return vtkUniformGrid_IsCellVisible_26(GetCppThis(), cellId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniformGrid_IsPointVisible_27(HandleRef pThis, long pointId);

	/// <summary>
	/// Return non-zero value if specified point is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public new virtual byte IsPointVisible(long pointId)
	{
		return vtkUniformGrid_IsPointVisible_27(GetCppThis(), pointId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGrid_IsTypeOf_28(string type);

	/// <summary>
	/// Construct an empty uniform grid.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUniformGrid_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_NewImageDataCopy_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return non-zero value if specified cell is visible.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual vtkImageData NewImageDataCopy()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_NewImageDataCopy_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an empty uniform grid.
	/// </summary>
	public new vtkUniformGrid NewInstance()
	{
		vtkUniformGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGrid_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an empty uniform grid.
	/// </summary>
	public new static vtkUniformGrid SafeDownCast(vtkObjectBase o)
	{
		vtkUniformGrid vtkUniformGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGrid_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGrid2 = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGrid2.Register(null);
			}
		}
		return vtkUniformGrid2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_UnBlankCell_33(HandleRef pThis, long ptId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// cells in the structured grid.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual void UnBlankCell(long ptId)
	{
		vtkUniformGrid_UnBlankCell_33(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_UnBlankCell_34(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// cells in the structured grid.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual void UnBlankCell(int i, int j, int k)
	{
		vtkUniformGrid_UnBlankCell_34(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_UnBlankPoint_35(HandleRef pThis, long ptId);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// points in the structured grid, and hence the cells connected to them.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual void UnBlankPoint(long ptId)
	{
		vtkUniformGrid_UnBlankPoint_35(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGrid_UnBlankPoint_36(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Methods for supporting blanking of cells. Blanking turns on or off
	/// points in the structured grid, and hence the cells connected to them.
	/// These methods should be called only after the dimensions of the
	/// grid are set.
	/// </summary>
	public virtual void UnBlankPoint(int i, int j, int k)
	{
		vtkUniformGrid_UnBlankPoint_36(GetCppThis(), i, j, k);
	}
}
