using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCleanPolyData
/// </summary>
/// <remarks>
///    merge duplicate points, and/or remove unused points and/or remove degenerate cells
///
/// vtkCleanPolyData is a filter that takes polygonal data as input and
/// generates polygonal data as output. vtkCleanPolyData will merge duplicate
/// points (within specified tolerance and if enabled), eliminate points
/// that are not used in any cell, and if enabled, transform degenerate cells into
/// appropriate forms (for example, a triangle is converted into a line
/// if two points of triangle are merged).
///
/// Conversion of degenerate cells is controlled by the flags
/// ConvertLinesToPoints, ConvertPolysToLines, ConvertStripsToPolys which act
/// cumulatively such that a degenerate strip may become a poly.
/// The full set is
/// Line with 1 points -&gt; Vert (if ConvertLinesToPoints)
/// Poly with 2 points -&gt; Line (if ConvertPolysToLines)
/// Poly with 1 points -&gt; Vert (if ConvertPolysToLines &amp;&amp; ConvertLinesToPoints)
/// Strp with 3 points -&gt; Poly (if ConvertStripsToPolys)
/// Strp with 2 points -&gt; Line (if ConvertStripsToPolys &amp;&amp; ConvertPolysToLines)
/// Strp with 1 points -&gt; Vert (if ConvertStripsToPolys &amp;&amp; ConvertPolysToLines
///   &amp;&amp; ConvertLinesToPoints)
///
/// Cells of type VTK_POLY_LINE will be converted to a vertex only if
/// ConvertLinesToPoints is on and all points are merged into one. Degenerate line
/// segments (with two identical end points) will be removed.
///
/// If tolerance is specified precisely=0.0, then vtkCleanPolyData will use
/// the vtkMergePoints object to merge points (which is faster). Otherwise the
/// slower vtkIncrementalPointLocator is used.  Before inserting points into the point
/// locator, this class calls a function OperateOnPoint which can be used (in
/// subclasses) to further refine the cleaning process. See
/// vtkQuantizePolyDataPoints.
///
/// In addition, if a point global id array is available, then two points are merged
/// if and only if they share the same global id.
///
/// Note that merging of points can be disabled. In this case, a point locator
/// will not be used, and points that are not used by any cells will be
/// eliminated, but never merged.
///
/// @warning
/// Merging points can alter topology, including introducing non-manifold
/// forms. The tolerance should be chosen carefully to avoid these problems.
/// Subclasses should handle OperateOnBounds as well as OperateOnPoint
/// to ensure that the locator is correctly initialized (i.e. all modified
/// points must lie inside modified bounds).
///
/// @warning
/// If you wish to operate on a set of point coordinates that has no cells,
/// you must add a vtkPolyVertex cell with all of the points to the PolyData
/// (or use a vtkVertexGlyphFilter) before using the vtkCleanPolyData filter.
///
/// @warning
/// The vtkStaticCleanPolyData filter is similar in operation to
/// vtkCleanPolyData. However, vtkStaticCleanPolyData is non-incremental and
/// uses a much faster threading approach (especially for larger datasets, and
/// when merging points with a non-zero tolerance). However because of the
/// difference in the traversal order in the point merging process, the output
/// of the filters may be different.
///
/// </remarks>
/// <seealso>
///
/// vtkQuantizePolyDataPoints vtkStaticCleanPolyData
/// vtkStaticCleanUnstructuredGrid
/// </seealso>
public class vtkCleanPolyData : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCleanPolyData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCleanPolyData()
	{
		MRClassNameKey = "class vtkCleanPolyData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCleanPolyData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCleanPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCleanPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCleanPolyData New()
	{
		vtkCleanPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCleanPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCleanPolyData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCleanPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ConvertLinesToPointsOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate lines to points. Default is On.
	/// </summary>
	public virtual void ConvertLinesToPointsOff()
	{
		vtkCleanPolyData_ConvertLinesToPointsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ConvertLinesToPointsOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate lines to points. Default is On.
	/// </summary>
	public virtual void ConvertLinesToPointsOn()
	{
		vtkCleanPolyData_ConvertLinesToPointsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ConvertPolysToLinesOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate polys to lines. Default is On.
	/// </summary>
	public virtual void ConvertPolysToLinesOff()
	{
		vtkCleanPolyData_ConvertPolysToLinesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ConvertPolysToLinesOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate polys to lines. Default is On.
	/// </summary>
	public virtual void ConvertPolysToLinesOn()
	{
		vtkCleanPolyData_ConvertPolysToLinesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ConvertStripsToPolysOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate strips to polys. Default is On.
	/// </summary>
	public virtual void ConvertStripsToPolysOff()
	{
		vtkCleanPolyData_ConvertStripsToPolysOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ConvertStripsToPolysOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate strips to polys. Default is On.
	/// </summary>
	public virtual void ConvertStripsToPolysOn()
	{
		vtkCleanPolyData_ConvertStripsToPolysOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_CreateDefaultLocator_07(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Create default locator. Used to create one when none is specified.
	/// </summary>
	public void CreateDefaultLocator(vtkPolyData input)
	{
		vtkCleanPolyData_CreateDefaultLocator_07(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCleanPolyData_GetAbsoluteTolerance_08(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in absolute terms. Default is 1.0.
	/// </summary>
	public virtual double GetAbsoluteTolerance()
	{
		return vtkCleanPolyData_GetAbsoluteTolerance_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCleanPolyData_GetAbsoluteToleranceMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in absolute terms. Default is 1.0.
	/// </summary>
	public virtual double GetAbsoluteToleranceMaxValue()
	{
		return vtkCleanPolyData_GetAbsoluteToleranceMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCleanPolyData_GetAbsoluteToleranceMinValue_10(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in absolute terms. Default is 1.0.
	/// </summary>
	public virtual double GetAbsoluteToleranceMinValue()
	{
		return vtkCleanPolyData_GetAbsoluteToleranceMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_GetConvertLinesToPoints_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate lines to points. Default is On.
	/// </summary>
	public virtual int GetConvertLinesToPoints()
	{
		return vtkCleanPolyData_GetConvertLinesToPoints_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_GetConvertPolysToLines_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate polys to lines. Default is On.
	/// </summary>
	public virtual int GetConvertPolysToLines()
	{
		return vtkCleanPolyData_GetConvertPolysToLines_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_GetConvertStripsToPolys_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off conversion of degenerate strips to polys. Default is On.
	/// </summary>
	public virtual int GetConvertStripsToPolys()
	{
		return vtkCleanPolyData_GetConvertStripsToPolys_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCleanPolyData_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a spatial locator for speeding the search process. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public virtual vtkIncrementalPointLocator GetLocator()
	{
		vtkIncrementalPointLocator vtkIncrementalPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCleanPolyData_GetLocator_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkCleanPolyData_GetMTime_15(HandleRef pThis);

	/// <summary>
	/// Get the MTime of this object also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkCleanPolyData_GetMTime_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCleanPolyData_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCleanPolyData_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCleanPolyData_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCleanPolyData_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_GetOutputPointsPrecision_18(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkCleanPolyData_GetOutputPointsPrecision_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_GetPieceInvariant_19(HandleRef pThis);

	/// <summary>
	/// Perform operation on bounds
	/// </summary>
	public virtual int GetPieceInvariant()
	{
		return vtkCleanPolyData_GetPieceInvariant_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_GetPointMerging_20(HandleRef pThis);

	/// <summary>
	/// Set/Get a boolean value that controls whether point merging is
	/// performed. If on, a locator will be used, and points laying within
	/// the appropriate tolerance may be merged. If off, points are never
	/// merged. By default, merging is on.
	/// </summary>
	public virtual int GetPointMerging()
	{
		return vtkCleanPolyData_GetPointMerging_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCleanPolyData_GetTolerance_21(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in terms of fraction of bounding box length.
	/// Default is 0.0.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkCleanPolyData_GetTolerance_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_GetToleranceIsAbsolute_22(HandleRef pThis);

	/// <summary>
	/// By default ToleranceIsAbsolute is false and Tolerance is
	/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
	/// used when adding points to locator (merging)
	/// </summary>
	public virtual int GetToleranceIsAbsolute()
	{
		return vtkCleanPolyData_GetToleranceIsAbsolute_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCleanPolyData_GetToleranceMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in terms of fraction of bounding box length.
	/// Default is 0.0.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkCleanPolyData_GetToleranceMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCleanPolyData_GetToleranceMinValue_24(HandleRef pThis);

	/// <summary>
	/// Specify tolerance in terms of fraction of bounding box length.
	/// Default is 0.0.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkCleanPolyData_GetToleranceMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCleanPolyData_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCleanPolyData_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCleanPolyData_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCleanPolyData_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCleanPolyData NewInstance()
	{
		vtkCleanPolyData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCleanPolyData_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_OperateOnBounds_29(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Perform operation on bounds
	/// </summary>
	public virtual void OperateOnBounds(IntPtr arg0, IntPtr arg1)
	{
		vtkCleanPolyData_OperateOnBounds_29(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_OperateOnPoint_30(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Perform operation on a point
	/// </summary>
	public virtual void OperateOnPoint(IntPtr arg0, IntPtr arg1)
	{
		vtkCleanPolyData_OperateOnPoint_30(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_PieceInvariantOff_31(HandleRef pThis);

	/// <summary>
	/// Perform operation on bounds
	/// </summary>
	public virtual void PieceInvariantOff()
	{
		vtkCleanPolyData_PieceInvariantOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_PieceInvariantOn_32(HandleRef pThis);

	/// <summary>
	/// Perform operation on bounds
	/// </summary>
	public virtual void PieceInvariantOn()
	{
		vtkCleanPolyData_PieceInvariantOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_PointMergingOff_33(HandleRef pThis);

	/// <summary>
	/// Set/Get a boolean value that controls whether point merging is
	/// performed. If on, a locator will be used, and points laying within
	/// the appropriate tolerance may be merged. If off, points are never
	/// merged. By default, merging is on.
	/// </summary>
	public virtual void PointMergingOff()
	{
		vtkCleanPolyData_PointMergingOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_PointMergingOn_34(HandleRef pThis);

	/// <summary>
	/// Set/Get a boolean value that controls whether point merging is
	/// performed. If on, a locator will be used, and points laying within
	/// the appropriate tolerance may be merged. If off, points are never
	/// merged. By default, merging is on.
	/// </summary>
	public virtual void PointMergingOn()
	{
		vtkCleanPolyData_PointMergingOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ReleaseLocator_35(HandleRef pThis);

	/// <summary>
	/// Release locator
	/// </summary>
	public void ReleaseLocator()
	{
		vtkCleanPolyData_ReleaseLocator_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCleanPolyData_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCleanPolyData SafeDownCast(vtkObjectBase o)
	{
		vtkCleanPolyData vtkCleanPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCleanPolyData_SafeDownCast_36(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCleanPolyData2 = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCleanPolyData2.Register(null);
			}
		}
		return vtkCleanPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetAbsoluteTolerance_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify tolerance in absolute terms. Default is 1.0.
	/// </summary>
	public virtual void SetAbsoluteTolerance(double _arg)
	{
		vtkCleanPolyData_SetAbsoluteTolerance_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetConvertLinesToPoints_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off conversion of degenerate lines to points. Default is On.
	/// </summary>
	public virtual void SetConvertLinesToPoints(int _arg)
	{
		vtkCleanPolyData_SetConvertLinesToPoints_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetConvertPolysToLines_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off conversion of degenerate polys to lines. Default is On.
	/// </summary>
	public virtual void SetConvertPolysToLines(int _arg)
	{
		vtkCleanPolyData_SetConvertPolysToLines_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetConvertStripsToPolys_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off conversion of degenerate strips to polys. Default is On.
	/// </summary>
	public virtual void SetConvertStripsToPolys(int _arg)
	{
		vtkCleanPolyData_SetConvertStripsToPolys_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetLocator_41(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Set/Get a spatial locator for speeding the search process. By
	/// default an instance of vtkMergePoints is used.
	/// </summary>
	public virtual void SetLocator(vtkIncrementalPointLocator locator)
	{
		vtkCleanPolyData_SetLocator_41(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetOutputPointsPrecision_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkCleanPolyData_SetOutputPointsPrecision_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetPieceInvariant_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Perform operation on bounds
	/// </summary>
	public virtual void SetPieceInvariant(int _arg)
	{
		vtkCleanPolyData_SetPieceInvariant_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetPointMerging_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get a boolean value that controls whether point merging is
	/// performed. If on, a locator will be used, and points laying within
	/// the appropriate tolerance may be merged. If off, points are never
	/// merged. By default, merging is on.
	/// </summary>
	public virtual void SetPointMerging(int _arg)
	{
		vtkCleanPolyData_SetPointMerging_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetTolerance_45(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify tolerance in terms of fraction of bounding box length.
	/// Default is 0.0.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkCleanPolyData_SetTolerance_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_SetToleranceIsAbsolute_46(HandleRef pThis, int _arg);

	/// <summary>
	/// By default ToleranceIsAbsolute is false and Tolerance is
	/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
	/// used when adding points to locator (merging)
	/// </summary>
	public virtual void SetToleranceIsAbsolute(int _arg)
	{
		vtkCleanPolyData_SetToleranceIsAbsolute_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ToleranceIsAbsoluteOff_47(HandleRef pThis);

	/// <summary>
	/// By default ToleranceIsAbsolute is false and Tolerance is
	/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
	/// used when adding points to locator (merging)
	/// </summary>
	public virtual void ToleranceIsAbsoluteOff()
	{
		vtkCleanPolyData_ToleranceIsAbsoluteOff_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCleanPolyData_ToleranceIsAbsoluteOn_48(HandleRef pThis);

	/// <summary>
	/// By default ToleranceIsAbsolute is false and Tolerance is
	/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
	/// used when adding points to locator (merging)
	/// </summary>
	public virtual void ToleranceIsAbsoluteOn()
	{
		vtkCleanPolyData_ToleranceIsAbsoluteOn_48(GetCppThis());
	}
}
