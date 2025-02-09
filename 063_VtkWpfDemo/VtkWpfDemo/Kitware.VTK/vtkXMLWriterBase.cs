using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkXMLWriterBase
/// </summary>
/// <remarks>
///  Abstract base class for VTK-XML writers.
///
/// vtkXMLWriterBase class was created to help refactor XML writers
/// (vtkXMLWriter and subclasses). Get/Set API on vtkXMLWriter is moved here while
/// all the gory implementation details are left in vtkXMLWriter. This enables use to create
/// a sibling hierarchy to vtkXMLWriter that uses a cleaner design to implement
/// the IO capabilities. Eventually, we vtkXMLWriter and its children will be
/// substituted by a parallel hierarchy at which point this class may merge with
/// it's new subclass.
/// </remarks>
public abstract class vtkXMLWriterBase : vtkAlgorithm
{
	/// <summary>
	/// Enumerate big and little endian byte order settings.
	/// </summary>
	public enum BigEndian_WrapperEnum
	{
		/// <summary>enum member</summary>
		BigEndian,
		/// <summary>enum member</summary>
		LittleEndian
	}

	/// <summary>
	/// Enumerate the supported data modes.
	/// Ascii = Inline ascii data.
	/// Binary = Inline binary data (base64 encoded, possibly compressed).
	/// Appended = Appended binary data (possibly compressed and/or base64).
	/// </summary>
	public enum Appended_WrapperEnum
	{
		/// <summary>enum member</summary>
		Appended = 2,
		/// <summary>enum member</summary>
		Ascii = 0,
		/// <summary>enum member</summary>
		Binary = 1
	}

	/// <summary>
	/// Enumerate the supported vtkIdType bit lengths.
	/// Int32 = File stores 32-bit values for vtkIdType.
	/// Int64 = File stores 64-bit values for vtkIdType.
	/// </summary>
	public enum Int32_WrapperEnum
	{
		/// <summary>enum member</summary>
		Int32 = 0x20,
		/// <summary>enum member</summary>
		Int64 = 0x40
	}

	/// <summary>
	/// Enumerate the supported binary data header bit lengths.
	/// UInt32 = File stores 32-bit binary data header elements.
	/// UInt64 = File stores 64-bit binary data header elements.
	/// </summary>
	public enum UInt32_WrapperEnum
	{
		/// <summary>enum member</summary>
		UInt32 = 0x20,
		/// <summary>enum member</summary>
		UInt64 = 0x40
	}

