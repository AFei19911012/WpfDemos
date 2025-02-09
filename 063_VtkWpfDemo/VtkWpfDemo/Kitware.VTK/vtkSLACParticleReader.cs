using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSLACParticleReader
///
///
///
/// A reader for a data format used by Omega3p, Tau3p, and several other tools
/// used at the Standford Linear Accelerator Center (SLAC).  The underlying
/// format uses netCDF to store arrays, but also imposes some conventions
/// to store a list of particles in 3D space.
///
/// This reader supports pieces, but in actuality only loads anything in
/// piece 0.  All other pieces are empty.
///
/// </summary>
public class vtkSLACParticleReader : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSLACParticleReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSLACParticleReader()
	{
		MRClassNameKey = "class vtkSLACParticleReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSLACParticleReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSLACParticleReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACParticleReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSLACParticleReader New()
	{
		vtkSLACParticleReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACParticleReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSLACParticleReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSLACParticleReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACParticleReader_CanReadFile_01(string filename);

	/// <summary>
	/// Returns true if the given file can be read by this reader.
	/// </summary>
	public static int CanReadFile(string filename)
	{
		return vtkSLACParticleReader_CanReadFile_01(filename);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACParticleReader_GetFileName_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSLACParticleReader_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSLACParticleReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSLACParticleReader_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSLACParticleReader_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSLACParticleReader_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACParticleReader_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSLACParticleReader_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSLACParticleReader_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSLACParticleReader_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACParticleReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSLACParticleReader NewInstance()
	{
		vtkSLACParticleReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACParticleReader_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSLACParticleReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSLACParticleReader SafeDownCast(vtkObjectBase o)
	{
		vtkSLACParticleReader vtkSLACParticleReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSLACParticleReader_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSLACParticleReader2 = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSLACParticleReader2.Register(null);
			}
		}
		return vtkSLACParticleReader2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSLACParticleReader_SetFileName_10(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkSLACParticleReader_SetFileName_10(GetCppThis(), _arg);
	}
}
