using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMultiBlockDataSet
/// </summary>
/// <remarks>
///    Composite dataset that organizes datasets into
/// blocks.
///
/// vtkMultiBlockDataSet is a vtkCompositeDataSet that stores
/// a hierarchy of datasets. The dataset collection consists of
/// multiple blocks. Each block can itself be a vtkMultiBlockDataSet, thus
/// providing for a full tree structure.
/// Sub-blocks are usually used to distribute blocks across processors.
/// For example, a 1 block dataset can be distributed as following:
/// @verbatim
/// proc 0:
/// Block 0:
///   * ds 0
///   * (null)
///
/// proc 1:
/// Block 0:
///   * (null)
///   * ds 1
/// @endverbatim
/// </remarks>
public class vtkMultiBlockDataSet : vtkDataObjectTree
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMultiBlockDataSet()
	{
		MRClassNameKey = "class vtkMultiBlockDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMultiBlockDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiBlockDataSet New()
	{
		vtkMultiBlockDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMultiBlockDataSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMultiBlockDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockDataSet_GetBlock_01(HandleRef pThis, uint blockno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the block at the given index. It is recommended that one uses the
	/// iterators to iterate over composite datasets rather than using this API.
	/// </summary>
	public vtkDataObject GetBlock(uint blockno)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockDataSet_GetBlock_01(GetCppThis(), blockno, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObject2 = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObject2.Register(null);
			}
		}
		return vtkDataObject2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockDataSet_GetData_02(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkMultiBlockDataSet GetData(vtkInformation info)
	{
		vtkMultiBlockDataSet vtkMultiBlockDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockDataSet_GetData_02(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiBlockDataSet2 = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiBlockDataSet2.Register(null);
			}
		}
		return vtkMultiBlockDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockDataSet_GetData_03(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkMultiBlockDataSet GetData(vtkInformationVector v, int i)
	{
		vtkMultiBlockDataSet vtkMultiBlockDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockDataSet_GetData_03(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiBlockDataSet2 = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiBlockDataSet2.Register(null);
			}
		}
		return vtkMultiBlockDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockDataSet_GetDataObjectType_04(HandleRef pThis);

	/// <summary>
	/// Return class name of data type (see vtkType.h for
	/// definitions).
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkMultiBlockDataSet_GetDataObjectType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockDataSet_GetMetaData_05(HandleRef pThis, uint blockno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the meta-data for the block. If none is already present, a new
	/// vtkInformation object will be allocated. Use HasMetaData to avoid
	/// allocating vtkInformation objects.
	/// </summary>
	public vtkInformation GetMetaData(uint blockno)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockDataSet_GetMetaData_05(GetCppThis(), blockno, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockDataSet_GetMetaData_06(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Unhiding superclass method.
	/// </summary>
	public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockDataSet_GetMetaData_06(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformation2 = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformation2.Register(null);
			}
		}
		return vtkInformation2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkMultiBlockDataSet_GetNumberOfBlocks_07(HandleRef pThis);

	/// <summary>
	/// Returns the number of blocks.
	/// </summary>
	public uint GetNumberOfBlocks()
	{
		return vtkMultiBlockDataSet_GetNumberOfBlocks_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiBlockDataSet_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMultiBlockDataSet_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMultiBlockDataSet_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMultiBlockDataSet_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockDataSet_HasMetaData_10(HandleRef pThis, uint blockno);

	/// <summary>
	/// Returns true if meta-data is available for a given block.
	/// </summary>
	public int HasMetaData(uint blockno)
	{
		return vtkMultiBlockDataSet_HasMetaData_10(GetCppThis(), blockno);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockDataSet_HasMetaData_11(HandleRef pThis, HandleRef iter);

	/// <summary>
	/// Unhiding superclass method.
	/// </summary>
	public override int HasMetaData(vtkCompositeDataIterator iter)
	{
		return vtkMultiBlockDataSet_HasMetaData_11(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockDataSet_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMultiBlockDataSet_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMultiBlockDataSet_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMultiBlockDataSet_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockDataSet_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMultiBlockDataSet NewInstance()
	{
		vtkMultiBlockDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockDataSet_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockDataSet_RemoveBlock_16(HandleRef pThis, uint blockno);

	/// <summary>
	/// Remove the given block from the dataset.
	/// </summary>
	public void RemoveBlock(uint blockno)
	{
		vtkMultiBlockDataSet_RemoveBlock_16(GetCppThis(), blockno);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMultiBlockDataSet_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMultiBlockDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkMultiBlockDataSet vtkMultiBlockDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMultiBlockDataSet_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiBlockDataSet2 = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiBlockDataSet2.Register(null);
			}
		}
		return vtkMultiBlockDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockDataSet_SetBlock_18(HandleRef pThis, uint blockno, HandleRef block);

	/// <summary>
	/// Sets the data object as the given block. The total number of blocks will
	/// be resized to fit the requested block no.
	///
	/// @remark while most vtkDataObject subclasses, including vtkMultiBlockDataSet
	/// as acceptable as a block, `vtkPartitionedDataSet`,
	/// `vtkPartitionedDataSetCollection`, and `vtkUniformGridAMR`
	/// are not valid.
	/// </summary>
	public void SetBlock(uint blockno, vtkDataObject block)
	{
		vtkMultiBlockDataSet_SetBlock_18(GetCppThis(), blockno, block?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMultiBlockDataSet_SetNumberOfBlocks_19(HandleRef pThis, uint numBlocks);

	/// <summary>
	/// Set the number of blocks. This will cause allocation if the new number of
	/// blocks is greater than the current size. All new blocks are initialized to
	/// null.
	/// </summary>
	public void SetNumberOfBlocks(uint numBlocks)
	{
		vtkMultiBlockDataSet_SetNumberOfBlocks_19(GetCppThis(), numBlocks);
	}
}
