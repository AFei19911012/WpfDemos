using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUniformGridAMRDataIterator
/// </summary>
/// <remarks>
///    subclass of vtkCompositeDataIterator
/// with API to get current level and dataset index.
///
/// </remarks>
public class vtkUniformGridAMRDataIterator : vtkCompositeDataIterator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGridAMRDataIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUniformGridAMRDataIterator()
	{
		MRClassNameKey = "class vtkUniformGridAMRDataIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGridAMRDataIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUniformGridAMRDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMRDataIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUniformGridAMRDataIterator New()
	{
		vtkUniformGridAMRDataIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMRDataIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniformGridAMRDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUniformGridAMRDataIterator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUniformGridAMRDataIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkUniformGridAMRDataIterator_GetCurrentDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the current item. Valid only when IsDoneWithTraversal() returns 0.
	/// </summary>
	public override vtkDataObject GetCurrentDataObject()
	{
		vtkDataObject vtkDataObject2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMRDataIterator_GetCurrentDataObject_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern uint vtkUniformGridAMRDataIterator_GetCurrentFlatIndex_02(HandleRef pThis);

	/// <summary>
	/// Flat index is an index obtained by traversing the tree in preorder.
	/// This can be used to uniquely identify nodes in the tree.
	/// Not valid if IsDoneWithTraversal() returns true.
	/// </summary>
	public override uint GetCurrentFlatIndex()
	{
		return vtkUniformGridAMRDataIterator_GetCurrentFlatIndex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkUniformGridAMRDataIterator_GetCurrentIndex_03(HandleRef pThis);

	/// <summary>
	/// Returns the dataset index for the current data object. Valid only if the
	/// current data is a leaf node i.e. no a composite dataset.
	/// </summary>
	public virtual uint GetCurrentIndex()
	{
		return vtkUniformGridAMRDataIterator_GetCurrentIndex_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkUniformGridAMRDataIterator_GetCurrentLevel_04(HandleRef pThis);

	/// <summary>
	/// Returns the level for the current dataset.
	/// </summary>
	public virtual uint GetCurrentLevel()
	{
		return vtkUniformGridAMRDataIterator_GetCurrentLevel_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMRDataIterator_GetCurrentMetaData_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the meta-data associated with the current item.
	/// Note that this points to a single instance of vtkInformation object
	/// allocated by the iterator and will be changed as soon as GoToNextItem is
	/// called.
	/// </summary>
	public override vtkInformation GetCurrentMetaData()
	{
		vtkInformation vtkInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMRDataIterator_GetCurrentMetaData_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkUniformGridAMRDataIterator_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUniformGridAMRDataIterator_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniformGridAMRDataIterator_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUniformGridAMRDataIterator_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMRDataIterator_GoToFirstItem_08(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the beginning of the collection.
	/// </summary>
	public override void GoToFirstItem()
	{
		vtkUniformGridAMRDataIterator_GoToFirstItem_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniformGridAMRDataIterator_GoToNextItem_09(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the next item in the collection.
	/// </summary>
	public override void GoToNextItem()
	{
		vtkUniformGridAMRDataIterator_GoToNextItem_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMRDataIterator_HasCurrentMetaData_10(HandleRef pThis);

	/// <summary>
	/// Returns the meta-data associated with the current item.
	/// Note that this points to a single instance of vtkInformation object
	/// allocated by the iterator and will be changed as soon as GoToNextItem is
	/// called.
	/// </summary>
	public override int HasCurrentMetaData()
	{
		return vtkUniformGridAMRDataIterator_HasCurrentMetaData_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMRDataIterator_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUniformGridAMRDataIterator_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMRDataIterator_IsDoneWithTraversal_12(HandleRef pThis);

	/// <summary>
	/// Test whether the iterator is finished with the traversal.
	/// Returns 1 for yes, and 0 for no.
	/// It is safe to call any of the GetCurrent...() methods only when
	/// IsDoneWithTraversal() returns 0.
	/// </summary>
	public override int IsDoneWithTraversal()
	{
		return vtkUniformGridAMRDataIterator_IsDoneWithTraversal_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniformGridAMRDataIterator_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUniformGridAMRDataIterator_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMRDataIterator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUniformGridAMRDataIterator NewInstance()
	{
		vtkUniformGridAMRDataIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMRDataIterator_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniformGridAMRDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniformGridAMRDataIterator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUniformGridAMRDataIterator SafeDownCast(vtkObjectBase o)
	{
		vtkUniformGridAMRDataIterator vtkUniformGridAMRDataIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniformGridAMRDataIterator_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniformGridAMRDataIterator2 = (vtkUniformGridAMRDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniformGridAMRDataIterator2.Register(null);
			}
		}
		return vtkUniformGridAMRDataIterator2;
	}
}
