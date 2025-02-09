using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSmoothPolyDataFilter
/// </summary>
/// <remarks>
///    adjust point positions using Laplacian smoothing
///
/// vtkSmoothPolyDataFilter is a filter that adjusts point coordinates using
/// Laplacian smoothing. The effect is to "relax" the mesh, making the cells
/// better shaped and the vertices more evenly distributed. Note that this
/// filter operates on the lines, polygons, and triangle strips composing an
/// instance of vtkPolyData. Vertex or poly-vertex cells are never modified.
///
/// The algorithm proceeds as follows. For each vertex v, a topological and
/// geometric analysis is performed to determine which vertices are connected
/// to v, and which cells are connected to v. Then, a connectivity array is
/// constructed for each vertex. (The connectivity array is a list of lists
/// of vertices that directly attach to each vertex.) Next, an iteration
/// phase begins over all vertices. For each vertex v, the coordinates of v
/// are modified according to an average of the connected vertices.  (A
/// relaxation factor is available to control the amount of displacement of
/// v).  The process repeats for each vertex. This pass over the list of
/// vertices is a single iteration. Many iterations (generally around 20 or
/// so) are repeated until the desired result is obtained.
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
/// Simple vertices are smoothed as before (i.e., average of connected
/// vertex coordinates). Interior edge vertices are smoothed only along
/// their two connected edges, and only if the angle between the edges
/// is less than the EdgeAngle ivar.
///
/// The total smoothing can be controlled by using two ivars. The
/// NumberOfIterations is a cap on the maximum number of smoothing passes.
/// The Convergence ivar is a limit on the maximum point motion. If the
/// maximum motion during an iteration is less than Convergence, then the
/// smoothing process terminates. (Convergence is expressed as a fraction of
/// the diagonal of the bounding box.)
///
/// There are two instance variables that control the generation of error
/// data. If the ivar GenerateErrorScalars is on, then a scalar value indicating
/// the distance of each vertex from its original position is computed. If the
/// ivar GenerateErrorVectors is on, then a vector representing change in
/// position is computed.
///
/// Optionally you can further control the smoothing process by defining a
/// second input: the Source. If defined, the input mesh is constrained to
/// lie on the surface defined by the Source ivar.
///
///
/// @warning
/// The Laplacian operation reduces high frequency information in the geometry
/// of the mesh. With excessive smoothing important details may be lost, and
/// the surface may shrink towards the centroid. Enabling FeatureEdgeSmoothing
/// helps reduce this effect, but cannot entirely eliminate it. You may also
/// wish to try vtkWindowedSincPolyDataFilter. It does a better job of
/// minimizing shrinkage. Another option is vtkConstrainedSmoothingFilter
/// which limits the distance that points can move.
///
/// </remarks>
/// <seealso>
///
/// vtkWindowedSincPolyDataFilter vtkConstrainedSmoothingFilter
/// vtkDecimate vtkDecimatePro
/// </seealso>
public class vtkSmoothPolyDataFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSmoothPolyDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSmoothPolyDataFilter()
	{
		MRClassNameKey = "class vtkSmoothPolyDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmoothPolyDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSmoothPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmoothPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with number of iterations 20; relaxation factor .01;
	/// feature edge smoothing turned off; feature
	/// angle 45 degrees; edge angle 15 degrees; and boundary smoothing turned
	/// on. Error scalars and vectors are not generated (by default). The
	/// convergence criterion is 0.0 of the bounding box diagonal.
	/// </summary>
	public new static vtkSmoothPolyDataFilter New()
	{
		vtkSmoothPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmoothPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with number of iterations 20; relaxation factor .01;
	/// feature edge smoothing turned off; feature
	/// angle 45 degrees; edge angle 15 degrees; and boundary smoothing turned
	/// on. Error scalars and vectors are not generated (by default). The
	/// convergence criterion is 0.0 of the bounding box diagonal.
	/// </summary>
	public vtkSmoothPolyDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSmoothPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSmoothPolyDataFilter_BoundarySmoothingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off the smoothing of vertices on the boundary of the mesh.
	/// </summary>
	public virtual void BoundarySmoothingOff()
	{
		vtkSmoothPolyDataFilter_BoundarySmoothingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_BoundarySmoothingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off the smoothing of vertices on the boundary of the mesh.
	/// </summary>
	public virtual void BoundarySmoothingOn()
	{
		vtkSmoothPolyDataFilter_BoundarySmoothingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off smoothing along sharp interior edges.
	/// </summary>
	public virtual void FeatureEdgeSmoothingOff()
	{
		vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off smoothing along sharp interior edges.
	/// </summary>
	public virtual void FeatureEdgeSmoothingOn()
	{
		vtkSmoothPolyDataFilter_FeatureEdgeSmoothingOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_GenerateErrorScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values.
	/// </summary>
	public virtual void GenerateErrorScalarsOff()
	{
		vtkSmoothPolyDataFilter_GenerateErrorScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_GenerateErrorScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values.
	/// </summary>
	public virtual void GenerateErrorScalarsOn()
	{
		vtkSmoothPolyDataFilter_GenerateErrorScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_GenerateErrorVectorsOff_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors.
	/// </summary>
	public virtual void GenerateErrorVectorsOff()
	{
		vtkSmoothPolyDataFilter_GenerateErrorVectorsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_GenerateErrorVectorsOn_08(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors.
	/// </summary>
	public virtual void GenerateErrorVectorsOn()
	{
		vtkSmoothPolyDataFilter_GenerateErrorVectorsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_GetBoundarySmoothing_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the smoothing of vertices on the boundary of the mesh.
	/// </summary>
	public virtual int GetBoundarySmoothing()
	{
		return vtkSmoothPolyDataFilter_GetBoundarySmoothing_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetConvergence_10(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration
	/// process. Smaller numbers result in more smoothing iterations.
	/// </summary>
	public virtual double GetConvergence()
	{
		return vtkSmoothPolyDataFilter_GetConvergence_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetConvergenceMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration
	/// process. Smaller numbers result in more smoothing iterations.
	/// </summary>
	public virtual double GetConvergenceMaxValue()
	{
		return vtkSmoothPolyDataFilter_GetConvergenceMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetConvergenceMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify a convergence criterion for the iteration
	/// process. Smaller numbers result in more smoothing iterations.
	/// </summary>
	public virtual double GetConvergenceMinValue()
	{
		return vtkSmoothPolyDataFilter_GetConvergenceMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngle_13(HandleRef pThis);

	/// <summary>
	/// Specify the edge angle to control smoothing along edges (either interior
	/// or boundary).
	/// </summary>
	public virtual double GetEdgeAngle()
	{
		return vtkSmoothPolyDataFilter_GetEdgeAngle_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngleMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the edge angle to control smoothing along edges (either interior
	/// or boundary).
	/// </summary>
	public virtual double GetEdgeAngleMaxValue()
	{
		return vtkSmoothPolyDataFilter_GetEdgeAngleMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetEdgeAngleMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the edge angle to control smoothing along edges (either interior
	/// or boundary).
	/// </summary>
	public virtual double GetEdgeAngleMinValue()
	{
		return vtkSmoothPolyDataFilter_GetEdgeAngleMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngle_16(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for sharp edge identification.
	/// </summary>
	public virtual double GetFeatureAngle()
	{
		return vtkSmoothPolyDataFilter_GetFeatureAngle_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngleMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for sharp edge identification.
	/// </summary>
	public virtual double GetFeatureAngleMaxValue()
	{
		return vtkSmoothPolyDataFilter_GetFeatureAngleMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetFeatureAngleMinValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the feature angle for sharp edge identification.
	/// </summary>
	public virtual double GetFeatureAngleMinValue()
	{
		return vtkSmoothPolyDataFilter_GetFeatureAngleMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_GetFeatureEdgeSmoothing_19(HandleRef pThis);

	/// <summary>
	/// Turn on/off smoothing along sharp interior edges.
	/// </summary>
	public virtual int GetFeatureEdgeSmoothing()
	{
		return vtkSmoothPolyDataFilter_GetFeatureEdgeSmoothing_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_GetGenerateErrorScalars_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of scalar distance values.
	/// </summary>
	public virtual int GetGenerateErrorScalars()
	{
		return vtkSmoothPolyDataFilter_GetGenerateErrorScalars_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_GetGenerateErrorVectors_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off the generation of error vectors.
	/// </summary>
	public virtual int GetGenerateErrorVectors()
	{
		return vtkSmoothPolyDataFilter_GetGenerateErrorVectors_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSmoothPolyDataFilter_GetNumberOfGenerationsFromBase_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to obtain type information, and print the
	/// state of a class instance.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSmoothPolyDataFilter_GetNumberOfGenerationsFromBase_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSmoothPolyDataFilter_GetNumberOfGenerationsFromBaseType_23(string type);

	/// <summary>
	/// Standard methods to obtain type information, and print the
	/// state of a class instance.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSmoothPolyDataFilter_GetNumberOfGenerationsFromBaseType_23(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterations_24(HandleRef pThis);

	/// <summary>
	/// Specify the number of iterations for Laplacian smoothing,
	/// </summary>
	public virtual int GetNumberOfIterations()
	{
		return vtkSmoothPolyDataFilter_GetNumberOfIterations_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterationsMaxValue_25(HandleRef pThis);

	/// <summary>
	/// Specify the number of iterations for Laplacian smoothing,
	/// </summary>
	public virtual int GetNumberOfIterationsMaxValue()
	{
		return vtkSmoothPolyDataFilter_GetNumberOfIterationsMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_GetNumberOfIterationsMinValue_26(HandleRef pThis);

	/// <summary>
	/// Specify the number of iterations for Laplacian smoothing,
	/// </summary>
	public virtual int GetNumberOfIterationsMinValue()
	{
		return vtkSmoothPolyDataFilter_GetNumberOfIterationsMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_GetOutputPointsPrecision_27(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkSmoothPolyDataFilter_GetOutputPointsPrecision_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSmoothPolyDataFilter_GetRelaxationFactor_28(HandleRef pThis);

	/// <summary>
	/// Specify the relaxation factor for Laplacian smoothing. As in all
	/// iterative methods, the stability of the process is sensitive to
	/// this parameter. In general, small relaxation factors and large
	/// numbers of iterations are more stable than larger relaxation
	/// factors and smaller numbers of iterations.
	/// </summary>
	public virtual double GetRelaxationFactor()
	{
		return vtkSmoothPolyDataFilter_GetRelaxationFactor_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmoothPolyDataFilter_GetSource_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the source object which is used to constrain smoothing. The
	/// source defines a surface that the input (as it is smoothed) is
	/// constrained to lie upon.
	/// </summary>
	public vtkPolyData GetSource()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmoothPolyDataFilter_GetSource_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_IsA_30(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods to obtain type information, and print the
	/// state of a class instance.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSmoothPolyDataFilter_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSmoothPolyDataFilter_IsTypeOf_31(string type);

	/// <summary>
	/// Standard methods to obtain type information, and print the
	/// state of a class instance.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSmoothPolyDataFilter_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmoothPolyDataFilter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to obtain type information, and print the
	/// state of a class instance.
	/// </summary>
	public new vtkSmoothPolyDataFilter NewInstance()
	{
		vtkSmoothPolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmoothPolyDataFilter_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSmoothPolyDataFilter_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods to obtain type information, and print the
	/// state of a class instance.
	/// </summary>
	public new static vtkSmoothPolyDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSmoothPolyDataFilter vtkSmoothPolyDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSmoothPolyDataFilter_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSmoothPolyDataFilter2 = (vtkSmoothPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSmoothPolyDataFilter2.Register(null);
			}
		}
		return vtkSmoothPolyDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetBoundarySmoothing_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the smoothing of vertices on the boundary of the mesh.
	/// </summary>
	public virtual void SetBoundarySmoothing(int _arg)
	{
		vtkSmoothPolyDataFilter_SetBoundarySmoothing_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetConvergence_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a convergence criterion for the iteration
	/// process. Smaller numbers result in more smoothing iterations.
	/// </summary>
	public virtual void SetConvergence(double _arg)
	{
		vtkSmoothPolyDataFilter_SetConvergence_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetEdgeAngle_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the edge angle to control smoothing along edges (either interior
	/// or boundary).
	/// </summary>
	public virtual void SetEdgeAngle(double _arg)
	{
		vtkSmoothPolyDataFilter_SetEdgeAngle_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetFeatureAngle_38(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the feature angle for sharp edge identification.
	/// </summary>
	public virtual void SetFeatureAngle(double _arg)
	{
		vtkSmoothPolyDataFilter_SetFeatureAngle_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetFeatureEdgeSmoothing_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off smoothing along sharp interior edges.
	/// </summary>
	public virtual void SetFeatureEdgeSmoothing(int _arg)
	{
		vtkSmoothPolyDataFilter_SetFeatureEdgeSmoothing_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetGenerateErrorScalars_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the generation of scalar distance values.
	/// </summary>
	public virtual void SetGenerateErrorScalars(int _arg)
	{
		vtkSmoothPolyDataFilter_SetGenerateErrorScalars_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetGenerateErrorVectors_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the generation of error vectors.
	/// </summary>
	public virtual void SetGenerateErrorVectors(int _arg)
	{
		vtkSmoothPolyDataFilter_SetGenerateErrorVectors_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetNumberOfIterations_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of iterations for Laplacian smoothing,
	/// </summary>
	public virtual void SetNumberOfIterations(int _arg)
	{
		vtkSmoothPolyDataFilter_SetNumberOfIterations_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetOutputPointsPrecision_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkSmoothPolyDataFilter_SetOutputPointsPrecision_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetRelaxationFactor_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the relaxation factor for Laplacian smoothing. As in all
	/// iterative methods, the stability of the process is sensitive to
	/// this parameter. In general, small relaxation factors and large
	/// numbers of iterations are more stable than larger relaxation
	/// factors and smaller numbers of iterations.
	/// </summary>
	public virtual void SetRelaxationFactor(double _arg)
	{
		vtkSmoothPolyDataFilter_SetRelaxationFactor_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSmoothPolyDataFilter_SetSourceData_45(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Specify the source object which is used to constrain smoothing. The
	/// source defines a surface that the input (as it is smoothed) is
	/// constrained to lie upon.
	/// </summary>
	public void SetSourceData(vtkPolyData source)
	{
		vtkSmoothPolyDataFilter_SetSourceData_45(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}
}
