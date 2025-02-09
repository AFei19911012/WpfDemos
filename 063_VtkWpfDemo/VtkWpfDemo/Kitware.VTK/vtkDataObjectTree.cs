using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataObjectTree
/// </summary>
/// <remarks>
///    provides implementation for most abstract
/// methods in the superclass vtkCompositeDataSet
///
/// vtkDataObjectTree is represents a collection
/// of datasets (including other composite datasets). It
/// provides an interface to access the datasets through iterators.
/// vtkDataObjectTree provides methods that are used by subclasses to store the
/// datasets.
/// vtkDataObjectTree provides the datastructure for a full tree
/// representation. Subclasses provide the semantics for it and control how
/// this tree is built.
///
/// </remarks>
/// <seealso>
///
/// vtkDataObjectTreeIterator
/// </seealso>
public class vtkDataObjectTree : vtkCompositeDataSet
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectTree";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataObjectTree()
	{
		MRClassNameKey = "class vtkDataObjectTree";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectTree"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataObjectTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTree_CopyStructure_01(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Copies the tree structure from the input. All pointers to non-composite
	/// data objects are initialized to nullptr. This also shallow copies the meta data
	/// associated with all the nodes.
	/// </summary>
	public override void CopyStructure(vtkCompositeDataSet input)
	{
		vtkDataObjectTree_CopyStructure_01(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTree_DeepCopy_02(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkDataObjectTree_DeepCopy_02(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDataObjectTree_GetActualMemorySize_03(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkDataObjectTree_GetActualMemorySize_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTree_GetData_04(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkDataObjectTree GetData(vtkInformation info)
	{
		vtkDataObjectTree vtkDataObjectTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTree_GetData_04(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObjectTree2 = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObjectTree2.Register(null);
			}
		}
		return vtkDataObjectTree2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTree_GetData_05(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkDataObjectTree GetData(vtkInformationVector v, int i)
	{
		vtkDataObjectTree vtkDataObjectTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTree_GetData_05(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObjectTree2 = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObjectTree2.Register(null);
			}
		}
		return vtkDataObjectTree2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTree_GetDataObjectType_06(HandleRef pThis);

	/// <summary>
	/// Overridden to return `VTK_DATA_OBJECT_TREE`.
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkDataObjectTree_GetDataObjectType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTree_GetDataSet_07(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the dataset located at the position pointed by the iterator.
	/// The iterator does not need to be iterating over this dataset itself. It can
	/// be an iterator for composite dataset with similar structure (achieved by
	/// using CopyStructure).
	/// </summary>
	public override vtkDataObject GetDataSet(vtkCompositeDataIterator iter)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTree_GetDataSet_07(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObjectTree_GetMetaData_08(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the meta-data associated with the position pointed by the iterator.
	/// This will create a new vtkInformation object if none already exists. Use
	/// HasMetaData to avoid creating the vtkInformation object unnecessarily.
	/// The iterator does not need to be iterating over this dataset itself. It can
	/// be an iterator for composite dataset with similar structure (achieved by
	/// using CopyStructure).
	/// </summary>
	public virtual vtkInformation GetMetaData(vtkCompositeDataIterator iter)
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTree_GetMetaData_08(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDataObjectTree_GetNumberOfCells_09(HandleRef pThis);

	/// <summary>
	/// Returns the total number of cells of all blocks. This will
	/// iterate over all blocks and call GetNumberOfPoints() so it
	/// might be expensive.
	/// </summary>
	public override long GetNumberOfCells()
	{
		return vtkDataObjectTree_GetNumberOfCells_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectTree_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataObjectTree_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectTree_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataObjectTree_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectTree_GetNumberOfPoints_12(HandleRef pThis);

	/// <summary>
	/// Returns the total number of points of all blocks. This will
	/// iterate over all blocks and call GetNumberOfPoints() so it
	/// might be expansive.
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkDataObjectTree_GetNumberOfPoints_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTree_HasMetaData_13(HandleRef pThis, HandleRef iter);

	/// <summary>
	/// Returns if any meta-data associated with the position pointed by the iterator.
	/// The iterator does not need to be iterating over this dataset itself. It can
	/// be an iterator for composite dataset with similar structure (achieved by
	/// using CopyStructure).
	/// </summary>
	public virtual int HasMetaData(vtkCompositeDataIterator iter)
	{
		return vtkDataObjectTree_HasMetaData_13(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTree_Initialize_14(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state,
	/// </summary>
	public override void Initialize()
	{
		vtkDataObjectTree_Initialize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTree_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataObjectTree_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTree_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataObjectTree_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTree_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataObjectTree NewInstance()
	{
		vtkDataObjectTree result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTree_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTree_NewIterator_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a new iterator (the iterator has to be deleted by user).
	///
	/// Use NewTreeIterator when you have a pointer to a vtkDataObjectTree
	/// and NewIterator when you have a pointer to a vtkCompositeDataSet;
	/// NewIterator is inherited and calls NewTreeIterator internally.
	/// </summary>
	public override vtkCompositeDataIterator NewIterator()
	{
		vtkCompositeDataIterator vtkCompositeDataIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTree_NewIterator_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataIterator2 = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataIterator2.Register(null);
			}
		}
		return vtkCompositeDataIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTree_NewTreeIterator_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a new iterator (the iterator has to be deleted by user).
	/// </summary>
	public virtual vtkDataObjectTreeIterator NewTreeIterator()
	{
		vtkDataObjectTreeIterator vtkDataObjectTreeIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTree_NewTreeIterator_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObjectTreeIterator2 = (vtkDataObjectTreeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObjectTreeIterator2.Register(null);
			}
		}
		return vtkDataObjectTreeIterator2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTree_RecursiveShallowCopy_20(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void RecursiveShallowCopy(vtkDataObject src)
	{
		vtkDataObjectTree_RecursiveShallowCopy_20(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTree_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectTree SafeDownCast(vtkObjectBase o)
	{
		vtkDataObjectTree vtkDataObjectTree2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTree_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataObjectTree2 = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataObjectTree2.Register(null);
			}
		}
		return vtkDataObjectTree2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTree_SetDataSet_22(HandleRef pThis, HandleRef iter, HandleRef dataObj);

	/// <summary>
	/// Sets the data set at the location pointed by the iterator.
	/// The iterator does not need to be iterating over this dataset itself. It can
	/// be any composite datasite with similar structure (achieved by using
	/// CopyStructure).
	/// </summary>
	public override void SetDataSet(vtkCompositeDataIterator iter, vtkDataObject dataObj)
	{
		vtkDataObjectTree_SetDataSet_22(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), dataObj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTree_SetDataSetFrom_23(HandleRef pThis, HandleRef iter, HandleRef dataObj);

	/// <summary>
	/// Sets the data at the location provided by a vtkDataObjectTreeIterator
	/// </summary>
	public void SetDataSetFrom(vtkDataObjectTreeIterator iter, vtkDataObject dataObj)
	{
		vtkDataObjectTree_SetDataSetFrom_23(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), dataObj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTree_ShallowCopy_24(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkDataObjectTree_ShallowCopy_24(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}
}
