using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMeshQuality
/// </summary>
/// <remarks>
///    Calculate functions of quality of the elements of a mesh
///
/// vtkMeshQuality computes one or more functions of (geometric)
/// quality for each 2-D and 3-D cell (triangle, quadrilateral, tetrahedron, pyramid,
/// wedge, or hexahedron) of a mesh. These functions of quality are then averaged
/// over the entire mesh. The minimum, average, maximum, and unbiased variance
/// of quality for each type of cell is stored in the output mesh's FieldData.
/// The FieldData arrays are named "Mesh Triangle Quality,"
/// "Mesh Quadrilateral Quality," "Mesh Tetrahedron Quality," "Mesh Pyramid Quality,"
/// "Mesh Wedge Quality," and "Mesh Hexahedron Quality." Each array has
/// a single tuple with 5 components. The first 4 components are the quality
/// statistics mentioned above; the final value is the number of cells of the
/// given type. This final component makes aggregation of statistics for
/// distributed mesh data possible.
///
/// By default, the per-cell quality is added to the mesh's cell data, in
/// an array named "Quality." Cell types not supported by
/// this filter will have an entry of 0. Use SaveCellQualityOff() to
/// store only the final statistics.
///
/// This version of the filter written by Philippe Pebay and David Thompson
/// overtakes an older version written by Leila Baghdadi, Hanif Ladak, and
/// David Steinman at the Imaging Research Labs, Robarts Research Institute.
/// That version only supported tetrahedral radius ratio. See the
/// CompatibilityModeOn() member for information on how to make this filter
/// behave like the previous implementation.
/// For more information on the triangle quality functions of this class, cf.
/// Pebay &amp; Baker 2003, Analysis of triangle quality measures, Math Comp 72:244.
/// For more information on the quadrangle quality functions of this class, cf.
/// Pebay 2004, Planar Quadrangle Quality Measures, Eng Comp 20:2.
///
/// @warning
/// While more general than before, this class does not address many
/// cell types, including triangle strips and fans in 2D (among others).
/// Most quadrilateral quality functions are intended for planar quadrilaterals
/// only.
/// The minimal angle is not, strictly speaking, a quality function, but it is
/// provided because of its usage by many authors.
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
/// </remarks>
public class vtkMeshQuality : vtkDataSetAlgorithm
{
	/// <summary>
	/// Enum which lists the Quality Measures Types
	/// </summary>
	public enum QualityMeasureTypes
	{
		/// <summary>enum member</summary>
		AREA = 28,
		/// <summary>enum member</summary>
		ASPECT_FROBENIUS = 3,
		/// <summary>enum member</summary>
		ASPECT_GAMMA = 27,
		/// <summary>enum member</summary>
		ASPECT_RATIO = 1,
		/// <summary>enum member</summary>
		COLLAPSE_RATIO = 7,
		/// <summary>enum member</summary>
		CONDITION = 9,
		/// <summary>enum member</summary>
		DIAGONAL = 21,
		/// <summary>enum member</summary>
		DIMENSION = 22,
		/// <summary>enum member</summary>
		DISTORTION = 15,
		/// <summary>enum member</summary>
		EDGE_RATIO = 0,
		/// <summary>enum member</summary>
		EQUIANGLE_SKEW = 29,
		/// <summary>enum member</summary>
		EQUIVOLUME_SKEW = 30,
		/// <summary>enum member</summary>
		JACOBIAN = 25,
		/// <summary>enum member</summary>
		MAX_ANGLE = 8,
		/// <summary>enum member</summary>
		MAX_ASPECT_FROBENIUS = 5,
		/// <summary>enum member</summary>
		MAX_EDGE_RATIO = 16,
		/// <summary>enum member</summary>
		MAX_STRETCH = 31,
		/// <summary>enum member</summary>
		MEAN_ASPECT_FROBENIUS = 32,
		/// <summary>enum member</summary>
		MEAN_RATIO = 33,
		/// <summary>enum member</summary>
		MED_ASPECT_FROBENIUS = 4,
		/// <summary>enum member</summary>
		MIN_ANGLE = 6,
		/// <summary>enum member</summary>
		NODAL_JACOBIAN_RATIO = 34,
		/// <summary>enum member</summary>
		NONE = 37,
		/// <summary>enum member</summary>
		NORMALIZED_INRADIUS = 35,
		/// <summary>enum member</summary>
		ODDY = 23,
		/// <summary>enum member</summary>
		RADIUS_RATIO = 2,
		/// <summary>enum member</summary>
		RELATIVE_SIZE_SQUARED = 12,
		/// <summary>enum member</summary>
		SCALED_JACOBIAN = 10,
		/// <summary>enum member</summary>
		SHAPE = 13,
		/// <summary>enum member</summary>
		SHAPE_AND_SIZE = 14,
		/// <summary>enum member</summary>
		SHEAR = 11,
		/// <summary>enum member</summary>
		SHEAR_AND_SIZE = 24,
		/// <summary>enum member</summary>
		SKEW = 17,
		/// <summary>enum member</summary>
		SQUISH_INDEX = 36,
		/// <summary>enum member</summary>
		STRETCH = 20,
		/// <summary>enum member</summary>
		TAPER = 18,
		/// <summary>enum member</summary>
		TOTAL_QUALITY_MEASURE_TYPES = 37,
		/// <summary>enum member</summary>
		VOLUME = 19,
		/// <summary>enum member</summary>
		WARPAGE = 26
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMeshQuality";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMeshQuality()
	{
		MRClassNameKey = "class vtkMeshQuality";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMeshQuality"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMeshQuality(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeshQuality_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMeshQuality New()
	{
		vtkMeshQuality result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeshQuality_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMeshQuality()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMeshQuality_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern QualityMeasureTypes vtkMeshQuality_GetHexQualityMeasure_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public virtual QualityMeasureTypes GetHexQualityMeasure()
	{
		return vtkMeshQuality_GetHexQualityMeasure_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMeshQuality_GetLinearApproximation_02(HandleRef pThis);

	/// <summary>
	/// If set to true, then this filter will output 2 quality arrays instead of one.
	/// The second array is names "Quality (Linear Approx)" and features measure for all non-linear
	/// cells in addition to the linear ones, but treated like if they were linear.
	///
	/// @note In the array "Quality", any non-linear cell quality is set to NaN.
	/// </summary>
	public virtual bool GetLinearApproximation()
	{
		return (vtkMeshQuality_GetLinearApproximation_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMeshQuality_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMeshQuality_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMeshQuality_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMeshQuality_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern QualityMeasureTypes vtkMeshQuality_GetPyramidQualityMeasure_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of pyramids.
	/// The default is SHAPE and valid values also include
	/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
	/// </summary>
	public virtual QualityMeasureTypes GetPyramidQualityMeasure()
	{
		return vtkMeshQuality_GetPyramidQualityMeasure_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern QualityMeasureTypes vtkMeshQuality_GetQuadQualityMeasure_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public virtual QualityMeasureTypes GetQuadQualityMeasure()
	{
		return vtkMeshQuality_GetQuadQualityMeasure_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeshQuality_GetRatio_07(HandleRef pThis);

	/// <summary>
	/// These methods are deprecated. Use Get/SetSaveCellQuality() instead.
	///
	/// Formerly, SetRatio could be used to disable computation
	/// of the tetrahedral radius ratio so that volume alone could be computed.
	/// Now, cell quality is always computed, but you may decide not
	/// to store the result for each cell.
	/// This allows average cell quality of a mesh to be
	/// calculated without requiring per-cell storage.
	/// </summary>
	public int GetRatio()
	{
		return vtkMeshQuality_GetRatio_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeshQuality_GetSaveCellQuality_08(HandleRef pThis);

	/// <summary>
	/// This variable controls whether or not cell quality is stored as
	/// cell data in the resulting mesh or discarded (leaving only the
	/// aggregate quality average of the entire mesh, recorded in the
	/// FieldData).
	/// </summary>
	public virtual int GetSaveCellQuality()
	{
		return vtkMeshQuality_GetSaveCellQuality_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern QualityMeasureTypes vtkMeshQuality_GetTetQualityMeasure_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public virtual QualityMeasureTypes GetTetQualityMeasure()
	{
		return vtkMeshQuality_GetTetQualityMeasure_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern QualityMeasureTypes vtkMeshQuality_GetTriangleQualityMeasure_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public virtual QualityMeasureTypes GetTriangleQualityMeasure()
	{
		return vtkMeshQuality_GetTriangleQualityMeasure_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern QualityMeasureTypes vtkMeshQuality_GetWedgeQualityMeasure_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public virtual QualityMeasureTypes GetWedgeQualityMeasure()
	{
		return vtkMeshQuality_GetWedgeQualityMeasure_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexCondition_12(HandleRef cell);

	/// <summary>
	/// Calculate the condition of a hexahedron.
	/// The condition of a hexahedron is equivalent to HexMaxAspectFrobenius.
	/// </summary>
	public static double HexCondition(vtkCell cell)
	{
		return vtkMeshQuality_HexCondition_12(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexDiagonal_13(HandleRef cell);

	/// <summary>
	/// Calculate the diagonal of a hexahedron.
	/// The diagonal of a hexahedron Minimum diagonal length / maximum diagonal length.
	/// </summary>
	public static double HexDiagonal(vtkCell cell)
	{
		return vtkMeshQuality_HexDiagonal_13(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexDimension_14(HandleRef cell);

	/// <summary>
	/// Calculate the dimension of a hexahedron.
	/// The dimension of a hexahedron is the Pronto-specific characteristic length
	/// for stable time step calculation, where characteristic length = Volume / 2 grad Volume.
	/// </summary>
	public static double HexDimension(vtkCell cell)
	{
		return vtkMeshQuality_HexDimension_14(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexDistortion_15(HandleRef cell);

	/// <summary>
	/// Calculate the distortion of a hexahedron.
	/// The distortion of a hexahedron is {min(|J|)/actual volume} * parent volume,
	/// parent volume = 8 for a hexahedron.
	/// </summary>
	public static double HexDistortion(vtkCell cell)
	{
		return vtkMeshQuality_HexDistortion_15(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexEdgeRatio_16(HandleRef cell);

	/// <summary>
	/// Calculate the edge ratio of a hexahedron.
	/// The edge ratio of a hexahedron \f$H\f$ is:
	/// \f$\frac{|H|_\infty}{|H|_0}\f$,
	/// where \f$|H|_\infty\f$ and \f$|H|_0\f$ respectively denote the greatest and
	/// the smallest edge lengths of \f$H\f$.
	/// </summary>
	public static double HexEdgeRatio(vtkCell cell)
	{
		return vtkMeshQuality_HexEdgeRatio_16(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexEquiangleSkew_17(HandleRef cell);

	/// <summary>
	/// Calculate the equiangle skew of a hexahedron.
	/// </summary>
	public static double HexEquiangleSkew(vtkCell cell)
	{
		return vtkMeshQuality_HexEquiangleSkew_17(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexJacobian_18(HandleRef cell);

	/// <summary>
	/// Calculate the Jacobian of a hexahedron.
	/// The jacobian of a hexahedron is the minimum point-wise of local map at
	/// 8 corners &amp; center of the hexahedron.
	/// </summary>
	public static double HexJacobian(vtkCell cell)
	{
		return vtkMeshQuality_HexJacobian_18(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexMaxAspectFrobenius_19(HandleRef cell);

	/// <summary>
	/// Calculate the maximal Frobenius aspect of the 8 corner tetrahedra of a hexahedron,
	/// when the reference tetrahedral elements are right isosceles at the hexahedron vertices.
	/// </summary>
	public static double HexMaxAspectFrobenius(vtkCell cell)
	{
		return vtkMeshQuality_HexMaxAspectFrobenius_19(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexMaxEdgeRatio_20(HandleRef cell);

	/// <summary>
	/// Calculate the maximum edge ratio of a hexahedron at its center.
	/// </summary>
	public static double HexMaxEdgeRatio(vtkCell cell)
	{
		return vtkMeshQuality_HexMaxEdgeRatio_20(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexMedAspectFrobenius_21(HandleRef cell);

	/// <summary>
	/// Calculate the average Frobenius aspect of the 8 corner tetrahedra of a hexahedron,
	/// when the reference tetrahedral elements are right isosceles at the hexahedron vertices.
	/// </summary>
	public static double HexMedAspectFrobenius(vtkCell cell)
	{
		return vtkMeshQuality_HexMedAspectFrobenius_21(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexNodalJacobianRatio_22(HandleRef cell);

	/// <summary>
	/// Calculate the nodal Jacobian ratio of a hexahedron.
	/// The nodal Jacobian ratio of a hexahedron is min(Jacobian) / max(Jacobian) over all nodes.
	/// </summary>
	public static double HexNodalJacobianRatio(vtkCell cell)
	{
		return vtkMeshQuality_HexNodalJacobianRatio_22(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexOddy_23(HandleRef cell);

	/// <summary>
	/// Calculate the oddy of a hexahedron.
	/// The oddy of a hexahedron is the general distortion measure based on left
	/// Cauchy-Green Tensor.
	/// </summary>
	public static double HexOddy(vtkCell cell)
	{
		return vtkMeshQuality_HexOddy_23(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexRelativeSizeSquared_24(HandleRef cell);

	/// <summary>
	/// Calculate the relative size squared of a hexahedron.
	/// The relative size squared of a hexahedron is Min(J, 1 / J), where J is determinant
	/// of weighted Jacobian matrix.
	///
	/// Note: HexRelativeSizeSquared will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average hex size.
	/// </summary>
	public static double HexRelativeSizeSquared(vtkCell cell)
	{
		return vtkMeshQuality_HexRelativeSizeSquared_24(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexScaledJacobian_25(HandleRef cell);

	/// <summary>
	/// Calculate the scaled Jacobian of a hexahedron.
	/// The scaled jacobian of a hexahedron is the minimum Jacobian divided
	/// by the lengths of 3 edge vectors.
	/// </summary>
	public static double HexScaledJacobian(vtkCell cell)
	{
		return vtkMeshQuality_HexScaledJacobian_25(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexShape_26(HandleRef cell);

	/// <summary>
	/// Calculate the shape of a hexahedron.
	/// The shape of a hexahedron is 3 / Mean Ratio of weighted Jacobian matrix.
	/// </summary>
	public static double HexShape(vtkCell cell)
	{
		return vtkMeshQuality_HexShape_26(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexShapeAndSize_27(HandleRef cell);

	/// <summary>
	/// Calculate the shape and size of a hexahedron.
	/// The shape and size of a hexahedron is product of shape and average size.
	///
	/// Note: HexShapeAndSize will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average hex size.
	/// </summary>
	public static double HexShapeAndSize(vtkCell cell)
	{
		return vtkMeshQuality_HexShapeAndSize_27(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexShear_28(HandleRef cell);

	/// <summary>
	/// Calculate the shear of a hexahedron.
	/// The shear of a hexahedron is 3 / Mean Ratio of Jacobian Skew matrix.
	/// </summary>
	public static double HexShear(vtkCell cell)
	{
		return vtkMeshQuality_HexShear_28(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexShearAndSize_29(HandleRef cell);

	/// <summary>
	/// Calculate the shear and size of a hexahedron.
	/// The shear and size of a hexahedron is product of shear and average size.
	///
	/// Note: HexShearAndSize will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average hex size.
	/// </summary>
	public static double HexShearAndSize(vtkCell cell)
	{
		return vtkMeshQuality_HexShearAndSize_29(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexSkew_30(HandleRef cell);

	/// <summary>
	/// Calculate the skew of a hexahedron.
	/// The skew of a hexahedron is the maximum |cos A|, where A is the angle
	/// between edges at the hexahedron center.
	/// </summary>
	public static double HexSkew(vtkCell cell)
	{
		return vtkMeshQuality_HexSkew_30(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexStretch_31(HandleRef cell);

	/// <summary>
	/// Calculate the stretch of a hexahedron.
	/// The stretch of a hexahedron is Sqrt(3) * minimum edge length / maximum diagonal length.
	/// </summary>
	public static double HexStretch(vtkCell cell)
	{
		return vtkMeshQuality_HexStretch_31(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexTaper_32(HandleRef cell);

	/// <summary>
	/// Calculate the taper of a hexahedron.
	/// The taper of a hexahedron is the ratio of lengths derived from opposite edges.
	/// </summary>
	public static double HexTaper(vtkCell cell)
	{
		return vtkMeshQuality_HexTaper_32(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_HexVolume_33(HandleRef cell);

	/// <summary>
	/// Calculate the volume of a hexahedron.
	/// The volume of a hexahedron is the Jacobian at the hexahedron center.
	/// </summary>
	public static double HexVolume(vtkCell cell)
	{
		return vtkMeshQuality_HexVolume_33(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeshQuality_IsA_34(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMeshQuality_IsA_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMeshQuality_IsTypeOf_35(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMeshQuality_IsTypeOf_35(type);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_LinearApproximationOff_36(HandleRef pThis);

	/// <summary>
	/// If set to true, then this filter will output 2 quality arrays instead of one.
	/// The second array is names "Quality (Linear Approx)" and features measure for all non-linear
	/// cells in addition to the linear ones, but treated like if they were linear.
	///
	/// @note In the array "Quality", any non-linear cell quality is set to NaN.
	/// </summary>
	public virtual void LinearApproximationOff()
	{
		vtkMeshQuality_LinearApproximationOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_LinearApproximationOn_37(HandleRef pThis);

	/// <summary>
	/// If set to true, then this filter will output 2 quality arrays instead of one.
	/// The second array is names "Quality (Linear Approx)" and features measure for all non-linear
	/// cells in addition to the linear ones, but treated like if they were linear.
	///
	/// @note In the array "Quality", any non-linear cell quality is set to NaN.
	/// </summary>
	public virtual void LinearApproximationOn()
	{
		vtkMeshQuality_LinearApproximationOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeshQuality_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMeshQuality NewInstance()
	{
		vtkMeshQuality result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeshQuality_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_PyramidEquiangleSkew_40(HandleRef cell);

	/// <summary>
	/// Calculate the equiangle skew of a pyramid.
	/// </summary>
	public static double PyramidEquiangleSkew(vtkCell cell)
	{
		return vtkMeshQuality_PyramidEquiangleSkew_40(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_PyramidJacobian_41(HandleRef cell);

	/// <summary>
	/// Calculate the Jacobian of a pyramid.
	/// The jacobian of a tetrahedron is the minimum point-wise volume at any corner.
	/// </summary>
	public static double PyramidJacobian(vtkCell cell)
	{
		return vtkMeshQuality_PyramidJacobian_41(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_PyramidScaledJacobian_42(HandleRef cell);

	/// <summary>
	/// Calculate the Jacobian of a pyramid.
	/// The jacobian of a tetrahedron is the minimum point-wise volume at any corner.
	/// </summary>
	public static double PyramidScaledJacobian(vtkCell cell)
	{
		return vtkMeshQuality_PyramidScaledJacobian_42(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_PyramidShape_43(HandleRef cell);

	/// <summary>
	/// Calculate the shape of a pyramid.
	/// The shape of a pyramid is 4 divided by the minimum mean ratio of the
	/// Jacobian matrix at each element corner.
	/// </summary>
	public static double PyramidShape(vtkCell cell)
	{
		return vtkMeshQuality_PyramidShape_43(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_PyramidVolume_44(HandleRef cell);

	/// <summary>
	/// Calculate the volume of a pyramid.
	/// </summary>
	public static double PyramidVolume(vtkCell cell)
	{
		return vtkMeshQuality_PyramidVolume_44(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadArea_45(HandleRef cell);

	/// <summary>
	/// Calculate the area of a quadrilateral.
	/// The area of a quadrilateral is the Jacobian at quad center.
	/// </summary>
	public static double QuadArea(vtkCell cell)
	{
		return vtkMeshQuality_QuadArea_45(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadAspectRatio_46(HandleRef cell);

	/// <summary>
	/// Calculate the aspect ratio of a planar quadrilateral.
	/// The aspect ratio of a planar quadrilateral \f$q\f$ is:
	/// \f$\frac{|q|_1|q|_\infty}{4{\cal A}}\f$,
	/// where \f$|q|_1\f$, \f$|q|_\infty\f$ and \f${\cal A}\f$ respectively denote the
	/// perimeter, the greatest edge length and the area of \f$q\f$.
	/// </summary>
	public static double QuadAspectRatio(vtkCell cell)
	{
		return vtkMeshQuality_QuadAspectRatio_46(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadCondition_47(HandleRef cell);

	/// <summary>
	/// Calculate the condition number of a quadrilateral.
	/// The condition number of a quadrilateral is the (maximum) condition number of the
	/// Jacobian matrix at the 4 corners.
	/// </summary>
	public static double QuadCondition(vtkCell cell)
	{
		return vtkMeshQuality_QuadCondition_47(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadDistortion_48(HandleRef cell);

	/// <summary>
	/// Calculate the distortion of a quadrilateral.
	/// The distortion of a quadrilateral is {min(|J|)/actual area} * parent area,
	/// parent area = 4 for quad.
	/// </summary>
	public static double QuadDistortion(vtkCell cell)
	{
		return vtkMeshQuality_QuadDistortion_48(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadEdgeRatio_49(HandleRef cell);

	/// <summary>
	/// Calculate the edge ratio of a quadrilateral.
	/// The edge ratio of a quadrilateral \f$q\f$ is:
	/// \f$\frac{|q|_\infty}{|q|_0}\f$,
	/// where \f$|q|_\infty\f$ and \f$|q|_0\f$ respectively denote the greatest and
	/// the smallest edge lengths of \f$q\f$.
	/// </summary>
	public static double QuadEdgeRatio(vtkCell cell)
	{
		return vtkMeshQuality_QuadEdgeRatio_49(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadEquiangleSkew_50(HandleRef cell);

	/// <summary>
	/// Calculate the equiangle skew of a quadrilateral.
	/// </summary>
	public static double QuadEquiangleSkew(vtkCell cell)
	{
		return vtkMeshQuality_QuadEquiangleSkew_50(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadJacobian_51(HandleRef cell);

	/// <summary>
	/// Calculate the Jacobian of a quadrilateral.
	/// The Jacobian of a quadrilateral is the minimum point-wise volume of local map
	/// at 4 corners &amp; center of quad.
	/// </summary>
	public static double QuadJacobian(vtkCell cell)
	{
		return vtkMeshQuality_QuadJacobian_51(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadMaxAngle_52(HandleRef cell);

	/// <summary>
	/// Calculate the maximum (nonoriented) angle of a quadrilateral, expressed in degrees.
	/// </summary>
	public static double QuadMaxAngle(vtkCell cell)
	{
		return vtkMeshQuality_QuadMaxAngle_52(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadMaxAspectFrobenius_53(HandleRef cell);

	/// <summary>
	/// Calculate the maximal Frobenius aspect of the 4 corner triangles of a planar quadrilateral,
	/// when the reference triangle elements are right isosceles at the quadrangle vertices.
	/// The Frobenius aspect of a triangle \f$t\f$, when the reference element is
	/// right isosceles at vertex \f$V\f$, is:
	/// \f$\frac{f^2+g^2}{4{\cal A}}\f$,
	/// where \f$f^2+g^2\f$ and \f$\cal A\f$ respectively denote the sum of the
	/// squared lengths of the edges attached to \f$V\f$ and the area of \f$t\f$.
	/// </summary>
	public static double QuadMaxAspectFrobenius(vtkCell cell)
	{
		return vtkMeshQuality_QuadMaxAspectFrobenius_53(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadMaxEdgeRatio_54(HandleRef cell);

	/// <summary>
	/// Calculate the maximum edge length ratio of a quadrilateral at quad center.
	/// </summary>
	public static double QuadMaxEdgeRatio(vtkCell cell)
	{
		return vtkMeshQuality_QuadMaxEdgeRatio_54(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadMedAspectFrobenius_55(HandleRef cell);

	/// <summary>
	/// Calculate the average Frobenius aspect of the 4 corner triangles of a planar quadrilateral,
	/// when the reference triangle elements are right isosceles at the quadrangle vertices.
	/// The Frobenius aspect of a triangle \f$t\f$, when the reference element is
	/// right isosceles at vertex \f$V\f$, is:
	/// \f$\frac{f^2+g^2}{4{\cal A}}\f$,
	/// where \f$f^2+g^2\f$ and \f$\cal A\f$ respectively denote the sum of the
	/// squared lengths of the edges attached to \f$V\f$ and the area of \f$t\f$.
	/// </summary>
	public static double QuadMedAspectFrobenius(vtkCell cell)
	{
		return vtkMeshQuality_QuadMedAspectFrobenius_55(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadMinAngle_56(HandleRef cell);

	/// <summary>
	/// Calculate the minimal (nonoriented) angle of a quadrilateral, expressed in degrees.
	/// </summary>
	public static double QuadMinAngle(vtkCell cell)
	{
		return vtkMeshQuality_QuadMinAngle_56(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadOddy_57(HandleRef cell);

	/// <summary>
	/// Calculate the oddy of a quadrilateral.
	/// The oddy of a quadrilateral is the general distortion measure based on left
	/// Cauchy-Green Tensor.
	/// </summary>
	public static double QuadOddy(vtkCell cell)
	{
		return vtkMeshQuality_QuadOddy_57(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadRadiusRatio_58(HandleRef cell);

	/// <summary>
	/// Calculate the radius ratio of a planar quadrilateral. The name is only used by analogy
	/// with the triangle radius ratio, because in general a quadrilateral does not have a
	/// circumcircle nor an incircle.
	/// The radius ratio of a planar quadrilateral \f$q\f$ is:
	/// \f$\frac{|q|_2h_{\max}}{\min_i{\cal A}_i}\f$,
	/// where \f$|q|_2\f$, \f$h_{\max}\f$ and \f$\min{\cal A}_i\f$ respectively denote
	/// the sum of the squared edge lengths, the greatest amongst diagonal and edge
	/// lengths and the smallest area of the 4 triangles extractable from \f$q\f$.
	/// </summary>
	public static double QuadRadiusRatio(vtkCell cell)
	{
		return vtkMeshQuality_QuadRadiusRatio_58(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadRelativeSizeSquared_59(HandleRef cell);

	/// <summary>
	/// Calculate the relative size squared of a quadrilateral.
	/// The relative size squared of a quadrilateral is the Min(J, 1 / J), where J is the
	/// determinant of weighted Jacobian matrix.
	///
	/// Note: QuadRelativeSizeSquared will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average quad size.
	/// </summary>
	public static double QuadRelativeSizeSquared(vtkCell cell)
	{
		return vtkMeshQuality_QuadRelativeSizeSquared_59(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadScaledJacobian_60(HandleRef cell);

	/// <summary>
	/// Calculate the scaled Jacobian of a quadrilateral.
	/// The scaled Jacobian of a quadrilateral is the minimum Jacobian divided by the lengths
	/// of the 2 edge vectors.
	/// </summary>
	public static double QuadScaledJacobian(vtkCell cell)
	{
		return vtkMeshQuality_QuadScaledJacobian_60(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadShape_61(HandleRef cell);

	/// <summary>
	/// Calculate the shear of a quadrilateral.
	/// The shear of a quadrilateral is 2 / Condition number of weighted Jacobian matrix.
	/// </summary>
	public static double QuadShape(vtkCell cell)
	{
		return vtkMeshQuality_QuadShape_61(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadShapeAndSize_62(HandleRef cell);

	/// <summary>
	/// Calculate the shape and size of a quadrilateral.
	/// The shape and size of a quadrilateral is product of shape and average size.
	///
	/// Note: QuadShapeAndSize will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average triangle size.
	/// </summary>
	public static double QuadShapeAndSize(vtkCell cell)
	{
		return vtkMeshQuality_QuadShapeAndSize_62(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadShear_63(HandleRef cell);

	/// <summary>
	/// Calculate the shear of a quadrilateral.
	/// The shear of a quadrilateral is 2 / Condition number of Jacobian Skew matrix.
	/// </summary>
	public static double QuadShear(vtkCell cell)
	{
		return vtkMeshQuality_QuadShear_63(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadShearAndSize_64(HandleRef cell);

	/// <summary>
	/// Calculate the shear and size of a quadrilateral.
	/// The shear and size of a quadrilateral is product of shear and average size.
	///
	/// Note: QuadShearAndSize will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average triangle size.
	/// </summary>
	public static double QuadShearAndSize(vtkCell cell)
	{
		return vtkMeshQuality_QuadShearAndSize_64(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadSkew_65(HandleRef cell);

	/// <summary>
	/// Calculate the skew of a quadrilateral.
	/// The skew of a quadrilateral is the maximum |cos A|, where A is the angle
	/// between edges at the quad center.
	/// </summary>
	public static double QuadSkew(vtkCell cell)
	{
		return vtkMeshQuality_QuadSkew_65(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadStretch_66(HandleRef cell);

	/// <summary>
	/// Calculate the stretch of a quadrilateral.
	/// The stretch of a quadrilateral is Sqrt(2) * minimum edge length / maximum diagonal length.
	/// </summary>
	public static double QuadStretch(vtkCell cell)
	{
		return vtkMeshQuality_QuadStretch_66(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadTaper_67(HandleRef cell);

	/// <summary>
	/// Calculate the taper of a quadrilateral.
	/// The taper of a quadrilateral is the ratio of lengths derived from opposite edges.
	/// </summary>
	public static double QuadTaper(vtkCell cell)
	{
		return vtkMeshQuality_QuadTaper_67(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_QuadWarpage_68(HandleRef cell);

	/// <summary>
	/// Calculate the warpage of a quadrilateral.
	/// The warpage of a quadrilateral is the cosine of Minimum Dihedral Angle formed by
	/// Planes Intersecting in Diagonals.
	/// </summary>
	public static double QuadWarpage(vtkCell cell)
	{
		return vtkMeshQuality_QuadWarpage_68(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_RatioOff_69(HandleRef pThis);

	/// <summary>
	/// These methods are deprecated. Use Get/SetSaveCellQuality() instead.
	///
	/// Formerly, SetRatio could be used to disable computation
	/// of the tetrahedral radius ratio so that volume alone could be computed.
	/// Now, cell quality is always computed, but you may decide not
	/// to store the result for each cell.
	/// This allows average cell quality of a mesh to be
	/// calculated without requiring per-cell storage.
	/// </summary>
	public virtual void RatioOff()
	{
		vtkMeshQuality_RatioOff_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_RatioOn_70(HandleRef pThis);

	/// <summary>
	/// These methods are deprecated. Use Get/SetSaveCellQuality() instead.
	///
	/// Formerly, SetRatio could be used to disable computation
	/// of the tetrahedral radius ratio so that volume alone could be computed.
	/// Now, cell quality is always computed, but you may decide not
	/// to store the result for each cell.
	/// This allows average cell quality of a mesh to be
	/// calculated without requiring per-cell storage.
	/// </summary>
	public virtual void RatioOn()
	{
		vtkMeshQuality_RatioOn_70(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMeshQuality_SafeDownCast_71(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMeshQuality SafeDownCast(vtkObjectBase o)
	{
		vtkMeshQuality vtkMeshQuality2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMeshQuality_SafeDownCast_71(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMeshQuality2 = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMeshQuality2.Register(null);
			}
		}
		return vtkMeshQuality2;
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SaveCellQualityOff_72(HandleRef pThis);

	/// <summary>
	/// This variable controls whether or not cell quality is stored as
	/// cell data in the resulting mesh or discarded (leaving only the
	/// aggregate quality average of the entire mesh, recorded in the
	/// FieldData).
	/// </summary>
	public virtual void SaveCellQualityOff()
	{
		vtkMeshQuality_SaveCellQualityOff_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SaveCellQualityOn_73(HandleRef pThis);

	/// <summary>
	/// This variable controls whether or not cell quality is stored as
	/// cell data in the resulting mesh or discarded (leaving only the
	/// aggregate quality average of the entire mesh, recorded in the
	/// FieldData).
	/// </summary>
	public virtual void SaveCellQualityOn()
	{
		vtkMeshQuality_SaveCellQualityOn_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasure_74(HandleRef pThis, QualityMeasureTypes _arg);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public virtual void SetHexQualityMeasure(QualityMeasureTypes _arg)
	{
		vtkMeshQuality_SetHexQualityMeasure_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasure_75(HandleRef pThis, int measure);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public virtual void SetHexQualityMeasure(int measure)
	{
		vtkMeshQuality_SetHexQualityMeasure_75(GetCppThis(), measure);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToCondition_76(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToCondition()
	{
		vtkMeshQuality_SetHexQualityMeasureToCondition_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToDiagonal_77(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToDiagonal()
	{
		vtkMeshQuality_SetHexQualityMeasureToDiagonal_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToDimension_78(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToDimension()
	{
		vtkMeshQuality_SetHexQualityMeasureToDimension_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToDistortion_79(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToDistortion()
	{
		vtkMeshQuality_SetHexQualityMeasureToDistortion_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToEdgeRatio_80(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToEdgeRatio()
	{
		vtkMeshQuality_SetHexQualityMeasureToEdgeRatio_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToEquiangleSkew_81(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToEquiangleSkew()
	{
		vtkMeshQuality_SetHexQualityMeasureToEquiangleSkew_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToJacobian_82(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToJacobian()
	{
		vtkMeshQuality_SetHexQualityMeasureToJacobian_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToMaxAspectFrobenius_83(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToMaxAspectFrobenius()
	{
		vtkMeshQuality_SetHexQualityMeasureToMaxAspectFrobenius_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToMaxEdgeRatio_84(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToMaxEdgeRatio()
	{
		vtkMeshQuality_SetHexQualityMeasureToMaxEdgeRatio_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToMedAspectFrobenius_85(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToMedAspectFrobenius()
	{
		vtkMeshQuality_SetHexQualityMeasureToMedAspectFrobenius_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToNodalJacobianRatio_86(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToNodalJacobianRatio()
	{
		vtkMeshQuality_SetHexQualityMeasureToNodalJacobianRatio_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToOddy_87(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToOddy()
	{
		vtkMeshQuality_SetHexQualityMeasureToOddy_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToRelativeSizeSquared_88(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToRelativeSizeSquared()
	{
		vtkMeshQuality_SetHexQualityMeasureToRelativeSizeSquared_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToScaledJacobian_89(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToScaledJacobian()
	{
		vtkMeshQuality_SetHexQualityMeasureToScaledJacobian_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToShape_90(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToShape()
	{
		vtkMeshQuality_SetHexQualityMeasureToShape_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToShapeAndSize_91(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToShapeAndSize()
	{
		vtkMeshQuality_SetHexQualityMeasureToShapeAndSize_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToShear_92(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToShear()
	{
		vtkMeshQuality_SetHexQualityMeasureToShear_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToShearAndSize_93(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToShearAndSize()
	{
		vtkMeshQuality_SetHexQualityMeasureToShearAndSize_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToSkew_94(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToSkew()
	{
		vtkMeshQuality_SetHexQualityMeasureToSkew_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToStretch_95(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToStretch()
	{
		vtkMeshQuality_SetHexQualityMeasureToStretch_95(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToTaper_96(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToTaper()
	{
		vtkMeshQuality_SetHexQualityMeasureToTaper_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetHexQualityMeasureToVolume_97(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of hexahedra.
	/// The default is MAX_ASPECT_FROBENIUS and valid values also include
	/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
	/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
	/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
	/// </summary>
	public void SetHexQualityMeasureToVolume()
	{
		vtkMeshQuality_SetHexQualityMeasureToVolume_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetLinearApproximation_98(HandleRef pThis, byte _arg);

	/// <summary>
	/// If set to true, then this filter will output 2 quality arrays instead of one.
	/// The second array is names "Quality (Linear Approx)" and features measure for all non-linear
	/// cells in addition to the linear ones, but treated like if they were linear.
	///
	/// @note In the array "Quality", any non-linear cell quality is set to NaN.
	/// </summary>
	public virtual void SetLinearApproximation(bool _arg)
	{
		vtkMeshQuality_SetLinearApproximation_98(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetPyramidQualityMeasure_99(HandleRef pThis, QualityMeasureTypes _arg);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of pyramids.
	/// The default is SHAPE and valid values also include
	/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
	/// </summary>
	public virtual void SetPyramidQualityMeasure(QualityMeasureTypes _arg)
	{
		vtkMeshQuality_SetPyramidQualityMeasure_99(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetPyramidQualityMeasure_100(HandleRef pThis, int measure);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of pyramids.
	/// The default is SHAPE and valid values also include
	/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
	/// </summary>
	public virtual void SetPyramidQualityMeasure(int measure)
	{
		vtkMeshQuality_SetPyramidQualityMeasure_100(GetCppThis(), measure);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToEquiangleSkew_101(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of pyramids.
	/// The default is SHAPE and valid values also include
	/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
	/// </summary>
	public void SetPyramidQualityMeasureToEquiangleSkew()
	{
		vtkMeshQuality_SetPyramidQualityMeasureToEquiangleSkew_101(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToJacobian_102(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of pyramids.
	/// The default is SHAPE and valid values also include
	/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
	/// </summary>
	public void SetPyramidQualityMeasureToJacobian()
	{
		vtkMeshQuality_SetPyramidQualityMeasureToJacobian_102(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToScaledJacobian_103(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of pyramids.
	/// The default is SHAPE and valid values also include
	/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
	/// </summary>
	public void SetPyramidQualityMeasureToScaledJacobian()
	{
		vtkMeshQuality_SetPyramidQualityMeasureToScaledJacobian_103(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToShape_104(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of pyramids.
	/// The default is SHAPE and valid values also include
	/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
	/// </summary>
	public void SetPyramidQualityMeasureToShape()
	{
		vtkMeshQuality_SetPyramidQualityMeasureToShape_104(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToVolume_105(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of pyramids.
	/// The default is SHAPE and valid values also include
	/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
	/// </summary>
	public void SetPyramidQualityMeasureToVolume()
	{
		vtkMeshQuality_SetPyramidQualityMeasureToVolume_105(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasure_106(HandleRef pThis, QualityMeasureTypes _arg);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public virtual void SetQuadQualityMeasure(QualityMeasureTypes _arg)
	{
		vtkMeshQuality_SetQuadQualityMeasure_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasure_107(HandleRef pThis, int measure);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public virtual void SetQuadQualityMeasure(int measure)
	{
		vtkMeshQuality_SetQuadQualityMeasure_107(GetCppThis(), measure);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToArea_108(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToArea()
	{
		vtkMeshQuality_SetQuadQualityMeasureToArea_108(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToAspectRatio_109(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToAspectRatio()
	{
		vtkMeshQuality_SetQuadQualityMeasureToAspectRatio_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToCondition_110(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToCondition()
	{
		vtkMeshQuality_SetQuadQualityMeasureToCondition_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToDistortion_111(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToDistortion()
	{
		vtkMeshQuality_SetQuadQualityMeasureToDistortion_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToEdgeRatio_112(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToEdgeRatio()
	{
		vtkMeshQuality_SetQuadQualityMeasureToEdgeRatio_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToEquiangleSkew_113(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToEquiangleSkew()
	{
		vtkMeshQuality_SetQuadQualityMeasureToEquiangleSkew_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToJacobian_114(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToJacobian()
	{
		vtkMeshQuality_SetQuadQualityMeasureToJacobian_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxAngle_115(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToMaxAngle()
	{
		vtkMeshQuality_SetQuadQualityMeasureToMaxAngle_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxAspectFrobenius_116(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToMaxAspectFrobenius()
	{
		vtkMeshQuality_SetQuadQualityMeasureToMaxAspectFrobenius_116(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxEdgeRatio_117(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToMaxEdgeRatio()
	{
		vtkMeshQuality_SetQuadQualityMeasureToMaxEdgeRatio_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMedAspectFrobenius_118(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToMedAspectFrobenius()
	{
		vtkMeshQuality_SetQuadQualityMeasureToMedAspectFrobenius_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMinAngle_119(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToMinAngle()
	{
		vtkMeshQuality_SetQuadQualityMeasureToMinAngle_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToOddy_120(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToOddy()
	{
		vtkMeshQuality_SetQuadQualityMeasureToOddy_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToRadiusRatio_121(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToRadiusRatio()
	{
		vtkMeshQuality_SetQuadQualityMeasureToRadiusRatio_121(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToRelativeSizeSquared_122(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToRelativeSizeSquared()
	{
		vtkMeshQuality_SetQuadQualityMeasureToRelativeSizeSquared_122(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToScaledJacobian_123(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToScaledJacobian()
	{
		vtkMeshQuality_SetQuadQualityMeasureToScaledJacobian_123(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShape_124(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToShape()
	{
		vtkMeshQuality_SetQuadQualityMeasureToShape_124(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShapeAndSize_125(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToShapeAndSize()
	{
		vtkMeshQuality_SetQuadQualityMeasureToShapeAndSize_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShear_126(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToShear()
	{
		vtkMeshQuality_SetQuadQualityMeasureToShear_126(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShearAndSize_127(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToShearAndSize()
	{
		vtkMeshQuality_SetQuadQualityMeasureToShearAndSize_127(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToSkew_128(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToSkew()
	{
		vtkMeshQuality_SetQuadQualityMeasureToSkew_128(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToStretch_129(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToStretch()
	{
		vtkMeshQuality_SetQuadQualityMeasureToStretch_129(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToTaper_130(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToTaper()
	{
		vtkMeshQuality_SetQuadQualityMeasureToTaper_130(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetQuadQualityMeasureToWarpage_131(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
	/// The default is EDGE_RATIO and valid values also include
	/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
	/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
	/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
	/// and EQUIANGLE_SKEW.
	///
	/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
	/// quadrilaterals only; use at your own risk if you really want to assess non-planar
	/// quadrilateral quality with those.
	/// </summary>
	public void SetQuadQualityMeasureToWarpage()
	{
		vtkMeshQuality_SetQuadQualityMeasureToWarpage_131(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetRatio_132(HandleRef pThis, int r);

	/// <summary>
	/// These methods are deprecated. Use Get/SetSaveCellQuality() instead.
	///
	/// Formerly, SetRatio could be used to disable computation
	/// of the tetrahedral radius ratio so that volume alone could be computed.
	/// Now, cell quality is always computed, but you may decide not
	/// to store the result for each cell.
	/// This allows average cell quality of a mesh to be
	/// calculated without requiring per-cell storage.
	/// </summary>
	public virtual void SetRatio(int r)
	{
		vtkMeshQuality_SetRatio_132(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetSaveCellQuality_133(HandleRef pThis, int _arg);

	/// <summary>
	/// This variable controls whether or not cell quality is stored as
	/// cell data in the resulting mesh or discarded (leaving only the
	/// aggregate quality average of the entire mesh, recorded in the
	/// FieldData).
	/// </summary>
	public virtual void SetSaveCellQuality(int _arg)
	{
		vtkMeshQuality_SetSaveCellQuality_133(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasure_134(HandleRef pThis, QualityMeasureTypes _arg);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public virtual void SetTetQualityMeasure(QualityMeasureTypes _arg)
	{
		vtkMeshQuality_SetTetQualityMeasure_134(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasure_135(HandleRef pThis, int measure);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public virtual void SetTetQualityMeasure(int measure)
	{
		vtkMeshQuality_SetTetQualityMeasure_135(GetCppThis(), measure);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectFrobenius_136(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToAspectFrobenius()
	{
		vtkMeshQuality_SetTetQualityMeasureToAspectFrobenius_136(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectGamma_137(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToAspectGamma()
	{
		vtkMeshQuality_SetTetQualityMeasureToAspectGamma_137(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectRatio_138(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToAspectRatio()
	{
		vtkMeshQuality_SetTetQualityMeasureToAspectRatio_138(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToCollapseRatio_139(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToCollapseRatio()
	{
		vtkMeshQuality_SetTetQualityMeasureToCollapseRatio_139(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToCondition_140(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToCondition()
	{
		vtkMeshQuality_SetTetQualityMeasureToCondition_140(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToDistortion_141(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToDistortion()
	{
		vtkMeshQuality_SetTetQualityMeasureToDistortion_141(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToEdgeRatio_142(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToEdgeRatio()
	{
		vtkMeshQuality_SetTetQualityMeasureToEdgeRatio_142(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToEquiangleSkew_143(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToEquiangleSkew()
	{
		vtkMeshQuality_SetTetQualityMeasureToEquiangleSkew_143(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToEquivolumeSkew_144(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToEquivolumeSkew()
	{
		vtkMeshQuality_SetTetQualityMeasureToEquivolumeSkew_144(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToJacobian_145(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToJacobian()
	{
		vtkMeshQuality_SetTetQualityMeasureToJacobian_145(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToMeanRatio_146(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToMeanRatio()
	{
		vtkMeshQuality_SetTetQualityMeasureToMeanRatio_146(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToMinAngle_147(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToMinAngle()
	{
		vtkMeshQuality_SetTetQualityMeasureToMinAngle_147(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToNormalizedInradius_148(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToNormalizedInradius()
	{
		vtkMeshQuality_SetTetQualityMeasureToNormalizedInradius_148(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToRadiusRatio_149(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToRadiusRatio()
	{
		vtkMeshQuality_SetTetQualityMeasureToRadiusRatio_149(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToRelativeSizeSquared_150(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToRelativeSizeSquared()
	{
		vtkMeshQuality_SetTetQualityMeasureToRelativeSizeSquared_150(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToScaledJacobian_151(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToScaledJacobian()
	{
		vtkMeshQuality_SetTetQualityMeasureToScaledJacobian_151(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToShape_152(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToShape()
	{
		vtkMeshQuality_SetTetQualityMeasureToShape_152(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToShapeAndSize_153(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToShapeAndSize()
	{
		vtkMeshQuality_SetTetQualityMeasureToShapeAndSize_153(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToSquishIndex_154(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToSquishIndex()
	{
		vtkMeshQuality_SetTetQualityMeasureToSquishIndex_154(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTetQualityMeasureToVolume_155(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of tetrahedra.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
	/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
	/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
	/// </summary>
	public void SetTetQualityMeasureToVolume()
	{
		vtkMeshQuality_SetTetQualityMeasureToVolume_155(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasure_156(HandleRef pThis, QualityMeasureTypes _arg);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public virtual void SetTriangleQualityMeasure(QualityMeasureTypes _arg)
	{
		vtkMeshQuality_SetTriangleQualityMeasure_156(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasure_157(HandleRef pThis, int measure);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public virtual void SetTriangleQualityMeasure(int measure)
	{
		vtkMeshQuality_SetTriangleQualityMeasure_157(GetCppThis(), measure);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToArea_158(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToArea()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToArea_158(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToAspectFrobenius_159(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToAspectFrobenius()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToAspectFrobenius_159(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToAspectRatio_160(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToAspectRatio()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToAspectRatio_160(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToCondition_161(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToCondition()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToCondition_161(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToDistortion_162(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToDistortion()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToDistortion_162(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToEdgeRatio_163(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToEdgeRatio()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToEdgeRatio_163(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToEquiangleSkew_164(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToEquiangleSkew()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToEquiangleSkew_164(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToMaxAngle_165(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToMaxAngle()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToMaxAngle_165(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToMinAngle_166(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToMinAngle()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToMinAngle_166(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToNormalizedInradius_167(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToNormalizedInradius()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToNormalizedInradius_167(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToRadiusRatio_168(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToRadiusRatio()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToRadiusRatio_168(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToRelativeSizeSquared_169(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToRelativeSizeSquared()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToRelativeSizeSquared_169(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToScaledJacobian_170(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToScaledJacobian()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToScaledJacobian_170(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToShape_171(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToShape()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToShape_171(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToShapeAndSize_172(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to function the quality of triangles.
	/// The default is RADIUS_RATIO and valid values also include
	/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
	/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
	/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
	/// </summary>
	public void SetTriangleQualityMeasureToShapeAndSize()
	{
		vtkMeshQuality_SetTriangleQualityMeasureToShapeAndSize_172(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasure_173(HandleRef pThis, QualityMeasureTypes _arg);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public virtual void SetWedgeQualityMeasure(QualityMeasureTypes _arg)
	{
		vtkMeshQuality_SetWedgeQualityMeasure_173(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasure_174(HandleRef pThis, int measure);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public virtual void SetWedgeQualityMeasure(int measure)
	{
		vtkMeshQuality_SetWedgeQualityMeasure_174(GetCppThis(), measure);
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToCondition_175(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToCondition()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToCondition_175(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToDistortion_176(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToDistortion()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToDistortion_176(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToEdgeRatio_177(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToEdgeRatio()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToEdgeRatio_177(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToEquiangleSkew_178(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToEquiangleSkew()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToEquiangleSkew_178(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToJacobian_179(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToJacobian()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToJacobian_179(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToMaxAspectFrobenius_180(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToMaxAspectFrobenius()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToMaxAspectFrobenius_180(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToMaxStretch_181(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToMaxStretch()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToMaxStretch_181(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToMeanAspectFrobenius_182(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToMeanAspectFrobenius()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToMeanAspectFrobenius_182(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToScaledJacobian_183(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToScaledJacobian()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToScaledJacobian_183(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToShape_184(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToShape()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToShape_184(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToVolume_185(HandleRef pThis);

	/// <summary>
	/// Set/Get the particular estimator used to measure the quality of wedges.
	/// The default is EDGE_RATIO and valid values also include
	/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
	/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
	/// </summary>
	public void SetWedgeQualityMeasureToVolume()
	{
		vtkMeshQuality_SetWedgeQualityMeasureToVolume_185(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetAspectFrobenius_186(HandleRef cell);

	/// <summary>
	/// Calculate the Frobenius condition number of the transformation matrix from a regular
	/// tetrahedron to a tetrahedron.
	/// The Frobenius aspect of a tetrahedron \f$K\f$, when the reference element is
	/// regular, is:
	/// \f$\frac{\frac{3}{2}(l_{11}+l_{22}+l_{33}) - (l_{12}+l_{13}+l_{23})}
	/// {3(\sqrt{2}\det{T})^\frac{2}{3}}\f$,
	/// where \f$T\f$ and \f$l_{ij}\f$ respectively denote the edge matrix of \f$K\f$
	/// and the entries of \f$L=T^t\,T\f$.
	/// </summary>
	public static double TetAspectFrobenius(vtkCell cell)
	{
		return vtkMeshQuality_TetAspectFrobenius_186(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetAspectGamma_187(HandleRef cell);

	/// <summary>
	/// Calculate the aspect gamma of a tetrahedron.
	/// The aspect gamma of a tetrahedron is:
	/// Srms**3 / (8.479670*V) where Srms = sqrt(Sum(Si**2)/6), Si = edge length.
	/// </summary>
	public static double TetAspectGamma(vtkCell cell)
	{
		return vtkMeshQuality_TetAspectGamma_187(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetAspectRatio_188(HandleRef cell);

	/// <summary>
	/// Calculate the aspect ratio of a tetrahedron.
	/// The aspect ratio of a tetrahedron \f$K\f$ is:
	/// \f$\frac{|K|_\infty}{2\sqrt{6}r}\f$,
	/// where \f$|K|_\infty\f$ and \f$r\f$ respectively denote the greatest edge
	/// length and the inradius of \f$K\f$.
	/// </summary>
	public static double TetAspectRatio(vtkCell cell)
	{
		return vtkMeshQuality_TetAspectRatio_188(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetCollapseRatio_189(HandleRef cell);

	/// <summary>
	/// Calculate the collapse ratio of a tetrahedron.
	/// The collapse ratio is a dimensionless number defined as the smallest ratio of the
	/// height of a vertex above its opposing triangle to the longest edge of that opposing
	/// triangle across all vertices of the tetrahedron.
	/// </summary>
	public static double TetCollapseRatio(vtkCell cell)
	{
		return vtkMeshQuality_TetCollapseRatio_189(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetCondition_190(HandleRef cell);

	/// <summary>
	/// Calculate the condition number of a tetrahedron.
	/// The condition number of a tetrahedron is Condition number of the Jacobian matrix at any corner.
	/// </summary>
	public static double TetCondition(vtkCell cell)
	{
		return vtkMeshQuality_TetCondition_190(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetDistortion_191(HandleRef cell);

	/// <summary>
	/// Calculate the distortion of a tetrahedron.
	/// The distortion of a quadrilateral is {min(|J|)/actual volume} * parent volume,
	/// parent volume = 1 / 6 for a tetrahedron.
	/// </summary>
	public static double TetDistortion(vtkCell cell)
	{
		return vtkMeshQuality_TetDistortion_191(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetEdgeRatio_192(HandleRef cell);

	/// <summary>
	/// Calculate the edge ratio of a tetrahedron.
	/// The edge ratio of a tetrahedron \f$K\f$ is:
	/// \f$\frac{|K|_\infty}{|K|_0}\f$,
	/// where \f$|K|_\infty\f$ and \f$|K|_0\f$ respectively denote the greatest and
	/// the smallest edge lengths of \f$K\f$.
	/// </summary>
	public static double TetEdgeRatio(vtkCell cell)
	{
		return vtkMeshQuality_TetEdgeRatio_192(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetEquiangleSkew_193(HandleRef cell);

	/// <summary>
	/// Calculate the equiangle skew of a tetrahedron.
	/// </summary>
	public static double TetEquiangleSkew(vtkCell cell)
	{
		return vtkMeshQuality_TetEquiangleSkew_193(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetEquivolumeSkew_194(HandleRef cell);

	/// <summary>
	/// Calculate the equivolume skew of a tetrahedron.
	/// </summary>
	public static double TetEquivolumeSkew(vtkCell cell)
	{
		return vtkMeshQuality_TetEquivolumeSkew_194(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetJacobian_195(HandleRef cell);

	/// <summary>
	/// Calculate the Jacobian of a tetrahedron.
	/// The jacobian of a tetrahedron is the minimum point-wise volume at any corner.
	/// </summary>
	public static double TetJacobian(vtkCell cell)
	{
		return vtkMeshQuality_TetJacobian_195(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetMeanRatio_196(HandleRef cell);

	/// <summary>
	/// Calculate the mean ratio of a tetrahedron.
	/// The mean ratio of a tetrahedron is the ratio of tetrahedron volume over the volume of an
	/// equilateral tetrahedron with the same RMS edge length.
	/// </summary>
	public static double TetMeanRatio(vtkCell cell)
	{
		return vtkMeshQuality_TetMeanRatio_196(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetMinAngle_197(HandleRef cell);

	/// <summary>
	/// Calculate the minimal (nonoriented) dihedral angle of a tetrahedron, expressed in degrees.
	/// </summary>
	public static double TetMinAngle(vtkCell cell)
	{
		return vtkMeshQuality_TetMinAngle_197(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetNormalizedInradius_198(HandleRef cell);

	/// <summary>
	/// Calculate the normalized in-radius of a tetrahedron.
	/// The minimum normalized in-radius of a tetrahedron is the ratio of the minimum
	/// sub-tetrahedron inner radius to the outer tetrahedron radius.
	/// </summary>
	public static double TetNormalizedInradius(vtkCell cell)
	{
		return vtkMeshQuality_TetNormalizedInradius_198(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetRadiusRatio_199(HandleRef cell);

	/// <summary>
	/// Calculate the radius ratio of a tetrahedron.
	/// The radius ratio of a tetrahedron \f$K\f$ is:
	/// \f$\frac{R}{3r}\f$,
	/// where \f$R\f$ and \f$r\f$ respectively denote the circumradius and
	/// the inradius of \f$K\f$.
	/// </summary>
	public static double TetRadiusRatio(vtkCell cell)
	{
		return vtkMeshQuality_TetRadiusRatio_199(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetRelativeSizeSquared_200(HandleRef cell);

	/// <summary>
	/// Calculate the relative size squared of a tetrahedron.
	/// The relative size squared of a tetrahedron is Min(J, 1 / J), where J is determinant
	/// of weighted Jacobian matrix.
	///
	/// Note: TetRelativeSizeSquared will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average tet size.
	/// </summary>
	public static double TetRelativeSizeSquared(vtkCell cell)
	{
		return vtkMeshQuality_TetRelativeSizeSquared_200(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetScaledJacobian_201(HandleRef cell);

	/// <summary>
	/// Calculate the scaled Jacobian of a tetrahedron.
	/// The scaled jacobian of a tetrahedron is the minimum Jacobian divided
	/// by the lengths of 3 edge vectors.
	/// </summary>
	public static double TetScaledJacobian(vtkCell cell)
	{
		return vtkMeshQuality_TetScaledJacobian_201(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetShape_202(HandleRef cell);

	/// <summary>
	/// Calculate the shape of a tetrahedron.
	/// The shape of a tetrahedron is 3 / Mean Ratio of weighted Jacobian matrix.
	/// </summary>
	public static double TetShape(vtkCell cell)
	{
		return vtkMeshQuality_TetShape_202(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetShapeAndSize_203(HandleRef cell);

	/// <summary>
	/// Calculate the shape and size of a tetrahedron.
	/// The shape and size of a tetrahedron is product of shape and average size.
	///
	/// Note: TetShapeAndSize will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average tet size.
	/// </summary>
	public static double TetShapeAndSize(vtkCell cell)
	{
		return vtkMeshQuality_TetShapeAndSize_203(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetSquishIndex_204(HandleRef cell);

	/// <summary>
	/// Calculate the squish index of a tetrahedron.
	/// </summary>
	public static double TetSquishIndex(vtkCell cell)
	{
		return vtkMeshQuality_TetSquishIndex_204(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TetVolume_205(HandleRef cell);

	/// <summary>
	/// Calculate the volume of a tetrahedron.
	/// The volume of a tetrahedron is (1/6) * Jacobian at corner node.
	/// </summary>
	public static double TetVolume(vtkCell cell)
	{
		return vtkMeshQuality_TetVolume_205(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleArea_206(HandleRef cell);

	/// <summary>
	/// Calculate the area of a triangle.
	/// </summary>
	public static double TriangleArea(vtkCell cell)
	{
		return vtkMeshQuality_TriangleArea_206(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleAspectFrobenius_207(HandleRef cell);

	/// <summary>
	/// Calculate the Frobenius condition number of the transformation matrix from an equilateral
	/// triangle to a triangle.
	/// The Frobenius aspect of a triangle \f$t\f$, when the reference element is
	/// equilateral, is:
	/// \f$\frac{|t|^2_2}{2\sqrt{3}{\cal A}}\f$,
	/// where \f$|t|^2_2\f$ and \f$\cal A\f$ respectively denote the sum of the
	/// squared edge lengths and the area of \f$t\f$.
	/// </summary>
	public static double TriangleAspectFrobenius(vtkCell cell)
	{
		return vtkMeshQuality_TriangleAspectFrobenius_207(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleAspectRatio_208(HandleRef cell);

	/// <summary>
	/// Calculate the aspect ratio of a triangle.
	/// The aspect ratio of a triangle \f$t\f$ is:
	/// \f$\frac{|t|_\infty}{2\sqrt{3}r}\f$,
	/// where \f$|t|_\infty\f$ and \f$r\f$ respectively denote the greatest edge
	/// length and the inradius of \f$t\f$.
	/// </summary>
	public static double TriangleAspectRatio(vtkCell cell)
	{
		return vtkMeshQuality_TriangleAspectRatio_208(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleCondition_209(HandleRef cell);

	/// <summary>
	/// Calculate the condition number of a triangle.
	/// </summary>
	public static double TriangleCondition(vtkCell cell)
	{
		return vtkMeshQuality_TriangleCondition_209(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleDistortion_210(HandleRef cell);

	/// <summary>
	/// Calculate the distortion of a triangle.
	/// </summary>
	public static double TriangleDistortion(vtkCell cell)
	{
		return vtkMeshQuality_TriangleDistortion_210(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleEdgeRatio_211(HandleRef cell);

	/// <summary>
	/// Calculate the edge ratio of a triangle.
	/// The edge ratio of a triangle \f$t\f$ is:
	/// \f$\frac{|t|_\infty}{|t|_0}\f$,
	/// where \f$|t|_\infty\f$ and \f$|t|_0\f$ respectively denote the greatest and
	/// the smallest edge lengths of \f$t\f$.
	/// </summary>
	public static double TriangleEdgeRatio(vtkCell cell)
	{
		return vtkMeshQuality_TriangleEdgeRatio_211(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleEquiangleSkew_212(HandleRef cell);

	/// <summary>
	/// Calculate the equiangle skew of a triangle.
	/// </summary>
	public static double TriangleEquiangleSkew(vtkCell cell)
	{
		return vtkMeshQuality_TriangleEquiangleSkew_212(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleMaxAngle_213(HandleRef cell);

	/// <summary>
	/// Calculate the maximal (nonoriented) angle of a triangle, expressed in degrees.
	/// </summary>
	public static double TriangleMaxAngle(vtkCell cell)
	{
		return vtkMeshQuality_TriangleMaxAngle_213(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleMinAngle_214(HandleRef cell);

	/// <summary>
	/// Calculate the minimal (nonoriented) angle of a triangle, expressed in degrees.
	/// </summary>
	public static double TriangleMinAngle(vtkCell cell)
	{
		return vtkMeshQuality_TriangleMinAngle_214(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleNormalizedInradius_215(HandleRef cell);

	/// <summary>
	/// Calculate the normalized in-radius of a triangle.
	/// The minimum normalized in-radius of a triangle is the ratio of the minimum
	/// sub-triangle inner radius to the outer triangle radius.
	/// </summary>
	public static double TriangleNormalizedInradius(vtkCell cell)
	{
		return vtkMeshQuality_TriangleNormalizedInradius_215(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleRadiusRatio_216(HandleRef cell);

	/// <summary>
	/// Calculate the radius ratio of a triangle.
	/// The radius ratio of a triangle \f$t\f$ is:
	/// \f$\frac{R}{2r}\f$,
	/// where \f$R\f$ and \f$r\f$ respectively denote the circumradius and
	/// the inradius of \f$t\f$.
	/// </summary>
	public static double TriangleRadiusRatio(vtkCell cell)
	{
		return vtkMeshQuality_TriangleRadiusRatio_216(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleRelativeSizeSquared_217(HandleRef cell);

	/// <summary>
	/// Calculate the square of the relative size of a triangle.
	///
	/// Note: TriangleRelativeSizeSquared will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average triangle size.
	/// </summary>
	public static double TriangleRelativeSizeSquared(vtkCell cell)
	{
		return vtkMeshQuality_TriangleRelativeSizeSquared_217(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleScaledJacobian_218(HandleRef cell);

	/// <summary>
	/// Calculate the scaled Jacobian of a triangle.
	/// </summary>
	public static double TriangleScaledJacobian(vtkCell cell)
	{
		return vtkMeshQuality_TriangleScaledJacobian_218(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleShape_219(HandleRef cell);

	/// <summary>
	/// Calculate the shape of a triangle.
	/// </summary>
	public static double TriangleShape(vtkCell cell)
	{
		return vtkMeshQuality_TriangleShape_219(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_TriangleShapeAndSize_220(HandleRef cell);

	/// <summary>
	/// Calculate the product of shape and relative size of a triangle.
	///
	/// Note: TriangleShapeAndSize will return 0.0 if the MeshQuality filter has NOT
	/// been executed, because it relies on the average triangle size.
	/// </summary>
	public static double TriangleShapeAndSize(vtkCell cell)
	{
		return vtkMeshQuality_TriangleShapeAndSize_220(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeCondition_221(HandleRef cell);

	/// <summary>
	/// Calculate the condition number of a wedge.
	/// The condition number of a wedge is equivalent to the max aspect Frobenius.
	/// </summary>
	public static double WedgeCondition(vtkCell cell)
	{
		return vtkMeshQuality_WedgeCondition_221(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeDistortion_222(HandleRef cell);

	/// <summary>
	/// Calculate the distortion of a wedge.
	/// The distortion of a wedge is {min(|J|) / actual volume } * parent volume.
	/// </summary>
	public static double WedgeDistortion(vtkCell cell)
	{
		return vtkMeshQuality_WedgeDistortion_222(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeEdgeRatio_223(HandleRef cell);

	/// <summary>
	/// Calculate the edge ratio of a wedge.
	/// The edge ratio of a wedge is Hmax / Hmin, where Hmax and Hmin are respectively
	/// the maximum and the minimum edge lengths.
	/// </summary>
	public static double WedgeEdgeRatio(vtkCell cell)
	{
		return vtkMeshQuality_WedgeEdgeRatio_223(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeEquiangleSkew_224(HandleRef cell);

	/// <summary>
	/// Calculate the equiangle skew of a wedge.
	/// </summary>
	public static double WedgeEquiangleSkew(vtkCell cell)
	{
		return vtkMeshQuality_WedgeEquiangleSkew_224(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeJacobian_225(HandleRef cell);

	/// <summary>
	/// Calculate the Jacobian of a wedge.
	/// The jacobian of a wedge is the min{((L_2 X L_0) * L_3)_k}.
	/// </summary>
	public static double WedgeJacobian(vtkCell cell)
	{
		return vtkMeshQuality_WedgeJacobian_225(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeMaxAspectFrobenius_226(HandleRef cell);

	/// <summary>
	/// Calculate the max aspect Frobenius of a wedge.
	/// The max aspect Frobenius of a wedge is max(F_0123, F_1204, F_2015, F_3540, F_4351, F_5432).
	/// </summary>
	public static double WedgeMaxAspectFrobenius(vtkCell cell)
	{
		return vtkMeshQuality_WedgeMaxAspectFrobenius_226(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeMaxStretch_227(HandleRef cell);

	/// <summary>
	/// Calculate the max stretch of a wedge.
	/// The maximum stretch of a wedge is maximum stretch (S) of the three quadrilateral faces:
	/// q = max[S_1043, S_1254, S_2035]
	/// </summary>
	public static double WedgeMaxStretch(vtkCell cell)
	{
		return vtkMeshQuality_WedgeMaxStretch_227(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeMeanAspectFrobenius_228(HandleRef cell);

	/// <summary>
	/// Calculate the mean aspect Frobenius of a wedge.
	/// The mean aspect Frobenius of a wedge is:
	/// 1/6 * (F_0123 + F_1204 + F+2015 + F_3540 + F_4351 + F_5432).
	/// </summary>
	public static double WedgeMeanAspectFrobenius(vtkCell cell)
	{
		return vtkMeshQuality_WedgeMeanAspectFrobenius_228(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeScaledJacobian_229(HandleRef cell);

	/// <summary>
	/// Calculate the scaled Jacobian a wedge.
	/// The jacobian of a wedge is the minimum point-wise volume at any corner divided by the
	/// corresponding edge lengths and normalized to the unit wedge:
	/// q = min(  2 / sqrt(3) * ((L_2 X L_0) * L_3)_k / sqrt(mag(L_2) * mag(L_0) * mag(L_3))),
	/// where ((L_2 X L_0) * L_3)_k is the determinant of the Jacobian of the tetrahedron defined
	/// at the kth corner node, and L_2, L_0 and L_3 are the edges defined according to the
	/// standard for tetrahedral elements.
	/// </summary>
	public static double WedgeScaledJacobian(vtkCell cell)
	{
		return vtkMeshQuality_WedgeScaledJacobian_229(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeShape_230(HandleRef cell);

	/// <summary>
	/// Calculate the shape of a wedge.
	/// The shape of a wedge is 3 divided by the minimum mean ratio of the Jacobian matrix at each
	/// element corner.
	/// </summary>
	public static double WedgeShape(vtkCell cell)
	{
		return vtkMeshQuality_WedgeShape_230(cell?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMeshQuality_WedgeVolume_231(HandleRef cell);

	/// <summary>
	/// Calculate the volume of a wedge.
	/// </summary>
	public static double WedgeVolume(vtkCell cell)
	{
		return vtkMeshQuality_WedgeVolume_231(cell?.GetCppThis() ?? default(HandleRef));
	}
}
