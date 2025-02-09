using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPOutlineCornerFilter
/// </summary>
/// <remarks>
///    create wireframe outline corners for arbitrary data set
///
/// vtkPOutlineCornerFilter works like vtkOutlineCornerFilter,
/// but it looks for data
/// partitions in other processes.  It assumes the filter is operated
/// in a data parallel pipeline.
/// </remarks>
public class vtkPOutlineCornerFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPOutlineCornerFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPOutlineCornerFilter()
	{
		MRClassNameKey = "class vtkPOutlineCornerFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOutlineCornerFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPOutlineCornerFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPOutlineCornerFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct outline corner filter with default corner factor = 0.2
	/// </summary>
	public new static vtkPOutlineCornerFilter New()
	{
		vtkPOutlineCornerFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPOutlineCornerFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct outline corner filter with default corner factor = 0.2
	/// </summary>
	public vtkPOutlineCornerFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPOutlineCornerFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkPOutlineCornerFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set and get the controller.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPOutlineCornerFilter_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkPOutlineCornerFilter_GetCornerFactor_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the corners
	/// to the length of the corresponding bounds
	/// Typically vtkSetClampMacro(CornerFactor, double, 0.001, 0.5) would
	/// used but since we are chaining this to an internal method we rewrite
	/// the code in the macro
	/// </summary>
	public virtual double GetCornerFactor()
	{
		return vtkPOutlineCornerFilter_GetCornerFactor_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPOutlineCornerFilter_GetCornerFactorMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the corners
	/// to the length of the corresponding bounds
	/// Typically vtkSetClampMacro(CornerFactor, double, 0.001, 0.5) would
	/// used but since we are chaining this to an internal method we rewrite
	/// the code in the macro
	/// </summary>
	public virtual double GetCornerFactorMaxValue()
	{
		return vtkPOutlineCornerFilter_GetCornerFactorMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPOutlineCornerFilter_GetCornerFactorMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the corners
	/// to the length of the corresponding bounds
	/// Typically vtkSetClampMacro(CornerFactor, double, 0.001, 0.5) would
	/// used but since we are chaining this to an internal method we rewrite
	/// the code in the macro
	/// </summary>
	public virtual double GetCornerFactorMinValue()
	{
		return vtkPOutlineCornerFilter_GetCornerFactorMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPOutlineCornerFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPOutlineCornerFilter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPOutlineCornerFilter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPOutlineCornerFilter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPOutlineCornerFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPOutlineCornerFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPOutlineCornerFilter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPOutlineCornerFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPOutlineCornerFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPOutlineCornerFilter NewInstance()
	{
		vtkPOutlineCornerFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPOutlineCornerFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPOutlineCornerFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPOutlineCornerFilter SafeDownCast(vtkObjectBase o)
	{
		vtkPOutlineCornerFilter vtkPOutlineCornerFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPOutlineCornerFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPOutlineCornerFilter2 = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPOutlineCornerFilter2.Register(null);
			}
		}
		return vtkPOutlineCornerFilter2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPOutlineCornerFilter_SetController_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set and get the controller.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkPOutlineCornerFilter_SetController_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPOutlineCornerFilter_SetCornerFactor_13(HandleRef pThis, double cornerFactor);

	/// <summary>
	/// Set/Get the factor that controls the relative size of the corners
	/// to the length of the corresponding bounds
	/// Typically vtkSetClampMacro(CornerFactor, double, 0.001, 0.5) would
	/// used but since we are chaining this to an internal method we rewrite
	/// the code in the macro
	/// </summary>
	public virtual void SetCornerFactor(double cornerFactor)
	{
		vtkPOutlineCornerFilter_SetCornerFactor_13(GetCppThis(), cornerFactor);
	}
}
