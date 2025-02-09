using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMergeTimeFilter
/// </summary>
/// <remarks>
///    Create a multiblock containing one block per input, with unified timestep list.
///
/// vtkMergeTimeFilter takes multiple temporal datasets as input and synchronize them.
///
/// The output data is a multiblock dataset containing one block per input dataset.
/// The output timesteps is the union (or the intersection) of each input timestep lists.
/// Duplicates time values are removed, dependending on a tolerance, either absolute or relative.
///
/// When source time is exactly 0., absolute tolerance is used even in relative mode.
///
/// Note that the actual merge of timesteps is done duing the RequestInformation pass.
/// In the 'Relative' mode, inputs are processed in order and compararison is done with
/// previously processed inputs.
/// </remarks>
public class vtkMergeTimeFilter : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMergeTimeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMergeTimeFilter()
	{
		MRClassNameKey = "class vtkMergeTimeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeTimeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMergeTimeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeTimeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeTimeFilter New()
	{
		vtkMergeTimeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeTimeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeTimeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMergeTimeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMergeTimeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeTimeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMergeTimeFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeTimeFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMergeTimeFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMergeTimeFilter_GetTolerance_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance for comparing time step
	/// values to see if they are close enough to be considered
	/// identical. Default is 0.00001
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkMergeTimeFilter_GetTolerance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMergeTimeFilter_GetToleranceMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance for comparing time step
	/// values to see if they are close enough to be considered
	/// identical. Default is 0.00001
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkMergeTimeFilter_GetToleranceMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMergeTimeFilter_GetToleranceMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the tolerance for comparing time step
	/// values to see if they are close enough to be considered
	/// identical. Default is 0.00001
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkMergeTimeFilter_GetToleranceMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMergeTimeFilter_GetUseIntersection_06(HandleRef pThis);

	/// <summary>
	/// Set/Get if the merge use intersection instead of union.
	/// Default is false (union is used).
	/// </summary>
	public virtual bool GetUseIntersection()
	{
		return (vtkMergeTimeFilter_GetUseIntersection_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMergeTimeFilter_GetUseRelativeTolerance_07(HandleRef pThis);

	/// <summary>
	/// Set/Get if the tolerance is relative to previous input or absolute.
	///
	/// Default is false (absolute tolerance).
	/// </summary>
	public virtual bool GetUseRelativeTolerance()
	{
		return (vtkMergeTimeFilter_GetUseRelativeTolerance_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeTimeFilter_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMergeTimeFilter_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeTimeFilter_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMergeTimeFilter_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeTimeFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMergeTimeFilter NewInstance()
	{
		vtkMergeTimeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeTimeFilter_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeTimeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeTimeFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeTimeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkMergeTimeFilter vtkMergeTimeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeTimeFilter_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMergeTimeFilter2 = (vtkMergeTimeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMergeTimeFilter2.Register(null);
			}
		}
		return vtkMergeTimeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTimeFilter_SetTolerance_13(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the tolerance for comparing time step
	/// values to see if they are close enough to be considered
	/// identical. Default is 0.00001
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkMergeTimeFilter_SetTolerance_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTimeFilter_SetUseIntersection_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the merge use intersection instead of union.
	/// Default is false (union is used).
	/// </summary>
	public virtual void SetUseIntersection(bool _arg)
	{
		vtkMergeTimeFilter_SetUseIntersection_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTimeFilter_SetUseRelativeTolerance_15(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if the tolerance is relative to previous input or absolute.
	///
	/// Default is false (absolute tolerance).
	/// </summary>
	public virtual void SetUseRelativeTolerance(bool _arg)
	{
		vtkMergeTimeFilter_SetUseRelativeTolerance_15(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTimeFilter_UseIntersectionOff_16(HandleRef pThis);

	/// <summary>
	/// Set/Get if the merge use intersection instead of union.
	/// Default is false (union is used).
	/// </summary>
	public virtual void UseIntersectionOff()
	{
		vtkMergeTimeFilter_UseIntersectionOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTimeFilter_UseIntersectionOn_17(HandleRef pThis);

	/// <summary>
	/// Set/Get if the merge use intersection instead of union.
	/// Default is false (union is used).
	/// </summary>
	public virtual void UseIntersectionOn()
	{
		vtkMergeTimeFilter_UseIntersectionOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTimeFilter_UseRelativeToleranceOff_18(HandleRef pThis);

	/// <summary>
	/// Set/Get if the tolerance is relative to previous input or absolute.
	///
	/// Default is false (absolute tolerance).
	/// </summary>
	public virtual void UseRelativeToleranceOff()
	{
		vtkMergeTimeFilter_UseRelativeToleranceOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeTimeFilter_UseRelativeToleranceOn_19(HandleRef pThis);

	/// <summary>
	/// Set/Get if the tolerance is relative to previous input or absolute.
	///
	/// Default is false (absolute tolerance).
	/// </summary>
	public virtual void UseRelativeToleranceOn()
	{
		vtkMergeTimeFilter_UseRelativeToleranceOn_19(GetCppThis());
	}
}
