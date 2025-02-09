using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositeDataIterator
/// </summary>
/// <remarks>
///    superclass for composite data iterators
///
/// vtkCompositeDataIterator provides an interface for accessing datasets
/// in a collection (vtkCompositeDataIterator).
/// </remarks>
public abstract class vtkCompositeDataIterator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeDataIterator()
	{
		MRClassNameKey = "class vtkCompositeDataIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkCompositeDataIterator_GetCurrentDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the current item. Valid only when IsDoneWithTraversal() returns 0.
	/// </summary>
	public virtual vtkDataObject GetCurrentDataObject()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataIterator_GetCurrentDataObject_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkCompositeDataIterator_GetCurrentFlatIndex_02(HandleRef pThis);

	/// <summary>
	/// Flat index is an index to identify the data in a composite data structure
	/// </summary>
	public virtual uint GetCurrentFlatIndex()
	{
		return vtkCompositeDataIterator_GetCurrentFlatIndex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataIterator_GetCurrentMetaData_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the meta-data associated with the current item. This will allocate
	/// a new vtkInformation object is none is already present. Use
	/// HasCurrentMetaData to avoid unnecessary creation of vtkInformation objects.
	/// </summary>
	public virtual vtkInformation GetCurrentMetaData()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataIterator_GetCurrentMetaData_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCompositeDataIterator_GetDataSet_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the composite dataset this iterator is iterating over.
	/// Must be set before traversal begins.
	/// </summary>
	public virtual vtkCompositeDataSet GetDataSet()
	{
		vtkCompositeDataSet vtkCompositeDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataIterator_GetDataSet_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCompositeDataIterator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeDataIterator_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataIterator_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeDataIterator_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataIterator_GetReverse_07(HandleRef pThis);

	/// <summary>
	/// Returns if the iteration is in reverse order.
	/// </summary>
	public virtual int GetReverse()
	{
		return vtkCompositeDataIterator_GetReverse_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataIterator_GetSkipEmptyNodes_08(HandleRef pThis);

	/// <summary>
	/// If SkipEmptyNodes is true, then nullptr datasets will be skipped. Default is
	/// true.
	/// </summary>
	public virtual int GetSkipEmptyNodes()
	{
		return vtkCompositeDataIterator_GetSkipEmptyNodes_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataIterator_GoToFirstItem_09(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the beginning of the collection.
	/// </summary>
	public virtual void GoToFirstItem()
	{
		vtkCompositeDataIterator_GoToFirstItem_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataIterator_GoToNextItem_10(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the next item in the collection.
	/// </summary>
	public virtual void GoToNextItem()
	{
		vtkCompositeDataIterator_GoToNextItem_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataIterator_HasCurrentMetaData_11(HandleRef pThis);

	/// <summary>
	/// Returns if the a meta-data information object is present for the current
	/// item. Return 1 on success, 0 otherwise.
	/// </summary>
	public virtual int HasCurrentMetaData()
	{
		return vtkCompositeDataIterator_HasCurrentMetaData_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataIterator_InitReverseTraversal_12(HandleRef pThis);

	/// <summary>
	/// Begin iterating over the composite dataset structure in reverse order.
	/// </summary>
	public virtual void InitReverseTraversal()
	{
		vtkCompositeDataIterator_InitReverseTraversal_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataIterator_InitTraversal_13(HandleRef pThis);

	/// <summary>
	/// Begin iterating over the composite dataset structure.
	/// </summary>
	public virtual void InitTraversal()
	{
		vtkCompositeDataIterator_InitTraversal_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataIterator_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeDataIterator_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataIterator_IsDoneWithTraversal_15(HandleRef pThis);

	/// <summary>
	/// Test whether the iterator is finished with the traversal.
	/// Returns 1 for yes, and 0 for no.
	/// It is safe to call any of the GetCurrent...() methods only when
	/// IsDoneWithTraversal() returns 0.
	/// </summary>
	public virtual int IsDoneWithTraversal()
	{
		return vtkCompositeDataIterator_IsDoneWithTraversal_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataIterator_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeDataIterator_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataIterator_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositeDataIterator NewInstance()
	{
		vtkCompositeDataIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataIterator_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataIterator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataIterator SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeDataIterator vtkCompositeDataIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataIterator_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCompositeDataIterator_SetDataSet_19(HandleRef pThis, HandleRef ds);

	/// <summary>
	/// Set the composite dataset this iterator is iterating over.
	/// Must be set before traversal begins.
	/// </summary>
	public virtual void SetDataSet(vtkCompositeDataSet ds)
	{
		vtkCompositeDataIterator_SetDataSet_19(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataIterator_SetSkipEmptyNodes_20(HandleRef pThis, int _arg);

	/// <summary>
	/// If SkipEmptyNodes is true, then nullptr datasets will be skipped. Default is
	/// true.
	/// </summary>
	public virtual void SetSkipEmptyNodes(int _arg)
	{
		vtkCompositeDataIterator_SetSkipEmptyNodes_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataIterator_SkipEmptyNodesOff_21(HandleRef pThis);

	/// <summary>
	/// If SkipEmptyNodes is true, then nullptr datasets will be skipped. Default is
	/// true.
	/// </summary>
	public virtual void SkipEmptyNodesOff()
	{
		vtkCompositeDataIterator_SkipEmptyNodesOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataIterator_SkipEmptyNodesOn_22(HandleRef pThis);

	/// <summary>
	/// If SkipEmptyNodes is true, then nullptr datasets will be skipped. Default is
	/// true.
	/// </summary>
	public virtual void SkipEmptyNodesOn()
	{
		vtkCompositeDataIterator_SkipEmptyNodesOn_22(GetCppThis());
	}
}
