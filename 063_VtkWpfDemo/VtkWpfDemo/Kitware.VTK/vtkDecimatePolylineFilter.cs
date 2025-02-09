using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDecimatePolylineFilter
/// </summary>
/// <remarks>
///    reduce the number of lines in a polyline
///
/// vtkDecimatePolylineFilter is a filter to reduce the number of lines in a
/// polyline. The algorithm functions by evaluating an error metric for each
/// vertex (i.e., the distance of the vertex to a line defined from the two
/// vertices on either side of the vertex). Then, these vertices are placed
/// into a priority queue, and those with smaller errors are deleted first.
/// The decimation continues until the target reduction is reached. While the
/// filter will not delete end points, it will decimate closed loops down to a
/// single line, thereby changing topology.
///
/// Note that a maximum error value (expressed in world coordinates) can also
/// be specified. This may limit the amount of decimation so the target
/// reduction may not be met. By setting the maximum error value to a very
/// small number, colinear points can be eliminated.
///
/// @warning
/// This algorithm is a very simple implementation that overlooks some
/// potential complexities. For example, if a vertex is multiply connected,
/// meaning that it is used by multiple distinct polylines, then the extra
/// topological constraints are ignored. This can produce less than optimal
/// results.
///
/// </remarks>
/// <seealso>
///
/// vtkDecimate vtkDecimateProp vtkQuadricClustering vtkQuadricDecimation
/// </seealso>
public class vtkDecimatePolylineFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDecimatePolylineFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDecimatePolylineFilter()
	{
		MRClassNameKey = "class vtkDecimatePolylineFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDecimatePolylineFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDecimatePolylineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDecimatePolylineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this object with a target reduction of 0.90.
	/// </summary>
	public new static vtkDecimatePolylineFilter New()
	{
		vtkDecimatePolylineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDecimatePolylineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this object with a target reduction of 0.90.
	/// </summary>
	public vtkDecimatePolylineFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDecimatePolylineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkDecimatePolylineFilter_GetMaximumError_01(HandleRef pThis);

	/// <summary>
	/// Set the largest decimation error that is allowed during the decimation
	/// process. This may limit the maximum reduction that may be achieved. The
	/// maximum error is specified as a fraction of the maximum length of
	/// the input data bounding box.
	/// </summary>
	public virtual double GetMaximumError()
	{
		return vtkDecimatePolylineFilter_GetMaximumError_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePolylineFilter_GetMaximumErrorMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set the largest decimation error that is allowed during the decimation
	/// process. This may limit the maximum reduction that may be achieved. The
	/// maximum error is specified as a fraction of the maximum length of
	/// the input data bounding box.
	/// </summary>
	public virtual double GetMaximumErrorMaxValue()
	{
		return vtkDecimatePolylineFilter_GetMaximumErrorMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePolylineFilter_GetMaximumErrorMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set the largest decimation error that is allowed during the decimation
	/// process. This may limit the maximum reduction that may be achieved. The
	/// maximum error is specified as a fraction of the maximum length of
	/// the input data bounding box.
	/// </summary>
	public virtual double GetMaximumErrorMinValue()
	{
		return vtkDecimatePolylineFilter_GetMaximumErrorMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDecimatePolylineFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDecimatePolylineFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDecimatePolylineFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDecimatePolylineFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePolylineFilter_GetOutputPointsPrecision_06(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkDecimatePolylineFilter_GetOutputPointsPrecision_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePolylineFilter_GetTargetReduction_07(HandleRef pThis);

	/// <summary>
	/// Specify the desired reduction in the total number of polygons (e.g., if
	/// TargetReduction is set to 0.9, this filter will try to reduce the data set
	/// to 10% of its original size).
	/// </summary>
	public virtual double GetTargetReduction()
	{
		return vtkDecimatePolylineFilter_GetTargetReduction_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePolylineFilter_GetTargetReductionMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the desired reduction in the total number of polygons (e.g., if
	/// TargetReduction is set to 0.9, this filter will try to reduce the data set
	/// to 10% of its original size).
	/// </summary>
	public virtual double GetTargetReductionMaxValue()
	{
		return vtkDecimatePolylineFilter_GetTargetReductionMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePolylineFilter_GetTargetReductionMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the desired reduction in the total number of polygons (e.g., if
	/// TargetReduction is set to 0.9, this filter will try to reduce the data set
	/// to 10% of its original size).
	/// </summary>
	public virtual double GetTargetReductionMinValue()
	{
		return vtkDecimatePolylineFilter_GetTargetReductionMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePolylineFilter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDecimatePolylineFilter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePolylineFilter_IsTypeOf_11(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDecimatePolylineFilter_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDecimatePolylineFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkDecimatePolylineFilter NewInstance()
	{
		vtkDecimatePolylineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDecimatePolylineFilter_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDecimatePolylineFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkDecimatePolylineFilter SafeDownCast(vtkObjectBase o)
	{
		vtkDecimatePolylineFilter vtkDecimatePolylineFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDecimatePolylineFilter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDecimatePolylineFilter2 = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDecimatePolylineFilter2.Register(null);
			}
		}
		return vtkDecimatePolylineFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePolylineFilter_SetMaximumError_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the largest decimation error that is allowed during the decimation
	/// process. This may limit the maximum reduction that may be achieved. The
	/// maximum error is specified as a fraction of the maximum length of
	/// the input data bounding box.
	/// </summary>
	public virtual void SetMaximumError(double _arg)
	{
		vtkDecimatePolylineFilter_SetMaximumError_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePolylineFilter_SetOutputPointsPrecision_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkDecimatePolylineFilter_SetOutputPointsPrecision_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePolylineFilter_SetTargetReduction_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the desired reduction in the total number of polygons (e.g., if
	/// TargetReduction is set to 0.9, this filter will try to reduce the data set
	/// to 10% of its original size).
	/// </summary>
	public virtual void SetTargetReduction(double _arg)
	{
		vtkDecimatePolylineFilter_SetTargetReduction_17(GetCppThis(), _arg);
	}
}
