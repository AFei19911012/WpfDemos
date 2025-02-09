using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPartitionedDataSet
/// </summary>
/// <remarks>
///    composite dataset to encapsulates a dataset consisting of
/// partitions.
///
/// A vtkPartitionedDataSet dataset groups multiple datasets together.
/// For example, say a simulation running in parallel on 16 processes
/// generated 16 datasets that when considering together form a whole
/// dataset. These are referred to as the partitions of the whole dataset.
/// Now imagine that we want to load a volume of 16 partitions in a
/// visualization cluster of 4 nodes. Each node could get 4 partitions,
/// not necessarily forming a whole rectangular region. In this case,
/// it is not possible to append the 4 partitions together into a vtkImageData.
/// We can then collect these 4 partitions together using a
/// vtkPartitionedDataSet.
///
/// It is required that all non-empty partitions have the same arrays
/// and that they can be processed together as a whole by the same kind of
/// filter. However, it is not required that they are of the same type.
/// For example, it is possible to have structured datasets together with
/// unstructured datasets as long as they are compatible meshes (i.e. can
/// be processed together for the same kind of filter).
/// </remarks>
public class vtkPartitionedDataSet : vtkDataObjectTree
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPartitionedDataSet()
	{
		MRClassNameKey = "class vtkPartitionedDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPartitionedDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSet New()
	{
		vtkPartitionedDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPartitionedDataSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPartitionedDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPartitionedDataSet_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPartitionedDataSet GetData(vtkInformation info)
	{
		vtkPartitionedDataSet vtkPartitionedDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_GetData_01(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSet2 = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSet2.Register(null);
			}
		}
		return vtkPartitionedDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSet_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkPartitionedDataSet GetData(vtkInformationVector v, int i)
	{
		vtkPartitionedDataSet vtkPartitionedDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_GetData_02(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSet2 = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSet2.Register(null);
			}
		}
		return vtkPartitionedDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSet_GetDataObjectType_03(HandleRef pThis);

	/// <summary>
	/// Return class name of data type (see vtkType.h for
	/// definitions).
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkPartitionedDataSet_GetDataObjectType_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSet_GetMetaData_04(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the meta-data for the partition. If none is already present, a new
	/// vtkInformation object will be allocated. Use HasMetaData to avoid
	/// allocating vtkInformation objects.
	/// </summary>
	public vtkInformation GetMetaData(uint idx)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_GetMetaData_04(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPartitionedDataSet_GetMetaData_05(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Unhiding superclass method.
	/// </summary>
	public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_GetMetaData_05(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPartitionedDataSet_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPartitionedDataSet_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPartitionedDataSet_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPartitionedDataSet_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkPartitionedDataSet_GetNumberOfPartitions_08(HandleRef pThis);

	/// <summary>
	/// Returns the number of partitions.
	/// </summary>
	public uint GetNumberOfPartitions()
	{
		return vtkPartitionedDataSet_GetNumberOfPartitions_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSet_GetPartition_09(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the partition at the given index.
	/// </summary>
	public vtkDataSet GetPartition(uint idx)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_GetPartition_09(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSet_GetPartitionAsDataObject_10(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the partition at the given index.
	/// </summary>
	public vtkDataObject GetPartitionAsDataObject(uint idx)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_GetPartitionAsDataObject_10(GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPartitionedDataSet_HasMetaData_11(HandleRef pThis, uint idx);

	/// <summary>
	/// Returns true if meta-data is available for a given partition.
	/// </summary>
	public int HasMetaData(uint idx)
	{
		return vtkPartitionedDataSet_HasMetaData_11(GetCppThis(), idx);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSet_HasMetaData_12(HandleRef pThis, HandleRef iter);

	/// <summary>
	/// Unhiding superclass method.
	/// </summary>
	public override int HasMetaData(vtkCompositeDataIterator iter)
	{
		return vtkPartitionedDataSet_HasMetaData_12(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSet_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPartitionedDataSet_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPartitionedDataSet_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPartitionedDataSet_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSet_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPartitionedDataSet NewInstance()
	{
		vtkPartitionedDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSet_RemoveNullPartitions_17(HandleRef pThis);

	/// <summary>
	/// Removes all partitions that have null datasets and resizes the dataset.
	/// Note any meta data associated with the null datasets will get lost.
	/// </summary>
	public void RemoveNullPartitions()
	{
		vtkPartitionedDataSet_RemoveNullPartitions_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPartitionedDataSet_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPartitionedDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkPartitionedDataSet vtkPartitionedDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPartitionedDataSet_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPartitionedDataSet2 = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPartitionedDataSet2.Register(null);
			}
		}
		return vtkPartitionedDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSet_SetNumberOfPartitions_19(HandleRef pThis, uint numPartitions);

	/// <summary>
	/// Set the number of partitions. This will cause allocation if the new number of
	/// partitions is greater than the current size. All new partitions are initialized to
	/// null.
	/// </summary>
	public void SetNumberOfPartitions(uint numPartitions)
	{
		vtkPartitionedDataSet_SetNumberOfPartitions_19(GetCppThis(), numPartitions);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPartitionedDataSet_SetPartition_20(HandleRef pThis, uint idx, HandleRef partition);

	/// <summary>
	/// Sets the data object as the given partition. The total number of partitions will
	/// be resized to fit the requested partition no.
	/// </summary>
	public void SetPartition(uint idx, vtkDataObject partition)
	{
		vtkPartitionedDataSet_SetPartition_20(GetCppThis(), idx, partition?.GetCppThis() ?? default(HandleRef));
	}
}
