using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPDirectory
///
/// vtkPDirectory provides a portable way of finding the names of the files
/// in a system directory where process 0 finds the information and
/// broadcasts it to other processes. It tries to replicate the API for both
/// Directory and vtkDirectory though there are slight mismatches between the
/// two. This is a blocking collective operation.
/// </summary>
public class vtkPDirectory : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPDirectory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPDirectory()
	{
		MRClassNameKey = "class vtkPDirectory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDirectory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDirectory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPDirectory New()
	{
		vtkPDirectory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPDirectory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPDirectory()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPDirectory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPDirectory_Clear_01(HandleRef pThis);

	/// <summary>
	/// Clear the internal structure. Used internally at beginning of Load(...)
	/// to clear the cache.
	/// </summary>
	public void Clear()
	{
		vtkPDirectory_Clear_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDirectory_DeleteDirectory_02(string dir);

	/// <summary>
	/// Remove a directory.
	/// </summary>
	public static int DeleteDirectory(string dir)
	{
		return vtkPDirectory_DeleteDirectory_02(dir);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDirectory_FileIsDirectory_03(HandleRef pThis, string name);

	/// <summary>
	/// Return true if the file is a directory.  If the file is not an
	/// absolute path, it is assumed to be relative to the opened
	/// directory. If no directory has been opened, it is assumed to
	/// be relative to the current working directory.
	/// </summary>
	public int FileIsDirectory(string name)
	{
		return vtkPDirectory_FileIsDirectory_03(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDirectory_GetCurrentWorkingDirectory_04(string buf, uint len);

	/// <summary>
	/// Get the current working directory.
	/// </summary>
	public static string GetCurrentWorkingDirectory(string buf, uint len)
	{
		return Marshal.PtrToStringAnsi(vtkPDirectory_GetCurrentWorkingDirectory_04(buf, len));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDirectory_GetFile_05(HandleRef pThis, long index);

	/// <summary>
	/// Return the file at the given index, the indexing is 0 based
	/// </summary>
	public string GetFile(long index)
	{
		return Marshal.PtrToStringAnsi(vtkPDirectory_GetFile_05(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDirectory_GetFiles_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get an array that contains all the file names.
	/// </summary>
	public virtual vtkStringArray GetFiles()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPDirectory_GetFiles_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPDirectory_GetNumberOfFiles_07(HandleRef pThis);

	/// <summary>
	/// Return the number of files in the current directory.
	/// </summary>
	public long GetNumberOfFiles()
	{
		return vtkPDirectory_GetNumberOfFiles_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPDirectory_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPDirectory_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPDirectory_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPDirectory_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDirectory_GetPath_10(HandleRef pThis);

	/// <summary>
	/// Return the path to Open'ed directory
	/// </summary>
	public string GetPath()
	{
		return Marshal.PtrToStringAnsi(vtkPDirectory_GetPath_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDirectory_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPDirectory_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDirectory_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPDirectory_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPDirectory_Load_13(HandleRef pThis, string arg0);

	/// <summary>
	/// Open/Load the specified directory and load the names of the files
	/// in that directory. false/0 is returned if the directory can not be
	/// opened, true/1 if it is opened. The reason that there are two versions
	/// of this is that Directory uses Load() and vtkDirectory uses Open()
	/// for this functionality.
	/// </summary>
	public bool Load(string arg0)
	{
		return (vtkPDirectory_Load_13(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDirectory_MakeDirectory_14(string dir);

	/// <summary>
	/// Create directory.
	/// </summary>
	public static int MakeDirectory(string dir)
	{
		return vtkPDirectory_MakeDirectory_14(dir);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDirectory_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPDirectory NewInstance()
	{
		vtkPDirectory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPDirectory_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDirectory_Open_17(HandleRef pThis, string dir);

	/// <summary>
	/// Open/Load the specified directory and load the names of the files
	/// in that directory. false/0 is returned if the directory can not be
	/// opened, true/1 if it is opened. The reason that there are two versions
	/// of this is that Directory uses Load() and vtkDirectory uses Open()
	/// for this functionality.
	/// </summary>
	public int Open(string dir)
	{
		return vtkPDirectory_Open_17(GetCppThis(), dir);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPDirectory_Rename_18(string oldname, string newname);

	/// <summary>
	/// Rename a file or directory.
	/// </summary>
	public static int Rename(string oldname, string newname)
	{
		return vtkPDirectory_Rename_18(oldname, newname);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPDirectory_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPDirectory SafeDownCast(vtkObjectBase o)
	{
		vtkPDirectory vtkPDirectory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPDirectory_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPDirectory2 = (vtkPDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPDirectory2.Register(null);
			}
		}
		return vtkPDirectory2;
	}
}
