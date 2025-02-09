using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageThresholdConnectivity
/// </summary>
/// <remarks>
///    Flood fill an image region.
///
/// vtkImageThresholdConnectivity will perform a flood fill on an image,
/// given upper and lower pixel intensity thresholds. It works similarly
/// to vtkImageThreshold, but also allows the user to set seed points
/// to limit the threshold operation to contiguous regions of the image.
/// The filled region, or the "inside", will be passed through to the
/// output by default, while the "outside" will be replaced with zeros.
/// This behavior can be changed by using the ReplaceIn() and ReplaceOut()
/// methods.  The scalar type of the output is the same as the input.
/// </remarks>
/// <seealso>
///
/// vtkImageThreshold
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </seealso>
public class vtkImageThresholdConnectivity : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageThresholdConnectivity";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageThresholdConnectivity()
	{
		MRClassNameKey = "class vtkImageThresholdConnectivity";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageThresholdConnectivity"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageThresholdConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageThresholdConnectivity New()
	{
		vtkImageThresholdConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageThresholdConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageThresholdConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageThresholdConnectivity()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageThresholdConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageThresholdConnectivity_GetActiveComponent_01(HandleRef pThis);

	/// <summary>
	/// For multi-component images, you can set which component will be
	/// used for the threshold checks.
	/// </summary>
	public virtual int GetActiveComponent()
	{
		return vtkImageThresholdConnectivity_GetActiveComponent_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThresholdConnectivity_GetInValue_02(HandleRef pThis);

	/// <summary>
	/// If ReplaceIn is set, the filled region will be replaced by this value.
	/// </summary>
	public virtual double GetInValue()
	{
		return vtkImageThresholdConnectivity_GetInValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThresholdConnectivity_GetLowerThreshold_03(HandleRef pThis);

	/// <summary>
	/// Get the Upper and Lower thresholds.
	/// </summary>
	public virtual double GetLowerThreshold()
	{
		return vtkImageThresholdConnectivity_GetLowerThreshold_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageThresholdConnectivity_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Override the MTime to account for the seed points.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageThresholdConnectivity_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThresholdConnectivity_GetNeighborhoodFraction_05(HandleRef pThis);

	/// <summary>
	/// The fraction of the neighborhood that must be within the thresholds.
	/// The default value is 0.5.
	/// </summary>
	public virtual double GetNeighborhoodFraction()
	{
		return vtkImageThresholdConnectivity_GetNeighborhoodFraction_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThresholdConnectivity_GetNeighborhoodFractionMaxValue_06(HandleRef pThis);

	/// <summary>
	/// The fraction of the neighborhood that must be within the thresholds.
	/// The default value is 0.5.
	/// </summary>
	public virtual double GetNeighborhoodFractionMaxValue()
	{
		return vtkImageThresholdConnectivity_GetNeighborhoodFractionMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThresholdConnectivity_GetNeighborhoodFractionMinValue_07(HandleRef pThis);

	/// <summary>
	/// The fraction of the neighborhood that must be within the thresholds.
	/// The default value is 0.5.
	/// </summary>
	public virtual double GetNeighborhoodFractionMinValue()
	{
		return vtkImageThresholdConnectivity_GetNeighborhoodFractionMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_GetNeighborhoodRadius_08(HandleRef pThis);

	/// <summary>
	/// The radius of the neighborhood that must be within the threshold
	/// values in order for the voxel to be included in the mask.  The
	/// default radius is zero (one single voxel).  The radius is measured
	/// in voxels.
	/// </summary>
	public virtual double[] GetNeighborhoodRadius()
	{
		IntPtr intPtr = vtkImageThresholdConnectivity_GetNeighborhoodRadius_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_GetNeighborhoodRadius_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// The radius of the neighborhood that must be within the threshold
	/// values in order for the voxel to be included in the mask.  The
	/// default radius is zero (one single voxel).  The radius is measured
	/// in voxels.
	/// </summary>
	public virtual void GetNeighborhoodRadius(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageThresholdConnectivity_GetNeighborhoodRadius_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_GetNeighborhoodRadius_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The radius of the neighborhood that must be within the threshold
	/// values in order for the voxel to be included in the mask.  The
	/// default radius is zero (one single voxel).  The radius is measured
	/// in voxels.
	/// </summary>
	public virtual void GetNeighborhoodRadius(IntPtr _arg)
	{
		vtkImageThresholdConnectivity_GetNeighborhoodRadius_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageThresholdConnectivity_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageThresholdConnectivity_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageThresholdConnectivity_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageThresholdConnectivity_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThresholdConnectivity_GetNumberOfInVoxels_13(HandleRef pThis);

	/// <summary>
	/// After the filter has executed, use GetNumberOfVoxels() to find
	/// out how many voxels were filled.
	/// </summary>
	public virtual int GetNumberOfInVoxels()
	{
		return vtkImageThresholdConnectivity_GetNumberOfInVoxels_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThresholdConnectivity_GetOutValue_14(HandleRef pThis);

	/// <summary>
	/// If ReplaceOut is set, outside the fill will be replaced by this value.
	/// </summary>
	public virtual double GetOutValue()
	{
		return vtkImageThresholdConnectivity_GetOutValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThresholdConnectivity_GetReplaceIn_15(HandleRef pThis);

	/// <summary>
	/// Replace the filled region by the value set by SetInValue().
	/// </summary>
	public virtual int GetReplaceIn()
	{
		return vtkImageThresholdConnectivity_GetReplaceIn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThresholdConnectivity_GetReplaceOut_16(HandleRef pThis);

	/// <summary>
	/// Replace the filled region by the value set by SetInValue().
	/// </summary>
	public virtual int GetReplaceOut()
	{
		return vtkImageThresholdConnectivity_GetReplaceOut_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_GetSeedPoints_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the seeds.  The seeds are in real data coordinates, not in
	/// voxel index locations.
	/// </summary>
	public virtual vtkPoints GetSeedPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageThresholdConnectivity_GetSeedPoints_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_GetSliceRangeX_18(HandleRef pThis);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual int[] GetSliceRangeX()
	{
		IntPtr intPtr = vtkImageThresholdConnectivity_GetSliceRangeX_18(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_GetSliceRangeX_19(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void GetSliceRangeX(ref int _arg1, ref int _arg2)
	{
		vtkImageThresholdConnectivity_GetSliceRangeX_19(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_GetSliceRangeX_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void GetSliceRangeX(IntPtr _arg)
	{
		vtkImageThresholdConnectivity_GetSliceRangeX_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_GetSliceRangeY_21(HandleRef pThis);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual int[] GetSliceRangeY()
	{
		IntPtr intPtr = vtkImageThresholdConnectivity_GetSliceRangeY_21(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_GetSliceRangeY_22(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void GetSliceRangeY(ref int _arg1, ref int _arg2)
	{
		vtkImageThresholdConnectivity_GetSliceRangeY_22(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_GetSliceRangeY_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void GetSliceRangeY(IntPtr _arg)
	{
		vtkImageThresholdConnectivity_GetSliceRangeY_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_GetSliceRangeZ_24(HandleRef pThis);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual int[] GetSliceRangeZ()
	{
		IntPtr intPtr = vtkImageThresholdConnectivity_GetSliceRangeZ_24(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_GetSliceRangeZ_25(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void GetSliceRangeZ(ref int _arg1, ref int _arg2)
	{
		vtkImageThresholdConnectivity_GetSliceRangeZ_25(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_GetSliceRangeZ_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void GetSliceRangeZ(IntPtr _arg)
	{
		vtkImageThresholdConnectivity_GetSliceRangeZ_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_GetStencil_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a stencil that will be used to limit the flood fill to
	/// an arbitrarily-shaped region of the image.
	/// </summary>
	public vtkImageStencilData GetStencil()
	{
		vtkImageStencilData vtkImageStencilData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageThresholdConnectivity_GetStencil_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilData2 = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilData2.Register(null);
			}
		}
		return vtkImageStencilData2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThresholdConnectivity_GetUpperThreshold_28(HandleRef pThis);

	/// <summary>
	/// Get the Upper and Lower thresholds.
	/// </summary>
	public virtual double GetUpperThreshold()
	{
		return vtkImageThresholdConnectivity_GetUpperThreshold_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThresholdConnectivity_IsA_29(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageThresholdConnectivity_IsA_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThresholdConnectivity_IsTypeOf_30(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageThresholdConnectivity_IsTypeOf_30(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageThresholdConnectivity NewInstance()
	{
		vtkImageThresholdConnectivity result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageThresholdConnectivity_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageThresholdConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_ReplaceInOff_33(HandleRef pThis);

	/// <summary>
	/// Replace the filled region by the value set by SetInValue().
	/// </summary>
	public virtual void ReplaceInOff()
	{
		vtkImageThresholdConnectivity_ReplaceInOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_ReplaceInOn_34(HandleRef pThis);

	/// <summary>
	/// Replace the filled region by the value set by SetInValue().
	/// </summary>
	public virtual void ReplaceInOn()
	{
		vtkImageThresholdConnectivity_ReplaceInOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_ReplaceOutOff_35(HandleRef pThis);

	/// <summary>
	/// Replace the filled region by the value set by SetInValue().
	/// </summary>
	public virtual void ReplaceOutOff()
	{
		vtkImageThresholdConnectivity_ReplaceOutOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_ReplaceOutOn_36(HandleRef pThis);

	/// <summary>
	/// Replace the filled region by the value set by SetInValue().
	/// </summary>
	public virtual void ReplaceOutOn()
	{
		vtkImageThresholdConnectivity_ReplaceOutOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThresholdConnectivity_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageThresholdConnectivity SafeDownCast(vtkObjectBase o)
	{
		vtkImageThresholdConnectivity vtkImageThresholdConnectivity2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageThresholdConnectivity_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageThresholdConnectivity2 = (vtkImageThresholdConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageThresholdConnectivity2.Register(null);
			}
		}
		return vtkImageThresholdConnectivity2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetActiveComponent_38(HandleRef pThis, int _arg);

	/// <summary>
	/// For multi-component images, you can set which component will be
	/// used for the threshold checks.
	/// </summary>
	public virtual void SetActiveComponent(int _arg)
	{
		vtkImageThresholdConnectivity_SetActiveComponent_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetInValue_39(HandleRef pThis, double val);

	/// <summary>
	/// If ReplaceIn is set, the filled region will be replaced by this value.
	/// </summary>
	public void SetInValue(double val)
	{
		vtkImageThresholdConnectivity_SetInValue_39(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetNeighborhoodFraction_40(HandleRef pThis, double _arg);

	/// <summary>
	/// The fraction of the neighborhood that must be within the thresholds.
	/// The default value is 0.5.
	/// </summary>
	public virtual void SetNeighborhoodFraction(double _arg)
	{
		vtkImageThresholdConnectivity_SetNeighborhoodFraction_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetNeighborhoodRadius_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// The radius of the neighborhood that must be within the threshold
	/// values in order for the voxel to be included in the mask.  The
	/// default radius is zero (one single voxel).  The radius is measured
	/// in voxels.
	/// </summary>
	public virtual void SetNeighborhoodRadius(double _arg1, double _arg2, double _arg3)
	{
		vtkImageThresholdConnectivity_SetNeighborhoodRadius_41(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetNeighborhoodRadius_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The radius of the neighborhood that must be within the threshold
	/// values in order for the voxel to be included in the mask.  The
	/// default radius is zero (one single voxel).  The radius is measured
	/// in voxels.
	/// </summary>
	public virtual void SetNeighborhoodRadius(IntPtr _arg)
	{
		vtkImageThresholdConnectivity_SetNeighborhoodRadius_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetOutValue_43(HandleRef pThis, double val);

	/// <summary>
	/// If ReplaceOut is set, outside the fill will be replaced by this value.
	/// </summary>
	public void SetOutValue(double val)
	{
		vtkImageThresholdConnectivity_SetOutValue_43(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetReplaceIn_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Replace the filled region by the value set by SetInValue().
	/// </summary>
	public virtual void SetReplaceIn(int _arg)
	{
		vtkImageThresholdConnectivity_SetReplaceIn_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetReplaceOut_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Replace the filled region by the value set by SetInValue().
	/// </summary>
	public virtual void SetReplaceOut(int _arg)
	{
		vtkImageThresholdConnectivity_SetReplaceOut_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetSeedPoints_46(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Set the seeds.  The seeds are in real data coordinates, not in
	/// voxel index locations.
	/// </summary>
	public void SetSeedPoints(vtkPoints points)
	{
		vtkImageThresholdConnectivity_SetSeedPoints_46(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetSliceRangeX_47(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void SetSliceRangeX(int _arg1, int _arg2)
	{
		vtkImageThresholdConnectivity_SetSliceRangeX_47(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetSliceRangeX_48(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public void SetSliceRangeX(IntPtr _arg)
	{
		vtkImageThresholdConnectivity_SetSliceRangeX_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetSliceRangeY_49(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void SetSliceRangeY(int _arg1, int _arg2)
	{
		vtkImageThresholdConnectivity_SetSliceRangeY_49(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetSliceRangeY_50(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public void SetSliceRangeY(IntPtr _arg)
	{
		vtkImageThresholdConnectivity_SetSliceRangeY_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetSliceRangeZ_51(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public virtual void SetSliceRangeZ(int _arg1, int _arg2)
	{
		vtkImageThresholdConnectivity_SetSliceRangeZ_51(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetSliceRangeZ_52(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Limit the flood to a range of slices in the specified direction.
	/// </summary>
	public void SetSliceRangeZ(IntPtr _arg)
	{
		vtkImageThresholdConnectivity_SetSliceRangeZ_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_SetStencilData_53(HandleRef pThis, HandleRef stencil);

	/// <summary>
	/// Specify a stencil that will be used to limit the flood fill to
	/// an arbitrarily-shaped region of the image.
	/// </summary>
	public virtual void SetStencilData(vtkImageStencilData stencil)
	{
		vtkImageThresholdConnectivity_SetStencilData_53(GetCppThis(), stencil?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_ThresholdBetween_54(HandleRef pThis, double lower, double upper);

	/// <summary>
	/// Values within this range will be filled, where the range includes
	/// values that are exactly equal to the lower and upper thresholds.
	/// </summary>
	public void ThresholdBetween(double lower, double upper)
	{
		vtkImageThresholdConnectivity_ThresholdBetween_54(GetCppThis(), lower, upper);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_ThresholdByLower_55(HandleRef pThis, double thresh);

	/// <summary>
	/// Values less than or equal to this threshold will be filled.
	/// </summary>
	public void ThresholdByLower(double thresh)
	{
		vtkImageThresholdConnectivity_ThresholdByLower_55(GetCppThis(), thresh);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThresholdConnectivity_ThresholdByUpper_56(HandleRef pThis, double thresh);

	/// <summary>
	/// Values greater than or equal to this threshold will be filled.
	/// </summary>
	public void ThresholdByUpper(double thresh)
	{
		vtkImageThresholdConnectivity_ThresholdByUpper_56(GetCppThis(), thresh);
	}
}
