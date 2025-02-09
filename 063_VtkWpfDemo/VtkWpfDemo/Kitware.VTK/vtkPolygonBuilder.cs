using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolygonBuilder
///
///
///  The polygon output is the boundary of the union of the triangles.
///  It is assumed that the input triangles form a simple polygon. It is
///  currently used to compute polygons for slicing.
///
/// </summary>
public class vtkPolygonBuilder : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonBuilder";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolygonBuilder()
	{
		MRClassNameKey = "class vtkPolygonBuilder";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonBuilder"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolygonBuilder(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonBuilder_GetPolygons_01(HandleRef pThis, HandleRef polys);

	/// <summary>
	/// Populate polys with lists of polygons, defined as sequential external
	/// vertices. It is the responsibility of the user to delete these generated
	/// lists in order to avoid memory leaks.
	/// </summary>
	public void GetPolygons(vtkIdListCollection polys)
	{
		vtkPolygonBuilder_GetPolygons_01(GetCppThis(), polys?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonBuilder_InsertTriangle_02(HandleRef pThis, IntPtr abc);

	/// <summary>
	/// Insert a triangle as a triplet of point IDs.
	/// </summary>
	public void InsertTriangle(IntPtr abc)
	{
		vtkPolygonBuilder_InsertTriangle_02(GetCppThis(), abc);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonBuilder_Reset_03(HandleRef pThis);

	/// <summary>
	/// Prepare the builder for a new set of inputs.
	/// </summary>
	public void Reset()
	{
		vtkPolygonBuilder_Reset_03(GetCppThis());
	}
}
