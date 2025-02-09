using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPDataSetWriter
/// </summary>
/// <remarks>
///    Manages writing pieces of a data set.
///
/// vtkPDataSetWriter will write a piece of a file, and will also create
/// a metadata file that lists all of the files in a data set.
/// </remarks>
public class vtkPDataSetWriter : vtkDataSetWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPDataSetWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPDataSetWriter()
	{
		MRClassNameKey = "class vtkPDataSetWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDataSetWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPDataSetWriter New()
	{
		vtkPDataSetWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPDataSetWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPDataSetWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPDataSetWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDataSetWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		IntPtr intPtr = vtkPDataSetWriter_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDataSetWriter_GetEndPiece_02(HandleRef pThis);

	/// <summary>
	/// This is the range of pieces that that this writer is
	/// responsible for writing.  All pieces must be written
	/// by some process.  The process that writes piece 0 also
	/// writes the pvtk file that lists all the piece file names.
	/// </summary>
	public virtual int GetEndPiece()
	{
		return vtkPDataSetWriter_GetEndPiece_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDataSetWriter_GetFilePattern_03(HandleRef pThis);

	/// <summary>
	/// This file pattern uses the file name and piece number
	/// to construct a file name for the piece file.
	/// </summary>
	public virtual string GetFilePattern()
	{
		return Marshal.PtrToStringAnsi(vtkPDataSetWriter_GetFilePattern_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDataSetWriter_GetGhostLevel_04(HandleRef pThis);

	/// <summary>
	/// Extra ghost cells will be written out to each piece file
	/// if this value is larger than 0.
	/// </summary>
	public virtual int GetGhostLevel()
	{
		return vtkPDataSetWriter_GetGhostLevel_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPDataSetWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPDataSetWriter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPDataSetWriter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPDataSetWriter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDataSetWriter_GetNumberOfPieces_07(HandleRef pThis);

	/// <summary>
	/// This is how many pieces the whole data set will be divided into.
	/// </summary>
	public virtual int GetNumberOfPieces()
	{
		return vtkPDataSetWriter_GetNumberOfPieces_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDataSetWriter_GetStartPiece_08(HandleRef pThis);

	/// <summary>
	/// This is the range of pieces that that this writer is
	/// responsible for writing.  All pieces must be written
	/// by some process.  The process that writes piece 0 also
	/// writes the pvtk file that lists all the piece file names.
	/// </summary>
	public virtual int GetStartPiece()
	{
		return vtkPDataSetWriter_GetStartPiece_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDataSetWriter_GetUseRelativeFileNames_09(HandleRef pThis);

	/// <summary>
	/// This flag determines whether to use absolute paths for the piece files.
	/// By default the pieces are put in the main directory, and the piece file
	/// names in the meta data pvtk file are relative to this directory.
	/// This should make moving the whole lot to another directory, an easier task.
	/// </summary>
	public virtual int GetUseRelativeFileNames()
	{
		return vtkPDataSetWriter_GetUseRelativeFileNames_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDataSetWriter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPDataSetWriter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDataSetWriter_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPDataSetWriter_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDataSetWriter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPDataSetWriter NewInstance()
	{
		vtkPDataSetWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPDataSetWriter_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDataSetWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPDataSetWriter SafeDownCast(vtkObjectBase o)
	{
		vtkPDataSetWriter vtkPDataSetWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPDataSetWriter_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPDataSetWriter2 = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPDataSetWriter2.Register(null);
			}
		}
		return vtkPDataSetWriter2;
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_SetController_15(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Controller used to communicate data type of blocks.
	/// By default, the global controller is used. If you want another
	/// controller to be used, set it with this.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkPDataSetWriter_SetController_15(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_SetEndPiece_16(HandleRef pThis, int _arg);

	/// <summary>
	/// This is the range of pieces that that this writer is
	/// responsible for writing.  All pieces must be written
	/// by some process.  The process that writes piece 0 also
	/// writes the pvtk file that lists all the piece file names.
	/// </summary>
	public virtual void SetEndPiece(int _arg)
	{
		vtkPDataSetWriter_SetEndPiece_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_SetFilePattern_17(HandleRef pThis, string _arg);

	/// <summary>
	/// This file pattern uses the file name and piece number
	/// to construct a file name for the piece file.
	/// </summary>
	public virtual void SetFilePattern(string _arg)
	{
		vtkPDataSetWriter_SetFilePattern_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_SetGhostLevel_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Extra ghost cells will be written out to each piece file
	/// if this value is larger than 0.
	/// </summary>
	public virtual void SetGhostLevel(int _arg)
	{
		vtkPDataSetWriter_SetGhostLevel_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_SetNumberOfPieces_19(HandleRef pThis, int num);

	/// <summary>
	/// This is how many pieces the whole data set will be divided into.
	/// </summary>
	public void SetNumberOfPieces(int num)
	{
		vtkPDataSetWriter_SetNumberOfPieces_19(GetCppThis(), num);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_SetStartPiece_20(HandleRef pThis, int _arg);

	/// <summary>
	/// This is the range of pieces that that this writer is
	/// responsible for writing.  All pieces must be written
	/// by some process.  The process that writes piece 0 also
	/// writes the pvtk file that lists all the piece file names.
	/// </summary>
	public virtual void SetStartPiece(int _arg)
	{
		vtkPDataSetWriter_SetStartPiece_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_SetUseRelativeFileNames_21(HandleRef pThis, int _arg);

	/// <summary>
	/// This flag determines whether to use absolute paths for the piece files.
	/// By default the pieces are put in the main directory, and the piece file
	/// names in the meta data pvtk file are relative to this directory.
	/// This should make moving the whole lot to another directory, an easier task.
	/// </summary>
	public virtual void SetUseRelativeFileNames(int _arg)
	{
		vtkPDataSetWriter_SetUseRelativeFileNames_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_UseRelativeFileNamesOff_22(HandleRef pThis);

	/// <summary>
	/// This flag determines whether to use absolute paths for the piece files.
	/// By default the pieces are put in the main directory, and the piece file
	/// names in the meta data pvtk file are relative to this directory.
	/// This should make moving the whole lot to another directory, an easier task.
	/// </summary>
	public virtual void UseRelativeFileNamesOff()
	{
		vtkPDataSetWriter_UseRelativeFileNamesOff_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDataSetWriter_UseRelativeFileNamesOn_23(HandleRef pThis);

	/// <summary>
	/// This flag determines whether to use absolute paths for the piece files.
	/// By default the pieces are put in the main directory, and the piece file
	/// names in the meta data pvtk file are relative to this directory.
	/// This should make moving the whole lot to another directory, an easier task.
	/// </summary>
	public virtual void UseRelativeFileNamesOn()
	{
		vtkPDataSetWriter_UseRelativeFileNamesOn_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDataSetWriter_Write_24(HandleRef pThis);

	/// <summary>
	/// Write the pvtk file and corresponding vtk files.
	/// </summary>
	public override int Write()
	{
		return vtkPDataSetWriter_Write_24(GetCppThis());
	}
}
