using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataSetSurfaceFilter
/// </summary>
/// <remarks>
///    Extracts outer surface (as vtkPolyData) of any dataset
///
/// vtkDataSetSurfaceFilter is a general-purpose filter to extract boundary
/// geometry (and associated data) from any type of dataset. Geometry is
/// obtained as follows: all 0D, 1D, and 2D cells are extracted. All 2D faces
/// that are used by only one 3D cell (i.e., boundary faces) are
/// extracted. The filter will handle any type of dataset, including
/// unstructured grids with non-linear cells. (See also vtkGeometryFilter for
/// additional documentation and information - vtkGeometryFilter is the
/// preferred filter to use in most cases and may be deprecated in the
/// future.)
///
/// The filter only has only a few options: methods for passing through
/// point and cell ids (to support picking); and controls for nonlinear cell
/// subdivision. At this time vtkDataSetSurfaceFilter has the distinction of
/// being able to process non-linear cells requiring subdivision. For this
/// reason, vtkDataSetSurfaceFilter should be used with non-linear cells;
/// otherwise vtkGeometryFilter should be used. (Note: by default this filter
/// will delegate processing of linear vtkUnstructuredGrids to
/// vtkGeometryFilter as vtkGeometryFilter is so much faster. And
/// vtkGeometryFilter will delegate to vtkDataSetSurfaceFilter when it
/// encounters nonlinear cells.)
///
/// @section FastMode Fast Mode
///
/// vtkDataSetSurfaceFilter is sometimes used to simply render a 3D
/// dataset. In which case we only are concerned about an approximate
/// representation of the data and not necessarily the true exterior surface. In
/// that case, simply set the FastMode flag to true.
///
/// Currently FastMode is used when extracting surface from a structured dataset
/// or when `Delegation` is true. When Delegation is true, the flag is passed on
/// to `vtkGeometryFilter` (see `vtkGeometryFilter:SetFastMode`).
///
/// @warning
/// At one time, vtkDataSetSurfaceFilter was a faster version of
/// vtkGeometryFilter when processing unstructured grids, however
/// vtkGeometryFilter is now faster. Also, vtkDataSetSurfaceFilter typically
/// uses more memory than vtkGeometryFilter.  Consequently as a convenience to
/// the user, vtkDataSetSurfaceFilter will delegate to vtkGeometryFilter when
/// processing linear vtkUnstructuredGrids. This typically produces a 5-10x
/// speed up. (See vtkGeometryFilter for more information.) This delegation can
/// be disabled by setting the Delegation data member.
///
/// @warning
/// vtkDataSetSurfaceFilter will generally not preserve topological
/// connectivity.  In other words, the output polygonal primitives may not be
/// connected although in the originating dataset the boundary entities (e.g.,
/// faces) may have been connected. This can result in issues for filters that
/// expect proper topological connectivity (e.g., vtkQuadricDecimation or
/// vtkFeatureEdges).
///
/// @warning
/// A key step in this algorithm (for 3D cells) is to count the number times a
/// face is used by a cell. If used only once, then the face is considered a
/// boundary face and sent to the filter output. The filter determines this by
/// creating a hash table of faces: faces that are placed into the hash table
/// a single time are used only once, and therefore sent to the output. Thus
/// large amounts of extra memory is necessary to build the hash table. This
/// obsoleted approach requires a significant amount of memory, and is a
/// significant bottleneck to threading.
///
/// @warning
/// This filter may create duplicate points. Unlike vtkGeometryFilter, it does
/// not have the option to merge points. However it will eliminate points
/// not used by any output polygonal primitive (i.e., not on the boundary).
///
/// </remarks>
/// <seealso>
///
/// vtkGeometryFilter vtkStructuredGridGeometryFilter
/// </seealso>
public class vtkDataSetSurfaceFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetSurfaceFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataSetSurfaceFilter()
	{
		MRClassNameKey = "class vtkDataSetSurfaceFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetSurfaceFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataSetSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Statndard methods for object instantiation, type information, and printing.
	/// </summary>
	public new static vtkDataSetSurfaceFilter New()
	{
		vtkDataSetSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Statndard methods for object instantiation, type information, and printing.
	/// </summary>
	public vtkDataSetSurfaceFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataSetSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDataSetSurfaceFilter_DataSetExecute_01(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// Execute the filter on \a input and store the result in \a output.
	/// The correct function should be used accordingly to the type of the input.
	/// </summary>
	public virtual int DataSetExecute(vtkDataSet input, vtkPolyData output)
	{
		return vtkDataSetSurfaceFilter_DataSetExecute_01(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_DelegationOff_02(HandleRef pThis);

	/// <summary>
	/// Disable delegation to an internal vtkGeometryFilter. The geometry filter runs
	/// much faster (especially for unstructured grids); however the two filters
	/// produce slightly different output. Hence by default delegation is disabled.
	/// </summary>
	public virtual void DelegationOff()
	{
		vtkDataSetSurfaceFilter_DelegationOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_DelegationOn_03(HandleRef pThis);

	/// <summary>
	/// Disable delegation to an internal vtkGeometryFilter. The geometry filter runs
	/// much faster (especially for unstructured grids); however the two filters
	/// produce slightly different output. Hence by default delegation is disabled.
	/// </summary>
	public virtual void DelegationOn()
	{
		vtkDataSetSurfaceFilter_DelegationOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_FastModeOff_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast mode execution. If enabled, fast mode typically runs
	/// much faster (2-3x) than the standard algorithm, however the output is an
	/// approximation to the correct result. Also, note that the FastMode
	/// depends on the data member Degree for its execution.
	/// </summary>
	public virtual void FastModeOff()
	{
		vtkDataSetSurfaceFilter_FastModeOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_FastModeOn_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast mode execution. If enabled, fast mode typically runs
	/// much faster (2-3x) than the standard algorithm, however the output is an
	/// approximation to the correct result. Also, note that the FastMode
	/// depends on the data member Degree for its execution.
	/// </summary>
	public virtual void FastModeOn()
	{
		vtkDataSetSurfaceFilter_FastModeOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_GetDelegation_06(HandleRef pThis);

	/// <summary>
	/// Disable delegation to an internal vtkGeometryFilter. The geometry filter runs
	/// much faster (especially for unstructured grids); however the two filters
	/// produce slightly different output. Hence by default delegation is disabled.
	/// </summary>
	public virtual int GetDelegation()
	{
		return vtkDataSetSurfaceFilter_GetDelegation_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataSetSurfaceFilter_GetFastMode_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off fast mode execution. If enabled, fast mode typically runs
	/// much faster (2-3x) than the standard algorithm, however the output is an
	/// approximation to the correct result. Also, note that the FastMode
	/// depends on the data member Degree for its execution.
	/// </summary>
	public virtual bool GetFastMode()
	{
		return (vtkDataSetSurfaceFilter_GetFastMode_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_GetNonlinearSubdivisionLevel_08(HandleRef pThis);

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
		return vtkDataSetSurfaceFilter_GetNonlinearSubdivisionLevel_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetSurfaceFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Statndard methods for object instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataSetSurfaceFilter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataSetSurfaceFilter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Statndard methods for object instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataSetSurfaceFilter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetSurfaceFilter_GetOriginalCellIdsName_11(HandleRef pThis);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual string GetOriginalCellIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataSetSurfaceFilter_GetOriginalCellIdsName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetSurfaceFilter_GetOriginalPointIdsName_12(HandleRef pThis);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual string GetOriginalPointIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataSetSurfaceFilter_GetOriginalPointIdsName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_GetPassThroughCellIds_13(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughCellIds()
	{
		return vtkDataSetSurfaceFilter_GetPassThroughCellIds_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_GetPassThroughPointIds_14(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual int GetPassThroughPointIds()
	{
		return vtkDataSetSurfaceFilter_GetPassThroughPointIds_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_GetPieceInvariant_15(HandleRef pThis);

	/// <summary>
	/// If PieceInvariant is true, vtkDataSetSurfaceFilter requests
	/// 1 ghost level from input in order to remove internal surface
	/// that are between processes. False by default.
	/// </summary>
	public virtual int GetPieceInvariant()
	{
		return vtkDataSetSurfaceFilter_GetPieceInvariant_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Statndard methods for object instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataSetSurfaceFilter_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_IsTypeOf_17(string type);

	/// <summary>
	/// Statndard methods for object instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataSetSurfaceFilter_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetSurfaceFilter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Statndard methods for object instantiation, type information, and printing.
	/// </summary>
	public new vtkDataSetSurfaceFilter NewInstance()
	{
		vtkDataSetSurfaceFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetSurfaceFilter_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_PassThroughCellIdsOff_20(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOff()
	{
		vtkDataSetSurfaceFilter_PassThroughCellIdsOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_PassThroughCellIdsOn_21(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughCellIdsOn()
	{
		vtkDataSetSurfaceFilter_PassThroughCellIdsOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_PassThroughPointIdsOff_22(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughPointIdsOff()
	{
		vtkDataSetSurfaceFilter_PassThroughPointIdsOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_PassThroughPointIdsOn_23(HandleRef pThis);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void PassThroughPointIdsOn()
	{
		vtkDataSetSurfaceFilter_PassThroughPointIdsOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataSetSurfaceFilter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Statndard methods for object instantiation, type information, and printing.
	/// </summary>
	public new static vtkDataSetSurfaceFilter SafeDownCast(vtkObjectBase o)
	{
		vtkDataSetSurfaceFilter vtkDataSetSurfaceFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataSetSurfaceFilter_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSetSurfaceFilter2 = (vtkDataSetSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSetSurfaceFilter2.Register(null);
			}
		}
		return vtkDataSetSurfaceFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_SetDelegation_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Disable delegation to an internal vtkGeometryFilter. The geometry filter runs
	/// much faster (especially for unstructured grids); however the two filters
	/// produce slightly different output. Hence by default delegation is disabled.
	/// </summary>
	public virtual void SetDelegation(int _arg)
	{
		vtkDataSetSurfaceFilter_SetDelegation_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_SetFastMode_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off fast mode execution. If enabled, fast mode typically runs
	/// much faster (2-3x) than the standard algorithm, however the output is an
	/// approximation to the correct result. Also, note that the FastMode
	/// depends on the data member Degree for its execution.
	/// </summary>
	public virtual void SetFastMode(bool _arg)
	{
		vtkDataSetSurfaceFilter_SetFastMode_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_SetNonlinearSubdivisionLevel_27(HandleRef pThis, int _arg);

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
		vtkDataSetSurfaceFilter_SetNonlinearSubdivisionLevel_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_SetOriginalCellIdsName_28(HandleRef pThis, string _arg);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual void SetOriginalCellIdsName(string _arg)
	{
		vtkDataSetSurfaceFilter_SetOriginalCellIdsName_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_SetOriginalPointIdsName_29(HandleRef pThis, string _arg);

	/// <summary>
	/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
	/// control the name given to the field in which the ids are written into.  If
	/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
	/// is used, respectively.
	/// </summary>
	public virtual void SetOriginalPointIdsName(string _arg)
	{
		vtkDataSetSurfaceFilter_SetOriginalPointIdsName_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_SetPassThroughCellIds_30(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughCellIds(int _arg)
	{
		vtkDataSetSurfaceFilter_SetPassThroughCellIds_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_SetPassThroughPointIds_31(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, the output polygonal dataset will have a celldata array that
	/// holds the cell index of the original 3D cell that produced each output
	/// cell. This is useful for cell picking. The default is off to conserve
	/// memory.
	/// </summary>
	public virtual void SetPassThroughPointIds(int _arg)
	{
		vtkDataSetSurfaceFilter_SetPassThroughPointIds_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataSetSurfaceFilter_SetPieceInvariant_32(HandleRef pThis, int _arg);

	/// <summary>
	/// If PieceInvariant is true, vtkDataSetSurfaceFilter requests
	/// 1 ghost level from input in order to remove internal surface
	/// that are between processes. False by default.
	/// </summary>
	public virtual void SetPieceInvariant(int _arg)
	{
		vtkDataSetSurfaceFilter_SetPieceInvariant_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_StructuredExecute_33(HandleRef pThis, HandleRef input, HandleRef output, IntPtr ext, IntPtr wholeExt);

	/// <summary>
	/// Direct access methods so that this class can be used as an
	/// algorithm without using it as a filter (i.e., no pipeline updates).
	/// </summary>
	public virtual int StructuredExecute(vtkDataSet input, vtkPolyData output, IntPtr ext, IntPtr wholeExt)
	{
		return vtkDataSetSurfaceFilter_StructuredExecute_33(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), ext, wholeExt);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_UniformGridExecute_34(HandleRef pThis, HandleRef input, HandleRef output, IntPtr ext, IntPtr wholeExt, IntPtr extractface);

	/// <summary>
	/// Execute the filter on \a input and store the result in \a output.
	/// The correct function should be used accordingly to the type of the input.
	/// </summary>
	public virtual int UniformGridExecute(vtkDataSet input, vtkPolyData output, IntPtr ext, IntPtr wholeExt, IntPtr extractface)
	{
		return vtkDataSetSurfaceFilter_UniformGridExecute_34(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef), ext, wholeExt, extractface);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataSetSurfaceFilter_UnstructuredGridExecute_35(HandleRef pThis, HandleRef input, HandleRef output);

	/// <summary>
	/// Execute the filter on \a input and store the result in \a output.
	/// The correct function should be used accordingly to the type of the input.
	///
	/// Input can be any subclass of \a vtkUnstructuredGridBase.
	/// In case of a \a vtkUnstructuredGrid or subclass instance, an optimized version
	/// of the filter is executed.
	/// </summary>
	public virtual int UnstructuredGridExecute(vtkDataSet input, vtkPolyData output)
	{
		return vtkDataSetSurfaceFilter_UnstructuredGridExecute_35(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), output?.GetCppThis() ?? default(HandleRef));
	}
}
