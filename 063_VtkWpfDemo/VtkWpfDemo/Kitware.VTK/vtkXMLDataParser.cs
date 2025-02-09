using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLDataParser
/// </summary>
/// <remarks>
///    Used by vtkXMLReader to parse VTK XML files.
///
/// vtkXMLDataParser provides a subclass of vtkXMLParser that
/// constructs a representation of an XML data format's file using
/// vtkXMLDataElement to represent each XML element.  This
/// representation is then used by vtkXMLReader and its subclasses to
/// traverse the structure of the file and extract data.
///
/// </remarks>
/// <seealso>
///
/// vtkXMLDataElement
/// </seealso>
public class vtkXMLDataParser : vtkXMLParser
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
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataParser";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLDataParser()
	{
		MRClassNameKey = "class vtkXMLDataParser";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataParser"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLDataParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLDataParser New()
	{
		vtkXMLDataParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLDataParser()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLDataParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataParser_CharacterDataHandler_01(HandleRef pThis, string data, int length);

	/// <summary>
	/// If you need the text inside XMLElements, turn IgnoreCharacterData off.
	/// This method will then be called when the file is parsed, and the text
	/// will be stored in each XMLDataElement. VTK XML Readers store the
	/// information elsewhere, so the default is to ignore it.
	/// </summary>
	public virtual void CharacterDataHandler(string data, int length)
	{
		vtkXMLDataParser_CharacterDataHandler_01(GetCppThis(), data, length);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataParser_GetAbort_02(HandleRef pThis);

	/// <summary>
	/// Get/Set flag to abort reading of data.  This may be set by a
	/// progress event observer.
	/// </summary>
	public virtual int GetAbort()
	{
		return vtkXMLDataParser_GetAbort_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLDataParser_GetAppendedDataPosition_03(HandleRef pThis);

	/// <summary>
	/// Returns the byte index of where appended data starts (if the
	/// file is using appended data). Valid after the XML is parsed.
	/// </summary>
	public long GetAppendedDataPosition()
	{
		return vtkXMLDataParser_GetAppendedDataPosition_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataParser_GetAttributesEncoding_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the character encoding that will be used to set the attributes's
	/// encoding type of each vtkXMLDataElement created by this parser (i.e.,
	/// the data element attributes will use that encoding internally).
	/// If set to VTK_ENCODING_NONE (default), the attribute encoding type will
	/// not be changed and will default to the vtkXMLDataElement default encoding
	/// type (see vtkXMLDataElement::AttributeEncoding).
	/// </summary>
	public virtual int GetAttributesEncoding()
	{
		return vtkXMLDataParser_GetAttributesEncoding_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataParser_GetAttributesEncodingMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the character encoding that will be used to set the attributes's
	/// encoding type of each vtkXMLDataElement created by this parser (i.e.,
	/// the data element attributes will use that encoding internally).
	/// If set to VTK_ENCODING_NONE (default), the attribute encoding type will
	/// not be changed and will default to the vtkXMLDataElement default encoding
	/// type (see vtkXMLDataElement::AttributeEncoding).
	/// </summary>
	public virtual int GetAttributesEncodingMaxValue()
	{
		return vtkXMLDataParser_GetAttributesEncodingMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataParser_GetAttributesEncodingMinValue_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the character encoding that will be used to set the attributes's
	/// encoding type of each vtkXMLDataElement created by this parser (i.e.,
	/// the data element attributes will use that encoding internally).
	/// If set to VTK_ENCODING_NONE (default), the attribute encoding type will
	/// not be changed and will default to the vtkXMLDataElement default encoding
	/// type (see vtkXMLDataElement::AttributeEncoding).
	/// </summary>
	public virtual int GetAttributesEncodingMinValue()
	{
		return vtkXMLDataParser_GetAttributesEncodingMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataParser_GetCompressor_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the compressor used to decompress binary and appended data
	/// after reading from the file.
	/// </summary>
	public virtual vtkDataCompressor GetCompressor()
	{
		vtkDataCompressor vtkDataCompressor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataParser_GetCompressor_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLDataParser_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLDataParser_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLDataParser_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLDataParser_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkXMLDataParser_GetProgress_10(HandleRef pThis);

	/// <summary>
	/// Get/Set progress of reading data.  This may be checked by a
	/// progress event observer.
	/// </summary>
	public virtual float GetProgress()
	{
		return vtkXMLDataParser_GetProgress_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataParser_GetRootElement_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the root element from the XML document.
	/// </summary>
	public vtkXMLDataElement GetRootElement()
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataParser_GetRootElement_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLDataElement2 = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLDataElement2.Register(null);
			}
		}
		return vtkXMLDataElement2;
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkXMLDataParser_GetWordTypeSize_12(HandleRef pThis, int wordType);

	/// <summary>
	/// Get the size of a word of the given type.
	/// </summary>
	public ulong GetWordTypeSize(int wordType)
	{
		return vtkXMLDataParser_GetWordTypeSize_12(GetCppThis(), wordType);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataParser_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLDataParser_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataParser_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLDataParser_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataParser_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLDataParser NewInstance()
	{
		vtkXMLDataParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataParser_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataParser_Parse_17(HandleRef pThis);

	/// <summary>
	/// Parse the XML input and check that the file is safe to read.
	/// Returns 1 for okay, 0 for error.
	/// </summary>
	public override int Parse()
	{
		return vtkXMLDataParser_Parse_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkXMLDataParser_ReadAppendedData_18(HandleRef pThis, long offset, IntPtr buffer, ulong startWord, ulong numWords, int wordType);

	/// <summary>
	/// Read from an appended data section starting at the given appended
	/// data offset.  Returns the number of words read.
	/// </summary>
	public ulong ReadAppendedData(long offset, IntPtr buffer, ulong startWord, ulong numWords, int wordType)
	{
		return vtkXMLDataParser_ReadAppendedData_18(GetCppThis(), offset, buffer, startWord, numWords, wordType);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkXMLDataParser_ReadAppendedData_19(HandleRef pThis, long offset, string buffer, ulong startWord, ulong numWords);

	/// <summary>
	/// Read from an appended data section starting at the given appended
	/// data offset.  Returns the number of words read.
	/// </summary>
	public ulong ReadAppendedData(long offset, string buffer, ulong startWord, ulong numWords)
	{
		return vtkXMLDataParser_ReadAppendedData_19(GetCppThis(), offset, buffer, startWord, numWords);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkXMLDataParser_ReadAsciiData_20(HandleRef pThis, IntPtr buffer, ulong startWord, ulong numWords, int wordType);

	/// <summary>
	/// Read from an ascii data section starting at the current position in
	/// the stream.  Returns the number of words read.
	/// </summary>
	public ulong ReadAsciiData(IntPtr buffer, ulong startWord, ulong numWords, int wordType)
	{
		return vtkXMLDataParser_ReadAsciiData_20(GetCppThis(), buffer, startWord, numWords, wordType);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkXMLDataParser_ReadBinaryData_21(HandleRef pThis, IntPtr buffer, ulong startWord, ulong maxWords, int wordType);

	/// <summary>
	/// Read from a data section starting at the current position in the
	/// stream.  Returns the number of words read.
	/// </summary>
	public ulong ReadBinaryData(IntPtr buffer, ulong startWord, ulong maxWords, int wordType)
	{
		return vtkXMLDataParser_ReadBinaryData_21(GetCppThis(), buffer, startWord, maxWords, wordType);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkXMLDataParser_ReadInlineData_22(HandleRef pThis, HandleRef element, int isAscii, IntPtr buffer, ulong startWord, ulong numWords, int wordType);

	/// <summary>
	/// Read inline data from inside the given element.  Returns the
	/// number of words read.
	/// </summary>
	public ulong ReadInlineData(vtkXMLDataElement element, int isAscii, IntPtr buffer, ulong startWord, ulong numWords, int wordType)
	{
		return vtkXMLDataParser_ReadInlineData_22(GetCppThis(), element?.GetCppThis() ?? default(HandleRef), isAscii, buffer, startWord, numWords, wordType);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkXMLDataParser_ReadInlineData_23(HandleRef pThis, HandleRef element, int isAscii, string buffer, ulong startWord, ulong numWords);

	/// <summary>
	/// Read inline data from inside the given element.  Returns the
	/// number of words read.
	/// </summary>
	public ulong ReadInlineData(vtkXMLDataElement element, int isAscii, string buffer, ulong startWord, ulong numWords)
	{
		return vtkXMLDataParser_ReadInlineData_23(GetCppThis(), element?.GetCppThis() ?? default(HandleRef), isAscii, buffer, startWord, numWords);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataParser_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLDataParser SafeDownCast(vtkObjectBase o)
	{
		vtkXMLDataParser vtkXMLDataParser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataParser_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLDataParser2 = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLDataParser2.Register(null);
			}
		}
		return vtkXMLDataParser2;
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataParser_SetAbort_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set flag to abort reading of data.  This may be set by a
	/// progress event observer.
	/// </summary>
	public virtual void SetAbort(int _arg)
	{
		vtkXMLDataParser_SetAbort_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataParser_SetAttributesEncoding_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the character encoding that will be used to set the attributes's
	/// encoding type of each vtkXMLDataElement created by this parser (i.e.,
	/// the data element attributes will use that encoding internally).
	/// If set to VTK_ENCODING_NONE (default), the attribute encoding type will
	/// not be changed and will default to the vtkXMLDataElement default encoding
	/// type (see vtkXMLDataElement::AttributeEncoding).
	/// </summary>
	public virtual void SetAttributesEncoding(int _arg)
	{
		vtkXMLDataParser_SetAttributesEncoding_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataParser_SetCompressor_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the compressor used to decompress binary and appended data
	/// after reading from the file.
	/// </summary>
	public virtual void SetCompressor(vtkDataCompressor arg0)
	{
		vtkXMLDataParser_SetCompressor_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataParser_SetProgress_28(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set progress of reading data.  This may be checked by a
	/// progress event observer.
	/// </summary>
	public virtual void SetProgress(float _arg)
	{
		vtkXMLDataParser_SetProgress_28(GetCppThis(), _arg);
	}
}
