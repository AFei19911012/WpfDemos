using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIntersectionCounter
/// </summary>
/// <remarks>
///    Fast simple class for dealing with ray intersections
///
/// vtkIntersectionCounter is used to intersect data and merge coincident
/// points along the intersect ray. It is light-weight and many of the member
/// functions are in-lined so its very fast. It is not derived from vtkObject
/// so it can be allocated on the stack.
///
/// This class makes the finite ray intersection process more robust. It
/// merges intersections that are very close to one another (within a
/// tolerance). Such situations are common when intersection rays pass through
/// the edge or vertex of a mesh.
///
/// </remarks>
/// <seealso>
///
/// vtkBoundingBox
/// </seealso>
public class vtkIntersectionCounter : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIntersectionCounter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIntersectionCounter()
	{
		MRClassNameKey = "class vtkIntersectionCounter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIntersectionCounter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIntersectionCounter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkIntersectionCounter_AddIntersection_01(HandleRef pThis, double t);

	/// <summary>
	/// Add an intersection given by parametric coordinate t.
	/// </summary>
	public void AddIntersection(double t)
	{
		vtkIntersectionCounter_AddIntersection_01(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIntersectionCounter_CountIntersections_02(HandleRef pThis);

	/// <summary>
	/// Returns number of intersections (even number of intersections, outside
	/// or odd number of intersections, inside). This is done by considering
	/// close intersections (within Tolerance) as being the same point.
	/// </summary>
	public int CountIntersections()
	{
		return vtkIntersectionCounter_CountIntersections_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIntersectionCounter_GetTolerance_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the intersection tolerance.
	/// </summary>
	public double GetTolerance()
	{
		return vtkIntersectionCounter_GetTolerance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionCounter_Reset_04(HandleRef pThis);

	/// <summary>
	/// Reset the intersection process.
	/// </summary>
	public void Reset()
	{
		vtkIntersectionCounter_Reset_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIntersectionCounter_SetTolerance_05(HandleRef pThis, double tol);

	/// <summary>
	/// Set/Get the intersection tolerance.
	/// </summary>
	public void SetTolerance(double tol)
	{
		vtkIntersectionCounter_SetTolerance_05(GetCppThis(), tol);
	}
}
