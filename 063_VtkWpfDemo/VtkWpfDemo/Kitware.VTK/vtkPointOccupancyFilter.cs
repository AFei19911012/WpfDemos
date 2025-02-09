using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointOccupancyFilter
/// </summary>
/// <remarks>
///    produce occupancy bit mask from input point cloud
///
/// vtkPointOccupancyFilter is a filter that generates an occupancy mask on a
/// volume from a point cloud. The output of the filter is an image/volume
/// that indicates for each pixel/voxel whether a point exists within the
/// pixel/voxel.
///
/// To use this filter, specify an input of type vtkPointSet (i.e., has an
/// explicit representation of points). Then define the occupancy volume by
/// specifying the sample dimensions and bounds. Optionally you can specify
/// unsigned char values used to indicate whether a voxel is empty or occupied.
///
/// @warning
/// During processing, if a point is found to be outside of the occupancy volume,
/// then it is skipped (i.e., it does not affect the occupancy mask).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPointDensityFilter vtkPointMaskFilter
/// </seealso>
public class vtkPointOccupancyFilter : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointOccupancyFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointOccupancyFilter()
	{
		MRClassNameKey = "class vtkPointOccupancyFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointOccupancyFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointOccupancyFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointOccupancyFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPointOccupancyFilter New()
	{
		vtkPointOccupancyFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointOccupancyFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointOccupancyFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkPointOccupancyFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointOccupancyFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointOccupancyFilter_GetEmptyValue_01(HandleRef pThis);

	/// <summary>
	/// Set / get the values indicating whether a voxel is empty (i.e., does not
	/// contain any points) or occupied. By default, an empty voxel has a zero
	/// value; an occupied voxel has a value of one.
	/// </summary>
	public virtual byte GetEmptyValue()
	{
		return vtkPointOccupancyFilter_GetEmptyValue_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointOccupancyFilter_GetModelBounds_02(HandleRef pThis);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkPointOccupancyFilter_GetModelBounds_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointOccupancyFilter_GetModelBounds_03(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkPointOccupancyFilter_GetModelBounds_03(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointOccupancyFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointOccupancyFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointOccupancyFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointOccupancyFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointOccupancyFilter_GetOccupiedValue_06(HandleRef pThis);

	/// <summary>
	/// Set / get the values indicating whether a voxel is empty (i.e., does not
	/// contain any points) or occupied. By default, an empty voxel has a zero
	/// value; an occupied voxel has a value of one.
	/// </summary>
	public virtual byte GetOccupiedValue()
	{
		return vtkPointOccupancyFilter_GetOccupiedValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointOccupancyFilter_GetSampleDimensions_07(HandleRef pThis);

	/// <summary>
	/// Set / get the dimensions of the occupancy volume. Higher values generally
	/// produce better results but may be much slower.
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkPointOccupancyFilter_GetSampleDimensions_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointOccupancyFilter_GetSampleDimensions_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the dimensions of the occupancy volume. Higher values generally
	/// produce better results but may be much slower.
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkPointOccupancyFilter_GetSampleDimensions_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointOccupancyFilter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointOccupancyFilter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointOccupancyFilter_IsTypeOf_10(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointOccupancyFilter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointOccupancyFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkPointOccupancyFilter NewInstance()
	{
		vtkPointOccupancyFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointOccupancyFilter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointOccupancyFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointOccupancyFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPointOccupancyFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPointOccupancyFilter vtkPointOccupancyFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointOccupancyFilter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointOccupancyFilter2 = (vtkPointOccupancyFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointOccupancyFilter2.Register(null);
			}
		}
		return vtkPointOccupancyFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointOccupancyFilter_SetEmptyValue_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set / get the values indicating whether a voxel is empty (i.e., does not
	/// contain any points) or occupied. By default, an empty voxel has a zero
	/// value; an occupied voxel has a value of one.
	/// </summary>
	public virtual void SetEmptyValue(byte _arg)
	{
		vtkPointOccupancyFilter_SetEmptyValue_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointOccupancyFilter_SetModelBounds_15(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkPointOccupancyFilter_SetModelBounds_15(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointOccupancyFilter_SetModelBounds_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
	/// the sampling is performed. If any of the (min,max) bounds values are
	/// min &gt;= max, then the bounds will be computed automatically from the input
	/// data. Otherwise, the user-specified bounds will be used.
	/// </summary>
	public virtual void SetModelBounds(IntPtr _arg)
	{
		vtkPointOccupancyFilter_SetModelBounds_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointOccupancyFilter_SetOccupiedValue_17(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set / get the values indicating whether a voxel is empty (i.e., does not
	/// contain any points) or occupied. By default, an empty voxel has a zero
	/// value; an occupied voxel has a value of one.
	/// </summary>
	public virtual void SetOccupiedValue(byte _arg)
	{
		vtkPointOccupancyFilter_SetOccupiedValue_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointOccupancyFilter_SetSampleDimensions_18(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set / get the dimensions of the occupancy volume. Higher values generally
	/// produce better results but may be much slower.
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkPointOccupancyFilter_SetSampleDimensions_18(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointOccupancyFilter_SetSampleDimensions_19(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Set / get the dimensions of the occupancy volume. Higher values generally
	/// produce better results but may be much slower.
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkPointOccupancyFilter_SetSampleDimensions_19(GetCppThis(), dim);
	}
}
