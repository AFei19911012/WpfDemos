using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataObjectTreeIterator
/// </summary>
/// <remarks>
///    superclass for composite data iterators
///
/// vtkDataObjectTreeIterator provides an interface for accessing datasets
/// in a collection (vtkDataObjectTreeIterator).
/// </remarks>
public class vtkDataObjectTreeIterator : vtkCompositeDataIterator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectTreeIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataObjectTreeIterator()
	{
		MRClassNameKey = "class vtkDataObjectTreeIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectTreeIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataObjectTreeIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTreeIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectTreeIterator New()
	{
		vtkDataObjectTreeIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTreeIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectTreeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataObjectTreeIterator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataObjectTreeIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataObjectTreeIterator_GetCurrentDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the current item. Valid only when IsDoneWithTraversal() returns 0.
	/// </summary>
	public override vtkDataObject GetCurrentDataObject()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTreeIterator_GetCurrentDataObject_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkDataObjectTreeIterator_GetCurrentFlatIndex_02(HandleRef pThis);

	/// <summary>
	/// Flat index is an index obtained by traversing the tree in preorder.
	/// This can be used to uniquely identify nodes in the tree.
	/// Not valid if IsDoneWithTraversal() returns true.
	/// </summary>
	public override uint GetCurrentFlatIndex()
	{
		return vtkDataObjectTreeIterator_GetCurrentFlatIndex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTreeIterator_GetCurrentMetaData_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the meta-data associated with the current item.
	/// Note that, depending on iterator implementation, the returned information
	/// is not necessarily stored on the current object. So modifying the information
	/// is forbidden.
	/// </summary>
	public override vtkInformation GetCurrentMetaData()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTreeIterator_GetCurrentMetaData_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDataObjectTreeIterator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataObjectTreeIterator_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataObjectTreeIterator_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataObjectTreeIterator_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTreeIterator_GetTraverseSubTree_06(HandleRef pThis);

	/// <summary>
	/// If TraverseSubTree is set to true, the iterator will visit the entire tree
	/// structure, otherwise it only visits the first level children. Set to 1 by
	/// default.
	/// </summary>
	public virtual int GetTraverseSubTree()
	{
		return vtkDataObjectTreeIterator_GetTraverseSubTree_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTreeIterator_GetVisitOnlyLeaves_07(HandleRef pThis);

	/// <summary>
	/// If VisitOnlyLeaves is true, the iterator will only visit nodes
	/// (sub-datasets) that are not composite. If it encounters a composite
	/// data set, it will automatically traverse that composite dataset until
	/// it finds non-composite datasets. With this options, it is possible to
	/// visit all non-composite datasets in tree of composite datasets
	/// (composite of composite of composite for example :-) ) If
	/// VisitOnlyLeaves is false, GetCurrentDataObject() may return
	/// vtkCompositeDataSet. By default, VisitOnlyLeaves is 1.
	/// </summary>
	public virtual int GetVisitOnlyLeaves()
	{
		return vtkDataObjectTreeIterator_GetVisitOnlyLeaves_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTreeIterator_GoToFirstItem_08(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the beginning of the collection.
	/// </summary>
	public override void GoToFirstItem()
	{
		vtkDataObjectTreeIterator_GoToFirstItem_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTreeIterator_GoToNextItem_09(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the next item in the collection.
	/// </summary>
	public override void GoToNextItem()
	{
		vtkDataObjectTreeIterator_GoToNextItem_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTreeIterator_HasCurrentMetaData_10(HandleRef pThis);

	/// <summary>
	/// Returns if the a meta-data information object is present for the current
	/// item. Return 1 on success, 0 otherwise.
	/// </summary>
	public override int HasCurrentMetaData()
	{
		return vtkDataObjectTreeIterator_HasCurrentMetaData_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTreeIterator_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataObjectTreeIterator_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTreeIterator_IsDoneWithTraversal_12(HandleRef pThis);

	/// <summary>
	/// Test whether the iterator is finished with the traversal.
	/// Returns 1 for yes, and 0 for no.
	/// It is safe to call any of the GetCurrent...() methods only when
	/// IsDoneWithTraversal() returns 0.
	/// </summary>
	public override int IsDoneWithTraversal()
	{
		return vtkDataObjectTreeIterator_IsDoneWithTraversal_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataObjectTreeIterator_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataObjectTreeIterator_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTreeIterator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataObjectTreeIterator NewInstance()
	{
		vtkDataObjectTreeIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTreeIterator_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataObjectTreeIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataObjectTreeIterator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataObjectTreeIterator SafeDownCast(vtkObjectBase o)
	{
		vtkDataObjectTreeIterator vtkDataObjectTreeIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataObjectTreeIterator_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataObjectTreeIterator_SetTraverseSubTree_17(HandleRef pThis, int _arg);

	/// <summary>
	/// If TraverseSubTree is set to true, the iterator will visit the entire tree
	/// structure, otherwise it only visits the first level children. Set to 1 by
	/// default.
	/// </summary>
	public virtual void SetTraverseSubTree(int _arg)
	{
		vtkDataObjectTreeIterator_SetTraverseSubTree_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTreeIterator_SetVisitOnlyLeaves_18(HandleRef pThis, int _arg);

	/// <summary>
	/// If VisitOnlyLeaves is true, the iterator will only visit nodes
	/// (sub-datasets) that are not composite. If it encounters a composite
	/// data set, it will automatically traverse that composite dataset until
	/// it finds non-composite datasets. With this options, it is possible to
	/// visit all non-composite datasets in tree of composite datasets
	/// (composite of composite of composite for example :-) ) If
	/// VisitOnlyLeaves is false, GetCurrentDataObject() may return
	/// vtkCompositeDataSet. By default, VisitOnlyLeaves is 1.
	/// </summary>
	public virtual void SetVisitOnlyLeaves(int _arg)
	{
		vtkDataObjectTreeIterator_SetVisitOnlyLeaves_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTreeIterator_TraverseSubTreeOff_19(HandleRef pThis);

	/// <summary>
	/// If TraverseSubTree is set to true, the iterator will visit the entire tree
	/// structure, otherwise it only visits the first level children. Set to 1 by
	/// default.
	/// </summary>
	public virtual void TraverseSubTreeOff()
	{
		vtkDataObjectTreeIterator_TraverseSubTreeOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTreeIterator_TraverseSubTreeOn_20(HandleRef pThis);

	/// <summary>
	/// If TraverseSubTree is set to true, the iterator will visit the entire tree
	/// structure, otherwise it only visits the first level children. Set to 1 by
	/// default.
	/// </summary>
	public virtual void TraverseSubTreeOn()
	{
		vtkDataObjectTreeIterator_TraverseSubTreeOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTreeIterator_VisitOnlyLeavesOff_21(HandleRef pThis);

	/// <summary>
	/// If VisitOnlyLeaves is true, the iterator will only visit nodes
	/// (sub-datasets) that are not composite. If it encounters a composite
	/// data set, it will automatically traverse that composite dataset until
	/// it finds non-composite datasets. With this options, it is possible to
	/// visit all non-composite datasets in tree of composite datasets
	/// (composite of composite of composite for example :-) ) If
	/// VisitOnlyLeaves is false, GetCurrentDataObject() may return
	/// vtkCompositeDataSet. By default, VisitOnlyLeaves is 1.
	/// </summary>
	public virtual void VisitOnlyLeavesOff()
	{
		vtkDataObjectTreeIterator_VisitOnlyLeavesOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataObjectTreeIterator_VisitOnlyLeavesOn_22(HandleRef pThis);

	/// <summary>
	/// If VisitOnlyLeaves is true, the iterator will only visit nodes
	/// (sub-datasets) that are not composite. If it encounters a composite
	/// data set, it will automatically traverse that composite dataset until
	/// it finds non-composite datasets. With this options, it is possible to
	/// visit all non-composite datasets in tree of composite datasets
	/// (composite of composite of composite for example :-) ) If
	/// VisitOnlyLeaves is false, GetCurrentDataObject() may return
	/// vtkCompositeDataSet. By default, VisitOnlyLeaves is 1.
	/// </summary>
	public virtual void VisitOnlyLeavesOn()
	{
		vtkDataObjectTreeIterator_VisitOnlyLeavesOn_22(GetCppThis());
	}
}
