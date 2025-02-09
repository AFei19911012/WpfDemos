using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkArrayDataWriter
/// </summary>
/// <remarks>
///    Serialize vtkArrayData to a file or stream.
///
///
/// vtkArrayDataWriter serializes vtkArrayData using a text-based
/// format that is human-readable and easily parsed (default option).  The
/// WriteBinary array option can be used to serialize the vtkArrayData
/// using a binary format that is optimized for rapid throughput.
///
/// vtkArrayDataWriter can be used in two distinct ways: first, it can be used as a
/// normal pipeline filter, which writes its inputs to a file.  Alternatively, static
/// methods are provided for writing vtkArrayData instances to files or arbitrary c++
/// streams.
///
/// Inputs:
///   Input port 0: (required) vtkArrayData object.
///
/// Output Format:
///   See http://www.kitware.com/InfovisWiki/index.php/N-Way_Array_File_Formats for
///   details on how vtkArrayDataWriter encodes data.
///
/// </remarks>
/// <seealso>
///
/// vtkArrayDataReader
///
/// @par Thanks:
/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
/// </seealso>
public class vtkArrayDataWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkArrayDataWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkArrayDataWriter()
	{
		MRClassNameKey = "class vtkArrayDataWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayDataWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkArrayDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArrayDataWriter New()
	{
		vtkArrayDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrayDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkArrayDataWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkArrayDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkArrayDataWriter_BinaryOff_01(HandleRef pThis);

	/// <summary>
	/// Get / set whether data will be written in binary format (when used as a filter).
	/// </summary>
	public virtual void BinaryOff()
	{
		vtkArrayDataWriter_BinaryOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayDataWriter_BinaryOn_02(HandleRef pThis);

	/// <summary>
	/// Get / set whether data will be written in binary format (when used as a filter).
	/// </summary>
	public virtual void BinaryOn()
	{
		vtkArrayDataWriter_BinaryOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayDataWriter_GetBinary_03(HandleRef pThis);

	/// <summary>
	/// Get / set whether data will be written in binary format (when used as a filter).
	/// </summary>
	public virtual int GetBinary()
	{
		return vtkArrayDataWriter_GetBinary_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayDataWriter_GetFileName_04(HandleRef pThis);

	/// <summary>
	/// Get / set the filename where data will be stored (when used as a filter).
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkArrayDataWriter_GetFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrayDataWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkArrayDataWriter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkArrayDataWriter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkArrayDataWriter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayDataWriter_GetOutputString_07(HandleRef pThis);

	/// <summary>
	/// The output string. This is only set when WriteToOutputString is set.
	/// </summary>
	public virtual string GetOutputString()
	{
		return vtkArrayDataWriter_GetOutputString_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayDataWriter_GetWriteToOutputString_08(HandleRef pThis);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public virtual bool GetWriteToOutputString()
	{
		return (vtkArrayDataWriter_GetWriteToOutputString_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayDataWriter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkArrayDataWriter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayDataWriter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkArrayDataWriter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayDataWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkArrayDataWriter NewInstance()
	{
		vtkArrayDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayDataWriter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkArrayDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkArrayDataWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkArrayDataWriter SafeDownCast(vtkObjectBase o)
	{
		vtkArrayDataWriter vtkArrayDataWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkArrayDataWriter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArrayDataWriter2 = (vtkArrayDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArrayDataWriter2.Register(null);
			}
		}
		return vtkArrayDataWriter2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayDataWriter_SetBinary_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Get / set whether data will be written in binary format (when used as a filter).
	/// </summary>
	public virtual void SetBinary(int _arg)
	{
		vtkArrayDataWriter_SetBinary_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayDataWriter_SetFileName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Get / set the filename where data will be stored (when used as a filter).
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkArrayDataWriter_SetFileName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayDataWriter_SetWriteToOutputString_16(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public virtual void SetWriteToOutputString(bool _arg)
	{
		vtkArrayDataWriter_SetWriteToOutputString_16(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkArrayDataWriter_Write_17(HandleRef pThis);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public override int Write()
	{
		return vtkArrayDataWriter_Write_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayDataWriter_Write_18(HandleRef pThis, string FileName, byte WriteBinary);

	/// <summary>
	/// Writes input port 0 data to a file, using an arbitrary filename and binary flag.
	/// </summary>
	public bool Write(string FileName, bool WriteBinary)
	{
		return (vtkArrayDataWriter_Write_18(GetCppThis(), FileName, (byte)(WriteBinary ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkArrayDataWriter_Write_19(HandleRef array, string file_name, byte WriteBinary);

	/// <summary>
	/// Write an arbitrary array to a file, without using the pipeline.
	/// </summary>
	public static bool Write(vtkArrayData array, string file_name, bool WriteBinary)
	{
		return (vtkArrayDataWriter_Write_19(array?.GetCppThis() ?? default(HandleRef), file_name, (byte)(WriteBinary ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayDataWriter_Write_20(HandleRef pThis, byte WriteBinary);

	/// <summary>
	/// Write input port 0 data to a string. Note that the WriteBinary argument is not
	/// optional in order to not clash with the inherited Write() method.
	/// </summary>
	public string Write(bool WriteBinary)
	{
		return vtkArrayDataWriter_Write_20(GetCppThis(), (byte)(WriteBinary ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkArrayDataWriter_Write_21(HandleRef array, byte WriteBinary);

	/// <summary>
	/// Write arbitrary data to a string without using the pipeline.
	/// </summary>
	public static string Write(vtkArrayData array, bool WriteBinary)
	{
		return vtkArrayDataWriter_Write_21(array?.GetCppThis() ?? default(HandleRef), (byte)(WriteBinary ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayDataWriter_WriteToOutputStringOff_22(HandleRef pThis);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public virtual void WriteToOutputStringOff()
	{
		vtkArrayDataWriter_WriteToOutputStringOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkArrayDataWriter_WriteToOutputStringOn_23(HandleRef pThis);

	/// <summary>
	/// Whether to output to a string instead of to a file, which is the default.
	/// </summary>
	public virtual void WriteToOutputStringOn()
	{
		vtkArrayDataWriter_WriteToOutputStringOn_23(GetCppThis());
	}
}
