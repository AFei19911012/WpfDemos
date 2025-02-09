using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourTriangulator
/// </summary>
/// <remarks>
///    Fill all 2D contours to create polygons
///
/// vtkContourTriangulator will generate triangles to fill all of the 2D
/// contours in its input. The input to the filter is a set of lines (not
/// polylines) which when joined form loops. The contours may be concave, and
/// may even contain holes i.e. a contour may contain an internal contour that
/// is wound in the opposite direction (as compared to the outer polygon
/// normal) to indicate that it is a hole.
///
/// @warning
/// The triangulation of is done in O(n) time for simple convex
/// inputs, but for non-convex inputs the worst-case time is O(n^2*m^2)
/// where n is the number of points and m is the number of holes.
/// The best triangulation algorithms, in contrast, are O(n log n).
/// The resulting triangles may be quite narrow, the algorithm does
/// not attempt to produce high-quality triangles.
///
/// </remarks>
/// <seealso>
///
/// vtkClipClosedSurface vtkPolygon
///
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </seealso>
public class vtkContourTriangulator : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourTriangulator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourTriangulator()
	{
		MRClassNameKey = "class vtkContourTriangulator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourTriangulator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourTriangulator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourTriangulator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkContourTriangulator New()
	{
		vtkContourTriangulator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourTriangulator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkContourTriangulator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContourTriangulator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkContourTriangulator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContourTriangulator_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourTriangulator_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContourTriangulator_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourTriangulator_GetTriangulationError_03(HandleRef pThis);

	/// <summary>
	/// Check if there was a triangulation failure in the last update.
	/// </summary>
	public virtual int GetTriangulationError()
	{
		return vtkContourTriangulator_GetTriangulationError_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourTriangulator_GetTriangulationErrorDisplay_04(HandleRef pThis);

	/// <summary>
	/// Generate errors when the triangulation fails.  Note that triangulation
	/// failures are often minor, because they involve tiny triangles that are
	/// too small to see.
	/// </summary>
	public virtual int GetTriangulationErrorDisplay()
	{
		return vtkContourTriangulator_GetTriangulationErrorDisplay_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourTriangulator_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContourTriangulator_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourTriangulator_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContourTriangulator_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourTriangulator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkContourTriangulator NewInstance()
	{
		vtkContourTriangulator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourTriangulator_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourTriangulator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkContourTriangulator SafeDownCast(vtkObjectBase o)
	{
		vtkContourTriangulator vtkContourTriangulator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourTriangulator_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourTriangulator2 = (vtkContourTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourTriangulator2.Register(null);
			}
		}
		return vtkContourTriangulator2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourTriangulator_SetTriangulationErrorDisplay_10(HandleRef pThis, int _arg);

	/// <summary>
	/// Generate errors when the triangulation fails.  Note that triangulation
	/// failures are often minor, because they involve tiny triangles that are
	/// too small to see.
	/// </summary>
	public virtual void SetTriangulationErrorDisplay(int _arg)
	{
		vtkContourTriangulator_SetTriangulationErrorDisplay_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourTriangulator_TriangulateContours_11(HandleRef data, long firstLine, long numLines, HandleRef outputPolys, IntPtr normal);

	/// <summary>
	/// Given some closed contour lines, create a triangle mesh that fills
	/// those lines.  The input lines do not have to be in tail-to-tip order.
	/// Only numLines starting from firstLine will be used.  Note that holes
	/// can be indicated by contour loops whose normals are in the opposite
	/// direction to the provided normal.
	/// </summary>
	public static int TriangulateContours(vtkPolyData data, long firstLine, long numLines, vtkCellArray outputPolys, IntPtr normal)
	{
		return vtkContourTriangulator_TriangulateContours_11(data?.GetCppThis() ?? default(HandleRef), firstLine, numLines, outputPolys?.GetCppThis() ?? default(HandleRef), normal);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourTriangulator_TriangulatePolygon_12(HandleRef polygon, HandleRef points, HandleRef triangles);

	/// <summary>
	/// A robust method for triangulating a polygon.  It cleans up the polygon
	/// and then applies the ear-cut triangulation.  A zero return value
	/// indicates that triangulation failed.
	/// </summary>
	public static int TriangulatePolygon(vtkIdList polygon, vtkPoints points, vtkCellArray triangles)
	{
		return vtkContourTriangulator_TriangulatePolygon_12(polygon?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef), triangles?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourTriangulator_TriangulationErrorDisplayOff_13(HandleRef pThis);

	/// <summary>
	/// Generate errors when the triangulation fails.  Note that triangulation
	/// failures are often minor, because they involve tiny triangles that are
	/// too small to see.
	/// </summary>
	public virtual void TriangulationErrorDisplayOff()
	{
		vtkContourTriangulator_TriangulationErrorDisplayOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourTriangulator_TriangulationErrorDisplayOn_14(HandleRef pThis);

	/// <summary>
	/// Generate errors when the triangulation fails.  Note that triangulation
	/// failures are often minor, because they involve tiny triangles that are
	/// too small to see.
	/// </summary>
	public virtual void TriangulationErrorDisplayOn()
	{
		vtkContourTriangulator_TriangulationErrorDisplayOn_14(GetCppThis());
	}
}
