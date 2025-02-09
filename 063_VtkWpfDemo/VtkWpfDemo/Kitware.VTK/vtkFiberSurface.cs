using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkFiberSurface
/// </summary>
/// <remarks>
///  Given a fiber surface control polygon (FSCP) and an
/// unstructured grid composed of tetrahedral cells with two scalar arrays, this filter
/// computes the corresponding fiber surfaces.
///
/// @section vtkFiberSurface-introduction Introduction
/// Fiber surfaces are constructed from sets of fibers, the multivariate analogues
/// of isolines. The original paper [0] offers a general purpose method that produces
/// separating surfaces representing boundaries in bivariate fields. This filter is based
/// on an improvement over [0] which computes accurate and exact fiber surfaces. It can
/// handle arbitrary input polygons including open polygons or self-intersecting polygons.
/// The current implementation can better captures sharp features induced by polygon
/// bends [1].
///
/// [0] Hamish Carr, Zhao Geng, Julien Tierny, Amit Chattopadhyay and Aaron Knoll,
///     Fiber Surfaces: Generalizing Isosurfaces to Bivariate Data,
///     Computer Graphics Forum, Volume 34, Issue 3, Pages 241-250, (EuroVis 2015)
///
/// [1] Pavol Klacansky, Julien Tierny, Hamish Carr, Zhao Geng,
///     Fast and Exact Fiber Surfaces for Tetrahedral Meshes,
///     Paper in submission, 2015
///
/// @section vtkFiberSurface-algorithm Algorithm For Extracting An Exact Fiber Surface
///  Require: R.1 A 3D domain space represented by an unstructured grid composed of
///               tetrahedral cells
///           R.2 Two scalar fields, f1 and f2, that map the domain space to a 2D range
///               space. These fields are assumed to be known at vertices of the
///               unstructured grid: i.e they are two fields associated with the
///               unstructured grid.
///           R.3 A Fiber Surface Control Polygon (FSCP) defined in the range space as a
///               list of line segments (l1, l2, ..., ln). The FSCP may be an open polyline
///               or a self-intersecting polygon.
///
///   1. For each line segment l in FSCP, we ignore the endpoints of the line and assume
///      this line extends to infinity. This line will then separate the range and its
///      inverse image, i.e fiber surfaces, will also separate the domain. Based on the
///      signed distance d between the image of a cell vertex v and line l in the range,
///      v can be classified as white (d &lt; 0), grey (d == 0) or black (d&gt;0). The
///      interpolation parameter between two vertices v1 and v2 in a cell edge can be
///      computed as |d1| / (|d2|+|d1|), where d1 and d2 are the signed distances between
///      images of v1,v2 and line l in the range. Once the classification and interpolation
///      parameters for all vertices in a cell are known, then we can apply the Marching
///      Tetrahedra algorithm. For each tetrahedron, this produces a planar cut which we
///      refer to as a base fiber surface.
///
///   2. After generating the base fiber surface in each cell, we need a further clipping
///      process to obtain the accurate fiber surface. Clipping is based on classifying the
///      vertices of each triangle as follows:
///      Given a line segment in the fiber surface control polygon (FSCP) parameterised
///      from 0 to 1, we know that every triangle vertex in the base fiber surface belongs
///      to the fiber surface, and that the fiber through each vertex can be parameterised
///      with respect to the line segment. Therefore, we compute the parameter t for each
///      vertex and use it to classify the vertex as:
///           0: t &lt; 0        Vertex is below the clipping range [0,1] and will be removed
///           1: 0 ≤ t ≤ 1    Vertex is inside the clipping range [0,1] and is retained
///           2: 1 &lt; t        Vertex is above the clipping  range [0,1] and will be removed
///      Based on the classification, we can further clip the triangle to obtain the final
///      surface.
///
///   3. Repeating steps 1 and 2 for every line segment in FSCP and iterating through each
///      cell will generate the final fiber surfaces in the domain.
///
/// @section VTK Filter Design
/// As stated in part B (R.1), we will compute the fiber surface over an unstructured grid.
/// This grid will have to be an input of the VTK filter. The two scalar fields, however,
/// are assumed to be stored in the VTK unstructured grid, and will be specified using the
/// SetField1() and SetField2() accessors. The FSCP will be passed into the filter as a
/// second input port. The data type of FSCP is required to be a vtkPolyData, with each of
/// its cell defined as a line segment and its point coordinates defined in the range of
/// the bivariate fields of the input grid.
///
/// @section Case Tables
/// @subsection Marching tetrahedra with grey cases
/// In this filter, we have added one vertex classification in Marching Tetrahedra. The
/// reason is because we need a grey classification to ensure that surfaces coincident with
/// the boundary of the tetrahedra will also be included in the output. Given an iso-value,
/// each vertex on the tetrahedron can be classified into three types, including
/// equal-(G)rey, below-(W)hite or above-(B)lack the isovalue.
/// The notation of the classifications are represented as:
///     W or 0 --- below an iso-value
///     G or 1 --- equal an iso-value
///     B or 2 --- above an iso-value
/// The following illustration summarises all of the surface cases (Asterisk * is used to
/// highlight the outline of the triangle):
/// Case A (no triangles): 0000
///    No triangle is generated.
///
///          W
///         ...
///        . . .
///       .  .  .
///      .  .W.  .
///     . .     . .
///    W...........W
///
/// Case B (one grey vertex): 0001, 0010, 0100, 1000
///    Only a vertex is kept, no triangle is generated.
///          W
///         ...
///        . . .
///       .  .  .
///      .  .G.  .
///     . .     . .
///    W...........W
///
/// Case C (one grey edge): 0011, 0101, 0110, 1001, 1010, 1100
///    Only an edge is kept, no triangle is generated.
///          G
///         ...
///        . . .
///       .  .  .
///      .  .G.  .
///     . .     . .
///    W...........W
///
/// Case D (standard triangle case): 0002, 0020, 0200, 2000
///    One triangle is generated
///          W                           W
///         ...                         ...
///        . . .                       . * .
///       .  .  .                     . *.* .
///      .  .B.  .        -&gt;         . * B * .
///     . .     . .                 . ** * ** .
///    W...........W               W...........W
///
/// Case E (one grey face): 0111, 1011, 1101, 1110
///    The triangle on one face of the tetra is generated.
///          G                          G
///         ...                        .**
///        . . .                      . * *
///       .  .  .         -&gt;         .  *  *
///      .  .G.  .                  .  .G*  *
///     . .     . .                . .     * *
///    W...........G              W...........G
///
/// Case F (triangle through vertex):  0012 0021 0102 0120 0201 0210
///                                    1002 1020 1200 2001 2010 2100
///    A triangle connecting one of the tetra vertex is generated.
///          G                          G
///         ...                        .*.
///        . . .                      .*.*.
///       .  .  .         -&gt;         . *.* .
///      .  .B.  .                  . *.B.* .
///     . .     . .                . * * * * .
///    W...........W              W...........W
///
/// Case G (grey tet - treat as empty): 1111
///    No triangle is generated.
///          G
///         ...
///        . . .
///       .  .  .
///      .  .G.  .
///     . .     . .
///    G...........G
///
/// Case H (triangle through edge): 0112 0121 0211 1012 1021 1102
///                                 1120 1201 1210 2011 2101 2110
///    A triangle containing an edge of the tetra is generated.
///
///          G                                      G
///         ...                                    ..*
///        . . .                                  . . *
///       .  .  .                                . *.  *
///      .   .   .                              .   .   *
///     .    .    .           -&gt;               . *  .    *
///    .   . W .   .                          .   . W .   *
///   .  .      .   .                        .  *      .   *
///  . .          .  .                      . .      *   .  *
///  B.............. G                      B...............G
///
/// Case I (standard quad case): 0022 0202 0220 2002 2020 2200
///   A quand is generated, which can be split to two triangles.
///
///          W                                      W
///         ...                                    ...
///        . . .                                  . . .
///       .  .  .                                .  .  .
///      .   .   .                              *  *. * *
///     .    .    .           -&gt;               .*   .   *.
///    .   . W .   .                          . * . W . * .
///   .  .      .   .                        .  * *  *  *   .
///  . .          .  .                      . .            . .
///  B.............. B                     B..................B
///
/// Case J (complement of Case E): 1112 1121 1211 2111
/// Case K (complement of Case F): 0122 0212 0221 1022 1202
///                                1220 2012 2021 2102 2120 2201 2210
/// Case L (complement of Case C): 1122 1212 1221 2112 2121 2211
/// Case M (complement of Case D): 0222 2022 2202 2220
/// Case N (complement of Case B): 1222 2122 2212 2221
/// Case O (complement of Case A): 2222
///
/// @subsection Clipping cases of the base fiber surface
/// After generating the base fiber surface in each cell, we need a further clipping
/// process to obtain the accurate fiber surface. Clipping is based on classifying the
/// vertices of each triangle to several cases, which will be described in this section.
/// In order to keep things consistent, we assume that the vertices are ordered CCW, and
/// that edges are numbered according to the opposing vertex:
///
///      v0
///     /  \
///   e2    e1
///   /      \
/// v1---e0---v2
///
/// =======================================================================
/// There are six cases for clipping the base fiber surface (subject to the usual
/// symmetries &amp; complementarity)
///             ------------------------------------------------------------------------
/// Case A (No triangles): Cases 000 &amp; 222
/// Here, the entire triangle is discarded
///
/// 000(A):  0
///         . .
///        .   .
///       .     .
///      .       .
///     .         .
///    0...........0
///
///             ------------------------------------------------------------------------
/// Case B (Point-triangle): Cases 001, 010, 100, 122, 212, 221
/// One vertex is kept, and a single triangle is extracted
///
/// 001(B):  1
///         / \
///        /   \
///       E-----E
///      .       .
///     .         .
///    0...........0
///
///             ------------------------------------------------------------------------
/// Case C (Edge Quad): Cases 011, 101, 110, 112, 121, 211
/// Two vertices are kept, and a quad is extracted based on the edge
///
/// 011(C):  1
///         /|\
///        / | \
///       /  |  E
///      /   | / .
///     /    |/   .
///    1-----E.....0
///
///             ------------------------------------------------------------------------
/// Case D (Stripe): Cases 002, 020, 022, 200, 202, 220
/// No vertices are kept, but a stripe across the middle is generated
///
/// 022(D):  2
///         . .
///        .   E
///       .   /|\
///      .   / | E
///     .   /  |/ .
///    2...E---E...0
///
///             ------------------------------------------------------------------------
/// Case E (Point-Stripe): Cases 012, 021, 102, 120, 201, 210
/// One vertex is kept, with a stripe through the triangle
///
/// 021(E):  1
///         / \
///        E---E
///       .|\  |.
///      . | \ | .
///     .  |  \|  .
///    2...E---E...0
///
///             ------------------------------------------------------------------------
/// Case F (Entire): Case 111
/// All three vertices are kept, along with the triangle
///
/// 111(F):  1
///         / \
///        /   \
///       /     \
///      /       \
///     /         \
///    1-----------1
///
///
/// @section How to use this filter
/// Suppose we have a tetrahedral mesh stored in a vtkUnstructuredGrid, we call this
/// data set "inputData". This data set has two scalar arrays whose names are "f1"
/// and "f2" respectively. Assume the "inputPoly" is a valid input polygon. Given
/// these input above, this filter can be used as follows in c++ sample code:
///
///     vtkSmartPointer&lt;vtkFiberSurface&gt; fiberSurface =
///                            vtkSmartPointer&lt;vtkFiberSurface&gt;::New();
///     fiberSurface-&gt;SetInputData(0,inputData);
///     fiberSurface-&gt;SetInputData(1,inputPoly);
///     fiberSurface-&gt;SetField1("f1");
///     fiberSurface-&gt;SetField2("f2");
///     fiberSurface-&gt;Update();
///
/// The filter output which can be called by "fiberSurface-&gt;GetOutput()", will be a
/// vtkPolyData containing the output fiber surfaces.
/// </remarks>
public class vtkFiberSurface : vtkPolyDataAlgorithm
{
	/// <summary>
	/// This structure lists the vertices to use for the marching tetrahedra,
	/// Some of these vertices need to be interpolated, but others are the vertices of
	/// the tetrahedron already, and for this we need to store the type of vertex.
	/// bv_not_used: Symbol for an unused entry
	/// bv_vertex_*: Vertices on a tetrahedron
	/// bv_edge_*: Vertices on the edges of a tetrahedron
	/// </summary>
	public enum BaseVertexType
	{
		/// <summary>enum member</summary>
		bv_edge_01 = 5,
		/// <summary>enum member</summary>
		bv_edge_02 = 6,
		/// <summary>enum member</summary>
		bv_edge_03 = 7,
		/// <summary>enum member</summary>
		bv_edge_12 = 8,
		/// <summary>enum member</summary>
		bv_edge_13 = 9,
		/// <summary>enum member</summary>
		bv_edge_23 = 10,
		/// <summary>enum member</summary>
		bv_not_used = 0,
		/// <summary>enum member</summary>
		bv_vertex_0 = 1,
		/// <summary>enum member</summary>
		bv_vertex_1 = 2,
		/// <summary>enum member</summary>
		bv_vertex_2 = 3,
		/// <summary>enum member</summary>
		bv_vertex_3 = 4
	}

