using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitModeller
/// </summary>
/// <remarks>
///    compute distance from input geometry on structured point dataset
///
/// vtkImplicitModeller is a filter that computes the distance from the input
/// geometry to the points of an output structured point set. This distance
/// function can then be "contoured" to generate new, offset surfaces from
/// the original geometry. An important feature of this object is
/// "capping". If capping is turned on, after the implicit model is created,
/// the values on the boundary of the structured points dataset are set to
/// the cap value. This is used to force closure of the resulting contoured
/// surface. Note, however, that large cap values can generate weird surface
/// normals in those cells adjacent to the boundary of the dataset. Using
/// smaller cap value will reduce this effect.
/// &lt;P&gt;
/// Another important ivar is MaximumDistance. This controls how far into the
/// volume the distance function is computed from the input geometry.  Small
/// values give significant increases in performance. However, there can
/// strange sampling effects at the extreme range of the MaximumDistance.
/// &lt;P&gt;
/// In order to properly execute and sample the input data, a rectangular
/// region in space must be defined (this is the ivar ModelBounds).  If not
/// explicitly defined, the model bounds will be computed. Note that to avoid
/// boundary effects, it is possible to adjust the model bounds (i.e., using
/// the AdjustBounds and AdjustDistance ivars) to strictly contain the
/// sampled data.
/// &lt;P&gt;
/// This filter has one other unusual capability: it is possible to append
/// data in a sequence of operations to generate a single output. This is
/// useful when you have multiple datasets and want to create a
/// conglomeration of all the data.  However, the user must be careful to
/// either specify the ModelBounds or specify the first item such that its
/// bounds completely contain all other items.  This is because the
/// rectangular region of the output can not be changed after the 1st Append.
/// &lt;P&gt;
/// The ProcessMode ivar controls the method used within the Append function
/// (where the actual work is done regardless if the Append function is
/// explicitly called) to compute the implicit model.  If set to work in voxel
/// mode, each voxel is visited once.  If set to cell mode, each cell is visited
/// once.  Tests have shown once per voxel to be faster when there are a
/// lot of cells (at least a thousand?); relative performance improvement
/// increases with addition cells. Primitives should not be stripped for best
/// performance of the voxel mode.  Also, if explicitly using the Append feature
/// many times, the cell mode will probably be better because each voxel will be
/// visited each Append.  Append the data before input if possible when using
/// the voxel mode.  Do not switch between voxel and cell mode between execution
/// of StartAppend and EndAppend.
/// &lt;P&gt;
/// Further performance improvement is now possible using the PerVoxel process
/// mode on multi-processor machines (the mode is now multithreaded).  Each
/// thread processes a different "slab" of the output.  Also, if the input is
/// vtkPolyData, it is appropriately clipped for each thread; that is, each
/// thread only considers the input which could affect its slab of the output.
/// &lt;P&gt;
/// This filter can now produce output of any type supported by vtkImageData.
/// However to support this change, additional sqrts must be executed during the
/// Append step.  Previously, the output was initialized to the squared CapValue
/// in StartAppend, the output was updated with squared distance values during
/// the Append, and then the sqrt of the distances was computed in EndAppend.
/// To support different scalar types in the output (largely to reduce memory
/// requirements as an vtkImageShiftScale and/or vtkImageCast could have
/// achieved the same result), we can't "afford" to save squared value in the
/// output, because then we could only represent up to the sqrt of the scalar
/// max for an integer type in the output; 1 (instead of 255) for an unsigned
/// char; 11 for a char (instead of 127).  Thus this change may result in a
/// minor performance degradation.  Non-float output types can be scaled to the
/// CapValue by turning ScaleToMaximumDistance On.
///
/// </remarks>
/// <seealso>
///
/// vtkSampleFunction vtkContourFilter
/// </seealso>
public class vtkImplicitModeller : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitModeller";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitModeller()
	{
		MRClassNameKey = "class vtkImplicitModeller";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitModeller"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitModeller(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitModeller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with sample dimensions=(50,50,50), and so that model bounds are
	/// automatically computed from the input. Capping is turned on with CapValue
	/// equal to a large positive number.
	/// </summary>
	public new static vtkImplicitModeller New()
	{
		vtkImplicitModeller result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitModeller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with sample dimensions=(50,50,50), and so that model bounds are
	/// automatically computed from the input. Capping is turned on with CapValue
	/// equal to a large positive number.
	/// </summary>
	public vtkImplicitModeller()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitModeller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_AdjustBoundsOff_01(HandleRef pThis);

	/// <summary>
	/// Control how the model bounds are computed. If the ivar AdjustBounds
	/// is set, then the bounds specified (or computed automatically) is modified
	/// by the fraction given by AdjustDistance. This means that the model
	/// bounds is expanded in each of the x-y-z directions.
	/// </summary>
	public virtual void AdjustBoundsOff()
	{
		vtkImplicitModeller_AdjustBoundsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_AdjustBoundsOn_02(HandleRef pThis);

	/// <summary>
	/// Control how the model bounds are computed. If the ivar AdjustBounds
	/// is set, then the bounds specified (or computed automatically) is modified
	/// by the fraction given by AdjustDistance. This means that the model
	/// bounds is expanded in each of the x-y-z directions.
	/// </summary>
	public virtual void AdjustBoundsOn()
	{
		vtkImplicitModeller_AdjustBoundsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_Append_03(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Append a data set to the existing output. To use this function,
	/// you'll have to invoke the StartAppend() method before doing
	/// successive appends. It's also a good idea to specify the model
	/// bounds; otherwise the input model bounds is used. When you've
	/// finished appending, use the EndAppend() method.
	/// </summary>
	public void Append(vtkDataSet input)
	{
		vtkImplicitModeller_Append_03(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_CappingOff_04(HandleRef pThis);

	/// <summary>
	/// The outer boundary of the structured point set can be assigned a
	/// particular value. This can be used to close or "cap" all surfaces.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkImplicitModeller_CappingOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_CappingOn_05(HandleRef pThis);

	/// <summary>
	/// The outer boundary of the structured point set can be assigned a
	/// particular value. This can be used to close or "cap" all surfaces.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkImplicitModeller_CappingOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitModeller_ComputeModelBounds_06(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Compute ModelBounds from input geometry. If input is not specified, the
	/// input of the filter will be used.
	/// </summary>
	public double ComputeModelBounds(vtkDataSet input)
	{
		return vtkImplicitModeller_ComputeModelBounds_06(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_EndAppend_07(HandleRef pThis);

	/// <summary>
	/// Method completes the append process.
	/// </summary>
	public void EndAppend()
	{
		vtkImplicitModeller_EndAppend_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetAdjustBounds_08(HandleRef pThis);

	/// <summary>
	/// Control how the model bounds are computed. If the ivar AdjustBounds
	/// is set, then the bounds specified (or computed automatically) is modified
	/// by the fraction given by AdjustDistance. This means that the model
	/// bounds is expanded in each of the x-y-z directions.
	/// </summary>
	public virtual int GetAdjustBounds()
	{
		return vtkImplicitModeller_GetAdjustBounds_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitModeller_GetAdjustDistance_09(HandleRef pThis);

	/// <summary>
	/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
	/// is set). The value is a fraction of the maximum length of the sides
	/// of the box specified by the model bounds.
	/// </summary>
	public virtual double GetAdjustDistance()
	{
		return vtkImplicitModeller_GetAdjustDistance_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitModeller_GetAdjustDistanceMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
	/// is set). The value is a fraction of the maximum length of the sides
	/// of the box specified by the model bounds.
	/// </summary>
	public virtual double GetAdjustDistanceMaxValue()
	{
		return vtkImplicitModeller_GetAdjustDistanceMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitModeller_GetAdjustDistanceMinValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
	/// is set). The value is a fraction of the maximum length of the sides
	/// of the box specified by the model bounds.
	/// </summary>
	public virtual double GetAdjustDistanceMinValue()
	{
		return vtkImplicitModeller_GetAdjustDistanceMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitModeller_GetCapValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the capping value to use. The CapValue is also used as an
	/// initial distance value at each point in the dataset.
	/// </summary>
	public virtual double GetCapValue()
	{
		return vtkImplicitModeller_GetCapValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetCapping_13(HandleRef pThis);

	/// <summary>
	/// The outer boundary of the structured point set can be assigned a
	/// particular value. This can be used to close or "cap" all surfaces.
	/// </summary>
	public virtual int GetCapping()
	{
		return vtkImplicitModeller_GetCapping_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetLocatorMaxLevel_14(HandleRef pThis);

	/// <summary>
	/// Specify the level of the locator to use when using the per voxel
	/// process mode.
	/// </summary>
	public virtual int GetLocatorMaxLevel()
	{
		return vtkImplicitModeller_GetLocatorMaxLevel_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitModeller_GetMaximumDistance_15(HandleRef pThis);

	/// <summary>
	/// Set / get the distance away from surface of input geometry to
	/// sample. This value is specified as a percentage of the length of
	/// the diagonal of the input data bounding box.
	/// Smaller values make large increases in performance.
	/// </summary>
	public virtual double GetMaximumDistance()
	{
		return vtkImplicitModeller_GetMaximumDistance_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitModeller_GetMaximumDistanceMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set / get the distance away from surface of input geometry to
	/// sample. This value is specified as a percentage of the length of
	/// the diagonal of the input data bounding box.
	/// Smaller values make large increases in performance.
	/// </summary>
	public virtual double GetMaximumDistanceMaxValue()
	{
		return vtkImplicitModeller_GetMaximumDistanceMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitModeller_GetMaximumDistanceMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set / get the distance away from surface of input geometry to
	/// sample. This value is specified as a percentage of the length of
	/// the diagonal of the input data bounding box.
	/// Smaller values make large increases in performance.
	/// </summary>
	public virtual double GetMaximumDistanceMinValue()
	{
		return vtkImplicitModeller_GetMaximumDistanceMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitModeller_GetModelBounds_18(HandleRef pThis);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkImplicitModeller_GetModelBounds_18(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_GetModelBounds_19(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkImplicitModeller_GetModelBounds_19(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitModeller_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitModeller_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitModeller_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitModeller_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetNumberOfThreads_22(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of threads used during Per-Voxel processing mode
	/// </summary>
	public virtual int GetNumberOfThreads()
	{
		return vtkImplicitModeller_GetNumberOfThreads_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetNumberOfThreadsMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of threads used during Per-Voxel processing mode
	/// </summary>
	public virtual int GetNumberOfThreadsMaxValue()
	{
		return vtkImplicitModeller_GetNumberOfThreadsMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetNumberOfThreadsMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set / Get the number of threads used during Per-Voxel processing mode
	/// </summary>
	public virtual int GetNumberOfThreadsMinValue()
	{
		return vtkImplicitModeller_GetNumberOfThreadsMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetOutputScalarType_25(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImplicitModeller_GetOutputScalarType_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetProcessMode_26(HandleRef pThis);

	/// <summary>
	/// Specify whether to visit each cell once per append or each voxel once
	/// per append.  Some tests have shown once per voxel to be faster
	/// when there are a lot of cells (at least a thousand?); relative
	/// performance improvement increases with addition cells.  Primitives
	/// should not be stripped for best performance of the voxel mode.
	/// </summary>
	public virtual int GetProcessMode()
	{
		return vtkImplicitModeller_GetProcessMode_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitModeller_GetProcessModeAsString_27(HandleRef pThis);

	/// <summary>
	/// Specify whether to visit each cell once per append or each voxel once
	/// per append.  Some tests have shown once per voxel to be faster
	/// when there are a lot of cells (at least a thousand?); relative
	/// performance improvement increases with addition cells.  Primitives
	/// should not be stripped for best performance of the voxel mode.
	/// </summary>
	public string GetProcessModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImplicitModeller_GetProcessModeAsString_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetProcessModeMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Specify whether to visit each cell once per append or each voxel once
	/// per append.  Some tests have shown once per voxel to be faster
	/// when there are a lot of cells (at least a thousand?); relative
	/// performance improvement increases with addition cells.  Primitives
	/// should not be stripped for best performance of the voxel mode.
	/// </summary>
	public virtual int GetProcessModeMaxValue()
	{
		return vtkImplicitModeller_GetProcessModeMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetProcessModeMinValue_29(HandleRef pThis);

	/// <summary>
	/// Specify whether to visit each cell once per append or each voxel once
	/// per append.  Some tests have shown once per voxel to be faster
	/// when there are a lot of cells (at least a thousand?); relative
	/// performance improvement increases with addition cells.  Primitives
	/// should not be stripped for best performance of the voxel mode.
	/// </summary>
	public virtual int GetProcessModeMinValue()
	{
		return vtkImplicitModeller_GetProcessModeMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitModeller_GetSampleDimensions_30(HandleRef pThis);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to sample distance function.
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkImplicitModeller_GetSampleDimensions_30(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_GetSampleDimensions_31(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to sample distance function.
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkImplicitModeller_GetSampleDimensions_31(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_GetScaleToMaximumDistance_32(HandleRef pThis);

	/// <summary>
	/// If a non-floating output type is specified, the output distances can be
	/// scaled to use the entire positive scalar range of the output type
	/// specified (up to the CapValue which is equal to the max for the type
	/// unless modified by the user).  For example, if ScaleToMaximumDistance
	/// is On and the OutputScalarType is UnsignedChar the distances saved in the
	/// output would be linearly scaled between 0 (for distances "very close" to
	/// the surface) and 255 (at the specified maximum distance)... assuming the
	/// CapValue is not changed from 255.
	/// </summary>
	public virtual int GetScaleToMaximumDistance()
	{
		return vtkImplicitModeller_GetScaleToMaximumDistance_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_IsA_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitModeller_IsA_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitModeller_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitModeller_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitModeller_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitModeller NewInstance()
	{
		vtkImplicitModeller result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitModeller_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitModeller_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitModeller SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitModeller vtkImplicitModeller2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitModeller_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitModeller2 = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitModeller2.Register(null);
			}
		}
		return vtkImplicitModeller2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_ScaleToMaximumDistanceOff_38(HandleRef pThis);

	/// <summary>
	/// If a non-floating output type is specified, the output distances can be
	/// scaled to use the entire positive scalar range of the output type
	/// specified (up to the CapValue which is equal to the max for the type
	/// unless modified by the user).  For example, if ScaleToMaximumDistance
	/// is On and the OutputScalarType is UnsignedChar the distances saved in the
	/// output would be linearly scaled between 0 (for distances "very close" to
	/// the surface) and 255 (at the specified maximum distance)... assuming the
	/// CapValue is not changed from 255.
	/// </summary>
	public virtual void ScaleToMaximumDistanceOff()
	{
		vtkImplicitModeller_ScaleToMaximumDistanceOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_ScaleToMaximumDistanceOn_39(HandleRef pThis);

	/// <summary>
	/// If a non-floating output type is specified, the output distances can be
	/// scaled to use the entire positive scalar range of the output type
	/// specified (up to the CapValue which is equal to the max for the type
	/// unless modified by the user).  For example, if ScaleToMaximumDistance
	/// is On and the OutputScalarType is UnsignedChar the distances saved in the
	/// output would be linearly scaled between 0 (for distances "very close" to
	/// the surface) and 255 (at the specified maximum distance)... assuming the
	/// CapValue is not changed from 255.
	/// </summary>
	public virtual void ScaleToMaximumDistanceOn()
	{
		vtkImplicitModeller_ScaleToMaximumDistanceOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetAdjustBounds_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the model bounds are computed. If the ivar AdjustBounds
	/// is set, then the bounds specified (or computed automatically) is modified
	/// by the fraction given by AdjustDistance. This means that the model
	/// bounds is expanded in each of the x-y-z directions.
	/// </summary>
	public virtual void SetAdjustBounds(int _arg)
	{
		vtkImplicitModeller_SetAdjustBounds_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetAdjustDistance_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
	/// is set). The value is a fraction of the maximum length of the sides
	/// of the box specified by the model bounds.
	/// </summary>
	public virtual void SetAdjustDistance(double _arg)
	{
		vtkImplicitModeller_SetAdjustDistance_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetCapValue_42(HandleRef pThis, double value);

	/// <summary>
	/// Specify the capping value to use. The CapValue is also used as an
	/// initial distance value at each point in the dataset.
	/// </summary>
	public void SetCapValue(double value)
	{
		vtkImplicitModeller_SetCapValue_42(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetCapping_43(HandleRef pThis, int _arg);

	/// <summary>
	/// The outer boundary of the structured point set can be assigned a
	/// particular value. This can be used to close or "cap" all surfaces.
	/// </summary>
	public virtual void SetCapping(int _arg)
	{
		vtkImplicitModeller_SetCapping_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetLocatorMaxLevel_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the level of the locator to use when using the per voxel
	/// process mode.
	/// </summary>
	public virtual void SetLocatorMaxLevel(int _arg)
	{
		vtkImplicitModeller_SetLocatorMaxLevel_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetMaximumDistance_45(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the distance away from surface of input geometry to
	/// sample. This value is specified as a percentage of the length of
	/// the diagonal of the input data bounding box.
	/// Smaller values make large increases in performance.
	/// </summary>
	public virtual void SetMaximumDistance(double _arg)
	{
		vtkImplicitModeller_SetMaximumDistance_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetModelBounds_46(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkImplicitModeller_SetModelBounds_46(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetModelBounds_47(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the region in space in which to perform the sampling. If
	/// not specified, it will be computed automatically.
	/// </summary>
	public virtual void SetModelBounds(IntPtr _arg)
	{
		vtkImplicitModeller_SetModelBounds_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetNumberOfThreads_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / Get the number of threads used during Per-Voxel processing mode
	/// </summary>
	public virtual void SetNumberOfThreads(int _arg)
	{
		vtkImplicitModeller_SetNumberOfThreads_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarType_49(HandleRef pThis, int type);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarType(int type)
	{
		vtkImplicitModeller_SetOutputScalarType_49(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToChar_50(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToChar()
	{
		vtkImplicitModeller_SetOutputScalarTypeToChar_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToDouble_51(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkImplicitModeller_SetOutputScalarTypeToDouble_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToFloat_52(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkImplicitModeller_SetOutputScalarTypeToFloat_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToInt_53(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToInt()
	{
		vtkImplicitModeller_SetOutputScalarTypeToInt_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToLong_54(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToLong()
	{
		vtkImplicitModeller_SetOutputScalarTypeToLong_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToShort_55(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToShort()
	{
		vtkImplicitModeller_SetOutputScalarTypeToShort_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedChar_56(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedChar()
	{
		vtkImplicitModeller_SetOutputScalarTypeToUnsignedChar_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedInt_57(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedInt()
	{
		vtkImplicitModeller_SetOutputScalarTypeToUnsignedInt_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedLong_58(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedLong()
	{
		vtkImplicitModeller_SetOutputScalarTypeToUnsignedLong_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedShort_59(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedShort()
	{
		vtkImplicitModeller_SetOutputScalarTypeToUnsignedShort_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetProcessMode_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether to visit each cell once per append or each voxel once
	/// per append.  Some tests have shown once per voxel to be faster
	/// when there are a lot of cells (at least a thousand?); relative
	/// performance improvement increases with addition cells.  Primitives
	/// should not be stripped for best performance of the voxel mode.
	/// </summary>
	public virtual void SetProcessMode(int _arg)
	{
		vtkImplicitModeller_SetProcessMode_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetProcessModeToPerCell_61(HandleRef pThis);

	/// <summary>
	/// Specify whether to visit each cell once per append or each voxel once
	/// per append.  Some tests have shown once per voxel to be faster
	/// when there are a lot of cells (at least a thousand?); relative
	/// performance improvement increases with addition cells.  Primitives
	/// should not be stripped for best performance of the voxel mode.
	/// </summary>
	public void SetProcessModeToPerCell()
	{
		vtkImplicitModeller_SetProcessModeToPerCell_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetProcessModeToPerVoxel_62(HandleRef pThis);

	/// <summary>
	/// Specify whether to visit each cell once per append or each voxel once
	/// per append.  Some tests have shown once per voxel to be faster
	/// when there are a lot of cells (at least a thousand?); relative
	/// performance improvement increases with addition cells.  Primitives
	/// should not be stripped for best performance of the voxel mode.
	/// </summary>
	public void SetProcessModeToPerVoxel()
	{
		vtkImplicitModeller_SetProcessModeToPerVoxel_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetSampleDimensions_63(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to sample distance function.
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkImplicitModeller_SetSampleDimensions_63(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetSampleDimensions_64(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set/Get the i-j-k dimensions on which to sample distance function.
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkImplicitModeller_SetSampleDimensions_64(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_SetScaleToMaximumDistance_65(HandleRef pThis, int _arg);

	/// <summary>
	/// If a non-floating output type is specified, the output distances can be
	/// scaled to use the entire positive scalar range of the output type
	/// specified (up to the CapValue which is equal to the max for the type
	/// unless modified by the user).  For example, if ScaleToMaximumDistance
	/// is On and the OutputScalarType is UnsignedChar the distances saved in the
	/// output would be linearly scaled between 0 (for distances "very close" to
	/// the surface) and 255 (at the specified maximum distance)... assuming the
	/// CapValue is not changed from 255.
	/// </summary>
	public virtual void SetScaleToMaximumDistance(int _arg)
	{
		vtkImplicitModeller_SetScaleToMaximumDistance_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitModeller_StartAppend_66(HandleRef pThis);

	/// <summary>
	/// Initialize the filter for appending data. You must invoke the
	/// StartAppend() method before doing successive Appends(). It's also a
	/// good idea to manually specify the model bounds; otherwise the input
	/// bounds for the data will be used.
	/// </summary>
	public void StartAppend()
	{
		vtkImplicitModeller_StartAppend_66(GetCppThis());
	}
}
