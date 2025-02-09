using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTecplotTableReader
/// </summary>
/// <remarks>
///    reads in Tecplot tabular data
/// and outputs a vtkTable data structure.
///
///
/// vtkTecplotTableReader is an interface for reading tabulat data in Tecplot
/// ascii format.
///
/// @par Thanks:
/// Thanks to vtkDelimitedTextReader authors.
///
/// </remarks>
public class vtkTecplotTableReader : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTecplotTableReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTecplotTableReader()
	{
		MRClassNameKey = "class vtkTecplotTableReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTecplotTableReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTecplotTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotTableReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTecplotTableReader New()
	{
		vtkTecplotTableReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTecplotTableReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTecplotTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTecplotTableReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTecplotTableReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_GeneratePedigreeIdsOff_01(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void GeneratePedigreeIdsOff()
	{
		vtkTecplotTableReader_GeneratePedigreeIdsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_GeneratePedigreeIdsOn_02(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void GeneratePedigreeIdsOn()
	{
		vtkTecplotTableReader_GeneratePedigreeIdsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTecplotTableReader_GetColumnNamesOnLine_03(HandleRef pThis);

	/// <summary>
	/// Specifies the line number that holds the column names. Default is 1.
	/// </summary>
	public virtual long GetColumnNamesOnLine()
	{
		return vtkTecplotTableReader_GetColumnNamesOnLine_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotTableReader_GetFileName_04(HandleRef pThis);

	/// <summary>
	/// Specifies the delimited text file to be loaded.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkTecplotTableReader_GetFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTecplotTableReader_GetGeneratePedigreeIds_05(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual bool GetGeneratePedigreeIds()
	{
		return (vtkTecplotTableReader_GetGeneratePedigreeIds_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTecplotTableReader_GetHeaderLines_06(HandleRef pThis);

	/// <summary>
	/// Specifies the number of lines that form the header of the file. Default is 2.
	/// </summary>
	public virtual long GetHeaderLines()
	{
		return vtkTecplotTableReader_GetHeaderLines_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkTecplotTableReader_GetLastError_07(HandleRef pThis);

	/// <summary>
	/// Returns a human-readable description of the most recent error, if any.
	/// Otherwise, returns an empty string.  Note that the result is only valid
	/// after calling Update().
	/// </summary>
	public string GetLastError()
	{
		return vtkTecplotTableReader_GetLastError_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTecplotTableReader_GetMaxRecords_08(HandleRef pThis);

	/// <summary>
	/// Specifies the maximum number of records to read from the file.  Limiting the
	/// number of records to read is useful for previewing the contents of a file.
	/// </summary>
	public virtual long GetMaxRecords()
	{
		return vtkTecplotTableReader_GetMaxRecords_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTecplotTableReader_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTecplotTableReader_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTecplotTableReader_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTecplotTableReader_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTecplotTableReader_GetOutputPedigreeIds_11(HandleRef pThis);

	/// <summary>
	/// If on, assigns pedigree ids to output. Defaults to off.
	/// </summary>
	public virtual bool GetOutputPedigreeIds()
	{
		return (vtkTecplotTableReader_GetOutputPedigreeIds_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotTableReader_GetPedigreeIdArrayName_12(HandleRef pThis);

	/// <summary>
	/// The name of the array for generating or assigning pedigree ids
	/// (default "id").
	/// </summary>
	public virtual string GetPedigreeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkTecplotTableReader_GetPedigreeIdArrayName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTecplotTableReader_GetSkipColumnNames_13(HandleRef pThis);

	/// <summary>
	/// Specifies the number of fields to skip while reading the column names. Default is 1.
	/// </summary>
	public virtual long GetSkipColumnNames()
	{
		return vtkTecplotTableReader_GetSkipColumnNames_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotTableReader_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTecplotTableReader_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTecplotTableReader_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTecplotTableReader_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotTableReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTecplotTableReader NewInstance()
	{
		vtkTecplotTableReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTecplotTableReader_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTecplotTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_OutputPedigreeIdsOff_18(HandleRef pThis);

	/// <summary>
	/// If on, assigns pedigree ids to output. Defaults to off.
	/// </summary>
	public virtual void OutputPedigreeIdsOff()
	{
		vtkTecplotTableReader_OutputPedigreeIdsOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_OutputPedigreeIdsOn_19(HandleRef pThis);

	/// <summary>
	/// If on, assigns pedigree ids to output. Defaults to off.
	/// </summary>
	public virtual void OutputPedigreeIdsOn()
	{
		vtkTecplotTableReader_OutputPedigreeIdsOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTecplotTableReader_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTecplotTableReader SafeDownCast(vtkObjectBase o)
	{
		vtkTecplotTableReader vtkTecplotTableReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTecplotTableReader_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTecplotTableReader2 = (vtkTecplotTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTecplotTableReader2.Register(null);
			}
		}
		return vtkTecplotTableReader2;
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_SetColumnNamesOnLine_21(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies the line number that holds the column names. Default is 1.
	/// </summary>
	public virtual void SetColumnNamesOnLine(long _arg)
	{
		vtkTecplotTableReader_SetColumnNamesOnLine_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_SetFileName_22(HandleRef pThis, string _arg);

	/// <summary>
	/// Specifies the delimited text file to be loaded.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkTecplotTableReader_SetFileName_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_SetGeneratePedigreeIds_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void SetGeneratePedigreeIds(bool _arg)
	{
		vtkTecplotTableReader_SetGeneratePedigreeIds_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_SetHeaderLines_24(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies the number of lines that form the header of the file. Default is 2.
	/// </summary>
	public virtual void SetHeaderLines(long _arg)
	{
		vtkTecplotTableReader_SetHeaderLines_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_SetMaxRecords_25(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies the maximum number of records to read from the file.  Limiting the
	/// number of records to read is useful for previewing the contents of a file.
	/// </summary>
	public virtual void SetMaxRecords(long _arg)
	{
		vtkTecplotTableReader_SetMaxRecords_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_SetOutputPedigreeIds_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, assigns pedigree ids to output. Defaults to off.
	/// </summary>
	public virtual void SetOutputPedigreeIds(bool _arg)
	{
		vtkTecplotTableReader_SetOutputPedigreeIds_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_SetPedigreeIdArrayName_27(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the array for generating or assigning pedigree ids
	/// (default "id").
	/// </summary>
	public virtual void SetPedigreeIdArrayName(string _arg)
	{
		vtkTecplotTableReader_SetPedigreeIdArrayName_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTecplotTableReader_SetSkipColumnNames_28(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies the number of fields to skip while reading the column names. Default is 1.
	/// </summary>
	public virtual void SetSkipColumnNames(long _arg)
	{
		vtkTecplotTableReader_SetSkipColumnNames_28(GetCppThis(), _arg);
	}
}
