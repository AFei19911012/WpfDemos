using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridGeometryFilter
/// </summary>
/// <remarks>
///    extract geometry from an unstructured grid
///
/// vtkUnstructuredGridGeometryFilter is a filter that extracts
/// geometry (and associated data) from an unstructured grid. It differs from
/// vtkGeometryFilter by not tessellating higher order faces: 2D faces of
/// quadratic 3D cells will be quadratic. A quadratic edge is extracted as a
/// quadratic edge. For that purpose, the output of this filter is an
/// unstructured grid, not a polydata.
/// Also, the face of a voxel is a pixel, not a quad.
/// Geometry is obtained as follows: all 0D, 1D, and 2D cells are extracted.
/// All 2D faces that are used by only one 3D cell (i.e., boundary faces) are
/// extracted. It also is possible to specify conditions on point ids, cell ids,
/// and on bounding box (referred to as "Extent") to control the extraction
/// process.
///
/// @warning
/// When vtkUnstructuredGridGeometryFilter extracts cells (or boundaries of
/// cells) it will (by default) merge duplicate vertices. This may cause
/// problems in some cases. Turn merging off to prevent this from occurring.
///
/// </remarks>
/// <seealso>
///
/// vtkGeometryFilter vtkDataSetSurfaceFilter
/// </seealso>
public class vtkUnstructuredGridGeometryFilter : vtkUnstructuredGridBaseAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridGeometryFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridGeometryFilter()
	{
		MRClassNameKey = "class vtkUnstructuredGridGeometryFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridGeometryFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridGeometryFilter New()
	{
		vtkUnstructuredGridGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridGeometryFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_CellClippingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void CellClippingOff()
	{
		vtkUnstructuredGridGeometryFilter_CellClippingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_CellClippingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void CellClippingOn()
	{
		vtkUnstructuredGridGeometryFilter_CellClippingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_CreateDefaultLocator_03(HandleRef pThis);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// </summary>
	public void CreateDefaultLocator()
	{
		vtkUnstructuredGridGeometryFilter_CreateDefaultLocator_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_DuplicateGhostCellClippingOff_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off clipping of ghost cells with type
	/// vtkDataSetAttributes::DUPLICATECELL. Defaults to on.
	/// </summary>
	public virtual void DuplicateGhostCellClippingOff()
	{
		vtkUnstructuredGridGeometryFilter_DuplicateGhostCellClippingOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_DuplicateGhostCellClippingOn_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off clipping of ghost cells with type
	/// vtkDataSetAttributes::DUPLICATECELL. Defaults to on.
	/// </summary>
	public virtual void DuplicateGhostCellClippingOn()
	{
		vtkUnstructuredGridGeometryFilter_DuplicateGhostCellClippingOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_ExtentClippingOff_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void ExtentClippingOff()
	{
		vtkUnstructuredGridGeometryFilter_ExtentClippingOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_ExtentClippingOn_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void ExtentClippingOn()
	{
		vtkUnstructuredGridGeometryFilter_ExtentClippingOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_GetCellClipping_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual int GetCellClipping()
	{
		return vtkUnstructuredGridGeometryFilter_GetCellClipping_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximum_09(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximum()
	{
		return vtkUnstructuredGridGeometryFilter_GetCellMaximum_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximumMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximumMaxValue()
	{
		return vtkUnstructuredGridGeometryFilter_GetCellMaximumMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximumMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximumMinValue()
	{
		return vtkUnstructuredGridGeometryFilter_GetCellMaximumMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimum_12(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimum()
	{
		return vtkUnstructuredGridGeometryFilter_GetCellMinimum_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimumMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimumMaxValue()
	{
		return vtkUnstructuredGridGeometryFilter_GetCellMinimumMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimumMinValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimumMinValue()
	{
		return vtkUnstructuredGridGeometryFilter_GetCellMinimumMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_GetDuplicateGhostCellClipping_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off clipping of ghost cells with type
	/// vtkDataSetAttributes::DUPLICATECELL. Defaults to on.
	/// </summary>
	public virtual int GetDuplicateGhostCellClipping()
	{
		return vtkUnstructuredGridGeometryFilter_GetDuplicateGhostCellClipping_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetExtent_16(HandleRef pThis);

	/// <summary>
	/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public IntPtr GetExtent()
	{
		return vtkUnstructuredGridGeometryFilter_GetExtent_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_GetExtentClipping_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual int GetExtentClipping()
	{
		return vtkUnstructuredGridGeometryFilter_GetExtentClipping_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetLocator_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkUnstructuredGridGeometryFilter_GetLocator_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkUnstructuredGridGeometryFilter_GetMTime_19(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkUnstructuredGridGeometryFilter_GetMTime_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_GetMerging_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual int GetMerging()
	{
		return vtkUnstructuredGridGeometryFilter_GetMerging_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridGeometryFilter_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridGeometryFilter_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetOriginalCellIdsName_23(HandleRef pThis);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual string GetOriginalCellIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkUnstructuredGridGeometryFilter_GetOriginalCellIdsName_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetOriginalPointIdsName_24(HandleRef pThis);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual string GetOriginalPointIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkUnstructuredGridGeometryFilter_GetOriginalPointIdsName_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_GetPassThroughCellIds_25(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
	/// since in that case each tringle strip can represent more than on of the
	/// input cells.
	/// </summary>
	public virtual int GetPassThroughCellIds()
	{
		return vtkUnstructuredGridGeometryFilter_GetPassThroughCellIds_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_GetPassThroughPointIds_26(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
	/// since in that case each tringle strip can represent more than on of the
	/// input cells.
	/// </summary>
	public virtual int GetPassThroughPointIds()
	{
		return vtkUnstructuredGridGeometryFilter_GetPassThroughPointIds_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_GetPointClipping_27(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual int GetPointClipping()
	{
		return vtkUnstructuredGridGeometryFilter_GetPointClipping_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximum_28(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximum()
	{
		return vtkUnstructuredGridGeometryFilter_GetPointMaximum_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximumMaxValue_29(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximumMaxValue()
	{
		return vtkUnstructuredGridGeometryFilter_GetPointMaximumMaxValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximumMinValue_30(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximumMinValue()
	{
		return vtkUnstructuredGridGeometryFilter_GetPointMaximumMinValue_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimum_31(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimum()
	{
		return vtkUnstructuredGridGeometryFilter_GetPointMinimum_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimumMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimumMaxValue()
	{
		return vtkUnstructuredGridGeometryFilter_GetPointMinimumMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimumMinValue_33(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimumMinValue()
	{
		return vtkUnstructuredGridGeometryFilter_GetPointMinimumMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_IsA_34(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridGeometryFilter_IsA_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridGeometryFilter_IsTypeOf_35(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridGeometryFilter_IsTypeOf_35(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_MergingOff_36(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void MergingOff()
	{
		vtkUnstructuredGridGeometryFilter_MergingOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_MergingOn_37(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void MergingOn()
	{
		vtkUnstructuredGridGeometryFilter_MergingOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridGeometryFilter_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridGeometryFilter NewInstance()
	{
		vtkUnstructuredGridGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridGeometryFilter_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOff_40(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
	/// since in that case each tringle strip can represent more than on of the
	/// input cells.
	/// </summary>
	public virtual void PassThroughCellIdsOff()
	{
		vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOff_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOn_41(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
	/// since in that case each tringle strip can represent more than on of the
	/// input cells.
	/// </summary>
	public virtual void PassThroughCellIdsOn()
	{
		vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOn_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOff_42(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
	/// since in that case each tringle strip can represent more than on of the
	/// input cells.
	/// </summary>
	public virtual void PassThroughPointIdsOff()
	{
		vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOn_43(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
	/// since in that case each tringle strip can represent more than on of the
	/// input cells.
	/// </summary>
	public virtual void PassThroughPointIdsOn()
	{
		vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_PointClippingOff_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void PointClippingOff()
	{
		vtkUnstructuredGridGeometryFilter_PointClippingOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_PointClippingOn_45(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void PointClippingOn()
	{
		vtkUnstructuredGridGeometryFilter_PointClippingOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridGeometryFilter_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridGeometryFilter SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridGeometryFilter vtkUnstructuredGridGeometryFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridGeometryFilter_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridGeometryFilter2 = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridGeometryFilter2.Register(null);
			}
		}
		return vtkUnstructuredGridGeometryFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetCellClipping_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void SetCellClipping(int _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetCellClipping_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetCellMaximum_48(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual void SetCellMaximum(long _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetCellMaximum_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetCellMinimum_49(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual void SetCellMinimum(long _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetCellMinimum_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetDuplicateGhostCellClipping_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off clipping of ghost cells with type
	/// vtkDataSetAttributes::DUPLICATECELL. Defaults to on.
	/// </summary>
	public virtual void SetDuplicateGhostCellClipping(int _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetDuplicateGhostCellClipping_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetExtent_51(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Specify a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkUnstructuredGridGeometryFilter_SetExtent_51(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetExtent_52(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkUnstructuredGridGeometryFilter_SetExtent_52(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetExtentClipping_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void SetExtentClipping(int _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetExtentClipping_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetLocator_54(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set / get a spatial locator for merging points. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkUnstructuredGridGeometryFilter_SetLocator_54(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetMerging_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off merging of coincident points. Note that is merging is
	/// on, points with different point attributes (e.g., normals) are merged,
	/// which may cause rendering artifacts.
	/// </summary>
	public virtual void SetMerging(int _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetMerging_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetOriginalCellIdsName_56(HandleRef pThis, string _arg);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual void SetOriginalCellIdsName(string _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetOriginalCellIdsName_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetOriginalPointIdsName_57(HandleRef pThis, string _arg);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual void SetOriginalPointIdsName(string _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetOriginalPointIdsName_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetPassThroughCellIds_58(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
	/// since in that case each tringle strip can represent more than on of the
	/// input cells.
	/// </summary>
	public virtual void SetPassThroughCellIds(int _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetPassThroughCellIds_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetPassThroughPointIds_59(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory. Note that PassThroughCellIds will be ignored if UseStrips is on,
	/// since in that case each tringle strip can represent more than on of the
	/// input cells.
	/// </summary>
	public virtual void SetPassThroughPointIds(int _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetPassThroughPointIds_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetPointClipping_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void SetPointClipping(int _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetPointClipping_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetPointMaximum_61(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual void SetPointMaximum(long _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetPointMaximum_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridGeometryFilter_SetPointMinimum_62(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual void SetPointMinimum(long _arg)
	{
		vtkUnstructuredGridGeometryFilter_SetPointMinimum_62(GetCppThis(), _arg);
	}
}
