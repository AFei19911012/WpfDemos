using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkShepardMethod
/// </summary>
/// <remarks>
///    interpolate points and associated scalars onto volume
/// using the method of Shepard
///
///
/// vtkShepardMethod is a filter used to interpolate point scalar values using
/// Shepard's method. The method works by resampling the scalars associated
/// with points defined on an arbitrary dataset onto a volume (i.e.,
/// structured points) dataset. The influence functions are described as
/// "inverse distance weighted". Once the interpolation is performed across
/// the volume, the usual volume visualization techniques (e.g.,
/// iso-contouring or volume rendering) can be used.
///
/// Note that this implementation also provides the ability to specify the
/// power parameter p. Given the generalized Inverse Distance Weighting (IDW)
/// function with distance between points measured as d(x,xi), p is defined
/// as:
/// &lt;pre&gt;
/// u(x) = Sum(wi(x) * ui) / Sum(wi(x)) if d(x,xi) != 0
/// u(x) = ui                           if d(x,xi) == 0
///
/// where wi(x) = 1 / (d(x,xi)^p
/// &lt;/pre&gt;
/// Typically p=2, so the weights wi(x) are the inverse of the distance
/// squared. However, power parameters &gt; 2 can be used which assign higher
/// weights for data closer to the interpolated point; or &lt;2 which assigns
/// greater weight to points further away. (Note that if p!=2, performance may
/// be significantly impacted as the algorithm is tuned for p=2.)
///
/// @warning
/// Strictly speaking, this is a modified Shepard's methodsince only points
/// within the MaxiumDistance are used for interpolation. By setting the
/// maximum distance to include the entire bounding box and therefore all
/// points, the class executes much slower but incorporates all points into
/// the interpolation process (i.e., a pure Shepard method).
///
/// @warning
/// The input to this filter is any dataset type. This filter can be used to
/// resample the points of any type of dataset onto the output volume; i.e.,
/// the input data need not be unstructured with explicit point
/// representations.
///
/// @warning
/// The bounds of the data (i.e., the sample space) is automatically computed
/// if not set by the user.
///
/// @warning
/// If you use a maximum distance less than 1.0 (i.e., using a modified
/// Shephard's method), some output points may never receive a
/// contribution. The final value of these points can be specified with the
/// "NullValue" instance variable.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkGaussianSplatter vtkCheckerboardSplatter
/// </seealso>
public class vtkShepardMethod : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkShepardMethod";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkShepardMethod()
	{
		MRClassNameKey = "class vtkShepardMethod";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkShepardMethod"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkShepardMethod(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShepardMethod_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with sample dimensions=(50,50,50) and so that model bounds are
	/// automatically computed from the input. The null value for each unvisited
	/// output point is 0.0. Maximum distance is 0.25. Power parameter p=2.
	/// </summary>
	public new static vtkShepardMethod New()
	{
		vtkShepardMethod result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShepardMethod_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with sample dimensions=(50,50,50) and so that model bounds are
	/// automatically computed from the input. The null value for each unvisited
	/// output point is 0.0. Maximum distance is 0.25. Power parameter p=2.
	/// </summary>
	public vtkShepardMethod()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkShepardMethod_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkShepardMethod_ComputeModelBounds_01(HandleRef pThis, IntPtr origin, IntPtr spacing);

	/// <summary>
	/// Compute ModelBounds from the input geometry.
	/// </summary>
	public double ComputeModelBounds(IntPtr origin, IntPtr spacing)
	{
		return vtkShepardMethod_ComputeModelBounds_01(GetCppThis(), origin, spacing);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardMethod_GetMaximumDistance_02(HandleRef pThis);

	/// <summary>
	/// Specify the maximum influence distance of each input point. This
	/// distance is a fraction of the length of the diagonal of the sample
	/// space. Thus, values of 1.0 will cause each input point to influence all
	/// points in the volume dataset. Values less than 1.0 can improve
	/// performance significantly. By default the maximum distance is 0.25.
	/// </summary>
	public virtual double GetMaximumDistance()
	{
		return vtkShepardMethod_GetMaximumDistance_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardMethod_GetMaximumDistanceMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Specify the maximum influence distance of each input point. This
	/// distance is a fraction of the length of the diagonal of the sample
	/// space. Thus, values of 1.0 will cause each input point to influence all
	/// points in the volume dataset. Values less than 1.0 can improve
	/// performance significantly. By default the maximum distance is 0.25.
	/// </summary>
	public virtual double GetMaximumDistanceMaxValue()
	{
		return vtkShepardMethod_GetMaximumDistanceMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardMethod_GetMaximumDistanceMinValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the maximum influence distance of each input point. This
	/// distance is a fraction of the length of the diagonal of the sample
	/// space. Thus, values of 1.0 will cause each input point to influence all
	/// points in the volume dataset. Values less than 1.0 can improve
	/// performance significantly. By default the maximum distance is 0.25.
	/// </summary>
	public virtual double GetMaximumDistanceMinValue()
	{
		return vtkShepardMethod_GetMaximumDistanceMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShepardMethod_GetModelBounds_05(HandleRef pThis);

	/// <summary>
	/// Specify the position in space to perform the sampling. The ModelBounds
	/// and SampleDimensions together define the output volume. (Note: if the
	/// ModelBounds are set to an invalid state [zero or negative volume] then
	/// the bounds are computed automatically.)
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkShepardMethod_GetModelBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_GetModelBounds_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the position in space to perform the sampling. The ModelBounds
	/// and SampleDimensions together define the output volume. (Note: if the
	/// ModelBounds are set to an invalid state [zero or negative volume] then
	/// the bounds are computed automatically.)
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkShepardMethod_GetModelBounds_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardMethod_GetNullValue_07(HandleRef pThis);

	/// <summary>
	/// Set the value for output points not receiving a contribution from any
	/// input point(s). Output points may not receive a contribution when the
	/// MaximumDistance &lt; 1.
	/// </summary>
	public virtual double GetNullValue()
	{
		return vtkShepardMethod_GetNullValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShepardMethod_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkShepardMethod_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShepardMethod_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkShepardMethod_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardMethod_GetPowerParameter_10(HandleRef pThis);

	/// <summary>
	/// Set / Get the power parameter p. By default p=2. Values (which must be
	/// a positive, real value) != 2 may affect performance significantly.
	/// </summary>
	public virtual double GetPowerParameter()
	{
		return vtkShepardMethod_GetPowerParameter_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardMethod_GetPowerParameterMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set / Get the power parameter p. By default p=2. Values (which must be
	/// a positive, real value) != 2 may affect performance significantly.
	/// </summary>
	public virtual double GetPowerParameterMaxValue()
	{
		return vtkShepardMethod_GetPowerParameterMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardMethod_GetPowerParameterMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set / Get the power parameter p. By default p=2. Values (which must be
	/// a positive, real value) != 2 may affect performance significantly.
	/// </summary>
	public virtual double GetPowerParameterMinValue()
	{
		return vtkShepardMethod_GetPowerParameterMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShepardMethod_GetSampleDimensions_13(HandleRef pThis);

	/// <summary>
	/// Retrieve the i-j-k dimensions on which to interpolate the input points.
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkShepardMethod_GetSampleDimensions_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_GetSampleDimensions_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Retrieve the i-j-k dimensions on which to interpolate the input points.
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkShepardMethod_GetSampleDimensions_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShepardMethod_IsA_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkShepardMethod_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShepardMethod_IsTypeOf_16(string type);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkShepardMethod_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShepardMethod_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new vtkShepardMethod NewInstance()
	{
		vtkShepardMethod result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShepardMethod_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShepardMethod_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard type and print methods.
	/// </summary>
	public new static vtkShepardMethod SafeDownCast(vtkObjectBase o)
	{
		vtkShepardMethod vtkShepardMethod2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShepardMethod_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShepardMethod2 = (vtkShepardMethod)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShepardMethod2.Register(null);
			}
		}
		return vtkShepardMethod2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_SetMaximumDistance_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the maximum influence distance of each input point. This
	/// distance is a fraction of the length of the diagonal of the sample
	/// space. Thus, values of 1.0 will cause each input point to influence all
	/// points in the volume dataset. Values less than 1.0 can improve
	/// performance significantly. By default the maximum distance is 0.25.
	/// </summary>
	public virtual void SetMaximumDistance(double _arg)
	{
		vtkShepardMethod_SetMaximumDistance_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_SetModelBounds_21(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Specify the position in space to perform the sampling. The ModelBounds
	/// and SampleDimensions together define the output volume. (Note: if the
	/// ModelBounds are set to an invalid state [zero or negative volume] then
	/// the bounds are computed automatically.)
	/// </summary>
	public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkShepardMethod_SetModelBounds_21(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_SetModelBounds_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the position in space to perform the sampling. The ModelBounds
	/// and SampleDimensions together define the output volume. (Note: if the
	/// ModelBounds are set to an invalid state [zero or negative volume] then
	/// the bounds are computed automatically.)
	/// </summary>
	public virtual void SetModelBounds(IntPtr _arg)
	{
		vtkShepardMethod_SetModelBounds_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_SetNullValue_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the value for output points not receiving a contribution from any
	/// input point(s). Output points may not receive a contribution when the
	/// MaximumDistance &lt; 1.
	/// </summary>
	public virtual void SetNullValue(double _arg)
	{
		vtkShepardMethod_SetNullValue_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_SetPowerParameter_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / Get the power parameter p. By default p=2. Values (which must be
	/// a positive, real value) != 2 may affect performance significantly.
	/// </summary>
	public virtual void SetPowerParameter(double _arg)
	{
		vtkShepardMethod_SetPowerParameter_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_SetSampleDimensions_25(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set the i-j-k dimensions on which to interpolate the input points.
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkShepardMethod_SetSampleDimensions_25(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardMethod_SetSampleDimensions_26(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set the i-j-k dimensions on which to sample the input points.
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkShepardMethod_SetSampleDimensions_26(GetCppThis(), dim);
	}
}
