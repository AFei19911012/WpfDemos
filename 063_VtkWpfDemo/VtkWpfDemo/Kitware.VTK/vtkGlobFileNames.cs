using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGlobFileNames
/// </summary>
/// <remarks>
///    find files that match a wildcard pattern
///
/// vtkGlobFileNames is a utility for finding files and directories
/// that match a given wildcard pattern.  Allowed wildcards are
/// *, ?, [...], [!...]. The "*" wildcard matches any substring,
/// the "?" matches any single character, the [...] matches any one of
/// the enclosed characters, e.g. [abc] will match one of a, b, or c,
/// while [0-9] will match any digit, and [!...] will match any single
/// character except for the ones within the brackets.  Special
/// treatment is given to "/" (or "\" on Windows) because these are
/// path separators.  These are never matched by a wildcard, they are
/// only matched with another file separator.
/// @warning
/// This function performs case-sensitive matches on UNIX and
/// case-insensitive matches on Windows.
/// </remarks>
/// <seealso>
///
/// vtkDirectory
/// </seealso>
public class vtkGlobFileNames : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGlobFileNames";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGlobFileNames()
	{
		MRClassNameKey = "class vtkGlobFileNames";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlobFileNames"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGlobFileNames(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlobFileNames_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new vtkGlobFileNames object.
	/// </summary>
	public new static vtkGlobFileNames New()
	{
		vtkGlobFileNames result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlobFileNames_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new vtkGlobFileNames object.
	/// </summary>
	public vtkGlobFileNames()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGlobFileNames_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlobFileNames_AddFileNames_01(HandleRef pThis, string pattern);

	/// <summary>
	/// Search for all files that match the given expression,
	/// sort them, and add them to the output.  This method can
	/// be called repeatedly to add files matching additional patterns.
	/// Returns 1 if successful, otherwise returns zero.
	/// </summary>
	public int AddFileNames(string pattern)
	{
		return vtkGlobFileNames_AddFileNames_01(GetCppThis(), pattern);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlobFileNames_GetDirectory_02(HandleRef pThis);

	/// <summary>
	/// Set the directory in which to perform the glob.  If this is
	/// not set, then the current directory will be used.  Also, if
	/// you use a glob pattern that contains absolute path (one that
	/// starts with "/" or a drive letter) then that absolute path
	/// will be used and Directory will be ignored.
	/// </summary>
	public virtual string GetDirectory()
	{
		return Marshal.PtrToStringAnsi(vtkGlobFileNames_GetDirectory_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlobFileNames_GetFileNames_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get an array that contains all the file names.
	/// </summary>
	public virtual vtkStringArray GetFileNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlobFileNames_GetFileNames_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlobFileNames_GetNthFileName_04(HandleRef pThis, int index);

	/// <summary>
	/// Return the file at the given index, the indexing is 0 based.
	/// </summary>
	public string GetNthFileName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkGlobFileNames_GetNthFileName_04(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlobFileNames_GetNumberOfFileNames_05(HandleRef pThis);

	/// <summary>
	/// Return the number of files found.
	/// </summary>
	public int GetNumberOfFileNames()
	{
		return vtkGlobFileNames_GetNumberOfFileNames_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlobFileNames_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGlobFileNames_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlobFileNames_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGlobFileNames_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlobFileNames_GetRecurse_08(HandleRef pThis);

	/// <summary>
	/// Recurse into subdirectories.
	/// </summary>
	public virtual int GetRecurse()
	{
		return vtkGlobFileNames_GetRecurse_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlobFileNames_IsA_09(HandleRef pThis, string type);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGlobFileNames_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlobFileNames_IsTypeOf_10(string type);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGlobFileNames_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlobFileNames_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public new vtkGlobFileNames NewInstance()
	{
		vtkGlobFileNames result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlobFileNames_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlobFileNames_RecurseOff_13(HandleRef pThis);

	/// <summary>
	/// Recurse into subdirectories.
	/// </summary>
	public virtual void RecurseOff()
	{
		vtkGlobFileNames_RecurseOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlobFileNames_RecurseOn_14(HandleRef pThis);

	/// <summary>
	/// Recurse into subdirectories.
	/// </summary>
	public virtual void RecurseOn()
	{
		vtkGlobFileNames_RecurseOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlobFileNames_Reset_15(HandleRef pThis);

	/// <summary>
	/// Reset the glob by clearing the list of output filenames.
	/// </summary>
	public void Reset()
	{
		vtkGlobFileNames_Reset_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlobFileNames_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the class name as a string.
	/// </summary>
	public new static vtkGlobFileNames SafeDownCast(vtkObjectBase o)
	{
		vtkGlobFileNames vtkGlobFileNames2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlobFileNames_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGlobFileNames2 = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGlobFileNames2.Register(null);
			}
		}
		return vtkGlobFileNames2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlobFileNames_SetDirectory_17(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the directory in which to perform the glob.  If this is
	/// not set, then the current directory will be used.  Also, if
	/// you use a glob pattern that contains absolute path (one that
	/// starts with "/" or a drive letter) then that absolute path
	/// will be used and Directory will be ignored.
	/// </summary>
	public virtual void SetDirectory(string _arg)
	{
		vtkGlobFileNames_SetDirectory_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlobFileNames_SetRecurse_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Recurse into subdirectories.
	/// </summary>
	public virtual void SetRecurse(int _arg)
	{
		vtkGlobFileNames_SetRecurse_18(GetCppThis(), _arg);
	}
}
