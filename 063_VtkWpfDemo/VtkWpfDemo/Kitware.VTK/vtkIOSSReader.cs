using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkIOSSReader
/// </summary>
/// <remarks>
///  Reader for IOSS (Sierra IO System)
///
/// vtkIOSSReader is reader that uses the IOSS (Sierra IO System) library to
/// read files. Currently, this reader support Exodus and CGNS file formats. IOSS
/// imposes certain restrictions on these file formats and hence it may not be
/// possible to open every Exodus or CGNS file using this reader. This is
/// true especially for CGNS, more so than Exodus. In that case `vtkCGNSReader`
/// may be more appropriate.
///
/// @section SpecifyingFiles Specifying Files
///
/// One can select a single file to read using `vtkIOSSReader::SetFileName`.
/// With IOSS, however, it is not uncommon to have a collection of files named
/// using standard patterns (described in Section @ref IossNamingConventions).
/// To support this use-case, the reader automatically scans for additionally
/// files internally. To disable this behaviour, call
/// `vtkIOSSReader::ScanForRelatedFilesOff`.
///
/// Alternatively, the list of files to be read can be explicitly specified using
/// `vtkIOSSReader::AddFileName`. Then too, if `ScanForRelatedFiles` is `true`,
/// the reader will search for related files for each of the files specified.
///
/// Additionally, `FileRange` and `FileStride` may be used to limit to reading a
/// subset of files.
///
/// @section SelectingBlocksSets Selecting blocks and sets to read
///
/// An IOSS file comprises of blocks and sets of various types. These are
/// described by the enum `vtkIOSSReader::EntityType`.
///
/// `vtkIOSSReader::GetEntitySelection` returns a `vtkDataArraySelection`
/// instance for each of the entity types. This `vtkDataArraySelection` can be
/// used to query the names for available blocks or sets and also select which
/// ones to read.
///
/// Typical usage is as follows:
///
/// @code{.cpp}
///
/// vtkNew&lt;vtkIOSSReader&gt; reader;
/// reader-&gt;SetFileName(...);
/// reader-&gt;UpdateInformation();
/// reader-&gt;GetElementBlockSelection()-&gt;EnableArray("Block0");
/// reader-&gt;GetEntitySelection(vtkIOSSReader::SIDESET)-&gt;DisableAllArrays();
/// @endcode
///
/// By default, all blocks are enabled, while all sets are disabled.
///
/// In additional to selecting blocks and sets by name, if the file defines assemblies
/// that organize these blocks and sets, then one can use selector expressions
/// to enable blocks/sets as defined in the assemblies.
///
/// A block (or set) is treated as enabled if it is either explicitly enabled using the
/// block selection or implicitly enabled due to a selector specified on over the assemblies.
///
/// Typical usage to select blocks by assembly alone is as follows:
///
/// @code{.cpp}
/// vtkNew&lt;vtkIOSSReader&gt; reader;
/// reader-&gt;SetFileName(...);
/// reader-&gt;UpdateInformation();
/// reader-&gt;GetElementBlockSelection()-&gt;DisableAllArrays();
/// ...
/// reader-&gt;AddSelector("//Low");
/// reader-&gt;AddSelector("//High");
/// @endcode
///
/// @section SelectingArrays Selecting arrays to read
///
/// Similar to the block and set selection, arrays (or fields as IOSS refers to
/// them) to read from each of the blocks or sets can be specified using the
/// `vtkDataArraySelection` instance returned using
/// `vtkIOSSReader::GetFieldSelection` (or one of its convenience variants).
///
/// By default all arrays are enabled.
///
/// @section IossNamingConventions IOSS Naming Conventions
///
/// An IOSS complete dataset is referred to as a database. There can be multiple
/// multiple timesteps in a single database. A single database may
/// split among multiple files. When a database is split among multiple files,
/// this is strictly spatial partitioning with each file storing part of the data
/// for a specific partition. In this case, the files are named with suffix
/// `.{NP}.{RANK}` where `{NP}` is the total number of partitions  and `{RANK}`
/// is the partition number. For example, if database named `can.e` is split among four
/// files representing 4 partitions, it will be named as follows:
///
/// @verbatim
///  can.e.4.0
///  can.e.4.1
///  can.e.4.2
///  can.e.4.3
/// @endverbatim
///
/// In this example, the database name is `can.e` while the `.4.[0-4]` suffix
/// provides the partition information.
///
/// Note, the database need not be split into multiple files. Thus, a writer may
/// generate a single `can.e` file that has all the timesteps and partitions and
/// still provide all information available when the database is split among
/// multiple files.
///
/// Multiple databases (with each stored in a single file or spatially split among files)
/// can form a temporal sequence. This done by using another file naming
/// convention. If the database name is followed by `-s.{RS}`, where `{RS}` is
/// some number sequence), then the databases are treated as a temporal sequence
/// with `{RS}` (called restart numbers) representing the temporal sequence
/// order.
///
/// The follow represents a temporal sequence:
///
/// @verbatim
///  mysimoutput.e-s.000
///  mysimoutput.e-s.001
///  mysimoutput.e-s.002
/// @endverbatim
///
/// You can use any number of digits for the restart number, but by convention
/// the number used should be the same for all files. Also by convention, you can
/// leave off the `-s.{RS}` suffix for the first file. The following
/// sequence is internally the same as that above:
///
/// @verbatim
///  mysimoutput.e-s
///  mysimoutput.e-s.001
///  mysimoutput.e-s.002
/// @endverbatim
///
/// When a database in the temporal sequence is spatially split in multiple
/// files, the corresponding filename is suffixed by the partition information.
/// For example:
///
/// @verbatim
///  mysimoutput.e-s.2.0
///  mysimoutput.e-s.2.1
///  mysimoutput.e-s.001.2.0
///  mysimoutput.e-s.001.2.1
///  mysimoutput.e-s.002.2.0
///  mysimoutput.e-s.002.2.1
/// @endverbatim
///
/// In this case, the filenames take the form `{DBNAME}-s.{RS}.{NP}.{RANK}`,
/// where `{DBNAME}` is the database name, `{RS}` is the restart number,
/// `{NP}` is the number of spatial partitions and `{RANK}` is the spatial partition number.
///
/// @section References References
/// * [Sierra IO System](http://gsjaardema.github.io/seacas/)
/// </remarks>
public class vtkIOSSReader : vtkReaderAlgorithm
{
	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public enum EntityType
	{
		/// <summary>enum member</summary>
		BLOCK_END = 5,
		/// <summary>enum member</summary>
		BLOCK_START = 0,
		/// <summary>enum member</summary>
		EDGEBLOCK = 1,
		/// <summary>enum member</summary>
		EDGESET = 6,
		/// <summary>enum member</summary>
		ELEMENTBLOCK = 3,
		/// <summary>enum member</summary>
		ELEMENTSET = 8,
		/// <summary>enum member</summary>
		ENTITY_END = 10,
		/// <summary>enum member</summary>
		ENTITY_START = 0,
		/// <summary>enum member</summary>
		FACEBLOCK = 2,
		/// <summary>enum member</summary>
		FACESET = 7,
		/// <summary>enum member</summary>
		NODEBLOCK = 0,
		/// <summary>enum member</summary>
		NODESET = 5,
		/// <summary>enum member</summary>
		NUMBER_OF_ENTITY_TYPES = 10,
		/// <summary>enum member</summary>
		SET_END = 10,
		/// <summary>enum member</summary>
		SET_START = 5,
		/// <summary>enum member</summary>
		SIDESET = 9,
		/// <summary>enum member</summary>
		STRUCTUREDBLOCK = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIOSSReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIOSSReader()
	{
		MRClassNameKey = "class vtkIOSSReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIOSSReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIOSSReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIOSSReader New()
	{
		vtkIOSSReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIOSSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIOSSReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIOSSReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_AddFileName_01(HandleRef pThis, string fname);

	/// <summary>
	/// API to set the filenames.
	/// </summary>
	public void AddFileName(string fname)
	{
		vtkIOSSReader_AddFileName_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_AddProperty_02(HandleRef pThis, string name, int value);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void AddProperty(string name, int value)
	{
		vtkIOSSReader_AddProperty_02(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_AddProperty_03(HandleRef pThis, string name, double value);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void AddProperty(string name, double value)
	{
		vtkIOSSReader_AddProperty_03(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_AddProperty_04(HandleRef pThis, string name, IntPtr value);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void AddProperty(string name, IntPtr value)
	{
		vtkIOSSReader_AddProperty_04(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_AddProperty_05(HandleRef pThis, string name, string value);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void AddProperty(string name, string value)
	{
		vtkIOSSReader_AddProperty_05(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_AddSelector_06(HandleRef pThis, string selector);

	/// <summary>
	/// API to specify selectors that indicate which branches on the assembly are
	/// chosen.
	/// </summary>
	public bool AddSelector(string selector)
	{
		return (vtkIOSSReader_AddSelector_06(GetCppThis(), selector) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ApplyDisplacementsOff_07(HandleRef pThis);

	/// <summary>
	/// When set to true (default), if an array named 'displacement' is present in
	/// the node field arrays, it will be used to transform the point coordinates.
	/// </summary>
	public virtual void ApplyDisplacementsOff()
	{
		vtkIOSSReader_ApplyDisplacementsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ApplyDisplacementsOn_08(HandleRef pThis);

	/// <summary>
	/// When set to true (default), if an array named 'displacement' is present in
	/// the node field arrays, it will be used to transform the point coordinates.
	/// </summary>
	public virtual void ApplyDisplacementsOn()
	{
		vtkIOSSReader_ApplyDisplacementsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ClearFileNames_09(HandleRef pThis);

	/// <summary>
	/// API to set the filenames.
	/// </summary>
	public void ClearFileNames()
	{
		vtkIOSSReader_ClearFileNames_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ClearProperties_10(HandleRef pThis);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void ClearProperties()
	{
		vtkIOSSReader_ClearProperties_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ClearSelectors_11(HandleRef pThis);

	/// <summary>
	/// API to specify selectors that indicate which branches on the assembly are
	/// chosen.
	/// </summary>
	public void ClearSelectors()
	{
		vtkIOSSReader_ClearSelectors_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_DoTestFilePatternMatching_12();

	/// <summary>
	/// Runs a bunch of tests for file pattern matching.
	/// </summary>
	public static bool DoTestFilePatternMatching()
	{
		return (vtkIOSSReader_DoTestFilePatternMatching_12() != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_GenerateFileIdOff_13(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader will add a cell-data array for cells named
	/// 'file_id' which identifies the file number when reading spatially
	/// partitioned files.
	///
	/// Default is false.
	/// </summary>
	public virtual void GenerateFileIdOff()
	{
		vtkIOSSReader_GenerateFileIdOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_GenerateFileIdOn_14(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader will add a cell-data array for cells named
	/// 'file_id' which identifies the file number when reading spatially
	/// partitioned files.
	///
	/// Default is false.
	/// </summary>
	public virtual void GenerateFileIdOn()
	{
		vtkIOSSReader_GenerateFileIdOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetApplyDisplacements_15(HandleRef pThis);

	/// <summary>
	/// When set to true (default), if an array named 'displacement' is present in
	/// the node field arrays, it will be used to transform the point coordinates.
	/// </summary>
	public virtual bool GetApplyDisplacements()
	{
		return (vtkIOSSReader_GetApplyDisplacements_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetAssembly_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Assemblies provide yet another way of selection blocks/sets to load, if
	/// available in the dataset. If a block (or set) is enabled either in the
	/// block (or set) selection or using assembly selector then it is treated as
	/// enabled and will be read.
	///
	/// This method returns the vtkDataAssembly. Since IOSS can have multiple
	/// assemblies, all are nested under the root "Assemblies" node.
	///
	/// If the file has no assemblies, this will return nullptr.
	/// </summary>
	public vtkDataAssembly GetAssembly()
	{
		vtkDataAssembly vtkDataAssembly2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetAssembly_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataAssembly2 = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataAssembly2.Register(null);
			}
		}
		return vtkDataAssembly2;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_GetAssemblyTag_17(HandleRef pThis);

	/// <summary>
	/// Whenever the assembly is changed, this tag gets changed. Note, users should
	/// not assume that this is monotonically increasing but instead simply rely on
	/// its value to determine if the assembly may have changed since last time.
	///
	/// It is set to 0 whenever there's no valid assembly available.
	/// </summary>
	public virtual int GetAssemblyTag()
	{
		return vtkIOSSReader_GetAssemblyTag_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetController_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller to use when working in parallel. Initialized to
	/// `vtkMultiProcessController::GetGlobalController` in the constructor.
	///
	/// The controller is used to using `ReadMetaData` stage to distribute the work
	/// of gathering meta-data from multiple files, if any, across ranks and then
	/// exchanging that information between all ranks.
	///
	/// The actual reading of data is controlled by piece requests sent by the
	/// pipeline e.g. using `vtkAlgorithm::UpdatePiece`.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetController_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetDataAssemblyNodeNameForEntityType_19(int type);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public static string GetDataAssemblyNodeNameForEntityType(int type)
	{
		return Marshal.PtrToStringAnsi(vtkIOSSReader_GetDataAssemblyNodeNameForEntityType_19(type));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetDatabaseTypeOverride_20(HandleRef pThis);

	/// <summary>
	/// Get/Set the IOSS database name to use for reading the file. If not
	/// specified (default), the reader will determine based on the file extension.
	/// </summary>
	public virtual string GetDatabaseTypeOverride()
	{
		return Marshal.PtrToStringAnsi(vtkIOSSReader_GetDatabaseTypeOverride_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkIOSSReader_GetDisplacementMagnitude_21(HandleRef pThis);

	/// <summary>
	/// When displacements are being applied, they are scaled by this amount. Set to 1 (default) for no
	/// scaling.
	/// </summary>
	public double GetDisplacementMagnitude()
	{
		return vtkIOSSReader_GetDisplacementMagnitude_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetEdgeBlockFieldSelection_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetEdgeBlockFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetEdgeBlockFieldSelection_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetEdgeBlockIdMapAsString_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetEdgeBlockIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetEdgeBlockIdMapAsString_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetEdgeBlockSelection_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetEdgeBlockSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetEdgeBlockSelection_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetEdgeSetFieldSelection_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetEdgeSetFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetEdgeSetFieldSelection_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetEdgeSetIdMapAsString_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetEdgeSetIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetEdgeSetIdMapAsString_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetEdgeSetSelection_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetEdgeSetSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetEdgeSetSelection_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetElementBlockFieldSelection_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetElementBlockFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetElementBlockFieldSelection_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetElementBlockIdMapAsString_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetElementBlockIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetElementBlockIdMapAsString_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetElementBlockSelection_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetElementBlockSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetElementBlockSelection_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetElementSetFieldSelection_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetElementSetFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetElementSetFieldSelection_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetElementSetIdMapAsString_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetElementSetIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetElementSetIdMapAsString_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetElementSetSelection_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetElementSetSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetElementSetSelection_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetEntityIdMapAsString_34(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetEntityIdMapAsString(int type)
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetEntityIdMapAsString_34(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetEntitySelection_35(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetEntitySelection(int type)
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetEntitySelection_35(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetEntityTypeIsBlock_36(int type);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public static bool GetEntityTypeIsBlock(int type)
	{
		return (vtkIOSSReader_GetEntityTypeIsBlock_36(type) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetEntityTypeIsSet_37(int type);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public static bool GetEntityTypeIsSet(int type)
	{
		return (vtkIOSSReader_GetEntityTypeIsSet_37(type) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFaceBlockFieldSelection_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetFaceBlockFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetFaceBlockFieldSelection_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFaceBlockIdMapAsString_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetFaceBlockIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetFaceBlockIdMapAsString_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFaceBlockSelection_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetFaceBlockSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetFaceBlockSelection_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFaceSetFieldSelection_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetFaceSetFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetFaceSetFieldSelection_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFaceSetIdMapAsString_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetFaceSetIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetFaceSetIdMapAsString_42(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFaceSetSelection_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetFaceSetSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetFaceSetSelection_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFieldSelection_44(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetFieldSelection(int type)
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetFieldSelection_44(GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkIOSSReader_GetFieldSuffixSeparator_45(HandleRef pThis);

	/// <summary>
	/// Set the character used to separate suffix from the field.
	/// </summary>
	public string GetFieldSuffixSeparator()
	{
		return vtkIOSSReader_GetFieldSuffixSeparator_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFileName_46(HandleRef pThis, int index);

	/// <summary>
	/// API to set the filenames.
	/// </summary>
	public string GetFileName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkIOSSReader_GetFileName_46(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetFileRange_47(HandleRef pThis);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public virtual int[] GetFileRange()
	{
		IntPtr intPtr = vtkIOSSReader_GetFileRange_47(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_GetFileRange_48(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public virtual void GetFileRange(ref int _arg1, ref int _arg2)
	{
		vtkIOSSReader_GetFileRange_48(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_GetFileRange_49(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public virtual void GetFileRange(IntPtr _arg)
	{
		vtkIOSSReader_GetFileRange_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_GetFileStride_50(HandleRef pThis);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public virtual int GetFileStride()
	{
		return vtkIOSSReader_GetFileStride_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_GetFileStrideMaxValue_51(HandleRef pThis);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public virtual int GetFileStrideMaxValue()
	{
		return vtkIOSSReader_GetFileStrideMaxValue_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_GetFileStrideMinValue_52(HandleRef pThis);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public virtual int GetFileStrideMinValue()
	{
		return vtkIOSSReader_GetFileStrideMinValue_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetGenerateFileId_53(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader will add a cell-data array for cells named
	/// 'file_id' which identifies the file number when reading spatially
	/// partitioned files.
	///
	/// Default is false.
	/// </summary>
	public virtual bool GetGenerateFileId()
	{
		return (vtkIOSSReader_GetGenerateFileId_53(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetGroupNumericVectorFieldComponents_54(HandleRef pThis);

	/// <summary>
	/// Set whether the reader should treat numeric suffixes for a vector field as vector components.
	/// By default, this property is off.
	/// Example: DENSITY_1, DENSITY_2, DENSITY_3, DENSITY_4
	/// If the property is true, those fields will be parsed as a 4-component vtkDataArray
	/// named DESNITY.
	/// When turned off, DENSITY_1, DENSITY_2, DENSITY_3, DENSITY_4 fields will be parsed as 4
	/// vtkDataArrays with 1 component each.
	/// </summary>
	public bool GetGroupNumericVectorFieldComponents()
	{
		return (vtkIOSSReader_GetGroupNumericVectorFieldComponents_54(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkIOSSReader_GetMTime_55(HandleRef pThis);

	/// <summary>
	/// Overridden to take into account mtimes for vtkDataArraySelection instances.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkIOSSReader_GetMTime_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetNodeBlockFieldSelection_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetNodeBlockFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetNodeBlockFieldSelection_56(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetNodeBlockIdMapAsString_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetNodeBlockIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetNodeBlockIdMapAsString_57(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetNodeBlockSelection_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetNodeBlockSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetNodeBlockSelection_58(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetNodeSetFieldSelection_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetNodeSetFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetNodeSetFieldSelection_59(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetNodeSetIdMapAsString_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetNodeSetIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetNodeSetIdMapAsString_60(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetNodeSetSelection_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetNodeSetSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetNodeSetSelection_61(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_GetNumberOfFileNames_62(HandleRef pThis);

	/// <summary>
	/// API to set the filenames.
	/// </summary>
	public int GetNumberOfFileNames()
	{
		return vtkIOSSReader_GetNumberOfFileNames_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIOSSReader_GetNumberOfGenerationsFromBase_63(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIOSSReader_GetNumberOfGenerationsFromBase_63(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIOSSReader_GetNumberOfGenerationsFromBaseType_64(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIOSSReader_GetNumberOfGenerationsFromBaseType_64(type);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_GetNumberOfSelectors_65(HandleRef pThis);

	/// <summary>
	/// API to access selectors.
	/// </summary>
	public int GetNumberOfSelectors()
	{
		return vtkIOSSReader_GetNumberOfSelectors_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetReadGlobalFields_66(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read global fields.
	/// </summary>
	public virtual bool GetReadGlobalFields()
	{
		return (vtkIOSSReader_GetReadGlobalFields_66(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetReadIds_67(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read ids associated with
	/// elements.
	/// </summary>
	public virtual bool GetReadIds()
	{
		return (vtkIOSSReader_GetReadIds_67(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetReadQAAndInformationRecords_68(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read quality assurance and
	/// information fields.
	/// </summary>
	public virtual bool GetReadQAAndInformationRecords()
	{
		return (vtkIOSSReader_GetReadQAAndInformationRecords_68(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetRemoveUnusedPoints_69(HandleRef pThis);

	/// <summary>
	/// Node related data, including point coordinates, point field data etc. is
	/// typically shared between all blocks and sets. By default, the reader will
	/// remove unused points for each block or set. To avoid this, set this flag to
	/// false.
	///
	/// Default is true, unused points are removed.
	/// </summary>
	public virtual bool GetRemoveUnusedPoints()
	{
		return (vtkIOSSReader_GetRemoveUnusedPoints_69(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkIOSSReader_GetScanForRelatedFiles_70(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader can automatically locate and load additional
	/// files that are part of the collection.
	/// </summary>
	public virtual bool GetScanForRelatedFiles()
	{
		return (vtkIOSSReader_GetScanForRelatedFiles_70(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetSelector_71(HandleRef pThis, int index);

	/// <summary>
	/// API to access selectors.
	/// </summary>
	public string GetSelector(int index)
	{
		return Marshal.PtrToStringAnsi(vtkIOSSReader_GetSelector_71(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetSideSetFieldSelection_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetSideSetFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetSideSetFieldSelection_72(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetSideSetIdMapAsString_73(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetSideSetIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetSideSetIdMapAsString_73(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetSideSetSelection_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetSideSetSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetSideSetSelection_74(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetStructuredBlockFieldSelection_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetStructuredBlockFieldSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetStructuredBlockFieldSelection_75(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetStructuredBlockIdMapAsString_76(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This API is not really meant for public use and may change without notices.
	/// It is simply provided to make it easy to wrap the API in client-server
	/// wrappings for ParaView.
	/// </summary>
	public vtkStringArray GetStructuredBlockIdMapAsString()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetStructuredBlockIdMapAsString_76(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_GetStructuredBlockSelection_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public vtkDataArraySelection GetStructuredBlockSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_GetStructuredBlockSelection_77(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_IsA_78(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIOSSReader_IsA_78(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_IsTypeOf_79(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIOSSReader_IsTypeOf_79(type);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_NewInstance_81(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIOSSReader NewInstance()
	{
		vtkIOSSReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_NewInstance_81(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIOSSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_ReadArrays_82(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

	/// <summary>
	/// Implementation for vtkReaderAlgorithm API
	/// </summary>
	public override int ReadArrays(int arg0, int arg1, int arg2, int arg3, vtkDataObject arg4)
	{
		return vtkIOSSReader_ReadArrays_82(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ReadGlobalFieldsOff_83(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read global fields.
	/// </summary>
	public virtual void ReadGlobalFieldsOff()
	{
		vtkIOSSReader_ReadGlobalFieldsOff_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ReadGlobalFieldsOn_84(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read global fields.
	/// </summary>
	public virtual void ReadGlobalFieldsOn()
	{
		vtkIOSSReader_ReadGlobalFieldsOn_84(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ReadIdsOff_85(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read ids associated with
	/// elements.
	/// </summary>
	public virtual void ReadIdsOff()
	{
		vtkIOSSReader_ReadIdsOff_85(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ReadIdsOn_86(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read ids associated with
	/// elements.
	/// </summary>
	public virtual void ReadIdsOn()
	{
		vtkIOSSReader_ReadIdsOn_86(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_ReadMesh_87(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// Implementation for vtkReaderAlgorithm API
	/// </summary>
	public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkIOSSReader_ReadMesh_87(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_ReadMetaData_88(HandleRef pThis, HandleRef metadata);

	/// <summary>
	/// Implementation for vtkReaderAlgorithm API
	/// </summary>
	public override int ReadMetaData(vtkInformation metadata)
	{
		return vtkIOSSReader_ReadMetaData_88(GetCppThis(), metadata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIOSSReader_ReadPoints_89(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

	/// <summary>
	/// Implementation for vtkReaderAlgorithm API
	/// </summary>
	public override int ReadPoints(int arg0, int arg1, int arg2, int arg3, vtkDataObject arg4)
	{
		return vtkIOSSReader_ReadPoints_89(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ReadQAAndInformationRecordsOff_90(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read quality assurance and
	/// information fields.
	/// </summary>
	public virtual void ReadQAAndInformationRecordsOff()
	{
		vtkIOSSReader_ReadQAAndInformationRecordsOff_90(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ReadQAAndInformationRecordsOn_91(HandleRef pThis);

	/// <summary>
	/// When set to true (default), the reader will read quality assurance and
	/// information fields.
	/// </summary>
	public virtual void ReadQAAndInformationRecordsOn()
	{
		vtkIOSSReader_ReadQAAndInformationRecordsOn_91(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_RemoveAllEntitySelections_92(HandleRef pThis);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void RemoveAllEntitySelections()
	{
		vtkIOSSReader_RemoveAllEntitySelections_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_RemoveAllFieldSelections_93(HandleRef pThis);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void RemoveAllFieldSelections()
	{
		vtkIOSSReader_RemoveAllFieldSelections_93(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_RemoveAllSelections_94(HandleRef pThis);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void RemoveAllSelections()
	{
		vtkIOSSReader_RemoveAllSelections_94(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_RemoveProperty_95(HandleRef pThis, string name);

	/// <summary>
	/// IOSS databases support various properties that affect how the database is
	/// read. These properties can be set using this API. Note, it's best to call
	/// this before the first update to the reader since any change and the reader
	/// will flush all caches and close all open databases etc.
	/// </summary>
	public void RemoveProperty(string name)
	{
		vtkIOSSReader_RemoveProperty_95(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_RemoveUnusedPointsOff_96(HandleRef pThis);

	/// <summary>
	/// Node related data, including point coordinates, point field data etc. is
	/// typically shared between all blocks and sets. By default, the reader will
	/// remove unused points for each block or set. To avoid this, set this flag to
	/// false.
	///
	/// Default is true, unused points are removed.
	/// </summary>
	public virtual void RemoveUnusedPointsOff()
	{
		vtkIOSSReader_RemoveUnusedPointsOff_96(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_RemoveUnusedPointsOn_97(HandleRef pThis);

	/// <summary>
	/// Node related data, including point coordinates, point field data etc. is
	/// typically shared between all blocks and sets. By default, the reader will
	/// remove unused points for each block or set. To avoid this, set this flag to
	/// false.
	///
	/// Default is true, unused points are removed.
	/// </summary>
	public virtual void RemoveUnusedPointsOn()
	{
		vtkIOSSReader_RemoveUnusedPointsOn_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIOSSReader_SafeDownCast_98(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIOSSReader SafeDownCast(vtkObjectBase o)
	{
		vtkIOSSReader vtkIOSSReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIOSSReader_SafeDownCast_98(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIOSSReader2 = (vtkIOSSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIOSSReader2.Register(null);
			}
		}
		return vtkIOSSReader2;
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ScanForRelatedFilesOff_99(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader can automatically locate and load additional
	/// files that are part of the collection.
	/// </summary>
	public virtual void ScanForRelatedFilesOff()
	{
		vtkIOSSReader_ScanForRelatedFilesOff_99(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_ScanForRelatedFilesOn_100(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader can automatically locate and load additional
	/// files that are part of the collection.
	/// </summary>
	public virtual void ScanForRelatedFilesOn()
	{
		vtkIOSSReader_ScanForRelatedFilesOn_100(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetApplyDisplacements_101(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default), if an array named 'displacement' is present in
	/// the node field arrays, it will be used to transform the point coordinates.
	/// </summary>
	public virtual void SetApplyDisplacements(bool _arg)
	{
		vtkIOSSReader_SetApplyDisplacements_101(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetController_102(HandleRef pThis, HandleRef controller);

	/// <summary>
	/// Get/Set the controller to use when working in parallel. Initialized to
	/// `vtkMultiProcessController::GetGlobalController` in the constructor.
	///
	/// The controller is used to using `ReadMetaData` stage to distribute the work
	/// of gathering meta-data from multiple files, if any, across ranks and then
	/// exchanging that information between all ranks.
	///
	/// The actual reading of data is controlled by piece requests sent by the
	/// pipeline e.g. using `vtkAlgorithm::UpdatePiece`.
	/// </summary>
	public void SetController(vtkMultiProcessController controller)
	{
		vtkIOSSReader_SetController_102(GetCppThis(), controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetDatabaseTypeOverride_103(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the IOSS database name to use for reading the file. If not
	/// specified (default), the reader will determine based on the file extension.
	/// </summary>
	public virtual void SetDatabaseTypeOverride(string _arg)
	{
		vtkIOSSReader_SetDatabaseTypeOverride_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetDisplacementMagnitude_104(HandleRef pThis, double magnitude);

	/// <summary>
	/// When displacements are being applied, they are scaled by this amount. Set to 1 (default) for no
	/// scaling.
	/// </summary>
	public void SetDisplacementMagnitude(double magnitude)
	{
		vtkIOSSReader_SetDisplacementMagnitude_104(GetCppThis(), magnitude);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetFieldSuffixSeparator_105(HandleRef pThis, string value);

	/// <summary>
	/// Set the character used to separate suffix from the field.
	/// </summary>
	public void SetFieldSuffixSeparator(string value)
	{
		vtkIOSSReader_SetFieldSuffixSeparator_105(GetCppThis(), value);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetFileName_106(HandleRef pThis, string fname);

	/// <summary>
	/// Set a single filename. Note, this will clear all existing filenames.
	/// </summary>
	public void SetFileName(string fname)
	{
		vtkIOSSReader_SetFileName_106(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetFileRange_107(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public virtual void SetFileRange(int _arg1, int _arg2)
	{
		vtkIOSSReader_SetFileRange_107(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetFileRange_108(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public void SetFileRange(IntPtr _arg)
	{
		vtkIOSSReader_SetFileRange_108(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetFileStride_109(HandleRef pThis, int _arg);

	/// <summary>
	/// This provides a mechanism to limit to reading to certain files in a
	/// spatially partitioned file-series. To just specific subset of files, one can
	/// always simply specify those files using `AddFileName` and then set
	/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
	/// related files and then use `FileRange` and `FileStride` to limit which
	/// files are read.
	///
	/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
	/// that no file-range overrides have been specified and both FileRange and
	/// FileStride will be ignored. When valid, only the chosen subset of files
	/// will be processed.
	/// </summary>
	public virtual void SetFileStride(int _arg)
	{
		vtkIOSSReader_SetFileStride_109(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetGenerateFileId_110(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true, the reader will add a cell-data array for cells named
	/// 'file_id' which identifies the file number when reading spatially
	/// partitioned files.
	///
	/// Default is false.
	/// </summary>
	public virtual void SetGenerateFileId(bool _arg)
	{
		vtkIOSSReader_SetGenerateFileId_110(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetGroupNumericVectorFieldComponents_111(HandleRef pThis, byte value);

	/// <summary>
	/// Set whether the reader should treat numeric suffixes for a vector field as vector components.
	/// By default, this property is off.
	/// Example: DENSITY_1, DENSITY_2, DENSITY_3, DENSITY_4
	/// If the property is true, those fields will be parsed as a 4-component vtkDataArray
	/// named DESNITY.
	/// When turned off, DENSITY_1, DENSITY_2, DENSITY_3, DENSITY_4 fields will be parsed as 4
	/// vtkDataArrays with 1 component each.
	/// </summary>
	public void SetGroupNumericVectorFieldComponents(bool value)
	{
		vtkIOSSReader_SetGroupNumericVectorFieldComponents_111(GetCppThis(), (byte)(value ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetReadGlobalFields_112(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default), the reader will read global fields.
	/// </summary>
	public virtual void SetReadGlobalFields(bool _arg)
	{
		vtkIOSSReader_SetReadGlobalFields_112(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetReadIds_113(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default), the reader will read ids associated with
	/// elements.
	/// </summary>
	public virtual void SetReadIds(bool _arg)
	{
		vtkIOSSReader_SetReadIds_113(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetReadQAAndInformationRecords_114(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default), the reader will read quality assurance and
	/// information fields.
	/// </summary>
	public virtual void SetReadQAAndInformationRecords(bool _arg)
	{
		vtkIOSSReader_SetReadQAAndInformationRecords_114(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetRemoveUnusedPoints_115(HandleRef pThis, byte arg0);

	/// <summary>
	/// Node related data, including point coordinates, point field data etc. is
	/// typically shared between all blocks and sets. By default, the reader will
	/// remove unused points for each block or set. To avoid this, set this flag to
	/// false.
	///
	/// Default is true, unused points are removed.
	/// </summary>
	public void SetRemoveUnusedPoints(bool arg0)
	{
		vtkIOSSReader_SetRemoveUnusedPoints_115(GetCppThis(), (byte)(arg0 ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetScanForRelatedFiles_116(HandleRef pThis, byte value);

	/// <summary>
	/// When set to true, the reader can automatically locate and load additional
	/// files that are part of the collection.
	/// </summary>
	public void SetScanForRelatedFiles(bool value)
	{
		vtkIOSSReader_SetScanForRelatedFiles_116(GetCppThis(), (byte)(value ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIOSSReader_SetSelector_117(HandleRef pThis, string selector);

	/// <summary>
	/// API to specify selectors that indicate which branches on the assembly are
	/// chosen.
	/// </summary>
	public void SetSelector(string selector)
	{
		vtkIOSSReader_SetSelector_117(GetCppThis(), selector);
	}
}
