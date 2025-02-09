using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCGNSReader
///
/// vtkCGNSReader creates a multi-block dataset and reads unstructured grids
/// and structured meshes from binary files stored in CGNS file format,
/// with data stored at the nodes, cells or faces.
///
/// vtkCGNSReader is inspired by the VisIt CGNS reader originally written by
/// B. Whitlock. vtkCGNSReader relies on the low level CGNS API to load data sets
/// and reduce memory footprint.
/// </summary>
public class vtkCGNSReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum DataArrayLocation
	{
		/// <summary>enum member</summary>
		CELL_DATA,
		/// <summary>enum member</summary>
		FACE_DATA
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCGNSReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCGNSReader()
	{
		MRClassNameKey = "class vtkCGNSReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCGNSReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCGNSReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCGNSReader New()
	{
		vtkCGNSReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCGNSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCGNSReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCGNSReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_Broadcast_01(HandleRef pThis, HandleRef ctrl);

	/// <summary>
	/// Sends metadata (that read from the input file, not settings modified
	/// through this API) from the rank 0 node to all other processes in a job.
	/// </summary>
	public void Broadcast(vtkMultiProcessController ctrl)
	{
		vtkCGNSReader_Broadcast_01(GetCppThis(), ctrl?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_CacheConnectivityOff_02(HandleRef pThis);

	/// <summary>
	/// This reader can cache the mesh connectivities if they are time invariant.
	/// They will be stored with a unique reference to their /base/zonename
	/// and not be read in the file when doing unsteady analysis.
	/// </summary>
	public virtual void CacheConnectivityOff()
	{
		vtkCGNSReader_CacheConnectivityOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_CacheConnectivityOn_03(HandleRef pThis);

	/// <summary>
	/// This reader can cache the mesh connectivities if they are time invariant.
	/// They will be stored with a unique reference to their /base/zonename
	/// and not be read in the file when doing unsteady analysis.
	/// </summary>
	public virtual void CacheConnectivityOn()
	{
		vtkCGNSReader_CacheConnectivityOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_CacheMeshOff_04(HandleRef pThis);

	/// <summary>
	/// This reader can cache the mesh points if they are time invariant.
	/// They will be stored with a unique reference to their /base/zonename
	/// and not be read in the file when doing unsteady analysis.
	/// </summary>
	public virtual void CacheMeshOff()
	{
		vtkCGNSReader_CacheMeshOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_CacheMeshOn_05(HandleRef pThis);

	/// <summary>
	/// This reader can cache the mesh points if they are time invariant.
	/// They will be stored with a unique reference to their /base/zonename
	/// and not be read in the file when doing unsteady analysis.
	/// </summary>
	public virtual void CacheMeshOn()
	{
		vtkCGNSReader_CacheMeshOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_CanReadFile_06(HandleRef pThis, string filename);

	/// <summary>
	/// Is the given file name a CGNS file?
	/// </summary>
	public int CanReadFile(string filename)
	{
		return vtkCGNSReader_CanReadFile_06(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_CreateEachSolutionAsBlockOff_07(HandleRef pThis);

	/// <summary>
	/// This option is provided for debugging and should not be used for production
	/// runs as the output data produced may not be correct. When set to true, the
	/// read will simply read each solution (`FlowSolution_t`) node encountered in
	/// a zone and create a separate block under the block corresponding to the
	/// zone in the output.
	/// </summary>
	public virtual void CreateEachSolutionAsBlockOff()
	{
		vtkCGNSReader_CreateEachSolutionAsBlockOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_CreateEachSolutionAsBlockOn_08(HandleRef pThis);

	/// <summary>
	/// This option is provided for debugging and should not be used for production
	/// runs as the output data produced may not be correct. When set to true, the
	/// read will simply read each solution (`FlowSolution_t`) node encountered in
	/// a zone and create a separate block under the block corresponding to the
	/// zone in the output.
	/// </summary>
	public virtual void CreateEachSolutionAsBlockOn()
	{
		vtkCGNSReader_CreateEachSolutionAsBlockOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DisableAllBases_09(HandleRef pThis);

	/// <summary>
	/// API to select bases to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
	///
	/// By default, 0-th base is enabled and all others are disabled.
	/// </summary>
	public void DisableAllBases()
	{
		vtkCGNSReader_DisableAllBases_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DisableAllCellArrays_10(HandleRef pThis);

	/// <summary>
	/// API to get information of cell arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void DisableAllCellArrays()
	{
		vtkCGNSReader_DisableAllCellArrays_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DisableAllFaceArrays_11(HandleRef pThis);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void DisableAllFaceArrays()
	{
		vtkCGNSReader_DisableAllFaceArrays_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DisableAllFamilies_12(HandleRef pThis);

	/// <summary>
	/// API to select families to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
	/// </summary>
	public void DisableAllFamilies()
	{
		vtkCGNSReader_DisableAllFamilies_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DisableAllPointArrays_13(HandleRef pThis);

	/// <summary>
	/// API to get information of point arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void DisableAllPointArrays()
	{
		vtkCGNSReader_DisableAllPointArrays_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DistributeBlocksOff_14(HandleRef pThis);

	/// <summary>
	/// This reader can support piece requests by distributing each block in each
	/// zone across ranks (default). To make the reader disregard piece request and
	/// read all blocks in the zone, set this to false (default is true).
	/// </summary>
	public virtual void DistributeBlocksOff()
	{
		vtkCGNSReader_DistributeBlocksOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DistributeBlocksOn_15(HandleRef pThis);

	/// <summary>
	/// This reader can support piece requests by distributing each block in each
	/// zone across ranks (default). To make the reader disregard piece request and
	/// read all blocks in the zone, set this to false (default is true).
	/// </summary>
	public virtual void DistributeBlocksOn()
	{
		vtkCGNSReader_DistributeBlocksOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DoublePrecisionMeshOff_16(HandleRef pThis);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public virtual void DoublePrecisionMeshOff()
	{
		vtkCGNSReader_DoublePrecisionMeshOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_DoublePrecisionMeshOn_17(HandleRef pThis);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public virtual void DoublePrecisionMeshOn()
	{
		vtkCGNSReader_DoublePrecisionMeshOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_EnableAllBases_18(HandleRef pThis);

	/// <summary>
	/// API to select bases to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
	///
	/// By default, 0-th base is enabled and all others are disabled.
	/// </summary>
	public void EnableAllBases()
	{
		vtkCGNSReader_EnableAllBases_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_EnableAllCellArrays_19(HandleRef pThis);

	/// <summary>
	/// API to get information of cell arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void EnableAllCellArrays()
	{
		vtkCGNSReader_EnableAllCellArrays_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_EnableAllFaceArrays_20(HandleRef pThis);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void EnableAllFaceArrays()
	{
		vtkCGNSReader_EnableAllFaceArrays_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_EnableAllFamilies_21(HandleRef pThis);

	/// <summary>
	/// API to select families to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
	/// </summary>
	public void EnableAllFamilies()
	{
		vtkCGNSReader_EnableAllFamilies_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_EnableAllPointArrays_22(HandleRef pThis);

	/// <summary>
	/// API to get information of point arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void EnableAllPointArrays()
	{
		vtkCGNSReader_EnableAllPointArrays_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_FAMILY_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key used to put a family name in the meta-data associated with a node
	/// </summary>
	public static vtkInformationStringKey FAMILY()
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSReader_FAMILY_23(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringKey2 = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringKey2.Register(null);
			}
		}
		return vtkInformationStringKey2;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetBaseArrayName_24(HandleRef pThis, int index);

	/// <summary>
	/// API to select bases to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
	///
	/// By default, 0-th base is enabled and all others are disabled.
	/// </summary>
	public string GetBaseArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkCGNSReader_GetBaseArrayName_24(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetBaseArrayStatus_25(HandleRef pThis, string name);

	/// <summary>
	/// API to select bases to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
	///
	/// By default, 0-th base is enabled and all others are disabled.
	/// </summary>
	public int GetBaseArrayStatus(string name)
	{
		return vtkCGNSReader_GetBaseArrayStatus_25(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetBaseSelection_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns access to the base selection object.
	/// </summary>
	public vtkDataArraySelection GetBaseSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSReader_GetBaseSelection_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSReader_GetCacheConnectivity_27(HandleRef pThis);

	/// <summary>
	/// This reader can cache the mesh connectivities if they are time invariant.
	/// They will be stored with a unique reference to their /base/zonename
	/// and not be read in the file when doing unsteady analysis.
	/// </summary>
	public virtual bool GetCacheConnectivity()
	{
		return (vtkCGNSReader_GetCacheConnectivity_27(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSReader_GetCacheMesh_28(HandleRef pThis);

	/// <summary>
	/// This reader can cache the mesh points if they are time invariant.
	/// They will be stored with a unique reference to their /base/zonename
	/// and not be read in the file when doing unsteady analysis.
	/// </summary>
	public virtual bool GetCacheMesh()
	{
		return (vtkCGNSReader_GetCacheMesh_28(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetCellArrayName_29(HandleRef pThis, int index);

	/// <summary>
	/// API to get information of cell arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkCGNSReader_GetCellArrayName_29(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetCellArrayStatus_30(HandleRef pThis, string name);

	/// <summary>
	/// API to get information of cell arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkCGNSReader_GetCellArrayStatus_30(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetController_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the communication object used to relay a list of files
	/// from the rank 0 process to all others. This is the only interprocess
	/// communication required by vtkPExodusIIReader.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSReader_GetController_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetCreateEachSolutionAsBlock_32(HandleRef pThis);

	/// <summary>
	/// This option is provided for debugging and should not be used for production
	/// runs as the output data produced may not be correct. When set to true, the
	/// read will simply read each solution (`FlowSolution_t`) node encountered in
	/// a zone and create a separate block under the block corresponding to the
	/// zone in the output.
	/// </summary>
	public virtual int GetCreateEachSolutionAsBlock()
	{
		return vtkCGNSReader_GetCreateEachSolutionAsBlock_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetDataLocation_33(HandleRef pThis);

	/// <summary>
	/// Set/get the location of the data arrays to read. Possible values for the data location are:
	/// - CELL_DATA - Read CellCenter data arrays from the CGNS file. Construct 3D meshes with 3D cells
	/// (e.g. a cube is defined as 1 cell).
	/// - FACE_DATA - Read FaceCenter data arrays from the CGNS file. Construct 3D meshes with 2D
	/// cells/faces (e.g. a cube is defined as 6 quad cells). Element connectivity must be defined with
	/// element type NGON_n.
	///
	/// Default is CELL_DATA.
	/// </summary>
	public virtual int GetDataLocation()
	{
		return vtkCGNSReader_GetDataLocation_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetDataLocationMaxValue_34(HandleRef pThis);

	/// <summary>
	/// Set/get the location of the data arrays to read. Possible values for the data location are:
	/// - CELL_DATA - Read CellCenter data arrays from the CGNS file. Construct 3D meshes with 3D cells
	/// (e.g. a cube is defined as 1 cell).
	/// - FACE_DATA - Read FaceCenter data arrays from the CGNS file. Construct 3D meshes with 2D
	/// cells/faces (e.g. a cube is defined as 6 quad cells). Element connectivity must be defined with
	/// element type NGON_n.
	///
	/// Default is CELL_DATA.
	/// </summary>
	public virtual int GetDataLocationMaxValue()
	{
		return vtkCGNSReader_GetDataLocationMaxValue_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetDataLocationMinValue_35(HandleRef pThis);

	/// <summary>
	/// Set/get the location of the data arrays to read. Possible values for the data location are:
	/// - CELL_DATA - Read CellCenter data arrays from the CGNS file. Construct 3D meshes with 3D cells
	/// (e.g. a cube is defined as 1 cell).
	/// - FACE_DATA - Read FaceCenter data arrays from the CGNS file. Construct 3D meshes with 2D
	/// cells/faces (e.g. a cube is defined as 6 quad cells). Element connectivity must be defined with
	/// element type NGON_n.
	///
	/// Default is CELL_DATA.
	/// </summary>
	public virtual int GetDataLocationMinValue()
	{
		return vtkCGNSReader_GetDataLocationMinValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSReader_GetDistributeBlocks_36(HandleRef pThis);

	/// <summary>
	/// This reader can support piece requests by distributing each block in each
	/// zone across ranks (default). To make the reader disregard piece request and
	/// read all blocks in the zone, set this to false (default is true).
	/// </summary>
	public virtual bool GetDistributeBlocks()
	{
		return (vtkCGNSReader_GetDistributeBlocks_36(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetDoublePrecisionMesh_37(HandleRef pThis);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public virtual int GetDoublePrecisionMesh()
	{
		return vtkCGNSReader_GetDoublePrecisionMesh_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetFaceArrayName_38(HandleRef pThis, int index);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public string GetFaceArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkCGNSReader_GetFaceArrayName_38(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetFaceArrayStatus_39(HandleRef pThis, string name);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public int GetFaceArrayStatus(string name)
	{
		return vtkCGNSReader_GetFaceArrayStatus_39(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetFamilyArrayName_40(HandleRef pThis, int index);

	/// <summary>
	/// API to select families to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
	/// </summary>
	public string GetFamilyArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkCGNSReader_GetFamilyArrayName_40(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetFamilyArrayStatus_41(HandleRef pThis, string name);

	/// <summary>
	/// API to select families to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
	/// </summary>
	public int GetFamilyArrayStatus(string name)
	{
		return vtkCGNSReader_GetFamilyArrayStatus_41(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetFamilySelection_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns access to the family selection object.
	/// </summary>
	public vtkDataArraySelection GetFamilySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSReader_GetFamilySelection_42(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetFileName_43(HandleRef pThis);

	/// <summary>
	/// Specify file name of CGNS datafile to read
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkCGNSReader_GetFileName_43(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSReader_GetIgnoreFlowSolutionPointers_44(HandleRef pThis);

	/// <summary>
	/// When set to true (default is false), the reader will simply
	/// ignore `FlowSolutionPointers` since they are either incomplete or invalid
	/// and instead will rely on FlowSolution_t nodes being labelled as
	/// "...AtStep&lt;tsindex&gt;" to locate solution nodes for a specific timestep.
	/// Note, tsindex starts with 1 (not zero).
	///
	/// When set to false, the reader will still try to confirm that at least one
	/// valid FlowSolution_t node is referred to in FlowSolutionPointers nodes for the
	/// current timestep. If none is found, then the reader will print out a
	/// warning and act as if IgnoreFlowSolutionPointers was set to true. To avoid
	/// this warning, one should set IgnoreFlowSolutionPointers to true.
	/// </summary>
	public virtual bool GetIgnoreFlowSolutionPointers()
	{
		return (vtkCGNSReader_GetIgnoreFlowSolutionPointers_44(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSReader_GetLoadBndPatch_45(HandleRef pThis);

	/// <summary>
	/// Enable/disable loading of boundary condition patches.
	/// Defaults to false.
	/// </summary>
	public virtual bool GetLoadBndPatch()
	{
		return (vtkCGNSReader_GetLoadBndPatch_45(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSReader_GetLoadMesh_46(HandleRef pThis);

	/// <summary>
	/// Enable/disable loading of zone mesh. Defaults to true. It may be turned off
	/// to load only boundary patches (when LoadBndPatch if ON), for example.
	/// </summary>
	public virtual bool GetLoadMesh()
	{
		return (vtkCGNSReader_GetLoadMesh_46(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetNumberOfBaseArrays_47(HandleRef pThis);

	/// <summary>
	/// API to select bases to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
	///
	/// By default, 0-th base is enabled and all others are disabled.
	/// </summary>
	public int GetNumberOfBaseArrays()
	{
		return vtkCGNSReader_GetNumberOfBaseArrays_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetNumberOfCellArrays_48(HandleRef pThis);

	/// <summary>
	/// API to get information of cell arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkCGNSReader_GetNumberOfCellArrays_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetNumberOfFaceArrays_49(HandleRef pThis);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public int GetNumberOfFaceArrays()
	{
		return vtkCGNSReader_GetNumberOfFaceArrays_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetNumberOfFamilyArrays_50(HandleRef pThis);

	/// <summary>
	/// API to select families to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
	/// </summary>
	public int GetNumberOfFamilyArrays()
	{
		return vtkCGNSReader_GetNumberOfFamilyArrays_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCGNSReader_GetNumberOfGenerationsFromBase_51(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCGNSReader_GetNumberOfGenerationsFromBase_51(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCGNSReader_GetNumberOfGenerationsFromBaseType_52(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCGNSReader_GetNumberOfGenerationsFromBaseType_52(type);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetNumberOfPointArrays_53(HandleRef pThis);

	/// <summary>
	/// API to get information of point arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkCGNSReader_GetNumberOfPointArrays_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_GetPointArrayName_54(HandleRef pThis, int index);

	/// <summary>
	/// API to get information of point arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkCGNSReader_GetPointArrayName_54(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_GetPointArrayStatus_55(HandleRef pThis, string name);

	/// <summary>
	/// API to get information of point arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkCGNSReader_GetPointArrayStatus_55(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSReader_GetUse3DVector_56(HandleRef pThis);

	/// <summary>
	/// Enable/disable adding an empty physical dimension to vectors in case of 2D solutions.
	/// </summary>
	public virtual bool GetUse3DVector()
	{
		return (vtkCGNSReader_GetUse3DVector_56(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSReader_GetUseUnsteadyPattern_57(HandleRef pThis);

	/// <summary>
	/// When set to true (default is false), the reader will try
	/// to determine to determine FlowSolution_t nodes to read with a pattern matching
	/// This can be useful for unsteady solutions when `FlowSolutionPointers` are not
	/// reliable
	/// </summary>
	public virtual bool GetUseUnsteadyPattern()
	{
		return (vtkCGNSReader_GetUseUnsteadyPattern_57(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_IgnoreFlowSolutionPointersOff_58(HandleRef pThis);

	/// <summary>
	/// When set to true (default is false), the reader will simply
	/// ignore `FlowSolutionPointers` since they are either incomplete or invalid
	/// and instead will rely on FlowSolution_t nodes being labelled as
	/// "...AtStep&lt;tsindex&gt;" to locate solution nodes for a specific timestep.
	/// Note, tsindex starts with 1 (not zero).
	///
	/// When set to false, the reader will still try to confirm that at least one
	/// valid FlowSolution_t node is referred to in FlowSolutionPointers nodes for the
	/// current timestep. If none is found, then the reader will print out a
	/// warning and act as if IgnoreFlowSolutionPointers was set to true. To avoid
	/// this warning, one should set IgnoreFlowSolutionPointers to true.
	/// </summary>
	public virtual void IgnoreFlowSolutionPointersOff()
	{
		vtkCGNSReader_IgnoreFlowSolutionPointersOff_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_IgnoreFlowSolutionPointersOn_59(HandleRef pThis);

	/// <summary>
	/// When set to true (default is false), the reader will simply
	/// ignore `FlowSolutionPointers` since they are either incomplete or invalid
	/// and instead will rely on FlowSolution_t nodes being labelled as
	/// "...AtStep&lt;tsindex&gt;" to locate solution nodes for a specific timestep.
	/// Note, tsindex starts with 1 (not zero).
	///
	/// When set to false, the reader will still try to confirm that at least one
	/// valid FlowSolution_t node is referred to in FlowSolutionPointers nodes for the
	/// current timestep. If none is found, then the reader will print out a
	/// warning and act as if IgnoreFlowSolutionPointers was set to true. To avoid
	/// this warning, one should set IgnoreFlowSolutionPointers to true.
	/// </summary>
	public virtual void IgnoreFlowSolutionPointersOn()
	{
		vtkCGNSReader_IgnoreFlowSolutionPointersOn_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_IsA_60(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCGNSReader_IsA_60(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSReader_IsTypeOf_61(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCGNSReader_IsTypeOf_61(type);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_LoadBndPatchOff_62(HandleRef pThis);

	/// <summary>
	/// Enable/disable loading of boundary condition patches.
	/// Defaults to false.
	/// </summary>
	public virtual void LoadBndPatchOff()
	{
		vtkCGNSReader_LoadBndPatchOff_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_LoadBndPatchOn_63(HandleRef pThis);

	/// <summary>
	/// Enable/disable loading of boundary condition patches.
	/// Defaults to false.
	/// </summary>
	public virtual void LoadBndPatchOn()
	{
		vtkCGNSReader_LoadBndPatchOn_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_LoadMeshOff_64(HandleRef pThis);

	/// <summary>
	/// Enable/disable loading of zone mesh. Defaults to true. It may be turned off
	/// to load only boundary patches (when LoadBndPatch if ON), for example.
	/// </summary>
	public virtual void LoadMeshOff()
	{
		vtkCGNSReader_LoadMeshOff_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_LoadMeshOn_65(HandleRef pThis);

	/// <summary>
	/// Enable/disable loading of zone mesh. Defaults to true. It may be turned off
	/// to load only boundary patches (when LoadBndPatch if ON), for example.
	/// </summary>
	public virtual void LoadMeshOn()
	{
		vtkCGNSReader_LoadMeshOn_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_NewInstance_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCGNSReader NewInstance()
	{
		vtkCGNSReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSReader_NewInstance_67(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCGNSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSReader_SafeDownCast_68(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCGNSReader SafeDownCast(vtkObjectBase o)
	{
		vtkCGNSReader vtkCGNSReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSReader_SafeDownCast_68(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCGNSReader2 = (vtkCGNSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCGNSReader2.Register(null);
			}
		}
		return vtkCGNSReader2;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetBaseArrayStatus_69(HandleRef pThis, string name, int status);

	/// <summary>
	/// API to select bases to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
	///
	/// By default, 0-th base is enabled and all others are disabled.
	/// </summary>
	public void SetBaseArrayStatus(string name, int status)
	{
		vtkCGNSReader_SetBaseArrayStatus_69(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetCacheConnectivity_70(HandleRef pThis, byte enable);

	/// <summary>
	/// This reader can cache the mesh connectivities if they are time invariant.
	/// They will be stored with a unique reference to their /base/zonename
	/// and not be read in the file when doing unsteady analysis.
	/// </summary>
	public void SetCacheConnectivity(bool enable)
	{
		vtkCGNSReader_SetCacheConnectivity_70(GetCppThis(), (byte)(enable ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetCacheMesh_71(HandleRef pThis, byte enable);

	/// <summary>
	/// This reader can cache the mesh points if they are time invariant.
	/// They will be stored with a unique reference to their /base/zonename
	/// and not be read in the file when doing unsteady analysis.
	/// </summary>
	public void SetCacheMesh(bool enable)
	{
		vtkCGNSReader_SetCacheMesh_71(GetCppThis(), (byte)(enable ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetCellArrayStatus_72(HandleRef pThis, string name, int status);

	/// <summary>
	/// API to get information of cell arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkCGNSReader_SetCellArrayStatus_72(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetController_73(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Set/get the communication object used to relay a list of files
	/// from the rank 0 process to all others. This is the only interprocess
	/// communication required by vtkPExodusIIReader.
	/// </summary>
	public void SetController(vtkMultiProcessController c)
	{
		vtkCGNSReader_SetController_73(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetCreateEachSolutionAsBlock_74(HandleRef pThis, int _arg);

	/// <summary>
	/// This option is provided for debugging and should not be used for production
	/// runs as the output data produced may not be correct. When set to true, the
	/// read will simply read each solution (`FlowSolution_t`) node encountered in
	/// a zone and create a separate block under the block corresponding to the
	/// zone in the output.
	/// </summary>
	public virtual void SetCreateEachSolutionAsBlock(int _arg)
	{
		vtkCGNSReader_SetCreateEachSolutionAsBlock_74(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetDataLocation_75(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the location of the data arrays to read. Possible values for the data location are:
	/// - CELL_DATA - Read CellCenter data arrays from the CGNS file. Construct 3D meshes with 3D cells
	/// (e.g. a cube is defined as 1 cell).
	/// - FACE_DATA - Read FaceCenter data arrays from the CGNS file. Construct 3D meshes with 2D
	/// cells/faces (e.g. a cube is defined as 6 quad cells). Element connectivity must be defined with
	/// element type NGON_n.
	///
	/// Default is CELL_DATA.
	/// </summary>
	public virtual void SetDataLocation(int _arg)
	{
		vtkCGNSReader_SetDataLocation_75(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetDistributeBlocks_76(HandleRef pThis, byte _arg);

	/// <summary>
	/// This reader can support piece requests by distributing each block in each
	/// zone across ranks (default). To make the reader disregard piece request and
	/// read all blocks in the zone, set this to false (default is true).
	/// </summary>
	public virtual void SetDistributeBlocks(bool _arg)
	{
		vtkCGNSReader_SetDistributeBlocks_76(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetDoublePrecisionMesh_77(HandleRef pThis, int _arg);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public virtual void SetDoublePrecisionMesh(int _arg)
	{
		vtkCGNSReader_SetDoublePrecisionMesh_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetFaceArrayStatus_78(HandleRef pThis, string name, int status);

	/// <summary>
	/// API to get information of face arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void SetFaceArrayStatus(string name, int status)
	{
		vtkCGNSReader_SetFaceArrayStatus_78(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetFamilyArrayStatus_79(HandleRef pThis, string name, int status);

	/// <summary>
	/// API to select families to read. These calls simply forward to the
	/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
	/// </summary>
	public void SetFamilyArrayStatus(string name, int status)
	{
		vtkCGNSReader_SetFamilyArrayStatus_79(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetFileName_80(HandleRef pThis, string arg);

	/// <summary>
	/// Specify file name of CGNS datafile to read
	/// </summary>
	public virtual void SetFileName(string arg)
	{
		vtkCGNSReader_SetFileName_80(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetIgnoreFlowSolutionPointers_81(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default is false), the reader will simply
	/// ignore `FlowSolutionPointers` since they are either incomplete or invalid
	/// and instead will rely on FlowSolution_t nodes being labelled as
	/// "...AtStep&lt;tsindex&gt;" to locate solution nodes for a specific timestep.
	/// Note, tsindex starts with 1 (not zero).
	///
	/// When set to false, the reader will still try to confirm that at least one
	/// valid FlowSolution_t node is referred to in FlowSolutionPointers nodes for the
	/// current timestep. If none is found, then the reader will print out a
	/// warning and act as if IgnoreFlowSolutionPointers was set to true. To avoid
	/// this warning, one should set IgnoreFlowSolutionPointers to true.
	/// </summary>
	public virtual void SetIgnoreFlowSolutionPointers(bool _arg)
	{
		vtkCGNSReader_SetIgnoreFlowSolutionPointers_81(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetLoadBndPatch_82(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable loading of boundary condition patches.
	/// Defaults to false.
	/// </summary>
	public virtual void SetLoadBndPatch(bool _arg)
	{
		vtkCGNSReader_SetLoadBndPatch_82(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetLoadMesh_83(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable loading of zone mesh. Defaults to true. It may be turned off
	/// to load only boundary patches (when LoadBndPatch if ON), for example.
	/// </summary>
	public virtual void SetLoadMesh(bool _arg)
	{
		vtkCGNSReader_SetLoadMesh_83(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetPointArrayStatus_84(HandleRef pThis, string name, int status);

	/// <summary>
	/// API to get information of point arrays and enable/disable loading of
	/// a particular arrays.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkCGNSReader_SetPointArrayStatus_84(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetUse3DVector_85(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable/disable adding an empty physical dimension to vectors in case of 2D solutions.
	/// </summary>
	public virtual void SetUse3DVector(bool _arg)
	{
		vtkCGNSReader_SetUse3DVector_85(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_SetUseUnsteadyPattern_86(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default is false), the reader will try
	/// to determine to determine FlowSolution_t nodes to read with a pattern matching
	/// This can be useful for unsteady solutions when `FlowSolutionPointers` are not
	/// reliable
	/// </summary>
	public virtual void SetUseUnsteadyPattern(bool _arg)
	{
		vtkCGNSReader_SetUseUnsteadyPattern_86(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_Use3DVectorOff_87(HandleRef pThis);

	/// <summary>
	/// Enable/disable adding an empty physical dimension to vectors in case of 2D solutions.
	/// </summary>
	public virtual void Use3DVectorOff()
	{
		vtkCGNSReader_Use3DVectorOff_87(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_Use3DVectorOn_88(HandleRef pThis);

	/// <summary>
	/// Enable/disable adding an empty physical dimension to vectors in case of 2D solutions.
	/// </summary>
	public virtual void Use3DVectorOn()
	{
		vtkCGNSReader_Use3DVectorOn_88(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_UseUnsteadyPatternOff_89(HandleRef pThis);

	/// <summary>
	/// When set to true (default is false), the reader will try
	/// to determine to determine FlowSolution_t nodes to read with a pattern matching
	/// This can be useful for unsteady solutions when `FlowSolutionPointers` are not
	/// reliable
	/// </summary>
	public virtual void UseUnsteadyPatternOff()
	{
		vtkCGNSReader_UseUnsteadyPatternOff_89(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSReader_UseUnsteadyPatternOn_90(HandleRef pThis);

	/// <summary>
	/// When set to true (default is false), the reader will try
	/// to determine to determine FlowSolution_t nodes to read with a pattern matching
	/// This can be useful for unsteady solutions when `FlowSolutionPointers` are not
	/// reliable
	/// </summary>
	public virtual void UseUnsteadyPatternOn()
	{
		vtkCGNSReader_UseUnsteadyPatternOn_90(GetCppThis());
	}
}
