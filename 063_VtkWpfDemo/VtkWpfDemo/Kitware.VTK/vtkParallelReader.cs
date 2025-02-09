using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParallelReader
/// </summary>
/// <remarks>
///    Superclass for algorithms that are parallel aware
///
/// vtkParallelReader is a vtkReaderAlgorithm subclass that provides
/// a specialized API to develop readers that are parallel aware (i.e.
/// can handle piece requests) but do not natively support time series.
/// This reader adds support for file series in order to support time
/// series.
/// </remarks>
public abstract class vtkParallelReader : vtkReaderAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParallelReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParallelReader()
	{
		MRClassNameKey = "class vtkParallelReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParallelReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelReader_AddFileName_01(HandleRef pThis, string fname);

	/// <summary>
	/// Add a filename to be read. Since this superclass handles
	/// file series to support time, multiple filenames can be added.
	/// Note that the time values are either integers growing sequentially,
	/// or are obtained from individual files as supported by the subclass.
	/// </summary>
	public void AddFileName(string fname)
	{
		vtkParallelReader_AddFileName_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParallelReader_ClearFileNames_02(HandleRef pThis);

	/// <summary>
	/// Removes all filenames stored by the reader.
	/// </summary>
	public void ClearFileNames()
	{
		vtkParallelReader_ClearFileNames_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelReader_GetCurrentFileName_03(HandleRef pThis);

	/// <summary>
	/// Returns the filename that was last loaded by the reader.
	/// This is set internally in ReadMesh()
	/// </summary>
	public string GetCurrentFileName()
	{
		return Marshal.PtrToStringAnsi(vtkParallelReader_GetCurrentFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelReader_GetFileName_04(HandleRef pThis, int i);

	/// <summary>
	/// Returns a particular filename stored by the reader.
	/// </summary>
	public string GetFileName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkParallelReader_GetFileName_04(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelReader_GetNumberOfFileNames_05(HandleRef pThis);

	/// <summary>
	/// Returns the number of filenames stored by the reader.
	/// </summary>
	public int GetNumberOfFileNames()
	{
		return vtkParallelReader_GetNumberOfFileNames_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParallelReader_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParallelReader_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParallelReader_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelReader_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParallelReader_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelReader_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParallelReader_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParallelReader NewInstance()
	{
		vtkParallelReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelReader_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParallelReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelReader_ReadArrays_11(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkParallelReader_ReadArrays_11(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelReader_ReadMesh_12(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkParallelReader_ReadMesh_12(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelReader_ReadMetaData_13(HandleRef pThis, HandleRef metadata);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadMetaData(vtkInformation metadata)
	{
		return vtkParallelReader_ReadMetaData_13(GetCppThis(), metadata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParallelReader_ReadPoints_14(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// This is the superclass API overridden by this class
	/// to provide time support internally. Subclasses should
	/// not normally have to override these methods.
	/// </summary>
	public override int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkParallelReader_ReadPoints_14(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParallelReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParallelReader SafeDownCast(vtkObjectBase o)
	{
		vtkParallelReader vtkParallelReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParallelReader_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParallelReader2 = (vtkParallelReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParallelReader2.Register(null);
			}
		}
		return vtkParallelReader2;
	}
}
