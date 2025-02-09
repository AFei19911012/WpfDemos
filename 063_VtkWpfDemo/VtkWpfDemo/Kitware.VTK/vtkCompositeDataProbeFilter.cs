using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositeDataProbeFilter
/// </summary>
/// <remarks>
///    subclass of vtkProbeFilter which supports
/// composite datasets in the input.
///
/// vtkCompositeDataProbeFilter supports probing into multi-group datasets.
/// It sequentially probes through each concrete dataset within the composite
/// probing at only those locations at which there were no hits when probing
/// earlier datasets. For Hierarchical datasets, this traversal through leaf
/// datasets is done in reverse order of levels i.e. highest level first.
/// To keep the ability of using locators with a composite input, we use a map that
/// maps a dataset belonging to the composite input to its FindCell strategy.
///
/// When dealing with composite datasets, partial arrays are common i.e.
/// data-arrays that are not available in all of the blocks. By default, this
/// filter only passes those point and cell data-arrays that are available in all
/// the blocks i.e. partial array are removed.
/// When PassPartialArrays is turned on, this behavior is changed to take a
/// union of all arrays present thus partial arrays are passed as well. However,
/// for composite dataset input, this filter still produces a non-composite
/// output. For all those locations in a block of where a particular data array
/// is missing, this filter uses vtkMath::Nan() for double and float arrays,
/// while 0 for all other types of arrays i.e int, char etc.
/// </remarks>
public class vtkCompositeDataProbeFilter : vtkProbeFilter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataProbeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeDataProbeFilter()
	{
		MRClassNameKey = "class vtkCompositeDataProbeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataProbeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeDataProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataProbeFilter New()
	{
		vtkCompositeDataProbeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataProbeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCompositeDataProbeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompositeDataProbeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataProbeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeDataProbeFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeDataProbeFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeDataProbeFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeDataProbeFilter_GetPassPartialArrays_03(HandleRef pThis);

	/// <summary>
	/// When dealing with composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in
	/// all the blocks i.e. partial array are removed.  When PassPartialArrays is
	/// turned on, this behavior is changed to take a union of all arrays present
	/// thus partial arrays are passed as well. However, for composite dataset
	/// input, this filter still produces a non-composite output. For all those
	/// locations in a block of where a particular data array is missing, this
	/// filter uses vtkMath::Nan() for double and float arrays, while 0 for all
	/// other types of arrays i.e int, char etc.
	/// </summary>
	public virtual bool GetPassPartialArrays()
	{
		return (vtkCompositeDataProbeFilter_GetPassPartialArrays_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataProbeFilter_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeDataProbeFilter_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeDataProbeFilter_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeDataProbeFilter_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataProbeFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositeDataProbeFilter NewInstance()
	{
		vtkCompositeDataProbeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataProbeFilter_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataProbeFilter_PassPartialArraysOff_08(HandleRef pThis);

	/// <summary>
	/// When dealing with composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in
	/// all the blocks i.e. partial array are removed.  When PassPartialArrays is
	/// turned on, this behavior is changed to take a union of all arrays present
	/// thus partial arrays are passed as well. However, for composite dataset
	/// input, this filter still produces a non-composite output. For all those
	/// locations in a block of where a particular data array is missing, this
	/// filter uses vtkMath::Nan() for double and float arrays, while 0 for all
	/// other types of arrays i.e int, char etc.
	/// </summary>
	public virtual void PassPartialArraysOff()
	{
		vtkCompositeDataProbeFilter_PassPartialArraysOff_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataProbeFilter_PassPartialArraysOn_09(HandleRef pThis);

	/// <summary>
	/// When dealing with composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in
	/// all the blocks i.e. partial array are removed.  When PassPartialArrays is
	/// turned on, this behavior is changed to take a union of all arrays present
	/// thus partial arrays are passed as well. However, for composite dataset
	/// input, this filter still produces a non-composite output. For all those
	/// locations in a block of where a particular data array is missing, this
	/// filter uses vtkMath::Nan() for double and float arrays, while 0 for all
	/// other types of arrays i.e int, char etc.
	/// </summary>
	public virtual void PassPartialArraysOn()
	{
		vtkCompositeDataProbeFilter_PassPartialArraysOn_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeDataProbeFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeDataProbeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeDataProbeFilter vtkCompositeDataProbeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeDataProbeFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeDataProbeFilter2 = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeDataProbeFilter2.Register(null);
			}
		}
		return vtkCompositeDataProbeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeDataProbeFilter_SetPassPartialArrays_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// When dealing with composite datasets, partial arrays are common i.e.
	/// data-arrays that are not available in all of the blocks. By default, this
	/// filter only passes those point and cell data-arrays that are available in
	/// all the blocks i.e. partial array are removed.  When PassPartialArrays is
	/// turned on, this behavior is changed to take a union of all arrays present
	/// thus partial arrays are passed as well. However, for composite dataset
	/// input, this filter still produces a non-composite output. For all those
	/// locations in a block of where a particular data array is missing, this
	/// filter uses vtkMath::Nan() for double and float arrays, while 0 for all
	/// other types of arrays i.e int, char etc.
	/// </summary>
	public virtual void SetPassPartialArrays(bool _arg)
	{
		vtkCompositeDataProbeFilter_SetPassPartialArrays_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