	/// <summary>
	/// Get/Set the compressor used to compress binary and appended data
	/// before writing to the file.  Default is a vtkZLibDataCompressor.
	/// </summary>
	public enum CompressorType
	{
		/// <summary>enum member</summary>
		LZ4 = 2,
		/// <summary>enum member</summary>
		LZMA = 3,
		/// <summary>enum member</summary>
		NONE = 0,
		/// <summary>enum member</summary>
		ZLIB = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLWriterBase";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLWriterBase()
	{
		MRClassNameKey = "class vtkXMLWriterBase";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLWriterBase"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLWriterBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_EncodeAppendedDataOff_01(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the appended data section is base64 encoded.  If
	/// encoded, reading and writing will be slower, but the file will be
	/// fully valid XML and text-only.  If not encoded, the XML
	/// specification will be violated, but reading and writing will be
	/// fast.  The default is to do the encoding.
	/// </summary>
	public virtual void EncodeAppendedDataOff()
	{
		vtkXMLWriterBase_EncodeAppendedDataOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_EncodeAppendedDataOn_02(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the appended data section is base64 encoded.  If
	/// encoded, reading and writing will be slower, but the file will be
	/// fully valid XML and text-only.  If not encoded, the XML
	/// specification will be violated, but reading and writing will be
	/// fast.  The default is to do the encoding.
	/// </summary>
	public virtual void EncodeAppendedDataOn()
	{
		vtkXMLWriterBase_EncodeAppendedDataOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkXMLWriterBase_GetBlockSize_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the block size used in compression.  When reading, this
	/// controls the granularity of how much extra information must be
	/// read when only part of the data are requested.  The value should
	/// be a multiple of the largest scalar data type.
	/// </summary>
	public virtual ulong GetBlockSize()
	{
		return vtkXMLWriterBase_GetBlockSize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriterBase_GetByteOrder_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the byte order of data written to the file.  The default
	/// is the machine's hardware byte order.
	/// </summary>
	public virtual int GetByteOrder()
	{
		return vtkXMLWriterBase_GetByteOrder_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriterBase_GetCompressionLevel_05(HandleRef pThis);

	/// <summary>
	/// Get/Set compression level.
	/// 1 (worst compression, fastest) ... 9 (best compression, slowest).
	/// </summary>
	public virtual int GetCompressionLevel()
	{
		return vtkXMLWriterBase_GetCompressionLevel_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLWriterBase_GetCompressor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the compressor used to compress binary and appended data
	/// before writing to the file.  Default is a vtkZLibDataCompressor.
	/// </summary>
	public virtual vtkDataCompressor GetCompressor()
	{
		vtkDataCompressor vtkDataCompressor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLWriterBase_GetCompressor_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataCompressor2 = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataCompressor2.Register(null);
			}
		}
		return vtkDataCompressor2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriterBase_GetDataMode_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the data mode used for the file's data.  The options are
	/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
	/// vtkXMLWriter::Appended.
	/// </summary>
	public virtual int GetDataMode()
	{
		return vtkXMLWriterBase_GetDataMode_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLWriterBase_GetDefaultFileExtension_08(HandleRef pThis);

	/// <summary>
	/// Get the default file extension for files written by this writer.
	/// </summary>
	public virtual string GetDefaultFileExtension()
	{
		return Marshal.PtrToStringAnsi(vtkXMLWriterBase_GetDefaultFileExtension_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLWriterBase_GetEncodeAppendedData_09(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the appended data section is base64 encoded.  If
	/// encoded, reading and writing will be slower, but the file will be
	/// fully valid XML and text-only.  If not encoded, the XML
	/// specification will be violated, but reading and writing will be
	/// fast.  The default is to do the encoding.
	/// </summary>
	public virtual bool GetEncodeAppendedData()
	{
		return (vtkXMLWriterBase_GetEncodeAppendedData_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLWriterBase_GetFileName_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the output file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLWriterBase_GetFileName_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriterBase_GetHeaderType_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the binary data header word type.  The default is UInt32.
	/// Set to UInt64 when storing arrays requiring 64-bit indexing.
	/// </summary>
	public virtual int GetHeaderType()
	{
		return vtkXMLWriterBase_GetHeaderType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriterBase_GetIdType_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the size of the vtkIdType values stored in the file.  The
	/// default is the real size of vtkIdType.
	/// </summary>
	public virtual int GetIdType()
	{
		return vtkXMLWriterBase_GetIdType_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLWriterBase_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLWriterBase_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLWriterBase_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLWriterBase_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkXMLWriterBase_GetOutputString_15(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public string GetOutputString()
	{
		return vtkXMLWriterBase_GetOutputString_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLWriterBase_GetWriteToOutputString_16(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual bool GetWriteToOutputString()
	{
		return (vtkXMLWriterBase_GetWriteToOutputString_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriterBase_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLWriterBase_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriterBase_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLWriterBase_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLWriterBase_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLWriterBase NewInstance()
	{
		vtkXMLWriterBase result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLWriterBase_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLWriterBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLWriterBase_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLWriterBase SafeDownCast(vtkObjectBase o)
	{
		vtkXMLWriterBase vtkXMLWriterBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLWriterBase_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLWriterBase2 = (vtkXMLWriterBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLWriterBase2.Register(null);
			}
		}
		return vtkXMLWriterBase2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetBlockSize_21(HandleRef pThis, ulong blockSize);

	/// <summary>
	/// Get/Set the block size used in compression.  When reading, this
	/// controls the granularity of how much extra information must be
	/// read when only part of the data are requested.  The value should
	/// be a multiple of the largest scalar data type.
	/// </summary>
	public virtual void SetBlockSize(ulong blockSize)
	{
		vtkXMLWriterBase_SetBlockSize_21(GetCppThis(), blockSize);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetByteOrder_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the byte order of data written to the file.  The default
	/// is the machine's hardware byte order.
	/// </summary>
	public virtual void SetByteOrder(int _arg)
	{
		vtkXMLWriterBase_SetByteOrder_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetByteOrderToBigEndian_23(HandleRef pThis);

	/// <summary>
	/// Get/Set the byte order of data written to the file.  The default
	/// is the machine's hardware byte order.
	/// </summary>
	public void SetByteOrderToBigEndian()
	{
		vtkXMLWriterBase_SetByteOrderToBigEndian_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetByteOrderToLittleEndian_24(HandleRef pThis);

	/// <summary>
	/// Get/Set the byte order of data written to the file.  The default
	/// is the machine's hardware byte order.
	/// </summary>
	public void SetByteOrderToLittleEndian()
	{
		vtkXMLWriterBase_SetByteOrderToLittleEndian_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetCompressionLevel_25(HandleRef pThis, int compressorLevel);

	/// <summary>
	/// Get/Set compression level.
	/// 1 (worst compression, fastest) ... 9 (best compression, slowest).
	/// </summary>
	public void SetCompressionLevel(int compressorLevel)
	{
		vtkXMLWriterBase_SetCompressionLevel_25(GetCppThis(), compressorLevel);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetCompressor_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the compressor used to compress binary and appended data
	/// before writing to the file.  Default is a vtkZLibDataCompressor.
	/// </summary>
	public virtual void SetCompressor(vtkDataCompressor arg0)
	{
		vtkXMLWriterBase_SetCompressor_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetCompressorType_27(HandleRef pThis, int compressorType);

	/// <summary>
	/// Convenience functions to set the compressor to certain known types.
	/// </summary>
	public void SetCompressorType(int compressorType)
	{
		vtkXMLWriterBase_SetCompressorType_27(GetCppThis(), compressorType);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetCompressorTypeToLZ4_28(HandleRef pThis);

	/// <summary>
	/// Convenience functions to set the compressor to certain known types.
	/// </summary>
	public void SetCompressorTypeToLZ4()
	{
		vtkXMLWriterBase_SetCompressorTypeToLZ4_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetCompressorTypeToLZMA_29(HandleRef pThis);

	/// <summary>
	/// Convenience functions to set the compressor to certain known types.
	/// </summary>
	public void SetCompressorTypeToLZMA()
	{
		vtkXMLWriterBase_SetCompressorTypeToLZMA_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetCompressorTypeToNone_30(HandleRef pThis);

	/// <summary>
	/// Convenience functions to set the compressor to certain known types.
	/// </summary>
	public void SetCompressorTypeToNone()
	{
		vtkXMLWriterBase_SetCompressorTypeToNone_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetCompressorTypeToZLib_31(HandleRef pThis);

	/// <summary>
	/// Convenience functions to set the compressor to certain known types.
	/// </summary>
	public void SetCompressorTypeToZLib()
	{
		vtkXMLWriterBase_SetCompressorTypeToZLib_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetDataMode_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the data mode used for the file's data.  The options are
	/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
	/// vtkXMLWriter::Appended.
	/// </summary>
	public virtual void SetDataMode(int _arg)
	{
		vtkXMLWriterBase_SetDataMode_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetDataModeToAppended_33(HandleRef pThis);

	/// <summary>
	/// Get/Set the data mode used for the file's data.  The options are
	/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
	/// vtkXMLWriter::Appended.
	/// </summary>
	public void SetDataModeToAppended()
	{
		vtkXMLWriterBase_SetDataModeToAppended_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetDataModeToAscii_34(HandleRef pThis);

	/// <summary>
	/// Get/Set the data mode used for the file's data.  The options are
	/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
	/// vtkXMLWriter::Appended.
	/// </summary>
	public void SetDataModeToAscii()
	{
		vtkXMLWriterBase_SetDataModeToAscii_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetDataModeToBinary_35(HandleRef pThis);

	/// <summary>
	/// Get/Set the data mode used for the file's data.  The options are
	/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
	/// vtkXMLWriter::Appended.
	/// </summary>
	public void SetDataModeToBinary()
	{
		vtkXMLWriterBase_SetDataModeToBinary_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetEncodeAppendedData_36(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether the appended data section is base64 encoded.  If
	/// encoded, reading and writing will be slower, but the file will be
	/// fully valid XML and text-only.  If not encoded, the XML
	/// specification will be violated, but reading and writing will be
	/// fast.  The default is to do the encoding.
	/// </summary>
	public virtual void SetEncodeAppendedData(bool _arg)
	{
		vtkXMLWriterBase_SetEncodeAppendedData_36(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetFileName_37(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the output file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkXMLWriterBase_SetFileName_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetHeaderType_38(HandleRef pThis, int arg0);

	/// <summary>
	/// Get/Set the binary data header word type.  The default is UInt32.
	/// Set to UInt64 when storing arrays requiring 64-bit indexing.
	/// </summary>
	public virtual void SetHeaderType(int arg0)
	{
		vtkXMLWriterBase_SetHeaderType_38(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetHeaderTypeToUInt32_39(HandleRef pThis);

	/// <summary>
	/// Get/Set the binary data header word type.  The default is UInt32.
	/// Set to UInt64 when storing arrays requiring 64-bit indexing.
	/// </summary>
	public void SetHeaderTypeToUInt32()
	{
		vtkXMLWriterBase_SetHeaderTypeToUInt32_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetHeaderTypeToUInt64_40(HandleRef pThis);

	/// <summary>
	/// Get/Set the binary data header word type.  The default is UInt32.
	/// Set to UInt64 when storing arrays requiring 64-bit indexing.
	/// </summary>
	public void SetHeaderTypeToUInt64()
	{
		vtkXMLWriterBase_SetHeaderTypeToUInt64_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetIdType_41(HandleRef pThis, int arg0);

	/// <summary>
	/// Get/Set the size of the vtkIdType values stored in the file.  The
	/// default is the real size of vtkIdType.
	/// </summary>
	public virtual void SetIdType(int arg0)
	{
		vtkXMLWriterBase_SetIdType_41(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetIdTypeToInt32_42(HandleRef pThis);

	/// <summary>
	/// Get/Set the size of the vtkIdType values stored in the file.  The
	/// default is the real size of vtkIdType.
	/// </summary>
	public void SetIdTypeToInt32()
	{
		vtkXMLWriterBase_SetIdTypeToInt32_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetIdTypeToInt64_43(HandleRef pThis);

	/// <summary>
	/// Get/Set the size of the vtkIdType values stored in the file.  The
	/// default is the real size of vtkIdType.
	/// </summary>
	public void SetIdTypeToInt64()
	{
		vtkXMLWriterBase_SetIdTypeToInt64_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_SetWriteToOutputString_44(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void SetWriteToOutputString(bool _arg)
	{
		vtkXMLWriterBase_SetWriteToOutputString_44(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLWriterBase_Write_45(HandleRef pThis);

	/// <summary>
	/// Invoke the writer.  Returns 1 for success, 0 for failure.
	/// </summary>
	public int Write()
	{
		return vtkXMLWriterBase_Write_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_WriteToOutputStringOff_46(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void WriteToOutputStringOff()
	{
		vtkXMLWriterBase_WriteToOutputStringOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLWriterBase_WriteToOutputStringOn_47(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void WriteToOutputStringOn()
	{
		vtkXMLWriterBase_WriteToOutputStringOn_47(GetCppThis());
	}
}
