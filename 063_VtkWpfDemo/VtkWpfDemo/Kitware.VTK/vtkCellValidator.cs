using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellValidator
/// </summary>
/// <remarks>
///    validates cells in a dataset
///
///
/// vtkCellValidator accepts as input a dataset and adds integral cell data
/// to it corresponding to the "validity" of each cell. The validity field
/// encodes a bitfield for identifying problems that prevent a cell from standard
/// use, including:
///
///   WrongNumberOfPoints: filters assume that a cell has access to the
///                        appropriate number of points that comprise it. This
///                        assumption is often tacit, resulting in unexpected
///                        behavior when the condition is not met. This check
///                        simply confirms that the cell has the minimum number
///                        of points needed to describe it.
///
///   IntersectingEdges: cells that incorrectly describe the order of their
///                      points often manifest with intersecting edges or
///                      intersecting faces. Given a tolerance, this check
///                      ensures that two edges from a two-dimensional cell
///                      are separated by at least the tolerance (discounting
///                      end-to-end connections).
///
///   IntersectingFaces: cells that incorrectly describe the order of their
///                      points often manifest with intersecting edges or
///                      intersecting faces. Given a tolerance, this check
///                      ensures that two faces from a three-dimensional cell
///                      do not intersect.
///
///   NoncontiguousEdges: another symptom of incorrect point ordering within a
///                       cell is the presence of noncontiguous edges where
///                       contiguous edges are otherwise expected. Given a
///                       tolerance, this check ensures that edges around the
///                       perimeter of a two-dimensional cell are contiguous.
///
///   Nonconvex: many algorithms implicitly require that all input three-
///              dimensional cells be convex. This check uses the generic
///              convexity checkers implemented in vtkPolygon and vtkPolyhedron
///              to test this requirement.
///
///   FacesAreOrientedIncorrectly: All three-dimensional cells have an implicit
///                                expectation for the orientation of their
///                                faces. While the convention is unfortunately
///                                inconsistent across cell types, it is usually
///                                required that cell faces point outward. This
///                                check tests that the faces of a cell point in
///                                the direction required by the cell type,
///                                taking into account the cell types with
///                                nonstandard orientation requirements.
///
///
/// </remarks>
/// <seealso>
///
/// vtkCellQuality
/// </seealso>
public class vtkCellValidator : vtkDataSetAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum State
	{
		/// <summary>enum member</summary>
		FacesAreOrientedIncorrectly = 32,
		/// <summary>enum member</summary>
		IntersectingEdges = 2,
		/// <summary>enum member</summary>
		IntersectingFaces = 4,
		/// <summary>enum member</summary>
		NoncontiguousEdges = 8,
		/// <summary>enum member</summary>
		Nonconvex = 16,
		/// <summary>enum member</summary>
		Valid = 0,
		/// <summary>enum member</summary>
		WrongNumberOfPoints = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellValidator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellValidator()
	{
		MRClassNameKey = "class vtkCellValidator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellValidator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellValidator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellValidator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellValidator New()
	{
		vtkCellValidator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellValidator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellValidator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCellValidator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellValidator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_01(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkGenericCell arg0, double tolerance)
	{
		return vtkCellValidator_Check_01(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_02(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkCell arg0, double tolerance)
	{
		return vtkCellValidator_Check_02(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_03(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkEmptyCell arg0, double tolerance)
	{
		return vtkCellValidator_Check_03(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_04(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkVertex arg0, double tolerance)
	{
		return vtkCellValidator_Check_04(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_05(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkPolyVertex arg0, double tolerance)
	{
		return vtkCellValidator_Check_05(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_06(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkLine arg0, double tolerance)
	{
		return vtkCellValidator_Check_06(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_07(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkPolyLine arg0, double tolerance)
	{
		return vtkCellValidator_Check_07(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_08(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkTriangle arg0, double tolerance)
	{
		return vtkCellValidator_Check_08(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_09(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkTriangleStrip arg0, double tolerance)
	{
		return vtkCellValidator_Check_09(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_10(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkPolygon arg0, double tolerance)
	{
		return vtkCellValidator_Check_10(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_11(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkPixel arg0, double tolerance)
	{
		return vtkCellValidator_Check_11(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_12(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuad arg0, double tolerance)
	{
		return vtkCellValidator_Check_12(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_13(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkTetra arg0, double tolerance)
	{
		return vtkCellValidator_Check_13(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_14(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkVoxel arg0, double tolerance)
	{
		return vtkCellValidator_Check_14(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_15(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkHexahedron arg0, double tolerance)
	{
		return vtkCellValidator_Check_15(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_16(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkWedge arg0, double tolerance)
	{
		return vtkCellValidator_Check_16(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_17(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkPyramid arg0, double tolerance)
	{
		return vtkCellValidator_Check_17(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_18(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkPentagonalPrism arg0, double tolerance)
	{
		return vtkCellValidator_Check_18(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_19(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkHexagonalPrism arg0, double tolerance)
	{
		return vtkCellValidator_Check_19(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_20(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticEdge arg0, double tolerance)
	{
		return vtkCellValidator_Check_20(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_21(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticTriangle arg0, double tolerance)
	{
		return vtkCellValidator_Check_21(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_22(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticQuad arg0, double tolerance)
	{
		return vtkCellValidator_Check_22(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_23(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticPolygon arg0, double tolerance)
	{
		return vtkCellValidator_Check_23(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_24(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticTetra arg0, double tolerance)
	{
		return vtkCellValidator_Check_24(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_25(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticHexahedron arg0, double tolerance)
	{
		return vtkCellValidator_Check_25(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_26(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticWedge arg0, double tolerance)
	{
		return vtkCellValidator_Check_26(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_27(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticPyramid arg0, double tolerance)
	{
		return vtkCellValidator_Check_27(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_28(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBiQuadraticQuad arg0, double tolerance)
	{
		return vtkCellValidator_Check_28(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_29(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkTriQuadraticHexahedron arg0, double tolerance)
	{
		return vtkCellValidator_Check_29(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_30(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkTriQuadraticPyramid arg0, double tolerance)
	{
		return vtkCellValidator_Check_30(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_31(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticLinearQuad arg0, double tolerance)
	{
		return vtkCellValidator_Check_31(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_32(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkQuadraticLinearWedge arg0, double tolerance)
	{
		return vtkCellValidator_Check_32(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_33(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBiQuadraticQuadraticWedge arg0, double tolerance)
	{
		return vtkCellValidator_Check_33(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_34(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBiQuadraticQuadraticHexahedron arg0, double tolerance)
	{
		return vtkCellValidator_Check_34(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_35(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBiQuadraticTriangle arg0, double tolerance)
	{
		return vtkCellValidator_Check_35(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_36(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkCubicLine arg0, double tolerance)
	{
		return vtkCellValidator_Check_36(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_37(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkConvexPointSet arg0, double tolerance)
	{
		return vtkCellValidator_Check_37(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_38(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkPolyhedron arg0, double tolerance)
	{
		return vtkCellValidator_Check_38(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_39(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkLagrangeCurve arg0, double tolerance)
	{
		return vtkCellValidator_Check_39(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_40(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkLagrangeTriangle arg0, double tolerance)
	{
		return vtkCellValidator_Check_40(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_41(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkLagrangeQuadrilateral arg0, double tolerance)
	{
		return vtkCellValidator_Check_41(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_42(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkLagrangeTetra arg0, double tolerance)
	{
		return vtkCellValidator_Check_42(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_43(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkLagrangeHexahedron arg0, double tolerance)
	{
		return vtkCellValidator_Check_43(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_44(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkLagrangeWedge arg0, double tolerance)
	{
		return vtkCellValidator_Check_44(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_45(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBezierCurve arg0, double tolerance)
	{
		return vtkCellValidator_Check_45(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_46(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBezierTriangle arg0, double tolerance)
	{
		return vtkCellValidator_Check_46(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_47(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBezierQuadrilateral arg0, double tolerance)
	{
		return vtkCellValidator_Check_47(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_48(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBezierTetra arg0, double tolerance)
	{
		return vtkCellValidator_Check_48(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_49(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBezierHexahedron arg0, double tolerance)
	{
		return vtkCellValidator_Check_49(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkCellValidator_Check_50(HandleRef arg0, double tolerance);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static State Check(vtkBezierWedge arg0, double tolerance)
	{
		return vtkCellValidator_Check_50(arg0?.GetCppThis() ?? default(HandleRef), tolerance);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellValidator_GetNumberOfGenerationsFromBase_51(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellValidator_GetNumberOfGenerationsFromBase_51(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellValidator_GetNumberOfGenerationsFromBaseType_52(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellValidator_GetNumberOfGenerationsFromBaseType_52(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellValidator_GetTolerance_53(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance. This value is used as an epsilon for floating point
	/// equality checks throughout the cell checking process. The default value is
	/// FLT_EPSILON.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkCellValidator_GetTolerance_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellValidator_GetToleranceMaxValue_54(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance. This value is used as an epsilon for floating point
	/// equality checks throughout the cell checking process. The default value is
	/// FLT_EPSILON.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkCellValidator_GetToleranceMaxValue_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellValidator_GetToleranceMinValue_55(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance. This value is used as an epsilon for floating point
	/// equality checks throughout the cell checking process. The default value is
	/// FLT_EPSILON.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkCellValidator_GetToleranceMinValue_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellValidator_IsA_56(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellValidator_IsA_56(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellValidator_IsTypeOf_57(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellValidator_IsTypeOf_57(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellValidator_NewInstance_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCellValidator NewInstance()
	{
		vtkCellValidator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellValidator_NewInstance_59(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellValidator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellValidator_SafeDownCast_60(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellValidator SafeDownCast(vtkObjectBase o)
	{
		vtkCellValidator vtkCellValidator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellValidator_SafeDownCast_60(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellValidator2 = (vtkCellValidator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellValidator2.Register(null);
			}
		}
		return vtkCellValidator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellValidator_SetTolerance_61(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the tolerance. This value is used as an epsilon for floating point
	/// equality checks throughout the cell checking process. The default value is
	/// FLT_EPSILON.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkCellValidator_SetTolerance_61(GetCppThis(), _arg);
	}
}