	/// <summary>
	/// After generating the base fiber surface in each cell, we need a further clipping
	/// process to obtain the accurate fiber surface. Clipping is based on classifying the
	/// vertices of each triangle, this structure lists the type of vertices to be used for
	/// the clipping triangles.
	/// Some of these vertices need to be interpolated, but others are the vertices of
	/// the triangle already, and for this we need to store the type of vertex.
	/// Moreover, vertices along the edges of the triangle may be interpolated either at
	/// parameter value 0 or at parameter value 1. In other words, there are three classes
	/// of vertex with three choices of each, with a total of nine vertices. We therefore
	/// store an ID code for each possibility as follows:
	/// </summary>
	public enum ClipVertexType
	{
		/// <summary>enum member</summary>
		edge_0_parm_0 = 4,
		/// <summary>enum member</summary>
		edge_0_parm_1 = 7,
		/// <summary>enum member</summary>
		edge_1_parm_0 = 5,
		/// <summary>enum member</summary>
		edge_1_parm_1 = 8,
		/// <summary>enum member</summary>
		edge_2_parm_0 = 6,
		/// <summary>enum member</summary>
		edge_2_parm_1 = 9,
		/// <summary>enum member</summary>
		not_used = 0,
		/// <summary>enum member</summary>
		vertex_0 = 1,
		/// <summary>enum member</summary>
		vertex_1 = 2,
		/// <summary>enum member</summary>
		vertex_2 = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFiberSurface";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFiberSurface()
	{
		MRClassNameKey = "class vtkFiberSurface";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFiberSurface"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFiberSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFiberSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFiberSurface New()
	{
		vtkFiberSurface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFiberSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFiberSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFiberSurface()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFiberSurface_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFiberSurface_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFiberSurface_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFiberSurface_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFiberSurface_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFiberSurface_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFiberSurface_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFiberSurface_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFiberSurface_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFiberSurface_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFiberSurface NewInstance()
	{
		vtkFiberSurface result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFiberSurface_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFiberSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFiberSurface_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFiberSurface SafeDownCast(vtkObjectBase o)
	{
		vtkFiberSurface vtkFiberSurface2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFiberSurface_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFiberSurface2 = (vtkFiberSurface)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFiberSurface2.Register(null);
			}
		}
		return vtkFiberSurface2;
	}

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFiberSurface_SetField1_08(HandleRef pThis, string fieldName);

	/// <summary>
	/// Specify the first field name to be used in this filter.
	/// </summary>
	public void SetField1(string fieldName)
	{
		vtkFiberSurface_SetField1_08(GetCppThis(), fieldName);
	}

	[DllImport("Kitware.VTK.FiltersTopology.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFiberSurface_SetField2_09(HandleRef pThis, string fieldName);

	/// <summary>
	/// Specify the second field name to be used in the filter.
	/// </summary>
	public void SetField2(string fieldName)
	{
		vtkFiberSurface_SetField2_09(GetCppThis(), fieldName);
	}
}
