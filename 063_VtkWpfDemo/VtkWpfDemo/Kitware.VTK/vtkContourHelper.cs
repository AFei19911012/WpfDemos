using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourHelper
/// </summary>
/// <remarks>
///    A utility class used by various contour filters
///
///  This is a simple utility class that can be used by various contour filters to
///  produce either triangles and/or polygons based on the outputTriangles parameter
///  When working with multidimensional dataset, it is needed to process cells
///  from low to high dimensions.
/// </remarks>
/// <seealso>
///
/// vtkContourGrid vtkCutter vtkContourFilter
/// </seealso>
public class vtkContourHelper : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourHelper()
	{
		MRClassNameKey = "class vtkContourHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourHelper_Contour_01(HandleRef pThis, HandleRef cell, double value, HandleRef cellScalars, long cellId);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void Contour(vtkCell cell, double value, vtkDataArray cellScalars, long cellId)
	{
		vtkContourHelper_Contour_01(GetCppThis(), cell?.GetCppThis() ?? default(HandleRef), value, cellScalars?.GetCppThis() ?? default(HandleRef), cellId);
	}
}
