using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkCGNSFileSeriesReader
/// </summary>
/// <remarks>
///  Adds support for reading temporal or partitioned CGNS files.
///
/// vtkCGNSFileSeriesReader is a meta-reader that add support for reading
/// CGNS file series using vtkCGNSReader. We encounter two types of file series
/// with CGNS:
/// \li 1. temporal file series - where each file is simply a single timestep.
/// \li 2. partitioned file series - where each file corresponds to data dumped
///        out from a rank but has all timesteps.
///
///  vtkCGNSFileSeriesReader determines the nature of the file series
///  encountered and reads the files accordingly. For partitioned files, the
///  files are distributed among data-processing ranks, while for temporal file
///  series, blocks are distributed among data-processing ranks (using logic in
///  vtkCGNSReader itself).
///
/// </remarks>
/// <seealso>
///   vtkFileSeriesHelper
/// </seealso>
public class vtkCGNSFileSeriesReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCGNSFileSeriesReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCGNSFileSeriesReader()
	{
		MRClassNameKey = "class vtkCGNSFileSeriesReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCGNSFileSeriesReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCGNSFileSeriesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSFileSeriesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCGNSFileSeriesReader New()
	{
		vtkCGNSFileSeriesReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSFileSeriesReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCGNSFileSeriesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCGNSFileSeriesReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCGNSFileSeriesReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSFileSeriesReader_AddFileName_01(HandleRef pThis, string fname);

	/// <summary>
	/// Add/remove files names in the file series.
	/// </summary>
	public void AddFileName(string fname)
	{
		vtkCGNSFileSeriesReader_AddFileName_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSFileSeriesReader_CanReadFile_02(HandleRef pThis, string filename);

	/// <summary>
	/// Test a file for readability. Ensure that vtkCGNSFileSeriesReader::SetReader
	/// is called before using this method.
	/// </summary>
	public int CanReadFile(string filename)
	{
		return vtkCGNSFileSeriesReader_CanReadFile_02(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSFileSeriesReader_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSFileSeriesReader_GetController_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSFileSeriesReader_GetCurrentFileName_04(HandleRef pThis);

	/// <summary>
	/// Returns the filename being used for current timesteps.
	/// This is only reasonable for temporal file series. For a partitioned file
	/// series, this will return the filename being used on the current rank.
	/// </summary>
	public string GetCurrentFileName()
	{
		return Marshal.PtrToStringAnsi(vtkCGNSFileSeriesReader_GetCurrentFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCGNSFileSeriesReader_GetIgnoreReaderTime_05(HandleRef pThis);

	/// <summary>
	/// If true, then treat file series like it does not contain any time step
	/// values. False by default.
	/// </summary>
	public virtual bool GetIgnoreReaderTime()
	{
		return (vtkCGNSFileSeriesReader_GetIgnoreReaderTime_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCGNSFileSeriesReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCGNSFileSeriesReader_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCGNSFileSeriesReader_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCGNSFileSeriesReader_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSFileSeriesReader_GetReader_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the reader.
	/// </summary>
	public virtual vtkCGNSReader GetReader()
	{
		vtkCGNSReader vtkCGNSReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSFileSeriesReader_GetReader_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCGNSReader2 = (vtkCGNSReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCGNSReader2.Register(null);
			}
		}
		return vtkCGNSReader2;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSFileSeriesReader_IgnoreReaderTimeOff_09(HandleRef pThis);

	/// <summary>
	/// If true, then treat file series like it does not contain any time step
	/// values. False by default.
	/// </summary>
	public virtual void IgnoreReaderTimeOff()
	{
		vtkCGNSFileSeriesReader_IgnoreReaderTimeOff_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSFileSeriesReader_IgnoreReaderTimeOn_10(HandleRef pThis);

	/// <summary>
	/// If true, then treat file series like it does not contain any time step
	/// values. False by default.
	/// </summary>
	public virtual void IgnoreReaderTimeOn()
	{
		vtkCGNSFileSeriesReader_IgnoreReaderTimeOn_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSFileSeriesReader_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCGNSFileSeriesReader_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCGNSFileSeriesReader_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCGNSFileSeriesReader_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSFileSeriesReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCGNSFileSeriesReader NewInstance()
	{
		vtkCGNSFileSeriesReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSFileSeriesReader_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCGNSFileSeriesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSFileSeriesReader_RemoveAllFileNames_15(HandleRef pThis);

	/// <summary>
	/// Add/remove files names in the file series.
	/// </summary>
	public void RemoveAllFileNames()
	{
		vtkCGNSFileSeriesReader_RemoveAllFileNames_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCGNSFileSeriesReader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCGNSFileSeriesReader SafeDownCast(vtkObjectBase o)
	{
		vtkCGNSFileSeriesReader vtkCGNSFileSeriesReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCGNSFileSeriesReader_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCGNSFileSeriesReader2 = (vtkCGNSFileSeriesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCGNSFileSeriesReader2.Register(null);
			}
		}
		return vtkCGNSFileSeriesReader2;
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSFileSeriesReader_SetController_17(HandleRef pThis, HandleRef controller);

	/// <summary>
	/// Get/Set the controller.
	/// </summary>
	public void SetController(vtkMultiProcessController controller)
	{
		vtkCGNSFileSeriesReader_SetController_17(GetCppThis(), controller?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSFileSeriesReader_SetIgnoreReaderTime_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, then treat file series like it does not contain any time step
	/// values. False by default.
	/// </summary>
	public virtual void SetIgnoreReaderTime(bool _arg)
	{
		vtkCGNSFileSeriesReader_SetIgnoreReaderTime_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCGNSFileSeriesReader_SetReader_19(HandleRef pThis, HandleRef reader);

	/// <summary>
	/// Get/Set the reader.
	/// </summary>
	public virtual void SetReader(vtkCGNSReader reader)
	{
		vtkCGNSFileSeriesReader_SetReader_19(GetCppThis(), reader?.GetCppThis() ?? default(HandleRef));
	}
}
