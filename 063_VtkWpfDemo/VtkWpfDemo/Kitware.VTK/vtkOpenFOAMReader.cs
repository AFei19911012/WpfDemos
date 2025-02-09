using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenFOAMReader
/// </summary>
/// <remarks>
///    reads a dataset in OpenFOAM format
///
/// vtkOpenFOAMReader creates a multiblock dataset. It reads mesh
/// information and time dependent data.  The polyMesh folders contain
/// mesh information. The time folders contain transient data for the
/// cells. Each folder can contain any number of data files.
///
/// @par Thanks:
/// </remarks>
/// <seealso>
/// Thanks to Terry Jordan (terry.jordan.netl.doe.gov) of SAIC
/// at the National Energy Technology Laboratory who originally
/// developed this class.
///
/// Takuya Oshima of Niigata University, Japan (oshima@eng.niigata-u.ac.jp)
/// provided the major bulk of improvements (rewrite) that made the reader
/// truly functional and included the following features:
/// Token-based FoamFile format lexer/parser,
/// performance/stability/compatibility enhancements, gzipped file
/// support, lagrangian field support, variable timestep support,
/// builtin cell-to-point filter, pointField support, polyhedron
/// decomposition support, multiregion support, parallelization support for
/// decomposed cases in conjunction with vtkPOpenFOAMReader etc.
///
/// Philippose Rajan (sarith@rocketmail.com) added
/// GUI-based selection of mesh regions and fields available in the case,
/// minor bug fixes, strict memory allocation checks,
///
/// Mark Olesen (OpenCFD Ltd.) www.openfoam.com
/// has provided various bugfixes, improvements, cleanup
/// </seealso>
public class vtkOpenFOAMReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenFOAMReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenFOAMReader()
	{
		MRClassNameKey = "class vtkOpenFOAMReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenFOAMReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenFOAMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenFOAMReader New()
	{
		vtkOpenFOAMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenFOAMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenFOAMReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenFOAMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_AddDimensionsToArrayNamesOff_01(HandleRef pThis);

	/// <summary>
	/// Add dimensions to array names
	/// </summary>
	public virtual void AddDimensionsToArrayNamesOff()
	{
		vtkOpenFOAMReader_AddDimensionsToArrayNamesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_AddDimensionsToArrayNamesOn_02(HandleRef pThis);

	/// <summary>
	/// Add dimensions to array names
	/// </summary>
	public virtual void AddDimensionsToArrayNamesOn()
	{
		vtkOpenFOAMReader_AddDimensionsToArrayNamesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_CacheMeshOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get whether mesh is to be cached.
	/// </summary>
	public virtual void CacheMeshOff()
	{
		vtkOpenFOAMReader_CacheMeshOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_CacheMeshOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get whether mesh is to be cached.
	/// </summary>
	public virtual void CacheMeshOn()
	{
		vtkOpenFOAMReader_CacheMeshOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_CanReadFile_05(HandleRef pThis, string arg0);

	/// <summary>
	/// Determine if the file can be read with this reader.
	/// </summary>
	public int CanReadFile(string arg0)
	{
		return vtkOpenFOAMReader_CanReadFile_05(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_CopyDataToCellZonesOff_06(HandleRef pThis);

	/// <summary>
	/// If true, data of the internal mesh are copied to the cell zones.
	/// Default is false.
	/// </summary>
	public virtual void CopyDataToCellZonesOff()
	{
		vtkOpenFOAMReader_CopyDataToCellZonesOff_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_CopyDataToCellZonesOn_07(HandleRef pThis);

	/// <summary>
	/// If true, data of the internal mesh are copied to the cell zones.
	/// Default is false.
	/// </summary>
	public virtual void CopyDataToCellZonesOn()
	{
		vtkOpenFOAMReader_CopyDataToCellZonesOn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_CreateCellToPointOff_08(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to create cell-to-point translated data for cell-type data
	/// </summary>
	public virtual void CreateCellToPointOff()
	{
		vtkOpenFOAMReader_CreateCellToPointOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_CreateCellToPointOn_09(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to create cell-to-point translated data for cell-type data
	/// </summary>
	public virtual void CreateCellToPointOn()
	{
		vtkOpenFOAMReader_CreateCellToPointOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_DecomposePolyhedraOff_10(HandleRef pThis);

	/// <summary>
	/// Set/Get whether polyhedra are to be decomposed.
	/// </summary>
	public virtual void DecomposePolyhedraOff()
	{
		vtkOpenFOAMReader_DecomposePolyhedraOff_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_DecomposePolyhedraOn_11(HandleRef pThis);

	/// <summary>
	/// Set/Get whether polyhedra are to be decomposed.
	/// </summary>
	public virtual void DecomposePolyhedraOn()
	{
		vtkOpenFOAMReader_DecomposePolyhedraOn_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_DisableAllCellArrays_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off all cell arrays.
	/// </summary>
	public void DisableAllCellArrays()
	{
		vtkOpenFOAMReader_DisableAllCellArrays_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_DisableAllLagrangianArrays_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off all Lagrangian arrays.
	/// </summary>
	public void DisableAllLagrangianArrays()
	{
		vtkOpenFOAMReader_DisableAllLagrangianArrays_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_DisableAllPatchArrays_14(HandleRef pThis);

	/// <summary>
	/// Turn on/off all Patches including the Internal Mesh.
	/// </summary>
	public void DisableAllPatchArrays()
	{
		vtkOpenFOAMReader_DisableAllPatchArrays_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_DisableAllPointArrays_15(HandleRef pThis);

	/// <summary>
	/// Turn on/off all point arrays.
	/// </summary>
	public void DisableAllPointArrays()
	{
		vtkOpenFOAMReader_DisableAllPointArrays_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_EnableAllCellArrays_16(HandleRef pThis);

	/// <summary>
	/// Turn on/off all cell arrays.
	/// </summary>
	public void EnableAllCellArrays()
	{
		vtkOpenFOAMReader_EnableAllCellArrays_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_EnableAllLagrangianArrays_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off all Lagrangian arrays.
	/// </summary>
	public void EnableAllLagrangianArrays()
	{
		vtkOpenFOAMReader_EnableAllLagrangianArrays_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_EnableAllPatchArrays_18(HandleRef pThis);

	/// <summary>
	/// Turn on/off all Patches including the Internal Mesh.
	/// </summary>
	public void EnableAllPatchArrays()
	{
		vtkOpenFOAMReader_EnableAllPatchArrays_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_EnableAllPointArrays_19(HandleRef pThis);

	/// <summary>
	/// Turn on/off all point arrays.
	/// </summary>
	public void EnableAllPointArrays()
	{
		vtkOpenFOAMReader_EnableAllPointArrays_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetAddDimensionsToArrayNames_20(HandleRef pThis);

	/// <summary>
	/// Add dimensions to array names
	/// </summary>
	public virtual int GetAddDimensionsToArrayNames()
	{
		return vtkOpenFOAMReader_GetAddDimensionsToArrayNames_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetCacheMesh_21(HandleRef pThis);

	/// <summary>
	/// Set/Get whether mesh is to be cached.
	/// </summary>
	public virtual int GetCacheMesh()
	{
		return vtkOpenFOAMReader_GetCacheMesh_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_GetCellArrayName_22(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the cell array with the given index in
	/// the input.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkOpenFOAMReader_GetCellArrayName_22(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetCellArrayStatus_23(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the cell array with the given name is to
	/// be read.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkOpenFOAMReader_GetCellArrayStatus_23(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenFOAMReader_GetCopyDataToCellZones_24(HandleRef pThis);

	/// <summary>
	/// If true, data of the internal mesh are copied to the cell zones.
	/// Default is false.
	/// </summary>
	public virtual bool GetCopyDataToCellZones()
	{
		return (vtkOpenFOAMReader_GetCopyDataToCellZones_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetCreateCellToPoint_25(HandleRef pThis);

	/// <summary>
	/// Set/Get whether to create cell-to-point translated data for cell-type data
	/// </summary>
	public virtual int GetCreateCellToPoint()
	{
		return vtkOpenFOAMReader_GetCreateCellToPoint_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetDecomposePolyhedra_26(HandleRef pThis);

	/// <summary>
	/// Set/Get whether polyhedra are to be decomposed.
	/// </summary>
	public virtual int GetDecomposePolyhedra()
	{
		return vtkOpenFOAMReader_GetDecomposePolyhedra_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_GetFileName_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the filename.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkOpenFOAMReader_GetFileName_27(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_GetLagrangianArrayName_28(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the Lagrangian array with the given index in
	/// the input.
	/// </summary>
	public string GetLagrangianArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkOpenFOAMReader_GetLagrangianArrayName_28(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetLagrangianArrayStatus_29(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the Lagrangian array with the given name is to
	/// be read.
	/// </summary>
	public int GetLagrangianArrayStatus(string name)
	{
		return vtkOpenFOAMReader_GetLagrangianArrayStatus_29(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetListTimeStepsByControlDict_30(HandleRef pThis);

	/// <summary>
	/// Determine if time directories are to be listed according to controlDict
	/// </summary>
	public virtual int GetListTimeStepsByControlDict()
	{
		return vtkOpenFOAMReader_GetListTimeStepsByControlDict_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetNumberOfCellArrays_31(HandleRef pThis);

	/// <summary>
	/// Get the number of cell arrays available in the input.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkOpenFOAMReader_GetNumberOfCellArrays_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenFOAMReader_GetNumberOfGenerationsFromBase_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenFOAMReader_GetNumberOfGenerationsFromBase_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenFOAMReader_GetNumberOfGenerationsFromBaseType_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenFOAMReader_GetNumberOfGenerationsFromBaseType_33(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetNumberOfLagrangianArrays_34(HandleRef pThis);

	/// <summary>
	/// Get the number of Lagrangian arrays available in the input.
	/// </summary>
	public int GetNumberOfLagrangianArrays()
	{
		return vtkOpenFOAMReader_GetNumberOfLagrangianArrays_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetNumberOfPatchArrays_35(HandleRef pThis);

	/// <summary>
	/// Get the number of Patches (including Internal Mesh) available in the input.
	/// </summary>
	public int GetNumberOfPatchArrays()
	{
		return vtkOpenFOAMReader_GetNumberOfPatchArrays_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetNumberOfPointArrays_36(HandleRef pThis);

	/// <summary>
	/// Get the number of point arrays available in the input.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkOpenFOAMReader_GetNumberOfPointArrays_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_GetPatchArrayName_37(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the Patch with the given index in
	/// the input.
	/// </summary>
	public string GetPatchArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkOpenFOAMReader_GetPatchArrayName_37(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetPatchArrayStatus_38(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the Patch with the given name is to
	/// be read.
	/// </summary>
	public int GetPatchArrayStatus(string name)
	{
		return vtkOpenFOAMReader_GetPatchArrayStatus_38(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_GetPointArrayName_39(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point array with the given index in
	/// the input.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkOpenFOAMReader_GetPointArrayName_39(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetPointArrayStatus_40(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the point array with the given name is to
	/// be read.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkOpenFOAMReader_GetPointArrayStatus_40(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetPositionsIsIn13Format_41(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the lagrangian/positions have additional data or not.
	/// For historical reasons, PositionsIsIn13Format is used to denote that
	/// the positions only have x,y,z value and the cell of the enclosing cell.
	/// In OpenFOAM 1.4-2.4, positions included facei and stepFraction information.
	/// </summary>
	public virtual int GetPositionsIsIn13Format()
	{
		return vtkOpenFOAMReader_GetPositionsIsIn13Format_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_GetReadZones_42(HandleRef pThis);

	/// <summary>
	/// Set/Get whether zones will be read.
	/// </summary>
	public virtual int GetReadZones()
	{
		return vtkOpenFOAMReader_GetReadZones_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenFOAMReader_GetSkipZeroTime_43(HandleRef pThis);

	/// <summary>
	/// Ignore 0/ time directory, which is normally missing Lagrangian fields
	/// and may have many dictionary functionality that we cannot easily handle.
	/// </summary>
	public virtual bool GetSkipZeroTime()
	{
		return (vtkOpenFOAMReader_GetSkipZeroTime_43(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_GetTimeNames_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public vtkStringArray GetTimeNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenFOAMReader_GetTimeNames_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkOpenFOAMReader_GetTimeValue_45(HandleRef pThis);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public double GetTimeValue()
	{
		return vtkOpenFOAMReader_GetTimeValue_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_GetTimeValues_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public vtkDoubleArray GetTimeValues()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenFOAMReader_GetTimeValues_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenFOAMReader_GetUse64BitFloats_47(HandleRef pThis);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public virtual bool GetUse64BitFloats()
	{
		return (vtkOpenFOAMReader_GetUse64BitFloats_47(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenFOAMReader_GetUse64BitLabels_48(HandleRef pThis);

	/// <summary>
	/// If true, labels are expected to be 64-bit, rather than 32.
	/// </summary>
	public virtual bool GetUse64BitLabels()
	{
		return (vtkOpenFOAMReader_GetUse64BitLabels_48(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_IsA_49(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenFOAMReader_IsA_49(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_IsTypeOf_50(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenFOAMReader_IsTypeOf_50(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_ListTimeStepsByControlDictOff_51(HandleRef pThis);

	/// <summary>
	/// Determine if time directories are to be listed according to controlDict
	/// </summary>
	public virtual void ListTimeStepsByControlDictOff()
	{
		vtkOpenFOAMReader_ListTimeStepsByControlDictOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_ListTimeStepsByControlDictOn_52(HandleRef pThis);

	/// <summary>
	/// Determine if time directories are to be listed according to controlDict
	/// </summary>
	public virtual void ListTimeStepsByControlDictOn()
	{
		vtkOpenFOAMReader_ListTimeStepsByControlDictOn_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_MakeInformationVector_53(HandleRef pThis, HandleRef arg0, string procDirName, HandleRef timeNames, HandleRef timeValues);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public int MakeInformationVector(vtkInformationVector arg0, string procDirName, vtkStringArray timeNames, vtkDoubleArray timeValues)
	{
		return vtkOpenFOAMReader_MakeInformationVector_53(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), procDirName, timeNames?.GetCppThis() ?? default(HandleRef), timeValues?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenFOAMReader_MakeMetaDataAtTimeStep_54(HandleRef pThis, byte arg0);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public int MakeMetaDataAtTimeStep(bool arg0)
	{
		return vtkOpenFOAMReader_MakeMetaDataAtTimeStep_54(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_NewInstance_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenFOAMReader NewInstance()
	{
		vtkOpenFOAMReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenFOAMReader_NewInstance_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_PositionsIsIn13FormatOff_57(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the lagrangian/positions have additional data or not.
	/// For historical reasons, PositionsIsIn13Format is used to denote that
	/// the positions only have x,y,z value and the cell of the enclosing cell.
	/// In OpenFOAM 1.4-2.4, positions included facei and stepFraction information.
	/// </summary>
	public virtual void PositionsIsIn13FormatOff()
	{
		vtkOpenFOAMReader_PositionsIsIn13FormatOff_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_PositionsIsIn13FormatOn_58(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the lagrangian/positions have additional data or not.
	/// For historical reasons, PositionsIsIn13Format is used to denote that
	/// the positions only have x,y,z value and the cell of the enclosing cell.
	/// In OpenFOAM 1.4-2.4, positions included facei and stepFraction information.
	/// </summary>
	public virtual void PositionsIsIn13FormatOn()
	{
		vtkOpenFOAMReader_PositionsIsIn13FormatOn_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_ReadZonesOff_59(HandleRef pThis);

	/// <summary>
	/// Set/Get whether zones will be read.
	/// </summary>
	public virtual void ReadZonesOff()
	{
		vtkOpenFOAMReader_ReadZonesOff_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_ReadZonesOn_60(HandleRef pThis);

	/// <summary>
	/// Set/Get whether zones will be read.
	/// </summary>
	public virtual void ReadZonesOn()
	{
		vtkOpenFOAMReader_ReadZonesOn_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenFOAMReader_SafeDownCast_61(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenFOAMReader SafeDownCast(vtkObjectBase o)
	{
		vtkOpenFOAMReader vtkOpenFOAMReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenFOAMReader_SafeDownCast_61(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenFOAMReader2 = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenFOAMReader2.Register(null);
			}
		}
		return vtkOpenFOAMReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetAddDimensionsToArrayNames_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Add dimensions to array names
	/// </summary>
	public virtual void SetAddDimensionsToArrayNames(int _arg)
	{
		vtkOpenFOAMReader_SetAddDimensionsToArrayNames_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetCacheMesh_63(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether mesh is to be cached.
	/// </summary>
	public virtual void SetCacheMesh(int _arg)
	{
		vtkOpenFOAMReader_SetCacheMesh_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetCellArrayStatus_64(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the cell array with the given name is to
	/// be read.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkOpenFOAMReader_SetCellArrayStatus_64(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetCopyDataToCellZones_65(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, data of the internal mesh are copied to the cell zones.
	/// Default is false.
	/// </summary>
	public virtual void SetCopyDataToCellZones(bool _arg)
	{
		vtkOpenFOAMReader_SetCopyDataToCellZones_65(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetCreateCellToPoint_66(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether to create cell-to-point translated data for cell-type data
	/// </summary>
	public virtual void SetCreateCellToPoint(int _arg)
	{
		vtkOpenFOAMReader_SetCreateCellToPoint_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetDecomposePolyhedra_67(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether polyhedra are to be decomposed.
	/// </summary>
	public virtual void SetDecomposePolyhedra(int _arg)
	{
		vtkOpenFOAMReader_SetDecomposePolyhedra_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetFileName_68(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the filename.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkOpenFOAMReader_SetFileName_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetLagrangianArrayStatus_69(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the Lagrangian array with the given name is to
	/// be read.
	/// </summary>
	public void SetLagrangianArrayStatus(string name, int status)
	{
		vtkOpenFOAMReader_SetLagrangianArrayStatus_69(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetListTimeStepsByControlDict_70(HandleRef pThis, int _arg);

	/// <summary>
	/// Determine if time directories are to be listed according to controlDict
	/// </summary>
	public virtual void SetListTimeStepsByControlDict(int _arg)
	{
		vtkOpenFOAMReader_SetListTimeStepsByControlDict_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetParent_71(HandleRef pThis, HandleRef parent);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public void SetParent(vtkOpenFOAMReader parent)
	{
		vtkOpenFOAMReader_SetParent_71(GetCppThis(), parent?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetPatchArrayStatus_72(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the Patch with the given name is to
	/// be read.
	/// </summary>
	public void SetPatchArrayStatus(string name, int status)
	{
		vtkOpenFOAMReader_SetPatchArrayStatus_72(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetPointArrayStatus_73(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the point array with the given name is to
	/// be read.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkOpenFOAMReader_SetPointArrayStatus_73(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetPositionsIsIn13Format_74(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether the lagrangian/positions have additional data or not.
	/// For historical reasons, PositionsIsIn13Format is used to denote that
	/// the positions only have x,y,z value and the cell of the enclosing cell.
	/// In OpenFOAM 1.4-2.4, positions included facei and stepFraction information.
	/// </summary>
	public virtual void SetPositionsIsIn13Format(int _arg)
	{
		vtkOpenFOAMReader_SetPositionsIsIn13Format_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetReadZones_75(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether zones will be read.
	/// </summary>
	public virtual void SetReadZones(int _arg)
	{
		vtkOpenFOAMReader_SetReadZones_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetRefresh_76(HandleRef pThis);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public void SetRefresh()
	{
		vtkOpenFOAMReader_SetRefresh_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetSkipZeroTime_77(HandleRef pThis, byte _arg);

	/// <summary>
	/// Ignore 0/ time directory, which is normally missing Lagrangian fields
	/// and may have many dictionary functionality that we cannot easily handle.
	/// </summary>
	public virtual void SetSkipZeroTime(bool _arg)
	{
		vtkOpenFOAMReader_SetSkipZeroTime_77(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenFOAMReader_SetTimeValue_78(HandleRef pThis, double arg0);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public bool SetTimeValue(double arg0)
	{
		return (vtkOpenFOAMReader_SetTimeValue_78(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetUse64BitFloats_79(HandleRef pThis, byte val);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public virtual void SetUse64BitFloats(bool val)
	{
		vtkOpenFOAMReader_SetUse64BitFloats_79(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SetUse64BitLabels_80(HandleRef pThis, byte val);

	/// <summary>
	/// If true, labels are expected to be 64-bit, rather than 32.
	/// </summary>
	public virtual void SetUse64BitLabels(bool val)
	{
		vtkOpenFOAMReader_SetUse64BitLabels_80(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SkipZeroTimeOff_81(HandleRef pThis);

	/// <summary>
	/// Ignore 0/ time directory, which is normally missing Lagrangian fields
	/// and may have many dictionary functionality that we cannot easily handle.
	/// </summary>
	public virtual void SkipZeroTimeOff()
	{
		vtkOpenFOAMReader_SkipZeroTimeOff_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_SkipZeroTimeOn_82(HandleRef pThis);

	/// <summary>
	/// Ignore 0/ time directory, which is normally missing Lagrangian fields
	/// and may have many dictionary functionality that we cannot easily handle.
	/// </summary>
	public virtual void SkipZeroTimeOn()
	{
		vtkOpenFOAMReader_SkipZeroTimeOn_82(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_Use64BitFloatsOff_83(HandleRef pThis);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public virtual void Use64BitFloatsOff()
	{
		vtkOpenFOAMReader_Use64BitFloatsOff_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_Use64BitFloatsOn_84(HandleRef pThis);

	/// <summary>
	/// If true, floats are expected to be 64-bit, rather than 32. Note that
	/// vtkFloatArrays may still be used in the output if this is true. This flag
	/// is only used to ensure that binary data is correctly parsed.
	/// </summary>
	public virtual void Use64BitFloatsOn()
	{
		vtkOpenFOAMReader_Use64BitFloatsOn_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_Use64BitLabelsOff_85(HandleRef pThis);

	/// <summary>
	/// If true, labels are expected to be 64-bit, rather than 32.
	/// </summary>
	public virtual void Use64BitLabelsOff()
	{
		vtkOpenFOAMReader_Use64BitLabelsOff_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenFOAMReader_Use64BitLabelsOn_86(HandleRef pThis);

	/// <summary>
	/// If true, labels are expected to be 64-bit, rather than 32.
	/// </summary>
	public virtual void Use64BitLabelsOn()
	{
		vtkOpenFOAMReader_Use64BitLabelsOn_86(GetCppThis());
	}
}
