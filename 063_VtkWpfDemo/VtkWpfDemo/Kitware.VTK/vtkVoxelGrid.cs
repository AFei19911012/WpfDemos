using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVoxelGrid
/// </summary>
/// <remarks>
///    subsample points using uniform binning
///
///
/// vtkVoxelGrid is a filter that subsamples a point cloud based on a regular
/// binning of space. Basically the algorithm operates by dividing space into
/// a volume of M x N x O bins, and then for each bin averaging all of the
/// points positions into a single representative point. Several strategies for
/// computing the binning can be used: 1) manual configuration of a requiring
/// specifying bin dimensions (the bounds are calculated from the data); 2) by
/// explicit specification of the bin size in world coordinates (x-y-z
/// lengths); and 3) an automatic process in which the user specifies an
/// approximate, average number of points per bin and dimensions and bin size
/// are computed automatically. (Note that under the hood a
/// vtkStaticPointLocator is used.)
///
/// While any vtkPointSet type can be provided as input, the output is
/// represented by an explicit representation of points via a
/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
/// contained in the output).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkStaticPointLocator vtkPointCloudFilter vtkQuadricClustering
/// </seealso>
public class vtkVoxelGrid : vtkPolyDataAlgorithm
{
	/// <summary>
	/// This enum is used to configure the operation of the filter.
	/// </summary>
	public enum Style
	{
		/// <summary>enum member</summary>
		AUTOMATIC = 2,
		/// <summary>enum member</summary>
		MANUAL = 0,
		/// <summary>enum member</summary>
		SPECIFY_LEAF_SIZE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVoxelGrid";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVoxelGrid()
	{
		MRClassNameKey = "class vtkVoxelGrid";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxelGrid"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVoxelGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkVoxelGrid New()
	{
		vtkVoxelGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoxelGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkVoxelGrid()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVoxelGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkVoxelGrid_GetConfigurationStyle_01(HandleRef pThis);

	/// <summary>
	/// Configure how the filter is to operate. The user can choose to manually
	/// specify the binning volume (by setting its dimensions via MANUAL style); or
	/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
	/// in AUTOMATIC style, use a rough average number of points in each bin
	/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
	/// configuration style is used.
	/// </summary>
	public virtual int GetConfigurationStyle()
	{
		return vtkVoxelGrid_GetConfigurationStyle_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelGrid_GetDivisions_02(HandleRef pThis);

	/// <summary>
	/// Set the number of divisions in x-y-z directions (the binning volume
	/// dimensions). This data member is used when the configuration style is
	/// set to MANUAL. Note that these values may be adjusted if &lt;1 or too
	/// large.
	/// </summary>
	public virtual int[] GetDivisions()
	{
		IntPtr intPtr = vtkVoxelGrid_GetDivisions_02(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_GetDivisions_03(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the number of divisions in x-y-z directions (the binning volume
	/// dimensions). This data member is used when the configuration style is
	/// set to MANUAL. Note that these values may be adjusted if &lt;1 or too
	/// large.
	/// </summary>
	public virtual void GetDivisions(IntPtr data)
	{
		vtkVoxelGrid_GetDivisions_03(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelGrid_GetKernel_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify an interpolation kernel to combine the point attributes. By
	/// default a vtkLinearKernel is used (i.e., average values). The
	/// interpolation kernel changes the basis of the interpolation.
	/// </summary>
	public virtual vtkInterpolationKernel GetKernel()
	{
		vtkInterpolationKernel vtkInterpolationKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelGrid_GetKernel_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInterpolationKernel2 = (vtkInterpolationKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInterpolationKernel2.Register(null);
			}
		}
		return vtkInterpolationKernel2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelGrid_GetLeafSize_05(HandleRef pThis);

	/// <summary>
	/// Set the bin size in the x-y-z directions. This data member is
	/// used when the configuration style is set to SPECIFY_LEAF_SIZE. The class will
	/// use these x-y-z lengths, within the bounding box of the point cloud,
	/// to determine the binning dimensions.
	/// </summary>
	public virtual double[] GetLeafSize()
	{
		IntPtr intPtr = vtkVoxelGrid_GetLeafSize_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_GetLeafSize_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the bin size in the x-y-z directions. This data member is
	/// used when the configuration style is set to SPECIFY_LEAF_SIZE. The class will
	/// use these x-y-z lengths, within the bounding box of the point cloud,
	/// to determine the binning dimensions.
	/// </summary>
	public virtual void GetLeafSize(IntPtr data)
	{
		vtkVoxelGrid_GetLeafSize_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoxelGrid_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVoxelGrid_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoxelGrid_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVoxelGrid_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelGrid_GetNumberOfPointsPerBin_09(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bin. Larger values
	/// result in higher rates of subsampling. This data member is used when the
	/// configuration style is set to AUTOMATIC. The class will automatically
	/// determine the binning dimensions in the x-y-z directions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBin()
	{
		return vtkVoxelGrid_GetNumberOfPointsPerBin_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelGrid_GetNumberOfPointsPerBinMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bin. Larger values
	/// result in higher rates of subsampling. This data member is used when the
	/// configuration style is set to AUTOMATIC. The class will automatically
	/// determine the binning dimensions in the x-y-z directions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBinMaxValue()
	{
		return vtkVoxelGrid_GetNumberOfPointsPerBinMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelGrid_GetNumberOfPointsPerBinMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the average number of points in each bin. Larger values
	/// result in higher rates of subsampling. This data member is used when the
	/// configuration style is set to AUTOMATIC. The class will automatically
	/// determine the binning dimensions in the x-y-z directions.
	/// </summary>
	public virtual int GetNumberOfPointsPerBinMinValue()
	{
		return vtkVoxelGrid_GetNumberOfPointsPerBinMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelGrid_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVoxelGrid_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoxelGrid_IsTypeOf_13(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVoxelGrid_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelGrid_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkVoxelGrid NewInstance()
	{
		vtkVoxelGrid result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelGrid_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoxelGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoxelGrid_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkVoxelGrid SafeDownCast(vtkObjectBase o)
	{
		vtkVoxelGrid vtkVoxelGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoxelGrid_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVoxelGrid2 = (vtkVoxelGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVoxelGrid2.Register(null);
			}
		}
		return vtkVoxelGrid2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetConfigurationStyle_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Configure how the filter is to operate. The user can choose to manually
	/// specify the binning volume (by setting its dimensions via MANUAL style); or
	/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
	/// in AUTOMATIC style, use a rough average number of points in each bin
	/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
	/// configuration style is used.
	/// </summary>
	public virtual void SetConfigurationStyle(int _arg)
	{
		vtkVoxelGrid_SetConfigurationStyle_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetConfigurationStyleToAutomatic_18(HandleRef pThis);

	/// <summary>
	/// Configure how the filter is to operate. The user can choose to manually
	/// specify the binning volume (by setting its dimensions via MANUAL style); or
	/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
	/// in AUTOMATIC style, use a rough average number of points in each bin
	/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
	/// configuration style is used.
	/// </summary>
	public void SetConfigurationStyleToAutomatic()
	{
		vtkVoxelGrid_SetConfigurationStyleToAutomatic_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetConfigurationStyleToLeafSize_19(HandleRef pThis);

	/// <summary>
	/// Configure how the filter is to operate. The user can choose to manually
	/// specify the binning volume (by setting its dimensions via MANUAL style); or
	/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
	/// in AUTOMATIC style, use a rough average number of points in each bin
	/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
	/// configuration style is used.
	/// </summary>
	public void SetConfigurationStyleToLeafSize()
	{
		vtkVoxelGrid_SetConfigurationStyleToLeafSize_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetConfigurationStyleToManual_20(HandleRef pThis);

	/// <summary>
	/// Configure how the filter is to operate. The user can choose to manually
	/// specify the binning volume (by setting its dimensions via MANUAL style); or
	/// specify a leaf bin size in the x-y-z directions (SPECIFY_LEAF_SIZE); or
	/// in AUTOMATIC style, use a rough average number of points in each bin
	/// guide the bin size and binning volume dimensions. By default, AUTOMATIC
	/// configuration style is used.
	/// </summary>
	public void SetConfigurationStyleToManual()
	{
		vtkVoxelGrid_SetConfigurationStyleToManual_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetDivisions_21(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set the number of divisions in x-y-z directions (the binning volume
	/// dimensions). This data member is used when the configuration style is
	/// set to MANUAL. Note that these values may be adjusted if &lt;1 or too
	/// large.
	/// </summary>
	public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
	{
		vtkVoxelGrid_SetDivisions_21(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetDivisions_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the number of divisions in x-y-z directions (the binning volume
	/// dimensions). This data member is used when the configuration style is
	/// set to MANUAL. Note that these values may be adjusted if &lt;1 or too
	/// large.
	/// </summary>
	public virtual void SetDivisions(IntPtr _arg)
	{
		vtkVoxelGrid_SetDivisions_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetKernel_23(HandleRef pThis, HandleRef kernel);

	/// <summary>
	/// Specify an interpolation kernel to combine the point attributes. By
	/// default a vtkLinearKernel is used (i.e., average values). The
	/// interpolation kernel changes the basis of the interpolation.
	/// </summary>
	public void SetKernel(vtkInterpolationKernel kernel)
	{
		vtkVoxelGrid_SetKernel_23(GetCppThis(), kernel?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetLeafSize_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the bin size in the x-y-z directions. This data member is
	/// used when the configuration style is set to SPECIFY_LEAF_SIZE. The class will
	/// use these x-y-z lengths, within the bounding box of the point cloud,
	/// to determine the binning dimensions.
	/// </summary>
	public virtual void SetLeafSize(double _arg1, double _arg2, double _arg3)
	{
		vtkVoxelGrid_SetLeafSize_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetLeafSize_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the bin size in the x-y-z directions. This data member is
	/// used when the configuration style is set to SPECIFY_LEAF_SIZE. The class will
	/// use these x-y-z lengths, within the bounding box of the point cloud,
	/// to determine the binning dimensions.
	/// </summary>
	public virtual void SetLeafSize(IntPtr _arg)
	{
		vtkVoxelGrid_SetLeafSize_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoxelGrid_SetNumberOfPointsPerBin_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the average number of points in each bin. Larger values
	/// result in higher rates of subsampling. This data member is used when the
	/// configuration style is set to AUTOMATIC. The class will automatically
	/// determine the binning dimensions in the x-y-z directions.
	/// </summary>
	public virtual void SetNumberOfPointsPerBin(int _arg)
	{
		vtkVoxelGrid_SetNumberOfPointsPerBin_26(GetCppThis(), _arg);
	}
}
