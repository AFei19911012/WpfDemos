using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositeDataSet
/// </summary>
/// <remarks>
///    abstract superclass for composite
/// (multi-block or AMR) datasets
///
/// vtkCompositeDataSet is an abstract class that represents a collection
/// of datasets (including other composite datasets). It
/// provides an interface to access the datasets through iterators.
/// vtkCompositeDataSet provides methods that are used by subclasses to store the
/// datasets.
/// vtkCompositeDataSet provides the datastructure for a full tree
/// representation. Subclasses provide the semantics for it and control how
/// this tree is built.
///
/// </remarks>
/// <seealso>
///
/// vtkCompositeDataIterator
/// </seealso>
public abstract class vtkCompositeDataSet : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeDataSet()
	{
		MRClassNameKey = "class vtkCompositeDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkCompositeDataSet_CURRENT_PROCESS_CAN_LOAD_BLOCK_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key used to indicate that the current process can load the data
	/// in the node.  Used for parallel readers where the nodes are assigned
	/// to the processes by the reader to indicate further down the pipeline
	/// which nodes will be on which processes.
	/// ***THIS IS AN EXPERIMENTAL KEY SUBJECT TO CHANGE WITHOUT NOTICE***
	/// </summary>
	public static vtkInformationIntegerKey CURRENT_PROCESS_CAN_LOAD_BLOCK()
	{
		vtkInformationIntegerKey vtkInformationIntegerKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_CURRENT_PROCESS_CAN_LOAD_BLOCK_01(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationIntegerKey2 = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationIntegerKey2.Register(null);
			}
		}
		return vtkInformationIntegerKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataSet_CopyStructure_02(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Copies the tree structure from the input. All pointers to non-composite
	/// data objects are initialized to nullptr. This also shallow copies the meta data
	/// associated with all the nodes.
	/// </summary>
	public virtual void CopyStructure(vtkCompositeDataSet input)
	{
		vtkCompositeDataSet_CopyStructure_02(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataSet_DeepCopy_03(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void DeepCopy(vtkDataObject src)
	{
		vtkCompositeDataSet_DeepCopy_03(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkCompositeDataSet_GetActualMemorySize_04(HandleRef pThis);

	/// <summary>
	/// Return the actual size of the data in kibibytes (1024 bytes). This number
	/// is valid only after the pipeline has updated.
	/// </summary>
	public override uint GetActualMemorySize()
	{
		return vtkCompositeDataSet_GetActualMemorySize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataSet_GetBounds_05(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Return the geometric bounding box in the form (xmin,xmax, ymin,ymax,
	/// zmin,zmax).  Note that if the composite dataset contains abstract types
	/// (i.e., non vtkDataSet types) such as tables these will be ignored by the
	/// method. In cases where no vtkDataSet is contained in the composite
	/// dataset then the returned bounds will be undefined. THIS METHOD IS
	/// THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND THE DATASET IS NOT
	/// MODIFIED.
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkCompositeDataSet_GetBounds_05(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataSet_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkCompositeDataSet GetData(vtkInformation info)
	{
		vtkCompositeDataSet vtkCompositeDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_GetData_06(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataSet2 = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataSet2.Register(null);
			}
		}
		return vtkCompositeDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataSet_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkCompositeDataSet GetData(vtkInformationVector v, int i)
	{
		vtkCompositeDataSet vtkCompositeDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_GetData_07(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataSet2 = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataSet2.Register(null);
			}
		}
		return vtkCompositeDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataSet_GetDataObjectType_08(HandleRef pThis);

	/// <summary>
	/// Return class name of data type (see vtkType.h for
	/// definitions).
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkCompositeDataSet_GetDataObjectType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataSet_GetDataSet_09(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the dataset located at the position pointed by the iterator.
	/// The iterator does not need to be iterating over this dataset itself. It can
	/// be an iterator for composite dataset with similar structure (achieved by
	/// using CopyStructure).
	/// </summary>
	public virtual vtkDataObject GetDataSet(vtkCompositeDataIterator iter)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_GetDataSet_09(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCompositeDataSet_GetDataSet_10(HandleRef pThis, uint flatIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the dataset located at the position pointed by the flatIndex.
	/// If no dataset has the same flat index, nullptr is returned.
	///
	/// It should be noted that this function should be used ONLY when you already know the flat index.
	/// It should NOT be used when you are iterating over the composite dataset (in that case, prefer
	/// the vtkCompositeDataIterator).
	/// </summary>
	public virtual vtkDataObject GetDataSet(uint flatIndex)
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_GetDataSet_10(GetCppThis(), flatIndex, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCompositeDataSet_GetNumberOfCells_11(HandleRef pThis);

	/// <summary>
	/// Returns the total number of cells of all blocks. This will
	/// iterate over all blocks and call GetNumberOfPoints() so it
	/// might be expensive.
	/// </summary>
	public virtual long GetNumberOfCells()
	{
		return vtkCompositeDataSet_GetNumberOfCells_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataSet_GetNumberOfElements_12(HandleRef pThis, int type);

	/// <summary>
	/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
	/// </summary>
	public override long GetNumberOfElements(int type)
	{
		return vtkCompositeDataSet_GetNumberOfElements_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataSet_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeDataSet_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataSet_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeDataSet_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataSet_GetNumberOfPoints_15(HandleRef pThis);

	/// <summary>
	/// Returns the total number of points of all blocks. This will
	/// iterate over all blocks and call GetNumberOfPoints() so it
	/// might be expensive.
	/// </summary>
	public virtual long GetNumberOfPoints()
	{
		return vtkCompositeDataSet_GetNumberOfPoints_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataSet_Initialize_16(HandleRef pThis);

	/// <summary>
	/// Restore data object to initial state,
	/// </summary>
	public override void Initialize()
	{
		vtkCompositeDataSet_Initialize_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataSet_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeDataSet_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataSet_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeDataSet_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataSet_NAME_19(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Key used to put node name in the meta-data associated with a node.
	/// </summary>
	public static vtkInformationStringKey NAME()
	{
		vtkInformationStringKey vtkInformationStringKey2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_NAME_19(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkInformationStringKey2 = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkInformationStringKey2.Register(null);
			}
		}
		return vtkInformationStringKey2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataSet_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositeDataSet NewInstance()
	{
		vtkCompositeDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataSet_NewIterator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a new iterator (the iterator has to be deleted by user).
	/// </summary>
	public virtual vtkCompositeDataIterator NewIterator()
	{
		vtkCompositeDataIterator vtkCompositeDataIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_NewIterator_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCompositeDataSet_RecursiveShallowCopy_22(HandleRef pThis, HandleRef src);

	/// <summary>
	/// For historical reasons, `vtkCompositeDataSet::ShallowCopy` simply pass
	/// pointers to the leaf non-composite datasets. In some cases, we truly want
	/// to shallow copy those leaf non-composite datasets as well. For those cases,
	/// use this method.
	/// </summary>
	public virtual void RecursiveShallowCopy(vtkDataObject src)
	{
		vtkCompositeDataSet_RecursiveShallowCopy_22(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataSet_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeDataSet vtkCompositeDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataSet_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataSet2 = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataSet2.Register(null);
			}
		}
		return vtkCompositeDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataSet_SetDataSet_24(HandleRef pThis, HandleRef iter, HandleRef dataObj);

	/// <summary>
	/// Sets the data set at the location pointed by the iterator.
	/// The iterator does not need to be iterating over this dataset itself. It can
	/// be any composite dataset with similar structure (achieved by using
	/// CopyStructure).
	/// </summary>
	public virtual void SetDataSet(vtkCompositeDataIterator iter, vtkDataObject dataObj)
	{
		vtkCompositeDataSet_SetDataSet_24(GetCppThis(), iter?.GetCppThis() ?? default(HandleRef), dataObj?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataSet_ShallowCopy_25(HandleRef pThis, HandleRef src);

	/// <summary>
	/// Shallow and Deep copy.
	/// </summary>
	public override void ShallowCopy(vtkDataObject src)
	{
		vtkCompositeDataSet_ShallowCopy_25(GetCppThis(), src?.GetCppThis() ?? default(HandleRef));
	}
}
