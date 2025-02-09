using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGeometryFilter
/// </summary>
/// <remarks>
///    extract boundary geometry from dataset (or convert data to polygonal type)
///
/// vtkGeometryFilter is a general-purpose filter to extract dataset boundary
/// geometry, topology, and associated attribute data from any type of
/// dataset. Geometry is obtained as follows: all 0D, 1D, and 2D cells are
/// extracted. All 2D faces that are used by only one 3D cell (i.e., boundary
/// faces) are extracted. It also is possible to specify conditions on point
/// ids, cell ids, and on a bounding box (referred to as "Extent") to control
/// the extraction process.  This point and cell id- and extent-based clipping
/// is a powerful way to "see inside" datasets; however it may impact
/// performance significantly.
///
/// This filter may also be used to convert any type of data to polygonal
/// type. This is particularly useful for surface rendering. The conversion
/// process may be less than satisfactory for some 3D datasets. For example,
/// this filter will extract the outer surface of a volume or structured grid
/// dataset (if point, cell, and extent clipping is disabled). (For structured
/// data you may want to use vtkImageDataGeometryFilter,
/// vtkStructuredGridGeometryFilter, vtkExtractUnstructuredGrid,
/// vtkRectilinearGridGeometryFilter, or vtkExtractVOI.)
///
/// Another important feature of vtkGeometryFilter is that it preserves
/// topological connectivity. This enables filters that depend on correct
/// connectivity (e.g., vtkQuadricDecimation, vtkFeatureEdges, etc.) to
/// operate properly . It is possible to label the output polydata with an
/// originating cell (PassThroughCellIds) or point id (PassThroughPointIds).
/// The output precision of created points (if they need to be created) can
/// also be specified.
///
/// Finally, this filter takes an optional second, vtkPolyData input. This
/// input represents a list of faces that are to be excluded from the output
/// of vtkGeometryFilter.
///
/// @warning
/// While vtkGeometryFilter and vtkDataSetSurfaceFilter perform similar operations,
/// there are important differences as follows:
/// 1. vtkGeometryFilter can preserve (using RemoveGhostInterfaces) topological connectivity.
///    vtkDataSetSurfaceFilter produces output primitives which may be disconnected from one another.
/// 2. vtkGeometryFilter can generate output based on cell ids, point ids, and/or
///    extent (bounding box) clipping. vtkDataSetSurfaceFilter strictly extracts
///    the boundary surface of a dataset.
/// 3. vtkGeometryFilter is much faster than vtkDataSetSurfaceFilter, because it's
///    multi-threaded. As a result, vtkDataSetSurfaceFilter will delegate the processing
///    of linear unstructured grids to vtkGeometryFilter.
/// 4. vtkGeometryFilter can (currently) only handle linear cells. The filter
///    will delegate to vtkDataSetSurfaceFilter for higher-order cells. (This
///    is a historical artifact and may be rectified in the future.)
///
/// @warning
/// If point merging (MergingOff) is disabled, the filter will (if possible)
/// use the input points and point attributes.  This can result in a lot of
/// unused points in the output, at some gain in filter performance.  If
/// enabled, point merging will generate only new points that are used by the
/// output polydata cells.
///
/// @warning
/// This class is templated. It may run slower than serial execution if the code
/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkDataSetSurfaceFilter vtkImageDataGeometryFilter
/// vtkStructuredGridGeometryFilter vtkExtractGeometry vtkExtractVOI
/// vtkMarkBoundaryFilter vtkRemovePolyData
/// </seealso>
public class vtkGeometryFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGeometryFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGeometryFilter()
	{
		MRClassNameKey = "class vtkGeometryFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeometryFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkGeometryFilter New()
	{
		vtkGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkGeometryFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGeometryFilter_CellClippingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void CellClippingOff()
	{
		vtkGeometryFilter_CellClippingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_CellClippingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void CellClippingOn()
	{
		vtkGeometryFilter_CellClippingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_DataSetExecute_03(HandleRef pThis, HandleRef input, HandleRef output, HandleRef exc);

	/// <summary>
	/// Direct access methods so that this class can be used as an
	/// algorithm without using it as a filter (i.e., no pipeline updates).
	/// Also some internal methods with additional options.
	/// </summary>
	public int DataSetExecute(vtkDataSet input, vtkPolyData output, vtkPolyData exc)
	{
		return vtkGeometryFilter_DataSetExecute_03(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), exc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_DataSetExecute_04(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// Direct access methods so that this class can be used as an
	/// algorithm without using it as a filter (i.e., no pipeline updates).
	/// Also some internal methods with additional options.
	/// </summary>
	public virtual int DataSetExecute(vtkDataSet input, vtkPolyData output)
	{
		return vtkGeometryFilter_DataSetExecute_04(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_DelegationOff_05(HandleRef pThis);

	/// <summary>
	/// Disable delegation to an internal vtkDataSetSurfaceFilter.
	/// </summary>
	public virtual void DelegationOff()
	{
		vtkGeometryFilter_DelegationOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_DelegationOn_06(HandleRef pThis);

	/// <summary>
	/// Disable delegation to an internal vtkDataSetSurfaceFilter.
	/// </summary>
	public virtual void DelegationOn()
	{
		vtkGeometryFilter_DelegationOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_ExtentClippingOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void ExtentClippingOff()
	{
		vtkGeometryFilter_ExtentClippingOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_ExtentClippingOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void ExtentClippingOn()
	{
		vtkGeometryFilter_ExtentClippingOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_FastModeOff_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast mode execution. If enabled, fast mode typically runs
	/// much faster (2-3x) than the standard algorithm, however the output is an
	/// approximation to the correct result. FastMode is only meaningful when
	/// the input is vtkImageData/vtkRectilinearGrid/vtkStructuredGrid and there
	/// are blank cells.
	/// </summary>
	public virtual void FastModeOff()
	{
		vtkGeometryFilter_FastModeOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_FastModeOn_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast mode execution. If enabled, fast mode typically runs
	/// much faster (2-3x) than the standard algorithm, however the output is an
	/// approximation to the correct result. FastMode is only meaningful when
	/// the input is vtkImageData/vtkRectilinearGrid/vtkStructuredGrid and there
	/// are blank cells.
	/// </summary>
	public virtual void FastModeOn()
	{
		vtkGeometryFilter_FastModeOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGeometryFilter_GetCellClipping_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual bool GetCellClipping()
	{
		return (vtkGeometryFilter_GetCellClipping_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetCellMaximum_12(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximum()
	{
		return vtkGeometryFilter_GetCellMaximum_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetCellMaximumMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximumMaxValue()
	{
		return vtkGeometryFilter_GetCellMaximumMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetCellMaximumMinValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMaximumMinValue()
	{
		return vtkGeometryFilter_GetCellMaximumMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetCellMinimum_15(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimum()
	{
		return vtkGeometryFilter_GetCellMinimum_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetCellMinimumMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimumMaxValue()
	{
		return vtkGeometryFilter_GetCellMinimumMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetCellMinimumMinValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual long GetCellMinimumMinValue()
	{
		return vtkGeometryFilter_GetCellMinimumMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_GetDelegation_18(HandleRef pThis);

	/// <summary>
	/// Disable delegation to an internal vtkDataSetSurfaceFilter.
	/// </summary>
	public virtual int GetDelegation()
	{
		return vtkGeometryFilter_GetDelegation_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometryFilter_GetExcludedFaces_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If a second, vtkPolyData input is provided, this second input specifies
	/// a list of faces to be excluded from the output (in the
	/// vtkPolyData::Polys attribute). This is useful to prevent the same face
	/// to be output multiple times in complex pipelines. (A candidate output
	/// boundary face is the same as a face in the excluded face list if it uses
	/// the same point ids as one of the polygons defined in the second input.) For
	/// example, a face may be extracted separately via a threshold filter; thus
	/// this face should not be also extracted via the vtkGeometryFilter. (This
	/// functionality is related to vtkRemovePolyData.)
	/// </summary>
	public vtkPolyData GetExcludedFaces()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeometryFilter_GetExcludedFaces_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometryFilter_GetExtent_20(HandleRef pThis);

	/// <summary>
	/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public double[] GetExtent()
	{
		IntPtr intPtr = vtkGeometryFilter_GetExtent_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGeometryFilter_GetExtentClipping_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual bool GetExtentClipping()
	{
		return (vtkGeometryFilter_GetExtentClipping_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGeometryFilter_GetFastMode_22(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast mode execution. If enabled, fast mode typically runs
	/// much faster (2-3x) than the standard algorithm, however the output is an
	/// approximation to the correct result. FastMode is only meaningful when
	/// the input is vtkImageData/vtkRectilinearGrid/vtkStructuredGrid and there
	/// are blank cells.
	/// </summary>
	public virtual bool GetFastMode()
	{
		return (vtkGeometryFilter_GetFastMode_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGeometryFilter_GetMerging_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of points. This will reduce the number of output
	/// points, at some cost to performance. If Merging is off, then if possible
	/// (i.e., if the point representation is explicit), the filter will reuse
	/// the input points to create the output polydata. Certain input dataset
	/// types (with implicit point representations) will always create new
	/// points (effectively performing a merge operation).
	/// </summary>
	public virtual bool GetMerging()
	{
		return (vtkGeometryFilter_GetMerging_23(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_GetNonlinearSubdivisionLevel_24(HandleRef pThis);

	/// <summary>
	/// If the input is an unstructured grid with nonlinear faces, this parameter
	/// determines how many times the face is subdivided into linear faces.  If 0,
	/// the output is the equivalent of its linear counterpart (and the midpoints
	/// determining the nonlinear interpolation are discarded).  If 1 (the
	/// default), the nonlinear face is triangulated based on the midpoints.  If
	/// greater than 1, the triangulated pieces are recursively subdivided to reach
	/// the desired subdivision.  Setting the value to greater than 1 may cause
	/// some point data to not be passed even if no nonlinear faces exist.  This
	/// option has no effect if the input is not an unstructured grid.
	/// </summary>
	public virtual int GetNonlinearSubdivisionLevel()
	{
		return vtkGeometryFilter_GetNonlinearSubdivisionLevel_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetNumberOfGenerationsFromBase_25(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGeometryFilter_GetNumberOfGenerationsFromBase_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetNumberOfGenerationsFromBaseType_26(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGeometryFilter_GetNumberOfGenerationsFromBaseType_26(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometryFilter_GetOriginalCellIdsName_27(HandleRef pThis);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual string GetOriginalCellIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkGeometryFilter_GetOriginalCellIdsName_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometryFilter_GetOriginalPointIdsName_28(HandleRef pThis);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual string GetOriginalPointIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkGeometryFilter_GetOriginalPointIdsName_28(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_GetOutputPointsPrecision_29(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings. This only applies for
	/// data types where we create points (merging) as opposed to passing them
	/// from input to output, such as unstructured grids.
	/// </summary>
	public int GetOutputPointsPrecision()
	{
		return vtkGeometryFilter_GetOutputPointsPrecision_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_GetPassThroughCellIds_30(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughCellIds()
	{
		return vtkGeometryFilter_GetPassThroughCellIds_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_GetPassThroughPointIds_31(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughPointIds()
	{
		return vtkGeometryFilter_GetPassThroughPointIds_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_GetPieceInvariant_32(HandleRef pThis);

	/// <summary>
	/// If PieceInvariant is true, vtkGeometryFilter requests
	/// 1 ghost level from input in order to remove internal surface
	/// that are between processes. False by default.
	/// </summary>
	public virtual int GetPieceInvariant()
	{
		return vtkGeometryFilter_GetPieceInvariant_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGeometryFilter_GetPointClipping_33(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual bool GetPointClipping()
	{
		return (vtkGeometryFilter_GetPointClipping_33(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetPointMaximum_34(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximum()
	{
		return vtkGeometryFilter_GetPointMaximum_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetPointMaximumMaxValue_35(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximumMaxValue()
	{
		return vtkGeometryFilter_GetPointMaximumMaxValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetPointMaximumMinValue_36(HandleRef pThis);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual long GetPointMaximumMinValue()
	{
		return vtkGeometryFilter_GetPointMaximumMinValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetPointMinimum_37(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimum()
	{
		return vtkGeometryFilter_GetPointMinimum_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetPointMinimumMaxValue_38(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimumMaxValue()
	{
		return vtkGeometryFilter_GetPointMinimumMaxValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeometryFilter_GetPointMinimumMinValue_39(HandleRef pThis);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual long GetPointMinimumMinValue()
	{
		return vtkGeometryFilter_GetPointMinimumMinValue_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGeometryFilter_GetRemoveGhostInterfaces_40(HandleRef pThis);

	/// <summary>
	/// Set/Get if Ghost interfaces will be removed.
	/// When you are rendering you want to remove ghost interfaces that originate from duplicate cells.
	///
	/// There are certain algorithms though that need the ghost interfaces, such as GhostCellGenerator
	/// and FeatureEdges.
	///
	/// Since Rendering is the most common case, the Default is on.
	///
	/// Note: DON'T change it if there are no ghost cells.
	/// </summary>
	public virtual bool GetRemoveGhostInterfaces()
	{
		return (vtkGeometryFilter_GetRemoveGhostInterfaces_40(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_IsA_41(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGeometryFilter_IsA_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_IsTypeOf_42(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGeometryFilter_IsTypeOf_42(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_MergingOff_43(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of points. This will reduce the number of output
	/// points, at some cost to performance. If Merging is off, then if possible
	/// (i.e., if the point representation is explicit), the filter will reuse
	/// the input points to create the output polydata. Certain input dataset
	/// types (with implicit point representations) will always create new
	/// points (effectively performing a merge operation).
	/// </summary>
	public virtual void MergingOff()
	{
		vtkGeometryFilter_MergingOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_MergingOn_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off merging of points. This will reduce the number of output
	/// points, at some cost to performance. If Merging is off, then if possible
	/// (i.e., if the point representation is explicit), the filter will reuse
	/// the input points to create the output polydata. Certain input dataset
	/// types (with implicit point representations) will always create new
	/// points (effectively performing a merge operation).
	/// </summary>
	public virtual void MergingOn()
	{
		vtkGeometryFilter_MergingOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometryFilter_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkGeometryFilter NewInstance()
	{
		vtkGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeometryFilter_NewInstance_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_PassThroughCellIdsOff_47(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOff()
	{
		vtkGeometryFilter_PassThroughCellIdsOff_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_PassThroughCellIdsOn_48(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOn()
	{
		vtkGeometryFilter_PassThroughCellIdsOn_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_PassThroughPointIdsOff_49(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughPointIdsOff()
	{
		vtkGeometryFilter_PassThroughPointIdsOff_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_PassThroughPointIdsOn_50(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughPointIdsOn()
	{
		vtkGeometryFilter_PassThroughPointIdsOn_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_PointClippingOff_51(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void PointClippingOff()
	{
		vtkGeometryFilter_PointClippingOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_PointClippingOn_52(HandleRef pThis);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void PointClippingOn()
	{
		vtkGeometryFilter_PointClippingOn_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_PolyDataExecute_53(HandleRef pThis, HandleRef input, HandleRef output, HandleRef exc);

	/// <summary>
	/// Direct access methods so that this class can be used as an
	/// algorithm without using it as a filter (i.e., no pipeline updates).
	/// Also some internal methods with additional options.
	/// </summary>
	public int PolyDataExecute(vtkDataSet input, vtkPolyData output, vtkPolyData exc)
	{
		return vtkGeometryFilter_PolyDataExecute_53(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), exc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_PolyDataExecute_54(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Direct access methods so that this class can be used as an
	/// algorithm without using it as a filter (i.e., no pipeline updates).
	/// Also some internal methods with additional options.
	/// </summary>
	public virtual int PolyDataExecute(vtkDataSet arg0, vtkPolyData arg1)
	{
		return vtkGeometryFilter_PolyDataExecute_54(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_RemoveGhostInterfacesOff_55(HandleRef pThis);

	/// <summary>
	/// Set/Get if Ghost interfaces will be removed.
	/// When you are rendering you want to remove ghost interfaces that originate from duplicate cells.
	///
	/// There are certain algorithms though that need the ghost interfaces, such as GhostCellGenerator
	/// and FeatureEdges.
	///
	/// Since Rendering is the most common case, the Default is on.
	///
	/// Note: DON'T change it if there are no ghost cells.
	/// </summary>
	public virtual void RemoveGhostInterfacesOff()
	{
		vtkGeometryFilter_RemoveGhostInterfacesOff_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_RemoveGhostInterfacesOn_56(HandleRef pThis);

	/// <summary>
	/// Set/Get if Ghost interfaces will be removed.
	/// When you are rendering you want to remove ghost interfaces that originate from duplicate cells.
	///
	/// There are certain algorithms though that need the ghost interfaces, such as GhostCellGenerator
	/// and FeatureEdges.
	///
	/// Since Rendering is the most common case, the Default is on.
	///
	/// Note: DON'T change it if there are no ghost cells.
	/// </summary>
	public virtual void RemoveGhostInterfacesOn()
	{
		vtkGeometryFilter_RemoveGhostInterfacesOn_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeometryFilter_SafeDownCast_57(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkGeometryFilter SafeDownCast(vtkObjectBase o)
	{
		vtkGeometryFilter vtkGeometryFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeometryFilter_SafeDownCast_57(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGeometryFilter2 = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGeometryFilter2.Register(null);
			}
		}
		return vtkGeometryFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetCellClipping_58(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off selection of geometry by cell id.
	/// </summary>
	public virtual void SetCellClipping(bool _arg)
	{
		vtkGeometryFilter_SetCellClipping_58(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetCellMaximum_59(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum cell id for point id selection.
	/// </summary>
	public virtual void SetCellMaximum(long _arg)
	{
		vtkGeometryFilter_SetCellMaximum_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetCellMinimum_60(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the minimum cell id for point id selection.
	/// </summary>
	public virtual void SetCellMinimum(long _arg)
	{
		vtkGeometryFilter_SetCellMinimum_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetDelegation_61(HandleRef pThis, int _arg);

	/// <summary>
	/// Disable delegation to an internal vtkDataSetSurfaceFilter.
	/// </summary>
	public virtual void SetDelegation(int _arg)
	{
		vtkGeometryFilter_SetDelegation_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetExcludedFacesConnection_62(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// If a second, vtkPolyData input is provided, this second input specifies
	/// a list of faces to be excluded from the output (in the
	/// vtkPolyData::Polys attribute). This is useful to prevent the same face
	/// to be output multiple times in complex pipelines. (A candidate output
	/// boundary face is the same as a face in the excluded face list if it uses
	/// the same point ids as one of the polygons defined in the second input.) For
	/// example, a face may be extracted separately via a threshold filter; thus
	/// this face should not be also extracted via the vtkGeometryFilter. (This
	/// functionality is related to vtkRemovePolyData.)
	/// </summary>
	public void SetExcludedFacesConnection(vtkAlgorithmOutput algOutput)
	{
		vtkGeometryFilter_SetExcludedFacesConnection_62(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetExcludedFacesData_63(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// If a second, vtkPolyData input is provided, this second input specifies
	/// a list of faces to be excluded from the output (in the
	/// vtkPolyData::Polys attribute). This is useful to prevent the same face
	/// to be output multiple times in complex pipelines. (A candidate output
	/// boundary face is the same as a face in the excluded face list if it uses
	/// the same point ids as one of the polygons defined in the second input.) For
	/// example, a face may be extracted separately via a threshold filter; thus
	/// this face should not be also extracted via the vtkGeometryFilter. (This
	/// functionality is related to vtkRemovePolyData.)
	/// </summary>
	public void SetExcludedFacesData(vtkPolyData arg0)
	{
		vtkGeometryFilter_SetExcludedFacesData_63(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetExtent_64(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Specify a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkGeometryFilter_SetExtent_64(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetExtent_65(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkGeometryFilter_SetExtent_65(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetExtentClipping_66(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off selection of geometry via bounding box.
	/// </summary>
	public virtual void SetExtentClipping(bool _arg)
	{
		vtkGeometryFilter_SetExtentClipping_66(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetFastMode_67(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off fast mode execution. If enabled, fast mode typically runs
	/// much faster (2-3x) than the standard algorithm, however the output is an
	/// approximation to the correct result. FastMode is only meaningful when
	/// the input is vtkImageData/vtkRectilinearGrid/vtkStructuredGrid and there
	/// are blank cells.
	/// </summary>
	public virtual void SetFastMode(bool _arg)
	{
		vtkGeometryFilter_SetFastMode_67(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetMerging_68(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off merging of points. This will reduce the number of output
	/// points, at some cost to performance. If Merging is off, then if possible
	/// (i.e., if the point representation is explicit), the filter will reuse
	/// the input points to create the output polydata. Certain input dataset
	/// types (with implicit point representations) will always create new
	/// points (effectively performing a merge operation).
	/// </summary>
	public virtual void SetMerging(bool _arg)
	{
		vtkGeometryFilter_SetMerging_68(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetNonlinearSubdivisionLevel_69(HandleRef pThis, int _arg);

	/// <summary>
	/// If the input is an unstructured grid with nonlinear faces, this parameter
	/// determines how many times the face is subdivided into linear faces.  If 0,
	/// the output is the equivalent of its linear counterpart (and the midpoints
	/// determining the nonlinear interpolation are discarded).  If 1 (the
	/// default), the nonlinear face is triangulated based on the midpoints.  If
	/// greater than 1, the triangulated pieces are recursively subdivided to reach
	/// the desired subdivision.  Setting the value to greater than 1 may cause
	/// some point data to not be passed even if no nonlinear faces exist.  This
	/// option has no effect if the input is not an unstructured grid.
	/// </summary>
	public virtual void SetNonlinearSubdivisionLevel(int _arg)
	{
		vtkGeometryFilter_SetNonlinearSubdivisionLevel_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetOriginalCellIdsName_70(HandleRef pThis, string _arg);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual void SetOriginalCellIdsName(string _arg)
	{
		vtkGeometryFilter_SetOriginalCellIdsName_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetOriginalPointIdsName_71(HandleRef pThis, string _arg);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual void SetOriginalPointIdsName(string _arg)
	{
		vtkGeometryFilter_SetOriginalPointIdsName_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetOutputPointsPrecision_72(HandleRef pThis, int precision);

	/// <summary>
	/// Set/get the desired precision for the output types. See the
	/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
	/// explanation of the available precision settings. This only applies for
	/// data types where we create points (merging) as opposed to passing them
	/// from input to output, such as unstructured grids.
	/// </summary>
	public void SetOutputPointsPrecision(int precision)
	{
		vtkGeometryFilter_SetOutputPointsPrecision_72(GetCppThis(), precision);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetPassThroughCellIds_73(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughCellIds(int _arg)
	{
		vtkGeometryFilter_SetPassThroughCellIds_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetPassThroughPointIds_74(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughPointIds(int _arg)
	{
		vtkGeometryFilter_SetPassThroughPointIds_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetPieceInvariant_75(HandleRef pThis, int _arg);

	/// <summary>
	/// If PieceInvariant is true, vtkGeometryFilter requests
	/// 1 ghost level from input in order to remove internal surface
	/// that are between processes. False by default.
	/// </summary>
	public virtual void SetPieceInvariant(int _arg)
	{
		vtkGeometryFilter_SetPieceInvariant_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetPointClipping_76(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off selection of geometry by point id.
	/// </summary>
	public virtual void SetPointClipping(bool _arg)
	{
		vtkGeometryFilter_SetPointClipping_76(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetPointMaximum_77(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the maximum point id for point id selection.
	/// </summary>
	public virtual void SetPointMaximum(long _arg)
	{
		vtkGeometryFilter_SetPointMaximum_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetPointMinimum_78(HandleRef pThis, long _arg);

	/// <summary>
	/// Specify the minimum point id for point id selection.
	/// </summary>
	public virtual void SetPointMinimum(long _arg)
	{
		vtkGeometryFilter_SetPointMinimum_78(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeometryFilter_SetRemoveGhostInterfaces_79(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if Ghost interfaces will be removed.
	/// When you are rendering you want to remove ghost interfaces that originate from duplicate cells.
	///
	/// There are certain algorithms though that need the ghost interfaces, such as GhostCellGenerator
	/// and FeatureEdges.
	///
	/// Since Rendering is the most common case, the Default is on.
	///
	/// Note: DON'T change it if there are no ghost cells.
	/// </summary>
	public virtual void SetRemoveGhostInterfaces(bool _arg)
	{
		vtkGeometryFilter_SetRemoveGhostInterfaces_79(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_StructuredExecute_80(HandleRef pThis, HandleRef input, HandleRef output, IntPtr wholeExtent, HandleRef exc, IntPtr extractFace);

	/// <summary>
	/// Direct access methods so that this class can be used as an
	/// algorithm without using it as a filter (i.e., no pipeline updates).
	/// Also some internal methods with additional options.
	/// </summary>
	public int StructuredExecute(vtkDataSet input, vtkPolyData output, IntPtr wholeExtent, vtkPolyData exc, IntPtr extractFace)
	{
		return vtkGeometryFilter_StructuredExecute_80(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), wholeExtent, exc?.GetCppThis() ?? default(HandleRef), extractFace);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_StructuredExecute_81(HandleRef pThis, HandleRef input, HandleRef output, IntPtr wholeExt, IntPtr extractFace);

	/// <summary>
	/// Direct access methods so that this class can be used as an
	/// algorithm without using it as a filter (i.e., no pipeline updates).
	/// Also some internal methods with additional options.
	/// </summary>
	public virtual int StructuredExecute(vtkDataSet input, vtkPolyData output, IntPtr wholeExt, IntPtr extractFace)
	{
		return vtkGeometryFilter_StructuredExecute_81(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), wholeExt, extractFace);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeometryFilter_UnstructuredGridExecute_82(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// Direct access methods so that this class can be used as an
	/// algorithm without using it as a filter (i.e., no pipeline updates).
	/// Also some internal methods with additional options.
	/// </summary>
	public virtual int UnstructuredGridExecute(vtkDataSet input, vtkPolyData output)
	{
		return vtkGeometryFilter_UnstructuredGridExecute_82(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}
}
