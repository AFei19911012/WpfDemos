using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLoopSubdivisionFilter
/// </summary>
/// <remarks>
///    generate a subdivision surface using the Loop Scheme
///
/// vtkLoopSubdivisionFilter is an approximating subdivision scheme that
/// creates four new triangles for each triangle in the mesh. The user can
/// specify the NumberOfSubdivisions. Loop's subdivision scheme is
/// described in: Loop, C., "Smooth Subdivision surfaces based on
/// triangles,", Masters Thesis, University of Utah, August 1987.
/// For a nice summary of the technique see, Hoppe, H., et. al,
/// "Piecewise Smooth Surface Reconstruction,:, Proceedings of Siggraph 94
/// (Orlando, Florida, July 24-29, 1994). In Computer Graphics
/// Proceedings, Annual Conference Series, 1994, ACM SIGGRAPH,
/// pp. 295-302.
/// &lt;P&gt;
/// The filter only operates on triangles. Users should use the
/// vtkTriangleFilter to triangulate meshes that contain polygons or
/// triangle strips.
/// &lt;P&gt;
/// The filter approximates point data using the same scheme. New
/// triangles create at a subdivision step will have the cell data of
/// their parent cell.
///
/// @par Thanks:
/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
/// from the National Center for Research Resources.
///
/// </remarks>
/// <seealso>
///
/// vtkApproximatingSubdivisionFilter
/// </seealso>
public class vtkLoopSubdivisionFilter : vtkApproximatingSubdivisionFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLoopSubdivisionFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLoopSubdivisionFilter()
	{
		MRClassNameKey = "class vtkLoopSubdivisionFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLoopSubdivisionFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLoopSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLoopSubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static vtkLoopSubdivisionFilter New()
	{
		vtkLoopSubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLoopSubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public vtkLoopSubdivisionFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLoopSubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkLoopSubdivisionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLoopSubdivisionFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLoopSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLoopSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopSubdivisionFilter_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLoopSubdivisionFilter_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLoopSubdivisionFilter_IsTypeOf_04(string type);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLoopSubdivisionFilter_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLoopSubdivisionFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new vtkLoopSubdivisionFilter NewInstance()
	{
		vtkLoopSubdivisionFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLoopSubdivisionFilter_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLoopSubdivisionFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with NumberOfSubdivisions set to 1.
	/// </summary>
	public new static vtkLoopSubdivisionFilter SafeDownCast(vtkObjectBase o)
	{
		vtkLoopSubdivisionFilter vtkLoopSubdivisionFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLoopSubdivisionFilter_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLoopSubdivisionFilter2 = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLoopSubdivisionFilter2.Register(null);
			}
		}
		return vtkLoopSubdivisionFilter2;
	}
}
