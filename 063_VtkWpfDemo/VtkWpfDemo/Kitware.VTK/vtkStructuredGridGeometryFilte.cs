using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStructuredGridGeometryFilter
/// </summary>
/// <remarks>
///    extract geometry for structured grid
///
/// vtkStructuredGridGeometryFilter is a filter that extracts geometry from a
/// structured grid. By specifying appropriate i-j-k indices, it is possible
/// to extract a point, a curve, a surface, or a "volume". Depending upon the
/// type of data, the curve and surface may be curved or planar. (The volume
/// is actually a (n x m x o) region of points.)
///
/// The extent specification is zero-offset. That is, the first k-plane in
/// a 50x50x50 structured grid is given by (0,49, 0,49, 0,0).
///
/// The output of this filter is affected by the structured grid blanking.
/// If blanking is on, and a blanking array defined, then those cells
/// attached to blanked points are not output. (Blanking is a property of
/// the input vtkStructuredGrid.)
///
/// @warning
/// If you don't know the dimensions of the input dataset, you can use a large
/// number to specify extent (the number will be clamped appropriately). For
/// example, if the dataset dimensions are 50x50x50, and you want a the fifth
/// k-plane, you can use the extents (0,100, 0,100, 4,4). The 100 will
/// automatically be clamped to 49.
///
/// </remarks>
/// <seealso>
///
/// vtkGeometryFilter vtkExtractGrid vtkStructuredGrid
/// </seealso>
public class vtkStructuredGridGeometryFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridGeometryFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStructuredGridGeometryFilter()
	{
		MRClassNameKey = "class vtkStructuredGridGeometryFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridGeometryFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStructuredGridGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGridGeometryFilter New()
	{
		vtkStructuredGridGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStructuredGridGeometryFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStructuredGridGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridGeometryFilter_GetExtent_01(HandleRef pThis);

	/// <summary>
	/// Get the extent in topological coordinate range (imin,imax, jmin,jmax,
	/// kmin,kmax).
	/// </summary>
	public virtual int[] GetExtent()
	{
		IntPtr intPtr = vtkStructuredGridGeometryFilter_GetExtent_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridGeometryFilter_GetExtent_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Get the extent in topological coordinate range (imin,imax, jmin,jmax,
	/// kmin,kmax).
	/// </summary>
	public virtual void GetExtent(IntPtr data)
	{
		vtkStructuredGridGeometryFilter_GetExtent_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGridGeometryFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStructuredGridGeometryFilter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStructuredGridGeometryFilter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStructuredGridGeometryFilter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridGeometryFilter_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStructuredGridGeometryFilter_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStructuredGridGeometryFilter_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStructuredGridGeometryFilter_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridGeometryFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStructuredGridGeometryFilter NewInstance()
	{
		vtkStructuredGridGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridGeometryFilter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStructuredGridGeometryFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStructuredGridGeometryFilter SafeDownCast(vtkObjectBase o)
	{
		vtkStructuredGridGeometryFilter vtkStructuredGridGeometryFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStructuredGridGeometryFilter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStructuredGridGeometryFilter2 = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStructuredGridGeometryFilter2.Register(null);
			}
		}
		return vtkStructuredGridGeometryFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridGeometryFilter_SetExtent_10(HandleRef pThis, int iMin, int iMax, int jMin, int jMax, int kMin, int kMax);

	/// <summary>
	/// Specify (imin,imax, jmin,jmax, kmin,kmax) indices.
	/// </summary>
	public void SetExtent(int iMin, int iMax, int jMin, int jMax, int kMin, int kMax)
	{
		vtkStructuredGridGeometryFilter_SetExtent_10(GetCppThis(), iMin, iMax, jMin, jMax, kMin, kMax);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStructuredGridGeometryFilter_SetExtent_11(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Specify (imin,imax, jmin,jmax, kmin,kmax) indices in array form.
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkStructuredGridGeometryFilter_SetExtent_11(GetCppThis(), extent);
	}
}
