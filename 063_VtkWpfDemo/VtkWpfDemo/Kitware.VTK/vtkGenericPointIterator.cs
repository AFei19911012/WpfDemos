using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenericPointIterator
/// </summary>
/// <remarks>
///    iterator used to traverse points
///
/// This class (and subclasses) are used to iterate over points. Use it
/// only in conjunction with vtkGenericDataSet (i.e., the adaptor framework).
///
/// Typical use is:
/// &lt;pre&gt;
/// vtkGenericDataSet *dataset;
/// vtkGenericPointIterator *it = dataset-&gt;NewPointIterator();
/// for (it-&gt;Begin(); !it-&gt;IsAtEnd(); it-&gt;Next());
///   {
///   x=it-&gt;GetPosition();
///   }
/// &lt;/pre&gt;
/// </remarks>
public abstract class vtkGenericPointIterator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenericPointIterator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenericPointIterator()
	{
		MRClassNameKey = "class vtkGenericPointIterator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericPointIterator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenericPointIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkGenericPointIterator_Begin_01(HandleRef pThis);

	/// <summary>
	/// Move iterator to first position if any (loop initialization).
	/// </summary>
	public virtual void Begin()
	{
		vtkGenericPointIterator_Begin_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericPointIterator_GetId_02(HandleRef pThis);

	/// <summary>
	/// Return the unique identifier for the point, could be non-contiguous.
	/// \pre not_off: !IsAtEnd()
	/// </summary>
	public virtual long GetId()
	{
		return vtkGenericPointIterator_GetId_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericPointIterator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenericPointIterator_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenericPointIterator_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenericPointIterator_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericPointIterator_GetPosition_05(HandleRef pThis);

	/// <summary>
	/// Get the coordinates of the point at the current iterator position.
	/// \pre not_off: !IsAtEnd()
	/// \post result_exists: result!=0
	/// </summary>
	public virtual IntPtr GetPosition()
	{
		return vtkGenericPointIterator_GetPosition_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericPointIterator_GetPosition_06(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Get the coordinates of the point at the current iterator position.
	/// \pre not_off: !IsAtEnd()
	/// \pre x_exists: x!=0
	/// </summary>
	public virtual void GetPosition(IntPtr x)
	{
		vtkGenericPointIterator_GetPosition_06(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericPointIterator_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenericPointIterator_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericPointIterator_IsAtEnd_08(HandleRef pThis);

	/// <summary>
	/// Is the iterator at the end of traversal?
	/// </summary>
	public virtual int IsAtEnd()
	{
		return vtkGenericPointIterator_IsAtEnd_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenericPointIterator_IsTypeOf_09(string type);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenericPointIterator_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericPointIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public new vtkGenericPointIterator NewInstance()
	{
		vtkGenericPointIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericPointIterator_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenericPointIterator_Next_11(HandleRef pThis);

	/// <summary>
	/// Move the iterator to the next position in the list.
	/// \pre not_off: !IsAtEnd()
	/// </summary>
	public virtual void Next()
	{
		vtkGenericPointIterator_Next_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenericPointIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK construction and type macros.
	/// </summary>
	public new static vtkGenericPointIterator SafeDownCast(vtkObjectBase o)
	{
		vtkGenericPointIterator vtkGenericPointIterator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenericPointIterator_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenericPointIterator2 = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenericPointIterator2.Register(null);
			}
		}
		return vtkGenericPointIterator2;
	}
}
