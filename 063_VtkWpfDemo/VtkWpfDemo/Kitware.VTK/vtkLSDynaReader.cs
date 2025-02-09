using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLSDynaReader
/// </summary>
/// <remarks>
///    Read LS-Dyna databases (d3plot)
///
/// This filter reads LS-Dyna databases.
///
/// The Set/GetFileName() routines are actually wrappers around the
/// Set/GetDatabaseDirectory() members; the actual filename you choose is
/// irrelevant -- only the directory name is used.  This is done in order to
/// accommodate ParaView.
///
/// Note that this reader produces 7 output meshes.
/// These meshes are required as several attributes are defined on subsets
/// of the mesh.  Below is a list of meshes in the order they are output and
/// an explanation of which attributes are unique to each mesh:
/// - solid (3D) elements: number of integration points are different than 2D
/// - thick shell elements: number of integration points are different than
/// planar 2D
/// - shell (2D) elements: number of integration points are different than 3D
/// - rigid surfaces: can't have deflection, only velocity, accel, etc.
/// - road surfaces: have only a "segment ID" (serves as material ID) and a
/// velocity.
/// - beam elements: have Frenet (TNB) frame and cross-section attributes
/// (shape and size)
/// - spherical particle hydrodynamics (SPH) elements: have a radius of
/// influence, internal energy, etc.
/// Because each mesh has its own cell attributes, the vtkLSDynaReader has a
/// rather large API.  Instead of a single set of routines to query and set
/// cell array names and status, one exists for each possible output mesh.
/// Also, GetNumberOfCells() will return the sum of all the cells in all 7
/// meshes.  If you want the number of cells in a specific mesh, there are
/// separate routines for each mesh type.
///
///
/// @attention
/// LSDyna files contain 3 different types of sections: control, data, and
/// state.  Control sections contain constants that describe the type of
/// simulation data in a file or group of files.  Data sections contain
/// simulation information that is invariant across individual time steps
/// (but can vary when a mesh adaptation occurs).  This information includes
/// material, connectivity, and undeformed geometry.  Finally, state data is
/// information that varies with each time step.  Unless a mesh adaptation
/// occurs, there will be a single control and data section, and they will
/// be located at the start of the database (the first file).
///
/// @attention
/// In their infinite wisdom, LSDyna developers decided to split simulation
/// data into multiple files, each no larger than some predetermined limit.
/// Each file can contain one section, a partial section (if it would not
/// fit into a single file), or multiple sections. Files are padded with
/// zeros so that their lengths will be multiples of 512*512.  The size of
/// each section is determined by constants in the control and data
/// sections, which means that these must be parsed carefully in order to
/// correctly locate desired information.  Unfortunately, the constants are
/// not terribly well-documented and in some cases the documentation is in
/// error.
///
/// @par "Open Issues":
/// The LS-Dyna file format document leaves a good bit open to
/// interpretation.  In addition to the "documentation vs. files in the
/// wild" issues there are also implementation problems.
///
/// @par "Open Issues":
/// - Where exactly may breaks to a new file occur in the pre-state
/// information? At each section?
/// - Will state data sections (node/cell data, element deletion, sph data,
/// rigid body motion) be moved to the beginning of a new file if their data
/// will be too large for a given file, or are all the sections
/// counted together as a single state (makes more sense for keeping time
/// word at start of every file).
///  The questions above arise because the docs (p. 3) state "There are 3
/// sections in this database." but then call many smaller pieces of data
/// "sections". Should they be subsections? The docs are quiet about whether
/// the second section (of 3) is ever split across multiple files and, if
/// so, whether it is done at (sub)section boundaries when possible or just
/// wherever it needs to occur.
/// - How many components does Eddy Viscosity have? It's shown as 7 bits in
/// NCFDV1 which makes no sense at all.
/// - Why is NARBS larger than 10+NUMNP+NEL8+NEL2+NEL4+NELT (which is the
/// value specified by the documentation)?
/// Obviously, NARBS is definitive, but what are the extra numbers at the end?
/// - Is there a difference between rigid body elements NUMRBE and rigid road
/// surfaces? It appears that the nodes and connectivity of the road surface
/// are given separately (p.13) while on p.7 the Material
///   Type Data subsection says that shells in a rigid body will just have a
/// certain material ID but be interspersed among deformable shell elements.
/// - Word 37 of the control section serves two possible purposes... it can
/// mean NMSPH or EDLOPT.
///   I assume that different versions of the code use that word differently.
/// How do we know the difference?
/// - It's unclear how much state isn't stored when a shell element is marked
/// as rigid. Specifically, is element deletion data stored for rigid shells?
/// Page 21 of the spec is mute on this.
/// - The loop to read cell User IDs won't work if Rigid Body and Shell
/// elements are interleaved (which I now believe they are).
///
/// @par "Open Issues":
/// On the VTK side of things:
/// - Berk has nudged me towards multiblock outputs but hasn't committed to
/// exactly how things can be made efficient for a parallel version of the
/// reader.
/// - This reader will eventually need to respond to a second output port for
/// "small spatial, large temporal" queries.
/// - The reader doesn't handle crack files (d3crck)
/// - The reader doesn't handle interface force files (no default name)
/// - The reader doesn't handle time history (abbreviated output) files (d3thdt)
/// - The reader doesn't handle dynamic relaxation files (d3drfl)
/// - The reader doesn't handle reduced parts (state for a subset of parts) files (d3part)
/// - The reader doesn't handle mode shape files (d3eigv)
/// - The reader doesn't handle equilibrium iteration files (d3iter)
/// - The reader doesn't handle extra time data files (d3xtf)
/// - The reader doesn't handle printer files (d3hsp)
/// - The reader doesn't handle modal neutral files (d3mnf)
/// - The reader doesn't handle packed connectivity.
/// - The reader doesn't handle adapted element parent lists (but the 2002 specification says LSDyna
/// doesn't implement it).
/// - All the sample datasets have MATTYP = 0. Need something to test MATTYP = 1.
/// - I have no test datasets with rigid body and/or road surfaces, so the
/// implementation is half-baked.
/// - It's unclear how some of the data should be presented. Although blindly
/// tacking the numbers into a large chuck of cell data is better than nothing,
/// some attributes (e.g., forces &amp; moments) lend themselves to more elaborate
/// presentation. Also, shell and thick shell elements have stresses that
/// belong to a particular side of an element or have a finite thickness that
/// could be rendered.
///   Finally, beam elements have cross sections that could be rendered.
/// Some of these operations require numerical processing of the results and
/// so we shouldn't eliminate the ability to get at the raw simulation data.
/// Perhaps a filter could be applied to "fancify" the geometry.
///
/// </remarks>
public class vtkLSDynaReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLSDynaReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLSDynaReader()
	{
		MRClassNameKey = "class vtkLSDynaReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLSDynaReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLSDynaReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLSDynaReader New()
	{
		vtkLSDynaReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLSDynaReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLSDynaReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLSDynaReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_CanReadFile_01(HandleRef pThis, string fname);

	/// <summary>
	/// Determine if the file can be read with this reader.
	/// </summary>
	public virtual int CanReadFile(string fname)
	{
		return vtkLSDynaReader_CanReadFile_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_DebugDump_02(HandleRef pThis);

	/// <summary>
	/// A routine to call Dump() from within a lame debugger that won't
	/// properly pass a C++ iostream object like cout.
	/// </summary>
	public void DebugDump()
	{
		vtkLSDynaReader_DebugDump_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_DeformedMeshOff_03(HandleRef pThis);

	/// <summary>
	/// Should deflected coordinates be used, or should the mesh remain
	/// undeflected?  By default, this is true but its value is ignored if the
	/// nodal "Deflected Coordinates" array is not set to be loaded.
	/// </summary>
	public virtual void DeformedMeshOff()
	{
		vtkLSDynaReader_DeformedMeshOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_DeformedMeshOn_04(HandleRef pThis);

	/// <summary>
	/// Should deflected coordinates be used, or should the mesh remain
	/// undeflected?  By default, this is true but its value is ignored if the
	/// nodal "Deflected Coordinates" array is not set to be loaded.
	/// </summary>
	public virtual void DeformedMeshOn()
	{
		vtkLSDynaReader_DeformedMeshOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_DeletedCellsAsGhostArrayOff_05(HandleRef pThis);

	/// <summary>
	/// Instead of removing the cells that are dead, hide them by setting
	/// the array as the ghost levels arrays
	/// </summary>
	public virtual void DeletedCellsAsGhostArrayOff()
	{
		vtkLSDynaReader_DeletedCellsAsGhostArrayOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_DeletedCellsAsGhostArrayOn_06(HandleRef pThis);

	/// <summary>
	/// Instead of removing the cells that are dead, hide them by setting
	/// the array as the ghost levels arrays
	/// </summary>
	public virtual void DeletedCellsAsGhostArrayOn()
	{
		vtkLSDynaReader_DeletedCellsAsGhostArrayOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetBeamArrayName_07(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public string GetBeamArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetBeamArrayName_07(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetBeamArrayStatus_08(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetBeamArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetBeamArrayStatus_08(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetBeamArrayStatus_09(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetBeamArrayStatus(string arrName)
	{
		return vtkLSDynaReader_GetBeamArrayStatus_09(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetCellArrayName_10(HandleRef pThis, int cellType, int arr);

	/// <summary>
	/// Routines that allow the status of a cell variable to be adjusted or
	/// queried independent of the output mesh.  The \a cellType parameter
	/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
	/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
	/// </summary>
	public string GetCellArrayName(int cellType, int arr)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetCellArrayName_10(GetCppThis(), cellType, arr));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetCellArrayStatus_11(HandleRef pThis, int cellType, int arr);

	/// <summary>
	/// Routines that allow the status of a cell variable to be adjusted or
	/// queried independent of the output mesh.  The \a cellType parameter
	/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
	/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
	/// </summary>
	public int GetCellArrayStatus(int cellType, int arr)
	{
		return vtkLSDynaReader_GetCellArrayStatus_11(GetCppThis(), cellType, arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetCellArrayStatus_12(HandleRef pThis, int cellType, string arrName);

	/// <summary>
	/// Routines that allow the status of a cell variable to be adjusted or
	/// queried independent of the output mesh.  The \a cellType parameter
	/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
	/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
	/// </summary>
	public int GetCellArrayStatus(int cellType, string arrName)
	{
		return vtkLSDynaReader_GetCellArrayStatus_12(GetCppThis(), cellType, arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkLSDynaReader_GetDatabaseDirectory_13(HandleRef pThis);

	/// <summary>
	/// Get/Set the directory containing the LS-Dyna database and determine
	/// whether it is valid.
	/// </summary>
	public string GetDatabaseDirectory()
	{
		return vtkLSDynaReader_GetDatabaseDirectory_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetDeformedMesh_14(HandleRef pThis);

	/// <summary>
	/// Should deflected coordinates be used, or should the mesh remain
	/// undeflected?  By default, this is true but its value is ignored if the
	/// nodal "Deflected Coordinates" array is not set to be loaded.
	/// </summary>
	public virtual int GetDeformedMesh()
	{
		return vtkLSDynaReader_GetDeformedMesh_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetDeletedCellsAsGhostArray_15(HandleRef pThis);

	/// <summary>
	/// Instead of removing the cells that are dead, hide them by setting
	/// the array as the ghost levels arrays
	/// </summary>
	public virtual int GetDeletedCellsAsGhostArray()
	{
		return vtkLSDynaReader_GetDeletedCellsAsGhostArray_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetDimensionality_16(HandleRef pThis);

	/// <summary>
	/// Retrieve the dimension of points in the database. This should return 2
	/// or 3.  Do not call this function before setting the database directory
	/// and calling UpdateInformation().
	/// </summary>
	public int GetDimensionality()
	{
		return vtkLSDynaReader_GetDimensionality_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkLSDynaReader_GetFileName_17(HandleRef pThis);

	/// <summary>
	/// Get/Set the filename. The Set/GetFileName() routines are actually
	/// wrappers around the Set/GetDatabaseDirectory() members; the actual
	/// filename you choose is irrelevant -- only the directory name is used.
	/// This is done in order to accommodate ParaView.
	/// </summary>
	public string GetFileName()
	{
		return vtkLSDynaReader_GetFileName_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetInputDeck_18(HandleRef pThis);

	/// <summary>
	/// The name of the input deck corresponding to the current database.
	/// This is used to determine the part names associated with each material ID.
	/// This file may be in two formats: a valid LSDyna input deck or a
	/// short XML summary.
	/// If the file begins with "&lt;?xml" then the summary format is used.
	/// Otherwise, the keyword format is used and a summary file will be
	/// created if write permissions exist in the directory containing
	/// the keyword file. The newly created summary will have ".k" or ".key"
	/// stripped from the end of the keyword filename and ".lsdyna" appended.
	/// </summary>
	public virtual string GetInputDeck()
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetInputDeck_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfBeamArrays_19(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfBeamArrays()
	{
		return vtkLSDynaReader_GetNumberOfBeamArrays_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfBeamCells_20(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.
	/// Do not call this function before setting the database directory and calling
	/// UpdateInformation().
	/// </summary>
	public long GetNumberOfBeamCells()
	{
		return vtkLSDynaReader_GetNumberOfBeamCells_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfCellArrays_21(HandleRef pThis, int cellType);

	/// <summary>
	/// Routines that allow the status of a cell variable to be adjusted or
	/// queried independent of the output mesh.  The \a cellType parameter
	/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
	/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
	/// </summary>
	public int GetNumberOfCellArrays(int cellType)
	{
		return vtkLSDynaReader_GetNumberOfCellArrays_21(GetCppThis(), cellType);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfCells_22(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.  Do not
	/// call this function before setting the database directory and calling
	/// UpdateInformation().
	///
	/// Note that GetNumberOfCells() returns the sum of
	/// GetNumberOfContinuumCells() and GetNumberOfParticleCells().
	/// </summary>
	public long GetNumberOfCells()
	{
		return vtkLSDynaReader_GetNumberOfCells_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInBeamArray_23(HandleRef pThis, int a);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInBeamArray(int a)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInBeamArray_23(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInBeamArray_24(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInBeamArray(string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInBeamArray_24(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInCellArray_25(HandleRef pThis, int cellType, int arr);

	/// <summary>
	/// Routines that allow the status of a cell variable to be adjusted or
	/// queried independent of the output mesh.  The \a cellType parameter
	/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
	/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
	/// </summary>
	public int GetNumberOfComponentsInCellArray(int cellType, int arr)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInCellArray_25(GetCppThis(), cellType, arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInCellArray_26(HandleRef pThis, int cellType, string arrName);

	/// <summary>
	/// Routines that allow the status of a cell variable to be adjusted or
	/// queried independent of the output mesh.  The \a cellType parameter
	/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
	/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
	/// </summary>
	public int GetNumberOfComponentsInCellArray(int cellType, string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInCellArray_26(GetCppThis(), cellType, arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInParticleArray_27(HandleRef pThis, int a);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInParticleArray(int a)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInParticleArray_27(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInParticleArray_28(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInParticleArray(string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInParticleArray_28(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInPointArray_29(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the nodal
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInPointArray(int arr)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInPointArray_29(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInPointArray_30(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the nodal
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInPointArray(string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInPointArray_30(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_31(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInRigidBodyArray(string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_31(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_32(HandleRef pThis, int a);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInRigidBodyArray(int a)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_32(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_33(HandleRef pThis, int a);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInRoadSurfaceArray(int a)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_33(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_34(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInRoadSurfaceArray(string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_34(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInShellArray_35(HandleRef pThis, int a);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInShellArray(int a)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInShellArray_35(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInShellArray_36(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInShellArray(string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInShellArray_36(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInSolidArray_37(HandleRef pThis, int a);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInSolidArray(int a)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInSolidArray_37(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInSolidArray_38(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInSolidArray(string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInSolidArray_38(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_39(HandleRef pThis, int a);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInThickShellArray(int a)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_39(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_40(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfComponentsInThickShellArray(string arrName)
	{
		return vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_40(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfContinuumCells_41(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.  Do not
	/// call this function before setting the database directory and calling
	/// UpdateInformation().
	///
	/// Note that GetNumberOfContinuumCells() returns the sum of
	/// GetNumberOfSolidCells(), GetNumberOfThickShellCells(),
	/// GetNumberOfShellCells(), GetNumberOfRigidBodyCells(),
	/// GetNumberOfRoadSurfaceCells(), and GetNumberOfBeamCells().
	/// </summary>
	public long GetNumberOfContinuumCells()
	{
		return vtkLSDynaReader_GetNumberOfContinuumCells_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfGenerationsFromBase_42(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLSDynaReader_GetNumberOfGenerationsFromBase_42(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfGenerationsFromBaseType_43(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLSDynaReader_GetNumberOfGenerationsFromBaseType_43(type);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfNodes_44(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of points in the database.  Do not call this
	/// function before setting the database directory and calling
	/// UpdateInformation().
	/// </summary>
	public long GetNumberOfNodes()
	{
		return vtkLSDynaReader_GetNumberOfNodes_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfPartArrays_45(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected parts of the input.
	/// If InputDeck points to a valid keyword file (or summary), then part
	/// names will be taken from that file.
	/// Otherwise, when arbitrary material numbering is used, parts will be named
	/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
	/// is the respective material ID. If no input deck is specified and arbitrary
	/// arbitrary material numbering is not used, parts will be named
	/// "PartXXX" where XXX is a sequential material ID.
	/// </summary>
	public int GetNumberOfPartArrays()
	{
		return vtkLSDynaReader_GetNumberOfPartArrays_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfParticleArrays_46(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfParticleArrays()
	{
		return vtkLSDynaReader_GetNumberOfParticleArrays_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfParticleCells_47(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.  Do not
	/// call this function before setting the database directory and calling
	/// UpdateInformation().
	/// </summary>
	public long GetNumberOfParticleCells()
	{
		return vtkLSDynaReader_GetNumberOfParticleCells_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfPointArrays_48(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected subsets of the nodal
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkLSDynaReader_GetNumberOfPointArrays_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfRigidBodyArrays_49(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfRigidBodyArrays()
	{
		return vtkLSDynaReader_GetNumberOfRigidBodyArrays_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfRigidBodyCells_50(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.  Do not
	/// call this function before setting the database directory and calling
	/// UpdateInformation().
	/// </summary>
	public long GetNumberOfRigidBodyCells()
	{
		return vtkLSDynaReader_GetNumberOfRigidBodyCells_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfRoadSurfaceArrays_51(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfRoadSurfaceArrays()
	{
		return vtkLSDynaReader_GetNumberOfRoadSurfaceArrays_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfRoadSurfaceCells_52(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.  Do not
	/// call this function before setting the database directory and calling
	/// UpdateInformation().
	/// </summary>
	public long GetNumberOfRoadSurfaceCells()
	{
		return vtkLSDynaReader_GetNumberOfRoadSurfaceCells_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfShellArrays_53(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfShellArrays()
	{
		return vtkLSDynaReader_GetNumberOfShellArrays_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfShellCells_54(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.  Do not
	/// call this function before setting the database directory and calling
	/// UpdateInformation().
	/// </summary>
	public long GetNumberOfShellCells()
	{
		return vtkLSDynaReader_GetNumberOfShellCells_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfSolidArrays_55(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfSolidArrays()
	{
		return vtkLSDynaReader_GetNumberOfSolidArrays_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfSolidCells_56(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.  Do not
	/// call this function before setting the database directory and calling
	/// UpdateInformation().
	/// </summary>
	public long GetNumberOfSolidCells()
	{
		return vtkLSDynaReader_GetNumberOfSolidCells_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetNumberOfThickShellArrays_57(HandleRef pThis);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetNumberOfThickShellArrays()
	{
		return vtkLSDynaReader_GetNumberOfThickShellArrays_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfThickShellCells_58(HandleRef pThis);

	/// <summary>
	/// Retrieve the number of cells of a given type in the database.  Do not
	/// call this function before setting the database directory and calling
	/// UpdateInformation().
	/// </summary>
	public long GetNumberOfThickShellCells()
	{
		return vtkLSDynaReader_GetNumberOfThickShellCells_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetNumberOfTimeSteps_59(HandleRef pThis);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public long GetNumberOfTimeSteps()
	{
		return vtkLSDynaReader_GetNumberOfTimeSteps_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetPartArrayName_60(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected parts of the input.
	/// If InputDeck points to a valid keyword file (or summary), then part
	/// names will be taken from that file.
	/// Otherwise, when arbitrary material numbering is used, parts will be named
	/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
	/// is the respective material ID. If no input deck is specified and arbitrary
	/// arbitrary material numbering is not used, parts will be named
	/// "PartXXX" where XXX is a sequential material ID.
	/// </summary>
	public string GetPartArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetPartArrayName_60(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetPartArrayStatus_61(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected parts of the input.
	/// If InputDeck points to a valid keyword file (or summary), then part
	/// names will be taken from that file.
	/// Otherwise, when arbitrary material numbering is used, parts will be named
	/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
	/// is the respective material ID. If no input deck is specified and arbitrary
	/// arbitrary material numbering is not used, parts will be named
	/// "PartXXX" where XXX is a sequential material ID.
	/// </summary>
	public int GetPartArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetPartArrayStatus_61(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetPartArrayStatus_62(HandleRef pThis, string partName);

	/// <summary>
	/// These methods allow you to load only selected parts of the input.
	/// If InputDeck points to a valid keyword file (or summary), then part
	/// names will be taken from that file.
	/// Otherwise, when arbitrary material numbering is used, parts will be named
	/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
	/// is the respective material ID. If no input deck is specified and arbitrary
	/// arbitrary material numbering is not used, parts will be named
	/// "PartXXX" where XXX is a sequential material ID.
	/// </summary>
	public int GetPartArrayStatus(string partName)
	{
		return vtkLSDynaReader_GetPartArrayStatus_62(GetCppThis(), partName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetParticleArrayName_63(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public string GetParticleArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetParticleArrayName_63(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetParticleArrayStatus_64(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetParticleArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetParticleArrayStatus_64(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetParticleArrayStatus_65(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetParticleArrayStatus(string arrName)
	{
		return vtkLSDynaReader_GetParticleArrayStatus_65(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetPointArrayName_66(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected subsets of the nodal
	/// variables defined over the mesh.
	/// </summary>
	public string GetPointArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetPointArrayName_66(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetPointArrayStatus_67(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the nodal
	/// variables defined over the mesh.
	/// </summary>
	public int GetPointArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetPointArrayStatus_67(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetPointArrayStatus_68(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the nodal
	/// variables defined over the mesh.
	/// </summary>
	public int GetPointArrayStatus(string arrName)
	{
		return vtkLSDynaReader_GetPointArrayStatus_68(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetRemoveDeletedCells_69(HandleRef pThis);

	/// <summary>
	/// Should dead cells be removed from the mesh?  Cells are marked dead by
	/// setting the corresponding entry in the &lt;b&gt;cell&lt;/b&gt; array "Death" to 0.
	/// Cells that are not dead have the corresponding entry in the cell array
	/// "Death" set to their material ID.  By default, this is true but its
	/// value is ignored if the cell "Death" array is not set to be loaded.
	/// It is also ignored if the database's element deletion option is set to
	/// denote &lt;b&gt;points&lt;/b&gt; (not cells) as deleted; in that case, "Death"
	/// will appear to be a point array.
	/// </summary>
	public virtual int GetRemoveDeletedCells()
	{
		return vtkLSDynaReader_GetRemoveDeletedCells_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetRigidBodyArrayName_70(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public string GetRigidBodyArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetRigidBodyArrayName_70(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetRigidBodyArrayStatus_71(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetRigidBodyArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetRigidBodyArrayStatus_71(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetRigidBodyArrayStatus_72(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetRigidBodyArrayStatus(string arrName)
	{
		return vtkLSDynaReader_GetRigidBodyArrayStatus_72(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetRoadSurfaceArrayName_73(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public string GetRoadSurfaceArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetRoadSurfaceArrayName_73(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetRoadSurfaceArrayStatus_74(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetRoadSurfaceArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetRoadSurfaceArrayStatus_74(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetRoadSurfaceArrayStatus_75(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetRoadSurfaceArrayStatus(string arrName)
	{
		return vtkLSDynaReader_GetRoadSurfaceArrayStatus_75(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetShellArrayName_76(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public string GetShellArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetShellArrayName_76(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetShellArrayStatus_77(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetShellArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetShellArrayStatus_77(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetShellArrayStatus_78(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetShellArrayStatus(string arrName)
	{
		return vtkLSDynaReader_GetShellArrayStatus_78(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetSolidArrayName_79(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public string GetSolidArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetSolidArrayName_79(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetSolidArrayStatus_80(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetSolidArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetSolidArrayStatus_80(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetSolidArrayStatus_81(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetSolidArrayStatus(string arrName)
	{
		return vtkLSDynaReader_GetSolidArrayStatus_81(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetThickShellArrayName_82(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public string GetThickShellArrayName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetThickShellArrayName_82(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetThickShellArrayStatus_83(HandleRef pThis, int arr);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetThickShellArrayStatus(int arr)
	{
		return vtkLSDynaReader_GetThickShellArrayStatus_83(GetCppThis(), arr);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_GetThickShellArrayStatus_84(HandleRef pThis, string arrName);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public int GetThickShellArrayStatus(string arrName)
	{
		return vtkLSDynaReader_GetThickShellArrayStatus_84(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLSDynaReader_GetTimeStep_85(HandleRef pThis);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public long GetTimeStep()
	{
		return vtkLSDynaReader_GetTimeStep_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetTimeStepRange_86(HandleRef pThis);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public virtual int[] GetTimeStepRange()
	{
		IntPtr intPtr = vtkLSDynaReader_GetTimeStepRange_86(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_GetTimeStepRange_87(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
	{
		vtkLSDynaReader_GetTimeStepRange_87(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_GetTimeStepRange_88(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public virtual void GetTimeStepRange(IntPtr _arg)
	{
		vtkLSDynaReader_GetTimeStepRange_88(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLSDynaReader_GetTimeValue_89(HandleRef pThis, long arg0);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public double GetTimeValue(long arg0)
	{
		return vtkLSDynaReader_GetTimeValue_89(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_GetTitle_90(HandleRef pThis);

	/// <summary>
	/// The title of the database is a 40 or 80 character text description
	/// stored at the front of a d3plot file.  Do not call this function
	/// before setting the database directory and calling UpdateInformation().
	/// </summary>
	public string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkLSDynaReader_GetTitle_90(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_IsA_91(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLSDynaReader_IsA_91(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_IsDatabaseValid_92(HandleRef pThis);

	/// <summary>
	/// Get/Set the directory containing the LS-Dyna database and determine
	/// whether it is valid.
	/// </summary>
	public int IsDatabaseValid()
	{
		return vtkLSDynaReader_IsDatabaseValid_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLSDynaReader_IsTypeOf_93(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLSDynaReader_IsTypeOf_93(type);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_NewInstance_95(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLSDynaReader NewInstance()
	{
		vtkLSDynaReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLSDynaReader_NewInstance_95(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_RemoveDeletedCellsOff_96(HandleRef pThis);

	/// <summary>
	/// Should dead cells be removed from the mesh?  Cells are marked dead by
	/// setting the corresponding entry in the &lt;b&gt;cell&lt;/b&gt; array "Death" to 0.
	/// Cells that are not dead have the corresponding entry in the cell array
	/// "Death" set to their material ID.  By default, this is true but its
	/// value is ignored if the cell "Death" array is not set to be loaded.
	/// It is also ignored if the database's element deletion option is set to
	/// denote &lt;b&gt;points&lt;/b&gt; (not cells) as deleted; in that case, "Death"
	/// will appear to be a point array.
	/// </summary>
	public virtual void RemoveDeletedCellsOff()
	{
		vtkLSDynaReader_RemoveDeletedCellsOff_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_RemoveDeletedCellsOn_97(HandleRef pThis);

	/// <summary>
	/// Should dead cells be removed from the mesh?  Cells are marked dead by
	/// setting the corresponding entry in the &lt;b&gt;cell&lt;/b&gt; array "Death" to 0.
	/// Cells that are not dead have the corresponding entry in the cell array
	/// "Death" set to their material ID.  By default, this is true but its
	/// value is ignored if the cell "Death" array is not set to be loaded.
	/// It is also ignored if the database's element deletion option is set to
	/// denote &lt;b&gt;points&lt;/b&gt; (not cells) as deleted; in that case, "Death"
	/// will appear to be a point array.
	/// </summary>
	public virtual void RemoveDeletedCellsOn()
	{
		vtkLSDynaReader_RemoveDeletedCellsOn_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLSDynaReader_SafeDownCast_98(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLSDynaReader SafeDownCast(vtkObjectBase o)
	{
		vtkLSDynaReader vtkLSDynaReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLSDynaReader_SafeDownCast_98(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLSDynaReader2 = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLSDynaReader2.Register(null);
			}
		}
		return vtkLSDynaReader2;
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetBeamArrayStatus_99(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetBeamArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetBeamArrayStatus_99(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetBeamArrayStatus_100(HandleRef pThis, string arrName, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetBeamArrayStatus(string arrName, int status)
	{
		vtkLSDynaReader_SetBeamArrayStatus_100(GetCppThis(), arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetCellArrayStatus_101(HandleRef pThis, int cellType, int arr, int status);

	/// <summary>
	/// Routines that allow the status of a cell variable to be adjusted or
	/// queried independent of the output mesh.  The \a cellType parameter
	/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
	/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
	/// </summary>
	public virtual void SetCellArrayStatus(int cellType, int arr, int status)
	{
		vtkLSDynaReader_SetCellArrayStatus_101(GetCppThis(), cellType, arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetCellArrayStatus_102(HandleRef pThis, int cellType, string arrName, int status);

	/// <summary>
	/// Routines that allow the status of a cell variable to be adjusted or
	/// queried independent of the output mesh.  The \a cellType parameter
	/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
	/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
	/// </summary>
	public virtual void SetCellArrayStatus(int cellType, string arrName, int status)
	{
		vtkLSDynaReader_SetCellArrayStatus_102(GetCppThis(), cellType, arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetDatabaseDirectory_103(HandleRef pThis, string arg0);

	/// <summary>
	/// Get/Set the directory containing the LS-Dyna database and determine
	/// whether it is valid.
	/// </summary>
	public virtual void SetDatabaseDirectory(string arg0)
	{
		vtkLSDynaReader_SetDatabaseDirectory_103(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetDeformedMesh_104(HandleRef pThis, int arg0);

	/// <summary>
	/// Should deflected coordinates be used, or should the mesh remain
	/// undeflected?  By default, this is true but its value is ignored if the
	/// nodal "Deflected Coordinates" array is not set to be loaded.
	/// </summary>
	public void SetDeformedMesh(int arg0)
	{
		vtkLSDynaReader_SetDeformedMesh_104(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetDeletedCellsAsGhostArray_105(HandleRef pThis, int _arg);

	/// <summary>
	/// Instead of removing the cells that are dead, hide them by setting
	/// the array as the ghost levels arrays
	/// </summary>
	public virtual void SetDeletedCellsAsGhostArray(int _arg)
	{
		vtkLSDynaReader_SetDeletedCellsAsGhostArray_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetFileName_106(HandleRef pThis, string arg0);

	/// <summary>
	/// Get/Set the filename. The Set/GetFileName() routines are actually
	/// wrappers around the Set/GetDatabaseDirectory() members; the actual
	/// filename you choose is irrelevant -- only the directory name is used.
	/// This is done in order to accommodate ParaView.
	/// </summary>
	public virtual void SetFileName(string arg0)
	{
		vtkLSDynaReader_SetFileName_106(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetInputDeck_107(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the input deck corresponding to the current database.
	/// This is used to determine the part names associated with each material ID.
	/// This file may be in two formats: a valid LSDyna input deck or a
	/// short XML summary.
	/// If the file begins with "&lt;?xml" then the summary format is used.
	/// Otherwise, the keyword format is used and a summary file will be
	/// created if write permissions exist in the directory containing
	/// the keyword file. The newly created summary will have ".k" or ".key"
	/// stripped from the end of the keyword filename and ".lsdyna" appended.
	/// </summary>
	public virtual void SetInputDeck(string _arg)
	{
		vtkLSDynaReader_SetInputDeck_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetPartArrayStatus_108(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected parts of the input.
	/// If InputDeck points to a valid keyword file (or summary), then part
	/// names will be taken from that file.
	/// Otherwise, when arbitrary material numbering is used, parts will be named
	/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
	/// is the respective material ID. If no input deck is specified and arbitrary
	/// arbitrary material numbering is not used, parts will be named
	/// "PartXXX" where XXX is a sequential material ID.
	/// </summary>
	public virtual void SetPartArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetPartArrayStatus_108(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetPartArrayStatus_109(HandleRef pThis, string partName, int status);

	/// <summary>
	/// These methods allow you to load only selected parts of the input.
	/// If InputDeck points to a valid keyword file (or summary), then part
	/// names will be taken from that file.
	/// Otherwise, when arbitrary material numbering is used, parts will be named
	/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
	/// is the respective material ID. If no input deck is specified and arbitrary
	/// arbitrary material numbering is not used, parts will be named
	/// "PartXXX" where XXX is a sequential material ID.
	/// </summary>
	public virtual void SetPartArrayStatus(string partName, int status)
	{
		vtkLSDynaReader_SetPartArrayStatus_109(GetCppThis(), partName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetParticleArrayStatus_110(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetParticleArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetParticleArrayStatus_110(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetParticleArrayStatus_111(HandleRef pThis, string arrName, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetParticleArrayStatus(string arrName, int status)
	{
		vtkLSDynaReader_SetParticleArrayStatus_111(GetCppThis(), arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetPointArrayStatus_112(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the nodal
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetPointArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetPointArrayStatus_112(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetPointArrayStatus_113(HandleRef pThis, string arrName, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the nodal
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetPointArrayStatus(string arrName, int status)
	{
		vtkLSDynaReader_SetPointArrayStatus_113(GetCppThis(), arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetRemoveDeletedCells_114(HandleRef pThis, int _arg);

	/// <summary>
	/// Should dead cells be removed from the mesh?  Cells are marked dead by
	/// setting the corresponding entry in the &lt;b&gt;cell&lt;/b&gt; array "Death" to 0.
	/// Cells that are not dead have the corresponding entry in the cell array
	/// "Death" set to their material ID.  By default, this is true but its
	/// value is ignored if the cell "Death" array is not set to be loaded.
	/// It is also ignored if the database's element deletion option is set to
	/// denote &lt;b&gt;points&lt;/b&gt; (not cells) as deleted; in that case, "Death"
	/// will appear to be a point array.
	/// </summary>
	public virtual void SetRemoveDeletedCells(int _arg)
	{
		vtkLSDynaReader_SetRemoveDeletedCells_114(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetRigidBodyArrayStatus_115(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetRigidBodyArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetRigidBodyArrayStatus_115(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetRigidBodyArrayStatus_116(HandleRef pThis, string arrName, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetRigidBodyArrayStatus(string arrName, int status)
	{
		vtkLSDynaReader_SetRigidBodyArrayStatus_116(GetCppThis(), arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetRoadSurfaceArrayStatus_117(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetRoadSurfaceArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetRoadSurfaceArrayStatus_117(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetRoadSurfaceArrayStatus_118(HandleRef pThis, string arrName, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetRoadSurfaceArrayStatus(string arrName, int status)
	{
		vtkLSDynaReader_SetRoadSurfaceArrayStatus_118(GetCppThis(), arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetShellArrayStatus_119(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetShellArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetShellArrayStatus_119(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetShellArrayStatus_120(HandleRef pThis, string arrName, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetShellArrayStatus(string arrName, int status)
	{
		vtkLSDynaReader_SetShellArrayStatus_120(GetCppThis(), arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetSolidArrayStatus_121(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetSolidArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetSolidArrayStatus_121(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetSolidArrayStatus_122(HandleRef pThis, string arrName, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetSolidArrayStatus(string arrName, int status)
	{
		vtkLSDynaReader_SetSolidArrayStatus_122(GetCppThis(), arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetThickShellArrayStatus_123(HandleRef pThis, int arr, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetThickShellArrayStatus(int arr, int status)
	{
		vtkLSDynaReader_SetThickShellArrayStatus_123(GetCppThis(), arr, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetThickShellArrayStatus_124(HandleRef pThis, string arrName, int status);

	/// <summary>
	/// These methods allow you to load only selected subsets of the cell
	/// variables defined over the mesh.
	/// </summary>
	public virtual void SetThickShellArrayStatus(string arrName, int status)
	{
		vtkLSDynaReader_SetThickShellArrayStatus_124(GetCppThis(), arrName, status);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetTimeStep_125(HandleRef pThis, long arg0);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public virtual void SetTimeStep(long arg0)
	{
		vtkLSDynaReader_SetTimeStep_125(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetTimeStepRange_126(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public virtual void SetTimeStepRange(int _arg1, int _arg2)
	{
		vtkLSDynaReader_SetTimeStepRange_126(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLSDynaReader_SetTimeStepRange_127(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Retrieve information about the time extents of the LS-Dyna database.
	/// Do not call these functions before setting the database directory and
	/// calling UpdateInformation().
	/// </summary>
	public void SetTimeStepRange(IntPtr _arg)
	{
		vtkLSDynaReader_SetTimeStepRange_127(GetCppThis(), _arg);
	}
}
