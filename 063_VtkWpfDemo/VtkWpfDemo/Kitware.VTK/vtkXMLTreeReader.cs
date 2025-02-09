using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLTreeReader
/// </summary>
/// <remarks>
///    reads an XML file into a vtkTree
///
///
/// vtkXMLTreeReader parses an XML file and uses the nesting structure of the
/// XML tags to generate a tree.  Node attributes are assigned to node arrays,
/// and the special arrays .tagname and .chardata contain the tag type and the
/// text internal to the tag, respectively.  The arrays are of type
/// vtkStringArray.  There is an array for each attribute type in the XML file,
/// even if it appears in only one tag.  If an attribute is missing from a tag,
/// its value is the empty string.
///
/// If MaskArrays is on (the default is off), the filter will additionally make bit
/// arrays whose names are prepended with ".valid." which are 1 if the element
/// contains that attribute, and 0 otherwise.
///
/// For example, the XML file containing the text:
/// &lt;pre&gt;
/// &amp;lt;node name="jeff" age="26"&amp;gt;
///   this is text in jeff's node
///   &amp;lt;node name="joe"&amp;gt;
///     &amp;lt;node name="al" initials="amb" other="something"/&amp;gt;
///     &amp;lt;node name="dave" age="30"/&amp;gt;
///   &amp;lt;/node&amp;gt;
///   &amp;lt;node name="lisa"&amp;gt;this is text in lisa's node&amp;lt;/node&amp;gt;
///   &amp;lt;node name="darlene" age="29"/&amp;gt;
/// &amp;lt;/node&amp;gt;
/// &lt;/pre&gt;
///
/// would be parsed into a tree with the following node IDs and structure:
///
/// &lt;pre&gt;
/// 0 (jeff) - children: 1 (joe), 4 (lisa), 5 (darlene)
/// 1 (joe)  - children: 2 (al), 3 (dave)
/// 2 (al)
/// 3 (dave)
/// 4 (lisa)
/// 5 (darlene)
/// &lt;/pre&gt;
///
/// and the node data arrays would be as follows:
///
/// &lt;pre&gt;
/// name      initials  other     age       .tagname  .chardata
/// ------------------------------------------------------------------------------------------------
/// jeff      (empty)   (empty)   26         node     "  this is text in jeff's node\n  \n  \n  \n"
/// joe       (empty)   (empty)   (empty)    node     "\n    \n    \n  "
/// al        amb       something (empty)    node     (empty)
/// dave      (empty)   (empty)   30         node     (empty)
/// lisa      (empty)   (empty)   (empty)    node     "this is text in lisa's node"
/// darlene   (empty)   (empty)   29         node     (empty)
/// &lt;/pre&gt;
///
/// There would also be the following bit arrays if MaskArrays is on:
///
/// &lt;pre&gt;
/// .valid.name   .valid.initials   .valid.other   .valid.age
/// ---------------------------------------------------------
/// 1             0                 0              1
/// 1             0                 0              0
/// 1             1                 1              0
/// 1             0                 0              1
/// 1             0                 0              0
/// 1             0                 0              1
/// &lt;/pre&gt;
/// </remarks>
public class vtkXMLTreeReader : vtkTreeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLTreeReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLTreeReader()
	{
		MRClassNameKey = "class vtkXMLTreeReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLTreeReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLTreeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLTreeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLTreeReader New()
	{
		vtkXMLTreeReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLTreeReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLTreeReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLTreeReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkXMLTreeReader_GenerateEdgePedigreeIdsOff_01(HandleRef pThis);

	/// <summary>
	/// Set whether to use an property from the XML file as pedigree ids (off),
	/// or generate a new array with integer values starting at zero (on).
	/// Default is on.
	/// </summary>
	public virtual void GenerateEdgePedigreeIdsOff()
	{
		vtkXMLTreeReader_GenerateEdgePedigreeIdsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_GenerateEdgePedigreeIdsOn_02(HandleRef pThis);

	/// <summary>
	/// Set whether to use an property from the XML file as pedigree ids (off),
	/// or generate a new array with integer values starting at zero (on).
	/// Default is on.
	/// </summary>
	public virtual void GenerateEdgePedigreeIdsOn()
	{
		vtkXMLTreeReader_GenerateEdgePedigreeIdsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_GenerateVertexPedigreeIdsOff_03(HandleRef pThis);

	/// <summary>
	/// Set whether to use an property from the XML file as pedigree ids (off),
	/// or generate a new array with integer values starting at zero (on).
	/// Default is on.
	/// </summary>
	public virtual void GenerateVertexPedigreeIdsOff()
	{
		vtkXMLTreeReader_GenerateVertexPedigreeIdsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_GenerateVertexPedigreeIdsOn_04(HandleRef pThis);

	/// <summary>
	/// Set whether to use an property from the XML file as pedigree ids (off),
	/// or generate a new array with integer values starting at zero (on).
	/// Default is on.
	/// </summary>
	public virtual void GenerateVertexPedigreeIdsOn()
	{
		vtkXMLTreeReader_GenerateVertexPedigreeIdsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLTreeReader_GetEdgePedigreeIdArrayName_05(HandleRef pThis);

	/// <summary>
	/// The name of the edge pedigree ids. Default is "edge id".
	/// </summary>
	public virtual string GetEdgePedigreeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLTreeReader_GetEdgePedigreeIdArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLTreeReader_GetFileName_06(HandleRef pThis);

	/// <summary>
	/// If set, reads in the XML file specified.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLTreeReader_GetFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLTreeReader_GetGenerateEdgePedigreeIds_07(HandleRef pThis);

	/// <summary>
	/// Set whether to use an property from the XML file as pedigree ids (off),
	/// or generate a new array with integer values starting at zero (on).
	/// Default is on.
	/// </summary>
	public virtual bool GetGenerateEdgePedigreeIds()
	{
		return (vtkXMLTreeReader_GetGenerateEdgePedigreeIds_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLTreeReader_GetGenerateVertexPedigreeIds_08(HandleRef pThis);

	/// <summary>
	/// Set whether to use an property from the XML file as pedigree ids (off),
	/// or generate a new array with integer values starting at zero (on).
	/// Default is on.
	/// </summary>
	public virtual bool GetGenerateVertexPedigreeIds()
	{
		return (vtkXMLTreeReader_GetGenerateVertexPedigreeIds_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLTreeReader_GetMaskArrays_09(HandleRef pThis);

	/// <summary>
	/// If on, makes bit arrays for each attribute with name .valid.attribute_name
	/// for each attribute.  Default is off.
	/// </summary>
	public virtual bool GetMaskArrays()
	{
		return (vtkXMLTreeReader_GetMaskArrays_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLTreeReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLTreeReader_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLTreeReader_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLTreeReader_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLTreeReader_GetReadCharData_12(HandleRef pThis);

	/// <summary>
	/// If on, stores the XML character data (i.e. textual data between tags)
	/// into an array named CharDataField, otherwise this field is skipped.
	/// Default is off.
	/// </summary>
	public virtual bool GetReadCharData()
	{
		return (vtkXMLTreeReader_GetReadCharData_12(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLTreeReader_GetReadTagName_13(HandleRef pThis);

	/// <summary>
	/// If on, stores the XML tag name data in a field called .tagname
	/// otherwise this field is skipped.
	/// Default is on.
	/// </summary>
	public virtual bool GetReadTagName()
	{
		return (vtkXMLTreeReader_GetReadTagName_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLTreeReader_GetVertexPedigreeIdArrayName_14(HandleRef pThis);

	/// <summary>
	/// The name of the vertex pedigree ids. Default is "vertex id".
	/// </summary>
	public virtual string GetVertexPedigreeIdArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLTreeReader_GetVertexPedigreeIdArrayName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLTreeReader_GetXMLString_15(HandleRef pThis);

	/// <summary>
	/// If set, and FileName is not set, reads in the XML string.
	/// </summary>
	public virtual string GetXMLString()
	{
		return Marshal.PtrToStringAnsi(vtkXMLTreeReader_GetXMLString_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLTreeReader_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLTreeReader_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLTreeReader_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLTreeReader_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_MaskArraysOff_18(HandleRef pThis);

	/// <summary>
	/// If on, makes bit arrays for each attribute with name .valid.attribute_name
	/// for each attribute.  Default is off.
	/// </summary>
	public virtual void MaskArraysOff()
	{
		vtkXMLTreeReader_MaskArraysOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_MaskArraysOn_19(HandleRef pThis);

	/// <summary>
	/// If on, makes bit arrays for each attribute with name .valid.attribute_name
	/// for each attribute.  Default is off.
	/// </summary>
	public virtual void MaskArraysOn()
	{
		vtkXMLTreeReader_MaskArraysOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLTreeReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLTreeReader NewInstance()
	{
		vtkXMLTreeReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLTreeReader_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_ReadCharDataOff_22(HandleRef pThis);

	/// <summary>
	/// If on, stores the XML character data (i.e. textual data between tags)
	/// into an array named CharDataField, otherwise this field is skipped.
	/// Default is off.
	/// </summary>
	public virtual void ReadCharDataOff()
	{
		vtkXMLTreeReader_ReadCharDataOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_ReadCharDataOn_23(HandleRef pThis);

	/// <summary>
	/// If on, stores the XML character data (i.e. textual data between tags)
	/// into an array named CharDataField, otherwise this field is skipped.
	/// Default is off.
	/// </summary>
	public virtual void ReadCharDataOn()
	{
		vtkXMLTreeReader_ReadCharDataOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_ReadTagNameOff_24(HandleRef pThis);

	/// <summary>
	/// If on, stores the XML tag name data in a field called .tagname
	/// otherwise this field is skipped.
	/// Default is on.
	/// </summary>
	public virtual void ReadTagNameOff()
	{
		vtkXMLTreeReader_ReadTagNameOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_ReadTagNameOn_25(HandleRef pThis);

	/// <summary>
	/// If on, stores the XML tag name data in a field called .tagname
	/// otherwise this field is skipped.
	/// Default is on.
	/// </summary>
	public virtual void ReadTagNameOn()
	{
		vtkXMLTreeReader_ReadTagNameOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLTreeReader_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLTreeReader SafeDownCast(vtkObjectBase o)
	{
		vtkXMLTreeReader vtkXMLTreeReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLTreeReader_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLTreeReader2 = (vtkXMLTreeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLTreeReader2.Register(null);
			}
		}
		return vtkXMLTreeReader2;
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetEdgePedigreeIdArrayName_27(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the edge pedigree ids. Default is "edge id".
	/// </summary>
	public virtual void SetEdgePedigreeIdArrayName(string _arg)
	{
		vtkXMLTreeReader_SetEdgePedigreeIdArrayName_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetFileName_28(HandleRef pThis, string _arg);

	/// <summary>
	/// If set, reads in the XML file specified.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkXMLTreeReader_SetFileName_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetGenerateEdgePedigreeIds_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether to use an property from the XML file as pedigree ids (off),
	/// or generate a new array with integer values starting at zero (on).
	/// Default is on.
	/// </summary>
	public virtual void SetGenerateEdgePedigreeIds(bool _arg)
	{
		vtkXMLTreeReader_SetGenerateEdgePedigreeIds_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetGenerateVertexPedigreeIds_30(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether to use an property from the XML file as pedigree ids (off),
	/// or generate a new array with integer values starting at zero (on).
	/// Default is on.
	/// </summary>
	public virtual void SetGenerateVertexPedigreeIds(bool _arg)
	{
		vtkXMLTreeReader_SetGenerateVertexPedigreeIds_30(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetMaskArrays_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, makes bit arrays for each attribute with name .valid.attribute_name
	/// for each attribute.  Default is off.
	/// </summary>
	public virtual void SetMaskArrays(bool _arg)
	{
		vtkXMLTreeReader_SetMaskArrays_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetReadCharData_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, stores the XML character data (i.e. textual data between tags)
	/// into an array named CharDataField, otherwise this field is skipped.
	/// Default is off.
	/// </summary>
	public virtual void SetReadCharData(bool _arg)
	{
		vtkXMLTreeReader_SetReadCharData_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetReadTagName_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// If on, stores the XML tag name data in a field called .tagname
	/// otherwise this field is skipped.
	/// Default is on.
	/// </summary>
	public virtual void SetReadTagName(bool _arg)
	{
		vtkXMLTreeReader_SetReadTagName_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetVertexPedigreeIdArrayName_34(HandleRef pThis, string _arg);

	/// <summary>
	/// The name of the vertex pedigree ids. Default is "vertex id".
	/// </summary>
	public virtual void SetVertexPedigreeIdArrayName(string _arg)
	{
		vtkXMLTreeReader_SetVertexPedigreeIdArrayName_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLTreeReader_SetXMLString_35(HandleRef pThis, string _arg);

	/// <summary>
	/// If set, and FileName is not set, reads in the XML string.
	/// </summary>
	public virtual void SetXMLString(string _arg)
	{
		vtkXMLTreeReader_SetXMLString_35(GetCppThis(), _arg);
	}
}
