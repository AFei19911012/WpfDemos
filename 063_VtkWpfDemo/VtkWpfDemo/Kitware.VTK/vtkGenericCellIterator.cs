using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericCellIterator
/// </summary>
/// <remarks>
///    iterator used to traverse cells
///
/// This class (and subclasses) are used to iterate over cells. Use it
/// only in conjunction with vtkGenericDataSet (i.e., the adaptor framework).
///
/// Typical use is:
/// &lt;pre&gt;
/// vtkGenericDataSet *dataset;
/// vtkGenericCellIterator *it = dataset-&gt;NewCellIterator(2);
/// for (it-&gt;Begin(); !it-&gt;IsAtEnd(); it-&gt;Next());
///   {
///   spec=it-&gt;GetCell();
///   }
/// &lt;/pre&gt;
/// </remarks>
public abstract class vtkGenericCellIterator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCellIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericCellIterator()
	{
		MRClassNameKey = "class vtkGenericCellIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCellIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericCellIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkGenericCellIterator_Begin_01(HandleRef pThis);

	/// <summary>
	/// Move iterator to first position if any (loop initialization).
	/// </summary>
	public virtual void Begin()
	{
		vtkGenericCellIterator_Begin_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellIterator_GetCell_02(HandleRef pThis, HandleRef c);

	/// <summary>
	/// Get the cell at current position. The cell should be instantiated
	/// with the NewCell() method.
	/// \pre not_at_end: !IsAtEnd()
	/// \pre c_exists: c!=0
	/// THREAD SAFE
	/// </summary>
	public virtual void GetCell(vtkGenericAdaptorCell c)
	{
		vtkGenericCellIterator_GetCell_02(GetCppThis(), c?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCellIterator_GetCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the cell at the current traversal position.
	/// NOT THREAD SAFE
	/// \pre not_at_end: !IsAtEnd()
	/// \post result_exits: result!=0
	/// </summary>
	public virtual vtkGenericAdaptorCell GetCell()
	{
		vtkGenericAdaptorCell vtkGenericAdaptorCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCellIterator_GetCell_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAdaptorCell2 = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAdaptorCell2.Register(null);
			}
		}
		return vtkGenericAdaptorCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericCellIterator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericCellIterator_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericCellIterator_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericCellIterator_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCellIterator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericCellIterator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCellIterator_IsAtEnd_07(HandleRef pThis);

	/// <summary>
	/// Is the iterator at the end of traversal?
	/// </summary>
	public virtual int IsAtEnd()
	{
		return vtkGenericCellIterator_IsAtEnd_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericCellIterator_IsTypeOf_08(string type);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericCellIterator_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCellIterator_NewCell_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an empty cell. The user is responsible for deleting it.
	/// \post result_exists: result!=0
	/// </summary>
	public virtual vtkGenericAdaptorCell NewCell()
	{
		vtkGenericAdaptorCell vtkGenericAdaptorCell2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCellIterator_NewCell_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericAdaptorCell2 = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericAdaptorCell2.Register(null);
			}
		}
		return vtkGenericAdaptorCell2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCellIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public new vtkGenericCellIterator NewInstance()
	{
		vtkGenericCellIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCellIterator_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericCellIterator_Next_11(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the next position in the list.
	/// \pre not_at_end: !IsAtEnd()
	/// </summary>
	public virtual void Next()
	{
		vtkGenericCellIterator_Next_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericCellIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public new static vtkGenericCellIterator SafeDownCast(vtkObjectBase o)
	{
		vtkGenericCellIterator vtkGenericCellIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericCellIterator_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericCellIterator2 = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericCellIterator2.Register(null);
			}
		}
		return vtkGenericCellIterator2;
	}
}
