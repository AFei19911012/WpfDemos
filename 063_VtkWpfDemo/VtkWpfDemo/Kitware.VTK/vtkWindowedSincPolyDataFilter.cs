using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkWindowedSincPolyDataFilter
/// </summary>
/// <remarks>
///    adjust point positions using a windowed sinc function interpolation kernel
///
/// vtkWindowedSincPolyDataFiler adjusts point coordinates using a windowed
/// sinc function interpolation kernel. The effect is to "relax" or "smooth"
/// the mesh, making the cells better shaped and the vertices more evenly
/// distributed.  Note that this filter operates the lines, polygons, and
/// triangle strips composing an instance of vtkPolyData. Vertex or
/// poly-vertex cells are never modified.
///
/// The algorithm proceeds as follows. For each vertex v, a topological and
/// geometric analysis is performed to determine which vertices are connected
/// to v, and which cells are connected to v. Then, a connectivity array is
/// constructed for each vertex. (The connectivity array is a list of lists
/// of vertices that directly attach to each vertex, the so-called smoothing
/// stencil.) Next, an iteration phase begins over all vertices. For each
/// vertex v, the coordinates of v are modified using a windowed sinc function
/// interpolation kernel.  Taubin describes this methodology is the IBM tech
/// report RC-20404 (#90237, dated 3/12/96) "Optimal Surface Smoothing as
/// Filter Design" G. Taubin, T. Zhang and G. Golub. (Zhang and Golub are at
/// Stanford University.)
///
/// This report discusses using standard signal processing low-pass filters
/// (in particular windowed sinc functions) to smooth polyhedra. The
/// transfer functions of the low-pass filters are approximated by
/// Chebyshev polynomials. This facilitates applying the filters in an
/// iterative diffusion process (as opposed to a kernel convolution).  The
/// more smoothing iterations applied, the higher the degree of polynomial
/// approximating the low-pass filter transfer function. Each smoothing
/// iteration, therefore, applies the next higher term of the Chebyshev
/// filter approximation to the polyhedron. This decoupling of the filter
/// into an iteratively applied polynomial is possible since the Chebyshev
/// polynomials are orthogonal, i.e. increasing the order of the
/// approximation to the filter transfer function does not alter the
/// previously calculated coefficients for the low order terms.
///
/// Note: Care must be taken to avoid smoothing with too few iterations.
/// A Chebyshev approximation with too few terms is a poor approximation.
/// The first few smoothing iterations represent a severe scaling and
/// translation of the data.  Subsequent iterations cause the smoothed
/// polyhedron to converge to the true location and scale of the object.
/// We have attempted to protect against this by automatically adjusting
/// the filter, effectively widening the pass band. This adjustment is only
/// possible if the number of iterations is greater than 1.  Note that this
/// sacrifices some degree of smoothing for model integrity. For those
/// interested, the filter is adjusted by searching for a value sigma
/// such that the actual pass band is k_pb + sigma and such that the
/// filter transfer function evaluates to unity at k_pb, i.e. f(k_pb) = 1
///
/// To improve the numerical stability of the solution, and minimize the
/// scaling the translation effects, the algorithm can translate and
/// scale the position coordinates to within the unit cube [-1, 1],
/// perform the smoothing, and translate and scale the position
/// coordinates back to the original coordinate frame.  This mode is
/// controlled with the NormalizeCoordinatesOn() /
/// NormalizeCoordinatesOff() methods.  For legacy reasons, the default
/// is NormalizeCoordinatesOff.
///
/// This implementation is currently limited to using an interpolation
/// kernel based on Hamming windows.  Other windows (such as Hann, Blackman,
/// Kaiser, Lanczos, Gaussian, and exponential windows) could be used
/// instead.
///
/// There are some special instance variables used to control the execution
/// of this filter. (These ivars basically control what vertices can be
/// smoothed, and the creation of the connectivity array.) The
/// BoundarySmoothing ivar enables/disables the smoothing operation on
/// vertices that are on the "boundary" of the mesh. A boundary vertex is one
/// that is surrounded by a semi-cycle of polygons (or used by a single
/// line).
///
/// Another important ivar is FeatureEdgeSmoothing. If this ivar is
/// enabled, then interior vertices are classified as either "simple",
/// "interior edge", or "fixed", and smoothed differently. (Interior
/// vertices are manifold vertices surrounded by a cycle of polygons; or used
/// by two line cells.) The classification is based on the number of feature
/// edges attached to v. A feature edge occurs when the angle between the two
/// surface normals of a polygon sharing an edge is greater than the
/// FeatureAngle ivar. Then, vertices used by no feature edges are classified
/// "simple", vertices used by exactly two feature edges are classified
/// "interior edge", and all others are "fixed" vertices.
///
/// Once the classification is known, the vertices are smoothed
/// differently. Corner (i.e., fixed) vertices are not smoothed at all.
/// Simple vertices are smoothed as before. Interior edge vertices are
/// smoothed only along their two connected edges, and only if the angle
/// between the edges is less than the EdgeAngle ivar.
///
/// The total smoothing can be controlled by using two ivars. The
/// NumberOfIterations determines the maximum number of smoothing passes.
/// The NumberOfIterations corresponds to the degree of the polynomial that
/// is used to approximate the windowed sinc function. Ten or twenty
/// iterations is all the is usually necessary. Contrast this with
/// vtkSmoothPolyDataFilter which usually requires 100 to 200 smoothing
/// iterations. vtkSmoothPolyDataFilter is also not an approximation to
/// an ideal low-pass filter, which can cause the geometry to shrink as the
/// amount of smoothing increases.
///
/// The second ivar is the specification of the PassBand for the windowed
/// sinc filter.  By design, the PassBand is specified as a doubling point
/// number between 0 and 2.  Lower PassBand values produce more smoothing.
/// A good default value for the PassBand is 0.1 (for those interested, the
/// PassBand (and frequencies) for PolyData are based on the valence of the
/// vertices, this limits all the frequency modes in a polyhedral mesh to
/// between 0 and 2.)
///
/// There are two instance variables that control the generation of error
/// data. If the ivar GenerateErrorScalars is on, then a scalar value
/// indicating the distance of each vertex from its original position is
/// computed. If the ivar GenerateErrorVectors is on, then a vector
/// representing change in position is computed.
///
/// @warning
/// The smoothing operation reduces high frequency information in the
/// geometry of the mesh. With excessive smoothing important details may be
/// lost. Enabling FeatureEdgeSmoothing helps reduce this effect, but cannot
/// entirely eliminate it.
///
/// @warning
/// For maximum performance, do not enable BoundarySmoothing,
/// NonManifoldSmoothing, or FeatureEdgeSmoothing. FeatureEdgeSmoothing is
/// particularly expensive as it requires building topological links and
/// computing local polygon normals which are relatively expensive
/// operations. BoundarySmoothing and NonManifoldSmoothing have a modest
/// impact on performance.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential execution type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// Another useful documentation resource is this SIGGRAPH publication:
/// Gabriel Taubin. "A Signal Processing Approach To Fair Surface Design".
///
///
/// vtkSmoothPolyDataFilter vtkConstrainedSmoothingFilter vtkPointSmoothingFilter
/// vtkAttributeSmoothingFilter vtkDecimate vtkDecimatePro vtkQuadricDecimation
/// </seealso>
public class vtkWindowedSincPolyDataFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkWindowedSincPolyDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkWindowedSincPolyDataFilter()
	{
		MRClassNameKey = "class vtkWindowedSincPolyDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowedSincPolyDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkWindowedSincPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowedSincPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with number of iterations 20; passband .1; feature edge
	/// smoothing turned off; feature angle 45 degrees; edge angle 15 degrees;
	/// and boundary smoothing turned on. Error scalars and vectors are not
	/// generated (by default).
	/// </summary>
	public new static vtkWindowedSincPolyDataFilter New()
	{
		vtkWindowedSincPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowedSincPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with number of iterations 20; passband .1; feature edge
	/// smoothing turned off; feature angle 45 degrees; edge angle 15 degrees;
	/// and boundary smoothing turned on. Error scalars and vectors are not
	/// generated (by default).
	/// </summary>
	public vtkWindowedSincPolyDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkWindowedSincPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_BoundarySmoothingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the smoothing of points on the boundary of the mesh.
	/// Enabled this option has a modest impact on performance.
	/// </summary>
	public virtual void BoundarySmoothingOff()
	{
		vtkWindowedSincPolyDataFilter_BoundarySmoothingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_BoundarySmoothingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the smoothing of points on the boundary of the mesh.
	/// Enabled this option has a modest impact on performance.
	/// </summary>
	public virtual void BoundarySmoothingOn()
	{
		vtkWindowedSincPolyDataFilter_BoundarySmoothingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off smoothing points along sharp interior edges. Enabling this
	/// option has a performance impact on the algorithm since neihborhood
	/// information (cell links) and polygon normals must be computed.
	/// </summary>
	public virtual void FeatureEdgeSmoothingOff()
	{
		vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off smoothing points along sharp interior edges. Enabling this
	/// option has a performance impact on the algorithm since neihborhood
	/// information (cell links) and polygon normals must be computed.
	/// </summary>
	public virtual void FeatureEdgeSmoothingOn()
	{
		vtkWindowedSincPolyDataFilter_FeatureEdgeSmoothingOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values.
	/// </summary>
	public virtual void GenerateErrorScalarsOff()
	{
		vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values.
	/// </summary>
	public virtual void GenerateErrorScalarsOn()
	{
		vtkWindowedSincPolyDataFilter_GenerateErrorScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors.
	/// </summary>
	public virtual void GenerateErrorVectorsOff()
	{
		vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors.
	/// </summary>
	public virtual void GenerateErrorVectorsOn()
	{
		vtkWindowedSincPolyDataFilter_GenerateErrorVectorsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetBoundarySmoothing_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the smoothing of points on the boundary of the mesh.
	/// Enabled this option has a modest impact on performance.
	/// </summary>
	public virtual int GetBoundarySmoothing()
	{
		return vtkWindowedSincPolyDataFilter_GetBoundarySmoothing_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngle_10(HandleRef pThis);

	/// <summary>
	/// Specify the edge angle to control smoothing along edges (either interior
	/// or boundary).
	/// </summary>
	public virtual double GetEdgeAngle()
	{
		return vtkWindowedSincPolyDataFilter_GetEdgeAngle_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngleMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the edge angle to control smoothing along edges (either interior
	/// or boundary).
	/// </summary>
	public virtual double GetEdgeAngleMaxValue()
	{
		return vtkWindowedSincPolyDataFilter_GetEdgeAngleMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetEdgeAngleMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the edge angle to control smoothing along edges (either interior
	/// or boundary).
	/// </summary>
	public virtual double GetEdgeAngleMinValue()
	{
		return vtkWindowedSincPolyDataFilter_GetEdgeAngleMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngle_13(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for sharp edge identification. It only affects
	/// the filter when FeatureEdgeSmoothing is enabled.
	/// </summary>
	public virtual double GetFeatureAngle()
	{
		return vtkWindowedSincPolyDataFilter_GetFeatureAngle_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngleMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for sharp edge identification. It only affects
	/// the filter when FeatureEdgeSmoothing is enabled.
	/// </summary>
	public virtual double GetFeatureAngleMaxValue()
	{
		return vtkWindowedSincPolyDataFilter_GetFeatureAngleMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetFeatureAngleMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for sharp edge identification. It only affects
	/// the filter when FeatureEdgeSmoothing is enabled.
	/// </summary>
	public virtual double GetFeatureAngleMinValue()
	{
		return vtkWindowedSincPolyDataFilter_GetFeatureAngleMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetFeatureEdgeSmoothing_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off smoothing points along sharp interior edges. Enabling this
	/// option has a performance impact on the algorithm since neihborhood
	/// information (cell links) and polygon normals must be computed.
	/// </summary>
	public virtual int GetFeatureEdgeSmoothing()
	{
		return vtkWindowedSincPolyDataFilter_GetFeatureEdgeSmoothing_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetGenerateErrorScalars_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values.
	/// </summary>
	public virtual int GetGenerateErrorScalars()
	{
		return vtkWindowedSincPolyDataFilter_GetGenerateErrorScalars_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetGenerateErrorVectors_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors.
	/// </summary>
	public virtual int GetGenerateErrorVectors()
	{
		return vtkWindowedSincPolyDataFilter_GetGenerateErrorVectors_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetNonManifoldSmoothing_19(HandleRef pThis);

	/// <summary>
	/// Smooth non-manifold points. Enabling this option has a modest
	/// impact on performance.
	/// </summary>
	public virtual int GetNonManifoldSmoothing()
	{
		return vtkWindowedSincPolyDataFilter_GetNonManifoldSmoothing_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetNormalizeCoordinates_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off coordinate normalization.  The positions can be translated
	/// and scaled such that they fit within a [-1, 1] prior to the smoothing
	/// computation. The default is off.  The numerical stability of the
	/// solution can be improved by turning normalization on.  If normalization
	/// is on, the coordinates will be rescaled to the original coordinate
	/// system after smoothing has completed.
	/// </summary>
	public virtual int GetNormalizeCoordinates()
	{
		return vtkWindowedSincPolyDataFilter_GetNormalizeCoordinates_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindowedSincPolyDataFilter_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to obtain information, and print information about the
	/// the object.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkWindowedSincPolyDataFilter_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkWindowedSincPolyDataFilter_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	/// Standard methods to obtain information, and print information about the
	/// the object.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkWindowedSincPolyDataFilter_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterations_23(HandleRef pThis);

	/// <summary>
	/// Specify the number of iterations (i.e., the degree of the polynomial
	/// approximating the windowed sinc function). Typically values around 20
	/// are used.
	/// </summary>
	public virtual int GetNumberOfIterations()
	{
		return vtkWindowedSincPolyDataFilter_GetNumberOfIterations_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMaxValue_24(HandleRef pThis);

	/// <summary>
	/// Specify the number of iterations (i.e., the degree of the polynomial
	/// approximating the windowed sinc function). Typically values around 20
	/// are used.
	/// </summary>
	public virtual int GetNumberOfIterationsMaxValue()
	{
		return vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMaxValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMinValue_25(HandleRef pThis);

	/// <summary>
	/// Specify the number of iterations (i.e., the degree of the polynomial
	/// approximating the windowed sinc function). Typically values around 20
	/// are used.
	/// </summary>
	public virtual int GetNumberOfIterationsMinValue()
	{
		return vtkWindowedSincPolyDataFilter_GetNumberOfIterationsMinValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetPassBand_26(HandleRef pThis);

	/// <summary>
	/// Set the passband value for the windowed sinc filter.
	/// </summary>
	public virtual double GetPassBand()
	{
		return vtkWindowedSincPolyDataFilter_GetPassBand_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetPassBandMaxValue_27(HandleRef pThis);

	/// <summary>
	/// Set the passband value for the windowed sinc filter.
	/// </summary>
	public virtual double GetPassBandMaxValue()
	{
		return vtkWindowedSincPolyDataFilter_GetPassBandMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkWindowedSincPolyDataFilter_GetPassBandMinValue_28(HandleRef pThis);

	/// <summary>
	/// Set the passband value for the windowed sinc filter.
	/// </summary>
	public virtual double GetPassBandMinValue()
	{
		return vtkWindowedSincPolyDataFilter_GetPassBandMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_GetWeightNonManifoldEdges_29(HandleRef pThis);

	/// <summary>
	/// When non-manifold smoothing is enabled, better smoothing performance may
	/// be possible by providing extra weighting to non-manifold edges. By default,
	/// WeightNonManifoldEdges is enabled (this is to preserve consistent behavior
	/// with previous versions of this filter).
	/// </summary>
	public virtual int GetWeightNonManifoldEdges()
	{
		return vtkWindowedSincPolyDataFilter_GetWeightNonManifoldEdges_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_IsA_30(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to obtain information, and print information about the
	/// the object.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkWindowedSincPolyDataFilter_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkWindowedSincPolyDataFilter_IsTypeOf_31(string type);

	/// <summary>
	/// Standard methods to obtain information, and print information about the
	/// the object.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkWindowedSincPolyDataFilter_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowedSincPolyDataFilter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to obtain information, and print information about the
	/// the object.
	/// </summary>
	public new vtkWindowedSincPolyDataFilter NewInstance()
	{
		vtkWindowedSincPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowedSincPolyDataFilter_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOff_34(HandleRef pThis);

	/// <summary>
	/// Smooth non-manifold points. Enabling this option has a modest
	/// impact on performance.
	/// </summary>
	public virtual void NonManifoldSmoothingOff()
	{
		vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOn_35(HandleRef pThis);

	/// <summary>
	/// Smooth non-manifold points. Enabling this option has a modest
	/// impact on performance.
	/// </summary>
	public virtual void NonManifoldSmoothingOn()
	{
		vtkWindowedSincPolyDataFilter_NonManifoldSmoothingOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOff_36(HandleRef pThis);

	/// <summary>
	/// Turn on/off coordinate normalization.  The positions can be translated
	/// and scaled such that they fit within a [-1, 1] prior to the smoothing
	/// computation. The default is off.  The numerical stability of the
	/// solution can be improved by turning normalization on.  If normalization
	/// is on, the coordinates will be rescaled to the original coordinate
	/// system after smoothing has completed.
	/// </summary>
	public virtual void NormalizeCoordinatesOff()
	{
		vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOn_37(HandleRef pThis);

	/// <summary>
	/// Turn on/off coordinate normalization.  The positions can be translated
	/// and scaled such that they fit within a [-1, 1] prior to the smoothing
	/// computation. The default is off.  The numerical stability of the
	/// solution can be improved by turning normalization on.  If normalization
	/// is on, the coordinates will be rescaled to the original coordinate
	/// system after smoothing has completed.
	/// </summary>
	public virtual void NormalizeCoordinatesOn()
	{
		vtkWindowedSincPolyDataFilter_NormalizeCoordinatesOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkWindowedSincPolyDataFilter_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to obtain information, and print information about the
	/// the object.
	/// </summary>
	public new static vtkWindowedSincPolyDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkWindowedSincPolyDataFilter vtkWindowedSincPolyDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkWindowedSincPolyDataFilter_SafeDownCast_38(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkWindowedSincPolyDataFilter2 = (vtkWindowedSincPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkWindowedSincPolyDataFilter2.Register(null);
			}
		}
		return vtkWindowedSincPolyDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetBoundarySmoothing_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the smoothing of points on the boundary of the mesh.
	/// Enabled this option has a modest impact on performance.
	/// </summary>
	public virtual void SetBoundarySmoothing(int _arg)
	{
		vtkWindowedSincPolyDataFilter_SetBoundarySmoothing_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetEdgeAngle_40(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the edge angle to control smoothing along edges (either interior
	/// or boundary).
	/// </summary>
	public virtual void SetEdgeAngle(double _arg)
	{
		vtkWindowedSincPolyDataFilter_SetEdgeAngle_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetFeatureAngle_41(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the feature angle for sharp edge identification. It only affects
	/// the filter when FeatureEdgeSmoothing is enabled.
	/// </summary>
	public virtual void SetFeatureAngle(double _arg)
	{
		vtkWindowedSincPolyDataFilter_SetFeatureAngle_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetFeatureEdgeSmoothing_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off smoothing points along sharp interior edges. Enabling this
	/// option has a performance impact on the algorithm since neihborhood
	/// information (cell links) and polygon normals must be computed.
	/// </summary>
	public virtual void SetFeatureEdgeSmoothing(int _arg)
	{
		vtkWindowedSincPolyDataFilter_SetFeatureEdgeSmoothing_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetGenerateErrorScalars_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the generation of scalar distance values.
	/// </summary>
	public virtual void SetGenerateErrorScalars(int _arg)
	{
		vtkWindowedSincPolyDataFilter_SetGenerateErrorScalars_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetGenerateErrorVectors_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the generation of error vectors.
	/// </summary>
	public virtual void SetGenerateErrorVectors(int _arg)
	{
		vtkWindowedSincPolyDataFilter_SetGenerateErrorVectors_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetNonManifoldSmoothing_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Smooth non-manifold points. Enabling this option has a modest
	/// impact on performance.
	/// </summary>
	public virtual void SetNonManifoldSmoothing(int _arg)
	{
		vtkWindowedSincPolyDataFilter_SetNonManifoldSmoothing_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetNormalizeCoordinates_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off coordinate normalization.  The positions can be translated
	/// and scaled such that they fit within a [-1, 1] prior to the smoothing
	/// computation. The default is off.  The numerical stability of the
	/// solution can be improved by turning normalization on.  If normalization
	/// is on, the coordinates will be rescaled to the original coordinate
	/// system after smoothing has completed.
	/// </summary>
	public virtual void SetNormalizeCoordinates(int _arg)
	{
		vtkWindowedSincPolyDataFilter_SetNormalizeCoordinates_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetNumberOfIterations_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of iterations (i.e., the degree of the polynomial
	/// approximating the windowed sinc function). Typically values around 20
	/// are used.
	/// </summary>
	public virtual void SetNumberOfIterations(int _arg)
	{
		vtkWindowedSincPolyDataFilter_SetNumberOfIterations_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetPassBand_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the passband value for the windowed sinc filter.
	/// </summary>
	public virtual void SetPassBand(double _arg)
	{
		vtkWindowedSincPolyDataFilter_SetPassBand_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_SetWeightNonManifoldEdges_49(HandleRef pThis, int _arg);

	/// <summary>
	/// When non-manifold smoothing is enabled, better smoothing performance may
	/// be possible by providing extra weighting to non-manifold edges. By default,
	/// WeightNonManifoldEdges is enabled (this is to preserve consistent behavior
	/// with previous versions of this filter).
	/// </summary>
	public virtual void SetWeightNonManifoldEdges(int _arg)
	{
		vtkWindowedSincPolyDataFilter_SetWeightNonManifoldEdges_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_WeightNonManifoldEdgesOff_50(HandleRef pThis);

	/// <summary>
	/// When non-manifold smoothing is enabled, better smoothing performance may
	/// be possible by providing extra weighting to non-manifold edges. By default,
	/// WeightNonManifoldEdges is enabled (this is to preserve consistent behavior
	/// with previous versions of this filter).
	/// </summary>
	public virtual void WeightNonManifoldEdgesOff()
	{
		vtkWindowedSincPolyDataFilter_WeightNonManifoldEdgesOff_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkWindowedSincPolyDataFilter_WeightNonManifoldEdgesOn_51(HandleRef pThis);

	/// <summary>
	/// When non-manifold smoothing is enabled, better smoothing performance may
	/// be possible by providing extra weighting to non-manifold edges. By default,
	/// WeightNonManifoldEdges is enabled (this is to preserve consistent behavior
	/// with previous versions of this filter).
	/// </summary>
	public virtual void WeightNonManifoldEdgesOn()
	{
		vtkWindowedSincPolyDataFilter_WeightNonManifoldEdgesOn_51(GetCppThis());
	}
}
