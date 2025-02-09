using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAVSucdReader
/// </summary>
/// <remarks>
///    reads a dataset in AVS "UCD" format
///
/// vtkAVSucdReader creates an unstructured grid dataset. It reads binary or
/// ASCII files stored in UCD format, with optional data stored at the nodes
/// or at the cells of the model. A cell-based fielddata stores the material
/// id. The class can automatically detect the endian-ness of the binary files.
///
/// @par Thanks:
/// Thanks to Guenole Harel and Emmanuel Colin (Supelec engineering school,
/// France) and Jean M. Favre (CSCS, Switzerland) who co-developed this class.
/// Thanks to Isabelle Surin (isabelle.surin at cea.fr, CEA-DAM, France) who
/// supervised the internship of the first two authors. Thanks to Daniel
/// Aguilera (daniel.aguilera at cea.fr, CEA-DAM, France) who contributed code
/// and advice. Please address all comments to Jean Favre (jfavre at cscs.ch)
///
/// </remarks>
/// <seealso>
///
/// vtkGAMBITReader
/// </seealso>
public class vtkAVSucdReader : vtkUnstructuredGridAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAVSucdReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAVSucdReader()
	{
		MRClassNameKey = "class vtkAVSucdReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAVSucdReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAVSucdReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVSucdReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAVSucdReader New()
	{
		vtkAVSucdReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAVSucdReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAVSucdReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAVSucdReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkAVSucdReader_BinaryFileOff_01(HandleRef pThis);

	/// <summary>
	/// Is the file to be read written in binary format (as opposed to ascii).
	/// </summary>
	public virtual void BinaryFileOff()
	{
		vtkAVSucdReader_BinaryFileOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_BinaryFileOn_02(HandleRef pThis);

	/// <summary>
	/// Is the file to be read written in binary format (as opposed to ascii).
	/// </summary>
	public virtual void BinaryFileOn()
	{
		vtkAVSucdReader_BinaryFileOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_DisableAllCellArrays_03(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public void DisableAllCellArrays()
	{
		vtkAVSucdReader_DisableAllCellArrays_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_DisableAllPointArrays_04(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public void DisableAllPointArrays()
	{
		vtkAVSucdReader_DisableAllPointArrays_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_EnableAllCellArrays_05(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public void EnableAllCellArrays()
	{
		vtkAVSucdReader_EnableAllCellArrays_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_EnableAllPointArrays_06(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public void EnableAllPointArrays()
	{
		vtkAVSucdReader_EnableAllPointArrays_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetBinaryFile_07(HandleRef pThis);

	/// <summary>
	/// Is the file to be read written in binary format (as opposed to ascii).
	/// </summary>
	public virtual int GetBinaryFile()
	{
		return vtkAVSucdReader_GetBinaryFile_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetByteOrder_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the endian-ness of the binary file.
	/// </summary>
	public virtual int GetByteOrder()
	{
		return vtkAVSucdReader_GetByteOrder_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVSucdReader_GetByteOrderAsString_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the endian-ness of the binary file.
	/// </summary>
	public string GetByteOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkAVSucdReader_GetByteOrderAsString_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVSucdReader_GetCellArrayName_10(HandleRef pThis, int index);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkAVSucdReader_GetCellArrayName_10(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetCellArrayStatus_11(HandleRef pThis, string name);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkAVSucdReader_GetCellArrayStatus_11(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_GetCellDataRange_12(HandleRef pThis, int cellComp, int index, IntPtr min, IntPtr max);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public void GetCellDataRange(int cellComp, int index, IntPtr min, IntPtr max)
	{
		vtkAVSucdReader_GetCellDataRange_12(GetCppThis(), cellComp, index, min, max);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVSucdReader_GetFileName_13(HandleRef pThis);

	/// <summary>
	/// Specify file name of AVS UCD datafile to read
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkAVSucdReader_GetFileName_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_GetNodeDataRange_14(HandleRef pThis, int nodeComp, int index, IntPtr min, IntPtr max);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public void GetNodeDataRange(int nodeComp, int index, IntPtr min, IntPtr max)
	{
		vtkAVSucdReader_GetNodeDataRange_14(GetCppThis(), nodeComp, index, min, max);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfCellArrays_15(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkAVSucdReader_GetNumberOfCellArrays_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfCellComponents_16(HandleRef pThis);

	/// <summary>
	/// Get the number of data components at the nodes and cells.
	/// </summary>
	public virtual int GetNumberOfCellComponents()
	{
		return vtkAVSucdReader_GetNumberOfCellComponents_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfCellFields_17(HandleRef pThis);

	/// <summary>
	/// Get the number of data fields at the cell centers.
	/// </summary>
	public virtual int GetNumberOfCellFields()
	{
		return vtkAVSucdReader_GetNumberOfCellFields_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfCells_18(HandleRef pThis);

	/// <summary>
	/// Get the total number of cells.
	/// </summary>
	public virtual int GetNumberOfCells()
	{
		return vtkAVSucdReader_GetNumberOfCells_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfFields_19(HandleRef pThis);

	/// <summary>
	/// Get the number of data fields for the model. Unused because VTK
	/// has no methods for it.
	/// </summary>
	public virtual int GetNumberOfFields()
	{
		return vtkAVSucdReader_GetNumberOfFields_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAVSucdReader_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAVSucdReader_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAVSucdReader_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAVSucdReader_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfNodeComponents_22(HandleRef pThis);

	/// <summary>
	/// Get the number of data components at the nodes and cells.
	/// </summary>
	public virtual int GetNumberOfNodeComponents()
	{
		return vtkAVSucdReader_GetNumberOfNodeComponents_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfNodeFields_23(HandleRef pThis);

	/// <summary>
	/// Get the number of data fields at the nodes.
	/// </summary>
	public virtual int GetNumberOfNodeFields()
	{
		return vtkAVSucdReader_GetNumberOfNodeFields_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfNodes_24(HandleRef pThis);

	/// <summary>
	/// Get the total number of nodes.
	/// </summary>
	public virtual int GetNumberOfNodes()
	{
		return vtkAVSucdReader_GetNumberOfNodes_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetNumberOfPointArrays_25(HandleRef pThis);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkAVSucdReader_GetNumberOfPointArrays_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVSucdReader_GetPointArrayName_26(HandleRef pThis, int index);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkAVSucdReader_GetPointArrayName_26(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_GetPointArrayStatus_27(HandleRef pThis, string name);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public int GetPointArrayStatus(string name)
	{
		return vtkAVSucdReader_GetPointArrayStatus_27(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAVSucdReader_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVSucdReader_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAVSucdReader_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVSucdReader_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAVSucdReader NewInstance()
	{
		vtkAVSucdReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAVSucdReader_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVSucdReader_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAVSucdReader SafeDownCast(vtkObjectBase o)
	{
		vtkAVSucdReader vtkAVSucdReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAVSucdReader_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAVSucdReader2 = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAVSucdReader2.Register(null);
			}
		}
		return vtkAVSucdReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_SetBinaryFile_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Is the file to be read written in binary format (as opposed to ascii).
	/// </summary>
	public virtual void SetBinaryFile(int _arg)
	{
		vtkAVSucdReader_SetBinaryFile_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_SetByteOrder_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the endian-ness of the binary file.
	/// </summary>
	public virtual void SetByteOrder(int _arg)
	{
		vtkAVSucdReader_SetByteOrder_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_SetByteOrderToBigEndian_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the endian-ness of the binary file.
	/// </summary>
	public void SetByteOrderToBigEndian()
	{
		vtkAVSucdReader_SetByteOrderToBigEndian_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_SetByteOrderToLittleEndian_36(HandleRef pThis);

	/// <summary>
	/// Set/Get the endian-ness of the binary file.
	/// </summary>
	public void SetByteOrderToLittleEndian()
	{
		vtkAVSucdReader_SetByteOrderToLittleEndian_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_SetCellArrayStatus_37(HandleRef pThis, string name, int status);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkAVSucdReader_SetCellArrayStatus_37(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_SetFileName_38(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of AVS UCD datafile to read
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkAVSucdReader_SetFileName_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVSucdReader_SetPointArrayStatus_39(HandleRef pThis, string name, int status);

	/// <summary>
	/// The following methods allow selective reading of solutions fields.  by
	/// default, ALL data fields are the nodes and cells are read, but this can
	/// be modified.
	/// </summary>
	public void SetPointArrayStatus(string name, int status)
	{
		vtkAVSucdReader_SetPointArrayStatus_39(GetCppThis(), name, status);
	}
}
