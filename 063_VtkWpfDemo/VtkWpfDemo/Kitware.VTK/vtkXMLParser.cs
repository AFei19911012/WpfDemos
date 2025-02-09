using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLParser
/// </summary>
/// <remarks>
///    Parse XML to handle element tags and attributes.
///
/// vtkXMLParser reads a stream and parses XML element tags and corresponding
/// attributes.  Each element begin tag and its attributes are sent to
/// the StartElement method.  Each element end tag is sent to the
/// EndElement method.  Subclasses should replace these methods to actually
/// use the tags.
/// </remarks>
public class vtkXMLParser : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLParser";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLParser()
	{
		MRClassNameKey = "class vtkXMLParser";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLParser"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLParser New()
	{
		vtkXMLParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLParser()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkXMLParser_CleanupParser_01(HandleRef pThis);

	/// <summary>
	/// When parsing fragments of XML, or when streaming XML,
	/// use the following three methods:
	/// - InitializeParser() initializes the parser
	/// but does not perform any actual parsing.
	/// - ParseChunk() parses a fragment of XML;
	/// this has to match to what was already parsed.
	/// - CleanupParser() finishes parsing;
	/// if there were errors, it will report them.
	/// </summary>
	public virtual int CleanupParser()
	{
		return vtkXMLParser_CleanupParser_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLParser_GetEncoding_02(HandleRef pThis);

	/// <summary>
	/// Set and get the encoding the parser should expect (nullptr defaults to
	/// Expat's own default encoder, i.e UTF-8).
	/// This should be set before parsing (i.e. a call to Parse()) or
	/// even initializing the parser (i.e. a call to InitializeParser())
	/// </summary>
	public virtual string GetEncoding()
	{
		return Marshal.PtrToStringAnsi(vtkXMLParser_GetEncoding_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLParser_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Set and get file name.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLParser_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLParser_GetIgnoreCharacterData_04(HandleRef pThis);

	/// <summary>
	/// If this is off (the default), CharacterDataHandler will be called to
	/// process text within XML Elements. If this is on, the text will be
	/// ignored.
	/// </summary>
	public virtual int GetIgnoreCharacterData()
	{
		return vtkXMLParser_GetIgnoreCharacterData_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLParser_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLParser_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLParser_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLParser_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLParser_InitializeParser_07(HandleRef pThis);

	/// <summary>
	/// When parsing fragments of XML, or when streaming XML,
	/// use the following three methods:
	/// - InitializeParser() initializes the parser
	/// but does not perform any actual parsing.
	/// - ParseChunk() parses a fragment of XML;
	/// this has to match to what was already parsed.
	/// - CleanupParser() finishes parsing;
	/// if there were errors, it will report them.
	/// </summary>
	public virtual int InitializeParser()
	{
		return vtkXMLParser_InitializeParser_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLParser_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLParser_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLParser_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLParser_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLParser_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLParser NewInstance()
	{
		vtkXMLParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLParser_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLParser_Parse_12(HandleRef pThis);

	/// <summary>
	/// Parse the XML input.
	/// </summary>
	public virtual int Parse()
	{
		return vtkXMLParser_Parse_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLParser_Parse_13(HandleRef pThis, string inputString);

	/// <summary>
	/// Parse the XML message. If length is specified, parse only the
	/// first "length" characters
	/// </summary>
	public virtual int Parse(string inputString)
	{
		return vtkXMLParser_Parse_13(GetCppThis(), inputString);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLParser_Parse_14(HandleRef pThis, string inputString, uint length);

	/// <summary>
	/// Parse the XML message. If length is specified, parse only the
	/// first "length" characters
	/// </summary>
	public virtual int Parse(string inputString, uint length)
	{
		return vtkXMLParser_Parse_14(GetCppThis(), inputString, length);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLParser_ParseChunk_15(HandleRef pThis, string inputString, uint length);

	/// <summary>
	/// When parsing fragments of XML, or when streaming XML,
	/// use the following three methods:
	/// - InitializeParser() initializes the parser
	/// but does not perform any actual parsing.
	/// - ParseChunk() parses a fragment of XML;
	/// this has to match to what was already parsed.
	/// - CleanupParser() finishes parsing;
	/// if there were errors, it will report them.
	/// </summary>
	public virtual int ParseChunk(string inputString, uint length)
	{
		return vtkXMLParser_ParseChunk_15(GetCppThis(), inputString, length);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLParser_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLParser SafeDownCast(vtkObjectBase o)
	{
		vtkXMLParser vtkXMLParser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLParser_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLParser2 = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLParser2.Register(null);
			}
		}
		return vtkXMLParser2;
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLParser_SeekG_17(HandleRef pThis, long position);

	/// <summary>
	/// Used by subclasses and their supporting classes.  These methods
	/// wrap around the tellg and seekg methods of the input stream to
	/// work-around stream bugs on various platforms.
	/// </summary>
	public void SeekG(long position)
	{
		vtkXMLParser_SeekG_17(GetCppThis(), position);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLParser_SetEncoding_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Set and get the encoding the parser should expect (nullptr defaults to
	/// Expat's own default encoder, i.e UTF-8).
	/// This should be set before parsing (i.e. a call to Parse()) or
	/// even initializing the parser (i.e. a call to InitializeParser())
	/// </summary>
	public virtual void SetEncoding(string _arg)
	{
		vtkXMLParser_SetEncoding_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLParser_SetFileName_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Set and get file name.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkXMLParser_SetFileName_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLParser_SetIgnoreCharacterData_20(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is off (the default), CharacterDataHandler will be called to
	/// process text within XML Elements. If this is on, the text will be
	/// ignored.
	/// </summary>
	public virtual void SetIgnoreCharacterData(int _arg)
	{
		vtkXMLParser_SetIgnoreCharacterData_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLParser_TellG_21(HandleRef pThis);

	/// <summary>
	/// Used by subclasses and their supporting classes.  These methods
	/// wrap around the tellg and seekg methods of the input stream to
	/// work-around stream bugs on various platforms.
	/// </summary>
	public long TellG()
	{
		return vtkXMLParser_TellG_21(GetCppThis());
	}
}
