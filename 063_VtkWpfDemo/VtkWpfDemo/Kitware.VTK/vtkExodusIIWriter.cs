using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExodusIIWriter
/// </summary>
/// <remarks>
///    Write Exodus II files
///
///     This is a vtkWriter that writes it's vtkUnstructuredGrid
///     input out to an Exodus II file.  Go to http://endo.sandia.gov/SEACAS/
///     for more information about the Exodus II format.
///
///     Exodus files contain much information that is not captured
///     in a vtkUnstructuredGrid, such as time steps, information
///     lines, node sets, and side sets.  This information can be
///     stored in a vtkModelMetadata object.
///
///     The vtkExodusReader and vtkPExodusReader can create
///     a vtkModelMetadata object and embed it in a vtkUnstructuredGrid
///     in a series of field arrays.  This writer searches for these
///     field arrays and will use the metadata contained in them
///     when creating the new Exodus II file.
///
///     You can also explicitly give the vtkExodusIIWriter a
///     vtkModelMetadata object to use when writing the file.
///
///     In the absence of the information provided by vtkModelMetadata,
///     if this writer is not part of a parallel application, we will use
///     reasonable defaults for all the values in the output Exodus file.
///     If you don't provide a block ID element array, we'll create a
///     block for each cell type that appears in the unstructured grid.
///
///     However if this writer is part of a parallel application (hence
///     writing out a distributed Exodus file), then we need at the very
///     least a list of all the block IDs that appear in the file.  And
///     we need the element array of block IDs for the input unstructured grid.
///
///     In the absence of a vtkModelMetadata object, you can also provide
///     time step information which we will include in the output Exodus
///     file.
///
/// @warning
///     If the input floating point field arrays and point locations are all
///     floats or all doubles, this class will operate more efficiently.
///     Mixing floats and doubles will slow you down, because Exodus II
///     requires that we write only floats or only doubles.
///
/// @warning
///     We use the terms "point" and "node" interchangeably.
///     Also, we use the terms "element" and "cell" interchangeably.
/// </remarks>
public class vtkExodusIIWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIIWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExodusIIWriter()
	{
		MRClassNameKey = "class vtkExodusIIWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIIWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExodusIIWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExodusIIWriter New()
	{
		vtkExodusIIWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExodusIIWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExodusIIWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkExodusIIWriter_GetBlockIdArrayName_01(HandleRef pThis);

	/// <summary>
	/// When WriteAllTimeSteps is turned ON, the writer is executed once for
	/// each timestep available from the reader.
	/// </summary>
	public virtual string GetBlockIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIWriter_GetBlockIdArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIWriter_GetFileName_02(HandleRef pThis);

	/// <summary>
	/// Name for the output file.  If writing in parallel, the number
	/// of processes and the process rank will be appended to the name,
	/// so each process is writing out a separate file.
	/// If not set, this class will make up a file name.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkExodusIIWriter_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIWriter_GetGhostLevel_03(HandleRef pThis);

	/// <summary>
	/// We never write out ghost cells.  This variable is here to satisfy
	/// the behavior of ParaView on invoking a parallel writer.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkExodusIIWriter_GetGhostLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExodusIIWriter_GetIgnoreMetaDataWarning_04(HandleRef pThis);

	/// <summary>
	/// In certain cases we know that metadata doesn't exist and
	/// we want to ignore that warning.
	/// </summary>
	public virtual bool GetIgnoreMetaDataWarning()
	{
		return (vtkExodusIIWriter_GetIgnoreMetaDataWarning_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIWriter_GetModelMetadata_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the vtkModelMetadata object which contains the Exodus file
	/// model information (metadata) absent in the vtkUnstructuredGrid.  If you
	/// have this object, you don't need to set any other values before writing.
	/// (Just the FileName and the Input.)
	/// Note that the vtkExodusReader can create and attach a vtkModelMetadata
	/// object to it's output.  If this has happened, the ExodusIIWriter will
	/// find it and use it.
	/// </summary>
	public virtual vtkModelMetadata GetModelMetadata()
	{
		vtkModelMetadata vtkModelMetadata2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIWriter_GetModelMetadata_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkModelMetadata2 = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkModelMetadata2.Register(null);
			}
		}
		return vtkModelMetadata2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExodusIIWriter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIWriter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExodusIIWriter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIWriter_GetStoreDoubles_08(HandleRef pThis);

	/// <summary>
	/// If StoreDoubles is ON, the floating point fields in the Exodus file
	/// will be double precision fields.  The default is determined by the
	/// max precision of the input.  If the field data appears to be doubles,
	/// then StoreDoubles will be ON, otherwise StoreDoubles will be OFF.
	/// </summary>
	public virtual int GetStoreDoubles()
	{
		return vtkExodusIIWriter_GetStoreDoubles_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIWriter_GetWriteAllTimeSteps_09(HandleRef pThis);

	/// <summary>
	/// When WriteAllTimeSteps is turned ON, the writer is executed once for
	/// each timestep available from the reader.
	/// </summary>
	public virtual int GetWriteAllTimeSteps()
	{
		return vtkExodusIIWriter_GetWriteAllTimeSteps_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIWriter_GetWriteOutBlockIdArray_10(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Block Ids of the
	/// cells is not included when the new Exodus II file is written out.  If
	/// you do want to include this array, set WriteOutBlockIdArray to ON.
	/// </summary>
	public virtual int GetWriteOutBlockIdArray()
	{
		return vtkExodusIIWriter_GetWriteOutBlockIdArray_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIWriter_GetWriteOutGlobalElementIdArray_11(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Element Ids
	/// is not included when the new Exodus II file is written out.  If you
	/// do want to include this array, set WriteOutGlobalElementIdArray to ON.
	/// </summary>
	public virtual int GetWriteOutGlobalElementIdArray()
	{
		return vtkExodusIIWriter_GetWriteOutGlobalElementIdArray_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIWriter_GetWriteOutGlobalNodeIdArray_12(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Node Ids
	/// is not included when the new Exodus II file is written out.  If
	/// you do want to include this array, set WriteOutGlobalNodeIdArray to ON.
	/// </summary>
	public virtual int GetWriteOutGlobalNodeIdArray()
	{
		return vtkExodusIIWriter_GetWriteOutGlobalNodeIdArray_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_IgnoreMetaDataWarningOff_13(HandleRef pThis);

	/// <summary>
	/// In certain cases we know that metadata doesn't exist and
	/// we want to ignore that warning.
	/// </summary>
	public virtual void IgnoreMetaDataWarningOff()
	{
		vtkExodusIIWriter_IgnoreMetaDataWarningOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_IgnoreMetaDataWarningOn_14(HandleRef pThis);

	/// <summary>
	/// In certain cases we know that metadata doesn't exist and
	/// we want to ignore that warning.
	/// </summary>
	public virtual void IgnoreMetaDataWarningOn()
	{
		vtkExodusIIWriter_IgnoreMetaDataWarningOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIWriter_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExodusIIWriter_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIWriter_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExodusIIWriter_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIWriter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExodusIIWriter NewInstance()
	{
		vtkExodusIIWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIWriter_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIWriter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExodusIIWriter SafeDownCast(vtkObjectBase o)
	{
		vtkExodusIIWriter vtkExodusIIWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIWriter_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExodusIIWriter2 = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExodusIIWriter2.Register(null);
			}
		}
		return vtkExodusIIWriter2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetBlockIdArrayName_20(HandleRef pThis, string _arg);

	/// <summary>
	/// When WriteAllTimeSteps is turned ON, the writer is executed once for
	/// each timestep available from the reader.
	/// </summary>
	public virtual void SetBlockIdArrayName(string _arg)
	{
		vtkExodusIIWriter_SetBlockIdArrayName_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetFileName_21(HandleRef pThis, string _arg);

	/// <summary>
	/// Name for the output file.  If writing in parallel, the number
	/// of processes and the process rank will be appended to the name,
	/// so each process is writing out a separate file.
	/// If not set, this class will make up a file name.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkExodusIIWriter_SetFileName_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetGhostLevel_22(HandleRef pThis, int _arg);

	/// <summary>
	/// We never write out ghost cells.  This variable is here to satisfy
	/// the behavior of ParaView on invoking a parallel writer.
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkExodusIIWriter_SetGhostLevel_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetIgnoreMetaDataWarning_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// In certain cases we know that metadata doesn't exist and
	/// we want to ignore that warning.
	/// </summary>
	public virtual void SetIgnoreMetaDataWarning(bool _arg)
	{
		vtkExodusIIWriter_SetIgnoreMetaDataWarning_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetModelMetadata_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the vtkModelMetadata object which contains the Exodus file
	/// model information (metadata) absent in the vtkUnstructuredGrid.  If you
	/// have this object, you don't need to set any other values before writing.
	/// (Just the FileName and the Input.)
	/// Note that the vtkExodusReader can create and attach a vtkModelMetadata
	/// object to it's output.  If this has happened, the ExodusIIWriter will
	/// find it and use it.
	/// </summary>
	public void SetModelMetadata(vtkModelMetadata arg0)
	{
		vtkExodusIIWriter_SetModelMetadata_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetStoreDoubles_25(HandleRef pThis, int _arg);

	/// <summary>
	/// If StoreDoubles is ON, the floating point fields in the Exodus file
	/// will be double precision fields.  The default is determined by the
	/// max precision of the input.  If the field data appears to be doubles,
	/// then StoreDoubles will be ON, otherwise StoreDoubles will be OFF.
	/// </summary>
	public virtual void SetStoreDoubles(int _arg)
	{
		vtkExodusIIWriter_SetStoreDoubles_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetWriteAllTimeSteps_26(HandleRef pThis, int _arg);

	/// <summary>
	/// When WriteAllTimeSteps is turned ON, the writer is executed once for
	/// each timestep available from the reader.
	/// </summary>
	public virtual void SetWriteAllTimeSteps(int _arg)
	{
		vtkExodusIIWriter_SetWriteAllTimeSteps_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetWriteOutBlockIdArray_27(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, the integer array containing the global Block Ids of the
	/// cells is not included when the new Exodus II file is written out.  If
	/// you do want to include this array, set WriteOutBlockIdArray to ON.
	/// </summary>
	public virtual void SetWriteOutBlockIdArray(int _arg)
	{
		vtkExodusIIWriter_SetWriteOutBlockIdArray_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetWriteOutGlobalElementIdArray_28(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, the integer array containing the global Element Ids
	/// is not included when the new Exodus II file is written out.  If you
	/// do want to include this array, set WriteOutGlobalElementIdArray to ON.
	/// </summary>
	public virtual void SetWriteOutGlobalElementIdArray(int _arg)
	{
		vtkExodusIIWriter_SetWriteOutGlobalElementIdArray_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_SetWriteOutGlobalNodeIdArray_29(HandleRef pThis, int _arg);

	/// <summary>
	/// By default, the integer array containing the global Node Ids
	/// is not included when the new Exodus II file is written out.  If
	/// you do want to include this array, set WriteOutGlobalNodeIdArray to ON.
	/// </summary>
	public virtual void SetWriteOutGlobalNodeIdArray(int _arg)
	{
		vtkExodusIIWriter_SetWriteOutGlobalNodeIdArray_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_WriteAllTimeStepsOff_30(HandleRef pThis);

	/// <summary>
	/// When WriteAllTimeSteps is turned ON, the writer is executed once for
	/// each timestep available from the reader.
	/// </summary>
	public virtual void WriteAllTimeStepsOff()
	{
		vtkExodusIIWriter_WriteAllTimeStepsOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_WriteAllTimeStepsOn_31(HandleRef pThis);

	/// <summary>
	/// When WriteAllTimeSteps is turned ON, the writer is executed once for
	/// each timestep available from the reader.
	/// </summary>
	public virtual void WriteAllTimeStepsOn()
	{
		vtkExodusIIWriter_WriteAllTimeStepsOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_WriteOutBlockIdArrayOff_32(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Block Ids of the
	/// cells is not included when the new Exodus II file is written out.  If
	/// you do want to include this array, set WriteOutBlockIdArray to ON.
	/// </summary>
	public virtual void WriteOutBlockIdArrayOff()
	{
		vtkExodusIIWriter_WriteOutBlockIdArrayOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_WriteOutBlockIdArrayOn_33(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Block Ids of the
	/// cells is not included when the new Exodus II file is written out.  If
	/// you do want to include this array, set WriteOutBlockIdArray to ON.
	/// </summary>
	public virtual void WriteOutBlockIdArrayOn()
	{
		vtkExodusIIWriter_WriteOutBlockIdArrayOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_WriteOutGlobalElementIdArrayOff_34(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Element Ids
	/// is not included when the new Exodus II file is written out.  If you
	/// do want to include this array, set WriteOutGlobalElementIdArray to ON.
	/// </summary>
	public virtual void WriteOutGlobalElementIdArrayOff()
	{
		vtkExodusIIWriter_WriteOutGlobalElementIdArrayOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_WriteOutGlobalElementIdArrayOn_35(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Element Ids
	/// is not included when the new Exodus II file is written out.  If you
	/// do want to include this array, set WriteOutGlobalElementIdArray to ON.
	/// </summary>
	public virtual void WriteOutGlobalElementIdArrayOn()
	{
		vtkExodusIIWriter_WriteOutGlobalElementIdArrayOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOff_36(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Node Ids
	/// is not included when the new Exodus II file is written out.  If
	/// you do want to include this array, set WriteOutGlobalNodeIdArray to ON.
	/// </summary>
	public virtual void WriteOutGlobalNodeIdArrayOff()
	{
		vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOn_37(HandleRef pThis);

	/// <summary>
	/// By default, the integer array containing the global Node Ids
	/// is not included when the new Exodus II file is written out.  If
	/// you do want to include this array, set WriteOutGlobalNodeIdArray to ON.
	/// </summary>
	public virtual void WriteOutGlobalNodeIdArrayOn()
	{
		vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOn_37(GetCppThis());
	}
}
