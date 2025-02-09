using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDelimitedTextReader
/// </summary>
/// <remarks>
///    reads in delimited ascii or unicode text files
/// and outputs a vtkTable data structure.
///
///
/// vtkDelimitedTextReader is an interface for pulling in data from a
/// flat, delimited ascii or unicode text file (delimiter can be any character).
///
/// The behavior of the reader with respect to ascii or unicode input
/// is controlled by the SetUnicodeCharacterSet() method.  By default
/// (without calling SetUnicodeCharacterSet()), the reader will expect
/// to read ascii text and will output vtkStdString columns.  Use the
/// Set and Get methods to set delimiters that do not contain UTF8 in
/// the name when operating the reader in default ascii mode.  If the
/// SetUnicodeCharacterSet() method is called, the reader will output
/// vtkStdString columns in the output table.  In addition, it is
/// necessary to use the Set and Get methods that contain UTF8 in the
/// name to specify delimiters when operating in unicode mode.
///
/// There is also a special character set US-ASCII-WITH-FALLBACK that
/// will treat the input text as ASCII no matter what.  If and when it
/// encounters a character with its 8th bit set it will replace that
/// character with the code point ReplacementCharacter.  You may use
/// this if you have text that belongs to a code page like LATIN9 or
/// ISO-8859-1 or friends: mostly ASCII but not entirely.  Eventually
/// this class will acquire the ability to read gracefully text from
/// any code page, making this option obsolete.
///
/// This class emits ProgressEvent for every 100 lines it reads.
///
/// @par Thanks:
/// Thanks to Andy Wilson, Brian Wylie, Tim Shead, and Thomas Otahal
/// from Sandia National Laboratories for implementing this class.
///
///
/// @warning
/// This reader assumes that the first line in the file (whether that's
/// headers or the first document) contains at least as many fields as
/// any other line in the file.
/// </remarks>
public class vtkDelimitedTextReader : vtkTableAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDelimitedTextReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDelimitedTextReader()
	{
		MRClassNameKey = "class vtkDelimitedTextReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelimitedTextReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDelimitedTextReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDelimitedTextReader New()
	{
		vtkDelimitedTextReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelimitedTextReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDelimitedTextReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDelimitedTextReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_AddTabFieldDelimiterOff_01(HandleRef pThis);

	/// <summary>
	/// If on, also add in the tab (i.e. \c '\\t') character as a field delimiter.
	/// We add this specially since applications may have a more
	/// difficult time doing this. Defaults to off.
	/// </summary>
	public virtual void AddTabFieldDelimiterOff()
	{
		vtkDelimitedTextReader_AddTabFieldDelimiterOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_AddTabFieldDelimiterOn_02(HandleRef pThis);

	/// <summary>
	/// If on, also add in the tab (i.e. \c '\\t') character as a field delimiter.
	/// We add this specially since applications may have a more
	/// difficult time doing this. Defaults to off.
	/// </summary>
	public virtual void AddTabFieldDelimiterOn()
	{
		vtkDelimitedTextReader_AddTabFieldDelimiterOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_DetectNumericColumnsOff_03(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader will detect numeric columns and create
	/// vtkDoubleArray or vtkIntArray for those instead of vtkStringArray. Default
	/// is off.
	/// </summary>
	public virtual void DetectNumericColumnsOff()
	{
		vtkDelimitedTextReader_DetectNumericColumnsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_DetectNumericColumnsOn_04(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader will detect numeric columns and create
	/// vtkDoubleArray or vtkIntArray for those instead of vtkStringArray. Default
	/// is off.
	/// </summary>
	public virtual void DetectNumericColumnsOn()
	{
		vtkDelimitedTextReader_DetectNumericColumnsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_ForceDoubleOff_05(HandleRef pThis);

	/// <summary>
	/// When set to true and DetectNumericColumns is also true, forces all
	/// numeric columns to vtkDoubleArray even if they contain only
	/// integer values. Default is off.
	/// </summary>
	public virtual void ForceDoubleOff()
	{
		vtkDelimitedTextReader_ForceDoubleOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_ForceDoubleOn_06(HandleRef pThis);

	/// <summary>
	/// When set to true and DetectNumericColumns is also true, forces all
	/// numeric columns to vtkDoubleArray even if they contain only
	/// integer values. Default is off.
	/// </summary>
	public virtual void ForceDoubleOn()
	{
		vtkDelimitedTextReader_ForceDoubleOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_GeneratePedigreeIdsOff_07(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void GeneratePedigreeIdsOff()
	{
		vtkDelimitedTextReader_GeneratePedigreeIdsOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_GeneratePedigreeIdsOn_08(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void GeneratePedigreeIdsOn()
	{
		vtkDelimitedTextReader_GeneratePedigreeIdsOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetAddTabFieldDelimiter_09(HandleRef pThis);

	/// <summary>
	/// If on, also add in the tab (i.e. \c '\\t') character as a field delimiter.
	/// We add this specially since applications may have a more
	/// difficult time doing this. Defaults to off.
	/// </summary>
	public virtual bool GetAddTabFieldDelimiter()
	{
		return (vtkDelimitedTextReader_GetAddTabFieldDelimiter_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDelimitedTextReader_GetDefaultDoubleValue_10(HandleRef pThis);

	/// <summary>
	/// When DetectNumericColumns is set to true, the reader use this value to populate
	/// the vtkDoubleArray where empty strings are found. Default is 0.0
	/// </summary>
	public virtual double GetDefaultDoubleValue()
	{
		return vtkDelimitedTextReader_GetDefaultDoubleValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelimitedTextReader_GetDefaultIntegerValue_11(HandleRef pThis);

	/// <summary>
	/// When DetectNumericColumns is set to true, the reader use this value to populate
	/// the vtkIntArray where empty strings are found. Default is 0.
	/// </summary>
	public virtual int GetDefaultIntegerValue()
	{
		return vtkDelimitedTextReader_GetDefaultIntegerValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetDetectNumericColumns_12(HandleRef pThis);

	/// <summary>
	/// When set to true, the reader will detect numeric columns and create
	/// vtkDoubleArray or vtkIntArray for those instead of vtkStringArray. Default
	/// is off.
	/// </summary>
	public virtual bool GetDetectNumericColumns()
	{
		return (vtkDelimitedTextReader_GetDetectNumericColumns_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_GetFieldDelimiterCharacters_13(HandleRef pThis);

	/// <summary>
	/// Specify the character(s) that will be used to separate fields.  For
	/// example, set this to "," for a comma-separated value file.  Set
	/// it to ".:;" for a file where columns can be separated by a
	/// period, colon or semicolon.  The order of the characters in the
	/// string does not matter.  Defaults to a comma.
	/// </summary>
	public virtual string GetFieldDelimiterCharacters()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextReader_GetFieldDelimiterCharacters_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_GetFileName_14(HandleRef pThis);

	/// <summary>
	/// Specifies the delimited text file to be loaded.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextReader_GetFileName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetForceDouble_15(HandleRef pThis);

	/// <summary>
	/// When set to true and DetectNumericColumns is also true, forces all
	/// numeric columns to vtkDoubleArray even if they contain only
	/// integer values. Default is off.
	/// </summary>
	public virtual bool GetForceDouble()
	{
		return (vtkDelimitedTextReader_GetForceDouble_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetGeneratePedigreeIds_16(HandleRef pThis);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual bool GetGeneratePedigreeIds()
	{
		return (vtkDelimitedTextReader_GetGeneratePedigreeIds_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetHaveHeaders_17(HandleRef pThis);

	/// <summary>
	/// Set/get whether to treat the first line of the file as headers.
	/// The default is false (no headers).
	/// </summary>
	public virtual bool GetHaveHeaders()
	{
		return (vtkDelimitedTextReader_GetHaveHeaders_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_GetInputString_18(HandleRef pThis);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public virtual string GetInputString()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextReader_GetInputString_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelimitedTextReader_GetInputStringLength_19(HandleRef pThis);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public virtual int GetInputStringLength()
	{
		return vtkDelimitedTextReader_GetInputStringLength_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDelimitedTextReader_GetLastError_20(HandleRef pThis);

	/// <summary>
	/// Returns a human-readable description of the most recent error, if any.
	/// Otherwise, returns an empty string.  Note that the result is only valid
	/// after calling Update().
	/// </summary>
	public string GetLastError()
	{
		return vtkDelimitedTextReader_GetLastError_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelimitedTextReader_GetMaxRecords_21(HandleRef pThis);

	/// <summary>
	/// Specifies the maximum number of records to read from the file.  Limiting the
	/// number of records to read is useful for previewing the contents of a file.
	/// </summary>
	public virtual long GetMaxRecords()
	{
		return vtkDelimitedTextReader_GetMaxRecords_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetMergeConsecutiveDelimiters_22(HandleRef pThis);

	/// <summary>
	/// Set/get whether to merge successive delimiters.  Use this if (for
	/// example) your fields are separated by spaces but you don't know
	/// exactly how many.
	/// </summary>
	public virtual bool GetMergeConsecutiveDelimiters()
	{
		return (vtkDelimitedTextReader_GetMergeConsecutiveDelimiters_22(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelimitedTextReader_GetNumberOfGenerationsFromBase_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDelimitedTextReader_GetNumberOfGenerationsFromBase_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDelimitedTextReader_GetNumberOfGenerationsFromBaseType_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDelimitedTextReader_GetNumberOfGenerationsFromBaseType_24(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetOutputPedigreeIds_25(HandleRef pThis);

	/// <summary>
	/// If on, assigns pedigree ids to output. Defaults to off.
	/// </summary>
	public virtual bool GetOutputPedigreeIds()
	{
		return (vtkDelimitedTextReader_GetOutputPedigreeIds_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_GetPedigreeIdArrayName_26(HandleRef pThis);

	/// <summary>
	/// The name of the array for generating or assigning pedigree ids
	/// (default "id").
	/// </summary>
	public virtual string GetPedigreeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextReader_GetPedigreeIdArrayName_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelimitedTextReader_GetReadFromInputString_27(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString or InputArray instead of the default,
	/// a file.
	/// </summary>
	public virtual int GetReadFromInputString()
	{
		return vtkDelimitedTextReader_GetReadFromInputString_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDelimitedTextReader_GetReplacementCharacter_28(HandleRef pThis);

	/// <summary>
	/// Fallback character for use in the US-ASCII-WITH-FALLBACK
	/// character set.  Any characters that have their 8th bit set will
	/// be replaced with this code point.  Defaults to 'x'.
	/// </summary>
	public virtual uint GetReplacementCharacter()
	{
		return vtkDelimitedTextReader_GetReplacementCharacter_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern sbyte vtkDelimitedTextReader_GetStringDelimiter_29(HandleRef pThis);

	/// <summary>
	/// Get/set the character that will begin and end strings.  Microsoft
	/// Excel, for example, will export the following format:
	///
	/// "First Field","Second Field","Field, With, Commas","Fourth Field"
	///
	/// The third field has a comma in it.  By using a string delimiter,
	/// this will be correctly read.  The delimiter defaults to '"'.
	/// </summary>
	public virtual sbyte GetStringDelimiter()
	{
		return vtkDelimitedTextReader_GetStringDelimiter_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetTrimWhitespacePriorToNumericConversion_30(HandleRef pThis);

	/// <summary>
	/// When DetectNumericColumns is set to true, whether to trim whitespace from
	/// strings prior to conversion to a numeric.
	/// Default is false to preserve backward compatibility.
	///
	/// vtkVariant handles whitespace inconsistently, so trim it before we try to
	/// convert it.  For example:
	///
	/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
	/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
	/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
	///
	/// In these cases, trimming the whitespace gives us the result we expect:
	/// 2.0 and INF respectively.
	/// </summary>
	public virtual bool GetTrimWhitespacePriorToNumericConversion()
	{
		return (vtkDelimitedTextReader_GetTrimWhitespacePriorToNumericConversion_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_GetUTF8FieldDelimiters_31(HandleRef pThis);

	/// <summary>
	/// Specify the character(s) that will be used to separate fields.  For
	/// example, set this to "," for a comma-separated value file.  Set
	/// it to ".:;" for a file where columns can be separated by a
	/// period, colon or semicolon.  The order of the characters in the
	/// string does not matter.  Defaults to a comma.
	/// </summary>
	public string GetUTF8FieldDelimiters()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextReader_GetUTF8FieldDelimiters_31(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_GetUTF8RecordDelimiters_32(HandleRef pThis);

	/// <summary>
	/// Specify the character(s) that will be used to separate records.
	/// The order of characters in the string does not matter.  Defaults
	/// to "\r\n".
	/// </summary>
	public string GetUTF8RecordDelimiters()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextReader_GetUTF8RecordDelimiters_32(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_GetUTF8StringDelimiters_33(HandleRef pThis);

	/// <summary>
	/// Get/set the character that will begin and end strings.  Microsoft
	/// Excel, for example, will export the following format:
	///
	/// "First Field","Second Field","Field, With, Commas","Fourth Field"
	///
	/// The third field has a comma in it.  By using a string delimiter,
	/// this will be correctly read.  The delimiter defaults to '"'.
	/// </summary>
	public string GetUTF8StringDelimiters()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextReader_GetUTF8StringDelimiters_33(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_GetUnicodeCharacterSet_34(HandleRef pThis);

	/// <summary>
	/// Specifies the character set used in the input file.  Valid character set
	/// names will be drawn from the list maintained by the Internet Assigned Name
	/// Authority at
	///
	/// http://www.iana.org/assignments/character-sets
	///
	/// Where multiple aliases are provided for a character set, the preferred MIME name
	/// will be used.  vtkUnicodeDelimitedTextReader currently supports "US-ASCII", "UTF-8",
	/// "UTF-16", "UTF-16BE", and "UTF-16LE" character sets.
	/// </summary>
	public virtual string GetUnicodeCharacterSet()
	{
		return Marshal.PtrToStringAnsi(vtkDelimitedTextReader_GetUnicodeCharacterSet_34(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDelimitedTextReader_GetUseStringDelimiter_35(HandleRef pThis);

	/// <summary>
	/// Set/get whether to use the string delimiter.  Defaults to on.
	/// </summary>
	public virtual bool GetUseStringDelimiter()
	{
		return (vtkDelimitedTextReader_GetUseStringDelimiter_35(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelimitedTextReader_IsA_36(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDelimitedTextReader_IsA_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDelimitedTextReader_IsTypeOf_37(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDelimitedTextReader_IsTypeOf_37(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_MergeConsecutiveDelimitersOff_38(HandleRef pThis);

	/// <summary>
	/// Set/get whether to merge successive delimiters.  Use this if (for
	/// example) your fields are separated by spaces but you don't know
	/// exactly how many.
	/// </summary>
	public virtual void MergeConsecutiveDelimitersOff()
	{
		vtkDelimitedTextReader_MergeConsecutiveDelimitersOff_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_MergeConsecutiveDelimitersOn_39(HandleRef pThis);

	/// <summary>
	/// Set/get whether to merge successive delimiters.  Use this if (for
	/// example) your fields are separated by spaces but you don't know
	/// exactly how many.
	/// </summary>
	public virtual void MergeConsecutiveDelimitersOn()
	{
		vtkDelimitedTextReader_MergeConsecutiveDelimitersOn_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDelimitedTextReader NewInstance()
	{
		vtkDelimitedTextReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelimitedTextReader_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_OutputPedigreeIdsOff_42(HandleRef pThis);

	/// <summary>
	/// If on, assigns pedigree ids to output. Defaults to off.
	/// </summary>
	public virtual void OutputPedigreeIdsOff()
	{
		vtkDelimitedTextReader_OutputPedigreeIdsOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_OutputPedigreeIdsOn_43(HandleRef pThis);

	/// <summary>
	/// If on, assigns pedigree ids to output. Defaults to off.
	/// </summary>
	public virtual void OutputPedigreeIdsOn()
	{
		vtkDelimitedTextReader_OutputPedigreeIdsOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_ReadFromInputStringOff_44(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString or InputArray instead of the default,
	/// a file.
	/// </summary>
	public virtual void ReadFromInputStringOff()
	{
		vtkDelimitedTextReader_ReadFromInputStringOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_ReadFromInputStringOn_45(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString or InputArray instead of the default,
	/// a file.
	/// </summary>
	public virtual void ReadFromInputStringOn()
	{
		vtkDelimitedTextReader_ReadFromInputStringOn_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDelimitedTextReader_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDelimitedTextReader SafeDownCast(vtkObjectBase o)
	{
		vtkDelimitedTextReader vtkDelimitedTextReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDelimitedTextReader_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDelimitedTextReader2 = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDelimitedTextReader2.Register(null);
			}
		}
		return vtkDelimitedTextReader2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetAddTabFieldDelimiter_47(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, also add in the tab (i.e. \c '\\t') character as a field delimiter.
	/// We add this specially since applications may have a more
	/// difficult time doing this. Defaults to off.
	/// </summary>
	public virtual void SetAddTabFieldDelimiter(bool _arg)
	{
		vtkDelimitedTextReader_SetAddTabFieldDelimiter_47(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetDefaultDoubleValue_48(HandleRef pThis, double _arg);

	/// <summary>
	/// When DetectNumericColumns is set to true, the reader use this value to populate
	/// the vtkDoubleArray where empty strings are found. Default is 0.0
	/// </summary>
	public virtual void SetDefaultDoubleValue(double _arg)
	{
		vtkDelimitedTextReader_SetDefaultDoubleValue_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetDefaultIntegerValue_49(HandleRef pThis, int _arg);

	/// <summary>
	/// When DetectNumericColumns is set to true, the reader use this value to populate
	/// the vtkIntArray where empty strings are found. Default is 0.
	/// </summary>
	public virtual void SetDefaultIntegerValue(int _arg)
	{
		vtkDelimitedTextReader_SetDefaultIntegerValue_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetDetectNumericColumns_50(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true, the reader will detect numeric columns and create
	/// vtkDoubleArray or vtkIntArray for those instead of vtkStringArray. Default
	/// is off.
	/// </summary>
	public virtual void SetDetectNumericColumns(bool _arg)
	{
		vtkDelimitedTextReader_SetDetectNumericColumns_50(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetFieldDelimiterCharacters_51(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the character(s) that will be used to separate fields.  For
	/// example, set this to "," for a comma-separated value file.  Set
	/// it to ".:;" for a file where columns can be separated by a
	/// period, colon or semicolon.  The order of the characters in the
	/// string does not matter.  Defaults to a comma.
	/// </summary>
	public virtual void SetFieldDelimiterCharacters(string _arg)
	{
		vtkDelimitedTextReader_SetFieldDelimiterCharacters_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetFileName_52(HandleRef pThis, string _arg);

	/// <summary>
	/// Specifies the delimited text file to be loaded.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkDelimitedTextReader_SetFileName_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetForceDouble_53(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true and DetectNumericColumns is also true, forces all
	/// numeric columns to vtkDoubleArray even if they contain only
	/// integer values. Default is off.
	/// </summary>
	public virtual void SetForceDouble(bool _arg)
	{
		vtkDelimitedTextReader_SetForceDouble_53(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetGeneratePedigreeIds_54(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on (default), generates pedigree ids automatically.
	/// If off, assign one of the arrays to be the pedigree id.
	/// </summary>
	public virtual void SetGeneratePedigreeIds(bool _arg)
	{
		vtkDelimitedTextReader_SetGeneratePedigreeIds_54(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetHaveHeaders_55(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether to treat the first line of the file as headers.
	/// The default is false (no headers).
	/// </summary>
	public virtual void SetHaveHeaders(bool _arg)
	{
		vtkDelimitedTextReader_SetHaveHeaders_55(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetInputString_56(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public void SetInputString(string arg0)
	{
		vtkDelimitedTextReader_SetInputString_56(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetInputString_57(HandleRef pThis, string arg0, int len);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public void SetInputString(string arg0, int len)
	{
		vtkDelimitedTextReader_SetInputString_57(GetCppThis(), arg0, len);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetMaxRecords_58(HandleRef pThis, long _arg);

	/// <summary>
	/// Specifies the maximum number of records to read from the file.  Limiting the
	/// number of records to read is useful for previewing the contents of a file.
	/// </summary>
	public virtual void SetMaxRecords(long _arg)
	{
		vtkDelimitedTextReader_SetMaxRecords_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetMergeConsecutiveDelimiters_59(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether to merge successive delimiters.  Use this if (for
	/// example) your fields are separated by spaces but you don't know
	/// exactly how many.
	/// </summary>
	public virtual void SetMergeConsecutiveDelimiters(bool _arg)
	{
		vtkDelimitedTextReader_SetMergeConsecutiveDelimiters_59(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetOutputPedigreeIds_60(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, assigns pedigree ids to output. Defaults to off.
	/// </summary>
	public virtual void SetOutputPedigreeIds(bool _arg)
	{
		vtkDelimitedTextReader_SetOutputPedigreeIds_60(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetPedigreeIdArrayName_61(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the array for generating or assigning pedigree ids
	/// (default "id").
	/// </summary>
	public virtual void SetPedigreeIdArrayName(string _arg)
	{
		vtkDelimitedTextReader_SetPedigreeIdArrayName_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetReadFromInputString_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading from an InputString or InputArray instead of the default,
	/// a file.
	/// </summary>
	public virtual void SetReadFromInputString(int _arg)
	{
		vtkDelimitedTextReader_SetReadFromInputString_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetReplacementCharacter_63(HandleRef pThis, uint _arg);

	/// <summary>
	/// Fallback character for use in the US-ASCII-WITH-FALLBACK
	/// character set.  Any characters that have their 8th bit set will
	/// be replaced with this code point.  Defaults to 'x'.
	/// </summary>
	public virtual void SetReplacementCharacter(uint _arg)
	{
		vtkDelimitedTextReader_SetReplacementCharacter_63(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetStringDelimiter_64(HandleRef pThis, sbyte _arg);

	/// <summary>
	/// Get/set the character that will begin and end strings.  Microsoft
	/// Excel, for example, will export the following format:
	///
	/// "First Field","Second Field","Field, With, Commas","Fourth Field"
	///
	/// The third field has a comma in it.  By using a string delimiter,
	/// this will be correctly read.  The delimiter defaults to '"'.
	/// </summary>
	public virtual void SetStringDelimiter(sbyte _arg)
	{
		vtkDelimitedTextReader_SetStringDelimiter_64(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetTrimWhitespacePriorToNumericConversion_65(HandleRef pThis, byte _arg);

	/// <summary>
	/// When DetectNumericColumns is set to true, whether to trim whitespace from
	/// strings prior to conversion to a numeric.
	/// Default is false to preserve backward compatibility.
	///
	/// vtkVariant handles whitespace inconsistently, so trim it before we try to
	/// convert it.  For example:
	///
	/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
	/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
	/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
	///
	/// In these cases, trimming the whitespace gives us the result we expect:
	/// 2.0 and INF respectively.
	/// </summary>
	public virtual void SetTrimWhitespacePriorToNumericConversion(bool _arg)
	{
		vtkDelimitedTextReader_SetTrimWhitespacePriorToNumericConversion_65(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetUTF8FieldDelimiters_66(HandleRef pThis, string delimiters);

	/// <summary>
	/// Specify the character(s) that will be used to separate fields.  For
	/// example, set this to "," for a comma-separated value file.  Set
	/// it to ".:;" for a file where columns can be separated by a
	/// period, colon or semicolon.  The order of the characters in the
	/// string does not matter.  Defaults to a comma.
	/// </summary>
	public void SetUTF8FieldDelimiters(string delimiters)
	{
		vtkDelimitedTextReader_SetUTF8FieldDelimiters_66(GetCppThis(), delimiters);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetUTF8RecordDelimiters_67(HandleRef pThis, string delimiters);

	/// <summary>
	/// Specify the character(s) that will be used to separate records.
	/// The order of characters in the string does not matter.  Defaults
	/// to "\r\n".
	/// </summary>
	public void SetUTF8RecordDelimiters(string delimiters)
	{
		vtkDelimitedTextReader_SetUTF8RecordDelimiters_67(GetCppThis(), delimiters);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetUTF8StringDelimiters_68(HandleRef pThis, string delimiters);

	/// <summary>
	/// Get/set the character that will begin and end strings.  Microsoft
	/// Excel, for example, will export the following format:
	///
	/// "First Field","Second Field","Field, With, Commas","Fourth Field"
	///
	/// The third field has a comma in it.  By using a string delimiter,
	/// this will be correctly read.  The delimiter defaults to '"'.
	/// </summary>
	public void SetUTF8StringDelimiters(string delimiters)
	{
		vtkDelimitedTextReader_SetUTF8StringDelimiters_68(GetCppThis(), delimiters);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetUnicodeCharacterSet_69(HandleRef pThis, string _arg);

	/// <summary>
	/// Specifies the character set used in the input file.  Valid character set
	/// names will be drawn from the list maintained by the Internet Assigned Name
	/// Authority at
	///
	/// http://www.iana.org/assignments/character-sets
	///
	/// Where multiple aliases are provided for a character set, the preferred MIME name
	/// will be used.  vtkUnicodeDelimitedTextReader currently supports "US-ASCII", "UTF-8",
	/// "UTF-16", "UTF-16BE", and "UTF-16LE" character sets.
	/// </summary>
	public virtual void SetUnicodeCharacterSet(string _arg)
	{
		vtkDelimitedTextReader_SetUnicodeCharacterSet_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_SetUseStringDelimiter_70(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether to use the string delimiter.  Defaults to on.
	/// </summary>
	public virtual void SetUseStringDelimiter(bool _arg)
	{
		vtkDelimitedTextReader_SetUseStringDelimiter_70(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_TrimWhitespacePriorToNumericConversionOff_71(HandleRef pThis);

	/// <summary>
	/// When DetectNumericColumns is set to true, whether to trim whitespace from
	/// strings prior to conversion to a numeric.
	/// Default is false to preserve backward compatibility.
	///
	/// vtkVariant handles whitespace inconsistently, so trim it before we try to
	/// convert it.  For example:
	///
	/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
	/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
	/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
	///
	/// In these cases, trimming the whitespace gives us the result we expect:
	/// 2.0 and INF respectively.
	/// </summary>
	public virtual void TrimWhitespacePriorToNumericConversionOff()
	{
		vtkDelimitedTextReader_TrimWhitespacePriorToNumericConversionOff_71(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_TrimWhitespacePriorToNumericConversionOn_72(HandleRef pThis);

	/// <summary>
	/// When DetectNumericColumns is set to true, whether to trim whitespace from
	/// strings prior to conversion to a numeric.
	/// Default is false to preserve backward compatibility.
	///
	/// vtkVariant handles whitespace inconsistently, so trim it before we try to
	/// convert it.  For example:
	///
	/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
	/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
	/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
	///
	/// In these cases, trimming the whitespace gives us the result we expect:
	/// 2.0 and INF respectively.
	/// </summary>
	public virtual void TrimWhitespacePriorToNumericConversionOn()
	{
		vtkDelimitedTextReader_TrimWhitespacePriorToNumericConversionOn_72(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_UseStringDelimiterOff_73(HandleRef pThis);

	/// <summary>
	/// Set/get whether to use the string delimiter.  Defaults to on.
	/// </summary>
	public virtual void UseStringDelimiterOff()
	{
		vtkDelimitedTextReader_UseStringDelimiterOff_73(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDelimitedTextReader_UseStringDelimiterOn_74(HandleRef pThis);

	/// <summary>
	/// Set/get whether to use the string delimiter.  Defaults to on.
	/// </summary>
	public virtual void UseStringDelimiterOn()
	{
		vtkDelimitedTextReader_UseStringDelimiterOn_74(GetCppThis());
	}
}
