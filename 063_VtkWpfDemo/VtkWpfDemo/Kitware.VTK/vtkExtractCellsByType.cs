using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractCellsByType
/// </summary>
/// <remarks>
///    extract cells of a specified type
///
///
/// Given an input vtkDataSet and a list of cell types, produce an output
/// dataset containing only cells of the specified type(s). Note that if the
/// input dataset is homogeneous (e.g., all cells are of the same type) and
/// the cell type is one of the cells specified, then the input dataset is
/// shallow copied to the output.
///
/// The type of output dataset is always the same as the input type. Since
/// structured types of data (i.e., vtkImageData, vtkStructuredGrid,
/// vtkRectilnearGrid, vtkUniformGrid) are all composed of a cell of the same
/// type, the output is either empty, or a shallow copy of the
/// input. Unstructured data (vtkUnstructuredGrid, vtkPolyData) input may
/// produce a subset of the input data (depending on the selected cell types).
///
/// Note this filter can be used in a pipeline with composite datasets to
/// extract blocks of (a) particular cell type(s).
///
/// @warning
/// Unlike the filter vtkExtractCells which always produces
/// vtkUnstructuredGrid output, this filter produces the same output type as
/// input type (i.e., it is a vtkDataSetAlgorithm). Also, vtkExtractCells
/// extracts cells based on their ids.
///
/// </remarks>
/// <seealso>
///
/// vtkExtractBlock vtkExtractCells
/// </seealso>
public class vtkExtractCellsByType : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCellsByType";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractCellsByType()
	{
		MRClassNameKey = "class vtkExtractCellsByType";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCellsByType"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractCellsByType(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCellsByType_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtkExtractCellsByType New()
	{
		vtkExtractCellsByType result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCellsByType_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractCellsByType)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public vtkExtractCellsByType()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractCellsByType_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractCellsByType_AddAllCellTypes_01(HandleRef pThis);

	/// <summary>
	/// Specify the cell types to extract. Any cells of the type specified are
	/// extracted. Methods for clearing the set of cells, adding all cells, and
	/// determining if a cell is in the set are also provided.
	/// </summary>
	public void AddAllCellTypes()
	{
		vtkExtractCellsByType_AddAllCellTypes_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCellsByType_AddCellType_02(HandleRef pThis, uint type);

	/// <summary>
	/// Specify the cell types to extract. Any cells of the type specified are
	/// extracted. Methods for clearing the set of cells, adding all cells, and
	/// determining if a cell is in the set are also provided.
	/// </summary>
	public void AddCellType(uint type)
	{
		vtkExtractCellsByType_AddCellType_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractCellsByType_ExtractCellType_03(HandleRef pThis, uint type);

	/// <summary>
	/// Specify the cell types to extract. Any cells of the type specified are
	/// extracted. Methods for clearing the set of cells, adding all cells, and
	/// determining if a cell is in the set are also provided.
	/// </summary>
	public bool ExtractCellType(uint type)
	{
		return (vtkExtractCellsByType_ExtractCellType_03(GetCppThis(), type) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractCellsByType_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractCellsByType_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractCellsByType_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractCellsByType_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCellsByType_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractCellsByType_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractCellsByType_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractCellsByType_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCellsByType_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new vtkExtractCellsByType NewInstance()
	{
		vtkExtractCellsByType result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCellsByType_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractCellsByType)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCellsByType_RemoveAllCellTypes_10(HandleRef pThis);

	/// <summary>
	/// Specify the cell types to extract. Any cells of the type specified are
	/// extracted. Methods for clearing the set of cells, adding all cells, and
	/// determining if a cell is in the set are also provided.
	/// </summary>
	public void RemoveAllCellTypes()
	{
		vtkExtractCellsByType_RemoveAllCellTypes_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractCellsByType_RemoveCellType_11(HandleRef pThis, uint type);

	/// <summary>
	/// Specify the cell types to extract. Any cells of the type specified are
	/// extracted. Methods for clearing the set of cells, adding all cells, and
	/// determining if a cell is in the set are also provided.
	/// </summary>
	public void RemoveCellType(uint type)
	{
		vtkExtractCellsByType_RemoveCellType_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractCellsByType_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for construction, type info, and printing.
	/// </summary>
	public new static vtkExtractCellsByType SafeDownCast(vtkObjectBase o)
	{
		vtkExtractCellsByType vtkExtractCellsByType2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractCellsByType_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractCellsByType2 = (vtkExtractCellsByType)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractCellsByType2.Register(null);
			}
		}
		return vtkExtractCellsByType2;
	}
}
