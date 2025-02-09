using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExodusIIReader
/// </summary>
/// <remarks>
///    Read exodus 2 files .ex2
///
/// vtkExodusIIReader is a unstructured grid source object that reads ExodusII
/// files.  Most of the meta data associated with the file is loaded when
/// UpdateInformation is called.  This includes information like Title, number
/// of blocks, number and names of arrays. This data can be retrieved from
/// methods in this reader. Separate arrays that are meant to be a single
/// vector, are combined internally for convenience.  To be combined, the array
/// names have to be identical except for a trailing X,Y and Z (or x,y,z).  By
/// default cell and point arrays are not loaded.  However, the user can flag
/// arrays to load with the methods "SetPointResultArrayStatus" and
/// "SetElementResultArrayStatus".  The reader DOES NOT respond to piece requests
///
/// </remarks>
public class vtkExodusIIReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public enum ID_NOT_FOUND_WrapperEnum
	{
		/// <summary>enum member</summary>
		ID_NOT_FOUND = -234121312,
		/// <summary>enum member</summary>
		SEARCH_TYPE_ELEMENT = 0,
		/// <summary>enum member</summary>
		SEARCH_TYPE_ELEMENT_THEN_NODE = 2,
		/// <summary>enum member</summary>
		SEARCH_TYPE_NODE = 1,
		/// <summary>enum member</summary>
		SEARCH_TYPE_NODE_THEN_ELEMENT = 3
	}

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public enum ObjectType
	{
		/// <summary>enum member</summary>
		ASSEMBLY = 60,
		/// <summary>enum member</summary>
		EDGE_BLOCK = 6,
		/// <summary>enum member</summary>
		EDGE_BLOCK_ATTRIB = 79,
		/// <summary>enum member</summary>
		EDGE_BLOCK_CONN = 94,
		/// <summary>enum member</summary>
		EDGE_ID = 106,
		/// <summary>enum member</summary>
		EDGE_MAP = 11,
		/// <summary>enum member</summary>
		EDGE_SET = 7,
		/// <summary>enum member</summary>
		EDGE_SET_CONN = 90,
		/// <summary>enum member</summary>
		ELEMENT_ID = 84,
		/// <summary>enum member</summary>
		ELEM_BLOCK = 1,
		/// <summary>enum member</summary>
		ELEM_BLOCK_ATTRIB = 81,
		/// <summary>enum member</summary>
		ELEM_BLOCK_EDGE_CONN = 96,
		/// <summary>enum member</summary>
		ELEM_BLOCK_ELEM_CONN = 98,
		/// <summary>enum member</summary>
		ELEM_BLOCK_FACE_CONN = 97,
		/// <summary>enum member</summary>
		ELEM_BLOCK_TEMPORAL = 100,
		/// <summary>enum member</summary>
		ELEM_MAP = 4,
		/// <summary>enum member</summary>
		ELEM_SET = 10,
		/// <summary>enum member</summary>
		ELEM_SET_CONN = 93,
		/// <summary>enum member</summary>
		ENTITY_COUNTS = 109,
		/// <summary>enum member</summary>
		FACE_BLOCK = 8,
		/// <summary>enum member</summary>
		FACE_BLOCK_ATTRIB = 80,
		/// <summary>enum member</summary>
		FACE_BLOCK_CONN = 95,
		/// <summary>enum member</summary>
		FACE_ID = 105,
		/// <summary>enum member</summary>
		FACE_MAP = 12,
		/// <summary>enum member</summary>
		FACE_SET = 9,
		/// <summary>enum member</summary>
		FACE_SET_CONN = 91,
		/// <summary>enum member</summary>
		GLOBAL = 13,
		/// <summary>enum member</summary>
		GLOBAL_CONN = 99,
		/// <summary>enum member</summary>
		GLOBAL_ELEMENT_ID = 86,
		/// <summary>enum member</summary>
		GLOBAL_NODE_ID = 85,
		/// <summary>enum member</summary>
		GLOBAL_TEMPORAL = 102,
		/// <summary>enum member</summary>
		HIERARCHY = 63,
		/// <summary>enum member</summary>
		IMPLICIT_ELEMENT_ID = 108,
		/// <summary>enum member</summary>
		IMPLICIT_NODE_ID = 107,
		/// <summary>enum member</summary>
		INFO_RECORDS = 104,
		/// <summary>enum member</summary>
		MATERIAL = 62,
		/// <summary>enum member</summary>
		NODAL = 14,
		/// <summary>enum member</summary>
		NODAL_COORDS = 88,
		/// <summary>enum member</summary>
		NODAL_SQUEEZEMAP = 82,
		/// <summary>enum member</summary>
		NODAL_TEMPORAL = 101,
		/// <summary>enum member</summary>
		NODE_ID = 83,
		/// <summary>enum member</summary>
		NODE_MAP = 5,
		/// <summary>enum member</summary>
		NODE_SET = 2,
		/// <summary>enum member</summary>
		NODE_SET_CONN = 89,
		/// <summary>enum member</summary>
		OBJECT_ID = 87,
		/// <summary>enum member</summary>
		PART = 61,
		/// <summary>enum member</summary>
		QA_RECORDS = 103,
		/// <summary>enum member</summary>
		SIDE_SET = 3,
		/// <summary>enum member</summary>
		SIDE_SET_CONN = 92
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIIReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExodusIIReader()
	{
		MRClassNameKey = "class vtkExodusIIReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIIReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExodusIIReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExodusIIReader New()
	{
		vtkExodusIIReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExodusIIReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExodusIIReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_AnimateModeShapesOff_01(HandleRef pThis);

	/// <summary>
	/// If this flag is on (the default) and HasModeShapes is also on, then this
	/// reader will report a continuous time range [0,1] and animate the
	/// displacements in a periodic sinusoid.  If this flag is off and
	/// HasModeShapes is on, this reader ignores time.  This flag has no effect if
	/// HasModeShapes is off.
	/// </summary>
	public virtual void AnimateModeShapesOff()
	{
		vtkExodusIIReader_AnimateModeShapesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_AnimateModeShapesOn_02(HandleRef pThis);

	/// <summary>
	/// If this flag is on (the default) and HasModeShapes is also on, then this
	/// reader will report a continuous time range [0,1] and animate the
	/// displacements in a periodic sinusoid.  If this flag is off and
	/// HasModeShapes is on, this reader ignores time.  This flag has no effect if
	/// HasModeShapes is off.
	/// </summary>
	public virtual void AnimateModeShapesOn()
	{
		vtkExodusIIReader_AnimateModeShapesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_ApplyDisplacementsOff_03(HandleRef pThis);

	/// <summary>
	/// Geometric locations can include displacements.  By default,
	/// this is ON.  The nodal positions are 'displaced' by the
	/// standard exodus displacement vector. If displacements
	/// are turned 'off', the user can explicitly add them by
	/// applying a warp filter.
	/// </summary>
	public virtual void ApplyDisplacementsOff()
	{
		vtkExodusIIReader_ApplyDisplacementsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_ApplyDisplacementsOn_04(HandleRef pThis);

	/// <summary>
	/// Geometric locations can include displacements.  By default,
	/// this is ON.  The nodal positions are 'displaced' by the
	/// standard exodus displacement vector. If displacements
	/// are turned 'off', the user can explicitly add them by
	/// applying a warp filter.
	/// </summary>
	public virtual void ApplyDisplacementsOn()
	{
		vtkExodusIIReader_ApplyDisplacementsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_CanReadFile_05(HandleRef pThis, string fname);

	/// <summary>
	/// Determine if the file can be read with this reader.
	/// </summary>
	public virtual int CanReadFile(string fname)
	{
		return vtkExodusIIReader_CanReadFile_05(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_Dump_06(HandleRef pThis);

	/// <summary>
	/// Should the reader output only points used by elements in the output mesh,
	/// or all the points. Outputting all the points is much faster since the
	/// point array can be read straight from disk and the mesh connectivity need
	/// not be altered. Squeezing the points down to the minimum set needed to
	/// produce the output mesh is useful for glyphing and other point-based
	/// operations. On large parallel datasets, loading all the points implies
	/// loading all the points on all processes and performing subsequent
	/// filtering on a much larger set.
	///
	/// By default, SqueezePoints is true for backwards compatibility.
	/// </summary>
	public virtual void Dump()
	{
		vtkExodusIIReader_Dump_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GLOBAL_TEMPORAL_VARIABLE_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Exodus reader outputs global variables and global temporal variables,
	/// together with some other variables as FieldData. These keys help identify
	/// which arrays in the FieldData are GLOBAL and which ones are
	/// GLOBAL_TEMPORAL.
	///
	/// @sa vtkExtractExodusGlobalTemporalVariables.
	/// </summary>
	public static vtkInformationIntegerKey GLOBAL_TEMPORAL_VARIABLE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReader_GLOBAL_TEMPORAL_VARIABLE_07(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GLOBAL_VARIABLE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Exodus reader outputs global variables and global temporal variables,
	/// together with some other variables as FieldData. These keys help identify
	/// which arrays in the FieldData are GLOBAL and which ones are
	/// GLOBAL_TEMPORAL.
	///
	/// @sa vtkExtractExodusGlobalTemporalVariables.
	/// </summary>
	public static vtkInformationIntegerKey GLOBAL_VARIABLE()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReader_GLOBAL_VARIABLE_08(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateFileIdArrayOff_09(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateFileIdArrayOff()
	{
		vtkExodusIIReader_GenerateFileIdArrayOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateFileIdArrayOn_10(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateFileIdArrayOn()
	{
		vtkExodusIIReader_GenerateFileIdArrayOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateGlobalElementIdArrayOff_11(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateGlobalElementIdArrayOff()
	{
		vtkExodusIIReader_GenerateGlobalElementIdArrayOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateGlobalElementIdArrayOn_12(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateGlobalElementIdArrayOn()
	{
		vtkExodusIIReader_GenerateGlobalElementIdArrayOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateGlobalNodeIdArrayOff_13(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateGlobalNodeIdArrayOff()
	{
		vtkExodusIIReader_GenerateGlobalNodeIdArrayOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateGlobalNodeIdArrayOn_14(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateGlobalNodeIdArrayOn()
	{
		vtkExodusIIReader_GenerateGlobalNodeIdArrayOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateImplicitElementIdArrayOff_15(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateImplicitElementIdArrayOff()
	{
		vtkExodusIIReader_GenerateImplicitElementIdArrayOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateImplicitElementIdArrayOn_16(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateImplicitElementIdArrayOn()
	{
		vtkExodusIIReader_GenerateImplicitElementIdArrayOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateImplicitNodeIdArrayOff_17(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateImplicitNodeIdArrayOff()
	{
		vtkExodusIIReader_GenerateImplicitNodeIdArrayOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateImplicitNodeIdArrayOn_18(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateImplicitNodeIdArrayOn()
	{
		vtkExodusIIReader_GenerateImplicitNodeIdArrayOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateObjectIdCellArrayOff_19(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateObjectIdCellArrayOff()
	{
		vtkExodusIIReader_GenerateObjectIdCellArrayOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GenerateObjectIdCellArrayOn_20(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void GenerateObjectIdCellArrayOn()
	{
		vtkExodusIIReader_GenerateObjectIdCellArrayOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetAnimateModeShapes_21(HandleRef pThis);

	/// <summary>
	/// If this flag is on (the default) and HasModeShapes is also on, then this
	/// reader will report a continuous time range [0,1] and animate the
	/// displacements in a periodic sinusoid.  If this flag is off and
	/// HasModeShapes is on, this reader ignores time.  This flag has no effect if
	/// HasModeShapes is off.
	/// </summary>
	public int GetAnimateModeShapes()
	{
		return vtkExodusIIReader_GetAnimateModeShapes_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetApplyDisplacements_22(HandleRef pThis);

	/// <summary>
	/// Geometric locations can include displacements.  By default,
	/// this is ON.  The nodal positions are 'displaced' by the
	/// standard exodus displacement vector. If displacements
	/// are turned 'off', the user can explicitly add them by
	/// applying a warp filter.
	/// </summary>
	public int GetApplyDisplacements()
	{
		return vtkExodusIIReader_GetApplyDisplacements_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetAssemblyArrayID_23(HandleRef pThis, string name);

	/// <summary>
	/// By default all assemblies are loaded. These methods allow the user to
	/// select which assemblies they want to load.  You can get information
	/// about the assemblies by first calling UpdateInformation, and using
	/// GetAssemblyArrayName ...
	/// </summary>
	public int GetAssemblyArrayID(string name)
	{
		return vtkExodusIIReader_GetAssemblyArrayID_23(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetAssemblyArrayName_24(HandleRef pThis, int arrayIdx);

	/// <summary>
	/// By default all assemblies are loaded. These methods allow the user to
	/// select which assemblies they want to load.  You can get information
	/// about the assemblies by first calling UpdateInformation, and using
	/// GetAssemblyArrayName ...
	/// </summary>
	public string GetAssemblyArrayName(int arrayIdx)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetAssemblyArrayName_24(GetCppThis(), arrayIdx));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetAssemblyArrayStatus_25(HandleRef pThis, int index);

	/// <summary>
	/// By default all assemblies are loaded. These methods allow the user to
	/// select which assemblies they want to load.  You can get information
	/// about the assemblies by first calling UpdateInformation, and using
	/// GetAssemblyArrayName ...
	/// </summary>
	public int GetAssemblyArrayStatus(int index)
	{
		return vtkExodusIIReader_GetAssemblyArrayStatus_25(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetAssemblyArrayStatus_26(HandleRef pThis, string arg0);

	/// <summary>
	/// By default all assemblies are loaded. These methods allow the user to
	/// select which assemblies they want to load.  You can get information
	/// about the assemblies by first calling UpdateInformation, and using
	/// GetAssemblyArrayName ...
	/// </summary>
	public int GetAssemblyArrayStatus(string arg0)
	{
		return vtkExodusIIReader_GetAssemblyArrayStatus_26(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExodusIIReader_GetCacheSize_27(HandleRef pThis);

	/// <summary>
	/// Get the size of the cache in MiB.
	/// </summary>
	public double GetCacheSize()
	{
		return vtkExodusIIReader_GetCacheSize_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetDimensionality_28(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetDimensionality()
	{
		return vtkExodusIIReader_GetDimensionality_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkExodusIIReader_GetDisplacementMagnitude_29(HandleRef pThis);

	/// <summary>
	/// Geometric locations can include displacements.  By default,
	/// this is ON.  The nodal positions are 'displaced' by the
	/// standard exodus displacement vector. If displacements
	/// are turned 'off', the user can explicitly add them by
	/// applying a warp filter.
	/// </summary>
	public float GetDisplacementMagnitude()
	{
		return vtkExodusIIReader_GetDisplacementMagnitude_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetDisplayType_30(HandleRef pThis);

	/// <summary>
	/// By default all hierarchy entries are loaded. These methods allow
	/// the user to
	/// select which hierarchy entries they want to load.  You can get information
	/// about the hierarchy entries by first calling UpdateInformation, and using
	/// GetHierarchyArrayName ...
	/// these methods do not call functions in metaData. They call functions on
	/// the ExodusXMLParser since it seemed silly to duplicate all the information
	/// </summary>
	public virtual int GetDisplayType()
	{
		return vtkExodusIIReader_GetDisplayType_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetEdgeBlockArrayName_31(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetEdgeBlockArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetEdgeBlockArrayName_31(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetEdgeBlockArrayStatus_32(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetEdgeBlockArrayStatus(string name)
	{
		return vtkExodusIIReader_GetEdgeBlockArrayStatus_32(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetEdgeMapArrayName_33(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetEdgeMapArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetEdgeMapArrayName_33(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetEdgeMapArrayStatus_34(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetEdgeMapArrayStatus(string name)
	{
		return vtkExodusIIReader_GetEdgeMapArrayStatus_34(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetEdgeResultArrayName_35(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetEdgeResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetEdgeResultArrayName_35(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetEdgeResultArrayStatus_36(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetEdgeResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetEdgeResultArrayStatus_36(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetEdgeSetArrayName_37(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetEdgeSetArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetEdgeSetArrayName_37(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetEdgeSetArrayStatus_38(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetEdgeSetArrayStatus(string name)
	{
		return vtkExodusIIReader_GetEdgeSetArrayStatus_38(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetEdgeSetResultArrayName_39(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetEdgeSetResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetEdgeSetResultArrayName_39(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetEdgeSetResultArrayStatus_40(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetEdgeSetResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetEdgeSetResultArrayStatus_40(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetElementBlockArrayName_41(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetElementBlockArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetElementBlockArrayName_41(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetElementBlockArrayStatus_42(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetElementBlockArrayStatus(string name)
	{
		return vtkExodusIIReader_GetElementBlockArrayStatus_42(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetElementMapArrayName_43(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetElementMapArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetElementMapArrayName_43(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetElementMapArrayStatus_44(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetElementMapArrayStatus(string name)
	{
		return vtkExodusIIReader_GetElementMapArrayStatus_44(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetElementResultArrayName_45(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetElementResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetElementResultArrayName_45(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetElementResultArrayStatus_46(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetElementResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetElementResultArrayStatus_46(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetElementSetArrayName_47(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetElementSetArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetElementSetArrayName_47(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetElementSetArrayStatus_48(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetElementSetArrayStatus(string name)
	{
		return vtkExodusIIReader_GetElementSetArrayStatus_48(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetElementSetResultArrayName_49(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetElementSetResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetElementSetResultArrayName_49(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetElementSetResultArrayStatus_50(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetElementSetResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetElementSetResultArrayStatus_50(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetFaceBlockArrayName_51(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetFaceBlockArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetFaceBlockArrayName_51(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetFaceBlockArrayStatus_52(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetFaceBlockArrayStatus(string name)
	{
		return vtkExodusIIReader_GetFaceBlockArrayStatus_52(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetFaceMapArrayName_53(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetFaceMapArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetFaceMapArrayName_53(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetFaceMapArrayStatus_54(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetFaceMapArrayStatus(string name)
	{
		return vtkExodusIIReader_GetFaceMapArrayStatus_54(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetFaceResultArrayName_55(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetFaceResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetFaceResultArrayName_55(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetFaceResultArrayStatus_56(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetFaceResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetFaceResultArrayStatus_56(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetFaceSetArrayName_57(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetFaceSetArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetFaceSetArrayName_57(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetFaceSetArrayStatus_58(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetFaceSetArrayStatus(string name)
	{
		return vtkExodusIIReader_GetFaceSetArrayStatus_58(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetFaceSetResultArrayName_59(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetFaceSetResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetFaceSetResultArrayName_59(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetFaceSetResultArrayStatus_60(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetFaceSetResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetFaceSetResultArrayStatus_60(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetFileId_61(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public int GetFileId()
	{
		return vtkExodusIIReader_GetFileId_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetFileName_62(HandleRef pThis);

	/// <summary>
	/// Specify file name of the Exodus file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetFileName_62(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGenerateFileIdArray_63(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public int GetGenerateFileIdArray()
	{
		return vtkExodusIIReader_GetGenerateFileIdArray_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGenerateGlobalElementIdArray_64(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public int GetGenerateGlobalElementIdArray()
	{
		return vtkExodusIIReader_GetGenerateGlobalElementIdArray_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGenerateGlobalNodeIdArray_65(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public int GetGenerateGlobalNodeIdArray()
	{
		return vtkExodusIIReader_GetGenerateGlobalNodeIdArray_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGenerateImplicitElementIdArray_66(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public int GetGenerateImplicitElementIdArray()
	{
		return vtkExodusIIReader_GetGenerateImplicitElementIdArray_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGenerateImplicitNodeIdArray_67(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public int GetGenerateImplicitNodeIdArray()
	{
		return vtkExodusIIReader_GetGenerateImplicitNodeIdArray_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGenerateObjectIdCellArray_68(HandleRef pThis);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public int GetGenerateObjectIdCellArray()
	{
		return vtkExodusIIReader_GetGenerateObjectIdCellArray_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalEdgeID_69(HandleRef data, int localID);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static int GetGlobalEdgeID(vtkDataSet data, int localID)
	{
		return vtkExodusIIReader_GetGlobalEdgeID_69(data?.GetCppThis() ?? default(HandleRef), localID);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalEdgeID_70(HandleRef data, int localID, int searchType);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static int GetGlobalEdgeID(vtkDataSet data, int localID, int searchType)
	{
		return vtkExodusIIReader_GetGlobalEdgeID_70(data?.GetCppThis() ?? default(HandleRef), localID, searchType);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetGlobalEdgeIdArrayName_71();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetGlobalEdgeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetGlobalEdgeIdArrayName_71());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalElementID_72(HandleRef data, int localID);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static int GetGlobalElementID(vtkDataSet data, int localID)
	{
		return vtkExodusIIReader_GetGlobalElementID_72(data?.GetCppThis() ?? default(HandleRef), localID);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalElementID_73(HandleRef data, int localID, int searchType);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static int GetGlobalElementID(vtkDataSet data, int localID, int searchType)
	{
		return vtkExodusIIReader_GetGlobalElementID_73(data?.GetCppThis() ?? default(HandleRef), localID, searchType);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetGlobalElementIdArrayName_74();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetGlobalElementIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetGlobalElementIdArrayName_74());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalFaceID_75(HandleRef data, int localID);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static int GetGlobalFaceID(vtkDataSet data, int localID)
	{
		return vtkExodusIIReader_GetGlobalFaceID_75(data?.GetCppThis() ?? default(HandleRef), localID);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalFaceID_76(HandleRef data, int localID, int searchType);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static int GetGlobalFaceID(vtkDataSet data, int localID, int searchType)
	{
		return vtkExodusIIReader_GetGlobalFaceID_76(data?.GetCppThis() ?? default(HandleRef), localID, searchType);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetGlobalFaceIdArrayName_77();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetGlobalFaceIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetGlobalFaceIdArrayName_77());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalNodeID_78(HandleRef data, int localID);

	/// <summary>
	/// Extra point data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id of the node.
	/// The id is relative to the entire data set.
	/// The name of the array is returned by GlobalNodeIdArrayName().
	/// </summary>
	public static int GetGlobalNodeID(vtkDataSet data, int localID)
	{
		return vtkExodusIIReader_GetGlobalNodeID_78(data?.GetCppThis() ?? default(HandleRef), localID);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalNodeID_79(HandleRef data, int localID, int searchType);

	/// <summary>
	/// Extra point data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id of the node.
	/// The id is relative to the entire data set.
	/// The name of the array is returned by GlobalNodeIdArrayName().
	/// </summary>
	public static int GetGlobalNodeID(vtkDataSet data, int localID, int searchType)
	{
		return vtkExodusIIReader_GetGlobalNodeID_79(data?.GetCppThis() ?? default(HandleRef), localID, searchType);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetGlobalNodeIdArrayName_80();

	/// <summary>
	/// Extra point data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id of the node.
	/// The id is relative to the entire data set.
	/// The name of the array is returned by GlobalNodeIdArrayName().
	/// </summary>
	public static string GetGlobalNodeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetGlobalNodeIdArrayName_80());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetGlobalResultArrayName_81(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetGlobalResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetGlobalResultArrayName_81(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetGlobalResultArrayStatus_82(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetGlobalResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetGlobalResultArrayStatus_82(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetHasModeShapes_83(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the Exodus sequence number corresponds to time steps or mode shapes.
	/// By default, HasModeShapes is false unless two time values in the Exodus file are identical,
	/// in which case it is true.
	/// </summary>
	public int GetHasModeShapes()
	{
		return vtkExodusIIReader_GetHasModeShapes_83(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetHierarchyArrayName_84(HandleRef pThis, int arrayIdx);

	/// <summary>
	/// By default all hierarchy entries are loaded. These methods allow
	/// the user to
	/// select which hierarchy entries they want to load.  You can get information
	/// about the hierarchy entries by first calling UpdateInformation, and using
	/// GetHierarchyArrayName ...
	/// these methods do not call functions in metaData. They call functions on
	/// the ExodusXMLParser since it seemed silly to duplicate all the information
	/// </summary>
	public string GetHierarchyArrayName(int arrayIdx)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetHierarchyArrayName_84(GetCppThis(), arrayIdx));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetHierarchyArrayStatus_85(HandleRef pThis, int index);

	/// <summary>
	/// By default all hierarchy entries are loaded. These methods allow
	/// the user to
	/// select which hierarchy entries they want to load.  You can get information
	/// about the hierarchy entries by first calling UpdateInformation, and using
	/// GetHierarchyArrayName ...
	/// these methods do not call functions in metaData. They call functions on
	/// the ExodusXMLParser since it seemed silly to duplicate all the information
	/// </summary>
	public int GetHierarchyArrayStatus(int index)
	{
		return vtkExodusIIReader_GetHierarchyArrayStatus_85(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetHierarchyArrayStatus_86(HandleRef pThis, string arg0);

	/// <summary>
	/// By default all hierarchy entries are loaded. These methods allow
	/// the user to
	/// select which hierarchy entries they want to load.  You can get information
	/// about the hierarchy entries by first calling UpdateInformation, and using
	/// GetHierarchyArrayName ...
	/// these methods do not call functions in metaData. They call functions on
	/// the ExodusXMLParser since it seemed silly to duplicate all the information
	/// </summary>
	public int GetHierarchyArrayStatus(string arg0)
	{
		return vtkExodusIIReader_GetHierarchyArrayStatus_86(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExodusIIReader_GetIgnoreFileTime_87(HandleRef pThis);

	/// <summary>
	/// When on, this option ignores the time values assigned to each time step in
	/// the file. This can be useful for Exodus files where different time steps
	/// are overloaded to represent different aspects of a data set rather than the
	/// data set at different time values.
	/// </summary>
	public bool GetIgnoreFileTime()
	{
		return (vtkExodusIIReader_GetIgnoreFileTime_87(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetImplicitEdgeIdArrayName_88();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetImplicitEdgeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetImplicitEdgeIdArrayName_88());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetImplicitElementIdArrayName_89();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetImplicitElementIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetImplicitElementIdArrayName_89());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetImplicitFaceIdArrayName_90();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetImplicitFaceIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetImplicitFaceIdArrayName_90());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetImplicitNodeIdArrayName_91();

	/// <summary>
	/// Extra point data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id of the node.
	/// The id is relative to the entire data set.
	/// The name of the array is returned by GlobalNodeIdArrayName().
	/// </summary>
	public static string GetImplicitNodeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetImplicitNodeIdArrayName_91());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExodusIIReader_GetMTime_92(HandleRef pThis);

	/// <summary>
	/// Return the object's MTime. This is overridden to include the timestamp of its internal class.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkExodusIIReader_GetMTime_92(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetMaterialArrayID_93(HandleRef pThis, string name);

	/// <summary>
	/// By default all materials are loaded. These methods allow the user to
	/// select which materials they want to load.  You can get information
	/// about the materials by first calling UpdateInformation, and using
	/// GetMaterialArrayName ...
	/// </summary>
	public int GetMaterialArrayID(string name)
	{
		return vtkExodusIIReader_GetMaterialArrayID_93(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetMaterialArrayName_94(HandleRef pThis, int arrayIdx);

	/// <summary>
	/// By default all materials are loaded. These methods allow the user to
	/// select which materials they want to load.  You can get information
	/// about the materials by first calling UpdateInformation, and using
	/// GetMaterialArrayName ...
	/// </summary>
	public string GetMaterialArrayName(int arrayIdx)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetMaterialArrayName_94(GetCppThis(), arrayIdx));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetMaterialArrayStatus_95(HandleRef pThis, int index);

	/// <summary>
	/// By default all materials are loaded. These methods allow the user to
	/// select which materials they want to load.  You can get information
	/// about the materials by first calling UpdateInformation, and using
	/// GetMaterialArrayName ...
	/// </summary>
	public int GetMaterialArrayStatus(int index)
	{
		return vtkExodusIIReader_GetMaterialArrayStatus_95(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetMaterialArrayStatus_96(HandleRef pThis, string arg0);

	/// <summary>
	/// By default all materials are loaded. These methods allow the user to
	/// select which materials they want to load.  You can get information
	/// about the materials by first calling UpdateInformation, and using
	/// GetMaterialArrayName ...
	/// </summary>
	public int GetMaterialArrayStatus(string arg0)
	{
		return vtkExodusIIReader_GetMaterialArrayStatus_96(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetMaxNameLength_97(HandleRef pThis);

	/// <summary>
	/// Get the max_name_length in the file. This is the amount of space allocated
	/// int the file for storing names of arrays, blocks, etc.
	/// </summary>
	public int GetMaxNameLength()
	{
		return vtkExodusIIReader_GetMaxNameLength_97(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkExodusIIReader_GetMetadataMTime_98(HandleRef pThis);

	/// <summary>
	/// Return the MTime of the internal data structure.
	/// This is really only intended for use by vtkPExodusIIReader in order
	/// to determine if the filename is newer than the metadata.
	/// </summary>
	public virtual ulong GetMetadataMTime()
	{
		return vtkExodusIIReader_GetMetadataMTime_98(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkExodusIIReader_GetModeShapeTime_99(HandleRef pThis);

	/// <summary>
	/// Set/Get the time used to animate mode shapes.
	/// This is a number between 0 and 1 that is used to scale the \a DisplacementMagnitude
	/// in a sinusoidal pattern. Specifically, the displacement vector for each vertex is scaled by
	/// \f$ \mathrm{DisplacementMagnitude} cos( 2\pi \mathrm{ModeShapeTime} ) \f$ before it is
	/// added to the vertex coordinates.
	/// </summary>
	public double GetModeShapeTime()
	{
		return vtkExodusIIReader_GetModeShapeTime_99(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetModeShapesRange_100(HandleRef pThis);

	/// <summary>
	/// Since ModeShapes are expected to run from [1,N] rather than [0, N-1],
	/// this method will return the TimeStepRange offset by 1. Note this method
	/// returns the potential mode shapes range irrespective of whether
	/// this-&gt;HasModeShapes is set to true.
	/// </summary>
	public virtual int[] GetModeShapesRange()
	{
		IntPtr intPtr = vtkExodusIIReader_GetModeShapesRange_100(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GetModeShapesRange_101(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Since ModeShapes are expected to run from [1,N] rather than [0, N-1],
	/// this method will return the TimeStepRange offset by 1. Note this method
	/// returns the potential mode shapes range irrespective of whether
	/// this-&gt;HasModeShapes is set to true.
	/// </summary>
	public virtual void GetModeShapesRange(ref int _arg1, ref int _arg2)
	{
		vtkExodusIIReader_GetModeShapesRange_101(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GetModeShapesRange_102(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Since ModeShapes are expected to run from [1,N] rather than [0, N-1],
	/// this method will return the TimeStepRange offset by 1. Note this method
	/// returns the potential mode shapes range irrespective of whether
	/// this-&gt;HasModeShapes is set to true.
	/// </summary>
	public virtual void GetModeShapesRange(IntPtr _arg)
	{
		vtkExodusIIReader_GetModeShapesRange_102(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetNodeMapArrayName_103(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetNodeMapArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetNodeMapArrayName_103(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNodeMapArrayStatus_104(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNodeMapArrayStatus(string name)
	{
		return vtkExodusIIReader_GetNodeMapArrayStatus_104(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetNodeSetArrayName_105(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetNodeSetArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetNodeSetArrayName_105(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNodeSetArrayStatus_106(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNodeSetArrayStatus(string name)
	{
		return vtkExodusIIReader_GetNodeSetArrayStatus_106(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetNodeSetResultArrayName_107(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetNodeSetResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetNodeSetResultArrayName_107(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNodeSetResultArrayStatus_108(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNodeSetResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetNodeSetResultArrayStatus_108(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfAssemblyArrays_109(HandleRef pThis);

	/// <summary>
	/// By default all assemblies are loaded. These methods allow the user to
	/// select which assemblies they want to load.  You can get information
	/// about the assemblies by first calling UpdateInformation, and using
	/// GetAssemblyArrayName ...
	/// </summary>
	public int GetNumberOfAssemblyArrays()
	{
		return vtkExodusIIReader_GetNumberOfAssemblyArrays_109(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfEdgeBlockArrays_110(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfEdgeBlockArrays()
	{
		return vtkExodusIIReader_GetNumberOfEdgeBlockArrays_110(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfEdgeMapArrays_111(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfEdgeMapArrays()
	{
		return vtkExodusIIReader_GetNumberOfEdgeMapArrays_111(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfEdgeResultArrays_112(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfEdgeResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfEdgeResultArrays_112(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfEdgeSetArrays_113(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfEdgeSetArrays()
	{
		return vtkExodusIIReader_GetNumberOfEdgeSetArrays_113(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfEdgeSetResultArrays_114(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfEdgeSetResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfEdgeSetResultArrays_114(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfEdgesInFile_115(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetNumberOfEdgesInFile()
	{
		return vtkExodusIIReader_GetNumberOfEdgesInFile_115(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfElementBlockArrays_116(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfElementBlockArrays()
	{
		return vtkExodusIIReader_GetNumberOfElementBlockArrays_116(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfElementMapArrays_117(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfElementMapArrays()
	{
		return vtkExodusIIReader_GetNumberOfElementMapArrays_117(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfElementResultArrays_118(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfElementResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfElementResultArrays_118(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfElementSetArrays_119(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfElementSetArrays()
	{
		return vtkExodusIIReader_GetNumberOfElementSetArrays_119(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfElementSetResultArrays_120(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfElementSetResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfElementSetResultArrays_120(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfElementsInFile_121(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetNumberOfElementsInFile()
	{
		return vtkExodusIIReader_GetNumberOfElementsInFile_121(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfEntriesInObject_122(HandleRef pThis, int objectType, int objectIndex);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetNumberOfEntriesInObject(int objectType, int objectIndex)
	{
		return vtkExodusIIReader_GetNumberOfEntriesInObject_122(GetCppThis(), objectType, objectIndex);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfFaceBlockArrays_123(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfFaceBlockArrays()
	{
		return vtkExodusIIReader_GetNumberOfFaceBlockArrays_123(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfFaceMapArrays_124(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfFaceMapArrays()
	{
		return vtkExodusIIReader_GetNumberOfFaceMapArrays_124(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfFaceResultArrays_125(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfFaceResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfFaceResultArrays_125(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfFaceSetArrays_126(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfFaceSetArrays()
	{
		return vtkExodusIIReader_GetNumberOfFaceSetArrays_126(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfFaceSetResultArrays_127(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfFaceSetResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfFaceSetResultArrays_127(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfFacesInFile_128(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetNumberOfFacesInFile()
	{
		return vtkExodusIIReader_GetNumberOfFacesInFile_128(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIReader_GetNumberOfGenerationsFromBase_129(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExodusIIReader_GetNumberOfGenerationsFromBase_129(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIReader_GetNumberOfGenerationsFromBaseType_130(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExodusIIReader_GetNumberOfGenerationsFromBaseType_130(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfGlobalResultArrays_131(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfGlobalResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfGlobalResultArrays_131(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfHierarchyArrays_132(HandleRef pThis);

	/// <summary>
	/// By default all hierarchy entries are loaded. These methods allow
	/// the user to
	/// select which hierarchy entries they want to load.  You can get information
	/// about the hierarchy entries by first calling UpdateInformation, and using
	/// GetHierarchyArrayName ...
	/// these methods do not call functions in metaData. They call functions on
	/// the ExodusXMLParser since it seemed silly to duplicate all the information
	/// </summary>
	public int GetNumberOfHierarchyArrays()
	{
		return vtkExodusIIReader_GetNumberOfHierarchyArrays_132(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfMaterialArrays_133(HandleRef pThis);

	/// <summary>
	/// By default all materials are loaded. These methods allow the user to
	/// select which materials they want to load.  You can get information
	/// about the materials by first calling UpdateInformation, and using
	/// GetMaterialArrayName ...
	/// </summary>
	public int GetNumberOfMaterialArrays()
	{
		return vtkExodusIIReader_GetNumberOfMaterialArrays_133(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfNodeMapArrays_134(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfNodeMapArrays()
	{
		return vtkExodusIIReader_GetNumberOfNodeMapArrays_134(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfNodeSetArrays_135(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfNodeSetArrays()
	{
		return vtkExodusIIReader_GetNumberOfNodeSetArrays_135(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfNodeSetResultArrays_136(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfNodeSetResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfNodeSetResultArrays_136(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfNodes_137(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetNumberOfNodes()
	{
		return vtkExodusIIReader_GetNumberOfNodes_137(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfNodesInFile_138(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetNumberOfNodesInFile()
	{
		return vtkExodusIIReader_GetNumberOfNodesInFile_138(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfObjectArrayComponents_139(HandleRef pThis, int objectType, int arrayIndex);

	/// <summary>
	/// By default arrays are not loaded.  These methods allow the user to select
	/// which arrays they want to load.  You can get information about the arrays
	/// by first calling UpdateInformation, and using GetPointArrayName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetNumberOfObjectArrayComponents(int objectType, int arrayIndex)
	{
		return vtkExodusIIReader_GetNumberOfObjectArrayComponents_139(GetCppThis(), objectType, arrayIndex);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfObjectArrays_140(HandleRef pThis, int objectType);

	/// <summary>
	/// By default arrays are not loaded.  These methods allow the user to select
	/// which arrays they want to load.  You can get information about the arrays
	/// by first calling UpdateInformation, and using GetPointArrayName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetNumberOfObjectArrays(int objectType)
	{
		return vtkExodusIIReader_GetNumberOfObjectArrays_140(GetCppThis(), objectType);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfObjectAttributes_141(HandleRef pThis, int objectType, int objectIndex);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetNumberOfObjectAttributes(int objectType, int objectIndex)
	{
		return vtkExodusIIReader_GetNumberOfObjectAttributes_141(GetCppThis(), objectType, objectIndex);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfObjects_142(HandleRef pThis, int objectType);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetNumberOfObjects(int objectType)
	{
		return vtkExodusIIReader_GetNumberOfObjects_142(GetCppThis(), objectType);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfPartArrays_143(HandleRef pThis);

	/// <summary>
	/// By default all parts are loaded. These methods allow the user to select
	/// which parts they want to load.  You can get information about the parts
	/// by first calling UpdateInformation, and using GetPartArrayName ...
	/// </summary>
	public int GetNumberOfPartArrays()
	{
		return vtkExodusIIReader_GetNumberOfPartArrays_143(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfPointResultArrays_144(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfPointResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfPointResultArrays_144(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfSideSetArrays_145(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfSideSetArrays()
	{
		return vtkExodusIIReader_GetNumberOfSideSetArrays_145(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfSideSetResultArrays_146(HandleRef pThis);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetNumberOfSideSetResultArrays()
	{
		return vtkExodusIIReader_GetNumberOfSideSetResultArrays_146(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetNumberOfTimeSteps_147(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetNumberOfTimeSteps()
	{
		return vtkExodusIIReader_GetNumberOfTimeSteps_147(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectArrayIndex_148(HandleRef pThis, int objectType, string arrayName);

	/// <summary>
	/// By default arrays are not loaded.  These methods allow the user to select
	/// which arrays they want to load.  You can get information about the arrays
	/// by first calling UpdateInformation, and using GetPointArrayName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetObjectArrayIndex(int objectType, string arrayName)
	{
		return vtkExodusIIReader_GetObjectArrayIndex_148(GetCppThis(), objectType, arrayName);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetObjectArrayName_149(HandleRef pThis, int objectType, int arrayIndex);

	/// <summary>
	/// By default arrays are not loaded.  These methods allow the user to select
	/// which arrays they want to load.  You can get information about the arrays
	/// by first calling UpdateInformation, and using GetPointArrayName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public string GetObjectArrayName(int objectType, int arrayIndex)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetObjectArrayName_149(GetCppThis(), objectType, arrayIndex));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectArrayStatus_150(HandleRef pThis, int objectType, int arrayIndex);

	/// <summary>
	/// By default arrays are not loaded.  These methods allow the user to select
	/// which arrays they want to load.  You can get information about the arrays
	/// by first calling UpdateInformation, and using GetPointArrayName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetObjectArrayStatus(int objectType, int arrayIndex)
	{
		return vtkExodusIIReader_GetObjectArrayStatus_150(GetCppThis(), objectType, arrayIndex);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectArrayStatus_151(HandleRef pThis, int objectType, string arrayName);

	/// <summary>
	/// By default arrays are not loaded.  These methods allow the user to select
	/// which arrays they want to load.  You can get information about the arrays
	/// by first calling UpdateInformation, and using GetPointArrayName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetObjectArrayStatus(int objectType, string arrayName)
	{
		return vtkExodusIIReader_GetObjectArrayStatus_151(GetCppThis(), objectType, arrayName);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectAttributeIndex_152(HandleRef pThis, int objectType, int objectIndex, string attribName);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetObjectAttributeIndex(int objectType, int objectIndex, string attribName)
	{
		return vtkExodusIIReader_GetObjectAttributeIndex_152(GetCppThis(), objectType, objectIndex, attribName);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetObjectAttributeName_153(HandleRef pThis, int objectType, int objectIndex, int attribIndex);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public string GetObjectAttributeName(int objectType, int objectIndex, int attribIndex)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetObjectAttributeName_153(GetCppThis(), objectType, objectIndex, attribIndex));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectAttributeStatus_154(HandleRef pThis, int objectType, int objectIndex, int attribIndex);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetObjectAttributeStatus(int objectType, int objectIndex, int attribIndex)
	{
		return vtkExodusIIReader_GetObjectAttributeStatus_154(GetCppThis(), objectType, objectIndex, attribIndex);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectAttributeStatus_155(HandleRef pThis, int objectType, int objectIndex, string attribName);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public int GetObjectAttributeStatus(int objectType, int objectIndex, string attribName)
	{
		return vtkExodusIIReader_GetObjectAttributeStatus_155(GetCppThis(), objectType, objectIndex, attribName);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectId_156(HandleRef pThis, int objectType, int objectIndex);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetObjectId(int objectType, int objectIndex)
	{
		return vtkExodusIIReader_GetObjectId_156(GetCppThis(), objectType, objectIndex);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetObjectIdArrayName_157();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public static string GetObjectIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetObjectIdArrayName_157());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectIndex_158(HandleRef pThis, int objectType, string objectName);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetObjectIndex(int objectType, string objectName)
	{
		return vtkExodusIIReader_GetObjectIndex_158(GetCppThis(), objectType, objectName);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectIndex_159(HandleRef pThis, int objectType, int id);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetObjectIndex(int objectType, int id)
	{
		return vtkExodusIIReader_GetObjectIndex_159(GetCppThis(), objectType, id);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetObjectName_160(HandleRef pThis, int objectType, int objectIndex);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public string GetObjectName(int objectType, int objectIndex)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetObjectName_160(GetCppThis(), objectType, objectIndex));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectStatus_161(HandleRef pThis, int objectType, int objectIndex);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetObjectStatus(int objectType, int objectIndex)
	{
		return vtkExodusIIReader_GetObjectStatus_161(GetCppThis(), objectType, objectIndex);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectStatus_162(HandleRef pThis, int objectType, string objectName);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetObjectStatus(int objectType, string objectName)
	{
		return vtkExodusIIReader_GetObjectStatus_162(GetCppThis(), objectType, objectName);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetObjectTypeFromName_163(HandleRef pThis, string name);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public int GetObjectTypeFromName(string name)
	{
		return vtkExodusIIReader_GetObjectTypeFromName_163(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetObjectTypeName_164(HandleRef pThis, int arg0);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public string GetObjectTypeName(int arg0)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetObjectTypeName_164(GetCppThis(), arg0));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetPartArrayID_165(HandleRef pThis, string name);

	/// <summary>
	/// By default all parts are loaded. These methods allow the user to select
	/// which parts they want to load.  You can get information about the parts
	/// by first calling UpdateInformation, and using GetPartArrayName ...
	/// </summary>
	public int GetPartArrayID(string name)
	{
		return vtkExodusIIReader_GetPartArrayID_165(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetPartArrayName_166(HandleRef pThis, int arrayIdx);

	/// <summary>
	/// By default all parts are loaded. These methods allow the user to select
	/// which parts they want to load.  You can get information about the parts
	/// by first calling UpdateInformation, and using GetPartArrayName ...
	/// </summary>
	public string GetPartArrayName(int arrayIdx)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetPartArrayName_166(GetCppThis(), arrayIdx));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetPartArrayStatus_167(HandleRef pThis, int index);

	/// <summary>
	/// By default all parts are loaded. These methods allow the user to select
	/// which parts they want to load.  You can get information about the parts
	/// by first calling UpdateInformation, and using GetPartArrayName ...
	/// </summary>
	public int GetPartArrayStatus(int index)
	{
		return vtkExodusIIReader_GetPartArrayStatus_167(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetPartArrayStatus_168(HandleRef pThis, string arg0);

	/// <summary>
	/// By default all parts are loaded. These methods allow the user to select
	/// which parts they want to load.  You can get information about the parts
	/// by first calling UpdateInformation, and using GetPartArrayName ...
	/// </summary>
	public int GetPartArrayStatus(string arg0)
	{
		return vtkExodusIIReader_GetPartArrayStatus_168(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetPartBlockInfo_169(HandleRef pThis, int arrayIdx);

	/// <summary>
	/// By default all parts are loaded. These methods allow the user to select
	/// which parts they want to load.  You can get information about the parts
	/// by first calling UpdateInformation, and using GetPartArrayName ...
	/// </summary>
	public string GetPartBlockInfo(int arrayIdx)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetPartBlockInfo_169(GetCppThis(), arrayIdx));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetPedigreeEdgeIdArrayName_170();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetPedigreeEdgeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetPedigreeEdgeIdArrayName_170());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetPedigreeElementIdArrayName_171();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetPedigreeElementIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetPedigreeElementIdArrayName_171());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetPedigreeFaceIdArrayName_172();

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is off.  The value of the array is the integer global id of the cell.
	/// The name of the array is returned by GetGlobalElementIdArrayName()
	/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
	/// </summary>
	public static string GetPedigreeFaceIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetPedigreeFaceIdArrayName_172());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetPedigreeNodeIdArrayName_173();

	/// <summary>
	/// Extra point data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id of the node.
	/// The id is relative to the entire data set.
	/// The name of the array is returned by GlobalNodeIdArrayName().
	/// </summary>
	public static string GetPedigreeNodeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetPedigreeNodeIdArrayName_173());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetPointResultArrayName_174(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetPointResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetPointResultArrayName_174(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetPointResultArrayStatus_175(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetPointResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetPointResultArrayStatus_175(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetSIL_176(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// SIL describes organization of/relationships between classifications
	/// eg. blocks/materials/hierarchies.
	/// </summary>
	public vtkGraph GetSIL()
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReader_GetSIL_176(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraph2 = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraph2.Register(null);
			}
		}
		return vtkGraph2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetSILUpdateStamp_177(HandleRef pThis);

	/// <summary>
	/// Every time the SIL is updated a this will return a different value.
	/// </summary>
	public virtual int GetSILUpdateStamp()
	{
		return vtkExodusIIReader_GetSILUpdateStamp_177(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetSideSetArrayName_178(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetSideSetArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetSideSetArrayName_178(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetSideSetArrayStatus_179(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetSideSetArrayStatus(string name)
	{
		return vtkExodusIIReader_GetSideSetArrayStatus_179(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetSideSetResultArrayName_180(HandleRef pThis, int index);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public string GetSideSetResultArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetSideSetResultArrayName_180(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetSideSetResultArrayStatus_181(HandleRef pThis, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetSideSetResultArrayStatus(string name)
	{
		return vtkExodusIIReader_GetSideSetResultArrayStatus_181(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetSideSetSourceElementIdArrayName_182();

	/// <summary>
	/// Get the name of the array that stores the mapping from side set
	/// cells back to the global id of the elements they bound.
	/// </summary>
	public static string GetSideSetSourceElementIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetSideSetSourceElementIdArrayName_182());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetSideSetSourceElementSideArrayName_183();

	/// <summary>
	/// Get the name of the array that stores the mapping from side set
	/// cells back to the canonical side of the elements they bound.
	/// </summary>
	public static string GetSideSetSourceElementSideArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetSideSetSourceElementSideArrayName_183());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExodusIIReader_GetSqueezePoints_184(HandleRef pThis);

	/// <summary>
	/// Should the reader output only points used by elements in the output mesh,
	/// or all the points. Outputting all the points is much faster since the
	/// point array can be read straight from disk and the mesh connectivity need
	/// not be altered. Squeezing the points down to the minimum set needed to
	/// produce the output mesh is useful for glyphing and other point-based
	/// operations. On large parallel datasets, loading all the points implies
	/// loading all the points on all processes and performing subsequent
	/// filtering on a much larger set.
	///
	/// By default, SqueezePoints is true for backwards compatibility.
	/// </summary>
	public bool GetSqueezePoints()
	{
		return (vtkExodusIIReader_GetSqueezePoints_184(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetTimeSeriesData_185(HandleRef pThis, int ID, string vName, string vType, HandleRef result);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetTimeSeriesData(int ID, string vName, string vType, vtkFloatArray result)
	{
		return vtkExodusIIReader_GetTimeSeriesData_185(GetCppThis(), ID, vName, vType, result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetTimeStep_186(HandleRef pThis);

	/// <summary>
	/// Which TimeStep to read.
	/// </summary>
	public virtual int GetTimeStep()
	{
		return vtkExodusIIReader_GetTimeStep_186(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetTimeStepRange_187(HandleRef pThis);

	/// <summary>
	/// Returns the available range of valid integer time steps.
	/// Note this method returns the potential timesteps range irrespective of
	/// whether this-&gt;HasModeShapes is set to false.
	/// </summary>
	public virtual int[] GetTimeStepRange()
	{
		IntPtr intPtr = vtkExodusIIReader_GetTimeStepRange_187(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GetTimeStepRange_188(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Returns the available range of valid integer time steps.
	/// Note this method returns the potential timesteps range irrespective of
	/// whether this-&gt;HasModeShapes is set to false.
	/// </summary>
	public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
	{
		vtkExodusIIReader_GetTimeStepRange_188(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_GetTimeStepRange_189(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Returns the available range of valid integer time steps.
	/// Note this method returns the potential timesteps range irrespective of
	/// whether this-&gt;HasModeShapes is set to false.
	/// </summary>
	public virtual void GetTimeStepRange(IntPtr _arg)
	{
		vtkExodusIIReader_GetTimeStepRange_189(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetTitle_190(HandleRef pThis);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public string GetTitle()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetTitle_190(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIReader_GetTotalNumberOfEdges_191(HandleRef pThis);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public virtual long GetTotalNumberOfEdges()
	{
		return vtkExodusIIReader_GetTotalNumberOfEdges_191(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIReader_GetTotalNumberOfElements_192(HandleRef pThis);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public virtual long GetTotalNumberOfElements()
	{
		return vtkExodusIIReader_GetTotalNumberOfElements_192(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIReader_GetTotalNumberOfFaces_193(HandleRef pThis);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public virtual long GetTotalNumberOfFaces()
	{
		return vtkExodusIIReader_GetTotalNumberOfFaces_193(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIReader_GetTotalNumberOfNodes_194(HandleRef pThis);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public virtual long GetTotalNumberOfNodes()
	{
		return vtkExodusIIReader_GetTotalNumberOfNodes_194(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExodusIIReader_GetUseLegacyBlockNames_195(HandleRef pThis);

	/// <summary>
	/// In previous versions, the reader added the type of elements in the block to
	/// the block name when no name was provided for the block. This has issues
	/// with consistency when naming blocks across ranks for partitioned files
	/// (see paraview/paraview#19110), hence we no longer do that. For legacy
	/// pipelines, one can enable the old behavior by setting this flag to true.
	/// </summary>
	public virtual bool GetUseLegacyBlockNames()
	{
		return (vtkExodusIIReader_GetUseLegacyBlockNames_195(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_GetVariableID_196(HandleRef pThis, string type, string name);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public int GetVariableID(string type, string name)
	{
		return vtkExodusIIReader_GetVariableID_196(GetCppThis(), type, name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_GetXMLFileName_197(HandleRef pThis);

	/// <summary>
	/// Specify file name of the xml file.
	/// </summary>
	public virtual string GetXMLFileName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIReader_GetXMLFileName_197(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_HasModeShapesOff_198(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the Exodus sequence number corresponds to time steps or mode shapes.
	/// By default, HasModeShapes is false unless two time values in the Exodus file are identical,
	/// in which case it is true.
	/// </summary>
	public virtual void HasModeShapesOff()
	{
		vtkExodusIIReader_HasModeShapesOff_198(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_HasModeShapesOn_199(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the Exodus sequence number corresponds to time steps or mode shapes.
	/// By default, HasModeShapes is false unless two time values in the Exodus file are identical,
	/// in which case it is true.
	/// </summary>
	public virtual void HasModeShapesOn()
	{
		vtkExodusIIReader_HasModeShapesOn_199(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_IgnoreFileTimeOff_200(HandleRef pThis);

	/// <summary>
	/// When on, this option ignores the time values assigned to each time step in
	/// the file. This can be useful for Exodus files where different time steps
	/// are overloaded to represent different aspects of a data set rather than the
	/// data set at different time values.
	/// </summary>
	public virtual void IgnoreFileTimeOff()
	{
		vtkExodusIIReader_IgnoreFileTimeOff_200(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_IgnoreFileTimeOn_201(HandleRef pThis);

	/// <summary>
	/// When on, this option ignores the time values assigned to each time step in
	/// the file. This can be useful for Exodus files where different time steps
	/// are overloaded to represent different aspects of a data set rather than the
	/// data set at different time values.
	/// </summary>
	public virtual void IgnoreFileTimeOn()
	{
		vtkExodusIIReader_IgnoreFileTimeOn_201(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_IsA_202(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExodusIIReader_IsA_202(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_IsTypeOf_203(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExodusIIReader_IsTypeOf_203(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReader_IsValidVariable_204(HandleRef pThis, string type, string name);

	/// <summary>
	/// return boolean indicating whether the type,name is a valid variable
	/// </summary>
	public int IsValidVariable(string type, string name)
	{
		return vtkExodusIIReader_IsValidVariable_204(GetCppThis(), type, name);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_NewInstance_206(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExodusIIReader NewInstance()
	{
		vtkExodusIIReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReader_NewInstance_206(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_Reset_207(HandleRef pThis);

	/// <summary>
	/// Reset the user-specified parameters and flush internal arrays
	/// so that the reader state is just as it was after the reader was
	/// instantiated.
	///
	/// It doesn't make sense to let users reset only the internal state;
	/// both the settings and the state are changed by this call.
	/// </summary>
	public void Reset()
	{
		vtkExodusIIReader_Reset_207(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_ResetCache_208(HandleRef pThis);

	/// <summary>
	/// Clears out the cache entries.
	/// </summary>
	public void ResetCache()
	{
		vtkExodusIIReader_ResetCache_208(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_ResetSettings_209(HandleRef pThis);

	/// <summary>
	/// Reset the user-specified parameters to their default values.
	/// The only settings not affected are the filename and/or pattern
	/// because these have no default.
	///
	/// Resetting the settings but not the state allows users to
	/// keep the active cache but return to initial array selections, etc.
	/// </summary>
	public void ResetSettings()
	{
		vtkExodusIIReader_ResetSettings_209(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReader_SafeDownCast_210(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExodusIIReader SafeDownCast(vtkObjectBase o)
	{
		vtkExodusIIReader vtkExodusIIReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReader_SafeDownCast_210(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExodusIIReader2 = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExodusIIReader2.Register(null);
			}
		}
		return vtkExodusIIReader2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetAllArrayStatus_211(HandleRef pThis, int otype, int status);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetAllArrayStatus(int otype, int status)
	{
		vtkExodusIIReader_SetAllArrayStatus_211(GetCppThis(), otype, status);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetAnimateModeShapes_212(HandleRef pThis, int flag);

	/// <summary>
	/// If this flag is on (the default) and HasModeShapes is also on, then this
	/// reader will report a continuous time range [0,1] and animate the
	/// displacements in a periodic sinusoid.  If this flag is off and
	/// HasModeShapes is on, this reader ignores time.  This flag has no effect if
	/// HasModeShapes is off.
	/// </summary>
	public virtual void SetAnimateModeShapes(int flag)
	{
		vtkExodusIIReader_SetAnimateModeShapes_212(GetCppThis(), flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetApplyDisplacements_213(HandleRef pThis, int d);

	/// <summary>
	/// Geometric locations can include displacements.  By default,
	/// this is ON.  The nodal positions are 'displaced' by the
	/// standard exodus displacement vector. If displacements
	/// are turned 'off', the user can explicitly add them by
	/// applying a warp filter.
	/// </summary>
	public virtual void SetApplyDisplacements(int d)
	{
		vtkExodusIIReader_SetApplyDisplacements_213(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetAssemblyArrayStatus_214(HandleRef pThis, int index, int flag);

	/// <summary>
	/// By default all assemblies are loaded. These methods allow the user to
	/// select which assemblies they want to load.  You can get information
	/// about the assemblies by first calling UpdateInformation, and using
	/// GetAssemblyArrayName ...
	/// </summary>
	public void SetAssemblyArrayStatus(int index, int flag)
	{
		vtkExodusIIReader_SetAssemblyArrayStatus_214(GetCppThis(), index, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetAssemblyArrayStatus_215(HandleRef pThis, string arg0, int flag);

	/// <summary>
	/// By default all assemblies are loaded. These methods allow the user to
	/// select which assemblies they want to load.  You can get information
	/// about the assemblies by first calling UpdateInformation, and using
	/// GetAssemblyArrayName ...
	/// </summary>
	public void SetAssemblyArrayStatus(string arg0, int flag)
	{
		vtkExodusIIReader_SetAssemblyArrayStatus_215(GetCppThis(), arg0, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetCacheSize_216(HandleRef pThis, double CacheSize);

	/// <summary>
	/// Set the size of the cache in MiB.
	/// </summary>
	public void SetCacheSize(double CacheSize)
	{
		vtkExodusIIReader_SetCacheSize_216(GetCppThis(), CacheSize);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetDisplacementMagnitude_217(HandleRef pThis, float s);

	/// <summary>
	/// Geometric locations can include displacements.  By default,
	/// this is ON.  The nodal positions are 'displaced' by the
	/// standard exodus displacement vector. If displacements
	/// are turned 'off', the user can explicitly add them by
	/// applying a warp filter.
	/// </summary>
	public virtual void SetDisplacementMagnitude(float s)
	{
		vtkExodusIIReader_SetDisplacementMagnitude_217(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetDisplayType_218(HandleRef pThis, int type);

	/// <summary>
	/// By default all hierarchy entries are loaded. These methods allow
	/// the user to
	/// select which hierarchy entries they want to load.  You can get information
	/// about the hierarchy entries by first calling UpdateInformation, and using
	/// GetHierarchyArrayName ...
	/// these methods do not call functions in metaData. They call functions on
	/// the ExodusXMLParser since it seemed silly to duplicate all the information
	/// </summary>
	public virtual void SetDisplayType(int type)
	{
		vtkExodusIIReader_SetDisplayType_218(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetEdgeBlockArrayStatus_219(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetEdgeBlockArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetEdgeBlockArrayStatus_219(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetEdgeMapArrayStatus_220(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetEdgeMapArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetEdgeMapArrayStatus_220(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetEdgeResultArrayStatus_221(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetEdgeResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetEdgeResultArrayStatus_221(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetEdgeSetArrayStatus_222(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetEdgeSetArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetEdgeSetArrayStatus_222(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetEdgeSetResultArrayStatus_223(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetEdgeSetResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetEdgeSetResultArrayStatus_223(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetElementBlockArrayStatus_224(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetElementBlockArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetElementBlockArrayStatus_224(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetElementMapArrayStatus_225(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetElementMapArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetElementMapArrayStatus_225(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetElementResultArrayStatus_226(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetElementResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetElementResultArrayStatus_226(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetElementSetArrayStatus_227(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetElementSetArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetElementSetArrayStatus_227(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetElementSetResultArrayStatus_228(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetElementSetResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetElementSetResultArrayStatus_228(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetFaceBlockArrayStatus_229(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetFaceBlockArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetFaceBlockArrayStatus_229(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetFaceMapArrayStatus_230(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetFaceMapArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetFaceMapArrayStatus_230(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetFaceResultArrayStatus_231(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetFaceResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetFaceResultArrayStatus_231(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetFaceSetArrayStatus_232(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetFaceSetArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetFaceSetArrayStatus_232(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetFaceSetResultArrayStatus_233(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetFaceSetResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetFaceSetResultArrayStatus_233(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetFileId_234(HandleRef pThis, int f);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void SetFileId(int f)
	{
		vtkExodusIIReader_SetFileId_234(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetFileName_235(HandleRef pThis, string fname);

	/// <summary>
	/// Specify file name of the Exodus file.
	/// </summary>
	public virtual void SetFileName(string fname)
	{
		vtkExodusIIReader_SetFileName_235(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetGenerateFileIdArray_236(HandleRef pThis, int f);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void SetGenerateFileIdArray(int f)
	{
		vtkExodusIIReader_SetGenerateFileIdArray_236(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetGenerateGlobalElementIdArray_237(HandleRef pThis, int g);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void SetGenerateGlobalElementIdArray(int g)
	{
		vtkExodusIIReader_SetGenerateGlobalElementIdArray_237(GetCppThis(), g);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetGenerateGlobalNodeIdArray_238(HandleRef pThis, int g);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void SetGenerateGlobalNodeIdArray(int g)
	{
		vtkExodusIIReader_SetGenerateGlobalNodeIdArray_238(GetCppThis(), g);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetGenerateImplicitElementIdArray_239(HandleRef pThis, int g);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void SetGenerateImplicitElementIdArray(int g)
	{
		vtkExodusIIReader_SetGenerateImplicitElementIdArray_239(GetCppThis(), g);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetGenerateImplicitNodeIdArray_240(HandleRef pThis, int g);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void SetGenerateImplicitNodeIdArray(int g)
	{
		vtkExodusIIReader_SetGenerateImplicitNodeIdArray_240(GetCppThis(), g);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetGenerateObjectIdCellArray_241(HandleRef pThis, int g);

	/// <summary>
	/// Extra cell data array that can be generated.  By default, this array
	/// is ON.  The value of the array is the integer id found
	/// in the exodus file. The name of the array is returned by
	/// GetBlockIdArrayName(). For cells representing elements from
	/// an Exodus element block, this is set to the element block ID. For
	/// cells representing edges from an Exodus edge block, this is the
	/// edge block ID. Similarly, this is the face block ID for cells
	/// representing faces from an Exodus face block. The same holds
	/// for cells representing entries of node, edge, face, side, and element sets.
	/// </summary>
	public virtual void SetGenerateObjectIdCellArray(int g)
	{
		vtkExodusIIReader_SetGenerateObjectIdCellArray_241(GetCppThis(), g);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetGlobalResultArrayStatus_242(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetGlobalResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetGlobalResultArrayStatus_242(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetHasModeShapes_243(HandleRef pThis, int ms);

	/// <summary>
	/// Set/Get whether the Exodus sequence number corresponds to time steps or mode shapes.
	/// By default, HasModeShapes is false unless two time values in the Exodus file are identical,
	/// in which case it is true.
	/// </summary>
	public virtual void SetHasModeShapes(int ms)
	{
		vtkExodusIIReader_SetHasModeShapes_243(GetCppThis(), ms);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetHierarchyArrayStatus_244(HandleRef pThis, int index, int flag);

	/// <summary>
	/// By default all hierarchy entries are loaded. These methods allow
	/// the user to
	/// select which hierarchy entries they want to load.  You can get information
	/// about the hierarchy entries by first calling UpdateInformation, and using
	/// GetHierarchyArrayName ...
	/// these methods do not call functions in metaData. They call functions on
	/// the ExodusXMLParser since it seemed silly to duplicate all the information
	/// </summary>
	public void SetHierarchyArrayStatus(int index, int flag)
	{
		vtkExodusIIReader_SetHierarchyArrayStatus_244(GetCppThis(), index, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetHierarchyArrayStatus_245(HandleRef pThis, string arg0, int flag);

	/// <summary>
	/// By default all hierarchy entries are loaded. These methods allow
	/// the user to
	/// select which hierarchy entries they want to load.  You can get information
	/// about the hierarchy entries by first calling UpdateInformation, and using
	/// GetHierarchyArrayName ...
	/// these methods do not call functions in metaData. They call functions on
	/// the ExodusXMLParser since it seemed silly to duplicate all the information
	/// </summary>
	public void SetHierarchyArrayStatus(string arg0, int flag)
	{
		vtkExodusIIReader_SetHierarchyArrayStatus_245(GetCppThis(), arg0, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetIgnoreFileTime_246(HandleRef pThis, byte flag);

	/// <summary>
	/// When on, this option ignores the time values assigned to each time step in
	/// the file. This can be useful for Exodus files where different time steps
	/// are overloaded to represent different aspects of a data set rather than the
	/// data set at different time values.
	/// </summary>
	public virtual void SetIgnoreFileTime(bool flag)
	{
		vtkExodusIIReader_SetIgnoreFileTime_246(GetCppThis(), (byte)(flag ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetMaterialArrayStatus_247(HandleRef pThis, int index, int flag);

	/// <summary>
	/// By default all materials are loaded. These methods allow the user to
	/// select which materials they want to load.  You can get information
	/// about the materials by first calling UpdateInformation, and using
	/// GetMaterialArrayName ...
	/// </summary>
	public void SetMaterialArrayStatus(int index, int flag)
	{
		vtkExodusIIReader_SetMaterialArrayStatus_247(GetCppThis(), index, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetMaterialArrayStatus_248(HandleRef pThis, string arg0, int flag);

	/// <summary>
	/// By default all materials are loaded. These methods allow the user to
	/// select which materials they want to load.  You can get information
	/// about the materials by first calling UpdateInformation, and using
	/// GetMaterialArrayName ...
	/// </summary>
	public void SetMaterialArrayStatus(string arg0, int flag)
	{
		vtkExodusIIReader_SetMaterialArrayStatus_248(GetCppThis(), arg0, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetModeShape_249(HandleRef pThis, int val);

	/// <summary>
	/// Convenience method to set the mode-shape which is same as
	/// this-&gt;SetTimeStep(val-1);
	/// </summary>
	public void SetModeShape(int val)
	{
		vtkExodusIIReader_SetModeShape_249(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetModeShapeTime_250(HandleRef pThis, double phase);

	/// <summary>
	/// Set/Get the time used to animate mode shapes.
	/// This is a number between 0 and 1 that is used to scale the \a DisplacementMagnitude
	/// in a sinusoidal pattern. Specifically, the displacement vector for each vertex is scaled by
	/// \f$ \mathrm{DisplacementMagnitude} cos( 2\pi \mathrm{ModeShapeTime} ) \f$ before it is
	/// added to the vertex coordinates.
	/// </summary>
	public virtual void SetModeShapeTime(double phase)
	{
		vtkExodusIIReader_SetModeShapeTime_250(GetCppThis(), phase);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetNodeMapArrayStatus_251(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetNodeMapArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetNodeMapArrayStatus_251(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetNodeSetArrayStatus_252(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetNodeSetArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetNodeSetArrayStatus_252(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetNodeSetResultArrayStatus_253(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetNodeSetResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetNodeSetResultArrayStatus_253(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetObjectArrayStatus_254(HandleRef pThis, int objectType, int arrayIndex, int status);

	/// <summary>
	/// By default arrays are not loaded.  These methods allow the user to select
	/// which arrays they want to load.  You can get information about the arrays
	/// by first calling UpdateInformation, and using GetPointArrayName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public void SetObjectArrayStatus(int objectType, int arrayIndex, int status)
	{
		vtkExodusIIReader_SetObjectArrayStatus_254(GetCppThis(), objectType, arrayIndex, status);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetObjectArrayStatus_255(HandleRef pThis, int objectType, string arrayName, int status);

	/// <summary>
	/// By default arrays are not loaded.  These methods allow the user to select
	/// which arrays they want to load.  You can get information about the arrays
	/// by first calling UpdateInformation, and using GetPointArrayName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public void SetObjectArrayStatus(int objectType, string arrayName, int status)
	{
		vtkExodusIIReader_SetObjectArrayStatus_255(GetCppThis(), objectType, arrayName, status);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetObjectAttributeStatus_256(HandleRef pThis, int objectType, int objectIndex, int attribIndex, int status);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public void SetObjectAttributeStatus(int objectType, int objectIndex, int attribIndex, int status)
	{
		vtkExodusIIReader_SetObjectAttributeStatus_256(GetCppThis(), objectType, objectIndex, attribIndex, status);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetObjectAttributeStatus_257(HandleRef pThis, int objectType, int objectIndex, string attribName, int status);

	/// <summary>
	/// By default attributes are not loaded.  These methods allow the user to select
	/// which attributes they want to load.  You can get information about the attributes
	/// by first calling UpdateInformation, and using GetObjectAttributeName ...
	/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
	/// </summary>
	public void SetObjectAttributeStatus(int objectType, int objectIndex, string attribName, int status)
	{
		vtkExodusIIReader_SetObjectAttributeStatus_257(GetCppThis(), objectType, objectIndex, attribName, status);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetObjectStatus_258(HandleRef pThis, int objectType, int objectIndex, int status);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public void SetObjectStatus(int objectType, int objectIndex, int status)
	{
		vtkExodusIIReader_SetObjectStatus_258(GetCppThis(), objectType, objectIndex, status);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetObjectStatus_259(HandleRef pThis, int objectType, string objectName, int status);

	/// <summary>
	/// Access to meta data generated by UpdateInformation.
	/// </summary>
	public void SetObjectStatus(int objectType, string objectName, int status)
	{
		vtkExodusIIReader_SetObjectStatus_259(GetCppThis(), objectType, objectName, status);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetPartArrayStatus_260(HandleRef pThis, int index, int flag);

	/// <summary>
	/// By default all parts are loaded. These methods allow the user to select
	/// which parts they want to load.  You can get information about the parts
	/// by first calling UpdateInformation, and using GetPartArrayName ...
	/// </summary>
	public void SetPartArrayStatus(int index, int flag)
	{
		vtkExodusIIReader_SetPartArrayStatus_260(GetCppThis(), index, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetPartArrayStatus_261(HandleRef pThis, string arg0, int flag);

	/// <summary>
	/// By default all parts are loaded. These methods allow the user to select
	/// which parts they want to load.  You can get information about the parts
	/// by first calling UpdateInformation, and using GetPartArrayName ...
	/// </summary>
	public void SetPartArrayStatus(string arg0, int flag)
	{
		vtkExodusIIReader_SetPartArrayStatus_261(GetCppThis(), arg0, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetPointResultArrayStatus_262(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetPointResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetPointResultArrayStatus_262(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetSideSetArrayStatus_263(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetSideSetArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetSideSetArrayStatus_263(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetSideSetResultArrayStatus_264(HandleRef pThis, string name, int flag);

	/// <summary>
	/// Return the id of the type,name variable
	/// </summary>
	public void SetSideSetResultArrayStatus(string name, int flag)
	{
		vtkExodusIIReader_SetSideSetResultArrayStatus_264(GetCppThis(), name, flag);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetSqueezePoints_265(HandleRef pThis, byte sp);

	/// <summary>
	/// Should the reader output only points used by elements in the output mesh,
	/// or all the points. Outputting all the points is much faster since the
	/// point array can be read straight from disk and the mesh connectivity need
	/// not be altered. Squeezing the points down to the minimum set needed to
	/// produce the output mesh is useful for glyphing and other point-based
	/// operations. On large parallel datasets, loading all the points implies
	/// loading all the points on all processes and performing subsequent
	/// filtering on a much larger set.
	///
	/// By default, SqueezePoints is true for backwards compatibility.
	/// </summary>
	public void SetSqueezePoints(bool sp)
	{
		vtkExodusIIReader_SetSqueezePoints_265(GetCppThis(), (byte)(sp ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetTimeStep_266(HandleRef pThis, int _arg);

	/// <summary>
	/// Which TimeStep to read.
	/// </summary>
	public virtual void SetTimeStep(int _arg)
	{
		vtkExodusIIReader_SetTimeStep_266(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetUseLegacyBlockNames_267(HandleRef pThis, byte _arg);

	/// <summary>
	/// In previous versions, the reader added the type of elements in the block to
	/// the block name when no name was provided for the block. This has issues
	/// with consistency when naming blocks across ranks for partitioned files
	/// (see paraview/paraview#19110), hence we no longer do that. For legacy
	/// pipelines, one can enable the old behavior by setting this flag to true.
	/// </summary>
	public virtual void SetUseLegacyBlockNames(bool _arg)
	{
		vtkExodusIIReader_SetUseLegacyBlockNames_267(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_SetXMLFileName_268(HandleRef pThis, string fname);

	/// <summary>
	/// Specify file name of the xml file.
	/// </summary>
	public virtual void SetXMLFileName(string fname)
	{
		vtkExodusIIReader_SetXMLFileName_268(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_UseLegacyBlockNamesOff_269(HandleRef pThis);

	/// <summary>
	/// In previous versions, the reader added the type of elements in the block to
	/// the block name when no name was provided for the block. This has issues
	/// with consistency when naming blocks across ranks for partitioned files
	/// (see paraview/paraview#19110), hence we no longer do that. For legacy
	/// pipelines, one can enable the old behavior by setting this flag to true.
	/// </summary>
	public virtual void UseLegacyBlockNamesOff()
	{
		vtkExodusIIReader_UseLegacyBlockNamesOff_269(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReader_UseLegacyBlockNamesOn_270(HandleRef pThis);

	/// <summary>
	/// In previous versions, the reader added the type of elements in the block to
	/// the block name when no name was provided for the block. This has issues
	/// with consistency when naming blocks across ranks for partitioned files
	/// (see paraview/paraview#19110), hence we no longer do that. For legacy
	/// pipelines, one can enable the old behavior by setting this flag to true.
	/// </summary>
	public virtual void UseLegacyBlockNamesOn()
	{
		vtkExodusIIReader_UseLegacyBlockNamesOn_270(GetCppThis());
	}
}
