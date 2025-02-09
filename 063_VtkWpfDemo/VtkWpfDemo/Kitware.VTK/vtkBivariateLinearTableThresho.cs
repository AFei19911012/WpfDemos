using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBivariateLinearTableThreshold
/// </summary>
/// <remarks>
///    performs line-based thresholding
/// for vtkTable data.
///
///
/// Class for filtering the rows of a two numeric columns of a vtkTable.  The
/// columns are treated as the two variables of a line.  This filter will
/// then iterate through the rows of the table determining if X,Y values pairs
/// are above/below/between/near one or more lines.
///
/// The "between" mode checks to see if a row is contained within the convex
/// hull of all of the specified lines.  The "near" mode checks if a row is
/// within a distance threshold two one of the specified lines.  This class
/// is used in conjunction with various plotting classes, so it is useful
/// to rescale the X,Y axes to a particular range of values.  Distance
/// comparisons can be performed in the scaled space by setting the CustomRanges
/// ivar and enabling UseNormalizedDistance.
/// </remarks>
public class vtkBivariateLinearTableThreshold : vtkTableAlgorithm
{
	/// <summary>
	/// Get the output as a table of row ids.
	/// </summary>
	public enum LinearThresholdType
	{
		/// <summary>enum member</summary>
		BLT_ABOVE = 0,
		/// <summary>enum member</summary>
		BLT_BELOW = 1,
		/// <summary>enum member</summary>
		BLT_BETWEEN = 3,
		/// <summary>enum member</summary>
		BLT_NEAR = 2
	}

