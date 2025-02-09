using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkArrayWriter
/// </summary>
/// <remarks>
///    Serialize sparse and dense arrays to a file or stream.
///
///
/// vtkArrayWriter serializes sparse and dense array data using a text-based
/// format that is human-readable and easily parsed (default option).  The
/// WriteBinary array option can be used to serialize the sparse and dense array data
/// using a binary format that is optimized for rapid throughput.
///
/// vtkArrayWriter can be used in two distinct ways: first, it can be used as a
/// normal pipeline filter, which writes its inputs to a file.  Alternatively, static
/// methods are provided for writing vtkArray instances to files or arbitrary c++
/// streams.
///
/// Inputs:
///   Input port 0: (required) vtkArrayData object containing a single sparse or dense
///                            array.
///
/// Output Format:
///   See http://www.kitware.com/InfovisWiki/index.php/N-Way_Array_File_Formats for
///   details on how vtkArrayWriter encodes data.
///
/// </remarks>
/// <seealso>
///
/// vtkArrayReader
///
/// @par Thanks:
/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
/// </seealso>
public class vtkArrayWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkArrayWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkArrayWriter()
	{
		MRClassNameKey = "class vtkArrayWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkArrayWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArrayWriter New()
	{
		vtkArrayWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkArrayWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkArrayWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayWriter_BinaryOff_01(HandleRef pThis);

	/// <summary>
	/// Get / set whether data will be written in binary format (when used as a filter).
	/// </summary>
	public virtual void BinaryOff()
	{
		vtkArrayWriter_BinaryOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayWriter_BinaryOn_02(HandleRef pThis);

	/// <summary>
	/// Get / set whether data will be written in binary format (when used as a filter).
	/// </summary>
	public virtual void BinaryOn()
	{
		vtkArrayWriter_BinaryOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayWriter_GetBinary_03(HandleRef pThis);

	/// <summary>
	/// Get / set whether data will be written in binary format (when used as a filter).
	/// </summary>
	public virtual int GetBinary()
	{
		return vtkArrayWriter_GetBinary_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayWriter_GetFileName_04(HandleRef pThis);

	/// <summary>
	/// Get / set the filename where data will be stored (when used as a filter).
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkArrayWriter_GetFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrayWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkArrayWriter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrayWriter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkArrayWriter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayWriter_GetOutputString_07(HandleRef pThis);

	/// <summary>
	/// The output string. This is only set when WriteToOutputString is set.
	/// </summary>
	public virtual string GetOutputString()
	{
		return vtkArrayWriter_GetOutputString_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayWriter_GetWriteToOutputString_08(HandleRef pThis);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public virtual bool GetWriteToOutputString()
	{
		return (vtkArrayWriter_GetWriteToOutputString_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayWriter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkArrayWriter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayWriter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkArrayWriter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkArrayWriter NewInstance()
	{
		vtkArrayWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayWriter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArrayWriter SafeDownCast(vtkObjectBase o)
	{
		vtkArrayWriter vtkArrayWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayWriter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArrayWriter2 = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArrayWriter2.Register(null);
			}
		}
		return vtkArrayWriter2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayWriter_SetBinary_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Get / set whether data will be written in binary format (when used as a filter).
	/// </summary>
	public virtual void SetBinary(int _arg)
	{
		vtkArrayWriter_SetBinary_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayWriter_SetFileName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Get / set the filename where data will be stored (when used as a filter).
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkArrayWriter_SetFileName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayWriter_SetWriteToOutputString_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public virtual void SetWriteToOutputString(bool _arg)
	{
		vtkArrayWriter_SetWriteToOutputString_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayWriter_Write_17(HandleRef pThis);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public override int Write()
	{
		return vtkArrayWriter_Write_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayWriter_Write_18(HandleRef pThis, string FileName, byte WriteBinary);

	/// <summary>
	/// Writes input port 0 data to a file, using an arbitrary filename and binary flag.
	/// </summary>
	public bool Write(string FileName, bool WriteBinary)
	{
		return (vtkArrayWriter_Write_18(GetCppThis(), FileName, (byte)(WriteBinary ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayWriter_Write_19(HandleRef array, string file_name, byte WriteBinary);

	/// <summary>
	/// Write an arbitrary array to a file, without using the pipeline.
	/// </summary>
	public static bool Write(vtkArray array, string file_name, bool WriteBinary)
	{
		return (vtkArrayWriter_Write_19(array?.GetCppThis() ?? default(HandleRef), file_name, (byte)(WriteBinary ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayWriter_Write_20(HandleRef pThis, byte WriteBinary);

	/// <summary>
	/// Write input port 0 data to a string. Note that the WriteBinary argument is not
	/// optional in order to not clash with the inherited Write() method.
	/// </summary>
	public string Write(bool WriteBinary)
	{
		return vtkArrayWriter_Write_20(GetCppThis(), (byte)(WriteBinary ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayWriter_Write_21(HandleRef array, byte WriteBinary);

	/// <summary>
	/// Write arbitrary data to a string without using the pipeline.
	/// </summary>
	public static string Write(vtkArray array, bool WriteBinary)
	{
		return vtkArrayWriter_Write_21(array?.GetCppThis() ?? default(HandleRef), (byte)(WriteBinary ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayWriter_WriteToOutputStringOff_22(HandleRef pThis);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public virtual void WriteToOutputStringOff()
	{
		vtkArrayWriter_WriteToOutputStringOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayWriter_WriteToOutputStringOn_23(HandleRef pThis);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public virtual void WriteToOutputStringOn()
	{
		vtkArrayWriter_WriteToOutputStringOn_23(GetCppThis());
	}
}
