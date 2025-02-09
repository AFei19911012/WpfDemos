using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLDataElement
/// </summary>
/// <remarks>
///    Represents an XML element and those nested inside.
///
/// vtkXMLDataElement is used by vtkXMLDataParser to represent an XML
/// element.  It provides methods to access the element's attributes
/// and nested elements in a convenient manner.  This allows easy
/// traversal of an input XML file by vtkXMLReader and its subclasses.
///
/// </remarks>
/// <seealso>
///
/// vtkXMLDataParser
/// </seealso>
public class vtkXMLDataElement : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataElement";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLDataElement()
	{
		MRClassNameKey = "class vtkXMLDataElement";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataElement"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLDataElement(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLDataElement New()
	{
		vtkXMLDataElement result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLDataElement()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLDataElement_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_AddCharacterData_01(HandleRef pThis, string c, ulong length);

	/// <summary>
	/// Set/Get the character data between XML start/end tags.
	/// </summary>
	public void AddCharacterData(string c, ulong length)
	{
		vtkXMLDataElement_AddCharacterData_01(GetCppThis(), c, length);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_AddNestedElement_02(HandleRef pThis, HandleRef element);

	/// <summary>
	/// Add nested element
	/// </summary>
	public void AddNestedElement(vtkXMLDataElement element)
	{
		vtkXMLDataElement_AddNestedElement_02(GetCppThis(), element?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_DeepCopy_03(HandleRef pThis, HandleRef elem);

	/// <summary>
	/// Copy this element from another of the same type (elem), recursively.
	/// Old attributes and nested elements are removed, new ones are created
	/// given the contents of 'elem'.
	/// Warning: Parent is ignored.
	/// </summary>
	public virtual void DeepCopy(vtkXMLDataElement elem)
	{
		vtkXMLDataElement_DeepCopy_03(GetCppThis(), elem?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_FindNestedElement_04(HandleRef pThis, string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Find the first nested element with the given id, given name, or given
	/// name and id.
	/// WARNING: the search is only performed on the children, not
	/// the grand-children.
	/// </summary>
	public vtkXMLDataElement FindNestedElement(string id)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_FindNestedElement_04(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithName_05(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Find the first nested element with the given id, given name, or given
	/// name and id.
	/// WARNING: the search is only performed on the children, not
	/// the grand-children.
	/// </summary>
	public vtkXMLDataElement FindNestedElementWithName(string name)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_FindNestedElementWithName_05(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithNameAndAttribute_06(HandleRef pThis, string name, string att_name, string att_value, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Find the first nested element with the given id, given name, or given
	/// name and id.
	/// WARNING: the search is only performed on the children, not
	/// the grand-children.
	/// </summary>
	public vtkXMLDataElement FindNestedElementWithNameAndAttribute(string name, string att_name, string att_value)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_FindNestedElementWithNameAndAttribute_06(GetCppThis(), name, att_name, att_value, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_FindNestedElementWithNameAndId_07(HandleRef pThis, string name, string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Find the first nested element with the given id, given name, or given
	/// name and id.
	/// WARNING: the search is only performed on the children, not
	/// the grand-children.
	/// </summary>
	public vtkXMLDataElement FindNestedElementWithNameAndId(string name, string id)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_FindNestedElementWithNameAndId_07(GetCppThis(), name, id, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetAttribute_08(HandleRef pThis, string name);

	/// <summary>
	/// Get the attribute with the given name.  If it doesn't exist,
	/// returns 0.
	/// </summary>
	public string GetAttribute(string name)
	{
		return Marshal.PtrToStringAnsi(vtkXMLDataElement_GetAttribute_08(GetCppThis(), name));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetAttributeEncoding_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the internal character encoding of the attributes.
	/// Default type is VTK_ENCODING_UTF_8.
	/// Note that a vtkXMLDataParser has its own AttributesEncoding ivar. If
	/// this ivar is set to something other than VTK_ENCODING_NONE, it will be
	/// used to set the attribute encoding of each vtkXMLDataElement
	/// created by this vtkXMLDataParser.
	/// </summary>
	public virtual int GetAttributeEncoding()
	{
		return vtkXMLDataElement_GetAttributeEncoding_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetAttributeEncodingMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the internal character encoding of the attributes.
	/// Default type is VTK_ENCODING_UTF_8.
	/// Note that a vtkXMLDataParser has its own AttributesEncoding ivar. If
	/// this ivar is set to something other than VTK_ENCODING_NONE, it will be
	/// used to set the attribute encoding of each vtkXMLDataElement
	/// created by this vtkXMLDataParser.
	/// </summary>
	public virtual int GetAttributeEncodingMaxValue()
	{
		return vtkXMLDataElement_GetAttributeEncodingMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetAttributeEncodingMinValue_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the internal character encoding of the attributes.
	/// Default type is VTK_ENCODING_UTF_8.
	/// Note that a vtkXMLDataParser has its own AttributesEncoding ivar. If
	/// this ivar is set to something other than VTK_ENCODING_NONE, it will be
	/// used to set the attribute encoding of each vtkXMLDataElement
	/// created by this vtkXMLDataParser.
	/// </summary>
	public virtual int GetAttributeEncodingMinValue()
	{
		return vtkXMLDataElement_GetAttributeEncodingMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetAttributeName_12(HandleRef pThis, int idx);

	/// <summary>
	/// Get the n-th attribute name.
	/// Returns 0 if there is no such attribute.
	/// </summary>
	public string GetAttributeName(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkXMLDataElement_GetAttributeName_12(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetAttributeValue_13(HandleRef pThis, int idx);

	/// <summary>
	/// Get the n-th attribute value.
	/// Returns 0 if there is no such attribute.
	/// </summary>
	public string GetAttributeValue(int idx)
	{
		return Marshal.PtrToStringAnsi(vtkXMLDataElement_GetAttributeValue_13(GetCppThis(), idx));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetCharacterData_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the character data between XML start/end tags.
	/// </summary>
	public virtual string GetCharacterData()
	{
		return Marshal.PtrToStringAnsi(vtkXMLDataElement_GetCharacterData_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetCharacterDataWidth_15(HandleRef pThis);

	/// <summary>
	/// Get/Set the width (in number of fields) that character
	/// data (that between open and closing tags ie. \&lt;X\&gt; ... \&lt;/X\&gt;)
	/// is printed. If the width is less than one the tag's character
	/// data is printed all on one line. If it is greater than one
	/// the character data is streamed insterting line feeds every
	/// width number of fields. See PrintXML.
	/// </summary>
	public virtual int GetCharacterDataWidth()
	{
		return vtkXMLDataElement_GetCharacterDataWidth_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetId_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the value of the id attribute of the element, if any.
	/// </summary>
	public virtual string GetId()
	{
		return Marshal.PtrToStringAnsi(vtkXMLDataElement_GetId_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetName_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the element.  This is its XML tag.
	/// </summary>
	public virtual string GetName()
	{
		return Marshal.PtrToStringAnsi(vtkXMLDataElement_GetName_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetNestedElement_18(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the element nested in this one at the given index.
	/// </summary>
	public vtkXMLDataElement GetNestedElement(int index)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_GetNestedElement_18(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetNumberOfAttributes_19(HandleRef pThis);

	/// <summary>
	/// Get the number of attributes.
	/// </summary>
	public virtual int GetNumberOfAttributes()
	{
		return vtkXMLDataElement_GetNumberOfAttributes_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLDataElement_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLDataElement_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLDataElement_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLDataElement_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetNumberOfNestedElements_22(HandleRef pThis);

	/// <summary>
	/// Get the number of elements nested in this one.
	/// </summary>
	public int GetNumberOfNestedElements()
	{
		return vtkXMLDataElement_GetNumberOfNestedElements_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetParent_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the parent of this element.
	/// </summary>
	public vtkXMLDataElement GetParent()
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_GetParent_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_GetRoot_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get root of the XML tree this element is part of.
	/// </summary>
	public virtual vtkXMLDataElement GetRoot()
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_GetRoot_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetScalarAttribute_25(HandleRef pThis, string name, ref int value);

	/// <summary>
	/// Get the attribute with the given name and converted to a scalar
	/// value.  Returns whether value was extracted.
	/// </summary>
	public int GetScalarAttribute(string name, ref int value)
	{
		return vtkXMLDataElement_GetScalarAttribute_25(GetCppThis(), name, ref value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetScalarAttribute_26(HandleRef pThis, string name, ref float value);

	/// <summary>
	/// Get the attribute with the given name and converted to a scalar
	/// value.  Returns whether value was extracted.
	/// </summary>
	public int GetScalarAttribute(string name, ref float value)
	{
		return vtkXMLDataElement_GetScalarAttribute_26(GetCppThis(), name, ref value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetScalarAttribute_27(HandleRef pThis, string name, ref double value);

	/// <summary>
	/// Get the attribute with the given name and converted to a scalar
	/// value.  Returns whether value was extracted.
	/// </summary>
	public int GetScalarAttribute(string name, ref double value)
	{
		return vtkXMLDataElement_GetScalarAttribute_27(GetCppThis(), name, ref value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetScalarAttribute_28(HandleRef pThis, string name, ref uint value);

	/// <summary>
	/// Get the attribute with the given name and converted to a scalar
	/// value.  Returns whether value was extracted.
	/// </summary>
	public int GetScalarAttribute(string name, ref uint value)
	{
		return vtkXMLDataElement_GetScalarAttribute_28(GetCppThis(), name, ref value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetScalarAttribute_29(HandleRef pThis, string name, ref long value);

	/// <summary>
	/// Set the attribute with the given name.
	/// </summary>
	public int GetScalarAttribute(string name, ref long value)
	{
		return vtkXMLDataElement_GetScalarAttribute_29(GetCppThis(), name, ref value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetScalarAttribute_30(HandleRef pThis, string name, ref ulong value);

	/// <summary>
	/// Set the attribute with the given name.
	/// </summary>
	public int GetScalarAttribute(string name, ref ulong value)
	{
		return vtkXMLDataElement_GetScalarAttribute_30(GetCppThis(), name, ref value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetVectorAttribute_31(HandleRef pThis, string name, int length, IntPtr value);

	/// <summary>
	/// Get the attribute with the given name and converted to a scalar
	/// value.  Returns length of vector read.
	/// </summary>
	public int GetVectorAttribute(string name, int length, IntPtr value)
	{
		return vtkXMLDataElement_GetVectorAttribute_31(GetCppThis(), name, length, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_GetWordTypeAttribute_32(HandleRef pThis, string name, ref int value);

	/// <summary>
	/// Get the attribute with the given name and converted to a word type.
	/// Word types can be `VTK_TYPE_FLOAT32`, `VTK_TYPE_FLOAT64`, `VTK_INT8`,
	/// `VTK_UINT8`, `VTK_INT16`, `VTK_UINT16`, `VTK_INT32`, `VTK_UINT32`,
	/// `VTK_INT64`, `VTK_UINT64`, `VTK_STRING`, or `VTK_BIT`.
	/// </summary>
	public int GetWordTypeAttribute(string name, ref int value)
	{
		return vtkXMLDataElement_GetWordTypeAttribute_32(GetCppThis(), name, ref value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLDataElement_GetXMLByteIndex_33(HandleRef pThis);

	/// <summary>
	/// Set/Get the offset from the beginning of the XML document to this element.
	/// </summary>
	public virtual long GetXMLByteIndex()
	{
		return vtkXMLDataElement_GetXMLByteIndex_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_IsA_34(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLDataElement_IsA_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_IsEqualTo_35(HandleRef pThis, HandleRef elem);

	/// <summary>
	/// Check if the instance has the same name, attributes, character data
	/// and nested elements contents than the given element (this method is
	/// applied recursively on the nested elements, and they must be stored in
	/// the same order).
	/// Warning: Id, Parent, XMLByteIndex are ignored.
	/// </summary>
	public virtual int IsEqualTo(vtkXMLDataElement elem)
	{
		return vtkXMLDataElement_IsEqualTo_35(GetCppThis(), elem?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataElement_IsTypeOf_36(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLDataElement_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_LookupElement_37(HandleRef pThis, string id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Lookup the element with the given id, starting at this scope.
	/// </summary>
	public vtkXMLDataElement LookupElement(string id)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_LookupElement_37(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_LookupElementWithName_38(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Find the first nested element with given name.
	/// WARNING: the search is performed on the whole XML tree.
	/// </summary>
	public vtkXMLDataElement LookupElementWithName(string name)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_LookupElementWithName_38(GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLDataElement NewInstance()
	{
		vtkXMLDataElement result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_PrintXML_41(HandleRef pThis, string fname);

	/// <summary>
	/// Prints element tree as XML.
	/// </summary>
	public void PrintXML(string fname)
	{
		vtkXMLDataElement_PrintXML_41(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_RemoveAllAttributes_42(HandleRef pThis);

	/// <summary>
	/// Remove one or all attributes.
	/// </summary>
	public virtual void RemoveAllAttributes()
	{
		vtkXMLDataElement_RemoveAllAttributes_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_RemoveAllNestedElements_43(HandleRef pThis);

	/// <summary>
	/// Remove all nested elements.
	/// </summary>
	public virtual void RemoveAllNestedElements()
	{
		vtkXMLDataElement_RemoveAllNestedElements_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_RemoveAttribute_44(HandleRef pThis, string name);

	/// <summary>
	/// Remove one or all attributes.
	/// </summary>
	public virtual void RemoveAttribute(string name)
	{
		vtkXMLDataElement_RemoveAttribute_44(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_RemoveNestedElement_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Remove nested element.
	/// </summary>
	public virtual void RemoveNestedElement(vtkXMLDataElement arg0)
	{
		vtkXMLDataElement_RemoveNestedElement_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataElement_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLDataElement SafeDownCast(vtkObjectBase o)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataElement_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetAttribute_47(HandleRef pThis, string name, string value);

	/// <summary>
	/// Set the attribute with the given name and value. If it doesn't exist,
	/// adds it.
	/// </summary>
	public void SetAttribute(string name, string value)
	{
		vtkXMLDataElement_SetAttribute_47(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetAttributeEncoding_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the internal character encoding of the attributes.
	/// Default type is VTK_ENCODING_UTF_8.
	/// Note that a vtkXMLDataParser has its own AttributesEncoding ivar. If
	/// this ivar is set to something other than VTK_ENCODING_NONE, it will be
	/// used to set the attribute encoding of each vtkXMLDataElement
	/// created by this vtkXMLDataParser.
	/// </summary>
	public virtual void SetAttributeEncoding(int _arg)
	{
		vtkXMLDataElement_SetAttributeEncoding_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetCharacterData_49(HandleRef pThis, string data, int length);

	/// <summary>
	/// Set/Get the character data between XML start/end tags.
	/// </summary>
	public void SetCharacterData(string data, int length)
	{
		vtkXMLDataElement_SetCharacterData_49(GetCppThis(), data, length);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetCharacterDataWidth_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the width (in number of fields) that character
	/// data (that between open and closing tags ie. \&lt;X\&gt; ... \&lt;/X\&gt;)
	/// is printed. If the width is less than one the tag's character
	/// data is printed all on one line. If it is greater than one
	/// the character data is streamed insterting line feeds every
	/// width number of fields. See PrintXML.
	/// </summary>
	public virtual void SetCharacterDataWidth(int _arg)
	{
		vtkXMLDataElement_SetCharacterDataWidth_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetDoubleAttribute_51(HandleRef pThis, string name, double value);

	/// <summary>
	/// Set the attribute with the given name.
	/// We can not use the same GetScalarAttribute() construct since
	/// the compiler will not be able to resolve between
	/// SetAttribute(..., int) and SetAttribute(..., unsigned long).
	/// </summary>
	public void SetDoubleAttribute(string name, double value)
	{
		vtkXMLDataElement_SetDoubleAttribute_51(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetFloatAttribute_52(HandleRef pThis, string name, float value);

	/// <summary>
	/// Set the attribute with the given name.
	/// We can not use the same GetScalarAttribute() construct since
	/// the compiler will not be able to resolve between
	/// SetAttribute(..., int) and SetAttribute(..., unsigned long).
	/// </summary>
	public void SetFloatAttribute(string name, float value)
	{
		vtkXMLDataElement_SetFloatAttribute_52(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetId_53(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the value of the id attribute of the element, if any.
	/// </summary>
	public virtual void SetId(string _arg)
	{
		vtkXMLDataElement_SetId_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetIntAttribute_54(HandleRef pThis, string name, int value);

	/// <summary>
	/// Set the attribute with the given name.
	/// We can not use the same GetScalarAttribute() construct since
	/// the compiler will not be able to resolve between
	/// SetAttribute(..., int) and SetAttribute(..., unsigned long).
	/// </summary>
	public void SetIntAttribute(string name, int value)
	{
		vtkXMLDataElement_SetIntAttribute_54(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetName_55(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the element.  This is its XML tag.
	/// </summary>
	public virtual void SetName(string _arg)
	{
		vtkXMLDataElement_SetName_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetParent_56(HandleRef pThis, HandleRef parent);

	/// <summary>
	/// Set/Get the parent of this element.
	/// </summary>
	public void SetParent(vtkXMLDataElement parent)
	{
		vtkXMLDataElement_SetParent_56(GetCppThis(), parent?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetUnsignedLongAttribute_57(HandleRef pThis, string name, uint value);

	/// <summary>
	/// Set the attribute with the given name.
	/// We can not use the same GetScalarAttribute() construct since
	/// the compiler will not be able to resolve between
	/// SetAttribute(..., int) and SetAttribute(..., unsigned long).
	/// </summary>
	public void SetUnsignedLongAttribute(string name, uint value)
	{
		vtkXMLDataElement_SetUnsignedLongAttribute_57(GetCppThis(), name, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetVectorAttribute_58(HandleRef pThis, string name, int length, IntPtr value);

	/// <summary>
	/// Set the attribute with the given name.
	/// </summary>
	public void SetVectorAttribute(string name, int length, IntPtr value)
	{
		vtkXMLDataElement_SetVectorAttribute_58(GetCppThis(), name, length, value);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataElement_SetXMLByteIndex_59(HandleRef pThis, long _arg);

	/// <summary>
	/// Set/Get the offset from the beginning of the XML document to this element.
	/// </summary>
	public virtual void SetXMLByteIndex(long _arg)
	{
		vtkXMLDataElement_SetXMLByteIndex_59(GetCppThis(), _arg);
	}
}
