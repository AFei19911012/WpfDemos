using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkXMLPDataObjectWriter
/// </summary>
/// <remarks>
///    Write data in a parallel XML format.
///
/// vtkXMLPDataWriter is the superclass for all XML parallel data object
/// writers.  It provides functionality needed for writing parallel
/// formats, such as the selection of which writer writes the summary
/// file and what range of pieces are assigned to each serial writer.
///
/// </remarks>
/// <seealso>
///
/// vtkXMLDataObjectWriter
/// </seealso>
public abstract class vtkXMLPDataObjectWriter : vtkXMLWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPDataObjectWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkXMLPDataObjectWriter()
	{
		MRClassNameKey = "class vtkXMLPDataObjectWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPDataObjectWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkXMLPDataObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLPDataObjectWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Controller used to communicate data type of blocks.
	/// By default, the global controller is used. If you want another
	/// controller to be used, set it with this.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLPDataObjectWriter_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkXMLPDataObjectWriter_GetEndPiece_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the range of pieces assigned to this writer.
	/// </summary>
	public virtual int GetEndPiece()
	{
		return vtkXMLPDataObjectWriter_GetEndPiece_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPDataObjectWriter_GetGhostLevel_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the ghost level used for this writer's piece.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkXMLPDataObjectWriter_GetGhostLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLPDataObjectWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkXMLPDataObjectWriter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkXMLPDataObjectWriter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkXMLPDataObjectWriter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPDataObjectWriter_GetNumberOfPieces_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the number of pieces that are being written in parallel.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkXMLPDataObjectWriter_GetNumberOfPieces_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPDataObjectWriter_GetStartPiece_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the range of pieces assigned to this writer.
	/// </summary>
	public virtual int GetStartPiece()
	{
		return vtkXMLPDataObjectWriter_GetStartPiece_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkXMLPDataObjectWriter_GetUseSubdirectory_08(HandleRef pThis);

	/// <summary>
	/// Get/Set whether to use a subdirectory to store the pieces
	/// </summary>
	public virtual bool GetUseSubdirectory()
	{
		return (vtkXMLPDataObjectWriter_GetUseSubdirectory_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPDataObjectWriter_GetWriteSummaryFile_09(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the writer should write the summary file that
	/// refers to all of the pieces' individual files.
	/// This is on by default. Note that only the first process writes
	/// the summary file.
	/// </summary>
	public virtual int GetWriteSummaryFile()
	{
		return vtkXMLPDataObjectWriter_GetWriteSummaryFile_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPDataObjectWriter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkXMLPDataObjectWriter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkXMLPDataObjectWriter_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkXMLPDataObjectWriter_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLPDataObjectWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkXMLPDataObjectWriter NewInstance()
	{
		vtkXMLPDataObjectWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLPDataObjectWriter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkXMLPDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkXMLPDataObjectWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkXMLPDataObjectWriter SafeDownCast(vtkObjectBase o)
	{
		vtkXMLPDataObjectWriter vtkXMLPDataObjectWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkXMLPDataObjectWriter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkXMLPDataObjectWriter2 = (vtkXMLPDataObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkXMLPDataObjectWriter2.Register(null);
			}
		}
		return vtkXMLPDataObjectWriter2;
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_SetController_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Controller used to communicate data type of blocks.
	/// By default, the global controller is used. If you want another
	/// controller to be used, set it with this.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkXMLPDataObjectWriter_SetController_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_SetEndPiece_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the range of pieces assigned to this writer.
	/// </summary>
	public virtual void SetEndPiece(int _arg)
	{
		vtkXMLPDataObjectWriter_SetEndPiece_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_SetGhostLevel_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the ghost level used for this writer's piece.
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkXMLPDataObjectWriter_SetGhostLevel_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_SetNumberOfPieces_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the number of pieces that are being written in parallel.
	/// </summary>
	public virtual void SetNumberOfPieces(int _arg)
	{
		vtkXMLPDataObjectWriter_SetNumberOfPieces_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_SetStartPiece_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the range of pieces assigned to this writer.
	/// </summary>
	public virtual void SetStartPiece(int _arg)
	{
		vtkXMLPDataObjectWriter_SetStartPiece_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_SetUseSubdirectory_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether to use a subdirectory to store the pieces
	/// </summary>
	public virtual void SetUseSubdirectory(bool _arg)
	{
		vtkXMLPDataObjectWriter_SetUseSubdirectory_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_SetWriteSummaryFile_20(HandleRef pThis, int flag);

	/// <summary>
	/// Get/Set whether the writer should write the summary file that
	/// refers to all of the pieces' individual files.
	/// This is on by default. Note that only the first process writes
	/// the summary file.
	/// </summary>
	public virtual void SetWriteSummaryFile(int flag)
	{
		vtkXMLPDataObjectWriter_SetWriteSummaryFile_20(GetCppThis(), flag);
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_WriteSummaryFileOff_21(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the writer should write the summary file that
	/// refers to all of the pieces' individual files.
	/// This is on by default. Note that only the first process writes
	/// the summary file.
	/// </summary>
	public virtual void WriteSummaryFileOff()
	{
		vtkXMLPDataObjectWriter_WriteSummaryFileOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkXMLPDataObjectWriter_WriteSummaryFileOn_22(HandleRef pThis);

	/// <summary>
	/// Get/Set whether the writer should write the summary file that
	/// refers to all of the pieces' individual files.
	/// This is on by default. Note that only the first process writes
	/// the summary file.
	/// </summary>
	public virtual void WriteSummaryFileOn()
	{
		vtkXMLPDataObjectWriter_WriteSummaryFileOn_22(GetCppThis());
	}
}
