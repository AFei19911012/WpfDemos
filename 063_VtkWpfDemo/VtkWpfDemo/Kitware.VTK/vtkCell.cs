using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCell
/// </summary>
/// <remarks>
///    abstract class to specify cell behavior
///
/// vtkCell is an abstract class that specifies the interfaces for data cells.
/// Data cells are simple topological elements like points, lines, polygons,
/// and tetrahedra of which visualization datasets are composed. In some
/// cases visualization datasets may explicitly represent cells (e.g.,
/// vtkPolyData, vtkUnstructuredGrid), and in some cases, the datasets are
/// implicitly composed of cells (e.g., vtkStructuredPoints).
///
/// @warning
/// The \#define VTK_CELL_SIZE is a parameter used to construct cells and provide
/// a general guideline for controlling object execution. This parameter is
/// not a hard boundary: you can create cells with more points.
///
/// </remarks>
/// <seealso>
///
/// vtkHexahedron vtkLine vtkPixel vtkPolyLine vtkPolyVertex
/// vtkPolygon vtkQuad vtkTetra vtkTriangle
/// vtkTriangleStrip vtkVertex vtkVoxel vtkWedge vtkPyramid
/// </seealso>
public abstract class vtkCell : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCell";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCell()
	{
		MRClassNameKey = "class vtkCell";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCell"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkCell_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

	/// <summary>
	/// Given parametric coordinates of a point, return the closest cell
	/// boundary, and whether the point is inside or outside of the cell. The
	/// cell boundary is defined by a list of points (pts) that specify a face
	/// (3D cell), edge (2D cell), or vertex (1D cell). If the return value of
	/// the method is != 0, then the point is inside the cell.
	/// </summary>
	public virtual int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
	{
		return vtkCell_CellBoundary_01(GetCppThis(), subId, pcoords, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

	/// <summary>
	/// Cut (or clip) the cell based on the input cellScalars and the
	/// specified value. The output of the clip operation will be one or
	/// more cells of the same topological dimension as the original cell.
	/// The flag insideOut controls what part of the cell is considered inside -
	/// normally cell points whose scalar value is greater than "value" are
	/// considered inside. If insideOut is on, this is reversed. Also, if the
	/// output cell data is non-nullptr, the cell data from the clipped cell is
	/// passed to the generated contouring primitives. (Note: the CopyAllocate()
	/// method must be invoked on both the output cell and point data. The
	/// cellId refers to the cell from which the cell data is copied.)
	/// </summary>
	public virtual void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
	{
		vtkCell_Clip_02(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), connectivity?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef), insideOut);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCell_ComputeBoundingSphere_03(HandleRef pThis, IntPtr center);

	/// <summary>
	/// Computes the bounding sphere of the cell. If the number of points in the cell is lower
	/// or equal to 4, an exact bounding sphere is computed. If not, Ritter's algorithm
	/// is followed. If the input sphere has zero points, then each coordinate of
	/// center is set to NaN, as well as the returned distance.
	///
	/// This method computes the center of the sphere, and returns its squared radius.
	/// </summary>
	public virtual double ComputeBoundingSphere(IntPtr center)
	{
		return vtkCell_ComputeBoundingSphere_03(GetCppThis(), center);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_Contour_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

	/// <summary>
	/// Generate contouring primitives. The scalar list cellScalars are
	/// scalar values at each cell point. The point locator is essentially a
	/// points list that merges points as they are inserted (i.e., prevents
	/// duplicates). Contouring primitives can be vertices, lines, or
	/// polygons. It is possible to interpolate point data along the edge
	/// by providing input and output point data - if outPd is nullptr, then
	/// no interpolation is performed. Also, if the output cell data is
	/// non-nullptr, the cell data from the contoured cell is passed to the
	/// generated contouring primitives. (Note: the CopyAllocate() method
	/// must be invoked on both the output cell and point data. The
	/// cellId refers to the cell from which the cell data is copied.)
	/// </summary>
	public virtual void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
	{
		vtkCell_Contour_04(GetCppThis(), value, cellScalars?.GetCppThis() ?? default(HandleRef), locator?.GetCppThis() ?? default(HandleRef), verts?.GetCppThis() ?? default(HandleRef), lines?.GetCppThis() ?? default(HandleRef), polys?.GetCppThis() ?? default(HandleRef), inPd?.GetCppThis() ?? default(HandleRef), outPd?.GetCppThis() ?? default(HandleRef), inCd?.GetCppThis() ?? default(HandleRef), cellId, outCd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_DeepCopy_05(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Copy this cell by completely copying internal data structures. This is
	/// slower but safer than ShallowCopy().
	/// </summary>
	public virtual void DeepCopy(vtkCell c)
	{
		vtkCell_DeepCopy_05(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_Derivatives_06(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

	/// <summary>
	/// Compute derivatives given cell subId and parametric coordinates. The
	/// values array is a series of data value(s) at the cell points. There is a
	/// one-to-one correspondence between cell point and data value(s). Dim is
	/// the number of data values per cell point. Derivs are derivatives in the
	/// x-y-z coordinate directions for each data value. Thus, if computing
	/// derivatives for a scalar function in a hexahedron, dim=1, 8 values are
	/// supplied, and 3 deriv values are returned (i.e., derivatives in x-y-z
	/// directions). On the other hand, if computing derivatives of velocity
	/// (vx,vy,vz) dim=3, 24 values are supplied ((vx,vy,vz)1, (vx,vy,vz)2,
	/// ....()8), and 9 deriv values are returned
	/// ((d(vx)/dx),(d(vx)/dy),(d(vx)/dz), (d(vy)/dx),(d(vy)/dy), (d(vy)/dz),
	/// (d(vz)/dx),(d(vz)/dy),(d(vz)/dz)).
	/// </summary>
	public virtual void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
	{
		vtkCell_Derivatives_06(GetCppThis(), subId, pcoords, values, dim, derivs);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_EvaluateLocation_07(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

	/// <summary>
	/// Determine global coordinate (x[3]) from subId and parametric coordinates.
	/// Also returns interpolation weights. (The number of weights is equal to
	/// the number of points in the cell.)
	/// </summary>
	public virtual void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
	{
		vtkCell_EvaluateLocation_07(GetCppThis(), ref subId, pcoords, x, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_EvaluatePosition_08(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

	/// <summary>
	/// Given a point x[3] return inside(=1), outside(=0) cell, or (-1)
	/// computational problem encountered; evaluate
	/// parametric coordinates, sub-cell id (!=0 only if cell is composite),
	/// distance squared of point x[3] to cell (in particular, the sub-cell
	/// indicated), closest point on cell to x[3] (unless closestPoint is null,
	/// in which case, the closest point and dist2 are not found), and
	/// interpolation weights in cell. (The number of weights is equal to the
	/// number of points defining the cell). Note: on rare occasions a -1 is
	/// returned from the method. This means that numerical error has occurred
	/// and all data returned from this method should be ignored. Also,
	/// inside/outside is determine parametrically. That is, a point is inside
	/// if it satisfies parametric limits. This can cause problems for cells of
	/// topological dimension 2 or less, since a point in 3D can project onto
	/// the cell within parametric limits but be "far" from the cell.  Thus the
	/// value dist2 may be checked to determine true in/out.
	/// </summary>
	public virtual int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
	{
		return vtkCell_EvaluatePosition_08(GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_GetBounds_09(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Compute cell bounding box (xmin,xmax,ymin,ymax,zmin,zmax). Copy result
	/// into user provided array.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkCell_GetBounds_09(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_GetBounds_10(HandleRef pThis);

	/// <summary>
	/// Compute cell bounding box (xmin,xmax,ymin,ymax,zmin,zmax). Return pointer
	/// to array of six double values.
	/// </summary>
	public double[] GetBounds()
	{
		IntPtr intPtr = vtkCell_GetBounds_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_GetCellDimension_11(HandleRef pThis);

	/// <summary>
	/// Return the topological dimensional of the cell (0,1,2, or 3).
	/// </summary>
	public virtual int GetCellDimension()
	{
		return vtkCell_GetCellDimension_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_GetCellType_12(HandleRef pThis);

	/// <summary>
	/// Return the type of cell.
	/// </summary>
	public virtual int GetCellType()
	{
		return vtkCell_GetCellType_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_GetEdge_13(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the edge cell from the edgeId of the cell.
	/// </summary>
	public virtual vtkCell GetEdge(int edgeId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCell_GetEdge_13(GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_GetFace_14(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the face cell from the faceId of the cell. The returned vtkCell
	/// is an object owned by this instance, hence the return value
	/// must not be deleted by the caller.
	///
	/// @warning Repeat calls to this function for different face ids will change
	/// the data stored in the internal member object whose pointer is returned by
	/// this function.
	///
	/// @warning THIS METHOD IS NOT THREAD SAFE.
	/// </summary>
	public virtual vtkCell GetFace(int faceId)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCell_GetFace_14(GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_GetFaces_15(HandleRef pThis);

	/// <summary>
	/// Determine whether the cell requires explicit face representation, and
	/// methods for setting and getting the faces (see vtkPolyhedron for example
	/// usage of these methods).
	/// </summary>
	public virtual IntPtr GetFaces()
	{
		return vtkCell_GetFaces_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCell_GetLength2_16(HandleRef pThis);

	/// <summary>
	/// Compute Length squared of cell (i.e., bounding box diagonal squared).
	/// </summary>
	public double GetLength2()
	{
		return vtkCell_GetLength2_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_GetNumberOfEdges_17(HandleRef pThis);

	/// <summary>
	/// Return the number of edges in the cell.
	/// </summary>
	public virtual int GetNumberOfEdges()
	{
		return vtkCell_GetNumberOfEdges_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_GetNumberOfFaces_18(HandleRef pThis);

	/// <summary>
	/// Return the number of faces in the cell.
	/// </summary>
	public virtual int GetNumberOfFaces()
	{
		return vtkCell_GetNumberOfFaces_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCell_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCell_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCell_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCell_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCell_GetNumberOfPoints_21(HandleRef pThis);

	/// <summary>
	/// Return the number of points in the cell.
	/// </summary>
	public long GetNumberOfPoints()
	{
		return vtkCell_GetNumberOfPoints_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_GetParametricCenter_22(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return center of the cell in parametric coordinates.  Note that the
	/// parametric center is not always located at (0.5,0.5,0.5). The return
	/// value is the subId that the center is in (if a composite cell). If you
	/// want the center in x-y-z space, invoke the EvaluateLocation() method.
	/// </summary>
	public virtual int GetParametricCenter(IntPtr pcoords)
	{
		return vtkCell_GetParametricCenter_22(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_GetParametricCoords_23(HandleRef pThis);

	/// <summary>
	/// Return a contiguous array of parametric coordinates of the points
	/// defining this cell. In other words, (px,py,pz, px,py,pz, etc..)  The
	/// coordinates are ordered consistent with the definition of the point
	/// ordering for the cell. This method returns a non-nullptr pointer when
	/// the cell is a primary type (i.e., IsPrimaryCell() is true). Note that
	/// 3D parametric coordinates are returned no matter what the topological
	/// dimension of the cell.
	/// </summary>
	public virtual IntPtr GetParametricCoords()
	{
		return vtkCell_GetParametricCoords_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCell_GetParametricDistance_24(HandleRef pThis, IntPtr pcoords);

	/// <summary>
	/// Return the distance of the parametric coordinate provided to the
	/// cell. If inside the cell, a distance of zero is returned. This is
	/// used during picking to get the correct cell picked. (The tolerance
	/// will occasionally allow cells to be picked who are not really
	/// intersected "inside" the cell.)
	/// </summary>
	public virtual double GetParametricDistance(IntPtr pcoords)
	{
		return vtkCell_GetParametricDistance_24(GetCppThis(), pcoords);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCell_GetPointId_25(HandleRef pThis, int ptId);

	/// <summary>
	/// For cell point i, return the actual point id.
	/// </summary>
	public long GetPointId(int ptId)
	{
		return vtkCell_GetPointId_25(GetCppThis(), ptId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_GetPointIds_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the list of point ids defining the cell.
	/// </summary>
	public vtkIdList GetPointIds()
	{
		vtkIdList vtkIdList2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCell_GetPointIds_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdList2 = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdList2.Register(null);
			}
		}
		return vtkIdList2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_GetPoints_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the point coordinates for the cell.
	/// </summary>
	public vtkPoints GetPoints()
	{
		vtkPoints vtkPoints2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCell_GetPoints_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoints2 = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoints2.Register(null);
			}
		}
		return vtkPoints2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_Inflate_28(HandleRef pThis, double dist);

	/// <summary>
	/// Inflates the cell. Each edge is displaced following its normal by a
	/// distance of value `dist`. If dist is negative, then the cell shrinks.
	/// The resulting cell edges / faces are colinear / coplanar to their previous
	/// self.
	///
	/// The cell is assumed to be non-degenerate and to have no
	/// edge of length zero for linear 2D cells.
	/// If it is not the case, then no inflation is performed.
	/// This method needs to be overridden by inheriting non-linear / non-2D cells.
	///
	/// \return 1 if inflation was successful, 0 if no inflation was performed
	/// </summary>
	public virtual int Inflate(double dist)
	{
		return vtkCell_Inflate_28(GetCppThis(), dist);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_Initialize_29(HandleRef pThis, int npts, IntPtr pts, HandleRef p);

	/// <summary>
	/// Initialize cell from outside with point ids and point
	/// coordinates specified.
	/// </summary>
	public void Initialize(int npts, IntPtr pts, vtkPoints p)
	{
		vtkCell_Initialize_29(GetCppThis(), npts, pts, p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_Initialize_30(HandleRef pThis, int npts, HandleRef p);

	/// <summary>
	/// Initialize the cell with point coordinates specified. Note that this
	/// simplified version of Initialize() assumes that the point ids are simply
	/// the indices into the supplied points array. Make sure that the ordering
	/// of the points is consistent with the definition of the cell.
	/// </summary>
	public void Initialize(int npts, vtkPoints p)
	{
		vtkCell_Initialize_30(GetCppThis(), npts, p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_Initialize_31(HandleRef pThis);

	/// <summary>
	/// Some cells require initialization prior to access. For example, they
	/// may have to triangulate themselves or set up internal data structures.
	/// </summary>
	public virtual void Initialize()
	{
		vtkCell_Initialize_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_InterpolateDerivs_32(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// No-ops at this level. Typically overridden in subclasses.
	/// </summary>
	public virtual void InterpolateDerivs(IntPtr arg0, IntPtr arg1)
	{
		vtkCell_InterpolateDerivs_32(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_InterpolateFunctions_33(HandleRef pThis, IntPtr arg0, IntPtr arg1);

	/// <summary>
	/// Compute the interpolation functions/derivatives
	/// (aka shape functions/derivatives)
	/// No-ops at this level. Typically overridden in subclasses.
	/// </summary>
	public virtual void InterpolateFunctions(IntPtr arg0, IntPtr arg1)
	{
		vtkCell_InterpolateFunctions_33(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_IntersectWithCell_34(HandleRef pThis, HandleRef other, double tol);

	/// <summary>
	/// Intersects with an other cell. Returns 1 if cells intersect, 0 otherwise.
	/// If an exact intersection detection with regards to floating point precision is wanted,
	/// tol should be disregarded.
	/// `vtkBoundingBox` are optional parameters which slightly improve the speed of the computation
	/// if bounding boxes are already available to user.
	/// </summary>
	public virtual int IntersectWithCell(vtkCell other, double tol)
	{
		return vtkCell_IntersectWithCell_34(GetCppThis(), other?.GetCppThis() ?? default(HandleRef), tol);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_IntersectWithLine_35(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

	/// <summary>
	/// Intersect with a ray. Return parametric coordinates (both line and cell)
	/// and global intersection coordinates, given ray definition p1[3], p2[3] and tolerance tol.
	/// The method returns non-zero value if intersection occurs. A parametric distance t
	/// between 0 and 1 along the ray representing the intersection point, the point coordinates
	/// x[3] in data coordinates and also pcoords[3] in parametric coordinates. subId is the index
	/// within the cell if a composed cell like a triangle strip.
	/// </summary>
	public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
	{
		return vtkCell_IntersectWithLine_35(GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_IsA_36(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCell_IsA_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_IsExplicitCell_37(HandleRef pThis);

	/// <summary>
	/// Explicit cells require additional representational information
	/// beyond the usual cell type and connectivity list information.
	/// Most cells in VTK are implicit cells.
	/// </summary>
	public virtual int IsExplicitCell()
	{
		return vtkCell_IsExplicitCell_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_IsLinear_38(HandleRef pThis);

	/// <summary>
	/// Non-linear cells require special treatment beyond the usual cell type
	/// and connectivity list information.  Most cells in VTK are implicit
	/// cells.
	/// </summary>
	public virtual int IsLinear()
	{
		return vtkCell_IsLinear_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_IsPrimaryCell_39(HandleRef pThis);

	/// <summary>
	/// Return whether this cell type has a fixed topology or whether the
	/// topology varies depending on the data (e.g., vtkConvexPointSet).
	/// This compares to composite cells that are typically composed of
	/// primary cells (e.g., a triangle strip composite cell is made up of
	/// triangle primary cells).
	/// </summary>
	public virtual int IsPrimaryCell()
	{
		return vtkCell_IsPrimaryCell_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_IsTypeOf_40(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCell_IsTypeOf_40(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCell NewInstance()
	{
		vtkCell result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCell_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_RequiresExplicitFaceRepresentation_42(HandleRef pThis);

	/// <summary>
	/// Determine whether the cell requires explicit face representation, and
	/// methods for setting and getting the faces (see vtkPolyhedron for example
	/// usage of these methods).
	/// </summary>
	public virtual int RequiresExplicitFaceRepresentation()
	{
		return vtkCell_RequiresExplicitFaceRepresentation_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_RequiresInitialization_43(HandleRef pThis);

	/// <summary>
	/// Some cells require initialization prior to access. For example, they
	/// may have to triangulate themselves or set up internal data structures.
	/// </summary>
	public virtual int RequiresInitialization()
	{
		return vtkCell_RequiresInitialization_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCell_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCell SafeDownCast(vtkObjectBase o)
	{
		vtkCell vtkCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCell_SafeDownCast_44(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCell2 = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCell2.Register(null);
			}
		}
		return vtkCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_SetFaces_45(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Determine whether the cell requires explicit face representation, and
	/// methods for setting and getting the faces (see vtkPolyhedron for example
	/// usage of these methods).
	/// </summary>
	public virtual void SetFaces(IntPtr arg0)
	{
		vtkCell_SetFaces_45(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCell_ShallowCopy_46(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Copy this cell by reference counting the internal data structures.
	/// This is safe if you want a "read-only" copy. If you modify the cell
	/// you might wish to use DeepCopy().
	/// </summary>
	public virtual void ShallowCopy(vtkCell c)
	{
		vtkCell_ShallowCopy_46(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCell_Triangulate_47(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

	/// <summary>
	/// Generate simplices of proper dimension. If cell is 3D, tetrahedron are
	/// generated; if 2D triangles; if 1D lines; if 0D points. The form of the
	/// output is a sequence of points, each n+1 points (where n is topological
	/// cell dimension) defining a simplex. The index is a parameter that controls
	/// which triangulation to use (if more than one is possible). If numerical
	/// degeneracy encountered, 0 is returned, otherwise 1 is returned.
	/// This method does not insert new points: all the points that define the
	/// simplices are the points that define the cell.
	/// </summary>
	public virtual int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
	{
		return vtkCell_Triangulate_47(GetCppThis(), index, ptIds?.GetCppThis() ?? default(HandleRef), pts?.GetCppThis() ?? default(HandleRef));
	}
}
