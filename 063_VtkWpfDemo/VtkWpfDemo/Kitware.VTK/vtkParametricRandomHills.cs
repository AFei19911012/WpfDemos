using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParametricRandomHills
/// </summary>
/// <remarks>
///    Generate a surface covered with randomly placed hills.
///
/// vtkParametricRandomHills generates a surface covered with randomly placed
/// hills. Hills will vary in shape and height since the presence
/// of nearby hills will contribute to the shape and height of a given hill.
/// An option is provided for placing hills on a regular grid on the surface.
/// In this case the hills will all have the same shape and height.
///
/// For further information about this surface, please consult the
/// technical description "Parametric surfaces" in http://www.vtk.org/publications
/// in the "VTK Technical Documents" section in the VTk.org web pages.
///
/// @par Thanks:
/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing the
/// class.
///
/// </remarks>
public class vtkParametricRandomHills : vtkParametricFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParametricRandomHills";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParametricRandomHills()
	{
		MRClassNameKey = "class vtkParametricRandomHills";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricRandomHills"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParametricRandomHills(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricRandomHills_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a surface of random hills with the following parameters:
	/// MinimumU = -10, MaximumU = 10,
	/// MinimumV = -10, MaximumV = 10,
	/// JoinU = 0, JoinV = 0,
	/// TwistU = 0, TwistV = 0;
	/// ClockwiseOrdering = 0,
	/// DerivativesAvailable = 0,
	/// Number of hills = 30,
	/// Variance of the hills 2.5 in both x- and y- directions,
	/// Scaling factor for the variances 1/3 in both x- and y- directions,
	/// Amplitude of each hill = 2,
	/// Scaling factor for the amplitude = 1/3,
	/// RandomSeed = 1,
	/// AllowRandomGeneration = 1.
	/// </summary>
	public new static vtkParametricRandomHills New()
	{
		vtkParametricRandomHills result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricRandomHills_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a surface of random hills with the following parameters:
	/// MinimumU = -10, MaximumU = 10,
	/// MinimumV = -10, MaximumV = 10,
	/// JoinU = 0, JoinV = 0,
	/// TwistU = 0, TwistV = 0;
	/// ClockwiseOrdering = 0,
	/// DerivativesAvailable = 0,
	/// Number of hills = 30,
	/// Variance of the hills 2.5 in both x- and y- directions,
	/// Scaling factor for the variances 1/3 in both x- and y- directions,
	/// Amplitude of each hill = 2,
	/// Scaling factor for the amplitude = 1/3,
	/// RandomSeed = 1,
	/// AllowRandomGeneration = 1.
	/// </summary>
	public vtkParametricRandomHills()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParametricRandomHills_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_AllowRandomGenerationOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the random generation flag.
	/// A value of 0 will disable the generation of random hills on the surface
	/// allowing a reproducible number of identically shaped hills to be
	/// generated. If zero, then the number of hills used will be the nearest
	/// perfect square less than or equal to the number of hills.
	/// For example, selecting 30 hills will result in a 5 X 5 array of
	/// hills being generated. Thus a square array of hills will be generated.
	///
	/// Any other value means that the hills will be placed randomly on the
	/// surface.
	/// Default is 1.
	/// </summary>
	public virtual void AllowRandomGenerationOff()
	{
		vtkParametricRandomHills_AllowRandomGenerationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_AllowRandomGenerationOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the random generation flag.
	/// A value of 0 will disable the generation of random hills on the surface
	/// allowing a reproducible number of identically shaped hills to be
	/// generated. If zero, then the number of hills used will be the nearest
	/// perfect square less than or equal to the number of hills.
	/// For example, selecting 30 hills will result in a 5 X 5 array of
	/// hills being generated. Thus a square array of hills will be generated.
	///
	/// Any other value means that the hills will be placed randomly on the
	/// surface.
	/// Default is 1.
	/// </summary>
	public virtual void AllowRandomGenerationOn()
	{
		vtkParametricRandomHills_AllowRandomGenerationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_Evaluate_03(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// Construct a terrain consisting of hills on a surface.
	///
	/// This function performs the mapping \f$f(u,v) \rightarrow (x,y,x)\f$, returning it
	/// as Pt. It also returns the partial derivatives Du and Dv.
	/// \f$Pt = (x, y, z), Du = (dx/du, dy/du, dz/du), Dv = (dx/dv, dy/dv, dz/dv)\f$ .
	/// Then the normal is \f$N = Du X Dv\f$ .
	/// </summary>
	public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		vtkParametricRandomHills_Evaluate_03(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricRandomHills_EvaluateScalar_04(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

	/// <summary>
	/// Calculate a user defined scalar using one or all of uvw, Pt, Duvw.
	///
	/// uvw are the parameters with Pt being the Cartesian point,
	/// Duvw are the derivatives of this point with respect to u, v and w.
	/// Pt, Duvw are obtained from Evaluate().
	///
	/// This function is only called if the ScalarMode has the value
	/// vtkParametricFunctionSource::SCALAR_FUNCTION_DEFINED
	///
	/// If the user does not need to calculate a scalar, then the
	/// instantiated function should return zero.
	/// </summary>
	public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
	{
		return vtkParametricRandomHills_EvaluateScalar_04(GetCppThis(), uvw, Pt, Duvw);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricRandomHills_GetAllowRandomGeneration_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the random generation flag.
	/// A value of 0 will disable the generation of random hills on the surface
	/// allowing a reproducible number of identically shaped hills to be
	/// generated. If zero, then the number of hills used will be the nearest
	/// perfect square less than or equal to the number of hills.
	/// For example, selecting 30 hills will result in a 5 X 5 array of
	/// hills being generated. Thus a square array of hills will be generated.
	///
	/// Any other value means that the hills will be placed randomly on the
	/// surface.
	/// Default is 1.
	/// </summary>
	public virtual int GetAllowRandomGeneration()
	{
		return vtkParametricRandomHills_GetAllowRandomGeneration_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricRandomHills_GetAllowRandomGenerationMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the random generation flag.
	/// A value of 0 will disable the generation of random hills on the surface
	/// allowing a reproducible number of identically shaped hills to be
	/// generated. If zero, then the number of hills used will be the nearest
	/// perfect square less than or equal to the number of hills.
	/// For example, selecting 30 hills will result in a 5 X 5 array of
	/// hills being generated. Thus a square array of hills will be generated.
	///
	/// Any other value means that the hills will be placed randomly on the
	/// surface.
	/// Default is 1.
	/// </summary>
	public virtual int GetAllowRandomGenerationMaxValue()
	{
		return vtkParametricRandomHills_GetAllowRandomGenerationMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricRandomHills_GetAllowRandomGenerationMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the random generation flag.
	/// A value of 0 will disable the generation of random hills on the surface
	/// allowing a reproducible number of identically shaped hills to be
	/// generated. If zero, then the number of hills used will be the nearest
	/// perfect square less than or equal to the number of hills.
	/// For example, selecting 30 hills will result in a 5 X 5 array of
	/// hills being generated. Thus a square array of hills will be generated.
	///
	/// Any other value means that the hills will be placed randomly on the
	/// surface.
	/// Default is 1.
	/// </summary>
	public virtual int GetAllowRandomGenerationMinValue()
	{
		return vtkParametricRandomHills_GetAllowRandomGenerationMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricRandomHills_GetAmplitudeScaleFactor_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the amplitude.
	/// Default is 1/3.
	/// </summary>
	public virtual double GetAmplitudeScaleFactor()
	{
		return vtkParametricRandomHills_GetAmplitudeScaleFactor_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricRandomHills_GetDimension_09(HandleRef pThis);

	/// <summary>
	/// Return the parametric dimension of the class.
	/// </summary>
	public override int GetDimension()
	{
		return vtkParametricRandomHills_GetDimension_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricRandomHills_GetHillAmplitude_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the hill amplitude (height).
	/// Default is 2.
	/// </summary>
	public virtual double GetHillAmplitude()
	{
		return vtkParametricRandomHills_GetHillAmplitude_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricRandomHills_GetHillXVariance_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the hill variance in the x-direction.
	/// Default is 2.5.
	/// </summary>
	public virtual double GetHillXVariance()
	{
		return vtkParametricRandomHills_GetHillXVariance_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricRandomHills_GetHillYVariance_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the hill variance in the y-direction.
	/// Default is 2.5.
	/// </summary>
	public virtual double GetHillYVariance()
	{
		return vtkParametricRandomHills_GetHillYVariance_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricRandomHills_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParametricRandomHills_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricRandomHills_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParametricRandomHills_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricRandomHills_GetNumberOfHills_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of hills.
	/// Default is 30.
	/// </summary>
	public virtual int GetNumberOfHills()
	{
		return vtkParametricRandomHills_GetNumberOfHills_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricRandomHills_GetRandomSeed_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the Seed for the random number generator,
	/// a value of 1 will initialize the random number generator,
	/// a negative value will initialize it with the system time.
	/// Default is 1.
	/// </summary>
	public virtual int GetRandomSeed()
	{
		return vtkParametricRandomHills_GetRandomSeed_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricRandomHills_GetXVarianceScaleFactor_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the variance in the x-direction.
	/// Default is 1/3.
	/// </summary>
	public virtual double GetXVarianceScaleFactor()
	{
		return vtkParametricRandomHills_GetXVarianceScaleFactor_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkParametricRandomHills_GetYVarianceScaleFactor_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the scaling factor for the variance in the y-direction.
	/// Default is 1/3.
	/// </summary>
	public virtual double GetYVarianceScaleFactor()
	{
		return vtkParametricRandomHills_GetYVarianceScaleFactor_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricRandomHills_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParametricRandomHills_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricRandomHills_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParametricRandomHills_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricRandomHills_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParametricRandomHills NewInstance()
	{
		vtkParametricRandomHills result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricRandomHills_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricRandomHills_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParametricRandomHills SafeDownCast(vtkObjectBase o)
	{
		vtkParametricRandomHills vtkParametricRandomHills2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricRandomHills_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricRandomHills2 = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricRandomHills2.Register(null);
			}
		}
		return vtkParametricRandomHills2;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetAllowRandomGeneration_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the random generation flag.
	/// A value of 0 will disable the generation of random hills on the surface
	/// allowing a reproducible number of identically shaped hills to be
	/// generated. If zero, then the number of hills used will be the nearest
	/// perfect square less than or equal to the number of hills.
	/// For example, selecting 30 hills will result in a 5 X 5 array of
	/// hills being generated. Thus a square array of hills will be generated.
	///
	/// Any other value means that the hills will be placed randomly on the
	/// surface.
	/// Default is 1.
	/// </summary>
	public virtual void SetAllowRandomGeneration(int _arg)
	{
		vtkParametricRandomHills_SetAllowRandomGeneration_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetAmplitudeScaleFactor_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the amplitude.
	/// Default is 1/3.
	/// </summary>
	public virtual void SetAmplitudeScaleFactor(double _arg)
	{
		vtkParametricRandomHills_SetAmplitudeScaleFactor_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetHillAmplitude_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the hill amplitude (height).
	/// Default is 2.
	/// </summary>
	public virtual void SetHillAmplitude(double _arg)
	{
		vtkParametricRandomHills_SetHillAmplitude_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetHillXVariance_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the hill variance in the x-direction.
	/// Default is 2.5.
	/// </summary>
	public virtual void SetHillXVariance(double _arg)
	{
		vtkParametricRandomHills_SetHillXVariance_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetHillYVariance_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the hill variance in the y-direction.
	/// Default is 2.5.
	/// </summary>
	public virtual void SetHillYVariance(double _arg)
	{
		vtkParametricRandomHills_SetHillYVariance_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetNumberOfHills_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of hills.
	/// Default is 30.
	/// </summary>
	public virtual void SetNumberOfHills(int _arg)
	{
		vtkParametricRandomHills_SetNumberOfHills_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetRandomSeed_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the Seed for the random number generator,
	/// a value of 1 will initialize the random number generator,
	/// a negative value will initialize it with the system time.
	/// Default is 1.
	/// </summary>
	public virtual void SetRandomSeed(int _arg)
	{
		vtkParametricRandomHills_SetRandomSeed_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetXVarianceScaleFactor_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the variance in the x-direction.
	/// Default is 1/3.
	/// </summary>
	public virtual void SetXVarianceScaleFactor(double _arg)
	{
		vtkParametricRandomHills_SetXVarianceScaleFactor_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricRandomHills_SetYVarianceScaleFactor_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scaling factor for the variance in the y-direction.
	/// Default is 1/3.
	/// </summary>
	public virtual void SetYVarianceScaleFactor(double _arg)
	{
		vtkParametricRandomHills_SetYVarianceScaleFactor_32(GetCppThis(), _arg);
	}
}
