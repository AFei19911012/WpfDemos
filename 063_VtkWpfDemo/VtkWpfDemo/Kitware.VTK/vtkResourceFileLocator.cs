using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkResourceFileLocator
/// </summary>
/// <remarks>
///  utility to locate resource files.
///
/// VTK based application often need to locate resource files, such configuration
/// files, Python modules, etc. vtkResourceFileLocator provides methods that can
/// be used to locate such resource files at runtime.
///
/// Using `Locate`, one can locate files relative to an
/// anchor directory such as the executable directory, or the library directory.
///
/// `GetLibraryPathForSymbolUnix` and `GetLibraryPathForSymbolWin32` methods can
/// be used to locate the library that provides a particular symbol. For example,
/// this is used by `vtkPythonInterpreter` to ensure that the `vtk` Python package
/// is located relative the VTK libraries, irrespective of the application location.
/// </remarks>
public class vtkResourceFileLocator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkResourceFileLocator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkResourceFileLocator()
	{
		MRClassNameKey = "class vtkResourceFileLocator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkResourceFileLocator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkResourceFileLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResourceFileLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResourceFileLocator New()
	{
		vtkResourceFileLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResourceFileLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResourceFileLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkResourceFileLocator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkResourceFileLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkResourceFileLocator_GetLibraryPathForSymbolUnix_01(string symbolname);

	/// <summary>
	/// Returns the name of the library providing the symbol. For example, if you
	/// want to locate where the VTK libraries located call
	/// `GetLibraryPathForSymbolUnix("GetVTKVersion")` on Unixes and
	/// `GetLibraryPathForSymbolWin32(GetVTKVersion)` on Windows. Alternatively, you
	/// can simply use the `vtkGetLibraryPathForSymbol(GetVTKVersion)` macro
	/// that makes the appropriate call as per the current platform.
	/// </summary>
	public static string GetLibraryPathForSymbolUnix(string symbolname)
	{
		return vtkResourceFileLocator_GetLibraryPathForSymbolUnix_01(symbolname);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkResourceFileLocator_GetLibraryPathForSymbolWin32_02(IntPtr fptr);

	/// <summary>
	/// Returns the name of the library providing the symbol. For example, if you
	/// want to locate where the VTK libraries located call
	/// `GetLibraryPathForSymbolUnix("GetVTKVersion")` on Unixes and
	/// `GetLibraryPathForSymbolWin32(GetVTKVersion)` on Windows. Alternatively, you
	/// can simply use the `vtkGetLibraryPathForSymbol(GetVTKVersion)` macro
	/// that makes the appropriate call as per the current platform.
	/// </summary>
	public static string GetLibraryPathForSymbolWin32(IntPtr fptr)
	{
		return vtkResourceFileLocator_GetLibraryPathForSymbolWin32_02(fptr);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResourceFileLocator_GetLogVerbosity_03(HandleRef pThis);

	/// <summary>
	/// The log verbosity to use when logging information about the resource
	/// searching. Default is `vtkLogger::VERBOSITY_TRACE`.
	/// </summary>
	public virtual int GetLogVerbosity()
	{
		return vtkResourceFileLocator_GetLogVerbosity_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResourceFileLocator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkResourceFileLocator_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkResourceFileLocator_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkResourceFileLocator_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResourceFileLocator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkResourceFileLocator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkResourceFileLocator_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkResourceFileLocator_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkResourceFileLocator_Locate_08(HandleRef pThis, string anchor, string landmark, string defaultDir);

	/// <summary>
	/// Given a starting anchor directory, look for the landmark file relative to
	/// the anchor. If found return the anchor. If not found, go one directory up
	/// and then look the landmark file again.
	/// </summary>
	public virtual string Locate(string anchor, string landmark, string defaultDir)
	{
		return vtkResourceFileLocator_Locate_08(GetCppThis(), anchor, landmark, defaultDir);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResourceFileLocator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkResourceFileLocator NewInstance()
	{
		vtkResourceFileLocator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResourceFileLocator_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkResourceFileLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkResourceFileLocator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkResourceFileLocator SafeDownCast(vtkObjectBase o)
	{
		vtkResourceFileLocator vtkResourceFileLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkResourceFileLocator_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkResourceFileLocator2 = (vtkResourceFileLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkResourceFileLocator2.Register(null);
			}
		}
		return vtkResourceFileLocator2;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkResourceFileLocator_SetLogVerbosity_12(HandleRef pThis, int _arg);

	/// <summary>
	/// The log verbosity to use when logging information about the resource
	/// searching. Default is `vtkLogger::VERBOSITY_TRACE`.
	/// </summary>
	public virtual void SetLogVerbosity(int _arg)
	{
		vtkResourceFileLocator_SetLogVerbosity_12(GetCppThis(), _arg);
	}
}
