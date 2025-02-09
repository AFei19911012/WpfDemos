using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellTypeSource
/// </summary>
/// <remarks>
///    Create cells of a given type
///
/// vtkCellTypeSource is a source object that creates cells of the given
/// input type. BlocksDimensions specifies the number of cell "blocks" in each
/// direction. A cell block may be divided into multiple cells based on
/// the chosen cell type (e.g. 6 pyramid cells make up a single cell block).
/// If a 1D cell is selected then only the first dimension is
/// used to specify how many cells are generated. If a 2D cell is
/// selected then only the first and second dimensions are used to
/// determine how many cells are created. The source respects pieces.
/// </remarks>
public class vtkCellTypeSource : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellTypeSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellTypeSource()
	{
		MRClassNameKey = "class vtkCellTypeSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellTypeSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellTypeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new static vtkCellTypeSource New()
	{
		vtkCellTypeSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTypeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellTypeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public vtkCellTypeSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellTypeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_CompleteQuadraticSimplicialElementsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get whether quadratic cells with simplicial shapes should be "completed".
	///
	/// By default, quadratic Lagrange cells with simplicial shapes
	/// do not completely span the basis of all polynomial of the maximal
	/// degree. This can be corrected by adding mid-face and body-centered
	/// nodes. Setting this option to true will generate cells with these
	/// additional nodes.
	///
	/// This is only used when
	/// (1) the cell type is a Lagrange triangle, tetrahedron, or wedge;
	/// and (2) \a CellOrder is set to 2 (quadratic elements).
	/// The default is false.
	///
	/// When true, generated
	/// (1) triangles will have 7 nodes instead of 6;
	/// (2) tetrahedra will have 15 nodes instead of 10;
	/// (3) wedges will have 21 nodes instead of 18.
	/// </summary>
	public virtual void CompleteQuadraticSimplicialElementsOff()
	{
		vtkCellTypeSource_CompleteQuadraticSimplicialElementsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_CompleteQuadraticSimplicialElementsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get whether quadratic cells with simplicial shapes should be "completed".
	///
	/// By default, quadratic Lagrange cells with simplicial shapes
	/// do not completely span the basis of all polynomial of the maximal
	/// degree. This can be corrected by adding mid-face and body-centered
	/// nodes. Setting this option to true will generate cells with these
	/// additional nodes.
	///
	/// This is only used when
	/// (1) the cell type is a Lagrange triangle, tetrahedron, or wedge;
	/// and (2) \a CellOrder is set to 2 (quadratic elements).
	/// The default is false.
	///
	/// When true, generated
	/// (1) triangles will have 7 nodes instead of 6;
	/// (2) tetrahedra will have 15 nodes instead of 10;
	/// (3) wedges will have 21 nodes instead of 18.
	/// </summary>
	public virtual void CompleteQuadraticSimplicialElementsOn()
	{
		vtkCellTypeSource_CompleteQuadraticSimplicialElementsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypeSource_GetBlocksDimensions_03(HandleRef pThis);

	/// <summary>
	/// Set the number of cells in each direction. If a 1D cell type is
	/// selected then only the first dimension is used and if a 2D cell
	/// type is selected then the first and second dimensions are used.
	/// Default is (1, 1, 1), which results in a single block of cells.
	/// </summary>
	public virtual int[] GetBlocksDimensions()
	{
		IntPtr intPtr = vtkCellTypeSource_GetBlocksDimensions_03(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_GetBlocksDimensions_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set the number of cells in each direction. If a 1D cell type is
	/// selected then only the first dimension is used and if a 2D cell
	/// type is selected then the first and second dimensions are used.
	/// Default is (1, 1, 1), which results in a single block of cells.
	/// </summary>
	public virtual void GetBlocksDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkCellTypeSource_GetBlocksDimensions_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_GetBlocksDimensions_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the number of cells in each direction. If a 1D cell type is
	/// selected then only the first dimension is used and if a 2D cell
	/// type is selected then the first and second dimensions are used.
	/// Default is (1, 1, 1), which results in a single block of cells.
	/// </summary>
	public virtual void GetBlocksDimensions(IntPtr _arg)
	{
		vtkCellTypeSource_GetBlocksDimensions_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetCellDimension_06(HandleRef pThis);

	/// <summary>
	/// Get the dimension of the cell blocks to be generated
	/// </summary>
	public int GetCellDimension()
	{
		return vtkCellTypeSource_GetCellDimension_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetCellOrder_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the order of Lagrange interpolation to be used.
	///
	/// This is only used when the cell type is a Lagrange element.
	/// The default is cubic (order 3).
	/// Lagrange elements are the same order along all axes
	/// (i.e., you cannot specify a different interpolation order
	/// for the i, j, and k axes of a hexahedron).
	/// </summary>
	public virtual int GetCellOrder()
	{
		return vtkCellTypeSource_GetCellOrder_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetCellType_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the type of cells to be generated.
	/// </summary>
	public virtual int GetCellType()
	{
		return vtkCellTypeSource_GetCellType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCellTypeSource_GetCompleteQuadraticSimplicialElements_09(HandleRef pThis);

	/// <summary>
	/// Set/Get whether quadratic cells with simplicial shapes should be "completed".
	///
	/// By default, quadratic Lagrange cells with simplicial shapes
	/// do not completely span the basis of all polynomial of the maximal
	/// degree. This can be corrected by adding mid-face and body-centered
	/// nodes. Setting this option to true will generate cells with these
	/// additional nodes.
	///
	/// This is only used when
	/// (1) the cell type is a Lagrange triangle, tetrahedron, or wedge;
	/// and (2) \a CellOrder is set to 2 (quadratic elements).
	/// The default is false.
	///
	/// When true, generated
	/// (1) triangles will have 7 nodes instead of 6;
	/// (2) tetrahedra will have 15 nodes instead of 10;
	/// (3) wedges will have 21 nodes instead of 18.
	/// </summary>
	public virtual bool GetCompleteQuadraticSimplicialElements()
	{
		return (vtkCellTypeSource_GetCompleteQuadraticSimplicialElements_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTypeSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellTypeSource_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellTypeSource_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellTypeSource_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetOutputPrecision_12(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION (0) - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION (1) - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPrecision()
	{
		return vtkCellTypeSource_GetOutputPrecision_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetOutputPrecisionMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION (0) - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION (1) - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPrecisionMaxValue()
	{
		return vtkCellTypeSource_GetOutputPrecisionMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetOutputPrecisionMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION (0) - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION (1) - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPrecisionMinValue()
	{
		return vtkCellTypeSource_GetOutputPrecisionMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetPolynomialFieldOrder_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the polynomial order of the "Polynomial" point field.
	/// The default is 1.
	/// </summary>
	public virtual int GetPolynomialFieldOrder()
	{
		return vtkCellTypeSource_GetPolynomialFieldOrder_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetPolynomialFieldOrderMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the polynomial order of the "Polynomial" point field.
	/// The default is 1.
	/// </summary>
	public virtual int GetPolynomialFieldOrderMaxValue()
	{
		return vtkCellTypeSource_GetPolynomialFieldOrderMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_GetPolynomialFieldOrderMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the polynomial order of the "Polynomial" point field.
	/// The default is 1.
	/// </summary>
	public virtual int GetPolynomialFieldOrderMinValue()
	{
		return vtkCellTypeSource_GetPolynomialFieldOrderMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellTypeSource_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellTypeSource_IsTypeOf_19(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellTypeSource_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypeSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new vtkCellTypeSource NewInstance()
	{
		vtkCellTypeSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTypeSource_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellTypeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellTypeSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type and printing instance values.
	/// </summary>
	public new static vtkCellTypeSource SafeDownCast(vtkObjectBase o)
	{
		vtkCellTypeSource vtkCellTypeSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellTypeSource_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellTypeSource2 = (vtkCellTypeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellTypeSource2.Register(null);
			}
		}
		return vtkCellTypeSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_SetBlocksDimensions_23(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Set the number of cells in each direction. If a 1D cell type is
	/// selected then only the first dimension is used and if a 2D cell
	/// type is selected then the first and second dimensions are used.
	/// Default is (1, 1, 1), which results in a single block of cells.
	/// </summary>
	public void SetBlocksDimensions(IntPtr arg0)
	{
		vtkCellTypeSource_SetBlocksDimensions_23(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_SetBlocksDimensions_24(HandleRef pThis, int arg0, int arg1, int arg2);

	/// <summary>
	/// Set the number of cells in each direction. If a 1D cell type is
	/// selected then only the first dimension is used and if a 2D cell
	/// type is selected then the first and second dimensions are used.
	/// Default is (1, 1, 1), which results in a single block of cells.
	/// </summary>
	public void SetBlocksDimensions(int arg0, int arg1, int arg2)
	{
		vtkCellTypeSource_SetBlocksDimensions_24(GetCppThis(), arg0, arg1, arg2);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_SetCellOrder_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the order of Lagrange interpolation to be used.
	///
	/// This is only used when the cell type is a Lagrange element.
	/// The default is cubic (order 3).
	/// Lagrange elements are the same order along all axes
	/// (i.e., you cannot specify a different interpolation order
	/// for the i, j, and k axes of a hexahedron).
	/// </summary>
	public virtual void SetCellOrder(int _arg)
	{
		vtkCellTypeSource_SetCellOrder_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_SetCellType_26(HandleRef pThis, int cellType);

	/// <summary>
	/// Set/Get the type of cells to be generated.
	/// </summary>
	public void SetCellType(int cellType)
	{
		vtkCellTypeSource_SetCellType_26(GetCppThis(), cellType);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_SetCompleteQuadraticSimplicialElements_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get whether quadratic cells with simplicial shapes should be "completed".
	///
	/// By default, quadratic Lagrange cells with simplicial shapes
	/// do not completely span the basis of all polynomial of the maximal
	/// degree. This can be corrected by adding mid-face and body-centered
	/// nodes. Setting this option to true will generate cells with these
	/// additional nodes.
	///
	/// This is only used when
	/// (1) the cell type is a Lagrange triangle, tetrahedron, or wedge;
	/// and (2) \a CellOrder is set to 2 (quadratic elements).
	/// The default is false.
	///
	/// When true, generated
	/// (1) triangles will have 7 nodes instead of 6;
	/// (2) tetrahedra will have 15 nodes instead of 10;
	/// (3) wedges will have 21 nodes instead of 18.
	/// </summary>
	public virtual void SetCompleteQuadraticSimplicialElements(bool _arg)
	{
		vtkCellTypeSource_SetCompleteQuadraticSimplicialElements_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_SetOutputPrecision_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION (0) - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION (1) - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPrecision(int _arg)
	{
		vtkCellTypeSource_SetOutputPrecision_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellTypeSource_SetPolynomialFieldOrder_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the polynomial order of the "Polynomial" point field.
	/// The default is 1.
	/// </summary>
	public virtual void SetPolynomialFieldOrder(int _arg)
	{
		vtkCellTypeSource_SetPolynomialFieldOrder_29(GetCppThis(), _arg);
	}
}
