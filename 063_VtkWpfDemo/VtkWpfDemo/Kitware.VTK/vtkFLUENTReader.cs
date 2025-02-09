using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFLUENTReader
/// </summary>
/// <remarks>
///    reads a dataset in Fluent file format
///
/// vtkFLUENTReader creates an unstructured grid dataset. It reads .cas and
/// .dat files stored in FLUENT native format.
///
/// @par Thanks:
/// Thanks to Brian W. Dotson &amp; Terry E. Jordan (Department of Energy, National
/// Energy Technology Laboratory) &amp; Douglas McCorkle (Iowa State University)
/// who developed this class.
/// Please address all comments to Brian Dotson (brian.dotson@netl.doe.gov) &amp;
/// </remarks>
/// <seealso>
/// Terry Jordan (terry.jordan.netl.doe.gov)
/// &amp; Doug McCorkle (mccdo@iastate.edu)
///
///
///
/// vtkGAMBITReader
/// </seealso>
public class vtkFLUENTReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFLUENTReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFLUENTReader()
	{
		MRClassNameKey = "class vtkFLUENTReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFLUENTReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFLUENTReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFLUENTReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFLUENTReader New()
	{
		vtkFLUENTReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFLUENTReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFLUENTReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFLUENTReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFLUENTReader_DisableAllCellArrays_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off all cell arrays.
	/// </summary>
	public void DisableAllCellArrays()
	{
		vtkFLUENTReader_DisableAllCellArrays_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFLUENTReader_EnableAllCellArrays_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off all cell arrays.
	/// </summary>
	public void EnableAllCellArrays()
	{
		vtkFLUENTReader_EnableAllCellArrays_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFLUENTReader_GetCellArrayName_03(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the cell array with the given index in
	/// the input.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkFLUENTReader_GetCellArrayName_03(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFLUENTReader_GetCellArrayStatus_04(HandleRef pThis, string name);

	/// <summary>
	/// Get/Set whether the cell array with the given name is to
	/// be read.
	/// </summary>
	public int GetCellArrayStatus(string name)
	{
		return vtkFLUENTReader_GetCellArrayStatus_04(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFLUENTReader_GetDataByteOrder_05(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public int GetDataByteOrder()
	{
		return vtkFLUENTReader_GetDataByteOrder_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFLUENTReader_GetDataByteOrderAsString_06(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public string GetDataByteOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkFLUENTReader_GetDataByteOrderAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFLUENTReader_GetFileName_07(HandleRef pThis);

	/// <summary>
	/// Specify the file name of the Fluent case file to read.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkFLUENTReader_GetFileName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFLUENTReader_GetNumberOfCellArrays_08(HandleRef pThis);

	/// <summary>
	/// Get the number of cell arrays available in the input.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkFLUENTReader_GetNumberOfCellArrays_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFLUENTReader_GetNumberOfCells_09(HandleRef pThis);

	/// <summary>
	/// Get the total number of cells. The number of cells is only valid after a
	/// successful read of the data file is performed. Initial value is 0.
	/// </summary>
	public virtual long GetNumberOfCells()
	{
		return vtkFLUENTReader_GetNumberOfCells_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFLUENTReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFLUENTReader_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFLUENTReader_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFLUENTReader_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFLUENTReader_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFLUENTReader_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFLUENTReader_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFLUENTReader_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFLUENTReader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFLUENTReader NewInstance()
	{
		vtkFLUENTReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFLUENTReader_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFLUENTReader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFLUENTReader SafeDownCast(vtkObjectBase o)
	{
		vtkFLUENTReader vtkFLUENTReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFLUENTReader_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFLUENTReader2 = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFLUENTReader2.Register(null);
			}
		}
		return vtkFLUENTReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFLUENTReader_SetCellArrayStatus_17(HandleRef pThis, string name, int status);

	/// <summary>
	/// Get/Set whether the cell array with the given name is to
	/// be read.
	/// </summary>
	public void SetCellArrayStatus(string name, int status)
	{
		vtkFLUENTReader_SetCellArrayStatus_17(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFLUENTReader_SetDataByteOrder_18(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public void SetDataByteOrder(int arg0)
	{
		vtkFLUENTReader_SetDataByteOrder_18(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFLUENTReader_SetDataByteOrderToBigEndian_19(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public void SetDataByteOrderToBigEndian()
	{
		vtkFLUENTReader_SetDataByteOrderToBigEndian_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFLUENTReader_SetDataByteOrderToLittleEndian_20(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public void SetDataByteOrderToLittleEndian()
	{
		vtkFLUENTReader_SetDataByteOrderToLittleEndian_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFLUENTReader_SetFileName_21(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the file name of the Fluent case file to read.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkFLUENTReader_SetFileName_21(GetCppThis(), _arg);
	}
}
