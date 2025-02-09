using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVoronoi2D
/// </summary>
/// <remarks>
///    create 2D Voronoi convex tiling of input points
///
/// vtkVoronoi2D is a filter that constructs a 2D Voronoi tessellation of a
/// list of input points. The points are assumed to lie in a plane. These
/// points may be represented by any dataset of type vtkPointSet and
/// subclasses. The output of the filter is a polygonal dataset. Each output
/// cell is a convex polygon.
///
/// The 2D Voronoi tessellation is a tiling of space, where each Voronoi tile
/// represents the region nearest to one of the input points. Voronoi
/// tessellations are important in computational geometry (and many other
/// fields), and are the dual of Delaunay triangulations.
///
/// The input to this filter is a list of points specified in 3D, even though
/// the triangulation is 2D. Thus the triangulation is constructed in the x-y
/// plane, and the z coordinate is ignored (although carried through to the
/// output). If you desire to triangulate in a different plane, you can use
/// the vtkTransformFilter to transform the points into and out of the x-y
/// plane or you can specify a transform to vtkVoronoi2D directly.  In the
/// latter case, the input points are transformed, the transformed points are
/// triangulated, and the output will use the triangulated topology for the
/// original (non-transformed) points.  This avoids transforming the data back
/// as would be required when using the vtkTransformFilter method.  Specifying
/// a transform directly also allows any transform to be used: rigid,
/// non-rigid, non-invertible, etc.
///
/// This filter is a reference implementation written with simplicity in
/// mind. Additional methods are available for debugging / instructional
/// purposes. This includes producing a single tile under various stages of
/// creation, as well as the Voronoi flower, related to the error metric for
/// point insertion / half-space clipping.
///
/// Publications are in preparation to describe the algorithm. A brief summary
/// is as follows. In parallel, each (generating) input point is associated
/// with an initial Voronoi tile, which is simply the bounding box of the
/// point set. A locator is then used to identify nearby points: each neighbor
/// in turn generates a clipping line positioned halfway between the
/// generating point and the neighboring point, and orthogonal to the line
/// connecting them. Clips are readily performed by evaluationg the vertices
/// of the convex Voronoi tile as being on either side (inside,outside) of the
/// clip line. If two intersections of the Voronoi tile are found, the portion
/// of the tile "outside" the clip line is discarded, resulting in a new
/// convex, Voronoi tile. As each clip occurs, the Voronoi "Flower" error
/// metric (the union of error spheres) is compared to the extent of the
/// region containing the neighboring clip points. The clip region (along with
/// the points contained in it) is grown by careful expansion (e.g., outward
/// spiraling iterator over all candidate clip points). When the Voronoi
/// Flower is contained within the clip region, the algorithm terminates and
/// the Voronoi tile is output. Once complete, it is possible to construct the
/// Delaunay triangulation from the Voronoi tessellation. Note that
/// topological and geometric information is used to generate a valid
/// triangulation (e.g., merging points and validating topology).
///
/// @warning
/// Coincident input points will result in overlapping tiles.  This is because
/// the Voronoi tessellation requires unique input points.
///
/// @warning
/// This is a novel approach which implements an embarrassingly parallel
/// algorithm. At the core of the algorithm a locator is used to determine
/// points close to a specified position. A vtkStaticPointLocator2D is used
/// because it is both threaded (when constructed) and supports thread-safe
/// queries. While other locators could be used in principal, they must
/// support thread-safe operations.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkDelaunay2D vtkTransformFilter vtkStaticPointLocator2D
/// </seealso>
public class vtkVoronoi2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Specify a padding for the bounding box of the points. A &gt;0 padding is
	/// necessary in order to create valid Voronoi tiles on the boundary of the
	/// tessellation. The padding is specified as a fraction of the diagonal
	/// length of the bounding box of the points.
	/// </summary>
	public enum GenerateScalarsStrategy
	{
		/// <summary>enum member</summary>
		NONE,
		/// <summary>enum member</summary>
		POINT_IDS,
		/// <summary>enum member</summary>
		THREAD_IDS
	}

	/// <summary>
	/// Set / get the transform which is applied to points to generate a 2D
	/// problem.  This maps a 3D dataset into a 2D dataset where triangulation
	/// can be done on the XY plane.  The points are then tessellated and the
	/// topology of tessellation are used as the output topology.  The output
	/// points are the original (untransformed) points.  The transform can be
	/// any subclass of vtkAbstractTransform (thus it does not need to be a
	/// linear or invertible transform).
	/// </summary>
	public enum ProjectionPlaneStrategy
	{
		/// <summary>enum member</summary>
		BEST_FITTING_PLANE = 2,
		/// <summary>enum member</summary>
		SPECIFIED_TRANSFORM_PLANE = 1,
		/// <summary>enum member</summary>
		XY_PLANE = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVoronoi2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVoronoi2D()
	{
		MRClassNameKey = "class vtkVoronoi2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoronoi2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVoronoi2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoronoi2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkVoronoi2D New()
	{
		vtkVoronoi2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoronoi2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoronoi2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkVoronoi2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVoronoi2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkVoronoi2D_GenerateVoronoiFlowerOff_01(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. If
	/// GenerateVoronoiFlower is on, and the PointOfIntersect is specified, then
	/// second and third (optional) outputs are populated which contains a
	/// representation of the Voronoi flower error metric (second output) and
	/// the single Voronoi tile (corresponding to PointOfInterest) with point
	/// scalar values indicating the radii of the Voronoi Flower petals (i.e.,
	/// circles contributing to the error metric).
	/// </summary>
	public virtual void GenerateVoronoiFlowerOff()
	{
		vtkVoronoi2D_GenerateVoronoiFlowerOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_GenerateVoronoiFlowerOn_02(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. If
	/// GenerateVoronoiFlower is on, and the PointOfIntersect is specified, then
	/// second and third (optional) outputs are populated which contains a
	/// representation of the Voronoi flower error metric (second output) and
	/// the single Voronoi tile (corresponding to PointOfInterest) with point
	/// scalar values indicating the radii of the Voronoi Flower petals (i.e.,
	/// circles contributing to the error metric).
	/// </summary>
	public virtual void GenerateVoronoiFlowerOn()
	{
		vtkVoronoi2D_GenerateVoronoiFlowerOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoronoi2D_GetGenerateScalars_03(HandleRef pThis);

	/// <summary>
	/// Indicate whether to create a scalar array as part of the output. No
	/// scalars; point ids, or execution thread ids may be output. By default no
	/// scalars are generated.
	/// </summary>
	public virtual int GetGenerateScalars()
	{
		return vtkVoronoi2D_GetGenerateScalars_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoronoi2D_GetGenerateVoronoiFlower_04(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. If
	/// GenerateVoronoiFlower is on, and the PointOfIntersect is specified, then
	/// second and third (optional) outputs are populated which contains a
	/// representation of the Voronoi flower error metric (second output) and
	/// the single Voronoi tile (corresponding to PointOfInterest) with point
	/// scalar values indicating the radii of the Voronoi Flower petals (i.e.,
	/// circles contributing to the error metric).
	/// </summary>
	public virtual int GetGenerateVoronoiFlower()
	{
		return vtkVoronoi2D_GetGenerateVoronoiFlower_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoronoi2D_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the internal locator to manually configure it, for example
	/// specifying the number of points per bucket. This method is generally
	/// used for debugging or testing purposes.
	/// </summary>
	public vtkStaticPointLocator2D GetLocator()
	{
		vtkStaticPointLocator2D vtkStaticPointLocator2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoronoi2D_GetLocator_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStaticPointLocator2D2 = (vtkStaticPointLocator2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStaticPointLocator2D2.Register(null);
			}
		}
		return vtkStaticPointLocator2D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkVoronoi2D_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Get the MTime of this object also considering the locator.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkVoronoi2D_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoronoi2D_GetMaximumNumberOfTileClips_07(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. When the
	/// point of interest is specified (i.e., to a non-negative number) then the
	/// algorithm will only process this single point (whose id is the
	/// PointOfInterest). The maximum number of clips (the
	/// MaximumNumberOfTileClips) can be specified. If
	/// MaximumNumberOfTileClips=0, then the initial tile (single point within
	/// the bounding box) is produced; if =1 then the split with the closest
	/// point is produced; and so on. By default the PointOfInterest is set to
	/// (-1), and the number of clips is unlimited (i.e.,
	/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
	/// by the algorithm).
	/// </summary>
	public virtual long GetMaximumNumberOfTileClips()
	{
		return vtkVoronoi2D_GetMaximumNumberOfTileClips_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoronoi2D_GetMaximumNumberOfTileClipsMaxValue_08(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. When the
	/// point of interest is specified (i.e., to a non-negative number) then the
	/// algorithm will only process this single point (whose id is the
	/// PointOfInterest). The maximum number of clips (the
	/// MaximumNumberOfTileClips) can be specified. If
	/// MaximumNumberOfTileClips=0, then the initial tile (single point within
	/// the bounding box) is produced; if =1 then the split with the closest
	/// point is produced; and so on. By default the PointOfInterest is set to
	/// (-1), and the number of clips is unlimited (i.e.,
	/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
	/// by the algorithm).
	/// </summary>
	public virtual long GetMaximumNumberOfTileClipsMaxValue()
	{
		return vtkVoronoi2D_GetMaximumNumberOfTileClipsMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoronoi2D_GetMaximumNumberOfTileClipsMinValue_09(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. When the
	/// point of interest is specified (i.e., to a non-negative number) then the
	/// algorithm will only process this single point (whose id is the
	/// PointOfInterest). The maximum number of clips (the
	/// MaximumNumberOfTileClips) can be specified. If
	/// MaximumNumberOfTileClips=0, then the initial tile (single point within
	/// the bounding box) is produced; if =1 then the split with the closest
	/// point is produced; and so on. By default the PointOfInterest is set to
	/// (-1), and the number of clips is unlimited (i.e.,
	/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
	/// by the algorithm).
	/// </summary>
	public virtual long GetMaximumNumberOfTileClipsMinValue()
	{
		return vtkVoronoi2D_GetMaximumNumberOfTileClipsMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoronoi2D_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVoronoi2D_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoronoi2D_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVoronoi2D_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoronoi2D_GetNumberOfThreadsUsed_12(HandleRef pThis);

	/// <summary>
	///  Return the number of threads actually used during execution. This is
	///  valid only after algorithm execution.
	/// </summary>
	public int GetNumberOfThreadsUsed()
	{
		return vtkVoronoi2D_GetNumberOfThreadsUsed_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoronoi2D_GetPadding_13(HandleRef pThis);

	/// <summary>
	/// Specify a padding for the bounding box of the points. A &gt;0 padding is
	/// necessary in order to create valid Voronoi tiles on the boundary of the
	/// tessellation. The padding is specified as a fraction of the diagonal
	/// length of the bounding box of the points.
	/// </summary>
	public virtual double GetPadding()
	{
		return vtkVoronoi2D_GetPadding_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoronoi2D_GetPaddingMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify a padding for the bounding box of the points. A &gt;0 padding is
	/// necessary in order to create valid Voronoi tiles on the boundary of the
	/// tessellation. The padding is specified as a fraction of the diagonal
	/// length of the bounding box of the points.
	/// </summary>
	public virtual double GetPaddingMaxValue()
	{
		return vtkVoronoi2D_GetPaddingMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkVoronoi2D_GetPaddingMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify a padding for the bounding box of the points. A &gt;0 padding is
	/// necessary in order to create valid Voronoi tiles on the boundary of the
	/// tessellation. The padding is specified as a fraction of the diagonal
	/// length of the bounding box of the points.
	/// </summary>
	public virtual double GetPaddingMinValue()
	{
		return vtkVoronoi2D_GetPaddingMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoronoi2D_GetPointOfInterest_16(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. When the
	/// point of interest is specified (i.e., to a non-negative number) then the
	/// algorithm will only process this single point (whose id is the
	/// PointOfInterest). The maximum number of clips (the
	/// MaximumNumberOfTileClips) can be specified. If
	/// MaximumNumberOfTileClips=0, then the initial tile (single point within
	/// the bounding box) is produced; if =1 then the split with the closest
	/// point is produced; and so on. By default the PointOfInterest is set to
	/// (-1), and the number of clips is unlimited (i.e.,
	/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
	/// by the algorithm).
	/// </summary>
	public virtual long GetPointOfInterest()
	{
		return vtkVoronoi2D_GetPointOfInterest_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoronoi2D_GetPointOfInterestMaxValue_17(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. When the
	/// point of interest is specified (i.e., to a non-negative number) then the
	/// algorithm will only process this single point (whose id is the
	/// PointOfInterest). The maximum number of clips (the
	/// MaximumNumberOfTileClips) can be specified. If
	/// MaximumNumberOfTileClips=0, then the initial tile (single point within
	/// the bounding box) is produced; if =1 then the split with the closest
	/// point is produced; and so on. By default the PointOfInterest is set to
	/// (-1), and the number of clips is unlimited (i.e.,
	/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
	/// by the algorithm).
	/// </summary>
	public virtual long GetPointOfInterestMaxValue()
	{
		return vtkVoronoi2D_GetPointOfInterestMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVoronoi2D_GetPointOfInterestMinValue_18(HandleRef pThis);

	/// <summary>
	/// These methods are for debugging or instructional purposes. When the
	/// point of interest is specified (i.e., to a non-negative number) then the
	/// algorithm will only process this single point (whose id is the
	/// PointOfInterest). The maximum number of clips (the
	/// MaximumNumberOfTileClips) can be specified. If
	/// MaximumNumberOfTileClips=0, then the initial tile (single point within
	/// the bounding box) is produced; if =1 then the split with the closest
	/// point is produced; and so on. By default the PointOfInterest is set to
	/// (-1), and the number of clips is unlimited (i.e.,
	/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
	/// by the algorithm).
	/// </summary>
	public virtual long GetPointOfInterestMinValue()
	{
		return vtkVoronoi2D_GetPointOfInterestMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoronoi2D_GetProjectionPlaneMode_19(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
	/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
	/// supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public virtual int GetProjectionPlaneMode()
	{
		return vtkVoronoi2D_GetProjectionPlaneMode_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoronoi2D_GetProjectionPlaneModeMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
	/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
	/// supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public virtual int GetProjectionPlaneModeMaxValue()
	{
		return vtkVoronoi2D_GetProjectionPlaneModeMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoronoi2D_GetProjectionPlaneModeMinValue_21(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
	/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
	/// supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public virtual int GetProjectionPlaneModeMinValue()
	{
		return vtkVoronoi2D_GetProjectionPlaneModeMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoronoi2D_GetSpheres_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the Voronoi flower (a collection of spheres) for the point of
	/// interest in the form of a vtkSpheres implicit function. This is valid
	/// only if GenerateVoronoiFlower and the PointOfInterest are set, and after
	/// the filter executes. Typically this is used for debugging or educational
	/// purposes.
	/// </summary>
	public virtual vtkSpheres GetSpheres()
	{
		vtkSpheres vtkSpheres2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoronoi2D_GetSpheres_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSpheres2 = (vtkSpheres)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSpheres2.Register(null);
			}
		}
		return vtkSpheres2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoronoi2D_GetTransform_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the transform which is applied to points to generate a 2D
	/// problem.  This maps a 3D dataset into a 2D dataset where triangulation
	/// can be done on the XY plane.  The points are then tessellated and the
	/// topology of tessellation are used as the output topology.  The output
	/// points are the original (untransformed) points.  The transform can be
	/// any subclass of vtkAbstractTransform (thus it does not need to be a
	/// linear or invertible transform).
	/// </summary>
	public virtual vtkAbstractTransform GetTransform()
	{
		vtkAbstractTransform vtkAbstractTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoronoi2D_GetTransform_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractTransform2 = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractTransform2.Register(null);
			}
		}
		return vtkAbstractTransform2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoronoi2D_IsA_24(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVoronoi2D_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVoronoi2D_IsTypeOf_25(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVoronoi2D_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoronoi2D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkVoronoi2D NewInstance()
	{
		vtkVoronoi2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoronoi2D_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVoronoi2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVoronoi2D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkVoronoi2D SafeDownCast(vtkObjectBase o)
	{
		vtkVoronoi2D vtkVoronoi2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVoronoi2D_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVoronoi2D2 = (vtkVoronoi2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVoronoi2D2.Register(null);
			}
		}
		return vtkVoronoi2D2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetGenerateScalars_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether to create a scalar array as part of the output. No
	/// scalars; point ids, or execution thread ids may be output. By default no
	/// scalars are generated.
	/// </summary>
	public virtual void SetGenerateScalars(int _arg)
	{
		vtkVoronoi2D_SetGenerateScalars_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetGenerateScalarsToNone_30(HandleRef pThis);

	/// <summary>
	/// Indicate whether to create a scalar array as part of the output. No
	/// scalars; point ids, or execution thread ids may be output. By default no
	/// scalars are generated.
	/// </summary>
	public void SetGenerateScalarsToNone()
	{
		vtkVoronoi2D_SetGenerateScalarsToNone_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetGenerateScalarsToPointIds_31(HandleRef pThis);

	/// <summary>
	/// Indicate whether to create a scalar array as part of the output. No
	/// scalars; point ids, or execution thread ids may be output. By default no
	/// scalars are generated.
	/// </summary>
	public void SetGenerateScalarsToPointIds()
	{
		vtkVoronoi2D_SetGenerateScalarsToPointIds_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetGenerateScalarsToThreadIds_32(HandleRef pThis);

	/// <summary>
	/// Indicate whether to create a scalar array as part of the output. No
	/// scalars; point ids, or execution thread ids may be output. By default no
	/// scalars are generated.
	/// </summary>
	public void SetGenerateScalarsToThreadIds()
	{
		vtkVoronoi2D_SetGenerateScalarsToThreadIds_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetGenerateVoronoiFlower_33(HandleRef pThis, int _arg);

	/// <summary>
	/// These methods are for debugging or instructional purposes. If
	/// GenerateVoronoiFlower is on, and the PointOfIntersect is specified, then
	/// second and third (optional) outputs are populated which contains a
	/// representation of the Voronoi flower error metric (second output) and
	/// the single Voronoi tile (corresponding to PointOfInterest) with point
	/// scalar values indicating the radii of the Voronoi Flower petals (i.e.,
	/// circles contributing to the error metric).
	/// </summary>
	public virtual void SetGenerateVoronoiFlower(int _arg)
	{
		vtkVoronoi2D_SetGenerateVoronoiFlower_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetMaximumNumberOfTileClips_34(HandleRef pThis, long _arg);

	/// <summary>
	/// These methods are for debugging or instructional purposes. When the
	/// point of interest is specified (i.e., to a non-negative number) then the
	/// algorithm will only process this single point (whose id is the
	/// PointOfInterest). The maximum number of clips (the
	/// MaximumNumberOfTileClips) can be specified. If
	/// MaximumNumberOfTileClips=0, then the initial tile (single point within
	/// the bounding box) is produced; if =1 then the split with the closest
	/// point is produced; and so on. By default the PointOfInterest is set to
	/// (-1), and the number of clips is unlimited (i.e.,
	/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
	/// by the algorithm).
	/// </summary>
	public virtual void SetMaximumNumberOfTileClips(long _arg)
	{
		vtkVoronoi2D_SetMaximumNumberOfTileClips_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetPadding_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify a padding for the bounding box of the points. A &gt;0 padding is
	/// necessary in order to create valid Voronoi tiles on the boundary of the
	/// tessellation. The padding is specified as a fraction of the diagonal
	/// length of the bounding box of the points.
	/// </summary>
	public virtual void SetPadding(double _arg)
	{
		vtkVoronoi2D_SetPadding_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetPointOfInterest_36(HandleRef pThis, long _arg);

	/// <summary>
	/// These methods are for debugging or instructional purposes. When the
	/// point of interest is specified (i.e., to a non-negative number) then the
	/// algorithm will only process this single point (whose id is the
	/// PointOfInterest). The maximum number of clips (the
	/// MaximumNumberOfTileClips) can be specified. If
	/// MaximumNumberOfTileClips=0, then the initial tile (single point within
	/// the bounding box) is produced; if =1 then the split with the closest
	/// point is produced; and so on. By default the PointOfInterest is set to
	/// (-1), and the number of clips is unlimited (i.e.,
	/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
	/// by the algorithm).
	/// </summary>
	public virtual void SetPointOfInterest(long _arg)
	{
		vtkVoronoi2D_SetPointOfInterest_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetProjectionPlaneMode_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
	/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
	/// supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public virtual void SetProjectionPlaneMode(int _arg)
	{
		vtkVoronoi2D_SetProjectionPlaneMode_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetProjectionPlaneModeToBestFittingPlane_38(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
	/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
	/// supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public void SetProjectionPlaneModeToBestFittingPlane()
	{
		vtkVoronoi2D_SetProjectionPlaneModeToBestFittingPlane_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetProjectionPlaneModeToSpecifiedTransformPlane_39(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
	/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
	/// supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public void SetProjectionPlaneModeToSpecifiedTransformPlane()
	{
		vtkVoronoi2D_SetProjectionPlaneModeToSpecifiedTransformPlane_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetProjectionPlaneModeToXYPlane_40(HandleRef pThis);

	/// <summary>
	/// Define the method to project the input 3D points into a 2D plane for
	/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
	/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
	/// supplied and the points are transformed using it. Finally, if
	/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
	/// plane and projects the points onto it.
	/// </summary>
	public void SetProjectionPlaneModeToXYPlane()
	{
		vtkVoronoi2D_SetProjectionPlaneModeToXYPlane_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVoronoi2D_SetTransform_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get the transform which is applied to points to generate a 2D
	/// problem.  This maps a 3D dataset into a 2D dataset where triangulation
	/// can be done on the XY plane.  The points are then tessellated and the
	/// topology of tessellation are used as the output topology.  The output
	/// points are the original (untransformed) points.  The transform can be
	/// any subclass of vtkAbstractTransform (thus it does not need to be a
	/// linear or invertible transform).
	/// </summary>
	public virtual void SetTransform(vtkAbstractTransform arg0)
	{
		vtkVoronoi2D_SetTransform_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
