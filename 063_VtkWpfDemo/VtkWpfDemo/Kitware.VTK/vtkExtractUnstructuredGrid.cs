using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractUnstructuredGrid
/// </summary>
/// <remarks>
///    extract subset of unstructured grid geometry
///
/// vtkExtractUnstructuredGrid is a general-purpose filter to
/// extract geometry (and associated data) from an unstructured grid
/// dataset. The extraction process is controlled by specifying a range
/// of point ids, cell ids, or a bounding box (referred to as "Extent").
/// Those cells laying within these regions are sent to the output.
/// The user has the choice of merging coincident points (Merging is on)
/// or using the original point set (Merging is off).
///
/// @warning
/// If merging is off, the input points are copied through to the
/// output. This means unused points may be present in the output data.
/// If merging is on, then coincident points with different point attribute
/// values are merged.
///
/// </remarks>
/// <seealso>
///
/// vtkImageDataGeometryFilter vtkStructuredGridGeometryFilter
/// vtkRectilinearGridGeometryFilter
/// vtkExtractGeometry vtkExtractVOI
/// </seealso>
public class vtkExtractUnstructuredGrid : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractUnstructuredGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractUnstructuredGrid()
	{
		MRClassNameKey = "class vtkExtractUnstructuredGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractUnstructuredGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with all types of clipping turned off.
	/// </summary>
	public new static vtkExtractUnstructuredGrid New()
	{
		vtkExtractUnstructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractUnstructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with all types of clipping turned off.
	/// </summary>
	public vtkExtractUnstructuredGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractUnstructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkExtractUnstructuredGrid_CellClippingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void CellClippingOff()
	{
		vtkExtractUnstructuredGrid_CellClippingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_CellClippingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void CellClippingOn()
	{
		vtkExtractUnstructuredGrid_CellClippingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_CreateDefaultLocator_03(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkExtractUnstructuredGrid_CreateDefaultLocator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_ExtentClippingOff_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void ExtentClippingOff()
	{
		vtkExtractUnstructuredGrid_ExtentClippingOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_ExtentClippingOn_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void ExtentClippingOn()
	{
		vtkExtractUnstructuredGrid_ExtentClippingOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractUnstructuredGrid_GetCellClipping_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual int GetCellClipping()
	{
		return vtkExtractUnstructuredGrid_GetCellClipping_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetCellMaximum_07(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximum()
	{
		return vtkExtractUnstructuredGrid_GetCellMaximum_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetCellMaximumMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximumMaxValue()
	{
		return vtkExtractUnstructuredGrid_GetCellMaximumMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetCellMaximumMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximumMinValue()
	{
		return vtkExtractUnstructuredGrid_GetCellMaximumMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetCellMinimum_10(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimum()
	{
		return vtkExtractUnstructuredGrid_GetCellMinimum_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetCellMinimumMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimumMaxValue()
	{
		return vtkExtractUnstructuredGrid_GetCellMinimumMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetCellMinimumMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimumMinValue()
	{
		return vtkExtractUnstructuredGrid_GetCellMinimumMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractUnstructuredGrid_GetExtent_13(HandleRef pThis);

	/// <summary>
	/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public double[] GetExtent()
	{
		IntPtr intPtr = vtkExtractUnstructuredGrid_GetExtent_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractUnstructuredGrid_GetExtentClipping_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual int GetExtentClipping()
	{
		return vtkExtractUnstructuredGrid_GetExtentClipping_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractUnstructuredGrid_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractUnstructuredGrid_GetLocator_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalPointLocator2 = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalPointLocator2.Register(null);
			}
		}
		return vtkIncrementalPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExtractUnstructuredGrid_GetMTime_16(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExtractUnstructuredGrid_GetMTime_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractUnstructuredGrid_GetMerging_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual int GetMerging()
	{
		return vtkExtractUnstructuredGrid_GetMerging_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractUnstructuredGrid_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractUnstructuredGrid_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractUnstructuredGrid_GetPointClipping_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual int GetPointClipping()
	{
		return vtkExtractUnstructuredGrid_GetPointClipping_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetPointMaximum_21(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximum()
	{
		return vtkExtractUnstructuredGrid_GetPointMaximum_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetPointMaximumMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximumMaxValue()
	{
		return vtkExtractUnstructuredGrid_GetPointMaximumMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetPointMaximumMinValue_23(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximumMinValue()
	{
		return vtkExtractUnstructuredGrid_GetPointMaximumMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetPointMinimum_24(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimum()
	{
		return vtkExtractUnstructuredGrid_GetPointMinimum_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetPointMinimumMaxValue_25(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimumMaxValue()
	{
		return vtkExtractUnstructuredGrid_GetPointMinimumMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractUnstructuredGrid_GetPointMinimumMinValue_26(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimumMinValue()
	{
		return vtkExtractUnstructuredGrid_GetPointMinimumMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractUnstructuredGrid_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractUnstructuredGrid_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractUnstructuredGrid_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractUnstructuredGrid_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_MergingOff_29(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void MergingOff()
	{
		vtkExtractUnstructuredGrid_MergingOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_MergingOn_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void MergingOn()
	{
		vtkExtractUnstructuredGrid_MergingOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractUnstructuredGrid_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractUnstructuredGrid NewInstance()
	{
		vtkExtractUnstructuredGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractUnstructuredGrid_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_PointClippingOff_33(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void PointClippingOff()
	{
		vtkExtractUnstructuredGrid_PointClippingOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_PointClippingOn_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void PointClippingOn()
	{
		vtkExtractUnstructuredGrid_PointClippingOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractUnstructuredGrid_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractUnstructuredGrid SafeDownCast(vtkObjectBase o)
	{
		vtkExtractUnstructuredGrid vtkExtractUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractUnstructuredGrid_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractUnstructuredGrid2 = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractUnstructuredGrid2.Register(null);
			}
		}
		return vtkExtractUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetCellClipping_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void SetCellClipping(int _arg)
	{
		vtkExtractUnstructuredGrid_SetCellClipping_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetCellMaximum_37(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual void SetCellMaximum(long _arg)
	{
		vtkExtractUnstructuredGrid_SetCellMaximum_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetCellMinimum_38(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual void SetCellMinimum(long _arg)
	{
		vtkExtractUnstructuredGrid_SetCellMinimum_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetExtent_39(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Specify a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkExtractUnstructuredGrid_SetExtent_39(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetExtent_40(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkExtractUnstructuredGrid_SetExtent_40(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetExtentClipping_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void SetExtentClipping(int _arg)
	{
		vtkExtractUnstructuredGrid_SetExtentClipping_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetLocator_42(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkExtractUnstructuredGrid_SetLocator_42(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetMerging_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void SetMerging(int _arg)
	{
		vtkExtractUnstructuredGrid_SetMerging_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetPointClipping_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void SetPointClipping(int _arg)
	{
		vtkExtractUnstructuredGrid_SetPointClipping_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetPointMaximum_45(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual void SetPointMaximum(long _arg)
	{
		vtkExtractUnstructuredGrid_SetPointMaximum_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractUnstructuredGrid_SetPointMinimum_46(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual void SetPointMinimum(long _arg)
	{
		vtkExtractUnstructuredGrid_SetPointMinimum_46(GetCppThis(), _arg);
	}
}
