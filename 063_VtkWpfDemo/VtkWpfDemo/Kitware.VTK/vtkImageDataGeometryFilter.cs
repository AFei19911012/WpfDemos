using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageDataGeometryFilter
/// </summary>
/// <remarks>
///    extract geometry for structured points
///
/// vtkImageDataGeometryFilter is a filter that extracts geometry from a
/// structured points dataset. By specifying appropriate i-j-k indices (via the
/// "Extent" instance variable), it is possible to extract a point, a line, a
/// plane (i.e., image), or a "volume" from dataset. (Since the output is
/// of type polydata, the volume is actually a (n x m x o) region of points.)
///
/// The extent specification is zero-offset. That is, the first k-plane in
/// a 50x50x50 volume is given by (0,49, 0,49, 0,0).
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
/// vtkGeometryFilter vtkStructuredGridSource
/// </seealso>
public class vtkImageDataGeometryFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataGeometryFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageDataGeometryFilter()
	{
		MRClassNameKey = "class vtkImageDataGeometryFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataGeometryFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageDataGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with initial extent of all the data
	/// </summary>
	public new static vtkImageDataGeometryFilter New()
	{
		vtkImageDataGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with initial extent of all the data
	/// </summary>
	public vtkImageDataGeometryFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageDataGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkImageDataGeometryFilter_GetExtent_01(HandleRef pThis);

	/// <summary>
	/// Set / get the extent (imin,imax, jmin,jmax, kmin,kmax) indices.
	/// </summary>
	public IntPtr GetExtent()
	{
		return vtkImageDataGeometryFilter_GetExtent_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDataGeometryFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageDataGeometryFilter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDataGeometryFilter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageDataGeometryFilter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataGeometryFilter_GetOutputTriangles_04(HandleRef pThis);

	/// <summary>
	/// Set OutputTriangles to true if you wish to generate triangles instead of quads
	/// when extracting cells from 2D imagedata
	/// Currently this functionality is only implemented for 2D imagedata
	/// </summary>
	public virtual int GetOutputTriangles()
	{
		return vtkImageDataGeometryFilter_GetOutputTriangles_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataGeometryFilter_GetThresholdCells_05(HandleRef pThis);

	/// <summary>
	/// Set ThresholdCells to true if you wish to skip any voxel/pixels which have scalar
	/// values less than the specified threshold.
	/// Currently this functionality is only implemented for 2D imagedata
	/// </summary>
	public virtual int GetThresholdCells()
	{
		return vtkImageDataGeometryFilter_GetThresholdCells_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageDataGeometryFilter_GetThresholdValue_06(HandleRef pThis);

	/// <summary>
	/// Set ThresholdValue to the scalar value by which to threshold cells when extracting geometry
	/// when ThresholdCells is true. Cells with scalar values greater than the threshold will be
	/// output.
	/// </summary>
	public virtual double GetThresholdValue()
	{
		return vtkImageDataGeometryFilter_GetThresholdValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataGeometryFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageDataGeometryFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataGeometryFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageDataGeometryFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataGeometryFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageDataGeometryFilter NewInstance()
	{
		vtkImageDataGeometryFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataGeometryFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_OutputTrianglesOff_11(HandleRef pThis);

	/// <summary>
	/// Set OutputTriangles to true if you wish to generate triangles instead of quads
	/// when extracting cells from 2D imagedata
	/// Currently this functionality is only implemented for 2D imagedata
	/// </summary>
	public virtual void OutputTrianglesOff()
	{
		vtkImageDataGeometryFilter_OutputTrianglesOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_OutputTrianglesOn_12(HandleRef pThis);

	/// <summary>
	/// Set OutputTriangles to true if you wish to generate triangles instead of quads
	/// when extracting cells from 2D imagedata
	/// Currently this functionality is only implemented for 2D imagedata
	/// </summary>
	public virtual void OutputTrianglesOn()
	{
		vtkImageDataGeometryFilter_OutputTrianglesOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataGeometryFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageDataGeometryFilter SafeDownCast(vtkObjectBase o)
	{
		vtkImageDataGeometryFilter vtkImageDataGeometryFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataGeometryFilter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDataGeometryFilter2 = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDataGeometryFilter2.Register(null);
			}
		}
		return vtkImageDataGeometryFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_SetExtent_14(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set / get the extent (imin,imax, jmin,jmax, kmin,kmax) indices.
	/// </summary>
	public void SetExtent(IntPtr extent)
	{
		vtkImageDataGeometryFilter_SetExtent_14(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_SetExtent_15(HandleRef pThis, int iMin, int iMax, int jMin, int jMax, int kMin, int kMax);

	/// <summary>
	/// Set / get the extent (imin,imax, jmin,jmax, kmin,kmax) indices.
	/// </summary>
	public void SetExtent(int iMin, int iMax, int jMin, int jMax, int kMin, int kMax)
	{
		vtkImageDataGeometryFilter_SetExtent_15(GetCppThis(), iMin, iMax, jMin, jMax, kMin, kMax);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_SetOutputTriangles_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set OutputTriangles to true if you wish to generate triangles instead of quads
	/// when extracting cells from 2D imagedata
	/// Currently this functionality is only implemented for 2D imagedata
	/// </summary>
	public virtual void SetOutputTriangles(int _arg)
	{
		vtkImageDataGeometryFilter_SetOutputTriangles_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_SetThresholdCells_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set ThresholdCells to true if you wish to skip any voxel/pixels which have scalar
	/// values less than the specified threshold.
	/// Currently this functionality is only implemented for 2D imagedata
	/// </summary>
	public virtual void SetThresholdCells(int _arg)
	{
		vtkImageDataGeometryFilter_SetThresholdCells_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_SetThresholdValue_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set ThresholdValue to the scalar value by which to threshold cells when extracting geometry
	/// when ThresholdCells is true. Cells with scalar values greater than the threshold will be
	/// output.
	/// </summary>
	public virtual void SetThresholdValue(double _arg)
	{
		vtkImageDataGeometryFilter_SetThresholdValue_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_ThresholdCellsOff_19(HandleRef pThis);

	/// <summary>
	/// Set ThresholdCells to true if you wish to skip any voxel/pixels which have scalar
	/// values less than the specified threshold.
	/// Currently this functionality is only implemented for 2D imagedata
	/// </summary>
	public virtual void ThresholdCellsOff()
	{
		vtkImageDataGeometryFilter_ThresholdCellsOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_ThresholdCellsOn_20(HandleRef pThis);

	/// <summary>
	/// Set ThresholdCells to true if you wish to skip any voxel/pixels which have scalar
	/// values less than the specified threshold.
	/// Currently this functionality is only implemented for 2D imagedata
	/// </summary>
	public virtual void ThresholdCellsOn()
	{
		vtkImageDataGeometryFilter_ThresholdCellsOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_ThresholdValueOff_21(HandleRef pThis);

	/// <summary>
	/// Set ThresholdValue to the scalar value by which to threshold cells when extracting geometry
	/// when ThresholdCells is true. Cells with scalar values greater than the threshold will be
	/// output.
	/// </summary>
	public virtual void ThresholdValueOff()
	{
		vtkImageDataGeometryFilter_ThresholdValueOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataGeometryFilter_ThresholdValueOn_22(HandleRef pThis);

	/// <summary>
	/// Set ThresholdValue to the scalar value by which to threshold cells when extracting geometry
	/// when ThresholdCells is true. Cells with scalar values greater than the threshold will be
	/// output.
	/// </summary>
	public virtual void ThresholdValueOn()
	{
		vtkImageDataGeometryFilter_ThresholdValueOn_22(GetCppThis());
	}
}
