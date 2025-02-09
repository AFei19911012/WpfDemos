using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHierarchicalBoxDataSet
/// </summary>
/// <remarks>
///    Backwards compatibility class
///
///
/// An empty class for backwards compatibility
///
/// </remarks>
/// <seealso>
///
/// vtkUniformGridAM vtkOverlappingAMR vtkNonOverlappingAMR
/// </seealso>
public class vtkHierarchicalBoxDataSet : vtkOverlappingAMR
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBoxDataSet";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHierarchicalBoxDataSet()
	{
		MRClassNameKey = "class vtkHierarchicalBoxDataSet";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBoxDataSet"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHierarchicalBoxDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBoxDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHierarchicalBoxDataSet New()
	{
		vtkHierarchicalBoxDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBoxDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkHierarchicalBoxDataSet()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHierarchicalBoxDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHierarchicalBoxDataSet_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkHierarchicalBoxDataSet GetData(vtkInformation info)
	{
		vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBoxDataSet_GetData_01(info?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHierarchicalBoxDataSet2 = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHierarchicalBoxDataSet2.Register(null);
			}
		}
		return vtkHierarchicalBoxDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBoxDataSet_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve an instance of this class from an information object.
	/// </summary>
	public new static vtkHierarchicalBoxDataSet GetData(vtkInformationVector v, int i)
	{
		vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBoxDataSet_GetData_02(v?.GetCppThis() ?? default(HandleRef), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHierarchicalBoxDataSet2 = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHierarchicalBoxDataSet2.Register(null);
			}
		}
		return vtkHierarchicalBoxDataSet2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBoxDataSet_GetDataObjectType_03(HandleRef pThis);

	/// <summary>
	/// Return class name of data type (see vtkType.h for definitions).
	/// </summary>
	public override int GetDataObjectType()
	{
		return vtkHierarchicalBoxDataSet_GetDataObjectType_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalBoxDataSet_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHierarchicalBoxDataSet_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHierarchicalBoxDataSet_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHierarchicalBoxDataSet_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBoxDataSet_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHierarchicalBoxDataSet_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHierarchicalBoxDataSet_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHierarchicalBoxDataSet_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBoxDataSet_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHierarchicalBoxDataSet NewInstance()
	{
		vtkHierarchicalBoxDataSet result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBoxDataSet_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHierarchicalBoxDataSet_NewIterator_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return a new iterator (the iterator has to be deleted by user).
	/// </summary>
	public override vtkCompositeDataIterator NewIterator()
	{
		vtkCompositeDataIterator vtkCompositeDataIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBoxDataSet_NewIterator_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkHierarchicalBoxDataSet_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHierarchicalBoxDataSet SafeDownCast(vtkObjectBase o)
	{
		vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHierarchicalBoxDataSet_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHierarchicalBoxDataSet2 = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHierarchicalBoxDataSet2.Register(null);
			}
		}
		return vtkHierarchicalBoxDataSet2;
	}
}
