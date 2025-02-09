using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolumeRayCastSpaceLeapingImageFilter
/// </summary>
/// <remarks>
///    Builds the space leaping data structure.
///
/// This is an optimized multi-threaded imaging filter that builds the space
/// leaping datastructure, used by vtkFixedPointVolumeRayCastMapper. Empty
/// space leaping is used to skip large empty regions in the scalar
/// opacity and/or the gradient opacity transfer functions. Depending on
/// the various options set by vtkFixedPointVolumeRayCastMapper, the class
/// will internally invoke one of the many optimized routines to compute the
/// min/max/gradient-max values within a fixed block size, trying to
/// compute everything in a single multi-threaded pass through the data
///
/// The block size may be changed at compile time. Its ifdef'ed to 4 in the CXX
/// file.
/// </remarks>
public class vtkVolumeRayCastSpaceLeapingImageFilter : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRayCastSpaceLeapingImageFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolumeRayCastSpaceLeapingImageFilter()
	{
		MRClassNameKey = "class vtkVolumeRayCastSpaceLeapingImageFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRayCastSpaceLeapingImageFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolumeRayCastSpaceLeapingImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeRayCastSpaceLeapingImageFilter New()
	{
		vtkVolumeRayCastSpaceLeapingImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVolumeRayCastSpaceLeapingImageFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVolumeRayCastSpaceLeapingImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOff_01(HandleRef pThis);

	/// <summary>
	/// Compute gradient opacity ?
	/// </summary>
	public virtual void ComputeGradientOpacityOff()
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOn_02(HandleRef pThis);

	/// <summary>
	/// Compute gradient opacity ?
	/// </summary>
	public virtual void ComputeGradientOpacityOn()
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeInputExtentsForOutput_03(IntPtr inExt, IntPtr inDim, IntPtr outExt, HandleRef inData);

	/// <summary>
	/// Compute the extents and dimensions of the input that's required to
	/// generate an output min-max structure given by outExt.
	/// INTERNAL - Do not use
	/// </summary>
	public static void ComputeInputExtentsForOutput(IntPtr inExt, IntPtr inDim, IntPtr outExt, vtkImageData inData)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_ComputeInputExtentsForOutput_03(inExt, inDim, outExt, inData?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOff_04(HandleRef pThis);

	/// <summary>
	/// Compute the min max structure ?.
	/// </summary>
	public virtual void ComputeMinMaxOff()
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOn_05(HandleRef pThis);

	/// <summary>
	/// Compute the min max structure ?.
	/// </summary>
	public virtual void ComputeMinMaxOn()
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeRayCastSpaceLeapingImageFilter_ComputeOffset_06(HandleRef pThis, IntPtr ext, IntPtr wholeExt, int nComponents);

	/// <summary>
	/// INTERNAL - Do not use
	/// Compute the offset within an image of whole extents wholeExt, to access
	/// the data starting at extents ext.
	/// </summary>
	public long ComputeOffset(IntPtr ext, IntPtr wholeExt, int nComponents)
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_ComputeOffset_06(GetCppThis(), ext, wholeExt, nComponents);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeGradientOpacity_07(HandleRef pThis);

	/// <summary>
	/// Compute gradient opacity ?
	/// </summary>
	public virtual int GetComputeGradientOpacity()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeGradientOpacity_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeMinMax_08(HandleRef pThis);

	/// <summary>
	/// Compute the min max structure ?.
	/// </summary>
	public virtual int GetComputeMinMax()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeMinMax_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetCurrentScalars_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the scalars.
	/// </summary>
	public virtual vtkDataArray GetCurrentScalars()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter_GetCurrentScalars_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetIndependentComponents_10(HandleRef pThis);

	/// <summary>
	/// Do we use independent components, or dependent components ?
	/// </summary>
	public virtual int GetIndependentComponents()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetIndependentComponents_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxBuildTime_11(HandleRef pThis);

	/// <summary>
	/// Get the last execution time. This is updated every
	/// time the scalars or the gradient opacity values are computed
	/// </summary>
	public ulong GetLastMinMaxBuildTime()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxBuildTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxFlagTime_12(HandleRef pThis);

	/// <summary>
	/// Get the last execution time. This is updated every time the flags bits
	/// are re-computed.
	/// </summary>
	public ulong GetLastMinMaxFlagTime()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxFlagTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinMaxVolume_13(HandleRef pThis, IntPtr dims);

	/// <summary>
	/// Get the raw pointer to the final computed space leaping datastructure.
	/// The result is only valid after Update() has been called on the filter.
	/// Note that this filter holds onto its memory. The dimensions of the min-
	/// max volume are in dims. The 4th value in the array indicates the number
	/// of independent components, (also queried via
	/// GetNumberOfIndependentComponents())
	/// </summary>
	public IntPtr GetMinMaxVolume(IntPtr dims)
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetMinMaxVolume_13(GetCppThis(), dims);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroGradientMagnitudeIndex_14(HandleRef pThis);

	/// <summary>
	/// Get the first non-zero scalar opacity and gradient opacity indices for
	/// each independent component
	/// INTERNAL - Do not use.
	/// </summary>
	public IntPtr GetMinNonZeroGradientMagnitudeIndex()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroGradientMagnitudeIndex_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroScalarIndex_15(HandleRef pThis);

	/// <summary>
	/// Get the first non-zero scalar opacity and gradient opacity indices for
	/// each independent component
	/// INTERNAL - Do not use.
	/// </summary>
	public IntPtr GetMinNonZeroScalarIndex()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroScalarIndex_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfIndependentComponents_18(HandleRef pThis);

	/// <summary>
	/// Get the number of independent components for which we need to keep track
	/// of min/max
	/// </summary>
	public int GetNumberOfIndependentComponents()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfIndependentComponents_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_19(HandleRef pThis);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual float[] GetTableScale()
	{
		IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_19(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_20(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void GetTableScale(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_20(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void GetTableScale(IntPtr _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_22(HandleRef pThis);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual float[] GetTableShift()
	{
		IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_22(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_23(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void GetTableShift(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_23(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void GetTableShift(IntPtr _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_25(HandleRef pThis);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual int[] GetTableSize()
	{
		IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_25(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_26(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void GetTableSize(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_26(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void GetTableSize(IntPtr _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetUpdateGradientOpacityFlags_28(HandleRef pThis);

	/// <summary>
	/// Update the gradient opacity flags. (The scalar opacity flags are always
	/// updated upon execution of this filter.)
	/// </summary>
	public virtual int GetUpdateGradientOpacityFlags()
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_GetUpdateGradientOpacityFlags_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolumeRayCastSpaceLeapingImageFilter_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolumeRayCastSpaceLeapingImageFilter NewInstance()
	{
		vtkVolumeRayCastSpaceLeapingImageFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeRayCastSpaceLeapingImageFilter SafeDownCast(vtkObjectBase o)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter vtkVolumeRayCastSpaceLeapingImageFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter_SafeDownCast_33(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter2 = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeRayCastSpaceLeapingImageFilter2.Register(null);
			}
		}
		return vtkVolumeRayCastSpaceLeapingImageFilter2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetCache_34(HandleRef pThis, HandleRef imageCache);

	/// <summary>
	/// INTERNAL - Do not use
	/// Set the last cached min-max volume, as used by
	/// vtkFixedPointVolumeRayCastMapper.
	/// </summary>
	public virtual void SetCache(vtkImageData imageCache)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetCache_34(GetCppThis(), imageCache?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeGradientOpacity_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Compute gradient opacity ?
	/// </summary>
	public virtual void SetComputeGradientOpacity(int _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeGradientOpacity_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeMinMax_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Compute the min max structure ?.
	/// </summary>
	public virtual void SetComputeMinMax(int _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeMinMax_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetCurrentScalars_37(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the scalars.
	/// </summary>
	public virtual void SetCurrentScalars(vtkDataArray arg0)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetCurrentScalars_37(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetGradientOpacityTable_38(HandleRef pThis, int c, IntPtr t);

	/// <summary>
	/// Set the scalar opacity and gradient opacity tables computed for each
	/// component by the vtkFixedPointVolumeRayCastMapper
	/// </summary>
	public void SetGradientOpacityTable(int c, IntPtr t)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetGradientOpacityTable_38(GetCppThis(), c, t);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetIndependentComponents_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Do we use independent components, or dependent components ?
	/// </summary>
	public virtual void SetIndependentComponents(int _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetIndependentComponents_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetScalarOpacityTable_40(HandleRef pThis, int c, IntPtr t);

	/// <summary>
	/// Set the scalar opacity and gradient opacity tables computed for each
	/// component by the vtkFixedPointVolumeRayCastMapper
	/// </summary>
	public void SetScalarOpacityTable(int c, IntPtr t)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetScalarOpacityTable_40(GetCppThis(), c, t);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_41(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void SetTableScale(float _arg1, float _arg2, float _arg3, float _arg4)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_41(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void SetTableScale(IntPtr _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_43(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void SetTableShift(float _arg1, float _arg2, float _arg3, float _arg4)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_43(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void SetTableShift(IntPtr _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_45(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void SetTableSize(int _arg1, int _arg2, int _arg3, int _arg4)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_45(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Is the difference between max and min of the data less than 32768? If so,
	/// and if the data is not of float/double type, use a simple offset mapping.
	/// If the difference between max and min is 32768 or greater, or the data
	/// is of type float or double, we must use an offset / scaling mapping.
	/// In this case, the array size will be 32768 - we need to figure out the
	/// offset and scale factor.
	/// </summary>
	public virtual void SetTableSize(IntPtr _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetUpdateGradientOpacityFlags_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Update the gradient opacity flags. (The scalar opacity flags are always
	/// updated upon execution of this filter.)
	/// </summary>
	public virtual void SetUpdateGradientOpacityFlags(int _arg)
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_SetUpdateGradientOpacityFlags_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOff_48(HandleRef pThis);

	/// <summary>
	/// Update the gradient opacity flags. (The scalar opacity flags are always
	/// updated upon execution of this filter.)
	/// </summary>
	public virtual void UpdateGradientOpacityFlagsOff()
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOff_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOn_49(HandleRef pThis);

	/// <summary>
	/// Update the gradient opacity flags. (The scalar opacity flags are always
	/// updated upon execution of this filter.)
	/// </summary>
	public virtual void UpdateGradientOpacityFlagsOn()
	{
		vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOn_49(GetCppThis());
	}
}
