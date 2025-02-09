using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBinnedDecimation
/// </summary>
/// <remarks>
///    reduce the number of triangles in a vtkPolyData mesh
///
/// vtkBinnedDecimation is a filter to reduce the number of triangles in a
/// triangle mesh represented by vtkPolyData. It is similar to
/// vtkQuadricClustering in concept, although it is performance accelerated:
/// it does not use quadric error metrics to position points in the bins, plus
/// it is threaded. (See vtkQuadricClustering for more information.) It also
/// takes some short cuts in the interest of speed: it limits the binning
/// resolution to no more than 2^31 bins; and it can (optionally) reuse the input
/// points in the output (to save memory and computational costs).
///
/// A high-level overview of the algorithm is as follows. Points are binned
/// into a regular grid subdivided in the x-y-z directions. The idea is to
/// combine all the points within each bin into a single point which is then
/// used by the output triangles. Four options are available to generate the
/// output points. If the input points are to be reused as the output points,
/// then all points in the same bin simply adopt the coordinates of one of the
/// selected points in the bin (and thus all points in the bin take on the
/// same output point id). Alternatively, if new output points are to be
/// generated, then either one point is selected; the centers of occupied bins
/// can be used as the output point coordinates; or an average position of all
/// points falling into the bin can be used to generate the bin
/// point. Finally, triangles are inserted into the output: triangles whose
/// three, binned points lie in separate bins are sent to the output, while
/// all others are discarded (i.e., triangles with two or more points in the
/// same bin are not sent to the output).
///
/// To use this filter, specify the divisions defining the spatial subdivision
/// in the x, y, and z directions. Of course you must also specify an input
/// vtkPolyData / filter connection. Higher division levels generally produce
/// results closer to the original mesh. Note that for performance reasons
/// (i.e., related to memory), the maximum divisions in the x-y-z directions
/// is limited in such a way (i.e., proportional scaling of divisions is used)
/// so as to ensure that no more than 2^31 bins are used. Higher divisions have
/// modest impact on the overall performance of the algorithm, although the
/// resolution of the output vtkPolyData is affected significantly (i.e., many
/// more triangles may be generated).
///
/// @warning
/// This filter can drastically affect mesh topology, i.e., topology is not
/// preserved.
///
/// @warning
/// This filter and vtkQuadricClustering produce similar results, with
/// vtkQuadricClustering theoretically producing better results. In practice
/// however, vtkBinnedDecimation produces results that are visually close to
/// vtkQuadricClustering at speeds approaching 10-100x faster (depending on
/// the bin divisions, and how the output points are generated), and the
/// algorithm requires much less memory. Note that the API of this filter is a
/// subset of vtkQuadricClustering and can often be used interchangeably with
/// vtkQuadricClustering.
///
/// @warning
/// Algorithm 4) BIN_CENTERS uses a very different implementation strategy
/// requiring a sort of all points. It scales better as the number of bins
/// increases.
///
/// @warning
/// For certain types of geometry (e.g., a mostly 2D plane with jitter in the
/// normal direction), this decimator can perform badly. In this situation,
/// set the number of bins in the normal direction to one.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential execution type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkQuadricClustering vtkDecimatePro vtkDecimate vtkQuadricLODActor
/// vtkTriangleFilter
/// </seealso>
public class vtkBinnedDecimation : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public enum BIN_AVERAGES_WrapperEnum
	{
		/// <summary>enum member</summary>
		BIN_AVERAGES = 4,
		/// <summary>enum member</summary>
		BIN_CENTERS = 3,
		/// <summary>enum member</summary>
		BIN_POINTS = 2,
		/// <summary>enum member</summary>
		INPUT_POINTS = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBinnedDecimation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBinnedDecimation()
	{
		MRClassNameKey = "class vtkBinnedDecimation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBinnedDecimation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBinnedDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinnedDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static vtkBinnedDecimation New()
	{
		vtkBinnedDecimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBinnedDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBinnedDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public vtkBinnedDecimation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBinnedDecimation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBinnedDecimation_AutoAdjustNumberOfDivisionsOff_01(HandleRef pThis);

	/// <summary>
	/// Enable automatic adjustment of number of divisions. If disabled, the
	/// number of divisions specified by the user is always used (as long as it
	/// is valid). The default is On.
	/// </summary>
	public virtual void AutoAdjustNumberOfDivisionsOff()
	{
		vtkBinnedDecimation_AutoAdjustNumberOfDivisionsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_AutoAdjustNumberOfDivisionsOn_02(HandleRef pThis);

	/// <summary>
	/// Enable automatic adjustment of number of divisions. If disabled, the
	/// number of divisions specified by the user is always used (as long as it
	/// is valid). The default is On.
	/// </summary>
	public virtual void AutoAdjustNumberOfDivisionsOn()
	{
		vtkBinnedDecimation_AutoAdjustNumberOfDivisionsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBinnedDecimation_GetAutoAdjustNumberOfDivisions_03(HandleRef pThis);

	/// <summary>
	/// Enable automatic adjustment of number of divisions. If disabled, the
	/// number of divisions specified by the user is always used (as long as it
	/// is valid). The default is On.
	/// </summary>
	public virtual bool GetAutoAdjustNumberOfDivisions()
	{
		return (vtkBinnedDecimation_GetAutoAdjustNumberOfDivisions_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinnedDecimation_GetDivisionOrigin_04(HandleRef pThis);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public virtual double[] GetDivisionOrigin()
	{
		IntPtr intPtr = vtkBinnedDecimation_GetDivisionOrigin_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_GetDivisionOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public virtual void GetDivisionOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkBinnedDecimation_GetDivisionOrigin_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_GetDivisionOrigin_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public virtual void GetDivisionOrigin(IntPtr _arg)
	{
		vtkBinnedDecimation_GetDivisionOrigin_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinnedDecimation_GetDivisionSpacing_07(HandleRef pThis);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public virtual double[] GetDivisionSpacing()
	{
		IntPtr intPtr = vtkBinnedDecimation_GetDivisionSpacing_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_GetDivisionSpacing_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public virtual void GetDivisionSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkBinnedDecimation_GetDivisionSpacing_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_GetDivisionSpacing_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public virtual void GetDivisionSpacing(IntPtr _arg)
	{
		vtkBinnedDecimation_GetDivisionSpacing_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBinnedDecimation_GetLargeIds_10(HandleRef pThis);

	/// <summary>
	/// Return a flag indicating whether large ids were used during
	/// execution. The value of this flag is only valid after filter
	/// execution. The filter may use a smaller id type unless it must use
	/// vtkIdType to represent points and cell ids.
	/// </summary>
	public bool GetLargeIds()
	{
		return (vtkBinnedDecimation_GetLargeIds_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinnedDecimation_GetNumberOfDivisions_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public IntPtr GetNumberOfDivisions()
	{
		return vtkBinnedDecimation_GetNumberOfDivisions_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_GetNumberOfDivisions_12(HandleRef pThis, IntPtr div);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public void GetNumberOfDivisions(IntPtr div)
	{
		vtkBinnedDecimation_GetNumberOfDivisions_12(GetCppThis(), div);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBinnedDecimation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBinnedDecimation_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBinnedDecimation_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBinnedDecimation_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinnedDecimation_GetNumberOfXDivisions_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public virtual int GetNumberOfXDivisions()
	{
		return vtkBinnedDecimation_GetNumberOfXDivisions_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinnedDecimation_GetNumberOfYDivisions_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public virtual int GetNumberOfYDivisions()
	{
		return vtkBinnedDecimation_GetNumberOfYDivisions_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinnedDecimation_GetNumberOfZDivisions_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public virtual int GetNumberOfZDivisions()
	{
		return vtkBinnedDecimation_GetNumberOfZDivisions_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinnedDecimation_GetPointGenerationMode_18(HandleRef pThis);

	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public virtual int GetPointGenerationMode()
	{
		return vtkBinnedDecimation_GetPointGenerationMode_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinnedDecimation_GetPointGenerationModeMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public virtual int GetPointGenerationModeMaxValue()
	{
		return vtkBinnedDecimation_GetPointGenerationModeMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinnedDecimation_GetPointGenerationModeMinValue_20(HandleRef pThis);

	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public virtual int GetPointGenerationModeMinValue()
	{
		return vtkBinnedDecimation_GetPointGenerationModeMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBinnedDecimation_GetProduceCellData_21(HandleRef pThis);

	/// <summary>
	/// This flag directs the filter to copy cell data from input to output.
	/// This flag is off by default.
	/// </summary>
	public virtual bool GetProduceCellData()
	{
		return (vtkBinnedDecimation_GetProduceCellData_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBinnedDecimation_GetProducePointData_22(HandleRef pThis);

	/// <summary>
	/// This flag directs the filter to produce output point data from the input
	/// point data (on by default). If the ProducePointData is set to
	/// INPUT_POINTS, point data is simply passed from input to output (since
	/// the points don't change). If the point generation mode is set to
	/// BIN_AVERAGES, then the average of all point data values within a bin
	/// are associated with the point generated in the bin. If the point
	/// generation mode is either BIN_POINTS or BIN_CENTERS, then the point
	/// data values from one of the points falling into the bin is used.
	/// </summary>
	public virtual bool GetProducePointData()
	{
		return (vtkBinnedDecimation_GetProducePointData_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinnedDecimation_IsA_23(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBinnedDecimation_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBinnedDecimation_IsTypeOf_24(string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBinnedDecimation_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinnedDecimation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new vtkBinnedDecimation NewInstance()
	{
		vtkBinnedDecimation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBinnedDecimation_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBinnedDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_ProduceCellDataOff_27(HandleRef pThis);

	/// <summary>
	/// This flag directs the filter to copy cell data from input to output.
	/// This flag is off by default.
	/// </summary>
	public virtual void ProduceCellDataOff()
	{
		vtkBinnedDecimation_ProduceCellDataOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_ProduceCellDataOn_28(HandleRef pThis);

	/// <summary>
	/// This flag directs the filter to copy cell data from input to output.
	/// This flag is off by default.
	/// </summary>
	public virtual void ProduceCellDataOn()
	{
		vtkBinnedDecimation_ProduceCellDataOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_ProducePointDataOff_29(HandleRef pThis);

	/// <summary>
	/// This flag directs the filter to produce output point data from the input
	/// point data (on by default). If the ProducePointData is set to
	/// INPUT_POINTS, point data is simply passed from input to output (since
	/// the points don't change). If the point generation mode is set to
	/// BIN_AVERAGES, then the average of all point data values within a bin
	/// are associated with the point generated in the bin. If the point
	/// generation mode is either BIN_POINTS or BIN_CENTERS, then the point
	/// data values from one of the points falling into the bin is used.
	/// </summary>
	public virtual void ProducePointDataOff()
	{
		vtkBinnedDecimation_ProducePointDataOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_ProducePointDataOn_30(HandleRef pThis);

	/// <summary>
	/// This flag directs the filter to produce output point data from the input
	/// point data (on by default). If the ProducePointData is set to
	/// INPUT_POINTS, point data is simply passed from input to output (since
	/// the points don't change). If the point generation mode is set to
	/// BIN_AVERAGES, then the average of all point data values within a bin
	/// are associated with the point generated in the bin. If the point
	/// generation mode is either BIN_POINTS or BIN_CENTERS, then the point
	/// data values from one of the points falling into the bin is used.
	/// </summary>
	public virtual void ProducePointDataOn()
	{
		vtkBinnedDecimation_ProducePointDataOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBinnedDecimation_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static vtkBinnedDecimation SafeDownCast(vtkObjectBase o)
	{
		vtkBinnedDecimation vtkBinnedDecimation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBinnedDecimation_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBinnedDecimation2 = (vtkBinnedDecimation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBinnedDecimation2.Register(null);
			}
		}
		return vtkBinnedDecimation2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetAutoAdjustNumberOfDivisions_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable automatic adjustment of number of divisions. If disabled, the
	/// number of divisions specified by the user is always used (as long as it
	/// is valid). The default is On.
	/// </summary>
	public virtual void SetAutoAdjustNumberOfDivisions(bool _arg)
	{
		vtkBinnedDecimation_SetAutoAdjustNumberOfDivisions_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetDivisionOrigin_33(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public void SetDivisionOrigin(double x, double y, double z)
	{
		vtkBinnedDecimation_SetDivisionOrigin_33(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetDivisionOrigin_34(HandleRef pThis, IntPtr o);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public void SetDivisionOrigin(IntPtr o)
	{
		vtkBinnedDecimation_SetDivisionOrigin_34(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetDivisionSpacing_35(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public void SetDivisionSpacing(double x, double y, double z)
	{
		vtkBinnedDecimation_SetDivisionSpacing_35(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetDivisionSpacing_36(HandleRef pThis, IntPtr s);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to
	/// match boundaries between pieces, then you should use these methods
	/// rather than SetNumberOfDivisions(). To use these methods, specify the
	/// origin and spacing of the spatial binning.
	/// </summary>
	public void SetDivisionSpacing(IntPtr s)
	{
		vtkBinnedDecimation_SetDivisionSpacing_36(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetNumberOfDivisions_37(HandleRef pThis, IntPtr div);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public void SetNumberOfDivisions(IntPtr div)
	{
		vtkBinnedDecimation_SetNumberOfDivisions_37(GetCppThis(), div);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetNumberOfDivisions_38(HandleRef pThis, int div0, int div1, int div2);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public void SetNumberOfDivisions(int div0, int div1, int div2)
	{
		vtkBinnedDecimation_SetNumberOfDivisions_38(GetCppThis(), div0, div1, div2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetNumberOfXDivisions_39(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public void SetNumberOfXDivisions(int num)
	{
		vtkBinnedDecimation_SetNumberOfXDivisions_39(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetNumberOfYDivisions_40(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public void SetNumberOfYDivisions(int num)
	{
		vtkBinnedDecimation_SetNumberOfYDivisions_40(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetNumberOfZDivisions_41(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions. The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions is
	/// enabled. Also, the maximum number of divisions is controlled so that no
	/// more than 2^31 bins are created. (If bin adjustment due to the limit on
	/// the number of bins is necessary, then a proportional scaling of the
	/// divisions in the x-y-z directions is used.) This API has been adopted
	/// to be consistent with vtkQuadricClustering.
	/// </summary>
	public void SetNumberOfZDivisions(int num)
	{
		vtkBinnedDecimation_SetNumberOfZDivisions_41(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetPointGenerationMode_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public virtual void SetPointGenerationMode(int _arg)
	{
		vtkBinnedDecimation_SetPointGenerationMode_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetPointGenerationModeToBinAverages_43(HandleRef pThis);

	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public void SetPointGenerationModeToBinAverages()
	{
		vtkBinnedDecimation_SetPointGenerationModeToBinAverages_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetPointGenerationModeToBinCenters_44(HandleRef pThis);

	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public void SetPointGenerationModeToBinCenters()
	{
		vtkBinnedDecimation_SetPointGenerationModeToBinCenters_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetPointGenerationModeToBinPoints_45(HandleRef pThis);

	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public void SetPointGenerationModeToBinPoints()
	{
		vtkBinnedDecimation_SetPointGenerationModeToBinPoints_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetPointGenerationModeToUseInputPoints_46(HandleRef pThis);

	/// <summary>
	/// Four options exist for generating output points. 1) Pass the input
	/// points through to the output; 2) select one of the input points in the bin and
	/// use that; 3) generate new points at the center of bins (only center bin
	/// points used by the output triangles are generated); and 4) generate new
	/// points from the average of all points falling into a bin and used by
	/// output triangles. Note that 1) can result in many, unused output points,
	/// but tends to be fastest for small numbers of bins. This can impact
	/// rendering memory usage as all points are typically pushed into the
	/// graphics hardware. Options 2-4 produce only points used by the output
	/// triangles but generally take longer (for small numbers of bins), with
	/// speeds slowing in order from options 2 through 4. In terms of quality,
	/// option 4 (BIN_AVERAGES) produces the best output; options 1) and 2)
	/// produce decent output, with option 3) (BIN_CENTERS) producing a
	/// voxelized-like result (which is quite useful for illustrative purposes).
	/// Note that for very large numbers of bins (say number of divisions &gt; 500^3),
	/// then algorithm 4) BIN_AVERAGES scales better, i.e., is likely faster and
	/// produces better results.
	/// </summary>
	public void SetPointGenerationModeToUseInputPoints()
	{
		vtkBinnedDecimation_SetPointGenerationModeToUseInputPoints_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetProduceCellData_47(HandleRef pThis, byte _arg);

	/// <summary>
	/// This flag directs the filter to copy cell data from input to output.
	/// This flag is off by default.
	/// </summary>
	public virtual void SetProduceCellData(bool _arg)
	{
		vtkBinnedDecimation_SetProduceCellData_47(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBinnedDecimation_SetProducePointData_48(HandleRef pThis, byte _arg);

	/// <summary>
	/// This flag directs the filter to produce output point data from the input
	/// point data (on by default). If the ProducePointData is set to
	/// INPUT_POINTS, point data is simply passed from input to output (since
	/// the points don't change). If the point generation mode is set to
	/// BIN_AVERAGES, then the average of all point data values within a bin
	/// are associated with the point generated in the bin. If the point
	/// generation mode is either BIN_POINTS or BIN_CENTERS, then the point
	/// data values from one of the points falling into the bin is used.
	/// </summary>
	public virtual void SetProducePointData(bool _arg)
	{
		vtkBinnedDecimation_SetProducePointData_48(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
