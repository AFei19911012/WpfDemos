using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRDataSetCache
///
///
///  A concrete implementation of vtkObject that provides functionality for
///  caching AMR blocks. The primary intent of this class is to be used by the
///  AMR reader infrastructure for caching blocks/data in memory to minimize
///  out-of-core operations.
/// </summary>
public class vtkAMRDataSetCache : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRDataSetCache";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRDataSetCache()
	{
		MRClassNameKey = "class vtkAMRDataSetCache";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRDataSetCache"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRDataSetCache(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRDataSetCache_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRDataSetCache New()
	{
		vtkAMRDataSetCache result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRDataSetCache_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAMRDataSetCache()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAMRDataSetCache_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRDataSetCache_GetAMRBlock_01(HandleRef pThis, int compositeIdx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given the composite index, this method returns the AMR block.
	/// NOTE: Null is returned if the AMR block does not exist in the cache.
	/// </summary>
	public vtkUniformGrid GetAMRBlock(int compositeIdx)
	{
		vtkUniformGrid vtkUniformGrid2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRDataSetCache_GetAMRBlock_01(GetCppThis(), compositeIdx, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGrid2 = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGrid2.Register(null);
			}
		}
		return vtkUniformGrid2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRDataSetCache_GetAMRBlockCellData_02(HandleRef pThis, int compositeIdx, string dataName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given the name of the cell array and AMR block composite index, this
	/// method returns a pointer to the cell data array.
	/// NOTE: Null is returned if the cell array and/or block is not cached.
	/// </summary>
	public vtkDataArray GetAMRBlockCellData(int compositeIdx, string dataName)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRDataSetCache_GetAMRBlockCellData_02(GetCppThis(), compositeIdx, dataName, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRDataSetCache_GetAMRBlockPointData_03(HandleRef pThis, int compositeIdx, string dataName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given the name of the point array and AMR block composite index, this
	/// method returns a pointer to the point data array.
	/// NOTE: Null is returned if the point array and /or block is not cached.
	/// </summary>
	public vtkDataArray GetAMRBlockPointData(int compositeIdx, string dataName)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRDataSetCache_GetAMRBlockPointData_03(GetCppThis(), compositeIdx, dataName, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRDataSetCache_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRDataSetCache_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRDataSetCache_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRDataSetCache_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRDataSetCache_HasAMRBlock_06(HandleRef pThis, int compositeIdx);

	/// <summary>
	/// Checks if the AMR block associated with the given composite is cached.
	/// </summary>
	public bool HasAMRBlock(int compositeIdx)
	{
		return (vtkAMRDataSetCache_HasAMRBlock_06(GetCppThis(), compositeIdx) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRDataSetCache_HasAMRBlockCellData_07(HandleRef pThis, int compositeIdx, string name);

	/// <summary>
	/// Checks if the cell data array, associated with the provided name, has
	/// been cached for the AMR block with the given composite index.
	/// </summary>
	public bool HasAMRBlockCellData(int compositeIdx, string name)
	{
		return (vtkAMRDataSetCache_HasAMRBlockCellData_07(GetCppThis(), compositeIdx, name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkAMRDataSetCache_HasAMRBlockPointData_08(HandleRef pThis, int compositeIdx, string name);

	/// <summary>
	/// Checks if the point data array, associated with the provided name, has
	/// been cached for the AMR block with the given composite index.
	/// </summary>
	public bool HasAMRBlockPointData(int compositeIdx, string name)
	{
		return (vtkAMRDataSetCache_HasAMRBlockPointData_08(GetCppThis(), compositeIdx, name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRDataSetCache_InsertAMRBlock_09(HandleRef pThis, int compositeIdx, HandleRef amrGrid);

	/// <summary>
	/// Inserts an AMR block to the cache
	/// </summary>
	public void InsertAMRBlock(int compositeIdx, vtkUniformGrid amrGrid)
	{
		vtkAMRDataSetCache_InsertAMRBlock_09(GetCppThis(), compositeIdx, amrGrid?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRDataSetCache_InsertAMRBlockCellData_10(HandleRef pThis, int compositeIdx, HandleRef dataArray);

	/// <summary>
	/// Inserts a cell data array to an already cached block
	/// NOTE: this-&gt;HasAMRBlock( compositeIdx ) == true
	/// </summary>
	public void InsertAMRBlockCellData(int compositeIdx, vtkDataArray dataArray)
	{
		vtkAMRDataSetCache_InsertAMRBlockCellData_10(GetCppThis(), compositeIdx, dataArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRDataSetCache_InsertAMRBlockPointData_11(HandleRef pThis, int compositeIdx, HandleRef dataArray);

	/// <summary>
	/// Inserts a point data array to an already cached block
	/// NOTE: this-&gt;HasAMRBlock( compositeIdx ) == true
	/// </summary>
	public void InsertAMRBlockPointData(int compositeIdx, vtkDataArray dataArray)
	{
		vtkAMRDataSetCache_InsertAMRBlockPointData_11(GetCppThis(), compositeIdx, dataArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRDataSetCache_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRDataSetCache_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRDataSetCache_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRDataSetCache_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRDataSetCache_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRDataSetCache NewInstance()
	{
		vtkAMRDataSetCache result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRDataSetCache_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRDataSetCache_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRDataSetCache SafeDownCast(vtkObjectBase o)
	{
		vtkAMRDataSetCache vtkAMRDataSetCache2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRDataSetCache_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRDataSetCache2 = (vtkAMRDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRDataSetCache2.Register(null);
			}
		}
		return vtkAMRDataSetCache2;
	}
}
