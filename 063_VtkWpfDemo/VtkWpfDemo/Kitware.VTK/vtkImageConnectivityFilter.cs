using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageConnectivityFilter
/// </summary>
/// <remarks>
///    Label an image by connectivity
///
/// vtkImageConnectivityFilter will identify connected regions within an
/// image and label them.  Only points with scalar values within a
/// prescribed range are considered for inclusion, by default this range
/// includes all scalar values with a value greater than zero.  Points
/// within the prescribed scalar range are considered to be connected
/// if a path exists between the points that does not traverse any
/// points that are not within the prescribed scalar range.
/// Adjacency of points is governed by 4-connectivity for 2D images, and
/// 6-connectivity for 3D images.
///
/// The output of this filter is a label image.  By default, each region
/// is assigned a different label, where the labels are integer values
/// starting at a value of 1.  The SetLabelMode() method can be used to
/// change the way that labels are assigned.  Labels can be assigned
/// by providing input seed points for each region to be labelled, or
/// they can be assigned by ranking the regions by size.
///
/// If a set of seeds is provided with the SetSeedData() method,
/// then the default behavior is to only output the regions that are
/// connected to the seeds, and if the seeds have scalars, then these
/// scalars will be used to label the regions.  Seeds with a scalar
/// value equal to zero are ignored.  See the documentation for the
/// SetExtractionMode() method for details on how to control which
/// regions will labeled.
///
/// Regions can be selected by size with the SetSizeRange() method,
/// which can be useful for identifying objects of a certain size,
/// e.g. for rejecting small regions that are likely to be noise.
/// It is also possible to label only the largest region and ignore
/// all others, with SetExtractionModeToLargestRegion().
///
/// In addition to the labels, the following additional information
/// is provided: the number of regions identified, the size of each
/// region, a list of all label values used, and the seed for each
/// region (if seeds were used).  Optionally, this filter can also
/// compute the extent of each region if GenerateRegionExtentsOn()
/// is called.  These extents can be useful for cropping the output
/// of the filter.
///
/// </remarks>
/// <seealso>
///
/// vtkConnectivityFilter, vtkPolyDataConnectivityFilter, vtkmImageConnectivity
/// </seealso>
public class vtkImageConnectivityFilter : vtkImageAlgorithm
{
	/// <summary>
	/// Enum constants for SetExtractionMode().
	/// </summary>
	public enum ExtractionModeEnum
	{
		/// <summary>enum member</summary>
		AllRegions = 1,
		/// <summary>enum member</summary>
		LargestRegion = 2,
		/// <summary>enum member</summary>
		SeededRegions = 0
	}

