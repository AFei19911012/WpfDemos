using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLPMultiBlockDataWriter
/// </summary>
/// <remarks>
///    parallel writer for
/// vtkHierarchicalBoxDataSet.
///
/// vtkXMLPCompositeDataWriter writes (in parallel or serially) the VTK XML
/// multi-group, multi-block hierarchical and hierarchical box files. XML
/// multi-group data files are meta-files that point to a list of serial VTK
/// XML files.
/// </remarks>
public class vtkXMLPMultiBlockDataWriter : vtkXMLMultiBlockDataWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPMultiBlockDataWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLPMultiBlockDataWriter()
	{
		MRClassNameKey = "class vtkXMLPMultiBlockDataWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPMultiBlockDataWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLPMultiBlockDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLPMultiBlockDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLPMultiBlockDataWriter New()
	{
		vtkXMLPMultiBlockDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLPMultiBlockDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkXMLPMultiBlockDataWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkXMLPMultiBlockDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkXMLPMultiBlockDataWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Controller used to communicate data type of blocks.
	/// By default, the global controller is used. If you want another
	/// controller to be used, set it with this.
	/// If no controller is set, only the local blocks will be written
	/// to the meta-file.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLPMultiBlockDataWriter_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLPMultiBlockDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLPMultiBlockDataWriter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLPMultiBlockDataWriter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLPMultiBlockDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPMultiBlockDataWriter_GetNumberOfPieces_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of pieces that are being written in parallel.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkXMLPMultiBlockDataWriter_GetNumberOfPieces_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPMultiBlockDataWriter_GetStartPiece_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the range of pieces assigned to this writer.
	/// </summary>
	public virtual int GetStartPiece()
	{
		return vtkXMLPMultiBlockDataWriter_GetStartPiece_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPMultiBlockDataWriter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLPMultiBlockDataWriter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPMultiBlockDataWriter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLPMultiBlockDataWriter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLPMultiBlockDataWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLPMultiBlockDataWriter NewInstance()
	{
		vtkXMLPMultiBlockDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLPMultiBlockDataWriter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLPMultiBlockDataWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLPMultiBlockDataWriter SafeDownCast(vtkObjectBase o)
	{
		vtkXMLPMultiBlockDataWriter vtkXMLPMultiBlockDataWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLPMultiBlockDataWriter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLPMultiBlockDataWriter2 = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLPMultiBlockDataWriter2.Register(null);
			}
		}
		return vtkXMLPMultiBlockDataWriter2;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPMultiBlockDataWriter_SetController_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Controller used to communicate data type of blocks.
	/// By default, the global controller is used. If you want another
	/// controller to be used, set it with this.
	/// If no controller is set, only the local blocks will be written
	/// to the meta-file.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkXMLPMultiBlockDataWriter_SetController_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPMultiBlockDataWriter_SetNumberOfPieces_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of pieces that are being written in parallel.
	/// </summary>
	public virtual void SetNumberOfPieces(int _arg)
	{
		vtkXMLPMultiBlockDataWriter_SetNumberOfPieces_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPMultiBlockDataWriter_SetStartPiece_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the range of pieces assigned to this writer.
	/// </summary>
	public virtual void SetStartPiece(int _arg)
	{
		vtkXMLPMultiBlockDataWriter_SetStartPiece_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPMultiBlockDataWriter_SetWriteMetaFile_14(HandleRef pThis, int flag);

	/// <summary>
	/// Set whether this instance will write the meta-file. WriteMetaFile
	/// is set to flag only on process 0 and all other processes have
	/// WriteMetaFile set to 0 by default.
	/// </summary>
	public override void SetWriteMetaFile(int flag)
	{
		vtkXMLPMultiBlockDataWriter_SetWriteMetaFile_14(GetCppThis(), flag);
	}
}
