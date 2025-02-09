using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTriangleMeshPointNormals
/// </summary>
/// <remarks>
///    compute point normals for triangle mesh
///
/// vtkTriangleMeshPointNormals is a filter that computes point normals for
/// a triangle mesh to enable high-performance rendering. It is a fast-path
/// version of the vtkPolyDataNormals filter in order to be able to compute
/// normals for triangle meshes deforming rapidly.
///
/// The computed normals (a vtkFloatArray) are set to be the active normals
/// (using SetNormals()) of the PointData. The array name is "Normals", so
/// they can be retrieved either with `output-&gt;GetPointData()-&gt;GetNormals()`
/// or with `output-&gt;GetPointData()-&gt;GetArray("Normals")`.
///
/// The algorithm works by determining normals for each triangle and adding
/// these vectors to the triangle points. The resulting vectors at each
/// point are then normalized.
///
/// @warning
/// Normals are computed only for triangular polygons: the filter can not
/// handle meshes with other types of cells (Verts, Lines, Strips) or Polys
/// with the wrong number of components (not equal to 3).
///
/// @warning
/// Unlike the vtkPolyDataNormals filter, this filter does not apply any
/// splitting nor checks for cell orientation consistency in order to speed
/// up the computation. Moreover, normals are not calculated the exact same
/// way as the vtkPolyDataNormals filter since the triangle normals are not
/// normalized before being added to the point normals: those cell normals
/// are therefore weighted by the triangle area. This is not more nor less
/// correct than normalizing them before adding them, but it is much faster.
///
/// </remarks>
/// <seealso>
///
/// If you do not need to do high-performance rendering, you should use
/// vtkPolyDataNormals if your mesh is not only triangular, if you need to
/// split vertices at sharp edges, or if you need to check that the cell
/// orientations are consistent to flip inverted normals.
///
///
/// If you still need high-performance rendering but your input polydata is
/// not a triangular mesh and/or does not have consistent cell orientations
/// (causing inverted normals), you can still use this filter by using
/// vtkTriangleFilter and/or vtkCleanPolyData respectively beforehand. If
/// your mesh is deforming rapidly, you should be deforming the output mesh
/// of those two filters instead in order to only run them once.
///
/// </seealso>
public class vtkTriangleMeshPointNormals : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTriangleMeshPointNormals";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTriangleMeshPointNormals()
	{
		MRClassNameKey = "class vtkTriangleMeshPointNormals";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangleMeshPointNormals"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTriangleMeshPointNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangleMeshPointNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangleMeshPointNormals New()
	{
		vtkTriangleMeshPointNormals result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangleMeshPointNormals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangleMeshPointNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTriangleMeshPointNormals()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTriangleMeshPointNormals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTriangleMeshPointNormals_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTriangleMeshPointNormals_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTriangleMeshPointNormals_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTriangleMeshPointNormals_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangleMeshPointNormals_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTriangleMeshPointNormals_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTriangleMeshPointNormals_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTriangleMeshPointNormals_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangleMeshPointNormals_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTriangleMeshPointNormals NewInstance()
	{
		vtkTriangleMeshPointNormals result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangleMeshPointNormals_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTriangleMeshPointNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTriangleMeshPointNormals_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTriangleMeshPointNormals SafeDownCast(vtkObjectBase o)
	{
		vtkTriangleMeshPointNormals vtkTriangleMeshPointNormals2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTriangleMeshPointNormals_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTriangleMeshPointNormals2 = (vtkTriangleMeshPointNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTriangleMeshPointNormals2.Register(null);
			}
		}
		return vtkTriangleMeshPointNormals2;
	}
}
