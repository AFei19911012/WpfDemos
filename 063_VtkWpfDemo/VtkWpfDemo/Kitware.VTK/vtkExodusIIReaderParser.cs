using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExodusIIReaderParser
/// </summary>
/// <remarks>
///    internal parser used by vtkExodusIIReader.
///
/// vtkExodusIIReaderParser is an internal XML parser used by vtkExodusIIReader.
/// This is not for public use.
/// </remarks>
public class vtkExodusIIReaderParser : vtkXMLParser
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIIReaderParser";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExodusIIReaderParser()
	{
		MRClassNameKey = "class vtkExodusIIReaderParser";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIIReaderParser"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExodusIIReaderParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReaderParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExodusIIReaderParser New()
	{
		vtkExodusIIReaderParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReaderParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExodusIIReaderParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExodusIIReaderParser()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExodusIIReaderParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkExodusIIReaderParser_GetBlockName_01(HandleRef pThis, int id);

	/// <summary>
	/// Given a block "id" return the name as determined from the xml.
	/// This is valid only after Go().
	/// </summary>
	public string GetBlockName(int id)
	{
		return vtkExodusIIReaderParser_GetBlockName_01(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIReaderParser_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExodusIIReaderParser_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExodusIIReaderParser_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExodusIIReaderParser_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReaderParser_GetSIL_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the SIL.
	/// This is valid only after Go().
	/// </summary>
	public virtual vtkMutableDirectedGraph GetSIL()
	{
		vtkMutableDirectedGraph vtkMutableDirectedGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReaderParser_GetSIL_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMutableDirectedGraph2 = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMutableDirectedGraph2.Register(null);
			}
		}
		return vtkMutableDirectedGraph2;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExodusIIReaderParser_Go_05(HandleRef pThis, string filename);

	/// <summary>
	/// Trigger parsing of the XML file.
	/// </summary>
	public void Go(string filename)
	{
		vtkExodusIIReaderParser_Go_05(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExodusIIReaderParser_HasInformationAboutBlock_06(HandleRef pThis, int id);

	/// <summary>
	/// Trigger parsing of the XML file.
	/// </summary>
	public bool HasInformationAboutBlock(int id)
	{
		return (vtkExodusIIReaderParser_HasInformationAboutBlock_06(GetCppThis(), id) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReaderParser_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExodusIIReaderParser_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExodusIIReaderParser_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExodusIIReaderParser_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReaderParser_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExodusIIReaderParser NewInstance()
	{
		vtkExodusIIReaderParser result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReaderParser_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExodusIIReaderParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExodusIIReaderParser_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExodusIIReaderParser SafeDownCast(vtkObjectBase o)
	{
		vtkExodusIIReaderParser vtkExodusIIReaderParser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExodusIIReaderParser_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExodusIIReaderParser2 = (vtkExodusIIReaderParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExodusIIReaderParser2.Register(null);
			}
		}
		return vtkExodusIIReaderParser2;
	}
}
