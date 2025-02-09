using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkXMLCompositeDataSetWriterHelper
/// </summary>
/// <remarks>
///  a helper class used by vtkXMLWriter2 subclasses that write composite
///        datasets.
///
/// vtkXMLCompositeDataSetWriterHelper is a helper class intended to be used by
/// subclasses of vtkXMLWriter2 that want to write composite datasets. It
/// consolidates the logic to write individual datasets for leaf nodes into
/// separate files.
/// </remarks>
public class vtkXMLCompositeDataSetWriterHelper : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLCompositeDataSetWriterHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLCompositeDataSetWriterHelper()
	{
		MRClassNameKey = "class vtkXMLCompositeDataSetWriterHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLCompositeDataSetWriterHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLCompositeDataSetWriterHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataSetWriterHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLCompositeDataSetWriterHelper New()
	{
		vtkXMLCompositeDataSetWriterHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataSetWriterHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLCompositeDataSetWriterHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLCompositeDataSetWriterHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLCompositeDataSetWriterHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkXMLCompositeDataSetWriterHelper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLCompositeDataSetWriterHelper_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLCompositeDataSetWriterHelper_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLCompositeDataSetWriterHelper_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataSetWriterHelper_GetWriter_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the writer using this helper. This is reference counted. So caller
	/// should avoid cycles explicitly.
	/// </summary>
	public virtual vtkXMLWriterBase GetWriter()
	{
		vtkXMLWriterBase vtkXMLWriterBase2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataSetWriterHelper_GetWriter_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataSetWriterHelper_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLCompositeDataSetWriterHelper_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataSetWriterHelper_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLCompositeDataSetWriterHelper_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataSetWriterHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLCompositeDataSetWriterHelper NewInstance()
	{
		vtkXMLCompositeDataSetWriterHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataSetWriterHelper_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLCompositeDataSetWriterHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataSetWriterHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLCompositeDataSetWriterHelper SafeDownCast(vtkObjectBase o)
	{
		vtkXMLCompositeDataSetWriterHelper vtkXMLCompositeDataSetWriterHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataSetWriterHelper_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLCompositeDataSetWriterHelper2 = (vtkXMLCompositeDataSetWriterHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLCompositeDataSetWriterHelper2.Register(null);
			}
		}
		return vtkXMLCompositeDataSetWriterHelper2;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLCompositeDataSetWriterHelper_SetWriter_09(HandleRef pThis, HandleRef writer);

	/// <summary>
	/// Get/Set the writer using this helper. This is reference counted. So caller
	/// should avoid cycles explicitly.
	/// </summary>
	public void SetWriter(vtkXMLWriterBase writer)
	{
		vtkXMLCompositeDataSetWriterHelper_SetWriter_09(GetCppThis(), writer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkXMLCompositeDataSetWriterHelper_WriteDataSet_10(HandleRef pThis, string path, string prefix, HandleRef data);

	/// <summary>
	/// Write a specific dataset to a file. The dataset cannot be a composite
	/// dataset. The implementation uses `vtkXMLDataObjectWriter` to find a writer
	/// to use. Internally, writers are cached and will be reused when same type of
	/// data is being written out multiple times.
	///
	/// The filename is created using the `path` and `prefix`. The prefix is
	/// extended with a `.&lt;ext&gt;` where the `&lt;ext&gt;` is dictated by the writer used.
	/// `vtkXMLWriterBase::GetDefaultFileExtension` is used to obtain the
	/// extension to use for the file written out.
	///
	/// On success, returns `&lt;prefix&gt;.&lt;ext&gt;`, otherwise an empty string is
	/// returned.
	/// </summary>
	public string WriteDataSet(string path, string prefix, vtkDataObject data)
	{
		return vtkXMLCompositeDataSetWriterHelper_WriteDataSet_10(GetCppThis(), path, prefix, data?.GetCppThis() ?? default(HandleRef));
	}
}
