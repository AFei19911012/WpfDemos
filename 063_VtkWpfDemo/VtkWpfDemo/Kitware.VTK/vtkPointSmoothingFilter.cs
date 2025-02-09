using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointSmoothingFilter
/// </summary>
/// <remarks>
///    adjust point positions to form a pleasing, packed arrangement
///
///
/// vtkPointSmoothingFilter modifies the coordinates of the input points of a
/// vtkPointSet by adjusting their position to create a smooth distribution
/// (and thereby form a pleasing packing of the points). Smoothing is
/// performed by considering the effects of neighboring points on one
/// another. Smoothing in its simplest form (geometric) is simply a variant of
/// Laplacian smoothing where each point moves towards the average position of
/// its neighboring points. Next, uniform smoothing uses a cubic cutoff
/// function to produce repulsive forces between close points and attractive
/// forces that are a little further away. Smoothing can be further controlled
/// either by a scalar field, by a tensor field, or a frame field (the user
/// can specify the nature of the smoothing operation). If controlled by a
/// scalar field, then each input point is assumed to be surrounded by a
/// isotropic sphere scaled by the scalar field; if controlled by a tensor
/// field, then each input point is assumed to be surrounded by an
/// anisotropic, oriented ellipsoid aligned to the the tensor eigenvectors and
/// scaled by the determinate of the tensor. A frame field also assumes a
/// surrounding, ellipsoidal shape except that the inversion of the ellipsoid
/// tensor is already performed. Typical usage of this filter is to perform a
/// smoothing (also referred to as packing) operation (i.e., first execute
/// this filter) and then combine it with a glyph filter (e.g., vtkTensorGlyph
/// or vtkGlyph3D) to visualize the packed points.
///
/// Smoothing depends on a local neighborhood of nearby points. In general,
/// the larger the neighborhood size, the greater the reduction in high
/// frequency information. (The memory and/or computational requirements of
/// the algorithm may also significantly increase.) The PackingRadius (and
/// PackingFactor) controls what points are considered close. The
/// PackingRadius can be computed automatically, or specified by the user.
/// (The product of PackingRadius*PackingFactor is referred to as the scaling
/// factor alpha in the paper cited below. This provides a convenient way to
/// combine automatic PackingRadius computation based on average between
/// particle neighborhoods, and then adjust it with the PackingFactor.)
///
/// Any vtkPointSet type can be provided as input, and the output will contain
/// the same number of new points each of which is adjusted to a new position.
///
/// Note that the algorithm requires the use of a spatial point locator. The
/// point locator is used to build a local neighborhood of the points
/// surrounding each point. It is also used to perform interpolation as the
/// point positions are adjusted.
///
/// The algorithm incrementally adjusts the point positions through an
/// iterative process. Basically points are moved due to the influence of
/// neighboring points. Iterations continue until the specified number of
/// iterations is reached, or convergence occurs. Convergence occurs when the
/// maximum displacement of any point is less than the convergence value. As
/// points move, both the local connectivity and data attributes associated
/// with each point must be updated. Rather than performing these expensive
/// operations after every iteration, a number of sub-iterations Si can be
/// specified. If Si &gt; 1, then the neighborhood and attribute value updates
/// occur only every Si'th iteration. Using sub-iterations can improve
/// performance significantly.
///
/// @warning
/// Geometric smoothing defines a one-sided attractive force between
/// particles. Thus particles tend to clump together, and the entire set of
/// points (with enough iterations and appropriate PackingRadius) can converge
/// to a single position. This can be mitigated by turning on point
/// constraints, which limit the movement of "boundary" points.
///
/// @warning
/// This class has been loosely inspired by the paper by Kindlmann and Westin
/// "Diffusion Tensor Visualization with Glyph Packing". However, several
/// computational shortcuts, and generalizations have been used for performance
/// and utility reasons.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorWidget vtkTensorGlyph vtkSmoothPolyDataFilter vtkGlyph3D
/// </seealso>
public class vtkPointSmoothingFilter : vtkPointSetAlgorithm
{
	/// <summary>
	/// Specify how smoothing is to be controlled.
	/// </summary>
	public enum DEFAULT_SMOOTHING_WrapperEnum
	{
		/// <summary>enum member</summary>
		DEFAULT_SMOOTHING = 0,
		/// <summary>enum member</summary>
		FRAME_FIELD_SMOOTHING = 5,
		/// <summary>enum member</summary>
		GEOMETRIC_SMOOTHING = 1,
		/// <summary>enum member</summary>
		SCALAR_SMOOTHING = 3,
		/// <summary>enum member</summary>
		TENSOR_SMOOTHING = 4,
		/// <summary>enum member</summary>
		UNIFORM_SMOOTHING = 2
	}