	/// <summary>
	/// Get the output as a table of row ids.
	/// </summary>
	public enum OutputPorts
	{
		/// <summary>enum member</summary>
		OUTPUT_ROW_DATA = 1,
		/// <summary>enum member</summary>
		OUTPUT_ROW_IDS = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBivariateLinearTableThreshold";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBivariateLinearTableThreshold()
	{
		MRClassNameKey = "class vtkBivariateLinearTableThreshold";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBivariateLinearTableThreshold"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBivariateLinearTableThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBivariateLinearTableThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBivariateLinearTableThreshold New()
	{
		vtkBivariateLinearTableThreshold result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBivariateLinearTableThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBivariateLinearTableThreshold()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBivariateLinearTableThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_AddColumnToThreshold_01(HandleRef pThis, long column, long component);

	/// <summary>
	/// Add a numeric column to the pair of columns to be thresholded.  Call twice.
	/// </summary>
	public void AddColumnToThreshold(long column, long component)
	{
		vtkBivariateLinearTableThreshold_AddColumnToThreshold_01(GetCppThis(), column, component);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_02(HandleRef pThis, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Add a line for thresholding from two x,y points.
	/// </summary>
	public void AddLineEquation(IntPtr p1, IntPtr p2)
	{
		vtkBivariateLinearTableThreshold_AddLineEquation_02(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_03(HandleRef pThis, IntPtr p, double slope);

	/// <summary>
	/// Add a line for thresholding in point-slope form.
	/// </summary>
	public void AddLineEquation(IntPtr p, double slope)
	{
		vtkBivariateLinearTableThreshold_AddLineEquation_03(GetCppThis(), p, slope);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_AddLineEquation_04(HandleRef pThis, double a, double b, double c);

	/// <summary>
	/// Add a line for thresholding in implicit form (ax + by + c = 0)
	/// </summary>
	public void AddLineEquation(double a, double b, double c)
	{
		vtkBivariateLinearTableThreshold_AddLineEquation_04(GetCppThis(), a, b, c);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_ClearColumnsToThreshold_05(HandleRef pThis);

	/// <summary>
	/// Reset the columns to be thresholded.
	/// </summary>
	public void ClearColumnsToThreshold()
	{
		vtkBivariateLinearTableThreshold_ClearColumnsToThreshold_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_ClearLineEquations_06(HandleRef pThis);

	/// <summary>
	/// Reset the list of line equations.
	/// </summary>
	public void ClearLineEquations()
	{
		vtkBivariateLinearTableThreshold_ClearLineEquations_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_07(IntPtr p1, IntPtr p2, IntPtr abc);

	/// <summary>
	/// Convert the two-point line formula to implicit form.
	/// </summary>
	public static void ComputeImplicitLineFunction(IntPtr p1, IntPtr p2, IntPtr abc)
	{
		vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_07(p1, p2, abc);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_08(IntPtr p, double slope, IntPtr abc);

	/// <summary>
	/// Convert the point-slope line formula to implicit form.
	/// </summary>
	public static void ComputeImplicitLineFunction(IntPtr p, double slope, IntPtr abc)
	{
		vtkBivariateLinearTableThreshold_ComputeImplicitLineFunction_08(p, slope, abc);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBivariateLinearTableThreshold_GetColumnRanges_09(HandleRef pThis);

	/// <summary>
	/// Manually access the maximum/minimum x,y values.  This is used in
	/// conjunction with UseNormalizedDistance when determining if a row
	/// passes the threshold.
	/// </summary>
	public virtual double[] GetColumnRanges()
	{
		IntPtr intPtr = vtkBivariateLinearTableThreshold_GetColumnRanges_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_GetColumnRanges_10(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Manually access the maximum/minimum x,y values.  This is used in
	/// conjunction with UseNormalizedDistance when determining if a row
	/// passes the threshold.
	/// </summary>
	public virtual void GetColumnRanges(ref double _arg1, ref double _arg2)
	{
		vtkBivariateLinearTableThreshold_GetColumnRanges_10(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_GetColumnRanges_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Manually access the maximum/minimum x,y values.  This is used in
	/// conjunction with UseNormalizedDistance when determining if a row
	/// passes the threshold.
	/// </summary>
	public virtual void GetColumnRanges(IntPtr _arg)
	{
		vtkBivariateLinearTableThreshold_GetColumnRanges_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_GetColumnToThreshold_12(HandleRef pThis, long idx, ref long column, ref long component);

	/// <summary>
	/// Return the column number from the input table for the idx'th added column.
	/// </summary>
	public void GetColumnToThreshold(long idx, ref long column, ref long component)
	{
		vtkBivariateLinearTableThreshold_GetColumnToThreshold_12(GetCppThis(), idx, ref column, ref component);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBivariateLinearTableThreshold_GetDistanceThreshold_13(HandleRef pThis);

	/// <summary>
	/// The Cartesian distance within which a point will pass the near threshold.
	/// </summary>
	public virtual double GetDistanceThreshold()
	{
		return vtkBivariateLinearTableThreshold_GetDistanceThreshold_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBivariateLinearTableThreshold_GetInclusive_14(HandleRef pThis);

	/// <summary>
	/// Include the line in the threshold.  Essentially whether the threshold operation
	/// uses &gt; versus &gt;=.
	/// </summary>
	public virtual int GetInclusive()
	{
		return vtkBivariateLinearTableThreshold_GetInclusive_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBivariateLinearTableThreshold_GetLinearThresholdType_15(HandleRef pThis);

	/// <summary>
	/// Set the threshold type.  Above: find all rows that are above the specified
	/// lines.  Below: find all rows that are below the specified lines.  Near:
	/// find all rows that are near the specified lines.  Between: find all rows
	/// that are between the specified lines.
	/// </summary>
	public virtual int GetLinearThresholdType()
	{
		return vtkBivariateLinearTableThreshold_GetLinearThresholdType_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBivariateLinearTableThreshold_GetNumberOfColumnsToThreshold_16(HandleRef pThis);

	/// <summary>
	/// Return how many columns have been added.  Hopefully 2.
	/// </summary>
	public int GetNumberOfColumnsToThreshold()
	{
		return vtkBivariateLinearTableThreshold_GetNumberOfColumnsToThreshold_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBivariateLinearTableThreshold_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBivariateLinearTableThreshold_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBivariateLinearTableThreshold_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBivariateLinearTableThreshold_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBivariateLinearTableThreshold_GetSelectedRowIds_19(HandleRef pThis, int selection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a table of row ids.
	/// </summary>
	public vtkIdTypeArray GetSelectedRowIds(int selection)
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBivariateLinearTableThreshold_GetSelectedRowIds_19(GetCppThis(), selection, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBivariateLinearTableThreshold_GetUseNormalizedDistance_20(HandleRef pThis);

	/// <summary>
	/// Renormalize the space of the data such that the X and Y axes are
	/// "square" over the specified ColumnRanges.  This essentially scales
	/// the data space so that ColumnRanges[1]-ColumnRanges[0] = 1.0 and
	/// ColumnRanges[3]-ColumnRanges[2] = 1.0.  Used for scatter plot distance
	/// calculations.  Be sure to set DistanceThreshold accordingly, when used.
	/// </summary>
	public virtual int GetUseNormalizedDistance()
	{
		return vtkBivariateLinearTableThreshold_GetUseNormalizedDistance_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_Initialize_21(HandleRef pThis);

	/// <summary>
	/// Reset the columns to threshold, column ranges, etc.
	/// </summary>
	public void Initialize()
	{
		vtkBivariateLinearTableThreshold_Initialize_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBivariateLinearTableThreshold_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBivariateLinearTableThreshold_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBivariateLinearTableThreshold_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBivariateLinearTableThreshold_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBivariateLinearTableThreshold_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBivariateLinearTableThreshold NewInstance()
	{
		vtkBivariateLinearTableThreshold result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBivariateLinearTableThreshold_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBivariateLinearTableThreshold_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBivariateLinearTableThreshold SafeDownCast(vtkObjectBase o)
	{
		vtkBivariateLinearTableThreshold vtkBivariateLinearTableThreshold2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBivariateLinearTableThreshold_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBivariateLinearTableThreshold2 = (vtkBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBivariateLinearTableThreshold2.Register(null);
			}
		}
		return vtkBivariateLinearTableThreshold2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetColumnRanges_27(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Manually access the maximum/minimum x,y values.  This is used in
	/// conjunction with UseNormalizedDistance when determining if a row
	/// passes the threshold.
	/// </summary>
	public virtual void SetColumnRanges(double _arg1, double _arg2)
	{
		vtkBivariateLinearTableThreshold_SetColumnRanges_27(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetColumnRanges_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Manually access the maximum/minimum x,y values.  This is used in
	/// conjunction with UseNormalizedDistance when determining if a row
	/// passes the threshold.
	/// </summary>
	public void SetColumnRanges(IntPtr _arg)
	{
		vtkBivariateLinearTableThreshold_SetColumnRanges_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetDistanceThreshold_29(HandleRef pThis, double _arg);

	/// <summary>
	/// The Cartesian distance within which a point will pass the near threshold.
	/// </summary>
	public virtual void SetDistanceThreshold(double _arg)
	{
		vtkBivariateLinearTableThreshold_SetDistanceThreshold_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetInclusive_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Include the line in the threshold.  Essentially whether the threshold operation
	/// uses &gt; versus &gt;=.
	/// </summary>
	public virtual void SetInclusive(int _arg)
	{
		vtkBivariateLinearTableThreshold_SetInclusive_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdType_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the threshold type.  Above: find all rows that are above the specified
	/// lines.  Below: find all rows that are below the specified lines.  Near:
	/// find all rows that are near the specified lines.  Between: find all rows
	/// that are between the specified lines.
	/// </summary>
	public virtual void SetLinearThresholdType(int _arg)
	{
		vtkBivariateLinearTableThreshold_SetLinearThresholdType_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToAbove_32(HandleRef pThis);

	/// <summary>
	/// Set the threshold type.  Above: find all rows that are above the specified
	/// lines.  Below: find all rows that are below the specified lines.  Near:
	/// find all rows that are near the specified lines.  Between: find all rows
	/// that are between the specified lines.
	/// </summary>
	public void SetLinearThresholdTypeToAbove()
	{
		vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToAbove_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBelow_33(HandleRef pThis);

	/// <summary>
	/// Set the threshold type.  Above: find all rows that are above the specified
	/// lines.  Below: find all rows that are below the specified lines.  Near:
	/// find all rows that are near the specified lines.  Between: find all rows
	/// that are between the specified lines.
	/// </summary>
	public void SetLinearThresholdTypeToBelow()
	{
		vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBelow_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBetween_34(HandleRef pThis);

	/// <summary>
	/// Set the threshold type.  Above: find all rows that are above the specified
	/// lines.  Below: find all rows that are below the specified lines.  Near:
	/// find all rows that are near the specified lines.  Between: find all rows
	/// that are between the specified lines.
	/// </summary>
	public void SetLinearThresholdTypeToBetween()
	{
		vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToBetween_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToNear_35(HandleRef pThis);

	/// <summary>
	/// Set the threshold type.  Above: find all rows that are above the specified
	/// lines.  Below: find all rows that are below the specified lines.  Near:
	/// find all rows that are near the specified lines.  Between: find all rows
	/// that are between the specified lines.
	/// </summary>
	public void SetLinearThresholdTypeToNear()
	{
		vtkBivariateLinearTableThreshold_SetLinearThresholdTypeToNear_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_SetUseNormalizedDistance_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Renormalize the space of the data such that the X and Y axes are
	/// "square" over the specified ColumnRanges.  This essentially scales
	/// the data space so that ColumnRanges[1]-ColumnRanges[0] = 1.0 and
	/// ColumnRanges[3]-ColumnRanges[2] = 1.0.  Used for scatter plot distance
	/// calculations.  Be sure to set DistanceThreshold accordingly, when used.
	/// </summary>
	public virtual void SetUseNormalizedDistance(int _arg)
	{
		vtkBivariateLinearTableThreshold_SetUseNormalizedDistance_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_UseNormalizedDistanceOff_37(HandleRef pThis);

	/// <summary>
	/// Renormalize the space of the data such that the X and Y axes are
	/// "square" over the specified ColumnRanges.  This essentially scales
	/// the data space so that ColumnRanges[1]-ColumnRanges[0] = 1.0 and
	/// ColumnRanges[3]-ColumnRanges[2] = 1.0.  Used for scatter plot distance
	/// calculations.  Be sure to set DistanceThreshold accordingly, when used.
	/// </summary>
	public virtual void UseNormalizedDistanceOff()
	{
		vtkBivariateLinearTableThreshold_UseNormalizedDistanceOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBivariateLinearTableThreshold_UseNormalizedDistanceOn_38(HandleRef pThis);

	/// <summary>
	/// Renormalize the space of the data such that the X and Y axes are
	/// "square" over the specified ColumnRanges.  This essentially scales
	/// the data space so that ColumnRanges[1]-ColumnRanges[0] = 1.0 and
	/// ColumnRanges[3]-ColumnRanges[2] = 1.0.  Used for scatter plot distance
	/// calculations.  Be sure to set DistanceThreshold accordingly, when used.
	/// </summary>
	public virtual void UseNormalizedDistanceOn()
	{
		vtkBivariateLinearTableThreshold_UseNormalizedDistanceOn_38(GetCppThis());
	}
}
