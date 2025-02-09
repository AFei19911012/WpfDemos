using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlanesIntersection
/// </summary>
/// <remarks>
///    A vtkPlanesIntersection object is a
///    vtkPlanes object that can compute whether the arbitrary convex region
///    bounded by it's planes intersects an axis-aligned box.
///
///
///    A subclass of vtkPlanes, this class determines whether it
///    intersects an axis aligned box.   This is motivated by the
///    need to intersect the axis aligned region of a spacial
///    decomposition of volume data with various other regions.
///    It uses the algorithm from Graphics Gems IV, page 81.
///
/// @par Caveat:
///    An instance of vtkPlanes can be redefined by changing the planes,
///    but this subclass then will not know if the region vertices are
///    up to date.  (Region vertices can be specified in SetRegionVertices
///    or computed by the subclass.)  So Delete and recreate if you want
///    to change the set of planes.
///
/// </remarks>
public class vtkPlanesIntersection : vtkPlanes
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlanesIntersection";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlanesIntersection()
	{
		MRClassNameKey = "class vtkPlanesIntersection";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlanesIntersection"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlanesIntersection(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanesIntersection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlanesIntersection New()
	{
		vtkPlanesIntersection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanesIntersection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPlanesIntersection()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlanesIntersection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanesIntersection_Convert3DCell_01(HandleRef cell, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Another convenience function provided by this class, returns
	/// the vtkPlanesIntersection object representing a 3D
	/// cell.  The point IDs for each face must be given in
	/// counter-clockwise order from the outside of the cell.
	/// </summary>
	public static vtkPlanesIntersection Convert3DCell(vtkCell cell)
	{
		vtkPlanesIntersection vtkPlanesIntersection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanesIntersection_Convert3DCell_01(cell?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlanesIntersection2 = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlanesIntersection2.Register(null);
			}
		}
		return vtkPlanesIntersection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanesIntersection_GetNumRegionVertices_02(HandleRef pThis);

	/// <summary>
	/// It helps if you know the vertices of the convex region.
	/// If you don't, we will calculate them.  Region vertices
	/// are 3-tuples.
	/// </summary>
	public int GetNumRegionVertices()
	{
		return vtkPlanesIntersection_GetNumRegionVertices_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlanesIntersection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlanesIntersection_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlanesIntersection_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlanesIntersection_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanesIntersection_GetNumberOfRegionVertices_05(HandleRef pThis);

	/// <summary>
	/// It helps if you know the vertices of the convex region.
	/// If you don't, we will calculate them.  Region vertices
	/// are 3-tuples.
	/// </summary>
	public int GetNumberOfRegionVertices()
	{
		return vtkPlanesIntersection_GetNumberOfRegionVertices_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanesIntersection_GetRegionVertices_06(HandleRef pThis, IntPtr v, int nvertices);

	/// <summary>
	/// It helps if you know the vertices of the convex region.
	/// If you don't, we will calculate them.  Region vertices
	/// are 3-tuples.
	/// </summary>
	public int GetRegionVertices(IntPtr v, int nvertices)
	{
		return vtkPlanesIntersection_GetRegionVertices_06(GetCppThis(), v, nvertices);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanesIntersection_IntersectsRegion_07(HandleRef pThis, HandleRef R);

	/// <summary>
	/// Return 1 if the axis aligned box defined by R intersects
	/// the region defined by the planes, or 0 otherwise.
	/// </summary>
	public int IntersectsRegion(vtkPoints R)
	{
		return vtkPlanesIntersection_IntersectsRegion_07(GetCppThis(), R?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanesIntersection_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlanesIntersection_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanesIntersection_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlanesIntersection_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanesIntersection_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlanesIntersection NewInstance()
	{
		vtkPlanesIntersection result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanesIntersection_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlanesIntersection_PolygonIntersectsBBox_12(IntPtr bounds, HandleRef pts);

	/// <summary>
	/// A convenience function provided by this class, returns
	/// 1 if the polygon defined in pts intersects the bounding
	/// box defined in bounds, 0 otherwise.
	///
	/// The points must define a planar polygon.
	/// </summary>
	public static int PolygonIntersectsBBox(IntPtr bounds, vtkPoints pts)
	{
		return vtkPlanesIntersection_PolygonIntersectsBBox_12(bounds, pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlanesIntersection_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlanesIntersection SafeDownCast(vtkObjectBase o)
	{
		vtkPlanesIntersection vtkPlanesIntersection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlanesIntersection_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlanesIntersection2 = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlanesIntersection2.Register(null);
			}
		}
		return vtkPlanesIntersection2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlanesIntersection_SetRegionVertices_14(HandleRef pThis, HandleRef pts);

	/// <summary>
	/// It helps if you know the vertices of the convex region.
	/// If you don't, we will calculate them.  Region vertices
	/// are 3-tuples.
	/// </summary>
	public void SetRegionVertices(vtkPoints pts)
	{
		vtkPlanesIntersection_SetRegionVertices_14(GetCppThis(), pts?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlanesIntersection_SetRegionVertices_15(HandleRef pThis, IntPtr v, int nvertices);

	/// <summary>
	/// It helps if you know the vertices of the convex region.
	/// If you don't, we will calculate them.  Region vertices
	/// are 3-tuples.
	/// </summary>
	public void SetRegionVertices(IntPtr v, int nvertices)
	{
		vtkPlanesIntersection_SetRegionVertices_15(GetCppThis(), v, nvertices);
	}
}
