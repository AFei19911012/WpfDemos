using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointSet
/// </summary>
/// <remarks>
///    concrete class for storing a set of points
///
/// vtkPointSet is an concrete class representing a set of points
/// that specifies the interface for
/// datasets that explicitly use "point" arrays to represent geometry.
/// For example, vtkPolyData, vtkUnstructuredGrid, and vtkStructuredGrid
/// require point arrays to specify point positions, while vtkImageData
/// represents point positions implicitly (and hence is not a subclass
/// of vtkImageData).
///
/// Note: The vtkPolyData and vtkUnstructuredGrid datasets (derived classes of
/// vtkPointSet) are often used in geometric computation (e.g.,
/// vtkDelaunay2D).  In most cases during filter execution the output geometry
/// and/or topology is created once and provided as output; however in a very
/// few cases the underlying geometry/topology may be created and then
/// incrementally modified. This has implications on the use of supporting
/// classes like locators and cell links topological structures which may be
/// required to support incremental editing operations. Consequently, there is
/// a flag, Editable, that controls whether the dataset can be incrementally
/// edited after it is initially created. By default, and for performance
/// reasons, vtkPointSet derived classes are created as non-editable.  The few
/// methods that require incremental editing capabilities are documented in
/// derived classes.
///
/// Another important feature of vtkPointSet classes is the use of an internal
/// locator to speed up certain operations like FindCell(). Depending on the
/// application and desired performance, different locators (either a cell or
/// point locator) of different locator types may be used, along with different
/// strategies for using the locators to perform various operations. See
/// the class vtkFindCellStrategy for more information
///
/// </remarks>
/// <seealso>
///
/// vtkPolyData vtkStructuredGrid vtkUnstructuredGrid vtkFindCellStrategy
/// </seealso>
public class vtkPointSet : vtkDataSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointSet()
	{
		MRClassNameKey = "class vtkPointSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation method.
	/// </summary>
	public new static vtkPointSet New()
	{
		vtkPointSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard instantiation method.
	/// </summary>
	public vtkPointSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointSet_BuildCellLocator_01(HandleRef pThis);

	/// <summary>
	/// Build the cell locator. In a multi-threaded environment,
	/// call this method in a single thread before using FindCell().
	/// </summary>
	public void BuildCellLocator()
	{
		vtkPointSet_BuildCellLocator_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_BuildLocator_02(HandleRef pThis);

	/// <summary>
	/// Build the internal point locator . In a multi-threaded environment, call
	/// this method in a single thread before using FindCell() or FindPoint().
	/// </summary>
	public void BuildLocator()
	{
		vtkPointSet_BuildLocator_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_BuildPointLocator_03(HandleRef pThis);

	/// <summary>
	/// Build the internal point locator . In a multi-threaded environment, call
	/// this method in a single thread before using FindCell() or FindPoint().
	/// </summary>
	public void BuildPointLocator()
	{
		vtkPointSet_BuildPointLocator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_ComputeBounds_04(HandleRef pThis);

	/// <summary>
	/// Compute the (X, Y, Z)  bounds of the data.
	/// </summary>
	public override void ComputeBounds()
	{
		vtkPointSet_ComputeBounds_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_CopyStructure_05(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Copy the geometric structure of an input point set object.
	/// </summary>
	public override void CopyStructure(vtkDataSet pd)
	{
		vtkPointSet_CopyStructure_05(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_DeepCopy_06(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkPointSet_DeepCopy_06(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_EditableOff_07(HandleRef pThis);

	/// <summary>
	/// Specify whether this dataset is editable after creation. Meaning, once
	/// the points and cells are defined, can the dataset be incrementally
	/// modified. By default, this dataset is non-editable (i.e., "static")
	/// after construction. The reason for this is performance: cell links and
	/// locators can be built (and destroyed) much faster is it is known that
	/// the data is static (see vtkStaticCellLinks, vtkStaticPointLocator,
	/// vtkStaticCellLocator).
	/// </summary>
	public virtual void EditableOff()
	{
		vtkPointSet_EditableOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_EditableOn_08(HandleRef pThis);

	/// <summary>
	/// Specify whether this dataset is editable after creation. Meaning, once
	/// the points and cells are defined, can the dataset be incrementally
	/// modified. By default, this dataset is non-editable (i.e., "static")
	/// after construction. The reason for this is performance: cell links and
	/// locators can be built (and destroyed) much faster is it is known that
	/// the data is static (see vtkStaticCellLinks, vtkStaticPointLocator,
	/// vtkStaticCellLocator).
	/// </summary>
	public virtual void EditableOn()
	{
		vtkPointSet_EditableOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_ExtendedNew_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation method.
	/// </summary>
	public static vtkPointSet ExtendedNew()
	{
		vtkPointSet vtkPointSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_ExtendedNew_09(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSet2 = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSet2.Register(null);
			}
		}
		return vtkPointSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_FindCell_10(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// See vtkDataSet for additional information.
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkPointSet_FindCell_10(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_FindCell_11(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

	/// <summary>
	/// See vtkDataSet for additional information.
	/// </summary>
	public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
	{
		return vtkPointSet_FindCell_11(GetCppThis(), x, cell?.GetCppThis() ?? default(HandleRef), gencell?.GetCppThis() ?? default(HandleRef), cellId, tol2, ref subId, pcoords, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_FindPoint_12(HandleRef pThis, IntPtr x);

	/// <summary>
	/// See vtkDataSet for additional information.
	/// </summary>
	public override long FindPoint(IntPtr x)
	{
		return vtkPointSet_FindPoint_12(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_FindPoint_13(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// See vtkDataSet for additional information.
	/// </summary>
	public new long FindPoint(double x, double y, double z)
	{
		return vtkPointSet_FindPoint_13(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPointSet_GetActualMemorySize_14(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated. The memory size
	/// returned is guaranteed to be greater than or equal to the
	/// memory required to represent the data (e.g., extra space in
	/// arrays, etc. are not included in the return value). THIS METHOD
	/// IS THREAD SAFE.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkPointSet_GetActualMemorySize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_GetCell_15(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This method always return a `vtkEmptyCell`, as there is no cell in a
	/// `vtkPointSet`.
	/// </summary>
	public override vtkCell GetCell(long arg0)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_GetCell_15(GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointSet_GetCell_16(HandleRef pThis, long arg0, HandleRef cell);

	/// <summary>
	/// This method sets cell to be an empty cell.
	/// </summary>
	public override void GetCell(long arg0, vtkGenericCell cell)
	{
		vtkPointSet_GetCell_16(GetCppThis(), arg0, cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_GetCellLocator_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get an instance of vtkAbstractCellLocator which may be used
	/// when a vtkCellLocatorStrategy is used during a FindCell() operation.
	/// </summary>
	public virtual vtkAbstractCellLocator GetCellLocator()
	{
		vtkAbstractCellLocator vtkAbstractCellLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_GetCellLocator_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractCellLocator2 = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractCellLocator2.Register(null);
			}
		}
		return vtkAbstractCellLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_GetCellPoints_18(HandleRef pThis, long arg0, HandleRef idList);

	/// <summary>
	/// This method resets parameter idList, as there is no cell in a `vtkPointSet`.
	/// </summary>
	public override void GetCellPoints(long arg0, vtkIdList idList)
	{
		vtkPointSet_GetCellPoints_18(GetCppThis(), arg0, idList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_GetCellSize_19(HandleRef pThis, long arg0);

	/// <summary>
	/// This method always returns 1, as all cells are point in a pure
	/// `vtkPointSet`.
	/// </summary>
	public override long GetCellSize(long arg0)
	{
		return vtkPointSet_GetCellSize_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSet_GetCellType_20(HandleRef pThis, long arg0);

	/// <summary>
	/// This method always returns `VTK_EMPTY_CELL`, as there is no cell in a
	/// `vtkPointSet`.
	/// </summary>
	public override int GetCellType(long arg0)
	{
		return vtkPointSet_GetCellType_20(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_GetData_21(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPointSet GetData(vtkInformation info)
	{
		vtkPointSet vtkPointSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_GetData_21(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSet2 = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSet2.Register(null);
			}
		}
		return vtkPointSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_GetData_22(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPointSet GetData(vtkInformationVector v, int i)
	{
		vtkPointSet vtkPointSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_GetData_22(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSet2 = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSet2.Register(null);
			}
		}
		return vtkPointSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSet_GetEditable_23(HandleRef pThis);

	/// <summary>
	/// Specify whether this dataset is editable after creation. Meaning, once
	/// the points and cells are defined, can the dataset be incrementally
	/// modified. By default, this dataset is non-editable (i.e., "static")
	/// after construction. The reason for this is performance: cell links and
	/// locators can be built (and destroyed) much faster is it is known that
	/// the data is static (see vtkStaticCellLinks, vtkStaticPointLocator,
	/// vtkStaticCellLocator).
	/// </summary>
	public virtual bool GetEditable()
	{
		return (vtkPointSet_GetEditable_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPointSet_GetMTime_24(HandleRef pThis);

	/// <summary>
	/// Get MTime which also considers its vtkPoints MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkPointSet_GetMTime_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSet_GetMaxCellSize_25(HandleRef pThis);

	/// <summary>
	/// This method always returns 0, as there are no cells in a `vtkPointSet`.
	/// </summary>
	public override int GetMaxCellSize()
	{
		return vtkPointSet_GetMaxCellSize_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_GetNumberOfCells_26(HandleRef pThis);

	/// <summary>
	/// This method always returns 0, as there are no cells in a `vtkPointSet`.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkPointSet_GetNumberOfCells_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_GetNumberOfGenerationsFromBase_27(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointSet_GetNumberOfGenerationsFromBase_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_GetNumberOfGenerationsFromBaseType_28(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointSet_GetNumberOfGenerationsFromBaseType_28(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSet_GetNumberOfPoints_29(HandleRef pThis);

	/// <summary>
	/// See vtkDataSet for additional information.
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkPointSet_GetNumberOfPoints_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_GetPoint_30(HandleRef pThis, long ptId, IntPtr x);

	/// <summary>
	/// See vtkDataSet for additional information.
	/// </summary>
	public override void GetPoint(long ptId, IntPtr x)
	{
		vtkPointSet_GetPoint_30(GetCppThis(), ptId, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_GetPoint_31(HandleRef pThis, long ptId);

	/// <summary>
	/// See vtkDataSet for additional information.
	/// WARNING: Just don't use this error-prone method, the returned pointer
	/// and its values are only valid as long as another method invocation is not
	/// performed. Prefer GetPoint() with the return value in argument.
	/// </summary>
	public override double[] GetPoint(long ptId)
	{
		IntPtr intPtr = vtkPointSet_GetPoint_31(GetCppThis(), ptId);
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_GetPointCells_32(HandleRef pThis, long arg0, HandleRef idList);

	/// <summary>
	/// This method resets parameter idList, as there is no cell in a `vtkPointSet`.
	/// </summary>
	public override void GetPointCells(long arg0, vtkIdList idList)
	{
		vtkPointSet_GetPointCells_32(GetCppThis(), arg0, idList?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_GetPointLocator_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get an instance of vtkAbstractPointLocator which is used to
	/// support the FindPoint() and FindCell() methods. By default a
	/// vtkStaticPointLocator is used, unless the class is set as Editable, in
	/// which case a vtkPointLocator is used.
	/// </summary>
	public virtual vtkAbstractPointLocator GetPointLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_GetPointLocator_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_GetPoints_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify point array to define point coordinates.
	/// </summary>
	public virtual vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_GetPoints_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointSet_Initialize_35(HandleRef pThis);

	/// <summary>
	/// Reset to an empty state and free any memory.
	/// </summary>
	public override void Initialize()
	{
		vtkPointSet_Initialize_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSet_IsA_36(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointSet_IsA_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSet_IsTypeOf_37(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointSet_IsTypeOf_37(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_NewCellIterator_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return an iterator that traverses the cells in this data set.
	/// </summary>
	public override vtkCellIterator NewCellIterator()
	{
		vtkCellIterator vtkCellIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_NewCellIterator_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkPointSet NewInstance()
	{
		vtkPointSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSet_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkPointSet SafeDownCast(vtkObjectBase o)
	{
		vtkPointSet vtkPointSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSet_SafeDownCast_41(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSet2 = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSet2.Register(null);
			}
		}
		return vtkPointSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_SetCellLocator_42(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get an instance of vtkAbstractCellLocator which may be used
	/// when a vtkCellLocatorStrategy is used during a FindCell() operation.
	/// </summary>
	public virtual void SetCellLocator(vtkAbstractCellLocator arg0)
	{
		vtkPointSet_SetCellLocator_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_SetEditable_43(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether this dataset is editable after creation. Meaning, once
	/// the points and cells are defined, can the dataset be incrementally
	/// modified. By default, this dataset is non-editable (i.e., "static")
	/// after construction. The reason for this is performance: cell links and
	/// locators can be built (and destroyed) much faster is it is known that
	/// the data is static (see vtkStaticCellLinks, vtkStaticPointLocator,
	/// vtkStaticCellLocator).
	/// </summary>
	public virtual void SetEditable(bool _arg)
	{
		vtkPointSet_SetEditable_43(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_SetPointLocator_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get an instance of vtkAbstractPointLocator which is used to
	/// support the FindPoint() and FindCell() methods. By default a
	/// vtkStaticPointLocator is used, unless the class is set as Editable, in
	/// which case a vtkPointLocator is used.
	/// </summary>
	public virtual void SetPointLocator(vtkAbstractPointLocator arg0)
	{
		vtkPointSet_SetPointLocator_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_SetPoints_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify point array to define point coordinates.
	/// </summary>
	public virtual void SetPoints(vtkPoints arg0)
	{
		vtkPointSet_SetPoints_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_ShallowCopy_46(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkPointSet_ShallowCopy_46(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSet_Squeeze_47(HandleRef pThis);

	/// <summary>
	/// Reclaim any unused memory.
	/// </summary>
	public override void Squeeze()
	{
		vtkPointSet_Squeeze_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSet_UsesGarbageCollector_48(HandleRef pThis);

	/// <summary>
	/// Overwritten to handle the data/locator loop
	/// </summary>
	public override bool UsesGarbageCollector()
	{
		return (vtkPointSet_UsesGarbageCollector_48(GetCppThis()) != 0) ? true : false;
	}
}
