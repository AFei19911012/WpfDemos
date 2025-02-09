using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStatisticalOutlierRemoval
/// </summary>
/// <remarks>
///    remove sparse outlier points
///
///
/// The vtkStatisticalOutlierRemoval filter removes sparse outlier points
/// through statistical analysis. The average (mean) distance between points
/// in the point cloud is computed (taking a local sample size around each
/// point); followed by computation of the global standard deviation of
/// distances between points. This global, statistical information is compared
/// against the mean separation distance for each point; those points whose
/// average separation is greater than the user-specified variation in
/// a multiple of standard deviation are removed.
///
/// Note that while any vtkPointSet type can be provided as input, the output is
/// represented by an explicit representation of points via a
/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
/// contained in the output). Also, after filter execution, the user can
/// request a vtkIdType* map which indicates how the input points were mapped
/// to the output. A value of map[i] (where i is the ith input point) less
/// than 0 means that the ith input point was removed. (See also the
/// superclass documentation for accessing the removed points through the
/// filter's second output.)
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPointCloudFilter vtkRadiusOutlierRemoval vtkExtractPoints
/// vtkThresholdPoints
/// </seealso>
public class vtkStatisticalOutlierRemoval : vtkPointCloudFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStatisticalOutlierRemoval";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStatisticalOutlierRemoval()
	{
		MRClassNameKey = "class vtkStatisticalOutlierRemoval";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStatisticalOutlierRemoval"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStatisticalOutlierRemoval(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStatisticalOutlierRemoval_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkStatisticalOutlierRemoval New()
	{
		vtkStatisticalOutlierRemoval result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStatisticalOutlierRemoval_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStatisticalOutlierRemoval)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkStatisticalOutlierRemoval()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStatisticalOutlierRemoval_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetComputedMean_01(HandleRef pThis);

	/// <summary>
	/// After execution, return the value of the computed mean. Before execution
	/// the value returned is invalid.
	/// </summary>
	public virtual double GetComputedMean()
	{
		return vtkStatisticalOutlierRemoval_GetComputedMean_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetComputedMeanMaxValue_02(HandleRef pThis);

	/// <summary>
	/// After execution, return the value of the computed mean. Before execution
	/// the value returned is invalid.
	/// </summary>
	public virtual double GetComputedMeanMaxValue()
	{
		return vtkStatisticalOutlierRemoval_GetComputedMeanMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetComputedMeanMinValue_03(HandleRef pThis);

	/// <summary>
	/// After execution, return the value of the computed mean. Before execution
	/// the value returned is invalid.
	/// </summary>
	public virtual double GetComputedMeanMinValue()
	{
		return vtkStatisticalOutlierRemoval_GetComputedMeanMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetComputedStandardDeviation_04(HandleRef pThis);

	/// <summary>
	/// After execution, return the value of the computed sigma (standard
	/// deviation). Before execution the value returned is invalid.
	/// </summary>
	public virtual double GetComputedStandardDeviation()
	{
		return vtkStatisticalOutlierRemoval_GetComputedStandardDeviation_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetComputedStandardDeviationMaxValue_05(HandleRef pThis);

	/// <summary>
	/// After execution, return the value of the computed sigma (standard
	/// deviation). Before execution the value returned is invalid.
	/// </summary>
	public virtual double GetComputedStandardDeviationMaxValue()
	{
		return vtkStatisticalOutlierRemoval_GetComputedStandardDeviationMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetComputedStandardDeviationMinValue_06(HandleRef pThis);

	/// <summary>
	/// After execution, return the value of the computed sigma (standard
	/// deviation). Before execution the value returned is invalid.
	/// </summary>
	public virtual double GetComputedStandardDeviationMinValue()
	{
		return vtkStatisticalOutlierRemoval_GetComputedStandardDeviationMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStatisticalOutlierRemoval_GetLocator_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// surroinding a sample point.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStatisticalOutlierRemoval_GetLocator_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStatisticalOutlierRemoval_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStatisticalOutlierRemoval_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStatisticalOutlierRemoval_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStatisticalOutlierRemoval_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticalOutlierRemoval_GetSampleSize_10(HandleRef pThis);

	/// <summary>
	/// For each point sampled, specify the number of the closest, surrounding
	/// points used to compute statistics. By default 25 points are used. Smaller
	/// numbers may speed performance.
	/// </summary>
	public virtual int GetSampleSize()
	{
		return vtkStatisticalOutlierRemoval_GetSampleSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticalOutlierRemoval_GetSampleSizeMaxValue_11(HandleRef pThis);

	/// <summary>
	/// For each point sampled, specify the number of the closest, surrounding
	/// points used to compute statistics. By default 25 points are used. Smaller
	/// numbers may speed performance.
	/// </summary>
	public virtual int GetSampleSizeMaxValue()
	{
		return vtkStatisticalOutlierRemoval_GetSampleSizeMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticalOutlierRemoval_GetSampleSizeMinValue_12(HandleRef pThis);

	/// <summary>
	/// For each point sampled, specify the number of the closest, surrounding
	/// points used to compute statistics. By default 25 points are used. Smaller
	/// numbers may speed performance.
	/// </summary>
	public virtual int GetSampleSizeMinValue()
	{
		return vtkStatisticalOutlierRemoval_GetSampleSizeMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetStandardDeviationFactor_13(HandleRef pThis);

	/// <summary>
	/// The filter uses this specified standard deviation factor to extract
	/// points. By default, points within 1.0 standard deviations (i.e., a
	/// StandardDeviationFactor=1.0) of the mean distance to neighboring
	/// points are retained.
	/// </summary>
	public virtual double GetStandardDeviationFactor()
	{
		return vtkStatisticalOutlierRemoval_GetStandardDeviationFactor_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetStandardDeviationFactorMaxValue_14(HandleRef pThis);

	/// <summary>
	/// The filter uses this specified standard deviation factor to extract
	/// points. By default, points within 1.0 standard deviations (i.e., a
	/// StandardDeviationFactor=1.0) of the mean distance to neighboring
	/// points are retained.
	/// </summary>
	public virtual double GetStandardDeviationFactorMaxValue()
	{
		return vtkStatisticalOutlierRemoval_GetStandardDeviationFactorMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStatisticalOutlierRemoval_GetStandardDeviationFactorMinValue_15(HandleRef pThis);

	/// <summary>
	/// The filter uses this specified standard deviation factor to extract
	/// points. By default, points within 1.0 standard deviations (i.e., a
	/// StandardDeviationFactor=1.0) of the mean distance to neighboring
	/// points are retained.
	/// </summary>
	public virtual double GetStandardDeviationFactorMinValue()
	{
		return vtkStatisticalOutlierRemoval_GetStandardDeviationFactorMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticalOutlierRemoval_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStatisticalOutlierRemoval_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStatisticalOutlierRemoval_IsTypeOf_17(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStatisticalOutlierRemoval_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStatisticalOutlierRemoval_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkStatisticalOutlierRemoval NewInstance()
	{
		vtkStatisticalOutlierRemoval result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStatisticalOutlierRemoval_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStatisticalOutlierRemoval)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStatisticalOutlierRemoval_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkStatisticalOutlierRemoval SafeDownCast(vtkObjectBase o)
	{
		vtkStatisticalOutlierRemoval vtkStatisticalOutlierRemoval2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStatisticalOutlierRemoval_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStatisticalOutlierRemoval2 = (vtkStatisticalOutlierRemoval)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStatisticalOutlierRemoval2.Register(null);
			}
		}
		return vtkStatisticalOutlierRemoval2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticalOutlierRemoval_SetComputedMean_21(HandleRef pThis, double _arg);

	/// <summary>
	/// After execution, return the value of the computed mean. Before execution
	/// the value returned is invalid.
	/// </summary>
	public virtual void SetComputedMean(double _arg)
	{
		vtkStatisticalOutlierRemoval_SetComputedMean_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticalOutlierRemoval_SetComputedStandardDeviation_22(HandleRef pThis, double _arg);

	/// <summary>
	/// After execution, return the value of the computed sigma (standard
	/// deviation). Before execution the value returned is invalid.
	/// </summary>
	public virtual void SetComputedStandardDeviation(double _arg)
	{
		vtkStatisticalOutlierRemoval_SetComputedStandardDeviation_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticalOutlierRemoval_SetLocator_23(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// surroinding a sample point.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkStatisticalOutlierRemoval_SetLocator_23(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticalOutlierRemoval_SetSampleSize_24(HandleRef pThis, int _arg);

	/// <summary>
	/// For each point sampled, specify the number of the closest, surrounding
	/// points used to compute statistics. By default 25 points are used. Smaller
	/// numbers may speed performance.
	/// </summary>
	public virtual void SetSampleSize(int _arg)
	{
		vtkStatisticalOutlierRemoval_SetSampleSize_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStatisticalOutlierRemoval_SetStandardDeviationFactor_25(HandleRef pThis, double _arg);

	/// <summary>
	/// The filter uses this specified standard deviation factor to extract
	/// points. By default, points within 1.0 standard deviations (i.e., a
	/// StandardDeviationFactor=1.0) of the mean distance to neighboring
	/// points are retained.
	/// </summary>
	public virtual void SetStandardDeviationFactor(double _arg)
	{
		vtkStatisticalOutlierRemoval_SetStandardDeviationFactor_25(GetCppThis(), _arg);
	}
}
