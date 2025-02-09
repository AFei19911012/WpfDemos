using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEllipsoidalGaussianKernel
/// </summary>
/// <remarks>
///    an ellipsoidal Gaussian interpolation kernel
///
///
/// vtkEllipsoidalGaussianKernel is an interpolation kernel that returns the
/// weights for all points found in the ellipsoid defined by radius R in
/// combination with local data (normals and/or scalars). For example, "pancake"
/// weightings (the local normal parallel to the minimum ellisoidal axis); or
/// "needle" weightings (the local normal parallel to the maximum ellipsoidal
/// axis) are possible. (Note that spherical Gaussian weightings are more
/// efficiently computed using vtkGaussianKernel.)
///
/// The ellipsoidal Gaussian can be described by:
///
///     W(x) = S * exp( -( Sharpness^2 * ((rxy/E)**2 + z**2)/R**2) )
///
/// where S is the local scalar value; E is a user-defined eccentricity factor
/// that controls the elliptical shape of the splat; z is the distance of the
/// current voxel sample point along the local normal N; and rxy is the
/// distance to neighbor point x in the direction prependicular to N.
///
/// @warning
/// The weights are normalized so that SUM(Wi) = 1. If a neighbor point p
/// precisely lies on the point to be interpolated, then the interpolated
/// point takes on the values associated with p.
///
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator vtkInterpolationKernel vtkGeneralizedKernel
/// vtkGaussianKernel vtkVoronoiKernel vtkSPHKernel vtkShepardKernel
/// </seealso>
public class vtkEllipsoidalGaussianKernel : vtkGeneralizedKernel
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEllipsoidalGaussianKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEllipsoidalGaussianKernel()
	{
		MRClassNameKey = "class vtkEllipsoidalGaussianKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipsoidalGaussianKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEllipsoidalGaussianKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipsoidalGaussianKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkEllipsoidalGaussianKernel New()
	{
		vtkEllipsoidalGaussianKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipsoidalGaussianKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEllipsoidalGaussianKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkEllipsoidalGaussianKernel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEllipsoidalGaussianKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkEllipsoidalGaussianKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

	/// <summary>
	/// Given a point x, a list of basis points pIds, and a probability
	/// weighting function prob, compute interpolation weights associated with
	/// these basis points.  Note that basis points list pIds, the probability
	/// weighting prob, and the weights array are provided by the caller of the
	/// method, and may be dynamically resized as necessary. The method returns
	/// the number of weights (pIds may be resized in some cases). Typically
	/// this method is called after ComputeBasis(), although advanced users can
	/// invoke ComputeWeights() and provide the interpolation basis points pIds
	/// directly. The probably weighting prob are numbers 0&lt;=prob&lt;=1 which are
	/// multiplied against the interpolation weights before normalization. They
	/// are estimates of local confidence of weights. The prob may be nullptr in
	/// which all probabilities are considered =1.
	/// </summary>
	public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
	{
		return vtkEllipsoidalGaussianKernel_ComputeWeights_01(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), prob?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetEccentricity_02(HandleRef pThis);

	/// <summary>
	/// Set / Get the eccentricity of the ellipsoidal Gaussian. A value=1.0
	/// produces a spherical distribution. Values &lt; 1 produce a needle like
	/// distribution (in the direction of the normal); values &gt; 1 produce a
	/// pancake like distribution (orthogonal to the normal).
	/// </summary>
	public virtual double GetEccentricity()
	{
		return vtkEllipsoidalGaussianKernel_GetEccentricity_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetEccentricityMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set / Get the eccentricity of the ellipsoidal Gaussian. A value=1.0
	/// produces a spherical distribution. Values &lt; 1 produce a needle like
	/// distribution (in the direction of the normal); values &gt; 1 produce a
	/// pancake like distribution (orthogonal to the normal).
	/// </summary>
	public virtual double GetEccentricityMaxValue()
	{
		return vtkEllipsoidalGaussianKernel_GetEccentricityMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetEccentricityMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set / Get the eccentricity of the ellipsoidal Gaussian. A value=1.0
	/// produces a spherical distribution. Values &lt; 1 produce a needle like
	/// distribution (in the direction of the normal); values &gt; 1 produce a
	/// pancake like distribution (orthogonal to the normal).
	/// </summary>
	public virtual double GetEccentricityMinValue()
	{
		return vtkEllipsoidalGaussianKernel_GetEccentricityMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkEllipsoidalGaussianKernel_GetNormalsArrayName_05(HandleRef pThis);

	/// <summary>
	/// Specify the normals array name. Used to orient the ellipsoid. Note that
	/// by default the input normals are used (i.e. the input to
	/// vtkPointInterpolator). If no input normals are available, then the named
	/// NormalsArrayName is used.
	/// </summary>
	public virtual string GetNormalsArrayName()
	{
		return vtkEllipsoidalGaussianKernel_GetNormalsArrayName_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEllipsoidalGaussianKernel_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEllipsoidalGaussianKernel_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEllipsoidalGaussianKernel_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEllipsoidalGaussianKernel_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkEllipsoidalGaussianKernel_GetScalarsArrayName_08(HandleRef pThis);

	/// <summary>
	/// Specify the scalars array name. Used to scale the ellipsoid. Note that
	/// by default the input scalars are used (i.e. the input to
	/// vtkPointInterpolator). If no input scalars are available, then the named
	/// ScalarsArrayName is used.
	/// </summary>
	public virtual string GetScalarsArrayName()
	{
		return vtkEllipsoidalGaussianKernel_GetScalarsArrayName_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetScaleFactor_09(HandleRef pThis);

	/// <summary>
	/// Multiply the Gaussian splat distribution by this value. If UseScalars is
	/// on and a scalar array is provided, then the scalar value will be
	/// multiplied by the ScaleFactor times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkEllipsoidalGaussianKernel_GetScaleFactor_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetScaleFactorMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Multiply the Gaussian splat distribution by this value. If UseScalars is
	/// on and a scalar array is provided, then the scalar value will be
	/// multiplied by the ScaleFactor times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactorMaxValue()
	{
		return vtkEllipsoidalGaussianKernel_GetScaleFactorMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetScaleFactorMinValue_11(HandleRef pThis);

	/// <summary>
	/// Multiply the Gaussian splat distribution by this value. If UseScalars is
	/// on and a scalar array is provided, then the scalar value will be
	/// multiplied by the ScaleFactor times the Gaussian function.
	/// </summary>
	public virtual double GetScaleFactorMinValue()
	{
		return vtkEllipsoidalGaussianKernel_GetScaleFactorMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetSharpness_12(HandleRef pThis);

	/// <summary>
	/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
	/// Sharpness=2. As the sharpness increases the effects of distant points
	/// are reduced.
	/// </summary>
	public virtual double GetSharpness()
	{
		return vtkEllipsoidalGaussianKernel_GetSharpness_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetSharpnessMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
	/// Sharpness=2. As the sharpness increases the effects of distant points
	/// are reduced.
	/// </summary>
	public virtual double GetSharpnessMaxValue()
	{
		return vtkEllipsoidalGaussianKernel_GetSharpnessMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipsoidalGaussianKernel_GetSharpnessMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
	/// Sharpness=2. As the sharpness increases the effects of distant points
	/// are reduced.
	/// </summary>
	public virtual double GetSharpnessMinValue()
	{
		return vtkEllipsoidalGaussianKernel_GetSharpnessMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEllipsoidalGaussianKernel_GetUseNormals_15(HandleRef pThis);

	/// <summary>
	/// Specify whether vector values should be used to affect the shape
	/// of the Gaussian distribution. By default this is on.
	/// </summary>
	public virtual bool GetUseNormals()
	{
		return (vtkEllipsoidalGaussianKernel_GetUseNormals_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkEllipsoidalGaussianKernel_GetUseScalars_16(HandleRef pThis);

	/// <summary>
	/// Specify whether scalar values should be used to scale the weights.
	/// By default this is off.
	/// </summary>
	public virtual bool GetUseScalars()
	{
		return (vtkEllipsoidalGaussianKernel_GetUseScalars_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_Initialize_17(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

	/// <summary>
	/// Initialize the kernel. Overload the superclass to set up scalars and
	/// vectors.
	/// </summary>
	public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
	{
		vtkEllipsoidalGaussianKernel_Initialize_17(GetCppThis(), loc?.GetCppThis() ?? default(HandleRef), ds?.GetCppThis() ?? default(HandleRef), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipsoidalGaussianKernel_IsA_18(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEllipsoidalGaussianKernel_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipsoidalGaussianKernel_IsTypeOf_19(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEllipsoidalGaussianKernel_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipsoidalGaussianKernel_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkEllipsoidalGaussianKernel NewInstance()
	{
		vtkEllipsoidalGaussianKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipsoidalGaussianKernel_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEllipsoidalGaussianKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipsoidalGaussianKernel_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkEllipsoidalGaussianKernel SafeDownCast(vtkObjectBase o)
	{
		vtkEllipsoidalGaussianKernel vtkEllipsoidalGaussianKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipsoidalGaussianKernel_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEllipsoidalGaussianKernel2 = (vtkEllipsoidalGaussianKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEllipsoidalGaussianKernel2.Register(null);
			}
		}
		return vtkEllipsoidalGaussianKernel2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_SetEccentricity_23(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / Get the eccentricity of the ellipsoidal Gaussian. A value=1.0
	/// produces a spherical distribution. Values &lt; 1 produce a needle like
	/// distribution (in the direction of the normal); values &gt; 1 produce a
	/// pancake like distribution (orthogonal to the normal).
	/// </summary>
	public virtual void SetEccentricity(double _arg)
	{
		vtkEllipsoidalGaussianKernel_SetEccentricity_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_SetNormalsArrayName_24(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the normals array name. Used to orient the ellipsoid. Note that
	/// by default the input normals are used (i.e. the input to
	/// vtkPointInterpolator). If no input normals are available, then the named
	/// NormalsArrayName is used.
	/// </summary>
	public virtual void SetNormalsArrayName(string _arg)
	{
		vtkEllipsoidalGaussianKernel_SetNormalsArrayName_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_SetScalarsArrayName_25(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the scalars array name. Used to scale the ellipsoid. Note that
	/// by default the input scalars are used (i.e. the input to
	/// vtkPointInterpolator). If no input scalars are available, then the named
	/// ScalarsArrayName is used.
	/// </summary>
	public virtual void SetScalarsArrayName(string _arg)
	{
		vtkEllipsoidalGaussianKernel_SetScalarsArrayName_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_SetScaleFactor_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Multiply the Gaussian splat distribution by this value. If UseScalars is
	/// on and a scalar array is provided, then the scalar value will be
	/// multiplied by the ScaleFactor times the Gaussian function.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkEllipsoidalGaussianKernel_SetScaleFactor_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_SetSharpness_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
	/// Sharpness=2. As the sharpness increases the effects of distant points
	/// are reduced.
	/// </summary>
	public virtual void SetSharpness(double _arg)
	{
		vtkEllipsoidalGaussianKernel_SetSharpness_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_SetUseNormals_28(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether vector values should be used to affect the shape
	/// of the Gaussian distribution. By default this is on.
	/// </summary>
	public virtual void SetUseNormals(bool _arg)
	{
		vtkEllipsoidalGaussianKernel_SetUseNormals_28(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_SetUseScalars_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether scalar values should be used to scale the weights.
	/// By default this is off.
	/// </summary>
	public virtual void SetUseScalars(bool _arg)
	{
		vtkEllipsoidalGaussianKernel_SetUseScalars_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_UseNormalsOff_30(HandleRef pThis);

	/// <summary>
	/// Specify whether vector values should be used to affect the shape
	/// of the Gaussian distribution. By default this is on.
	/// </summary>
	public virtual void UseNormalsOff()
	{
		vtkEllipsoidalGaussianKernel_UseNormalsOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_UseNormalsOn_31(HandleRef pThis);

	/// <summary>
	/// Specify whether vector values should be used to affect the shape
	/// of the Gaussian distribution. By default this is on.
	/// </summary>
	public virtual void UseNormalsOn()
	{
		vtkEllipsoidalGaussianKernel_UseNormalsOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_UseScalarsOff_32(HandleRef pThis);

	/// <summary>
	/// Specify whether scalar values should be used to scale the weights.
	/// By default this is off.
	/// </summary>
	public virtual void UseScalarsOff()
	{
		vtkEllipsoidalGaussianKernel_UseScalarsOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipsoidalGaussianKernel_UseScalarsOn_33(HandleRef pThis);

	/// <summary>
	/// Specify whether scalar values should be used to scale the weights.
	/// By default this is off.
	/// </summary>
	public virtual void UseScalarsOn()
	{
		vtkEllipsoidalGaussianKernel_UseScalarsOn_33(GetCppThis());
	}
}