	/// <summary>
	/// Specify how point motion is to be constrained.
	/// </summary>
	public enum PLANE_MOTION_WrapperEnum
	{
		/// <summary>enum member</summary>
		PLANE_MOTION = 1,
		/// <summary>enum member</summary>
		UNCONSTRAINED_MOTION = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointSmoothingFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointSmoothingFilter()
	{
		MRClassNameKey = "class vtkPointSmoothingFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSmoothingFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointSmoothingFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSmoothingFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPointSmoothingFilter New()
	{
		vtkPointSmoothingFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSmoothingFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkPointSmoothingFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointSmoothingFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPointSmoothingFilter_ComputePackingRadiusOff_01(HandleRef pThis);

	/// <summary>
	/// Enable / disable the computation of a packing radius. By default,
	/// a packing radius is computed as one half of the average distance
	/// between neighboring points. (Point neighbors are defined by the
	/// neighborhood size.)
	/// </summary>
	public virtual void ComputePackingRadiusOff()
	{
		vtkPointSmoothingFilter_ComputePackingRadiusOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_ComputePackingRadiusOn_02(HandleRef pThis);

	/// <summary>
	/// Enable / disable the computation of a packing radius. By default,
	/// a packing radius is computed as one half of the average distance
	/// between neighboring points. (Point neighbors are defined by the
	/// neighborhood size.)
	/// </summary>
	public virtual void ComputePackingRadiusOn()
	{
		vtkPointSmoothingFilter_ComputePackingRadiusOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_EnableConstraintsOff_03(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual void EnableConstraintsOff()
	{
		vtkPointSmoothingFilter_EnableConstraintsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_EnableConstraintsOn_04(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual void EnableConstraintsOn()
	{
		vtkPointSmoothingFilter_EnableConstraintsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_GenerateConstraintNormalsOff_05(HandleRef pThis);

	/// <summary>
	/// If point constraints are enabled, an output vector indicating the
	/// average normal at each point can be generated.
	/// </summary>
	public virtual void GenerateConstraintNormalsOff()
	{
		vtkPointSmoothingFilter_GenerateConstraintNormalsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_GenerateConstraintNormalsOn_06(HandleRef pThis);

	/// <summary>
	/// If point constraints are enabled, an output vector indicating the
	/// average normal at each point can be generated.
	/// </summary>
	public virtual void GenerateConstraintNormalsOn()
	{
		vtkPointSmoothingFilter_GenerateConstraintNormalsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_GenerateConstraintScalarsOff_07(HandleRef pThis);

	/// <summary>
	/// If point constraints are enabled, an output scalar indicating the
	/// classification of points can be generated.
	/// </summary>
	public virtual void GenerateConstraintScalarsOff()
	{
		vtkPointSmoothingFilter_GenerateConstraintScalarsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_GenerateConstraintScalarsOn_08(HandleRef pThis);

	/// <summary>
	/// If point constraints are enabled, an output scalar indicating the
	/// classification of points can be generated.
	/// </summary>
	public virtual void GenerateConstraintScalarsOn()
	{
		vtkPointSmoothingFilter_GenerateConstraintScalarsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetAttractionFactor_09(HandleRef pThis);

	/// <summary>
	/// Control the relative distance of inter-particle attraction. A value of
	/// 1.0 means that the radius of the attraction region is the same as the
	/// radius of repulsion. By default, a value of 0.5 is used (e.g., in the
	/// region 0&lt;=r&lt;=R a repulsive force is generated, while in R&lt;r&lt;=R*1.5 an
	/// attractive force is generated).
	/// </summary>
	public virtual double GetAttractionFactor()
	{
		return vtkPointSmoothingFilter_GetAttractionFactor_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetAttractionFactorMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Control the relative distance of inter-particle attraction. A value of
	/// 1.0 means that the radius of the attraction region is the same as the
	/// radius of repulsion. By default, a value of 0.5 is used (e.g., in the
	/// region 0&lt;=r&lt;=R a repulsive force is generated, while in R&lt;r&lt;=R*1.5 an
	/// attractive force is generated).
	/// </summary>
	public virtual double GetAttractionFactorMaxValue()
	{
		return vtkPointSmoothingFilter_GetAttractionFactorMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetAttractionFactorMinValue_11(HandleRef pThis);

	/// <summary>
	/// Control the relative distance of inter-particle attraction. A value of
	/// 1.0 means that the radius of the attraction region is the same as the
	/// radius of repulsion. By default, a value of 0.5 is used (e.g., in the
	/// region 0&lt;=r&lt;=R a repulsive force is generated, while in R&lt;r&lt;=R*1.5 an
	/// attractive force is generated).
	/// </summary>
	public virtual double GetAttractionFactorMinValue()
	{
		return vtkPointSmoothingFilter_GetAttractionFactorMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetBoundaryAngle_12(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual double GetBoundaryAngle()
	{
		return vtkPointSmoothingFilter_GetBoundaryAngle_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetBoundaryAngleMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual double GetBoundaryAngleMaxValue()
	{
		return vtkPointSmoothingFilter_GetBoundaryAngleMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetBoundaryAngleMinValue_14(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual double GetBoundaryAngleMinValue()
	{
		return vtkPointSmoothingFilter_GetBoundaryAngleMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSmoothingFilter_GetComputePackingRadius_15(HandleRef pThis);

	/// <summary>
	/// Enable / disable the computation of a packing radius. By default,
	/// a packing radius is computed as one half of the average distance
	/// between neighboring points. (Point neighbors are defined by the
	/// neighborhood size.)
	/// </summary>
	public virtual bool GetComputePackingRadius()
	{
		return (vtkPointSmoothingFilter_GetComputePackingRadius_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetConvergence_16(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration
	/// process. Smaller numbers result in more smoothing iterations.
	/// </summary>
	public virtual double GetConvergence()
	{
		return vtkPointSmoothingFilter_GetConvergence_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetConvergenceMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration
	/// process. Smaller numbers result in more smoothing iterations.
	/// </summary>
	public virtual double GetConvergenceMaxValue()
	{
		return vtkPointSmoothingFilter_GetConvergenceMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetConvergenceMinValue_18(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration
	/// process. Smaller numbers result in more smoothing iterations.
	/// </summary>
	public virtual double GetConvergenceMinValue()
	{
		return vtkPointSmoothingFilter_GetConvergenceMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSmoothingFilter_GetEnableConstraints_19(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual bool GetEnableConstraints()
	{
		return (vtkPointSmoothingFilter_GetEnableConstraints_19(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetFixedAngle_20(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual double GetFixedAngle()
	{
		return vtkPointSmoothingFilter_GetFixedAngle_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetFixedAngleMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual double GetFixedAngleMaxValue()
	{
		return vtkPointSmoothingFilter_GetFixedAngleMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetFixedAngleMinValue_22(HandleRef pThis);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual double GetFixedAngleMinValue()
	{
		return vtkPointSmoothingFilter_GetFixedAngleMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSmoothingFilter_GetFrameFieldArray_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the name of the frame field to use for smoothing. This
	/// information is only necessary if a frame field smoothing is enabled.
	/// </summary>
	public virtual vtkDataArray GetFrameFieldArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSmoothingFilter_GetFrameFieldArray_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSmoothingFilter_GetGenerateConstraintNormals_24(HandleRef pThis);

	/// <summary>
	/// If point constraints are enabled, an output vector indicating the
	/// average normal at each point can be generated.
	/// </summary>
	public virtual bool GetGenerateConstraintNormals()
	{
		return (vtkPointSmoothingFilter_GetGenerateConstraintNormals_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointSmoothingFilter_GetGenerateConstraintScalars_25(HandleRef pThis);

	/// <summary>
	/// If point constraints are enabled, an output scalar indicating the
	/// classification of points can be generated.
	/// </summary>
	public virtual bool GetGenerateConstraintScalars()
	{
		return (vtkPointSmoothingFilter_GetGenerateConstraintScalars_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSmoothingFilter_GetLocator_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSmoothingFilter_GetLocator_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetMaximumStepSize_27(HandleRef pThis);

	/// <summary>
	/// Specify the maximum smoothing step size for each smoothing iteration. This
	/// step size limits the the distance over which a point can move in each
	/// iteration.  As in all iterative methods, the stability of the process is
	/// sensitive to this parameter. In general, small step size and large
	/// numbers of iterations are more stable than a larger step size and a
	/// smaller numbers of iterations.
	/// </summary>
	public virtual double GetMaximumStepSize()
	{
		return vtkPointSmoothingFilter_GetMaximumStepSize_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetMaximumStepSizeMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Specify the maximum smoothing step size for each smoothing iteration. This
	/// step size limits the the distance over which a point can move in each
	/// iteration.  As in all iterative methods, the stability of the process is
	/// sensitive to this parameter. In general, small step size and large
	/// numbers of iterations are more stable than a larger step size and a
	/// smaller numbers of iterations.
	/// </summary>
	public virtual double GetMaximumStepSizeMaxValue()
	{
		return vtkPointSmoothingFilter_GetMaximumStepSizeMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetMaximumStepSizeMinValue_29(HandleRef pThis);

	/// <summary>
	/// Specify the maximum smoothing step size for each smoothing iteration. This
	/// step size limits the the distance over which a point can move in each
	/// iteration.  As in all iterative methods, the stability of the process is
	/// sensitive to this parameter. In general, small step size and large
	/// numbers of iterations are more stable than a larger step size and a
	/// smaller numbers of iterations.
	/// </summary>
	public virtual double GetMaximumStepSizeMinValue()
	{
		return vtkPointSmoothingFilter_GetMaximumStepSizeMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetMotionConstraint_30(HandleRef pThis);

	/// <summary>
	/// Specify how to constrain the motion of points. By default, point motion is
	/// unconstrained. Points can also be constrained to a plane. If constrained to
	/// a plane, then an instance of vtkPlane must be specified.
	/// </summary>
	public virtual int GetMotionConstraint()
	{
		return vtkPointSmoothingFilter_GetMotionConstraint_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNeighborhoodSize_31(HandleRef pThis);

	/// <summary>
	/// Specify the neighborhood size. This controls the number of surrounding
	/// points that can affect a point to be smoothed.
	/// </summary>
	public virtual int GetNeighborhoodSize()
	{
		return vtkPointSmoothingFilter_GetNeighborhoodSize_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNeighborhoodSizeMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Specify the neighborhood size. This controls the number of surrounding
	/// points that can affect a point to be smoothed.
	/// </summary>
	public virtual int GetNeighborhoodSizeMaxValue()
	{
		return vtkPointSmoothingFilter_GetNeighborhoodSizeMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNeighborhoodSizeMinValue_33(HandleRef pThis);

	/// <summary>
	/// Specify the neighborhood size. This controls the number of surrounding
	/// points that can affect a point to be smoothed.
	/// </summary>
	public virtual int GetNeighborhoodSizeMinValue()
	{
		return vtkPointSmoothingFilter_GetNeighborhoodSizeMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSmoothingFilter_GetNumberOfGenerationsFromBase_34(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointSmoothingFilter_GetNumberOfGenerationsFromBase_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointSmoothingFilter_GetNumberOfGenerationsFromBaseType_35(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointSmoothingFilter_GetNumberOfGenerationsFromBaseType_35(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNumberOfIterations_36(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing iterations.
	/// </summary>
	public virtual int GetNumberOfIterations()
	{
		return vtkPointSmoothingFilter_GetNumberOfIterations_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNumberOfIterationsMaxValue_37(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing iterations.
	/// </summary>
	public virtual int GetNumberOfIterationsMaxValue()
	{
		return vtkPointSmoothingFilter_GetNumberOfIterationsMaxValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNumberOfIterationsMinValue_38(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing iterations.
	/// </summary>
	public virtual int GetNumberOfIterationsMinValue()
	{
		return vtkPointSmoothingFilter_GetNumberOfIterationsMinValue_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNumberOfSubIterations_39(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing subiterations. This specifies the
	/// frequency of connectivity and data attribute updates.
	/// </summary>
	public virtual int GetNumberOfSubIterations()
	{
		return vtkPointSmoothingFilter_GetNumberOfSubIterations_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNumberOfSubIterationsMaxValue_40(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing subiterations. This specifies the
	/// frequency of connectivity and data attribute updates.
	/// </summary>
	public virtual int GetNumberOfSubIterationsMaxValue()
	{
		return vtkPointSmoothingFilter_GetNumberOfSubIterationsMaxValue_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetNumberOfSubIterationsMinValue_41(HandleRef pThis);

	/// <summary>
	/// Specify the number of smoothing subiterations. This specifies the
	/// frequency of connectivity and data attribute updates.
	/// </summary>
	public virtual int GetNumberOfSubIterationsMinValue()
	{
		return vtkPointSmoothingFilter_GetNumberOfSubIterationsMinValue_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetPackingFactor_42(HandleRef pThis);

	/// <summary>
	/// Specify the packing factor. Larger numbers tend to loosen the overall
	/// packing of points. Note however that if the point density in a region is
	/// high, then the packing factor may have little effect (due to mutual
	/// inter-particle constraints). The default value is 1.0. (Note that a
	/// characteristic inter-particle radius R is computed at the onset of the
	/// algorithm (or can be manually specified). Within 0&lt;=r&lt;=R*PackingFactor a
	/// repulsive force is generated.)
	/// </summary>
	public virtual double GetPackingFactor()
	{
		return vtkPointSmoothingFilter_GetPackingFactor_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetPackingFactorMaxValue_43(HandleRef pThis);

	/// <summary>
	/// Specify the packing factor. Larger numbers tend to loosen the overall
	/// packing of points. Note however that if the point density in a region is
	/// high, then the packing factor may have little effect (due to mutual
	/// inter-particle constraints). The default value is 1.0. (Note that a
	/// characteristic inter-particle radius R is computed at the onset of the
	/// algorithm (or can be manually specified). Within 0&lt;=r&lt;=R*PackingFactor a
	/// repulsive force is generated.)
	/// </summary>
	public virtual double GetPackingFactorMaxValue()
	{
		return vtkPointSmoothingFilter_GetPackingFactorMaxValue_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetPackingFactorMinValue_44(HandleRef pThis);

	/// <summary>
	/// Specify the packing factor. Larger numbers tend to loosen the overall
	/// packing of points. Note however that if the point density in a region is
	/// high, then the packing factor may have little effect (due to mutual
	/// inter-particle constraints). The default value is 1.0. (Note that a
	/// characteristic inter-particle radius R is computed at the onset of the
	/// algorithm (or can be manually specified). Within 0&lt;=r&lt;=R*PackingFactor a
	/// repulsive force is generated.)
	/// </summary>
	public virtual double GetPackingFactorMinValue()
	{
		return vtkPointSmoothingFilter_GetPackingFactorMinValue_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetPackingRadius_45(HandleRef pThis);

	/// <summary>
	/// Specify the packing radius R. This only takes effect if
	/// ComputePackingRadius is off. Note that the for two points separated by
	/// radius r, a repulsive force is generated when 0&lt;=r&lt;=R, and a repulsive
	/// force when R&lt;=r&lt;=(1+AttractionFactor*R). By default, the PackingRadius
	/// is automatically computed, but when ComputePackingRadius is off, then
	/// manually setting the PackingRadius is allowed. Note that the
	/// PackingRadius is updated after the algorithm runs (useful to examine the
	/// computed packing radius).
	/// </summary>
	public virtual double GetPackingRadius()
	{
		return vtkPointSmoothingFilter_GetPackingRadius_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetPackingRadiusMaxValue_46(HandleRef pThis);

	/// <summary>
	/// Specify the packing radius R. This only takes effect if
	/// ComputePackingRadius is off. Note that the for two points separated by
	/// radius r, a repulsive force is generated when 0&lt;=r&lt;=R, and a repulsive
	/// force when R&lt;=r&lt;=(1+AttractionFactor*R). By default, the PackingRadius
	/// is automatically computed, but when ComputePackingRadius is off, then
	/// manually setting the PackingRadius is allowed. Note that the
	/// PackingRadius is updated after the algorithm runs (useful to examine the
	/// computed packing radius).
	/// </summary>
	public virtual double GetPackingRadiusMaxValue()
	{
		return vtkPointSmoothingFilter_GetPackingRadiusMaxValue_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointSmoothingFilter_GetPackingRadiusMinValue_47(HandleRef pThis);

	/// <summary>
	/// Specify the packing radius R. This only takes effect if
	/// ComputePackingRadius is off. Note that the for two points separated by
	/// radius r, a repulsive force is generated when 0&lt;=r&lt;=R, and a repulsive
	/// force when R&lt;=r&lt;=(1+AttractionFactor*R). By default, the PackingRadius
	/// is automatically computed, but when ComputePackingRadius is off, then
	/// manually setting the PackingRadius is allowed. Note that the
	/// PackingRadius is updated after the algorithm runs (useful to examine the
	/// computed packing radius).
	/// </summary>
	public virtual double GetPackingRadiusMinValue()
	{
		return vtkPointSmoothingFilter_GetPackingRadiusMinValue_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSmoothingFilter_GetPlane_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the plane to which point motion is constrained. Only required if
	/// MotionConstraint is set to UNCONSTRAINED_MOTION.
	/// </summary>
	public virtual vtkPlane GetPlane()
	{
		vtkPlane vtkPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSmoothingFilter_GetPlane_48(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlane2 = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlane2.Register(null);
			}
		}
		return vtkPlane2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetSmoothingMode_49(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public virtual int GetSmoothingMode()
	{
		return vtkPointSmoothingFilter_GetSmoothingMode_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetSmoothingModeMaxValue_50(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public virtual int GetSmoothingModeMaxValue()
	{
		return vtkPointSmoothingFilter_GetSmoothingModeMaxValue_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_GetSmoothingModeMinValue_51(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public virtual int GetSmoothingModeMinValue()
	{
		return vtkPointSmoothingFilter_GetSmoothingModeMinValue_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_IsA_52(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointSmoothingFilter_IsA_52(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointSmoothingFilter_IsTypeOf_53(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointSmoothingFilter_IsTypeOf_53(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSmoothingFilter_NewInstance_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkPointSmoothingFilter NewInstance()
	{
		vtkPointSmoothingFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSmoothingFilter_NewInstance_55(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointSmoothingFilter_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPointSmoothingFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPointSmoothingFilter vtkPointSmoothingFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointSmoothingFilter_SafeDownCast_56(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointSmoothingFilter2 = (vtkPointSmoothingFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointSmoothingFilter2.Register(null);
			}
		}
		return vtkPointSmoothingFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetAttractionFactor_57(HandleRef pThis, double _arg);

	/// <summary>
	/// Control the relative distance of inter-particle attraction. A value of
	/// 1.0 means that the radius of the attraction region is the same as the
	/// radius of repulsion. By default, a value of 0.5 is used (e.g., in the
	/// region 0&lt;=r&lt;=R a repulsive force is generated, while in R&lt;r&lt;=R*1.5 an
	/// attractive force is generated).
	/// </summary>
	public virtual void SetAttractionFactor(double _arg)
	{
		vtkPointSmoothingFilter_SetAttractionFactor_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetBoundaryAngle_58(HandleRef pThis, double _arg);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual void SetBoundaryAngle(double _arg)
	{
		vtkPointSmoothingFilter_SetBoundaryAngle_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetComputePackingRadius_59(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable / disable the computation of a packing radius. By default,
	/// a packing radius is computed as one half of the average distance
	/// between neighboring points. (Point neighbors are defined by the
	/// neighborhood size.)
	/// </summary>
	public virtual void SetComputePackingRadius(bool _arg)
	{
		vtkPointSmoothingFilter_SetComputePackingRadius_59(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetConvergence_60(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a convergence criterion for the iteration
	/// process. Smaller numbers result in more smoothing iterations.
	/// </summary>
	public virtual void SetConvergence(double _arg)
	{
		vtkPointSmoothingFilter_SetConvergence_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetEnableConstraints_61(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual void SetEnableConstraints(bool _arg)
	{
		vtkPointSmoothingFilter_SetEnableConstraints_61(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetFixedAngle_62(HandleRef pThis, double _arg);

	/// <summary>
	/// Enable or disable constraints on points. Point constraints are used to
	/// prevent points from moving, or to move only on a plane. This can prevent
	/// shrinking or growing point clouds. If enabled, a local topological
	/// analysis is performed to determine whether a point should be marked
	/// "Fixed" i.e., never moves; "Plane", the point only moves on a plane; or
	/// "Unconstrained", the point can move freely. If all points in the
	/// neighborhood surrounding a point are in the cone defined by FixedAngle,
	/// then the point is classified "Fixed." If all points in the neighborhood
	/// surrounding a point are in the cone defined by BoundaryAngle, then the
	/// point is classified "Plane." (The angles are expressed in degrees.)
	/// </summary>
	public virtual void SetFixedAngle(double _arg)
	{
		vtkPointSmoothingFilter_SetFixedAngle_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetFrameFieldArray_63(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the name of the frame field to use for smoothing. This
	/// information is only necessary if a frame field smoothing is enabled.
	/// </summary>
	public virtual void SetFrameFieldArray(vtkDataArray arg0)
	{
		vtkPointSmoothingFilter_SetFrameFieldArray_63(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetGenerateConstraintNormals_64(HandleRef pThis, byte _arg);

	/// <summary>
	/// If point constraints are enabled, an output vector indicating the
	/// average normal at each point can be generated.
	/// </summary>
	public virtual void SetGenerateConstraintNormals(bool _arg)
	{
		vtkPointSmoothingFilter_SetGenerateConstraintNormals_64(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetGenerateConstraintScalars_65(HandleRef pThis, byte _arg);

	/// <summary>
	/// If point constraints are enabled, an output scalar indicating the
	/// classification of points can be generated.
	/// </summary>
	public virtual void SetGenerateConstraintScalars(bool _arg)
	{
		vtkPointSmoothingFilter_SetGenerateConstraintScalars_65(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetLocator_66(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkStaticPointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkPointSmoothingFilter_SetLocator_66(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetMaximumStepSize_67(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the maximum smoothing step size for each smoothing iteration. This
	/// step size limits the the distance over which a point can move in each
	/// iteration.  As in all iterative methods, the stability of the process is
	/// sensitive to this parameter. In general, small step size and large
	/// numbers of iterations are more stable than a larger step size and a
	/// smaller numbers of iterations.
	/// </summary>
	public virtual void SetMaximumStepSize(double _arg)
	{
		vtkPointSmoothingFilter_SetMaximumStepSize_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetMotionConstraint_68(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify how to constrain the motion of points. By default, point motion is
	/// unconstrained. Points can also be constrained to a plane. If constrained to
	/// a plane, then an instance of vtkPlane must be specified.
	/// </summary>
	public virtual void SetMotionConstraint(int _arg)
	{
		vtkPointSmoothingFilter_SetMotionConstraint_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetMotionConstraintToPlane_69(HandleRef pThis);

	/// <summary>
	/// Specify how to constrain the motion of points. By default, point motion is
	/// unconstrained. Points can also be constrained to a plane. If constrained to
	/// a plane, then an instance of vtkPlane must be specified.
	/// </summary>
	public void SetMotionConstraintToPlane()
	{
		vtkPointSmoothingFilter_SetMotionConstraintToPlane_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetMotionConstraintToUnconstrained_70(HandleRef pThis);

	/// <summary>
	/// Specify how to constrain the motion of points. By default, point motion is
	/// unconstrained. Points can also be constrained to a plane. If constrained to
	/// a plane, then an instance of vtkPlane must be specified.
	/// </summary>
	public void SetMotionConstraintToUnconstrained()
	{
		vtkPointSmoothingFilter_SetMotionConstraintToUnconstrained_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetNeighborhoodSize_71(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the neighborhood size. This controls the number of surrounding
	/// points that can affect a point to be smoothed.
	/// </summary>
	public virtual void SetNeighborhoodSize(int _arg)
	{
		vtkPointSmoothingFilter_SetNeighborhoodSize_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetNumberOfIterations_72(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of smoothing iterations.
	/// </summary>
	public virtual void SetNumberOfIterations(int _arg)
	{
		vtkPointSmoothingFilter_SetNumberOfIterations_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetNumberOfSubIterations_73(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of smoothing subiterations. This specifies the
	/// frequency of connectivity and data attribute updates.
	/// </summary>
	public virtual void SetNumberOfSubIterations(int _arg)
	{
		vtkPointSmoothingFilter_SetNumberOfSubIterations_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetPackingFactor_74(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the packing factor. Larger numbers tend to loosen the overall
	/// packing of points. Note however that if the point density in a region is
	/// high, then the packing factor may have little effect (due to mutual
	/// inter-particle constraints). The default value is 1.0. (Note that a
	/// characteristic inter-particle radius R is computed at the onset of the
	/// algorithm (or can be manually specified). Within 0&lt;=r&lt;=R*PackingFactor a
	/// repulsive force is generated.)
	/// </summary>
	public virtual void SetPackingFactor(double _arg)
	{
		vtkPointSmoothingFilter_SetPackingFactor_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetPackingRadius_75(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the packing radius R. This only takes effect if
	/// ComputePackingRadius is off. Note that the for two points separated by
	/// radius r, a repulsive force is generated when 0&lt;=r&lt;=R, and a repulsive
	/// force when R&lt;=r&lt;=(1+AttractionFactor*R). By default, the PackingRadius
	/// is automatically computed, but when ComputePackingRadius is off, then
	/// manually setting the PackingRadius is allowed. Note that the
	/// PackingRadius is updated after the algorithm runs (useful to examine the
	/// computed packing radius).
	/// </summary>
	public virtual void SetPackingRadius(double _arg)
	{
		vtkPointSmoothingFilter_SetPackingRadius_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetPlane_76(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the plane to which point motion is constrained. Only required if
	/// MotionConstraint is set to UNCONSTRAINED_MOTION.
	/// </summary>
	public void SetPlane(vtkPlane arg0)
	{
		vtkPointSmoothingFilter_SetPlane_76(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetSmoothingMode_77(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public virtual void SetSmoothingMode(int _arg)
	{
		vtkPointSmoothingFilter_SetSmoothingMode_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToDefault_78(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public void SetSmoothingModeToDefault()
	{
		vtkPointSmoothingFilter_SetSmoothingModeToDefault_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToFrameField_79(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public void SetSmoothingModeToFrameField()
	{
		vtkPointSmoothingFilter_SetSmoothingModeToFrameField_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToGeometric_80(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public void SetSmoothingModeToGeometric()
	{
		vtkPointSmoothingFilter_SetSmoothingModeToGeometric_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToScalars_81(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public void SetSmoothingModeToScalars()
	{
		vtkPointSmoothingFilter_SetSmoothingModeToScalars_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToTensors_82(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public void SetSmoothingModeToTensors()
	{
		vtkPointSmoothingFilter_SetSmoothingModeToTensors_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointSmoothingFilter_SetSmoothingModeToUniform_83(HandleRef pThis);

	/// <summary>
	/// Control how smoothing is to be performed. By default, if a point frame
	/// field is available then frame field smoothing will be performed; then if
	/// point tensors are available then anisotropic tensor smoothing will be
	/// used; the next choice is to use isotropic scalar smoothing; and finally
	/// if no frame field, tensors, or scalars are available, uniform smoothing
	/// will be used. If both scalars, tensors, and /or a frame field are
	/// present, the user can specify which to use; or to use uniform or
	/// geometric smoothing.
	/// </summary>
	public void SetSmoothingModeToUniform()
	{
		vtkPointSmoothingFilter_SetSmoothingModeToUniform_83(GetCppThis());
	}
}
