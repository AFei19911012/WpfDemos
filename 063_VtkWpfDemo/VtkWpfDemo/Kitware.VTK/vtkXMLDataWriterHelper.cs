using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkXMLDataWriterHelper
/// </summary>
/// <remarks>
///  helper for vtkXMLWriter2 and subclasses
///
/// vtkXMLDataWriterHelper is intended to be a helper class used by vtkXMLWriter2
/// and subclasses to use to write the XML to a file. Currently, this is simply a
/// subclass of vtkXMLWriter with some minimal API exposed. The ultimate goal is
/// to move logic to write XML data to this class and remove the reliance on
/// vtkXMLWriter. To get things off the ground quickly, this is kept as a
/// subclass of vtkXMLWriter for now.
/// </remarks>
public class vtkXMLDataWriterHelper : vtkXMLWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataWriterHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLDataWriterHelper()
	{
		MRClassNameKey = "class vtkXMLDataWriterHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataWriterHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLDataWriterHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataWriterHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLDataWriterHelper New()
	{
		vtkXMLDataWriterHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataWriterHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLDataWriterHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLDataWriterHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLDataWriterHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLDataWriterHelper_AddGlobalFieldData_01(HandleRef pThis, HandleRef dataset);

	/// <summary>
	/// Adds global field data for composite dataset.
	/// </summary>
	public bool AddGlobalFieldData(vtkCompositeDataSet dataset)
	{
		return (vtkXMLDataWriterHelper_AddGlobalFieldData_01(GetCppThis(), dataset?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLDataWriterHelper_AddXML_02(HandleRef pThis, HandleRef xmlElement);

	/// <summary>
	/// Serialize and add an XML dom described by the `xmlElement` to the file.
	/// </summary>
	public bool AddXML(vtkXMLDataElement xmlElement)
	{
		return (vtkXMLDataWriterHelper_AddXML_02(GetCppThis(), xmlElement?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLDataWriterHelper_BeginWriting_03(HandleRef pThis);

	/// <summary>
	/// The writing process is split into 4 parts:
	/// 1. `OpenFile` opens the file for writing.
	/// 2. `BeginWriting` begins writing by adding header.
	/// 3. Write the contents. API calls like `AddGlobalFieldData`, `AddXML` can be used for this.
	/// 4. `EndWriting` ends the writing, adding any footers as needed.
	/// </summary>
	public bool BeginWriting()
	{
		return (vtkXMLDataWriterHelper_BeginWriting_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLDataWriterHelper_EndWriting_04(HandleRef pThis);

	/// <summary>
	/// The writing process is split into 4 parts:
	/// 1. `OpenFile` opens the file for writing.
	/// 2. `BeginWriting` begins writing by adding header.
	/// 3. Write the contents. API calls like `AddGlobalFieldData`, `AddXML` can be used for this.
	/// 4. `EndWriting` ends the writing, adding any footers as needed.
	/// </summary>
	public bool EndWriting()
	{
		return (vtkXMLDataWriterHelper_EndWriting_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataWriterHelper_GetDefaultFileExtension_05(HandleRef pThis);

	/// <summary>
	/// These methods should be used by the caller to provide necessary information
	/// to the helper to generate a valid header. This is currently necessary since
	/// we are making this class reused parts of vtkXMLWriter. When than dependence
	/// is severed, this API will likely change.
	/// </summary>
	public override string GetDefaultFileExtension()
	{
		return Marshal.PtrToStringAnsi(vtkXMLDataWriterHelper_GetDefaultFileExtension_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLDataWriterHelper_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLDataWriterHelper_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLDataWriterHelper_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLDataWriterHelper_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataWriterHelper_GetWriter_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the writer using this helper. Attributes from the writer are used
	/// to control how data is written out.
	/// </summary>
	public virtual vtkXMLWriter2 GetWriter()
	{
		vtkXMLWriter2 vtkXMLWriter3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataWriterHelper_GetWriter_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLWriter3 = (vtkXMLWriter2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLWriter3.Register(null);
			}
		}
		return vtkXMLWriter3;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataWriterHelper_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLDataWriterHelper_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLDataWriterHelper_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLDataWriterHelper_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataWriterHelper_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLDataWriterHelper NewInstance()
	{
		vtkXMLDataWriterHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataWriterHelper_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLDataWriterHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLDataWriterHelper_OpenFile_13(HandleRef pThis);

	/// <summary>
	/// The writing process is split into 4 parts:
	/// 1. `OpenFile` opens the file for writing.
	/// 2. `BeginWriting` begins writing by adding header.
	/// 3. Write the contents. API calls like `AddGlobalFieldData`, `AddXML` can be used for this.
	/// 4. `EndWriting` ends the writing, adding any footers as needed.
	/// </summary>
	public bool OpenFile()
	{
		return (vtkXMLDataWriterHelper_OpenFile_13(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLDataWriterHelper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLDataWriterHelper SafeDownCast(vtkObjectBase o)
	{
		vtkXMLDataWriterHelper vtkXMLDataWriterHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLDataWriterHelper_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLDataWriterHelper2 = (vtkXMLDataWriterHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLDataWriterHelper2.Register(null);
			}
		}
		return vtkXMLDataWriterHelper2;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataWriterHelper_SetDataSetName_15(HandleRef pThis, string name);

	/// <summary>
	/// These methods should be used by the caller to provide necessary information
	/// to the helper to generate a valid header. This is currently necessary since
	/// we are making this class reused parts of vtkXMLWriter. When than dependence
	/// is severed, this API will likely change.
	/// </summary>
	public void SetDataSetName(string name)
	{
		vtkXMLDataWriterHelper_SetDataSetName_15(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataWriterHelper_SetDataSetVersion_16(HandleRef pThis, int major, int minor);

	/// <summary>
	/// These methods should be used by the caller to provide necessary information
	/// to the helper to generate a valid header. This is currently necessary since
	/// we are making this class reused parts of vtkXMLWriter. When than dependence
	/// is severed, this API will likely change.
	/// </summary>
	public void SetDataSetVersion(int major, int minor)
	{
		vtkXMLDataWriterHelper_SetDataSetVersion_16(GetCppThis(), major, minor);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLDataWriterHelper_SetWriter_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the writer using this helper. Attributes from the writer are used
	/// to control how data is written out.
	/// </summary>
	public void SetWriter(vtkXMLWriter2 arg0)
	{
		vtkXMLDataWriterHelper_SetWriter_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
