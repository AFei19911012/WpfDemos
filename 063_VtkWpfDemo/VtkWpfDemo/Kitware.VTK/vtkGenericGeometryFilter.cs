using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericGeometryFilter
/// </summary>
/// <remarks>
///    extract geometry from data (or convert data to polygonal type)
///
/// vtkGenericGeometryFilter is a general-purpose filter to extract geometry (and
/// associated data) from any type of dataset. Geometry is obtained as
/// follows: all 0D, 1D, and 2D cells are extracted. All 2D faces that are
/// used by only one 3D cell (i.e., boundary faces) are extracted. It also is
/// possible to specify conditions on point ids, cell ids, and on
/// bounding box (referred to as "Extent") to control the extraction process.
///
/// This filter also may be used to convert any type of data to polygonal
/// type. The conversion process may be less than satisfactory for some 3D
/// datasets. For example, this filter will extract the outer surface of a
/// volume or structured grid dataset. (For structured data you may want to
/// use vtkImageDataGeometryFilter, vtkStructuredGridGeometryFilter,
/// vtkExtractUnstructuredGrid, vtkRectilinearGridGeometryFilter, or
/// vtkExtractVOI.)
///
/// @warning
/// When vtkGenericGeometryFilter extracts cells (or boundaries of cells) it
/// will (by default) merge duplicate vertices. This may cause problems
/// in some cases. For example, if you've run vtkPolyDataNormals to
/// generate normals, which may split meshes and create duplicate
/// vertices, vtkGenericGeometryFilter will merge these points back
/// together. Turn merging off to prevent this from occurring.
///
/// </remarks>
/// <seealso>
///
/// vtkImageDataGeometryFilter vtkStructuredGridGeometryFilter
/// vtkExtractGeometry vtkExtractVOI
/// </seealso>
public class vtkGenericGeometryFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericGeometryFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericGeometryFilter()
	{
		MRClassNameKey = "class vtkGenericGeometryFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericGeometryFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericGeometryFilter New()
	{
		vtkGenericGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGenericGeometryFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenericGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_CellClippingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void CellClippingOff()
	{
		vtkGenericGeometryFilter_CellClippingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_CellClippingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void CellClippingOn()
	{
		vtkGenericGeometryFilter_CellClippingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_CreateDefaultLocator_03(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkGenericGeometryFilter_CreateDefaultLocator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_ExtentClippingOff_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void ExtentClippingOff()
	{
		vtkGenericGeometryFilter_ExtentClippingOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_ExtentClippingOn_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void ExtentClippingOn()
	{
		vtkGenericGeometryFilter_ExtentClippingOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGeometryFilter_GetCellClipping_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual int GetCellClipping()
	{
		return vtkGenericGeometryFilter_GetCellClipping_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetCellMaximum_07(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximum()
	{
		return vtkGenericGeometryFilter_GetCellMaximum_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetCellMaximumMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximumMaxValue()
	{
		return vtkGenericGeometryFilter_GetCellMaximumMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetCellMaximumMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximumMinValue()
	{
		return vtkGenericGeometryFilter_GetCellMaximumMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetCellMinimum_10(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimum()
	{
		return vtkGenericGeometryFilter_GetCellMinimum_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetCellMinimumMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimumMaxValue()
	{
		return vtkGenericGeometryFilter_GetCellMinimumMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetCellMinimumMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimumMinValue()
	{
		return vtkGenericGeometryFilter_GetCellMinimumMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGeometryFilter_GetExtent_13(HandleRef pThis);

	/// <summary>
	/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public IntPtr GetExtent()
	{
		return vtkGenericGeometryFilter_GetExtent_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGeometryFilter_GetExtentClipping_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual int GetExtentClipping()
	{
		return vtkGenericGeometryFilter_GetExtentClipping_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGeometryFilter_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkGenericGeometryFilter_GetLocator_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkGenericGeometryFilter_GetMTime_16(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkGenericGeometryFilter_GetMTime_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGeometryFilter_GetMerging_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual int GetMerging()
	{
		return vtkGenericGeometryFilter_GetMerging_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericGeometryFilter_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericGeometryFilter_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGeometryFilter_GetPassThroughCellIds_20(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughCellIds()
	{
		return vtkGenericGeometryFilter_GetPassThroughCellIds_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGeometryFilter_GetPointClipping_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual int GetPointClipping()
	{
		return vtkGenericGeometryFilter_GetPointClipping_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetPointMaximum_22(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximum()
	{
		return vtkGenericGeometryFilter_GetPointMaximum_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetPointMaximumMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximumMaxValue()
	{
		return vtkGenericGeometryFilter_GetPointMaximumMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetPointMaximumMinValue_24(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximumMinValue()
	{
		return vtkGenericGeometryFilter_GetPointMaximumMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetPointMinimum_25(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimum()
	{
		return vtkGenericGeometryFilter_GetPointMinimum_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetPointMinimumMaxValue_26(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimumMaxValue()
	{
		return vtkGenericGeometryFilter_GetPointMinimumMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericGeometryFilter_GetPointMinimumMinValue_27(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimumMinValue()
	{
		return vtkGenericGeometryFilter_GetPointMinimumMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGeometryFilter_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericGeometryFilter_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericGeometryFilter_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericGeometryFilter_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_MergingOff_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void MergingOff()
	{
		vtkGenericGeometryFilter_MergingOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_MergingOn_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void MergingOn()
	{
		vtkGenericGeometryFilter_MergingOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGeometryFilter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericGeometryFilter NewInstance()
	{
		vtkGenericGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericGeometryFilter_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_PassThroughCellIdsOff_34(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOff()
	{
		vtkGenericGeometryFilter_PassThroughCellIdsOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_PassThroughCellIdsOn_35(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOn()
	{
		vtkGenericGeometryFilter_PassThroughCellIdsOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_PointClippingOff_36(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void PointClippingOff()
	{
		vtkGenericGeometryFilter_PointClippingOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_PointClippingOn_37(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void PointClippingOn()
	{
		vtkGenericGeometryFilter_PointClippingOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericGeometryFilter_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericGeometryFilter SafeDownCast(vtkObjectBase o)
	{
		vtkGenericGeometryFilter vtkGenericGeometryFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericGeometryFilter_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericGeometryFilter2 = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericGeometryFilter2.Register(null);
			}
		}
		return vtkGenericGeometryFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetCellClipping_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void SetCellClipping(int _arg)
	{
		vtkGenericGeometryFilter_SetCellClipping_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetCellMaximum_40(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual void SetCellMaximum(long _arg)
	{
		vtkGenericGeometryFilter_SetCellMaximum_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetCellMinimum_41(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual void SetCellMinimum(long _arg)
	{
		vtkGenericGeometryFilter_SetCellMinimum_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetExtent_42(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Specify a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkGenericGeometryFilter_SetExtent_42(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetExtent_43(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkGenericGeometryFilter_SetExtent_43(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetExtentClipping_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void SetExtentClipping(int _arg)
	{
		vtkGenericGeometryFilter_SetExtentClipping_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetLocator_45(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkGenericGeometryFilter_SetLocator_45(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetMerging_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void SetMerging(int _arg)
	{
		vtkGenericGeometryFilter_SetMerging_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetPassThroughCellIds_47(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughCellIds(int _arg)
	{
		vtkGenericGeometryFilter_SetPassThroughCellIds_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetPointClipping_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void SetPointClipping(int _arg)
	{
		vtkGenericGeometryFilter_SetPointClipping_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetPointMaximum_49(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual void SetPointMaximum(long _arg)
	{
		vtkGenericGeometryFilter_SetPointMaximum_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericGeometryFilter_SetPointMinimum_50(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual void SetPointMinimum(long _arg)
	{
		vtkGenericGeometryFilter_SetPointMinimum_50(GetCppThis(), _arg);
	}
}
