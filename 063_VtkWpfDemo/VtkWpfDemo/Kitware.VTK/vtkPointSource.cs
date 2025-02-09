using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointSource
/// </summary>
/// <remarks>
///    create a random cloud of points
///
/// vtkPointSource is a source object that creates a user-specified number of
/// points within a specified radius about a specified center point.  By
/// default the location of the points is random within the sphere. It is also
/// possible to generate random points only on the surface of the sphere; or a
/// exponential distribution weighted towards the center point. The output
/// PolyData has the specified number of points and a single cell - a
/// vtkPolyVertex cell referencing all of the points.
///
/// @note
/// If Lambda set to zero, a uniform distribution is used. Negative lambda
/// values are allowed, but the distribution function becomes inverted.
///
/// @note
/// If you desire to create complex point clouds (e.g., stellar distributions)
/// then use multiple point sources and then append them together using the
/// an append filter (e.g., vtkAppendPolyData).
///
/// </remarks>
/// <seealso>
///
/// vtkAppendPolyData
/// </seealso>
public class vtkPointSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointSource()
	{
		MRClassNameKey = "class vtkPointSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkPointSource New()
	{
		vtkPointSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkPointSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSource_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Set the center of the point cloud.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkPointSource_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_GetCenter_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the point cloud.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkPointSource_GetCenter_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSource_GetDistribution_03(HandleRef pThis);

	/// <summary>
	/// Specify the point distribution to use.  The default is a uniform
	/// distribution.  The shell distribution produces random points on the
	/// surface of the sphere Radius=constant, no points in the interior.  The
	/// exponential distribution creates more points towards the center point
	/// weighted by the exponential function.
	/// </summary>
	public virtual int GetDistribution()
	{
		return vtkPointSource_GetDistribution_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSource_GetDistributionMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify the point distribution to use.  The default is a uniform
	/// distribution.  The shell distribution produces random points on the
	/// surface of the sphere Radius=constant, no points in the interior.  The
	/// exponential distribution creates more points towards the center point
	/// weighted by the exponential function.
	/// </summary>
	public virtual int GetDistributionMaxValue()
	{
		return vtkPointSource_GetDistributionMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSource_GetDistributionMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify the point distribution to use.  The default is a uniform
	/// distribution.  The shell distribution produces random points on the
	/// surface of the sphere Radius=constant, no points in the interior.  The
	/// exponential distribution creates more points towards the center point
	/// weighted by the exponential function.
	/// </summary>
	public virtual int GetDistributionMinValue()
	{
		return vtkPointSource_GetDistributionMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSource_GetLambda_06(HandleRef pThis);

	/// <summary>
	/// If the distribution is set to exponential, then Lambda is used to
	/// scale the exponential distribution defined by
	/// f(x) = Lambda*exp(-Lambda*radius) where the radius is the distance
	/// from the Center of the point source. By default, the value of Lambda
	/// is Lambda=1.0.
	/// </summary>
	public virtual double GetLambda()
	{
		return vtkPointSource_GetLambda_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSource_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointSource_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSource_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointSource_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSource_GetNumberOfPoints_09(HandleRef pThis);

	/// <summary>
	/// Set the number of points to generate.
	/// </summary>
	public virtual long GetNumberOfPoints()
	{
		return vtkPointSource_GetNumberOfPoints_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSource_GetNumberOfPointsMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set the number of points to generate.
	/// </summary>
	public virtual long GetNumberOfPointsMaxValue()
	{
		return vtkPointSource_GetNumberOfPointsMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSource_GetNumberOfPointsMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set the number of points to generate.
	/// </summary>
	public virtual long GetNumberOfPointsMinValue()
	{
		return vtkPointSource_GetNumberOfPointsMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSource_GetOutputPointsPrecision_12(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkPointSource_GetOutputPointsPrecision_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSource_GetRadius_13(HandleRef pThis);

	/// <summary>
	/// Set the radius of the point cloud.  If you are
	/// generating a Gaussian distribution, then this is
	/// the standard deviation for each of x, y, and z.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkPointSource_GetRadius_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSource_GetRadiusMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set the radius of the point cloud.  If you are
	/// generating a Gaussian distribution, then this is
	/// the standard deviation for each of x, y, and z.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkPointSource_GetRadiusMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSource_GetRadiusMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set the radius of the point cloud.  If you are
	/// generating a Gaussian distribution, then this is
	/// the standard deviation for each of x, y, and z.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkPointSource_GetRadiusMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSource_GetRandomSequence_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get a random sequence generator.
	/// By default, the generator in vtkMath is used to maintain backwards
	/// compatibility.
	/// </summary>
	public virtual vtkRandomSequence GetRandomSequence()
	{
		vtkRandomSequence vtkRandomSequence2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSource_GetRandomSequence_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRandomSequence2 = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRandomSequence2.Register(null);
			}
		}
		return vtkRandomSequence2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSource_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointSource_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSource_IsTypeOf_18(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointSource_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSource_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkPointSource NewInstance()
	{
		vtkPointSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSource_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSource_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkPointSource SafeDownCast(vtkObjectBase o)
	{
		vtkPointSource vtkPointSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSource_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSource2 = (vtkPointSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSource2.Register(null);
			}
		}
		return vtkPointSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetCenter_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the point cloud.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkPointSource_SetCenter_22(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetCenter_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the point cloud.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkPointSource_SetCenter_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetDistribution_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the point distribution to use.  The default is a uniform
	/// distribution.  The shell distribution produces random points on the
	/// surface of the sphere Radius=constant, no points in the interior.  The
	/// exponential distribution creates more points towards the center point
	/// weighted by the exponential function.
	/// </summary>
	public virtual void SetDistribution(int _arg)
	{
		vtkPointSource_SetDistribution_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetDistributionToExponential_25(HandleRef pThis);

	/// <summary>
	/// Specify the point distribution to use.  The default is a uniform
	/// distribution.  The shell distribution produces random points on the
	/// surface of the sphere Radius=constant, no points in the interior.  The
	/// exponential distribution creates more points towards the center point
	/// weighted by the exponential function.
	/// </summary>
	public void SetDistributionToExponential()
	{
		vtkPointSource_SetDistributionToExponential_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetDistributionToShell_26(HandleRef pThis);

	/// <summary>
	/// Specify the point distribution to use.  The default is a uniform
	/// distribution.  The shell distribution produces random points on the
	/// surface of the sphere Radius=constant, no points in the interior.  The
	/// exponential distribution creates more points towards the center point
	/// weighted by the exponential function.
	/// </summary>
	public void SetDistributionToShell()
	{
		vtkPointSource_SetDistributionToShell_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetDistributionToUniform_27(HandleRef pThis);

	/// <summary>
	/// Specify the point distribution to use.  The default is a uniform
	/// distribution.  The shell distribution produces random points on the
	/// surface of the sphere Radius=constant, no points in the interior.  The
	/// exponential distribution creates more points towards the center point
	/// weighted by the exponential function.
	/// </summary>
	public void SetDistributionToUniform()
	{
		vtkPointSource_SetDistributionToUniform_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetLambda_28(HandleRef pThis, double _arg);

	/// <summary>
	/// If the distribution is set to exponential, then Lambda is used to
	/// scale the exponential distribution defined by
	/// f(x) = Lambda*exp(-Lambda*radius) where the radius is the distance
	/// from the Center of the point source. By default, the value of Lambda
	/// is Lambda=1.0.
	/// </summary>
	public virtual void SetLambda(double _arg)
	{
		vtkPointSource_SetLambda_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetNumberOfPoints_29(HandleRef pThis, long _arg);

	/// <summary>
	/// Set the number of points to generate.
	/// </summary>
	public virtual void SetNumberOfPoints(long _arg)
	{
		vtkPointSource_SetNumberOfPoints_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkPointSource_SetOutputPointsPrecision_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetRadius_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the radius of the point cloud.  If you are
	/// generating a Gaussian distribution, then this is
	/// the standard deviation for each of x, y, and z.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkPointSource_SetRadius_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSource_SetRandomSequence_32(HandleRef pThis, HandleRef randomSequence);

	/// <summary>
	/// Set/Get a random sequence generator.
	/// By default, the generator in vtkMath is used to maintain backwards
	/// compatibility.
	/// </summary>
	public virtual void SetRandomSequence(vtkRandomSequence randomSequence)
	{
		vtkPointSource_SetRandomSequence_32(GetCppThis(), randomSequence?.GetCppThis() ?? default(HandleRef));
	}
}
