using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFastSplatter
/// </summary>
/// <remarks>
///    A splatter optimized for splatting single kernels.
///
///
///
/// vtkFastSplatter takes any vtkPointSet as input (of which vtkPolyData and
/// vtkUnstructuredGrid inherit).  Each point in the data set is considered to be
/// an impulse.  These impulses are convolved with a given splat image.  In other
/// words, the splat image is added to the final image at every place where there
/// is an input point.
///
/// Note that point and cell data are thrown away.  If you want a sampling
/// of unstructured points consider vtkGaussianSplatter or vtkShepardMethod.
///
/// Use input port 0 for the impulse data (vtkPointSet), and input port 1 for
/// the splat image (vtkImageData)
///
///
/// @bug
/// Any point outside of the extents of the image is thrown away, even if it is
/// close enough such that it's convolution with the splat image would overlap
/// the extents.
///
/// </remarks>
public class vtkFastSplatter : vtkImageAlgorithm
{
	/// <summary>
	/// Set/get the dimensions of the output image
	/// </summary>
	public enum ClampLimit_WrapperEnum
	{
		/// <summary>enum member</summary>
		ClampLimit = 1,
		/// <summary>enum member</summary>
		FreezeScaleLimit = 3,
		/// <summary>enum member</summary>
		NoneLimit = 0,
		/// <summary>enum member</summary>
		ScaleLimit = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFastSplatter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFastSplatter()
	{
		MRClassNameKey = "class vtkFastSplatter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFastSplatter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFastSplatter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFastSplatter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFastSplatter New()
	{
		vtkFastSplatter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFastSplatter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFastSplatter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFastSplatter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFastSplatter_GetLimitMode_01(HandleRef pThis);

	/// <summary>
	/// Set/get the way voxel values will be limited.  If this is set to None (the
	/// default), the output can have arbitrarily large values.  If set to clamp,
	/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
	/// output will be linearly scaled between MinValue and MaxValue.
	/// </summary>
	public virtual int GetLimitMode()
	{
		return vtkFastSplatter_GetLimitMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFastSplatter_GetMaxValue_02(HandleRef pThis);

	/// <summary>
	/// See the LimitMode method.
	/// </summary>
	public virtual double GetMaxValue()
	{
		return vtkFastSplatter_GetMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFastSplatter_GetMinValue_03(HandleRef pThis);

	/// <summary>
	/// See the LimitMode method.
	/// </summary>
	public virtual double GetMinValue()
	{
		return vtkFastSplatter_GetMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFastSplatter_GetModelBounds_04(HandleRef pThis);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkFastSplatter_GetModelBounds_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_GetModelBounds_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkFastSplatter_GetModelBounds_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFastSplatter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFastSplatter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFastSplatter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFastSplatter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFastSplatter_GetNumberOfPointsSplatted_08(HandleRef pThis);

	/// <summary>
	/// This returns the number of points splatted (as opposed to
	/// discarded for being outside the image) during the previous pass.
	/// </summary>
	public virtual int GetNumberOfPointsSplatted()
	{
		return vtkFastSplatter_GetNumberOfPointsSplatted_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFastSplatter_GetOutputDimensions_09(HandleRef pThis);

	/// <summary>
	/// Set/get the dimensions of the output image
	/// </summary>
	public virtual int[] GetOutputDimensions()
	{
		IntPtr intPtr = vtkFastSplatter_GetOutputDimensions_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_GetOutputDimensions_10(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set/get the dimensions of the output image
	/// </summary>
	public virtual void GetOutputDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkFastSplatter_GetOutputDimensions_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_GetOutputDimensions_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the dimensions of the output image
	/// </summary>
	public virtual void GetOutputDimensions(IntPtr _arg)
	{
		vtkFastSplatter_GetOutputDimensions_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFastSplatter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFastSplatter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFastSplatter_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFastSplatter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFastSplatter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFastSplatter NewInstance()
	{
		vtkFastSplatter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFastSplatter_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFastSplatter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFastSplatter SafeDownCast(vtkObjectBase o)
	{
		vtkFastSplatter vtkFastSplatter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFastSplatter_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFastSplatter2 = (vtkFastSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFastSplatter2.Register(null);
			}
		}
		return vtkFastSplatter2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetLimitMode_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the way voxel values will be limited.  If this is set to None (the
	/// default), the output can have arbitrarily large values.  If set to clamp,
	/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
	/// output will be linearly scaled between MinValue and MaxValue.
	/// </summary>
	public virtual void SetLimitMode(int _arg)
	{
		vtkFastSplatter_SetLimitMode_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetLimitModeToClamp_18(HandleRef pThis);

	/// <summary>
	/// Set/get the way voxel values will be limited.  If this is set to None (the
	/// default), the output can have arbitrarily large values.  If set to clamp,
	/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
	/// output will be linearly scaled between MinValue and MaxValue.
	/// </summary>
	public void SetLimitModeToClamp()
	{
		vtkFastSplatter_SetLimitModeToClamp_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetLimitModeToFreezeScale_19(HandleRef pThis);

	/// <summary>
	/// Set/get the way voxel values will be limited.  If this is set to None (the
	/// default), the output can have arbitrarily large values.  If set to clamp,
	/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
	/// output will be linearly scaled between MinValue and MaxValue.
	/// </summary>
	public void SetLimitModeToFreezeScale()
	{
		vtkFastSplatter_SetLimitModeToFreezeScale_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetLimitModeToNone_20(HandleRef pThis);

	/// <summary>
	/// Set/get the way voxel values will be limited.  If this is set to None (the
	/// default), the output can have arbitrarily large values.  If set to clamp,
	/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
	/// output will be linearly scaled between MinValue and MaxValue.
	/// </summary>
	public void SetLimitModeToNone()
	{
		vtkFastSplatter_SetLimitModeToNone_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetLimitModeToScale_21(HandleRef pThis);

	/// <summary>
	/// Set/get the way voxel values will be limited.  If this is set to None (the
	/// default), the output can have arbitrarily large values.  If set to clamp,
	/// the output will be clamped to [MinValue,MaxValue].  If set to scale, the
	/// output will be linearly scaled between MinValue and MaxValue.
	/// </summary>
	public void SetLimitModeToScale()
	{
		vtkFastSplatter_SetLimitModeToScale_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetMaxValue_22(HandleRef pThis, double _arg);

	/// <summary>
	/// See the LimitMode method.
	/// </summary>
	public virtual void SetMaxValue(double _arg)
	{
		vtkFastSplatter_SetMaxValue_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetMinValue_23(HandleRef pThis, double _arg);

	/// <summary>
	/// See the LimitMode method.
	/// </summary>
	public virtual void SetMinValue(double _arg)
	{
		vtkFastSplatter_SetMinValue_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetModelBounds_24(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkFastSplatter_SetModelBounds_24(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetModelBounds_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(IntPtr _arg)
	{
		vtkFastSplatter_SetModelBounds_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetOutputDimensions_26(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set/get the dimensions of the output image
	/// </summary>
	public virtual void SetOutputDimensions(int _arg1, int _arg2, int _arg3)
	{
		vtkFastSplatter_SetOutputDimensions_26(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetOutputDimensions_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the dimensions of the output image
	/// </summary>
	public virtual void SetOutputDimensions(IntPtr _arg)
	{
		vtkFastSplatter_SetOutputDimensions_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFastSplatter_SetSplatConnection_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Convenience function for connecting the splat algorithm source.
	/// This is provided mainly for convenience using the filter with
	/// ParaView, VTK users should prefer SetInputConnection(1, splat) instead.
	/// </summary>
	public void SetSplatConnection(vtkAlgorithmOutput arg0)
	{
		vtkFastSplatter_SetSplatConnection_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
