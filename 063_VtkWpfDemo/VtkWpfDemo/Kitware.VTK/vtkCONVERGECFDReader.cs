using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///     vtkCONVERGECFDReader
/// </summary>
/// <remarks>
///     Reader for CONVERGE CFD post files.
///
/// This class reads CONVERGE CFD post files containing meshes, surfaces,
/// and parcels. Each stream in a file is read as a top-level
/// block and meshes, surfaces, and parcels are datasets under
/// each stream block.
///
/// Cell data arrays associated with mesh cells can be individually
/// selected for reading using the CellArrayStatus API.
///
/// Point data arrays associated with parcels can be individually selected
/// for reading using the ParcelArrayStatus API.
///
/// Time series are supported. The reader assumes a time series is defined
/// in a sequence of files that follow the naming convention
///
/// <code>
/// &lt;prefix&gt;&lt;zero-padded index&gt;[_][&lt;time&gt;].h5
/// </code>
///
/// where the prefix is determined from the FileName property passed to
/// the reader. The underscore and time elements are optional. The time
/// value associated with each file is read from metadata in the file.
///
/// Parallel data loading is not supported.
/// </remarks>
public class vtkCONVERGECFDReader : vtkPartitionedDataSetCollectionAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCONVERGECFDReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCONVERGECFDReader()
	{
		MRClassNameKey = "class vtkCONVERGECFDReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCONVERGECFDReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCONVERGECFDReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCONVERGECFDReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCONVERGECFDReader New()
	{
		vtkCONVERGECFDReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCONVERGECFDReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCONVERGECFDReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCONVERGECFDReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCONVERGECFDReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCONVERGECFDReader_CanReadFile_01(HandleRef pThis, string fname);

	/// <summary>
	/// Determine if the file can be read with this reader.
	/// </summary>
	public virtual int CanReadFile(string fname)
	{
		return vtkCONVERGECFDReader_CanReadFile_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCONVERGECFDReader_GetCellDataArraySelection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the cell data array selection to specify which cell data arrays
	/// should be read. Only the specified cell data arrays will be read from the file.
	/// </summary>
	public virtual vtkDataArraySelection GetCellDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCONVERGECFDReader_GetCellDataArraySelection_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCONVERGECFDReader_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Specify file name of the Exodus file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkCONVERGECFDReader_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCONVERGECFDReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCONVERGECFDReader_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCONVERGECFDReader_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCONVERGECFDReader_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCONVERGECFDReader_GetParcelDataArraySelection_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the parcel data array selection to specify which point data arrays
	/// should be read and associated parcel. Only the specified parcel data arrays will
	/// be read from the file.
	/// </summary>
	public virtual vtkDataArraySelection GetParcelDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCONVERGECFDReader_GetParcelDataArraySelection_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCONVERGECFDReader_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCONVERGECFDReader_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCONVERGECFDReader_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCONVERGECFDReader_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCONVERGECFDReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCONVERGECFDReader NewInstance()
	{
		vtkCONVERGECFDReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCONVERGECFDReader_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCONVERGECFDReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCONVERGECFDReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCONVERGECFDReader SafeDownCast(vtkObjectBase o)
	{
		vtkCONVERGECFDReader vtkCONVERGECFDReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCONVERGECFDReader_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCONVERGECFDReader2 = (vtkCONVERGECFDReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCONVERGECFDReader2.Register(null);
			}
		}
		return vtkCONVERGECFDReader2;
	}

	[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCONVERGECFDReader_SetFileName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of the Exodus file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkCONVERGECFDReader_SetFileName_12(GetCppThis(), _arg);
	}
}
