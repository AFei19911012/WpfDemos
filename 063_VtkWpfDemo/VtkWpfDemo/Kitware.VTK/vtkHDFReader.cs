using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHDFReader
/// </summary>
/// <remarks>
///    VTKHDF format reader.
///
/// </remarks>
public class vtkHDFReader : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHDFReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHDFReader()
	{
		MRClassNameKey = "class vtkHDFReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHDFReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHDFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHDFReader New()
	{
		vtkHDFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHDFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHDFReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHDFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHDFReader_CanReadFile_01(HandleRef pThis, string name);

	/// <summary>
	/// Test whether the file (type) with the given name can be read by this
	/// reader. If the file has a newer version than the reader, we still say
	/// we can read the file type and we fail later, when we try to read the file.
	/// This enables clients (ParaView) to distinguish between failures when we
	/// need to look for another reader and failures when we don't.
	/// </summary>
	public virtual int CanReadFile(string name)
	{
		return vtkHDFReader_CanReadFile_01(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_GetCellArrayName_02(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point or cell array with the given index in
	/// the input.
	/// </summary>
	public string GetCellArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkHDFReader_GetCellArrayName_02(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_GetCellDataArraySelection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetCellDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHDFReader_GetCellDataArraySelection_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_GetFieldDataArraySelection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetFieldDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHDFReader_GetFieldDataArraySelection_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_GetFileName_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the name of the input file.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkHDFReader_GetFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkHDFReader_GetMaximumLevelsToReadByDefaultForAMR_06(HandleRef pThis);

	/// <summary>
	/// Get the name of the point or cell array with the given index in
	/// the input.
	/// </summary>
	public virtual uint GetMaximumLevelsToReadByDefaultForAMR()
	{
		return vtkHDFReader_GetMaximumLevelsToReadByDefaultForAMR_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHDFReader_GetNumberOfCellArrays_07(HandleRef pThis);

	/// <summary>
	/// Get the number of point or cell arrays available in the input.
	/// </summary>
	public int GetNumberOfCellArrays()
	{
		return vtkHDFReader_GetNumberOfCellArrays_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHDFReader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHDFReader_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHDFReader_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHDFReader_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHDFReader_GetNumberOfPointArrays_10(HandleRef pThis);

	/// <summary>
	/// Get the number of point or cell arrays available in the input.
	/// </summary>
	public int GetNumberOfPointArrays()
	{
		return vtkHDFReader_GetNumberOfPointArrays_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_GetOutputAsDataSet_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a vtkDataSet pointer.
	/// </summary>
	public vtkDataSet GetOutputAsDataSet()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHDFReader_GetOutputAsDataSet_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_GetOutputAsDataSet_12(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output as a vtkDataSet pointer.
	/// </summary>
	public vtkDataSet GetOutputAsDataSet(int index)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHDFReader_GetOutputAsDataSet_12(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_GetPointArrayName_13(HandleRef pThis, int index);

	/// <summary>
	/// Get the name of the point or cell array with the given index in
	/// the input.
	/// </summary>
	public string GetPointArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkHDFReader_GetPointArrayName_13(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_GetPointDataArraySelection_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the data array selection tables used to configure which data
	/// arrays are loaded by the reader.
	/// </summary>
	public virtual vtkDataArraySelection GetPointDataArraySelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHDFReader_GetPointDataArraySelection_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHDFReader_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHDFReader_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHDFReader_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHDFReader_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHDFReader NewInstance()
	{
		vtkHDFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHDFReader_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHDFReader_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHDFReader SafeDownCast(vtkObjectBase o)
	{
		vtkHDFReader vtkHDFReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHDFReader_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHDFReader2 = (vtkHDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHDFReader2.Register(null);
			}
		}
		return vtkHDFReader2;
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHDFReader_SetFileName_20(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the name of the input file.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkHDFReader_SetFileName_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOHDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHDFReader_SetMaximumLevelsToReadByDefaultForAMR_21(HandleRef pThis, uint _arg);

	/// <summary>
	/// Get the name of the point or cell array with the given index in
	/// the input.
	/// </summary>
	public virtual void SetMaximumLevelsToReadByDefaultForAMR(uint _arg)
	{
		vtkHDFReader_SetMaximumLevelsToReadByDefaultForAMR_21(GetCppThis(), _arg);
	}
}
