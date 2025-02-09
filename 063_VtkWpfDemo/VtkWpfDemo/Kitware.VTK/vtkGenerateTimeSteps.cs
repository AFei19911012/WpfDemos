using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGenerateTimeSteps
/// </summary>
/// <remarks>
///    Generate timesteps on any input
///
/// A vtkPassInputTypeAlgorithm that add timesteps during the request information
/// pass and just shallow copy its input to its output. Input timesteps are completely
/// ignored and the first timestep will be requested if any.
/// </remarks>
public class vtkGenerateTimeSteps : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGenerateTimeSteps";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGenerateTimeSteps()
	{
		MRClassNameKey = "class vtkGenerateTimeSteps";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenerateTimeSteps"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGenerateTimeSteps(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenerateTimeSteps_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenerateTimeSteps New()
	{
		vtkGenerateTimeSteps result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenerateTimeSteps_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenerateTimeSteps)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGenerateTimeSteps()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGenerateTimeSteps_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateTimeSteps_AddTimeStepValue_01(HandleRef pThis, double timeStepValue);

	/// <summary>
	/// Add a time step value.
	/// </summary>
	public void AddTimeStepValue(double timeStepValue)
	{
		vtkGenerateTimeSteps_AddTimeStepValue_01(GetCppThis(), timeStepValue);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateTimeSteps_ClearTimeStepValues_02(HandleRef pThis);

	/// <summary>
	/// Clear the time step values
	/// </summary>
	public void ClearTimeStepValues()
	{
		vtkGenerateTimeSteps_ClearTimeStepValues_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateTimeSteps_GenerateTimeStepValues_03(HandleRef pThis, double begin, double end, double step);

	/// <summary>
	/// Generate a range of values in [begin, end) with a step size of 'step'
	/// </summary>
	public void GenerateTimeStepValues(double begin, double end, double step)
	{
		vtkGenerateTimeSteps_GenerateTimeStepValues_03(GetCppThis(), begin, end, step);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenerateTimeSteps_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGenerateTimeSteps_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGenerateTimeSteps_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGenerateTimeSteps_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenerateTimeSteps_GetNumberOfTimeSteps_06(HandleRef pThis);

	/// <summary>
	/// Get the number of time steps that will be extracted
	/// </summary>
	public int GetNumberOfTimeSteps()
	{
		return vtkGenerateTimeSteps_GetNumberOfTimeSteps_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateTimeSteps_GetTimeStepValues_07(HandleRef pThis, IntPtr timeStepValues);

	/// <summary>
	/// Get/Set an array of time step values. For the Get function,
	/// timeStepValues should be big enough for GetNumberOfTimeSteps() values.
	/// </summary>
	public void GetTimeStepValues(IntPtr timeStepValues)
	{
		vtkGenerateTimeSteps_GetTimeStepValues_07(GetCppThis(), timeStepValues);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenerateTimeSteps_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGenerateTimeSteps_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGenerateTimeSteps_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGenerateTimeSteps_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenerateTimeSteps_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGenerateTimeSteps NewInstance()
	{
		vtkGenerateTimeSteps result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenerateTimeSteps_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGenerateTimeSteps)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGenerateTimeSteps_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGenerateTimeSteps SafeDownCast(vtkObjectBase o)
	{
		vtkGenerateTimeSteps vtkGenerateTimeSteps2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGenerateTimeSteps_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGenerateTimeSteps2 = (vtkGenerateTimeSteps)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGenerateTimeSteps2.Register(null);
			}
		}
		return vtkGenerateTimeSteps2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGenerateTimeSteps_SetTimeStepValues_13(HandleRef pThis, int count, IntPtr timeStepValues);

	/// <summary>
	/// Get/Set an array of time step values. For the Get function,
	/// timeStepValues should be big enough for GetNumberOfTimeSteps() values.
	/// </summary>
	public void SetTimeStepValues(int count, IntPtr timeStepValues)
	{
		vtkGenerateTimeSteps_SetTimeStepValues_13(GetCppThis(), count, timeStepValues);
	}
}