	/// <summary>
	/// Enum constants for SetLabelMode().
	/// </summary>
	public enum LabelModeEnum
	{
		/// <summary>enum member</summary>
		ConstantValue = 1,
		/// <summary>enum member</summary>
		SeedScalar = 0,
		/// <summary>enum member</summary>
		SizeRank = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageConnectivityFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageConnectivityFilter()
	{
		MRClassNameKey = "class vtkImageConnectivityFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConnectivityFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageConnectivityFilter New()
	{
		vtkImageConnectivityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageConnectivityFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageConnectivityFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_GenerateRegionExtentsOff_01(HandleRef pThis);

	/// <summary>
	/// Turn this on to request creation of the ExtractedRegionExtents array.
	/// </summary>
	public virtual void GenerateRegionExtentsOff()
	{
		vtkImageConnectivityFilter_GenerateRegionExtentsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_GenerateRegionExtentsOn_02(HandleRef pThis);

	/// <summary>
	/// Turn this on to request creation of the ExtractedRegionExtents array.
	/// </summary>
	public virtual void GenerateRegionExtentsOn()
	{
		vtkImageConnectivityFilter_GenerateRegionExtentsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConnectivityFilter_GetActiveComponent_03(HandleRef pThis);

	/// <summary>
	/// For multi-component input images, select which component to use.
	/// </summary>
	public virtual int GetActiveComponent()
	{
		return vtkImageConnectivityFilter_GetActiveComponent_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetExtractedRegionExtents_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the extent (a 6-tuples) for each output region.
	/// This is only valid if GenerateRegionExtentsOn() was called before
	/// the filter was executed.
	/// </summary>
	public vtkIntArray GetExtractedRegionExtents()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_GetExtractedRegionExtents_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetExtractedRegionLabels_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the label used for each extracted region.
	/// </summary>
	public vtkIdTypeArray GetExtractedRegionLabels()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_GetExtractedRegionLabels_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetExtractedRegionSeedIds_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the PointId of the seed for each region.
	/// If no seed was used, the PointId will be -1.
	/// </summary>
	public vtkIdTypeArray GetExtractedRegionSeedIds()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_GetExtractedRegionSeedIds_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetExtractedRegionSizes_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the label used for each extracted region.
	/// </summary>
	public vtkIdTypeArray GetExtractedRegionSizes()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_GetExtractedRegionSizes_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConnectivityFilter_GetExtractionMode_08(HandleRef pThis);

	/// <summary>
	/// Set which regions to output from this filter.
	/// This can be all the regions, just the seeded regions, or the largest
	/// region (which will be the largest seeded region, if there are seeds).
	/// The default is to output all the seeded regions, if there are seeds,
	/// or to output all the regions, if there are no seeds.
	/// </summary>
	public virtual int GetExtractionMode()
	{
		return vtkImageConnectivityFilter_GetExtractionMode_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetExtractionModeAsString_09(HandleRef pThis);

	/// <summary>
	/// Set which regions to output from this filter.
	/// This can be all the regions, just the seeded regions, or the largest
	/// region (which will be the largest seeded region, if there are seeds).
	/// The default is to output all the seeded regions, if there are seeds,
	/// or to output all the regions, if there are no seeds.
	/// </summary>
	public string GetExtractionModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageConnectivityFilter_GetExtractionModeAsString_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConnectivityFilter_GetGenerateRegionExtents_10(HandleRef pThis);

	/// <summary>
	/// Turn this on to request creation of the ExtractedRegionExtents array.
	/// </summary>
	public virtual int GetGenerateRegionExtents()
	{
		return vtkImageConnectivityFilter_GetGenerateRegionExtents_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConnectivityFilter_GetLabelConstantValue_11(HandleRef pThis);

	/// <summary>
	/// The label used when LabelMode is ConstantValue.
	/// The default value is 255.
	/// </summary>
	public virtual int GetLabelConstantValue()
	{
		return vtkImageConnectivityFilter_GetLabelConstantValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConnectivityFilter_GetLabelMode_12(HandleRef pThis);

	/// <summary>
	/// Set the mode for applying labels to the output.
	/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
	/// present, or the regions will be labeled consecutively starting at 1,
	/// if the seeds have no scalars. Labeling by SizeRank means that the
	/// largest region is labeled 1 and other regions are labeled consecutively
	/// in order of decreasing size (if there is a tie, then the seed point ID
	/// is used as a tiebreaker).  Finally, Constant means that all regions
	/// will have the value of SetLabelConstantValue().  The default is to
	/// label using the seed scalars, if present, or to label consecutively,
	/// if no seed scalars are present.
	/// </summary>
	public virtual int GetLabelMode()
	{
		return vtkImageConnectivityFilter_GetLabelMode_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetLabelModeAsString_13(HandleRef pThis);

	/// <summary>
	/// Set the mode for applying labels to the output.
	/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
	/// present, or the regions will be labeled consecutively starting at 1,
	/// if the seeds have no scalars. Labeling by SizeRank means that the
	/// largest region is labeled 1 and other regions are labeled consecutively
	/// in order of decreasing size (if there is a tie, then the seed point ID
	/// is used as a tiebreaker).  Finally, Constant means that all regions
	/// will have the value of SetLabelConstantValue().  The default is to
	/// label using the seed scalars, if present, or to label consecutively,
	/// if no seed scalars are present.
	/// </summary>
	public string GetLabelModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageConnectivityFilter_GetLabelModeAsString_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConnectivityFilter_GetLabelScalarType_14(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for the output label image.
	/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
	/// depending on how many labels are expected.  The default is UnsignedChar,
	/// which allows for 255 label values.  If the total number of regions is
	/// greater than the maximum label value N, then only the largest N regions
	/// will be kept and the rest will be discarded.
	/// </summary>
	public virtual int GetLabelScalarType()
	{
		return vtkImageConnectivityFilter_GetLabelScalarType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetLabelScalarTypeAsString_15(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for the output label image.
	/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
	/// depending on how many labels are expected.  The default is UnsignedChar,
	/// which allows for 255 label values.  If the total number of regions is
	/// greater than the maximum label value N, then only the largest N regions
	/// will be kept and the rest will be discarded.
	/// </summary>
	public string GetLabelScalarTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageConnectivityFilter_GetLabelScalarTypeAsString_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageConnectivityFilter_GetNumberOfExtractedRegions_16(HandleRef pThis);

	/// <summary>
	/// Get the number of extracted regions.
	/// </summary>
	public long GetNumberOfExtractedRegions()
	{
		return vtkImageConnectivityFilter_GetNumberOfExtractedRegions_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageConnectivityFilter_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageConnectivityFilter_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageConnectivityFilter_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageConnectivityFilter_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetScalarRange_19(HandleRef pThis);

	/// <summary>
	/// Set the scalar range used to define potential regions.
	/// Only voxels with values that are within this range will be considered
	/// for region membership.  This is an inclusive range, meaning that the
	/// upper and lower limits are considered to be within the range.  The
	/// default range goes from 0.5 to VTK_DOUBLE_MAX.
	/// </summary>
	public virtual double[] GetScalarRange()
	{
		IntPtr intPtr = vtkImageConnectivityFilter_GetScalarRange_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_GetScalarRange_20(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set the scalar range used to define potential regions.
	/// Only voxels with values that are within this range will be considered
	/// for region membership.  This is an inclusive range, meaning that the
	/// upper and lower limits are considered to be within the range.  The
	/// default range goes from 0.5 to VTK_DOUBLE_MAX.
	/// </summary>
	public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
	{
		vtkImageConnectivityFilter_GetScalarRange_20(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_GetScalarRange_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range used to define potential regions.
	/// Only voxels with values that are within this range will be considered
	/// for region membership.  This is an inclusive range, meaning that the
	/// upper and lower limits are considered to be within the range.  The
	/// default range goes from 0.5 to VTK_DOUBLE_MAX.
	/// </summary>
	public virtual void GetScalarRange(IntPtr _arg)
	{
		vtkImageConnectivityFilter_GetScalarRange_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetSeedConnection_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The input for seed locations (input port 1).
	/// Each point in the supplied data set will be used as a seed, unless
	/// the data set has scalars, in which case only the points with scalar
	/// values that are not equal to zero will be used as seeds.
	/// </summary>
	public vtkAlgorithmOutput GetSeedConnection()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_GetSeedConnection_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetSizeRange_23(HandleRef pThis);

	/// <summary>
	/// Set the size range for the extracted regions.
	/// Only regions that have sizes within the specified range will be present
	/// in the output.  The default range is (1, VTK_ID_MAX).
	/// </summary>
	public virtual long[] GetSizeRange()
	{
		IntPtr intPtr = vtkImageConnectivityFilter_GetSizeRange_23(GetCppThis());
		long[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new long[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_GetSizeRange_24(HandleRef pThis, ref long _arg1, ref long _arg2);

	/// <summary>
	/// Set the size range for the extracted regions.
	/// Only regions that have sizes within the specified range will be present
	/// in the output.  The default range is (1, VTK_ID_MAX).
	/// </summary>
	public virtual void GetSizeRange(ref long _arg1, ref long _arg2)
	{
		vtkImageConnectivityFilter_GetSizeRange_24(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_GetSizeRange_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the size range for the extracted regions.
	/// Only regions that have sizes within the specified range will be present
	/// in the output.  The default range is (1, VTK_ID_MAX).
	/// </summary>
	public virtual void GetSizeRange(IntPtr _arg)
	{
		vtkImageConnectivityFilter_GetSizeRange_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_GetStencilConnection_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The input for a stencil (input port 2).
	/// The output labels will be restricted to the region inside the stencil,
	/// as if no input voxels existed outside the stencil.  This allows you to
	/// apply this filter within an arbitrary region of interest.
	/// </summary>
	public vtkAlgorithmOutput GetStencilConnection()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_GetStencilConnection_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConnectivityFilter_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageConnectivityFilter_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageConnectivityFilter_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageConnectivityFilter_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageConnectivityFilter NewInstance()
	{
		vtkImageConnectivityFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageConnectivityFilter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageConnectivityFilter SafeDownCast(vtkObjectBase o)
	{
		vtkImageConnectivityFilter vtkImageConnectivityFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageConnectivityFilter_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageConnectivityFilter2 = (vtkImageConnectivityFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageConnectivityFilter2.Register(null);
			}
		}
		return vtkImageConnectivityFilter2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetActiveComponent_32(HandleRef pThis, int _arg);

	/// <summary>
	/// For multi-component input images, select which component to use.
	/// </summary>
	public virtual void SetActiveComponent(int _arg)
	{
		vtkImageConnectivityFilter_SetActiveComponent_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetExtractionMode_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set which regions to output from this filter.
	/// This can be all the regions, just the seeded regions, or the largest
	/// region (which will be the largest seeded region, if there are seeds).
	/// The default is to output all the seeded regions, if there are seeds,
	/// or to output all the regions, if there are no seeds.
	/// </summary>
	public virtual void SetExtractionMode(int _arg)
	{
		vtkImageConnectivityFilter_SetExtractionMode_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetExtractionModeToAllRegions_34(HandleRef pThis);

	/// <summary>
	/// Set which regions to output from this filter.
	/// This can be all the regions, just the seeded regions, or the largest
	/// region (which will be the largest seeded region, if there are seeds).
	/// The default is to output all the seeded regions, if there are seeds,
	/// or to output all the regions, if there are no seeds.
	/// </summary>
	public void SetExtractionModeToAllRegions()
	{
		vtkImageConnectivityFilter_SetExtractionModeToAllRegions_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetExtractionModeToLargestRegion_35(HandleRef pThis);

	/// <summary>
	/// Set which regions to output from this filter.
	/// This can be all the regions, just the seeded regions, or the largest
	/// region (which will be the largest seeded region, if there are seeds).
	/// The default is to output all the seeded regions, if there are seeds,
	/// or to output all the regions, if there are no seeds.
	/// </summary>
	public void SetExtractionModeToLargestRegion()
	{
		vtkImageConnectivityFilter_SetExtractionModeToLargestRegion_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetExtractionModeToSeededRegions_36(HandleRef pThis);

	/// <summary>
	/// Set which regions to output from this filter.
	/// This can be all the regions, just the seeded regions, or the largest
	/// region (which will be the largest seeded region, if there are seeds).
	/// The default is to output all the seeded regions, if there are seeds,
	/// or to output all the regions, if there are no seeds.
	/// </summary>
	public void SetExtractionModeToSeededRegions()
	{
		vtkImageConnectivityFilter_SetExtractionModeToSeededRegions_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetGenerateRegionExtents_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn this on to request creation of the ExtractedRegionExtents array.
	/// </summary>
	public virtual void SetGenerateRegionExtents(int _arg)
	{
		vtkImageConnectivityFilter_SetGenerateRegionExtents_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelConstantValue_38(HandleRef pThis, int _arg);

	/// <summary>
	/// The label used when LabelMode is ConstantValue.
	/// The default value is 255.
	/// </summary>
	public virtual void SetLabelConstantValue(int _arg)
	{
		vtkImageConnectivityFilter_SetLabelConstantValue_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelMode_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the mode for applying labels to the output.
	/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
	/// present, or the regions will be labeled consecutively starting at 1,
	/// if the seeds have no scalars. Labeling by SizeRank means that the
	/// largest region is labeled 1 and other regions are labeled consecutively
	/// in order of decreasing size (if there is a tie, then the seed point ID
	/// is used as a tiebreaker).  Finally, Constant means that all regions
	/// will have the value of SetLabelConstantValue().  The default is to
	/// label using the seed scalars, if present, or to label consecutively,
	/// if no seed scalars are present.
	/// </summary>
	public virtual void SetLabelMode(int _arg)
	{
		vtkImageConnectivityFilter_SetLabelMode_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelModeToConstantValue_40(HandleRef pThis);

	/// <summary>
	/// Set the mode for applying labels to the output.
	/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
	/// present, or the regions will be labeled consecutively starting at 1,
	/// if the seeds have no scalars. Labeling by SizeRank means that the
	/// largest region is labeled 1 and other regions are labeled consecutively
	/// in order of decreasing size (if there is a tie, then the seed point ID
	/// is used as a tiebreaker).  Finally, Constant means that all regions
	/// will have the value of SetLabelConstantValue().  The default is to
	/// label using the seed scalars, if present, or to label consecutively,
	/// if no seed scalars are present.
	/// </summary>
	public void SetLabelModeToConstantValue()
	{
		vtkImageConnectivityFilter_SetLabelModeToConstantValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelModeToSeedScalar_41(HandleRef pThis);

	/// <summary>
	/// Set the mode for applying labels to the output.
	/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
	/// present, or the regions will be labeled consecutively starting at 1,
	/// if the seeds have no scalars. Labeling by SizeRank means that the
	/// largest region is labeled 1 and other regions are labeled consecutively
	/// in order of decreasing size (if there is a tie, then the seed point ID
	/// is used as a tiebreaker).  Finally, Constant means that all regions
	/// will have the value of SetLabelConstantValue().  The default is to
	/// label using the seed scalars, if present, or to label consecutively,
	/// if no seed scalars are present.
	/// </summary>
	public void SetLabelModeToSeedScalar()
	{
		vtkImageConnectivityFilter_SetLabelModeToSeedScalar_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelModeToSizeRank_42(HandleRef pThis);

	/// <summary>
	/// Set the mode for applying labels to the output.
	/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
	/// present, or the regions will be labeled consecutively starting at 1,
	/// if the seeds have no scalars. Labeling by SizeRank means that the
	/// largest region is labeled 1 and other regions are labeled consecutively
	/// in order of decreasing size (if there is a tie, then the seed point ID
	/// is used as a tiebreaker).  Finally, Constant means that all regions
	/// will have the value of SetLabelConstantValue().  The default is to
	/// label using the seed scalars, if present, or to label consecutively,
	/// if no seed scalars are present.
	/// </summary>
	public void SetLabelModeToSizeRank()
	{
		vtkImageConnectivityFilter_SetLabelModeToSizeRank_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelScalarType_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the scalar type for the output label image.
	/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
	/// depending on how many labels are expected.  The default is UnsignedChar,
	/// which allows for 255 label values.  If the total number of regions is
	/// greater than the maximum label value N, then only the largest N regions
	/// will be kept and the rest will be discarded.
	/// </summary>
	public virtual void SetLabelScalarType(int _arg)
	{
		vtkImageConnectivityFilter_SetLabelScalarType_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelScalarTypeToInt_44(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for the output label image.
	/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
	/// depending on how many labels are expected.  The default is UnsignedChar,
	/// which allows for 255 label values.  If the total number of regions is
	/// greater than the maximum label value N, then only the largest N regions
	/// will be kept and the rest will be discarded.
	/// </summary>
	public void SetLabelScalarTypeToInt()
	{
		vtkImageConnectivityFilter_SetLabelScalarTypeToInt_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelScalarTypeToShort_45(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for the output label image.
	/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
	/// depending on how many labels are expected.  The default is UnsignedChar,
	/// which allows for 255 label values.  If the total number of regions is
	/// greater than the maximum label value N, then only the largest N regions
	/// will be kept and the rest will be discarded.
	/// </summary>
	public void SetLabelScalarTypeToShort()
	{
		vtkImageConnectivityFilter_SetLabelScalarTypeToShort_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelScalarTypeToUnsignedChar_46(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for the output label image.
	/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
	/// depending on how many labels are expected.  The default is UnsignedChar,
	/// which allows for 255 label values.  If the total number of regions is
	/// greater than the maximum label value N, then only the largest N regions
	/// will be kept and the rest will be discarded.
	/// </summary>
	public void SetLabelScalarTypeToUnsignedChar()
	{
		vtkImageConnectivityFilter_SetLabelScalarTypeToUnsignedChar_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetLabelScalarTypeToUnsignedShort_47(HandleRef pThis);

	/// <summary>
	/// Set the scalar type for the output label image.
	/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
	/// depending on how many labels are expected.  The default is UnsignedChar,
	/// which allows for 255 label values.  If the total number of regions is
	/// greater than the maximum label value N, then only the largest N regions
	/// will be kept and the rest will be discarded.
	/// </summary>
	public void SetLabelScalarTypeToUnsignedShort()
	{
		vtkImageConnectivityFilter_SetLabelScalarTypeToUnsignedShort_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetScalarRange_48(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Set the scalar range used to define potential regions.
	/// Only voxels with values that are within this range will be considered
	/// for region membership.  This is an inclusive range, meaning that the
	/// upper and lower limits are considered to be within the range.  The
	/// default range goes from 0.5 to VTK_DOUBLE_MAX.
	/// </summary>
	public virtual void SetScalarRange(double _arg1, double _arg2)
	{
		vtkImageConnectivityFilter_SetScalarRange_48(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetScalarRange_49(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scalar range used to define potential regions.
	/// Only voxels with values that are within this range will be considered
	/// for region membership.  This is an inclusive range, meaning that the
	/// upper and lower limits are considered to be within the range.  The
	/// default range goes from 0.5 to VTK_DOUBLE_MAX.
	/// </summary>
	public void SetScalarRange(IntPtr _arg)
	{
		vtkImageConnectivityFilter_SetScalarRange_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetSeedConnection_50(HandleRef pThis, HandleRef port);

	/// <summary>
	/// The input for seed locations (input port 1).
	/// Each point in the supplied data set will be used as a seed, unless
	/// the data set has scalars, in which case only the points with scalar
	/// values that are not equal to zero will be used as seeds.
	/// </summary>
	public void SetSeedConnection(vtkAlgorithmOutput port)
	{
		vtkImageConnectivityFilter_SetSeedConnection_50(GetCppThis(), port?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetSeedData_51(HandleRef pThis, HandleRef data);

	/// <summary>
	/// The input for seed locations (input port 1).
	/// Each point in the supplied data set will be used as a seed, unless
	/// the data set has scalars, in which case only the points with scalar
	/// values that are not equal to zero will be used as seeds.
	/// </summary>
	public void SetSeedData(vtkDataSet data)
	{
		vtkImageConnectivityFilter_SetSeedData_51(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetSizeRange_52(HandleRef pThis, long _arg1, long _arg2);

	/// <summary>
	/// Set the size range for the extracted regions.
	/// Only regions that have sizes within the specified range will be present
	/// in the output.  The default range is (1, VTK_ID_MAX).
	/// </summary>
	public virtual void SetSizeRange(long _arg1, long _arg2)
	{
		vtkImageConnectivityFilter_SetSizeRange_52(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetSizeRange_53(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the size range for the extracted regions.
	/// Only regions that have sizes within the specified range will be present
	/// in the output.  The default range is (1, VTK_ID_MAX).
	/// </summary>
	public void SetSizeRange(IntPtr _arg)
	{
		vtkImageConnectivityFilter_SetSizeRange_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetStencilConnection_54(HandleRef pThis, HandleRef port);

	/// <summary>
	/// The input for a stencil (input port 2).
	/// The output labels will be restricted to the region inside the stencil,
	/// as if no input voxels existed outside the stencil.  This allows you to
	/// apply this filter within an arbitrary region of interest.
	/// </summary>
	public void SetStencilConnection(vtkAlgorithmOutput port)
	{
		vtkImageConnectivityFilter_SetStencilConnection_54(GetCppThis(), port?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageConnectivityFilter_SetStencilData_55(HandleRef pThis, HandleRef data);

	/// <summary>
	/// The input for a stencil (input port 2).
	/// The output labels will be restricted to the region inside the stencil,
	/// as if no input voxels existed outside the stencil.  This allows you to
	/// apply this filter within an arbitrary region of interest.
	/// </summary>
	public void SetStencilData(vtkImageStencilData data)
	{
		vtkImageConnectivityFilter_SetStencilData_55(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}
}
