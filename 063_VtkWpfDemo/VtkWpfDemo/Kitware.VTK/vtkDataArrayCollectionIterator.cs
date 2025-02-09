using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataArrayCollectionIterator
/// </summary>
/// <remarks>
///    iterator through a vtkDataArrayCollection.
///
/// vtkDataArrayCollectionIterator provides an implementation of
/// vtkCollectionIterator which allows the items to be retrieved with
/// the proper subclass pointer type for vtkDataArrayCollection.
/// </remarks>
public class vtkDataArrayCollectionIterator : vtkCollectionIterator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataArrayCollectionIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataArrayCollectionIterator()
	{
		MRClassNameKey = "class vtkDataArrayCollectionIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArrayCollectionIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataArrayCollectionIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArrayCollectionIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataArrayCollectionIterator New()
	{
		vtkDataArrayCollectionIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArrayCollectionIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataArrayCollectionIterator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataArrayCollectionIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArrayCollectionIterator_GetDataArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the item at the current iterator position.  Valid only when
	/// IsDoneWithTraversal() returns 1.
	/// </summary>
	public vtkDataArray GetDataArray()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArrayCollectionIterator_GetDataArray_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataArrayCollectionIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataArrayCollectionIterator_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataArrayCollectionIterator_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataArrayCollectionIterator_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArrayCollectionIterator_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataArrayCollectionIterator_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataArrayCollectionIterator_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataArrayCollectionIterator_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArrayCollectionIterator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataArrayCollectionIterator NewInstance()
	{
		vtkDataArrayCollectionIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArrayCollectionIterator_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataArrayCollectionIterator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataArrayCollectionIterator SafeDownCast(vtkObjectBase o)
	{
		vtkDataArrayCollectionIterator vtkDataArrayCollectionIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataArrayCollectionIterator_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArrayCollectionIterator2 = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArrayCollectionIterator2.Register(null);
			}
		}
		return vtkDataArrayCollectionIterator2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArrayCollectionIterator_SetCollection_09(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the collection over which to iterate.
	/// </summary>
	public override void SetCollection(vtkCollection arg0)
	{
		vtkDataArrayCollectionIterator_SetCollection_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataArrayCollectionIterator_SetCollection_10(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the collection over which to iterate.
	/// </summary>
	public void SetCollection(vtkDataArrayCollection arg0)
	{
		vtkDataArrayCollectionIterator_SetCollection_10(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
