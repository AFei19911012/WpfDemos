using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGeneralizedKernel
/// </summary>
/// <remarks>
///    flexible, general interpolation kernels
///
///
/// vtkGeneralizedKernel is an abstract class that defines an API for concrete
/// general-purpose, kernel subclasses. vtkGeneralizedKernels has important
/// properties that make them useful in a variety of interpolation
/// applications:
/// &lt;pre&gt;
/// 1. The weights are normalized.
/// 2. The footprint of the basis is configurable.
/// 3. Probabilistic weighting functions can be used to favor certain weights.
/// &lt;/pre&gt;
/// The following paragraphs describe each of these properties in more detail.
///
/// Normalized weightings simple mean Sum(w_i) = 1. This ensures that the
/// interpolation process is well behaved.
///
/// The interpolation footprint is the set of points that are used to perform
/// the interpolation process. For example, it is possible to choose between a
/// radius-based kernel selection, and one based on the N nearest
/// neighbors. Note that the performance and mathematical properties of
/// kernels may vary greatly depending on which kernel style is selected. For
/// example, if a radius-based kernel footprint is used, and the radius is too
/// big, the algorithm can perform in n^3 fashion.
///
/// Finally, in advanced usage, probability functions can be applied to the
/// interpolation weights (prior to normalization). These probability
/// functions are confidence estimates that the data at a particular point is
/// accurate. A typical application is when laser scans are used to acquire
/// point measurements, which return normals that indicate glancing returns
/// versus direct, near orthogonal hits. Another use is when point clouds are
/// combined, where some clouds are acquired with more accurate, detailed
/// devices versus a broad, potentially coarser acquisition process.
///
/// @warning
/// Some kernels, like the Voronoi kernel, cannot be subclasses of this class
/// because their definition inherently defines the basis style. For example,
/// the Voronoi kernel is simply the single closest point. SPH kernels are
/// similar, because they implicitly depend on a particle distribution
/// consistent with simulation constraints such as conservation of mass, etc.
///
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator vtkPointInterpolator2D vtkGaussianKernel vtkSPHKernel
/// vtkShepardKernel vtkLinearKernel vtkVoronoiKernel
/// </seealso>
public abstract class vtkGeneralizedKernel : vtkInterpolationKernel
{
	/// <summary>
	/// Enum used to select the interpolation basis form. By default, a Radius
	/// form is used (i.e., the basis is defined from all points within a
	/// specified radius). However, it is also possible to select the N closest
	/// points (NClosest).
	/// </summary>
	public enum KernelStyle
	{
		/// <summary>enum member</summary>
		N_CLOSEST = 1,
		/// <summary>enum member</summary>
		RADIUS = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGeneralizedKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGeneralizedKernel()
	{
		MRClassNameKey = "class vtkGeneralizedKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeneralizedKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGeneralizedKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern long vtkGeneralizedKernel_ComputeBasis_01(HandleRef pThis, IntPtr x, HandleRef pIds, long ptId);

	/// <summary>
	/// Based on the kernel style, invoke the appropriate locator method to
	/// obtain the points making up the basis. Given a point x (and optional
	/// associated point id), determine the points around x which form an
	/// interpolation basis. The user must provide the vtkIdList pIds, which
	/// will be dynamically resized as necessary. The method returns the number
	/// of points in the basis. Typically this method is called before
	/// ComputeWeights(). Note that ptId is optional in most cases, although in
	/// some kernels it is used to facilitate basis computation.
	/// </summary>
	public override long ComputeBasis(IntPtr x, vtkIdList pIds, long ptId)
	{
		return vtkGeneralizedKernel_ComputeBasis_01(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), ptId);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeneralizedKernel_ComputeWeights_02(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

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
	public virtual long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
	{
		return vtkGeneralizedKernel_ComputeWeights_02(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), prob?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeneralizedKernel_ComputeWeights_03(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights);

	/// <summary>
	/// Given a point x, and a list of basis points pIds, compute interpolation
	/// weights associated with these basis points.  Note that both the nearby
	/// basis points list pIds and the weights array are provided by the caller
	/// of the method, and may be dynamically resized as necessary. Typically
	/// this method is called after ComputeBasis(), although advanced users can
	/// invoke ComputeWeights() and provide the interpolation basis points pIds
	/// directly.
	/// </summary>
	public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights)
	{
		return vtkGeneralizedKernel_ComputeWeights_03(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralizedKernel_GetKernelFootprint_04(HandleRef pThis);

	/// <summary>
	/// Specify the interpolation basis style. By default, a Radius style is
	/// used (i.e., the basis is defined from all points within a specified
	/// radius). However, it is also possible to select the N closest points
	/// (NClosest). Note that in most formulations the Radius style is assumed
	/// as it provides better mathematical properties. However, for convenience
	/// some bases are easier to use when the N closest points are taken.
	/// </summary>
	public virtual int GetKernelFootprint()
	{
		return vtkGeneralizedKernel_GetKernelFootprint_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGeneralizedKernel_GetNormalizeWeights_05(HandleRef pThis);

	/// <summary>
	/// Indicate whether the interpolation weights should be normalized after they
	/// are computed. Generally this is left on as it results in more reasonable
	/// behavior.
	/// </summary>
	public virtual bool GetNormalizeWeights()
	{
		return (vtkGeneralizedKernel_GetNormalizeWeights_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeneralizedKernel_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGeneralizedKernel_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGeneralizedKernel_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGeneralizedKernel_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralizedKernel_GetNumberOfPoints_08(HandleRef pThis);

	/// <summary>
	/// If the interpolation basis style is NClosest, then this method specifies
	/// the number of the closest points used to form the interpolation basis.
	/// </summary>
	public virtual int GetNumberOfPoints()
	{
		return vtkGeneralizedKernel_GetNumberOfPoints_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralizedKernel_GetNumberOfPointsMaxValue_09(HandleRef pThis);

	/// <summary>
	/// If the interpolation basis style is NClosest, then this method specifies
	/// the number of the closest points used to form the interpolation basis.
	/// </summary>
	public virtual int GetNumberOfPointsMaxValue()
	{
		return vtkGeneralizedKernel_GetNumberOfPointsMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralizedKernel_GetNumberOfPointsMinValue_10(HandleRef pThis);

	/// <summary>
	/// If the interpolation basis style is NClosest, then this method specifies
	/// the number of the closest points used to form the interpolation basis.
	/// </summary>
	public virtual int GetNumberOfPointsMinValue()
	{
		return vtkGeneralizedKernel_GetNumberOfPointsMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGeneralizedKernel_GetRadius_11(HandleRef pThis);

	/// <summary>
	/// If the interpolation basis style is Radius, then this method specifies
	/// the radius within which the basis points must lie.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkGeneralizedKernel_GetRadius_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGeneralizedKernel_GetRadiusMaxValue_12(HandleRef pThis);

	/// <summary>
	/// If the interpolation basis style is Radius, then this method specifies
	/// the radius within which the basis points must lie.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkGeneralizedKernel_GetRadiusMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGeneralizedKernel_GetRadiusMinValue_13(HandleRef pThis);

	/// <summary>
	/// If the interpolation basis style is Radius, then this method specifies
	/// the radius within which the basis points must lie.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkGeneralizedKernel_GetRadiusMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralizedKernel_IsA_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGeneralizedKernel_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGeneralizedKernel_IsTypeOf_15(string type);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGeneralizedKernel_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeneralizedKernel_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public new vtkGeneralizedKernel NewInstance()
	{
		vtkGeneralizedKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeneralizedKernel_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGeneralizedKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralizedKernel_NormalizeWeightsOff_17(HandleRef pThis);

	/// <summary>
	/// Indicate whether the interpolation weights should be normalized after they
	/// are computed. Generally this is left on as it results in more reasonable
	/// behavior.
	/// </summary>
	public virtual void NormalizeWeightsOff()
	{
		vtkGeneralizedKernel_NormalizeWeightsOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralizedKernel_NormalizeWeightsOn_18(HandleRef pThis);

	/// <summary>
	/// Indicate whether the interpolation weights should be normalized after they
	/// are computed. Generally this is left on as it results in more reasonable
	/// behavior.
	/// </summary>
	public virtual void NormalizeWeightsOn()
	{
		vtkGeneralizedKernel_NormalizeWeightsOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGeneralizedKernel_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type and printing.
	/// </summary>
	public new static vtkGeneralizedKernel SafeDownCast(vtkObjectBase o)
	{
		vtkGeneralizedKernel vtkGeneralizedKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGeneralizedKernel_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGeneralizedKernel2 = (vtkGeneralizedKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGeneralizedKernel2.Register(null);
			}
		}
		return vtkGeneralizedKernel2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralizedKernel_SetKernelFootprint_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the interpolation basis style. By default, a Radius style is
	/// used (i.e., the basis is defined from all points within a specified
	/// radius). However, it is also possible to select the N closest points
	/// (NClosest). Note that in most formulations the Radius style is assumed
	/// as it provides better mathematical properties. However, for convenience
	/// some bases are easier to use when the N closest points are taken.
	/// </summary>
	public virtual void SetKernelFootprint(int _arg)
	{
		vtkGeneralizedKernel_SetKernelFootprint_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralizedKernel_SetKernelFootprintToNClosest_21(HandleRef pThis);

	/// <summary>
	/// Specify the interpolation basis style. By default, a Radius style is
	/// used (i.e., the basis is defined from all points within a specified
	/// radius). However, it is also possible to select the N closest points
	/// (NClosest). Note that in most formulations the Radius style is assumed
	/// as it provides better mathematical properties. However, for convenience
	/// some bases are easier to use when the N closest points are taken.
	/// </summary>
	public void SetKernelFootprintToNClosest()
	{
		vtkGeneralizedKernel_SetKernelFootprintToNClosest_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralizedKernel_SetKernelFootprintToRadius_22(HandleRef pThis);

	/// <summary>
	/// Specify the interpolation basis style. By default, a Radius style is
	/// used (i.e., the basis is defined from all points within a specified
	/// radius). However, it is also possible to select the N closest points
	/// (NClosest). Note that in most formulations the Radius style is assumed
	/// as it provides better mathematical properties. However, for convenience
	/// some bases are easier to use when the N closest points are taken.
	/// </summary>
	public void SetKernelFootprintToRadius()
	{
		vtkGeneralizedKernel_SetKernelFootprintToRadius_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralizedKernel_SetNormalizeWeights_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Indicate whether the interpolation weights should be normalized after they
	/// are computed. Generally this is left on as it results in more reasonable
	/// behavior.
	/// </summary>
	public virtual void SetNormalizeWeights(bool _arg)
	{
		vtkGeneralizedKernel_SetNormalizeWeights_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralizedKernel_SetNumberOfPoints_24(HandleRef pThis, int _arg);

	/// <summary>
	/// If the interpolation basis style is NClosest, then this method specifies
	/// the number of the closest points used to form the interpolation basis.
	/// </summary>
	public virtual void SetNumberOfPoints(int _arg)
	{
		vtkGeneralizedKernel_SetNumberOfPoints_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGeneralizedKernel_SetRadius_25(HandleRef pThis, double _arg);

	/// <summary>
	/// If the interpolation basis style is Radius, then this method specifies
	/// the radius within which the basis points must lie.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkGeneralizedKernel_SetRadius_25(GetCppThis(), _arg);
	}
}
