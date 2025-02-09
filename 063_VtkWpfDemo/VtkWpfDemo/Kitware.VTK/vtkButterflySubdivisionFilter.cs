using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkButterflySubdivisionFilter
/// </summary>
/// <remarks>
///    generate a subdivision surface using the Butterfly Scheme
///
/// vtkButterflySubdivisionFilter is an interpolating subdivision scheme
/// that creates four new triangles for each triangle in the mesh. The
/// user can specify the NumberOfSubdivisions. This filter implements the
/// 8-point butterfly scheme described in: Zorin, D., Schroder, P., and
/// Sweldens, W., "Interpolating Subdivisions for Meshes with Arbitrary
/// Topology," Computer Graphics Proceedings, Annual Conference Series,
/// 1996, ACM SIGGRAPH, pp.189-192. This scheme improves previous
/// butterfly subdivisions with special treatment of vertices with valence
/// other than 6.
///
/// Currently, the filter only operates on triangles. Users should use the
/// vtkTriangleFilter to triangulate meshes that contain polygons or
/// triangle strips.
///
/// The filter interpolates point data using the same scheme. New
/// triangles created at a subdivision step will have the cell data of
/// their parent cell.
///
/// @par Thanks:
/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
/// from the National Center for Research Resources.
///
/// </remarks>
/// <seealso>
///
/// vtkInterpolatingSubdivisionFilter vtkLinearSubdivisionFilter
/// </seealso>
public class vtkButterflySubdivisionFilter : vtkInterpolatingSubdivisionFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkButterflySubdivisionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkButterflySubdivisionFilter()
	{
		MRClassNameKey = "class vtkButterflySubdivisionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkButterflySubdivisionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkButterflySubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButterflySubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static vtkButterflySubdivisionFilter New()
	{
		vtkButterflySubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkButterflySubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public vtkButterflySubdivisionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkButterflySubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkButterflySubdivisionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkButterflySubdivisionFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkButterflySubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkButterflySubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButterflySubdivisionFilter_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkButterflySubdivisionFilter_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButterflySubdivisionFilter_IsTypeOf_04(string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkButterflySubdivisionFilter_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButterflySubdivisionFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new vtkButterflySubdivisionFilter NewInstance()
	{
		vtkButterflySubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkButterflySubdivisionFilter_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButterflySubdivisionFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static vtkButterflySubdivisionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkButterflySubdivisionFilter vtkButterflySubdivisionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkButterflySubdivisionFilter_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkButterflySubdivisionFilter2 = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkButterflySubdivisionFilter2.Register(null);
			}
		}
		return vtkButterflySubdivisionFilter2;
	}
}
