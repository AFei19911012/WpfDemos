using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDirectory
/// </summary>
/// <remarks>
///    OS independent class for access and manipulation of system directories
///
/// vtkDirectory provides a portable way of finding the names of the files
/// in a system directory.  It also provides methods of manipulating directories.
///
/// @warning
/// vtkDirectory works with windows and unix only.
/// </remarks>
public class vtkDirectory : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDirectory";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDirectory()
	{
		MRClassNameKey = "class vtkDirectory";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectory"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkDirectory object.
	/// </summary>
	public new static vtkDirectory New()
	{
		vtkDirectory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDirectory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkDirectory object.
	/// </summary>
	public vtkDirectory()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDirectory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectory_DeleteDirectory_01(string dir);

	/// <summary>
	/// Remove a directory.
	/// </summary>
	public static int DeleteDirectory(string dir)
	{
		return vtkDirectory_DeleteDirectory_01(dir);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectory_FileIsDirectory_02(HandleRef pThis, string name);

	/// <summary>
	/// Return true if the file is a directory.  If the file is not an
	/// absolute path, it is assumed to be relative to the opened
	/// directory. If no directory has been opened, it is assumed to
	/// be relative to the current working directory.
	/// </summary>
	public int FileIsDirectory(string name)
	{
		return vtkDirectory_FileIsDirectory_02(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectory_GetCurrentWorkingDirectory_03(string buf, uint len);

	/// <summary>
	/// Get the current working directory.
	/// </summary>
	public static string GetCurrentWorkingDirectory(string buf, uint len)
	{
		return Marshal.PtrToStringAnsi(vtkDirectory_GetCurrentWorkingDirectory_03(buf, len));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectory_GetFile_04(HandleRef pThis, long index);

	/// <summary>
	/// Return the file at the given index, the indexing is 0 based
	/// </summary>
	public string GetFile(long index)
	{
		return Marshal.PtrToStringAnsi(vtkDirectory_GetFile_04(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectory_GetFiles_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get an array that contains all the file names.
	/// </summary>
	public virtual vtkStringArray GetFiles()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDirectory_GetFiles_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDirectory_GetNumberOfFiles_06(HandleRef pThis);

	/// <summary>
	/// Return the number of files in the current directory.
	/// </summary>
	public long GetNumberOfFiles()
	{
		return vtkDirectory_GetNumberOfFiles_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDirectory_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDirectory_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDirectory_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDirectory_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectory_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDirectory_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectory_IsTypeOf_10(string type);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDirectory_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectory_MakeDirectory_11(string dir);

	/// <summary>
	/// Create directory.
	/// </summary>
	public static int MakeDirectory(string dir)
	{
		return vtkDirectory_MakeDirectory_11(dir);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectory_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public new vtkDirectory NewInstance()
	{
		vtkDirectory result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDirectory_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectory_Open_14(HandleRef pThis, string dir);

	/// <summary>
	/// Open the specified directory and load the names of the files
	/// in that directory. 0 is returned if the directory can not be
	/// opened, 1 if it is opened.
	/// </summary>
	public int Open(string dir)
	{
		return vtkDirectory_Open_14(GetCppThis(), dir);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDirectory_Rename_15(string oldname, string newname);

	/// <summary>
	/// Rename a file or directory.
	/// </summary>
	public static int Rename(string oldname, string newname)
	{
		return vtkDirectory_Rename_15(oldname, newname);
	}

	[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDirectory_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public new static vtkDirectory SafeDownCast(vtkObjectBase o)
	{
		vtkDirectory vtkDirectory2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDirectory_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDirectory2 = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDirectory2.Register(null);
			}
		}
		return vtkDirectory2;
	}
}
