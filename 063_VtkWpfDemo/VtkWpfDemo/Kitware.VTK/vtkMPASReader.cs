using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMPASReader
/// </summary>
/// <remarks>
///    Read an MPAS netCDF file
///
/// This program reads an MPAS netCDF data file to allow paraview to
/// display a dual-grid sphere or latlon projection.  Also allows
/// display of primal-grid sphere.
/// The variables that have time dim are available to ParaView.
///
/// Assume all variables are of interest if they have dims
/// (Time, nCells|nVertices, nVertLevels, [nTracers]).
/// Does not deal with edge data.
///
/// When using this reader, it is important that you remember to do the
///             following:
///   1.  When changing a selected variable, remember to select it also
///       in the drop down box to "color by".  It doesn't color by that variable
///       automatically.
///   2.  When selecting multilayer sphere view, make layer thickness around
///       100,000.
///   3.  When selecting multilayer lat/lon view, make layer thickness around 10.
///   4.  Always click the -Z orientation after making a switch from lat/lon to
///       sphere, from single to multilayer or changing thickness.
///   5.  Be conservative on the number of changes you make before hitting Apply,
///       since there may be bugs in this reader.  Just make one change and then
///       hit Apply.
///
///
/// Christine Ahrens (cahrens@lanl.gov)
/// Version 1.3
/// </remarks>
public class vtkMPASReader : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMPASReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMPASReader()
	{
		MRClassNameKey = "class vtkMPASReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMPASReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMPASReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMPASReader New()
	{
		vtkMPASReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMPASReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMPASReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMPASReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_CanReadFile_01(string filename);

	/// <summary>
	/// Returns true if the given file can be read.
	/// </summary>
	public static int CanReadFile(string filename)
	{
		return vtkMPASReader_CanReadFile_01(filename);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_DisableAllCellArrays_02(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void DisableAllCellArrays()
	{
		vtkMPASReader_DisableAllCellArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_DisableAllPointArrays_03(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void DisableAllPointArrays()
	{
		vtkMPASReader_DisableAllPointArrays_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_EnableAllCellArrays_04(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void EnableAllCellArrays()
	{
		vtkMPASReader_EnableAllCellArrays_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_EnableAllPointArrays_05(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void EnableAllPointArrays()
	{
		vtkMPASReader_EnableAllPointArrays_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetAllDimensions_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If the point/cell arrays contain dimensions other than Time, nCells, or
	/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
	/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
	/// retrieve the dimension names. GetDimensionSize returns the number of values
	/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
	/// to fix a given dimension at when extracting slices of data.
	/// </summary>
	public vtkStringArray GetAllDimensions()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMPASReader_GetAllDimensions_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetCellArrayName_07(HandleRef pThis, int index);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkMPASReader_GetCellArrayName_07(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetCellArrayStatus_08(HandleRef pThis, string name);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkMPASReader_GetCellArrayStatus_08(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetCenterLonRange_09(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual int[] GetCenterLonRange()
	{
		IntPtr intPtr = vtkMPASReader_GetCenterLonRange_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_GetCenterLonRange_10(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void GetCenterLonRange(ref int _arg1, ref int _arg2)
	{
		vtkMPASReader_GetCenterLonRange_10(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_GetCenterLonRange_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void GetCenterLonRange(IntPtr _arg)
	{
		vtkMPASReader_GetCenterLonRange_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetDimensionCurrentIndex_12(HandleRef pThis, string dim);

	/// <summary>
	/// If the point/cell arrays contain dimensions other than Time, nCells, or
	/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
	/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
	/// retrieve the dimension names. GetDimensionSize returns the number of values
	/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
	/// to fix a given dimension at when extracting slices of data.
	/// </summary>
	public int GetDimensionCurrentIndex(string dim)
	{
		return vtkMPASReader_GetDimensionCurrentIndex_12(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkMPASReader_GetDimensionName_13(HandleRef pThis, int idx);

	/// <summary>
	/// If the point/cell arrays contain dimensions other than Time, nCells, or
	/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
	/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
	/// retrieve the dimension names. GetDimensionSize returns the number of values
	/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
	/// to fix a given dimension at when extracting slices of data.
	/// </summary>
	public string GetDimensionName(int idx)
	{
		return vtkMPASReader_GetDimensionName_13(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetDimensionSize_14(HandleRef pThis, string dim);

	/// <summary>
	/// If the point/cell arrays contain dimensions other than Time, nCells, or
	/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
	/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
	/// retrieve the dimension names. GetDimensionSize returns the number of values
	/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
	/// to fix a given dimension at when extracting slices of data.
	/// </summary>
	public int GetDimensionSize(string dim)
	{
		return vtkMPASReader_GetDimensionSize_14(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetFileName_15(HandleRef pThis);

	/// <summary>
	/// Specify file name of MPAS data file to read.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMPASReader_GetFileName_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMPASReader_GetIsAtmosphere_16(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual bool GetIsAtmosphere()
	{
		return (vtkMPASReader_GetIsAtmosphere_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMPASReader_GetIsZeroCentered_17(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual bool GetIsZeroCentered()
	{
		return (vtkMPASReader_GetIsZeroCentered_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetLayerThickness_18(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual int GetLayerThickness()
	{
		return vtkMPASReader_GetLayerThickness_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetLayerThicknessRange_19(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual int[] GetLayerThicknessRange()
	{
		IntPtr intPtr = vtkMPASReader_GetLayerThicknessRange_19(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_GetLayerThicknessRange_20(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void GetLayerThicknessRange(ref int _arg1, ref int _arg2)
	{
		vtkMPASReader_GetLayerThicknessRange_20(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_GetLayerThicknessRange_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void GetLayerThicknessRange(IntPtr _arg)
	{
		vtkMPASReader_GetLayerThicknessRange_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkMPASReader_GetMTime_22(HandleRef pThis);

	/// <summary>
	/// Returns true if the given file can be read.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkMPASReader_GetMTime_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetMaximumCells_23(HandleRef pThis);

	/// <summary>
	/// Get the number of data cells
	/// </summary>
	public virtual int GetMaximumCells()
	{
		return vtkMPASReader_GetMaximumCells_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetMaximumPoints_24(HandleRef pThis);

	/// <summary>
	/// Get the number of points
	/// </summary>
	public virtual int GetMaximumPoints()
	{
		return vtkMPASReader_GetMaximumPoints_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetNumberOfCellArrays_25(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkMPASReader_GetNumberOfCellArrays_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetNumberOfCellVars_26(HandleRef pThis);

	/// <summary>
	/// Get the number of data variables at the cell centers and points
	/// </summary>
	public virtual int GetNumberOfCellVars()
	{
		return vtkMPASReader_GetNumberOfCellVars_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMPASReader_GetNumberOfDimensions_27(HandleRef pThis);

	/// <summary>
	/// If the point/cell arrays contain dimensions other than Time, nCells, or
	/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
	/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
	/// retrieve the dimension names. GetDimensionSize returns the number of values
	/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
	/// to fix a given dimension at when extracting slices of data.
	/// </summary>
	public long GetNumberOfDimensions()
	{
		return vtkMPASReader_GetNumberOfDimensions_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMPASReader_GetNumberOfGenerationsFromBase_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMPASReader_GetNumberOfGenerationsFromBase_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMPASReader_GetNumberOfGenerationsFromBaseType_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMPASReader_GetNumberOfGenerationsFromBaseType_29(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetNumberOfPointArrays_30(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkMPASReader_GetNumberOfPointArrays_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetNumberOfPointVars_31(HandleRef pThis);

	/// <summary>
	/// Get the number of data variables at the cell centers and points
	/// </summary>
	public virtual int GetNumberOfPointVars()
	{
		return vtkMPASReader_GetNumberOfPointVars_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetOutput_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the reader's output
	/// </summary>
	public new vtkUnstructuredGrid GetOutput()
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMPASReader_GetOutput_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetOutput_33(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the reader's output
	/// </summary>
	public new vtkUnstructuredGrid GetOutput(int idx)
	{
		vtkUnstructuredGrid vtkUnstructuredGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMPASReader_GetOutput_33(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGrid2 = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGrid2.Register(null);
			}
		}
		return vtkUnstructuredGrid2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetPointArrayName_34(HandleRef pThis, int index);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkMPASReader_GetPointArrayName_34(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetPointArrayStatus_35(HandleRef pThis, string name);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkMPASReader_GetPointArrayStatus_35(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMPASReader_GetProjectLatLon_36(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual bool GetProjectLatLon()
	{
		return (vtkMPASReader_GetProjectLatLon_36(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMPASReader_GetShowMultilayerView_37(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual bool GetShowMultilayerView()
	{
		return (vtkMPASReader_GetShowMultilayerView_37(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMPASReader_GetUseDimensionedArrayNames_38(HandleRef pThis);

	/// <summary>
	/// If true, dimension info is included in the array name. For instance,
	/// "tracers" will become "tracers(Time, nCells, nVertLevels, nTracers)".
	/// This is useful for user-visible array selection, but is disabled by default
	/// for backwards compatibility.
	/// </summary>
	public virtual bool GetUseDimensionedArrayNames()
	{
		return (vtkMPASReader_GetUseDimensionedArrayNames_38(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkMPASReader_GetVerticalDimension_39(HandleRef pThis);

	/// <summary>
	/// Get/Set the name to the dimension that identifies the vertical dimension.
	/// Defaults to "nVertLevels".
	/// </summary>
	public virtual string GetVerticalDimension()
	{
		return vtkMPASReader_GetVerticalDimension_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_GetVerticalLevel_40(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public int GetVerticalLevel()
	{
		return vtkMPASReader_GetVerticalLevel_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_GetVerticalLevelRange_41(HandleRef pThis);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual int[] GetVerticalLevelRange()
	{
		IntPtr intPtr = vtkMPASReader_GetVerticalLevelRange_41(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_GetVerticalLevelRange_42(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void GetVerticalLevelRange(ref int _arg1, ref int _arg2)
	{
		vtkMPASReader_GetVerticalLevelRange_42(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_GetVerticalLevelRange_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void GetVerticalLevelRange(IntPtr _arg)
	{
		vtkMPASReader_GetVerticalLevelRange_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_IsA_44(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMPASReader_IsA_44(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMPASReader_IsTypeOf_45(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMPASReader_IsTypeOf_45(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMPASReader NewInstance()
	{
		vtkMPASReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMPASReader_NewInstance_47(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMPASReader_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMPASReader SafeDownCast(vtkObjectBase o)
	{
		vtkMPASReader vtkMPASReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMPASReader_SafeDownCast_48(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMPASReader2 = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMPASReader2.Register(null);
			}
		}
		return vtkMPASReader2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetCellArrayStatus_49(HandleRef pThis, string name, int status);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkMPASReader_SetCellArrayStatus_49(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetCenterLon_50(HandleRef pThis, int val);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public void SetCenterLon(int val)
	{
		vtkMPASReader_SetCenterLon_50(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetDimensionCurrentIndex_51(HandleRef pThis, string dim, int idx);

	/// <summary>
	/// If the point/cell arrays contain dimensions other than Time, nCells, or
	/// nVertices, they are configured here. Use GetNumberOfDimensions to get the
	/// number of arbitrary dimensions in the loaded arrays and GetDimensionName to
	/// retrieve the dimension names. GetDimensionSize returns the number of values
	/// in the dimensions, and Set/GetDimensionCurrentIndex controls the value
	/// to fix a given dimension at when extracting slices of data.
	/// </summary>
	public void SetDimensionCurrentIndex(string dim, int idx)
	{
		vtkMPASReader_SetDimensionCurrentIndex_51(GetCppThis(), dim, idx);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetFileName_52(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of MPAS data file to read.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkMPASReader_SetFileName_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetIsAtmosphere_53(HandleRef pThis, byte _arg);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void SetIsAtmosphere(bool _arg)
	{
		vtkMPASReader_SetIsAtmosphere_53(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetIsZeroCentered_54(HandleRef pThis, byte _arg);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void SetIsZeroCentered(bool _arg)
	{
		vtkMPASReader_SetIsZeroCentered_54(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetLayerThickness_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void SetLayerThickness(int _arg)
	{
		vtkMPASReader_SetLayerThickness_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetPointArrayStatus_56(HandleRef pThis, string name, int status);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.
	/// By default, ALL data fields on the nodes are read, but this can
	/// be modified.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkMPASReader_SetPointArrayStatus_56(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetProjectLatLon_57(HandleRef pThis, byte _arg);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void SetProjectLatLon(bool _arg)
	{
		vtkMPASReader_SetProjectLatLon_57(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetShowMultilayerView_58(HandleRef pThis, byte _arg);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public virtual void SetShowMultilayerView(bool _arg)
	{
		vtkMPASReader_SetShowMultilayerView_58(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetUseDimensionedArrayNames_59(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, dimension info is included in the array name. For instance,
	/// "tracers" will become "tracers(Time, nCells, nVertLevels, nTracers)".
	/// This is useful for user-visible array selection, but is disabled by default
	/// for backwards compatibility.
	/// </summary>
	public virtual void SetUseDimensionedArrayNames(bool _arg)
	{
		vtkMPASReader_SetUseDimensionedArrayNames_59(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetVerticalDimension_60(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name to the dimension that identifies the vertical dimension.
	/// Defaults to "nVertLevels".
	/// </summary>
	public virtual void SetVerticalDimension(string _arg)
	{
		vtkMPASReader_SetVerticalDimension_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_SetVerticalLevel_61(HandleRef pThis, int level);

	/// <summary>
	/// Convenience function for setting/querying [GS]etDimensionCurrentIndex
	/// for the dimension returned by GetVerticalDimension.
	/// </summary>
	public void SetVerticalLevel(int level)
	{
		vtkMPASReader_SetVerticalLevel_61(GetCppThis(), level);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_UseDimensionedArrayNamesOff_62(HandleRef pThis);

	/// <summary>
	/// If true, dimension info is included in the array name. For instance,
	/// "tracers" will become "tracers(Time, nCells, nVertLevels, nTracers)".
	/// This is useful for user-visible array selection, but is disabled by default
	/// for backwards compatibility.
	/// </summary>
	public virtual void UseDimensionedArrayNamesOff()
	{
		vtkMPASReader_UseDimensionedArrayNamesOff_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMPASReader_UseDimensionedArrayNamesOn_63(HandleRef pThis);

	/// <summary>
	/// If true, dimension info is included in the array name. For instance,
	/// "tracers" will become "tracers(Time, nCells, nVertLevels, nTracers)".
	/// This is useful for user-visible array selection, but is disabled by default
	/// for backwards compatibility.
	/// </summary>
	public virtual void UseDimensionedArrayNamesOn()
	{
		vtkMPASReader_UseDimensionedArrayNamesOn_63(GetCppThis());
	}
}
