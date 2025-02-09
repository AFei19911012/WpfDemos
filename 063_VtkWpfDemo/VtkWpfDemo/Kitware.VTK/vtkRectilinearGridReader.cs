using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectilinearGridReader
/// </summary>
/// <remarks>
///    read vtk rectilinear grid data file
///
/// vtkRectilinearGridReader is a source object that reads ASCII or binary
/// rectilinear grid data files in vtk format (see text for format details).
/// The output of this reader is a single vtkRectilinearGrid data object.
/// The superclass of this class, vtkDataReader, provides many methods for
/// controlling the reading of the data file, see vtkDataReader for more
/// information.
/// @warning
/// Binary files written on one system may not be readable on other systems.
/// </remarks>
/// <seealso>
///
/// vtkRectilinearGrid vtkDataReader
/// </seealso>
public class vtkRectilinearGridReader : vtkDataReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectilinearGridReader()
	{
		MRClassNameKey = "class vtkRectilinearGridReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectilinearGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridReader New()
	{
		vtkRectilinearGridReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRectilinearGridReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectilinearGridReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectilinearGridReader_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectilinearGridReader_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectilinearGridReader_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get and set the output of this reader.
	/// </summary>
	public vtkRectilinearGrid GetOutput()
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridReader_GetOutput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGrid2 = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGrid2.Register(null);
			}
		}
		return vtkRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get and set the output of this reader.
	/// </summary>
	public vtkRectilinearGrid GetOutput(int idx)
	{
		vtkRectilinearGrid vtkRectilinearGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridReader_GetOutput_04(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGrid2 = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGrid2.Register(null);
			}
		}
		return vtkRectilinearGrid2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridReader_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectilinearGridReader_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridReader_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectilinearGridReader_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRectilinearGridReader NewInstance()
	{
		vtkRectilinearGridReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridReader_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridReader_ReadMeshSimple_09(HandleRef pThis, string fname, HandleRef output);

	/// <summary>
	/// Actual reading happens here
	/// </summary>
	public override int ReadMeshSimple(string fname, vtkDataObject output)
	{
		return vtkRectilinearGridReader_ReadMeshSimple_09(GetCppThis(), fname, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectilinearGridReader_ReadMetaDataSimple_10(HandleRef pThis, string fname, HandleRef metadata);

	/// <summary>
	/// Read the meta information from the file (WHOLE_EXTENT).
	/// </summary>
	public override int ReadMetaDataSimple(string fname, vtkInformation metadata)
	{
		return vtkRectilinearGridReader_ReadMetaDataSimple_10(GetCppThis(), fname, metadata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectilinearGridReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectilinearGridReader SafeDownCast(vtkObjectBase o)
	{
		vtkRectilinearGridReader vtkRectilinearGridReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectilinearGridReader_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectilinearGridReader2 = (vtkRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectilinearGridReader2.Register(null);
			}
		}
		return vtkRectilinearGridReader2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectilinearGridReader_SetOutput_12(HandleRef pThis, HandleRef output);

	/// <summary>
	/// Get and set the output of this reader.
	/// </summary>
	public void SetOutput(vtkRectilinearGrid output)
	{
		vtkRectilinearGridReader_SetOutput_12(GetCppThis(), output?.GetCppThis() ?? default(HandleRef));
	}
}
