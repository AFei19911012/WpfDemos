using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLUtilities
/// </summary>
/// <remarks>
///    XML utilities.
///
/// vtkXMLUtilities provides XML-related convenience functions.
/// </remarks>
/// <seealso>
///
/// vtkXMLDataElement
/// </seealso>
public class vtkXMLUtilities : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUtilities";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLUtilities()
	{
		MRClassNameKey = "class vtkXMLUtilities";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUtilities"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLUtilities New()
	{
		vtkXMLUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLUtilities()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkXMLUtilities_FactorElements_01(HandleRef tree);

	/// <summary>
	/// Factor and unfactor a tree. This operation looks for duplicate elements
	/// in the tree, and replace them with references to a pool of elements.
	/// Unfactoring a non-factored element is harmless.
	/// </summary>
	public static void FactorElements(vtkXMLDataElement tree)
	{
		vtkXMLUtilities_FactorElements_01(tree?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLUtilities_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLUtilities_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLUtilities_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUtilities_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLUtilities_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLUtilities_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLUtilities_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUtilities_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLUtilities NewInstance()
	{
		vtkXMLUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUtilities_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLUtilities_ReadElementFromFile_08(string filename, int encoding, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Read a vtkXMLDataElement from a stream, string or file.
	/// The 'encoding' parameter will be used to set the internal encoding of the
	/// attributes of the data elements created by those functions (conversion
	/// from the XML stream encoding to that new encoding will be performed
	/// automatically). If set to VTK_ENCODING_NONE, the encoding won't be
	/// changed and will default to the default vtkXMLDataElement encoding.
	/// Return the root element on success, nullptr otherwise.
	/// Note that you have to call Delete() on the element returned by that
	/// function to ensure it is freed properly.
	/// </summary>
	public static vtkXMLDataElement ReadElementFromFile(string filename, int encoding)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUtilities_ReadElementFromFile_08(filename, encoding, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkXMLUtilities_ReadElementFromString_09(string str, int encoding, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Read a vtkXMLDataElement from a stream, string or file.
	/// The 'encoding' parameter will be used to set the internal encoding of the
	/// attributes of the data elements created by those functions (conversion
	/// from the XML stream encoding to that new encoding will be performed
	/// automatically). If set to VTK_ENCODING_NONE, the encoding won't be
	/// changed and will default to the default vtkXMLDataElement encoding.
	/// Return the root element on success, nullptr otherwise.
	/// Note that you have to call Delete() on the element returned by that
	/// function to ensure it is freed properly.
	/// </summary>
	public static vtkXMLDataElement ReadElementFromString(string str, int encoding)
	{
		vtkXMLDataElement vtkXMLDataElement2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUtilities_ReadElementFromString_09(str, encoding, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkXMLUtilities_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLUtilities SafeDownCast(vtkObjectBase o)
	{
		vtkXMLUtilities vtkXMLUtilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLUtilities_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLUtilities2 = (vtkXMLUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLUtilities2.Register(null);
			}
		}
		return vtkXMLUtilities2;
	}

	[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLUtilities_UnFactorElements_11(HandleRef tree);

	/// <summary>
	/// Factor and unfactor a tree. This operation looks for duplicate elements
	/// in the tree, and replace them with references to a pool of elements.
	/// Unfactoring a non-factored element is harmless.
	/// </summary>
	public static void UnFactorElements(vtkXMLDataElement tree)
	{
		vtkXMLUtilities_UnFactorElements_11(tree?.GetCppThis() ?? default(HandleRef));
	}
}
