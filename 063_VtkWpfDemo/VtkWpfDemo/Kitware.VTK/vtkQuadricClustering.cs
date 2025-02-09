using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkQuadricClustering
/// </summary>
/// <remarks>
///    reduce the number of triangles in a mesh
///
/// vtkQuadricClustering is a filter to reduce the number of triangles in a
/// triangle mesh, forming a good approximation to the original geometry.  The
/// input to vtkQuadricClustering is a vtkPolyData object, and all types of
/// polygonal data are handled.
///
/// The algorithm used is the one described by Peter Lindstrom in his Siggraph
/// 2000 paper, "Out-of-Core Simplification of Large Polygonal Models."  The
/// general approach of the algorithm is to cluster vertices in a uniform
/// binning of space, accumulating the quadric of each triangle (pushed out to
/// the triangles vertices) within each bin, and then determining an optimal
/// position for a single vertex in a bin by using the accumulated quadric. In
/// more detail, the algorithm first gets the bounds of the input poly data.
/// It then breaks this bounding volume into a user-specified number of
/// spatial bins.  It then reads each triangle from the input and hashes its
/// vertices into these bins.  (If this is the first time a bin has been
/// visited, initialize its quadric to the 0 matrix.) The algorithm computes
/// the error quadric for this triangle and adds it to the existing quadric of
/// the bin in which each vertex is contained. Then, if 2 or more vertices of
/// the triangle fall in the same bin, the triangle is discarded.  If the
/// triangle is not discarded, it adds the triangle to the list of output
/// triangles as a list of vertex identifiers.  (There is one vertex id per
/// bin.)  After all the triangles have been read, the representative vertex
/// for each bin is computed (an optimal location is found) using the quadric
/// for that bin.  This determines the spatial location of the vertices of
/// each of the triangles in the output.
///
/// To use this filter, specify the divisions defining the spatial subdivision
/// in the x, y, and z directions. You must also specify an input vtkPolyData.
/// Then choose to either 1) use the original points that minimize the quadric
/// error to produce the output triangles or 2) compute an optimal position in
/// each bin to produce the output triangles (recommended and default behavior).
///
/// This filter can take multiple inputs.  To do this, the user must explicitly
/// call StartAppend, Append (once for each input), and EndAppend.  StartAppend
/// sets up the data structure to hold the quadric matrices.  Append processes
/// each triangle in the input poly data it was called on, hashes its vertices
/// to the appropriate bins, determines whether to keep this triangle, and
/// updates the appropriate quadric matrices.  EndAppend determines the spatial
/// location of each of the representative vertices for the visited bins. While
/// this approach does not fit into the visualization architecture and requires
/// manual control, it has the advantage that extremely large data can be
/// processed in pieces and appended to the filter piece-by-piece.
///
/// @warning
/// This filter can drastically affect topology, i.e., topology is not
/// preserved.
///
/// @warning
/// The filter handles input triangle strips and arbitrary polygons. Arbitrary
/// polygons are assumed convex: during insertion they are triangulated using
/// a fan of triangles from the first point in the polygons. If the polygon is
/// concave, this can produce bad results. In this case, use vtkTriangleFilter
/// to triangulate the polygons first.
///
/// @warning
/// The filter also treats polylines and vertices.
///
/// @warning
/// Note that for certain types of geometry (e.g., a mostly 2D plane with
/// jitter in the normal direction), the decimator can perform badly. In this
/// situation, set the number of bins in the normal direction to one.
///
/// @warning
/// vtkBinnedDecimation produces similar results with significant speedup
/// and reduced memory consumption.
///
/// </remarks>
/// <seealso>
///
/// vtkQuadricDecimation vtkDecimatePro vtkDecimate vtkQuadricLODActor
/// vtkBinnedDecimation
/// </seealso>
public class vtkQuadricClustering : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricClustering";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkQuadricClustering()
	{
		MRClassNameKey = "class vtkQuadricClustering";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricClustering"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkQuadricClustering(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricClustering_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static vtkQuadricClustering New()
	{
		vtkQuadricClustering result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricClustering_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public vtkQuadricClustering()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkQuadricClustering_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkQuadricClustering_Append_01(HandleRef pThis, HandleRef piece);

	/// <summary>
	/// These methods provide an alternative way of executing the filter.
	/// PolyData can be added to the result in pieces (append).
	/// In this mode, the user must specify the bounds of the entire model
	/// as an argument to the "StartAppend" method.
	/// </summary>
	public void Append(vtkPolyData piece)
	{
		vtkQuadricClustering_Append_01(GetCppThis(), piece?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_AutoAdjustNumberOfDivisionsOff_02(HandleRef pThis);

	/// <summary>
	/// Enable automatic adjustment of number of divisions. If off, the number
	/// of divisions specified by the user is always used (as long as it is valid).
	/// The default is On
	/// </summary>
	public virtual void AutoAdjustNumberOfDivisionsOff()
	{
		vtkQuadricClustering_AutoAdjustNumberOfDivisionsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_AutoAdjustNumberOfDivisionsOn_03(HandleRef pThis);

	/// <summary>
	/// Enable automatic adjustment of number of divisions. If off, the number
	/// of divisions specified by the user is always used (as long as it is valid).
	/// The default is On
	/// </summary>
	public virtual void AutoAdjustNumberOfDivisionsOn()
	{
		vtkQuadricClustering_AutoAdjustNumberOfDivisionsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_CopyCellDataOff_04(HandleRef pThis);

	/// <summary>
	/// This flag makes the filter copy cell data from input to output
	/// (the best it can).  It uses input cells that trigger the addition
	/// of output cells (no averaging).  This is off by default, and does
	/// not work when append is being called explicitly (non-pipeline usage).
	/// </summary>
	public virtual void CopyCellDataOff()
	{
		vtkQuadricClustering_CopyCellDataOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_CopyCellDataOn_05(HandleRef pThis);

	/// <summary>
	/// This flag makes the filter copy cell data from input to output
	/// (the best it can).  It uses input cells that trigger the addition
	/// of output cells (no averaging).  This is off by default, and does
	/// not work when append is being called explicitly (non-pipeline usage).
	/// </summary>
	public virtual void CopyCellDataOn()
	{
		vtkQuadricClustering_CopyCellDataOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_EndAppend_06(HandleRef pThis);

	/// <summary>
	/// These methods provide an alternative way of executing the filter.
	/// PolyData can be added to the result in pieces (append).
	/// In this mode, the user must specify the bounds of the entire model
	/// as an argument to the "StartAppend" method.
	/// </summary>
	public void EndAppend()
	{
		vtkQuadricClustering_EndAppend_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetAutoAdjustNumberOfDivisions_07(HandleRef pThis);

	/// <summary>
	/// Enable automatic adjustment of number of divisions. If off, the number
	/// of divisions specified by the user is always used (as long as it is valid).
	/// The default is On
	/// </summary>
	public virtual int GetAutoAdjustNumberOfDivisions()
	{
		return vtkQuadricClustering_GetAutoAdjustNumberOfDivisions_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetCopyCellData_08(HandleRef pThis);

	/// <summary>
	/// This flag makes the filter copy cell data from input to output
	/// (the best it can).  It uses input cells that trigger the addition
	/// of output cells (no averaging).  This is off by default, and does
	/// not work when append is being called explicitly (non-pipeline usage).
	/// </summary>
	public virtual int GetCopyCellData()
	{
		return vtkQuadricClustering_GetCopyCellData_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricClustering_GetDivisionOrigin_09(HandleRef pThis);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public virtual double[] GetDivisionOrigin()
	{
		IntPtr intPtr = vtkQuadricClustering_GetDivisionOrigin_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_GetDivisionOrigin_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public virtual void GetDivisionOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkQuadricClustering_GetDivisionOrigin_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_GetDivisionOrigin_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public virtual void GetDivisionOrigin(IntPtr _arg)
	{
		vtkQuadricClustering_GetDivisionOrigin_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricClustering_GetDivisionSpacing_12(HandleRef pThis);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public virtual double[] GetDivisionSpacing()
	{
		IntPtr intPtr = vtkQuadricClustering_GetDivisionSpacing_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_GetDivisionSpacing_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public virtual void GetDivisionSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkQuadricClustering_GetDivisionSpacing_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_GetDivisionSpacing_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public virtual void GetDivisionSpacing(IntPtr _arg)
	{
		vtkQuadricClustering_GetDivisionSpacing_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricClustering_GetFeatureEdges_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By default, this flag is off.  When "UseFeatureEdges" is on, then
	/// quadrics are computed for boundary edges/feature edges.  They influence
	/// the quadrics (position of points), but not the mesh.  Which features to
	/// use can be controlled by the filter "FeatureEdges".
	/// </summary>
	public vtkFeatureEdges GetFeatureEdges()
	{
		vtkFeatureEdges vtkFeatureEdges2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricClustering_GetFeatureEdges_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFeatureEdges2 = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFeatureEdges2.Register(null);
			}
		}
		return vtkFeatureEdges2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricClustering_GetFeaturePointsAngle_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the angle to use in determining whether a point on a boundary /
	/// feature edge is a feature point.
	/// </summary>
	public virtual double GetFeaturePointsAngle()
	{
		return vtkQuadricClustering_GetFeaturePointsAngle_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricClustering_GetFeaturePointsAngleMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the angle to use in determining whether a point on a boundary /
	/// feature edge is a feature point.
	/// </summary>
	public virtual double GetFeaturePointsAngleMaxValue()
	{
		return vtkQuadricClustering_GetFeaturePointsAngleMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkQuadricClustering_GetFeaturePointsAngleMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the angle to use in determining whether a point on a boundary /
	/// feature edge is a feature point.
	/// </summary>
	public virtual double GetFeaturePointsAngleMinValue()
	{
		return vtkQuadricClustering_GetFeaturePointsAngleMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricClustering_GetNumberOfDivisions_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public int[] GetNumberOfDivisions()
	{
		IntPtr intPtr = vtkQuadricClustering_GetNumberOfDivisions_19(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_GetNumberOfDivisions_20(HandleRef pThis, IntPtr div);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public void GetNumberOfDivisions(IntPtr div)
	{
		vtkQuadricClustering_GetNumberOfDivisions_20(GetCppThis(), div);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadricClustering_GetNumberOfGenerationsFromBase_21(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkQuadricClustering_GetNumberOfGenerationsFromBase_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkQuadricClustering_GetNumberOfGenerationsFromBaseType_22(string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkQuadricClustering_GetNumberOfGenerationsFromBaseType_22(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetNumberOfXDivisions_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public virtual int GetNumberOfXDivisions()
	{
		return vtkQuadricClustering_GetNumberOfXDivisions_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetNumberOfYDivisions_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public virtual int GetNumberOfYDivisions()
	{
		return vtkQuadricClustering_GetNumberOfYDivisions_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetNumberOfZDivisions_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public virtual int GetNumberOfZDivisions()
	{
		return vtkQuadricClustering_GetNumberOfZDivisions_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetPreventDuplicateCells_26(HandleRef pThis);

	/// <summary>
	/// Specify a boolean indicating whether to remove duplicate cells
	/// (i.e. triangles).  This is a little slower, and takes more memory, but
	/// in some cases can reduce the number of cells produced by an order of
	/// magnitude. By default, this flag is true.
	/// </summary>
	public virtual int GetPreventDuplicateCells()
	{
		return vtkQuadricClustering_GetPreventDuplicateCells_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetUseFeatureEdges_27(HandleRef pThis);

	/// <summary>
	/// By default, this flag is off.  When "UseFeatureEdges" is on, then
	/// quadrics are computed for boundary edges/feature edges.  They influence
	/// the quadrics (position of points), but not the mesh.  Which features to
	/// use can be controlled by the filter "FeatureEdges".
	/// </summary>
	public virtual int GetUseFeatureEdges()
	{
		return vtkQuadricClustering_GetUseFeatureEdges_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetUseFeaturePoints_28(HandleRef pThis);

	/// <summary>
	/// By default, this flag is off.  It only has an effect when
	/// "UseFeatureEdges" is also on.  When "UseFeaturePoints" is on, then
	/// quadrics are computed for boundary / feature points used in the boundary
	/// / feature edges.  They influence the quadrics (position of points), but
	/// not the mesh.
	/// </summary>
	public virtual int GetUseFeaturePoints()
	{
		return vtkQuadricClustering_GetUseFeaturePoints_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetUseInputPoints_29(HandleRef pThis);

	/// <summary>
	/// Normally the point that minimizes the quadric error function is used as
	/// the output of the bin.  When this flag is on, the bin point is forced to
	/// be one of the points from the input (the one with the smallest
	/// error). This option does not work (i.e., input points cannot be used)
	/// when the append methods (StartAppend(), Append(), EndAppend()) are being
	/// called directly.
	/// </summary>
	public virtual int GetUseInputPoints()
	{
		return vtkQuadricClustering_GetUseInputPoints_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_GetUseInternalTriangles_30(HandleRef pThis);

	/// <summary>
	/// When this flag is on (and it is on by default), then triangles that are
	/// completely contained in a bin are added to the bin quadrics.  When the
	/// the flag is off the filter operates faster, but the surface may not be
	/// as well behaved.
	/// </summary>
	public virtual int GetUseInternalTriangles()
	{
		return vtkQuadricClustering_GetUseInternalTriangles_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_IsA_31(HandleRef pThis, string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkQuadricClustering_IsA_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkQuadricClustering_IsTypeOf_32(string type);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkQuadricClustering_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricClustering_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new vtkQuadricClustering NewInstance()
	{
		vtkQuadricClustering result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricClustering_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_PreventDuplicateCellsOff_35(HandleRef pThis);

	/// <summary>
	/// Specify a boolean indicating whether to remove duplicate cells
	/// (i.e. triangles).  This is a little slower, and takes more memory, but
	/// in some cases can reduce the number of cells produced by an order of
	/// magnitude. By default, this flag is true.
	/// </summary>
	public virtual void PreventDuplicateCellsOff()
	{
		vtkQuadricClustering_PreventDuplicateCellsOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_PreventDuplicateCellsOn_36(HandleRef pThis);

	/// <summary>
	/// Specify a boolean indicating whether to remove duplicate cells
	/// (i.e. triangles).  This is a little slower, and takes more memory, but
	/// in some cases can reduce the number of cells produced by an order of
	/// magnitude. By default, this flag is true.
	/// </summary>
	public virtual void PreventDuplicateCellsOn()
	{
		vtkQuadricClustering_PreventDuplicateCellsOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkQuadricClustering_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard instantiation, type and print methods.
	/// </summary>
	public new static vtkQuadricClustering SafeDownCast(vtkObjectBase o)
	{
		vtkQuadricClustering vtkQuadricClustering2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkQuadricClustering_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkQuadricClustering2 = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkQuadricClustering2.Register(null);
			}
		}
		return vtkQuadricClustering2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetAutoAdjustNumberOfDivisions_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable automatic adjustment of number of divisions. If off, the number
	/// of divisions specified by the user is always used (as long as it is valid).
	/// The default is On
	/// </summary>
	public virtual void SetAutoAdjustNumberOfDivisions(int _arg)
	{
		vtkQuadricClustering_SetAutoAdjustNumberOfDivisions_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetCopyCellData_39(HandleRef pThis, int _arg);

	/// <summary>
	/// This flag makes the filter copy cell data from input to output
	/// (the best it can).  It uses input cells that trigger the addition
	/// of output cells (no averaging).  This is off by default, and does
	/// not work when append is being called explicitly (non-pipeline usage).
	/// </summary>
	public virtual void SetCopyCellData(int _arg)
	{
		vtkQuadricClustering_SetCopyCellData_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetDivisionOrigin_40(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public void SetDivisionOrigin(double x, double y, double z)
	{
		vtkQuadricClustering_SetDivisionOrigin_40(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetDivisionOrigin_41(HandleRef pThis, IntPtr o);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public void SetDivisionOrigin(IntPtr o)
	{
		vtkQuadricClustering_SetDivisionOrigin_41(GetCppThis(), o);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetDivisionSpacing_42(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public void SetDivisionSpacing(double x, double y, double z)
	{
		vtkQuadricClustering_SetDivisionSpacing_42(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetDivisionSpacing_43(HandleRef pThis, IntPtr s);

	/// <summary>
	/// This is an alternative way to set up the bins.  If you are trying to match
	/// boundaries between pieces, then you should use these methods rather than
	/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
	/// of the spatial binning.
	/// </summary>
	public void SetDivisionSpacing(IntPtr s)
	{
		vtkQuadricClustering_SetDivisionSpacing_43(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetFeaturePointsAngle_44(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the angle to use in determining whether a point on a boundary /
	/// feature edge is a feature point.
	/// </summary>
	public virtual void SetFeaturePointsAngle(double _arg)
	{
		vtkQuadricClustering_SetFeaturePointsAngle_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetNumberOfDivisions_45(HandleRef pThis, IntPtr div);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public void SetNumberOfDivisions(IntPtr div)
	{
		vtkQuadricClustering_SetNumberOfDivisions_45(GetCppThis(), div);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetNumberOfDivisions_46(HandleRef pThis, int div0, int div1, int div2);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public void SetNumberOfDivisions(int div0, int div1, int div2)
	{
		vtkQuadricClustering_SetNumberOfDivisions_46(GetCppThis(), div0, div1, div2);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetNumberOfXDivisions_47(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public void SetNumberOfXDivisions(int num)
	{
		vtkQuadricClustering_SetNumberOfXDivisions_47(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetNumberOfYDivisions_48(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public void SetNumberOfYDivisions(int num)
	{
		vtkQuadricClustering_SetNumberOfYDivisions_48(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetNumberOfZDivisions_49(HandleRef pThis, int num);

	/// <summary>
	/// Set/Get the number of divisions along each axis for the spatial bins.
	/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
	/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
	/// divisions if the input has few points and AutoAdjustNumberOfDivisions
	/// is enabled.
	/// </summary>
	public void SetNumberOfZDivisions(int num)
	{
		vtkQuadricClustering_SetNumberOfZDivisions_49(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetPreventDuplicateCells_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify a boolean indicating whether to remove duplicate cells
	/// (i.e. triangles).  This is a little slower, and takes more memory, but
	/// in some cases can reduce the number of cells produced by an order of
	/// magnitude. By default, this flag is true.
	/// </summary>
	public virtual void SetPreventDuplicateCells(int _arg)
	{
		vtkQuadricClustering_SetPreventDuplicateCells_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetUseFeatureEdges_51(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, this flag is off.  When "UseFeatureEdges" is on, then
	/// quadrics are computed for boundary edges/feature edges.  They influence
	/// the quadrics (position of points), but not the mesh.  Which features to
	/// use can be controlled by the filter "FeatureEdges".
	/// </summary>
	public virtual void SetUseFeatureEdges(int _arg)
	{
		vtkQuadricClustering_SetUseFeatureEdges_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetUseFeaturePoints_52(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, this flag is off.  It only has an effect when
	/// "UseFeatureEdges" is also on.  When "UseFeaturePoints" is on, then
	/// quadrics are computed for boundary / feature points used in the boundary
	/// / feature edges.  They influence the quadrics (position of points), but
	/// not the mesh.
	/// </summary>
	public virtual void SetUseFeaturePoints(int _arg)
	{
		vtkQuadricClustering_SetUseFeaturePoints_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetUseInputPoints_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Normally the point that minimizes the quadric error function is used as
	/// the output of the bin.  When this flag is on, the bin point is forced to
	/// be one of the points from the input (the one with the smallest
	/// error). This option does not work (i.e., input points cannot be used)
	/// when the append methods (StartAppend(), Append(), EndAppend()) are being
	/// called directly.
	/// </summary>
	public virtual void SetUseInputPoints(int _arg)
	{
		vtkQuadricClustering_SetUseInputPoints_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_SetUseInternalTriangles_54(HandleRef pThis, int _arg);

	/// <summary>
	/// When this flag is on (and it is on by default), then triangles that are
	/// completely contained in a bin are added to the bin quadrics.  When the
	/// the flag is off the filter operates faster, but the surface may not be
	/// as well behaved.
	/// </summary>
	public virtual void SetUseInternalTriangles(int _arg)
	{
		vtkQuadricClustering_SetUseInternalTriangles_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_StartAppend_55(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// These methods provide an alternative way of executing the filter.
	/// PolyData can be added to the result in pieces (append).
	/// In this mode, the user must specify the bounds of the entire model
	/// as an argument to the "StartAppend" method.
	/// </summary>
	public void StartAppend(IntPtr bounds)
	{
		vtkQuadricClustering_StartAppend_55(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_StartAppend_56(HandleRef pThis, double x0, double x1, double y0, double y1, double z0, double z1);

	/// <summary>
	/// These methods provide an alternative way of executing the filter.
	/// PolyData can be added to the result in pieces (append).
	/// In this mode, the user must specify the bounds of the entire model
	/// as an argument to the "StartAppend" method.
	/// </summary>
	public void StartAppend(double x0, double x1, double y0, double y1, double z0, double z1)
	{
		vtkQuadricClustering_StartAppend_56(GetCppThis(), x0, x1, y0, y1, z0, z1);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_UseFeatureEdgesOff_57(HandleRef pThis);

	/// <summary>
	/// By default, this flag is off.  When "UseFeatureEdges" is on, then
	/// quadrics are computed for boundary edges/feature edges.  They influence
	/// the quadrics (position of points), but not the mesh.  Which features to
	/// use can be controlled by the filter "FeatureEdges".
	/// </summary>
	public virtual void UseFeatureEdgesOff()
	{
		vtkQuadricClustering_UseFeatureEdgesOff_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_UseFeatureEdgesOn_58(HandleRef pThis);

	/// <summary>
	/// By default, this flag is off.  When "UseFeatureEdges" is on, then
	/// quadrics are computed for boundary edges/feature edges.  They influence
	/// the quadrics (position of points), but not the mesh.  Which features to
	/// use can be controlled by the filter "FeatureEdges".
	/// </summary>
	public virtual void UseFeatureEdgesOn()
	{
		vtkQuadricClustering_UseFeatureEdgesOn_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_UseFeaturePointsOff_59(HandleRef pThis);

	/// <summary>
	/// By default, this flag is off.  It only has an effect when
	/// "UseFeatureEdges" is also on.  When "UseFeaturePoints" is on, then
	/// quadrics are computed for boundary / feature points used in the boundary
	/// / feature edges.  They influence the quadrics (position of points), but
	/// not the mesh.
	/// </summary>
	public virtual void UseFeaturePointsOff()
	{
		vtkQuadricClustering_UseFeaturePointsOff_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_UseFeaturePointsOn_60(HandleRef pThis);

	/// <summary>
	/// By default, this flag is off.  It only has an effect when
	/// "UseFeatureEdges" is also on.  When "UseFeaturePoints" is on, then
	/// quadrics are computed for boundary / feature points used in the boundary
	/// / feature edges.  They influence the quadrics (position of points), but
	/// not the mesh.
	/// </summary>
	public virtual void UseFeaturePointsOn()
	{
		vtkQuadricClustering_UseFeaturePointsOn_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_UseInputPointsOff_61(HandleRef pThis);

	/// <summary>
	/// Normally the point that minimizes the quadric error function is used as
	/// the output of the bin.  When this flag is on, the bin point is forced to
	/// be one of the points from the input (the one with the smallest
	/// error). This option does not work (i.e., input points cannot be used)
	/// when the append methods (StartAppend(), Append(), EndAppend()) are being
	/// called directly.
	/// </summary>
	public virtual void UseInputPointsOff()
	{
		vtkQuadricClustering_UseInputPointsOff_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_UseInputPointsOn_62(HandleRef pThis);

	/// <summary>
	/// Normally the point that minimizes the quadric error function is used as
	/// the output of the bin.  When this flag is on, the bin point is forced to
	/// be one of the points from the input (the one with the smallest
	/// error). This option does not work (i.e., input points cannot be used)
	/// when the append methods (StartAppend(), Append(), EndAppend()) are being
	/// called directly.
	/// </summary>
	public virtual void UseInputPointsOn()
	{
		vtkQuadricClustering_UseInputPointsOn_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_UseInternalTrianglesOff_63(HandleRef pThis);

	/// <summary>
	/// When this flag is on (and it is on by default), then triangles that are
	/// completely contained in a bin are added to the bin quadrics.  When the
	/// the flag is off the filter operates faster, but the surface may not be
	/// as well behaved.
	/// </summary>
	public virtual void UseInternalTrianglesOff()
	{
		vtkQuadricClustering_UseInternalTrianglesOff_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkQuadricClustering_UseInternalTrianglesOn_64(HandleRef pThis);

	/// <summary>
	/// When this flag is on (and it is on by default), then triangles that are
	/// completely contained in a bin are added to the bin quadrics.  When the
	/// the flag is off the filter operates faster, but the surface may not be
	/// as well behaved.
	/// </summary>
	public virtual void UseInternalTrianglesOn()
	{
		vtkQuadricClustering_UseInternalTrianglesOn_64(GetCppThis());
	}
}
