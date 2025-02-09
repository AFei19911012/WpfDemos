using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPSystemTools
/// </summary>
/// <remarks>
///    System tools for file system introspection
///
/// A class with only static methods for doing parallel file system
/// introspection. It limits doing file stats on process 0 and
/// broadcasting the results to other processes. It is built on VTK's
/// SystemTools class and uses the global controller for communication.
/// It uses blocking collective communication operations.
/// </remarks>
public class vtkPSystemTools : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPSystemTools";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPSystemTools()
	{
		MRClassNameKey = "class vtkPSystemTools";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPSystemTools"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPSystemTools(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPSystemTools_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPSystemTools New()
	{
		vtkPSystemTools result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPSystemTools_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPSystemTools)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPSystemTools()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPSystemTools_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPSystemTools_BroadcastString_01(string arg0, int proc);

	/// <summary>
	/// Given a string on process proc, broadcast that string to
	/// all of the other processes. This method does not have a
	/// correspondence to anything in SystemTools.
	/// </summary>
	public static void BroadcastString(string arg0, int proc)
	{
		vtkPSystemTools_BroadcastString_01(arg0, proc);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPSystemTools_CollapseFullPath_02(string in_relative);

	/// <summary>
	/// Given a path to a file or directory, convert it to a full path.
	/// This collapses away relative paths relative to the cwd argument
	/// (which defaults to the current working directory).  The full path
	/// is returned.
	/// </summary>
	public static string CollapseFullPath(string in_relative)
	{
		return vtkPSystemTools_CollapseFullPath_02(in_relative);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPSystemTools_CollapseFullPath_03(string in_relative, string in_base);

	/// <summary>
	/// Given a path to a file or directory, convert it to a full path.
	/// This collapses away relative paths relative to the cwd argument
	/// (which defaults to the current working directory).  The full path
	/// is returned.
	/// </summary>
	public static string CollapseFullPath(string in_relative, string in_base)
	{
		return vtkPSystemTools_CollapseFullPath_03(in_relative, in_base);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPSystemTools_FileExists_04(string filename, byte isFile);

	/// <summary>
	/// Return true if a file exists in the current directory.
	/// If isFile = true, then make sure the file is a file and
	/// not a directory.  If isFile = false, then return true
	/// if it is a file or a directory.  Note that the file will
	/// also be checked for read access.  (Currently, this check
	/// for read access is only done on POSIX systems.)
	/// </summary>
	public static bool FileExists(string filename, bool isFile)
	{
		return (vtkPSystemTools_FileExists_04(filename, (byte)(isFile ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPSystemTools_FileExists_05(string filename);

	/// <summary>
	/// Return true if a file exists in the current directory.
	/// If isFile = true, then make sure the file is a file and
	/// not a directory.  If isFile = false, then return true
	/// if it is a file or a directory.  Note that the file will
	/// also be checked for read access.  (Currently, this check
	/// for read access is only done on POSIX systems.)
	/// </summary>
	public static bool FileExists(string filename)
	{
		return (vtkPSystemTools_FileExists_05(filename) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPSystemTools_FileIsDirectory_06(string name);

	/// <summary>
	/// Return true if the file is a directory
	/// </summary>
	public static bool FileIsDirectory(string name)
	{
		return (vtkPSystemTools_FileIsDirectory_06(name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPSystemTools_FindProgramPath_07(string argv0, string pathOut, string errorMsg, string exeName, string buildDir, string installPrefix);

	/// <summary>
	/// Given argv[0] for a unix program find the full path to a running
	/// executable.  argv0 can be null for windows WinMain programs
	/// in this case GetModuleFileName will be used to find the path
	/// to the running executable.  If argv0 is not a full path,
	/// then this will try to find the full path.  If the path is not
	/// found false is returned, if found true is returned.  An error
	/// message of the attempted paths is stored in errorMsg.
	/// exeName is the name of the executable.
	/// buildDir is a possibly null path to the build directory.
	/// installPrefix is a possibly null pointer to the install directory.
	/// </summary>
	public static bool FindProgramPath(string argv0, string pathOut, string errorMsg, string exeName, string buildDir, string installPrefix)
	{
		return (vtkPSystemTools_FindProgramPath_07(argv0, pathOut, errorMsg, exeName, buildDir, installPrefix) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPSystemTools_GetCurrentWorkingDirectory_08(byte collapse);

	/// <summary>
	/// Get current working directory CWD
	/// </summary>
	public static string GetCurrentWorkingDirectory(bool collapse)
	{
		return vtkPSystemTools_GetCurrentWorkingDirectory_08((byte)(collapse ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPSystemTools_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPSystemTools_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPSystemTools_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPSystemTools_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPSystemTools_GetProgramPath_11(string arg0);

	/// <summary>
	/// Given the path to a program executable, get the directory part of
	/// the path with the file stripped off.  If there is no directory
	/// part, the empty string is returned.
	/// </summary>
	public static string GetProgramPath(string arg0)
	{
		return vtkPSystemTools_GetProgramPath_11(arg0);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPSystemTools_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPSystemTools_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPSystemTools_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPSystemTools_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPSystemTools_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPSystemTools NewInstance()
	{
		vtkPSystemTools result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPSystemTools_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPSystemTools)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPSystemTools_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPSystemTools SafeDownCast(vtkObjectBase o)
	{
		vtkPSystemTools vtkPSystemTools2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPSystemTools_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPSystemTools2 = (vtkPSystemTools)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPSystemTools2.Register(null);
			}
		}
		return vtkPSystemTools2;
	}
}
