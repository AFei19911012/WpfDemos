using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGaussianKernel
/// </summary>
/// <remarks>
///    a spherical Gaussian interpolation kernel
///
///
/// vtkGaussianKernel is an interpolation kernel that simply returns the
/// weights for all points found in the sphere defined by radius R. The
/// weights are computed as: exp(-(s*r/R)^2) where r is the distance from the
/// point to be interpolated to a neighboring point within R. The sharpness s
/// simply affects the rate of fall off of the Gaussian. (A more general
/// Gaussian kernel is available from vtkEllipsoidalGaussianKernel.)
///
/// @warning
/// The weights are normalized sp that SUM(Wi) = 1. If a neighbor point p
/// precisely lies on the point to be interpolated, then the interpolated
/// point takes on the values associated with p.
///
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator vtkInterpolationKernel vtkEllipsoidalGaussianKernel
/// vtkVoronoiKernel vtkSPHKernel vtkShepardKernel
/// </seealso>
public class vtkGaussianKernel : vtkGeneralizedKernel
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGaussianKernel()
	{
		MRClassNameKey = "class vtkGaussianKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGaussianKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkGaussianKernel New()
	{
		vtkGaussianKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGaussianKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGaussianKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkGaussianKernel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGaussianKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkGaussianKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

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
		return vtkGaussianKernel_ComputeWeights_01(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), prob?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGaussianKernel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGaussianKernel_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGaussianKernel_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGaussianKernel_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianKernel_GetSharpness_04(HandleRef pThis);

	/// <summary>
	/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
	/// Sharpness=2. As the sharpness increases the effects of distant points
	/// are reduced.
	/// </summary>
	public virtual double GetSharpness()
	{
		return vtkGaussianKernel_GetSharpness_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianKernel_GetSharpnessMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
	/// Sharpness=2. As the sharpness increases the effects of distant points
	/// are reduced.
	/// </summary>
	public virtual double GetSharpnessMaxValue()
	{
		return vtkGaussianKernel_GetSharpnessMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGaussianKernel_GetSharpnessMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
	/// Sharpness=2. As the sharpness increases the effects of distant points
	/// are reduced.
	/// </summary>
	public virtual double GetSharpnessMinValue()
	{
		return vtkGaussianKernel_GetSharpnessMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianKernel_Initialize_07(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

	/// <summary>
	/// Initialize the kernel. Overload the superclass to set up internal
	/// computational values.
	/// </summary>
	public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
	{
		vtkGaussianKernel_Initialize_07(GetCppThis(), loc?.GetCppThis() ?? default(HandleRef), ds?.GetCppThis() ?? default(HandleRef), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianKernel_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGaussianKernel_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGaussianKernel_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGaussianKernel_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianKernel_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkGaussianKernel NewInstance()
	{
		vtkGaussianKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGaussianKernel_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGaussianKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGaussianKernel_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkGaussianKernel SafeDownCast(vtkObjectBase o)
	{
		vtkGaussianKernel vtkGaussianKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGaussianKernel_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGaussianKernel2 = (vtkGaussianKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGaussianKernel2.Register(null);
			}
		}
		return vtkGaussianKernel2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGaussianKernel_SetSharpness_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
	/// Sharpness=2. As the sharpness increases the effects of distant points
	/// are reduced.
	/// </summary>
	public virtual void SetSharpness(double _arg)
	{
		vtkGaussianKernel_SetSharpness_13(GetCppThis(), _arg);
	}
}
