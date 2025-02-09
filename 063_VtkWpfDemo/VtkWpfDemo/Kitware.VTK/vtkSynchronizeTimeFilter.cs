using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSynchronizeTimeFilter
/// </summary>
/// <remarks>
///    Set "close" time step values from the second input to the first
///
/// Synchronize time step values in the first input to time step
/// values in the second input that are considered close enough.
/// The outputted data set is from the first input and the number of
/// output time steps is also equal to the number of time steps in
/// the first input. Time step values in the first input that are
/// "close" to time step values in the second input are replaced
/// with the value from the second input. Close is determined to
/// be if the difference is less than RelativeTolerance multiplied
/// by the time range of the first input.
/// </remarks>
public class vtkSynchronizeTimeFilter : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizeTimeFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSynchronizeTimeFilter()
	{
		MRClassNameKey = "class vtkSynchronizeTimeFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizeTimeFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSynchronizeTimeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSynchronizeTimeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSynchronizeTimeFilter New()
	{
		vtkSynchronizeTimeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSynchronizeTimeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSynchronizeTimeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSynchronizeTimeFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSynchronizeTimeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkSynchronizeTimeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSynchronizeTimeFilter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSynchronizeTimeFilter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSynchronizeTimeFilter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSynchronizeTimeFilter_GetRelativeTolerance_03(HandleRef pThis);

	/// <summary>
	/// Set/get the relative tolerance for comparing time step
	/// values to see if they are close enough to be considered
	/// identical.
	/// </summary>
	public virtual double GetRelativeTolerance()
	{
		return vtkSynchronizeTimeFilter_GetRelativeTolerance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSynchronizeTimeFilter_GetRelativeToleranceMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Set/get the relative tolerance for comparing time step
	/// values to see if they are close enough to be considered
	/// identical.
	/// </summary>
	public virtual double GetRelativeToleranceMaxValue()
	{
		return vtkSynchronizeTimeFilter_GetRelativeToleranceMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSynchronizeTimeFilter_GetRelativeToleranceMinValue_05(HandleRef pThis);

	/// <summary>
	/// Set/get the relative tolerance for comparing time step
	/// values to see if they are close enough to be considered
	/// identical.
	/// </summary>
	public virtual double GetRelativeToleranceMinValue()
	{
		return vtkSynchronizeTimeFilter_GetRelativeToleranceMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizeTimeFilter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSynchronizeTimeFilter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSynchronizeTimeFilter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSynchronizeTimeFilter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSynchronizeTimeFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSynchronizeTimeFilter NewInstance()
	{
		vtkSynchronizeTimeFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSynchronizeTimeFilter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSynchronizeTimeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSynchronizeTimeFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSynchronizeTimeFilter SafeDownCast(vtkObjectBase o)
	{
		vtkSynchronizeTimeFilter vtkSynchronizeTimeFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSynchronizeTimeFilter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSynchronizeTimeFilter2 = (vtkSynchronizeTimeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSynchronizeTimeFilter2.Register(null);
			}
		}
		return vtkSynchronizeTimeFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizeTimeFilter_SetRelativeTolerance_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the relative tolerance for comparing time step
	/// values to see if they are close enough to be considered
	/// identical.
	/// </summary>
	public virtual void SetRelativeTolerance(double _arg)
	{
		vtkSynchronizeTimeFilter_SetRelativeTolerance_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSynchronizeTimeFilter_SetSourceConnection_12(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Specify the input that we may potentially replace time
	/// steps with. SetInputConnection() should be used for providing the data
	/// set that will actually be output from this filter.
	/// </summary>
	public void SetSourceConnection(vtkAlgorithmOutput algOutput)
	{
		vtkSynchronizeTimeFilter_SetSourceConnection_12(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}
}
