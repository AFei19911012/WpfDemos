using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOBJImporter
/// </summary>
/// <remarks>
///    import from .obj wavefront files
///
///                        from Wavefront .obj &amp; associated .mtl files.
/// @par Thanks - Peter Karasev (Georgia Tech / Keysight Technologies Inc),:
///                   Allen Tannenbaum (SUNY Stonybrook), Patricio Vela (Georgia Tech)
/// </remarks>
/// <seealso>
///
///  vtkImporter
/// </seealso>
public class vtkOBJImporter : vtkImporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOBJImporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOBJImporter()
	{
		MRClassNameKey = "class vtkOBJImporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBJImporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOBJImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBJImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOBJImporter New()
	{
		vtkOBJImporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOBJImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOBJImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOBJImporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOBJImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBJImporter_GetFileName_01(HandleRef pThis);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkOBJImporter_GetFileName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBJImporter_GetFileNameMTL_02(HandleRef pThis);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public string GetFileNameMTL()
	{
		return Marshal.PtrToStringAnsi(vtkOBJImporter_GetFileNameMTL_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOBJImporter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOBJImporter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOBJImporter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOBJImporter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkOBJImporter_GetOutputDescription_05(HandleRef pThis, int idx);

	/// <summary>
	/// Get a string describing an output
	/// </summary>
	public string GetOutputDescription(int idx)
	{
		return vtkOBJImporter_GetOutputDescription_05(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkOBJImporter_GetOutputsDescription_06(HandleRef pThis);

	/// <summary>
	/// Get a printable string describing all outputs
	/// </summary>
	public override string GetOutputsDescription()
	{
		return vtkOBJImporter_GetOutputsDescription_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBJImporter_GetTexturePath_07(HandleRef pThis);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public string GetTexturePath()
	{
		return Marshal.PtrToStringAnsi(vtkOBJImporter_GetTexturePath_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOBJImporter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOBJImporter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOBJImporter_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOBJImporter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBJImporter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOBJImporter NewInstance()
	{
		vtkOBJImporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOBJImporter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOBJImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOBJImporter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOBJImporter SafeDownCast(vtkObjectBase o)
	{
		vtkOBJImporter vtkOBJImporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOBJImporter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOBJImporter2 = (vtkOBJImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOBJImporter2.Register(null);
			}
		}
		return vtkOBJImporter2;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBJImporter_SetFileName_13(HandleRef pThis, string arg);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public void SetFileName(string arg)
	{
		vtkOBJImporter_SetFileName_13(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBJImporter_SetFileNameMTL_14(HandleRef pThis, string arg);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public void SetFileNameMTL(string arg)
	{
		vtkOBJImporter_SetFileNameMTL_14(GetCppThis(), arg);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOBJImporter_SetTexturePath_15(HandleRef pThis, string path);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public void SetTexturePath(string path)
	{
		vtkOBJImporter_SetTexturePath_15(GetCppThis(), path);
	}
}
