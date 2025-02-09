using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericAdaptorCell
/// </summary>
/// <remarks>
///    defines cell interface
///
/// In VTK, spatial-temporal data is defined in terms of a dataset which is
/// composed of cells. The cells are topological entities over which an
/// interpolation field is applied. Cells are defined in terms of a topology
/// (e.g., vertices, lines, triangles, polygons, tetrahedra, etc.), points
/// that instantiate the geometry of the cells, and interpolation fields
/// (in the general case one interpolation field is for geometry, the other
/// is for attribute data associated with the cell).
///
/// Currently most algorithms in VTK use vtkCell and vtkDataSet, which make
/// assumptions about the nature of datasets, cells, and attributes. In
/// particular, this abstraction assumes that cell interpolation functions
/// are linear, or products of linear functions. Further, VTK implements
/// most of the interpolation functions. This implementation starts breaking
/// down as the complexity of the interpolation (or basis) functions
/// increases.
///
/// vtkGenericAdaptorCell addresses these issues by providing more general
/// abstraction for cells. It also adopts modern C++ practices including using
/// iterators. The vtkGenericAdaptorCell is designed to fit within the adaptor
/// framework; meaning that it is meant to adapt VTK to external simulation
/// systems (see the GenericFiltering/README.html).
///
/// Please note that most cells are defined in terms of other cells (the
/// boundary cells). They are also defined in terms of points, which are
/// not the same as vertices (vertices are a 0-D cell; points represent a
/// position in space).
///
/// Another important concept is the notion of DOFNodes. These concept
/// supports cell types with complex interpolation functions. For example,
/// higher-order p-method finite elements may have different functions on each
/// of their topological features (edges, faces, region). The coefficients of
/// these polynomial functions are associated with DOFNodes. (There is a
/// single DOFNode for each topological feature.) Note that from this
/// perspective, points are used to establish the topological form of the
/// cell; mid-side nodes and such are considered DOFNodes.
///
/// </remarks>
/// <seealso>
///
/// vtkGenericDataSet
/// </seealso>
public abstract class vtkGenericAdaptorCell : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAdaptorCell";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericAdaptorCell()
	{
		MRClassNameKey = "class vtkGenericAdaptorCell";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAdaptorCell"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericAdaptorCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_Clip_01(HandleRef pThis, double value, HandleRef f, HandleRef attributes, HandleRef tess, int insideOut, HandleRef locator, HandleRef connectivity, HandleRef outPd, HandleRef outCd, HandleRef internalPd, HandleRef secondaryPd, HandleRef secondaryCd);

	/// <summary>
	/// Cut (or clip) the current cell with respect to the contour defined by
	/// the `value' or the implicit function `f' of the scalar attribute
	/// (`attributes-&gt;GetActiveAttribute()',`attributes-&gt;GetActiveComponent()').
	/// If `f' exists, `value' is not used. The output is the part of the
	/// current cell which is inside the contour.  The output is a set of zero,
	/// one or more cells of the same topological dimension as the current
	/// cell. Normally, cell points whose scalar value is greater than "value"
	/// are considered inside. If `insideOut' is on, this is reversed.  Clipping
	/// interpolates the `attributes-&gt;GetNumberOfattributesToInterpolate()'
	/// attributes `attributes-&gt;GetAttributesToInterpolate()'.  `locator',
	/// `connectivity', `outPd' and `outCd' are cumulative data arrays over cell
	/// iterations: they store the result of each call to Clip():
	/// - `locator' is a points list that merges points as they are inserted
	/// (i.e., prevents duplicates).
	/// - `connectivity' is an array of generated cells
	/// - `outPd' is an array of interpolated point data along the edge (if
	/// not-nullptr)
	/// - `outCd' is an array of copied cell data of the current cell (if
	/// not-nullptr)
	/// `internalPd', `secondaryPd' and `secondaryCd' are initialized by the
	/// filter that call it from `attributes'.
	/// - `internalPd' stores the result of the tessellation pass: the
	/// higher-order cell is tessellated into linear sub-cells.
	/// - `secondaryPd' and `secondaryCd' are used internally as inputs to the
	/// Clip() method on linear sub-cells.
	/// Note: the CopyAllocate() method must be invoked on both `outPd' and
	/// `outCd', from `secondaryPd' and `secondaryCd'.
	///
	/// NOTE: `vtkGenericAttributeCollection *attributes' will be replaced by a
	/// `vtkInformation'.
	///
	/// \pre attributes_exist: attributes!=0
	/// \pre tessellator_exists: tess!=0
	/// \pre locator_exists: locator!=0
	/// \pre connectivity_exists: connectivity!=0
	/// \pre internalPd_exists: internalPd!=0
	/// \pre secondaryPd_exists: secondaryPd!=0
	/// \pre secondaryCd_exists: secondaryCd!=0
	/// </summary>
	public virtual void Clip(double value, vtkImplicitFunction f, vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, int insideOut, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData outPd, vtkCellData outCd, vtkPointData internalPd, vtkPointData secondaryPd, vtkCellData secondaryCd)
	{
		vtkGenericAdaptorCell_Clip_01(GetCppThis(), value, f?.GetCppThis() ?? default(HandleRef), attributes?.GetCppThis() ?? default(HandleRef), tess?.GetCppThis() ?? default(HandleRef), insideOut, locator?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), outCd?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef), secondaryPd?.GetCppThis() ?? default(HandleRef), secondaryCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_Contour_02(HandleRef pThis, HandleRef values, HandleRef f, HandleRef attributes, HandleRef tess, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef outPd, HandleRef outCd, HandleRef internalPd, HandleRef secondaryPd, HandleRef secondaryCd);

	/// <summary>
	/// Generate a contour (contouring primitives) for each `values' or with
	/// respect to an implicit function `f'. Contouring is performed on the
	/// scalar attribute (`attributes-&gt;GetActiveAttribute()'
	/// `attributes-&gt;GetActiveComponent()').  Contouring interpolates the
	/// `attributes-&gt;GetNumberOfattributesToInterpolate()' attributes
	/// `attributes-&gt;GetAttributesToInterpolate()'.  The `locator', `verts',
	/// `lines', `polys', `outPd' and `outCd' are cumulative data arrays over
	/// cell iterations: they store the result of each call to Contour():
	/// - `locator' is a points list that merges points as they are inserted
	/// (i.e., prevents duplicates).
	/// - `verts' is an array of generated vertices
	/// - `lines' is an array of generated lines
	/// - `polys' is an array of generated polygons
	/// - `outPd' is an array of interpolated point data along the edge (if
	/// not-nullptr)
	/// - `outCd' is an array of copied cell data of the current cell (if
	/// not-nullptr)
	/// `internalPd', `secondaryPd' and `secondaryCd' are initialized by the
	/// filter that call it from `attributes'.
	/// - `internalPd' stores the result of the tessellation pass: the
	/// higher-order cell is tessellated into linear sub-cells.
	/// - `secondaryPd' and `secondaryCd' are used internally as inputs to the
	/// Contour() method on linear sub-cells.
	/// Note: the CopyAllocate() method must be invoked on both `outPd' and
	/// `outCd', from `secondaryPd' and `secondaryCd'.
	///
	/// NOTE: `vtkGenericAttributeCollection *attributes' will be replaced by a
	/// `vtkInformation'.
	///
	/// \pre values_exist: (values!=0 &amp;&amp; f==0) || (values==0 &amp;&amp; f!=0)
	/// \pre attributes_exist: attributes!=0
	/// \pre tessellator_exists: tess!=0
	/// \pre locator_exists: locator!=0
	/// \pre verts_exist: verts!=0
	/// \pre lines_exist: lines!=0
	/// \pre polys_exist: polys!=0
	/// \pre internalPd_exists: internalPd!=0
	/// \pre secondaryPd_exists: secondaryPd!=0
	/// \pre secondaryCd_exists: secondaryCd!=0
	/// </summary>
	public virtual void Contour(vtkContourValues values, vtkImplicitFunction f, vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData outPd, vtkCellData outCd, vtkPointData internalPd, vtkPointData secondaryPd, vtkCellData secondaryCd)
	{
		vtkGenericAdaptorCell_Contour_02(GetCppThis(), values?.GetCppThis() ?? default(HandleRef), f?.GetCppThis() ?? default(HandleRef), attributes?.GetCppThis() ?? default(HandleRef), tess?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), outCd?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef), secondaryPd?.GetCppThis() ?? default(HandleRef), secondaryCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_CountEdgeNeighbors_03(HandleRef pThis, IntPtr sharing);

	/// <summary>
	/// Number of cells (dimension&gt;boundary-&gt;GetDimension()) of the dataset
	/// that share the boundary `boundary' of `this'.
	/// `this' IS NOT INCLUDED.
	/// \pre boundary_exists: boundary!=0
	/// \pre real_boundary: !boundary-&gt;IsInDataSet()
	/// \pre cell_of_the_dataset: IsInDataSet()
	/// \pre boundary: HasBoundary(boundary)
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual void CountEdgeNeighbors(IntPtr sharing)
	{
		vtkGenericAdaptorCell_CountEdgeNeighbors_03(GetCppThis(), sharing);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_CountNeighbors_04(HandleRef pThis, HandleRef boundary);

	/// <summary>
	/// Number of cells (dimension&gt;boundary-&gt;GetDimension()) of the dataset
	/// that share the boundary `boundary' of `this'.
	/// `this' IS NOT INCLUDED.
	/// \pre boundary_exists: boundary!=0
	/// \pre real_boundary: !boundary-&gt;IsInDataSet()
	/// \pre cell_of_the_dataset: IsInDataSet()
	/// \pre boundary: HasBoundary(boundary)
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual int CountNeighbors(vtkGenericAdaptorCell boundary)
	{
		return vtkGenericAdaptorCell_CountNeighbors_04(GetCppThis(), boundary?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, HandleRef attribute, IntPtr derivs);

	/// <summary>
	/// Compute derivatives `derivs' of the attribute `attribute' (from its
	/// values at the corner points of the cell) given sub-cell `subId' (0 means
	/// primary cell) and parametric coordinates `pcoords'.
	/// Derivatives are in the x-y-z coordinate directions for each data value.
	/// \pre positive_subId: subId&gt;=0
	/// \pre clamped_pcoords: (0&lt;=pcoords[0])&amp;&amp;(pcoords[0]&lt;=1)&amp;&amp;(0&lt;=pcoords[1])
	/// &amp;&amp;(pcoords[1]&lt;=1)&amp;&amp;(0&lt;=pcoords[2])%%(pcoords[2]&lt;=1)
	/// \pre attribute_exists: attribute!=0
	/// \pre derivs_exists: derivs!=0
	/// \pre valid_size: sizeof(derivs)&gt;=attribute-&gt;GetNumberOfComponents()*3
	/// </summary>
	public virtual void Derivatives(int subId, IntPtr pcoords, vtkGenericAttribute attribute, IntPtr derivs)
	{
		vtkGenericAdaptorCell_Derivatives_05(GetCppThis(), subId, pcoords, attribute?.GetCppThis() ?? default(HandleRef), derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_EvaluateLocation_06(HandleRef pThis, int subId, IntPtr pcoords, IntPtr x);

	/// <summary>
	/// Determine the global coordinates `x' from sub-cell `subId' and parametric
	/// coordinates `pcoords' in the cell.
	/// \pre positive_subId: subId&gt;=0
	/// \pre clamped_pcoords: (0&lt;=pcoords[0])&amp;&amp;(pcoords[0]&lt;=1)&amp;&amp;(0&lt;=pcoords[1])
	/// &amp;&amp;(pcoords[1]&lt;=1)&amp;&amp;(0&lt;=pcoords[2])&amp;&amp;(pcoords[2]&lt;=1)
	/// </summary>
	public virtual void EvaluateLocation(int subId, IntPtr pcoords, IntPtr x)
	{
		vtkGenericAdaptorCell_EvaluateLocation_06(GetCppThis(), subId, pcoords, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2);

	/// <summary>
	/// Is `x' inside the current cell? It also evaluates parametric coordinates
	/// `pcoords', sub-cell id `subId' (0 means primary cell), distance squared
	/// to the sub-cell in `dist2' and closest corner point `closestPoint'.
	/// `dist2' and `closestPoint' are not evaluated if `closestPoint'==0.
	/// If a numerical error occurred, -1 is returned and all other results
	/// should be ignored.
	/// \post valid_result: result==-1 || result==0 || result==1
	/// \post positive_distance: result!=-1 implies (closestPoint!=0 implies
	/// dist2&gt;=0)
	/// </summary>
	public virtual int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2)
	{
		return vtkGenericAdaptorCell_EvaluatePosition_07(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_FindClosestBoundary_08(HandleRef pThis, int subId, IntPtr pcoords, HandleRef boundary);

	/// <summary>
	/// Compute the closest boundary of the current sub-cell `subId' for point
	/// `pcoord' (in parametric coordinates) in `boundary', and return whether
	/// the point is inside the cell or not. `boundary' is of dimension
	/// GetDimension()-1.
	/// \pre positive_subId: subId&gt;=0
	/// </summary>
	public virtual int FindClosestBoundary(int subId, IntPtr pcoords, vtkGenericCellIterator boundary)
	{
		return vtkGenericAdaptorCell_FindClosestBoundary_08(GetCppThis(), subId, pcoords, boundary?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetAttributeOrder_09(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Return the interpolation order of attribute `a' on the cell
	/// (may differ by cell).
	/// \pre a_exists: a!=0
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual int GetAttributeOrder(vtkGenericAttribute a)
	{
		return vtkGenericAdaptorCell_GetAttributeOrder_09(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_GetBoundaryIterator_10(HandleRef pThis, HandleRef boundaries, int dim);

	/// <summary>
	/// Return the `boundaries' cells of dimension `dim' (or all dimensions
	/// less than GetDimension() if -1) that are part of the boundary of the cell.
	/// \pre valid_dim_range: (dim==-1) || ((dim&gt;=0)&amp;&amp;(dim&lt;GetDimension()))
	/// \pre boundaries_exist: boundaries!=0
	/// </summary>
	public virtual void GetBoundaryIterator(vtkGenericCellIterator boundaries, int dim)
	{
		vtkGenericAdaptorCell_GetBoundaryIterator_10(GetCppThis(), boundaries?.GetCppThis() ?? default(HandleRef), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_GetBounds_11(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Compute the bounding box of the current cell in `bounds' in global
	/// coordinates.
	/// THREAD SAFE
	/// </summary>
	public virtual void GetBounds(IntPtr bounds)
	{
		vtkGenericAdaptorCell_GetBounds_11(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAdaptorCell_GetBounds_12(HandleRef pThis);

	/// <summary>
	/// Return the bounding box of the current cell in global coordinates.
	/// NOT THREAD SAFE
	/// \post result_exists: result!=0
	/// \post valid_size: sizeof(result)&gt;=6
	/// </summary>
	public virtual IntPtr GetBounds()
	{
		return vtkGenericAdaptorCell_GetBounds_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetDimension_13(HandleRef pThis);

	/// <summary>
	/// Return the topological dimension of the current cell.
	/// \post valid_result: result&gt;=0 &amp;&amp; result&lt;=3
	/// </summary>
	public virtual int GetDimension()
	{
		return vtkGenericAdaptorCell_GetDimension_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAdaptorCell_GetEdgeArray_14(HandleRef pThis, long edgeId);

	/// <summary>
	/// Return the ids of the vertices defining edge `edgeId'.
	/// Ids are related to the cell, not to the dataset.
	/// \pre valid_dimension: this-&gt;GetDimension()&gt;=2
	/// \pre valid_edgeId_range: edgeId&gt;=0 &amp;&amp; edgeId&lt;this-&gt;GetNumberOfBoundaries(1)
	/// \post result_exists: result!=0
	/// \post valid_size: sizeof(result)==2
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints.
	/// </summary>
	public virtual IntPtr GetEdgeArray(long edgeId)
	{
		return vtkGenericAdaptorCell_GetEdgeArray_14(GetCppThis(), edgeId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAdaptorCell_GetFaceArray_15(HandleRef pThis, long faceId);

	/// <summary>
	/// Return the ids of the vertices defining face `faceId'.
	/// Ids are related to the cell, not to the dataset.
	/// \pre is_3d: this-&gt;GetDimension()==3
	/// \pre valid_faceId_range: faceId&gt;=0 &amp;&amp; faceId&lt;this-&gt;GetNumberOfBoundaries(2)
	/// \post result_exists: result!=0
	/// \post valid_size: sizeof(result)&gt;=GetNumberOfVerticesOnFace(faceId)
	///
	/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
	/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
	/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
	/// </summary>
	public virtual IntPtr GetFaceArray(long faceId)
	{
		return vtkGenericAdaptorCell_GetFaceArray_15(GetCppThis(), faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetGeometryOrder_16(HandleRef pThis);

	/// <summary>
	/// Return the interpolation order of the geometry.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual int GetGeometryOrder()
	{
		return vtkGenericAdaptorCell_GetGeometryOrder_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetHighestOrderAttribute_17(HandleRef pThis, HandleRef ac);

	/// <summary>
	/// Return the index of the first point centered attribute with the highest
	/// order in `ac'.
	/// \pre ac_exists: ac!=0
	/// \post valid_result: result&gt;=-1 &amp;&amp; result&lt;ac-&gt;GetNumberOfAttributes()
	/// </summary>
	public virtual int GetHighestOrderAttribute(vtkGenericAttributeCollection ac)
	{
		return vtkGenericAdaptorCell_GetHighestOrderAttribute_17(GetCppThis(), ac?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericAdaptorCell_GetId_18(HandleRef pThis);

	/// <summary>
	/// Unique identification number of the cell over the whole
	/// data set. This unique key may not be contiguous.
	/// </summary>
	public virtual long GetId()
	{
		return vtkGenericAdaptorCell_GetId_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericAdaptorCell_GetLength2_19(HandleRef pThis);

	/// <summary>
	/// Return the bounding box diagonal squared of the current cell.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual double GetLength2()
	{
		return vtkGenericAdaptorCell_GetLength2_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_GetNeighbors_20(HandleRef pThis, HandleRef boundary, HandleRef neighbors);

	/// <summary>
	/// Put into `neighbors' the cells (dimension&gt;boundary-&gt;GetDimension())
	/// of the dataset that share the boundary `boundary' with this cell.
	/// `this' IS NOT INCLUDED.
	/// \pre boundary_exists: boundary!=0
	/// \pre real_boundary: !boundary-&gt;IsInDataSet()
	/// \pre cell_of_the_dataset: IsInDataSet()
	/// \pre boundary: HasBoundary(boundary)
	/// \pre neighbors_exist: neighbors!=0
	/// </summary>
	public virtual void GetNeighbors(vtkGenericAdaptorCell boundary, vtkGenericCellIterator neighbors)
	{
		vtkGenericAdaptorCell_GetNeighbors_20(GetCppThis(), boundary?.GetCppThis() ?? default(HandleRef), neighbors?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetNumberOfBoundaries_21(HandleRef pThis, int dim);

	/// <summary>
	/// Return the number of boundaries of dimension `dim' (or all dimensions
	/// greater than 0 and less than GetDimension() if -1) of the cell.
	/// When \a dim is -1, the number of vertices is not included in the
	/// count because vertices are a special case: a vertex will have
	/// at most a single field value associated with it; DOF nodes may have
	/// an arbitrary number of field values associated with them.
	/// \pre valid_dim_range: (dim==-1) || ((dim&gt;=0)&amp;&amp;(dim&lt;GetDimension()))
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual int GetNumberOfBoundaries(int dim)
	{
		return vtkGenericAdaptorCell_GetNumberOfBoundaries_21(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetNumberOfDOFNodes_22(HandleRef pThis);

	/// <summary>
	/// Accumulated number of DOF nodes of the current cell. A DOF node is
	/// a component of cell with a given topological dimension. e.g.: a triangle
	/// has 4 DOF: 1 face and 3 edges. An hexahedron has 19 DOF:
	/// 1 region, 6 faces, and 12 edges.
	///
	/// The number of vertices is not included in the
	/// count because vertices are a special case: a vertex will have
	/// at most a single field value associated with it; DOF nodes may have
	/// an arbitrary number of field values associated with them.
	/// \post valid_result: result==GetNumberOfBoundaries(-1)+1
	/// </summary>
	public virtual int GetNumberOfDOFNodes()
	{
		return vtkGenericAdaptorCell_GetNumberOfDOFNodes_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericAdaptorCell_GetNumberOfGenerationsFromBase_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericAdaptorCell_GetNumberOfGenerationsFromBase_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericAdaptorCell_GetNumberOfGenerationsFromBaseType_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericAdaptorCell_GetNumberOfGenerationsFromBaseType_24(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetNumberOfPoints_25(HandleRef pThis);

	/// <summary>
	/// Return the number of corner points that compose the cell.
	/// \post positive_result: result&gt;=0
	/// </summary>
	public virtual int GetNumberOfPoints()
	{
		return vtkGenericAdaptorCell_GetNumberOfPoints_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetNumberOfVerticesOnFace_26(HandleRef pThis, int faceId);

	/// <summary>
	/// Return the number of vertices defining face `faceId'.
	/// \pre is_3d: this-&gt;GetDimension()==3
	/// \pre valid_faceId_range: faceId&gt;=0 &amp;&amp; faceId&lt;this-&gt;GetNumberOfBoundaries(2)
	/// \post positive_result: &amp;&amp; result&gt;0
	/// </summary>
	public virtual int GetNumberOfVerticesOnFace(int faceId)
	{
		return vtkGenericAdaptorCell_GetNumberOfVerticesOnFace_26(GetCppThis(), faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetParametricCenter_27(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Get the center of the current cell (in parametric coordinates) and place
	/// it in `pcoords'.  If the current cell is a composite, the return value
	/// is the sub-cell id that the center is in.  \post valid_result:
	/// (result&gt;=0) &amp;&amp; (IsPrimary() implies result==0)
	/// </summary>
	public virtual int GetParametricCenter(IntPtr pcoords)
	{
		return vtkGenericAdaptorCell_GetParametricCenter_27(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAdaptorCell_GetParametricCoords_28(HandleRef pThis);

	/// <summary>
	/// Return a contiguous array of parametric coordinates of the corrner points
	/// defining the current cell. In other words, (px,py,pz, px,py,pz, etc..) The
	/// coordinates are ordered consistent with the definition of the point
	/// ordering for the cell. Note that 3D parametric coordinates are returned
	/// no matter what the topological dimension of the cell.
	/// \post valid_result_exists: ((IsPrimary()) &amp;&amp; (result!=0)) ||
	/// ((!IsPrimary()) &amp;&amp; (result==0))
	/// result!=0 implies sizeof(result)==GetNumberOfPoints()
	/// </summary>
	public virtual IntPtr GetParametricCoords()
	{
		return vtkGenericAdaptorCell_GetParametricCoords_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGenericAdaptorCell_GetParametricDistance_29(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the distance of the parametric coordinate `pcoords' to the
	/// current cell.  If inside the cell, a distance of zero is returned. This
	/// is used during picking to get the correct cell picked. (The tolerance
	/// will occasionally allow cells to be picked who are not really
	/// intersected "inside" the cell.)  \post positive_result: result&gt;=0
	/// </summary>
	public virtual double GetParametricDistance(IntPtr pcoords)
	{
		return vtkGenericAdaptorCell_GetParametricDistance_29(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_GetPointIds_30(HandleRef pThis, IntPtr id);

	/// <summary>
	/// Put into `id' the list of the dataset points that define the corner points
	/// of the cell.
	/// \pre id_exists: id!=0
	/// \pre valid_size: sizeof(id)==GetNumberOfPoints();
	/// </summary>
	public virtual void GetPointIds(IntPtr id)
	{
		vtkGenericAdaptorCell_GetPointIds_30(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_GetPointIterator_31(HandleRef pThis, HandleRef it);

	/// <summary>
	/// Return the points of cell into `it'.
	/// \pre it_exists: it!=0
	/// </summary>
	public virtual void GetPointIterator(vtkGenericPointIterator it)
	{
		vtkGenericAdaptorCell_GetPointIterator_31(GetCppThis(), it?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_GetType_32(HandleRef pThis);

	/// <summary>
	/// Return the type of the current cell.
	/// \post (result==VTK_HIGHER_ORDER_EDGE)||
	/// (result==VTK_HIGHER_ORDER_TRIANGLE)||
	/// (result==VTK_HIGHER_ORDER_TETRAHEDRON)
	/// </summary>
	public virtual int GetTypeWrapper()
	{
		return vtkGenericAdaptorCell_GetType_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_InterpolateTuple_33(HandleRef pThis, HandleRef a, IntPtr pcoords, IntPtr val);

	/// <summary>
	/// Interpolate the attribute `a' at local position `pcoords' of the cell into
	/// `val'.
	/// \pre a_exists: a!=0
	/// \pre a_is_point_centered: a-&gt;GetCentering()==vtkPointCentered
	/// \pre clamped_point: pcoords[0]&gt;=0 &amp;&amp; pcoords[0]&lt;=1 &amp;&amp; pcoords[1]&gt;=0 &amp;&amp;
	/// pcoords[1]&lt;=1 &amp;&amp; pcoords[2]&gt;=0 &amp;&amp; pcoords[2]&lt;=1
	/// \pre val_exists: val!=0
	/// \pre valid_size: sizeof(val)==a-&gt;GetNumberOfComponents()
	/// </summary>
	public virtual void InterpolateTuple(vtkGenericAttribute a, IntPtr pcoords, IntPtr val)
	{
		vtkGenericAdaptorCell_InterpolateTuple_33(GetCppThis(), a?.GetCppThis() ?? default(HandleRef), pcoords, val);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_InterpolateTuple_34(HandleRef pThis, HandleRef c, IntPtr pcoords, IntPtr val);

	/// <summary>
	/// Interpolate the whole collection of attributes `c' at local position
	/// `pcoords' of the cell into `val'. Only point centered attributes are
	/// taken into account.
	/// \pre c_exists: c!=0
	/// \pre clamped_point: pcoords[0]&gt;=0 &amp;&amp; pcoords[0]&lt;=1 &amp;&amp; pcoords[1]&gt;=0 &amp;&amp;
	/// pcoords[1]&lt;=1 &amp;&amp; pcoords[2]&gt;=0 &amp;&amp; pcoords[2]&lt;=1
	/// \pre val_exists: val!=0
	/// \pre valid_size: sizeof(val)==c-&gt;GetNumberOfPointCenteredComponents()
	/// </summary>
	public virtual void InterpolateTuple(vtkGenericAttributeCollection c, IntPtr pcoords, IntPtr val)
	{
		vtkGenericAdaptorCell_InterpolateTuple_34(GetCppThis(), c?.GetCppThis() ?? default(HandleRef), pcoords, val);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IntersectWithLine_35(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Is there an intersection between the current cell and the ray (`p1',`p2')
	/// according to a tolerance `tol'? If true, `x' is the global intersection,
	/// `t' is the parametric coordinate for the line, `pcoords' are the
	/// parametric coordinates for cell. `subId' is the sub-cell where
	/// the intersection occurs.
	/// \pre positive_tolerance: tol&gt;0
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkGenericAdaptorCell_IntersectWithLine_35(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IsA_36(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericAdaptorCell_IsA_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IsAttributeLinear_37(HandleRef pThis, HandleRef a);

	/// <summary>
	/// Does the attribute `a' have a non-linear interpolation?
	/// \pre a_exists: a!=0
	/// \post definition: result==(GetAttributeOrder()==1)
	/// </summary>
	public int IsAttributeLinear(vtkGenericAttribute a)
	{
		return vtkGenericAdaptorCell_IsAttributeLinear_37(GetCppThis(), a?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IsFaceOnBoundary_38(HandleRef pThis, long faceId);

	/// <summary>
	/// Is the face `faceId' of the current cell on the exterior boundary of the
	/// dataset?
	/// \pre 3d: GetDimension()==3
	/// </summary>
	public virtual int IsFaceOnBoundary(long faceId)
	{
		return vtkGenericAdaptorCell_IsFaceOnBoundary_38(GetCppThis(), faceId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IsGeometryLinear_39(HandleRef pThis);

	/// <summary>
	/// Does the cell have a non-linear interpolation for the geometry?
	/// \post definition: result==(GetGeometryOrder()==1)
	/// </summary>
	public int IsGeometryLinear()
	{
		return vtkGenericAdaptorCell_IsGeometryLinear_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IsInDataSet_40(HandleRef pThis);

	/// <summary>
	/// Does `this' a cell of a dataset? (otherwise, it is a boundary cell)
	/// </summary>
	public virtual int IsInDataSet()
	{
		return vtkGenericAdaptorCell_IsInDataSet_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IsOnBoundary_41(HandleRef pThis);

	/// <summary>
	/// Is the cell on the exterior boundary of the dataset?
	/// \pre 2d: GetDimension()==2
	/// </summary>
	public virtual int IsOnBoundary()
	{
		return vtkGenericAdaptorCell_IsOnBoundary_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IsPrimary_42(HandleRef pThis);

	/// <summary>
	/// Is the cell primary (i.e. not composite) ?
	/// </summary>
	public virtual int IsPrimary()
	{
		return vtkGenericAdaptorCell_IsPrimary_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericAdaptorCell_IsTypeOf_43(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericAdaptorCell_IsTypeOf_43(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAdaptorCell_NewCellIterator_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an empty cell iterator. The user is responsible for deleting it.
	/// \post result_exists: result!=0
	/// </summary>
	public virtual vtkGenericCellIterator NewCellIterator()
	{
		vtkGenericCellIterator vtkGenericCellIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAdaptorCell_NewCellIterator_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericCellIterator2 = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericCellIterator2.Register(null);
			}
		}
		return vtkGenericCellIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAdaptorCell_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenericAdaptorCell NewInstance()
	{
		vtkGenericAdaptorCell result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAdaptorCell_NewInstance_45(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericAdaptorCell_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenericAdaptorCell SafeDownCast(vtkObjectBase o)
	{
		vtkGenericAdaptorCell vtkGenericAdaptorCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericAdaptorCell_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAdaptorCell2 = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAdaptorCell2.Register(null);
			}
		}
		return vtkGenericAdaptorCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_Tessellate_47(HandleRef pThis, HandleRef attributes, HandleRef tess, HandleRef points, HandleRef locator, HandleRef cellArray, HandleRef internalPd, HandleRef pd, HandleRef cd, HandleRef types);

	/// <summary>
	/// Tessellate the cell if it is not linear or if at least one attribute of
	/// `attributes' is not linear. The output are linear cells of the same
	/// dimension than the cell. If the cell is linear and all attributes are
	/// linear, the output is just a copy of the current cell.
	/// `points', `cellArray', `pd' and `cd' are cumulative output data arrays
	/// over cell iterations: they store the result of each call to Tessellate().
	/// `internalPd' is initialized by the calling filter and stores the
	/// result of the tessellation.
	/// If it is not null, `types' is filled with the types of the linear cells.
	/// `types' is null when it is called from vtkGenericGeometryFilter and not
	/// null when it is called from vtkGenericDatasetTessellator.
	/// \pre attributes_exist: attributes!=0
	/// \pre tessellator_exists: tess!=0
	/// \pre points_exist: points!=0
	/// \pre cellArray_exists: cellArray!=0
	/// \pre internalPd_exists: internalPd!=0
	/// \pre pd_exist: pd!=0
	/// \pre cd_exists: cd!=0
	/// </summary>
	public virtual void Tessellate(vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, vtkPoints points, vtkIncrementalPointLocator locator, vtkCellArray cellArray, vtkPointData internalPd, vtkPointData pd, vtkCellData cd, vtkUnsignedCharArray types)
	{
		vtkGenericAdaptorCell_Tessellate_47(GetCppThis(), attributes?.GetCppThis() ?? default(HandleRef), tess?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), cellArray?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef), pd?.GetCppThis() ?? default(HandleRef), cd?.GetCppThis() ?? default(HandleRef), types?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericAdaptorCell_TriangulateFace_48(HandleRef pThis, HandleRef attributes, HandleRef tess, int index, HandleRef points, HandleRef locator, HandleRef cellArray, HandleRef internalPd, HandleRef pd, HandleRef cd);

	/// <summary>
	/// Tessellate face `index' of the cell. See Tessellate() for further
	/// explanations.
	/// \pre cell_is_3d: GetDimension()==3
	/// \pre attributes_exist: attributes!=0
	/// \pre tessellator_exists: tess!=0
	/// \pre valid_face: index&gt;=0
	/// \pre points_exist: points!=0
	/// \pre cellArray_exists: cellArray!=0
	/// \pre internalPd_exists: internalPd!=0
	/// \pre pd_exist: pd!=0
	/// \pre cd_exists: cd!=0
	/// </summary>
	public virtual void TriangulateFace(vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, int index, vtkPoints points, vtkIncrementalPointLocator locator, vtkCellArray cellArray, vtkPointData internalPd, vtkPointData pd, vtkCellData cd)
	{
		vtkGenericAdaptorCell_TriangulateFace_48(GetCppThis(), attributes?.GetCppThis() ?? default(HandleRef), tess?.GetCppThis() ?? default(HandleRef), index, points?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), cellArray?.GetCppThis() ?? default(HandleRef), internalPd?.GetCppThis() ?? default(HandleRef), pd?.GetCppThis() ?? default(HandleRef), cd?.GetCppThis() ?? default(HandleRef));
	}
}
