using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataObjectWriter
/// </summary>
/// <remarks>
///    write vtk field data
///
/// vtkDataObjectWriter is a source object that writes ASCII or binary
/// field data files in vtk format. Field data is a general form of data in
/// matrix form.
///
/// @warning
/// Binary files written on one system may not be readable on other systems.
///
/// </remarks>
/// <seealso>
///
/// vtkFieldData vtkFieldDataReader
/// </seealso>
public class vtkDataObjectWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataObjectWriter()
	{
		MRClassNameKey = "class vtkDataObjectWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectWriter New()
	{
		vtkDataObjectWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataObjectWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataObjectWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectWriter_GetBinaryOutputString_01(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public IntPtr GetBinaryOutputString()
	{
		return vtkDataObjectWriter_GetBinaryOutputString_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectWriter_GetFieldDataName_02(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public string GetFieldDataName()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectWriter_GetFieldDataName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectWriter_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectWriter_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectWriter_GetFileType_04(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public int GetFileType()
	{
		return vtkDataObjectWriter_GetFileType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectWriter_GetHeader_05(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public string GetHeader()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectWriter_GetHeader_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataObjectWriter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectWriter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataObjectWriter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDataObjectWriter_GetOutputStdString_08(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public string GetOutputStdString()
	{
		return vtkDataObjectWriter_GetOutputStdString_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectWriter_GetOutputString_09(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public string GetOutputString()
	{
		return Marshal.PtrToStringAnsi(vtkDataObjectWriter_GetOutputString_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectWriter_GetOutputStringLength_10(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public long GetOutputStringLength()
	{
		return vtkDataObjectWriter_GetOutputStringLength_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectWriter_GetWriteToOutputString_11(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public int GetWriteToOutputString()
	{
		return vtkDataObjectWriter_GetWriteToOutputString_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectWriter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataObjectWriter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectWriter_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataObjectWriter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectWriter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataObjectWriter NewInstance()
	{
		vtkDataObjectWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectWriter_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectWriter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectWriter SafeDownCast(vtkObjectBase o)
	{
		vtkDataObjectWriter vtkDataObjectWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectWriter_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObjectWriter2 = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObjectWriter2.Register(null);
			}
		}
		return vtkDataObjectWriter2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_SetFieldDataName_17(HandleRef pThis, string fieldname);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void SetFieldDataName(string fieldname)
	{
		vtkDataObjectWriter_SetFieldDataName_17(GetCppThis(), fieldname);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_SetFileName_18(HandleRef pThis, string filename);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void SetFileName(string filename)
	{
		vtkDataObjectWriter_SetFileName_18(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_SetFileType_19(HandleRef pThis, int type);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void SetFileType(int type)
	{
		vtkDataObjectWriter_SetFileType_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_SetFileTypeToASCII_20(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void SetFileTypeToASCII()
	{
		vtkDataObjectWriter_SetFileTypeToASCII_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_SetFileTypeToBinary_21(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void SetFileTypeToBinary()
	{
		vtkDataObjectWriter_SetFileTypeToBinary_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_SetHeader_22(HandleRef pThis, string header);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void SetHeader(string header)
	{
		vtkDataObjectWriter_SetHeader_22(GetCppThis(), header);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_SetWriteToOutputString_23(HandleRef pThis, int b);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void SetWriteToOutputString(int b)
	{
		vtkDataObjectWriter_SetWriteToOutputString_23(GetCppThis(), b);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_WriteToOutputStringOff_24(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void WriteToOutputStringOff()
	{
		vtkDataObjectWriter_WriteToOutputStringOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectWriter_WriteToOutputStringOn_25(HandleRef pThis);

	/// <summary>
	/// Methods delegated to vtkDataWriter, see vtkDataWriter.
	/// </summary>
	public void WriteToOutputStringOn()
	{
		vtkDataObjectWriter_WriteToOutputStringOn_25(GetCppThis());
	}
}
