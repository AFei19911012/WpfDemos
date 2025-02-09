using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkAlignImageDataSetFilter
/// </summary>
/// <remarks>
///  align collection of image datasets to use a global origin
///
/// When dealing with a collection of image datasets, either in a composite
/// dataset or in a distributed environment, it is not uncommon to have each
/// dataset have its own unique origin such that the extents for each start at 0.
/// However, if the images are parts of a whole, then several filters like
/// vtkExtractVOI that simply use extents fail to execute correctly. Such
/// filters require that all parts use the same global origin and set local
/// extents accordingly. This filter can be used to align such image
/// datasets. Essentially, this filter ensures all image datasets have the same
/// origin and each blocks extents are set relative to that origin. This requires
/// that all images have the same spacing.
/// </remarks>
public class vtkAlignImageDataSetFilter : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAlignImageDataSetFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAlignImageDataSetFilter()
	{
		MRClassNameKey = "class vtkAlignImageDataSetFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAlignImageDataSetFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAlignImageDataSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlignImageDataSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAlignImageDataSetFilter New()
	{
		vtkAlignImageDataSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlignImageDataSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAlignImageDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAlignImageDataSetFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAlignImageDataSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlignImageDataSetFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the controller to use. By default
	/// vtkMultiProcessController::GlobalController will be used.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlignImageDataSetFilter_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlignImageDataSetFilter_GetMinimumExtent_02(HandleRef pThis);

	/// <summary>
	/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
	/// </summary>
	public virtual int[] GetMinimumExtent()
	{
		IntPtr intPtr = vtkAlignImageDataSetFilter_GetMinimumExtent_02(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlignImageDataSetFilter_GetMinimumExtent_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
	/// </summary>
	public virtual void GetMinimumExtent(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkAlignImageDataSetFilter_GetMinimumExtent_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlignImageDataSetFilter_GetMinimumExtent_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
	/// </summary>
	public virtual void GetMinimumExtent(IntPtr _arg)
	{
		vtkAlignImageDataSetFilter_GetMinimumExtent_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAlignImageDataSetFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAlignImageDataSetFilter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAlignImageDataSetFilter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAlignImageDataSetFilter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlignImageDataSetFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAlignImageDataSetFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAlignImageDataSetFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAlignImageDataSetFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlignImageDataSetFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAlignImageDataSetFilter NewInstance()
	{
		vtkAlignImageDataSetFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlignImageDataSetFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAlignImageDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAlignImageDataSetFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAlignImageDataSetFilter SafeDownCast(vtkObjectBase o)
	{
		vtkAlignImageDataSetFilter vtkAlignImageDataSetFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAlignImageDataSetFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlignImageDataSetFilter2 = (vtkAlignImageDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlignImageDataSetFilter2.Register(null);
			}
		}
		return vtkAlignImageDataSetFilter2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlignImageDataSetFilter_SetController_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the controller to use. By default
	/// vtkMultiProcessController::GlobalController will be used.
	/// </summary>
	public void SetController(vtkMultiProcessController arg0)
	{
		vtkAlignImageDataSetFilter_SetController_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlignImageDataSetFilter_SetMinimumExtent_13(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
	/// </summary>
	public virtual void SetMinimumExtent(int _arg1, int _arg2, int _arg3)
	{
		vtkAlignImageDataSetFilter_SetMinimumExtent_13(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAlignImageDataSetFilter_SetMinimumExtent_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
	/// </summary>
	public virtual void SetMinimumExtent(IntPtr _arg)
	{
		vtkAlignImageDataSetFilter_SetMinimumExtent_14(GetCppThis(), _arg);
	}
}
