using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDecimatePro
/// </summary>
/// <remarks>
///    reduce the number of triangles in a mesh
///
/// vtkDecimatePro is a filter to reduce the number of triangles in a triangle
/// mesh, forming a good approximation to the original geometry. The input to
/// vtkDecimatePro is a vtkPolyData object, and only triangles are treated. If
/// you desire to decimate polygonal meshes, first triangulate the polygons
/// with vtkTriangleFilter object.
///
/// The implementation of vtkDecimatePro is similar to the algorithm
/// originally described in "Decimation of Triangle Meshes", Proc Siggraph
/// `92, with three major differences. First, this algorithm does not
/// necessarily preserve the topology of the mesh. Second, it is guaranteed to
/// give the a mesh reduction factor specified by the user (as long as certain
/// constraints are not set - see Caveats). Third, it is set up generate
/// progressive meshes, that is a stream of operations that can be easily
/// transmitted and incrementally updated (see Hugues Hoppe's Siggraph '96
/// paper on progressive meshes).
///
/// The algorithm proceeds as follows. Each vertex in the mesh is classified
/// and inserted into a priority queue. The priority is based on the error to
/// delete the vertex and retriangulate the hole. Vertices that cannot be
/// deleted or triangulated (at this point in the algorithm) are
/// skipped. Then, each vertex in the priority queue is processed (i.e.,
/// deleted followed by hole triangulation using edge collapse). This
/// continues until the priority queue is empty. Next, all remaining vertices
/// are processed, and the mesh is split into separate pieces along sharp
/// edges or at non-manifold attachment points and reinserted into the
/// priority queue. Again, the priority queue is processed until empty. If
/// the desired reduction is still not achieved, the remaining vertices are
/// split as necessary (in a recursive fashion) so that it is possible to
/// eliminate every triangle as necessary.
///
/// To use this object, at a minimum you need to specify the ivar
/// TargetReduction. The algorithm is guaranteed to generate a reduced mesh
/// at this level as long as the following four conditions are met: 1)
/// topology modification is allowed (i.e., the ivar PreserveTopology is off);
/// 2) mesh splitting is enabled (i.e., the ivar Splitting is on); 3) the
/// algorithm is allowed to modify the boundary of the mesh (i.e., the ivar
/// BoundaryVertexDeletion is on); and 4) the maximum allowable error (i.e.,
/// the ivar MaximumError) is set to VTK_DOUBLE_MAX.  Other important
/// parameters to adjust include the FeatureAngle and SplitAngle ivars, since
/// these can impact the quality of the final mesh. Also, you can set the
/// ivar AccumulateError to force incremental error update and distribution
/// to surrounding vertices as each vertex is deleted. The accumulated error
/// is a conservative global error bounds and decimation error, but requires
/// additional memory and time to compute.
///
/// @warning
/// To guarantee a given level of reduction, the ivar PreserveTopology must
/// be off; the ivar Splitting is on; the ivar BoundaryVertexDeletion is on;
/// and the ivar MaximumError is set to VTK_DOUBLE_MAX.
///
/// @warning
/// If PreserveTopology is off, and SplitEdges is off; the mesh topology may
/// be modified by closing holes.
///
/// @warning
/// Once mesh splitting begins, the feature angle is set to the split angle.
///
/// </remarks>
/// <seealso>
///
/// vtkDecimate vtkQuadricClustering vtkQuadricDecimation
/// </seealso>
public class vtkDecimatePro : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDecimatePro";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDecimatePro()
	{
		MRClassNameKey = "class vtkDecimatePro";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDecimatePro"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDecimatePro(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDecimatePro_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create object with specified reduction of 90% and feature angle of
	/// 15 degrees. Edge splitting is on, defer splitting is on, and the
	/// split angle is 75 degrees. Topology preservation is off, delete
	/// boundary vertices is on, and the maximum error is set to
	/// VTK_DOUBLE_MAX. The inflection point ratio is 10 and the vertex
	/// degree is 25. Error accumulation is turned off.
	/// </summary>
	public new static vtkDecimatePro New()
	{
		vtkDecimatePro result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDecimatePro_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create object with specified reduction of 90% and feature angle of
	/// 15 degrees. Edge splitting is on, defer splitting is on, and the
	/// split angle is 75 degrees. Topology preservation is off, delete
	/// boundary vertices is on, and the maximum error is set to
	/// VTK_DOUBLE_MAX. The inflection point ratio is 10 and the vertex
	/// degree is 25. Error accumulation is turned off.
	/// </summary>
	public vtkDecimatePro()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDecimatePro_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDecimatePro_AccumulateErrorOff_01(HandleRef pThis);

	/// <summary>
	/// The computed error can either be computed directly from the mesh
	/// or the error may be accumulated as the mesh is modified. If the error
	/// is accumulated, then it represents a global error bounds, and the ivar
	/// MaximumError becomes a global bounds on mesh error. Accumulating the
	/// error requires extra memory proportional to the number of vertices in
	/// the mesh. If AccumulateError is off, then the error is not accumulated.
	/// </summary>
	public virtual void AccumulateErrorOff()
	{
		vtkDecimatePro_AccumulateErrorOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_AccumulateErrorOn_02(HandleRef pThis);

	/// <summary>
	/// The computed error can either be computed directly from the mesh
	/// or the error may be accumulated as the mesh is modified. If the error
	/// is accumulated, then it represents a global error bounds, and the ivar
	/// MaximumError becomes a global bounds on mesh error. Accumulating the
	/// error requires extra memory proportional to the number of vertices in
	/// the mesh. If AccumulateError is off, then the error is not accumulated.
	/// </summary>
	public virtual void AccumulateErrorOn()
	{
		vtkDecimatePro_AccumulateErrorOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_BoundaryVertexDeletionOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the deletion of vertices on the boundary of a mesh. This
	/// may limit the maximum reduction that may be achieved.
	/// </summary>
	public virtual void BoundaryVertexDeletionOff()
	{
		vtkDecimatePro_BoundaryVertexDeletionOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_BoundaryVertexDeletionOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the deletion of vertices on the boundary of a mesh. This
	/// may limit the maximum reduction that may be achieved.
	/// </summary>
	public virtual void BoundaryVertexDeletionOn()
	{
		vtkDecimatePro_BoundaryVertexDeletionOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetAbsoluteError_05(HandleRef pThis);

	/// <summary>
	/// Same as MaximumError, but to be used when ErrorIsAbsolute is 1
	/// </summary>
	public virtual double GetAbsoluteError()
	{
		return vtkDecimatePro_GetAbsoluteError_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetAbsoluteErrorMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Same as MaximumError, but to be used when ErrorIsAbsolute is 1
	/// </summary>
	public virtual double GetAbsoluteErrorMaxValue()
	{
		return vtkDecimatePro_GetAbsoluteErrorMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetAbsoluteErrorMinValue_07(HandleRef pThis);

	/// <summary>
	/// Same as MaximumError, but to be used when ErrorIsAbsolute is 1
	/// </summary>
	public virtual double GetAbsoluteErrorMinValue()
	{
		return vtkDecimatePro_GetAbsoluteErrorMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetAccumulateError_08(HandleRef pThis);

	/// <summary>
	/// The computed error can either be computed directly from the mesh
	/// or the error may be accumulated as the mesh is modified. If the error
	/// is accumulated, then it represents a global error bounds, and the ivar
	/// MaximumError becomes a global bounds on mesh error. Accumulating the
	/// error requires extra memory proportional to the number of vertices in
	/// the mesh. If AccumulateError is off, then the error is not accumulated.
	/// </summary>
	public virtual int GetAccumulateError()
	{
		return vtkDecimatePro_GetAccumulateError_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetBoundaryVertexDeletion_09(HandleRef pThis);

	/// <summary>
	/// Turn on/off the deletion of vertices on the boundary of a mesh. This
	/// may limit the maximum reduction that may be achieved.
	/// </summary>
	public virtual int GetBoundaryVertexDeletion()
	{
		return vtkDecimatePro_GetBoundaryVertexDeletion_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetDegree_10(HandleRef pThis);

	/// <summary>
	/// If the number of triangles connected to a vertex exceeds "Degree", then
	/// the vertex will be split. (NOTE: the complexity of the triangulation
	/// algorithm is proportional to Degree^2. Setting degree small can improve
	/// the performance of the algorithm.)
	/// </summary>
	public virtual int GetDegree()
	{
		return vtkDecimatePro_GetDegree_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetDegreeMaxValue_11(HandleRef pThis);

	/// <summary>
	/// If the number of triangles connected to a vertex exceeds "Degree", then
	/// the vertex will be split. (NOTE: the complexity of the triangulation
	/// algorithm is proportional to Degree^2. Setting degree small can improve
	/// the performance of the algorithm.)
	/// </summary>
	public virtual int GetDegreeMaxValue()
	{
		return vtkDecimatePro_GetDegreeMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetDegreeMinValue_12(HandleRef pThis);

	/// <summary>
	/// If the number of triangles connected to a vertex exceeds "Degree", then
	/// the vertex will be split. (NOTE: the complexity of the triangulation
	/// algorithm is proportional to Degree^2. Setting degree small can improve
	/// the performance of the algorithm.)
	/// </summary>
	public virtual int GetDegreeMinValue()
	{
		return vtkDecimatePro_GetDegreeMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetErrorIsAbsolute_13(HandleRef pThis);

	/// <summary>
	/// The MaximumError is normally defined as a fraction of the dataset bounding
	/// diagonal. By setting ErrorIsAbsolute to 1, the error is instead defined
	/// as that specified by AbsoluteError. By default ErrorIsAbsolute=0.
	/// </summary>
	public virtual int GetErrorIsAbsolute()
	{
		return vtkDecimatePro_GetErrorIsAbsolute_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetFeatureAngle_14(HandleRef pThis);

	/// <summary>
	/// Specify the mesh feature angle. This angle is used to define what
	/// an edge is (i.e., if the surface normal between two adjacent triangles
	/// is &gt;= FeatureAngle, an edge exists).
	/// </summary>
	public virtual double GetFeatureAngle()
	{
		return vtkDecimatePro_GetFeatureAngle_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetFeatureAngleMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the mesh feature angle. This angle is used to define what
	/// an edge is (i.e., if the surface normal between two adjacent triangles
	/// is &gt;= FeatureAngle, an edge exists).
	/// </summary>
	public virtual double GetFeatureAngleMaxValue()
	{
		return vtkDecimatePro_GetFeatureAngleMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetFeatureAngleMinValue_16(HandleRef pThis);

	/// <summary>
	/// Specify the mesh feature angle. This angle is used to define what
	/// an edge is (i.e., if the surface normal between two adjacent triangles
	/// is &gt;= FeatureAngle, an edge exists).
	/// </summary>
	public virtual double GetFeatureAngleMinValue()
	{
		return vtkDecimatePro_GetFeatureAngleMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetInflectionPointRatio_17(HandleRef pThis);

	/// <summary>
	/// Specify the inflection point ratio. An inflection point occurs
	/// when the ratio of reduction error between two iterations is greater
	/// than or equal to the InflectionPointRatio.
	/// </summary>
	public virtual double GetInflectionPointRatio()
	{
		return vtkDecimatePro_GetInflectionPointRatio_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetInflectionPointRatioMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the inflection point ratio. An inflection point occurs
	/// when the ratio of reduction error between two iterations is greater
	/// than or equal to the InflectionPointRatio.
	/// </summary>
	public virtual double GetInflectionPointRatioMaxValue()
	{
		return vtkDecimatePro_GetInflectionPointRatioMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetInflectionPointRatioMinValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the inflection point ratio. An inflection point occurs
	/// when the ratio of reduction error between two iterations is greater
	/// than or equal to the InflectionPointRatio.
	/// </summary>
	public virtual double GetInflectionPointRatioMinValue()
	{
		return vtkDecimatePro_GetInflectionPointRatioMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_GetInflectionPoints_20(HandleRef pThis, IntPtr inflectionPoints);

	/// <summary>
	/// Get a list of inflection points. These are double values 0 &lt; r &lt;= 1.0
	/// corresponding to reduction level, and there are a total of
	/// NumberOfInflectionPoints() values. You must provide an array (of
	/// the correct size) into which the inflection points are written.
	/// </summary>
	public void GetInflectionPoints(IntPtr inflectionPoints)
	{
		vtkDecimatePro_GetInflectionPoints_20(GetCppThis(), inflectionPoints);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDecimatePro_GetInflectionPoints_21(HandleRef pThis);

	/// <summary>
	/// Get a list of inflection points. These are double values 0 &lt; r &lt;= 1.0
	/// corresponding to reduction level, and there are a total of
	/// NumberOfInflectionPoints() values. You must provide an array (of
	/// the correct size) into which the inflection points are written.
	/// This method returns a pointer to a list of inflection points.
	/// </summary>
	public IntPtr GetInflectionPoints()
	{
		return vtkDecimatePro_GetInflectionPoints_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetMaximumError_22(HandleRef pThis);

	/// <summary>
	/// Set the largest decimation error that is allowed during the decimation
	/// process. This may limit the maximum reduction that may be achieved. The
	/// maximum error is specified as a fraction of the maximum length of
	/// the input data bounding box.
	/// </summary>
	public virtual double GetMaximumError()
	{
		return vtkDecimatePro_GetMaximumError_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetMaximumErrorMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set the largest decimation error that is allowed during the decimation
	/// process. This may limit the maximum reduction that may be achieved. The
	/// maximum error is specified as a fraction of the maximum length of
	/// the input data bounding box.
	/// </summary>
	public virtual double GetMaximumErrorMaxValue()
	{
		return vtkDecimatePro_GetMaximumErrorMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetMaximumErrorMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set the largest decimation error that is allowed during the decimation
	/// process. This may limit the maximum reduction that may be achieved. The
	/// maximum error is specified as a fraction of the maximum length of
	/// the input data bounding box.
	/// </summary>
	public virtual double GetMaximumErrorMinValue()
	{
		return vtkDecimatePro_GetMaximumErrorMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDecimatePro_GetNumberOfGenerationsFromBase_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDecimatePro_GetNumberOfGenerationsFromBase_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDecimatePro_GetNumberOfGenerationsFromBaseType_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDecimatePro_GetNumberOfGenerationsFromBaseType_26(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDecimatePro_GetNumberOfInflectionPoints_27(HandleRef pThis);

	/// <summary>
	/// Get the number of inflection points. Only returns a valid value after
	/// the filter has executed.  The values in the list are mesh reduction
	/// values at each inflection point. Note: the first inflection point always
	/// occurs right before non-planar triangles are decimated (i.e., as the
	/// error becomes non-zero).
	/// </summary>
	public long GetNumberOfInflectionPoints()
	{
		return vtkDecimatePro_GetNumberOfInflectionPoints_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetOutputPointsPrecision_28(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkDecimatePro_GetOutputPointsPrecision_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetPreSplitMesh_29(HandleRef pThis);

	/// <summary>
	/// In some cases you may wish to split the mesh prior to algorithm
	/// execution. This separates the mesh into semi-planar patches, which are
	/// disconnected from each other. This can give superior results in some
	/// cases. If the ivar PreSplitMesh ivar is enabled, the mesh is split with
	/// the specified SplitAngle. Otherwise mesh splitting is deferred as long
	/// as possible.
	/// </summary>
	public virtual int GetPreSplitMesh()
	{
		return vtkDecimatePro_GetPreSplitMesh_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetPreserveTopology_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to preserve the topology of the original mesh. If
	/// on, mesh splitting and hole elimination will not occur. This may limit
	/// the maximum reduction that may be achieved.
	/// </summary>
	public virtual int GetPreserveTopology()
	{
		return vtkDecimatePro_GetPreserveTopology_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetSplitAngle_31(HandleRef pThis);

	/// <summary>
	/// Specify the mesh split angle. This angle is used to control the splitting
	/// of the mesh. A split line exists when the surface normals between
	/// two edge connected triangles are &gt;= SplitAngle.
	/// </summary>
	public virtual double GetSplitAngle()
	{
		return vtkDecimatePro_GetSplitAngle_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetSplitAngleMaxValue_32(HandleRef pThis);

	/// <summary>
	/// Specify the mesh split angle. This angle is used to control the splitting
	/// of the mesh. A split line exists when the surface normals between
	/// two edge connected triangles are &gt;= SplitAngle.
	/// </summary>
	public virtual double GetSplitAngleMaxValue()
	{
		return vtkDecimatePro_GetSplitAngleMaxValue_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetSplitAngleMinValue_33(HandleRef pThis);

	/// <summary>
	/// Specify the mesh split angle. This angle is used to control the splitting
	/// of the mesh. A split line exists when the surface normals between
	/// two edge connected triangles are &gt;= SplitAngle.
	/// </summary>
	public virtual double GetSplitAngleMinValue()
	{
		return vtkDecimatePro_GetSplitAngleMinValue_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_GetSplitting_34(HandleRef pThis);

	/// <summary>
	/// Turn on/off the splitting of the mesh at corners, along edges, at
	/// non-manifold points, or anywhere else a split is required. Turning
	/// splitting off will better preserve the original topology of the
	/// mesh, but you may not obtain the requested reduction.
	/// </summary>
	public virtual int GetSplitting()
	{
		return vtkDecimatePro_GetSplitting_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetTargetReduction_35(HandleRef pThis);

	/// <summary>
	/// Specify the desired reduction in the total number of polygons (e.g., if
	/// TargetReduction is set to 0.9, this filter will try to reduce the data set
	/// to 10% of its original size). Because of various constraints, this level of
	/// reduction may not be realized. If you want to guarantee a particular
	/// reduction, you must turn off PreserveTopology, turn on SplitEdges and
	/// BoundaryVertexDeletion, and set the MaximumError to VTK_DOUBLE_MAX (these
	/// ivars are initialized this way when the object is instantiated).
	/// </summary>
	public virtual double GetTargetReduction()
	{
		return vtkDecimatePro_GetTargetReduction_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetTargetReductionMaxValue_36(HandleRef pThis);

	/// <summary>
	/// Specify the desired reduction in the total number of polygons (e.g., if
	/// TargetReduction is set to 0.9, this filter will try to reduce the data set
	/// to 10% of its original size). Because of various constraints, this level of
	/// reduction may not be realized. If you want to guarantee a particular
	/// reduction, you must turn off PreserveTopology, turn on SplitEdges and
	/// BoundaryVertexDeletion, and set the MaximumError to VTK_DOUBLE_MAX (these
	/// ivars are initialized this way when the object is instantiated).
	/// </summary>
	public virtual double GetTargetReductionMaxValue()
	{
		return vtkDecimatePro_GetTargetReductionMaxValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDecimatePro_GetTargetReductionMinValue_37(HandleRef pThis);

	/// <summary>
	/// Specify the desired reduction in the total number of polygons (e.g., if
	/// TargetReduction is set to 0.9, this filter will try to reduce the data set
	/// to 10% of its original size). Because of various constraints, this level of
	/// reduction may not be realized. If you want to guarantee a particular
	/// reduction, you must turn off PreserveTopology, turn on SplitEdges and
	/// BoundaryVertexDeletion, and set the MaximumError to VTK_DOUBLE_MAX (these
	/// ivars are initialized this way when the object is instantiated).
	/// </summary>
	public virtual double GetTargetReductionMinValue()
	{
		return vtkDecimatePro_GetTargetReductionMinValue_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_IsA_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDecimatePro_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDecimatePro_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDecimatePro_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDecimatePro_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDecimatePro NewInstance()
	{
		vtkDecimatePro result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDecimatePro_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_PreSplitMeshOff_42(HandleRef pThis);

	/// <summary>
	/// In some cases you may wish to split the mesh prior to algorithm
	/// execution. This separates the mesh into semi-planar patches, which are
	/// disconnected from each other. This can give superior results in some
	/// cases. If the ivar PreSplitMesh ivar is enabled, the mesh is split with
	/// the specified SplitAngle. Otherwise mesh splitting is deferred as long
	/// as possible.
	/// </summary>
	public virtual void PreSplitMeshOff()
	{
		vtkDecimatePro_PreSplitMeshOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_PreSplitMeshOn_43(HandleRef pThis);

	/// <summary>
	/// In some cases you may wish to split the mesh prior to algorithm
	/// execution. This separates the mesh into semi-planar patches, which are
	/// disconnected from each other. This can give superior results in some
	/// cases. If the ivar PreSplitMesh ivar is enabled, the mesh is split with
	/// the specified SplitAngle. Otherwise mesh splitting is deferred as long
	/// as possible.
	/// </summary>
	public virtual void PreSplitMeshOn()
	{
		vtkDecimatePro_PreSplitMeshOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_PreserveTopologyOff_44(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to preserve the topology of the original mesh. If
	/// on, mesh splitting and hole elimination will not occur. This may limit
	/// the maximum reduction that may be achieved.
	/// </summary>
	public virtual void PreserveTopologyOff()
	{
		vtkDecimatePro_PreserveTopologyOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_PreserveTopologyOn_45(HandleRef pThis);

	/// <summary>
	/// Turn on/off whether to preserve the topology of the original mesh. If
	/// on, mesh splitting and hole elimination will not occur. This may limit
	/// the maximum reduction that may be achieved.
	/// </summary>
	public virtual void PreserveTopologyOn()
	{
		vtkDecimatePro_PreserveTopologyOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDecimatePro_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDecimatePro SafeDownCast(vtkObjectBase o)
	{
		vtkDecimatePro vtkDecimatePro2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDecimatePro_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDecimatePro2 = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDecimatePro2.Register(null);
			}
		}
		return vtkDecimatePro2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetAbsoluteError_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Same as MaximumError, but to be used when ErrorIsAbsolute is 1
	/// </summary>
	public virtual void SetAbsoluteError(double _arg)
	{
		vtkDecimatePro_SetAbsoluteError_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetAccumulateError_48(HandleRef pThis, int _arg);

	/// <summary>
	/// The computed error can either be computed directly from the mesh
	/// or the error may be accumulated as the mesh is modified. If the error
	/// is accumulated, then it represents a global error bounds, and the ivar
	/// MaximumError becomes a global bounds on mesh error. Accumulating the
	/// error requires extra memory proportional to the number of vertices in
	/// the mesh. If AccumulateError is off, then the error is not accumulated.
	/// </summary>
	public virtual void SetAccumulateError(int _arg)
	{
		vtkDecimatePro_SetAccumulateError_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetBoundaryVertexDeletion_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the deletion of vertices on the boundary of a mesh. This
	/// may limit the maximum reduction that may be achieved.
	/// </summary>
	public virtual void SetBoundaryVertexDeletion(int _arg)
	{
		vtkDecimatePro_SetBoundaryVertexDeletion_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetDegree_50(HandleRef pThis, int _arg);

	/// <summary>
	/// If the number of triangles connected to a vertex exceeds "Degree", then
	/// the vertex will be split. (NOTE: the complexity of the triangulation
	/// algorithm is proportional to Degree^2. Setting degree small can improve
	/// the performance of the algorithm.)
	/// </summary>
	public virtual void SetDegree(int _arg)
	{
		vtkDecimatePro_SetDegree_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetErrorIsAbsolute_51(HandleRef pThis, int _arg);

	/// <summary>
	/// The MaximumError is normally defined as a fraction of the dataset bounding
	/// diagonal. By setting ErrorIsAbsolute to 1, the error is instead defined
	/// as that specified by AbsoluteError. By default ErrorIsAbsolute=0.
	/// </summary>
	public virtual void SetErrorIsAbsolute(int _arg)
	{
		vtkDecimatePro_SetErrorIsAbsolute_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetFeatureAngle_52(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the mesh feature angle. This angle is used to define what
	/// an edge is (i.e., if the surface normal between two adjacent triangles
	/// is &gt;= FeatureAngle, an edge exists).
	/// </summary>
	public virtual void SetFeatureAngle(double _arg)
	{
		vtkDecimatePro_SetFeatureAngle_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetInflectionPointRatio_53(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the inflection point ratio. An inflection point occurs
	/// when the ratio of reduction error between two iterations is greater
	/// than or equal to the InflectionPointRatio.
	/// </summary>
	public virtual void SetInflectionPointRatio(double _arg)
	{
		vtkDecimatePro_SetInflectionPointRatio_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetMaximumError_54(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the largest decimation error that is allowed during the decimation
	/// process. This may limit the maximum reduction that may be achieved. The
	/// maximum error is specified as a fraction of the maximum length of
	/// the input data bounding box.
	/// </summary>
	public virtual void SetMaximumError(double _arg)
	{
		vtkDecimatePro_SetMaximumError_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetOutputPointsPrecision_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output types. See the documentation
	/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
	/// the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkDecimatePro_SetOutputPointsPrecision_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetPreSplitMesh_56(HandleRef pThis, int _arg);

	/// <summary>
	/// In some cases you may wish to split the mesh prior to algorithm
	/// execution. This separates the mesh into semi-planar patches, which are
	/// disconnected from each other. This can give superior results in some
	/// cases. If the ivar PreSplitMesh ivar is enabled, the mesh is split with
	/// the specified SplitAngle. Otherwise mesh splitting is deferred as long
	/// as possible.
	/// </summary>
	public virtual void SetPreSplitMesh(int _arg)
	{
		vtkDecimatePro_SetPreSplitMesh_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetPreserveTopology_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off whether to preserve the topology of the original mesh. If
	/// on, mesh splitting and hole elimination will not occur. This may limit
	/// the maximum reduction that may be achieved.
	/// </summary>
	public virtual void SetPreserveTopology(int _arg)
	{
		vtkDecimatePro_SetPreserveTopology_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetSplitAngle_58(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the mesh split angle. This angle is used to control the splitting
	/// of the mesh. A split line exists when the surface normals between
	/// two edge connected triangles are &gt;= SplitAngle.
	/// </summary>
	public virtual void SetSplitAngle(double _arg)
	{
		vtkDecimatePro_SetSplitAngle_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetSplitting_59(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the splitting of the mesh at corners, along edges, at
	/// non-manifold points, or anywhere else a split is required. Turning
	/// splitting off will better preserve the original topology of the
	/// mesh, but you may not obtain the requested reduction.
	/// </summary>
	public virtual void SetSplitting(int _arg)
	{
		vtkDecimatePro_SetSplitting_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SetTargetReduction_60(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the desired reduction in the total number of polygons (e.g., if
	/// TargetReduction is set to 0.9, this filter will try to reduce the data set
	/// to 10% of its original size). Because of various constraints, this level of
	/// reduction may not be realized. If you want to guarantee a particular
	/// reduction, you must turn off PreserveTopology, turn on SplitEdges and
	/// BoundaryVertexDeletion, and set the MaximumError to VTK_DOUBLE_MAX (these
	/// ivars are initialized this way when the object is instantiated).
	/// </summary>
	public virtual void SetTargetReduction(double _arg)
	{
		vtkDecimatePro_SetTargetReduction_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SplittingOff_61(HandleRef pThis);

	/// <summary>
	/// Turn on/off the splitting of the mesh at corners, along edges, at
	/// non-manifold points, or anywhere else a split is required. Turning
	/// splitting off will better preserve the original topology of the
	/// mesh, but you may not obtain the requested reduction.
	/// </summary>
	public virtual void SplittingOff()
	{
		vtkDecimatePro_SplittingOff_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDecimatePro_SplittingOn_62(HandleRef pThis);

	/// <summary>
	/// Turn on/off the splitting of the mesh at corners, along edges, at
	/// non-manifold points, or anywhere else a split is required. Turning
	/// splitting off will better preserve the original topology of the
	/// mesh, but you may not obtain the requested reduction.
	/// </summary>
	public virtual void SplittingOn()
	{
		vtkDecimatePro_SplittingOn_62(GetCppThis());
	}
}
