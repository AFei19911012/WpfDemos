using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLCompositeDataWriter
/// </summary>
/// <remarks>
///    Writer for multi-group datasets
///
/// vtkXMLCompositeDataWriter writes (serially) the VTK XML multi-group,
/// multi-block hierarchical and hierarchical box files. XML multi-group
/// data files are meta-files that point to a list of serial VTK XML files.
/// </remarks>
/// <seealso>
///
/// vtkXMLPCompositeDataWriter
/// </seealso>
public abstract class vtkXMLCompositeDataWriter : vtkXMLWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLCompositeDataWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLCompositeDataWriter()
	{
		MRClassNameKey = "class vtkXMLCompositeDataWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLCompositeDataWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLCompositeDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkXMLCompositeDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

	/// <summary>
	/// Get the default file extension for files written by this writer.
	/// </summary>
	public override string GetDefaultFileExtension()
	{
		return Marshal.PtrToStringAnsi(vtkXMLCompositeDataWriter_GetDefaultFileExtension_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataWriter_GetGhostLevel_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of ghost levels to be written.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkXMLCompositeDataWriter_GetGhostLevel_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLCompositeDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLCompositeDataWriter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLCompositeDataWriter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLCompositeDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataWriter_GetWriteMetaFile_05(HandleRef pThis);

	/// <summary>
	/// Get/Set whether this instance will write the meta-file.
	/// </summary>
	public virtual int GetWriteMetaFile()
	{
		return vtkXMLCompositeDataWriter_GetWriteMetaFile_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataWriter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLCompositeDataWriter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLCompositeDataWriter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLCompositeDataWriter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLCompositeDataWriter NewInstance()
	{
		vtkXMLCompositeDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataWriter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLCompositeDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLCompositeDataWriter SafeDownCast(vtkObjectBase o)
	{
		vtkXMLCompositeDataWriter vtkXMLCompositeDataWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLCompositeDataWriter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLCompositeDataWriter2 = (vtkXMLCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLCompositeDataWriter2.Register(null);
			}
		}
		return vtkXMLCompositeDataWriter2;
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLCompositeDataWriter_SetGhostLevel_10(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of ghost levels to be written.
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkXMLCompositeDataWriter_SetGhostLevel_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLCompositeDataWriter_SetWriteMetaFile_11(HandleRef pThis, int flag);

	/// <summary>
	/// Get/Set whether this instance will write the meta-file.
	/// </summary>
	public virtual void SetWriteMetaFile(int flag)
	{
		vtkXMLCompositeDataWriter_SetWriteMetaFile_11(GetCppThis(), flag);
	}
}
