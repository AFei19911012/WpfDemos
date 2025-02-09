using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkOMETIFFReader
/// </summary>
/// <remarks>
///  reader for OME TIFF files
///
/// vtkOMETIFFReader supports reading OME-TIFF files. These are TIFF files with
/// OME meta-data that helps interpret the contents of the TIFF.
///
/// The OME-TIFF specification is available here:
/// https://docs.openmicroscopy.org/ome-model/5.6.3/ome-tiff/specification.html#ome-tiff-specification
///
/// The current implementation only supports single-file, multi-page TIFF. It
/// will not read multi-file OME-TIFF files correctly.
///
/// Unlike most image readers, this reader does not support arbitrary sub-extent
/// requests. This is because the splicing of the `z`, `t`, and `c` planes can make it
/// tricky to read sub-extents in `z` for certain dimension orders. This reader
/// supports piece-request instead and satisfies such request by splitting the
/// `XY` plane into requested number of pieces.
///
/// The reader lets the superclass read the whole TIFF volume and then splice it
/// up into channels, timesteps, and z-planes. The parts are then cached
/// internally so that subsequent timestep requests can be served without
/// re-reading the file.
/// </remarks>
public class vtkOMETIFFReader : vtkTIFFReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOMETIFFReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOMETIFFReader()
	{
		MRClassNameKey = "class vtkOMETIFFReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOMETIFFReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOMETIFFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOMETIFFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOMETIFFReader New()
	{
		vtkOMETIFFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOMETIFFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOMETIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOMETIFFReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOMETIFFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOMETIFFReader_CanReadFile_01(HandleRef pThis, string fname);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int CanReadFile(string fname)
	{
		return vtkOMETIFFReader_CanReadFile_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOMETIFFReader_GetDescriptiveName_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkOMETIFFReader_GetDescriptiveName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOMETIFFReader_GetFileExtensions_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkOMETIFFReader_GetFileExtensions_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOMETIFFReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOMETIFFReader_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOMETIFFReader_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOMETIFFReader_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOMETIFFReader_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOMETIFFReader_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOMETIFFReader_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOMETIFFReader_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOMETIFFReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOMETIFFReader NewInstance()
	{
		vtkOMETIFFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOMETIFFReader_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOMETIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOMETIFFReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOMETIFFReader SafeDownCast(vtkObjectBase o)
	{
		vtkOMETIFFReader vtkOMETIFFReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOMETIFFReader_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOMETIFFReader2 = (vtkOMETIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOMETIFFReader2.Register(null);
			}
		}
		return vtkOMETIFFReader2;
	}
}
