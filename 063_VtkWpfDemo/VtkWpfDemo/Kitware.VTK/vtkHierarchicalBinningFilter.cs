using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHierarchicalBinningFilter
/// </summary>
/// <remarks>
///    uniform binning of points into
/// a hierarchical structure
///
///
/// vtkHierarchicalBinningFilter creates a spatial, hierarchical ordering of
/// input points. This hierarchy is suitable for level-of-detail rendering, or
/// multiresolution processing. Each level of the hierarchy is based on
/// uniform binning of space, where deeper levels (and its bins) are
/// repeatedly subdivided by a given branching factor. Points are associated
/// with bins at different levels, with the number of points in each level
/// proportional to the number of bins in that level. The output points are
/// sorted according to a bin number, where the bin number is unique,
/// monotonically increasing number representing the breadth first ordering of
/// all of the levels and their bins. Thus all points in a bin (or even a level)
/// are segmented into contiguous runs.
///
/// Note that points are associated with different bins using a pseudo random
/// process. No points are repeated, and no new points are created, thus the
/// effect of executing this filter is simply to reorder the input points.
///
/// The algorithm proceeds as follows: Given an initial bounding box, the
/// space is uniformally subdivided into bins of (M x N x O) dimensions; in
/// turn each subsequent level in the tree is further divided into (M x N x O)
/// bins (note that level 0 is a single, root bin). Thus the number of bins at
/// level L of the hierarchical tree is: Nbins=(M^L x N^L x O^L). Once the
/// binning is created to a specified depth, then points are placed in the
/// bins using a pseudo-random sampling proportional to the number of bins in each
/// level. All input points are sorted in the order described above, with no
/// points repeated.
///
/// The output of this filter are sorted points and associated point
/// attributes represented by a vtkPolyData. In addition, an offset integral
/// array is associated with the field data of the output, providing offsets
/// into the points list via a breadth-first traversal order. Metadata
/// describing the output is provided in the field data. Convenience functions
/// are also provided here to access the data in a particular bin or across a
/// level. (Using the offset array directly may result in higher performance.)
///
/// While any vtkPointSet type can be provided as input, the output is
/// represented by an explicit representation of points via a
/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
/// contained in the output).
///
/// @warning
/// This class has been threaded with vtkSMPTools. Using TBB or other
/// non-sequential type (set in the CMake variable
/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
///
/// </remarks>
/// <seealso>
///
/// vtkPointCloudFilter vtkQuadricClustering vtkStaticPointLocator
/// </seealso>
public class vtkHierarchicalBinningFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBinningFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHierarchicalBinningFilter()
	{
		MRClassNameKey = "class vtkHierarchicalBinningFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBinningFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHierarchicalBinningFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBinningFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkHierarchicalBinningFilter New()
	{
		vtkHierarchicalBinningFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBinningFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHierarchicalBinningFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkHierarchicalBinningFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHierarchicalBinningFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkHierarchicalBinningFilter_AutomaticOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether to determine the determine the level divisions, and the bounding
	/// box automatically (by default this is on). If off, then the user must specify both
	/// the bounding box and bin divisions. (Computing the bounding box can be slow for
	/// large point clouds, manual specification can save time.)
	/// </summary>
	public virtual void AutomaticOff()
	{
		vtkHierarchicalBinningFilter_AutomaticOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_AutomaticOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether to determine the determine the level divisions, and the bounding
	/// box automatically (by default this is on). If off, then the user must specify both
	/// the bounding box and bin divisions. (Computing the bounding box can be slow for
	/// large point clouds, manual specification can save time.)
	/// </summary>
	public virtual void AutomaticOn()
	{
		vtkHierarchicalBinningFilter_AutomaticOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkHierarchicalBinningFilter_GetAutomatic_03(HandleRef pThis);

	/// <summary>
	/// Specify whether to determine the determine the level divisions, and the bounding
	/// box automatically (by default this is on). If off, then the user must specify both
	/// the bounding box and bin divisions. (Computing the bounding box can be slow for
	/// large point clouds, manual specification can save time.)
	/// </summary>
	public virtual bool GetAutomatic()
	{
		return (vtkHierarchicalBinningFilter_GetAutomatic_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_GetBinBounds_04(HandleRef pThis, int globalBin, IntPtr bounds);

	/// <summary>
	/// Convenience methods for extracting useful information about a bin tree.
	/// Given a global bin number, return the bounds (xmin,xmax,ymin,ymax,zmin,zmax)
	/// for that bin. Invoke this method after the bin tree has been built.
	/// </summary>
	public void GetBinBounds(int globalBin, IntPtr bounds)
	{
		vtkHierarchicalBinningFilter_GetBinBounds_04(GetCppThis(), globalBin, bounds);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalBinningFilter_GetBinOffset_05(HandleRef pThis, int globalBin, ref long npts);

	/// <summary>
	/// Convenience methods for extracting useful information about this bin
	/// tree.  Given a global bin number, return the point id and number of
	/// points for that bin. Invoke this method after the bin tree has been
	/// built.
	/// </summary>
	public long GetBinOffset(int globalBin, ref long npts)
	{
		return vtkHierarchicalBinningFilter_GetBinOffset_05(GetCppThis(), globalBin, ref npts);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBinningFilter_GetBounds_06(HandleRef pThis);

	/// <summary>
	/// Set the bounding box of the point cloud. If Automatic is enabled, then
	/// this is computed during filter execution. If manually specified
	/// (Automatic is off) then make sure the bounds is represented as
	/// (xmin,xmax, ymin,ymax, zmin,zmax). If the bounds specified is does not
	/// enclose the points, then points are clamped to lie in the bounding box.
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkHierarchicalBinningFilter_GetBounds_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_GetBounds_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the bounding box of the point cloud. If Automatic is enabled, then
	/// this is computed during filter execution. If manually specified
	/// (Automatic is off) then make sure the bounds is represented as
	/// (xmin,xmax, ymin,ymax, zmin,zmax). If the bounds specified is does not
	/// enclose the points, then points are clamped to lie in the bounding box.
	/// </summary>
	public virtual void GetBounds(IntPtr data)
	{
		vtkHierarchicalBinningFilter_GetBounds_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBinningFilter_GetDivisions_08(HandleRef pThis);

	/// <summary>
	/// Set the number of branching divisions in each binning direction. Each
	/// level of the tree is subdivided by this factor. The Divisions[i] must be
	/// &gt;= 1. Note: if Automatic subdivision is specified, the Divisions are
	/// set by the filter.
	/// </summary>
	public virtual int[] GetDivisions()
	{
		IntPtr intPtr = vtkHierarchicalBinningFilter_GetDivisions_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_GetDivisions_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the number of branching divisions in each binning direction. Each
	/// level of the tree is subdivided by this factor. The Divisions[i] must be
	/// &gt;= 1. Note: if Automatic subdivision is specified, the Divisions are
	/// set by the filter.
	/// </summary>
	public virtual void GetDivisions(IntPtr data)
	{
		vtkHierarchicalBinningFilter_GetDivisions_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalBinningFilter_GetLevelOffset_10(HandleRef pThis, int level, ref long npts);

	/// <summary>
	/// Convenience methods for extracting useful information about this bin
	/// tree.  Given a level, return the beginning point id and number of points
	/// that level. Invoke this method after the bin tree has been built.
	/// </summary>
	public long GetLevelOffset(int level, ref long npts)
	{
		return vtkHierarchicalBinningFilter_GetLevelOffset_10(GetCppThis(), level, ref npts);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_GetLocalBinBounds_11(HandleRef pThis, int level, int localBin, IntPtr bounds);

	/// <summary>
	/// Convenience methods for extracting useful information about a bin tree.
	/// Given a level, and a local bin number, return the bounds
	/// (xmin,xmax,ymin,ymax,zmin,zmax) for that bin. Invoke this method after
	/// the bin tree has been built.
	/// </summary>
	public void GetLocalBinBounds(int level, int localBin, IntPtr bounds)
	{
		vtkHierarchicalBinningFilter_GetLocalBinBounds_11(GetCppThis(), level, localBin, bounds);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalBinningFilter_GetLocalBinOffset_12(HandleRef pThis, int level, int localBin, ref long npts);

	/// <summary>
	/// Convenience methods for extracting useful information about this bin
	/// tree.  Given a level, and the bin number in that level, return the
	/// offset point id and number of points for that bin. Invoke this method
	/// after the bin tree has been built.
	/// </summary>
	public long GetLocalBinOffset(int level, int localBin, ref long npts)
	{
		return vtkHierarchicalBinningFilter_GetLocalBinOffset_12(GetCppThis(), level, localBin, ref npts);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBinningFilter_GetNumberOfBins_13(HandleRef pThis, int level);

	/// <summary>
	/// Convenience methods for extracting useful information about this bin
	/// tree.  Return the number of bins in a particular level of the
	/// tree. Invoke this method after the bin tree has been built.
	/// </summary>
	public int GetNumberOfBins(int level)
	{
		return vtkHierarchicalBinningFilter_GetNumberOfBins_13(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalBinningFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHierarchicalBinningFilter_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalBinningFilter_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHierarchicalBinningFilter_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBinningFilter_GetNumberOfGlobalBins_16(HandleRef pThis);

	/// <summary>
	/// Convenience methods for extracting useful information about this bin
	/// tree.  Return the number of total bins across all levels (i.e., the
	/// total global bins). Invoke this method after the bin tree has been
	/// built.
	/// </summary>
	public int GetNumberOfGlobalBins()
	{
		return vtkHierarchicalBinningFilter_GetNumberOfGlobalBins_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBinningFilter_GetNumberOfLevels_17(HandleRef pThis);

	/// <summary>
	/// Specify the number of levels in the spatial hierarchy. By default, the
	/// number of levels is three.
	/// </summary>
	public virtual int GetNumberOfLevels()
	{
		return vtkHierarchicalBinningFilter_GetNumberOfLevels_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBinningFilter_GetNumberOfLevelsMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the number of levels in the spatial hierarchy. By default, the
	/// number of levels is three.
	/// </summary>
	public virtual int GetNumberOfLevelsMaxValue()
	{
		return vtkHierarchicalBinningFilter_GetNumberOfLevelsMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBinningFilter_GetNumberOfLevelsMinValue_19(HandleRef pThis);

	/// <summary>
	/// Specify the number of levels in the spatial hierarchy. By default, the
	/// number of levels is three.
	/// </summary>
	public virtual int GetNumberOfLevelsMinValue()
	{
		return vtkHierarchicalBinningFilter_GetNumberOfLevelsMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBinningFilter_IsA_20(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHierarchicalBinningFilter_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBinningFilter_IsTypeOf_21(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHierarchicalBinningFilter_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBinningFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkHierarchicalBinningFilter NewInstance()
	{
		vtkHierarchicalBinningFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBinningFilter_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHierarchicalBinningFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBinningFilter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkHierarchicalBinningFilter SafeDownCast(vtkObjectBase o)
	{
		vtkHierarchicalBinningFilter vtkHierarchicalBinningFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBinningFilter_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHierarchicalBinningFilter2 = (vtkHierarchicalBinningFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHierarchicalBinningFilter2.Register(null);
			}
		}
		return vtkHierarchicalBinningFilter2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_SetAutomatic_25(HandleRef pThis, byte _arg);

	/// <summary>
	/// Specify whether to determine the determine the level divisions, and the bounding
	/// box automatically (by default this is on). If off, then the user must specify both
	/// the bounding box and bin divisions. (Computing the bounding box can be slow for
	/// large point clouds, manual specification can save time.)
	/// </summary>
	public virtual void SetAutomatic(bool _arg)
	{
		vtkHierarchicalBinningFilter_SetAutomatic_25(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_SetBounds_26(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set the bounding box of the point cloud. If Automatic is enabled, then
	/// this is computed during filter execution. If manually specified
	/// (Automatic is off) then make sure the bounds is represented as
	/// (xmin,xmax, ymin,ymax, zmin,zmax). If the bounds specified is does not
	/// enclose the points, then points are clamped to lie in the bounding box.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkHierarchicalBinningFilter_SetBounds_26(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_SetBounds_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the bounding box of the point cloud. If Automatic is enabled, then
	/// this is computed during filter execution. If manually specified
	/// (Automatic is off) then make sure the bounds is represented as
	/// (xmin,xmax, ymin,ymax, zmin,zmax). If the bounds specified is does not
	/// enclose the points, then points are clamped to lie in the bounding box.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkHierarchicalBinningFilter_SetBounds_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_SetDivisions_28(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set the number of branching divisions in each binning direction. Each
	/// level of the tree is subdivided by this factor. The Divisions[i] must be
	/// &gt;= 1. Note: if Automatic subdivision is specified, the Divisions are
	/// set by the filter.
	/// </summary>
	public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
	{
		vtkHierarchicalBinningFilter_SetDivisions_28(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_SetDivisions_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the number of branching divisions in each binning direction. Each
	/// level of the tree is subdivided by this factor. The Divisions[i] must be
	/// &gt;= 1. Note: if Automatic subdivision is specified, the Divisions are
	/// set by the filter.
	/// </summary>
	public virtual void SetDivisions(IntPtr _arg)
	{
		vtkHierarchicalBinningFilter_SetDivisions_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHierarchicalBinningFilter_SetNumberOfLevels_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of levels in the spatial hierarchy. By default, the
	/// number of levels is three.
	/// </summary>
	public virtual void SetNumberOfLevels(int _arg)
	{
		vtkHierarchicalBinningFilter_SetNumberOfLevels_30(GetCppThis(), _arg);
	}
}
